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
    public partial class Rpt_PO_SalesReport : Form
    {
        public Rpt_PO_SalesReport(String Brand, DateTime FromDate, DateTime ToDate, String Text)
        {
            try
            {
                InitializeComponent();
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("FROMDATE", FromDate.ToShortDateString()));
                reportParameters.Add(new ReportParameter("TODATE", ToDate.ToShortDateString()));
                reportParameters.Add(new ReportParameter("BRAND", Brand));
                reportParameters.Add(new ReportParameter("ITEM", Text));
                this.reportViewer1.LocalReport.SetParameters(reportParameters);
                PO_SalesReport.EnforceConstraints = false;
                this.sp_PO_SalesReportTableAdapter.Fill(this.PO_SalesReport.sp_PO_SalesReport, Brand, FromDate, ToDate, Text);

                this.reportViewer1.RefreshReport();
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }catch(Exception ex)
            {
                MessageBox.Show("\nContact IT Team.\n\n"+ex.ToString());
            }


        }

        private void Rpt_PO_SalesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PO_SalesReport.sp_PO_SalesReport' table. You can move, or remove it, as needed.
            //this.sp_PO_SalesReportTableAdapter.Fill(this.PO_SalesReport.sp_PO_SalesReport);

            //this.reportViewer1.RefreshReport();
        }
    }
}
