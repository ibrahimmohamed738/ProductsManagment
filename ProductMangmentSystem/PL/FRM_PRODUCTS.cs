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
    public partial class FRM_PRODUCTS : Form
    {
        
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();

        public FRM_PRODUCTS()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = prd.GetAllProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.SearchProduct(txtSearch.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this Product.", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.DELETE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Product Deleted Successfully.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = prd.GetAllProducts();
            }
            else 
            {
                MessageBox.Show("Product Not Deleted","Prodcut Delete",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.txtRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDescription.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtProductQty.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtProductPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbCategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();

            frm.Text = "Edit Product " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnAddProduct.Text = "Edit Product";
            frm.txtRef.ReadOnly = true;
            frm.state = "update";
            byte[] Img = (byte[])prd.GetProductImg(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(Img);
            frm.pictureBoxProduct.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void btnShowPic_Click(object sender, EventArgs e)
        {
            FRM_PREVEIW frm = new FRM_PREVEIW();
            byte[] Img = (byte[])prd.GetProductImg(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(Img);
            frm.pictureBoxProduct.Image = Image.FromStream(ms);
            frm.ShowDialog();

        }
    }
}
