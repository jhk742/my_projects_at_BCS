
namespace OBCS.Reports
{
    partial class Rpt_Commission_091521
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
            this.sp_Commission_091521BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommissionReport_091521 = new OBCS.Reports.CommissionReport_091521();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_Commission_091521TableAdapter = new OBCS.Reports.CommissionReport_091521TableAdapters.sp_Commission_091521TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Commission_091521BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommissionReport_091521)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Commission_091521BindingSource
            // 
            this.sp_Commission_091521BindingSource.DataMember = "sp_Commission_091521";
            this.sp_Commission_091521BindingSource.DataSource = this.CommissionReport_091521;
            // 
            // CommissionReport_091521
            // 
            this.CommissionReport_091521.DataSetName = "CommissionReport_091521";
            this.CommissionReport_091521.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "CommissionReport_091521";
            reportDataSource2.Value = this.sp_Commission_091521BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.CommissionReport_091521.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1036, 914);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_Commission_091521TableAdapter
            // 
            this.sp_Commission_091521TableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_Commission_091521
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 914);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_Commission_091521";
            this.Text = "Commission Detail Report";
            this.Load += new System.EventHandler(this.Rpt_Commission_091521_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Commission_091521BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommissionReport_091521)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Commission_091521BindingSource;
        private CommissionReport_091521 CommissionReport_091521;
        private CommissionReport_091521TableAdapters.sp_Commission_091521TableAdapter sp_Commission_091521TableAdapter;
    }
}