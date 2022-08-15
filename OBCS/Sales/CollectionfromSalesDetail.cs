using System;
using System.Collections;
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
    public partial class CollectionfromSalesDetail : Form
    {
        private String ARCNumber = "";
        private String NewOrNot = "";
        private String Memo = "";
        private List<String> DeliveryNumberList = new List<String>();
        //private List<String> SelectDeliveryNumberList = new List<String>();
        public CollectionfromSalesDetail(String NewOrNot, String ARCNumber, String SaleRep, DateTime CreateTime, String Memo)
        {
            this.ARCNumber = ARCNumber;
            this.NewOrNot = NewOrNot;
            this.Memo = Memo;
            InitializeComponent();
            grid_ARCollectionDetail_Init();
            cbo_SaleRep.Enabled = true;
            dateTimePickerDate.Enabled = true;
            txt_Memo.Enabled = true;

            cbo_SaleRep.Items.Add("Mail");
            cbo_SaleRep.Items.Add("Vendor");
            connPO.cbox_BPSaleRep(cbo_SaleRep);
            if (NewOrNot.Equals("O"))
            {
                cbo_SaleRep.Text = SaleRep.ToString();
                dateTimePickerDate.Value = CreateTime;
                txt_Memo.Text = Memo.ToString();
                cbo_SaleRep.Enabled = false;
                dateTimePickerDate.Enabled = false;

                
            }

            connPO.cbo_getAllDeliveryNumber(cbo_DeliveryNumber, SaleRep.ToString(), "");
            connPO.cbo_getAllDeliveryNumber(cbo_DeliveryNumber2, SaleRep.ToString(), "");
            //connPO.cbo_CustomerID(cbo_AccountID, SaleRep);
            connPO.cbox_getCustomerID(cbo_AccountID);

            connSalesOrder.sp_ARCOLLECTION_DETAIL(grid_ARCollectionDetail, ARCNumber);
        }
        private void grid_ARCollectionDetail_Init()
        {
            grid_ARCollectionDetail.AutoGenerateColumns = false;
            grid_ARCollectionDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_ARCollectionDetail.ColumnCount = 9;

            grid_ARCollectionDetail.Columns[0].Name = "DeliveryNumber";
            grid_ARCollectionDetail.Columns[0].ReadOnly = true;
            grid_ARCollectionDetail.Columns[0].Width = 60;
            grid_ARCollectionDetail.Columns[0].MinimumWidth = 60;
            grid_ARCollectionDetail.Columns[0].DataPropertyName = "DeliveryNumber";

            grid_ARCollectionDetail.Columns[1].Name = "DeliveryDate";
            grid_ARCollectionDetail.Columns[1].ReadOnly = true;
            grid_ARCollectionDetail.Columns[1].Visible = false;
            grid_ARCollectionDetail.Columns[1].Width = 50;
            grid_ARCollectionDetail.Columns[1].MinimumWidth = 50;
            grid_ARCollectionDetail.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_ARCollectionDetail.Columns[1].DataPropertyName = "DeliveryDate";

            grid_ARCollectionDetail.Columns[2].Name = "AccountID";
            grid_ARCollectionDetail.Columns[2].ReadOnly = true;
            grid_ARCollectionDetail.Columns[2].Width = 80;
            grid_ARCollectionDetail.Columns[2].MinimumWidth = 80;
            grid_ARCollectionDetail.Columns[2].DataPropertyName = "AccountID";

            grid_ARCollectionDetail.Columns[3].Name = "CashCheck";
            grid_ARCollectionDetail.Columns[3].ReadOnly = true;
            grid_ARCollectionDetail.Columns[3].Width = 45;
            grid_ARCollectionDetail.Columns[3].MinimumWidth = 45;
            grid_ARCollectionDetail.Columns[3].DataPropertyName = "CashCheck";

            grid_ARCollectionDetail.Columns[4].Name = "CheckNumber";
            grid_ARCollectionDetail.Columns[4].ReadOnly = true;
            grid_ARCollectionDetail.Columns[4].Width = 50;
            grid_ARCollectionDetail.Columns[4].MinimumWidth = 50;
            grid_ARCollectionDetail.Columns[4].DataPropertyName = "CheckNumber";

            grid_ARCollectionDetail.Columns[5].Name = "CheckDate";
            grid_ARCollectionDetail.Columns[5].ReadOnly = true;
            grid_ARCollectionDetail.Columns[5].Width = 60;
            grid_ARCollectionDetail.Columns[5].MinimumWidth = 60;
            grid_ARCollectionDetail.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_ARCollectionDetail.Columns[5].DataPropertyName = "CheckDate";

            grid_ARCollectionDetail.Columns[6].Name = "Amount";
            grid_ARCollectionDetail.Columns[6].ReadOnly = true;
            grid_ARCollectionDetail.Columns[6].Width = 50;
            grid_ARCollectionDetail.Columns[6].MinimumWidth = 50;
            grid_ARCollectionDetail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_ARCollectionDetail.Columns[6].DataPropertyName = "Amount";

            grid_ARCollectionDetail.Columns[7].Name = "Memo";
            grid_ARCollectionDetail.Columns[7].ReadOnly = true;
            grid_ARCollectionDetail.Columns[7].Width = 250;
            grid_ARCollectionDetail.Columns[7].MinimumWidth = 250;
            grid_ARCollectionDetail.Columns[7].DataPropertyName = "Memo";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 50;
            deleteButton.MinimumWidth = 50;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_ARCollectionDetail.Columns["Delete"] == null)
            {
                grid_ARCollectionDetail.Columns.Insert(8, deleteButton);
            }

            grid_ARCollectionDetail.Columns[9].Name = "id";
            grid_ARCollectionDetail.Columns[9].ReadOnly = true;
            grid_ARCollectionDetail.Columns[9].Visible = false;
            grid_ARCollectionDetail.Columns[9].Width = 10;
            grid_ARCollectionDetail.Columns[9].MinimumWidth = 10;
            grid_ARCollectionDetail.Columns[9].DataPropertyName = "id";

            //grid font size custom
            grid_ARCollectionDetail.RowTemplate.Height = 20;
            grid_ARCollectionDetail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_ARCollectionDetail.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_ARCollectionDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
       
        private void cbo_SaleRep_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //cbo_DeliveryNumber2.Text = "Input value and Press ENTER";
            //cbo_AccountID.Text = "";

            //connPO.cbo_getAllDeliveryNumber(cbo_DeliveryNumber, cbo_SaleRep.Text, "");
            //connPO.cbo_getAllDeliveryNumber(cbo_DeliveryNumber2, cbo_SaleRep.Text, "");
            ////connPO.cbo_CustomerID(cbo_AccountID, SaleRep);
            //connPO.cbox_getCustomerID(cbo_AccountID);

            cbo_SaleRep.Enabled = false;

        }
        private void cbo_CashCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            datetimePickerCheck.Enabled = true;
            txt_CheckNumber.Enabled = true;

            if (cbo_CashCheck.Text.Equals("Cash"))
            {
                txt_CheckNumber.Enabled = false;
                datetimePickerCheck.Enabled = false;
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cbo_SaleRep.Text.Trim() == "" || cbo_AccountID.Text.Trim() == "" || cbo_CashCheck.Text.Trim() == "")
            {
                MessageBox.Show("Input all item info", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            try
            {
                String DeliveryNumber = txt_DeliveryNumber.Text;
                DateTime DeliveryDate = datetimePickerDelivery.Value;
                String AccountID = cbo_AccountID.Text;
                String CashCheck = cbo_CashCheck.Text;
                String CheckNumber = txt_CheckNumber.Text;
                DateTime CheckDate = datetimePickerCheck.Value.Date;
                Decimal Amount = Convert.ToDecimal(txt_Amount.Text);
                String Memo = txt_DetailMemo.Text;

                //DataTable dt = new DataTable();
                //dt = this.grid_ARCollectionDetail.DataSource as DataTable;
                //DataRow dr = dt.NewRow();
                //dr["DeliveryNumber"] = DeliveryNumber;
                //dr["DeliveryDate"] = DeliveryDate;
                //dr["AccountID"] = AccountID;
                //dr["CashCheck"] = CashCheck;
                //dr["CheckNumber"] = CheckNumber;
                //dr["CheckDate"] = CheckDate;
                //dr["Amount"] = Amount;
                //dr["Memo"] = Memo;
                //dt.Rows.Add(dr);

                cbo_DeliveryNumber2.Text = "";
                cbo_AccountID.Text = "";
                txt_CheckNumber.Text = "";
                txt_DeliveryNumber.Text = "";
                txt_Amount.Text = "";
                txt_DetailMemo.Text = "";
                DeliveryNumberList.Clear();

                if (this.NewOrNot.Equals("N"))
                {
                    //Insert Header 
                    connSalesOrder.sp_ARCOLLECTION_CREATE_HEADER(this.ARCNumber, cbo_SaleRep.Text, txt_Memo.Text);
                    this.NewOrNot = "O";
                    this.Memo = txt_Memo.Text.ToString();
                    cbo_SaleRep.Enabled = false;
                }
                //Insert Detail
                connSalesOrder.sp_ARCOLLECTION_INSERT_DETAIL(this.ARCNumber, DeliveryNumber, DeliveryDate, AccountID, CashCheck, CheckNumber, CheckDate, Amount, "", Memo);

                //Update Header memo & editID, edittime
                connSalesOrder.sp_ARCOLLECTION_UPDATE_HEADER(this.ARCNumber, cbo_SaleRep.Text, txt_Memo.Text);
                //Select Detail
                connSalesOrder.sp_ARCOLLECTION_DETAIL(grid_ARCollectionDetail, this.ARCNumber);

                int ARCid = Convert.ToInt32(grid_ARCollectionDetail.Rows[grid_ARCollectionDetail.Rows.Count - 1].Cells["id"].Value.ToString().Trim());
                //MessageBox.Show(ARCid.ToString());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("Please input valid values.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void grid_ARCollectionDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 8 && e.RowIndex >= 0) // Delete button
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure to delete this item from list?"
                                                            , "Confirming", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(grid_ARCollectionDetail.Rows[e.RowIndex].Cells["id"].Value.ToString().Trim());
                        connSalesOrder.sp_ARCOLLECTION_DELETE_DETAIL(this.ARCNumber, id);
                        grid_ARCollectionDetail.Rows.RemoveAt(e.RowIndex);

                    }
                    else if (dialogResult == DialogResult.No) { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ARCNumber : " + this.ARCNumber + "\n" + ex.ToString());
            }
        }
        private void grid_ARCollectionDetail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            calculate();
        }
        private void calculate()
        {
            try
            {
                Decimal CashTotal = 0;
                Decimal CheckTotal = 0;
                Decimal Total = 0;

                for (int j = 0; j < grid_ARCollectionDetail.RowCount; j++)
                {
                    string CashCheck = grid_ARCollectionDetail.Rows[j].Cells["CashCheck"].Value.ToString().Trim();
                    decimal amount = Convert.ToDecimal(grid_ARCollectionDetail.Rows[j].Cells["Amount"].Value);
                    if (CashCheck.Equals("Cash"))
                    {
                        CashTotal = CashTotal + amount;
                    }
                    else if (CashCheck.Equals("Check"))
                    {
                        CheckTotal = CheckTotal + amount;
                    }
                    Total = Total + amount;
                }
                txt_CashTotal.Text = CashTotal.ToString("N2");
                txt_CheckTotal.Text = CheckTotal.ToString("N2");
                txt_Total.Text = Total.ToString("N2");

            }
            catch
            {
                MessageBox.Show("Please input valid values.");
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            connSalesOrder.sp_ARCOLLECTION_UPDATE_HEADER(this.ARCNumber, cbo_SaleRep.Text, txt_Memo.Text);
            Reports.Rpt_ARCOLLECTIOND rpt_ARCOLLECTIOND = new Reports.Rpt_ARCOLLECTIOND(cbo_SaleRep.Text, dateTimePickerDate.Value, txt_Memo.Text, ARCNumber);
            rpt_ARCOLLECTIOND.Show();
        }


        private void btn_DelAdd_Click(object sender, EventArgs e)
        {
            bool CorrectNumber = false;
            try
            {

                foreach (String itemstring in cbo_DeliveryNumber.Items)
                {
                    if (itemstring.Equals(cbo_DeliveryNumber2.Text))
                    {
                        CorrectNumber = true;
                    }
                }
                if (CorrectNumber == false)
                {
                    MessageBox.Show("Check the input value.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DeliveryNumberList.Exists(item => item.Equals(cbo_DeliveryNumber2.Text)))
                {
                    MessageBox.Show("Duplicate delivery number.");
                }
                else
                {
                    DeliveryNumberList.Add(cbo_DeliveryNumber2.Text);
                    txt_DeliveryNumber.Text = "";
                    for (int i = 0; i < DeliveryNumberList.Count; i++)
                    {
                        txt_DeliveryNumber.Text += DeliveryNumberList[i].ToString() + " ";
                    }
                    cbo_DeliveryNumber2.Text = "";
                    cbo_DeliveryNumber2.DroppedDown = false;
                }
                cbo_DeliveryNumber2.Focus();
            }
            catch (Exception ex) { MessageBox.Show("Try again."); }

        }
        private void btn_DelDelete_Click(object sender, EventArgs e)
        {
            try
            {
                txt_DeliveryNumber.Text = "";
                if (DeliveryNumberList.Count > 0)
                {
                    DeliveryNumberList.RemoveAt(DeliveryNumberList.Count - 1);
                }
                for (int i = 0; i < DeliveryNumberList.Count; i++)
                {
                    txt_DeliveryNumber.Text += DeliveryNumberList[i].ToString() + " ";
                }
            }
            catch (Exception ex) { MessageBox.Show("Try again."); }
        }


        private void ARCOLLECTIOND_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NewOrNot.Equals("O"))
            {
                if (!this.Memo.Equals(txt_Memo.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to save the changes?", "Save", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        connSalesOrder.sp_ARCOLLECTION_UPDATE_HEADER(this.ARCNumber, cbo_SaleRep.Text, txt_Memo.Text);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                    else
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }
        private void cbo_DeliveryNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                connPO.cbo_getAllDeliveryNumber(cbo_DeliveryNumber2, cbo_SaleRep.Text, cbo_DeliveryNumber2.Text);
                cbo_DeliveryNumber2.SelectionStart = cbo_DeliveryNumber2.Text.Length;
                cbo_DeliveryNumber2.SelectedItem = FindItemContaining(cbo_DeliveryNumber2.Items, cbo_DeliveryNumber2.Text);
                cbo_DeliveryNumber2.DroppedDown = true;

            }
        }
        private object FindItemContaining(IEnumerable items, string target)
        {
            foreach (object item in items)
                if (item.ToString().Contains(target))
                    return item;

            return null;
        }

        private void cbo_DeliveryNumber2_MouseClick(object sender, MouseEventArgs e)
        {
            if(cbo_DeliveryNumber2.Text.Equals("Input value and Press ENTER"))
            {
                cbo_DeliveryNumber2.Text = "";
            }
        }
        private void cbo_DeliveryNumber2_SelectedIndexChanged(object sender, EventArgs e)
        {
            connPO.DTP_getDeliveryDateFromNumber(datetimePickerDelivery, cbo_DeliveryNumber2.Text);
        }

        private void cbo_DeliveryNumber2_Leave(object sender, EventArgs e)
        {
            if (cbo_DeliveryNumber2.Text.Length == 0)
            {
                //connPO.cbo_getAllDeliveryNumber(cbo_DeliveryNumber2, cbo_SaleRep.Text.ToString(), "");
                cbo_DeliveryNumber2.Text = "Input value and Press ENTER";
            }
                


        }

        private void cbo_AccountID_Enter(object sender, EventArgs e)
        {
            cbo_AccountID.DroppedDown = true;
        }

        private void cbo_SaleRep_Enter(object sender, EventArgs e)
        {
            cbo_SaleRep.DroppedDown = true;
        }
    }
}
