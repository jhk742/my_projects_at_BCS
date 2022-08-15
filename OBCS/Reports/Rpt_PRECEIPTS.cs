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
    public partial class Rpt_PRECEIPTS : Form
    {
        public Rpt_PRECEIPTS(
            String PoNumber, String RecNumber, String OrderDate, String ReceivingDate, String Term, String Via, String Contact, String SupplierID, String SupplierName,
            String SupplierAddress1, String SupplierAddress2, String SupplierTel, String SupplierFax, String SupplierCityStateZip, String ShipName, String ShipAddress1,
            String ShipAddress2, String ShipTel, String ShipFax, String ShipCityStateZip, String RequireDate, String TotalPOCase, String TotalPOAmount, String TotalGRCase,
            String TotalGRAmount, String Memo)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("PoNumber", PoNumber));
            reportParameters.Add(new ReportParameter("RecNumber", RecNumber));
            reportParameters.Add(new ReportParameter("OrderDate", OrderDate));
            reportParameters.Add(new ReportParameter("ReceivingDate", ReceivingDate));
            reportParameters.Add(new ReportParameter("Term", Term));
            reportParameters.Add(new ReportParameter("ShipVia", Via));
            reportParameters.Add(new ReportParameter("Contact", Contact));
            reportParameters.Add(new ReportParameter("SupplierID", SupplierID));
            reportParameters.Add(new ReportParameter("SupplierName", SupplierName));
            reportParameters.Add(new ReportParameter("SupplierAddress1", SupplierAddress1));
            reportParameters.Add(new ReportParameter("SupplierAddress2", SupplierAddress2));
            reportParameters.Add(new ReportParameter("SupplierTel", SupplierTel));
            reportParameters.Add(new ReportParameter("SupplierFax", SupplierFax));
            reportParameters.Add(new ReportParameter("SupplierCityStateZip", SupplierCityStateZip));
            reportParameters.Add(new ReportParameter("ShipName", ShipName));
            reportParameters.Add(new ReportParameter("ShipAddress1", ShipAddress1));
            reportParameters.Add(new ReportParameter("ShipAddress2", ShipAddress2));
            reportParameters.Add(new ReportParameter("ShipTel", ShipTel));
            reportParameters.Add(new ReportParameter("ShipFax", ShipFax));
            reportParameters.Add(new ReportParameter("ShipCityStateZip", ShipCityStateZip));
            reportParameters.Add(new ReportParameter("RequireDate", RequireDate));
            reportParameters.Add(new ReportParameter("TotalPOCase", TotalPOCase));
            reportParameters.Add(new ReportParameter("TotalPOAmount", TotalPOAmount));
            reportParameters.Add(new ReportParameter("TotalGRCase", TotalGRCase));
            reportParameters.Add(new ReportParameter("TotalGRAmount", TotalGRAmount));
            reportParameters.Add(new ReportParameter("Memo", Memo));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_PRECEIPT_DETAILTableAdapter.Fill(this.PRECEIPTS.sp_PRECEIPT_DETAIL, RecNumber);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

        }

        private void Rpt_PRECEIPTS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PRECEIPTS.sp_PRECEIPT_DETAIL' table. You can move, or remove it, as needed.
            //this.sp_PRECEIPT_DETAILTableAdapter.Fill(this.PRECEIPTS.sp_PRECEIPT_DETAIL);

            //this.reportViewer1.RefreshReport();
        }
    }
}
