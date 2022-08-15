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
    public partial class Rpt_ARCollectionMonthly : Form
    {
        public Rpt_ARCollectionMonthly(DateTime Fromdate, DateTime Todate)
        {
            InitializeComponent();

            String vFromDate = Fromdate.ToString("MMMM yyyy");
            String vToDate = Todate.ToString("MMMM yyyy");

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", vFromDate));
            reportParameters.Add(new ReportParameter("TODATE", vToDate));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_ARCollectionMonthlyReportTableAdapter.Fill(this.ARCollectionMonthly.sp_ARCollectionMonthlyReport,Fromdate,Todate);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_ARCollectionMonthly_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ARCollectionMonthly.sp_ARCollectionMonthlyReport' table. You can move, or remove it, as needed.
            
        }
    }
}
