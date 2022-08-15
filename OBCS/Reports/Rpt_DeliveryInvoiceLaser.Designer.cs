
namespace OBCS.Reports
{
    partial class Rpt_DeliveryInvoiceLaser
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Rpt_Fetch_DeliveryInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeliveryInvoiceLaser = new OBCS.Reports.DeliveryInvoiceLaser();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Rpt_Fetch_DeliveryInvoiceTableAdapter = new OBCS.Reports.DeliveryInvoiceLaserTableAdapters.Rpt_Fetch_DeliveryInvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Rpt_Fetch_DeliveryInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryInvoiceLaser)).BeginInit();
            this.SuspendLayout();
            // 
            // Rpt_Fetch_DeliveryInvoiceBindingSource
            // 
            this.Rpt_Fetch_DeliveryInvoiceBindingSource.DataMember = "Rpt_Fetch_DeliveryInvoice";
            this.Rpt_Fetch_DeliveryInvoiceBindingSource.DataSource = this.DeliveryInvoiceLaser;
            // 
            // DeliveryInvoiceLaser
            // 
            this.DeliveryInvoiceLaser.DataSetName = "DeliveryInvoiceLaser";
            this.DeliveryInvoiceLaser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DeliveryInvoiceLaser";
            reportDataSource2.Value = this.Rpt_Fetch_DeliveryInvoiceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.DeliveryInvoiceLaser.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1330, 766);
            this.reportViewer1.TabIndex = 0;
            // 
            // Rpt_Fetch_DeliveryInvoiceTableAdapter
            // 
            this.Rpt_Fetch_DeliveryInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_DeliveryInvoiceLaser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 766);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_DeliveryInvoiceLaser";
            this.Text = "Delivery Note (Laser)";
            this.Load += new System.EventHandler(this.Rpt_DeliveryInvoiceLaser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rpt_Fetch_DeliveryInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryInvoiceLaser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Rpt_Fetch_DeliveryInvoiceBindingSource;
        private DeliveryInvoiceLaser DeliveryInvoiceLaser;
        private DeliveryInvoiceLaserTableAdapters.Rpt_Fetch_DeliveryInvoiceTableAdapter Rpt_Fetch_DeliveryInvoiceTableAdapter;
    }
}