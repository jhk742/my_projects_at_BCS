
namespace OBCS.Reports
{
    partial class Rpt_PrintCheck
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
            this.sp_Rpt_PrintCheckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrintCheck = new OBCS.Reports.PrintCheck();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_Rpt_PrintCheckTableAdapter = new OBCS.Reports.PrintCheckTableAdapters.sp_Rpt_PrintCheckTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Rpt_PrintCheckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Rpt_PrintCheckBindingSource
            // 
            this.sp_Rpt_PrintCheckBindingSource.DataMember = "sp_Rpt_PrintCheck";
            this.sp_Rpt_PrintCheckBindingSource.DataSource = this.PrintCheck;
            // 
            // PrintCheck
            // 
            this.PrintCheck.DataSetName = "PrintCheck";
            this.PrintCheck.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.PrintCheck.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(994, 679);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_Rpt_PrintCheckTableAdapter
            // 
            this.sp_Rpt_PrintCheckTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_PrintCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 679);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_PrintCheck";
            this.Text = "Print Check";
            this.Load += new System.EventHandler(this.Rpt_PrintCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Rpt_PrintCheckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Rpt_PrintCheckBindingSource;
        private PrintCheck PrintCheck;
        private PrintCheckTableAdapters.sp_Rpt_PrintCheckTableAdapter sp_Rpt_PrintCheckTableAdapter;
    }
}