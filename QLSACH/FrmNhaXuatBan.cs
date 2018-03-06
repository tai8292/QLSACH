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
    public partial class FrmNhaXuatBan : Form
    {
        public FrmNhaXuatBan()
        {
            InitializeComponent();
        }

        public void loadFrom()
        {
            DataProvider dp = new DataProvider();
            string sql = "select * from NHAXUATBAN";
            DataTable dt = dp.GetDataTable(sql);
            this.dgNhaXuatBan.DataSource = dt;
                
            if (this.dgNhaXuatBan.Rows.Count > 0)
            {
                loadData(0);
            }
        }

        private void FrmNhaXuatBan_Load(object sender, EventArgs e)
        {
            loadFrom();
        }

        public void loadData(int i)
        {
            this.txtMaNhaXuatBan.Text = this.dgNhaXuatBan.Rows[i].Cells[0].Value.ToString();
            this.txtTenNhaXuatBan.Text = this.dgNhaXuatBan.Rows[i].Cells[1].Value.ToString();
            this.txtSdt.Text = this.dgNhaXuatBan.Rows[i].Cells[2].Value.ToString();
            this.txtDiaChi.Text = this.dgNhaXuatBan.Rows[i].Cells[3].Value.ToString();
        }

        private void dgNhaXuatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && e.RowIndex<this.dgNhaXuatBan.Rows.Count-1)
            {
                loadData(e.RowIndex);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn lưu chỉnh sửa này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataProvider dp = new DataProvider();
                string sql = "update NHAXUATBAN set TenNhaXuatBan =N'" + txtTenNhaXuatBan.Text + "',Sdt ='" + txtSdt.Text + "',DiaChi =N'" + txtDiaChi.Text + "' where MaNhaXuatBan ='"+txtMaNhaXuatBan.Text+"'";
                dp.ExeNoQuery(sql);
                MessageBox.Show("Chỉnh sửa thành công");
                loadFrom();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemNhaXuatBan f = new FrmThemNhaXuatBan();
            f.ShowDialog();
            loadFrom();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa nhà xuất bản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataProvider dp = new DataProvider();
                string sql = "select count(*) from SACH where MaNhaXuatBan = '" + txtMaNhaXuatBan.Text + "'";
                int kq = dp.ExeScalar(sql);
                if (kq > 0)
                {
                    MessageBox.Show("Bạn không thể xóa nhà xuất bản này vì nó đang được sử dụng");
                }
                else
                {
                    sql = "delete from NHAXUATBAN where MaNhaXuatBan = '" + txtMaNhaXuatBan.Text + "'";
                    dp.ExeNoQuery(sql);
                    MessageBox.Show("Xóa nhà xuất bản thành công");
                    loadFrom();
                }
            }
        }
    }
}
