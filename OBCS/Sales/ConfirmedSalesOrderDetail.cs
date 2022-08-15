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
using static OBCS.conn;

namespace OBCS.Sales
{
    public partial class ConfirmedSalesOrderDetail : Form
    {
        Entities.Order2 order2 = new Entities.Order2();
        public ConfirmedSalesOrderDetail(String OrderID)
        {
            InitializeComponent();
            grid_OrderDetail_Init();
            grid_return_Init();
            txt_orderID.Text = OrderID;
            connSalesOrder.sp_Fetch_OrderDetail2(grid_OrderDetail, OrderID);
            connSalesOrder.sp_Fetch_OrderReturnDetail(grid_return, OrderID);

            order2 = connSalesOrder.sp_Fetch_Order2Info(OrderID);

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

            txt_AuditMemo.Text = order2.AuditMemo;
            cbo_auditConfirm.Text = order2.AuditConfirm;
            txt_paymentTerm.Text = order2.PaymentTermKey;

            //아이템 가져오기
            connSalesOrder.cbo_itemID(cbo_itemID);

            cbo_RM.Items.Add("RR");
            cbo_RM.Items.Add("PF");
        }

        private void grid_OrderDetail_Init()
        {
            grid_OrderDetail.AutoGenerateColumns = false;
            grid_OrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_OrderDetail.ColumnCount = 18;

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
            grid_OrderDetail.Columns[9].Visible = false;
            grid_OrderDetail.Columns[9].ReadOnly = true;
            grid_OrderDetail.Columns[9].Width = 30;
            grid_OrderDetail.Columns[9].DataPropertyName = "";

            grid_OrderDetail.Columns[10].Name = "List Price";
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

            grid_OrderDetail.Columns[13].Name = "Available Onhand";
            grid_OrderDetail.Columns[13].ReadOnly = true;
            grid_OrderDetail.Columns[13].Width = 60;
            grid_OrderDetail.Columns[13].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[13].DataPropertyName = "AvailableOnhand";

            grid_OrderDetail.Columns[14].Name = "Inner";
            grid_OrderDetail.Columns[14].ReadOnly = true;
            grid_OrderDetail.Columns[14].Width = 50;
            grid_OrderDetail.Columns[14].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[14].DataPropertyName = "LastOutCost";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 50;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_OrderDetail.Columns["Delete"] == null)

            {
                grid_OrderDetail.Columns.Insert(15, deleteButton);
            }


            grid_OrderDetail.Columns[16].Name = "Return";
            grid_OrderDetail.Columns[16].Visible = false;
            grid_OrderDetail.Columns[16].DataPropertyName = "ReturnFlag";
        
            grid_OrderDetail.Columns[17].Name = "ProductKey";
            grid_OrderDetail.Columns[17].Visible = false;
            grid_OrderDetail.Columns[17].DataPropertyName = "ItemKey";

            grid_OrderDetail.Columns[18].Name = "Status";
            grid_OrderDetail.Columns[18].Visible = false;
            grid_OrderDetail.Columns[18].DataPropertyName = "Status";


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

            if (grid_OrderDetail.CurrentRow.Cells["RM"].Value.ToString() == "RR")
            {
                amount = orderQty * price;
                grid_OrderDetail.CurrentRow.Cells["Amount"].Value = amount;
            }
            else if(grid_OrderDetail.CurrentRow.Cells["RM"].Value.ToString() == "PF")
            {
                amount = 0;
                grid_OrderDetail.CurrentRow.Cells["Amount"].Value = amount;
            }

            //Audit();
        }

