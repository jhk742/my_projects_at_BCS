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
    public partial class TransactionReportDetail : Form
    {
        public TransactionReportDetail()
        {
            InitializeComponent();
            grid_TransactionDetail_Init();
            dateTimePickerFrom.MinDate = new DateTime(2021, 1, 1);
        }

        private void grid_TransactionDetail_Init()
        {
            grid_TransactionDetail.AutoGenerateColumns = false;
            grid_TransactionDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_TransactionDetail.ColumnCount = 13;

            grid_TransactionDetail.Columns[0].Name = "Invoice Date";
            grid_TransactionDetail.Columns[0].ReadOnly = true;
            grid_TransactionDetail.Columns[0].Width = 25;
            grid_TransactionDetail.Columns[0].MinimumWidth = 25;
            grid_TransactionDetail.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[0].DataPropertyName = "INVDAT_0";

            grid_TransactionDetail.Columns[1].Name = "Invoice Number";
            grid_TransactionDetail.Columns[1].ReadOnly = true;
            grid_TransactionDetail.Columns[1].Width = 30;
            grid_TransactionDetail.Columns[1].MinimumWidth = 30;
            grid_TransactionDetail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[1].DataPropertyName = "NUM_0";

            grid_TransactionDetail.Columns[2].Name = "Customer ID";
            grid_TransactionDetail.Columns[2].ReadOnly = true;
            grid_TransactionDetail.Columns[2].Width = 30;
            grid_TransactionDetail.Columns[2].MinimumWidth = 30;
            grid_TransactionDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[2].DataPropertyName = "BPCINV_0";

            grid_TransactionDetail.Columns[3].Name = "Customer Name";
            grid_TransactionDetail.Columns[3].ReadOnly = true;
            grid_TransactionDetail.Columns[3].Width = 50;
            grid_TransactionDetail.Columns[3].MinimumWidth = 50;
            grid_TransactionDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[3].DataPropertyName = "BPCNAM_0";

            grid_TransactionDetail.Columns[4].Name = "Sales Rep";
            grid_TransactionDetail.Columns[4].ReadOnly = true;
            grid_TransactionDetail.Columns[4].Width = 10;
            grid_TransactionDetail.Columns[4].MinimumWidth = 10;
            grid_TransactionDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[4].DataPropertyName = "REP1_0";

            grid_TransactionDetail.Columns[5].Name = "Brand";
            grid_TransactionDetail.Columns[5].ReadOnly = true;
            grid_TransactionDetail.Columns[5].Width = 25;
            grid_TransactionDetail.Columns[5].MinimumWidth = 25;
            grid_TransactionDetail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[5].DataPropertyName = "TSICOD_0";

            grid_TransactionDetail.Columns[6].Name = "Remark";
            grid_TransactionDetail.Columns[6].ReadOnly = true;
            grid_TransactionDetail.Columns[6].Width = 10;
            grid_TransactionDetail.Columns[6].MinimumWidth = 10;
            grid_TransactionDetail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[6].DataPropertyName = "Remark";

            grid_TransactionDetail.Columns[7].Name = "Product ID";
            grid_TransactionDetail.Columns[7].ReadOnly = true;
            grid_TransactionDetail.Columns[7].Width = 30;
            grid_TransactionDetail.Columns[7].MinimumWidth = 30;
            grid_TransactionDetail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[7].DataPropertyName = "ITMREF_0";

            grid_TransactionDetail.Columns[8].Name = "Product Description";
            grid_TransactionDetail.Columns[8].ReadOnly = true;
            grid_TransactionDetail.Columns[8].Width = 70;
            grid_TransactionDetail.Columns[8].MinimumWidth = 70;
            grid_TransactionDetail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[8].DataPropertyName = "ITMDES_0";

            grid_TransactionDetail.Columns[9].Name = "Pack Size";
            grid_TransactionDetail.Columns[9].ReadOnly = true;
            grid_TransactionDetail.Columns[9].Width = 20;
            grid_TransactionDetail.Columns[9].MinimumWidth = 20;
            grid_TransactionDetail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[9].DataPropertyName = "ITMDES_1";

            grid_TransactionDetail.Columns[10].Name = "Price";
            grid_TransactionDetail.Columns[10].ReadOnly = true;
            grid_TransactionDetail.Columns[10].Width = 20;
            grid_TransactionDetail.Columns[10].MinimumWidth = 20;
            grid_TransactionDetail.Columns[10].DefaultCellStyle.Format = "N2";
            grid_TransactionDetail.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_TransactionDetail.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[10].DataPropertyName = "NETPRI_0";

            grid_TransactionDetail.Columns[11].Name = "QTY";
            grid_TransactionDetail.Columns[11].ReadOnly = true;
            grid_TransactionDetail.Columns[11].Width = 10;
            grid_TransactionDetail.Columns[11].MinimumWidth = 10;
            grid_TransactionDetail.Columns[11].DefaultCellStyle.Format = "N2";
            grid_TransactionDetail.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_TransactionDetail.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[11].DataPropertyName = "QTY_0";

            grid_TransactionDetail.Columns[12].Name = "Amount";
            grid_TransactionDetail.Columns[12].ReadOnly = true;
            grid_TransactionDetail.Columns[12].Width = 100;
            grid_TransactionDetail.Columns[12].MinimumWidth = 100;
            grid_TransactionDetail.Columns[12].DefaultCellStyle.Format = "N2";
            grid_TransactionDetail.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_TransactionDetail.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TransactionDetail.Columns[12].DataPropertyName = "AMTNOTLIN_0";
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String CustomerID = txtBox_CustomerID.Text;
            String CustomerName = txtBox_CustomerName.Text;
            String InvoiceNo = txtBox_InvoiceNumber.Text;

            connSalesOrder.sp_Transaction_Detail_Report(grid_TransactionDetail, FromDate, ToDate, CustomerID, CustomerName, InvoiceNo);
        }

        private void grid_TransactionDetail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                Decimal TotalQTY = 0;
                Decimal TotalAmount = 0;
                for (int i = 0; i < grid_TransactionDetail.Rows.Count; i++)
                {
                    Decimal totq = Convert.ToDecimal(grid_TransactionDetail.Rows[i].Cells[11].Value);
                    TotalQTY += totq;

                    Decimal totamt = Convert.ToDecimal(grid_TransactionDetail.Rows[i].Cells[12].Value);
                    TotalAmount += totamt;
                }

                txtbox_totqty.Text = TotalQTY.ToString("N2");
                txtbox_totamt.Text = TotalAmount.ToString("N2");
            } catch
            {

            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String CustomerID = txtBox_CustomerID.Text.ToString().Trim();
            String CustomerName = txtBox_CustomerName.Text.ToString().Trim();
            String InvoiceNo = txtBox_InvoiceNumber.Text.ToString().Trim();

            Reports.Rpt_TransactionReport report = new Reports.Rpt_TransactionReport(FromDate, ToDate, CustomerID, CustomerName, InvoiceNo);
            report.Show();
        }
        /*
private void btn_print_Click(object sender, EventArgs e)
{
   DateTime FromDate = dateTimePickerFrom.Value.Date;
   DateTime ToDate = dateTimePickerTo.Value.Date;
   String CustomerID = txtBox_CustomerID.ToString().Trim();
   String CustomerName = txtBox_CustomerName.ToString().Trim();
   String InvoiceNo = txtBox_InvoiceNumber.ToString().Trim();

   Reports.Rpt_trd trd = new Reports.Rpt_trd();
}*/
    }
}
