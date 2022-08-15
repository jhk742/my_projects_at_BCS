using OBCS.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Stock
{
    public partial class StockValuationReport : Form
    {
        public StockValuationReport()
        {
            InitializeComponent();
            grid_detail_Init();

            cbo_storageSite.Items.Add("");
            cbo_storageSite.Items.Add("BCS");
            cbo_storageSite.Items.Add("WH2");

            cbo_status.Items.Add("");
            cbo_status.Items.Add("A");
            cbo_status.Items.Add("Q");
            cbo_status.Items.Add("R");

            //DateTime AsofDate = DateTimePickerAsof.Value.Date;
            //String Site = cbo_storageSite.Text.Trim();
            //String Status = cbo_status.Text.Trim();
            //connSalesOrder.sp_StockValuationReport(grid_stockValuationReport, AsofDate, Site, Status);
        }
        private void grid_detail_Init()
        {
            grid_stockValuationReport.AutoGenerateColumns = false;
            grid_stockValuationReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_stockValuationReport.ColumnCount = 9;

            grid_stockValuationReport.Columns[0].Name = "Site";
            grid_stockValuationReport.Columns[0].ReadOnly = true;
            grid_stockValuationReport.Columns[0].Width = 40;
            grid_stockValuationReport.Columns[0].MinimumWidth = 40;
            grid_stockValuationReport.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stockValuationReport.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stockValuationReport.Columns[0].DataPropertyName = "Site";

            grid_stockValuationReport.Columns[1].Name = "Product";
            grid_stockValuationReport.Columns[1].ReadOnly = true;
            grid_stockValuationReport.Columns[1].Width = 90;
            grid_stockValuationReport.Columns[1].MinimumWidth = 90;
            grid_stockValuationReport.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stockValuationReport.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stockValuationReport.Columns[1].DataPropertyName = "ProductID";

            grid_stockValuationReport.Columns[2].Name = "Status";
            grid_stockValuationReport.Columns[2].ReadOnly = true;
            grid_stockValuationReport.Columns[2].Width = 30;
            grid_stockValuationReport.Columns[2].MinimumWidth = 30;
            grid_stockValuationReport.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stockValuationReport.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stockValuationReport.Columns[2].DataPropertyName = "Status";

            grid_stockValuationReport.Columns[3].Name = "Description";
            grid_stockValuationReport.Columns[3].ReadOnly = true;
            grid_stockValuationReport.Columns[3].Width = 300;
            grid_stockValuationReport.Columns[3].MinimumWidth = 300;
            grid_stockValuationReport.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stockValuationReport.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stockValuationReport.Columns[3].DataPropertyName = "ProductDesc";

            grid_stockValuationReport.Columns[4].Name = "STK Quantity";
            grid_stockValuationReport.Columns[4].ReadOnly = true;
            grid_stockValuationReport.Columns[4].Width = 80;
            grid_stockValuationReport.Columns[4].MinimumWidth = 80;
            grid_stockValuationReport.Columns[4].DefaultCellStyle.Format = "N2";
            grid_stockValuationReport.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stockValuationReport.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stockValuationReport.Columns[4].DataPropertyName = "STKQuantity";

            grid_stockValuationReport.Columns[5].Name = "Unit";
            grid_stockValuationReport.Columns[5].ReadOnly = true;
            grid_stockValuationReport.Columns[5].Width = 50;
            grid_stockValuationReport.Columns[5].MinimumWidth = 50;
            grid_stockValuationReport.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stockValuationReport.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stockValuationReport.Columns[5].DataPropertyName = "SalesUnit";

            grid_stockValuationReport.Columns[6].Name = "Unit Price";
            grid_stockValuationReport.Columns[6].ReadOnly = true;
            grid_stockValuationReport.Columns[6].Width = 80;
            grid_stockValuationReport.Columns[6].MinimumWidth = 80;
            grid_stockValuationReport.Columns[6].DefaultCellStyle.Format = "N2";
            grid_stockValuationReport.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stockValuationReport.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stockValuationReport.Columns[6].DataPropertyName = "UnitPrice";

            grid_stockValuationReport.Columns[7].Name = "AmountUSD";
            grid_stockValuationReport.Columns[7].ReadOnly = true;
            grid_stockValuationReport.Columns[7].Width = 80;
            grid_stockValuationReport.Columns[7].MinimumWidth = 80;
            grid_stockValuationReport.Columns[7].DefaultCellStyle.Format = "N2";
            grid_stockValuationReport.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stockValuationReport.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stockValuationReport.Columns[7].DataPropertyName = "Amount";
        
            grid_stockValuationReport.Columns[8].Name = "Costing mode";
            grid_stockValuationReport.Columns[8].ReadOnly = true;
            grid_stockValuationReport.Columns[8].Width = 80;
            grid_stockValuationReport.Columns[8].MinimumWidth = 80;
            grid_stockValuationReport.Columns[8].DefaultCellStyle.Format = "N2";
            grid_stockValuationReport.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stockValuationReport.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stockValuationReport.Columns[8].DataPropertyName = "CostingMode";
            
            //grid font size custom
            grid_stockValuationReport.RowTemplate.Height = 20;
            grid_stockValuationReport.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_stockValuationReport.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            //for (int i = 0; i < grid_DeliveryOS.ColumnCount; i++)
            //{
            //    grid_DeliveryOS.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            //}

            grid_stockValuationReport.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            grid_stockValuationReport.DataSource = null;
            DateTime AsofDate = DateTimePickerAsof.Value.Date;
            String Site = cbo_storageSite.Text.Trim();
            String Status = cbo_status.Text.Trim();
            connSalesOrder.sp_StockValuationReport(grid_stockValuationReport, AsofDate, Site, Status);

            //try
            //{
            //    DataTable dataTable = (DataTable)grid_DeliveryOS.DataSource;

            //    decimal TOTALDELIVERY = 0, TOTALDAMAGE = 0, TOTALMISSING = 0, TOTALNOTIN = 0, TOTALRETURN = 0, TOTALNETDELIVERY = 0, TOTALDIFF = 0;

            //    for (int i = 0; i < grid_DeliveryOS.RowCount; i++)
            //    {
            //        TOTALDELIVERY += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["DELIVERY"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["DELIVERY"].Value);
            //        TOTALDAMAGE += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["DAMAGED"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["DAMAGED"].Value);
            //        TOTALMISSING += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["MISSING"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["MISSING"].Value);
            //        TOTALNOTIN += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["NOT IN"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["NOT IN"].Value);
            //        TOTALRETURN += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["RETURN"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["RETURN"].Value);
            //        TOTALNETDELIVERY += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["NETDELIVERY"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["NETDELIVERY"].Value);
            //        TOTALDIFF += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["DELIVERY DIFFERENCE"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["DELIVERY DIFFERENCE"].Value);
            //    }

            //    DataRow drToAdd = dataTable.NewRow();
            //    drToAdd["DeliveryNumber"] = "TOTAL";
            //    drToAdd["SaleRep"] = "";
            //    drToAdd["CustomerID"] = "";
            //    drToAdd["DELIVERY"] = TOTALDELIVERY.ToString();
            //    drToAdd["OrderDate"] = DBNull.Value;
            //    drToAdd["DAMAGED"] = TOTALDAMAGE.ToString();
            //    drToAdd["MISSING"] = TOTALMISSING.ToString();
            //    drToAdd["NOTIN"] = TOTALNOTIN.ToString();
            //    drToAdd["RT"] = TOTALRETURN.ToString();
            //    drToAdd["NETDELIVERY"] = TOTALNETDELIVERY.ToString();
            //    drToAdd["DELIVERYDIFF"] = TOTALDIFF.ToString();

            //    dataTable.Rows.Add(drToAdd);

            //    dataTable.AcceptChanges();

            //    this.grid_DeliveryOS.ClearSelection();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void grid_DeliveryOS_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //foreach (DataGridViewRow row in this.grid_stockValuationReport.Rows)
            //{
            //    if (row.Cells["Amount"].Value.Equals("TOTAL"))
            //    {
            //        for (int i = 0; i < grid_stockValuationReport.ColumnCount; i++)
            //        {
            //            row.Cells[i].Style.BackColor = Color.Gray;
            //            row.Cells[i].Style.ForeColor = Color.White;
            //        }
            //    }
            //}
            decimal TOTALAMOUNT = 0;
            decimal TOTALQty = 0;

            for (int i = 0; i < grid_stockValuationReport.RowCount; i++)
            {
                TOTALAMOUNT += Convert.ToDecimal(grid_stockValuationReport.Rows[i].Cells["AmountUSD"].Value == DBNull.Value ? "0" : grid_stockValuationReport.Rows[i].Cells["AmountUSD"].Value);
                TOTALQty += Convert.ToDecimal(grid_stockValuationReport.Rows[i].Cells["STK Quantity"].Value == DBNull.Value ? "0" : grid_stockValuationReport.Rows[i].Cells["STK Quantity"].Value);
            }

            txt_totalAmount.Text = TOTALAMOUNT.ToString("N2");
            txt_TotalQty.Text = TOTALQty.ToString("N2");
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime AsOfDate = DateTimePickerAsof.Value.Date;
            String Site = cbo_storageSite.Text.Trim();
            String Status = cbo_status.Text.Trim();
            Rpt_StockValuationReport rpt_StockValuationReport = new Rpt_StockValuationReport(AsOfDate, Site, Status);
            rpt_StockValuationReport.Show();
        }
    }
}
