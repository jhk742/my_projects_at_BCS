namespace OBCS.Reports
{
    partial class Rpt_ARSalesDebitMemoDaily
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
            this.sp_ARDailySalesDebitMemoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ARSalesDebitMemoDaily = new OBCS.Reports.ARSalesDebitMemoDaily();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ARDailySalesDebitMemoTableAdapter = new OBCS.Reports.ARSalesDebitMemoDailyTableAdapters.sp_ARDailySalesDebitMemoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ARDailySalesDebitMemoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARSalesDebitMemoDaily)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_ARDailySalesDebitMemoBindingSource
            // 
            this.sp_ARDailySalesDebitMemoBindingSource.DataMember = "sp_ARDailySalesDebitMemo";
            this.sp_ARDailySalesDebitMemoBindingSource.DataSource = this.ARSalesDebitMemoDaily;
            // 
            // ARSalesDebitMemoDaily
            // 
            this.ARSalesDebitMemoDaily.DataSetName = "ARSalesDebitMemoDaily";
            this.ARSalesDebitMemoDaily.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ARSalesDebitMemoDaily";
            reportDataSource1.Value = this.sp_ARDailySalesDebitMemoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.ARSalesDebitMemoDaily.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1264, 841);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_ARDailySalesDebitMemoTableAdapter
            // 
            this.sp_ARDailySalesDebitMemoTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_ARSalesDebitMemoDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 841);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_ARSalesDebitMemoDaily";
            this.Text = "Daily AR Sales Debit Memo Summary Report";
            this.Load += new System.EventHandler(this.Rpt_ARSalesDebitMemoDaily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_ARDailySalesDebitMemoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARSalesDebitMemoDaily)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_ARDailySalesDebitMemoBindingSource;
        private ARSalesDebitMemoDaily ARSalesDebitMemoDaily;
        private ARSalesDebitMemoDailyTableAdapters.sp_ARDailySalesDebitMemoTableAdapter sp_ARDailySalesDebitMemoTableAdapter;
    }
}