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
    public partial class DuplicateSalesOrder : Form
    {
        public DuplicateSalesOrder()
        {
            InitializeComponent();

            cbo_customerID.Items.Clear();
            connPO.cbox_getCustomerID(cbo_customerID);
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            cbo_deliveryNumber.Items.Clear();
            connPO.cbox_getDeliveryNumberByCustomerID(cbo_customerID, cbo_deliveryNumber);
            if (cbo_deliveryNumber.Items.Count == 0)
                return;
            //cbo_deliveryNumber.DroppedDown = true;
        }

        private void cbox_customerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbo_deliveryNumber.Items.Clear();
                connPO.cbox_getDeliveryNumberByCustomerID(cbo_customerID, cbo_deliveryNumber);
                if (cbo_deliveryNumber.Items.Count == 0)
                    return;
                //cbo_deliveryNumber.DroppedDown = true;
            }
        }

        private void btn_duplicate_Click(object sender, EventArgs e)
        {
            if(cbo_deliveryNumber.Text.Trim() == "")
            {
                MessageBox.Show("Select a delivery number.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure duplicate the sales order?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                String DeliveryNumber = cbo_deliveryNumber.Text.Trim();
                String Return = connSalesOrder.sp_DuplicateSalesOrder(DeliveryNumber);
                if (Return != "OK")
                    MessageBox.Show(Return, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else if(Return == "OK")
                    MessageBox.Show("The sales order has been duplicated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //cbo_customerID.Text = "";
                cbo_deliveryNumber.Text = "";
            }
        }

        private void cbo_customerID_SelectedValueChanged(object sender, EventArgs e)
        {
            cbo_deliveryNumber.Items.Clear();
            connPO.cbox_getDeliveryNumberByCustomerID(cbo_customerID, cbo_deliveryNumber);
            if (cbo_deliveryNumber.Items.Count == 0)
                return;
            //cbo_deliveryNumber.DroppedDown = true;
        }
    }
}
