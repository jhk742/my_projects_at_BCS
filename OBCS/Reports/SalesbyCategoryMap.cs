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

namespace OBCS.Reports
{
    public partial class SalesbyCategoryMap : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        double BCSlatitude = 40.742164;
        double BCSlongitude = -73.931789;


        string ApiKey = "AIzaSyBLxyBEB2O504HHMFcT_oWI5jWD_0x5A5Y";
        
        public SalesbyCategoryMap()
        {
            InitializeComponent();
            grid_Category_Init();
            grid_Customer_Init();

            //connSalesOrder.sp_GET_ProductCategory(grid_Category);
            connSalesOrder.cbo_getCdPackDeptTypeCode(cbo_category);
            BCS_Setting();
        }
        private void grid_Category_Init()
        {
            grid_Category.AutoGenerateColumns = false;
            grid_Category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Category.ColumnCount = 1;
            grid_Category.ColumnHeadersVisible = false;

            DataGridViewCheckBoxColumn confirmCheck = new DataGridViewCheckBoxColumn();
            confirmCheck.HeaderText = "V";
            confirmCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            confirmCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            confirmCheck.FalseValue = false;
            confirmCheck.TrueValue = true;
            confirmCheck.Name = "CheckBox";
            confirmCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            confirmCheck.ReadOnly = true;
            confirmCheck.Width = 25;
            //confirmCheck.HeaderCell.
            confirmCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            grid_Category.Columns.Insert(0, confirmCheck);
            grid_Category.CellContentClick += new DataGridViewCellEventHandler(confirmcellclick);

            grid_Category.Columns[1].Name = "Category";
            grid_Category.Columns[1].ReadOnly = true;
            grid_Category.Columns[1].Width = 30;
            grid_Category.Columns[1].MinimumWidth = 30;
            grid_Category.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Category.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Category.Columns[1].DataPropertyName = "CdPackDeptTypeCode";

            //grid font size custom
            grid_Category.RowTemplate.Height = 20;

            foreach (DataGridViewColumn c in grid_Category.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            for (int i = 0; i < grid_Category.ColumnCount; i++)
            {
                grid_Category.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            grid_Category.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);

        }
        private void grid_Customer_Init()
        {
            grid_Customer.AutoGenerateColumns = false;
            grid_Customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Customer.ColumnCount = 16;

            grid_Customer.Columns[0].Name = "CustomerID";
            grid_Customer.Columns[0].ReadOnly = true;
            grid_Customer.Columns[0].Width = 10;
            grid_Customer.Columns[0].MinimumWidth = 10;
            grid_Customer.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[0].DataPropertyName = "CustomerID";

            grid_Customer.Columns[1].Name = "CustomerName";
            grid_Customer.Columns[1].ReadOnly = true;
            grid_Customer.Columns[1].Width = 90;
            grid_Customer.Columns[1].MinimumWidth = 90;
            grid_Customer.Columns[1].Visible = false;
            grid_Customer.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[1].DataPropertyName = "CustomerName";

            grid_Customer.Columns[2].Name = "Rep";
            grid_Customer.Columns[2].ReadOnly = true;
            grid_Customer.Columns[2].Width = 5;
            grid_Customer.Columns[2].MinimumWidth = 5;
            grid_Customer.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[2].DataPropertyName = "SaleRep";

            grid_Customer.Columns[3].Name = "Address";
            grid_Customer.Columns[3].ReadOnly = true;
            grid_Customer.Columns[3].Width = 60;
            grid_Customer.Columns[3].MinimumWidth = 60;
            grid_Customer.Columns[3].Visible = false;
            grid_Customer.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[3].DataPropertyName = "Address";

            grid_Customer.Columns[4].Name = "City";
            grid_Customer.Columns[4].ReadOnly = true;
            grid_Customer.Columns[4].Width = 30;
            grid_Customer.Columns[4].MinimumWidth = 30;
            grid_Customer.Columns[4].Visible = false;
            grid_Customer.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[4].DataPropertyName = "City";

            grid_Customer.Columns[5].Name = "State";
            grid_Customer.Columns[5].ReadOnly = true;
            grid_Customer.Columns[5].Width = 30;
            grid_Customer.Columns[5].MinimumWidth = 30;
            grid_Customer.Columns[5].Visible = false;
            grid_Customer.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[5].DataPropertyName = "State";

            grid_Customer.Columns[6].Name = "Postal";
            grid_Customer.Columns[6].ReadOnly = true;
            grid_Customer.Columns[6].Width = 50;
            grid_Customer.Columns[6].MinimumWidth = 50;
            grid_Customer.Columns[6].Visible = false;
            grid_Customer.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[6].DataPropertyName = "Postal";

            grid_Customer.Columns[7].Name = "InActive";
            grid_Customer.Columns[7].ReadOnly = true;
            grid_Customer.Columns[7].Width = 50;
            grid_Customer.Columns[7].MinimumWidth = 50;
            grid_Customer.Columns[7].Visible = false;
            grid_Customer.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[7].DataPropertyName = "InActive";

            grid_Customer.Columns[8].Name = "Latitude";
            grid_Customer.Columns[8].ReadOnly = true;
            grid_Customer.Columns[8].Width = 50;
            grid_Customer.Columns[8].MinimumWidth = 50;
            grid_Customer.Columns[8].Visible = false;
            grid_Customer.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[8].DataPropertyName = "Latitude";

            grid_Customer.Columns[9].Name = "Longitude";
            grid_Customer.Columns[9].ReadOnly = true;
            grid_Customer.Columns[9].Width = 50;
            grid_Customer.Columns[9].MinimumWidth = 50;
            grid_Customer.Columns[9].Visible = false;
            grid_Customer.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[9].DataPropertyName = "Longitude";

            grid_Customer.Columns[10].Name = "Payment";
            grid_Customer.Columns[10].ReadOnly = true;
            grid_Customer.Columns[10].Width = 50;
            grid_Customer.Columns[10].MinimumWidth = 50;
            grid_Customer.Columns[10].Visible = false;
            grid_Customer.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[10].DataPropertyName = "Payment";

            grid_Customer.Columns[11].Name = "Memo";
            grid_Customer.Columns[11].ReadOnly = true;
            grid_Customer.Columns[11].Width = 50;
            grid_Customer.Columns[11].MinimumWidth = 50;
            grid_Customer.Columns[11].Visible = false;
            grid_Customer.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[11].DataPropertyName = "Memo";

            grid_Customer.Columns[12].Name = "TEL_0";
            grid_Customer.Columns[12].ReadOnly = true;
            grid_Customer.Columns[12].Width = 50;
            grid_Customer.Columns[12].MinimumWidth = 50;
            grid_Customer.Columns[12].Visible = false;
            grid_Customer.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[12].DataPropertyName = "TEL_0";

            grid_Customer.Columns[13].Name = "WEB_0";
            grid_Customer.Columns[13].ReadOnly = true;
            grid_Customer.Columns[13].Width = 50;
            grid_Customer.Columns[13].MinimumWidth = 50;
            grid_Customer.Columns[13].Visible = false;
            grid_Customer.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[13].DataPropertyName = "WEB_0";

            grid_Customer.Columns[14].Name = "LastInvoiceDate";
            grid_Customer.Columns[14].ReadOnly = true;
            grid_Customer.Columns[14].Width = 60;
            grid_Customer.Columns[14].MinimumWidth = 60;
            grid_Customer.Columns[14].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_Customer.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[14].DataPropertyName = "LastInvoiceDate";

            grid_Customer.Columns[15].Name = "Amount";
            grid_Customer.Columns[15].ReadOnly = true;
            grid_Customer.Columns[15].Width = 70;
            grid_Customer.Columns[15].MinimumWidth = 70;
            grid_Customer.Columns[15].DefaultCellStyle.Format = "N2";
            grid_Customer.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Customer.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[15].DataPropertyName = "Amount";


            //grid font size custom
            grid_Customer.RowTemplate.Height = 20;
            grid_Customer.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_Customer.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            for (int i = 0; i < grid_Customer.ColumnCount; i++)
            {
                grid_Customer.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
            }
            grid_Customer.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void BCS_Setting()
        {
            try
            {
                gMapControl1.DragButton = MouseButtons.Left;
                gMapControl1.CanDragMap = true;
                gMapControl1.MapProvider = GMapProviders.GoogleMap;
                gMapControl1.Position = new PointLatLng(BCSlatitude, BCSlongitude);

                gMapControl1.MinZoom = 0;
                gMapControl1.MaxZoom = 24;
                gMapControl1.Zoom = 12;
                gMapControl1.AutoScroll = true;

                markerOverlay = new GMapOverlay("Marker");
                marker = new GMarkerGoogle(new PointLatLng(BCSlatitude, BCSlongitude), GMarkerGoogleType.red_dot);
                markerOverlay.Markers.Add(marker);

                GMapToolTip tooltip = new GMapToolTip(marker);

                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                //tooltip.Fill = new SolidBrush(Color.SkyBlue);
                tooltip.Font = new Font("Arial", 12, FontStyle.Bold);
                marker.ToolTip = tooltip;
                marker.ToolTip.Stroke = new Pen(Color.Magenta, 2);
                marker.ToolTipText = string.Format("\nBCS ROYAL \nAddress :47-15 33rd St, Long Island City, NY 11101\nLatitude : {0} \nLongtitude : {1}", BCSlatitude, BCSlongitude);
                marker.ToolTip.TextPadding = new Size(3, 1);

                gMapControl1.Overlays.Add(markerOverlay);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void confirmcellclick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0) //confirm check box click
                {
                    if (Convert.ToBoolean(grid_Category.Rows[e.RowIndex].Cells[0].EditedFormattedValue) == false)
                        grid_Category.Rows[e.RowIndex].Cells[0].Value = true;
                    else                    // uncheck 했을 때
                        grid_Category.Rows[e.RowIndex].Cells[0].Value = false;
                }

            }
            catch
            { }
        }
        private void SalesbyCategoryMap_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_Category.RowCount; i++)
            {
                grid_Category.Rows[i].Cells[0].Value = false;
            }
        }
        private void btn_Satellite_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
        }
        private void btn_Map_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }
        private void btn_Hybrid_Click(object sender, EventArgs e)
        {

            gMapControl1.MapProvider = GMapProviders.GoogleHybridMap;
        }
        private void btn_BcsLogo_Click(object sender, EventArgs e)
        {
            double ZoomIndex = Convert.ToDouble(gMapControl1.Zoom.ToString());
            gMapControl1.Zoom = 15;
            gMapControl1.Position = new PointLatLng(BCSlatitude, BCSlongitude);

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String Category = cbo_category.Text.ToString();
            grid_Customer.DataSource = null;
            connSalesOrder.sp_CustomerMapListByCategory(grid_Customer, Category, FromDate, ToDate);

            //CustomerByCategory(FromDate, ToDate);
            
            MarkTheMap();
            BCS_Setting();


        }
        private void MarkTheMap()
        {
            String ErrorCustomer = "";
            String Category = cbo_category.Text.ToString();
            cbo_CustomerID.Items.Clear();
            try
            {
                gMapControl1.Overlays.Clear();
                gMapControl1.Refresh();

                for (int i = 0; i < grid_Customer.RowCount; i++)
                {
                    string CustomerID = grid_Customer.Rows[i].Cells["CustomerID"].Value.ToString();
                    string CustomerName = grid_Customer.Rows[i].Cells["CustomerName"].Value.ToString();
                    string SalesRep = grid_Customer.Rows[i].Cells["Rep"].Value.ToString();
                    string Result = connSalesOrder.sp_CustomerMapMarkByID(CustomerID);
                    string Address = grid_Customer.Rows[i].Cells["Address"].Value.ToString();
                    string State = grid_Customer.Rows[i].Cells["State"].Value.ToString();
                    string City = grid_Customer.Rows[i].Cells["City"].Value.ToString();
                    string Postal = grid_Customer.Rows[i].Cells["Postal"].Value.ToString();
                    string Memo = grid_Customer.Rows[i].Cells["Memo"].Value.ToString();
                    string TEL = grid_Customer.Rows[i].Cells["TEL_0"].Value.ToString();
                    string WEB = grid_Customer.Rows[i].Cells["WEB_0"].Value.ToString();
                    string Latitude = grid_Customer.Rows[i].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[i].Cells["Latitude"].Value.ToString();
                    string Longitude = grid_Customer.Rows[i].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[i].Cells["Longitude"].Value.ToString();
                    DateTime LastInvoiceDate = grid_Customer.Rows[i].Cells["LastInvoiceDate"].Value == DBNull.Value ? Convert.ToDateTime("1900-01-01") : Convert.ToDateTime(grid_Customer.Rows[i].Cells["LastInvoiceDate"].Value);
                    Double Amount = Convert.ToDouble(grid_Customer.Rows[i].Cells["Amount"].Value);
                    string InActive = grid_Customer.Rows[i].Cells["InActive"].Value.ToString();

                    //MessageBox.Show("CustomerID : " + CustomerID + "\n" + "CustomerName : " + CustomerName + "\n" + "SalesRep : " + SalesRep + "\n"
                    //    + "Result : " + Result + "\n" + "Address : " + Address + "\n" + "State : " + State + "\n"
                    //    + "City : " + City + "\n" + "Postal : " + Postal + "\n" + "Memo : " + Memo + "\n"
                    //    + "TEL : " + TEL + "\n" + "WEB : " + WEB + "\n" + "Latitude : " + Latitude + "\n" + "Longitude : " + Longitude + "\n" + "Amount : " + Amount + "\n"
                    //    + "InActive : " + InActive + "\n");

                    if (Latitude.Equals(""))
                    { ErrorCustomer += CustomerID + ", "; }
                    else
                    {
                        gMapControl1.DragButton = MouseButtons.Left;
                        gMapControl1.CanDragMap = true;
                        gMapControl1.MapProvider = GMapProviders.GoogleMap;

                        gMapControl1.MinZoom = 0;
                        gMapControl1.MaxZoom = 24;
                        gMapControl1.Zoom = 12;
                        gMapControl1.AutoScroll = true;

                        markerOverlay = new GMapOverlay("Marker");

                        if (InActive.Equals("InActive"))
                        {
                            marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.gray_small);
                        }
                        else
                        {
                            switch (Category)
                            {
                                case "AG":
                                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.blue_small);
                                    break;
                                case "AK":
                                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.yellow_small);
                                    break;
                                case "BF":
                                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.brown_small);
                                    break;
                                case "CP":
                                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.green_small);
                                    break;
                                case "DR":
                                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.orange_small);
                                    break;
                                case "EF":
                                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.white_small);
                                    break;
                                case "FC":
                                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.red_small);
                                    break;
                                case "FP":
                                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.purple_small);
                                    break;
                                default:
                                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.black_small);
                                    break;
                            }
                        }
                        
                        markerOverlay.Markers.Add(marker);

                        GMapToolTip tooltip = new GMapToolTip(marker);

                        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        tooltip.Font = new Font("Arial", 12, FontStyle.Bold);
                        marker.ToolTip = tooltip;
                        marker.ToolTipText = string.Format("SalesRep : {0}\nCustomer : {1}    InActive : {2} \n\nAddress : {3}\nMemo : {4} \nTel : {5}   " +
                            "Web : {6}\nLast Invoice Date : {7} \n\nTotal Sales Amount : {8} ",
                            SalesRep, CustomerID, InActive, Result, Memo, TEL, WEB, LastInvoiceDate.ToString("MM/dd/yyyy"),Amount.ToString("F"));
                        marker.ToolTip.Stroke = new Pen(Color.Magenta, 2);
                        marker.ToolTip.TextPadding = new Size(3, 1);

                        gMapControl1.Overlays.Add(markerOverlay);

                        cbo_CustomerID.Items.Add(CustomerID);
                    }
                }
                if (!ErrorCustomer.Equals("")) MessageBox.Show("Done!\nError : " + ErrorCustomer.ToString() + "\nReason : Address Maping Error", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void cbo_category_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cbo_category.Text.ToString())
            {
                case "":    txt_CategoryName.Text = "";    break;
                case "AG":  txt_CategoryName.Text = "Grocery";  break;
                case "AK":  txt_CategoryName.Text = "Bulk nut"; break;
                case "BF":  txt_CategoryName.Text = "Bread";    break;
                case "CP":  txt_CategoryName.Text = "Package nut";  break;
                case "DR":  txt_CategoryName.Text = "Refrigerated"; break;
                case "EF":  txt_CategoryName.Text = "Frozen";   break;
                case "FC":  txt_CategoryName.Text = "Bulk cheese";  break;
                case "FP":  txt_CategoryName.Text = "Piece cheese"; break;
                default :   txt_CategoryName.Text = "Others";   break;
            }
        }
        private void CustomerByCategory(DateTime FromDate, DateTime ToDate)
        {
            try
            {
                String Text = "";
                int selectedItem = 0;
                if (grid_Category.DataSource != null)
                {
                    List<string> list = new List<string>();

                    for (int i = 0; i < grid_Category.RowCount; i++)
                    {
                        grid_Category.Rows[i].Cells[1].Style.BackColor = Color.Empty;
                        if (grid_Category.Rows[i].Cells[0].Value.Equals(true))
                        {
                            selectedItem += 1;
                            list.Add(grid_Category.Rows[i].Cells[1].Value.ToString());
                        }
                    }
                    string[] array = list.ToArray();

                    if (selectedItem == 0) grid_Customer.DataSource = null;
                    else
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            Text += array[i].ToString();
                            if (i < (array.Length - 1)) Text += ",";
                        }
                        connSalesOrder.sp_CustomerMapListByCategory(grid_Customer, Text, FromDate, ToDate);
                    }
                }
                //MessageBox.Show(Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer by Category \n" + ex.ToString());
            }
        }
        private void grid_Customer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                decimal Total_Amount = 0;
                foreach (DataGridViewRow row in this.grid_Customer.Rows)
                {
                    Total_Amount += Convert.ToDecimal(row.Cells["Amount"].Value);

                    if (row.Cells["InActive"].Value.Equals("InActive"))
                    {
                        for (int i = 0; i < grid_Customer.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Gray;
                        }
                    }
                }
                txt_TotalAmount.Text = Total_Amount.ToString("F");
            }
            catch { }
        }
        private void grid_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selection = e.RowIndex;
                string Latitude = grid_Customer.Rows[selection].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[selection].Cells["Latitude"].Value.ToString();
                string Longitude = grid_Customer.Rows[selection].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[selection].Cells["Longitude"].Value.ToString();
                string CustomerID = grid_Customer.Rows[selection].Cells["CustomerID"].Value.ToString();

                gMapControl1.Position = new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude));
                gMapControl1.Zoom = 15;
            }
            catch { }
        }
        private void grid_Customer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selection = e.RowIndex;
                string Latitude = grid_Customer.Rows[selection].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[selection].Cells["Latitude"].Value.ToString();
                string Longitude = grid_Customer.Rows[selection].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[selection].Cells["Longitude"].Value.ToString();
                string CustomerID = grid_Customer.Rows[selection].Cells["CustomerID"].Value.ToString();
                gMapControl1.Position = new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude));
                gMapControl1.Zoom = 15;
            }
            catch { }
        }
        private void cbo_CustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            String SearchCustomerID = cbo_CustomerID.Text.ToString();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                for (int i = 0; i < grid_Customer.RowCount; i++)
                {
                    String CustomerID = grid_Customer.Rows[i].Cells["CustomerID"].Value.ToString();
                    if (CustomerID.Contains(SearchCustomerID))
                    {
                        grid_Customer.Rows[i].Selected = true;
                        grid_Customer.FirstDisplayedScrollingRowIndex = grid_Customer.SelectedRows[0].Index;

                        string Latitude = grid_Customer.Rows[i].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[i].Cells["Latitude"].Value.ToString();
                        string Longitude = grid_Customer.Rows[i].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[i].Cells["Longitude"].Value.ToString();

                        gMapControl1.Position = new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude));
                        gMapControl1.Zoom = 15;
                        cbo_CustomerID_SelectedValueChanged(sender,e);
                        break;
                    }
                }
            }
        }
        private void cbo_CustomerID_SelectedValueChanged(object sender, EventArgs e)
        {
            String SearchCustomerID = cbo_CustomerID.Text.ToString();
            for (int i = 0; i < grid_Customer.RowCount; i++)
            {
                String CustomerID = grid_Customer.Rows[i].Cells["CustomerID"].Value.ToString();
                if (CustomerID.Contains(SearchCustomerID))
                {
                    grid_Customer.Rows[i].Selected = true;
                    grid_Customer.FirstDisplayedScrollingRowIndex = grid_Customer.SelectedRows[0].Index;

                    string Latitude = grid_Customer.Rows[i].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[i].Cells["Latitude"].Value.ToString();
                    string Longitude = grid_Customer.Rows[i].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[i].Cells["Longitude"].Value.ToString();

                    gMapControl1.Position = new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude));
                    gMapControl1.Zoom = 15;
                    break;
                }
            }
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            //MessageBox.Show("오 있네 몰랐노 ㅆㅂ");
        }
    }
}
