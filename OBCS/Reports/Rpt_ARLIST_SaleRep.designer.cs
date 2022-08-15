namespace OBCS.Reports
{
    partial class Rpt_ARLIST_SaleRep
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
            this.sp_AR_LIST_SaleRepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ARLIST_SaleRep = new OBCS.Reports.ARLIST_SaleRep();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_AR_LIST_SaleRepTableAdapter = new OBCS.Reports.ARLIST_SaleRepTableAdapters.sp_AR_LIST_SaleRepTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_AR_LIST_SaleRepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARLIST_SaleRep)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_AR_LIST_SaleRepBindingSource
            // 
            this.sp_AR_LIST_SaleRepBindingSource.DataMember = "sp_AR_LIST_SaleRep";
            this.sp_AR_LIST_SaleRepBindingSource.DataSource = this.ARLIST_SaleRep;
            // 
            // ARLIST_SaleRep
            // 
            this.ARLIST_SaleRep.DataSetName = "ARLIST_SaleRep";
            this.ARLIST_SaleRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ARLIST_SaleRep";
            reportDataSource1.Value = this.sp_AR_LIST_SaleRepBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.ARLIST_SaleRep.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1342, 1034);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_AR_LIST_SaleRepTableAdapter
            // 
            this.sp_AR_LIST_SaleRepTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_ARLIST_SaleRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 1034);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_ARLIST_SaleRep";
            this.Text = "AR by Salesperson Report (Rpt_ARLIST_SaleRep)";
            this.Load += new System.EventHandler(this.Rpt_ARLIST_SaleRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_AR_LIST_SaleRepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARLIST_SaleRep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_AR_LIST_SaleRepBindingSource;
        private ARLIST_SaleRep ARLIST_SaleRep;
        private ARLIST_SaleRepTableAdapters.sp_AR_LIST_SaleRepTableAdapter sp_AR_LIST_SaleRepTableAdapter;
    }
}