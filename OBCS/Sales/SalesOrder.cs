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
    public partial class SalesOrder : Form
    {
        public SalesOrder()
        {
            InitializeComponent();
            grid_ORDER_Init();
        }

        private void grid_ORDER_Init()
        {
            grid_ORDER.AutoGenerateColumns = false;
            grid_ORDER.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_ORDER.ColumnCount = 8;

            grid_ORDER.Columns[0].Name = "Order ID";
            grid_ORDER.Columns[0].ReadOnly = true;
            grid_ORDER.Columns[0].Width = 75;
            grid_ORDER.Columns[0].MinimumWidth = 75;
            grid_ORDER.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDER.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDER.Columns[0].DataPropertyName = "OrderID";

            grid_ORDER.Columns[1].Name = "Order Date";
            grid_ORDER.Columns[1].ReadOnly = true;
            grid_ORDER.Columns[1].Width = 90;
            grid_ORDER.Columns[1].MinimumWidth = 90;
            grid_ORDER.Columns[1].DefaultCellStyle.Format = "MM'/'dd'/'yyyy hh:mm tt";
            grid_ORDER.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDER.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDER.Columns[1].DataPropertyName = "OrderDate";

            grid_ORDER.Columns[2].Name = "Customer ID";
            grid_ORDER.Columns[2].ReadOnly = true;
            grid_ORDER.Columns[2].Width = 110;
            grid_ORDER.Columns[2].MinimumWidth = 100;
            grid_ORDER.Columns[2].DataPropertyName = "CustomerID";

            grid_ORDER.Columns[3].Name = "Customer Name";
            grid_ORDER.Columns[3].ReadOnly = true;
            grid_ORDER.Columns[3].Width = 110;
            grid_ORDER.Columns[3].MinimumWidth = 100;
            grid_ORDER.Columns[3].DataPropertyName = "CompanyName";

            grid_ORDER.Columns[4].Name = "Amount";
            grid_ORDER.Columns[4].ReadOnly = true;
            grid_ORDER.Columns[4].Width = 60;
            grid_ORDER.Columns[4].MinimumWidth = 60;
            grid_ORDER.Columns[4].DefaultCellStyle.Format = "N2";
            grid_ORDER.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[4].DataPropertyName = "OrderAmount";

            grid_ORDER.Columns[5].Name = "Credit";
            grid_ORDER.Columns[5].ReadOnly = true;
            grid_ORDER.Columns[5].Width = 50;
            grid_ORDER.Columns[5].MinimumWidth = 50;
            grid_ORDER.Columns[5].DefaultCellStyle.Format = "N2";
            grid_ORDER.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[5].DataPropertyName = "CrAmt";

            grid_ORDER.Columns[6].Name = "Memo";
            grid_ORDER.Columns[6].ReadOnly = true;
            grid_ORDER.Columns[6].Width = 200;
            grid_ORDER.Columns[6].DataPropertyName = "OrdMemo";

            grid_ORDER.Columns[7].Name = "Finish";
            grid_ORDER.Columns[7].ReadOnly = true;
            grid_ORDER.Columns[7].Width = 40;
            grid_ORDER.Columns[7].MinimumWidth = 40;
            grid_ORDER.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDER.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDER.Columns[7].DataPropertyName = "CompleteFlag";

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

        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            connSalesOrder.sp_ManualOrder_Search(grid_ORDER, FromDate, ToDate);
            grid_ORDER.ClearSelection();
        }

        private void grid_ORDER_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String OrderID = grid_ORDER.Rows[e.RowIndex].Cells["Order ID"].Value.ToString().Trim();
                
                SalesOrderDetail manualOrder = new SalesOrderDetail(OrderID);
                manualOrder.StartPosition = FormStartPosition.CenterScreen;
                manualOrder.Show();
            }
            catch
            {

            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            String NewORDNumber = connSalesOrder.sp_GET_NewORDNumber();
            connSalesOrder.sp_ManualOrder_CREATE_HEADER(NewORDNumber);

            try
            {
                SalesOrderDetail salesOrderDetail = new SalesOrderDetail(NewORDNumber);
                salesOrderDetail.StartPosition = FormStartPosition.CenterScreen;
                salesOrderDetail.Show();
            }
            catch
            {

            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManualOrderList_Load(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            connSalesOrder.sp_ManualOrder_Search(grid_ORDER, FromDate, ToDate);
            grid_ORDER.ClearSelection();
        }
    }
}