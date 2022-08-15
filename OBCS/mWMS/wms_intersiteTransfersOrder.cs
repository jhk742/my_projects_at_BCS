using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.mWMS
{
    public partial class wms_intersiteTransfersOrder : Form
    {
        public wms_intersiteTransfersOrder()
        {
            InitializeComponent();
            grid_ORDER_Init();
        }

        private void grid_ORDER_Init()
        {
            grid_ORDER.AutoGenerateColumns = false;
            grid_ORDER.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_ORDER.ColumnCount = 5;

            grid_ORDER.Columns[0].Name = "Order ID";
            grid_ORDER.Columns[0].ReadOnly = true;
            grid_ORDER.Columns[0].Width = 75;
            grid_ORDER.Columns[0].MinimumWidth = 75;
            grid_ORDER.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDER.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDER.Columns[0].DataPropertyName = "WHCHGNumber";

            grid_ORDER.Columns[1].Name = "Order Date";
            grid_ORDER.Columns[1].ReadOnly = true;
            grid_ORDER.Columns[1].Width = 90;
            grid_ORDER.Columns[1].MinimumWidth = 90;
            grid_ORDER.Columns[1].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_ORDER.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDER.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDER.Columns[1].DataPropertyName = "CreateDate";

            grid_ORDER.Columns[2].Name = "Stock Site";
            grid_ORDER.Columns[2].ReadOnly = true;
            grid_ORDER.Columns[2].Width = 110;
            grid_ORDER.Columns[2].MinimumWidth = 100;
            grid_ORDER.Columns[2].DataPropertyName = "StockSite";

            grid_ORDER.Columns[3].Name = "Dest Site";
            grid_ORDER.Columns[3].ReadOnly = true;
            grid_ORDER.Columns[3].Width = 110;
            grid_ORDER.Columns[3].MinimumWidth = 100;
            grid_ORDER.Columns[3].DataPropertyName = "DestSite";
            
            grid_ORDER.Columns[4].Name = "Memo";
            grid_ORDER.Columns[4].ReadOnly = true;
            grid_ORDER.Columns[4].Width = 200;
            grid_ORDER.Columns[4].DataPropertyName = "Memo";
            

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

        private void btn_new_Click(object sender, EventArgs e)
        {
            String NewWHCHGNumber = connSalesOrder.sp_GET_NewWHCHGNumber();
            connSalesOrder.sp_WMS_INTERSITETRANSFERS_CREATE_HEADER(NewWHCHGNumber);

            try
            {
                wms_intersiteTransfersOrderDetail detail = new wms_intersiteTransfersOrderDetail(NewWHCHGNumber);
                detail.StartPosition = FormStartPosition.CenterScreen;
                detail.Show();
            }
            catch
            {

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            connSalesOrder.sp_WMS_INTERSITETRANSFERS_Search(grid_ORDER, FromDate, ToDate);
            grid_ORDER.ClearSelection();
        }

        private void grid_ORDER_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String OrderID = grid_ORDER.Rows[e.RowIndex].Cells["Order ID"].Value.ToString().Trim();

                wms_intersiteTransfersOrderDetail detail = new wms_intersiteTransfersOrderDetail(OrderID);
                detail.StartPosition = FormStartPosition.CenterScreen;
                detail.Show();
            }
            catch
            {

            }
        }
    }
}
