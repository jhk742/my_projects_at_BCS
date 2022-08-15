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
    public partial class StockDetailByProduct : Form
    {
        public StockDetailByProduct()
        {
            InitializeComponent();
            grid_STOJOU_Init();

            cbo_Site.Items.Add("");
            cbo_Category.Items.Add("");
            cbo_Brand.Items.Add("");
            cbo_Status.Items.Add("");
            cbo_Status.Items.Add("A");
            cbo_Status.Items.Add("Q");
            cbo_Status.Items.Add("R");
            cbo_Site.Items.Add("BCS");
            cbo_Site.Items.Add("WH2");

            //connSalesOrder.cbo_SiteFromSTOJOU(cbo_Site);
            connSalesOrder.cbo_CdPackDeptTypeCode(cbo_Category);
            connSalesOrder.sp_GET_ALLBrandCode(cbo_Brand);
            connSalesOrder.cbo_itemID(cbo_ProductID);

        }
        private void grid_STOJOU_Init()
        {
            grid_STOJOU.AutoGenerateColumns = false;
            grid_STOJOU.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            grid_STOJOU.ColumnCount = 27;

            grid_STOJOU.Columns[0].Name = "Site";
            grid_STOJOU.Columns[0].ReadOnly = true;
            grid_STOJOU.Columns[0].Width = 50;
            grid_STOJOU.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[0].DataPropertyName = "Site";

            grid_STOJOU.Columns[1].Name = "Status";
            grid_STOJOU.Columns[1].ReadOnly = true;
            grid_STOJOU.Columns[1].Width = 50;
            grid_STOJOU.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[1].DataPropertyName = "Status";

            grid_STOJOU.Columns[2].Name = "Category";
            grid_STOJOU.Columns[2].ReadOnly = true;
            grid_STOJOU.Columns[2].Width = 70;
            grid_STOJOU.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[2].DataPropertyName = "Category";

            grid_STOJOU.Columns[3].Name = "Brand";
            grid_STOJOU.Columns[3].ReadOnly = true;
            grid_STOJOU.Columns[3].Width = 100;
            grid_STOJOU.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[3].DataPropertyName = "Brand";

            grid_STOJOU.Columns[4].Name = "ProductID";
            grid_STOJOU.Columns[4].ReadOnly = true;
            grid_STOJOU.Columns[4].Width = 90;
            grid_STOJOU.Columns[4].MinimumWidth = 90;
            grid_STOJOU.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[4].DataPropertyName = "ProductID";

            grid_STOJOU.Columns[5].Name = "ProductDesc";
            grid_STOJOU.Columns[5].ReadOnly = true;
            grid_STOJOU.Columns[5].Width = 300;
            grid_STOJOU.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[5].DataPropertyName = "ProductDesc";

            grid_STOJOU.Columns[6].Name = "PackSize";
            grid_STOJOU.Columns[6].ReadOnly = true;
            grid_STOJOU.Columns[6].Width = 90;
            grid_STOJOU.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[6].DataPropertyName = "StrPackSize";

            grid_STOJOU.Columns[7].Name = "Beg";
            grid_STOJOU.Columns[7].ReadOnly = true;
            grid_STOJOU.Columns[7].Width = 80;
            grid_STOJOU.Columns[7].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[7].DataPropertyName = "Beg";

            grid_STOJOU.Columns[8].Name = "Receipt\n(+)";
            grid_STOJOU.Columns[8].ReadOnly = true;
            grid_STOJOU.Columns[8].Width = 100;
            grid_STOJOU.Columns[8].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[8].DataPropertyName = "Receipt";

            grid_STOJOU.Columns[9].Name = "Receipt\nReturn(-)";
            grid_STOJOU.Columns[9].ReadOnly = true;
            grid_STOJOU.Columns[9].Width = 100;
            grid_STOJOU.Columns[9].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[9].DataPropertyName = "ReceiptReturn";

            grid_STOJOU.Columns[10].Name = "Shipment\n(-)";
            grid_STOJOU.Columns[10].ReadOnly = true;
            grid_STOJOU.Columns[10].Width = 100;
            grid_STOJOU.Columns[10].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[10].DataPropertyName = "Shipment";

            grid_STOJOU.Columns[11].Name = "Shipment\nReturn(+)";
            grid_STOJOU.Columns[11].ReadOnly = true;
            grid_STOJOU.Columns[11].Width = 100;
            grid_STOJOU.Columns[11].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[11].DataPropertyName = "ShipmentReturn";

            grid_STOJOU.Columns[12].Name = "Manufactoring\n(-)";
            grid_STOJOU.Columns[12].ReadOnly = true;
            grid_STOJOU.Columns[12].Width = 100;
            grid_STOJOU.Columns[12].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[12].DataPropertyName = "ManufactoringOrders";

            grid_STOJOU.Columns[13].Name = "Manufactoring\nReceipt(+)";
            grid_STOJOU.Columns[13].ReadOnly = true;
            grid_STOJOU.Columns[13].Width = 100;
            grid_STOJOU.Columns[13].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[13].DataPropertyName = "ManufactoringReceipt";

            grid_STOJOU.Columns[14].Name = "Subcontract\nOrders(-)";
            grid_STOJOU.Columns[14].ReadOnly = true;
            grid_STOJOU.Columns[14].Width = 100;
            grid_STOJOU.Columns[14].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[14].DataPropertyName = "SubcontractOrders";

            grid_STOJOU.Columns[15].Name = "Subcontract\nReceipt(+)";
            grid_STOJOU.Columns[15].ReadOnly = true;
            grid_STOJOU.Columns[15].Width = 100;
            grid_STOJOU.Columns[15].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[15].DataPropertyName = "SubcontractReceipt";

            grid_STOJOU.Columns[16].Name = "Miscellaneous\nReceipts(+)"; 
            grid_STOJOU.Columns[16].ReadOnly = true;
            grid_STOJOU.Columns[16].Width = 100;
            grid_STOJOU.Columns[16].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[16].DataPropertyName = "MiscellaneousReceipts"; 

            grid_STOJOU.Columns[17].Name = "Miscellaneous\nIssues(-)";
            grid_STOJOU.Columns[17].ReadOnly = true;
            grid_STOJOU.Columns[17].Width = 100;
            grid_STOJOU.Columns[17].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[17].DataPropertyName = "MiscellaneousIssues";

            grid_STOJOU.Columns[18].Name = "Assembly\n(+)";
            grid_STOJOU.Columns[18].ReadOnly = true;
            grid_STOJOU.Columns[18].Width = 100;
            grid_STOJOU.Columns[18].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[18].DataPropertyName = "AssemblyPlus";

            grid_STOJOU.Columns[19].Name = "Assembly\n(-)";
            grid_STOJOU.Columns[19].ReadOnly = true;
            grid_STOJOU.Columns[19].Width = 100;
            grid_STOJOU.Columns[19].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[19].DataPropertyName = "AssemblyMinus";

            grid_STOJOU.Columns[20].Name = "Disassembly\n(+)";
            grid_STOJOU.Columns[20].ReadOnly = true;
            grid_STOJOU.Columns[20].Width = 100;
            grid_STOJOU.Columns[20].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[20].DataPropertyName = "DisassemblyPlus";

            grid_STOJOU.Columns[21].Name = "Disassembly\n(-)";
            grid_STOJOU.Columns[21].ReadOnly = true;
            grid_STOJOU.Columns[21].Width = 100;
            grid_STOJOU.Columns[21].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[21].DataPropertyName = "DisassemblyMinus";

            grid_STOJOU.Columns[22].Name = "Stock\nChange(+)";
            grid_STOJOU.Columns[22].ReadOnly = true;
            grid_STOJOU.Columns[22].Width = 100;
            grid_STOJOU.Columns[22].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[22].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[22].DataPropertyName = "StockChangePlus";

            grid_STOJOU.Columns[23].Name = "Stock\nChange(-)";
            grid_STOJOU.Columns[23].ReadOnly = true;
            grid_STOJOU.Columns[23].Width = 100;
            grid_STOJOU.Columns[23].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[23].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[23].DataPropertyName = "StockChangeMinus";

            grid_STOJOU.Columns[24].Name = "Intersite\nTransfer(+)";
            grid_STOJOU.Columns[24].ReadOnly = true;
            grid_STOJOU.Columns[24].Width = 100;
            grid_STOJOU.Columns[24].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[24].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[24].DataPropertyName = "IntersiteTransferPlus";

            grid_STOJOU.Columns[25].Name = "Intersite\nTransfer(-)";
            grid_STOJOU.Columns[25].ReadOnly = true;
            grid_STOJOU.Columns[25].Width = 100;
            grid_STOJOU.Columns[25].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[25].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[25].DataPropertyName = "IntersiteTransferMinus";

            //grid_STOJOU.Columns[26].Name = "Etc\n(+/-)";
            //grid_STOJOU.Columns[26].ReadOnly = true;
            //grid_STOJOU.Columns[26].Width = 80;
            //grid_STOJOU.Columns[26].DefaultCellStyle.Format = "N2";
            //grid_STOJOU.Columns[26].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //grid_STOJOU.Columns[26].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_STOJOU.Columns[26].DataPropertyName = "Etc";

            grid_STOJOU.Columns[26].Name = "Ending";
            grid_STOJOU.Columns[26].ReadOnly = true;
            grid_STOJOU.Columns[26].Width = 80;
            grid_STOJOU.Columns[26].DefaultCellStyle.Format = "N2";
            grid_STOJOU.Columns[26].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_STOJOU.Columns[26].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_STOJOU.Columns[26].DataPropertyName = "Ending";

            //grid font size custom
            grid_STOJOU.RowTemplate.Height = 20;
            grid_STOJOU.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_STOJOU.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
                c.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            
            grid_STOJOU.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime ToDate = DateTimePickerTo.Value.Date;
            String Site = cbo_Site.Text.ToString();
            String Status = cbo_Status.Text.ToString();
            String Category = cbo_Category.Text.ToString();
            String ProductID = cbo_ProductID.Text.ToString();
            String Brand = cbo_Brand.Text.ToString();

            connSalesOrder.sp_StockDetailByProductID(grid_STOJOU, FromDate, ToDate, Site, Status, Category, ProductID, Brand);


            try
            {
                DataTable dataTable = (DataTable)grid_STOJOU.DataSource;

                decimal[] Totalarray = new decimal[20];

                for (int i = 0; i < grid_STOJOU.RowCount; i++)
                {
                    for(int j = 0; j < Totalarray.Length; j++)
                    {
                        Totalarray[j] += Convert.ToDecimal(grid_STOJOU.Rows[i].Cells[j+7].Value == DBNull.Value ? "0" : grid_STOJOU.Rows[i].Cells[j+7].Value);
                    }
                }

                DataRow drToAdd = dataTable.NewRow();
                for(int i = 0; i < grid_STOJOU.ColumnCount; i++)
                {
                    drToAdd[i] = DBNull.Value;
                    drToAdd["ProductID"] = "TOTAL";
                    if( i >= 7)
                    {
                        drToAdd[i] = Totalarray[i - 7].ToString();
                    }
                }

                dataTable.Rows.Add(drToAdd);

                dataTable.AcceptChanges();

                this.grid_STOJOU.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void grid_STOJOU_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.grid_STOJOU.Rows)
            {
                row.Cells["Beg"].Style.BackColor = Color.OldLace;
                row.Cells["Ending"].Style.BackColor = Color.OldLace;

                if (row.Cells["ProductID"].Value.Equals("TOTAL"))
                {
                    for (int i = 0; i < grid_STOJOU.ColumnCount; i++)
                    {
                        row.Cells[i].Style.BackColor = Color.Gray;
                        row.Cells[i].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime ToDate = DateTimePickerTo.Value.Date;
            String Site = cbo_Site.Text.ToString();
            String Status = cbo_Status.Text.ToString();
            String Category = cbo_Category.Text.ToString();
            String ProductID = cbo_ProductID.Text.ToString();
            String Brand = cbo_Brand.Text.ToString();

            Reports.Rpt_StockDetailByProduct stockDetailByProduct = new Reports.Rpt_StockDetailByProduct(FromDate, ToDate, Site, Status, Category, ProductID, Brand);
            stockDetailByProduct.Show();
        }

        private void DateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime datetime = new DateTime(2019, 05, 29);
            if (FromDate < datetime)
            {
                MessageBox.Show("INVENTORY DAY : 05/28/2019");
                DateTimePickerFrom.Value = datetime;
            }
        }

        private void DateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            DateTime ToDate = DateTimePickerTo.Value.Date;
            DateTime datetime = new DateTime(2019, 05, 29);
            if (ToDate < datetime)
            {
                MessageBox.Show("INVENTORY DAY : 05/28/2019");
                DateTimePickerTo.Value = datetime;
            }
        }
    }
}