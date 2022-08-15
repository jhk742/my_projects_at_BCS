using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;
using OBCS.Entities;
using static OBCS.conn;

namespace OBCS.Sales
{
    public partial class AuditSalesOrderDetail : Form
    {
        iPadSalesOrder iPadSalesOrder = new iPadSalesOrder();

        public AuditSalesOrderDetail(String iPadOrderID)
        {
            InitializeComponent();
            
            grid_OrderDetail_Init();
            
            txt_iPadOrderID.Text = iPadOrderID;
            connSalesOrder.sp_Fetch_iPadSalesOrderDetail(grid_OrderDetail, iPadOrderID);

            iPadSalesOrder = connSalesOrder.sp_Fetch_iPadSalesOrderInfo(iPadOrderID);

            txt_customerID.Text = iPadSalesOrder.CustomerID;
            txt_company.Text = iPadSalesOrder.CompanyName;
            txt_orderMemo.Text = iPadSalesOrder.OrdMemo;
            txt_billAddress1.Text = iPadSalesOrder.BillAddress1;
            txt_billAddress2.Text = iPadSalesOrder.BillAddress2;
            txt_billCity.Text = iPadSalesOrder.BillCityName;
            txt_billStateCode.Text = iPadSalesOrder.BillStateCode;
            txt_billPostalCode.Text = iPadSalesOrder.BillPostalCode;
            txt_shipAddress1.Text = iPadSalesOrder.ShipAddress1;
            txt_shipAddress2.Text = iPadSalesOrder.ShipAddress2;
            txt_shipCity.Text = iPadSalesOrder.ShipCityName;
            txt_shipStateCode.Text = iPadSalesOrder.ShipStateCode;
            txt_shipPostalCode.Text = iPadSalesOrder.ShipPostalCode;
            txt_orderDate.Text = iPadSalesOrder.OrderDate.ToString();
            txt_saleRep.Text = iPadSalesOrder.SaleRepID.ToString();
            txt_creditAmount.Text = iPadSalesOrder.CrAmt.ToString("N2");
            txt_paymentTerm.Text = iPadSalesOrder.TermName.Trim();

            //아이템 가져오기
            connSalesOrder.cbo_itemID(cbo_itemID);

            //confirm 가져오기
            cbo_auditConfirm.Items.Add("Admin1");
            cbo_auditConfirm.Items.Add("Admin2");

            cbo_RM.Items.Add("RR");
            cbo_RM.Items.Add("PF");

            this.CenterToScreen();

            grid_invoice_Init();
            connSalesOrder.sp_PAYMENT_INVOICE(grid_invoice, iPadSalesOrder.CustomerID, "");
            finished = false;
        }

        private void grid_OrderDetail_Init()
        {
            grid_OrderDetail.AutoGenerateColumns = false;
            grid_OrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //detail grid multi line allow
            //grid_OrderDetail.AllowDrop = true;
            //grid_OrderDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //grid_OrderDetail.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            grid_OrderDetail.ColumnCount = 16;

            grid_OrderDetail.Columns[0].Name = "No.";
            grid_OrderDetail.Columns[0].ReadOnly = true;
            grid_OrderDetail.Columns[0].Width = 40;
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
            grid_OrderDetail.Columns[2].DataPropertyName = "Quantity";

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
            grid_OrderDetail.Columns[8].DataPropertyName = "flRemark";

            grid_OrderDetail.Columns[9].Name = "PF";
            grid_OrderDetail.Columns[9].Visible = false;
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

            grid_OrderDetail.Columns[13].Name = "Inner";
            grid_OrderDetail.Columns[13].ReadOnly = true;
            grid_OrderDetail.Columns[13].Width = 50;
            grid_OrderDetail.Columns[13].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[13].DataPropertyName = "ItemPack";

            //Order Add
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 50;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_OrderDetail.Columns["Delete"] == null)
            {
                grid_OrderDetail.Columns.Insert(14, deleteButton);
            }

            grid_OrderDetail.Columns[15].Name = "Return";
            grid_OrderDetail.Columns[15].Visible = false;
            grid_OrderDetail.Columns[15].DataPropertyName = "ReturnFlag";

