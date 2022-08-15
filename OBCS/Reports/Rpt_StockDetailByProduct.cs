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
    public partial class Rpt_StockDetailByProduct : Form
    {
        public Rpt_StockDetailByProduct(DateTime FromDate, DateTime ToDate, String Site, String Status, String Category, String ProductID, String Brand)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", FromDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", ToDate.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_StockDetailByProductIDTableAdapter.Fill(this.StockDetailByProduct.sp_StockDetailByProductID, FromDate, ToDate, Site, Status, Category, ProductID, Brand);
            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_StockDetailByProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StockDetailByProduct.sp_StockDetailByProductID' table. You can move, or remove it, as needed.
            
        }
    }
}
