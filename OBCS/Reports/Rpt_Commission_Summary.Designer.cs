namespace OBCS.Reports
{
    partial class Rpt_Commission_Summary
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
            this.CommissionSummary = new OBCS.Reports.CommissionSummary();
            this.sp_Commission_SummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Commission_SummaryTableAdapter = new OBCS.Reports.CommissionSummaryTableAdapters.sp_Commission_SummaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CommissionSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Commission_SummaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CommissionSummary";
            reportDataSource1.Value = this.sp_Commission_SummaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.CommissionSummary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1041, 658);
            this.reportViewer1.TabIndex = 0;
            // 
            // CommissionSummary
            // 
            this.CommissionSummary.DataSetName = "CommissionSummary";
            this.CommissionSummary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_Commission_SummaryBindingSource
            // 
            this.sp_Commission_SummaryBindingSource.DataMember = "sp_Commission_Summary";
            this.sp_Commission_SummaryBindingSource.DataSource = this.CommissionSummary;
            // 
            // sp_Commission_SummaryTableAdapter
            // 
            this.sp_Commission_SummaryTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_Commission_Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 658);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_Commission_Summary";
            this.Text = "Commission Summary Report";
            this.Load += new System.EventHandler(this.Rpt_Commission_Summary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CommissionSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Commission_SummaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Commission_SummaryBindingSource;
        private CommissionSummary CommissionSummary;
        private CommissionSummaryTableAdapters.sp_Commission_SummaryTableAdapter sp_Commission_SummaryTableAdapter;
    }
}