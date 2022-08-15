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

namespace OBCS.Purchase
{
    public partial class PORDER : Form
    {
        Boolean NewPo = false;
        Boolean POprepare = false;
        Boolean POprepareVoid = false;
        public PORDER()
        {
            InitializeComponent();

            btn_create.Enabled = false;

            grid_po_Init();
            dateTimePickerFrom.Value = DateTime.Today.AddMonths(-3);
            dateTimePickerVoidFrom.Value = DateTime.Today.AddMonths(-3);
            String SearchPONumber = txt_PSOrderID.Text.Trim();
            String SearchRECNumber = txt_PSRECID.Text.Trim();
            String SearchSite = cbo_PSSite.Text.Trim();
            String SearchSupplier = txt_PSSupplier.Text.Trim();
            String SearchMemo = txt_PSMemo.Text.Trim();
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;

            //Clear the binding.
            grid_poPrepare.DataSource = null;
            grid_poPrepareVoid.DataSource = null;
            grid_detail.DataSource = null;
            grid_POReceiptHistory.DataSource = null;
            checkBox_ConfirmedDate.Enabled = false;
            checkBox_ExpectedDate.Enabled = false;
            dateTimePicker_ETA.Enabled = false;
            //dgrid_poPrepare_Init(); //this line and the four lines below have been added to a method at the bottom (when clicking tab2 of tabcontrol1)
            //grid_poPrepareVoid_Init();
            //위 2줄 + *밑에 5줄 뺌 ... grid_poPrepare_Init()은 btn_refreshPOPrepare에 추가하고
            //                         grid_poPrepareVoid_Init()은 btn_refreshVoid에 추가함
            //**************Close 누를때 error exception 던지는거 해결법*************
            //grid_poPrepare_Init();
            //grid_poPrepareVoid_Init();
            grid_detail_Init();
            grid_POReceiptHistory_Init();
            /* *밑에 5줄
            ****************PO키면 PO Prepare의 첫번째 HEADER의 DETAIL 이 표시되었었음. 이거 해결법 ************
            String SearchPOPNumber = txt_PPSOrderID.Text.Trim();
            String SearchPOPSupplier = txt_PPSSupplier.Text.Trim();
            String SearchPOPMemo = txt_PPSMemo.Text.Trim();
            connPO.sp_POPrepare_HEADER(grid_poPrepare, SearchPOPNumber, SearchPOPSupplier, SearchPOPMemo);
            connPO.sp_POPrepareVoid_HEADER(grid_poPrepareVoid, FromDate, ToDate);*/

            grid_po.ClearSelection();
            grid_poPrepare.ClearSelection();
            grid_detail.ClearSelection();

            cbo_location.Items.Clear();
            cbo_location.Items.Add("BCS");
            cbo_location.Items.Add("WH2");
            cbo_location.Items.Add("IFN");

            cbo_term.Items.Clear();
            connPO.cbo_term(cbo_term);

            cbo_shipVia.Items.Clear();

            cbo_shipVia.Items.Add("");
            cbo_shipVia.Items.Add("DELIVERY");
            cbo_shipVia.Items.Add("OURTRUCK");
            cbo_shipVia.Items.Add("THRPT");
            cbo_shipVia.Items.Add("N/A");

            connPO.sp_GET_SUPPLIER(cbo_supplierID);        
            cbo_PSSite.Items.Add("");
            cbo_PSSite.Items.Add("BCS");
            cbo_PSSite.Items.Add("WH2");
            cbo_PSSite.Items.Add("IFN");

            //아이템 가져오기
            cbo_product.Items.Clear();
            connSalesOrder.cbo_itemID(cbo_product);
            tabControl1.SelectTab(0);
        }

