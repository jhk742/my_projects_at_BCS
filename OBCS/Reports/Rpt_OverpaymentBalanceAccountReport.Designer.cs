
namespace OBCS.Reports
{
    partial class Rpt_OverpaymentBalanceAccountReport
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
            this.sp_OverpaymentBalanceAccountReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OverpaymentBalanceAccountReport = new OBCS.Reports.OverpaymentBalanceAccountReport();
            this.sp_OverpaymentBalanceAccountReportTableAdapter = new OBCS.Reports.OverpaymentBalanceAccountReportTableAdapters.sp_OverpaymentBalanceAccountReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_OverpaymentBalanceAccountReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverpaymentBalanceAccountReport)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OverpaymentBalanceAccountReport";
            reportDataSource1.Value = this.sp_OverpaymentBalanceAccountReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.OverpaymentBalanceAccountReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1152, 645);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_OverpaymentBalanceAccountReportBindingSource
            // 
            this.sp_OverpaymentBalanceAccountReportBindingSource.DataMember = "sp_OverpaymentBalanceAccountReport";
            this.sp_OverpaymentBalanceAccountReportBindingSource.DataSource = this.OverpaymentBalanceAccountReport;
            // 
            // OverpaymentBalanceAccountReport
            // 
            this.OverpaymentBalanceAccountReport.DataSetName = "OverpaymentBalanceAccountReport";
            this.OverpaymentBalanceAccountReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_OverpaymentBalanceAccountReportTableAdapter
            // 
            this.sp_OverpaymentBalanceAccountReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_OverpaymentBalanceAccountReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 645);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_OverpaymentBalanceAccountReport";
            this.Text = "Overpayment Balance Account Report";
            this.Load += new System.EventHandler(this.Rpt_OverpaymentBalanceAccountReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_OverpaymentBalanceAccountReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverpaymentBalanceAccountReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_OverpaymentBalanceAccountReportBindingSource;
        private OverpaymentBalanceAccountReport OverpaymentBalanceAccountReport;
        private OverpaymentBalanceAccountReportTableAdapters.sp_OverpaymentBalanceAccountReportTableAdapter sp_OverpaymentBalanceAccountReportTableAdapter;
    }
}