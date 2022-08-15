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
    public partial class Rpt_SalesOrderExceptionReport : Form
    {
        public Rpt_SalesOrderExceptionReport(DateTime FromDate, DateTime AsOfDate, String CheckNumber, String CustomerID, String SOOpenStatus, String SOFromX3)
        {
            InitializeComponent();

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FromDate", FromDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("AsOfDate", AsOfDate.ToShortDateString()));


            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_SalesOrderExceptionReportTableAdapter.Fill(this.SalesOrderExceptionReport.sp_SalesOrderExceptionReport, FromDate, AsOfDate, CheckNumber, CustomerID, SOOpenStatus, SOFromX3);


            this.reportViewer1.RefreshReport();


            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

        }

        private void Rpt_SalesOrderExceptionReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalesOrderExceptionReport.sp_SalesOrderExceptionReport' table. You can move, or remove it, as needed.
            //this.sp_SalesOrderExceptionReportTableAdapter.Fill(this.SalesOrderExceptionReport.sp_SalesOrderExceptionReport);

            //this.reportViewer1.RefreshReport();
        }
    }
}
