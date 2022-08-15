namespace OBCS.Reports
{
    partial class Rpt_STOJOU_HISTORY
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_STOJOU_HistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.STOJOU_HISTORY = new OBCS.Reports.STOJOU_HISTORY();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_STOJOU_HistoryTableAdapter = new OBCS.Reports.STOJOU_HISTORYTableAdapters.sp_STOJOU_HistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_STOJOU_HistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STOJOU_HISTORY)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_STOJOU_HistoryBindingSource
            // 
            this.sp_STOJOU_HistoryBindingSource.DataMember = "sp_STOJOU_History";
            this.sp_STOJOU_HistoryBindingSource.DataSource = this.STOJOU_HISTORY;
            // 
            // STOJOU_HISTORY
            // 
            this.STOJOU_HISTORY.DataSetName = "STOJOU_HISTORY";
            this.STOJOU_HISTORY.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "STOJOU_HISTORY";
            reportDataSource3.Value = this.sp_STOJOU_HistoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.STOJOU_HISTORY.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1352, 942);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_STOJOU_HistoryTableAdapter
            // 
            this.sp_STOJOU_HistoryTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_STOJOU_HISTORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 942);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_STOJOU_HISTORY";
            this.Text = "Stock Transaction";
            this.Load += new System.EventHandler(this.Rpt_STOJOU_HISTORY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_STOJOU_HistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STOJOU_HISTORY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_STOJOU_HistoryBindingSource;
        private STOJOU_HISTORY STOJOU_HISTORY;
        private STOJOU_HISTORYTableAdapters.sp_STOJOU_HistoryTableAdapter sp_STOJOU_HistoryTableAdapter;
    }
}