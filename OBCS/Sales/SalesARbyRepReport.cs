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
    public partial class SalesARbyRepReport : Form
    {
        public SalesARbyRepReport()
        {
            InitializeComponent();
            grid_salesReport_Init();
            connPO.cbox_BPSaleRep(cbx_SalesRep);
        }
        private void grid_salesReport_Init()
        {
            grid_salesReport.AutoGenerateColumns = false;
            grid_salesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            grid_salesReport.ColumnCount = 30;

            grid_salesReport.Columns[0].Name = "No.";
            grid_salesReport.Columns[0].ReadOnly = true;
            grid_salesReport.Columns[0].Width = 50;
            grid_salesReport.Columns[0].MinimumWidth = 50;
            grid_salesReport.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[0].DataPropertyName = "WeeksNo";
            grid_salesReport.Columns[0].Frozen = true;

            grid_salesReport.Columns[1].Name = "DATE1";
            grid_salesReport.Columns[1].ReadOnly = true;
            grid_salesReport.Columns[1].Width = 100;
            grid_salesReport.Columns[1].MinimumWidth = 100;
            grid_salesReport.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_salesReport.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[1].DataPropertyName = "DATE1";
            grid_salesReport.Columns[1].Frozen = true;

            grid_salesReport.Columns[2].Name = "DATE2";
            grid_salesReport.Columns[2].ReadOnly = true;
            grid_salesReport.Columns[2].Width = 100;
            grid_salesReport.Columns[2].MinimumWidth = 100;
            grid_salesReport.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_salesReport.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[2].DataPropertyName = "DATE2";
            grid_salesReport.Columns[2].Frozen = true;

            grid_salesReport.Columns[3].Name = "SalesRep";
            grid_salesReport.Columns[3].ReadOnly = true;
            grid_salesReport.Columns[3].Width = 60;
            grid_salesReport.Columns[3].MinimumWidth = 60;
            grid_salesReport.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[3].DataPropertyName = "SalesRep";
            grid_salesReport.Columns[3].Frozen = true;
            grid_salesReport.Columns[3].DividerWidth = 2;

            grid_salesReport.Columns[4].Name = "Order Count";
            grid_salesReport.Columns[4].ReadOnly = true;
            grid_salesReport.Columns[4].Width = 90;
            grid_salesReport.Columns[4].MinimumWidth = 90;
            grid_salesReport.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[4].DataPropertyName = "OrderCount";

            grid_salesReport.Columns[5].Name = "Sales Per Store";
            grid_salesReport.Columns[5].ReadOnly = true;
            grid_salesReport.Columns[5].Width = 120;
            grid_salesReport.Columns[5].MinimumWidth = 120;
            grid_salesReport.Columns[5].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[5].DataPropertyName = "SalesPerStore";

            grid_salesReport.Columns[6].Name = "Delivery Amount";
            grid_salesReport.Columns[6].ReadOnly = true;
            grid_salesReport.Columns[6].Width = 120;
            grid_salesReport.Columns[6].MinimumWidth = 120;
            grid_salesReport.Columns[6].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[6].DataPropertyName = "DeliveryAmount";

            grid_salesReport.Columns[7].Name = "GrossSales";
            grid_salesReport.Columns[7].ReadOnly = true;
            grid_salesReport.Columns[7].Width = 120;
            grid_salesReport.Columns[7].MinimumWidth = 120;
            grid_salesReport.Columns[7].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[7].DataPropertyName = "GrossSales";

            grid_salesReport.Columns[8].Name = "Promotion";
            grid_salesReport.Columns[8].ReadOnly = true;
            grid_salesReport.Columns[8].Width = 100;
            grid_salesReport.Columns[8].MinimumWidth = 100;
            grid_salesReport.Columns[8].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[8].DataPropertyName = "Promotion";

            grid_salesReport.Columns[9].Name = "Promotion(%)";
            grid_salesReport.Columns[9].ReadOnly = true;
            grid_salesReport.Columns[9].Width = 100;
            grid_salesReport.Columns[9].MinimumWidth = 100;
            grid_salesReport.Columns[9].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[9].DataPropertyName = "PromoRatio";

            grid_salesReport.Columns[10].Name = "Credit";
            grid_salesReport.Columns[10].ReadOnly = true;
            grid_salesReport.Columns[10].Width = 100;
            grid_salesReport.Columns[10].MinimumWidth = 100;
            grid_salesReport.Columns[10].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[10].DataPropertyName = "Credit";

            grid_salesReport.Columns[11].Name = "Credit(%)";
            grid_salesReport.Columns[11].ReadOnly = true;
            grid_salesReport.Columns[11].Width = 100;
            grid_salesReport.Columns[11].MinimumWidth = 100;
            grid_salesReport.Columns[11].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[11].DataPropertyName = "CreditRatio";

            grid_salesReport.Columns[12].Name = "Return";
            grid_salesReport.Columns[12].ReadOnly = true;
            grid_salesReport.Columns[12].Width = 100;
            grid_salesReport.Columns[12].MinimumWidth = 100;
            grid_salesReport.Columns[12].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[12].DataPropertyName = "Returns";

            grid_salesReport.Columns[13].Name = "Return(%)";
            grid_salesReport.Columns[13].ReadOnly = true;
            grid_salesReport.Columns[13].Width = 100;
            grid_salesReport.Columns[13].MinimumWidth = 100;
            grid_salesReport.Columns[13].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[13].DataPropertyName = "ReturnRatio";

            grid_salesReport.Columns[14].Name = "Term";
            grid_salesReport.Columns[14].ReadOnly = true;
            grid_salesReport.Columns[14].Width = 100;
            grid_salesReport.Columns[14].MinimumWidth = 100;
            grid_salesReport.Columns[14].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[14].DataPropertyName = "Term";

            grid_salesReport.Columns[15].Name = "Term(%)";
            grid_salesReport.Columns[15].ReadOnly = true;
            grid_salesReport.Columns[15].Width = 100;
            grid_salesReport.Columns[15].MinimumWidth = 100;
            grid_salesReport.Columns[15].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[15].DataPropertyName = "TermRatio";

            grid_salesReport.Columns[16].Name = "Net Sales";
            grid_salesReport.Columns[16].ReadOnly = true;
            grid_salesReport.Columns[16].Width = 120;
            grid_salesReport.Columns[16].MinimumWidth = 120;
            grid_salesReport.Columns[16].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[16].DataPropertyName = "NetSales";

            grid_salesReport.Columns[17].Name = "Not Due";
            grid_salesReport.Columns[17].ReadOnly = true;
            grid_salesReport.Columns[17].Width = 100;
            grid_salesReport.Columns[17].MinimumWidth = 100;
            grid_salesReport.Columns[17].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[17].DataPropertyName = "NotDue";

            grid_salesReport.Columns[18].Name = "AR30";
            grid_salesReport.Columns[18].ReadOnly = true;
            grid_salesReport.Columns[18].Width = 100;
            grid_salesReport.Columns[18].MinimumWidth = 100;
            grid_salesReport.Columns[18].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[18].DataPropertyName = "AR30";

            grid_salesReport.Columns[19].Name = "AR60";
            grid_salesReport.Columns[19].ReadOnly = true;
            grid_salesReport.Columns[19].Width = 100;
            grid_salesReport.Columns[19].MinimumWidth = 100;
            grid_salesReport.Columns[19].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[19].DataPropertyName = "AR60";
        
            grid_salesReport.Columns[20].Name = "AR90";
            grid_salesReport.Columns[20].ReadOnly = true;
            grid_salesReport.Columns[20].Width = 100;
            grid_salesReport.Columns[20].MinimumWidth = 100;
            grid_salesReport.Columns[20].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[20].DataPropertyName = "AR90";

            grid_salesReport.Columns[21].Name = "AR90 Over";
            grid_salesReport.Columns[21].ReadOnly = true;
            grid_salesReport.Columns[21].Width = 100;
            grid_salesReport.Columns[21].MinimumWidth = 100;
            grid_salesReport.Columns[21].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[21].DataPropertyName = "AR90Over";

            grid_salesReport.Columns[22].Name = "Total AR";
            grid_salesReport.Columns[22].ReadOnly = true;
            grid_salesReport.Columns[22].Width = 120;
            grid_salesReport.Columns[22].MinimumWidth = 120;
            grid_salesReport.Columns[22].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[22].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[22].DataPropertyName = "TotalAR";

            grid_salesReport.Columns[23].Name = "GOAL";
            grid_salesReport.Columns[23].ReadOnly = true;
            grid_salesReport.Columns[23].Width = 100;
            grid_salesReport.Columns[23].MinimumWidth = 100;
            grid_salesReport.Columns[23].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[23].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[23].DataPropertyName = "REPGOAL_W";

            grid_salesReport.Columns[24].Name = "Performance";
            grid_salesReport.Columns[24].ReadOnly = true;
            grid_salesReport.Columns[24].Width = 100;
            grid_salesReport.Columns[24].MinimumWidth = 100;
            grid_salesReport.Columns[24].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[24].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[24].DataPropertyName = "Performance";

            grid_salesReport.Columns[25].Name = "Performance(%)";
            grid_salesReport.Columns[25].ReadOnly = true;
            grid_salesReport.Columns[25].Width = 100;
            grid_salesReport.Columns[25].MinimumWidth = 100;
            grid_salesReport.Columns[25].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[25].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[25].DataPropertyName = "PerformanceRatio";

            grid_salesReport.Columns[26].Name = "New Account";
            grid_salesReport.Columns[26].ReadOnly = true;
            grid_salesReport.Columns[26].Width = 100;
            grid_salesReport.Columns[26].MinimumWidth = 100;
            grid_salesReport.Columns[26].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[26].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[26].DataPropertyName = "NewAccount";

            grid_salesReport.Columns[27].Name = "REPGOAL_Y";
            grid_salesReport.Columns[27].Visible = false;
            grid_salesReport.Columns[27].ReadOnly = true;
            grid_salesReport.Columns[27].Width = 100;
            grid_salesReport.Columns[27].MinimumWidth = 100;
            grid_salesReport.Columns[27].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[27].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[27].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[27].DataPropertyName = "REPGOAL_Y";

            grid_salesReport.Columns[28].Name = "WeeklySalary";
            grid_salesReport.Columns[28].Visible = false;
            grid_salesReport.Columns[28].ReadOnly = true;
            grid_salesReport.Columns[28].Width = 80;
            grid_salesReport.Columns[28].MinimumWidth = 80;
            grid_salesReport.Columns[28].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[28].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[28].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[28].DataPropertyName = "WeeklySalary";

            grid_salesReport.Columns[29].Name = "Ratio";
            grid_salesReport.Columns[29].ReadOnly = true;
            grid_salesReport.Columns[29].Width = 80;
            grid_salesReport.Columns[29].MinimumWidth = 80;
            grid_salesReport.Columns[29].DefaultCellStyle.Format = "N2";
            grid_salesReport.Columns[29].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesReport.Columns[29].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_salesReport.Columns[29].DataPropertyName = "Ratio";

            //grid font size custom
            grid_salesReport.RowTemplate.Height = 20;
            grid_salesReport.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_salesReport.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            grid_salesReport.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {

            if (cbx_SalesRep.Text.Length == 0)
            {
                MessageBox.Show("Please choose salesrep first.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String SalesRep = cbx_SalesRep.Text.ToString();
            //grid_salesReport.DataSource = null;
            connSalesOrder.sp_SalesARbyRepReport(grid_salesReport, SalesRep);

            try
            {
                DataTable dataTable = (DataTable)grid_salesReport.DataSource;
                int TotalOrderCount = 0, TotalNewAccount = 0;
                decimal TotalDeliveryAmount = 0, TotalGrossSales = 0, TotalPromotion = 0, TotalCredit = 0, TotalReturn = 0, TotalTerm = 0, TotalNetSales = 0, TotalPerformance = 0, TotalWeekGoal = 0, TotalWeeklySalary = 0;
                //decimal TotalNotDue = 0, TotalAR30 = 0, TotalAR60 = 0, TotalAR90 = 0, TotalAR90Over = 0, TotalAR = 0;
                

                for (int i = 0; i < grid_salesReport.RowCount; i++)
                {
                    TotalOrderCount += Convert.ToInt32(grid_salesReport.Rows[i].Cells["Order Count"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Order Count"].Value);
                    TotalDeliveryAmount += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Delivery Amount"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Delivery Amount"].Value);
                    TotalGrossSales += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["GrossSales"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["GrossSales"].Value);
                    TotalPromotion += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Promotion"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Promotion"].Value);
                    TotalCredit += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Credit"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Credit"].Value);
                    TotalReturn += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Return"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Return"].Value);
                    TotalTerm += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Term"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Term"].Value);
                    TotalNetSales += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Net Sales"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Net Sales"].Value);
                    TotalPerformance += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Performance"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Performance"].Value);
                    TotalWeekGoal += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Goal"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Goal"].Value);
                    //TotalNotDue += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Not Due"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Not Due"].Value);
                    //TotalAR30 += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["AR30"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["AR30"].Value);
                    //TotalAR60 += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["AR60"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["AR60"].Value);
                    //TotalAR90 += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["AR90"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["AR90"].Value);
                    //TotalAR90Over += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["AR90 Over"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["AR90 Over"].Value);
                    //TotalAR += Convert.ToDecimal(grid_salesReport.Rows[i].Cells["Total AR"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["Total AR"].Value);
                    TotalNewAccount += Convert.ToInt32(grid_salesReport.Rows[i].Cells["New Account"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["New Account"].Value);
                    TotalWeeklySalary += Convert.ToInt32(grid_salesReport.Rows[i].Cells["WeeklySalary"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[i].Cells["WeeklySalary"].Value);
                }

                DataRow drToAdd = dataTable.NewRow();
                drToAdd["WeeksNo"] = "TOTAL";
                drToAdd["OrderCount"] = TotalOrderCount.ToString();
                drToAdd["SalesPerStore"] = (TotalOrderCount == 0 ? 0 : TotalDeliveryAmount / TotalOrderCount).ToString();
                drToAdd["DeliveryAmount"] = TotalDeliveryAmount.ToString();
                drToAdd["GrossSales"] = TotalGrossSales.ToString();
                drToAdd["Promotion"] = TotalPromotion.ToString();
                drToAdd["PromoRatio"] = (TotalGrossSales == 0 ? 0 : TotalPromotion / TotalGrossSales * 100).ToString();
                drToAdd["Credit"] = TotalCredit.ToString();
                drToAdd["CreditRatio"] = (TotalGrossSales == 0 ? 0 : TotalCredit / TotalGrossSales * 100).ToString();
                drToAdd["Returns"] = TotalReturn.ToString();
                drToAdd["ReturnRatio"] = (TotalGrossSales == 0 ? 0 : TotalReturn / TotalGrossSales * 100).ToString();
                drToAdd["Term"] = TotalTerm.ToString();
                drToAdd["TermRatio"] = (TotalGrossSales == 0 ? 0 : TotalTerm / TotalGrossSales * 100).ToString();
                drToAdd["NetSales"] = TotalNetSales.ToString();
                //drToAdd["Performance"] = TotalPerformance.ToString();
                drToAdd["PerformanceRatio"] = (TotalWeekGoal == 0 ? 0 : TotalPerformance / TotalWeekGoal * 100).ToString();
                drToAdd["Ratio"] = (TotalNetSales == 0 ? 0 : TotalWeeklySalary / TotalNetSales * 100).ToString();
                //drToAdd["NotDue"] = TotalNotDue.ToString();
                //drToAdd["AR30"] = TotalAR30.ToString();
                //drToAdd["AR60"] = TotalAR60.ToString();
                //drToAdd["AR90"] = TotalAR90.ToString();
                //drToAdd["AR90Over"] = TotalAR90Over.ToString();
                //drToAdd["TotalAR"] = TotalAR.ToString();
                drToAdd["NewAccount"] = TotalNewAccount.ToString();

                dataTable.Rows.Add(drToAdd);

                dataTable.AcceptChanges();

                this.grid_salesReport.ClearSelection();

                decimal YearGoal = Convert.ToDecimal(grid_salesReport.Rows[0].Cells["REPGOAL_Y"].Value == DBNull.Value ? "0" : grid_salesReport.Rows[0].Cells["REPGOAL_Y"].Value);

                txt_YearGoal.Text = YearGoal.ToString("N2");
                txt_Cumulative.Text = TotalNetSales.ToString("N2");
                txt_CumulativeRatio.Text = (YearGoal == 0 ? 0 : TotalNetSales / YearGoal * 100).ToString("N2");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void grid_salesReport_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.grid_salesReport.Rows)
            {
                //row.Cells["Beg"].Style.BackColor = Color.OldLace;
                //row.Cells["Ending"].Style.BackColor = Color.OldLace;

                if (row.Cells["No."].Value.Equals("TOTAL"))
                {
                    for (int i = 0; i < grid_salesReport.ColumnCount; i++)
                    {
                        row.Cells[i].Style.BackColor = Color.Gray;
                        row.Cells[i].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            String SalesRep = cbx_SalesRep.Text.ToString();

            Reports.Rpt_SalesARbyRepReport rpt = new Reports.Rpt_SalesARbyRepReport(SalesRep);
            rpt.Show();
        }
    }
}
