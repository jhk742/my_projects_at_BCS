namespace OBCS.Reports
{
    partial class Rpt_StockDetailByProduct
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
            this.sp_StockDetailByProductIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockDetailByProduct = new OBCS.Reports.StockDetailByProduct();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_StockDetailByProductIDTableAdapter = new OBCS.Reports.StockDetailByProductTableAdapters.sp_StockDetailByProductIDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_StockDetailByProductIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDetailByProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_StockDetailByProductIDBindingSource
            // 
            this.sp_StockDetailByProductIDBindingSource.DataMember = "sp_StockDetailByProductID";
            this.sp_StockDetailByProductIDBindingSource.DataSource = this.StockDetailByProduct;
            // 
            // StockDetailByProduct
            // 
            this.StockDetailByProduct.DataSetName = "StockDetailByProduct";
            this.StockDetailByProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StockDetailByProduct";
            reportDataSource1.Value = this.sp_StockDetailByProductIDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.StockDetailByProduct.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1247, 830);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_StockDetailByProductIDTableAdapter
            // 
            this.sp_StockDetailByProductIDTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_StockDetailByProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 830);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_StockDetailByProduct";
            this.Text = "Rpt_StockDetailByProduct";
            this.Load += new System.EventHandler(this.Rpt_StockDetailByProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_StockDetailByProductIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDetailByProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_StockDetailByProductIDBindingSource;
        private StockDetailByProduct StockDetailByProduct;
        private StockDetailByProductTableAdapters.sp_StockDetailByProductIDTableAdapter sp_StockDetailByProductIDTableAdapter;
    }
}