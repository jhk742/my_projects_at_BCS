namespace OBCS.Reports
{
    partial class Rpt_BulkNutLabelList
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
            this.sp_REPORT_BulkNutLabelListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BulkNutLabelList = new OBCS.Reports.BulkNutLabelList();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_REPORT_BulkNutLabelListTableAdapter = new OBCS.Reports.BulkNutLabelListTableAdapters.sp_REPORT_BulkNutLabelListTableAdapter();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.sp_REPORT_BulkNutLabelListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulkNutLabelList)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_REPORT_BulkNutLabelListBindingSource
            // 
            this.sp_REPORT_BulkNutLabelListBindingSource.DataMember = "sp_REPORT_BulkNutLabelList";
            this.sp_REPORT_BulkNutLabelListBindingSource.DataSource = this.BulkNutLabelList;
            // 
            // BulkNutLabelList
            // 
            this.BulkNutLabelList.DataSetName = "BulkNutLabelList";
            this.BulkNutLabelList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BulkNutLabelList";
            reportDataSource1.Value = this.sp_REPORT_BulkNutLabelListBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.BulkNutLabelList.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1121, 609);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.reportViewer1_RenderingComplete);
            // 
            // sp_REPORT_BulkNutLabelListTableAdapter
            // 
            this.sp_REPORT_BulkNutLabelListTableAdapter.ClearBeforeFill = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Rpt_BulkNutLabelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 609);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_BulkNutLabelList";
            this.Text = "Bulk Nut Label List Report";
            this.Load += new System.EventHandler(this.Rpt_BulkNutLabelList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_REPORT_BulkNutLabelListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulkNutLabelList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_REPORT_BulkNutLabelListBindingSource;
        private BulkNutLabelList BulkNutLabelList;
        private BulkNutLabelListTableAdapters.sp_REPORT_BulkNutLabelListTableAdapter sp_REPORT_BulkNutLabelListTableAdapter;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}