namespace OBCS.Reports
{
    partial class Rpt_POForWareHouse
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
            this.Rpt_POForWareHouseBindingSource = new System.Windows.Forms.BindingSource();
            this.POForWareHouse = new OBCS.Reports.POForWareHouse();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Rpt_POForWareHouseTableAdapter = new OBCS.Reports.POForWareHouseTableAdapters.Rpt_POForWareHouseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Rpt_POForWareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POForWareHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // Rpt_POForWareHouseBindingSource
            // 
            this.Rpt_POForWareHouseBindingSource.DataMember = "Rpt_POForWareHouse";
            this.Rpt_POForWareHouseBindingSource.DataSource = this.POForWareHouse;
            // 
            // POForWareHouse
            // 
            this.POForWareHouse.DataSetName = "POForWareHouse";
            this.POForWareHouse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "POForWareHouse";
            reportDataSource1.Value = this.Rpt_POForWareHouseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.POForWareHouse.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1225, 743);
            this.reportViewer1.TabIndex = 0;
            // 
            // Rpt_POForWareHouseTableAdapter
            // 
            this.Rpt_POForWareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_POForWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 767);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_POForWareHouse";
            this.Text = "PO For Warehouse";
            this.Load += new System.EventHandler(this.Rpt_POForWareHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rpt_POForWareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POForWareHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Rpt_POForWareHouseBindingSource;
        private POForWareHouse POForWareHouse;
        private POForWareHouseTableAdapters.Rpt_POForWareHouseTableAdapter Rpt_POForWareHouseTableAdapter;
    }
}