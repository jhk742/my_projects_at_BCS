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
    public partial class STOJOU_History : Form
    {
        public STOJOU_History()
        {
            InitializeComponent();
            grid_STOJOU_Init();
            //connPO.cbo_Sto_Site(cbo_Site);
            cbo_Site.Items.Add("");
            cbo_Site.Items.Add("BCS");
            cbo_Site.Items.Add("WH2");
            //cbo_Site.Items.Add("IFN");

            cbo_Status.Items.Add("");
            cbo_Status.Items.Add("Assembly");
            cbo_Status.Items.Add("Customer delivery");
            cbo_Status.Items.Add("Disassembly");
            cbo_Status.Items.Add("Intersite transfer");
            cbo_Status.Items.Add("Manufacturing order");
            cbo_Status.Items.Add("Manufacturing receipt");
            cbo_Status.Items.Add("Miscellaneous issue");
            cbo_Status.Items.Add("Miscellaneous receipt");
            cbo_Status.Items.Add("Receipt return");
            cbo_Status.Items.Add("Shipment return");
            cbo_Status.Items.Add("Status change");
            cbo_Status.Items.Add("Subcontract delivery");
            cbo_Status.Items.Add("Subcontract receipt");
            cbo_Status.Items.Add("Supplier receipt");
            cbo_Status.Items.Add("Location Change");

            connSalesOrder.cbo_itemID(cbo_itemID);

        }
        private void grid_STOJOU_Init()
        {
            grid_STOJOU.AutoGenerateColumns = false;
            grid_STOJOU.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_STOJOU.ColumnCount = 15;

            grid_STOJOU.Columns[0].Name = "Site";
            grid_STOJOU.Columns[0].ReadOnly = true;
            grid_STOJOU.Columns[0].Width = 50;
            grid_STOJOU.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_STOJOU.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[0].DataPropertyName = "STOFCY_0";

            grid_STOJOU.Columns[1].Name = "Product ID";
            grid_STOJOU.Columns[1].ReadOnly = true;
            grid_STOJOU.Columns[1].Width = 80;
            grid_STOJOU.Columns[1].MinimumWidth = 80;
            grid_STOJOU.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[1].DataPropertyName = "ITMREF_0";

            grid_STOJOU.Columns[2].Name = "Product Desc";
            grid_STOJOU.Columns[2].ReadOnly = true;
            grid_STOJOU.Columns[2].Width = 250;
            grid_STOJOU.Columns[2].MinimumWidth = 250;
            grid_STOJOU.Columns[2].DataPropertyName = "ProductDesc";

            grid_STOJOU.Columns[3].Name = "Pack Size";
            grid_STOJOU.Columns[3].ReadOnly = true;
            grid_STOJOU.Columns[3].Width = 80;
            grid_STOJOU.Columns[3].MinimumWidth = 80;
            grid_STOJOU.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[3].DataPropertyName = "PackSize";

            grid_STOJOU.Columns[4].Name = "Brand";
            grid_STOJOU.Columns[4].ReadOnly = true;
            grid_STOJOU.Columns[4].Width = 90;
            grid_STOJOU.Columns[4].MinimumWidth = 90;
            grid_STOJOU.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[4].DataPropertyName = "BrandName";

            grid_STOJOU.Columns[5].Name = "Date";
            grid_STOJOU.Columns[5].ReadOnly = true;
            grid_STOJOU.Columns[5].Width = 80;
            grid_STOJOU.Columns[5].MinimumWidth = 80;
            grid_STOJOU.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_STOJOU.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[5].DataPropertyName = "IPTDAT_0";

            grid_STOJOU.Columns[6].Name = "LOT No";
            grid_STOJOU.Columns[6].ReadOnly = true;
            grid_STOJOU.Columns[6].Width = 80;
            grid_STOJOU.Columns[6].MinimumWidth = 80;
            grid_STOJOU.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[6].DataPropertyName = "LOT_0";

            grid_STOJOU.Columns[7].Name = "VCR No";
            grid_STOJOU.Columns[7].ReadOnly = true;
            grid_STOJOU.Columns[7].Width = 80;
            grid_STOJOU.Columns[7].MinimumWidth = 80;
            grid_STOJOU.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[7].DataPropertyName = "VCRNUM_0";

            grid_STOJOU.Columns[8].Name = "Status";
            grid_STOJOU.Columns[8].ReadOnly = true;
            grid_STOJOU.Columns[8].Width = 120;
            grid_STOJOU.Columns[8].MinimumWidth = 120;
            grid_STOJOU.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[8].DataPropertyName = "STATUS";

            grid_STOJOU.Columns[9].Name = "Qty";
            grid_STOJOU.Columns[9].ReadOnly = true;
            grid_STOJOU.Columns[9].Width = 50;
            grid_STOJOU.Columns[9].MinimumWidth = 50;
            grid_STOJOU.Columns[9].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[9].DataPropertyName = "QTYPCU_0";

            grid_STOJOU.Columns[10].Name = "Amount";
            grid_STOJOU.Columns[10].ReadOnly = true;
            grid_STOJOU.Columns[10].Width = 50;
            grid_STOJOU.Columns[10].MinimumWidth = 50;
            grid_STOJOU.Columns[10].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[10].DataPropertyName = "AMTORD_0";

            grid_STOJOU.Columns[11].Name = "STA";
            grid_STOJOU.Columns[11].ReadOnly = true;
            grid_STOJOU.Columns[11].Width = 30;
            grid_STOJOU.Columns[11].MinimumWidth = 30;
            grid_STOJOU.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[11].DataPropertyName = "STA_0";

            grid_STOJOU.Columns[12].Name = "Memo";
            grid_STOJOU.Columns[12].ReadOnly = true;
            grid_STOJOU.Columns[12].Width = 50;
            grid_STOJOU.Columns[12].MinimumWidth = 50;
            grid_STOJOU.Columns[12].DataPropertyName = "Memo";

            grid_STOJOU.Columns[13].Name = "Type Code";
            grid_STOJOU.Columns[13].ReadOnly = true;
            grid_STOJOU.Columns[13].Width = 30;
            grid_STOJOU.Columns[13].MinimumWidth = 30;
            grid_STOJOU.Columns[13].DataPropertyName = "TypeCode";

            grid_STOJOU.Columns[14].Name = "Type Name";
            grid_STOJOU.Columns[14].ReadOnly = true;
            grid_STOJOU.Columns[14].Width = 120;
            grid_STOJOU.Columns[14].MinimumWidth = 120;
            grid_STOJOU.Columns[14].DataPropertyName = "TypeName";

            //grid font size custom
            grid_STOJOU.RowTemplate.Height = 20;
            grid_STOJOU.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_STOJOU.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_STOJOU.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime ToDate = DateTimePickerTo.Value.Date;
            //string ProductID = txt_ProductID.Text.Trim();
            string ProductID = cbo_itemID.Text.Trim();
            string Site = cbo_Site.Text.Trim();
            string Status = cbo_Status.Text.Trim();

            connPO.sp_STOJOU_History(grid_STOJOU, FromDate, ToDate, ProductID, Site, Status);
        }
        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime ToDate = DateTimePickerTo.Value.Date;
            //string ProductID = txt_ProductID.Text.Trim();
            string ProductID = cbo_itemID.Text.Trim();
            string Site = cbo_Site.Text.Trim();
            string Status = cbo_Status.Text.Trim();

            Reports.Rpt_STOJOU_HISTORY sTOJOU_HISTORY = new Reports.Rpt_STOJOU_HISTORY(FromDate, ToDate, ProductID, Site, Status);
            sTOJOU_HISTORY.Show();
        }



        private void grid_STOJOU_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            String ProductID = grid_STOJOU.Rows[e.RowIndex].Cells["Product ID"].Value.ToString().Trim();
            connPO.txt_INVENTORY(ProductID, txt_PHYWH, txt_PHYNY, txt_GLOBAL, txt_DETAIL);
           
        }

        private void DateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime datetime = new DateTime(2019, 02, 25);
            if (FromDate < datetime)
            {
                MessageBox.Show("INVENTORY DAY : 02/24/2019");
                DateTimePickerFrom.Value = DateTime.Parse("2019/02/25");
            }
        }

        private void DateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            DateTime ToDate = DateTimePickerTo.Value.Date;
            DateTime datetime = new DateTime(2019, 02, 25);
            if (ToDate < datetime)
            {
                MessageBox.Show("INVENTORY DAY : 02/24/2019");
                DateTimePickerTo.Value = DateTime.Parse("2019/02/25");
            }
        }
    }
}
