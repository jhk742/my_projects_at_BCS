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
    public partial class Rpt_OSREPORT : Form
    {
        public Rpt_OSREPORT(DateTime fromdate, DateTime todate)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", fromdate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", todate.AddDays(-1).ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_OSReportTableAdapter.Fill(this.OSREPORT.sp_OSReport,fromdate,todate);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_OSREPORT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OSREPORT.sp_OSReport' table. You can move, or remove it, as needed.
            
        }
    }
}
