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
    public partial class WriteOff : Form
    {
        public WriteOff()
        {
            InitializeComponent();

            connPO.cbo_CompanyName(cbo_company);
            cbo_company.Text = "B.C.S.INTERNATIONAL CORP.";
            cbo_company.Enabled = false;

            cbo_customerHistory.Items.Clear();
            cbo_customerInvoice.Items.Clear(); //
            connPO.cbox_getCustomerID(cbo_customerHistory);
            connPO.cbox_getCustomerID(cbo_customerInvoice); //

            grid_invoice_Init();
            grid_historyHeader_Init();

            txt_totalPostedAmount.Text = "0.00";

        }

        private void grid_invoice_Init()
        {
            grid_invoice.AutoGenerateColumns = false;
            grid_invoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_invoice.ColumnCount = 13;

            grid_invoice.Columns[0].Visible = false;

            grid_invoice.Columns[1].Name = "Customer Name";
            grid_invoice.Columns[1].ReadOnly = true;
            grid_invoice.Columns[1].Visible = false;
            grid_invoice.Columns[1].Width = 130;
            grid_invoice.Columns[1].DataPropertyName = "BPCNAM_0";

            grid_invoice.Columns[2].Name = "Customer";
            grid_invoice.Columns[2].ReadOnly = true;
            grid_invoice.Columns[2].Width = 90;
            grid_invoice.Columns[2].MinimumWidth = 90;
            grid_invoice.Columns[2].DataPropertyName = "BPR_0";

            grid_invoice.Columns[3].Name = "Rep";
            grid_invoice.Columns[3].ReadOnly = true;
            //grid_invoice.Columns[3].Visible = false;
            grid_invoice.Columns[3].Width = 40;
            grid_invoice.Columns[3].MinimumWidth = 40;
            grid_invoice.Columns[3].DataPropertyName = "SaleRep";

            grid_invoice.Columns[4].Name = "Site";
            grid_invoice.Columns[4].ReadOnly = true;
            grid_invoice.Columns[4].Width = 40;
            grid_invoice.Columns[4].MinimumWidth = 40;
            grid_invoice.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_invoice.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_invoice.Columns[4].DataPropertyName = "FCY_0";

            grid_invoice.Columns[5].Name = "Order No.";
            grid_invoice.Columns[5].ReadOnly = true;
            grid_invoice.Columns[5].Width = 100;
            grid_invoice.Columns[5].MinimumWidth = 100;
            grid_invoice.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[5].DataPropertyName = "OrderID";

            grid_invoice.Columns[6].Name = "Delivery No.";
            grid_invoice.Columns[6].ReadOnly = true;
            grid_invoice.Columns[6].Width = 110;
            grid_invoice.Columns[6].MinimumWidth = 110;
            grid_invoice.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[6].DataPropertyName = "ORIDOCNUM_0";

            grid_invoice.Columns[7].Name = "Invoice No.";
            grid_invoice.Columns[7].ReadOnly = true;
            grid_invoice.Columns[7].Width = 90;
            grid_invoice.Columns[7].MinimumWidth = 90;
            grid_invoice.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[7].DataPropertyName = "NUM_0";

            grid_invoice.Columns[8].Name = "Invoice Date";
            grid_invoice.Columns[8].ReadOnly = true;
            grid_invoice.Columns[8].Width = 75;
            grid_invoice.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_invoice.Columns[8].DataPropertyName = "ACCDAT_0";

            grid_invoice.Columns[9].Name = "Original Amount";
            grid_invoice.Columns[9].ReadOnly = true;
            grid_invoice.Columns[9].Width = 70;
            grid_invoice.Columns[9].MinimumWidth = 70;
            grid_invoice.Columns[9].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[9].DataPropertyName = "ARAmount";

            grid_invoice.Columns[10].Name = "Net Amount";
            grid_invoice.Columns[10].ReadOnly = true;
            grid_invoice.Columns[10].Width = 70;
            grid_invoice.Columns[10].MinimumWidth = 70;
            grid_invoice.Columns[10].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[10].DataPropertyName = "AMTATI_0";

            grid_invoice.Columns[11].Name = "Write-off Amount";
            grid_invoice.Columns[11].ReadOnly = false;
            grid_invoice.Columns[11].Width = 70;
            grid_invoice.Columns[11].MinimumWidth = 70;
            grid_invoice.Columns[11].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[11].DataPropertyName = "AmountPosted";

            grid_invoice.Columns[12].Name = "Payment Term";
            grid_invoice.Columns[12].ReadOnly = true;
            grid_invoice.Columns[12].Width = 100;
            grid_invoice.Columns[12].MinimumWidth = 100;
            grid_invoice.Columns[12].DataPropertyName = "PTE_0";

            //grid font size custom
            grid_invoice.RowTemplate.Height = 20;
            grid_invoice.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_invoice.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_invoice.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_historyHeader_Init()
        {
            grid_historyHeader.AutoGenerateColumns = false;
            grid_historyHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_historyHeader.ColumnCount = 7;

            grid_historyHeader.Columns[0].Name = "Customer ID";
            grid_historyHeader.Columns[0].ReadOnly = true;
            grid_historyHeader.Columns[0].Width = 80;
            grid_historyHeader.Columns[0].MinimumWidth = 80;
            grid_historyHeader.Columns[0].DataPropertyName = "CustomerID";

            grid_historyHeader.Columns[1].Name = "Date";
            grid_historyHeader.Columns[1].ReadOnly = true;
            grid_historyHeader.Columns[1].Width = 75;
            grid_historyHeader.Columns[1].MinimumWidth = 75;
            grid_historyHeader.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_historyHeader.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_historyHeader.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_historyHeader.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_historyHeader.Columns[1].DataPropertyName = "CreateTime";

            grid_historyHeader.Columns[2].Name = "Accounting Date";
            grid_historyHeader.Columns[2].ReadOnly = true;
            grid_historyHeader.Columns[2].Width = 75;
            grid_historyHeader.Columns[2].MinimumWidth = 75;
            grid_historyHeader.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_historyHeader.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_historyHeader.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_historyHeader.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_historyHeader.Columns[2].DataPropertyName = "AccountingDate";

            grid_historyHeader.Columns[3].Name = "Write-off Number";
            grid_historyHeader.Columns[3].ReadOnly = true;
            grid_historyHeader.Columns[3].Width = 80;
            grid_historyHeader.Columns[3].MinimumWidth = 80;
            grid_historyHeader.Columns[3].DataPropertyName = "WONumber";

            grid_historyHeader.Columns[4].Name = "Write-off Invoice Number";
            grid_historyHeader.Columns[4].ReadOnly = true;
            grid_historyHeader.Columns[4].Width = 80;
            grid_historyHeader.Columns[4].MinimumWidth = 80;
            grid_historyHeader.Columns[4].DefaultCellStyle.Format = "N2";
            grid_historyHeader.Columns[4].DataPropertyName = "InvoiceNumber";

            grid_historyHeader.Columns[5].Name = "Write-off Amount";
            grid_historyHeader.Columns[5].ReadOnly = true;
            grid_historyHeader.Columns[5].Width = 75;
            grid_historyHeader.Columns[5].MinimumWidth = 75;
            grid_historyHeader.Columns[5].DefaultCellStyle.Format = "N2";
            grid_historyHeader.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_historyHeader.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_historyHeader.Columns[5].DataPropertyName = "WOAmount";

            grid_historyHeader.Columns[6].Name = "Memo";
            grid_historyHeader.Columns[6].ReadOnly = true;
            grid_historyHeader.Columns[6].Width = 100;
            grid_historyHeader.Columns[6].MinimumWidth = 100;
            grid_historyHeader.Columns[6].DataPropertyName = "DESVCR_0";

            //DataGridViewButtonColumn reverseButton = new DataGridViewButtonColumn();
            //reverseButton.Width = 60;
            //reverseButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //reverseButton.Name = "Reverse";
            //reverseButton.Text = "Reverse";
            //reverseButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //reverseButton.UseColumnTextForButtonValue = true;
            //if (grid_historyHeader.Columns["Reverse"] == null)
            //{
            //    grid_historyHeader.Columns.Insert(5, reverseButton);
            //}

            //grid font size custom
            grid_historyHeader.RowTemplate.Height = 20;
            grid_historyHeader.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_historyHeader.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_historyHeader.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_invoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Decimal NetAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["Net Amount"].Value.ToString());

                Decimal WriteoffAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["Write-off Amount"].Value.ToString());

                if(NetAmount < WriteoffAmount)
                {
                    MessageBox.Show("Net Amount cannot be greater than Write-off Amount.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    grid_invoice.Rows[e.RowIndex].Cells["Write-off Amount"].Value = "0.00";
                    return;
                }

                if (WriteoffAmount < 0)
                {
                    MessageBox.Show("Write-off Amount cannot be less than 0.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    grid_invoice.Rows[e.RowIndex].Cells["Write-off Amount"].Value = "0.00";
                    return;
                }


                update();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void update()
        {
            Decimal TotalWriteoffAmount = 0;
            for (int i = 0; i < grid_invoice.RowCount; i++)
            {
                Decimal WriteoffAmount = Convert.ToDecimal(grid_invoice.Rows[i].Cells["Write-off Amount"].Value.ToString());
                TotalWriteoffAmount = TotalWriteoffAmount + WriteoffAmount;
            }

            txt_totalPostedAmount.Text = TotalWriteoffAmount.ToString("N2");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            DateTime AccountingDate = dateTimePickerFrom.Value;
            for (int i = 0; i < grid_invoice.RowCount; i++)
            {
                Decimal WriteoffAmount = Convert.ToDecimal(grid_invoice.Rows[i].Cells["Write-off Amount"].Value.ToString());
                if (WriteoffAmount > 0)
                {
                    String InvoiceNumber = grid_invoice.Rows[i].Cells["Invoice No."].Value.ToString();
                    String CustomerID = grid_invoice.Rows[i].Cells["Customer"].Value.ToString();
                    DateTime InvoiceDate = Convert.ToDateTime(grid_invoice.Rows[i].Cells["Invoice Date"].Value);
                    if (InvoiceDate > AccountingDate)
                    {
                        MessageBox.Show(CustomerID + ", " + InvoiceNumber +  ", " + "Accounting Date (" + AccountingDate.ToShortDateString() + ") cannot be earlier than Invoice Date (" + InvoiceDate.ToShortDateString() + ")", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); //NetSettlementAmount < 0

                        return;
                    }
                }
            }

            if (txt_customerID.Text == "")
            {
                MessageBox.Show("Please select a customer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Decimal TotalWriteoffAmount = Convert.ToDecimal(txt_totalPostedAmount.Text.Trim());
            if (TotalWriteoffAmount == 0)
            {
                MessageBox.Show("Total Write-off Amount cannot be 0.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); //NetSettlementAmount < 0
                return;
            }

            for (int i = 0; i < grid_invoice.RowCount; i++)
            {
                Decimal WriteoffAmount = Convert.ToDecimal(grid_invoice.Rows[i].Cells["Write-off Amount"].Value.ToString());
                if (WriteoffAmount > 0)
                {
                    //MessageBox.Show(AmountPosted.ToString("N2"));
                    //1. get WO Number
                    String NewWONumber = connSalesOrder.sp_GET_NewWONumber();
                    if (!NewWONumber.Contains("WO"))
                    {
                        MessageBox.Show("Please try again.(WO) (Error code: " + NewWONumber + ")"
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    String InvoiceNumber = grid_invoice.Rows[i].Cells["Invoice No."].Value.ToString();
                    String CompanyName = cbo_company.Text.Trim();
                    String Memo = textbox_Memo.Text.Trim();
                    //NS_INSERT_WO
                    //1-2. NetSettlement 
                    //2. PAYMENTD (PAYMENT)
                    //3. SINVOICE
                    //4. GACCENTRYD, GACCENTRY
                    connSalesOrder.sp_WRITEOFF(NewWONumber, InvoiceNumber, WriteoffAmount, AccountingDate, CompanyName, Memo);
                }
            }

            grid_invoice.DataSource = null;
            this.grid_invoice.Rows.Clear();

            connSalesOrder.sp_PAYMENT_INVOICE(grid_invoice, cbo_customerHistory.Text, "");

            DateTime FromDate = dateTimePickerFromDate.Value.Date;
            DateTime ToDate = dateTimePickerToDate.Value.Date;
            connSalesOrder.sp_WRITEOFF_HISTORY(grid_historyHeader, cbo_customerHistory.Text, FromDate, ToDate);

            txt_totalPostedAmount.Text = "0";

            txt_customerID.Text = cbo_customerHistory.Text.Trim();
        }

        private void grid_invoice_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                grid_invoice.Rows[e.RowIndex].Cells["Write-off Amount"].Value = "0.00";
            }
            catch
            {
                grid_invoice.Rows[e.RowIndex].Cells["Write-off Amount"].Value = "0.00";
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            String CustomerID = cbo_customerHistory.Text.ToString();
            DateTime FromDate = dateTimePickerFromDate.Value.Date;
            DateTime ToDate = dateTimePickerToDate.Value.Date;
            Reports.Rpt_WriteOff rpt = new Reports.Rpt_WriteOff(CustomerID, FromDate, ToDate);
            rpt.Show();
        }

        private void btn_searchInvoice_Click(object sender, EventArgs e)
        {
            txt_customerID.Text = cbo_customerInvoice.Text.ToString();
            grid_invoice.DataSource = null;
            this.grid_invoice.Rows.Clear();

            connSalesOrder.sp_PAYMENT_INVOICE(grid_invoice, cbo_customerInvoice.Text, "");

            txt_totalPostedAmount.Text = "0";

            //txt_customerID.Text = cbo_customerHistory.Text.Trim();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFromDate.Value.Date;
            DateTime ToDate = dateTimePickerToDate.Value.Date;
            connSalesOrder.sp_WRITEOFF_HISTORY(grid_historyHeader, cbo_customerHistory.Text, FromDate, ToDate);
        }
    }
}

