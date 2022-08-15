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
    public partial class Rpt_NSFReport : Form
    {
        public Rpt_NSFReport(String CompanyName, DateTime FromDate, DateTime ToDate)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("CompanyName", CompanyName));
            reportParameters.Add(new ReportParameter("FROMDATE", FromDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", ToDate.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_NSFReportTableAdapter.Fill(this.NSFReport.sp_NSFReport, CompanyName, FromDate, ToDate);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_NSFReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NSFReport.sp_NSFReport' table. You can move, or remove it, as needed.
            
        }
    }
}
