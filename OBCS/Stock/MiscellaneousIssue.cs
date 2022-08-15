using System;
using System.Drawing;
using System.Windows.Forms;

namespace OBCS.Stock
{
    public partial class MiscellaneousIssue : Form
    {
        public MiscellaneousIssue()
        {
            InitializeComponent();
            grid_header_Init();
            grid_Detail_Init();
            grid_stock_Init();

            dateTimePickerFrom.Value = DateTime.Now.AddDays(-7);
            DateTime FromDate = dateTimePickerFrom.Value;
            DateTime ToDate = dateTimePickerTo.Value;
            connSalesOrder.sp_Miscellaneous_Issue_Select(grid_header, FromDate, ToDate);
            connSalesOrder.cbo_AllProduct(cbo_product);
            connSalesOrder.cbo_STKReasonCode("MI", cbo_MemoCode);
            //connSalesOrder.cbo_SiteFromSTOJOU(cbo_storageSite);
            cbo_storageSite.Items.Add("BCS");
            cbo_storageSite.Items.Add("WH2");
            cbo_Company.Items.Add("B.C.S.INTERNATIONAL CORP.");
            cbo_storageSite.SelectedItem = "BCS";
            cbo_Company.SelectedItem = "B.C.S.INTERNATIONAL CORP.";
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

            grid_header.Columns[1].Name = "Number";
            grid_header.Columns[1].ReadOnly = true;
            grid_header.Columns[1].Width = 50;
            grid_header.Columns[1].MinimumWidth = 50;
            grid_header.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[1].DataPropertyName = "MisNumber";

            grid_header.Columns[2].Name = "Account Date";
            grid_header.Columns[2].ReadOnly = true;
            grid_header.Columns[2].Width = 60;
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

            grid_header.Columns[5].Name = "Type Name";
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

            grid_Detail.Columns[1].Name = "Product ID";
            grid_Detail.Columns[1].ReadOnly = true;
            grid_Detail.Columns[1].Width = 40;
            grid_Detail.Columns[1].MinimumWidth = 40;
            grid_Detail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[1].DataPropertyName = "ITMREF_0";

            grid_Detail.Columns[2].Name = "Lot number";
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

            grid_Detail.Columns[6].Name = "Quantity";
            grid_Detail.Columns[6].ReadOnly = true;
            grid_Detail.Columns[6].Width = 40;
            grid_Detail.Columns[6].MinimumWidth = 40;
            grid_Detail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_Detail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Detail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Detail.Columns[6].DataPropertyName = "QTYPCU_0";

            grid_Detail.Columns[7].Name = "Amount";
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
            grid_stock.ColumnCount = 14;

            grid_stock.Columns[0].Name = "Site";
            grid_stock.Columns[0].ReadOnly = true;
            grid_stock.Columns[0].Width = 20;
            grid_stock.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[0].DataPropertyName = "STOFCY_0";

            grid_stock.Columns[1].Name = "Product ID";
            grid_stock.Columns[1].ReadOnly = true;
            grid_stock.Columns[1].Width = 55;
            grid_stock.Columns[1].MinimumWidth = 55;
            grid_stock.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[1].DataPropertyName = "ITMREF_0";

            grid_stock.Columns[2].Name = "Lot number";
            grid_stock.Columns[2].ReadOnly = true;
            grid_stock.Columns[2].Width = 55;
            grid_stock.Columns[2].MinimumWidth = 55;
            grid_stock.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[2].DataPropertyName = "LOT_0";

            grid_stock.Columns[3].Name = "TRANSACTION_CHANGE";
            grid_stock.Columns[3].ReadOnly = true;
            grid_stock.Columns[3].Visible = false;
            grid_stock.Columns[3].Width = 100;
            grid_stock.Columns[3].MinimumWidth = 100;
            grid_stock.Columns[3].DataPropertyName = "TRANSACTION_CHANGE";

            grid_stock.Columns[4].Name = "Status";
            grid_stock.Columns[4].ReadOnly = true;
            grid_stock.Columns[4].Width = 30;
            grid_stock.Columns[4].MinimumWidth = 30;
            grid_stock.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[4].DataPropertyName = "STA_0";

            grid_stock.Columns[5].Name = "Initial quantity";
            grid_stock.Columns[5].ReadOnly = true;
            grid_stock.Columns[5].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[5].Width = 60;
            grid_stock.Columns[5].DataPropertyName = "InitialQty";

            grid_stock.Columns[6].Name = "Remaining quantity";
            grid_stock.Columns[6].ReadOnly = true;
            grid_stock.Columns[6].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[6].Width = 80;
            grid_stock.Columns[6].DataPropertyName = "RemainingQty";

            grid_stock.Columns[7].Name = "Detailed";
            grid_stock.Columns[7].ReadOnly = true;
            grid_stock.Columns[7].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[7].Width = 40;
            grid_stock.Columns[7].DataPropertyName = "Detailed";

            grid_stock.Columns[8].Name = "Available";
            grid_stock.Columns[8].ReadOnly = true;
            grid_stock.Columns[8].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[8].Width = 40;
            grid_stock.Columns[8].DataPropertyName = "AvailableQty";

            grid_stock.Columns[9].Name = "Allocated";
            grid_stock.Columns[9].ReadOnly = true;
            grid_stock.Columns[9].Visible = false;
            grid_stock.Columns[9].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[9].Width = 40;
            grid_stock.Columns[9].DataPropertyName = "Allocated";

            //DataGridViewCheckBoxColumn stockCheck = new DataGridViewCheckBoxColumn();
            //stockCheck.HeaderText = "V";
            //stockCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //stockCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //stockCheck.FalseValue = false;
            //stockCheck.TrueValue = true;
            //stockCheck.Name = "stockCheckSelect";
            //stockCheck.ReadOnly = false;
            //stockCheck.Width = 25;
            //stockCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //stockCheck.Visible = true;
            ////pickingCheck.DataPropertyName = "FLGDLVPRN";
            //grid_stock.Columns.Insert(6, stockCheck);
            //grid_stock.CellContentClick += new DataGridViewCellEventHandler(stockCheckSelect);

            grid_stock.Columns[10].Name = "Issue quantity";
            grid_stock.Columns[10].ReadOnly = false;
            grid_stock.Columns[10].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[10].Width = 60;
            grid_stock.Columns[10].DataPropertyName = "IssueQty";

            grid_stock.Columns[11].Name = "Expiration";
            grid_stock.Columns[11].ReadOnly = true;
            grid_stock.Columns[11].Width = 50;
            grid_stock.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[11].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_stock.Columns[11].DataPropertyName = "Expiration";

            grid_stock.Columns[12].Name = "Update user";
            grid_stock.Columns[12].ReadOnly = true;
            grid_stock.Columns[12].Width = 50;
            grid_stock.Columns[12].MinimumWidth = 50;
            grid_stock.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[12].DataPropertyName = "UPDUSER";

            grid_stock.Columns[13].Name = "Update time";
            grid_stock.Columns[13].ReadOnly = true;
            grid_stock.Columns[13].Width = 120;
            grid_stock.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_stock.Columns[10].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_stock.Columns[13].DataPropertyName = "UPDDATTIM_0";

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
       
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            connSalesOrder.sp_Miscellaneous_Issue_Select(grid_header, FromDate, ToDate);
        }
        private void grid_header_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String MisNumber = grid_header.Rows[e.RowIndex].Cells["Number"].Value.ToString();
                connSalesOrder.sp_Miscellaneous_Issue_Select_Detail(grid_Detail, MisNumber);
            }
            catch { }
        }
        private void cbo_product_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_ProductDesc.Text = "";
            txt_globalAllocated.Text = "";
            txt_availableQty.Text = "";
            txt_IssueQty.Text = "";

            grid_stock.DataSource = null;
            btn_Save.Enabled = false;

            LotInformationByProductID();
        }
        private void cbo_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LotInformationByProductID();
            }
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

                btn_Save.Enabled = true;
            }
            catch { btn_Save.Enabled = false; }
        }

       

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal Available = 0;
                Decimal TotalIssueQty = 0;
                Decimal CheckNumber = 0;
                int StockLine = 1;
                String Company = cbo_Company.Text.ToString();
                String Site = cbo_storageSite.Text.ToString();
                String ProductID = cbo_product.Text.ToString();
                String MisMemo = txt_MisMemo.Text.ToString();
                String MisMemoCode = cbo_MemoCode.Text.ToString();


                if (cbo_storageSite.Text.Equals(""))
                {
                    MessageBox.Show("Please select the site.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbo_MemoCode.Text.Equals(""))
                { 
                    MessageBox.Show("Please select the memo code.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!(cbo_storageSite.Text.Equals("BCS") || cbo_storageSite.Text.Equals("WH2")))
                {
                    MessageBox.Show("Please choose the site 'BCS' or 'WH2'.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                for (int i = 0; i < grid_stock.RowCount; i++)
                {
                    if (grid_stock.Rows[i].Cells["Status"].Value.ToString().Trim() == "A")
                    {
                        Available += (Convert.ToDecimal(grid_stock.Rows[i].Cells["Available"].Value.ToString().Trim()) - Convert.ToDecimal(grid_stock.Rows[i].Cells["Issue quantity"].Value.ToString().Trim()));
                    }
                    TotalIssueQty += Convert.ToDecimal(grid_stock.Rows[i].Cells["Issue quantity"].Value.ToString().Trim());
                   
                }

                if ((Available < Convert.ToDecimal(txt_globalAllocated.Text.Trim())) && cbo_storageSite.Text.Equals("BCS"))
                {
                    MessageBox.Show("Please check GLOBAL qty."
                                                           , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(TotalIssueQty == 0)
                {
                    MessageBox.Show("Please check Issue qty."
                                                          , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure to continue Miscellaneous Issue?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    String AvailableResult = connSalesOrder.sp_Miscellaneous_Issue_Available_Check(Site, ProductID, TotalIssueQty);
                    //MessageBox.Show(Site + "\n" + ProductID + "\n" + TotalIssueQty.ToString() + "\n" + AvailableResult);
                    if (!AvailableResult.Equals("Success"))
                    {
                        MessageBox.Show("Item stock has changed. Please refresh and try again.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    String NewSTKNumber = connSalesOrder.sp_GET_NewSTKNumber();
                    String NewMISNumber = connSalesOrder.sp_GET_NewMISNumber();
                    //INSERT(GACCENTRY,GACCENTRYD)
                    //String SaveGaccResult = connSalesOrder.sp_Miscellaneous_Issue_Save_Gaccentry(Company, Site, ProductID, NewSTKNumber, NewMISNumber, TotalIssueQty, MisMemo);

                    //if (!SaveGaccResult.Equals("Success"))
                    //{
                    //    MessageBox.Show(SaveGaccResult, "※COTACT IT TEAM※", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    //    return;

                    //} 

                    //sp_Miscellaneous_Issue_Save_Stock 에서 stock, account jou 같이 insert 업데이트: 12/14/2021
                    //INSERT(STOUJOU), UPDATE(STOCK, STOCOST)
                    //INSERT(GACCENTRY,GACCENTRYD)
                    for (int i = 0; i < grid_stock.RowCount; i++)
                    {
                        if (Convert.ToDecimal(grid_stock.Rows[i].Cells["Issue quantity"].Value) > 0)
                        {
                            String LotNumber = grid_stock.Rows[i].Cells["Lot number"].Value.ToString();
                            Decimal IssueQtys = Convert.ToDecimal(grid_stock.Rows[i].Cells["Issue quantity"].Value);
                            String Status = grid_stock.Rows[i].Cells["Status"].Value.ToString();

                            String SaveStockResult = connSalesOrder.sp_Miscellaneous_Issue_Save_Stock(LotNumber, Company, Site, ProductID, NewSTKNumber, NewMISNumber, IssueQtys, Status, MisMemoCode, MisMemo, StockLine);
                            if (!SaveStockResult.Equals("Success"))
                            {
                                MessageBox.Show(SaveStockResult, "※COTACT IT TEAM※", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                return;
                            }
                            StockLine++;
                            //MessageBox.Show(LotNumber);
                        }
                    }
                    MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_globalAllocated.Text = "";
                    txt_IssueQty.Text = "";
                    txt_availableQty.Text = "";
                    grid_stock.DataSource = null;
                    grid_stock.Rows.Clear();
                    grid_stock.Refresh();

                    LotInformationByProductID();
                    connSalesOrder.sp_Miscellaneous_Issue_Select(grid_header, dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : " + ex.Message.ToString() + "", "※COTACT IT TEAM※", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grid_stock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                btn_Save.Enabled = true;
                foreach (DataGridViewRow row in this.grid_stock.Rows)
                {
                    row.Cells["Issue quantity"].Style.BackColor = Color.OldLace;
                }
                if (grid_stock.RowCount == 0)
                {
                    btn_Save.Enabled = false;
                }
            }
            catch { }
            
        }
        private void cbo_MemoCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            connSalesOrder.GETSTKReasonText("MI", cbo_MemoCode.Text.ToString(), txt_MisMemoSummary);
        }

        private void grid_stock_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Decimal TotalIssueQty = 0;
                if (grid_stock.Rows[e.RowIndex].Cells["Issue quantity"].Value == DBNull.Value || Convert.ToDecimal(grid_stock.Rows[e.RowIndex].Cells["Issue quantity"].Value) < 0)
                {
                    grid_stock.Rows[e.RowIndex].Cells["Issue quantity"].Value = "0.00";
                }

                if (Convert.ToDecimal(grid_stock.Rows[e.RowIndex].Cells["Issue quantity"].Value) > Convert.ToDecimal(grid_stock.Rows[e.RowIndex].Cells["Available"].Value))
                {
                    MessageBox.Show("Please check ISSUE qty."
                                                            , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grid_stock.Rows[e.RowIndex].Cells["Issue quantity"].Value = "0.00";
                    //grid_stock.Rows[e.RowIndex].Cells["stockCheckSelect"].Value = false;
                    //grid_stock.Rows[e.RowIndex].Cells["IssueQty"].ReadOnly = true;
                }


                for (int i = 0; i < grid_stock.RowCount; i++)
                {
                    TotalIssueQty += Convert.ToDecimal(grid_stock.Rows[i].Cells["Issue quantity"].Value);
                }
                txt_IssueQty.Text = TotalIssueQty.ToString("N2");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "DataGridView Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grid_stock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0.00";
                //MessageBox.Show("HI" + ex.ToString());
            }
        }

		private void cbo_product_TextUpdate(object sender, EventArgs e)
		{
            grid_stock.DataSource = null;
            txt_ProductDesc.Text = "";
            txt_globalAllocated.Text = "";
            txt_availableQty.Text = "";
            txt_IssueQty.Text = "";

            btn_Save.Enabled = false;
        }
	}
}
