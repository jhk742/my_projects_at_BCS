namespace OBCS.Reports
{
    partial class Rpt_AGING_AP_SUMMARY
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
            this.sp_AGING_AP_SUMMARYBindingSource = new System.Windows.Forms.BindingSource();
            this.AGING_AP_SUMMARY = new OBCS.Reports.AGING_AP_SUMMARY();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_AGING_AP_SUMMARYTableAdapter = new OBCS.Reports.AGING_AP_SUMMARYTableAdapters.sp_AGING_AP_SUMMARYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_AGING_AP_SUMMARYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AGING_AP_SUMMARY)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_AGING_AP_SUMMARYBindingSource
            // 
            this.sp_AGING_AP_SUMMARYBindingSource.DataMember = "sp_AGING_AP_SUMMARY";
            this.sp_AGING_AP_SUMMARYBindingSource.DataSource = this.AGING_AP_SUMMARY;
            // 
            // AGING_AP_SUMMARY
            // 
            this.AGING_AP_SUMMARY.DataSetName = "AGING_AP_SUMMARY";
            this.AGING_AP_SUMMARY.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AGING_AP_SUMMARY";
            reportDataSource1.Value = this.sp_AGING_AP_SUMMARYBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.AGING_AP_SUMMARY.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1220, 752);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_AGING_AP_SUMMARYTableAdapter
            // 
            this.sp_AGING_AP_SUMMARYTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_AGING_AP_SUMMARY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 752);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_AGING_AP_SUMMARY";
            this.Text = "AP AGING SUMMARY";
            this.Load += new System.EventHandler(this.Rpt_AGING_AP_SUMMARY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_AGING_AP_SUMMARYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AGING_AP_SUMMARY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_AGING_AP_SUMMARYBindingSource;
        private AGING_AP_SUMMARY AGING_AP_SUMMARY;
        private AGING_AP_SUMMARYTableAdapters.sp_AGING_AP_SUMMARYTableAdapter sp_AGING_AP_SUMMARYTableAdapter;
    }
}