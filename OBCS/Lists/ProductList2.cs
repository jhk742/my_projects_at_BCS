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
    public partial class ProductList2 : Form
    {
        public ProductList2()
        {
            InitializeComponent();

            grid_customer_Init();

            String Branch = cbo_branch.Text.Trim();
            String SalesPerson = cbo_salesPerson.Text.Trim();
            String CustomerID = txt_product.Text.Trim();
            String CompanyName = txt_product.Text.Trim();
            String Active = "";

            connSalesOrder.sp_LIST_PRODUCT(grid_customer, Branch, SalesPerson, CustomerID, CompanyName, Active);
        }

        private void grid_customer_Init()
        {
            grid_customer.AutoGenerateColumns = false;
            grid_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_customer.ColumnCount = 12;

            grid_customer.Columns[0].Name = "";
            grid_customer.Columns[0].Visible = false;
            grid_customer.Columns[0].Width = 80;
            grid_customer.Columns[0].MinimumWidth = 80;
            grid_customer.Columns[0].DataPropertyName = "";

            grid_customer.Columns[1].Name = "Product Key";
            grid_customer.Columns[1].ReadOnly = true;
            grid_customer.Columns[1].Width = 50;
            grid_customer.Columns[1].MinimumWidth = 50;
            grid_customer.Columns[1].DataPropertyName = "ProductKey";

            grid_customer.Columns[2].Name = "Product ID";
            grid_customer.Columns[2].ReadOnly = true;
            grid_customer.Columns[2].Width = 80;
            grid_customer.Columns[2].MinimumWidth = 80;
            grid_customer.Columns[2].DataPropertyName = "ProductID";

            grid_customer.Columns[3].Name = "Product Description";
            grid_customer.Columns[3].ReadOnly = true;
            grid_customer.Columns[3].Width = 230;
            grid_customer.Columns[3].DataPropertyName = "ProductDesc";

            grid_customer.Columns[4].Name = "Pack Size";
            grid_customer.Columns[4].ReadOnly = true;
            grid_customer.Columns[4].Width = 75;
            grid_customer.Columns[4].MinimumWidth = 75;
            grid_customer.Columns[4].DataPropertyName = "StrPackSize";

            grid_customer.Columns[5].Name = "List Price";
            grid_customer.Columns[5].ReadOnly = true;
            grid_customer.Columns[5].Width = 60;
            grid_customer.Columns[5].MinimumWidth = 60;
            grid_customer.Columns[5].DataPropertyName = "UnitPr";

            grid_customer.Columns[6].Name = "Bottom Price";
            grid_customer.Columns[6].ReadOnly = true;
            grid_customer.Columns[6].Width = 60;
            grid_customer.Columns[6].MinimumWidth = 60;
            grid_customer.Columns[6].DataPropertyName = "BottomPr";

            grid_customer.Columns[7].Name = "COGS";
            grid_customer.Columns[7].ReadOnly = true;
            grid_customer.Columns[7].Width = 60;
            grid_customer.Columns[7].MinimumWidth = 60;
            grid_customer.Columns[7].DataPropertyName = "COGS";

            grid_customer.Columns[8].Name = "Onhand";
            grid_customer.Columns[8].ReadOnly = true;
            grid_customer.Columns[8].Width = 70;
            grid_customer.Columns[8].MinimumWidth = 70;
            grid_customer.Columns[8].DataPropertyName = "Onhand";

            grid_customer.Columns[9].Name = "Gauranteed Day";
            grid_customer.Columns[9].ReadOnly = true;
            grid_customer.Columns[9].Width = 75;
            grid_customer.Columns[9].MinimumWidth = 75;
            grid_customer.Columns[9].DataPropertyName = "GauranteedDay";

            grid_customer.Columns[10].Name = "Korsher";
            grid_customer.Columns[10].ReadOnly = true;
            grid_customer.Columns[10].Width = 75;
            grid_customer.Columns[10].Width = 75;
            grid_customer.Columns[10].DataPropertyName = "FlgKosher";

            grid_customer.Columns[11].Name = "FlgOrganic";
            grid_customer.Columns[11].ReadOnly = true;
            grid_customer.Columns[11].Width = 80;
            grid_customer.Columns[11].MinimumWidth = 80;
            grid_customer.Columns[11].DefaultCellStyle.Format = "N2";
            grid_customer.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_customer.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_customer.Columns[11].DataPropertyName = "FlgOrganic";
            

            connPO.sp_TemporaryPurchaseOrderList(grid_customer);
            //grid font size custom
            grid_customer.RowTemplate.Height = 20;

            foreach (DataGridViewColumn c in grid_customer.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Regular);
            }
            grid_customer.ColumnHeadersHeight = 30;
            grid_customer.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Regular);

        }
    }
}