            grid_OrderDetail.Columns[16].Name = "ProductKey";
            grid_OrderDetail.Columns[16].Visible = false;
            grid_OrderDetail.Columns[16].DataPropertyName = "ItemKey";

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

        private void grid_invoice_Init()
        {
            grid_invoice.AutoGenerateColumns = false;
            grid_invoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_invoice.ColumnCount = 3;

            grid_invoice.Columns[0].Name = "No.";
            grid_invoice.Columns[0].ReadOnly = true;
            //grid_invoice.Columns[0].Width = 40;
            grid_invoice.Columns[0].DataPropertyName = "NUM_0";

            grid_invoice.Columns[1].Name = "Date";
            grid_invoice.Columns[1].ReadOnly = true;
            //grid_invoice.Columns[1].Width = 100;
            grid_invoice.Columns[1].DataPropertyName = "ACCDAT_0";

            grid_invoice.Columns[2].Name = "Amount";
            grid_invoice.Columns[2].ReadOnly = true;
            //grid_invoice.Columns[2].Width = 50;
            grid_invoice.Columns[2].DefaultCellStyle.Format = "N2";
            grid_invoice.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_invoice.Columns[2].DataPropertyName = "AMTATI_0";

            //grid font size custom
            grid_invoice.RowTemplate.Height = 20;
            grid_invoice.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_invoice.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 7F, FontStyle.Bold);
            }

