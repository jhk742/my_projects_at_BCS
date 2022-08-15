namespace OBCS.Reports
{
    partial class Rpt_Commission
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
            this.sp_CommissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommissionReport = new OBCS.Reports.CommissionReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_CommissionTableAdapter = new OBCS.Reports.CommissionReportTableAdapters.sp_CommissionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CommissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommissionReport)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_CommissionBindingSource
            // 
            this.sp_CommissionBindingSource.DataMember = "sp_Commission";
            this.sp_CommissionBindingSource.DataSource = this.CommissionReport;
            // 
            // CommissionReport
            // 
            this.CommissionReport.DataSetName = "CommissionReport";
            this.CommissionReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CommissionReport";
            reportDataSource1.Value = this.sp_CommissionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.CommissionReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1036, 914);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_CommissionTableAdapter
            // 
            this.sp_CommissionTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_Commission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 914);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_Commission";
            this.Text = "Commission Detail Report";
            this.Load += new System.EventHandler(this.Rpt_Commission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_CommissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommissionReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_CommissionBindingSource;
        private CommissionReport CommissionReport;
        private CommissionReportTableAdapters.sp_CommissionTableAdapter sp_CommissionTableAdapter;
    }
}