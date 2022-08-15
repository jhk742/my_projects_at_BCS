
namespace OBCS.Reports
{
    partial class Rpt_PRECEIPTS
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
            this.sp_PRECEIPT_DETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRECEIPTS = new OBCS.Reports.PRECEIPTS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_PRECEIPT_DETAILTableAdapter = new OBCS.Reports.PRECEIPTSTableAdapters.sp_PRECEIPT_DETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PRECEIPT_DETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRECEIPTS)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_PRECEIPT_DETAILBindingSource
            // 
            this.sp_PRECEIPT_DETAILBindingSource.DataMember = "sp_PRECEIPT_DETAIL";
            this.sp_PRECEIPT_DETAILBindingSource.DataSource = this.PRECEIPTS;
            // 
            // PRECEIPTS
            // 
            this.PRECEIPTS.DataSetName = "PRECEIPTS";
            this.PRECEIPTS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PRECEIPTS";
            reportDataSource1.Value = this.sp_PRECEIPT_DETAILBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.PRECEIPTS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1320, 898);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_PRECEIPT_DETAILTableAdapter
            // 
            this.sp_PRECEIPT_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_PRECEIPTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 898);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_PRECEIPTS";
            this.Text = "Rpt_PRECEIPTS";
            this.Load += new System.EventHandler(this.Rpt_PRECEIPTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_PRECEIPT_DETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRECEIPTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_PRECEIPT_DETAILBindingSource;
        private PRECEIPTS PRECEIPTS;
        private PRECEIPTSTableAdapters.sp_PRECEIPT_DETAILTableAdapter sp_PRECEIPT_DETAILTableAdapter;
    }
}