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
    public partial class DeliveryNote : Form
    {

        int RouteNumber; // RouteNumber 초기화
        string RouteDriver, RouteTruck;
        decimal RouteAmount;
        int i = 0; // i 초기화
        String SelectedOrderID; //Route에서 선택한 order를 지우기 위한 초기화

        public DeliveryNote()
        {
            InitializeComponent();

            grid_RouteHeader_Init();
            grid_RouteDetail_Init();
            grid_PickingNumber_Init();
            refresh_header();
        }

        private void grid_RouteHeader_Init()
        {
            grid_RouteHeader.AutoGenerateColumns = false;
            grid_RouteHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_RouteHeader.ColumnCount = 4;

            grid_RouteHeader.Columns[0].Name = "RTN";
            grid_RouteHeader.Columns[0].ReadOnly = true;
            grid_RouteHeader.Columns[0].Width = 50;
            grid_RouteHeader.Columns[0].DataPropertyName = "RouteNumber";

            grid_RouteHeader.Columns[1].Name = "Driver";
            grid_RouteHeader.Columns[1].ReadOnly = true;
            grid_RouteHeader.Columns[1].Width = 150;
            grid_RouteHeader.Columns[1].DataPropertyName = "DriverName";

            grid_RouteHeader.Columns[2].Name = "Truck";
            grid_RouteHeader.Columns[2].ReadOnly = true;
            grid_RouteHeader.Columns[2].Width = 120;
            grid_RouteHeader.Columns[2].DataPropertyName = "TruckPlateNumber";
            
            DataGridViewCheckBoxColumn invoiceCompleteCheck = new DataGridViewCheckBoxColumn();
            invoiceCompleteCheck.HeaderText = "R";
            invoiceCompleteCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invoiceCompleteCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invoiceCompleteCheck.FalseValue = false;
            invoiceCompleteCheck.TrueValue = true;
            invoiceCompleteCheck.Name = "invoiceCompleteCheck";
            invoiceCompleteCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            invoiceCompleteCheck.ReadOnly = true;
            invoiceCompleteCheck.Width = 30;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_RouteHeader.Columns.Insert(3, invoiceCompleteCheck);
            grid_RouteHeader.CellContentClick += new DataGridViewCellEventHandler(invoiceCheck);
            
            grid_RouteHeader.Columns[4].Name = "InvoiceComplete";
            grid_RouteHeader.Columns[4].Visible = false;
            grid_RouteHeader.Columns[4].Width = 30;
            grid_RouteHeader.Columns[4].DataPropertyName = "InvoiceComplete";


            
            //grid font size custom
            grid_RouteHeader.RowTemplate.Height = 20;
            grid_RouteHeader.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_RouteHeader.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_RouteHeader.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void invoiceCheck(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_RouteDetail_Init()
        {
            grid_RouteDetail.AutoGenerateColumns = false;
            grid_RouteDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_RouteDetail.ColumnCount = 6;

            grid_RouteDetail.Columns[0].Name = "Stop";
            grid_RouteDetail.Columns[0].ReadOnly = true;
            grid_RouteDetail.Columns[0].Width = 40;
            grid_RouteDetail.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RouteDetail.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RouteDetail.Columns[0].DataPropertyName = "RouteStop";

            grid_RouteDetail.Columns[1].Name = "OrderID";
            grid_RouteDetail.Columns[1].ReadOnly = true;
            grid_RouteDetail.Columns[1].Width = 100;
            grid_RouteDetail.Columns[1].MinimumWidth = 100;
            grid_RouteDetail.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[1].DataPropertyName = "OrderID";

            grid_RouteDetail.Columns[2].Name = "CustomerID";
            grid_RouteDetail.Columns[2].ReadOnly = true;
            grid_RouteDetail.Columns[2].Width = 100;
            grid_RouteDetail.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[2].DataPropertyName = "CustomerID";

            grid_RouteDetail.Columns[3].Name = "Address";
            grid_RouteDetail.Columns[3].ReadOnly = true;
            grid_RouteDetail.Columns[3].Width = 200;
            grid_RouteDetail.Columns[3].Width = 200;
            grid_RouteDetail.Columns[3].DataPropertyName = "ShipAddress1";
            
            grid_RouteDetail.Columns[4].Name = "Order Date";
            grid_RouteDetail.Columns[4].Width = 80;
            grid_RouteDetail.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_RouteDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RouteDetail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RouteDetail.Columns[4].DataPropertyName = "OrderDate";

            grid_RouteDetail.Columns[5].Name = "OrderStatus";
            grid_RouteDetail.Columns[5].Visible = false;
            grid_RouteDetail.Columns[5].DataPropertyName = "OrderStatus";

            //grid font size custom
            grid_RouteDetail.RowTemplate.Height = 20;
            grid_RouteDetail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_RouteDetail.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_RouteDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_PickingNumber_Init()
        {
            grid_PickingNumber.AutoGenerateColumns = false;
            grid_PickingNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_PickingNumber.ColumnCount = 5;

            grid_PickingNumber.Columns[0].Name = "Picking Number";
            grid_PickingNumber.Columns[0].ReadOnly = true;
            grid_PickingNumber.Columns[0].Width = 80;
            grid_PickingNumber.Columns[0].MinimumWidth = 80;
            grid_PickingNumber.Columns[0].DataPropertyName = "PickingNumber";

            grid_PickingNumber.Columns[1].Name = "";
            grid_PickingNumber.Columns[1].ReadOnly = true;
            grid_PickingNumber.Columns[1].Width = 30;
            grid_PickingNumber.Columns[1].MinimumWidth = 30;
            grid_PickingNumber.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PickingNumber.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PickingNumber.Columns[1].DataPropertyName = "Category";

            grid_PickingNumber.Columns[2].Name = "Box";
            grid_PickingNumber.Columns[2].ReadOnly = true;
            grid_PickingNumber.Columns[2].Width = 40;
            grid_PickingNumber.Columns[2].MinimumWidth = 40;
            grid_PickingNumber.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PickingNumber.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PickingNumber.Columns[2].DataPropertyName = "Box";

            grid_PickingNumber.Columns[3].Name = "OrderID";
            grid_PickingNumber.Columns[3].ReadOnly = true;
            grid_PickingNumber.Columns[3].Width = 90;
            grid_PickingNumber.Columns[3].MinimumWidth = 90;
            grid_PickingNumber.Columns[3].DataPropertyName = "OrderID";
            
            grid_PickingNumber.Columns[4].Name = "Status";
            //grid_PickingNumber.Columns[4].Visible = false;
            grid_PickingNumber.Columns[4].ReadOnly = true;
            grid_PickingNumber.Columns[4].Width = 80;
            grid_PickingNumber.Columns[4].MinimumWidth = 80;
            grid_PickingNumber.Columns[4].DataPropertyName = "Status";

            //grid font size custom
            grid_RouteDetail.RowTemplate.Height = 20;
            grid_RouteDetail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_PickingNumber.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_PickingNumber.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void dateTimePicker_receiptDate_ValueChanged(object sender, EventArgs e)
        {
            
            refresh_header();

        }

        private void refresh_header() // header grid refresh
        {
            if (cbox_vendor.Checked)
            {
                connSalesOrder.sp_GET_Route_HEADERS_VENDOR(grid_RouteHeader, dateTimePicker_receiptDate);
            }
            else
            {
                connSalesOrder.sp_GET_Route_HEADERS(grid_RouteHeader, dateTimePicker_receiptDate);
            }
            

            foreach (DataGridViewRow item in grid_RouteHeader.Rows)
            {


                if (item.Cells["InvoiceComplete"].Value.ToString().Trim() == "Y")
                {
                    item.Cells["invoiceCompleteCheck"].Value = true;
                }
            }
            grid_RouteDetail.DataSource = null;
            grid_PickingNumber.DataSource = null;
            grid_RouteHeader.ClearSelection();
        }



        private void grid_RouteDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String orderID = grid_RouteDetail.Rows[e.RowIndex].Cells["OrderID"].Value.ToString().Trim();
                if (connSalesOrder.getOrderStatusFromSPick(orderID) != "DeliveryInvoice")
                {
                    MessageBox.Show("The Delivery Invoice " + SelectedOrderID + " never been made.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    //String OrderID = grid_RouteDetail.Rows[e.RowIndex].Cells["OrderID"].Value.ToString().Trim();
                    //Rpt_DeliveryInvoice rpt_DeliveryInvoice = new Rpt_DeliveryInvoice(OrderID);
                    //rpt_DeliveryInvoice.Show();

                    String OrderID = grid_RouteDetail.Rows[e.RowIndex].Cells["OrderID"].Value.ToString().Trim();
                    if (checkbox_Matrix.Checked == true && checkbox_Laser.Checked == false)
                    {
                        Rpt_DeliveryInvoice rpt_DeliveryInvoice = new Rpt_DeliveryInvoice(OrderID);
                        rpt_DeliveryInvoice.Show();
                    }
                    else if (checkbox_Laser.Checked == true && checkbox_Matrix.Checked == false)
                    {
                        Rpt_DeliveryInvoiceLaser rpt_DeliveryInvoice = new Rpt_DeliveryInvoiceLaser(OrderID);
                        rpt_DeliveryInvoice.Show();
                    }
                }
            }
            catch
            {

            }
        }

        private string OrderID = "";
        private string CustomerID = "";
        private void grid_RouteDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            OrderID = grid_RouteDetail.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
            //connSalesOrder.grid_PickingNumber(grid_PickingNumber, OrderID);
            CustomerID = grid_RouteDetail.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
            try
            {
                String OrderID = grid_RouteDetail.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                SelectedOrderID = OrderID;
                connSalesOrder.grid_PickingNumber(grid_PickingNumber, OrderID);
                grid_PickingNumber.ClearSelection();

                bool done = true;
                for (int i = 0; i < grid_PickingNumber.RowCount; i++)
                {

                    if (grid_PickingNumber.Rows[i].Cells["Status"].Value.ToString() == "")
                    {
                        grid_PickingNumber.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        grid_PickingNumber.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        done = false;
                    }
                    else
                    {
                        //grid_PickingNumber.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        //grid_PickingNumber.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
                if (done == true)
                {
                    btn_deliveryList.Enabled = true;
                }
                else
                {
                    btn_deliveryList.Enabled = false;
                }
                cellUpdate();
            }
            catch
            {

            }

            
        }

        private void btn_deliveryList_Click(object sender, EventArgs e)
        {
            //delivery 테이블에 order number 가지고 적혀있는지 확인
            String ReturnMessage = connSalesOrder.sp_Check_DeliveryInvoice(OrderID);
            if (ReturnMessage != "OK")
            {
                MessageBox.Show(ReturnMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure create delivery list?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                
                //Get a new Delivery Number from Server 12/28/2018
                if (connSalesOrder.sp_GET_PickStatus(SelectedOrderID) == "DeliveryInvoice")
                {
                    MessageBox.Show("The Delivery Invoice " + SelectedOrderID + " already has been made.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    /*
                    String NewDeliveryNumber = connSalesOrder.sp_GET_NewDeliveryNumber();
                    //MessageBox.Show(NewDeliveryNumber);
                    if (!NewDeliveryNumber.Contains("DBCS"))
                    {
                        MessageBox.Show("Please try again.(DBCS) (Error code: " + NewDeliveryNumber + ")"
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    String NewSTKNumber = connSalesOrder.sp_GET_NewSTKNumber();
                    if (!NewSTKNumber.Contains("STK"))
                    {
                        MessageBox.Show("Please try again.(STK) (Error code: " + NewSTKNumber + ")"
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    //STOALL 에서 global 잡혀있는 모든 STOALL 지운다.
                    connSalesOrder.sp_CREATE_Delivery(SelectedOrderID, NewSTKNumber, NewDeliveryNumber);
                    connSalesOrder.sp_CREATE_DeliveryDetail(SelectedOrderID, NewSTKNumber, NewDeliveryNumber);

                    MessageBox.Show("The Delivery Invoice " + SelectedOrderID + ", " + NewDeliveryNumber + " has been made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    */

                    connSalesOrder.sp_CREATE_DeliveryNote(SelectedOrderID); //updated on 6/16/2022 3:54PM

                    MessageBox.Show("The Delivery Invoice " + SelectedOrderID + " has been made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (DataGridViewRow item in grid_RouteDetail.Rows)
                    {
                        if (item.Cells["OrderID"].Value.ToString() == SelectedOrderID)
                        {
                            item.Cells["OrderStatus"].Value = "DeliveryInvoice";
                            item.DefaultCellStyle.BackColor = Color.GreenYellow;
                            item.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
                            break;
                        }
                    }
                }

                connSalesOrder.sp_GET_PickingList(grid_PickingNumber, RouteNumber.ToString());

                //delivery note STOALL
                //connSalesOrder.sp_Allocation_PickingList(sTOALL);

            }
            else if (dialogResult == DialogResult.No)
            {

            }

            
        }

        private void cellUpdate()
        {
            foreach (DataGridViewRow item in grid_RouteDetail.Rows)
            {
                if (item.Cells["OrderStatus"].Value.ToString() == "DeliveryInvoice")
                {
                    item.DefaultCellStyle.BackColor = Color.GreenYellow;
                    item.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
                    //item.DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else
                {
                    item.DefaultCellStyle.BackColor = Color.Empty;
                    item.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                    //item.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }

            foreach (DataGridViewRow item in grid_PickingNumber.Rows)
            {
                if (item.Cells["Status"].Value.ToString() == "")
                {
                    item.DefaultCellStyle.BackColor = Color.Red;
                    item.DefaultCellStyle.SelectionBackColor = Color.Crimson;
                    item.DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else
                {
                    //item.DefaultCellStyle.BackColor = Color.Empty;
                    //item.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                    item.DefaultCellStyle.BackColor = Color.GreenYellow;
                    item.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
                    item.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

        private void grid_RouteDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //{
                
            //    try
            //    {

            //        //String orderID = grid_RouteDetail.Rows[e.RowIndex].Cells["OrderID"].Value.ToString().Trim();
            //        if (connSalesOrder.getOrderStatusFromSPick(OrderID) != "DeliveryInvoice")
            //        {
            //            MessageBox.Show("The Delivery Invoice " + SelectedOrderID + " never been made.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //            return;
            //        }
            //        else
            //        {
            //            //String OrderID = grid_RouteDetail.Rows[e.RowIndex].Cells["OrderID"].Value.ToString().Trim();
            //            Rpt_DeliveryInvoice rpt_DeliveryInvoice = new Rpt_DeliveryInvoice(OrderID);
            //            rpt_DeliveryInvoice.Show();
            //        }

            //    }
            //    catch
            //    {

            //    }
            //}

            

        }

        private void grid_RouteDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {

                    //String orderID = grid_RouteDetail.Rows[e.RowIndex].Cells["OrderID"].Value.ToString().Trim();
                    if (connSalesOrder.getOrderStatusFromSPick(OrderID) != "DeliveryInvoice")
                    {
                        MessageBox.Show("The Delivery Invoice " + SelectedOrderID + " never been made.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
                        //String OrderID = grid_RouteDetail.Rows[e.RowIndex].Cells["OrderID"].Value.ToString().Trim();
                        //Rpt_DeliveryInvoice rpt_DeliveryInvoice = new Rpt_DeliveryInvoice(OrderID);
                        //rpt_DeliveryInvoice.Show();

                        if (checkbox_Matrix.Checked == true && checkbox_Laser.Checked == false)
                        {
                            Rpt_DeliveryInvoice rpt_DeliveryInvoice = new Rpt_DeliveryInvoice(OrderID);
                            rpt_DeliveryInvoice.Show();
                        }
                        else if (checkbox_Laser.Checked == true && checkbox_Matrix.Checked == false)
                        {
                            Rpt_DeliveryInvoiceLaser rpt_DeliveryInvoice = new Rpt_DeliveryInvoiceLaser(OrderID);
                            rpt_DeliveryInvoice.Show();
                        }
                    }

                }
                catch
                {

                }
            }
        }

        private void btn_deliveryList2_Click(object sender, EventArgs e)
        {
            try
            {
                RouteAmount = connSalesOrder.sp_GET_Route_Amount(RouteNumber);

                String RouteStatus = connSalesOrder.sp_GET_RouteStatus(RouteNumber);
                if (RouteStatus != "Finish")
                {
                    MessageBox.Show("This Route Number has never been made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                Rpt_CourseList rpt_CourseList = new Rpt_CourseList(RouteNumber, RouteDriver, RouteTruck, RouteAmount.ToString("N2"));
                rpt_CourseList.Show();
            }
            catch
            {
                MessageBox.Show("This Route Number has never been finished process.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void grid_RouteHeader_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RouteNumber = Convert.ToInt32(grid_RouteHeader.Rows[e.RowIndex].Cells["RTN"].Value); //초기화 한 RouteNumber 정의
                string RouteNumberString = grid_RouteHeader.Rows[e.RowIndex].Cells["RTN"].Value.ToString(); //RouteNumber String 형
                RouteDriver = grid_RouteHeader.Rows[e.RowIndex].Cells["Driver"].Value.ToString(); //RouteNumber String 형
                RouteTruck = grid_RouteHeader.Rows[e.RowIndex].Cells["Truck"].Value.ToString(); //RouteNumber String 형
                //RouteAmount = connSalesOrder.sp_GET_Route_Amount(RouteNumber);



                i = 0;

                SelectedOrderID = ""; //RouteNumber에서 order를 지우기위한 OrderID 초기화

                connSalesOrder.grid_RouteDetailfromPick(grid_RouteDetail, RouteNumberString); // Fill detail gird
                grid_RouteDetail.ClearSelection(); // detail gird clear selection
                grid_PickingNumber.DataSource = null;
                connSalesOrder.sp_GET_PickingList(grid_PickingNumber, RouteNumberString);
                grid_PickingNumber.ClearSelection();
                
                btn_deliveryList.Enabled = false;

                cellUpdate();
            }
            catch
            {

            }
        }

        private void grid_RouteDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkbox_Laser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_Laser.Checked == true == true && checkbox_Matrix.Checked == true)
            {
                MessageBox.Show("Only one option available at a time. Please choose the printer you would like to use.");
                checkbox_Matrix.Checked = false;
                checkbox_Laser.Checked = false;
            }
        }

        private void checkbox_Matrix_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_Laser.Checked == true && checkbox_Matrix.Checked == true)
            {
                MessageBox.Show("Only one option available at a time. Please choose the printer you would like to use.");
                checkbox_Matrix.Checked = false;
                checkbox_Laser.Checked = false;
            }
        }

        private void cbox_vendor_CheckedChanged(object sender, EventArgs e)
        {
            refresh_header();
        }
    }
}
