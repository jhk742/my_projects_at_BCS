namespace OBCS.Reports
{
    partial class Rpt_PAYMENTT_GetPayments
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
            this.PAYMENTT_GetPayments = new OBCS.Reports.PAYMENTT_GetPayments();
            this.sp_PAYMENTT_GetPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_PAYMENTT_GetPaymentsTableAdapter = new OBCS.Reports.PAYMENTT_GetPaymentsTableAdapters.sp_PAYMENTT_GetPaymentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PAYMENTT_GetPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PAYMENTT_GetPaymentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PAYMENTT_GetPayments";
            reportDataSource1.Value = this.sp_PAYMENTT_GetPaymentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.PAYMENTT_GetPayments.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1228, 990);
            this.reportViewer1.TabIndex = 0;
            // 
            // PAYMENTT_GetPayments
            // 
            this.PAYMENTT_GetPayments.DataSetName = "PAYMENTT_GetPayments";
            this.PAYMENTT_GetPayments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_PAYMENTT_GetPaymentsBindingSource
            // 
            this.sp_PAYMENTT_GetPaymentsBindingSource.DataMember = "sp_PAYMENTT_GetPayments";
            this.sp_PAYMENTT_GetPaymentsBindingSource.DataSource = this.PAYMENTT_GetPayments;
            // 
            // sp_PAYMENTT_GetPaymentsTableAdapter
            // 
            this.sp_PAYMENTT_GetPaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_PAYMENTT_GetPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 990);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_PAYMENTT_GetPayments";
            this.Text = "Rpt_PAYMENTT_GetPayments";
            this.Load += new System.EventHandler(this.Rpt_PAYMENTT_GetPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PAYMENTT_GetPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PAYMENTT_GetPaymentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_PAYMENTT_GetPaymentsBindingSource;
        private PAYMENTT_GetPayments PAYMENTT_GetPayments;
        private PAYMENTT_GetPaymentsTableAdapters.sp_PAYMENTT_GetPaymentsTableAdapter sp_PAYMENTT_GetPaymentsTableAdapter;
    }
}