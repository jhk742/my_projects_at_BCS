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
    public partial class POManagement_Detail : Form
    {
        public POManagement_Detail()
        {
            InitializeComponent();
            Combobox_SetUp();
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-7);
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            string Supplier = cbx_Supplier.Text.Trim();
            string Brand = cbx_Brand.Text.Trim();
            string Product = cbx_Product.Text.Trim();
            string ConfirmedCheck = cbx_Confirmed.Text.Trim();
            string ReceivedCheck = cbx_Received.Text.Trim();
            rad_PoDate.Checked = true;

            grid_PoManagment_detail_Init();


            //connPO.sp_POManagement_detail(grid_PoManagement_detail, FromDate, ToDate, Supplier, Brand, Product, ReceivedCheck, ConfirmedCheck, RecFromDate, RecToDate);
        }
        private void grid_PoManagment_detail_Init()
        {
            grid_PoManagement_detail.AutoGenerateColumns = false;
            grid_PoManagement_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_PoManagement_detail.ColumnCount = 20;

            grid_PoManagement_detail.Columns[0].Name = "PO Number";
            grid_PoManagement_detail.Columns[0].ReadOnly = true;
            grid_PoManagement_detail.Columns[0].Width = 70;
            grid_PoManagement_detail.Columns[0].MinimumWidth = 70;
            grid_PoManagement_detail.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[0].DataPropertyName = "PONumber";

            grid_PoManagement_detail.Columns[1].Name = "PODate";
            grid_PoManagement_detail.Columns[1].ReadOnly = true;
            grid_PoManagement_detail.Columns[1].Width = 70;
            grid_PoManagement_detail.Columns[1].MinimumWidth = 70;
            grid_PoManagement_detail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[1].DataPropertyName = "PODate";

            grid_PoManagement_detail.Columns[2].Name = "Supplier";
            grid_PoManagement_detail.Columns[2].ReadOnly = true;
            grid_PoManagement_detail.Columns[2].Width = 120;
            grid_PoManagement_detail.Columns[2].MinimumWidth = 120;
            grid_PoManagement_detail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[2].DataPropertyName = "Supplier";

            grid_PoManagement_detail.Columns[3].Name = "Brand";
            grid_PoManagement_detail.Columns[3].ReadOnly = true;
            grid_PoManagement_detail.Columns[3].Width = 120;
            grid_PoManagement_detail.Columns[3].MinimumWidth = 120;
            grid_PoManagement_detail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[3].DataPropertyName = "Brand";

            grid_PoManagement_detail.Columns[4].Name = "ProductID";
            grid_PoManagement_detail.Columns[4].ReadOnly = true;
            grid_PoManagement_detail.Columns[4].Width = 80;
            grid_PoManagement_detail.Columns[4].MinimumWidth = 80;
            grid_PoManagement_detail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[4].DataPropertyName = "ProductID";

            grid_PoManagement_detail.Columns[5].Name = "Product Description";
            grid_PoManagement_detail.Columns[5].ReadOnly = true;
            grid_PoManagement_detail.Columns[5].Width = 120;
            grid_PoManagement_detail.Columns[5].MinimumWidth = 120;
            grid_PoManagement_detail.Columns[5].DataPropertyName = "ProductDesc";

            grid_PoManagement_detail.Columns[6].Name = "Pack Size";
            grid_PoManagement_detail.Columns[6].ReadOnly = true;
            grid_PoManagement_detail.Columns[6].Width = 70;
            grid_PoManagement_detail.Columns[6].MinimumWidth = 70;
            grid_PoManagement_detail.Columns[6].DataPropertyName = "PackSize";

            grid_PoManagement_detail.Columns[7].Name = "SITE";
            grid_PoManagement_detail.Columns[7].ReadOnly = true;
            grid_PoManagement_detail.Columns[7].Width = 30;
            grid_PoManagement_detail.Columns[7].MinimumWidth = 30;
            grid_PoManagement_detail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[7].DataPropertyName = "SITE";

            grid_PoManagement_detail.Columns[8].Name = "Confirmed";
            grid_PoManagement_detail.Columns[8].ReadOnly = true;
            grid_PoManagement_detail.Columns[8].Width = 60;
            grid_PoManagement_detail.Columns[8].MinimumWidth = 60;
            grid_PoManagement_detail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[8].DataPropertyName = "Confirmed";
        
            grid_PoManagement_detail.Columns[9].Name = "ExpectedDate";
            grid_PoManagement_detail.Columns[9].ReadOnly = true;
            grid_PoManagement_detail.Columns[9].Width = 70;
            grid_PoManagement_detail.Columns[9].MinimumWidth = 70;
            //grid_PoManagement.Columns[5].DefaultCellStyle.Format = "N2";
            grid_PoManagement_detail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[9].DataPropertyName = "ExpectedDate";

            grid_PoManagement_detail.Columns[10].Name = "Received";
            grid_PoManagement_detail.Columns[10].ReadOnly = true;
            grid_PoManagement_detail.Columns[10].Width = 60;
            grid_PoManagement_detail.Columns[10].MinimumWidth = 60;
            grid_PoManagement_detail.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[10].DataPropertyName = "Received";

            grid_PoManagement_detail.Columns[11].Name = "RECNumber";
            grid_PoManagement_detail.Columns[11].ReadOnly = true;
            grid_PoManagement_detail.Columns[11].Width = 70;
            grid_PoManagement_detail.Columns[11].MinimumWidth = 70;
            grid_PoManagement_detail.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[11].DataPropertyName = "RECNumber";

            grid_PoManagement_detail.Columns[12].Name = "RECDate";
            grid_PoManagement_detail.Columns[12].ReadOnly = true;
            grid_PoManagement_detail.Columns[12].Width = 70;
            grid_PoManagement_detail.Columns[12].MinimumWidth = 70;
            grid_PoManagement_detail.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[12].DataPropertyName = "RECDate";

            grid_PoManagement_detail.Columns[13].Name = "POQty";
            grid_PoManagement_detail.Columns[13].ReadOnly = true;
            grid_PoManagement_detail.Columns[13].Width = 60;
            grid_PoManagement_detail.Columns[13].MinimumWidth = 60;
            grid_PoManagement_detail.Columns[13].DefaultCellStyle.Format = "N2";
            grid_PoManagement_detail.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement_detail.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement_detail.Columns[13].DataPropertyName = "POQty";

            grid_PoManagement_detail.Columns[14].Name = "RECQty";
            grid_PoManagement_detail.Columns[14].ReadOnly = true;
            grid_PoManagement_detail.Columns[14].Width = 60;
            grid_PoManagement_detail.Columns[14].MinimumWidth = 60;
            grid_PoManagement_detail.Columns[14].DefaultCellStyle.Format = "N2";
            grid_PoManagement_detail.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement_detail.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement_detail.Columns[14].DataPropertyName = "RECQty";

            grid_PoManagement_detail.Columns[15].Name = "POAmount";
            grid_PoManagement_detail.Columns[15].ReadOnly = true;
            grid_PoManagement_detail.Columns[15].Width = 70;
            grid_PoManagement_detail.Columns[15].MinimumWidth = 70;
            grid_PoManagement_detail.Columns[15].DefaultCellStyle.Format = "N2";
            grid_PoManagement_detail.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement_detail.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement_detail.Columns[15].DataPropertyName = "POAmount";

            grid_PoManagement_detail.Columns[16].Name = "RECAmount";
            grid_PoManagement_detail.Columns[16].ReadOnly = true;
            grid_PoManagement_detail.Columns[16].Width = 70;
            grid_PoManagement_detail.Columns[16].MinimumWidth = 70;
            grid_PoManagement_detail.Columns[16].DefaultCellStyle.Format = "N2";
            grid_PoManagement_detail.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement_detail.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoManagement_detail.Columns[16].DataPropertyName = "RECAmount";

            grid_PoManagement_detail.Columns[17].Name = "POMemo";
            grid_PoManagement_detail.Columns[17].ReadOnly = true;
            grid_PoManagement_detail.Columns[17].Width = 150;
            grid_PoManagement_detail.Columns[17].MinimumWidth = 150;
            grid_PoManagement_detail.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[17].DataPropertyName = "POMemo";

            grid_PoManagement_detail.Columns[18].Name = "Update User";
            grid_PoManagement_detail.Columns[18].ReadOnly = true;
            grid_PoManagement_detail.Columns[18].Width = 50;
            grid_PoManagement_detail.Columns[18].MinimumWidth = 50;
            grid_PoManagement_detail.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[18].DataPropertyName = "UpdateUser";
        
            grid_PoManagement_detail.Columns[19].Name = "Update Date";
            grid_PoManagement_detail.Columns[19].ReadOnly = true;
            grid_PoManagement_detail.Columns[19].Width = 70;
            grid_PoManagement_detail.Columns[19].MinimumWidth = 70;
            grid_PoManagement_detail.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoManagement_detail.Columns[19].DataPropertyName = "UpdateDate";



            //grid font size custom
            grid_PoManagement_detail.RowTemplate.Height = 20;
            grid_PoManagement_detail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_PoManagement_detail.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_PoManagement_detail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            string Supplier = cbx_Supplier.Text.Trim();
            string Brand = cbx_Brand.Text.Trim();
            string Product = cbx_Product.Text.Trim();
            string ConfirmedCheck = cbx_Confirmed.Text.Trim();
            string ReceivedCheck = cbx_Received.Text.Trim();
            String Type = "P";
            if (rad_PoDate.Checked) Type = "P";
            else if (rad_RecDate.Checked) Type = "R";

            connPO.sp_POManagement_detail(grid_PoManagement_detail, FromDate, ToDate, Supplier, Brand, Product, ReceivedCheck, ConfirmedCheck, Type);
        }
        private void Combobox_SetUp()
        {
            cbx_Confirmed.Items.Add("");
            cbx_Confirmed.Items.Add("Confirmed");
            cbx_Confirmed.Items.Add("Unconfirmed");
            cbx_Received.Items.Add("");
            cbx_Received.Items.Add("Received");
            cbx_Received.Items.Add("Not Received");
            connPO.cbox_getVendorID(cbx_Supplier);
            connPO.cbox_getBrnad(cbx_Brand);
            connSalesOrder.cbo_itemID(cbx_Product);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            string Supplier = cbx_Supplier.Text.Trim();
            string Brand = cbx_Brand.Text.Trim();
            string Product = cbx_Product.Text.Trim();
            string ConfirmedCheck = cbx_Confirmed.Text.Trim();
            string ReceivedCheck = cbx_Received.Text.Trim();
            String Type = "P";
            if (rad_PoDate.Checked) Type = "P";
            else if (rad_RecDate.Checked) Type = "R";
            Reports.Rpt_POManagement_Detail pOManagement_detail = new Reports.Rpt_POManagement_Detail(FromDate, ToDate, Supplier,Brand,Product, ReceivedCheck, ConfirmedCheck, Type);
            //salesReport.MdiParent = this.MdiParent;
            pOManagement_detail.Show();
        }

    }

}
