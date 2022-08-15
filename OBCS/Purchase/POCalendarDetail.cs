using OBCS.Tools;
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
    public partial class POCalendarDetail : Form
    {
        public POCalendarDetail(String PONumber, int day)
        {
            InitializeComponent();
            grid_POReceptionDEtail_Init();

            txt_PONumber.Text = PONumber;
            txt_SupplierName.Text = connPO.GET_SupplierID_by_PONumber(PONumber);
            text_receptionDate.Text = customCalendar.static_month + "/" + day + "/" + customCalendar.static_year;

            connPO.sp_PoCalendarREALDetail(grid_POReceptionDetail, PONumber);
            
        }

        private void grid_POReceptionDEtail_Init()
        {
            grid_POReceptionDetail.AutoGenerateColumns = false;
            grid_POReceptionDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_POReceptionDetail.ColumnCount = 7;

            grid_POReceptionDetail.Columns[0].Name = "PO #";
            grid_POReceptionDetail.Columns[0].ReadOnly = true;
            grid_POReceptionDetail.Columns[0].Width = 10;
            grid_POReceptionDetail.Columns[0].MinimumWidth = 10;
            grid_POReceptionDetail.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POReceptionDetail.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POReceptionDetail.Columns[0].DataPropertyName = "POHNUM_0";

            grid_POReceptionDetail.Columns[1].Name = "Product ID";
            grid_POReceptionDetail.Columns[1].ReadOnly = true;
            grid_POReceptionDetail.Columns[1].Width = 12;
            grid_POReceptionDetail.Columns[1].MinimumWidth = 12;
            grid_POReceptionDetail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POReceptionDetail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POReceptionDetail.Columns[1].DataPropertyName = "ITMREF_0";

            grid_POReceptionDetail.Columns[2].Name = "Product Desc";
            grid_POReceptionDetail.Columns[2].ReadOnly = true;
            grid_POReceptionDetail.Columns[2].Width = 60;
            grid_POReceptionDetail.Columns[2].MinimumWidth = 50;
            grid_POReceptionDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POReceptionDetail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POReceptionDetail.Columns[2].DataPropertyName = "ITMDES1_0";

            grid_POReceptionDetail.Columns[3].Name = "Brand Name";
            grid_POReceptionDetail.Columns[3].ReadOnly = true;
            grid_POReceptionDetail.Columns[3].Width = 60;
            grid_POReceptionDetail.Columns[3].MinimumWidth = 50;
            grid_POReceptionDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POReceptionDetail.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POReceptionDetail.Columns[3].DataPropertyName = "BrandName";

            grid_POReceptionDetail.Columns[4].Name = "Ordered Quantity";
            grid_POReceptionDetail.Columns[4].ReadOnly = true;
            grid_POReceptionDetail.Columns[4].Width = 15;
            grid_POReceptionDetail.Columns[4].MinimumWidth = 10;
            grid_POReceptionDetail.Columns[4].DefaultCellStyle.Format = "N2";
            grid_POReceptionDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceptionDetail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceptionDetail.Columns[4].DataPropertyName = "QTY_0";

            grid_POReceptionDetail.Columns[5].Name = "Product Price";
            grid_POReceptionDetail.Columns[5].ReadOnly = true;
            grid_POReceptionDetail.Columns[5].Width = 15;
            grid_POReceptionDetail.Columns[5].MinimumWidth = 20;
            grid_POReceptionDetail.Columns[5].DefaultCellStyle.Format = "N2";
            grid_POReceptionDetail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceptionDetail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceptionDetail.Columns[5].DataPropertyName = "GROPRI_0";

            grid_POReceptionDetail.Columns[6].Name = "Ordered Amount";
            grid_POReceptionDetail.Columns[6].ReadOnly = true;
            grid_POReceptionDetail.Columns[6].Width = 200;
            grid_POReceptionDetail.Columns[6].MinimumWidth = 180;
            grid_POReceptionDetail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_POReceptionDetail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceptionDetail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceptionDetail.Columns[6].DataPropertyName = "OrderAmount";

            grid_POReceptionDetail.RowTemplate.Height = 20;
            grid_POReceptionDetail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_POReceptionDetail.Columns)
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            grid_POReceptionDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_POReceptionDetail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Close the form?", "Exit Application Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
