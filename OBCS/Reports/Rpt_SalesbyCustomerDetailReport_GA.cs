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
    public partial class Rpt_SalesbyCustomerDetailReport_GA : Form
    {
        public Rpt_SalesbyCustomerDetailReport_GA(DateTime FROMDATE, DateTime TODATE, String CustomerID, String CustomerName, String REP, String City, String State, String InvoiceNumber, bool CityAll, bool StateAll)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("CustomerID", CustomerID.ToString()));
            reportParameters.Add(new ReportParameter("FROMDATE", FROMDATE.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", TODATE.ToShortDateString()));
            reportParameters.Add(new ReportParameter("REP", REP.ToString()));
            reportParameters.Add(new ReportParameter("City", CityAll == true ? "ALL" : ""));
            reportParameters.Add(new ReportParameter("State", StateAll == true ? "ALL" : ""));
            reportParameters.Add(new ReportParameter("InvoiceNumber", InvoiceNumber.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_SalesbyCustomerDetailReportTableAdapter.Fill(this.SalesbyCustomerDetailReport.sp_SalesbyCustomerDetailReport, CustomerID, CustomerName, FROMDATE, TODATE, REP, InvoiceNumber, State, City);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_SalesbyCustomerDetailReport_GA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalesbyCustomerDetailReport.sp_SalesbyCustomerDetailReport' table. You can move, or remove it, as needed.
        }
    }
}
