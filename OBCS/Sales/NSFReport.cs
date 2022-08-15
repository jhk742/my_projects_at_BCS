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
    public partial class NSFReport : Form
    {
        public NSFReport()
        {
            InitializeComponent();
            grid_NSFReport_Init(); 
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-14);

            for (int i = 0; i < grid_NSFReport.ColumnCount; i++)
            {
                grid_NSFReport.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            cbo_company.Items.Add("");
            connPO.cbo_CompanyName(cbo_company);
        }
        private void grid_NSFReport_Init()
        {
            grid_NSFReport.AutoGenerateColumns = false;
            grid_NSFReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_NSFReport.ColumnCount = 9;

            grid_NSFReport.Columns[0].Name = "Date";
            grid_NSFReport.Columns[0].ReadOnly = true;
            grid_NSFReport.Columns[0].Width = 75;
            grid_NSFReport.Columns[0].MinimumWidth = 75;
            grid_NSFReport.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_NSFReport.Columns[0].DataPropertyName = "Date";

            grid_NSFReport.Columns[1].Name = "Document Number";
            grid_NSFReport.Columns[1].ReadOnly = true;
            grid_NSFReport.Columns[1].Width = 90;
            grid_NSFReport.Columns[1].MinimumWidth = 90;
            grid_NSFReport.Columns[1].DataPropertyName = "DocumentNumber";

            grid_NSFReport.Columns[2].Name = "Site";
            grid_NSFReport.Columns[2].ReadOnly = true;
            grid_NSFReport.Columns[2].Width = 40;
            grid_NSFReport.Columns[2].MinimumWidth = 40;
            grid_NSFReport.Columns[2].DataPropertyName = "Site";

            grid_NSFReport.Columns[3].Name = "Description";
            grid_NSFReport.Columns[3].ReadOnly = true;
            grid_NSFReport.Columns[3].Width = 250;
            grid_NSFReport.Columns[3].MinimumWidth = 250;
            grid_NSFReport.Columns[3].DataPropertyName = "Description";

            grid_NSFReport.Columns[4].Name = "Ledger Posting";
            grid_NSFReport.Columns[4].ReadOnly = false;
            grid_NSFReport.Columns[4].Width = 80;
            grid_NSFReport.Columns[4].MinimumWidth = 80;
            grid_NSFReport.Columns[4].DefaultCellStyle.Format = "N2";
            grid_NSFReport.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_NSFReport.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_NSFReport.Columns[4].DataPropertyName = "LedgerPosting";

            grid_NSFReport.Columns[5].Name = "Ledger Debit";
            grid_NSFReport.Columns[5].ReadOnly = false;
            grid_NSFReport.Columns[5].Width = 80;
            grid_NSFReport.Columns[5].MinimumWidth = 80;
            grid_NSFReport.Columns[5].DefaultCellStyle.Format = "N2";
            grid_NSFReport.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_NSFReport.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_NSFReport.Columns[5].DataPropertyName = "LedgerDebit";

            grid_NSFReport.Columns[6].Name = "Ledger Credit";
            grid_NSFReport.Columns[6].ReadOnly = true;
            grid_NSFReport.Columns[6].Width = 80;
            grid_NSFReport.Columns[6].MinimumWidth = 80;
            grid_NSFReport.Columns[6].DefaultCellStyle.Format = "N2";
            grid_NSFReport.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_NSFReport.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_NSFReport.Columns[6].DataPropertyName = "LedgerCredit";

            grid_NSFReport.Columns[7].Name = "Offset";
            grid_NSFReport.Columns[7].ReadOnly = true;
            grid_NSFReport.Columns[7].Width = 80;
            grid_NSFReport.Columns[7].MinimumWidth = 80;
            grid_NSFReport.Columns[7].DataPropertyName = "Offset";

            grid_NSFReport.Columns[8].Name = "Refernce";
            grid_NSFReport.Columns[8].ReadOnly = true;
            grid_NSFReport.Columns[8].Width = 70;
            grid_NSFReport.Columns[8].MinimumWidth = 70;
            grid_NSFReport.Columns[8].DataPropertyName = "Refernce";



            //grid font size custom
            grid_NSFReport.RowTemplate.Height = 20;
            grid_NSFReport.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_NSFReport.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_NSFReport.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String CompanyName = cbo_company.Text.ToString();
            connSalesOrder.sp_NSFReport(grid_NSFReport, CompanyName, FromDate, ToDate);

            try
            {
                DataTable dataTable = (DataTable)grid_NSFReport.DataSource;

                decimal TotalDebit = 0, TotalCredit = 0, TotalPosting = 0;

                for (int i = 0; i < grid_NSFReport.RowCount; i++)
                {
                    TotalDebit += Convert.ToDecimal(grid_NSFReport.Rows[i].Cells["Ledger Debit"].Value == DBNull.Value ? "0" : grid_NSFReport.Rows[i].Cells["Ledger Debit"].Value);
                    TotalCredit += Convert.ToDecimal(grid_NSFReport.Rows[i].Cells["Ledger Credit"].Value == DBNull.Value ? "0" : grid_NSFReport.Rows[i].Cells["Ledger Credit"].Value);
                    TotalPosting += Convert.ToDecimal(grid_NSFReport.Rows[i].Cells["Ledger Posting"].Value == DBNull.Value ? "0" : grid_NSFReport.Rows[i].Cells["Ledger Posting"].Value);
                }

                DataRow drToAdd = dataTable.NewRow();
                drToAdd["Date"] = DBNull.Value;
                drToAdd["DocumentNumber"] = "TOTAL";
                drToAdd["Site"] = "";
                drToAdd["Type"] = "";
                drToAdd["Description"] = "";
                drToAdd["LedgerDebit"] = TotalDebit.ToString();
                drToAdd["LedgerCredit"] = TotalCredit.ToString();
                drToAdd["Offset"] = "";
                drToAdd["LedgerPosting"] = TotalPosting.ToString();
                //drToAdd["Refernce"] = "";

                dataTable.Rows.Add(drToAdd);

                dataTable.AcceptChanges();

                this.grid_NSFReport.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String CompanyName = cbo_company.Text.ToString();

            Reports.Rpt_NSFReport nSFReport = new Reports.Rpt_NSFReport(CompanyName,FromDate, ToDate);
            nSFReport.Show();

        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date < Convert.ToDateTime("01/01/2019"))
            {
                //MessageBox.Show("노옵~~!!!");
                dateTimePickerFrom.Value = Convert.ToDateTime("01/01/2019");
            }
        }

        private void grid_salesReport_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.grid_NSFReport.Rows)
            {
                if (row.Cells["Document Number"].Value.Equals("TOTAL"))
                {
                    for (int i = 0; i < grid_NSFReport.ColumnCount; i++)
                    {
                        row.Cells[i].Style.BackColor = Color.Gray;
                        row.Cells[i].Style.ForeColor = Color.White;
                    }
                }
            }
        }
    }
}