        private void grid_return_Init()
        {
            grid_return.AutoGenerateColumns = false;
            grid_return.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_return.ColumnCount = 17;

            grid_return.Columns[0].Name = "No.";
            grid_return.Columns[0].ReadOnly = true;
            grid_return.Columns[0].Width = 30;
            grid_return.Columns[0].DataPropertyName = "OrderDetailKey";

            grid_return.Columns[1].Name = "Item ID";
            grid_return.Columns[1].ReadOnly = true;
            grid_return.Columns[1].Width = 100;
            grid_return.Columns[1].DataPropertyName = "ProductID";

            grid_return.Columns[2].Name = "Qty";
            grid_return.Columns[2].Width = 50;
            grid_return.Columns[2].DefaultCellStyle.Format = "N2";
            grid_return.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[2].DataPropertyName = "OrderQty";

            grid_return.Columns[3].Name = "Item Desc";
            grid_return.Columns[3].ReadOnly = true;
            grid_return.Columns[3].Width = 300;
            grid_return.Columns[3].DataPropertyName = "ProductDesc";

            grid_return.Columns[4].Name = "Unit";
            grid_return.Columns[4].ReadOnly = true;
            grid_return.Columns[4].Width = 30;
            grid_return.Columns[4].DataPropertyName = "SUnitM";

            grid_return.Columns[5].Name = "Pack Size";
            grid_return.Columns[5].ReadOnly = true;
            grid_return.Columns[5].Width = 90;
            grid_return.Columns[5].DataPropertyName = "StrPackSize";

            grid_return.Columns[6].Name = "Price";
            grid_return.Columns[6].Width = 60;
            grid_return.Columns[6].DefaultCellStyle.Format = "N2";
            grid_return.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[6].DataPropertyName = "Price";

            grid_return.Columns[7].Name = "Amount";
            grid_return.Columns[7].ReadOnly = true;
            grid_return.Columns[7].Width = 60;
            grid_return.Columns[7].DefaultCellStyle.Format = "N2";
            grid_return.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[7].DataPropertyName = "Amount";

            grid_return.Columns[8].Name = "RM";
            grid_return.Columns[8].Width = 30;
            grid_return.Columns[8].DataPropertyName = "Remark";

            grid_return.Columns[9].Name = "PF";
            grid_return.Columns[9].Visible = false;
            grid_return.Columns[9].ReadOnly = true;
            grid_return.Columns[9].Width = 30;
            grid_return.Columns[9].DataPropertyName = "";

            grid_return.Columns[10].Name = "List Price";
            grid_return.Columns[10].ReadOnly = true;
            grid_return.Columns[10].Width = 60;
            grid_return.Columns[10].DefaultCellStyle.Format = "N2";
            grid_return.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[10].DataPropertyName = "UnitPr";

            grid_return.Columns[11].Name = "Bottom Price";
            grid_return.Columns[11].ReadOnly = true;
            grid_return.Columns[11].Width = 60;
            grid_return.Columns[11].DefaultCellStyle.Format = "N2";
            grid_return.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[11].DataPropertyName = "BottomPr";

            grid_return.Columns[12].Name = "Onhand";
            grid_return.Columns[12].ReadOnly = true;
            grid_return.Columns[12].Width = 60;
            grid_return.Columns[12].DefaultCellStyle.Format = "N2";
            grid_return.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[12].DataPropertyName = "QtyOnHand";
            
            grid_return.Columns[13].Name = "Inner";
            grid_return.Columns[13].ReadOnly = true;
            grid_return.Columns[13].Width = 50;
            grid_return.Columns[13].DefaultCellStyle.Format = "N2";
            grid_return.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_return.Columns[13].DataPropertyName = "LastOutCost";

            //DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            //deleteButton.Width = 50;
            //deleteButton.Name = "Delete";
            //deleteButton.Text = "Delete";
            //deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //deleteButton.UseColumnTextForButtonValue = true;
            //if (grid_return.Columns["Delete"] == null)

            //{
            //    grid_return.Columns.Insert(14, deleteButton);
            //}

            grid_return.Columns[14].Name = "Return";
            grid_return.Columns[14].Visible = false;
            grid_return.Columns[14].DataPropertyName = "ReturnFlag";

            grid_return.Columns[15].Name = "ProductKey";
            grid_return.Columns[15].Visible = false;
            grid_return.Columns[15].DataPropertyName = "ItemKey";

            grid_return.Columns[16].Name = "Status";
            grid_return.Columns[16].Visible = false;
            grid_return.Columns[16].DataPropertyName = "Status";

            //grid font size custom
            grid_return.RowTemplate.Height = 20;
            grid_return.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_return.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_return.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_return_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string orderQtyString = grid_return.CurrentRow.Cells["Qty"].Value.ToString();
            double orderQty = Convert.ToDouble(orderQtyString);

            string priceString = grid_return.CurrentRow.Cells["Price"].Value.ToString();
            double price = Convert.ToDouble(priceString);

            string amountString = grid_return.CurrentRow.Cells["Amount"].Value.ToString();
            double amount = Convert.ToDouble(amountString);

            if (grid_return.CurrentRow.Cells["RM"].Value.ToString() == "RR")
            {
                amount = orderQty * price;
                grid_return.CurrentRow.Cells["Amount"].Value = amount;
            }

            //Audit();
        }

