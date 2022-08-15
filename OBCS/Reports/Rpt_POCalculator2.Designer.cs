
namespace OBCS.Reports
{
    partial class Rpt_POCalculator2
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
            this.POCalculator2 = new OBCS.Reports.POCalculator2();
            this.sp_GoodsReceiptValueCalculationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GoodsReceiptValueCalculationTableAdapter = new OBCS.Reports.POCalculator2TableAdapters.sp_GoodsReceiptValueCalculationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.POCalculator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GoodsReceiptValueCalculationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "POCalculator2";
            reportDataSource1.Value = this.sp_GoodsReceiptValueCalculationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.POCalculator2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1049, 604);
            this.reportViewer1.TabIndex = 0;
            // 
            // POCalculator2
            // 
            this.POCalculator2.DataSetName = "POCalculator2";
            this.POCalculator2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_GoodsReceiptValueCalculationBindingSource
            // 
            this.sp_GoodsReceiptValueCalculationBindingSource.DataMember = "sp_GoodsReceiptValueCalculation";
            this.sp_GoodsReceiptValueCalculationBindingSource.DataSource = this.POCalculator2;
            // 
            // sp_GoodsReceiptValueCalculationTableAdapter
            // 
            this.sp_GoodsReceiptValueCalculationTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_POCalculator2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 604);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_POCalculator2";
            this.Text = "Rpt_POCalculator2";
            this.Load += new System.EventHandler(this.Rpt_POCalculator2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.POCalculator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GoodsReceiptValueCalculationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_GoodsReceiptValueCalculationBindingSource;
        private POCalculator2 POCalculator2;
        private POCalculator2TableAdapters.sp_GoodsReceiptValueCalculationTableAdapter sp_GoodsReceiptValueCalculationTableAdapter;
    }
}