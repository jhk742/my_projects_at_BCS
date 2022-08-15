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
    public partial class ARCollectionsSummaryReport : Form
    {
        public ARCollectionsSummaryReport()
        {
            InitializeComponent();
            grid_ARReport_Init();
            for (int i = 0; i < grid_ARReport.ColumnCount; i++)
            {
                grid_ARReport.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dateTimePickerFrom.Value = DateTime.Today.AddMonths(-1);
        }
        private void grid_ARReport_Init()
        {
            grid_ARReport.AutoGenerateColumns = false;
            grid_ARReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_ARReport.ColumnCount = 11;

            grid_ARReport.Columns[0].Name = "Date";
            grid_ARReport.Columns[0].ReadOnly = true;
            grid_ARReport.Columns[0].Width = 20;
            grid_ARReport.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_ARReport.Columns[0].DataPropertyName = "ACCDAT_0";

            grid_ARReport.Columns[1].Name = "ACH";
            grid_ARReport.Columns[1].ReadOnly = true;
            grid_ARReport.Columns[1].Width = 20;
            grid_ARReport.Columns[1].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[1].DataPropertyName = "ACH";

            grid_ARReport.Columns[2].Name = "Cash";
            grid_ARReport.Columns[2].ReadOnly = true;
            grid_ARReport.Columns[2].Width = 20;
            grid_ARReport.Columns[2].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[2].DataPropertyName = "Cash";

            grid_ARReport.Columns[3].Name = "Check";
            grid_ARReport.Columns[3].ReadOnly = true;
            grid_ARReport.Columns[3].Width = 20;
            grid_ARReport.Columns[3].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[3].DataPropertyName = "Checks";

            grid_ARReport.Columns[4].Name = "Total";
            grid_ARReport.Columns[4].ReadOnly = true;
            grid_ARReport.Columns[4].Width = 25;
            grid_ARReport.Columns[4].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[4].DataPropertyName = "Total";

            grid_ARReport.Columns[5].Name = "Sales";
            grid_ARReport.Columns[5].ReadOnly = true;
            grid_ARReport.Columns[5].Width = 20;
            grid_ARReport.Columns[5].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[5].DataPropertyName = "Sales";

            grid_ARReport.Columns[6].Name = "NSF";
            grid_ARReport.Columns[6].ReadOnly = true;
            grid_ARReport.Columns[6].Width = 20;
            grid_ARReport.Columns[6].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[6].DataPropertyName = "NSF";

            grid_ARReport.Columns[7].Name = "Other Income";
            grid_ARReport.Columns[7].ReadOnly = true;
            grid_ARReport.Columns[7].Width = 20;
            grid_ARReport.Columns[7].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[7].DataPropertyName = "OtherIncome";

            grid_ARReport.Columns[8].Name = "Over";
            grid_ARReport.Columns[8].ReadOnly = true;
            grid_ARReport.Columns[8].Width = 20;
            grid_ARReport.Columns[8].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[8].DataPropertyName = "Overs";

            grid_ARReport.Columns[9].Name = "Payment Total";
            grid_ARReport.Columns[9].ReadOnly = true;
            grid_ARReport.Columns[9].Width = 25;
            grid_ARReport.Columns[9].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[9].DataPropertyName = "PaymentTotal";

            grid_ARReport.Columns[10].Name = "Short";
            grid_ARReport.Columns[10].ReadOnly = true;
            grid_ARReport.Columns[10].Width = 100;
            grid_ARReport.Columns[10].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[10].DataPropertyName = "Short";

            //grid font size custom
            grid_ARReport.RowTemplate.Height = 20;
            grid_ARReport.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_ARReport.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_ARReport.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (dateTimePickerTo.Value.Date < dateTimePickerFrom.Value.Date)
            {
                MessageBox.Show("Check the date");
                return;
            }

            if (dateTimePickerFrom.CustomFormat.Equals("MM/yyyy"))
            {
                if (dateTimePickerFrom.Value < Convert.ToDateTime("01/2020"))
                {
                    MessageBox.Show("Only After 01/2020");
                    dateTimePickerFrom.Value = Convert.ToDateTime("01/2020");
                    return;
                }
            }
            else if (dateTimePickerFrom.CustomFormat.Equals("MM/dd/yyyy"))
            {
                if (dateTimePickerFrom.Value < Convert.ToDateTime("01/01/2020"))
                {
                    MessageBox.Show("Only After 01/01/2020");
                    dateTimePickerFrom.Value = Convert.ToDateTime("01/01/2020");
                    return;
                }
            }

            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;

            grid_ARReport.DataSource = null;

            if (rad_Daily.Checked)
            {
                connSalesOrder.sp_ARCollectionDailyReport(grid_ARReport, FromDate, ToDate);
                grid_ARReportLoad();
            }
            else if (rad_Monthly.Checked)
            {
                connSalesOrder.sp_ARCollectionMonthlyReport(grid_ARReport, FromDate, ToDate);
                grid_ARReportLoad();
            }
            else
            {
                MessageBox.Show("Select the Daily/Monthly.");
                return;
            }
        }
        private void radioChecked(object sender, EventArgs e)
        {
            if (rad_Monthly.Checked)
            {
                //dateTimePickerFrom.Enabled = false;
                //dateTimePickerTo.Enabled = false;
                rad_Daily.Checked = false;
                dateTimePickerFrom.CustomFormat = "MM/yyyy";
                dateTimePickerTo.CustomFormat = "MM/yyyy";
                dateTimePickerFrom.Value = Convert.ToDateTime("01/2020");
            }
            else if (rad_Daily.Checked)
            {
                //dateTimePickerFrom.Enabled = true;
                //dateTimePickerTo.Enabled = true;
                rad_Monthly.Checked = false;
                dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
                dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
            }
        }
        private void grid_ARReportLoad()
        {
            try
            {
                decimal total_ACH = 0, total_Cash = 0, total_Check = 0, total_Total = 0, total_Sales = 0,
                total_NSF = 0, total_OtherIncome = 0, total_Over = 0, total_PaymentTotal = 0, total_Short = 0;

                for (int i = 0; i < grid_ARReport.RowCount; i++)
                {
                    total_ACH += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["ACH"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["ACH"].Value);
                    total_Cash += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Cash"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Cash"].Value);
                    total_Check += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Check"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Check"].Value);
                    total_Total += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Total"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Total"].Value);
                    total_Sales += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Sales"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Sales"].Value);
                    total_NSF += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["NSF"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["NSF"].Value);
                    total_OtherIncome += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Other Income"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Other Income"].Value);
                    total_Over += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Over"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Over"].Value);
                    total_PaymentTotal += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Payment Total"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Payment Total"].Value);
                    total_Short += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Short"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Short"].Value);
                }
                DataTable dataTable = (DataTable)grid_ARReport.DataSource;
                DataRow drToAdd = dataTable.NewRow();
                drToAdd["ACCDAT_0"] = "TOTAL";
                drToAdd["ACH"] = total_ACH.ToString();
                drToAdd["Cash"] = total_Cash.ToString();
                drToAdd["Checks"] = total_Check.ToString();
                drToAdd["Total"] = total_Total.ToString();
                drToAdd["Sales"] = total_Sales.ToString();
                drToAdd["NSF"] = total_NSF.ToString();
                drToAdd["OtherIncome"] = total_OtherIncome.ToString();
                drToAdd["Overs"] = total_Over.ToString();
                drToAdd["PaymentTotal"] = total_PaymentTotal.ToString();
                drToAdd["Short"] = total_Short.ToString();

                dataTable.Rows.Add(drToAdd);

                dataTable.AcceptChanges();

                this.grid_ARReport.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void grid_ARReport_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in this.grid_ARReport.Rows)
                {
                    row.Cells["Total"].Style.BackColor = Color.AliceBlue;
                    row.Cells["Payment Total"].Style.BackColor = Color.AliceBlue;

                    if (row.Cells["Date"].Value.Equals("TOTAL"))
                    {
                        row.Cells["Total"].Style.BackColor = Color.Gray;
                        row.Cells["Payment Total"].Style.BackColor = Color.Gray;
                        row.DefaultCellStyle.BackColor = Color.Gray;
                        row.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime Fromdate = dateTimePickerFrom.Value.Date;
            DateTime Todate = dateTimePickerTo.Value.Date;

            if (rad_Monthly.Checked)
            {
                Reports.Rpt_ARCollectionMonthly aRCollectionMonthly = new Reports.Rpt_ARCollectionMonthly(Fromdate, Todate);
                aRCollectionMonthly.Show();
            }
            else if (rad_Daily.Checked)
            {
                Reports.Rpt_ARCollectionDaily aRCollectionDaily = new Reports.Rpt_ARCollectionDaily(Fromdate, Todate);
                aRCollectionDaily.Show();
            }
            else
            {
                MessageBox.Show("Select the Daily/Monthly.");
            }
        }
    }
}
