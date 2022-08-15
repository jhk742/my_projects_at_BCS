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
    public partial class SalesOrderHistory : Form
    {
        string selectedCustomerID, selectedProductID;
        public SalesOrderHistory(String CustomerID, String ProductID)
        {
            InitializeComponent();

            selectedCustomerID = CustomerID;
            selectedProductID = ProductID;

            grid_OrderDetail_Init();

            txt_customerID.Text = CustomerID;
            txt_productID.Text = ProductID;

        }

        private void grid_OrderDetail_Init()
        {
            grid_OrderDetail.AutoGenerateColumns = false;
            grid_OrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_OrderDetail.ColumnCount = 10;

            grid_OrderDetail.Columns[0].Name = "";
            grid_OrderDetail.Columns[0].Visible = false;
            grid_OrderDetail.Columns[0].Width = 80;
            grid_OrderDetail.Columns[0].MinimumWidth = 80;
            grid_OrderDetail.Columns[0].DataPropertyName = "";

            grid_OrderDetail.Columns[1].Name = "Order Date";
            grid_OrderDetail.Columns[1].ReadOnly = true;
            grid_OrderDetail.Columns[1].Width = 75;
            grid_OrderDetail.Columns[1].MinimumWidth = 75;
            grid_OrderDetail.Columns[1].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_OrderDetail.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[1].DataPropertyName = "OrderDate";

            grid_OrderDetail.Columns[2].Name = "Order ID";
            grid_OrderDetail.Columns[2].ReadOnly = true;
            grid_OrderDetail.Columns[2].Width = 90;
            grid_OrderDetail.Columns[2].MinimumWidth = 90;
            grid_OrderDetail.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[2].DataPropertyName = "OrderID";

            grid_OrderDetail.Columns[3].Name = "Delivery Number";
            grid_OrderDetail.Columns[3].ReadOnly = true;
            grid_OrderDetail.Columns[3].Width = 105;
            grid_OrderDetail.Columns[3].MinimumWidth = 105;
            grid_OrderDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[3].DataPropertyName = "DeliveryNumber";

            grid_OrderDetail.Columns[4].Name = "Invoice Number";
            grid_OrderDetail.Columns[4].ReadOnly = true;
            grid_OrderDetail.Columns[4].Width = 85;
            grid_OrderDetail.Columns[4].MinimumWidth = 85;
            grid_OrderDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[4].DataPropertyName = "InvoiceNumber";

            grid_OrderDetail.Columns[5].Name = "Ordered Qty";
            grid_OrderDetail.Columns[5].ReadOnly = true;
            grid_OrderDetail.Columns[5].Width = 50;
            grid_OrderDetail.Columns[5].MinimumWidth = 50;
            grid_OrderDetail.Columns[5].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[5].DataPropertyName = "OrderedQty";

            grid_OrderDetail.Columns[6].Name = "Sales Unit";
            grid_OrderDetail.Columns[6].Visible = false;
            grid_OrderDetail.Columns[6].ReadOnly = true;
            grid_OrderDetail.Columns[6].Width = 60;
            grid_OrderDetail.Columns[6].MinimumWidth = 60;
            grid_OrderDetail.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[6].DataPropertyName = "";

            grid_OrderDetail.Columns[7].Name = "Gross Price";
            grid_OrderDetail.Columns[7].ReadOnly = true;
            grid_OrderDetail.Columns[7].Width = 70;
            grid_OrderDetail.Columns[7].MinimumWidth = 70;
            grid_OrderDetail.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[7].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[7].DataPropertyName = "GrossPrice";

            grid_OrderDetail.Columns[8].Name = "Promo";
            grid_OrderDetail.Columns[8].ReadOnly = true;
            grid_OrderDetail.Columns[8].Width = 70;
            grid_OrderDetail.Columns[8].MinimumWidth = 70;
            grid_OrderDetail.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[8].DataPropertyName = "Promotion";

            grid_OrderDetail.Columns[9].Name = "Invoice Date";
            grid_OrderDetail.Columns[9].ReadOnly = true;
            grid_OrderDetail.Columns[9].Width = 75;
            grid_OrderDetail.Columns[9].MinimumWidth = 75;
            grid_OrderDetail.Columns[9].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_OrderDetail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[9].DataPropertyName = "InvoiceDate";

            //grid font size custom
            grid_OrderDetail.RowTemplate.Height = 20;
            grid_OrderDetail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_OrderDetail.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_OrderDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_OrderDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Close();
            }
        }

        private void ManualOrderSalesHistory_Load(object sender, EventArgs e)
        {
            connSalesOrder.sp_ManualOrder_SalesHistory(grid_OrderDetail, selectedCustomerID, selectedProductID);
            grid_OrderDetail.ClearSelection();
        }
    }
}
