namespace OBCS.Reports
{
    partial class Rpt_SubcontractExceptionReport
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
            this.SubContractExceptionReport = new OBCS.Reports.SubContractExceptionReport();
            this.sp_SubcontractExceptionReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SubcontractExceptionReportTableAdapter = new OBCS.Reports.SubContractExceptionReportTableAdapters.sp_SubcontractExceptionReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SubContractExceptionReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SubcontractExceptionReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SubcontractExceptionReport";
            reportDataSource1.Value = this.sp_SubcontractExceptionReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.SubcontractExceptionReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1176, 655);
            this.reportViewer1.TabIndex = 0;
            // 
            // SubContractExceptionReport
            // 
            this.SubContractExceptionReport.DataSetName = "SubContractExceptionReport";
            this.SubContractExceptionReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_SubcontractExceptionReportBindingSource
            // 
            this.sp_SubcontractExceptionReportBindingSource.DataMember = "sp_SubcontractExceptionReport";
            this.sp_SubcontractExceptionReportBindingSource.DataSource = this.SubContractExceptionReport;
            // 
            // sp_SubcontractExceptionReportTableAdapter
            // 
            this.sp_SubcontractExceptionReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_SubcontractExceptionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 655);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_SubcontractExceptionReport";
            this.Text = "Subcontract Exception Report";
            this.Load += new System.EventHandler(this.Rpt_SubcontractExceptionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubContractExceptionReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SubcontractExceptionReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_SubcontractExceptionReportBindingSource;
        private SubContractExceptionReport SubContractExceptionReport;
        private SubContractExceptionReportTableAdapters.sp_SubcontractExceptionReportTableAdapter sp_SubcontractExceptionReportTableAdapter;
    }
}