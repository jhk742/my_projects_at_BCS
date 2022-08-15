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
    public partial class IPADORDER_SHORTAGE_Form : Form
    {
        public IPADORDER_SHORTAGE_Form()
        {
            InitializeComponent();
            grid_IPadOrderDIFF_Init();
            //dateTimePickerFrom.Value = DateTime.Today.AddDays(-1);
        }
        private void grid_IPadOrderDIFF_Init()
        {
            grid_Shortage.AutoGenerateColumns = false;
            grid_Shortage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Shortage.ColumnCount = 11;

            grid_Shortage.Columns[0].Name = "Type";
            grid_Shortage.Columns[0].Visible = true;
            grid_Shortage.Columns[0].Width = 30;
            grid_Shortage.Columns[0].MinimumWidth = 30;
            grid_Shortage.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Shortage.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Shortage.Columns[0].DataPropertyName = "Type";

            grid_Shortage.Columns[1].Name = "Product ID";
            grid_Shortage.Columns[1].Visible = true;
            grid_Shortage.Columns[1].Width = 60;
            grid_Shortage.Columns[1].MinimumWidth = 60;
            grid_Shortage.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Shortage.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Shortage.Columns[1].DataPropertyName = "ProductID";

            grid_Shortage.Columns[2].Name = "Description";
            grid_Shortage.Columns[2].ReadOnly = true;
            grid_Shortage.Columns[2].Width = 180;
            grid_Shortage.Columns[2].MinimumWidth = 180;
            grid_Shortage.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Shortage.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Shortage.Columns[2].DataPropertyName = "ProductDesc";

            grid_Shortage.Columns[3].Name = "Pack Size";
            grid_Shortage.Columns[3].ReadOnly = true;
            grid_Shortage.Columns[3].Width = 70;
            grid_Shortage.Columns[3].MinimumWidth = 70;
            grid_Shortage.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Shortage.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Shortage.Columns[3].DataPropertyName = "StrPackSize";

            grid_Shortage.Columns[4].Name = "WH QTY";
            grid_Shortage.Columns[4].ReadOnly = true;
            grid_Shortage.Columns[4].Width = 50;
            grid_Shortage.Columns[4].MinimumWidth = 50;
            grid_Shortage.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Shortage.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Shortage.Columns[4].DefaultCellStyle.Format = "N2";
            grid_Shortage.Columns[4].DataPropertyName = "PHYQTYWH";

            grid_Shortage.Columns[5].Name = "PHYQTY";
            grid_Shortage.Columns[5].ReadOnly = true;
            grid_Shortage.Columns[5].Width = 50;
            grid_Shortage.Columns[5].MinimumWidth = 50;
            grid_Shortage.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Shortage.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Shortage.Columns[5].DefaultCellStyle.Format = "N2";
            grid_Shortage.Columns[5].DataPropertyName = "PHYQTY";

            grid_Shortage.Columns[6].Name = "GLOALL";
            grid_Shortage.Columns[6].ReadOnly = true;
            grid_Shortage.Columns[6].Width = 50;
            grid_Shortage.Columns[6].MinimumWidth = 50;
            grid_Shortage.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Shortage.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Shortage.Columns[6].DefaultCellStyle.Format = "N2";
            grid_Shortage.Columns[6].DataPropertyName = "GLOALL";

            grid_Shortage.Columns[7].Name = "DETAILED";
            grid_Shortage.Columns[7].ReadOnly = true;
            grid_Shortage.Columns[7].Width = 50;
            grid_Shortage.Columns[7].MinimumWidth = 50;
            grid_Shortage.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Shortage.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Shortage.Columns[7].DefaultCellStyle.Format = "N2";
            grid_Shortage.Columns[7].DataPropertyName = "DETAILED";

            grid_Shortage.Columns[8].Name = "OS QTY";
            grid_Shortage.Columns[8].ReadOnly = true;
            grid_Shortage.Columns[8].Width = 50;
            grid_Shortage.Columns[8].MinimumWidth = 50;
            grid_Shortage.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Shortage.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Shortage.Columns[8].DefaultCellStyle.Format = "N2";
            grid_Shortage.Columns[8].DataPropertyName = "OS_QTY";

            grid_Shortage.Columns[9].Name = "OS AMOUNT";
            grid_Shortage.Columns[9].ReadOnly = true;
            grid_Shortage.Columns[9].Width = 70;
            grid_Shortage.Columns[9].MinimumWidth = 70;
            grid_Shortage.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Shortage.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Shortage.Columns[9].DataPropertyName = "OS_AMT";

            grid_Shortage.Columns[10].Name = "Status";
            grid_Shortage.Columns[10].ReadOnly = true;
            grid_Shortage.Columns[10].Width = 50;
            grid_Shortage.Columns[10].MinimumWidth = 50;
            grid_Shortage.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Shortage.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Shortage.Columns[10].DataPropertyName = "Status";

            //grid font size custom
            grid_Shortage.RowTemplate.Height = 20;
            grid_Shortage.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_Shortage.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_Shortage.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;

            connSalesOrder.sp_IPAD_ORDER_DIFF(grid_Shortage, FromDate, ToDate);
            if (grid_Shortage.RowCount == 0)
            {
                txt_IPADAmt.Text = "0";
                txt_ORDERAmt.Text = "0";
            }
            else
            {
                connSalesOrder.sp_IPAD_ORDER_DIFF_TOTAL_AMOUNT(FromDate, ToDate, txt_IPADAmt, txt_ORDERAmt);
            }

        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            Reports.Rpt_IPADORDER_SHORTAGE iPADORDER_SHORTAGE = new Reports.Rpt_IPADORDER_SHORTAGE(FromDate, ToDate);
            iPADORDER_SHORTAGE.Show();
        }

        private void grid_Shortage_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            decimal OS_QTY = 0, OS_AMT = 0;
            for (int i = 0; i < grid_Shortage.RowCount; i++)
            {
                grid_Shortage.Rows[i].Cells["OS QTY"].Style.BackColor = Color.OldLace;
                grid_Shortage.Rows[i].Cells["OS AMOUNT"].Style.BackColor = Color.OldLace;
                OS_QTY += Convert.ToDecimal(grid_Shortage.Rows[i].Cells["OS QTY"].Value == DBNull.Value ? "0" : grid_Shortage.Rows[i].Cells["OS QTY"].Value);
                OS_AMT += Convert.ToDecimal(grid_Shortage.Rows[i].Cells["OS AMOUNT"].Value == DBNull.Value ? "0" : grid_Shortage.Rows[i].Cells["OS AMOUNT"].Value);
            }
            txt_TotalOSQty.Text = OS_QTY.ToString();
            txt_TotalOSAmt.Text = OS_AMT.ToString();
        }
    }
}
