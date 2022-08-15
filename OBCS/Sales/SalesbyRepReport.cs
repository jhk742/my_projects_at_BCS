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
    public partial class SalesbyRepReport : Form
    {
        public SalesbyRepReport()
        {
            InitializeComponent();

            grid_salesReport_Init();
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-14);

            for (int i = 0; i < grid_salesReport.ColumnCount; i++)
            {
                grid_salesReport.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }
        
        private void grid_salesReport_Init()
        {
            grid_salesReport.AutoGenerateColumns = false;
            grid_salesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_salesReport.ColumnCount = 18;

            grid_salesReport.Columns[0].Name = "Branch";
            grid_salesReport.Columns[0].ReadOnly = true;
            grid_salesReport.Columns[0].Width = 40;
            grid_salesReport.Columns[0].MinimumWidth = 40;
            grid_salesReport.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[0].DataPropertyName = "Branch";

            grid_salesReport.Columns[1].Name = "Sale Rep";
            grid_salesReport.Columns[1].ReadOnly = true;
            grid_salesReport.Columns[1].Width = 40;
            grid_salesReport.Columns[1].MinimumWidth = 40;
            grid_salesReport.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[1].DataPropertyName = "SaleRep";

            grid_salesReport.Columns[2].Name = "Gross Sales";
            grid_salesReport.Columns[2].ReadOnly = true;
            grid_salesReport.Columns[2].Width = 60;
            grid_salesReport.Columns[2].MinimumWidth = 60;
            grid_salesReport.Columns[2].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[2].DataPropertyName = "GrossSales";

            grid_salesReport.Columns[3].Name = "Promotion";
            grid_salesReport.Columns[3].ReadOnly = true;
            grid_salesReport.Columns[3].Width = 60;
            grid_salesReport.Columns[3].MinimumWidth = 60;
            grid_salesReport.Columns[3].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[3].DataPropertyName = "Promotion";

            grid_salesReport.Columns[4].Name = "Promotion Ratio";
            grid_salesReport.Columns[4].ReadOnly = true;
            grid_salesReport.Columns[4].Width = 70;
            grid_salesReport.Columns[4].MinimumWidth = 70;
            grid_salesReport.Columns[4].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[4].DataPropertyName = "PromotionRatio";

            grid_salesReport.Columns[5].Name = "Credit";
            grid_salesReport.Columns[5].ReadOnly = true;
            grid_salesReport.Columns[5].Width = 60;
            grid_salesReport.Columns[5].MinimumWidth = 60;
            grid_salesReport.Columns[5].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[5].DataPropertyName = "Credit";

            grid_salesReport.Columns[6].Name = "Credit Ratio";
            grid_salesReport.Columns[6].ReadOnly = true;
            grid_salesReport.Columns[6].Width = 60;
            grid_salesReport.Columns[6].MinimumWidth = 60;
            grid_salesReport.Columns[6].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[6].DataPropertyName = "CreditRatio";

            grid_salesReport.Columns[7].Name = "Return Credit";
            grid_salesReport.Columns[7].ReadOnly = true;
            grid_salesReport.Columns[7].Width = 60;
            grid_salesReport.Columns[7].MinimumWidth = 60;
            grid_salesReport.Columns[7].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[7].DataPropertyName = "ReturnCredit";

            grid_salesReport.Columns[8].Name = "Return Credit Ratio";
            grid_salesReport.Columns[8].ReadOnly = true;
            grid_salesReport.Columns[8].Width = 80;
            grid_salesReport.Columns[8].MinimumWidth = 80;
            grid_salesReport.Columns[8].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[8].DataPropertyName = "ReturnCreditRatio";

            grid_salesReport.Columns[9].Name = "Term Credit";
            grid_salesReport.Columns[9].ReadOnly = true;
            grid_salesReport.Columns[9].Width = 60;
            grid_salesReport.Columns[9].MinimumWidth = 60;
            grid_salesReport.Columns[9].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[9].DataPropertyName = "TermCredit";

            grid_salesReport.Columns[10].Name = "Term Credit Ratio";
            grid_salesReport.Columns[10].ReadOnly = true;
            grid_salesReport.Columns[10].Width = 80;
            grid_salesReport.Columns[10].MinimumWidth = 80;
            grid_salesReport.Columns[10].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[10].DataPropertyName = "TermCreditRatio";

            grid_salesReport.Columns[11].Name = "Net Sales";
            grid_salesReport.Columns[11].ReadOnly = true;
            grid_salesReport.Columns[11].Width = 70;
            grid_salesReport.Columns[11].MinimumWidth = 70;
            grid_salesReport.Columns[11].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[11].DataPropertyName = "NetSales";

            grid_salesReport.Columns[12].Name = "COGS";
            grid_salesReport.Columns[12].ReadOnly = true;
            grid_salesReport.Columns[12].Width = 80;
            grid_salesReport.Columns[12].MinimumWidth = 80;
            grid_salesReport.Columns[12].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[12].DataPropertyName = "COGS";

            grid_salesReport.Columns[13].Name = "Shipment Return";
            grid_salesReport.Columns[13].ReadOnly = true;
            grid_salesReport.Columns[13].Width = 70;
            grid_salesReport.Columns[13].MinimumWidth = 70;
            grid_salesReport.Columns[13].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[13].DataPropertyName = "ShipmentReturn";

            grid_salesReport.Columns[14].Name = "Purchase Allowance";
            grid_salesReport.Columns[14].ReadOnly = true;
            grid_salesReport.Columns[14].Width = 90;
            grid_salesReport.Columns[14].MinimumWidth = 90;
            grid_salesReport.Columns[14].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[14].DataPropertyName = "PurchaseAllowance";

            grid_salesReport.Columns[15].Name = "Billback";
            grid_salesReport.Columns[15].ReadOnly = true;
            grid_salesReport.Columns[15].Width = 60;
            grid_salesReport.Columns[15].MinimumWidth = 60;
            grid_salesReport.Columns[15].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[15].DataPropertyName = "Billback";

            grid_salesReport.Columns[16].Name = "Profit";
            grid_salesReport.Columns[16].ReadOnly = true;
            grid_salesReport.Columns[16].Width = 50;
            grid_salesReport.Columns[16].MinimumWidth = 50;
            grid_salesReport.Columns[16].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[16].DataPropertyName = "Profit";

            grid_salesReport.Columns[17].Name = "Profit Ratio";
            grid_salesReport.Columns[17].ReadOnly = true;
            grid_salesReport.Columns[17].Width = 80;
            grid_salesReport.Columns[17].MinimumWidth = 80;
            grid_salesReport.Columns[17].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[17].DataPropertyName = "ProfitRatio";
            
            //grid font size custom
            grid_salesReport.RowTemplate.Height = 20;
            grid_salesReport.ColumnHeadersHeight = 50;

            foreach (DataGridViewColumn c in grid_salesReport.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_salesReport.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            grid_salesReport.DataSource = null;
            connSalesOrder.sp_SalesbyRepReport(grid_salesReport, FromDate, ToDate);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;

            Reports.Rpt_SalesbyRepReport salesReport = new Reports.Rpt_SalesbyRepReport(FromDate, ToDate);
            salesReport.Show();

            grid_salesReport.DataSource = null;
        }
        
        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date <= Convert.ToDateTime("01/06/2020"))
            {
                dateTimePickerFrom.Value = Convert.ToDateTime("01/06/2020");
            }
        }

        private void grid_salesReport_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grid_salesReport.Rows[grid_salesReport.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGray;
        }
    }
}
