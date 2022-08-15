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
    public partial class TemporaryPurchaseOrderList : Form
    {
        public TemporaryPurchaseOrderList()
        {
            InitializeComponent();

            grid_brands_Init();
            grid_product_Init();

        }

        private void grid_brands_Init()
        {
            grid_brands.AutoGenerateColumns = false;

            grid_brands.ColumnCount = 4;

            grid_brands.Columns[0].Name = "Brand ID";
            grid_brands.Columns[0].ReadOnly = true;
            grid_brands.Columns[0].Width = 80;
            grid_brands.Columns[0].DataPropertyName = "BrandKey";

            grid_brands.Columns[1].Name = "BRAND NAME";
            grid_brands.Columns[1].ReadOnly = true;
            grid_brands.Columns[1].Width = 140;
            grid_brands.Columns[1].DataPropertyName = "BrandName";

            grid_brands.Columns[2].Name = "VENDOR ID";
            grid_brands.Columns[2].ReadOnly = true;
            grid_brands.Columns[2].Width = 140;
            grid_brands.Columns[2].DataPropertyName = "VendorID";

            grid_brands.Columns[3].Name = "VENDOR NAME";
            grid_brands.Columns[3].ReadOnly = true;
            grid_brands.Columns[3].Width = 210;
            grid_brands.Columns[3].DataPropertyName = "VendorName";

            connPO.sp_TemporaryPurchaseOrderList(grid_brands);
            //grid font size custom
            grid_brands.RowTemplate.Height = 20;

            foreach (DataGridViewColumn c in grid_brands.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Regular);
            }
            grid_brands.ColumnHeadersHeight = 30;
            grid_brands.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Regular);

        }

        private void grid_product_Init()
        {
            grid_product.AutoGenerateColumns = false;

            grid_product.ColumnCount = 8;

            grid_product.Columns[0].Name = "Brand Name";
            grid_product.Columns[0].ReadOnly = true;
            grid_product.Columns[0].Width = 140;
            grid_product.Columns[0].DataPropertyName = "BrandName";

            grid_product.Columns[1].Name = "Product";
            grid_product.Columns[1].ReadOnly = true;
            grid_product.Columns[1].Width = 70;
            grid_product.Columns[1].DataPropertyName = "ProductID";

            grid_product.Columns[2].Name = "ORD";
            grid_product.Columns[2].ReadOnly = true;
            grid_product.Columns[2].Width = 50;
            grid_product.Columns[2].DataPropertyName = "QtyReplenish";

            grid_product.Columns[3].Name = "Product Desc";
            grid_product.Columns[3].ReadOnly = true;
            grid_product.Columns[3].Width = 300;
            grid_product.Columns[3].DataPropertyName = "ProductDesc";

            grid_product.Columns[4].Name = "Pack Size";
            grid_product.Columns[4].ReadOnly = true;
            grid_product.Columns[4].Width = 80;
            grid_product.Columns[4].DataPropertyName = "StrPackSize";

            grid_product.Columns[5].Name = "PSC";
            grid_product.Columns[5].ReadOnly = true;
            grid_product.Columns[5].Width = 50;
            grid_product.Columns[5].DataPropertyName = "ItemPack";

            grid_product.Columns[6].Name = "LOQ-P";
            grid_product.Columns[6].ReadOnly = true;
            grid_product.Columns[6].Width = 50;
            grid_product.Columns[6].DataPropertyName = "LOQP";

            grid_product.Columns[7].Name = "LOQ-S";
            grid_product.Columns[7].ReadOnly = true;
            grid_product.Columns[7].Width = 50;
            grid_product.Columns[7].DataPropertyName = "LOQS";

            

            //grid font size custom
            grid_product.RowTemplate.Height = 20;

            foreach (DataGridViewColumn c in grid_product.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Regular);
            }
            grid_product.ColumnHeadersHeight = 30;
            grid_product.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Regular);

        }

        private void grid_brands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            String BrandName = grid_brands.Rows[e.RowIndex].Cells["Brand Name"].Value.ToString();
            String BrandKey = connPO.getBrandKey(BrandName);

            btn_reset.Text = "Reset " + BrandName.Trim() + " Order";
   
            connPO.sp_TemporaryPurchaseOrderList_Product(grid_product, BrandKey);
            customTextBox1.Text = BrandName;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            String BrandName = customTextBox1.Text;
            DialogResult dialogResult = MessageBox.Show("Importance Notice : Reset " + BrandName.Trim() + " Order? \n"
                                                        , "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                String BrandKey = connPO.getBrandKey(BrandName);
                connPO.sp_ResetOrder(BrandKey);
                

                connPO.sp_TemporaryPurchaseOrderList(grid_brands);
                this.grid_product.DataSource = null;

                MessageBox.Show("The P/O prepare has been reset successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
