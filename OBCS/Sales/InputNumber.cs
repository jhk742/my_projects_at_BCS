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
    public partial class InputNumber : Form
    {
        public InputNumber(String Input)
        {
            InitializeComponent();
            
            txt_text.SelectAll();
            txt_text.Focus();

            this.Text = Input;
            lbl_text.Text = Input;
        }

        public static String input;
        private void customExtraLargeTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                input = txt_text.Text;
                Close();
            }
        }
    }
}
