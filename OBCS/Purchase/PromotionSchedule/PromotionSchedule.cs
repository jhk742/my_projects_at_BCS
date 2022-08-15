using OBCS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OBCS.Purchase.PromotionSchedule
{
    public partial class PromotionSchedule : Form
    {
        public PromotionSchedule()
        {
            InitializeComponent();
            grid_promotion_Init(grid_promotionSchedule);
            grid_promotion_Init(grid_expired);
            grid_promotionHeader_Init(grid_promotionScheduleH);
            grid_promotionHeader_Init(grid_expiredH);
            grid_Product_Init();


            Initial_Setting();

            search_schedule();
            search_expired();
            //add control
            panel_methods.Visible = true;
            groupbox_free.Visible = false;

            lbl_method2.Visible = false;
            txt_netPrice.Visible = false;
            txt_value2.Visible = false;
            cbo_method2.Visible = false;
            txt_netPrice.Visible = false;

            tabControl1.SelectedIndex = 1;
        }
        private void Initial_Setting(){

            ////search section (schedule)
            //brand code
            cbo_searchBrandCode.Items.Add("");
            connSalesOrder.sp_GET_ALLBrandCode(cbo_searchBrandCode);
            //product id
            cbo_searchProductID.Items.Add("");
            connSalesOrder.cbo_itemID(cbo_searchProductID);
            //promotion type
            cbo_searchPromotionType.Items.Add("");
            connSalesOrder.sp_GET_PromotionTypeCode(cbo_searchPromotionType);
            //promotion base
            cbo_searchPromotionBase.Items.Clear();
            cbo_searchPromotionBase.Items.Add("");
            cbo_searchPromotionBase.Items.Add("Order");
            cbo_searchPromotionBase.Items.Add("Ship");
            //type
            cbo_searchType.Items.Clear();
            cbo_searchType.Items.Add("");
            cbo_searchType.Items.Add("Methods");
            cbo_searchType.Items.Add("Free");

            ////TODO: search section (expired)
            //brand code
            cbo_searchExpiredBrandCode.Items.Add("");
            connSalesOrder.sp_GET_ALLBrandCode(cbo_searchExpiredBrandCode);
            //product id
            cbo_searchExpiredProductID.Items.Add("");
            connSalesOrder.cbo_itemID(cbo_searchExpiredProductID);
            //promotion type
            cbo_searchExpiredPromotionType.Items.Add("");
            connSalesOrder.sp_GET_PromotionTypeCode(cbo_searchExpiredPromotionType);
            //promotion base
            cbo_searchExpiredPromotionBase.Items.Clear();
            cbo_searchExpiredPromotionBase.Items.Add("");
            cbo_searchExpiredPromotionBase.Items.Add("Order");
            cbo_searchExpiredPromotionBase.Items.Add("Ship");
            //type
            cbo_searchExpiredType.Items.Clear();
            cbo_searchExpiredType.Items.Add("");
            cbo_searchExpiredType.Items.Add("Methods");
            cbo_searchExpiredType.Items.Add("Free");


            ////add promo info
            //brand
            connSalesOrder.sp_GET_ALLBrandCode(cbo_brand);
            //promo code
            connSalesOrder.sp_GET_PromotionTypeCode(cbo_promotionTypeCode);
            cbo_promotionTypeCode.SelectedIndex = 0;
            //promotion base
            cbo_promotionBase.Items.Clear();
            cbo_promotionBase.Items.Add("Order");
            cbo_promotionBase.Items.Add("Ship");
            cbo_promotionBase.SelectedIndex = 0;
            //product id
            //connSalesOrder.cbo_itemID(cbo_productID);
            //method1
            cbo_method1.Items.Clear();
            cbo_method1.Items.Add("%");
            cbo_method1.Items.Add("$");
            cbo_method1.SelectedIndex = 0;
            //method2
            cbo_method2.Items.Clear();
            cbo_method2.Items.Add("%");
            cbo_method2.Items.Add("$");
            cbo_method2.SelectedIndex = 0;

            dateTimePickerSearchEnd.Value = DateTime.Today.AddMonths(3);
            dateTimePickerSearchExpiredStart.Value = DateTime.Today.AddMonths(-3);
            dateTimePickerSearchExpiredEnd.Value = DateTime.Today.AddDays(-1);

            txt_value1.Text = "0";
            txt_value2.Text = "0";
            txt_buy.Text = "0";
            txt_free.Text = "0";
        }
        private void grid_promotionHeader_Init(DataGridView gridView)
        {
            gridView.AutoGenerateColumns = false;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            gridView.ColumnCount = 8;
            //detail grid multi line allow
            gridView.AllowDrop = true;
            gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            int i = 0;

            if (gridView.Name.Equals("grid_promotionScheduleH"))
            {
                DataGridViewCheckBoxColumn confirmCheck = new DataGridViewCheckBoxColumn();
                confirmCheck.HeaderText = "V";
                confirmCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                confirmCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                confirmCheck.FalseValue = false;
                confirmCheck.TrueValue = true;
                confirmCheck.Name = "CheckBox";
                confirmCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                confirmCheck.ReadOnly = true;
                confirmCheck.Width = 20;
                //confirmCheck.HeaderCell.
                confirmCheck.SortMode = DataGridViewColumnSortMode.Automatic;
                gridView.Columns.Insert(0, confirmCheck);
                gridView.CellContentClick += new DataGridViewCellEventHandler(confirmcellclick);
                i = 1;
            }

            gridView.Columns[i].Name = "No.";
            gridView.Columns[i].ReadOnly = true;
            gridView.Columns[i].Visible = false;
            gridView.Columns[i].Width = 25;
            gridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i].DataPropertyName = "";

            gridView.Columns[i + 1].Name = "Brand (Code)";
            gridView.Columns[i + 1].ReadOnly = true;
            gridView.Columns[i + 1].Width = 50;
            gridView.Columns[i + 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 1].DataPropertyName = "BrandCode";

            gridView.Columns[i + 2].Name = "Brand Name";
            gridView.Columns[i + 2].ReadOnly = true;
            gridView.Columns[i + 2].Visible = true;
            gridView.Columns[i + 2].Width = 120;
            gridView.Columns[i + 2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 2].DataPropertyName = "BrandName";

            gridView.Columns[i + 3].Name = "Start";
            gridView.Columns[i + 3].ReadOnly = true;
            gridView.Columns[i + 3].Width = 70;
            gridView.Columns[i + 3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridView.Columns[i + 3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 3].DefaultCellStyle.Format = "MM/dd/yyyy";
            gridView.Columns[i + 3].DataPropertyName = "StartDate";

            gridView.Columns[i + 4].Name = "End";
            gridView.Columns[i + 4].ReadOnly = true;
            gridView.Columns[i + 4].Width = 70;
            gridView.Columns[i + 4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridView.Columns[i + 4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 4].DefaultCellStyle.Format = "MM/dd/yyyy";
            gridView.Columns[i + 4].DataPropertyName = "EndDate";

            gridView.Columns[i + 5].Name = "Promotion Memo";
            gridView.Columns[i + 5].ReadOnly = true;
            gridView.Columns[i + 5].Width = 200;
            gridView.Columns[i + 5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 5].DataPropertyName = "PromotionMemo";

            gridView.Columns[i + 6].Name = "id";
            gridView.Columns[i + 6].ReadOnly = true;
            gridView.Columns[i + 6].Visible = false;
            gridView.Columns[i + 6].Width = 120;
            gridView.Columns[i + 6].MinimumWidth = 120;
            gridView.Columns[i + 6].DataPropertyName = "id";

            gridView.Columns[i + 7].Name = "NUM_0";
            gridView.Columns[i + 7].ReadOnly = true;
            gridView.Columns[i + 7].Visible = false;
            gridView.Columns[i + 7].Width = 120;
            gridView.Columns[i + 7].MinimumWidth = 120;
            gridView.Columns[i + 7].DataPropertyName = "NUM_0";

            //grid font size custom
            gridView.RowTemplate.Height = 20;
            gridView.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in gridView.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
            }

            gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
        }
        private void grid_promotion_Init(DataGridView gridView)
        {
            gridView.AutoGenerateColumns = false;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.ColumnCount = 19;
            //detail grid multi line allow
            gridView.AllowDrop = true;
            gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            int i = 0;

            //if (gridView.Name.Equals("grid_promotionSchedule"))
            //{
            //    DataGridViewCheckBoxColumn confirmCheck = new DataGridViewCheckBoxColumn();
            //    confirmCheck.HeaderText = "V";
            //    confirmCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //    confirmCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //    confirmCheck.FalseValue = false;
            //    confirmCheck.TrueValue = true;
            //    confirmCheck.Name = "CheckBox";
            //    confirmCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //    confirmCheck.ReadOnly = true;
            //    confirmCheck.Width = 20;
            //    //confirmCheck.HeaderCell.
            //    confirmCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            //    gridView.Columns.Insert(0, confirmCheck);
            //    gridView.CellContentClick += new DataGridViewCellEventHandler(confirmcellclick);
            //    i = 1;
            //}

            gridView.Columns[i].Name = "No.";
            gridView.Columns[i].ReadOnly = true;
            gridView.Columns[i].Width = 22;
            gridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i].DataPropertyName = "";

            gridView.Columns[i + 1].Name = "Brand (Code)";
            gridView.Columns[i + 1].ReadOnly = true;
            gridView.Columns[i + 1].Visible = false;
            gridView.Columns[i + 1].Width = 50;
            gridView.Columns[i + 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 1].DataPropertyName = "BrandCode";

            gridView.Columns[i + 2].Name = "Brand Name";
            gridView.Columns[i + 2].ReadOnly = true;
            gridView.Columns[i + 2].Visible = false;
            gridView.Columns[i + 2].Width = 120;
            gridView.Columns[i + 2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 2].DataPropertyName = "BrandName";

            gridView.Columns[i + 3].Name = "Product ID";
            gridView.Columns[i + 3].ReadOnly = true;
            gridView.Columns[i + 3].Width = 40;
            gridView.Columns[i + 3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 3].DataPropertyName = "ProductID";

            gridView.Columns[i + 4].Name = "Product Description";
            gridView.Columns[i + 4].ReadOnly = true;
            gridView.Columns[i + 4].Width = 110;
            gridView.Columns[i + 4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 4].DataPropertyName = "ProductDesc";

            gridView.Columns[i + 5].Name = "Promotion Type";
            gridView.Columns[i + 5].ReadOnly = true;
            gridView.Columns[i + 5].Width = 65;
            gridView.Columns[i + 5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridView.Columns[i + 5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 5].DataPropertyName = "PromotionTypeCode";

            gridView.Columns[i + 6].Name = "Promotion Base";
            gridView.Columns[i + 6].ReadOnly = true;
            gridView.Columns[i + 6].Width = 65;
            gridView.Columns[i + 6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridView.Columns[i + 6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 6].DataPropertyName = "PromotionBase";

            gridView.Columns[i + 7].Name = "Start";
            gridView.Columns[i + 7].ReadOnly = true;
            gridView.Columns[i + 7].Visible = false;
            gridView.Columns[i + 7].Width = 70;
            gridView.Columns[i + 7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridView.Columns[i + 7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 7].DefaultCellStyle.Format = "MM/dd/yyyy";
            gridView.Columns[i + 7].DataPropertyName = "StartDate";

            gridView.Columns[i + 8].Name = "End";
            gridView.Columns[i + 8].ReadOnly = true;
            gridView.Columns[i + 8].Visible = false;
            gridView.Columns[i + 8].Width = 70;
            gridView.Columns[i + 8].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridView.Columns[i + 8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 8].DefaultCellStyle.Format = "MM/dd/yyyy";
            gridView.Columns[i + 8].DataPropertyName = "EndDate";

            gridView.Columns[i + 9].Name = "Alert From";
            gridView.Columns[i + 9].ReadOnly = true;
            gridView.Columns[i + 9].Visible = false;
            gridView.Columns[i + 9].Width = 75;
            gridView.Columns[i + 9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 9].DataPropertyName = "AlertFrom";

            gridView.Columns[i + 10].Name = "Alert To";
            gridView.Columns[i + 10].ReadOnly = true;
            gridView.Columns[i + 10].Visible = false;
            gridView.Columns[i + 10].Width = 75;
            gridView.Columns[i + 10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 10].DataPropertyName = "AlertTo";

            gridView.Columns[i + 11].Name = "Base Price";
            gridView.Columns[i + 11].ReadOnly = true;
            gridView.Columns[i + 11].Width = 45;
            gridView.Columns[i + 11].DefaultCellStyle.Format = "N2";
            gridView.Columns[i + 11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridView.Columns[i + 11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridView.Columns[i + 11].DataPropertyName = "BasePrice";

            gridView.Columns[i + 12].Name = "Type";
            gridView.Columns[i + 12].ReadOnly = true;
            gridView.Columns[i + 12].Width = 55;
            gridView.Columns[i + 12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 12].DataPropertyName = "Type";

            gridView.Columns[i + 13].Name = "Promo1";
            gridView.Columns[i + 13].ReadOnly = true;
            gridView.Columns[i + 13].Width = 60;
            gridView.Columns[i + 13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 13].DataPropertyName = "Promo1";

            gridView.Columns[i + 14].Name = "Promo2";
            gridView.Columns[i + 14].ReadOnly = true;
            gridView.Columns[i + 14].Width = 60;
            gridView.Columns[i + 14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 14].DataPropertyName = "Promo2";

            //gridView.Columns[i + 15].Name = "Buy";
            //gridView.Columns[i + 15].ReadOnly = true;
            //gridView.Columns[i + 15].Width = 60;
            //gridView.Columns[i + 15].DefaultCellStyle.Format = "N2";
            //gridView.Columns[i + 15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //gridView.Columns[i + 15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //gridView.Columns[i + 15].DataPropertyName = "PromotionBuy";

            //gridView.Columns[i + 16].Name = "Free";
            //gridView.Columns[i + 16].ReadOnly = true;
            //gridView.Columns[i + 16].Width = 60;
            //gridView.Columns[i + 16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //gridView.Columns[i + 16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //gridView.Columns[i + 16].DataPropertyName = "PromotionFree";

            gridView.Columns[i + 15].Name = "Net Price";
            gridView.Columns[i + 15].ReadOnly = true;
            gridView.Columns[i + 15].Width = 55;
            gridView.Columns[i + 15].DefaultCellStyle.Format = "N2";
            gridView.Columns[i + 15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridView.Columns[i + 15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridView.Columns[i + 15].DataPropertyName = "NetPrice";

            gridView.Columns[i + 16].Name = "Promotion Memo";
            gridView.Columns[i + 16].ReadOnly = true;
            gridView.Columns[i + 16].Visible = false;
            gridView.Columns[i + 16].Width = 120;
            gridView.Columns[i + 16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[i + 16].DataPropertyName = "PromotionMemo";

            gridView.Columns[i + 17].Name = "id";
            gridView.Columns[i + 17].ReadOnly = true;
            gridView.Columns[i + 17].Visible = false;
            gridView.Columns[i + 17].Width = 120;
            gridView.Columns[i + 17].MinimumWidth = 120;
            gridView.Columns[i + 17].DataPropertyName = "id";

            gridView.Columns[i + 18].Name = "NUM_0";
            gridView.Columns[i + 18].ReadOnly = true;
            gridView.Columns[i + 18].Visible = false;
            gridView.Columns[i + 18].Width = 120;
            gridView.Columns[i + 18].MinimumWidth = 120;
            gridView.Columns[i + 18].DataPropertyName = "NUM_0";

            //grid font size custom
            gridView.RowTemplate.Height = 20;
            gridView.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in gridView.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
            }

            gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
        }
       
        private void grid_Product_Init()
        {
            grid_Product.AutoGenerateColumns = false;
            grid_Product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Product.ColumnCount = 15;
            //detail grid multi line allow
            grid_Product.AllowDrop = true;
            grid_Product.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_Product.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //grid_Product.DefaultCellStyle.NullValue = null;

            DataGridViewCheckBoxColumn confirmCheck = new DataGridViewCheckBoxColumn();
            confirmCheck.HeaderText = "V";
            confirmCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            confirmCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            confirmCheck.FalseValue = false;
            confirmCheck.TrueValue = true;
            confirmCheck.Name = "CheckBox";
            confirmCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            confirmCheck.ReadOnly = true;
            confirmCheck.Width = 20;
            //confirmCheck.HeaderCell.
            confirmCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            grid_Product.Columns.Insert(0, confirmCheck);
            grid_Product.CellContentClick += new DataGridViewCellEventHandler(confirmcellclick);

            grid_Product.Columns[1].Name = "ProductID";
            grid_Product.Columns[1].ReadOnly = true;
            grid_Product.Columns[1].Width = 60;
            grid_Product.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[1].DataPropertyName = "ProductID";

            grid_Product.Columns[2].Name = "ProductDesc";
            grid_Product.Columns[2].ReadOnly = true;
            grid_Product.Columns[2].Width = 150;
            grid_Product.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[2].DataPropertyName = "ProductDesc";

            grid_Product.Columns[3].Name = "PackSize";
            grid_Product.Columns[3].ReadOnly = true;
            grid_Product.Columns[3].Width = 65;
            grid_Product.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[3].DataPropertyName = "StrPackSize";

            grid_Product.Columns[4].Name = "S/U";
            grid_Product.Columns[4].ReadOnly = true;
            grid_Product.Columns[4].Width = 30;
            grid_Product.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[4].DataPropertyName = "SalesUnit";
        
            grid_Product.Columns[5].Name = "IsInActive";
            grid_Product.Columns[5].ReadOnly = true;
            grid_Product.Columns[5].Width = 30;
            grid_Product.Columns[5].MinimumWidth = 30;
            grid_Product.Columns[5].Visible = false;
            grid_Product.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[5].DataPropertyName = "IsInActive";

            grid_Product.Columns[6].Name = "UnitPr";
            grid_Product.Columns[6].ReadOnly = true;
            grid_Product.Columns[6].Width = 40;
            grid_Product.Columns[6].Visible = false;
            grid_Product.Columns[6].MinimumWidth = 40;
            grid_Product.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[6].DataPropertyName = "UnitPr";

            grid_Product.Columns[7].Name = "BottomPr";
            grid_Product.Columns[7].ReadOnly = true;
            grid_Product.Columns[7].Width = 40;
            grid_Product.Columns[7].Visible = false;
            grid_Product.Columns[7].MinimumWidth = 40;
            grid_Product.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[7].DataPropertyName = "BottomPr";

            grid_Product.Columns[8].Name = "Conv.";
            grid_Product.Columns[8].ReadOnly = true;
            grid_Product.Columns[8].Width = 40;
            grid_Product.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[8].DataPropertyName = "StockConversionQty";

            grid_Product.Columns[9].Name = "GuaranteeDay";
            grid_Product.Columns[9].ReadOnly = true;
            grid_Product.Columns[9].Width = 30;
            grid_Product.Columns[9].MinimumWidth = 30;
            grid_Product.Columns[9].Visible = false;
            grid_Product.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[9].DataPropertyName = "GuaranteeDay";

            grid_Product.Columns[10].Name = "BasePrice";
            grid_Product.Columns[10].ReadOnly = true;
            grid_Product.Columns[10].Width = 60;
            grid_Product.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[10].DataPropertyName = "BasePrice";

            //grid_Product.Columns[11].Name = "Type";
            //grid_Product.Columns[11].ReadOnly = true;
            //grid_Product.Columns[11].Width = 50;
            //grid_Product.Columns[11].MinimumWidth = 50;
            //grid_Product.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //grid_Product.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_Product.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_Product.Columns[11].DataPropertyName = "";

            
            DataGridViewComboBoxColumn cbo_Type = new DataGridViewComboBoxColumn();
            cbo_Type.HeaderText = "Types";
            cbo_Type.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cbo_Type.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cbo_Type.Name = "Types";
            cbo_Type.DataSource = new string[] { "","Method", "Free" };
            cbo_Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cbo_Type.ReadOnly = false;
            cbo_Type.Width = 65;
            cbo_Type.FlatStyle = FlatStyle.Popup;
            cbo_Type.DefaultCellStyle.BackColor = Color.Aqua;
            cbo_Type.SortMode = DataGridViewColumnSortMode.Automatic;
            grid_Product.Columns.Insert(11, cbo_Type);

            grid_Product.Columns[12].Name = "Promo1";
            grid_Product.Columns[12].ReadOnly = true;
            grid_Product.Columns[12].Width = 50;
            grid_Product.Columns[12].MinimumWidth = 50;
            grid_Product.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[12].DefaultCellStyle.Format = "N2";
            grid_Product.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[12].DataPropertyName = "";

            DataGridViewComboBoxColumn cbo_Method1 = new DataGridViewComboBoxColumn();
            cbo_Method1.HeaderText = "";
            cbo_Method1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cbo_Method1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cbo_Method1.Name = "Method1";
            cbo_Method1.DataSource = new string[] { "$","%" };
            cbo_Method1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cbo_Method1.ReadOnly = true;
            cbo_Method1.Width = 35;
            cbo_Method1.FlatStyle = FlatStyle.Popup;
            cbo_Method1.SortMode = DataGridViewColumnSortMode.Automatic;
            grid_Product.Columns.Insert(13, cbo_Method1);

            grid_Product.Columns[14].Name = "Promo2";
            grid_Product.Columns[14].ReadOnly = true;
            grid_Product.Columns[14].Width = 50;
            grid_Product.Columns[14].MinimumWidth = 50;
            grid_Product.Columns[14].DefaultCellStyle.Format = "N2";
            grid_Product.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[14].DataPropertyName = "";

            DataGridViewComboBoxColumn cbo_Method2 = new DataGridViewComboBoxColumn();
            cbo_Method2.HeaderText = "";
            cbo_Method2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cbo_Method2.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cbo_Method2.Name = "Method2";
            cbo_Method2.DataSource = new string[] { "$", "%" };
            cbo_Method2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cbo_Method2.ReadOnly = true;
            cbo_Method2.Width = 35;
            cbo_Method2.FlatStyle = FlatStyle.Popup;
            cbo_Method2.SortMode = DataGridViewColumnSortMode.Automatic;
            grid_Product.Columns.Insert(15, cbo_Method2);

            grid_Product.Columns[16].Name = "Buy";
            grid_Product.Columns[16].ReadOnly = true;
            grid_Product.Columns[16].Width = 35;
            grid_Product.Columns[16].MinimumWidth = 35;
            grid_Product.Columns[16].DefaultCellStyle.Format = "N2";
            grid_Product.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[16].DataPropertyName = "";

            grid_Product.Columns[17].Name = "Free";
            grid_Product.Columns[17].ReadOnly = true;
            grid_Product.Columns[17].Width = 35;
            grid_Product.Columns[17].MinimumWidth = 35;
            grid_Product.Columns[17].DefaultCellStyle.Format = "N2";
            grid_Product.Columns[17].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[17].DataPropertyName = "";

            grid_Product.Columns[18].Name = "Net Sales";
            grid_Product.Columns[18].ReadOnly = true;
            grid_Product.Columns[18].Width = 35;
            grid_Product.Columns[18].MinimumWidth = 35;
            grid_Product.Columns[18].DefaultCellStyle.Format = "N2";
            grid_Product.Columns[18].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_Product.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Product.Columns[18].DataPropertyName = "";

            //grid font size custom
            grid_Product.RowTemplate.Height = 20;
            grid_Product.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_Product.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
            }
            grid_Product.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
        }

        private void NetSales_Calculator(int RowIndex)
        {
            decimal BasePrice = Convert.ToDecimal(grid_Product.Rows[RowIndex].Cells[10].Value == DBNull.Value ? "0" : grid_Product.Rows[RowIndex].Cells[10].Value);
            decimal Promo1 = grid_Product.Rows[RowIndex].Cells[12].Value == DBNull.Value ? 0 : Convert.ToDecimal(grid_Product.Rows[RowIndex].Cells[12].Value);
            String Promo1Type = (grid_Product.Rows[RowIndex].Cells[13].Value == DBNull.Value ? "" : grid_Product.Rows[RowIndex].Cells[13].Value).ToString();
            decimal Promo2 = grid_Product.Rows[RowIndex].Cells[14].Value == DBNull.Value ? 0 : Convert.ToDecimal(grid_Product.Rows[RowIndex].Cells[14].Value);
            String Promo2Type = (grid_Product.Rows[RowIndex].Cells[15].Value == DBNull.Value ? "" : grid_Product.Rows[RowIndex].Cells[15].Value).ToString();

            //MessageBox.Show(Promo2 + "\n" + Promo2Type);
            decimal NetPrice = 0;

            if (Promo1Type.Equals("$")) // promo 1
            {
                NetPrice = BasePrice - Promo1;
            }
            else if (Promo1Type.Equals("%"))
            {
                NetPrice = BasePrice - (BasePrice * Promo1 / 100);
            }

            if (!grid_Product.Rows[RowIndex].Cells[15].Value.ToString().Equals("")) // Promo 2 
            {

                if (Promo2Type.Equals("$"))
                {
                    NetPrice = NetPrice - Promo2;
                }
                else if (Promo2Type.Equals("%"))
                {
                    NetPrice = NetPrice - (NetPrice * Promo2 / 100);
                }
            }
            grid_Product.Rows[RowIndex].Cells[18].Value = NetPrice;
        }

        private void btn_BatchProcessing_Click(object sender, EventArgs e)
        {
            int checknum = 0;

            String Promo1 = txt_value1.Text.Length == 0 ? "0" : txt_value1.Text.ToString();
            String Promo1Type = cbo_method1.Text.ToString();
            String Promo2 = txt_value2.Text.Length == 0 ? "0" : txt_value2.Text.ToString();
            String Promo2Type = cbo_method2.Text.ToString();
            String Buy = txt_buy.Text.Length == 0 ? "0" : txt_buy.Text.ToString();
            String Free = txt_free.Text.Length == 0 ? "0" : txt_free.Text.ToString();

            for (int i = 0; i < grid_Product.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_Product.Rows[i].Cells[0].Value) == true)
                {
                    if (rbtn_methods.Checked)
                    {
                        grid_Product.Rows[i].Cells[11].Value = "Method";
                        grid_Product.Rows[i].Cells[12].Value = Promo1;
                        grid_Product.Rows[i].Cells[13].Value = Promo1Type;
                        grid_Product.Rows[i].Cells[14].Value = Promo2;
                        grid_Product.Rows[i].Cells[15].Value = Promo2Type;

                        NetSales_Calculator(i);
                        if (Convert.ToDecimal(grid_Product.Rows[i].Cells[18].Value) < 0)
                        {
                            MessageBox.Show("net price cannot be less than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            grid_Product.Rows[i].Cells[12].Value = "0";
                            grid_Product.Rows[i].Cells[14].Value = "0";
                            grid_Product.Rows[i].Cells[18].Value = "0";
                            return;
                        }
                    }
                    else if (rbtn_free.Checked)
                    {
                        grid_Product.Rows[i].Cells[11].Value = "Free";
                        grid_Product.Rows[i].Cells[16].Value = Buy;
                        grid_Product.Rows[i].Cells[17].Value = Free;

                        grid_Product.Rows[i].Cells[18].Value = grid_Product.Rows[i].Cells[10].Value;
                    }
                    checknum++;
                }
            }

            if (checknum == 0)
            {
                MessageBox.Show("Please put a check mark first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
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
        private void btn_newSave_Click(object sender, EventArgs e)
        {
            if (grid_Product.DataSource is null)
            {
                MessageBox.Show("Please select the BRAND first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            int CheckNum = 0;
            for (int i = 0; i < grid_Product.RowCount; i++)
            {
                if (!string.IsNullOrEmpty(grid_Product.Rows[i].Cells[11].Value as string))
                {
                    CheckNum++;
                }
            }
            if (CheckNum == 0)
            {
                MessageBox.Show("Please select the Type first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure to insert promotion schedule?"
                                                , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    String PRMNumber = connSalesOrder.sp_GET_NewPRMNumber();
                    String BrandCode = cbo_brand.Text.ToString();
                    String BrandName = txt_brandName.Text.ToString();
                    DateTime StartDate = dateTimePickerStart.Value.Date;
                    DateTime EndDate = dateTimePickerEnd.Value.Date;
                    String PromotionMemo = txt_promotionMemo.Text.ToString();

                    connSalesOrder.sp_PromotionScheduleH_INSERT(PRMNumber,BrandCode,BrandName,StartDate,EndDate,PromotionMemo);
                    for (int i = 0; i < grid_Product.RowCount; i++)
                    {
                        if (!string.IsNullOrEmpty(grid_Product.Rows[i].Cells[11].Value as string))
                        {
                            Decimal BasePrice = grid_Product.Rows[i].Cells[10].Value == DBNull.Value ? Convert.ToDecimal("0") : Convert.ToDecimal(grid_Product.Rows[i].Cells[10].Value);
                            String Type = grid_Product.Rows[i].Cells[11].Value == DBNull.Value ? " " : grid_Product.Rows[i].Cells[11].Value.ToString();
                            Decimal Value1 = 0;
                            String Method1 = "%";
                            Decimal Value2 = 0;
                            String Method2 = "%";
                            Decimal Buy = 0;
                            Decimal Free = 0;
                            Decimal NetPrice = 0;

                            if (grid_Product.Rows[i].Cells[11].Value.ToString().Equals("Method"))
                            {
                                Value1 = Convert.ToDecimal(grid_Product.Rows[i].Cells[12].Value);
                                Method1 = grid_Product.Rows[i].Cells[13].Value.ToString();
                                Value2 = Convert.ToDecimal(grid_Product.Rows[i].Cells[14].Value);
                                Method2 = grid_Product.Rows[i].Cells[15].Value.ToString();
                                NetPrice = Convert.ToDecimal(grid_Product.Rows[i].Cells[18].Value);
                            }
                            else if (grid_Product.Rows[i].Cells[11].Value.ToString().Equals("Free"))
                            {
                                Buy = Convert.ToDecimal(grid_Product.Rows[i].Cells[16].Value);
                                Free = Convert.ToDecimal(grid_Product.Rows[i].Cells[17].Value);
                                NetPrice = Convert.ToDecimal(grid_Product.Rows[i].Cells[18].Value);
                            }

                            Entities.PromotionScheduleObject promotionScheduleObject = new Entities.PromotionScheduleObject();
                            promotionScheduleObject.BrandCode = BrandCode;
                            promotionScheduleObject.PromotionTypeCode = cbo_promotionTypeCode.Text.ToString();
                            promotionScheduleObject.PromotionBase = cbo_promotionBase.Text.ToString();
                            promotionScheduleObject.StartDate = StartDate;
                            promotionScheduleObject.EndDate = EndDate;
                            promotionScheduleObject.PromotionMemo = PromotionMemo;
                            promotionScheduleObject.ProductID = grid_Product.Rows[i].Cells[1].Value.ToString();
                            promotionScheduleObject.BasePrice = BasePrice;
                            promotionScheduleObject.Type = Type;
                            promotionScheduleObject.PromotionValue1 = Value1;
                            promotionScheduleObject.PromotionMethod1 = Method1;
                            promotionScheduleObject.PromotionValue2 = Value2;
                            promotionScheduleObject.PromotionMethod2 = Method2;
                            promotionScheduleObject.PromotionBuy = Buy;
                            promotionScheduleObject.PromotionFree = Free;
                            promotionScheduleObject.NetPrice = NetPrice;
                            promotionScheduleObject.Checked = "";
                            promotionScheduleObject.Status = "Active";

                            connSalesOrder.sp_PromotionSchedule_INSERT(PRMNumber,promotionScheduleObject);
                        }
                    }
                    search_schedule();
                    search_expired();

                    MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //MessageBox.Show("sp_PromotionSchedule_INSERT Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int CheckNum = 0;
            for (int i = 0; i < grid_promotionScheduleH.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_promotionScheduleH.Rows[i].Cells[0].Value) == true)
                {
                    CheckNum++;
                }
            }
            if (CheckNum == 0)
            {
                MessageBox.Show("Please put a check mark first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete promotion schedule?"
                                                , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < grid_promotionScheduleH.RowCount; i++)
                    {
                        if (Convert.ToBoolean(grid_promotionScheduleH.Rows[i].Cells[0].Value) == true)
                        {
                            String PRMNumber = grid_promotionScheduleH.Rows[i].Cells["NUM_0"].Value.ToString().Trim();
                            connSalesOrder.sp_PromotionSchedule_DELETE(PRMNumber);
                        }
                    }
                    search_schedule();
                    MessageBox.Show("Done.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("sp_PromotionSchedule_DELETE Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void PromotionSchedule_Activated(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void cbo_promotionTypeCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_promotionTypeName.Text = connSalesOrder.sp_GET_PromotionTypeNamebyCode(cbo_promotionTypeCode.Text.Trim());
        }
        private void confirmcellclick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridview = (DataGridView)sender;

            try
            {
                if (e.ColumnIndex == 0) //confirm check box click
                {
                    if (Convert.ToBoolean(gridview.Rows[e.RowIndex].Cells[0].EditedFormattedValue) == false)
                        gridview.Rows[e.RowIndex].Cells[0].Value = true;
                    else // uncheck 했을 때
                        gridview.Rows[e.RowIndex].Cells[0].Value = false;
                }

            }
            catch { }
        }
        private void cbo_brand_SelectedValueChanged(object sender, EventArgs e)
        {
            connPO.sp_GET_BrandName(cbo_brand, txt_brandName);
            connPO.sp_PromotionSchedule_ProductList(grid_Product, cbo_brand.Text.ToString());

            grid_Product.Columns[12].ReadOnly = true;
            grid_Product.Columns[13].ReadOnly = true;
            grid_Product.Columns[14].ReadOnly = true;
            grid_Product.Columns[15].ReadOnly = true;
            grid_Product.Columns[16].ReadOnly = true;
            grid_Product.Columns[17].ReadOnly = true;
        }

        private void gridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView gridview = (DataGridView)sender;
            gridview.Rows[e.RowIndex].Cells["No."].Value = (e.RowIndex + 1).ToString();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_addMethod.Checked)
            {
                lbl_netPrice.Location = new Point(lbl_netPrice.Location.X, lbl_netPrice.Location.Y + 44);
                customLabel34.Location = new Point(customLabel34.Location.X - 15, customLabel34.Location.Y);
                customLabel34.Text = "Method(1)";
                lbl_method2.Visible = true;
                txt_value2.Visible = true;
                cbo_method2.Visible = true;
            }
            else
            {
                lbl_netPrice.Location = new Point(lbl_netPrice.Location.X, lbl_netPrice.Location.Y - 44);
                customLabel34.Location = new Point(customLabel34.Location.X + 15, customLabel34.Location.Y);
                customLabel34.Text = "Method";
                lbl_method2.Visible = false;
                txt_value2.Visible = false;
                cbo_method2.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_methods.Checked)
            {
                panel_methods.Visible = true;
                groupbox_free.Visible = false;
                cbx_addMethod.Enabled = true;
                txt_value1.Text = "0";
                txt_value2.Text = "0";
            }
            else
            {
                panel_methods.Visible = false;
                groupbox_free.Visible = true;
                cbx_addMethod.Checked = false;
                cbx_addMethod.Enabled = false;
                txt_buy.Text = "0";
                txt_free.Text = "0";
            }
        }

        private void gridview_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView gridview = (DataGridView)sender;

            if (gridview.RowCount > 0)
            {
                if (e.ColumnIndex == 0)
                {
                    if (Convert.ToBoolean(gridview.Rows[1].Cells[0].EditedFormattedValue) == false)
                        for (int i = 0; i < gridview.RowCount; i++)
                            gridview.Rows[i].Cells[0].Value = true;

                    else // uncheck 했을 때
                        for (int i = 0; i < gridview.RowCount; i++)
                            gridview.Rows[i].Cells[0].Value = false;
                }
            }
        }
       
        private void grid_Product_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            { //Choose Types
                grid_Product.Rows[e.RowIndex].Cells[12].ReadOnly = true; //promo1
                grid_Product.Rows[e.RowIndex].Cells[13].ReadOnly = true; //promo1 Type
                grid_Product.Rows[e.RowIndex].Cells[14].ReadOnly = true; //promo2
                grid_Product.Rows[e.RowIndex].Cells[15].ReadOnly = true; //promo2 Type
                grid_Product.Rows[e.RowIndex].Cells[16].ReadOnly = true; //Buy
                grid_Product.Rows[e.RowIndex].Cells[17].ReadOnly = true; //Free

                grid_Product.Rows[e.RowIndex].Cells[12].Value = "";
                grid_Product.Rows[e.RowIndex].Cells[13].Value = "";
                grid_Product.Rows[e.RowIndex].Cells[14].Value = "";
                grid_Product.Rows[e.RowIndex].Cells[15].Value = "";
                grid_Product.Rows[e.RowIndex].Cells[16].Value = "";
                grid_Product.Rows[e.RowIndex].Cells[17].Value = "";
                grid_Product.Rows[e.RowIndex].Cells[18].Value = "";

                if (Convert.ToString(grid_Product.Rows[e.RowIndex].Cells[11].Value).Equals("Method"))
                {
                    grid_Product.Rows[e.RowIndex].Cells[12].ReadOnly = false;
                    grid_Product.Rows[e.RowIndex].Cells[13].ReadOnly = false;
                    grid_Product.Rows[e.RowIndex].Cells[14].ReadOnly = false;
                    grid_Product.Rows[e.RowIndex].Cells[15].ReadOnly = false;


                    grid_Product.Rows[e.RowIndex].Cells[12].Value = "0";
                    grid_Product.Rows[e.RowIndex].Cells[13].Value = "$";
                    grid_Product.Rows[e.RowIndex].Cells[14].Value = "0";
                    grid_Product.Rows[e.RowIndex].Cells[15].Value = "$";
                }
                else if (Convert.ToString(grid_Product.Rows[e.RowIndex].Cells[11].Value).Equals("Free"))
                {
                    grid_Product.Rows[e.RowIndex].Cells[16].ReadOnly = false;
                    grid_Product.Rows[e.RowIndex].Cells[17].ReadOnly = false;

                    grid_Product.Rows[e.RowIndex].Cells[16].Value = "0";
                    grid_Product.Rows[e.RowIndex].Cells[17].Value = "0";
                    grid_Product.Rows[e.RowIndex].Cells[18].Value = grid_Product.Rows[e.RowIndex].Cells["BasePrice"].Value;
                }
                else
                {
                    grid_Product.Rows[e.RowIndex].Cells[11].Value = "";
                }
            }            
        }

        private void grid_Product_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 12 || e.ColumnIndex == 14 || e.ColumnIndex == 16 || e.ColumnIndex == 17)) // Only promo1 promo2 Buy Free
            {
                if (grid_Product.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    grid_Product.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
                    return;
                }
                Decimal ValueCheck1;
                String InputString = (grid_Product.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value ? "0" : grid_Product.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).ToString();

                if (InputString.ToString().Trim() != "") // input check
                {
                    try
                    {
                        ValueCheck1 = Convert.ToDecimal(InputString);
                        if (ValueCheck1 < 0)
                        {
                            grid_Product.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Input valid value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        grid_Product.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
                        return;
                    }
                }
            }

            if (Convert.ToString(grid_Product.Rows[e.RowIndex].Cells["Types"].Value).Equals("Method"))
            {
                try
                {
                    NetSales_Calculator(e.RowIndex);

                    if (Convert.ToDecimal(grid_Product.Rows[e.RowIndex].Cells[18].Value) < 0)
                    {
                        MessageBox.Show("net price cannot be less than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        grid_Product.Rows[e.RowIndex].Cells[12].Value = "0";
                        grid_Product.Rows[e.RowIndex].Cells[14].Value = "0";
                        grid_Product.Rows[e.RowIndex].Cells[18].Value = "0";
                        return;
                    }
                }
                catch //(Exception ex)
                {
                    //txt_value.Focus();
                    //MessageBox.Show(ex.ToString());

                    MessageBox.Show("input valid values", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grid_Product.Rows[e.RowIndex].Cells[12].Value = "0";
                    grid_Product.Rows[e.RowIndex].Cells[14].Value = "0";
                    grid_Product.Rows[e.RowIndex].Cells[18].Value = "0";
                    return;
                }
            }
        }
        
        private void cbo_brand_TextUpdate(object sender, EventArgs e)
        {
            grid_Product.DataSource = null;
            txt_brandName.Text = "";
        }

        private void grid_Product_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in this.grid_Product.Rows)
                {
                    row.Cells["Types"].Style.BackColor = Color.OldLace;
                }
            }
            catch { }
        }

        private void grid_promotionScheduleH_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String PRMNumber = grid_promotionScheduleH.Rows[e.RowIndex].Cells["NUM_0"].Value.ToString().Trim();
            connSalesOrder.sp_PromotionSchedule(grid_promotionSchedule, PRMNumber);
        }

        private void grid_expiredH_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String PRMNumber = grid_expiredH.Rows[e.RowIndex].Cells["NUM_0"].Value.ToString().Trim();
            connSalesOrder.sp_PromotionSchedule(grid_expired, PRMNumber);
        }

        private void search_schedule()
        {
            String BrandCode = cbo_searchBrandCode.Text.Trim();
            DateTime StartDate = dateTimePickerSearchStart.Value.Date;
            DateTime EndDate = dateTimePickerSearchEnd.Value.Date;

            connSalesOrder.sp_PromotionSchedule_Header(grid_promotionScheduleH, "", BrandCode, StartDate, EndDate);
        }

        private void dateTimePickerSearchStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerSearchStart.Value.Date;
            DateTime today = DateTime.Today.Date;

            if (selectedDate < today)
            {
                dateTimePickerSearchStart.Value = today; //DateTime.Parse("2019/02/25");
            }
            search_schedule();
        }
        
        private void cbo_searchBrandCode_SelectedValueChanged(object sender, EventArgs e)
        {
            grid_promotionSchedule.DataSource = null;
            search_schedule();
        }

        private void cbo_searchBrandCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                search_schedule();
            }
        }

        private void dateTimePickerSearchEnd_ValueChanged(object sender, EventArgs e)
        {
            search_schedule();
        }
        private void search_expired()
        {
            String BrandCode = cbo_searchExpiredBrandCode.Text.Trim();
            DateTime StartDate = dateTimePickerSearchExpiredStart.Value.Date;
            DateTime EndDate = dateTimePickerSearchExpiredEnd.Value.Date;

            connSalesOrder.sp_PromotionSchedule_Header(grid_expiredH, "Expired", BrandCode, StartDate, EndDate);
        }
        private void dateTimePickerSearchExpiredEnd_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerSearchExpiredEnd.Value.Date;
            DateTime today = DateTime.Today.Date;
            DateTime yesterday = DateTime.Today.Date.AddDays(-1);

            if (selectedDate > yesterday)
            {
                dateTimePickerSearchExpiredEnd.Value = yesterday; //DateTime.Parse("2019/02/25");
            }
            search_expired();
        }
        private void cbo_searchExpiredBrandCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                search_expired();
            }
        }

        private void cbo_searchExpiredBrandCode_SelectedValueChanged(object sender, EventArgs e)
        {
            grid_expired.DataSource = null;
            search_expired();
        }

        private void dateTimePickerSearchExpiredStart_ValueChanged(object sender, EventArgs e)
        {
            search_expired();
        }
    }
}




