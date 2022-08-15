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
    public partial class Rpt_SalesbyCustomerReport : Form
    {
        public Rpt_SalesbyCustomerReport(String CustomerID, String CustomerName, DateTime FROMDATE, DateTime TODATE, String StateString, String CityString)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("CustomerID", CustomerID.ToString()));
            reportParameters.Add(new ReportParameter("FROMDATE", FROMDATE.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", TODATE.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            
            this.sp_SalesbyCustomerReportTableAdapter.Fill(this.SalesbyCustomerReport.sp_SalesbyCustomerReport, CustomerID, CustomerName, FROMDATE, TODATE, StateString, CityString);
            

            this.reportViewer1.RefreshReport();


            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_SalesbyCustomerReport_Load(object sender, EventArgs e)
        {
        }
    }
}
