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
    public partial class Rpt_AGING_AR_SUMMARY : Form
    {
        public Rpt_AGING_AR_SUMMARY(DateTime ToDate, String CustomerID, String Site)
        {
            InitializeComponent();

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("TODATE", ToDate.ToShortDateString()));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_AGING_AR_SUMMARYTableAdapter.Fill(this.AGING_AR_SUMMARY.sp_AGING_AR_SUMMARY, ToDate, CustomerID, Site);

            this.reportViewer1.RefreshReport();


            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_AGING_AR_SUMMARY_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AGING_AR_SUMMARY.sp_AGING_AR_SUMMARY' table. You can move, or remove it, as needed.
            
        }
    }
}
