namespace OBCS.Reports
{
    partial class Rpt_AROPENCLOSED_ALL
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
            this.sp_AROPENCLOSE_ALLBindingSource = new System.Windows.Forms.BindingSource();
            this.AROPENCLOSED_ALL = new OBCS.Reports.AROPENCLOSED_ALL();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_AROPENCLOSE_ALLTableAdapter = new OBCS.Reports.AROPENCLOSED_ALLTableAdapters.sp_AROPENCLOSE_ALLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_AROPENCLOSE_ALLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AROPENCLOSED_ALL)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_AROPENCLOSE_ALLBindingSource
            // 
            this.sp_AROPENCLOSE_ALLBindingSource.DataMember = "sp_AROPENCLOSE_ALL";
            this.sp_AROPENCLOSE_ALLBindingSource.DataSource = this.AROPENCLOSED_ALL;
            // 
            // AROPENCLOSED_ALL
            // 
            this.AROPENCLOSED_ALL.DataSetName = "AROPENCLOSED_ALL";
            this.AROPENCLOSED_ALL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AROPENCLOSED_ALL";
            reportDataSource1.Value = this.sp_AROPENCLOSE_ALLBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.AROPENCLOSED_ALL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1455, 876);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_AROPENCLOSE_ALLTableAdapter
            // 
            this.sp_AROPENCLOSE_ALLTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_AROPENCLOSED_ALL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 876);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_AROPENCLOSED_ALL";
            this.Text = "Rpt_AROPENCLOSED_ALL";
            this.Load += new System.EventHandler(this.Rpt_AROPENCLOSED_ALL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_AROPENCLOSE_ALLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AROPENCLOSED_ALL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_AROPENCLOSE_ALLBindingSource;
        private AROPENCLOSED_ALL AROPENCLOSED_ALL;
        private AROPENCLOSED_ALLTableAdapters.sp_AROPENCLOSE_ALLTableAdapter sp_AROPENCLOSE_ALLTableAdapter;
    }
}