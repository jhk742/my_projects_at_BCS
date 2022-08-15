namespace OBCS.Reports
{
    partial class Rpt_SalesARbyRepReport
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
            this.SalesARbyRepReport = new OBCS.Reports.SalesARbyRepReport();
            this.sp_SalesARbyRepReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SalesARbyRepReportTableAdapter = new OBCS.Reports.SalesARbyRepReportTableAdapters.sp_SalesARbyRepReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SalesARbyRepReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SalesARbyRepReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SalesARbyRepReport";
            reportDataSource1.Value = this.sp_SalesARbyRepReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.SalesARbyRepReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1247, 830);
            this.reportViewer1.TabIndex = 0;
            // 
            // SalesARbyRepReport
            // 
            this.SalesARbyRepReport.DataSetName = "SalesARbyRepReport";
            this.SalesARbyRepReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_SalesARbyRepReportBindingSource
            // 
            this.sp_SalesARbyRepReportBindingSource.DataMember = "sp_SalesARbyRepReport";
            this.sp_SalesARbyRepReportBindingSource.DataSource = this.SalesARbyRepReport;
            // 
            // sp_SalesARbyRepReportTableAdapter
            // 
            this.sp_SalesARbyRepReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_SalesARbyRepReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 830);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_SalesARbyRepReport";
            this.Text = "Rpt_SalesARbyRepReport";
            this.Load += new System.EventHandler(this.Rpt_SalesARbyRepReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesARbyRepReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SalesARbyRepReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_SalesARbyRepReportBindingSource;
        private SalesARbyRepReport SalesARbyRepReport;
        private SalesARbyRepReportTableAdapters.sp_SalesARbyRepReportTableAdapter sp_SalesARbyRepReportTableAdapter;
    }
}