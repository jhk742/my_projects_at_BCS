using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Lists
{
    public partial class PriceListEntry : Form
    {
        public string selectedCustomerID = "";

        public PriceListEntry()
        {
            InitializeComponent();

            grid_EntryHeader_Init();
            grid_EntryDetail_Init();

            connSalesOrder.sp_PriceListEntry_Header(grid_EntryHeader);
            connPO.cbox_getCustomerID(cbo_searchCustomerID);



            connSalesOrder.cbo_itemID(cbo_searchProductID);
            connSalesOrder.cbo_itemID(cbo_productID);
            //connPO.cbox_getCustomerID(cbo_CustomerID);
            
        }
        
        private void grid_EntryHeader_Init()
        {
            grid_EntryHeader.AutoGenerateColumns = false;
            grid_EntryHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_EntryHeader.ColumnCount = 2;

            grid_EntryHeader.Columns[0].Name = "Customer ID";
            grid_EntryHeader.Columns[0].ReadOnly = true;
            grid_EntryHeader.Columns[0].Width = 120;
            grid_EntryHeader.Columns[0].MinimumWidth = 120;
            grid_EntryHeader.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_EntryHeader.Columns[0].DataPropertyName = "CustomerID";

            grid_EntryHeader.Columns[1].Name = "Customer Name";
            grid_EntryHeader.Columns[1].ReadOnly = true;
            grid_EntryHeader.Columns[1].Width = 200;
            grid_EntryHeader.Columns[1].MinimumWidth = 200;
            grid_EntryHeader.Columns[1].DataPropertyName = "CustomerName";
            
            grid_EntryHeader.RowTemplate.Height = 20;
            grid_EntryHeader.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_EntryHeader.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_EntryHeader.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void grid_EntryDetail_Init()
        {
            grid_EntryDetail.AutoGenerateColumns = false;
            grid_EntryDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_EntryDetail.ColumnCount = 6;

            grid_EntryDetail.Columns[0].Name = "Customer ID";
            grid_EntryDetail.Columns[0].ReadOnly = true;
            grid_EntryDetail.Columns[0].Width = 40;
            grid_EntryDetail.Columns[0].MinimumWidth =40;
            grid_EntryDetail.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_EntryDetail.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_EntryDetail.Columns[0].DataPropertyName = "CustomerID";

            grid_EntryDetail.Columns[1].Name = "Product ID";
            grid_EntryDetail.Columns[1].ReadOnly = true;
            grid_EntryDetail.Columns[1].Width = 40;
            grid_EntryDetail.Columns[1].MinimumWidth = 40;
            grid_EntryDetail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_EntryDetail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_EntryDetail.Columns[1].DataPropertyName = "ProductID";

            grid_EntryDetail.Columns[2].Name = "Price";
            grid_EntryDetail.Columns[2].ReadOnly = false;
            grid_EntryDetail.Columns[2].Width = 30;
            grid_EntryDetail.Columns[2].MinimumWidth = 30;
            grid_EntryDetail.Columns[2].DefaultCellStyle.Format = "N2";
            grid_EntryDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_EntryDetail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_EntryDetail.Columns[2].DataPropertyName = "Price";

            grid_EntryDetail.Columns[3].Name = "Updated Date";
            grid_EntryDetail.Columns[3].ReadOnly = true;
            grid_EntryDetail.Columns[3].Width = 30;
            grid_EntryDetail.Columns[3].MinimumWidth = 30;
            grid_EntryDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_EntryDetail.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_EntryDetail.Columns[3].DataPropertyName = "UPDDAT_0";

            grid_EntryDetail.Columns[4].Name = "User";
            grid_EntryDetail.Columns[4].ReadOnly = true;
            grid_EntryDetail.Columns[4].Width = 30;
            grid_EntryDetail.Columns[4].MinimumWidth = 30;
            grid_EntryDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_EntryDetail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_EntryDetail.Columns[4].DataPropertyName = "UPDUSR_0";

            grid_EntryDetail.Columns[5].Name = "ROWID";
            grid_EntryDetail.Columns[5].Visible = false;
            grid_EntryDetail.Columns[5].ReadOnly = true;
            grid_EntryDetail.Columns[5].Width = 30;
            grid_EntryDetail.Columns[5].MinimumWidth = 30;
            grid_EntryDetail.Columns[5].DataPropertyName = "ROWID";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 50;
            deleteButton.MinimumWidth = 50;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_EntryDetail.Columns["Delete"] == null)
            {
                grid_EntryDetail.Columns.Insert(6, deleteButton);
            }

            //grid font size custom
            grid_EntryDetail.RowTemplate.Height = 20;
            grid_EntryDetail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_EntryDetail.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            } 
            grid_EntryDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        
        private void grid_EntryDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0) // Delete button
            {
                //MessageBox.Show(e.RowIndex.ToString().Trim());
                DialogResult dialogResult = MessageBox.Show("Are you sure deleting product from this order?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int ROWID = Convert.ToInt32(grid_EntryDetail.Rows[e.RowIndex].Cells["ROWID"].Value.ToString().Trim());
                    connSalesOrder.sp_PriceListEntry_DELETE(ROWID);

                    grid_EntryDetail.Rows.RemoveAt(e.RowIndex);
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }
        

        private void grid_EntryDetail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.grid_EntryDetail.Rows)
            {
                row.Cells["Item ID"].Style.BackColor = Color.OldLace;
                row.Cells["Price"].Style.BackColor = Color.OldLace;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            connSalesOrder.sp_PriceListEntry_Header(grid_EntryHeader);
            grid_EntryDetail.DataSource = null;
           
        }
        

        private void cbo_ItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //NewLine = true;
            try
            {
                //MessageBox.Show(grid_EntryDetail.DataSource == null ? "null" : grid_EntryDetail.DataSource.ToString());
                String ItemID = cbo_productID.Text.Trim();
                grid_EntryDetail.CurrentRow.Cells["Item ID"].Value = ItemID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
             
        }
        
        private void btn_search_Click(object sender, EventArgs e)
        {
            searchCustomer();
        }

        private void cbo_searchCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchCustomer();
            }
            
        }

        private void searchCustomer()
        {
            String CustomerID = cbo_searchCustomerID.Text.Trim();

            for (int i = 0; i < grid_EntryHeader.RowCount - 1; i++)
            {
                string str = grid_EntryHeader.Rows[i].Cells["Customer ID"].Value.ToString().Trim();

                //if (str == "")
                //{
                //    str = "XXXXX";
                //}
                //string substr = str.Substring(str.Length - 5);
                ////MessageBox.Show(substr);

                if (str == CustomerID)//(substr.Contains(DeliveryNumber))
                {
                    grid_EntryHeader.CurrentCell = grid_EntryHeader[1, i];
                    break;
                }
            }
        }
        

        private void grid_EntryHeader_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            String CustomerID = grid_EntryHeader.Rows[e.RowIndex].Cells["Customer ID"].Value.ToString().Trim();
            selectedCustomerID = CustomerID;
            connSalesOrder.sp_PriceListEntry_Detail(grid_EntryDetail, CustomerID);
        }

        private void grid_EntryDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_EntryDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_EntryDetail.Columns[e.ColumnIndex].Name == "Price")
            {
                int ROWID = Convert.ToInt32(grid_EntryDetail.Rows[e.RowIndex].Cells["ROWID"].Value.ToString().Trim());
                decimal Price = Convert.ToDecimal(grid_EntryDetail.Rows[e.RowIndex].Cells["Price"].Value.ToString().Trim());

                connSalesOrder.sp_PriceListEntry_UPDATE_Price(ROWID, Price);

                grid_EntryDetail.Rows[e.RowIndex].Cells["Updated Date"].Value = DateTime.Now.ToString("MM/dd/yyyy");
                grid_EntryDetail.Rows[e.RowIndex].Cells["User"].Value = GATE.userID;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(cbo_productID.Text.Trim() == "")
            {
                MessageBox.Show("Please input product ID."
                                                    , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            decimal value;
            if (!Decimal.TryParse(txt_price.Text.Trim(), out value))
            {
                MessageBox.Show("Please input valid values"
                                                    , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            String CustomerID = selectedCustomerID;
            String ProductID = cbo_productID.Text.Trim();
            Decimal Price = Convert.ToDecimal(txt_price.Text.Trim());
            String INSERT = connSalesOrder.sp_PriceListEntry_INSERT(CustomerID, ProductID, Price);
            if(INSERT == "YES")
            {
                connSalesOrder.sp_PriceListEntry_Detail(grid_EntryDetail, CustomerID);
                
            }
            else
            {
                MessageBox.Show("The product ID already exists."
                                                    , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            for (int i = 0; i < grid_EntryDetail.RowCount - 1; i++)
            {
                string str = grid_EntryDetail.Rows[i].Cells["Product ID"].Value.ToString().Trim();

                //if (str == "")
                //{
                //    str = "XXXXX";
                //}
                //string substr = str.Substring(str.Length - 5);
                ////MessageBox.Show(substr);

                if (str == ProductID)//(substr.Contains(DeliveryNumber))
                {
                    grid_EntryDetail.CurrentCell = grid_EntryDetail[1, i];
                    break;
                }
            }

        }
        

        private void cbo_searchProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String ProductID = cbo_searchProductID.Text.Trim();

                for (int i = 0; i < grid_EntryDetail.RowCount - 1; i++)
                {
                    string str = grid_EntryDetail.Rows[i].Cells["Product ID"].Value.ToString().Trim();

                    //if (str == "")
                    //{
                    //    str = "XXXXX";
                    //}
                    //string substr = str.Substring(str.Length - 5);
                    ////MessageBox.Show(substr);

                    if (str == ProductID)//(substr.Contains(DeliveryNumber))
                    {
                        grid_EntryDetail.CurrentCell = grid_EntryDetail[1, i];
                        break;
                    }
                }
            }
        }
    }
}
