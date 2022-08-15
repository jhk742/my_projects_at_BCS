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
    public partial class POManagement : Form
    {
        public POManagement()
        {
            InitializeComponent();
            Combobox_SetUp();
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-7);
            RecdateTimePickerFrom.Value = DateTime.Today.AddDays(-7);
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            string Supplier = cbx_Supplier.Text.Trim();
            string ConfirmedCheck = cbx_Confirmed.Text.Trim();
            string ReceivedCheck = cbx_Received.Text.Trim();
            string Type = "P";
            cbx_Brand.Enabled = false;
            cbx_Supplier.Enabled = false;
            rad_PoDate.Checked = true;
            //DateTime RecFromDate = RecdateTimePickerFrom.Value.Date;
            //DateTime RecToDate = RecdateTimePickerTo.Value.Date;

            grid_PoManagment_Init();
 
            //connPO.sp_POManagement(grid_PoManagement, FromDate, ToDate, Supplier, ReceivedCheck, ConfirmedCheck, Type);
        } 
        private void grid_PoManagment_Init()
        {
            grid_PoManagement.AutoGenerateColumns = false;
            grid_PoManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_PoManagement.ColumnCount = 16;

            grid_PoManagement.Columns[0].Name = "PO Number";
            grid_PoManagement.Columns[0].ReadOnly = true;
            grid_PoManagement.Columns[0].Width = 50;
            grid_PoManagement.Columns[0].MinimumWidth = 50;
            grid_PoManagement.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[0].DataPropertyName = "PONumber";

            grid_PoManagement.Columns[1].Name = "PODate";
            grid_PoManagement.Columns[1].ReadOnly = true;
            grid_PoManagement.Columns[1].Width = 50;
            grid_PoManagement.Columns[1].MinimumWidth = 50;
            grid_PoManagement.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[1].DataPropertyName = "PODate";

            grid_PoManagement.Columns[2].Name = "Supplier";
            grid_PoManagement.Columns[2].ReadOnly = true;
            grid_PoManagement.Columns[2].Width = 120;
            grid_PoManagement.Columns[2].MinimumWidth = 120;
            grid_PoManagement.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[2].DataPropertyName = "Supplier";

            grid_PoManagement.Columns[3].Name = "SITE";
            grid_PoManagement.Columns[3].ReadOnly = true;
            grid_PoManagement.Columns[3].Width = 30;
            grid_PoManagement.Columns[3].MinimumWidth = 30;
            grid_PoManagement.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[3].DataPropertyName = "SITE";

            grid_PoManagement.Columns[4].Name = "Confirmed";
            grid_PoManagement.Columns[4].ReadOnly = true;
            grid_PoManagement.Columns[4].Width = 60;
            grid_PoManagement.Columns[4].MinimumWidth = 60;
            grid_PoManagement.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[4].DataPropertyName = "Confirmed";

            grid_PoManagement.Columns[5].Name = "ExpectedDate";
            grid_PoManagement.Columns[5].ReadOnly = true;
            grid_PoManagement.Columns[5].Width = 70;
            grid_PoManagement.Columns[5].MinimumWidth = 70;
            //grid_PoManagement.Columns[5].DefaultCellStyle.Format = "N2";
            grid_PoManagement.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[5].DataPropertyName = "ExpectedDate";

            grid_PoManagement.Columns[6].Name = "Received";
            grid_PoManagement.Columns[6].ReadOnly = true;
            grid_PoManagement.Columns[6].Width = 60;
            grid_PoManagement.Columns[6].MinimumWidth = 60;
            grid_PoManagement.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[6].DataPropertyName = "Received";

            grid_PoManagement.Columns[7].Name = "RECNumber";
            grid_PoManagement.Columns[7].ReadOnly = true;
            grid_PoManagement.Columns[7].Width = 60;
            grid_PoManagement.Columns[7].MinimumWidth = 60;
            grid_PoManagement.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[7].DataPropertyName = "RECNumber";

            grid_PoManagement.Columns[8].Name = "RECDate";
            grid_PoManagement.Columns[8].ReadOnly = true;
            grid_PoManagement.Columns[8].Width = 50;
            grid_PoManagement.Columns[8].MinimumWidth = 50;
            grid_PoManagement.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[8].DataPropertyName = "RECDate";

            grid_PoManagement.Columns[9].Name = "POQty";
            grid_PoManagement.Columns[9].ReadOnly = true;
            grid_PoManagement.Columns[9].Width = 70;
            grid_PoManagement.Columns[9].MinimumWidth = 70;
            grid_PoManagement.Columns[9].DefaultCellStyle.Format = "N2";
            grid_PoManagement.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement.Columns[9].DataPropertyName = "POQty";

            grid_PoManagement.Columns[10].Name = "RECQty";
            grid_PoManagement.Columns[10].ReadOnly = true;
            grid_PoManagement.Columns[10].Width = 70;
            grid_PoManagement.Columns[10].MinimumWidth = 70;
            grid_PoManagement.Columns[10].DefaultCellStyle.Format = "N2";
            grid_PoManagement.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement.Columns[10].DataPropertyName = "RECQty";

            grid_PoManagement.Columns[11].Name = "POAmount";
            grid_PoManagement.Columns[11].ReadOnly = true;
            grid_PoManagement.Columns[11].Width = 80;
            grid_PoManagement.Columns[11].MinimumWidth = 80;
            grid_PoManagement.Columns[11].DefaultCellStyle.Format = "N2";
            grid_PoManagement.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement.Columns[11].DataPropertyName = "POAmount";

            grid_PoManagement.Columns[12].Name = "RECAmount";
            grid_PoManagement.Columns[12].ReadOnly = true;
            grid_PoManagement.Columns[12].Width = 80;
            grid_PoManagement.Columns[12].MinimumWidth = 80;
            grid_PoManagement.Columns[12].DefaultCellStyle.Format = "N2";
            grid_PoManagement.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[12].DataPropertyName = "RECAmount";

            grid_PoManagement.Columns[13].Name = "POMemo";
            grid_PoManagement.Columns[13].ReadOnly = true;
            grid_PoManagement.Columns[13].Width = 150;
            grid_PoManagement.Columns[13].MinimumWidth = 150;
            grid_PoManagement.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[13].DataPropertyName = "POMemo";

            grid_PoManagement.Columns[14].Name = "Update User";
            grid_PoManagement.Columns[14].ReadOnly = true;
            grid_PoManagement.Columns[14].Width = 50;
            grid_PoManagement.Columns[14].MinimumWidth = 50;
            grid_PoManagement.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[14].DataPropertyName = "UpdateUser";

            grid_PoManagement.Columns[15].Name = "UpdateDate";
            grid_PoManagement.Columns[15].ReadOnly = true;
            grid_PoManagement.Columns[15].Width = 70;
            grid_PoManagement.Columns[15].MinimumWidth = 70;
            grid_PoManagement.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement.Columns[15].DataPropertyName = "UpdateDate";



            //grid font size custom
            grid_PoManagement.RowTemplate.Height = 20;
            grid_PoManagement.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_PoManagement.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_PoManagement.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            string Supplier = cbx_Supplier.Text.Trim();
            string ReceivedCheck = cbx_Received.Text.Trim();
            string ConfirmedCheck = cbx_Confirmed.Text.Trim();
            String Type = "P";
            if (rad_PoDate.Checked) Type = "P";
            else if (rad_RecDate.Checked) Type = "R";
            String Brand = cbx_Brand.Text.Trim();
            //MessageBox.Show(Type);
            connPO.sp_POManagement(grid_PoManagement, FromDate, ToDate, Supplier, ReceivedCheck, ConfirmedCheck, Type, Brand);
        }
        private void Combobox_SetUp()
        {
            cbx_Confirmed.Items.Add("");
            cbx_Confirmed.Items.Add("Confirmed");
            cbx_Confirmed.Items.Add("Unconfirmed");
            cbx_Received.Items.Add("");
            cbx_Received.Items.Add("Received");
            cbx_Received.Items.Add("Not Received");
            //connPO.cbox_getVendorID(cbx_Supplier);
            connPO.sp_GET_SUPPLIER(cbx_Supplier);
            connPO.cbox_Brand(cbx_Brand);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            string Supplier = cbx_Supplier.Text.Trim();
            string ReceivedCheck = cbx_Received.Text.Trim();
            string ConfirmedCheck = cbx_Confirmed.Text.Trim();
            String Brand = cbx_Brand.Text.Trim();
            String Type = "P";
            if (rad_PoDate.Checked) Type = "P";
            else if (rad_RecDate.Checked) Type = "R";

            Reports.Rpt_POManagement pOManagement = new Reports.Rpt_POManagement(FromDate, ToDate, Supplier, ReceivedCheck, ConfirmedCheck, Type, Brand);
            //salesReport.MdiParent = this.MdiParent;
            pOManagement.Show();
        }

        private void rad_Supplier_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_Brand.Checked)
            {
                cbx_Brand.Enabled = true;
                cbx_Supplier.Enabled = false;
                cbx_Supplier.Text = "";
            }
            else if (rad_Supplier.Checked)
            {
                cbx_Supplier.Enabled = true;
                cbx_Brand.Enabled = false;
                cbx_Brand.Text = "";
            }
        }
        private void total_in_Grid()
        {
            //decimal GrossSales = 0, Promotion = 0, Sales = 0, Credit = 0, ReturnAmount = 0,
            //      NetSales = 0, COGS = 0, PurchaseAllowance = 0, BillBack = 0;
            //decimal ProfitResult = 0, ProfitResultRatio = 0, PromoResultRatio = 0, CreditResultRatio = 0, ReturnResultRatio = 0;
            //for (int i = 0; i < grid_PoManagement.RowCount; i++)
            //{
            //    GrossSales += Convert.ToDecimal(grid_PoManagement.Rows[i].Cells[3].Value == DBNull.Value ? "0" : grid_PoManagement.Rows[i].Cells[3].Value);
            //    Promotion += Convert.ToDecimal(grid_PoManagement.Rows[i].Cells[4].Value == DBNull.Value ? "0" : grid_PoManagement.Rows[i].Cells[4].Value);
            //    Sales += Convert.ToDecimal(grid_PoManagement.Rows[i].Cells[6].Value == DBNull.Value ? "0" : grid_PoManagement.Rows[i].Cells[6].Value);
            //    Credit += Convert.ToDecimal(grid_PoManagement.Rows[i].Cells[7].Value == DBNull.Value ? "0" : grid_PoManagement.Rows[i].Cells[7].Value);
            //    ReturnAmount += Convert.ToDecimal(grid_PoManagement.Rows[i].Cells[9].Value == DBNull.Value ? "0" : grid_PoManagement.Rows[i].Cells[9].Value);
            //    NetSales += Convert.ToDecimal(grid_PoManagement.Rows[i].Cells[11].Value == DBNull.Value ? "0" : grid_PoManagement.Rows[i].Cells[11].Value);
            //    COGS += Convert.ToDecimal(grid_PoManagement.Rows[i].Cells[12].Value == DBNull.Value ? "0" : grid_PoManagement.Rows[i].Cells[12].Value);
            //    PurchaseAllowance = Convert.ToDecimal(grid_PoManagement.Rows[0].Cells[13].Value == DBNull.Value ? "0" : grid_PoManagement.Rows[0].Cells[13].Value);
            //    BillBack = Convert.ToDecimal(grid_PoManagement.Rows[0].Cells[14].Value == DBNull.Value ? "0" : grid_PoManagement.Rows[0].Cells[14].Value);
            //}
            //ProfitResult = NetSales - (COGS - PurchaseAllowance - BillBack);
            //PromoResultRatio = Promotion / GrossSales * 100;
            //CreditResultRatio = Credit / GrossSales * 100;
            //ReturnResultRatio = ReturnAmount / GrossSales * 100;
            //ProfitResultRatio = NetSales - (COGS - PurchaseAllowance - BillBack) / GrossSales * 100;

            //DataTable dataTable = (DataTable)grid_PoManagement.DataSource;
            //DataRow drToAdd = dataTable.NewRow();
            //drToAdd[0] = "TOTAL";
            //drToAdd[3] = GrossSales.ToString();
            //drToAdd[4] = Promotion.ToString();
            //drToAdd[5] = PromoResultRatio.ToString();
            //drToAdd[6] = Sales.ToString();
            //drToAdd[7] = Credit.ToString();
            //drToAdd[8] = CreditResultRatio.ToString();
            //drToAdd[9] = ReturnAmount.ToString();
            //drToAdd[10] = ReturnResultRatio.ToString();
            //drToAdd[11] = NetSales.ToString();
            //drToAdd[12] = COGS.ToString();
            //drToAdd[13] = PurchaseAllowance.ToString();
            //drToAdd[14] = BillBack.ToString();
            //drToAdd[15] = ProfitResult;
            //drToAdd[16] = ProfitResultRatio;

            //dataTable.Rows.Add(drToAdd);

            //dataTable.AcceptChanges();

            //this.grid_PoManagement.ClearSelection();
        }
    }
}
