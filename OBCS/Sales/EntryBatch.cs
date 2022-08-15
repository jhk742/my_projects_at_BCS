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
    public partial class EntryBatch : Form
    {
        public EntryBatch()
        {
            InitializeComponent();

            grid_header_Init();
            grid_detail_Init();

            DateTime Date = dateTimePicker1.Value;
            connSalesOrder.sp_ENTRYBATCH_SELECT(grid_header, Date.ToShortDateString());

        }

        private void grid_header_Init()
        {
            grid_header.AutoGenerateColumns = false;
            grid_header.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_header.ColumnCount = 3;

            grid_header.Columns[0].Name = "";
            grid_header.Columns[0].Visible = false ;
            grid_header.Columns[0].Width = 70;
            grid_header.Columns[0].MinimumWidth = 70;
            grid_header.Columns[0].DataPropertyName = "";

            grid_header.Columns[1].Name = "Entry Batch";
            grid_header.Columns[1].ReadOnly = true;
            grid_header.Columns[1].Width = 70;
            grid_header.Columns[1].MinimumWidth = 70;
            grid_header.Columns[1].DataPropertyName = "REF_0";

            grid_header.Columns[2].Name = "Create User";
            grid_header.Columns[2].ReadOnly = true;
            grid_header.Columns[2].Visible = false;
            grid_header.Columns[2].Width = 70;
            grid_header.Columns[2].MinimumWidth = 70;
            grid_header.Columns[2].DataPropertyName = "CREUSR_0";
            
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
            grid_detail.ColumnCount = 8;

            grid_detail.Columns[0].Name = "";
            grid_detail.Columns[0].Visible = false;
            grid_detail.Columns[0].Width = 70;
            grid_detail.Columns[0].DataPropertyName = "";

            grid_detail.Columns[1].Name = "Number";
            grid_detail.Columns[1].ReadOnly = true;
            grid_detail.Columns[1].Width = 70;
            grid_detail.Columns[1].DataPropertyName = "NUM_0";

            grid_detail.Columns[2].Name = "Site";
            grid_detail.Columns[2].ReadOnly = true;
            grid_detail.Columns[2].Width = 70;
            grid_detail.Columns[2].DataPropertyName = "FCY_0";

            grid_detail.Columns[3].Name = "Bank";
            grid_detail.Columns[3].ReadOnly = true;
            grid_detail.Columns[3].Width = 70;
            grid_detail.Columns[3].DataPropertyName = "BAN_0";

            grid_detail.Columns[4].Name = "Payment method";
            grid_detail.Columns[4].ReadOnly = false;
            grid_detail.Columns[4].Width = 50;
            grid_detail.Columns[4].DataPropertyName = "PAM_0";

            grid_detail.Columns[5].Name = "BP";
            grid_detail.Columns[5].ReadOnly = true;
            grid_detail.Columns[5].Width = 70;
            grid_detail.Columns[5].DataPropertyName = "BPR_0";

            grid_detail.Columns[6].Name = "Amount";
            grid_detail.Columns[6].ReadOnly = true;
            grid_detail.Columns[6].Width = 70;
            grid_detail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].DataPropertyName = "AMTCUR_0";

            grid_detail.Columns[7].Name = "Slip Number";
            grid_detail.Columns[7].ReadOnly = true;
            grid_detail.Columns[7].Width = 70;
            grid_detail.Columns[7].DataPropertyName = "FRMNUM_0";


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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime Date = dateTimePicker1.Value;
            connSalesOrder.sp_ENTRYBATCH_SELECT(grid_header, Date.ToShortDateString());
        }

        private void grid_header_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_entryBatch.Text = "";
            String EntryBatch = grid_header.Rows[e.RowIndex].Cells["Entry Batch"].Value.ToString().Trim();
            txt_entryBatch.Text = EntryBatch;
            DateTime Date = dateTimePicker1.Value;
            connSalesOrder.sp_ENTRYBATCH_SELECT_DETAIL(grid_detail, Date.ToShortDateString(), EntryBatch);

            Decimal Amount = 0;
            Decimal AmountTotal = 0;
            Decimal CashAmountTotal = 0;
            Decimal CheckAmountTotal = 0;
            Decimal ACHAmountTotal = 0;

            for (int i = 0; i < grid_detail.RowCount; i++)
            {
                Amount = Convert.ToDecimal(grid_detail.Rows[i].Cells["Amount"].Value.ToString());
                AmountTotal = AmountTotal + Amount;

                if(grid_detail.Rows[i].Cells["Payment method"].Value.ToString().Trim() == "CSH")
                {
                    CashAmountTotal = CashAmountTotal + Amount;
                }
                else if(grid_detail.Rows[i].Cells["Payment method"].Value.ToString().Trim() == "CHQ")
                {
                    CheckAmountTotal = CheckAmountTotal + Amount;
                }
                else if (grid_detail.Rows[i].Cells["Payment method"].Value.ToString().Trim() == "ACH")
                {
                    ACHAmountTotal = ACHAmountTotal + Amount;
                }
            }

            txt_total.Text = AmountTotal.ToString("N2");
            txt_cashTotal.Text = CashAmountTotal.ToString("N2");
            txt_checkTotal.Text = CheckAmountTotal.ToString("N2");
            txt_achTotal.Text = ACHAmountTotal.ToString("N2");

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime Date = dateTimePicker1.Value;
            connSalesOrder.sp_ENTRYBATCH_SELECT(grid_header, Date.ToShortDateString());
        }
    }
}
