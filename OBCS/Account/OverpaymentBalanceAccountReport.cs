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
    public partial class OverpaymentBalanceAccountReport : Form
    {
        public OverpaymentBalanceAccountReport()
        {
            InitializeComponent();

            grid_OVerpaymentBalanceAccount_Init();
        }

        private void grid_OVerpaymentBalanceAccount_Init()
        {
            grid_OverpaymentBalanceAccount.AutoGenerateColumns = false;
            grid_OverpaymentBalanceAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_OverpaymentBalanceAccount.ColumnCount = 8;

            grid_OverpaymentBalanceAccount.Columns[0].Name = "Customer ID";
            grid_OverpaymentBalanceAccount.Columns[0].ReadOnly = true;
            grid_OverpaymentBalanceAccount.Columns[0].Width = 120;
            grid_OverpaymentBalanceAccount.Columns[0].MinimumWidth = 120;
            grid_OverpaymentBalanceAccount.Columns[0].DataPropertyName = "CustomerID";

            grid_OverpaymentBalanceAccount.Columns[1].Name = "Customer Name";
            grid_OverpaymentBalanceAccount.Columns[1].ReadOnly = true;
            grid_OverpaymentBalanceAccount.Columns[1].Width = 300;
            grid_OverpaymentBalanceAccount.Columns[1].MinimumWidth = 300;
            grid_OverpaymentBalanceAccount.Columns[1].DataPropertyName = "CustomerName";

            grid_OverpaymentBalanceAccount.Columns[2].Name = "Beginning Amount Debit";
            grid_OverpaymentBalanceAccount.Columns[2].ReadOnly = true;
            grid_OverpaymentBalanceAccount.Columns[2].Width = 80;
            grid_OverpaymentBalanceAccount.Columns[2].MinimumWidth = 80;
            grid_OverpaymentBalanceAccount.Columns[2].DefaultCellStyle.Format = "N2";
            grid_OverpaymentBalanceAccount.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OverpaymentBalanceAccount.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OverpaymentBalanceAccount.Columns[2].DataPropertyName = "";

            grid_OverpaymentBalanceAccount.Columns[3].Name = "Beginning Amount Credit";
            grid_OverpaymentBalanceAccount.Columns[3].ReadOnly = true;
            grid_OverpaymentBalanceAccount.Columns[3].Width = 80;
            grid_OverpaymentBalanceAccount.Columns[3].MinimumWidth = 80;
            grid_OverpaymentBalanceAccount.Columns[3].DefaultCellStyle.Format = "N2";
            grid_OverpaymentBalanceAccount.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OverpaymentBalanceAccount.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OverpaymentBalanceAccount.Columns[3].DataPropertyName = "BeginningAmount";

            grid_OverpaymentBalanceAccount.Columns[4].Name = "Current Period Debit";
            grid_OverpaymentBalanceAccount.Columns[4].ReadOnly = true;
            grid_OverpaymentBalanceAccount.Columns[4].Width = 80;
            grid_OverpaymentBalanceAccount.Columns[4].MinimumWidth = 80;
            grid_OverpaymentBalanceAccount.Columns[4].DefaultCellStyle.Format = "N2";
            grid_OverpaymentBalanceAccount.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OverpaymentBalanceAccount.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OverpaymentBalanceAccount.Columns[4].DataPropertyName = "Debit";

            grid_OverpaymentBalanceAccount.Columns[5].Name = "Current Period Credit";
            grid_OverpaymentBalanceAccount.Columns[5].ReadOnly = true;
            grid_OverpaymentBalanceAccount.Columns[5].Width = 80;
            grid_OverpaymentBalanceAccount.Columns[5].MinimumWidth = 80;
            grid_OverpaymentBalanceAccount.Columns[5].DefaultCellStyle.Format = "N2";
            grid_OverpaymentBalanceAccount.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OverpaymentBalanceAccount.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OverpaymentBalanceAccount.Columns[5].DataPropertyName = "Credit";

            grid_OverpaymentBalanceAccount.Columns[6].Name = "Ending Amount Debit";
            grid_OverpaymentBalanceAccount.Columns[6].ReadOnly = true;
            grid_OverpaymentBalanceAccount.Columns[6].Width = 80;
            grid_OverpaymentBalanceAccount.Columns[6].MinimumWidth = 80;
            grid_OverpaymentBalanceAccount.Columns[6].DefaultCellStyle.Format = "N2";
            grid_OverpaymentBalanceAccount.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OverpaymentBalanceAccount.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OverpaymentBalanceAccount.Columns[6].DataPropertyName = "";

            grid_OverpaymentBalanceAccount.Columns[7].Name = "Ending Amount Credit";
            grid_OverpaymentBalanceAccount.Columns[7].ReadOnly = true;
            grid_OverpaymentBalanceAccount.Columns[7].Width = 80;
            grid_OverpaymentBalanceAccount.Columns[7].MinimumWidth = 80;
            grid_OverpaymentBalanceAccount.Columns[7].DefaultCellStyle.Format = "N2";
            grid_OverpaymentBalanceAccount.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OverpaymentBalanceAccount.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OverpaymentBalanceAccount.Columns[7].DataPropertyName = "EndingAmount";


            //grid font size custom
            grid_OverpaymentBalanceAccount.RowTemplate.Height = 20;
            grid_OverpaymentBalanceAccount.ColumnHeadersHeight = 100;

            foreach (DataGridViewColumn c in grid_OverpaymentBalanceAccount.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_OverpaymentBalanceAccount.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFromDate.Value;
            DateTime ToDate = dateTimePickerToDate.Value;

            connSalesOrder.sp_OverpaymentBalanceAccountReport(grid_OverpaymentBalanceAccount, FromDate, ToDate);

            try
            {
                Decimal TotalBegginingAmount = 0;
                Decimal TotalDebit = 0;
                Decimal TotalCredit = 0;
                Decimal TotalEndingAmount = 0;
                Decimal TotalCustomerCount = 0;

                for (int i = 0; i < grid_OverpaymentBalanceAccount.Rows.Count; i++)
                {
                    Decimal BegginingBalance = Convert.ToDecimal(grid_OverpaymentBalanceAccount.Rows[i].Cells[3].Value);
                    TotalBegginingAmount = TotalBegginingAmount + BegginingBalance;

                    Decimal Debit = Convert.ToDecimal(grid_OverpaymentBalanceAccount.Rows[i].Cells[4].Value);
                    TotalDebit = TotalDebit + Debit;

                    Decimal Credit = Convert.ToDecimal(grid_OverpaymentBalanceAccount.Rows[i].Cells[5].Value);
                    TotalCredit = TotalCredit + Credit;

                    Decimal EndingBalance = Convert.ToDecimal(grid_OverpaymentBalanceAccount.Rows[i].Cells[7].Value);
                    TotalEndingAmount = TotalEndingAmount + EndingBalance;

                    TotalCustomerCount = TotalCustomerCount + 1;
                }

                txt_beginningAmountDebit.Text = "0";
                txt_beginningAmountCredit.Text = TotalBegginingAmount.ToString("N2");
                txt_debit.Text = TotalDebit.ToString("N2");
                txt_credit.Text = TotalCredit.ToString("N2");
                txt_endingAmountDebit.Text = "0";
                txt_endingAmountCredit.Text = TotalEndingAmount.ToString("N2");
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

            Reports.Rpt_OverpaymentBalanceAccountReport rpt_OverpaymentBalanceAccount = new Reports.Rpt_OverpaymentBalanceAccountReport(FromDate, ToDate);
            rpt_OverpaymentBalanceAccount.Show();

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
