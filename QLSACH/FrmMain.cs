using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLSACH
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmThemSach f = new FrmThemSach();
            nhungForm(f);
        }

        public void nhungForm(Form f)
        {
            this.pnMain.Controls.Clear();
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.TopLevel = false;
            f.Visible = true;

            f.Dock = System.Windows.Forms.DockStyle.None;

            this.pnMain.Controls.Add(f);
            this.pnMain.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnMain.Controls.Clear();
            this.pnMain.Controls.Add(this.lbTieuDe);
            this.pnMain.Controls.Add(this.btnThem);
            this.pnMain.Controls.Add(this.btnXoa);
            this.pnMain.Controls.Add(this.btnChiTiet);
            this.pnMain.Controls.Add(this.picBook);
            this.pnMain.Controls.Add(this.dgSach);
            this.pnMain.Controls.Add(this.pnTacGia);
            this.pnMain.Controls.Add(this.pnTenSach);
            pnMain.Show();
            loadForm();
        }

        public void loadForm()
        {
            DataProvider dp = new DataProvider();
            string sql = "select MaSach,TenSach,TacGia,HinhAnh from SACH";
            DataTable dt = dp.GetDataTable(sql);
            this.dgSach.DataSource = dt;

            if(this.dgSach.Rows.Count >0)
            {
                hienThi(0); 
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            loadForm();
        }

        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.RowIndex<this.dgSach.Rows.Count-1)
            {
                hienThi(e.RowIndex);
            }
        }

        public void hienThi(int index)
        {
            this.lbMaSach.Text = this.dgSach.Rows[index].Cells[0].Value.ToString();
            this.lbTenSach.Text = this.dgSach.Rows[index].Cells[1].Value.ToString();
            this.lbTacGia.Text = this.dgSach.Rows[index].Cells[2].Value.ToString();
            this.picBook.Image = LopDungChung.byteSangAnh((byte[])this.dgSach.Rows[index].Cells[3].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa quyển sách"+lbTenSach.Text+" này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                DataProvider dp = new DataProvider();
                string sql = "delete from LOAISACH where MaSach ='" + lbMaSach.Text + "'";
                dp.ExeNoQuery(sql);

                sql = "delete from SACH where MaSach = '" + lbMaSach.Text + "'";
                dp.ExeNoQuery(sql);

                MessageBox.Show("Xóa thành công");
                loadForm();
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FrmChiTietSach f = new FrmChiTietSach(this.lbMaSach.Text);
            nhungForm(f);
        }
    }
}
