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
    public partial class PickingTickets : Form
    {
        Entities.Order2 order2 = new Entities.Order2();
        public PickingTickets()
        {
            InitializeComponent();
            grid_OrderDetail_Init();
            grid_OrderDetailOriginal_Init();

            //아이템 가져오기
            connSalesOrder.cbo_itemID(cbo_itemID);

            cbo_RM.Items.Add("RR");
            cbo_RM.Items.Add("PF");


        }

        public PickingTickets(String OrderID)
        {
            InitializeComponent();
            grid_OrderDetail_Init();
            txt_orderID.Text = OrderID;
            connSalesOrder.sp_Fetch_PickDetail(grid_OrderDetail, OrderID);
            connSalesOrder.sp_Fetch_PickDetail(grid_OrderDetailOriginal, OrderID);


            //Order2 info
            //Order2 order2 = new Order2();
            order2 = connSalesOrder.sp_Fetch_PickInfo(OrderID);

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
            
            //아이템 가져오기
            connSalesOrder.cbo_itemID(cbo_itemID);
            
        }

        private void grid_OrderDetail_Init()
        {
            grid_OrderDetail.AutoGenerateColumns = false;
            grid_OrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_OrderDetail.ColumnCount = 21;

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

            //grid_OrderDetail.Columns[9].Name = "PF";
            //grid_OrderDetail.Columns[9].ReadOnly = true;
            //grid_OrderDetail.Columns[9].Visible = false;
            //grid_OrderDetail.Columns[9].Width = 30;
            //grid_OrderDetail.Columns[9].DataPropertyName = "";

            grid_OrderDetail.Columns[9].Name = "Unit Price";
            grid_OrderDetail.Columns[9].ReadOnly = true;
            grid_OrderDetail.Columns[9].Width = 60;
            grid_OrderDetail.Columns[9].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[9].DataPropertyName = "UnitPr";

            grid_OrderDetail.Columns[10].Name = "Bottom Price";
            grid_OrderDetail.Columns[10].ReadOnly = true;
            grid_OrderDetail.Columns[10].Width = 60;
            grid_OrderDetail.Columns[10].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[10].DataPropertyName = "BottomPr";

            grid_OrderDetail.Columns[11].Name = "Onhand";
            grid_OrderDetail.Columns[11].ReadOnly = true;
            grid_OrderDetail.Columns[11].Width = 60;
            grid_OrderDetail.Columns[11].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[11].DataPropertyName = "QtyOnHand";

            grid_OrderDetail.Columns[12].Name = "Available Onhand";
            grid_OrderDetail.Columns[12].ReadOnly = true;
            grid_OrderDetail.Columns[12].Width = 60;
            grid_OrderDetail.Columns[12].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[12].DataPropertyName = "AvailableQty";

            grid_OrderDetail.Columns[13].Name = "Inner";
            grid_OrderDetail.Columns[13].ReadOnly = true;
            grid_OrderDetail.Columns[13].Width = 50;
            grid_OrderDetail.Columns[13].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[13].DataPropertyName = "LastOutCost";

            //Order Add
            DataGridViewButtonColumn OSButton = new DataGridViewButtonColumn();
            OSButton.Width = 50;
            OSButton.Name = "O/S";
            OSButton.Text = "O/S";
            OSButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            OSButton.UseColumnTextForButtonValue = true;
            if (grid_OrderDetail.Columns["O/S"] == null)

            {
                grid_OrderDetail.Columns.Insert(14, OSButton);
            }

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
            grid_OrderDetail.Columns[18].Width = 60;
            grid_OrderDetail.Columns[18].Visible = false;
            grid_OrderDetail.Columns[18].DataPropertyName = "Status";

            grid_OrderDetail.Columns[19].Name = "PickingNumber";
            grid_OrderDetail.Columns[19].Visible = false;
            grid_OrderDetail.Columns[19].DataPropertyName = "PickingNumber";

            grid_OrderDetail.Columns[20].Name = "PickingCategory";
            grid_OrderDetail.Columns[20].Visible = false;
            grid_OrderDetail.Columns[20].DataPropertyName = "PickingCategory";

            grid_OrderDetail.Columns[21].Name = "PackedQty";
            grid_OrderDetail.Columns[21].Visible = false;
            grid_OrderDetail.Columns[21].DataPropertyName = "PackedQty";

            grid_OrderDetail.Columns[22].Name = "OriginalOrderQty";
            grid_OrderDetail.Columns[22].Visible = true;
            grid_OrderDetail.Columns[22].Width = 50;
            grid_OrderDetail.Columns[22].MinimumWidth = 50;
            grid_OrderDetail.Columns[22].DataPropertyName = "OriginalOrderQty";


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

        private void grid_OrderDetailOriginal_Init()
        {
            grid_OrderDetailOriginal.AutoGenerateColumns = false;
            grid_OrderDetailOriginal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_OrderDetailOriginal.ColumnCount = 3;

            grid_OrderDetailOriginal.Columns[0].Name = "No.";
            grid_OrderDetailOriginal.Columns[0].ReadOnly = true;
            grid_OrderDetailOriginal.Columns[0].Width = 30;
            grid_OrderDetailOriginal.Columns[0].DataPropertyName = "OrderDetailKey";

            grid_OrderDetailOriginal.Columns[1].Name = "Item ID";
            grid_OrderDetailOriginal.Columns[1].ReadOnly = true;
            grid_OrderDetailOriginal.Columns[1].Width = 100;
            grid_OrderDetailOriginal.Columns[1].DataPropertyName = "ProductID";

            grid_OrderDetailOriginal.Columns[2].Name = "Qty";
            grid_OrderDetailOriginal.Columns[2].Width = 50;
            grid_OrderDetailOriginal.Columns[2].DefaultCellStyle.Format = "N2";
            grid_OrderDetailOriginal.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetailOriginal.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetailOriginal.Columns[2].DataPropertyName = "OrderQty";

            //grid font size custom
            grid_OrderDetailOriginal.RowTemplate.Height = 20;
            grid_OrderDetailOriginal.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_OrderDetailOriginal.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_OrderDetailOriginal.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
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
            else if (grid_OrderDetail.CurrentRow.Cells["RM"].Value.ToString() == "PF")
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
                string ProductID = grid_OrderDetail.Rows[i].Cells["Item ID"].Value.ToString();
                decimal price = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Price"].Value);
                decimal bottomPrice = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Bottom Price"].Value);
                decimal unitPrice = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Unit Price"].Value);
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
                        string PFstatus = grid_OrderDetail.Rows[k].Cells["Return"].Value.ToString();
                        if (i != k && ProductID.Trim() == PFProductID.Trim() && ReturnFlag == "N" && status != "OS" && PFstatus != "OS")
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
                                grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DeepPink;
                                grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
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
                    grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                    grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                }

                if (ReturnFlag == "N" && status != "OS")
                {
                    Amount += Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Amount"].Value);
                }
                
            }
            
        }

        private Decimal GetTotalOrderQty(int ROWNO)
        {
            string ProductID = grid_OrderDetail.Rows[ROWNO].Cells["Item ID"].Value.ToString();
            decimal price = Convert.ToInt32(grid_OrderDetail.Rows[ROWNO].Cells["Price"].Value);
            decimal bottomPrice = Convert.ToInt32(grid_OrderDetail.Rows[ROWNO].Cells["Bottom Price"].Value);
            decimal qty = Convert.ToInt32(grid_OrderDetail.Rows[ROWNO].Cells["Qty"].Value);
            decimal onhand = Convert.ToInt32(grid_OrderDetail.Rows[ROWNO].Cells["Available Onhand"].Value);
            string Remark = grid_OrderDetail.Rows[ROWNO].Cells["RM"].Value.ToString();
            string status = grid_OrderDetail.Rows[ROWNO].Cells["Status"].Value.ToString();

            Decimal TotalOrderQty = qty;

            if (status != "OS")
            {
                if (Remark == "RR")
                {
                    for (int j = 0; j < grid_OrderDetail.RowCount; j++)
                    {
                        string PFProductID = grid_OrderDetail.Rows[j].Cells["Item ID"].Value.ToString();
                        decimal PFqty = Convert.ToInt32(grid_OrderDetail.Rows[j].Cells["Qty"].Value);
                        string PFRemark = grid_OrderDetail.Rows[j].Cells["RM"].Value.ToString();
                        string PFstatus = grid_OrderDetail.Rows[j].Cells["Status"].Value.ToString();

                        if (ProductID.Trim() == PFProductID.Trim() && PFRemark == "PF" && PFstatus != "OS")
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
                        string PFstatus = grid_OrderDetail.Rows[j].Cells["Status"].Value.ToString();

                        if (ProductID.Trim() == PFProductID.Trim() && PFRemark == "RR" && PFstatus != "OS")
                        {
                            TotalOrderQty = TotalOrderQty + PFqty;
                        }
                    }

                }
            }
            else
            {

            }
                

            //MessageBox.Show(ROWNO + " " + TotalOrderQty);
            return TotalOrderQty;

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


                //원래있던 온핸드 원래대로 해놓는다
                //connSalesOrder.sp_UPDATE_AddOnhand(order2.OrderID);


                connSalesOrder.sp_UPDATE_Pick(order2);



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



                    connSalesOrder.sp_UPDATE_PickDetail(orderDetail2);


                    //onhand delete
                    //connSalesOrder.sp_UPDATE_DeleteOnhand(orderDetail2.ProductID, orderDetail2.OrderQty);
                }

                //Save finished
                MessageBox.Show("The new Order " + order2.OrderID + " has been Updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (e.ColumnIndex == 14) // O/S button
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure this item is out of stock?"
                                                        , "Confirming", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //DataTable dt = this.grid_OrderDetail.DataSource as DataTable;
                    //DataRow dr = dt.NewRow();
                    //dt.Rows.RemoveAt(e.RowIndex);

                    //String OrderID = txt_orderID.Text.Trim();
                    //int OrderDetailKey = Convert.ToInt32(grid_OrderDetail.Rows[e.RowIndex].Cells["No."].Value.ToString().Trim());
                    //connSalesOrder.sp_UPDATE_OrderDetail2OutOfStock(OrderID, OrderDetailKey);
                    if (grid_OrderDetail.Rows[e.RowIndex].Cells["Status"].Value.ToString() != "OS")
                    {
                        grid_OrderDetail.Rows[e.RowIndex].Cells["Status"].Value = "OS";
                    }
                    else
                    {
                        grid_OrderDetail.Rows[e.RowIndex].Cells["Status"].Value = "";
                    }

                }
                else if (dialogResult == DialogResult.No)
                {

                }
                //Audit();
                string status = grid_OrderDetail.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                if (status == "OS")
                {
                    grid_OrderDetail.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.CornflowerBlue;
                    grid_OrderDetail.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                    grid_OrderDetail.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else
                {
                    grid_OrderDetail.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    grid_OrderDetail.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightGray;
                    grid_OrderDetail.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;
                }

            }

            if (e.ColumnIndex == 15) // Delete button
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

                Decimal AvailableOnhand = connSalesOrder.sp_GET_GlobalQty(txt_orderID.Text.Trim().ToString(), cbo_itemID.Text.Trim().ToString());
                txt_availableOnhand.Text = AvailableOnhand.ToString("N2");

                Decimal Inner = Convert.ToDecimal(connSalesOrder.getItemInnerFromItemID(cbo_itemID.Text));
                txt_inner.Text = Inner.ToString("N2");

                cbo_RM.Text = "RR";
            }
            catch
            {
                MessageBox.Show("Try again please.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

                if(AvailableOnhand < Quantity)
                {
                    MessageBox.Show("The onhand quantity is less than the quantity entered.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

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
                dr["AvailableQty"] = AvailableOnhand;
                dr["OriginalOrderQty"] = 0;

                dt.Rows.Add(dr);
                //dt.Rows.InsertAt(dr, grid_RouteDetail.ColumnCount + 1);
                //Audit();
            }
            catch
            {
                MessageBox.Show("Input all item info", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                lbl_newCase.Visible = false;
                txt_newCase.Visible = false;
                btn_edit.Visible = false;

                txt_cases.Enabled = true;
                btn_Deliverable.Enabled = true;
                String PickingNumber;
                PickingNumber = txt_barcode.Text.Substring(0, txt_barcode.Text.Length - 1);
                txt_realBarcode.Text = PickingNumber.Trim();
                txt_barcode.Text = PickingNumber;
                String PickingNumberCategory = connSalesOrder.sp_GET_PickingNumberCategory(PickingNumber);
                txt_category.Text = PickingNumberCategory;
                connSalesOrder.sp_Fetch_PickingNumber(grid_OrderDetail, PickingNumber);
                connSalesOrder.sp_Fetch_PickingNumber(grid_OrderDetailOriginal, PickingNumber);
                String OrderID = connSalesOrder.sp_GET_OrderIDfromPickingNumber(PickingNumber);
                
                order2 = connSalesOrder.sp_Fetch_PickInfo(OrderID);

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

                String deliverable = connSalesOrder.sp_PickingNumber_isDeliverable(PickingNumber);
                if (deliverable == "Deliverable" || deliverable == "void") //void deliverable 05/12/2020
                {
                    connSalesOrder.sp_Fetch_PickingNumber_Deliverable(grid_OrderDetail, PickingNumber);
                    connSalesOrder.sp_Fetch_PickingNumber_Deliverable(grid_OrderDetailOriginal, PickingNumber);
                    txt_cases.Enabled = false;
                    btn_Deliverable.Enabled = false;

                    lbl_newCase.Visible = true;
                    txt_newCase.Visible = true;
                    btn_edit.Visible = true;
                }

                String Cases = connSalesOrder.sp_GET_BoxesbyPickingNumber(PickingNumber);
                txt_cases.Text = Cases;
                txt_barcode.SelectAll();
                
            }
        }

        private void btn_Deliverable_Click(object sender, EventArgs e)
        {
            try
            {
                int Box = Convert.ToInt32(txt_cases.Text.ToString().Trim());
            }
            catch
            {
                MessageBox.Show("Input the valid number of case.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (txt_cases.Text == "")
            {
                MessageBox.Show("Input the number of case.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            bool stockCheck = false;
            for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
            {
                Decimal Qty = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Qty"].Value.ToString().Trim());
                Decimal OriginalQty = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["OriginalOrderQty"].Value.ToString().Trim());

                if (Qty > OriginalQty)
                {
                    stockCheck = true;
                    break;
                }
            }

            
            
            if (stockCheck == true)
            {
                for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
                {
                    string ProductID = grid_OrderDetail.Rows[i].Cells["Item ID"].Value.ToString();
                    Decimal NewOnhand = Convert.ToDecimal(connSalesOrder.getItemOnhandFromItemID(ProductID));
                    Decimal NewAvailableOnhand = connSalesOrder.sp_GET_GlobalQty(txt_orderID.Text.Trim().ToString(), ProductID);
                    grid_OrderDetail.Rows[i].Cells["Onhand"].Value = NewOnhand;
                    grid_OrderDetail.Rows[i].Cells["Available Onhand"].Value = NewAvailableOnhand;
                    //MessageBox.Show(ProductID + ", " + NewOnhand + ", " + NewAvailableOnhand);
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
            }

            

            DialogResult dialogResult = MessageBox.Show("Are you sure make deliverable this picking ticket?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                String PickingNumber;
                PickingNumber = txt_realBarcode.Text.Trim();
 
                for (int i = 0; i < grid_OrderDetailOriginal.Rows.Count; i++)
                {
                    String OriginalProductID = grid_OrderDetailOriginal.Rows[i].Cells["Item ID"].Value.ToString().Trim();
                    Decimal OriginalQty = Convert.ToDecimal(grid_OrderDetailOriginal.Rows[i].Cells["Qty"].Value.ToString().Trim());
                    String OriginalOrderID = txt_orderID.Text.Trim();
                    connSalesOrder.sp_UPDATE_DeleteGLOALL(OriginalProductID, OriginalQty, OriginalOrderID); //GLobal 지운다
                }
                
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
                    orderDetail2.PickingCategory = txt_category.Text.Trim();                                                    
                    orderDetail2.PackedQty = 0;
                    //orderDetail2.PickingNumber = grid_OrderDetail.Rows[i].Cells["PickingNumber"].Value.ToString();
                    orderDetail2.PickingNumber = PickingNumber;
                    //if (grid_OrderDetail.Rows[i].Cells["PickingCategory"].Value != System.DBNull.Value)
                    //{
                    //    orderDetail2.PickingCategory = grid_OrderDetail.Rows[i].Cells["PickingCategory"].Value.ToString();
                    //}
                    //else
                    //{
                    //    orderDetail2.PickingCategory = "";
                    //}

                    if (grid_OrderDetail.Rows[i].Cells["PackedQty"].Value != System.DBNull.Value)
                    {
                        orderDetail2.PackedQty = Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["PackedQty"].Value);
                    }
                    else
                    {
                        orderDetail2.PackedQty = 0;
                    }

                    connSalesOrder.sp_INSERT_PickingDetail(orderDetail2);
                    //MessageBox.Show(i.ToString() + " sp_INSERT_PickingDetail Done");
                }
                //box cases update 
                connSalesOrder.sp_UPDATE_PickingNumberBox(PickingNumber, Convert.ToInt32(txt_cases.Text));
                //UPDATE PickingNumber SET Status = 'Deliverable'
                connSalesOrder.sp_UPDATE_PickingNumberDeliverable(PickingNumber);  
                //Save finished
                MessageBox.Show(PickingNumber + " has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //connSalesOrder.sp_Fetch_PickingNumber(grid_OrderDetail, PickingNumber);

                txt_barcode.Text = "";
                txt_realBarcode.Text = "";
                txt_cases.Text = "";
                txt_category.Text = "";
                grid_OrderDetail.DataSource = null;
                grid_OrderDetailOriginal.DataSource = null;

                cbo_itemID.Text = "";
                txt_qty.Text = "";
                txt_itemDesc.Text = "";
                txt_unit.Text = "";
                txt_packSize.Text = "";
                txt_amount.Text = "";
                cbo_RM.Text = "";
                txt_unitPrice.Text = "";
                txt_bottomPrice.Text = "";
                txt_onhand.Text = "";
                txt_availableOnhand.Text = "";
                txt_inner.Text = "";
                
                txt_barcode.Focus();

            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure update delivery case?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int Box = Convert.ToInt32(txt_cases.Text);
                int NewBox = Convert.ToInt32(txt_newCase.Text);
                String PickingNumber = txt_barcode.Text;
                connSalesOrder.sp_EDIT_PickingNumberBox(PickingNumber, NewBox);

                MessageBox.Show(PickingNumber + " has been updated successfully.\n\n" + Box.ToString().Trim() + " --> " + NewBox.ToString().Trim() + " Box", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //connSalesOrder.sp_Fetch_PickingNumber(grid_OrderDetail, PickingNumber);

                txt_barcode.Text = "";
                txt_cases.Text = "";
                txt_category.Text = "";
                txt_newCase.Text = "";
                grid_OrderDetail.DataSource = null;
                grid_OrderDetailOriginal.DataSource = null;

                lbl_newCase.Visible = false;
                txt_newCase.Visible = false;
                btn_edit.Visible = false;

                txt_barcode.Focus();
            }
                
        }

        private void cbo_RM_SelectedValueChanged(object sender, EventArgs e)
        {
            calculateAddItemPrice();
        }
    }
}
