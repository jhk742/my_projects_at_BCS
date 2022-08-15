namespace OBCS.Reports
{
    partial class Rpt_NSFReport
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
            this.sp_NSFReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NSFReport = new OBCS.Reports.NSFReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_NSFReportTableAdapter = new OBCS.Reports.NSFReportTableAdapters.sp_NSFReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_NSFReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSFReport)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_NSFReportBindingSource
            // 
            this.sp_NSFReportBindingSource.DataMember = "sp_NSFReport";
            this.sp_NSFReportBindingSource.DataSource = this.NSFReport;
            // 
            // NSFReport
            // 
            this.NSFReport.DataSetName = "NSFReport";
            this.NSFReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "NSFReport";
            reportDataSource1.Value = this.sp_NSFReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.NSFReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1077, 849);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_NSFReportTableAdapter
            // 
            this.sp_NSFReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_NSFReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 849);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_NSFReport";
            this.Text = "Non Sufficient Funds Report";
            this.Load += new System.EventHandler(this.Rpt_NSFReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_NSFReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSFReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_NSFReportBindingSource;
        private NSFReport NSFReport;
        private NSFReportTableAdapters.sp_NSFReportTableAdapter sp_NSFReportTableAdapter;
    }
}