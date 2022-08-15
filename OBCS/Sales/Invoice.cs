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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
            grid_ORDER_Init();
            salesOrder_refresh();

            //connSalesOrder.cbo_site(cbo_site);
            cbo_site.Items.Add("BCS");
            cbo_site.Items.Add("NYC");
            cbo_site.Items.Add("HYD");
            cbo_site.Items.Add("CFI");
            cbo_site.Items.Add("NTM");
            cbo_site.Items.Add("NYF");

            cbo_invoiceType.Items.Add("DR");
            cbo_company.Items.Add("BIC");

            cbo_customerID.Items.Clear();
            connPO.cbox_getCustomerID(cbo_customerID);
            cbo_gl.Items.Add("12102");
            cbo_gl.Items.Add("70000");
            //cbo_gl.Items.Add("75000");

            connPO.cbox_getCustomerID(cbo_searchCustomerID);
        }

        private void grid_ORDER_Init()
        {
            grid_ORDER.AutoGenerateColumns = false;
            grid_ORDER.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_ORDER.ColumnCount = 12;

            grid_ORDER.Columns[0].Name = "No.";
            grid_ORDER.Columns[0].ReadOnly = true;
            grid_ORDER.Columns[0].Width = 40;
            grid_ORDER.Columns[0].MinimumWidth = 40;
            grid_ORDER.Columns[0].DataPropertyName = "";

            grid_ORDER.Columns[1].Name = "Site";
            grid_ORDER.Columns[1].ReadOnly = true;
            grid_ORDER.Columns[1].Width = 40;
            grid_ORDER.Columns[1].MinimumWidth = 40;
            grid_ORDER.Columns[1].DataPropertyName = "Branch";

            grid_ORDER.Columns[2].Name = "Sales Rep";
            grid_ORDER.Columns[2].ReadOnly = true;
            grid_ORDER.Columns[2].Width = 80;
            grid_ORDER.Columns[2].MinimumWidth = 80;
            grid_ORDER.Columns[2].DataPropertyName = "SaleRep";

            grid_ORDER.Columns[2].Name = "Invoice No.";
            grid_ORDER.Columns[2].ReadOnly = true;
            grid_ORDER.Columns[2].Width = 100;
            grid_ORDER.Columns[2].MinimumWidth = 100;
            grid_ORDER.Columns[2].DataPropertyName = "InvoiceNumber";

            grid_ORDER.Columns[3].Name = "Sales Code.";
            grid_ORDER.Columns[3].ReadOnly = true;
            grid_ORDER.Columns[3].Width = 80;
            grid_ORDER.Columns[3].MinimumWidth = 80;
            grid_ORDER.Columns[3].DataPropertyName = "SaleRep";

            grid_ORDER.Columns[4].Name = "Order ID";
            //grid_ORDER.Columns[3].Visible = false;
            grid_ORDER.Columns[4].ReadOnly = true;
            grid_ORDER.Columns[4].Width = 100;
            grid_ORDER.Columns[4].MinimumWidth = 100;
            grid_ORDER.Columns[4].DataPropertyName = "OrderID";

            grid_ORDER.Columns[5].Name = "Customer ID";
            grid_ORDER.Columns[5].ReadOnly = true;
            grid_ORDER.Columns[5].Width = 100;
            grid_ORDER.Columns[5].MinimumWidth = 100;
            grid_ORDER.Columns[5].DataPropertyName = "CustomerID";

            //grid_ORDER.Columns[5].Name = "Sales Rep.";
            //grid_ORDER.Columns[5].ReadOnly = true;
            //grid_ORDER.Columns[5].Width = 80;
            //grid_ORDER.Columns[5].DataPropertyName = "SaleRep";

            grid_ORDER.Columns[6].Name = "INV Date";
            grid_ORDER.Columns[6].ReadOnly = true;
            grid_ORDER.Columns[6].Width = 80;
            grid_ORDER.Columns[6].MinimumWidth = 80;
            grid_ORDER.Columns[6].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_ORDER.Columns[6].DataPropertyName = "CreateTime";

            grid_ORDER.Columns[7].Name = "Status";
            grid_ORDER.Columns[7].Visible = false;
            grid_ORDER.Columns[7].Width = 50;
            grid_ORDER.Columns[7].MinimumWidth = 50;
            grid_ORDER.Columns[7].DataPropertyName = "OrderStatus";

            grid_ORDER.Columns[8].Name = "Printed";
            grid_ORDER.Columns[8].Visible = false;
            grid_ORDER.Columns[8].Width = 50;
            grid_ORDER.Columns[8].DataPropertyName = "";

            grid_ORDER.Columns[9].Name = "Amount";
            grid_ORDER.Columns[9].Visible = true;
            grid_ORDER.Columns[9].Width = 70;
            grid_ORDER.Columns[9].MinimumWidth = 70;
            grid_ORDER.Columns[9].DefaultCellStyle.Format = "N2";
            grid_ORDER.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[9].DataPropertyName = "Amount";

            grid_ORDER.Columns[10].Name = "Credit";
            grid_ORDER.Columns[10].Visible = false;
            grid_ORDER.Columns[10].Width = 70;
            grid_ORDER.Columns[10].MinimumWidth = 70;
            grid_ORDER.Columns[10].DefaultCellStyle.Format = "N2";
            grid_ORDER.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDER.Columns[10].DataPropertyName = "CreditAmount";

            grid_ORDER.Columns[11].Name = "Memo";
            grid_ORDER.Columns[11].Visible = true;
            grid_ORDER.Columns[11].Width = 300;
            grid_ORDER.Columns[11].DataPropertyName = "OrderMemo";

            //grid font size custom
            grid_ORDER.RowTemplate.Height = 20;
            grid_ORDER.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_ORDER.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_ORDER.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void salesOrder_refresh()
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String SalesRep = cbo_SalesRep.Text.Trim();
            String CustomerID = cbo_searchCustomerID.Text.Trim();
            connSalesOrder.sp_Fetch_Invoice(grid_ORDER, FromDate, ToDate, SalesRep, CustomerID);
            grid_ORDER.ClearSelection();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            salesOrder_refresh();
        }

        private void grid_ORDER_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //String iPadOrderID = grid_ORDER.Rows[e.RowIndex].Cells["iPad Order ID"].Value.ToString().Trim();
                String OrderID = grid_ORDER.Rows[e.RowIndex].Cells["Order ID"].Value.ToString().Trim();
                //String OrderStatus = connSalesOrder.sp_GET_DeliveryStatus(OrderID);
                //if (OrderStatus == "Invoice")
                //{
                //    MessageBox.Show("This Delivery invoice + " + OrderID  + " already has been made .", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //    return;
                //}
                InvoiceDetail invoiceDetail = new InvoiceDetail(OrderID);
                invoiceDetail.Show();
            }
            catch
            {

            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (cbo_site.Text == "" ||
               cbo_company.Text == "" ||
               cbo_invoiceType.Text == "" ||
               cbo_customerID.Text == "" ||
               txt_memo.Text == "" ||
               txt_amount.Text == "" ||
               cbo_gl.Text == "")
            {
                MessageBox.Show("Input all info.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (connSalesOrder.sp_CHECK_NewCustomerID(cbo_customerID.Text.ToString().Trim()) == false)
            {
                MessageBox.Show("Not exists Customer.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cbo_customerID.SelectAll();
                return;
            }

            string MessageBoxText = "";
            if (cbo_gl.Text.Trim() == "12102")
                MessageBoxText = "Are you sure add a DIR Invoice?";
            else if (cbo_gl.Text.Trim() == "70000")
                MessageBoxText = "Are you sure add a DIR Fee?";

            DialogResult dialogResult = MessageBox.Show(MessageBoxText, "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                String Site = cbo_site.Text.Trim();
                String Company = cbo_company.Text.Trim();
                DateTime AccountingDate = dateTimePicker1.Value.Date;
                String CustomerID = cbo_customerID.Text.Trim();
                String Memo = txt_memo.Text.Trim();
                Decimal Amount = Convert.ToDecimal(txt_amount.Text);
                String GL = cbo_gl.Text.Trim();

                connSalesOrder.sp_CREATE_DIR(Site, Company, AccountingDate, CustomerID, Memo, GL, Amount);

                salesOrder_refresh();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }
    }
}
