using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace OBCS.Reports
{
    public partial class Rpt_TransactionReport : Form
    {
        public Rpt_TransactionReport(DateTime FromDate, DateTime ToDate, String CustomerID, String CustomerName, String InvoiceNo)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", FromDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", ToDate.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_TRANSACTION_REPORT_DETAILTableAdapter.Fill(this.TransactionReport.sp_TRANSACTION_REPORT_DETAIL, FromDate, ToDate, CustomerID, CustomerName, InvoiceNo);

            this.reportViewer1.RefreshReport();


            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_TransactionReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TransactionReport.sp_TRANSACTION_REPORT_DETAIL' table. You can move, or remove it, as needed.
            //this.sp_TRANSACTION_REPORT_DETAILTableAdapter.Fill(this.TransactionReport.sp_TRANSACTION_REPORT_DETAIL);

            //this.reportViewer1.RefreshReport();
        }
    }
}
