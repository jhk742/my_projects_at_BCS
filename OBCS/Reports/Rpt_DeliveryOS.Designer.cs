namespace OBCS.Reports
{
    partial class Rpt_DeliveryOS
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
            this.sp_DeliveryOS_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeliveryOS = new OBCS.Reports.DeliveryOS();
            this.sp_DeliveryOS_ReportTableAdapter = new OBCS.Reports.DeliveryOSTableAdapters.sp_DeliveryOS_ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DeliveryOS_ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryOS)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DeliveryOS";
            reportDataSource1.Value = this.sp_DeliveryOS_ReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.DeliveryOS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1155, 649);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_DeliveryOS_ReportBindingSource
            // 
            this.sp_DeliveryOS_ReportBindingSource.DataMember = "sp_DeliveryOS_Report";
            this.sp_DeliveryOS_ReportBindingSource.DataSource = this.DeliveryOS;
            // 
            // DeliveryOS
            // 
            this.DeliveryOS.DataSetName = "DeliveryOS";
            this.DeliveryOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_DeliveryOS_ReportTableAdapter
            // 
            this.sp_DeliveryOS_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_DeliveryOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 649);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_DeliveryOS";
            this.Text = "Detailed Shortage (O/S)";
            this.Load += new System.EventHandler(this.Rpt_DeliveryOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_DeliveryOS_ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_DeliveryOS_ReportBindingSource;
        private DeliveryOS DeliveryOS;
        private DeliveryOSTableAdapters.sp_DeliveryOS_ReportTableAdapter sp_DeliveryOS_ReportTableAdapter;
    }
}