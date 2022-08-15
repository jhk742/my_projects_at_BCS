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
using System.Timers;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OBCS.Lists
{
    public partial class ProductList : Form
    {
        bool userCheck;
        public ProductList()
        {
           // MessageBox.Show("ProductList");
            InitializeComponent();

            //detail grid multi line allow
            //grid_product.AllowDrop = true;
            //grid_product.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //grid_product.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            cbo_ProductCategory.Items.Clear();
            cbo_ProductCategory.Items.Add("AG");
            cbo_ProductCategory.Items.Add("AK");
            cbo_ProductCategory.Items.Add("BF");
            cbo_ProductCategory.Items.Add("CP");
            cbo_ProductCategory.Items.Add("DR");
            cbo_ProductCategory.Items.Add("EF");
            cbo_ProductCategory.Items.Add("FC");
            cbo_ProductCategory.Items.Add("FP");
            cbo_ProductCategory.Items.Add("NP");
            cbo_ProductCategory.Items.Add("ZN");

            cbo_ProductStatus.Items.Clear();
            cbo_ProductStatus.Items.Add("Active");
            cbo_ProductStatus.Items.Add("Inactive");

            cbo_CommissionCode.Items.Clear();
            connSalesOrder.sp_GET_CommissionCode(cbo_CommissionCode);

            cbo_IncentiveCode.Items.Clear();
            connSalesOrder.sp_GET_CommissionCode(cbo_IncentiveCode);


            cbo_Brand.Items.Clear();
            connSalesOrder.sp_GET_ALLBrandCode(cbo_Brand);

            cbo_SalesUnit.Items.Clear();
            connSalesOrder.sp_GET_SalesUnit(cbo_SalesUnit);

            cbo_PurchaseUnit.Items.Clear();
            connSalesOrder.sp_GET_PurchaseUnit(cbo_PurchaseUnit);

            cbo_supplierID.Items.Clear();
            connPO.sp_GET_SUPPLIER(cbo_supplierID);

            cbx_SearchBrand.Items.Clear();
            connSalesOrder.sp_GET_ALLBrandCode(cbx_SearchBrand);

            if (connSalesOrder.sp_LIST_PRODUCT_UserCheck() == "0")
            {
                userCheck = false;
                btn_new.Enabled = false;
                btn_save.Enabled = false;
                btn_newSave.Enabled = false;
                btn_addSupplier.Enabled = false;
            }
            else
            {
                userCheck = true;
            }

            //picture box
            pictureBox1.Image = null;

        }

        private void grid_product_Init()
        {
            grid_product.AutoGenerateColumns = false;
            //grid_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_product.ColumnCount = 17;

            grid_product.Columns[0].Name = "";
            grid_product.Columns[0].Visible = false;
            grid_product.Columns[0].Width = 80;
            grid_product.Columns[0].MinimumWidth = 80;
            grid_product.Columns[0].DataPropertyName = "";

            grid_product.Columns[1].Name = "Product Key";
            grid_product.Columns[1].ReadOnly = true;
            grid_product.Columns[1].Width = 50;
            grid_product.Columns[1].MinimumWidth = 50;
            grid_product.Columns[1].DataPropertyName = "ProductKey";

            grid_product.Columns[2].Name = "Product ID";
            grid_product.Columns[2].ReadOnly = true;
            grid_product.Columns[2].Width = 70;
            grid_product.Columns[2].MinimumWidth = 70;
            grid_product.Columns[2].DataPropertyName = "ProductID";

            grid_product.Columns[3].Name = "Description";
            grid_product.Columns[3].ReadOnly = true;
            grid_product.Columns[3].Width = 300;
            grid_product.Columns[3].MinimumWidth = 200;
            grid_product.Columns[3].DataPropertyName = "ProductDesc";

            grid_product.Columns[4].Name = "Pack Size";
            grid_product.Columns[4].ReadOnly = true;
            grid_product.Columns[4].Width = 60;
            grid_product.Columns[4].MinimumWidth = 75;
            grid_product.Columns[4].DataPropertyName = "StrPackSize";

            grid_product.Columns[5].Name = "Product Status";
            grid_product.Columns[5].ReadOnly = true;
            grid_product.Columns[5].Visible = false;
            grid_product.Columns[5].Width = 50;
            grid_product.Columns[5].MinimumWidth = 65;
            grid_product.Columns[5].DataPropertyName = "IsInActive";

            grid_product.Columns[6].Name = "List Price";
            grid_product.Columns[6].ReadOnly = true;
            grid_product.Columns[6].Width = 50;
            grid_product.Columns[6].MinimumWidth = 50;
            grid_product.Columns[6].DefaultCellStyle.Format = "N2";
            grid_product.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[6].DataPropertyName = "UnitPr";

            grid_product.Columns[7].Name = "Minimum Price";
            grid_product.Columns[7].ReadOnly = true;
            grid_product.Columns[7].Width = 50;
            grid_product.Columns[7].MinimumWidth = 50;
            grid_product.Columns[7].DefaultCellStyle.Format = "N2";
            grid_product.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[7].DataPropertyName = "BottomPr";

            grid_product.Columns[8].Name = "COGS";
            grid_product.Columns[8].ReadOnly = true;
            grid_product.Columns[8].Width = 60;
            grid_product.Columns[8].MinimumWidth = 60;
            grid_product.Columns[8].DataPropertyName = "";
            grid_product.Columns[8].Visible = false;

            grid_product.Columns[9].Name = "NJ Physical Qty";
            grid_product.Columns[9].ReadOnly = true;
            grid_product.Columns[9].Width = 55;
            grid_product.Columns[9].MinimumWidth = 60;
            grid_product.Columns[9].DefaultCellStyle.Format = "N2";
            grid_product.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[9].DataPropertyName = "PHYQTYWH";

            grid_product.Columns[10].Name = "NY Physical Qty";
            grid_product.Columns[10].ReadOnly = true;
            grid_product.Columns[10].Width = 55;
            grid_product.Columns[10].MinimumWidth = 60;
            grid_product.Columns[10].DefaultCellStyle.Format = "N2";
            grid_product.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[10].DataPropertyName = "PHYQTY";

            grid_product.Columns[11].Name = "Global allocated Qty";
            grid_product.Columns[11].ReadOnly = true;
            grid_product.Columns[11].Width = 55;
            grid_product.Columns[11].MinimumWidth = 60;
            grid_product.Columns[11].DefaultCellStyle.Format = "N2";
            grid_product.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[11].DataPropertyName = "GLOALL";

            grid_product.Columns[12].Name = "Detailed allocated Qty";
            grid_product.Columns[12].ReadOnly = true;
            grid_product.Columns[12].Width = 55;
            grid_product.Columns[12].MinimumWidth = 60;
            grid_product.Columns[12].DefaultCellStyle.Format = "N2";
            grid_product.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[12].DataPropertyName = "DETAILED";

            grid_product.Columns[13].Name = "Onhand";
            grid_product.Columns[13].ReadOnly = true;
            grid_product.Columns[13].Width = 55;
            grid_product.Columns[13].MinimumWidth = 60;
            grid_product.Columns[13].DefaultCellStyle.Format = "N2";
            grid_product.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[13].DataPropertyName = "Onhand";

            grid_product.Columns[14].Name = "Guarantee Day";
            grid_product.Columns[14].ReadOnly = true;
            grid_product.Columns[14].Width = 65;
            grid_product.Columns[14].MinimumWidth = 65;
            grid_product.Columns[14].DefaultCellStyle.Format = "N2";
            grid_product.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_product.Columns[14].DataPropertyName = "GuaranteeDay";

            grid_product.Columns[15].Name = "Status";
            grid_product.Columns[15].ReadOnly = true;
            grid_product.Columns[15].Width = 60;
            grid_product.Columns[15].MinimumWidth = 60;
            grid_product.Columns[15].DefaultCellStyle.Format = "N2";
            grid_product.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_product.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_product.Columns[15].DataPropertyName = "IsInActive";

            grid_product.Columns[16].Name = "FlgPause";
            grid_product.Columns[16].ReadOnly = true;
            grid_product.Columns[16].Width = 60;
            grid_product.Columns[16].MinimumWidth = 60;
            grid_product.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_product.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_product.Columns[16].DataPropertyName = "FlgPause";
            grid_product.Columns[16].Visible = false;


            //grid font size custom
            grid_product.RowTemplate.Height = 20;
            grid_product.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_product.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_product.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_supplier_Init()
        {
            grid_supplier.AutoGenerateColumns = false;
            grid_supplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_supplier.ColumnCount = 4;

            grid_supplier.Columns[0].Name = "";
            grid_supplier.Columns[0].Visible = false;
            grid_supplier.Columns[0].Width = 80;
            grid_supplier.Columns[0].MinimumWidth = 80;
            grid_supplier.Columns[0].DataPropertyName = "";

            grid_supplier.Columns[1].Name = "Supplier";
            grid_supplier.Columns[1].Visible = false;
            grid_supplier.Columns[1].Width = 60;
            grid_supplier.Columns[1].MinimumWidth = 60;
            grid_supplier.Columns[1].DataPropertyName = "";

            grid_supplier.Columns[2].Name = "Supplier Name";
            grid_supplier.Columns[2].ReadOnly = true;
            grid_supplier.Columns[2].Width = 200;
            grid_supplier.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_supplier.Columns[2].DataPropertyName = "SupplierName";

            grid_supplier.Columns[3].Name = "Supplier Item Code";
            grid_supplier.Columns[3].ReadOnly = true;
            grid_supplier.Columns[3].Width = 80;
            grid_supplier.Columns[3].MinimumWidth = 80;
            grid_supplier.Columns[3].DataPropertyName = "SupplierProductCode";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 60;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_supplier.Columns["Delete"] == null)
            {
                grid_supplier.Columns.Insert(4, deleteButton);
            }
            if (userCheck == false)
                deleteButton.Visible = false;

            //grid font size custom
            grid_supplier.RowTemplate.Height = 20;
            grid_supplier.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_supplier.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_supplier.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        String occupied;
        bool bOccupied = false;
        private void grid_product_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ProductObject productObject = new ProductObject();

            String ProductKey = grid_product.Rows[e.RowIndex].Cells["Product Key"].Value.ToString().Trim();
            productObject = connSalesOrder.sp_GET_ProductObject(ProductKey);

            cbo_ProductCategory.Text = productObject.CdPackDeptTypeCode;
            if(productObject.IsInActive == "False")
            {
                cbo_ProductStatus.Text = "Active";
            }
            else
            {
                cbo_ProductStatus.Text = "Inactive";
            }
            
            cbo_Brand.Text = productObject.Brand;

            if(productObject.FlgPause == "1")
            {
                cbx_ProductPause.Checked = true;
            }
            else
            {
                cbx_ProductPause.Checked = false;
            }
            
            txt_ProductKey.Text = productObject.ProductKey;
            txt_ProductID.Text = productObject.ProductID;
            txt_ProductDescription.Text = productObject.ProductDesc;
            txt_pack.Text = productObject.ItemPack.ToString();
            txt_size.Text = productObject.ItemSize.ToString();
            txt_unit.Text = productObject.ItemSizeUnit;
            txt_packSize.Text = productObject.StrPackSize;
            cbo_SalesUnit.Text = productObject.SalesUnit;
            txt_salesListPrice.Text = productObject.UnitPr.ToString("N2");
            txt_salesBottomPrice.Text = productObject.BottomPr.ToString("N2");
            txt_shelfLife.Text = productObject.ShelfLife;
            txt_guaranteeDay.Text = productObject.GuaranteeDay.ToString();
            cbo_PurchaseUnit.Text = productObject.PurchaseUnit;
            txt_purchaseStockConversion.Text = productObject.StockConversionQty.ToString();
            txt_palletTier.Text = productObject.PalletTier.ToString();
            txt_palletHeight.Text = productObject.PalletHeight.ToString();
            txt_basePrice.Text = productObject.BasePrice.ToString();
            txt_pickName.Text = productObject.PickName;
            txt_pickUPC.Text = productObject.PickBarCode;
            txt_pieceUPC.Text = productObject.UPCUnit;
            txt_boxUPC.Text = productObject.UPCBox;
            txt_masterUPC.Text = productObject.UPCCase;
            cbo_CommissionCode.Text = productObject.CommissionCode1;
            cbo_IncentiveCode.Text = productObject.IncentiveCode1;
            txt_locationID.Text = productObject.LOCID;
            txt_location2.Text = productObject.LOCID2;
            txt_subPickZone.Text = productObject.SubPickZone;
            txt_kosherLabel.Text = productObject.KosherLabel1;
            txt_cheeseNumber.Text = productObject.CheeseNumber;
            txt_receivingUPC.Text = productObject.ReceivingUPC;

            if (productObject.Organic == "1")
            {
                cbx_organic.Checked = true;
            }
            else
            {
                cbx_organic.Checked = false;
            }

            if (productObject.Vegan == "1")
            {
                cbx_vegan.Checked = true;
            }
            else
            {
                cbx_vegan.Checked = false;
            }

            if (productObject.GlutenFree == "1")
            {
                cbx_glutenFree.Checked = true;
            }
            else
            {
                cbx_glutenFree.Checked = false;
            }

            if (productObject.NonGMO == "1")
            {
                cbx_nonGMO.Checked = true;
            }
            else
            {
                cbx_nonGMO.Checked = false;
            }

            if (productObject.Kosher == "1")
            {
                cbx_kosher.Checked = true;
            }
            else
            {
                cbx_kosher.Checked = false;
            }
            
            connPO.sp_LIST_PRODUCT_Supplier(grid_supplier, productObject.ProductID);

            btn_save.Enabled = true;
            btn_newSave.Visible = false;
            if (userCheck == false)
            {
                btn_new.Enabled = false;
                btn_save.Enabled = false;
                btn_newSave.Enabled = false;
            }
            else
            {
                btn_new.Enabled = true;
            }

            txt_ProductID.Enabled = false;
            if (GATE.userID != "ADMIN")
            {
                //txt_ProductDescription.Enabled = false;
                //txt_packSize.Enabled = false;
                //txt_pack.Enabled = false;
                //txt_size.Enabled = false;
                //txt_unit.Enabled = false;
                //cbo_SalesUnit.Enabled = false;
                txt_purchaseStockConversion.Enabled = false;
                cbo_PurchaseUnit.Enabled = false;
            }


            pan_packagenut.Visible = false;


            cbo_supplierID.Text = "";
            txt_supplierProductCode.Text = "";
            pan_supplier.Visible = true;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Confirming update product, "+ txt_ProductID.Text.Trim() + " information."
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    ProductObject productObject = new ProductObject();

                    productObject.CdPackDeptTypeCode = cbo_ProductCategory.Text.Trim();
                    if (cbo_ProductStatus.Text.Trim() == "Active")
                    {
                        productObject.IsInActive = "False";
                    }
                    else
                    {
                        productObject.IsInActive = "True";

                        int ProductKey = Convert.ToInt32(txt_ProductKey.Text.Trim());
                        if (connSalesOrder.sp_GET_GLOALL(ProductKey) > 0)
                        {
                            MessageBox.Show("This product " + txt_ProductID.Text.Trim() + " has been global allocated."
                                                                    , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        if (connSalesOrder.sp_GET_DETAILED(ProductKey) > 0)
                        {
                            MessageBox.Show("This product " + txt_ProductID.Text.Trim() + " has been detail allocated."
                                                                    , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }

                    productObject.Brand = cbo_Brand.Text.Trim();
                    if (cbx_ProductPause.Checked)
                    {
                        productObject.FlgPause = "1";
                    }
                    else
                    {
                        productObject.FlgPause = "0";
                    }

                    productObject.ProductKey = txt_ProductKey.Text.Trim();
                    productObject.ProductID = txt_ProductID.Text.Trim();
                    productObject.ProductDesc = txt_ProductDescription.Text.Trim();
                    productObject.ItemPack = Convert.ToDecimal(txt_pack.Text.Trim());
                    productObject.ItemSize = Convert.ToDecimal(txt_size.Text.Trim());
                    productObject.ItemSizeUnit = txt_unit.Text.Trim();
                    productObject.StrPackSize = txt_packSize.Text.Trim();
                    productObject.SalesUnit = cbo_SalesUnit.Text.Trim();
                    productObject.UnitPr = Convert.ToDecimal(txt_salesListPrice.Text.Trim());
                    productObject.BottomPr = Convert.ToDecimal(txt_salesBottomPrice.Text.Trim());
                    productObject.ShelfLife = txt_shelfLife.Text.Trim();
                    productObject.GuaranteeDay = Convert.ToDecimal(txt_guaranteeDay.Text.Trim());
                    //txt_leadTime.Text = "";
                    productObject.PurchaseUnit = cbo_PurchaseUnit.Text.Trim();
                    productObject.StockConversionQty = Convert.ToDecimal(txt_purchaseStockConversion.Text.Trim());
                    productObject.PalletTier = Convert.ToDecimal(txt_palletTier.Text.Trim());
                    productObject.PalletHeight = Convert.ToDecimal(txt_palletHeight.Text.Trim());
                    productObject.BasePrice = Convert.ToDecimal(txt_basePrice.Text.Trim());
                    productObject.PickName = txt_pickName.Text.Trim();
                    productObject.PickBarCode = txt_pickUPC.Text.Trim();
                    productObject.UPCUnit = txt_pieceUPC.Text.Trim();
                    productObject.UPCBox = txt_boxUPC.Text.Trim();
                    productObject.UPCCase = txt_masterUPC.Text.Trim();
                    productObject.CommissionCode1 = cbo_CommissionCode.Text.Trim();
                    productObject.IncentiveCode1 = cbo_IncentiveCode.Text.Trim();
                    productObject.LOCID = txt_locationID.Text.Trim();
                    productObject.LOCID2 = txt_location2.Text.Trim();
                    productObject.SubPickZone = txt_subPickZone.Text.Trim();
                    productObject.KosherLabel1 = txt_kosherLabel.Text.Trim();
                    productObject.CheeseNumber = txt_cheeseNumber.Text.Trim();
                    productObject.ReceivingUPC = txt_receivingUPC.Text.Trim();

                    if (cbx_organic.Checked)
                    {
                        productObject.Organic = "1";
                    }
                    else
                    {
                        productObject.Organic = "0";
                    }

                    if (cbx_vegan.Checked)
                    {
                        productObject.Vegan = "1";
                    }
                    else
                    {
                        productObject.Vegan = "0";
                    }

                    if (cbx_glutenFree.Checked)
                    {
                        productObject.GlutenFree = "1";
                    }
                    else
                    {
                        productObject.GlutenFree = "0";
                    }

                    if (cbx_nonGMO.Checked)
                    {
                        productObject.NonGMO = "1";
                    }
                    else
                    {
                        productObject.NonGMO = "0";
                    }

                    if (cbx_kosher.Checked)
                    {
                        productObject.Kosher = "1";
                    }
                    else
                    {
                        productObject.Kosher = "0";
                    }

                    String ReturnMessage = connSalesOrder.sp_UPDATE_ProductInfo(productObject);
                    MessageBox.Show(ReturnMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshinformation(txt_ProductKey.Text.Trim());
                }
                catch
                {

                }
                
            }
            

        }

        private void refreshinformation(String ProductKey)
        {
            ProductObject productObject = new ProductObject();

            //String ProductKey = txt_ProductKey.Text.Trim();
            productObject = connSalesOrder.sp_GET_ProductObject(ProductKey);

            cbo_ProductCategory.Text = productObject.CdPackDeptTypeCode;
            if (productObject.IsInActive == "False")
            {
                cbo_ProductStatus.Text = "Active";
            }
            else
            {
                cbo_ProductStatus.Text = "Inactive";
            }

            cbo_Brand.Text = productObject.Brand;

            if (productObject.FlgPause == "1")
            {
                cbx_ProductPause.Checked = true;
            }
            else
            {
                cbx_ProductPause.Checked = false;
            }

            txt_ProductKey.Text = productObject.ProductKey;
            txt_ProductID.Text = productObject.ProductID;
            txt_ProductDescription.Text = productObject.ProductDesc;
            txt_pack.Text = productObject.ItemPack.ToString();
            txt_size.Text = productObject.ItemSize.ToString();
            txt_unit.Text = productObject.ItemSizeUnit;
            txt_packSize.Text = productObject.StrPackSize;
            cbo_SalesUnit.Text = productObject.SalesUnit;
            txt_salesListPrice.Text = productObject.UnitPr.ToString("N2");
            txt_salesBottomPrice.Text = productObject.BottomPr.ToString("N2");
            txt_shelfLife.Text = productObject.ShelfLife;
            txt_guaranteeDay.Text = productObject.GuaranteeDay.ToString();
            cbo_PurchaseUnit.Text = productObject.PurchaseUnit;
            txt_purchaseStockConversion.Text = productObject.StockConversionQty.ToString();
            txt_palletTier.Text = productObject.PalletTier.ToString();
            txt_palletHeight.Text = productObject.PalletHeight.ToString();
            txt_basePrice.Text = productObject.BasePrice.ToString();
            txt_pickName.Text = productObject.PickName;
            txt_pickUPC.Text = productObject.PickBarCode;
            txt_pieceUPC.Text = productObject.UPCUnit;
            txt_masterUPC.Text = productObject.UPCCase;
            cbo_CommissionCode.Text = productObject.CommissionCode1;
            cbo_IncentiveCode.Text = productObject.IncentiveCode1;
            txt_locationID.Text = productObject.LOCID;
            txt_location2.Text = productObject.LOCID2;
            txt_subPickZone.Text = productObject.SubPickZone;
            txt_kosherLabel.Text = productObject.KosherLabel1;
            txt_cheeseNumber.Text = productObject.CheeseNumber;
            txt_receivingUPC.Text = productObject.ReceivingUPC;

            if (productObject.Organic == "1")
            {
                cbx_organic.Checked = true;
            }
            else
            {
                cbx_organic.Checked = false;
            }

            if (productObject.Vegan == "1")
            {
                cbx_vegan.Checked = true;
            }
            else
            {
                cbx_vegan.Checked = false;
            }

            if (productObject.GlutenFree == "1")
            {
                cbx_glutenFree.Checked = true;
            }
            else
            {
                cbx_glutenFree.Checked = false;
            }

            if (productObject.NonGMO == "1")
            {
                cbx_nonGMO.Checked = true;
            }
            else
            {
                cbx_nonGMO.Checked = false;
            }

            if (productObject.Kosher == "1")
            {
                cbx_kosher.Checked = true;
            }
            else
            {
                cbx_kosher.Checked = false;
            }

            connPO.sp_LIST_PRODUCT_Supplier(grid_supplier, productObject.ProductID);

            btn_save.Enabled = true;
            btn_newSave.Visible = false;
            if (userCheck == false)
            {
                btn_new.Enabled = false;
                btn_save.Enabled = false;
                btn_newSave.Enabled = false;
            }
            else
            {
                btn_new.Enabled = true;
            }

            txt_ProductID.Enabled = false;
            if (GATE.userID != "ADMIN")
            {
                //txt_ProductDescription.Enabled = false;
                //txt_packSize.Enabled = false;
                //txt_pack.Enabled = false;
                //txt_size.Enabled = false;
                //txt_unit.Enabled = false;
                //cbo_SalesUnit.Enabled = false;
                txt_purchaseStockConversion.Enabled = false;
                cbo_PurchaseUnit.Enabled = false;
            }


            cbo_supplierID.Text = "";
            txt_supplierProductCode.Text = "";
            pan_supplier.Visible = true;
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
            String SearchProductID = txt_searchProductID.Text.Trim();
            String SearchProductDesc = txt_searchProductDesc.Text.Trim();
            String SearchBrand = cbx_SearchBrand.Text.Trim();
            String SearchInactive = "Active";
            String SearchPause = "NotPause";
            if (cbx_inactive.Checked) SearchInactive = "ALL";
            if (cbx_Pause.Checked) SearchPause = "Pause";

            connPO.sp_LIST_Product(grid_product, SearchProductID, SearchBrand, SearchProductDesc, SearchInactive, SearchPause);
            Color_SetUp();
        }

        private void cbx_inactive_CheckedChanged(object sender, EventArgs e)
        {
            searchProduct();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Duplicate product info?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                
                txt_ProductKey.Text = "";
                txt_ProductID.Text = "";

                MessageBox.Show("Please insert suppplier information about new product."
                                                        , "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(dialogResult == DialogResult.No)
            {
                cbo_ProductCategory.Text = "";
                cbo_ProductStatus.Text = "";
                cbo_Brand.Text = "";
                cbx_ProductPause.Checked = false;
                cbo_ProductCategory.Text = "";
                txt_ProductKey.Text = "";
                txt_ProductID.Text = "";
                txt_ProductDescription.Text = "";
                txt_pack.Text = "";
                txt_size.Text = "";
                txt_unit.Text = "";
                txt_packSize.Text = "";
                cbo_SalesUnit.Text = "";
                txt_salesListPrice.Text = "";
                txt_salesBottomPrice.Text = "";
                txt_shelfLife.Text = "";
                txt_guaranteeDay.Text = "";
                cbo_PurchaseUnit.Text = "";
                txt_purchaseStockConversion.Text = "";
                txt_palletTier.Text = "";
                txt_palletHeight.Text = "";
                txt_basePrice.Text = "";
                txt_pickName.Text = "";
                txt_pickUPC.Text = "";
                txt_pieceUPC.Text = "";
                txt_masterUPC.Text = "";
                cbo_CommissionCode.Text = "";
                cbo_IncentiveCode.Text = "";
                txt_locationID.Text = "";
                txt_subPickZone.Text = "";
                txt_kosherLabel.Text = "";
                txt_cheeseNumber.Text = "";
                cbx_organic.Checked = false;
                cbx_vegan.Checked = false;
                cbx_glutenFree.Checked = false;
                cbx_nonGMO.Checked = false;
                cbx_kosher.Checked = false;
            
            }
            txt_ProductID.Enabled = true;
            if (GATE.userID != "ADMIN")
            {
                //txt_ProductDescription.Enabled = true;
                //txt_packSize.Enabled = true;
                //txt_pack.Enabled = true;
                // txt_size.Enabled = true;
                //txt_unit.Enabled = true;
                //cbo_SalesUnit.Enabled = true;
                txt_purchaseStockConversion.Enabled = true;
                cbo_PurchaseUnit.Enabled = true;
            }
                

            grid_supplier.DataSource = null;

            btn_save.Enabled = false;
            btn_newSave.Visible = true;

            btn_new.Enabled = false;
            pan_supplier.Visible = false;

            if(cbo_ProductCategory.Text.Trim()=="CP")
            {
                txt_pckName1.Text = "";
                txt_pckName2.Text = "";
                txt_pckUPC.Text = "";
                txt_pckContainerSize.Text = "";
                txt_pckNetOZ.Text = "";
                txt_pckNetLB.Text = "";
                txt_pckIngredient.Text = "";
                pan_packagenut.Visible = true;
            }
        }

        private void btn_addSupplier_Click(object sender, EventArgs e)
        {
            String ProductID = txt_ProductID.Text.Trim();
            String Supplier = cbo_supplierID.Text.Trim();
            String SupplierProductCode = txt_supplierProductCode.Text.Trim();
            try
            {
                connSalesOrder.sp_INSERT_ITMBPS(ProductID, Supplier, SupplierProductCode);
                connPO.sp_LIST_PRODUCT_Supplier(grid_supplier, ProductID);

                cbo_supplierID.Text = "";
                txt_supplierProductCode.Text = "";
                
            }
            catch
            {
                MessageBox.Show("4"
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
        }

        private void grid_supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(userCheck)
            {
                if (e.ColumnIndex == 4 && e.RowIndex >= 0) // Delete button
                {
                    //MessageBox.Show(e.RowIndex.ToString().Trim());
                    DialogResult dialogResult = MessageBox.Show("Are you sure deleting supplier from this list?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            String ProductID = txt_ProductID.Text.Trim();
                            String Supplier = grid_supplier.Rows[e.RowIndex].Cells["Supplier Name"].Value.ToString().Trim();
                            String SupplierProductCode = grid_supplier.Rows[e.RowIndex].Cells["Supplier Item Code"].Value.ToString().Trim();
                            connSalesOrder.sp_DELETE_ITMBPS(ProductID, Supplier);

                            grid_supplier.Rows.RemoveAt(e.RowIndex);

                            cbo_supplierID.Text = Supplier;
                            txt_supplierProductCode.Text = SupplierProductCode;
                        }
                        catch
                        {

                        }

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                }
            }
           
        }

        private void btn_newSave_Click(object sender, EventArgs e)
        {
            if (txt_ProductID.Text.Trim() == "")
            {
                MessageBox.Show("Please insert Product ID", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (connSalesOrder.sp_CHECK_NewProductID(txt_ProductID.Text.Trim()) == true)
            {
                MessageBox.Show("Product id already exist.", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (cbo_ProductCategory.Text.Trim() == "CP" && 
                    (
                        txt_pckName1.Text.Trim() == "" ||
                        txt_pckName2.Text.Trim() == "" ||
                        txt_pckUPC.Text.Trim() == "" ||
                        txt_pckContainerSize.Text.Trim() == "" ||
                        txt_pckNetOZ.Text.Trim() == "" ||
                        txt_pckNetLB.Text.Trim() == "" ||
                        txt_pckIngredient.Text.Trim() == ""
                    )
               )
            {
                MessageBox.Show("Please input all package nut information below.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Save a new product?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    ProductObject productObject = new ProductObject();

                    productObject.CdPackDeptTypeCode = cbo_ProductCategory.Text.Trim();
                    if (cbo_ProductStatus.Text.Trim() == "Active")
                    {
                        productObject.IsInActive = "False";
                    }
                    else
                    {
                        productObject.IsInActive = "True";
                    }

                    productObject.Brand = cbo_Brand.Text.Trim();
                    if (cbx_ProductPause.Checked)
                    {
                        productObject.FlgPause = "1";
                    }
                    else
                    {
                        productObject.FlgPause = "0";
                    }

                    productObject.ProductID = txt_ProductID.Text.Trim();
                    productObject.ProductDesc = txt_ProductDescription.Text.Trim();
                    productObject.ItemPack = Convert.ToDecimal(txt_pack.Text.Trim());
                    productObject.ItemSize = Convert.ToDecimal(txt_size.Text.Trim());
                    productObject.ItemSizeUnit = txt_unit.Text.Trim();
                    productObject.StrPackSize = txt_packSize.Text.Trim();
                    productObject.SalesUnit = cbo_SalesUnit.Text.Trim();
                    productObject.UnitPr = Convert.ToDecimal(txt_salesListPrice.Text.Trim());
                    productObject.BottomPr = Convert.ToDecimal(txt_salesBottomPrice.Text.Trim());
                    productObject.ShelfLife = txt_shelfLife.Text.Trim();
                    productObject.GuaranteeDay = Convert.ToDecimal(txt_guaranteeDay.Text.Trim());
                    productObject.PurchaseUnit = cbo_PurchaseUnit.Text.Trim();
                    productObject.StockConversionQty = Convert.ToDecimal(txt_purchaseStockConversion.Text.Trim());
                    productObject.PalletTier = Convert.ToDecimal(txt_palletTier.Text.Trim());
                    productObject.PalletHeight = Convert.ToDecimal(txt_palletHeight.Text.Trim());
                    productObject.BasePrice = Convert.ToDecimal(txt_basePrice.Text.Trim());
                    productObject.PickName = txt_pickName.Text.Trim();
                    productObject.PickBarCode = txt_pickUPC.Text.Trim();
                    productObject.UPCUnit = txt_pieceUPC.Text.Trim();
                    productObject.UPCBox = txt_boxUPC.Text.Trim();
                    productObject.UPCCase = txt_masterUPC.Text.Trim();
                    productObject.CommissionCode1 = cbo_CommissionCode.Text.Trim();
                    productObject.IncentiveCode1 = cbo_IncentiveCode.Text.Trim();
                    productObject.LOCID = txt_locationID.Text.Trim();
                    productObject.LOCID2 = txt_location2.Text.Trim();
                    productObject.SubPickZone = txt_subPickZone.Text.Trim();
                    productObject.KosherLabel1 = txt_kosherLabel.Text.Trim();
                    productObject.CheeseNumber = txt_cheeseNumber.Text.Trim();
                    productObject.PCKName1 = txt_pckName1.Text.Trim();
                    productObject.PCKName2 = txt_pckName2.Text.Trim();
                    productObject.PCKUPC = txt_pckUPC.Text.Trim();
                    productObject.PCKContSize = txt_pckContainerSize.Text.Trim();
                    productObject.PCKNetOZ = txt_pckNetOZ.Text.Trim();
                    productObject.PCKNetLB = txt_pckNetLB.Text.Trim();
                    productObject.PCKIngredient = txt_pckIngredient.Text.Trim();
                    productObject.ReceivingUPC = txt_receivingUPC.Text.Trim();

                    if (cbx_organic.Checked)
                    {
                        productObject.Organic = "1";
                    }
                    else
                    {
                        productObject.Organic = "0";
                    }

                    if (cbx_vegan.Checked)
                    {
                        productObject.Vegan = "1";
                    }
                    else
                    {
                        productObject.Vegan = "0";
                    }

                    if (cbx_glutenFree.Checked)
                    {
                        productObject.GlutenFree = "1";
                    }
                    else
                    {
                        productObject.GlutenFree = "0";
                    }

                    if (cbx_nonGMO.Checked)
                    {
                        productObject.NonGMO = "1";
                    }
                    else
                    {
                        productObject.NonGMO = "0";
                    }

                    if (cbx_kosher.Checked)
                    {
                        productObject.Kosher = "1";
                    }
                    else
                    {
                        productObject.Kosher = "0";
                    }

                    connSalesOrder.sp_INSERT_NewProduct(productObject);

                    MessageBox.Show("Product, " + productObject.ProductID + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Input all product information."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            
        }

        //private void grid_product_RowLeave(object sender, DataGridViewCellEventArgs e)
        //{
            
        //    try
        //    {   
        //        MessageBox.Show(bOccupied.ToString());
        //        if (bOccupied == false)
        //        {
        //            MessageBox.Show("Release");
        //            String RefNumber = "";
        //            RefNumber = "P" + grid_product.Rows[e.RowIndex].Cells["Product Key"].Value.ToString().Trim();
        //            connSalesOrder.sp_OCCUPIED_RELEASE(RefNumber);
        //            bOccupied = false;
        //        }
 
        //    }
        //    catch
        //    {
                
        //    }
            
            

        //}

        //private void grid_product_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {   
        //        if(started == true)
        //        {
        //            String RefNumber = "";
        //            //MessageBox.Show("grid_product_CellEnter");
        //            RefNumber = "P" + grid_product.Rows[e.RowIndex].Cells["Product Key"].Value.ToString().Trim();
        //            occupied = connSalesOrder.sp_OCCUPIED_CHECK(RefNumber);

        //            if (occupied == "Occupying")
        //            {

        //                btn_save.Enabled = false;
        //                MessageBox.Show("Someone occupying this reference number.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //                bOccupied = true;
        //            }
        //            else
        //            {
        //                bOccupied = false;
        //            }
        //        }
                
        //    }
        //    catch
        //    {

        //    }
            
            
        //}

        private void ProductList_Load(object sender, EventArgs e)
        {
            
            //MessageBox.Show("ProductList_Load");
            grid_product_Init();
            grid_supplier_Init();

            String SearchProductID = txt_searchProductID.Text.Trim();
            String SearchProductDesc = txt_searchProductDesc.Text.Trim();
            String SearchBrand = cbx_SearchBrand.Text.Trim();
            String SearchInactive = "Active";
            String SearchPause = "NotPause";
            if (cbx_inactive.Checked) SearchInactive = "ALL";
            if (cbx_Pause.Checked) SearchPause = "Pause";

            connPO.sp_LIST_Product(grid_product, SearchProductID, SearchBrand, SearchProductDesc, SearchInactive, SearchPause);



            Color_SetUp();
        }
        bool started = false;
        private void ProductList_Activated(object sender, EventArgs e)
        {
            started = true;
        }

        private void ProductList_Deactivate(object sender, EventArgs e)
        {
            started = false;
        }
        
        private void cbo_ProductCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if(txt_ProductID.Enabled == true && cbo_ProductCategory.Text.Trim() =="CP")
            {
                pan_packagenut.Visible = true;
            }
            else
            {
                pan_packagenut.Visible = false;
            }
        }

        private void Color_SetUp()
        {
            try
            {
                foreach (DataGridViewRow row in this.grid_product.Rows)
                {
                    if (row.Cells["Status"].Value.Equals("Inactive"))
                    {
                        for (int i = 0; i < grid_product.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Gray;
                        }
                    }
                    else if (row.Cells["FlgPause"].Value.Equals("1"))
                    {
                        for (int i = 0; i < grid_product.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Orange;
                        }
                    }
                    else if (row.Cells["Status"].Value.Equals("Inactive") && row.Cells["FlgPause"].Value.Equals("1"))
                    {
                        for (int i = 0; i < grid_product.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Gray;
                        }
                    }
                }
            }
            catch { }
        }

        private void cbx_Pause_CheckedChanged(object sender, EventArgs e)
        {
            searchProduct();
        }

        private void cbx_SearchBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchProduct();
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            String SearchProductID = txt_searchProductID.Text.Trim();
            String SearchProductDesc = txt_searchProductDesc.Text.Trim();
            String SearchBrand = cbx_SearchBrand.Text.Trim();
            String SearchInactive = "Active";
            String SearchPause = "NotPause";
            String Onhand = "NotPause";
            String Warehouse = "";

            

            if (cbx_inactive.Checked) SearchInactive = "ALL";
            if (cbx_Pause.Checked) SearchPause = "Pause";
            if (cbx_onhand.Checked) Onhand = "true"; else Onhand = "false";
            if (cbx_warehouse.Checked) Warehouse = "true"; else Warehouse = "false";

            //connPO.sp_LIST_Product(grid_product, SearchProductID, SearchBrand, SearchProductDesc, SearchInactive, SearchPause);

            Reports.Rpt_ProductList rpt_ProductList = new Reports.Rpt_ProductList(SearchProductID, SearchProductDesc, SearchBrand, SearchInactive, SearchPause, Onhand, Warehouse);
            rpt_ProductList.Show();
        }

        private void grid_product_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 11 && e.RowIndex >= 0 && GATE.userID == "ADMIN") // Delete button
            {
                Decimal GlobalQty = Convert.ToDecimal(grid_product.Rows[e.RowIndex].Cells["Global Allocated Qty"].Value.ToString().Trim());

                if (GlobalQty == 0)
                {
                    MessageBox.Show("There is no global allocated Qty.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    String ProductID = grid_product.Rows[e.RowIndex].Cells["Product ID"].Value.ToString().Trim();
                    String ProductDesc = grid_product.Rows[e.RowIndex].Cells["Description"].Value.ToString().Trim();

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.GetType() == typeof(GlobalAllocated))
                        {
                            form.Activate();
                            form.WindowState = FormWindowState.Normal;
                            form.BringToFront();
                            //form.Close();
                            //return;
                        }
                    }
                    GlobalAllocated globalAllocated = new GlobalAllocated(ProductID, ProductDesc);
                    globalAllocated.Show();
                }


            }
            
        }

        private static System.Timers.Timer aTimer = new System.Timers.Timer();


        private void btn_copyDesc_Click(object sender, EventArgs e)
        {
            btn_copyDesc.Text = "Copy desc. to clipboard";
            btn_copyDesc.ForeColor = Color.Black;
            aTimer.Stop();

            Clipboard.SetText(txt_ProductDescription.Text.Trim());
            btn_copyDesc.Text = "✔️Copied to clipboard";
            btn_copyDesc.ForeColor = Color.Green;

            aTimer.Start();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimerEvent);
            aTimer.Interval = 2000;
            aTimer.Enabled = true;
            
            //MessageBox.Show("Product Description was successfully copied.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            btn_copyDesc.Text = "Copy desc. to clipboard";
            btn_copyDesc.ForeColor = Color.Black;
            
        }

        private static System.Timers.Timer aTimer2 = new System.Timers.Timer();
        private void btn_copyPackSize_Click(object sender, EventArgs e)
        {
            btn_copyPackSize.Text = "Copy";
            btn_copyPackSize.ForeColor = Color.Black;
            aTimer2.Stop();

            Clipboard.SetText(txt_packSize.Text.Trim());
            btn_copyPackSize.Text = "✔️";
            btn_copyPackSize.ForeColor = Color.Green;

            aTimer2.Start();
            aTimer2.Elapsed += new ElapsedEventHandler(OnTimerEvent2);
            aTimer2.Interval = 2000;
            aTimer2.Enabled = true;
        }

        private void OnTimerEvent2(object sender, EventArgs e)
        {
            btn_copyPackSize.Text = "Copy";
            btn_copyPackSize.ForeColor = Color.Black;

        }

        private void txt_ProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
        
        private void txt_ProductID_TextChanged(object sender, EventArgs e)
        {
            txt_ProductID.Text = Regex.Replace(txt_ProductID.Text, @"\s", "");
        }

        private void cbx_onhand_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_onhand.Checked)
            {
                cbx_onhand.Checked = true;
                cbx_warehouse.Checked = false;
            }
            
        }

        private void cbx_warehouse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_warehouse.Checked)
            {
                cbx_onhand.Checked = false;
                cbx_warehouse.Checked = true;
            }
        }
    }
}
