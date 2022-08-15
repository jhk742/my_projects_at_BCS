using OBCS.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Sales
{
    public partial class DeliveryOSReport : Form
    {
        public DeliveryOSReport()
        {
            InitializeComponent();
            grid_detail_Init();
            connSalesOrder.sp_GET_SalesRep(cbx_SalesRep);
            String DeliveryNubmer = txt_DeliveryNumber.Text.Trim();
            String CustomerID = txt_CustomerID.Text.Trim();
            String SalesRep = cbx_SalesRep.Text.Trim();
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime ToDate = DateTimePickerTo.Value.Date;
            connSalesOrder.sp_DeliveryOS_Report(grid_DeliveryOS, FromDate, ToDate, DeliveryNubmer, SalesRep, CustomerID);
        }
        private void grid_detail_Init()
        {
            grid_DeliveryOS.AutoGenerateColumns = false;
            grid_DeliveryOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_DeliveryOS.ColumnCount = 12;

            grid_DeliveryOS.Columns[0].Name = "DELIVERY NUMBER";
            grid_DeliveryOS.Columns[0].ReadOnly = true;
            grid_DeliveryOS.Columns[0].Width = 100;
            grid_DeliveryOS.Columns[0].MinimumWidth = 100;
            grid_DeliveryOS.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_DeliveryOS.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_DeliveryOS.Columns[0].DataPropertyName = "DeliveryNumber";

            grid_DeliveryOS.Columns[1].Name = "SALE REP";
            grid_DeliveryOS.Columns[1].ReadOnly = true;
            grid_DeliveryOS.Columns[1].Width = 40;
            grid_DeliveryOS.Columns[1].MinimumWidth = 40;
            grid_DeliveryOS.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_DeliveryOS.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_DeliveryOS.Columns[1].DataPropertyName = "SaleRep";

            grid_DeliveryOS.Columns[2].Name = "CUSTOMER ID";
            grid_DeliveryOS.Columns[2].ReadOnly = true;
            grid_DeliveryOS.Columns[2].Width = 80;
            grid_DeliveryOS.Columns[2].MinimumWidth = 80;
            grid_DeliveryOS.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_DeliveryOS.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_DeliveryOS.Columns[2].DataPropertyName = "CustomerID";

            grid_DeliveryOS.Columns[3].Name = "DELIVERY";
            grid_DeliveryOS.Columns[3].ReadOnly = true;
            grid_DeliveryOS.Columns[3].Width = 80;
            grid_DeliveryOS.Columns[3].MinimumWidth = 80;
            grid_DeliveryOS.Columns[3].DefaultCellStyle.Format = "N2";
            grid_DeliveryOS.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DeliveryOS.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DeliveryOS.Columns[3].DataPropertyName = "DELIVERY";

            grid_DeliveryOS.Columns[4].Name = "CREATE DATE";
            grid_DeliveryOS.Columns[4].ReadOnly = true;
            grid_DeliveryOS.Columns[4].Width = 80;
            grid_DeliveryOS.Columns[4].MinimumWidth = 80;
            grid_DeliveryOS.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_DeliveryOS.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_DeliveryOS.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_DeliveryOS.Columns[4].DataPropertyName = "CreateTime";

            grid_DeliveryOS.Columns[5].Name = "DAMAGED";
            grid_DeliveryOS.Columns[5].ReadOnly = true;
            grid_DeliveryOS.Columns[5].Width = 80;
            grid_DeliveryOS.Columns[5].MinimumWidth = 80;
            grid_DeliveryOS.Columns[5].DefaultCellStyle.Format = "N2";
            grid_DeliveryOS.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DeliveryOS.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DeliveryOS.Columns[5].DataPropertyName = "DAMAGED";

            grid_DeliveryOS.Columns[6].Name = "MISSING";
            grid_DeliveryOS.Columns[6].ReadOnly = true;
            grid_DeliveryOS.Columns[6].Width = 80;
            grid_DeliveryOS.Columns[6].MinimumWidth = 80;
            grid_DeliveryOS.Columns[6].DefaultCellStyle.Format = "N2";
            grid_DeliveryOS.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DeliveryOS.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DeliveryOS.Columns[6].DataPropertyName = "MISSING";

            grid_DeliveryOS.Columns[7].Name = "NOT IN";
            grid_DeliveryOS.Columns[7].ReadOnly = true;
            grid_DeliveryOS.Columns[7].Width = 80;
            grid_DeliveryOS.Columns[7].MinimumWidth = 80;
            grid_DeliveryOS.Columns[7].DefaultCellStyle.Format = "N2";
            grid_DeliveryOS.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DeliveryOS.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DeliveryOS.Columns[7].DataPropertyName = "NOTIN";

            grid_DeliveryOS.Columns[8].Name = "RETURN";
            grid_DeliveryOS.Columns[8].ReadOnly = true;
            grid_DeliveryOS.Columns[8].Width = 80;
            grid_DeliveryOS.Columns[8].MinimumWidth = 80;
            grid_DeliveryOS.Columns[8].DefaultCellStyle.Format = "N2";
            grid_DeliveryOS.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DeliveryOS.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DeliveryOS.Columns[8].DataPropertyName = "RT";

            grid_DeliveryOS.Columns[9].Name = "NETDELIVERY";
            grid_DeliveryOS.Columns[9].ReadOnly = true;
            grid_DeliveryOS.Columns[9].Width = 80;
            grid_DeliveryOS.Columns[9].MinimumWidth = 80;
            grid_DeliveryOS.Columns[9].DefaultCellStyle.Format = "N2";
            grid_DeliveryOS.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DeliveryOS.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DeliveryOS.Columns[9].DataPropertyName = "NETDELIVERY";

            grid_DeliveryOS.Columns[10].Name = "DELIVERY DIFFERENCE";
            grid_DeliveryOS.Columns[10].ReadOnly = true;
            grid_DeliveryOS.Columns[10].Width = 80;
            grid_DeliveryOS.Columns[10].MinimumWidth = 80;
            grid_DeliveryOS.Columns[10].DefaultCellStyle.Format = "N2";
            grid_DeliveryOS.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DeliveryOS.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DeliveryOS.Columns[10].DataPropertyName = "DELIVERYDIFF";

            grid_DeliveryOS.Columns[11].Name = "DRIVER NAME";
            grid_DeliveryOS.Columns[11].ReadOnly = true;
            grid_DeliveryOS.Columns[11].Width = 80;
            grid_DeliveryOS.Columns[11].MinimumWidth = 80;
            grid_DeliveryOS.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_DeliveryOS.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_DeliveryOS.Columns[11].DataPropertyName = "DriverName";

            //grid font size custom
            grid_DeliveryOS.RowTemplate.Height = 20;
            grid_DeliveryOS.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_DeliveryOS.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            //for (int i = 0; i < grid_DeliveryOS.ColumnCount; i++)
            //{
            //    grid_DeliveryOS.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            //}

            grid_DeliveryOS.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            grid_DeliveryOS.DataSource = null;
            String DeliveryNubmer = txt_DeliveryNumber.Text.Trim();
            String CustomerID = txt_CustomerID.Text.Trim();
            String SalesRep = cbx_SalesRep.Text.Trim();
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime ToDate = DateTimePickerTo.Value.Date;
            connSalesOrder.sp_DeliveryOS_Report(grid_DeliveryOS, FromDate, ToDate, DeliveryNubmer, SalesRep, CustomerID);

            
            //try
            //{
            //    DataTable dataTable = (DataTable)grid_DeliveryOS.DataSource;

            //    decimal TOTALDELIVERY = 0, TOTALDAMAGE = 0, TOTALMISSING = 0, TOTALNOTIN = 0, TOTALRETURN = 0, TOTALNETDELIVERY = 0, TOTALDIFF = 0;

            //    for (int i = 0; i < grid_DeliveryOS.RowCount; i++)
            //    {
            //        TOTALDELIVERY += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["DELIVERY"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["DELIVERY"].Value);
            //        TOTALDAMAGE += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["DAMAGED"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["DAMAGED"].Value);
            //        TOTALMISSING += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["MISSING"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["MISSING"].Value);
            //        TOTALNOTIN += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["NOT IN"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["NOT IN"].Value);
            //        TOTALRETURN += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["RETURN"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["RETURN"].Value);
            //        TOTALNETDELIVERY += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["NETDELIVERY"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["NETDELIVERY"].Value);
            //        TOTALDIFF += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["DELIVERY DIFFERENCE"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["DELIVERY DIFFERENCE"].Value);
            //    }

            //    DataRow drToAdd = dataTable.NewRow();
            //    drToAdd["DeliveryNumber"] = "TOTAL";
            //    drToAdd["SaleRep"] = "";
            //    drToAdd["CustomerID"] = "";
            //    drToAdd["DELIVERY"] = TOTALDELIVERY.ToString();
            //    drToAdd["OrderDate"] = DBNull.Value;
            //    drToAdd["DAMAGED"] = TOTALDAMAGE.ToString();
            //    drToAdd["MISSING"] = TOTALMISSING.ToString();
            //    drToAdd["NOTIN"] = TOTALNOTIN.ToString();
            //    drToAdd["RT"] = TOTALRETURN.ToString();
            //    drToAdd["NETDELIVERY"] = TOTALNETDELIVERY.ToString();
            //    drToAdd["DELIVERYDIFF"] = TOTALDIFF.ToString();

            //    dataTable.Rows.Add(drToAdd);

            //    dataTable.AcceptChanges();

            //    this.grid_DeliveryOS.ClearSelection();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void grid_DeliveryOS_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //foreach (DataGridViewRow row in this.grid_DeliveryOS.Rows)
            //{
            //    if (row.Cells["DELIVERY NUMBER"].Value.Equals("TOTAL"))
            //    {
            //        for (int i = 0; i < grid_DeliveryOS.ColumnCount; i++)
            //        {
            //            row.Cells[i].Style.BackColor = Color.Gray;
            //            row.Cells[i].Style.ForeColor = Color.White;
            //        }
            //    }
            //}
            decimal TOTALDELIVERY = 0, TOTALDAMAGE = 0, TOTALMISSING = 0, TOTALNOTIN = 0, TOTALRETURN = 0, TOTALNETDELIVERY = 0, TOTALDIFF = 0;

            for (int i = 0; i < grid_DeliveryOS.RowCount; i++)
            {
                TOTALDELIVERY += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["DELIVERY"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["DELIVERY"].Value);
                TOTALDAMAGE += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["DAMAGED"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["DAMAGED"].Value);
                TOTALMISSING += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["MISSING"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["MISSING"].Value);
                TOTALNOTIN += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["NOT IN"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["NOT IN"].Value);
                TOTALRETURN += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["RETURN"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["RETURN"].Value);
                TOTALNETDELIVERY += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["NETDELIVERY"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["NETDELIVERY"].Value);
                TOTALDIFF += Convert.ToDecimal(grid_DeliveryOS.Rows[i].Cells["DELIVERY DIFFERENCE"].Value == DBNull.Value ? "0" : grid_DeliveryOS.Rows[i].Cells["DELIVERY DIFFERENCE"].Value);
            }

            txt_DeliveryT.Text = TOTALDELIVERY.ToString();
            txt_DamagedT.Text = TOTALDAMAGE.ToString();
            txt_MissingT.Text = TOTALMISSING.ToString();
            txt_NotInT.Text = TOTALNOTIN.ToString();
            txt_ReturnT.Text = TOTALRETURN.ToString();
            txt_NetDeliveryT.Text = TOTALNETDELIVERY.ToString();
            txt_DeliveryDiffT.Text = TOTALDIFF.ToString();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            String DeliveryNubmer = txt_DeliveryNumber.Text.Trim();
            String CustomerID = txt_CustomerID.Text.Trim();
            String SalesRep = cbx_SalesRep.Text.Trim();
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime ToDate = DateTimePickerTo.Value.Date;
            Rpt_DeliveryOS rpt_DeliveryOS = new Rpt_DeliveryOS(FromDate, ToDate, DeliveryNubmer, SalesRep, CustomerID);
            rpt_DeliveryOS.Show();
        }
    }
}