//private void btn_search_schedule_Click(object sender, EventArgs e)
//{
//    search_schedule();
//}
//private void btn_search_expired_Click(object sender, EventArgs e)
//{
//    search_expired();
//}





//private void grid_promotionSchedule_CellEnter(object sender, DataGridViewCellEventArgs e)
//{
//    String SelectedType = grid_promotionSchedule.Rows[e.RowIndex].Cells["Type"].Value.ToString().Trim();
//    if (SelectedType == "Methods")
//    {
//        rbtn_methods.Checked = true;
//    }
//    else
//    {
//        rbtn_free.Checked = true;
//    }
//    String isPromotion2 = grid_promotionSchedule.Rows[e.RowIndex].Cells["Promotion2"].Value.ToString().Trim();
//    if (isPromotion2 != "")
//    {
//        cbx_addMethod.Checked = true;
//        txt_value2.Visible = true;
//        cbo_method2.Visible = true;
//        txt_netPrice.Visible = true;
//        lbl_method2.Visible = true;

//    }
//    else
//    {
//        cbx_addMethod.Checked = false;
//        txt_value2.Visible = false;
//        cbo_method2.Visible = false;
//        txt_netPrice.Visible = false;
//        lbl_method2.Visible = false;
//    }

//    if (btn_newSave.Enabled == false)
//    {
//        PromotionScheduleObject promotionScheduleObject = new PromotionScheduleObject();
//        id = Convert.ToInt32(grid_promotionSchedule.Rows[e.RowIndex].Cells["id"].Value.ToString().Trim());
//        promotionScheduleObject = connSalesOrder.sp_PromotionSchedule_SELECT(id);

