using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Reports
{
    public partial class Rpt_CourseList : Form
    {
        public Rpt_CourseList(int RouteNumber, String Driver, String Truck, String InvoiceAmount)
        {
            InitializeComponent();

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("RouteNumber", RouteNumber.ToString()));
            reportParameters.Add(new ReportParameter("Driver", Driver));
            reportParameters.Add(new ReportParameter("Truck", Truck));
            reportParameters.Add(new ReportParameter("InvoiceAmount", InvoiceAmount));
            
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_Rpt_DriverCourseListTableAdapter.Fill(this.CourseList.sp_Rpt_DriverCourseList, RouteNumber);

            //this.reportViewer1.RefreshReport();
            var rds = new ReportDataSource("CourseList", this.CourseList.sp_Rpt_DriverCourseList as DataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_CourseList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CourseList.sp_Rpt_DriverCourseList' table. You can move, or remove it, as needed.
            //this.sp_Rpt_DriverCourseListTableAdapter.Fill(this.CourseList.sp_Rpt_DriverCourseList);

            this.reportViewer1.RefreshReport();
        }
    }
}
