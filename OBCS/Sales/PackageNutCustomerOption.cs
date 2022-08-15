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
    public partial class PackageNutCustomerOption : Form
    {
        public PackageNutCustomerOption()
        {
            InitializeComponent();

            grid_List_Init();
            grid_Customer_Init();

            connPO.cbox_getCustomerID(cbo_customerID);
            connSalesOrder.sp_GET_PackageNutProduct(cbo_productID);
            connSalesOrder.sp_GET_PackageNutProduct(cbo_searchProductID);
            connSalesOrder.sp_GET_PackageNutCustomerOption_Customer(grid_customer);

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
            grid_List.ColumnCount = 10;

            grid_List.Columns[0].Name = "Product ID";
            grid_List.Columns[0].ReadOnly = true;
            grid_List.Columns[0].Visible = true;
            grid_List.Columns[0].Width = 90;
            grid_List.Columns[0].MinimumWidth = 90;
            grid_List.Columns[0].DataPropertyName = "ITMREF";

            grid_List.Columns[1].Name = "Name 1";
            grid_List.Columns[1].ReadOnly = true;
            grid_List.Columns[1].Width = 150;
            grid_List.Columns[1].MinimumWidth = 150;
            grid_List.Columns[1].DataPropertyName = "NAMELN01";

            grid_List.Columns[2].Name = "Name 2";
            grid_List.Columns[2].ReadOnly = true;
            grid_List.Columns[2].Width = 150;
            grid_List.Columns[2].MinimumWidth = 150;
            grid_List.Columns[2].DataPropertyName = "NAMELN02";

            grid_List.Columns[3].Name = "UPC";
            grid_List.Columns[3].ReadOnly = true;
            grid_List.Columns[3].Width = 100;
            grid_List.Columns[3].MinimumWidth = 100;
            grid_List.Columns[3].DataPropertyName = "UPC";

            grid_List.Columns[4].Name = "Size";
            grid_List.Columns[4].ReadOnly = true;
            grid_List.Columns[4].Width = 55;
            grid_List.Columns[4].MinimumWidth = 55;
            grid_List.Columns[4].DefaultCellStyle.Format = "N2";
            grid_List.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_List.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_List.Columns[4].DataPropertyName = "CONTSIZE";

            grid_List.Columns[5].Name = "Retail Price";
            grid_List.Columns[5].ReadOnly = true;
            grid_List.Columns[5].Width = 45;
            grid_List.Columns[5].MinimumWidth = 45;
            grid_List.Columns[5].DefaultCellStyle.Format = "N2";
            grid_List.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_List.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_List.Columns[5].DataPropertyName = "RETAILPR";

            grid_List.Columns[6].Name = "Net OZ";
            grid_List.Columns[6].ReadOnly = true;
            grid_List.Columns[6].MinimumWidth = 40;
            grid_List.Columns[6].MinimumWidth = 40;
            grid_List.Columns[6].DefaultCellStyle.Format = "N2";
            grid_List.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_List.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_List.Columns[6].DataPropertyName = "NETWTOZ";

            grid_List.Columns[7].Name = "Net GR";
            grid_List.Columns[7].Visible = false;
            grid_List.Columns[7].MinimumWidth = 40;
            grid_List.Columns[7].MinimumWidth = 40;
            grid_List.Columns[7].DataPropertyName = "";

            grid_List.Columns[8].Name = "NET LB";
            grid_List.Columns[8].ReadOnly = true;
            grid_List.Columns[8].MinimumWidth = 40;
            grid_List.Columns[8].MinimumWidth = 40;
            grid_List.Columns[8].DefaultCellStyle.Format = "N2";
            grid_List.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_List.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_List.Columns[8].DataPropertyName = "NETWTLB";

            grid_List.Columns[9].Name = "Ingredient";
            grid_List.Columns[9].ReadOnly = true;
            grid_List.Columns[9].Visible = false;
            grid_List.Columns[9].MinimumWidth = 40;
            grid_List.Columns[9].MinimumWidth = 40;
            grid_List.Columns[9].DataPropertyName = "Ingredient";


            //grid font size custom
            grid_List.RowTemplate.Height = 20;
            grid_List.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_List.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_List.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void sp_PackageNutCustomerOption_Detail(String CustomerID)
        {
            connSalesOrder.sp_PackageNutCustomerOption_Detail(grid_List, CustomerID);
        }

        private void grid_customer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String CustomerID = grid_customer.Rows[e.RowIndex].Cells["Customer ID"].Value.ToString().Trim();
            sp_PackageNutCustomerOption_Detail(CustomerID);
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
            txt_pckName1.Text = "";
            txt_pckName2.Text = "";
            txt_pckUPC.Text = "";
            txt_pckContainerSize.Text = "";
            txt_pckRetailPrice.Text = "";
            txt_pckNetOZ.Text = "";
            txt_pckNetLB.Text = "";
            txt_pckIngredient.Text = "";



            String ProductID = grid_List.Rows[e.RowIndex].Cells["Product ID"].Value.ToString().Trim();
            String Name1 = grid_List.Rows[e.RowIndex].Cells["Name 1"].Value.ToString().Trim();
            //MessageBox.Show(Name1);
            String Name2 = grid_List.Rows[e.RowIndex].Cells["Name 2"].Value.ToString().Trim();
            String UPC = grid_List.Rows[e.RowIndex].Cells["UPC"].Value.ToString().Trim();
            String Size = grid_List.Rows[e.RowIndex].Cells["Size"].Value.ToString().Trim();
            String RetailPrice = grid_List.Rows[e.RowIndex].Cells["Retail Price"].Value.ToString().Trim();
            String NetOZ = grid_List.Rows[e.RowIndex].Cells["Net OZ"].Value.ToString().Trim();
            String NetLB = grid_List.Rows[e.RowIndex].Cells["Net LB"].Value.ToString().Trim();
            String Ingredient = grid_List.Rows[e.RowIndex].Cells["Ingredient"].Value.ToString().Trim();

            cbo_productID.Text = ProductID;
            txt_pckName1.Text = Name1;
            txt_pckName2.Text = Name2;
            txt_pckUPC.Text = UPC;
            txt_pckContainerSize.Text = Size;
            txt_pckRetailPrice.Text = RetailPrice;
            txt_pckNetOZ.Text = NetOZ;
            txt_pckNetLB.Text = NetLB;
            txt_pckIngredient.Text = Ingredient;

            btn_add.Enabled = false;
            btn_update.Enabled = true;

        }

        private void cbo_produtID_SelectedValueChanged(object sender, EventArgs e)
        {
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
                String Name1 = txt_pckName1.Text.Trim();
                String Name2 = txt_pckName2.Text.Trim();
                String UPC = txt_pckUPC.Text.Trim();
                String ContainerSize = txt_pckContainerSize.Text.Trim();
                Decimal RetailPrice = Convert.ToDecimal(txt_pckRetailPrice.Text.Trim());
                Decimal NetOZ = Convert.ToDecimal(txt_pckNetOZ.Text.Trim());
                Decimal NetLB = Convert.ToDecimal(txt_pckNetLB.Text.Trim());
                String Ingredient = txt_pckIngredient.Text.Trim();

                connSalesOrder.sp_PackageNutCustomerOption_Update(CustomerID, ProductID, Name1, Name2, UPC, ContainerSize, RetailPrice, NetOZ, NetLB, Ingredient);

                MessageBox.Show(CustomerID + ", " + ProductID + " has been Saved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //connSalesOrder.sp_GET_PackageNutCustomerOption_Customer(grid_customer);

                //sp_PackageNutCustomerOption_Detail(CustomerID);
                grid_List.DataSource = null;


                //for (int i = 0; i < grid_customer.RowCount - 1; i++)
                //{
                //    string str = grid_customer.Rows[i].Cells["Customer ID"].Value.ToString().Trim();
                //    //MessageBox.Show(str);

                //    //MessageBox.Show(substr);

                //    if (CustomerID == str)//(substr.Contains(DeliveryNumber))
                //    {
                //        grid_customer.CurrentCell = grid_customer[0, i];
                //        break;
                //    }
                //}
            }
               
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String CustomerID = cbo_customerID.Text.Trim();
            String ProductID = cbo_productID.Text.Trim();

            bool isexist = connSalesOrder.sp_CHECK_PackageNutCustomerOption(CustomerID, ProductID);
            if (isexist)
            {
                MessageBox.Show("Can not add this product. This Route Number already has been made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure to add product information?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                String Name1 = txt_pckName1.Text.Trim();
                String Name2 = txt_pckName2.Text.Trim();
                String UPC = txt_pckUPC.Text.Trim();
                String ContainerSize = txt_pckContainerSize.Text.Trim();
                Decimal RetailPrice = Convert.ToDecimal(txt_pckRetailPrice.Text.Trim());
                Decimal NetOZ = Convert.ToDecimal(txt_pckNetOZ.Text.Trim());
                Decimal NetLB = Convert.ToDecimal(txt_pckNetLB.Text.Trim());
                String Ingredient = txt_pckIngredient.Text.Trim();

                connSalesOrder.sp_PackageNutCustomerOption_Create(CustomerID, ProductID, Name1, Name2, UPC, ContainerSize, RetailPrice, NetOZ, NetLB, Ingredient);

                MessageBox.Show(CustomerID + ", " + ProductID + " has been Saved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //
                //sp_PackageNutCustomerOption_Detail(CustomerID);

                

                //for (int i = 0; i < grid_customer.RowCount - 1; i++)
                //{
                //    string str = grid_customer.Rows[i].Cells["Customer ID"].Value.ToString().Trim();
                //    //MessageBox.Show(str);

                //    //MessageBox.Show(substr);

                //    if (CustomerID == str)//(substr.Contains(DeliveryNumber))
                //    {
                //        grid_customer.CurrentCell = grid_customer[0, i];
                //        break;
                //    }
                //}
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            connSalesOrder.sp_GET_PackageNutCustomerOption_Customer(grid_customer);
        }
    }
}
