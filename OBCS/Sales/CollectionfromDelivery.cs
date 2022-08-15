using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBCS.Entities;
using OBCS.Reports;

namespace OBCS.Sales
{
    public partial class CollectionfromDelivery : Form
    {
        int RouteNumber; // RouteNumber 초기화
        int i = 0; // i 초기화
        String SelectedOrderID; //Route에서 선택한 order를 지우기 위한 초기화

        public CollectionfromDelivery()
        {
            InitializeComponent();
            //monthCalendar1.ShowWeekNumbers = true;
            grid_DRIVER_Init();
            grid_DETAIL_Init();

            refresh_header();

            //detail grid multi line allow
            grid_DETAIL.AllowDrop = true;
            grid_DETAIL.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_DETAIL.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DateTime LastDateofBusiness;
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                LastDateofBusiness = DateTime.Today.AddDays(-3);
            }
            else if(DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                LastDateofBusiness = DateTime.Today.AddDays(-2);
            }
            else
            {
                LastDateofBusiness = DateTime.Today.AddDays(-1);
            }
            monthCalendar1.SetDate(LastDateofBusiness);
        }

        private void grid_DRIVER_Init()
        {
            grid_DRIVER.AutoGenerateColumns = false;
            grid_DRIVER.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_DRIVER.ColumnCount = 3;

            grid_DRIVER.Columns[0].Name = "RTN";
            grid_DRIVER.Columns[0].ReadOnly = true;
            grid_DRIVER.Columns[0].Width = 50;
            grid_DRIVER.Columns[0].DataPropertyName = "RouteNumber";

            grid_DRIVER.Columns[1].Name = "Driver";
            grid_DRIVER.Columns[1].ReadOnly = true;
            grid_DRIVER.Columns[1].Width = 150;
            grid_DRIVER.Columns[1].DataPropertyName = "DriverName";

            grid_DRIVER.Columns[2].Name = "Truck";
            grid_DRIVER.Columns[2].ReadOnly = true;
            grid_DRIVER.Columns[2].Width = 120;
            grid_DRIVER.Columns[2].DataPropertyName = "TruckPlateNumber";
            
            
            //grid font size custom
            grid_DRIVER.RowTemplate.Height = 20;
            grid_DRIVER.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_DRIVER.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_DRIVER.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_DETAIL_Init()
        {
            grid_DETAIL.AutoGenerateColumns = false;
            grid_DETAIL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_DETAIL.ColumnCount = 10;
            
            grid_DETAIL.Columns[0].Name = "No.";
            grid_DETAIL.Columns[0].ReadOnly = true;
            grid_DETAIL.Columns[0].Width = 35;
            grid_DETAIL.Columns[0].DataPropertyName = "RouteStop";

            grid_DETAIL.Columns[1].Name = "FCY";
            grid_DETAIL.Columns[1].Visible = false;
            grid_DETAIL.Columns[1].ReadOnly = true;
            grid_DETAIL.Columns[1].Width = 250;
            grid_DETAIL.Columns[1].DataPropertyName = "";

            //grid_DETAIL.Columns[2].Name = "Order ID";
            //grid_DETAIL.Columns[2].ReadOnly = true;
            //grid_DETAIL.Columns[2].Width = 100;
            //grid_DETAIL.Columns[2].DataPropertyName = "OrderID";

            grid_DETAIL.Columns[2].Name = "Delivery Number";
            grid_DETAIL.Columns[2].ReadOnly = true;
            grid_DETAIL.Columns[2].Width = 100;
            grid_DETAIL.Columns[2].DataPropertyName = "DeliveryNumber";

            grid_DETAIL.Columns[3].Name = "Rep.";
            grid_DETAIL.Columns[3].ReadOnly = true;
            grid_DETAIL.Columns[3].Width = 40;
            grid_DETAIL.Columns[3].DataPropertyName = "SaleRep";
            
            grid_DETAIL.Columns[4].Name = "CustomerID";
            grid_DETAIL.Columns[4].ReadOnly = true;
            grid_DETAIL.Columns[4].Width = 100;
            grid_DETAIL.Columns[4].DataPropertyName = "CustomerID";

            grid_DETAIL.Columns[5].Name = "Company";
            grid_DETAIL.Columns[5].ReadOnly = true;
            grid_DETAIL.Columns[5].Width = 300;
            grid_DETAIL.Columns[5].DataPropertyName = "CustomerName";

            grid_DETAIL.Columns[6].Name = "Order Date";
            grid_DETAIL.Columns[6].ReadOnly = true;
            grid_DETAIL.Columns[6].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_DETAIL.Columns[6].Width = 80;
            grid_DETAIL.Columns[6].DataPropertyName = "OrderDate";
            
            grid_DETAIL.Columns[7].Name = "Paid";
            grid_DETAIL.Columns[7].ReadOnly = true;
            grid_DETAIL.Columns[7].Width = 350;
            grid_DETAIL.Columns[7].DataPropertyName = "";

            grid_DETAIL.Columns[8].Name = "Order ID";
            grid_DETAIL.Columns[8].Visible = false;
            grid_DETAIL.Columns[8].Width = 350;
            grid_DETAIL.Columns[8].DataPropertyName = "OrderID";

            DataGridViewCheckBoxColumn DeliveryNoteCheck = new DataGridViewCheckBoxColumn();
            DeliveryNoteCheck.HeaderText = "X";
            DeliveryNoteCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DeliveryNoteCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DeliveryNoteCheck.FalseValue = false;
            DeliveryNoteCheck.TrueValue = true;
            DeliveryNoteCheck.Name = "DeliveryNoteSelect";
            DeliveryNoteCheck.ReadOnly = true;
            DeliveryNoteCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DeliveryNoteCheck.Width = 25;
            DeliveryNoteCheck.MinimumWidth = 25;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_DETAIL.Columns.Insert(9, DeliveryNoteCheck);
            grid_DETAIL.CellContentClick += new DataGridViewCellEventHandler(DeliveryNoteSelect);
        
            grid_DETAIL.Columns[10].Name = "DeliveryNotePickup";
            grid_DETAIL.Columns[10].Visible = false;
            grid_DETAIL.Columns[10].Width = 50;
            grid_DETAIL.Columns[10].DataPropertyName = "DeliveryNotePickup";

            //grid font size custom
            grid_DETAIL.RowTemplate.Height = 35;
            grid_DETAIL.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_DETAIL.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_DETAIL.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void DeliveryNoteSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9) //Ready check box click
            {
                if (Convert.ToBoolean(grid_DETAIL.Rows[e.RowIndex].Cells["DeliveryNoteSelect"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                {
                    String DeliveryNumber = grid_DETAIL.Rows[e.RowIndex].Cells["Delivery Number"].Value.ToString().Trim();
                    String StopNumber = grid_DETAIL.Rows[e.RowIndex].Cells["No."].Value.ToString().Trim();
                    String CustomerID = grid_DETAIL.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString().Trim();
                    String CompanyName = grid_DETAIL.Rows[e.RowIndex].Cells["Company"].Value.ToString().Trim();
                    DialogResult dialogResult = MessageBox.Show(StopNumber + " / " + DeliveryNumber + " / " + CustomerID + " / " + CompanyName + "\nHave you confirmed that you have brought the delivery note?"
                                                       , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        grid_DETAIL.Rows[e.RowIndex].Cells["DeliveryNoteSelect"].Value = true;
                        connSalesOrder.sp_DeliveryMenifest_DeliveryNotePickup(DeliveryNumber, "Check");
                    }
                }
                else // uncheck 했을 때
                {
                    MessageBox.Show("Please contact the system administrator."
                                                       , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    //grid_DETAIL.Rows[e.RowIndex].Cells["DeliveryNoteSelect"].Value = false;
                    //String DeliveryNumber = grid_DETAIL.Rows[e.RowIndex].Cells["Delivery Number"].Value.ToString().Trim();
                    //connSalesOrder.sp_DeliveryMenifest_DeliveryNotePickup(DeliveryNumber, "Uncheck");
                }
            }
        }

        private void refresh_header() // header grid refresh
        {
            grid_DRIVER.DataSource = null;
            connSalesOrder.grid_DRIVER(grid_DRIVER, monthCalendar1);
            grid_DRIVER.ClearSelection();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show(monthCalendar1.SelectionRange.Start.ToShortDateString());
            refresh_header();
        }

        private void grid_DRIVER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RouteNumber = Convert.ToInt32(grid_DRIVER.Rows[e.RowIndex].Cells["RTN"].Value); //초기화 한 RouteNumber 정의
                string RouteNumberString = grid_DRIVER.Rows[e.RowIndex].Cells["RTN"].Value.ToString(); //RouteNumber String 형

                i = 0;

                SelectedOrderID = ""; //RouteNumber에서 order를 지우기위한 OrderID 초기화

                connSalesOrder.grid_DETAILSfromDelivery(grid_DETAIL, RouteNumberString); // Fill detail gird
                grid_DETAIL.ClearSelection(); // detail gird clear selection

                Entities.DeliveryManifest deliveryManifest = new Entities.DeliveryManifest();
                deliveryManifest = connSalesOrder.sp_GET_DeliveryManifest(RouteNumberString);

                txt_100.Text = Convert.ToDecimal(deliveryManifest.Bill100).ToString("C2");
                txt_50.Text = Convert.ToDecimal(deliveryManifest.Bill50).ToString("C2");
                txt_20.Text = Convert.ToDecimal(deliveryManifest.Bill20).ToString("C2");
                txt_10.Text = Convert.ToDecimal(deliveryManifest.Bill10).ToString("C2");
                txt_5.Text = Convert.ToDecimal(deliveryManifest.Bill5).ToString("C2");
                txt_2.Text = Convert.ToDecimal(deliveryManifest.Bill2).ToString("C2");
                txt_1.Text = Convert.ToDecimal(deliveryManifest.Bill1).ToString("C2");
                txt_coins.Text = Convert.ToDecimal(deliveryManifest.Coins).ToString("C2");
                txt_park.Text = Convert.ToDecimal(deliveryManifest.Park).ToString("C2");
                txt_gas.Text = Convert.ToDecimal(deliveryManifest.Gas).ToString("C2");
                txt_toll.Text = Convert.ToDecimal(deliveryManifest.Toll).ToString("C2");
                txt_misc.Text = Convert.ToDecimal(deliveryManifest.Misc).ToString("C2");

                decimal b100 = Convert.ToDecimal(txt_100.Text.ToString().Substring(1));
                decimal b50 = Convert.ToDecimal(txt_50.Text.ToString().Substring(1));
                decimal b20 = Convert.ToDecimal(txt_20.Text.ToString().Substring(1));
                decimal b10 = Convert.ToDecimal(txt_10.Text.ToString().Substring(1));
                decimal b5 = Convert.ToDecimal(txt_5.Text.ToString().Substring(1));
                decimal b2 = Convert.ToDecimal(txt_2.Text.ToString().Substring(1));
                decimal b1 = Convert.ToDecimal(txt_1.Text.ToString().Substring(1));
                decimal coins = Convert.ToDecimal(txt_coins.Text.ToString().Substring(1));

                txt_cashTotal.Text = (b100 + b50 + b20 + b10 + b5 + b2 + b1 + coins).ToString("C2");

                decimal park = Convert.ToDecimal(txt_park.Text.ToString().Substring(1));
                decimal gas = Convert.ToDecimal(txt_gas.Text.ToString().Substring(1));
                decimal toll = Convert.ToDecimal(txt_toll.Text.ToString().Substring(1));
                decimal misc = Convert.ToDecimal(txt_misc.Text.ToString().Substring(1));

                txt_expenseTotal.Text = (park + gas + toll + misc).ToString("C2");

                

                for (int i = 0; i < grid_DETAIL.RowCount; i++)
                {
                    if (grid_DETAIL.Rows[i].Cells["DeliveryNotePickup"].Value.ToString().Trim() == "Y")
                    {
                        grid_DETAIL.Rows[i].Cells["DeliveryNoteSelect"].Value = true;
                    }
                    
                    String OrderID = grid_DETAIL.Rows[i].Cells["Order ID"].Value.ToString();
                    Collection collection = new Collection();
                    collection = connSalesOrder.sp_Fetch_Order2CollectionInfo(OrderID);
                    //MessageBox.Show("1" + collection.CheckNo3.ToString() + "1");
                    String cashString;
                    if (collection.Cash.ToString() == "0.00")
                    {
                        cashString = "";
                    }
                    else
                    {
                        cashString = "Cash: $ " + collection.Cash.ToString() + "\n";
                    }

                    String check1String;
                    if (collection.CheckNo1.ToString().Equals(""))
                    {
                        check1String = "";
                    }
                    else
                    {
                        check1String = "CHK 01: (" + collection.CheckDate1.ToString("MM/dd/yyyy") + ") " + collection.CheckNo1 + " $" + collection.CheckAmount1 + "\n";
                    }

                    String check2String;
                    if (collection.CheckNo2.ToString().Equals(""))
                    {
                        check2String = "";
                    }
                    else
                    {
                        check2String = "CHK 02: (" + collection.CheckDate2.ToString("MM/dd/yyyy") + ") " + collection.CheckNo2 + " $" + collection.CheckAmount2 + "\n";
                    }

                    String check3String;
                    if (collection.CheckNo3.ToString().Equals(""))
                    {
                        check3String = "";
                    }
                    else
                    {
                        check3String = "CHK 03: (" + collection.CheckDate3.ToString("MM/dd/yyyy") + ") " + collection.CheckNo3 + " $" + collection.CheckAmount3 + "\n";
                    }

                    String check4String;
                    if (collection.CheckNo4.ToString().Equals(""))
                    {
                        check4String = "";
                    }
                    else
                    {
                        check4String = "CHK 04: (" + collection.CheckDate4.ToString("MM/dd/yyyy") + ") " + collection.CheckNo4 + " $" + collection.CheckAmount4 + "\n";
                    }

                    String check5String;
                    if (collection.CheckNo5.ToString().Equals(""))
                    {
                        check5String = "";
                    }
                    else
                    {
                        check5String = "CHK 05: (" + collection.CheckDate5.ToString("MM/dd/yyyy") + ") " + collection.CheckNo5 + " $" + collection.CheckAmount5 + "\n";
                    }

                    string Paid = "\n" + cashString + check1String + check2String + check3String + check4String + check5String;
                    if (Paid == "\n")
                    {
                        Paid = "Not Paid";
                    }
                    grid_DETAIL.Rows[i].Cells["Paid"].Value = Paid;
                }

                Decimal cashTotal = connSalesOrder.sp_GET_CashTotal(RouteNumberString);
                Decimal checkTotal = connSalesOrder.sp_GET_CheckTotal(RouteNumberString);

                txt_cashTotal2.Text = cashTotal.ToString();
                txt_checkTotal.Text = checkTotal.ToString();
                txt_subTotal.Text = (cashTotal + checkTotal).ToString();
            }
            catch
            {

            }
        }

        private void grid_DETAIL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String OrderID = grid_DETAIL.Rows[e.RowIndex].Cells["Order ID"].Value.ToString();
                CashCheckCollection cashCheckCollection = new CashCheckCollection(OrderID);
                cashCheckCollection.ShowDialog();

                connSalesOrder.grid_DETAILSfromDelivery(grid_DETAIL, RouteNumber.ToString()); // Fill detail gird
                grid_DETAIL.ClearSelection(); // detail gird clear selection

                for (int i = 0; i < grid_DETAIL.RowCount; i++)
                {
                    String OrderID2 = grid_DETAIL.Rows[i].Cells["Order ID"].Value.ToString();
                    Collection collection = new Collection();
                    collection = connSalesOrder.sp_Fetch_Order2CollectionInfo(OrderID2);
                    //MessageBox.Show("1" + collection.CheckNo3.ToString() + "1");
                    String cashString;
                    if (collection.Cash.ToString() == "0.00")
                    {
                        cashString = "";
                    }
                    else
                    {
                        cashString = "Cash: $ " + collection.Cash.ToString() + "\n";
                    }

                    String check1String;
                    if (collection.CheckNo1.ToString().Equals(""))
                    {
                        check1String = "";
                    }
                    else
                    {
                        check1String = "CHK 01: (" + collection.CheckDate1.ToString("MM/dd/yyyy") + ") " + collection.CheckNo1 + " $" + collection.CheckAmount1 + "\n";
                    }

                    String check2String;
                    if (collection.CheckNo2.ToString().Equals(""))
                    {
                        check2String = "";
                    }
                    else
                    {
                        check2String = "CHK 02: (" + collection.CheckDate2.ToString("MM/dd/yyyy") + ") " + collection.CheckNo2 + " $" + collection.CheckAmount2 + "\n";
                    }

                    String check3String;
                    if (collection.CheckNo3.ToString().Equals(""))
                    {
                        check3String = "";
                    }
                    else
                    {
                        check3String = "CHK 03: (" + collection.CheckDate3.ToString("MM/dd/yyyy") + ") " + collection.CheckNo3 + " $" + collection.CheckAmount3 + "\n";
                    }

                    String check4String;
                    if (collection.CheckNo4.ToString().Equals(""))
                    {
                        check4String = "";
                    }
                    else
                    {
                        check4String = "CHK 04: (" + collection.CheckDate4.ToString("MM/dd/yyyy") + ") " + collection.CheckNo4 + " $" + collection.CheckAmount4 + "\n";
                    }

                    String check5String;
                    if (collection.CheckNo5.ToString().Equals(""))
                    {
                        check5String = "";
                    }
                    else
                    {
                        check5String = "CHK 05: (" + collection.CheckDate5.ToString("MM/dd/yyyy") + ") " + collection.CheckNo5 + " $" + collection.CheckAmount5 + "\n";
                    }

                    string Paid = "\n" + cashString + check1String + check2String + check3String + check4String + check5String;
                    if (Paid == "\n")
                    {
                        Paid = "Not Paid";
                    }
                    grid_DETAIL.Rows[i].Cells["Paid"].Value = Paid;
                }

                Decimal cashTotal = connSalesOrder.sp_GET_CashTotal(RouteNumber.ToString());
                Decimal checkTotal = connSalesOrder.sp_GET_CheckTotal(RouteNumber.ToString());

                txt_cashTotal2.Text = cashTotal.ToString();
                txt_checkTotal.Text = checkTotal.ToString();
                txt_subTotal.Text = (cashTotal + checkTotal).ToString();
            }
            catch
            {

            }

        }


