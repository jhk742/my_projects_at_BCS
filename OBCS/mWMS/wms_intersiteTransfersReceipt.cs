using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.mWMS
{
    public partial class wms_intersiteTransfersReceipt : Form
    {
        public wms_intersiteTransfersReceipt()
        {
            InitializeComponent();

            grid_header_Init();
            grid_detail_Init();

            connSalesOrder.sp_WMS_INTERSITETRANSFERS_RECEIPT(grid_header);

            cbo_storageSite.Items.Add("BCS");
            cbo_storageSite.Items.Add("WH2");

            cbo_destinationStie.Items.Add("BCS");
            cbo_destinationStie.Items.Add("WH2");
            cbo_storageSite.Text = "WH2";
            cbo_destinationStie.Text = "BCS";

        }

        private void grid_header_Init()
        {
            grid_header.AutoGenerateColumns = false;
            grid_header.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_header.ColumnCount = 5;

            grid_header.Columns[0].Name = "No.";
            grid_header.Columns[0].ReadOnly = true;
            grid_header.Columns[0].Width = 70;
            grid_header.Columns[0].DataPropertyName = "WHCHGNumber";

            grid_header.Columns[1].Name = "Description";
            grid_header.Columns[1].ReadOnly = true;
            grid_header.Columns[1].Width = 70;
            grid_header.Columns[1].DataPropertyName = "Memo";

            grid_header.Columns[2].Name = "Stock Site";
            grid_header.Columns[2].ReadOnly = true;
            grid_header.Columns[2].Width = 70;
            grid_header.Columns[2].DataPropertyName = "StorageSite";

            grid_header.Columns[3].Name = "Dest. Site";
            grid_header.Columns[3].ReadOnly = true;
            grid_header.Columns[3].Width = 70;
            grid_header.Columns[3].DataPropertyName = "DestinationSite";

            grid_header.Columns[4].Name = "Date";
            grid_header.Columns[4].ReadOnly = true;
            grid_header.Columns[4].Width = 70;
            grid_header.Columns[4].DataPropertyName = "CreateDate";


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

        private void grid_detail_Init()
        {
            grid_detail.AutoGenerateColumns = false;
            grid_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_detail.ColumnCount = 11;
            
            grid_detail.Columns[0].Name = "Product";
            grid_detail.Columns[0].ReadOnly = true;
            grid_detail.Columns[0].Width = 70;
            grid_detail.Columns[0].DataPropertyName = "ProductID";

            grid_detail.Columns[1].Name = "Description";
            grid_detail.Columns[1].ReadOnly = true;
            grid_detail.Columns[1].Width = 70;
            grid_detail.Columns[1].DataPropertyName = "ProductDesc";

            grid_detail.Columns[2].Name = "Status";
            grid_detail.Columns[2].ReadOnly = false;
            grid_detail.Columns[2].Width = 70;
            grid_detail.Columns[2].DataPropertyName = "Status";

            grid_detail.Columns[3].Name = "Sales Unit";
            grid_detail.Columns[3].ReadOnly = true;
            grid_detail.Columns[3].Width = 70;
            grid_detail.Columns[3].DataPropertyName = "SalesUnit";

            grid_detail.Columns[4].Name = "Pack Size";
            grid_detail.Columns[4].ReadOnly = true;
            grid_detail.Columns[4].Width = 70;
            grid_detail.Columns[4].DataPropertyName = "PackSize";

            grid_detail.Columns[5].Name = "Qty";
            grid_detail.Columns[5].ReadOnly = false;
            grid_detail.Columns[5].Width = 50;
            grid_detail.Columns[5].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].DataPropertyName = "Qty";

            grid_detail.Columns[6].Name = "Price";
            grid_detail.Columns[6].ReadOnly = true;
            grid_detail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].Width = 60;
            grid_detail.Columns[6].DataPropertyName = "BasePrice";

            grid_detail.Columns[7].Name = "Amount";
            grid_detail.Columns[7].ReadOnly = true;
            grid_detail.Columns[7].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[7].Width = 60;
            grid_detail.Columns[7].DataPropertyName = "Amount";

            grid_detail.Columns[8].Name = "DetailKey";
            grid_detail.Columns[8].ReadOnly = true;
            grid_detail.Columns[8].Width = 70;
            grid_detail.Columns[8].DataPropertyName = "DetailKey";
            
            grid_detail.Columns[9].Name = "Expiration Date";
            grid_detail.Columns[9].ReadOnly = true;
            grid_detail.Columns[9].Width = 80;
            grid_detail.Columns[9].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_detail.Columns[9].DataPropertyName = "ExpirationDate";

            grid_detail.Columns[10].Name = "Location";
            grid_detail.Columns[10].ReadOnly = true;
            grid_detail.Columns[10].Width = 70;
            grid_detail.Columns[10].DataPropertyName = "Location";

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

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure run this intersite transfer process?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                String WHCHGNumber = txt_WHCHGNumber.Text.Trim();
                String StorageSite = cbo_storageSite.Text.Trim();
                String DestinationSite = cbo_destinationStie.Text.Trim();
                DateTime AccountingDate = dateTimePicker1.Value.Date;
                String Description = txt_desc.Text.Trim();
                
                for (int i = 0; i < grid_detail.Rows.Count; i++)
                {
                    String ProductID = grid_detail.Rows[i].Cells["Product"].Value.ToString().Trim();
                    String ProductDesc = grid_detail.Rows[i].Cells["Description"].Value.ToString().Trim();
                    String Status = grid_detail.Rows[i].Cells["Status"].Value.ToString().Trim();
                    String SalesUnit = grid_detail.Rows[i].Cells["Sales Unit"].Value.ToString().Trim();
                    String PackSize = grid_detail.Rows[i].Cells["Pack Size"].Value.ToString().Trim();
                    Decimal Qty = Convert.ToDecimal(grid_detail.Rows[i].Cells["Qty"].Value.ToString().Trim());
                    Decimal BasePrice = Convert.ToDecimal(grid_detail.Rows[i].Cells["Price"].Value.ToString().Trim());
                    int DetailKey = Convert.ToInt32(grid_detail.Rows[i].Cells["DetailKey"].Value.ToString().Trim());
                    DateTime ExpirationDate = Convert.ToDateTime(grid_detail.Rows[i].Cells["Expiration Date"].Value.ToString().Trim());
                    String Location = grid_detail.Rows[i].Cells["Location"].Value.ToString().Trim();
                    
                    connSalesOrder.sp_WMS_INTERSITETRANSFERS_CONFIRM_DETAIL(WHCHGNumber, ProductID, ProductDesc, Status, SalesUnit, PackSize, Qty, BasePrice, Location, ExpirationDate, DetailKey);
                }

                connSalesOrder.sp_WMS_INTERSITETRANSFERS_CONFIRM_HEADER(WHCHGNumber, StorageSite, DestinationSite, AccountingDate, Description);
                MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_desc.Text = "";

                grid_detail.DataSource = null;
                
                connSalesOrder.sp_WMS_INTERSITETRANSFERS_RECEIPT(grid_header);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void grid_header_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String WHCHGNumber = grid_header.Rows[e.RowIndex].Cells["No."].Value.ToString();
                String StockSite = grid_header.Rows[e.RowIndex].Cells["Stock Site"].Value.ToString();
                String DestinationSite = grid_header.Rows[e.RowIndex].Cells["Dest. Site"].Value.ToString();
                txt_WHCHGNumber.Text = WHCHGNumber;
                cbo_storageSite.Text = StockSite;
                cbo_destinationStie.Text = DestinationSite;

                connSalesOrder.sp_WMS_INTERSITETRANSFERS_RECEIPTD(grid_detail, WHCHGNumber);
            }
            catch
            {
                //MessageBox.Show("ERROR");
            }
        }
    }
}
