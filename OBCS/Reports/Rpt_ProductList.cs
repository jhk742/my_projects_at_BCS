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
    public partial class Rpt_ProductList : Form
    {
        public Rpt_ProductList(String SearchProductID, String SearchProductDesc, String SearchBrand, String SearchInactive, String SearchPause, String Onhand, String Warehouse)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("onhand", Onhand.ToString()));
            reportParameters.Add(new ReportParameter("warehouse", Warehouse.ToString()));
            //reportParameters.Add(new ReportParameter("TODATE", todate.ToShortDateString()));
            //reportParameters.Add(new ReportParameter("CUSTOMERID", CustomerID));
            //MessageBox.Show("SearchInactive : " + SearchInactive + " \nSEarchPause : " + SearchPause);
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_LIST_PRODUCTTableAdapter.Fill(this.ProductList.sp_LIST_PRODUCT, SearchProductID, SearchProductDesc, SearchBrand,"", SearchInactive, SearchPause);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_ProductList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ProductList.sp_LIST_PRODUCT' table. You can move, or remove it, as needed.
            
        }
    }
}
