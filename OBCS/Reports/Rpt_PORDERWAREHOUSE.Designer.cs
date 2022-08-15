namespace OBCS.Reports
{
    partial class Rpt_PORDERWAREHOUSE
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
            this.sp_Rpt_PORDERDETAIL_WAREHOUSEBindingSource = new System.Windows.Forms.BindingSource();
            this.PORDERWAREHOUSE = new OBCS.Reports.PORDERWAREHOUSE();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_Rpt_PORDERDETAIL_WAREHOUSETableAdapter = new OBCS.Reports.PORDERWAREHOUSETableAdapters.sp_Rpt_PORDERDETAIL_WAREHOUSETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Rpt_PORDERDETAIL_WAREHOUSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PORDERWAREHOUSE)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Rpt_PORDERDETAIL_WAREHOUSEBindingSource
            // 
            this.sp_Rpt_PORDERDETAIL_WAREHOUSEBindingSource.DataMember = "sp_Rpt_PORDERDETAIL_WAREHOUSE";
            this.sp_Rpt_PORDERDETAIL_WAREHOUSEBindingSource.DataSource = this.PORDERWAREHOUSE;
            // 
            // PORDERWAREHOUSE
            // 
            this.PORDERWAREHOUSE.DataSetName = "PORDERWAREHOUSE";
            this.PORDERWAREHOUSE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PORDERWAREHOUSE";
            reportDataSource1.Value = this.sp_Rpt_PORDERDETAIL_WAREHOUSEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.PORDERWAREHOUSE.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1181, 691);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_Rpt_PORDERDETAIL_WAREHOUSETableAdapter
            // 
            this.sp_Rpt_PORDERDETAIL_WAREHOUSETableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_PORDERWAREHOUSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 691);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_PORDERWAREHOUSE";
            this.Text = "PO WAREHOUSE";
            this.Load += new System.EventHandler(this.Rpt_PORDERWAREHOUSE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Rpt_PORDERDETAIL_WAREHOUSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PORDERWAREHOUSE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Rpt_PORDERDETAIL_WAREHOUSEBindingSource;
        private PORDERWAREHOUSE PORDERWAREHOUSE;
        private PORDERWAREHOUSETableAdapters.sp_Rpt_PORDERDETAIL_WAREHOUSETableAdapter sp_Rpt_PORDERDETAIL_WAREHOUSETableAdapter;
    }
}