namespace OBCS.Reports
{
    partial class Rpt_POManagement
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_PO_MANAGEMENTBindingSource = new System.Windows.Forms.BindingSource();
            this.PO_Management = new OBCS.Reports.PO_Management();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_PO_MANAGEMENTTableAdapter = new OBCS.Reports.PO_ManagementTableAdapters.sp_PO_MANAGEMENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PO_MANAGEMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PO_Management)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_PO_MANAGEMENTBindingSource
            // 
            this.sp_PO_MANAGEMENTBindingSource.DataMember = "sp_PO_MANAGEMENT";
            this.sp_PO_MANAGEMENTBindingSource.DataSource = this.PO_Management;
            // 
            // PO_Management
            // 
            this.PO_Management.DataSetName = "PO_Management";
            this.PO_Management.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PO_Management";
            reportDataSource1.Value = this.sp_PO_MANAGEMENTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.PO_Management.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1549, 823);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_PO_MANAGEMENTTableAdapter
            // 
            this.sp_PO_MANAGEMENTTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_POManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 823);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_POManagement";
            this.Text = "Rpt_POManagement";
            this.Load += new System.EventHandler(this.Rpt_POManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_PO_MANAGEMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PO_Management)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_PO_MANAGEMENTBindingSource;
        private PO_Management PO_Management;
        private PO_ManagementTableAdapters.sp_PO_MANAGEMENTTableAdapter sp_PO_MANAGEMENTTableAdapter;
    }
}