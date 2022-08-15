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
    public partial class Rpt_IPADORDER_SHORTAGE : Form
    {
        public Rpt_IPADORDER_SHORTAGE(DateTime FROMDATE, DateTime TODATE)
        {
            InitializeComponent();

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", FROMDATE.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", TODATE.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_IPAD_ORDER_DIFFTableAdapter.Fill(this.IPADORDER_SHORTAGE.sp_IPAD_ORDER_DIFF, FROMDATE, TODATE);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_IPADORDER_SHORTAGE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'IPADORDER_SHORTAGE.sp_IPAD_ORDER_DIFF' table. You can move, or remove it, as needed.
            
        }
    }
}
