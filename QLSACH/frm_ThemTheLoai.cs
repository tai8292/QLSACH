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
    public partial class frm_ThemTheLoai : Form
    {
        bool tinhTrang = false;
        public frm_ThemTheLoai()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();

            string MaTheLoai = this.txt_MaTheLoai.Text.ToString();
            string TenTheLoai = this.txt_TenTheLoai.Text.ToString();
            if (dp.ExeScalar("SELECT count (*) from THELOAI where MaLoaiSach= '" + MaTheLoai + "'")==1){
                MessageBox.Show("Ma The Loai da ton tai");
            }
            else
            {
                if(txt_MaTheLoai.Text == "")
                {
                    MessageBox.Show("Ma The Loai khong duoc de trong");
                }
                else
                {
                    string sql = "insert into THELOAI values('" + MaTheLoai + "',N'" + TenTheLoai + "')";
                    dp.ExeNoQuery(sql);
                    MessageBox.Show("Thêm Thể Loại Thành Công");
                    tinhTrang = true;
                    this.Close();
                }
            }

        }

        private void frm_ThemTheLoai_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!tinhTrang)
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
