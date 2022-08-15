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
    public partial class EditRouteInfo : Form
    {
        public EditRouteInfo(int RouteNumber, String Driver, String Truck)
        {
            InitializeComponent();

            connSalesOrder.cbo_Driver(cbo_drivers); //driver cbo loading
            connSalesOrder.cbo_Truck(cbo_trucks); //truck cbo loadking

            txt_routeNumber.Text = RouteNumber.ToString();
            cbo_drivers.Text = Driver;
            cbo_trucks.Text = Truck;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int RouteNumber = Convert.ToInt32(txt_routeNumber.Text);
            String DriverName = cbo_drivers.Text;
            String TruckPlate = cbo_trucks.Text;
            connSalesOrder.sp_UPDATE_RouteInfo(RouteNumber, DriverName, TruckPlate);

            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
