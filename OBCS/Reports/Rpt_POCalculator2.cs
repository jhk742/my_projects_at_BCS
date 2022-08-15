using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace OBCS.Reports
{
    public partial class Rpt_POCalculator2 : Form
    {
        public Rpt_POCalculator2(String PONumber, String RECNumber)
        {
            InitializeComponent();
            //ReportParameterCollection reportParameters = new ReportParameterCollection();
            //reportParameters.Add(new ReportParameter("SupplierID", SupplierID.ToString()));
            //reportParameters.Add(new ReportParameter("SUpplierName", SUpplierName.ToString()));
            //reportParameters.Add(new ReportParameter("PODate", PODate.ToShortDateString()));
            //reportParameters.Add(new ReportParameter("PONumber", PONumber.ToString()));
            //reportParameters.Add(new ReportParameter("RECDate", RECDate.ToShortDateString()));
            //reportParameters.Add(new ReportParameter("RECNumber", RECNumber.ToString()));
            //reportParameters.Add(new ReportParameter("APPostingDate", APPostingDate.ToShortDateString()));
            //reportParameters.Add(new ReportParameter("APNumber", APNumber.ToString()));
            //reportParameters.Add(new ReportParameter("SupplierInvoiceDate", SupplierInvoiceDate.ToShortDateString()));
            //reportParameters.Add(new ReportParameter("SupplierInvoiceNumber", SupplierInvoiceNumber.ToString()));
            //this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_GoodsReceiptValueCalculationTableAdapter.Fill(this.POCalculator2.sp_GoodsReceiptValueCalculation, PONumber, RECNumber);

            this.reportViewer1.RefreshReport();


            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_POCalculator2_Load(Object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'POCalculator2.sp_GoodsReceiptValueCalculation' table. You can move, or remove it, as needed.
            //this.sp_GoodsReceiptValueCalculationTableAdapter.Fill(this.POCalculator2.sp_GoodsReceiptValueCalculation,);

            //this.reportViewer1.RefreshReport();
        }
    }
}
