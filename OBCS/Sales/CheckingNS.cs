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
    public partial class CheckingNS : Form
    {
        public CheckingNS()
        {
            InitializeComponent();
            grid_checkingNS_Init();
            connSalesOrder.sp_NS_CHECKING(grid_checkingNS);
        }

        private void grid_checkingNS_Init()
        {
            grid_checkingNS.AutoGenerateColumns = false;
            grid_checkingNS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_checkingNS.ColumnCount = 11;

            grid_checkingNS.Columns[0].Name = "No.";
            grid_checkingNS.Columns[0].ReadOnly = true;
            grid_checkingNS.Columns[0].Width = 30;
            grid_checkingNS.Columns[0].MinimumWidth = 30;
            grid_checkingNS.Columns[0].DataPropertyName = "";

            grid_checkingNS.Columns[1].Name = "Sales Rep";
            grid_checkingNS.Columns[1].ReadOnly = true;
            grid_checkingNS.Columns[1].Width = 40;
            grid_checkingNS.Columns[1].MinimumWidth = 40;
            grid_checkingNS.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_checkingNS.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_checkingNS.Columns[1].DataPropertyName = "SalesRep";

            grid_checkingNS.Columns[2].Name = "Customer ID";
            grid_checkingNS.Columns[2].ReadOnly = true;
            grid_checkingNS.Columns[2].Width = 80;
            grid_checkingNS.Columns[2].MinimumWidth = 80;
            grid_checkingNS.Columns[2].DataPropertyName = "CustomerID";
            
            grid_checkingNS.Columns[3].Name = "Invoice Date";
            grid_checkingNS.Columns[3].ReadOnly = true;
            grid_checkingNS.Columns[3].Width = 75;
            grid_checkingNS.Columns[3].MinimumWidth = 75;
            grid_checkingNS.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_checkingNS.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_checkingNS.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_checkingNS.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_checkingNS.Columns[3].DataPropertyName = "InvoiceDate";

            grid_checkingNS.Columns[4].Name = "Delivery Number";
            grid_checkingNS.Columns[4].ReadOnly = true;
            grid_checkingNS.Columns[4].Width = 90;
            grid_checkingNS.Columns[4].MinimumWidth = 90;
            grid_checkingNS.Columns[4].DataPropertyName = "DeliveryNumber";

            grid_checkingNS.Columns[5].Name = "Order ID";
            grid_checkingNS.Columns[5].ReadOnly = true;
            grid_checkingNS.Columns[5].Width = 80;
            grid_checkingNS.Columns[5].MinimumWidth = 80;
            grid_checkingNS.Columns[5].DataPropertyName = "OrderID";

            grid_checkingNS.Columns[6].Name = "Credit Number";
            grid_checkingNS.Columns[6].ReadOnly = true;
            grid_checkingNS.Columns[6].Width = 70;
            grid_checkingNS.Columns[6].MinimumWidth = 70;
            grid_checkingNS.Columns[6].DataPropertyName = "CreditNumber";

            grid_checkingNS.Columns[7].Name = "Credit Amount";
            grid_checkingNS.Columns[7].ReadOnly = true;
            grid_checkingNS.Columns[7].Width = 60;
            grid_checkingNS.Columns[7].MinimumWidth = 60;
            grid_checkingNS.Columns[7].DefaultCellStyle.Format = "N2";
            grid_checkingNS.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_checkingNS.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_checkingNS.Columns[7].DataPropertyName = "RemainingCreditAmount";

            grid_checkingNS.Columns[8].Name = "Credit Type";
            grid_checkingNS.Columns[8].ReadOnly = true;
            grid_checkingNS.Columns[8].Width = 50;
            grid_checkingNS.Columns[8].MinimumWidth = 50;
            grid_checkingNS.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_checkingNS.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_checkingNS.Columns[8].DataPropertyName = "NSCreditTypeNumber";

            grid_checkingNS.Columns[9].Name = "Return ID";
            grid_checkingNS.Columns[9].ReadOnly = true;
            grid_checkingNS.Columns[9].Width = 80;
            grid_checkingNS.Columns[9].MinimumWidth = 80;
            grid_checkingNS.Columns[9].DataPropertyName = "ReturnID";

            grid_checkingNS.Columns[10].Name = "Return Credit Amount";
            grid_checkingNS.Columns[10].ReadOnly = true;
            grid_checkingNS.Columns[10].Width = 60;
            grid_checkingNS.Columns[10].MinimumWidth = 60;
            grid_checkingNS.Columns[10].DefaultCellStyle.Format = "N2";
            grid_checkingNS.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_checkingNS.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_checkingNS.Columns[10].DataPropertyName = "RemainingReturnCreditAmount";
            
            //grid font size custom
            grid_checkingNS.RowTemplate.Height = 20;
            grid_checkingNS.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_checkingNS.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_checkingNS.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_checkingNS_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.grid_checkingNS.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString("D2");
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            connSalesOrder.sp_NS_CHECKING(grid_checkingNS);
        }

        private void grid_checkingNS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String CustomerID = grid_checkingNS.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString().Trim();
                var mainForm = Application.OpenForms.OfType<ARPAYMENT>().FirstOrDefault();
                mainForm.Activate();
                mainForm.cbox_customer.Text = CustomerID;
                mainForm.btn_search.PerformClick();
            }
            catch
            {
                //MessageBox.Show("Net settlement catch");
            }
        }

        private void grid_checkingNS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String CustomerID = grid_checkingNS.Rows[e.RowIndex].Cells["Customer ID"].Value.ToString().Trim();
                var mainForm = Application.OpenForms.OfType<NetSettlement>().FirstOrDefault();
                mainForm.Activate();
                mainForm.cbo_customer.Text = CustomerID;//CustomerID;
                mainForm.btn_search.PerformClick();

            }
            catch
            {
                //MessageBox.Show("Net settlement catch");
            }
        }
    }
}
