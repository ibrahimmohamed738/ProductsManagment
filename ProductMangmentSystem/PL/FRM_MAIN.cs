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
    public partial class FRM_MAIN : Form
    {
        private static FRM_MAIN frm;

        static void frm_FromClosed(object sender, FormClosedEventArgs e) 
        {
            frm = null;
        
        }
        public static FRM_MAIN getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FromClosed);
                }
                return frm;
            }
        
        }
        public FRM_MAIN()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;

            this.productToolStripMenuItem.Enabled = false;
            this.customerToolStripMenuItem.Enabled = false;
            this.usersToolStripMenuItem.Enabled = false;
            this.backupToolStripMenuItem.Enabled = false;
            this.restoreToolStripMenuItem.Enabled = false;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frmlogin = new FRM_LOGIN();
            frmlogin.ShowDialog();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();

        }
    }
}
