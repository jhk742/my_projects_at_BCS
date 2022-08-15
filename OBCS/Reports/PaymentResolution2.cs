using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using OBCS.Entities;

namespace OBCS.Reports
{
    public partial class PaymentResolution2 : Form
    {
        public PaymentResolution2()
        {
            InitializeComponent();

            grid_invoice_Init();

            cbo_searchSupplierID.Items.Clear();
            connPO.cbox_getVendorID(cbo_searchSupplierID);

            dateTimePickerFrom.Value = DateTime.Today.AddMonths(-3);
        }

        private void PaymentResolution2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PaymentResolution.sp_PaymentResolution' table. You can move, or remove it, as needed.
            //this.sp_PaymentResolutionTableAdapter.Fill(this.PaymentResolution.sp_PaymentResolution, "");

            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }

        private void grid_invoice_Init()
        {
            grid_invoice.AutoGenerateColumns = false;
            grid_invoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_invoice.ColumnCount = 33;

            grid_invoice.Columns[0].Name = "Accounting Date";
            grid_invoice.Columns[0].ReadOnly = true;
            grid_invoice.Columns[0].Width = 80;
            grid_invoice.Columns[0].MinimumWidth = 80;
            grid_invoice.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_invoice.Columns[0].DataPropertyName = "ACCDAT_0";

            grid_invoice.Columns[1].Name = "Company";
            grid_invoice.Columns[1].ReadOnly = true;
            grid_invoice.Columns[1].Width = 80;
            grid_invoice.Columns[1].MinimumWidth = 80;
            grid_invoice.Columns[1].DataPropertyName = "";

            grid_invoice.Columns[2].Name = "Site";
            grid_invoice.Columns[2].ReadOnly = true;
            grid_invoice.Columns[2].Width = 40;
            grid_invoice.Columns[2].MinimumWidth = 40;
            grid_invoice.Columns[2].DataPropertyName = "FCY_0";

            grid_invoice.Columns[3].Name = "Supplier ID";
            grid_invoice.Columns[3].ReadOnly = true;
            grid_invoice.Columns[3].Width = 120;
            grid_invoice.Columns[3].MinimumWidth = 120;
            grid_invoice.Columns[3].DataPropertyName = "BPR_0";

            grid_invoice.Columns[4].Name = "Supplier Name";
            grid_invoice.Columns[4].ReadOnly = true;
            grid_invoice.Columns[4].Width = 120;
            grid_invoice.Columns[4].MinimumWidth = 120;
            grid_invoice.Columns[4].DataPropertyName = "BPRNAM_0";

            grid_invoice.Columns[5].Name = "PO Number";
            grid_invoice.Columns[5].ReadOnly = true;
            grid_invoice.Columns[5].Width = 80;
            grid_invoice.Columns[5].MinimumWidth = 80;
            grid_invoice.Columns[5].DataPropertyName = "POHNUM_0";

            grid_invoice.Columns[6].Name = "REC Number";
            grid_invoice.Columns[6].ReadOnly = true;
            grid_invoice.Columns[6].Width = 80;
            grid_invoice.Columns[6].MinimumWidth = 80;
            grid_invoice.Columns[6].DataPropertyName = "ORIDOCNUM_0";

            grid_invoice.Columns[7].Name = "Invoice Number";
            grid_invoice.Columns[7].ReadOnly = true;
            grid_invoice.Columns[7].Width = 80;
            grid_invoice.Columns[7].MinimumWidth = 80;
            grid_invoice.Columns[7].DataPropertyName = "NUM_0";

            grid_invoice.Columns[8].Name = "Supplier Doc. Number";
            grid_invoice.Columns[8].ReadOnly = true;
            grid_invoice.Columns[8].Width = 160;
            grid_invoice.Columns[8].MinimumWidth = 80;
            grid_invoice.Columns[8].DataPropertyName = "INVREF_0";

            grid_invoice.Columns[9].Name = "Status";
            grid_invoice.Columns[9].Visible = false;
            grid_invoice.Columns[9].ReadOnly = true;
            grid_invoice.Columns[9].Width = 160;
            grid_invoice.Columns[9].MinimumWidth = 80;
            grid_invoice.Columns[9].DataPropertyName = "";

            //===================================================

            grid_invoice.Columns[10].Name = "Create Date";
            grid_invoice.Columns[10].Visible = false;
            grid_invoice.Columns[10].Width = 80;
            grid_invoice.Columns[10].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_invoice.Columns[10].DataPropertyName = "CREDATTIM_0";//"ACCDAT_0";

            grid_invoice.Columns[11].Name = "Supplier Doc. Amount";
            grid_invoice.Columns[11].Visible = false;
            grid_invoice.Columns[11].Width = 120;
            grid_invoice.Columns[11].DataPropertyName = "SupplierDocAmount";

            grid_invoice.Columns[12].Name = "REC Net Amount";
            grid_invoice.Columns[12].Visible = false;
            grid_invoice.Columns[12].Width = 120;
            grid_invoice.Columns[12].DataPropertyName = "ReceiptAmount";

            grid_invoice.Columns[13].Name = "Diff";
            grid_invoice.Columns[13].Visible = false;
            grid_invoice.Columns[13].Width = 120;
            grid_invoice.Columns[13].DataPropertyName = "Diff";

            grid_invoice.Columns[14].Name = "Cost";
            grid_invoice.Columns[14].Visible = false;
            grid_invoice.Columns[14].Width = 120;
            grid_invoice.Columns[14].DataPropertyName = "Cost";

            grid_invoice.Columns[15].Name = "Invoice Amount";
            grid_invoice.Columns[15].Visible = false;
            grid_invoice.Columns[15].Width = 120;
            grid_invoice.Columns[15].DataPropertyName = "InvoiceAmount";

            grid_invoice.Columns[16].Name = "PO Issue Date";
            grid_invoice.Columns[16].Visible = false;
            grid_invoice.Columns[16].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_invoice.Columns[16].DataPropertyName = "POIssueDate";

            grid_invoice.Columns[17].Name = "POIssueDate";
            grid_invoice.Columns[17].Visible = false;
            grid_invoice.Columns[17].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_invoice.Columns[17].DataPropertyName = "ORDDAT_0";

            grid_invoice.Columns[18].Name = "PO Gross Amount";
            grid_invoice.Columns[18].Visible = false;
            grid_invoice.Columns[18].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[18].DataPropertyName = "TotalPOGrossAmount";

            grid_invoice.Columns[19].Name = "PO EDLP";
            grid_invoice.Columns[19].Visible = false;
            grid_invoice.Columns[19].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[19].DataPropertyName = "POEDLP";

            grid_invoice.Columns[20].Name = "PO Term Promotion";
            grid_invoice.Columns[20].Visible = false;
            grid_invoice.Columns[20].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[20].DataPropertyName = "POTermPromo";

            grid_invoice.Columns[21].Name = "PO Net Amount";
            grid_invoice.Columns[21].Visible = false;
            grid_invoice.Columns[21].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[21].DataPropertyName = "TotalPOAmount";

            grid_invoice.Columns[22].Name = "REC Gross Amount";
            grid_invoice.Columns[22].Visible = false;
            grid_invoice.Columns[22].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[22].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[22].DataPropertyName = "TotalRECGrossAmount";

            grid_invoice.Columns[23].Name = "REC EDLP";
            grid_invoice.Columns[23].Visible = false;
            grid_invoice.Columns[23].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[23].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[23].DataPropertyName = "RECEDLP";

            grid_invoice.Columns[24].Name = "REC Term Promotion";
            grid_invoice.Columns[24].Visible = false;
            grid_invoice.Columns[24].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[24].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[24].DataPropertyName = "RECTermPromo";

            grid_invoice.Columns[25].Name = "REC Net Amount";
            grid_invoice.Columns[25].Visible = false;
            grid_invoice.Columns[25].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[25].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[25].DataPropertyName = "TotalRECAmount";

            grid_invoice.Columns[26].Name = "Payment Term";
            grid_invoice.Columns[26].Visible = false;
            grid_invoice.Columns[26].DataPropertyName = "PaymentTerm";

            grid_invoice.Columns[27].Name = "PO Memo";
            grid_invoice.Columns[27].Visible = false;
            grid_invoice.Columns[27].DataPropertyName = "POMemo";

            grid_invoice.Columns[28].Name = "REC Memo";
            grid_invoice.Columns[28].Visible = false;
            grid_invoice.Columns[28].DataPropertyName = "RECMemo";

            grid_invoice.Columns[29].Name = "Invoice Memo";
            grid_invoice.Columns[29].Visible = false;
            grid_invoice.Columns[29].DataPropertyName = "InvoiceMemo";

            grid_invoice.Columns[30].Name = "Discount Amount";
            grid_invoice.Columns[30].Visible = false;
            grid_invoice.Columns[30].DataPropertyName = "DiscountAmount";

            grid_invoice.Columns[31].Name = "Discount Due Date";
            grid_invoice.Columns[31].Visible = false;
            grid_invoice.Columns[31].DataPropertyName = "DiscountDueDate";

            grid_invoice.Columns[32].Name = "Payment Due Date";
            grid_invoice.Columns[32].Visible = false;
            grid_invoice.Columns[32].DataPropertyName = "PaymentDueDate";

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

        public void btn_search_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            String SearchSupplierID = cbo_searchSupplierID.Text.Trim();
            String SearchPONumber = txt_searchPONumber.Text.Trim();
            String SearchSupplierInvoiceNumber = txt_searchSupplierInvoiceNumber.Text.Trim();

            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;

            connPO.sp_PINVOICE_HEADER(grid_invoice, SearchSupplierID, SearchSupplierInvoiceNumber, SearchPONumber, FromDate, ToDate);
        }

