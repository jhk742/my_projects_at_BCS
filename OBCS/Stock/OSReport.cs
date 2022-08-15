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
    public partial class OSReport : Form
    {
        public OSReport()
        {
            InitializeComponent();
            grid_salesReport_Init();
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-1);
        }

        private void grid_salesReport_Init()
        {
            grid_salesReport.AutoGenerateColumns = false;
            grid_salesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_salesReport.ColumnCount = 13;

            grid_salesReport.Columns[0].Name = "Type";
            grid_salesReport.Columns[0].ReadOnly = true;
            grid_salesReport.Columns[0].Width = 50;
            grid_salesReport.Columns[0].MinimumWidth = 50;
            grid_salesReport.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[0].DataPropertyName = "CdPackDeptTypeCode";

            grid_salesReport.Columns[1].Name = "ProductID";
            grid_salesReport.Columns[1].ReadOnly = true;
            grid_salesReport.Columns[1].Width = 70;
            grid_salesReport.Columns[1].MinimumWidth = 70;
            //grid_salesReport.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_salesReport.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[1].DataPropertyName = "ProductID";

            grid_salesReport.Columns[2].Name = "ProductDesc";
            grid_salesReport.Columns[2].ReadOnly = true;
            grid_salesReport.Columns[2].Width = 250;
            grid_salesReport.Columns[2].MinimumWidth = 250;
            grid_salesReport.Columns[2].DataPropertyName = "ProductDesc";

            grid_salesReport.Columns[3].Name = "PackSize";
            grid_salesReport.Columns[3].ReadOnly = true;
            grid_salesReport.Columns[3].Width = 80;
            grid_salesReport.Columns[3].MinimumWidth = 80;
            grid_salesReport.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[3].DataPropertyName = "StrPackSize";

            grid_salesReport.Columns[4].Name = "GLOBAL";
            grid_salesReport.Columns[4].ReadOnly = true;
            grid_salesReport.Columns[4].Width = 60;
            grid_salesReport.Columns[4].MinimumWidth = 60;
            grid_salesReport.Columns[4].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[4].DataPropertyName = "GLOALL";

            grid_salesReport.Columns[5].Name = "DETAIL";
            grid_salesReport.Columns[5].ReadOnly = true;
            grid_salesReport.Columns[5].Width = 60;
            grid_salesReport.Columns[5].MinimumWidth = 60;
            grid_salesReport.Columns[5].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[5].DataPropertyName = "DETAILED";

            grid_salesReport.Columns[6].Name = "PHYQTY";
            grid_salesReport.Columns[6].ReadOnly = true;
            grid_salesReport.Columns[6].Width = 70;
            grid_salesReport.Columns[6].MinimumWidth = 70;
            grid_salesReport.Columns[6].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[6].DataPropertyName = "PHYQTY";

            grid_salesReport.Columns[7].Name = "OrderQty";
            grid_salesReport.Columns[7].Visible = false;
            grid_salesReport.Columns[7].Width = 60;
            grid_salesReport.Columns[7].MinimumWidth = 60;
            grid_salesReport.Columns[7].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[7].DataPropertyName = "OrderQty";

            grid_salesReport.Columns[8].Name = "Price";
            grid_salesReport.Columns[8].Visible = false;
            grid_salesReport.Columns[8].Width = 70;
            grid_salesReport.Columns[8].MinimumWidth = 70;
            grid_salesReport.Columns[8].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[8].DataPropertyName = "Price";

            grid_salesReport.Columns[9].Name = "Amount";
            grid_salesReport.Columns[9].Visible = false;
            grid_salesReport.Columns[9].Width = 70;
            grid_salesReport.Columns[9].MinimumWidth = 70;
            grid_salesReport.Columns[9].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[9].DataPropertyName = "Amount";

            grid_salesReport.Columns[10].Name = "OSQty";
            grid_salesReport.Columns[10].ReadOnly = true;
            grid_salesReport.Columns[10].Width = 50;
            grid_salesReport.Columns[10].MinimumWidth = 50;
            grid_salesReport.Columns[10].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[10].DataPropertyName = "OSQty";

            grid_salesReport.Columns[11].Name = "Status";
            grid_salesReport.Columns[11].ReadOnly = true;
            grid_salesReport.Columns[11].Width = 50;
            grid_salesReport.Columns[11].MinimumWidth = 50;
            grid_salesReport.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[11].DataPropertyName = "Status";

            grid_salesReport.Columns[12].Name = "OrderDate";
            grid_salesReport.Columns[12].ReadOnly = true;
            grid_salesReport.Columns[12].Width = 90;
            grid_salesReport.Columns[12].MinimumWidth = 90;
            grid_salesReport.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[12].DataPropertyName = "OrderDate";
            

            
            //grid font size custom
            grid_salesReport.RowTemplate.Height = 20;
            grid_salesReport.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_salesReport.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_salesReport.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            //MessageBox.Show(date.ToString());
            connSalesOrder.sp_OSReport(grid_salesReport, FromDate, ToDate);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;

            Reports.Rpt_OSREPORT salesReport = new Reports.Rpt_OSREPORT(FromDate, ToDate);
            //salesReport.MdiParent = this.MdiParent;
            salesReport.Show();
        }

        
    }
}
