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
    public partial class DebitNote : Form
    {
        public DebitNote()
        {
            InitializeComponent();

            //connPO.cbox_getVendorID(cbo_supplierID);
            //connPO.cbox_getVendorID(cbo_freightSupplier);

            //header grid multi line allow
            grid_POinvoice.AllowDrop = true;
            grid_POinvoice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_POinvoice.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            connPO.cbox_getVendorID(cbo_searchSupplierID);
            
            dateTimePickerFrom.Value = DateTime.Today.AddMonths(-1);
            grid_POinvoice_Init();
            grid_detail_Init();
            refresh();
        }

        private void grid_POinvoice_Init()
        {
            grid_POinvoice.AutoGenerateColumns = false;
            grid_POinvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_POinvoice.ColumnCount = 27;

            grid_POinvoice.Columns[0].Name = "Create Date";
            grid_POinvoice.Columns[0].ReadOnly = true;
            grid_POinvoice.Columns[0].Width = 80;
            grid_POinvoice.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_POinvoice.Columns[0].DataPropertyName = "CREDATTIM_0";//"ACCDAT_0";

            grid_POinvoice.Columns[1].Name = "Rec Date";
            grid_POinvoice.Columns[1].ReadOnly = true;
            grid_POinvoice.Columns[1].Width = 80;
            grid_POinvoice.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_POinvoice.Columns[1].DataPropertyName = "ACCDAT_0";

            grid_POinvoice.Columns[2].Name = "Entry";
            grid_POinvoice.Columns[2].ReadOnly = true;
            grid_POinvoice.Columns[2].Width = 80;
            grid_POinvoice.Columns[2].DataPropertyName = "NUM_0";

            grid_POinvoice.Columns[3].Name = "PO Number";
            grid_POinvoice.Columns[3].ReadOnly = true;
            grid_POinvoice.Columns[3].Width = 80;
            grid_POinvoice.Columns[3].DataPropertyName = "POHNUM_0";

            grid_POinvoice.Columns[4].Name = "BP";
            grid_POinvoice.Columns[4].ReadOnly = true;
            grid_POinvoice.Columns[4].Width = 120;
            grid_POinvoice.Columns[4].DataPropertyName = "BPR_0";

            grid_POinvoice.Columns[5].Name = "Site";
            grid_POinvoice.Columns[5].ReadOnly = true;
            grid_POinvoice.Columns[5].Width = 40;
            grid_POinvoice.Columns[5].DataPropertyName = "FCY_0";

            grid_POinvoice.Columns[6].Name = "Document";
            grid_POinvoice.Columns[6].ReadOnly = true;
            grid_POinvoice.Columns[6].Width = 160;
            grid_POinvoice.Columns[6].MinimumWidth = 80;
            grid_POinvoice.Columns[6].DataPropertyName = "INVREF_0";

            grid_POinvoice.Columns[7].Name = "SupplierDocAmount";
            grid_POinvoice.Columns[7].Visible = false;
            grid_POinvoice.Columns[7].Width = 120;
            grid_POinvoice.Columns[7].DataPropertyName = "SupplierDocAmount";

            grid_POinvoice.Columns[8].Name = "ReceiptAmount";
            grid_POinvoice.Columns[8].Visible = false;
            grid_POinvoice.Columns[8].Width = 120;
            grid_POinvoice.Columns[8].DataPropertyName = "ReceiptAmount";

            grid_POinvoice.Columns[9].Name = "Diff";
            grid_POinvoice.Columns[9].Visible = false;
            grid_POinvoice.Columns[9].Width = 120;
            grid_POinvoice.Columns[9].DataPropertyName = "Diff";

            grid_POinvoice.Columns[10].Name = "Cost";
            grid_POinvoice.Columns[10].Visible = false;
            grid_POinvoice.Columns[10].Width = 120;
            grid_POinvoice.Columns[10].DataPropertyName = "Cost";

            grid_POinvoice.Columns[11].Name = "InvoiceAmount";
            grid_POinvoice.Columns[11].Visible = false;
            grid_POinvoice.Columns[11].Width = 120;
            grid_POinvoice.Columns[11].DataPropertyName = "InvoiceAmount";

            grid_POinvoice.Columns[12].Name = "SupplierName";
            grid_POinvoice.Columns[12].Visible = false;
            grid_POinvoice.Columns[12].DataPropertyName = "BPRNAM_0";

            grid_POinvoice.Columns[13].Name = "RECNumber";
            grid_POinvoice.Columns[13].Visible = false;
            grid_POinvoice.Columns[13].DataPropertyName = "ORIDOCNUM_0";

            grid_POinvoice.Columns[14].Name = "POIssueDate";
            grid_POinvoice.Columns[14].Visible = false;
            grid_POinvoice.Columns[14].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_POinvoice.Columns[14].DataPropertyName = "POIssueDate";

            grid_POinvoice.Columns[15].Name = "POIssueDate";
            grid_POinvoice.Columns[15].Visible = false;
            grid_POinvoice.Columns[15].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_POinvoice.Columns[15].DataPropertyName = "ORDDAT_0";

            grid_POinvoice.Columns[16].Name = "TotalPOGrossAmount";
            grid_POinvoice.Columns[16].Visible = false;
            grid_POinvoice.Columns[16].DefaultCellStyle.Format = "N2";
            grid_POinvoice.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[16].DataPropertyName = "TotalPOGrossAmount";

            grid_POinvoice.Columns[17].Name = "POEDLP";
            grid_POinvoice.Columns[17].Visible = false;
            grid_POinvoice.Columns[17].DefaultCellStyle.Format = "N2";
            grid_POinvoice.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[17].DataPropertyName = "POEDLP";

            grid_POinvoice.Columns[18].Name = "POTermPromo";
            grid_POinvoice.Columns[18].Visible = false;
            grid_POinvoice.Columns[18].DefaultCellStyle.Format = "N2";
            grid_POinvoice.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[18].DataPropertyName = "POTermPromo";

            grid_POinvoice.Columns[19].Name = "TotalPOAmount";
            grid_POinvoice.Columns[19].Visible = false;
            grid_POinvoice.Columns[19].DefaultCellStyle.Format = "N2";
            grid_POinvoice.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[19].DataPropertyName = "TotalPOAmount";

            grid_POinvoice.Columns[20].Name = "TotalRECGrossAmount";
            grid_POinvoice.Columns[20].Visible = false;
            grid_POinvoice.Columns[20].DefaultCellStyle.Format = "N2";
            grid_POinvoice.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[20].DataPropertyName = "TotalRECGrossAmount";

            grid_POinvoice.Columns[21].Name = "RECEDLP";
            grid_POinvoice.Columns[21].Visible = false;
            grid_POinvoice.Columns[21].DefaultCellStyle.Format = "N2";
            grid_POinvoice.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[21].DataPropertyName = "RECEDLP";

            grid_POinvoice.Columns[22].Name = "RECTermPromo";
            grid_POinvoice.Columns[22].Visible = false;
            grid_POinvoice.Columns[22].DefaultCellStyle.Format = "N2";
            grid_POinvoice.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[22].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[22].DataPropertyName = "RECTermPromo";

            grid_POinvoice.Columns[23].Name = "TotalRECAmount";
            grid_POinvoice.Columns[23].Visible = false;
            grid_POinvoice.Columns[23].DefaultCellStyle.Format = "N2";
            grid_POinvoice.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[23].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POinvoice.Columns[23].DataPropertyName = "TotalRECAmount";

            grid_POinvoice.Columns[24].Name = "TypeCode";
            grid_POinvoice.Columns[24].Visible = false;
            grid_POinvoice.Columns[24].DataPropertyName = "TypeCode";

            grid_POinvoice.Columns[25].Name = "TypeName";
            grid_POinvoice.Columns[25].Visible = false;
            grid_POinvoice.Columns[25].DataPropertyName = "TypeName";

            grid_POinvoice.Columns[26].Name = "SupplierInvoiceDate";
            grid_POinvoice.Columns[26].Visible = false;
            grid_POinvoice.Columns[26].DataPropertyName = "SupplierInvoiceDate";

            //grid font size custom
            grid_POinvoice.RowTemplate.Height = 20;
            grid_POinvoice.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_POinvoice.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_POinvoice.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
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
            //grid_detail.Columns[3].Visible = false;
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

        private void refresh()
        {
            String SearchSupplierID = cbo_searchSupplierID.Text.Trim();
            String SearchPONumber = txt_searchPONumber.Text.Trim();
            String SearchSupplierInvoiceNumber = txt_searchSupplierInvoiceNumber.Text.Trim();
            
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            
            
            connPO.sp_PINVOICE_HEADER(grid_POinvoice, SearchSupplierID, SearchSupplierInvoiceNumber, SearchPONumber, FromDate, ToDate);
        }

        private void btn_createDebitNote_Click(object sender, EventArgs e)
        {
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.GetType() == typeof(DEPOSITSLIP))
            //    {
            //        form.Activate();
            //        form.WindowState = FormWindowState.Normal;
            //        form.BringToFront();
            //        return;
            //    }
            //}
            CreateDebitNote createDebitNote = new CreateDebitNote();
            createDebitNote.ShowDialog();

            if (createDebitNote.save == true)
            {
                refresh();
            }
        }
        
        private void grid_POinvoice_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //init text fields
                txt_poNumber.Text = "";
                txt_poGrossAmount.Text = "";
                txt_poEDLP.Text = "";
                txt_poTermPromo.Text = "";
                txt_poNetAmount.Text = "";

                txt_ReceiptNumber.Text = "";
                txt_grGrossAmount.Text = "";
                txt_recEDLP.Text = "";
                txt_recTermPromo.Text = "";
                txt_grGrossAmount.Text = "";

                txt_supplierDocNo.Text = "";
                txt_supplierDocAmount.Text = "";
                txt_diff.Text = "";

                //declare 
                DateTime POIssueDate;
                String PONumber;
                Decimal TotalPOGrossAmount;
                Decimal POEDLP;
                Decimal POTermPromo;
                Decimal TotalPOAmount;

                DateTime ReceivingDate;
                String ReceiptNumber;
                Decimal TotalRECGrossAmount;
                Decimal RECEDLP;
                Decimal RECTermPromo;
                Decimal TotalRECAmount;

                String POInvoiceNumber;
                String SupplierDocNo;
                Decimal SupplierDocAmount;
                Decimal Diff;
                DateTime SupplierInvoiceDate;

                String SupplierID = grid_POinvoice.Rows[e.RowIndex].Cells["BP"].Value.ToString();
                String SupplierName = grid_POinvoice.Rows[e.RowIndex].Cells["SupplierName"].Value.ToString();
                txt_supplierID.Text = SupplierID;
                txt_supplierName.Text = SupplierName;


                //set values
                String POInvoicePONumber = "";
                POInvoicePONumber = grid_POinvoice.Rows[e.RowIndex].Cells["PO Number"].Value.ToString().Trim();
                String TypeCode = grid_POinvoice.Rows[e.RowIndex].Cells["TypeCode"].Value.ToString().Trim();

                if(POInvoicePONumber == "")
                {
                    POInvoicePONumber = "XXXXX";
                }

                if (POInvoicePONumber.Substring(0, 5).Trim() == "BCSSC" )
                {
                    Decimal AmountTotal = 0;
                    AmountTotal = connSalesOrder.sp_GET_SUBCONTRACTFEE(POInvoicePONumber);
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

                    lbl_panelpo.Visible = true;
                    panel1.Visible = true;
                    panel6.Visible = true;

                    customLabel32.Visible = true;
                    panel4.Visible = true;
                    panel7.Visible = true;

                    customLabel33.Visible = true;
                    panel5.Visible = true;

                    lbl_invoice.Visible = false;
                    panel_invoice.Visible = false;

                    btn_calculator.Visible = false;
                }
                else
                {
                    if (POInvoicePONumber.Substring(0, 2).Trim() == "PO" && TypeCode == "")
                    {
                        lbl_panelpo.Visible = true;
                        panel1.Visible = true;
                        panel6.Visible = true;

                        customLabel32.Visible = true;
                        panel4.Visible = true;
                        panel7.Visible = true;

                        customLabel33.Visible = true;
                        panel5.Visible = true;

                        lbl_invoice.Visible = false;
                        panel_invoice.Visible = false;

                        btn_calculator.Visible = true;
                    }
                    else// if(TypeCode != "")
                    {
                        lbl_panelpo.Visible = false;
                        panel1.Visible = false;
                        panel6.Visible = false;

                        customLabel32.Visible = false;
                        panel4.Visible = false;
                        panel7.Visible = false;

                        customLabel33.Visible = false;
                        panel5.Visible = false;

                        lbl_invoice.Visible = true;
                        panel_invoice.Visible = true;

                        btn_calculator.Visible = false;

                        txt_invoiceNumber.Text = grid_POinvoice.Rows[e.RowIndex].Cells["Entry"].Value.ToString();
                        txt_supplierDocNumber.Text = grid_POinvoice.Rows[e.RowIndex].Cells["Document"].Value.ToString();
                        txt_invoiceAmount.Text = Convert.ToDecimal(grid_POinvoice.Rows[e.RowIndex].Cells["ReceiptAmount"].Value.ToString().Trim()).ToString("N2");
                        txt_typeCode.Text = grid_POinvoice.Rows[e.RowIndex].Cells["TypeCode"].Value.ToString();
                        txt_typeName.Text = grid_POinvoice.Rows[e.RowIndex].Cells["TypeName"].Value.ToString();
                    }

                    lbl_number.Text = "PO Number";
                    panel_PO.Visible = true;
                    panel_receipt.Visible = true;
                    txt_fee.Text = "";

                    lbl_panelpo.Text = "PO";
                    lbl_poIssueDate.Visible = true;
                    dateTimePickerPoIssueDate.Visible = true;

                    //po issue date
                    POIssueDate = Convert.ToDateTime(grid_POinvoice.Rows[e.RowIndex].Cells["POIssueDate"].Value.ToString());
                    dateTimePickerPoIssueDate.Value = POIssueDate;

                    //po gross amount
                    TotalPOGrossAmount = Convert.ToDecimal(grid_POinvoice.Rows[e.RowIndex].Cells["TotalPOGrossAmount"].Value.ToString().Trim());
                    txt_poGrossAmount.Text = TotalPOGrossAmount.ToString("N2");

                    //po edlp
                    POEDLP = Convert.ToDecimal(grid_POinvoice.Rows[e.RowIndex].Cells["POEDLP"].Value.ToString().Trim());
                    txt_poEDLP.Text = POEDLP.ToString("N2");

                    //po term promo
                    POTermPromo = Convert.ToDecimal(grid_POinvoice.Rows[e.RowIndex].Cells["POTermPromo"].Value.ToString().Trim());
                    txt_poTermPromo.Text = POTermPromo.ToString("N2");

                    //po net amount
                    TotalPOAmount = Convert.ToDecimal(grid_POinvoice.Rows[e.RowIndex].Cells["TotalPOAmount"].Value.ToString().Trim());
                    txt_poNetAmount.Text = TotalPOAmount.ToString("N2");
                }

                if(POInvoicePONumber.ToString().Trim() == "")
                {
                    txt_poNumber.Text = "";
                    txt_supplierDocAmount.Text = "";
                    txt_diff.Text = "";
                }
                else
                {
                    //po number
                    PONumber = grid_POinvoice.Rows[e.RowIndex].Cells["PO Number"].Value.ToString();
                    txt_poNumber.Text = PONumber;

                    //receiving date
                    ReceivingDate = Convert.ToDateTime(grid_POinvoice.Rows[e.RowIndex].Cells["Rec Date"].Value.ToString());
                    dateTimePickerReceivingDate.Value = ReceivingDate;

                    //receipt number
                    String RECNumber = grid_POinvoice.Rows[e.RowIndex].Cells["RECNumber"].Value.ToString();
                    txt_ReceiptNumber.Text = RECNumber;

                    //gr gross amount
                    TotalRECGrossAmount = Convert.ToDecimal(grid_POinvoice.Rows[e.RowIndex].Cells["TotalRECGrossAmount"].Value.ToString().Trim());
                    txt_grGrossAmount.Text = TotalRECGrossAmount.ToString("N2");

                    //rec edlp
                    RECEDLP = Convert.ToDecimal(grid_POinvoice.Rows[e.RowIndex].Cells["RECEDLP"].Value.ToString().Trim());
                    txt_recEDLP.Text = RECEDLP.ToString("N2");

                    //rec term promo
                    RECTermPromo = Convert.ToDecimal(grid_POinvoice.Rows[e.RowIndex].Cells["RECTermPromo"].Value.ToString().Trim());
                    txt_recTermPromo.Text = RECTermPromo.ToString("N2");

                    //supplier doc amount
                    SupplierDocAmount = Convert.ToDecimal(grid_POinvoice.Rows[e.RowIndex].Cells["SupplierDocAmount"].Value.ToString());
                    txt_supplierDocAmount.Text = SupplierDocAmount.ToString("N2");

                    //diff
                    Diff = Convert.ToDecimal(grid_POinvoice.Rows[e.RowIndex].Cells["Diff"].Value.ToString());
                    txt_diff.Text = Diff.ToString("N2");

                }
                
                //gr net amount
                TotalRECAmount = Convert.ToDecimal(grid_POinvoice.Rows[e.RowIndex].Cells["ReceiptAmount"].Value.ToString().Trim());
                txt_grNetAmount.Text = TotalRECAmount.ToString("N2");

                //------------------
                //po invoice number;
                POInvoiceNumber = grid_POinvoice.Rows[e.RowIndex].Cells["Entry"].Value.ToString();
                txt_poInvoiceNumber.Text = POInvoiceNumber;

                //supplier doc no
                SupplierDocNo = grid_POinvoice.Rows[e.RowIndex].Cells["Document"].Value.ToString();
                txt_supplierDocNo.Text = SupplierDocNo;

                SupplierInvoiceDate = Convert.ToDateTime(grid_POinvoice.Rows[e.RowIndex].Cells["SupplierInvoiceDate"].Value.ToString());
                dateTimePicker_SupplierInvoiceDate.Value = SupplierInvoiceDate;

                connSalesOrder.sp_PINVOICE_DETAIL(grid_detail, POInvoiceNumber);
            }
            catch
            {
                grid_detail.DataSource = null;
                txt_grNetAmount.Text = "";
                txt_poInvoiceNumber.Text = grid_POinvoice.Rows[e.RowIndex].Cells["Entry"].Value.ToString(); ;

                //supplier doc no
                txt_supplierDocNo.Text = grid_POinvoice.Rows[e.RowIndex].Cells["Document"].Value.ToString(); ;

                //txt_poInvoiceNumber.Text = "";

                //MessageBox.Show("Freight and Charge Back invoice updating in progress...");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            refresh();
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
            Purchase.POCaculator fm = new Purchase.POCaculator(PONumber, ReceivingDate, RECNumber, Supplier);
            fm.Show();
        }
    }
}
