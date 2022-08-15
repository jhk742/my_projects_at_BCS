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
    public partial class NetSettlement : Form
    {
        public NetSettlement()
        {
            InitializeComponent();

            connPO.cbo_CompanyName(cbo_company);
            cbo_company.Text = "B.C.S.INTERNATIONAL CORP.";
            cbo_company.Enabled = false;

            cbo_customer.Items.Clear();
            connPO.cbox_getCustomerID(cbo_customer);

            grid_invoice_Init();
            grid_credit_Init();
            grid_return_Init();
            grid_overPayment_Init();
            grid_netSettlementHistory_Init();
            grid_netSettlementDetail_Init();

            txt_invoiceAmount.Text = "0.00";
            txt_creditTotal.Text = "0.00";
            txt_netSettleAmount.Text = "0.00";


            grid_credit.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            grid_return.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            grid_overPayment.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;


        }

        private void grid_invoice_Init()
        {
            grid_invoice.AutoGenerateColumns = false;
            grid_invoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_invoice.ColumnCount = 11;

            DataGridViewCheckBoxColumn invoiceCheck = new DataGridViewCheckBoxColumn();
            invoiceCheck.HeaderText = "X";
            invoiceCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invoiceCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invoiceCheck.FalseValue = false;
            invoiceCheck.TrueValue = true;
            invoiceCheck.Name = "invoiceSelect";
            invoiceCheck.ReadOnly = true;
            invoiceCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            invoiceCheck.Width = 25;
            invoiceCheck.MinimumWidth = 25;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_invoice.Columns.Insert(0, invoiceCheck);
            grid_invoice.CellContentClick += new DataGridViewCellEventHandler(invoiceSelect);

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
            grid_invoice.Columns[3].Visible = false;
            grid_invoice.Columns[3].Width = 40;
            grid_invoice.Columns[3].DataPropertyName = "REP1_0";

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
            
            grid_invoice.Columns[11].Name = "Payment Term";
            grid_invoice.Columns[11].ReadOnly = true;
            grid_invoice.Columns[11].Width = 120;
            grid_invoice.Columns[11].MinimumWidth = 120;
            grid_invoice.Columns[11].DataPropertyName = "PTE_0";
            
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

        String SelectedInvoiceNumber = "";
        private void invoiceSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Ready check box click
            {
                if (Convert.ToBoolean(grid_invoice.Rows[e.RowIndex].Cells["invoiceSelect"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                {

                    for (int i = 0; i < grid_invoice.RowCount; i++)
                    {
                        if (Convert.ToBoolean(grid_invoice.Rows[i].Cells["invoiceSelect"].EditedFormattedValue) == true)
                        {
                            MessageBox.Show("Can choose only 1 invoice.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }

                    grid_invoice.Rows[e.RowIndex].Cells["invoiceSelect"].Value = true;
                    SelectedInvoiceNumber = grid_invoice.Rows[e.RowIndex].Cells["Invoice No."].Value.ToString().Trim();
                    grid_invoice.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                    grid_invoice.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    
                    
                    

                    Decimal InvoiceOriginalAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["Original Amount"].Value.ToString());
                    Decimal InvoiceNetAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["Net Amount"].Value.ToString());
                    String InvoiceNumber = grid_invoice.Rows[e.RowIndex].Cells["Invoice No."].Value.ToString().Trim();

                    if (SelectedInvoiceNumber.Contains("DIR"))
                    {
                        calculate();
                        return;
                    }

                    for (int i = 0; i < grid_credit.Rows.Count; i++)
                    {
                        if (grid_credit.Rows[i].Cells["Order No."].Value.ToString() == grid_invoice.Rows[e.RowIndex].Cells["Order No."].Value.ToString())
                        {
                            grid_credit.Rows[i].Cells["CreditSelect"].Value = true;
                            grid_credit.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                            grid_credit.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }

                    for (int i = 0; i < grid_return.Rows.Count; i++)
                    {
                        if (grid_return.Rows[i].Cells["OrderID"].Value.ToString() == grid_invoice.Rows[e.RowIndex].Cells["Order No."].Value.ToString())
                        {
                            grid_return.Rows[i].Cells["returnSelect"].Value = true;
                            grid_return.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                            grid_return.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }

                }
                else // uncheck 했을 때
                {
                    grid_invoice.Rows[e.RowIndex].Cells["invoiceSelect"].Value = false;
                    grid_invoice.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    grid_invoice.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

                    for (int i = 0; i < grid_credit.Rows.Count; i++)
                    {
                        //if (grid_credit.Rows[i].Cells["Order No."].Value.ToString() == grid_invoice.Rows[e.RowIndex].Cells["Order No."].Value.ToString())
                        //{
                            grid_credit.Rows[i].Cells["CreditSelect"].Value = false;
                            grid_credit.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            grid_credit.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                            grid_credit.Rows[i].Cells["Net Amount"].Value = grid_credit.Rows[i].Cells["Amt"].Value;
                        //}
                    }

                    for (int i = 0; i < grid_return.Rows.Count; i++)
                    {
                        //if (grid_return.Rows[i].Cells["OrderID"].Value.ToString() == grid_invoice.Rows[e.RowIndex].Cells["Order No."].Value.ToString())
                        //{
                            grid_return.Rows[i].Cells["returnSelect"].Value = false;
                            grid_return.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            grid_return.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                            grid_return.Rows[i].Cells["Net Amount"].Value = grid_return.Rows[i].Cells["Amt"].Value;
                        //}
                    }
                }

            }

            for (int i = 0; i < grid_invoice.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_invoice.Rows[i].Cells["invoiceSelect"].EditedFormattedValue) == true)
                {
                    grid_invoice.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DimGray;
                    grid_invoice.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else
                {
                    grid_invoice.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightGray;
                    grid_invoice.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }

            for (int i = 0; i < grid_credit.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_credit.Rows[i].Cells["creditSelect"].EditedFormattedValue) == true)
                {
                    grid_credit.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DimGray;
                    grid_credit.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else
                {
                    grid_credit.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightGray;
                    grid_credit.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }

            for (int i = 0; i < grid_return.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_return.Rows[i].Cells["returnSelect"].EditedFormattedValue) == true)
                {
                    grid_return.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DimGray;
                    grid_return.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else
                {
                    grid_return.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightGray;
                    grid_return.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }

            calculate();


        }

        private void grid_credit_Init()
        {
            grid_credit.AutoGenerateColumns = false;
            grid_credit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_credit.ColumnCount = 8;

            DataGridViewCheckBoxColumn creditCheck = new DataGridViewCheckBoxColumn();
            creditCheck.HeaderText = "X";
            creditCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            creditCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            creditCheck.FalseValue = false;
            creditCheck.TrueValue = true;
            creditCheck.Name = "creditSelect";
            creditCheck.ReadOnly = true;
            creditCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            creditCheck.Width = 25;
            creditCheck.MinimumWidth = 25;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_credit.Columns.Insert(0, creditCheck);
            grid_credit.CellContentClick += new DataGridViewCellEventHandler(creditSelect);

            grid_credit.Columns[1].Name = "No.";
            grid_credit.Columns[1].ReadOnly = true;
            grid_credit.Columns[1].Width = 80;
            grid_credit.Columns[1].MinimumWidth = 80;
            grid_credit.Columns[1].DataPropertyName = "NUM_0";

            grid_credit.Columns[2].Name = "Amt";
            grid_credit.Columns[2].ReadOnly = true;
            grid_credit.Columns[2].Width = 50;
            grid_credit.Columns[2].MinimumWidth = 50;
            grid_credit.Columns[2].DefaultCellStyle.Format = "N2";
            grid_credit.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_credit.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_credit.Columns[2].DataPropertyName = "CreditAmount";

            grid_credit.Columns[3].Name = "Net Amount";
            grid_credit.Columns[3].ReadOnly = false;
            grid_credit.Columns[3].Width = 70;
            grid_credit.Columns[3].MinimumWidth = 70;
            grid_credit.Columns[3].DefaultCellStyle.Format = "N2";
            grid_credit.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_credit.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_credit.Columns[3].DataPropertyName = "NetAmount";

            grid_credit.Columns[4].Name = "Date";
            grid_credit.Columns[4].ReadOnly = true;
            grid_credit.Columns[4].Width = 75;
            grid_credit.Columns[4].MinimumWidth = 75;
            grid_credit.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_credit.Columns[4].DataPropertyName = "ACCDAT_0";

            grid_credit.Columns[5].Name = "Customer";
            grid_credit.Columns[5].Visible = false;
            grid_credit.Columns[5].ReadOnly = true;
            grid_credit.Columns[5].Width = 80;
            grid_credit.Columns[5].DataPropertyName = "BPR_0";

            grid_credit.Columns[6].Name = "Order No.";
            //grid_credit.Columns[6].Visible = false;
            grid_credit.Columns[6].ReadOnly = true;
            grid_credit.Columns[6].Width = 80;
            grid_credit.Columns[6].MinimumWidth = 80;
            grid_credit.Columns[6].DataPropertyName = "ORIDOCNUM_0";

            grid_credit.Columns[7].Name = "Memo";
            //grid_credit.Columns[7].Visible = false;
            grid_credit.Columns[7].ReadOnly = true;
            grid_credit.Columns[7].Width = 120;
            grid_credit.Columns[7].MinimumWidth = 120;
            grid_credit.Columns[7].DataPropertyName = "DES_0";

            grid_credit.Columns[8].Name = "Type";
            //grid_credit.Columns[8].Visible = false;
            grid_credit.Columns[8].ReadOnly = true;
            grid_credit.Columns[8].Width = 50;
            grid_credit.Columns[8].MinimumWidth = 50;
            grid_credit.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_credit.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_credit.Columns[8].DataPropertyName = "CreditType";

            //DataGridViewButtonColumn deleteCreditButton = new DataGridViewButtonColumn();
            //deleteCreditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //deleteCreditButton.Width = 50;
            //deleteCreditButton.MinimumWidth = 50;
            //deleteCreditButton.Name = "Delete";
            //deleteCreditButton.Text = "Delete";
            //deleteCreditButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //deleteCreditButton.UseColumnTextForButtonValue = true;
            //if (grid_credit.Columns["Delete"] == null)

            //{
            //    grid_credit.Columns.Insert(9, deleteCreditButton);
            //}

            //grid font size custom
            grid_credit.RowTemplate.Height = 20;
            grid_credit.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_credit.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_credit.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void creditSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Ready check box click
            {
                if (Convert.ToBoolean(grid_credit.Rows[e.RowIndex].Cells["CreditSelect"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                {
                    grid_credit.Rows[e.RowIndex].Cells["creditSelect"].Value = true;
                    grid_credit.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                    grid_credit.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else // uncheck 했을 때
                {
                    grid_credit.Rows[e.RowIndex].Cells["creditSelect"].Value = false;
                    grid_credit.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    grid_credit.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }

                for (int i = 0; i < grid_credit.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_credit.Rows[i].Cells["creditSelect"].EditedFormattedValue) == true)
                    {
                        grid_credit.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DimGray;
                        grid_credit.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                    }
                    else
                    {
                        grid_credit.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightGray;
                        grid_credit.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;
                    }
                }

                calculate();
            }
        }

        private void grid_return_Init()
        {
            grid_return.AutoGenerateColumns = false;
            grid_return.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_return.ColumnCount = 6;

            DataGridViewCheckBoxColumn returnCheck = new DataGridViewCheckBoxColumn();
            returnCheck.HeaderText = "X";
            returnCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            returnCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            returnCheck.FalseValue = false;
            returnCheck.TrueValue = true;
            returnCheck.Name = "returnSelect";
            returnCheck.ReadOnly = true;
            returnCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            returnCheck.Width = 25;
            returnCheck.MinimumWidth = 25;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_return.Columns.Insert(0, returnCheck);
            grid_return.CellContentClick += new DataGridViewCellEventHandler(returnSelect);

            grid_return.Columns[1].Name = "No.";
            grid_return.Columns[1].ReadOnly = true;
            grid_return.Columns[1].Width = 80;
            grid_return.Columns[1].MinimumWidth = 80;
            grid_return.Columns[1].DataPropertyName = "ReturnID";

            grid_return.Columns[2].Name = "Amt";
            grid_return.Columns[2].ReadOnly = true;
            grid_return.Columns[2].Width = 50;
            grid_return.Columns[2].MinimumWidth = 50;
            grid_return.Columns[2].DefaultCellStyle.Format = "N2";
            grid_return.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[2].DataPropertyName = "Amount";

            grid_return.Columns[3].Name = "Net Amount";
            grid_return.Columns[3].ReadOnly = false;
            grid_return.Columns[3].Width = 50;
            grid_return.Columns[3].MinimumWidth = 50;
            grid_return.Columns[3].DefaultCellStyle.Format = "N2";
            grid_return.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[3].DataPropertyName = "NetAmount";

            grid_return.Columns[4].Name = "Date";
            grid_return.Columns[4].ReadOnly = true;
            grid_return.Columns[4].Width = 75;
            grid_return.Columns[4].MinimumWidth = 75;
            grid_return.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_return.Columns[4].DataPropertyName = "OrderDate";

            grid_return.Columns[5].Name = "Customer";
            //grid_return.Columns[5].Visible = false;
            grid_return.Columns[5].ReadOnly = true;
            grid_return.Columns[5].Width = 80;
            grid_return.Columns[5].MinimumWidth = 80;
            grid_return.Columns[5].DataPropertyName = "CustomerID";

            grid_return.Columns[6].Name = "OrderID";
            //grid_return.Columns[6].Visible = false;
            grid_return.Columns[6].ReadOnly = true;
            grid_return.Columns[6].Width = 80;
            grid_return.Columns[6].MinimumWidth = 80;
            grid_return.Columns[6].DataPropertyName = "OrderID";

            //grid font size custom
            grid_return.RowTemplate.Height = 20;
            grid_return.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_return.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_return.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void returnSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Ready check box click
            {

                if (Convert.ToBoolean(grid_return.Rows[e.RowIndex].Cells["returnSelect"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                {
                    grid_return.Rows[e.RowIndex].Cells["returnSelect"].Value = true;
                    grid_return.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                    grid_return.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else // uncheck 했을 때
                {
                    grid_return.Rows[e.RowIndex].Cells["returnSelect"].Value = false;
                    grid_return.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    grid_return.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }

                for (int i = 0; i < grid_return.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_return.Rows[i].Cells["returnSelect"].EditedFormattedValue) == true)
                    {
                        grid_return.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DimGray;
                        grid_return.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                    }
                    else
                    {
                        grid_return.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightGray;
                        grid_return.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;
                    }
                }
                calculate();
            }
        }

        private void grid_overPayment_Init()
        {
            grid_overPayment.AutoGenerateColumns = false;
            grid_overPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_overPayment.ColumnCount = 7;

            DataGridViewCheckBoxColumn overPaymentCheck = new DataGridViewCheckBoxColumn();
            overPaymentCheck.HeaderText = "X";
            overPaymentCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            overPaymentCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            overPaymentCheck.FalseValue = false;
            overPaymentCheck.TrueValue = true;
            overPaymentCheck.Name = "overPaymentSelect";
            overPaymentCheck.ReadOnly = true;
            overPaymentCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            overPaymentCheck.Width = 25;
            overPaymentCheck.MinimumWidth = 25;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_overPayment.Columns.Insert(0, overPaymentCheck);
            grid_overPayment.CellContentClick += new DataGridViewCellEventHandler(overPaymentSelect);

            grid_overPayment.Columns[1].Name = "No.";
            grid_overPayment.Columns[1].ReadOnly = true;
            grid_overPayment.Columns[1].Width = 80;
            grid_overPayment.Columns[1].MinimumWidth = 80;
            grid_overPayment.Columns[1].DataPropertyName = "NUM_0";

            grid_overPayment.Columns[2].Name = "Amt";
            grid_overPayment.Columns[2].ReadOnly = true;
            grid_overPayment.Columns[2].Width = 50;
            grid_overPayment.Columns[2].MinimumWidth = 50;
            grid_overPayment.Columns[2].DefaultCellStyle.Format = "N2";
            grid_overPayment.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_overPayment.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_overPayment.Columns[2].DataPropertyName = "CreditAmount";

            grid_overPayment.Columns[3].Name = "Net Amount";
            grid_overPayment.Columns[3].ReadOnly = false;
            grid_overPayment.Columns[3].Width = 70;
            grid_overPayment.Columns[3].MinimumWidth = 70;
            grid_overPayment.Columns[3].DefaultCellStyle.Format = "N2";
            grid_overPayment.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_overPayment.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_overPayment.Columns[3].DataPropertyName = "NetAmount";

            grid_overPayment.Columns[4].Name = "Date";
            grid_overPayment.Columns[4].ReadOnly = true;
            grid_overPayment.Columns[4].Width = 75;
            grid_overPayment.Columns[4].MinimumWidth = 75;
            grid_overPayment.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_overPayment.Columns[4].DataPropertyName = "ACCDAT_0";

            grid_overPayment.Columns[5].Name = "Customer";
            grid_overPayment.Columns[5].Visible = false;
            grid_overPayment.Columns[5].ReadOnly = true;
            grid_overPayment.Columns[5].Width = 80;
            grid_overPayment.Columns[5].DataPropertyName = "BPR_0";

            grid_overPayment.Columns[6].Name = "Order No.";
            grid_overPayment.Columns[6].Visible = false;
            grid_overPayment.Columns[6].ReadOnly = true;
            grid_overPayment.Columns[6].Width = 80;
            grid_overPayment.Columns[6].MinimumWidth = 80;
            grid_overPayment.Columns[6].DataPropertyName = "ORIDOCNUM_0";

            grid_overPayment.Columns[7].Name = "Memo";
            //grid_overPayment.Columns[7].Visible = false;
            grid_overPayment.Columns[7].ReadOnly = true;
            grid_overPayment.Columns[7].Width = 120;
            grid_overPayment.Columns[7].MinimumWidth = 120;
            grid_overPayment.Columns[7].DataPropertyName = "DES_0";
            
            //grid font size custom
            grid_overPayment.RowTemplate.Height = 20;
            grid_overPayment.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_overPayment.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_overPayment.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void overPaymentSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Ready check box click
            {
                if (Convert.ToBoolean(grid_overPayment.Rows[e.RowIndex].Cells["overPaymentSelect"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                {
                    grid_overPayment.Rows[e.RowIndex].Cells["overPaymentSelect"].Value = true;
                    grid_overPayment.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                    grid_overPayment.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else // uncheck 했을 때
                {
                    grid_overPayment.Rows[e.RowIndex].Cells["overPaymentSelect"].Value = false;
                    grid_overPayment.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    grid_overPayment.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }

                for (int i = 0; i < grid_overPayment.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_overPayment.Rows[i].Cells["overPaymentSelect"].EditedFormattedValue) == true)
                    {
                        grid_overPayment.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DimGray;
                        grid_overPayment.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                    }
                    else
                    {
                        grid_overPayment.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightGray;
                        grid_overPayment.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;
                    }
                }

                calculate();
            }
        }

        private void grid_netSettlementHistory_Init()
        {
            grid_netSettlementHistory.AutoGenerateColumns = false;
            grid_netSettlementHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_netSettlementHistory.ColumnCount = 3;
            
            grid_netSettlementHistory.Columns[0].Name = "Date";
            grid_netSettlementHistory.Columns[0].ReadOnly = true;
            grid_netSettlementHistory.Columns[0].Width = 75;
            grid_netSettlementHistory.Columns[0].MinimumWidth = 75;
            grid_netSettlementHistory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_netSettlementHistory.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_netSettlementHistory.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_netSettlementHistory.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_netSettlementHistory.Columns[0].DataPropertyName = "NSDate";

            grid_netSettlementHistory.Columns[1].Name = "Net Settlement Number";
            grid_netSettlementHistory.Columns[1].ReadOnly = true;
            grid_netSettlementHistory.Columns[1].Width = 100;
            grid_netSettlementHistory.Columns[1].MinimumWidth = 100;
            grid_netSettlementHistory.Columns[1].DataPropertyName = "NSNumber";

            grid_netSettlementHistory.Columns[2].Name = "Net Settlement Invoice Number";
            grid_netSettlementHistory.Columns[2].ReadOnly = true;
            grid_netSettlementHistory.Columns[2].Width = 120;
            grid_netSettlementHistory.Columns[2].MinimumWidth = 120;
            grid_netSettlementHistory.Columns[2].DefaultCellStyle.Format = "N2";
            grid_netSettlementHistory.Columns[2].DataPropertyName = "NSInvoiceNumber";

            DataGridViewButtonColumn reverseButton = new DataGridViewButtonColumn();
            reverseButton.Width = 60;
            reverseButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            reverseButton.Name = "Reverse";
            reverseButton.Text = "Reverse";
            reverseButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            reverseButton.UseColumnTextForButtonValue = true;
            if (grid_netSettlementHistory.Columns["Reverse"] == null)
            {
                grid_netSettlementHistory.Columns.Insert(3, reverseButton);
            }

            //grid font size custom
            grid_netSettlementHistory.RowTemplate.Height = 20;
            grid_netSettlementHistory.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_netSettlementHistory.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_netSettlementHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_netSettlementDetail_Init()
        {
            grid_netSettlementDetail.AutoGenerateColumns = false;
            grid_netSettlementDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_netSettlementDetail.ColumnCount = 3;

            grid_netSettlementDetail.Columns[0].Name = "Type";
            grid_netSettlementDetail.Columns[0].ReadOnly = true;
            grid_netSettlementDetail.Columns[0].Width = 90;
            grid_netSettlementDetail.Columns[0].MinimumWidth = 90;
            grid_netSettlementDetail.Columns[0].DataPropertyName = "NSType";

            grid_netSettlementDetail.Columns[1].Name = "Number";
            grid_netSettlementDetail.Columns[1].ReadOnly = true;
            grid_netSettlementDetail.Columns[1].Width = 100;
            grid_netSettlementDetail.Columns[1].MinimumWidth = 100;
            grid_netSettlementDetail.Columns[1].DataPropertyName = "NSCreditNumber";

            grid_netSettlementDetail.Columns[2].Name = "Amount";
            grid_netSettlementDetail.Columns[2].ReadOnly = true;
            grid_netSettlementDetail.Columns[2].Width = 90;
            grid_netSettlementDetail.Columns[2].MinimumWidth = 90;
            grid_netSettlementDetail.Columns[2].DefaultCellStyle.Format = "N2";
            grid_netSettlementDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_netSettlementDetail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_netSettlementDetail.Columns[2].DataPropertyName = "NSCreditAmount";
            
            //grid font size custom
            grid_netSettlementDetail.RowTemplate.Height = 20;
            grid_netSettlementDetail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_netSettlementDetail.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_netSettlementDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }


        private void refresh()
        {
            //MessageBox.Show("refresh");
            
            grid_invoice.DataSource = null;
            grid_credit.DataSource = null;
            grid_return.DataSource = null;
            grid_netSettlementHistory.DataSource = null;
            
            this.grid_invoice.Rows.Clear();
            this.grid_credit.Rows.Clear();
            this.grid_return.Rows.Clear();
            this.grid_netSettlementHistory.Rows.Clear();
            
            txt_invoice.Text = "";
            txt_credit.Text = "";
            txt_return.Text = "";
            
            //connSalesOrder.sp_PAYMENTT_HEADER(grid_payment, cbox_customer.Text, "");
            connSalesOrder.sp_PAYMENT_INVOICE(grid_invoice, cbo_customer.Text, "");
            connSalesOrder.sp_PAYMENT_CREDIT(grid_credit, cbo_customer.Text);
            connSalesOrder.sp_PAYMENT_RETURN(grid_return, cbo_customer.Text);
            connSalesOrder.sp_PAYMENT_OVERPAYMENT(grid_overPayment, cbo_customer.Text);
            connSalesOrder.sp_NS_HISTORY(grid_netSettlementHistory, cbo_customer.Text);
            //connSalesOrder.sp_PAYMENT_PaidCashCheck(grid_paidCashCheck, cbox_customer.Text.ToString().Trim());

            txt_invoice.Text = "0";
            txt_credit.Text = "0";
            txt_return.Text = "0";
            txt_invoice.Text = "0";

            txt_invoiceAmount.Text = "0";
            txt_creditTotal.Text = "0";
            txt_netSettleAmount.Text = "0";

            txt_customerID.Text = cbo_customer.Text.Trim();

            calculate();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void calculate()
        {

            //selected invoice total (only 1 invoice)
            Decimal CheckedTotalInvoiceAmount = 0;

            for (int i = 0; i < grid_invoice.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_invoice.Rows[i].Cells["invoiceSelect"].EditedFormattedValue) == true)
                {
                    Decimal Amount = Convert.ToDecimal(grid_invoice.Rows[i].Cells["Net Amount"].Value.ToString());
                    CheckedTotalInvoiceAmount = CheckedTotalInvoiceAmount + Amount;
                }
            }

            txt_invoice.Text = CheckedTotalInvoiceAmount.ToString("N2");
            txt_invoiceAmount.Text = CheckedTotalInvoiceAmount.ToString("N2");

            //selected credit total, count (multiple)
            Decimal CheckedTotalCreditAmount = 0;
            Decimal CheckedTotalCreditCount = 0;
            for (int i = 0; i < grid_credit.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_credit.Rows[i].Cells["CreditSelect"].EditedFormattedValue) == true)
                {
                    Decimal Amount = Convert.ToDecimal(grid_credit.Rows[i].Cells["Net Amount"].Value.ToString());
                    CheckedTotalCreditAmount = CheckedTotalCreditAmount + Amount;

                    //체크된 오더의 갯수 구하기
                    CheckedTotalCreditCount = CheckedTotalCreditCount + 1;
                }
            }

            txt_credit.Text = CheckedTotalCreditAmount.ToString("N2");


            //selected return credit total, count (multiple)
            Decimal CheckedTotalReturnAmount = 0;
            Decimal CheckedTotalReturnCount = 0;
            for (int i = 0; i < grid_return.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_return.Rows[i].Cells["returnSelect"].EditedFormattedValue) == true)
                {
                    Decimal Amount = Convert.ToDecimal(grid_return.Rows[i].Cells["Net Amount"].Value.ToString());
                    CheckedTotalReturnAmount = CheckedTotalReturnAmount + Amount;

                    CheckedTotalReturnCount = CheckedTotalReturnCount + 1;
                }
            }
            txt_return.Text = CheckedTotalReturnAmount.ToString("N2");

            //selected over payment total, count (multiple)
            Decimal CheckedTotalOverPaymentAmount = 0;
            Decimal CheckedTotalOverPaymentCount = 0;
            for (int i = 0; i < grid_overPayment.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_overPayment.Rows[i].Cells["overPaymentSelect"].EditedFormattedValue) == true)
                {
                    Decimal Amount = Convert.ToDecimal(grid_overPayment.Rows[i].Cells["Net Amount"].Value.ToString());
                    CheckedTotalOverPaymentAmount = CheckedTotalOverPaymentAmount + Amount;

                    CheckedTotalOverPaymentCount = CheckedTotalOverPaymentCount + 1;
                }
            }
            txt_overPayment.Text = CheckedTotalOverPaymentAmount.ToString("N2");

            //credit + return credit total
            txt_creditTotal.Text = (CheckedTotalCreditAmount + CheckedTotalReturnAmount + CheckedTotalOverPaymentAmount).ToString("N2");

            //get Net settlement amount
            txt_netSettleAmount.Text = (CheckedTotalInvoiceAmount - (CheckedTotalCreditAmount + CheckedTotalReturnAmount + CheckedTotalOverPaymentAmount)).ToString("N2");
        }

 

        private void grid_credit_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Decimal CreditAmount = Convert.ToDecimal(grid_credit.Rows[e.RowIndex].Cells["Amt"].Value.ToString());
            Decimal CreditNetAmount = Convert.ToDecimal(grid_credit.Rows[e.RowIndex].Cells["Net Amount"].Value.ToString());
            if(CreditAmount < CreditNetAmount || CreditNetAmount == 0)
            {
                grid_credit.Rows[e.RowIndex].Cells["Net Amount"].Value = CreditAmount;
            }
            calculate();
        }

        private void grid_return_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Decimal ReturnCreditAmount = Convert.ToDecimal(grid_return.Rows[e.RowIndex].Cells["Amt"].Value.ToString());
            Decimal ReturnCreditNetAmount = Convert.ToDecimal(grid_return.Rows[e.RowIndex].Cells["Net Amount"].Value.ToString());
            if (ReturnCreditAmount < ReturnCreditNetAmount || ReturnCreditNetAmount == 0)
            {
                grid_return.Rows[e.RowIndex].Cells["Net Amount"].Value = ReturnCreditAmount;
            }
            calculate();
        }

        private void grid_overPayment_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Decimal OverPaymentAmount = Convert.ToDecimal(grid_overPayment.Rows[e.RowIndex].Cells["Amt"].Value.ToString());
            Decimal OverPaymentNetAmount = Convert.ToDecimal(grid_overPayment.Rows[e.RowIndex].Cells["Net Amount"].Value.ToString());
            if (OverPaymentAmount < OverPaymentNetAmount || OverPaymentNetAmount == 0)
            {
                grid_overPayment.Rows[e.RowIndex].Cells["Net Amount"].Value = OverPaymentAmount;
            }
            calculate();
        }                                                                                                                                        

        private void btn_posting_Click(object sender, EventArgs e)
        {
            if (GATE.userID != "ADMIN" && txt_customerID.Text == "")
            {
                MessageBox.Show("Please select a customer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connSalesOrder.sp_WriteOff_TempCheck(SelectedInvoiceNumber) == "1")
            {
                MessageBox.Show("No : " + SelectedInvoiceNumber.ToString() + ", This number is in 'WRITE-OFF' list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Decimal NetSettlementAmount = Convert.ToDecimal(txt_netSettleAmount.Text.Trim());
            if(NetSettlementAmount < 0)
            {
                MessageBox.Show("Net Settlement Amount cannot be less than 0.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); //NetSettlementAmount < 0
                return;
            }

            Decimal InvoiceAmount = Convert.ToDecimal(txt_invoiceAmount.Text.Trim());
            Decimal CreditTotalAmount = Convert.ToDecimal(txt_creditTotal.Text.Trim());
            if (InvoiceAmount == 0)
            {
                MessageBox.Show("Invoice Amount cannot be 0.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (CreditTotalAmount == 0)
            {
                MessageBox.Show("Please choose at least one credit, return credit or overpayment.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            


            else
            {
                //DialogResult dialogResult = MessageBox.Show("Posting?"
                //                                    , "Confirming", MessageBoxButtons.YesNo);

                //if (dialogResult == DialogResult.Yes)
                //{

                //0.get a net settlement number (NS Number)========================================================
                String NewNSNumber = connSalesOrder.sp_GET_NewNSNumber();
                if (!NewNSNumber.Contains("NS"))
                {
                    MessageBox.Show("Please try again. (Error code: " + NewNSNumber + ")"
                                                    , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //=================================================================================================


                //1.sinvoice (BASDEP_0 에 크래딧만큼 Amount 추가)========================
                Decimal CreditTotal = Convert.ToDecimal(txt_creditTotal.Text.Trim());
                connSalesOrder.sp_NS_SINVOICE(SelectedInvoiceNumber, CreditTotal);
                //======================================================================

                //2.NET SETTLEMENT ============================================
                //--CREDIT       , NS123456789, INV123456, $100
                for (int i = 0; i < grid_credit.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_credit.Rows[i].Cells["creditSelect"].EditedFormattedValue) == true)
                    {
                        String CreditNumber = grid_credit.Rows[i].Cells["No."].Value.ToString().Trim();
                        Decimal CreditAmount = Convert.ToDecimal(grid_credit.Rows[i].Cells["Net Amount"].Value.ToString());
                        int Type = Convert.ToInt32(grid_credit.Rows[i].Cells["Type"].Value.ToString());
                        connSalesOrder.sp_NS_INSERT(NewNSNumber, SelectedInvoiceNumber, "Credit", Type, CreditNumber, CreditAmount);
                    }
                }
                //--RETURN CREDIT, NS123456789, INV123456, $30
                for (int i = 0; i < grid_return.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_return.Rows[i].Cells["returnSelect"].EditedFormattedValue) == true)
                    {
                        String ReturnCreditNumber = grid_return.Rows[i].Cells["No."].Value.ToString().Trim();
                        Decimal ReturnCreditAmount = Convert.ToDecimal(grid_return.Rows[i].Cells["Net Amount"].Value.ToString());
                        connSalesOrder.sp_NS_INSERT(NewNSNumber, SelectedInvoiceNumber, "ReturnCredit", 0, ReturnCreditNumber, ReturnCreditAmount);
                    }
                }
                //--OVER PAYMENT, NS123456789, INV123456, $30
                for (int i = 0; i < grid_overPayment.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_overPayment.Rows[i].Cells["overPaymentSelect"].EditedFormattedValue) == true)
                    {
                        String OverPaymentNumber = grid_overPayment.Rows[i].Cells["No."].Value.ToString().Trim();
                        Decimal OverPaymentAmount = Convert.ToDecimal(grid_overPayment.Rows[i].Cells["Net Amount"].Value.ToString());
                        connSalesOrder.sp_NS_INSERT(NewNSNumber, SelectedInvoiceNumber, "OverPayment", 0, OverPaymentNumber, OverPaymentAmount);
                    }
                }
                //==============================================================

                //3.CREDIT 집계 테이블==========================================================================
                //Header: SCM123456, $300(Original), $200(remaining)
                //Detail: SCM123456, $100(used), INV123456(used invoice), NS123456789(NS Number)
                for (int i = 0; i < grid_credit.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_credit.Rows[i].Cells["creditSelect"].EditedFormattedValue) == true)
                    {
                        String CreditNumber = grid_credit.Rows[i].Cells["No."].Value.ToString().Trim();
                        Decimal CreditAmount = Convert.ToDecimal(grid_credit.Rows[i].Cells["Net Amount"].Value.ToString());
                        connSalesOrder.sp_NS_CREDIT(NewNSNumber, SelectedInvoiceNumber, "Credit", CreditNumber, CreditAmount);
                    }
                }
                for (int i = 0; i < grid_return.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_return.Rows[i].Cells["returnSelect"].EditedFormattedValue) == true)
                    {
                        String ReturnCreditNumber = grid_return.Rows[i].Cells["No."].Value.ToString().Trim();
                        Decimal ReturnCreditAmount = Convert.ToDecimal(grid_return.Rows[i].Cells["Net Amount"].Value.ToString());
                        connSalesOrder.sp_NS_CREDIT(NewNSNumber, SelectedInvoiceNumber, "ReturnCredit", ReturnCreditNumber, ReturnCreditAmount);
                    }
                }
                for (int i = 0; i < grid_overPayment.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_overPayment.Rows[i].Cells["overPaymentSelect"].EditedFormattedValue) == true)
                    {
                        String OverPaymentNumber = grid_overPayment.Rows[i].Cells["No."].Value.ToString().Trim();
                        Decimal OverPaymentAmount = Convert.ToDecimal(grid_overPayment.Rows[i].Cells["Net Amount"].Value.ToString());
                        connSalesOrder.sp_NS_CREDIT(NewNSNumber, SelectedInvoiceNumber, "OverPayment", OverPaymentNumber, OverPaymentAmount);
                    }
                }

                //=============================================================================================

                String CompanyName = cbo_company.Text.Trim();
                String CustomerID = cbo_customer.Text.Trim();
                    

                //4.Accounting Journal===========================================================
                //42000(1), 12100(-1)AR.
                for (int i = 0; i < grid_credit.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_credit.Rows[i].Cells["creditSelect"].EditedFormattedValue) == true)
                    {
                        String CreditNumber = grid_credit.Rows[i].Cells["No."].Value.ToString().Trim();
                        Decimal CreditAmount = Convert.ToDecimal(grid_credit.Rows[i].Cells["Net Amount"].Value.ToString());
                        connSalesOrder.sp_NS_AccountingJournal(CompanyName, CustomerID, NewNSNumber, SelectedInvoiceNumber, "Credit", CreditNumber, CreditAmount);
                    }
                }
                for (int i = 0; i < grid_return.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_return.Rows[i].Cells["returnSelect"].EditedFormattedValue) == true)
                    {
                        String ReturnCreditNumber = grid_return.Rows[i].Cells["No."].Value.ToString().Trim();
                        Decimal ReturnCreditAmount = Convert.ToDecimal(grid_return.Rows[i].Cells["Net Amount"].Value.ToString());
                        connSalesOrder.sp_NS_AccountingJournal(CompanyName, CustomerID, NewNSNumber, SelectedInvoiceNumber, "ReturnCredit", ReturnCreditNumber, ReturnCreditAmount);
                    }
                }
                for (int i = 0; i < grid_overPayment.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_overPayment.Rows[i].Cells["overPaymentSelect"].EditedFormattedValue) == true)
                    {
                        String OverPaymentNumber = grid_overPayment.Rows[i].Cells["No."].Value.ToString().Trim();
                        Decimal OverPaymentAmount = Convert.ToDecimal(grid_overPayment.Rows[i].Cells["Net Amount"].Value.ToString());
                        connSalesOrder.sp_NS_AccountingJournal(CompanyName, CustomerID, NewNSNumber, SelectedInvoiceNumber, "OverPayment", OverPaymentNumber, OverPaymentAmount);
                    }
                }
                //===============================================================================

                refresh();
                
            }
        }

        private void cbo_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_customerID.Text = "";
            txt_invoiceAmount.Text = "0.00";
            txt_creditTotal.Text = "0.00";
            txt_netSettleAmount.Text = "0.00";

            grid_invoice.DataSource = null;
            grid_credit.DataSource = null;
            grid_return.DataSource = null;
            grid_overPayment.DataSource = null;
        }

        private void cbo_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cbox_customer_DroppedDown();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                refresh();
            }
        }

        private void grid_netSettlementHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0) // Delete button
            {
                //String InvoiceNumber = grid_netSettlementHistory.Rows[e.RowIndex].Cells["Net Settlement Invoice Number"].Value.ToString().Trim();
                //String NSReverseCheck = connSalesOrder.sp_NS_REVERSECHECK(InvoiceNumber);
                ////MessageBox.Show(DEPOSITSLIPCHECK);
                //if (NSReverseCheck != "OK")
                //{
                   
                //    MessageBox.Show("Can't process reverse net settlement.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //    return;
                    

                //}

                //MessageBox.Show(e.RowIndex.ToString().Trim());
                DialogResult dialogResult = MessageBox.Show("Are you sure reverse the net settlement?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    String NSNumber = grid_netSettlementHistory.Rows[e.RowIndex].Cells["Net Settlement Number"].Value.ToString().Trim();

                    connSalesOrder.sp_NS_REVERSE(NSNumber);


                    //grid_creditMemo.Rows.RemoveAt(e.RowIndex);

                    refresh();
                    MessageBox.Show("Done.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void grid_netSettlementHistory_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String NSNumber = grid_netSettlementHistory.Rows[e.RowIndex].Cells["Net Settlement Number"].Value.ToString().Trim();
            //MessageBox.Show(NSNumber);
            connSalesOrder.sp_NS_HISTORY_DETAIL(grid_netSettlementDetail, NSNumber);
            
        }

        private void btn_checkingNS_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CheckingNS))
                {
                    form.Activate();
                    return;
                }
            }
            CheckingNS checkingNS = new CheckingNS();
            checkingNS.Show();
        }
    }
}

