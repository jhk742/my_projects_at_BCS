using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Stock
{
    public partial class SubcontractOrder : Form
    {
        int PairingNumber = 1;
        public SubcontractOrder()
        {
            InitializeComponent();

            grid_header_Init();
            grid_Detail_Init();
            grid_DetailReceipt_Init();
            grid_Basket_Init();
            grid_BasketReceipt_Init();
            grid_stock_Init();

            dateTimePickerFrom.Value = DateTime.Now.AddYears(-1);

            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;

            connSalesOrder.cbo_Company(cbo_Company);
            cbo_Company.SelectedItem = "BIC";
            txt_CompanyName.Text = connSalesOrder.getCompanyName(cbo_Company.Text.ToString());

            cbo_storageSite.Items.Add("BCS");
            cbo_storageSite.Items.Add("WH2");
            cbo_storageSite.SelectedItem = "BCS";
            //아이템 가져오기.
            connSalesOrder.cbo_itemID(cbo_product);
            connSalesOrder.cbo_itemID(cbo_RecProduct);

            //connPO.cbox_getVendorID(cbo_location);

            cbo_service.Items.Add("ROAST");
            cbo_service.Items.Add("CUTTING");

            cbo_Supplier.Items.Add("HERSHEL");
            cbo_Supplier.Items.Add("HABCO");

            cbo_Company.BackColor = Color.OldLace;
            cbo_storageSite.BackColor = Color.OldLace;
            cbo_product.BackColor = Color.OldLace;
            txt_lbs.BackColor = Color.OldLace;
            cbo_Supplier.BackColor = Color.OldLace;
            txt_Fee.BackColor = Color.OldLace;
            cbo_RecProduct.BackColor = Color.OldLace;
            txt_RecQty.BackColor = Color.OldLace;
            txt_FeeTotal.BackColor = Color.OldLace;

            connSalesOrder.sp_SUBCONTRACT_SELECT(grid_header, FromDate, ToDate);
            connSalesOrder.sp_SUBCONTRACT_SELECT_DETAIL(grid_Basket, "0");
            connSalesOrder.sp_SUBCONTRACT_SELECT_RECDETAIL(grid_BasketReceipt, "0");
        }
        private void grid_header_Init()
        {
            grid_header.AutoGenerateColumns = false;
            grid_header.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_header.ColumnCount = 9;

            grid_header.Columns[0].Name = "No.";
            grid_header.Columns[0].ReadOnly = true;
            grid_header.Columns[0].Width = 20;
            grid_header.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[0].DataPropertyName = "NUM_0";

            grid_header.Columns[1].Name = "Company";
            grid_header.Columns[1].ReadOnly = true;
            grid_header.Columns[1].Width = 40;
            grid_header.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[1].DataPropertyName = "CPY_0";

            grid_header.Columns[2].Name = "Storage site";
            grid_header.Columns[2].ReadOnly = true;
            grid_header.Columns[2].Width = 55;
            grid_header.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[2].DataPropertyName = "STOFCY_0";

            grid_header.Columns[3].Name = "Supplier Code";
            grid_header.Columns[3].ReadOnly = true;
            grid_header.Columns[3].Width = 70;
            grid_header.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[3].DataPropertyName = "LOC_0";

            grid_header.Columns[4].Name = "Supplier Name";
            grid_header.Columns[4].ReadOnly = true;
            grid_header.Columns[4].Visible = false;
            grid_header.Columns[4].Width = 60;
            grid_header.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[4].DataPropertyName = "BPSNAM_0";

            grid_header.Columns[5].Name = "Service";
            grid_header.Columns[5].ReadOnly = true;
            grid_header.Columns[5].Width = 60;
            grid_header.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[5].DataPropertyName = "SRVITMREF_0";

            grid_header.Columns[6].Name = "Memo";
            grid_header.Columns[6].ReadOnly = true;
            grid_header.Columns[6].Width = 150;
            grid_header.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[6].DataPropertyName = "MEMO";

            grid_header.Columns[7].Name = "Transaction Date";
            grid_header.Columns[7].ReadOnly = true;
            grid_header.Columns[7].Width = 60;
            grid_header.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[7].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_header.Columns[7].DataPropertyName = "CREDAT_0";

            grid_header.Columns[8].Name = "User";
            grid_header.Columns[8].ReadOnly = true;
            grid_header.Columns[8].Width = 50;
            grid_header.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[8].DataPropertyName = "CREUSR_0";


            //grid font size custom
            grid_header.RowTemplate.Height = 20;
            grid_header.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_header.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_header.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void grid_Detail_Init()
        {
            grid_detail.AutoGenerateColumns = false;
            grid_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_detail.ColumnCount = 10;

            grid_detail.Columns[0].Name = "Site";
            grid_detail.Columns[0].ReadOnly = true;
            grid_detail.Columns[0].Visible = false;
            grid_detail.Columns[0].Width = 35;
            grid_detail.Columns[0].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[0].DataPropertyName = "STOFCY_0";

            grid_detail.Columns[1].Name = "Number";
            grid_detail.Columns[1].ReadOnly = true;
            grid_detail.Columns[1].Width = 60;
            grid_detail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[1].DataPropertyName = "SCONUM_0";

            grid_detail.Columns[2].Name = "Product ID";
            grid_detail.Columns[2].ReadOnly = true;
            grid_detail.Columns[2].Width = 60;
            grid_detail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[2].DataPropertyName = "ITMREF_0";

            grid_detail.Columns[3].Name = "Description";
            grid_detail.Columns[3].ReadOnly = true;
            grid_detail.Columns[3].Width = 115;
            grid_detail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[3].DataPropertyName = "ProductDesc";

            grid_detail.Columns[4].Name = "Lot number";
            grid_detail.Columns[4].ReadOnly = true;
            grid_detail.Columns[4].Width = 60;
            grid_detail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[4].DataPropertyName = "LOT_0";

            grid_detail.Columns[5].Name = "Status";
            grid_detail.Columns[5].ReadOnly = true;
            grid_detail.Columns[5].Width = 25;
            grid_detail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[5].DataPropertyName = "STA_0";

            grid_detail.Columns[6].Name = "Expiration Date";
            grid_detail.Columns[6].ReadOnly = true;
            grid_detail.Columns[6].Width = 65;
            grid_detail.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_detail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[6].DataPropertyName = "Expiration";

            grid_detail.Columns[7].Name = "Quantity";
            grid_detail.Columns[7].ReadOnly = true;
            grid_detail.Columns[7].Width = 40;
            grid_detail.Columns[7].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[7].DataPropertyName = "QTYPCU_0";

            grid_detail.Columns[8].Name = "Price";
            grid_detail.Columns[8].ReadOnly = true;
            grid_detail.Columns[8].Width = 30;
            grid_detail.Columns[8].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[8].DataPropertyName = "Price";

            grid_detail.Columns[9].Name = "Amount";
            grid_detail.Columns[9].ReadOnly = true;
            grid_detail.Columns[9].Width = 75;
            grid_detail.Columns[9].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[9].DataPropertyName = "Amount";

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
        private void grid_DetailReceipt_Init()
        {
            grid_detailReceipt.AutoGenerateColumns = false;
            grid_detailReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_detailReceipt.ColumnCount = 10;

            grid_detailReceipt.Columns[0].Name = "Site";
            grid_detailReceipt.Columns[0].ReadOnly = true;
            grid_detailReceipt.Columns[0].Visible = false;
            grid_detailReceipt.Columns[0].Width = 35;
            grid_detailReceipt.Columns[0].DefaultCellStyle.Format = "N2";
            grid_detailReceipt.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[0].DataPropertyName = "STOFCY_0";

            grid_detailReceipt.Columns[1].Name = "Number";
            grid_detailReceipt.Columns[1].ReadOnly = true;
            grid_detailReceipt.Columns[1].Width = 70;
            grid_detailReceipt.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[1].DataPropertyName = "SCONUM_0";

            grid_detailReceipt.Columns[2].Name = "Product ID";
            grid_detailReceipt.Columns[2].ReadOnly = true;
            grid_detailReceipt.Columns[2].Width = 70;
            grid_detailReceipt.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[2].DataPropertyName = "RECITMREF_0";

            grid_detailReceipt.Columns[3].Name = "Description";
            grid_detailReceipt.Columns[3].ReadOnly = true;
            grid_detailReceipt.Columns[3].Width = 130;
            grid_detailReceipt.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[3].DataPropertyName = "ProductDesc";

            grid_detailReceipt.Columns[4].Name = "lbs";
            grid_detailReceipt.Columns[4].ReadOnly = true;
            grid_detailReceipt.Columns[4].Width = 50;
            grid_detailReceipt.Columns[4].DefaultCellStyle.Format = "N2";
            grid_detailReceipt.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[4].DataPropertyName = "lbs";

            grid_detailReceipt.Columns[5].Name = "Fee";
            grid_detailReceipt.Columns[5].ReadOnly = true;
            grid_detailReceipt.Columns[5].Width = 50;
            grid_detailReceipt.Columns[5].DefaultCellStyle.Format = "N2";
            grid_detailReceipt.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[5].DataPropertyName = "Fee";

            grid_detailReceipt.Columns[6].Name = "Fee Total";
            grid_detailReceipt.Columns[6].ReadOnly = true;
            grid_detailReceipt.Columns[6].Width = 65;
            grid_detailReceipt.Columns[6].DefaultCellStyle.Format = "N2";
            grid_detailReceipt.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[6].DataPropertyName = "FeeTotal";

            grid_detailReceipt.Columns[7].Name = "Quantity";
            grid_detailReceipt.Columns[7].ReadOnly = true;
            grid_detailReceipt.Columns[7].Width = 50;
            grid_detailReceipt.Columns[7].DefaultCellStyle.Format = "N2";
            grid_detailReceipt.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detailReceipt.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[7].DataPropertyName = "Qty";

            grid_detailReceipt.Columns[8].Name = "Price";
            grid_detailReceipt.Columns[8].ReadOnly = true;
            grid_detailReceipt.Columns[8].Width = 50;
            grid_detailReceipt.Columns[8].DefaultCellStyle.Format = "N2";
            grid_detailReceipt.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detailReceipt.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[8].DataPropertyName = "Price";

            grid_detailReceipt.Columns[9].Name = "Amount";
            grid_detailReceipt.Columns[9].ReadOnly = true;
            grid_detailReceipt.Columns[9].Width = 75;
            grid_detailReceipt.Columns[9].DefaultCellStyle.Format = "N2";
            grid_detailReceipt.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detailReceipt.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[9].DataPropertyName = "Amount";

            //grid font size custom
            grid_detailReceipt.RowTemplate.Height = 20;
            grid_detailReceipt.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_detailReceipt.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_detailReceipt.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void grid_Basket_Init()
        {
            grid_Basket.AutoGenerateColumns = false;
            grid_Basket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Basket.ColumnCount = 10;

            grid_Basket.Columns[0].Name = "No";
            grid_Basket.Columns[0].ReadOnly = true;
            grid_Basket.Columns[0].Width = 15;
            grid_Basket.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[0].DataPropertyName = "No";

            grid_Basket.Columns[1].Name = "Site";
            grid_Basket.Columns[1].ReadOnly = true;
            grid_Basket.Columns[1].Visible = true;
            grid_Basket.Columns[1].Width = 25;
            grid_Basket.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[1].DataPropertyName = "STOFCY_0";

            grid_Basket.Columns[2].Name = "Product ID";
            grid_Basket.Columns[2].ReadOnly = true;
            grid_Basket.Columns[2].Width = 45;
            grid_Basket.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[2].DataPropertyName = "ITMREF_0";

            grid_Basket.Columns[3].Name = "Description";
            grid_Basket.Columns[3].ReadOnly = true;
            grid_Basket.Columns[3].Width = 150;
            grid_Basket.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[3].DataPropertyName = "ProductDesc";

            grid_Basket.Columns[4].Name = "Lot number";
            grid_Basket.Columns[4].ReadOnly = true;
            grid_Basket.Columns[4].Width = 60;
            grid_Basket.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[4].DataPropertyName = "LOT_0";
        
            grid_Basket.Columns[5].Name = "Status";
            grid_Basket.Columns[5].ReadOnly = true;
            grid_Basket.Columns[5].Width = 25;
            grid_Basket.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[5].DataPropertyName = "STA_0";

            grid_Basket.Columns[6].Name = "Expiration Date";
            grid_Basket.Columns[6].ReadOnly = true;
            grid_Basket.Columns[6].Width = 70;
            grid_Basket.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_Basket.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[6].DataPropertyName = "Expiration";

            grid_Basket.Columns[7].Name = "Quantity";
            grid_Basket.Columns[7].ReadOnly = true;
            grid_Basket.Columns[7].Width = 50;
            grid_Basket.Columns[7].DefaultCellStyle.Format = "N2";
            grid_Basket.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Basket.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[7].DataPropertyName = "QTYPCU_0";

            grid_Basket.Columns[8].Name = "Price";
            grid_Basket.Columns[8].ReadOnly = true;
            grid_Basket.Columns[8].Width = 30;
            grid_Basket.Columns[8].DefaultCellStyle.Format = "N2";
            grid_Basket.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Basket.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[8].DataPropertyName = "Price";

            grid_Basket.Columns[9].Name = "Amount";
            grid_Basket.Columns[9].ReadOnly = true;
            grid_Basket.Columns[9].Width = 80;
            grid_Basket.Columns[9].DefaultCellStyle.Format = "N2";
            grid_Basket.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Basket.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[9].DataPropertyName = "Amount";


            //DataGridViewButtonColumn deleteCreditButton = new DataGridViewButtonColumn();
            //deleteCreditButton.Width = 50;
            //deleteCreditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //deleteCreditButton.Name = "Delete";
            //deleteCreditButton.Visible = true;
            //deleteCreditButton.Text = "Delete";
            //deleteCreditButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //deleteCreditButton.UseColumnTextForButtonValue = true;
            //if (grid_Basket.Columns["Delete"] == null)
            //{
            //    grid_Basket.Columns.Insert(9, deleteCreditButton);
            //}
            //deleteCreditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            //grid font size custom
            grid_Basket.RowTemplate.Height = 20;
            grid_Basket.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_Basket.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_Basket.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_BasketReceipt_Init()
        {
            grid_BasketReceipt.AutoGenerateColumns = false;
            grid_BasketReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_BasketReceipt.ColumnCount = 12;

            grid_BasketReceipt.Columns[0].Name = "No";
            grid_BasketReceipt.Columns[0].ReadOnly = true;
            grid_BasketReceipt.Columns[0].Width = 15;
            grid_BasketReceipt.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[0].DataPropertyName = "No";

            grid_BasketReceipt.Columns[1].Name = "Site";
            grid_BasketReceipt.Columns[1].ReadOnly = true;
            grid_BasketReceipt.Columns[1].Visible = true;
            grid_BasketReceipt.Columns[1].Width = 25;
            grid_BasketReceipt.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[1].DataPropertyName = "STOFCY_0";

            grid_BasketReceipt.Columns[2].Name = "Product ID";
            grid_BasketReceipt.Columns[2].ReadOnly = true;
            grid_BasketReceipt.Columns[2].Width = 50;
            grid_BasketReceipt.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[2].DataPropertyName = "RECITMREF_0";

            grid_BasketReceipt.Columns[3].Name = "Description";
            grid_BasketReceipt.Columns[3].ReadOnly = true;
            grid_BasketReceipt.Columns[3].Width = 150;
            grid_BasketReceipt.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[3].DataPropertyName = "ProductDesc";

            grid_BasketReceipt.Columns[4].Name = "lbs";
            grid_BasketReceipt.Columns[4].ReadOnly = true;
            grid_BasketReceipt.Columns[4].Width = 40;
            grid_BasketReceipt.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[4].DataPropertyName = "lbs";

            grid_BasketReceipt.Columns[5].Name = "Fee";
            grid_BasketReceipt.Columns[5].ReadOnly = true;
            grid_BasketReceipt.Columns[5].Width = 40;
            grid_BasketReceipt.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[5].DataPropertyName = "Fee";

            grid_BasketReceipt.Columns[6].Name = "Fee Total";
            grid_BasketReceipt.Columns[6].ReadOnly = true;
            grid_BasketReceipt.Columns[6].Width = 50;
            grid_BasketReceipt.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[6].DataPropertyName = "FeeTotal";

            grid_BasketReceipt.Columns[7].Name = "Quantity";
            grid_BasketReceipt.Columns[7].ReadOnly = true;
            grid_BasketReceipt.Columns[7].Width = 50;
            grid_BasketReceipt.Columns[7].DefaultCellStyle.Format = "N2";
            grid_BasketReceipt.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_BasketReceipt.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[7].DataPropertyName = "Qty";

            grid_BasketReceipt.Columns[8].Name = "Price";
            grid_BasketReceipt.Columns[8].ReadOnly = true;
            grid_BasketReceipt.Columns[8].Width = 30;
            grid_BasketReceipt.Columns[8].DefaultCellStyle.Format = "N2";
            grid_BasketReceipt.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_BasketReceipt.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[8].DataPropertyName = "Price";

            grid_BasketReceipt.Columns[9].Name = "Amount";
            grid_BasketReceipt.Columns[9].ReadOnly = true;
            grid_BasketReceipt.Columns[9].Width = 80;
            grid_BasketReceipt.Columns[9].DefaultCellStyle.Format = "N2";
            grid_BasketReceipt.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_BasketReceipt.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[9].DataPropertyName = "Amount";


            DataGridViewButtonColumn deleteCreditButton = new DataGridViewButtonColumn();
            deleteCreditButton.Width = 50;
            deleteCreditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteCreditButton.Name = "Delete";
            deleteCreditButton.Visible = true;
            deleteCreditButton.Text = "Delete";
            deleteCreditButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteCreditButton.UseColumnTextForButtonValue = true;
            if (grid_BasketReceipt.Columns["Delete"] == null)
            {
                grid_BasketReceipt.Columns.Insert(10, deleteCreditButton);
            }
            deleteCreditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_BasketReceipt.Columns[11].Name = "Supplier";
            grid_BasketReceipt.Columns[11].ReadOnly = true;
            grid_BasketReceipt.Columns[11].Visible = false;
            grid_BasketReceipt.Columns[11].Width = 80;
            grid_BasketReceipt.Columns[11].DefaultCellStyle.Format = "N2";
            grid_BasketReceipt.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_BasketReceipt.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[11].DataPropertyName = "BPRNUM_0";

            grid_BasketReceipt.Columns[12].Name = "Service";
            grid_BasketReceipt.Columns[12].ReadOnly = true;
            grid_BasketReceipt.Columns[12].Visible = false;
            grid_BasketReceipt.Columns[12].Width = 80;
            grid_BasketReceipt.Columns[12].DefaultCellStyle.Format = "N2";
            grid_BasketReceipt.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_BasketReceipt.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_BasketReceipt.Columns[12].DataPropertyName = "SRVITMREF_0";

            //grid font size custom
            grid_BasketReceipt.RowTemplate.Height = 20;
            grid_BasketReceipt.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_BasketReceipt.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_BasketReceipt.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void grid_stock_Init()
        {
            grid_stock.AutoGenerateColumns = false;
            grid_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_stock.ColumnCount = 15;

            grid_stock.Columns[0].Name = "Site";
            grid_stock.Columns[0].ReadOnly = true;
            grid_stock.Columns[0].Width = 25;
            grid_stock.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[0].DataPropertyName = "STOFCY_0";

            grid_stock.Columns[1].Name = "Product ID";
            grid_stock.Columns[1].ReadOnly = true;
            grid_stock.Columns[1].Width = 55;
            grid_stock.Columns[1].MinimumWidth = 55;
            grid_stock.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[1].DataPropertyName = "ITMREF_0";

            grid_stock.Columns[2].Name = "Lot number";
            grid_stock.Columns[2].ReadOnly = true;
            grid_stock.Columns[2].Width = 60;
            grid_stock.Columns[2].MinimumWidth = 60;
            grid_stock.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[2].DataPropertyName = "LOT_0";

            grid_stock.Columns[3].Name = "TRANSACTION_CHANGE";
            grid_stock.Columns[3].ReadOnly = true;
            grid_stock.Columns[3].Visible = false;
            grid_stock.Columns[3].Width = 100;
            grid_stock.Columns[3].MinimumWidth = 100;
            grid_stock.Columns[3].DataPropertyName = "TRANSACTION_CHANGE";

            grid_stock.Columns[4].Name = "Status";
            grid_stock.Columns[4].ReadOnly = true;
            grid_stock.Columns[4].Width = 30;
            grid_stock.Columns[4].MinimumWidth = 30;
            grid_stock.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[4].DataPropertyName = "STA_0";

            grid_stock.Columns[5].Name = "Initial quantity";
            grid_stock.Columns[5].ReadOnly = true;
            grid_stock.Columns[5].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[5].Width = 60;
            grid_stock.Columns[5].DataPropertyName = "InitialQty";

            grid_stock.Columns[6].Name = "Remaining quantity";
            grid_stock.Columns[6].ReadOnly = true;
            grid_stock.Columns[6].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[6].Width = 80;
            grid_stock.Columns[6].DataPropertyName = "RemainingQty";

            grid_stock.Columns[7].Name = "Detailed";
            grid_stock.Columns[7].ReadOnly = true;
            grid_stock.Columns[7].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[7].Width = 40;
            grid_stock.Columns[7].DataPropertyName = "Detailed";

            grid_stock.Columns[8].Name = "Available";
            grid_stock.Columns[8].ReadOnly = true;
            grid_stock.Columns[8].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[8].Width = 40;
            grid_stock.Columns[8].DataPropertyName = "AvailableQty";

            grid_stock.Columns[9].Name = "Allocated";
            grid_stock.Columns[9].ReadOnly = true;
            grid_stock.Columns[9].Visible = false;
            grid_stock.Columns[9].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[9].Width = 40;
            grid_stock.Columns[9].DataPropertyName = "Allocated";

            grid_stock.Columns[10].Name = "Order quantity";
            grid_stock.Columns[10].ReadOnly = false;
            grid_stock.Columns[10].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[10].Width = 70;
            grid_stock.Columns[10].DataPropertyName = "IssueQty";

            grid_stock.Columns[11].Name = "Price";
            grid_stock.Columns[11].ReadOnly = true;
            grid_stock.Columns[11].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[11].Width = 45;
            grid_stock.Columns[11].DataPropertyName = "Price";

            grid_stock.Columns[12].Name = "Expiration Date";
            grid_stock.Columns[12].ReadOnly = true;
            grid_stock.Columns[12].Width = 80;
            grid_stock.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[12].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_stock.Columns[12].DataPropertyName = "Expiration";

            grid_stock.Columns[13].Name = "Update user";
            grid_stock.Columns[13].ReadOnly = true;
            grid_stock.Columns[13].Width = 60;
            grid_stock.Columns[13].MinimumWidth = 50;
            grid_stock.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[13].DataPropertyName = "UPDUSER";

            grid_stock.Columns[14].Name = "Update time";
            grid_stock.Columns[14].ReadOnly = true;
            grid_stock.Columns[14].Width = 120;
            grid_stock.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_stock.Columns[10].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_stock.Columns[14].DataPropertyName = "UPDDATTIM_0";

            //grid font size custom
            grid_stock.RowTemplate.Height = 20;
            grid_stock.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_stock.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            grid_stock.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void LotInformationByProductID()
        {
            try
            {
                String ItemID = cbo_product.Text.Trim();
                String StorageSite = cbo_storageSite.Text.Trim();
                String Company = cbo_Company.Text.ToString();

                txt_ProductDesc.Text = connSalesOrder.getItemDescFromItemID(ItemID);
                txt_globalAllocated.Text = connSalesOrder.sp_STOCKCHANGE_GLOBAL(ItemID);
                txt_BasePrice.Text = connSalesOrder.getItemBasePriceDividebyConvFromItemID(ItemID).ToString("N2");
                txt_PackSize.Text = connSalesOrder.getItemPackSizeFromItemID(ItemID);

                connSalesOrder.sp_Miscellaneous_Stock_Select(grid_stock, ItemID, Company, StorageSite);


                Decimal CheckedTotalStockQty = 0;
                for (int i = 0; i < grid_stock.RowCount; i++)
                {
                    if (grid_stock.Rows[i].Cells["Status"].Value.ToString().Equals("A"))
                    {
                        Decimal AvailableQty = Convert.ToDecimal(grid_stock.Rows[i].Cells["Available"].Value.ToString());
                        CheckedTotalStockQty = CheckedTotalStockQty + AvailableQty;
                    }
                }
                txt_availableQty.Text = CheckedTotalStockQty.ToString("N2");
            }
            catch { }

        }
        private void Initialized()
        {
            txt_globalAllocated.Text = "";
            txt_IssueQty.Text = "";
            txt_availableQty.Text = "";
            txt_lbs.Text = "0.0";
            txt_Fee.Text = "0.0";
            txt_RecQty.Text = "0.0";
            txt_FeeTotal.Text = "0.0";
            grid_stock.DataSource = null;
            grid_stock.Rows.Clear();
            grid_stock.Refresh();
            grid_Basket.DataSource = null;
            grid_Basket.Rows.Clear();
            grid_Basket.Refresh();
            grid_BasketReceipt.DataSource = null;
            grid_BasketReceipt.Rows.Clear();
            grid_BasketReceipt.Refresh();
            btn_Save.Enabled = false;
            cbo_product.Focus();
            PairingNumber = 1;

            connSalesOrder.sp_SUBCONTRACT_SELECT_DETAIL(grid_Basket, "0");
            connSalesOrder.sp_SUBCONTRACT_SELECT_RECDETAIL(grid_BasketReceipt, "0");

            LotInformationByProductID();
            connSalesOrder.sp_SUBCONTRACT_SELECT(grid_header, dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            connSalesOrder.sp_SUBCONTRACT_SELECT(grid_header, FromDate, ToDate);
        }

        private void grid_header_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String Number = grid_header.Rows[e.RowIndex].Cells["No."].Value.ToString();

            connSalesOrder.sp_SUBCONTRACT_SELECT_DETAIL(grid_detail, Number);
            connSalesOrder.sp_SUBCONTRACT_SELECT_RECDETAIL(grid_detailReceipt, Number);

        }
        private void cbo_product_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_ProductDesc.Text = "";
            txt_globalAllocated.Text = "";
            txt_availableQty.Text = "";
            txt_IssueQty.Text = "";

            grid_stock.DataSource = null;
            btn_Add.Enabled = false;

            LotInformationByProductID();
        }
        private void cbo_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LotInformationByProductID();
            }
        }
        private void cbo_product_TextUpdate(object sender, EventArgs e)
        {
            grid_stock.DataSource = null;
            txt_ProductDesc.Text = "";
            txt_globalAllocated.Text = "";
            txt_availableQty.Text = "";
            txt_IssueQty.Text = "";
            txt_lbs.Text = "";

            btn_Add.Enabled = false;
        }
        private void cbo_RecProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                RecProductInfo();
            }
        }

        private void cbo_RecProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_RecProductDesc.Text = "";
            txt_RecglobalAllocated.Text = "";
            txt_RecavailableQty.Text = "";

            RecProductInfo();
        }

        private void cbo_RecProduct_TextUpdate(object sender, EventArgs e)
        {
            txt_RecProductDesc.Text = "";
            txt_RecglobalAllocated.Text = "";
            txt_RecavailableQty.Text = "";

            RecProductInfo();
        }
        private void RecProductInfo()
        {
            try
            {
                String ProductID = cbo_RecProduct.Text.ToString();

                txt_RecProductDesc.Text = connSalesOrder.getItemDescFromItemID(ProductID);
                txt_RecglobalAllocated.Text = connSalesOrder.sp_STOCKCHANGE_GLOBAL(ProductID);
                txt_RecPackSize.Text = connSalesOrder.getItemPackSizeFromItemID(ProductID);
                Decimal Available = connSalesOrder.getStockAvailableFromProductID(ProductID);
                txt_RecavailableQty.Text = Available.ToString("N2");
            }
            catch
            {
            }
        }
        private void cbo_storageSite_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //{
            //    LotInformationByProductID();
            //}
        }
        private void cbo_storageSite_SelectedValueChanged(object sender, EventArgs e)
        {
            //LotInformationByProductID();
        }
        private void cbo_Company_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_CompanyName.Text = connSalesOrder.getCompanyName(cbo_Company.Text.ToString());
        }

        private void cbo_Supplier_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_Supplier.Text.ToString().Equals("HERSHEL"))
            {
                cbo_service.Text = "ROAST";
            }
            else
            {
                cbo_service.Text = "CUTTING";
            }
        }
        private void grid_stock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                btn_Add.Enabled = true;
                foreach (DataGridViewRow row in this.grid_stock.Rows)
                {
                    row.Cells["Order quantity"].Style.BackColor = Color.OldLace;
                    if (!row.Cells["Status"].Value.ToString().Equals("A"))
                    {
                        //row.Cells["Status"].Style.BackColor = Color.LightGray;
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        row.Cells["Order quantity"].Style.BackColor = Color.LightGray;
                        row.Cells["Order quantity"].ReadOnly = true;
                    }
                }
                if (grid_stock.RowCount == 0)
                {
                    btn_Add.Enabled = false;
                }
            }
            catch { }
        }
        private void grid_stock_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Decimal TotalIssueQty = 0;
                if (grid_stock.Rows[e.RowIndex].Cells["Order quantity"].Value == DBNull.Value || Convert.ToDecimal(grid_stock.Rows[e.RowIndex].Cells["Order quantity"].Value) < 0)
                {
                    grid_stock.Rows[e.RowIndex].Cells["Order quantity"].Value = "0.00";
                }
                if (Convert.ToDecimal(grid_stock.Rows[e.RowIndex].Cells["Order quantity"].Value) > Convert.ToDecimal(grid_stock.Rows[e.RowIndex].Cells["Available"].Value))
                {
                    MessageBox.Show("Please check ORDER qty."
                                                            , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grid_stock.Rows[e.RowIndex].Cells["Order quantity"].Value = "0.00";
                }
                for (int i = 0; i < grid_stock.RowCount; i++)
                {
                    TotalIssueQty += Convert.ToDecimal(grid_stock.Rows[i].Cells["Order quantity"].Value);
                }
                txt_IssueQty.Text = TotalIssueQty.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "DataGridView Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grid_stock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0.00";
            }
        }


       

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch(Exception ex)
            {
                MessageBox.Show("Please enter a valid value.\n\n" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                (sender as TextBox).Text = "";
            }
            
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal lbs = 0;
                decimal Fee = 0;
                decimal FeeTotal = 0;
                if (!string.IsNullOrEmpty(txt_lbs.Text.ToString()))
                {
                    lbs = Convert.ToDecimal(txt_lbs.Text.ToString());
                }
                if (!string.IsNullOrEmpty(txt_Fee.Text.ToString()))
                {
                    Fee = Convert.ToDecimal(txt_Fee.Text.ToString());
                }
                FeeTotal = lbs * Fee;
                txt_FeeTotal.Text = FeeTotal.ToString("N4");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid value.\n\n" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                (sender as TextBox).Text = "";
            }
        }

        private void grid_BasketReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 10 && e.RowIndex >= 0) // Delete button
                {
                    String Number = grid_BasketReceipt.Rows[e.RowIndex].Cells["No"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Are you sure to delete this No (" + Number + ")?"
                                                            , "Confirming", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        grid_BasketReceipt.Rows.RemoveAt(e.RowIndex);

                        int Count = 0;
                        while (Count < grid_Basket.RowCount)
                        {
                            if (Number.Equals(grid_Basket.Rows[Count].Cells["No"].Value.ToString()))
                            {
                                grid_Basket.Rows.RemoveAt(Count);
                                //MessageBox.Show("grid_Basket.Rows[Count].Cells[No'].Value.ToString() : " + grid_Basket.Rows[Count].Cells["No"].Value.ToString() +
                                //    "grid_Basket.Rows.RemoveAt(Count); Count : "+Count.ToString());
                            }
                            else
                            {
                                Count++;
                                //MessageBox.Show("grid_Basket.Rows[Count].Cells[No'].Value.ToString() : " + grid_Basket.Rows[Count].Cells["No"].Value.ToString() +
                                //    "Count++; Count : " + Count.ToString());
                            }
                        }

                        this.grid_BasketReceipt.ClearSelection();
                        this.grid_Basket.ClearSelection();
                        //MessageBox.Show(grid_Basket.RowCount.ToString()+"\n"+grid_BasketReceipt.RowCount.ToString());
                        if (grid_Basket.RowCount == 0 && grid_BasketReceipt.RowCount == 0)
                        {
                            btn_Save.Enabled = false;
                            PairingNumber = 1;
                        }
                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(txt_IssueQty.Text.ToString()) || txt_IssueQty.TextLength == 0 || Convert.ToDecimal(txt_IssueQty.Text.ToString()) == 0)
                {
                    MessageBox.Show("Please check the input values.(Purchase Order product)"
                                                              , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(cbo_Supplier.Text.ToString()) || string.IsNullOrEmpty(txt_lbs.Text.ToString()) 
                    || string.IsNullOrEmpty(txt_Fee.Text.ToString()) || string.IsNullOrEmpty(txt_FeeTotal.Text.ToString()))
                {
                    MessageBox.Show("Please check the input values.(Lbs, Fee)"
                                                              , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(cbo_RecProduct.Text.ToString()) || txt_RecQty.TextLength == 0 || Convert.ToDecimal(txt_RecQty.Text.ToString()) == 0 ||
                    Convert.ToDecimal(txt_RecQty.Text.ToString()) <= 0 || string.IsNullOrEmpty(txt_RecQty.Text.ToString()))
                {
                    MessageBox.Show("Please check the input values.(Receipt product)"
                                                           , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Choose only one Service 
                Decimal GlobalCheck = 0;

                decimal BasePrice = Convert.ToDecimal(txt_BasePrice.Text.ToString());

                for (int i = 0; i < grid_stock.RowCount; i++) //Global Check와 Lot exist Check
                {
                    if (grid_stock.Rows[i].Cells["Status"].Value.ToString().Equals("A"))
                    {
                        GlobalCheck += (Convert.ToDecimal(grid_stock.Rows[i].Cells["Available"].Value.ToString().Trim()) - Convert.ToDecimal(grid_stock.Rows[i].Cells["Order quantity"].Value.ToString().Trim()));
                    }
                    if (Convert.ToDecimal(grid_stock.Rows[i].Cells["Order quantity"].Value) > 0)
                    {
                        if (grid_Basket.RowCount > 0)
                        {
                            
                            foreach (DataGridViewRow row in this.grid_Basket.Rows)
                            {
                                if (row.Cells["Lot number"].Value.ToString().Equals(grid_stock.Rows[i].Cells["Lot number"].Value.ToString()))
                                {
                                    MessageBox.Show("Same Lot number exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }
                    }
                }
                if ((GlobalCheck < Convert.ToDecimal(txt_globalAllocated.Text.Trim())) && cbo_storageSite.Text.Equals("BCS"))
                {
                    MessageBox.Show("Please check BCS GLOBAL qty."
                                                           , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (grid_BasketReceipt.RowCount > 0)
                {
                    if (!cbo_Supplier.Text.ToString().Equals(grid_BasketReceipt.Rows[0].Cells["Supplier"].Value.ToString()))
                    {
                        MessageBox.Show("Please choose only one supplier.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                decimal TotalPrice = 0, TotalFee = 0;
                TotalFee = Convert.ToDecimal(txt_FeeTotal.Text.ToString());
                for (int i = 0; i < grid_stock.RowCount; i++)
                {
                    if (Convert.ToDecimal(grid_stock.Rows[i].Cells["Order quantity"].Value) > 0)
                    {
                        DataTable dataTable = this.grid_Basket.DataSource as DataTable;
                        DataRow drToAdd = dataTable.NewRow();
                        drToAdd["No"] = PairingNumber.ToString();
                        drToAdd["STOFCY_0"] = grid_stock.Rows[i].Cells["Site"].Value.ToString();
                        drToAdd["ITMREF_0"] = grid_stock.Rows[i].Cells["Product ID"].Value.ToString();
                        drToAdd["ProductDesc"] = txt_ProductDesc.Text.ToString();
                        drToAdd["LOT_0"] = grid_stock.Rows[i].Cells["Lot number"].Value.ToString();
                        drToAdd["STA_0"] = grid_stock.Rows[i].Cells["Status"].Value.ToString();
                        drToAdd["QTYPCU_0"] = grid_stock.Rows[i].Cells["Order Quantity"].Value.ToString();
                        drToAdd["Expiration"] = grid_stock.Rows[i].Cells["Expiration Date"].Value.ToString();
                        drToAdd["Price"] = grid_stock.Rows[i].Cells["Price"].Value.ToString();
                        drToAdd["Amount"] = (Convert.ToDecimal(grid_stock.Rows[i].Cells["Order Quantity"].Value) *
                            Convert.ToDecimal(grid_stock.Rows[i].Cells["Price"].Value)).ToString("N2");

                        TotalPrice += Convert.ToDecimal(grid_stock.Rows[i].Cells["Order Quantity"].Value) * Convert.ToDecimal(grid_stock.Rows[i].Cells["Price"].Value);

                        dataTable.Rows.Add(drToAdd);

                        dataTable.AcceptChanges();

                        this.grid_Basket.ClearSelection();
                    }
                }

                Decimal RecPrice = 0;

                RecPrice = (TotalPrice + TotalFee) / Convert.ToDecimal(txt_RecQty.Text.ToString());
                String RecProductID = cbo_RecProduct.Text.ToString();
                String RecBasePrice = connSalesOrder.getItemBasePriceDividebyConvFromItemID(RecProductID).ToString("N2");
                DataTable RecdataTable = this.grid_BasketReceipt.DataSource as DataTable;
                DataRow RecdrToAdd = RecdataTable.NewRow();
                RecdrToAdd["No"] = PairingNumber.ToString();
                RecdrToAdd["STOFCY_0"] = cbo_storageSite.Text.ToString();
                RecdrToAdd["RECITMREF_0"] = RecProductID;
                RecdrToAdd["ProductDesc"] = txt_RecProductDesc.Text.ToString();
                RecdrToAdd["lbs"] = txt_lbs.Text.ToString();
                RecdrToAdd["Fee"] = txt_Fee.Text.ToString();
                RecdrToAdd["FeeTotal"] = txt_FeeTotal.Text.ToString();
                RecdrToAdd["Qty"] = txt_RecQty.Text.ToString();
                RecdrToAdd["BPRNUM_0"] = cbo_Supplier.Text.ToString();
                RecdrToAdd["SRVITMREF_0"] = cbo_service.Text.ToString();
                //RecdrToAdd["Price"] = RecBasePrice;
                //RecdrToAdd["Amount"] = (Convert.ToDecimal(txt_RecQty.Text.ToString()) *
                //    Convert.ToDecimal(RecBasePrice)).ToString("N2");
                RecdrToAdd["Price"] = RecPrice;
                RecdrToAdd["Amount"] = Convert.ToDecimal(txt_RecQty.Text.ToString()) * RecPrice;
                RecdataTable.Rows.Add(RecdrToAdd);

                RecdataTable.AcceptChanges();

                this.grid_BasketReceipt.ClearSelection();

                PairingNumber++;
                btn_Save.Enabled = true;
                cbo_product.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try again.\n\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private bool REALTIME_STOCKCHECK()
        {
            try
            {
                String ErrorProductList = "", GlobalProductList = "";
                List<string> ProductList = new List<string>();
                string[] DistinctProductList;

                for (int i = 0; i < grid_Basket.RowCount; i++)
                {
                    String SelectedProductID = grid_Basket.Rows[i].Cells["Product ID"].Value.ToString();
                    String LotNumber = grid_Basket.Rows[i].Cells["Lot number"].Value.ToString();
                    Decimal Quantity = Convert.ToDecimal(grid_Basket.Rows[i].Cells["Quantity"].Value);

                    String AvailableResult = connSalesOrder.sp_Stock_Available_Check(SelectedProductID, LotNumber, Quantity); // LOT REALTIME CHECK BY LOT NUMBER
                    ProductList.Add(SelectedProductID);

                    if (!AvailableResult.Equals("Success"))
                    {
                        ErrorProductList += SelectedProductID + " ";
                    }
                }
                if (ErrorProductList.Length != 0)
                {
                    MessageBox.Show("Product stock(LOT Quantity) has changed( " + ErrorProductList + "). Please refresh and try again.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                DistinctProductList = ProductList.Distinct().ToArray();

                for (int i = 0; i < DistinctProductList.Length; i++)
                {
                    String ProductID = DistinctProductList[i].ToString();
                    Decimal ProductQty = 0;

                    foreach (DataGridViewRow row in this.grid_Basket.Rows)
                    {
                        if (row.Cells["Product ID"].Value.ToString().Equals(ProductID) && row.Cells["Status"].Value.ToString().Equals("A"))
                        {
                            ProductQty += Convert.ToDecimal(row.Cells["Quantity"].Value);
                        }
                    }
                    String StockCheckByProductID = connSalesOrder.sp_Stock_Available_Check_ByProductID(ProductID, ProductQty); // PRODUCT GLOBAL QUANTITY REALTIME CHECK 
                    if (!StockCheckByProductID.Equals("Success"))
                    {
                        GlobalProductList += ProductID + " ";
                    }
                }
                if (GlobalProductList.Length != 0)
                {
                    MessageBox.Show("Product stock(BCS GLOBAL Quantity) has changed( " + GlobalProductList + "). Please refresh and try again.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to continue Subcontract order?"
                                                           , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    List<string> NoList = new List<string>();
                    string[] DistinctNoList;
                    int HeaderLine = 1;

                    if (!REALTIME_STOCKCHECK()) return;

                    for (int i = 0; i < grid_Basket.RowCount; i++)
                    {
                        NoList.Add(grid_Basket.Rows[i].Cells["No"].Value.ToString());
                    }

                    DistinctNoList = NoList.Distinct().ToArray();

                    String OrderNumber = connSalesOrder.sp_GET_SubcontractOrderNumber();

                    for (int i = 0; i < DistinctNoList.Length; i++)
                    {
                        String No = DistinctNoList[i].ToString();
                        int DetailLine = 1;
                        String NewBCSSCNumber = connSalesOrder.sp_GET_NewBCSSCNumber();
                        String CompanyCode = cbo_Company.Text.ToString();
                        String Site = cbo_storageSite.Text.ToString();
                        String Supplier = grid_BasketReceipt.Rows[0].Cells["Supplier"].Value.ToString();
                        String Service = grid_BasketReceipt.Rows[0].Cells["Service"].Value.ToString();
                        String Memo = txt_Memo.Text.ToString();

                        Decimal OrderProductQty = 0;
                        Decimal OrderProductAmount = 0;
                        String OrderProductID = "";

                        foreach (DataGridViewRow row in this.grid_Basket.Rows)
                        {
                            if (No.Equals(row.Cells["No"].Value.ToString()))
                            {
                                OrderProductID = row.Cells["Product ID"].Value.ToString();
                                String OrderLOT = row.Cells["Lot Number"].Value.ToString();
                                String OrderStatus = row.Cells["Status"].Value.ToString();
                                Decimal OrderQuantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                                Decimal OrderAmount = Convert.ToDecimal(row.Cells["Amount"].Value);
                                DateTime OrderExpirationDate = Convert.ToDateTime(row.Cells["Expiration Date"].Value);

                                //MessageBox.Show("NewBCSSCNumber :" + NewBCSSCNumber + "\nCompanyCode : " + CompanyCode + "\nSite : " + Site + "\nOrderProductID : " 
                                //    + OrderProductID +"\nSCLOT : " + OrderLOT + "\nOrderStatus : " + OrderStatus + "\nOrderQuantity : " + OrderQuantity.ToString() + 
                                //    "\nSupplier : " + Supplier + "\nService : " + Service+ "\nExpiration : " + OrderExpirationDate.ToShortDateString() 
                                //    + "\nLine : " + DetailLine.ToString());

                                //Insert Detail

                                //
                                String SaveDetailResult = connSalesOrder.sp_SUBCONTRACT_SAVE(NewBCSSCNumber, CompanyCode, Site, OrderProductID,
                                    OrderLOT, OrderStatus, OrderQuantity, Supplier, Service, OrderExpirationDate, DetailLine);

                                if (!SaveDetailResult.Equals("Success"))
                                {
                                    MessageBox.Show(SaveDetailResult, "※COTACT IT TEAM※", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                    return;
                                }

                                OrderProductQty += OrderQuantity;
                                OrderProductAmount += OrderAmount;
                                DetailLine++;
                            }
                        }

                        //Insert Subcontract Header
                        for (int j = 0; j < grid_BasketReceipt.RowCount; j++)
                        {
                            String MatchNumber = grid_BasketReceipt.Rows[j].Cells["No"].Value.ToString();
                            if (MatchNumber.Equals(No))
                            {
                                String RecProductID = grid_BasketReceipt.Rows[j].Cells["Product ID"].Value.ToString();
                                Decimal RecLbs = Convert.ToDecimal(grid_BasketReceipt.Rows[j].Cells["lbs"].Value);
                                Decimal RecFee = Convert.ToDecimal(grid_BasketReceipt.Rows[j].Cells["Fee"].Value);
                                Decimal RecFeeTotal = Convert.ToDecimal(grid_BasketReceipt.Rows[j].Cells["Fee Total"].Value);
                                Decimal RecQuantity = Convert.ToDecimal(grid_BasketReceipt.Rows[j].Cells["Quantity"].Value);
                                Decimal RecPrice = Convert.ToDecimal(grid_BasketReceipt.Rows[j].Cells["Price"].Value);
                                Decimal RecAmount = Convert.ToDecimal(grid_BasketReceipt.Rows[j].Cells["Amount"].Value);

                                //MessageBox.Show("No : "+No + "\nNewBCSSCNumber :" + NewBCSSCNumber + "\nCompanyCode : " + CompanyCode + "\nSite : " + Site + "\nOrderProductID : "
                                //   + OrderProductID + "\nOrderProductQty : " + OrderProductQty.ToString() + "\nSupplier : " + Supplier + "\nService : " + Service +
                                //   "\nRecLbs : " + RecLbs.ToString() + "\nRecFee : " + RecFee.ToString() + "\nRecFeeTotal : " + RecFeeTotal.ToString() + 
                                //   "\nRecProductID : " + RecProductID+ "\nRecQuantity : " + RecQuantity.ToString() + "\nOrderProductAmount : " + OrderProductAmount.ToString() +
                                //    "\nRecPrice : " + RecPrice.ToString() + "\nMemo : " + Memo + "\nHeaderLine : " + HeaderLine.ToString());

                                String SaveHeaderResult = connSalesOrder.sp_SUBCONTRACT_SAVE_HEADER(OrderNumber, NewBCSSCNumber, CompanyCode, Site, OrderProductID, OrderProductQty,
                                    Supplier, Service, RecLbs, RecFee, RecFeeTotal, RecProductID, RecQuantity, OrderProductAmount, RecPrice, Memo, HeaderLine);

                                if (!SaveHeaderResult.Equals("Success"))
                                {
                                    MessageBox.Show(SaveHeaderResult, "※COTACT IT TEAM※", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                    return;

                                }
                            }
                        }

                        HeaderLine++;
                    }
                    MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Initialized();
                    cbo_product.Focus();
                }
                else
                {
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
