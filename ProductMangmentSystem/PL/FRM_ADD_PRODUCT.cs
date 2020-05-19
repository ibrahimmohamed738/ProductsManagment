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
        public string state = "add";
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
            if (state == "add")
            {
                MemoryStream ms = new MemoryStream();
                pictureBoxProduct.Image.Save(ms, pictureBoxProduct.Image.RawFormat);
                byte[] byteImage = ms.ToArray();
                int CAT_ID = Convert.ToInt32(cmbCategories.SelectedValue);
                int xQty = Convert.ToInt32(txtProductQty.Text);
                prd.ADD_PRODUCT(CAT_ID, txtDescription.Text, txtRef.Text, xQty, txtProductPrice.Text, byteImage);
                MessageBox.Show("Product Added Successfully", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MemoryStream ms = new MemoryStream();
                pictureBoxProduct.Image.Save(ms, pictureBoxProduct.Image.RawFormat);
                byte[] byteImage = ms.ToArray();
                int CAT_ID = Convert.ToInt32(cmbCategories.SelectedValue);
                int xQty = Convert.ToInt32(txtProductQty.Text);
                prd.UpdateProduct(CAT_ID, txtDescription.Text, txtRef.Text, xQty, txtProductPrice.Text, byteImage);
                MessageBox.Show("Product Updated Successfully", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FRM_PRODUCTS.getMainForm.dataGridView1.DataSource = prd.GetAllProducts();
        }

        private void txtRef_Validated(object sender, EventArgs e)
        {
            if (state == "add")
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
}
