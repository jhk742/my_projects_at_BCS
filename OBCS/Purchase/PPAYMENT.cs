using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OBCS.connSalesOrder;

namespace OBCS.Purchase
{
    public partial class PPAYMENT : Form
    {
        public PPAYMENT()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            grid_payment_Init();
            grid_paymentInfo_Init();
            grid_invoice_Init();
            grid_selectedInvoice_Init();
            grid_termCredit_Init();
            grid_selectedTermCredit_Init();
            cbo_supplierID.Items.Clear();
            connPO.cbox_getVendorID(cbo_supplierID);
            String SupplierID = cbo_supplierID.Text;
            connSalesOrder.cbo_site(cbo_site);
            connSalesOrder.cbo_bank(cbo_bank);
            cbo_paymentType.Items.Add("Automatic Check");
            cbo_paymentType.Items.Add("Manual Check");
            cbo_paymentType.Items.Add("Cash");
            cbo_paymentType.Items.Add("ACH");
            cbo_paymentType.Items.Add("Wire Transfer");
            cbo_paymentType.Text = "ACH";
            cbo_site.Text = "BCS";
            cbo_bank.Text = "WB436";
        }

        private void grid_payment_Init()
        {
            grid_payment.AutoGenerateColumns = false;
            grid_payment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_payment.ColumnCount = 7;

            grid_payment.Columns[0].Name = "Payment Number";
            grid_payment.Columns[0].ReadOnly = true;
            grid_payment.Columns[0].Width = 100;
            grid_payment.Columns[0].Width = 100;
            grid_payment.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_payment.Columns[0].DataPropertyName = "NUM_0";

            grid_payment.Columns[1].Name = "Supplier ID";
            grid_payment.Columns[1].ReadOnly = true;
            grid_payment.Columns[1].Width = 120;
            grid_payment.Columns[1].MinimumWidth = 100;
            grid_payment.Columns[1].DataPropertyName = "BPR_0";

            grid_payment.Columns[2].Name = "Site";
            grid_payment.Columns[2].ReadOnly = true;
            grid_payment.Columns[2].Width = 40;
            grid_payment.Columns[2].MinimumWidth = 40;
            grid_payment.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_payment.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_payment.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_payment.Columns[2].DataPropertyName = "FCY_0";

            grid_payment.Columns[3].Name = "Amount";
            grid_payment.Columns[3].ReadOnly = true;
            grid_payment.Columns[3].Width = 80;
            grid_payment.Columns[3].MinimumWidth = 80;
            grid_payment.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_payment.Columns[3].DefaultCellStyle.Format = "N2";
            grid_payment.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_payment.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_payment.Columns[3].DataPropertyName = "AMTCUR_0";

            grid_payment.Columns[4].Name = "Acc Date";
            grid_payment.Columns[4].ReadOnly = true;
            grid_payment.Columns[4].Width = 80;
            grid_payment.Columns[4].MinimumWidth = 80;
            grid_payment.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_payment.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_payment.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_payment.Columns[4].DataPropertyName = "ACCDAT_0";

            DataGridViewButtonColumn printButton = new DataGridViewButtonColumn();
            printButton.Width = 50;
            printButton.Name = "Print Check";
            printButton.Text = "Print";
            printButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            printButton.UseColumnTextForButtonValue = true;
            printButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            if (grid_payment.Columns["Print"] == null)
            {
                grid_payment.Columns.Insert(5, printButton);
            }

            grid_payment.Columns[6].Name = "Payment Method";
            grid_payment.Columns[6].Visible = false;
            grid_payment.Columns[6].Width = 50;
            grid_payment.Columns[6].DataPropertyName = "PAM_0";

            grid_payment.Columns[7].Name = "Check Number";
            grid_payment.Columns[7].Visible = false;
            grid_payment.Columns[7].Width = 50;
            grid_payment.Columns[7].DataPropertyName = "CHQNUM_0";

            DataGridViewButtonColumn reverseButton = new DataGridViewButtonColumn();
            reverseButton.Width = 60;
            reverseButton.Name = "Reverse";
            reverseButton.Text = "Reverse";
            reverseButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            reverseButton.UseColumnTextForButtonValue = true;
            reverseButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            if (grid_payment.Columns["Reverse"] == null)
            {
                grid_payment.Columns.Insert(6, reverseButton);
            }

            //grid font size custom
            grid_payment.RowTemplate.Height = 20;
            grid_payment.ColumnHeadersHeight = 30;
            foreach (DataGridViewColumn c in grid_payment.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_payment.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_paymentInfo_Init()
        {
            grid_paymentInfo.AutoGenerateColumns = false;
            grid_paymentInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_paymentInfo.ColumnCount = 7;

            grid_paymentInfo.Columns[0].Name = "Payment Number";
            grid_paymentInfo.Columns[0].ReadOnly = true;
            grid_paymentInfo.Columns[0].Width = 60;
            grid_paymentInfo.Columns[0].MinimumWidth = 60;
            grid_paymentInfo.Columns[0].DataPropertyName = "NUM_0";

            grid_paymentInfo.Columns[1].Name = "Supplier ID";
            grid_paymentInfo.Columns[1].ReadOnly = true;
            grid_paymentInfo.Columns[1].Width = 70;
            grid_paymentInfo.Columns[1].MinimumWidth = 70;
            grid_paymentInfo.Columns[1].DataPropertyName = "BPRLIN_0";

            grid_paymentInfo.Columns[2].Name = "Type";
            grid_paymentInfo.Columns[2].ReadOnly = true;
            grid_paymentInfo.Columns[2].Width = 50;
            grid_paymentInfo.Columns[2].MinimumWidth = 50;
            grid_paymentInfo.Columns[2].DataPropertyName = "Type";

            grid_paymentInfo.Columns[3].Name = "Ref. Number";
            grid_paymentInfo.Columns[3].ReadOnly = true;
            grid_paymentInfo.Columns[3].Width = 60;
            grid_paymentInfo.Columns[3].MinimumWidth = 60;
            grid_paymentInfo.Columns[3].DataPropertyName = "VCRNUM_0";

            grid_paymentInfo.Columns[4].Name = "PO Number";
            grid_paymentInfo.Columns[4].ReadOnly = true;
            grid_paymentInfo.Columns[4].Width = 60;
            grid_paymentInfo.Columns[4].MinimumWidth = 60;
            grid_paymentInfo.Columns[4].DataPropertyName = "PONumber";

            grid_paymentInfo.Columns[5].Name = "Supplier Doc. Number";
            grid_paymentInfo.Columns[5].ReadOnly = true;
            grid_paymentInfo.Columns[5].Width = 60;
            grid_paymentInfo.Columns[5].MinimumWidth = 60;
            grid_paymentInfo.Columns[5].DataPropertyName = "SupplierDocNumber";

            grid_paymentInfo.Columns[6].Name = "Amount";
            grid_paymentInfo.Columns[6].ReadOnly = true;
            grid_paymentInfo.Columns[6].Width = 70;
            grid_paymentInfo.Columns[6].MinimumWidth = 70;
            grid_paymentInfo.Columns[6].DefaultCellStyle.Format = "N2";
            grid_paymentInfo.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_paymentInfo.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_paymentInfo.Columns[6].DataPropertyName = "AMTLIN_0";

            //grid font size custom
            grid_paymentInfo.RowTemplate.Height = 20;
            grid_paymentInfo.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_paymentInfo.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
            }

            grid_paymentInfo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
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
            grid_invoice.Columns.Insert(0, invoiceCheck);
            grid_invoice.CellContentClick += new DataGridViewCellEventHandler(invoiceSelect);

            grid_invoice.Columns[1].Name = "Supplier ID";
            grid_invoice.Columns[1].ReadOnly = true;
            grid_invoice.Columns[1].Width = 80;
            grid_invoice.Columns[1].MinimumWidth = 80;
            grid_invoice.Columns[1].DataPropertyName = "BPR_0";

            grid_invoice.Columns[2].Name = "Receiving Site";
            grid_invoice.Columns[2].ReadOnly = true;
            grid_invoice.Columns[2].Width = 40;
            grid_invoice.Columns[2].MinimumWidth = 40;
            grid_invoice.Columns[2].DataPropertyName = "FCY_0";

            grid_invoice.Columns[3].Name = "PO Number";
            grid_invoice.Columns[3].ReadOnly = true;
            grid_invoice.Columns[3].Width = 80;
            grid_invoice.Columns[3].MinimumWidth = 80;
            grid_invoice.Columns[3].DataPropertyName = "POHNUM_0";

            grid_invoice.Columns[4].Name = "Receiving Number";
            grid_invoice.Columns[4].ReadOnly = true;
            grid_invoice.Columns[4].Width = 70;
            grid_invoice.Columns[4].MinimumWidth = 70;
            grid_invoice.Columns[4].DataPropertyName = "ORIDOCNUM_0";

            grid_invoice.Columns[5].Name = "Date";
            grid_invoice.Columns[5].ReadOnly = true;
            grid_invoice.Columns[5].Width = 70;
            grid_invoice.Columns[5].MinimumWidth = 70;
            grid_invoice.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_invoice.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_invoice.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_invoice.Columns[5].DataPropertyName = "ACCDAT_0";

            grid_invoice.Columns[6].Name = "PINV Number";
            grid_invoice.Columns[6].ReadOnly = true;
            grid_invoice.Columns[6].Width = 80;
            grid_invoice.Columns[6].MinimumWidth = 80;
            grid_invoice.Columns[6].DataPropertyName = "NUM_0";

            grid_invoice.Columns[7].Name = "Supplier Invoice Number";
            grid_invoice.Columns[7].ReadOnly = true;
            grid_invoice.Columns[7].Width = 90;
            grid_invoice.Columns[7].MinimumWidth = 90;
            grid_invoice.Columns[7].DataPropertyName = "INVREF_0";

            grid_invoice.Columns[8].Name = "Invoice Amount";
            grid_invoice.Columns[8].ReadOnly = true;
            grid_invoice.Columns[8].Width = 70;
            grid_invoice.Columns[8].MinimumWidth = 70;
            grid_invoice.Columns[8].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[8].DataPropertyName = "OriginalAmount";

            grid_invoice.Columns[9].Name = "AP Amount";
            grid_invoice.Columns[9].ReadOnly = true;
            grid_invoice.Columns[9].Width = 70;
            grid_invoice.Columns[9].MinimumWidth = 70;
            grid_invoice.Columns[9].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[9].DataPropertyName = "AMTATI_0";

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

        private void grid_selectedInvoice_Init()
        {

            grid_selectedInvoice.AutoGenerateColumns = false;
            grid_selectedInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_selectedInvoice.ColumnCount = 11;

            grid_selectedInvoice.Columns[0].Name = "Supplier ID";
            grid_selectedInvoice.Columns[0].ReadOnly = true;
            grid_selectedInvoice.Columns[0].Width = 80;
            grid_selectedInvoice.Columns[0].MinimumWidth = 80;
            grid_selectedInvoice.Columns[0].DataPropertyName = "BPR_0";

            grid_selectedInvoice.Columns[1].Name = "Site";
            grid_selectedInvoice.Columns[1].ReadOnly = true;
            grid_selectedInvoice.Columns[1].Width = 40;
            grid_selectedInvoice.Columns[1].MinimumWidth = 40;
            grid_selectedInvoice.Columns[1].DataPropertyName = "FCY_0";

            grid_selectedInvoice.Columns[2].Name = "PO Number";
            grid_selectedInvoice.Columns[2].ReadOnly = true;
            grid_selectedInvoice.Columns[2].Width = 80;
            grid_selectedInvoice.Columns[2].MinimumWidth = 80;
            grid_selectedInvoice.Columns[2].DataPropertyName = "POHNUM_0";

            grid_selectedInvoice.Columns[3].Name = "Receiving Number";
            grid_selectedInvoice.Columns[3].ReadOnly = true;
            grid_selectedInvoice.Columns[3].Width = 80;
            grid_selectedInvoice.Columns[3].MinimumWidth = 80;
            grid_selectedInvoice.Columns[3].DataPropertyName = "ORIDOCNUM_0";

            grid_selectedInvoice.Columns[4].Name = "Date";
            grid_selectedInvoice.Columns[4].ReadOnly = true;
            grid_selectedInvoice.Columns[4].Width = 70;
            grid_selectedInvoice.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_selectedInvoice.Columns[4].DataPropertyName = "ACCDAT_0";

            grid_selectedInvoice.Columns[5].Name = "PINV Number";
            grid_selectedInvoice.Columns[5].ReadOnly = true;
            grid_selectedInvoice.Columns[5].Width = 90;
            grid_selectedInvoice.Columns[5].MinimumWidth = 90;
            grid_selectedInvoice.Columns[5].DataPropertyName = "NUM_0";

            grid_selectedInvoice.Columns[6].Name = "Supplier Invoice Number";
            grid_selectedInvoice.Columns[6].ReadOnly = true;
            grid_selectedInvoice.Columns[6].Width = 90;
            grid_selectedInvoice.Columns[6].MinimumWidth = 90;
            grid_selectedInvoice.Columns[6].DataPropertyName = "INVREF_0";

            grid_selectedInvoice.Columns[7].Name = "Invoice Amount";
            grid_selectedInvoice.Columns[7].ReadOnly = true;
            grid_selectedInvoice.Columns[7].Width = 70;
            grid_selectedInvoice.Columns[7].DefaultCellStyle.Format = "N2";
            grid_selectedInvoice.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[7].DataPropertyName = "AMTATI_0";

            grid_selectedInvoice.Columns[8].Name = "Net AP Amount";
            grid_selectedInvoice.Columns[8].ReadOnly = true;
            grid_selectedInvoice.Columns[8].Width = 70;
            grid_selectedInvoice.Columns[8].DefaultCellStyle.Format = "N2";
            grid_selectedInvoice.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[8].DataPropertyName = "AMTATI_0";

            grid_selectedInvoice.Columns[9].Name = "Payment Amount";
            grid_selectedInvoice.Columns[9].Width = 70;
            grid_selectedInvoice.Columns[9].DefaultCellStyle.Format = "N2";
            grid_selectedInvoice.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[9].DataPropertyName = "AMTATI_0";

            grid_selectedInvoice.Columns[10].Name = "Amt";
            grid_selectedInvoice.Columns[10].Visible = false;
            grid_selectedInvoice.Columns[10].Width = 50;
            grid_selectedInvoice.Columns[10].MinimumWidth = 50;
            grid_selectedInvoice.Columns[10].DefaultCellStyle.Format = "N2";
            grid_selectedInvoice.Columns[10].DataPropertyName = "AMTATI_0";
            grid_selectedInvoice.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 50;
            deleteButton.MinimumWidth = 50;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_selectedInvoice.Columns["Delete"] == null)
            {
                grid_selectedInvoice.Columns.Insert(11, deleteButton);
            }
            //grid font size custom
            grid_selectedInvoice.RowTemplate.Height = 20;
            grid_selectedInvoice.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_selectedInvoice.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_selectedInvoice.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void invoiceSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Ready check box click
            {

                if (Convert.ToBoolean(grid_invoice.Rows[e.RowIndex].Cells["invoiceSelect"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                {
                    grid_invoice.Rows[e.RowIndex].Cells["invoiceSelect"].Value = true;

                    for (int i = 0; i < grid_selectedInvoice.Rows.Count; i++)
                    {
                        if (grid_selectedInvoice.Rows[i].Cells["PINV Number"].Value.ToString() == grid_invoice.Rows[e.RowIndex].Cells["PINV Number"].Value.ToString())
                        {
                            MessageBox.Show("The invoice number, " + grid_selectedInvoice.Rows[i].Cells["PINV Number"].Value.ToString() + " already in selected invoice list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    String SupplierID = grid_invoice.Rows[e.RowIndex].Cells["Supplier ID"].Value.ToString();
                    String Site = grid_invoice.Rows[e.RowIndex].Cells["Receiving Site"].Value.ToString();
                    String PONumber = grid_invoice.Rows[e.RowIndex].Cells["PO Number"].Value.ToString();
                    String ReceivingNumber = grid_invoice.Rows[e.RowIndex].Cells["Receiving Number"].Value.ToString();
                    DateTime InvoiceDate = Convert.ToDateTime(grid_invoice.Rows[e.RowIndex].Cells["Date"].Value.ToString());
                    String PINVNumber = grid_invoice.Rows[e.RowIndex].Cells["PINV Number"].Value.ToString();
                    String SupplierInvoiceNumber = grid_invoice.Rows[e.RowIndex].Cells["Supplier Invoice Number"].Value.ToString();
                    Decimal OriginalAPAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["Invoice Amount"].Value.ToString());
                    Decimal APAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["AP Amount"].Value.ToString());
                    //
                    grid_selectedInvoice.Rows.Add(new Object[] { SupplierID, Site, PONumber, ReceivingNumber, InvoiceDate, PINVNumber, SupplierInvoiceNumber, OriginalAPAmount, APAmount, APAmount, APAmount, APAmount});

                }
                else // uncheck 했을 때
                {
                    grid_invoice.Rows[e.RowIndex].Cells["invoiceSelect"].Value = false;

                    for (int i = 0; i < grid_selectedInvoice.Rows.Count; i++)
                    {
                        if (grid_selectedInvoice.Rows[i].Cells["PINV Number"].Value.ToString() == grid_invoice.Rows[e.RowIndex].Cells["PINV Number"].Value.ToString())
                        {
                            grid_selectedInvoice.Rows.RemoveAt(i);
                        }
                    }

                    //2. invoice 체크해제하면 term credit 선택해제

                    String PONumber = grid_invoice.Rows[e.RowIndex].Cells["PO Number"].Value.ToString();
                    for (int i = 0; i < grid_termCredit.Rows.Count; i++)
                    {
                        String TermCreditPONumber = grid_termCredit.Rows[i].Cells["PO Number"].Value.ToString();
                        if (TermCreditPONumber == PONumber)
                        {
                            grid_termCredit.Rows[i].Cells["termCreditSelect"].Value = false;
                        }
                    }

                    int selectedtermcreditRows = grid_selectedTermCredit.Rows.Count;
                    for (int j = 0; j < selectedtermcreditRows; j++)
                    {
                        for (int i = 0; i < grid_selectedTermCredit.Rows.Count; i++)
                        {
                            String TermCreditPONumber = grid_selectedTermCredit.Rows[i].Cells["PO Number"].Value.ToString();
                            if (TermCreditPONumber == PONumber)
                            {
                                grid_selectedTermCredit.Rows.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }

                CalculateAmount();
            }
        }

        private void grid_termCredit_Init()
        {
            grid_termCredit.AutoGenerateColumns = false;
            grid_termCredit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_termCredit.ColumnCount = 9;

            DataGridViewCheckBoxColumn termCreditCheck = new DataGridViewCheckBoxColumn();
            termCreditCheck.HeaderText = "X";
            termCreditCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            termCreditCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            termCreditCheck.FalseValue = false;
            termCreditCheck.TrueValue = true;
            termCreditCheck.Name = "termCreditSelect";
            termCreditCheck.ReadOnly = true;
            termCreditCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            termCreditCheck.Width = 25;
            termCreditCheck.MinimumWidth = 25;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_termCredit.Columns.Insert(0, termCreditCheck);
            grid_termCredit.CellContentClick += new DataGridViewCellEventHandler(termCreditSelect);

            grid_termCredit.Columns[1].Name = "Supplier ID";
            //grid_termCredit.Columns[1].Visible = false;
            grid_termCredit.Columns[1].ReadOnly = true;
            grid_termCredit.Columns[1].Width = 100;
            grid_termCredit.Columns[1].MinimumWidth = 100;
            grid_termCredit.Columns[1].DataPropertyName = "SupplierID";
            grid_termCredit.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_termCredit.Columns[2].Name = "Date";
            grid_termCredit.Columns[2].ReadOnly = true;
            grid_termCredit.Columns[2].Width = 75;
            grid_termCredit.Columns[2].MinimumWidth = 75;
            grid_termCredit.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_termCredit.Columns[2].DataPropertyName = "CreateTime";
            grid_termCredit.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_termCredit.Columns[3].Name = "PO Number";
            //grid_termCredit.Columns[3].Visible = false;
            grid_termCredit.Columns[3].ReadOnly = true;
            grid_termCredit.Columns[3].Width = 80;
            grid_termCredit.Columns[3].MinimumWidth = 80;
            grid_termCredit.Columns[3].DataPropertyName = "InvoiceNumber";
            grid_termCredit.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_termCredit.Columns[4].Name = "Credit Number";
            grid_termCredit.Columns[4].ReadOnly = true;
            grid_termCredit.Columns[4].Width = 90;
            grid_termCredit.Columns[4].MinimumWidth = 90;
            grid_termCredit.Columns[4].DataPropertyName = "Number";
            grid_termCredit.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_termCredit.Columns[5].Name = "Amount";
            grid_termCredit.Columns[5].ReadOnly = true;
            grid_termCredit.Columns[5].Visible = false;
            grid_termCredit.Columns[5].Width = 50;
            grid_termCredit.Columns[5].MinimumWidth = 50;
            grid_termCredit.Columns[5].DefaultCellStyle.Format = "N2";
            grid_termCredit.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_termCredit.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_termCredit.Columns[5].DataPropertyName = "Amount";
            grid_termCredit.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_termCredit.Columns[6].Name = "Net Amount";
            grid_termCredit.Columns[6].ReadOnly = true;
            grid_termCredit.Columns[6].Width = 70;
            grid_termCredit.Columns[6].MinimumWidth = 70;
            grid_termCredit.Columns[6].DefaultCellStyle.Format = "N2";
            grid_termCredit.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_termCredit.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_termCredit.Columns[6].DataPropertyName = "NetAmount";
            grid_termCredit.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_termCredit.Columns[7].Name = "Memo";
            //grid_termCredit.Columns[7].Visible = false;
            grid_termCredit.Columns[7].ReadOnly = true;
            grid_termCredit.Columns[7].Width = 120;
            grid_termCredit.Columns[7].MinimumWidth = 120;
            grid_termCredit.Columns[7].DataPropertyName = "PMemo";

            grid_termCredit.Columns[8].Name = "Type";
            grid_termCredit.Columns[8].ReadOnly = true;
            grid_termCredit.Columns[8].Visible = false;
            grid_termCredit.Columns[8].Width = 100;
            grid_termCredit.Columns[8].MinimumWidth = 100;
            grid_termCredit.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_termCredit.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_termCredit.Columns[8].DataPropertyName = "CreditDebit";

            grid_termCredit.Columns[9].Name = "Reason Code";
            grid_termCredit.Columns[9].ReadOnly = true;
            grid_termCredit.Columns[9].Visible = false;
            grid_termCredit.Columns[9].Width = 60;
            grid_termCredit.Columns[9].MinimumWidth = 60;
            grid_termCredit.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_termCredit.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_termCredit.Columns[9].DataPropertyName = "ReasonCode";

            //grid font size custom
            grid_termCredit.RowTemplate.Height = 20;
            grid_termCredit.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_termCredit.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_termCredit.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void termCreditSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Ready check box click
            {
                if (Convert.ToBoolean(grid_termCredit.Rows[e.RowIndex].Cells["termCreditSelect"].EditedFormattedValue) == false) // check
                {
                    for (int i = 0; i < grid_selectedTermCredit.Rows.Count; i++)
                    {
                        if (grid_selectedTermCredit.Rows[i].Cells["Credit Number"].Value.ToString() == grid_termCredit.Rows[e.RowIndex].Cells["Credit Number"].Value.ToString())
                        {
                            MessageBox.Show("The Term Credit, " + grid_selectedTermCredit.Rows[i].Cells["Credit Number"].Value.ToString() + " already in selected Term Credit list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            grid_termCredit.Rows[e.RowIndex].Cells["termCreditSelect"].Value = true;
                            return;
                        }
                    }

                    //1. invoice 체크하면 term credit 선택가능
                    String PONumber = grid_termCredit.Rows[e.RowIndex].Cells["PO Number"].Value.ToString();
                    for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
                    {
                        if(PONumber == grid_selectedInvoice.Rows[i].Cells["PO Number"].Value.ToString())
                        {

                            String SupplierID = grid_termCredit.Rows[e.RowIndex].Cells["Supplier ID"].Value.ToString();
                            DateTime Date = Convert.ToDateTime(grid_termCredit.Rows[e.RowIndex].Cells["Date"].Value.ToString());
                            //String PONumber = grid_termCredit.Rows[e.RowIndex].Cells["PO Number"].Value.ToString();
                            String CreditNumber = grid_termCredit.Rows[e.RowIndex].Cells["Credit Number"].Value.ToString();
                            Decimal Amount = Convert.ToDecimal(grid_termCredit.Rows[e.RowIndex].Cells["Amount"].Value.ToString());
                            Decimal NetAmount = Convert.ToDecimal(grid_termCredit.Rows[e.RowIndex].Cells["Net Amount"].Value.ToString());
                            String Memo = grid_termCredit.Rows[e.RowIndex].Cells["Memo"].Value.ToString();
                            String Type = grid_termCredit.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                            String ReasonCode = grid_termCredit.Rows[e.RowIndex].Cells["Reason Code"].Value.ToString();

                            grid_selectedTermCredit.Rows.Add(new Object[] { SupplierID, Date, PONumber, CreditNumber, Amount, NetAmount, Memo, Type, ReasonCode });
                            grid_termCredit.Rows[e.RowIndex].Cells["termCreditSelect"].Value = true;

                            String TermCreditPONumber = grid_termCredit.Rows[e.RowIndex].Cells["PO Number"].Value.ToString();
                            for (int j = 0; j < grid_selectedInvoice.RowCount; j++)
                            {
                                String InvoicePONumber = grid_selectedInvoice.Rows[j].Cells["PO Number"].Value.ToString();
                                if(InvoicePONumber == TermCreditPONumber)
                                {
                                    grid_selectedInvoice.Rows[j].Cells["Net AP Amount"].Value = (Convert.ToDecimal(grid_selectedInvoice.Rows[j].Cells["Net AP Amount"].Value) - NetAmount).ToString("N2");
                                    grid_selectedInvoice.Rows[j].Cells["Payment Amount"].Value = (Convert.ToDecimal(grid_selectedInvoice.Rows[j].Cells["Payment Amount"].Value) - NetAmount).ToString("N2");
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                else // uncheck
                {
                    grid_termCredit.Rows[e.RowIndex].Cells["termCreditSelect"].Value = false;
                    for (int i = 0; i < grid_selectedTermCredit.Rows.Count; i++)
                    {
                        if (grid_selectedTermCredit.Rows[i].Cells["Credit Number"].Value.ToString() == grid_termCredit.Rows[e.RowIndex].Cells["Credit Number"].Value.ToString())
                        {
                            grid_selectedTermCredit.Rows.RemoveAt(i);
                            break;
                        }
                    }
                    String TermCreditPONumber = grid_termCredit.Rows[e.RowIndex].Cells["PO Number"].Value.ToString();
                    Decimal TermCreditNetAmount = Convert.ToDecimal(grid_termCredit.Rows[e.RowIndex].Cells["Net Amount"].Value.ToString());
                    for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
                    {
                        String InvoicePONumber = grid_selectedInvoice.Rows[i].Cells["PO Number"].Value.ToString();
                        if (InvoicePONumber == TermCreditPONumber)
                        {
                            grid_selectedInvoice.Rows[i].Cells["Net AP Amount"].Value = (Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Net AP Amount"].Value) + TermCreditNetAmount).ToString("N2");
                            grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value = (Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value) + TermCreditNetAmount).ToString("N2");
                            break;
                        }
                    }
                }
                CalculateAmount();
            }
        }

        private void grid_selectedTermCredit_Init()
        {
            grid_selectedTermCredit.AutoGenerateColumns = false;
            grid_selectedTermCredit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_selectedTermCredit.ColumnCount = 9;

            grid_selectedTermCredit.Columns[0].Name = "Supplier ID";
            //grid_selectedTermCredit.Columns[0].Visible = false;
            grid_selectedTermCredit.Columns[0].ReadOnly = true;
            grid_selectedTermCredit.Columns[0].Width = 100;
            grid_selectedTermCredit.Columns[0].MinimumWidth = 100;
            grid_selectedTermCredit.Columns[0].DataPropertyName = "SupplierID";
            grid_selectedTermCredit.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_selectedTermCredit.Columns[1].Name = "Date";
            grid_selectedTermCredit.Columns[1].ReadOnly = true;
            grid_selectedTermCredit.Columns[1].Width = 75;
            grid_selectedTermCredit.Columns[1].MinimumWidth = 75;
            grid_selectedTermCredit.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_selectedTermCredit.Columns[1].DataPropertyName = "CreateTime";
            grid_selectedTermCredit.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_selectedTermCredit.Columns[2].Name = "PO Number";
            //grid_selectedTermCredit.Columns[2].Visible = false;
            grid_selectedTermCredit.Columns[2].ReadOnly = true;
            grid_selectedTermCredit.Columns[2].Width = 80;
            grid_selectedTermCredit.Columns[2].MinimumWidth = 80;
            grid_selectedTermCredit.Columns[2].DataPropertyName = "InvoiceNumber";
            grid_selectedTermCredit.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_selectedTermCredit.Columns[3].Name = "Credit Number";
            grid_selectedTermCredit.Columns[3].ReadOnly = true;
            grid_selectedTermCredit.Columns[3].Width = 90;
            grid_selectedTermCredit.Columns[3].MinimumWidth = 90;
            grid_selectedTermCredit.Columns[3].DataPropertyName = "Number";
            grid_selectedTermCredit.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_selectedTermCredit.Columns[4].Name = "Amount";
            grid_selectedTermCredit.Columns[4].ReadOnly = true;
            grid_selectedTermCredit.Columns[4].Visible = false;
            grid_selectedTermCredit.Columns[4].Width = 50;
            grid_selectedTermCredit.Columns[4].MinimumWidth = 50;
            grid_selectedTermCredit.Columns[4].DefaultCellStyle.Format = "N2";
            grid_selectedTermCredit.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedTermCredit.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedTermCredit.Columns[4].DataPropertyName = "Amount";
            grid_selectedTermCredit.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_selectedTermCredit.Columns[5].Name = "Net Amount";
            grid_selectedTermCredit.Columns[5].ReadOnly = true;
            grid_selectedTermCredit.Columns[5].Width = 70;
            grid_selectedTermCredit.Columns[5].MinimumWidth = 70;
            grid_selectedTermCredit.Columns[5].DefaultCellStyle.Format = "N2";
            grid_selectedTermCredit.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedTermCredit.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedTermCredit.Columns[5].DataPropertyName = "NetAmount";
            grid_selectedTermCredit.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_selectedTermCredit.Columns[6].Name = "Memo";
            grid_selectedTermCredit.Columns[6].ReadOnly = true;
            grid_selectedTermCredit.Columns[6].Width = 120;
            grid_selectedTermCredit.Columns[6].MinimumWidth = 120;
            grid_selectedTermCredit.Columns[6].DataPropertyName = "PMemo";

            grid_selectedTermCredit.Columns[7].Name = "Type";
            grid_selectedTermCredit.Columns[7].ReadOnly = true;
            grid_selectedTermCredit.Columns[7].Visible = false;
            grid_selectedTermCredit.Columns[7].Width = 100;
            grid_selectedTermCredit.Columns[7].MinimumWidth = 100;
            grid_selectedTermCredit.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_selectedTermCredit.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_selectedTermCredit.Columns[7].DataPropertyName = "CreditDebit";

            grid_selectedTermCredit.Columns[8].Name = "Reason Code";
            grid_selectedTermCredit.Columns[8].ReadOnly = true;
            grid_selectedTermCredit.Columns[8].Visible = false;
            grid_selectedTermCredit.Columns[8].Width = 60;
            grid_selectedTermCredit.Columns[8].MinimumWidth = 60;
            grid_selectedTermCredit.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_selectedTermCredit.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_selectedTermCredit.Columns[8].DataPropertyName = "ReasonCode";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 50;
            deleteButton.MinimumWidth = 50;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_selectedTermCredit.Columns["Delete"] == null)
            {
                grid_selectedTermCredit.Columns.Insert(9, deleteButton);
            }

            //grid font size custom
            grid_selectedTermCredit.RowTemplate.Height = 20;
            grid_selectedTermCredit.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_selectedTermCredit.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_selectedTermCredit.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void cbox_supplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_supplier.Text = cbo_supplierID.Text.Trim();
                refresh();
            }
        }

        private void CalculateAmount()
        {
            Decimal PaymentAmountTotal = 0;
            Decimal PaymentInvoiceCount = 0;
            for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
            {
                //체크된 오더의 order amount 합 구하기
                Decimal PaymentAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value.ToString());
                PaymentAmountTotal = PaymentAmountTotal + PaymentAmount;

                //체크된 오더의 갯수 구하기
                PaymentInvoiceCount = PaymentInvoiceCount + 1;
            }
            if (PaymentInvoiceCount == 1)
            {
                lbl_invoice.Text = "(" + PaymentInvoiceCount.ToString("N0") + ") Invoice";
            }
            else
            {
                lbl_invoice.Text = "(" + PaymentInvoiceCount.ToString("N0") + ") Invoices";
            }
            
            Decimal TermCreditTotalAmount = 0;
            Decimal TermCreditCount = 0;
            for (int i = 0; i < grid_selectedTermCredit.RowCount; i++)
            {
                //체크된 term credit 합 구하기
                Decimal TermCreditAmount = Convert.ToDecimal(grid_selectedTermCredit.Rows[i].Cells["Net Amount"].Value.ToString());
                TermCreditTotalAmount = TermCreditTotalAmount + TermCreditAmount;
                //체크된 term credit 갯수 구하기
                TermCreditCount = TermCreditCount + 1;
            }
            lbl_termCredit.Text = "(" + TermCreditCount.ToString("N0") + ") Term Credit";
            txt_paymentAmount.Text = PaymentAmountTotal.ToString("N2");
        }

        private void btn_tempPayment_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure run the temp payment process?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //Get a new PAYXX Number from Server 12/24/2018
                String NewPAYXXNumber = connSalesOrder.sp_GET_NewPAYXXNumber();
                String SupplierID = txt_supplier.Text.Trim(); //cbox_supplier.Text.Trim();
                Decimal PaymentAmount = Convert.ToDecimal(txt_paymentAmount.Text);
                String PaymentType = cbo_paymentType.Text.Trim();
                String CheckNo = txt_checkNumber.Text.Trim();

                for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
                {
                    String PONumber = grid_selectedInvoice.Rows[i].Cells["PO No."].Value.ToString().Trim();
                    String InvoiceNumber = grid_selectedInvoice.Rows[i].Cells["INV No."].Value.ToString();
                    if (Convert.ToBoolean(grid_selectedInvoice.Rows[i].Cells["invoiceSelect"].EditedFormattedValue) == true)
                    {
                        Decimal InvoiceAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Amt"].Value.ToString());

                        connPO.sp_PPAYMENTT_INSERT_INVOICE(PaymentType, SupplierID, InvoiceNumber, InvoiceAmount, NewPAYXXNumber);
                    }
                }
                String CheckNumber = txt_checkNumber.Text;
                DateTime AccountingDate = dateTimePicker2.Value;
                String Bank = cbo_bank.Text;
                String Site = cbo_site.Text;
                connPO.sp_PPAYMENTT(PaymentType, SupplierID, CheckNumber, AccountingDate, PaymentAmount, Bank, Site, NewPAYXXNumber);
                connPO.sp_PPAYMENT_HEADER(grid_payment, "");
                refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        
        private void btn_payment_Click(object sender, EventArgs e)
        {
            if(cbo_supplierID.Text == "")
            {
                MessageBox.Show("Please select Supplier ID.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            int InvoiceCount = grid_selectedInvoice.Rows.Count;
            if(InvoiceCount == 0)
            {
                MessageBox.Show("Must select at least one invoice.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (Convert.ToDecimal(txt_paymentAmount.Text.Trim()) == 0)
            {
                MessageBox.Show("The payment amount cannot be 0.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure run the payment process?", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
                {
                    //payment 하는 순간의 net amount 일치하는지 확인 (다른 곳에서 페이하거나 reverse하거나 net settlement한 인보이스 확인)
                    String SelectedPINVNumber = grid_selectedInvoice.Rows[i].Cells["PINV Number"].Value.ToString();
                    Decimal SelectedNetAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Amt"].Value.ToString());
                    Decimal NetSettledAmount = connSalesOrder.sp_PPAYMENT_CheckNetSettledAmount(SelectedPINVNumber);
                    if (SelectedNetAmount != NetSettledAmount)
                    {
                        MessageBox.Show("The Invoice, " + SelectedPINVNumber + " has been updated.(Net Settled, Paid or Reversed). Please try again.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        grid_selectedInvoice.DataSource = null;
                        grid_selectedInvoice.Rows.Clear();
                        txt_paymentAmount.Text = "";
                        for (int j = 0; j < grid_selectedTermCredit.Rows.Count; j++)
                        {
                            if (grid_selectedTermCredit.Rows[j].Cells["PINV Number"].Value.ToString() == SelectedPINVNumber)
                            {
                                grid_selectedInvoice.Rows.RemoveAt(j);
                            }
                        }
                        refresh();
                        CalculateAmount();
                        return;
                    }
                }
                //payment 하는 순간의 term credit이 일치하는지 확인(이미 페이할때 사용되거나 삭제된 term credit인지 확인)
                for (int i = 0; i < grid_selectedTermCredit.RowCount; i++)
                {
                    String TermCreditNumber = grid_selectedTermCredit.Rows[i].Cells["Credit Number"].Value.ToString();
                    Decimal TermCreditNetAmount = Convert.ToDecimal(grid_selectedTermCredit.Rows[i].Cells["Net Amount"].Value.ToString());
                    CheckCreditDebitMemo checkCreditDebitMemo = new CheckCreditDebitMemo();
                    checkCreditDebitMemo = connSalesOrder.sp_PPAYMENT_CheckCreditDebitMemo(TermCreditNumber);
                    if (TermCreditNetAmount != checkCreditDebitMemo.NetSettledAmount || checkCreditDebitMemo.Deleted == "Deleted")
                    {
                        MessageBox.Show("The Term Credit, " + TermCreditNumber + " has been updated (already paid or deleted). Please try again.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        grid_selectedTermCredit.Rows.RemoveAt(i);
                        connPO.sp_PPAYMENT_TERMCREDIT(grid_termCredit, cbo_supplierID.Text.Trim());
                        CalculateAmount();
                        return;
                    }
                }

                //term credit과 invoice 짝이 맞는지 확인
                for (int i = 0; i < grid_selectedInvoice.RowCount; i++) 
                {
                    String SelectedTermCreditPONumber = grid_selectedInvoice.Rows[i].Cells["PO Number"].Value.ToString();
                    for (int j = 0; j < grid_selectedInvoice.RowCount; j++)
                    {
                        String SelectedInvoicePONumber = grid_selectedInvoice.Rows[i].Cells["PO Number"].Value.ToString();
                        if(SelectedTermCreditPONumber == SelectedInvoicePONumber)
                        {
                            break;
                        }
                        else
                        {
                            MessageBox.Show("The Term Credit, " + SelectedTermCreditPONumber + " has been updated. (Used or Reversed). Please try again.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }
                }
                
                String NewBMWNumber = connSalesOrder.sp_GET_NewBMWNumber_AP();
                //MessageBox.Show(NewDeliveryNumber);
                if (!NewBMWNumber.Contains("BMW"))
                {
                    MessageBox.Show("Please try again.(BMW) (Error code: " + NewBMWNumber + ")", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                String PaymentType = cbo_paymentType.Text.Trim();
                String NewPAYNumber = connSalesOrder.sp_GET_NewPAYNumber(PaymentType);
                String SupplierID = cbo_supplierID.Text.Trim();
                String CheckNumber = txt_checkNumber.Text.Trim();
                DateTime AccountingDate = dateTimePicker2.Value;
                Decimal PaymentAmount = Convert.ToDecimal(txt_paymentAmount.Text);
                String Site = cbo_site.Text.Trim();
                String Bank = cbo_bank.Text.Trim();
                connPO.sp_PPAYMENT(NewPAYNumber, NewBMWNumber, PaymentType, SupplierID, CheckNumber, AccountingDate, PaymentAmount, Site, Bank);
                for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
                {
                    String SelectedSupplierID = grid_selectedInvoice.Rows[i].Cells["Supplier ID"].Value.ToString();
                    String SelectedPINVNumber = grid_selectedInvoice.Rows[i].Cells["PINV Number"].Value.ToString();
                    Decimal SelectedNetAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Net AP Amount"].Value.ToString());
                    Decimal SelectedPaymentAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value.ToString());
                    connPO.sp_PPAYMENTD(NewPAYNumber, NewBMWNumber, SelectedPINVNumber, PaymentType, SelectedSupplierID, CheckNumber, AccountingDate, SelectedPaymentAmount, Site, Bank);
                }

                //term credit
                for (int i = 0; i < grid_selectedTermCredit.RowCount; i++)
                {
                    String SelectedTermCreditSupplierID = grid_selectedTermCredit.Rows[i].Cells["Supplier ID"].Value.ToString();
                    String SelectedTermCreditPONumber = grid_selectedTermCredit.Rows[i].Cells["PO Number"].Value.ToString();
                    String SelectedTermCreditNumber = grid_selectedTermCredit.Rows[i].Cells["Credit Number"].Value.ToString();
                    Decimal SelectedTermCreditAmount = Convert.ToDecimal(grid_selectedTermCredit.Rows[i].Cells["Net Amount"].Value.ToString());
                    connPO.sp_PPAYMENTD_TERMCREDIT(NewPAYNumber, NewBMWNumber, SelectedTermCreditPONumber, SelectedTermCreditNumber, SelectedTermCreditAmount, SelectedTermCreditSupplierID);
                }
                grid_selectedInvoice.DataSource = null;
                grid_selectedTermCredit.DataSource = null;
                grid_selectedInvoice.Rows.Clear();
                grid_selectedTermCredit.Rows.Clear();
                txt_checkNumber.Text = "";
                txt_paymentAmount.Text = "";
                lbl_invoice.Text = "Invoice";
                lbl_termCredit.Text = "Term Credit";
                refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void refresh()
        {
            String SupplierID = txt_supplier.Text.Trim();
            connPO.sp_PPAYMENT_HEADER(grid_payment, SupplierID);
            connPO.sp_PPAYMENT_INVOICE(grid_invoice, SupplierID);
            connPO.sp_PPAYMENT_TERMCREDIT(grid_termCredit, SupplierID);
            grid_paymentInfo.DataSource = null;
            this.grid_paymentInfo.Rows.Clear();
        }

        private void grid_payment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String SelectedPaymentNumber = grid_payment.Rows[e.RowIndex].Cells["Payment Number"].Value.ToString().Trim();
                String SelectedSupplierID = grid_payment.Rows[e.RowIndex].Cells["Supplier ID"].Value.ToString().Trim();
                String SelectedSite = grid_payment.Rows[e.RowIndex].Cells["Site"].Value.ToString().Trim();
                Decimal SelectedPaymentAmount = Convert.ToDecimal(grid_payment.Rows[e.RowIndex].Cells["Amount"].Value.ToString().Trim());
                DateTime SelectedPaymentDate = Convert.ToDateTime(grid_payment.Rows[e.RowIndex].Cells["Acc Date"].Value.ToString().Trim());
                String SelectedPaymentMethod = grid_payment.Rows[e.RowIndex].Cells["Payment Method"].Value.ToString().Trim();
                String SelectedCheckNumber = grid_payment.Rows[e.RowIndex].Cells["Check Number"].Value.ToString().Trim();
                connPO.sp_PPAYMENT_DETAIL(grid_paymentInfo, SelectedPaymentNumber);
                if (e.ColumnIndex == grid_payment.Columns["Print Check"].Index && e.RowIndex >= 0)
                {
                    if (SelectedPaymentMethod != "CHQ")
                    {
                        MessageBox.Show("This is not a payment paid by check.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    DialogResult dialogResult = MessageBox.Show("Are you sure print check?", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            String InputCheckAmount = SelectedPaymentAmount.ToString().Trim();
                            Decimal CheckAmountDecimal = Convert.ToDecimal(InputCheckAmount);
                            int WithoutCentsInt = (int)CheckAmountDecimal;
                            Decimal WithoutCentsDecimal = Convert.ToDecimal(WithoutCentsInt);
                            Decimal Cents = CheckAmountDecimal - WithoutCentsDecimal;
                            int CentsString = Convert.ToInt32(Cents * 100);
                            String US_DOLLARS_AND;
                            if(WithoutCentsInt == 1)
                            {
                                US_DOLLARS_AND = " US DOLLAR AND ";
                            }
                            else
                            {
                                US_DOLLARS_AND = " US DOLLARS AND ";
                            }
                            String AmountDigits = "****" + CheckAmountDecimal.ToString("N2");
                            String AmountWord = (NumberToWords(WithoutCentsInt) + US_DOLLARS_AND + CentsString.ToString() + "/100").ToUpper();
                            String SupplierID = SelectedSupplierID;
                            String PaymentNumber = SelectedPaymentNumber;
                            String CheckNumber = SelectedCheckNumber;
                            String CheckDate = SelectedPaymentDate.ToShortDateString();
                            String SupplierName = connPO.sp_PPAYMENT_GetSupplierName(SupplierID);
                            String CheckAmount = SelectedPaymentAmount.ToString("N2");
                            String CheckAmountWord = AmountWord;
                            String SupplierAddress1 = connPO.sp_PPAYMENT_GetSupplierAddress1(SupplierID);
                            String SupplierAddress2 = connPO.sp_PPAYMENT_GetSupplierAddress2(SupplierID);
                            Reports.Rpt_PrintCheck printCheck = new Reports.Rpt_PrintCheck(PaymentNumber.Trim(), CheckNumber, CheckDate, SupplierID, SupplierName, CheckAmount, CheckAmountWord, SupplierAddress1, SupplierAddress2);
                            printCheck.Show();
                        }
                        catch
                        {
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
                else if(e.ColumnIndex == grid_payment.Columns["Reverse"].Index && e.RowIndex >= 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure reverse this payment?", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            connPO.sp_PPAYMENT_REVERSE(SelectedPaymentNumber);
                            refresh();
                        }
                        catch
                        {
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
            }
        }

        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }
            return words;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_searchPaymentSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String SupplierID = txt_searchPaymentSupplier.Text.Trim();
                connPO.sp_PPAYMENT_HEADER(grid_payment, SupplierID);
            }
        }

        private void cbox_supplier_SelectedValueChanged(object sender, EventArgs e)
        {
            grid_payment.DataSource = null;
            grid_paymentInfo.DataSource = null;
        }

        private void grid_selectedInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Decimal NetAPAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[e.RowIndex].Cells["Net AP Amount"].Value.ToString().Trim());
            Decimal PaymentAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[e.RowIndex].Cells["Payment Amount"].Value.ToString().Trim());
            grid_selectedInvoice.Rows[e.RowIndex].Cells["Payment Amount"].Value = PaymentAmount.ToString("N2");
            if(PaymentAmount > NetAPAmount)
            {
                MessageBox.Show("Payment Amount cannot be greater than Net AP Amount.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                grid_selectedInvoice.Rows[e.RowIndex].Cells["Payment Amount"].Value = NetAPAmount;
            }
            CalculateAmount();
        }

        private void grid_selectedInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11 && e.RowIndex >= 0) // Delete button
            {
                for (int i = 0; i < grid_invoice.Rows.Count; i++)
                {
                    if (grid_invoice.Rows[i].Cells["PINV Number"].Value.ToString() == grid_selectedInvoice.Rows[e.RowIndex].Cells["PINV Number"].Value.ToString())
                    {
                        grid_invoice.Rows[i].Cells["invoiceSelect"].Value = false;
                    }
                }
                //2 - 1.selected invoice에서 지워지면 term credit 선택해제
                String PONumber = grid_selectedInvoice.Rows[e.RowIndex].Cells["PO Number"].Value.ToString();
                for (int i = 0; i < grid_termCredit.Rows.Count; i++)
                {
                    String TermCreditPONumber = grid_termCredit.Rows[i].Cells["PO Number"].Value.ToString();
                    if (TermCreditPONumber == PONumber)
                    {
                        grid_termCredit.Rows[i].Cells["termCreditSelect"].Value = false;
                        break;
                    }
                }

                for (int i = 0; i < grid_selectedTermCredit.Rows.Count; i++)
                {
                    String TermCreditPONumber = grid_selectedTermCredit.Rows[i].Cells["PO Number"].Value.ToString();
                    if (TermCreditPONumber == PONumber)
                    {
                        grid_selectedTermCredit.Rows.RemoveAt(i);
                        break;
                    }
                }
                grid_selectedInvoice.Rows.RemoveAt(e.RowIndex);
                CalculateAmount();
            }
        }

        private void txt_poNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String PONumber = "PO" + txt_poNumber.Text.Trim();
                String SupplierIDbyPONumber = connPO.GET_SupplierID_by_PONumber(PONumber);
                cbo_supplierID.Text = SupplierIDbyPONumber;
                txt_supplier.Text = cbo_supplierID.Text.Trim();
                refresh();
                txt_poNumber.Text = "";
            }
        }

        private void txt_poNumber_Leave(object sender, EventArgs e)
        {
            lbl_PO.Visible = false;
            txt_poNumber.Text = "";
        }

        private void txt_poNumber_Enter(object sender, EventArgs e)
        {
            lbl_PO.Visible = true;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            txt_poNumber.Focus();
        }

        private void grid_selectedTermCredit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9 && e.RowIndex >= 0) // Delete button
            {
                for (int i = 0; i < grid_termCredit.Rows.Count; i++)
                {
                    if (grid_termCredit.Rows[i].Cells["PO Number"].Value.ToString() == grid_selectedTermCredit.Rows[e.RowIndex].Cells["PO Number"].Value.ToString())
                    {
                        grid_termCredit.Rows[i].Cells["termCreditSelect"].Value = false;
                    }
                }
                String TermCreditPONumber = grid_termCredit.Rows[e.RowIndex].Cells["PO Number"].Value.ToString();
                Decimal TermCreditNetAmount = Convert.ToDecimal(grid_termCredit.Rows[e.RowIndex].Cells["Net Amount"].Value.ToString());
                for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
                {
                    String InvoicePONumber = grid_selectedInvoice.Rows[i].Cells["PO Number"].Value.ToString();
                    if (InvoicePONumber == TermCreditPONumber)
                    {
                        grid_selectedInvoice.Rows[i].Cells["Net AP Amount"].Value = (Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Net AP Amount"].Value) + TermCreditNetAmount).ToString("N2");
                        grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value = (Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value) + TermCreditNetAmount).ToString("N2");
                        break;
                    }
                }
                grid_selectedTermCredit.Rows.RemoveAt(e.RowIndex);
                CalculateAmount();
            }
        }
    }
}