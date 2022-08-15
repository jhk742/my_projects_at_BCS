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

namespace OBCS.Purchase
{
    public partial class RECEIPTS : Form
    {
        CustomDateTimePicker dateTimePickerExpirationDate = new CustomDateTimePicker();
        Rectangle rectangle;
        private string format;
        private string SelectedPONumber;
        public RECEIPTS()
        {
            InitializeComponent();
            grid_receipt_Init();
            grid_detail_Init();
            grid_selectionHeader_Init();

            grid_detail.Controls.Add(dateTimePickerExpirationDate);
            dateTimePickerExpirationDate.Visible = false;
            dateTimePickerExpirationDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerExpirationDate.Leave += new EventHandler(dtp_ValueFunction);
            dateTimePickerFrom.Value = DateTime.Today.AddMonths(-1);

            String SearchRECPOID = txt_PRSPOID.Text.Trim();
            String SearchRECRECID = txt_PRSRECID.Text.Trim();
            String SearchRECSupplier = txt_PRSSupplier.Text.Trim();
            String SearchRECSite = cbo_PRSSite.Text.Trim();
            String SearchRECMemo = txt_PRSMemo.Text.Trim();
            String SearchPOID = txt_POSPOID.Text.Trim();
            String SearchPOupplier = txt_POSSupplier.Text.Trim();
            String SearchPOSite = cbo_POSSite.Text.Trim();
            String SearchPOMemo = txt_POSMemo.Text.Trim();

            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;

            connSalesOrder.sp_PORDER_SelectionHeader(grid_selectionHeader, FromDate, ToDate, SearchPOID, SearchPOupplier, SearchPOSite, SearchPOMemo);
            connSalesOrder.sp_PRECEIPT_HEADER(grid_receipt, FromDate, ToDate, SearchRECPOID, SearchRECRECID, SearchRECSupplier, SearchRECSite, SearchRECMemo);

            cbo_site.Items.Add("");
            cbo_site.Items.Add("BCS");
            cbo_site.Items.Add("WH2");
            cbo_site.Items.Add("IFN");

            cbo_PRSSite.Items.Add("");
            cbo_PRSSite.Items.Add("BCS");
            cbo_PRSSite.Items.Add("WH2");
            cbo_PRSSite.Items.Add("IFN");

            cbo_POSSite.Items.Add("");
            cbo_POSSite.Items.Add("BCS");
            cbo_POSSite.Items.Add("WH2");
            cbo_POSSite.Items.Add("IFN");
        }

        private void grid_receipt_Init()
        {
            grid_receipt.AutoGenerateColumns = false;
            grid_receipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_receipt.ColumnCount = 9;

            //grid font size custom
            grid_receipt.RowTemplate.Height = 20;
            grid_receipt.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_receipt.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            grid_receipt.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);

            grid_receipt.Columns[0].Name = "Date";
            grid_receipt.Columns[0].ReadOnly = true;
            grid_receipt.Columns[0].Width = 70;
            grid_receipt.Columns[0].MinimumWidth = 70;
            grid_receipt.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_receipt.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_receipt.Columns[0].DataPropertyName = "NDEDAT_0";

            grid_receipt.Columns[1].Name = "PO No.";
            grid_receipt.Columns[1].ReadOnly = true;
            grid_receipt.Columns[1].Width = 75;
            grid_receipt.Columns[1].MinimumWidth = 75;
            grid_receipt.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_receipt.Columns[1].DataPropertyName = "POHNUM_0";

            grid_receipt.Columns[2].Name = "Receipt No.";
            grid_receipt.Columns[2].ReadOnly = true;
            grid_receipt.Columns[2].Width = 75;
            grid_receipt.Columns[2].MinimumWidth = 75;
            grid_receipt.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_receipt.Columns[2].DataPropertyName = "PTHNUM_0";

            grid_receipt.Columns[3].Name = "Supplier";
            grid_receipt.Columns[3].ReadOnly = true;
            grid_receipt.Columns[3].Width = 90;
            grid_receipt.Columns[3].MinimumWidth = 90;
            grid_receipt.Columns[3].DataPropertyName = "BPSNUM_0";

            grid_receipt.Columns[4].Name = "Receiving Site";
            grid_receipt.Columns[4].ReadOnly = true;
            grid_receipt.Columns[4].Width = 35;
            grid_receipt.Columns[4].MinimumWidth = 35;
            grid_receipt.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_receipt.Columns[4].DataPropertyName = "PRHFCY_0";

            grid_receipt.Columns[5].Name = "Memo";
            grid_receipt.Columns[5].ReadOnly = true;
            grid_receipt.Columns[5].Width = 150;
            grid_receipt.Columns[5].MinimumWidth = 150;
            grid_receipt.Columns[5].DataPropertyName = "PMemo";

            grid_receipt.Columns[6].Name = "SupplierName";
            grid_receipt.Columns[6].Visible = false;
            grid_receipt.Columns[6].Width = 100;
            grid_receipt.Columns[6].MinimumWidth = 100;
            grid_receipt.Columns[6].DataPropertyName = "SupplierName";

            grid_receipt.Columns[7].Name = "OrderQty";
            grid_receipt.Columns[7].Width = 45;
            grid_receipt.Columns[7].MinimumWidth = 45;
            grid_receipt.Columns[7].Visible = false;
            grid_receipt.Columns[7].DefaultCellStyle.Format = "N2";
            grid_receipt.Columns[7].DataPropertyName = "OrderQty";

            grid_receipt.Columns[8].Name = "OrderAmount";
            grid_receipt.Columns[8].Width = 45;
            grid_receipt.Columns[8].MinimumWidth = 45;
            grid_receipt.Columns[8].Visible = false;
            grid_receipt.Columns[8].DefaultCellStyle.Format = "N2";
            grid_receipt.Columns[8].DataPropertyName = "OrderAmount";

        }

        private void grid_selectionHeader_Init()
        {
            grid_selectionHeader.AutoGenerateColumns = false;
            grid_selectionHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_selectionHeader.ColumnCount = 7;

            //detail grid multi line allow
            grid_selectionHeader.AllowDrop = true;
            grid_selectionHeader.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_selectionHeader.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //grid font size custom
            grid_selectionHeader.RowTemplate.Height = 20;
            grid_selectionHeader.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_selectionHeader.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            grid_selectionHeader.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);

            grid_selectionHeader.Columns[0].Name = "PO No.";
            grid_selectionHeader.Columns[0].ReadOnly = true;
            grid_selectionHeader.Columns[0].Width = 75;
            grid_selectionHeader.Columns[0].MinimumWidth = 75;
            grid_selectionHeader.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectionHeader.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectionHeader.Columns[0].DataPropertyName = "POHNUM_0";

            grid_selectionHeader.Columns[1].Name = "Date";
            grid_selectionHeader.Columns[1].ReadOnly = true;
            grid_selectionHeader.Columns[1].Width = 75;
            grid_selectionHeader.Columns[1].MinimumWidth = 75;
            grid_selectionHeader.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_selectionHeader.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectionHeader.Columns[1].DataPropertyName = "ORDDAT_0";

            grid_selectionHeader.Columns[2].Name = "Supplier";
            grid_selectionHeader.Columns[2].ReadOnly = true;
            grid_selectionHeader.Columns[2].Width = 100;
            grid_selectionHeader.Columns[2].MinimumWidth = 100;
            grid_selectionHeader.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectionHeader.Columns[2].DataPropertyName = "BPSNUM_0";

