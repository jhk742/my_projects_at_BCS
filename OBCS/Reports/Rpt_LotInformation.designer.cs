namespace OBCS.Reports
{
    partial class Rpt_LotInformation
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
            this.sp_LotInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LotInformation = new OBCS.Reports.LotInformation();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_LotInformationTableAdapter = new OBCS.Reports.LotInformationTableAdapters.sp_LotInformationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LotInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_LotInformationBindingSource
            // 
            this.sp_LotInformationBindingSource.DataMember = "sp_LotInformation";
            this.sp_LotInformationBindingSource.DataSource = this.LotInformation;
            // 
            // LotInformation
            // 
            this.LotInformation.DataSetName = "LotInformation";
            this.LotInformation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "LotInformation";
            reportDataSource1.Value = this.sp_LotInformationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.LotInformation.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1312, 843);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_LotInformationTableAdapter
            // 
            this.sp_LotInformationTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_LotInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 843);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_LotInformation";
            this.Text = "Lot Information Report";
            this.Load += new System.EventHandler(this.Rpt_LotInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_LotInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_LotInformationBindingSource;
        private LotInformation LotInformation;
        private LotInformationTableAdapters.sp_LotInformationTableAdapter sp_LotInformationTableAdapter;
    }
}