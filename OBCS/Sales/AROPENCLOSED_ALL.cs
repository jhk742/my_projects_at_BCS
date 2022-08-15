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
    public partial class AROPENCLOSED_ALL : Form
    {
        public AROPENCLOSED_ALL()
        {
            InitializeComponent();
            grid_all_Init();
            connPO.cbox_getCustomerID(cbox_customer);
        }
        private void grid_all_Init()
        {
            grid_all.AutoGenerateColumns = false;
            grid_all.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_all.ColumnCount = 25;

            grid_all.Columns[0].Name = "Customer ID";
            grid_all.Columns[0].ReadOnly = true;
            grid_all.Columns[0].Width = 80;
            grid_all.Columns[0].MinimumWidth = 80;
            grid_all.Columns[0].DataPropertyName = "CustomerID";

            grid_all.Columns[1].Name = "Company Name";
            grid_all.Columns[1].ReadOnly = true;
            grid_all.Columns[1].Width = 150;
            grid_all.Columns[1].MinimumWidth = 150;
            grid_all.Columns[1].DataPropertyName = "CustomerName";

            grid_all.Columns[2].Name = "Rep";
            grid_all.Columns[2].ReadOnly = true;
            grid_all.Columns[2].Width = 30;
            grid_all.Columns[2].MinimumWidth = 30;
            grid_all.Columns[2].DataPropertyName = "SaleRep";

            grid_all.Columns[3].Name = "Invoice Number";
            grid_all.Columns[3].ReadOnly = true;
            grid_all.Columns[3].Width = 70;
            grid_all.Columns[3].MinimumWidth = 70;
            grid_all.Columns[3].DataPropertyName = "InvoiceNumber";

            grid_all.Columns[4].Name = "Invoice Date";
            grid_all.Columns[4].ReadOnly = true;
            grid_all.Columns[4].Width = 70;
            grid_all.Columns[4].MinimumWidth = 70;
            grid_all.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_all.Columns[4].DataPropertyName = "InvoiceDate";

            grid_all.Columns[5].Name = "Delivery Number";
            grid_all.Columns[5].ReadOnly = true;
            grid_all.Columns[5].Width = 90;
            grid_all.Columns[5].MinimumWidth = 90;
            grid_all.Columns[5].DataPropertyName = "DeliveryNumber";

            grid_all.Columns[6].Name = "Ship Date";
            grid_all.Columns[6].ReadOnly = true;
            grid_all.Columns[6].Width = 70;
            grid_all.Columns[6].MinimumWidth = 70;
            grid_all.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_all.Columns[6].DataPropertyName = "ShipDate";

            grid_all.Columns[7].Name = "Invoice Amount";
            grid_all.Columns[7].ReadOnly = true;
            grid_all.Columns[7].Width = 50;
            grid_all.Columns[7].DefaultCellStyle.Format = "N2";
            grid_all.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[7].MinimumWidth = 50;
            grid_all.Columns[7].DataPropertyName = "InvoiceAmount";

            grid_all.Columns[8].Name = "Credit Memo1";
            grid_all.Columns[8].ReadOnly = true;
            grid_all.Columns[8].Width = 50;
            grid_all.Columns[8].MinimumWidth = 50;
            grid_all.Columns[8].DefaultCellStyle.Format = "N2";
            grid_all.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[8].DataPropertyName = "Credit1Total";

            grid_all.Columns[9].Name = "Credit Memo2";
            grid_all.Columns[9].ReadOnly = true;
            grid_all.Columns[9].Width = 50;
            grid_all.Columns[9].MinimumWidth = 50;
            grid_all.Columns[9].DefaultCellStyle.Format = "N2";
            grid_all.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[9].DataPropertyName = "Credit2Total";

            grid_all.Columns[10].Name = "Credit Memo3";
            grid_all.Columns[10].ReadOnly = true;
            grid_all.Columns[10].Width = 50;
            grid_all.Columns[10].MinimumWidth = 50;
            grid_all.Columns[10].DefaultCellStyle.Format = "N2";
            grid_all.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[10].DataPropertyName = "Credit3Total";

            grid_all.Columns[11].Name = "Return";
            grid_all.Columns[11].ReadOnly = true;
            grid_all.Columns[11].Width = 50;
            grid_all.Columns[11].MinimumWidth = 50;
            grid_all.Columns[11].DefaultCellStyle.Format = "N2";
            grid_all.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[11].DataPropertyName = "ReturnCreditTotal";

            grid_all.Columns[12].Name = "Term Credit";
            grid_all.Columns[12].ReadOnly = true;
            grid_all.Columns[12].Width = 50;
            grid_all.Columns[12].MinimumWidth = 50;
            grid_all.Columns[12].DefaultCellStyle.Format = "N2";
            grid_all.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[12].DataPropertyName = "TermCreditTotal";

            grid_all.Columns[13].Name = "Short";
            grid_all.Columns[13].ReadOnly = true;
            grid_all.Columns[13].Width = 50;
            grid_all.Columns[13].MinimumWidth = 50;
            grid_all.Columns[13].DefaultCellStyle.Format = "N2";
            grid_all.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[13].DataPropertyName = "Short";

            grid_all.Columns[14].Name = "Temp Short";
            grid_all.Columns[14].Visible = false;
            grid_all.Columns[14].Width = 50;
            grid_all.Columns[14].MinimumWidth = 50;
            grid_all.Columns[14].DefaultCellStyle.Format = "N2";
            grid_all.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[14].DataPropertyName = "TempShort";

            grid_all.Columns[15].Name = "Over Payment Amount";
            grid_all.Columns[15].ReadOnly = true;
            grid_all.Columns[15].Width = 50;
            grid_all.Columns[15].MinimumWidth = 50;
            grid_all.Columns[15].DefaultCellStyle.Format = "N2";
            grid_all.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[15].DataPropertyName = "OverPaymentTotal";

            grid_all.Columns[16].Name = "Paid Amount";
            grid_all.Columns[16].ReadOnly = true;
            grid_all.Columns[16].Width = 50;
            grid_all.Columns[16].MinimumWidth = 50;
            grid_all.Columns[16].DefaultCellStyle.Format = "N2";
            grid_all.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[16].DataPropertyName = "PaymentAmount";

            grid_all.Columns[17].Name = "Open A/R";
            grid_all.Columns[17].ReadOnly = true;
            grid_all.Columns[17].Width = 50;
            grid_all.Columns[17].MinimumWidth = 50;
            grid_all.Columns[17].DefaultCellStyle.Format = "N2";
            grid_all.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[17].DataPropertyName = "OpenAR";

            grid_all.Columns[18].Name = "Post Check Payment";
            grid_all.Columns[18].ReadOnly = true;
            grid_all.Columns[18].Width = 50;
            grid_all.Columns[18].MinimumWidth = 50;
            grid_all.Columns[18].DefaultCellStyle.Format = "N2";
            grid_all.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[18].DataPropertyName = "PostCheckPayment";

            grid_all.Columns[19].Name = "Settled Amount";
            grid_all.Columns[19].ReadOnly = true;
            grid_all.Columns[19].Width = 50;
            grid_all.Columns[19].MinimumWidth = 50;
            grid_all.Columns[19].DefaultCellStyle.Format = "N2";
            grid_all.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[19].DataPropertyName = "SettledAmount";

            grid_all.Columns[20].Name = "Last Check Number";
            grid_all.Columns[20].ReadOnly = true;
            grid_all.Columns[20].Width = 40;
            grid_all.Columns[20].MinimumWidth = 40;
            grid_all.Columns[20].DataPropertyName = "LastCheckNumber";

            grid_all.Columns[21].Name = "Last Check Amount";
            grid_all.Columns[21].ReadOnly = true;
            grid_all.Columns[21].Width = 50;
            grid_all.Columns[21].MinimumWidth = 50;
            grid_all.Columns[21].DefaultCellStyle.Format = "N2";
            grid_all.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_all.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid_all.Columns[22].Name = "Last Payment Date";
            grid_all.Columns[22].Visible = false;
            grid_all.Columns[22].Width = 60;
            grid_all.Columns[22].MinimumWidth = 60;
            grid_all.Columns[22].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_all.Columns[22].DataPropertyName = "LastPaymentDate";

            grid_all.Columns[23].Name = "Last Check Date";
            grid_all.Columns[23].ReadOnly = true;
            grid_all.Columns[23].Width = 60;
            grid_all.Columns[23].MinimumWidth = 60;
            grid_all.Columns[23].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_all.Columns[23].DataPropertyName = "LastPaymentDate";
            
            grid_all.Columns[24].Name = "Ref. Doc. No.";
            grid_all.Columns[24].ReadOnly = true;
            grid_all.Columns[24].Width = 90;
            grid_all.Columns[24].MinimumWidth = 90;
            grid_all.Columns[24].DataPropertyName = "RefDocNumber";
           


            //grid font size custom
            grid_all.RowTemplate.Height = 20;
            grid_all.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_all.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_all.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime ToDate = DateTimePickerTo.Value.Date;
            string Customer = cbox_customer.Text.Trim();
            connSalesOrder.sp_AROPENCLOSE_ALL(grid_all, FromDate, ToDate, cbox_customer.Text);
        }

        private void btn_statement_Click(object sender, EventArgs e)
        {
            DateTime FromDate = DateTimePickerFrom.Value.Date;
            DateTime ToDate = DateTimePickerTo.Value.Date;
            string CustomerID = cbox_customer.Text.Trim();
            Reports.Rpt_AROPENCLOSED_ALL aROPENCLOSED_ALL = new Reports.Rpt_AROPENCLOSED_ALL(FromDate, ToDate, CustomerID);
            //salesReport.MdiParent = this.MdiParent;
            aROPENCLOSED_ALL.Show();
        }
    }
}
