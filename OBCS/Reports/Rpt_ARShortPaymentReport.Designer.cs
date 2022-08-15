
namespace OBCS.Reports
{
    partial class Rpt_ARShortPaymentReport
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
            this.ARShortPaymentReport = new OBCS.Reports.ARShortPaymentReport();
            this.sp_ARShortPaymentReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ARShortPaymentReportTableAdapter = new OBCS.Reports.ARShortPaymentReportTableAdapters.sp_ARShortPaymentReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ARShortPaymentReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ARShortPaymentReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ARShortPaymentReport";
            reportDataSource1.Value = this.sp_ARShortPaymentReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.ARShortPaymentReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1134, 678);
            this.reportViewer1.TabIndex = 0;
            // 
            // ARShortPaymentReport
            // 
            this.ARShortPaymentReport.DataSetName = "ARShortPaymentReport";
            this.ARShortPaymentReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_ARShortPaymentReportBindingSource
            // 
            this.sp_ARShortPaymentReportBindingSource.DataMember = "sp_ARShortPaymentReport";
            this.sp_ARShortPaymentReportBindingSource.DataSource = this.ARShortPaymentReport;
            // 
            // sp_ARShortPaymentReportTableAdapter
            // 
            this.sp_ARShortPaymentReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_ARShortPaymentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 678);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_ARShortPaymentReport";
            this.Text = "Rpt_ARShortPaymentReport";
            this.Load += new System.EventHandler(this.Rpt_ARShortPaymentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ARShortPaymentReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ARShortPaymentReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_ARShortPaymentReportBindingSource;
        private ARShortPaymentReport ARShortPaymentReport;
        private ARShortPaymentReportTableAdapters.sp_ARShortPaymentReportTableAdapter sp_ARShortPaymentReportTableAdapter;
    }
}