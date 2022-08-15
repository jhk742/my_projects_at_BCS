namespace OBCS.Reports
{
    partial class Rpt_StockValuationReport
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
            this.StockValuationReport = new OBCS.Reports.StockValuationReport();
            this.sp_StockValuationReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_StockValuationReportTableAdapter = new OBCS.Reports.StockValuationReportTableAdapters.sp_StockValuationReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StockValuationReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_StockValuationReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StockValuationReport";
            reportDataSource1.Value = this.sp_StockValuationReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.StockValuationReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1011, 556);
            this.reportViewer1.TabIndex = 0;
            // 
            // StockValuationReport
            // 
            this.StockValuationReport.DataSetName = "StockValuationReport";
            this.StockValuationReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_StockValuationReportBindingSource
            // 
            this.sp_StockValuationReportBindingSource.DataMember = "sp_StockValuationReport";
            this.sp_StockValuationReportBindingSource.DataSource = this.StockValuationReport;
            // 
            // sp_StockValuationReportTableAdapter
            // 
            this.sp_StockValuationReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_StockValuationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 556);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_StockValuationReport";
            this.Text = "Stock Valuation Report";
            this.Load += new System.EventHandler(this.Rpt_StockValuationReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockValuationReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_StockValuationReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_StockValuationReportBindingSource;
        private StockValuationReport StockValuationReport;
        private StockValuationReportTableAdapters.sp_StockValuationReportTableAdapter sp_StockValuationReportTableAdapter;
    }
}