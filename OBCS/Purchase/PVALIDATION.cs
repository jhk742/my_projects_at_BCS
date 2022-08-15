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
    public partial class PVALIDATION : Form
    {
        public PVALIDATION()
        {
            InitializeComponent();
            
            //detail grid multi line allow
            grid_detail.AllowDrop = true;
            grid_detail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_detail.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            
            grid_receiving_Init();
            grid_detail_Init();

            String RecNumber = txt_searchRecNo.Text.Trim();
            String PONumber = txt_searchPoNo.Text.Trim();
            String Supplier = txt_searchSupplier.Text.Trim();

            //dateTimePickerFrom.Value = DateTime.Today.AddMonths(-1);
            dateTimePickerFrom.Value = DateTime.Today.AddMonths(-3);
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            //connPO.sp_PRECEIPT_VALIDATIONHEADER(grid_receiving, RecNumber, PONumber, Supplier, FromDate, ToDate);
            
            cbo_invoicingSite.Items.Add("BCS");
            cbo_invoicingSite.Items.Add("WH2");
            cbo_invoicingSite.Text = "BCS";

            ///* //10/12/2020 -- moved to debit memo request 
            connPO.cbox_getVendorID(cbox_supplier);
            connPO.cbox_getVendorID(cbo_freightSupplier);

            cbo_freightInvoiceSite.Items.Add("BCS");
            cbo_freightInvoiceSite.Items.Add("WH2");
            cbo_freightInvoiceSite.Text = "BCS";

            cbo_chargeBackInvoiceSite.Items.Add("BCS");
            cbo_chargeBackInvoiceSite.Items.Add("WH2");
            cbo_chargeBackInvoiceSite.Text = "BCS";
            //--*/
        }

        private void grid_receiving_Init()
        {
            grid_receiving.AutoGenerateColumns = false;
            grid_receiving.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_receiving.ColumnCount = 16;

            grid_receiving.Columns[0].Name = "Receipt Date";
            grid_receiving.Columns[0].ReadOnly = true;
            grid_receiving.Columns[0].Width = 75;
            grid_receiving.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_receiving.Columns[0].DataPropertyName = "NDEDAT_0";

            grid_receiving.Columns[1].Name = "Receipt No.";
            grid_receiving.Columns[1].ReadOnly = true;
            grid_receiving.Columns[1].Width = 80;
            grid_receiving.Columns[1].DataPropertyName = "PTHNUM_0";

            grid_receiving.Columns[2].Name = "PO No.";
            grid_receiving.Columns[2].ReadOnly = true;
            grid_receiving.Columns[2].Width = 90;
            grid_receiving.Columns[2].DataPropertyName = "POHNUM_0";

            grid_receiving.Columns[3].Name = "Supplier ID";
            grid_receiving.Columns[3].ReadOnly = true;
            grid_receiving.Columns[3].Width = 120;
            grid_receiving.Columns[3].DataPropertyName = "BPSNUM_0";

            grid_receiving.Columns[4].Name = "Receiving Site";
            grid_receiving.Columns[4].ReadOnly = true;
            grid_receiving.Columns[4].Width = 60;
            grid_receiving.Columns[4].DataPropertyName = "PRHFCY_0";

            grid_receiving.Columns[5].Name = "Memo";
            grid_receiving.Columns[5].ReadOnly = true;
            //grid_receiving.Columns[5].Visible = false;
            grid_receiving.Columns[5].Width = 120;
            grid_receiving.Columns[5].DataPropertyName = "PMemo";

            grid_receiving.Columns[6].Name = "Supplier Name";
            grid_receiving.Columns[6].Visible = false;
            grid_receiving.Columns[6].DataPropertyName = "BPONAM_0";

            grid_receiving.Columns[7].Name = "POIssueDate";
            grid_receiving.Columns[7].Visible = false;
            grid_receiving.Columns[7].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_receiving.Columns[7].DataPropertyName = "ORDDAT_0";

            grid_receiving.Columns[8].Name = "TotalPOGrossAmount";
            grid_receiving.Columns[8].Visible = false;
            grid_receiving.Columns[8].DefaultCellStyle.Format = "N2";
            grid_receiving.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[8].DataPropertyName = "TotalPOGrossAmount";

            grid_receiving.Columns[9].Name = "POEDLP";
            grid_receiving.Columns[9].Visible = false;
            grid_receiving.Columns[9].DefaultCellStyle.Format = "N2";
            grid_receiving.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[9].DataPropertyName = "POEDLP";

            grid_receiving.Columns[10].Name = "POTermPromo";
            grid_receiving.Columns[10].Visible = false;
            grid_receiving.Columns[10].DefaultCellStyle.Format = "N2";
            grid_receiving.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[10].DataPropertyName = "POTermPromo";

            grid_receiving.Columns[11].Name = "TotalPOAmount";
            grid_receiving.Columns[11].Visible = false;
            grid_receiving.Columns[11].DefaultCellStyle.Format = "N2";
            grid_receiving.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[11].DataPropertyName = "TotalPOAmount";

            grid_receiving.Columns[12].Name = "TotalRECGrossAmount";
            grid_receiving.Columns[12].Visible = false;
            grid_receiving.Columns[12].DefaultCellStyle.Format = "N2";
            grid_receiving.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[12].DataPropertyName = "TotalRECGrossAmount";

            grid_receiving.Columns[13].Name = "RECEDLP";
            grid_receiving.Columns[13].Visible = false;
            grid_receiving.Columns[13].DefaultCellStyle.Format = "N2";
            grid_receiving.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[13].DataPropertyName = "RECEDLP";

            grid_receiving.Columns[14].Name = "RECTermPromo";
            grid_receiving.Columns[14].Visible = false;
            grid_receiving.Columns[14].DefaultCellStyle.Format = "N2";
            grid_receiving.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[14].DataPropertyName = "RECTermPromo";

            grid_receiving.Columns[15].Name = "TotalRECAmount";
            grid_receiving.Columns[15].Visible = false;
            grid_receiving.Columns[15].DefaultCellStyle.Format = "N2";
            grid_receiving.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_receiving.Columns[15].DataPropertyName = "TotalRECAmount";
            
            //grid font size custom
            grid_receiving.RowTemplate.Height = 20;
            grid_receiving.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_receiving.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_receiving.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        
        private void grid_detail_Init()
        {
            grid_detail.AutoGenerateColumns = false;
            grid_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_detail.ColumnCount = 17;

            grid_detail.Columns[0].Name = "Number";
            grid_detail.Columns[0].ReadOnly = true;
            grid_detail.Columns[0].Visible = false;
            grid_detail.Columns[0].Width = 80;
            grid_detail.Columns[0].Width = 80;
            grid_detail.Columns[0].DataPropertyName = "POHNUM_0";

            grid_detail.Columns[1].Name = "Product (BCS)";
            grid_detail.Columns[1].ReadOnly = true;
            grid_detail.Columns[1].Width = 80;
            grid_detail.Columns[1].Width = 80;
            grid_detail.Columns[1].DataPropertyName = "ITMREF_0";

            grid_detail.Columns[2].Name = "Description";
            grid_detail.Columns[2].ReadOnly = true;
            grid_detail.Columns[2].Width = 200;
            grid_detail.Columns[2].DataPropertyName = "ITMDES1_0";

            grid_detail.Columns[3].Name = "Pack Size";
            grid_detail.Columns[3].ReadOnly = true;
            grid_detail.Columns[3].Width = 70;
            grid_detail.Columns[3].MinimumWidth = 70;
            grid_detail.Columns[3].DataPropertyName = "PackSize";

            grid_detail.Columns[4].Name = "Unit";
            grid_detail.Columns[4].ReadOnly = true;
            grid_detail.Columns[4].Width = 40;
            grid_detail.Columns[4].MinimumWidth = 40;
            grid_detail.Columns[4].DataPropertyName = "Unit";

            grid_detail.Columns[5].Name = "Invoiced Qty.";
            grid_detail.Columns[5].ReadOnly = true;
            grid_detail.Columns[5].Width = 60;
            grid_detail.Columns[5].MinimumWidth = 80;
            grid_detail.Columns[5].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].DataPropertyName = "QTY_0";

            grid_detail.Columns[6].Name = "Inner Case";
            grid_detail.Columns[6].ReadOnly = true;
            grid_detail.Columns[6].Width = 80;
            grid_detail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].DataPropertyName = "InnerCase";

            grid_detail.Columns[7].Name = "Gross price";
            grid_detail.Columns[7].ReadOnly = true;
            grid_detail.Columns[7].Width = 60;
            grid_detail.Columns[7].MinimumWidth = 60;
            grid_detail.Columns[7].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[7].DataPropertyName = "GROPRI_0";

            grid_detail.Columns[8].Name = "EDLP";
            grid_detail.Columns[8].Width = 60;
            grid_detail.Columns[8].MinimumWidth = 60;
            grid_detail.Columns[8].ReadOnly = true;
            grid_detail.Columns[8].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[8].DataPropertyName = "EDLP";

            grid_detail.Columns[9].Name = "EDLP (P)";
            grid_detail.Columns[9].Width = 60;
            grid_detail.Columns[9].MinimumWidth = 60;
            grid_detail.Columns[9].ReadOnly = true;
            grid_detail.Columns[9].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[9].DataPropertyName = "EDLPP";

            grid_detail.Columns[10].Name = "Term Promo";
            grid_detail.Columns[10].Width = 60;
            grid_detail.Columns[10].ReadOnly = true;
            grid_detail.Columns[10].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[10].DataPropertyName = "TermPromo";

            grid_detail.Columns[11].Name = "Term Promo (P)";
            grid_detail.Columns[11].Width = 60;
            grid_detail.Columns[11].MinimumWidth = 60;
            grid_detail.Columns[11].ReadOnly = true;
            grid_detail.Columns[11].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[11].DataPropertyName = "TermPromoP";

            grid_detail.Columns[12].Name = "Net Price";
            grid_detail.Columns[12].ReadOnly = true;
            grid_detail.Columns[12].Width = 60;
            grid_detail.Columns[12].MinimumWidth = 60;
            grid_detail.Columns[12].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[12].DataPropertyName = "NETPRI_0";

            grid_detail.Columns[13].Name = "Order Amount";
            grid_detail.Columns[13].ReadOnly = true;
            grid_detail.Columns[13].Width = 65;
            grid_detail.Columns[13].MinimumWidth = 65;
            grid_detail.Columns[13].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[13].DataPropertyName = "OrderAmount";

            grid_detail.Columns[14].Name = "Expiration Date";
            //grid_detail.Columns[14].ReadOnly = true;
            grid_detail.Columns[14].Width = 80;
            grid_detail.Columns[14].MinimumWidth = 80;
            grid_detail.Columns[14].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_detail.Columns[14].DataPropertyName = "ExpirationDate";

            grid_detail.Columns[15].Name = "Receiving Site";
            //grid_detail.Columns[15].Visible = false;
            grid_detail.Columns[15].Width = 40;
            grid_detail.Columns[15].MinimumWidth = 40;
            grid_detail.Columns[15].DataPropertyName = "ReceivingSite";

            grid_detail.Columns[16].Name = "ROWID";
            grid_detail.Columns[16].Visible = false;
            grid_detail.Columns[16].DataPropertyName = "ROWID";

            //grid font size custom
            grid_detail.RowTemplate.Height = 20;
            grid_detail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_detail.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_detail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        static private String SelectedPONumber;
        private void grid_receiving_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Decimal AmountTotal = 0;
            try
            {
                SelectedPONumber = grid_receiving.Rows[e.RowIndex].Cells["PO No."].Value.ToString();

                btn_create.Enabled = true;

                cbo_invoicingSite.Text = "";
                txt_supplierID.Text = "";
                txt_supplierDocNo.Text = "";
                txt_supplierDocAmount.Text = "0";
                txt_diff.Text = "0";
                txt_cost.Text = "0";
                txt_invoiceAmount.Text = "0";

                cbo_invoicingSite.Enabled = true;
                txt_supplierDocNo.Enabled = true;
                txt_supplierDocAmount.Enabled = true;
                txt_cost.Enabled = true;
                txt_invoiceAmount.Enabled = true;

                String SupplierID = grid_receiving.Rows[e.RowIndex].Cells["Supplier ID"].Value.ToString();
                String SupplierName = grid_receiving.Rows[e.RowIndex].Cells["Supplier Name"].Value.ToString();
                txt_supplierID.Text = SupplierID;
                txt_supplierName.Text = SupplierName;

                String PONumber;
                DateTime POIssueDate;
                
                Decimal TotalPOGrossAmount;
                Decimal POEDLP;
                Decimal POTermPromo;
                Decimal TotalPOAmount;
                Decimal TotalRECGrossAmount;
                Decimal RECEDLP;
                Decimal RECTermPromo;
                Decimal TotalRECAmount;
                
                //receiving site
                String ReceivingSite = grid_receiving.Rows[e.RowIndex].Cells["Receiving Site"].Value.ToString();
                cbo_invoicingSite.Text = ReceivingSite;
                
                String BCSSC = grid_receiving.Rows[e.RowIndex].Cells["PO No."].Value.ToString().Trim();
                if (BCSSC.Substring(0, 5).Trim() == "BCSSC")
                {
                    AmountTotal = connSalesOrder.sp_GET_SUBCONTRACTFEE(BCSSC);
                    txt_poNetAmount.Text = "";//TotalPOAmount.ToString("N2");
                    txt_poGrossAmount.Text = "";  
                    txt_poEDLP.Text = "";
                    txt_poTermPromo.Text = "";

                    lbl_number.Text = "Subcontract No.";
                    panel_PO.Visible = false;
                    panel_receipt.Visible = false;
                    txt_fee.Text = AmountTotal.ToString("N2");

                    lbl_panelpo.Text = "Subcontract Order";
                    lbl_poIssueDate.Visible = false;
                    dateTimePickerPoIssueDate.Visible = false;

                    btn_calculator.Visible = false;

                }
                else
                {
                    lbl_number.Text = "PO Number";
                    panel_PO.Visible = true;
                    panel_receipt.Visible = true;
                    txt_fee.Text = "";

                    lbl_panelpo.Text = "PO";
                    lbl_poIssueDate.Visible = true;
                    dateTimePickerPoIssueDate.Visible = true;

                    btn_calculator.Visible = true;

                    //po issue date
                    POIssueDate = Convert.ToDateTime(grid_receiving.Rows[e.RowIndex].Cells["POIssueDate"].Value.ToString());
                    dateTimePickerPoIssueDate.Value = POIssueDate;
                    
                    //po gross amount
                    TotalPOGrossAmount = Convert.ToDecimal(grid_receiving.Rows[e.RowIndex].Cells["TotalPOGrossAmount"].Value.ToString().Trim());
                    txt_poGrossAmount.Text = TotalPOGrossAmount.ToString("N2");

                    //po edlp
                    POEDLP = Convert.ToDecimal(grid_receiving.Rows[e.RowIndex].Cells["POEDLP"].Value.ToString().Trim());
                    txt_poEDLP.Text = POEDLP.ToString("N2");

                    //po term promo
                    POTermPromo = Convert.ToDecimal(grid_receiving.Rows[e.RowIndex].Cells["POTermPromo"].Value.ToString().Trim());
                    txt_poTermPromo.Text = POTermPromo.ToString("N2");

                    //po net amount
                    TotalPOAmount = Convert.ToDecimal(grid_receiving.Rows[e.RowIndex].Cells["TotalPOAmount"].Value.ToString().Trim());
                    txt_poNetAmount.Text = TotalPOAmount.ToString("N2");
                }
                //po number
                PONumber = grid_receiving.Rows[e.RowIndex].Cells["PO No."].Value.ToString();
                txt_poNumber.Text = PONumber;

                //receiving date
                DateTime ReceivingDate = Convert.ToDateTime(grid_receiving.Rows[e.RowIndex].Cells["Receipt Date"].Value.ToString());
                dateTimePickerReceivingDate.Value = ReceivingDate;
                dateTimePicker_SupplierInvoiceDate.Value = ReceivingDate;

                //receipt number
                String RECNumber = grid_receiving.Rows[e.RowIndex].Cells["Receipt No."].Value.ToString();
                txt_ReceiptNumber.Text = RECNumber;

                //gr gross amount
                TotalRECGrossAmount = Convert.ToDecimal(grid_receiving.Rows[e.RowIndex].Cells["TotalRECGrossAmount"].Value.ToString().Trim());
                txt_grGrossAmount.Text = TotalRECGrossAmount.ToString("N2");

                //rec edlp
                RECEDLP = Convert.ToDecimal(grid_receiving.Rows[e.RowIndex].Cells["RECEDLP"].Value.ToString().Trim());
                txt_recEDLP.Text = RECEDLP.ToString("N2");

                //rec term promo
                RECTermPromo = Convert.ToDecimal(grid_receiving.Rows[e.RowIndex].Cells["RECTermPromo"].Value.ToString().Trim());
                txt_recTermPromo.Text = RECTermPromo.ToString("N2");

                //gr net amount
                TotalRECAmount = Convert.ToDecimal(grid_receiving.Rows[e.RowIndex].Cells["TotalRECAmount"].Value.ToString().Trim());
                txt_grNetAmount.Text = TotalRECAmount.ToString("N2");


                CalculateTotal();
                
                connSalesOrder.sp_PRECEIPT_DETAIL_RECEIVING(grid_detail, RECNumber);
            }
            catch
            {

            }

           



        }

        private void CalculateTotal()
        {
            Decimal supplierDocAmount, receiptAmount, diff, cost, invoiceAmount;

            try
            {
                
                supplierDocAmount = Convert.ToDecimal(txt_supplierDocAmount.Text);
                receiptAmount = Convert.ToDecimal(txt_grNetAmount.Text);
                diff = Convert.ToDecimal(txt_diff.Text);
                cost = Convert.ToDecimal(txt_cost.Text);
                invoiceAmount = Convert.ToDecimal(txt_invoiceAmount.Text);

                String BCSSC = SelectedPONumber;

                if (BCSSC.Substring(0, 5).Trim() == "BCSSC")
                {
                    diff = supplierDocAmount - Convert.ToDecimal(txt_fee.Text);
                }
                else
                {
                    diff = supplierDocAmount - receiptAmount;
                }
                txt_diff.Text = diff.ToString("N2");

            }
            catch
            {
                //MessageBox.Show("Input valid value.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //txt_supplierDocAmount.Focus();
            }


        }

        private void txt_supplierDocAmount_Leave(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (txt_supplierDocNo.Text == "" || txt_supplierDocAmount.Text == "" || txt_supplierFreightAmount.Text == "" || txt_diff.Text == "")
            {
                MessageBox.Show("Please fill in all text box", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            /*if (dateTimePicker_SupplierInvoiceDate.Value.Date < dateTimePickerReceivingDate.Value.Date)
            {
                MessageBox.Show("\"Supplier Doc Reception Date\" can only be of a date that is either equal to or comes later than \"Receipt Date\".", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            DialogResult dialogResult = MessageBox.Show("Are you sure run the vaildation process?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //Get a new PIN Number from Server 12/24/2018
                String NewPINNumber = connSalesOrder.sp_GET_NewPINNumber();
                String SupplierID = txt_supplierID.Text;
                Decimal SupplierDocAmount = Convert.ToDecimal(txt_supplierDocAmount.Text);
                Decimal ReceiptAmount = Convert.ToDecimal(txt_grNetAmount.Text);
                Decimal Diff = Convert.ToDecimal(txt_diff.Text);
                Decimal Cost = 0; // Convert.ToDecimal(txt_cost.Text);
                Decimal InvoiceAmount = 0; // Convert.ToDecimal(txt_invoiceAmount.Text);

                String ReceivingSite = cbo_invoicingSite.Text.Trim();
                String RECNumber = txt_ReceiptNumber.Text.Trim();
                String SupplierDocNo = txt_supplierDocNo.Text.Trim();
                String ValidationMemo = txt_validationMemo.Text.Trim();
                DateTime ReceivingDate = Convert.ToDateTime(dateTimePickerReceivingDate.Value.ToShortDateString());
                DateTime InvoiceReceptionDate = Convert.ToDateTime(dateTimePicker_SupplierInvoiceDate.Value.ToShortDateString());

                String BCSSC = SelectedPONumber;
                if (BCSSC.Substring(0, 5).Trim() == "BCSSC")
                {
                    Decimal SubcontractFee = Convert.ToDecimal(txt_fee.Text);

                    for (int i = 0; i < grid_detail.Rows.Count; i++)
                    {
                        String Supplier = txt_supplierID.Text.Trim();
                        String PORDERNumber = grid_detail.Rows[i].Cells["Number"].Value.ToString().Trim(); ;
                        String ProductBCS = grid_detail.Rows[i].Cells["Product (BCS)"].Value.ToString().Trim();
                        //String ProductSupplier = grid_detail.Rows[i].Cells["Product (Supplier)"].Value.ToString();
                        Decimal Qty = Convert.ToDecimal(grid_detail.Rows[i].Cells["Invoiced Qty."].Value.ToString().Trim());
                        Decimal InnerCase = Convert.ToDecimal(grid_detail.Rows[i].Cells["Inner Case"].Value.ToString().Trim());
                        String Description = grid_detail.Rows[i].Cells["Description"].Value.ToString().Trim();
                        String PackSize = grid_detail.Rows[i].Cells["Pack Size"].Value.ToString().Trim();
                        Decimal GrossPrice = Convert.ToDecimal(grid_detail.Rows[i].Cells["Gross Price"].Value.ToString().Trim());
                        Decimal EDLP = Convert.ToDecimal(grid_detail.Rows[i].Cells["EDLP"].Value.ToString().Trim());
                        Decimal EDLPP = Convert.ToDecimal(grid_detail.Rows[i].Cells["EDLP (P)"].Value.ToString().Trim());
                        Decimal TermPromo = Convert.ToDecimal(grid_detail.Rows[i].Cells["Term Promo"].Value.ToString().Trim());
                        Decimal TermPromoP = Convert.ToDecimal(grid_detail.Rows[i].Cells["Term Promo (P)"].Value.ToString().Trim());
                        Decimal NetPrice = Convert.ToDecimal(grid_detail.Rows[i].Cells["Net Price"].Value.ToString().Trim());
                        Decimal OrderAmount = Convert.ToDecimal(grid_detail.Rows[i].Cells["Order Amount"].Value.ToString().Trim());
                        String Unit = grid_detail.Rows[i].Cells["Unit"].Value.ToString().Trim();
                        DateTime ExpirationDate = Convert.ToDateTime(grid_detail.Rows[i].Cells["Expiration Date"].Value.ToString().Trim());
                        ReceivingSite = grid_detail.Rows[i].Cells["Receiving Site"].Value.ToString().Trim();
                        //DateTime ReceivingDate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());//Convert.ToDateTime(dateTimePicker1.Value);
                        int ROWID = Convert.ToInt32(grid_detail.Rows[i].Cells["ROWID"].Value.ToString().Trim());

                        Entities.PORDER pORDER = new Entities.PORDER();

                        pORDER.Supplier = Supplier;
                        pORDER.RECNumber = RECNumber;
                        pORDER.PORDERNumber = PORDERNumber;
                        pORDER.ProductBCS = ProductBCS;
                        pORDER.Description = Description;
                        pORDER.PackSize = PackSize;
                        pORDER.Unit = Unit;
                        pORDER.Qty = Qty;
                        pORDER.InnerCase = InnerCase;
                        pORDER.GrossPrice = GrossPrice;
                        pORDER.EDLP = EDLP;
                        pORDER.EDLPP = EDLPP;
                        pORDER.TermPromo = TermPromo;
                        pORDER.TermPromoP = TermPromoP;
                        pORDER.NetPrice = NetPrice;
                        pORDER.OrderAmount = OrderAmount;
                        pORDER.ExpirationDate = ExpirationDate;
                        pORDER.ReceivingSite = ReceivingSite;
                        pORDER.Line = i + 1;
                        pORDER.ReceivingDate = ReceivingDate;
                        pORDER.ROWID = ROWID;

                        connPO.sp_INSERT_PINVOICED(pORDER, NewPINNumber);
                    }
                    connPO.sp_CREATE_PINVOICE_SUBCONTRACT(SupplierID, "", "", RECNumber, SupplierDocNo, SupplierDocAmount, SubcontractFee, Diff, Cost, InvoiceAmount, ReceivingSite, NewPINNumber, ReceivingDate, SubcontractFee);
                }
                else
                {
                    for (int i = 0; i < grid_detail.Rows.Count; i++)
                    {
                        String Supplier = txt_supplierID.Text.Trim();
                        String PORDERNumber = grid_detail.Rows[i].Cells["Number"].Value.ToString().Trim(); ;
                        String ProductBCS = grid_detail.Rows[i].Cells["Product (BCS)"].Value.ToString().Trim();
                        //String ProductSupplier = grid_detail.Rows[i].Cells["Product (Supplier)"].Value.ToString();
                        Decimal Qty = Convert.ToDecimal(grid_detail.Rows[i].Cells["Invoiced Qty."].Value.ToString().Trim());
                        Decimal InnerCase = Convert.ToDecimal(grid_detail.Rows[i].Cells["Inner Case"].Value.ToString().Trim());
                        String Description = grid_detail.Rows[i].Cells["Description"].Value.ToString().Trim();
                        String PackSize = grid_detail.Rows[i].Cells["Pack Size"].Value.ToString().Trim();
                        Decimal GrossPrice = Convert.ToDecimal(grid_detail.Rows[i].Cells["Gross Price"].Value.ToString().Trim());
                        Decimal EDLP = Convert.ToDecimal(grid_detail.Rows[i].Cells["EDLP"].Value.ToString().Trim());
                        Decimal EDLPP = Convert.ToDecimal(grid_detail.Rows[i].Cells["EDLP (P)"].Value.ToString().Trim());
                        Decimal TermPromo = Convert.ToDecimal(grid_detail.Rows[i].Cells["Term Promo"].Value.ToString().Trim());
                        Decimal TermPromoP = Convert.ToDecimal(grid_detail.Rows[i].Cells["Term Promo (P)"].Value.ToString().Trim());
                        Decimal NetPrice = Convert.ToDecimal(grid_detail.Rows[i].Cells["Net Price"].Value.ToString().Trim());
                        Decimal OrderAmount = Convert.ToDecimal(grid_detail.Rows[i].Cells["Order Amount"].Value.ToString().Trim());
                        String Unit = grid_detail.Rows[i].Cells["Unit"].Value.ToString().Trim();
                        DateTime ExpirationDate = Convert.ToDateTime(grid_detail.Rows[i].Cells["Expiration Date"].Value.ToString().Trim());
                        ReceivingSite = grid_detail.Rows[i].Cells["Receiving Site"].Value.ToString().Trim();
                        //DateTime ReceivingDate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());//Convert.ToDateTime(dateTimePicker1.Value);
                        int ROWID = Convert.ToInt32(grid_detail.Rows[i].Cells["ROWID"].Value.ToString().Trim());

                        Entities.PORDER pORDER = new Entities.PORDER();

                        pORDER.Supplier = Supplier;
                        pORDER.RECNumber = RECNumber;
                        pORDER.PORDERNumber = PORDERNumber;
                        pORDER.ProductBCS = ProductBCS;
                        pORDER.Description = Description;
                        pORDER.PackSize = PackSize;
                        pORDER.Unit = Unit;
                        pORDER.Qty = Qty;
                        pORDER.InnerCase = InnerCase;
                        pORDER.GrossPrice = GrossPrice;
                        pORDER.EDLP = EDLP;
                        pORDER.EDLPP = EDLPP;
                        pORDER.TermPromo = TermPromo;
                        pORDER.TermPromoP = TermPromoP;
                        pORDER.NetPrice = NetPrice;
                        pORDER.OrderAmount = OrderAmount;
                        pORDER.ExpirationDate = ExpirationDate;
                        pORDER.ReceivingSite = ReceivingSite;
                        pORDER.Line = i + 1;
                        pORDER.ReceivingDate = ReceivingDate;
                        pORDER.ROWID = ROWID;

                        connPO.sp_INSERT_PINVOICED(pORDER, NewPINNumber);

                        //저널Detail
                        connPO.sp_PPAYMENT_JOU_VALIDATIOND(pORDER, NewPINNumber);

                    }
                    //MessageBox.Show("Validation Complete!");
                    //저널H
                    connPO.sp_PPAYMENT_JOU_VALIDATION(ReceivingSite, SupplierID, NewPINNumber);
                    connPO.sp_CREATE_PINVOICE(SupplierID, ValidationMemo, "", RECNumber, SupplierDocNo, SupplierDocAmount, ReceiptAmount, Diff, Cost, InvoiceAmount, ReceivingSite, NewPINNumber, ReceivingDate, InvoiceReceptionDate);

                    /*
                    //Freight inv만들고 저널
                    Decimal SupplierFreightAmount = Convert.ToDecimal(txt_supplierFreightAmount.Text.Trim());
                    String FreightBranch = cbo_invoicingSite.Text.Trim();
                    if (SupplierFreightAmount > 0)
                    {
                        //Get a new PIN Number from Server 12/24/2018
                        NewPINNumber = connSalesOrder.sp_GET_NewPINNumber();
                        connPO.sp_CREATE_PINVOICE_FREIGHT(SupplierID, SupplierDocNo, SupplierFreightAmount, FreightBranch, RECNumber, NewPINNumber);
                    }
                    */
                }
                
                //connSalesOrder.sp_PORDER_SelectionHeader(grid_selectionHeader);
                String SearchRecNumber = txt_searchRecNo.Text.Trim();
                String SearchPONumber = txt_searchPoNo.Text.Trim();
                String SearchSupplier = txt_searchSupplier.Text.Trim();

                DateTime FromDate = dateTimePickerFrom.Value.Date;
                DateTime ToDate = dateTimePickerTo.Value.Date;
                connPO.sp_PRECEIPT_VALIDATIONHEADER(grid_receiving, SearchRecNumber, SearchPONumber, SearchSupplier, FromDate, ToDate);
                
                btn_create.Enabled = false;
                grid_detail.DataSource = null;
                txt_supplierID.Text = "";
                txt_supplierDocNo.Text = "";
                txt_supplierDocNo.Text = "";
                txt_grNetAmount.Text = "";
                txt_diff.Text = "";
                txt_cost.Text = "";
                txt_invoiceAmount.Text = "";
                txt_validationMemo.Text = "";
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        
        private void txt_searchRecNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String RecNumber = txt_searchRecNo.Text.Trim();
                String PONumber = txt_searchPoNo.Text.Trim();
                String Supplier = txt_searchSupplier.Text.Trim();
                DateTime FromDate = dateTimePickerFrom.Value.Date;
                DateTime ToDate = dateTimePickerTo.Value.Date;
                connPO.sp_PRECEIPT_VALIDATIONHEADER(grid_receiving, RecNumber, PONumber, Supplier, FromDate, ToDate);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }
        
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            String RecNumber = txt_searchRecNo.Text.Trim();
            String PONumber = txt_searchPoNo.Text.Trim();
            String Supplier = txt_searchSupplier.Text.Trim();
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            connPO.sp_PRECEIPT_VALIDATIONHEADER(grid_receiving, RecNumber, PONumber, Supplier, FromDate, ToDate);
        }

        private void grid_detail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void grid_receiving_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String PONumber = grid_receiving.Rows[e.RowIndex].Cells["PO No."].Value.ToString();
            DateTime ReceivingDate = Convert.ToDateTime(grid_receiving.Rows[e.RowIndex].Cells["Receipt Date"].Value.ToString());
            String RECNumber = grid_receiving.Rows[e.RowIndex].Cells["Receipt No."].Value.ToString();
            String Supplier = grid_receiving.Rows[e.RowIndex].Cells["Supplier ID"].Value.ToString();

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.POCaculator))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Purchase.POCaculator fm = new Purchase.POCaculator(PONumber, ReceivingDate, RECNumber, Supplier);
            fm.Show();
        }

        private void txt_supplierDocAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_supplierDocAmount_Enter(object sender, EventArgs e)
        {
            txt_supplierDocAmount.SelectAll();
        }

        private void txt_supplierDocAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btn_calculator_Click(object sender, EventArgs e)
        {
            String PONumber = txt_poNumber.Text;
            DateTime ReceivingDate = Convert.ToDateTime(dateTimePickerReceivingDate.Value.ToString());
            String RECNumber = txt_ReceiptNumber.Text;
            String Supplier = txt_supplierID.Text;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.POCaculator))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //Purchase.POCaculator fm = new Purchase.POCaculator(PONumber, ReceivingDate, RECNumber, Supplier);
            Purchase.POCalculator2 fm = new Purchase.POCalculator2(PONumber, ReceivingDate, RECNumber, Supplier);
            fm.Show();
        }
    }
}
