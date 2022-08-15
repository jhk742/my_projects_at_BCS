using OBCS.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Sales
{
    public partial class CashCheckCollection : Form
    {
        public CashCheckCollection(String OrderID)
        {
            InitializeComponent();

            txt_orderID.Text = OrderID;

            //select
            Collection collection = new Collection();
            collection = connSalesOrder.sp_Fetch_Order2CollectionInfo(OrderID);

            txt_cash.Text = collection.Cash.ToString();
            if (collection.CheckDate1 == Convert.ToDateTime("01/01/1900"))
            {
                txt_date1.Text = "";
            }
            else
            {
                txt_date1.Text = collection.CheckDate1.ToString("MM/dd/yyyy");
            }
            
            txt_check1.Text = collection.CheckNo1.ToString();
            txt_amount1.Text = collection.CheckAmount1.ToString();
            if (collection.CheckDate2 == Convert.ToDateTime("01/01/1900"))
            {
                txt_date2.Text = "";
            }
            else
            {
                txt_date2.Text = collection.CheckDate1.ToString("MM/dd/yyyy");
            }
            txt_check2.Text = collection.CheckNo2.ToString();
            txt_amount2.Text = collection.CheckAmount2.ToString();
            if (collection.CheckDate3 == Convert.ToDateTime("01/01/1900"))
            {
                txt_date3.Text = "";
            }
            else
            {
                txt_date3.Text = collection.CheckDate1.ToString("MM/dd/yyyy");
            }
            txt_check3.Text = collection.CheckNo3.ToString();
            txt_amount3.Text = collection.CheckAmount3.ToString();
            if (collection.CheckDate4 == Convert.ToDateTime("01/01/1900"))
            {
                txt_date4.Text = "";
            }
            else
            {
                txt_date4.Text = collection.CheckDate1.ToString("MM/dd/yyyy");
            }
            txt_check4.Text = collection.CheckNo4.ToString();
            txt_amount4.Text = collection.CheckAmount4.ToString();
            if (collection.CheckDate5 == Convert.ToDateTime("01/01/1900"))
            {
                txt_date5.Text = "";
            }
            else
            {
                txt_date5.Text = collection.CheckDate1.ToString("MM/dd/yyyy");
            }
            txt_check5.Text = collection.CheckNo5.ToString();
            txt_amount5.Text = collection.CheckAmount5.ToString();

            

        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            Collection collection = new Collection();
            collection.OrderID = txt_orderID.Text;
            collection.Cash = Convert.ToDecimal(txt_cash.Text);

            if (txt_date1.Text == "  /  /")
            {
                collection.CheckDate1 = Convert.ToDateTime("1900-01-01");
            }
            else
            {
                collection.CheckDate1 = Convert.ToDateTime(txt_date1.Text);
            }
            collection.CheckNo1 = txt_check1.Text.Trim();
            collection.CheckAmount1 = Convert.ToDecimal(txt_amount1.Text);
            if(txt_date2.Text == "  /  /")
            {
                collection.CheckDate2 = Convert.ToDateTime("1900-01-01");
            }
            else
            {
                collection.CheckDate2 = Convert.ToDateTime(txt_date2.Text);
            }
            
            collection.CheckNo2 = txt_check2.Text.Trim();
            collection.CheckAmount2 = Convert.ToDecimal(txt_amount2.Text);
            if (txt_date3.Text == "  /  /")
            {
                collection.CheckDate3 = Convert.ToDateTime("1900-01-01");
            }
            else
            {
                collection.CheckDate3 = Convert.ToDateTime(txt_date3.Text);
            }
            collection.CheckNo3 = txt_check3.Text.Trim();
            collection.CheckAmount3 = Convert.ToDecimal(txt_amount3.Text);
            if (txt_date4.Text == "  /  /")
            {
                collection.CheckDate4 = Convert.ToDateTime("1900-01-01");
            }
            else
            {
                collection.CheckDate4 = Convert.ToDateTime(txt_date4.Text);
            }
            collection.CheckNo4 = txt_check4.Text.Trim();
            collection.CheckAmount4 = Convert.ToDecimal(txt_amount4.Text);
            if (txt_date5.Text == "  /  /")
            {
                collection.CheckDate5 = Convert.ToDateTime("1900-01-01");
            }
            else
            {
                collection.CheckDate5 = Convert.ToDateTime(txt_date5.Text);
            }
            collection.CheckNo5 = txt_check5.Text.Trim();
            collection.CheckAmount5 = Convert.ToDecimal(txt_amount5.Text);

            //EDDIE
            //turned off auto register check, cash info into deliveryCollection table(on procedure, sp_UPDATE_Order2CollectInfo) -- 11/10/2018 Eddie
            //turned on auto register check cash info into deliveryCollection table(on procedure, sp_UPDATE_Order2CollectInfo) -- 11/28/2018 Eddie
            connSalesOrder.sp_UPDATE_Order2CollectInfo(collection);

            Close();
        }

        private void txt_cash_Leave(object sender, EventArgs e)
        {
            if(txt_cash.Text.Trim() == "")
            {
                txt_cash.Text = "0";
            }
        }


        //Double value;
        //    if (Double.TryParse(txt_amount1.Text, out value))
        //        txt_amount1.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
        //    else
        //        txt_amount1.Text = "$0.00";

        //txt_amount1.SelectAll();


    }
}