//        String BrandCode = promotionScheduleObject.BrandCode;
//        String PromotionTypeCode = promotionScheduleObject.PromotionTypeCode;
//        String PromotionBase = promotionScheduleObject.PromotionBase;
//        DateTime StartDate = promotionScheduleObject.StartDate;
//        DateTime EndDate = promotionScheduleObject.EndDate;
//        String PromotionMemo = promotionScheduleObject.PromotionMemo;
//        String ProductID = promotionScheduleObject.ProductID;
//        Decimal BasePrice = promotionScheduleObject.BasePrice;
//        Decimal PromotionValue1 = promotionScheduleObject.PromotionValue1;
//        String PromotionMethod1 = promotionScheduleObject.PromotionMethod1;
//        Decimal PromotionValue2 = promotionScheduleObject.PromotionValue2;
//        String PromotionMethod2 = promotionScheduleObject.PromotionMethod2;
//        Decimal PromotionBuy = promotionScheduleObject.PromotionBuy;
//        Decimal PromotionFree = promotionScheduleObject.PromotionFree;
//        Decimal NetPrice = promotionScheduleObject.NetPrice;

//        cbo_brand.Text = BrandCode;
//        cbo_promotionTypeCode.Text = PromotionTypeCode;
//        cbo_promotionBase.Text = PromotionBase;
//        dateTimePickerStart.Value = StartDate;
//        dateTimePickerEnd.Value = EndDate;
//        txt_promotionMemo.Text = PromotionMemo;

