using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using OBCS.Entities;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Lists
{
    public partial class PaymentTermList : Form
    {
        public PaymentTermList()
        {
            InitializeComponent();
            grid_PaymentTerm_Init();
            cbo_Status.Items.Clear();
            cbo_Status.Items.Add("");
            cbo_Status.Items.Add("Active");
            cbo_Status.Items.Add("Inactive");
            
            connPO.sp_LIST_PaymentTerm(grid_PaymentTerm, " ", " ", "Active");

            btn_newSave.BringToFront();
        }
        private void grid_PaymentTerm_Init()
        {
            grid_PaymentTerm.AutoGenerateColumns = false;
            grid_PaymentTerm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_PaymentTerm.ColumnCount = 8;

            grid_PaymentTerm.Columns[0].Name = "Payment Term";
            grid_PaymentTerm.Columns[0].ReadOnly = true;
            grid_PaymentTerm.Columns[0].Width = 70;
            grid_PaymentTerm.Columns[0].MinimumWidth = 20;
            grid_PaymentTerm.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PaymentTerm.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PaymentTerm.Columns[0].DataPropertyName = "NUM_0";

            grid_PaymentTerm.Columns[1].Name = "Description";
            grid_PaymentTerm.Columns[1].ReadOnly = true;
            grid_PaymentTerm.Columns[1].Width = 300;
            grid_PaymentTerm.Columns[1].MinimumWidth = 100;
            grid_PaymentTerm.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid_PaymentTerm.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PaymentTerm.Columns[1].DataPropertyName = "Description";

            grid_PaymentTerm.Columns[2].Name = "Discount percentage";
            grid_PaymentTerm.Columns[2].ReadOnly = true;
            grid_PaymentTerm.Columns[2].Width = 55;
            grid_PaymentTerm.Columns[2].MinimumWidth = 20;
            grid_PaymentTerm.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PaymentTerm.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PaymentTerm.Columns[2].DefaultCellStyle.Format = "N2";
            grid_PaymentTerm.Columns[2].DataPropertyName = "DCPercentage";

            grid_PaymentTerm.Columns[3].Name = "Discount Days";
            grid_PaymentTerm.Columns[3].ReadOnly = true;
            grid_PaymentTerm.Columns[3].Width = 55;
            grid_PaymentTerm.Columns[3].MinimumWidth = 20;
            grid_PaymentTerm.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PaymentTerm.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PaymentTerm.Columns[3].DefaultCellStyle.Format = "#,###";
            grid_PaymentTerm.Columns[3].DataPropertyName = "DCDays";

            grid_PaymentTerm.Columns[4].Name = "Net Days To Pay";
            grid_PaymentTerm.Columns[4].ReadOnly = true;
            grid_PaymentTerm.Columns[4].Width = 55;
            grid_PaymentTerm.Columns[4].MinimumWidth = 20;
            grid_PaymentTerm.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PaymentTerm.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PaymentTerm.Columns[4].DefaultCellStyle.Format = "#,###";
            grid_PaymentTerm.Columns[4].DataPropertyName = "NetDaysToPay";

            grid_PaymentTerm.Columns[5].Name = "Status";
            grid_PaymentTerm.Columns[5].ReadOnly = true;
            grid_PaymentTerm.Columns[5].Width = 40;
            grid_PaymentTerm.Columns[5].MinimumWidth = 20;
            grid_PaymentTerm.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PaymentTerm.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PaymentTerm.Columns[5].DataPropertyName = "Status";

            grid_PaymentTerm.Columns[6].Name = "Update User";
            grid_PaymentTerm.Columns[6].ReadOnly = true;
            grid_PaymentTerm.Columns[6].Width = 50;
            grid_PaymentTerm.Columns[6].MinimumWidth = 20;
            grid_PaymentTerm.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PaymentTerm.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PaymentTerm.Columns[6].DataPropertyName = "UpdateUser";

            grid_PaymentTerm.Columns[7].Name = "Update Time";
            grid_PaymentTerm.Columns[7].ReadOnly = true;
            grid_PaymentTerm.Columns[7].Width = 120;
            grid_PaymentTerm.Columns[7].MinimumWidth = 50;
            grid_PaymentTerm.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PaymentTerm.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_PaymentTerm.Columns[7].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_PaymentTerm.Columns[7].DataPropertyName = "UpdateTime";

            //grid font size custom
            grid_PaymentTerm.RowTemplate.Height = 20;
            grid_PaymentTerm.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_PaymentTerm.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_PaymentTerm.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void searchPaymentTerm()
        {
            Initialized();
            String PaymentTerm = txt_searchPMCode.Text.Trim();
            String Description = txt_SearchPMDescription.Text.Trim();
            String Status = "";
            if (cbx_inactive.Checked)
            {
                Status = "";
            }
            else
            {
                Status = "Active";
            }
            connPO.sp_LIST_PaymentTerm(grid_PaymentTerm, PaymentTerm, Description, Status);
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchPaymentTerm();
            }
        }

        private void cbx_inactive_CheckedChanged(object sender, EventArgs e)
        {
            searchPaymentTerm();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_PaymentTerm.Text = "";
            txt_Description.Text = "";
            txt_DCPercentage.Text = "";
            txt_DCDays.Text = "";
            txt_NetDaysToPay.Text = "";
            cbo_Status.Text = "Active";

            txt_PaymentTerm.Enabled = true;
            btn_save.Enabled = false;
            btn_newSave.Visible = true;

            btn_new.Enabled = false;
        }

        private void grid_PaymentTerm_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //PaymentTermObject paymentTermObject = new PaymentTermObject();

                //String PaymentTerm = grid_PaymentTerm.Rows[e.RowIndex].Cells["Payment Term"].Value.ToString().Trim();
                //paymentTermObject = connSalesOrder.sp_GET_PaymentTermObject(PaymentTerm);

                //txt_PaymentTerm.Text = paymentTermObject.PaymentTerm;
                //txt_Description.Text = paymentTermObject.Description;
                //txt_DCPercentage.Text = paymentTermObject.DCPercentage.ToString();
                //txt_DCDays.Text = paymentTermObject.DCDays.ToString();
                //txt_NetDaysToPay.Text = paymentTermObject.NetDaysToPay.ToString();
                //cbo_Status.Text = paymentTermObject.Status;

                String PaymentTerm = grid_PaymentTerm.Rows[e.RowIndex].Cells["Payment Term"].Value.ToString().Trim();
                String Description = grid_PaymentTerm.Rows[e.RowIndex].Cells["Description"].Value.ToString().Trim();
                decimal DCPercentage = Convert.ToDecimal(grid_PaymentTerm.Rows[e.RowIndex].Cells["Discount percentage"].Value);
                decimal DCDays = Convert.ToDecimal(grid_PaymentTerm.Rows[e.RowIndex].Cells["Discount Days"].Value);
                decimal NetDaysToPay = Convert.ToDecimal(grid_PaymentTerm.Rows[e.RowIndex].Cells["Net Days to Pay"].Value);
                String Status = grid_PaymentTerm.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                txt_PaymentTerm.Text = PaymentTerm;
                txt_Description.Text = Description;
                txt_DCPercentage.Text = DCPercentage.ToString("N2");
                txt_DCDays.Text = (Convert.ToInt32(DCDays)).ToString();
                txt_NetDaysToPay.Text = (Convert.ToInt32(NetDaysToPay)).ToString();
                cbo_Status.Text = Status;

                btn_save.Enabled = true;
                btn_newSave.Visible = false;
                btn_new.Enabled = true;
                txt_PaymentTerm.Enabled = false;
            }
            catch
            {
            }
            
        }

        private void btn_newSave_Click(object sender, EventArgs e)
        {
            if (txt_PaymentTerm.Text.Trim() == "")
            {
                MessageBox.Show("Please insert Payment Term name."
                                                           , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txt_DCPercentage.Text.Trim() == "" || txt_DCDays.Text.Trim() == "" || txt_NetDaysToPay.Text.Trim() == "" || cbo_Status.Text.Trim() == "")
            {
                MessageBox.Show("Please insert all values."
                                                           , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (connSalesOrder.sp_CHECK_NewPaymentTerm(txt_PaymentTerm.Text.Trim()) == true)
            {
                MessageBox.Show("Payment Term name already exist."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Save a new Payment Term?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    PaymentTermObject paymentTermObject = new PaymentTermObject();

                    paymentTermObject.PaymentTerm = txt_PaymentTerm.Text.Trim();
                    paymentTermObject.Description = txt_Description.Text.Trim();
                    paymentTermObject.DCPercentage = Convert.ToDecimal(txt_DCPercentage.Text.Trim());
                    paymentTermObject.DCDays = Convert.ToDecimal(txt_DCDays.Text.Trim());
                    paymentTermObject.NetDaysToPay = Convert.ToDecimal(txt_NetDaysToPay.Text.Trim());
                    paymentTermObject.Status = cbo_Status.Text.Trim();

                    connSalesOrder.sp_INSERT_NewPaymentTerm(paymentTermObject);

                    MessageBox.Show("Payment Term, " + paymentTermObject.PaymentTerm + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Initialized();
                    searchPaymentTerm();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_DCPercentage.Text.Trim() == "" || txt_DCDays.Text.Trim() == "" || txt_NetDaysToPay.Text.Trim() == "" || cbo_Status.Text.Trim() == "")
            {
                MessageBox.Show("Please insert all values."
                                                           , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Confirming update Payment Term, " + txt_PaymentTerm.Text.Trim() + " information."
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    PaymentTermObject paymentTermObject = new PaymentTermObject();

                    paymentTermObject.PaymentTerm = txt_PaymentTerm.Text.Trim();
                    paymentTermObject.Description = txt_Description.Text.Trim();
                    paymentTermObject.DCPercentage = Convert.ToDecimal(txt_DCPercentage.Text.Trim());
                    paymentTermObject.DCDays = Convert.ToDecimal(txt_DCDays.Text.Trim());
                    paymentTermObject.NetDaysToPay = Convert.ToDecimal(txt_NetDaysToPay.Text.Trim());
                    paymentTermObject.Status = cbo_Status.Text.Trim();

                    connSalesOrder.sp_UPDATE_PaymentTermInfo(paymentTermObject);

                    MessageBox.Show("Payment Term, " + paymentTermObject.PaymentTerm + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Initialized();
                    searchPaymentTerm();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

            }
        }

        private void txt_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void Initialized()
        {
            txt_PaymentTerm.Text = "";
            txt_Description.Text = "";
            txt_DCPercentage.Text = "";
            txt_DCDays.Text = "";
            txt_NetDaysToPay.Text = "";
            cbo_Status.Text = "";
        }

        private void grid_PaymentTerm_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.grid_PaymentTerm.Rows)
            {
                if (row.Cells["Status"].Value.ToString().Equals("Inactive"))
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }
    }
}
