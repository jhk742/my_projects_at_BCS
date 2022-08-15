namespace OBCS.Reports
{
    partial class Rpt_POManagement_Detail
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
            this.PO_Management_Detail = new OBCS.Reports.PO_Management_Detail();
            this.sp_PO_MANAGEMENT_DETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_PO_MANAGEMENT_DETAILTableAdapter = new OBCS.Reports.PO_Management_DetailTableAdapters.sp_PO_MANAGEMENT_DETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PO_Management_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PO_MANAGEMENT_DETAILBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PO_Management_Detail";
            reportDataSource1.Value = this.sp_PO_MANAGEMENT_DETAILBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.PO_Management_Detail.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1533, 789);
            this.reportViewer1.TabIndex = 0;
            // 
            // PO_Management_Detail
            // 
            this.PO_Management_Detail.DataSetName = "PO_Management_Detail";
            this.PO_Management_Detail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_PO_MANAGEMENT_DETAILBindingSource
            // 
            this.sp_PO_MANAGEMENT_DETAILBindingSource.DataMember = "sp_PO_MANAGEMENT_DETAIL";
            this.sp_PO_MANAGEMENT_DETAILBindingSource.DataSource = this.PO_Management_Detail;
            // 
            // sp_PO_MANAGEMENT_DETAILTableAdapter
            // 
            this.sp_PO_MANAGEMENT_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_POManagement_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 789);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_POManagement_Detail";
            this.Text = "Rpt_POManagement_Detail";
            this.Load += new System.EventHandler(this.Rpt_POManagement_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PO_Management_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PO_MANAGEMENT_DETAILBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_PO_MANAGEMENT_DETAILBindingSource;
        private PO_Management_Detail PO_Management_Detail;
        private PO_Management_DetailTableAdapters.sp_PO_MANAGEMENT_DETAILTableAdapter sp_PO_MANAGEMENT_DETAILTableAdapter;
    }
}