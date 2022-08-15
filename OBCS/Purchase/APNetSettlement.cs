using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Purchase
{
    public partial class APNetSettlement : Form
    {
        public APNetSettlement()
        {
            InitializeComponent();

            connPO.cbo_CompanyName(cbo_company);
            cbo_company.Text = "B.C.S.INTERNATIONAL CORP.";
            cbo_company.Enabled = false;

            cbo_supplierID.Items.Clear();
            connPO.sp_GET_SUPPLIER(cbo_supplierID);
            

            txt_invoiceAmount.Text = "0.00";
            txt_creditTotal.Text = "0.00";
            txt_debitTotal.Text = "0.00";
            txt_netSettleAmount.Text = "0.00";

            grid_netSettlementHistory_Init();
            grid_netSettlementDetail_Init();
            grid_invoice_Init();
            grid_credit_Init();
            grid_debit_Init();

            grid_credit.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            grid_debit.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

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
            grid_netSettlementHistory.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy";
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

        


        private void grid_invoice_Init()
        {
            grid_invoice.AutoGenerateColumns = false;
            grid_invoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_invoice.ColumnCount = 9;

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

            grid_invoice.Columns[1].Name = "Supplier ID";
            grid_invoice.Columns[1].ReadOnly = true;
            grid_invoice.Columns[1].Width = 90;
            grid_invoice.Columns[1].MinimumWidth = 90;
            grid_invoice.Columns[1].DataPropertyName = "BPR_0";

            grid_invoice.Columns[2].Name = "Site";
            grid_invoice.Columns[2].ReadOnly = true;
            grid_invoice.Columns[2].Width = 90;
            grid_invoice.Columns[2].MinimumWidth = 90;
            grid_invoice.Columns[2].DataPropertyName = "FCY_0";

            grid_invoice.Columns[3].Name = "PO Number";
            grid_invoice.Columns[3].ReadOnly = true;
            grid_invoice.Columns[3].Width = 100;
            grid_invoice.Columns[3].MinimumWidth = 100;
            grid_invoice.Columns[3].DataPropertyName =     "POHNUM_0";

            grid_invoice.Columns[4].Name = "REC Number";
            grid_invoice.Columns[4].ReadOnly = true;
            grid_invoice.Columns[4].Width = 100;
            grid_invoice.Columns[4].MinimumWidth = 100;
            grid_invoice.Columns[4].DataPropertyName = "ORIDOCNUM_0";

            grid_invoice.Columns[5].Name = "PINV Number";
            grid_invoice.Columns[5].ReadOnly = true;
            grid_invoice.Columns[5].Width = 100;
            grid_invoice.Columns[5].MinimumWidth = 100;
            grid_invoice.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_invoice.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_invoice.Columns[5].DataPropertyName = "NUM_0";

            grid_invoice.Columns[6].Name = "Invoice Date";
            grid_invoice.Columns[6].ReadOnly = true;
            grid_invoice.Columns[6].Width = 75;
            grid_invoice.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_invoice.Columns[6].DataPropertyName = "ACCDAT_0";

            grid_invoice.Columns[7].Name = "Original Amount";
            grid_invoice.Columns[7].ReadOnly = true;
            grid_invoice.Columns[7].Width = 70;
            grid_invoice.Columns[7].MinimumWidth = 70;
            grid_invoice.Columns[7].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[7].DataPropertyName = "OriginalAmount";
           
            grid_invoice.Columns[8].Name = "Net Amount";
            grid_invoice.Columns[8].ReadOnly = true;
            grid_invoice.Columns[8].Width = 70;
            grid_invoice.Columns[8].MinimumWidth = 70;
            grid_invoice.Columns[8].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[8].DataPropertyName = "AMTATI_0";

            grid_invoice.Columns[9].Name = "Payment Term";
            grid_invoice.Columns[9].ReadOnly = true;
            grid_invoice.Columns[9].Width = 120;
            grid_invoice.Columns[9].MinimumWidth = 120;
            grid_invoice.Columns[9].DataPropertyName = "PTE_0";

            //grid font size custom
            grid_invoice.RowTemplate.Height = 20;
            grid_invoice.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_invoice.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
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
                    SelectedInvoiceNumber = grid_invoice.Rows[e.RowIndex].Cells["PINV Number"].Value.ToString().Trim();
                    grid_invoice.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                    grid_invoice.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;

                    //check
                    Decimal InvoiceOriginalAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["Original Amount"].Value.ToString());
                    Decimal InvoiceNetAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["Net Amount"].Value.ToString());
                    String InvoiceNumber = grid_invoice.Rows[e.RowIndex].Cells["PINV Number"].Value.ToString().Trim();

                    String selectedPONumber = grid_invoice.Rows[e.RowIndex].Cells["PO Number"].Value.ToString().Trim();
                    if (selectedPONumber == "")
                    {
                        calculate();
                        return;
                    }
                    
                    for (int i = 0; i < grid_credit.Rows.Count; i++)
                    {
                        if (grid_credit.Rows[i].Cells["PO Number"].Value.ToString() == grid_invoice.Rows[e.RowIndex].Cells["PO Number"].Value.ToString())
                        {
                            grid_credit.Rows[i].Cells["CreditSelect"].Value = true;
                            grid_credit.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                            grid_credit.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }

                    for (int i = 0; i < grid_debit.Rows.Count; i++)
                    {
                        if (grid_debit.Rows[i].Cells["PO Number"].Value.ToString() == grid_invoice.Rows[e.RowIndex].Cells["PO Number"].Value.ToString())
                        {
                            grid_debit.Rows[i].Cells["debitSelect"].Value = true;
                            grid_debit.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                            grid_debit.Rows[i].DefaultCellStyle.ForeColor = Color.White;
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
                        grid_credit.Rows[i].Cells["Net Amount"].Value = grid_credit.Rows[i].Cells["Amount"].Value;
                        //}
                    }

                    for (int i = 0; i < grid_debit.Rows.Count; i++)
                    {
                        //if (grid_debit.Rows[i].Cells["OrderID"].Value.ToString() == grid_invoice.Rows[e.RowIndex].Cells["Order No."].Value.ToString())
                        //{
                        grid_debit.Rows[i].Cells["debitSelect"].Value = false;
                        grid_debit.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        grid_debit.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                        grid_debit.Rows[i].Cells["Net Amount"].Value = grid_debit.Rows[i].Cells["Amount"].Value;
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

            for (int i = 0; i < grid_debit.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_debit.Rows[i].Cells["debitSelect"].EditedFormattedValue) == true)
                {
                    grid_debit.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DimGray;
                    grid_debit.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else
                {
                    grid_debit.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightGray;
                    grid_debit.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
            calculate();
        }

        private void grid_credit_Init()
        {
            grid_credit.AutoGenerateColumns = false;
            grid_credit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_credit.ColumnCount = 9;

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

            grid_credit.Columns[1].Name = "Credit Number";
            grid_credit.Columns[1].ReadOnly = true;
            grid_credit.Columns[1].Width = 80;
            grid_credit.Columns[1].MinimumWidth = 80;
            grid_credit.Columns[1].DataPropertyName = "Number";

            grid_credit.Columns[2].Name = "Amount";
            grid_credit.Columns[2].ReadOnly = true;
            grid_credit.Columns[2].Width = 50;
            grid_credit.Columns[2].MinimumWidth = 50;
            grid_credit.Columns[2].DefaultCellStyle.Format = "N2";
            grid_credit.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_credit.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_credit.Columns[2].DataPropertyName = "Amount";

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
            grid_credit.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_credit.Columns[4].DataPropertyName = "CreateTime";

            grid_credit.Columns[5].Name = "Supplier ID";
            grid_credit.Columns[5].Visible = false;
            grid_credit.Columns[5].ReadOnly = true;
            grid_credit.Columns[5].Width = 80;
            grid_credit.Columns[5].DataPropertyName = "SuppplierID";

            grid_credit.Columns[6].Name = "PO Number";
            //grid_credit.Columns[6].Visible = false;
            grid_credit.Columns[6].ReadOnly = true;
            grid_credit.Columns[6].Width = 80;
            grid_credit.Columns[6].MinimumWidth = 80;
            grid_credit.Columns[6].DataPropertyName = "InvoiceNumber";

            grid_credit.Columns[7].Name = "Memo";
            //grid_credit.Columns[7].Visible = false;
            grid_credit.Columns[7].ReadOnly = true;
            grid_credit.Columns[7].Width = 120;
            grid_credit.Columns[7].MinimumWidth = 120;
            grid_credit.Columns[7].DataPropertyName = "PMemo";

            grid_credit.Columns[8].Name = "Type";
            grid_credit.Columns[8].ReadOnly = true;
            grid_credit.Columns[8].Width = 100;
            grid_credit.Columns[8].MinimumWidth = 100;
            grid_credit.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_credit.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_credit.Columns[8].DataPropertyName = "CreditDebit";

            grid_credit.Columns[9].Name = "Reason Code";
            grid_credit.Columns[9].ReadOnly = true;
            grid_credit.Columns[9].Width = 60;
            grid_credit.Columns[9].MinimumWidth = 60;
            grid_credit.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_credit.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_credit.Columns[9].DataPropertyName = "ReasonCode";

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

        private void grid_debit_Init()
        {
            grid_debit.AutoGenerateColumns = false;
            grid_debit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_debit.ColumnCount = 9;

            DataGridViewCheckBoxColumn debitCheck = new DataGridViewCheckBoxColumn();
            debitCheck.HeaderText = "X";
            debitCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            debitCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            debitCheck.FalseValue = false;
            debitCheck.TrueValue = true;
            debitCheck.Name = "debitSelect";
            debitCheck.ReadOnly = true;
            debitCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            debitCheck.Width = 25;
            debitCheck.MinimumWidth = 25;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_debit.Columns.Insert(0, debitCheck);
            grid_debit.CellContentClick += new DataGridViewCellEventHandler(debitSelect);

            grid_debit.Columns[1].Name = "Debit Number";
            grid_debit.Columns[1].ReadOnly = true;
            grid_debit.Columns[1].Width = 80;
            grid_debit.Columns[1].MinimumWidth = 80;
            grid_debit.Columns[1].DataPropertyName = "Number";

            grid_debit.Columns[2].Name = "Amount";
            grid_debit.Columns[2].ReadOnly = true;
            grid_debit.Columns[2].Width = 50;
            grid_debit.Columns[2].MinimumWidth = 50;
            grid_debit.Columns[2].DefaultCellStyle.Format = "N2";
            grid_debit.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_debit.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight; 
            grid_debit.Columns[2].DataPropertyName = "Amount";

            grid_debit.Columns[3].Name = "Net Amount";
            grid_debit.Columns[3].ReadOnly = false;
            grid_debit.Columns[3].Width = 50;
            grid_debit.Columns[3].MinimumWidth = 50;
            grid_debit.Columns[3].DefaultCellStyle.Format = "N2";
            grid_debit.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_debit.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_debit.Columns[3].DataPropertyName = "NetAmount";

            grid_debit.Columns[4].Name = "Date";
            grid_debit.Columns[4].ReadOnly = true;
            grid_debit.Columns[4].Width = 75;
            grid_debit.Columns[4].MinimumWidth = 75;
            grid_debit.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_debit.Columns[4].DataPropertyName = "CreateTime";

            grid_debit.Columns[5].Name = "SupplierID";
            grid_debit.Columns[5].Visible = false;
            grid_debit.Columns[5].ReadOnly = true;
            grid_debit.Columns[5].Width = 80;
            grid_debit.Columns[5].MinimumWidth = 80;
            grid_debit.Columns[5].DataPropertyName = "SupplierID";

            grid_debit.Columns[6].Name = "PO Number";
            grid_debit.Columns[6].ReadOnly = true;
            grid_debit.Columns[6].Width = 80;
            grid_debit.Columns[6].MinimumWidth = 80;
            grid_debit.Columns[6].DataPropertyName = "InvoiceNumber";

            grid_debit.Columns[7].Name = "Memo";
            grid_debit.Columns[7].ReadOnly = true;
            grid_debit.Columns[7].Width = 120;
            grid_debit.Columns[7].MinimumWidth = 120;
            grid_debit.Columns[7].DataPropertyName = "PMemo";

            grid_debit.Columns[8].Name = "Type";
            grid_debit.Columns[8].ReadOnly = true;
            grid_debit.Columns[8].Width = 70;
            grid_debit.Columns[8].MinimumWidth = 70;
            grid_debit.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_debit.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_debit.Columns[8].DataPropertyName = "CreditDebit";

            grid_debit.Columns[9].Name = "Reason Code";
            grid_debit.Columns[9].ReadOnly = true;
            grid_debit.Columns[9].Width = 60;
            grid_debit.Columns[9].MinimumWidth = 60;
            grid_debit.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_debit.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_debit.Columns[9].DataPropertyName = "ReasonCode";

            //grid font size custom
            grid_debit.RowTemplate.Height = 20;
            grid_debit.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_debit.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_debit.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void debitSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Ready check box click
            {
                if (Convert.ToBoolean(grid_debit.Rows[e.RowIndex].Cells["debitSelect"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                {
                    grid_debit.Rows[e.RowIndex].Cells["debitSelect"].Value = true;
                    grid_debit.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                    grid_debit.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else // uncheck 했을 때
                {
                    grid_debit.Rows[e.RowIndex].Cells["debitSelect"].Value = false;
                    grid_debit.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    grid_debit.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }

                for (int i = 0; i < grid_debit.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_debit.Rows[i].Cells["debitSelect"].EditedFormattedValue) == true)
                    {
                        grid_debit.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DimGray;
                        grid_debit.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                    }
                    else
                    {
                        grid_debit.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightGray;
                        grid_debit.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;
                    }
                }
                calculate();
            }
        }

        private void refresh()
        {
            grid_invoice.DataSource = null;
            grid_credit.DataSource = null;
            grid_debit.DataSource = null;
            grid_netSettlementHistory.DataSource = null;
            grid_netSettlementDetail.DataSource = null;

            this.grid_invoice.Rows.Clear();
            this.grid_credit.Rows.Clear();
            this.grid_debit.Rows.Clear();
            this.grid_netSettlementHistory.Rows.Clear();
            this.grid_netSettlementDetail.Rows.Clear();

            txt_invoice.Text = "";
            txt_credit.Text = "";
            txt_debit.Text = "";

            String SearchSupplierID = cbo_supplierID.Text.Trim();

            ////hisory
            //connSalesOrder.sp_NS_HISTORY(grid_netSettlementHistory, cbo_customer.Text);
            ////history detail

            //invoice
            connPO.sp_PPAYMENT_INVOICE(grid_invoice, SearchSupplierID);

            //credit
            connPO.sp_PPAYMENT_CREDIT(grid_credit, SearchSupplierID);

            //debit
            connPO.sp_PPAYMENT_DEBIT(grid_debit, SearchSupplierID);

            //payment history
            connPO.sp_NS_HISTORY_AP(grid_netSettlementHistory, cbo_supplierID.Text);

            //payment detail
            
            txt_invoiceAmount.Text = "0";
            txt_creditTotal.Text = "0";
            txt_debitTotal.Text = "0";
            txt_netSettleAmount.Text = "0";

            //txt_customerID.Text = cbo_customer.Text.Trim();

            //calculate();
        }

        private void cbo_supplierID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //refresh();
            }
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
            Decimal CheckedTotalDebitAmount = 0;
            Decimal CheckedTotalDebitCount = 0;
            for (int i = 0; i < grid_debit.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_debit.Rows[i].Cells["debitSelect"].EditedFormattedValue) == true)
                {
                    Decimal Amount = Convert.ToDecimal(grid_debit.Rows[i].Cells["Net Amount"].Value.ToString());
                    CheckedTotalDebitAmount = CheckedTotalDebitAmount + Amount;

                    CheckedTotalDebitCount = CheckedTotalDebitCount + 1;
                }
            }
            txt_debit.Text = CheckedTotalDebitAmount.ToString("N2");

            //credit + return credit total
            txt_creditTotal.Text = CheckedTotalCreditAmount.ToString("N2");
            txt_debitTotal.Text = CheckedTotalDebitAmount.ToString("N2");

            //get Net settlement amount
            txt_netSettleAmount.Text = (CheckedTotalInvoiceAmount - (CheckedTotalCreditAmount - CheckedTotalDebitAmount)).ToString("N2");
        }

        private void grid_credit_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Decimal CreditAmount = Convert.ToDecimal(grid_credit.Rows[e.RowIndex].Cells["Amount"].Value.ToString());
            Decimal CreditNetAmount = Convert.ToDecimal(grid_credit.Rows[e.RowIndex].Cells["Net Amount"].Value.ToString());
            if (CreditAmount < CreditNetAmount || CreditNetAmount == 0)
            {
                grid_credit.Rows[e.RowIndex].Cells["Net Amount"].Value = CreditAmount;
            }
            calculate();
        }

        private void grid_debit_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Decimal ReturnCreditAmount = Convert.ToDecimal(grid_debit.Rows[e.RowIndex].Cells["Amount"].Value.ToString());
            Decimal ReturnCreditNetAmount = Convert.ToDecimal(grid_debit.Rows[e.RowIndex].Cells["Net Amount"].Value.ToString());
            if (ReturnCreditAmount < ReturnCreditNetAmount || ReturnCreditNetAmount == 0)
            {
                grid_debit.Rows[e.RowIndex].Cells["Net Amount"].Value = ReturnCreditAmount;
            }
            calculate();
        }

        private void btn_posting_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_invoice.RowCount; i++)
            {
                if(Convert.ToBoolean(grid_invoice.Rows[i].Cells["invoiceSelect"].EditedFormattedValue) == true)
                {
                    //posting 하는 순간의 net amount 일치하는지 확인 (다른 곳에서 페이하거나 reverse하거나 net settlement한 인보이스 확인)
                    String SelectedPINVNumber = grid_invoice.Rows[i].Cells["PINV Number"].Value.ToString();
                    Decimal SelectedNetAmount = Convert.ToDecimal(grid_invoice.Rows[i].Cells["Net Amount"].Value.ToString());
                    Decimal NetSettledAmount = connSalesOrder.sp_PPAYMENT_CheckNetSettledAmount(SelectedPINVNumber);
                    if (SelectedNetAmount != NetSettledAmount)
                    {
                        MessageBox.Show("The Invoice, " + SelectedPINVNumber + " has been updated.(Net Settled, Paid or Reversed). Please try again.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        refresh();
                        return;
                    }
                }
            }

            Decimal NetSettlementAmount = Convert.ToDecimal(txt_netSettleAmount.Text.Trim());
            if (NetSettlementAmount < 0)
            {
                MessageBox.Show("Net Settlement Amount cannot be less than 0.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); //NetSettlementAmount < 0
                return;
            }

            Decimal InvoiceAmount = Convert.ToDecimal(txt_invoiceAmount.Text.Trim());
            Decimal CreditTotalAmount = Convert.ToDecimal(txt_creditTotal.Text.Trim());
            Decimal DebitTotalAmount = Convert.ToDecimal(txt_debitTotal.Text.Trim());
            if (InvoiceAmount == 0)
            {
                MessageBox.Show("Invoice Amount cannot be 0.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (CreditTotalAmount == 0 && DebitTotalAmount == 0)
            {
                MessageBox.Show("Please choose at least one credit or debit.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                //100

                //1.pinvoice (AMTSUBJ1099_0 에 크래딧만큼 Amount 추가, BASDEP_0 에 데빗만큼 Amount 추가)===================
                Decimal CreditTotal = Convert.ToDecimal(txt_creditTotal.Text.Trim());
                Decimal DebitTotal = Convert.ToDecimal(txt_debitTotal.Text.Trim());
                connSalesOrder.sp_NS_PINVOICE(SelectedInvoiceNumber, CreditTotal, DebitTotal);
                //=======================================================================================================

                //2.NET SETTLEMENT ======================================================================================
                //--CREDIT
                for (int i = 0; i < grid_credit.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_credit.Rows[i].Cells["creditSelect"].EditedFormattedValue) == true)
                    {
                        String CreditNumber = grid_credit.Rows[i].Cells["Credit Number"].Value.ToString().Trim();
                        Decimal CreditAmount = Convert.ToDecimal(grid_credit.Rows[i].Cells["Net Amount"].Value.ToString());
                        String CreditType = grid_credit.Rows[i].Cells["Type"].Value.ToString(); //Type 4: AP Credit, Type 5: AP Term credit, Type 6: Billback Type 7: Return Credit
                        connSalesOrder.sp_NS_INSERT_AP_Credit(NewNSNumber, SelectedInvoiceNumber, CreditType, CreditNumber, CreditAmount);
                    }
                }

                //--DEBIT
                for (int i = 0; i < grid_debit.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_debit.Rows[i].Cells["debitSelect"].EditedFormattedValue) == true)
                    {
                        String DebitNumber = grid_debit.Rows[i].Cells["Debit Number"].Value.ToString().Trim();
                        Decimal DebitAmount = Convert.ToDecimal(grid_debit.Rows[i].Cells["Net Amount"].Value.ToString());
                        String DebitType = grid_debit.Rows[i].Cells["Type"].Value.ToString(); //Type 8: AP Debit
                        connSalesOrder.sp_NS_INSERT_AP_Debit(NewNSNumber, SelectedInvoiceNumber, DebitType, DebitNumber, DebitAmount);
                    }
                }
                //=======================================================================================================

                //3.CREDIT 집계 테이블================================================================================
                for (int i = 0; i < grid_credit.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_credit.Rows[i].Cells["creditSelect"].EditedFormattedValue) == true)
                    {
                        String CreditNumber = grid_credit.Rows[i].Cells["Credit Number"].Value.ToString().Trim();
                        Decimal CreditAmount = Convert.ToDecimal(grid_credit.Rows[i].Cells["Net Amount"].Value.ToString());
                        String CreditType = grid_credit.Rows[i].Cells["Type"].Value.ToString();
                        connSalesOrder.sp_NS_CREDIT_AP(NewNSNumber, SelectedInvoiceNumber, CreditType, CreditNumber, CreditAmount);
                    }
                }
                for (int i = 0; i < grid_debit.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_debit.Rows[i].Cells["debitSelect"].EditedFormattedValue) == true)
                    {
                        String DebitNumber = grid_debit.Rows[i].Cells["Debit Number"].Value.ToString().Trim();
                        Decimal DebitAmount = Convert.ToDecimal(grid_debit.Rows[i].Cells["Net Amount"].Value.ToString());
                        String DebitType = grid_debit.Rows[i].Cells["Type"].Value.ToString();
                        connSalesOrder.sp_NS_DEBIT_AP(NewNSNumber, SelectedInvoiceNumber, DebitType, DebitNumber, DebitAmount);
                    }
                }
                //========================================================================================================

                String CompanyName = cbo_company.Text.Trim();
                String SupplierID = cbo_supplierID.Text.Trim();

                //4.Accounting Journal========================================================================================
                for (int i = 0; i < grid_credit.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_credit.Rows[i].Cells["creditSelect"].EditedFormattedValue) == true)
                    {
                        String CreditNumber = grid_credit.Rows[i].Cells["Credit Number"].Value.ToString().Trim();
                        Decimal CreditAmount = Convert.ToDecimal(grid_credit.Rows[i].Cells["Net Amount"].Value.ToString());
                        String CreditType = grid_credit.Rows[i].Cells["Type"].Value.ToString();
                        connSalesOrder.sp_NS_AccountingJournal_AP_Credit(CompanyName, SupplierID, NewNSNumber, SelectedInvoiceNumber, CreditType, CreditNumber, CreditAmount);
                    }
                }
                for (int i = 0; i < grid_debit.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_debit.Rows[i].Cells["debitSelect"].EditedFormattedValue) == true)
                    {
                        String DebitNumber = grid_debit.Rows[i].Cells["Debit Number"].Value.ToString().Trim();
                        Decimal DebitAmount = Convert.ToDecimal(grid_debit.Rows[i].Cells["Net Amount"].Value.ToString());
                        String DebitType = grid_debit.Rows[i].Cells["Type"].Value.ToString();
                        connSalesOrder.sp_NS_AccountingJournal_AP_Debit(CompanyName, SupplierID, NewNSNumber, SelectedInvoiceNumber, DebitType, DebitNumber, DebitAmount);
                    }
                }
                //===============================================================================
                refresh();

                refreshPaymentResoultionReport();
            }
        }

        private void grid_netSettlementHistory_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String NSNumber = grid_netSettlementHistory.Rows[e.RowIndex].Cells["Net Settlement Number"].Value.ToString().Trim();
            //MessageBox.Show(NSNumber);
            connSalesOrder.sp_NS_HISTORY_DETAIL(grid_netSettlementDetail, NSNumber);
        }

        private void grid_netSettlementHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0) // Delete button
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure reverse the net settlement?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    String NSNumber = grid_netSettlementHistory.Rows[e.RowIndex].Cells["Net Settlement Number"].Value.ToString().Trim();
                    String InvoiceNumber = grid_netSettlementHistory.Rows[e.RowIndex].Cells["Net Settlement Invoice Number"].Value.ToString().Trim();
                    connSalesOrder.sp_NS_REVERSE_AP(NSNumber, InvoiceNumber);
                    //grid_creditMemo.Rows.RemoveAt(e.RowIndex);
                    //
                    refresh();
                    refreshPaymentResoultionReport();
                    MessageBox.Show("Done.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }//
        }

        private void refreshPaymentResoultionReport()
        {
            //update payment resolution form
            try
            {
                var mainForm = Application.OpenForms.OfType<Reports.PaymentResolution2>().FirstOrDefault();
                if (SelectedInvoiceNumber == mainForm.SelectedInvoiceNumber) { mainForm.grid_invoice_CellEnter(mainForm.selectedSender, mainForm.selectedDataGridViewCellEventArgs); }
            }
            catch { }
        }

        private void txt_poNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //search Supplier ID by PO Number
                String PONumber = "PO" + txt_poNumber.Text.Trim();
                String SupplierIDbyPONumber = connPO.GET_SupplierID_by_PONumber(PONumber);
                cbo_supplierID.Text = SupplierIDbyPONumber;
                txt_supplierID.Text = cbo_supplierID.Text.Trim();
                refresh();
                txt_poNumber.Text = "";
            }
        }

        private void txt_poNumber_Enter(object sender, EventArgs e)
        {
            lbl_PO.Visible = true;
        }

        private void txt_poNumber_Leave(object sender, EventArgs e)
        {
            lbl_PO.Visible = false;
            txt_poNumber.Text = "";
        }
    }
}
