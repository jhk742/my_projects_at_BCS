namespace OBCS.Reports
{
    partial class Rpt_Commission_Summary_Beta
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
            this.sp_Commission_Summary_BETABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommissionSummary_Beta = new OBCS.Reports.CommissionSummary_Beta();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_Commission_Summary_BETATableAdapter = new OBCS.Reports.CommissionSummary_BetaTableAdapters.sp_Commission_Summary_BETATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Commission_Summary_BETABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommissionSummary_Beta)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Commission_Summary_BETABindingSource
            // 
            this.sp_Commission_Summary_BETABindingSource.DataMember = "sp_Commission_Summary_BETA";
            this.sp_Commission_Summary_BETABindingSource.DataSource = this.CommissionSummary_Beta;
            // 
            // CommissionSummary_Beta
            // 
            this.CommissionSummary_Beta.DataSetName = "CommissionSummary_Beta";
            this.CommissionSummary_Beta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CommissionSummary_Beta";
            reportDataSource1.Value = this.sp_Commission_Summary_BETABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.CommissionSummary_Beta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1360, 754);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_Commission_Summary_BETATableAdapter
            // 
            this.sp_Commission_Summary_BETATableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_Commission_Summary_Beta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 754);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_Commission_Summary_Beta";
            this.Text = "Commission Summary Report";
            this.Load += new System.EventHandler(this.Rpt_Commission_Summary_Beta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Commission_Summary_BETABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommissionSummary_Beta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Commission_Summary_BETABindingSource;
        private CommissionSummary_Beta CommissionSummary_Beta;
        private CommissionSummary_BetaTableAdapters.sp_Commission_Summary_BETATableAdapter sp_Commission_Summary_BETATableAdapter;
    }
}