//        //txt_basePrice.Text = "0";
//        //txt_value2.Text = "0";
//        //cbo_method2.Text = PromotionMethod2;
//        //txt_value1.Text = "0";
//        //cbo_method1.Text = PromotionMethod1;
//        //txt_netPrice.Text = "0";


//        cbo_method1.Text = PromotionMethod1;
//        txt_value1.Text = PromotionValue1.ToString("N2");
//        cbo_method2.Text = PromotionMethod2;
//        txt_value2.Text = PromotionValue2.ToString("N2");
//        txt_buy.Text = PromotionBuy.ToString("N2");
//        txt_free.Text = PromotionFree.ToString("N2");
//        txt_netPrice.Text = NetPrice.ToString("N2");
//    }
//}

//private void btn_save_Click(object sender, EventArgs e)
//{
//    DialogResult dialogResult = MessageBox.Show("Are you sure updating promotion schedule?"
//                                                , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//    if (dialogResult == DialogResult.Yes)
//    {
//        String BrandCode;
//        String PromotionTypeCode;
//        String PromotionBase;
//        DateTime StartDate;
//        DateTime EndDate;
//        String PromotionMemo;
//        String ProductID;
//        Decimal BasePrice;
//        String Type;
//        Decimal PromotionValue1;
//        String PromotionMethod1;
//        Decimal PromotionValue2;
//        String PromotionMethod2;
//        Decimal PromotionBuy;
//        Decimal PromotionFree;
//        Decimal NetPrice;
//        String Checked;
//        String Status = "Active";

