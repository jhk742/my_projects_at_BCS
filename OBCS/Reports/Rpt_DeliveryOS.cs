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
    public partial class Rpt_DeliveryOS : Form
    {
        public Rpt_DeliveryOS(DateTime FromDate, DateTime ToDate, String DeliveryNubmer, String SalesRep, String CustomerID)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", FromDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", ToDate.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_DeliveryOS_ReportTableAdapter.Fill(this.DeliveryOS.sp_DeliveryOS_Report, FromDate, ToDate, DeliveryNubmer, SalesRep, CustomerID);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_DeliveryOS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DeliveryOS.sp_DeliveryOS_Report' table. You can move, or remove it, as needed.
            //this.sp_DeliveryOS_ReportTableAdapter.Fill(this.DeliveryOS.sp_DeliveryOS_Report);

            //this.reportViewer1.RefreshReport();
        }
    }
}
