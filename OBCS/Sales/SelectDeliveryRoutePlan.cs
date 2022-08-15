using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    public partial class SelectDeliveryRoutePlan : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        double BCSlatitude = 40.742164;
        double BCSlongitude = -73.931789;
        int Zoom = 10;

        public SelectDeliveryRoutePlan(int RouteNumber, String Driver, String Truck)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            txt_driver.Text = Driver;
            txt_truck.Text = Truck;
            txt_RouteNumber.Text = RouteNumber.ToString();
            grid_ORDERS_Init();
            grid_RoutePlanDetail_Init();
            for (int i = 0; i < grid_RoutePlanDetail.ColumnCount; i++)
            {
                grid_RoutePlanDetail.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            connSalesOrder.cbo_RouteCode(cbo_SearchCode);
            connSalesOrder.sp_PreparationMap(grid_ORDERS);
            Map_InitialSetting();
            //grid_ORDERS.VirtualMode = true;
        }
        private void Map_InitialSetting()
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(BCSlatitude, BCSlongitude);

            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = Zoom;
            gMapControl1.AutoScroll = true;
        }
        private void grid_ORDERS_Init()
        {
            //grid_ORDERS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            grid_ORDERS.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

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
            grid_ORDERS.Columns[1].ReadOnly = true;
            grid_ORDERS.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_ORDERS.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
            grid_ORDERS.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[1].DataPropertyName = "OrderDate";
            
            DataGridViewCheckBoxColumn pickingCheck = new DataGridViewCheckBoxColumn();
            pickingCheck.HeaderText = "V";
            pickingCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            pickingCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            pickingCheck.FalseValue = false;
            pickingCheck.TrueValue = true;
            pickingCheck.Name = "CheckBox";
            pickingCheck.ReadOnly = true;
            pickingCheck.Visible = false;
            pickingCheck.Width = 30;
            pickingCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_ORDERS.Columns.Insert(2, pickingCheck);
            //grid_ORDERS.CellContentClick += new DataGridViewCellEventHandler(gridcellclick);

            grid_ORDERS.Columns[3].Name = "Memo";
            grid_ORDERS.Columns[3].Width = 200;
            grid_ORDERS.Columns[3].MinimumWidth = 200;
            grid_ORDERS.Columns[3].ReadOnly = true;
            //grid_ORDERS.Columns[3].Visible = false;
            grid_ORDERS.Columns[3].DataPropertyName = "OrderMemo";

            grid_ORDERS.Columns[4].Name = "Memo2";
            grid_ORDERS.Columns[4].Width = 180;
            grid_ORDERS.Columns[4].MinimumWidth = 180;
            grid_ORDERS.Columns[4].ReadOnly = true;
            //grid_ORDERS.Columns[4].Visible = false;
            grid_ORDERS.Columns[4].DataPropertyName = "ShipAddress2";
            
            grid_ORDERS.Columns[5].Name = "Audit Memo";
            grid_ORDERS.Columns[5].Width = 90;
            grid_ORDERS.Columns[5].ReadOnly = true;
            grid_ORDERS.Columns[5].Visible = false;
            grid_ORDERS.Columns[5].DataPropertyName = "AuditMemo";

            grid_ORDERS.Columns[6].Name = "Amount";
            grid_ORDERS.Columns[6].Width = 70;
            grid_ORDERS.Columns[6].MinimumWidth = 70;
            grid_ORDERS.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_ORDERS.Columns[6].ReadOnly = true;
            grid_ORDERS.Columns[6].DefaultCellStyle.Format = "N2";
            grid_ORDERS.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDERS.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[6].DataPropertyName = "Amount";

            grid_ORDERS.Columns[7].Name = "Customer";
            grid_ORDERS.Columns[7].ReadOnly = true;
            grid_ORDERS.Columns[7].Width = 100;
            grid_ORDERS.Columns[7].MinimumWidth = 100;
            grid_ORDERS.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_ORDERS.Columns[7].DataPropertyName = "CustomerID";

            grid_ORDERS.Columns[8].Name = "Address";
            grid_ORDERS.Columns[8].ReadOnly = true;
            grid_ORDERS.Columns[8].Width = 160;
            grid_ORDERS.Columns[8].MinimumWidth = 160;
            grid_ORDERS.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid_ORDERS.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[8].DataPropertyName = "ShipAddress1";

            grid_ORDERS.Columns[9].Name = "City";
            grid_ORDERS.Columns[9].Width = 100;
            grid_ORDERS.Columns[9].MinimumWidth = 100;
            grid_ORDERS.Columns[9].ReadOnly = true;
            grid_ORDERS.Columns[9].DataPropertyName = "ShipCity";

            grid_ORDERS.Columns[10].Name = "ZIP";
            grid_ORDERS.Columns[10].ReadOnly = true;
            grid_ORDERS.Columns[10].Width = 50;
            grid_ORDERS.Columns[10].MinimumWidth = 50;
            grid_ORDERS.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_ORDERS.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_ORDERS.Columns[10].DataPropertyName = "ShipZip";

            grid_ORDERS.Columns[11].Name = "State";
            grid_ORDERS.Columns[11].Width = 40;
            grid_ORDERS.Columns[11].ReadOnly = true;
            grid_ORDERS.Columns[11].Visible = false;
            grid_ORDERS.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[11].DataPropertyName = "ShipState";

            grid_ORDERS.Columns[12].Name = "Rep";
            grid_ORDERS.Columns[12].Width = 30;
            grid_ORDERS.Columns[12].ReadOnly = true;
            grid_ORDERS.Columns[12].Visible = false;
            grid_ORDERS.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[12].DataPropertyName = "SaleRep";

            grid_ORDERS.Columns[13].Name = "Order No.";
            grid_ORDERS.Columns[13].Width = 85;
            grid_ORDERS.Columns[13].MinimumWidth = 85;
            grid_ORDERS.Columns[13].ReadOnly = true;
            grid_ORDERS.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_ORDERS.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ORDERS.Columns[13].DataPropertyName = "OrderID";

            grid_ORDERS.Columns[14].Name = "Latitude";
            grid_ORDERS.Columns[14].Width = 100;
            grid_ORDERS.Columns[14].Visible = false;
            grid_ORDERS.Columns[14].DataPropertyName = "WEB_3";

            grid_ORDERS.Columns[15].Name = "Longitude";
            grid_ORDERS.Columns[15].Width = 100;
            grid_ORDERS.Columns[15].Visible = false;
            grid_ORDERS.Columns[15].DataPropertyName = "WEB_4";

            //grid font size custom
            grid_ORDERS.RowTemplate.Height = 17;
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
        private void grid_RoutePlanDetail_Init()
        {
            //grid_RoutePlanDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            grid_RoutePlanDetail.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            grid_RoutePlanDetail.AutoGenerateColumns = false;
            grid_RoutePlanDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_RoutePlanDetail.ColumnCount = 19;

            grid_RoutePlanDetail.Columns[0].Name = "id";
            grid_RoutePlanDetail.Columns[0].Visible = false;
            grid_RoutePlanDetail.Columns[0].Width = 80;
            grid_RoutePlanDetail.Columns[0].MinimumWidth = 80;
            grid_RoutePlanDetail.Columns[0].DataPropertyName = "id";

            grid_RoutePlanDetail.Columns[1].Name = "No.";
            grid_RoutePlanDetail.Columns[1].ReadOnly = true;
            grid_RoutePlanDetail.Columns[1].Width = 15;
            grid_RoutePlanDetail.Columns[1].MinimumWidth = 15;
            grid_RoutePlanDetail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlanDetail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            grid_RoutePlanDetail.Columns[1].DataPropertyName = "RouteStop";

            grid_RoutePlanDetail.Columns[2].Name = "CustomerID";
            grid_RoutePlanDetail.Columns[2].ReadOnly = true;
            grid_RoutePlanDetail.Columns[2].Width = 35;
            grid_RoutePlanDetail.Columns[2].MinimumWidth = 35;
            grid_RoutePlanDetail.Columns[2].DataPropertyName = "CustomerID";

            grid_RoutePlanDetail.Columns[3].Name = "CustomerName";
            grid_RoutePlanDetail.Columns[3].ReadOnly = true;
            grid_RoutePlanDetail.Columns[3].Visible = false;
            grid_RoutePlanDetail.Columns[3].Width = 300;
            grid_RoutePlanDetail.Columns[3].MinimumWidth = 300;
            grid_RoutePlanDetail.Columns[3].DataPropertyName = "CustomerName";

            grid_RoutePlanDetail.Columns[4].Name = "REP_0";
            grid_RoutePlanDetail.Columns[4].ReadOnly = true;
            grid_RoutePlanDetail.Columns[4].Width = 60;
            grid_RoutePlanDetail.Columns[4].Visible = false;
            grid_RoutePlanDetail.Columns[4].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[4].DataPropertyName = "REP_0";

            grid_RoutePlanDetail.Columns[5].Name = "ShipType";
            grid_RoutePlanDetail.Columns[5].ReadOnly = true;
            grid_RoutePlanDetail.Columns[5].Width = 80;
            grid_RoutePlanDetail.Columns[5].Visible = false;
            grid_RoutePlanDetail.Columns[5].MinimumWidth = 80;
            grid_RoutePlanDetail.Columns[5].DataPropertyName = "ShipType";

            grid_RoutePlanDetail.Columns[6].Name = "Address1";
            grid_RoutePlanDetail.Columns[6].ReadOnly = true;
            grid_RoutePlanDetail.Columns[6].Width = 90;
            grid_RoutePlanDetail.Columns[6].MinimumWidth = 90;
            grid_RoutePlanDetail.Columns[6].DataPropertyName = "Address1";

            grid_RoutePlanDetail.Columns[7].Name = "Address2";
            grid_RoutePlanDetail.Columns[7].ReadOnly = true;
            grid_RoutePlanDetail.Columns[7].Width = 75;
            grid_RoutePlanDetail.Columns[7].Visible = false;
            grid_RoutePlanDetail.Columns[7].MinimumWidth = 75;
            grid_RoutePlanDetail.Columns[7].DataPropertyName = "Address2";

            grid_RoutePlanDetail.Columns[8].Name = "PostalCode";
            grid_RoutePlanDetail.Columns[8].ReadOnly = true;
            grid_RoutePlanDetail.Columns[8].Width = 60;
            grid_RoutePlanDetail.Columns[8].Visible = false;
            grid_RoutePlanDetail.Columns[8].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[8].DataPropertyName = "PostalCode";

            grid_RoutePlanDetail.Columns[9].Name = "City";
            grid_RoutePlanDetail.Columns[9].ReadOnly = true;
            grid_RoutePlanDetail.Columns[9].Width = 60;
            grid_RoutePlanDetail.Columns[9].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[9].DataPropertyName = "City";

            grid_RoutePlanDetail.Columns[10].Name = "State";
            grid_RoutePlanDetail.Columns[10].ReadOnly = true;
            grid_RoutePlanDetail.Columns[10].Width = 25;
            grid_RoutePlanDetail.Columns[10].MinimumWidth = 25;
            grid_RoutePlanDetail.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlanDetail.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlanDetail.Columns[10].DataPropertyName = "State";

            grid_RoutePlanDetail.Columns[11].Name = "Country";
            grid_RoutePlanDetail.Columns[11].ReadOnly = true;
            grid_RoutePlanDetail.Columns[11].Width = 60;
            grid_RoutePlanDetail.Columns[11].Visible = false;
            grid_RoutePlanDetail.Columns[11].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[11].DataPropertyName = "Country";

            grid_RoutePlanDetail.Columns[12].Name = "TEL_0";
            grid_RoutePlanDetail.Columns[12].ReadOnly = true;
            grid_RoutePlanDetail.Columns[12].Width = 60;
            grid_RoutePlanDetail.Columns[12].Visible = false;
            grid_RoutePlanDetail.Columns[12].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[12].DataPropertyName = "TEL_0";

            grid_RoutePlanDetail.Columns[13].Name = "TEL_1";
            grid_RoutePlanDetail.Columns[13].ReadOnly = true;
            grid_RoutePlanDetail.Columns[13].Width = 60;
            grid_RoutePlanDetail.Columns[13].Visible = false;
            grid_RoutePlanDetail.Columns[13].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[13].DataPropertyName = "TEL_1";

            grid_RoutePlanDetail.Columns[14].Name = "FAX_0";
            grid_RoutePlanDetail.Columns[14].ReadOnly = true;
            grid_RoutePlanDetail.Columns[14].Width = 60;
            grid_RoutePlanDetail.Columns[14].Visible = false;
            grid_RoutePlanDetail.Columns[14].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[14].DataPropertyName = "FAX_0";

            grid_RoutePlanDetail.Columns[15].Name = "MOB_0";
            grid_RoutePlanDetail.Columns[15].ReadOnly = true;
            grid_RoutePlanDetail.Columns[15].Width = 60;
            grid_RoutePlanDetail.Columns[15].Visible = false;
            grid_RoutePlanDetail.Columns[15].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[15].DataPropertyName = "MOB_0";

            grid_RoutePlanDetail.Columns[16].Name = "WEB_0";
            grid_RoutePlanDetail.Columns[16].ReadOnly = true;
            grid_RoutePlanDetail.Columns[16].Width = 60;
            grid_RoutePlanDetail.Columns[16].Visible = false;
            grid_RoutePlanDetail.Columns[16].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[16].DataPropertyName = "WEB_0";

            grid_RoutePlanDetail.Columns[17].Name = "Latitude";
            grid_RoutePlanDetail.Columns[17].ReadOnly = true;
            grid_RoutePlanDetail.Columns[17].Width = 60;
            grid_RoutePlanDetail.Columns[17].Visible = false;
            grid_RoutePlanDetail.Columns[17].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[17].DataPropertyName = "Latitude";

            grid_RoutePlanDetail.Columns[18].Name = "Longitude";
            grid_RoutePlanDetail.Columns[18].ReadOnly = true;
            grid_RoutePlanDetail.Columns[18].Width = 60;
            grid_RoutePlanDetail.Columns[18].Visible = false;
            grid_RoutePlanDetail.Columns[18].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[18].DataPropertyName = "Longitude";
            //grid_RoutePlanDetail.Columns[7].DefaultCellStyle.Format = "MM/dd/yyyy";
            //grid font size custom
            DataGridViewCheckBoxColumn pickingCheck = new DataGridViewCheckBoxColumn();
            pickingCheck.HeaderText = "V";
            pickingCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            pickingCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            pickingCheck.FalseValue = false;
            pickingCheck.TrueValue = true;
            pickingCheck.Name = "CheckBox";
            pickingCheck.ReadOnly = true;
            pickingCheck.Visible = false;
            pickingCheck.Width = 30;
            pickingCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_RoutePlanDetail.Columns.Insert(19, pickingCheck);

            grid_RoutePlanDetail.RowTemplate.Height = 17;
            grid_RoutePlanDetail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_RoutePlanDetail.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
                
            }

            grid_RoutePlanDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void RoutePlan_Setting()
        {
            gMapControl1.Overlays.Clear();
            gMapControl1.Refresh();
           // String RouteCode = cbo_SearchCode.Text.ToString();
            String RouteInput = cbo_SearchCode.Text.ToString();
            String[] result = RouteInput.Split('(');
            String RouteCode = result[0].Trim().ToString();

            connSalesOrder.sp_PreparationMap(grid_ORDERS);
            connSalesOrder.sp_RoutePlanDetail(grid_RoutePlanDetail, RouteCode);

            for (int i = 0; i < grid_RoutePlanDetail.RowCount; i++)
            {
                for (int j = 0; j < grid_ORDERS.RowCount; j++)
                {
                    String CusIDFromPlan = grid_RoutePlanDetail.Rows[i].Cells["CustomerID"].Value.ToString();
                    String CusIDFromOrder = grid_ORDERS.Rows[j].Cells["Customer"].Value.ToString();
                    if (CusIDFromPlan.Equals(CusIDFromOrder))
                    {
                        grid_RoutePlanDetail.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        grid_RoutePlanDetail.Rows[i].Cells["CheckBox"].Value = true;
                        grid_ORDERS.Rows[j].Cells["CheckBox"].Value = true;
                        grid_ORDERS.Rows[j].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                }
            }
            MarkTheMap();
            cellUpdate();
        }
        private void getTotalAmount() // get total amount and display
        {
            Decimal Amount = 0;
            for (int i = 0; i < grid_ORDERS.Rows.Count; i++)
            {
                if (Convert.ToBoolean(grid_ORDERS.Rows[i].Cells["CheckBox"].Value) == true)
                {
                    Amount += Convert.ToDecimal(grid_ORDERS.Rows[i].Cells["Amount"].Value);
                }
            }
            txt_amount.Text = Amount.ToString("N2"); // ToString C : $ Currency
        }

        private void grid_ORDERS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(grid_ORDERS.Rows[e.RowIndex].Cells["CheckBox"].EditedFormattedValue) == true)
                {
                    grid_ORDERS.Rows[e.RowIndex].Cells["CheckBox"].Value = false;
                }
                else
                {
                    grid_ORDERS.Rows[e.RowIndex].Cells["CheckBox"].Value = true;
                }
                MarkTheMap();
            }
            catch { }
            cellUpdate();
        }

        private void cellUpdate()
        {
            //for (int i = 0; i < grid_overPayment.RowCount; i++)
            //{
            //    if (Convert.ToBoolean(grid_overPayment.Rows[i].Cells["overPaymentSelect"].EditedFormattedValue) == true)
            //    {
            //        grid_overPayment.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DimGray;
            //        grid_overPayment.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
            //    }
            //    else
            //    {
            //        grid_overPayment.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            //        grid_overPayment.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;
            //    }
            //}

            foreach (DataGridViewRow item in grid_ORDERS.Rows)
            {
                if (Convert.ToBoolean(item.Cells["CheckBox"].EditedFormattedValue) == true)
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

            foreach (DataGridViewRow item in grid_RoutePlanDetail.Rows)
            {
                if (Convert.ToBoolean(item.Cells["CheckBox"].EditedFormattedValue) == true)
                {
                    item.DefaultCellStyle.BackColor = Color.GreenYellow;
                    item.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
                    //item.DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else
                {
                    item.DefaultCellStyle.BackColor = Color.Empty;
                    item.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                   // item.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }

        }

        private void cbo_SearchCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoutePlan_Setting();
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RoutePlan_Setting();
        }
        private void grid_ORDERS_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < grid_RoutePlanDetail.RowCount; i++)
            {
                for (int j = 0; j < grid_ORDERS.RowCount; j++)
                {
                    String CusIDFromPlan = grid_RoutePlanDetail.Rows[i].Cells["CustomerID"].Value.ToString();
                    String CusIDFromOrder = grid_ORDERS.Rows[j].Cells["Customer"].Value.ToString();
                    if (CusIDFromPlan.Equals(CusIDFromOrder))
                    {
                        grid_RoutePlanDetail.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        grid_RoutePlanDetail.Rows[i].Cells["CheckBox"].Value = true;
                        grid_ORDERS.Rows[j].Cells["CheckBox"].Value = true;
                        grid_ORDERS.Rows[j].DefaultCellStyle.BackColor = Color.GreenYellow;
                        //    row.DefaultCellStyle.BackColor = Color.Gray;
                        //row.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
                        //row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            //for(int i = 0; i < grid_ORDERS.RowCount; i++)
            //{
            //    if (Convert.ToBoolean(grid_ORDERS.Rows[i].Cells["CheckBox"].Value) == true)
            //    {
            //        grid_ORDERS.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
            //    }
            //}
            //try
            //{
            //    RoutePlan_Setting();
            //}
            //catch { }
        }
        public void MarkTheMap()
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

                for(int i = 0; i < grid_ORDERS.RowCount; i++)
                {
                    if(Convert.ToBoolean(grid_ORDERS.Rows[i].Cells["CheckBox"].Value) == true)
                    {
                        //string No = grid_ORDERS.Rows[i].Cells["No"].Value.ToString();
                        string CustomerID = grid_ORDERS.Rows[i].Cells["Customer"].Value.ToString();
                        string ZIP = grid_ORDERS.Rows[i].Cells["ZIP"].Value.ToString();
                        string Address = grid_ORDERS.Rows[i].Cells["Address"].Value.ToString();
                        string State = grid_ORDERS.Rows[i].Cells["State"].Value.ToString();
                        string City = grid_ORDERS.Rows[i].Cells["City"].Value.ToString();
                        string Latitude = grid_ORDERS.Rows[i].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_ORDERS.Rows[i].Cells["Latitude"].Value.ToString();
                        string Longitude = grid_ORDERS.Rows[i].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_ORDERS.Rows[i].Cells["Longitude"].Value.ToString();
                        //bool Checks = Convert.ToBoolean(grid_RouteDetail.Rows[i].Cells["CheckBox"].Value);
                        if (Latitude.Equals(""))
                        { ErrorCustomer += CustomerID + ", "; }
                        else
                        {
                            markerOverlay = new GMapOverlay("Marker");
                            gMapControl1.Overlays.Add(markerOverlay);
                            marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.yellow);
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
                }

                gMapControl1.Refresh();
                getTotalAmount();
                //if (grid_ORDERS.RowCount != 0)
                //{
                //    string WLatitude = grid_ORDERS.Rows[0].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_ORDERS.Rows[0].Cells["Latitude"].Value.ToString();
                //    string WLongitude = grid_ORDERS.Rows[0].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_ORDERS.Rows[0].Cells["Longitude"].Value.ToString();
                //    gMapControl1.Position = new PointLatLng(Convert.ToDouble(WLatitude), Convert.ToDouble(WLongitude));
                //}

                if (!ErrorCustomer.Equals("")) MessageBox.Show("Done!\nError : " + ErrorCustomer.ToString() + "\nReason : Address Maping Error", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Map Error. Ask to IT team.\n\n" + ex.ToString());
            }
        }

        private void grid_ORDERS_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure add all the selected orders to this route?"
                                                           , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < grid_ORDERS.RowCount; i++)
                {
                    String OrderNumber = grid_ORDERS.Rows[i].Cells["Order No."].Value.ToString().Trim();
                    String RouteNumber = connSalesOrder.sp_CHECK_ADDORDERTOROUTEPLAN(OrderNumber);
                    if (RouteNumber != "" && RouteNumber != "0")
                    {
                        MessageBox.Show("The Order ID, " + OrderNumber + " is already planed in another route plan, " + RouteNumber + ". Please try again."
                                                                , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        //connSalesOrder.sp_PreparationMap(grid_ORDERS); //루트에 속하지 않은 orderid만 가져와서 grid에 보여주기
                        string SearchCode = cbo_SearchCode.Text.Trim();
                        cbo_SearchCode.Text = SearchCode;
                        RoutePlan_Setting();

                        return;
                    }
                }

                PreparationOrders preparationOrders = new PreparationOrders
                (Convert.ToInt32(txt_RouteNumber.Text), txt_driver.Text.ToString(), txt_truck.Text.ToString());
                for (int j = 0; j < grid_RoutePlanDetail.RowCount; j++)
                {
                    if (Convert.ToBoolean(grid_RoutePlanDetail.Rows[j].Cells["CheckBox"].Value) == true)
                    {
                        String CustomerID = grid_RoutePlanDetail.Rows[j].Cells["CustomerID"].Value.ToString();
                        for (int i = 0; i < grid_ORDERS.RowCount; i++)
                        {
                            if (CustomerID.Equals(grid_ORDERS.Rows[i].Cells["Customer"].Value.ToString()) & 
                                Convert.ToBoolean(grid_ORDERS.Rows[i].Cells["CheckBox"].Value) == true)
                            {
                                String OrderID = grid_ORDERS.Rows[i].Cells["Order No."].Value.ToString();
                                preparationOrders.AddOrderByDoubleClick(OrderID);
                                grid_ORDERS.Rows[i].Cells["CheckBox"].Value = false;
                            }
                        }
                    }
                }
                for (int i = 0; i < grid_ORDERS.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_ORDERS.Rows[i].Cells["CheckBox"].Value) == true)
                    {
                        String OrderID = grid_ORDERS.Rows[i].Cells["Order No."].Value.ToString();
                        preparationOrders.AddOrderByDoubleClick(OrderID);
                        grid_ORDERS.Rows[i].Cells["CheckBox"].Value = false;
                    }
                }
                var mainForm = Application.OpenForms.OfType<PreparationOrders>().FirstOrDefault();
                mainForm.Refresh_PreparationOrder();
                var preparationPlanForm = Application.OpenForms.OfType<PreparationPlan>().FirstOrDefault();
                preparationPlanForm.setStopSave();
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        private void grid_ORDERS_Sorted(object sender, EventArgs e)
        {
            cellUpdate();
        }
        
    }
}
