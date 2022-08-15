using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Account
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
            cbo_accountType.Items.Clear();
            cbo_accountType.Items.Add("Bank");
            cbo_accountType.Items.Add("Accounts Receivable");
            cbo_accountType.Items.Add("Other Current Asset");
            cbo_accountType.Items.Add("Fixed Asset");
            cbo_accountType.Items.Add("Other Asset");
            cbo_accountType.Items.Add("Accounts Payable");
            cbo_accountType.Items.Add("Other Current Liability");
            cbo_accountType.Items.Add("Long Term Liability");
            cbo_accountType.Items.Add("Equity");
            cbo_accountType.Items.Add("Income");
            cbo_accountType.Items.Add("Cost of Goods Sold");
            cbo_accountType.Items.Add("Expense");
            cbo_accountType.Items.Add("Other Income");
            cbo_accountType.Items.Add("Other Expense");
            cbo_accountType.Items.Add("Clearing");

            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbx_subAccount_CheckedChanged(object sender, EventArgs e)
        {
            cbo_subAccount.Items.Clear();
            if (cbx_subAccount.Checked)
            {
                cbo_subAccount.Items.Clear();
                connSalesOrder.sp_ACCOUNT_GET_SUBACCOUNT(cbo_subAccount, cbo_accountType.Text.Trim());
            }
            else
            {
                cbo_subAccount.Text = "";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure add a term credit?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                

                string type = cbo_accountType.Text.Trim();
                string name = txt_name.Text.Trim();
                string subAccount = cbo_subAccount.Text.Trim();
                string description = txt_desc.Text.Trim();
                string accountNumber = txt_accountNumber.Text.Trim();
                string routingNumber = txt_routingNumber.Text.Trim();
                decimal openingBalance = 0;// Convert.ToDecimal(txt_openingBalance.Text.Trim());
                DateTime asOf = Convert.ToDateTime(dateTimePicker_asOf.Value.ToShortDateString());
                String Return = connSalesOrder.sp_ACCOUNT_INSERT_GACCOUNT(type, name, subAccount, description, accountNumber, routingNumber, openingBalance, asOf);

                if (Return != "OK")
                {
                    MessageBox.Show(Return, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                MessageBox.Show("New account has been saved.\n\nType: " + type + "\nAccount Number: " + accountNumber + "\nName: " + name , "Info" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();


            }
            else if (dialogResult == DialogResult.No)
            {

            }

           
        }

        private void cbo_accountType_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbx_subAccount.Checked)
            {
                cbo_subAccount.Text = "";
                cbo_subAccount.Items.Clear();
                connSalesOrder.sp_ACCOUNT_GET_SUBACCOUNT(cbo_subAccount, cbo_accountType.Text.Trim());
            }
            
        }
    }
}
