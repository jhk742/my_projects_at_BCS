using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS
{
    public partial class PASS_ADD : Form
    {
        public PASS_ADD()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            newUserID = "";
            this.Close();
        }

        public static string newUserID = "";
        private void btn_ok_Click(object sender, EventArgs e)
        {

            if (conn.UserIdCheckup(txt_userid.Text.Trim()) == true)
            {
                String userID = txt_userid.Text.Trim();
                MessageBox.Show("'" + userID + "' already ");
            }
            else
            {
                newUserID = txt_userid.Text.Trim();
                conn.AddNewUser(txt_userid.Text.Trim());
                //Visible = false;
                Close();
            }
        }

        private void PASS_ADD_Leave(object sender, EventArgs e)
        {
            
        }

        private void txt_userid_TextChanged(object sender, EventArgs e)
        {
            txt_userid.Text = Regex.Replace(txt_userid.Text, @"\s", "");
        }
    }
}
