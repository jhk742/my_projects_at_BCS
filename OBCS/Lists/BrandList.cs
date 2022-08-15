using OBCS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OBCS.Lists
{
    public partial class BrandList : Form
    {
        public BrandList()
        {
            InitializeComponent();

            //detail grid multi line allow
            //grid_product.AllowDrop = true;
            //grid_product.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //grid_product.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            grid_brand_Init();

            String SearchBrandCode = txt_searchBrandCode.Text.Trim();
            String SearchBrandDesc = txt_searchBrandDesc.Text.Trim();
            String SearchInactive = "";

            if (cbx_inactive.Checked)
            {
                SearchInactive = "ALL";
            }
            else
            {
                SearchInactive = "Active";
            }

            connPO.sp_LIST_BRAND(grid_brand, SearchBrandCode, SearchBrandDesc, SearchInactive);

            cbo_BrandStatus.Items.Clear();
            cbo_BrandStatus.Items.Add("Active");
            cbo_BrandStatus.Items.Add("Inactive");
            
        }

        private void grid_brand_Init()
        {
            grid_brand.AutoGenerateColumns = false;
            grid_brand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_brand.ColumnCount = 6;

            grid_brand.Columns[0].Name = "";
            grid_brand.Columns[0].Visible = false;
            grid_brand.Columns[0].Width = 80;
            grid_brand.Columns[0].MinimumWidth = 80;
            grid_brand.Columns[0].DataPropertyName = "";

            grid_brand.Columns[1].Name = "Brand Code";
            grid_brand.Columns[1].ReadOnly = true;
            grid_brand.Columns[1].Width = 50;
            grid_brand.Columns[1].MinimumWidth = 50;
            grid_brand.Columns[1].DataPropertyName = "BrandCode";

            grid_brand.Columns[2].Name = "Brand Name";
            grid_brand.Columns[2].ReadOnly = true;
            grid_brand.Columns[2].Width = 120;
            grid_brand.Columns[2].MinimumWidth = 120;
            grid_brand.Columns[2].DataPropertyName = "BrandName";

            grid_brand.Columns[3].Name = "Lead Time";
            grid_brand.Columns[3].ReadOnly = true;
            grid_brand.Columns[3].Width = 40;
            grid_brand.Columns[3].MinimumWidth = 40;
            grid_brand.Columns[3].DataPropertyName = "LeadTime";

            grid_brand.Columns[4].Name = "Brand Status";
            grid_brand.Columns[4].ReadOnly = true;
            grid_brand.Columns[4].Width = 50;
            grid_brand.Columns[4].MinimumWidth = 50;
            grid_brand.Columns[4].DataPropertyName = "BrandStatus";

            grid_brand.Columns[5].Name = "Brand Memo";
            grid_brand.Columns[5].ReadOnly = true;
            grid_brand.Columns[5].Width = 200;
            grid_brand.Columns[5].MinimumWidth = 200;
            grid_brand.Columns[5].DataPropertyName = "BrandMemo";

            //grid font size custom
            grid_brand.RowTemplate.Height = 20;
            grid_brand.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_brand.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_brand.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        
        private void grid_product_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String BrandCode = grid_brand.Rows[e.RowIndex].Cells["Brand Code"].Value.ToString().Trim();
            String BrandName = grid_brand.Rows[e.RowIndex].Cells["Brand Name"].Value.ToString().Trim();
            String LeadTime = grid_brand.Rows[e.RowIndex].Cells["Lead Time"].Value.ToString().Trim();
            String BrandStatus = grid_brand.Rows[e.RowIndex].Cells["Brand Status"].Value.ToString().Trim();
            String BrandMemo = grid_brand.Rows[e.RowIndex].Cells["Brand Memo"].Value.ToString().Trim();

            txt_leadTime.Text = LeadTime;
            cbo_BrandStatus.Text = BrandStatus;
            txt_BrandCode.Text = BrandCode;
            txt_BrandName.Text = BrandName;
            txt_BrandMemo.Text = BrandMemo;

            btn_save.Enabled = true;
            btn_new.Enabled = true;
            txt_BrandCode.Enabled = false;
            txt_BrandName.Enabled = false;
            btn_newSave.Visible = false;
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirming update product, " + txt_BrandName.Text.Trim() + " information."
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                
                String BrandCode = txt_BrandCode.Text.Trim();
                String BrandName = txt_BrandName.Text.Trim();
                int LeadTime = Convert.ToInt32(txt_leadTime.Text.Trim());
                String BrandStatus = cbo_BrandStatus.Text.Trim();
                String BrandMemo = txt_BrandMemo.Text.Trim();
                
                connSalesOrder.sp_UPDATE_BrandInfo(BrandCode, BrandName, LeadTime, BrandStatus, BrandMemo);

                MessageBox.Show("Brand, " + BrandName + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void txt_searchProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchProduct();
            }
        }

        private void txt_searchProductDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchProduct();
            }
        }

        private void searchProduct()
        {
            String SearchBrandCode = txt_searchBrandCode.Text.Trim();
            String SearchBrandDesc = txt_searchBrandDesc.Text.Trim();
            String SearchInactive = "";

            if (cbx_inactive.Checked)
            {
                SearchInactive = "ALL";
            }
            else
            {
                SearchInactive = "Active";
            }

            connPO.sp_LIST_BRAND(grid_brand, SearchBrandCode, SearchBrandDesc, SearchInactive);
            Color_SetUp();
        }

        private void cbx_inactive_CheckedChanged(object sender, EventArgs e)
        {
            searchProduct();
        }

        private void BrandList_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = false;
            btn_new.Enabled = false;
            txt_BrandCode.Enabled = true;
            txt_BrandName.Enabled = true;
            txt_leadTime.Text = "";
            cbo_BrandStatus.Text = "";
            txt_BrandCode.Text = "";
            txt_BrandName.Text = "";
            txt_BrandMemo.Text = "";
            btn_newSave.Visible = true;

            btn_save.Enabled = false;
            btn_new.Enabled = false;

        }

        private void btn_newSave_Click(object sender, EventArgs e)
        {
            if(connSalesOrder.sp_CHECK_NewBrandCode(txt_BrandCode.Text.Trim()) == true )
            {
                MessageBox.Show("Brand code already exist."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (connSalesOrder.sp_CHECK_NewBrandName(txt_BrandName.Text.Trim()) == true)
            {
                MessageBox.Show("Brand name already exist."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            try
            {
                String BrandCode = txt_BrandCode.Text.Trim();
                String BrandName = txt_BrandName.Text.Trim();
                int LeadTime = Convert.ToInt32(txt_leadTime.Text.Trim());
                String BrandMemo = txt_BrandMemo.Text.Trim();
                String BrandStatus = cbo_BrandStatus.Text.Trim();

                connSalesOrder.sp_INSERT_NewBrand(BrandCode, BrandName, LeadTime, BrandStatus, BrandMemo);

                btn_newSave.Visible = false;
            }
            catch
            {
                MessageBox.Show("Input all brand information."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
           
        }

        private void Color_SetUp()
        {
            try
            {
                foreach (DataGridViewRow row in this.grid_brand.Rows)
                {
                    if (row.Cells["Brand Status"].Value.Equals("Inactive"))
                    {
                        for (int i = 0; i < grid_brand.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Gray;
                        }
                    }
                }
            }
            catch { }
        }

        private void txt_BrandCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_BrandCode_TextChanged(object sender, EventArgs e)
        {
            txt_BrandCode.Text = Regex.Replace(txt_BrandCode.Text, @"\s", "");
        }
    }
}
