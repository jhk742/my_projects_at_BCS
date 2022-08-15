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
    public partial class Rpt_ARCOLLECTIOND : Form
    {
        public Rpt_ARCOLLECTIOND(String SaleRep, DateTime Dates, String Memo,String ARCNumber)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("SaleRep", SaleRep));
            reportParameters.Add(new ReportParameter("Dates", Dates.ToShortDateString()));
            reportParameters.Add(new ReportParameter("Memo", Memo));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_ARCOLLECTION_DETAILTableAdapter.Fill(this.ARCOLLECTIOND.sp_ARCOLLECTION_DETAIL,ARCNumber);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_ARCOLLECTIOND_Load(object sender, EventArgs e)
        {
            
        }
    }
}
