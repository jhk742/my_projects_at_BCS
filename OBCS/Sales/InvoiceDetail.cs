using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBCS.Entities;

namespace OBCS.Sales
{
    public partial class InvoiceDetail : Form
    {
        Entities.Order2 order2 = new Entities.Order2();
        public InvoiceDetail(String OrderID)
        {
            InitializeComponent();
            grid_OrderDetail_Init();
            txt_orderID.Text = OrderID;
            connSalesOrder.sp_Fetch_InvoiceDetail(grid_OrderDetail, OrderID);
            
            //Order2 info
            //Order2 order2 = new Order2();
            order2 = connSalesOrder.sp_Fetch_InvoiceInfo(OrderID);

            txt_orderID.Text = order2.OrderID;
            txt_customerID.Text = order2.CustomerID;
            txt_company.Text = order2.CustomerName;
            txt_orderMemo.Text = order2.OrderMemo;
            txt_orderDate.Text = order2.OrderDate.ToString();
            txt_iPadOrderID.Text = order2.iPadOrderID;

            txt_billAddress1.Text = order2.BillAddress1;
            txt_billAddress2.Text = order2.BillAddress2;
            txt_billCity.Text = order2.BillCity;
            txt_billStateCode.Text = order2.BillState;
            txt_billPostalCode.Text = order2.BillZip;

            txt_shipAddress1.Text = order2.ShipAddress1;
            txt_shipAddress2.Text = order2.ShipAddress2;
            txt_shipCity.Text = order2.ShipCity;
            txt_shipStateCode.Text = order2.ShipState;
            txt_shipPostalCode.Text = order2.ShipZip;
            txt_saleRep.Text = order2.SaleRep.ToString();



            //아이템 가져오기
            connSalesOrder.cbo_itemID(cbo_itemID);
            

        }

