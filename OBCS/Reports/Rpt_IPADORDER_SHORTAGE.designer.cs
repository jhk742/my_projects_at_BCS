namespace OBCS.Reports
{
    partial class Rpt_IPADORDER_SHORTAGE
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
            this.sp_IPAD_ORDER_DIFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IPADORDER_SHORTAGE = new OBCS.Reports.IPADORDER_SHORTAGE();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_IPAD_ORDER_DIFFTableAdapter = new OBCS.Reports.IPADORDER_SHORTAGETableAdapters.sp_IPAD_ORDER_DIFFTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_IPAD_ORDER_DIFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPADORDER_SHORTAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_IPAD_ORDER_DIFFBindingSource
            // 
            this.sp_IPAD_ORDER_DIFFBindingSource.DataMember = "sp_IPAD_ORDER_DIFF";
            this.sp_IPAD_ORDER_DIFFBindingSource.DataSource = this.IPADORDER_SHORTAGE;
            // 
            // IPADORDER_SHORTAGE
            // 
            this.IPADORDER_SHORTAGE.DataSetName = "IPADORDER_SHORTAGE";
            this.IPADORDER_SHORTAGE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "IPADORDER_SHORTAGE";
            reportDataSource1.Value = this.sp_IPAD_ORDER_DIFFBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.IPADORDER_SHORTAGE.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1035, 797);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_IPAD_ORDER_DIFFTableAdapter
            // 
            this.sp_IPAD_ORDER_DIFFTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_IPADORDER_SHORTAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 797);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_IPADORDER_SHORTAGE";
            this.Text = "iPad Order Shortage Report";
            this.Load += new System.EventHandler(this.Rpt_IPADORDER_SHORTAGE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_IPAD_ORDER_DIFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPADORDER_SHORTAGE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_IPAD_ORDER_DIFFBindingSource;
        private IPADORDER_SHORTAGE IPADORDER_SHORTAGE;
        private IPADORDER_SHORTAGETableAdapters.sp_IPAD_ORDER_DIFFTableAdapter sp_IPAD_ORDER_DIFFTableAdapter;
    }
}