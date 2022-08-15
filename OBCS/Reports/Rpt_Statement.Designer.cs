namespace OBCS.Reports
{
    partial class Rpt_Statement
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
            this.sp_Rpt_StatementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StatementReport = new OBCS.Reports.StatementReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_Rpt_StatementTableAdapter = new OBCS.Reports.StatementReportTableAdapters.sp_Rpt_StatementTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Rpt_StatementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatementReport)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Rpt_StatementBindingSource
            // 
            this.sp_Rpt_StatementBindingSource.DataMember = "sp_Rpt_Statement";
            this.sp_Rpt_StatementBindingSource.DataSource = this.StatementReport;
            // 
            // StatementReport
            // 
            this.StatementReport.DataSetName = "StatementReport";
            this.StatementReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StatementReport";
            reportDataSource1.Value = this.sp_Rpt_StatementBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.StatementReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1159, 662);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_Rpt_StatementTableAdapter
            // 
            this.sp_Rpt_StatementTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 662);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_Statement";
            this.Text = "Statement";
            this.Load += new System.EventHandler(this.Rpt_Statement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Rpt_StatementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatementReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Rpt_StatementBindingSource;
        private StatementReport StatementReport;
        private StatementReportTableAdapters.sp_Rpt_StatementTableAdapter sp_Rpt_StatementTableAdapter;
    }
}