using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBCS.Entities;

namespace OBCS.SystemMenu.UserMaintenance
{
    public partial class ChangePassword : Form
    {
        public ChangePassword(String UserID)
        {
            InitializeComponent();
            txt_userid.Text = UserID;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String UserID = txt_userid.Text;
            String pw = txt_password.Text.Trim();
            String cpw = txt_comfirmPassword.Text.Trim();

            if (pw != cpw)
            {
                MessageBox.Show("not matching password and confirm password.");
                return;
            }
            else
            {
                UserObject userObject = new UserObject();
                userObject.UserID = UserID;
                userObject.Password = MD5(pw);
                connSalesOrder.sp_UPDATE_UserPass(userObject);
                Close();
            }
                
            
            //else
            //save pw
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        public string MD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("X2"));
            }
            return str.ToString();
        }
    }
}
