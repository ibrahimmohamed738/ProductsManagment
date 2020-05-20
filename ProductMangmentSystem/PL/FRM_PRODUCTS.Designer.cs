namespace ProductMangmentSystem.PL
{
    partial class FRM_PRODUCTS
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrintAllProducts = new System.Windows.Forms.Button();
            this.btnPrintSingle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowPic = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search For Product :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(171, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(363, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 222);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(693, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrintAllProducts);
            this.groupBox2.Controls.Add(this.btnPrintSingle);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnShowPic);
            this.groupBox2.Controls.Add(this.btnExportExcel);
            this.groupBox2.Controls.Add(this.btnEditProduct);
            this.groupBox2.Controls.Add(this.btnDeleteSelected);
            this.groupBox2.Controls.Add(this.btnAddProduct);
            this.groupBox2.Location = new System.Drawing.Point(13, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // btnPrintAllProducts
            // 
            this.btnPrintAllProducts.Location = new System.Drawing.Point(598, 15);
            this.btnPrintAllProducts.Name = "btnPrintAllProducts";
            this.btnPrintAllProducts.Size = new System.Drawing.Size(103, 23);
            this.btnPrintAllProducts.TabIndex = 0;
            this.btnPrintAllProducts.Text = "Print All Product";
            this.btnPrintAllProducts.UseVisualStyleBackColor = true;
            this.btnPrintAllProducts.Click += new System.EventHandler(this.btnPrintAllProducts_Click);
            // 
            // btnPrintSingle
            // 
            this.btnPrintSingle.Location = new System.Drawing.Point(466, 15);
            this.btnPrintSingle.Name = "btnPrintSingle";
            this.btnPrintSingle.Size = new System.Drawing.Size(128, 23);
            this.btnPrintSingle.TabIndex = 0;
            this.btnPrintSingle.Text = "Print Selected Product";
            this.btnPrintSingle.UseVisualStyleBackColor = true;
            this.btnPrintSingle.Click += new System.EventHandler(this.btnPrintSingle_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(339, 44);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowPic
            // 
            this.btnShowPic.Location = new System.Drawing.Point(339, 15);
            this.btnShowPic.Name = "btnShowPic";
            this.btnShowPic.Size = new System.Drawing.Size(124, 23);
            this.btnShowPic.TabIndex = 0;
            this.btnShowPic.Text = "Select Product Image";
            this.btnShowPic.UseVisualStyleBackColor = true;
            this.btnShowPic.Click += new System.EventHandler(this.btnShowPic_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(239, 44);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(96, 23);
            this.btnExportExcel.TabIndex = 0;
            this.btnExportExcel.Text = "Export to Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(239, 15);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(96, 23);
            this.btnEditProduct.TabIndex = 0;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(114, 15);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(121, 23);
            this.btnDeleteSelected.TabIndex = 0;
            this.btnDeleteSelected.Text = "Delete Select Product";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(8, 15);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(102, 23);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // FRM_PRODUCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FRM_PRODUCTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Products";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrintAllProducts;
        private System.Windows.Forms.Button btnPrintSingle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowPic;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnAddProduct;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}