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
    public partial class AssemblyReceipt : Form
    {
        public AssemblyReceipt()
        {
            InitializeComponent();

            grid_header_Init();
            grid_TempHeader_Init();
            grid_Detail_Init();
            grid_Basket_Init();
            grid_stock_Init();

            cbo_storageSite.Items.Add("BCS");
            cbo_storageSite.Items.Add("WH2");
            cbo_storageSite.Text = "BCS";

            connSalesOrder.cbo_Company(cbo_Company);
            cbo_Company.SelectedItem = "BIC";
            txt_CompanyName.Text = connSalesOrder.getCompanyName(cbo_Company.Text.ToString());

            //connSalesOrder.cbo_site(cbo_storageSite);
            cbo_storageSite.Items.Add("BCS");
            cbo_storageSite.Items.Add("WH2");
            cbo_storageSite.SelectedItem = "BCS";
            cbo_Status.Items.Add("A");
            cbo_Status.Items.Add("Q");
            cbo_Status.Items.Add("R");
            cbo_Status.Text = "A";
            //아이템 가져오기
            connSalesOrder.cbo_itemID(cbo_product);

            dateTimePickerFrom.Value = DateTime.Now.AddYears(-1);
            dateTimePickerExpired.Value = DateTime.Now.AddYears(1);

            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;

            connSalesOrder.sp_ASSEMBLY_SELECT_ASSEMBLED(grid_header, FromDate, ToDate);
            connSalesOrder.sp_ASSEMBLY_SELECT_TEMP(grid_TempHeader);
        }
        private void grid_header_Init()
        {
            grid_header.AutoGenerateColumns = false;
            grid_header.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_header.ColumnCount = 6;

            grid_header.Columns[0].Name = "Company";
            grid_header.Columns[0].ReadOnly = true;
            grid_header.Columns[0].Width = 25;
            grid_header.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[0].DataPropertyName = "CPY_0";

            grid_header.Columns[1].Name = "Site";
            grid_header.Columns[1].ReadOnly = true;
            grid_header.Columns[1].Width = 15;
            grid_header.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[1].DataPropertyName = "STOFCY_0";

            grid_header.Columns[2].Name = "Number";
            grid_header.Columns[2].ReadOnly = true;
            grid_header.Columns[2].Width = 40;
            grid_header.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[2].DataPropertyName = "VCRNUM_0";

            grid_header.Columns[3].Name = "Transaction Date";
            grid_header.Columns[3].ReadOnly = true;
            grid_header.Columns[3].Width = 40;
            grid_header.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_header.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[3].DataPropertyName = "IPTDAT_0";

            grid_header.Columns[4].Name = "Accounting Date";
            grid_header.Columns[4].ReadOnly = true;
            grid_header.Columns[4].Width = 40;
            grid_header.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_header.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[4].DataPropertyName = "ACCDAT_0";

            grid_header.Columns[5].Name = "Memo";
            grid_header.Columns[5].ReadOnly = true;
            grid_header.Columns[5].Width = 200;
            grid_header.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[5].DataPropertyName = "VCRDES_0";

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
        private void grid_TempHeader_Init()
        {
            grid_TempHeader.AutoGenerateColumns = false;
            grid_TempHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_TempHeader.ColumnCount = 5;

            grid_TempHeader.Columns[0].Name = "Company";
            grid_TempHeader.Columns[0].ReadOnly = true;
            grid_TempHeader.Columns[0].Width = 15;
            grid_TempHeader.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[0].DataPropertyName = "CPY_0";

            grid_TempHeader.Columns[1].Name = "Site";
            grid_TempHeader.Columns[1].ReadOnly = true;
            grid_TempHeader.Columns[1].Width = 10;
            grid_TempHeader.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[1].DataPropertyName = "STOFCY_0";

            grid_TempHeader.Columns[2].Name = "Number";
            grid_TempHeader.Columns[2].ReadOnly = true;
            grid_TempHeader.Columns[2].Width = 25;
            grid_TempHeader.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[2].DataPropertyName = "VCRNUM_0";

            grid_TempHeader.Columns[3].Name = "Transaction Date";
            grid_TempHeader.Columns[3].ReadOnly = true;
            grid_TempHeader.Columns[3].Width = 30;
            grid_TempHeader.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_TempHeader.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[3].DataPropertyName = "IPTDAT_0";

            grid_TempHeader.Columns[4].Name = "Memo";
            grid_TempHeader.Columns[4].ReadOnly = true;
            grid_TempHeader.Columns[4].Width = 300;
            grid_TempHeader.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[4].DataPropertyName = "VCRDES_0";


            //grid font size custom
            grid_TempHeader.RowTemplate.Height = 20;
            grid_TempHeader.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_TempHeader.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_TempHeader.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        
        private void grid_Detail_Init()
        {
            grid_detail.AutoGenerateColumns = false;
            grid_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_detail.ColumnCount = 9;

            grid_detail.Columns[0].Name = "Site";
            grid_detail.Columns[0].ReadOnly = true;
            grid_detail.Columns[0].Visible = false;
            grid_detail.Columns[0].Width = 40;
            grid_detail.Columns[0].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[0].DataPropertyName = "STOFCY_0";

            grid_detail.Columns[1].Name = "Product ID";
            grid_detail.Columns[1].ReadOnly = true;
            grid_detail.Columns[1].Width = 55;
            grid_detail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[1].DataPropertyName = "ITMREF_0";

            grid_detail.Columns[2].Name = "Description";
            grid_detail.Columns[2].ReadOnly = true;
            grid_detail.Columns[2].Width = 120;
            grid_detail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[2].DataPropertyName = "ITMDES1_0";

            grid_detail.Columns[3].Name = "Lot number";
            grid_detail.Columns[3].ReadOnly = true;
            grid_detail.Columns[3].Width = 60;
            grid_detail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[3].DataPropertyName = "LOT_0";

            grid_detail.Columns[4].Name = "Status";
            grid_detail.Columns[4].ReadOnly = true;
            grid_detail.Columns[4].Width = 25;
            grid_detail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[4].DataPropertyName = "STA_0";

            grid_detail.Columns[5].Name = "Expiration";
            grid_detail.Columns[5].ReadOnly = true;
            grid_detail.Columns[5].Visible = true;
            grid_detail.Columns[5].Width = 50;
            grid_detail.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_detail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[5].DataPropertyName = "Expiration";

            grid_detail.Columns[6].Name = "Quantity";
            grid_detail.Columns[6].ReadOnly = true;
            grid_detail.Columns[6].Width = 40;
            grid_detail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[6].DataPropertyName = "QTYPCU_0";

            grid_detail.Columns[7].Name = "Price";
            grid_detail.Columns[7].ReadOnly = true;
            grid_detail.Columns[7].Width = 30;
            grid_detail.Columns[7].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[7].DataPropertyName = "Price";

            grid_detail.Columns[8].Name = "Amount";
            grid_detail.Columns[8].ReadOnly = true;
            grid_detail.Columns[8].Width = 75;
            grid_detail.Columns[8].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[8].DataPropertyName = "Amount";

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
        private void grid_Basket_Init()
        {
            grid_Basket.AutoGenerateColumns = false;
            grid_Basket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Basket.ColumnCount = 9;

            grid_Basket.Columns[0].Name = "Site";
            grid_Basket.Columns[0].ReadOnly = true;
            grid_Basket.Columns[0].Visible = true;
            grid_Basket.Columns[0].Width = 25;
            grid_Basket.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[0].DataPropertyName = "STOFCY_0";

            grid_Basket.Columns[1].Name = "Product ID";
            grid_Basket.Columns[1].ReadOnly = true;
            grid_Basket.Columns[1].Width = 45;
            grid_Basket.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[1].DataPropertyName = "ITMREF_0";

            grid_Basket.Columns[2].Name = "Description";
            grid_Basket.Columns[2].ReadOnly = true;
            grid_Basket.Columns[2].Width = 150;
            grid_Basket.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[2].DataPropertyName = "ITMDES1_0";

            grid_Basket.Columns[3].Name = "Lot number";
            grid_Basket.Columns[3].ReadOnly = true;
            grid_Basket.Columns[3].Width = 60;
            grid_Basket.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[3].DataPropertyName = "LOT_0";

            grid_Basket.Columns[4].Name = "Status";
            grid_Basket.Columns[4].ReadOnly = true;
            grid_Basket.Columns[4].Width = 25;
            grid_Basket.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[4].DataPropertyName = "STA_0";

            grid_Basket.Columns[5].Name = "Expiration";
            grid_Basket.Columns[5].ReadOnly = true;
            grid_Basket.Columns[5].Width = 50;
            grid_Basket.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_Basket.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[5].DataPropertyName = "Expiration";

            grid_Basket.Columns[6].Name = "Quantity";
            grid_Basket.Columns[6].ReadOnly = true;
            grid_Basket.Columns[6].Width = 50;
            grid_Basket.Columns[6].DefaultCellStyle.Format = "N2";
            grid_Basket.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Basket.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[6].DataPropertyName = "QTYPCU_0";

            grid_Basket.Columns[7].Name = "Price";
            grid_Basket.Columns[7].ReadOnly = true;
            grid_Basket.Columns[7].Width = 30;
            grid_Basket.Columns[7].DefaultCellStyle.Format = "N2";
            grid_Basket.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Basket.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[7].DataPropertyName = "Price";

            grid_Basket.Columns[8].Name = "Amount";
            grid_Basket.Columns[8].ReadOnly = true;
            grid_Basket.Columns[8].Width = 80;
            grid_Basket.Columns[8].DefaultCellStyle.Format = "N2";
            grid_Basket.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Basket.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[8].DataPropertyName = "Amount";


            DataGridViewButtonColumn deleteCreditButton = new DataGridViewButtonColumn();
            deleteCreditButton.Width = 50;
            deleteCreditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteCreditButton.Name = "Delete";
            deleteCreditButton.Visible = true;
            deleteCreditButton.Text = "Delete";
            deleteCreditButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteCreditButton.UseColumnTextForButtonValue = true;
            if (grid_Basket.Columns["Delete"] == null)
            {
                grid_Basket.Columns.Insert(9, deleteCreditButton);
            }
            deleteCreditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;



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
        private void grid_stock_Init()
        {
            grid_stock.AutoGenerateColumns = false;
            grid_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_stock.ColumnCount = 15;

            grid_stock.Columns[0].Name = "Site";
            grid_stock.Columns[0].ReadOnly = true;
            grid_stock.Columns[0].Width = 20;
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
            grid_stock.Columns[2].Width = 55;
            grid_stock.Columns[2].MinimumWidth = 55;
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

            grid_stock.Columns[10].Name = "Receipt quantity";
            grid_stock.Columns[10].ReadOnly = false;
            grid_stock.Columns[10].Visible = false;
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

            grid_stock.Columns[12].Name = "Expiration";
            grid_stock.Columns[12].ReadOnly = true;
            grid_stock.Columns[12].Width = 60;
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

        private void grid_TempHeader_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String ASMNumber = grid_TempHeader.Rows[e.RowIndex].Cells["Number"].Value.ToString().Trim();
                String Site = grid_TempHeader.Rows[e.RowIndex].Cells["Site"].Value.ToString().Trim();

                connSalesOrder.sp_ASSEMBLY_SELECT_DETAIL(grid_detail, ASMNumber);
                grid_Basket.DataSource = null;
                grid_Basket.Rows.Clear();
                grid_Basket.Refresh();

                txt_ASMNumber.Text = ASMNumber;
                cbo_storageSite.Text = Site;
                dateTimePickerAcc.Value = System.DateTime.Now;
                txt_Memo.Text = "";
                grid_Basket.Columns["Delete"].Visible = true;
                connSalesOrder.sp_ASSEMBLY_SELECT_DETAIL(grid_Basket, "GRID_BASKET_INITIALIZE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Initialize_Information()
        {
            txt_globalAllocated.Text = "";
            txt_ProductDesc.Text = "";
            txt_IssueQty.Text = "";
            txt_availableQty.Text = "";
            txt_PackSize.Text = "";
            txt_BasePrice.Text = "";
            cbo_Status.Text = "";
            txt_ReceiptQty.Text = "";
        }
        private void grid_header_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Initialize_Information();
                grid_stock.DataSource = null;
                grid_stock.Rows.Clear();
                grid_stock.Refresh();
                grid_Basket.DataSource = null;
                grid_Basket.Rows.Clear();
                grid_Basket.Refresh();

                grid_Basket.Columns["Delete"].Visible = false;
                String ASMNumber = grid_header.Rows[e.RowIndex].Cells["Number"].Value.ToString().Trim();
                String Site = grid_header.Rows[e.RowIndex].Cells["Site"].Value.ToString().Trim();

                txt_ASMNumber.Text = ASMNumber;
                cbo_storageSite.Text = Site;

                connSalesOrder.txt_DisReceipt("SMVTH", dateTimePickerAcc, txt_Memo, ASMNumber);
                connSalesOrder.sp_ASSEMBLY_SELECT_DETAIL(grid_detail, ASMNumber);
                connSalesOrder.sp_ASSEMBLYRECEIPT_SELECT_DETAIL(grid_Basket, ASMNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbo_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LotInformationByProductID();
            }
        }

        private void cbo_product_SelectedValueChanged(object sender, EventArgs e)
        {
            Initialize_Information();
            grid_stock.DataSource = null;
            LotInformationByProductID();
        }

        private void cbo_product_TextUpdate(object sender, EventArgs e)
        {
            Initialize_Information();
            grid_stock.DataSource = null;

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
                //btn_Receipt.Enabled = true;
            }
            catch { }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            connSalesOrder.sp_ASSEMBLY_SELECT_ASSEMBLED(grid_header, FromDate, ToDate);
        }
        private void btn_RefreshWIP_Click(object sender, EventArgs e)
        {
            connSalesOrder.sp_ASSEMBLY_SELECT_TEMP(grid_TempHeader);
        }
        private void cbo_storageSite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LotInformationByProductID();
            }
        }

        private void cbo_storageSite_SelectedValueChanged(object sender, EventArgs e)
        {
            LotInformationByProductID();
        }

        private void grid_stock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in this.grid_stock.Rows)
                {
                    row.Cells["Receipt quantity"].Style.BackColor = Color.OldLace;
                    if (!row.Cells["Status"].Value.ToString().Equals("A"))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        row.Cells["Receipt quantity"].Style.BackColor = Color.LightGray;
                        row.Cells["Receipt quantity"].ReadOnly = true;
                    }
                }
            }
            catch { }
        }


        private void grid_Basket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 9 && e.RowIndex >= 0) // Delete button
                {
                    String ProductID = grid_Basket.Rows[e.RowIndex].Cells["Product ID"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Are you sure to delete this product(" + ProductID + ")?"
                                                            , "Confirming", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        grid_Basket.Rows.RemoveAt(e.RowIndex);

                        if (grid_Basket.RowCount == 0)
                        {
                            btn_Save.Enabled = false;
                        }

                    }
                }
            }
            catch { }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                String ProductID = cbo_product.Text.ToString();
                String InputSite = cbo_storageSite.Text.ToString();
                String InputStatus = cbo_Status.Text.ToString();
                if (InputSite.Equals("") || ProductID.Equals("") || txt_ReceiptQty.Text.Equals("") || InputStatus.Equals(""))
                {
                    MessageBox.Show("Check the input value.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (grid_Basket.RowCount > 0)
                {
                    String Site = grid_Basket.Rows[0].Cells["Site"].Value.ToString();
                    if (!cbo_storageSite.Text.ToString().Equals(Site)) //Site 통일
                    {
                        MessageBox.Show("You can choose only one site."
                                                   , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    foreach (DataGridViewRow row in this.grid_Basket.Rows)
                    {
                        if (row.Cells["Product ID"].Value.ToString().Equals(ProductID))
                        {
                            MessageBox.Show("Same Product exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                }
                DataTable dataTable = this.grid_Basket.DataSource as DataTable;
                DataRow drToAdd = dataTable.NewRow();
                int i = grid_Basket.RowCount;
                drToAdd["STOFCY_0"] = cbo_storageSite.Text.ToString();
                drToAdd["ITMREF_0"] = cbo_product.Text.ToString();
                drToAdd["ITMDES1_0"] = txt_ProductDesc.Text.ToString();
                drToAdd["LOT_0"] = "";
                drToAdd["STA_0"] = cbo_Status.Text.ToString();
                drToAdd["Expiration"] = dateTimePickerExpired.Value.Date.ToShortDateString();
                drToAdd["QTYPCU_0"] = txt_ReceiptQty.Text.ToString();
                drToAdd["Price"] = txt_BasePrice.Text.ToString();
                drToAdd["Amount"] = (Convert.ToDecimal(txt_ReceiptQty.Text.ToString()) *
                    Convert.ToDecimal(txt_BasePrice.Text.ToString())).ToString("N2");

                dataTable.Rows.Add(drToAdd);

                dataTable.AcceptChanges();

                this.grid_Basket.ClearSelection();

                btn_Save.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Try again.\n\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void AssemblyReceipt_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabWIP;
            grid_TempHeader.CurrentCell = grid_TempHeader.Rows[0].Cells[0];
            grid_TempHeader_CellEnter(this.grid_TempHeader, new DataGridViewCellEventArgs(0, 0));
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabWIP)
            {
                txt_Memo.Enabled = true;
                btn_Add.Enabled = true;
                cbo_product.Enabled = true;
                if (grid_TempHeader.RowCount > 0)
                {
                    grid_TempHeader.Rows[0].Selected = true;
                    grid_TempHeader.CurrentCell = grid_TempHeader.Rows[0].Cells[0];
                    grid_TempHeader_CellEnter(this.grid_TempHeader, new DataGridViewCellEventArgs(0, 0));
                }

            }
            else
            {
                txt_Memo.Enabled = false;
                btn_Add.Enabled = false;
                btn_Save.Enabled = false;
                cbo_product.Text = "";
                cbo_product.Enabled = false;
                if (grid_header.RowCount > 0)
                {
                    grid_header.Rows[0].Selected = true;
                    grid_header.CurrentCell = grid_header.Rows[0].Cells[0];
                    grid_header_CellEnter(this.grid_header, new DataGridViewCellEventArgs(0, 0));
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(cbo_storageSite.Text.Equals("BCS") || cbo_storageSite.Text.Equals("WH2")))
                {
                    MessageBox.Show("Please choose the site 'BCS' or 'WH2'.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (grid_Basket.RowCount < 1)
                {
                    MessageBox.Show("Please add first.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_ASMNumber.Text.Length == 0)
                {
                    MessageBox.Show("Please select DISNumber first.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you sure to continue Assembly receipt process?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    String NewSTKNumber = connSalesOrder.sp_GET_NewSTKNumber();
                    String ASMNumber = txt_ASMNumber.Text.ToString();
                    String CompanyCode = cbo_Company.Text.ToString();
                    String Site = grid_Basket.Rows[0].Cells["Site"].Value.ToString();
                    DateTime AccountingDate = dateTimePickerAcc.Value.Date;
                    String Memo = txt_Memo.Text.ToString();

                    for (int i = 0; i < grid_Basket.RowCount; i++)
                    {
                        String LOTNumber = connSalesOrder.sp_GET_NewLOTNumber();
                        String ProductID = grid_Basket.Rows[i].Cells["Product ID"].Value.ToString();
                        String Status = grid_Basket.Rows[i].Cells["Status"].Value.ToString();
                        decimal Qty = Convert.ToDecimal(grid_Basket.Rows[i].Cells["Quantity"].Value);
                        DateTime ExpirationDate = Convert.ToDateTime(grid_Basket.Rows[i].Cells["Expiration"].Value);

                        String SaveResult = connSalesOrder.sp_ASSEMBLYRECEIPT_SAVE(NewSTKNumber, ASMNumber, LOTNumber, AccountingDate, CompanyCode, Site, ProductID,
                            Status, ExpirationDate, Memo, Qty, i + 1);

                        if (!SaveResult.Equals("Success"))
                        {
                            MessageBox.Show(SaveResult, "※COTACT IT TEAM※", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    String SaveHeaderResult = connSalesOrder.sp_ASSEMBLYRECEIPT_SAVE_HEADER(NewSTKNumber, ASMNumber, AccountingDate, Memo, CompanyCode, Site);
                    if (!SaveHeaderResult.Equals("Success"))
                    {
                        MessageBox.Show(SaveHeaderResult, "※COTACT IT TEAM※", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Initialized();
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : " + ex.Message.ToString() + "", "※COTACT IT TEAM※", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Initialized()
        {
            Initialize_Information();
            txt_ASMNumber.Text = "";
            txt_Memo.Text = "";
            grid_stock.DataSource = null;
            grid_stock.Rows.Clear();
            grid_stock.Refresh();
            grid_Basket.DataSource = null;
            grid_Basket.Rows.Clear();
            grid_Basket.Refresh();

            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;

            connSalesOrder.sp_ASSEMBLY_SELECT_DETAIL(grid_Basket, "GRID_BASKET_INITIALIZE");
            connSalesOrder.sp_ASSEMBLY_SELECT_ASSEMBLED(grid_header, FromDate, ToDate);
            LotInformationByProductID();
            connSalesOrder.sp_ASSEMBLY_SELECT_TEMP(grid_TempHeader);
        }
        private void txt_ReceiptQty_KeyPress(object sender, KeyPressEventArgs e)
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


    }
}


//private void grid_header_Init(DataGridView gridView)
//{
//    gridView.AutoGenerateColumns = false;
//    gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//    gridView.ColumnCount = 7;

//    gridView.Columns[0].Name = "Company";
//    gridView.Columns[0].ReadOnly = true;
//    gridView.Columns[0].Width = 30;
//    gridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
//    gridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
//    gridView.Columns[0].DataPropertyName = "CPY_0";

//    gridView.Columns[1].Name = "Site";
//    gridView.Columns[1].ReadOnly = true;
//    gridView.Columns[1].Width = 20;
//    gridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
//    gridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
//    gridView.Columns[1].DataPropertyName = "STOFCY_0";

//    gridView.Columns[2].Name = "Number";
//    gridView.Columns[2].ReadOnly = true;
//    gridView.Columns[2].Width = 50;
//    gridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
//    gridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
//    gridView.Columns[2].DataPropertyName = "VCRNUM_0";

//    gridView.Columns[3].Name = "Transaction Date";
//    gridView.Columns[3].ReadOnly = true;
//    gridView.Columns[3].Width = 60;
//    gridView.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
//    gridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
//    gridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
//    gridView.Columns[3].DataPropertyName = "IPTDAT_0";

//    gridView.Columns[4].Name = "Accounting Date";
//    if (gridView.Name.Equals("grid_TempHeader"))
//    {
//        gridView.Columns[4].Visible = false;
//    }
//    gridView.Columns[4].ReadOnly = true;
//    gridView.Columns[4].Width = 60;
//    gridView.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
//    gridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
//    gridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
//    gridView.Columns[4].DataPropertyName = "ACCDAT_0";

//    gridView.Columns[5].Name = "Memo";
//    gridView.Columns[5].ReadOnly = true;
//    gridView.Columns[5].Width = 100;
//    gridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
//    gridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
//    gridView.Columns[5].DataPropertyName = "VCRDES_0";

//    gridView.Columns[6].Name = "Status";
//    gridView.Columns[6].Visible = false;
//    gridView.Columns[6].ReadOnly = true;
//    gridView.Columns[6].Width = 70;
//    gridView.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
//    gridView.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
//    gridView.Columns[6].DataPropertyName = "Status";

//    //grid font size custom
//    gridView.RowTemplate.Height = 20;
//    gridView.ColumnHeadersHeight = 30;

//    foreach (DataGridViewColumn c in gridView.Columns)
//    {
//        //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
//        c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
//    }

//    gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
//}