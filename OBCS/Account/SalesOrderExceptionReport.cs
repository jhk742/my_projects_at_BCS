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
    public partial class SalesOrderExceptionReport : Form
    {
        public SalesOrderExceptionReport()
        {
            InitializeComponent();
            grid_all_Init();
            cbo_soOpenStatus.Items.Add("");
            cbo_soOpenStatus.Items.Add("Open");
            cbo_soOpenStatus.Items.Add("Close");

            connPO.cbox_getCustomerID(cbo_customerID);

        }
        private void grid_all_Init()
        {
            grid_AR.AutoGenerateColumns = false;
            grid_AR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_AR.ColumnCount = 31;

            grid_AR.Columns[0].Name = "Customer ID";
            grid_AR.Columns[0].ReadOnly = true;
            grid_AR.Columns[0].Width = 100;
            grid_AR.Columns[0].MinimumWidth = 100;
            grid_AR.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[0].DataPropertyName = "CustomerID";

            grid_AR.Columns[1].Name = "Sales Order Date";
            grid_AR.Columns[1].ReadOnly = true;
            grid_AR.Columns[1].Width = 80;
            grid_AR.Columns[1].MinimumWidth = 80;
            grid_AR.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_AR.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[1].DataPropertyName = "SalesOrderDate";

            grid_AR.Columns[2].Name = "Sales Order Number";
            grid_AR.Columns[2].ReadOnly = true;
            grid_AR.Columns[2].Width = 80;
            grid_AR.Columns[2].MinimumWidth = 80;
            grid_AR.Columns[2].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[2].DataPropertyName = "SONumber";

            grid_AR.Columns[3].Name = "Sales Order Amount";
            grid_AR.Columns[3].ReadOnly = true;
            grid_AR.Columns[3].Width = 80;
            grid_AR.Columns[3].MinimumWidth = 80;
            grid_AR.Columns[3].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[3].DataPropertyName = "SOAmount";
            
            grid_AR.Columns[4].Name = "Sales Order Status";
            grid_AR.Columns[4].ReadOnly = true;
            grid_AR.Columns[4].Width = 80;
            grid_AR.Columns[4].MinimumWidth = 80;
            grid_AR.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[4].DataPropertyName = "SOStatus";

            grid_AR.Columns[5].Name = "Packing Date";
            grid_AR.Columns[5].ReadOnly = true;
            grid_AR.Columns[5].Width = 80;
            grid_AR.Columns[5].MinimumWidth = 80;
            grid_AR.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_AR.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[5].DataPropertyName = "PackingDate";

            grid_AR.Columns[6].Name = "Packing Amount";
            grid_AR.Columns[6].ReadOnly = true;
            grid_AR.Columns[6].Width = 80;
            grid_AR.Columns[6].MinimumWidth = 80;
            grid_AR.Columns[6].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[6].DataPropertyName = "PackAmount";

            grid_AR.Columns[7].Name = "Packing Status";
            grid_AR.Columns[7].ReadOnly = true;
            grid_AR.Columns[7].Width = 100;
            grid_AR.Columns[7].MinimumWidth = 100;
            grid_AR.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[7].DataPropertyName = "PackingStatus";

            grid_AR.Columns[8].Name = "Delivery Note Date";
            grid_AR.Columns[8].ReadOnly = true;
            grid_AR.Columns[8].Width = 80;
            grid_AR.Columns[8].MinimumWidth = 80;
            grid_AR.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_AR.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[8].DataPropertyName = "DeliveryNoteDate";

            grid_AR.Columns[9].Name = "Delivery Note Number";
            grid_AR.Columns[9].ReadOnly = true;
            grid_AR.Columns[9].Width = 90;
            grid_AR.Columns[9].MinimumWidth = 90;
            grid_AR.Columns[9].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[9].DataPropertyName = "DNNumber";

            grid_AR.Columns[10].Name = "Delivery Amount";
            grid_AR.Columns[10].ReadOnly = true;
            grid_AR.Columns[10].Width = 90;
            grid_AR.Columns[10].MinimumWidth = 90;
            grid_AR.Columns[10].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[10].DataPropertyName = "DNAmount";

            grid_AR.Columns[11].Name = "Delivery Note Status";
            grid_AR.Columns[11].ReadOnly = true;
            grid_AR.Columns[11].Width = 80;
            grid_AR.Columns[11].MinimumWidth = 80;
            grid_AR.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[11].DataPropertyName = "DNStatus";

            grid_AR.Columns[12].Name = "AR Invoice Date";
            grid_AR.Columns[12].ReadOnly = true;
            grid_AR.Columns[12].Width = 80;
            grid_AR.Columns[12].MinimumWidth = 80;
            grid_AR.Columns[12].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_AR.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[12].DataPropertyName = "ARDate";

            grid_AR.Columns[13].Name = "AR Invoice Nubmer";
            grid_AR.Columns[13].ReadOnly = true;
            grid_AR.Columns[13].Width = 80;
            grid_AR.Columns[13].MinimumWidth = 80;
            grid_AR.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[13].DataPropertyName = "ARInvoiceNumber";

            grid_AR.Columns[14].Name = "AR Invoice Amount";
            grid_AR.Columns[14].ReadOnly = true;
            grid_AR.Columns[14].Width = 80;
            grid_AR.Columns[14].MinimumWidth = 80;
            grid_AR.Columns[14].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[14].DataPropertyName = "ARInvoiceAmount";

            grid_AR.Columns[15].Name = "COGS";
            grid_AR.Columns[15].ReadOnly = true;
            grid_AR.Columns[15].Width = 80;
            grid_AR.Columns[15].MinimumWidth = 80;
            grid_AR.Columns[15].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[15].DataPropertyName = "COGS";

            grid_AR.Columns[16].Name = "Last Payment Date";
            grid_AR.Columns[16].ReadOnly = true;
            grid_AR.Columns[16].Width = 80;
            grid_AR.Columns[16].MinimumWidth = 80;
            grid_AR.Columns[16].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_AR.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[16].DataPropertyName = "ARLastPaymentDate";
            
            grid_AR.Columns[17].Name = "Last Payment Number";
            grid_AR.Columns[17].ReadOnly = true;
            grid_AR.Columns[17].Width = 90;
            grid_AR.Columns[17].MinimumWidth = 90;
            grid_AR.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[17].DataPropertyName = "ARLastPaymentNumber";

            grid_AR.Columns[18].Name = "Last Deposit Date";
            grid_AR.Columns[18].ReadOnly = true;
            grid_AR.Columns[18].Width = 80;
            grid_AR.Columns[18].MinimumWidth = 80;
            grid_AR.Columns[18].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_AR.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[18].DataPropertyName = "LastDepositDate";

            grid_AR.Columns[19].Name = "AR Payment Type";
            grid_AR.Columns[19].ReadOnly = true;
            grid_AR.Columns[19].Width = 80;
            grid_AR.Columns[19].MinimumWidth = 80;
            grid_AR.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[19].DataPropertyName = "ARPaymentType";

            grid_AR.Columns[20].Name = "Credit";
            grid_AR.Columns[20].ReadOnly = true;
            grid_AR.Columns[20].Width = 70;
            grid_AR.Columns[20].MinimumWidth = 70;
            grid_AR.Columns[20].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[20].DataPropertyName = "CreditTotal";

            grid_AR.Columns[21].Name = "Return Credit";
            grid_AR.Columns[21].ReadOnly = true;
            grid_AR.Columns[21].Width = 80;
            grid_AR.Columns[21].MinimumWidth = 80;
            grid_AR.Columns[21].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[21].DataPropertyName = "ReturnCreditTotal";

            grid_AR.Columns[22].Name = "Term Credit";
            grid_AR.Columns[22].ReadOnly = true;
            grid_AR.Columns[22].Width = 70;
            grid_AR.Columns[22].MinimumWidth = 70;
            grid_AR.Columns[22].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[22].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[22].DataPropertyName = "TermCreditTotal";

            grid_AR.Columns[23].Name = "Short";
            grid_AR.Columns[23].ReadOnly = true;
            grid_AR.Columns[23].Width = 70;
            grid_AR.Columns[23].MinimumWidth = 70;
            grid_AR.Columns[23].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[23].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[23].DataPropertyName = "ShortTotal";

            grid_AR.Columns[24].Name = "Overpayment";
            grid_AR.Columns[24].ReadOnly = true;
            grid_AR.Columns[24].Width = 70;
            grid_AR.Columns[24].MinimumWidth = 70;
            grid_AR.Columns[24].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[24].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[24].DataPropertyName = "OverPaymentTotal";
           
            grid_AR.Columns[25].Name = "Payment Amount";
            grid_AR.Columns[25].ReadOnly = true;
            grid_AR.Columns[25].Width = 80;
            grid_AR.Columns[25].MinimumWidth = 80;
            grid_AR.Columns[25].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[25].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[25].DataPropertyName = "PaymentAmount";

            grid_AR.Columns[26].Name = "Write-off";
            grid_AR.Columns[26].ReadOnly = true;
            grid_AR.Columns[26].Width = 80;
            grid_AR.Columns[26].MinimumWidth = 80;
            grid_AR.Columns[26].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[26].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[26].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[26].DataPropertyName = "WriteOffTotal";

            grid_AR.Columns[27].Name = "Generated Overpayment";
            grid_AR.Columns[27].ReadOnly = true;
            grid_AR.Columns[27].Width = 70;
            grid_AR.Columns[27].MinimumWidth = 70;
            grid_AR.Columns[27].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[27].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[27].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[27].DataPropertyName = "GeneratedOverpaymentTotal";

            grid_AR.Columns[28].Name = "Last Check Number";
            grid_AR.Columns[28].ReadOnly = true;
            grid_AR.Columns[28].Width = 80;
            grid_AR.Columns[28].MinimumWidth = 80;
            grid_AR.Columns[28].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[28].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[28].DataPropertyName = "LastCheckNumber";

            grid_AR.Columns[29].Name = "Open Balance";
            grid_AR.Columns[29].ReadOnly = true;
            grid_AR.Columns[29].Width = 80;
            grid_AR.Columns[29].MinimumWidth = 80;
            grid_AR.Columns[29].DefaultCellStyle.Format = "N2";
            grid_AR.Columns[29].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[29].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_AR.Columns[29].DataPropertyName = "SOOpenBalance";

            grid_AR.Columns[30].Name = "SO Open Status";
            grid_AR.Columns[30].ReadOnly = true;
            grid_AR.Columns[30].Width = 80;
            grid_AR.Columns[30].MinimumWidth = 80;
            grid_AR.Columns[30].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[30].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AR.Columns[30].DataPropertyName = "SOOpenStatus";
            
            //grid font size custom
            grid_AR.RowTemplate.Height = 20;
            grid_AR.ColumnHeadersHeight = 100;

            foreach (DataGridViewColumn c in grid_AR.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
            }

            grid_AR.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String SOFromX3 = "";
            if (cbx_x3.Checked)
            {
                SOFromX3 = "Checked";
            }
            else
            {
                SOFromX3 = "Unchecked";
            }

            DateTime FromDate = dateTimePickerFromDate.Value.Date;
            DateTime AsOfDate = dateTimePickerAsOf.Value.Date;
            String CustomerID = cbo_customerID.Text.Trim();
            String CheckNumber = txt_checkNo.Text.Trim();
            String SOOpenStatus = cbo_soOpenStatus.Text.Trim();
            connSalesOrder.sp_SalesOrderExceptionReport(grid_AR, FromDate, AsOfDate, CheckNumber, CustomerID, SOOpenStatus, SOFromX3);
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            //DateTime GetDate = dateTimePickerTo.Value.Date;
            //String CustomerID = cbo_customerID.Text.Trim();
            //String CheckNumber = txt_CheckNo.Text.Trim();
            //String ARStatus = cbo_ARState.Text.Trim();
            //connSalesOrder.sp_AROPENCLOSE2(grid_AR, GetDate, CheckNumber, CustomerID, ARStatus);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            String SOFromX3 = "";
            if (cbx_x3.Checked)
            {
                SOFromX3 = "Checked";
            }
            else
            {
                SOFromX3 = "Unchecked";
            }

            DateTime FromDate = dateTimePickerFromDate.Value.Date;
            DateTime AsOfDate = dateTimePickerAsOf.Value.Date;
            String CustomerID = cbo_customerID.Text.Trim();
            String CheckNumber = txt_checkNo.Text.Trim();
            String SOOpenStatus = cbo_soOpenStatus.Text.Trim();

            Reports.Rpt_SalesOrderExceptionReport salesOrderExceptionReport = new Reports.Rpt_SalesOrderExceptionReport(FromDate, AsOfDate, CheckNumber, CustomerID, SOOpenStatus, SOFromX3);
            salesOrderExceptionReport.Show();

        }
    }
}
