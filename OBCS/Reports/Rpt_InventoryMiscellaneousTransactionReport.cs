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
    public partial class Rpt_InventoryMiscellaneousTransactionReport : Form
    {
        public Rpt_InventoryMiscellaneousTransactionReport(DateTime FromDate, DateTime ToDate, String Type)
        {
            InitializeComponent();

            String vFromDate = FromDate.ToString("MMMM yyyy");
            String vToDate = ToDate.ToString("MMMM yyyy");

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FromDate", vFromDate));
            reportParameters.Add(new ReportParameter("ToDate", vToDate));
            reportParameters.Add(new ReportParameter("Type", Type));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_InventoryMiscellaneousTransactionReportTableAdapter.Fill(this.InventoryMiscellaneousTransactionReport.sp_InventoryMiscellaneousTransactionReport, FromDate, ToDate, Type);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_InventoryMiscellaneousTransactionReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'InventoryMiscellaneousTransactionReport.sp_InventoryMiscellaneousTransactionReport' table. You can move, or remove it, as needed.
            //this.sp_InventoryMiscellaneousTransactionReportTableAdapter.Fill(this.InventoryMiscellaneousTransactionReport.sp_InventoryMiscellaneousTransactionReport);

            //this.reportViewer1.RefreshReport();
        }
    }
}
