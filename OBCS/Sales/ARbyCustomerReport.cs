using OBCS.Entities;
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
    public partial class ARbyCustomerReport : Form
    {
        public ARbyCustomerReport()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            grid_open_Init();
            grid_closed_Init();
            connPO.cbox_getCustomerID(cbox_customer);
        }

        private void grid_open_Init()
        {
            grid_open.AutoGenerateColumns = false;
            grid_open.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_open.ColumnCount = 28;

            grid_open.Columns[0].Name = "Customer ID";
            grid_open.Columns[0].ReadOnly = true;
            grid_open.Columns[0].Width = 80;
            grid_open.Columns[0].MinimumWidth = 80;
            grid_open.Columns[0].DataPropertyName = "CustomerID";

            grid_open.Columns[1].Name = "Company Name";
            grid_open.Columns[1].ReadOnly = true;
            grid_open.Columns[1].Width = 100;
            grid_open.Columns[1].MinimumWidth = 100;
            grid_open.Columns[1].DataPropertyName = "CustomerName";

            grid_open.Columns[2].Name = "Rep";
            grid_open.Columns[2].ReadOnly = true;
            grid_open.Columns[2].Width = 30;
            grid_open.Columns[2].MinimumWidth = 30;
            grid_open.Columns[2].DataPropertyName = "SaleRep";

            grid_open.Columns[3].Name = "Delivery Number";
            grid_open.Columns[3].ReadOnly = true;
            grid_open.Columns[3].Width = 90;
            grid_open.Columns[3].MinimumWidth = 90;
            grid_open.Columns[3].DataPropertyName = "DeliveryNumber";

            grid_open.Columns[4].Name = "Ship Date";
            grid_open.Columns[4].ReadOnly = true;
            grid_open.Columns[4].Width = 70;
            grid_open.Columns[4].MinimumWidth = 70;
            grid_open.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_open.Columns[4].DataPropertyName = "ShipDate";

            grid_open.Columns[5].Name = "Invoice Number";
            grid_open.Columns[5].ReadOnly = true;
            grid_open.Columns[5].Width = 70;
            grid_open.Columns[5].MinimumWidth = 70;
            grid_open.Columns[5].DataPropertyName = "InvoiceNumber";

            grid_open.Columns[6].Name = "Invoice Date";
            grid_open.Columns[6].ReadOnly = true;
            grid_open.Columns[6].Width = 70;
            grid_open.Columns[6].MinimumWidth = 70;
            grid_open.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_open.Columns[6].DataPropertyName = "InvoiceDate";
            
            grid_open.Columns[7].Name = "Invoice Amount";
            grid_open.Columns[7].ReadOnly = true;
            grid_open.Columns[7].Width = 50;
            grid_open.Columns[7].DefaultCellStyle.Format = "N2";
            grid_open.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[7].MinimumWidth = 50;
            grid_open.Columns[7].DataPropertyName = "InvoiceAmount";

            grid_open.Columns[8].Name = "Credit Memo1";
            grid_open.Columns[8].ReadOnly = true;
            grid_open.Columns[8].Width = 50;
            grid_open.Columns[8].MinimumWidth = 50;
            grid_open.Columns[8].DefaultCellStyle.Format = "N2";
            grid_open.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[8].DataPropertyName = "Credit1Total";

            grid_open.Columns[9].Name = "Credit Memo2";
            grid_open.Columns[9].ReadOnly = true;
            grid_open.Columns[9].Width = 50;
            grid_open.Columns[9].MinimumWidth = 50;
            grid_open.Columns[9].DefaultCellStyle.Format = "N2";
            grid_open.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[9].DataPropertyName = "Credit2Total";

            grid_open.Columns[10].Name = "Credit Memo3";
            grid_open.Columns[10].ReadOnly = true;
            grid_open.Columns[10].Width = 50;
            grid_open.Columns[10].MinimumWidth = 50;
            grid_open.Columns[10].DefaultCellStyle.Format = "N2";
            grid_open.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[10].DataPropertyName = "Credit3Total";

            grid_open.Columns[11].Name = "Return";
            grid_open.Columns[11].ReadOnly = true;
            grid_open.Columns[11].Width = 50;
            grid_open.Columns[11].MinimumWidth = 50;
            grid_open.Columns[11].DefaultCellStyle.Format = "N2";
            grid_open.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[11].DataPropertyName = "ReturnCreditTotal";

            grid_open.Columns[12].Name = "Term Credit";
            grid_open.Columns[12].ReadOnly = true;
            grid_open.Columns[12].Width = 50;
            grid_open.Columns[12].MinimumWidth = 50;
            grid_open.Columns[12].DefaultCellStyle.Format = "N2";
            grid_open.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[12].DataPropertyName = "TermCreditTotal";

            grid_open.Columns[13].Name = "Short";
            grid_open.Columns[13].ReadOnly = true;
            grid_open.Columns[13].Width = 50;
            grid_open.Columns[13].MinimumWidth = 50;
            grid_open.Columns[13].DefaultCellStyle.Format = "N2";
            grid_open.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[13].DataPropertyName = "Short";
            
            grid_open.Columns[14].Name = "Paid Amount";
            grid_open.Columns[14].ReadOnly = true;
            grid_open.Columns[14].Width = 50;
            grid_open.Columns[14].MinimumWidth = 50;
            grid_open.Columns[14].DefaultCellStyle.Format = "N2";
            grid_open.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[14].DataPropertyName = "PaymentAmount";

            grid_open.Columns[15].Name = "Over Payment Amount";
            grid_open.Columns[15].ReadOnly = true;
            grid_open.Columns[15].Width = 50;
            grid_open.Columns[15].MinimumWidth = 50;
            grid_open.Columns[15].DefaultCellStyle.Format = "N2";
            grid_open.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[15].DataPropertyName = "OverPaymentTotal";

            grid_open.Columns[16].Name = "Write-off Amount";
            grid_open.Columns[16].ReadOnly = true;
            grid_open.Columns[16].Width = 50;
            grid_open.Columns[16].MinimumWidth = 50;
            grid_open.Columns[16].DefaultCellStyle.Format = "N2";
            grid_open.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[16].DataPropertyName = "WriteOffTotal";

            grid_open.Columns[17].Name = "Open A/R";
            grid_open.Columns[17].ReadOnly = true;
            grid_open.Columns[17].Width = 50;
            grid_open.Columns[17].MinimumWidth = 50;
            grid_open.Columns[17].DefaultCellStyle.Format = "N2";
            grid_open.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[17].DataPropertyName = "OpenAR";

            grid_open.Columns[18].Name = "Post Check Payment";
            grid_open.Columns[18].ReadOnly = true;
            grid_open.Columns[18].Width = 50;
            grid_open.Columns[18].MinimumWidth = 50;
            grid_open.Columns[18].DefaultCellStyle.Format = "N2";
            grid_open.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[18].DataPropertyName = "PostCheckPayment";

            grid_open.Columns[19].Name = "Settled Amount";
            grid_open.Columns[19].ReadOnly = true;
            grid_open.Columns[19].Width = 50;
            grid_open.Columns[19].MinimumWidth = 50;
            grid_open.Columns[19].DefaultCellStyle.Format = "N2";
            grid_open.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[19].DataPropertyName = "SettledAmount";

            grid_open.Columns[20].Name = "Last Check Number";
            grid_open.Columns[20].ReadOnly = true;
            grid_open.Columns[20].Width = 40;
            grid_open.Columns[20].MinimumWidth = 40;
            grid_open.Columns[20].DataPropertyName = "LastCheckNumber";
       
            grid_open.Columns[21].Name = "Last Check Amount";
            grid_open.Columns[21].ReadOnly = true;
            grid_open.Columns[21].Width = 50;
            grid_open.Columns[21].MinimumWidth = 50;
            grid_open.Columns[21].DefaultCellStyle.Format = "N2";
            grid_open.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_open.Columns[21].DataPropertyName = "LastPaymentAmount";

            grid_open.Columns[22].Name = "Last Payment Date";
            grid_open.Columns[22].ReadOnly = true;
            grid_open.Columns[22].Width = 60;
            grid_open.Columns[22].MinimumWidth = 60;
            grid_open.Columns[22].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_open.Columns[22].DataPropertyName = "LastPaymentDate";
       
            grid_open.Columns[23].Name = "Last Check Date";
            grid_open.Columns[23].ReadOnly = true;
            grid_open.Columns[23].Width = 60;
            grid_open.Columns[23].MinimumWidth = 60;
            grid_open.Columns[23].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_open.Columns[23].DataPropertyName = "LastCheckDate";

            grid_open.Columns[24].Name = "Ref. Doc. No.";
            grid_open.Columns[24].ReadOnly = true;
            grid_open.Columns[24].Width = 70;
            grid_open.Columns[24].MinimumWidth = 70;
            grid_open.Columns[24].DataPropertyName = "RefDocNumber";
            
            grid_open.Columns[25].Name = "Driver";
            grid_open.Columns[25].ReadOnly = true;
            grid_open.Columns[25].Width = 70;
            grid_open.Columns[25].MinimumWidth = 70;
            grid_open.Columns[25].DataPropertyName = "DriverName";

            grid_open.Columns[26].Name = "Route Number";
            grid_open.Columns[26].ReadOnly = true;
            grid_open.Columns[26].Width = 40;
            grid_open.Columns[26].MinimumWidth = 40;
            grid_open.Columns[26].DataPropertyName = "RouteNumber";

            grid_open.Columns[27].Name = "Entry Batch";
            grid_open.Columns[27].ReadOnly = true;
            grid_open.Columns[27].Width = 60;
            grid_open.Columns[27].MinimumWidth = 60;
            grid_open.Columns[27].DataPropertyName = "EntryBatch";


            //grid font size custom
            grid_open.RowTemplate.Height = 20;
            grid_open.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_open.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_open.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_closed_Init()
        {
            grid_closed.AutoGenerateColumns = false;
            grid_closed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_closed.ColumnCount = 26;

            grid_closed.Columns[0].Name = "Customer ID";
            grid_closed.Columns[0].ReadOnly = true;
            grid_closed.Columns[0].Width = 80;
            grid_closed.Columns[0].MinimumWidth = 80;
            grid_closed.Columns[0].DataPropertyName = "CustomerID";

            grid_closed.Columns[1].Name = "Company Name";
            grid_closed.Columns[1].ReadOnly = true;
            grid_closed.Columns[1].Width = 150;
            grid_closed.Columns[1].MinimumWidth = 150;
            grid_closed.Columns[1].DataPropertyName = "CustomerName";

            grid_closed.Columns[2].Name = "Rep";
            grid_closed.Columns[2].ReadOnly = true;
            grid_closed.Columns[2].Width = 30;
            grid_closed.Columns[2].MinimumWidth = 30;
            grid_closed.Columns[2].DataPropertyName = "SaleRep";

            grid_closed.Columns[3].Name = "Delivery Number";
            grid_closed.Columns[3].ReadOnly = true;
            grid_closed.Columns[3].Width = 80;
            grid_closed.Columns[3].MinimumWidth = 80;
            grid_closed.Columns[3].DataPropertyName = "DeliveryNumber";

            grid_closed.Columns[4].Name = "Ship Date";
            grid_closed.Columns[4].ReadOnly = true;
            grid_closed.Columns[4].Width = 70;
            grid_closed.Columns[4].MinimumWidth = 70;
            grid_closed.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_closed.Columns[4].DataPropertyName = "ShipDate";

            grid_closed.Columns[5].Name = "Invoice Number";
            grid_closed.Columns[5].ReadOnly = true;
            grid_closed.Columns[5].Width = 70;
            grid_closed.Columns[5].MinimumWidth = 70;
            grid_closed.Columns[5].DataPropertyName = "InvoiceNumber";

            grid_closed.Columns[6].Name = "Invoice Date";
            grid_closed.Columns[6].ReadOnly = true;
            grid_closed.Columns[6].Width = 70;
            grid_closed.Columns[6].MinimumWidth = 70;
            grid_closed.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_closed.Columns[6].DataPropertyName = "InvoiceDate";
            
            grid_closed.Columns[7].Name = "Invoice Amount";
            grid_closed.Columns[7].ReadOnly = true;
            grid_closed.Columns[7].Width = 50;
            grid_closed.Columns[7].DefaultCellStyle.Format = "N2";
            grid_closed.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[7].MinimumWidth = 50;
            grid_closed.Columns[7].DataPropertyName = "InvoiceAmount";

            grid_closed.Columns[8].Name = "Credit Memo1";
            grid_closed.Columns[8].ReadOnly = true;
            grid_closed.Columns[8].Width = 50;
            grid_closed.Columns[8].MinimumWidth = 50;
            grid_closed.Columns[8].DefaultCellStyle.Format = "N2";
            grid_closed.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[8].DataPropertyName = "Credit1Total";

            grid_closed.Columns[9].Name = "Credit Memo2";
            grid_closed.Columns[9].ReadOnly = true;
            grid_closed.Columns[9].Width = 50;
            grid_closed.Columns[9].MinimumWidth = 50;
            grid_closed.Columns[9].DefaultCellStyle.Format = "N2";
            grid_closed.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[9].DataPropertyName = "Credit2Total";

            grid_closed.Columns[10].Name = "Credit Memo3";
            grid_closed.Columns[10].ReadOnly = true;
            grid_closed.Columns[10].Width = 50;
            grid_closed.Columns[10].MinimumWidth = 50;
            grid_closed.Columns[10].DefaultCellStyle.Format = "N2";
            grid_closed.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[10].DataPropertyName = "Credit3Total";

            grid_closed.Columns[11].Name = "Return";
            grid_closed.Columns[11].ReadOnly = true;
            grid_closed.Columns[11].Width = 50;
            grid_closed.Columns[11].MinimumWidth = 50;
            grid_closed.Columns[11].DefaultCellStyle.Format = "N2";
            grid_closed.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[11].DataPropertyName = "ReturnCreditTotal";

            grid_closed.Columns[12].Name = "Term Credit";
            grid_closed.Columns[12].ReadOnly = true;
            grid_closed.Columns[12].Width = 50;
            grid_closed.Columns[12].MinimumWidth = 50;
            grid_closed.Columns[12].DefaultCellStyle.Format = "N2";
            grid_closed.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[12].DataPropertyName = "TermCreditTotal";

            grid_closed.Columns[13].Name = "Short";
            grid_closed.Columns[13].ReadOnly = true;
            grid_closed.Columns[13].Width = 50;
            grid_closed.Columns[13].MinimumWidth = 50;
            grid_closed.Columns[13].DefaultCellStyle.Format = "N2";
            grid_closed.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[13].DataPropertyName = "Short";

            grid_closed.Columns[14].Name = "Paid Amount";
            grid_closed.Columns[14].ReadOnly = true;
            grid_closed.Columns[14].Width = 50;
            grid_closed.Columns[14].MinimumWidth = 50;
            grid_closed.Columns[14].DefaultCellStyle.Format = "N2";
            grid_closed.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[14].DataPropertyName = "PaymentAmount";

            grid_closed.Columns[15].Name = "Over Payment Amount";
            grid_closed.Columns[15].ReadOnly = true;
            grid_closed.Columns[15].Width = 50;
            grid_closed.Columns[15].MinimumWidth = 50;
            grid_closed.Columns[15].DefaultCellStyle.Format = "N2";
            grid_closed.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[15].DataPropertyName = "OverPaymentTotal";

            grid_closed.Columns[16].Name = "Write-off Amount";
            grid_closed.Columns[16].ReadOnly = true;
            grid_closed.Columns[16].Width = 40;
            grid_closed.Columns[16].MinimumWidth = 40;
            grid_closed.Columns[16].DefaultCellStyle.Format = "N2";
            grid_closed.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[16].DataPropertyName = "WriteOffTotal";

            grid_closed.Columns[17].Name = "Open A/R";
            grid_closed.Columns[17].ReadOnly = true;
            grid_closed.Columns[17].Width = 40;
            grid_closed.Columns[17].MinimumWidth = 40;
            grid_closed.Columns[17].DefaultCellStyle.Format = "N2";
            grid_closed.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[17].DataPropertyName = "OpenAR";

            grid_closed.Columns[18].Name = "Last Check Number";
            grid_closed.Columns[18].ReadOnly = true;
            grid_closed.Columns[18].Width = 40;
            grid_closed.Columns[18].MinimumWidth = 40;
            grid_closed.Columns[18].DataPropertyName = "LastCheckNumber";

            grid_closed.Columns[19].Name = "Last Payment Amount";
            grid_closed.Columns[19].ReadOnly = true;
            grid_closed.Columns[19].Width = 50;
            grid_closed.Columns[19].MinimumWidth = 50;
            grid_closed.Columns[19].DefaultCellStyle.Format = "N2";
            grid_closed.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_closed.Columns[19].DataPropertyName = "LastPaymentAmount";

            grid_closed.Columns[20].Name = "Last Payment Date";
            grid_closed.Columns[20].Visible = false;
            grid_closed.Columns[20].Width = 60;
            grid_closed.Columns[20].MinimumWidth = 60;
            grid_closed.Columns[20].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_closed.Columns[20].DataPropertyName = "LastPaymentDate";

            grid_closed.Columns[21].Name = "Last Payment Date";
            grid_closed.Columns[21].ReadOnly = true;
            grid_closed.Columns[21].Width = 60;
            grid_closed.Columns[21].MinimumWidth = 60;
            grid_closed.Columns[21].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_closed.Columns[21].DataPropertyName = "LastPaymentDate";

            grid_closed.Columns[22].Name = "Ref. Doc. No.";
            grid_closed.Columns[22].ReadOnly = true;
            grid_closed.Columns[22].Width = 90;
            grid_closed.Columns[22].MinimumWidth = 90;
            grid_closed.Columns[22].DataPropertyName = "RefDocNumber";

            grid_closed.Columns[23].Name = "Driver";
            grid_closed.Columns[23].ReadOnly = true;
            grid_closed.Columns[23].Width = 80;
            grid_closed.Columns[23].MinimumWidth = 80;
            grid_closed.Columns[23].DataPropertyName = "DriverName";

            grid_closed.Columns[24].Name = "Route Number";
            grid_closed.Columns[24].ReadOnly = true;
            grid_closed.Columns[24].Width = 40;
            grid_closed.Columns[24].MinimumWidth = 40;
            grid_closed.Columns[24].DataPropertyName = "RouteNumber";

            grid_closed.Columns[25].Name = "Entry Batch";
            grid_closed.Columns[25].ReadOnly = true;
            grid_closed.Columns[25].Width = 60;
            grid_closed.Columns[25].MinimumWidth = 60;
            grid_closed.Columns[25].DataPropertyName = "EntryBatch";

            //grid font size custom
            grid_closed.RowTemplate.Height = 20;
            grid_closed.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_closed.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_closed.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void cbox_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbox_customer_DroppedDown();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                search();
            }

        }

        private void cbox_customer_DroppedDown()
        {
            cbox_customer.DroppedDown = true;
        }

        private void search()
        {
            connSalesOrder.sp_AROPENCLOSE_OPEN(grid_open, cbox_customer.Text);
            connSalesOrder.sp_AROPENCLOSE_CLOSED(grid_closed, cbox_customer.Text);
        }

        private void grid_open_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            txt_totalAR.Text = "";
            txt_count.Text = "";
            txt_totalSettledAR.Text = "";
            try
            {
                Decimal TotalOpenAR = 0;
                Decimal TotalOpenARCount = 0;
                Decimal TotalSettledAR = 0;
                for (int i = 0; i < grid_open.Rows.Count; i++)
                {
                    Decimal OpenAR = Convert.ToDecimal(grid_open.Rows[i].Cells["Open A/R"].Value);
                    TotalOpenAR = TotalOpenAR + OpenAR;

                    Decimal SettledAR = Convert.ToDecimal(grid_open.Rows[i].Cells["Settled Amount"].Value);
                    TotalSettledAR = TotalSettledAR + SettledAR;

                    TotalOpenARCount = TotalOpenARCount + 1;
                }

                txt_totalAR.Text = TotalOpenAR.ToString("N2");
                txt_count.Text = TotalOpenARCount.ToString();
                txt_totalSettledAR.Text = TotalSettledAR.ToString("N2");
            }
            catch
            {

            }
        }

        private void btn_statement_Click(object sender, EventArgs e)
        {
            String CustomerID = cbox_customer.Text.Trim();
            CustInfo custInfo = new CustInfo();
            custInfo = connSalesOrder.sp_GET_CustomerInfoByCustomerID(CustomerID);
            
            String CustomerName = custInfo.CustomerName;

            String Address1 = custInfo.Address1;
            String Address2 = custInfo.Address2;
            String CustomerAddress = Address1 + "\n" + Address2;

            String Branch = custInfo.Branch;
            if (Branch == "BCS")
                Branch = "BCS International";
            else if (Branch == "NYC")
                Branch = "New York Cheese";
            else if (Branch == "HYD")
                Branch = "HYUNDAI";
            else if (Branch == "CFI")
                Branch = "Care Food";


            //String TotalBalance = txt_totalSettledAR.Text.Trim();
            //String TotalBalance;
            try
            {
                //TotalBalance = connSalesOrder.sp_GET_PreviousBalance(CustomerID);

                Reports.Rpt_Statement statement = new Reports.Rpt_Statement
                    (
                    CustomerID, CustomerName, CustomerAddress, Branch
                    );
                statement.MdiParent = this.MdiParent;
                statement.Show();

            } catch{
                MessageBox.Show("Total A/R : $0", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}
