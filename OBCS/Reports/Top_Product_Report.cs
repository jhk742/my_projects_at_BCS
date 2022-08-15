using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Reports
{
    public partial class Top_Product_Report : Form
    {
        public Top_Product_Report()
        {
            InitializeComponent();
            connSalesOrder.cbo_salesRep(cbo_Salerep);
            String ProductID = txt_ProductID.Text.Trim();
            String Salerep = cbo_Salerep.Text.Trim();
            DateTimePickerFrom.Value = DateTime.Today.AddDays(-7);
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime ToDate = DateTimePickerTo.Value.Date;
            grid_Summary_Init();
            grid_detail_Init();

            //connSalesOrder.sp_Top_Product_Summary(grid_Top_Summary, ProductID, FromDate, ToDate);
        }
        private void grid_Summary_Init()
        {
            grid_Top_Summary.AutoGenerateColumns = false;
            grid_Top_Summary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Top_Summary.ColumnCount = 4;
            
            grid_Top_Summary.Columns[0].Name = "Item ID";
            grid_Top_Summary.Columns[0].ReadOnly = true;
            grid_Top_Summary.Columns[0].Width = 50;
            grid_Top_Summary.Columns[0].MinimumWidth = 50;
            grid_Top_Summary.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_Summary.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_Summary.Columns[0].DataPropertyName = "ITMREF_0";

            grid_Top_Summary.Columns[1].Name = "Current Bottom Price";
            grid_Top_Summary.Columns[1].ReadOnly = true;
            grid_Top_Summary.Columns[1].Width = 70;
            grid_Top_Summary.Columns[1].MinimumWidth = 70;
            grid_Top_Summary.Columns[1].DefaultCellStyle.Format = "N2";
            grid_Top_Summary.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_Summary.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_Summary.Columns[1].DataPropertyName = "CurrentUnitPr";

            grid_Top_Summary.Columns[2].Name = "Qty";
            grid_Top_Summary.Columns[2].ReadOnly = true;
            grid_Top_Summary.Columns[2].Width = 70;
            grid_Top_Summary.Columns[2].MinimumWidth = 70;
            grid_Top_Summary.Columns[2].DefaultCellStyle.Format = "N2";
            grid_Top_Summary.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_Summary.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_Summary.Columns[2].DataPropertyName = "TotalQty";

            grid_Top_Summary.Columns[3].Name = "Amount";
            grid_Top_Summary.Columns[3].ReadOnly = true;
            grid_Top_Summary.Columns[3].Width = 70;
            grid_Top_Summary.Columns[3].MinimumWidth = 70;
            grid_Top_Summary.Columns[3].DefaultCellStyle.Format = "N2";
            grid_Top_Summary.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_Summary.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_Summary.Columns[3].DataPropertyName = "TotalAmount";
            
            //grid_Top_Summary.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            //grid_Top_Summary.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            //grid_Top_Summary.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            //grid_Top_Summary.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            //radio button click시 사용
            //this.grid_LastPriceOfVendor.Sort(this.grid_LastPriceOfVendor.Columns["OrdDate"], ListSortDirection.Descending);

            //this.grid_LastPriceOfVendor.ClearSelection();

            //grid font size custom
            grid_Top_Summary.RowTemplate.Height = 20;
            grid_Top_Summary.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_Top_Summary.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_Top_Summary.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void grid_detail_Init()
        {
            grid_Top_detail.AutoGenerateColumns = false;
            grid_Top_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Top_detail.ColumnCount = 8;

            grid_Top_detail.Columns[0].Name = "Rep";
            grid_Top_detail.Columns[0].ReadOnly = true;
            grid_Top_detail.Columns[0].Width = 25;
            grid_Top_detail.Columns[0].MinimumWidth = 25;
            grid_Top_detail.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[0].DataPropertyName = "REP1_0";

            grid_Top_detail.Columns[1].Name = "Item ID";
            grid_Top_detail.Columns[1].ReadOnly = true;
            grid_Top_detail.Columns[1].Width = 60;
            grid_Top_detail.Columns[1].MinimumWidth = 60;
            grid_Top_detail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[1].DataPropertyName = "ITMREF_0";

            grid_Top_detail.Columns[2].Name = "Description";
            grid_Top_detail.Columns[2].ReadOnly = true;
            grid_Top_detail.Columns[2].Width = 120;
            grid_Top_detail.Columns[2].MinimumWidth = 120;
            grid_Top_detail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[2].DataPropertyName = "ProductDesc";

            grid_Top_detail.Columns[3].Name = "InvoiceDate";
            grid_Top_detail.Columns[3].ReadOnly = true;
            grid_Top_detail.Columns[3].Width = 50;
            grid_Top_detail.Columns[3].MinimumWidth = 50;
            grid_Top_detail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[3].DataPropertyName = "INVDAT_0";

            grid_Top_detail.Columns[4].Name = "Customer";
            grid_Top_detail.Columns[4].ReadOnly = true;
            grid_Top_detail.Columns[4].Width = 55;
            grid_Top_detail.Columns[4].MinimumWidth = 55;
            grid_Top_detail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[4].DataPropertyName = "BPCINV_0";

            grid_Top_detail.Columns[5].Name = "Company";
            grid_Top_detail.Columns[5].ReadOnly = true;
            grid_Top_detail.Columns[5].Width = 80;
            grid_Top_detail.Columns[5].MinimumWidth = 80;
            grid_Top_detail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[5].DataPropertyName = "BPCNAM_0";

            grid_Top_detail.Columns[6].Name = "Qty";
            grid_Top_detail.Columns[6].ReadOnly = true;
            grid_Top_detail.Columns[6].Width = 50;
            grid_Top_detail.Columns[6].MinimumWidth = 50;
            grid_Top_detail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_Top_detail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[6].DataPropertyName = "QTY_0";

            grid_Top_detail.Columns[7].Name = "Amount";
            grid_Top_detail.Columns[7].ReadOnly = true;
            grid_Top_detail.Columns[7].Width = 70;
            grid_Top_detail.Columns[7].MinimumWidth = 70;
            grid_Top_detail.Columns[7].DefaultCellStyle.Format = "N2";
            grid_Top_detail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Top_detail.Columns[7].DataPropertyName = "AMTNOTLIN_0";

            //grid font size custom
            grid_Top_detail.RowTemplate.Height = 20;
            grid_Top_detail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_Top_detail.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_Top_detail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void Search_Function()
        {
            String ProductID = txt_ProductID.Text.Trim();
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime ToDate = DateTimePickerTo.Value.Date;
            String Salerep = cbo_Salerep.Text.Trim();
            if (rad_ShowAll.Checked) connSalesOrder.sp_Top_Product_Summary(grid_Top_Summary, ProductID, Salerep, FromDate, ToDate);
            else if (rad_Top20A.Checked) connSalesOrder.sp_Top20_Product_Summary(grid_Top_Summary, ProductID, Salerep, FromDate, ToDate, 2);
            else if (rad_Top20Q.Checked) connSalesOrder.sp_Top20_Product_Summary(grid_Top_Summary, ProductID, Salerep, FromDate, ToDate, 1);
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Search_Function();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime ToDate = DateTimePickerTo.Value.Date;
            String Salerep = cbo_Salerep.Text.Trim();
            string ProductID = grid_Top_Summary.CurrentRow.Cells["Item ID"].Value.ToString();

            Reports.Rpt_Top_Product_Report_Detail top_Product_Report_Detail = new Reports.Rpt_Top_Product_Report_Detail(ProductID, Salerep, FromDate, ToDate);
            top_Product_Report_Detail.Show();
        }

        private void btn_Summaryexport_Click(object sender, EventArgs e)
        {
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime ToDate = DateTimePickerTo.Value.Date;
            string ProductID = txt_ProductID.Text.Trim();
            String Salerep = cbo_Salerep.Text.Trim();
            int Type = 0;
            if (rad_ShowAll.Checked) Type = 0;
            else if (rad_Top20A.Checked) Type = 2;
            else if (rad_Top20Q.Checked) Type = 1;
            Reports.Rpt_Top_Product_Report_Summary top_Product_Report_Summary = new Reports.Rpt_Top_Product_Report_Summary(ProductID, Salerep, FromDate, ToDate,Type);
            top_Product_Report_Summary.Show();
        }

        private void grid_Top_Summary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ProductID = grid_Top_Summary.CurrentRow.Cells["Item ID"].Value.ToString();
            String Salerep = cbo_Salerep.Text.Trim();
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime ToDate = DateTimePickerTo.Value.Date;
            connSalesOrder.sp_Top_Product_Detail(grid_Top_detail, ProductID, Salerep, FromDate, ToDate);
        }

        private void txt_ProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Search_Function();
            }
        }

        private void cbo_Salerep_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_Function();
        }
    }
}
