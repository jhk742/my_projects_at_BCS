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
    public partial class LotInformation : Form
    {
        public LotInformation()
        {
            InitializeComponent();
            grid_LOTINFO_Init();
            cbo_Site.Items.Add("BCS");
            cbo_Site.Items.Add("WH2");
            //cbo_Site.Items.Add("IFN"); // hiding IFN on Lot information menu - 06/30/2020 requested by management
            cbo_Status.Items.Add("A");
            cbo_Status.Items.Add("Q");
            cbo_Status.Items.Add("R");
            cbo_transaction.Items.Add("");
            cbo_transaction.Items.Add("Miscellaneous receipt");
            cbo_transaction.Items.Add("Supplier receipt");
            cbo_transaction.Items.Add("Assembly");
            cbo_transaction.Items.Add("Disassembly");
            cbo_transaction.Items.Add("Manufacturing receipt");
            cbo_transaction.Items.Add("Status change");
            cbo_transaction.Items.Add("Shipment return");
            cbo_transaction.Items.Add("Intersite transfer");
            cbo_transaction.Items.Add("Location Change");
            cbo_transaction.Items.Add("Subcontract Receipt");

            connSalesOrder.cbo_CdPackDeptTypeCode(cbo_category);
        }
        private void grid_LOTINFO_Init()
        {
            grid_LOTINFO.AutoGenerateColumns = false;
            grid_LOTINFO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_LOTINFO.ColumnCount = 16;

            grid_LOTINFO.Columns[0].Name = "Item ID";
            grid_LOTINFO.Columns[0].ReadOnly = true;
            grid_LOTINFO.Columns[0].Width = 35;
            grid_LOTINFO.Columns[0].MinimumWidth = 35;
            grid_LOTINFO.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[0].DataPropertyName = "ITMREF_0";

            //grid_LOTINFO.Columns[1].Name = "Item ID(Supplier)";
            //grid_LOTINFO.Columns[1].ReadOnly = true;
            //grid_LOTINFO.Columns[1].Width = 50;
            //grid_LOTINFO.Columns[1].MinimumWidth = 50;
            //grid_LOTINFO.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_LOTINFO.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_LOTINFO.Columns[1].DataPropertyName = "ITMREF_SUP";

            grid_LOTINFO.Columns[1].Name = "Description";
            grid_LOTINFO.Columns[1].ReadOnly = true;
            grid_LOTINFO.Columns[1].Width = 120;
            grid_LOTINFO.Columns[1].MinimumWidth = 120;
            grid_LOTINFO.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[1].DataPropertyName = "ProductDesc";

            grid_LOTINFO.Columns[2].Name = "PackSize";
            grid_LOTINFO.Columns[2].ReadOnly = true;
            grid_LOTINFO.Columns[2].Width = 40;
            grid_LOTINFO.Columns[2].MinimumWidth = 40;
            grid_LOTINFO.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[2].DataPropertyName = "StrPackSize";

            grid_LOTINFO.Columns[3].Name = "Category";
            grid_LOTINFO.Columns[3].ReadOnly = true;
            grid_LOTINFO.Columns[3].Width = 25;
            grid_LOTINFO.Columns[3].MinimumWidth = 25;
            grid_LOTINFO.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[3].DataPropertyName = "Category";

            grid_LOTINFO.Columns[4].Name = "Site";
            grid_LOTINFO.Columns[4].ReadOnly = true;
            grid_LOTINFO.Columns[4].Width = 20;
            grid_LOTINFO.Columns[4].MinimumWidth = 20;
            grid_LOTINFO.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[4].DataPropertyName = "STOFCY_0";

            grid_LOTINFO.Columns[5].Name = "Location";
            grid_LOTINFO.Columns[5].ReadOnly = true;
            grid_LOTINFO.Columns[5].Width = 40;
            grid_LOTINFO.Columns[5].MinimumWidth = 40;
            grid_LOTINFO.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[5].DataPropertyName = "Location";

            grid_LOTINFO.Columns[6].Name = "LOT";
            grid_LOTINFO.Columns[6].ReadOnly = true;
            grid_LOTINFO.Columns[6].Width = 40;
            grid_LOTINFO.Columns[6].MinimumWidth = 40;
            grid_LOTINFO.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[6].DataPropertyName = "LOT_0";

            grid_LOTINFO.Columns[7].Name = "Create Date";
            grid_LOTINFO.Columns[7].ReadOnly = true;
            grid_LOTINFO.Columns[7].Width = 35;
            grid_LOTINFO.Columns[7].MinimumWidth = 35;
            grid_LOTINFO.Columns[7].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_LOTINFO.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[7].DataPropertyName = "CreateDate";

            grid_LOTINFO.Columns[8].Name = "STA";
            grid_LOTINFO.Columns[8].ReadOnly = true;
            grid_LOTINFO.Columns[8].Width = 15;
            grid_LOTINFO.Columns[8].MinimumWidth = 15;
            grid_LOTINFO.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[8].DataPropertyName = "STA_0";

            grid_LOTINFO.Columns[9].Name = "Qty";
            grid_LOTINFO.Columns[9].ReadOnly = true;
            grid_LOTINFO.Columns[9].Width = 25;
            grid_LOTINFO.Columns[9].MinimumWidth = 25;
            grid_LOTINFO.Columns[9].DefaultCellStyle.Format = "N2";
            grid_LOTINFO.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LOTINFO.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LOTINFO.Columns[9].DataPropertyName = "Qty";

            grid_LOTINFO.Columns[10].Name = "Base Price";
            grid_LOTINFO.Columns[10].ReadOnly = true;
            grid_LOTINFO.Columns[10].Width = 25;
            grid_LOTINFO.Columns[10].MinimumWidth = 25;
            grid_LOTINFO.Columns[10].DefaultCellStyle.Format = "N2";
            grid_LOTINFO.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LOTINFO.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LOTINFO.Columns[10].DataPropertyName = "MATCST_1";

            grid_LOTINFO.Columns[11].Name = "Total Cost";
            grid_LOTINFO.Columns[11].ReadOnly = true;
            grid_LOTINFO.Columns[11].Width = 35;
            grid_LOTINFO.Columns[11].MinimumWidth = 35;
            grid_LOTINFO.Columns[11].DefaultCellStyle.Format = "N2";
            grid_LOTINFO.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LOTINFO.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LOTINFO.Columns[11].DataPropertyName = "CST_0";

            grid_LOTINFO.Columns[12].Name = "Expire Date";
            grid_LOTINFO.Columns[12].ReadOnly = true;
            grid_LOTINFO.Columns[12].Width = 35;
            grid_LOTINFO.Columns[12].MinimumWidth = 35;
            grid_LOTINFO.Columns[12].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_LOTINFO.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[12].DataPropertyName = "RCPDAT_0";

            grid_LOTINFO.Columns[13].Name = "Transaction type";
            grid_LOTINFO.Columns[13].ReadOnly = true;
            grid_LOTINFO.Columns[13].Width = 50;
            grid_LOTINFO.Columns[13].MinimumWidth = 50;
            grid_LOTINFO.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[13].DataPropertyName = "TRANSACTION_CHANGE";

            grid_LOTINFO.Columns[14].Name = "Reason";
            grid_LOTINFO.Columns[14].ReadOnly = true;
            grid_LOTINFO.Columns[14].Width = 200;
            grid_LOTINFO.Columns[14].MinimumWidth = 200;
            grid_LOTINFO.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[14].DataPropertyName = "Reason";

            grid_LOTINFO.Columns[15].Name = "Memo";
            grid_LOTINFO.Columns[15].ReadOnly = true;
            grid_LOTINFO.Columns[15].Width = 100;
            grid_LOTINFO.Columns[15].MinimumWidth = 100;
            grid_LOTINFO.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LOTINFO.Columns[15].DataPropertyName = "Memo";

            //grid font size custom
            grid_LOTINFO.RowTemplate.Height = 20;
            grid_LOTINFO.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_LOTINFO.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_LOTINFO.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            String ProductID = txt_ProductID.Text.Trim().ToString();
            String STOFCY = cbo_Site.Text.Trim().ToString();
            String Status = cbo_Status.Text.Trim().ToString();
            String Category = cbo_category.Text.Trim().ToString();
            String Location = txt_location.Text.Trim().ToString();
            String Transaction = cbo_transaction.Text.ToString();

            connSalesOrder.sp_LotInformation(grid_LOTINFO, ProductID, Status, STOFCY, Category, Location, Transaction);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            String ProductID = txt_ProductID.Text.Trim().ToString();
            String STOFCY = cbo_Site.Text.Trim().ToString();
            String Status = cbo_Status.Text.Trim().ToString();
            String Category = cbo_category.Text.Trim().ToString();
            String Location = txt_location.Text.Trim().ToString();
            String Transaction = cbo_transaction.Text.ToString();
            Reports.Rpt_LotInformation rpt_LotInformation = new Reports.Rpt_LotInformation(ProductID, Status, STOFCY, Category, Location, Transaction);
            rpt_LotInformation.Show();
        }

        private void grid_LOTINFO_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.grid_LOTINFO.Rows)
            {
                if (Convert.ToDateTime(row.Cells["Expire Date"].Value) < DateTime.Today.AddDays(+31) && Convert.ToDateTime(row.Cells["Expire Date"].Value) >= DateTime.Today)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }else if(Convert.ToDateTime(row.Cells["Expire Date"].Value) < DateTime.Today)
                {   
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void grid_LOTINFO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String ProductID = grid_LOTINFO.Rows[e.RowIndex].Cells["Item ID"].Value.ToString().Trim();
                Entities.LotProductInfo lotProductInfo = new Entities.LotProductInfo();
                lotProductInfo = connSalesOrder.sp_lotProductInfo(ProductID);

                txt_ProductIDInfo.Text = lotProductInfo.ProductID;
                txt_ProductDescInfo.Text = lotProductInfo.ProductDesc;
                txt_ProductPacksizeInfo.Text = lotProductInfo.PackSize;
                txt_NJWH.Text = lotProductInfo.NJWH;
                txt_NYWH.Text = lotProductInfo.NYWH;
                txt_Global.Text = lotProductInfo.GLOALL;
                txt_Detailed.Text = lotProductInfo.DETAIL;
                txt_Onhand.Text = lotProductInfo.Onhand;
                txt_Lot.Text = grid_LOTINFO.Rows[e.RowIndex].Cells["LOT"].Value.ToString().Trim();
                txt_Memo.Text = grid_LOTINFO.Rows[e.RowIndex].Cells["Memo"].Value.ToString().Trim();
            }
            catch
            {

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                String LOTNumber = txt_Lot.Text.ToString();
                String Memo = txt_Memo.Text.ToString();
                connSalesOrder.sp_LotMemoUpdate(LOTNumber, Memo);

                MessageBox.Show("Done. \nPlease refresh the list to get the modified values.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                for (int i = 0; i < grid_LOTINFO.RowCount; i++)
                {
                    if (grid_LOTINFO.Rows[i].Cells["LOT"].Value.ToString().Trim().Equals(LOTNumber))
                    {
                        grid_LOTINFO.Rows[i].Cells["Memo"].Value = Memo;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
