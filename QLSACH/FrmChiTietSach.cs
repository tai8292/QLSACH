﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSACH
{
    public partial class FrmChiTietSach : Form
    {
        bool tinhTrang = false;
        string maSach;
        public FrmChiTietSach()
        {
            InitializeComponent();
        }

        public void loadForm()
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

            sql = "select * from SACH where MaSach ='" + maSach + "'";
            dt = dp.GetDataTable(sql);

            this.txtMaSach.Text = maSach;
            this.txtTenSach.Text = dt.Rows[0]["TenSach"].ToString();
            this.txtTacGia.Text = dt.Rows[0]["TacGia"].ToString();
            this.txtMoTa.Text = dt.Rows[0]["MoTa"].ToString();
            this.cbNhaXuatBan.SelectedValue = dt.Rows[0]["MaNhaXuatBan"].ToString();
            this.hinhAnh.Image = LopDungChung.byteSangAnh((byte[])dt.Rows[0]["HinhAnh"]);

            sql = "select * from LOAISACH where MaSach ='" + maSach + "'";
            dt = dp.GetDataTable(sql);
            foreach(DataRow dr in dt.Rows)
            {
                lbTheLoai.SelectedValue = dr["MaLoaiSach"].ToString();
            }
        }

        public FrmChiTietSach(string maSach)
        {
            InitializeComponent();
            this.maSach = maSach;
        }

        private void FrmChiTietSach_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.txtTenSach.ReadOnly = false;
            this.txtTacGia.ReadOnly = false;
            this.cbNhaXuatBan.Enabled = true;
            this.lbTheLoai.Enabled = true;
            this.txtMoTa.ReadOnly = false;
            this.button1.Visible = true;
            this.ngayXuatBan.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Tên sách không được để trống");
            }
            else
            {
                if (ngayXuatBan.Value > DateTime.Now)
                {
                    MessageBox.Show("Ngày xuất bản không được lớn hơn ngày hiện tại");
                }
                else
                {
                    DataProvider dp = new DataProvider();
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@HinhAnh";
                    param.Value = LopDungChung.anhSangByte(hinhAnh.Image);
                    string sql = "update SACH set TenSach =N'" + txtTenSach.Text + "',TacGia = N'" + txtTacGia.Text + "',MaNhaXuatBan ='" + cbNhaXuatBan.SelectedValue.ToString() + "',NgayXuatBan ='" + ngayXuatBan.Value.ToString() + "',MoTa = N'" + txtMoTa.Text + "',HinhAnh = @HinhAnh where MaSach ='" + maSach + "'";
                    dp.ExeNoQuery(sql, param);

                    this.txtTenSach.ReadOnly = true;
                    this.txtTacGia.ReadOnly = true;
                    this.cbNhaXuatBan.Enabled = false;
                    this.lbTheLoai.Enabled = false;
                    this.txtMoTa.ReadOnly = true;
                    this.button1.Visible = false;
                    this.ngayXuatBan.Enabled = false;
                    tinhTrang = true;

                    MessageBox.Show("Sửa  thông tin sách thành công");
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anh.Filter = "Jpg file|*.jpg|Bmp file|*.bmp|jepg file|*.jepg|All file|*.*";
            if (anh.ShowDialog() == DialogResult.OK)
                hinhAnh.Image = Image.FromFile(anh.FileName);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmChiTietSach_FormClosing(object sender, FormClosingEventArgs e)
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
