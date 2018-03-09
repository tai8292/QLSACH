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
    public partial class FrmTheLoai : Form
    {
        public FrmTheLoai()
        {
            InitializeComponent();
        }

        public void frmLoad()
        {
            DataProvider dp = new DataProvider();
            string sql = "select * from THELOAI";
            DataTable dt = dp.GetDataTable(sql);
            this.dgTheLoai.DataSource = dt;

           if (this.dgTheLoai.Rows.Count > 0)
           {
               loadData(0);
           }
        }

        public void loadData(int i)
        {
            this.txt_MaTheLoai.Text = this.dgTheLoai.Rows[i].Cells[0].Value.ToString();
            this.txt_TenTheLoai.Text = this.dgTheLoai.Rows[i].Cells[1].Value.ToString();
        }

        private void dgTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgTheLoai.Rows.Count - 1)
            {
                loadData(e.RowIndex);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_ThemTheLoai f = new frm_ThemTheLoai();
            f.ShowDialog();
            frmLoad();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Thể Loại " + txt_MaTheLoai.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataProvider dp = new DataProvider();
                string sql = "select count(*) from LoaiSach where MaLoaiSach ='" + txt_MaTheLoai.Text + "'";
                int kq =dp.ExeScalar(sql);
                if (kq == 0)
                {
                    sql = "delete from THELOAI where MaLoaiSach ='" + txt_MaTheLoai.Text + "'";
                    dp.ExeNoQuery(sql);
                    MessageBox.Show("Thể loại đã được xóa");
                    frmLoad();
                }
                else
                {
                    MessageBox.Show("Thể loại đang được sử dụng, không được xóa");
                }
            }
        }



        private void FrmTheLoai_Load(object sender, EventArgs e)
        {
            frmLoad();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn lưu chỉnh sửa này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataProvider dp = new DataProvider();
                string sql = "update THELOAI set TenTheLoai =N'" + txt_TenTheLoai.Text + "'where MaLoaiSach ='" + txt_MaTheLoai.Text + "'";
                dp.ExeNoQuery(sql);
                MessageBox.Show("Chỉnh sửa thành công");
                frmLoad();
            }
        }

        private void txt_giatri_TextChanged(object sender, EventArgs e)
        {
            string giaTri = txt_giatri.Text;
            if (txt_giatri.Text=="")
            {
                frmLoad();
            }
            else
            {
                DataProvider dp = new DataProvider();
                string sql = "select MaLoaiSach, TenTheLoai from THELOAI where MaLoaiSach like '%" + giaTri + "%' or MaLoaiSach like '%" + giaTri + "%' or TenTheLoai like '%" + giaTri + "%'";
                this.dgTheLoai.DataSource = dp.GetDataTable(sql);
            }
        }
    }
}
