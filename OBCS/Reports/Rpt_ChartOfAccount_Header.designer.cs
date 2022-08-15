namespace OBCS.Reports
{
    partial class Rpt_ChartOfAccount_Header
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
            this.sp_GL_Transaction_Account_RecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChartOfAccount_Header = new OBCS.Reports.ChartOfAccount_Header();
            this.sp_GL_Transaction_Account_RecTableAdapter = new OBCS.Reports.ChartOfAccount_HeaderTableAdapters.sp_GL_Transaction_Account_RecTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GL_Transaction_Account_RecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfAccount_Header)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ChartOfAccount_Header";
            reportDataSource1.Value = this.sp_GL_Transaction_Account_RecBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.ChartOfAccount_Header.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1189, 718);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_GL_Transaction_Account_RecBindingSource
            // 
            this.sp_GL_Transaction_Account_RecBindingSource.DataMember = "sp_GL_Transaction_Account_Rec";
            this.sp_GL_Transaction_Account_RecBindingSource.DataSource = this.ChartOfAccount_Header;
            // 
            // ChartOfAccount_Header
            // 
            this.ChartOfAccount_Header.DataSetName = "ChartOfAccount_Header";
            this.ChartOfAccount_Header.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_GL_Transaction_Account_RecTableAdapter
            // 
            this.sp_GL_Transaction_Account_RecTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_ChartOfAccount_Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 718);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_ChartOfAccount_Header";
            this.Text = "Chart of account header";
            this.Load += new System.EventHandler(this.Rpt_ChartOfAccount_Header_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_GL_Transaction_Account_RecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfAccount_Header)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_GL_Transaction_Account_RecBindingSource;
        private ChartOfAccount_Header ChartOfAccount_Header;
        private ChartOfAccount_HeaderTableAdapters.sp_GL_Transaction_Account_RecTableAdapter sp_GL_Transaction_Account_RecTableAdapter;
    }
}