        private void grid_po_Init()
        {
            //detail grid multi line allow
            grid_po.AllowDrop = true;
            grid_po.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_po.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            grid_po.AutoGenerateColumns = false;
            grid_po.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_po.ColumnCount = 13;

            grid_po.Columns[0].Name = "PO Date";
            grid_po.Columns[0].ReadOnly = true;
            grid_po.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_po.Columns[0].Width = 61;
            grid_po.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_po.Columns[0].DataPropertyName = "ORDDAT_0";

            grid_po.Columns[1].Name = "PO No.";
            grid_po.Columns[1].ReadOnly = true;
            grid_po.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_po.Columns[1].Width = 57;
            grid_po.Columns[1].DataPropertyName = "POHNUM_0";

            grid_po.Columns[2].Name = "Receipt No.";
            grid_po.Columns[2].ReadOnly = true;
            grid_po.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_po.Columns[2].Width = 62;
            grid_po.Columns[2].DataPropertyName = "PTHNUM_0";

            grid_po.Columns[3].Name = "Receipt Date";
            grid_po.Columns[3].ReadOnly = true;
            grid_po.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_po.Columns[3].Width = 60;
            grid_po.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_po.Columns[3].DataPropertyName = "RCPDAT_0";

            grid_po.Columns[4].Name = "Order Site";
            grid_po.Columns[4].ReadOnly = true;
            grid_po.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_po.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_po.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_po.Columns[4].Width = 30;
            grid_po.Columns[4].DataPropertyName = "POHFCY_0";

            grid_po.Columns[5].Name = "Supplier";
            grid_po.Columns[5].ReadOnly = true;
            grid_po.Columns[5].Width = 85;
            grid_po.Columns[5].DataPropertyName = "BPSNUM_0";

            grid_po.Columns[6].Name = "Memo";
            grid_po.Columns[6].ReadOnly = true;
            grid_po.Columns[6].Width = 40;
            grid_po.Columns[6].DataPropertyName = "PMemo";
            
            DataGridViewCheckBoxColumn confirmCheck = new DataGridViewCheckBoxColumn();
            confirmCheck.HeaderText = "Confirmed";
            confirmCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            confirmCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            confirmCheck.FalseValue = false;
            confirmCheck.TrueValue = true;
            confirmCheck.Name = "CheckBox";
            confirmCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            confirmCheck.ReadOnly = true;
            confirmCheck.Width = 60;
            confirmCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            grid_po.Columns.Insert(7, confirmCheck);
            grid_po.CellContentClick += new DataGridViewCellEventHandler(confirmcellclick);

            grid_po.Columns[8].Name = "PStatus";
            grid_po.Columns[8].Visible = false;
            grid_po.Columns[8].DataPropertyName = "PStatus";

            grid_po.Columns[9].Name = "Delivery Date";
            grid_po.Columns[9].ReadOnly = true;
            grid_po.Columns[9].Width = 60;
            grid_po.Columns[9].DataPropertyName = "DateBabe";

            grid_po.Columns[10].Name = "Status";
            grid_po.Columns[10].ReadOnly = true;
            grid_po.Columns[10].Width = 67;
            grid_po.Columns[10].SortMode = DataGridViewColumnSortMode.Automatic;
            grid_po.Columns[10].DataPropertyName = "StatusFlag";

            grid_po.Columns[11].Name = "WHMemo"; //10
            grid_po.Columns[11].Visible = false;
            grid_po.Columns[11].DataPropertyName = "WHMemo";

            grid_po.Columns[12].Name = "SupplierName"; //11
            grid_po.Columns[12].Visible = false;
            grid_po.Columns[12].DataPropertyName = "BPRNAM_0";

            grid_po.Columns[13].Name = "Flag"; //12
            grid_po.Columns[13].Visible = false;
            grid_po.Columns[13].DataPropertyName = "TSSCOD_0";

            DataGridViewButtonColumn deletePOButton = new DataGridViewButtonColumn(); //delete button found within the po header grid
            deletePOButton.Width = 46;
            deletePOButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deletePOButton.Name = "Delete";
            deletePOButton.Text = "Delete";
            deletePOButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deletePOButton.UseColumnTextForButtonValue = true;
            if (grid_po.Columns["Delete"] == null)
            {
                grid_po.Columns.Insert(13, deletePOButton);
            }
            //grid font size custom
            grid_po.RowTemplate.Height = 20;
            foreach (DataGridViewColumn c in grid_po.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 7F, FontStyle.Bold);
            }
            grid_po.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 7F, FontStyle.Bold);
        }

        private void confirmcellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 7) //confirm check box click
            {
                if (Convert.ToBoolean(grid_po.Rows[e.RowIndex].Cells["CheckBox"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to confirm this P/O?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        grid_po.Rows[e.RowIndex].Cells["CheckBox"].Value = true;
                        String PONumber = grid_po.Rows[e.RowIndex].Cells["PO No."].Value.ToString();
                        connPO.sp_PORDER_ConfirmCheckUncheck("CHECK", PONumber);
                        //finished
                        MessageBox.Show(PONumber + " confirmed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
                else // uncheck 했을 때
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure cancel the confirm?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        grid_po.Rows[e.RowIndex].Cells["CheckBox"].Value = false;
                        String PONumber = grid_po.Rows[e.RowIndex].Cells["PO No."].Value.ToString();
                        connPO.sp_PORDER_ConfirmCheckUncheck("UNCHECK", PONumber);
                        //finished
                        MessageBox.Show("The P/O, " + PONumber + " cancelled confirmed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
            }
        }

        private void grid_poPrepare_Init()
        {
            //po prepare grid multi line allow
            grid_poPrepare.AllowDrop = true;
            grid_poPrepare.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_poPrepare.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            grid_poPrepare.AutoGenerateColumns = false;
            grid_poPrepare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_poPrepare.ColumnCount = 5;

            grid_poPrepare.Columns[0].Name = "Date";
            grid_poPrepare.Columns[0].ReadOnly = true;
            grid_poPrepare.Columns[0].Width = 75;
            grid_poPrepare.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_poPrepare.Columns[0].DataPropertyName = "CreateDate";

            grid_poPrepare.Columns[1].Name = "No.";
            grid_poPrepare.Columns[1].ReadOnly = true;
            grid_poPrepare.Columns[1].Width = 85;
            grid_poPrepare.Columns[1].DataPropertyName = "POPrepareNumber";

            grid_poPrepare.Columns[2].Name = "Supplier";
            grid_poPrepare.Columns[2].ReadOnly = true;
            grid_poPrepare.Columns[2].Width = 200;
            grid_poPrepare.Columns[2].DataPropertyName = "Supplier";

            grid_poPrepare.Columns[3].Name = "Brand";
            grid_poPrepare.Columns[3].ReadOnly = true;
            grid_poPrepare.Columns[3].Width = 200;
            grid_poPrepare.Columns[3].DataPropertyName = "Brand";

            grid_poPrepare.Columns[4].Name = "Memo";
            grid_poPrepare.Columns[4].ReadOnly = true;
            grid_poPrepare.Columns[4].Width = 200;
            grid_poPrepare.Columns[4].DataPropertyName = "Memo";

            DataGridViewButtonColumn voidButton = new DataGridViewButtonColumn();
            voidButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            voidButton.Width = 50;
            voidButton.Name = "Void";
            voidButton.Text = "Void";
            voidButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            voidButton.UseColumnTextForButtonValue = true;
            if (grid_poPrepare.Columns["Void"] == null)
            {
                grid_poPrepare.Columns.Insert(5, voidButton);
            }
            grid_poPrepare.RowTemplate.Height = 20;
            grid_poPrepare.ColumnHeadersHeight = 30;
            foreach (DataGridViewColumn c in grid_poPrepare.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_poPrepare.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_poPrepareVoid_Init()
        {
            //po prepare grid multi line allow
            grid_poPrepareVoid.AllowDrop = true;
            grid_poPrepareVoid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_poPrepareVoid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            grid_poPrepareVoid.AutoGenerateColumns = false;
            grid_poPrepareVoid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_poPrepareVoid.ColumnCount = 4;

            grid_poPrepareVoid.Columns[0].Name = "Date";
            grid_poPrepareVoid.Columns[0].ReadOnly = true;
            grid_poPrepareVoid.Columns[0].Width = 75;
            grid_poPrepareVoid.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_poPrepareVoid.Columns[0].DataPropertyName = "CreateDate";

            grid_poPrepareVoid.Columns[1].Name = "No.";
            grid_poPrepareVoid.Columns[1].ReadOnly = true;
            grid_poPrepareVoid.Columns[1].Width = 85;
            grid_poPrepareVoid.Columns[1].DataPropertyName = "POPrepareNumber";

            grid_poPrepareVoid.Columns[2].Name = "Supplier";
            grid_poPrepareVoid.Columns[2].ReadOnly = true;
            grid_poPrepareVoid.Columns[2].Width = 200;
            grid_poPrepareVoid.Columns[2].DataPropertyName = "Supplier";

            grid_poPrepareVoid.Columns[3].Name = "Memo";
            grid_poPrepareVoid.Columns[3].ReadOnly = true;
            grid_poPrepareVoid.Columns[3].Width = 200;
            grid_poPrepareVoid.Columns[3].DataPropertyName = "Memo";

            //grid font size custom
            grid_poPrepareVoid.RowTemplate.Height = 20;
            grid_poPrepareVoid.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_poPrepareVoid.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_poPrepareVoid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_detail_Init()
        {

            //detail grid multi line allow
            grid_detail.AllowDrop = true;
            grid_detail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_detail.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            grid_detail.AutoGenerateColumns = false;
            grid_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_detail.ColumnCount = 20;

            grid_detail.Columns[0].Name = "Product (BCS)";
            grid_detail.Columns[0].ReadOnly = true;
            grid_detail.Columns[0].Width = 70;
            grid_detail.Columns[0].DataPropertyName = "ItemID";

            grid_detail.Columns[1].Name = "Product (Supplier)";
            grid_detail.Columns[1].ReadOnly = true;
            grid_detail.Columns[1].Width = 70;
            grid_detail.Columns[1].DataPropertyName = "VendorCode";

            grid_detail.Columns[2].Name = "Description";
            grid_detail.Columns[2].ReadOnly = true;
            grid_detail.Columns[2].Width = 250;
            grid_detail.Columns[2].DataPropertyName = "ProductDesc";

            grid_detail.Columns[3].Name = "Pack Size";
            grid_detail.Columns[3].ReadOnly = true;
            grid_detail.Columns[3].Width = 80;
            grid_detail.Columns[3].DataPropertyName = "StrPackSize";

            grid_detail.Columns[4].Name = "Unit";
            grid_detail.Columns[4].ReadOnly = true;
            grid_detail.Columns[4].Width = 40;
            grid_detail.Columns[4].DataPropertyName = "SUnitM";

            grid_detail.Columns[5].Name = "Order Qty.";
            grid_detail.Columns[5].Width = 50;
            grid_detail.Columns[5].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].DataPropertyName = "OrderQty";

            grid_detail.Columns[6].Name = "Received Qty";
            grid_detail.Columns[6].ReadOnly = true;
            grid_detail.Columns[6].Width = 80;
            grid_detail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].DataPropertyName = "ReceivedQty";

            grid_detail.Columns[7].Name = "STK qty.";
            grid_detail.Columns[7].ReadOnly = true;
            grid_detail.Columns[7].Width = 50;
            grid_detail.Columns[7].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[7].DataPropertyName = "CSInner";

            grid_detail.Columns[8].Name = "Expected rcpt. Date";
            grid_detail.Columns[8].ReadOnly = true;
            grid_detail.Columns[8].Visible = false;
            grid_detail.Columns[8].Width = 80;
            grid_detail.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_detail.Columns[8].DataPropertyName = "ExpectedRcptDate";

            grid_detail.Columns[9].Name = "Gross Price";
            grid_detail.Columns[9].Width = 60;
            grid_detail.Columns[9].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[9].DataPropertyName = "UnitPr";

            grid_detail.Columns[10].Name = "EDLP";
            grid_detail.Columns[10].Width = 50;
            grid_detail.Columns[10].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[10].DataPropertyName = "EDLP";

            grid_detail.Columns[11].Name = "EDLP (P)";
            grid_detail.Columns[11].Width = 50;
            grid_detail.Columns[11].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[11].DataPropertyName = "EDLPP";

            grid_detail.Columns[12].Name = "Term Promo";
            grid_detail.Columns[12].Width = 60;
            grid_detail.Columns[12].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[12].DataPropertyName = "TermPromo";

            grid_detail.Columns[13].Name = "Term Promo (P)";
            grid_detail.Columns[13].Width = 60;
            grid_detail.Columns[13].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[13].DataPropertyName = "TermPromoP";

            grid_detail.Columns[14].Name = "Net Price";
            grid_detail.Columns[14].ReadOnly = true;
            grid_detail.Columns[14].Width = 60;
            grid_detail.Columns[14].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[14].DataPropertyName = "NetPrice";

            grid_detail.Columns[15].Name = "Order Amount";
            grid_detail.Columns[15].ReadOnly = true;
            grid_detail.Columns[15].Width = 100;
            grid_detail.Columns[15].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[15].DataPropertyName = "OrderAmount";

            grid_detail.Columns[16].Name = "Receiving Site";
            grid_detail.Columns[16].Visible = false;
            grid_detail.Columns[16].Width = 50;
            grid_detail.Columns[16].DataPropertyName = "ReceivingSite";

            //Order Add
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 50;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_detail.Columns["Delete"] == null)
            {
                grid_detail.Columns.Insert(19, deleteButton);
            }

            grid_detail.Columns[17].Name = "Billed-by Supplier";
            grid_detail.Columns[17].Visible = false;
            grid_detail.Columns[17].Width = 140;
            grid_detail.Columns[17].DataPropertyName = "BilledBySupplier";

            grid_detail.Columns[18].Name = "PODetailKey";
            grid_detail.Columns[18].Visible = false;
            grid_detail.Columns[18].Width = 30;
            grid_detail.Columns[18].DataPropertyName = "PODetailKey";

            //grid font size custom
            grid_detail.RowTemplate.Height = 20;
            grid_detail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_detail.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_detail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_POReceiptHistory_Init()
        {
            grid_POReceiptHistory.AutoGenerateColumns = false;
            grid_POReceiptHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_POReceiptHistory.ColumnCount = 16;

            grid_POReceiptHistory.Columns[0].Name = "Order Date";
            grid_POReceiptHistory.Columns[0].ReadOnly = true;
            grid_POReceiptHistory.Columns[0].Width = 75;
            grid_POReceiptHistory.Columns[0].MinimumWidth = 75;
            grid_POReceiptHistory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_POReceiptHistory.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_POReceiptHistory.Columns[0].DataPropertyName = "ORDDAT_0";

            grid_POReceiptHistory.Columns[1].Name = "Order No.";
            grid_POReceiptHistory.Columns[1].ReadOnly = true;
            grid_POReceiptHistory.Columns[1].Width = 75;
            grid_POReceiptHistory.Columns[1].MinimumWidth = 75;
            grid_POReceiptHistory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_POReceiptHistory.Columns[1].DataPropertyName = "POHNUM_0";

            grid_POReceiptHistory.Columns[2].Name = "Receipt Date";
            grid_POReceiptHistory.Columns[2].ReadOnly = true;
            grid_POReceiptHistory.Columns[2].Width = 75;
            grid_POReceiptHistory.Columns[2].MinimumWidth = 75;
            grid_POReceiptHistory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_POReceiptHistory.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_POReceiptHistory.Columns[2].DataPropertyName = "RCPDAT_0";

            grid_POReceiptHistory.Columns[3].Name = "Receipt No.";
            grid_POReceiptHistory.Columns[3].ReadOnly = true;
            grid_POReceiptHistory.Columns[3].Width = 85;
            grid_POReceiptHistory.Columns[3].MinimumWidth = 85;
            grid_POReceiptHistory.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_POReceiptHistory.Columns[3].DataPropertyName = "PTHNUM_0";

            grid_POReceiptHistory.Columns[4].Name = "Order Qty";
            grid_POReceiptHistory.Columns[4].ReadOnly = true;
            grid_POReceiptHistory.Columns[4].Width = 50;
            grid_POReceiptHistory.Columns[4].MinimumWidth = 50;
            grid_POReceiptHistory.Columns[4].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[4].DataPropertyName = "QTY_0";

            grid_POReceiptHistory.Columns[5].Name = "Receipt Qty";
            grid_POReceiptHistory.Columns[5].ReadOnly = true;
            grid_POReceiptHistory.Columns[5].Width = 50;
            grid_POReceiptHistory.Columns[5].MinimumWidth = 50;
            grid_POReceiptHistory.Columns[5].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[5].DataPropertyName = "QTYUOM_0";

            grid_POReceiptHistory.Columns[6].Name = "Stock Conversion Qty";
            grid_POReceiptHistory.Columns[6].ReadOnly = true;
            grid_POReceiptHistory.Columns[6].Width = 50;
            grid_POReceiptHistory.Columns[6].MinimumWidth = 50;
            grid_POReceiptHistory.Columns[6].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[6].DataPropertyName = "StockConversionReceiptQty";

            grid_POReceiptHistory.Columns[7].Name = "Gross Price";
            grid_POReceiptHistory.Columns[7].ReadOnly = true;
            grid_POReceiptHistory.Columns[7].Width = 50;
            grid_POReceiptHistory.Columns[7].MinimumWidth = 50;
            grid_POReceiptHistory.Columns[7].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[7].DataPropertyName = "GROPRI_0";

            grid_POReceiptHistory.Columns[8].Name = "Promotion";
            grid_POReceiptHistory.Columns[8].ReadOnly = true;
            grid_POReceiptHistory.Columns[8].Width = 40;
            grid_POReceiptHistory.Columns[8].MinimumWidth = 40;
            grid_POReceiptHistory.Columns[8].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[8].DataPropertyName = "Promo2";

            grid_POReceiptHistory.Columns[9].Name = "Promotion(P)";
            grid_POReceiptHistory.Columns[9].ReadOnly = true;
            grid_POReceiptHistory.Columns[9].Width = 40;
            grid_POReceiptHistory.Columns[9].MinimumWidth = 40;
            grid_POReceiptHistory.Columns[9].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[9].DataPropertyName = "PromoP2";

            grid_POReceiptHistory.Columns[10].Name = "EDLP";
            grid_POReceiptHistory.Columns[10].Width = 40;
            grid_POReceiptHistory.Columns[10].MinimumWidth = 40;
            grid_POReceiptHistory.Columns[10].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[10].DataPropertyName = "EDLP2";

            grid_POReceiptHistory.Columns[11].Name = "EDLP(P)";
            grid_POReceiptHistory.Columns[11].Width = 40;
            grid_POReceiptHistory.Columns[11].MinimumWidth = 40;
            grid_POReceiptHistory.Columns[11].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[11].DataPropertyName = "EDLPP2";

            grid_POReceiptHistory.Columns[12].Name = "Price";
            grid_POReceiptHistory.Columns[12].Width = 70;
            grid_POReceiptHistory.Columns[12].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[12].DataPropertyName = "NETPRI_0";

            grid_POReceiptHistory.Columns[13].Name = "Amount";
            grid_POReceiptHistory.Columns[13].Width = 55;
            grid_POReceiptHistory.Columns[13].MinimumWidth = 55;
            grid_POReceiptHistory.Columns[13].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[13].DataPropertyName = "LINAMT_0";

            grid_POReceiptHistory.Columns[14].Name = "Status";
            grid_POReceiptHistory.Columns[14].Visible = false;
            grid_POReceiptHistory.Columns[14].Width = 40;
            grid_POReceiptHistory.Columns[14].DataPropertyName = "";

            grid_POReceiptHistory.Columns[15].Name = "Expire Date";
            grid_POReceiptHistory.Columns[15].ReadOnly = true;
            grid_POReceiptHistory.Columns[15].Width = 70;
            grid_POReceiptHistory.Columns[15].MinimumWidth = 70;
            grid_POReceiptHistory.Columns[15].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_POReceiptHistory.Columns[15].DataPropertyName = "ExpirationDate";

            //grid font size custom
            grid_POReceiptHistory.RowTemplate.Height = 20;
            grid_POReceiptHistory.ColumnHeadersHeight = 30;
            foreach (DataGridViewColumn c in grid_POReceiptHistory.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_POReceiptHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        String POPrepareNumber;
        String POPNumber;
        private void grid_poPrepare_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_brand.Visible = true;
                lbl_brand.Visible = true;
                txt_leadtime.Visible = true;
                lbl_leadtime.Visible = true;
                DateTime Date = Convert.ToDateTime(grid_poPrepare.Rows[e.RowIndex].Cells["Date"].Value.ToString());
                dateTimePicker1.Value = Date;
                dateTimePicker_ETA.Value = Date;
                POPrepareNumber = grid_poPrepare.Rows[e.RowIndex].Cells["No."].Value.ToString();
                POPNumber = grid_poPrepare.Rows[e.RowIndex].Cells["No."].Value.ToString();
                connPO.sp_POPrepare_DETAIL(grid_detail, POPNumber);
                txt_leadtime.Text = connPO.sp_POPrepare_GET_LeadTime("LeadTime", POPNumber);
                txt_brand.Text = connPO.sp_POPrepare_GET_LeadTime("BrandCode", POPNumber);
                grid_detail.ClearSelection();
                grid_po.ClearSelection();
                String Supplier = grid_poPrepare.Rows[e.RowIndex].Cells["Supplier"].Value.ToString();
                cbo_supplierID.Text = Supplier;
                String Memo = grid_poPrepare.Rows[e.RowIndex].Cells["Memo"].Value.ToString();
                txt_memo.Text = Memo;
                btn_create.Enabled = true;
                btn_print.Enabled = false;
                btn_printWarehouse.Enabled = false;
                btn_saveMemo.Enabled = false;
                cbo_supplierID.Enabled = false;
                txt_memo.Enabled = true;
                txt_poNumber.Text = "";
                cbo_product.Text = "";
                cbo_supplierID.Enabled = true;
            }
            catch
            {
            }
        }

        private void grid_detail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string orderQtyString = grid_detail.CurrentRow.Cells["Order Qty."].Value.ToString();
                double orderQty = Convert.ToDouble(orderQtyString);

                string GrossPriceString = grid_detail.CurrentRow.Cells["Gross Price"].Value.ToString();
                double GrossPrice = Convert.ToDouble(GrossPriceString);

                string EDLPString = grid_detail.CurrentRow.Cells["EDLP"].Value.ToString();
                double EDLP = Convert.ToDouble(EDLPString);

                string EDLPPString = grid_detail.CurrentRow.Cells["EDLP (P)"].Value.ToString();
                double EDLPP = Convert.ToDouble(EDLPPString);

                string TermPromoString = grid_detail.CurrentRow.Cells["Term Promo"].Value.ToString();
                double TermPromo = Convert.ToDouble(TermPromoString);

                string TermPromoPString = grid_detail.CurrentRow.Cells["Term Promo (P)"].Value.ToString();
                double TermPromoP = Convert.ToDouble(TermPromoPString);

                string OrderAmountString = grid_detail.CurrentRow.Cells["Order Amount"].Value.ToString();
                double OrderAmount = Convert.ToDouble(TermPromoPString);

                double netPrice = 0;
                double dEDLPP = 0;
                double dTermPromoP = 0;

                //dEDLPP = EDLPP * 0.01 * GrossPrice;
                //dTermPromoP = TermPromoP * 0.01 * GrossPrice;
                dEDLPP = Math.Round((EDLPP * 0.01 * GrossPrice), 2); //10*0.01*10.74=1.074 //1.07
                dTermPromoP = Math.Round((TermPromoP * 0.01 * GrossPrice), 2);
                netPrice = GrossPrice - EDLP - dEDLPP - TermPromo - dTermPromoP; // 10.74 - 0 - 1.074 - 0 - 0 = 9.666 // 10.74 - 0 - 1.07 - 0 - 0 = 9.67
                double orderAmount = 0;
                if (netPrice < 0)
                {
                    MessageBox.Show("-----", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    grid_detail.CurrentRow.Cells["EDLP"].Value = "0";
                    grid_detail.CurrentRow.Cells["EDLP (P)"].Value = "0";
                    grid_detail.CurrentRow.Cells["Term Promo"].Value = "0";
                    grid_detail.CurrentRow.Cells["Term Promo (P)"].Value = "0";
                    grid_detail.CurrentRow.Cells["Net Price"].Value = (Convert.ToDecimal(grid_detail.CurrentRow.Cells["Gross Price"].Value)).ToString();
                    netPrice = Convert.ToDouble(grid_detail.CurrentRow.Cells["Net Price"].Value);
                    orderAmount = netPrice * orderQty;
                    grid_detail.CurrentRow.Cells["Order Amount"].Value = orderAmount.ToString();
                    return;
                }
                orderAmount = netPrice * orderQty;
                grid_detail.CurrentRow.Cells["Net Price"].Value = netPrice.ToString();
                grid_detail.CurrentRow.Cells["Order Amount"].Value = orderAmount.ToString();
            }
            catch
            {
                MessageBox.Show("1");
            }

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            
            String supplierID = cbo_supplierID.Text.Trim();
            if (supplierID != "" && connPO.sp_getSupplierInfoWithSupplierID(supplierID) != "") //supplier안 치거나, 이상한 string 넣었을때 create 안되게끔 추가한 if-else statement
            {
                DialogResult dialogResult = MessageBox.Show("Proceed with this P/O prepare process?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    //Get a new PO Number from Server 12/24/2018
                    String NewPONumber = connSalesOrder.sp_GET_NewPONumber();

                    if (cbo_location.Text == "")
                    {
                        MessageBox.Show("Select Receiving Site.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    String ReceivingSite;
                    if (cbo_location.Text == "BCS")
                    {
                        ReceivingSite = "BCS";
                    }
                    else if (cbo_location.Text == "WH2")
                    {
                        ReceivingSite = "WH2";
                    }
                    else
                    {
                        ReceivingSite = "IFN";
                    }

                    for (int i = 0; i < grid_detail.Rows.Count; i++)
                    {
                        String PORDERNumber = "";
                        String Supplier = cbo_supplierID.Text.Trim();
                        String Memo = "";
                        String ProductBCS = grid_detail.Rows[i].Cells["Product (BCS)"].Value.ToString();
                        String ProductSupplier = grid_detail.Rows[i].Cells["Product (Supplier)"].Value.ToString();
                        Decimal OrderQty = Convert.ToDecimal(grid_detail.Rows[i].Cells["Order Qty."].Value.ToString());
                        String Description = grid_detail.Rows[i].Cells["Description"].Value.ToString();
                        String PackSize = grid_detail.Rows[i].Cells["Pack Size"].Value.ToString();
                        Decimal GrossPrice = Convert.ToDecimal(grid_detail.Rows[i].Cells["Gross Price"].Value.ToString());
                        Decimal EDLP = Convert.ToDecimal(grid_detail.Rows[i].Cells["EDLP"].Value.ToString());
                        Decimal EDLPP = Convert.ToDecimal(grid_detail.Rows[i].Cells["EDLP (P)"].Value.ToString());
                        Decimal TermPromo = Convert.ToDecimal(grid_detail.Rows[i].Cells["Term Promo"].Value.ToString());
                        Decimal TermPromoP = Convert.ToDecimal(grid_detail.Rows[i].Cells["Term Promo (P)"].Value.ToString());
                        Decimal NetPrice = Convert.ToDecimal(grid_detail.Rows[i].Cells["Net Price"].Value.ToString());
                        Decimal OrderAmount = Convert.ToDecimal(grid_detail.Rows[i].Cells["Order Amount"].Value.ToString());
                        String Unit = grid_detail.Rows[i].Cells["Unit"].Value.ToString();
                        DateTime ExpectedRcptDate = Convert.ToDateTime(grid_detail.Rows[i].Cells["Expected rcpt. Date"].Value.ToString());
                        String BilledBySupplier = grid_detail.Rows[i].Cells["Billed-by Supplier"].Value.ToString();
                        Decimal StockConversionQty = Convert.ToDecimal(grid_detail.Rows[i].Cells["STK qty."].Value.ToString());

                        Entities.PORDER pORDER = new Entities.PORDER();

                        pORDER.PORDERNumber = PORDERNumber;
                        pORDER.ReceivingSite = ReceivingSite;
                        pORDER.Supplier = Supplier;
                        pORDER.Memo = Memo;
                        pORDER.ProductBCS = ProductBCS;
                        pORDER.ProductSupplier = ProductSupplier;
                        pORDER.OrderQty = OrderQty;
                        pORDER.Description = Description;
                        pORDER.PackSize = PackSize;
                        pORDER.GrossPrice = GrossPrice;
                        pORDER.EDLP = EDLP;
                        pORDER.EDLPP = EDLPP;
                        pORDER.TermPromo = TermPromo;
                        pORDER.TermPromoP = TermPromoP;
                        pORDER.NetPrice = NetPrice;
                        pORDER.OrderAmount = OrderAmount;
                        pORDER.Unit = Unit;
                        pORDER.ExpectedRcptDate = ExpectedRcptDate;
                        pORDER.BilledBySupplier = BilledBySupplier;
                        pORDER.Line = i + 1;
                        pORDER.Location = "";
                        pORDER.STKQty = StockConversionQty;

                        connPO.sp_INSERT_PORDERD(pORDER, NewPONumber);
                    }
                    String SupplierID = cbo_supplierID.Text.Trim();
                    String POrderMemo = txt_memo.Text;
                    String WHMemo = txt_WHMemo.Text;
                    DateTime POExpectedRcptDate = dateTimePicker_ETA.Value.Date;
                    String ShipVia = cbo_shipVia.Text.Trim();

                    connPO.sp_CREATE_PORDER(SupplierID, POrderMemo, WHMemo, POPrepareNumber, ReceivingSite, POPNumber, NewPONumber, POExpectedRcptDate, ShipVia);

                    String SearchPONumber = txt_PSOrderID.Text.Trim();
                    String SearchRECNumber = txt_PSRECID.Text.Trim();
                    String SearchSite = cbo_PSSite.Text.Trim();
                    String SearchSupplier = txt_PSSupplier.Text.Trim();
                    String SearchMemo = txt_PSMemo.Text.Trim();
                    DateTime FromDate = dateTimePickerFrom.Value.Date;
                    DateTime ToDate = dateTimePickerTo.Value.Date;
                    connPO.sp_PO_HEADER(grid_po, FromDate, ToDate, SearchPONumber, SearchRECNumber, SearchSite, SearchSupplier, SearchMemo);

                    String SearchPOPNumber = txt_PPSOrderID.Text.Trim();
                    String SearchPOPSupplier = txt_PPSSupplier.Text.Trim();
                    String SearchBrand = txtBox_Brand.Text.Trim();
                    String SearchPOPMemo = txt_PPSMemo.Text.Trim();
                    connPO.sp_POPrepare_HEADER3(grid_poPrepare, SearchPOPNumber, SearchPOPSupplier, SearchBrand, SearchPOPMemo);

                    connPO.sp_POPrepareVoid_HEADER(grid_poPrepareVoid, FromDate, ToDate);
                    btn_create.Enabled = false;
                    grid_detail.DataSource = null;
                    cbo_supplierID.Text = "";
                    txt_memo.Text = "";
                    txt_totalAmount.Text = "";

                    MessageBox.Show("P/O " + NewPONumber + " saved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            } else {
                DialogResult dialogResult = MessageBox.Show("Please choose a valid supplier from the \"Supplier ID\" field. \nYou have either input an empty string or the supplier you have provided does not exist.");
            }
        }

        private string SupplierID, SupplierName, flag; 
        private void grid_po_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dateTimePicker_ETA.Enabled = true;
                checkBox_ConfirmedDate.Enabled = true;
                checkBox_ExpectedDate.Enabled = true;
                checkBox_ConfirmedDate.Checked = false;
                checkBox_ExpectedDate.Checked = false;
                flag = grid_po.Rows[e.RowIndex].Cells["Flag"].Value.ToString();
                if (flag == "1")
                    checkBox_ExpectedDate.Checked = true;
                else if (flag == "2")
                {
                    checkBox_ConfirmedDate.Checked = true;
                }
                else if (flag == "0")
                {
                    checkBox_ConfirmedDate.Checked = false;
                    checkBox_ExpectedDate.Checked = false;
                }
                SupplierID = grid_po.Rows[e.RowIndex].Cells["Supplier"].Value.ToString();
                SupplierName = grid_po.Rows[e.RowIndex].Cells["SupplierName"].Value.ToString();
                if (flag == "0")
                {
                    dateTimePicker_ETA.Value = Convert.ToDateTime(grid_po.Rows[e.RowIndex].Cells["PO Date"].Value.ToString());
                } else if (flag == "1")
                {
                    dateTimePicker_ETA.Value = Convert.ToDateTime(grid_po.Rows[e.RowIndex].Cells["Delivery Date"].Value.ToString());
                } else if (flag == "2")
                {
                    dateTimePicker_ETA.Value = Convert.ToDateTime(grid_po.Rows[e.RowIndex].Cells["Delivery Date"].Value.ToString());
                }
                cbo_supplierID.Text = SupplierID;
                cbo_location.Text = grid_po.Rows[e.RowIndex].Cells["Order Site"].Value.ToString();
                txt_poNumber.Text = grid_po.Rows[e.RowIndex].Cells["PO No."].Value.ToString();
                txt_memo.Text = grid_po.Rows[e.RowIndex].Cells["Memo"].Value.ToString();
            }
            catch
            {
            }
            try
            {
                if (e.ColumnIndex == 13 && e.RowIndex >= 0) // Delete PO button
                {
                    String PRECEIPTNumber = grid_po.Rows[e.RowIndex].Cells["Receipt No."].Value.ToString();
                    if (PRECEIPTNumber != "")
                    {
                        MessageBox.Show("The receipt number already exists.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this P/O?", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        String PONumber = grid_po.Rows[e.RowIndex].Cells["PO No."].Value.ToString().Trim();
                        connSalesOrder.sp_PO_DELETE(PONumber);
                        grid_po.Rows.RemoveAt(e.RowIndex);
                        String SearchPONumber = txt_PSOrderID.Text.Trim();
                        String SearchRECNumber = txt_PSRECID.Text.Trim();
                        String SearchSite = cbo_PSSite.Text.Trim();
                        String SearchSupplier = txt_PSSupplier.Text.Trim();
                        String SearchMemo = txt_PSMemo.Text.Trim();
                        DateTime FromDate = dateTimePickerFrom.Value.Date;
                        DateTime ToDate = dateTimePickerTo.Value.Date;
                        btn_create.Enabled = false;
                        btn_saveMemo.Enabled = true;
                        grid_detail.DataSource = null;
                        cbo_supplierID.Text = "";
                        txt_memo.Text = "";
                        txt_totalAmount.Text = "";
                        MessageBox.Show(PONumber + " was successfully removed.");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
            }
            catch
            {
            }
        }

        private void grid_po_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in grid_po.Rows)
                {
                    if (item.Cells["PStatus"].Value.ToString().Trim() == "Confirmed")
                    {
                        item.Cells["CheckBox"].Value = true;
                    }
                }
            }
            catch
            {
            }
            grid_po.ClearSelection();
        }

        private void grid_poPrepare_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grid_poPrepare.ClearSelection();
        }

        private void grid_detail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            txt_totalAmount.Text = "";
            try
            {
                Decimal TotalAmount = 0;
                Decimal TotalQty = 0;
                for (int i = 0; i < grid_detail.Rows.Count; i++)
                {
                    Decimal Amount = Convert.ToDecimal(grid_detail.Rows[i].Cells["Order Amount"].Value);
                    TotalAmount = TotalAmount + Amount;
                    Decimal Qty = Convert.ToDecimal(grid_detail.Rows[i].Cells["Order Qty."].Value);
                    TotalQty = TotalQty + Qty;
                }
                txt_totalAmount.Text = TotalAmount.ToString();
                txt_totalQty.Text = TotalQty.ToString();
            }
            catch
            {
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (txt_poNumber.Text == "")
            {
                MessageBox.Show("Please select.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            //PO SAVE
            string PONO = txt_poNumber.Text.Trim();
            string ShipVia = cbo_shipVia.Text.Trim();
            string Term = cbo_term.Text.Trim();
            string Contact = "";
            string OrderDate = dateTimePicker1.Value.ToShortDateString();
            string RequireDate = dateTimePicker1.Value.ToShortDateString();
            string ExpectDate = dateTimePicker_ETA.Value.ToShortDateString();
            string RecevingDate = "";
            string VendorID = SupplierID;//cbo_supplierID.Text.Trim();
            string VendorName = SupplierName;//cbo_supplierID.Text.Trim();
            string VendorAddress1 = txt_billAddress1.Text.Trim();
            string VendorAddress2 = txt_billAddress2.Text.Trim();
            string VendorTel = txt_billTel.Text.Trim();
            string VendorFax = txt_billFax.Text.Trim();
            string VendorCityStateZip = txt_billCity.Text.Trim() + ", " + txt_billState.Text.Trim() + " " + txt_billZip.Text.Trim();
            string ShipName = "";

            if (cbo_location.Text.Trim() == "BCS" || cbo_location.Text.Trim() == "WH2")
            {
                ShipName = "BCS International";
            }
            else if (cbo_location.Text.Trim() == "IFN")
            {
                ShipName = "IFONS";
            }
            string ShipAddress1 = txt_shipAddress1.Text.Trim();
            string ShipAddress2 = txt_shipAddress2.Text.Trim();
            string ShipTel = txt_shipTel.Text.Trim();
            string ShipFax = txt_shipFax.Text.Trim();
            string ShipCityStateZip = txt_shipCity.Text.Trim() + ", " + txt_shipState.Text.Trim() + " " + txt_shipZip.Text.Trim();
            string TotalCase = txt_totalQty.Text.Trim();
            string TotalAmount = txt_totalAmount.Text.Trim();

            Reports.Rpt_PORDER reportTest = new Reports.Rpt_PORDER
                (
                PONO, OrderDate, RecevingDate, Term, ShipVia, Contact,
                VendorID, VendorName, VendorAddress1, VendorAddress2, VendorTel, VendorFax, VendorCityStateZip,
                ShipName, ShipAddress1, ShipAddress2, ShipTel, ShipFax, ShipCityStateZip, ExpectDate, TotalCase, TotalAmount
                );
            reportTest.Show();
        }

        

        private void cbo_location_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_location.Text == "BCS")
            {
                txt_shipAddress1.Text = "47-15 33rd St.";
                txt_shipAddress2.Text = "";
                txt_shipCity.Text = "Long Island City";
                txt_shipState.Text = "NY";
                txt_shipZip.Text = "11101";
            }
            else if (cbo_location.Text == "WH2")
            {
                txt_shipAddress1.Text = "686 Grand Ave";
                txt_shipAddress2.Text = "";
                txt_shipCity.Text = "Ridgefield";
                txt_shipState.Text = "NJ";
                txt_shipZip.Text = "07657";
            }
            else if (cbo_location.Text == "IFN")
            {
                txt_shipAddress1.Text = "12 Jamaica Ave";
                txt_shipAddress2.Text = "";
                txt_shipCity.Text = "Plainview";
                txt_shipState.Text = "NY";
                txt_shipZip.Text = "11803";
            }
        }

        private void btn_saveMemo_Click(object sender, EventArgs e)
        {
            try
            {
                String PORDERNumber = txt_poNumber.Text;
                String Memo = txt_memo.Text;
                String WHMemo = txt_WHMemo.Text;
                connPO.sp_PORDER_SaveMemo(PORDERNumber, Memo, WHMemo);
                MessageBox.Show("the memo has been saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                String SearchPONumber = txt_PSOrderID.Text.Trim();
                String SearchRECNumber = txt_PSRECID.Text.Trim();
                String SearchSite = cbo_PSSite.Text.Trim();
                String SearchSupplier = txt_PSSupplier.Text.Trim();
                String SearchMemo = txt_PSMemo.Text.Trim();
                DateTime FromDate = dateTimePickerFrom.Value.Date;
                DateTime ToDate = dateTimePickerTo.Value.Date;
                connPO.sp_PO_HEADER(grid_po, FromDate, ToDate, SearchPONumber, SearchRECNumber, SearchSite, SearchSupplier, SearchMemo);
                grid_detail.DataSource = null;
            }
            catch
            {
                MessageBox.Show("memo save error.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_printWarehouse_Click(object sender, EventArgs e)
        {
            if (txt_poNumber.Text == "")
            {
                MessageBox.Show("Please select.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            //PO SAVE
            string PONO = txt_poNumber.Text.Trim();
            string SupplierID = cbo_supplierID.Text.Trim();
            string SupplierAddress1 = txt_billAddress1.Text.Trim() + " " + txt_billAddress2.Text.Trim();
            string SupplierAddress2 = txt_billCity.Text.Trim() + ", " + txt_billState.Text.Trim() + " " + txt_billZip.Text.Trim();
            string ShipVia = cbo_shipVia.Text.Trim();
            string WHMemo = txt_WHMemo.Text.ToString();

            Reports.Rpt_PORDERWAREHOUSE pORDERWAREHOUSE = new Reports.Rpt_PORDERWAREHOUSE(PONO, SupplierID, SupplierName, SupplierAddress1, SupplierAddress2, ShipVia, WHMemo, "USER", "USER");

            pORDERWAREHOUSE.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setProduct()
        {
            String ItemDesc = connSalesOrder.getItemDescFromItemID(cbo_product.Text);
            txt_itemDesc.Text = ItemDesc;

            String ItemUnit = connSalesOrder.getItemUnitFromItemID(cbo_product.Text);
            txt_unit.Text = ItemUnit;

            String PackSize = connSalesOrder.getItemPackSizeFromItemID(cbo_product.Text);
            txt_packSize.Text = PackSize;

            String SupplierProductID = connSalesOrder.sp_PORDER_GET_SupplierProductID(cbo_supplierID.Text.Trim(), cbo_product.Text.Trim());
            txt_supplierProductID.Text = SupplierProductID;

            String STKQty = connSalesOrder.sp_PORDER_GET_ProductSTKQty(cbo_product.Text.Trim());
            txt_stkQty.Text = STKQty;

            DateTime ExpectedRcptDate = connSalesOrder.sp_PORDER_GET_ExpectedRcptDate(cbo_product.Text.Trim());
            txt_expectedRcptDate.Text = ExpectedRcptDate.ToShortDateString();

            Decimal GrossPrice = connSalesOrder.sp_PORDER_GET_GROSSPRICE(cbo_product.Text.Trim());
            txt_grossPrice.Text = GrossPrice.ToString("N2");
        }

        private void cbo_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            setProduct();
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            if (cbo_product.Text.Trim() == "")
            {
                MessageBox.Show("Choose a product to add to the cart.");
                return;
            }
                
            int rowscount = grid_detail.Rows.Count;
            int initPODetailKey = 0;
            int maxPODetailKey = 0;

            for (int i = 0; i < grid_detail.RowCount; i++)
            {
                int PODetailKey = Convert.ToInt32(grid_detail.Rows[i].Cells["PODetailKey"].Value.ToString().Trim());
                if (maxPODetailKey < PODetailKey)
                {
                    maxPODetailKey = PODetailKey;
                }
            }
            if (grid_detail.DataSource == null)
            {
                try
                {
                    grid_detail.Rows.Add();
                    grid_detail["Product (BCS)", rowscount].Value = cbo_product.Text.ToString();
                    grid_detail["Product (Supplier)", rowscount].Value = txt_supplierProductID.Text.ToString();
                    grid_detail["Description", rowscount].Value = txt_itemDesc.Text.Trim();
                    grid_detail["Pack Size", rowscount].Value = txt_packSize.Text.Trim();
                    grid_detail["Unit", rowscount].Value = txt_unit.Text.Trim();
                    grid_detail["Order Qty.", rowscount].Value = txt_qty.Text.Trim();
                    grid_detail["Received Qty", rowscount].Value = txt_stkQty.Text.Trim();
                    grid_detail["STK qty.", rowscount].Value = txt_stkQty.Text.Trim();
                    grid_detail["Expected rcpt. Date", rowscount].Value = txt_expectedRcptDate.Text.Trim();
                    grid_detail["Gross Price", rowscount].Value = txt_grossPrice.Text.Trim();
                    grid_detail["EDLP", rowscount].Value = "0";
                    grid_detail["EDLP (P)", rowscount].Value = "0";
                    grid_detail["Term Promo", rowscount].Value = "0";
                    grid_detail["Term Promo (P)", rowscount].Value = "0";
                    grid_detail["Net Price", rowscount].Value = txt_grossPrice.Text.Trim();
                    grid_detail["Order Amount", rowscount].Value = (Convert.ToDecimal(txt_grossPrice.Text) * Convert.ToDecimal(txt_qty.Text)).ToString();
                    grid_detail["Billed-by Supplier", rowscount].Value = cbo_supplierID.Text.Trim();
                    grid_detail["PODetailKey", rowscount].Value = maxPODetailKey + 1;

                    Calculate();

                    cbo_product.Text = "";
                    txt_supplierProductID.Text = "";
                    txt_itemDesc.Text = "";
                    txt_packSize.Text = "";
                    txt_unit.Text = "";
                    txt_qty.Text = "";
                    txt_stkQty.Text = "";
                    txt_expectedRcptDate.Text = "";
                    txt_grossPrice.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    DataTable dt = this.grid_detail.DataSource as DataTable;
                    DataRow dr = dt.NewRow();

                    String ProductID = cbo_product.Text.Trim();
                    String SupplierProductID = txt_supplierProductID.Text.Trim();
                    String ProductDesc = txt_itemDesc.Text.Trim();
                    String PackSize = txt_packSize.Text.Trim();
                    String Unit = txt_unit.Text.Trim();
                    Decimal Quantity = Convert.ToDecimal(txt_qty.Text.Trim());
                    Decimal STKQty = Convert.ToDecimal(txt_stkQty.Text.Trim());
                    DateTime ExpectedRcptDate = Convert.ToDateTime(txt_expectedRcptDate.Text.Trim());
                    Decimal GrossPrice = Convert.ToDecimal(txt_grossPrice.Text.Trim());
                    Decimal EDLP = 0;
                    Decimal EDLPP = 0;
                    Decimal TermPromo = 0;
                    Decimal TermPromoP = 0;
                    Decimal NetPrice = GrossPrice;
                    Decimal OrderAmount = GrossPrice * Quantity;
                    String BilledBySupplier = cbo_supplierID.Text.Trim();

                    dr["ItemID"] = ProductID;
                    dr["VendorCode"] = SupplierProductID;
                    dr["ProductDesc"] = ProductDesc;
                    dr["StrPackSize"] = PackSize;
                    dr["SUnitM"] = Unit;
                    dr["OrderQty"] = Quantity;
                    dr["CSInner"] = STKQty;
                    dr["ExpectedRcptDate"] = ExpectedRcptDate;
                    dr["UnitPr"] = GrossPrice;
                    dr["EDLP"] = EDLP;
                    dr["EDLPP"] = EDLPP;
                    dr["TermPromo"] = TermPromo;
                    dr["TermPromoP"] = TermPromoP;
                    dr["NetPrice"] = NetPrice;
                    dr["OrderAmount"] = OrderAmount;
                    dr["ReceivingSite"] = cbo_location.Text.Trim();
                    dr["BilledBySupplier"] = BilledBySupplier;
                    dr["PODetailKey"] = maxPODetailKey + 1;
                    dt.Rows.Add(dr);

                    cbo_product.Text = "";
                    txt_supplierProductID.Text = "";
                    txt_itemDesc.Text = "";
                    txt_packSize.Text = "";
                    txt_unit.Text = "";
                    txt_qty.Text = "";
                    txt_stkQty.Text = "";
                    txt_expectedRcptDate.Text = "";
                    txt_grossPrice.Text = "";

                    Calculate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Input all item info", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void grid_detail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                grid_POReceiptHistory.DataSource = null;
                String ProductID = grid_detail.CurrentRow.Cells[0].Value.ToString();
                if (e.ColumnIndex == 19 && e.RowIndex >= 0) // Delete button
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item from the list?", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        grid_detail.Rows.RemoveAt(e.RowIndex);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
                connSalesOrder.sp_POPREPARE_RECEIPTHISTORY(grid_POReceiptHistory, ProductID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_refresh2_Click(object sender, EventArgs e)
        {
            String SearchPONumber = txt_PSOrderID.Text.Trim();
            String SearchRECNumber = txt_PSRECID.Text.Trim();
            String SearchSite = cbo_PSSite.Text.Trim();
            String SearchSupplier = txt_PSSupplier.Text.Trim();
            String SearchMemo = txt_PSMemo.Text.Trim();
            String SearchPOPNumber = txt_PPSOrderID.Text.Trim();
            String SearchPOPSupplier = txt_PPSSupplier.Text.Trim();
            String SearchPOPMemo = txt_PPSMemo.Text.Trim();
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            connPO.sp_PO_HEADER(grid_po, FromDate, ToDate, SearchPONumber, SearchRECNumber, SearchSite, SearchSupplier, SearchMemo);
        }

        private void btn_creatNewPO_Click(object sender, EventArgs e)
        {
            //cbo_supplierID.Enabled = true;
            checkBox_ExpectedDate.Enabled = false;
            checkBox_ConfirmedDate.Enabled = false;
            checkBox_ExpectedDate.Checked = false;
            checkBox_ConfirmedDate.Checked = false;
            MessageBox.Show("Supplier Select");
            cbo_supplierID.Enabled = true;
            cbo_supplierID.Text = "";
            cbo_supplierID.Focus();
            cbo_location.Text = "";
            txt_poNumber.Text = "";// connPO.sp_CREATE_NewPONumber();
            cbo_term.Text = "";
            cbo_shipVia.Text = "";
            txt_memo.Text = "";
            txt_WHMemo.Text = "";
            grid_detail.DataSource = null;
            dateTimePicker1.Value = DateTime.Now.Date;
            dateTimePicker_ETA.Value = DateTime.Now.Date;
            dateTimePicker_ETA.Enabled = false;
            btn_create.Enabled = true;
            cbo_product.Text = "";
            cbo_product_SelectedIndexChanged(sender, e);
            txt_grossPrice.Text = "";
            txt_qty.Text = "";
            btn_print.Enabled = false;
            btn_printWarehouse.Enabled = false;
            btn_saveMemo.Enabled = false;
            NewPo = true;
            POPrepareNumber = "NewPO";
            POPNumber = "NewPO";
        }

        private void btn_updatePO_Click(object sender, EventArgs e)
        {
            if (cbo_location.Text == "")
            {
                MessageBox.Show("Select Receiving Site.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (txt_poNumber.Text == "")
            {
                MessageBox.Show("Select PO Number.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Proceed with this P/O update process?", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //get po number
                String PONumber = txt_poNumber.Text.Trim();
                //delete po details and then add new details.
                connPO.sp_PO_DeleteDetail(PONumber);
                String ReceivingSite;
                if (cbo_location.Text == "BCS")
                {
                    ReceivingSite = "BCS";
                }
                else if (cbo_location.Text == "WH2")
                {
                    ReceivingSite = "WH2";
                }
                else
                {
                    ReceivingSite = "IFN";
                }
                String PORDERNumber = PONumber;
                String Supplier = cbo_supplierID.Text.Trim();
                String Memo = txt_memo.Text.Trim();
                String ShipVia = cbo_shipVia.Text.Trim();
                String WHMemo = txt_WHMemo.Text.Trim();
                connPO.sp_PO_UPDATE(PONumber, Memo, WHMemo, ReceivingSite, Supplier, ShipVia);
                
                for (int i = 0; i < grid_detail.Rows.Count; i++)
                {
                    String ProductBCS = grid_detail.Rows[i].Cells["Product (BCS)"].Value.ToString();
                    String ProductSupplier = grid_detail.Rows[i].Cells["Product (Supplier)"].Value.ToString();
                    Decimal OrderQty = Convert.ToDecimal(grid_detail.Rows[i].Cells["Order Qty."].Value.ToString());
                    Decimal STKQty = Convert.ToDecimal(grid_detail.Rows[i].Cells["STK qty."].Value.ToString());
                    String Description = grid_detail.Rows[i].Cells["Description"].Value.ToString();
                    String PackSize = grid_detail.Rows[i].Cells["Pack Size"].Value.ToString();
                    Decimal GrossPrice = Convert.ToDecimal(grid_detail.Rows[i].Cells["Gross Price"].Value.ToString());
                    Decimal EDLP = Convert.ToDecimal(grid_detail.Rows[i].Cells["EDLP"].Value.ToString());
                    Decimal EDLPP = Convert.ToDecimal(grid_detail.Rows[i].Cells["EDLP (P)"].Value.ToString());
                    Decimal TermPromo = Convert.ToDecimal(grid_detail.Rows[i].Cells["Term Promo"].Value.ToString());
                    Decimal TermPromoP = Convert.ToDecimal(grid_detail.Rows[i].Cells["Term Promo (P)"].Value.ToString());
                    Decimal NetPrice = Convert.ToDecimal(grid_detail.Rows[i].Cells["Net Price"].Value.ToString());
                    Decimal OrderAmount = Convert.ToDecimal(grid_detail.Rows[i].Cells["Order Amount"].Value.ToString());
                    String Unit = grid_detail.Rows[i].Cells["Unit"].Value.ToString();
                    DateTime ExpectedRcptDate = Convert.ToDateTime(grid_detail.Rows[i].Cells["Expected rcpt. Date"].Value.ToString());
                    String BilledBySupplier = grid_detail.Rows[i].Cells["Billed-by Supplier"].Value.ToString();
                    int PODetailKey = Convert.ToInt32(grid_detail.Rows[i].Cells["PODetailKey"].Value.ToString());
                    
                    Entities.PORDER pORDER = new Entities.PORDER();

                    pORDER.PORDERNumber = PORDERNumber;
                    pORDER.ReceivingSite = ReceivingSite;
                    pORDER.Supplier = Supplier;
                    pORDER.Memo = Memo;
                    pORDER.ProductBCS = ProductBCS;
                    pORDER.ProductSupplier = ProductSupplier;
                    pORDER.OrderQty = OrderQty;
                    pORDER.STKQty = STKQty;
                    pORDER.Description = Description;
                    pORDER.PackSize = PackSize;
                    pORDER.GrossPrice = GrossPrice;
                    pORDER.EDLP = EDLP;
                    pORDER.EDLPP = EDLPP;
                    pORDER.TermPromo = TermPromo;
                    pORDER.TermPromoP = TermPromoP;
                    pORDER.NetPrice = NetPrice;
                    pORDER.OrderAmount = OrderAmount;
                    pORDER.Unit = Unit;
                    pORDER.ExpectedRcptDate = ExpectedRcptDate;
                    pORDER.BilledBySupplier = BilledBySupplier;
                    pORDER.Line = PODetailKey;
                    pORDER.Location = "";

                    connPO.sp_INSERT_PORDERD(pORDER, PONumber);
                }
                String SearchPONumber = txt_PSOrderID.Text.Trim();
                String SearchRECNumber = txt_PSRECID.Text.Trim();
                String SearchSite = cbo_PSSite.Text.Trim();
                String SearchSupplier = txt_PSSupplier.Text.Trim();
                String SearchMemo = txt_PSMemo.Text.Trim();
                String SearchPOPNumber = txt_PPSOrderID.Text.Trim();
                String SearchPOPSupplier = txt_PPSSupplier.Text.Trim();
                String SearchPOPMemo = txt_PPSMemo.Text.Trim();
                DateTime FromDate = dateTimePickerFrom.Value.Date;
                DateTime ToDate = dateTimePickerTo.Value.Date;
                connPO.sp_PO_HEADER(grid_po, FromDate, ToDate, SearchPONumber, SearchRECNumber, SearchSite, SearchSupplier, SearchMemo);
                
                btn_create.Enabled = false;
                grid_detail.DataSource = null;
                cbo_supplierID.Text = "";
                txt_memo.Text = "";
                txt_WHMemo.Text = "";
                txt_totalAmount.Text = "";

                MessageBox.Show("P/O " + PONumber + " has been update successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void grid_poPrepare_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0) // Delete button
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this PO prepare from the list?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    connPO.sp_POPrepare_VOID(POPNumber);
                    DataTable dt = this.grid_poPrepare.DataSource as DataTable;
                    DataRow dr = dt.NewRow();
                    dt.Rows.RemoveAt(e.RowIndex);

                    String SearchPOPNumber = txt_PPSOrderID.Text.Trim();
                    String SearchPOPSupplier = txt_PPSSupplier.Text.Trim();
                    String SearchPOPMemo = txt_PPSMemo.Text.Trim();
                    DateTime FromDate = dateTimePickerFrom.Value.Date;
                    DateTime ToDate = dateTimePickerTo.Value.Date;
                    connPO.sp_POPrepareVoid_HEADER(grid_poPrepareVoid, FromDate, ToDate);
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
        }

        private void grid_po_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_brand.Visible = false;
                lbl_brand.Visible = false;
                txt_leadtime.Visible = false;
                lbl_leadtime.Visible = false;
                grid_poPrepare.ClearSelection();
                btn_create.Enabled = false;
                btn_print.Enabled = true;
                btn_printWarehouse.Enabled = true;
                btn_saveMemo.Enabled = true;
                btn_updatePO.Enabled = true;

                cbo_supplierID.Text = "";
                txt_memo.Text = "";
                txt_WHMemo.Text = "";
                txt_poNumber.Text = "";
                cbo_location.Text = "";
                cbo_term.Text = "";
                cbo_shipVia.Text = "";
                txt_billAddress1.Text = "";
                txt_billAddress2.Text = "";
                txt_billCity.Text = "";
                txt_billState.Text = "";
                txt_billZip.Text = "";
                txt_billTel.Text = "";
                txt_billFax.Text = "";

                String PORDERNumber = grid_po.Rows[e.RowIndex].Cells["PO No."].Value.ToString();
                String PRECEIPTNumber = grid_po.Rows[e.RowIndex].Cells["Receipt No."].Value.ToString();
                connPO.sp_PO_DETAIL(grid_detail, PORDERNumber);
                String Memo = grid_po.Rows[e.RowIndex].Cells["Memo"].Value.ToString();
                String WHMemo = grid_po.Rows[e.RowIndex].Cells["WHMemo"].Value.ToString();
                DateTime POrderDate = Convert.ToDateTime(grid_po.Rows[e.RowIndex].Cells["PO Date"].Value.ToString());
                String Supplier = grid_po.Rows[e.RowIndex].Cells["Supplier"].Value.ToString();
                String OrderSite = grid_po.Rows[e.RowIndex].Cells["Order Site"].Value.ToString();

                if (grid_po.Rows[e.RowIndex].Cells["Delivery Date"].Value.ToString() == "")
                {
                    dateTimePicker_ETA.Visible = true;
                }
                else
                {
                    DateTime ExpectedRcptDate = Convert.ToDateTime(grid_po.Rows[e.RowIndex].Cells["Delivery Date"].Value.ToString());
                    dateTimePicker_ETA.Value = ExpectedRcptDate;
                    dateTimePicker_ETA.Visible = true;
                }

                if (PRECEIPTNumber != "")
                {
                    btn_updatePO.Enabled = false;
                }
                else
                {
                    btn_updatePO.Enabled = true;
                }

                cbo_supplierID.Text = Supplier;
                txt_memo.Text = Memo;
                txt_WHMemo.Text = WHMemo;
                dateTimePicker1.Value = POrderDate;
                txt_poNumber.Text = PORDERNumber;
                cbo_location.Text = OrderSite;
                grid_detail.ClearSelection();
                String Term = connPO.getPaymentTerm2(PORDERNumber);
                cbo_term.Text = Term;
                String ShipVia = connPO.sp_GET_ShipVia(cbo_supplierID.Text.Trim(), PORDERNumber);
                cbo_shipVia.Text = ShipVia;
                Address address = connPO.sp_GET_SupplierAddress(cbo_supplierID.Text.Trim());
                txt_billAddress1.Text = address.Address1;
                txt_billAddress2.Text = address.Address2;
                txt_billCity.Text = address.City;
                txt_billState.Text = address.State;
                txt_billZip.Text = address.Zip;
                txt_billTel.Text = address.Tel;
                txt_billFax.Text = address.Fax;
            }
            catch(Exception ex)
            {
            }
        }
        
        private void SearchPO()
        {
            String SearchPONumber = txt_PSOrderID.Text.Trim();
            String SearchRECNumber = txt_PSRECID.Text.Trim();
            String SearchSite = cbo_PSSite.Text.Trim();
            String SearchSupplier = txt_PSSupplier.Text.Trim();
            String SearchMemo = txt_PSMemo.Text.Trim();
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            connPO.sp_PO_HEADER(grid_po, FromDate, ToDate, SearchPONumber, SearchRECNumber, SearchSite, SearchSupplier, SearchMemo);
        }

        private void txt_PSOrderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SearchPO();
            }
        }

        private void txt_PSRECID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SearchPO();
            }
        }

        private void cbo_PSSite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (POprepare == false)
            {
                grid_poPrepare_Init();
                POprepare = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SearchPOP();
            }
        }

        private void txt_PSSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SearchPO();
            }
        }

        private void txt_PSMemo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SearchPO();
            }
        }

        private void SearchPOP()
        {
            String SearchPOPNumber = txt_PPSOrderID.Text.Trim();
            String SearchPOPSupplier = txt_PPSSupplier.Text.Trim();
            String SearchPOPMemo = txt_PPSMemo.Text.Trim();
            String SearchBrand = txtBox_Brand.Text.Trim();
            connPO.sp_POPrepare_HEADER3(grid_poPrepare, SearchPOPNumber, SearchPOPSupplier, SearchBrand, SearchPOPMemo);
        }

        private void txt_PPSOrderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (POprepare == false)
            {
                grid_poPrepare_Init();
                POprepare = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SearchPOP();
            }
        }

        private void txt_PPSMemo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (POprepare == false)
            {
                grid_poPrepare_Init();
                POprepare = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SearchPOP();
            }
        }

        private void btn_refreshPOPrepare_Click(object sender, EventArgs e)
        {
            if(POprepare == false)
            {
                grid_poPrepare_Init();
                POprepare = true;
            }
            SearchPOP();
        }

        private void checkBox_ExpectedDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ExpectedDate.Checked == true && checkBox_ConfirmedDate.Checked == false)
            {
                dateTimePicker_ETA.Enabled = true;
            }
            else if (checkBox_ExpectedDate.Checked == true && checkBox_ConfirmedDate.Checked == true)
            {
                MessageBox.Show("A PO cannot simultaneously hold an EXPECTED and a CONFIRMED date. Please choose only one.\n\nIf you wish to make modifications to a date, first uncheck any checkboxes that may have been filled.", "Check yourself.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                checkBox_ExpectedDate.Checked = false;
                checkBox_ConfirmedDate.Checked = true;
            }
        }

        private void checkBox_ConfirmedDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ConfirmedDate.Checked == true && checkBox_ExpectedDate.Checked == false)
            {
                dateTimePicker_ETA.Enabled = true;
            }
            else if (checkBox_ExpectedDate.Checked == true && checkBox_ConfirmedDate.Checked == true)
            {
                MessageBox.Show("A PO cannot simultaneously hold an EXPECTED and a CONFIRMED date. Please choose only one.\n\nIf you wish to make modifications to a date, first uncheck any checkboxes that may have been filled.", "Check yourself.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                checkBox_ExpectedDate.Checked = true;
                checkBox_ConfirmedDate.Checked = false;
            }
        }

        private void btn_updateDates_Click(object sender, EventArgs e)
        {
            try
            {
                String PONumber = txt_poNumber.Text.Trim();
                if (checkBox_ExpectedDate.Checked == true && checkBox_ConfirmedDate.Checked == false)
                {
                    int RcptDateFlag = 1;
                    DateTime POExpectedRcptDate = dateTimePicker_ETA.Value.Date;
                    connPO.sp_PO_ETA_DATE_UPDATE(PONumber, POExpectedRcptDate, RcptDateFlag);
                    MessageBox.Show("Date for " + PONumber + " updated: ETA");
                }
                else if (checkBox_ConfirmedDate.Checked == true && checkBox_ExpectedDate.Checked == false)
                {
                    int RcptDateFlag = 2;
                    DateTime POConfirmedRcptDate = dateTimePicker_ETA.Value.Date;
                    connPO.sp_PO_CONFIRMED_DATE_UPDATE(PONumber, POConfirmedRcptDate, RcptDateFlag);
                    MessageBox.Show("Date for " + PONumber + " updated: CONFIRMED");
                }
                String SearchPONumber = txt_PSOrderID.Text.Trim();
                String SearchRECNumber = txt_PSRECID.Text.Trim();
                String SearchSite = cbo_PSSite.Text.Trim();
                String SearchSupplier = txt_PSSupplier.Text.Trim();
                String SearchMemo = txt_PSMemo.Text.Trim();
                String SearchPOPNumber = txt_PPSOrderID.Text.Trim();
                String SearchPOPSupplier = txt_PPSSupplier.Text.Trim();
                String SearchPOPMemo = txt_PPSMemo.Text.Trim();
                DateTime FromDate = dateTimePickerFrom.Value.Date;
                DateTime ToDate = dateTimePickerTo.Value.Date;
                connPO.sp_PO_HEADER(grid_po, FromDate, ToDate, SearchPONumber, SearchRECNumber, SearchSite, SearchSupplier, SearchMemo);
            } catch {
                MessageBox.Show(e.ToString());
            }
        }

        private void txtBox_Brand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (POprepare == false)
            {
                grid_poPrepare_Init();
                POprepare = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SearchPOP();
            }
        }

        private void btn_refreshVoid_Click(object sender, EventArgs e)
        {
            if (POprepareVoid == false)
            {
                grid_poPrepareVoid_Init();
                POprepareVoid = true;
            }
            
            DateTime FromDate = dateTimePickerVoidFrom.Value.Date;
            DateTime ToDate = dateTimePickerVoidTo.Value.Date;
            connPO.sp_POPrepareVoid_HEADER(grid_poPrepareVoid, FromDate, ToDate);
        }

        private void cbo_product_Leave(object sender, EventArgs e)
        {
            setProduct();
        }
    }
}                               