        private void Audit()
        {
            //Total Amount
            Decimal Amount = 0;
            for (int i = 0; i < grid_OrderDetail.RowCount; i++)
            {
                string ProductID = grid_OrderDetail.Rows[i].Cells["Item ID"].Value.ToString();
                decimal price = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Price"].Value);
                decimal bottomPrice = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Bottom Price"].Value);
                decimal unitPrice = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["List Price"].Value);
                decimal qty = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Qty"].Value);
                decimal onhand = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Available Onhand"].Value);
                string Remark = grid_OrderDetail.Rows[i].Cells["RM"].Value.ToString();
                string ReturnFlag = grid_OrderDetail.Rows[i].Cells["Return"].Value.ToString();
                string status = grid_OrderDetail.Rows[i].Cells["Status"].Value.ToString();

                Decimal TotalOrderQty = GetTotalOrderQty(i);


                if (TotalOrderQty > onhand)
                {
                    bool promoitem = false;
                    for (int k = 0; k < grid_OrderDetail.RowCount; k++)
                    {
                        string PFProductID = grid_OrderDetail.Rows[k].Cells["Item ID"].Value.ToString();
                        string PFReturnFlag = grid_OrderDetail.Rows[k].Cells["Return"].Value.ToString();
                        if (i != k && ProductID.Trim() == PFProductID.Trim() && ReturnFlag == "N")
                        {
                            promoitem = true;
                            break;
                        }
                    }

                    if (promoitem == false)
                    {
                        grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.Violet;
                        grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.MediumOrchid;
                        grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                    }
                    else
                    {
                        grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.HotPink;
                        grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DeepPink;
                        grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                        for (int j = 0; j < grid_OrderDetail.RowCount; j++)
                        {
                            string PFProductID = grid_OrderDetail.Rows[j].Cells["Item ID"].Value.ToString();
                            string PFReturnFlag = grid_OrderDetail.Rows[j].Cells["Return"].Value.ToString();
                            if (i != j && ProductID.Trim() == PFProductID.Trim() && PFReturnFlag == "N")
                            {
                                grid_OrderDetail.Rows[j].DefaultCellStyle.BackColor = Color.HotPink;
                                grid_OrderDetail.Rows[j].DefaultCellStyle.SelectionBackColor = Color.DeepPink;
                                grid_OrderDetail.Rows[j].DefaultCellStyle.SelectionForeColor = Color.White;
                            }
                        }
                    }

                }
                else
                {

                    if (Remark == "PF")
                    {
                        grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                        grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DarkGoldenrod;
                        grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                    }
                    else
                    {
                        if (price < bottomPrice && Remark == "RR")
                        {
                            grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
                            grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                            grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                        }
                        else
                        {
                            grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightGray;
                            grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;
                        }
                    }
                }

                if (ReturnFlag == "Y")
                {
                    grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.DarkGray;
                    grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Gray;
                    grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                }

                if (status == "OS")
                {
                    grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.CornflowerBlue;
                }

                //GET Amount
                if (ReturnFlag == "N")
                {
                    Amount += Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Amount"].Value);
                }

            }

            for (int i = 0; i < grid_return.RowCount; i++)
            {
                grid_return.Rows[i].DefaultCellStyle.BackColor = Color.DarkGray;
                grid_return.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Gray;
                grid_return.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
            }
            
            Decimal ReturnAmount = 0;
            
            for (int i = 0; i < grid_return.Rows.Count; i++)
            {
                ReturnAmount += Convert.ToDecimal(grid_return.Rows[i].Cells["Amount"].Value);
            }
            
