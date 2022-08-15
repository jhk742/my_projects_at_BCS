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
    public partial class ChartOfAccount2 : Form
    {
        public ChartOfAccount2()
        {
            InitializeComponent();

            grid_header_Init();
            grid_detail_Init();

            connSalesOrder.sp_ACCOUNT_CHARTOFACCOUNT(grid_header);

        }

        private void grid_header_Init()
        {
            grid_header.AutoGenerateColumns = false;
            grid_header.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_header.ColumnCount = 2;

            grid_header.Columns[0].Name = "Account";
            grid_header.Columns[0].ReadOnly = true;
            grid_header.Columns[0].Width = 50;
            grid_header.Columns[0].MinimumWidth = 50;
            grid_header.Columns[0].DataPropertyName = "ACC_0";

            grid_header.Columns[1].Name = "Description";
            grid_header.Columns[1].ReadOnly = true;
            grid_header.Columns[1].Width = 270;
            grid_header.Columns[1].MinimumWidth = 270;
            grid_header.Columns[1].DataPropertyName = "DES_0";
            

            //grid font size custom
            grid_header.RowTemplate.Height = 20;
            grid_header.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_header.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_header.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_detail_Init()
        {
            grid_detail.AutoGenerateColumns = false;
            grid_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_detail.ColumnCount = 9;

            grid_detail.Columns[0].Name = "Date";
            grid_detail.Columns[0].ReadOnly = true;
            grid_detail.Columns[0].Width = 75;
            grid_detail.Columns[0].MinimumWidth = 75;
            grid_detail.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_detail.Columns[0].DataPropertyName = "Date";

            grid_detail.Columns[1].Name = "Document number";
            grid_detail.Columns[1].ReadOnly = true;
            grid_detail.Columns[1].Width = 90;
            grid_detail.Columns[1].MinimumWidth = 90;
            grid_detail.Columns[1].DataPropertyName = "DocumentNumber";

            grid_detail.Columns[2].Name = "Site";
            grid_detail.Columns[2].ReadOnly = true;
            grid_detail.Columns[2].Width = 40;
            grid_detail.Columns[2].MinimumWidth = 40;
            grid_detail.Columns[2].DataPropertyName = "Site";

            grid_detail.Columns[3].Name = "Description";
            grid_detail.Columns[3].ReadOnly = true;
            grid_detail.Columns[3].Width = 250;
            grid_detail.Columns[3].MinimumWidth = 250;
            grid_detail.Columns[3].DataPropertyName = "Description";

            grid_detail.Columns[4].Name = "Ledger posting";
            grid_detail.Columns[4].ReadOnly = false;
            grid_detail.Columns[4].Width = 80;
            grid_detail.Columns[4].MinimumWidth = 80;
            grid_detail.Columns[4].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[4].DataPropertyName = "LedgerPosting";

            grid_detail.Columns[5].Name = "Ledger debit";
            grid_detail.Columns[5].ReadOnly = false;
            grid_detail.Columns[5].Width = 80;
            grid_detail.Columns[5].MinimumWidth = 80;
            grid_detail.Columns[5].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].DataPropertyName = "LedgerDebit";

            grid_detail.Columns[6].Name = "Ledger credit";
            grid_detail.Columns[6].ReadOnly = true;
            grid_detail.Columns[6].Width = 80;
            grid_detail.Columns[6].MinimumWidth = 80;
            grid_detail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].DataPropertyName = "LedgerCredit";
        
            grid_detail.Columns[7].Name = "Offset";
            grid_detail.Columns[7].ReadOnly = true;
            grid_detail.Columns[7].Width = 80;
            grid_detail.Columns[7].MinimumWidth = 80;
            grid_detail.Columns[7].DataPropertyName = "Offset";

            grid_detail.Columns[8].Name = "Refernce";
            grid_detail.Columns[8].ReadOnly = true;
            grid_detail.Columns[8].Width = 70;
            grid_detail.Columns[8].MinimumWidth = 70;
            grid_detail.Columns[8].DataPropertyName = "Refernce";



            //grid font size custom
            grid_detail.RowTemplate.Height = 20;
            grid_detail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_detail.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_detail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_header_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String Account = grid_header.Rows[e.RowIndex].Cells["Account"].Value.ToString().Trim();
            DateTime FromDate = dateTimePicker1.Value;
            DateTime ToDate = dateTimePicker2.Value;
            String FromDateString = FromDate.ToShortDateString(); 
            String ToDateString = ToDate.ToShortDateString(); 

            connSalesOrder.sp_ACCOUNT_CHARTOFACCOUNT_DETAIL2(grid_detail, Account, FromDateString, ToDateString);
        }

        private void grid_detail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            txt_totalLedgerPosting.Text = "";
            txt_totalLedgerDebit.Text = "";
            txt_totalLedgerCredit.Text = "";
            try
            {
                Decimal TotalLedgerPosting = 0;
                Decimal TotalLedgerDebit = 0;
                Decimal TotalLedgerCredit = 0;
                for (int i = 0; i < grid_detail.Rows.Count; i++)
                {
                    Decimal LedgerDebit = Convert.ToDecimal(grid_detail.Rows[i].Cells["Ledger debit"].Value);
                    TotalLedgerDebit = TotalLedgerDebit + LedgerDebit;

                    Decimal LedgerCredit = Convert.ToDecimal(grid_detail.Rows[i].Cells["Ledger credit"].Value);
                    TotalLedgerCredit = TotalLedgerCredit + LedgerCredit;

                    //TotalOpenARCount = TotalOpenARCount + 1;
                }

                txt_totalLedgerPosting.Text = (TotalLedgerDebit - TotalLedgerCredit).ToString("N2");
                txt_totalLedgerDebit.Text = TotalLedgerDebit.ToString("N2");
                txt_totalLedgerCredit.Text = TotalLedgerCredit.ToString("N2");
            }
            catch
            {

            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

        }
    }
}
