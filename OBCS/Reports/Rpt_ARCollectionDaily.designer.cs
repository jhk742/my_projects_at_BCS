namespace OBCS.Reports
{
    partial class Rpt_ARCollectionDaily
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_ARCollectionDailyReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ARCollectionDaily = new OBCS.Reports.ARCollectionDaily();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ARCollectionDailyReportTableAdapter = new OBCS.Reports.ARCollectionDailyTableAdapters.sp_ARCollectionDailyReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ARCollectionDailyReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARCollectionDaily)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_ARCollectionDailyReportBindingSource
            // 
            this.sp_ARCollectionDailyReportBindingSource.DataMember = "sp_ARCollectionDailyReport";
            this.sp_ARCollectionDailyReportBindingSource.DataSource = this.ARCollectionDaily;
            // 
            // ARCollectionDaily
            // 
            this.ARCollectionDaily.DataSetName = "ARCollectionDaily";
            this.ARCollectionDaily.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "ARCollectionDaily";
            reportDataSource2.Value = this.sp_ARCollectionDailyReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.ARCollectionDaily.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1264, 841);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_ARCollectionDailyReportTableAdapter
            // 
            this.sp_ARCollectionDailyReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_ARCollectionDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 841);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_ARCollectionDaily";
            this.Text = "Daily AR Collections Summary Report";
            this.Load += new System.EventHandler(this.Rpt_ARCollectionDaily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_ARCollectionDailyReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARCollectionDaily)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_ARCollectionDailyReportBindingSource;
        private ARCollectionDaily ARCollectionDaily;
        private ARCollectionDailyTableAdapters.sp_ARCollectionDailyReportTableAdapter sp_ARCollectionDailyReportTableAdapter;
    }
}