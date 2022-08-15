using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using OBCS.Entities;

namespace OBCS.Reports
{
    public partial class Rpt_DeliveryInvoiceLaser : Form
    {
        public Rpt_DeliveryInvoiceLaser(String OrderID)
        {
            InitializeComponent();

            DeliveryNoteObject deliveryNoteObject = new DeliveryNoteObject();
            deliveryNoteObject = connSalesOrder.sp_GET_DeliveryNote(OrderID);

            DateTime OrderDate = deliveryNoteObject.OrderDate;
            DateTime DeliveryDate = deliveryNoteObject.DeliveryDate;
            String CustomerID = deliveryNoteObject.CustomerID;
            String ShipTo = deliveryNoteObject.ShipTo;
            String BillTo = deliveryNoteObject.BillTo;
            String RouteNumber = deliveryNoteObject.RouteNumber;
            String RouteStop = deliveryNoteObject.RouteStop;
            String Term = deliveryNoteObject.Term;
            String SalesPerson = deliveryNoteObject.SalesPerson;
            String SalesPersonMobile = deliveryNoteObject.SalesPersonMobile;
            Decimal CreditAmount = deliveryNoteObject.CreditAmount;
            Decimal TotalBox = deliveryNoteObject.TotalBox;
            Decimal ABox = deliveryNoteObject.ABox;
            Decimal BBox = deliveryNoteObject.BBox;
            Decimal CBox = deliveryNoteObject.CBox;
            Decimal DBox = deliveryNoteObject.DBox;
            Decimal EBox = deliveryNoteObject.EBox;
            Decimal FBox = deliveryNoteObject.FBox;
            Decimal ReturnAmount = deliveryNoteObject.ReturnAmount;
            String DeliveryNumber = deliveryNoteObject.DeliveryNumber;
            Decimal AR = deliveryNoteObject.AR;
            Decimal TotalAmount = deliveryNoteObject.TotalAmount;

            //DateTime OrderDate = connSalesOrder.getOrderDateFromOrderID(OrderID);
            //DateTime DeliveryDate = connSalesOrder.getDeliveryDateFromOrderID(OrderID);
            //String CustomerID = connSalesOrder.getCustomerIDFromOrderID(OrderID);
            //String ShipTo = connSalesOrder.getShipToFromOrderID(OrderID);
            //String BillTo = connSalesOrder.getBillToFromOrderID(OrderID);
            //String RouteNumber = connSalesOrder.getRouteNumberFromOrderID(OrderID);
            //String RouteStop = connSalesOrder.getRouteStopFromOrderID(OrderID);
            //String Term = connSalesOrder.getTermFromOrderID2(OrderID);
            //String SalesPerson = connSalesOrder.getSalesPersonFromOrderID(OrderID);
            //String SalesPersonMobile = connSalesOrder.getSalesPersonMobileFromOrderID(OrderID);
            //String CreditAmount = connSalesOrder.getCreditAmountFromOrderID(OrderID);
            //String TotalBox = connSalesOrder.getTotalBoxFromOrderID(OrderID);
            //String ABox = connSalesOrder.getABoxFromOrderID(OrderID);
            //String BBox = connSalesOrder.getBBoxFromOrderID(OrderID);
            //String CBox = connSalesOrder.getCBoxFromOrderID(OrderID);
            //String DBox = connSalesOrder.getDBoxFromOrderID(OrderID);
            //String EBox = connSalesOrder.getEBoxFromOrderID(OrderID);
            //String FBox = connSalesOrder.getFBoxFromOrderID(OrderID);
            //String ReturnAmount = connSalesOrder.getReturnAmountFromOrderID(OrderID);
            //if (ReturnAmount == "")
            //{
            //    ReturnAmount = "0";
            //}
            //String DeliveryNumber = connSalesOrder.getDeliveryNumberFromOrderID(OrderID);
            //String AR = connSalesOrder.sp_GET_PreviousBalance(CustomerID);

            ////MessageBox.Show(AR);
            //if (AR == null || AR == "")
            //{
            //    AR = "0";
            //}
            //Decimal TotalAmount = Convert.ToDecimal(connSalesOrder.sp_GET_TotalAmount(OrderID));


            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("OrderID", OrderID));
            reportParameters.Add(new ReportParameter("OrderDate", OrderDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("DeliveryDate", DeliveryDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("CustomerID", CustomerID));
            reportParameters.Add(new ReportParameter("ShipTo", ShipTo));
            reportParameters.Add(new ReportParameter("BillTo", BillTo));
            reportParameters.Add(new ReportParameter("RouteNumber", RouteNumber));
            reportParameters.Add(new ReportParameter("RouteStop", RouteStop));
            reportParameters.Add(new ReportParameter("Term", Term));
            reportParameters.Add(new ReportParameter("SalesPerson", SalesPerson));
            reportParameters.Add(new ReportParameter("SalesPersonMobile", SalesPersonMobile));
            reportParameters.Add(new ReportParameter("CreditAmount", CreditAmount.ToString("N2")));
            reportParameters.Add(new ReportParameter("TotalBox", TotalBox.ToString("N0")));
            reportParameters.Add(new ReportParameter("ABox", ABox.ToString("N0")));
            reportParameters.Add(new ReportParameter("BBox", BBox.ToString("N0")));
            reportParameters.Add(new ReportParameter("CBox", CBox.ToString("N0")));
            reportParameters.Add(new ReportParameter("DBox", DBox.ToString("N0")));
            reportParameters.Add(new ReportParameter("EBox", EBox.ToString("N0")));
            reportParameters.Add(new ReportParameter("FBox", FBox.ToString("N0")));
            reportParameters.Add(new ReportParameter("ReturnAmount", ReturnAmount.ToString("N2")));
            reportParameters.Add(new ReportParameter("DeliveryNumber", DeliveryNumber));
            reportParameters.Add(new ReportParameter("AR", AR.ToString("N2")));
            reportParameters.Add(new ReportParameter("TotalAmount", TotalAmount.ToString("N2")));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.Rpt_Fetch_DeliveryInvoiceTableAdapter.Fill(this.DeliveryInvoiceLaser.Rpt_Fetch_DeliveryInvoice, OrderID);

            PageSettings ps = new PageSettings(); //Declare a new PageSettings for printing
            //ps.Landscape = false; //Set True for landscape, False for Portrait
            ps.Landscape = true;
            ps.Margins = new Margins(0, 0, 15, 25); //Set margins
                                                    //Choose paper size from the paper sizes defined in ur printer.
                                                    //Here we use Linq to quickly choose by name
            ps.PaperSize =
                (from PaperSize p
                in ps.PrinterSettings.PaperSizes
                 where p.PaperName == "Letter"
                 select p).First();
            //Alternatively you can set the paper size as custom
            //ps.PaperSize = new PaperSize("MyPaperSize", 1200, 850);

            reportViewer1.SetPageSettings(ps);


            this.reportViewer1.RefreshReport();

            this.reportViewer1.PrinterSettings.Copies = (short)2;
            this.reportViewer1.PrinterSettings.Collate = false;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_DeliveryInvoiceLaser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DeliveryInvoiceLaser.Rpt_Fetch_DeliveryInvoice' table. You can move, or remove it, as needed.
            //this.Rpt_Fetch_DeliveryInvoiceTableAdapter.Fill(this.DeliveryInvoiceLaser.Rpt_Fetch_DeliveryInvoice);

            //this.reportViewer1.RefreshReport();
        }
    }
}
