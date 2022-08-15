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
    public partial class SalesPromotionReport : Form
    {
        public SalesPromotionReport()
        {
            InitializeComponent();
            grid_salesPromotionReport_Init();
            connPO.cbox_BPSaleRep(cbx_SalesRep);
        }

        private void grid_salesPromotionReport_Init()
        {
            grid_salesPromotionReport.AutoGenerateColumns = false;
            grid_salesPromotionReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_salesPromotionReport.ColumnCount = 11;

            grid_salesPromotionReport.Columns[0].Name = "Confirm Order Date";
            grid_salesPromotionReport.Columns[0].ReadOnly = true;
            grid_salesPromotionReport.Columns[0].Width = 70;
            grid_salesPromotionReport.Columns[0].MinimumWidth = 70;
            grid_salesPromotionReport.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesPromotionReport.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesPromotionReport.Columns[0].DataPropertyName = "OrderDate";

            grid_salesPromotionReport.Columns[1].Name = "Sales Rep";
            grid_salesPromotionReport.Columns[1].ReadOnly = true;
            grid_salesPromotionReport.Columns[1].Width = 50;
            grid_salesPromotionReport.Columns[1].MinimumWidth = 50;
            grid_salesPromotionReport.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesPromotionReport.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesPromotionReport.Columns[1].DataPropertyName = "SaleRep";

            grid_salesPromotionReport.Columns[2].Name = "Brand";
            grid_salesPromotionReport.Columns[2].ReadOnly = true;
            grid_salesPromotionReport.Columns[2].Width = 100;
            grid_salesPromotionReport.Columns[2].MinimumWidth = 100;
            grid_salesPromotionReport.Columns[2].DataPropertyName = "Brand";

            grid_salesPromotionReport.Columns[3].Name = "Product ID";
            grid_salesPromotionReport.Columns[3].ReadOnly = true;
            grid_salesPromotionReport.Columns[3].Width = 100;
            grid_salesPromotionReport.Columns[3].MinimumWidth = 100;
            grid_salesPromotionReport.Columns[3].DataPropertyName = "ProductID";

            grid_salesPromotionReport.Columns[4].Name = "Product Description";
            grid_salesPromotionReport.Columns[4].ReadOnly = true;
            grid_salesPromotionReport.Columns[4].Width = 350;
            grid_salesPromotionReport.Columns[4].MinimumWidth = 350;
            grid_salesPromotionReport.Columns[4].DataPropertyName = "ProductDesc";

            grid_salesPromotionReport.Columns[5].Name = "Pack Size";
            grid_salesPromotionReport.Columns[5].ReadOnly = true;
            grid_salesPromotionReport.Columns[5].Width = 100;
            grid_salesPromotionReport.Columns[5].MinimumWidth = 100;
            grid_salesPromotionReport.Columns[5].DataPropertyName = "PackSize";

            grid_salesPromotionReport.Columns[6].Name = "Order Qty";
            grid_salesPromotionReport.Columns[6].ReadOnly = true;
            grid_salesPromotionReport.Columns[6].Width = 70;
            grid_salesPromotionReport.Columns[6].MinimumWidth = 70;
            grid_salesPromotionReport.Columns[6].DefaultCellStyle.Format = "N2";
            grid_salesPromotionReport.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesPromotionReport.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesPromotionReport.Columns[6].DataPropertyName = "OrderQty";

            grid_salesPromotionReport.Columns[7].Name = "Price";
            grid_salesPromotionReport.Columns[7].ReadOnly = true;
            grid_salesPromotionReport.Columns[7].Width = 70;
            grid_salesPromotionReport.Columns[7].MinimumWidth = 70;
            grid_salesPromotionReport.Columns[7].DefaultCellStyle.Format = "N2";
            grid_salesPromotionReport.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesPromotionReport.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesPromotionReport.Columns[7].DataPropertyName = "Price";

            grid_salesPromotionReport.Columns[8].Name = "Amount";
            grid_salesPromotionReport.Columns[8].ReadOnly = true;
            grid_salesPromotionReport.Columns[8].Width = 80;
            grid_salesPromotionReport.Columns[8].MinimumWidth = 80;
            grid_salesPromotionReport.Columns[8].DefaultCellStyle.Format = "N2";
            grid_salesPromotionReport.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesPromotionReport.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesPromotionReport.Columns[8].DataPropertyName = "Total";

            grid_salesPromotionReport.Columns[9].Name = "Customer ID";
            grid_salesPromotionReport.Columns[9].ReadOnly = true;
            grid_salesPromotionReport.Columns[9].Width = 100;
            grid_salesPromotionReport.Columns[9].MinimumWidth = 100;
            grid_salesPromotionReport.Columns[9].DataPropertyName = "CustomerID";

            grid_salesPromotionReport.Columns[10].Name = "Customer Name";
            grid_salesPromotionReport.Columns[10].ReadOnly = true;
            grid_salesPromotionReport.Columns[10].Width = 250;
            grid_salesPromotionReport.Columns[10].MinimumWidth = 250;
            grid_salesPromotionReport.Columns[10].DataPropertyName = "CustomerName";


            //grid font size custom
            grid_salesPromotionReport.RowTemplate.Height = 20;
            grid_salesPromotionReport.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_salesPromotionReport.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_salesPromotionReport.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String REP = cbx_SalesRep.Text.Trim();
            connSalesOrder.sp_SalesPromotionReport(grid_salesPromotionReport, FromDate, ToDate, REP);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String REP = cbx_SalesRep.Text.Trim();
            Reports.Rpt_SalesPromotionReport salesPromotionReport = new Reports.Rpt_SalesPromotionReport(FromDate, ToDate, REP);
            salesPromotionReport.Show();
        }
    }
}
