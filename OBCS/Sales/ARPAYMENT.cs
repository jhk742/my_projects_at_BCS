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
    public partial class ARPAYMENT : Form
    {
        public ARPAYMENT()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            grid_payment_Init();
            
            grid_invoice_Init();
            grid_selectedInvoice_Init();
            grid_selectedInvoiceTotal_Init();

            grid_selectedInvoiceTotal.Rows.Add(new Object[] {"Total", "", "", "", "", "", 0, 0, 0, 0, 0 ,"", 0, ""});

            grid_termCredit_Init();
            grid_paidCashCheck_Init();
            grid_paymentInfo_Init();

            cbox_customer_Init();

            if(GATE.userID != "NYF01" && GATE.userID != "NYF02")
            {
                cbo_site.Items.Add("BCS");
                cbo_site.Items.Add("NYC");
                cbo_site.Items.Add("HYD");
                cbo_site.Items.Add("CFI");
                cbo_site.Items.Add("NTM");
            }
            cbo_site.Items.Add("NYF");

            cbo_bank.Items.Add("WB436");
            cbo_bank.Items.Add("BVC");
            cbo_bank.Items.Add("BCSB");
            
            cbo_checkCash.Items.Add("Check");
            cbo_checkCash.Items.Add("Cash");
            cbo_checkCash.Items.Add("ACH");

            txt_invoiceNetAmountTotal.Text = "0.00";
            txt_termCredit.Text = "0.00";
            txt_arPaymentTotal.Text = "0.00";
            txt_shortOver.Text = "0.00";



            //btn_payment.Enabled = false;
            cbo_site.Text = "BCS";
            if (GATE.userID == "NYF01" || GATE.userID == "NYF02")
            {
                cbo_site.Text = "NYF";
            }

            cbo_bank.Text = "WB436";
            

            lbl_customerInfo.Text = "";
        }


        private void grid_payment_Init()
        {
            grid_payment.AutoGenerateColumns = false;
            grid_payment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_payment.ColumnCount = 8;

            grid_payment.Columns[0].Name = "No.";
            grid_payment.Columns[0].ReadOnly = true;
            grid_payment.Columns[0].Width = 90;
            grid_payment.Columns[0].MinimumWidth = 90;
            grid_payment.Columns[0].DataPropertyName = "NUM_0";

            grid_payment.Columns[1].Name = "Customer";
            grid_payment.Columns[1].ReadOnly = true;
            grid_payment.Columns[1].Width = 80;
            grid_payment.Columns[1].MinimumWidth = 80;
            grid_payment.Columns[1].DataPropertyName = "BPR_0";

            grid_payment.Columns[2].Name = "Site";
            grid_payment.Columns[2].ReadOnly = true;
            grid_payment.Columns[2].Width = 40;
            grid_payment.Columns[2].MinimumWidth = 40;
            grid_payment.Columns[2].DataPropertyName = "FCY_0";

            grid_payment.Columns[3].Name = "Amt";
            grid_payment.Columns[3].ReadOnly = true;
            grid_payment.Columns[3].Width = 70;
            grid_payment.Columns[3].MinimumWidth = 70;
            grid_payment.Columns[3].DefaultCellStyle.Format = "N2";
            grid_payment.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_payment.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_payment.Columns[3].DataPropertyName = "AMTCUR_0";

            grid_payment.Columns[4].Name = "Date";
            grid_payment.Columns[4].ReadOnly = true;
            grid_payment.Columns[4].Width = 70;
            grid_payment.Columns[4].MinimumWidth = 70;
            grid_payment.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_payment.Columns[4].DataPropertyName = "ACCDAT_0";

            grid_payment.Columns[5].Name = "Check/Cash";
            grid_payment.Columns[5].ReadOnly = true;
            grid_payment.Columns[5].Width = 40;
            grid_payment.Columns[5].MinimumWidth = 40;
            grid_payment.Columns[5].DataPropertyName = "PAM_0";

            grid_payment.Columns[6].Name = "Check No.";
            grid_payment.Columns[6].ReadOnly = true;
            grid_payment.Columns[6].Width = 50;
            grid_payment.Columns[6].MinimumWidth = 50;
            grid_payment.Columns[6].DataPropertyName = "CHQNUM_0";

            grid_payment.Columns[7].Name = "Entry Batch";
            grid_payment.Columns[7].ReadOnly = true;
            grid_payment.Columns[7].Width = 50;
            grid_payment.Columns[7].MinimumWidth = 50;
            grid_payment.Columns[7].DataPropertyName = "REF_0";
            
            DataGridViewButtonColumn reverseButton = new DataGridViewButtonColumn();
            reverseButton.Width = 60;
            reverseButton.MinimumWidth = 60;
            reverseButton.Name = "Reverse";
            reverseButton.Text = "Reverse";
            reverseButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            reverseButton.UseColumnTextForButtonValue = true;
            if (grid_payment.Columns["Reverse"] == null)

            {
                grid_payment.Columns.Insert(8, reverseButton);
            }

            //grid font size custom
            grid_payment.RowTemplate.Height = 20;
            grid_payment.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_payment.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_payment.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        
        private void grid_invoice_Init()
        {
            grid_invoice.AutoGenerateColumns = false;
            grid_invoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_invoice.ColumnCount = 12;

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
            grid_invoice.Columns.Insert(0, invoiceCheck);
            grid_invoice.CellContentClick += new DataGridViewCellEventHandler(invoiceSelect);

            //DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            //deleteButton.Width = 50;
            //deleteButton.Name = "Delete";
            //deleteButton.Text = "Delete";
            //deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //deleteButton.UseColumnTextForButtonValue = true;
            //if (grid_OrderDetail.Columns["Delete"] == null)
            //{
            //    grid_OrderDetail.Columns.Insert(14, deleteButton);
            //}

            grid_invoice.Columns[1].Name = "Customer";
            grid_invoice.Columns[1].ReadOnly = true;
            grid_invoice.Columns[1].Width = 115;
            grid_invoice.Columns[1].MinimumWidth = 115;
            //grid_invoice.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[1].DataPropertyName = "BPR_0";

            grid_invoice.Columns[2].Name = "Site";
            grid_invoice.Columns[2].ReadOnly = true;
            grid_invoice.Columns[2].Width = 35;
            grid_invoice.Columns[2].MinimumWidth = 35;
            //grid_invoice.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_invoice.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_invoice.Columns[2].DataPropertyName = "FCY_0";

            grid_invoice.Columns[3].Name = "Order No.";
            grid_invoice.Columns[3].Visible = false;
            grid_invoice.Columns[3].ReadOnly = true;
            grid_invoice.Columns[3].Width = 110;
            grid_invoice.Columns[3].MinimumWidth = 110;
            //grid_invoice.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[3].DataPropertyName = "OrderID";
            
            grid_invoice.Columns[4].Name = "Delv No.";
            grid_invoice.Columns[4].ReadOnly = true;
            grid_invoice.Columns[4].Width = 110;
            grid_invoice.Columns[4].MinimumWidth = 110;
            //grid_invoice.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[4].DataPropertyName = "ORIDOCNUM_0";

            grid_invoice.Columns[5].Name = "Date";
            grid_invoice.Columns[5].ReadOnly = true;
            grid_invoice.Columns[5].Width = 80;
            grid_invoice.Columns[5].MinimumWidth = 80;
            //grid_invoice.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_invoice.Columns[5].DataPropertyName = "ACCDAT_0";

            grid_invoice.Columns[6].Name = "No.";
            grid_invoice.Columns[6].ReadOnly = true;
            grid_invoice.Columns[6].Width = 80;
            grid_invoice.Columns[6].MinimumWidth = 80;
            //grid_invoice.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[6].DataPropertyName = "NUM_0";
            
            grid_invoice.Columns[7].Name = "AR Amount";
            grid_invoice.Columns[7].ReadOnly = true;
            grid_invoice.Columns[7].Width = 80;
            grid_invoice.Columns[7].MinimumWidth = 80;
            //grid_invoice.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[7].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[7].DataPropertyName = "ARAmount";

            grid_invoice.Columns[8].Name = "Amt";
            grid_invoice.Columns[8].ReadOnly = false;
            grid_invoice.Columns[8].Width = 80;
            grid_invoice.Columns[8].MinimumWidth = 80;
            //grid_invoice.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[8].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[8].DataPropertyName = "AMTATI_0";

            grid_invoice.Columns[9].Name = "Net";
            grid_invoice.Columns[9].Visible = false;
            grid_invoice.Columns[9].Width = 70;
            grid_invoice.Columns[9].MinimumWidth = 70;
            //grid_invoice.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[9].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[9].DataPropertyName = "Net";

            grid_invoice.Columns[10].Name = "Rep";
            grid_invoice.Columns[10].ReadOnly = true;
            //grid_invoice.Columns[10].Visible = false;
            grid_invoice.Columns[10].Width = 40;
            grid_invoice.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_invoice.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_invoice.Columns[10].DataPropertyName = "SaleRep";

            grid_invoice.Columns[11].Name = "Payment Term";
            grid_invoice.Columns[11].ReadOnly = true;
            grid_invoice.Columns[11].Width = 70;
            grid_invoice.Columns[11].MinimumWidth = 70;
            //grid_invoice.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_invoice.Columns[11].DataPropertyName = "PTE_0";
            
            grid_invoice.Columns[12].Name = "Customer Name";
            grid_invoice.Columns[12].ReadOnly = true;
            grid_invoice.Columns[12].Visible = false;
            grid_invoice.Columns[12].Width = 130;
            grid_invoice.Columns[12].DataPropertyName = "BPCNAM_0";

            
            
            //DataGridViewComboBoxColumn ShortOverComboBox = new DataGridViewComboBoxColumn();
            //ShortOverComboBox.Width = 70;
            //ShortOverComboBox.MinimumWidth = 70;
            //ShortOverComboBox.Name = "ShortOver";
            //ShortOverComboBox.Items.Add("Short");
            //ShortOverComboBox.Items.Add("Over");
            //ShortOverComboBox.Items.Add("");
            //ShortOverComboBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_invoice.Columns.Insert(13, ShortOverComboBox);

            //grid_invoice.Columns[14].Name = "Short/Over Amount";
            //grid_invoice.Columns[14].ReadOnly = true;
            //grid_invoice.Columns[14].Width = 70;
            //grid_invoice.Columns[14].MinimumWidth = 70;
            //grid_invoice.Columns[14].DefaultCellStyle.Format = "N2";
            //grid_invoice.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //grid_invoice.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //grid_invoice.Columns[14].DataPropertyName = "";



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
            grid_selectedInvoice.ColumnCount = 12;
            
            grid_selectedInvoice.Columns[0].Name = "Customer";
            grid_selectedInvoice.Columns[0].ReadOnly = true;
            grid_selectedInvoice.Columns[0].Width = 115;
            grid_selectedInvoice.Columns[0].MinimumWidth = 115;
            //grid_selectedInvoice.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoice.Columns[0].DataPropertyName = "BPR_0";

            grid_selectedInvoice.Columns[1].Name = "Site";
            grid_selectedInvoice.Columns[1].ReadOnly = true;
            grid_selectedInvoice.Columns[1].Width = 40;
            grid_selectedInvoice.Columns[1].MinimumWidth = 40;
            //grid_selectedInvoice.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoice.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_selectedInvoice.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_selectedInvoice.Columns[1].DataPropertyName = "FCY_0";

            grid_selectedInvoice.Columns[2].Name = "Order No.";
            //grid_selectedInvoice.Columns[2].Visible = false;
            grid_selectedInvoice.Columns[2].ReadOnly = true;
            grid_selectedInvoice.Columns[2].Width = 90;
            grid_selectedInvoice.Columns[2].MinimumWidth = 90;
            //grid_selectedInvoice.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoice.Columns[2].DataPropertyName = "OrderID";

            grid_selectedInvoice.Columns[3].Name = "Delv No.";
            grid_selectedInvoice.Columns[3].ReadOnly = true;
            grid_selectedInvoice.Columns[3].Width = 100;
            grid_selectedInvoice.Columns[3].MinimumWidth = 100;
            //grid_selectedInvoice.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoice.Columns[3].DataPropertyName = "ORIDOCNUM_0";

            grid_selectedInvoice.Columns[4].Name = "No.";
            grid_selectedInvoice.Columns[4].ReadOnly = true;
            grid_selectedInvoice.Columns[4].Width = 75;
            grid_selectedInvoice.Columns[4].MinimumWidth = 75;
            //grid_selectedInvoice.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoice.Columns[4].DataPropertyName = "NUM_0";

            grid_selectedInvoice.Columns[5].Name = "Date";
            grid_selectedInvoice.Columns[5].ReadOnly = true;
            grid_selectedInvoice.Columns[5].Width = 80;
            grid_selectedInvoice.Columns[5].MinimumWidth = 80;
            grid_selectedInvoice.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoice.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_selectedInvoice.Columns[5].DataPropertyName = "ACCDAT_0";

            grid_selectedInvoice.Columns[6].Name = "AR Amount";
            grid_selectedInvoice.Columns[6].ReadOnly = true;
            grid_selectedInvoice.Columns[6].Width = 80;
            grid_selectedInvoice.Columns[6].MinimumWidth = 80;
            grid_selectedInvoice.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoice.Columns[6].DefaultCellStyle.Format = "N2";
            grid_selectedInvoice.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[6].DataPropertyName = "ARAmount";

            grid_selectedInvoice.Columns[7].Name = "Amt";
            grid_selectedInvoice.Columns[7].ReadOnly = true;
            grid_selectedInvoice.Columns[7].Width = 80;
            grid_selectedInvoice.Columns[7].MinimumWidth = 80;
            grid_selectedInvoice.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoice.Columns[7].DefaultCellStyle.Format = "N2";
            grid_selectedInvoice.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[7].DataPropertyName = "AMTATI_0";

            grid_selectedInvoice.Columns[8].Name = "Net Amount";
            grid_selectedInvoice.Columns[8].ReadOnly = true;
            grid_selectedInvoice.Columns[8].Width = 80;
            grid_selectedInvoice.Columns[8].MinimumWidth = 80;
            grid_selectedInvoice.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoice.Columns[8].DefaultCellStyle.Format = "N2";
            grid_selectedInvoice.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[8].DataPropertyName = "NetAmount";

            grid_selectedInvoice.Columns[9].Name = "Payment Amount";
            grid_selectedInvoice.Columns[9].ReadOnly = false;
            grid_selectedInvoice.Columns[9].Width = 80;
            grid_selectedInvoice.Columns[9].MinimumWidth = 80;
            grid_selectedInvoice.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoice.Columns[9].DefaultCellStyle.Format = "N2";
            grid_selectedInvoice.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[9].DataPropertyName = "PaymentNetAmount";

            grid_selectedInvoice.Columns[10].Name = "Payment Term";
            grid_selectedInvoice.Columns[10].ReadOnly = true;
            grid_selectedInvoice.Columns[10].Width = 100;
            grid_selectedInvoice.Columns[10].MinimumWidth = 100;
            grid_selectedInvoice.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoice.Columns[10].DataPropertyName = "PTE_0";
            
            DataGridViewComboBoxColumn ShortOverComboBox = new DataGridViewComboBoxColumn();
            ShortOverComboBox.Width = 70;
            ShortOverComboBox.MinimumWidth = 70;
            ShortOverComboBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ShortOverComboBox.Name = "ShortOver";
            ShortOverComboBox.Items.Add("Short");
            ShortOverComboBox.Items.Add("Over");
            ShortOverComboBox.Items.Add(" ");
            ShortOverComboBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_selectedInvoice.Columns.Insert(11, ShortOverComboBox);

            grid_selectedInvoice.Columns[12].Name = "Short/Over Amount";
            grid_selectedInvoice.Columns[12].ReadOnly = false;
            grid_selectedInvoice.Columns[12].Width = 80;
            grid_selectedInvoice.Columns[12].MinimumWidth = 80;
            grid_selectedInvoice.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoice.Columns[12].DefaultCellStyle.Format = "N2";
            grid_selectedInvoice.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoice.Columns[12].DataPropertyName = "";

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
                grid_selectedInvoice.Columns.Insert(13, deleteButton);
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
                try
                {
                    if (connSalesOrder.sp_WriteOff_TempCheck(grid_invoice.Rows[e.RowIndex].Cells["No."].Value.ToString()) == "1")
                    {
                        MessageBox.Show("No : " + grid_invoice.Rows[e.RowIndex].Cells["No."].Value.ToString() + ", This number is in 'WRITE-OFF' list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (Convert.ToBoolean(grid_invoice.Rows[e.RowIndex].Cells["invoiceSelect"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                    {

                        //btn_payment.Enabled = true;

                        grid_invoice.Rows[e.RowIndex].Cells["invoiceSelect"].Value = true;

                        for (int i = 0; i < grid_selectedInvoice.Rows.Count; i++)
                        {
                            if (grid_selectedInvoice.Rows[i].Cells["No."].Value.ToString() == grid_invoice.Rows[e.RowIndex].Cells["No."].Value.ToString())
                            {
                                MessageBox.Show("The invoice number, " + grid_selectedInvoice.Rows[i].Cells["No."].Value.ToString() + " already in selected invoice list.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }
                        }

                        Decimal InvoiceAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["Amt"].Value.ToString());
                        String InvoiceNumber = grid_invoice.Rows[e.RowIndex].Cells["No."].Value.ToString().Trim();
                        String PaymentTermName = grid_invoice.Rows[e.RowIndex].Cells["Payment Term"].Value.ToString().Trim(); //connSalesOrder.sp_GET_InvoicePaymentTerm(InvoiceNumber);

                        Decimal DiscountRate = 0;
                        try
                        {
                            DiscountRate = Convert.ToDecimal(PaymentTermName.Substring(0, 2));
                            //MessageBox.Show(DiscountRate.ToString());
                        }
                        catch
                        {
                            try
                            {
                                DiscountRate = Convert.ToDecimal(PaymentTermName.Substring(0, 1));
                            }
                            catch
                            {
                                DiscountRate = 0;
                            }
                        }
                        

                        if (DiscountRate > 0 && !grid_invoice.Rows[e.RowIndex].Cells["No."].Value.ToString().Contains("DIR"))
                        {
                            grid_termCredit.Rows.Add(new Object[] { false, PaymentTermName, DiscountRate.ToString("N2"), (DiscountRate / 100 * InvoiceAmount).ToString("N2"), InvoiceNumber });
                        }
                        

                        String CustomerID = grid_invoice.Rows[e.RowIndex].Cells["Customer"].Value.ToString();
                        String Site = grid_invoice.Rows[e.RowIndex].Cells["Site"].Value.ToString();
                        String OrderNumber = grid_invoice.Rows[e.RowIndex].Cells["Order No."].Value.ToString();
                        String DeliveryNumber = grid_invoice.Rows[e.RowIndex].Cells["Delv No."].Value.ToString();
                        //String InvoiceNumber = grid_invoice.Rows[e.RowIndex].Cells["InvoiceNumber"].Value.ToString();
                        DateTime InvoiceDate = Convert.ToDateTime(grid_invoice.Rows[e.RowIndex].Cells["Date"].Value.ToString());
                        Decimal OriginalARAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["AR Amount"].Value.ToString());
                        Decimal ARAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["Amt"].Value.ToString());
                        String PaymentTerm = grid_invoice.Rows[e.RowIndex].Cells["Payment Term"].Value.ToString();

                        grid_selectedInvoice.Rows.Add(new Object[] { CustomerID, Site, OrderNumber, DeliveryNumber, InvoiceNumber, InvoiceDate, OriginalARAmount, ARAmount, ARAmount, ARAmount, PaymentTerm, "", 0 });

                        if (cbox_customer.Text != "")
                        {
                            //connSalesOrder.sp_PAYMENT_GETPaidCashCheck(grid_paidCashCheck, grid_invoice.Rows[e.RowIndex].Cells["No."].Value.ToString().Trim());

                            //for (int i = 0; i < grid_paidCashCheck.RowCount; i++)
                            //{
                            //    if (grid_paidCashCheck.Rows[i].Cells["Check No."].Value.ToString() != "")
                            //    {
                            //        grid_paidCashCheck.Rows[i].Cells["Check/Cash"].Value = "Check";
                            //    }
                            //    else
                            //    {
                            //        grid_paidCashCheck.Rows[i].Cells["Check/Cash"].Value = "Cash";
                            //    }

                            //}
                        }

                    }
                    else // uncheck 했을 때
                    {
                        grid_invoice.Rows[e.RowIndex].Cells["invoiceSelect"].Value = false;

                        for (int i = 0; i < grid_termCredit.Rows.Count; i++)
                        {
                            if (grid_termCredit.Rows[i].Cells["InvoiceNumber"].Value.ToString() == grid_invoice.Rows[e.RowIndex].Cells["No."].Value.ToString())
                            {
                                grid_termCredit.Rows.RemoveAt(i);
                            }
                        }

                        for (int i = 0; i < grid_selectedInvoice.Rows.Count; i++)
                        {
                            if (grid_selectedInvoice.Rows[i].Cells["No."].Value.ToString() == grid_invoice.Rows[e.RowIndex].Cells["No."].Value.ToString())
                            {
                                grid_selectedInvoice.Rows.RemoveAt(i);
                            }
                        }

                    }

                    Decimal CheckedTotalInvoiceAmount = 0;
                    Decimal CheckedTotalInvoiceCount = 0;
                    for (int i = 0; i < grid_invoice.RowCount; i++)
                    {
                        if (Convert.ToBoolean(grid_invoice.Rows[i].Cells["invoiceSelect"].EditedFormattedValue) == true)
                        {
                            //체크된 오더의 order amount 합 구하기
                            Decimal Amount = Convert.ToDecimal(grid_invoice.Rows[i].Cells["Amt"].Value.ToString());
                            CheckedTotalInvoiceAmount = CheckedTotalInvoiceAmount + Amount;

                            //체크된 오더의 갯수 구하기
                            CheckedTotalInvoiceCount = CheckedTotalInvoiceCount + 1;
                        }
                    }
                    //txt_invoice.Text = CheckedTotalInvoiceAmount.ToString("C");

                    //CalculateAmount();

                    Decimal CheckedTotalTermCreditAmount = 0;
                    Decimal CheckedTotalTermCreditCount = 0;
                    for (int i = 0; i < grid_termCredit.RowCount; i++)
                    {
                        if (Convert.ToBoolean(grid_termCredit.Rows[i].Cells["termCreditSelect"].EditedFormattedValue) == true)
                        {
                            //체크된 오더의 order amount 합 구하기
                            Decimal Amount = Convert.ToDecimal(grid_termCredit.Rows[i].Cells["Amount"].Value.ToString());
                            CheckedTotalTermCreditAmount = CheckedTotalTermCreditAmount + Amount;

                            //체크된 오더의 갯수 구하기
                            CheckedTotalTermCreditCount = CheckedTotalTermCreditCount + 1;
                        }
                    }
                    //txt_return.Text = CheckedTotalReturnAmount.ToString("C");
                    txt_termCredit.Text = CheckedTotalTermCreditAmount.ToString("N2");

                    CalculateAmount();
                }
                catch
                {
                    //MessageBox.Show("choose paid check or cash.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                

            }

        }

        private void grid_selectedInvoiceTotal_Init()
        {
            grid_selectedInvoiceTotal.ColumnHeadersVisible = false;
            grid_selectedInvoiceTotal.AutoGenerateColumns = false;
            grid_selectedInvoiceTotal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_selectedInvoiceTotal.ColumnCount = 14;

            grid_selectedInvoiceTotal.Columns[0].Name = "Customer";
            grid_selectedInvoiceTotal.Columns[0].ReadOnly = true;
            grid_selectedInvoiceTotal.Columns[0].Width = 115;
            grid_selectedInvoiceTotal.Columns[0].MinimumWidth = 115;
            //grid_selectedInvoiceTotal.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoiceTotal.Columns[0].DataPropertyName = "BPR_0";

            grid_selectedInvoiceTotal.Columns[1].Name = "Site";
            grid_selectedInvoiceTotal.Columns[1].ReadOnly = true;
            grid_selectedInvoiceTotal.Columns[1].Width = 40;
            grid_selectedInvoiceTotal.Columns[1].MinimumWidth = 40;
            //grid_selectedInvoiceTotal.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoiceTotal.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_selectedInvoiceTotal.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_selectedInvoiceTotal.Columns[1].DataPropertyName = "FCY_0";

            grid_selectedInvoiceTotal.Columns[2].Name = "Order No.";
            //grid_selectedInvoiceTotal.Columns[2].Visible = false;
            grid_selectedInvoiceTotal.Columns[2].ReadOnly = true;
            grid_selectedInvoiceTotal.Columns[2].Width = 90;
            grid_selectedInvoiceTotal.Columns[2].MinimumWidth = 90;
            //grid_selectedInvoiceTotal.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoiceTotal.Columns[2].DataPropertyName = "OrderID";

            grid_selectedInvoiceTotal.Columns[3].Name = "Delv No.";
            grid_selectedInvoiceTotal.Columns[3].ReadOnly = true;
            grid_selectedInvoiceTotal.Columns[3].Width = 100;
            grid_selectedInvoiceTotal.Columns[3].MinimumWidth = 100;
            //grid_selectedInvoiceTotal.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoiceTotal.Columns[3].DataPropertyName = "ORIDOCNUM_0";

            grid_selectedInvoiceTotal.Columns[4].Name = "No.";
            grid_selectedInvoiceTotal.Columns[4].ReadOnly = true;
            grid_selectedInvoiceTotal.Columns[4].Width = 75;
            grid_selectedInvoiceTotal.Columns[4].MinimumWidth = 75;
            //grid_selectedInvoiceTotal.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoiceTotal.Columns[4].DataPropertyName = "NUM_0";

            grid_selectedInvoiceTotal.Columns[5].Name = "Date";
            grid_selectedInvoiceTotal.Columns[5].ReadOnly = true;
            grid_selectedInvoiceTotal.Columns[5].Width = 80;
            grid_selectedInvoiceTotal.Columns[5].MinimumWidth = 80;
            grid_selectedInvoiceTotal.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoiceTotal.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_selectedInvoiceTotal.Columns[5].DataPropertyName = "ACCDAT_0";

            grid_selectedInvoiceTotal.Columns[6].Name = "AR Amount";
            grid_selectedInvoiceTotal.Columns[6].ReadOnly = true;
            grid_selectedInvoiceTotal.Columns[6].Width = 80;
            grid_selectedInvoiceTotal.Columns[6].MinimumWidth = 80;
            grid_selectedInvoiceTotal.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoiceTotal.Columns[6].DefaultCellStyle.Format = "N2";
            grid_selectedInvoiceTotal.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoiceTotal.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoiceTotal.Columns[6].DataPropertyName = "ARAmount";

            grid_selectedInvoiceTotal.Columns[7].Name = "Amt";
            grid_selectedInvoiceTotal.Columns[7].ReadOnly = true;
            grid_selectedInvoiceTotal.Columns[7].Width = 80;
            grid_selectedInvoiceTotal.Columns[7].MinimumWidth = 80;
            grid_selectedInvoiceTotal.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoiceTotal.Columns[7].DefaultCellStyle.Format = "N2";
            grid_selectedInvoiceTotal.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoiceTotal.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoiceTotal.Columns[7].DataPropertyName = "AMTATI_0";

            grid_selectedInvoiceTotal.Columns[8].Name = "Net Amount";
            grid_selectedInvoiceTotal.Columns[8].ReadOnly = true;
            grid_selectedInvoiceTotal.Columns[8].Width = 80;
            grid_selectedInvoiceTotal.Columns[8].MinimumWidth = 80;
            grid_selectedInvoiceTotal.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoiceTotal.Columns[8].DefaultCellStyle.Format = "N2";
            grid_selectedInvoiceTotal.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoiceTotal.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoiceTotal.Columns[8].DataPropertyName = "NetAmount";

            grid_selectedInvoiceTotal.Columns[9].Name = "Payment Amount";
            grid_selectedInvoiceTotal.Columns[9].ReadOnly = true;
            grid_selectedInvoiceTotal.Columns[9].Width = 80;
            grid_selectedInvoiceTotal.Columns[9].MinimumWidth = 80;
            grid_selectedInvoiceTotal.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoiceTotal.Columns[9].DefaultCellStyle.Format = "N2";
            grid_selectedInvoiceTotal.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoiceTotal.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoiceTotal.Columns[9].DataPropertyName = "PaymentNetAmount";

            grid_selectedInvoiceTotal.Columns[10].Name = "Payment Term";
            grid_selectedInvoiceTotal.Columns[10].ReadOnly = true;
            grid_selectedInvoiceTotal.Columns[10].Width = 100;
            grid_selectedInvoiceTotal.Columns[10].MinimumWidth = 100;
            grid_selectedInvoiceTotal.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoiceTotal.Columns[10].DataPropertyName = "PTE_0";

            grid_selectedInvoiceTotal.Columns[11].Name = "ShortOver";
            grid_selectedInvoiceTotal.Columns[11].ReadOnly = true;
            grid_selectedInvoiceTotal.Columns[11].Width = 70;
            grid_selectedInvoiceTotal.Columns[11].MinimumWidth = 70;
            grid_selectedInvoiceTotal.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoiceTotal.Columns[11].DataPropertyName = "ShortOver";

            grid_selectedInvoiceTotal.Columns[12].Name = "Short/Over Amount";
            grid_selectedInvoiceTotal.Columns[12].ReadOnly = true;
            grid_selectedInvoiceTotal.Columns[12].Width = 80;
            grid_selectedInvoiceTotal.Columns[12].MinimumWidth = 80;
            grid_selectedInvoiceTotal.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoiceTotal.Columns[12].DefaultCellStyle.Format = "N2";
            grid_selectedInvoiceTotal.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoiceTotal.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_selectedInvoiceTotal.Columns[12].DataPropertyName = "";

            grid_selectedInvoiceTotal.Columns[13].Name = "Delete";
            grid_selectedInvoiceTotal.Columns[13].ReadOnly = true;
            grid_selectedInvoiceTotal.Columns[13].Width = 50;
            grid_selectedInvoiceTotal.Columns[13].MinimumWidth = 50;
            grid_selectedInvoiceTotal.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectedInvoiceTotal.Columns[13].DataPropertyName = "Delete";

            //grid font size custom
            grid_selectedInvoiceTotal.RowTemplate.Height = 20;
            grid_selectedInvoiceTotal.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_selectedInvoiceTotal.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_selectedInvoiceTotal.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }


        private void grid_termCredit_Init()
        {
            grid_termCredit.AutoGenerateColumns = false;
            grid_termCredit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_termCredit.ColumnCount = 4;

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

            grid_termCredit.Columns[1].Name = "Term";
            grid_termCredit.Columns[1].ReadOnly = true;
            grid_termCredit.Columns[1].Width = 70;
            grid_termCredit.Columns[1].MinimumWidth = 70;
            grid_termCredit.Columns[1].DataPropertyName = "Term";

            grid_termCredit.Columns[2].Name = "Percent";
            grid_termCredit.Columns[2].ReadOnly = true;
            grid_termCredit.Columns[2].Width = 35;
            grid_termCredit.Columns[2].MinimumWidth = 35;
            grid_termCredit.Columns[2].DefaultCellStyle.Format = "N2";
            grid_termCredit.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_termCredit.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_termCredit.Columns[2].DataPropertyName = "Percent";

            grid_termCredit.Columns[3].Name = "Amount";
            grid_termCredit.Columns[3].ReadOnly = false;
            grid_termCredit.Columns[3].Width = 60;
            grid_termCredit.Columns[3].MinimumWidth = 60;
            grid_termCredit.Columns[3].DefaultCellStyle.Format = "N2";
            grid_termCredit.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_termCredit.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_termCredit.Columns[3].DataPropertyName = "Amount";

            grid_termCredit.Columns[4].Name = "InvoiceNumber";
            grid_termCredit.Columns[4].ReadOnly = true;
            grid_termCredit.Columns[4].Width = 70;
            grid_termCredit.Columns[4].MinimumWidth = 70;
            grid_termCredit.Columns[4].DataPropertyName = "InvoiceNumber";



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
                try
                {
                    if (Convert.ToBoolean(grid_termCredit.Rows[e.RowIndex].Cells["termCreditSelect"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                    {
                        grid_termCredit.Rows[e.RowIndex].Cells["termCreditSelect"].Value = true;
                        //finished
                        //MessageBox.Show("The Route " + RouteNumber + " has been Finished.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);       
                        //Decimal TermDiscountAmount = (Convert.ToDecimal(grid_termCredit.Rows[e.RowIndex].Cells["Percent"].Value.ToString()) /100) * Convert.ToDecimal(grid_termCredit.Rows[e.RowIndex].Cells["Percent"].Value.ToString());

                        for (int i = 0; i < grid_selectedInvoice.Rows.Count; i++)
                        {


                            if (grid_selectedInvoice.Rows[i].Cells["No."].Value.ToString() == grid_termCredit.Rows[e.RowIndex].Cells["InvoiceNumber"].Value.ToString())
                            {
                                Decimal Amt = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Amt"].Value.ToString());
                                Decimal NetAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Net Amount"].Value.ToString());
                                Decimal PaymentAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value.ToString());
                                Decimal TermCreditAmount = Convert.ToDecimal(grid_termCredit.Rows[e.RowIndex].Cells["Amount"].Value.ToString());

                                grid_selectedInvoice.Rows[i].Cells["Net Amount"].Value = (Amt - TermCreditAmount).ToString("N2");
                                NetAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Net Amount"].Value.ToString());

                                if (NetAmount < PaymentAmount)
                                {
                                    grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value = (NetAmount).ToString("N2");
                                }
                            }



                        }

                    }
                    else // uncheck 했을 때
                    {

                        grid_termCredit.Rows[e.RowIndex].Cells["termCreditSelect"].Value = false;
                        //not finished
                        //MessageBox.Show("The Route " + RouteNumber + " has been unchecked finish.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_termCredit.Text = "";

                        for (int i = 0; i < grid_selectedInvoice.Rows.Count; i++)
                        {
                            if (grid_selectedInvoice.Rows[i].Cells["No."].Value.ToString() == grid_termCredit.Rows[e.RowIndex].Cells["InvoiceNumber"].Value.ToString())
                            {
                                Decimal NetAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Amt"].Value.ToString());
                                Decimal TermCreditAmount = Convert.ToDecimal(grid_termCredit.Rows[e.RowIndex].Cells["Amount"].Value.ToString());

                                grid_selectedInvoice.Rows[i].Cells["Net Amount"].Value = NetAmount.ToString("N2");
                            }
                        }
                    }

                    Decimal CheckedTotalTermCreditAmount = 0;
                    Decimal CheckedTotalTermCreditCount = 0;
                    for (int i = 0; i < grid_termCredit.RowCount; i++)
                    {
                        if (Convert.ToBoolean(grid_termCredit.Rows[i].Cells["termCreditSelect"].EditedFormattedValue) == true)
                        {
                            //체크된 오더의 order amount 합 구하기
                            Decimal Amount = Convert.ToDecimal(grid_termCredit.Rows[i].Cells["Amount"].Value.ToString());
                            CheckedTotalTermCreditAmount = CheckedTotalTermCreditAmount + Amount;

                            //체크된 오더의 갯수 구하기
                            CheckedTotalTermCreditCount = CheckedTotalTermCreditCount + 1;

                        }
                    }
                    //txt_return.Text = CheckedTotalReturnAmount.ToString("C");
                    txt_termCredit.Text = CheckedTotalTermCreditAmount.ToString("N2");



                    CalculateAmount();
                }
                catch
                {
                    //grid_termCredit.Rows[e.RowIndex].Cells["termCreditSelect"].Value = false;
                    MessageBox.Show("Please Choose paid check, cash first.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }

        private void grid_paidCashCheck_Init()
        {
            grid_paidCashCheck.AutoGenerateColumns = false;
            grid_paidCashCheck.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_paidCashCheck.ColumnCount = 6;

            DataGridViewCheckBoxColumn paidCashCheckCheck = new DataGridViewCheckBoxColumn();
            paidCashCheckCheck.HeaderText = "X";
            paidCashCheckCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            paidCashCheckCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            paidCashCheckCheck.FalseValue = false;
            paidCashCheckCheck.TrueValue = true;
            paidCashCheckCheck.Name = "paidCashCheckSelect";
            paidCashCheckCheck.ReadOnly = true;
            paidCashCheckCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            paidCashCheckCheck.Width = 25;
            paidCashCheckCheck.MinimumWidth = 25;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_paidCashCheck.Columns.Insert(0, paidCashCheckCheck);
            grid_paidCashCheck.CellContentClick += new DataGridViewCellEventHandler(paidCashCheckSelect);

            grid_paidCashCheck.Columns[1].Name = "Check/Cash";
            grid_paidCashCheck.Columns[1].ReadOnly = true;
            grid_paidCashCheck.Columns[1].Width = 60;
            grid_paidCashCheck.Columns[1].MinimumWidth = 60;
            grid_paidCashCheck.Columns[1].DataPropertyName = "CashCheck";

            grid_paidCashCheck.Columns[2].Name = "Amount";
            grid_paidCashCheck.Columns[2].ReadOnly = true;
            grid_paidCashCheck.Columns[2].Width = 60;
            grid_paidCashCheck.Columns[2].MinimumWidth = 60;
            grid_paidCashCheck.Columns[2].DefaultCellStyle.Format = "N2";
            grid_paidCashCheck.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_paidCashCheck.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_paidCashCheck.Columns[2].DataPropertyName = "Amount";

            grid_paidCashCheck.Columns[3].Name = "Check Date";
            //grid_paidCashCheck.Columns[3].ReadOnly = true;
            grid_paidCashCheck.Columns[3].Width = 75;
            grid_paidCashCheck.Columns[3].MinimumWidth = 75;
            grid_paidCashCheck.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_paidCashCheck.Columns[3].DataPropertyName = "CheckDate";

            grid_paidCashCheck.Columns[4].Name = "Check No.";
            grid_paidCashCheck.Columns[4].ReadOnly = true;
            grid_paidCashCheck.Columns[4].Width = 70;
            grid_paidCashCheck.Columns[4].MinimumWidth = 70;
            grid_paidCashCheck.Columns[4].DataPropertyName = "CheckNumber";

            grid_paidCashCheck.Columns[5].Name = "DeliveryNumber";
            grid_paidCashCheck.Columns[5].Visible = false;
            grid_paidCashCheck.Columns[5].Width = 80;
            grid_paidCashCheck.Columns[5].MinimumWidth = 80;
            grid_paidCashCheck.Columns[5].DataPropertyName = "DeliveryNumber";

            DataGridViewButtonColumn deletePaidButton = new DataGridViewButtonColumn();
            deletePaidButton.Width = 50;
            deletePaidButton.MinimumWidth = 50;
            deletePaidButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deletePaidButton.Name = "Delete";
            deletePaidButton.Text = "Delete";
            deletePaidButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deletePaidButton.UseColumnTextForButtonValue = true;
            if (grid_paidCashCheck.Columns["Delete"] == null)
            {
                grid_paidCashCheck.Columns.Insert(6, deletePaidButton);
            }

            grid_paidCashCheck.Columns[7].Name = "id";
            grid_paidCashCheck.Columns[7].Visible = false;
            grid_paidCashCheck.Columns[7].Width = 50;
            grid_paidCashCheck.Columns[7].MinimumWidth = 50;
            //grid_paidCashCheck.Columns[7].Visible = false;
            grid_paidCashCheck.Columns[7].DataPropertyName = "id";

            //grid font size custom
            grid_paidCashCheck.RowTemplate.Height = 20;
            grid_paidCashCheck.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_paidCashCheck.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_paidCashCheck.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        

        private void prePaidSelect(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_paymentInfo_Init()
        {
            grid_paymentInfo.AutoGenerateColumns = false;
            grid_paymentInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_paymentInfo.ColumnCount = 7;


            grid_paymentInfo.Columns[0].Name = "Type";
            grid_paymentInfo.Columns[0].ReadOnly = true;
            grid_paymentInfo.Columns[0].Width = 60;
            grid_paymentInfo.Columns[0].MinimumWidth = 60;
            grid_paymentInfo.Columns[0].DataPropertyName = "Kinds";

            grid_paymentInfo.Columns[1].Name = "Payment Amount";
            grid_paymentInfo.Columns[1].ReadOnly = true;
            grid_paymentInfo.Columns[1].Width = 55;
            grid_paymentInfo.Columns[1].MinimumWidth = 55;
            grid_paymentInfo.Columns[1].DefaultCellStyle.Format = "N2";
            grid_paymentInfo.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_paymentInfo.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_paymentInfo.Columns[1].DataPropertyName = "Amount";

            grid_paymentInfo.Columns[2].Name = "Document No.";
            grid_paymentInfo.Columns[2].ReadOnly = true;
            grid_paymentInfo.Columns[2].Width = 80;
            grid_paymentInfo.Columns[2].MinimumWidth = 80;
            grid_paymentInfo.Columns[2].DataPropertyName = "DocumentNumber";

            grid_paymentInfo.Columns[3].Name = "Delivery No.";
            grid_paymentInfo.Columns[3].ReadOnly = true;
            grid_paymentInfo.Columns[3].Width = 80;
            grid_paymentInfo.Columns[3].MinimumWidth = 80;
            grid_paymentInfo.Columns[3].DataPropertyName = "DeliveryNumber";
            
            grid_paymentInfo.Columns[4].Name = "Term Credit Invoice No.";
            grid_paymentInfo.Columns[4].ReadOnly = true;
            grid_paymentInfo.Columns[4].Width = 60;
            grid_paymentInfo.Columns[4].MinimumWidth = 60;
            grid_paymentInfo.Columns[4].DataPropertyName = "InvoiceNumber";

            grid_paymentInfo.Columns[5].Name = "Ship Date";
            grid_paymentInfo.Columns[5].ReadOnly = true;
            grid_paymentInfo.Columns[5].Width = 65;
            grid_paymentInfo.Columns[5].MinimumWidth = 65;
            grid_paymentInfo.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_paymentInfo.Columns[5].DataPropertyName = "ShipDate";
            
            grid_paymentInfo.Columns[6].Name = "Memo";
            grid_paymentInfo.Columns[6].ReadOnly = true;
            grid_paymentInfo.Columns[6].Width = 100;
            grid_paymentInfo.Columns[6].DataPropertyName = "Memo";

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

        private void paidCashCheckSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Ready check box click
            {
                //if (grid_paidCashCheck.Rows[e.RowIndex].Cells["Check/Cash"].Value.ToString() == "Check")
                //{
                //    for (int j = 0; j < grid_paidCashCheck.RowCount; j++)
                //    {
                //        grid_paidCashCheck.Rows[e.RowIndex].Cells["paidCashCheckSelect"].Value = true;
                //    }
                //}
                
                if (Convert.ToBoolean(grid_paidCashCheck.Rows[e.RowIndex].Cells["paidCashCheckSelect"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                {
                    //finished
                    //MessageBox.Show("The Route " + RouteNumber + " has been Finished.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    for (int i = 0; i < grid_paidCashCheck.RowCount; i++)
                    {
                        if (Convert.ToBoolean(grid_paidCashCheck.Rows[i].Cells["paidCashCheckSelect"].EditedFormattedValue) == true)
                        {
                            MessageBox.Show("Can choose only 1 paid check, cash or ASH.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;

                        }
                    }

                    grid_paidCashCheck.Rows[e.RowIndex].Cells["paidCashCheckSelect"].Value = true;

                    //payment bank cash: BVC,  check: WB436, ACH: BCSB
                    if(grid_paidCashCheck.Rows[e.RowIndex].Cells["Check/Cash"].Value.ToString() == "Cash")
                    {
                        cbo_bank.Text = "BVC";
                    }
                    else if(grid_paidCashCheck.Rows[e.RowIndex].Cells["Check/Cash"].Value.ToString() == "Check")
                    {
                        cbo_bank.Text = "WB436";
                    }
                    else if (grid_paidCashCheck.Rows[e.RowIndex].Cells["Check/Cash"].Value.ToString() == "ACH")
                    {
                        cbo_bank.Text = "BCSB";
                    }
                    
                }
                else // uncheck 했을 때
                {

                    grid_paidCashCheck.Rows[e.RowIndex].Cells["paidCashCheckSelect"].Value = false;
                    //not finished
                    //MessageBox.Show("The Route " + RouteNumber + " has been unchecked finish.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                Decimal CheckedTotalPaidAmount = 0;
                Decimal CheckedTotalPaidCount = 0;
                for (int i = 0; i < grid_paidCashCheck.RowCount; i++)
                {

                    if (Convert.ToBoolean(grid_paidCashCheck.Rows[i].Cells["paidCashCheckSelect"].EditedFormattedValue) == true)
                    {
                        //체크된 오더의 order amount 합 구하기
                        Decimal Amount = Convert.ToDecimal(grid_paidCashCheck.Rows[i].Cells["Amount"].Value.ToString());

                        CheckedTotalPaidAmount = CheckedTotalPaidAmount + Amount;

                        //체크된 오더의 갯수 구하기
                        CheckedTotalPaidCount = CheckedTotalPaidCount + 1;
                    }
                }
                //txt_return.Text = CheckedTotalReturnAmount.ToString("C");
                txt_arPaymentTotal.Text = CheckedTotalPaidAmount.ToString("N2");

                CalculateAmount();

            }
        }

        private void cbox_customer_Init()
        {
            cbox_customer.Items.Clear();
            cbox_customer.Items.Add("");
            connPO.cbox_getCustomerID(cbox_customer);
        }

        private void cbox_customer_DroppedDown()
        {
            cbox_customer.DroppedDown = true;
        }

        private void cbox_customer_Enter(object sender, EventArgs e)
        {
            //cbox_customer_DroppedDown();
        }

        private void cbox_customer_Click(object sender, EventArgs e)
        {
            cbox_customer_DroppedDown();
        }

        private void cbox_customer_SelectedValueChanged(object sender, EventArgs e)
        {
            lbl_customerInfo.Text = "";
            //MessageBox.Show("cbox_customer_SelectedValueChanged");
            //refresh();
            grid_payment.DataSource = null;
            grid_paymentInfo.DataSource = null;
            grid_invoice.DataSource = null;
            grid_termCredit.DataSource = null;
            grid_paidCashCheck.DataSource = null;
            String EntryBatch = txt_entryBatch.Text.Trim();

            //Action<Control.ControlCollection> func = null;

            //func = (controls) =>
            //{
            //    foreach (Control control in controls)
            //        if (control is TextBox)
            //            (control as TextBox).Clear();
            //        else
            //            func(control.Controls);
            //};

            //func(Controls);
            txt_arPaymentTotal.Text = "0.00";
            
            txt_entryBatch.Text = EntryBatch;

            //if(cbox_customer.Text.Trim() == "")
            //{
            //    refresh();
            //}
            //refresh();

            CalculateAmount();
            

        }

        private void cbox_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbox_customer.DroppedDown = false;
                refresh();
            }
        }

        private void CalculateAmount()
        {
            Decimal TotalNetAmount = 0;
            Decimal TotalShortOver = 0;

            for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
            {
                Decimal NetAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Amt"].Value.ToString());
                TotalNetAmount = TotalNetAmount + NetAmount;

                //MessageBox.Show(grid_selectedInvoice.Rows[i].Cells["ShortOver"].Value.ToString());
                //MessageBox.Show("1" + grid_selectedInvoice.Rows[i].Cells["ShortOver"].Value.ToString().Trim() + "2");
                if (grid_selectedInvoice.Rows[i].Cells["ShortOver"].Value.ToString().Trim() != "")
                {
                    Decimal ShortOver = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Short/Over Amount"].Value.ToString().Trim());
                    if (grid_selectedInvoice.Rows[i].Cells["ShortOver"].Value.ToString().Trim() == "Short")
                        ShortOver = ShortOver * -1;

                    TotalShortOver = TotalShortOver + ShortOver;
                }

            }

            txt_invoiceNetAmountTotal.Text = TotalNetAmount.ToString("N2");
            txt_ARTotal.Text = TotalNetAmount.ToString("N2");
            txt_shortOver.Text = TotalShortOver.ToString("N2");




            for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
            {
                Decimal NetAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Amt"].Value.ToString().Trim());
                
                
                String InvoiceOrderNumber = grid_selectedInvoice.Rows[i].Cells["Order No."].Value.ToString().Trim();
                String InvoiceNumber = grid_selectedInvoice.Rows[i].Cells["No."].Value.ToString().Trim();
                    
                //Term Credit
                for (int t = 0; t < grid_termCredit.RowCount; t++)
                {
                    String termInvoiceNumber = grid_termCredit.Rows[t].Cells["InvoiceNumber"].Value.ToString().Trim();

                    if (termInvoiceNumber == InvoiceNumber)
                    {
                        //Decimal discountRate = Convert.ToDecimal(grid_termCredit.Rows[t].Cells["Percent"].Value.ToString().Trim());
                        //grid_termCredit.Rows[t].Cells["Amount"].Value = (discountRate / 100 * NetAmount).ToString("N2");
                    }
                }
                
            }

            Decimal Invoice, Credit, Return, TermCredit;
            if (txt_invoiceNetAmountTotal.Text == "")
            {
                Invoice = 0;
            }
            else
            {
                Invoice = Convert.ToDecimal(txt_invoiceNetAmountTotal.Text);
            }
            

            if (txt_termCredit.Text == "")
            {
                TermCredit = 0;
            }
            else
            {
                TermCredit = Convert.ToDecimal(txt_termCredit.Text);
            }

            Decimal TotalAmount = Invoice - TermCredit;
            txt_ARTotal.Text = TotalAmount.ToString("N2");


            Decimal ARPaymentTotal, ARTotal, Diff;
            if (txt_arPaymentTotal.Text == "")
            {
                ARPaymentTotal = 0;
            }
            else
            {
                ARPaymentTotal = Convert.ToDecimal(txt_arPaymentTotal.Text);
            }

            if (txt_ARTotal.Text == "")
            {
                ARTotal = 0;
            }
            else
            {
                ARTotal = Convert.ToDecimal(txt_ARTotal.Text);
            }

            if (txt_diff.Text == "")
            {
                Diff = 0;
            }
            else
            {
                Diff = Convert.ToDecimal(txt_diff.Text);
            }
            
            Diff = ARTotal - ARPaymentTotal;
            Diff = Diff + TotalShortOver;
            txt_diff.Text = Diff.ToString("N2");

            Decimal TotalInvoiceARAmount = 0;
            Decimal TotalInvoiceAmt = 0;
            Decimal TotalInvoiceNetAmount = 0;
            Decimal TotalInvoicePaymentAmount = 0;
            Decimal TotalInvoiceShortOverAmount = 0;

            Decimal Remaining = Convert.ToDecimal(txt_arPaymentTotal.Text.Trim());

            for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
            {
                Decimal ARAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["AR Amount"].Value.ToString().Trim());
                Decimal Amt = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Amt"].Value.ToString().Trim());
                Decimal NetAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Net Amount"].Value.ToString().Trim());
                Decimal PaymentAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value.ToString().Trim());
                Decimal ShortOverAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Short/Over Amount"].Value.ToString().Trim());

                TotalInvoiceARAmount = TotalInvoiceARAmount + ARAmount;
                TotalInvoiceAmt = TotalInvoiceAmt + Amt;
                TotalInvoiceNetAmount = TotalInvoiceNetAmount + NetAmount;
                TotalInvoicePaymentAmount = TotalInvoicePaymentAmount + PaymentAmount;
                TotalInvoiceShortOverAmount = TotalInvoiceShortOverAmount + ShortOverAmount;

            }

            grid_selectedInvoiceTotal.Rows[0].Cells["AR Amount"].Value = TotalInvoiceARAmount.ToString("N2");
            grid_selectedInvoiceTotal.Rows[0].Cells["Amt"].Value = TotalInvoiceAmt.ToString("N2");
            grid_selectedInvoiceTotal.Rows[0].Cells["Net Amount"].Value = TotalInvoiceNetAmount.ToString("N2");
            grid_selectedInvoiceTotal.Rows[0].Cells["Payment Amount"].Value = TotalInvoicePaymentAmount.ToString("N2");
            grid_selectedInvoiceTotal.Rows[0].Cells["Short/Over Amount"].Value = TotalInvoiceShortOverAmount.ToString("N2");
            grid_selectedInvoiceTotal.Rows[0].Cells["Payment Term"].Value = "(" + (Remaining - TotalInvoicePaymentAmount).ToString("N2") + ")";

        }

        private void txt_shortOver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CalculateAmount();
            }
        }

        private void txt_shortOver_KeyDown(object sender, KeyEventArgs e)
        {

        }

        String PAM_0;

        private void btn_payment_Click(object sender, EventArgs e)
        {
            if (cbox_customer.Text.Trim() =="")
            {
                MessageBox.Show("Please choose customer.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop); 
                return;
            }

            //checking difference >= 0
            Decimal Difference = Convert.ToDecimal(txt_diff.Text.Trim());
            if(Difference < 0)
            {
                MessageBox.Show("Check over or short amount.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop); //difference < 0
                return;
            }
            
            //===================Start Short, Over check========================
            string ShortOverCheck = "";
            bool firstOne = false;
            for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
            {
                if(grid_selectedInvoice.Rows[i].Cells["ShortOver"].Value.ToString().Trim() != "")
                {
                    if(firstOne == false)
                    {
                        ShortOverCheck = grid_selectedInvoice.Rows[i].Cells["ShortOver"].Value.ToString().Trim();
                        firstOne = true;
                    }

                    Decimal ShortOverAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Short/Over Amount"].Value.ToString().Trim());
                    if (ShortOverAmount <= 0)
                    {
                        MessageBox.Show("Invalid Short/OverAmount.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop); //(<= 0)
                        return;
                    }
                        

                    if(ShortOverCheck != grid_selectedInvoice.Rows[i].Cells["ShortOver"].Value.ToString().Trim())
                    {
                        MessageBox.Show("Cannot choose short and over at the same time.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop); //ShortOver != PreviousShortOver
                        return;
                    }

                    if (grid_selectedInvoice.Rows[i].Cells["ShortOver"].Value.ToString().Trim() == "Over")
                    {
                        Decimal PaymentAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value.ToString().Trim());
                        Decimal NetAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Net Amount"].Value.ToString().Trim());
                        if(PaymentAmount != NetAmount)
                        {
                            MessageBox.Show("Invaild payment amount and Over Amount.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);//(Over) PaymentAmount != NetAmount
                            return;
                        }
                        
                    }

                    if (grid_selectedInvoice.Rows[i].Cells["ShortOver"].Value.ToString().Trim() == "Short")
                    {
                        Decimal NetAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Net Amount"].Value.ToString().Trim());
                        Decimal PaymentAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value.ToString().Trim());
                        Decimal InvoiceShortOverAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Short/Over Amount"].Value.ToString().Trim());
                        if ((PaymentAmount + InvoiceShortOverAmount) > NetAmount)
                        {
                            MessageBox.Show("Invaild payment amount and Short Amount.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);//(Short) PaymentAmount + InvoiceShortOverAmount) > NetAmount
                            return;
                        }

                    }
                }
            }

            //over있을때는 diff를 0을 맞춰야 한다.
            if(ShortOverCheck == "Over" && Difference != 0)
            {
                MessageBox.Show("Invaild payment amount and Over Amount. (Over Amount)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);//ShortOverCheck == Over && Difference != 0
                return;
            }
            
            //Checking Payment Amount
            Decimal TotalPaymentAmount = 0;
            for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
            {
                Decimal PaymentAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value.ToString().Trim());
                Decimal OverAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Short/Over Amount"].Value.ToString().Trim());
                if(ShortOverCheck == "Over")
                {
                    PaymentAmount = PaymentAmount + OverAmount;
                }

                TotalPaymentAmount = TotalPaymentAmount + PaymentAmount;
            }
            Decimal ARPaymentTotal = Convert.ToDecimal(txt_arPaymentTotal.Text.Trim());

            if (TotalPaymentAmount != ARPaymentTotal)
            {
                MessageBox.Show("Total Payment Amount has to be same as AR Payment Total", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop); //TotalPaymentAmount != ARPaymentTotal
                return;
            }

            //*******************End Short, Over check****************************


            //===================Start Checking payment amount========================
            for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
            {
                Decimal PaymentAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value.ToString().Trim());

                if (PaymentAmount <= 0)
                {
                    MessageBox.Show("Invaild payment amount.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop); //PaymentAmount <= 0
                    return;
                }

                Decimal NetAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Net Amount"].Value.ToString());
                
                //over일때는 모든 amount를 처리하고 over에 나머지 Amount넣을 수 있다.
                if (grid_selectedInvoice.Rows[i].Cells["ShortOver"].Value.ToString().Trim() == "Over")
                {
                    if(PaymentAmount != NetAmount)
                    {
                        MessageBox.Show("Invaild over amount.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop); //PaymentAmount != NetAmount
                        return;
                    }
                }

                //short 일때  클리어 할때만 할수 있다.
                if (grid_selectedInvoice.Rows[i].Cells["ShortOver"].Value.ToString().Trim() == "Short")
                {
                    Decimal Short = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Short/Over Amount"].Value.ToString().Trim());

                    if (PaymentAmount + Short != NetAmount)
                    {
                        MessageBox.Show("Invalid value (Short)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }

            }


            //*******************End Checking payment amount**************************
           
            //확인 메시지 시작
            //DialogResult dialogResult2 = MessageBox.Show("Are you sure run the payment process?\n\n" // +
            //                                , "Payment Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            //if (dialogResult2 == DialogResult.Yes)
            //{
                String PaymentType = "";
                String PaymentTypePAM_0 = "";
                for (int i = 0; i < grid_paidCashCheck.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_paidCashCheck.Rows[i].Cells["paidCashCheckSelect"].EditedFormattedValue) == true)
                    {
                        PaymentType = grid_paidCashCheck.Rows[i].Cells["Check/Cash"].Value.ToString().Trim();
                    }
                }
                if(PaymentType == "Cash")
                {
                    PaymentTypePAM_0 = "CSH";
                }
                else if (PaymentType == "Check")
                {
                    PaymentTypePAM_0 = "CHQ";
                }
                else if (PaymentType == "ACH")
                {
                    PaymentTypePAM_0 = "ACH";
                }
                else
                {
                    MessageBox.Show("Invalid paid.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                String NewPaymentNumber = connSalesOrder.sp_GET_NewPaymentNumber(PaymentTypePAM_0);

                //===================Start Selected Invoice========================
                for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
                {
                    String CustomerID = grid_selectedInvoice.Rows[i].Cells["Customer"].Value.ToString().Trim();
                    Decimal PaymentAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value.ToString().Trim());
                    String InvoiceNumber = grid_selectedInvoice.Rows[i].Cells["No."].Value.ToString().Trim();
                    String ShortOver = grid_selectedInvoice.Rows[i].Cells["ShortOver"].Value.ToString().Trim();
                    Decimal ShortOverAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Short/Over Amount"].Value.ToString().Trim());

                    //if(ShortOver != "" && ShortOverAmount > 0)
                    //{
                        connSalesOrder.sp_PAYMENTT_INVOICE_AR(NewPaymentNumber, CustomerID, InvoiceNumber, PaymentAmount, ShortOver, ShortOverAmount);
                    //}
                    
                    connSalesOrder.sp_PAYMENTT_INVOICE(NewPaymentNumber, CustomerID, InvoiceNumber, PaymentAmount);

                    //connSalesOrder.sp_PAYMENTT_INVOICE_SHORTOVER(NewPaymentNumber, CustomerID, InvoiceNumber, ShortOver, ShortOverAmount);
                }
                //*******************End Selected Invoice**************************

                //===================Start Term Credit========================
                for (int i = 0; i < grid_termCredit.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_termCredit.Rows[i].Cells["termCreditSelect"].EditedFormattedValue) == true)
                    {
                        String InvoiceNumber = grid_termCredit.Rows[i].Cells["InvoiceNumber"].Value.ToString().Trim();
                        Decimal TermCreditAmount = Convert.ToDecimal(grid_termCredit.Rows[i].Cells["Amount"].Value.ToString().Trim());

                        connSalesOrder.sp_PAYMENTT_TERMCREDIT(NewPaymentNumber, InvoiceNumber, TermCreditAmount);
                    }
                }
                //*******************End Term Credit**************************
                for (int i = 0; i < grid_paidCashCheck.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_paidCashCheck.Rows[i].Cells["paidCashCheckSelect"].EditedFormattedValue) == true)
                    {
                        String Bank = cbo_bank.Text.Trim();
                        String Site = cbo_site.Text.Trim();
                        String CheckNumber = grid_paidCashCheck.Rows[i].Cells["Check No."].Value.ToString();
                        DateTime Date = Convert.ToDateTime(grid_paidCashCheck.Rows[i].Cells["Check Date"].Value.ToString());
                        Decimal paidAmount = Convert.ToDecimal(grid_paidCashCheck.Rows[i].Cells["Amount"].Value.ToString());
                        String DeliveryNumber = grid_paidCashCheck.Rows[i].Cells["DeliveryNumber"].Value.ToString();
                        String id = grid_paidCashCheck.Rows[i].Cells["id"].Value.ToString();

                        String PAM_0;
                        if (grid_paidCashCheck.Rows[i].Cells["Check/Cash"].Value.ToString() == "Cash")
                        {
                            PAM_0 = "CSH";
                        }
                        else if (grid_paidCashCheck.Rows[i].Cells["Check/Cash"].Value.ToString() == "Check")
                        {
                            PAM_0 = "CHQ";
                        }
                        else// ACH
                        {
                            PAM_0 = "ACH";
                        }
                        String EntryBatch = txt_entryBatch.Text.Trim();

                        String PaymentCustomerID = cbox_customer.Text.Trim();

                        connSalesOrder.sp_PAYMENTT(NewPaymentNumber, PaymentCustomerID, CheckNumber, Date, paidAmount, PAM_0, Site, Bank, EntryBatch, id);
                    }
                }

                grid_invoice.DataSource = null;
                grid_termCredit.DataSource = null;
                grid_termCredit.Rows.Clear();
                grid_paidCashCheck.DataSource = null;
                grid_paymentInfo.DataSource = null;
                grid_selectedInvoice.DataSource = null;

                txt_invoiceNetAmountTotal.Text = "0.00";
                txt_termCredit.Text = "0.00";
                txt_arPaymentTotal.Text = "0.00";
                txt_ARTotal.Text = "0.00";
                txt_shortOver.Text = "0.00";
                txt_diff.Text = "0.00";

                CalculateAmount();
                grid_selectedInvoice.Rows.Clear();
                refresh();
                //MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            //} --확인 매시지 끝






            //===================Start ========================
            //*******************End **************************




            //int checkedcount = 0;
            //for (int j = 0; j < grid_paidCashCheck.RowCount; j++)
            //{
            //    if (Convert.ToBoolean(grid_paidCashCheck.Rows[j].Cells["paidCashCheckSelect"].EditedFormattedValue) == true)
            //    {
            //        checkedcount = checkedcount + 1;
            //    }
            //}

            //for (int k = 0; k < grid_invoice.RowCount; k++)
            //{
            //    if (Convert.ToBoolean(grid_invoice.Rows[k].Cells["invoiceSelect"].EditedFormattedValue) == true)
            //    {
            //        if(Convert.ToDecimal(grid_invoice.Rows[k].Cells["Net"].Value.ToString().Trim()) < 0)
            //        {
            //            //MessageBox.Show("Net amount can not be less than 0.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //            //return;

            //            //MessageBox.Show("Net amount less than 0.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //            //invoice 한개만 선택 확인
            //            int selectedinvoice = 0;
            //            for (int i = 0; i < grid_invoice.RowCount; i++)
            //            {
            //                if (Convert.ToBoolean(grid_invoice.Rows[i].Cells["invoiceSelect"].EditedFormattedValue) == true)
            //                {
            //                    selectedinvoice = selectedinvoice + 1;


            //                }
            //            }
            //            if(selectedinvoice > 1)
            //            {
            //                MessageBox.Show("can choose only one invoice.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //                return;
            //            }

            //            // term credit 확인
            //            for (int i = 0; i < grid_termCredit.RowCount; i++)
            //            {
            //                if (Convert.ToBoolean(grid_termCredit.Rows[i].Cells["termCreditSelect"].EditedFormattedValue) == true)
            //                {
            //                    MessageBox.Show("Can't check term credit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //                    return;
            //                }
            //            }
            //            //페이 선택되어있는지 확인

            //            int selectedPaid = 0;
            //            for (int i = 0; i < grid_paidCashCheck.RowCount; i++)
            //            {
            //                if (Convert.ToBoolean(grid_paidCashCheck.Rows[i].Cells["paidCashCheckSelect"].EditedFormattedValue) == true)
            //                {
            //                    selectedPaid = selectedPaid + 1;
            //                }
            //            }
            //            if (selectedPaid != 1)
            //            {
            //                MessageBox.Show("check paid cash.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //                return;
            //            }

            //            if (txt_arPaymentTotal.Text != "0.00")
            //            {
            //                MessageBox.Show("cannot pay.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //                return;
            //            }


            //            DialogResult dialogResult2 = MessageBox.Show("Net amount less than 0. Are you sure run the payment process?\n\n" // +
            //                                            , "Payment Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            //            if (dialogResult2 == DialogResult.Yes)
            //            {
            //                decimal PAYMENTAmount = 0;

            //                //Get a new PAYMENT Number from Server 12/24/2018
            //                String NewPaymentNumber = connSalesOrder.sp_GET_NewPaymentNumber("CSH");
            //                String InvoiceNumber = grid_invoice.Rows[k].Cells["No."].Value.ToString();
            //                String PaymentCustomerID = grid_invoice.Rows[k].Cells["Customer"].Value.ToString();

            //                Decimal InvoiceAmount = Convert.ToDecimal(grid_invoice.Rows[k].Cells["Amt"].Value.ToString());

            //                //Return(PAYMENTTD)
            //                for (int i = 0; i < grid_return.RowCount; i++)
            //                {
            //                    if (Convert.ToBoolean(grid_return.Rows[i].Cells["ReturnSelect"].EditedFormattedValue) == true)
            //                    {
            //                        String ReturnNumber = grid_return.Rows[i].Cells["No."].Value.ToString();
            //                        Decimal ReturnAmount = Convert.ToDecimal(grid_return.Rows[i].Cells["Amt"].Value.ToString());
            //                        connSalesOrder.sp_PAYMENTT_RETURN(PaymentCustomerID, ReturnNumber, ReturnAmount, NewPaymentNumber);
            //                    }

            //                }

            //                //***PAYMENT***
            //                connSalesOrder.sp_PAYMENTT_INVOICE(PaymentCustomerID, InvoiceNumber, PAYMENTAmount, NewPaymentNumber);
            //                //***AR***
            //                connSalesOrder.sp_PAYMENTT_INVOICE_AR(PaymentCustomerID, InvoiceNumber, 0, InvoiceAmount, NewPaymentNumber);
            //                //sp_PAYMENTT
            //                for (int i = 0; i < grid_paidCashCheck.RowCount; i++)
            //                {
            //                    if (Convert.ToBoolean(grid_paidCashCheck.Rows[i].Cells["paidCashCheckSelect"].EditedFormattedValue) == true)
            //                    {
            //                        String Bank = cbo_bank.Text.Trim();
            //                        String Site = cbo_site.Text.Trim();
            //                        String CheckNumber = grid_paidCashCheck.Rows[i].Cells["Check No."].Value.ToString();
            //                        DateTime Date = Convert.ToDateTime(grid_paidCashCheck.Rows[i].Cells["Check Date"].Value.ToString());
            //                        Decimal paidAmount = Convert.ToDecimal(grid_paidCashCheck.Rows[i].Cells["Amount"].Value.ToString());
            //                        String DeliveryNumber = grid_paidCashCheck.Rows[i].Cells["DeliveryNumber"].Value.ToString();
            //                        String id = grid_paidCashCheck.Rows[i].Cells["id"].Value.ToString();

            //                        String PAM_0;
            //                        if (grid_paidCashCheck.Rows[i].Cells["Check/Cash"].Value.ToString() == "Cash")
            //                        {
            //                            PAM_0 = "CSH";
            //                        }
            //                        else if (grid_paidCashCheck.Rows[i].Cells["Check/Cash"].Value.ToString() == "Check")
            //                        {
            //                            PAM_0 = "CHQ";
            //                        }
            //                        else// ACH
            //                        {
            //                            PAM_0 = "ACH";
            //                        }
            //                        String EntryBatch = txt_entryBatch.Text.Trim();


            //                        String OrderNumber = grid_invoice.Rows[k].Cells["Order No."].Value.ToString().Trim();
            //                        if (Convert.ToDecimal(txt_diff.Text) < 0)
            //                        {
            //                            connSalesOrder.sp_PAYMENT_ADD_CREDIT(PaymentCustomerID, -(Convert.ToDecimal(txt_diff.Text)), OrderNumber, "");
            //                        }


            //                        connSalesOrder.sp_PAYMENTT(PaymentCustomerID, CheckNumber, Date, paidAmount, DeliveryNumber, PAM_0, Site, Bank, EntryBatch, id, NewPaymentNumber);
            //                        //connSalesOrder.sp_PAYMENTT(CustomerID, CheckNumber, Date, ARAmount, GATE.userID, DeliveryNumber, PAM_0, Site, Bank); 
            //                    }


            //                }
            //                MessageBox.Show("DONE", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                refresh();


            //            }
            //            return;
            //        }
            //        else
            //        {

            //        }

            //    }

            //}


            //if (checkedcount > 1)
            //{
            //    MessageBox.Show("AR Receipt restarting...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    Close();
            //    return;
            //}

            //if (txt_arPaymentTotal.Text == "")
            //{
            //    MessageBox.Show("Check the AR payment text box."
            //                                            , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}
            //else if(txt_shortOver.Text == "")
            //{
            //    MessageBox.Show("Check the short over text box."
            //                                            , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}

            //Decimal SelectedInvoiceCount = 0;
            //for (int i = 0; i < grid_invoice.RowCount; i++)
            //{
            //    if (Convert.ToBoolean(grid_invoice.Rows[i].Cells["invoiceSelect"].EditedFormattedValue) == true)
            //    {
            //        SelectedInvoiceCount = SelectedInvoiceCount + 1;
            //    }
            //}

            //if(SelectedInvoiceCount == 0)
            //{
            //    MessageBox.Show("Please select one or more invoice.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}

            //if (Convert.ToDecimal(txt_arPaymentTotal.Text.Trim()) == 0)
            //{
            //    if (SelectedInvoiceCount > 1)
            //    {
            //        MessageBox.Show("Select only one invoice that processing clear.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        return;
            //    }
            //    else
            //    {
            //        for (int i = 0; i < grid_invoice.RowCount; i++)
            //        {
            //            if (Convert.ToBoolean(grid_invoice.Rows[i].Cells["invoiceSelect"].EditedFormattedValue) == true &&
            //                Convert.ToDecimal(grid_invoice.Rows[i].Cells["Net"].Value.ToString()) != 0)
            //            {
            //                MessageBox.Show("Can not process clear and payment at the same time.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //                return;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < grid_invoice.RowCount; i++)
            //    {
            //        if (Convert.ToBoolean(grid_invoice.Rows[i].Cells["invoiceSelect"].EditedFormattedValue) == true &&
            //            Convert.ToDecimal(grid_invoice.Rows[i].Cells["Net"].Value.ToString()) == 0)
            //        {
            //            MessageBox.Show("Can not be Net 0 when payment.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //            return;
            //        }
            //    }

            //}




            //DialogResult dialogResult = MessageBox.Show("Are you sure run the payment process?\n\n" // +

            ////    "Selected Invoice Total : " + txt_invoice.Text.Trim() + "\n" +
            ////    "Selected Credit Total : " + txt_credit.Text.Trim() + "\n" +
            ////    "Selected Term Credit Total : " + txt_termCredit.Text.Trim() + "\n" +
            ////    "Selected Return Total : " + txt_return.Text.Trim() + "\n" +
            ////    "AR Total : " + txt_ARTotal.Text.Trim() + "\n\n" +

            ////    "AR Payment Total : " + txt_arPaymentTotal.Text.Trim()  + "\n" +
            ////    "Short or Over : " + txt_shortOver.Text.Trim() + "\n\n" +

            ////    "Difference : " + txt_diff.Text.Trim() + "\n\n" +

            ////    "Entry Batch : " + txt_entryBatch.Text.Trim() + "\n" +
            ////    "Site : " + cbo_site.Text.Trim() + "\n" +
            ////    "Bank : " + cbo_bank.Text.Trim() 

            //                                            , "Payment Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            //if (dialogResult == DialogResult.Yes)
            //{

            //    String CustomerID = cbox_customer.Text.Trim();

            //    Decimal Amount = Convert.ToDecimal(txt_invoice.Text) - Convert.ToDecimal(txt_diff.Text);
            //    Decimal ShortOver = Convert.ToDecimal(txt_shortOver.Text);
            //    Decimal Credit = Convert.ToDecimal(txt_credit.Text);
            //    Decimal Return = Convert.ToDecimal(txt_return.Text);
            //    Decimal TermCredit = Convert.ToDecimal(txt_termCredit.Text);

            //    String Site = cbo_site.Text.Trim();
            //    String Bank = cbo_bank.Text.Trim();

            //    for (int j = 0; j < grid_paidCashCheck.RowCount; j++)
            //    {
            //        if (Convert.ToBoolean(grid_paidCashCheck.Rows[j].Cells["paidCashCheckSelect"].EditedFormattedValue) == true)
            //        {
            //            if (grid_paidCashCheck.Rows[j].Cells["Check/Cash"].Value.ToString() == "Cash")
            //            {
            //                PAM_0 = "CSH";
            //            }
            //            else if (grid_paidCashCheck.Rows[j].Cells["Check/Cash"].Value.ToString() == "Check")
            //            {
            //                PAM_0 = "CHQ";
            //            }
            //            else// ACH
            //            {
            //                PAM_0 = "ACH";
            //            }
            //            break;
            //        }
            //    }

            //    //Get a new PAYMENT Number from Server 12/24/2018
            //    String NewPaymentNumber = connSalesOrder.sp_GET_NewPaymentNumber(PAM_0);

            //    //실제 낸돈 ARPaymentTotal //1735.91
            //    Decimal ARPaymentTotal = Convert.ToDecimal(txt_arPaymentTotal.Text.Trim());

            //    //AR 깔 돈
            //    Decimal ARAmount = Convert.ToDecimal(txt_arPaymentTotal.Text) + Credit + Return + TermCredit + ShortOver;
            //    //MessageBox.Show(ARAmount.ToString() + " " + ShortOver.ToString());
            //    //PAYMENT 깔 돈
            //    Decimal PAYMENTAmount = Convert.ToDecimal(txt_arPaymentTotal.Text);

            //    String InvoiceNumber ="";
            //    String OrderID = "";
            //    String PaymentCustomerID = "";
            //    //get last of selected invoice

            //    for (int i = 0; i < grid_invoice.RowCount; i++)
            //    {

            //        if (Convert.ToBoolean(grid_invoice.Rows[i].Cells["invoiceSelect"].EditedFormattedValue) == true && ARAmount > 0)
            //        {
            //            //MessageBox.Show(ARAmount.ToString());
            //            //Credit Amount초기화
            //            Decimal TotalCreditReturnAmount = 0;
            //            //인보이스 넘버
            //            InvoiceNumber = grid_invoice.Rows[i].Cells["No."].Value.ToString();
            //            //Order ID
            //            OrderID = grid_invoice.Rows[i].Cells["Order No."].Value.ToString();
            //            //payment 에 들어갈 금액 (NET)
            //            Decimal Net = Convert.ToDecimal(grid_invoice.Rows[i].Cells["Net"].Value.ToString());
            //            //한 인보이스의 남아있는 AR
            //            Decimal InvoiceAmount = Convert.ToDecimal(grid_invoice.Rows[i].Cells["Amt"].Value.ToString());
            //            //invoice customer
            //            PaymentCustomerID = grid_invoice.Rows[i].Cells["Customer"].Value.ToString();


            //            //인보이스의 Credit Amount
            //            Decimal TotalCreditAmountbyInvoice = 0;
            //            for (int k = 0; k < grid_credit.RowCount; k++)
            //            {
            //                if (grid_credit.Rows[k].Cells["Order No."].Value.ToString() == grid_invoice.Rows[i].Cells["Order No."].Value.ToString() &&
            //                    Convert.ToBoolean(grid_credit.Rows[k].Cells["creditSelect"].EditedFormattedValue) == true)
            //                {
            //                    Decimal CreditAmountbyInvoice = Convert.ToDecimal(grid_credit.Rows[k].Cells["Amt"].Value.ToString());
            //                    TotalCreditAmountbyInvoice = TotalCreditAmountbyInvoice + CreditAmountbyInvoice;
            //                }
            //            }
            //            //인보이스의 Return Amount
            //            Decimal TotalReturnAmountbyInvoice = 0;
            //            for (int l = 0; l < grid_return.RowCount; l++)
            //            {
            //                if (grid_return.Rows[l].Cells["OrderID"].Value.ToString() == grid_invoice.Rows[i].Cells["Order No."].Value.ToString() &&
            //                    Convert.ToBoolean(grid_return.Rows[l].Cells["returnSelect"].EditedFormattedValue) == true)
            //                {
            //                    Decimal ReturnAmountbyInvoice = Convert.ToDecimal(grid_return.Rows[l].Cells["Amt"].Value.ToString());
            //                    TotalReturnAmountbyInvoice = TotalReturnAmountbyInvoice + ReturnAmountbyInvoice;
            //                }
            //            }
            //            //인보이스의 Term Credit Amount
            //            Decimal TotalTermCreditAmountbyInvoice = 0;
            //            for (int m = 0; m < grid_termCredit.RowCount; m++)
            //            {
            //                if (grid_termCredit.Rows[m].Cells["InvoiceNumber"].Value.ToString() == grid_invoice.Rows[i].Cells["No."].Value.ToString() &&
            //                    Convert.ToBoolean(grid_termCredit.Rows[m].Cells["termCreditSelect"].EditedFormattedValue) == true)
            //                {
            //                    Decimal TermCreditAmountbyInvoice = Convert.ToDecimal(grid_termCredit.Rows[m].Cells["Amount"].Value.ToString());
            //                    TotalTermCreditAmountbyInvoice = TotalTermCreditAmountbyInvoice + TermCreditAmountbyInvoice;
            //                }
            //            }
            //            //credit, Return Term Credit 합계 Amount
            //            TotalCreditReturnAmount = TotalCreditAmountbyInvoice + TotalReturnAmountbyInvoice + TotalTermCreditAmountbyInvoice;

            //            if(Net < PAYMENTAmount)
            //            {
            //                //***PAYMENT***
            //                connSalesOrder.sp_PAYMENTT_INVOICE(PaymentCustomerID, InvoiceNumber, Net, NewPaymentNumber);
            //                //***AR***
            //                connSalesOrder.sp_PAYMENTT_INVOICE_AR(PaymentCustomerID, InvoiceNumber, Net, TotalCreditReturnAmount, NewPaymentNumber);

            //                ARAmount = ARAmount - (Net + TotalCreditReturnAmount);
            //                PAYMENTAmount = PAYMENTAmount - Net;
            //            }
            //            else //(Net >= PAYMENTAmount)
            //            {
            //                //***PAYMENT***
            //                connSalesOrder.sp_PAYMENTT_INVOICE(PaymentCustomerID, InvoiceNumber, PAYMENTAmount, NewPaymentNumber);
            //                //***AR***
            //                connSalesOrder.sp_PAYMENTT_INVOICE_AR(PaymentCustomerID, InvoiceNumber, ARAmount-TotalCreditReturnAmount, TotalCreditReturnAmount, NewPaymentNumber);

            //                ARAmount = ARAmount - (ARAmount - TotalCreditReturnAmount + TotalCreditReturnAmount); // ARAmount = 0
            //                PAYMENTAmount = PAYMENTAmount - PAYMENTAmount;
            //            }
            //        }
            //    }

            //    if (ShortOver > 0 || ShortOver < 0)
            //    {
            //        connSalesOrder.sp_PAYMENTT_INVOICE_SHORTOVER(PaymentCustomerID, InvoiceNumber, ShortOver, NewPaymentNumber);
            //        //MessageBox.Show("Short Over!");
            //    }

            //    //Decimal TempPaidAmountWithShortOver = Convert.ToDecimal(txt_arPaymentTotal.Text) + ShortOver;
            //    //Decimal CreditReturnTermCreditAmount = Credit + Return + TermCredit;

            //    //Over일때 Credit 추가(PAYMENTTD)
            //    for (int i = grid_invoice.RowCount; i > 0; i--)
            //    {
            //        if (Convert.ToBoolean(grid_invoice.Rows[i - 1].Cells["invoiceSelect"].EditedFormattedValue) == true)
            //        {
            //            String OrderNumber = grid_invoice.Rows[i - 1].Cells["Order No."].Value.ToString().Trim();
            //            if (Convert.ToDecimal(txt_diff.Text) < 0)
            //            {
            //                connSalesOrder.sp_PAYMENT_ADD_CREDIT(PaymentCustomerID, -(Convert.ToDecimal(txt_diff.Text)), OrderNumber, "");
            //            }
            //            break;
            //        }
            //    }

            //    //Credit(PAYMENTTD)
            //    for (int i = 0; i < grid_credit.RowCount; i++)
            //    {
            //        if (Convert.ToBoolean(grid_credit.Rows[i].Cells["CreditSelect"].EditedFormattedValue) == true)
            //        {
            //            String CreditNumber = grid_credit.Rows[i].Cells["No."].Value.ToString();
            //            Decimal CreditAmount = Convert.ToDecimal(grid_credit.Rows[i].Cells["Amt"].Value.ToString());
            //            connSalesOrder.sp_PAYMENTT_CREDIT(PaymentCustomerID, CreditNumber, CreditAmount, NewPaymentNumber);
            //        }

            //    }

            //    //Return(PAYMENTTD)
            //    for (int i = 0; i < grid_return.RowCount; i++)
            //    {
            //        if (Convert.ToBoolean(grid_return.Rows[i].Cells["ReturnSelect"].EditedFormattedValue) == true)
            //        {
            //            String ReturnNumber = grid_return.Rows[i].Cells["No."].Value.ToString();
            //            Decimal ReturnAmount = Convert.ToDecimal(grid_return.Rows[i].Cells["Amt"].Value.ToString());
            //            connSalesOrder.sp_PAYMENTT_RETURN(PaymentCustomerID, ReturnNumber, ReturnAmount, NewPaymentNumber);
            //        }

            //    }

            //    //Term Credit(PAYMENTTD)
            //    for (int i = 0; i < grid_termCredit.RowCount; i++)
            //    {
            //        if (Convert.ToBoolean(grid_termCredit.Rows[i].Cells["termCreditSelect"].EditedFormattedValue) == true)
            //        {
            //            //Decimal termCreditAmount = Convert.ToDecimal(txt_termCredit.Text.ToString());
            //            Decimal termCreditAmount = Convert.ToDecimal(grid_termCredit.Rows[i].Cells["Amount"].Value.ToString());
            //            InvoiceNumber = grid_termCredit.Rows[i].Cells["InvoiceNumber"].Value.ToString();
            //            connSalesOrder.sp_PAYMENTT_TERMCREDIT(PaymentCustomerID, termCreditAmount, InvoiceNumber, NewPaymentNumber);
            //        }
            //    }

            //    //sp_PAYMENTT
            //    for (int i = 0; i < grid_paidCashCheck.RowCount; i++)
            //    {
            //        if (Convert.ToBoolean(grid_paidCashCheck.Rows[i].Cells["paidCashCheckSelect"].EditedFormattedValue) == true)
            //        {
            //            String CheckNumber = grid_paidCashCheck.Rows[i].Cells["Check No."].Value.ToString();
            //            DateTime Date = Convert.ToDateTime(grid_paidCashCheck.Rows[i].Cells["Check Date"].Value.ToString());
            //            Decimal paidAmount = Convert.ToDecimal(grid_paidCashCheck.Rows[i].Cells["Amount"].Value.ToString());
            //            String DeliveryNumber = grid_paidCashCheck.Rows[i].Cells["DeliveryNumber"].Value.ToString();
            //            String id = grid_paidCashCheck.Rows[i].Cells["id"].Value.ToString();

            //            String PAM_0;
            //            if (grid_paidCashCheck.Rows[i].Cells["Check/Cash"].Value.ToString() == "Cash")
            //            {
            //                PAM_0 = "CSH";
            //            }
            //            else if (grid_paidCashCheck.Rows[i].Cells["Check/Cash"].Value.ToString() == "Check")
            //            {
            //                PAM_0 = "CHQ";
            //            }
            //            else// ACH
            //            {
            //                PAM_0 = "ACH";
            //            }
            //            String EntryBatch = txt_entryBatch.Text.Trim();

            //            connSalesOrder.sp_PAYMENTT(PaymentCustomerID, CheckNumber, Date, paidAmount, DeliveryNumber, PAM_0, Site, Bank, EntryBatch, id, NewPaymentNumber);
            //            //connSalesOrder.sp_PAYMENTT(CustomerID, CheckNumber, Date, ARAmount, GATE.userID, DeliveryNumber, PAM_0, Site, Bank); 
            //        }

            //    }
            //    refresh();

            //}
            //else if (dialogResult == DialogResult.No)
            //{

            //}


        }



        private void btn_addCredit_Click(object sender, EventArgs e)
        {
            //if(txt_OrderID.Text.Trim() == "")
            //{
            //    MessageBox.Show("Please input order id.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}

            //DialogResult dialogResult = MessageBox.Show("Are you sure add a new credit memo?"
            //                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    if (cbox_customer.Text == "")
            //    {
            //        MessageBox.Show("Select a customer first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        return;
            //    }
            //    try
            //    {

            //        String CreditMemo = txt_creditMemo.Text.Trim();
            //        //String OrderNumber = txt_orderID.Text.Trim();
            //        String OrderNumber = txt_OrderID.Text.Trim();
            //        //connSalesOrder.sp_PAYMENT_ADD_3CREDIT(cbox_customer.Text.Trim(), Convert.ToDecimal(txt_addCreditAmount.Text), "", CreditMemo);
            //        connSalesOrder.sp_PAYMENT_ADD_3CREDIT(cbox_customer.Text.Trim(), Convert.ToDecimal(txt_addCreditAmount.Text), OrderNumber, CreditMemo);
            //        //connSalesOrder.sp_PAYMENT_CREDIT(grid_credit, cbox_customer.Text);

            //        txt_addCreditAmount.Text = "";
            //        txt_creditMemo.Text = "";

            //        connSalesOrder.sp_PAYMENT_CREDIT(grid_credit, cbox_customer.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Input all info", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    }
            //}
            //else if (dialogResult == DialogResult.No)
            //{

            //}
        }

        private void btn_addPaidCheckCash_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure add a paid check or cash?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    //DataTable dt = this.grid_paidCashCheck.DataSource as DataTable;
                    //DataRow dr = dt.NewRow();

                    String CheckCash = cbo_checkCash.Text;
                    Decimal Amount = Convert.ToDecimal(txt_paidAmount.Text);
                    DateTime CheckDate = dateTimePicker1.Value.Date;
                    String CheckNumber = txt_checkNo.Text;

                    //dr[0] = true;
                    //dr[1] = CheckCash;
                    //dr[2] = Amount;
                    //dr[3] = CheckDate;
                    //dr[4] = CheckNumber;
                    //dr[5] = "";

                    //dt.Rows.Add(dr);

                    connSalesOrder.sp_PAYMENT_ADD_PAIDCHECKCASH(CheckCash, Amount, CheckDate, CheckNumber, cbox_customer.Text);
                    connSalesOrder.sp_PAYMENT_PaidCashCheck(grid_paidCashCheck, cbox_customer.Text.ToString().Trim());

                    txt_paidAmount.Text = "";
                    txt_checkNo.Text = "";
                    dateTimePicker1.Value = DateTime.Now.Date;


                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            catch
            {
                MessageBox.Show("Input all info", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_addTermCredit_Click(object sender, EventArgs e)
        {
            //bool termcreditInvoiceCheck = false;
            //String InputInvoiceNumber = txt_termCreditInvoiceNumber.Text.Trim();

            //for (int j = 0; j < grid_invoice.RowCount; j++)
            //{
            //    if (Convert.ToBoolean(grid_invoice.Rows[j].Cells["invoiceSelect"].EditedFormattedValue) == true)
            //    {
                    
            //        String InvoiceNumber = grid_invoice.Rows[j].Cells["No."].Value.ToString().Trim();
            //        //MessageBox.Show(InputInvoiceNumber + " " + InvoiceNumber);
            //        if (InputInvoiceNumber == InvoiceNumber)
            //        {
            //            //MessageBox.Show(InputInvoiceNumber + " " + InvoiceNumber);
            //            termcreditInvoiceCheck = true;
            //        }
            //    }
            //}

            //if (termcreditInvoiceCheck == false)
            //{
            //    MessageBox.Show("check invoice number on term credit part."
            //                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    //Close();
            //    return;
                
            //}

            //    //for (int i = 0; i < grid_termCredit.RowCount; i++)
            //    //{
            //    //    bool termcreditInvoiceCheck = false;
            //    //    if (Convert.ToBoolean(grid_termCredit.Rows[i].Cells["termCreditSelect"].EditedFormattedValue) == true)
            //    //    {
            //    //        String InputInvoiceNumber = grid_termCredit.Rows[i].Cells["InvoiceNumber"].Value.ToString();
            //    //        for (int j = 0; j < grid_invoice.RowCount; j++)
            //    //        {
            //    //            if (Convert.ToBoolean(grid_invoice.Rows[j].Cells["invoiceSelect"].EditedFormattedValue) == true)
            //    //            {
            //    //                String InvoiceNumber = grid_invoice.Rows[i].Cells["No."].Value.ToString();
            //    //                if(InputInvoiceNumber == InvoiceNumber)
            //    //                {
            //    //                    termcreditInvoiceCheck = true;
            //    //                }
            //    //            }
            //    //        }
            //    //    }
            //    //    if (termcreditInvoiceCheck == false)
            //    //    {
            //    //        MessageBox.Show("check invoice number on term credit part."
            //    //                                            , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    //        return;
            //    //    }
            //    //}


            //    DialogResult dialogResult = MessageBox.Show("Are you sure add a term credit?"
            //                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (dialogResult == DialogResult.Yes)
            //{
            //    String Term = cbo_term.Text;
            //    Decimal Percentage = Convert.ToDecimal(txt_percentage.Text);
            //    Decimal Amount = Convert.ToDecimal(txt_termCreditAmount.Text);
            //    String TermCreditInvoiceNumber = txt_termCreditInvoiceNumber.Text.Trim();

            //    //DataGridViewRow row = (DataGridViewRow)grid_termCredit.Rows[0].Clone();
            //    //row.Cells[0].Value = true;
            //    //row.Cells[1].Value = Term;
            //    //row.Cells[2].Value = Percentage.ToString();
            //    //row.Cells[3].Value = Amount.ToString();
            //    //grid_termCredit.Rows.Add(row);

            //    grid_termCredit.Rows.Add(new object[] { false, Term, Percentage, Amount, TermCreditInvoiceNumber });

            //}
            //else if (dialogResult == DialogResult.No)
            //{

            //}

        }

        private void refresh()
        {
            //MessageBox.Show("refresh");
            //btn_payment.Enabled = false;


            grid_invoice.DataSource = null;
            grid_termCredit.DataSource = null;
            grid_paidCashCheck.DataSource = null;
            grid_paymentInfo.DataSource = null;

            //this.grid_invoice.Rows.Clear();
            //this.grid_credit.Rows.Clear();
            //this.grid_return.Rows.Clear();
            //this.grid_termCredit.Rows.Clear();
            //this.grid_paidCashCheck.Rows.Clear();

            //txt_invoiceNetAmountTotal.Text = "";
            //txt_termCredit.Text = "";
            //txt_arPaymentTotal.Text = "";
            //txt_ARTotal.Text = "";
            //txt_diff.Text = "";

            txt_searchPaymentNo.Text = "";


            connSalesOrder.sp_PAYMENTT_HEADER(grid_payment, cbox_customer.Text, "");
            connSalesOrder.sp_PAYMENT_INVOICE(grid_invoice, cbox_customer.Text, "");
            if(cbox_customer.Text.Trim() != "")
            {
                connSalesOrder.sp_PAYMENT_PaidCashCheck(grid_paidCashCheck, cbox_customer.Text.ToString().Trim());
            }

            
            //for (int i = 0; i < grid_paidCashCheck.RowCount; i++)
            //{
            //    if (grid_paidCashCheck.Rows[i].Cells["Check No."].Value.ToString() != "")
            //    {
            //        grid_paidCashCheck.Rows[i].Cells["Check/Cash"].Value = "Check";
            //    }
            //    else
            //    {
            //        grid_paidCashCheck.Rows[i].Cells["Check/Cash"].Value = "Cash";
            //    }

            //}

            //String PaymentTermKey = connSalesOrder.getPaymentTermKey(cbox_customer.Text.Trim());
            //String PaymentTermName = connSalesOrder.getPaymentTermName(PaymentTermKey);
            //Decimal DiscountRate = connSalesOrder.getDiscountRate(PaymentTermKey);
            //try
            //{

            //    grid_termCredit.Rows.Add(new object[] { false, PaymentTermName, DiscountRate.ToString("N2") });

            //}
            //catch
            //{
            //    MessageBox.Show("Input all item try to add info", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}

            //txt_invoiceNetAmountTotal.Text = "0";
            //txt_termCredit.Text = "0";

            lbl_customerInfo.Text = "";
            lbl_customerInfo.Text = connSalesOrder.getShipAddressByCustomerID(cbox_customer.Text.Trim());
            
        }

        private void txt_addCreditAmount_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void txt_searchRecNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String SearchPaymentNumber = txt_searchPaymentNo.Text.Trim();
                connSalesOrder.sp_PAYMENTT_HEADER(grid_payment, cbox_customer.Text, SearchPaymentNumber);
            }
        }

        private void txt_searchDeliveryNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    searchDeliveryNumber();
                }
                catch
                {

                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            cbox_customer.DroppedDown = false;
            refresh();
            

        }

        private void btn_deliveryNumberSearch_Click(object sender, EventArgs e)
        {
            searchDeliveryNumber();
        }

        private void searchDeliveryNumber()
        {
            //String DeliveryNumber = txt_searchDeliveryNumber.Text.Trim();
            //connSalesOrder.sp_PAYMENT_INVOICE(grid_invoice, cbox_customer.Text, DeliveryNumber);
            //txt_searchDeliveryNumber.SelectAll();
            //txt_searchDeliveryNumber.Focus();
            String DeliveryNumber = txt_searchDeliveryNumber.Text.Trim();
            
            for (int i = 0; i < grid_invoice.RowCount - 1; i++)
            {
                string str = grid_invoice.Rows[i].Cells["Delv No."].Value.ToString().Trim();
                
                if (str.Contains(DeliveryNumber))//(substr.Contains(DeliveryNumber))
                {
                    grid_invoice.CurrentCell = grid_invoice[1, i];
                    break;
                }
            }
        }

        private void txt_searchCheckNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String SearchCheckNumber = txt_searchCheckNumber.Text.Trim();

                for (int i = 0; i < grid_payment.RowCount; i++)
                {
                    string str = grid_payment.Rows[i].Cells["Check No."].Value.ToString().Trim();
                    //if (str == "")
                    //{
                    //    str = "XXXX";
                    //}
                    //string substr = str.Substring(str.Length - 4);

                    if (str.Contains(SearchCheckNumber))
                    {
                        grid_payment.CurrentCell = grid_payment[1, i];
                        break;
                    }
                }
            }
            
        }

        private void txt_searchEntryBatch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String SearchEntryBatch = txt_searchEntryBatch.Text.Trim();

                for (int i = 0; i < grid_payment.RowCount; i++)
                {
                    string str = grid_payment.Rows[i].Cells["Entry Batch"].Value.ToString().Trim();
                    //string substr = str.Substring(str.Length - 4);
                    //if (str == "")
                    //{
                    //    str = "XXXX";
                    //}
                    if (str.Contains(SearchEntryBatch))
                    {
                        grid_payment.CurrentCell = grid_payment[1, i];
                        break;
                    }
                }
            }
        }
        

        private void txt_shortOver_Leave(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        private void grid_payment_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //view inv, credit, return termcredit, payment
                String PaymentNumber = grid_payment.Rows[e.RowIndex].Cells["No."].Value.ToString().Trim();
                connSalesOrder.sp_PAYMENTT_SELECT_PAYMENTNUMBER(grid_paymentInfo, PaymentNumber);
                
            }
            catch
            {

            }
        }

        private void grid_payment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String PaymentNumber = grid_payment.Rows[e.RowIndex].Cells["No."].Value.ToString().Trim();
                if (e.ColumnIndex == 8) // Reverse button
                {
                    String DEPOSITSLIPCHECK = connSalesOrder.sp_PAYMENTT_DEPOSITSLIPCHECK(PaymentNumber);
                    //MessageBox.Show(DEPOSITSLIPCHECK);
                    if (DEPOSITSLIPCHECK != "")
                    {
                        if(DEPOSITSLIPCHECK == "NS")
                        {
                            MessageBox.Show("Net settlement.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                        else {
                            MessageBox.Show("This payment number has been made deposit slip already.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                        
                    }

                    DialogResult dialogResult = MessageBox.Show("Are you sure reverse this payment?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        DataTable dt = this.grid_payment.DataSource as DataTable;
                        DataRow dr = dt.NewRow();
                        dt.Rows.RemoveAt(e.RowIndex);

                        //invoice, credit, return term credit 되돌리기
                        connSalesOrder.sp_PAYMENTT_REVERSE(PaymentNumber);
                        refresh();

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                }
            }
            catch
            {

            }
        }

        private void grid_invoice_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    String OrderID = grid_invoice.Rows[e.RowIndex].Cells["Order No."].Value.ToString().Trim();
            //    String InvoiceNumber = grid_invoice.Rows[e.RowIndex].Cells["No."].Value.ToString().Trim();

            //    txt_termCreditInvoiceNumber.Text = InvoiceNumber;
            //    txt_OrderID.Text = OrderID;
            //}
            //catch
            //{

            //}
        }

        private void grid_termCredit_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Decimal CheckedTotalTermCreditAmount = 0;
            Decimal CheckedTotalTermCreditCount = 0;
            for (int i = 0; i < grid_termCredit.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_termCredit.Rows[i].Cells["termCreditSelect"].EditedFormattedValue) == true)
                {
                    //체크된 오더의 order amount 합 구하기
                    Decimal Amount = Convert.ToDecimal(grid_termCredit.Rows[i].Cells["Amount"].Value.ToString());
                    CheckedTotalTermCreditAmount = CheckedTotalTermCreditAmount + Amount;

                    //체크된 오더의 갯수 구하기
                    CheckedTotalTermCreditCount = CheckedTotalTermCreditCount + 1;
                }
            }
            //txt_return.Text = CheckedTotalReturnAmount.ToString("C");
            txt_termCredit.Text = CheckedTotalTermCreditAmount.ToString("N2");

            CalculateAmount();
        }

        private void grid_credit_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Decimal CheckedTotalCreditAmount = 0;
            //Decimal CheckedTotalCreditCount = 0;
            //for (int i = 0; i < grid_credit.RowCount; i++)
            //{
            //    if (Convert.ToBoolean(grid_credit.Rows[i].Cells["CreditSelect"].EditedFormattedValue) == true)
            //    {
            //        //체크된 오더의 order amount 합 구하기
            //        Decimal Amount = Convert.ToDecimal(grid_credit.Rows[i].Cells["Amt"].Value.ToString());
            //        CheckedTotalCreditAmount = CheckedTotalCreditAmount + Amount;

            //        //체크된 오더의 갯수 구하기
            //        CheckedTotalCreditCount = CheckedTotalCreditCount + 1;
            //    }
            //}
            ////txt_invoice.Text = CheckedTotalCreditAmount.ToString("C");
            //txt_credit.Text = CheckedTotalCreditAmount.ToString("N2");
            //CalculateAmount();
        }

        private void grid_termCredit_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Decimal CheckedTotalTermCreditAmount = 0;
            Decimal CheckedTotalTermCreditCount = 0;
            for (int i = 0; i < grid_termCredit.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_termCredit.Rows[i].Cells["termCreditSelect"].EditedFormattedValue) == true)
                {
                    //체크된 오더의 order amount 합 구하기
                    Decimal Amount = Convert.ToDecimal(grid_termCredit.Rows[i].Cells["Amount"].Value.ToString());
                    CheckedTotalTermCreditAmount = CheckedTotalTermCreditAmount + Amount;

                    //체크된 오더의 갯수 구하기
                    CheckedTotalTermCreditCount = CheckedTotalTermCreditCount + 1;
                }
            }
            //txt_return.Text = CheckedTotalReturnAmount.ToString("C");
            txt_termCredit.Text = CheckedTotalTermCreditAmount.ToString("N2");

            CalculateAmount();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grid_paidCashCheck_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6) // Delete Paid button
                {
                    DialogResult dialogResult = MessageBox.Show("Deleting paid cash, check?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes)
                    {
                        String id = grid_paidCashCheck.Rows[e.RowIndex].Cells["id"].Value.ToString().Trim();
                        connSalesOrder.sp_PAYMENTT_DELETE_PAID(id);

                        DataTable dt = this.grid_paidCashCheck.DataSource as DataTable;
                        DataRow dr = dt.NewRow();
                        dt.Rows.RemoveAt(e.RowIndex);

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                    //refresh();
                }
            }
            catch
            {

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grid_selectedInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Decimal NetAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[e.RowIndex].Cells["Net Amount"].Value.ToString());
            Decimal PaymentAmount = 0;
            try
            {
                PaymentAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[e.RowIndex].Cells["Payment Amount"].Value.ToString());
            }
            catch
            {
                grid_selectedInvoice.Rows[e.RowIndex].Cells["Payment Amount"].Value = 0;
                PaymentAmount = 0;
            }
                
            grid_selectedInvoice.Rows[e.RowIndex].Cells["Payment Amount"].Value = PaymentAmount.ToString("N2");
            PaymentAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[e.RowIndex].Cells["Payment Amount"].Value.ToString());

            Decimal ShortOverAmount = 0;
            try
            {
                ShortOverAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[e.RowIndex].Cells["Short/Over Amount"].Value.ToString());
            }
            catch
            {
                grid_selectedInvoice.Rows[e.RowIndex].Cells["Short/Over Amount"].Value = 0;
                ShortOverAmount = 0;
            }
            
            grid_selectedInvoice.Rows[e.RowIndex].Cells["Short/Over Amount"].Value = ShortOverAmount.ToString("N2");
            ShortOverAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[e.RowIndex].Cells["Short/Over Amount"].Value.ToString());

            if (PaymentAmount > NetAmount)
            {
                MessageBox.Show("Payment Amount Cannot greater than Net Amount", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);//PaymentAmount > NetAmount
                grid_selectedInvoice.Rows[e.RowIndex].Cells["Payment Amount"].Value = 0.ToString("N2");
            }

            Decimal SelectedInvoiceNetAmountTotal = 0;
            for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
            {
                Decimal SelectedInvoiceNetAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value.ToString().Trim());
                SelectedInvoiceNetAmountTotal = SelectedInvoiceNetAmountTotal + SelectedInvoiceNetAmount;
            }

            Decimal ARPaymentTotal = 0;

            try
            {
                ARPaymentTotal = Convert.ToDecimal(txt_arPaymentTotal.Text.ToString());
            }
            catch
            {
                MessageBox.Show("choose AR payment first.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            if(SelectedInvoiceNetAmountTotal > ARPaymentTotal)

            {
                MessageBox.Show("Selected Invoice Net Amount Total cannot be greater than AR Payment Total", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); //SelectedInvoiceNetAmountTotal > ARPaymentTotal
                for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
                {
                    //grid_selectedInvoice.Rows[i].Cells["Payment Amount"].Value = 0.00;
                    //grid_selectedInvoice.CurrentCell = grid_selectedInvoice.Rows[i].Cells["Payment Amount"];

                    //grid_selectedInvoice.Focus();
                    //grid_selectedInvoice.Select();
                }
            }
            


            CalculateAmount();


            //short over
            //prepaid

            //for (int i = 0; i < grid_selectedInvoice.RowCount; i++)
            //{
            //    Decimal NetAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Net Amount"].Value.ToString());
            //    TotalNetAmount = TotalNetAmount + NetAmount;

            //    String ShortOver = grid_selectedInvoice.Rows[i].Cells["ShortOver"].Value.ToString();

            //    Decimal ShortOverAmount = 0;
            //    if (grid_selectedInvoice.Rows[i].Cells["Short/Over Amount"].Value == null)
            //    {
            //        ShortOverAmount = 0;
            //    }
            //    else
            //    {
            //        ShortOverAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Short/Over Amount"].Value.ToString());
            //    }

            //    Decimal PrepaidAmount = 0;
            //    if (grid_selectedInvoice.Rows[i].Cells["Prepaid"].Value == null)
            //    {
            //        PrepaidAmount = 0;
            //    }
            //    else
            //    {
            //        PrepaidAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[i].Cells["Prepaid"].Value.ToString());
            //    }

            //    if ((Diff > 0 && ShortOver == "Short") || (Diff < 0 && ShortOver == "Over"))
            //    {
            //        MessageBox.Show("Check Short / Over.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        grid_selectedInvoice.Rows[i].Cells["Short/Over Amount"].Value = "";
            //        grid_selectedInvoice.Rows[i].Cells["Prepaid"].Value = "";

            //        return;
            //    }


            //}

            //MessageBox.Show(TotalNetAmount.ToString());

        }

        private void grid_selectedInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 13 && e.RowIndex >= 0) // Delete button
            {
                //01-29-2020 AR요청사항
                ////MessageBox.Show(e.RowIndex.ToString().Trim());
                //DialogResult dialogResult = MessageBox.Show("Are you sure deleting item from this order?"
                //                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (dialogResult == DialogResult.Yes)
                //{
                    //DataTable dt = this.grid_OrderDetail.DataSource as DataTable;
                    //DataRow dr = dt.NewRow();
                    //dt.Rows.RemoveAt(e.RowIndex);

                    for (int i = 0; i < grid_invoice.Rows.Count; i++)
                    {
                        if (grid_invoice.Rows[i].Cells["No."].Value.ToString() == grid_selectedInvoice.Rows[e.RowIndex].Cells["No."].Value.ToString())
                        {
                            grid_invoice.Rows[i].Cells["invoiceSelect"].Value = false;
                        }
                    }

                    for (int i = 0; i < grid_termCredit.Rows.Count; i++)
                    {
                        if (grid_termCredit.Rows[i].Cells["InvoiceNumber"].Value.ToString() == grid_selectedInvoice.Rows[e.RowIndex].Cells["No."].Value.ToString())
                        {
                            grid_termCredit.Rows.RemoveAt(i);
                        }
                    }

                    grid_selectedInvoice.Rows.RemoveAt(e.RowIndex);
                    //Audit();
                    CalculateAmount();
                //}
                //else if (dialogResult == DialogResult.No)
                //{

                //}

            }
        }

        private void grid_selectedInvoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 13 && e.RowIndex >= 0)
            {

            }
        }

        private void grid_termCredit_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            Decimal Amount = 0;
            try
            {
                Amount = Convert.ToDecimal(grid_termCredit.Rows[e.RowIndex].Cells["Amount"].Value.ToString());
            }
            catch
            {
                grid_termCredit.Rows[e.RowIndex].Cells["Amount"].Value = 0;
                Amount = 0;
            }
            grid_termCredit.Rows[e.RowIndex].Cells["Amount"].Value = Amount.ToString("N2");

            
            String InvoiceNumber = grid_termCredit.Rows[e.RowIndex].Cells["InvoiceNumber"].Value.ToString();

            for (int i = 0; i < grid_selectedInvoice.Rows.Count; i++)
            {
                if (Convert.ToBoolean(grid_termCredit.Rows[i].Cells["termCreditSelect"].EditedFormattedValue) == true)
                {
                    String SelectedInvoiceNumber = grid_selectedInvoice.Rows[i].Cells["No."].Value.ToString();
                    Decimal SelectedInvoiceAmount = Convert.ToDecimal(grid_selectedInvoice.Rows[e.RowIndex].Cells["Amt"].Value.ToString());
                    if (SelectedInvoiceNumber == InvoiceNumber)
                    {
                        grid_selectedInvoice.Rows[i].Cells["Net Amount"].Value = (SelectedInvoiceAmount - Amount).ToString("N2");
                        break;
                    }
                }
            }
        }

        private void cbox_customer_TextUpdate(object sender, EventArgs e)
        {
            lbl_customerInfo.Text = "";
            grid_payment.DataSource = null;
            grid_paymentInfo.DataSource = null;
            grid_invoice.DataSource = null;
            grid_termCredit.DataSource = null;
            grid_paidCashCheck.DataSource = null;
            grid_paidCashCheck.Rows.Clear();
            String EntryBatch = txt_entryBatch.Text.Trim();

            txt_arPaymentTotal.Text = "0.00";

            txt_entryBatch.Text = EntryBatch;
            //refresh();
            CalculateAmount();
        }

        private void txt_searchAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Decimal SearchAmount = Convert.ToDecimal(txt_searchAmount.Text.Trim());

                for (int i = 0; i < grid_payment.RowCount; i++)
                {
                    Decimal amt = Convert.ToDecimal(grid_payment.Rows[i].Cells["Amt"].Value.ToString().Trim());
                    //if (str == "")
                    //{
                    //    str = "XXXX";
                    //}
                    //string substr = str.Substring(str.Length - 4);

                    if (amt == SearchAmount)
                    {
                        grid_payment.CurrentCell = grid_payment[1, i];
                        break;
                    }
                }
            }
        }

        private void txt_searchCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String SearchCustomerID = txt_searchCustomerID.Text.Trim();

                for (int i = 0; i < grid_payment.RowCount; i++)
                {
                    String str = grid_payment.Rows[i].Cells["Customer"].Value.ToString().Trim();

                    if (str.Contains(SearchCustomerID))
                    {
                        grid_payment.CurrentCell = grid_payment[1, i];
                        break;
                    }
                }
            }
        }
    }
}
