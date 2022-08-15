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
    public partial class Rpt_Top_Product_Report_Summary : Form
    {
        public Rpt_Top_Product_Report_Summary(String ProductID, String Salerep, DateTime FROMDATE, DateTime TODATE, int Type)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", FROMDATE.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", TODATE.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_Top_Product_Report_SummaryTableAdapter.Fill(this.Top_Product_Report_Summary.sp_Top_Product_Report_Summary,ProductID,Salerep,FROMDATE,TODATE,Type);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_Top_Product_Report_Summary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Top_Product_Report_Summary.sp_Top_Product_Report_Summary' table. You can move, or remove it, as needed.
            
        }
    }
}
