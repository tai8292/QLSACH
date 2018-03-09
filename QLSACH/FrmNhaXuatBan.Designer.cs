namespace QLSACH
{
    partial class FrmNhaXuatBan
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
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.dgNhaXuatBan = new System.Windows.Forms.DataGridView();
            this.MaNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaNhaXuatBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenNhaXuatBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txt_giatri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhaXuatBan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.lbTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lbTieuDe.Location = new System.Drawing.Point(262, 9);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(430, 41);
            this.lbTieuDe.TabIndex = 23;
            this.lbTieuDe.Text = "Danh sách nhà xuất bản";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(800, 448);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 35);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(642, 448);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 35);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgNhaXuatBan
            // 
            this.dgNhaXuatBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNhaXuatBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNhaXuatBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhaXuatBan,
            this.TenNhaXuatBan,
            this.Sdt,
            this.DiaChi});
            this.dgNhaXuatBan.Location = new System.Drawing.Point(15, 116);
            this.dgNhaXuatBan.Name = "dgNhaXuatBan";
            this.dgNhaXuatBan.RowHeadersWidth = 30;
            this.dgNhaXuatBan.Size = new System.Drawing.Size(611, 398);
            this.dgNhaXuatBan.TabIndex = 0;
            this.dgNhaXuatBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNhaXuatBan_CellClick);
            // 
            // MaNhaXuatBan
            // 
            this.MaNhaXuatBan.DataPropertyName = "MaNhaXuatBan";
            this.MaNhaXuatBan.HeaderText = "Mã NXB";
            this.MaNhaXuatBan.Name = "MaNhaXuatBan";
            // 
            // TenNhaXuatBan
            // 
            this.TenNhaXuatBan.DataPropertyName = "TenNhaXuatBan";
            this.TenNhaXuatBan.HeaderText = "Tên NXB";
            this.TenNhaXuatBan.Name = "TenNhaXuatBan";
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "SDT";
            this.Sdt.Name = "Sdt";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaNhaXuatBan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(635, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 68);
            this.panel1.TabIndex = 2;
            // 
            // txtMaNhaXuatBan
            // 
            this.txtMaNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhaXuatBan.Location = new System.Drawing.Point(10, 29);
            this.txtMaNhaXuatBan.MaxLength = 10;
            this.txtMaNhaXuatBan.Name = "txtMaNhaXuatBan";
            this.txtMaNhaXuatBan.ReadOnly = true;
            this.txtMaNhaXuatBan.Size = new System.Drawing.Size(247, 26);
            this.txtMaNhaXuatBan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NXB :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenNhaXuatBan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(632, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 68);
            this.panel2.TabIndex = 3;
            // 
            // txtTenNhaXuatBan
            // 
            this.txtTenNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhaXuatBan.Location = new System.Drawing.Point(10, 29);
            this.txtTenNhaXuatBan.MaxLength = 150;
            this.txtTenNhaXuatBan.Name = "txtTenNhaXuatBan";
            this.txtTenNhaXuatBan.Size = new System.Drawing.Size(247, 26);
            this.txtTenNhaXuatBan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên NXB :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSdt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(632, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 68);
            this.panel3.TabIndex = 4;
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(10, 29);
            this.txtSdt.MaxLength = 15;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(247, 26);
            this.txtSdt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "SĐT :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDiaChi);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(632, 374);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 68);
            this.panel4.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(10, 29);
            this.txtDiaChi.MaxLength = 150;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(247, 26);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ :";
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
            this.btnThem.Location = new System.Drawing.Point(684, 116);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(168, 55);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm mới sách";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txt_giatri
            // 
            this.txt_giatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giatri.Location = new System.Drawing.Point(99, 70);
            this.txt_giatri.Name = "txt_giatri";
            this.txt_giatri.Size = new System.Drawing.Size(527, 26);
            this.txt_giatri.TabIndex = 36;
            this.txt_giatri.TextChanged += new System.EventHandler(this.txt_giatri_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tìm Kiếm";
            // 
            // FrmNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 517);
            this.Controls.Add(this.txt_giatri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgNhaXuatBan);
            this.Name = "FrmNhaXuatBan";
            this.Text = "Nha Xuat Ban";
            this.Load += new System.EventHandler(this.FrmNhaXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNhaXuatBan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.DataGridView dgNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaNhaXuatBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenNhaXuatBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TextBox txt_giatri;
        private System.Windows.Forms.Label label5;
    }
}