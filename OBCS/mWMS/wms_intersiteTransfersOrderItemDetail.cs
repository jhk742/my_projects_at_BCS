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

namespace OBCS.mWMS
{
    public partial class wms_intersiteTransfersOrderItemDetail : Form
    {
        String GlobalProductID;
        
        public wms_intersiteTransfersOrderItemDetail(String ProductID, String FromSite)
        {
            InitializeComponent();
            
            save = false;
            GlobalProductID = ProductID;

            txt_fromSite.Text = FromSite;

            cbo_status.Items.Add("A");
            cbo_status.Items.Add("Q");
            cbo_status.Items.Add("R");
            cbo_status.Text = "A";
            
        }

        public static string ProductID = "";
        public static string ProductDesc = "";
        public static string PackSize = "";
        public static string SalesUnit = "";
        
        public static decimal Qty = 0;
        public static decimal Price = 0;
        public static decimal Amount = 0;
        public static decimal Onhand = 0;
        public static decimal BCSStockQ = 0;
        public static decimal BCSStockR = 0;
        public static decimal WH2StockA = 0;
        public static decimal WH2StockQ = 0;
        public static decimal WH2StockR = 0;
        public static string Remark = "";
        public static string Return = "";
        public static decimal ListPrice = 0;
        public static decimal BottomPrice = 0;
        public static decimal BasePrice = 0;
        public static string Status = "";
        public static string Site = "";

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

            if(txt_fromSite.Text == "WH2")
            {
                if (cbo_status.Text == "A")
                {
                    if (Convert.ToDecimal(txt_WH2StockA.Text) < Convert.ToDecimal(txt_qty.Text))
                    {
                        MessageBox.Show("Wh2 Onhand."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                else if (cbo_status.Text == "Q")
                {
                    if (Convert.ToDecimal(txt_WH2StockQ.Text) < Convert.ToDecimal(txt_qty.Text))
                    {
                        MessageBox.Show("Wh2 Onhand."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                else if (cbo_status.Text == "R")
                {
                    if (Convert.ToDecimal(txt_WH2StockR.Text) < Convert.ToDecimal(txt_qty.Text))
                    {
                        MessageBox.Show("Wh2 Onhand."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }
            else if(txt_fromSite.Text == "BCS")
            {
                if (cbo_status.Text == "A")
                {
                    if (Convert.ToDecimal(txt_onhand.Text) < Convert.ToDecimal(txt_qty.Text))
                    {
                        MessageBox.Show("BCS Onhand."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                else if (cbo_status.Text == "Q")
                {
                    if (Convert.ToDecimal(txt_BCSStockQ.Text) < Convert.ToDecimal(txt_qty.Text))
                    {
                        MessageBox.Show("BCS Onhand."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                else if (cbo_status.Text == "R")
                {
                    if (Convert.ToDecimal(txt_BCSStockR.Text) < Convert.ToDecimal(txt_qty.Text))
                    {
                        MessageBox.Show("BCS Onhand."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }

            

            ProductID = txt_productID.Text.Trim();
            ProductDesc = txt_productDesc.Text.Trim();
            PackSize = txt_packSize.Text.Trim();
            SalesUnit = txt_salesUnit.Text.Trim();
            Qty = Convert.ToDecimal(txt_qty.Text.Trim());
            BasePrice = Convert.ToDecimal(txt_basePrice.Text.Trim());
            Onhand = Convert.ToDecimal(txt_onhand.Text.Trim());
            BCSStockQ = Convert.ToDecimal(txt_BCSStockQ.Text.Trim());
            BCSStockR = Convert.ToDecimal(txt_BCSStockR.Text.Trim());
            WH2StockA = Convert.ToDecimal(txt_WH2StockA.Text.Trim());
            WH2StockQ = Convert.ToDecimal(txt_WH2StockQ.Text.Trim());
            WH2StockR = Convert.ToDecimal(txt_WH2StockR.Text.Trim());
            Amount = BasePrice * Qty;
            Status = cbo_status.Text.Trim();
            Site = txt_fromSite.Text.Trim();

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
        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManualOrderItemDetail_Load(object sender, EventArgs e)
        {
            txt_productID.Text = GlobalProductID;

            ProductObject productObject = new ProductObject();

            productObject = connSalesOrder.sp_GET_ProductInfo(GlobalProductID);
            
            if(productObject.ProductID == null)
            {
                //MessageBox.Show("NULL");
                Close();
            }
            

            txt_productDesc.Text = productObject.ProductDesc;
            txt_packSize.Text = productObject.StrPackSize;
            txt_salesUnit.Text = productObject.SalesUnit;
            txt_onhand.Text = productObject.Onhand.ToString("N2");
            txt_BCSStockQ.Text = productObject.BCSStockQ.ToString("N2");
            txt_BCSStockR.Text = productObject.BCSStockR.ToString("N2");
            txt_WH2StockA.Text = productObject.WH2StockA.ToString("N2");
            txt_WH2StockQ.Text = productObject.WH2StockQ.ToString("N2");
            txt_WH2StockR.Text = productObject.WH2StockR.ToString("N2");
            txt_basePrice.Text = productObject.BasePrice.ToString("N2");

            productObject = connSalesOrder.sp_GET_WH2Stock(GlobalProductID);
            txt_WH2StockQ.Text = productObject.WH2Q.ToString("N2");
            txt_WH2StockR.Text = productObject.WH2R.ToString("N2");
            
        }
    }
}
