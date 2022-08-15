namespace OBCS.Reports
{
    partial class Rpt_PickingList
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
            this.Rpt_Fetch_PickingListBindingSource = new System.Windows.Forms.BindingSource();
            this.PickingList = new OBCS.Reports.PickingList();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Rpt_Fetch_PickingListTableAdapter = new OBCS.Reports.PickingListTableAdapters.Rpt_Fetch_PickingListTableAdapter();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Rpt_Fetch_PickingListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PickingList)).BeginInit();
            this.SuspendLayout();
            // 
            // Rpt_Fetch_PickingListBindingSource
            // 
            this.Rpt_Fetch_PickingListBindingSource.DataMember = "Rpt_Fetch_PickingList";
            this.Rpt_Fetch_PickingListBindingSource.DataSource = this.PickingList;
            // 
            // PickingList
            // 
            this.PickingList.DataSetName = "PickingList2";
            this.PickingList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.PickingList.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1203, 598);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Rpt_Fetch_PickingListTableAdapter
            // 
            this.Rpt_Fetch_PickingListTableAdapter.ClearBeforeFill = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Rpt_PickingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 598);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_PickingList";
            this.Text = "Picking List";
            this.Load += new System.EventHandler(this.Rpt_PickingList_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rpt_PickingList_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Rpt_Fetch_PickingListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PickingList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Rpt_Fetch_PickingListBindingSource;
        private PickingList PickingList;
        private PickingListTableAdapters.Rpt_Fetch_PickingListTableAdapter Rpt_Fetch_PickingListTableAdapter;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}