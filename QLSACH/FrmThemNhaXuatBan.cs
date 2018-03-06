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
    public partial class FrmThemNhaXuatBan : Form
    {
        bool tinhTrang = false;
        public FrmThemNhaXuatBan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            string sql = "select count(*) from NHAXUATBAN where MaNhaXuatBan ='" + txtMaNhaXuatBan.Text + "'";
            int kq = dp.ExeScalar(sql);
            if(kq == 1)
            {
                MessageBox.Show("Mã nhà xuất bản đã tồn tại");
            }
            else
            {
                if(txtMaNhaXuatBan.Text == "")
                {
                    MessageBox.Show("Mã xuất bản không được bỏ trống");
                }
                else
                {
                    sql = "insert into NHAXUATBAN values('" + txtMaNhaXuatBan.Text + "',N'" + txtTenNhaXuatBan.Text + "','" + txtSdt.Text + "',N'" + txtDiaChi.Text + "')";
                    dp.ExeNoQuery(sql);
                    MessageBox.Show("Thêm nhà xuất bản thành công");
                    tinhTrang = true;
                    this.Close();
                }
            }
        }

        private void FrmThemNhaXuatBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!tinhTrang)
            {
                if(MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
