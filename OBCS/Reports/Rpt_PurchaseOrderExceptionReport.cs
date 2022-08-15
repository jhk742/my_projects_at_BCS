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
    public partial class Rpt_PurchaseOrderExceptionReport : Form
    {
        public Rpt_PurchaseOrderExceptionReport(DateTime FromDate, DateTime AsOfDate, String CheckNumber, String SupplierID, String POOpenStatus, String POFromX3)
        {
            InitializeComponent();

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FromDate", FromDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("AsOfDate", AsOfDate.ToShortDateString()));


            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_PurchaseOrderExceptionReportTableAdapter.Fill(this.PurchaseOrderExceptionReport.sp_PurchaseOrderExceptionReport, FromDate, AsOfDate, CheckNumber, SupplierID, POOpenStatus, POFromX3);

            this.reportViewer1.RefreshReport();
            
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_PurchaseOrderExceptionReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PurchaseOrderExceptionReport.sp_PurchaseOrderExceptionReport' table. You can move, or remove it, as needed.
            //this.sp_PurchaseOrderExceptionReportTableAdapter.Fill(this.PurchaseOrderExceptionReport.sp_PurchaseOrderExceptionReport);

            //this.reportViewer1.RefreshReport();
        }
    }
}
