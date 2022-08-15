namespace OBCS.Reports
{
    partial class Rpt_SalesReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_SalesReportBindingSource = new System.Windows.Forms.BindingSource();
            this.SalesReport = new OBCS.Reports.SalesReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_SalesReportTableAdapter = new OBCS.Reports.SalesReportTableAdapters.sp_SalesReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SalesReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_SalesReportBindingSource
            // 
            this.sp_SalesReportBindingSource.DataMember = "sp_SalesReport";
            this.sp_SalesReportBindingSource.DataSource = this.SalesReport;
            // 
            // SalesReport
            // 
            this.SalesReport.DataSetName = "SalesReport";
            this.SalesReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SalesReport";
            reportDataSource1.Value = this.sp_SalesReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.SalesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1381, 681);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_SalesReportTableAdapter
            // 
            this.sp_SalesReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 681);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_SalesReport";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.Rpt_SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_SalesReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_SalesReportBindingSource;
        private SalesReport SalesReport;
        private SalesReportTableAdapters.sp_SalesReportTableAdapter sp_SalesReportTableAdapter;
    }
}