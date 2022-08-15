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
    public partial class Rpt_ARCollectionDaily : Form
    {
        public Rpt_ARCollectionDaily(DateTime Fromdate, DateTime Todate)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", Fromdate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", Todate.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);


            this.sp_ARCollectionDailyReportTableAdapter.Fill(this.ARCollectionDaily.sp_ARCollectionDailyReport,Fromdate,Todate);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_ARCollectionDaily_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ARCollectionDaily.sp_ARCollectionDailyReport' table. You can move, or remove it, as needed.
            
        }
    }
}
