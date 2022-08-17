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
    public partial class PurchaseOrderExceptionReport : Form
    {
        public PurchaseOrderExceptionReport()
        {
            InitializeComponent();
            grid_all_Init();
            cbo_poOpenStatus.Items.Add("");
            cbo_poOpenStatus.Items.Add("Open");
            cbo_poOpenStatus.Items.Add("Close");
            
            connPO.cbox_getVendorID(cbo_SupplierID);

        }
        
        /* 
           grid_all_Init() initializes the grid that is to load when the corresponding WinForms ReportViewer Control 
           is loaded from a user on the ERP software. Data for each column is extracted from the company's database by 
           binding Events such as the click of a button (on a winforms properties) to a SSMS stored procedure.
        */
        private void grid_all_Init()
        {
            grid_AR.AutoGenerateColumns = false;
            grid_AR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_AR.ColumnCount = 40;

            grid_AR.Columns[0].Name = "Supplier ID";
            grid_AR.Columns[0].ReadOnly = true;
            grid_AR.Columns[0].Width = 100;
            grid_AR.Columns[0].MinimumWidth = 100;
            grid_AR.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[0].DataPropertyName = "SupplierID";

            grid_AR.Columns[1].Name = "PO Date";
            grid_AR.Columns[1].ReadOnly = true;
            grid_AR.Columns[1].Width = 80;
            grid_AR.Columns[1].MinimumWidth = 80;
            grid_AR.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_AR.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[1].DataPropertyName = "PODate";

            grid_AR.Columns[2].Name = "PO Number";
            grid_AR.Columns[2].ReadOnly = true;
            grid_AR.Columns[2].Width = 80;
            grid_AR.Columns[2].MinimumWidth = 80;
            grid_AR.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[2].DataPropertyName = "PONumber";

            grid_AR.Columns[3].Name = "PO Gross Amount";
            grid_AR.Columns[3].ReadOnly = true;
            grid_AR.Columns[3].Width = 80;
            grid_AR.Columns[3].MinimumWidth = 80;
            grid_AR.Columns[3].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[3].DataPropertyName = "POGrossAmount";

            grid_AR.Columns[4].Name = "PO EDLP";
            grid_AR.Columns[4].ReadOnly = true;
            grid_AR.Columns[4].Width = 80;
            grid_AR.Columns[4].MinimumWidth = 80;
            grid_AR.Columns[4].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[4].DataPropertyName = "POEDLP";

            grid_AR.Columns[5].Name = "PO Term Promotion";
            grid_AR.Columns[5].ReadOnly = true;
            grid_AR.Columns[5].Width = 80;
            grid_AR.Columns[5].MinimumWidth = 80;
            grid_AR.Columns[5].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[5].DataPropertyName = "POTermPromo";

            grid_AR.Columns[6].Name = "PO Net Amount";
            grid_AR.Columns[6].ReadOnly = true;
            grid_AR.Columns[6].Width = 80;
            grid_AR.Columns[6].MinimumWidth = 80;
            grid_AR.Columns[6].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[6].DataPropertyName = "POAmount";
            
            grid_AR.Columns[7].Name = "PO Status";
            grid_AR.Columns[7].ReadOnly = true;
            grid_AR.Columns[7].Width = 80;
            grid_AR.Columns[7].MinimumWidth = 80;
            grid_AR.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[7].DataPropertyName = "POStatus";

            grid_AR.Columns[8].Name = "Goods Receipt Date";
            grid_AR.Columns[8].ReadOnly = true;
            grid_AR.Columns[8].Width = 80;
            grid_AR.Columns[8].MinimumWidth = 80;
            grid_AR.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_AR.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[8].DataPropertyName = "GoodsReceiptDate";

            grid_AR.Columns[9].Name = "Goods Receipt No.";
            grid_AR.Columns[9].ReadOnly = true;
            grid_AR.Columns[9].Width = 80;
            grid_AR.Columns[9].MinimumWidth = 80;
            grid_AR.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[9].DataPropertyName = "GoodsReceiptNo";

            grid_AR.Columns[10].Name = "Not Goods Receipt";
            grid_AR.Columns[10].ReadOnly = true;
            grid_AR.Columns[10].Width = 100;
            grid_AR.Columns[10].MinimumWidth = 100;
            grid_AR.Columns[10].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[10].DataPropertyName = "NotGR";

            grid_AR.Columns[11].Name = "Goods Receipt Gross Amount";
            grid_AR.Columns[11].ReadOnly = true;
            grid_AR.Columns[11].Width = 100;
            grid_AR.Columns[11].MinimumWidth = 100;
            grid_AR.Columns[11].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[11].DataPropertyName = "RECGrossAmount";

            grid_AR.Columns[12].Name = "Goods Receipt EDLP";
            grid_AR.Columns[12].ReadOnly = true;
            grid_AR.Columns[12].Width = 80;
            grid_AR.Columns[12].MinimumWidth = 80;
            grid_AR.Columns[12].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[12].DataPropertyName = "RECEDLP";

            grid_AR.Columns[13].Name = "Goods Receipt Term Promotion";
            grid_AR.Columns[13].ReadOnly = true;
            grid_AR.Columns[13].Width = 80;
            grid_AR.Columns[13].MinimumWidth = 80;
            grid_AR.Columns[13].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[13].DataPropertyName = "RECTermPromo";

            grid_AR.Columns[14].Name = "Goods Receipt Net Amount";
            grid_AR.Columns[14].ReadOnly = true;
            grid_AR.Columns[14].Width = 80;
            grid_AR.Columns[14].MinimumWidth = 80;
            grid_AR.Columns[14].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[14].DataPropertyName = "GRAmount";

            grid_AR.Columns[15].Name = "Goods Receipt Status";
            grid_AR.Columns[15].ReadOnly = true;
            grid_AR.Columns[15].Width = 100;
            grid_AR.Columns[15].MinimumWidth = 100;
            grid_AR.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[15].DataPropertyName = "GRStatus";

            grid_AR.Columns[16].Name = "AP Invoice Date";
            grid_AR.Columns[16].ReadOnly = true;
            grid_AR.Columns[16].Width = 80;
            grid_AR.Columns[16].MinimumWidth = 80;
            grid_AR.Columns[16].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_AR.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[16].DataPropertyName = "APInvoiceDate";

            grid_AR.Columns[17].Name = "AP Invoice Number";
            grid_AR.Columns[17].ReadOnly = true;
            grid_AR.Columns[17].Width = 90;
            grid_AR.Columns[17].MinimumWidth = 90;
            grid_AR.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[17].DataPropertyName = "APInvoiceNumber";

            grid_AR.Columns[18].Name = "Supplier Doc. Date";
            grid_AR.Columns[18].Visible = true;
            grid_AR.Columns[18].ReadOnly = true;
            grid_AR.Columns[18].Width = 90;
            grid_AR.Columns[18].MinimumWidth = 90;
            grid_AR.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[18].DataPropertyName = "SupplierDocDate";

            grid_AR.Columns[19].Name = "Supplier Doc. Number";
            grid_AR.Columns[19].ReadOnly = true;
            grid_AR.Columns[19].Width = 90;
            grid_AR.Columns[19].MinimumWidth = 90;
            grid_AR.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[19].DataPropertyName = "SupplierDocNumber";

            grid_AR.Columns[20].Name = "AP Invoice Amount";
            grid_AR.Columns[20].ReadOnly = true;
            grid_AR.Columns[20].Width = 90;
            grid_AR.Columns[20].MinimumWidth = 90;
            grid_AR.Columns[20].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[20].DataPropertyName = "APInvoiceAmount";

            grid_AR.Columns[21].Name = "Payment Term";
            grid_AR.Columns[21].ReadOnly = true;
            grid_AR.Columns[21].Width = 100;
            grid_AR.Columns[21].MinimumWidth = 100;
            grid_AR.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[21].DataPropertyName = "PaymentTerm";

            grid_AR.Columns[22].Name = "Discount Due Date";
            grid_AR.Columns[22].ReadOnly = true;
            grid_AR.Columns[22].Width = 80;
            grid_AR.Columns[22].MinimumWidth = 80;
            grid_AR.Columns[22].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_AR.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[22].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[22].DataPropertyName = "DiscountDueDate";

            grid_AR.Columns[23].Name = "Payment Due Date";
            grid_AR.Columns[23].ReadOnly = true;
            grid_AR.Columns[23].Width = 80;
            grid_AR.Columns[23].MinimumWidth = 80;
            grid_AR.Columns[23].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_AR.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[23].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[23].DataPropertyName = "PaymentDueDate";

            grid_AR.Columns[24].Name = "AP Invoice Status";
            grid_AR.Columns[24].ReadOnly = true;
            grid_AR.Columns[24].Width = 80;
            grid_AR.Columns[24].MinimumWidth = 80;
            grid_AR.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[24].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[24].DataPropertyName = "APInvoiceStatus";
        
            grid_AR.Columns[25].Name = "Last Payment Date";
            grid_AR.Columns[25].ReadOnly = true;
            grid_AR.Columns[25].Width = 80;
            grid_AR.Columns[25].MinimumWidth = 80;
            grid_AR.Columns[25].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_AR.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[25].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[25].DataPropertyName = "LastPaymentDate";

            grid_AR.Columns[26].Name = "Payment Type";
            grid_AR.Columns[26].ReadOnly = true;
            grid_AR.Columns[26].Width = 80;
            grid_AR.Columns[26].MinimumWidth = 80;
            grid_AR.Columns[26].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[26].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[26].DataPropertyName = "PaymentType";
        
            grid_AR.Columns[27].Name = "Last Check Number";
            grid_AR.Columns[27].ReadOnly = true;
            grid_AR.Columns[27].Width = 80;
            grid_AR.Columns[27].MinimumWidth = 80;
            grid_AR.Columns[27].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[27].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[27].DataPropertyName = "LastCheckNumber";

            grid_AR.Columns[28].Name = "Last Check Date";
            grid_AR.Columns[28].ReadOnly = true;
            grid_AR.Columns[28].Width = 80;
            grid_AR.Columns[28].MinimumWidth = 80;
            grid_AR.Columns[28].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_AR.Columns[28].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[28].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[28].DataPropertyName = "LastCheckDate";

            grid_AR.Columns[29].Name = "AP Last Check Amount";
            grid_AR.Columns[29].ReadOnly = true;
            grid_AR.Columns[29].Width = 70;
            grid_AR.Columns[29].MinimumWidth = 70;
            grid_AR.Columns[29].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[29].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[29].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[29].DataPropertyName = "APLastCheckAmount";

            grid_AR.Columns[30].Name = "Promotion";
            grid_AR.Columns[30].MinimumWidth = 80;
            grid_AR.Columns[30].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[30].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[30].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[30].DataPropertyName = "Promotion";

            grid_AR.Columns[31].Name = "EDLP";
            grid_AR.Columns[31].ReadOnly = true;
            grid_AR.Columns[31].Width = 80;
            grid_AR.Columns[31].MinimumWidth = 80;
            grid_AR.Columns[31].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[31].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[31].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[31].DataPropertyName = "EDLP";

            grid_AR.Columns[32].Name = "Billback";
            grid_AR.Columns[32].ReadOnly = true;
            grid_AR.Columns[32].Width = 80;
            grid_AR.Columns[32].MinimumWidth = 80;
            grid_AR.Columns[32].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[32].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[32].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[32].DataPropertyName = "Billback";

            grid_AR.Columns[33].Name = "Credit";
            grid_AR.Columns[33].ReadOnly = true;
            grid_AR.Columns[33].Width = 80;
            grid_AR.Columns[33].MinimumWidth = 80;
            grid_AR.Columns[33].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[33].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[33].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[33].DataPropertyName = "Credit";

            grid_AR.Columns[34].Name = "Return";
            grid_AR.Columns[34].ReadOnly = true;
            grid_AR.Columns[34].Width = 80;
            grid_AR.Columns[34].MinimumWidth = 80;
            grid_AR.Columns[34].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[34].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[34].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[34].DataPropertyName = "ReturnCredit";

            grid_AR.Columns[35].Name = "Term Discount";
            grid_AR.Columns[35].ReadOnly = true;
            grid_AR.Columns[35].Width = 80;
            grid_AR.Columns[35].MinimumWidth = 80;
            grid_AR.Columns[35].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[35].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[35].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[35].DataPropertyName = "TermCredit";

            grid_AR.Columns[36].Name = "Debit";
            grid_AR.Columns[36].ReadOnly = true;
            grid_AR.Columns[36].Width = 70;
            grid_AR.Columns[36].MinimumWidth = 70;
            grid_AR.Columns[36].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[36].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[36].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[36].DataPropertyName = "Debit";

            grid_AR.Columns[37].ReadOnly = true;
            grid_AR.Columns[37].Width = 70;
            grid_AR.Columns[37].MinimumWidth = 70;
            grid_AR.Columns[37].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[37].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[37].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[37].DataPropertyName = "PaymentAmount";

            grid_AR.Columns[38].Name = "PO Open Balance";
            grid_AR.Columns[38].ReadOnly = true;
            grid_AR.Columns[38].Width = 80;
            grid_AR.Columns[38].MinimumWidth = 80;
            grid_AR.Columns[38].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[38].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[38].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[38].DataPropertyName = "POOpenBalance";

            grid_AR.Columns[39].Name = "PO Open Status";
            grid_AR.Columns[39].ReadOnly = true;
            grid_AR.Columns[39].Width = 80;
            grid_AR.Columns[39].MinimumWidth = 80;
            grid_AR.Columns[39].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[39].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[39].DataPropertyName = "POOpenStatus";
          
            //grid font size custom
            grid_AR.RowTemplate.Height = 20;
            grid_AR.ColumnHeadersHeight = 100;

            foreach (DataGridViewColumn c in grid_AR.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
            }

            grid_AR.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
        }
    
        /*
        btn_search_Click()
        
        Clicking the "Search" button would extract data from certain columns, send them in as arguments into a function, 
        "sp_PurchaseOrcerExceptionReport" within a "connSalesOrder" folder, which will in-turn send these same arguments in as variables for datatypes 
        I would declare in a stored procedure to help query for the data that I need from whatever table.
        */
        private void btn_search_Click(object sender, EventArgs e)
        {
            String POFromX3 = "";
            if (cbx_x3.Checked)
            {
                POFromX3 = "Checked";
            }
            else
            {
                POFromX3 = "Unchecked";
            }
            
            DateTime FromDate = dateTimePickerFromDate.Value.Date;
            DateTime AsOfDate = dateTimePickerAsOf.Value.Date;
            String SupplierID = cbo_SupplierID.Text.Trim();
            String CheckNumber = txt_checkNo.Text.Trim();
            String POOpenStatus = cbo_poOpenStatus.Text.Trim();
            connSalesOrder.sp_PurchaseOrderExceptionReport(grid_AR, FromDate, AsOfDate, CheckNumber, SupplierID, POOpenStatus, POFromX3);
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            //DateTime GetDate = dateTimePickerTo.Value.Date;
            //String CustomerID = cbo_customerID.Text.Trim();
            //String CheckNumber = txt_CheckNo.Text.Trim();
            //String ARStatus = cbo_ARState.Text.Trim();
            //connSalesOrder.sp_AROPENCLOSE2(grid_AR, GetDate, CheckNumber, CustomerID, ARStatus);
        }

        // Would export the data into a pre-defined layout for printing. Other times, the data would open up on a pre-defined Excel sheet.
        private void btn_export_Click(object sender, EventArgs e)
        {
            String POFromX3 = "";
            if (cbx_x3.Checked)
            {
                POFromX3 = "Checked";
            }
            else
            {
                POFromX3 = "Unchecked";
            }

            DateTime FromDate = dateTimePickerFromDate.Value.Date;
            DateTime AsOfDate = dateTimePickerAsOf.Value.Date;
            String SupplierID = cbo_SupplierID.Text.Trim();
            String CheckNumber = txt_checkNo.Text.Trim();
            String POOpenStatus = cbo_poOpenStatus.Text.Trim();

            Reports.Rpt_PurchaseOrderExceptionReport purchaseOrderExceptionReport = new Reports.Rpt_PurchaseOrderExceptionReport(FromDate, AsOfDate, CheckNumber, SupplierID, POOpenStatus, POFromX3);
            purchaseOrderExceptionReport.Show();

        }

        private void grid_AR_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (grid_AR.Rows[e.RowIndex].Cells["AP Invoice Status"].Value.ToString() == "PAYMENT")
                {
                    String PONumber = grid_AR.Rows[e.RowIndex].Cells["PO Number"].Value.ToString();
                    DateTime FromDate = Convert.ToDateTime(grid_AR.Rows[e.RowIndex].Cells["Goods Receipt Date"].Value.ToString());
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.GetType() == typeof(Reports.PaymentResolution2))
                        {
                            form.Activate();
                            form.WindowState = FormWindowState.Normal;
                            form.BringToFront();
                            return;
                        }
                    }
                    Reports.PaymentResolution2 paymentResolution = new Reports.PaymentResolution2();
                    paymentResolution.txt_searchPONumber.Text = PONumber;
                    paymentResolution.dateTimePickerFrom.Value = FromDate;
                    paymentResolution.btn_search_Click(sender, e);
                    paymentResolution.Show();
                }
                else 
                {
                    MessageBox.Show("The corresponding PO does not yet have a PR.", "PR N/A", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch
            {

            }
        }
    }
}