            grid_invoice.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 7F, FontStyle.Bold);
        }

        private void grid_OrderDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string orderQtyString = grid_OrderDetail.CurrentRow.Cells["Qty"].Value.ToString().Trim();
            double orderQty = Convert.ToDouble(orderQtyString);

            string priceString = grid_OrderDetail.CurrentRow.Cells["Price"].Value.ToString().Trim();
            double price = Convert.ToDouble(priceString);

            string amountString = grid_OrderDetail.CurrentRow.Cells["Amount"].Value.ToString().Trim();
            double amount = Convert.ToDouble(amountString);

            if (grid_OrderDetail.CurrentRow.Cells["RM"].Value.ToString().Trim() == "RR")
            {
                amount = orderQty * price;
                grid_OrderDetail.CurrentRow.Cells["Amount"].Value = amount;
            }
            else if (grid_OrderDetail.CurrentRow.Cells["RM"].Value.ToString().Trim() == "PF")
            {
                amount = 0;
                grid_OrderDetail.CurrentRow.Cells["Amount"].Value = amount;
            }
            //Audit();
        }
        private void Audit()
        {
            //Total Amount
            Decimal Amount = 0;
            for (int i = 0; i < grid_OrderDetail.RowCount; i++)
            {
                string ProductID = grid_OrderDetail.Rows[i].Cells["Item ID"].Value.ToString().Trim();
                decimal price = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Price"].Value);
                decimal bottomPrice = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Bottom Price"].Value);
                decimal unitPrice = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["List Price"].Value);
                decimal qty = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Qty"].Value);
                decimal onhand = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Onhand"].Value);
                string Remark = grid_OrderDetail.Rows[i].Cells["RM"].Value.ToString().Trim();
                string ReturnFlag = grid_OrderDetail.Rows[i].Cells["Return"].Value.ToString().Trim();

                Decimal TotalOrderQty = GetTotalOrderQty(i);
                if (TotalOrderQty > onhand)
                {
                    bool promoitem = false;
                    for (int k = 0; k < grid_OrderDetail.RowCount; k++)
                    {
                        string PFProductID = grid_OrderDetail.Rows[k].Cells["Item ID"].Value.ToString().Trim();
                        string PFReturnFlag = grid_OrderDetail.Rows[k].Cells["Return"].Value.ToString().Trim();
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
                            string PFProductID = grid_OrderDetail.Rows[j].Cells["Item ID"].Value.ToString().Trim();
                            string PFReturnFlag = grid_OrderDetail.Rows[j].Cells["Return"].Value.ToString().Trim();
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

                //return
                if (ReturnFlag == "Y")
                {
                    grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.DarkGray;
                    grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Gray;
                    grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                }

                //GET Amount
                if (ReturnFlag == "N")
                {
                    Amount += Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Amount"].Value);
                }
            }

            txt_amount.Text = Amount.ToString("N2");

            ////get Credit Amount
            //Decimal creditAmount = Convert.ToDecimal(connSalesOrder.getCreditAmount(txt_iPadOrderID.Text.Trim()));
            //txt_creditAmount.Text = creditAmount.ToString("N2");
            try
            {
                Decimal SalesTotal = Amount - Convert.ToDecimal(txt_creditAmount.Text.Trim());
                txt_salesTotal.Text = SalesTotal.ToString("N2");
            }
            catch
            {
                txt_salesTotal.Text = Amount.ToString("N2");
            }

            //foreach (DataGridViewRow item in grid_OrderDetail.Rows)
            //{
            //    if (item.DefaultCellStyle.BackColor == Color.IndianRed)
            //    {
                    
            //        item.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            //        item.DefaultCellStyle.SelectionForeColor = Color.White;
            //    }
            //    else if(item.DefaultCellStyle.BackColor == Color.Gold)
            //    {
            //        item.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            //        item.DefaultCellStyle.SelectionForeColor = Color.White;
            //    }
            //    else if (item.DefaultCellStyle.BackColor == Color.HotPink)
            //    {
            //        item.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            //        item.DefaultCellStyle.SelectionForeColor = Color.White;
            //    }
            //    else if (item.DefaultCellStyle.BackColor == Color.HotPink)
            //    {
            //        item.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            //        item.DefaultCellStyle.SelectionForeColor = Color.White;
            //    }
            //    else if (item.DefaultCellStyle.BackColor == Color.HotPink)
            //    {
            //        item.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            //        item.DefaultCellStyle.SelectionForeColor = Color.White;
            //    }
            //    else
            //    {
            //        item.DefaultCellStyle.BackColor = Color.Empty;
            //        item.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            //        item.DefaultCellStyle.SelectionForeColor = Color.Black;
            //    }
            //}

        }

        private Decimal GetTotalOrderQty(int ROWNO)
        {
            string ProductID = grid_OrderDetail.Rows[ROWNO].Cells["Item ID"].Value.ToString().Trim();
            decimal price = Convert.ToInt32(grid_OrderDetail.Rows[ROWNO].Cells["Price"].Value);
            decimal bottomPrice = Convert.ToInt32(grid_OrderDetail.Rows[ROWNO].Cells["Bottom Price"].Value);
            decimal unitPrice = Convert.ToInt32(grid_OrderDetail.Rows[ROWNO].Cells["List Price"].Value);
            decimal qty = Convert.ToInt32(grid_OrderDetail.Rows[ROWNO].Cells["Qty"].Value);
            decimal onhand = Convert.ToInt32(grid_OrderDetail.Rows[ROWNO].Cells["Onhand"].Value);
            string Remark = grid_OrderDetail.Rows[ROWNO].Cells["RM"].Value.ToString().Trim();
            string ReturnFlag = grid_OrderDetail.Rows[ROWNO].Cells["Return"].Value.ToString().Trim();

            Decimal TotalOrderQty = qty;

            if (Remark == "RR")
            {
                for (int j = 0; j < grid_OrderDetail.RowCount; j++)
                {
                    string PFProductID = grid_OrderDetail.Rows[j].Cells["Item ID"].Value.ToString().Trim();
                    decimal PFqty = Convert.ToInt32(grid_OrderDetail.Rows[j].Cells["Qty"].Value);
                    string PFRemark = grid_OrderDetail.Rows[j].Cells["RM"].Value.ToString().Trim();

                    if (ProductID.Trim() == PFProductID.Trim() && PFRemark == "PF" && ReturnFlag == "N")
                    {
                        TotalOrderQty = TotalOrderQty + PFqty;
                    }
                }
            }

            else if (Remark == "PF")
            {
                for (int j = 0; j < grid_OrderDetail.RowCount; j++)
                {
                    string PFProductID = grid_OrderDetail.Rows[j].Cells["Item ID"].Value.ToString().Trim();
                    decimal PFqty = Convert.ToInt32(grid_OrderDetail.Rows[j].Cells["Qty"].Value);
                    string PFRemark = grid_OrderDetail.Rows[j].Cells["RM"].Value.ToString().Trim();

                    if (ProductID.Trim() == PFProductID.Trim() && PFRemark == "RR" && ReturnFlag == "N")
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

        public bool finished = false;
        private void btn_save_Click(object sender, EventArgs e)
        {
            //check address
            if(txt_shipAddress1.Text.Trim() == "")
            {
                MessageBox.Show("No shipping address. Please input address on Customer List"
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            bool returnOnlyOrder = true;
            for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
            {
                String ReturnProduct = grid_OrderDetail.Rows[i].Cells["Return"].Value.ToString().Trim();
                Decimal Onhand = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Onhand"].Value.ToString().Trim());
                if (ReturnProduct != "Y" && Onhand > 0 )
                {
                    returnOnlyOrder = false;
                    break;
                }
            }

            if(returnOnlyOrder)
            {
                MessageBox.Show("Cannot save return only order."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (txt_billPostalCode.Text.Trim().Length > 5 || txt_shipPostalCode.Text.Trim().Length > 5)
            {
                MessageBox.Show("zip code error. please change the zip code from customer list."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
            {
                if (grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor == Color.HotPink)
                {
                    MessageBox.Show("Promotion item order quantity is greater than onhand quantity."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            //Create a new order number
            DialogResult dialogResult = MessageBox.Show("Are you sure to create a new order number?"
                                                    , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                /*
                for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
                {
                    try
                    {
                        string ProductID = grid_OrderDetail.Rows[i].Cells["Item ID"].Value.ToString().Trim();
                        Decimal NewOnhand = Convert.ToDecimal(connSalesOrder.getItemOnhandFromItemID(ProductID));
                        grid_OrderDetail.Rows[i].Cells["Onhand"].Value = NewOnhand;
                    }
                    catch
                    {
                        string ProductID = grid_OrderDetail.Rows[i].Cells["Item ID"].Value.ToString().Trim();
                        MessageBox.Show(ProductID + " has been inactivated."
                                                            , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    
                }

                Audit();

                for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
                {
                    if (grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor == Color.HotPink)
                    {
                        MessageBox.Show("Promotion item order quantity is greater than onhand quantity."
                                                            , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }*/

                //order와 return, credit 을 나눠서 database넣는다
                //1. order 는 SORDER, SORDERD에 저장한다.
                //2. Return 은 SRETURN, SRETURND
                iPadSalesOrder.OrderID = txt_iPadOrderID.Text.Trim();
                iPadSalesOrder.BillAddress1 = txt_billAddress1.Text.Trim();
                iPadSalesOrder.BillAddress2 = txt_billAddress2.Text.Trim();
                iPadSalesOrder.BillCityName = txt_billCity.Text.Trim();
                iPadSalesOrder.BillStateCode = txt_billStateCode.Text.Trim();
                iPadSalesOrder.BillPostalCode = txt_billPostalCode.Text.Trim();
                iPadSalesOrder.ShipAddress1 = txt_shipAddress1.Text.Trim();
                iPadSalesOrder.ShipAddress2 = txt_shipAddress2.Text.Trim();
                iPadSalesOrder.ShipCityName = txt_shipCity.Text.Trim();
                iPadSalesOrder.ShipStateCode = txt_shipStateCode.Text.Trim();
                iPadSalesOrder.ShipPostalCode = txt_shipPostalCode.Text.Trim();
                iPadSalesOrder.OrderDate = Convert.ToDateTime(txt_orderDate.Text);
                iPadSalesOrder.AuditMemo = txt_auditMemo.Text.Trim();
                iPadSalesOrder.AuditConfirm = cbo_auditConfirm.Text.Trim();
                iPadSalesOrder.CrAmt = Convert.ToDecimal(txt_creditAmount.Text.Trim());

                //Order2에 header insert
                //Sorder에 header insert(backup)
                //ipad order가 audit 끝났다고 표시
                connSalesOrder.sp_INSERT_NewOrderIDFromiPadSalesOrder(iPadSalesOrder);

                //credit은 0보다 클때만 sinvoice에 쓴다.
                if (Convert.ToDecimal(txt_creditAmount.Text.Trim()) > 0)
                {
                    connSalesOrder.sp_GACCENTRY_SalesCreditSCM(iPadSalesOrder);
                }

                //리턴 아이템이 있는지 확인하려고 return Item 변수를 만들어서 false로 써놓는다.
                bool returnItem = false;

                int OrderDetailCount = 0;
                //Detail 시작
                for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
                {
                    string ProductID = grid_OrderDetail.Rows[i].Cells["Item ID"].Value.ToString().Trim();
                    decimal price = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Price"].Value);
                    decimal bottomPrice = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Bottom Price"].Value);
                    decimal unitPrice = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["List Price"].Value);
                    decimal qty = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Qty"].Value);
                    decimal onhand = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Onhand"].Value);
                    string Remark = grid_OrderDetail.Rows[i].Cells["RM"].Value.ToString().Trim();
                    string ReturnFlag = grid_OrderDetail.Rows[i].Cells["Return"].Value.ToString().Trim();

                    if (onhand > 0 || ReturnFlag == "Y")
                    {
                        iPadSaleOrderDetail iPadSaleOrderDetail = new iPadSaleOrderDetail();

                        iPadSaleOrderDetail.OrderID = txt_iPadOrderID.Text.Trim();
                        iPadSaleOrderDetail.OrderDetailKey = grid_OrderDetail.Rows[i].Cells["No."].Value.ToString().Trim();
                        //iPadSaleOrderDetail.ProductKey = grid_OrderDetail.Rows[i].Cells["ProductKey"].Value.ToString().Trim();
                        iPadSaleOrderDetail.ProductID = ProductID;

                        if (qty > onhand && ReturnFlag == "N")
                        {
                            iPadSaleOrderDetail.OrderQty = onhand;
                            iPadSaleOrderDetail.Price = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Price"].Value);
                            iPadSaleOrderDetail.Amount = onhand * Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Price"].Value);
                        }
                        else
                        {
                            iPadSaleOrderDetail.OrderQty = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Qty"].Value);
                            iPadSaleOrderDetail.Price = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Price"].Value);
                            iPadSaleOrderDetail.Amount = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Amount"].Value);
                        }

                        iPadSaleOrderDetail.ReturnFlag = ReturnFlag;
                        iPadSaleOrderDetail.Remark = grid_OrderDetail.Rows[i].Cells["RM"].Value.ToString().Trim();
                        iPadSaleOrderDetail.CreateUserID = GATE.userID;

                        connSalesOrder.sp_INSERT_OrderDetail2(iPadSaleOrderDetail, i + 1);
                        if(ReturnFlag != "Y")
                            OrderDetailCount += 1;
                    }
                    if (ReturnFlag == "Y") // Return
                    {
                        returnItem = true;
                    }
                    //MessageBox.Show(ProductID);
                }

                if (returnItem == true)
                {
                    connSalesOrder.sp_INSERT_SRETURN(iPadSalesOrder);
                }
                //MessageBox.Show("stop");
                String iPadOrderID = txt_iPadOrderID.Text.Trim();
                String Result = "";
                Result = connSalesOrder.sp_CHECK_OrderDetail2(iPadOrderID, OrderDetailCount);

                if(Result != "OK")
                {
                    MessageBox.Show(Result.ToString(), "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Close();
                    return;
                }

                connSalesOrder.sp_ORDER_COMPLETE(iPadOrderID);
                //if (occupied != "Occupying")
                //{
                String RefNumber = txt_iPadOrderID.Text.Trim();
                connSalesOrder.sp_OCCUPIED_FINISHED(RefNumber);
                bOccupied = true;
                //}

                //Save finished
                finished = true;
                MessageBox.Show("The new Order " + iPadSalesOrder.OrderID + " has been Saved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            String iPadOrderID = txt_iPadOrderID.Text.Trim();
            occupied = connSalesOrder.sp_OCCUPIED_CHECK(iPadOrderID);

            //가다가 끊긴 오더인지 확인
            //MessageBox.Show("RefNumber: " + RefNumber);
            String CHECK_AuditOrder = "";
            CHECK_AuditOrder = connSalesOrder.sp_CHECK_AuditOrder(iPadOrderID);
            if (CHECK_AuditOrder != "OK")
            {
                btn_save.Enabled = true;
                MessageBox.Show(CHECK_AuditOrder, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bOccupied = true;
                return;
            }

            if (occupied == "Occupying")
            {
                btn_save.Enabled = false;
                MessageBox.Show("Someone occupying this reference number.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                bOccupied = true;
                return;
            }
            else if (occupied == "Finished")
            {
                btn_save.Enabled = false;
                MessageBox.Show("This reference number is already closed.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                bOccupied = true;
                return;
            }

            //227 ipad order amount 와 audit detail grid에 불러온 amount 비교
            Decimal AuditOrderAmount = Convert.ToDecimal(txt_amount.Text.ToString());
            String AuditOrderAmountResult = connSalesOrder.sp_CHECK_AuditOrderAmount(iPadOrderID, AuditOrderAmount);
            if (AuditOrderAmountResult != "OK")
            {
                btn_save.Enabled = false;
                MessageBox.Show(AuditOrderAmountResult, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                btn_save.Enabled = true;
            }
        }

        private void AuditSalesOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ipad order number release
            //MessageBox.Show("Close");
            if (bOccupied == false)
            {
                String RefNumber = txt_iPadOrderID.Text.Trim();
                connSalesOrder.sp_OCCUPIED_RELEASE(RefNumber);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ControlID.TextData = btn_refresh.Text;
            Close();
        }

        private void grid_OrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //grid_OrderDetail.Rows[e.RowIndex].DefaultCellStyle.BackColor.ToArgb();
            //Color C = Color.Red;
            //string HexVal = ColorTranslator.ToHtml(Color.FromArgb(C.R, C.G, C.B)));

            //MessageBox.Show(grid_OrderDetail.Rows[e.RowIndex].DefaultCellStyle.BackColor.R.ToString());

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
                    grid_OrderDetail.Rows.RemoveAt(e.RowIndex);
                    //Audit();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
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

                Decimal Inner = Convert.ToDecimal(connSalesOrder.getItemInnerFromItemID(cbo_itemID.Text));
                txt_inner.Text = Inner.ToString("N2");

                cbo_RM.Text = "RR";
            }
            catch
            {
                //MessageBox.Show("Input all item try to add info", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
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
            finally
            {

            }
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            calculateAddItemPrice();
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
                String ReturnFlag = "N";

                dr["OrderDetailKey"] = OrderDetailKey;
                dr["ProductID"] = ProductID;
                //dr["ProductKey"] = ProductKey;
                dr["Quantity"] = Quantity;
                dr["ProductDesc"] = ProductDesc;
                dr["SUnitM"] = SUnitM;
                dr["StrPackSize"] = StrPackSize;
                dr["Price"] = Price;
                dr["Amount"] = Amount;
                dr["flRemark"] = flRemark;
                dr["UnitPr"] = UnitPr;
                dr["BottomPr"] = BottomPr;
                dr["QtyOnHand"] = QtyOnHand;
                dr["ItemPack"] = LastOutCost;
                dr["ReturnFlag"] = ReturnFlag;
                dt.Rows.Add(dr);
                //dt.Rows.InsertAt(dr, grid_RouteDetail.ColumnCount + 1);
                //Audit();
            }
            catch
            {
                MessageBox.Show("Input all item info", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cbo_itemID_Leave(object sender, EventArgs e)
        {
            fillAddItemInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

        private void btn_save_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Red), new Rectangle(0, 0, ((Button)sender).Width - 1, ((Button)sender).Height - 1));
        }

        private void cbo_RM_SelectedValueChanged(object sender, EventArgs e)
        {
            calculateAddItemPrice();
        }

        private void txt_creditAmount_Leave(object sender, EventArgs e)
        {
            Decimal OrderTotalAmount = Convert.ToDecimal(txt_amount.Text.Trim());
            Decimal CreditAmount = Convert.ToDecimal(txt_creditAmount.Text.Trim());
            Decimal TotalAmount = OrderTotalAmount - CreditAmount;
            txt_salesTotal.Text = TotalAmount.ToString("N2");
        }


        private void btn_void_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this order?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                String iPadOrderID = txt_iPadOrderID.Text.Trim();
                connSalesOrder.sp_VOID_iPadSalesOrder(iPadOrderID);

                connSalesOrder.sp_OCCUPIED_FINISHED(iPadOrderID);
                bOccupied = true;
                //}

                //Save finished
                MessageBox.Show("The order, " + iPadOrderID + " has been deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }
    }
}
