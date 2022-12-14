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
    public partial class Rpt_ARBalanceAccountReport : Form
    {
        public Rpt_ARBalanceAccountReport(DateTime FromDate, DateTime ToDate)
        {
            InitializeComponent();

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FromDate", FromDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("ToDate", ToDate.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_ARBalanceAccountReportTableAdapter.Fill(this.ARBalanceAccountReport.sp_ARBalanceAccountReport, FromDate, ToDate);
            
            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_ARBalanceAccountReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ARBalanceAccountReport.sp_ARBalanceAccountReport' table. You can move, or remove it, as needed.
            //this.sp_ARBalanceAccountReportTableAdapter.Fill(this.ARBalanceAccountReport.sp_ARBalanceAccountReport,);

            //this.reportViewer1.RefreshReport();
        }
    }
}
