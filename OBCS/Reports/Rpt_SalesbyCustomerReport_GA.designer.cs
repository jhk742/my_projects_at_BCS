
namespace OBCS.Reports
{
    partial class Rpt_SalesbyCustomerReport_GA
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
            this.sp_SalesbyCustomerReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesbyCustomerReport = new OBCS.Reports.SalesbyCustomerReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_SalesbyCustomerReportTableAdapter = new OBCS.Reports.SalesbyCustomerReportTableAdapters.sp_SalesbyCustomerReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SalesbyCustomerReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesbyCustomerReport)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_SalesbyCustomerReportBindingSource
            // 
            this.sp_SalesbyCustomerReportBindingSource.DataMember = "sp_SalesbyCustomerReport";
            this.sp_SalesbyCustomerReportBindingSource.DataSource = this.SalesbyCustomerReport;
            // 
            // SalesbyCustomerReport
            // 
            this.SalesbyCustomerReport.DataSetName = "SalesbyCustomerReport";
            this.SalesbyCustomerReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SalesbyCustomerReport";
            reportDataSource1.Value = this.sp_SalesbyCustomerReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.SalesbyCustomerReport_GA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1270, 824);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_SalesbyCustomerReportTableAdapter
            // 
            this.sp_SalesbyCustomerReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_SalesbyCustomerReport_GA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 824);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_SalesbyCustomerReport_GA";
            this.Text = "Rpt_SalesbyCustomerReport_GA";
            this.Load += new System.EventHandler(this.Rpt_SalesbyCustomerReport_GA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_SalesbyCustomerReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesbyCustomerReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_SalesbyCustomerReportBindingSource;
        private SalesbyCustomerReport SalesbyCustomerReport;
        private SalesbyCustomerReportTableAdapters.sp_SalesbyCustomerReportTableAdapter sp_SalesbyCustomerReportTableAdapter;
    }
}