        public string SelectedInvoiceNumber = "";
        public DataGridViewCellEventArgs selectedDataGridViewCellEventArgs;
        public object selectedSender;
        public void grid_invoice_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedDataGridViewCellEventArgs = e;
                selectedSender = sender;
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                String SupplierCode = grid_invoice.Rows[e.RowIndex].Cells["Supplier ID"].Value.ToString();
                String SupplierName = grid_invoice.Rows[e.RowIndex].Cells["Supplier Name"].Value.ToString();

                String PONumber = grid_invoice.Rows[e.RowIndex].Cells["PO Number"].Value.ToString();
                String POIssueDate;
                String POGrossAmount;
                String POEDLP;
                String POTermPromotion;
                String PONetAmount;

                if (PONumber.Contains("BCSSC"))
                {
                    POIssueDate = "";
                    POGrossAmount = "";
                    POEDLP = "";
                    POTermPromotion = "";
                    PONetAmount = "";
                }
                else
                {
                    POIssueDate = Convert.ToDateTime(grid_invoice.Rows[e.RowIndex].Cells["PO Issue Date"].Value).ToShortDateString();
                    POGrossAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["PO Gross Amount"].Value.ToString()).ToString("N2");
                    POEDLP = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["PO EDLP"].Value.ToString()).ToString("N2");
                    POTermPromotion = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["PO Term Promotion"].Value.ToString()).ToString("N2");
                    PONetAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["PO Net Amount"].Value.ToString()).ToString("N2");
                }

                String ReceiptDate = Convert.ToDateTime(grid_invoice.Rows[e.RowIndex].Cells["Accounting Date"].Value).ToShortDateString();
                String RECNumber = grid_invoice.Rows[e.RowIndex].Cells["REC Number"].Value.ToString();
                String RECGrossAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["REC Gross Amount"].Value.ToString()).ToString("N2");
                String RECEDLP = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["REC EDLP"].Value.ToString()).ToString("N2");
                String RECTermPromotion = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["REC Term Promotion"].Value.ToString()).ToString("N2");
                String RECNetAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["REC Net Amount"].Value.ToString()).ToString("N2");

                String InvoiceDate = Convert.ToDateTime(grid_invoice.Rows[e.RowIndex].Cells["Accounting Date"].Value).ToShortDateString();
                String InvoiceNumber = grid_invoice.Rows[e.RowIndex].Cells["Invoice Number"].Value.ToString();
                SelectedInvoiceNumber = InvoiceNumber;
                String SupplierDocNumber = grid_invoice.Rows[e.RowIndex].Cells["Supplier Doc. Number"].Value.ToString();
                String APAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["REC Net Amount"].Value.ToString()).ToString("N2");
                String SupplierDocAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["Supplier Doc. Amount"].Value.ToString()).ToString("N2");

                String PaymentTerm = grid_invoice.Rows[e.RowIndex].Cells["Payment Term"].Value.ToString();
                String DiscountAmount = Convert.ToDecimal(grid_invoice.Rows[e.RowIndex].Cells["Discount Amount"].Value.ToString()).ToString("N2");
                String DiscountDueDate = grid_invoice.Rows[e.RowIndex].Cells["Discount Due Date"].Value.ToString();
                String PaymentDueDate = grid_invoice.Rows[e.RowIndex].Cells["Payment Due Date"].Value.ToString();
                //String DiscountAmount = Convert.ToDecimal("0").ToString("N2");

                String POMemo = grid_invoice.Rows[e.RowIndex].Cells["PO Memo"].Value.ToString();
                String RECMemo = grid_invoice.Rows[e.RowIndex].Cells["REC Memo"].Value.ToString();
                String InvoiceMemo = grid_invoice.Rows[e.RowIndex].Cells["Invoice Memo"].Value.ToString();

                //String  = grid_invoice.Rows[e.RowIndex].Cells[""].Value.ToString();

                reportParameters.Add(new ReportParameter("SupplierCode", SupplierCode));
                reportParameters.Add(new ReportParameter("SupplierName", SupplierName));

                reportParameters.Add(new ReportParameter("POIssueDate", POIssueDate));
                reportParameters.Add(new ReportParameter("PONumber", PONumber));
                reportParameters.Add(new ReportParameter("POGrossAmount", POGrossAmount));
                reportParameters.Add(new ReportParameter("POEDLP", POEDLP));
                reportParameters.Add(new ReportParameter("POTermPromotion", POTermPromotion));
                reportParameters.Add(new ReportParameter("PONetAmount", PONetAmount));

                reportParameters.Add(new ReportParameter("ReceiptDate", ReceiptDate));
                reportParameters.Add(new ReportParameter("RECNumber", RECNumber));
                reportParameters.Add(new ReportParameter("RECGrossAmount", RECGrossAmount));
                reportParameters.Add(new ReportParameter("RECEDLP", RECEDLP));
                reportParameters.Add(new ReportParameter("RECTermPromotion", RECTermPromotion));
                reportParameters.Add(new ReportParameter("RECNetAmount", RECNetAmount));

                reportParameters.Add(new ReportParameter("InvoiceDate", InvoiceDate));
                reportParameters.Add(new ReportParameter("InvoiceNumber", InvoiceNumber));
                reportParameters.Add(new ReportParameter("SupplierDocNumber", SupplierDocNumber));
                reportParameters.Add(new ReportParameter("APAmount", APAmount));
                reportParameters.Add(new ReportParameter("SupplierDocAmount", SupplierDocAmount));


                reportParameters.Add(new ReportParameter("POMemo", POMemo));
                reportParameters.Add(new ReportParameter("RECMemo", RECMemo));
                reportParameters.Add(new ReportParameter("InvoiceMemo", InvoiceMemo));
                //reportParameters.Add(new ReportParameter("", ));

                PaymentResolutionObject paymentResolution = new PaymentResolutionObject();
                //po
                paymentResolution = connPO.sp_PaymentResolution_Detail(InvoiceNumber);

                //debit note
                //PaymentResolutionDebitNote paymentResolutionDebitnote = new PaymentResolutionDebitNote()


                reportParameters.Add(new ReportParameter("AD", paymentResolution.AD.ToString("N2")));
                reportParameters.Add(new ReportParameter("PR", paymentResolution.PR.ToString("N2")));
                reportParameters.Add(new ReportParameter("EDLP", paymentResolution.EDLP.ToString("N2")));
                reportParameters.Add(new ReportParameter("BB", paymentResolution.BB.ToString("N2")));
                reportParameters.Add(new ReportParameter("MD", paymentResolution.MD.ToString("N2")));
                reportParameters.Add(new ReportParameter("CR", paymentResolution.CR.ToString("N2")));
                reportParameters.Add(new ReportParameter("D", paymentResolution.D.ToString("N2")));
                reportParameters.Add(new ReportParameter("DMC", paymentResolution.DMC.ToString("N2")));
                reportParameters.Add(new ReportParameter("R", paymentResolution.R.ToString("N2")));
                reportParameters.Add(new ReportParameter("RST", paymentResolution.RST.ToString("N2")));
                reportParameters.Add(new ReportParameter("ST", paymentResolution.ST.ToString("N2")));
                reportParameters.Add(new ReportParameter("DA", paymentResolution.DA.ToString("N2")));
                reportParameters.Add(new ReportParameter("SD", paymentResolution.SD.ToString("N2")));
                reportParameters.Add(new ReportParameter("SP", paymentResolution.SP.ToString("N2")));
                reportParameters.Add(new ReportParameter("TC", paymentResolution.TC.ToString("N2")));
                reportParameters.Add(new ReportParameter("DOH", paymentResolution.DOH.ToString("N2")));
                reportParameters.Add(new ReportParameter("MISC", paymentResolution.MISC.ToString("N2")));

                reportParameters.Add(new ReportParameter("AD_m", paymentResolution.AD_m));
                reportParameters.Add(new ReportParameter("PR_m", paymentResolution.PR_m));
                reportParameters.Add(new ReportParameter("EDLP_m", paymentResolution.EDLP_m));
                reportParameters.Add(new ReportParameter("BB_m", paymentResolution.BB_m));
                reportParameters.Add(new ReportParameter("MD_m", paymentResolution.MD_m));
                reportParameters.Add(new ReportParameter("CR_m", paymentResolution.CR_m));
                reportParameters.Add(new ReportParameter("D_m", paymentResolution.D_m));
                reportParameters.Add(new ReportParameter("DMC_m", paymentResolution.DMC_m));
                reportParameters.Add(new ReportParameter("R_m", paymentResolution.R_m));
                reportParameters.Add(new ReportParameter("RST_m", paymentResolution.RST_m));
                reportParameters.Add(new ReportParameter("DA_m", paymentResolution.DA_m));
                reportParameters.Add(new ReportParameter("ST_m", paymentResolution.ST_m));
                reportParameters.Add(new ReportParameter("SD_m", paymentResolution.SD_m));
                reportParameters.Add(new ReportParameter("SP_m", paymentResolution.SP_m));
                reportParameters.Add(new ReportParameter("TC_m", paymentResolution.TC_m));
                reportParameters.Add(new ReportParameter("DOH_m", paymentResolution.DOH_m));
                reportParameters.Add(new ReportParameter("MISC_m", paymentResolution.MISC_m));

                reportParameters.Add(new ReportParameter("PaymentTerm", PaymentTerm));
                reportParameters.Add(new ReportParameter("DiscountAmount", DiscountAmount));
                reportParameters.Add(new ReportParameter("DiscountDueDate", DiscountDueDate));
                reportParameters.Add(new ReportParameter("PaymentDueDate", PaymentDueDate));

                this.reportViewer1.LocalReport.SetParameters(reportParameters);

                this.sp_PaymentResolutionTableAdapter.Fill(this.PaymentResolution.sp_PaymentResolution, "");

                this.reportViewer1.RefreshReport();

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch { }


            //=================================================================================================
            /*
            reportViewer2.LocalReport.ReportPath = "Reports/PaymentResolution.rdlc";
            reportViewer2.LocalReport.DataSources.Clear();

            ReportDataSource rds1 = new ReportDataSource();
            rds1.Name = "PaymentResolution";
            rds1.Value = paymentResolution;
            reportViewer2.LocalReport.DataSources.Add(rds1);
            reportViewer2.LocalReport.Refresh();

            //this.reportViewer2.RefreshReport();

            reportViewer2.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer2.ZoomMode = ZoomMode.Percent;
            reportViewer2.ZoomPercent = 100;
            */

        }

        private void txt_searchPONumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                refresh();
            }
        }

        private void txt_searchSupplierInvoiceNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                refresh();
            }
        }
        //
    }
}
