namespace ProductMangmentSystem.RPT
{
    partial class FRM_RPT_PRODUCT
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
            this.crystalReportViewerSingle = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerSingle
            // 
            this.crystalReportViewerSingle.ActiveViewIndex = -1;
            this.crystalReportViewerSingle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerSingle.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerSingle.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerSingle.Name = "crystalReportViewerSingle";
            this.crystalReportViewerSingle.Size = new System.Drawing.Size(513, 376);
            this.crystalReportViewerSingle.TabIndex = 0;
            this.crystalReportViewerSingle.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FRM_RPT_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 376);
            this.Controls.Add(this.crystalReportViewerSingle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_RPT_PRODUCT";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Report";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerSingle;
    }
}