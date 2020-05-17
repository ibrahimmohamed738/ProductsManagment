using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMangmentSystem.PL
{
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_LOGIN login = new BL.CLS_LOGIN();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = login.LOGIN(txtUsername.Text,txtPassword.Text);
            if (dt.Rows.Count > 0)
            {
                FRM_MAIN.getMainForm.productToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.customerToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.usersToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.backupToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.restoreToolStripMenuItem.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed.");
            }
        }
    }
}
