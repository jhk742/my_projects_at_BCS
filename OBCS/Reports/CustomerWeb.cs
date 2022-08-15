using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace OBCS.Reports
{
    public partial class CustomerWeb : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        public CustomerWeb(bool Menu, String Address, String City, String State, String Zipcode, String Latitude, String Longitude)
        {
            InitializeComponent();
            markerOverlay = new GMapOverlay("Marker");
            String URL = "", FullAddress = "";
            FullAddress = Address + "," + City + "," + State + "," + Zipcode + "/" + Latitude + "," + Longitude;
            if (FullAddress.Length == 5 || Menu)
            {
                URL = "http://maps.google.com/maps/place/47-15+33rd+street,+longisland,+NY+11101/40.741540,-73.932440";
                marker = new GMarkerGoogle(new PointLatLng(40.741540, -73.932440), GMarkerGoogleType.red_dot);
            }
            else
            {
                URL = "http://maps.google.com/maps/place/" + FullAddress;
                marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.red_dot);
            }

            //webBrowser1.Url = new Uri("https://www.google.com/maps/place/47-15+33rd+street,+longisland,+NY+11101/40.741540,-73.932440");
            //webBrowser1.Url = new Uri(URL);
            webBrowser1.Navigate(URL);
        }
    }
}
