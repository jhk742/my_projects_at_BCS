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
    public partial class Rpt_PickingList : Form
    {
        public Rpt_PickingList(String OrderID)
        {
            InitializeComponent();

            String Branch = connSalesOrder.getBranchFromOrderID(OrderID);
            String ABCDEF = connSalesOrder.sp_GET_ABCDEF(OrderID);
            DateTime OrderDateDate = connSalesOrder.getOrderDateFromOrderID(OrderID);
            String OrderDate = OrderDateDate.Date.ToShortDateString();
            String Driver = connSalesOrder.getDriverFromOrderID(OrderID);
            String Truck = connSalesOrder.getTruckFromOrderID(OrderID);
            String CustomerID = connSalesOrder.getCustomerIDFromOrderID(OrderID);
            String ShipTo = connSalesOrder.getShipToFromOrderID(OrderID);
            String REP = connSalesOrder.getSaleRepFromOrderID(OrderID);
            //String CoreCustomerID = connSalesOrder.getCoreCustomerID(CustomerID);
            //String Memo = connSalesOrder.getMarkUpMemo(CoreCustomerID);
            String Memo = connSalesOrder.sp_GET_PickingListMemo(CustomerID);


            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("OrderID", OrderID));
            reportParameters.Add(new ReportParameter("Branch", Branch));
            reportParameters.Add(new ReportParameter("ABCDEF", ABCDEF));
            reportParameters.Add(new ReportParameter("OrderDate", OrderDate));
            reportParameters.Add(new ReportParameter("Driver", Driver));
            reportParameters.Add(new ReportParameter("Truck", Truck));
            reportParameters.Add(new ReportParameter("CustomerID", CustomerID));
            reportParameters.Add(new ReportParameter("ShipTo", ShipTo));
            reportParameters.Add(new ReportParameter("REP", REP));
            reportParameters.Add(new ReportParameter("Memo", Memo));


            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.Rpt_Fetch_PickingListTableAdapter.Fill(this.PickingList.Rpt_Fetch_PickingList, OrderID);

            var rds = new ReportDataSource("PickingList", this.PickingList.Rpt_Fetch_PickingList as DataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            

        }

        private void Rpt_PickingList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PickingList.Rpt_Fetch_PickingList' table. You can move, or remove it, as needed.
            //this.Rpt_Fetch_PickingListTableAdapter.Fill(this.PickingList.Rpt_Fetch_PickingList, "NYC000009");

            //this.reportViewer1.RefreshReport();
            //PrintDialog printDialog = new PrintDialog();
            //printDialog.ShowDialog();

            //Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //PrintDialog printDialog = new PrintDialog();
            //printDialog.ShowDialog();
        }

        private void Rpt_PickingList_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("ESC");
            //if (e.KeyChar == Convert.ToChar(Keys.Escape))
            //{
            //    MessageBox.Show("ESC");
            //    this.Close();

            //}
            
        }

        private void reportViewer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("ESC");
            //if (e.KeyChar == Convert.ToChar(Keys.Escape))
            //{
            //    MessageBox.Show("ESC");
            //    this.Close();

            //}
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
    }
}
