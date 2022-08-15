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
    public partial class Rpt_StockValuationReport : Form
    {
        public Rpt_StockValuationReport(DateTime AsOfDate, String Site, String Status)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("AsOfDate", AsOfDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("Site", Site.ToString()));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_StockValuationReportTableAdapter.Fill(this.StockValuationReport.sp_StockValuationReport, AsOfDate, Site, Status);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_StockValuationReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StockValuationReport.sp_StockValuationReport' table. You can move, or remove it, as needed.
            //this.sp_StockValuationReportTableAdapter.Fill(this.StockValuationReport.sp_StockValuationReport, AsOfDate, Site);

            //this.reportViewer1.RefreshReport();
        }
    }
}
