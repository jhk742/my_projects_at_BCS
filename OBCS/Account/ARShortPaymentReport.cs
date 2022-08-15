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
    public partial class ARShortPaymentReport : Form
    {
        public ARShortPaymentReport()
        {
            InitializeComponent();

            grid_ARShortPayment_Init();

        }

        private void grid_ARShortPayment_Init()
        {
            grid_ARShortPayment.AutoGenerateColumns = false;
            grid_ARShortPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_ARShortPayment.ColumnCount = 11;

            grid_ARShortPayment.Columns[0].Name = "Date";
            grid_ARShortPayment.Columns[0].ReadOnly = true;
            grid_ARShortPayment.Columns[0].Width = 120;
            grid_ARShortPayment.Columns[0].MinimumWidth = 120;
            grid_ARShortPayment.Columns[0].DataPropertyName = "ACCDAT_0";

            grid_ARShortPayment.Columns[1].Name = "Document Number";
            grid_ARShortPayment.Columns[1].ReadOnly = true;
            grid_ARShortPayment.Columns[1].Width = 120;
            grid_ARShortPayment.Columns[1].MinimumWidth = 120;
            grid_ARShortPayment.Columns[1].DataPropertyName = "NUM_0";

            grid_ARShortPayment.Columns[2].Name = "Account Number";
            grid_ARShortPayment.Columns[2].ReadOnly = true;
            grid_ARShortPayment.Columns[2].Width = 120;
            grid_ARShortPayment.Columns[2].MinimumWidth = 120;
            grid_ARShortPayment.Columns[2].DataPropertyName = "ACC_0";

            grid_ARShortPayment.Columns[3].Name = "Account Description";
            grid_ARShortPayment.Columns[3].ReadOnly = true;
            grid_ARShortPayment.Columns[3].Width = 120;
            grid_ARShortPayment.Columns[3].MinimumWidth = 120;
            grid_ARShortPayment.Columns[3].DataPropertyName = "AccountDescripton";

            grid_ARShortPayment.Columns[4].Name = "Site";
            grid_ARShortPayment.Columns[4].ReadOnly = true;
            grid_ARShortPayment.Columns[4].Width = 120;
            grid_ARShortPayment.Columns[4].MinimumWidth = 120;
            grid_ARShortPayment.Columns[4].DataPropertyName = "FCYLIN_0";

            grid_ARShortPayment.Columns[5].Name = "Type";
            grid_ARShortPayment.Columns[5].ReadOnly = true;
            grid_ARShortPayment.Columns[5].Width = 120;
            grid_ARShortPayment.Columns[5].MinimumWidth = 120;
            grid_ARShortPayment.Columns[5].DataPropertyName = "TYP_0";

            grid_ARShortPayment.Columns[6].Name = "Description";
            grid_ARShortPayment.Columns[6].ReadOnly = true;
            grid_ARShortPayment.Columns[6].Width = 120;
            grid_ARShortPayment.Columns[6].MinimumWidth = 120;
            grid_ARShortPayment.Columns[6].DataPropertyName = "DES_0";

            grid_ARShortPayment.Columns[7].Name = "Ledger Posting";
            grid_ARShortPayment.Columns[7].ReadOnly = true;
            grid_ARShortPayment.Columns[7].Width = 80;
            grid_ARShortPayment.Columns[7].MinimumWidth = 80;
            grid_ARShortPayment.Columns[7].DefaultCellStyle.Format = "N2";
            grid_ARShortPayment.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARShortPayment.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARShortPayment.Columns[7].DataPropertyName = "LedgerPosting";

            grid_ARShortPayment.Columns[8].Name = "Ledger Debit";
            grid_ARShortPayment.Columns[8].ReadOnly = true;
            grid_ARShortPayment.Columns[8].Width = 80;
            grid_ARShortPayment.Columns[8].MinimumWidth = 80;
            grid_ARShortPayment.Columns[8].DefaultCellStyle.Format = "N2";
            grid_ARShortPayment.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARShortPayment.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARShortPayment.Columns[8].DataPropertyName = "LedgerDebit";

            grid_ARShortPayment.Columns[9].Name = "Ledger Credit";
            grid_ARShortPayment.Columns[9].ReadOnly = true;
            grid_ARShortPayment.Columns[9].Width = 80;
            grid_ARShortPayment.Columns[9].MinimumWidth = 80;
            grid_ARShortPayment.Columns[9].DefaultCellStyle.Format = "N2";
            grid_ARShortPayment.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARShortPayment.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARShortPayment.Columns[9].DataPropertyName = "LedgerCredit";

            grid_ARShortPayment.Columns[10].Name = "Offset";
            grid_ARShortPayment.Columns[10].ReadOnly = true;
            grid_ARShortPayment.Columns[10].Width = 120;
            grid_ARShortPayment.Columns[10].MinimumWidth = 120;
            grid_ARShortPayment.Columns[10].DataPropertyName = "OFFACC_0";

            //grid font size custom
            grid_ARShortPayment.RowTemplate.Height = 20;
            grid_ARShortPayment.ColumnHeadersHeight = 100;

            foreach (DataGridViewColumn c in grid_ARShortPayment.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_ARShortPayment.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFromDate.Value;
            DateTime ToDate = dateTimePickerToDate.Value;

            connSalesOrder.sp_ARShortPaymentReport(grid_ARShortPayment, FromDate, ToDate);

            try
            {
                Decimal TotalLedgerPosting = 0;
                Decimal TotalLedgerDebit = 0;
                Decimal TotalLedgerCredit = 0;
                Decimal TotalCount = 0;

                for (int i = 0; i < grid_ARShortPayment.Rows.Count; i++)
                {
                    Decimal LedgerPosting = Convert.ToDecimal(grid_ARShortPayment.Rows[i].Cells[7].Value);
                    TotalLedgerPosting = TotalLedgerPosting + LedgerPosting;

                    Decimal LedgerDebit = Convert.ToDecimal(grid_ARShortPayment.Rows[i].Cells[8].Value);
                    TotalLedgerDebit = TotalLedgerDebit + LedgerDebit;

                    Decimal LedgerCredit = Convert.ToDecimal(grid_ARShortPayment.Rows[i].Cells[9].Value);
                    TotalLedgerCredit = TotalLedgerCredit + LedgerCredit;


                    TotalCount = TotalCount + 1;
                }

                txt_ledgerPosting.Text = TotalLedgerPosting.ToString("N2");
                txt_ledgerDebit.Text = TotalLedgerDebit.ToString("N2");
                txt_ledgerCredit.Text = TotalLedgerCredit.ToString("N2");
                
                txt_count.Text = TotalCount.ToString();
            }
            catch
            {

            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFromDate.Value;
            DateTime ToDate = dateTimePickerToDate.Value;

            Reports.Rpt_ARShortPaymentReport rpt_ARShortPaymentReport = new Reports.Rpt_ARShortPaymentReport(FromDate, ToDate);
            rpt_ARShortPaymentReport.Show();
        }
    }
}
