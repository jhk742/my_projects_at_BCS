namespace OBCS.Reports
{
    partial class Rpt_InventoryFlowByLastRecDateByBrand
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
            this.Rpt_InventoryFlowListByLastRecDateBindingSource = new System.Windows.Forms.BindingSource();
            this.InventoryFlowByLastRecDateByBrand = new OBCS.Reports.InventoryFlowByLastRecDateByBrand();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Rpt_InventoryFlowListByLastRecDateTableAdapter = new OBCS.Reports.InventoryFlowByLastRecDateByBrandTableAdapters.Rpt_InventoryFlowListByLastRecDateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Rpt_InventoryFlowListByLastRecDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryFlowByLastRecDateByBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // Rpt_InventoryFlowListByLastRecDateBindingSource
            // 
            this.Rpt_InventoryFlowListByLastRecDateBindingSource.DataMember = "Rpt_InventoryFlowListByLastRecDate";
            this.Rpt_InventoryFlowListByLastRecDateBindingSource.DataSource = this.InventoryFlowByLastRecDateByBrand;
            // 
            // InventoryFlowByLastRecDateByBrand
            // 
            this.InventoryFlowByLastRecDateByBrand.DataSetName = "InventoryFlowByLastRecDateByBrand";
            this.InventoryFlowByLastRecDateByBrand.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "InventoryFlowByLastRecDateByBrand";
            reportDataSource1.Value = this.Rpt_InventoryFlowListByLastRecDateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.InventoryFlowByLastRecDateByBrand.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1225, 743);
            this.reportViewer1.TabIndex = 0;
            // 
            // Rpt_InventoryFlowListByLastRecDateTableAdapter
            // 
            this.Rpt_InventoryFlowListByLastRecDateTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_InventoryFlowByLastRecDateByBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 767);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_InventoryFlowByLastRecDateByBrand";
            this.Text = "Form_InventoryFlowByLastRecDateByBrand";
            this.Load += new System.EventHandler(this.Form_InventoryFlowByLastRecDateByBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rpt_InventoryFlowListByLastRecDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryFlowByLastRecDateByBrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Rpt_InventoryFlowListByLastRecDateBindingSource;
        private InventoryFlowByLastRecDateByBrand InventoryFlowByLastRecDateByBrand;
        private InventoryFlowByLastRecDateByBrandTableAdapters.Rpt_InventoryFlowListByLastRecDateTableAdapter Rpt_InventoryFlowListByLastRecDateTableAdapter;
    }
}