using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Purchase
{
    public partial class RECEIPTS_popup : Form
    {
        public RECEIPTS_popup(String ProductID)
        {
            InitializeComponent();

            lbl_text.Text = ProductID;
            txt_text.Text = "1";
        }

        public static String input;
        private void txt_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Convert.ToDecimal(txt_text.Text) <= 0)
                {
                    return;
                }
                else
                {
                    input = txt_text.Text;
                    Close();
                }
                    
            }
        }
    }
}
