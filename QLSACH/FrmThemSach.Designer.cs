﻿namespace QLSACH
{
    partial class FrmThemSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.anh = new System.Windows.Forms.OpenFileDialog();
            this.hinhAnh = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lbTheLoai = new System.Windows.Forms.ListBox();
            this.ngayXuatBan = new System.Windows.Forms.DateTimePicker();
            this.cbNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnh)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thêm mới sách";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenSach);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 45);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTacGia);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 45);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tác giả : ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbNhaXuatBan);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 197);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 45);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhà xuất bản : ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ngayXuatBan);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(12, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 45);
            this.panel4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày xuất bản :";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbTheLoai);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(12, 299);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 96);
            this.panel5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thể loại : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(508, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 32);
            this.button1.TabIndex = 7;
            this.button1.Tag = "1";
            this.button1.Text = "Chọn ảnh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anh
            // 
            this.anh.FileName = "anh";
            // 
            // hinhAnh
            // 
            this.hinhAnh.Image = global::QLSACH.Properties.Resources.book;
            this.hinhAnh.Location = new System.Drawing.Point(485, 61);
            this.hinhAnh.Name = "hinhAnh";
            this.hinhAnh.Size = new System.Drawing.Size(181, 147);
            this.hinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hinhAnh.TabIndex = 6;
            this.hinhAnh.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(155, 538);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 34);
            this.btnThem.TabIndex = 8;
            this.btnThem.Tag = "1";
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(307, 538);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(95, 34);
            this.btnNhapLai.TabIndex = 9;
            this.btnNhapLai.Tag = "1";
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(455, 538);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 34);
            this.btnDong.TabIndex = 10;
            this.btnDong.Tag = "1";
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtMoTa);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(12, 401);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(456, 131);
            this.panel6.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mô tả";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtMaSach);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(12, 43);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(456, 45);
            this.panel7.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã sách : ";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(140, 7);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(313, 121);
            this.txtMoTa.TabIndex = 0;
            this.txtMoTa.Tag = "1";
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheLoai.FormattingEnabled = true;
            this.lbTheLoai.ItemHeight = 20;
            this.lbTheLoai.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.lbTheLoai.Location = new System.Drawing.Point(140, 5);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTheLoai.Size = new System.Drawing.Size(313, 84);
            this.lbTheLoai.TabIndex = 0;
            this.lbTheLoai.Tag = "1";
            // 
            // ngayXuatBan
            // 
            this.ngayXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayXuatBan.Location = new System.Drawing.Point(140, 9);
            this.ngayXuatBan.Name = "ngayXuatBan";
            this.ngayXuatBan.Size = new System.Drawing.Size(313, 26);
            this.ngayXuatBan.TabIndex = 0;
            this.ngayXuatBan.Tag = "1";
            // 
            // cbNhaXuatBan
            // 
            this.cbNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhaXuatBan.FormattingEnabled = true;
            this.cbNhaXuatBan.Location = new System.Drawing.Point(140, 9);
            this.cbNhaXuatBan.Name = "cbNhaXuatBan";
            this.cbNhaXuatBan.Size = new System.Drawing.Size(313, 28);
            this.cbNhaXuatBan.TabIndex = 0;
            this.cbNhaXuatBan.Tag = "1";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(140, 7);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(313, 26);
            this.txtTacGia.TabIndex = 0;
            this.txtTacGia.Tag = "1";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(140, 7);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(313, 26);
            this.txtTenSach.TabIndex = 0;
            this.txtTenSach.Tag = "1";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(140, 7);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(313, 26);
            this.txtMaSach.TabIndex = 1;
            this.txtMaSach.Tag = "1";
            // 
            // FrmThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 578);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.hinhAnh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmThemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "1";
            this.Text = "FrmThemSach";
            this.Load += new System.EventHandler(this.FrmThemSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnh)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog anh;
        private System.Windows.Forms.PictureBox hinhAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.ComboBox cbNhaXuatBan;
        private System.Windows.Forms.DateTimePicker ngayXuatBan;
        private System.Windows.Forms.ListBox lbTheLoai;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtMaSach;
    }
}