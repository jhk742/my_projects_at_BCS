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
    public partial class SalesbyCustomerReport : Form
    {
        //bool isDataGridFormatted = false;
        //DataTable dataTable = new DataTable();
        public SalesbyCustomerReport()
        {
            InitializeComponent();
            grid_salesReport_Init();
            grid_State_Init();
            grid_City_Init();
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-14);

            connSalesOrder.sp_GET_ShipState(grid_State);
            connSalesOrder.sp_GET_ShipCity(grid_City);
        }

        private void SalesbyCustomerReport_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_City.RowCount; i++)
                grid_City.Rows[i].Cells[0].Value = true;
            for (int i = 0; i < grid_State.RowCount; i++)
                grid_State.Rows[i].Cells[0].Value = true;
        }

        private void grid_State_Init()
        {
            grid_State.AutoGenerateColumns = false;
            grid_State.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_State.ColumnCount = 1;

            DataGridViewCheckBoxColumn confirmCheck = new DataGridViewCheckBoxColumn();
            confirmCheck.HeaderText = "V";
            confirmCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            confirmCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            confirmCheck.FalseValue = false;
            confirmCheck.TrueValue = true;
            confirmCheck.Name = "CheckBox";
            confirmCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            confirmCheck.ReadOnly = true;
            confirmCheck.Width = 25;
            confirmCheck.HeaderCell.Style.ForeColor = Color.Red;
            confirmCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            confirmCheck.ToolTipText = "(Un)Check all";
            grid_State.Columns.Insert(0, confirmCheck);
            grid_State.CellContentClick += new DataGridViewCellEventHandler(confirmcellclick);

            grid_State.Columns[1].Name = "State";
            grid_State.Columns[1].ReadOnly = true;
            grid_State.Columns[1].Width = 10;
            grid_State.Columns[1].MinimumWidth = 10;
            grid_State.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_State.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_State.Columns[1].DataPropertyName = "ShipState";


            //grid font size custom
            grid_State.RowTemplate.Height = 20;
            grid_State.ColumnHeadersHeight = 35;

            foreach (DataGridViewColumn c in grid_State.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < grid_State.ColumnCount; i++)
            {
                grid_State.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            grid_State.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_City_Init()
        {
            grid_City.AutoGenerateColumns = false;
            grid_City.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_City.ColumnCount = 1;

            DataGridViewCheckBoxColumn confirmCheck = new DataGridViewCheckBoxColumn();
            confirmCheck.HeaderText = "V";
            confirmCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            confirmCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            confirmCheck.FalseValue = false;
            confirmCheck.TrueValue = true;
            confirmCheck.Name = "CheckBox";
            confirmCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            confirmCheck.ReadOnly = true;
            confirmCheck.Width = 25;
            confirmCheck.HeaderCell.Style.ForeColor = Color.Red;
            confirmCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            confirmCheck.ToolTipText = "(Un)Check all";
            grid_City.Columns.Insert(0, confirmCheck);
            grid_City.CellContentClick += new DataGridViewCellEventHandler(confirmcellclick);

            grid_City.Columns[1].Name = "City";
            grid_City.Columns[1].ReadOnly = true;
            grid_City.Columns[1].Width = 10;
            grid_City.Columns[1].MinimumWidth = 10;
            grid_City.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_City.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_City.Columns[1].DataPropertyName = "ShipCity";


            //grid font size custom
            grid_City.RowTemplate.Height = 20;
            grid_City.ColumnHeadersHeight = 35;

            foreach (DataGridViewColumn c in grid_City.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < grid_City.ColumnCount; i++)
            {
                grid_City.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            grid_City.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_salesReport_Init()
        {
            grid_salesReport.AutoGenerateColumns = false;
            grid_salesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_salesReport.ColumnCount = 18;

            grid_salesReport.Columns[0].Name = "State";
            grid_salesReport.Columns[0].ReadOnly = true;
            grid_salesReport.Columns[0].Width = 25;
            grid_salesReport.Columns[0].MinimumWidth = 25;
            grid_salesReport.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[0].DataPropertyName = "State";

            grid_salesReport.Columns[1].Name = "City";
            grid_salesReport.Columns[1].ReadOnly = true;
            grid_salesReport.Columns[1].Width = 60;
            grid_salesReport.Columns[1].MinimumWidth = 60;
            grid_salesReport.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[1].DataPropertyName = "City";

            grid_salesReport.Columns[2].Name = "CustomerID";
            grid_salesReport.Columns[2].ReadOnly = true;
            grid_salesReport.Columns[2].Width = 60;
            grid_salesReport.Columns[2].MinimumWidth = 60;
            grid_salesReport.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[2].DataPropertyName = "CustomerID";

            grid_salesReport.Columns[3].Name = "CustomerName";
            grid_salesReport.Columns[3].ReadOnly = true;
            grid_salesReport.Columns[3].Width = 180;
            grid_salesReport.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[3].DataPropertyName = "CustomerName";

            grid_salesReport.Columns[4].Name = "REP";
            grid_salesReport.Columns[4].ReadOnly = true;
            grid_salesReport.Columns[4].Width = 25;
            grid_salesReport.Columns[4].MinimumWidth = 25;
            grid_salesReport.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[4].DataPropertyName = "REP";

            grid_salesReport.Columns[5].Name = "Gross Sales";
            grid_salesReport.Columns[5].ReadOnly = true;
            grid_salesReport.Columns[5].Width = 55;
            grid_salesReport.Columns[5].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[5].DataPropertyName = "GrossSales";

            grid_salesReport.Columns[6].Name = "Promotion";
            grid_salesReport.Columns[6].ReadOnly = true;
            grid_salesReport.Columns[6].Width = 55;
            grid_salesReport.Columns[6].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[6].DataPropertyName = "Promotion";

            grid_salesReport.Columns[7].Name = "Promotion Ratio";
            grid_salesReport.Columns[7].ReadOnly = true;
            grid_salesReport.Columns[7].Width = 60;
            grid_salesReport.Columns[7].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[7].DataPropertyName = "PromotionRatio";

            grid_salesReport.Columns[8].Name = "Credit";
            grid_salesReport.Columns[8].ReadOnly = true;
            grid_salesReport.Columns[8].Width = 55;
            grid_salesReport.Columns[8].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[8].DataPropertyName = "Credit";

            grid_salesReport.Columns[9].Name = "Credit Ratio";
            grid_salesReport.Columns[9].ReadOnly = true;
            grid_salesReport.Columns[9].Width = 55;
            grid_salesReport.Columns[9].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[9].DataPropertyName = "CreditRatio";

            grid_salesReport.Columns[10].Name = "Sales Allowance";
            grid_salesReport.Columns[10].ReadOnly = true;
            grid_salesReport.Columns[10].Visible = false;
            grid_salesReport.Columns[10].Width = 50;
            grid_salesReport.Columns[10].ToolTipText = "Promotion + Credit";
            grid_salesReport.Columns[10].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[10].DataPropertyName = "SalesAllowance";

            grid_salesReport.Columns[11].Name = "Return Credit";
            grid_salesReport.Columns[11].ReadOnly = true;
            grid_salesReport.Columns[11].Width = 70;
            grid_salesReport.Columns[11].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[11].DataPropertyName = "ReturnCredit";

            grid_salesReport.Columns[12].Name = "Return Credit Ratio";
            grid_salesReport.Columns[12].ReadOnly = true;
            grid_salesReport.Columns[12].Width = 90;
            grid_salesReport.Columns[12].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[12].DataPropertyName = "ReturnCreditRatio";

            grid_salesReport.Columns[13].Name = "Term Credit";
            grid_salesReport.Columns[13].ReadOnly = true;
            grid_salesReport.Columns[13].Width = 50;
            grid_salesReport.Columns[13].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[13].DataPropertyName = "TermCredit";

            grid_salesReport.Columns[14].Name = "Term Credit Ratio";
            grid_salesReport.Columns[14].ReadOnly = true;
            grid_salesReport.Columns[14].Width = 70;
            grid_salesReport.Columns[14].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[14].DataPropertyName = "TermCreditRatio";

            grid_salesReport.Columns[15].Name = "Sales Discount";
            grid_salesReport.Columns[15].ReadOnly = true;
            grid_salesReport.Columns[15].Visible = false;
            grid_salesReport.Columns[15].Width = 10;
            grid_salesReport.Columns[15].ToolTipText = "Term Credit";
            grid_salesReport.Columns[15].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[15].DataPropertyName = "SalesDiscount";

            grid_salesReport.Columns[16].Name = "Net Sales";
            grid_salesReport.Columns[16].ReadOnly = true;
            grid_salesReport.Columns[16].Width = 100;
            grid_salesReport.Columns[16].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[16].DataPropertyName = "NetSales";

            grid_salesReport.Columns[17].Name = "COGS";
            grid_salesReport.Columns[17].ReadOnly = true;
            grid_salesReport.Columns[17].Width = 100;
            grid_salesReport.Columns[17].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[17].DataPropertyName = "COGS";
            
            //grid font size custom
            grid_salesReport.RowTemplate.Height = 20;
            grid_salesReport.ColumnHeadersHeight = 35;

            foreach (DataGridViewColumn c in grid_salesReport.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_salesReport.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        
        private void CalculateTotal()
        {
            int RowCount = 0;
            decimal TotalGrossSales = 0, TotalPromotion = 0, TotalCredit = 0, TotalReturnCredit = 0, TotalTermCredit = 0, TotalNetSales = 0, TotalCOGS = 0;

            if (grid_salesReport.RowCount > 0)
            {
                try
                {
                    for (int i = 0; i < grid_salesReport.RowCount; i++)
                    {
                        TotalGrossSales += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Gross Sales"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Gross Sales"].Value);
                        TotalPromotion += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Promotion"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Promotion"].Value);
                        TotalCredit += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Credit"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Credit"].Value);
                        TotalReturnCredit += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Return Credit"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Return Credit"].Value);
                        TotalTermCredit += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Term Credit"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Term Credit"].Value);
                        TotalNetSales += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Net Sales"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Net Sales"].Value);
                        TotalCOGS += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["COGS"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["COGS"].Value);
                        RowCount++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            txt_SAGrossSales.Text = TotalGrossSales.ToString("N");
            txt_GAGrossSales.Text = TotalGrossSales.ToString("N");
            txt_SAPromo.Text = TotalPromotion.ToString("N");
            txt_SAPromoRatio.Text = (TotalGrossSales == 0 ? "0" : (TotalPromotion / TotalGrossSales * 100).ToString("N"));
            txt_SACredit.Text = TotalCredit.ToString("N");
            txt_SalesAllowance.Text = (TotalPromotion + TotalCredit).ToString("N");
            txt_CreditRatio.Text = (TotalGrossSales == 0 ? "0" : (TotalCredit / TotalGrossSales * 100).ToString("N"));
            txt_SAReturnCredit.Text = TotalReturnCredit.ToString("N");
            txt_GAReturnCredit.Text = TotalReturnCredit.ToString("N");
            txt_SAReturnCreditRatio.Text = (TotalGrossSales == 0 ? "0" : (TotalReturnCredit / TotalGrossSales * 100).ToString("N"));
            txt_SATermCredit.Text = TotalTermCredit.ToString("N");
            txt_SalesDiscount.Text = TotalTermCredit.ToString("N");
            txt_SATermCreditRatio.Text = (TotalGrossSales == 0 ? "0" : (TotalTermCredit / TotalGrossSales * 100).ToString("N"));
            txt_SANetSales.Text = (TotalGrossSales - TotalPromotion - TotalReturnCredit - TotalCredit - TotalTermCredit).ToString("N");
            txt_GANetSales.Text = (TotalGrossSales - TotalPromotion - TotalReturnCredit - TotalCredit - TotalTermCredit).ToString("N");
            txt_SACOGS.Text = TotalCOGS.ToString("N");
            lbl_RowCount.Text = "Row Count : " + RowCount.ToString();
        }
        private String GridConvertToString(DataGridView gridView)
        {
            try
            {
                if (gridView.Name.Equals("grid_State")) gridView = grid_State;
                else if (gridView.Name.Equals("grid_City")) gridView = grid_City;

                String TextString = "";
                List<string> List = new List<string>();
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    if (gridView.Rows[i].Cells[0].Value.Equals(true))
                    {
                        List.Add(gridView.Rows[i].Cells[1].Value.ToString());
                    }
                }
                string[] Array = List.ToArray();

                for (int i = 0; i < Array.Length; i++)
                {
                    TextString += Array[i].ToString();
                    if (i < (Array.Length - 1)) TextString += ",";
                }

                return TextString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("GridConvertToString\nError : " + ex.Message.ToString(), "Information");
                return "";
            }

        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String CustomerID = txt_CustomerID.Text.ToString();
            String CustomerName = txt_customerName.Text.ToString();

            if (grid_State.DataSource == null || grid_City.DataSource == null)
            {
                MessageBox.Show("Something went wrong. Please close the form and try again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            connSalesOrder.sp_SalesbyCustomerReport(grid_salesReport, CustomerID, CustomerName, FromDate, ToDate, GridConvertToString(grid_State), GridConvertToString(grid_City));
            CalculateTotal();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String CustomerID = txt_CustomerID.Text.ToString();
            String CustomerName = txt_customerName.Text.ToString();

            if (rdb_GAVersion.Checked)
            {
                Reports.Rpt_SalesbyCustomerReport_GA salesReport = new Reports.Rpt_SalesbyCustomerReport_GA(CustomerID, CustomerName, FromDate, ToDate, GridConvertToString(grid_State), GridConvertToString(grid_City));
                salesReport.Show();
            }
            else if (rdb_SalesVersion.Checked)
            {
                Reports.Rpt_SalesbyCustomerReport salesReport = new Reports.Rpt_SalesbyCustomerReport(CustomerID, CustomerName, FromDate, ToDate, GridConvertToString(grid_State), GridConvertToString(grid_City));
                salesReport.Show();
            }
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date <= Convert.ToDateTime("01/06/2020"))
            {
                dateTimePickerFrom.Value = Convert.ToDateTime("01/06/2020");
            }
        }
        
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                if(((RadioButton)sender) == rdb_SalesVersion)
                {
                    rdb_GAVersion.Checked = false;

                    grid_salesReport.Columns[4].Visible = true; //REP
                    grid_salesReport.Columns[6].Visible = true; //Promotion
                    grid_salesReport.Columns[7].Visible = true; //Promotion Ratio
                    grid_salesReport.Columns[8].Visible = true; //Credit
                    grid_salesReport.Columns[9].Visible = true; //Credit Ratio
                    grid_salesReport.Columns[12].Visible = true; //Return Credit Ratio
                    grid_salesReport.Columns[13].Visible = true; //Term Credit
                    grid_salesReport.Columns[14].Visible = true; //Term Credit Ratio
                    grid_salesReport.Columns[17].Visible = true; //COGS

                    grid_salesReport.Columns[10].Visible = false; //Sales Allowance
                    grid_salesReport.Columns[15].Visible = false; //Sales Discount

                    grid_salesReport.Columns[0].Width = 25;
                    grid_salesReport.Columns[1].Width = 80;
                    grid_salesReport.Columns[2].Width = 70;
                    grid_salesReport.Columns[3].Width = 180;
                    grid_salesReport.Columns[4].Width = 25;
                    grid_salesReport.Columns[5].Width = 55;
                    grid_salesReport.Columns[6].Width = 55;
                    grid_salesReport.Columns[7].Width = 65;
                    grid_salesReport.Columns[8].Width = 55;
                    grid_salesReport.Columns[9].Width = 55;
                    grid_salesReport.Columns[11].Width = 55;
                    grid_salesReport.Columns[12].Width = 70;
                    grid_salesReport.Columns[13].Width = 55;
                    grid_salesReport.Columns[14].Width = 70;
                    grid_salesReport.Columns[16].Width = 100;
                    grid_salesReport.Columns[17].Width = 100;

                    pn_Sales.Visible = true;
                    pn_GA.Visible = false;
                }
                else if(((RadioButton)sender) == rdb_GAVersion)
                {
                    rdb_SalesVersion.Checked = false;

                    grid_salesReport.Columns[4].Visible = false; //REP
                    grid_salesReport.Columns[6].Visible = false; //Promotion
                    grid_salesReport.Columns[7].Visible = false; //Promotion Ratio
                    grid_salesReport.Columns[8].Visible = false; //Credit
                    grid_salesReport.Columns[9].Visible = false; //Credit Ratio
                    grid_salesReport.Columns[12].Visible = false; //Return Credit Ratio
                    grid_salesReport.Columns[13].Visible = false; //Term Credit
                    grid_salesReport.Columns[14].Visible = false; //Term Credit Ratio
                    grid_salesReport.Columns[17].Visible = false; //COGS

                    grid_salesReport.Columns[10].Visible = true; //Sales Allowance
                    grid_salesReport.Columns[15].Visible = true; //Sales Discount

                    grid_salesReport.Columns[0].Width = 30;
                    grid_salesReport.Columns[1].Width = 80;
                    grid_salesReport.Columns[2].Width = 60;
                    grid_salesReport.Columns[3].Width = 150;
                    grid_salesReport.Columns[5].Width = 80;
                    grid_salesReport.Columns[10].Width = 80;
                    grid_salesReport.Columns[11].Width = 80;
                    grid_salesReport.Columns[15].Width = 80;
                    grid_salesReport.Columns[16].Width = 200;

                    pn_GA.Visible = true;
                    pn_Sales.Visible = false;
                }
            }
        }
        private void AddTotalRow()
        {
            //if (grid_salesReport.RowCount > 0)
            //{
            //    try
            //    {
            //        dataTable = (DataTable)grid_salesReport.DataSource;

            //        DataRow drToAdd = dataTable.NewRow();
            //        drToAdd["State"] = "Total";
            //        drToAdd["City"] = "";
            //        drToAdd["CustomerID"] = "";
            //        drToAdd["CustomerName"] = "";
            //        drToAdd["REP"] = "";
            //        drToAdd["GrossSales"] = TotalGrossSales.ToString();
            //        drToAdd["Promotion"] = TotalPromotion.ToString();
            //        drToAdd["PromotionRatio"] = (TotalGrossSales == 0 ? "0" : (TotalPromotion / TotalGrossSales * 100).ToString("F"));
            //        drToAdd["Credit"] = TotalCredit.ToString();
            //        drToAdd["SalesAllowance"] = (TotalPromotion + TotalCredit).ToString();
            //        drToAdd["CreditRatio"] = (TotalGrossSales == 0 ? "0" : (TotalCredit / TotalGrossSales * 100).ToString("F"));
            //        drToAdd["ReturnCredit"] = TotalReturnCredit.ToString();
            //        drToAdd["ReturnCreditRatio"] = (TotalGrossSales == 0 ? "0" : (TotalReturnCredit / TotalGrossSales * 100).ToString("F"));
            //        drToAdd["TermCredit"] = TotalTermCredit.ToString();
            //        drToAdd["SalesDiscount"] = TotalTermCredit.ToString();
            //        drToAdd["TermCreditRatio"] = (TotalGrossSales == 0 ? "0" : (TotalTermCredit / TotalGrossSales * 100).ToString("F"));
            //        drToAdd["NetSales"] = (TotalGrossSales - TotalPromotion - TotalReturnCredit - TotalCredit - TotalTermCredit).ToString();
            //        drToAdd["COGS"] = TotalCOGS.ToString();

            //        //dataTable.Rows.InsertAt(drToAdd, grid_salesReport.RowCount);
            //        dataTable.Rows.Add(drToAdd);

            //        dataTable.AcceptChanges();

            //        this.grid_salesReport.ClearSelection();


            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}
        }
        private void grid_salesReport_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //if (isDataGridFormatted) return;

            //MessageBox.Show("grid_salesReport_DataBindingComplete isDataGridFormatted : " + isDataGridFormatted.ToString());
            //isDataGridFormatted = true;
            //foreach (DataGridViewRow row in this.grid_salesReport.Rows)
            //{
            //    if (row.Cells["State"].Value.Equals("Total"))
            //    {
            //        grid_salesReport.Rows.Remove(row);
            //        dataTable.Rows.Add(row);
            //    }
            //}
            ////MessageBox.Show(dataTable.Rows.Count.ToString()+"\n"+ dataTable.Columns.Count.ToString());
            ////DataRow[] dr = dataTable.Select("State = Total");
            ////DataRow newRow = dataTable.NewRow();
            ////// We "clone" the row
            ////newRow.ItemArray = dr[0].ItemArray;
            ////// We remove the old and insert the new
            ////dataTable.Rows.Remove(dr[0]);
            ////dataTable.Rows.Add(newRow);


            //foreach (DataGridViewRow row in this.grid_salesReport.Rows)
            //{
            //    if (row.Cells["State"].Value.Equals("Total"))
            //    {
            //        for (int i = 0; i < grid_salesReport.ColumnCount; i++)
            //        {
            //            row.Cells[i].Style.BackColor = Color.Gray;
            //            row.Cells[i].Style.ForeColor = Color.White;
            //        }
            //    }
            //}
        }
        private void grid_salesReport_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //isDataGridFormatted = false;
            //foreach (DataGridViewRow row in this.grid_salesReport.Rows)
            //{
            //    if (row.Cells["State"].Value.Equals("Total"))
            //    {
            //        grid_salesReport.Rows.Remove(row);
            //    }
            //}
            //switch (e.ColumnIndex)
            //{
            //    case 0:
            //        if (dataTable.DefaultView.Sort.Equals("State ASC")) dataTable.DefaultView.Sort = "State DESC";
            //        dataTable.DefaultView.Sort = "State ASC";
            //        break;
            //    case 1:
            //        if (dataTable.DefaultView.Sort.Equals("City ASC")) dataTable.DefaultView.Sort = "City DESC";
            //        dataTable.DefaultView.Sort = "City ASC";
            //        break;
            //    case 2:
            //        if (dataTable.DefaultView.Sort.Equals("CustomerID ASC")) dataTable.DefaultView.Sort = "CustomerID DESC";
            //        dataTable.DefaultView.Sort = "CustomerID ASC";
            //        break;
            //    default:
            //        dataTable.DefaultView.Sort = "GrossSales";
            //        break;
            //}
            //MessageBox.Show(e.ColumnIndex.ToString());
            //AddTotalRow();

        }
        private void grid_salesReport_Sorted(object sender, EventArgs e)
        {

            //MessageBox.Show("grid_salesReport_Sorted isDataGridFormatted : "+ isDataGridFormatted.ToString());
            //isDataGridFormatted = true;
            //try
            //{
            //    DataGridViewRow TotalRow = new DataGridViewRow();
            //    foreach (DataGridViewRow row in this.grid_salesReport.Rows)
            //    {
            //        if (row.Cells["State"].Value.Equals("Total"))
            //        {
            //            TotalRow = row;
            //            grid_salesReport.Rows.Remove(row);
            //        }
            //    }
            //    //MessageBox.Show(TotalRow.Cells[0].Value.ToString());
            //    //grid_salesReport.Rows.Insert(grid_salesReport.RowCount, TotalRow);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }
        private void grid_salesReport_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //MessageBox.Show("grid_salesReport_RowsRemoved\nisDataGridFormatted : " + isDataGridFormatted.ToString());
            //if (isDataGridFormatted)
            //{
            //    DataRow drToAdd = dataTable.NewRow();
            //    drToAdd["State"] = "Total";
            //    dataTable.Rows.Add(drToAdd);
            //    dataTable.AcceptChanges();
            //    this.grid_salesReport.ClearSelection();

            //    isDataGridFormatted = false;

            //}
        }

        private void confirmcellclick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridview = (DataGridView)sender;
            try
            {
                if (e.ColumnIndex == 0) //confirm check box click
                {
                    if (Convert.ToBoolean(gridview.Rows[e.RowIndex].Cells[0].EditedFormattedValue) == false)
                        gridview.Rows[e.RowIndex].Cells[0].Value = true;
                    else // uncheck 했을 때
                        gridview.Rows[e.RowIndex].Cells[0].Value = false;
                }

            }
            catch { }
        }

        private void grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView gridview = (DataGridView)sender;

            if (gridview.RowCount > 0)
            {
                if (e.ColumnIndex == 0)
                {
                    if (Convert.ToBoolean(gridview.Rows[1].Cells[0].EditedFormattedValue) == false)
                        for (int i = 0; i < gridview.RowCount; i++)
                            gridview.Rows[i].Cells[0].Value = true;

                    else // uncheck 했을 때
                        for (int i = 0; i < gridview.RowCount; i++)
                            gridview.Rows[i].Cells[0].Value = false;
                }
            }
        }
    }
}
