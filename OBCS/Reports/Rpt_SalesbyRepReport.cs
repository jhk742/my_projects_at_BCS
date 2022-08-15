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
    public partial class Rpt_SalesbyRepReport : Form
    {
        public Rpt_SalesbyRepReport(DateTime FROMDATE, DateTime TODATE)
        {
            InitializeComponent();

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", FROMDATE.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", TODATE.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_SalesbyRepReportTableAdapter.Fill(this.SalesbyRepReport.sp_SalesbyRepReport, FROMDATE, TODATE);

            this.reportViewer1.RefreshReport();


            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

        }

        private void Rpt_SalesbyRepReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalesbyRepReport.sp_SalesbyRepReport' table. You can move, or remove it, as needed.
            //this.sp_SalesbyRepReportTableAdapter.Fill(this.SalesbyRepReport.sp_SalesbyRepReport);

            //this.reportViewer1.RefreshReport();
        }
    }
}
