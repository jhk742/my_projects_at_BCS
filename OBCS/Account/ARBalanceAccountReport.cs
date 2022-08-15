using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Account
{
    public partial class ARBalanceAccountReport : Form
    {
        public ARBalanceAccountReport()
        {
            InitializeComponent();

            grid_all_Init();
        }

        private void grid_all_Init()
        {
            grid_ARBalanceAccount.AutoGenerateColumns = false;
            grid_ARBalanceAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_ARBalanceAccount.ColumnCount = 8;

            grid_ARBalanceAccount.Columns[0].Name = "Customer ID";
            grid_ARBalanceAccount.Columns[0].ReadOnly = true;
            grid_ARBalanceAccount.Columns[0].Width = 120;
            grid_ARBalanceAccount.Columns[0].MinimumWidth = 120;
            grid_ARBalanceAccount.Columns[0].DataPropertyName = "CustomerID";

            grid_ARBalanceAccount.Columns[1].Name = "Customer Name";
            grid_ARBalanceAccount.Columns[1].ReadOnly = true;
            grid_ARBalanceAccount.Columns[1].Width = 300;
            grid_ARBalanceAccount.Columns[1].MinimumWidth = 300;
            grid_ARBalanceAccount.Columns[1].DataPropertyName = "CustomerName";

            grid_ARBalanceAccount.Columns[2].Name = "Beginning Balance Debit";
            grid_ARBalanceAccount.Columns[2].ReadOnly = true;
            grid_ARBalanceAccount.Columns[2].Width = 80;
            grid_ARBalanceAccount.Columns[2].MinimumWidth = 80;
            grid_ARBalanceAccount.Columns[2].DefaultCellStyle.Format = "N2";
            grid_ARBalanceAccount.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARBalanceAccount.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARBalanceAccount.Columns[2].DataPropertyName = "BeginningBalance";

            grid_ARBalanceAccount.Columns[3].Name = "Beginning Balance Credit";
            grid_ARBalanceAccount.Columns[3].ReadOnly = true;
            grid_ARBalanceAccount.Columns[3].Width = 80;
            grid_ARBalanceAccount.Columns[3].MinimumWidth = 80;
            grid_ARBalanceAccount.Columns[3].DefaultCellStyle.Format = "N2";
            grid_ARBalanceAccount.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARBalanceAccount.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARBalanceAccount.Columns[3].DataPropertyName = "";

            grid_ARBalanceAccount.Columns[4].Name = "Current Period Debit";
            grid_ARBalanceAccount.Columns[4].ReadOnly = true;
            grid_ARBalanceAccount.Columns[4].Width = 80;
            grid_ARBalanceAccount.Columns[4].MinimumWidth = 80;
            grid_ARBalanceAccount.Columns[4].DefaultCellStyle.Format = "N2";
            grid_ARBalanceAccount.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARBalanceAccount.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARBalanceAccount.Columns[4].DataPropertyName = "Debit";

            grid_ARBalanceAccount.Columns[5].Name = "Current Period Credit";
            grid_ARBalanceAccount.Columns[5].ReadOnly = true;
            grid_ARBalanceAccount.Columns[5].Width = 80;
            grid_ARBalanceAccount.Columns[5].MinimumWidth = 80;
            grid_ARBalanceAccount.Columns[5].DefaultCellStyle.Format = "N2";
            grid_ARBalanceAccount.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARBalanceAccount.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARBalanceAccount.Columns[5].DataPropertyName = "Credit";

            grid_ARBalanceAccount.Columns[6].Name = "Ending Balance Debit";
            grid_ARBalanceAccount.Columns[6].ReadOnly = true;
            grid_ARBalanceAccount.Columns[6].Width = 80;
            grid_ARBalanceAccount.Columns[6].MinimumWidth = 80;
            grid_ARBalanceAccount.Columns[6].DefaultCellStyle.Format = "N2";
            grid_ARBalanceAccount.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARBalanceAccount.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARBalanceAccount.Columns[6].DataPropertyName = "EndingBalance";

            grid_ARBalanceAccount.Columns[7].Name = "Ending Balance Credit";
            grid_ARBalanceAccount.Columns[7].ReadOnly = true;
            grid_ARBalanceAccount.Columns[7].Width = 80;
            grid_ARBalanceAccount.Columns[7].MinimumWidth = 80;
            grid_ARBalanceAccount.Columns[7].DefaultCellStyle.Format = "N2";
            grid_ARBalanceAccount.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARBalanceAccount.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARBalanceAccount.Columns[7].DataPropertyName = "";


            //grid font size custom
            grid_ARBalanceAccount.RowTemplate.Height = 20;
            grid_ARBalanceAccount.ColumnHeadersHeight = 100;

            foreach (DataGridViewColumn c in grid_ARBalanceAccount.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_ARBalanceAccount.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFromDate.Value;
            DateTime ToDate = dateTimePickerToDate.Value;

            connSalesOrder.sp_ARBalanceAccountReport(grid_ARBalanceAccount, FromDate, ToDate);

            try
            {
                Decimal TotalBegginingBalance = 0;
                Decimal TotalDebit = 0;
                Decimal TotalCredit = 0;
                Decimal TotalEndingBalance = 0;
                Decimal TotalCustomerCount = 0;

                for (int i = 0; i < grid_ARBalanceAccount.Rows.Count; i++)
                {
                    Decimal BegginingBalance = Convert.ToDecimal(grid_ARBalanceAccount.Rows[i].Cells[2].Value);
                    TotalBegginingBalance = TotalBegginingBalance + BegginingBalance;

                    Decimal Debit = Convert.ToDecimal(grid_ARBalanceAccount.Rows[i].Cells[4].Value);
                    TotalDebit = TotalDebit + Debit;

                    Decimal Credit = Convert.ToDecimal(grid_ARBalanceAccount.Rows[i].Cells[5].Value);
                    TotalCredit = TotalCredit + Credit;

                    Decimal EndingBalance = Convert.ToDecimal(grid_ARBalanceAccount.Rows[i].Cells[6].Value);
                    TotalEndingBalance = TotalEndingBalance + EndingBalance;

                    TotalCustomerCount = TotalCustomerCount + 1;
                }

                txt_beginningBalanceDebit.Text = TotalBegginingBalance.ToString("N2");
                txt_beginningBalanceCredit.Text = "0";
                txt_debit.Text = TotalDebit.ToString("N2");
                txt_credit.Text = TotalCredit.ToString("N2");
                txt_endingBalanceDebit.Text = TotalEndingBalance.ToString("N2");
                txt_endingBalanceCredit.Text = "0";
                txt_count.Text = TotalCustomerCount.ToString();
            }
            catch
            {

            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFromDate.Value;
            DateTime ToDate = dateTimePickerToDate.Value;

            Reports.Rpt_ARBalanceAccountReport rpt_ARBalanceAccountReport = new Reports.Rpt_ARBalanceAccountReport(FromDate, ToDate);
            rpt_ARBalanceAccountReport.Show();
        }

        private void dateTimePickerFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFromDate.Value.Date < Convert.ToDateTime("01/01/2021"))
            {
                dateTimePickerFromDate.Value = Convert.ToDateTime("01/01/2021");
            }
        }

        private void dateTimePickerToDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerToDate.Value.Date < Convert.ToDateTime("01/01/2021"))
            {
                dateTimePickerToDate.Value = Convert.ToDateTime("01/01/2021");
            }
        }
    }
}
