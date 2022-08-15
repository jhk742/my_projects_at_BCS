
namespace OBCS.Reports
{
    partial class Rpt_SalesbyCustomerDetailReport
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
            this.SalesbyCustomerDetailReport = new OBCS.Reports.SalesbyCustomerDetailReport();
            this.sp_SalesbyCustomerDetailReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SalesbyCustomerDetailReportTableAdapter = new OBCS.Reports.SalesbyCustomerDetailReportTableAdapters.sp_SalesbyCustomerDetailReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SalesbyCustomerDetailReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SalesbyCustomerDetailReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SalesbyCustomerDetailReport";
            reportDataSource1.Value = this.sp_SalesbyCustomerDetailReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.SalesbyCustomerDetailReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1340, 827);
            this.reportViewer1.TabIndex = 0;
            // 
            // SalesbyCustomerDetailReport
            // 
            this.SalesbyCustomerDetailReport.DataSetName = "SalesbyCustomerDetailReport";
            this.SalesbyCustomerDetailReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_SalesbyCustomerDetailReportBindingSource
            // 
            this.sp_SalesbyCustomerDetailReportBindingSource.DataMember = "sp_SalesbyCustomerDetailReport";
            this.sp_SalesbyCustomerDetailReportBindingSource.DataSource = this.SalesbyCustomerDetailReport;
            // 
            // sp_SalesbyCustomerDetailReportTableAdapter
            // 
            this.sp_SalesbyCustomerDetailReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_SalesbyCustomerDetailReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 827);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_SalesbyCustomerDetailReport";
            this.Text = "Rpt_SalesbyCustomerDetailReport";
            this.Load += new System.EventHandler(this.Rpt_SalesbyCustomerDetailReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesbyCustomerDetailReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SalesbyCustomerDetailReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_SalesbyCustomerDetailReportBindingSource;
        private SalesbyCustomerDetailReport SalesbyCustomerDetailReport;
        private SalesbyCustomerDetailReportTableAdapters.sp_SalesbyCustomerDetailReportTableAdapter sp_SalesbyCustomerDetailReportTableAdapter;
    }
}