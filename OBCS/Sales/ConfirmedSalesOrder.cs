using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OBCS.conn;

namespace OBCS.Sales
{
    public partial class ConfirmedSalesOrder : Form
    {
        public ConfirmedSalesOrder()
        {
            InitializeComponent();
            grid_ORDER_Init();
            salesOrder_refresh();

            cbo_customerID.Items.Clear();
            connPO.cbox_getCustomerID(cbo_customerID);

            cbo_salesRep.Items.Clear();
            cbo_salesRep.Items.Add("");
            connSalesOrder.sp_GET_SalesRep(cbo_salesRep);
        }

        private void grid_ORDER_Init()
        {
            grid_ORDER.AutoGenerateColumns = false;
            grid_ORDER.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_ORDER.ColumnCount = 14;

            grid_ORDER.Columns[0].Name = "No.";
            grid_ORDER.Columns[0].ReadOnly = true;
            grid_ORDER.Columns[0].Width = 40;
            grid_ORDER.Columns[0].DataPropertyName = "";

            grid_ORDER.Columns[1].Name = "Site";
            grid_ORDER.Columns[1].ReadOnly = true;
            grid_ORDER.Columns[1].Width = 50;
            grid_ORDER.Columns[1].DataPropertyName = "Branch";

            grid_ORDER.Columns[2].Name = "Order ID";
            grid_ORDER.Columns[2].ReadOnly = true;
            grid_ORDER.Columns[2].Width = 120;
            grid_ORDER.Columns[2].DataPropertyName = "OrderID";

            grid_ORDER.Columns[3].Name = "Customer ID";
            grid_ORDER.Columns[3].ReadOnly = true;
            grid_ORDER.Columns[3].Width = 100;
            grid_ORDER.Columns[3].DataPropertyName = "CustomerID";

            grid_ORDER.Columns[4].Name = "Sales Rep.";
            grid_ORDER.Columns[4].ReadOnly = true;
            grid_ORDER.Columns[4].Width = 80;
            grid_ORDER.Columns[4].DataPropertyName = "SaleRep";

            grid_ORDER.Columns[5].Name = "Order Date";
            grid_ORDER.Columns[5].ReadOnly = true;
            grid_ORDER.Columns[5].Width = 80;
            grid_ORDER.Columns[5].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_ORDER.Columns[5].DataPropertyName = "OrderDate";

            grid_ORDER.Columns[6].Name = "Status";
            grid_ORDER.Columns[6].ReadOnly = true;
            grid_ORDER.Columns[6].Width = 50;
            grid_ORDER.Columns[6].DataPropertyName = "OrderStatus";

            grid_ORDER.Columns[7].Name = "Route Date";
            grid_ORDER.Columns[7].ReadOnly = true;
            grid_ORDER.Columns[7].Width = 70;
            grid_ORDER.Columns[7].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_ORDER.Columns[7].DataPropertyName = "RouteDate";

            grid_ORDER.Columns[8].Name = "Route Number";
            grid_ORDER.Columns[8].ReadOnly = true;
            grid_ORDER.Columns[8].Width = 50;
            grid_ORDER.Columns[8].DataPropertyName = "RouteNumber";

            grid_ORDER.Columns[9].Name = "Route Stop";
            grid_ORDER.Columns[9].ReadOnly = true;
            grid_ORDER.Columns[9].Width = 40;
            grid_ORDER.Columns[9].DataPropertyName = "RouteStop";

            grid_ORDER.Columns[10].Name = "Printed";
            grid_ORDER.Columns[10].Visible = false;
            grid_ORDER.Columns[10].Width = 50;
            grid_ORDER.Columns[10].DataPropertyName = "";

            grid_ORDER.Columns[11].Name = "Amount";
            grid_ORDER.Columns[11].ReadOnly = true;
            grid_ORDER.Columns[11].Width = 70;
            grid_ORDER.Columns[11].DefaultCellStyle.Format = "N2";
            grid_ORDER.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[11].DataPropertyName = "Amount";

            grid_ORDER.Columns[12].Name = "Credit";
            grid_ORDER.Columns[12].ReadOnly = true;
            grid_ORDER.Columns[12].Width = 70;
            grid_ORDER.Columns[12].DefaultCellStyle.Format = "N2";
            grid_ORDER.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[12].DataPropertyName = "CreditAmount";

            grid_ORDER.Columns[13].Name = "Memo";
            grid_ORDER.Columns[13].ReadOnly = true;
            grid_ORDER.Columns[13].Width = 200;
            grid_ORDER.Columns[13].DataPropertyName = "OrderMemo";
            
            //grid font size custom
            grid_ORDER.RowTemplate.Height = 20;
            grid_ORDER.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_ORDER.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_ORDER.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void salesOrder_refresh()
        {

            txt_multipleOrdersAmount.Text = "";

            cbo_customerID.Enabled = true;
            cbo_salesRep.Enabled = true;
            dateTimePickerFrom.Enabled = true;
            dateTimePickerTo.Enabled = true;
            
            String CustomerID = cbo_customerID.Text.Trim();
            String SalesRep = cbo_salesRep.Text.Trim();
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            connSalesOrder.sp_Fetch_Order2(grid_ORDER, CustomerID, SalesRep, FromDate, ToDate);
            grid_ORDER.ClearSelection();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cbx_multipleOrders.Checked = false;

            salesOrder_refresh();
        }

        private void grid_ORDER_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String OrderID = grid_ORDER.Rows[e.RowIndex].Cells["Order ID"].Value.ToString().Trim();
                String OrderStatus = connSalesOrder.sp_GET_Order2OrderStatus(OrderID);
                if (OrderStatus == "PickingList")
                {
                    MessageBox.Show("This order number's picking list already has been made.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (OrderStatus == "void")
                {
                    MessageBox.Show("This Order Number has been deleted.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                ConfirmedSalesOrderDetail confirmedSalesOrderDetail = new ConfirmedSalesOrderDetail(OrderID);
                confirmedSalesOrderDetail.StartPosition = FormStartPosition.CenterScreen;
                confirmedSalesOrderDetail.ShowDialog();
            }
            catch
            {

            }
            
        }
        
        //Enter Key Event - David Kang
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check if Enter is pressed
            if (keyData == Keys.Enter)
            {

                // If there isn't any selected row, do nothing
                if (grid_ORDER.CurrentRow == null)
                {
                    return true;
                }

                // Display first cell's value

                String OrderID = grid_ORDER.CurrentRow.Cells["Order ID"].Value.ToString().Trim();
                String OrderStatus = connSalesOrder.sp_GET_Order2OrderStatus(OrderID);
                if (OrderStatus == "PickingList")
                {
                    MessageBox.Show("This Order Number's picking list already has been made .", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return true;
                }
                else if (OrderStatus == "void")
                {
                    MessageBox.Show("This Order Number has been deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return true;
                }
                ConfirmedSalesOrderDetail confirmedSalesOrderDetail = new ConfirmedSalesOrderDetail(OrderID);
                //auditSalesOrder.MdiParent = this.MdiParent;
                confirmedSalesOrderDetail.ShowDialog();

                //int rowIndex = grid_ORDER.CurrentCell.RowIndex;

                //String InText = ControlID.TextData;

                //MessageBox.Show(InText);
                //int InOut = InText.Length;
                //MessageBox.Show(InOut.ToString());
                //if (InOut == 27)
                //{
                //grid_ORDER.Rows.RemoveAt(rowIndex);

                //}

                //else
                //{
                //InOut = 0;
                //grid_ORDER.Refresh();

                //}

                return true;
            }

            if (keyData == Keys.Escape)
            {
                Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void grid_ORDER_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.grid_ORDER.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString("D2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

        private void grid_ORDER_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //MessageBox.Show("grid_ORDER_DataBindingComplete");
            decimal TOA = 0;
            try
            {
                for (int i = 0; i < grid_ORDER.RowCount; i++)
                {
                    TOA += Convert.ToDecimal(grid_ORDER.Rows[i].Cells["Amount"].Value);

                }
                txt_TOA.Text = TOA.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }

        private void cbx_multipleOrders_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_multipleOrders.Checked)
            {
                cbo_customerID.Text = "";
                cbo_salesRep.Text = "";

                //btn_refresh.PerformClick();
                salesOrder_refresh();
                this.grid_ORDER.Sort(this.grid_ORDER.Columns["Customer ID"], ListSortDirection.Ascending);

                cbo_customerID.Enabled = false;
                cbo_salesRep.Enabled = false;
                dateTimePickerFrom.Enabled = false;
                dateTimePickerTo.Enabled = false;
                
                bool multi = false;
                for (int i = 0; i < grid_ORDER.Rows.Count; i++)
                {
                    String CustomerID = grid_ORDER.Rows[i].Cells["Customer ID"].Value.ToString().Trim();
                    String Status = grid_ORDER.Rows[i].Cells["Status"].Value.ToString().Trim();
                    for (int j = 0; j < grid_ORDER.Rows.Count; j++)
                    {
                        String CheckCustomerID = grid_ORDER.Rows[j].Cells["Customer ID"].Value.ToString().Trim();
                        String CheckStatus = grid_ORDER.Rows[j].Cells["Status"].Value.ToString().Trim();
                        if (i != j && CustomerID == CheckCustomerID && Status == "O" && CheckStatus == "O")
                        {
                            //MessageBox.Show(CustomerID + ", " + CheckCustomerID);
                            multi = true;
                        }

                    }

                    if (multi == true)
                    {
                        grid_ORDER.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }

                    multi = false;
                }
                
                decimal MultipleOrdersAmount = 0;
                try
                {
                    for (int i = 0; i < grid_ORDER.RowCount; i++)
                    {
                        if (grid_ORDER.Rows[i].DefaultCellStyle.BackColor == Color.LightSalmon)
                            MultipleOrdersAmount += Convert.ToDecimal(grid_ORDER.Rows[i].Cells["Amount"].Value);
                    }
                    txt_multipleOrdersAmount.Text = MultipleOrdersAmount.ToString("N2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                
                txt_multipleOrdersAmount.Text = "";

                cbo_customerID.Enabled = true;
                cbo_salesRep.Enabled = true;
                dateTimePickerFrom.Enabled = true;
                dateTimePickerTo.Enabled = true;

                //btn_refresh.PerformClick();
                salesOrder_refresh();
            }
        }

        private void grid_ORDER_Sorted(object sender, EventArgs e)
        {
            if(cbx_multipleOrders.Checked)
            {
                bool multi = false;
                for (int i = 0; i < grid_ORDER.Rows.Count; i++)
                {
                    String CustomerID = grid_ORDER.Rows[i].Cells["Customer ID"].Value.ToString().Trim();
                    String Status = grid_ORDER.Rows[i].Cells["Status"].Value.ToString().Trim();
                    for (int j = 0; j < grid_ORDER.Rows.Count; j++)
                    {
                        String CheckCustomerID = grid_ORDER.Rows[j].Cells["Customer ID"].Value.ToString().Trim();
                        String CheckStatus = grid_ORDER.Rows[j].Cells["Status"].Value.ToString().Trim();
                        if (i != j && CustomerID == CheckCustomerID && Status == "O" && CheckStatus == "O")
                        {
                            //MessageBox.Show(CustomerID + ", " + CheckCustomerID);
                            multi = true;
                        }

                    }

                    if (multi == true)
                    {
                        grid_ORDER.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }

                    multi = false;
                }
            }
        }
    }
}
