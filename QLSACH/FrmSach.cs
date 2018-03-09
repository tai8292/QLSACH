using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSACH
{
    public partial class FrmSach : Form
    {
        public FrmSach()
        {
            InitializeComponent();
        }

        public void frmLoad()
        {
            DataProvider dp = new DataProvider();
            string sql = "select MaSach,TenSach,TacGia,HinhAnh from SACH";
            DataTable dt = dp.GetDataTable(sql);
            this.dgSach.DataSource = dt;

            if(this.dgSach.Rows.Count>0)
            {
                loadData(0);
            }
        }

        public void loadData(int i)
        {
            this.lbMaSach.Text = this.dgSach.Rows[i].Cells[0].Value.ToString();
            this.lbTenSach.Text = this.dgSach.Rows[i].Cells[1].Value.ToString();
            this.lbTacGia.Text = this.dgSach.Rows[i].Cells[2].Value.ToString();
            this.picBook.Image = LopDungChung.byteSangAnh((byte[])this.dgSach.Rows[i].Cells[3].Value);
        }

        private void FrmSach_Load(object sender, EventArgs e)
        {
            frmLoad();
        }

        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.RowIndex<this.dgSach.Rows.Count-1)
            {
                loadData(e.RowIndex);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FrmChiTietSach f = new FrmChiTietSach(this.lbMaSach.Text);
            f.ShowDialog();
            frmLoad();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemSach f = new FrmThemSach();
            f.ShowDialog();
            frmLoad();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa Sách "+lbTenSach.Text+" không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataProvider dp = new DataProvider();
                string sql = "delete from LOAISACH where MaSach ='" + lbMaSach.Text + "'";
                dp.ExeNoQuery(sql);

                sql = "delete from SACH where MaSach ='" + lbMaSach.Text + "'";
                dp.ExeNoQuery(sql);
                MessageBox.Show("Sách đã được xóa");
                frmLoad();
            }
        }

        private void txtGiaTriTimKiem_TextChanged(object sender, EventArgs e)
        {
            string giaTri = txtGiaTriTimKiem.Text;
            if (giaTri != "")
            {
                DataProvider dp = new DataProvider();
                string sql = "select MaSach,TenSach,TacGia,HinhAnh from SACH where MaSach like '%" + giaTri + "%' or TenSach like '%" + giaTri + "%' or TacGia like '%"+giaTri+"%'";
                this.dgSach.DataSource = dp.GetDataTable(sql);
            }
            else
            {
                frmLoad();
            }
        }
    }
}
