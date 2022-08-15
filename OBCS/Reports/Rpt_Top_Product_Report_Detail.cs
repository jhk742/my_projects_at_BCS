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
    public partial class Rpt_Top_Product_Report_Detail : Form
    {
        public Rpt_Top_Product_Report_Detail(String ProductID, String SaleRep, DateTime FROMDATE, DateTime TODATE)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", FROMDATE.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", TODATE.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_Top_Product_Report_DetailTableAdapter.Fill(this.Top_Product_Report_Detail.sp_Top_Product_Report_Detail,ProductID,SaleRep,FROMDATE,TODATE);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_Top_Product_Report_Detail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Top_Product_Report_Detail.sp_Top_Product_Report_Detail' table. You can move, or remove it, as needed.
            //this.sp_Top_Product_Report_DetailTableAdapter.Fill(this.Top_Product_Report_Detail.sp_Top_Product_Report_Detail);

            //this.reportViewer1.RefreshReport();
        }
    }
}
