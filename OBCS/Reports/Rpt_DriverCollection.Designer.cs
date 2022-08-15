namespace OBCS.Reports
{
    partial class Rpt_DriverCollection
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
            this.Rpt_DriverCollection2BindingSource = new System.Windows.Forms.BindingSource();
            this.DriverCollection = new OBCS.Reports.DriverCollection();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Rpt_DriverCollection2TableAdapter = new OBCS.Reports.DriverCollectionTableAdapters.Rpt_DriverCollection2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Rpt_DriverCollection2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // Rpt_DriverCollection2BindingSource
            // 
            this.Rpt_DriverCollection2BindingSource.DataSource = this.DriverCollection;
            this.Rpt_DriverCollection2BindingSource.Position = 0;
            // 
            // DriverCollection
            // 
            this.DriverCollection.DataSetName = "DriverCollection";
            this.DriverCollection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DriverCollection";
            reportDataSource1.Value = this.Rpt_DriverCollection2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.DriverCollection.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1022, 590);
            this.reportViewer1.TabIndex = 1;
            // 
            // Rpt_DriverCollection2TableAdapter
            // 
            this.Rpt_DriverCollection2TableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_DriverCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 590);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_DriverCollection";
            this.Text = "Driver Collection";
            this.Load += new System.EventHandler(this.Rpt_DriverCollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rpt_DriverCollection2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Rpt_DriverCollection2BindingSource;
        private DriverCollection DriverCollection;
        private DriverCollectionTableAdapters.Rpt_DriverCollection2TableAdapter Rpt_DriverCollection2TableAdapter;
    }
}