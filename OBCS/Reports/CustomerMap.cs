using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
//using GoogleMaps.LocationServices;
//using Newtonsoft.Json; //added JSON.NET with Nuget
//using Newtonsoft.Json.Linq;
using OBCS.Properties;

namespace OBCS.Reports
{
    public partial class CustomerMap : Form 
    {

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        int selection = 0;
        double BCSlatitude = 40.742164;
        double BCSlongitude = -73.931789;

        string[] SalesCategoryArray;
        string[][] SalesTotalArray;
        string[,] ColorMatchArray;

        string ApiKey = "JINKIM";

        public CustomerMap()
        {
            InitializeComponent();
            grid_SalesRep_Init();
            grid_Customer_Init();

            connSalesOrder.SalesRepList(grid_SalesRep);
            connPO.cbox_getCustomerID(cbo_Customer);

            BCS_Setting();
            ListviewSetup();

        }
        private void ListviewSetup()
        {
            try
            {
                listView1.View = View.Details;
                listView1.Columns.Add("    ", 10, HorizontalAlignment.Center);
                listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
                listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;

                ImageList imgs = new ImageList();
                imgs.ImageSize = new Size(16, 21);

                System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
                string resourceName = asm.GetName().Name + ".Properties.Resources";
                var rm = new System.Resources.ResourceManager(resourceName, asm);
                System.Drawing.Bitmap AImageSample = (Bitmap)rm.GetObject("small_A1");
                System.Drawing.Bitmap CFImageSample = (Bitmap)rm.GetObject("small_C1");
                System.Drawing.Bitmap HImageSample = (Bitmap)rm.GetObject("small_H1");
                System.Drawing.Bitmap SImageSample = (Bitmap)rm.GetObject("small_S1");
                System.Drawing.Bitmap WImageSample = (Bitmap)rm.GetObject("small_W1");
                System.Drawing.Bitmap FImageSample = (Bitmap)rm.GetObject("blue-dot");
                System.Drawing.Bitmap OImageSample = (Bitmap)rm.GetObject("arrow");
                System.Drawing.Bitmap SCWImageSample = (Bitmap)rm.GetObject("small_SCW1");
                System.Drawing.Bitmap CJYImageSample = (Bitmap)rm.GetObject("small_CJY1");
                imgs.Images.Add("A", AImageSample);
                imgs.Images.Add("CF", CFImageSample);
                imgs.Images.Add("F", FImageSample);
                imgs.Images.Add("H", HImageSample);
                imgs.Images.Add("O", OImageSample);
                imgs.Images.Add("S", SImageSample);
                imgs.Images.Add("W", WImageSample);
                imgs.Images.Add("CW", SCWImageSample);
                imgs.Images.Add("JY", CJYImageSample);

                listView1.SmallImageList = imgs;
                listView1.Items.Add("A", 0);
                listView1.Items.Add("CF", 1);
                listView1.Items.Add("F", 2);
                listView1.Items.Add("H", 3);
                listView1.Items.Add("O", 4);
                listView1.Items.Add("S", 5);
                listView1.Items.Add("W", 6);
                listView1.Items.Add("CW", 7);
                listView1.Items.Add("JY", 8);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
                marker.ToolTip.TextPadding = new Size(10, 5);

                gMapControl1.Overlays.Add(markerOverlay);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void grid_SalesRep_Init()
        {
            grid_SalesRep.AutoGenerateColumns = false;
            grid_SalesRep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_SalesRep.ColumnCount = 1;

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
            grid_SalesRep.Columns.Insert(0, confirmCheck);
            grid_SalesRep.CellContentClick += new DataGridViewCellEventHandler(confirmcellclick);

            //DataGridViewImageColumn salesimage = new DataGridViewImageColumn();
            //salesimage.

            grid_SalesRep.Columns[1].Name = "Rep";
            grid_SalesRep.Columns[1].ReadOnly = true;
            grid_SalesRep.Columns[1].Width = 30;
            grid_SalesRep.Columns[1].MinimumWidth = 30;
            grid_SalesRep.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[1].DataPropertyName = "REPNUM_0";

            //grid font size custom
            grid_SalesRep.RowTemplate.Height = 20;

            foreach (DataGridViewColumn c in grid_SalesRep.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            for (int i = 0; i < grid_SalesRep.ColumnCount; i++)
            {
                grid_SalesRep.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            grid_SalesRep.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);

        }
        private void grid_Customer_Init()
        {
            grid_Customer.AutoGenerateColumns = false;
            grid_Customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Customer.ColumnCount = 23;

            grid_Customer.Columns[0].Name = "Rep";
            grid_Customer.Columns[0].ReadOnly = true;
            grid_Customer.Columns[0].Width = 20;
            grid_Customer.Columns[0].MinimumWidth = 20;
            grid_Customer.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[0].DataPropertyName = "SalesRep";

            grid_Customer.Columns[1].Name = "CustomerID";
            grid_Customer.Columns[1].ReadOnly = true;
            grid_Customer.Columns[1].Width = 40;
            grid_Customer.Columns[1].MinimumWidth = 40;
            grid_Customer.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[1].DataPropertyName = "CustomerID";

            grid_Customer.Columns[2].Name = "CustomerName";
            grid_Customer.Columns[2].ReadOnly = true;
            grid_Customer.Columns[2].Width = 90;
            grid_Customer.Columns[2].MinimumWidth = 90;
            grid_Customer.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[2].DataPropertyName = "CustomerName";

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
            grid_Customer.Columns[8].DataPropertyName = "WEB_3";

            grid_Customer.Columns[9].Name = "Longitude";
            grid_Customer.Columns[9].ReadOnly = true;
            grid_Customer.Columns[9].Width = 50;
            grid_Customer.Columns[9].MinimumWidth = 50;
            grid_Customer.Columns[9].Visible = false;
            grid_Customer.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[9].DataPropertyName = "WEB_4";

            grid_Customer.Columns[10].Name = "CustomerState";
            grid_Customer.Columns[10].ReadOnly = true;
            grid_Customer.Columns[10].Width = 50;
            grid_Customer.Columns[10].MinimumWidth = 50;
            grid_Customer.Columns[10].Visible = false;
            grid_Customer.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[10].DataPropertyName = "CustomerState";

            grid_Customer.Columns[11].Name = "Memo";
            grid_Customer.Columns[11].ReadOnly = true;
            grid_Customer.Columns[11].Width = 50;
            grid_Customer.Columns[11].MinimumWidth = 50;
            grid_Customer.Columns[11].Visible = false;
            grid_Customer.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[11].DataPropertyName = "Memo";

            grid_Customer.Columns[12].Name = "PACK MEMO";
            grid_Customer.Columns[12].ReadOnly = true;
            grid_Customer.Columns[12].Width = 50;
            grid_Customer.Columns[12].MinimumWidth = 50;
            grid_Customer.Columns[12].Visible = false;
            grid_Customer.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[12].DataPropertyName = "YPACKMEMO_0";

            grid_Customer.Columns[13].Name = "DELV MEMO";
            grid_Customer.Columns[13].ReadOnly = true;
            grid_Customer.Columns[13].Width = 50;
            grid_Customer.Columns[13].MinimumWidth = 50;
            grid_Customer.Columns[13].Visible = false;
            grid_Customer.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[13].DataPropertyName = "YDELVMEMO_0";

            grid_Customer.Columns[14].Name = "TEL";
            grid_Customer.Columns[14].ReadOnly = true;
            grid_Customer.Columns[14].Width = 50;
            grid_Customer.Columns[14].MinimumWidth = 50;
            grid_Customer.Columns[14].Visible = false;
            grid_Customer.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[14].DataPropertyName = "TEL_0";

            grid_Customer.Columns[15].Name = "WEB";
            grid_Customer.Columns[15].ReadOnly = true;
            grid_Customer.Columns[15].Width = 50;
            grid_Customer.Columns[15].MinimumWidth = 50;
            grid_Customer.Columns[15].Visible = false;
            grid_Customer.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[15].DataPropertyName = "WEB_0";

            grid_Customer.Columns[16].Name = "LastInvoiceDate";
            grid_Customer.Columns[16].ReadOnly = true;
            grid_Customer.Columns[16].Width = 50;
            grid_Customer.Columns[16].MinimumWidth = 50;
            grid_Customer.Columns[16].Visible = false;
            grid_Customer.Columns[16].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_Customer.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[16].DataPropertyName = "LastInvoiceDate";

            grid_Customer.Columns[17].Name = "Order Count";
            grid_Customer.Columns[17].ReadOnly = true;
            grid_Customer.Columns[17].Width = 50;
            grid_Customer.Columns[17].MinimumWidth = 50;
            grid_Customer.Columns[17].Visible = false;
            grid_Customer.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[17].DataPropertyName = "OrderCount";

            grid_Customer.Columns[18].Name = "Average Income Amount";
            grid_Customer.Columns[18].ReadOnly = true;
            grid_Customer.Columns[18].Width = 50;
            grid_Customer.Columns[18].MinimumWidth = 50;
            grid_Customer.Columns[18].Visible = false;
            grid_Customer.Columns[18].DefaultCellStyle.Format = "N2";
            grid_Customer.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[18].DataPropertyName = "AverageIncomeAmount";

            grid_Customer.Columns[19].Name = "Weeks As Customer";
            grid_Customer.Columns[19].ReadOnly = true;
            grid_Customer.Columns[19].Width = 50;
            grid_Customer.Columns[19].MinimumWidth = 50;
            grid_Customer.Columns[19].Visible = false;
            grid_Customer.Columns[19].DefaultCellStyle.Format = "N2";
            grid_Customer.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[19].DataPropertyName = "WeeksAsCustomer";

            grid_Customer.Columns[20].Name = "Weekly Average Order Count";
            grid_Customer.Columns[20].ReadOnly = true;
            grid_Customer.Columns[20].Width = 50;
            grid_Customer.Columns[20].MinimumWidth = 50;
            grid_Customer.Columns[20].Visible = false;
            grid_Customer.Columns[20].DefaultCellStyle.Format = "N4";
            grid_Customer.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[20].DataPropertyName = "WeeklyAverageOrderCount";

            grid_Customer.Columns[21].Name = "Customer Since";
            grid_Customer.Columns[21].ReadOnly = true;
            grid_Customer.Columns[21].Width = 50;
            grid_Customer.Columns[21].MinimumWidth = 50;
            grid_Customer.Columns[21].Visible = false;
            grid_Customer.Columns[21].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_Customer.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[21].DataPropertyName = "MinDate";

            grid_Customer.Columns[22].Name = "Weekly Average Amount";
            grid_Customer.Columns[22].ReadOnly = true;
            grid_Customer.Columns[22].Width = 50;
            grid_Customer.Columns[22].MinimumWidth = 50;
            grid_Customer.Columns[22].Visible = false;
            grid_Customer.Columns[22].DefaultCellStyle.Format = "N2";
            grid_Customer.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[22].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Customer.Columns[22].DataPropertyName = "WeeklyAverageAmount";

            grid_Customer.RowTemplate.Height = 20;
            grid_Customer.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_Customer.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            for (int i = 0; i < grid_Customer.ColumnCount; i++)
            {
                grid_Customer.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
            }
            grid_Customer.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void confirmcellclick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0) //confirm check box click
                {
                    if (Convert.ToBoolean(grid_SalesRep.Rows[e.RowIndex].Cells[0].EditedFormattedValue) == false)
                        grid_SalesRep.Rows[e.RowIndex].Cells[0].Value = true;
                    else                 
                        grid_SalesRep.Rows[e.RowIndex].Cells[0].Value = false;
                }

            }
            catch
            { }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            CustomerBySalesRep();
            MarkTheMap();
            gMapControl1.Zoom = 11;
            BCS_Setting();
        }

        private void CustomerBySalesRep()
        {
            try
            {
                string Text = "";
                int selectedItem = 0;
                if (grid_SalesRep.DataSource != null)
                {
                    List<string> list = new List<string>();
                    List<int> ListRowNumber = new List<int>();
                    List<string> SubStringList = new List<string>();

                    for (int i = 0; i < grid_SalesRep.RowCount; i++)
                    {
                        grid_SalesRep.Rows[i].Cells[1].Style.BackColor = Color.Empty;
                        if (grid_SalesRep.Rows[i].Cells[0].Value.Equals(true))
                        {
                            selectedItem += 1;
                            list.Add(grid_SalesRep.Rows[i].Cells[1].Value.ToString());
                            ListRowNumber.Add(i);
                            SubStringList.Add(grid_SalesRep.Rows[i].Cells[1].Value.ToString().Substring(0, 1));
                        }
                    }
                    SalesCategoryArray = SubStringList.Distinct().ToArray();
                    SalesTotalArray = new string[SalesCategoryArray.Length][];
                    ColorMatchArray = new string[selectedItem, 2];
                    string[] array = list.ToArray();

                    for (int i = 0; i < SalesCategoryArray.Length; i++)
                    {
                        var result = array.Where(item => item.Substring(0, 1).Equals(SalesCategoryArray[i].ToString()));
                        SalesTotalArray[i] = result.ToArray();
                    }
                    int x = 0;
                    foreach (DataGridViewRow row in this.grid_SalesRep.Rows)
                    {
                        if (row.Cells[0].Value.Equals(true))
                        {
                            for (int i = 0; i < SalesCategoryArray.Length; i++)
                            {
                                if (SalesCategoryArray[i].ToString().Equals((row.Cells[1].Value.ToString()).Substring(0, 1)))
                                {
                                    for (int j = 0; j < SalesTotalArray[i].Length; j++)
                                    {
                                        if (row.Cells[1].Value.ToString().Equals(SalesTotalArray[i][j].ToString()))
                                        {
                                            string salesrep = row.Cells[1].Value.ToString();
                                            System.Drawing.Color mycolor = System.Drawing.ColorTranslator.FromHtml("#" + SetUpColor(j));
                                            row.Cells[1].Style.BackColor = mycolor;
                                            //}

                                            if (x < selectedItem)
                                            {
                                                ColorMatchArray[x, 0] = row.Cells[1].Value.ToString();
                                                ColorMatchArray[x, 1] = j.ToString();
                                            }
                                            x++;
                                        }
                                    }
                                }
                            } 
                        }
                    }
                    if (selectedItem == 0) grid_Customer.DataSource = null;
                    else
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            Text += array[i].ToString();
                            if (i < (array.Length - 1)) Text += ",";
                        }
                        //String result = Text.Remove(Text.Length - 1);
                        connPO.sp_CustomerMapListBySalesRep(grid_Customer, Text);
                    }

                }
                else MessageBox.Show("No Data Source.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer by SalesRep \n" + ex.ToString());
            }

        }
        private void MarkTheMap()
        {
            //MessageBox.Show("Inside");
            String ErrorCustomer = "";
            try
            {
                gMapControl1.Overlays.Clear();
                gMapControl1.Refresh();

                for (int i = 0; i < grid_Customer.RowCount; i++)
                {
                    //MessageBox.Show("Inside for loop " + i);
                    string SalesRep = grid_Customer.Rows[i].Cells["Rep"].Value.ToString();
                    string CustomerID = grid_Customer.Rows[i].Cells["CustomerID"].Value.ToString();
                    string CustomerName = grid_Customer.Rows[i].Cells["CustomerName"].Value.ToString();
                    string Result = connSalesOrder.sp_CustomerMapMarkByID(CustomerID);
                    string Address = grid_Customer.Rows[i].Cells["Address"].Value.ToString();
                    string State = grid_Customer.Rows[i].Cells["State"].Value.ToString();
                    string City = grid_Customer.Rows[i].Cells["City"].Value.ToString();
                    string Postal = grid_Customer.Rows[i].Cells["Postal"].Value.ToString();
                    string Latitude = grid_Customer.Rows[i].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[i].Cells["Latitude"].Value.ToString();
                    string Longitude = grid_Customer.Rows[i].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[i].Cells["Longitude"].Value.ToString();
                    string CustomerState = grid_Customer.Rows[i].Cells["CustomerState"].Value.ToString();
                    string Memo = grid_Customer.Rows[i].Cells["Memo"].Value.ToString();
                    string PackMemo = grid_Customer.Rows[i].Cells["PACK MEMO"].Value.ToString();
                    string DelvMemo = grid_Customer.Rows[i].Cells["DELV MEMO"].Value.ToString();
                    string TEL = grid_Customer.Rows[i].Cells["TEL"].Value.ToString();
                    string WEB = grid_Customer.Rows[i].Cells["WEB"].Value.ToString();
                    string oc = grid_Customer.Rows[i].Cells["Order Count"].Value.ToString();
                    string aia = grid_Customer.Rows[i].Cells["Average Income Amount"].Value.ToString();
                    string weeksAsCustomer = grid_Customer.Rows[i].Cells["Weeks As Customer"].Value.ToString();
                    string weeklyAverageOrderCount = grid_Customer.Rows[i].Cells["Weekly Average Order Count"].Value.ToString();
                    string customerSince = grid_Customer.Rows[i].Cells["Customer Since"].Value.ToString();
                    string weeklyAverageAmount = grid_Customer.Rows[i].Cells["Weekly Average Amount"].Value.ToString();
                    DateTime LastInvoiceDate = grid_Customer.Rows[i].Cells["LastInvoiceDate"].Value == DBNull.Value ? Convert.ToDateTime("1900-01-01") : Convert.ToDateTime(grid_Customer.Rows[i].Cells["LastInvoiceDate"].Value);
                    //string netSales = grid_Customer.Rows[i].Cells["Net Sales"].Value.ToString();
                    //MessageBox.Show("Done with strings " + i);
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

                        if (CustomerState.Equals("Active"))
                        {
                            for (int a = 0; a < ColorMatchArray.Length / 2; a++)
                            {
                                if (SalesRep.Equals(ColorMatchArray[a, 0].ToString()))
                                {
                                    int ColorNumber = Convert.ToInt32(ColorMatchArray[a, 1]);
                                    String SalesChar = SalesRep.Substring(0, 1);
                                    String ImageName = "small_";
                                    ImageName = ImageName + SalesChar + ((ColorNumber + 1) % 20).ToString();
                                    //MessageBox.Show(ImageName);
                                    System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
                                    string resourceName = asm.GetName().Name + ".Properties.Resources";
                                    var rm = new System.Resources.ResourceManager(resourceName, asm);

                                    if (SalesChar.Equals("O"))
                                    {
                                        marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.arrow);
                                    }
                                    else if (SalesChar.Equals("F"))
                                    {
                                        marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.blue_dot);
                                    }
                                    else if (SalesRep.Equals("S13") || SalesRep.Equals("A13") || SalesRep.Equals("H11"))
                                    {
                                        String SCWImageName = "small_";
                                        SCWImageName = SCWImageName + "SCW" + ((ColorNumber + 1) % 20).ToString();
                                        System.Drawing.Bitmap Image = (Bitmap)rm.GetObject(SCWImageName);
                                        marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), Image);
                                    }
                                    else if (SalesRep.Equals("H16") || SalesRep.Equals("A16"))
                                    {
                                        String CJYImageName = "small_";
                                        CJYImageName = CJYImageName + "CJY" + ((ColorNumber + 1) % 20).ToString();
                                        System.Drawing.Bitmap Image = (Bitmap)rm.GetObject(CJYImageName);
                                        marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), Image);
                                    }
                                    else
                                    {
                                        System.Drawing.Bitmap Image = (Bitmap)rm.GetObject(ImageName);
                                        //MessageBox.Show("CustomerID: " + CustomerID + " Latitude: " + Latitude + ", Longitude: " + Longitude);
                                        marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), Image);
                                    }
                                }
                            }
                            markerOverlay.Markers.Add(marker);

                            GMapToolTip tooltip = new GMapToolTip(marker);

                            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                            tooltip.Font = new Font("Arial", 12, FontStyle.Bold);
                            marker.ToolTip = tooltip;
                            //MessageBox.Show("Stitching together " + i);
                            marker.ToolTipText = string.Format("SalesRep : {0}\nCompany : {1} \nAddress : {2}\nMemo : {3} \nTel : {4}   " +
                                "Web : {5}\nLast Invoice Date : {6}     Customer Status : {7}" +
                                "\n\nWeekly Average Sales Order Count : {8}" +
                                "\n\nWeekly Average Sales Amount :        {9}" +
                                "\n\nAverage Sales Order Amount :        {10}"/* +
                                "\n\nNet Sales : {11}"*/,
                                SalesRep, CustomerID, Result, Memo, TEL, WEB, LastInvoiceDate.ToString("MM/dd/yyyy"), CustomerState, weeklyAverageOrderCount, aia, weeklyAverageAmount/*, netSales*/);
                            marker.ToolTip.Stroke = new Pen(Color.Magenta, 2);
                            marker.ToolTip.TextPadding = new Size(10, 5);
                            gMapControl1.Overlays.Add(markerOverlay);
                        }
                    }
                }
                //if (!ErrorCustomer.Equals("")) MessageBox.Show("Done!\nError : " + ErrorCustomer.ToString() + "\nReason : Address Mapping Error","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                if (!ErrorCustomer.Equals(""))
                {
                    ErrorCustomer = ErrorCustomer.Remove(ErrorCustomer.Length - 2);
                    MessageBox.Show("\t\tProcess successfully run.\n\nThe following customer(s) could not be loaded on the map:\n\n\t\t" + ErrorCustomer.ToString() + "\n\nReason: Address mapping error. Search the corresponding customer(s) within Customer List for further troubleshooting.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void CustomerMap_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_SalesRep.RowCount; i++)
            {
                grid_SalesRep.Rows[i].Cells[0].Value = false;
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
        private void button1_Click(object sender, EventArgs e)
        {

            gMapControl1.MapProvider = GMapProviders.GoogleHybridMap;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selection = e.RowIndex;
                //string CustomerID = grid_Customer.Rows[selection].Cells["CustomerID"].Value.ToString();
                //string CustomerName = grid_Customer.Rows[selection].Cells["CustomerName"].Value.ToString();
                //string Address = grid_Customer.Rows[selection].Cells["Address"].Value.ToString();
                //string City = grid_Customer.Rows[selection].Cells["City"].Value.ToString();
                //string State = grid_Customer.Rows[selection].Cells["State"].Value.ToString();
                //string Postal = grid_Customer.Rows[selection].Cells["Postal"].Value.ToString();
                string Latitude = grid_Customer.Rows[selection].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[selection].Cells["Latitude"].Value.ToString();
                string Longitude = grid_Customer.Rows[selection].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[selection].Cells["Longitude"].Value.ToString();
                string CustomerID = grid_Customer.Rows[selection].Cells["CustomerID"].Value.ToString();

                //MessageBox.Show(Latitude+"\n"+Longitude+"\n"+CustomerID);
                gMapControl1.Position = new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude));
                gMapControl1.Zoom = 15;
            }
            catch { }
        }
        private void grid_Customer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selection = e.RowIndex;
                string Latitude = grid_Customer.Rows[selection].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[selection].Cells["Latitude"].Value.ToString();
                string Longitude = grid_Customer.Rows[selection].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[selection].Cells["Longitude"].Value.ToString();
                string CustomerID = grid_Customer.Rows[selection].Cells["CustomerID"].Value.ToString();
                gMapControl1.Position = new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude));
                gMapControl1.Zoom = 15;
            }
            catch { }
        }
        private void cbo_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            gMapControl1.Overlays.Clear();
            gMapControl1.Refresh();
            string CustomerID = cbo_Customer.Text;
            connSalesOrder.sp_CustomerMapListByCustomerID(grid_Customer, CustomerID);

            SearchTheCustomer(CustomerID);
        }

        private void SearchTheCustomer(String CustomerID)
        {
            String ErrorCustomer = "";
            for (int i = 0; i < grid_Customer.RowCount; i++)
            {
                string SalesRep = grid_Customer.Rows[i].Cells["Rep"].Value.ToString();
                string CustomerName = grid_Customer.Rows[i].Cells["CustomerName"].Value.ToString();
                string Result = connSalesOrder.sp_CustomerMapMarkByID(CustomerID);
                string Address = grid_Customer.Rows[i].Cells["Address"].Value.ToString();
                string State = grid_Customer.Rows[i].Cells["State"].Value.ToString();
                string City = grid_Customer.Rows[i].Cells["City"].Value.ToString();
                string Postal = grid_Customer.Rows[i].Cells["Postal"].Value.ToString();
                string Latitude = grid_Customer.Rows[i].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[i].Cells["Latitude"].Value.ToString();
                string Longitude = grid_Customer.Rows[i].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_Customer.Rows[i].Cells["Longitude"].Value.ToString();
                string CustomerState = grid_Customer.Rows[i].Cells["CustomerState"].Value.ToString();
                string Memo = grid_Customer.Rows[i].Cells["Memo"].Value.ToString();
                string PackMemo = grid_Customer.Rows[i].Cells["PACK MEMO"].Value.ToString();
                string DelvMemo = grid_Customer.Rows[i].Cells["DELV MEMO"].Value.ToString();
                string TEL = grid_Customer.Rows[i].Cells["TEL"].Value.ToString();
                string WEB = grid_Customer.Rows[i].Cells["WEB"].Value.ToString();
                DateTime LastInvoiceDate = grid_Customer.Rows[i].Cells["LastInvoiceDate"].Value == DBNull.Value ? Convert.ToDateTime("1900-01-01") : Convert.ToDateTime(grid_Customer.Rows[i].Cells["LastInvoiceDate"].Value);

                if (Latitude.Equals(""))
                {
                    ErrorCustomer += CustomerID + ", ";
                }
                else
                {
                    gMapControl1.DragButton = MouseButtons.Left;
                    gMapControl1.CanDragMap = true;
                    gMapControl1.MapProvider = GMapProviders.GoogleMap;

                    gMapControl1.MinZoom = 0;
                    gMapControl1.MaxZoom = 24;
                    gMapControl1.Zoom = 15;
                    gMapControl1.AutoScroll = true;

                    markerOverlay = new GMapOverlay("Marker");
                    if (CustomerState.Equals("6MonthNoInvoice"))
                    {
                        MessageBox.Show("Time elapsed between now and the date of last invoice is longer than 6 months ago.");
                    }
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.yellow);
                }
                markerOverlay.Markers.Add(marker);

                GMapToolTip tooltip = new GMapToolTip(marker);

                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                tooltip.Font = new Font("Arial", 12, FontStyle.Bold);
                marker.ToolTip = tooltip;
                marker.ToolTipText = string.Format("SalesRep : {0}\nCompany : {1} \nAddress : {2}\nMemo : {3} \nTel : {4}   " +
                    "Web : {5}\nLast Invoice Date : {6}     InActive : {7}",
                    SalesRep, CustomerID, Result, Memo, TEL, WEB, LastInvoiceDate.ToString("MM/dd/yyyy"), CustomerState);
                marker.ToolTip.Stroke = new Pen(Color.Magenta, 2);
                marker.ToolTip.TextPadding = new Size(10, 5);
                gMapControl1.Overlays.Add(markerOverlay);

            }
            if (!ErrorCustomer.Equals("")) MessageBox.Show("Done!\nError : " + ErrorCustomer.ToString() + "\nReason : Address Maping Error", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void grid_SalesRep_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (grid_SalesRep.RowCount > 0)
                {
                    if (e.ColumnIndex == 0)
                    {
                        if (Convert.ToBoolean(grid_SalesRep.Rows[1].Cells[0].EditedFormattedValue) == false)
                        {
                            for (int i = 0; i < grid_SalesRep.RowCount; i++)
                                grid_SalesRep.Rows[i].Cells[0].Value = true;
                        }
                        else // uncheck 했을 때
                        {
                            for (int i = 0; i < grid_SalesRep.RowCount; i++)
                                grid_SalesRep.Rows[i].Cells[0].Value = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void grid_Customer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in this.grid_Customer.Rows)
                {
                    if (row.Cells["CustomerState"].Value.Equals("InActive"))
                    {
                        for (int i = 0; i < grid_Customer.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Red;
                        }
                    }
                    else if (row.Cells["CustomerState"].Value.Equals("6MonthNoInvoice"))
                    {
                        for (int i = 0; i < grid_Customer.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Gray;
                        }
                    }
                }
            }
            catch { }
        }

        private void btn_BcsLogo_Click(object sender, EventArgs e)
        {
            double ZoomIndex = Convert.ToDouble(gMapControl1.Zoom.ToString());
            gMapControl1.Zoom = 15;
            gMapControl1.Position = new PointLatLng(BCSlatitude, BCSlongitude);

        }
        private string SetUpColor(int ArrayPosition)
        {
            String result = "000000";
            switch (ArrayPosition % 20)
            {
                case 0:
                    result = "4400ff";
                    break;
                case 1:
                    result = "ffff2d";
                    break;
                case 2:
                    result = "d40492";//"3b3b3b";
                    break;
                case 3:
                    result = "ff8000";
                    break;
                case 4:
                    result = "ffffff";
                    break;
                case 5:
                    result = "6699ff";
                    break;
                case 6:
                    result = "91262d";
                    break;
                case 7:
                    result = "ffcc00";
                    break;
                case 8:
                    result = "da5eff";
                    break;
                case 9:
                    result = "a8a875";
                    break;
                case 10:
                    result = "000000";
                    break;
                case 11:
                    result = "ff0011";
                    break;
                case 12:
                    result = "000066";
                    break;
                case 13:
                    result = "666699";
                    break;
                case 14:
                    result = "99ffcc";
                    break;
                case 15:
                    result = "393939";
                    break;
                case 16:
                    result = "999999";
                    break;
                case 17:
                    result = "7f8a38";
                    break;
                case 18:
                    result = "8e383e";
                    break;
                case 19:
                    result = "ff0040";
                    break;

            }
            return result;
        }


    }

}
