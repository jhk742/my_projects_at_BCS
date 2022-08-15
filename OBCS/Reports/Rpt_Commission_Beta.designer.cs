namespace OBCS.Reports
{
    partial class Rpt_Commission_Beta
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
            this.sp_Commission_BETABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommissionReport_Beta = new OBCS.Reports.CommissionReport_Beta();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_Commission_BETATableAdapter = new OBCS.Reports.CommissionReport_BetaTableAdapters.sp_Commission_BETATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Commission_BETABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommissionReport_Beta)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Commission_BETABindingSource
            // 
            this.sp_Commission_BETABindingSource.DataMember = "sp_Commission_BETA";
            this.sp_Commission_BETABindingSource.DataSource = this.CommissionReport_Beta;
            // 
            // CommissionReport_Beta
            // 
            this.CommissionReport_Beta.DataSetName = "CommissionReport_Beta";
            this.CommissionReport_Beta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "CommissionReport_Beta";
            reportDataSource2.Value = this.sp_Commission_BETABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.CommissionReport_Beta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1036, 914);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_Commission_BETATableAdapter
            // 
            this.sp_Commission_BETATableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_Commission_Beta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 914);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_Commission_Beta";
            this.Text = "Commission Detail Report";
            this.Load += new System.EventHandler(this.Rpt_Commission_Beta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Commission_BETABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommissionReport_Beta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Commission_BETABindingSource;
        private CommissionReport_Beta CommissionReport_Beta;
        private CommissionReport_BetaTableAdapters.sp_Commission_BETATableAdapter sp_Commission_BETATableAdapter;
    }
}