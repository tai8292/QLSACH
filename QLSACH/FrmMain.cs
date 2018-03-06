using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLSACH
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void nhungForm(Form f)
        {
            this.pnMain.Controls.Clear();
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.TopLevel = false;
            f.Visible = true;

            f.Dock = System.Windows.Forms.DockStyle.None;

            this.pnMain.Controls.Add(f);
            this.pnMain.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm();
        }

        public void loadForm()
        {
            FrmSach f = new FrmSach();
            nhungForm(f);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhaXuatBan f = new FrmNhaXuatBan();
            nhungForm(f);
        }
    }
}
