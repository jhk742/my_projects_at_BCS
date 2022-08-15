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
    public partial class Rpt_POForWareHouse : Form
    {
        public Rpt_POForWareHouse(int POKey, String PONO, String OrderDate, String RequireDate, String Term, String Via, String Contact,
             String VendorName, String VendorAddress1, String VendorAddress2,
             String VendorTel, String VendorFax,
             String VendorCityStateZip,
             String ShipName, String ShipAddress1, String ShipAddress2,
             String ShipTel, String ShipFax,
             String ShipCityStateZip)
        {
            InitializeComponent();

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("POKey", POKey.ToString()));
            reportParameters.Add(new ReportParameter("PONO", PONO));
            reportParameters.Add(new ReportParameter("OrderDate", OrderDate));
            reportParameters.Add(new ReportParameter("RequireDate", RequireDate));
            reportParameters.Add(new ReportParameter("Term", Term));
            reportParameters.Add(new ReportParameter("Via", Via));
            reportParameters.Add(new ReportParameter("Contact", Contact));
            reportParameters.Add(new ReportParameter("VendorName", VendorName));
            reportParameters.Add(new ReportParameter("ShipName", ShipName));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.Rpt_POForWareHouseTableAdapter.Fill(this.POForWareHouse.Rpt_POForWareHouse, POKey);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

        }

        private void Rpt_POForWareHouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'POForWareHouse.Rpt_POForWareHouse' table. You can move, or remove it, as needed.

        }
    }
}
