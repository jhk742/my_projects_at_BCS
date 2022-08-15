using OBCS.Entities;
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
    public partial class SalesOrderDetailProduct : Form
    {
        String GlobalProductID, GlobalCustomerID;
        
        public SalesOrderDetailProduct(String ProductID, String CustomerID)
        {
            InitializeComponent();

            //ProductID = "";
            //ProductDesc = "";
            //PackSize = "";
            //Qty = 0;
            //Price = 0;
            //Onhand = 0;
            //Remark = "";
            //Return = "";
            //BottomPrice = 0;
            //BasePrice = 0;
            save = false;
            GlobalProductID = ProductID;
            GlobalCustomerID = CustomerID;
        }

        public static string ProductID = "";
        public static string ProductDesc = "";
        public static string PackSize = "";
        public static decimal Qty = 0;
        public static decimal Price = 0;
        public static decimal Amount = 0;
        public static decimal Onhand = 0;
        public static string Remark = "";
        public static string Return = "";
        public static decimal ListPrice = 0;
        public static decimal BottomPrice = 0;
        public static decimal BasePrice = 0;
        public static bool save = false;
        private void btn_save_Click(object sender, EventArgs e)
        {
            saveOrder();
        }

        private void saveOrder()
        {
            decimal value;
            if (!Decimal.TryParse(txt_qty.Text.Trim(), out value))
            {
                MessageBox.Show("Please input valid values"
                                                    , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (!Decimal.TryParse(txt_price.Text.Trim(), out value))
            {
                MessageBox.Show("Please input valid values"
                                                    , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            ProductID = txt_productID.Text.Trim();
            ProductDesc = txt_productDesc.Text.Trim();
            PackSize = txt_packSize.Text.Trim();
            Qty = Convert.ToDecimal(txt_qty.Text.Trim());
            Price = Convert.ToDecimal(txt_price.Text.Trim());
            if (rbtn_RR.Checked)
                Remark = "RR";
            else
                Remark = "PF";

            if (cbo_return.Checked)
                Return = "Y";
            else
                Return = "";

            if (Remark == "PF")
                Amount = 0;
            else
                Amount = Qty * Price;

            ListPrice = Convert.ToDecimal(txt_listPrice.Text.Trim());
            BottomPrice = Convert.ToDecimal(txt_bottomPrice.Text.Trim());
            BasePrice = Convert.ToDecimal(txt_basePrice.Text.Trim());
            Onhand = Convert.ToDecimal(txt_onhand.Text.Trim());

            save = true;
            Close();
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                saveOrder();
            }
            else if(e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Close();
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                saveOrder();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManualOrderItemDetail_Load(object sender, EventArgs e)
        {
            rbtn_RR.Checked = true;
            txt_productID.Text = GlobalProductID;
            txt_customerID.Text = GlobalCustomerID;

            ManualOrderProductObject manualOrderProductObject = new ManualOrderProductObject();

            manualOrderProductObject = connSalesOrder.sp_GET_ManualOrderProductInfo(GlobalProductID, GlobalCustomerID);
            if(manualOrderProductObject.ProductID == null)
            {
                //MessageBox.Show("NULL");
                Close();
            }
            txt_productDesc.Text = manualOrderProductObject.ProductDesc;
            txt_packSize.Text = manualOrderProductObject.PackSize;
            txt_onhand.Text = manualOrderProductObject.Onhand.ToString("N2");
            txt_listPrice.Text = manualOrderProductObject.ListPrice.ToString("N2");
            txt_lastPrice.Text = manualOrderProductObject.LastPrice.ToString("N2");
            txt_listPrice.Text = manualOrderProductObject.ListPrice.ToString("N2");
            txt_bottomPrice.Text = manualOrderProductObject.BottomPrice.ToString("N2");
            txt_basePrice.Text = manualOrderProductObject.BasePrice.ToString("N2");
            txt_price.Text = manualOrderProductObject.CustomPrice.ToString("N2");
        }
    }
}
