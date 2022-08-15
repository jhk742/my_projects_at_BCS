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
    public partial class CreditMemoRequest : Form
    {
        public CreditMemoRequest()
        {
            InitializeComponent();
            grid_credit_Init();

            cbo_companyID.Items.Clear();
            connPO.cbo_getCompanyID(cbo_companyID);
            cbo_companyID.Text = cbo_companyID.Items[0].ToString();

            cbo_supplierID.Items.Clear();
            connPO.cbox_getVendorID(cbo_supplierID);
            cbo_searchSupplierID.Items.Add("");
            connPO.cbox_getVendorID(cbo_searchSupplierID);

            cbo_cmReason.Items.Clear();
            connSalesOrder.cbo_STKReasonCode("APC", cbo_cmReason);
            cbo_cmReason.SelectedIndex = 0;
            //connPO.sp_PPAYMENT_CREDIT(grid_creditMemo, SupplierID);
        }

        private void grid_credit_Init()
        {
            grid_credit.AutoGenerateColumns = false;
            grid_credit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_credit.ColumnCount = 9;

            grid_credit.Columns[0].Name = "No.";
            grid_credit.Columns[0].ReadOnly = true;
            grid_credit.Columns[0].Width = 40;
            grid_credit.Columns[0].MinimumWidth = 40;
            grid_credit.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_credit.Columns[0].DataPropertyName = "";

            grid_credit.Columns[1].Name = "Supplier ID";
            grid_credit.Columns[1].ReadOnly = true;
            grid_credit.Columns[1].Width = 150;
            grid_credit.Columns[1].MinimumWidth = 150;
            grid_credit.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_credit.Columns[1].DataPropertyName = "SupplierID";

            grid_credit.Columns[2].Name = "Type";
            grid_credit.Columns[2].ReadOnly = true;
            grid_credit.Columns[2].Width = 60;
            grid_credit.Columns[2].MinimumWidth = 60;
            grid_credit.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_credit.Columns[2].DataPropertyName = "CreditDebit";

            grid_credit.Columns[3].Name = "Credit Number";
            grid_credit.Columns[3].ReadOnly = true;
            grid_credit.Columns[3].Width = 90;
            grid_credit.Columns[3].MinimumWidth = 90;
            grid_credit.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_credit.Columns[3].DataPropertyName = "Number";

            grid_credit.Columns[4].Name = "PO Number";
            grid_credit.Columns[4].ReadOnly = true;
            grid_credit.Columns[4].Width = 90;
            grid_credit.Columns[4].MinimumWidth = 90;
            grid_credit.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_credit.Columns[4].DataPropertyName = "InvoiceNumber";

            grid_credit.Columns[5].Name = "Amount";
            grid_credit.Columns[5].ReadOnly = true;
            grid_credit.Columns[5].Width = 65;
            grid_credit.Columns[5].MinimumWidth = 65;
            grid_credit.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_credit.Columns[5].DefaultCellStyle.Format = "N2";
            grid_credit.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_credit.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_credit.Columns[5].DataPropertyName = "Amount";

            grid_credit.Columns[6].Name = "Reason Code";
            grid_credit.Columns[6].ReadOnly = true;
            grid_credit.Columns[6].Width = 80;
            grid_credit.Columns[6].MinimumWidth = 80;
            grid_credit.Columns[6].DataPropertyName = "ReasonCode";

            grid_credit.Columns[7].Name = "Memo";
            grid_credit.Columns[7].ReadOnly = true;
            grid_credit.Columns[7].Width = 80;
            grid_credit.Columns[7].MinimumWidth = 80;
            grid_credit.Columns[7].DataPropertyName = "PMemo";

            grid_credit.Columns[8].Name = "Create Date";
            grid_credit.Columns[8].ReadOnly = true;
            grid_credit.Columns[8].Width = 80;
            grid_credit.Columns[8].MinimumWidth = 80;
            grid_credit.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_credit.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_credit.Columns[8].DataPropertyName = "CreateTime";

            DataGridViewButtonColumn deleteCreditButton = new DataGridViewButtonColumn();
            deleteCreditButton.Width = 50;
            deleteCreditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteCreditButton.Name = "Delete";
            deleteCreditButton.Text = "Delete";
            deleteCreditButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteCreditButton.UseColumnTextForButtonValue = true;
            if (grid_credit.Columns["Delete"] == null)
            {
                grid_credit.Columns.Insert(8, deleteCreditButton);
            }
            deleteCreditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            //grid font size custom
            grid_credit.RowTemplate.Height = 20;
            grid_credit.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_credit.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_credit.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void cbo_companyID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_companyName.Text = connPO.getCompanyNamebyCompanyID(cbo_companyID.Text.Trim());
        }

        private void cbo_supplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update --sp_GET_PONumberBySupplierID
            cbo_poNumber.Items.Clear();
            cbo_poNumber.Items.Add("");
            connPO.sp_GET_PONumberBySupplierID(cbo_poNumber, cbo_supplierID.Text.Trim());
        }

        private void cbo_cmReason_SelectedValueChanged(object sender, EventArgs e)
        {
            connSalesOrder.GETSTKReasonText("APC", cbo_cmReason.Text.ToString(), txt_cmReasonDesc);
        }

        private void btn_request_Click(object sender, EventArgs e)
        {
            //add credit sp_PPAYMENT_ADDCREDIT 
            DialogResult dialogResult = MessageBox.Show("Are you sure request a credit memo?", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                String SupplierID = cbo_supplierID.Text.Trim();
                String PONumber = cbo_poNumber.Text.Trim();
                Decimal Amount = Convert.ToDecimal(txt_amount.Text.Trim());
                String ReasonCode = cbo_cmReason.Text.Trim();
                String Memo = txt_memo.Text.Trim();

                connPO.sp_PPAYMENT_ADDCREDIT(SupplierID, PONumber, Amount, ReasonCode, Memo);

                cbo_searchSupplierID.Text = SupplierID;
                String SearchSupplierID = cbo_searchSupplierID.Text.Trim();
                connPO.sp_PPAYMENT_CREDIT(grid_credit, SearchSupplierID);

                txt_poNumber.Text = "";
                cbo_supplierID.Text = "";
                cbo_poNumber.Text = "";
                txt_amount.Text = "";
                txt_memo.Text = "";
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String SearchSupplierID = cbo_searchSupplierID.Text.Trim();

            connPO.sp_PPAYMENT_CREDIT_ALL(grid_credit, SearchSupplierID);
        }

        private void grid_credit_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.grid_credit.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void grid_credit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8) // Delete button
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure delete this Credit?"
                                                        , "Confirming", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //DataTable dt = this.grid_tempPayment.DataSource as DataTable;
                    //DataRow dr = dt.NewRow();
                    //dt.Rows.RemoveAt(e.RowIndex);
                    String SupplierID = cbo_searchSupplierID.Text.Trim();
                    String CreditNumber = grid_credit.Rows[e.RowIndex].Cells["Credit Number"].Value.ToString().Trim();

                    //크래딧을 삭제하기 전에 사용한 크래딧인지 아닌지 확인
                    //form의 amount 와 서버의 amount 비교하여 다르면 return
                    //get amount from server
                    Decimal CreditAmountfromServer = connSalesOrder.sp_CHECK_CreditDebitAmount_AP(CreditNumber);
                    Decimal CreditAmount = Convert.ToDecimal(grid_credit.Rows[e.RowIndex].Cells["Amount"].Value.ToString().Trim());
                    if(CreditAmount != CreditAmountfromServer)
                    {
                        MessageBox.Show("The amount has been updated. Refreshing...", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //refresh credit list
                        String SearchSupplierID = cbo_searchSupplierID.Text.Trim();
                        connPO.sp_PPAYMENT_CREDIT_ALL(grid_credit, SearchSupplierID);
                        return;
                    }

                    //delete
                    connPO.sp_PPAYMENT_DELETECREDITDEBIT(CreditNumber);

                    //refresh
                    connPO.sp_PPAYMENT_CREDIT(grid_credit, SupplierID);

                    try
                    {
                        grid_credit.Rows[e.RowIndex].Selected = true;
                        grid_credit.FirstDisplayedScrollingRowIndex = grid_credit.SelectedRows[0].Index;
                    }
                    catch
                    {

                    }
                    
                }
 
            }
        }

        private void txt_poNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //search Supplier ID by PO Number
                String PONumber = "PO" + txt_poNumber.Text.Trim();
                String SupplierIDbyPONumber = connPO.GET_SupplierID_by_PONumber(PONumber);
                cbo_supplierID.Text = SupplierIDbyPONumber;
                cbo_poNumber.Text = PONumber;
                if(cbo_supplierID.Text.Trim() == "")
                {
                    cbo_poNumber.Text = "";
                    txt_poNumber.Focus();
                }
                else
                {
                    txt_amount.Focus();
                }
                txt_poNumber.Text = "";

                cbo_searchSupplierID.Text = cbo_supplierID.Text;
                String SearchSupplierID = cbo_searchSupplierID.Text.Trim();
                connPO.sp_PPAYMENT_CREDIT(grid_credit, SearchSupplierID);


            }
        }
    }
}
