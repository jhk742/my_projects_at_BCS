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
    public partial class CreditMemoRequest : Form
    {
        public CreditMemoRequest()
        {
            InitializeComponent();
            grid_creditMemo_Init();
            grid_requested_Init();

            cbo_companyID.Items.Clear();
            connPO.cbo_getCompanyID(cbo_companyID);
            cbo_companyID.Text = cbo_companyID.Items[0].ToString();
            
            
            cbo_customerID.Items.Clear();
            connPO.cbox_getCustomerID(cbo_customerID);
            cbo_CMSearch.Items.Clear();
            connPO.cbox_getCustomerID(cbo_CMSearch);
            cbo_requestedCMSearch.Items.Clear();
            connPO.cbox_getCustomerID(cbo_requestedCMSearch);

            cbo_CMReason.Items.Add("SRCM");
            cbo_CMReason.Items.Add("DCM");
            cbo_CMReason.Items.Add("NCS");
            cbo_CMReason.Items.Add("PFCM");
            cbo_CMReason.Items.Add("CRCM");
            cbo_CMReason.Items.Add("DAD");
            cbo_CMReason.Items.Add("AC");
            cbo_CMReason.Items.Add("LD");
            cbo_CMReason.Items.Add("NO");
            cbo_CMReason.Items.Add("IP");
            cbo_CMReason.Items.Add("QE");
            cbo_CMReason.Items.Add("DIS");
            cbo_CMReason.Items.Add("MISC");
            cbo_CMReason.Items.Add("SD");





            //connSalesOrder.sp_PAYMENT_CREDIT(grid_creditMemo, "");
            connSalesOrder.sp_PAYMENT_CREDIT_PENDING(grid_requested, "");
        }

        private void grid_creditMemo_Init()
        {
            grid_creditMemo.AutoGenerateColumns = false;
            grid_creditMemo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_creditMemo.ColumnCount = 8;

            grid_creditMemo.Columns[0].Name = "Company ID";
            grid_creditMemo.Columns[0].ReadOnly = true;
            grid_creditMemo.Columns[0].Width = 40;
            grid_creditMemo.Columns[0].MinimumWidth = 40;
            grid_creditMemo.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_creditMemo.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_creditMemo.Columns[0].DataPropertyName = "CompanyID";

            grid_creditMemo.Columns[1].Name = "Company Name";
            grid_creditMemo.Columns[1].ReadOnly = true;
            grid_creditMemo.Columns[1].Width = 110;
            grid_creditMemo.Columns[1].MinimumWidth = 110;
            grid_creditMemo.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_creditMemo.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_creditMemo.Columns[1].DataPropertyName = "CompanyName";

            grid_creditMemo.Columns[2].Name = "Date";
            grid_creditMemo.Columns[2].ReadOnly = true;
            grid_creditMemo.Columns[2].Width = 75;
            grid_creditMemo.Columns[2].MinimumWidth = 75;
            grid_creditMemo.Columns[2].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_creditMemo.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_creditMemo.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_creditMemo.Columns[2].DataPropertyName = "ACCDAT_0";

            grid_creditMemo.Columns[3].Name = "Customer ID";
            grid_creditMemo.Columns[3].ReadOnly = true;
            grid_creditMemo.Columns[3].Width = 90;
            grid_creditMemo.Columns[3].MinimumWidth = 90;
            grid_creditMemo.Columns[3].DataPropertyName = "BPR_0";

            grid_creditMemo.Columns[4].Name = "Customer Name";
            grid_creditMemo.Columns[4].ReadOnly = true;
            grid_creditMemo.Columns[4].Width = 110;
            grid_creditMemo.Columns[4].MinimumWidth = 110;
            grid_creditMemo.Columns[4].DataPropertyName = "CustomerName";
            
            grid_creditMemo.Columns[5].Name = "Credit Number";
            grid_creditMemo.Columns[5].ReadOnly = true;
            grid_creditMemo.Columns[5].Width = 60;
            grid_creditMemo.Columns[5].MinimumWidth = 60;
            grid_creditMemo.Columns[5].DefaultCellStyle.Format = "N2";
            grid_creditMemo.Columns[5].DataPropertyName = "NUM_0";

            grid_creditMemo.Columns[6].Name = "Credit Amount";
            grid_creditMemo.Columns[6].ReadOnly = true;
            grid_creditMemo.Columns[6].Width = 60;
            grid_creditMemo.Columns[6].MinimumWidth = 60;
            grid_creditMemo.Columns[6].DefaultCellStyle.Format = "N2";
            grid_creditMemo.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_creditMemo.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_creditMemo.Columns[6].DataPropertyName = "CreditAmount";

            grid_creditMemo.Columns[7].Name = "CM reason";
            grid_creditMemo.Columns[7].ReadOnly = true;
            grid_creditMemo.Columns[7].Width = 90;
            grid_creditMemo.Columns[7].MinimumWidth = 90;
            grid_creditMemo.Columns[7].DataPropertyName = "DES_0";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 50;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_requested.Columns["Delete"] == null)
            {
                grid_creditMemo.Columns.Insert(8, deleteButton);
            }

            //grid font size custom
            grid_creditMemo.RowTemplate.Height = 20;
            grid_creditMemo.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_creditMemo.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_creditMemo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_requested_Init()
        {
            grid_requested.AutoGenerateColumns = false;
            grid_requested.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_requested.ColumnCount = 8;

            grid_requested.Columns[0].Name = "Company ID";
            grid_requested.Columns[0].ReadOnly = true;
            grid_requested.Columns[0].Width = 40;
            grid_requested.Columns[0].MinimumWidth = 40;
            grid_requested.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_requested.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_requested.Columns[0].DataPropertyName = "CompanyID";

            grid_requested.Columns[1].Name = "Company Name";
            grid_requested.Columns[1].ReadOnly = true;
            grid_requested.Columns[1].Width = 110;
            grid_requested.Columns[1].MinimumWidth = 110;
            grid_requested.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_requested.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_requested.Columns[1].DataPropertyName = "CompanyName";

            grid_requested.Columns[2].Name = "Date";
            grid_requested.Columns[2].ReadOnly = true;
            grid_requested.Columns[2].Width = 75;
            grid_requested.Columns[2].MinimumWidth = 75;
            grid_requested.Columns[2].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_requested.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_requested.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_requested.Columns[2].DataPropertyName = "ACCDAT_0";

            grid_requested.Columns[3].Name = "Customer ID";
            grid_requested.Columns[3].ReadOnly = true;
            grid_requested.Columns[3].Width = 70;
            grid_requested.Columns[3].MinimumWidth = 70;
            grid_requested.Columns[3].DataPropertyName = "BPR_0";

            grid_requested.Columns[4].Name = "Customer Name";
            grid_requested.Columns[4].ReadOnly = true;
            grid_requested.Columns[4].Width = 110;
            grid_requested.Columns[4].MinimumWidth = 110;
            grid_requested.Columns[4].DataPropertyName = "CustomerName";

            grid_requested.Columns[5].Name = "Credit Number";
            grid_requested.Columns[5].ReadOnly = true;
            grid_requested.Columns[5].Width = 90;
            grid_requested.Columns[5].MinimumWidth = 90;
            grid_requested.Columns[5].DefaultCellStyle.Format = "N2";
            grid_requested.Columns[5].DataPropertyName = "NUM_0";

            grid_requested.Columns[6].Name = "Credit Amount";
            grid_requested.Columns[6].ReadOnly = true;
            grid_requested.Columns[6].Width = 60;
            grid_requested.Columns[6].MinimumWidth = 60;
            grid_requested.Columns[6].DefaultCellStyle.Format = "N2";
            grid_requested.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_requested.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_requested.Columns[6].DataPropertyName = "CreditAmount";

            grid_requested.Columns[7].Name = "CM reason";
            grid_requested.Columns[7].ReadOnly = true;
            grid_requested.Columns[7].Width = 90;
            grid_requested.Columns[7].MinimumWidth = 90;
            grid_requested.Columns[7].DataPropertyName = "CMReason";

            DataGridViewButtonColumn confirmButton = new DataGridViewButtonColumn();
            confirmButton.Width = 60;
            confirmButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            confirmButton.Name = "Confirm";
            confirmButton.Text = "Confirm";
            confirmButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            confirmButton.UseColumnTextForButtonValue = true;
            if (grid_requested.Columns["Confirm"] == null)
            {
                grid_requested.Columns.Insert(8, confirmButton);
            }

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 50;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_requested.Columns["Delete"] == null)
            {
                grid_requested.Columns.Insert(9, deleteButton);
            }

            //grid font size custom
            grid_requested.RowTemplate.Height = 20;
            grid_requested.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_requested.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_requested.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void cbo_companyID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_companyName.Text = connPO.getCompanyNamebyCompanyID(cbo_companyID.Text.Trim());
        }

        private void cbo_customerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_customerName.Text = connPO.getCustomerNamebyCustomerID(cbo_customerID.Text.Trim());

            cbo_deliveryNumber.Items.Clear();
            connPO.cbox_getAllDeliveryNumberByCustomerID(cbo_customerID, cbo_deliveryNumber);
            if (cbo_deliveryNumber.Items.Count == 0)
                return;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                String CompanyID = cbo_companyID.Text.Trim();
                String CustomerID = cbo_customerID.Text.Trim();
                String CMReason = cbo_CMReason.Text.Trim();
                String CreditMemo = txt_CMReasonMemo.Text.Trim();
                Decimal CreditAmount = Convert.ToDecimal(txt_CMAmount.Text.Trim());
                String DeliveryNumber = cbo_deliveryNumber.Text.Trim();

                if (CompanyID == "" || CustomerID == "" || CMReason == "" || CreditAmount <= 0 || txt_CMAmount.Text.Trim() == "")
                {
                    MessageBox.Show("Input valid value.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure add a new credit memo?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    connSalesOrder.sp_PAYMENT_ADD_3CREDIT(CompanyID, CustomerID, CMReason, CreditMemo, CreditAmount, DeliveryNumber);
                    connSalesOrder.sp_PAYMENT_CREDIT_PENDING(grid_requested, "");
                }
            }
            catch
            {
                MessageBox.Show("Input valid value.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
           
            
        }

        private void btn_CMSearch_Click(object sender, EventArgs e)
        {
            String CustomerID = cbo_CMSearch.Text.Trim();
            connSalesOrder.sp_PAYMENT_CREDIT(grid_creditMemo, CustomerID);
        }

        private void btn_requestedCMSearch_Click(object sender, EventArgs e)
        {
            String CustomerID = cbo_requestedCMSearch.Text.Trim();
            connSalesOrder.sp_PAYMENT_CREDIT_PENDING(grid_requested, CustomerID); 
        }

        private void grid_creditMemo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex >= 0) // Delete button
            {
                //MessageBox.Show(e.RowIndex.ToString().Trim());
                DialogResult dialogResult = MessageBox.Show("Are you sure deleting credit memo?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    String CreditNumber = grid_creditMemo.Rows[e.RowIndex].Cells["Credit Number"].Value.ToString().Trim();

                    connSalesOrder.sp_PAYMENTT_DELETE_CREDIT(CreditNumber);
                    //grid_creditMemo.Rows.RemoveAt(e.RowIndex);

                    String CustomerID = cbo_CMSearch.Text.Trim();
                    connSalesOrder.sp_PAYMENT_CREDIT(grid_creditMemo, CustomerID);
                }
                else if (dialogResult == DialogResult.No)
                {

                }


            }
        }

        private void grid_requested_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex >= 0) // confirm button
            {
                if (connSalesOrder.sp_CreditRequest_Confirm_UserCheck() == "1")
                {
                    //MessageBox.Show(e.RowIndex.ToString().Trim());
                    DialogResult dialogResult = MessageBox.Show("Are you sure confirm this credit memo?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        String CreditNumber = grid_requested.Rows[e.RowIndex].Cells["Credit Number"].Value.ToString().Trim();

                        connSalesOrder.sp_PAYMENTT_CONFIRM_CREDIT(CreditNumber);
                        //grid_creditMemo.Rows.RemoveAt(e.RowIndex);

                        String CustomerID = cbo_requestedCMSearch.Text.Trim();
                        connSalesOrder.sp_PAYMENT_CREDIT_PENDING(grid_requested, CustomerID);
                        connSalesOrder.sp_PAYMENT_CREDIT(grid_creditMemo, cbo_CMSearch.Text.Trim());

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("You do not have permissions to access.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            

            if (e.ColumnIndex == 9 && e.RowIndex >= 0) // Delete button
            {
                //MessageBox.Show(e.RowIndex.ToString().Trim());
                DialogResult dialogResult = MessageBox.Show("Are you sure deleting credit memo request?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    String CreditNumber = grid_requested.Rows[e.RowIndex].Cells["Credit Number"].Value.ToString().Trim();

                    connSalesOrder.sp_PAYMENTT_DELETE_CREDIT(CreditNumber);
                    //grid_creditMemo.Rows.RemoveAt(e.RowIndex);

                    String CustomerID = cbo_requestedCMSearch.Text.Trim();
                    connSalesOrder.sp_PAYMENT_CREDIT_PENDING(grid_requested, CustomerID);
                    connSalesOrder.sp_PAYMENT_CREDIT(grid_creditMemo, cbo_CMSearch.Text.Trim());
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void cbo_CMReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo_CMReason.Text.Trim())
            {
                case "SRCM":
                    txt_CMReason.Text = "Sales rep credit memo";
                    break;
                case "DCM":
                    txt_CMReason.Text = "Direct credit memo";
                    break;
                case "NCS":
                    txt_CMReason.Text = "Not Compliant with shipment";
                    break;
                case "PFCM":
                    txt_CMReason.Text = "PF Cedit memo";
                    break;
                case "CRCM":
                    txt_CMReason.Text = "Cheese return Credit memo";
                    break;
                case "DAD":
                    txt_CMReason.Text = "Damaged";
                    break;
                case "AC":
                    txt_CMReason.Text = "Account Changed";
                    break;
                case "LD":
                    txt_CMReason.Text = "Late delivery";
                    break;
                case "NO":
                    txt_CMReason.Text = "Not ordered";
                    break;
                case "IP":
                    txt_CMReason.Text = "Incorrect price";
                    break;
                case "QE":
                    txt_CMReason.Text = "Quantity error";
                    break;
                case "DIS":
                    txt_CMReason.Text = "Discount";
                    break;
                case "MISC":
                    txt_CMReason.Text = "Miscellaneous";
                    break;
                case "SD":
                    txt_CMReason.Text = "Short Dated";
                    break;
                default:
                    txt_CMReason.Text = "";
                    break;
            }
        }
    }
}
