﻿
namespace OBCS.Reports
{
    partial class Rpt_ARBalanceAccountReport
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
            this.sp_ARBalanceAccountReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ARBalanceAccountReport = new OBCS.Reports.ARBalanceAccountReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ARBalanceAccountReportTableAdapter = new OBCS.Reports.ARBalanceAccountReportTableAdapters.sp_ARBalanceAccountReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ARBalanceAccountReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARBalanceAccountReport)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_ARBalanceAccountReportBindingSource
            // 
            this.sp_ARBalanceAccountReportBindingSource.DataMember = "sp_ARBalanceAccountReport";
            this.sp_ARBalanceAccountReportBindingSource.DataSource = this.ARBalanceAccountReport;
            // 
            // ARBalanceAccountReport
            // 
            this.ARBalanceAccountReport.DataSetName = "ARBalanceAccountReport";
            this.ARBalanceAccountReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AllowDrop = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ARBalanceAccountReport";
            reportDataSource1.Value = this.sp_ARBalanceAccountReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.ARBalanceAccountReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1191, 667);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_ARBalanceAccountReportTableAdapter
            // 
            this.sp_ARBalanceAccountReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_ARBalanceAccountReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 667);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_ARBalanceAccountReport";
            this.Text = "AR Balance Account Report";
            this.Load += new System.EventHandler(this.Rpt_ARBalanceAccountReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_ARBalanceAccountReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARBalanceAccountReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_ARBalanceAccountReportBindingSource;
        private ARBalanceAccountReport ARBalanceAccountReport;
        private ARBalanceAccountReportTableAdapters.sp_ARBalanceAccountReportTableAdapter sp_ARBalanceAccountReportTableAdapter;
    }
}