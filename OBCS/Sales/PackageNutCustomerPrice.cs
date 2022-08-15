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
    public partial class PackageNutCustomerPrice : Form
    {
        public PackageNutCustomerPrice()
        {
            InitializeComponent();

            grid_List_Init();
            grid_Customer_Init();

            connPO.cbox_getCustomerID(cbo_customerID);
            connSalesOrder.sp_GET_PackageNutProduct(cbo_productID);
            connSalesOrder.sp_GET_PackageNutProduct(cbo_searchProductID);
            connSalesOrder.sp_GET_PackageNutCustomerPrice_Customer(grid_customer);

            btn_add.Enabled = false;
            btn_update.Enabled = true;
        }

        private void grid_Customer_Init()
        {
            grid_customer.AutoGenerateColumns = false;
            grid_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_customer.ColumnCount = 1;

            grid_customer.Columns[0].Name = "Customer ID";
            grid_customer.Columns[0].ReadOnly = true;
            grid_customer.Columns[0].Visible = true;
            grid_customer.Columns[0].Width = 90;
            grid_customer.Columns[0].MinimumWidth = 90;
            grid_customer.Columns[0].DataPropertyName = "BPCNUM";

            //grid font size custom
            grid_customer.RowTemplate.Height = 20;
            grid_customer.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_List.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_customer.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_List_Init()
        {
            grid_List.AutoGenerateColumns = false;
            grid_List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_List.ColumnCount = 4;

            grid_List.Columns[0].Name = "Product ID";
            grid_List.Columns[0].ReadOnly = true;
            grid_List.Columns[0].Visible = true;
            grid_List.Columns[0].Width = 90;
            grid_List.Columns[0].MinimumWidth = 90;
            grid_List.Columns[0].DataPropertyName = "ITMREF";

            grid_List.Columns[1].Name = "Description";
            grid_List.Columns[1].ReadOnly = true;
            grid_List.Columns[1].Width = 150;
            grid_List.Columns[1].MinimumWidth = 150;
            grid_List.Columns[1].DataPropertyName = "ProductDesc";
            
            grid_List.Columns[2].Name = "Pack Size";
            grid_List.Columns[2].ReadOnly = true;
            grid_List.Columns[2].Width = 100;
            grid_List.Columns[2].MinimumWidth = 100;
            grid_List.Columns[2].DataPropertyName = "PackSize";

            grid_List.Columns[3].Name = "Retail Price";
            grid_List.Columns[3].ReadOnly = true;
            grid_List.Columns[3].Width = 55;
            grid_List.Columns[3].MinimumWidth = 55;
            grid_List.Columns[3].DefaultCellStyle.Format = "N2";
            grid_List.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_List.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_List.Columns[3].DataPropertyName = "RETAILPR";
            
            //grid font size custom
            grid_List.RowTemplate.Height = 20;
            grid_List.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_List.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_List.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void sp_PackageNutCustomerPrice_Detail(String CustomerID)
        {
            connSalesOrder.sp_PackageNutCustomerPrice_Detail(grid_List, CustomerID);
        }

        private void grid_customer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String CustomerID = grid_customer.Rows[e.RowIndex].Cells["Customer ID"].Value.ToString().Trim();
            try
            {
                sp_PackageNutCustomerPrice_Detail(CustomerID);
            }
            catch
            {

            }
            cbo_customerID.Text = CustomerID;

        }

        private void cbo_customerID_SelectedValueChanged(object sender, EventArgs e)
        {
            //String CustomerID = cbo_customerID.Text.Trim();
            //sp_PackageNutCustomerOption_Detail(CustomerID);

            //grid_customer.ClearSelection();

            //txt_pckName1.Text = "";
            //txt_pckName2.Text = "";
            //txt_pckUPC.Text = "";
            //txt_pckContainerSize.Text = "";
            //txt_pckRetailPrice.Text = "";
            //txt_pckNetOZ.Text = "";
            //txt_pckNetLB.Text = "";
            //txt_pckIngredient.Text = "";

            btn_add.Enabled = true;
            btn_update.Enabled = false;

        }

        private void grid_List_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            cbo_productID.Text = "";
            txt_productDesc.Text = "";
            txt_packSize.Text = "";
            txt_price.Text = "";
            

            String ProductID = grid_List.Rows[e.RowIndex].Cells["Product ID"].Value.ToString().Trim();
            //String ProductDesc = grid_List.Rows[e.RowIndex].Cells["Description"].Value.ToString().Trim();
            //String PackSize = grid_List.Rows[e.RowIndex].Cells["Pack Size"].Value.ToString().Trim();
            String RetailPrice = grid_List.Rows[e.RowIndex].Cells["Retail Price"].Value.ToString().Trim();

            cbo_productID.Text = ProductID;
            //txt_productDesc.Text = ProductDesc;
            //txt_packSize.Text = PackSize;
            txt_price.Text = RetailPrice;

            btn_add.Enabled = false;
            btn_update.Enabled = true;

        }

        private void cbo_produtID_SelectedValueChanged(object sender, EventArgs e)
        {
            //cbo_productID.Text = "";
            txt_productDesc.Text = "";
            txt_packSize.Text = "";
            txt_price.Text = "";


            //String ProductID = grid_List.Rows[e.RowIndex].Cells["Product ID"].Value.ToString().Trim();
            String ProductDesc = connSalesOrder.sp_GET_PackageNutCustomerPrice_Desc(cbo_productID.Text.Trim());
            String PackSize = connSalesOrder.sp_GET_PackageNutCustomerPrice_PackSize(cbo_productID.Text.Trim());
            //String RetailPrice = grid_List.Rows[e.RowIndex].Cells["Retail Price"].Value.ToString().Trim();

            txt_productDesc.Text = ProductDesc;
            txt_packSize.Text = PackSize;

            btn_add.Enabled = true;
            btn_update.Enabled = false;
        }

        private void cbo_searchProductID_SelectedValueChanged(object sender, EventArgs e)
        {
            grid_List.ClearSelection();

            String SearchProductID = cbo_searchProductID.Text.Trim();
            
            for (int i = 0; i < grid_List.RowCount - 1; i++)
            {
                string str = grid_List.Rows[i].Cells["Product ID"].Value.ToString().Trim();
                //MessageBox.Show(str);
                
                //MessageBox.Show(substr);

                if (SearchProductID == str)//(substr.Contains(DeliveryNumber))
                {
                    grid_List.CurrentCell = grid_List[1, i];
                    break;
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to update product information?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                String CustomerID = cbo_customerID.Text.Trim();
                String ProductID = cbo_productID.Text.Trim();
                Decimal RetailPrice = Convert.ToDecimal(txt_price.Text.Trim());


                connSalesOrder.sp_PackageNutCustomerPrice_Update(CustomerID, ProductID, RetailPrice);

                MessageBox.Show(CustomerID + ", " + ProductID + " has been Saved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //connSalesOrder.sp_GET_PackageNutCustomerOption_Customer(grid_customer);

                ////sp_PackageNutCustomerOption_Detail(CustomerID);
                connSalesOrder.sp_PackageNutCustomerPrice_Detail(grid_List, CustomerID);


                ////for (int i = 0; i < grid_customer.RowCount - 1; i++)
                ////{
                ////    string str = grid_customer.Rows[i].Cells["Customer ID"].Value.ToString().Trim();
                ////    //MessageBox.Show(str);

                ////    //MessageBox.Show(substr);

                ////    if (CustomerID == str)//(substr.Contains(DeliveryNumber))
                ////    {
                ////        grid_customer.CurrentCell = grid_customer[0, i];
                ////        break;
                ////    }
                ////}
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String CustomerID = cbo_customerID.Text.Trim();
            String ProductID = cbo_productID.Text.Trim();

            bool isexist = connSalesOrder.sp_CHECK_PackageNutCustomerPrice(CustomerID, ProductID);
            if (isexist)
            {
                MessageBox.Show("Can not add this product.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure to add product information?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Decimal RetailPrice = 0;
                try
                {
                    RetailPrice = Convert.ToDecimal(txt_price.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("input decimal."
                                                        , "Confirming", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                
                connSalesOrder.sp_PackageNutCustomerPrice_Create(CustomerID, ProductID, RetailPrice);

                MessageBox.Show(CustomerID + ", " + ProductID + " has been Saved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connSalesOrder.sp_PackageNutCustomerPrice_Detail(grid_List, CustomerID);
                ////
                ////sp_PackageNutCustomerOption_Detail(CustomerID);



                ////for (int i = 0; i < grid_customer.RowCount - 1; i++)
                ////{
                ////    string str = grid_customer.Rows[i].Cells["Customer ID"].Value.ToString().Trim();
                ////    //MessageBox.Show(str);

                ////    //MessageBox.Show(substr);

                ////    if (CustomerID == str)//(substr.Contains(DeliveryNumber))
                ////    {
                ////        grid_customer.CurrentCell = grid_customer[0, i];
                ////        break;
                ////    }
                ////}
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            connSalesOrder.sp_GET_PackageNutCustomerOption_Customer(grid_customer);
        }
    }
}
