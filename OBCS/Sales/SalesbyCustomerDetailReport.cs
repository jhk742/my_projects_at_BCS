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
    public partial class SalesbyCustomerDetailReport : Form
    {
        public SalesbyCustomerDetailReport()
        {
            InitializeComponent();
            grid_salesDetailReport_Init();
            grid_State_Init();
            grid_City_Init();
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-14);

            connSalesOrder.sp_GET_ShipState(grid_State);
            connSalesOrder.sp_GET_ShipCity(grid_City);
        }
        private void SalesbyCustomerDetailReport_Load(object sender, EventArgs e)
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
        private void grid_salesDetailReport_Init()
        {
            grid_salesDetailReport.AutoGenerateColumns = false;
            grid_salesDetailReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_salesDetailReport.ColumnCount = 16;

            grid_salesDetailReport.Columns[0].Name = "State";
            grid_salesDetailReport.Columns[0].ReadOnly = true;
            grid_salesDetailReport.Columns[0].Width = 25;
            grid_salesDetailReport.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[0].DataPropertyName = "State";

            grid_salesDetailReport.Columns[1].Name = "City";
            grid_salesDetailReport.Columns[1].ReadOnly = true;
            grid_salesDetailReport.Columns[1].Width = 80;
            grid_salesDetailReport.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[1].DataPropertyName = "City";

            grid_salesDetailReport.Columns[2].Name = "Customer ID";
            grid_salesDetailReport.Columns[2].ReadOnly = true;
            grid_salesDetailReport.Columns[2].Width = 70;
            grid_salesDetailReport.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[2].DataPropertyName = "CustomerID";

            grid_salesDetailReport.Columns[3].Name = "Customer Name";
            grid_salesDetailReport.Columns[3].ReadOnly = true;
            grid_salesDetailReport.Columns[3].Width = 180;
            grid_salesDetailReport.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[3].DataPropertyName = "CustomerName";

            grid_salesDetailReport.Columns[4].Name = "REP";
            grid_salesDetailReport.Columns[4].ReadOnly = true;
            grid_salesDetailReport.Columns[4].Width = 25;
            grid_salesDetailReport.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[4].DataPropertyName = "REP";

            grid_salesDetailReport.Columns[5].Name = "Invoice Number";
            grid_salesDetailReport.Columns[5].ReadOnly = true;
            grid_salesDetailReport.Columns[5].Width = 55;
            grid_salesDetailReport.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[5].DataPropertyName = "InvoiceNumber";

            grid_salesDetailReport.Columns[6].Name = "Gross Sales";
            grid_salesDetailReport.Columns[6].ReadOnly = true;
            grid_salesDetailReport.Columns[6].Width = 55;
            grid_salesDetailReport.Columns[6].DefaultCellStyle.Format = "N2";
            grid_salesDetailReport.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesDetailReport.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[6].DataPropertyName = "GrossSales";

            grid_salesDetailReport.Columns[7].Name = "Promotion";
            grid_salesDetailReport.Columns[7].ReadOnly = true;
            grid_salesDetailReport.Columns[7].Width = 55;
            grid_salesDetailReport.Columns[7].DefaultCellStyle.Format = "N2";
            grid_salesDetailReport.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesDetailReport.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[7].DataPropertyName = "Promotion";

            grid_salesDetailReport.Columns[8].Name = "Credit";
            grid_salesDetailReport.Columns[8].ReadOnly = true;
            grid_salesDetailReport.Columns[8].Width = 55;
            grid_salesDetailReport.Columns[8].DefaultCellStyle.Format = "N2";
            grid_salesDetailReport.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesDetailReport.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[8].DataPropertyName = "Credit";

            grid_salesDetailReport.Columns[9].Name = "Sales Allowance";
            grid_salesDetailReport.Columns[9].ReadOnly = true;
            grid_salesDetailReport.Columns[9].Visible = false;
            grid_salesDetailReport.Columns[9].Width = 65;
            grid_salesDetailReport.Columns[9].ToolTipText = "Promotion + Credit";
            grid_salesDetailReport.Columns[9].DefaultCellStyle.Format = "N2";
            grid_salesDetailReport.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesDetailReport.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[9].DataPropertyName = "SalesAllowance";

            grid_salesDetailReport.Columns[10].Name = "Return Credit";
            grid_salesDetailReport.Columns[10].ReadOnly = true;
            grid_salesDetailReport.Columns[10].Width = 55;
            grid_salesDetailReport.Columns[10].DefaultCellStyle.Format = "N2";
            grid_salesDetailReport.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesDetailReport.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[10].DataPropertyName = "ReturnCredit";

            grid_salesDetailReport.Columns[11].Name = "Term Credit";
            grid_salesDetailReport.Columns[11].ReadOnly = true;
            grid_salesDetailReport.Columns[11].Width = 55;
            grid_salesDetailReport.Columns[11].DefaultCellStyle.Format = "N2";
            grid_salesDetailReport.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesDetailReport.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[11].DataPropertyName = "TermCredit";

            grid_salesDetailReport.Columns[12].Name = "Sales Discount";
            grid_salesDetailReport.Columns[12].ReadOnly = true;
            grid_salesDetailReport.Columns[12].Visible = false;
            grid_salesDetailReport.Columns[12].Width = 65;
            grid_salesDetailReport.Columns[12].ToolTipText = "Term Credit";
            grid_salesDetailReport.Columns[12].DefaultCellStyle.Format = "N2";
            grid_salesDetailReport.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesDetailReport.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[12].DataPropertyName = "SalesDiscount";

            grid_salesDetailReport.Columns[13].Name = "Net Sales";
            grid_salesDetailReport.Columns[13].ReadOnly = true;
            grid_salesDetailReport.Columns[13].Width = 70;
            grid_salesDetailReport.Columns[13].DefaultCellStyle.Format = "N2";
            grid_salesDetailReport.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesDetailReport.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[13].DataPropertyName = "NetSales";

            grid_salesDetailReport.Columns[14].Name = "COGS";
            grid_salesDetailReport.Columns[14].ReadOnly = true;
            grid_salesDetailReport.Columns[14].Width = 70;
            grid_salesDetailReport.Columns[14].DefaultCellStyle.Format = "N2";
            grid_salesDetailReport.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesDetailReport.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[14].DataPropertyName = "COGS";

            grid_salesDetailReport.Columns[15].Name = "SINVOICE_DATE";
            grid_salesDetailReport.Columns[15].ReadOnly = true;
            grid_salesDetailReport.Columns[15].Visible = false;
            grid_salesDetailReport.Columns[15].Width = 25;
            grid_salesDetailReport.Columns[15].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_salesDetailReport.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesDetailReport.Columns[15].DataPropertyName = "SINVOICE_DATE";

            //grid font size custom
            grid_salesDetailReport.RowTemplate.Height = 20;
            grid_salesDetailReport.ColumnHeadersHeight = 35;

            foreach (DataGridViewColumn c in grid_salesDetailReport.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_salesDetailReport.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date <= Convert.ToDateTime("01/06/2020"))
            {
                dateTimePickerFrom.Value = Convert.ToDateTime("01/06/2020");
            }
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
            catch(Exception ex)
            {
                MessageBox.Show("GridConvertToString\nError : " + ex.Message.ToString(),"Information");
                return "";
            }
            
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime FromDate = dateTimePickerFrom.Value.Date;
                DateTime ToDate = dateTimePickerTo.Value.Date;
                String CustomerID = txt_CustomerID.Text.Trim().ToString();
                String CustomerName = txt_customerName.Text.Trim().ToString();
                String REP = txt_REP.Text.Trim().ToString();
                String InvoiceNumber = txt_InvNumber.Text.Trim().ToString();

                if (grid_State.DataSource == null || grid_City.DataSource == null)
                {
                    MessageBox.Show("Something went wrong. Please close the form and try again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //List<string> StateList = new List<string>();
                //List<string> CityList = new List<string>();
                //for (int i = 0; i < grid_State.RowCount; i++)
                //{
                //    if (grid_State.Rows[i].Cells[0].Value.Equals(true))
                //    {
                //        StateList.Add(grid_State.Rows[i].Cells[1].Value.ToString());
                //    }
                //}
                //for (int i = 0; i < grid_City.RowCount; i++)
                //{
                //    if (grid_City.Rows[i].Cells[0].Value.Equals(true))
                //    {
                //        CityList.Add(grid_City.Rows[i].Cells[1].Value.ToString());
                //    }
                //}
                //string[] StateArray = StateList.ToArray();
                //string[] CityArray = CityList.ToArray();

                //for (int i = 0; i < StateArray.Length; i++)
                //{
                //    StateString += StateArray[i].ToString();
                //    if (i < (StateArray.Length - 1)) StateString += ",";
                //}
                //for (int i = 0; i < CityArray.Length; i++)
                //{
                //    CityString += CityArray[i].ToString();
                //    if (i < (CityArray.Length - 1)) CityString += ",";
                //}

                connSalesOrder.sp_SalesbyCustomerDetailReport(grid_salesDetailReport, CustomerID, CustomerName, FromDate, ToDate, REP, InvoiceNumber, GridConvertToString(grid_State), GridConvertToString(grid_City));

                CalculateTotal();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
        private void CalculateTotal()
        {
            int RowCount = 0;
            decimal TotalGrossSales = 0, TotalPromotion = 0, TotalCredit = 0, TotalReturnCredit = 0, TotalTermCredit = 0, TotalNetSales = 0, TotalCOGS = 0;

            if (grid_salesDetailReport.RowCount > 0)
            {
                try
                {
                    for (int i = 0; i < grid_salesDetailReport.RowCount; i++)
                    {
                        TotalGrossSales += Convert.ToDecimal(grid_salesDetailReport.Rows[i].Cells["Gross Sales"].Value == DBNull.Value ? "0" : grid_salesDetailReport.Rows[i].Cells["Gross Sales"].Value);
                        TotalPromotion += Convert.ToDecimal(grid_salesDetailReport.Rows[i].Cells["Promotion"].Value == DBNull.Value ? "0" : grid_salesDetailReport.Rows[i].Cells["Promotion"].Value);
                        TotalCredit += Convert.ToDecimal(grid_salesDetailReport.Rows[i].Cells["Credit"].Value == DBNull.Value ? "0" : grid_salesDetailReport.Rows[i].Cells["Credit"].Value);
                        TotalReturnCredit += Convert.ToDecimal(grid_salesDetailReport.Rows[i].Cells["Return Credit"].Value == DBNull.Value ? "0" : grid_salesDetailReport.Rows[i].Cells["Return Credit"].Value);
                        TotalTermCredit += Convert.ToDecimal(grid_salesDetailReport.Rows[i].Cells["Term Credit"].Value == DBNull.Value ? "0" : grid_salesDetailReport.Rows[i].Cells["Term Credit"].Value);
                        TotalNetSales += Convert.ToDecimal(grid_salesDetailReport.Rows[i].Cells["Net Sales"].Value == DBNull.Value ? "0" : grid_salesDetailReport.Rows[i].Cells["Net Sales"].Value);
                        TotalCOGS += Convert.ToDecimal(grid_salesDetailReport.Rows[i].Cells["COGS"].Value == DBNull.Value ? "0" : grid_salesDetailReport.Rows[i].Cells["COGS"].Value);
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
            txt_SACredit.Text = TotalCredit.ToString("N");
            txt_SalesAllowance.Text = (TotalPromotion + TotalCredit).ToString("N");
            txt_SAReturnCredit.Text = TotalReturnCredit.ToString("N");
            txt_GAReturnCredit.Text = TotalReturnCredit.ToString("N");
            txt_SATermCredit.Text = TotalTermCredit.ToString("N");
            txt_SalesDiscount.Text = TotalTermCredit.ToString("N");
            txt_SANetSales.Text = (TotalGrossSales - TotalPromotion - TotalReturnCredit - TotalCredit - TotalTermCredit).ToString("N");
            txt_GANetSales.Text = (TotalGrossSales - TotalPromotion - TotalReturnCredit - TotalCredit - TotalTermCredit).ToString("N");
            txt_SACOGS.Text = TotalCOGS.ToString("N");
            lbl_RowCount.Text = "Row Count : " + RowCount.ToString();
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == rdb_SalesVersion)
                {
                    rdb_GAVersion.Checked = false;

                    grid_salesDetailReport.Columns[4].Visible = true; //REP
                    grid_salesDetailReport.Columns[7].Visible = true; //Promotion
                    grid_salesDetailReport.Columns[8].Visible = true; //Credit
                    grid_salesDetailReport.Columns[11].Visible = true; //Term Credit
                    grid_salesDetailReport.Columns[14].Visible = true; //COGS
                    grid_salesDetailReport.Columns[9].Visible = false; //Sales Allowance
                    grid_salesDetailReport.Columns[12].Visible = false; //Sales Discount

                    grid_salesDetailReport.Columns[0].Width = 25; // State
                    grid_salesDetailReport.Columns[1].Width = 80; // City
                    grid_salesDetailReport.Columns[2].Width = 70; // CustomerID
                    grid_salesDetailReport.Columns[3].Width = 180; //CustomerName
                    grid_salesDetailReport.Columns[4].Width = 25; // REP
                    grid_salesDetailReport.Columns[5].Width = 55; // InvoiceNumber
                    grid_salesDetailReport.Columns[6].Width = 55; // GrossSales
                    grid_salesDetailReport.Columns[7].Width = 55; // Promotion
                    grid_salesDetailReport.Columns[8].Width = 55; // Credit
                    grid_salesDetailReport.Columns[9].Width = 65; // SalesAllowance
                    grid_salesDetailReport.Columns[10].Width = 55; // Return Credit
                    grid_salesDetailReport.Columns[11].Width = 55; // TermCredit
                    grid_salesDetailReport.Columns[12].Width = 65; // Sales Discount
                    grid_salesDetailReport.Columns[13].Width = 70; // Net Sales
                    grid_salesDetailReport.Columns[14].Width = 70; // COGS

                    pn_Sales.Visible = true;
                    pn_GA.Visible = false;
                }
                else if (((RadioButton)sender) == rdb_GAVersion)
                {
                    rdb_SalesVersion.Checked = false;

                    grid_salesDetailReport.Columns[4].Visible = false; //REP
                    grid_salesDetailReport.Columns[7].Visible = false; //Promotion
                    grid_salesDetailReport.Columns[8].Visible = false; //Credit
                    grid_salesDetailReport.Columns[11].Visible = false; //Term Credit
                    grid_salesDetailReport.Columns[14].Visible = false; //COGS
                    grid_salesDetailReport.Columns[9].Visible = true; //Sales Allowance
                    grid_salesDetailReport.Columns[12].Visible = true; //Sales Discount

                    grid_salesDetailReport.Columns[0].Width = 40; // State
                    grid_salesDetailReport.Columns[1].Width = 80; // City
                    grid_salesDetailReport.Columns[2].Width = 100; // CustomerID
                    grid_salesDetailReport.Columns[3].Width = 200; //CustomerName
                    grid_salesDetailReport.Columns[5].Width = 80; // InvoiceNumber
                    grid_salesDetailReport.Columns[6].Width = 80; // GrossSales
                    grid_salesDetailReport.Columns[9].Width = 80; // SalesAllowance
                    grid_salesDetailReport.Columns[10].Width = 80; // Return Credit
                    grid_salesDetailReport.Columns[12].Width = 80; // Sales Discount
                    grid_salesDetailReport.Columns[13].Width = 100; // Net Sales

                    pn_GA.Visible = true;
                    pn_Sales.Visible = false;
                }
            }
        }
        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String CustomerID = txt_CustomerID.Text.ToString();
            String CustomerName = txt_customerName.Text.ToString();
            String REP = txt_REP.Text.ToString();
            int CityCount = 0;
            int StateCount = 0;
            for (int i = 0; i < grid_City.RowCount; i++)
            {
                if (grid_City.Rows[i].Cells[0].Value.Equals(true))  CityCount++;
            }
            for (int i = 0; i < grid_State.RowCount; i++)
            {
                if (grid_State.Rows[i].Cells[0].Value.Equals(true)) StateCount++;
            }
            bool CityAll = CityCount == grid_City.RowCount ? true : false;
            bool StateAll = StateCount == grid_State.RowCount ? true : false;
            String City = GridConvertToString(grid_City);
            String State = GridConvertToString(grid_State);
            String InvoiceNumber = txt_InvNumber.Text.ToString();
            if (rdb_GAVersion.Checked)
            {
                Reports.Rpt_SalesbyCustomerDetailReport_GA salesReport = new Reports.Rpt_SalesbyCustomerDetailReport_GA(FromDate, ToDate, CustomerID, CustomerName, REP, City, State, InvoiceNumber, CityAll, StateAll);
                salesReport.Show();
            }
            else if (rdb_SalesVersion.Checked)
            {
                Reports.Rpt_SalesbyCustomerDetailReport salesReport = new Reports.Rpt_SalesbyCustomerDetailReport(FromDate, ToDate, CustomerID, CustomerName, REP, City, State, InvoiceNumber,CityAll,StateAll);
                salesReport.Show();
            }
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
