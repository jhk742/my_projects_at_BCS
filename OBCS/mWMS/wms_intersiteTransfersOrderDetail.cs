using OBCS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.mWMS
{
    public partial class wms_intersiteTransfersOrderDetail : Form
    {
        string selectedOrderID;
        public wms_intersiteTransfersOrderDetail(String OrderID)
        {
            InitializeComponent();

            grid_product_Init();
            grid_OrderDetail_Init();

            //detail grid multi line allow
            grid_product.AllowDrop = true;
            grid_product.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_product.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //detail grid multi line allow
            grid_OrderDetail.AllowDrop = true;
            grid_OrderDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_OrderDetail.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            IntersiteTransfersObject intersiteTransfersObject = new IntersiteTransfersObject();
            
            selectedOrderID = OrderID;
            txt_orderID.Text = selectedOrderID;
            
            cbo_siteFrom.Items.Clear();
            cbo_siteFrom.Items.Add("BCS");
            cbo_siteFrom.Items.Add("WH2");
            //cbo_siteFrom.Text = "WH2";

            cbo_siteTo.Items.Clear();
            cbo_siteTo.Items.Add("BCS");
            cbo_siteTo.Items.Add("WH2");
            //cbo_siteTo.Text = "BCS";

            //intersiteTransfersObject = connSalesOrder.sp_WMS_INTERSITETRANSFERS_GET_HEADER(selectedOrderID);
            //cbo_siteTo.Text = intersiteTransfersObject.DestSite;
            //cbo_siteFrom.Text = intersiteTransfersObject.StockSite;
            //txt_orderMemo.Text = intersiteTransfersObject.Memo;
            //dateTimePickerDate.Text = intersiteTransfersObject.CreateTime.ToShortDateString();

            txt_totalAmount.Text = 0.ToString("N2");

        }

        private void grid_product_Init()
        {
            grid_product.AutoGenerateColumns = false;
            grid_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_product.ColumnCount = 7;

            grid_product.Columns[0].Name = "";
            grid_product.Columns[0].Visible = false;
            grid_product.Columns[0].Width = 80;
            grid_product.Columns[0].MinimumWidth = 80;
            grid_product.Columns[0].DataPropertyName = "";

            grid_product.Columns[1].Name = "Item Code";
            grid_product.Columns[1].ReadOnly = true;
            grid_product.Columns[1].Width = 75;
            grid_product.Columns[1].MinimumWidth = 75;
            grid_product.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_product.Columns[1].DataPropertyName = "ProductID";

            grid_product.Columns[2].Name = "Description";
            grid_product.Columns[2].ReadOnly = true;
            grid_product.Columns[2].Width = 300;
            grid_product.Columns[2].MinimumWidth = 300;
            grid_product.Columns[2].DataPropertyName = "ProductDesc";

            grid_product.Columns[3].Name = "Pack Size";
            grid_product.Columns[3].ReadOnly = true;
            grid_product.Columns[3].Width = 80;
            grid_product.Columns[3].MinimumWidth = 80;
            grid_product.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_product.Columns[3].DataPropertyName = "StrPackSize";

            grid_product.Columns[4].Name = "Price";
            grid_product.Columns[4].ReadOnly = true;
            grid_product.Columns[4].Width = 60;
            grid_product.Columns[4].MinimumWidth = 60;
            grid_product.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_product.Columns[4].DefaultCellStyle.Format = "N2";
            grid_product.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[4].DataPropertyName = "UnitPr";

            grid_product.Columns[5].Name = "Onhand";
            grid_product.Columns[5].ReadOnly = true;
            grid_product.Columns[5].Width = 65;
            grid_product.Columns[5].MinimumWidth = 65;
            grid_product.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_product.Columns[5].DefaultCellStyle.Format = "N2";
            grid_product.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[5].DataPropertyName = "Onhand";

            grid_product.Columns[6].Name = "Onhand (WH)";
            grid_product.Columns[6].ReadOnly = true;
            grid_product.Columns[6].Width = 65;
            grid_product.Columns[6].MinimumWidth = 65;
            grid_product.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_product.Columns[6].DefaultCellStyle.Format = "N2";
            grid_product.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[6].DataPropertyName = "PHYQTYWH";

            //grid font size custom
            grid_product.RowTemplate.Height = 20;
            grid_product.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_product.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_product.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_OrderDetail_Init()
        {
            grid_OrderDetail.AutoGenerateColumns = false;
            grid_OrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_OrderDetail.ColumnCount = 15;

            grid_OrderDetail.Columns[0].Name = "";
            grid_OrderDetail.Columns[0].Visible = false;
            grid_OrderDetail.Columns[0].Width = 80;
            grid_OrderDetail.Columns[0].MinimumWidth = 80;
            grid_OrderDetail.Columns[0].DataPropertyName = "";

            grid_OrderDetail.Columns[1].Name = "Product ID";
            grid_OrderDetail.Columns[1].ReadOnly = true;
            grid_OrderDetail.Columns[1].Width = 75;
            grid_OrderDetail.Columns[1].MinimumWidth = 75;
            grid_OrderDetail.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[1].DataPropertyName = "ProductID";

            grid_OrderDetail.Columns[2].Name = "Status";
            grid_OrderDetail.Columns[2].ReadOnly = true;
            grid_OrderDetail.Columns[2].Width = 35;
            grid_OrderDetail.Columns[2].MinimumWidth = 35;
            grid_OrderDetail.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[2].DataPropertyName = "Status";

            grid_OrderDetail.Columns[3].Name = "Qty";
            grid_OrderDetail.Columns[3].ReadOnly = true;
            grid_OrderDetail.Columns[3].Width = 50;
            grid_OrderDetail.Columns[3].MinimumWidth = 50;
            grid_OrderDetail.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[3].DefaultCellStyle.Format = "N0";
            grid_OrderDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[3].DataPropertyName = "Qty";

            grid_OrderDetail.Columns[4].Name = "Description";
            grid_OrderDetail.Columns[4].ReadOnly = true;
            grid_OrderDetail.Columns[4].Width = 300;
            grid_OrderDetail.Columns[4].MinimumWidth = 300;
            grid_OrderDetail.Columns[4].DataPropertyName = "ProductDesc";

            grid_OrderDetail.Columns[5].Name = "PackSize";
            grid_OrderDetail.Columns[5].ReadOnly = true;
            grid_OrderDetail.Columns[5].Width = 80;
            grid_OrderDetail.Columns[5].MinimumWidth = 80;
            grid_OrderDetail.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[5].DataPropertyName = "PackSize";

            grid_OrderDetail.Columns[6].Name = "Base Price";
            grid_OrderDetail.Columns[6].ReadOnly = true;
            grid_OrderDetail.Columns[6].Width = 60;
            grid_OrderDetail.Columns[6].MinimumWidth = 60;
            grid_OrderDetail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[6].DataPropertyName = "BasePrice";

            grid_OrderDetail.Columns[7].Name = "Amount";
            grid_OrderDetail.Columns[7].ReadOnly = true;
            grid_OrderDetail.Columns[7].Width = 70;
            grid_OrderDetail.Columns[7].MinimumWidth = 70;
            grid_OrderDetail.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[7].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[7].DataPropertyName = "Amount";
            
            grid_OrderDetail.Columns[8].Name = "BCS Onhand";
            grid_OrderDetail.Columns[8].ReadOnly = true;
            grid_OrderDetail.Columns[8].Width = 65;
            grid_OrderDetail.Columns[8].MinimumWidth = 65;
            grid_OrderDetail.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[8].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[8].DataPropertyName = "Onhand";

            grid_OrderDetail.Columns[9].Name = "BCS Stock (Q)";
            grid_OrderDetail.Columns[9].ReadOnly = true;
            grid_OrderDetail.Columns[9].Width = 65;
            grid_OrderDetail.Columns[9].MinimumWidth = 65;
            grid_OrderDetail.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[9].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[9].DataPropertyName = "BCSStockQ";

            grid_OrderDetail.Columns[10].Name = "BCS Stock (R)";
            grid_OrderDetail.Columns[10].ReadOnly = true;
            grid_OrderDetail.Columns[10].Width = 65;
            grid_OrderDetail.Columns[10].MinimumWidth = 65;
            grid_OrderDetail.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[10].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[10].DataPropertyName = "BCSStockR";

            grid_OrderDetail.Columns[11].Name = "WH2 Stock (A)";
            grid_OrderDetail.Columns[11].ReadOnly = true;
            grid_OrderDetail.Columns[11].Width = 65;
            grid_OrderDetail.Columns[11].MinimumWidth = 65;
            grid_OrderDetail.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[11].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[11].DataPropertyName = "WH2StockA";

            grid_OrderDetail.Columns[12].Name = "WH2 Stock (Q)";
            grid_OrderDetail.Columns[12].ReadOnly = true;
            grid_OrderDetail.Columns[12].Width = 65;
            grid_OrderDetail.Columns[12].MinimumWidth = 65;
            grid_OrderDetail.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[12].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[12].DataPropertyName = "WH2StockQ";

            grid_OrderDetail.Columns[13].Name = "WH2 Stock (R)";
            grid_OrderDetail.Columns[13].ReadOnly = true;
            grid_OrderDetail.Columns[13].Width = 65;
            grid_OrderDetail.Columns[13].MinimumWidth = 65;
            grid_OrderDetail.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[13].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[13].DataPropertyName = "WH2StockR";
            

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 50;
            deleteButton.MinimumWidth = 50;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_OrderDetail.Columns["Delete"] == null)
            {
                grid_OrderDetail.Columns.Insert(14, deleteButton);
            }

            grid_OrderDetail.Columns[15].Name = "DetailKey";
            grid_OrderDetail.Columns[15].ReadOnly = true;
            grid_OrderDetail.Columns[15].Visible = true;
            grid_OrderDetail.Columns[15].Width = 40;
            grid_OrderDetail.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[15].DataPropertyName = "DetailKey";

            //grid font size custom
            grid_OrderDetail.RowTemplate.Height = 20;
            grid_OrderDetail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_OrderDetail.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_OrderDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void searchProduct()
        {
            String SearchProductID = txt_searchProductID.Text.Trim();
            String SearchProductDesc = txt_searchProductDesc.Text.Trim();
            String SearchBrand = cbx_SearchBrand.Text.Trim();

            connPO.sp_LIST_Product(grid_product, SearchProductID, SearchBrand, SearchProductDesc, "Active", "NotPause");
        }

        private void txt_searchProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchProduct();

                String ProductID = txt_searchProductID.Text.Trim();
                
                for (int i = 0; i < grid_OrderDetail.RowCount; i++)
                {
                    String CheckProductID = grid_OrderDetail.Rows[i].Cells["Product ID"].Value.ToString().Trim();

                    if (ProductID == CheckProductID)
                    {
                        MessageBox.Show("The product is already in the list."
                                                            , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }

                String FromSite = cbo_siteFrom.Text.Trim();

                ProductObject productObject = new ProductObject();
                productObject = connSalesOrder.sp_GET_ProductInfo(ProductID);
                
                wms_intersiteTransfersOrderItemDetail itemDetail = new wms_intersiteTransfersOrderItemDetail(ProductID, FromSite);
                itemDetail.ShowDialog();

                if (wms_intersiteTransfersOrderItemDetail.save)
                {
                    DataTable dt = this.grid_OrderDetail.DataSource as DataTable;
                    DataRow dr = dt.NewRow();

                    string addProductID = wms_intersiteTransfersOrderItemDetail.ProductID;
                    string addProductDesc = wms_intersiteTransfersOrderItemDetail.ProductDesc;
                    string addPackSize = wms_intersiteTransfersOrderItemDetail.PackSize;
                    string addSalesUnit = wms_intersiteTransfersOrderItemDetail.SalesUnit;
                    decimal addQty = wms_intersiteTransfersOrderItemDetail.Qty;
                    decimal addBasePrice = wms_intersiteTransfersOrderItemDetail.BasePrice;
                    decimal addAmount = wms_intersiteTransfersOrderItemDetail.Amount;
                    decimal addOnhand = wms_intersiteTransfersOrderItemDetail.Onhand;
                    decimal addBCSStockQ = wms_intersiteTransfersOrderItemDetail.BCSStockQ;
                    decimal addBCSStockR = wms_intersiteTransfersOrderItemDetail.BCSStockR;
                    decimal addWH2StockA= wms_intersiteTransfersOrderItemDetail.WH2StockA;
                    decimal addWH2StockQ = wms_intersiteTransfersOrderItemDetail.WH2StockQ;
                    decimal addWH2StockR = wms_intersiteTransfersOrderItemDetail.WH2StockR;
                    string addStatus = wms_intersiteTransfersOrderItemDetail.Status;

                    // grid_OrderDetail.Rows.Add(new object[] { "", addQty, addProductID, addProductDesc, addPackSize, addPrice, addQty * addPrice, addBottomPrice, addBasePrice, addOnhand, addRemark, addReturn });

                    dr["ProductID"] = addProductID;
                    dr["Qty"] = addQty;
                    dr["ProductDesc"] = addProductDesc;
                    dr["PackSize"] = addPackSize;
                    dr["Amount"] = addAmount;
                    dr["BasePrice"] = addBasePrice;
                    dr["Onhand"] = addOnhand;
                    dr["BCSStockQ"] = addBCSStockQ;
                    dr["BCSStockR"] = addBCSStockR;
                    dr["WH2StockA"] = addWH2StockA;
                    dr["WH2StockQ"] = addWH2StockQ;
                    dr["WH2StockR"] = addWH2StockR;
                    dr["Status"] = addStatus;
                    
                    //int orderDetailKey = connSalesOrder.sp_ManualOrder_GET_NewOrderDetailKey(selectedOrderID, addReturn);
                    int maxOrderDetailKey = 0;
                    for (int i = 0; i < grid_OrderDetail.RowCount; i++)
                    {
                        int OrderDetailKey = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["DetailKey"].Value.ToString().Trim());

                        if (maxOrderDetailKey < OrderDetailKey)
                        {
                            maxOrderDetailKey = OrderDetailKey;
                        }
                    }
                    dr["DetailKey"] = maxOrderDetailKey+1;
                    dt.Rows.Add(dr);

                    //connSalesOrder.sp_WMS_INTERSITETRANSFERS_INSERT_DETAIL(selectedOrderID, maxOrderDetailKey + 1, addProductID, addProductDesc, addPackSize, addSalesUnit, "A", addQty, addBasePrice, addAmount);

                    calculate();
                    //grid_OrderDetail.FirstDisplayedScrollingRowIndex = grid_OrderDetail.RowCount - 1;
                    grid_OrderDetail.CurrentCell = grid_OrderDetail.Rows[grid_OrderDetail.RowCount - 1].Cells[1];
                }
            }
        }

        private void txt_searchProductDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchProduct();
            }
        }

        private void grid_product_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String ProductID = grid_product.Rows[e.RowIndex].Cells["Item Code"].Value.ToString().Trim();

            for (int i = 0; i < grid_OrderDetail.RowCount; i++)
            {
                String CheckProductID = grid_OrderDetail.Rows[i].Cells["Product ID"].Value.ToString().Trim();

                if(ProductID == CheckProductID)
                {
                    MessageBox.Show("The product is already in the list."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            String FromSite = cbo_siteFrom.Text.Trim();

            ProductObject productObject = new ProductObject();
            productObject = connSalesOrder.sp_GET_ProductInfo(ProductID);

            wms_intersiteTransfersOrderItemDetail itemDetail = new wms_intersiteTransfersOrderItemDetail(ProductID, FromSite);
            itemDetail.ShowDialog();

            if (wms_intersiteTransfersOrderItemDetail.save)
            {
                DataTable dt = this.grid_OrderDetail.DataSource as DataTable;
                DataRow dr = dt.NewRow();

                string addProductID = wms_intersiteTransfersOrderItemDetail.ProductID;
                string addProductDesc = wms_intersiteTransfersOrderItemDetail.ProductDesc;
                string addPackSize = wms_intersiteTransfersOrderItemDetail.PackSize;
                string addSalesUnit = wms_intersiteTransfersOrderItemDetail.SalesUnit;
                decimal addQty = wms_intersiteTransfersOrderItemDetail.Qty;
                decimal addBasePrice = wms_intersiteTransfersOrderItemDetail.BasePrice;
                decimal addAmount = wms_intersiteTransfersOrderItemDetail.Amount;
                decimal addOnhand = wms_intersiteTransfersOrderItemDetail.Onhand;
                decimal addBCSStockQ = wms_intersiteTransfersOrderItemDetail.BCSStockQ;
                decimal addBCSStockR = wms_intersiteTransfersOrderItemDetail.BCSStockR;
                decimal addWH2StockA = wms_intersiteTransfersOrderItemDetail.WH2StockA;
                decimal addWH2StockQ = wms_intersiteTransfersOrderItemDetail.WH2StockQ;
                decimal addWH2StockR = wms_intersiteTransfersOrderItemDetail.WH2StockR;
                string addStatus = wms_intersiteTransfersOrderItemDetail.Status;
                string addSite = wms_intersiteTransfersOrderItemDetail.Site;

                int maxOrderDetailKey = 0;
                for (int i = 0; i < grid_OrderDetail.RowCount; i++)
                {
                    int OrderDetailKey = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["DetailKey"].Value.ToString().Trim());

                    if (maxOrderDetailKey < OrderDetailKey)
                    {
                        maxOrderDetailKey = OrderDetailKey;
                    }
                }

                String result = connSalesOrder.sp_WMS_INTERSITETRANSFERS_INSERT_DETAIL(selectedOrderID, maxOrderDetailKey + 1, addProductID, addProductDesc, addPackSize, addSalesUnit, addSite, addStatus, addQty, addBasePrice, addAmount);

                if (result == "OK")
                {
                    dr["ProductID"] = addProductID;
                    dr["Qty"] = addQty;
                    dr["ProductDesc"] = addProductDesc;
                    dr["PackSize"] = addPackSize;
                    dr["Amount"] = addAmount;
                    dr["BasePrice"] = addBasePrice;
                    dr["Onhand"] = addOnhand;
                    dr["BCSStockQ"] = addBCSStockQ;
                    dr["BCSStockR"] = addBCSStockR;
                    dr["WH2StockA"] = addWH2StockA;
                    dr["WH2StockQ"] = addWH2StockQ;
                    dr["WH2StockR"] = addWH2StockR;
                    dr["Status"] = addStatus;
                    dr["DetailKey"] = maxOrderDetailKey + 1;
                    dt.Rows.Add(dr);

                    calculate();
                    //grid_OrderDetail.FirstDisplayedScrollingRowIndex = grid_OrderDetail.RowCount - 1;
                    grid_OrderDetail.CurrentCell = grid_OrderDetail.Rows[grid_OrderDetail.RowCount - 1].Cells[1];
                }
                else
                {
                    MessageBox.Show("Please try again.(Stock Qty)"
                                                    , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
            }
        }

        private void grid_OrderDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_OrderDetail.Columns[e.ColumnIndex].Name == "Qty")
            {
                int deletingOrderDetailKey = Convert.ToInt32(grid_OrderDetail.Rows[e.RowIndex].Cells["DetailKey"].Value.ToString().Trim());
                decimal qty = Convert.ToDecimal(grid_OrderDetail.Rows[e.RowIndex].Cells["Qty"].Value);
                decimal basePrice = Convert.ToDecimal(grid_OrderDetail.Rows[e.RowIndex].Cells["Base Price"].Value);

                grid_OrderDetail.Rows[e.RowIndex].Cells["Amount"].Value = qty * basePrice;

                //MessageBox.Show(Remark);
                connSalesOrder.sp_WMS_INTERSITETRANSFERS_ORDER_UPDATE_DETAIL(selectedOrderID, deletingOrderDetailKey, qty);

                calculate();
            }
        }

        private void calculate()
        {
            try
            {
                Decimal Amount = 0;
                

                for (int j = 0; j < grid_OrderDetail.RowCount; j++)
                {
                    decimal amount = Convert.ToDecimal(grid_OrderDetail.Rows[j].Cells["Amount"].Value);
                    Amount = Amount + amount;
                }
                
                txt_totalAmount.Text = Amount.ToString("N2");
                
            }
            catch
            {
                MessageBox.Show("Please input valid values.");
            }



        }

        private void grid_OrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 14 && e.RowIndex >= 0) // Delete button
            {
                //MessageBox.Show(e.RowIndex.ToString().Trim());
                DialogResult dialogResult = MessageBox.Show("Are you sure deleting item from this order?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //DataTable dt = this.grid_OrderDetail.DataSource as DataTable;
                    //DataRow dr = dt.NewRow();
                    //dt.Rows.RemoveAt(e.RowIndex);
                    int deletingOrderDetailKey = Convert.ToInt32(grid_OrderDetail.Rows[e.RowIndex].Cells["DetailKey"].Value.ToString().Trim());
                    connSalesOrder.sp_WMS_INTERSITETRANSFERS_ORDER_DELETE_DETAIL(selectedOrderID, deletingOrderDetailKey);

                    grid_OrderDetail.Rows.RemoveAt(e.RowIndex);
                    calculate();
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            String WHCHGNumber = txt_orderID.Text.Trim();
            String StockSite = cbo_siteFrom.Text.Trim();
            String DestSite = cbo_siteTo.Text.Trim();
            String Memo = txt_orderMemo.Text.Trim();

            connSalesOrder.sp_WMS_INTERSITETRANSFERS_UPDATE_HEADER(WHCHGNumber, StockSite, DestSite, Memo);
            
            Close();
            
        }

        private void wms_intersiteTransfersDetail_Load(object sender, EventArgs e)
        {
            try
            {
                connSalesOrder.sp_WMS_INTERSITETRANSFERS_ORDER_detail(grid_OrderDetail, selectedOrderID);

                IntersiteTransfersObject intersiteTransfersObject = new IntersiteTransfersObject();
                intersiteTransfersObject = connSalesOrder.sp_WMS_INTERSITETRANSFERS_GET_HEADER(selectedOrderID);

                cbo_siteFrom.Text = intersiteTransfersObject.StockSite;
                cbo_siteTo.Text = intersiteTransfersObject.DestSite;
                txt_orderMemo.Text = intersiteTransfersObject.Memo;
                dateTimePickerDate.Value = intersiteTransfersObject.CreateTime;

                
                
                try
                {
                    grid_OrderDetail.CurrentCell = grid_OrderDetail.Rows[grid_OrderDetail.RowCount - 1].Cells[1];
                }
                catch
                {

                }
                //grid_OrderDetail.ClearSelection();
                //grid_OrderDetail.FirstDisplayedScrollingRowIndex = grid_OrderDetail.RowCount - 1;
                calculate();

                string issued = "";
                issued = connSalesOrder.sp_WMS_INTERSITETRANSFERS_ORDER_ISSUED_CHECK(selectedOrderID);
                if (issued == "Issued")
                {
                    txt_searchProductID.Enabled = false;
                    txt_searchProductDesc.Enabled = false;
                    txt_orderMemo.Enabled = false;
                    grid_product.Enabled = false;
                    grid_OrderDetail.Columns[14].Visible = false;
                    btn_save.Enabled = false;
                    
                }
            }
            catch
            {
                MessageBox.Show("CATCH");
            }

            //String CompleteFlag = connSalesOrder.sp_ManualOrder_CHECK_SEND(selectedOrderID);
            //MessageBox.Show(CompleteFlag);

            //if (CompleteFlag.Trim() == "Y")
            //{
            //    grid_OrderDetail.Enabled = false;
            //    grid_product.Enabled = false;
            //    txt_credit.Enabled = false;
            //    txt_orderMemo.Enabled = false;
            //    btn_send.Enabled = false;
            //    txt_searchProductID.Enabled = false;
            //    txt_searchProductDesc.Enabled = false;

            //}
        }

        private void cbo_siteFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("cbo_siteFrom_SelectedIndexChanged");
            if (cbo_siteFrom.Text == "BCS")
            {
                cbo_siteTo.Text = "WH2";
            }
            else if (cbo_siteFrom.Text == "WH2")
            {
                cbo_siteTo.Text = "BCS";
            }

            String WHCHGNumber = txt_orderID.Text.Trim();
            String StockSite = cbo_siteFrom.Text.Trim();
            String DestSite = cbo_siteTo.Text.Trim();
            String Memo = txt_orderMemo.Text.Trim();

            //connSalesOrder.sp_WMS_INTERSITETRANSFERS_UPDATE_HEADER(WHCHGNumber, StockSite, DestSite, Memo);
        }
        

        private void grid_OrderDetail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //MessageBox.Show("grid_OrderDetail_DataBindingComplete");
            if (grid_OrderDetail.RowCount > 0)
            {
                cbo_siteFrom.Enabled = false;
                //cbo_siteTo.Enabled = false;
                
            }
            else if (grid_OrderDetail.RowCount == 0)
            {
                cbo_siteFrom.Enabled = true;
                //cbo_siteTo.Enabled = true;
            }
            String WHCHGNumber = txt_orderID.Text.Trim();
            String StockSite = cbo_siteFrom.Text.Trim();
            String DestSite = cbo_siteTo.Text.Trim();
            String Memo = txt_orderMemo.Text.Trim();
            
        }
        
    }
}
