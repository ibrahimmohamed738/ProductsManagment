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


namespace ProductMangmentSystem.PL
{
    public partial class FRM_ADD_PRODUCT : Form
    {
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
            cmbCategories.DataSource = prd.GetAllCategories();
            cmbCategories.DisplayMember = "DESCRIPTION_CAT";
            cmbCategories.ValueMember = "ID_CAT";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File | *.JPG; *.PNG; *.JPEG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProduct.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxProduct.Image.Save(ms,pictureBoxProduct.Image.RawFormat);
            byte[] byteImage = ms.ToArray();
            int CAT_ID = Convert.ToInt32(cmbCategories.SelectedValue);
            int xQty = Convert.ToInt32(txtProductQty.Text);
            prd.ADD_PRODUCT(CAT_ID,txtDescription.Text,txtRef.Text,xQty,txtProductPrice.Text,byteImage);
            MessageBox.Show("Product Added Succefully", "Add Product",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void txtRef_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.VerifyProductID(txtRef.Text);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Product ID Already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRef.Focus();
                txtRef.SelectionStart = 0;
                txtRef.SelectionLength = txtRef.TextLength;
            }
        }
    }
}
