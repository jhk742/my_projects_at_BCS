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
    public partial class Rpt_AGING_AP_SUMMARY : Form
    {
        public Rpt_AGING_AP_SUMMARY(DateTime ToDate , string SupplierID)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("TODATE", ToDate.ToShortDateString()));

            this.sp_AGING_AP_SUMMARYTableAdapter.Fill(this.AGING_AP_SUMMARY.sp_AGING_AP_SUMMARY, ToDate, SupplierID);
            
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.reportViewer1.RefreshReport();


            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_AGING_AP_SUMMARY_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AGING_AP_SUMMARY.sp_AGING_AP_SUMMARY' table. You can move, or remove it, as needed.
            //this.sp_AGING_AP_SUMMARYTableAdapter.Fill(this.AGING_AP_SUMMARY.sp_AGING_AP_SUMMARY);

            //this.reportViewer1.RefreshReport();
        }
    }
}
