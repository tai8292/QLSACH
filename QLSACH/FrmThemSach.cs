using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSACH
{
    public partial class FrmThemSach : Form
    {
        public FrmThemSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.anh.ShowDialog();
            this.hinhAnh.Image = Image.FromFile(this.anh.FileName);

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            this.txtTenSach.Clear();
            this.txtTacGia.Clear();
            this.txtMoTa.Clear();

            this.txtMaSach.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();

            string maSach = this.txtMaSach.Text.ToString();
            string tenSach = this.txtTenSach.Text.ToString();
            string tacGia = this.txtTacGia.Text.ToString();
            string moTa = this.txtMoTa.Text.ToString();
            string nhaXuatBan = this.cbNhaXuatBan.SelectedValue.ToString();
            string ngayXuatBan = this.ngayXuatBan.Value.ToString();
            byte[] anh = anhSangByte(this.hinhAnh.Image);

            string sql = "insert into SACH(MaSach,TenSach,TacGia,NgayXuatBan,MaNhaXuatBan,HinhAnh,MoTa) values('" + maSach + "','" + tenSach + "','"+tacGia+"','" + ngayXuatBan + "','" + nhaXuatBan + "','" + Convert.ToBase64String(anh) + "','" + moTa + "')";
            dp.ExeNoQuery(sql);

            //get the loai
            List<string> listTheLoai = new List<string>();
            foreach (DataRowView i in this.lbTheLoai.SelectedItems)
                listTheLoai.Add(i["MaLoaiSach"].ToString());

            for(int i=0;i<listTheLoai.Count;i++)
            {
                sql = "insert into LOAISACH values('" + maSach + "','" + listTheLoai[i] + "')";
                dp.ExeNoQuery(sql);
            }
        }

        private void FrmThemSach_Load(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            string sql = "select * from NHAXUATBAN";
            DataTable dt = dp.GetDataTable(sql);
            this.cbNhaXuatBan.DataSource = dt;
            this.cbNhaXuatBan.ValueMember = "MaNhaXuatBan";
            this.cbNhaXuatBan.DisplayMember = "TenNhaXuatBan";

            sql = "select * from THELOAI";
            dt = dp.GetDataTable(sql);
            this.lbTheLoai.DataSource = dt;
            this.lbTheLoai.ValueMember = "MaLoaiSach";
            this.lbTheLoai.DisplayMember = "TenTheLoai";
        }

        public byte[] anhSangByte(Image hinhAnh)
        {
            MemoryStream ms = new MemoryStream();
            hinhAnh.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }
    }
}
