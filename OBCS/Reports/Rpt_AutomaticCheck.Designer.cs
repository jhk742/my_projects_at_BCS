namespace OBCS.Reports
{
    partial class Rpt_AutomaticCheck
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
            this.sp_Rpt_AutomaticCheckBindingSource = new System.Windows.Forms.BindingSource();
            this.AutomaticCheck = new OBCS.Reports.AutomaticCheck();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_Rpt_AutomaticCheckTableAdapter = new OBCS.Reports.AutomaticCheckTableAdapters.sp_Rpt_AutomaticCheckTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Rpt_AutomaticCheckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutomaticCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Rpt_AutomaticCheckBindingSource
            // 
            this.sp_Rpt_AutomaticCheckBindingSource.DataMember = "sp_Rpt_AutomaticCheck";
            this.sp_Rpt_AutomaticCheckBindingSource.DataSource = this.AutomaticCheck;
            // 
            // AutomaticCheck
            // 
            this.AutomaticCheck.DataSetName = "AutomaticCheck";
            this.AutomaticCheck.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AutomaticCheck";
            reportDataSource1.Value = this.sp_Rpt_AutomaticCheckBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.AutomaticCheck.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1085, 656);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_Rpt_AutomaticCheckTableAdapter
            // 
            this.sp_Rpt_AutomaticCheckTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_AutomaticCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 656);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_AutomaticCheck";
            this.Text = "Rpt_AutomaticCheck";
            this.Load += new System.EventHandler(this.Rpt_AutomaticCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Rpt_AutomaticCheckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutomaticCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Rpt_AutomaticCheckBindingSource;
        private AutomaticCheck AutomaticCheck;
        private AutomaticCheckTableAdapters.sp_Rpt_AutomaticCheckTableAdapter sp_Rpt_AutomaticCheckTableAdapter;
    }
}