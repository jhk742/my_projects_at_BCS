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
    public partial class Rpt_POManagement_Detail : Form
    {
        public Rpt_POManagement_Detail(DateTime fromdate, DateTime todate, string Supplier, string Brand, string Product, string Received, string Confirmed, string Type)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", fromdate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", todate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("Supplier", Supplier));
            reportParameters.Add(new ReportParameter("Brand", Brand));
            reportParameters.Add(new ReportParameter("Product", Product));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_PO_MANAGEMENT_DETAILTableAdapter.Fill(this.PO_Management_Detail.sp_PO_MANAGEMENT_DETAIL,fromdate,todate,Supplier,Brand,Product,Received,Confirmed, Type);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_POManagement_Detail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PO_Management_Detail.sp_PO_MANAGEMENT_DETAIL' table. You can move, or remove it, as needed.
            //this.sp_PO_MANAGEMENT_DETAILTableAdapter.Fill(this.PO_Management_Detail.sp_PO_MANAGEMENT_DETAIL);

            //this.reportViewer1.RefreshReport();
        }
    }
}
