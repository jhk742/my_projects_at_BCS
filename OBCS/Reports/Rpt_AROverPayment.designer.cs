namespace OBCS.Reports
{
    partial class Rpt_AROverPayment
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
            this.AROverPayment = new OBCS.Reports.AROverPayment();
            this.sp_OverPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_OverPaymentTableAdapter = new OBCS.Reports.AROverPaymentTableAdapters.sp_OverPaymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AROverPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_OverPaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AROverPayment";
            reportDataSource1.Value = this.sp_OverPaymentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.AROverPayment.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(956, 819);
            this.reportViewer1.TabIndex = 0;
            // 
            // AROverPayment
            // 
            this.AROverPayment.DataSetName = "AROverPayment";
            this.AROverPayment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_OverPaymentBindingSource
            // 
            this.sp_OverPaymentBindingSource.DataMember = "sp_OverPayment";
            this.sp_OverPaymentBindingSource.DataSource = this.AROverPayment;
            // 
            // sp_OverPaymentTableAdapter
            // 
            this.sp_OverPaymentTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_AROverPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 819);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_AROverPayment";
            this.Text = "Rpt_AROverPayment";
            this.Load += new System.EventHandler(this.Rpt_AROverPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AROverPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_OverPaymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_OverPaymentBindingSource;
        private AROverPayment AROverPayment;
        private AROverPaymentTableAdapters.sp_OverPaymentTableAdapter sp_OverPaymentTableAdapter;
    }
}