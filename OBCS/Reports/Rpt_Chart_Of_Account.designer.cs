namespace OBCS.Reports
{
    partial class Rpt_Chart_Of_Account
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
            this.sp_ACCOUNT_CHARTOFACCOUNT_DETAILBindingSource = new System.Windows.Forms.BindingSource();
            this.ChartOfAccount = new OBCS.Reports.ChartOfAccount();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ACCOUNT_CHARTOFACCOUNT_DETAILTableAdapter = new OBCS.Reports.ChartOfAccountTableAdapters.sp_ACCOUNT_CHARTOFACCOUNT_DETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ACCOUNT_CHARTOFACCOUNT_DETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_ACCOUNT_CHARTOFACCOUNT_DETAILBindingSource
            // 
            this.sp_ACCOUNT_CHARTOFACCOUNT_DETAILBindingSource.DataMember = "sp_ACCOUNT_CHARTOFACCOUNT_DETAIL";
            this.sp_ACCOUNT_CHARTOFACCOUNT_DETAILBindingSource.DataSource = this.ChartOfAccount;
            // 
            // ChartOfAccount
            // 
            this.ChartOfAccount.DataSetName = "ChartOfAccount";
            this.ChartOfAccount.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ChartOfAccount";
            reportDataSource1.Value = this.sp_ACCOUNT_CHARTOFACCOUNT_DETAILBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.ChartOfAccount.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1247, 719);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_ACCOUNT_CHARTOFACCOUNT_DETAILTableAdapter
            // 
            this.sp_ACCOUNT_CHARTOFACCOUNT_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_Chart_Of_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 719);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_Chart_Of_Account";
            this.Text = "Chart of account detail";
            this.Load += new System.EventHandler(this.Rpt_Chart_Of_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_ACCOUNT_CHARTOFACCOUNT_DETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_ACCOUNT_CHARTOFACCOUNT_DETAILBindingSource;
        private ChartOfAccount ChartOfAccount;
        private ChartOfAccountTableAdapters.sp_ACCOUNT_CHARTOFACCOUNT_DETAILTableAdapter sp_ACCOUNT_CHARTOFACCOUNT_DETAILTableAdapter;
    }
}