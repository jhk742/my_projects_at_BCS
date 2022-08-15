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
    public partial class StockChange : Form
    {
        public StockChange()
        {
            InitializeComponent();
            grid_header_Init();
            grid_stock_Init();
            grid_Detail_Init();
            grid_Basket_Init();


            connSalesOrder.cbo_Company(cbo_Company);
            cbo_Company.SelectedItem = "BIC";
            txt_CompanyName.Text = connSalesOrder.getCompanyName(cbo_Company.Text.ToString());

            cbo_storageSite.Items.Add("BCS");
            cbo_storageSite.Items.Add("WH2");
            cbo_storageSite.SelectedItem = "BCS";

            //아이템 가져오기
            connSalesOrder.cbo_itemID(cbo_product);

            dateTimePickerFrom.Value = DateTime.Now.AddYears(-1);

            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;


            connSalesOrder.sp_STOCKCHANGE_SELECT(grid_header, FromDate, ToDate);
            connSalesOrder.sp_STOCKCHANGE_SELECT_DETAIL(grid_Basket, "GRID_BASKET_INITIALIZE");

        }
        private void grid_header_Init()
        {
            grid_header.AutoGenerateColumns = false;
            grid_header.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_header.ColumnCount = 7;

            grid_header.Columns[0].Name = "Company";
            grid_header.Columns[0].ReadOnly = true;
            grid_header.Columns[0].Width = 30;
            grid_header.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[0].DataPropertyName = "CPY_0";

            grid_header.Columns[1].Name = "Storage site";
            grid_header.Columns[1].ReadOnly = true;
            grid_header.Columns[1].Width = 40;
            grid_header.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[1].DataPropertyName = "STOFCY_0";

            grid_header.Columns[2].Name = "Destination site";
            grid_header.Columns[2].ReadOnly = true;
            grid_header.Columns[2].Visible = false;
            grid_header.Columns[2].Width = 50;
            grid_header.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[2].DataPropertyName = "FCYDES_0";

            grid_header.Columns[3].Name = "Number";
            grid_header.Columns[3].ReadOnly = true;
            grid_header.Columns[3].Width = 70;
            grid_header.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[3].DataPropertyName = "VCRNUM_0";

            grid_header.Columns[4].Name = "Transaction Date";
            grid_header.Columns[4].ReadOnly = true;
            grid_header.Columns[4].Width = 70;
            grid_header.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_header.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[4].DataPropertyName = "IPTDAT_0";

            grid_header.Columns[5].Name = "Memo";
            grid_header.Columns[5].ReadOnly = true;
            grid_header.Columns[5].Width = 150;
            grid_header.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[5].DataPropertyName = "VCRDES_0";

            grid_header.Columns[6].Name = "User";
            grid_header.Columns[6].ReadOnly = true;
            grid_header.Columns[6].Width = 50;
            grid_header.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[6].DataPropertyName = "CREUSR_0";


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
            grid_detail.Columns[0].Width = 40;
            grid_detail.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[0].DataPropertyName = "OWNER_0";

            grid_detail.Columns[1].Name = "Product ID";
            grid_detail.Columns[1].ReadOnly = true;
            grid_detail.Columns[1].Width = 50;
            grid_detail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[1].DataPropertyName = "ITMREF_0";

            grid_detail.Columns[2].Name = "Description";
            grid_detail.Columns[2].ReadOnly = true;
            grid_detail.Columns[2].Width = 130;
            grid_detail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[2].DataPropertyName = "ITMDES1_0";

            grid_detail.Columns[3].Name = "Lot number";
            grid_detail.Columns[3].ReadOnly = true;
            grid_detail.Columns[3].Width = 65;
            grid_detail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[3].DataPropertyName = "LOT_0";

            grid_detail.Columns[4].Name = "Status";
            grid_detail.Columns[4].ReadOnly = true;
            grid_detail.Columns[4].Width = 40;
            grid_detail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[4].DataPropertyName = "STA_0";

            grid_detail.Columns[5].Name = "Destination status";
            grid_detail.Columns[5].ReadOnly = true;
            grid_detail.Columns[5].Width = 50;
            grid_detail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[5].DataPropertyName = "DestStatus";

            grid_detail.Columns[6].Name = "Expiration Date";
            grid_detail.Columns[6].ReadOnly = true;
            grid_detail.Columns[6].Visible = true;
            grid_detail.Columns[6].Width = 55;
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
            grid_detail.Columns[9].Width = 70;
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
            grid_stock.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[1].DataPropertyName = "ITMREF_0";

            grid_stock.Columns[2].Name = "Lot number";
            grid_stock.Columns[2].ReadOnly = true;
            grid_stock.Columns[2].Width = 65;
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
            grid_stock.Columns[5].Width = 55;
            grid_stock.Columns[5].DataPropertyName = "InitialQty";

            grid_stock.Columns[6].Name = "Remaining quantity";
            grid_stock.Columns[6].ReadOnly = true;
            grid_stock.Columns[6].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[6].Width = 55;
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

            DataGridViewComboBoxColumn cbo_Status = new DataGridViewComboBoxColumn();
            cbo_Status.HeaderText = "Destination status";
            cbo_Status.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cbo_Status.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cbo_Status.Name = "Destination_status";
            cbo_Status.DataSource = new string[] { "", "A", "Q", "R" };
            cbo_Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cbo_Status.ReadOnly = false;
            cbo_Status.Width = 80;
            cbo_Status.FlatStyle = FlatStyle.Popup;
            //cbo_Status.DefaultCellStyle.BackColor = Color.Aqua;
            cbo_Status.SortMode = DataGridViewColumnSortMode.Automatic;
            grid_stock.Columns.Insert(11, cbo_Status);

            grid_stock.Columns[12].Name = "Price";
            grid_stock.Columns[12].ReadOnly = true;
            grid_stock.Columns[12].DefaultCellStyle.Format = "N2";
            grid_stock.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_stock.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[12].Width = 45;
            grid_stock.Columns[12].DataPropertyName = "Price";

            grid_stock.Columns[13].Name = "Expiration Date";
            grid_stock.Columns[13].ReadOnly = true;
            grid_stock.Columns[13].Width = 80;
            grid_stock.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[13].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_stock.Columns[13].DataPropertyName = "Expiration";

            grid_stock.Columns[14].Name = "Update user";
            grid_stock.Columns[14].ReadOnly = true;
            grid_stock.Columns[14].Width = 50;
            grid_stock.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[14].DataPropertyName = "UPDUSER";

            grid_stock.Columns[15].Name = "Update time";
            grid_stock.Columns[15].ReadOnly = true;
            grid_stock.Columns[15].Width = 120;
            grid_stock.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_stock.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_stock.Columns510].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_stock.Columns[15].DataPropertyName = "UPDDATTIM_0";

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

        private void grid_Basket_Init()
        {
            grid_Basket.AutoGenerateColumns = false;
            grid_Basket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Basket.ColumnCount = 10;

            grid_Basket.Columns[0].Name = "Site";
            grid_Basket.Columns[0].ReadOnly = true;
            grid_Basket.Columns[0].Visible = true;
            grid_Basket.Columns[0].Width = 25;
            grid_Basket.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[0].DataPropertyName = "STOFCY_0";

            grid_Basket.Columns[1].Name = "Product ID";
            grid_Basket.Columns[1].ReadOnly = true;
            grid_Basket.Columns[1].Width = 50;
            grid_Basket.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[1].DataPropertyName = "ITMREF_0";

            grid_Basket.Columns[2].Name = "Description";
            grid_Basket.Columns[2].ReadOnly = true;
            grid_Basket.Columns[2].Width = 130;
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
            grid_Basket.Columns[4].Width = 30;
            grid_Basket.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[4].DataPropertyName = "STA_0";

            grid_Basket.Columns[5].Name = "Destination status";
            grid_Basket.Columns[5].ReadOnly = true;
            grid_Basket.Columns[5].Width = 75;
            grid_Basket.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[5].DataPropertyName = "DestStatus";

            grid_Basket.Columns[6].Name = "Expiration Date";
            grid_Basket.Columns[6].ReadOnly = true;
            grid_Basket.Columns[6].Width = 65;
            grid_Basket.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_Basket.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[6].DataPropertyName = "Expiration";

            grid_Basket.Columns[7].Name = "Quantity";
            grid_Basket.Columns[7].ReadOnly = true;
            grid_Basket.Columns[7].Width = 40;
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
            grid_Basket.Columns[9].Width = 70;
            grid_Basket.Columns[9].DefaultCellStyle.Format = "N2";
            grid_Basket.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Basket.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Basket.Columns[9].DataPropertyName = "Amount";


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
                grid_Basket.Columns.Insert(10, deleteCreditButton);
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

        private void grid_header_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            connSalesOrder.sp_STOCKCHANGE_SELECT_DETAIL(grid_detail, grid_header.Rows[e.RowIndex].Cells["Number"].Value.ToString().Trim());
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            connSalesOrder.sp_STOCKCHANGE_SELECT(grid_header, dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);
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
                    MessageBox.Show("Please check Order quantity."
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

        private void grid_Basket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 10 && e.RowIndex >= 0) // Delete button
                {
                    String LotNumber = grid_Basket.Rows[e.RowIndex].Cells["Lot number"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Are you sure to delete this product(" + LotNumber + ")?"
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
        private void cbo_Company_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_CompanyName.Text = connSalesOrder.getCompanyName(cbo_Company.Text.ToString());
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

        private void cbo_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LotInformationByProductID();
            }
        }
        private void ClearValues()
        {
            txt_ProductDesc.Text = "";
            txt_globalAllocated.Text = "";
            txt_availableQty.Text = "";
            txt_IssueQty.Text = "";
            txt_PackSize.Text = "";

            grid_stock.DataSource = null;
            btn_Add.Enabled = false;
        }

        private void cbo_product_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearValues();
            LotInformationByProductID();
        }

        private void cbo_product_TextUpdate(object sender, EventArgs e)
        {
            ClearValues();
        }
        private void Initialized()
        {
            txt_globalAllocated.Text = "";
            txt_IssueQty.Text = "";
            txt_availableQty.Text = "";
            txt_Memo.Text = "";
            grid_stock.DataSource = null;
            grid_stock.Rows.Clear();
            grid_stock.Refresh();
            grid_Basket.DataSource = null;
            grid_Basket.Rows.Clear();
            grid_Basket.Refresh();
            btn_Save.Enabled = false;

            connSalesOrder.sp_STOCKCHANGE_SELECT(grid_header, dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);
            connSalesOrder.sp_STOCKCHANGE_SELECT_DETAIL(grid_Basket, "GRID_BASKET_INITIALIZE");
            LotInformationByProductID();
        }

        private void grid_stock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                btn_Add.Enabled = true;
                foreach (DataGridViewRow row in this.grid_stock.Rows)
                {
                    row.Cells["Order quantity"].Style.BackColor = Color.OldLace;
                }
                if (grid_stock.RowCount == 0)
                {
                    btn_Add.Enabled = false;
                }
            }
            catch { }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
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
                        if (string.IsNullOrEmpty(grid_stock.Rows[i].Cells["Destination_status"].Value as string))
                        {
                            MessageBox.Show("Input destination status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (grid_stock.Rows[i].Cells["Destination_status"].Value.ToString().Equals(grid_stock.Rows[i].Cells["Status"].Value.ToString()))
                            {
                                MessageBox.Show("Double check if you put the correct destination status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }
                if ((GlobalCheck < Convert.ToDecimal(txt_globalAllocated.Text.Trim())) && cbo_storageSite.Text.Equals("BCS"))
                {
                    MessageBox.Show("Please check BCS GLOBAL quantity."
                                                           , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < grid_stock.RowCount; i++)
                {
                    if (Convert.ToDecimal(grid_stock.Rows[i].Cells["Order quantity"].Value) > 0)
                    {
                        if (grid_Basket.RowCount > 0)
                        {
                            String Site = grid_Basket.Rows[0].Cells["Site"].Value.ToString();
                            if (!grid_stock.Rows[i].Cells["Site"].Value.ToString().Equals(Site)) //Site 통일
                            {
                                MessageBox.Show("You can choose only one site."
                                                           , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        DataTable dataTable = this.grid_Basket.DataSource as DataTable;
                        DataRow drToAdd = dataTable.NewRow();
                        drToAdd["STOFCY_0"] = grid_stock.Rows[i].Cells["Site"].Value.ToString();
                        drToAdd["ITMREF_0"] = grid_stock.Rows[i].Cells["Product ID"].Value.ToString();
                        drToAdd["ITMDES1_0"] = txt_ProductDesc.Text.ToString();
                        drToAdd["LOT_0"] = grid_stock.Rows[i].Cells["Lot number"].Value.ToString();
                        drToAdd["STA_0"] = grid_stock.Rows[i].Cells["Status"].Value.ToString();
                        drToAdd["DestStatus"] = grid_stock.Rows[i].Cells["Destination_status"].Value.ToString();
                        drToAdd["QTYPCU_0"] = grid_stock.Rows[i].Cells["Order Quantity"].Value.ToString();
                        drToAdd["Expiration"] = grid_stock.Rows[i].Cells["Expiration Date"].Value.ToString();
                        drToAdd["Price"] = grid_stock.Rows[i].Cells["Price"].Value.ToString();
                        drToAdd["Amount"] = (Convert.ToDecimal(grid_stock.Rows[i].Cells["Order Quantity"].Value) *
                            Convert.ToDecimal(grid_stock.Rows[i].Cells["Price"].Value)).ToString("N2");

                        dataTable.Rows.Add(drToAdd);

                        dataTable.AcceptChanges();

                        this.grid_Basket.ClearSelection();

                        btn_Save.Enabled = true;
                        cbo_product.Select();
                    }
                }
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

                DistinctProductList = ProductList.Distinct().ToArray(); // DISTINCT ITEM ARRAY FOR BASKET RECEIPT GRIDVIEW

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
            
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                String CompanyCode = cbo_Company.Text.ToString();
                DateTime AccDate = dateTimePickerAcc.Value;
                String Memo = txt_Memo.Text.ToString();
                String Site = cbo_storageSite.Text.ToString();


                DialogResult dialogResult = MessageBox.Show("Are you sure to continue Stock Change process?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    if (!REALTIME_STOCKCHECK()) return;

                    String NewBCSCHGNumber = connSalesOrder.sp_GET_NewBCSCHGNumber();

                    if (!NewBCSCHGNumber.Contains("BCSCHG"))
                    {
                        MessageBox.Show("Please try again.(BCSCHG) (Error code: " + NewBCSCHGNumber + ")", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    String SaveHeaderResult = connSalesOrder.sp_STOCKCHANGE_SAVE_HEADER(NewBCSCHGNumber, CompanyCode, AccDate, Memo, Site);

                    if (!SaveHeaderResult.Equals("Success"))
                    {
                        MessageBox.Show(SaveHeaderResult, "※COTACT IT TEAM※", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }

                    for (int i = 0; i < grid_Basket.RowCount; i++)
                    {
                        String ProductID = grid_Basket.Rows[i].Cells["Product ID"].Value.ToString();
                        String LOT = grid_Basket.Rows[i].Cells["Lot number"].Value.ToString();
                        Decimal StockChangeQty = Convert.ToDecimal(grid_Basket.Rows[i].Cells["Quantity"].Value);
                        String Status = grid_Basket.Rows[i].Cells["Status"].Value.ToString();
                        String DestStatus = grid_Basket.Rows[i].Cells["Destination status"].Value.ToString();

                        String SaveDetailResult = connSalesOrder.sp_STOCKCHANGE_SAVE(NewBCSCHGNumber, ProductID, LOT, StockChangeQty, Status, DestStatus, i + 1);
                        if (!SaveDetailResult.Equals("Success"))
                        {
                            MessageBox.Show(SaveDetailResult, "※COTACT IT TEAM※", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Initialized();
                    cbo_product.Focus();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : " + ex.Message.ToString() + "", "※COTACT IT TEAM※", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
