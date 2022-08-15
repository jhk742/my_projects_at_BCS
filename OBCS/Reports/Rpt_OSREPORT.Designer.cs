namespace OBCS.Reports
{
    partial class Rpt_OSREPORT
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_OSReportBindingSource = new System.Windows.Forms.BindingSource();
            this.OSREPORT = new OBCS.Reports.OSREPORT();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_OSReportTableAdapter = new OBCS.Reports.OSREPORTTableAdapters.sp_OSReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_OSReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OSREPORT)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_OSReportBindingSource
            // 
            this.sp_OSReportBindingSource.DataMember = "sp_OSReport";
            this.sp_OSReportBindingSource.DataSource = this.OSREPORT;
            // 
            // OSREPORT
            // 
            this.OSREPORT.DataSetName = "OSREPORT";
            this.OSREPORT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OSREPORT";
            reportDataSource1.Value = this.sp_OSReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.OSREPORT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1068, 917);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_OSReportTableAdapter
            // 
            this.sp_OSReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_OSREPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 917);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_OSREPORT";
            this.Text = "OS Report";
            this.Load += new System.EventHandler(this.Rpt_OSREPORT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_OSReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OSREPORT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_OSReportBindingSource;
        private OSREPORT OSREPORT;
        private OSREPORTTableAdapters.sp_OSReportTableAdapter sp_OSReportTableAdapter;
    }
}