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
    public partial class Rpt_ARSalesDebitMemoDaily : Form
    {
        public Rpt_ARSalesDebitMemoDaily(DateTime Fromdate, DateTime Todate)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", Fromdate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", Todate.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);


            this.sp_ARDailySalesDebitMemoTableAdapter.Fill(this.ARSalesDebitMemoDaily.sp_ARDailySalesDebitMemo,Fromdate,Todate);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_ARSalesDebitMemoDaily_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ARSalesDebitMemoDaily.sp_ARDailySalesDebitMemo' table. You can move, or remove it, as needed.
            
        }
    }
}
