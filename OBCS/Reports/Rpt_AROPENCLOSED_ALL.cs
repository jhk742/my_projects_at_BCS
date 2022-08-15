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
    public partial class Rpt_AROPENCLOSED_ALL : Form
    {
        public Rpt_AROPENCLOSED_ALL(DateTime fromdate, DateTime todate, string CustomerID)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", fromdate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", todate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("CUSTOMERID", CustomerID));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_AROPENCLOSE_ALLTableAdapter.Fill(this.AROPENCLOSED_ALL.sp_AROPENCLOSE_ALL,fromdate,todate,CustomerID);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_AROPENCLOSED_ALL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AROPENCLOSED_ALL.sp_AROPENCLOSE_ALL' table. You can move, or remove it, as needed.
            //this.sp_AROPENCLOSE_ALLTableAdapter.Fill(this.AROPENCLOSED_ALL.sp_AROPENCLOSE_ALL);

            //this.reportViewer1.RefreshReport();
        }
    }
}
