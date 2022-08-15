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
    public partial class POPrepare_Detail : Form
    {
        public POPrepare_Detail(DateTime FromDate, DateTime ToDate, String ProductID)
        {
            InitializeComponent();
            grid_PoprepareDate_Init();
            grid_PoprepareSalerep_Init();

            txt_productID.Text = ProductID;
            dateTimePicker1.Value = Convert.ToDateTime(FromDate);

            LotProductInfo lotProductInfo = new LotProductInfo();
            lotProductInfo = connSalesOrder.sp_lotProductInfo(ProductID);

            txt_productDesc.Text = lotProductInfo.ProductDesc;
            txt_packsize.Text = lotProductInfo.PackSize;

            connSalesOrder.sp_PoprepareDate(grid_PoprepareDate, FromDate, ToDate, ProductID);
            connSalesOrder.sp_PoprepareSaleRep(grid_PoprepareSaleRep, FromDate, ToDate, ProductID);
        }
        private void grid_PoprepareDate_Init()
        {
            grid_PoprepareDate.AutoGenerateColumns = false;
            grid_PoprepareDate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_PoprepareDate.ColumnCount = 13;

            grid_PoprepareDate.Columns[0].Name = "Date";
            grid_PoprepareDate.Columns[0].ReadOnly = true;
            grid_PoprepareDate.Columns[0].Width = 15;
            grid_PoprepareDate.Columns[0].MinimumWidth = 15;
            grid_PoprepareDate.Columns[0].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_PoprepareDate.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoprepareDate.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoprepareDate.Columns[0].DataPropertyName = "ACCDAT_0";

            grid_PoprepareDate.Columns[1].Name = "Ipad sales";
            grid_PoprepareDate.Columns[1].ReadOnly = true;
            grid_PoprepareDate.Columns[1].Width = 15;
            grid_PoprepareDate.Columns[1].MinimumWidth = 15;
            grid_PoprepareDate.Columns[1].DefaultCellStyle.Format = "N2";
            grid_PoprepareDate.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[1].DataPropertyName = "IpadQty";

            grid_PoprepareDate.Columns[2].Name = "Ipad O/S";
            grid_PoprepareDate.Columns[2].ReadOnly = true;
            grid_PoprepareDate.Columns[2].Width = 15;
            grid_PoprepareDate.Columns[2].MinimumWidth = 15;
            grid_PoprepareDate.Columns[2].DefaultCellStyle.Format = "N2";
            grid_PoprepareDate.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[2].DataPropertyName = "IpadOS";

            grid_PoprepareDate.Columns[3].Name = "Sales order";
            grid_PoprepareDate.Columns[3].ReadOnly = true;
            grid_PoprepareDate.Columns[3].Width = 15;
            grid_PoprepareDate.Columns[3].MinimumWidth = 15;
            grid_PoprepareDate.Columns[3].DefaultCellStyle.Format = "N2";
            grid_PoprepareDate.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[3].DataPropertyName = "OrderQty";

            grid_PoprepareDate.Columns[4].Name = "Global O/S";
            grid_PoprepareDate.Columns[4].ReadOnly = true;
            grid_PoprepareDate.Columns[4].Width = 15;
            grid_PoprepareDate.Columns[4].MinimumWidth = 15;
            grid_PoprepareDate.Columns[4].DefaultCellStyle.Format = "N2";
            grid_PoprepareDate.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[4].DataPropertyName = "GlobalOS";

            grid_PoprepareDate.Columns[5].Name = "Delivery";
            grid_PoprepareDate.Columns[5].ReadOnly = true;
            grid_PoprepareDate.Columns[5].Width = 15;
            grid_PoprepareDate.Columns[5].MinimumWidth = 15;
            grid_PoprepareDate.Columns[5].DefaultCellStyle.Format = "N2";
            grid_PoprepareDate.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[5].DataPropertyName = "Delivery";

            grid_PoprepareDate.Columns[6].Name = "Damaged";
            grid_PoprepareDate.Columns[6].ReadOnly = true;
            grid_PoprepareDate.Columns[6].Width = 15;
            grid_PoprepareDate.Columns[6].MinimumWidth = 15;
            grid_PoprepareDate.Columns[6].DefaultCellStyle.Format = "N2";
            grid_PoprepareDate.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[6].DataPropertyName = "Damaged";

            grid_PoprepareDate.Columns[7].Name = "Missing";
            grid_PoprepareDate.Columns[7].ReadOnly = true;
            grid_PoprepareDate.Columns[7].Width = 15;
            grid_PoprepareDate.Columns[7].MinimumWidth = 15;
            grid_PoprepareDate.Columns[7].DefaultCellStyle.Format = "N2";
            grid_PoprepareDate.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[7].DataPropertyName = "Missing";

            grid_PoprepareDate.Columns[8].Name = "NotIn";
            grid_PoprepareDate.Columns[8].ReadOnly = true;
            grid_PoprepareDate.Columns[8].Width = 15;
            grid_PoprepareDate.Columns[8].MinimumWidth = 15;
            grid_PoprepareDate.Columns[8].DefaultCellStyle.Format = "N2";
            grid_PoprepareDate.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[8].DataPropertyName = "NotIn";

            grid_PoprepareDate.Columns[9].Name = "Refuse";
            grid_PoprepareDate.Columns[9].ReadOnly = true;
            grid_PoprepareDate.Columns[9].Width = 15;
            grid_PoprepareDate.Columns[9].MinimumWidth = 15;
            grid_PoprepareDate.Columns[9].DefaultCellStyle.Format = "N2";
            grid_PoprepareDate.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[9].DataPropertyName = "Returns";

            grid_PoprepareDate.Columns[10].Name = "Promotion";
            grid_PoprepareDate.Columns[10].ReadOnly = true;
            grid_PoprepareDate.Columns[10].Width = 25;
            grid_PoprepareDate.Columns[10].MinimumWidth = 25;
            grid_PoprepareDate.Columns[10].DefaultCellStyle.Format = "N2";
            grid_PoprepareDate.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[10].DataPropertyName = "Promotion";

            grid_PoprepareDate.Columns[11].Name = "Sales";
            grid_PoprepareDate.Columns[11].ReadOnly = true;
            grid_PoprepareDate.Columns[11].Width = 25;
            grid_PoprepareDate.Columns[11].MinimumWidth = 25;
            grid_PoprepareDate.Columns[11].DefaultCellStyle.Format = "N2";
            grid_PoprepareDate.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[11].DataPropertyName = "Sales";

            grid_PoprepareDate.Columns[12].Name = "Return";
            grid_PoprepareDate.Columns[12].ReadOnly = true;
            grid_PoprepareDate.Columns[12].Width = 60;
            grid_PoprepareDate.Columns[12].MinimumWidth = 60;
            grid_PoprepareDate.Columns[12].DefaultCellStyle.Format = "N2";
            grid_PoprepareDate.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareDate.Columns[12].DataPropertyName = "ReturnQty";

            //grid font size custom
            grid_PoprepareDate.RowTemplate.Height = 20;
            grid_PoprepareDate.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_PoprepareDate.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            grid_PoprepareDate.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void grid_PoprepareSalerep_Init()
        {
            grid_PoprepareSaleRep.AutoGenerateColumns = false;
            grid_PoprepareSaleRep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_PoprepareSaleRep.ColumnCount = 13;

            grid_PoprepareSaleRep.Columns[0].Name = "SaleRep";
            grid_PoprepareSaleRep.Columns[0].ReadOnly = true;
            grid_PoprepareSaleRep.Columns[0].Width = 15;
            grid_PoprepareSaleRep.Columns[0].MinimumWidth = 15;
            grid_PoprepareSaleRep.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoprepareSaleRep.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PoprepareSaleRep.Columns[0].DataPropertyName = "SaleRep";

            grid_PoprepareSaleRep.Columns[1].Name = "Ipad sales";
            grid_PoprepareSaleRep.Columns[1].ReadOnly = true;
            grid_PoprepareSaleRep.Columns[1].Width = 15;
            grid_PoprepareSaleRep.Columns[1].MinimumWidth = 15;
            grid_PoprepareSaleRep.Columns[1].DefaultCellStyle.Format = "N2";
            grid_PoprepareSaleRep.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[1].DataPropertyName = "IpadQty";

            grid_PoprepareSaleRep.Columns[2].Name = "Ipad O/S";
            grid_PoprepareSaleRep.Columns[2].ReadOnly = true;
            grid_PoprepareSaleRep.Columns[2].Width = 15;
            grid_PoprepareSaleRep.Columns[2].MinimumWidth = 15;
            grid_PoprepareSaleRep.Columns[2].DefaultCellStyle.Format = "N2";
            grid_PoprepareSaleRep.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[2].DataPropertyName = "IpadOS";

            grid_PoprepareSaleRep.Columns[3].Name = "Sales order";
            grid_PoprepareSaleRep.Columns[3].ReadOnly = true;
            grid_PoprepareSaleRep.Columns[3].Width = 15;
            grid_PoprepareSaleRep.Columns[3].MinimumWidth = 15;
            grid_PoprepareSaleRep.Columns[3].DefaultCellStyle.Format = "N2";
            grid_PoprepareSaleRep.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[3].DataPropertyName = "OrderQty";

            grid_PoprepareSaleRep.Columns[4].Name = "Global O/S";
            grid_PoprepareSaleRep.Columns[4].ReadOnly = true;
            grid_PoprepareSaleRep.Columns[4].Width = 15;
            grid_PoprepareSaleRep.Columns[4].MinimumWidth = 15;
            grid_PoprepareSaleRep.Columns[4].DefaultCellStyle.Format = "N2";
            grid_PoprepareSaleRep.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[4].DataPropertyName = "GlobalOS";

            grid_PoprepareSaleRep.Columns[5].Name = "Delivery";
            grid_PoprepareSaleRep.Columns[5].ReadOnly = true;
            grid_PoprepareSaleRep.Columns[5].Width = 15;
            grid_PoprepareSaleRep.Columns[5].MinimumWidth = 15;
            grid_PoprepareSaleRep.Columns[5].DefaultCellStyle.Format = "N2";
            grid_PoprepareSaleRep.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[5].DataPropertyName = "Delivery";

            grid_PoprepareSaleRep.Columns[6].Name = "Damaged";
            grid_PoprepareSaleRep.Columns[6].ReadOnly = true;
            grid_PoprepareSaleRep.Columns[6].Width = 15;
            grid_PoprepareSaleRep.Columns[6].MinimumWidth = 15;
            grid_PoprepareSaleRep.Columns[6].DefaultCellStyle.Format = "N2";
            grid_PoprepareSaleRep.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[6].DataPropertyName = "Damaged";

            grid_PoprepareSaleRep.Columns[7].Name = "Missing";
            grid_PoprepareSaleRep.Columns[7].ReadOnly = true;
            grid_PoprepareSaleRep.Columns[7].Width = 15;
            grid_PoprepareSaleRep.Columns[7].MinimumWidth = 15;
            grid_PoprepareSaleRep.Columns[7].DefaultCellStyle.Format = "N2";
            grid_PoprepareSaleRep.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[7].DataPropertyName = "Missing";

            grid_PoprepareSaleRep.Columns[8].Name = "NotIn";
            grid_PoprepareSaleRep.Columns[8].ReadOnly = true;
            grid_PoprepareSaleRep.Columns[8].Width = 15;
            grid_PoprepareSaleRep.Columns[8].MinimumWidth = 15;
            grid_PoprepareSaleRep.Columns[8].DefaultCellStyle.Format = "N2";
            grid_PoprepareSaleRep.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[8].DataPropertyName = "NotIn";

            grid_PoprepareSaleRep.Columns[9].Name = "Refuse";
            grid_PoprepareSaleRep.Columns[9].ReadOnly = true;
            grid_PoprepareSaleRep.Columns[9].Width = 15;
            grid_PoprepareSaleRep.Columns[9].MinimumWidth = 15;
            grid_PoprepareSaleRep.Columns[9].DefaultCellStyle.Format = "N2";
            grid_PoprepareSaleRep.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[9].DataPropertyName = "Returns";

            grid_PoprepareSaleRep.Columns[10].Name = "Promotion";
            grid_PoprepareSaleRep.Columns[10].ReadOnly = true;
            grid_PoprepareSaleRep.Columns[10].Width = 25;
            grid_PoprepareSaleRep.Columns[10].MinimumWidth = 25;
            grid_PoprepareSaleRep.Columns[10].DefaultCellStyle.Format = "N2";
            grid_PoprepareSaleRep.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[10].DataPropertyName = "Promotion";

            grid_PoprepareSaleRep.Columns[11].Name = "Sales";
            grid_PoprepareSaleRep.Columns[11].ReadOnly = true;
            grid_PoprepareSaleRep.Columns[11].Width = 25;
            grid_PoprepareSaleRep.Columns[11].MinimumWidth = 25;
            grid_PoprepareSaleRep.Columns[11].DefaultCellStyle.Format = "N2";
            grid_PoprepareSaleRep.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[11].DataPropertyName = "Sales";

            grid_PoprepareSaleRep.Columns[12].Name = "Return";
            grid_PoprepareSaleRep.Columns[12].ReadOnly = true;
            grid_PoprepareSaleRep.Columns[12].Width = 60;
            grid_PoprepareSaleRep.Columns[12].MinimumWidth = 60;
            grid_PoprepareSaleRep.Columns[12].DefaultCellStyle.Format = "N2";
            grid_PoprepareSaleRep.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_PoprepareSaleRep.Columns[12].DataPropertyName = "ReturnQty";

            //grid font size custom
            grid_PoprepareSaleRep.RowTemplate.Height = 20;
            grid_PoprepareSaleRep.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_PoprepareSaleRep.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            grid_PoprepareSaleRep.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void POPrepare_Detail_Load(object sender, EventArgs e)
        {
            try
            {
                //grid_PoprepareDate.DataSource = null;
                decimal[] TotalDate = new decimal[13];
                decimal[] TotalSaleRep = new decimal[13];

                for (int i = 0; i < grid_PoprepareDate.RowCount; i++)
                {
                    for (int j = 1; j < grid_PoprepareDate.ColumnCount; j++)
                    {
                        TotalDate[j] += Convert.ToDecimal(grid_PoprepareDate.Rows[i].Cells[j].Value == DBNull.Value ? "0" : grid_PoprepareDate.Rows[i].Cells[j].Value);
                    }
                    
                }
                for (int i = 0; i < grid_PoprepareSaleRep.RowCount; i++)
                {
                    for (int j = 1; j < grid_PoprepareDate.ColumnCount; j++)
                    {
                        TotalSaleRep[j] += Convert.ToDecimal(grid_PoprepareSaleRep.Rows[i].Cells[j].Value == DBNull.Value ? "0" : grid_PoprepareSaleRep.Rows[i].Cells[j].Value);
                    }
                }
                DataTable dataTable = (DataTable)grid_PoprepareDate.DataSource;
                DataRow drToAdd = dataTable.NewRow();
                drToAdd["ACCDAT_0"] = "TOTAL";
                for (int i = 1; i < grid_PoprepareDate.ColumnCount; i++)
                {
                    drToAdd[i] = TotalDate[i].ToString();
                }
                dataTable.Rows.Add(drToAdd);
                dataTable.AcceptChanges();
                this.grid_PoprepareDate.ClearSelection();


                DataTable SdataTable = (DataTable)grid_PoprepareSaleRep.DataSource;
                DataRow SdrToAdd = SdataTable.NewRow();
                SdrToAdd["SaleRep"] = "TOTAL";
                for (int i = 1; i < grid_PoprepareDate.ColumnCount; i++)
                {
                    SdrToAdd[i] = TotalSaleRep[i].ToString();
                }
                SdataTable.Rows.Add(SdrToAdd);
                SdataTable.AcceptChanges();
                this.grid_PoprepareSaleRep.ClearSelection();

                //txt_totalSalesQty.Text = (total_Promotion + total_Sales).ToString();
                txt_totalSalesQty.Text = decimal.Round((TotalDate[10] + TotalDate[11]), 2, MidpointRounding.AwayFromZero).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void grid_PoprepareDate_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.grid_PoprepareDate.Rows)
            {
                if (row.Cells["Date"].Value.Equals("TOTAL"))
                {
                    row.Cells["Ipad Sales"].Style.BackColor = Color.Gray;
                    row.Cells["Ipad O/S"].Style.BackColor = Color.Gray;
                    row.Cells["Sales order"].Style.BackColor = Color.Gray;
                    row.Cells["Global O/S"].Style.BackColor = Color.Gray;
                    row.Cells["Delivery"].Style.BackColor = Color.Gray;
                    row.Cells["Damaged"].Style.BackColor = Color.Gray;
                    row.Cells["Missing"].Style.BackColor = Color.Gray;
                    row.Cells["NotIn"].Style.BackColor = Color.Gray;
                    row.Cells["Refuse"].Style.BackColor = Color.Gray;
                    row.Cells["Promotion"].Style.BackColor = Color.Gray;
                    row.Cells["Sales"].Style.BackColor = Color.Gray;
                    row.Cells["Return"].Style.BackColor = Color.Gray;
                    row.DefaultCellStyle.BackColor = Color.Gray;
                    row.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void grid_PoprepareSaleRep_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            foreach (DataGridViewRow row in this.grid_PoprepareSaleRep.Rows)
            {
                if (row.Cells["SaleRep"].Value.Equals("TOTAL"))
                {
                    row.Cells["Ipad sales"].Style.BackColor = Color.Gray;
                    row.Cells["Ipad O/S"].Style.BackColor = Color.Gray;
                    row.Cells["Sales order"].Style.BackColor = Color.Gray;
                    row.Cells["Global O/S"].Style.BackColor = Color.Gray;
                    row.Cells["Delivery"].Style.BackColor = Color.Gray;
                    row.Cells["Damaged"].Style.BackColor = Color.Gray;
                    row.Cells["Missing"].Style.BackColor = Color.Gray;
                    row.Cells["NotIn"].Style.BackColor = Color.Gray;
                    row.Cells["Refuse"].Style.BackColor = Color.Gray;
                    row.Cells["Promotion"].Style.BackColor = Color.Gray;
                    row.Cells["Sales"].Style.BackColor = Color.Gray;
                    row.Cells["Return"].Style.BackColor = Color.Gray;
                    row.DefaultCellStyle.BackColor = Color.Gray;
                    row.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
             }
        }
    }
}






//private void POPrepare_Detail_Load(object sender, EventArgs e)
//{
//    //grid_PoprepareDate.DataSource = null;

//    decimal total_IpadQty = 0, total_IpadOS = 0, total_OrderQty = 0, total_GlobalOS = 0, total_Delivery = 0,
//        total_Damaged = 0, total_Missing = 0, total_NotIn = 0, total_Returns = 0, total_Promotion = 0, total_Sales = 0, total_ReturnQty = 0;
//    decimal Stotal_IpadQty = 0, Stotal_IpadOS = 0, Stotal_OrderQty = 0, Stotal_GlobalOS = 0, Stotal_Delivery = 0,
//        Stotal_Damaged = 0, Stotal_Missing = 0, Stotal_NotIn = 0, Stotal_Returns = 0, Stotal_Promotion = 0, Stotal_Sales = 0, Stotal_ReturnQty = 0;

//    for (int i = 0; i < grid_PoprepareDate.RowCount; i++)
//    {
//        total_IpadQty += Convert.ToDecimal(grid_PoprepareDate.Rows[i].Cells["Ipad sales"].Value == DBNull.Value ? "0" : grid_PoprepareDate.Rows[i].Cells["Ipad sales"].Value);
//        total_IpadOS += Convert.ToDecimal(grid_PoprepareDate.Rows[i].Cells["Ipad O/S"].Value == DBNull.Value ? "0" : grid_PoprepareDate.Rows[i].Cells["Ipad O/S"].Value);
//        total_OrderQty += Convert.ToDecimal(grid_PoprepareDate.Rows[i].Cells["Sales order"].Value == DBNull.Value ? "0" : grid_PoprepareDate.Rows[i].Cells["Sales order"].Value);
//        total_GlobalOS += Convert.ToDecimal(grid_PoprepareDate.Rows[i].Cells["Global O/S"].Value == DBNull.Value ? "0" : grid_PoprepareDate.Rows[i].Cells["Global O/S"].Value);
//        total_Delivery += Convert.ToDecimal(grid_PoprepareDate.Rows[i].Cells["Delivery"].Value == DBNull.Value ? "0" : grid_PoprepareDate.Rows[i].Cells["Delivery"].Value);
//        total_Damaged += Convert.ToDecimal(grid_PoprepareDate.Rows[i].Cells["Damaged"].Value == DBNull.Value ? "0" : grid_PoprepareDate.Rows[i].Cells["Damaged"].Value);
//        total_Missing += Convert.ToDecimal(grid_PoprepareDate.Rows[i].Cells["Missing"].Value == DBNull.Value ? "0" : grid_PoprepareDate.Rows[i].Cells["Missing"].Value);
//        total_NotIn += Convert.ToDecimal(grid_PoprepareDate.Rows[i].Cells["NotIn"].Value == DBNull.Value ? "0" : grid_PoprepareDate.Rows[i].Cells["NotIn"].Value);
//        total_Returns += Convert.ToDecimal(grid_PoprepareDate.Rows[i].Cells["Refuse"].Value == DBNull.Value ? "0" : grid_PoprepareDate.Rows[i].Cells["Refuse"].Value);
//        total_Promotion += Convert.ToDecimal(grid_PoprepareDate.Rows[i].Cells["Promotion"].Value == DBNull.Value ? "0" : grid_PoprepareDate.Rows[i].Cells["Promotion"].Value);
//        total_Sales += Convert.ToDecimal(grid_PoprepareDate.Rows[i].Cells["Sales"].Value == DBNull.Value ? "0" : grid_PoprepareDate.Rows[i].Cells["Sales"].Value);
//        total_ReturnQty += Convert.ToDecimal(grid_PoprepareDate.Rows[i].Cells["Return"].Value == DBNull.Value ? "0" : grid_PoprepareDate.Rows[i].Cells["Return"].Value);
//    }

//    for (int i = 0; i < grid_PoprepareSaleRep.RowCount; i++)
//    {
//        Stotal_IpadQty += Convert.ToDecimal(grid_PoprepareSaleRep.Rows[i].Cells["Ipad sales"].Value == DBNull.Value ? "0" : grid_PoprepareSaleRep.Rows[i].Cells["Ipad sales"].Value);
//        Stotal_IpadOS += Convert.ToDecimal(grid_PoprepareSaleRep.Rows[i].Cells["Ipad O/S"].Value == DBNull.Value ? "0" : grid_PoprepareSaleRep.Rows[i].Cells["Ipad O/S"].Value);
//        Stotal_OrderQty += Convert.ToDecimal(grid_PoprepareSaleRep.Rows[i].Cells["Sales order"].Value == DBNull.Value ? "0" : grid_PoprepareSaleRep.Rows[i].Cells["Sales order"].Value);
//        Stotal_GlobalOS += Convert.ToDecimal(grid_PoprepareSaleRep.Rows[i].Cells["Global O/S"].Value == DBNull.Value ? "0" : grid_PoprepareSaleRep.Rows[i].Cells["Global O/S"].Value);
//        Stotal_Delivery += Convert.ToDecimal(grid_PoprepareSaleRep.Rows[i].Cells["Delivery"].Value == DBNull.Value ? "0" : grid_PoprepareSaleRep.Rows[i].Cells["Delivery"].Value);
//        Stotal_Damaged += Convert.ToDecimal(grid_PoprepareSaleRep.Rows[i].Cells["Damaged"].Value == DBNull.Value ? "0" : grid_PoprepareSaleRep.Rows[i].Cells["Damaged"].Value);
//        Stotal_Missing += Convert.ToDecimal(grid_PoprepareSaleRep.Rows[i].Cells["Missing"].Value == DBNull.Value ? "0" : grid_PoprepareSaleRep.Rows[i].Cells["Missing"].Value);
//        Stotal_NotIn += Convert.ToDecimal(grid_PoprepareSaleRep.Rows[i].Cells["NotIn"].Value == DBNull.Value ? "0" : grid_PoprepareSaleRep.Rows[i].Cells["NotIn"].Value);
//        Stotal_Returns += Convert.ToDecimal(grid_PoprepareSaleRep.Rows[i].Cells["Refuse"].Value == DBNull.Value ? "0" : grid_PoprepareSaleRep.Rows[i].Cells["Refuse"].Value);
//        Stotal_Promotion += Convert.ToDecimal(grid_PoprepareSaleRep.Rows[i].Cells["Promotion"].Value == DBNull.Value ? "0" : grid_PoprepareSaleRep.Rows[i].Cells["Promotion"].Value);
//        Stotal_Sales += Convert.ToDecimal(grid_PoprepareSaleRep.Rows[i].Cells["Sales"].Value == DBNull.Value ? "0" : grid_PoprepareSaleRep.Rows[i].Cells["Sales"].Value);
//        Stotal_ReturnQty += Convert.ToDecimal(grid_PoprepareSaleRep.Rows[i].Cells["Return"].Value == DBNull.Value ? "0" : grid_PoprepareSaleRep.Rows[i].Cells["Return"].Value);
//    }
//    DataTable dataTable = (DataTable)grid_PoprepareDate.DataSource;
//    DataRow drToAdd = dataTable.NewRow();
//    drToAdd["ACCDAT_0"] = "TOTAL";
//    drToAdd["IpadQty"] = total_IpadQty.ToString();
//    drToAdd["IpadOS"] = total_IpadOS.ToString();
//    drToAdd["OrderQty"] = total_OrderQty.ToString();
//    drToAdd["GlobalOS"] = total_GlobalOS.ToString();
//    drToAdd["Delivery"] = total_Delivery.ToString();
//    drToAdd["Damaged"] = total_Damaged.ToString();
//    drToAdd["Missing"] = total_Missing.ToString();
//    drToAdd["NotIn"] = total_NotIn.ToString();
//    drToAdd["Returns"] = total_Returns.ToString();
//    drToAdd["Promotion"] = total_Promotion.ToString();
//    drToAdd["Sales"] = total_Sales.ToString();
//    drToAdd["ReturnQty"] = total_ReturnQty.ToString();

//    dataTable.Rows.Add(drToAdd);

//    dataTable.AcceptChanges();

//    this.grid_PoprepareDate.ClearSelection();


//    DataTable SdataTable = (DataTable)grid_PoprepareSaleRep.DataSource;
//    DataRow SdrToAdd = SdataTable.NewRow();
//    SdrToAdd["SaleRep"] = "TOTAL";
//    SdrToAdd["IpadQty"] = Stotal_IpadQty.ToString();
//    SdrToAdd["IpadOS"] = Stotal_IpadOS.ToString();
//    SdrToAdd["OrderQty"] = Stotal_OrderQty.ToString();
//    SdrToAdd["GlobalOS"] = Stotal_GlobalOS.ToString();
//    SdrToAdd["Delivery"] = Stotal_Delivery.ToString();
//    SdrToAdd["Damaged"] = Stotal_Damaged.ToString();
//    SdrToAdd["Missing"] = Stotal_Missing.ToString();
//    SdrToAdd["NotIn"] = Stotal_NotIn.ToString();
//    SdrToAdd["Returns"] = Stotal_Returns.ToString();
//    SdrToAdd["Promotion"] = Stotal_Promotion.ToString();
//    SdrToAdd["Sales"] = Stotal_Sales.ToString();
//    SdrToAdd["ReturnQty"] = Stotal_ReturnQty.ToString();

//    SdataTable.Rows.Add(SdrToAdd);

//    SdataTable.AcceptChanges();

//    this.grid_PoprepareSaleRep.ClearSelection();

//    //txt_totalSalesQty.Text = (total_Promotion + total_Sales).ToString();
//    txt_totalSalesQty.Text = decimal.Round((total_Promotion + total_Sales), 2, MidpointRounding.AwayFromZero).ToString();
//}