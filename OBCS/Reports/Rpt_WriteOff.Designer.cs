
namespace OBCS.Reports
{
    partial class Rpt_WriteOff
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
            this.WriteOff = new OBCS.Reports.WriteOff();
            this.sp_WRITEOFF_EXPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_WRITEOFF_EXPORTTableAdapter = new OBCS.Reports.WriteOffTableAdapters.sp_WRITEOFF_EXPORTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.WriteOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_WRITEOFF_EXPORTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "WriteOff";
            reportDataSource1.Value = this.sp_WRITEOFF_EXPORTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.WriteOff.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // WriteOff
            // 
            this.WriteOff.DataSetName = "WriteOff";
            this.WriteOff.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_WRITEOFF_EXPORTBindingSource
            // 
            this.sp_WRITEOFF_EXPORTBindingSource.DataMember = "sp_WRITEOFF_EXPORT";
            this.sp_WRITEOFF_EXPORTBindingSource.DataSource = this.WriteOff;
            // 
            // sp_WRITEOFF_EXPORTTableAdapter
            // 
            this.sp_WRITEOFF_EXPORTTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_WriteOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_WriteOff";
            this.Text = "Rpt_WriteOff";
            this.Load += new System.EventHandler(this.Rpt_WriteOff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WriteOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_WRITEOFF_EXPORTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_WRITEOFF_EXPORTBindingSource;
        private WriteOff WriteOff;
        private WriteOffTableAdapters.sp_WRITEOFF_EXPORTTableAdapter sp_WRITEOFF_EXPORTTableAdapter;
    }
}