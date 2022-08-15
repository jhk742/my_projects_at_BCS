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
    public partial class Rpt_SalesARbyRepReport : Form
    {
        public Rpt_SalesARbyRepReport(String REP)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("REP", REP.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_SalesARbyRepReportTableAdapter.Fill(this.SalesARbyRepReport.sp_SalesARbyRepReport,REP);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_SalesARbyRepReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalesARbyRepReport.sp_SalesARbyRepReport' table. You can move, or remove it, as needed.

        }
    }
}
