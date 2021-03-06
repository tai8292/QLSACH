﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        bool trangThai = false;
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

        public void Clear()
        {
            this.txtMaSach.Clear();
            this.txtTenSach.Clear();
            this.txtTacGia.Clear();
            this.txtMoTa.Clear();

            this.txtMaSach.Focus();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            Clear();
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
            byte[] anh = LopDungChung.anhSangByte(this.hinhAnh.Image);

            if (dp.ExeScalar("select count(*) from SACH where MaSach ='" + maSach + "'") == 1)
            {
                MessageBox.Show("Mã sách đã tồn tài");
            }
            else
            {
                if (txtMaSach.Text == "")
                {
                    MessageBox.Show("Mã sách không được để trống");
                }
                else
                {
                    if (txtTenSach.Text == "")
                    {
                        MessageBox.Show("Tên sách không được để trống");
                    }
                    else
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@HinhAnh";
                        param.Value = anh;

                        string sql = "insert into SACH values('" + maSach + "',N'" + tenSach + "',N'" + tacGia + "','" + ngayXuatBan + "','" + nhaXuatBan + "',@HinhAnh,N'" + moTa + "')";
                        dp.ExeNoQuery(sql, param);

                        //get the loai
                        List<string> listTheLoai = new List<string>();
                        foreach (DataRowView i in this.lbTheLoai.SelectedItems)
                            listTheLoai.Add(i["MaLoaiSach"].ToString());

                        for (int i = 0; i < listTheLoai.Count; i++)
                        {
                            sql = "insert into LOAISACH values('" + maSach + "','" + listTheLoai[i] + "')";
                            dp.ExeNoQuery(sql);
                        }
                        Clear();
                        trangThai = true;
                        MessageBox.Show("THêm sách thành công");
                        this.Close();
                    }
                }
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

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmThemSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trangThai == false)
            {
                if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
