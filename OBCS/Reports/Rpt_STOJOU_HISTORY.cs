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
    public partial class Rpt_STOJOU_HISTORY : Form
    {
        public Rpt_STOJOU_HISTORY(DateTime Fromdate, DateTime ToDate, string ProductID, string Site, string Status)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("TODATE", ToDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("FROMDATE", Fromdate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("SITE", Site.Trim()));
            reportParameters.Add(new ReportParameter("STATUS", Status.Trim()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_STOJOU_HistoryTableAdapter.Fill(this.STOJOU_HISTORY.sp_STOJOU_History,Fromdate,ToDate,ProductID, Site, Status);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_STOJOU_HISTORY_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'STOJOU_HISTORY.sp_STOJOU_History' table. You can move, or remove it, as needed.
            
        }
    }
}
