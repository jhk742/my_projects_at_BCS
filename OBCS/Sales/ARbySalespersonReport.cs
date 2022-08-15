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
    public partial class ARbySalespersonReport : Form
    {
        public ARbySalespersonReport()
        {
            InitializeComponent();
            grid_ARLIST_Init();
            connPO.cbox_BPSaleRep(cbo_SaleRep);


        }
        private void grid_ARLIST_Init()
        {
            grid_ARLIST.AutoGenerateColumns = false;
            grid_ARLIST.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_ARLIST.ColumnCount = 21;

            grid_ARLIST.Columns[0].Name = "Customer ID";
            grid_ARLIST.Columns[0].ReadOnly = true;
            grid_ARLIST.Columns[0].Width = 80;
            grid_ARLIST.Columns[0].MinimumWidth = 80;
            grid_ARLIST.Columns[0].DataPropertyName = "CustomerID";

            grid_ARLIST.Columns[1].Name = "Company Name";
            grid_ARLIST.Columns[1].ReadOnly = true;
            grid_ARLIST.Columns[1].Width = 150;
            grid_ARLIST.Columns[1].MinimumWidth = 150;
            grid_ARLIST.Columns[1].DataPropertyName = "CustomerName";

            grid_ARLIST.Columns[2].Name = "Rep";
            grid_ARLIST.Columns[2].ReadOnly = true;
            grid_ARLIST.Columns[2].Width = 30;
            grid_ARLIST.Columns[2].MinimumWidth = 30;
            grid_ARLIST.Columns[2].DataPropertyName = "SaleRep";

            grid_ARLIST.Columns[3].Name = "Invoice Number";
            grid_ARLIST.Columns[3].ReadOnly = true;
            grid_ARLIST.Columns[3].Width = 70;
            grid_ARLIST.Columns[3].MinimumWidth = 70;
            grid_ARLIST.Columns[3].DataPropertyName = "InvoiceNumber";

            grid_ARLIST.Columns[4].Name = "Invoice Date";
            grid_ARLIST.Columns[4].ReadOnly = true;
            grid_ARLIST.Columns[4].Width = 70;
            grid_ARLIST.Columns[4].MinimumWidth = 70;
            grid_ARLIST.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_ARLIST.Columns[4].DataPropertyName = "InvoiceDate";

            grid_ARLIST.Columns[5].Name = "Delivery Number";
            grid_ARLIST.Columns[5].ReadOnly = true;
            grid_ARLIST.Columns[5].Width = 90;
            grid_ARLIST.Columns[5].MinimumWidth = 90;
            grid_ARLIST.Columns[5].DataPropertyName = "DeliveryNumber";

            grid_ARLIST.Columns[6].Name = "Ship Date";
            grid_ARLIST.Columns[6].ReadOnly = true;
            grid_ARLIST.Columns[6].Width = 70;
            grid_ARLIST.Columns[6].MinimumWidth = 70;
            grid_ARLIST.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_ARLIST.Columns[6].DataPropertyName = "ShipDate";

            grid_ARLIST.Columns[7].Name = "Invoice Amount";
            grid_ARLIST.Columns[7].ReadOnly = true;
            grid_ARLIST.Columns[7].Width = 50;
            grid_ARLIST.Columns[7].DefaultCellStyle.Format = "N2";
            grid_ARLIST.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[7].MinimumWidth = 50;
            grid_ARLIST.Columns[7].DataPropertyName = "InvoiceAmount";

            grid_ARLIST.Columns[8].Name = "Credit Memo1";
            grid_ARLIST.Columns[8].ReadOnly = true;
            grid_ARLIST.Columns[8].Width = 50;
            grid_ARLIST.Columns[8].MinimumWidth = 50;
            grid_ARLIST.Columns[8].DefaultCellStyle.Format = "N2";
            grid_ARLIST.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[8].DataPropertyName = "Credit1Total";

            grid_ARLIST.Columns[9].Name = "Credit Memo2";
            grid_ARLIST.Columns[9].ReadOnly = true;
            grid_ARLIST.Columns[9].Width = 50;
            grid_ARLIST.Columns[9].MinimumWidth = 50;
            grid_ARLIST.Columns[9].DefaultCellStyle.Format = "N2";
            grid_ARLIST.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[9].DataPropertyName = "Credit2Total";

            grid_ARLIST.Columns[10].Name = "Credit Memo3";
            grid_ARLIST.Columns[10].ReadOnly = true;
            grid_ARLIST.Columns[10].Width = 50;
            grid_ARLIST.Columns[10].MinimumWidth = 50;
            grid_ARLIST.Columns[10].DefaultCellStyle.Format = "N2";
            grid_ARLIST.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[10].DataPropertyName = "Credit3Total";

            grid_ARLIST.Columns[11].Name = "Return";
            grid_ARLIST.Columns[11].ReadOnly = true;
            grid_ARLIST.Columns[11].Width = 50;
            grid_ARLIST.Columns[11].MinimumWidth = 50;
            grid_ARLIST.Columns[11].DefaultCellStyle.Format = "N2";
            grid_ARLIST.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[11].DataPropertyName = "ReturnCreditTotal";

            grid_ARLIST.Columns[12].Name = "Term Credit";
            grid_ARLIST.Columns[12].ReadOnly = true;
            grid_ARLIST.Columns[12].Width = 50;
            grid_ARLIST.Columns[12].MinimumWidth = 50;
            grid_ARLIST.Columns[12].DefaultCellStyle.Format = "N2";
            grid_ARLIST.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[12].DataPropertyName = "TermCreditTotal";

            grid_ARLIST.Columns[13].Name = "Short";
            grid_ARLIST.Columns[13].ReadOnly = true;
            grid_ARLIST.Columns[13].Width = 50;
            grid_ARLIST.Columns[13].MinimumWidth = 50;
            grid_ARLIST.Columns[13].DefaultCellStyle.Format = "N2";
            grid_ARLIST.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[13].DataPropertyName = "Short";

            grid_ARLIST.Columns[14].Name = "Temp Short";
            grid_ARLIST.Columns[14].Visible = false;
            grid_ARLIST.Columns[14].Width = 50;
            grid_ARLIST.Columns[14].MinimumWidth = 50;
            grid_ARLIST.Columns[14].DefaultCellStyle.Format = "N2";
            grid_ARLIST.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[14].DataPropertyName = "TempShort";

            grid_ARLIST.Columns[15].Name = "Over Payment";
            grid_ARLIST.Columns[15].ReadOnly = true;
            grid_ARLIST.Columns[15].Width = 50;
            grid_ARLIST.Columns[15].MinimumWidth = 50;
            grid_ARLIST.Columns[15].DefaultCellStyle.Format = "N2";
            grid_ARLIST.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[15].DataPropertyName = "OverPaymentTotal";

            grid_ARLIST.Columns[16].Name = "Paid Amount";
            grid_ARLIST.Columns[16].ReadOnly = true;
            grid_ARLIST.Columns[16].Width = 50;
            grid_ARLIST.Columns[16].MinimumWidth = 50;
            grid_ARLIST.Columns[16].DefaultCellStyle.Format = "N2";
            grid_ARLIST.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[16].DataPropertyName = "PaymentAmount";

            grid_ARLIST.Columns[17].Name = "Write-off Amount";
            grid_ARLIST.Columns[17].ReadOnly = true;
            grid_ARLIST.Columns[17].Width = 50;
            grid_ARLIST.Columns[17].MinimumWidth = 50;
            grid_ARLIST.Columns[17].DefaultCellStyle.Format = "N2";
            grid_ARLIST.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[17].DataPropertyName = "WriteOffTotal";

            grid_ARLIST.Columns[18].Name = "Open A/R";
            grid_ARLIST.Columns[18].ReadOnly = true;
            grid_ARLIST.Columns[18].Width = 50;
            grid_ARLIST.Columns[18].MinimumWidth = 50;
            grid_ARLIST.Columns[18].DefaultCellStyle.Format = "N2";
            grid_ARLIST.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[18].DataPropertyName = "OpenAR";

            grid_ARLIST.Columns[19].Name = "Post Check Payment";
            grid_ARLIST.Columns[19].ReadOnly = true;
            grid_ARLIST.Columns[19].Width = 50;
            grid_ARLIST.Columns[19].MinimumWidth = 50;
            grid_ARLIST.Columns[19].DefaultCellStyle.Format = "N2";
            grid_ARLIST.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[19].DataPropertyName = "PostCheckPayment";

            grid_ARLIST.Columns[20].Name = "Settled Amount";
            grid_ARLIST.Columns[20].ReadOnly = true;
            grid_ARLIST.Columns[20].Width = 70;
            grid_ARLIST.Columns[20].MinimumWidth = 70;
            grid_ARLIST.Columns[20].DefaultCellStyle.Format = "N2";
            grid_ARLIST.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ARLIST.Columns[20].DataPropertyName = "SettledAmount";

            //grid_ARLIST.Columns[19].Name = "Last Check Number";
            //grid_ARLIST.Columns[19].ReadOnly = true;
            //grid_ARLIST.Columns[19].Width = 40;
            //grid_ARLIST.Columns[19].MinimumWidth = 40;
            //grid_ARLIST.Columns[19].DataPropertyName = "LastCheckNumber";

            //grid_ARLIST.Columns[20].Name = "Last Check Amount";
            //grid_ARLIST.Columns[20].ReadOnly = true;
            //grid_ARLIST.Columns[20].Width = 50;
            //grid_ARLIST.Columns[20].MinimumWidth = 50;
            //grid_ARLIST.Columns[20].DefaultCellStyle.Format = "N2";
            //grid_ARLIST.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //grid_ARLIST.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //grid_ARLIST.Columns[20].DataPropertyName = "LastPaymentAmount";

            //grid_ARLIST.Columns[21].Name = "Last Payment Date";
            //grid_ARLIST.Columns[21].ReadOnly = true;
            //grid_ARLIST.Columns[21].Width = 60;
            //grid_ARLIST.Columns[21].MinimumWidth = 60;
            //grid_ARLIST.Columns[21].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            //grid_ARLIST.Columns[21].DataPropertyName = "LastPaymentDate";

            //grid_ARLIST.Columns[22].Name = "Last Check Date";
            //grid_ARLIST.Columns[22].ReadOnly = true;
            //grid_ARLIST.Columns[22].Width = 60;
            //grid_ARLIST.Columns[22].MinimumWidth = 60;
            //grid_ARLIST.Columns[22].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            //grid_ARLIST.Columns[22].DataPropertyName = "LastPaymentDate";

            //grid_ARLIST.Columns[23].Name = "Ref. Doc. No.";
            //grid_ARLIST.Columns[23].Visible = false;
            //grid_ARLIST.Columns[23].Width = 90;
            //grid_ARLIST.Columns[23].MinimumWidth = 90;
            //grid_ARLIST.Columns[23].DataPropertyName = "RefDocNumber";

            //grid_ARLIST.Columns[24].Name = "Driver";
            //grid_ARLIST.Columns[24].ReadOnly = true;
            //grid_ARLIST.Columns[24].Width = 80;
            //grid_ARLIST.Columns[24].MinimumWidth = 80;
            //grid_ARLIST.Columns[24].DataPropertyName = "DriverName";

            //grid_ARLIST.Columns[25].Name = "Route Number";
            //grid_ARLIST.Columns[25].ReadOnly = true;
            //grid_ARLIST.Columns[25].Width = 40;
            //grid_ARLIST.Columns[25].MinimumWidth = 40;
            //grid_ARLIST.Columns[25].DataPropertyName = "RouteNumber";

            //grid_ARLIST.Columns[26].Name = "Entry Batch";
            //grid_ARLIST.Columns[26].ReadOnly = true;
            //grid_ARLIST.Columns[26].Width = 60;
            //grid_ARLIST.Columns[26].MinimumWidth = 60;
            //grid_ARLIST.Columns[26].DataPropertyName = "EntryBatch";

            //grid font size custom
            grid_ARLIST.RowTemplate.Height = 20;
            grid_ARLIST.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_ARLIST.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_ARLIST.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            string SaleRep = cbo_SaleRep.Text.Trim();
            connSalesOrder.sp_ARLIST_SaleRep(grid_ARLIST, SaleRep);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            string SaleRep = cbo_SaleRep.Text.Trim();
            Reports.Rpt_ARLIST_SaleRep aRLIST_SaleRep = new Reports.Rpt_ARLIST_SaleRep(SaleRep);
            //salesReport.MdiParent = this.MdiParent;
            aRLIST_SaleRep.Show();
        }
    }
}
