namespace OBCS.Reports
{
    partial class Rpt_ARSalesDebitMemoMonthly
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
            this.sp_ARMonthlySalesDebitMemoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ARSalesDebitMemoMonthly = new OBCS.Reports.ARSalesDebitMemoMonthly();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ARMonthlySalesDebitMemoTableAdapter = new OBCS.Reports.ARSalesDebitMemoMonthlyTableAdapters.sp_ARMonthlySalesDebitMemoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ARMonthlySalesDebitMemoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARSalesDebitMemoMonthly)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_ARMonthlySalesDebitMemoBindingSource
            // 
            this.sp_ARMonthlySalesDebitMemoBindingSource.DataMember = "sp_ARMonthlySalesDebitMemo";
            this.sp_ARMonthlySalesDebitMemoBindingSource.DataSource = this.ARSalesDebitMemoMonthly;
            // 
            // ARSalesDebitMemoMonthly
            // 
            this.ARSalesDebitMemoMonthly.DataSetName = "ARSalesDebitMemoMonthly";
            this.ARSalesDebitMemoMonthly.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ARSalesDebitMemoMonthly";
            reportDataSource1.Value = this.sp_ARMonthlySalesDebitMemoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.ARSalesDebitMemoMonthly.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1264, 841);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_ARMonthlySalesDebitMemoTableAdapter
            // 
            this.sp_ARMonthlySalesDebitMemoTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_ARSalesDebitMemoMonthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 841);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_ARSalesDebitMemoMonthly";
            this.Text = "Monthly AR Sales Debit Memo Summary Report";
            this.Load += new System.EventHandler(this.Rpt_ARSalesDebitMemoMonthly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_ARMonthlySalesDebitMemoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARSalesDebitMemoMonthly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_ARMonthlySalesDebitMemoBindingSource;
        private ARSalesDebitMemoMonthly ARSalesDebitMemoMonthly;
        private ARSalesDebitMemoMonthlyTableAdapters.sp_ARMonthlySalesDebitMemoTableAdapter sp_ARMonthlySalesDebitMemoTableAdapter;
    }
}