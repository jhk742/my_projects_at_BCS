namespace OBCS.Reports
{
    partial class Rpt_CourseList
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
            this.sp_Rpt_DriverCourseListBindingSource = new System.Windows.Forms.BindingSource();
            this.CourseList = new OBCS.Reports.CourseList();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_Rpt_DriverCourseListTableAdapter = new OBCS.Reports.CourseListTableAdapters.sp_Rpt_DriverCourseListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Rpt_DriverCourseListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseList)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Rpt_DriverCourseListBindingSource
            // 
            this.sp_Rpt_DriverCourseListBindingSource.DataMember = "sp_Rpt_DriverCourseList";
            this.sp_Rpt_DriverCourseListBindingSource.DataSource = this.CourseList;
            // 
            // CourseList
            // 
            this.CourseList.DataSetName = "CourseList";
            this.CourseList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CourseList";
            reportDataSource1.Value = this.sp_Rpt_DriverCourseListBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.CourseList.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1153, 626);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_Rpt_DriverCourseListTableAdapter
            // 
            this.sp_Rpt_DriverCourseListTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_CourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 626);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_CourseList";
            this.Text = "Course List";
            this.Load += new System.EventHandler(this.Rpt_CourseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Rpt_DriverCourseListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Rpt_DriverCourseListBindingSource;
        private CourseList CourseList;
        private CourseListTableAdapters.sp_Rpt_DriverCourseListTableAdapter sp_Rpt_DriverCourseListTableAdapter;
    }
}