//        BrandCode = cbo_brand.Text.Trim();
//        PromotionTypeCode = cbo_promotionTypeCode.Text.Trim();
//        PromotionBase = cbo_promotionBase.Text.Trim();
//        StartDate = dateTimePickerStart.Value.Date;
//        EndDate = dateTimePickerEnd.Value.Date;
//        PromotionMemo = txt_promotionMemo.Text.Trim();
//        ProductID = cbo_productID.Text.Trim();
//        BasePrice = Convert.ToDecimal(txt_basePrice.Text.Trim().ToString());

//        //methods, free radio buttons
//        if (rbtn_methods.Checked)
//        {
//            //add method checked
//            Type = "Methods";
//            PromotionValue1 = Convert.ToDecimal(txt_value1.Text.Trim().ToString());
//            PromotionMethod1 = cbo_method1.Text.Trim();
//            PromotionBuy = 0;
//            PromotionFree = 0;
//            Checked = "";


//            if (cbx_addMethod.Checked) // 2 methods
//            {
//                PromotionValue2 = Convert.ToDecimal(txt_value2.Text.Trim().ToString());
//                PromotionMethod2 = cbo_method2.Text.Trim();
//                NetPrice = Convert.ToDecimal(txt_netPrice.Text.Trim().ToString());
//            }
//            else // 1 method
//            {
//                PromotionValue2 = 0;
//                PromotionMethod2 = "%";
//                NetPrice = Convert.ToDecimal(txt_subNetPrice.Text.Trim().ToString());
//            }
//        }
//        else
//        {
//            Type = "Free";
//            PromotionValue1 = 0;
//            PromotionMethod1 = "%";
//            PromotionValue2 = 0;
//            PromotionMethod2 = "%";
//            PromotionBuy = Convert.ToDecimal(txt_buy.Text.Trim());
//            PromotionFree = Convert.ToDecimal(txt_free.Text.Trim());
//            NetPrice = BasePrice;
//        }