        private void grid_OrderDetail_Init()
        {
            grid_OrderDetail.AutoGenerateColumns = false;
            grid_OrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_OrderDetail.ColumnCount = 17;

            grid_OrderDetail.Columns[0].Name = "No.";
            grid_OrderDetail.Columns[0].ReadOnly = true;
            grid_OrderDetail.Columns[0].Width = 30;
            grid_OrderDetail.Columns[0].DataPropertyName = "OrderDetailKey";

            grid_OrderDetail.Columns[1].Name = "Item ID";
            grid_OrderDetail.Columns[1].ReadOnly = true;
            grid_OrderDetail.Columns[1].Width = 100;
            grid_OrderDetail.Columns[1].DataPropertyName = "ProductID";

            grid_OrderDetail.Columns[2].Name = "Qty";
            grid_OrderDetail.Columns[2].Width = 50;
            grid_OrderDetail.Columns[2].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[2].DataPropertyName = "OrderQty";

            grid_OrderDetail.Columns[3].Name = "Item Desc";
            grid_OrderDetail.Columns[3].ReadOnly = true;
            grid_OrderDetail.Columns[3].Width = 300;
            grid_OrderDetail.Columns[3].DataPropertyName = "ProductDesc";

            grid_OrderDetail.Columns[4].Name = "Unit";
            grid_OrderDetail.Columns[4].ReadOnly = true;
            grid_OrderDetail.Columns[4].Width = 30;
            grid_OrderDetail.Columns[4].DataPropertyName = "SUnitM";

            grid_OrderDetail.Columns[5].Name = "Pack Size";
            grid_OrderDetail.Columns[5].ReadOnly = true;
            grid_OrderDetail.Columns[5].Width = 90;
            grid_OrderDetail.Columns[5].DataPropertyName = "StrPackSize";

            grid_OrderDetail.Columns[6].Name = "Price";
            grid_OrderDetail.Columns[6].Width = 60;
            grid_OrderDetail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[6].DataPropertyName = "Price";

            grid_OrderDetail.Columns[7].Name = "Amount";
            grid_OrderDetail.Columns[7].ReadOnly = true;
            grid_OrderDetail.Columns[7].Width = 60;
            grid_OrderDetail.Columns[7].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[7].DataPropertyName = "Amount";

            grid_OrderDetail.Columns[8].Name = "RM";
            grid_OrderDetail.Columns[8].Width = 30;
            grid_OrderDetail.Columns[8].DataPropertyName = "Remark";
            
            grid_OrderDetail.Columns[9].Name = "PF";
            grid_OrderDetail.Columns[9].ReadOnly = true;
            grid_OrderDetail.Columns[9].Width = 30;
            grid_OrderDetail.Columns[9].DataPropertyName = "";

            grid_OrderDetail.Columns[10].Name = "Unit Price";
            grid_OrderDetail.Columns[10].ReadOnly = true;
            grid_OrderDetail.Columns[10].Width = 60;
            grid_OrderDetail.Columns[10].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[10].DataPropertyName = "UnitPr";

            grid_OrderDetail.Columns[11].Name = "Bottom Price";
            grid_OrderDetail.Columns[11].ReadOnly = true;
            grid_OrderDetail.Columns[11].Width = 60;
            grid_OrderDetail.Columns[11].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[11].DataPropertyName = "BottomPr";

            grid_OrderDetail.Columns[12].Name = "Onhand";
            grid_OrderDetail.Columns[12].ReadOnly = true;
            grid_OrderDetail.Columns[12].Width = 60;
            grid_OrderDetail.Columns[12].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[12].DataPropertyName = "QtyOnHand";

            grid_OrderDetail.Columns[13].Name = "Inner";
            grid_OrderDetail.Columns[13].ReadOnly = true;
            grid_OrderDetail.Columns[13].Width = 50;
            grid_OrderDetail.Columns[13].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[13].DataPropertyName = "LastOutCost";



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


            grid_OrderDetail.Columns[14].Name = "Return";
            grid_OrderDetail.Columns[14].Visible = false;
            grid_OrderDetail.Columns[14].DataPropertyName = "ReturnFlag";

            grid_OrderDetail.Columns[15].Name = "ProductKey";
            grid_OrderDetail.Columns[15].Visible = false;
            grid_OrderDetail.Columns[15].DataPropertyName = "ItemKey";
        
            grid_OrderDetail.Columns[16].Name = "Status";
            grid_OrderDetail.Columns[16].Visible = false;
            grid_OrderDetail.Columns[16].DataPropertyName = "Status";
            
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
        

        private void grid_OrderDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string orderQtyString = grid_OrderDetail.CurrentRow.Cells["Qty"].Value.ToString();
            double orderQty = Convert.ToDouble(orderQtyString);

            string priceString = grid_OrderDetail.CurrentRow.Cells["Price"].Value.ToString();
            double price = Convert.ToDouble(priceString);

            string amountString = grid_OrderDetail.CurrentRow.Cells["Amount"].Value.ToString();
            double amount = Convert.ToDouble(amountString);
            
            if(grid_OrderDetail.CurrentRow.Cells["RM"].Value.ToString() == "RR")
            {
                amount = orderQty * price;
                grid_OrderDetail.CurrentRow.Cells["Amount"].Value = amount;
            }

            Audit();

        }
        private void Audit()
        {
            for (int i = 0; i < grid_OrderDetail.RowCount; i++)
            {
                decimal price = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Price"].Value);
                decimal bottomPrice = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Bottom Price"].Value);
                decimal unitPrice = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Unit Price"].Value);
                decimal qty = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Qty"].Value);
                decimal onhand = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Onhand"].Value);
                string Remark = grid_OrderDetail.Rows[i].Cells["RM"].Value.ToString();
                string ReturnFlag = grid_OrderDetail.Rows[i].Cells["Return"].Value.ToString();
                string status = grid_OrderDetail.Rows[i].Cells["Status"].Value.ToString();


                if (price < bottomPrice && Remark == "RR")
                {
                    grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                    
                }
                else
                {
                    if (qty > onhand)
                    {
                        //grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.Violet;
                    }
                    else
                    {
                        if (Remark == "PF")
                        {
                            grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                        }
                        else
                        {
                            grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                }

                if (ReturnFlag == "Y")
                {
                    grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.DarkGray;
                }

                if (status == "OS")
                {
                    //grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.CornflowerBlue;
                }

            }


            //Total Amount
            Decimal Amount = 0;
            for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
            {
                String ReturnFlag = grid_OrderDetail.Rows[i].Cells["Return"].Value.ToString();
                String Status = grid_OrderDetail.Rows[i].Cells["Status"].Value.ToString();
                if (ReturnFlag == "N" && Status != "OS")
                {
                    
                    Amount += Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Amount"].Value);
                    //MessageBox.Show(Amount.ToString());
                }
                //MessageBox.Show(grid_RTTMPD.Rows[i].Cells["Memo"].Value.ToString());
            }
            /* 달러 표시 방법
                0 : ($12,345.00)
                1 : -$12,345.00
                2 : $-12,345.00
                3 : $12,345.00-
                4 : (12,345.00$)
                5 : -12,345.00$
                6 : 12,345.00-$
                7 : 12,345.00$-
                8 : -12,345.00 $
                9 : -$ 12,345.00
                10 : 12,345.00 $-
                11 : $ 12,345.00-
                12 : $ -12,345.00
                13 : 12,345.00- $
                14 : ($ 12,345.00)
                15 : (12,345.00 $)
                https://stackoverflow.com/questions/14137597/int-tostringc-removes-negative-symbol
            */
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyNegativePattern = 1;
            txt_amount.Text = Amount.ToString("C");

            //get Credit Amount
            Decimal creditAmount = Convert.ToDecimal(connSalesOrder.getCreditAmountFromOrder2(txt_orderID.Text.Trim()));
            txt_creditAmount.Text = creditAmount.ToString("C");

            Decimal SalesTotal = Amount - creditAmount;
            txt_salesTotal.Text = SalesTotal.ToString("C");
        }

        private void grid_OrderDetail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grid_OrderDetail.ClearSelection();
            Audit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //Create a new order number
            DialogResult dialogResult = MessageBox.Show("Are you sure UPDATE this order??"
                                                        , "Confirming", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                //connSalesOrder.sp_CREATE_Invoice(txt_orderID.Text.Trim());

                //온핸드
                //connSalesOrder.sp_UPDATE_AddOnhand(order2.OrderID);
                
                for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
                {
                    Entities.OrderDetail2 orderDetail2 = new Entities.OrderDetail2();

                    orderDetail2.OrderID = txt_orderID.Text.Trim();
                    orderDetail2.OrderDetailKey = grid_OrderDetail.Rows[i].Cells["No."].Value.ToString();
                    //orderDetail2.ProductKey = grid_OrderDetail.Rows[i].Cells["ProductKey"].Value.ToString();
                    orderDetail2.ProductID = grid_OrderDetail.Rows[i].Cells["Item ID"].Value.ToString();
                    orderDetail2.OrderQty = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Qty"].Value);
                    orderDetail2.Price = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Price"].Value);
                    orderDetail2.Amount = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Amount"].Value);
                    orderDetail2.ReturnFlag = grid_OrderDetail.Rows[i].Cells["Return"].Value.ToString();
                    orderDetail2.Remark = grid_OrderDetail.Rows[i].Cells["RM"].Value.ToString();
                    orderDetail2.CreateUserID = GATE.userID;
                    orderDetail2.Status = grid_OrderDetail.Rows[i].Cells["Status"].Value.ToString();

                    //connSalesOrder.sp_UPDATE_InvoiceDetail(orderDetail2);

                    
                    //onhand delete
                    //connSalesOrder.sp_UPDATE_DeleteOnhand(orderDetail2.ProductID, orderDetail2.OrderQty);
                }

                //Save finished
                MessageBox.Show("인보이스 생성 " + order2.OrderID + " has been Updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //flag 업데이트
                connSalesOrder.sp_UPDATE_DeliveryStatus(order2.OrderID);

                Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void AuditSalesOrder_Load(object sender, EventArgs e)
        {
            //ipad order number occupied
        }

        private void AuditSalesOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ipad order number release
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grid_OrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 14) // Delete button
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure delete item from this order?"
                                                        , "Confirming", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    DataTable dt = this.grid_OrderDetail.DataSource as DataTable;
                    DataRow dr = dt.NewRow();
                    dt.Rows.RemoveAt(e.RowIndex);
                    Audit();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                Audit();

            }
        }

        private void cbo_itemID_Enter(object sender, EventArgs e)
        {
            cbo_itemID.DroppedDown = true;
        }

        private void cbo_itemID_SelectedValueChanged(object sender, EventArgs e)
        {
            //String ProductKey = connSalesOrder.getProductKeyFromItemID(cbo_itemID.Text);
            //txt_productKey.Text = ProductKey;

            String ItemDesc = connSalesOrder.getItemDescFromItemID(cbo_itemID.Text);
            txt_itemDesc.Text = ItemDesc;

            String ItemUnit = connSalesOrder.getItemUnitFromItemID(cbo_itemID.Text);
            txt_unit.Text = ItemUnit;

            String PackSize = connSalesOrder.getItemPackSizeFromItemID(cbo_itemID.Text);
            txt_packSize.Text = PackSize;
            
            Decimal UnitPrice = Convert.ToDecimal(connSalesOrder.getItemUnitPriceFromItemID(cbo_itemID.Text));
            txt_unitPrice.Text = UnitPrice.ToString("N2");
            txt_price.Text = UnitPrice.ToString("N2");

            Decimal BottomPrice = Convert.ToDecimal(connSalesOrder.getItemBottomPriceFromItemID(cbo_itemID.Text));
            txt_bottomPrice.Text = BottomPrice.ToString("N2");

            Decimal Onhand = Convert.ToDecimal(connSalesOrder.getItemOnhandFromItemID(cbo_itemID.Text));
            txt_onhand.Text = Onhand.ToString("N2");

            Decimal Inner = Convert.ToDecimal(connSalesOrder.getItemInnerFromItemID(cbo_itemID.Text));
            txt_inner.Text = Inner.ToString("N2");

            txt_RM.Text = "RR";

        }

        private void txt_qty_Leave(object sender, EventArgs e)
        {
            calculateAddItemPrice();
        }
        

        private void txt_price_Leave(object sender, EventArgs e)
        {
            calculateAddItemPrice();
        }

        private void txt_RM_Leave(object sender, EventArgs e)
        {
            calculateAddItemPrice();
        }

        private void calculateAddItemPrice()
        {
            try
            {
                Decimal Qty = Convert.ToDecimal(txt_qty.Text);
                Decimal Price = Convert.ToDecimal(txt_price.Text);
                Decimal Amount = Qty * Price;
                String Remark = txt_RM.Text;
                if (Remark == "PF")
                {
                    txt_addAmount.Text = "0.00";
                }
                else
                {
                    txt_addAmount.Text = Amount.ToString("N2");
                }
            }
            catch
            {

            }
            
            
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            try
            { 
                DataTable dt = this.grid_OrderDetail.DataSource as DataTable;
                DataRow dr = dt.NewRow();

                int OrderDetailKey = 2222;
                String ProductID = cbo_itemID.Text;
                //Decimal ProductKey = Convert.ToDecimal(txt_productKey.Text);
                Decimal Quantity = Convert.ToDecimal(txt_qty.Text);
                String ProductDesc = txt_itemDesc.Text;
                String SUnitM = txt_unit.Text;
                String StrPackSize = txt_packSize.Text;
                Decimal Price = Convert.ToDecimal(txt_price.Text);
                Decimal Amount = Convert.ToDecimal(txt_addAmount.Text);
                String flRemark = txt_RM.Text;
                Decimal UnitPr = Convert.ToDecimal(txt_unitPrice.Text);
                Decimal BottomPr = Convert.ToDecimal(txt_bottomPrice.Text);
                Decimal QtyOnHand = Convert.ToDecimal(txt_onhand.Text);
                Decimal LastOutCost = Convert.ToDecimal(txt_inner.Text);
                String ReturnFlag = "N";
            

                dr["OrderDetailKey"] = OrderDetailKey;
                dr["ProductID"] = ProductID;
                //dr["ProductKey"] = ProductKey;
                dr["OrderQty"] = Quantity;
                dr["ProductDesc"] = ProductDesc;
                dr["SUnitM"] = SUnitM;
                dr["StrPackSize"] = StrPackSize;
                dr["Price"] = Price;
                dr["Amount"] = Amount;
                dr["Remark"] = flRemark;
                dr["UnitPr"] = UnitPr;
                dr["BottomPr"] = BottomPr;
                dr["QtyOnHand"] = QtyOnHand;
                dr["LastOutCost"] = LastOutCost;
                dr["ReturnFlag"] = ReturnFlag;
                dt.Rows.Add(dr);
                //dt.Rows.InsertAt(dr, grid_RouteDetail.ColumnCount + 1);
                Audit();
            }
            catch
            {
                MessageBox.Show("Input all item try to add info", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }
    }
}
