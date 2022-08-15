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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
            grid_salesReport_Init();
            dateTimePickerFrom.Value = DateTime.Today.AddMonths(-1);

        }

        private void grid_salesReport_Init()
        {
            grid_salesReport.AutoGenerateColumns = false;
            grid_salesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_salesReport.ColumnCount = 15;

            grid_salesReport.Columns[0].Name = "Branch";
            grid_salesReport.Columns[0].ReadOnly = true;
            grid_salesReport.Columns[0].Width = 50;
            grid_salesReport.Columns[0].MinimumWidth = 50;
            grid_salesReport.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[0].DataPropertyName = "Branch";

            grid_salesReport.Columns[1].Name = "REP";
            grid_salesReport.Columns[1].ReadOnly = true;
            grid_salesReport.Columns[1].Width = 50;
            grid_salesReport.Columns[1].MinimumWidth = 50;
            grid_salesReport.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[1].DataPropertyName = "REP_0";

            grid_salesReport.Columns[2].Name = "REP Name";
            grid_salesReport.Columns[2].ReadOnly = true;
            grid_salesReport.Columns[2].Width = 120;
            grid_salesReport.Columns[2].MinimumWidth = 120;
            grid_salesReport.Columns[2].DataPropertyName = "REPName";

            grid_salesReport.Columns[3].Name = "Total Sales";
            grid_salesReport.Columns[3].ReadOnly = true;
            grid_salesReport.Columns[3].Width = 100;
            grid_salesReport.Columns[3].MinimumWidth = 100;
            grid_salesReport.Columns[3].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[3].DataPropertyName = "TotalSales";

            grid_salesReport.Columns[4].Name = "Promo";
            grid_salesReport.Columns[4].ReadOnly = true;
            grid_salesReport.Columns[4].Width = 90;
            grid_salesReport.Columns[4].MinimumWidth = 90;
            grid_salesReport.Columns[4].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[4].DataPropertyName = "PromoAmount";

            grid_salesReport.Columns[5].Name = "Sales";
            grid_salesReport.Columns[5].ReadOnly = true;
            grid_salesReport.Columns[5].Width = 100;
            grid_salesReport.Columns[5].MinimumWidth = 100;
            grid_salesReport.Columns[5].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[5].DataPropertyName = "Sales";

            grid_salesReport.Columns[6].Name = "Credit1";
            grid_salesReport.Columns[6].ReadOnly = true;
            grid_salesReport.Columns[6].Width = 70;
            grid_salesReport.Columns[6].MinimumWidth = 70;
            grid_salesReport.Columns[6].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[6].DataPropertyName = "CreditMemo1";

            grid_salesReport.Columns[7].Name = "Credit2";
            grid_salesReport.Columns[7].ReadOnly = true;
            grid_salesReport.Columns[7].Width = 70;
            grid_salesReport.Columns[7].MinimumWidth = 70;
            grid_salesReport.Columns[7].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[7].DataPropertyName = "CreditMemo2";

            grid_salesReport.Columns[8].Name = "Credit3";
            grid_salesReport.Columns[8].ReadOnly = true;
            grid_salesReport.Columns[8].Width = 70;
            grid_salesReport.Columns[8].MinimumWidth = 70;
            grid_salesReport.Columns[8].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[8].DataPropertyName = "CreditMemo3";

            grid_salesReport.Columns[9].Name = "Credit Ratio";
            grid_salesReport.Columns[9].ReadOnly = true;
            grid_salesReport.Columns[9].Width = 50;
            grid_salesReport.Columns[9].MinimumWidth = 50;
            grid_salesReport.Columns[9].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[9].DataPropertyName = "CreditRatio";

            grid_salesReport.Columns[10].Name = "Return";
            grid_salesReport.Columns[10].ReadOnly = true;
            grid_salesReport.Columns[10].Width = 80;
            grid_salesReport.Columns[10].MinimumWidth = 80;
            grid_salesReport.Columns[10].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[10].DataPropertyName = "ReturnAmount";

            grid_salesReport.Columns[11].Name = "Net Sales";
            grid_salesReport.Columns[11].ReadOnly = true;
            grid_salesReport.Columns[11].Width = 100;
            grid_salesReport.Columns[11].MinimumWidth = 100;
            grid_salesReport.Columns[11].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[11].DataPropertyName = "NetSales";

            grid_salesReport.Columns[12].Name = "COGS";
            grid_salesReport.Columns[12].ReadOnly = true;
            grid_salesReport.Columns[12].Width = 90;
            grid_salesReport.Columns[12].MinimumWidth = 90;
            grid_salesReport.Columns[12].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[12].DataPropertyName = "COGS";

            grid_salesReport.Columns[13].Name = "Profit";
            grid_salesReport.Columns[13].ReadOnly = true;
            grid_salesReport.Columns[13].Width = 100;
            grid_salesReport.Columns[13].MinimumWidth = 100;
            grid_salesReport.Columns[13].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[13].DataPropertyName = "Profit";

            grid_salesReport.Columns[14].Name = "Profit Ratio";
            grid_salesReport.Columns[14].ReadOnly = true;
            grid_salesReport.Columns[14].Width = 50;
            grid_salesReport.Columns[14].MinimumWidth = 50;
            grid_salesReport.Columns[14].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[14].DataPropertyName = "ProfitRatio";

            //grid font size custom
            grid_salesReport.RowTemplate.Height = 20;
            grid_salesReport.ColumnHeadersHeight = 30;

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
            //MessageBox.Show(date.ToString());
            connSalesOrder.sp_SalesReport(grid_salesReport, FromDate, ToDate);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;

            Reports.Rpt_SalesReport salesReport = new Reports.Rpt_SalesReport(FromDate, ToDate);
            //salesReport.MdiParent = this.MdiParent;
            salesReport.Show();



        }
    }
}
