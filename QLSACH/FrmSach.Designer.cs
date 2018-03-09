namespace QLSACH
{
    partial class FrmSach
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
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.pnTacGia = new System.Windows.Forms.Panel();
            this.lbTacGia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnTenSach = new System.Windows.Forms.Panel();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.dgSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.picBook = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaTriTimKiem = new System.Windows.Forms.TextBox();
            this.pnTacGia.SuspendLayout();
            this.pnTenSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.lbTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lbTieuDe.Location = new System.Drawing.Point(112, -3);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(421, 41);
            this.lbTieuDe.TabIndex = 15;
            this.lbTieuDe.Text = "Phầm mền quản lý sách";
            // 
            // pnTacGia
            // 
            this.pnTacGia.Controls.Add(this.lbTacGia);
            this.pnTacGia.Controls.Add(this.label4);
            this.pnTacGia.Location = new System.Drawing.Point(643, 419);
            this.pnTacGia.Name = "pnTacGia";
            this.pnTacGia.Size = new System.Drawing.Size(246, 31);
            this.pnTacGia.TabIndex = 14;
            // 
            // lbTacGia
            // 
            this.lbTacGia.AutoSize = true;
            this.lbTacGia.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbTacGia.Location = new System.Drawing.Point(86, 7);
            this.lbTacGia.Name = "lbTacGia";
            this.lbTacGia.Size = new System.Drawing.Size(53, 17);
            this.lbTacGia.TabIndex = 1;
            this.lbTacGia.Text = "tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tác giả : ";
            // 
            // pnTenSach
            // 
            this.pnTenSach.Controls.Add(this.lbMaSach);
            this.pnTenSach.Controls.Add(this.lbTenSach);
            this.pnTenSach.Controls.Add(this.label1);
            this.pnTenSach.Location = new System.Drawing.Point(643, 368);
            this.pnTenSach.Name = "pnTenSach";
            this.pnTenSach.Size = new System.Drawing.Size(246, 31);
            this.pnTenSach.TabIndex = 13;
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbMaSach.Location = new System.Drawing.Point(131, 7);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(39, 17);
            this.lbMaSach.TabIndex = 2;
            this.lbMaSach.Text = "sách";
            this.lbMaSach.Visible = false;
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbTenSach.Location = new System.Drawing.Point(86, 7);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(39, 17);
            this.lbTenSach.TabIndex = 1;
            this.lbTenSach.Text = "sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách : ";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(800, 469);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 35);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnChiTiet.Appearance.Options.UseFont = true;
            this.btnChiTiet.Location = new System.Drawing.Point(643, 469);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(89, 35);
            this.btnChiTiet.TabIndex = 2;
            this.btnChiTiet.Text = "Xem chi tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Appearance.BackColor2 = System.Drawing.Color.DarkBlue;
            this.btnThem.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseBorderColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.Location = new System.Drawing.Point(681, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(168, 55);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm mới sách";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgSach
            // 
            this.dgSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TacGia,
            this.HinhAnh});
            this.dgSach.Location = new System.Drawing.Point(12, 84);
            this.dgSach.Name = "dgSach";
            this.dgSach.RowHeadersWidth = 30;
            this.dgSach.Size = new System.Drawing.Size(611, 467);
            this.dgSach.TabIndex = 0;
            this.dgSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSach_CellClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình ảnh";
            this.HinhAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            // 
            // picBook
            // 
            this.picBook.Image = global::QLSACH.Properties.Resources.book;
            this.picBook.Location = new System.Drawing.Point(643, 84);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(246, 258);
            this.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBook.TabIndex = 9;
            this.picBook.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tìm kiếm : ";
            // 
            // txtGiaTriTimKiem
            // 
            this.txtGiaTriTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTriTimKiem.Location = new System.Drawing.Point(131, 50);
            this.txtGiaTriTimKiem.Name = "txtGiaTriTimKiem";
            this.txtGiaTriTimKiem.Size = new System.Drawing.Size(492, 26);
            this.txtGiaTriTimKiem.TabIndex = 17;
            this.txtGiaTriTimKiem.TextChanged += new System.EventHandler(this.txtGiaTriTimKiem_TextChanged);
            // 
            // FrmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 563);
            this.Controls.Add(this.txtGiaTriTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.pnTacGia);
            this.Controls.Add(this.pnTenSach);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.picBook);
            this.Controls.Add(this.dgSach);
            this.Name = "FrmSach";
            this.Text = "Sach";
            this.Load += new System.EventHandler(this.FrmSach_Load);
            this.pnTacGia.ResumeLayout(false);
            this.pnTacGia.PerformLayout();
            this.pnTenSach.ResumeLayout(false);
            this.pnTenSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Panel pnTacGia;
        private System.Windows.Forms.Label lbTacGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnTenSach;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnChiTiet;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.PictureBox picBook;
        private System.Windows.Forms.DataGridView dgSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaTriTimKiem;
    }
}