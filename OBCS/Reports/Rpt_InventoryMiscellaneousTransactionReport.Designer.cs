
namespace OBCS.Reports
{
    partial class Rpt_InventoryMiscellaneousTransactionReport
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
            this.sp_InventoryMiscellaneousTransactionReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InventoryMiscellaneousTransactionReport = new OBCS.Reports.InventoryMiscellaneousTransactionReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_InventoryMiscellaneousTransactionReportTableAdapter = new OBCS.Reports.InventoryMiscellaneousTransactionReportTableAdapters.sp_InventoryMiscellaneousTransactionReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InventoryMiscellaneousTransactionReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryMiscellaneousTransactionReport)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_InventoryMiscellaneousTransactionReportBindingSource
            // 
            this.sp_InventoryMiscellaneousTransactionReportBindingSource.DataMember = "sp_InventoryMiscellaneousTransactionReport";
            this.sp_InventoryMiscellaneousTransactionReportBindingSource.DataSource = this.InventoryMiscellaneousTransactionReport;
            // 
            // InventoryMiscellaneousTransactionReport
            // 
            this.InventoryMiscellaneousTransactionReport.DataSetName = "InventoryMiscellaneousTransactionReport";
            this.InventoryMiscellaneousTransactionReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "InventoryMiscellaneousTransactionReport";
            reportDataSource1.Value = this.sp_InventoryMiscellaneousTransactionReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.InventoryMiscellaneousTransactionReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1232, 650);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_InventoryMiscellaneousTransactionReportTableAdapter
            // 
            this.sp_InventoryMiscellaneousTransactionReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_InventoryMiscellaneousTransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 650);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_InventoryMiscellaneousTransactionReport";
            this.Text = "Miscellaneous Transaction Report";
            this.Load += new System.EventHandler(this.Rpt_InventoryMiscellaneousTransactionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_InventoryMiscellaneousTransactionReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryMiscellaneousTransactionReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_InventoryMiscellaneousTransactionReportBindingSource;
        private InventoryMiscellaneousTransactionReport InventoryMiscellaneousTransactionReport;
        private InventoryMiscellaneousTransactionReportTableAdapters.sp_InventoryMiscellaneousTransactionReportTableAdapter sp_InventoryMiscellaneousTransactionReportTableAdapter;
    }
}