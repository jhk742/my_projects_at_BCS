﻿using System;
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
    public partial class ARSalesDebitMemoSummaryReport : Form
    {
        public ARSalesDebitMemoSummaryReport()
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
            grid_ARReport.ColumnCount = 12;

            grid_ARReport.Columns[0].Name = "Date";
            grid_ARReport.Columns[0].ReadOnly = true;
            grid_ARReport.Columns[0].Width = 15;
            grid_ARReport.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_ARReport.Columns[0].DataPropertyName = "ACCDAT_0";

            grid_ARReport.Columns[1].Name = "Gross Sales";
            grid_ARReport.Columns[1].ReadOnly = true;
            grid_ARReport.Columns[1].Width = 25;
            grid_ARReport.Columns[1].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[1].DataPropertyName = "GrossSales";

            grid_ARReport.Columns[2].Name = "Sales Allowance";
            grid_ARReport.Columns[2].ReadOnly = true;
            grid_ARReport.Columns[2].Width = 25;
            grid_ARReport.Columns[2].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[2].DataPropertyName = "SalesAllowance";

            grid_ARReport.Columns[3].Name = "Sales Discount";
            grid_ARReport.Columns[3].ReadOnly = true;
            grid_ARReport.Columns[3].Width = 25;
            grid_ARReport.Columns[3].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[3].DataPropertyName = "SalesDiscount";

            grid_ARReport.Columns[4].Name = "Sales Return";
            grid_ARReport.Columns[4].ReadOnly = true;
            grid_ARReport.Columns[4].Width = 25;
            grid_ARReport.Columns[4].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[4].DataPropertyName = "SalesReturn";

            grid_ARReport.Columns[5].Name = "Net Sales";
            grid_ARReport.Columns[5].ReadOnly = true;
            grid_ARReport.Columns[5].Width = 25;
            grid_ARReport.Columns[5].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[5].DataPropertyName = "NetSales";

            grid_ARReport.Columns[6].Name = "Bad Debt";
            grid_ARReport.Columns[6].ReadOnly = true;
            grid_ARReport.Columns[6].Width = 15;
            grid_ARReport.Columns[6].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[6].DataPropertyName = "BadDebt";

            grid_ARReport.Columns[7].Name = "Collection Fee";
            grid_ARReport.Columns[7].ReadOnly = true;
            grid_ARReport.Columns[7].Width = 15;
            grid_ARReport.Columns[7].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[7].DataPropertyName = "CollectionFee";

            grid_ARReport.Columns[8].Name = "Deduct Total";
            grid_ARReport.Columns[8].ReadOnly = true;
            grid_ARReport.Columns[8].Width = 15;
            grid_ARReport.Columns[8].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[8].DataPropertyName = "DeductTotal";

            grid_ARReport.Columns[9].Name = "NSF";
            grid_ARReport.Columns[9].ReadOnly = true;
            grid_ARReport.Columns[9].Width = 25;
            grid_ARReport.Columns[9].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[9].DataPropertyName = "NSF";

            grid_ARReport.Columns[10].Name = "NSF Fee";
            grid_ARReport.Columns[10].ReadOnly = true;
            grid_ARReport.Columns[10].Width = 25;
            grid_ARReport.Columns[10].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[10].DataPropertyName = "NSFFee";

            grid_ARReport.Columns[11].Name = "Debit Memo Total";
            grid_ARReport.Columns[11].ReadOnly = true;
            grid_ARReport.Columns[11].Width = 120;
            grid_ARReport.Columns[11].DefaultCellStyle.Format = "N2";
            grid_ARReport.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARReport.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ARReport.Columns[11].DataPropertyName = "DebitMemoTotal";

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
                connSalesOrder.sp_ARDailySalesDebitMemo(grid_ARReport, FromDate, ToDate);
                grid_ARReportLoad();
            }
            else if (rad_Monthly.Checked)
            {
                connSalesOrder.sp_ARMonthlySalesDebitMemo(grid_ARReport, FromDate, ToDate);
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
                decimal total_GrossSales = 0, total_SalesAllowance = 0, total_SalesDiscount = 0, total_SalesReturn = 0, total_NetSales = 0,
                total_BadDebt = 0, total_CollectionFee = 0, total_Deduct = 0, total_NSF = 0, total_NSFFee = 0, total_DebitMemo = 0;

                for (int i = 0; i < grid_ARReport.RowCount; i++)
                {
                    total_GrossSales += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Gross Sales"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Gross Sales"].Value);
                    total_SalesAllowance += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Sales Allowance"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Sales Allowance"].Value);
                    total_SalesDiscount += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Sales Discount"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Sales Discount"].Value);
                    total_SalesReturn += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Sales Return"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Sales Return"].Value);
                    total_NetSales += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Net Sales"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Net Sales"].Value);
                    total_BadDebt += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Bad Debt"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Bad Debt"].Value);
                    total_CollectionFee += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Collection Fee"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Collection Fee"].Value);
                    total_Deduct += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Deduct Total"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Deduct Total"].Value);
                    total_NSF += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["NSF"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["NSF"].Value);
                    total_NSFFee += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["NSF Fee"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["NSF Fee"].Value);
                    total_DebitMemo += Convert.ToDecimal(grid_ARReport.Rows[i].Cells["Debit Memo Total"].Value == DBNull.Value ? "0" : grid_ARReport.Rows[i].Cells["Debit Memo Total"].Value);
                }
                DataTable dataTable = (DataTable)grid_ARReport.DataSource;
                DataRow drToAdd = dataTable.NewRow();
                drToAdd["ACCDAT_0"] = "TOTAL";
                drToAdd["GrossSales"] = total_GrossSales.ToString();
                drToAdd["SalesAllowance"] = total_SalesAllowance.ToString();
                drToAdd["SalesDiscount"] = total_SalesDiscount.ToString();
                drToAdd["SalesReturn"] = total_SalesReturn.ToString();
                drToAdd["NetSales"] = total_NetSales.ToString();
                drToAdd["BadDebt"] = total_BadDebt.ToString();
                drToAdd["CollectionFee"] = total_CollectionFee.ToString();
                drToAdd["DeductTotal"] = total_Deduct.ToString();
                drToAdd["NSF"] = total_NSF.ToString();
                drToAdd["NSFFee"] = total_NSFFee.ToString();
                drToAdd["DebitMemoTotal"] = total_DebitMemo.ToString();

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
                    row.Cells["Net Sales"].Style.BackColor = Color.AliceBlue;
                    row.Cells["Debit Memo Total"].Style.BackColor = Color.AliceBlue;

                    if (row.Cells["Date"].Value.Equals("TOTAL"))
                    {
                        row.Cells["Net Sales"].Style.BackColor = Color.Gray;
                        row.Cells["Debit Memo Total"].Style.BackColor = Color.Gray;
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
                Reports.Rpt_ARSalesDebitMemoMonthly aRSalesDebitMemoMonthly = new Reports.Rpt_ARSalesDebitMemoMonthly(Fromdate, Todate);
                aRSalesDebitMemoMonthly.Show();
            }else if (rad_Daily.Checked)
            {
                Reports.Rpt_ARSalesDebitMemoDaily aRSalesDebitMemoDaily = new Reports.Rpt_ARSalesDebitMemoDaily(Fromdate, Todate);
                aRSalesDebitMemoDaily.Show();
            }
            else
            {
                MessageBox.Show("Select the Daily/Monthly.");
            }
           
        }
    }
}
