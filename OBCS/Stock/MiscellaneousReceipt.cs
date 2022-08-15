using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Stock
{
    public partial class MiscellaneousReceipt : Form
    {
        public MiscellaneousReceipt()
        {
            InitializeComponent();
            grid_header_Init();
            grid_Detail_Init();
            grid_stock_Init();

            dateTimePickerFrom.Value = DateTime.Now.AddDays(-7);
            dateTimePickerExpired.Value = DateTime.Now.AddYears(1);
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            connSalesOrder.sp_Miscellaneous_Receipt_Select(grid_header, FromDate, ToDate);
            connSalesOrder.cbo_AllProduct(cbo_product);
            connSalesOrder.cbo_STKReasonCode("MR", cbo_MemoCode);
            //connSalesOrder.cbo_SiteFromSTOJOU(cbo_storageSite);
            cbo_storageSite.Items.Add("BCS");
            cbo_storageSite.Items.Add("WH2");
            cbo_Company.Items.Add("B.C.S.INTERNATIONAL CORP.");
            cbo_storageSite.SelectedItem = "BCS";
            cbo_Company.SelectedItem = "B.C.S.INTERNATIONAL CORP.";
            cbo_Status.Items.Add("A");
            cbo_Status.Items.Add("Q");
            cbo_Status.Items.Add("R");
        }

        private void grid_header_Init()
        {
            grid_header.AutoGenerateColumns = false;
            grid_header.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_header.ColumnCount = 9;

            grid_header.Columns[0].Name = "Site";
            grid_header.Columns[0].ReadOnly = true;
            grid_header.Columns[0].Width = 20;
            grid_header.Columns[0].MinimumWidth = 20;
            grid_header.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[0].DataPropertyName = "FCY_0";

            grid_header.Columns[1].Name = "No.";
            grid_header.Columns[1].ReadOnly = true;
            grid_header.Columns[1].Width = 50;
            grid_header.Columns[1].MinimumWidth = 50;
            grid_header.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[1].DataPropertyName = "MrcNumber";

            grid_header.Columns[2].Name = "AccDate";
            grid_header.Columns[2].ReadOnly = true;
            grid_header.Columns[2].Width = 45;
            grid_header.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_header.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[2].DataPropertyName = "ACCDAT_0";

            grid_header.Columns[3].Name = "Reference";
            grid_header.Columns[3].ReadOnly = true;
            grid_header.Columns[3].Visible = false;
            grid_header.Columns[3].Width = 80;
            grid_header.Columns[3].MinimumWidth = 80;
            grid_header.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[3].DataPropertyName = "Reference";

            grid_header.Columns[4].Name = "Code";
            grid_header.Columns[4].ReadOnly = true;
            grid_header.Columns[4].Width = 25;
            grid_header.Columns[4].MinimumWidth = 25;
            grid_header.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[4].DataPropertyName = "TypeCode";

            grid_header.Columns[5].Name = "TypeName";
            grid_header.Columns[5].ReadOnly = true;
            grid_header.Columns[5].Width = 100;
            grid_header.Columns[5].MinimumWidth = 100;
            grid_header.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[5].DataPropertyName = "TypeName";

            grid_header.Columns[6].Name = "Memo";
            grid_header.Columns[6].ReadOnly = true;
            grid_header.Columns[6].Width = 100;
            grid_header.Columns[6].MinimumWidth = 100;
            grid_header.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[6].DataPropertyName = "Memo";

            grid_header.Columns[7].Name = "User";
            grid_header.Columns[7].ReadOnly = true;
            grid_header.Columns[7].Width = 30;
            grid_header.Columns[7].MinimumWidth = 30;
            grid_header.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[7].DataPropertyName = "UPDUSER";

            grid_header.Columns[8].Name = "UPDDATTIM_0";
            grid_header.Columns[8].ReadOnly = true;
            grid_header.Columns[8].Width = 60;
            grid_header.Columns[8].Visible = false;
            grid_header.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_header.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[8].DataPropertyName = "UPDDATTIM_0";


            //grid font size custom
            grid_header.RowTemplate.Height = 20;
            grid_header.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_header.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_header.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void grid_Detail_Init()
        {
            grid_Detail.AutoGenerateColumns = false;
            grid_Detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Detail.ColumnCount = 12;

            grid_Detail.Columns[0].Name = "Site";
            grid_Detail.Columns[0].ReadOnly = true;
            grid_Detail.Columns[0].Visible = false;
            grid_Detail.Columns[0].Width = 30;
            grid_Detail.Columns[0].MinimumWidth = 30;
            grid_Detail.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[0].DataPropertyName = "STOFCY_0";

            grid_Detail.Columns[1].Name = "ITEM ID";
            grid_Detail.Columns[1].ReadOnly = true;
            grid_Detail.Columns[1].Width = 60;
            grid_Detail.Columns[1].MinimumWidth = 60;
            grid_Detail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[1].DataPropertyName = "ITMREF_0";

            grid_Detail.Columns[2].Name = "LOT";
            grid_Detail.Columns[2].ReadOnly = true;
            grid_Detail.Columns[2].Width = 60;
            grid_Detail.Columns[2].MinimumWidth = 60;
            grid_Detail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[2].DataPropertyName = "LOT_0";

            grid_Detail.Columns[3].Name = "VCRNUM_0";
            grid_Detail.Columns[3].ReadOnly = true;
            grid_Detail.Columns[3].Width = 60;
            grid_Detail.Columns[3].Visible = false;
            grid_Detail.Columns[3].MinimumWidth = 60;
            grid_Detail.Columns[3].DataPropertyName = "VCRNUM_0";

            grid_Detail.Columns[4].Name = "VCRNUMREG_0";
            grid_Detail.Columns[4].ReadOnly = true;
            grid_Detail.Columns[4].Width = 60;
            grid_Detail.Columns[4].Visible = false;
            grid_Detail.Columns[4].MinimumWidth = 60;
            grid_Detail.Columns[4].DataPropertyName = "VCRNUMREG_0";

            grid_Detail.Columns[5].Name = "Status";
            grid_Detail.Columns[5].ReadOnly = true;
            grid_Detail.Columns[5].Width = 20;
            grid_Detail.Columns[5].MinimumWidth = 20;
            grid_Detail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[5].DataPropertyName = "STA_0";

            grid_Detail.Columns[6].Name = "QTY";
            grid_Detail.Columns[6].ReadOnly = true;
            grid_Detail.Columns[6].Width = 40;
            grid_Detail.Columns[6].MinimumWidth = 40;
            grid_Detail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_Detail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Detail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[6].DataPropertyName = "QTYPCU_0";

            grid_Detail.Columns[7].Name = "AMOUNT";
            grid_Detail.Columns[7].ReadOnly = true;
            grid_Detail.Columns[7].Width = 50;
            grid_Detail.Columns[7].MinimumWidth = 50;
            grid_Detail.Columns[7].DefaultCellStyle.Format = "N2";
            grid_Detail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Detail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[7].DataPropertyName = "AMTORD_0";

            grid_Detail.Columns[8].Name = "CREUSR_0";
            grid_Detail.Columns[8].ReadOnly = true;
            grid_Detail.Columns[8].Width = 60;
            grid_Detail.Columns[8].MinimumWidth = 60;
            grid_Detail.Columns[8].Visible = false;
            grid_Detail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[8].DataPropertyName = "CREUSR_0";

            grid_Detail.Columns[9].Name = "CREDAT_0";
            grid_Detail.Columns[9].ReadOnly = true;
            grid_Detail.Columns[9].Width = 40;
            grid_Detail.Columns[9].Visible = false;
            grid_Detail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[9].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_Detail.Columns[9].DataPropertyName = "CREDAT_0";

            grid_Detail.Columns[10].Name = "UPDDAT_0";
            grid_Detail.Columns[10].ReadOnly = true;
            grid_Detail.Columns[10].Width = 40;
            grid_Detail.Columns[10].Visible = false;
            grid_Detail.Columns[10].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_Detail.Columns[10].DataPropertyName = "UPDDAT_0";

            grid_Detail.Columns[11].Name = "ACCDAT_0";
            grid_Detail.Columns[11].ReadOnly = true;
            grid_Detail.Columns[11].Width = 40;
            grid_Detail.Columns[11].Visible = false;
            grid_Detail.Columns[11].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_Detail.Columns[11].DataPropertyName = "ACCDAT_0";


            //grid font size custom
            grid_Detail.RowTemplate.Height = 20;
            grid_Detail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_Detail.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_Detail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void grid_stock_Init()
        {
            grid_stock.AutoGenerateColumns = false;
            grid_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_stock.ColumnCount = 9;

            grid_stock.Columns[0].Name = "Site";
            grid_stock.Columns[0].ReadOnly = true;
            grid_stock.Columns[0].Width = 20;
            grid_stock.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[0].DataPropertyName = "STOFCY_0";

            grid_stock.Columns[1].Name = "Product";
            grid_stock.Columns[1].ReadOnly = true;
            grid_stock.Columns[1].Width = 60;
            grid_stock.Columns[1].MinimumWidth = 60;
            grid_stock.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[1].DataPropertyName = "ITMREF_0";

            grid_stock.Columns[2].Name = "LOT";
            grid_stock.Columns[2].ReadOnly = true;
            grid_stock.Columns[2].Width = 70;
            grid_stock.Columns[2].MinimumWidth = 70;
            grid_stock.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[2].DataPropertyName = "LOT_0";

            grid_stock.Columns[3].Name = "Status";
            grid_stock.Columns[3].ReadOnly = true;
            grid_stock.Columns[3].Width = 30;
            grid_stock.Columns[3].MinimumWidth = 30;
            grid_stock.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[3].DataPropertyName = "STA_0";

            grid_stock.Columns[4].Name = "Available";
            grid_stock.Columns[4].ReadOnly = true;
            grid_stock.Columns[4].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[4].Width = 40;
            grid_stock.Columns[4].DataPropertyName = "AvailableQty";

            grid_stock.Columns[5].Name = "Allocated";
            grid_stock.Columns[5].ReadOnly = true;
            grid_stock.Columns[5].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[5].Width = 40;
            grid_stock.Columns[5].DataPropertyName = "Allocated";

            grid_stock.Columns[6].Name = "Expiration";
            grid_stock.Columns[6].ReadOnly = true;
            grid_stock.Columns[6].Width = 60;
            grid_stock.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_stock.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[6].DataPropertyName = "Expiration";

            grid_stock.Columns[7].Name = "UPDUSER";
            grid_stock.Columns[7].ReadOnly = true;
            grid_stock.Columns[7].Width = 30;
            grid_stock.Columns[7].MinimumWidth = 30;
            grid_stock.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[7].DataPropertyName = "UPDUSER";

            grid_stock.Columns[8].Name = "UPDDATETIME";
            grid_stock.Columns[8].ReadOnly = true;
            grid_stock.Columns[8].Width = 120;
            grid_stock.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_stock.Columns[10].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_stock.Columns[8].DataPropertyName = "UPDDATTIM_0";

            //grid font size custom
            grid_stock.RowTemplate.Height = 20;
            grid_stock.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_stock.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            grid_stock.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        
        private void grid_header_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String MrcNumber = grid_header.Rows[e.RowIndex].Cells["No."].Value.ToString();
                connSalesOrder.sp_Miscellaneous_Receipt_Select_Detail(grid_Detail, MrcNumber);
            }
            catch { }
        }

        private void cbo_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String ItemID = cbo_product.Text.Trim();
                if (connSalesOrder.getProductKeyFromItemID(ItemID) == "")
                {
                    //응~ 데이터베이스에 없엉~~
                    //ㅃㅃㅇ~~
                }
                else
                    LotInformationByProductID();
            }
        }

        private void cbo_product_SelectedValueChanged(object sender, EventArgs e)
        {
            LotInformationByProductID();
        }
        private void cbo_storageSite_SelectedValueChanged(object sender, EventArgs e)
        {
            LotInformationByProductID();
        }

        private void cbo_storageSite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LotInformationByProductID();
            }
        }
        private void LotInformationByProductID()
        {
            try
            {
                String ItemID = cbo_product.Text.Trim();
                String StorageSite = cbo_storageSite.Text.Trim();
                String Company = cbo_Company.Text.ToString();

                txt_ProductDesc.Text = connSalesOrder.getItemDescFromItemID(ItemID);
                txt_globalAllocated.Text = connSalesOrder.sp_STOCKCHANGE_GLOBAL(ItemID);

                connSalesOrder.sp_Miscellaneous_Stock_Select(grid_stock, ItemID, Company, StorageSite);

                Decimal CheckedTotalStockQty = 0;
                for (int i = 0; i < grid_stock.RowCount; i++)
                {
                    Decimal AvailableQty = Convert.ToDecimal(grid_stock.Rows[i].Cells["Available"].Value.ToString());
                    CheckedTotalStockQty = CheckedTotalStockQty + AvailableQty;
                }
                txt_availableQty.Text = CheckedTotalStockQty.ToString("N2");
                btn_Receipt.Enabled = true;
            }
            catch { }
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            connSalesOrder.sp_Miscellaneous_Receipt_Select(grid_header, FromDate, ToDate);
        }

        private void btn_Receipt_Click(object sender, EventArgs e)
        {
            try
            {
                String Company = cbo_Company.Text.ToString();
                String Site = cbo_storageSite.Text.ToString();
                String ProductID = cbo_product.Text.ToString();
                String Status = cbo_Status.Text.ToString();
                String MRCMemo = txt_MrcMemo.Text.ToString();
                String MRCMemoCode = cbo_MemoCode.Text.ToString();

                DateTime ExpireDate = dateTimePickerExpired.Value;
                DialogResult dialogResult = MessageBox.Show("Proceed with Miscellaneous Receipt?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Site.Equals("") || ProductID.Equals("") || txt_ReceiptQty.Text.Equals("") || Status.Equals(""))
                    {
                        MessageBox.Show("Please select a valid Product ID before proceeding.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (cbo_MemoCode.Text.Equals(""))
                    {
                        MessageBox.Show("Please select the memo code.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!(cbo_storageSite.Text.Equals("BCS") || cbo_storageSite.Text.Equals("WH2")))
                    {
                        MessageBox.Show("Please choose the site 'BCS' or 'WH2'.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                   
                    String NewSTKNumber = connSalesOrder.sp_GET_NewSTKNumber();
                    String NewMRCNumber = connSalesOrder.sp_GET_NewMRCNumber();
                    String NewLOTNumber = connSalesOrder.sp_GET_NewLOTNumber();
                    decimal ReceiptQty = Convert.ToDecimal(txt_ReceiptQty.Text.ToString());

                    connSalesOrder.sp_Miscellaneous_Receipt_Save(Company, Site, ProductID, NewLOTNumber, NewMRCNumber, NewSTKNumber, ReceiptQty, Status, MRCMemoCode, MRCMemo, ExpireDate);
                   

                    MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbo_Status.Text = "";
                    txt_globalAllocated.Text = "";
                    txt_ReceiptQty.Text = "";
                    txt_availableQty.Text = "";
                    grid_stock.DataSource = null;
                    grid_stock.Rows.Clear();
                    grid_stock.Refresh();

                    LotInformationByProductID();
                    connSalesOrder.sp_Miscellaneous_Receipt_Select(grid_header, dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : "+ex.Message.ToString() + "", "※COTACT IT TEAM※", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_ReceiptQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbo_MemoCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            connSalesOrder.GETSTKReasonText("MR", cbo_MemoCode.Text.ToString(), txt_MrcMemoSummary);
        }

		private void cbo_product_TextUpdate(object sender, EventArgs e)
		{
            grid_stock.DataSource = null;
            txt_ProductDesc.Text = "";
            txt_globalAllocated.Text = "";
            txt_availableQty.Text = "";
            txt_ReceiptQty.Text = "";

            btn_Receipt.Enabled = false;
        }
	}
}
