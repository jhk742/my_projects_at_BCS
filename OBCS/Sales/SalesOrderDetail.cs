using OBCS.Entities;
using OBCS.Reports;
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
    public partial class SalesOrderDetail : Form
    {
        string selectedOrderID;
        public SalesOrderDetail(String OrderID)
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

            selectedOrderID = OrderID;
            txt_orderID.Text = selectedOrderID;

            if(cbo_customerID.Text.Trim() == "")
            {
                cbo_customerID.Enabled = true;
            }
            ManualOrderHeader manualOrderHeader = new ManualOrderHeader();
            manualOrderHeader = connSalesOrder.sp_ManualOrder_SELECT(selectedOrderID);
            cbo_customerID.Text = manualOrderHeader.CustomerID.Trim();
            txt_orderMemo.Text = manualOrderHeader.OrderMemo.Trim();
            txt_credit.Text = manualOrderHeader.CreditAmount.ToString("N2");

            if (cbo_customerID.Text.Trim() != "")
            {
                CustomerInfoObject customerInfoObject = new CustomerInfoObject();
                customerInfoObject = connSalesOrder.sp_GET_CustomerInfo(cbo_customerID.Text.Trim());

                txt_company.Text = customerInfoObject.CustomerName;
                txt_salesRep.Text = customerInfoObject.SalesRep;
                txt_billAddress1.Text = customerInfoObject.BillAddress1;
                txt_billAddress2.Text = customerInfoObject.BillAddress2;
                txt_billCity.Text = customerInfoObject.BillCity;
                txt_billStateCode.Text = customerInfoObject.BillState;
                txt_billPostalCode.Text = customerInfoObject.BillPostalCode;
                txt_billPhone.Text = customerInfoObject.BillPhone;
                txt_shipAddress1.Text = customerInfoObject.ShipAddress1;
                txt_shipAddress2.Text = customerInfoObject.ShipAddress2;
                txt_shipCity.Text = customerInfoObject.ShipCity;
                txt_shipStateCode.Text = customerInfoObject.ShipState;
                txt_shipPostalCode.Text = customerInfoObject.ShipPostalCode;
                txt_shipPhone.Text = customerInfoObject.ShipPhone;

                cbo_customerID.Enabled = false;
            }


            //connSalesOrder.sp_ManualOrder_detail(grid_OrderDetail, selectedOrderID);

            //grid_OrderDetail.ClearSelection();
            //grid_OrderDetail.FirstDisplayedScrollingRowIndex = grid_OrderDetail.RowCount - 1;
            //grid_OrderDetail.DataBindings.Clear();



            cbo_customerID.Items.Clear();
            connPO.cbox_getCustomerID(cbo_customerID);

            cbo_site.Items.Clear();
            cbo_site.Items.Add("BCS");
            cbo_site.Text = "BCS";

            txt_orderAmount.Text = 0.ToString("N2");
            txt_creditAmount.Text = 0.ToString("N2");
            txt_totalAmount.Text = 0.ToString("N2");

        }

        private void grid_product_Init()
        {
            grid_product.AutoGenerateColumns = false;
            grid_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_product.ColumnCount = 6;

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
            grid_product.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_product.Columns[5].DefaultCellStyle.Format = "N2";
            grid_product.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[5].DataPropertyName = "Onhand";
            
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
            grid_OrderDetail.ColumnCount = 13;

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

            grid_OrderDetail.Columns[2].Name = "Qty";
            grid_OrderDetail.Columns[2].ReadOnly = false;
            grid_OrderDetail.Columns[2].Width = 50;
            grid_OrderDetail.Columns[2].MinimumWidth = 50;
            grid_OrderDetail.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[2].DefaultCellStyle.Format = "N0";
            grid_OrderDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[2].DataPropertyName = "Qty";
           
            grid_OrderDetail.Columns[3].Name = "Description";
            grid_OrderDetail.Columns[3].ReadOnly = true;
            grid_OrderDetail.Columns[3].Width = 300;
            grid_OrderDetail.Columns[3].MinimumWidth = 300;
            grid_OrderDetail.Columns[3].DataPropertyName = "ProductDesc";

            grid_OrderDetail.Columns[4].Name = "PackSize";
            grid_OrderDetail.Columns[4].ReadOnly = true;
            grid_OrderDetail.Columns[4].Width = 80;
            grid_OrderDetail.Columns[4].MinimumWidth = 80;
            grid_OrderDetail.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[4].DataPropertyName = "PackSize";

            grid_OrderDetail.Columns[5].Name = "Price";
            grid_OrderDetail.Columns[5].ReadOnly = false;
            grid_OrderDetail.Columns[5].Width = 60;
            grid_OrderDetail.Columns[5].MinimumWidth = 60;
            grid_OrderDetail.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[5].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[5].DataPropertyName = "Price";

            grid_OrderDetail.Columns[6].Name = "Amount";
            grid_OrderDetail.Columns[6].ReadOnly = true;
            grid_OrderDetail.Columns[6].Width = 70;
            grid_OrderDetail.Columns[6].MinimumWidth = 70;
            grid_OrderDetail.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[6].DataPropertyName = "Amount";

            grid_OrderDetail.Columns[7].Name = "List Price";
            grid_OrderDetail.Columns[7].ReadOnly = true;
            grid_OrderDetail.Columns[7].Width = 60;
            grid_OrderDetail.Columns[7].MinimumWidth = 60;
            grid_OrderDetail.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[7].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[7].DataPropertyName = "ListPrice";

            grid_OrderDetail.Columns[8].Name = "Bottom Price";
            grid_OrderDetail.Columns[8].ReadOnly = true;
            grid_OrderDetail.Columns[8].Width = 60;
            grid_OrderDetail.Columns[8].MinimumWidth = 60;
            grid_OrderDetail.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[8].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[8].DataPropertyName = "BottomPrice";

            grid_OrderDetail.Columns[9].Name = "Base Price";
            grid_OrderDetail.Columns[9].ReadOnly = true;
            grid_OrderDetail.Columns[9].Width = 60;
            grid_OrderDetail.Columns[9].MinimumWidth = 60;
            grid_OrderDetail.Columns[9].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[9].DataPropertyName = "BasePrice";

            grid_OrderDetail.Columns[10].Name = "Onhand";
            grid_OrderDetail.Columns[10].ReadOnly = true;
            grid_OrderDetail.Columns[10].Width = 65;
            grid_OrderDetail.Columns[10].MinimumWidth = 65;
            grid_OrderDetail.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[10].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[10].DataPropertyName = "Onhand";

            DataGridViewComboBoxColumn RemarkComboBox = new DataGridViewComboBoxColumn();
            RemarkComboBox.Width = 50;
            RemarkComboBox.MinimumWidth = 50;
            RemarkComboBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            RemarkComboBox.Name = "Remark";
            RemarkComboBox.Items.Add("RR");
            RemarkComboBox.Items.Add("PF");
            RemarkComboBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            RemarkComboBox.DataPropertyName = "Remark";
            RemarkComboBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns.Insert(11, RemarkComboBox);
            grid_OrderDetail.CellValueChanged += new DataGridViewCellEventHandler(RemarkCellValueChanged);

            //grid_OrderDetail.Columns[8].Name = "Remark";
            //grid_OrderDetail.Columns[8].ReadOnly = true;
            //grid_OrderDetail.Columns[8].Width = 50;
            //grid_OrderDetail.Columns[8].MinimumWidth = 50;
            //grid_OrderDetail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_OrderDetail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_OrderDetail.Columns[8].DataPropertyName = "Remark";

            grid_OrderDetail.Columns[12].Name = "Return";
            grid_OrderDetail.Columns[12].ReadOnly = true;
            grid_OrderDetail.Columns[12].Width = 50;
            grid_OrderDetail.Columns[12].MinimumWidth = 50;
            grid_OrderDetail.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_OrderDetail.Columns[12].DataPropertyName = "Returnflag";

            DataGridViewButtonColumn infoButton = new DataGridViewButtonColumn();
            infoButton.Width = 50;
            infoButton.MinimumWidth = 50;
            infoButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            infoButton.Name = "info";
            infoButton.Text = "info";
            infoButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            infoButton.UseColumnTextForButtonValue = true;
            if (grid_OrderDetail.Columns["info"] == null)
            {
                grid_OrderDetail.Columns.Insert(13, infoButton);
            }

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

            grid_OrderDetail.Columns[15].Name = "OrderDetailKey";
            grid_OrderDetail.Columns[15].ReadOnly = true;
            grid_OrderDetail.Columns[15].Visible = false;
            grid_OrderDetail.Columns[15].Width = 40;
            grid_OrderDetail.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_OrderDetail.Columns[15].DataPropertyName = "OrderDetailKey";

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

        private void RemarkCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("RemarkCellValueChanged");
            //calculate();
        }

        private void searchProduct()
        {
            String SearchProductID = txt_searchProductID.Text.Trim();
            String SearchProductDesc = txt_searchProductDesc.Text.Trim();
            String SearchBrand = cbx_SearchBrand.Text.Trim();

            connPO.sp_LIST_Product(grid_product, SearchProductID, SearchBrand, SearchProductDesc, "Active", "NotPause");
        }

        private void cbo_customerID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_customerID.Text.Trim() != "")
            {
                CustomerInfoObject customerInfoObject = new CustomerInfoObject();
                customerInfoObject = connSalesOrder.sp_GET_CustomerInfo(cbo_customerID.Text.Trim());

                txt_company.Text = customerInfoObject.CustomerName;
                txt_salesRep.Text = customerInfoObject.SalesRep;
                txt_billAddress1.Text = customerInfoObject.BillAddress1;
                txt_billAddress2.Text = customerInfoObject.BillAddress2;
                txt_billCity.Text = customerInfoObject.BillCity;
                txt_billStateCode.Text = customerInfoObject.BillState;
                txt_billPostalCode.Text = customerInfoObject.BillPostalCode;
                txt_shipAddress1.Text = customerInfoObject.ShipAddress1;
                txt_shipAddress2.Text = customerInfoObject.ShipAddress2;
                txt_shipCity.Text = customerInfoObject.ShipCity;
                txt_shipStateCode.Text = customerInfoObject.ShipState;
                txt_shipPostalCode.Text = customerInfoObject.ShipPostalCode;

                //connSalesOrder.sp_ManualOrder_SET_CustomerID(selectedOrderID, cbo_customerID.Text.Trim());

                //cbo_customerID.Enabled = false;


            }
        }

        private void txt_searchProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchProduct();

                String ProductID = txt_searchProductID.Text.Trim();
                String CustomerID = cbo_customerID.Text.Trim();

                ManualOrderProductObject manualOrderProductObject = new ManualOrderProductObject();
                manualOrderProductObject = connSalesOrder.sp_GET_ManualOrderProductInfo(ProductID, CustomerID);
                if (manualOrderProductObject.ProductID == null)
                {
                    //MessageBox.Show("Are you sure deleting item from this order?"
                    //                                    , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return;
                }

                SalesOrderDetailProduct salesOrderDetailProduct = new SalesOrderDetailProduct(ProductID, CustomerID);
                salesOrderDetailProduct.ShowDialog();

                if (SalesOrderDetailProduct.save)
                {
                    DataTable dt = this.grid_OrderDetail.DataSource as DataTable;
                    DataRow dr = dt.NewRow();

                    string addProductID = SalesOrderDetailProduct.ProductID;
                    string addProductDesc = SalesOrderDetailProduct.ProductDesc;
                    string addPackSize = SalesOrderDetailProduct.PackSize;
                    decimal addQty = SalesOrderDetailProduct.Qty;
                    decimal addPrice = SalesOrderDetailProduct.Price;
                    decimal addAmount = SalesOrderDetailProduct.Amount;
                    string addRemark = SalesOrderDetailProduct.Remark;
                    string addReturn = SalesOrderDetailProduct.Return;
                    decimal addListPrice = SalesOrderDetailProduct.ListPrice;
                    decimal addBottomPrice = SalesOrderDetailProduct.BottomPrice;
                    decimal addBasePrice = SalesOrderDetailProduct.BasePrice;
                    decimal addOnhand = SalesOrderDetailProduct.Onhand;

                    // grid_OrderDetail.Rows.Add(new object[] { "", addQty, addProductID, addProductDesc, addPackSize, addPrice, addQty * addPrice, addBottomPrice, addBasePrice, addOnhand, addRemark, addReturn });

                    dr["ProductID"] = addProductID;
                    dr["Qty"] = addQty;
                    dr["ProductDesc"] = addProductDesc;
                    dr["PackSize"] = addPackSize;
                    dr["Price"] = addPrice;
                    dr["Amount"] = addAmount;
                    dr["ListPrice"] = addListPrice;
                    dr["BottomPrice"] = addBottomPrice;
                    dr["BasePrice"] = addBasePrice;
                    dr["Onhand"] = addOnhand;
                    dr["Remark"] = addRemark;
                    dr["ReturnFlag"] = addReturn;

                    int orderDetailKey = connSalesOrder.sp_ManualOrder_GET_NewOrderDetailKey(selectedOrderID, addReturn);
                    dr["OrderDetailKey"] = orderDetailKey;
                    dt.Rows.Add(dr);

                    connSalesOrder.sp_ManualOrder_INSERT_DETAIL(selectedOrderID, orderDetailKey, addProductID, addQty, addPrice, addReturn, addRemark);

                    calculate();
                    //grid_OrderDetail.FirstDisplayedScrollingRowIndex = grid_OrderDetail.RowCount - 1;
                    grid_OrderDetail.CurrentCell = grid_OrderDetail.Rows[grid_OrderDetail.RowCount - 1].Cells[1];
                }
            }
            
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{

        //    //capture down arrow key
        //    if (keyData == Keys.Down)
        //    {
        //        if (txt_searchProductID.Focused == true)
        //        { 
        //        MessageBox.Show("if");
        //        grid_product.Focus();
        //        }
        //        else
        //        {
        //            MessageBox.Show("else");
        //        }
        //        //MessageBox.Show("You pressed Down arrow key");
                
        //        return true;
        //    }
            
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        

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
            String CustomerID = cbo_customerID.Text.Trim();
            SalesOrderDetailProduct salesOrderDetailProduct = new SalesOrderDetailProduct(ProductID, CustomerID);
            salesOrderDetailProduct.ShowDialog();

            if(SalesOrderDetailProduct.save)
            {
                DataTable dt = this.grid_OrderDetail.DataSource as DataTable;
                DataRow dr = dt.NewRow();

                string addProductID = SalesOrderDetailProduct.ProductID;
                string addProductDesc = SalesOrderDetailProduct.ProductDesc;
                string addPackSize = SalesOrderDetailProduct.PackSize;
                decimal addQty = SalesOrderDetailProduct.Qty;
                decimal addPrice = SalesOrderDetailProduct.Price;
                decimal addAmount = SalesOrderDetailProduct.Amount;
                string addRemark = SalesOrderDetailProduct.Remark;
                string addReturn = SalesOrderDetailProduct.Return;
                decimal addListPrice = SalesOrderDetailProduct.ListPrice;
                decimal addBottomPrice = SalesOrderDetailProduct.BottomPrice;
                decimal addBasePrice = SalesOrderDetailProduct.BasePrice;
                decimal addOnhand = SalesOrderDetailProduct.Onhand;

                // grid_OrderDetail.Rows.Add(new object[] { "", addQty, addProductID, addProductDesc, addPackSize, addPrice, addQty * addPrice, addBottomPrice, addBasePrice, addOnhand, addRemark, addReturn });

                dr["ProductID"] = addProductID;
                dr["Qty"] = addQty;
                dr["ProductDesc"] = addProductDesc;
                dr["PackSize"] = addPackSize;
                dr["Price"] = addPrice;
                dr["Amount"] = addAmount;
                dr["ListPrice"] = addListPrice;
                dr["BottomPrice"] = addBottomPrice;
                dr["BasePrice"] = addBasePrice;
                dr["Onhand"] = addOnhand;
                dr["Remark"] = addRemark;
                dr["ReturnFlag"] = addReturn;

                int orderDetailKey = connSalesOrder.sp_ManualOrder_GET_NewOrderDetailKey(selectedOrderID, addReturn);
                dr["OrderDetailKey"] = orderDetailKey;
                dt.Rows.Add(dr);

                connSalesOrder.sp_ManualOrder_INSERT_DETAIL(selectedOrderID, orderDetailKey, addProductID, addQty, addPrice, addReturn, addRemark);

                calculate();
                //grid_OrderDetail.FirstDisplayedScrollingRowIndex = grid_OrderDetail.RowCount - 1;
                grid_OrderDetail.CurrentCell = grid_OrderDetail.Rows[grid_OrderDetail.RowCount - 1].Cells[1];
            }
            
            
        }
        

        private void grid_OrderDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("grid_OrderDetail_CellValueChanged");
            
            if (grid_OrderDetail.Columns[e.ColumnIndex].Name == "Qty" || grid_OrderDetail.Columns[e.ColumnIndex].Name == "Price" || grid_OrderDetail.Columns[e.ColumnIndex].Name == "Remark")
            {
                int deletingOrderDetailKey = Convert.ToInt32(grid_OrderDetail.Rows[e.RowIndex].Cells["OrderDetailKey"].Value.ToString().Trim());
                decimal qty = Convert.ToDecimal(grid_OrderDetail.Rows[e.RowIndex].Cells["Qty"].Value);
                decimal price = Convert.ToDecimal(grid_OrderDetail.Rows[e.RowIndex].Cells["Price"].Value);
                string Remark = grid_OrderDetail.Rows[e.RowIndex].Cells["Remark"].Value.ToString().Trim();

                if (Remark == "PF")
                    grid_OrderDetail.Rows[e.RowIndex].Cells["Amount"].Value = 0;
                else
                    grid_OrderDetail.Rows[e.RowIndex].Cells["Amount"].Value = qty * price;

                //MessageBox.Show(Remark);
                connSalesOrder.sp_ManualOrder_UPDATE_DETAIL(selectedOrderID, deletingOrderDetailKey, qty, price, Remark);

                calculate();
            }
            
            
        }

        private void calculate()
        {
            //MessageBox.Show("calculate");
            try
            {
                Decimal Amount = 0;
                //for (int i = 0; i < grid_OrderDetail.RowCount; i++)
                //{
                //    decimal qty = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Qty"].Value);
                //    decimal price = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Price"].Value);
                //    string Remark = grid_OrderDetail.Rows[i].Cells["Remark"].Value.ToString().Trim();
                //    string Return = grid_OrderDetail.Rows[i].Cells["Return"].Value.ToString().Trim();
                //    decimal amount = qty * price;

                //    //if (Remark == "PF")
                //    //    grid_OrderDetail.Rows[i].Cells["Amount"].Value = 0;
                //    //else
                //    //    grid_OrderDetail.Rows[i].Cells["Amount"].Value = amount;
                //}

                for (int j = 0; j < grid_OrderDetail.RowCount; j++)
                {
                    string Remark = grid_OrderDetail.Rows[j].Cells["Remark"].Value.ToString().Trim();
                    string Return = grid_OrderDetail.Rows[j].Cells["Return"].Value.ToString().Trim();
                    decimal amount = Convert.ToDecimal(grid_OrderDetail.Rows[j].Cells["Amount"].Value);
                    if (Return != "Y" && Remark == "RR")
                    {
                        Amount = Amount + amount;
                    }
                }


                //Decimal SalesTotal = Amount - Convert.ToDecimal(txt_creditAmount.Text.Trim());
                txt_orderAmount.Text = Amount.ToString("N2");

                try
                {
                    Decimal OrderAmount = Convert.ToDecimal(txt_orderAmount.Text.Trim());
                    Decimal CreditAmount = Convert.ToDecimal(txt_creditAmount.Text.Trim());
                    Decimal TotalAmount = OrderAmount - CreditAmount;
                    txt_totalAmount.Text = TotalAmount.ToString("N2");
                }
                catch
                {

                }
            }
            catch
            {
                MessageBox.Show("Please input valid values.");
            }
            

            
        }

        private void grid_OrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 13 && e.RowIndex >= 0) // info button
            {
                string customerID = cbo_customerID.Text.Trim();
                string productID = grid_OrderDetail.Rows[e.RowIndex].Cells["Product ID"].Value.ToString().Trim();
                SalesOrderHistory salesOrderHistory = new SalesOrderHistory(customerID, productID);
                salesOrderHistory.Show();
            }

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
                    int deletingOrderDetailKey = Convert.ToInt32(grid_OrderDetail.Rows[e.RowIndex].Cells["OrderDetailKey"].Value.ToString().Trim());
                    connSalesOrder.sp_ManualOrder_DELETE_DETAIL(selectedOrderID, deletingOrderDetailKey);

                    grid_OrderDetail.Rows.RemoveAt(e.RowIndex);
                    calculate();
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }


        private void txt_creditAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal OrderAmount = Convert.ToDecimal(txt_orderAmount.Text.Trim());
                Decimal CreditAmount = Convert.ToDecimal(txt_creditAmount.Text.Trim());
                Decimal TotalAmount = OrderAmount - CreditAmount;
                txt_totalAmount.Text = TotalAmount.ToString("N2");
            }
            catch
            {

            }
           
        }

        private void txt_credit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal Credit = Convert.ToDecimal(txt_credit.Text.Trim());
                txt_creditAmount.Text = Credit.ToString("N2");
            }
            catch
            {
                if (txt_credit.Text == "")
                    txt_creditAmount.Text = 0.ToString("N2");
            }

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure sending the order?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (cbo_customerID.Text.ToString() == "")
                {
                    MessageBox.Show("Select Customer.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    String customerID = cbo_customerID.Text.ToString().Trim();
                    if (connSalesOrder.sp_CHECK_NewCustomerID(customerID) == true)
                    {
                        connSalesOrder.sp_ManualOrder_SEND(selectedOrderID);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Not exists Customer.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }

            //DialogResult dialogResult = MessageBox.Show("Are you sure sending the order?"
            //                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    String NewORDNumber = connSalesOrder.sp_GET_NewORDNumber();
            //    if (!NewORDNumber.Contains("ORD"))
            //    {
            //        MessageBox.Show("Please try again. (Error code: " + NewORDNumber + ")"
            //                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }

            //    string customerID = cbo_customerID.Text.Trim();
            //    string REP = txt_salesRep.Text.Trim();
            //    decimal creditAmount = Convert.ToDecimal(txt_creditAmount.Text.Trim());
            //    string orderMemo = txt_orderMemo.Text.Trim();

            //    connSalesOrder.sp_ManualOrderSend_header(NewORDNumber, customerID, REP, creditAmount, orderMemo);

            //    for (int i = 0; i < grid_OrderDetail.RowCount; i++)
            //    {
            //        string productID = grid_OrderDetail.Rows[i].Cells["Product ID"].Value.ToString().Trim();
            //        decimal qty = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Qty"].Value);
            //        decimal price = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Price"].Value);
            //        string Remark = grid_OrderDetail.Rows[i].Cells["Remark"].Value.ToString().Trim();
            //        string Return = grid_OrderDetail.Rows[i].Cells["Return"].Value.ToString().Trim();
            //        if (Return == "")
            //            Return = "N";
            //        decimal amount = qty * price;

            //        if (Remark == "PF")
            //            grid_OrderDetail.Rows[i].Cells["Amount"].Value = 0;
            //        else
            //            grid_OrderDetail.Rows[i].Cells["Amount"].Value = amount;

            //        connSalesOrder.sp_ManualOrderSend_detail(NewORDNumber, i, productID, qty, price, Return, Remark);
            //    }

            //    MessageBox.Show("the order has been sent."
            //                                        , "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    //Close();
            //}
            //else if (dialogResult == DialogResult.No)
            //{

            //}



        }

        String OrderStatus;
        bool bOccupied = false;

        private void ManualOrder_Load(object sender, EventArgs e)
        {
            try
            {
                connSalesOrder.sp_ManualOrder_detail(grid_OrderDetail, selectedOrderID);
                grid_OrderDetail.CurrentCell = grid_OrderDetail.Rows[grid_OrderDetail.RowCount - 1].Cells[1];
                //grid_OrderDetail.ClearSelection();
                //grid_OrderDetail.FirstDisplayedScrollingRowIndex = grid_OrderDetail.RowCount - 1;
                calculate();
            }
            catch
            {

            }

            

            String CompleteFlag = connSalesOrder.sp_ManualOrder_CHECK_SEND(selectedOrderID);
            //MessageBox.Show(CompleteFlag);

            if(CompleteFlag.Trim() == "Y")
            {
                grid_OrderDetail.Enabled = false;
                grid_product.Enabled = false;
                txt_credit.Enabled = false;
                txt_orderMemo.Enabled = false;
                btn_send.Enabled = false;
                txt_searchProductID.Enabled = false;
                txt_searchProductDesc.Enabled = false;
            }

            //occupied check
            String OrderID = txt_orderID.Text.Trim();
            OrderStatus = connSalesOrder.sp_ManualOrder_OCCUPIED_CHECK(OrderID);
            if (OrderStatus == "Occupying")
            {
                btn_send.Enabled = false;
                cbo_customerID.Enabled = false;
                txt_orderMemo.Enabled = false;
                txt_credit.Enabled = false;
                txt_searchProductID.Enabled = false;
                txt_searchProductDesc.Enabled = false;
                MessageBox.Show("Someone occupying this sales order.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                bOccupied = true;
                return;
            }
            else if (OrderStatus == "Sent")
            {
                MessageBox.Show("This order has been sent already.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                bOccupied = true;
                return;
            }

        }

        private void grid_OrderDetail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //calculate();
            for (int i = 0; i < grid_OrderDetail.RowCount; i++)
            {
                decimal Price = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Price"].Value);
                decimal ListPrice = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["List Price"].Value);

                if (Price != ListPrice) grid_OrderDetail.Rows[i].Cells["Price"].Style.ForeColor = Color.Red;
                else grid_OrderDetail.Rows[i].Cells["Price"].Style.ForeColor = Color.Black;
            }
        }

        private void txt_orderMemo_Leave(object sender, EventArgs e)
        {
            updateHeader();
        }
        private void updateHeader()
        {
            connSalesOrder.sp_ManualOrder_UPDATE_HEADER(selectedOrderID, txt_orderMemo.Text.Trim(), Convert.ToDecimal(txt_credit.Text.Trim()));
        }

        private void txt_credit_Leave(object sender, EventArgs e)
        {
            if (txt_credit.Text.Trim() == "")
                txt_credit.Text = "0";
            try
            {
                updateHeader();
            }
            catch
            {
            }
            
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            String CustomerID = cbo_customerID.Text.Trim();
            CustInfo custInfo = new CustInfo();
            custInfo = connSalesOrder.sp_GET_CustomerInfoByCustomerID(CustomerID);

            String CustomerName = custInfo.CustomerName;

            String Address1 = custInfo.Address1;
            String Address2 = custInfo.Address2;
            String CustomerAddress = Address1 + "\n" + Address2;

            String Branch = custInfo.Branch;
            if (Branch == "BCS")
                Branch = "BCS International";
            else if (Branch == "NYC")
                Branch = "New York Cheese";
            else if (Branch == "HYD")
                Branch = "HYUNDAI";
            else if (Branch == "CFI")
                Branch = "Care Food";

            Rpt_ManualOrderReport rpt_ManualOrderReport = new Rpt_ManualOrderReport(selectedOrderID, Branch, CustomerID, CustomerName, CustomerAddress);
            rpt_ManualOrderReport.Show();
        }

        private void cbo_customerID_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cbo_customerID.Text.Trim() != "")
                {
                    CustomerInfoObject customerInfoObject = new CustomerInfoObject();
                    customerInfoObject = connSalesOrder.sp_GET_CustomerInfo(cbo_customerID.Text.Trim());

                    txt_company.Text = customerInfoObject.CustomerName;
                    txt_salesRep.Text = customerInfoObject.SalesRep;
                    txt_billAddress1.Text = customerInfoObject.BillAddress1;
                    txt_billAddress2.Text = customerInfoObject.BillAddress2;
                    txt_billCity.Text = customerInfoObject.BillCity;
                    txt_billStateCode.Text = customerInfoObject.BillState;
                    txt_billPostalCode.Text = customerInfoObject.BillPostalCode;
                    txt_shipAddress1.Text = customerInfoObject.ShipAddress1;
                    txt_shipAddress2.Text = customerInfoObject.ShipAddress2;
                    txt_shipCity.Text = customerInfoObject.ShipCity;
                    txt_shipStateCode.Text = customerInfoObject.ShipState;
                    txt_shipPostalCode.Text = customerInfoObject.ShipPostalCode;
                }
            }
            catch
            {
                cbo_customerID.Text = "";
                cbo_customerID.Focus();
                return;
            }
            

            if (cbo_customerID.Text.Trim() != "")
            {
                String customerID = cbo_customerID.Text.ToString().Trim();
                if (connSalesOrder.sp_CHECK_NewCustomerID(customerID) == true)
                {
                    connSalesOrder.sp_ManualOrder_SET_CustomerID(selectedOrderID, cbo_customerID.Text.Trim(), txt_salesRep.Text.Trim());
                    cbo_customerID.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Not exists Customer.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cbo_customerID.Focus();
                    return;
                }
            }
        }

        private void txt_searchProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (grid_product.DataSource != null)
            {
                if ((e.KeyData & Keys.KeyCode) == Keys.Down)
                {
                    int row = grid_product.CurrentRow.Cells[0] == null ? grid_product.Rows[0].Index : grid_product.CurrentRow.Index;
                    grid_product.Rows[row].Selected = true;
                    grid_product.Focus();
                }
            }
        }

        private void grid_product_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData & Keys.KeyCode) == Keys.Enter)
            {
                String ProductID = grid_product.Rows[grid_product.CurrentRow.Index].Cells["Item Code"].Value.ToString().Trim();
                String CustomerID = cbo_customerID.Text.Trim();
                int row = grid_product.Rows[grid_product.CurrentRow.Index].Index;
                grid_product.Rows[row].Selected = true;

                SalesOrderDetailProduct salesOrderDetailProduct = new SalesOrderDetailProduct(ProductID, CustomerID);
                salesOrderDetailProduct.ShowDialog();

                if (SalesOrderDetailProduct.save)
                {
                    DataTable dt = this.grid_OrderDetail.DataSource as DataTable;
                    DataRow dr = dt.NewRow();

                    string addProductID = SalesOrderDetailProduct.ProductID;
                    string addProductDesc = SalesOrderDetailProduct.ProductDesc;
                    string addPackSize = SalesOrderDetailProduct.PackSize;
                    decimal addQty = SalesOrderDetailProduct.Qty;
                    decimal addPrice = SalesOrderDetailProduct.Price;
                    decimal addAmount = SalesOrderDetailProduct.Amount;
                    string addRemark = SalesOrderDetailProduct.Remark;
                    string addReturn = SalesOrderDetailProduct.Return;
                    decimal addListPrice = SalesOrderDetailProduct.ListPrice;
                    decimal addBottomPrice = SalesOrderDetailProduct.BottomPrice;
                    decimal addBasePrice = SalesOrderDetailProduct.BasePrice;
                    decimal addOnhand = SalesOrderDetailProduct.Onhand;

                    // grid_OrderDetail.Rows.Add(new object[] { "", addQty, addProductID, addProductDesc, addPackSize, addPrice, addQty * addPrice, addBottomPrice, addBasePrice, addOnhand, addRemark, addReturn });

                    dr["ProductID"] = addProductID;
                    dr["Qty"] = addQty;
                    dr["ProductDesc"] = addProductDesc;
                    dr["PackSize"] = addPackSize;
                    dr["Price"] = addPrice;
                    dr["Amount"] = addAmount;
                    dr["ListPrice"] = addListPrice;
                    dr["BottomPrice"] = addBottomPrice;
                    dr["BasePrice"] = addBasePrice;
                    dr["Onhand"] = addOnhand;
                    dr["Remark"] = addRemark;
                    dr["ReturnFlag"] = addReturn;

                    int orderDetailKey = connSalesOrder.sp_ManualOrder_GET_NewOrderDetailKey(selectedOrderID, addReturn);
                    dr["OrderDetailKey"] = orderDetailKey;
                    dt.Rows.Add(dr);

                    connSalesOrder.sp_ManualOrder_INSERT_DETAIL(selectedOrderID, orderDetailKey, addProductID, addQty, addPrice, addReturn, addRemark);

                    calculate();
                    //grid_OrderDetail.FirstDisplayedScrollingRowIndex = grid_OrderDetail.RowCount - 1;
                    grid_OrderDetail.CurrentCell = grid_OrderDetail.Rows[grid_OrderDetail.RowCount - 1].Cells[1];
                }
            }
        }

        private void txt_salesRep_Leave(object sender, EventArgs e)
        {
            connSalesOrder.sp_ManualOrder_SET_CustomerID(selectedOrderID, cbo_customerID.Text.Trim(), txt_salesRep.Text.Trim());
        }

        private void searchProduct_Enter(object sender, EventArgs e)
        {
            if (cbo_customerID.Enabled == true)
            {
                MessageBox.Show("You must select a customer first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_customerID.Focus();
                return;
            }
        }

        private void SalesOrderDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (bOccupied == false)
            { 
                connSalesOrder.sp_ManualOrder_OCCUPIED_RELEASE(selectedOrderID);
            }
            
        }
    }
}
