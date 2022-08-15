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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OBCS.Sales
{
    public partial class DeliveryDetail : Form
    {
        Entities.Order2 order2 = new Entities.Order2();
        public DeliveryDetail(String OrderID)
        {
            InitializeComponent();
            grid_OrderDetail_Init();
            grid_return_Init();

            txt_orderID.Text = OrderID;
            connSalesOrder.sp_Fetch_DeliveryDetail(grid_OrderDetail, OrderID);
            connSalesOrder.sp_Fetch_OrderReturnDetail(grid_return, OrderID);
            txt_addCreditAmount.Text = "0";

            //Order2 info
            //Order2 order2 = new Order2();
            order2 = connSalesOrder.sp_Fetch_DeliveryInfo(OrderID);

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
            txt_deliveryNumber.Text = order2.DeliveryNumber;

            //아이템 가져오기
            connSalesOrder.cbo_itemID(cbo_itemID);

            cbo_CMReason.Items.Add("SRCM");
            cbo_CMReason.Items.Add("DCM");
            cbo_CMReason.Items.Add("NCS");
            cbo_CMReason.Items.Add("PFCM");
            cbo_CMReason.Items.Add("CRCM");
            cbo_CMReason.Items.Add("DAD");
            cbo_CMReason.Items.Add("AC");
            cbo_CMReason.Items.Add("LD");
            cbo_CMReason.Items.Add("NO");
            cbo_CMReason.Items.Add("IP");
            cbo_CMReason.Items.Add("QE");
            cbo_CMReason.Items.Add("DIS");
            cbo_CMReason.Items.Add("MISC");

            //Audit();


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
            grid_OrderDetail.Columns[2].ReadOnly = true;
            grid_OrderDetail.Columns[2].Width = 50;
            grid_OrderDetail.Columns[2].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[2].DataPropertyName = "OrderQty";

            grid_OrderDetail.Columns[3].Name = "Delivered Qty";
            grid_OrderDetail.Columns[3].Width = 50;
            grid_OrderDetail.Columns[3].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[3].DataPropertyName = "DeliveredQty2";

            DataGridViewComboBoxColumn ReasonComboBox = new DataGridViewComboBoxColumn();
            ReasonComboBox.Width = 70;
            ReasonComboBox.Name = "Reason";
            ReasonComboBox.Items.Add("Return");
            ReasonComboBox.Items.Add("Missing");
            ReasonComboBox.Items.Add("Damaged");
            ReasonComboBox.Items.Add("Not In");
            ReasonComboBox.Items.Add("");
            ReasonComboBox.DataPropertyName = "Reason";
            ReasonComboBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (grid_OrderDetail.Columns["RMA"] == null)

            {
                grid_OrderDetail.Columns.Insert(4, ReasonComboBox);
            }

            grid_OrderDetail.Columns[5].Name = "Item Desc";
            grid_OrderDetail.Columns[5].ReadOnly = true;
            grid_OrderDetail.Columns[5].Width = 300;
            grid_OrderDetail.Columns[5].DataPropertyName = "ProductDesc";

            grid_OrderDetail.Columns[6].Name = "Unit";
            grid_OrderDetail.Columns[6].Visible = false;
            grid_OrderDetail.Columns[6].ReadOnly = true;
            grid_OrderDetail.Columns[6].Width = 30;
            grid_OrderDetail.Columns[6].DataPropertyName = "Unit";

            grid_OrderDetail.Columns[7].Name = "Pack Size";
            grid_OrderDetail.Columns[7].ReadOnly = true;
            grid_OrderDetail.Columns[7].Width = 90;
            grid_OrderDetail.Columns[7].DataPropertyName = "StrPackSize";

            grid_OrderDetail.Columns[8].Name = "Price";
            grid_OrderDetail.Columns[8].Width = 60;
            grid_OrderDetail.Columns[8].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[8].DataPropertyName = "Price";

            grid_OrderDetail.Columns[9].Name = "Amount";
            grid_OrderDetail.Columns[9].ReadOnly = true;
            grid_OrderDetail.Columns[9].Width = 60;
            grid_OrderDetail.Columns[9].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[9].DataPropertyName = "Amount";

            grid_OrderDetail.Columns[10].Name = "RM";
            grid_OrderDetail.Columns[10].Width = 30;
            grid_OrderDetail.Columns[10].DataPropertyName = "Remark";

            grid_OrderDetail.Columns[11].Name = "PF";
            grid_OrderDetail.Columns[11].Visible = false;
            grid_OrderDetail.Columns[11].Width = 30;
            grid_OrderDetail.Columns[11].DataPropertyName = "";

            grid_OrderDetail.Columns[12].Name = "Unit Price";
            grid_OrderDetail.Columns[12].Visible = false;
            grid_OrderDetail.Columns[12].ReadOnly = true;
            grid_OrderDetail.Columns[12].Width = 60;
            grid_OrderDetail.Columns[12].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[12].DataPropertyName = "UnitPr";

            grid_OrderDetail.Columns[13].Name = "Bottom Price";
            grid_OrderDetail.Columns[13].Visible = false;
            grid_OrderDetail.Columns[13].ReadOnly = true;
            grid_OrderDetail.Columns[13].Width = 60;
            grid_OrderDetail.Columns[13].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[13].DataPropertyName = "BottomPr";

            grid_OrderDetail.Columns[14].Name = "Onhand";
            grid_OrderDetail.Columns[14].Visible = false;
            grid_OrderDetail.Columns[14].ReadOnly = true;
            grid_OrderDetail.Columns[14].Width = 60;
            grid_OrderDetail.Columns[14].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[14].DataPropertyName = "QtyOnHand";

            grid_OrderDetail.Columns[15].Name = "Inner";
            grid_OrderDetail.Columns[15].Visible = false;
            grid_OrderDetail.Columns[15].ReadOnly = true;
            grid_OrderDetail.Columns[15].Width = 50;
            grid_OrderDetail.Columns[15].DefaultCellStyle.Format = "N2";
            grid_OrderDetail.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_OrderDetail.Columns[15].DataPropertyName = "LastOutCost";

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
            try
            {
                if (grid_OrderDetail.CurrentRow.Cells["RM"].Value.ToString() == "PF" || grid_OrderDetail.CurrentRow.Cells["RM"].Value.ToString() == "RR")
                {

                }
                else
                {
                    MessageBox.Show("Check the remark, RR or PF."
                                                , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    grid_OrderDetail.CurrentRow.Cells["RM"].Value = "RR";

                }
                string orderQtyString = grid_OrderDetail.CurrentRow.Cells["Delivered Qty"].Value.ToString();
                double orderQty = Convert.ToDouble(orderQtyString);

                string priceString = grid_OrderDetail.CurrentRow.Cells["Price"].Value.ToString();
                double price = Convert.ToDouble(priceString);

                string amountString = grid_OrderDetail.CurrentRow.Cells["Amount"].Value.ToString();
                double amount = Convert.ToDouble(amountString);

                if (grid_OrderDetail.CurrentRow.Cells["RM"].Value.ToString() == "RR")
                {
                    amount = orderQty * price;
                    grid_OrderDetail.CurrentRow.Cells["Amount"].Value = amount;
                    grid_OrderDetail.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                    grid_OrderDetail.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                    grid_OrderDetail.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
                else if (grid_OrderDetail.CurrentRow.Cells["RM"].Value.ToString() == "PF")
                {
                    amount = 0;
                    grid_OrderDetail.CurrentRow.Cells["Amount"].Value = amount;
                    grid_OrderDetail.CurrentRow.DefaultCellStyle.BackColor = Color.Gold;
                    grid_OrderDetail.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.DarkGoldenrod;
                    grid_OrderDetail.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;
                }

                Audit();
            }
            catch
            {
                // Close();
            }


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

            grid_return.Columns[10].Name = "Unit Price";
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


        private void Audit()
        {
            for (int i = 0; i < grid_OrderDetail.RowCount; i++)
            {
                decimal price = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Price"].Value);
                decimal bottomPrice = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Bottom Price"].Value);
                decimal unitPrice = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Unit Price"].Value);
                decimal qty = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Delivered Qty"].Value);
                decimal onhand = Convert.ToInt32(grid_OrderDetail.Rows[i].Cells["Onhand"].Value);
                string Remark = grid_OrderDetail.Rows[i].Cells["RM"].Value.ToString();
                string ReturnFlag = grid_OrderDetail.Rows[i].Cells["Return"].Value.ToString();
                string status = grid_OrderDetail.Rows[i].Cells["Status"].Value.ToString();
                //string reason = grid_OrderDetail.Rows[i].Cells["Reason"].Value.ToString();


                if (price < bottomPrice && Remark == "RR")
                {
                    grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                    grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Crimson;
                    grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;

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
                            grid_OrderDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DarkGoldenrod;
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
                    //grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.CornflowerBlue;
                }

                //if (reason != "")
                //{
                //    grid_OrderDetail.Rows[i].DefaultCellStyle.BackColor = Color.MistyRose;
                //}

            }




            //Total Amount
            Decimal Amount = 0;
            Decimal ReturnAmount = 0;
            for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
            {
                String ReturnFlag = grid_OrderDetail.Rows[i].Cells["Return"].Value.ToString();
                String Status = grid_OrderDetail.Rows[i].Cells["Status"].Value.ToString();
                if (ReturnFlag == "N" && Status != "OS")
                {
                    Amount += Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Amount"].Value);
                }
                //MessageBox.Show(grid_RTTMPD.Rows[i].Cells["Memo"].Value.ToString());
            }

            for (int i = 0; i < grid_return.Rows.Count; i++)
            {

                ReturnAmount += Convert.ToDecimal(grid_return.Rows[i].Cells["Amount"].Value);
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
            txt_amount.Text = Amount.ToString("N2");
            //MessageBox.Show(txt_orderID.Text.Trim());
            //get Credit Amount
            Decimal creditAmount = Convert.ToDecimal(connSalesOrder.getCreditAmountFromOrder2(txt_orderID.Text.Trim()));
            txt_creditAmount.Text = creditAmount.ToString("N2");
            txt_returnAmount.Text = ReturnAmount.ToString("N2");

            Decimal AddCreditAmount = Convert.ToDecimal(txt_addCreditAmount.Text.Trim());

            Decimal SalesTotal = Amount - creditAmount - AddCreditAmount - ReturnAmount;
            txt_salesTotal.Text = SalesTotal.ToString("N2");

            //if(Convert.ToDecimal(txt_salesTotal.Text.Trim()) <= 0)
            //{
            //    txt_addCreditAmount.Text = "0";
            //    Audit();
            //}
        }

        private void grid_OrderDetail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
            //{
            //    String Qty = grid_OrderDetail.Rows[i].Cells["Qty"].Value.ToString();
            //    grid_OrderDetail.Rows[i].Cells["Delivered Qty"].Value = Qty;

            //}
            foreach (DataGridViewRow item in grid_OrderDetail.Rows)
            {
                //MessageBox.Show(item.Cells["Item ID"].Value.ToString() + " " + item.Cells["RM"].Value.ToString());
                if (item.Cells["RM"].Value.ToString() == "PF")
                {
                    item.DefaultCellStyle.BackColor = Color.Gold;
                    item.DefaultCellStyle.SelectionBackColor = Color.DarkGoldenrod;
                    item.DefaultCellStyle.SelectionForeColor = Color.White;
                }
            }

            grid_OrderDetail.ClearSelection();
            //Audit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_OrderDetail.Rows.Count; i++)
            {
                if (grid_OrderDetail.Rows[i].Cells["Reason"].Value == null)
                {
                    grid_OrderDetail.Rows[i].Cells["Reason"].Value = "";
                }

                if (Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Qty"].Value.ToString()) < Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Delivered Qty"].Value.ToString()))
                {
                    MessageBox.Show("The quantity of deliveries cannot be greater than the quantity originally delivered."
                                                , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Qty"].Value.ToString()) != Convert.ToDecimal(grid_OrderDetail.Rows[i].Cells["Delivered Qty"].Value.ToString()))
                {
                    if (grid_OrderDetail.Rows[i].Cells["Reason"].Value.ToString().Trim() == "")
                    {
                        MessageBox.Show("Please select a reason for delivery of items that have not been delivered."
                                                    , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to validate this order?", "Confirming", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                bOccupied = true;

                String OrderID = txt_orderID.Text.Trim();
                String DeliveryNumber = txt_deliveryNumber.Text.Trim();
                String CustomerID = txt_customerID.Text.Trim();
                String REP = txt_saleRep.Text.ToString().Trim();
                Decimal CreditAmount = Convert.ToDecimal(txt_addCreditAmount.Text.Trim());
                String CreditReason = cbo_CMReason.Text.Trim();
                String CreditMemo = txt_CMReasonMemo.Text.Trim();
                String UserID = GATE.userID;
                DataTable dt = new DataTable();
                dt = (DataTable)grid_OrderDetail.DataSource;

                System.Text.Json.JsonSerializer jsonSerializer = new System.Text.Json.JsonSerializer();
                var jsonstring = jsonSerializer.SerializeObject(OrderID, DeliveryNumber, CustomerID, REP, CreditAmount, CreditReason, CreditMemo, UserID, dt);
                connSalesOrder.sp_ARValidation(jsonstring.ToString());

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
            String RefNumber = txt_deliveryNumber.Text.Trim();
            occupied = connSalesOrder.sp_OCCUPIED_CHECK(RefNumber);

            if (occupied == "Occupying")
            {
                btn_save.Enabled = false;
                bOccupied = true;
                MessageBox.Show("Someone occupying this reference number.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (occupied == "Finished")
            {
                btn_save.Enabled = false;
                grid_OrderDetail.Columns[3].ReadOnly = true;
                grid_OrderDetail.Columns[4].ReadOnly = true;
                grid_OrderDetail.Columns[8].ReadOnly = true;
                grid_OrderDetail.Columns[10].ReadOnly = true;
                bOccupied = true;
                MessageBox.Show("This reference number is already closed.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (occupied == "Processing")
            {
                btn_save.Enabled = false;
                grid_OrderDetail.Columns[3].ReadOnly = true;
                grid_OrderDetail.Columns[4].ReadOnly = true;
                grid_OrderDetail.Columns[8].ReadOnly = true;
                grid_OrderDetail.Columns[10].ReadOnly = true;
                bOccupied = true;
                MessageBox.Show("AR Validation processing...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void AuditSalesOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ipad order number release
            //MessageBox.Show("Close");
            if (bOccupied == false)
            {
                String RefNumber = txt_deliveryNumber.Text.Trim();
                connSalesOrder.sp_OCCUPIED_RELEASE(RefNumber);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grid_OrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void txt_addCreditAmount_Leave(object sender, EventArgs e)
        {
            try
            {
                Audit();
            }
            catch
            {
                txt_addCreditAmount.Text = "0";
                Audit();
            }

        }

        private void calculateSalesTotal()
        {
            Decimal OrderTotalAmount = Convert.ToDecimal(txt_amount.Text.Trim());
            Decimal CreditAmount = Convert.ToDecimal(txt_creditAmount.Text.Trim());
            Decimal AddCreditAmount = Convert.ToDecimal(txt_addCreditAmount.Text.Trim());
            Decimal ReturnAmount = Convert.ToDecimal(txt_returnAmount.Text.Trim());

            Decimal SalesTotalAmount = OrderTotalAmount - CreditAmount - AddCreditAmount - ReturnAmount;

            txt_salesTotal.Text = SalesTotalAmount.ToString("N2");
        }


        private void txt_addCreditAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Audit();
            }
            catch
            {
                txt_addCreditAmount.Text = "0";
                Audit();
                txt_addCreditAmount.SelectAll();
            }

        }

        private void txt_addCreditAmount_Enter(object sender, EventArgs e)
        {
            txt_addCreditAmount.SelectAll();
        }

        private void txt_addCreditAmount_Click(object sender, EventArgs e)
        {
            txt_addCreditAmount.SelectAll();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

        private void cbo_CMReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo_CMReason.Text.Trim())
            {
                case "SRCM":
                    txt_CMReason.Text = "Sales rep credit memo";
                    break;
                case "DCM":
                    txt_CMReason.Text = "Direct credit memo";
                    break;
                case "NCS":
                    txt_CMReason.Text = "Not Compliant with shipment";
                    break;
                case "PFCM":
                    txt_CMReason.Text = "PF Cedit memo";
                    break;
                case "CRCM":
                    txt_CMReason.Text = "Cheese return Credit memo";
                    break;
                case "DAD":
                    txt_CMReason.Text = "Damaged";
                    break;
                case "AC":
                    txt_CMReason.Text = "Account Changed";
                    break;
                case "LD":
                    txt_CMReason.Text = "Late delivery";
                    break;
                case "NO":
                    txt_CMReason.Text = "Not ordered";
                    break;
                case "IP":
                    txt_CMReason.Text = "Incorrect price";
                    break;
                case "QE":
                    txt_CMReason.Text = "Quantity error";
                    break;
                case "DIS":
                    txt_CMReason.Text = "Discount";
                    break;
                case "MISC":
                    txt_CMReason.Text = "Miscellaneous";
                    break;
                default:
                    txt_CMReason.Text = "";
                    break;
            }
        }

    }
}