            txt_amount.Text = Amount.ToString("N2");

            //get Credit Amount
            Decimal creditAmount = Convert.ToDecimal(connSalesOrder.getCreditAmountFromOrder2(txt_orderID.Text.Trim()));
            txt_creditAmount.Text = creditAmount.ToString("N2");
            txt_return.Text = ReturnAmount.ToString("N2");

            Decimal SalesTotal = Amount - creditAmount - ReturnAmount;
            txt_salesTotal.Text = SalesTotal.ToString("N2");
        }

        private Decimal GetTotalOrderQty(int ROWNO)
        {
            string ProductID = grid_OrderDetail.Rows[ROWNO].Cells["Item ID"].Value.ToString();
            decimal price = Convert.ToInt32(grid_OrderDetail.Rows[ROWNO].Cells["Price"].Value);
            decimal bottomPrice = Convert.ToInt32(grid_OrderDetail.Rows[ROWNO].Cells["Bottom Price"].Value);
            decimal qty = Convert.ToInt32(grid_OrderDetail.Rows[ROWNO].Cells["Qty"].Value);
            decimal onhand = Convert.ToInt32(grid_OrderDetail.Rows[ROWNO].Cells["Available Onhand"].Value);
            string Remark = grid_OrderDetail.Rows[ROWNO].Cells["RM"].Value.ToString();

            Decimal TotalOrderQty = qty;

            if (Remark == "RR")
            {
                for (int j = 0; j < grid_OrderDetail.RowCount; j++)
                {
                    string PFProductID = grid_OrderDetail.Rows[j].Cells["Item ID"].Value.ToString();
                    decimal PFqty = Convert.ToInt32(grid_OrderDetail.Rows[j].Cells["Qty"].Value);
                    string PFRemark = grid_OrderDetail.Rows[j].Cells["RM"].Value.ToString();

                    if (ProductID.Trim() == PFProductID.Trim() && PFRemark == "PF")
                    {
                        TotalOrderQty = TotalOrderQty + PFqty;
                    }

                }
            }

            else if (Remark == "PF")
            {
                for (int j = 0; j < grid_OrderDetail.RowCount; j++)
                {
                    string PFProductID = grid_OrderDetail.Rows[j].Cells["Item ID"].Value.ToString();
                    decimal PFqty = Convert.ToInt32(grid_OrderDetail.Rows[j].Cells["Qty"].Value);
                    string PFRemark = grid_OrderDetail.Rows[j].Cells["RM"].Value.ToString();

                    if (ProductID.Trim() == PFProductID.Trim() && PFRemark == "RR")
                    {
                        TotalOrderQty = TotalOrderQty + PFqty;
                    }
                }
            }

            //MessageBox.Show(ROWNO + " " + TotalOrderQty);
            return TotalOrderQty;

        }


        private void grid_OrderDetail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grid_OrderDetail.ClearSelection();
            Audit();
        }

        private void grid_return_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grid_return.ClearSelection();
            //Audit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
            {
                string ProductID = grid_OrderDetail.Rows[i].Cells["Item ID"].Value.ToString();
                Decimal NewOnhand = Convert.ToDecimal(connSalesOrder.getItemOnhandFromItemID(ProductID));
                Decimal NewAvailableOnhand = connSalesOrder.sp_GET_GlobalQty(txt_orderID.Text.Trim().ToString(), ProductID);
                grid_OrderDetail.Rows[i].Cells["Onhand"].Value = NewOnhand;
                grid_OrderDetail.Rows[i].Cells["Available Onhand"].Value = NewAvailableOnhand;
            }

            Audit();

            for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
            {
                if (grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor == Color.HotPink ||
                    grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor == Color.Violet)
                {
                    MessageBox.Show("Order quantity is greater than onhand quantity."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            //Update Order Details
            DialogResult dialogResult = MessageBox.Show("Are you sure update this order?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //수정한 user, 시간 저장
                order2.OrderID = txt_orderID.Text.Trim();
                order2.BillAddress1 = txt_billAddress1.Text.Trim();
                order2.BillAddress2 = txt_billAddress2.Text.Trim();
                order2.BillCity = txt_billCity.Text.Trim();
                order2.BillState = txt_billStateCode.Text.Trim();
                order2.BillZip = txt_billPostalCode.Text.Trim();
                order2.ShipAddress1 = txt_shipAddress1.Text.Trim();
                order2.ShipAddress2 = txt_shipAddress2.Text.Trim();
                order2.ShipCity = txt_shipCity.Text.Trim();
                order2.ShipState = txt_shipStateCode.Text.Trim();
                order2.ShipZip = txt_shipPostalCode.Text.Trim();
                order2.OrderDate = Convert.ToDateTime(txt_orderDate.Text);
                order2.AuditMemo = txt_AuditMemo.Text.Trim();
                order2.AuditConfirm = cbo_auditConfirm.Text.Trim();
                
                connSalesOrder.sp_UPDATE_Order2(order2);

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

                    connSalesOrder.sp_UPDATE_OrderDetail2(orderDetail2);

                    //onhand delete
                    //connSalesOrder.sp_UPDATE_DeleteOnhand(orderDetail2.ProductID, orderDetail2.OrderQty);
                }

                //Save finished
                //MessageBox.Show("The order, " + order2.OrderID + " has been Updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //String RefNumber = txt_orderID.Text.Trim();
                //connSalesOrder.sp_OCCUPIED_FINISHED(RefNumber);
                //bOccupied = true;

                Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        String occupied;
        bool bOccupied = false;
        private void AuditSalesOrder_Load(object sender, EventArgs e)
        {
            //ipad order number occupied
            //occupied check
            String RefNumber = txt_orderID.Text.Trim();
            occupied = connSalesOrder.sp_OCCUPIED_CHECK(RefNumber);

            if (occupied == "Occupying")
            {
                btn_save.Enabled = false;
                MessageBox.Show("Someone occupying this reference number.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                bOccupied = true;
            }
            else if (occupied == "Finished")
            {
                btn_save.Enabled = false;
                MessageBox.Show("This reference number is already closed.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                bOccupied = true;

            }

            //// 8/3/2021 온핸드 검사하기전에 온핸드 경고 색이 표시되서 들어갈때 검사

            //for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
            //{
            //    string ProductID = grid_OrderDetail.Rows[i].Cells["Item ID"].Value.ToString();
            //    Decimal NewOnhand = Convert.ToDecimal(connSalesOrder.getItemOnhandFromItemID(ProductID));
            //    Decimal NewAvailableOnhand = connSalesOrder.sp_GET_GlobalQty(txt_orderID.Text.Trim().ToString(), ProductID);
            //    grid_OrderDetail.Rows[i].Cells["Onhand"].Value = NewOnhand;
            //    grid_OrderDetail.Rows[i].Cells["Available Onhand"].Value = NewAvailableOnhand;
            //}

            //Audit();

            //for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
            //{
            //    if (grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor == Color.HotPink ||
            //        grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor == Color.Violet)
            //    {
            //        MessageBox.Show("Order quantity is greater than onhand quantity."
            //                                            , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        return;
            //    }
            //}
        }

        private void AuditSalesOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ipad order number release
            //MessageBox.Show("Close");
            if (bOccupied == false)
            {
                String RefNumber = txt_orderID.Text.Trim();
                connSalesOrder.sp_OCCUPIED_RELEASE(RefNumber);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grid_OrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 15 && e.RowIndex >= 0) // Delete button
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure delete item from this order?"
                                                        , "Confirming", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //DataTable dt = this.grid_OrderDetail.DataSource as DataTable;
                    //DataRow dr = dt.NewRow();
                    //dt.Rows.RemoveAt(e.RowIndex);
                    //Audit();
                    grid_OrderDetail.Rows.RemoveAt(e.RowIndex);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                //Audit();
            }
        }

        private void grid_return_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 14 && e.RowIndex >= 0) // Delete button
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure delete item from this order?"
                                                        , "Confirming", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    DataTable dt = this.grid_return.DataSource as DataTable;
                    DataRow dr = dt.NewRow();
                    dt.Rows.RemoveAt(e.RowIndex);
                    Audit();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                //Audit();

            }
        }

        private void cbo_itemID_Enter(object sender, EventArgs e)
        {
            cbo_itemID.DroppedDown = true;
        }

        private void cbo_itemID_SelectedValueChanged(object sender, EventArgs e)
        {
            fillAddItemInfo();
            calculateAddItemPrice();
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

        private void cbo_RM_Leave(object sender, EventArgs e)
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
                String Remark = cbo_RM.Text;
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
            if (cbo_RM.Text.Trim() != "PF")
            {
                for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
                {
                    if (grid_OrderDetail.Rows[i].Cells["RM"].Value.ToString().Trim() == "RR" && grid_OrderDetail.Rows[i].Cells["Item ID"].Value.ToString().Trim() == cbo_itemID.Text.Trim())
                    {
                        MessageBox.Show(cbo_itemID.Text.Trim() + " is already in order detail.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        return;
                    }
                }
            }
            else
            {
                for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
                {
                    if (grid_OrderDetail.Rows[i].Cells["RM"].Value.ToString().Trim() == "PF" && grid_OrderDetail.Rows[i].Cells["Item ID"].Value.ToString().Trim() == cbo_itemID.Text.Trim())
                    {
                        MessageBox.Show(cbo_itemID.Text.Trim() + " is already in order detail(PF).", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        return;
                    }
                }
            }
            
            
            try
            {
                DataTable dt = this.grid_OrderDetail.DataSource as DataTable;
                DataRow dr = dt.NewRow();

                //get new orderDetailKey
                String NewOrderDetailKey = connSalesOrder.sp_GET_NewOrderDetailKey();

                int OrderDetailKey = Convert.ToInt32(Convert.ToDecimal(NewOrderDetailKey));
                String ProductID = cbo_itemID.Text;
                //Decimal ProductKey = Convert.ToDecimal(txt_productKey.Text);
                Decimal Quantity = Convert.ToDecimal(txt_qty.Text);
                String ProductDesc = txt_itemDesc.Text;
                String SUnitM = txt_unit.Text;
                String StrPackSize = txt_packSize.Text;
                Decimal Price = Convert.ToDecimal(txt_price.Text);
                Decimal Amount = Convert.ToDecimal(txt_addAmount.Text);
                String flRemark = cbo_RM.Text;
                Decimal UnitPr = Convert.ToDecimal(txt_unitPrice.Text);
                Decimal BottomPr = Convert.ToDecimal(txt_bottomPrice.Text);
                Decimal QtyOnHand = Convert.ToDecimal(txt_onhand.Text);
                Decimal LastOutCost = Convert.ToDecimal(txt_inner.Text);
                Decimal AvailableOnhand = Convert.ToDecimal(txt_availableOnhand.Text);
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
                dr["AvailableOnhand"] = AvailableOnhand;
                
                dt.Rows.Add(dr);
                //dt.Rows.InsertAt(dr, grid_RouteDetail.ColumnCount + 1);
                //Audit();
            }
            catch
            {
                MessageBox.Show("Input all item info", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void fillAddItemInfo()
        {
            try
            {
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

                Decimal AvailableOnhand = connSalesOrder.sp_GET_GlobalQty(txt_orderID.Text.Trim().ToString(), cbo_itemID.Text.Trim().ToString());
                txt_availableOnhand.Text = AvailableOnhand.ToString("N2");

                Decimal Inner = Convert.ToDecimal(connSalesOrder.getItemInnerFromItemID(cbo_itemID.Text));
                txt_inner.Text = Inner.ToString("N2");

                cbo_RM.Text = "RR";
            }
            catch
            {
                //MessageBox.Show("Input all item try to add info", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        
        private void grid_OrderDetail_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //this.grid_OrderDetail.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }



        private void cbo_itemID_Leave(object sender, EventArgs e)
        {
            fillAddItemInfo();
        }

        private void cbo_RM_Enter(object sender, EventArgs e)
        {
            cbo_itemID.DroppedDown = true;
        }

        private void cbo_RM_SelectedValueChanged(object sender, EventArgs e)
        {
            calculateAddItemPrice();
        }

        
    }
}
