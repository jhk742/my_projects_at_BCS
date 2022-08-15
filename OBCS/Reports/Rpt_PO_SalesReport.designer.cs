namespace OBCS.Reports
{
    partial class Rpt_PO_SalesReport
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
            this.PO_SalesReport = new OBCS.Reports.PO_SalesReport();
            this.sp_PO_SalesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_PO_SalesReportTableAdapter = new OBCS.Reports.PO_SalesReportTableAdapters.sp_PO_SalesReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PO_SalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PO_SalesReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PO_SalesReport";
            reportDataSource1.Value = this.sp_PO_SalesReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.PO_SalesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1008, 583);
            this.reportViewer1.TabIndex = 0;
            // 
            // PO_SalesReport
            // 
            this.PO_SalesReport.DataSetName = "PO_SalesReport";
            this.PO_SalesReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_PO_SalesReportBindingSource
            // 
            this.sp_PO_SalesReportBindingSource.DataMember = "sp_PO_SalesReport";
            this.sp_PO_SalesReportBindingSource.DataSource = this.PO_SalesReport;
            // 
            // sp_PO_SalesReportTableAdapter
            // 
            this.sp_PO_SalesReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_PO_SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 583);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_PO_SalesReport";
            this.Text = "PO Sales Report";
            this.Load += new System.EventHandler(this.Rpt_PO_SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PO_SalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PO_SalesReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_PO_SalesReportBindingSource;
        private PO_SalesReport PO_SalesReport;
        private PO_SalesReportTableAdapters.sp_PO_SalesReportTableAdapter sp_PO_SalesReportTableAdapter;
    }
}