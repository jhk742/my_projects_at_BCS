using Microsoft.Reporting.WinForms;
using OBCS.Entities;
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
    public partial class Rpt_DriverCollection : Form
    {
        public Rpt_DriverCollection(int RouteNumber)
        {
            InitializeComponent();

            DeliveryManifest deliveryManifest = new DeliveryManifest();
            deliveryManifest = connSalesOrder.sp_GET_DeliveryManifest(RouteNumber.ToString());
            
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Bill100", deliveryManifest.Bill100.ToString()));
            reportParameters.Add(new ReportParameter("Bill50", deliveryManifest.Bill50.ToString()));
            reportParameters.Add(new ReportParameter("Bill20", deliveryManifest.Bill20.ToString()));
            reportParameters.Add(new ReportParameter("Bill10", deliveryManifest.Bill10.ToString()));
            reportParameters.Add(new ReportParameter("Bill5", deliveryManifest.Bill5.ToString()));
            reportParameters.Add(new ReportParameter("Bill2", deliveryManifest.Bill2.ToString()));
            reportParameters.Add(new ReportParameter("Bill1", deliveryManifest.Bill1.ToString()));
            reportParameters.Add(new ReportParameter("Coins", deliveryManifest.Coins.ToString()));
            reportParameters.Add(new ReportParameter("Parking", deliveryManifest.Park.ToString()));
            reportParameters.Add(new ReportParameter("Gas", deliveryManifest.Gas.ToString()));
            reportParameters.Add(new ReportParameter("Toll", deliveryManifest.Toll.ToString()));
            reportParameters.Add(new ReportParameter("Misc", deliveryManifest.Misc.ToString()));
            reportParameters.Add(new ReportParameter("RouteNumber", RouteNumber.ToString()));

            String Driver = connSalesOrder.getDriverFromRouteNumber(RouteNumber.ToString());
            String PlateNo = connSalesOrder.getPlateNoFromRouteNumber(RouteNumber.ToString());
            reportParameters.Add(new ReportParameter("Driver", Driver));
            reportParameters.Add(new ReportParameter("PlateNo", PlateNo));

            Decimal CashDecimal = connSalesOrder.sp_GET_CashTotal(RouteNumber.ToString());
            Decimal Checkecimal = connSalesOrder.sp_GET_CheckTotal(RouteNumber.ToString());
            reportParameters.Add(new ReportParameter("Cash", CashDecimal.ToString("C2")));
            reportParameters.Add(new ReportParameter("Check", Checkecimal.ToString("C2")));
            reportParameters.Add(new ReportParameter("Total", (CashDecimal + Checkecimal).ToString("C2")));
            
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.Rpt_DriverCollection2TableAdapter.Fill(this.DriverCollection.Rpt_DriverCollection2, RouteNumber);

            //this.reportViewer1.RefreshReport();
            var rds = new ReportDataSource("DriverCollection", this.DriverCollection.Rpt_DriverCollection2 as DataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

        }

        private void Rpt_DriverCollection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DriverCollection.Rpt_DriverCollection2' table. You can move, or remove it, as needed.

        }
    }
}
