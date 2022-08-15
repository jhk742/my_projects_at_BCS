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
    public partial class AROverpayment : Form
    {
        public AROverpayment()
        {
            InitializeComponent();
            grid_AROverPayment_Init();

            cbo_CustomerID.Items.Clear();
            cbo_CustomerID.Items.Add("");
            connPO.cbox_getCustomerID(cbo_CustomerID);
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-14);
            dateTimePickerTo.Value = DateTime.Today;
            connSalesOrder.sp_AROverPayment(grid_AROverPayment, cbo_CustomerID.Text, DateTime.Today.AddDays(-14), DateTime.Today);
            CalculateTotal();
        }
        private void grid_AROverPayment_Init()
        {
            grid_AROverPayment.AutoGenerateColumns = false;
            grid_AROverPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_AROverPayment.ColumnCount = 8;

            grid_AROverPayment.Columns[0].Name = "OP Number";
            grid_AROverPayment.Columns[0].ReadOnly = true;
            grid_AROverPayment.Columns[0].Width = 60;
            grid_AROverPayment.Columns[0].MinimumWidth = 60;
            grid_AROverPayment.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AROverPayment.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AROverPayment.Columns[0].DataPropertyName = "OPNumber";

            grid_AROverPayment.Columns[1].Name = "NS Number";
            grid_AROverPayment.Columns[1].ReadOnly = true;
            grid_AROverPayment.Columns[1].Width = 60;
            grid_AROverPayment.Columns[1].MinimumWidth = 60;
            grid_AROverPayment.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AROverPayment.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AROverPayment.Columns[1].DataPropertyName = "NSNumber";

            grid_AROverPayment.Columns[2].Name = "Customer ID";
            grid_AROverPayment.Columns[2].ReadOnly = true;
            grid_AROverPayment.Columns[2].Width = 80;
            grid_AROverPayment.Columns[2].MinimumWidth = 80;
            grid_AROverPayment.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AROverPayment.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AROverPayment.Columns[2].DataPropertyName = "Customer";

            grid_AROverPayment.Columns[3].Name = "Description";
            grid_AROverPayment.Columns[3].ReadOnly = true;
            grid_AROverPayment.Columns[3].Width = 130;
            grid_AROverPayment.Columns[3].MinimumWidth = 130;
            grid_AROverPayment.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AROverPayment.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AROverPayment.Columns[3].DataPropertyName = "Description";

            grid_AROverPayment.Columns[4].Name = "Credit Amount";
            grid_AROverPayment.Columns[4].ReadOnly = true;
            grid_AROverPayment.Columns[4].Width = 80;
            grid_AROverPayment.Columns[4].MinimumWidth = 80;
            grid_AROverPayment.Columns[4].DefaultCellStyle.Format = "N2";
            grid_AROverPayment.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AROverPayment.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AROverPayment.Columns[4].DataPropertyName = "CreditAmount";

            grid_AROverPayment.Columns[5].Name = "Remaining Amount";
            grid_AROverPayment.Columns[5].ReadOnly = true;
            grid_AROverPayment.Columns[5].Width = 80;
            grid_AROverPayment.Columns[5].MinimumWidth = 80;
            grid_AROverPayment.Columns[5].DefaultCellStyle.Format = "N2";
            grid_AROverPayment.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AROverPayment.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AROverPayment.Columns[5].DataPropertyName = "RemainingAmount";

            grid_AROverPayment.Columns[6].Name = "Transfer Amount";
            grid_AROverPayment.Columns[6].ReadOnly = true;
            grid_AROverPayment.Columns[6].Width = 80;
            grid_AROverPayment.Columns[6].MinimumWidth = 80;
            grid_AROverPayment.Columns[6].DefaultCellStyle.Format = "N2";
            grid_AROverPayment.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AROverPayment.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AROverPayment.Columns[6].DataPropertyName = "TransferAmount";
            
            grid_AROverPayment.Columns[7].Name = "Date";
            grid_AROverPayment.Columns[7].ReadOnly = true;
            grid_AROverPayment.Columns[7].Width = 75;
            grid_AROverPayment.Columns[7].MinimumWidth = 75;
            grid_AROverPayment.Columns[7].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_AROverPayment.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AROverPayment.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AROverPayment.Columns[7].DataPropertyName = "Date";
            //grid font size custom
            grid_AROverPayment.RowTemplate.Height = 20;
            grid_AROverPayment.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_AROverPayment.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_AROverPayment.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void cbo_CustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_CustomerID.Text.Equals("")) 
                txt_customerName.Text = "";
            else
                txt_customerName.Text = connPO.getCustomerNamebyCustomerID(cbo_CustomerID.Text.Trim());
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (cbo_CustomerID.Text.Equals(""))
                txt_customerName.Text = "";
            else
                txt_customerName.Text = connPO.getCustomerNamebyCustomerID(cbo_CustomerID.Text.Trim());

            connSalesOrder.sp_AROverPayment(grid_AROverPayment, cbo_CustomerID.Text, dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            try
            {
                DataTable dataTable = (DataTable)grid_AROverPayment.DataSource;
                decimal TotalCreditAmount = 0, TotalRemainingAmount = 0, TotalTransferAmount = 0;

                for (int i = 0; i < grid_AROverPayment.RowCount; i++)
                {
                    TotalCreditAmount += Convert.ToDecimal(grid_AROverPayment.Rows[i].Cells["Credit Amount"].Value == DBNull.Value ? "0" : grid_AROverPayment.Rows[i].Cells["Credit Amount"].Value);
                    TotalRemainingAmount += Convert.ToDecimal(grid_AROverPayment.Rows[i].Cells["Remaining Amount"].Value == DBNull.Value ? "0" : grid_AROverPayment.Rows[i].Cells["Remaining Amount"].Value);
                    TotalTransferAmount += Convert.ToDecimal(grid_AROverPayment.Rows[i].Cells["Transfer Amount"].Value == DBNull.Value ? "0" : grid_AROverPayment.Rows[i].Cells["Transfer Amount"].Value);
                }

                txt_CreditAmount.Text = TotalCreditAmount.ToString("F");
                txt_RemainingAmount.Text = (TotalCreditAmount - TotalTransferAmount).ToString("F");
                txt_TransferAmount.Text = TotalTransferAmount.ToString("F");
                //DataRow drToAdd = dataTable.NewRow();
                //drToAdd["OPNumber"] = "TOTAL";
                //drToAdd["NSNumber"] = "";
                //drToAdd["Customer"] = "";
                //drToAdd["Description"] = "";
                //drToAdd["CreditAmount"] = TotalCreditAmount.ToString();
                //drToAdd["RemainingAmount"] = TotalRemainingAmount.ToString();
                //drToAdd["TransferAmount"] = TotalTransferAmount.ToString();
                //drToAdd["Date"] = DBNull.Value;

                //dataTable.Rows.Add(drToAdd);
                //dataTable.AcceptChanges();
                //this.grid_AROverPayment.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void grid_AROverPayment_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //foreach (DataGridViewRow row in this.grid_AROverPayment.Rows)
            //{
            //    if (row.Cells["OPNumber"].Value.Equals("TOTAL"))
            //    {
            //        for (int i = 0; i < grid_AROverPayment.ColumnCount; i++)
            //        {
            //            row.Cells[i].Style.BackColor = Color.Gray;
            //            row.Cells[i].Style.ForeColor = Color.White;
            //        }
            //    }
            //}
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String CustomerID = cbo_CustomerID.Text;


            Reports.Rpt_AROverPayment aROverPayment = new Reports.Rpt_AROverPayment(CustomerID, FromDate, ToDate);
            //salesReport.MdiParent = this.MdiParent;
            aROverPayment.Show();
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date < Convert.ToDateTime("01/06/2020"))
            {
                dateTimePickerFrom.Value = Convert.ToDateTime("01/06/2020");
            }
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date < Convert.ToDateTime("01/06/2020"))
            {
                dateTimePickerFrom.Value = Convert.ToDateTime("01/06/2020");
            }
        }
    }
}