        private void button_Click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            
            InputNumber inputNumber = new InputNumber(button.Text);
            inputNumber.ShowDialog();


            switch (button.Name)
            {
                case "btn_100":
                    int input100 = Convert.ToInt32(InputNumber.input.ToString());
                    txt_100.Text = (100 * input100).ToString("C2");
                    break;
                case "btn_50":
                    int input50 = Convert.ToInt32(InputNumber.input.ToString());
                    txt_50.Text = (50 * input50).ToString("C2");
                    break;
                case "btn_20":
                    int input20 = Convert.ToInt32(InputNumber.input.ToString());
                    txt_20.Text = (20 * input20).ToString("C2");
                    break;
                case "btn_10":
                    int input10 = Convert.ToInt32(InputNumber.input.ToString());
                    txt_10.Text = (10 * input10).ToString("C2");
                    break;
                case "btn_5":
                    int input5 = Convert.ToInt32(InputNumber.input.ToString());
                    txt_5.Text = (5 * input5).ToString("C2");
                    break;
                case "btn_2":
                    int input2 = Convert.ToInt32(InputNumber.input.ToString());
                    txt_2.Text = (2 * input2).ToString("C2");
                    break;
                case "btn_1":
                    int input1 = Convert.ToInt32(InputNumber.input.ToString());
                    txt_1.Text = (1 * input1).ToString("C2");
                    break;
                case "btn_coins":
                    decimal inputCoins = Convert.ToDecimal(InputNumber.input.ToString());
                    txt_coins.Text = (1 * inputCoins).ToString("C2");
                    break;
                case "btn_park":
                    decimal inputPark = Convert.ToDecimal(InputNumber.input.ToString());
                    txt_park.Text = (1 * inputPark).ToString("C2");
                    break;
                case "btn_gas":
                    decimal inputGas = Convert.ToDecimal(InputNumber.input.ToString());
                    txt_gas.Text = (1 * inputGas).ToString("C2");
                    break;
                case "btn_toll":
                    decimal inputToll = Convert.ToDecimal(InputNumber.input.ToString());
                    txt_toll.Text = (1 * inputToll).ToString("C2");
                    break;
                case "btn_misc":
                    decimal inputMisc = Convert.ToDecimal(InputNumber.input.ToString());
                    txt_misc.Text = (1 * inputMisc).ToString("C2");
                    break;
            }

            
            decimal b100 = Convert.ToDecimal(txt_100.Text.ToString().Substring(1));
            decimal b50 = Convert.ToDecimal(txt_50.Text.ToString().Substring(1));
            decimal b20 = Convert.ToDecimal(txt_20.Text.ToString().Substring(1));
            decimal b10 = Convert.ToDecimal(txt_10.Text.ToString().Substring(1));
            decimal b5 = Convert.ToDecimal(txt_5.Text.ToString().Substring(1));
            decimal b2 = Convert.ToDecimal(txt_2.Text.ToString().Substring(1));
            decimal b1 = Convert.ToDecimal(txt_1.Text.ToString().Substring(1));
            decimal coins = Convert.ToDecimal(txt_coins.Text.ToString().Substring(1));

