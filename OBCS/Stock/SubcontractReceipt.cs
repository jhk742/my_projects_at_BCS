using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Stock
{
    public partial class SubcontractReceipt : Form
    {

        public SubcontractReceipt()
        {
            InitializeComponent();
            grid_header_Init();
            grid_TempHeader_Init();
            grid_Detail_Init();
            grid_DetailReceipt_Init();

            connSalesOrder.cbo_Company(cbo_Company);
            //cbo_Company.SelectedItem = "BIC";
            //txt_CompanyName.Text = connSalesOrder.getCompanyName(cbo_Company.Text.ToString());

            //connSalesOrder.cbo_site(cbo_storageSite);
            cbo_storageSite.Items.Add("BCS");
            cbo_storageSite.Items.Add("WH2");
            //cbo_storageSite.SelectedItem = "BCS";
            //아이템 가져오기

            cbo_Supplier.Items.Add("");
            cbo_Supplier.Items.Add("HERSHEL");
            cbo_Supplier.Items.Add("HABCO");
            dateTimePickerFrom.Value = DateTime.Now.AddYears(-1);

            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;

            connSalesOrder.sp_SUBCONTRACTRECEIPT_SELECT_TEMP(grid_TempHeader);
            connSalesOrder.sp_SUBCONTRACTRECEIPT_SELECT(grid_header,FromDate,ToDate);

            tabControl1.SelectedTab = tabWIP;
        }
        private void grid_header_Init()
        {
            grid_header.AutoGenerateColumns = false;
            grid_header.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_header.ColumnCount = 10;

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
            grid_header.Columns[6].Visible = false;
            grid_header.Columns[6].Width = 150;
            grid_header.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[6].DataPropertyName = "MEMO";

            grid_header.Columns[7].Name = "Receipt Memo";
            grid_header.Columns[7].ReadOnly = true;
            grid_header.Columns[7].Width = 150;
            grid_header.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[7].DataPropertyName = "RECMEMO";

            grid_header.Columns[8].Name = "Transaction Date";
            grid_header.Columns[8].ReadOnly = true;
            grid_header.Columns[8].Width = 60;
            grid_header.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_header.Columns[8].DataPropertyName = "CREDAT_0";

            grid_header.Columns[9].Name = "User";
            grid_header.Columns[9].ReadOnly = true;
            grid_header.Columns[9].Width = 50;
            grid_header.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_header.Columns[9].DataPropertyName = "CREUSR_0";


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
            grid_TempHeader.ColumnCount = 9;

            grid_TempHeader.Columns[0].Name = "No.";
            grid_TempHeader.Columns[0].ReadOnly = true;
            grid_TempHeader.Columns[0].Width = 20;
            grid_TempHeader.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[0].DataPropertyName = "NUM_0";

            grid_TempHeader.Columns[1].Name = "Company";
            grid_TempHeader.Columns[1].ReadOnly = true;
            grid_TempHeader.Columns[1].Width = 40;
            grid_TempHeader.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[1].DataPropertyName = "CPY_0";

            grid_TempHeader.Columns[2].Name = "Storage site";
            grid_TempHeader.Columns[2].ReadOnly = true;
            grid_TempHeader.Columns[2].Width = 55;
            grid_TempHeader.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[2].DataPropertyName = "STOFCY_0";

            grid_TempHeader.Columns[3].Name = "Supplier Code";
            grid_TempHeader.Columns[3].ReadOnly = true;
            grid_TempHeader.Columns[3].Width = 70;
            grid_TempHeader.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[3].DataPropertyName = "LOC_0";

            grid_TempHeader.Columns[4].Name = "Supplier Name";
            grid_TempHeader.Columns[4].ReadOnly = true;
            grid_TempHeader.Columns[4].Visible = false;
            grid_TempHeader.Columns[4].Width = 60;
            grid_TempHeader.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[4].DataPropertyName = "BPSNAM_0";

            grid_TempHeader.Columns[5].Name = "Service";
            grid_TempHeader.Columns[5].ReadOnly = true;
            grid_TempHeader.Columns[5].Width = 60;
            grid_TempHeader.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[5].DataPropertyName = "SRVITMREF_0";

            grid_TempHeader.Columns[6].Name = "Memo";
            grid_TempHeader.Columns[6].ReadOnly = true;
            grid_TempHeader.Columns[6].Width = 150;
            grid_TempHeader.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[6].DataPropertyName = "MEMO";

            grid_TempHeader.Columns[7].Name = "Transaction Date";
            grid_TempHeader.Columns[7].ReadOnly = true;
            grid_TempHeader.Columns[7].Width = 60;
            grid_TempHeader.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[7].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_TempHeader.Columns[7].DataPropertyName = "CREDAT_0";

            grid_TempHeader.Columns[8].Name = "User";
            grid_TempHeader.Columns[8].ReadOnly = true;
            grid_TempHeader.Columns[8].Width = 50;
            grid_TempHeader.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TempHeader.Columns[8].DataPropertyName = "CREUSR_0";


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
            grid_detailReceipt.ColumnCount = 11;

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
            grid_detailReceipt.Columns[6].Width = 55;
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
            grid_detailReceipt.Columns[9].Width = 70;
            grid_detailReceipt.Columns[9].DefaultCellStyle.Format = "N2";
            grid_detailReceipt.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detailReceipt.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[9].DataPropertyName = "Amount";

            grid_detailReceipt.Columns[10].Name = "Expiration";
            grid_detailReceipt.Columns[10].ReadOnly = false;
            grid_detailReceipt.Columns[10].Width = 90;
            //grid_detailReceipt.Columns[10].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_detailReceipt.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detailReceipt.Columns[10].DataPropertyName = "Expiration";

            //grid_detailReceipt.Columns[11].Name = "Memo";
            //grid_detailReceipt.Columns[11].ReadOnly = false;
            //grid_detailReceipt.Columns[11].Width = 150;
            //grid_detailReceipt.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_detailReceipt.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_detailReceipt.Columns[11].DataPropertyName = "Memo";

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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;

            connSalesOrder.sp_SUBCONTRACTRECEIPT_SELECT(grid_header, FromDate, ToDate);
        }
        private void btn_RefreshWIP_Click(object sender, EventArgs e)
        {
            connSalesOrder.sp_SUBCONTRACTRECEIPT_SELECT_TEMP(grid_TempHeader);
        }
        
       

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                txt_ReceiptMemo.Enabled = false;
                btn_Save.Enabled = false;
                grid_detail.DataSource = null;
                grid_detailReceipt.DataSource = null;
                txt_ReceiptMemo.Text = "";

                if (e.TabPage == tabWIP)
                {
                    if (grid_TempHeader.RowCount > 0)
                    {
                        grid_TempHeader.Rows[0].Selected = true;
                        grid_TempHeader.CurrentCell = grid_TempHeader.Rows[0].Cells[0];
                        grid_TempHeader_CellEnter(this.grid_TempHeader, new DataGridViewCellEventArgs(0, 0));
                        txt_ReceiptMemo.Enabled = true;
                        btn_Save.Enabled = true;
                    }
                }
                else
                {

                    if (grid_header.RowCount > 0)
                    {
                        grid_header.Rows[0].Selected = true;
                        grid_header.CurrentCell = grid_header.Rows[0].Cells[0];
                        grid_header_CellEnter(this.grid_header, new DataGridViewCellEventArgs(0, 0));
                    }
                }
            }
            catch { }
            
        }

        private void grid_header_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String No = grid_header.Rows[e.RowIndex].Cells["No."].Value.ToString();
                String CompanyCode = grid_header.Rows[e.RowIndex].Cells["Company"].Value.ToString();
                String StorageSite = grid_header.Rows[e.RowIndex].Cells["Storage site"].Value.ToString();
                String SupplierCode = grid_header.Rows[e.RowIndex].Cells["Supplier Code"].Value.ToString();
                String Service = grid_header.Rows[e.RowIndex].Cells["Service"].Value.ToString();
                String OrderMemo = grid_header.Rows[e.RowIndex].Cells["Memo"].Value.ToString();
                String ReceiptMemo = grid_header.Rows[e.RowIndex].Cells["Receipt Memo"].Value.ToString();

                cbo_Company.Text = CompanyCode;
                cbo_storageSite.Text = StorageSite;
                cbo_Supplier.Text = SupplierCode;
                txt_Service.Text = Service;
                txt_OrderMemo.Text = OrderMemo;
                txt_ReceiptMemo.Text = ReceiptMemo;

                connSalesOrder.sp_SUBCONTRACT_SELECT_DETAIL(grid_detail, No);
                connSalesOrder.sp_SUBCONTRACT_SELECT_RECDETAIL(grid_detailReceipt, No);
            }
            catch { }
            
        }

        private void grid_TempHeader_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String No = grid_TempHeader.Rows[e.RowIndex].Cells["No."].Value.ToString();
                String CompanyCode = grid_TempHeader.Rows[e.RowIndex].Cells["Company"].Value.ToString();
                String StorageSite = grid_TempHeader.Rows[e.RowIndex].Cells["Storage site"].Value.ToString();
                String SupplierCode = grid_TempHeader.Rows[e.RowIndex].Cells["Supplier Code"].Value.ToString();
                String Service = grid_TempHeader.Rows[e.RowIndex].Cells["Service"].Value.ToString();
                String OrderMemo = grid_TempHeader.Rows[e.RowIndex].Cells["Memo"].Value.ToString();

                cbo_Company.Text = CompanyCode;
                cbo_storageSite.Text = StorageSite;
                cbo_Supplier.Text = SupplierCode;
                txt_Service.Text = Service;
                txt_OrderMemo.Text = OrderMemo;

                connSalesOrder.sp_SUBCONTRACT_SELECT_DETAIL(grid_detail, No);
                connSalesOrder.sp_SUBCONTRACT_SELECT_RECDETAIL(grid_detailReceipt, No);
            }
            catch { }
        }

        private void cbo_Company_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_CompanyName.Text = connSalesOrder.getCompanyName(cbo_Company.Text.ToString());
        }

        private void SubcontractReceipt_Load(object sender, EventArgs e)
        {
            try
            {
                txt_ReceiptMemo.Text = "";
                if (grid_TempHeader.RowCount > 0)
                {
                    btn_Save.Enabled = true;
                    txt_ReceiptMemo.Enabled = true;
                }
            }
            catch
            {
                //
            }
            
        }

        private string format;

        private void grid_detailReceipt_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                try
                {

                    CultureInfo provider = CultureInfo.InvariantCulture;
                    string dateString = grid_detailReceipt.CurrentRow.Cells["Expiration"].Value.ToString().Trim();
                    //MessageBox.Show(dateString);
                    if (dateString.Length == 6)
                    {
                        format = "MMddyy";
                    }
                    else if (dateString.Length == 8)
                    {
                        format = "MMddyyyy";
                    }
                    else if (dateString.Length == 10)
                    {
                        format = "MM/dd/yyyy";
                    }
                    DateTime result = DateTime.ParseExact(dateString, format, provider);
                    grid_detailReceipt.CurrentRow.Cells["Expiration"].Value = result.ToString("MM/dd/yyyy");
                    //MessageBox.Show(grid_detail.CurrentRow.Cells["Expiration Date"].Value.ToString().Trim());
                    //DateTime Today = DateTime.Now.Date;
                    //if ((result <= Today) && (!result.ToString("MM/dd/yyyy").Equals("01/01/1900")))
                    //{
                    //    MessageBox.Show("Please input a date after today. ("+Today.ToShortDateString()+")", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //    grid_detailReceipt.CurrentRow.Cells["Expiration"].Value = "01/01/1900";
                    //    return;
                    //}

                }
                catch
                {
                    MessageBox.Show("Please check the Date format\n(Please try 'MMddyy', 'MMddyyyy', 'MM/dd/yyyy')", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    grid_detailReceipt.CurrentRow.Cells["Expiration"].Value = "01/01/1900";
                }
            }
        }
        private void grid_detailReceipt_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabWIP)
                {
                    foreach (DataGridViewRow row in this.grid_detailReceipt.Rows)
                    {
                        row.Cells["Expiration"].Style.BackColor = Color.OldLace;
                        row.Cells["Expiration"].ReadOnly = false;
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in this.grid_detailReceipt.Rows)
                    {
                        row.Cells["Expiration"].ReadOnly = true;
                    }
                }
                
            }
            catch { }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_detailReceipt.RowCount; i++)
            {
                if (string.IsNullOrEmpty(grid_detailReceipt.Rows[i].Cells["Expiration"].Value as string))
                {
                    MessageBox.Show("Please input the expiration date.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;

                }
                else {
                    String ExpirationDate = grid_detailReceipt.Rows[i].Cells["Expiration"].Value.ToString().Trim();

                    if (ExpirationDate.Length == 0)
                    {
                        MessageBox.Show("Please input the expiration date.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    if (Convert.ToDateTime(ExpirationDate) < DateTime.Now.Date)
                    {
                        MessageBox.Show("Please input a date after today. (" + DateTime.Now.ToShortDateString() + ")", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                } 
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure to continue Subcontract receipt?"
                                                       , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                String CompanyCode = cbo_Company.Text.ToString();
                String StorageSite = cbo_storageSite.Text.ToString();

                for (int i = 0; i < grid_detailReceipt.RowCount; i++)
                {
                    String BCSSCNumber = grid_detailReceipt.Rows[i].Cells["Number"].Value.ToString();
                    String NewRECNumber = connSalesOrder.sp_GET_NewRECNumber();
                    DateTime ExpirationDate = Convert.ToDateTime(grid_detailReceipt.Rows[i].Cells["Expiration"].Value);
                    String SupplierID = cbo_Supplier.Text.ToString();
                    String Memo = txt_ReceiptMemo.Text.ToString();

                    String SaveResult = connSalesOrder.sp_SUBCONTRACTRECEIPT_SAVE(CompanyCode, StorageSite, BCSSCNumber, ExpirationDate, NewRECNumber, SupplierID, Memo);

                    if (!SaveResult.Equals("Success"))
                    {
                        MessageBox.Show(SaveResult, "※COTACT IT TEAM※", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    
                }

                MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DateTime FromDate = dateTimePickerFrom.Value.Date;
                DateTime ToDate = dateTimePickerTo.Value.Date;

                connSalesOrder.sp_SUBCONTRACTRECEIPT_SELECT_TEMP(grid_TempHeader);
                connSalesOrder.sp_SUBCONTRACTRECEIPT_SELECT(grid_header, FromDate, ToDate);
                connSalesOrder.sp_SUBCONTRACT_SELECT_DETAIL(grid_detail, "0");
                connSalesOrder.sp_SUBCONTRACT_SELECT_RECDETAIL(grid_detailReceipt, "0");

                if (grid_TempHeader.RowCount > 0)
                {
                    grid_TempHeader.Rows[0].Selected = true;
                    grid_TempHeader.CurrentCell = grid_TempHeader.Rows[0].Cells[0];
                    grid_TempHeader_CellEnter(this.grid_TempHeader, new DataGridViewCellEventArgs(0, 0));
                }
                else
                {
                    cbo_Supplier.Text = "";
                    txt_Service.Text = "";
                    txt_OrderMemo.Text = "";
                    txt_ReceiptMemo.Text = "";
                }

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
