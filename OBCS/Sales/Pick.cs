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
    public partial class Pick : Form
    {
        public Pick()
        {
            InitializeComponent();
            grid_ORDER_Init();
            salesOrder_refresh();
        }

        private void grid_ORDER_Init()
        {
            grid_ORDER.AutoGenerateColumns = false;

            grid_ORDER.ColumnCount = 11;

            grid_ORDER.Columns[0].Name = "No.";
            grid_ORDER.Columns[0].ReadOnly = true;
            grid_ORDER.Columns[0].Width = 50;
            grid_ORDER.Columns[0].DataPropertyName = "";

            grid_ORDER.Columns[1].Name = "Site";
            grid_ORDER.Columns[1].ReadOnly = true;
            grid_ORDER.Columns[1].Width = 60;
            grid_ORDER.Columns[1].DataPropertyName = "Branch";

            grid_ORDER.Columns[2].Name = "Order ID";
            //grid_ORDER.Columns[2].Visible = false;
            grid_ORDER.Columns[2].ReadOnly = true;
            grid_ORDER.Columns[2].Width = 270;
            grid_ORDER.Columns[2].DataPropertyName = "OrderID";

            grid_ORDER.Columns[3].Name = "Customer ID";
            grid_ORDER.Columns[3].ReadOnly = true;
            grid_ORDER.Columns[3].Width = 100;
            grid_ORDER.Columns[3].DataPropertyName = "CustomerID";

            grid_ORDER.Columns[4].Name = "Sales Rep.";
            grid_ORDER.Columns[4].ReadOnly = true;
            grid_ORDER.Columns[4].Width = 80;
            grid_ORDER.Columns[4].DataPropertyName = "SaleRep";

            grid_ORDER.Columns[5].Name = "Order Date";
            grid_ORDER.Columns[5].ReadOnly = true;
            grid_ORDER.Columns[5].Width = 80;
            grid_ORDER.Columns[5].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_ORDER.Columns[5].DataPropertyName = "OrderDate";

            grid_ORDER.Columns[6].Name = "Status";
            grid_ORDER.Columns[6].Width = 50;
            grid_ORDER.Columns[6].DataPropertyName = "OrderStatus";

            grid_ORDER.Columns[7].Name = "Printed";
            grid_ORDER.Columns[7].Width = 50;
            grid_ORDER.Columns[7].DataPropertyName = "";

            grid_ORDER.Columns[8].Name = "Amount";
            grid_ORDER.Columns[8].Width = 70;
            grid_ORDER.Columns[8].DefaultCellStyle.Format = "N2";
            grid_ORDER.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[8].DataPropertyName = "";

            grid_ORDER.Columns[9].Name = "Credit";
            grid_ORDER.Columns[9].Width = 70;
            grid_ORDER.Columns[9].DefaultCellStyle.Format = "N2";
            grid_ORDER.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[9].DataPropertyName = "CreditAmount";

            grid_ORDER.Columns[10].Name = "Memo";
            grid_ORDER.Columns[10].Width = 300;
            grid_ORDER.Columns[10].DataPropertyName = "OrderMemo";
            
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
            connSalesOrder.sp_Fetch_Pick(grid_ORDER, FromDate, ToDate);
            grid_ORDER.ClearSelection();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            salesOrder_refresh();
        }

        private void grid_ORDER_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //String iPadOrderID = grid_ORDER.Rows[e.RowIndex].Cells["iPad Order ID"].Value.ToString().Trim();
            String OrderID = grid_ORDER.Rows[e.RowIndex].Cells["Order ID"].Value.ToString().Trim();
            PickDetail pickDetail = new PickDetail(OrderID);
            pickDetail.Show();
        }
    }
}
