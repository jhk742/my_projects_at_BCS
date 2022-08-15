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
    public partial class Rpt_SubcontractExceptionReport : Form
    {
        public Rpt_SubcontractExceptionReport(DateTime FromDate, DateTime ToDate, String Supplier, String POStatus, String APStatus)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FromDate", FromDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("ToDate", ToDate.ToShortDateString()));


            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_SubcontractExceptionReportTableAdapter.Fill(this.SubContractExceptionReport.sp_SubcontractExceptionReport, FromDate, ToDate, Supplier, POStatus, APStatus);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_SubcontractExceptionReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SubContractExceptionReport.sp_SubcontractExceptionReport' table. You can move, or remove it, as needed.
            //this.sp_SubcontractExceptionReportTableAdapter.Fill(this.SubContractExceptionReport.sp_SubcontractExceptionReport);

            //this.reportViewer1.RefreshReport();
        }
    }
}
