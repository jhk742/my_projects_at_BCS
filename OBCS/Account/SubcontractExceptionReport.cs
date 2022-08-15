using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Account
{
    public partial class SubcontractExceptionReport : Form
    {
        public SubcontractExceptionReport()
        {
            InitializeComponent();
            grid_all_Init();
            connSalesOrder.cbo_Subcontract_Supplier(cbo_Supplier);
            cbo_POStatus.Items.Add("");
            cbo_POStatus.Items.Add("Open");
            cbo_POStatus.Items.Add("Close");
            cbo_APStatus.Items.Add("");
            cbo_APStatus.Items.Add("Open");
            cbo_APStatus.Items.Add("Close");
        }
        private void grid_all_Init()
        {
            grid_Sub.AutoGenerateColumns = false;
            grid_Sub.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Sub.ColumnCount = 32;

            grid_Sub.Columns[0].Name = "Subcontract Order";
            grid_Sub.Columns[0].ReadOnly = true;
            grid_Sub.Columns[0].Width = 100;
            grid_Sub.Columns[0].MinimumWidth = 100;
            grid_Sub.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[0].DataPropertyName = "SubcontractOrder";

            grid_Sub.Columns[1].Name = "Order Date";
            grid_Sub.Columns[1].ReadOnly = true;
            grid_Sub.Columns[1].Width = 80;
            grid_Sub.Columns[1].MinimumWidth = 80;
            grid_Sub.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_Sub.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[1].DataPropertyName = "OrderDate";

            grid_Sub.Columns[2].Name = "PO Company";
            grid_Sub.Columns[2].ReadOnly = true;
            grid_Sub.Columns[2].Width = 60;
            grid_Sub.Columns[2].MinimumWidth = 60;
            grid_Sub.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[2].DataPropertyName = "POCompany";

            grid_Sub.Columns[3].Name = "PO Site";
            grid_Sub.Columns[3].ReadOnly = true;
            grid_Sub.Columns[3].Width = 50;
            grid_Sub.Columns[3].MinimumWidth = 50;
            grid_Sub.Columns[3].DefaultCellStyle.Format = "N2";
            grid_Sub.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[3].DataPropertyName = "POSite";

            grid_Sub.Columns[4].Name = "Item Code";
            grid_Sub.Columns[4].ReadOnly = true;
            grid_Sub.Columns[4].Width = 60;
            grid_Sub.Columns[4].MinimumWidth = 60;
            grid_Sub.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[4].DataPropertyName = "ItemCode";

            grid_Sub.Columns[5].Name = "ItemDescription";
            grid_Sub.Columns[5].ReadOnly = true;
            grid_Sub.Columns[5].Width = 150;
            grid_Sub.Columns[5].MinimumWidth = 150;
            grid_Sub.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[5].DataPropertyName = "ItemDescription";

            grid_Sub.Columns[6].Name = "Order Qty";
            grid_Sub.Columns[6].ReadOnly = true;
            grid_Sub.Columns[6].Width = 60;
            grid_Sub.Columns[6].MinimumWidth = 60;
            grid_Sub.Columns[6].DefaultCellStyle.Format = "N2";
            grid_Sub.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[6].DataPropertyName = "OrderQty";

            grid_Sub.Columns[7].Name = "Supplier";
            grid_Sub.Columns[7].ReadOnly = true;
            grid_Sub.Columns[7].Width = 60;
            grid_Sub.Columns[7].MinimumWidth = 60;
            grid_Sub.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[7].DataPropertyName = "Supplier";

            grid_Sub.Columns[8].Name = "Service";
            grid_Sub.Columns[8].ReadOnly = true;
            grid_Sub.Columns[8].Width = 60;
            grid_Sub.Columns[8].MinimumWidth = 60;
            grid_Sub.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[8].DataPropertyName = "Service";

            grid_Sub.Columns[9].Name = "Fee";
            grid_Sub.Columns[9].ReadOnly = true;
            grid_Sub.Columns[9].Width = 50;
            grid_Sub.Columns[9].MinimumWidth = 50;
            grid_Sub.Columns[9].DefaultCellStyle.Format = "N2";
            grid_Sub.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[9].DataPropertyName = "Fee";

            grid_Sub.Columns[10].Name = "Total Fee";
            grid_Sub.Columns[10].ReadOnly = true;
            grid_Sub.Columns[10].Width = 60;
            grid_Sub.Columns[10].MinimumWidth = 60;
            grid_Sub.Columns[10].DefaultCellStyle.Format = "N2";
            grid_Sub.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[10].DataPropertyName = "TotalFee";

            grid_Sub.Columns[11].Name = "Goods Receipt Number";
            grid_Sub.Columns[11].ReadOnly = true;
            grid_Sub.Columns[11].Width = 80;
            grid_Sub.Columns[11].MinimumWidth = 80;
            grid_Sub.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[11].DataPropertyName = "GoodsReceiptNo";

            grid_Sub.Columns[12].Name = "Receiving Item Code";
            grid_Sub.Columns[12].ReadOnly = true;
            grid_Sub.Columns[12].Width = 80;
            grid_Sub.Columns[12].MinimumWidth = 80;
            grid_Sub.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[12].DataPropertyName = "ReceivingItemCode";

            grid_Sub.Columns[13].Name = "Receiving Item Description";
            grid_Sub.Columns[13].ReadOnly = true;
            grid_Sub.Columns[13].Width = 150;
            grid_Sub.Columns[13].MinimumWidth = 150;
            grid_Sub.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[13].DataPropertyName = "ReceivingItemDescription";

            grid_Sub.Columns[14].Name = "GR Date";
            grid_Sub.Columns[14].ReadOnly = true;
            grid_Sub.Columns[14].Width = 80;
            grid_Sub.Columns[14].MinimumWidth = 80;
            grid_Sub.Columns[14].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_Sub.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[14].DataPropertyName = "GRDate";

            grid_Sub.Columns[15].Name = "GR Qty";
            grid_Sub.Columns[15].ReadOnly = true;
            grid_Sub.Columns[15].Width = 50;
            grid_Sub.Columns[15].MinimumWidth = 50;
            grid_Sub.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[15].DataPropertyName = "GRQty";

            grid_Sub.Columns[16].Name = "PO Status";
            grid_Sub.Columns[16].ReadOnly = true;
            grid_Sub.Columns[16].Width = 60;
            grid_Sub.Columns[16].MinimumWidth = 60;
            grid_Sub.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[16].DataPropertyName = "POStatus";

            grid_Sub.Columns[17].Name = "AP Invoice Number";
            grid_Sub.Columns[17].ReadOnly = true;
            grid_Sub.Columns[17].Width = 70;
            grid_Sub.Columns[17].MinimumWidth = 70;
            grid_Sub.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[17].DataPropertyName = "APInvoiceNo";

            grid_Sub.Columns[18].Name = "Supplier Doc. Number";
            grid_Sub.Columns[18].ReadOnly = true;
            grid_Sub.Columns[18].Width = 70;
            grid_Sub.Columns[18].MinimumWidth = 70;
            grid_Sub.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;                      
            grid_Sub.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[18].DataPropertyName = "SupplierDocNumber";

            grid_Sub.Columns[19].Name = "AP Date";
            grid_Sub.Columns[19].ReadOnly = true;
            grid_Sub.Columns[19].Width = 80;
            grid_Sub.Columns[19].MinimumWidth = 80;
            grid_Sub.Columns[19].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_Sub.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[19].DataPropertyName = "APDate";

            grid_Sub.Columns[20].Name = "AP Amount";
            grid_Sub.Columns[20].ReadOnly = true;
            grid_Sub.Columns[20].Width = 70;
            grid_Sub.Columns[20].MinimumWidth = 70;
            grid_Sub.Columns[20].DefaultCellStyle.Format = "N2";
            grid_Sub.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[20].DataPropertyName = "APAmount";

            grid_Sub.Columns[21].Name = "AP Status";
            grid_Sub.Columns[21].ReadOnly = true;
            grid_Sub.Columns[21].Width = 60;
            grid_Sub.Columns[21].MinimumWidth = 60;
            grid_Sub.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[21].DataPropertyName = "APStatus";

            grid_Sub.Columns[22].Name = "Last PaymentDate";
            grid_Sub.Columns[22].ReadOnly = true;
            grid_Sub.Columns[22].Width = 80;
            grid_Sub.Columns[22].MinimumWidth = 80;
            grid_Sub.Columns[22].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_Sub.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[22].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[22].DataPropertyName = "LastPaymentDate";

            grid_Sub.Columns[23].Name = "Payment Type";
            grid_Sub.Columns[23].ReadOnly = true;
            grid_Sub.Columns[23].Width = 70;
            grid_Sub.Columns[23].MinimumWidth = 70;
            grid_Sub.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[23].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[23].DataPropertyName = "PaymentType";

            grid_Sub.Columns[24].Name = "Last Check Number";
            grid_Sub.Columns[24].ReadOnly = true;
            grid_Sub.Columns[24].Width = 100;
            grid_Sub.Columns[24].MinimumWidth = 100;
            grid_Sub.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[24].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[24].DataPropertyName = "LastCheckNumber";

            grid_Sub.Columns[25].Name = "Last Check Date";
            grid_Sub.Columns[25].ReadOnly = true;
            grid_Sub.Columns[25].Width = 80;
            grid_Sub.Columns[25].MinimumWidth = 80;
            grid_Sub.Columns[25].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_Sub.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[25].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[25].DataPropertyName = "LastCheckDate";

            grid_Sub.Columns[26].Name = "AP Payment Allowance";
            grid_Sub.Columns[26].ReadOnly = true;
            grid_Sub.Columns[26].Visible = false;
            grid_Sub.Columns[26].Width = 80;
            grid_Sub.Columns[26].MinimumWidth = 80;
            grid_Sub.Columns[26].DefaultCellStyle.Format = "N2";
            grid_Sub.Columns[26].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[26].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[26].DataPropertyName = "APPaymentAllowance";

            grid_Sub.Columns[27].Name = "Credit";
            grid_Sub.Columns[27].ReadOnly = true;
            grid_Sub.Columns[27].Width = 80;
            grid_Sub.Columns[27].MinimumWidth = 80;
            grid_Sub.Columns[27].DefaultCellStyle.Format = "N2";
            grid_Sub.Columns[27].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[27].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[27].DataPropertyName = "CREDIT";

            grid_Sub.Columns[28].Name = "Debit";
            grid_Sub.Columns[28].ReadOnly = true;
            grid_Sub.Columns[28].Width = 80;
            grid_Sub.Columns[28].MinimumWidth = 80;
            grid_Sub.Columns[28].DefaultCellStyle.Format = "N2";
            grid_Sub.Columns[28].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[28].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[28].DataPropertyName = "DEBIT";

            grid_Sub.Columns[29].Name = "Payment Amount";
            grid_Sub.Columns[29].ReadOnly = true;
            grid_Sub.Columns[29].Width = 80;
            grid_Sub.Columns[29].MinimumWidth = 80;
            grid_Sub.Columns[29].DefaultCellStyle.Format = "N2";
            grid_Sub.Columns[29].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[29].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[29].DataPropertyName = "PaymentAmount";

            grid_Sub.Columns[30].Name = "Open Balance";
            grid_Sub.Columns[30].ReadOnly = true;
            grid_Sub.Columns[30].Width = 80;
            grid_Sub.Columns[30].MinimumWidth = 80;
            grid_Sub.Columns[30].DefaultCellStyle.Format = "N2";
            grid_Sub.Columns[30].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[30].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_Sub.Columns[30].DataPropertyName = "APOpenBalance";

            grid_Sub.Columns[31].Name = "AP Open Status";
            grid_Sub.Columns[31].ReadOnly = true;
            grid_Sub.Columns[31].Width = 100;
            grid_Sub.Columns[31].MinimumWidth = 100;
            grid_Sub.Columns[31].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[31].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Sub.Columns[31].DataPropertyName = "APOpenStatus";

            //grid font size custom
            grid_Sub.RowTemplate.Height = 20;
            grid_Sub.ColumnHeadersHeight = 100;

            foreach (DataGridViewColumn c in grid_Sub.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
            }

            grid_Sub.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFromDate.Value.Date;
            DateTime ToDate = dateTimePickerAsOf.Value.Date;
            String Supplier = cbo_Supplier.Text.Trim();
            String POStatus = cbo_POStatus.Text.Trim();
            String APStatus = cbo_APStatus.Text.Trim();
            connSalesOrder.sp_SubContractExceptionReport(grid_Sub, FromDate, ToDate, Supplier, POStatus, APStatus);
            
        }
        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFromDate.Value.Date;
            DateTime ToDate = dateTimePickerAsOf.Value.Date;
            String Supplier = cbo_Supplier.Text.Trim();
            String POStatus = cbo_POStatus.Text.Trim();
            String APStatus = cbo_APStatus.Text.Trim();

            Reports.Rpt_SubcontractExceptionReport subcontractExceptionReport = new Reports.Rpt_SubcontractExceptionReport(FromDate, ToDate, Supplier, POStatus, APStatus);
            subcontractExceptionReport.Show();

        }

        private void grid_Sub_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.grid_Sub.Rows)
            {
                row.Cells["Supplier"].Style.BackColor = Color.OldLace;
                row.Cells["PO Status"].Style.BackColor = Color.OldLace;
                row.Cells["AP Open Status"].Style.BackColor = Color.OldLace;
                
            }
        }
    }
}
