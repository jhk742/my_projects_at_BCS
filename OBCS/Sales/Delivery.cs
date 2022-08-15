using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Sales
{
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
            grid_ORDER_Init();
            salesOrder_refresh();

            cbo_customerID.Items.Clear();
            cbo_customerID.Items.Add("");
            connPO.cbox_getCustomerID(cbo_customerID);

            cbo_drivers.Items.Add("");
            connSalesOrder.cbo_Driver(cbo_drivers);
        }

        private void grid_ORDER_Init()
        {
            grid_ORDER.AutoGenerateColumns = false;
            grid_ORDER.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_ORDER.ColumnCount = 14;

            grid_ORDER.Columns[0].Name = "No.";
            grid_ORDER.Columns[0].Visible = false;
            grid_ORDER.Columns[0].ReadOnly = true;
            grid_ORDER.Columns[0].Width = 50;
            grid_ORDER.Columns[0].DataPropertyName = "";

            grid_ORDER.Columns[1].Name = "Site";
            grid_ORDER.Columns[1].ReadOnly = true;
            grid_ORDER.Columns[1].Width = 50;
            grid_ORDER.Columns[1].DataPropertyName = "Branch";

            grid_ORDER.Columns[2].Name = "Order ID";
            //grid_ORDER.Columns[2].Visible = false;
            grid_ORDER.Columns[2].ReadOnly = true;
            grid_ORDER.Columns[2].Width = 120;
            grid_ORDER.Columns[2].DataPropertyName = "OrderID";

            grid_ORDER.Columns[3].Name = "Route";
            grid_ORDER.Columns[3].ReadOnly = true;
            grid_ORDER.Columns[3].Width = 50;
            grid_ORDER.Columns[3].DataPropertyName = "RouteNumber";

            grid_ORDER.Columns[4].Name = "Driver Name";
            grid_ORDER.Columns[4].ReadOnly = true;
            grid_ORDER.Columns[4].Width = 100;
            grid_ORDER.Columns[4].DataPropertyName = "DriverName";

            grid_ORDER.Columns[5].Name = "Delivery Number";
            grid_ORDER.Columns[5].ReadOnly = true;
            grid_ORDER.Columns[5].Width = 120;
            grid_ORDER.Columns[5].DataPropertyName = "DeliveryNumber";

            grid_ORDER.Columns[6].Name = "Customer ID";
            grid_ORDER.Columns[6].ReadOnly = true;
            grid_ORDER.Columns[6].Width = 100;
            grid_ORDER.Columns[6].DataPropertyName = "CustomerID";

            grid_ORDER.Columns[7].Name = "Sales Rep.";
            grid_ORDER.Columns[7].ReadOnly = true;
            grid_ORDER.Columns[7].Width = 80;
            grid_ORDER.Columns[7].DataPropertyName = "SaleRep";

            grid_ORDER.Columns[8].Name = "Order Date";
            grid_ORDER.Columns[8].ReadOnly = true;
            grid_ORDER.Columns[8].Width = 80;
            grid_ORDER.Columns[8].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_ORDER.Columns[8].DataPropertyName = "OrderDate";

            grid_ORDER.Columns[9].Name = "Status";
            grid_ORDER.Columns[9].ReadOnly = true;
            grid_ORDER.Columns[9].Width = 80;
            grid_ORDER.Columns[9].DataPropertyName = "OrderStatus";

            grid_ORDER.Columns[10].Name = "Printed";
            grid_ORDER.Columns[10].Visible = false ;
            grid_ORDER.Columns[10].Width = 50;
            grid_ORDER.Columns[10].DataPropertyName = "";

            grid_ORDER.Columns[11].Name = "Amount";
            grid_ORDER.Columns[11].Visible = false;
            grid_ORDER.Columns[11].Width = 70;
            grid_ORDER.Columns[11].DefaultCellStyle.Format = "N2";
            grid_ORDER.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[11].DataPropertyName = "";

            grid_ORDER.Columns[12].Name = "Credit";
            grid_ORDER.Columns[12].ReadOnly = true;
            grid_ORDER.Columns[12].Width = 70;
            grid_ORDER.Columns[12].DefaultCellStyle.Format = "N2";
            grid_ORDER.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[12].DataPropertyName = "CreditAmount";

            grid_ORDER.Columns[13].Name = "Memo";
            grid_ORDER.Columns[13].ReadOnly = true;
            grid_ORDER.Columns[13].Width = 300;
            grid_ORDER.Columns[13].DataPropertyName = "OrderMemo";

            

            //grid font size custom
            grid_ORDER.RowTemplate.Height = 20;
            grid_ORDER.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_ORDER.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_ORDER.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void salesOrder_refresh()
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String DeliveryNumber = txt_DeliveryNo.Text.Trim();
            String CustomerID = cbo_customerID.Text.Trim();
            String RouteNumber = txt_routeNumber.Text.Trim();
            String DriverName = cbo_drivers.Text.Trim();
            connSalesOrder.sp_Fetch_Delivery(grid_ORDER, FromDate, ToDate, DeliveryNumber, CustomerID, RouteNumber, DriverName);
            grid_ORDER.ClearSelection();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            salesOrder_refresh();
        }
        
        private void grid_ORDER_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //String iPadOrderID = grid_ORDER.Rows[e.RowIndex].Cells["iPad Order ID"].Value.ToString().Trim();
                String OrderID = grid_ORDER.Rows[e.RowIndex].Cells["Order ID"].Value.ToString().Trim();
                String DeliveryNumber = grid_ORDER.Rows[e.RowIndex].Cells["Delivery Number"].Value.ToString().Trim();
                String OrderStatus = connSalesOrder.sp_GET_DeliveryStatus(OrderID);
                //if (OrderStatus == "Invoice")
                //{
                //    MessageBox.Show("This Delivery invoice, " + DeliveryNumber + " already has been made invoice.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //    return;
                //}

                grid_ORDER.Rows[e.RowIndex].Cells["Status"].Value = OrderStatus;
                

                if (OrderStatus == "void")
                {
                    MessageBox.Show("This Delivery invoice, " + DeliveryNumber + " has been voided.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                DeliveryDetail deliveryDetail = new DeliveryDetail(OrderID);
                deliveryDetail.ShowDialog();

                OrderStatus = connSalesOrder.sp_GET_DeliveryStatus(OrderID);
                grid_ORDER.Rows[e.RowIndex].Cells["Status"].Value = OrderStatus;
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                salesOrder_refresh();
            }
                
        }
    }
}
