using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Lists
{
    public partial class GlobalAllocated : Form
    {
        public GlobalAllocated(String ProductID, String ProductDesc)
        {
            InitializeComponent();

            txt_searchProductID.Text = ProductID.Trim();
            txt_searchProductDesc.Text = ProductDesc.Trim();

            grid_globalAllocated_Init();
            connSalesOrder.sp_List_ProductList_GlobalAllocated(grid_globalAllocated, ProductID);

        }

        private void grid_globalAllocated_Init()
        {
            grid_globalAllocated.AutoGenerateColumns = false;
            grid_globalAllocated.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_globalAllocated.ColumnCount = 5;

            grid_globalAllocated.Columns[0].Name = "Sales Rep.";
            grid_globalAllocated.Columns[0].ReadOnly = true;
            grid_globalAllocated.Columns[0].Width = 60;
            grid_globalAllocated.Columns[0].MinimumWidth = 60;
            grid_globalAllocated.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_globalAllocated.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_globalAllocated.Columns[0].DataPropertyName = "SalesRep";

            grid_globalAllocated.Columns[1].Name = "Customer ID";
            grid_globalAllocated.Columns[1].ReadOnly = true;
            grid_globalAllocated.Columns[1].Width = 60;
            grid_globalAllocated.Columns[1].MinimumWidth = 60;
            grid_globalAllocated.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_globalAllocated.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_globalAllocated.Columns[1].DataPropertyName = "CustomerID";

            grid_globalAllocated.Columns[2].Name = "Order ID";
            grid_globalAllocated.Columns[2].ReadOnly = true;
            grid_globalAllocated.Columns[2].Width = 40;
            grid_globalAllocated.Columns[2].MinimumWidth = 40;
            grid_globalAllocated.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_globalAllocated.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_globalAllocated.Columns[2].DataPropertyName = "OrderID";

            grid_globalAllocated.Columns[3].Name = "Order Qty";
            grid_globalAllocated.Columns[3].ReadOnly = true;
            grid_globalAllocated.Columns[3].Width = 80;
            grid_globalAllocated.Columns[3].MinimumWidth = 80;
            grid_globalAllocated.Columns[3].DefaultCellStyle.Format = "N2";
            grid_globalAllocated.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_globalAllocated.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_globalAllocated.Columns[3].DataPropertyName = "OrderQty";

            grid_globalAllocated.Columns[4].Name = "Order Created Date";
            grid_globalAllocated.Columns[4].ReadOnly = true;
            grid_globalAllocated.Columns[4].Width = 75;
            grid_globalAllocated.Columns[4].MinimumWidth = 75;
            //grid_globalAllocated.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_globalAllocated.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_globalAllocated.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_globalAllocated.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_globalAllocated.Columns[4].DataPropertyName = "OrderCreatedDate";
            
            //grid font size custom
            grid_globalAllocated.RowTemplate.Height = 20;
            grid_globalAllocated.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_globalAllocated.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_globalAllocated.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            connSalesOrder.sp_List_ProductList_GlobalAllocated(grid_globalAllocated, txt_searchProductID.Text.Trim());
        }

        private void grid_globalAllocated_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String OrderID = grid_globalAllocated.Rows[e.RowIndex].Cells["Order ID"].Value.ToString().Trim();
                String OrderStatus = connSalesOrder.sp_GET_Order2OrderStatus(OrderID);
                if (OrderStatus == "PickingList")
                {
                    MessageBox.Show("This order number's picking list already has been made.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (OrderStatus == "void")
                {
                    MessageBox.Show("This Order Number has been deleted.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                Sales.ConfirmedSalesOrderDetail orderDetail2 = new Sales.ConfirmedSalesOrderDetail(OrderID);
                orderDetail2.StartPosition = FormStartPosition.CenterScreen;
                orderDetail2.ShowDialog();
            }
            catch
            {

            }
        }
    }
}
