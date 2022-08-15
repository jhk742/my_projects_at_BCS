namespace OBCS.Reports
{
    partial class Rpt_ARCollectionMonthly
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
            this.sp_ARCollectionMonthlyReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ARCollectionMonthly = new OBCS.Reports.ARCollectionMonthly();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ARCollectionMonthlyReportTableAdapter = new OBCS.Reports.ARCollectionMonthlyTableAdapters.sp_ARCollectionMonthlyReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ARCollectionMonthlyReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARCollectionMonthly)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_ARCollectionMonthlyReportBindingSource
            // 
            this.sp_ARCollectionMonthlyReportBindingSource.DataMember = "sp_ARCollectionMonthlyReport";
            this.sp_ARCollectionMonthlyReportBindingSource.DataSource = this.ARCollectionMonthly;
            // 
            // ARCollectionMonthly
            // 
            this.ARCollectionMonthly.DataSetName = "ARCollectionMonthly";
            this.ARCollectionMonthly.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ARCollectionMonthly";
            reportDataSource1.Value = this.sp_ARCollectionMonthlyReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.ARCollectionMonthly.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1264, 841);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_ARCollectionMonthlyReportTableAdapter
            // 
            this.sp_ARCollectionMonthlyReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_ARCollectionMonthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 841);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_ARCollectionMonthly";
            this.Text = "Monthly AR Collections Summary Report";
            this.Load += new System.EventHandler(this.Rpt_ARCollectionMonthly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_ARCollectionMonthlyReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARCollectionMonthly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_ARCollectionMonthlyReportBindingSource;
        private ARCollectionMonthly ARCollectionMonthly;
        private ARCollectionMonthlyTableAdapters.sp_ARCollectionMonthlyReportTableAdapter sp_ARCollectionMonthlyReportTableAdapter;
    }
}