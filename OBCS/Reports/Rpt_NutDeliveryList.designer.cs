namespace OBCS.Reports
{
    partial class Rpt_NutDeliveryList
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
            this.sp_delivery_NutBindingSource = new System.Windows.Forms.BindingSource();
            this.NutDeliveryList = new OBCS.Reports.NutDeliveryList();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_delivery_NutTableAdapter = new OBCS.Reports.NutDeliveryListTableAdapters.sp_delivery_NutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_delivery_NutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NutDeliveryList)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_delivery_NutBindingSource
            // 
            this.sp_delivery_NutBindingSource.DataMember = "sp_delivery_Nut";
            this.sp_delivery_NutBindingSource.DataSource = this.NutDeliveryList;
            // 
            // NutDeliveryList
            // 
            this.NutDeliveryList.DataSetName = "NutDeliveryList";
            this.NutDeliveryList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "NutDeliveryList";
            reportDataSource1.Value = this.sp_delivery_NutBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.NutDeliveryLIst.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(873, 965);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_delivery_NutTableAdapter
            // 
            this.sp_delivery_NutTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_NutDeliveryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 965);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_NutDeliveryList";
            this.Text = "Nut Delivery List";
            this.Load += new System.EventHandler(this.Rpt_NutDeliveryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_delivery_NutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NutDeliveryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_delivery_NutBindingSource;
        private NutDeliveryList NutDeliveryList;
        private NutDeliveryListTableAdapters.sp_delivery_NutTableAdapter sp_delivery_NutTableAdapter;
    }
}