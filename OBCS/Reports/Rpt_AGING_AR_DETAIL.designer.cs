namespace OBCS.Reports
{
    partial class Rpt_AGING_AR_DETAIL
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
            this.sp_AGING_AR_DETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AGING_AR_DETAIL = new OBCS.Reports.AGING_AR_DETAIL();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_AGING_AR_DETAILTableAdapter = new OBCS.Reports.AGING_AR_DETAILTableAdapters.sp_AGING_AR_DETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_AGING_AR_DETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AGING_AR_DETAIL)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_AGING_AR_DETAILBindingSource
            // 
            this.sp_AGING_AR_DETAILBindingSource.DataMember = "sp_AGING_AR_DETAIL";
            this.sp_AGING_AR_DETAILBindingSource.DataSource = this.AGING_AR_DETAIL;
            // 
            // AGING_AR_DETAIL
            // 
            this.AGING_AR_DETAIL.DataSetName = "AGING_AR_DETAIL";
            this.AGING_AR_DETAIL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AGING_AR_DETAIL";
            reportDataSource1.Value = this.sp_AGING_AR_DETAILBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.AGING_AR_DETAIL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1037, 816);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_AGING_AR_DETAILTableAdapter
            // 
            this.sp_AGING_AR_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_AGING_AR_DETAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 816);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_AGING_AR_DETAIL";
            this.Text = "AR AGING DETAIL";
            this.Load += new System.EventHandler(this.Rpt_AGING_AR_DETAIL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_AGING_AR_DETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AGING_AR_DETAIL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_AGING_AR_DETAILBindingSource;
        private AGING_AR_DETAIL AGING_AR_DETAIL;
        private AGING_AR_DETAILTableAdapters.sp_AGING_AR_DETAILTableAdapter sp_AGING_AR_DETAILTableAdapter;
    }
}