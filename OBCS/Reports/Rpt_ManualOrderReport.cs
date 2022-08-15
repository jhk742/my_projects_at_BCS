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
    public partial class Rpt_ManualOrderReport : Form
    {
        public Rpt_ManualOrderReport(String OrderID, String Branch, String CustomerID, String CustomerName, String CustomerAddress)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("OrderID", OrderID));
            reportParameters.Add(new ReportParameter("Branch", Branch));
            reportParameters.Add(new ReportParameter("CustomerID", CustomerID));
            reportParameters.Add(new ReportParameter("CustomerName", CustomerName));
            reportParameters.Add(new ReportParameter("CustomerAddress", CustomerAddress));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_ManualOrder_EXPORTTableAdapter.Fill(this.ManualOrderReport.sp_ManualOrder_EXPORT, OrderID);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_ManualOrderReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ManualOrderReport.sp_ManualOrder_EXPORT' table. You can move, or remove it, as needed.
            //this.sp_ManualOrder_EXPORTTableAdapter.Fill(this.ManualOrderReport.sp_ManualOrder_EXPORT);

            //this.reportViewer1.RefreshReport();
        }
    }
}
