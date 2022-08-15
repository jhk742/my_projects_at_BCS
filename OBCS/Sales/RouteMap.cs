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
    public partial class RouteMap : Form
    {
        private IMyInterface frm = null;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        int selection = 0;
        double BCSlatitude = 40.742164;
        double BCSlongitude = -73.931789;
        int Zoom = 12;

        public RouteMap(IMyInterface frm)
        {
            InitializeComponent();
            this.frm = frm;
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
            gMapControl1.Zoom = Zoom;
            gMapControl1.AutoScroll = true;
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
                gMapControl1.AutoScroll = true;

                markerOverlay = new GMapOverlay("Marker");
                gMapControl1.Overlays.Add(markerOverlay);
                marker = new GMarkerGoogle(new PointLatLng(BCSlatitude, BCSlongitude), GMarkerGoogleType.orange_dot);
                markerOverlay.Markers.Add(marker);

                GMapToolTip tooltip = new GMapToolTip(marker);

                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                //tooltip.Fill = new SolidBrush(Color.SkyBlue);
                tooltip.Font = new Font("Arial", 12, FontStyle.Bold);
                marker.ToolTip = tooltip;
                marker.ToolTip.Stroke = new Pen(Color.Magenta, 2);
                marker.ToolTipText = string.Format("\nBCS ROYAL \nAddress :47-15 33rd St, Long Island City, NY 11101");
                marker.ToolTip.TextPadding = new Size(10, 5);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void FocusTheMap(DataGridView grid_RouteDetail, int RowNumber)
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
        public void MarkTheMap(DataGridView grid_RouteDetail)
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

                for (int i = 0; i < grid_RouteDetail.RowCount; i++)
                {
                    //string No = grid_ORDERS.Rows[i].Cells["No"].Value.ToString();
                    string CustomerID = grid_RouteDetail.Rows[i].Cells["Customer"].Value.ToString();
                    string ZIP = grid_RouteDetail.Rows[i].Cells["ZIP"].Value.ToString();
                    string Address = grid_RouteDetail.Rows[i].Cells["Address"].Value.ToString();
                    string State = grid_RouteDetail.Rows[i].Cells["State"].Value.ToString();
                    string City = grid_RouteDetail.Rows[i].Cells["City"].Value.ToString();
                    string Rep = grid_RouteDetail.Rows[i].Cells["Rep."].Value.ToString();
                    DateTime OrderDate = grid_RouteDetail.Rows[i].Cells["Order Date"].Value == DBNull.Value ? Convert.ToDateTime("1900-01-01") : Convert.ToDateTime(grid_RouteDetail.Rows[i].Cells["Order Date"].Value);
                    string OrderNumber = grid_RouteDetail.Rows[i].Cells["Order No."].Value.ToString();
                    string Amount = grid_RouteDetail.Rows[i].Cells["Ord. Amount"].Value.ToString();
                    string Latitude = grid_RouteDetail.Rows[i].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_RouteDetail.Rows[i].Cells["Latitude"].Value.ToString();
                    string Longitude = grid_RouteDetail.Rows[i].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_RouteDetail.Rows[i].Cells["Longitude"].Value.ToString();
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
                BCS_Setting();

                if (grid_RouteDetail.RowCount != 0)
                {
                    string Latitude = grid_RouteDetail.Rows[0].Cells["Latitude"].Value.ToString().Length == 0 ? "" : grid_RouteDetail.Rows[0].Cells["Latitude"].Value.ToString();
                    string Longitude = grid_RouteDetail.Rows[0].Cells["Longitude"].Value.ToString().Length == 0 ? "" : grid_RouteDetail.Rows[0].Cells["Longitude"].Value.ToString();
                    gMapControl1.Position = new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude));
                }

                if (!ErrorCustomer.Equals("")) MessageBox.Show("Done!\nError : " + ErrorCustomer.ToString() + "\nReason : Address Maping Error", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Map Error. Ask to IT team.\n\n"+ex.ToString());
            }
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
    }
}
