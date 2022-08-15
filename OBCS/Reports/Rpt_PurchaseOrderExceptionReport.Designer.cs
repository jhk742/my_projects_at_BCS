namespace OBCS.Reports
{
    partial class Rpt_PurchaseOrderExceptionReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PurchaseOrderExceptionReport = new OBCS.Reports.PurchaseOrderExceptionReport();
            this.sp_PurchaseOrderExceptionReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_PurchaseOrderExceptionReportTableAdapter = new OBCS.Reports.PurchaseOrderExceptionReportTableAdapters.sp_PurchaseOrderExceptionReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseOrderExceptionReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PurchaseOrderExceptionReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PurchaseOrderExceptionReport";
            reportDataSource1.Value = this.sp_PurchaseOrderExceptionReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.PurchaseOrderExceptionReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1188, 668);
            this.reportViewer1.TabIndex = 0;
            // 
            // PurchaseOrderExceptionReport
            // 
            this.PurchaseOrderExceptionReport.DataSetName = "PurchaseOrderExceptionReport";
            this.PurchaseOrderExceptionReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_PurchaseOrderExceptionReportBindingSource
            // 
            this.sp_PurchaseOrderExceptionReportBindingSource.DataMember = "sp_PurchaseOrderExceptionReport";
            this.sp_PurchaseOrderExceptionReportBindingSource.DataSource = this.PurchaseOrderExceptionReport;
            // 
            // sp_PurchaseOrderExceptionReportTableAdapter
            // 
            this.sp_PurchaseOrderExceptionReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_PurchaseOrderExceptionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 668);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_PurchaseOrderExceptionReport";
            this.Text = "Purchase Order Exception Report";
            this.Load += new System.EventHandler(this.Rpt_PurchaseOrderExceptionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseOrderExceptionReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PurchaseOrderExceptionReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_PurchaseOrderExceptionReportBindingSource;
        private PurchaseOrderExceptionReport PurchaseOrderExceptionReport;
        private PurchaseOrderExceptionReportTableAdapters.sp_PurchaseOrderExceptionReportTableAdapter sp_PurchaseOrderExceptionReportTableAdapter;
    }
}