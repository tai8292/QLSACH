namespace QLSACH
{
    partial class FrmTheLoai
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
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TenTheLoai = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_MaTheLoai = new System.Windows.Forms.TextBox();
            this.tx = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.dgTheLoai = new System.Windows.Forms.DataGridView();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_giatri = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheLoai)).BeginInit();
            this.SuspendLayout();
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
            this.btnThem.Location = new System.Drawing.Point(675, 84);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(168, 55);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm mới thể loại";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txt_TenTheLoai
            // 
            this.txt_TenTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTheLoai.Location = new System.Drawing.Point(10, 29);
            this.txt_TenTheLoai.MaxLength = 150;
            this.txt_TenTheLoai.Name = "txt_TenTheLoai";
            this.txt_TenTheLoai.Size = new System.Drawing.Size(247, 26);
            this.txt_TenTheLoai.TabIndex = 1;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(6, 6);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(113, 20);
            this.t.TabIndex = 0;
            this.t.Text = "Tên thể loại :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_TenTheLoai);
            this.panel2.Controls.Add(this.t);
            this.panel2.Location = new System.Drawing.Point(638, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 68);
            this.panel2.TabIndex = 27;
            // 
            // txt_MaTheLoai
            // 
            this.txt_MaTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaTheLoai.Location = new System.Drawing.Point(10, 29);
            this.txt_MaTheLoai.MaxLength = 10;
            this.txt_MaTheLoai.Name = "txt_MaTheLoai";
            this.txt_MaTheLoai.ReadOnly = true;
            this.txt_MaTheLoai.Size = new System.Drawing.Size(247, 26);
            this.txt_MaTheLoai.TabIndex = 1;
            // 
            // tx
            // 
            this.tx.AutoSize = true;
            this.tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx.Location = new System.Drawing.Point(6, 6);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(107, 20);
            this.tx.TabIndex = 0;
            this.tx.Text = "Mã thể loại :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_MaTheLoai);
            this.panel1.Controls.Add(this.tx);
            this.panel1.Location = new System.Drawing.Point(638, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 68);
            this.panel1.TabIndex = 26;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(799, 407);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 35);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(638, 407);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 35);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgTheLoai
            // 
            this.dgTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTheLoai,
            this.TenTheLoai});
            this.dgTheLoai.Location = new System.Drawing.Point(12, 84);
            this.dgTheLoai.Name = "dgTheLoai";
            this.dgTheLoai.RowHeadersWidth = 30;
            this.dgTheLoai.Size = new System.Drawing.Size(611, 467);
            this.dgTheLoai.TabIndex = 24;
            this.dgTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTheLoai_CellClick);
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.DataPropertyName = "MaLoaiSach";
            this.MaTheLoai.HeaderText = "Mã thể loại";
            this.MaTheLoai.Name = "MaTheLoai";
            this.MaTheLoai.ReadOnly = true;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.HeaderText = "Tên thể loại";
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.lbTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lbTieuDe.Location = new System.Drawing.Point(195, 7);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(333, 41);
            this.lbTieuDe.TabIndex = 32;
            this.lbTieuDe.Text = "Danh sách thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tìm Kiếm";
            // 
            // txt_giatri
            // 
            this.txt_giatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giatri.Location = new System.Drawing.Point(110, 51);
            this.txt_giatri.Name = "txt_giatri";
            this.txt_giatri.Size = new System.Drawing.Size(513, 26);
            this.txt_giatri.TabIndex = 34;
            this.txt_giatri.TextChanged += new System.EventHandler(this.txt_giatri_TextChanged);
            // 
            // FrmTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 563);
            this.Controls.Add(this.txt_giatri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgTheLoai);
            this.Controls.Add(this.lbTieuDe);
            this.Name = "FrmTheLoai";
            this.Text = "FrmTheLoai";
            this.Load += new System.EventHandler(this.FrmTheLoai_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TextBox txt_TenTheLoai;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_MaTheLoai;
        private System.Windows.Forms.Label tx;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.DataGridView dgTheLoai;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_giatri;
    }
}