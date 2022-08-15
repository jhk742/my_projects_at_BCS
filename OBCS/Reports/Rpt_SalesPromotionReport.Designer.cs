
namespace OBCS.Reports
{
    partial class Rpt_SalesPromotionReport
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
            this.SalesPromotionReport = new OBCS.Reports.SalesPromotionReport();
            this.sp_SalesPromotionReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SalesPromotionReportTableAdapter = new OBCS.Reports.SalesPromotionReportTableAdapters.sp_SalesPromotionReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SalesPromotionReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SalesPromotionReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SalesPromotionReport";
            reportDataSource1.Value = this.sp_SalesPromotionReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.SalesPromotionReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1105, 653);
            this.reportViewer1.TabIndex = 0;
            // 
            // SalesPromotionReport
            // 
            this.SalesPromotionReport.DataSetName = "SalesPromotionReport";
            this.SalesPromotionReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_SalesPromotionReportBindingSource
            // 
            this.sp_SalesPromotionReportBindingSource.DataMember = "sp_SalesPromotionReport";
            this.sp_SalesPromotionReportBindingSource.DataSource = this.SalesPromotionReport;
            // 
            // sp_SalesPromotionReportTableAdapter
            // 
            this.sp_SalesPromotionReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_SalesPromotionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 653);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_SalesPromotionReport";
            this.Text = "Sales Promotion Report";
            this.Load += new System.EventHandler(this.Rpt_SalesPromotionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesPromotionReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SalesPromotionReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_SalesPromotionReportBindingSource;
        private SalesPromotionReport SalesPromotionReport;
        private SalesPromotionReportTableAdapters.sp_SalesPromotionReportTableAdapter sp_SalesPromotionReportTableAdapter;
    }
}