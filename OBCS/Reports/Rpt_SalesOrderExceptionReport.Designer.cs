namespace OBCS.Reports
{
    partial class Rpt_SalesOrderExceptionReport
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
            this.sp_SalesOrderExceptionReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesOrderExceptionReport = new OBCS.Reports.SalesOrderExceptionReport();
            this.sp_SalesOrderExceptionReportTableAdapter = new OBCS.Reports.SalesOrderExceptionReportTableAdapters.sp_SalesOrderExceptionReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SalesOrderExceptionReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesOrderExceptionReport)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SalesOrderExceptionReport";
            reportDataSource1.Value = this.sp_SalesOrderExceptionReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.SalesOrderExceptionReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1140, 586);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_SalesOrderExceptionReportBindingSource
            // 
            this.sp_SalesOrderExceptionReportBindingSource.DataMember = "sp_SalesOrderExceptionReport";
            this.sp_SalesOrderExceptionReportBindingSource.DataSource = this.SalesOrderExceptionReport;
            // 
            // SalesOrderExceptionReport
            // 
            this.SalesOrderExceptionReport.DataSetName = "SalesOrderExceptionReport";
            this.SalesOrderExceptionReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_SalesOrderExceptionReportTableAdapter
            // 
            this.sp_SalesOrderExceptionReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_SalesOrderExceptionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 586);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_SalesOrderExceptionReport";
            this.Text = "Sales Order Exception Report";
            this.Load += new System.EventHandler(this.Rpt_SalesOrderExceptionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_SalesOrderExceptionReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesOrderExceptionReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_SalesOrderExceptionReportBindingSource;
        private SalesOrderExceptionReport SalesOrderExceptionReport;
        private SalesOrderExceptionReportTableAdapters.sp_SalesOrderExceptionReportTableAdapter sp_SalesOrderExceptionReportTableAdapter;
    }
}