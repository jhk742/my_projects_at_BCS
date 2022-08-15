namespace OBCS.Reports
{
    partial class Rpt_ProductList
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_LIST_PRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductList = new OBCS.Reports.ProductList();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_LIST_PRODUCTTableAdapter = new OBCS.Reports.ProductListTableAdapters.sp_LIST_PRODUCTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LIST_PRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_LIST_PRODUCTBindingSource
            // 
            this.sp_LIST_PRODUCTBindingSource.DataMember = "sp_LIST_PRODUCT";
            this.sp_LIST_PRODUCTBindingSource.DataSource = this.ProductList;
            // 
            // ProductList
            // 
            this.ProductList.DataSetName = "ProductList";
            this.ProductList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProductList";
            reportDataSource1.Value = this.sp_LIST_PRODUCTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.ProductList.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1144, 890);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_LIST_PRODUCTTableAdapter
            // 
            this.sp_LIST_PRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 890);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_ProductList";
            this.Text = "Rpt_ProductList";
            this.Load += new System.EventHandler(this.Rpt_ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_LIST_PRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_LIST_PRODUCTBindingSource;
        private ProductList ProductList;
        private ProductListTableAdapters.sp_LIST_PRODUCTTableAdapter sp_LIST_PRODUCTTableAdapter;
    }
}