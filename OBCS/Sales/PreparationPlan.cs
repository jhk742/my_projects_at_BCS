using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using OBCS.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Sales
{
    [System.Runtime.InteropServices.Guid("3DCAD836-2195-41D8-A685-BE6A0268978F")]
    public interface IMyInterface
    {
        void MarkTheMap(DataGridView gridRouteDetail);
        void FocusTheMap(DataGridView gridRouteDetail, int RowNumber);
    }
    
    public partial class PreparationPlan : Form, IMyInterface
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        //int selection = 0;
        //double BCSlatitude = 40.742164;
        //double BCSlongitude = -73.931789;
        //int Zoom = 11;

        int RouteNumber; // RouteNumber 초기화
        string RouteFinish;
        string RouteDriver;
        string RouteTruck;
        decimal RouteAmount;

        int i = 0; // i 초기화
        String SelectedOrderID; //Route에서 선택한 order를 지우기 위한 초기화
        RouteMap routeMap;

        public PreparationPlan()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            cbo_drivers.Items.Add("VENDOR");
            connSalesOrder.cbo_Driver(cbo_drivers); //driver cbo loading
            cbo_trucks.Items.Add("PICK UP");
            connSalesOrder.cbo_Truck(cbo_trucks); //truck cbo loadking

            grid_RouteHeader_Init(); //header grid init
            grid_RouteDetail_Init(); //detail grid init
            grid_RouteDeliveryPlan_Init(); //sort grid init

            //detail grid multi line allow
            grid_RouteDetail.AllowDrop = true;
            grid_RouteDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_RouteDetail.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //grid_RTTMPD.AllowUserToAddRows = true;

            if (GATE.userID == "WH01")
            {
                btn_createPickingList.Visible = false;
            }
            //btn_selectOrders.Enabled = false;
            btn_deleteRouteOrders.Enabled = false;
            btn_DeleteAll.Enabled = false;
            btn_Sort.Enabled = false;
            cbo_SearchCode.Enabled = false;

            for (int i = 0; i < grid_RouteDetail.ColumnCount; i++)
            {
                grid_RouteDetail.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < grid_RouteHeader.ColumnCount; i++)
            {
                grid_RouteHeader.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            btn_createPickingList.Enabled = false;

            connSalesOrder.cbo_RouteCode(cbo_SearchCode);
        }

        private void grid_RouteHeader_Init()
        {
            grid_RouteHeader.AutoGenerateColumns = false;
            grid_RouteHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_RouteHeader.ColumnCount = 8;
            
            DataGridViewCheckBoxColumn readyCheck = new DataGridViewCheckBoxColumn();
            readyCheck.HeaderText = "R";
            readyCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            readyCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            readyCheck.FalseValue = false;
            readyCheck.TrueValue = true;
            readyCheck.Name = "ReadyCheckBox";
            readyCheck.ReadOnly = true;
            readyCheck.Width = 30;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            readyCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteHeader.Columns.Insert(0, readyCheck);
            grid_RouteHeader.CellContentClick += new DataGridViewCellEventHandler(readycellclick);

            grid_RouteHeader.Columns[1].Name = "RTN";
            grid_RouteHeader.Columns[1].ReadOnly = true;
            grid_RouteHeader.Columns[1].Width = 50;
            grid_RouteHeader.Columns[1].DataPropertyName = "RouteNumber";

            grid_RouteHeader.Columns[2].Name = "Driver";
            grid_RouteHeader.Columns[2].ReadOnly = true;
            grid_RouteHeader.Columns[2].Width = 150;
            grid_RouteHeader.Columns[2].DataPropertyName = "DriverName";

            grid_RouteHeader.Columns[3].Name = "Truck";
            grid_RouteHeader.Columns[3].ReadOnly = true;
            grid_RouteHeader.Columns[3].Width = 120;
            grid_RouteHeader.Columns[3].DataPropertyName = "TruckPlateNumber";

            grid_RouteHeader.Columns[4].Name = "CRS";
            grid_RouteHeader.Columns[4].ReadOnly = true;
            grid_RouteHeader.Columns[4].Width = 35;
            grid_RouteHeader.Columns[4].DataPropertyName = "CRS";


            DataGridViewCheckBoxColumn finishCheck = new DataGridViewCheckBoxColumn();
            finishCheck.HeaderText = "F";
            finishCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            finishCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            finishCheck.FalseValue = false;
            finishCheck.TrueValue = true;
            finishCheck.Name = "CheckBox";
            finishCheck.ReadOnly = true;
            finishCheck.Width = 30;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            finishCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteHeader.Columns.Insert(5, finishCheck);
            grid_RouteHeader.CellContentClick += new DataGridViewCellEventHandler(gridcellclick);

            grid_RouteHeader.Columns[6].Name = "P";
            grid_RouteHeader.Columns[6].Visible = false;
            grid_RouteHeader.Columns[6].Width = 30;
            grid_RouteHeader.Columns[6].DataPropertyName = "Complete";

            grid_RouteHeader.Columns[7].Name = "Finish";
            grid_RouteHeader.Columns[7].Visible = false;
            grid_RouteHeader.Columns[7].DataPropertyName = "Complete";

            grid_RouteHeader.Columns[8].Name = "Ready";
            grid_RouteHeader.Columns[8].Visible = false;
            grid_RouteHeader.Columns[8].DataPropertyName = "Ready";

            grid_RouteHeader.Columns[9].Name = "RouteStatus";
            grid_RouteHeader.Columns[9].Visible = false;
            grid_RouteHeader.Columns[9].DataPropertyName = "RouteStatus";


            //grid font size custom
            grid_RouteHeader.RowTemplate.Height = 20;
            grid_RouteHeader.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_RouteHeader.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_RouteHeader.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_RouteDetail_Init()
        {
            grid_RouteDetail.AutoGenerateColumns = false;
            grid_RouteDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_RouteDetail.ColumnCount = 17;
            
            grid_RouteDetail.Columns[0].Name = "Stop";
            grid_RouteDetail.Columns[0].ReadOnly = true;
            grid_RouteDetail.Columns[0].Width = 40;
            grid_RouteDetail.Columns[0].MinimumWidth = 40;
            grid_RouteDetail.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RouteDetail.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RouteDetail.Columns[0].DataPropertyName = "RouteStop";

            grid_RouteDetail.Columns[1].Name = "Memo";
            grid_RouteDetail.Columns[1].ReadOnly = true;
            grid_RouteDetail.Columns[1].Width = 200;
            grid_RouteDetail.Columns[1].MinimumWidth = 200;
            grid_RouteDetail.Columns[1].DataPropertyName = "OrderMemo";

            grid_RouteDetail.Columns[2].Name = "Memo2";
            grid_RouteDetail.Columns[2].ReadOnly = true;
            grid_RouteDetail.Columns[2].Width = 100;
            grid_RouteDetail.Columns[2].MinimumWidth = 100;
            grid_RouteDetail.Columns[2].DataPropertyName = "ShipAddress2";

            grid_RouteDetail.Columns[3].Name = "Audit Memo";
            grid_RouteDetail.Columns[3].ReadOnly = true;
            grid_RouteDetail.Columns[3].Width = 100;
            grid_RouteDetail.Columns[3].MinimumWidth = 100;
            grid_RouteDetail.Columns[3].DataPropertyName = "AuditMemo";

            grid_RouteDetail.Columns[4].Name = "Address";
            grid_RouteDetail.Columns[4].ReadOnly = true;
            grid_RouteDetail.Columns[4].Width = 200;
            grid_RouteDetail.Columns[4].MinimumWidth = 200;
            grid_RouteDetail.Columns[4].DataPropertyName = "ShipAddress1";

            grid_RouteDetail.Columns[5].Name = "City";
            grid_RouteDetail.Columns[5].ReadOnly = true;
            grid_RouteDetail.Columns[5].Width = 100;
            grid_RouteDetail.Columns[5].MinimumWidth = 100;
            grid_RouteDetail.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[5].DataPropertyName = "ShipCity";

            grid_RouteDetail.Columns[6].Name = "State";
            grid_RouteDetail.Columns[6].ReadOnly = true;
            grid_RouteDetail.Columns[6].Width = 40;
            grid_RouteDetail.Columns[6].MinimumWidth = 40;
            grid_RouteDetail.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RouteDetail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RouteDetail.Columns[6].DataPropertyName = "ShipState";

            grid_RouteDetail.Columns[7].Name = "ZIP";
            grid_RouteDetail.Columns[7].ReadOnly = true;
            grid_RouteDetail.Columns[7].Width = 50;
            grid_RouteDetail.Columns[7].MinimumWidth = 50;
            grid_RouteDetail.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RouteDetail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RouteDetail.Columns[7].DataPropertyName = "ShipZip";

            grid_RouteDetail.Columns[8].Name = "Ord. Amount";
            grid_RouteDetail.Columns[8].ReadOnly = true;
            grid_RouteDetail.Columns[8].Width = 70;
            grid_RouteDetail.Columns[8].MinimumWidth = 70;
            grid_RouteDetail.Columns[8].DefaultCellStyle.Format = "N2";
            grid_RouteDetail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_RouteDetail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_RouteDetail.Columns[8].DataPropertyName = "Amount";

            grid_RouteDetail.Columns[9].Name = "Order No.";
            grid_RouteDetail.Columns[9].ReadOnly = true;
            grid_RouteDetail.Columns[9].Width = 95;
            grid_RouteDetail.Columns[9].MinimumWidth = 95;
            grid_RouteDetail.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[9].DataPropertyName = "OrderID";
        
            grid_RouteDetail.Columns[10].Name = "Delv. No";
            grid_RouteDetail.Columns[10].Visible = false;
            grid_RouteDetail.Columns[10].Width = 100;
            grid_RouteDetail.Columns[10].MinimumWidth = 100;
            grid_RouteDetail.Columns[10].DataPropertyName = "";

            grid_RouteDetail.Columns[11].Name = "Order Date";
            grid_RouteDetail.Columns[11].ReadOnly = true;
            grid_RouteDetail.Columns[11].Width = 80;
            grid_RouteDetail.Columns[11].MinimumWidth = 80;
            grid_RouteDetail.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[11].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_RouteDetail.Columns[11].DataPropertyName = "OrderDate";

            grid_RouteDetail.Columns[12].Name = "Customer";
            grid_RouteDetail.Columns[12].ReadOnly = true;
            grid_RouteDetail.Columns[12].Width = 100;
            grid_RouteDetail.Columns[12].MinimumWidth = 100;
            grid_RouteDetail.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[12].DataPropertyName = "CustomerID";

            grid_RouteDetail.Columns[13].Name = "Rep.";
            grid_RouteDetail.Columns[13].ReadOnly = true;
            grid_RouteDetail.Columns[13].Width = 40;
            grid_RouteDetail.Columns[13].MinimumWidth = 40;
            grid_RouteDetail.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RouteDetail.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RouteDetail.Columns[13].DataPropertyName = "SaleRep";
            
            grid_RouteDetail.Columns[14].Name = "Department";
            grid_RouteDetail.Columns[14].ReadOnly = true;
            grid_RouteDetail.Columns[14].Width = 65;
            grid_RouteDetail.Columns[14].MinimumWidth = 65;
            grid_RouteDetail.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[14].DataPropertyName = "Dept";

            grid_RouteDetail.Columns[15].Name = "Latitude";
            grid_RouteDetail.Columns[15].ReadOnly = true;
            grid_RouteDetail.Columns[15].Visible = false;
            grid_RouteDetail.Columns[15].Width = 65;
            grid_RouteDetail.Columns[15].MinimumWidth = 65;
            grid_RouteDetail.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[15].DataPropertyName = "Latitude";

            grid_RouteDetail.Columns[16].Name = "Longitude";
            grid_RouteDetail.Columns[16].ReadOnly = true;
            grid_RouteDetail.Columns[16].Visible = false;
            grid_RouteDetail.Columns[16].Width = 65;
            grid_RouteDetail.Columns[16].MinimumWidth = 65;
            grid_RouteDetail.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns[16].DataPropertyName = "Longitude";

            DataGridViewCheckBoxColumn CheckBox = new DataGridViewCheckBoxColumn();
            CheckBox.HeaderText = "CheckBox";
            CheckBox.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CheckBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CheckBox.FalseValue = false;
            CheckBox.TrueValue = true;
            CheckBox.Name = "CheckBox";
            CheckBox.ReadOnly = true;
            CheckBox.Visible = false;
            CheckBox.Width = 30;
            CheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_RouteDetail.Columns.Insert(17, CheckBox);
            //grid_RouteDetail.CellContentClick += new DataGridViewCellEventHandler(readycellclick);
            //grid font size custom
            grid_RouteDetail.RowTemplate.Height = 20;
            grid_RouteDetail.ColumnHeadersHeight = 30;

            //grid font size custom
            grid_RouteDetail.RowTemplate.Height = 20;
            grid_RouteDetail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_RouteDetail.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_RouteDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_RouteDeliveryPlan_Init()
        {
            grid_RouteDeliveryPlan.AutoGenerateColumns = false;
            grid_RouteDeliveryPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_RouteDeliveryPlan.ColumnCount = 3;

            grid_RouteDeliveryPlan.Columns[0].Name = "RouteCode";
            grid_RouteDeliveryPlan.Columns[0].ReadOnly = true;
            grid_RouteDeliveryPlan.Columns[0].Width = 50;
            grid_RouteDeliveryPlan.Columns[0].DataPropertyName = "RouteCode";

            grid_RouteDeliveryPlan.Columns[1].Name = "RouteStop";
            grid_RouteDeliveryPlan.Columns[1].ReadOnly = true;
            grid_RouteDeliveryPlan.Columns[1].Width = 50;
            grid_RouteDeliveryPlan.Columns[1].DataPropertyName = "RouteStop";

            grid_RouteDeliveryPlan.Columns[2].Name = "CustomerID";
            grid_RouteDeliveryPlan.Columns[2].ReadOnly = true;
            grid_RouteDeliveryPlan.Columns[2].Width = 150;
            grid_RouteDeliveryPlan.Columns[2].DataPropertyName = "CustomerID";

            //grid font size custom
            grid_RouteDeliveryPlan.RowTemplate.Height = 20;
            grid_RouteDeliveryPlan.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_RouteDeliveryPlan.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_RouteDeliveryPlan.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void gridcellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.ColumnIndex >= 0) //finish check box click
            {
                if (Convert.ToBoolean(grid_RouteHeader.Rows[e.RowIndex].Cells["CheckBox"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                {
                    DialogResult dialogResult = MessageBox.Show("Are you finished setting up this route?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        grid_RouteHeader.Rows[e.RowIndex].Cells["CheckBox"].Value = true;
                        connSalesOrder.sp_UPDATE_RouteFinishCheckUncheck("CHECK", RouteNumber);
                        //finished
                        //MessageBox.Show("The Route " + RouteNumber + " has been Finished.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                }
                else // uncheck 했을 때
                {
                    if (connSalesOrder.sp_UPDATE_RouteFinishCheckUncheck_UserCheck() == "1")
                    {
                        grid_RouteHeader.Rows[e.RowIndex].Cells["CheckBox"].Value = false;
                        connSalesOrder.sp_UPDATE_RouteFinishCheckUncheck("UNCHECK", RouteNumber);
                    }
                    else
                    {
                        MessageBox.Show("Cannot uncheck finish check box."
                                                            , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    //DialogResult dialogResult = MessageBox.Show("Are you sure not finish yet this Route?"
                    //                                    , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //if (dialogResult == DialogResult.Yes)
                    //{
                    //    grid_RouteHeader.Rows[e.RowIndex].Cells["CheckBox"].Value = false;
                    //    connSalesOrder.sp_UPDATE_RouteFinishCheckUncheck("UNCHECK", RouteNumber);
                    //    //not finished
                    //    MessageBox.Show("The Route " + RouteNumber + " has been unchecked finish.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    //else if (dialogResult == DialogResult.No)
                    //{

                    //}
                }

            }

        }

        private void readycellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Ready check box click
            {
                if (Convert.ToBoolean(grid_RouteHeader.Rows[e.RowIndex].Cells["ReadyCheckBox"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                {
                    //DialogResult dialogResult = MessageBox.Show("Are you sure Ready this Route?"
                    //                                    , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //if (dialogResult == DialogResult.Yes)
                    //{
                    grid_RouteHeader.Rows[e.RowIndex].Cells["ReadyCheckBox"].Value = true;
                    connSalesOrder.sp_UPDATE_RouteReadyCheckUncheck("CHECK", RouteNumber);
                    //    //finished
                    //    //MessageBox.Show("The Route " + RouteNumber + " has been Finished.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    //else if (dialogResult == DialogResult.No)
                    //{

                    //}
                }
                else // uncheck 했을 때
                {
                    //DialogResult dialogResult = MessageBox.Show("Are you sure not ready yet this Route?"
                    //                                    , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //if (dialogResult == DialogResult.Yes)
                    //{
                    grid_RouteHeader.Rows[e.RowIndex].Cells["ReadyCheckBox"].Value = false;
                    connSalesOrder.sp_UPDATE_RouteReadyCheckUncheck("UNCHECK", RouteNumber);
                    //    //not finished
                    //    //MessageBox.Show("The Route " + RouteNumber + " has been unchecked finish.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    //else if (dialogResult == DialogResult.No)
                    //{

                    //}
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e) // refresh button
        {
            refresh_header();
        }

        private void refresh_totalAmountByRouteDate(string Type)
        {
            Decimal TotalAmountByRouteDate = 0;
            TotalAmountByRouteDate = connSalesOrder.sp_GET_Route_TotalAmountByDate(Type, dateTimePicker_routingDate.Value.Date);
            txt_TotalAmount.Text = TotalAmountByRouteDate.ToString("N2");
        }

        private void refresh_header() // header grid refresh
        {
            btn_createPickingList.Enabled = false;
            String SearchInactive = "";
            if (cbox_vendor.Checked)
            {
                connSalesOrder.sp_GET_Route_HEADERS_VENDOR(grid_RouteHeader, dateTimePicker_routingDate);
                refresh_totalAmountByRouteDate("VENDOR");
            }
            else
            {
                connSalesOrder.sp_GET_Route_HEADERS(grid_RouteHeader, dateTimePicker_routingDate);
                refresh_totalAmountByRouteDate("");
            }

            

            foreach (DataGridViewRow item in grid_RouteHeader.Rows)
            {
                if (item.Cells["Finish"].Value.ToString().Trim() == "Y")
                {
                    item.Cells["CheckBox"].Value = true;
                }

                if (item.Cells["Ready"].Value.ToString().Trim() == "Y")
                {
                    item.Cells["ReadyCheckBox"].Value = true;
                }

                if (item.Cells["RouteStatus"].Value.ToString().Trim() == "Finish")
                {
                    item.DefaultCellStyle.BackColor = Color.Pink;
                    item.DefaultCellStyle.SelectionBackColor = Color.PaleVioletRed;
                    //item.DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else
                {
                    item.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                    //item.DefaultCellStyle.SelectionForeColor = Color.Black;
                }

            }


            //for (int i = 0; i < grid_RouteHeader.RowCount; i++)
            //{
            //    if (grid_RouteHeader.Rows[i].Cells["RouteStatus"].Value.ToString().Trim() == "Finish")
            //    {
            //        MessageBox.Show("TEST");
            //    }
            //}

            grid_RouteDetail.DataSource = null;
            grid_RouteHeader.ClearSelection();
        }

        private string selectedRouteNumber = "";

        private void grid_RTTMPH_CellClick(object sender, DataGridViewCellEventArgs e) // header grid에서 row선택 했을 때
        {
            cbo_SearchCode.SelectedItem = "";
            try
            {
                RouteDriver = grid_RouteHeader.Rows[e.RowIndex].Cells["Driver"].Value.ToString().Trim();
                RouteTruck = grid_RouteHeader.Rows[e.RowIndex].Cells["Truck"].Value.ToString().Trim();
                RouteNumber = Convert.ToInt32(grid_RouteHeader.Rows[e.RowIndex].Cells["RTN"].Value); //초기화 한 RouteNumber 정의
                if (Convert.ToBoolean(grid_RouteHeader.Rows[e.RowIndex].Cells["CheckBox"].EditedFormattedValue) == false)
                {
                    RouteFinish = "N";
                    //btn_selectOrders.Enabled = true;
                    btn_deleteRouteOrders.Enabled = true;
                    btn_DeleteAll.Enabled = true;
                    btn_Sort.Enabled = true;
                    cbo_SearchCode.Enabled = true;
                }
                else
                {
                    RouteFinish = "Y";
                    //btn_selectOrders.Enabled = false;
                    btn_deleteRouteOrders.Enabled = false;
                    btn_DeleteAll.Enabled = true;
                    btn_Sort.Enabled = true;
                    cbo_SearchCode.Enabled = true;
                }

                string RouteNumberString = grid_RouteHeader.Rows[e.RowIndex].Cells["RTN"].Value.ToString(); //RouteNumber String 형
                selectedRouteNumber = RouteNumberString;


                i = 0;
                SelectedOrderID = ""; //RouteNumber에서 order를 지우기위한 OrderID 초기화

                connSalesOrder.grid_RouteDetail(grid_RouteDetail, RouteNumberString); // Fill detail gird
                grid_RouteDetail.ClearSelection(); // detail gird clear selection
                //refresh_header();                                                 
                for (int i = 0; i < grid_RouteHeader.RowCount; i++)
                {
                    if (grid_RouteHeader.Rows[i].Cells["RTN"].Value.ToString().Trim() == RouteNumber.ToString())
                    {
                        grid_RouteHeader.Rows[i].Cells["CRS"].Value = grid_RouteDetail.Rows.Count.ToString();
                        break;
                    }
                }
                getTotalAmount(); // get total amount and 
                                  //disableSelectOrdersButton();
                btn_createPickingList.Enabled = true;

                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(PreparationOrders))
                    {
                        var mainForm = Application.OpenForms.OfType<PreparationOrders>().FirstOrDefault();
                        mainForm.txt_driver.Text = RouteDriver;
                        mainForm.txt_truck.Text = RouteTruck;
                        mainForm.txt_RouteNumber.Text = RouteNumber.ToString();
                    }
                }
            }
            catch
            {

            }

        }

        private void getTotalAmount() // get total amount and display
        {
            Decimal Amount = 0;
            for (int i = 0; i < grid_RouteDetail.Rows.Count; i++)
            {
                Amount += Convert.ToDecimal(grid_RouteDetail.Rows[i].Cells["Ord. Amount"].Value);
            }
            txt_amount.Text = Amount.ToString("N2"); // ToString C : $ Currency
        }


        //********************************************Drag and drop 순서 바꾸기 START************************************//
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        private void grid_RTTMPD_MouseMove(object sender, MouseEventArgs e)
        {
            String Finish = connSalesOrder.getRouteFinish(RouteNumber);
            if (Finish == "Y")
            {
                return;
            }

            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = grid_RouteDetail.DoDragDrop(
                    grid_RouteDetail.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void grid_RTTMPD_MouseDown(object sender, MouseEventArgs e)
        {
            String Finish = connSalesOrder.getRouteFinish(RouteNumber);
            if (Finish == "Y")
            {
                return;
            }

            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = grid_RouteDetail.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;

        }

        private void grid_RTTMPD_DragOver(object sender, DragEventArgs e)
        {
            String Finish = connSalesOrder.getRouteFinish(RouteNumber);
            if (Finish == "Y")
            {
                return;
            }
            e.Effect = DragDropEffects.Move;
        }


        private void grid_RTTMPD_DragDrop(object sender, DragEventArgs e)
        {
            String Finish = connSalesOrder.getRouteFinish(RouteNumber);
            if (Finish == "Y")
            {
                return;
            }
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = grid_RouteDetail.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                grid_RouteDetail.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                DataTable dt = this.grid_RouteDetail.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr.ItemArray = dt.Rows[rowIndexFromMouseDown].ItemArray.Clone() as object[];
                dt.Rows.RemoveAt(rowIndexFromMouseDown);
                dt.Rows.InsertAt(dr, rowIndexOfItemUnderMouseToDrop);
            }

            i++;

            for (int i = 0; i < grid_RouteDetail.RowCount; i++)
            {
                int j = i + 1;
                grid_RouteDetail.Rows[i].Cells["STOP"].Value = "S" + j.ToString("D2");
            }
            //순서바꾸면 S01 부터 순서를 다시 정렬, 
            //save는 하지 않음
            saveRoute();
        }
        //********************************************Drag and drop 순서 바꾸기 END************************************//

        private void grid_RTTMPD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_RTTMPD_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) // No. 번호매기기
        {
            //this.grid_RouteDetail.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString("D2");
        }

        private void btn_saveRouteOrders_Click(object sender, EventArgs e)
        {
            ////cuid update ( sp_CRUD_RouteDetail 사용해서  action을 "update"로 update)
            //for (int i = 0; i < grid_RouteDetail.RowCount; i++)
            //{
            //    String RouteStop = grid_RouteDetail.Rows[i].Cells["Stop"].Value.ToString().Trim();
            //    String OrderID = grid_RouteDetail.Rows[i].Cells["Order No."].Value.ToString().Trim();
            //    String BPCNUM = grid_RouteDetail.Rows[i].Cells["Customer"].Value.ToString().Trim();

            //    connSalesOrder.sp_CRUD_RouteDetail("UPDATE", RouteNumber, RouteStop, OrderID);
            //}

            ////Save finished
            //MessageBox.Show("The Route " + RouteNumber + " has been Saved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ////header grid refresh only
            ////connSalesOrder.grid_RouteHeader(grid_RouteHeader, dateTimePicker_routingDate);
            //EnableSelectOrdersButton();
        }

        private void saveRoute()
        {
            //cuid update ( sp_CRUD_RouteDetail 사용해서  action을 "update"로 update)
            for (int i = 0; i < grid_RouteDetail.RowCount; i++)
            {
                String RouteStop = grid_RouteDetail.Rows[i].Cells["Stop"].Value.ToString().Trim();
                String OrderID = grid_RouteDetail.Rows[i].Cells["Order No."].Value.ToString().Trim();
                String BPCNUM = grid_RouteDetail.Rows[i].Cells["Customer"].Value.ToString().Trim();

                connSalesOrder.sp_CRUD_RouteDetail("UPDATE", RouteNumber, RouteStop, OrderID);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            //btn_new.Enabled = false;
            //btn_save.Enabled = false;
            //btn_create.Enabled = true;
            //btn_cancel.Enabled = true;

            //btn_selectOrders.Enabled = false;
            //btn_saveRouteOrders.Enabled = false;
            //btn_deleteRouteOrders.Enabled = false; //-----> DELETE ROUTE ORDERS 
            //btn_createPrepPlan.Enabled = false; //-----> CREATE PREP PLAN
            //btn_updateStopNo.Enabled = false; //-----> UPDATE STOP NO (MDL)
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (cbo_drivers.Text == "" || cbo_trucks.Text == "") // driver와 truck 선택 하지 않았을 때
            {
                MessageBox.Show("Select Driver and Truck.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            String TruckID = connSalesOrder.getDriverID(cbo_drivers.Text);
            String DriverID = connSalesOrder.getTruckID(cbo_trucks.Text);
            DateTime RouteDate = dateTimePicker_routingDate.Value;

            connSalesOrder.sp_RouteHeader_INSERT(TruckID, DriverID, RouteDate); //새로운 RouteNumber 생성

            refresh_header();//header grid refresh
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //btn_new.Enabled = true;
            //btn_create.Enabled = false;
            //btn_cancel.Enabled = false;
        }

        private void btn_selectOrders_Click(object sender, EventArgs e)
        {
            if (RouteNumber == 0)
            {
                MessageBox.Show("Select route first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PreparationOrders))
                {
                    form.Activate();
                    //form.WindowState = FormWindowState.Normal;
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    return;
                }
            }

            //Screen[] screens = Screen.AllScreens;
            PreparationOrders preparationOrders = new PreparationOrders(RouteNumber, RouteDriver, RouteTruck);
            preparationOrders.StartPosition = FormStartPosition.Manual;
            try
            {
                Screen screen = Screen.FromControl(this);
                if (screen.Bounds == Screen.AllScreens[0].Bounds)
                {
                    preparationOrders.Bounds = Screen.AllScreens[1].Bounds;
                }
                else
                {
                    preparationOrders.Bounds = Screen.AllScreens[0].Bounds;
                }
            }
            catch
            {

            }
            preparationOrders.Show();
        }

        private void setFormLocation(Form form, Screen screen)
        {
            // first method
            Rectangle bounds = screen.Bounds;
            form.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);

            // second method
            //Point location = screen.Bounds.Location;
            //Size size = screen.Bounds.Size;

            //form.Left = location.X;
            //form.Top = location.Y;
            //form.Width = size.Width;
            //form.Height = size.Height;
        }

        private void btn_deleteRouteOrders_Click(object sender, EventArgs e)
        {
            String RouteStatus = connSalesOrder.sp_GET_RouteStatus(RouteNumber);
            if (RouteStatus == "Finish")
            {
                MessageBox.Show("Can not delete this route from route number. This Route Number already has been made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (SelectedOrderID != "") //detail grid에서 order를 선택했을 때
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure delete this order, " + SelectedOrderID + " from this Route?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    connSalesOrder.sp_CRUD_RouteDetail("DELETE", 0, "", SelectedOrderID); // delete order from route

                    //Delete finished
                    //MessageBox.Show("The Order Number " + SelectedOrderID + " has been Deleted from this Route Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connSalesOrder.grid_RouteDetail(grid_RouteDetail, RouteNumber.ToString()); // detail grid refresh

                    //S01 부터 순서대로 정렬
                    for (int i = 0; i < grid_RouteDetail.RowCount; i++)
                    {
                        int j = i + 1;
                        grid_RouteDetail.Rows[i].Cells["STOP"].Value = "S" + j.ToString("D2");
                    }

                    getTotalAmount();

                    //저장하기
                    for (int i = 0; i < grid_RouteDetail.RowCount; i++)
                    {
                        String RouteStop = grid_RouteDetail.Rows[i].Cells["Stop"].Value.ToString().Trim();
                        String OrderID = grid_RouteDetail.Rows[i].Cells["Order No."].Value.ToString().Trim();
                        String BPCNUM = grid_RouteDetail.Rows[i].Cells["Customer"].Value.ToString().Trim();

                        connSalesOrder.sp_CRUD_RouteDetail("UPDATE", RouteNumber, RouteStop, OrderID);
                    }

                    for (int i = 0; i < grid_RouteHeader.RowCount; i++)
                    {
                        string routeNumber = grid_RouteHeader.Rows[i].Cells["RTN"].Value.ToString().Trim();
                        if (routeNumber == selectedRouteNumber)
                        {
                            grid_RouteHeader.Rows[i].Cells["CRS"].Value = (Convert.ToInt32(grid_RouteHeader.Rows[i].Cells["CRS"].Value.ToString().Trim()) - 1).ToString();
                            break;
                        }
                    }
                    try
                    {
                        var mainForm = Application.OpenForms.OfType<PreparationOrders>().FirstOrDefault();
                        mainForm.Refresh_PreparationOrder();
                    }
                    catch
                    { }
                    
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            else //아직 detail grid에서 order를 클릭해서 선택하지 않았을 때
            {
                MessageBox.Show("Select the order number to delete the order from the route number.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void grid_RouteDetail_CellClick(object sender, DataGridViewCellEventArgs e) // detail grid의 row를 선택해서 지우기 위한 준비
        {
            try
            {
                cbo_SearchCode.SelectedItem = "";
                if (!(routeMap is null))
                {
                    routeMap.FocusTheMap(grid_RouteDetail, e.RowIndex);
                }
                SelectedOrderID = grid_RouteDetail.Rows[e.RowIndex].Cells["Order No."].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void grid_RouteDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String orderID = grid_RouteDetail.Rows[e.RowIndex].Cells["Order No."].Value.ToString().Trim();
                if (connSalesOrder.getOrderStatusFromOrderID(orderID) != "PickingList")
                {
                    MessageBox.Show("This order number has not yet issued a picking ticket.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    String OrderID = grid_RouteDetail.Rows[e.RowIndex].Cells["Order No."].Value.ToString().Trim();
                    Rpt_PickingList rpt_PickingList = new Rpt_PickingList(OrderID);
                    rpt_PickingList.Show();
                }
            }
            catch
            {

            }

        }

        private void btn_createPickingList_Click(object sender, EventArgs e)
        {
            if (connSalesOrder.sp_CreatePickinList_UserCheck() == "0")
            {
                MessageBox.Show("You do not have permissions to access.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            
            String Finish = connSalesOrder.getRouteFinish(RouteNumber);
            if (Finish == "N")
            {
                MessageBox.Show("You have not completed routing yet."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            String RouteStatus = connSalesOrder.sp_GET_RouteStatus(RouteNumber);
            if (RouteStatus == "Finish")
            {
                MessageBox.Show("Cannot create picking lists.\nThe picking list already has been made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Please confirm create a picking list."
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //if routeStatus is finish : return
                //String RouteStatus = connSalesOrder.sp_GET_RouteStatus(RouteNumber);
                //if (RouteStatus == "Finish")
                //{
                //    MessageBox.Show("This Route Number already has been made.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //    return;
                //}

                connSalesOrder.sp_UPDATE_RouteStatus(RouteNumber); // 07/08/20 mark finish route status first when picking list creating.

                for (int i = 0; i < grid_RouteDetail.Rows.Count; i++)
                {
                    String orderID = grid_RouteDetail.Rows[i].Cells["Order No."].Value.ToString().Trim();
                    if (connSalesOrder.getOrderStatusFromOrderID(orderID) == "PickingList")
                    {
                        MessageBox.Show("This Order Number " + orderID + " already has been made.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //return;
                    }

                    connSalesOrder.sp_CREATE_PickingNumber(orderID); // delete order from route
                    connSalesOrder.sp_CREATE_Pick(orderID);
                    connSalesOrder.sp_CREATE_PickDetail(orderID); 
                    // Copy SPickDetailTemp -> SPickDetail 
                    // Stock pick allocation table
                    // Stock 테이블에서 pick detail : CUMWIPQTA_0
                    
                }
                MessageBox.Show("Picking lists have been successfully created.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //refresh_header();                                                 
                for (int i = 0; i < grid_RouteHeader.RowCount; i++)
                {
                    if (grid_RouteHeader.Rows[i].Cells["RTN"].Value.ToString().Trim() == RouteNumber.ToString())
                    {
                        grid_RouteHeader.Rows[i].Cells["CRS"].Value = grid_RouteDetail.Rows.Count.ToString();
                        grid_RouteHeader.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                        grid_RouteHeader.Rows[i].DefaultCellStyle.SelectionBackColor = Color.PaleVioletRed;
                        break;
                    }
                }

            }
            else if (dialogResult == DialogResult.No)
            {

            }

            //개별 orderid로 picking list만들기
            //if (SelectedOrderID != "") //detail grid에서 order를 선택했을 때
            //{
            //    DialogResult dialogResult = MessageBox.Show("Are you sure create picking list (" + SelectedOrderID + ")?"
            //                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if(connSalesOrder.getOrderStatusFromOrderID(SelectedOrderID) == "PickingList")
            //    {
            //        MessageBox.Show("This Order Number already has been made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        return;
            //    }

            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        connSalesOrder.sp_CREATE_PickingNumber(SelectedOrderID); // delete order from route
            //        MessageBox.Show("The Order Number " + SelectedOrderID + " has been made picking list Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
            //    else if (dialogResult == DialogResult.No)
            //    {

            //    }

            //}
            //else //아직 detail grid에서 order를 클릭해서 선택하지 않았을 때
            //{
            //    MessageBox.Show("Select Order Number for delete Route.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}

            //=============================================
            //TODO:picking, picking detail 테이블에 저장하기
            //=============================================

        }

        private void grid_RouteHeader_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    String Finish = connSalesOrder.getRouteFinish(Convert.ToInt32(grid_RouteHeader.Rows[e.RowIndex].Cells["RTN"].Value.ToString().Trim()));
                    if (Finish == "Y")
                    {
                        MessageBox.Show("This route has already been finished."
                                                                , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
                        int RouteNumber = Convert.ToInt32(grid_RouteHeader.Rows[e.RowIndex].Cells["RTN"].Value.ToString().Trim());
                        String driver = grid_RouteHeader.Rows[e.RowIndex].Cells["Driver"].Value.ToString().Trim();
                        String truck = grid_RouteHeader.Rows[e.RowIndex].Cells["Truck"].Value.ToString().Trim();
                        EditRouteInfo editRouteInfo = new EditRouteInfo(RouteNumber, driver, truck);
                        editRouteInfo.ShowDialog();

                        refresh_header();
                    }
                }
            }
            catch
            {

            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

        private void btn_deliveryList_Click(object sender, EventArgs e)
        {
            try
            {
                RouteAmount = connSalesOrder.sp_GET_Route_Amount(RouteNumber);

                String RouteStatus = connSalesOrder.sp_GET_RouteStatus(RouteNumber);
                if (RouteStatus != "Finish")
                {
                    MessageBox.Show("This Route Number has never been made", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void btn_bulkNutLabelList_Click(object sender, EventArgs e)
        {
            try
            {
                String RouteStatus = connSalesOrder.sp_GET_RouteStatus(RouteNumber);
                
                if (RouteStatus != "Finish")
                {
                    MessageBox.Show("This Route Number has never been made", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                bool BulkNutLabelList = connSalesOrder.sp_CHECK_BulkNutLabelList(RouteNumber);
                if (BulkNutLabelList == false)
                {
                    MessageBox.Show("This Route Number doesn't have any bulk nut items.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Rpt_BulkNutLabelList rpt_BulkNutLabelList = new Rpt_BulkNutLabelList(RouteNumber);
                rpt_BulkNutLabelList.Show();
            }
            catch
            {

            }
        }

        private void grid_RouteDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!(routeMap is null))
                {
                    routeMap.FocusTheMap(grid_RouteDetail, e.RowIndex);
                }
                SelectedOrderID = grid_RouteDetail.Rows[e.RowIndex].Cells["Order No."].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void grid_RouteDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //{
            //    try
            //    {
                    
            //        if (connSalesOrder.getOrderStatusFromOrderID(SelectedOrderID) != "PickingList")
            //        {
            //            MessageBox.Show("This order number has not yet issued a picking ticket.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //            return;
            //        }
            //        else
            //        {
                        
            //            Rpt_PickingList rpt_PickingList = new Rpt_PickingList(SelectedOrderID);
            //            rpt_PickingList.Show();
            //        }
            //    }
            //    catch
            //    {

            //    }
            //}
        }

        private void grid_RouteDetail_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void grid_RouteDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    if (connSalesOrder.getOrderStatusFromOrderID(SelectedOrderID) != "PickingList")
                    {
                        MessageBox.Show("This order number has not yet issued a picking ticket.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {

                        Rpt_PickingList rpt_PickingList = new Rpt_PickingList(SelectedOrderID);
                        rpt_PickingList.Show();
                    }
                }
                catch
                {

                }
            }
        }

        public void MarkTheMap(DataGridView gridView)
        {
            String ErrorCustomer = "";
            try
            {
                gMapControl1.Overlays.Clear();

                gMapControl1.DragButton = MouseButtons.Left;
                gMapControl1.CanDragMap = true;

                gMapControl1.MinZoom = 0;
                gMapControl1.MaxZoom = 24;
                gMapControl1.AutoScroll = true;

                for (int i = 0; i < gridView.RowCount; i++)
                {
                    //string No = grid_ORDERS.Rows[i].Cells["No"].Value.ToString();
                    string CustomerID = gridView.Rows[i].Cells["Customer"].Value.ToString();
                    string ZIP = gridView.Rows[i].Cells["ZIP"].Value.ToString();
                    string Address = gridView.Rows[i].Cells["Address"].Value.ToString();
                    string State = gridView.Rows[i].Cells["State"].Value.ToString();
                    string City = gridView.Rows[i].Cells["City"].Value.ToString();
                    string Rep = gridView.Rows[i].Cells["Rep."].Value.ToString();
                    DateTime OrderDate = gridView.Rows[i].Cells["Order Date"].Value == DBNull.Value ? Convert.ToDateTime("1900-01-01") : Convert.ToDateTime(gridView.Rows[i].Cells["Order Date"].Value);
                    string OrderNumber = gridView.Rows[i].Cells["Order No."].Value.ToString();
                    string Amount = gridView.Rows[i].Cells["Ord. Amount"].Value.ToString();
                    string Latitude = gridView.Rows[i].Cells["Latitude"].Value.ToString().Length == 0 ? "" : gridView.Rows[i].Cells["Latitude"].Value.ToString();
                    string Longitude = gridView.Rows[i].Cells["Longitude"].Value.ToString().Length == 0 ? "" : gridView.Rows[i].Cells["Longitude"].Value.ToString();
                    //bool Checks = Convert.ToBoolean(grid_RouteDetail.Rows[i].Cells["CheckBox"].Value);
                    if (Latitude.Equals(""))
                    { ErrorCustomer += CustomerID + ", "; }
                    else
                    {
                        markerOverlay = new GMapOverlay("Marker");
                        gMapControl1.Overlays.Add(markerOverlay);
                        marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.red);
                        markerOverlay.Markers.Add(marker);
                        GMapToolTip tooltip = new GMapToolTip(marker);
                        marker.ToolTipMode = MarkerTooltipMode.Always;
                        tooltip.Font = new Font("Arial", 12, FontStyle.Bold);
                        marker.ToolTip = tooltip;
                        marker.ToolTipText = Address;//Address;//string.Format("CustomerID : {0}", CustomerID);
                        //marker.ToolTipText = string.Format("SalesRep : {0}\nCompany : {1} \nAddress : {2}\nMemo : {3} \nTel : {4}   " +
                        //    "Web : {5}\nLast Invoice Date : {6}     InActive : {7}",
                        //    SalesRep, CustomerID, Result, Memo, TEL, WEB, LastInvoiceDate.ToString("MM/dd/yyyy"), CustomerState);
                        marker.ToolTip.Stroke = new Pen(Color.Magenta, 2);
                        marker.ToolTip.TextPadding = new Size(5, 5);
                    }
                }
                gMapControl1.Refresh();
                gMapControl1.ReloadMap();


                if (!ErrorCustomer.Equals("")) MessageBox.Show("Done!\nError : " + ErrorCustomer.ToString() + "\nReason : Address Maping Error", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void FocusTheMap(DataGridView gridRouteDetail, int RowNumber)
        {
            try
            {
                string Latitude = grid_RouteDetail.Rows[RowNumber].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_RouteDetail.Rows[RowNumber].Cells["Latitude"].Value.ToString();
                string Longitude = grid_RouteDetail.Rows[RowNumber].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_RouteDetail.Rows[RowNumber].Cells["Longitude"].Value.ToString();
                gMapControl1.Position = new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude));
            }
            catch
            {
                return;
            }
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            String Finish = connSalesOrder.getRouteFinish(RouteNumber);
            if (Finish == "Y")
            {
                MessageBox.Show("The Route Number cannot be reordered, Course preparation has already been marked as finished."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cbo_SearchCode.Text = "";
                return;
            }

            String RouteStatus = connSalesOrder.sp_GET_RouteStatus(RouteNumber);
            if (RouteStatus == "Finish")
            {
                MessageBox.Show("The picking list already has been made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cbo_SearchCode.Text = "";
                return;
            }

            try
            {
                if (RouteNumber == 0)
                {
                    MessageBox.Show("Select route first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (grid_RouteDetail.RowCount < 2)
                {
                    MessageBox.Show("Add orders first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (cbo_SearchCode.Text.Length == 0)
                {
                    MessageBox.Show("Select code first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //String RouteCode = cbo_SearchCode.Text.ToString(); 11/23/2020
                String RouteInput = cbo_SearchCode.Text.ToString();
                String[] result = RouteInput.Split('(');
                String RouteCode = result[0].Trim().ToString();
                
                connSalesOrder.sp_RoutePlanDetail(grid_RouteDeliveryPlan, RouteCode);

                DialogResult dialogResult = MessageBox.Show("Are you sure sort orders with '" + cbo_SearchCode.Text.ToString() + "' delivery route plan?"
                                                               , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //Code로 customer 순서 가져오고, list와 비교해서 순서 S+i하나씩 올리면서 update
                    int index = 1;
                    for (int i = 0; i < grid_RouteDeliveryPlan.RowCount; i++)
                    {
                        String CustomerID = grid_RouteDeliveryPlan.Rows[i].Cells["CustomerID"].Value.ToString();
                        for (int j = 0; j < grid_RouteDetail.RowCount; j++)
                        {
                            String VCustomerID = grid_RouteDetail.Rows[j].Cells["Customer"].Value.ToString();
                            if (CustomerID.Equals(VCustomerID))
                            {
                                String OrderID = grid_RouteDetail.Rows[j].Cells["Order No."].Value.ToString();
                                connSalesOrder.sp_CRUD_RouteDetail("SORT", RouteNumber, "S" + index.ToString("D2"), OrderID);
                                grid_RouteDetail.Rows[j].Cells["CheckBox"].Value = true;
                                index++;
                            }
                        }
                    }
                    for (int i = 0; i < grid_RouteDetail.RowCount; i++)
                    {
                        if (Convert.ToBoolean(grid_RouteDetail.Rows[i].Cells["CheckBox"].Value) == false)
                        {
                            String OrderID = grid_RouteDetail.Rows[i].Cells["Order No."].Value.ToString();
                            connSalesOrder.sp_CRUD_RouteDetail("SORT", RouteNumber, "S" + index.ToString("D2"), OrderID);
                            grid_RouteDetail.Rows[i].Cells["CheckBox"].Value = true;
                            index++;
                        }
                    }
                    connSalesOrder.grid_RouteDetail(grid_RouteDetail, RouteNumber.ToString());

                    grid_RouteDeliveryPlan.DataSource = null;
                    MessageBox.Show("Done", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
                {
                    cbo_SearchCode.SelectedItem = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void PreparationPlan_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("Close");
            if (!(routeMap is null)) routeMap.Close();
            if (!(Application.OpenForms.OfType<PreparationOrders>().FirstOrDefault() is null))
                Application.OpenForms.OfType<PreparationOrders>().FirstOrDefault().Close();
        }
        

        //async Task Download() //(DropboxClient dbx, string folder, string file)
        //{
        //    var dbx = new DropboxClient("AiwJ3q3u-HwAAAAAAAAAAW4J2OakmqLDTht7QhoOKxAonCG5ct-sW4e5CmmIp7n_");
        //    string folder = "Database";
        //    string file = "test1.txt";
        //    string localFilePath = @"C:\Users\user\Downloads\";

        //    using (var response = await dbx.Files.DownloadAsync("/"+folder + "/" + file))
        //    {
        //        using (var fileStream = File.Create(localFilePath))
        //        {
        //            (await response.GetContentAsStreamAsync()).CopyTo(fileStream);
        //        }
                
        //        //Console.WriteLine(await response.GetContentAsStringAsync());
        //    }
            
        //}

        public void Refresh_RouteDetail(String RouteNumber)
        {
            
            connSalesOrder.grid_RouteDetail(grid_RouteDetail, RouteNumber); // Fill detail gird
            //refresh_header();
            for (int i = 0; i < grid_RouteHeader.RowCount; i++)
            {
                if (grid_RouteHeader.Rows[i].Cells["RTN"].Value.ToString().Trim() == RouteNumber.ToString())
                {
                    grid_RouteHeader.Rows[i].Cells["CRS"].Value = grid_RouteDetail.Rows.Count.ToString();
                    break;
                }
            }
            getTotalAmount();
        }

        public void setStopSave()
        {
            for (int i = 0; i < grid_RouteDetail.RowCount; i++)
            {
                int j = i + 1;
                grid_RouteDetail.Rows[i].Cells["STOP"].Value = "S" + j.ToString("D2");
            }

            for (int i = 0; i < grid_RouteDetail.RowCount; i++)
            {
                String RouteStop = grid_RouteDetail.Rows[i].Cells["Stop"].Value.ToString().Trim();
                String OrderID = grid_RouteDetail.Rows[i].Cells["Order No."].Value.ToString().Trim();

                connSalesOrder.sp_CRUD_RouteDetail("UPDATE", RouteNumber, RouteStop, OrderID);
            }
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                String RouteStatus = connSalesOrder.sp_GET_RouteStatus(RouteNumber);
                if (RouteStatus == "Finish")
                {
                    MessageBox.Show("Can not delete this route from route number. This Route Number already has been made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (SelectedOrderID != "" && (grid_RouteDetail.RowCount != 0)) //detail grid에서 order를 선택했을 때
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure delete all orders from this Route?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < grid_RouteDetail.RowCount; i++)
                        {
                            String SelectedOrderID = grid_RouteDetail.Rows[i].Cells["Order No."].Value.ToString();
                            connSalesOrder.sp_CRUD_RouteDetail("DELETE", 0, "", SelectedOrderID); // delete order from route
                        }

                        
                        connSalesOrder.grid_RouteDetail(grid_RouteDetail, RouteNumber.ToString()); // detail grid refresh
                        //refresh_header();
                        for (int i = 0; i < grid_RouteHeader.RowCount; i++)
                        {
                            if (grid_RouteHeader.Rows[i].Cells["RTN"].Value.ToString().Trim() == RouteNumber.ToString())
                            {
                                grid_RouteHeader.Rows[i].Cells["CRS"].Value = grid_RouteDetail.Rows.Count.ToString();
                                break;
                            }
                        }

                        getTotalAmount();
                        try
                        {
                            var mainForm = Application.OpenForms.OfType<PreparationOrders>().FirstOrDefault();
                            mainForm.Refresh_PreparationOrder();
                        }
                        catch { }
                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
                else //아직 detail grid에서 order를 클릭해서 선택하지 않았을 때
                {
                    MessageBox.Show("Select the order number to delete the order from the route number.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                //MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btn_RouteMap_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(RouteMap))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            RouteMap frm = new RouteMap(this as IMyInterface);
            //frm.StartPosition = FormStartPosition.Manual;
            //Screen screen = Screen.FromControl(this);
            //if (screen.Bounds == Screen.AllScreens[0].Bounds)
            //{
            //    frm.Bounds = Screen.AllScreens[1].Bounds;
            //}
            //else
            //{
            //    frm.Bounds = Screen.AllScreens[0].Bounds;
            //}
            frm.Show();
            routeMap = frm;
            routeMap.MarkTheMap(grid_RouteDetail);
            //routeMap.dataGridView = grid_RouteDetail;
            
        }

        private void grid_RouteDetail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (!(routeMap is null))
            {
                routeMap.MarkTheMap(grid_RouteDetail);
            }
        }
        
        private void PreparationPlan_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var mainForm = Application.OpenForms.OfType<PreparationOrders>().FirstOrDefault();
                mainForm.Close();
                //this.Close();
            }catch
            {

            }

            try
            {
                var mainForm = Application.OpenForms.OfType<RouteMap>().FirstOrDefault();
                mainForm.Close();
            }
            catch
            {

            }
        } 
    }
}
