namespace OBCS.Reports
{
    partial class Rpt_Top_Product_Report_Summary
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
            this.sp_Top_Product_Report_SummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Top_Product_Report_Summary = new OBCS.Reports.Top_Product_Report_Summary();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_Top_Product_Report_SummaryTableAdapter = new OBCS.Reports.Top_Product_Report_SummaryTableAdapters.sp_Top_Product_Report_SummaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Top_Product_Report_SummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top_Product_Report_Summary)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Top_Product_Report_SummaryBindingSource
            // 
            this.sp_Top_Product_Report_SummaryBindingSource.DataMember = "sp_Top_Product_Report_Summary";
            this.sp_Top_Product_Report_SummaryBindingSource.DataSource = this.Top_Product_Report_Summary;
            // 
            // Top_Product_Report_Summary
            // 
            this.Top_Product_Report_Summary.DataSetName = "Top_Product_Report_Summary";
            this.Top_Product_Report_Summary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Top_Product_Report_Summary";
            reportDataSource1.Value = this.sp_Top_Product_Report_SummaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.Top_Product_Report_Summary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(892, 775);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_Top_Product_Report_SummaryTableAdapter
            // 
            this.sp_Top_Product_Report_SummaryTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_Top_Product_Report_Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 775);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_Top_Product_Report_Summary";
            this.Text = "Top Product Report Summary";
            this.Load += new System.EventHandler(this.Rpt_Top_Product_Report_Summary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Top_Product_Report_SummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top_Product_Report_Summary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Top_Product_Report_SummaryBindingSource;
        private Top_Product_Report_Summary Top_Product_Report_Summary;
        private Top_Product_Report_SummaryTableAdapters.sp_Top_Product_Report_SummaryTableAdapter sp_Top_Product_Report_SummaryTableAdapter;
    }
}