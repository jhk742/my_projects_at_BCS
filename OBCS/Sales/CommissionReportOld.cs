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
    public partial class CommissionReportOld : Form
    {
        public CommissionReportOld()
        {
            InitializeComponent();
            connPO.cbox_BPSaleRep(cbx_SalesRep);
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-14);
            grid_Commission_Init();

        }
        private void grid_Commission_Init()
        {
            grid_Commission.AutoGenerateColumns = false;
            grid_Commission.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Commission.ColumnCount = 9;

            grid_Commission.Columns[0].Name = "REP";
            grid_Commission.Columns[0].ReadOnly = true;
            grid_Commission.Columns[0].Width = 40;
            grid_Commission.Columns[0].MinimumWidth = 40;
            grid_Commission.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Commission.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Commission.Columns[0].DataPropertyName = "REP";

            grid_Commission.Columns[1].Name = "Customer ID";
            grid_Commission.Columns[1].ReadOnly = true;
            grid_Commission.Columns[1].Width = 110;
            grid_Commission.Columns[1].MinimumWidth = 110;
            grid_Commission.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Commission.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Commission.Columns[1].DataPropertyName = "CustomerID";

            grid_Commission.Columns[2].Name = "Invoice Number";
            grid_Commission.Columns[2].ReadOnly = true;
            grid_Commission.Columns[2].Width = 90;
            grid_Commission.Columns[2].MinimumWidth = 90;
            grid_Commission.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Commission.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Commission.Columns[2].DataPropertyName = "InvoiceNumber";
            
            grid_Commission.Columns[3].Name = "Invoice Amount";
            grid_Commission.Columns[3].ReadOnly = true;
            grid_Commission.Columns[3].Width = 70;
            grid_Commission.Columns[3].MinimumWidth = 70;
            grid_Commission.Columns[3].DefaultCellStyle.Format = "N2";
            grid_Commission.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Commission.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Commission.Columns[3].DataPropertyName = "InvoiceAmount";
            
            grid_Commission.Columns[4].Name = "Credit";
            grid_Commission.Columns[4].ReadOnly = true;
            grid_Commission.Columns[4].Width = 60;
            grid_Commission.Columns[4].MinimumWidth = 60;
            grid_Commission.Columns[4].DefaultCellStyle.Format = "N2";
            grid_Commission.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Commission.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Commission.Columns[4].DataPropertyName = "CreditTotal";
            
            grid_Commission.Columns[5].Name = "Return";
            grid_Commission.Columns[5].ReadOnly = true;
            grid_Commission.Columns[5].Width = 60;
            grid_Commission.Columns[5].MinimumWidth = 60;
            grid_Commission.Columns[5].DefaultCellStyle.Format = "N2";
            grid_Commission.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Commission.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Commission.Columns[5].DataPropertyName = "ReturnTotal";

            grid_Commission.Columns[6].Name = "Term Credit";
            grid_Commission.Columns[6].ReadOnly = true;
            grid_Commission.Columns[6].Width = 60;
            grid_Commission.Columns[6].MinimumWidth = 60;
            grid_Commission.Columns[6].DefaultCellStyle.Format = "N2";
            grid_Commission.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Commission.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Commission.Columns[6].DataPropertyName = "TermCreditTotal";

            grid_Commission.Columns[7].Name = "Commission";
            grid_Commission.Columns[7].ReadOnly = true;
            grid_Commission.Columns[7].Width = 60;
            grid_Commission.Columns[7].MinimumWidth = 60;
            grid_Commission.Columns[7].DefaultCellStyle.Format = "N2";
            grid_Commission.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Commission.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Commission.Columns[7].DataPropertyName = "Commission";

            grid_Commission.Columns[8].Name = "Last Payment Date";
            grid_Commission.Columns[8].ReadOnly = true;
            grid_Commission.Columns[8].Width = 75;
            grid_Commission.Columns[8].MinimumWidth = 75;
            grid_Commission.Columns[8].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_Commission.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Commission.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Commission.Columns[8].DataPropertyName = "LastPaymentDate";
            //grid font size custom
            grid_Commission.RowTemplate.Height = 20;
            grid_Commission.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_Commission.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_Commission.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            grid_Commission.DataSource = null;
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String REP = cbx_SalesRep.Text.Trim();
            connSalesOrder.sp_Commission(grid_Commission, REP, FromDate, ToDate);

            try
            {
                DataTable dataTable = (DataTable)grid_Commission.DataSource;

                decimal TotalInvoiceAmt = 0, TotalCommission = 0, TotalCredit = 0, TotalReturn = 0, TotalTermCredit = 0;
                
                for (int i = 0; i < grid_Commission.RowCount; i++)
                {
                    TotalInvoiceAmt += Convert.ToDecimal(grid_Commission.Rows[i].Cells["Invoice Amount"].Value == DBNull.Value ? "0" : grid_Commission.Rows[i].Cells["Invoice Amount"].Value);
                    TotalCommission += Convert.ToDecimal(grid_Commission.Rows[i].Cells["Commission"].Value == DBNull.Value ? "0" : grid_Commission.Rows[i].Cells["Commission"].Value);
                    TotalCredit += Convert.ToDecimal(grid_Commission.Rows[i].Cells["Credit"].Value == DBNull.Value ? "0" : grid_Commission.Rows[i].Cells["Credit"].Value);
                    TotalReturn += Convert.ToDecimal(grid_Commission.Rows[i].Cells["Return"].Value == DBNull.Value ? "0" : grid_Commission.Rows[i].Cells["Return"].Value);
                    TotalTermCredit += Convert.ToDecimal(grid_Commission.Rows[i].Cells["Term Credit"].Value == DBNull.Value ? "0" : grid_Commission.Rows[i].Cells["Term Credit"].Value);
                }

                DataRow drToAdd = dataTable.NewRow();
                drToAdd["REP"] = "TOTAL";
                drToAdd["InvoiceNumber"] = "";
                drToAdd["CustomerID"] = "";
                drToAdd["InvoiceAmount"] = TotalInvoiceAmt.ToString();
                drToAdd["Commission"] = TotalCommission.ToString();
                drToAdd["CreditTotal"] = TotalCredit.ToString();
                drToAdd["ReturnTotal"] = TotalReturn.ToString();
                drToAdd["TermCreditTotal"] = TotalTermCredit.ToString();
                drToAdd["LastPaymentDate"] = DBNull.Value;
                
                dataTable.Rows.Add(drToAdd);

                dataTable.AcceptChanges();

                this.grid_Commission.ClearSelection();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String REP = cbx_SalesRep.Text.Trim();
            Reports.Rpt_Commission commission= new Reports.Rpt_Commission(REP,FromDate,ToDate);
            commission.Show();
        }
        

        private void grid_Commission_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.grid_Commission.Rows)
            {
                if (row.Cells["REP"].Value.Equals("TOTAL"))
                {
                    for (int i = 0; i < grid_Commission.ColumnCount; i++)
                    {
                        row.Cells[i].Style.BackColor = Color.Gray;
                        row.Cells[i].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void btn_exportSummary_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            Reports.Rpt_Commission_Summary commissionSummary = new Reports.Rpt_Commission_Summary(FromDate, ToDate);
            commissionSummary.Show();
        }
    }
}