            grid_selectionHeader.Columns[3].Name = "ReceivingSite";
            grid_selectionHeader.Columns[3].ReadOnly = true;
            grid_selectionHeader.Columns[3].Width = 35;
            grid_selectionHeader.Columns[3].MinimumWidth = 35;
            grid_selectionHeader.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectionHeader.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_selectionHeader.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_selectionHeader.Columns[3].DataPropertyName = "ReceivingSite";

            grid_selectionHeader.Columns[4].Name = "Memo";
            grid_selectionHeader.Columns[4].ReadOnly = true;
            grid_selectionHeader.Columns[4].Width = 150;
            grid_selectionHeader.Columns[4].MinimumWidth = 150;
            grid_selectionHeader.Columns[4].DataPropertyName = "PMemo";

            grid_selectionHeader.Columns[5].Name = "SupplierName";
            grid_selectionHeader.Columns[5].Visible = false;
            grid_selectionHeader.Columns[5].Width = 120;
            grid_selectionHeader.Columns[5].MinimumWidth = 120;
            grid_selectionHeader.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectionHeader.Columns[5].DataPropertyName = "SupplierName";

            grid_selectionHeader.Columns[6].Name = "RequireDate";
            grid_selectionHeader.Columns[6].Visible = false;
            grid_selectionHeader.Columns[6].Width = 120;
            grid_selectionHeader.Columns[6].MinimumWidth = 120;
            grid_selectionHeader.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_selectionHeader.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_selectionHeader.Columns[6].DataPropertyName = "RequireDate";

        }
        private void grid_detail_Init()
        {
            grid_detail.AutoGenerateColumns = false;
            grid_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_detail.ColumnCount = 23;

            grid_detail.AllowDrop = true;
            grid_detail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_detail.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewButtonColumn AddButton = new DataGridViewButtonColumn();
            AddButton.Width = 25;
            AddButton.Name = "➕";
            AddButton.Visible = true;
            AddButton.Text = "➕";
            AddButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AddButton.UseColumnTextForButtonValue = true;
            AddButton.FlatStyle = FlatStyle.Popup;
            if (grid_detail.Columns["➕"] == null)
            {
                grid_detail.Columns.Insert(0, AddButton);
            }
            AddButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_detail.Columns[1].Name = "Order";
            grid_detail.Columns[1].ReadOnly = true;
            grid_detail.Columns[1].Visible = false;
            grid_detail.Columns[1].Width = 70;
            grid_detail.Columns[1].DataPropertyName = "POHNUM_0";

            grid_detail.Columns[2].Name = "Product (BCS)";
            grid_detail.Columns[2].ReadOnly = true;
            grid_detail.Columns[2].Width = 60;
            grid_detail.Columns[2].DataPropertyName = "ITMREF_0";

            grid_detail.Columns[3].Name = "Product (Supplier)";
            grid_detail.Columns[3].ReadOnly = true;
            grid_detail.Columns[3].Width = 80;
            grid_detail.Columns[3].DataPropertyName = "VendorCode";

            grid_detail.Columns[4].Name = "Description";
            grid_detail.Columns[4].ReadOnly = true;
            grid_detail.Columns[4].Width = 200;
            grid_detail.Columns[4].DataPropertyName = "ProductDesc";

            grid_detail.Columns[5].Name = "Pack Size";
            grid_detail.Columns[5].ReadOnly = true;
            grid_detail.Columns[5].Width = 70;
            grid_detail.Columns[5].DataPropertyName = "StrPackSize";

            grid_detail.Columns[6].Name = "Unit";
            grid_detail.Columns[6].ReadOnly = true;
            grid_detail.Columns[6].Width = 35;
            grid_detail.Columns[6].DataPropertyName = "SUnitM";

            grid_detail.Columns[7].Name = "Location";
            grid_detail.Columns[7].ReadOnly = true;
            grid_detail.Columns[7].Width = 50;
            grid_detail.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns[7].DataPropertyName = "Location";

            grid_detail.Columns[8].Name = "STK Qty.";
            grid_detail.Columns[8].ReadOnly = true;
            grid_detail.Columns[8].Width = 45;
            grid_detail.Columns[8].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[8].DataPropertyName = "CSInner";

            grid_detail.Columns[9].Name = "Gross price";
            grid_detail.Columns[9].ReadOnly = true;
            grid_detail.Columns[9].Width = 50;
            grid_detail.Columns[9].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[9].DataPropertyName = "UnitPr";

            grid_detail.Columns[10].Name = "EDLP";
            grid_detail.Columns[10].Width = 45;
            grid_detail.Columns[10].MinimumWidth = 45;
            grid_detail.Columns[10].ReadOnly = true;
            grid_detail.Columns[10].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[10].DataPropertyName = "EDLP";

            grid_detail.Columns[11].Name = "EDLP (P)";
            grid_detail.Columns[11].Width = 45;
            grid_detail.Columns[11].MinimumWidth = 45;
            grid_detail.Columns[11].ReadOnly = true;
            grid_detail.Columns[11].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[11].DataPropertyName = "EDLPP";

            grid_detail.Columns[12].Name = "Term Promo";
            grid_detail.Columns[12].Width = 45;
            grid_detail.Columns[12].MinimumWidth = 45;
            grid_detail.Columns[12].ReadOnly = true;
            grid_detail.Columns[12].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[12].DataPropertyName = "TermPromo";

            grid_detail.Columns[13].Name = "Term Promo (P)";
            grid_detail.Columns[13].Width = 45;
            grid_detail.Columns[13].MinimumWidth = 45;
            grid_detail.Columns[13].ReadOnly = true;
            grid_detail.Columns[13].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[13].DataPropertyName = "TermPromoP";

            grid_detail.Columns[14].Name = "Net Price";
            grid_detail.Columns[14].ReadOnly = true;
            grid_detail.Columns[14].Width = 50;
            grid_detail.Columns[14].MinimumWidth = 50;
            grid_detail.Columns[14].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[14].DataPropertyName = "NetPrice";

            grid_detail.Columns[15].Name = "PO Qty.";
            grid_detail.Columns[15].ReadOnly = true;
            grid_detail.Columns[15].Width = 55;
            grid_detail.Columns[15].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[15].DataPropertyName = "OrderQty";

            grid_detail.Columns[16].Name = "PO Amount";
            grid_detail.Columns[16].ReadOnly = true;
            grid_detail.Columns[16].Width = 65;
            grid_detail.Columns[16].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[16].DataPropertyName = "OrderAmount";

            grid_detail.Columns[17].Name = "GR Qty.";
            grid_detail.Columns[17].Width = 55;
            grid_detail.Columns[17].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[17].DataPropertyName = "ReceivedQty";

            grid_detail.Columns[18].Name = "GR Amount";
            grid_detail.Columns[18].ReadOnly = true;
            grid_detail.Columns[18].Width = 65;
            grid_detail.Columns[18].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[18].DataPropertyName = "ReceivedAmount";

            grid_detail.Columns[19].Name = "Diff Qty.";
            grid_detail.Columns[19].Width = 55;
            grid_detail.Columns[19].Visible = false;
            grid_detail.Columns[19].ReadOnly = true;
            grid_detail.Columns[19].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[19].DataPropertyName = "DiffQty";

            grid_detail.Columns[20].Name = "Diff Amount";
            grid_detail.Columns[20].Visible = false;
            grid_detail.Columns[20].ReadOnly = true;
            grid_detail.Columns[20].Width = 65;
            grid_detail.Columns[20].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[20].DataPropertyName = "DiffAmount";

            grid_detail.Columns[21].Name = "Receiving Site";
            grid_detail.Columns[21].ReadOnly = true;
            grid_detail.Columns[21].Visible = false;
            grid_detail.Columns[21].Width = 50;
            grid_detail.Columns[21].DataPropertyName = "ReceivingSite";

            grid_detail.Columns[22].Name = "ROWID";
            grid_detail.Columns[22].ReadOnly = true;
            grid_detail.Columns[22].Visible = false;
            grid_detail.Columns[22].Width = 50;
            grid_detail.Columns[22].DataPropertyName = "ROWID";

            DataGridViewCheckBoxColumn DetailCheck = new DataGridViewCheckBoxColumn();
            DetailCheck.HeaderText = "Receiving";
            DetailCheck.FalseValue = false;
            DetailCheck.TrueValue = true;
            DetailCheck.Name = "Receiving";
            DetailCheck.ReadOnly = true;
            DetailCheck.Width = 30;
            DetailCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DetailCheck.DataPropertyName = "Receiving";
            grid_detail.Columns.Insert(23, DetailCheck);
            grid_detail.CellContentClick += new DataGridViewCellEventHandler(detailSelect);

            DataGridViewComboBoxColumn ReasonCodeComboBox = new DataGridViewComboBoxColumn();
            ReasonCodeComboBox.Width = 80;
            ReasonCodeComboBox.MinimumWidth = 50;
            ReasonCodeComboBox.Name = "Reason";
            ReasonCodeComboBox.Items.Add("");
            ReasonCodeComboBox.Items.Add("O/S");
            ReasonCodeComboBox.Items.Add("Short");
            ReasonCodeComboBox.Items.Add("Damaged");
            ReasonCodeComboBox.Items.Add("Short date");
            ReasonCodeComboBox.FlatStyle = FlatStyle.Popup;
            ReasonCodeComboBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ReasonCodeComboBox.DataPropertyName = "Reason";
            ReasonCodeComboBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns.Insert(24, ReasonCodeComboBox);

            DataGridViewComboBoxColumn ItemStatusComboBox = new DataGridViewComboBoxColumn();
            ItemStatusComboBox.Width = 40;
            ItemStatusComboBox.MinimumWidth = 40;
            ItemStatusComboBox.Name = "Status";
            ItemStatusComboBox.Items.Add("");
            ItemStatusComboBox.Items.Add("A");
            ItemStatusComboBox.Items.Add("Q");
            ItemStatusComboBox.Items.Add("R");
            ItemStatusComboBox.FlatStyle = FlatStyle.Popup;
            ItemStatusComboBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ItemStatusComboBox.DataPropertyName = "ItemStatus";
            ItemStatusComboBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_detail.Columns.Insert(25, ItemStatusComboBox);

            grid_detail.Columns[26].Name = "Expiration Date";
            //grid_detail.Columns[15].ReadOnly = true;
            grid_detail.Columns[26].Width = 95;
            grid_detail.Columns[26].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_detail.Columns[26].DataPropertyName = "ExpirationDate";

            DataGridViewButtonColumn DeleteButton = new DataGridViewButtonColumn();
            DeleteButton.Width = 5;
            DeleteButton.Name = "Delete";
            DeleteButton.Visible = true;
            DeleteButton.Text = "Delete";
            DeleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DeleteButton.UseColumnTextForButtonValue = true;
            //DeleteButton.FlatStyle = FlatStyle.Popup;
            if (grid_detail.Columns["Delete"] == null)
            {
                grid_detail.Columns.Insert(27, DeleteButton);
            }
            DeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            //grid font size custom
            grid_detail.RowTemplate.Height = 20;
            grid_detail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_detail.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            grid_detail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);

        }
        private void detailSelect(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grid_detail.Columns[e.ColumnIndex].Name.Equals("Receiving"))
                {
                    if (tabControl1.SelectedTab == tabWIP)
                    {
                        grid_detail.Rows[e.RowIndex].Cells["Expiration Date"].Value = DBNull.Value;
                        grid_detail.Rows[e.RowIndex].Cells["Status"].Value = "";
                        grid_detail.Rows[e.RowIndex].Cells["Reason"].Value = "";

                        if (Convert.ToBoolean(grid_detail.Rows[e.RowIndex].Cells["Receiving"].EditedFormattedValue) == false)
                        {
                            grid_detail.Rows[e.RowIndex].Cells["Receiving"].Value = true;
                        }
                        else
                        {
                            grid_detail.Rows[e.RowIndex].Cells["Receiving"].Value = false;
                        }
                        Calculate();
                    }
                }
            }
            catch { }
        }
        private void grid_detail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grid_detail.Columns[e.ColumnIndex].Name.Equals("Receiving")) //CheckBox 빠르게 Double click시 인식이 잘 안되어서 detailSelect로 끝내지 못하고 일단 grid_detail_CellValueChanged 만들었음 
                {

                    grid_detail.Rows[e.RowIndex].Cells["Expiration Date"].Value = DBNull.Value;
                    grid_detail.Rows[e.RowIndex].Cells["Expiration Date"].ReadOnly = false;
                    grid_detail.Rows[e.RowIndex].Cells["Status"].ReadOnly = false;
                    grid_detail.Rows[e.RowIndex].Cells["Reason"].ReadOnly = false;

                    if (Convert.ToBoolean(grid_detail.Rows[e.RowIndex].Cells["Receiving"].Value) == false)
                    {
                        grid_detail.Rows[e.RowIndex].Cells["Expiration Date"].ReadOnly = true;
                        grid_detail.Rows[e.RowIndex].Cells["Status"].ReadOnly = true;
                    }
                    else
                    {
                        grid_detail.Rows[e.RowIndex].Cells["Reason"].ReadOnly = true;
                    }
                    txt_memo.Focus();
                }
            }
            catch//(Exception ex) { MessageBox.Show(ex.ToString()); }
            { }
        }
        private void grid_selectionHeader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_print.Enabled = true;
            btn_create.Enabled = true;

            try
            {
                Initialize();

                cbo_site.Enabled = true;
                txt_memo.Enabled = true;

                String PORDERNumber = grid_selectionHeader.Rows[e.RowIndex].Cells["PO No."].Value.ToString();
                txt_supplierID.Text = grid_selectionHeader.Rows[e.RowIndex].Cells["Supplier"].Value.ToString();
                txt_supplierName.Text = grid_selectionHeader.Rows[e.RowIndex].Cells["SupplierName"].Value.ToString();
                txt_receivingSite.Text = grid_selectionHeader.Rows[e.RowIndex].Cells["ReceivingSite"].Value.ToString();
                txt_supplierID.Text = grid_selectionHeader.Rows[e.RowIndex].Cells["Supplier"].Value.ToString();
                SelectedPONumber = grid_selectionHeader.Rows[e.RowIndex].Cells["PO No."].Value.ToString();
                dateTimePickerReceipt.Value = DateTime.Today.Date;
                dateTimePickerRequire.Value = Convert.ToDateTime(grid_selectionHeader.Rows[e.RowIndex].Cells["RequireDate"].Value);
                dateTimePickerOrder.Value = Convert.ToDateTime(grid_selectionHeader.Rows[e.RowIndex].Cells["Date"].Value);
                txt_poNumber.Text = PORDERNumber;

                connSalesOrder.sp_PORDER_Detail(grid_detail, PORDERNumber);
                grid_detail.ClearSelection();

                grid_detail.Columns["➕"].Visible = true;
                grid_detail.Columns["Delete"].Visible = true;
                grid_detail.Columns["Status"].ReadOnly = false;
                grid_detail.Columns["GR Qty."].ReadOnly = false;
                grid_detail.Columns["Expiration Date"].ReadOnly = false;
                grid_detail.Columns["Receiving"].ReadOnly = false;
                grid_detail.Columns["Reason"].ReadOnly = false;

                Decimal TotalPOQty = 0;
                Decimal TotalPOAmount = 0;

                for (int i = 0; i < grid_detail.RowCount; i++)
                {
                    grid_detail.Rows[i].Cells["Receiving"].Value = true;
                    grid_detail.Rows[i].Cells["Expiration Date"].Value = DBNull.Value;
                    Decimal Qty = Convert.ToDecimal(grid_detail.Rows[i].Cells["PO Qty."].Value);
                    Decimal Amount = Convert.ToDecimal(grid_detail.Rows[i].Cells["PO Amount"].Value);
                    TotalPOQty += Qty;
                    TotalPOAmount += Amount;
                }
                txt_totalPOQty.Text = TotalPOQty.ToString("N2");
                txt_totalPOAmount.Text = TotalPOAmount.ToString("N2");
                Calculate();
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
        private void grid_receipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_create.Enabled = false;
            btn_print.Enabled = true;

            try
            {
                Initialize();

                dateTimePickerReceipt.Value = Convert.ToDateTime(grid_receipt.Rows[e.RowIndex].Cells["Date"].Value.ToString());
                cbo_site.Text = grid_receipt.Rows[e.RowIndex].Cells["Receiving Site"].Value.ToString();
                txt_receiptNumber.Text = grid_receipt.Rows[e.RowIndex].Cells["Receipt No."].Value.ToString();
                txt_receivingSite.Text = grid_receipt.Rows[e.RowIndex].Cells["Receiving Site"].Value.ToString();
                txt_supplierID.Text = grid_receipt.Rows[e.RowIndex].Cells["Supplier"].Value.ToString();
                txt_memo.Text = grid_receipt.Rows[e.RowIndex].Cells["Memo"].Value.ToString();
                txt_poNumber.Text = grid_receipt.Rows[e.RowIndex].Cells["PO No."].Value.ToString();
                txt_supplierName.Text = grid_receipt.Rows[e.RowIndex].Cells["SupplierName"].Value.ToString();
                if (txt_poNumber.Text.Substring(0, 2).Equals("PO"))
                {
                    connPO.datepickerPORDER(txt_poNumber.Text, dateTimePickerOrder, dateTimePickerRequire);
                }
                else 
                {
                    dateTimePickerOrder.Value = Convert.ToDateTime(grid_receipt.Rows[e.RowIndex].Cells["Date"].Value.ToString());
                    dateTimePickerRequire.Value = Convert.ToDateTime(grid_receipt.Rows[e.RowIndex].Cells["Date"].Value.ToString());
                }

                connSalesOrder.sp_PRECEIPT_DETAIL(grid_detail, grid_receipt.Rows[e.RowIndex].Cells["Receipt No."].Value.ToString());
                grid_detail.ClearSelection();

                Calculate();
            }
            catch
            {
            }
        }

        private void grid_detail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (grid_detail.Columns[e.ColumnIndex].Name)
            {
                case "GR Qty.":
                    try
                    {
                        string OrderQtyString = grid_detail.Rows[e.RowIndex].Cells["PO Qty."].Value == DBNull.Value ? "0" : grid_detail.Rows[e.RowIndex].Cells["PO Qty."].Value.ToString();
                        string GRQtyString = grid_detail.Rows[e.RowIndex].Cells["GR Qty."].Value == DBNull.Value ? "0" : grid_detail.Rows[e.RowIndex].Cells["GR Qty."].Value.ToString();
                        string NetPriceString = grid_detail.Rows[e.RowIndex].Cells["Net Price"].Value.ToString();
                        string STKQtyString = grid_detail.Rows[e.RowIndex].Cells["STK Qty."].Value.ToString();

                        decimal OrderQty = Convert.ToDecimal(OrderQtyString);
                        decimal GRQty = Convert.ToDecimal(GRQtyString);
                        decimal NetPrice = Convert.ToDecimal(NetPriceString);
                        decimal STKQty = Convert.ToDecimal(STKQtyString);

                        // 11/23/2021
                        //decimal grAmount = Math.Round((NetPrice / STKQty), 2) * (GRQty * STKQty);

                        //MessageBox.Show(Math.Round((NetPrice / STKQty),2).ToString());
                        //MessageBox.Show((GRQty * STKQty).ToString());

                        // 11/23/2021
                        //grid_detail.Rows[e.RowIndex].Cells["GR Amount"].Value = grAmount;//(GRQty * NetPrice).ToString();
                        grid_detail.Rows[e.RowIndex].Cells["GR Amount"].Value = (GRQty * NetPrice).ToString();
                        grid_detail.Rows[e.RowIndex].Cells["Diff Qty."].Value = (GRQty - OrderQty).ToString();
                        grid_detail.Rows[e.RowIndex].Cells["Diff Amount"].Value = ((GRQty - OrderQty) * NetPrice).ToString();
                        Calculate();
                    }
                    catch { }
                    break;

                case "Expiration Date":
                    try
                    {
                        dateTimePickerExpirationDate.Visible = false;
                        CultureInfo provider = CultureInfo.InvariantCulture;
                        string dateString = grid_detail.Rows[e.RowIndex].Cells["Expiration Date"].Value.ToString().Trim();

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
                        grid_detail.Rows[e.RowIndex].Cells["Expiration Date"].Value = result.ToString("MM/dd/yyyy");
                    }
                    catch
                    {
                        grid_detail.Rows[e.RowIndex].Cells["Expiration Date"].Value = DBNull.Value;
                    }
                    break;

                default:
                    Calculate();
                    break;
            }
        }
        private void grid_detail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabControl1.TabPages["tabWIP"])
                {
                    switch (grid_detail.Columns[e.ColumnIndex].Name)
                    {
                        case "Expiration Date":
                            if (Convert.ToBoolean(grid_detail.Rows[e.RowIndex].Cells["Receiving"].Value) == true)
                            {
                                rectangle = grid_detail.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                                dateTimePickerExpirationDate.Size = new Size(rectangle.Width, rectangle.Height);
                                dateTimePickerExpirationDate.Location = new Point(rectangle.X, rectangle.Y);
                                dateTimePickerExpirationDate.Visible = true;
                                grid_detail.CurrentRow.Cells["Expiration Date"].Value = dateTimePickerExpirationDate.Text.ToString();
                            }
                            break;

                        default:
                            Calculate();
                            break;
                    }
                }
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString(), "grid_detail_CellDoubleClick Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        private void grid_detail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabWIP)
                {
                    Calculate();

                    foreach (DataGridViewRow row in this.grid_detail.Rows)
                    {
                        row.Cells["GR Qty."].Style.BackColor = Color.OldLace;
                        row.Cells["Expiration Date"].Style.BackColor = Color.OldLace;
                        row.Cells["Status"].Style.BackColor = Color.OldLace;
                        row.Cells["Receiving Site"].Style.BackColor = Color.OldLace;
                        row.Cells["Reason"].Style.BackColor = Color.OldLace;
                        row.Cells["Receiving"].Style.BackColor = Color.OldLace;
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in this.grid_detail.Rows)
                    {
                        if (Convert.ToDateTime(row.Cells["Expiration Date"].Value).ToShortDateString().Equals("1/1/1900"))
                        {
                            row.Cells["Expiration Date"].Value = DBNull.Value;
                        }
                        if (Convert.ToDecimal(row.Cells["PO Qty."].Value) == 0)
                        {
                            row.Cells["PO Qty."].Value = DBNull.Value;
                            row.Cells["PO Amount"].Value = DBNull.Value;
                        }
                        if (Convert.ToBoolean(row.Cells["Receiving"].Value) == false)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                        }
                    }
                }
            }
            catch { }
        }

        private void Receiving()
        {
            try
            {
                List<string> ProductList = new List<string>();
                string[] DistinctProductList;
                string[,] ProductArray;
                string UnMatchProductList = "";
                bool CompareQty = true;

                for (int i = 0; i < grid_detail.RowCount; i++)
                {
                    ProductList.Add(grid_detail.Rows[i].Cells[2].Value.ToString()); //Cells["Product (BCS)"]
                }
                DistinctProductList = ProductList.Distinct().ToArray();
                ProductArray = new string[DistinctProductList.Length, 3];

                for (int i = 0; i < DistinctProductList.Length; i++)
                {
                    Decimal POQty = 0, RECQty = 0;
                    for (int j = 0; j < grid_detail.RowCount; j++)
                    {
                        if (DistinctProductList[i].ToString().Equals(grid_detail.Rows[j].Cells[2].Value.ToString()))
                        {
                            POQty += grid_detail.Rows[j].Cells["PO Qty."].Value == DBNull.Value ? 0 : Convert.ToDecimal(grid_detail.Rows[j].Cells["PO Qty."].Value);
                            RECQty += grid_detail.Rows[j].Cells["GR Qty."].Value == DBNull.Value ? 0 : Convert.ToDecimal(grid_detail.Rows[j].Cells["GR Qty."].Value);
                        }
                    }
                    ProductArray[i, 0] = DistinctProductList[i].ToString();
                    ProductArray[i, 1] = POQty.ToString("N2");
                    ProductArray[i, 2] = RECQty.ToString("N2");
                }

                for (int i = 0; i < DistinctProductList.Length; i++)
                {
                    if (!ProductArray[i, 1].ToString().Equals(ProductArray[i, 2].ToString()))
                    {
                        UnMatchProductList += ProductArray[i, 0].ToString() + "    PO Qty : " + ProductArray[i, 1].ToString()
                            + "    REC Qty : " + ProductArray[i, 2].ToString() + "  (Diff : "
                            + (Convert.ToDecimal(ProductArray[i, 2].ToString()) - Convert.ToDecimal(ProductArray[i, 1].ToString())).ToString("N2") + ")\n";
                        if (Convert.ToDecimal(ProductArray[i, 1]) >= Convert.ToDecimal(ProductArray[i, 2])) CompareQty = false;
                    }
                }


                if (CompareQty)
                {
                    String MessageContent = "Confirm running the receiving process.\n";
                    if (UnMatchProductList.Length != 0)
                    {
                        MessageContent += "\n" + UnMatchProductList + "\nPlease input a memo(reason) for the difference in quantity.";
                    }
                    DialogResult dialogResult = MessageBox.Show(MessageContent, "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes)
                    {
                        //Receiving
                        String NewRECNumber = connSalesOrder.sp_GET_NewRECNumber();
                        String NewSTKNumber = connSalesOrder.sp_GET_NewSTKNumber();
                        String Memo = txt_memo.Text;
                        String ReceivingSite = cbo_site.Text;
                        if (!NewSTKNumber.Contains("STK"))
                        {
                            MessageBox.Show("Please try again.(STK) (Error code: " + NewSTKNumber + ")"
                                                            , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        for (int i = 0; i < grid_detail.Rows.Count; i++)
                        {
                            String Supplier = txt_supplierID.Text.Trim();
                            String PORDERNumber = grid_detail.Rows[i].Cells["Order"].Value.ToString().Trim(); ;
                            String ProductBCS = grid_detail.Rows[i].Cells["Product (BCS)"].Value.ToString().Trim();
                            //String ProductSupplier = grid_detail.Rows[i].Cells["Product (Supplier)"].Value.ToString();
                            Decimal POQty = grid_detail.Rows[i].Cells["PO Qty."].Value == DBNull.Value ? 0 : Convert.ToDecimal(grid_detail.Rows[i].Cells["PO Qty."].Value.ToString().Trim());
                            Decimal POAmount = grid_detail.Rows[i].Cells["PO Amount"].Value == DBNull.Value ? 0 : Convert.ToDecimal(grid_detail.Rows[i].Cells["PO Amount"].Value.ToString().Trim());
                            Decimal GRQty = Convert.ToDecimal(grid_detail.Rows[i].Cells["GR Qty."].Value.ToString().Trim());
                            Decimal GRAmount = Convert.ToDecimal(grid_detail.Rows[i].Cells["GR Amount"].Value.ToString().Trim());
                            Decimal InnerCase = Convert.ToDecimal(grid_detail.Rows[i].Cells["STK Qty."].Value.ToString().Trim());
                            String Description = grid_detail.Rows[i].Cells["Description"].Value.ToString().Trim();
                            String PackSize = grid_detail.Rows[i].Cells["Pack Size"].Value.ToString().Trim();
                            Decimal GrossPrice = Convert.ToDecimal(grid_detail.Rows[i].Cells["Gross Price"].Value.ToString().Trim());
                            Decimal EDLP = Convert.ToDecimal(grid_detail.Rows[i].Cells["EDLP"].Value.ToString().Trim());
                            Decimal EDLPP = Convert.ToDecimal(grid_detail.Rows[i].Cells["EDLP (P)"].Value.ToString().Trim());
                            Decimal TermPromo = Convert.ToDecimal(grid_detail.Rows[i].Cells["Term Promo"].Value.ToString().Trim());
                            Decimal TermPromoP = Convert.ToDecimal(grid_detail.Rows[i].Cells["Term Promo (P)"].Value.ToString().Trim());
                            Decimal NetPrice = Convert.ToDecimal(grid_detail.Rows[i].Cells["Net Price"].Value.ToString().Trim());
                            String Unit = grid_detail.Rows[i].Cells["Unit"].Value.ToString().Trim();
                            //DateTime ExpirationDate = grid_detail.Rows[i].Cells["Expiration Date"].Value == DBNull.Value ? Convert.ToDateTime("01/01/1900") : Convert.ToDateTime(grid_detail.Rows[i].Cells["Expiration Date"].Value.ToString().Trim()).Date;
                            DateTime ExpirationDate = grid_detail.Rows[i].Cells["Expiration Date"].Value == DBNull.Value ? Convert.ToDateTime("01/01/1900")
                               : (grid_detail.Rows[i].Cells["Expiration Date"].Value.ToString().Equals("") ? Convert.ToDateTime("01/01/1900") : Convert.ToDateTime(grid_detail.Rows[i].Cells["Expiration Date"].Value.ToString().Trim()).Date);
                            DateTime ReceivingDate = Convert.ToDateTime(dateTimePickerReceipt.Value.ToShortDateString());//Convert.ToDateTime(dateTimePicker1.Value);
                            String Location = grid_detail.Rows[i].Cells["Location"].Value.ToString().Trim();
                            String ProductStatus = grid_detail.Rows[i].Cells["Status"].Value.ToString().Trim();
                            String Reason = grid_detail.Rows[i].Cells["Reason"].Value == DBNull.Value ? "" : grid_detail.Rows[i].Cells["Reason"].Value.ToString().Trim();
                            int ROWID = Convert.ToInt32(grid_detail.Rows[i].Cells["ROWID"].Value.ToString().Trim());

                            Entities.PORDER pORDER = new Entities.PORDER();

                            pORDER.Supplier = Supplier;
                            pORDER.PORDERNumber = PORDERNumber;
                            pORDER.ProductBCS = ProductBCS;
                            pORDER.Description = Description;
                            pORDER.PackSize = PackSize;
                            pORDER.Unit = Unit;
                            pORDER.InnerCase = InnerCase;
                            pORDER.GrossPrice = GrossPrice;
                            pORDER.EDLP = EDLP;
                            pORDER.EDLPP = EDLPP;
                            pORDER.TermPromo = TermPromo;
                            pORDER.TermPromoP = TermPromoP;
                            pORDER.NetPrice = NetPrice;
                            pORDER.OrderQty = POQty;
                            pORDER.Qty = GRQty;
                            pORDER.OrderAmount = POAmount;
                            pORDER.GRAmount = GRAmount;
                            pORDER.ExpirationDate = ExpirationDate;
                            pORDER.ReceivingSite = ReceivingSite;
                            pORDER.Line = i + 1;
                            pORDER.ReceivingDate = ReceivingDate;
                            pORDER.ROWID = ROWID;
                            pORDER.Location = Location;
                            pORDER.ProductStatus = ProductStatus;
                            Decimal DiscountAmount = pORDER.Qty * (pORDER.GrossPrice - pORDER.NetPrice);

                            // 11/23/2021
                            //Decimal DiscountAmount = (Math.Round((pORDER.GrossPrice / InnerCase), 2) * (pORDER.OrderQty * InnerCase)) - (Math.Round((pORDER.NetPrice / InnerCase), 2) * (pORDER.OrderQty * InnerCase));

                        if (Convert.ToBoolean(grid_detail.Rows[i].Cells["Receiving"].Value) == true)
                            {
                                //phy +, INSERT STOCK
                                connPO.sp_INSERT_PRECEIPTD(pORDER, NewRECNumber);
                                //저널Detail
                                connPO.sp_PPAYMENT_JOU_RECEIVINGD(pORDER, NewRECNumber, NewSTKNumber);
                                //50010(-1), 15100(1)
                                connPO.sp_PPAYMENT_JOU_RECEIVINGD_DISCOUNT(pORDER, NewRECNumber, NewSTKNumber, DiscountAmount);
                            }
                            else
                            {
                                connPO.sp_INSERT_PRECEIPTDNOT(pORDER, NewRECNumber, Reason);
                            }
                        }
                        String SupplierID = txt_supplierID.Text;
                        String ReceiptMemo = txt_memo.Text;
                        //GIT TEST 10/26/2021
                        connPO.sp_PPAYMENT_JOU_RECEIVING(ReceivingSite, NewRECNumber, NewSTKNumber);
                        connPO.sp_CREATE_PRECEIPT(SupplierID, ReceiptMemo, ReceivingSite, SelectedPONumber, NewRECNumber);

                        String SearchRECPOID = txt_PRSPOID.Text.Trim();
                        String SearchRECRECID = txt_PRSRECID.Text.Trim();
                        String SearchRECSupplier = txt_PRSSupplier.Text.Trim();
                        String SearchRECSite = cbo_PRSSite.Text.Trim();
                        String SearchRECMemo = txt_PRSMemo.Text.Trim();

                        String SearchPOID = txt_POSPOID.Text.Trim();
                        String SearchPOupplier = txt_POSSupplier.Text.Trim();
                        String SearchPOSite = cbo_POSSite.Text.Trim();
                        String SearchPOMemo = txt_POSMemo.Text.Trim();

                        DateTime FromDate = dateTimePickerFrom.Value.Date;
                        DateTime ToDate = dateTimePickerTo.Value.Date;
                        connSalesOrder.sp_PORDER_SelectionHeader(grid_selectionHeader, FromDate, ToDate, SearchPOID, SearchPOupplier, SearchPOSite, SearchPOMemo);
                        connSalesOrder.sp_PRECEIPT_HEADER(grid_receipt, FromDate, ToDate, SearchRECPOID, SearchRECRECID, SearchRECSupplier, SearchRECSite, SearchRECMemo);


                        btn_create.Enabled = false;
                        btn_print.Enabled = false;
                        Initialize();

                        MessageBox.Show("PO Receiving " + NewRECNumber + " successfully saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                else
                {
                    UnMatchProductList += "\nEach item's GR.Qty must be greater than or equal to PO.Qty";
                    MessageBox.Show(UnMatchProductList.ToString(), "Product Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Contact to IT team.\n" + ex.Message.ToString(), "Receiving() Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                Calculate();
                if (txt_poNumber.Text == "")
                {
                    MessageBox.Show("Please select.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (cbo_site.Text == "")
                {
                    MessageBox.Show("Select Receiving Site.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                for (int i = 0; i < grid_detail.RowCount; i++)
                {
                    if(grid_detail.Rows[i].Cells["ROWID"].Value.ToString() == "")
                    {
                        connSalesOrder.sp_PRECEIPT_ROWID_ERROR(txt_poNumber.Text);
                        MessageBox.Show("STOP", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    decimal GRQty = Convert.ToDecimal(grid_detail.Rows[i].Cells["GR Qty."].Value);
                    if (Convert.ToBoolean(grid_detail.Rows[i].Cells["Receiving"].Value) == true)
                    {
                        String ExpirationDate = grid_detail.Rows[i].Cells["Expiration Date"].Value == DBNull.Value ? "" : grid_detail.Rows[i].Cells["Expiration Date"].Value.ToString();
                        String ItemStatus = grid_detail.Rows[i].Cells["Status"].Value == DBNull.Value ? "" : grid_detail.Rows[i].Cells["Status"].Value.ToString();

                        if (ExpirationDate.Equals(""))
                        {
                            MessageBox.Show("Input expiration date.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (!(ItemStatus.Equals("A") || ItemStatus.Equals("Q") || ItemStatus.Equals("R")))
                        {
                            MessageBox.Show("Input product Status A, Q or R", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    else
                    {
                        String Reason = grid_detail.Rows[i].Cells["Reason"].Value == DBNull.Value ? "" : grid_detail.Rows[i].Cells["Reason"].Value.ToString();
                        if (Reason.Equals(""))
                        {
                            MessageBox.Show("Enter the reason for the product NOT received.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    if (GRQty <= 0)
                    {
                        MessageBox.Show("Input information(*GR Qty. > 0*)", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                Receiving();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Contact IT.\n"+ex.Message.ToString(), "Button Receiving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void grid_detail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabControl1.TabPages["tabWIP"])
                {
                    switch (grid_detail.Columns[e.ColumnIndex].Name)
                    {
                        case "➕":
                            DataTable dt = this.grid_detail.DataSource as DataTable;
                            DataRow dr = dt.NewRow();

                            dr["POHNUM_0"] = grid_detail.Rows[e.RowIndex].Cells["Order"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["Order"].Value.ToString();
                            dr["ITMREF_0"] = grid_detail.Rows[e.RowIndex].Cells["Product (BCS)"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["Product (BCS)"].Value.ToString();
                            dr["VendorCode"] = grid_detail.Rows[e.RowIndex].Cells["Product (Supplier)"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["Product (Supplier)"].Value.ToString();
                            dr["ProductDesc"] = grid_detail.Rows[e.RowIndex].Cells["Description"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                            dr["StrPackSize"] = grid_detail.Rows[e.RowIndex].Cells["Pack Size"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["Pack Size"].Value.ToString();
                            dr["SUnitM"] = grid_detail.Rows[e.RowIndex].Cells["Unit"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["Unit"].Value.ToString();
                            dr["OrderQty"] = DBNull.Value;
                            dr["ReceivedQty"] = "0.00";
                            dr["CSInner"] = grid_detail.Rows[e.RowIndex].Cells["STK Qty."].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["STK Qty."].Value.ToString();
                            dr["UnitPr"] = grid_detail.Rows[e.RowIndex].Cells["Gross price"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["Gross price"].Value.ToString();
                            dr["EDLP"] = grid_detail.Rows[e.RowIndex].Cells["EDLP"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["EDLP"].Value.ToString();
                            dr["EDLPP"] = grid_detail.Rows[e.RowIndex].Cells["EDLP (P)"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["EDLP (P)"].Value.ToString();
                            dr["TermPromo"] = grid_detail.Rows[e.RowIndex].Cells["Term Promo"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["Term Promo"].Value.ToString();
                            dr["TermPromoP"] = grid_detail.Rows[e.RowIndex].Cells["Term Promo (P)"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["Term Promo (P)"].Value.ToString();
                            dr["NetPrice"] = grid_detail.Rows[e.RowIndex].Cells["Net Price"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["Net Price"].Value.ToString();
                            dr["OrderAmount"] = DBNull.Value;
                            dr["ReceivedAmount"] = "0.00";
                            dr["ExpirationDate"] = DBNull.Value;
                            dr["ReceivingSite"] = grid_detail.Rows[e.RowIndex].Cells["Receiving Site"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["Receiving Site"].Value.ToString();
                            dr["ItemStatus"] = "";
                            dr["ROWID"] = grid_detail.Rows[e.RowIndex].Cells["ROWID"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["ROWID"].Value.ToString();
                            dr["Location"] = grid_detail.Rows[e.RowIndex].Cells["Location"].Value == DBNull.Value ? "" : grid_detail.Rows[e.RowIndex].Cells["Location"].Value.ToString();
                            dr["Reason"] = "";

                            dt.Rows.InsertAt(dr, e.RowIndex + 1);
                            grid_detail.Rows[e.RowIndex + 1].Cells["Expiration Date"].ReadOnly = true;
                            grid_detail.Rows[e.RowIndex + 1].Cells["Status"].ReadOnly = true;
                            break;

                        case "Delete":
                            if (grid_detail.Rows[e.RowIndex].Cells["PO Qty."].Value != DBNull.Value)
                            {
                                MessageBox.Show("You cannot delete original PO detail (PO order quantity > 0). Please uncheck the receiving checkbox and input the reason.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            grid_detail.Rows.RemoveAt(e.RowIndex);
                            break;

                        default:
                            Calculate();
                            break;
                    }
                }
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString(), "grid_detail_CellClick Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (txt_poNumber.Text == "")
            {
                MessageBox.Show("Please select.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            String PoNumber = txt_poNumber.Text.Trim();
            String Term = connPO.getPaymentTerm2(PoNumber);
            String ShipVia = connPO.sp_GET_ShipVia(txt_supplierID.Text.Trim(), "");
            Entities.Address address = connPO.sp_GET_SupplierAddress(txt_supplierID.Text.Trim());
            String OrderDate = dateTimePickerOrder.Value.ToShortDateString();
            String ReceivingDate = dateTimePickerReceipt.Value.ToShortDateString();
            String RequireDate = dateTimePickerRequire.Value.ToShortDateString();
            String SupplierID = txt_supplierID.Text.Trim();
            String SupplierName = txt_supplierName.Text.Trim();
            String ReceivingSite = txt_receivingSite.Text.Trim();
            String Contact = address.Tel;
            String VendorAddress1 = address.Address1;
            String VendorAddress2 = address.Address2;
            String VendorTel = address.Tel;
            String VendorFax = address.Fax;
            String VendorCityStateZip = address.City + ", " + address.State + " " + address.Zip;
            String ShipName = "BCS International";
            String ShipAddress1 = "47-15 33rd St.";
            String ShipAddress2 = "";
            String ShipCity = "Long Island City";
            String ShipState = "NY";
            String ShipZip = "11101";
            String ShipTel = "(718)392-3355";
            String ShipFax = "(718)382-2072";
            String ShipCityStateZip = ShipCity + ", " + ShipState + " " + ShipZip;
            String TotalPOCase = txt_totalPOQty.Text.Trim();
            String TotalPOAmount = txt_totalPOAmount.Text.Trim();

            String RecNumber = txt_receiptNumber.Text.Trim();
            String TotalGRCase = (txt_totalQty.Text.Substring(0, txt_totalQty.Text.IndexOf('/'))).Trim();
            String TotalGRAmount = (txt_totalAmount.Text.Substring(0, txt_totalAmount.Text.IndexOf('/'))).Trim();
            String Memo = txt_memo.Text.ToString();

            if (ReceivingSite == "WH2")
            {
                ShipAddress1 = "686 Grand Ave";
                ShipAddress2 = "";
                ShipCity = "Ridgefield";
                ShipState = "NJ";
                ShipZip = "07657";
            }
            else if (ReceivingSite == "IFN")
            {
                ShipName = "IFONS";
                ShipAddress1 = "12 Jamaica Ave";
                ShipAddress2 = "";
                ShipCity = "Plainview";
                ShipState = "NY";
                ShipZip = "11803";
            }

            if (tabControl1.SelectedTab == tabReceipt)
            {
                Reports.Rpt_PRECEIPTS f = new Reports.Rpt_PRECEIPTS
                   (
                   PoNumber, RecNumber, OrderDate, ReceivingDate, Term, ShipVia, Contact,
                   SupplierID, SupplierName, VendorAddress1, VendorAddress2, VendorTel, VendorFax, VendorCityStateZip,
                   ShipName, ShipAddress1, ShipAddress2, ShipTel, ShipFax, ShipCityStateZip, RequireDate, TotalPOCase, TotalPOAmount, TotalGRCase, TotalGRAmount, Memo
                   );
                f.Show();
            }
            else
            {
                Reports.Rpt_PORDER reportTest = new Reports.Rpt_PORDER
                   (
                   PoNumber, OrderDate, ReceivingDate, Term, ShipVia, Contact,
                   SupplierID, SupplierName, VendorAddress1, VendorAddress2, VendorTel, VendorFax, VendorCityStateZip,
                   ShipName, ShipAddress1, ShipAddress2, ShipTel, ShipFax, ShipCityStateZip, RequireDate, TotalPOCase, TotalPOAmount
                   );
                reportTest.Show();
            }

        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            String SearchRECPOID = txt_PRSPOID.Text.Trim();
            String SearchRECRECID = txt_PRSRECID.Text.Trim();
            String SearchRECSupplier = txt_PRSSupplier.Text.Trim();
            String SearchRECSite = cbo_PRSSite.Text.Trim();
            String SearchRECMemo = txt_PRSMemo.Text.Trim();

            String SearchPOID = txt_POSPOID.Text.Trim();
            String SearchPOupplier = txt_POSSupplier.Text.Trim();
            String SearchPOSite = cbo_POSSite.Text.Trim();
            String SearchPOMemo = txt_POSMemo.Text.Trim();

            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            connSalesOrder.sp_PORDER_SelectionHeader(grid_selectionHeader, FromDate, ToDate, SearchPOID, SearchPOupplier, SearchPOSite, SearchPOMemo);
            connSalesOrder.sp_PRECEIPT_HEADER(grid_receipt, FromDate, ToDate, SearchRECPOID, SearchRECRECID, SearchRECSupplier, SearchRECSite, SearchRECMemo);
        }
        private void SearchREC(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String SearchRECPOID = txt_PRSPOID.Text.Trim();
                String SearchRECRECID = txt_PRSRECID.Text.Trim();
                String SearchRECSupplier = txt_PRSSupplier.Text.Trim();
                String SearchRECSite = cbo_PRSSite.Text.Trim();
                String SearchRECMemo = txt_PRSMemo.Text.Trim();

                DateTime FromDate = dateTimePickerFrom.Value.Date;
                DateTime ToDate = dateTimePickerTo.Value.Date;

                connSalesOrder.sp_PRECEIPT_HEADER(grid_receipt, FromDate, ToDate, SearchRECPOID, SearchRECRECID, SearchRECSupplier, SearchRECSite, SearchRECMemo);
            }
        }
        private void SearchPO(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String SearchPOID = txt_POSPOID.Text.Trim();
                String SearchPOupplier = txt_POSSupplier.Text.Trim();
                String SearchPOSite = cbo_POSSite.Text.Trim();
                String SearchPOMemo = txt_POSMemo.Text.Trim();

                DateTime FromDate = dateTimePickerFrom.Value.Date;
                DateTime ToDate = dateTimePickerTo.Value.Date;

                connSalesOrder.sp_PORDER_SelectionHeader(grid_selectionHeader, FromDate, ToDate, SearchPOID, SearchPOupplier, SearchPOSite, SearchPOMemo);
            }
        }
        private void grid_detail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 17)
            {
                decimal i;
                if (!decimal.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Check the input values", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void dtp_ValueFunction(object sender, EventArgs e)
        {
            grid_detail.CurrentRow.Cells["Expiration Date"].Value = dateTimePickerExpirationDate.Text.ToString();
            dateTimePickerExpirationDate.Visible = false;
        }
        private void grid_detail_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dateTimePickerExpirationDate.Visible = false;
        }
        private void grid_detail_Scroll(object sender, ScrollEventArgs e)
        {
            dateTimePickerExpirationDate.Visible = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Initialize();
            Calculate();
        }
        private void Calculate()
        {
            try
            {
                Decimal TotalAmount = 0, TotalQty = 0, TotalReceivingAmount = 0, TotalReceivingQty = 0, TotalPOAmount = 0, TotalPOQty = 0;

                for (int i = 0; i < grid_detail.Rows.Count; i++)
                {
                    Decimal POAmount = 0, POQty = 0, Amount = 0, Qty = 0, ReceivingQty = 0, ReceivingAmount = 0;

                    POAmount = grid_detail.Rows[i].Cells["PO Amount"].Value == DBNull.Value ? 0 : Convert.ToDecimal(grid_detail.Rows[i].Cells["PO Amount"].Value);
                    POQty = grid_detail.Rows[i].Cells["PO Qty."].Value == DBNull.Value ? 0 : Convert.ToDecimal(grid_detail.Rows[i].Cells["PO Qty."].Value);
                    Amount = Convert.ToDecimal(grid_detail.Rows[i].Cells["GR Amount"].Value);
                    Qty = Convert.ToDecimal(grid_detail.Rows[i].Cells["GR Qty."].Value);

                    TotalPOAmount = TotalPOAmount + POAmount;
                    TotalPOQty = TotalPOQty + POQty;
                    TotalAmount = TotalAmount + Amount;
                    TotalQty = TotalQty + Qty;

                    if (Convert.ToBoolean(grid_detail.Rows[i].Cells["Receiving"].Value) == true)
                    {
                        ReceivingQty = Convert.ToDecimal(grid_detail.Rows[i].Cells["GR Qty."].Value);
                        ReceivingAmount = Convert.ToDecimal(grid_detail.Rows[i].Cells["GR Amount"].Value);

                        TotalReceivingQty = TotalReceivingQty + ReceivingQty;
                        TotalReceivingAmount = TotalReceivingAmount + ReceivingAmount;
                    }
                }
                String AmountString = TotalReceivingAmount.ToString("N2") + " / " + TotalAmount.ToString("N2");
                String QtyString = TotalReceivingQty.ToString("N2") + " / " + TotalQty.ToString("N2");
                txt_totalAmount.Text = AmountString;
                txt_totalQty.Text = QtyString;
                txt_totalPOQty.Text = TotalPOQty.ToString("N2");
                txt_totalPOAmount.Text = TotalPOAmount.ToString("N2");
                txt_totalDiffQty.Text = (TotalQty - TotalPOQty).ToString("N2");
                txt_totalDiffAmount.Text = (TotalAmount - TotalPOAmount).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Calculate() Error");
            }
        }
        private void Initialize()
        {
            dateTimePickerReceipt.Value = DateTime.Today.Date;
            cbo_site.Text = "";
            txt_receivingSite.Text = "";
            txt_supplierID.Text = "";
            txt_supplierName.Text = "";
            txt_memo.Text = "";
            txt_poNumber.Text = "";
            txt_totalPOQty.Text = "0.00";
            txt_totalPOAmount.Text = "0.00";
            txt_receiptNumber.Text = "";
            txt_totalQty.Text = "0.00";
            txt_totalAmount.Text = "0.00";
            txt_totalDiffQty.Text = "0.00";
            txt_totalDiffAmount.Text = "0.00";

            cbo_site.Enabled = false;
            txt_memo.Enabled = false;
            grid_detail.DataSource = null;

            grid_detail.Columns["➕"].Visible = false;
            grid_detail.Columns["Delete"].Visible = false;
            grid_detail.Columns["Status"].ReadOnly = true;
            grid_detail.Columns["GR Qty."].ReadOnly = true;
            grid_detail.Columns["Expiration Date"].ReadOnly = true;
            grid_detail.Columns["Receiving"].ReadOnly = true;
            grid_detail.Columns["Reason"].ReadOnly = true;
        }

    }
}