            txt_cashTotal.Text = (b100 + b50 + b20 + b10 + b5 + b2 + b1 + coins).ToString("C2");

            decimal park = Convert.ToDecimal(txt_park.Text.ToString().Substring(1));
            decimal gas = Convert.ToDecimal(txt_gas.Text.ToString().Substring(1));
            decimal toll = Convert.ToDecimal(txt_toll.Text.ToString().Substring(1));
            decimal misc = Convert.ToDecimal(txt_misc.Text.ToString().Substring(1));


            txt_expenseTotal.Text = (park + gas + toll + misc).ToString("C2");

            Entities.DeliveryManifest deliveryManifest = new Entities.DeliveryManifest();
            deliveryManifest.Bill100 = b100;
            deliveryManifest.Bill50 = b50;
            deliveryManifest.Bill20 = b20;
            deliveryManifest.Bill10 = b10;
            deliveryManifest.Bill5 = b5;
            deliveryManifest.Bill2 = b2;
            deliveryManifest.Bill1 = b1;
            deliveryManifest.Coins = coins;
            deliveryManifest.Park = park;
            deliveryManifest.Gas = gas;
            deliveryManifest.Toll = toll;
            deliveryManifest.Misc = misc;

            connSalesOrder.sp_Update_DeliveryManifest(RouteNumber, deliveryManifest);

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Rpt_DriverCollection rpt_DriverCollection = new Rpt_DriverCollection(RouteNumber);
            rpt_DriverCollection.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }
    }
}
