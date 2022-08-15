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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
            //connSalesOrder.cbo_site(cbo_site);
            //connSalesOrder.cbo_bank(cbo_bank);
            if (GATE.userID != "NYF01" && GATE.userID != "NYF02")
            {
                cbo_site.Items.Add("BCS");
                cbo_site.Items.Add("NYC");
                cbo_site.Items.Add("HYD");
                cbo_site.Items.Add("CFI");
                cbo_site.Items.Add("NTM");
            }
            cbo_site.Items.Add("NYF");

            cbo_bank.Items.Add("WB436");
            cbo_bank.Items.Add("BVC");
            cbo_bank.Items.Add("BCSB");
            connSalesOrder.cbo_paymentType(cbo_paymentType);
            cbo_paymentType.SelectedIndex = 0;

            grid_payments_Init();

            grid_remittances_Init();
            //connSalesOrder.sp_DEPOSIT_HEADER(grid_remittances);
            DateTime CreateTime = DatetimePicker_Createtime.Value.Date;
            connSalesOrder.sp_DEPOSIT_HEADER_BY_DATE(grid_remittances, CreateTime);
            grid_remittancesDetail_Init();

        }

        private void grid_remittances_Init()
        {
            grid_remittances.AutoGenerateColumns = false;
            grid_remittances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_remittances.ColumnCount = 8;

            grid_remittances.Columns[0].Name = "Slip No.";
            grid_remittances.Columns[0].ReadOnly = true;
            grid_remittances.Columns[0].Width = 90;
            grid_remittances.Columns[0].DataPropertyName = "FRMNUM_0";

            grid_remittances.Columns[1].Name = "Type";
            grid_remittances.Columns[1].ReadOnly = true;
            grid_remittances.Columns[1].Width = 90;
            grid_remittances.Columns[1].DataPropertyName = "PAYTYP_0";
            
            grid_remittances.Columns[2].Name = "Bank";
            grid_remittances.Columns[2].ReadOnly = true;
            grid_remittances.Columns[2].Width = 90;
            grid_remittances.Columns[2].DataPropertyName = "BAN_0";

            grid_remittances.Columns[3].Name = "Status";
            grid_remittances.Columns[3].Visible = false;
            grid_remittances.Columns[3].Width = 90;
            grid_remittances.Columns[3].DataPropertyName = "STA_0";

            grid_remittances.Columns[4].Name = "Company";
            grid_remittances.Columns[4].Visible = false;
            grid_remittances.Columns[4].Width = 90;
            grid_remittances.Columns[4].DataPropertyName = "CPY_0";

            grid_remittances.Columns[5].Name = "Site";
            grid_remittances.Columns[5].ReadOnly = true;
            grid_remittances.Columns[5].Width = 90;
            grid_remittances.Columns[5].DataPropertyName = "FRMFCY_0";

            grid_remittances.Columns[6].Name = "Create Date";
            grid_remittances.Columns[6].ReadOnly = true;
            grid_remittances.Columns[6].Width = 80;
            grid_remittances.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_remittances.Columns[6].DataPropertyName = "CREDAT_0";

            grid_remittances.Columns[7].Name = "Total";
            grid_remittances.Columns[7].ReadOnly = true;
            grid_remittances.Columns[7].Width = 70;
            grid_remittances.Columns[7].DefaultCellStyle.Format = "N2";
            grid_remittances.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_remittances.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_remittances.Columns[7].DataPropertyName = "Total";


            //grid font size custom
            grid_remittances.RowTemplate.Height = 20;
            grid_remittances.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_remittances.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_remittances.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_remittancesDetail_Init()
        {
            grid_remittancesDetail.AutoGenerateColumns = false;
            grid_remittancesDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_remittancesDetail.ColumnCount = 6;

            grid_remittancesDetail.Columns[0].Name = "No.";
            grid_remittancesDetail.Columns[0].ReadOnly = true;
            grid_remittancesDetail.Columns[0].Width = 90;
            grid_remittancesDetail.Columns[0].DataPropertyName = "NUM_0";

            grid_remittancesDetail.Columns[1].Name = "Customer ID";
            grid_remittancesDetail.Columns[1].ReadOnly = true;
            grid_remittancesDetail.Columns[1].Width = 120;
            grid_remittancesDetail.Columns[1].DataPropertyName = "BPR_0";

            grid_remittancesDetail.Columns[2].Name = "Customer Name";
            grid_remittancesDetail.Columns[2].ReadOnly = true;
            grid_remittancesDetail.Columns[2].Width = 150;
            grid_remittancesDetail.Columns[2].DataPropertyName = "CompanyName";

            grid_remittancesDetail.Columns[3].Name = "Acc Date";
            grid_remittancesDetail.Columns[3].ReadOnly = true;
            grid_remittancesDetail.Columns[3].Width = 100;
            grid_remittancesDetail.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_remittancesDetail.Columns[3].DataPropertyName = "ACCDAT_0";

            grid_remittancesDetail.Columns[4].Name = "Amount";
            grid_remittancesDetail.Columns[4].Width = 70;
            grid_remittancesDetail.Columns[4].ReadOnly = true;
            grid_remittancesDetail.Columns[4].DefaultCellStyle.Format = "N2";
            grid_remittancesDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_remittancesDetail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_remittancesDetail.Columns[4].DataPropertyName = "AMTCUR_0";

            grid_remittancesDetail.Columns[5].Name = "Site";
            grid_remittancesDetail.Columns[5].ReadOnly = true;
            grid_remittancesDetail.Columns[5].Width = 60;
            grid_remittancesDetail.Columns[5].DataPropertyName = "FCY_0";

            //grid font size custom
            grid_remittancesDetail.RowTemplate.Height = 20;
            grid_remittancesDetail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_remittancesDetail.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_remittancesDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_payments_Init()
        {
            grid_payments.AutoGenerateColumns = false;
            grid_payments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_payments.ColumnCount = 6;

            DataGridViewCheckBoxColumn paymentCheck = new DataGridViewCheckBoxColumn();
            paymentCheck.HeaderText = "X";
            paymentCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            paymentCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            paymentCheck.FalseValue = false;
            paymentCheck.TrueValue = true;
            paymentCheck.Name = "paymentSelect";
            paymentCheck.ReadOnly = true;
            paymentCheck.Width = 25;
            paymentCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_payments.Columns.Insert(0, paymentCheck);
            grid_payments.CellContentClick += new DataGridViewCellEventHandler(paymentSelect);

            grid_payments.Columns[1].Name = "No.";
            grid_payments.Columns[1].ReadOnly = true;
            grid_payments.Columns[1].Width = 100;
            grid_payments.Columns[1].DataPropertyName = "NUM_0";


            grid_payments.Columns[2].Name = "Customer";
            grid_payments.Columns[2].ReadOnly = true;
            grid_payments.Columns[2].Width = 120;
            grid_payments.Columns[2].DataPropertyName = "BPR_0";

            grid_payments.Columns[3].Name = "Amount";
            grid_payments.Columns[3].ReadOnly = true;
            grid_payments.Columns[3].Width = 70;
            grid_payments.Columns[3].DefaultCellStyle.Format = "N2";
            grid_payments.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_payments.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_payments.Columns[3].DataPropertyName = "AMTCUR_0";

            grid_payments.Columns[4].Name = "Acc Date";
            grid_payments.Columns[4].ReadOnly = true;
            grid_payments.Columns[4].Width = 90;
            grid_payments.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_payments.Columns[4].DataPropertyName = "ACCDAT_0";

            grid_payments.Columns[5].Name = "Check No.";
            grid_payments.Columns[5].ReadOnly = true;
            grid_payments.Columns[5].Width = 80;
            grid_payments.Columns[5].DataPropertyName = "CHQNUM_0";

            grid_payments.Columns[6].Name = "PAM_0";
            grid_payments.Columns[6].ReadOnly = true;
            grid_payments.Columns[6].Width = 80;
            grid_payments.Columns[6].DataPropertyName = "PAM_0";

            //grid font size custom
            grid_payments.RowTemplate.Height = 20;
            grid_payments.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_payments.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_payments.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void paymentSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Ready check box click
            {

                if (Convert.ToBoolean(grid_payments.Rows[e.RowIndex].Cells["paymentSelect"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                {

                    grid_payments.Rows[e.RowIndex].Cells["paymentSelect"].Value = true;


                }
                else // uncheck 했을 때
                {

                    grid_payments.Rows[e.RowIndex].Cells["paymentSelect"].Value = false;

                }
                CalculateTotal();

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {


            txt_site.Text = cbo_site.Text;
            txt_bank.Text = cbo_bank.Text;
            txt_paymentType.Text = cbo_paymentType.Text;

            String Site = txt_site.Text;
            String Bank = txt_bank.Text;
            String PaymentType = txt_paymentType.Text;

            connSalesOrder.sp_PAYMENTT_GetPayments(grid_payments, Site, Bank, PaymentType);
            for (int i = 0; i < grid_payments.RowCount; i++)
            {

                grid_payments.Rows[i].Cells["paymentSelect"].Value = true;

            }

            CalculateTotal();

        }

        private void CalculateTotal()
        {
            Decimal Amount = 0;
            Decimal AmountTotal = 0;
            for (int i = 0; i < grid_payments.RowCount; i++)
            {
                Amount = 0;
                if (Convert.ToBoolean(grid_payments.Rows[i].Cells["paymentSelect"].EditedFormattedValue) == true)
                {
                    Amount = Convert.ToDecimal(grid_payments.Rows[i].Cells["Amount"].Value.ToString());

                }
                AmountTotal = AmountTotal + Amount;
            }

            txt_total.Text = AmountTotal.ToString("N2");
        }

        String PAM_0;
        private void btn_create_Click(object sender, EventArgs e)
        {

            if (txt_site.Text.Trim() == "" || txt_bank.Text.Trim() == "" || txt_paymentType.Text.Trim() == "")
            {
                MessageBox.Show("input site, bank, payment type."
                                                    , "STOP", MessageBoxButtons.OK);
                return;
            }

            String Bank = txt_bank.Text.Trim();

            //if(Bank == "WB436")
            //{
            //    for (int i = 0; i < grid_payments.RowCount; i++)
            //    {
            //        String PAM_0 = grid_payments.Rows[i].Cells["PAM_0"].Value.ToString();
            //        if(PAM_0 != "CHQ")
            //        {
            //            MessageBox.Show("Payment must be check(CHQ)."
            //                                        , "STOP", MessageBoxButtons.OK);
            //            return;
            //        }
            //    }
            //}
            //else if(Bank == "BVC")
            //{
            //    for (int i = 0; i < grid_payments.RowCount; i++)
            //    {
            //        String PAM_0 = grid_payments.Rows[i].Cells["PAM_0"].Value.ToString();
            //        if (PAM_0 != "CSH")
            //        {
            //            MessageBox.Show("Payment must be cash(CSH)."
            //                                        , "STOP", MessageBoxButtons.OK);
            //            return;
            //        }
            //    }
            //}
            //else if(Bank == "BCSB")
            //{
            //    for (int i = 0; i < grid_payments.RowCount; i++)
            //    {
            //        String PAM_0 = grid_payments.Rows[i].Cells["PAM_0"].Value.ToString();
            //        if (PAM_0 != "ACH")
            //        {
            //            MessageBox.Show("Payment must be wireless transfer(ACH)."
            //                                        , "STOP", MessageBoxButtons.OK);
            //            return;
            //        }
            //    }
            //}

            DialogResult dialogResult = MessageBox.Show("Are you sure run the deposit slip process?"
                                                    , "Confirming", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                //Get a new Invoice Number from Server 12/24/2018
                String NewDEPNumber = connSalesOrder.sp_GET_NewDEPNumber();

                String Site = txt_site.Text.Trim();

                String NewBMWNumber = connSalesOrder.sp_GET_NewBMWNumber(Bank);

                for (int i = 0; i < grid_payments.RowCount; i++)
                {
                    if (Convert.ToBoolean(grid_payments.Rows[i].Cells["paymentSelect"].EditedFormattedValue) == true)
                    {
                        String RECCHNumber = grid_payments.Rows[i].Cells["No."].Value.ToString();
                        connSalesOrder.sp_DEPOSIT_CREATEDETAIL(RECCHNumber, NewDEPNumber, NewBMWNumber);
                    }
                    PAM_0 = grid_payments.Rows[i].Cells["PAM_0"].Value.ToString();
                }
                //create header
                connSalesOrder.sp_DEPOSIT_CREATEHEADER(Site, Bank, PAM_0, NewDEPNumber, NewBMWNumber);

                //refresh
                //connSalesOrder.sp_DEPOSIT_HEADER(grid_remittances);

                DatetimePicker_Createtime.Value = DateTime.Today.Date;
                DateTime CreateTime = DatetimePicker_Createtime.Value.Date;
                connSalesOrder.sp_DEPOSIT_HEADER_BY_DATE(grid_remittances, CreateTime);


                String PaymentType = cbo_paymentType.Text;
                connSalesOrder.sp_PAYMENTT_GetPayments(grid_payments, Site, Bank, PaymentType);
                for (int i = 0; i < grid_payments.RowCount; i++)
                {
                    grid_payments.Rows[i].Cells["paymentSelect"].Value = true;
                }
                
                CalculateTotal();
            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }

        private void grid_remittances_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String DEPNumber = grid_remittances.Rows[e.RowIndex].Cells["Slip No."].Value.ToString();
            connSalesOrder.sp_DEPOSIT_DETAIL(grid_remittancesDetail, DEPNumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

        private void btnslipPrint_Click(object sender, EventArgs e)
        {
            string Site = cbo_site.Text.Trim();
            string Bank = cbo_bank.Text.Trim();
            string PaymentType = cbo_paymentType.Text.Trim();

            Reports.Rpt_PAYMENTT_GetPayments Depositslip_Print = new Reports.Rpt_PAYMENTT_GetPayments(Site, Bank, PaymentType);
            Depositslip_Print.Show();

            ///*DEPOSITSLIP_PRINT slip_print= new DEPOSITSLIP_PRINT();
            //slip_print.StartPosition = FormStartPosition.CenterScreen;
            //slip_print.Show();*/
            //connSalesOrder.sp_PAYMENTT_GetPayments(grid_payments, "", "", "");
            //SaveFileDialog sfd = new SaveFileDialog();


            //sfd.Filter = "Excel Documents (*.xls)|*.xls";
            //sfd.FileName = DateTime.Now.ToString("MMddyyy") + "_Deposit_slip.xls";
            //if (sfd.ShowDialog() == DialogResult.OK)

            //    try
            //    {
            //        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            //        excel.Visible = true;
            //        Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            //        Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            //        int StartCol = 1;
            //        int StartRow = 1;
            //        int j = 0, i = 0;

            //        //Write Headers
            //        for (j = 0; j < grid_payments.Columns.Count; j++)
            //        {
            //            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
            //            myRange.Value2 = grid_payments.Columns[j].HeaderText;
            //        }

            //        StartRow++;

            //        //Write datagridview content
            //        for (i = 0; i < grid_payments.Rows.Count; i++)
            //        {
            //            for (j = 0; j < grid_payments.Columns.Count; j++)
            //            {
            //                try
            //                {

            //                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
            //                    myRange.Value2 = grid_payments[j, i].Value == null ? "" : grid_payments[j, i].Value;
            //                    /*Microsoft.Office.Interop.Excel.Range myRange4 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, 5];

            //                    myRange4.EntireColumn.NumberFormat = "MM/DD/YYYY";*/
            //                    if (j == 4)
            //                        myRange.NumberFormat = "MM/dd/yyyy";
            //                }
            //                catch
            //                {

            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }

        }

        private void DatetimePicker_Createtime_ValueChanged(object sender, EventArgs e)
        {
            DateTime CreateTime = DatetimePicker_Createtime.Value.Date;
            connSalesOrder.sp_DEPOSIT_HEADER_BY_DATE(grid_remittances, CreateTime);
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            DatetimePicker_Createtime.Value = DateTime.Today;
            grid_remittances.DataSource = null;
            connSalesOrder.sp_DEPOSIT_HEADER(grid_remittances);
        }
    }
}
