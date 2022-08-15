namespace OBCS.Reports
{
    partial class Rpt_SalesbyRepReport
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
            this.sp_SalesbyRepReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesbyRepReport = new OBCS.Reports.SalesbyRepReport();
            this.sp_SalesbyRepReportTableAdapter = new OBCS.Reports.SalesbyRepReportTableAdapters.sp_SalesbyRepReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SalesbyRepReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesbyRepReport)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SalesbyRepReport";
            reportDataSource1.Value = this.sp_SalesbyRepReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.SalesbyRepReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1439, 941);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_SalesbyRepReportBindingSource
            // 
            this.sp_SalesbyRepReportBindingSource.DataMember = "sp_SalesbyRepReport";
            this.sp_SalesbyRepReportBindingSource.DataSource = this.SalesbyRepReport;
            // 
            // SalesbyRepReport
            // 
            this.SalesbyRepReport.DataSetName = "SalesbyRepReport";
            this.SalesbyRepReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_SalesbyRepReportTableAdapter
            // 
            this.sp_SalesbyRepReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_SalesbyRepReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 941);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_SalesbyRepReport";
            this.Text = "Sales by Rep Report";
            this.Load += new System.EventHandler(this.Rpt_SalesbyRepReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_SalesbyRepReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesbyRepReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_SalesbyRepReportBindingSource;
        private SalesbyRepReport SalesbyRepReport;
        private SalesbyRepReportTableAdapters.sp_SalesbyRepReportTableAdapter sp_SalesbyRepReportTableAdapter;
    }
}