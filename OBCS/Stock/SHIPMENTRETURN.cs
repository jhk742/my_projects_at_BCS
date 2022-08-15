using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Stock
{
    public partial class SHIPMENTRETURN : Form
    {
        public SHIPMENTRETURN()
        {
            InitializeComponent();
            grid_returned_Init();
            grid_tempReturned_Init();
            grid_detail_Init();

            //dateTimePickerFrom.Value = DateTime.Now.AddMonths(-1);

            connSalesOrder.sp_SHIPMENTRETURN_SELECT_RETURN(grid_returned,dateTimePickerFrom.Value.Date,dateTimePickerTo.Value.Date);

            connSalesOrder.sp_SHIPMENTRETURN_SELECT_RETURN_TEMP(grid_tempReturned);

            btn_done.Enabled = false;
            btn_notReturned.Enabled = false;
            tabControl1.SelectedTab = tabWIP;
            

            //아이템 가져오기
            connSalesOrder.cbo_itemID(cbo_product);
            cbo_RM.Items.Add("RR");
            cbo_RM.Items.Add("PF");

            connSalesOrder.cbo_Company(cbo_Company);
            cbo_Company.SelectedItem = "BIC";
            txt_CompanyName.Text = connSalesOrder.getCompanyName(cbo_Company.Text.ToString());

            //connSalesOrder.cbo_site(cbo_storageSite);
            cbo_storageSite.Items.Add("BCS");
            cbo_storageSite.Items.Add("WH2");
            cbo_storageSite.SelectedItem = "BCS";

            if (connSalesOrder.sp_UserCheck("SHIPMENTRETURN").Equals("1"))
            {
                btn_Add.Visible = true;
                btn_create.Visible = true;
            }
            else
            {
                btn_FakeAdd.Visible = true;
                btn_FakeCreate.Visible = true;
            }
        }

        private void grid_tempReturned_Init()
        {
            grid_tempReturned.AutoGenerateColumns = false;
            grid_tempReturned.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_tempReturned.ColumnCount = 12;

            grid_tempReturned.Columns[0].Name = "Company";
            grid_tempReturned.Columns[0].ReadOnly = true;
            grid_tempReturned.Columns[0].Width = 55;
            grid_tempReturned.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[0].DataPropertyName = "Company";

            grid_tempReturned.Columns[1].Name = "Site";
            grid_tempReturned.Columns[1].ReadOnly = true;
            grid_tempReturned.Columns[1].Width = 40;
            grid_tempReturned.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[1].DataPropertyName = "Site";

            grid_tempReturned.Columns[2].Name = "Return number";
            grid_tempReturned.Columns[2].ReadOnly = true;
            grid_tempReturned.Columns[2].Width = 80;
            grid_tempReturned.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[2].DataPropertyName = "ReturnID";

            grid_tempReturned.Columns[3].Name = "Create Date";
            grid_tempReturned.Columns[3].ReadOnly = true;
            grid_tempReturned.Columns[3].Width = 80;
            grid_tempReturned.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_tempReturned.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[3].DataPropertyName = "CreateTime";

            grid_tempReturned.Columns[4].Name = "Sale rep";
            grid_tempReturned.Columns[4].ReadOnly = true;
            grid_tempReturned.Columns[4].Width = 45;
            grid_tempReturned.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[4].DataPropertyName = "SaleRep";

            grid_tempReturned.Columns[5].Name = "Branch";
            grid_tempReturned.Columns[5].ReadOnly = true;
            grid_tempReturned.Columns[5].Width = 45;
            grid_tempReturned.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[5].DataPropertyName = "Branch";

            grid_tempReturned.Columns[6].Name = "Customer ID";
            grid_tempReturned.Columns[6].ReadOnly = true;
            grid_tempReturned.Columns[6].Width = 80;
            grid_tempReturned.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[6].DataPropertyName = "CustomerID";

            grid_tempReturned.Columns[7].Name = "Customer Name";
            grid_tempReturned.Columns[7].ReadOnly = true;
            grid_tempReturned.Columns[7].Width = 150;
            grid_tempReturned.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[7].DataPropertyName = "CustomerName";

            grid_tempReturned.Columns[8].Name = "Order number";
            grid_tempReturned.Columns[8].ReadOnly = true;
            grid_tempReturned.Columns[8].Width = 80;
            grid_tempReturned.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[8].DataPropertyName = "OrderID";

            grid_tempReturned.Columns[9].Name = "Delivery number";
            grid_tempReturned.Columns[9].ReadOnly = true;
            grid_tempReturned.Columns[9].Width = 100;
            grid_tempReturned.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[9].DataPropertyName = "DeliveryNumber";

            grid_tempReturned.Columns[10].Name = "Order status";
            grid_tempReturned.Columns[10].ReadOnly = true;
            grid_tempReturned.Columns[10].Visible = false;
            grid_tempReturned.Columns[10].Width = 60;
            grid_tempReturned.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_tempReturned.Columns[10].DataPropertyName = "OrderStatus";

            grid_tempReturned.Columns[11].Name = "Amount";
            grid_tempReturned.Columns[11].ReadOnly = true;
            grid_tempReturned.Columns[11].Width = 60;
            grid_tempReturned.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_tempReturned.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_tempReturned.Columns[11].DataPropertyName = "Amount";

            //grid font size custom
            grid_tempReturned.RowTemplate.Height = 20;
            grid_tempReturned.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_tempReturned.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_tempReturned.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_returned_Init()
        {
            grid_returned.AutoGenerateColumns = false;
            grid_returned.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_returned.ColumnCount = 12;

            grid_returned.Columns[0].Name = "Company";
            grid_returned.Columns[0].ReadOnly = true;
            grid_returned.Columns[0].Width = 55;
            grid_returned.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[0].DataPropertyName = "Company";

            grid_returned.Columns[1].Name = "Site";
            grid_returned.Columns[1].ReadOnly = true;
            grid_returned.Columns[1].Width = 40;
            grid_returned.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[1].DataPropertyName = "Site";

            grid_returned.Columns[2].Name = "Return number";
            grid_returned.Columns[2].ReadOnly = true;
            grid_returned.Columns[2].Width = 80;
            grid_returned.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[2].DataPropertyName = "ReturnID";

            grid_returned.Columns[3].Name = "Transaction Date";
            grid_returned.Columns[3].ReadOnly = true;
            grid_returned.Columns[3].Width = 80;
            grid_returned.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_returned.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[3].DataPropertyName = "LastModTime";

            grid_returned.Columns[4].Name = "Sale rep";
            grid_returned.Columns[4].ReadOnly = true;
            grid_returned.Columns[4].Width = 45;
            grid_returned.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[4].DataPropertyName = "SaleRep";

            grid_returned.Columns[5].Name = "Branch";
            grid_returned.Columns[5].ReadOnly = true;
            grid_returned.Columns[5].Width = 45;
            grid_returned.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[5].DataPropertyName = "Branch";

            grid_returned.Columns[6].Name = "Customer ID";
            grid_returned.Columns[6].ReadOnly = true;
            grid_returned.Columns[6].Width = 80;
            grid_returned.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[6].DataPropertyName = "CustomerID";

            grid_returned.Columns[7].Name = "Customer Name";
            grid_returned.Columns[7].ReadOnly = true;
            grid_returned.Columns[7].Width = 150;
            grid_returned.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[7].DataPropertyName = "CustomerName";

            grid_returned.Columns[8].Name = "Order number";
            grid_returned.Columns[8].ReadOnly = true;
            grid_returned.Columns[8].Width = 80;
            grid_returned.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[8].DataPropertyName = "OrderID";

            grid_returned.Columns[9].Name = "Delivery number";
            grid_returned.Columns[9].ReadOnly = true;
            grid_returned.Columns[9].Width = 100;
            grid_returned.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[9].DataPropertyName = "DeliveryNumber";

            grid_returned.Columns[10].Name = "Order status";
            grid_returned.Columns[10].ReadOnly = true;
            grid_returned.Columns[10].Visible = false;
            grid_returned.Columns[10].Width = 60;
            grid_returned.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_returned.Columns[10].DataPropertyName = "OrderStatus";

            grid_returned.Columns[11].Name = "Amount";
            grid_returned.Columns[11].ReadOnly = true;
            grid_returned.Columns[11].Width = 60;
            grid_returned.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_returned.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_returned.Columns[11].DataPropertyName = "Amount";

            //grid font size custom
            grid_returned.RowTemplate.Height = 20;
            grid_returned.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_returned.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_returned.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_detail_Init()
        {
            grid_detail.AutoGenerateColumns = false;
            grid_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_detail.ColumnCount = 9;

            grid_detail.Columns[0].Name = "No.";
            grid_detail.Columns[0].ReadOnly = true;
            grid_detail.Columns[0].Visible = false;
            grid_detail.Columns[0].Width = 50;
            grid_detail.Columns[0].DataPropertyName = "OrderDetailKey";

            grid_detail.Columns[1].Name = "Product ID";
            grid_detail.Columns[1].ReadOnly = true;
            grid_detail.Columns[1].Width = 90;
            grid_detail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[1].DataPropertyName = "ProductID";

            grid_detail.Columns[2].Name = "Product Description";
            grid_detail.Columns[2].ReadOnly = true;
            grid_detail.Columns[2].Width = 300;
            grid_detail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[2].DataPropertyName = "ProductDesc";

            grid_detail.Columns[3].Name = "Remark";
            grid_detail.Columns[3].ReadOnly = true;
            grid_detail.Columns[3].Width = 70;
            grid_detail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[3].DataPropertyName = "Remark";

            grid_detail.Columns[4].Name = "Price";
            grid_detail.Columns[4].ReadOnly = true;
            grid_detail.Columns[4].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[4].Width = 70;
            grid_detail.Columns[4].DataPropertyName = "Price";

            grid_detail.Columns[5].Name = "Quantity";
            grid_detail.Columns[5].ReadOnly = false;
            grid_detail.Columns[5].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[5].Width = 70;
            grid_detail.Columns[5].DataPropertyName = "OrderQty";

            grid_detail.Columns[6].Name = "Amount";
            grid_detail.Columns[6].ReadOnly = true;
            grid_detail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].Width = 80;
            grid_detail.Columns[6].DataPropertyName = "Amount";

            DataGridViewComboBoxColumn AQRComboBox = new DataGridViewComboBoxColumn();
            AQRComboBox.Width = 50;
            AQRComboBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            AQRComboBox.Name = "Status";
            AQRComboBox.Items.Add("A");
            AQRComboBox.Items.Add("Q");
            AQRComboBox.Items.Add("R");
            AQRComboBox.FlatStyle = FlatStyle.Popup;
            AQRComboBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AQRComboBox.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AQRComboBox.DataPropertyName = "TempAQR";
            grid_detail.Columns.Insert(7, AQRComboBox);

            grid_detail.Columns[8].Name = "Expiration Date";
            grid_detail.Columns[8].ReadOnly = false;
            grid_detail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[8].Width = 90;
            grid_detail.Columns[8].DataPropertyName = "Expiration";

            grid_detail.Columns[9].Name = "Memo";
            grid_detail.Columns[9].ReadOnly = false;
            grid_detail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid_detail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[9].Width = 150;
            grid_detail.Columns[9].DataPropertyName = "Memo";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 50;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_detail.Columns["Delete"] == null)

            {
                grid_detail.Columns.Insert(10, deleteButton);
            }


            //grid font size custom
            grid_detail.RowTemplate.Height = 20;
            grid_detail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_detail.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_detail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private string SelectedReturnID;
        private string SelectedOrderID;
        private string SelectedCustomerID;
        private string format;

        private void btn_done_Click(object sender, EventArgs e) // Returned item receive button
        {
            try
            {
                if (connSalesOrder.sp_CHECK_ShipmentReturn(SelectedOrderID) == true)
                {
                    MessageBox.Show("Already processed shipment return. Refreshing...", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //connSalesOrder.sp_SHIPMENTRETURN_SELECT_RETURN(grid_returned, dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);
                    //connSalesOrder.sp_SHIPMENTRETURN_SELECT_RETURN_TEMP(grid_tempReturned);

                    return;
                }
                if (connSalesOrder.sp_CHECK_SRETURNID(SelectedReturnID) == true)
                {
                    MessageBox.Show("Already processed shipment return. Refreshing...", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //connSalesOrder.sp_SHIPMENTRETURN_SELECT_RETURN(grid_returned, dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);
                    //connSalesOrder.sp_SHIPMENTRETURN_SELECT_RETURN_TEMP(grid_tempReturned);

                    return;
                }
                if (grid_detail.RowCount == 0)
                {
                    MessageBox.Show("Please click Decline button.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                for (int i = 0; i < grid_detail.Rows.Count; i++)
                {
                    Decimal RetunrQty = Convert.ToDecimal(grid_detail.Rows[i].Cells["Quantity"].Value.ToString().Trim());
                    String ReturnAQR = grid_detail.Rows[i].Cells["Status"].Value.ToString().Trim();
                    String ReturnExpirationDate = grid_detail.Rows[i].Cells["Expiration Date"].Value.ToString().Trim();
                    if (RetunrQty <= 0)
                    {
                        MessageBox.Show("Please delete the item when the item has not been received.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    if (ReturnAQR == "")
                    {
                        MessageBox.Show("Please select product status."
                                                            , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    if (ReturnExpirationDate == "")
                    {
                        MessageBox.Show("Please input the expiration date."
                                                            , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    if (string.IsNullOrEmpty(grid_detail.Rows[i].Cells["Memo"].Value as string))
                    {
                        grid_detail.Rows[i].Cells["Memo"].Value = "";
                    }
                    if (grid_detail.Rows[i].Cells["Memo"].Value.ToString().Length > 20)
                    {
                        MessageBox.Show("Memo (20) letter"
                                                            , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure shipment return receiving process?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    String CompanyCode = cbo_Company.Text.ToString();
                    String Site = cbo_storageSite.Text.ToString();
                    for (int i = 0; i < grid_detail.Rows.Count; i++)
                    {
                        String OrderDetailKey = grid_detail.Rows[i].Cells["No."].Value.ToString().Trim();
                        String Status = grid_detail.Rows[i].Cells["Status"].Value.ToString().Trim();
                        String Remark = grid_detail.Rows[i].Cells["Remark"].Value.ToString().Trim();
                        Decimal ReturnQty = Convert.ToDecimal(grid_detail.Rows[i].Cells["Quantity"].Value.ToString().Trim());
                        Decimal ReturnPrice = Convert.ToDecimal(grid_detail.Rows[i].Cells["Price"].Value.ToString().Trim());
                        Decimal ReturnAmount = Convert.ToDecimal(grid_detail.Rows[i].Cells["Amount"].Value.ToString().Trim());
                        String ProductID = grid_detail.Rows[i].Cells["Product ID"].Value.ToString().Trim();
                        DateTime ExpirationDate = Convert.ToDateTime(grid_detail.Rows[i].Cells["Expiration Date"].Value.ToString().Trim());
                        String Memo = grid_detail.Rows[i].Cells["Memo"].Value.ToString().Trim();
                        
                        connSalesOrder.sp_RETURN_RECEIVING_DETAIL(SelectedReturnID, SelectedOrderID, OrderDetailKey, ProductID, ReturnQty, ReturnPrice, ReturnAmount, Status, ExpirationDate, Memo, Remark);
                        connSalesOrder.sp_RETURN_STOCK(SelectedCustomerID, i + 1, ReturnQty, Status, ExpirationDate, ProductID, Memo, CompanyCode, Site);
                    }
                    connSalesOrder.sp_RETURN_RECEIVING(SelectedReturnID);

                    btn_notReturned.Enabled = false;
                    btn_done.Enabled = false;

                    grid_tempReturned.DataSource = null;
                    grid_detail.DataSource = null;
                    MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Accept Button Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_notReturned_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure shipment not received all item process?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connSalesOrder.sp_SHIPMENTRETURN_NOTRETURNED(SelectedReturnID);

                btn_notReturned.Enabled = false;
                btn_done.Enabled = false;

                grid_tempReturned.DataSource = null;
                grid_detail.DataSource = null;
                MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else if (dialogResult == DialogResult.No)
            {

            }


        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            if (cbo_product.Text.Trim() == "" || cbo_RM.Text.Length == 0 || txt_price.Text.Length == 0 || txt_qty.Text.Length == 0)
            {
                MessageBox.Show("Input all values.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                DataTable dt = this.grid_detail.DataSource as DataTable;
                DataRow dr = dt.NewRow();

                //get new orderDetailKey
                String NewOrderDetailKey = connSalesOrder.sp_GET_NewOrderDetailKey();

                int OrderDetailKey = Convert.ToInt32(Convert.ToDecimal(NewOrderDetailKey));
                String ProductID = cbo_product.Text;
                Decimal Quantity = Convert.ToDecimal(txt_qty.Text);
                String ProductDesc = txt_ProductDesc.Text;
                Decimal Price = Convert.ToDecimal(txt_price.Text);
                Decimal Amount = Convert.ToDecimal(txt_amount.Text);
                String Remark = cbo_RM.Text;

                dr["OrderDetailKey"] = OrderDetailKey;
                dr["ProductID"] = ProductID;
                dr["ProductDesc"] = ProductDesc;
                dr["Remark"] = Remark;
                dr["Price"] = Price;
                dr["OrderQty"] = Quantity;
                dr["Amount"] = Amount;
                dr["TempAQR"] = "A";
                dr["Expiration"] = "01/01/1900";
                dr["Memo"] = "";

                dt.Rows.Add(dr);
                //dt.Rows.InsertAt(dr, grid_RouteDetail.ColumnCount + 1);
                //Audit();
                cbo_product.Text = "";
                txt_ProductDesc.Text = "";
                cbo_RM.Text = "RR";
                txt_qty.Text = "";
                txt_amount.Text = "";
                txt_price.Text = "";

            }
            catch(Exception ex)
            {
                MessageBox.Show("Select Return ID first. \n"+ex.Message.ToString(), "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure create a new return ID?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                String DeliveryNumber = txt_deliveryNumber.Text.Trim();
                String Return = connSalesOrder.sp_Check_NewReturn(DeliveryNumber);
                if (Return != "OK")
                    MessageBox.Show(Return, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    String ReturnID = connSalesOrder.sp_CREATE_NewReturn(DeliveryNumber);
                    //MessageBox.Show(ReturnID+"", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    refresh();
                    MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_deliveryNumber.Text = "";
                    customLabel1.Text = "";
                }
            }
        }
        private void grid_returned_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_notReturned.Enabled = false;
                btn_done.Enabled = false;
                SelectedReturnID = grid_returned.Rows[e.RowIndex].Cells["Return number"].Value.ToString().Trim();
                SelectedOrderID = grid_returned.Rows[e.RowIndex].Cells["Order number"].Value.ToString().Trim();
                connSalesOrder.sp_SHIPMENTRETURN_SELECT_RETURNDETAIL(grid_detail, SelectedReturnID);
                grid_detail.Columns[7].ReadOnly = true;
            }
            catch { }
            
        }

        private void grid_tempReturned_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grid_tempReturned.RowCount == 0)
                {
                    grid_detail.DataSource = null;
                }
                else
                {
                    SelectedReturnID = grid_tempReturned.Rows[e.RowIndex].Cells["Return number"].Value.ToString().Trim();
                    SelectedOrderID = grid_tempReturned.Rows[e.RowIndex].Cells["Order number"].Value.ToString().Trim();
                    SelectedCustomerID = grid_tempReturned.Rows[e.RowIndex].Cells["Customer ID"].Value.ToString().Trim();
                    connSalesOrder.sp_SHIPMENTRETURN_SELECT_RETURNDETAIL_TEMP(grid_detail, SelectedReturnID);
                    btn_Add.Enabled = true;
                    btn_notReturned.Enabled = true;
                    btn_done.Enabled = true;
                    grid_detail.Columns[7].ReadOnly = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void grid_detail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10 && e.RowIndex >= 0) // Delete button
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure delete item from this list?"
                                                        , "Confirming", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //DataTable dt = this.grid_OrderDetail.DataSource as DataTable;
                    //DataRow dr = dt.NewRow();
                    //dt.Rows.RemoveAt(e.RowIndex);
                    //Audit();
                    grid_detail.Rows.RemoveAt(e.RowIndex);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                //Audit();
            }
        }

        
        private void grid_detail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                try
                {

                    CultureInfo provider = CultureInfo.InvariantCulture;
                    string dateString = grid_detail.CurrentRow.Cells["Expiration Date"].Value.ToString().Trim();

                    if (dateString.Length == 6)
                    {
                        format = "MMddyy";
                    }
                    else if (dateString.Length == 8)
                    {
                        format = "MMddyyyy";
                    }
                    else if (dateString.Length == 10)
                    {
                        format = "MM/dd/yyyy";
                    }
                    DateTime result = DateTime.ParseExact(dateString, format, provider);
                    grid_detail.CurrentRow.Cells["Expiration Date"].Value = result.ToString("MM/dd/yyyy");
                    //MessageBox.Show(grid_detail.CurrentRow.Cells["Expiration Date"].Value.ToString().Trim());

                }
                catch
                {
                    MessageBox.Show("Wrong Date format\n(Please try 'MMddyy', 'MMddyyyy', 'MM/dd/yyyy')", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    grid_detail.CurrentRow.Cells["Expiration Date"].Value = "01/01/1900";
                }
            }
            else
            {
                try
                {
                    if (grid_detail.Rows[e.RowIndex].Cells["Remark"].Value.ToString().Trim() == "RR")
                    {
                        Decimal ReturnPrice = Convert.ToDecimal(grid_detail.Rows[e.RowIndex].Cells["Price"].Value.ToString().Trim());
                        Decimal ReturQty = Convert.ToDecimal(grid_detail.Rows[e.RowIndex].Cells["Quantity"].Value.ToString().Trim());
                        grid_detail.CurrentRow.Cells["Amount"].Value = ReturnPrice * ReturQty;
                    }
                    else
                    {
                        grid_detail.CurrentRow.Cells["Amount"].Value = 0;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "DataGridView Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("HI" + ex.ToString());
                }
            }

            
        }
        private void refresh()
        {
            connSalesOrder.sp_SHIPMENTRETURN_SELECT_RETURN(grid_returned, dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);
            connSalesOrder.sp_SHIPMENTRETURN_SELECT_RETURN_TEMP(grid_tempReturned);
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            connSalesOrder.sp_SHIPMENTRETURN_SELECT_RETURN(grid_returned, dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);
        }

        private void btn_RefreshWIP_Click(object sender, EventArgs e)
        {
            connSalesOrder.sp_SHIPMENTRETURN_SELECT_RETURN_TEMP(grid_tempReturned);
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            grid_detail.DataSource = null;

            if (e.TabPage == tabDone)
            {
                grid_detail.Enabled = false;
                btn_Add.Enabled = false;
                btn_notReturned.Enabled = false;
                btn_done.Enabled = false;
                cbo_product.Enabled = false;
                if (grid_returned.RowCount > 0)
                {
                    grid_returned.Rows[0].Selected = true;
                    grid_returned.CurrentCell = grid_returned.Rows[0].Cells[0];
                    grid_returned_CellEnter(this.grid_returned, new DataGridViewCellEventArgs(0, 0));
                }
            }
            else
            {
                grid_detail.Enabled = true;
                btn_Add.Enabled = false;
                btn_done.Enabled = false;
                btn_notReturned.Enabled = false;
                cbo_product.Enabled = true;
                if (grid_tempReturned.RowCount > 0)
                {
                    grid_tempReturned.Rows[0].Selected = true;
                    grid_tempReturned.CurrentCell = grid_tempReturned.Rows[0].Cells[0];
                    grid_tempReturned_CellEnter(this.grid_tempReturned, new DataGridViewCellEventArgs(0, 0));
                    btn_Add.Enabled = true;
                    btn_notReturned.Enabled = true;
                    btn_done.Enabled = true;
                }
            }
        }
        private void Initialize_Information()
        {
            txt_ProductDesc.Text = "";
            txt_PackSize.Text = "";
            cbo_RM.Text = "";
            txt_price.Text = "";
        }
        private void LotInformationByProductID()
        {
            try
            {
                String ItemID = cbo_product.Text.Trim();
                String StorageSite = cbo_storageSite.Text.Trim();
                String Company = cbo_Company.Text.ToString();

                txt_ProductDesc.Text = connSalesOrder.getItemDescFromItemID(ItemID);
                txt_PackSize.Text = connSalesOrder.getItemPackSizeFromItemID(ItemID);
                Decimal UnitPrice = Convert.ToDecimal(connSalesOrder.getItemUnitPriceFromItemID(cbo_product.Text));
                txt_price.Text = UnitPrice.ToString("N2");

                //connSalesOrder.sp_SHIPMENTRETURN_SELECT_RETURNDETAIL_TEMP(grid_detail, SelectedReturnID);

            }
            catch { }

        }
        private void calculateAddItemPrice()
        {
            try
            {
                decimal Price = txt_price.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_price.Text.ToString());
                decimal Quantity = txt_qty.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_qty.Text.ToString());
                String Remark = cbo_RM.Text.ToString();

                if (Remark == "PF")
                {
                    txt_amount.Text = "0.00";
                }
                else
                {
                    txt_amount.Text = (Price * Quantity).ToString("N2");
                }
            }
            catch
            {

            }
            finally
            {

            }
        }
        private void cbo_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LotInformationByProductID();
            }
        }
        private void cbo_RM_Leave(object sender, EventArgs e)
        {
            calculateAddItemPrice();
        }
        private void cbo_product_SelectedValueChanged(object sender, EventArgs e)
        {
            Initialize_Information();
            LotInformationByProductID();
        }

        private void cbo_product_TextUpdate(object sender, EventArgs e)
        {
            Initialize_Information();
        }
       
        private void cbo_RM_SelectedValueChanged(object sender, EventArgs e)
        {
            calculateAddItemPrice();
        }
        private void txt_deliveryNumber_TextChanged(object sender, EventArgs e)
        {
            customLabel1.Text = connSalesOrder.sp_Check_NewReturn(txt_deliveryNumber.Text.ToString());

            if (customLabel1.Text.Equals("OK"))
            {
                customLabel1.Text = "YOU CAN CREATE A NEW RETURN ID WITH THIS DELIVERY NUMBER!";
                customLabel1.ForeColor = Color.Blue;
            }
            else
            {
                customLabel1.ForeColor = Color.Red;
            }
        }


        private void textBox_TextChanged(object sender, EventArgs e)
        {
            calculateAddItemPrice();
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void grid_tempReturned_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (grid_tempReturned.RowCount == 0)
            {
                grid_detail.DataSource = null;
                btn_Add.Enabled = false;
                btn_done.Enabled = false;
                btn_notReturned.Enabled = false;
            }
        }

        private void grid_returned_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (grid_returned.RowCount == 0)
            {
                grid_detail.DataSource = null;
            }
        }
    }
}
