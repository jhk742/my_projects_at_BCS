using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.mWMS
{
    public partial class wms_goodsReceipt : Form
    {
        public wms_goodsReceipt()
        {
            InitializeComponent();

            grid_header_Init();
            grid_detail_Init();
            connPO.sp_WMS_GOODSRECEIPT(grid_header);

            


        }

        private void grid_header_Init()
        {
            grid_header.AutoGenerateColumns = false;
            grid_header.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_header.ColumnCount = 5;

            grid_header.Columns[0].Name = "Date";
            grid_header.Columns[0].ReadOnly = true;
            grid_header.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_header.Columns[0].Width = 75;
            grid_header.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_header.Columns[0].DataPropertyName = "CreateTime";

            grid_header.Columns[1].Name = "Order No.";
            grid_header.Columns[1].ReadOnly = true;
            grid_header.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_header.Columns[1].Width = 80;
            grid_header.Columns[1].DataPropertyName = "PONumber";
            
            grid_header.Columns[2].Name = "Order Site";
            grid_header.Columns[2].ReadOnly = true;
            grid_header.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_header.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[2].Width = 40;
            grid_header.Columns[2].DataPropertyName = "ReceivingSite";

            grid_header.Columns[3].Name = "Supplier";
            grid_header.Columns[3].ReadOnly = true;
            grid_header.Columns[3].Width = 150;
            grid_header.Columns[3].DataPropertyName = "SupplierID";

            grid_header.Columns[4].Name = "Memo";
            grid_header.Columns[4].ReadOnly = true;
            grid_header.Columns[4].Width = 150;
            grid_header.Columns[4].DataPropertyName = "PMemo";


            DataGridViewButtonColumn deletePOButton = new DataGridViewButtonColumn();
            deletePOButton.Visible = false;
            deletePOButton.Width = 50;
            deletePOButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deletePOButton.Name = "Delete";
            deletePOButton.Text = "Delete";
            deletePOButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deletePOButton.UseColumnTextForButtonValue = true;
            if (grid_header.Columns["Delete"] == null)

            {
                grid_header.Columns.Insert(5, deletePOButton);
            }

            DataGridViewButtonColumn resetPOButton = new DataGridViewButtonColumn();
            resetPOButton.Visible = false;
            resetPOButton.Width = 50;
            resetPOButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            resetPOButton.Name = "Reset";
            resetPOButton.Text = "Reset";
            resetPOButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            resetPOButton.UseColumnTextForButtonValue = true;
            if (grid_header.Columns["Reset"] == null)

            {
                grid_header.Columns.Insert(6, resetPOButton);
            }

            //grid font size custom
            grid_header.RowTemplate.Height = 20;
            //grid_header.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_header.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_header.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_detail_Init()
        {
            grid_detail.AutoGenerateColumns = false;
            grid_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_detail.ColumnCount = 19;

            grid_detail.Columns[0].Name = "Order";
            grid_detail.Columns[0].ReadOnly = true;
            grid_detail.Columns[0].Width = 70;
            grid_detail.Columns[0].MinimumWidth = 70;
            grid_detail.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[0].DataPropertyName = "PONumber";

            grid_detail.Columns[1].Name = "Product (BCS)";
            grid_detail.Columns[1].ReadOnly = true;
            grid_detail.Columns[1].Width = 70;
            grid_detail.Columns[1].MinimumWidth = 70;
            grid_detail.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[1].DataPropertyName = "ProductID";

            grid_detail.Columns[2].Name = "Description";
            grid_detail.Columns[2].ReadOnly = true;
            grid_detail.Columns[2].Width = 150;
            grid_detail.Columns[2].MinimumWidth = 150;
            grid_detail.Columns[2].DataPropertyName = "ProductDesc";

            grid_detail.Columns[3].Name = "Pack Size";
            grid_detail.Columns[3].ReadOnly = true;
            grid_detail.Columns[3].Width = 70;
            grid_detail.Columns[3].MinimumWidth = 70;
            grid_detail.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[3].DataPropertyName = "PackSize";

            grid_detail.Columns[4].Name = "Unit";
            grid_detail.Columns[4].ReadOnly = true;
            grid_detail.Columns[4].Width = 40;
            grid_detail.Columns[4].MinimumWidth = 40;
            grid_detail.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[4].DataPropertyName = "PurchaseUnit";

            grid_detail.Columns[5].Name = "Qty.";
            grid_detail.Columns[5].Width = 60;
            grid_detail.Columns[5].MinimumWidth = 60;
            grid_detail.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[5].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].DataPropertyName = "ReceivingQty";

            grid_detail.Columns[6].Name = "STK Qty.";
            grid_detail.Columns[6].ReadOnly = true;
            grid_detail.Columns[6].Width = 60;
            grid_detail.Columns[6].MinimumWidth = 60;
            grid_detail.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].DataPropertyName = "StockConversionQty";

            grid_detail.Columns[7].Name = "Gross price";
            grid_detail.Columns[7].ReadOnly = true;
            grid_detail.Columns[7].Width = 60;
            grid_detail.Columns[7].MinimumWidth = 60;
            grid_detail.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[7].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[7].DataPropertyName = "GrossPrice";

            grid_detail.Columns[8].Name = "EDLP";
            grid_detail.Columns[8].Width = 50;
            grid_detail.Columns[8].MinimumWidth = 60;
            grid_detail.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[8].ReadOnly = true;
            grid_detail.Columns[8].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[8].DataPropertyName = "EDLP";

            grid_detail.Columns[9].Name = "EDLP (P)";
            grid_detail.Columns[9].Width = 50;
            grid_detail.Columns[9].MinimumWidth = 50;
            grid_detail.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[9].ReadOnly = true;
            grid_detail.Columns[9].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[9].DataPropertyName = "EDLPP";

            grid_detail.Columns[10].Name = "Term Promo";
            grid_detail.Columns[10].Width = 50;
            grid_detail.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[10].ReadOnly = true;
            grid_detail.Columns[10].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[10].DataPropertyName = "TermPromo";

            grid_detail.Columns[11].Name = "Term Promo (P)";
            grid_detail.Columns[11].Width = 50;
            grid_detail.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[11].ReadOnly = true;
            grid_detail.Columns[11].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[11].DataPropertyName = "TermPromoP";

            grid_detail.Columns[12].Name = "Net Price";
            grid_detail.Columns[12].ReadOnly = true;
            grid_detail.Columns[12].Width = 60;
            grid_detail.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[12].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[12].DataPropertyName = "NetPrice";

            grid_detail.Columns[13].Name = "Order Amount";
            grid_detail.Columns[13].ReadOnly = true;
            grid_detail.Columns[13].Width = 65;
            grid_detail.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[13].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[13].DataPropertyName = "OrderAmount";

            grid_detail.Columns[14].Name = "Expiration Date";
            grid_detail.Columns[14].ReadOnly = false;
            grid_detail.Columns[14].Width = 80;
            grid_detail.Columns[14].MinimumWidth = 80;
            grid_detail.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //grid_detail.Columns[14].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_detail.Columns[14].DataPropertyName = "ReceivingExpireDate";

            grid_detail.Columns[15].Name = "Receiving Site";
            grid_detail.Columns[15].ReadOnly = true;
            //grid_detail.Columns[15].Visible = false;
            grid_detail.Columns[15].Width = 50;
            grid_detail.Columns[15].MinimumWidth = 50;
            grid_detail.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[15].DataPropertyName = "ReceivingSite";

            grid_detail.Columns[16].Name = "ROWID";
            grid_detail.Columns[16].Visible = false;
            grid_detail.Columns[16].Width = 50;
            grid_detail.Columns[16].MinimumWidth = 50;
            grid_detail.Columns[16].DataPropertyName = "ROWID";

            grid_detail.Columns[17].Name = "Item Status";
            //grid_detail.Columns[17].Visible = false;
            grid_detail.Columns[17].Width = 50;
            grid_detail.Columns[17].MinimumWidth = 50;
            grid_detail.Columns[17].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[17].DataPropertyName = "ReceivingStatus";

            grid_detail.Columns[18].Name = "Location";
            grid_detail.Columns[18].Width = 50;
            grid_detail.Columns[18].MinimumWidth = 50;
            grid_detail.Columns[18].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[18].DataPropertyName = "Location";

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

        private void grid_header_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //grid_detail.ClearSelection();

                String PONumber = grid_header.Rows[e.RowIndex].Cells["Order No."].Value.ToString();
                String SupplierID = grid_header.Rows[e.RowIndex].Cells["Supplier"].Value.ToString();
                txt_PONumber.Text = PONumber;
                txt_supplierID.Text = SupplierID;
                //MessageBox.Show(PONumber);

                connPO.sp_WMS_GOODSRECEIPTD(grid_detail, PONumber);
            }
            catch
            {
                //MessageBox.Show("ERROR");
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; grid_detail.RowCount > i; i++)
            {
                if (grid_detail.Rows[i].Cells["Expiration Date"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Input expiration date.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            for (int i = 0; grid_detail.RowCount > i; i++)
            {
                if (grid_detail.Rows[i].Cells["Item Status"].Value.ToString().Trim() == "A" ||
                    grid_detail.Rows[i].Cells["Item Status"].Value.ToString().Trim() == "R" ||
                    grid_detail.Rows[i].Cells["Item Status"].Value.ToString().Trim() == "Q")
                {

                }
                else
                {
                    MessageBox.Show("Input Item Status A, Q or R", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

            }

            DialogResult dialogResult = MessageBox.Show("Are you sure run the receiving process?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //Get a new REC Number from Server 12/24/2018
                String NewRECNumber = connSalesOrder.sp_GET_NewRECNumber();

                //Get a new STK Number from Server 12/24/2018
                String NewSTKNumber = connSalesOrder.sp_GET_NewSTKNumber();
                if (!NewSTKNumber.Contains("STK"))
                {
                    MessageBox.Show("Please try again.(STK) (Error code: " + NewSTKNumber + ")"
                                                    , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                String PONumber = txt_PONumber.Text.Trim();
                //Entities.PORDER pORDER = new Entities.PORDER();
                String ReceivingSite = cbo_site.Text;

                for (int i = 0; i < grid_detail.Rows.Count; i++)
                {
                    String Supplier = txt_supplierID.Text.Trim();
                    String PORDERNumber = grid_detail.Rows[i].Cells["Order"].Value.ToString().Trim(); ;
                    String ProductBCS = grid_detail.Rows[i].Cells["Product (BCS)"].Value.ToString().Trim();
                    //String ProductSupplier = grid_detail.Rows[i].Cells["Product (Supplier)"].Value.ToString();
                    Decimal Qty = Convert.ToDecimal(grid_detail.Rows[i].Cells["Qty."].Value.ToString().Trim());
                    Decimal InnerCase = Convert.ToDecimal(grid_detail.Rows[i].Cells["STK Qty."].Value.ToString().Trim());
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
                    DateTime ExpirationDate = Convert.ToDateTime(grid_detail.Rows[i].Cells["Expiration Date"].Value.ToString().Trim()).Date;
                    ReceivingSite = grid_detail.Rows[i].Cells["Receiving Site"].Value.ToString().Trim();
                    DateTime ReceivingDate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
                    int ROWID = Convert.ToInt32(grid_detail.Rows[i].Cells["ROWID"].Value.ToString().Trim());
                    String Location = grid_detail.Rows[i].Cells["Location"].Value.ToString().Trim();


                    Entities.PORDER pORDER = new Entities.PORDER();

                    pORDER.Supplier = Supplier;

                    pORDER.PORDERNumber = PORDERNumber;
                    pORDER.ProductBCS = ProductBCS;
                    pORDER.Description = Description;
                    pORDER.PackSize = PackSize;
                    pORDER.Unit = Unit;
                    pORDER.OrderQty = Qty;
                    pORDER.Qty = Qty;
                    pORDER.InnerCase = InnerCase;
                    pORDER.GrossPrice = GrossPrice;
                    pORDER.EDLP = EDLP;
                    pORDER.EDLPP = EDLPP;
                    pORDER.TermPromo = TermPromo;
                    pORDER.TermPromoP = TermPromoP;
                    pORDER.NetPrice = NetPrice;
                    pORDER.OrderAmount = OrderAmount;
                    pORDER.GRAmount = OrderAmount;
                    pORDER.ExpirationDate = ExpirationDate;
                    pORDER.ReceivingSite = ReceivingSite;
                    pORDER.Line = i + 1;
                    pORDER.ReceivingDate = ReceivingDate;
                    pORDER.ROWID = ROWID;
                    pORDER.Location = Location;
                    Decimal DiscountAmount = pORDER.Qty * (pORDER.GrossPrice - pORDER.NetPrice);

                    //phy +, INSERT STOCK
                    connPO.sp_INSERT_PRECEIPTD(pORDER, NewRECNumber);

                    //저널Detail
                    connPO.sp_PPAYMENT_JOU_RECEIVINGD(pORDER, NewRECNumber, NewSTKNumber);
                    //50010(-1), 15100(1)
                    connPO.sp_PPAYMENT_JOU_RECEIVINGD_DISCOUNT(pORDER, NewRECNumber, NewSTKNumber, DiscountAmount);

                }
                String SupplierID = txt_supplierID.Text;

                //site reset
                String ReceiptMemo = txt_memo.Text;
                //저널H
                connPO.sp_PPAYMENT_JOU_RECEIVING(ReceivingSite, NewRECNumber, NewSTKNumber);
                connPO.sp_CREATE_PRECEIPT(SupplierID, ReceiptMemo, ReceivingSite, PONumber, NewRECNumber);

                connPO.sp_WMS_GOODSRECEIPT_COMPLETE(PONumber);
                
                grid_detail.DataSource = null;
                txt_supplierID.Text = "";
                txt_memo.Text = "";
                txt_PONumber.Text = "";

                connPO.sp_WMS_GOODSRECEIPT(grid_header);

                MessageBox.Show("PO Receiving " + NewRECNumber + " successfully saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private string format;
        private void grid_detail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string QtyString = grid_detail.CurrentRow.Cells["Qty."].Value.ToString();
                double qty = Convert.ToDouble(QtyString);

                string GrossPriceString = grid_detail.CurrentRow.Cells["Gross Price"].Value.ToString();
                double GrossPrice = Convert.ToDouble(GrossPriceString);

                string EDLPString = grid_detail.CurrentRow.Cells["EDLP"].Value.ToString();
                double EDLP = Convert.ToDouble(EDLPString);

                string EDLPPString = grid_detail.CurrentRow.Cells["EDLP (P)"].Value.ToString();
                double EDLPP = Convert.ToDouble(EDLPPString);

                string TermPromoString = grid_detail.CurrentRow.Cells["Term Promo"].Value.ToString();
                double TermPromo = Convert.ToDouble(TermPromoString);

                string TermPromoPString = grid_detail.CurrentRow.Cells["Term Promo (P)"].Value.ToString();
                double TermPromoP = Convert.ToDouble(TermPromoPString);

                double netPrice = 0;

                double dEDLPP = 0;

                double dTermPromoP = 0;

                dEDLPP = EDLPP * 0.01 * GrossPrice;
                dTermPromoP = TermPromoP * 0.01 * GrossPrice;


                netPrice = GrossPrice - EDLP - dEDLPP - TermPromo - dTermPromoP;
                double orderAmount = 0;

                if (netPrice < 0)
                {
                    MessageBox.Show("Check the input values", "Info(1)", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    grid_detail.CurrentRow.Cells["EDLP"].Value = "0";
                    grid_detail.CurrentRow.Cells["EDLP (P)"].Value = "0";
                    grid_detail.CurrentRow.Cells["Term Promo"].Value = "0";
                    grid_detail.CurrentRow.Cells["Term Promo (P)"].Value = "0";
                    grid_detail.CurrentRow.Cells["Net Price"].Value = (Convert.ToDecimal(grid_detail.CurrentRow.Cells["Gross Price"].Value)).ToString();
                    netPrice = Convert.ToDouble(grid_detail.CurrentRow.Cells["Net Price"].Value);
                    orderAmount = netPrice * qty;
                    grid_detail.CurrentRow.Cells["Order Amount"].Value = orderAmount.ToString();

                    return;
                }


                orderAmount = netPrice * qty;
                grid_detail.CurrentRow.Cells["Net Price"].Value = netPrice.ToString();
                grid_detail.CurrentRow.Cells["Order Amount"].Value = orderAmount.ToString();

                //dateTimePickerExpirationDate.Visible = false;

                try
                {
                    CultureInfo provider = CultureInfo.InvariantCulture;
                    string dateString = grid_detail.CurrentRow.Cells["Expiration Date"].Value.ToString().Trim();

                    if (dateString.Length == 6)
                    {
                        format = "MMddyy";
                    }
                    else if (dateString.Length == 8)
                    {
                        format = "MMddyyyy";
                    }
                    else if (dateString.Length == 10)
                    {
                        format = "MM/dd/yyyy";
                    }
                    DateTime result = DateTime.ParseExact(dateString, format, provider);
                    grid_detail.CurrentRow.Cells["Expiration Date"].Value = result.ToString("MM/dd/yyyy");
                    //MessageBox.Show(grid_detail.CurrentRow.Cells["Expiration Date"].Value.ToString().Trim());


                }
                catch
                {
                    grid_detail.CurrentRow.Cells["Expiration Date"].Value = "";
                }

            }
            catch
            {
                MessageBox.Show("Check the input values", "Info(2)", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
