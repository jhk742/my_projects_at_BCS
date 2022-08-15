using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// maps 11/6/2020
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace OBCS.Sales
{
    public partial class PreparationOrders : Form
    {
        // maps 11/6/2020
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        int selection = 0;
        double BCSlatitude = 40.742164;
        double BCSlongitude = -73.931789;
        int Zoom = 11;

        public PreparationOrders(int RouteNumber, String Driver, String Truck)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            grid_ORDERS_Init(); //grid 초기화

            txt_driver.Text = Driver;
            txt_truck.Text = Truck;
            txt_RouteNumber.Text = RouteNumber.ToString();

            //grid multi line allow
            grid_ORDERS.AllowDrop = true;
            grid_ORDERS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_ORDERS.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            
            connSalesOrder.sp_PreparationMap(grid_ORDERS); //루트에 속하지 않은 orderid만 가져와서 grid에 보여주기
            
            Map_InitialSetting();
        }

        private void Map_InitialSetting()
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(BCSlatitude, BCSlongitude);

            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 12;
            gMapControl1.AutoScroll = true;
        }

        private void grid_ORDERS_Init()
        {
            grid_ORDERS.AutoGenerateColumns = false;
            grid_ORDERS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_ORDERS.ColumnCount = 15;

            grid_ORDERS.Columns[0].Name = "No.";
            grid_ORDERS.Columns[0].ReadOnly = true;
            grid_ORDERS.Columns[0].Width = 25;
            grid_ORDERS.Columns[0].Visible = false;
            grid_ORDERS.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_ORDERS.Columns[0].DataPropertyName = "";

            grid_ORDERS.Columns[1].Name = "Order Date";
            grid_ORDERS.Columns[1].Width = 135;
            grid_ORDERS.Columns[1].MinimumWidth = 135;
            grid_ORDERS.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_ORDERS.Columns[1].ReadOnly = true;
            grid_ORDERS.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[1].DataPropertyName = "OrderDate";
            
            grid_ORDERS.Columns[2].Name = "Memo";
            grid_ORDERS.Columns[2].Width = 150;
            grid_ORDERS.Columns[2].MinimumWidth = 150;
            grid_ORDERS.Columns[2].ReadOnly = true;
            grid_ORDERS.Columns[2].DataPropertyName = "OrderMemo";

            grid_ORDERS.Columns[3].Name = "Memo2";
            grid_ORDERS.Columns[3].Width = 150;
            grid_ORDERS.Columns[3].MinimumWidth = 150;
            grid_ORDERS.Columns[3].ReadOnly = true;
            grid_ORDERS.Columns[3].DataPropertyName = "ShipAddress2";

            grid_ORDERS.Columns[4].Name = "Audit Memo";
            grid_ORDERS.Columns[4].Width = 90;
            grid_ORDERS.Columns[4].MinimumWidth = 90;
            grid_ORDERS.Columns[4].ReadOnly = true;
            grid_ORDERS.Columns[4].Visible = false;
            grid_ORDERS.Columns[4].DataPropertyName = "AuditMemo";
            
            grid_ORDERS.Columns[5].Name = "Amount";
            grid_ORDERS.Columns[5].Width = 65;
            grid_ORDERS.Columns[5].MinimumWidth = 65;
            grid_ORDERS.Columns[5].ReadOnly = true;
            grid_ORDERS.Columns[5].DefaultCellStyle.Format = "N2";
            grid_ORDERS.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDERS.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[5].DataPropertyName = "Amount";
            
            grid_ORDERS.Columns[6].Name = "Customer";
            grid_ORDERS.Columns[6].ReadOnly = true;
            grid_ORDERS.Columns[6].Width = 90;
            grid_ORDERS.Columns[6].MinimumWidth = 90;
            grid_ORDERS.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_ORDERS.Columns[6].DataPropertyName = "CustomerID";

            grid_ORDERS.Columns[7].Name = "Address";
            grid_ORDERS.Columns[7].ReadOnly = true;
            grid_ORDERS.Columns[7].Width = 170;
            grid_ORDERS.Columns[7].MinimumWidth = 170;
            grid_ORDERS.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid_ORDERS.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[7].DataPropertyName = "ShipAddress1";

            grid_ORDERS.Columns[8].Name = "City";
            grid_ORDERS.Columns[8].Width = 85;
            grid_ORDERS.Columns[8].MinimumWidth = 85;
            grid_ORDERS.Columns[8].ReadOnly = true;
            grid_ORDERS.Columns[8].DataPropertyName = "ShipCity";

            grid_ORDERS.Columns[9].Name = "ZIP";
            grid_ORDERS.Columns[9].ReadOnly = true;
            grid_ORDERS.Columns[9].Width = 45;
            grid_ORDERS.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_ORDERS.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_ORDERS.Columns[9].DataPropertyName = "ShipZip";

            grid_ORDERS.Columns[10].Name = "State";
            grid_ORDERS.Columns[10].Width = 40;
            grid_ORDERS.Columns[10].ReadOnly = true;
            grid_ORDERS.Columns[10].Visible = false;
            grid_ORDERS.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[10].DataPropertyName = "ShipState";

            grid_ORDERS.Columns[11].Name = "Rep";
            grid_ORDERS.Columns[11].Width = 30;
            grid_ORDERS.Columns[11].ReadOnly = true;
            grid_ORDERS.Columns[11].Visible = false;
            grid_ORDERS.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[11].DataPropertyName = "SaleRep";

            grid_ORDERS.Columns[12].Name = "Order No.";
            grid_ORDERS.Columns[12].Width = 80;
            grid_ORDERS.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_ORDERS.Columns[12].ReadOnly = true;
            grid_ORDERS.Columns[12].MinimumWidth = 80;
            grid_ORDERS.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[12].DataPropertyName = "OrderID";
        
            grid_ORDERS.Columns[13].Name = "Latitude";
            grid_ORDERS.Columns[13].Width = 100;
            grid_ORDERS.Columns[13].Visible = false;
            grid_ORDERS.Columns[13].DataPropertyName = "WEB_3";

            grid_ORDERS.Columns[14].Name = "Longitude";
            grid_ORDERS.Columns[14].Width = 100;
            grid_ORDERS.Columns[14].Visible = false;
            grid_ORDERS.Columns[14].DataPropertyName = "WEB_4";

            //grid font size custom
            grid_ORDERS.RowTemplate.Height = 20;
            grid_ORDERS.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_ORDERS.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            //grid_ORDERS.Columns[4].DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
            //grid_ORDERS.Columns[5].DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
            //grid_ORDERS.Columns[8].DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
            //grid_ORDERS.Columns[9].DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
            grid_ORDERS.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        
        private void grid_ORDERS_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //번호매기기
            this.grid_ORDERS.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString("D2");
        }
        
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
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
        
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (GATE.userID.ToUpper() == "JUNG" || GATE.userID.ToUpper() == "JKIM")
            {
                connSalesOrder.sp_GET_ALLORDERS_NOT_PREPLN_VENDOR(grid_ORDERS, "");

            }
            else
            {
                connSalesOrder.sp_PreparationMap(grid_ORDERS);
            }
        }

        private void MarkTheMap()
        {
            String ErrorCustomer = "";
            try
            {
                gMapControl1.Overlays.Clear();
                gMapControl1.Refresh();

                gMapControl1.DragButton = MouseButtons.Left;
                gMapControl1.CanDragMap = true;

                gMapControl1.MinZoom = 0;
                gMapControl1.MaxZoom = 24;
                gMapControl1.AutoScroll = true;

                for (int i = 0; i < grid_ORDERS.RowCount; i++)
                {
                    //string No = grid_ORDERS.Rows[i].Cells["No"].Value.ToString();
                    string CustomerID = grid_ORDERS.Rows[i].Cells["Customer"].Value.ToString();
                    string ZIP = grid_ORDERS.Rows[i].Cells["ZIP"].Value.ToString();
                    string Address = grid_ORDERS.Rows[i].Cells["Address"].Value.ToString();
                    string State = grid_ORDERS.Rows[i].Cells["State"].Value.ToString();
                    string City = grid_ORDERS.Rows[i].Cells["City"].Value.ToString();
                    string Rep = grid_ORDERS.Rows[i].Cells["Rep"].Value.ToString();
                    DateTime OrderDate = grid_ORDERS.Rows[i].Cells["Order Date"].Value == DBNull.Value ? Convert.ToDateTime("1900-01-01") : Convert.ToDateTime(grid_ORDERS.Rows[i].Cells["Order Date"].Value);
                    string OrderNumber = grid_ORDERS.Rows[i].Cells["Order No."].Value.ToString();
                    string Amount = grid_ORDERS.Rows[i].Cells["Amount"].Value.ToString();
                    string Latitude = grid_ORDERS.Rows[i].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_ORDERS.Rows[i].Cells["Latitude"].Value.ToString();
                    string Longitude = grid_ORDERS.Rows[i].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_ORDERS.Rows[i].Cells["Longitude"].Value.ToString();
                    //bool Checks = Convert.ToBoolean(grid_ORDERS.Rows[i].Cells["CheckBox"].Value);
                    if (Latitude.Equals(""))
                    { ErrorCustomer += CustomerID + ", "; }
                    else
                    {
                        markerOverlay = new GMapOverlay("Marker");
                        gMapControl1.Overlays.Add(markerOverlay);
                        marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.blue);
                        //if (Checks)
                        //{
                        //    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.red);
                        //}
                        //else
                        //{
                        //    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.blue);
                        //}
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
                //BCS_Setting();

                if (!ErrorCustomer.Equals("")) MessageBox.Show("Done!\nError : " + ErrorCustomer.ToString() + "\nReason : Address Maping Error", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Map Error. Ask to IT team.\n\n" + ex.ToString());
            }
        }

        private void grid_ORDERS_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MarkTheMap();
        }

        private void grid_ORDERS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String OrderNumber = grid_ORDERS.Rows[e.RowIndex].Cells["Order No."].Value.ToString().Trim();
            String RouteNumber = connSalesOrder.sp_CHECK_ADDORDERTOROUTEPLAN(OrderNumber);
            if (RouteNumber != "" && RouteNumber != "0")
            {
                MessageBox.Show("The Order ID, " + OrderNumber + " is already planed in another route plan, " + RouteNumber + ". Please try again."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                connSalesOrder.sp_PreparationMap(grid_ORDERS); //루트에 속하지 않은 orderid만 가져와서 grid에 보여주기

                return;
            }
            
            try
            {
                String Route = txt_RouteNumber.Text.Trim().ToString();
                String RouteStatus = connSalesOrder.sp_GET_RouteStatus(Convert.ToInt32(Route));
                if (RouteStatus == "Finish")
                {
                    MessageBox.Show("Can not add this route from route number. This Route Number already has been made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                String OrderID = grid_ORDERS.Rows[e.RowIndex].Cells["Order No."].Value.ToString().Trim();

                connSalesOrder.sp_CRUD_RouteDetail("UPDATE", Convert.ToInt32(Route), "NEW", OrderID);
                connSalesOrder.sp_PreparationMap(grid_ORDERS);

                var mainForm = Application.OpenForms.OfType<PreparationPlan>().FirstOrDefault();
                mainForm.Refresh_RouteDetail(Route);
                mainForm.setStopSave();

                grid_ORDERS.Rows[e.RowIndex].Selected = true;
                grid_ORDERS.FirstDisplayedScrollingRowIndex = grid_ORDERS.SelectedRows[0].Index;
            }
            catch { }
        }

        public void AddOrderByDoubleClick(String GETOrderID)
        {           

            for (int i = 0; i < grid_ORDERS.RowCount; i++)
            {
                String OrderID = grid_ORDERS.Rows[i].Cells["Order No."].Value.ToString();
                if (GETOrderID.Equals(OrderID))
                {
                    connSalesOrder.sp_CRUD_RouteDetail("UPDATE", Convert.ToInt32(txt_RouteNumber.Text), "NEW", OrderID);

                    var mainForm = Application.OpenForms.OfType<PreparationPlan>().FirstOrDefault();
                    mainForm.Refresh_RouteDetail(txt_RouteNumber.Text.ToString());
                }
            }
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            String Address = item.ToolTipText.ToString();
            for (int i = 0; i < grid_ORDERS.RowCount; i++)
            {
                if (grid_ORDERS.Rows[i].Cells["Address"].Value.Equals(Address))
                {
                    grid_ORDERS.Rows[i].Selected = true;
                    grid_ORDERS.FirstDisplayedScrollingRowIndex = i;
                    return;
                }
            }
        }

        private void gMapControl1_OnMarkerDoubleClick(GMapMarker item, MouseEventArgs e)
        {
            String Address = item.ToolTipText.ToString();
            //MessageBox.Show(CustomerID);
            String Route = txt_RouteNumber.Text.Trim().ToString();
            String RouteStatus = connSalesOrder.sp_GET_RouteStatus(Convert.ToInt32(Route));
            if (RouteStatus == "Finish")
            {
                MessageBox.Show("Can not add this route from route number. This Route Number already has been made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            for (int i = 0; i < grid_ORDERS.RowCount; i++)
            {
                if (grid_ORDERS.Rows[i].Cells["Address"].Value.Equals(Address))
                {
                    String OrderID = grid_ORDERS.Rows[i].Cells["Order No."].Value.ToString().Trim();
                    String RouteNumber = connSalesOrder.sp_CHECK_ADDORDERTOROUTEPLAN(OrderID);
                    if (RouteNumber != "" && RouteNumber != "0")
                    {
                        MessageBox.Show("The Order ID, " + OrderID + " is already planed in another route plan, " + RouteNumber + ". Please try again."
                                                                , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        connSalesOrder.sp_PreparationMap(grid_ORDERS); //루트에 속하지 않은 orderid만 가져와서 grid에 보여주기

                        return;
                    }

                    connSalesOrder.sp_CRUD_RouteDetail("UPDATE", Convert.ToInt32(Route), "NEW", OrderID);
                    connSalesOrder.sp_PreparationMap(grid_ORDERS);
                    var mainForm = Application.OpenForms.OfType<PreparationPlan>().FirstOrDefault();
                    mainForm.Refresh_RouteDetail(Route);
                    mainForm.setStopSave();
                    return;
                }
            }
            

        }

        public void Refresh_PreparationOrder()
        {
            connSalesOrder.sp_PreparationMap(grid_ORDERS);
        }

        private void btn_Map_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void btn_hybrid_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleHybridMap;
        }

        private void btn_BcsLogo_Click(object sender, EventArgs e)
        {
            gMapControl1.Position = new PointLatLng(BCSlatitude, BCSlongitude);
        }

        private void btn_DeliveryRoutePlan_Click(object sender, EventArgs e)
        {
            String RouteStatus = connSalesOrder.sp_GET_RouteStatus(Convert.ToInt32(txt_RouteNumber.Text));
            if (RouteStatus == "Finish")
            {
                MessageBox.Show("Can not add this route from route number. This Route Number already has been made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SelectDeliveryRoutePlan))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            SelectDeliveryRoutePlan fm = new SelectDeliveryRoutePlan(Convert.ToInt32(txt_RouteNumber.Text), txt_driver.Text.ToString(), txt_truck.Text.ToString());
            fm.StartPosition = FormStartPosition.Manual;
            try
            {
                Screen screen = Screen.FromControl(this);
                if (screen.Bounds == Screen.AllScreens[0].Bounds)
                {
                    fm.Bounds = Screen.AllScreens[0].Bounds;
                }
                else
                {
                    fm.Bounds = Screen.AllScreens[1].Bounds;
                }
            }
            catch { }
            
            fm.ShowDialog();
            
        }

        private void grid_ORDERS_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string Latitude = grid_ORDERS.Rows[e.RowIndex].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_ORDERS.Rows[e.RowIndex].Cells["Latitude"].Value.ToString();
                string Longitude = grid_ORDERS.Rows[e.RowIndex].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_ORDERS.Rows[e.RowIndex].Cells["Longitude"].Value.ToString();
                string CustomerID = grid_ORDERS.Rows[e.RowIndex].Cells["Customer"].Value.ToString();
                //MessageBox.Show(Latitude+"\n"+Longitude+"\n"+CustomerID);
                gMapControl1.Position = new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude));
            }
            catch { }
        }
        
    }

}
