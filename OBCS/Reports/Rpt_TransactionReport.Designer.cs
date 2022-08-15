
namespace OBCS.Reports
{
    partial class Rpt_TransactionReport
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
            this.TransactionReport = new OBCS.Reports.TransactionReport();
            this.sp_TRANSACTION_REPORT_DETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_TRANSACTION_REPORT_DETAILTableAdapter = new OBCS.Reports.TransactionReportTableAdapters.sp_TRANSACTION_REPORT_DETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_TRANSACTION_REPORT_DETAILBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TransactionReport";
            reportDataSource1.Value = this.sp_TRANSACTION_REPORT_DETAILBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.TransactionReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1127, 694);
            this.reportViewer1.TabIndex = 0;
            // 
            // TransactionReport
            // 
            this.TransactionReport.DataSetName = "TransactionReport";
            this.TransactionReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_TRANSACTION_REPORT_DETAILBindingSource
            // 
            this.sp_TRANSACTION_REPORT_DETAILBindingSource.DataMember = "sp_TRANSACTION_REPORT_DETAIL";
            this.sp_TRANSACTION_REPORT_DETAILBindingSource.DataSource = this.TransactionReport;
            // 
            // sp_TRANSACTION_REPORT_DETAILTableAdapter
            // 
            this.sp_TRANSACTION_REPORT_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_TransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 694);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_TransactionReport";
            this.Text = "Rpt_TransactionReport";
            this.Load += new System.EventHandler(this.Rpt_TransactionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_TRANSACTION_REPORT_DETAILBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_TRANSACTION_REPORT_DETAILBindingSource;
        private TransactionReport TransactionReport;
        private TransactionReportTableAdapters.sp_TRANSACTION_REPORT_DETAILTableAdapter sp_TRANSACTION_REPORT_DETAILTableAdapter;
    }
}