//        Entities.PromotionScheduleObject promotionScheduleObject = new Entities.PromotionScheduleObject();
//        promotionScheduleObject.BrandCode = BrandCode;
//        promotionScheduleObject.PromotionTypeCode = PromotionTypeCode;
//        promotionScheduleObject.PromotionBase = PromotionBase;
//        promotionScheduleObject.StartDate = StartDate;
//        promotionScheduleObject.EndDate = EndDate;
//        promotionScheduleObject.PromotionMemo = PromotionMemo;
//        promotionScheduleObject.ProductID = ProductID;
//        promotionScheduleObject.BasePrice = BasePrice;
//        promotionScheduleObject.Type = Type;
//        promotionScheduleObject.PromotionValue1 = PromotionValue1;
//        promotionScheduleObject.PromotionMethod1 = PromotionMethod1;
//        promotionScheduleObject.PromotionValue2 = PromotionValue2;
//        promotionScheduleObject.PromotionMethod2 = PromotionMethod2;
//        promotionScheduleObject.PromotionBuy = PromotionBuy;
//        promotionScheduleObject.PromotionFree = PromotionFree;
//        promotionScheduleObject.NetPrice = NetPrice;
//        promotionScheduleObject.Checked = "";
//        promotionScheduleObject.Status = Status;

//        connSalesOrder.sp_PromotionSchedule_UPDATE(id, promotionScheduleObject);

//        search_schedule();
//        search_expired();
//    }
//    else if (dialogResult == DialogResult.No)
//    {

//    }

//}
//private void grid_promotionSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
//{
//    if (e.ColumnIndex == 18 && e.RowIndex >= 0) // Delete button
//    {
//        //MessageBox.Show(e.RowIndex.ToString().Trim());
//        DialogResult dialogResult = MessageBox.Show("Are you sure deleting promotion schedule?"
//                                                , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//        if (dialogResult == DialogResult.Yes)
//        {
//            int deletingid = Convert.ToInt32(grid_promotionSchedule.Rows[e.RowIndex].Cells["id"].Value.ToString().Trim());
//            connSalesOrder.sp_PromotionSchedule_DELETE(deletingid);

//            search_schedule();

//            //rowCheck();
//        }
//        else if (dialogResult == DialogResult.No)
//        {

//        }
//    }
//}