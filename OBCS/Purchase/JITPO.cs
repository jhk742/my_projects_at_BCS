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
    public partial class JITPO : Form
    {
        public JITPO()
        {
            InitializeComponent();

            dateTimePicker_fromDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_fromDate.CustomFormat = "MM/yyyy";

            dateTimePicker_toDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_toDate.CustomFormat = "MM/yyyy";

            grid_JIT_Init();

            cbo_brand.Items.Clear();
            connPO.sp_GET_Brand(cbo_brand);
            //아이템 가져오기
            cbo_productID.Items.Clear();
            connSalesOrder.cbo_itemID(cbo_productID);
        }

        private void grid_JIT_Init()
        {
            grid_JIT.AutoGenerateColumns = false;
            grid_JIT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_JIT.ColumnCount = 17;

            grid_JIT.Columns[0].Name = "BrandName";
            grid_JIT.Columns[0].ReadOnly = true;
            grid_JIT.Columns[0].Visible = true;
            grid_JIT.Columns[0].Width = 100;
            grid_JIT.Columns[0].MinimumWidth = 100;
            grid_JIT.Columns[0].DataPropertyName = "BrandName";

            grid_JIT.Columns[1].Name = "Product ID";
            grid_JIT.Columns[1].ReadOnly = true;
            grid_JIT.Columns[1].Width = 90;
            grid_JIT.Columns[1].MinimumWidth = 90;
            grid_JIT.Columns[1].DataPropertyName = "ITMREF_0";

            grid_JIT.Columns[2].Name = "Product Description";
            grid_JIT.Columns[2].ReadOnly = true;
            grid_JIT.Columns[2].Width = 300;
            grid_JIT.Columns[2].MinimumWidth = 200;
            grid_JIT.Columns[2].DataPropertyName = "ProductDesc";

            grid_JIT.Columns[3].Name = "Last Receiving Number";
            grid_JIT.Columns[3].ReadOnly = true;
            grid_JIT.Columns[3].Width = 80;
            grid_JIT.Columns[3].MinimumWidth = 80;
            grid_JIT.Columns[3].DefaultCellStyle.Format = "N2";
            grid_JIT.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_JIT.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_JIT.Columns[3].DataPropertyName = "LASTRECNO";

            grid_JIT.Columns[4].Name = "Last Receiving Date";
            grid_JIT.Columns[4].ReadOnly = true;
            grid_JIT.Columns[4].Width = 80;
            grid_JIT.Columns[4].MinimumWidth = 80;
            grid_JIT.Columns[4].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_JIT.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_JIT.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_JIT.Columns[4].DataPropertyName = "LASTRECDATE";

            grid_JIT.Columns[5].Name = "Last Received Qty.";
            grid_JIT.Columns[5].ReadOnly = true;
            grid_JIT.Columns[5].Width = 50;
            grid_JIT.Columns[5].MinimumWidth = 50;
            grid_JIT.Columns[5].DefaultCellStyle.Format = "N2";
            grid_JIT.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[5].DataPropertyName = "LASTRECQTY";

            grid_JIT.Columns[6].Name = "NJ Physical Qty.";
            grid_JIT.Columns[6].ReadOnly = true;
            grid_JIT.Columns[6].MinimumWidth = 50;
            grid_JIT.Columns[6].MinimumWidth = 50;
            grid_JIT.Columns[6].DefaultCellStyle.Format = "N2";
            grid_JIT.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[6].DataPropertyName = "PHYQTYWH";

            grid_JIT.Columns[7].Name = "NY Physical Qty.";
            grid_JIT.Columns[7].ReadOnly = true;
            grid_JIT.Columns[7].MinimumWidth = 50;
            grid_JIT.Columns[7].MinimumWidth = 50;
            grid_JIT.Columns[7].DefaultCellStyle.Format = "N2";
            grid_JIT.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[7].DataPropertyName = "PHYQTY";

            grid_JIT.Columns[8].Name = "Global Allocation Qty.";
            grid_JIT.Columns[8].ReadOnly = true;
            grid_JIT.Columns[8].MinimumWidth = 50;
            grid_JIT.Columns[8].MinimumWidth = 50;
            grid_JIT.Columns[8].DefaultCellStyle.Format = "N2";
            grid_JIT.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[8].DataPropertyName = "GLOALL";

            grid_JIT.Columns[9].Name = "Detailed Allocation Qty.";
            grid_JIT.Columns[9].ReadOnly = true;
            grid_JIT.Columns[9].MinimumWidth = 50;
            grid_JIT.Columns[9].MinimumWidth = 50;
            grid_JIT.Columns[9].DefaultCellStyle.Format = "N2";
            grid_JIT.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[9].DataPropertyName = "DETAILED";

            grid_JIT.Columns[10].Name = "NY Onhand Qty.";
            grid_JIT.Columns[10].ReadOnly = true;
            grid_JIT.Columns[10].MinimumWidth = 50;
            grid_JIT.Columns[10].MinimumWidth = 50;
            grid_JIT.Columns[10].DefaultCellStyle.Format = "N2";
            grid_JIT.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[10].DataPropertyName = "NYONHAND";

            grid_JIT.Columns[11].Name = "Daily Sales";
            grid_JIT.Columns[11].ReadOnly = true;
            grid_JIT.Columns[11].MinimumWidth = 50;
            grid_JIT.Columns[11].MinimumWidth = 50;
            grid_JIT.Columns[11].DefaultCellStyle.Format = "N2";
            grid_JIT.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[11].DataPropertyName = "DAILYSALES";

            grid_JIT.Columns[12].Name = "Lead Time";
            grid_JIT.Columns[12].ReadOnly = true;
            grid_JIT.Columns[12].MinimumWidth = 50;
            grid_JIT.Columns[12].MinimumWidth = 50;
            grid_JIT.Columns[12].DefaultCellStyle.Format = "N2";
            grid_JIT.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[12].DataPropertyName = "LEADTIME";

            grid_JIT.Columns[13].Name = "Safety Stock";
            grid_JIT.Columns[13].ReadOnly = true;
            grid_JIT.Columns[13].MinimumWidth = 50;
            grid_JIT.Columns[13].MinimumWidth = 50;
            grid_JIT.Columns[13].DefaultCellStyle.Format = "N2";
            grid_JIT.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[13].DataPropertyName = "SAFETYSTOCK";

            grid_JIT.Columns[14].Name = "Surplus Inventory";
            grid_JIT.Columns[14].ReadOnly = true;
            grid_JIT.Columns[14].MinimumWidth = 40;
            grid_JIT.Columns[14].MinimumWidth = 40;
            grid_JIT.Columns[14].DefaultCellStyle.Format = "N2";
            grid_JIT.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[14].DataPropertyName = "SURPLUSINVENTORY";

            grid_JIT.Columns[15].Name = "JIT PO Date";
            grid_JIT.Columns[15].ReadOnly = true;
            grid_JIT.Columns[15].MinimumWidth = 40;
            grid_JIT.Columns[15].MinimumWidth = 40;
            grid_JIT.Columns[15].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_JIT.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_JIT.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_JIT.Columns[15].DataPropertyName = "JITDate";

            grid_JIT.Columns[16].Name = "On Order Qty.";
            grid_JIT.Columns[16].ReadOnly = true;
            grid_JIT.Columns[16].MinimumWidth = 50;
            grid_JIT.Columns[16].MinimumWidth = 50;
            grid_JIT.Columns[16].DefaultCellStyle.Format = "N2";
            grid_JIT.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_JIT.Columns[16].DataPropertyName = "OnOrder";



            //grid font size custom
            grid_JIT.RowTemplate.Height = 20;
            grid_JIT.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_JIT.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_JIT.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            String BrandName = cbo_brand.Text.Trim();
            String ProductID = cbo_productID.Text.Trim();

            DateTime FromDate = dateTimePicker_fromDate.Value.Date;
            FromDate = new DateTime(FromDate.Year, FromDate.Month, 1);
            DateTime ToDate = dateTimePicker_toDate.Value.Date;
            ToDate = new DateTime(ToDate.Year, ToDate.Month+1, 1);
            
            connSalesOrder.sp_PO_JIT(grid_JIT, BrandName, ProductID, FromDate, ToDate);
        }
    }
}
