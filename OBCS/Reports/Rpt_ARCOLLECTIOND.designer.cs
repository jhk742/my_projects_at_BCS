namespace OBCS.Reports
{
    partial class Rpt_ARCOLLECTIOND
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
            this.sp_ARCOLLECTION_DETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ARCOLLECTIOND = new OBCS.Reports.ARCOLLECTIOND();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ARCOLLECTION_DETAILTableAdapter = new OBCS.Reports.ARCOLLECTIONDTableAdapters.sp_ARCOLLECTION_DETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ARCOLLECTION_DETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARCOLLECTIOND)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_ARCOLLECTION_DETAILBindingSource
            // 
            this.sp_ARCOLLECTION_DETAILBindingSource.DataMember = "sp_ARCOLLECTION_DETAIL";
            this.sp_ARCOLLECTION_DETAILBindingSource.DataSource = this.ARCOLLECTIOND;
            // 
            // ARCOLLECTIOND
            // 
            this.ARCOLLECTIOND.DataSetName = "ARCOLLECTIOND";
            this.ARCOLLECTIOND.EnforceConstraints = false;
            this.ARCOLLECTIOND.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ARCOLLECTIOND";
            reportDataSource1.Value = this.sp_ARCOLLECTION_DETAILBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.ARCOLLECTIOND.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(881, 881);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_ARCOLLECTION_DETAILTableAdapter
            // 
            this.sp_ARCOLLECTION_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_ARCOLLECTIOND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 881);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_ARCOLLECTIOND";
            this.Text = "Collection from Sales Report";
            this.Load += new System.EventHandler(this.Rpt_ARCOLLECTIOND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_ARCOLLECTION_DETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARCOLLECTIOND)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_ARCOLLECTION_DETAILBindingSource;
        private ARCOLLECTIOND ARCOLLECTIOND;
        private ARCOLLECTIONDTableAdapters.sp_ARCOLLECTION_DETAILTableAdapter sp_ARCOLLECTION_DETAILTableAdapter;
    }
}