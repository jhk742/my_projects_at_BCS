using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OBCS.Purchase
{
    public partial class POPrepData : Form
    {
        public POPrepData()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            grid_brandMemo_Init();
            grid_POReceiptHistory_Init();
            grid_salesHistoryMonthly_Init();
            grid_salesHistoryWeekly_Init();

            var chart = chart_monthly.ChartAreas[0];

           // chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            //chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            //chart.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chart.AxisX.Interval = 1;
            //chart.AxisX.LabelStyle.Format = "yyyy/MM";

            var chart2 = chart_weekly.ChartAreas[0];
            chart2.AxisX.Interval = 1;

            cbo_basedDate.Items.Add("Order");
            cbo_basedDate.Items.Add("Ship");
            cbo_basedDate.Text = "Order";

            //아이템 가져오기
            connSalesOrder.cbo_itemID(cbo_product);


        }

        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    base.OnFormClosing(e);

        //    if (e.CloseReason == CloseReason.WindowsShutDown) return;

        //    MessageBox.Show(this, "Close PO Prepare window first.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //    e.Cancel = true;
        //    // Confirm user wants to close
        //    //switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
        //    //{
        //    //    case DialogResult.No:
        //    //        e.Cancel = true;
        //    //        break;
        //    //    default:
        //    //        break;
        //    //}
        //}

        private void txt_product_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(txt_product.Text);
            String ProductID = txt_product.Text.Trim();
            connSalesOrder.sp_POPREPARE_RECEIPTHISTORY(grid_POReceiptHistory, ProductID);

            connSalesOrder.sp_POPREPARE_SALESHISTORY_MONTHLY(grid_salesHistoryMonthly, ProductID);
            connSalesOrder.sp_POPREPARE_SALESHISTORY_WEEKLY(grid_salesHistoryWeekly, ProductID);

            Entities.ProductObject productObject = new Entities.ProductObject();
            productObject = connSalesOrder.sp_GET_ProductInfo(ProductID);
            txt_listPrice.Text = productObject.UnitPr.ToString("N2");
            txt_bottomPrice.Text = productObject.BottomPr.ToString("N2");
            try
            {
                txt_commissionCode.Text = productObject.CommissionCode1.ToString();
            }
            catch
            {
                txt_commissionCode.Text = "";
            }
            

            try
            {

                int i = 1;


                //graph

                //chart_monthly.Series["ThisYear"].Points.Clear();

                chart_monthly.Series.Clear();

                chart_monthly.Series.Add("ThisYear");
                chart_monthly.Series.Add("LastYear");

                this.chart_monthly.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
                this.chart_monthly.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;

                chart_monthly.Series["ThisYear"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_monthly.Series["LastYear"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


                for (i = grid_salesHistoryMonthly.Rows.Count; i > 0; i--)
                {

                    String MString = grid_salesHistoryMonthly.Rows[i - 1].Cells["Qty"].Value.ToString();
                    double Mdouble = Convert.ToDouble(MString);

                    DateTime Today = DateTime.Now;


                    String MMonthString = grid_salesHistoryMonthly.Rows[i - 1].Cells["Month"].Value.ToString(); //Today.AddMonths(-MMonth).ToString("yyyy.MM");
                    //chart_poPrepare.Series["ThisYear"].Points.AddXY(MMonthString, Mdouble);
                    //MessageBox.Show(MMonth.ToString());
                    if (i - 1 >= 12)
                    {
                        chart_monthly.Series["ThisYear"].Points.AddXY(MMonthString, Mdouble);
                    }
                    else
                    {
                        chart_monthly.Series["LastYear"].Points.AddXY(MMonthString, Mdouble);
                    }


                }
                //chart_poPrepare.ChartAreas[0].AxisY.ScaleView.Zoom(-10, highestM);
                // chart_poPrepare.Series["ThisYear"].IsValueShownAsLabel = true;
                chart_monthly.Series["ThisYear"].IsVisibleInLegend = true;
                chart_monthly.Series["ThisYear"].LegendText = "Last Year";
                chart_monthly.Series["ThisYear"].BorderWidth = 3;
                chart_monthly.Series["ThisYear"].Color = Color.Salmon;
                chart_monthly.Series["ThisYear"].MarkerStyle = MarkerStyle.Circle;
                chart_monthly.Series["ThisYear"].MarkerSize = 7;
                chart_monthly.Series["ThisYear"].MarkerColor = Color.Red;

                //chart_poPrepare.Series["LastYear"].IsValueShownAsLabel = true;
                chart_monthly.Series["LastYear"].IsVisibleInLegend = true;
                chart_monthly.Series["LastYear"].LegendText = "This Year";
                chart_monthly.Series["LastYear"].BorderWidth = 3;
                chart_monthly.Series["LastYear"].Color = Color.CornflowerBlue;
                chart_monthly.Series["LastYear"].MarkerStyle = MarkerStyle.Circle;
                chart_monthly.Series["LastYear"].MarkerSize = 7;
                chart_monthly.Series["LastYear"].MarkerColor = Color.Blue;
            }
            catch
            {

            }

            try
            {

                int i = 1;

                chart_weekly.Series.Clear();

                chart_weekly.Series.Add("ThisYear");
                chart_weekly.Series.Add("LastYear");

                this.chart_weekly.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
                this.chart_weekly.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;

                chart_weekly.Series["ThisYear"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_weekly.Series["LastYear"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (i = grid_salesHistoryWeekly.Rows.Count; i > 0; i--)
                {
                    String MString = grid_salesHistoryWeekly.Rows[i - 1].Cells["Qty"].Value.ToString();
                    double Mdouble = Convert.ToDouble(MString);
                    DateTime Today = DateTime.Now;
                    String MMonthString = grid_salesHistoryWeekly.Rows[i - 1].Cells["Week"].Value.ToString(); //Today.AddMonths(-MMonth).ToString("yyyy.MM");

                    if (i - 1 >= 54)
                    {
                        chart_weekly.Series["ThisYear"].Points.AddXY(MMonthString, Mdouble);
                    }
                    else
                    {
                        chart_weekly.Series["LastYear"].Points.AddXY(MMonthString, Mdouble);
                    }

                }
                //chart_poPrepare.ChartAreas[0].AxisY.ScaleView.Zoom(-10, highestM);
                // chart_poPrepare.Series["ThisYear"].IsValueShownAsLabel = true;
                chart_weekly.Series["ThisYear"].IsVisibleInLegend = true;
                chart_weekly.Series["ThisYear"].LegendText = "Last Year";
                chart_weekly.Series["ThisYear"].BorderWidth = 3;
                chart_weekly.Series["ThisYear"].Color = Color.Salmon;
                chart_weekly.Series["ThisYear"].MarkerStyle = MarkerStyle.Circle;
                chart_weekly.Series["ThisYear"].MarkerSize = 7;
                chart_weekly.Series["ThisYear"].MarkerColor = Color.Red;

                //chart_poPrepare.Series["LastYear"].IsValueShownAsLabel = true;
                chart_weekly.Series["LastYear"].IsVisibleInLegend = true;
                chart_weekly.Series["LastYear"].LegendText = "This Year";
                chart_weekly.Series["LastYear"].BorderWidth = 3;
                chart_weekly.Series["LastYear"].Color = Color.CornflowerBlue;
                chart_weekly.Series["LastYear"].MarkerStyle = MarkerStyle.Circle;
                chart_weekly.Series["LastYear"].MarkerSize = 7;
                chart_weekly.Series["LastYear"].MarkerColor = Color.Blue;
            }
            catch
            {

            }

        }

        private void txt_brand_TextChanged(object sender, EventArgs e)
        {
            String Brand = txt_brand.Text.Trim();
            connSalesOrder.sp_POPREPARE_BRANDMEMO(grid_brandMemo, Brand);
        }

        private void grid_POReceiptHistory_Init()
        {
            grid_POReceiptHistory.AutoGenerateColumns = false;
            grid_POReceiptHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_POReceiptHistory.ColumnCount = 16;

            grid_POReceiptHistory.Columns[0].Name = "Order Date";
            grid_POReceiptHistory.Columns[0].ReadOnly = true;
            grid_POReceiptHistory.Columns[0].Width = 75;
            grid_POReceiptHistory.Columns[0].MinimumWidth = 75;
            grid_POReceiptHistory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_POReceiptHistory.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_POReceiptHistory.Columns[0].DataPropertyName = "ORDDAT_0";

            grid_POReceiptHistory.Columns[1].Name = "Order No.";
            grid_POReceiptHistory.Columns[1].ReadOnly = true;
            grid_POReceiptHistory.Columns[1].Width = 75;
            grid_POReceiptHistory.Columns[1].MinimumWidth = 75;
            grid_POReceiptHistory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_POReceiptHistory.Columns[1].DataPropertyName = "POHNUM_0";

            grid_POReceiptHistory.Columns[2].Name = "Receipt Date";
            grid_POReceiptHistory.Columns[2].ReadOnly = true;
            grid_POReceiptHistory.Columns[2].Width = 75;
            grid_POReceiptHistory.Columns[2].MinimumWidth = 75;
            grid_POReceiptHistory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_POReceiptHistory.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_POReceiptHistory.Columns[2].DataPropertyName = "RCPDAT_0";
       
            grid_POReceiptHistory.Columns[3].Name = "Receipt No.";
            grid_POReceiptHistory.Columns[3].ReadOnly = true;
            grid_POReceiptHistory.Columns[3].Width = 75;
            grid_POReceiptHistory.Columns[3].MinimumWidth = 75;
            grid_POReceiptHistory.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_POReceiptHistory.Columns[3].DataPropertyName = "PTHNUM_0";

            grid_POReceiptHistory.Columns[4].Name = "Order Qty";
            grid_POReceiptHistory.Columns[4].ReadOnly = true;
            grid_POReceiptHistory.Columns[4].Width = 50;
            grid_POReceiptHistory.Columns[4].MinimumWidth = 50;
            grid_POReceiptHistory.Columns[4].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[4].DataPropertyName = "QTY_0";

            grid_POReceiptHistory.Columns[5].Name = "Receipt Qty";
            grid_POReceiptHistory.Columns[5].ReadOnly = true;
            grid_POReceiptHistory.Columns[5].Width = 50;
            grid_POReceiptHistory.Columns[5].MinimumWidth = 50;
            grid_POReceiptHistory.Columns[5].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[5].DataPropertyName = "QTYUOM_0";

            grid_POReceiptHistory.Columns[6].Name = "Stock Conversion Qty";
            grid_POReceiptHistory.Columns[6].ReadOnly = true;
            grid_POReceiptHistory.Columns[6].Width = 50;
            grid_POReceiptHistory.Columns[6].MinimumWidth = 50;
            grid_POReceiptHistory.Columns[6].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[6].DataPropertyName = "StockConversionReceiptQty";

            grid_POReceiptHistory.Columns[7].Name = "Gross Price";
            grid_POReceiptHistory.Columns[7].ReadOnly = true;
            //grid_POReceiptHistory.Columns[7].Visible = false;
            grid_POReceiptHistory.Columns[7].Width = 50;
            grid_POReceiptHistory.Columns[7].MinimumWidth = 50;
            grid_POReceiptHistory.Columns[7].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[7].DataPropertyName = "GROPRI_0";

            grid_POReceiptHistory.Columns[8].Name = "Promotion";
            grid_POReceiptHistory.Columns[8].ReadOnly = true;
            grid_POReceiptHistory.Columns[8].Width = 40;
            grid_POReceiptHistory.Columns[8].MinimumWidth = 40;
            grid_POReceiptHistory.Columns[8].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[8].DataPropertyName = "Promo2";

            grid_POReceiptHistory.Columns[9].Name = "Promotion(P)";
            grid_POReceiptHistory.Columns[9].ReadOnly = true;
            grid_POReceiptHistory.Columns[9].Width = 40;
            grid_POReceiptHistory.Columns[9].MinimumWidth = 40;
            grid_POReceiptHistory.Columns[9].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[9].DataPropertyName = "PromoP2";

            grid_POReceiptHistory.Columns[10].Name = "EDLP";
            grid_POReceiptHistory.Columns[10].Width = 40;
            grid_POReceiptHistory.Columns[10].MinimumWidth = 40;
            grid_POReceiptHistory.Columns[10].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[10].DataPropertyName = "EDLP2";

            grid_POReceiptHistory.Columns[11].Name = "EDLP(P)";
            grid_POReceiptHistory.Columns[11].Width = 40;
            grid_POReceiptHistory.Columns[11].MinimumWidth = 40;
            grid_POReceiptHistory.Columns[11].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[11].DataPropertyName = "EDLPP2";
       
            grid_POReceiptHistory.Columns[12].Name = "Price";
            grid_POReceiptHistory.Columns[12].Width = 70;
            grid_POReceiptHistory.Columns[12].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[12].DataPropertyName = "NETPRI_0";
        
            grid_POReceiptHistory.Columns[13].Name = "Amount";
            grid_POReceiptHistory.Columns[13].Width = 55;
            grid_POReceiptHistory.Columns[13].MinimumWidth = 55;
            grid_POReceiptHistory.Columns[13].DefaultCellStyle.Format = "N2";
            grid_POReceiptHistory.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POReceiptHistory.Columns[13].DataPropertyName = "LINAMT_0";
        
            grid_POReceiptHistory.Columns[14].Name = "Status";
            grid_POReceiptHistory.Columns[14].Visible = false;
            grid_POReceiptHistory.Columns[14].Width = 40;
            grid_POReceiptHistory.Columns[14].DataPropertyName = "";
       
            grid_POReceiptHistory.Columns[15].Name = "Expire Date";
            grid_POReceiptHistory.Columns[15].ReadOnly = true;
            grid_POReceiptHistory.Columns[15].Width = 70;
            grid_POReceiptHistory.Columns[15].MinimumWidth = 70;
            grid_POReceiptHistory.Columns[15].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_POReceiptHistory.Columns[15].DataPropertyName = "ExpirationDate";
            
            //grid font size custom
            grid_POReceiptHistory.RowTemplate.Height = 20;
            grid_POReceiptHistory.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_POReceiptHistory.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_POReceiptHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_brandMemo_Init()
        {
            grid_brandMemo.AutoGenerateColumns = false;
            grid_brandMemo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_brandMemo.ColumnCount = 5;

            grid_brandMemo.Columns[0].Name = "Product ID";
            grid_brandMemo.Columns[0].ReadOnly = true;
            grid_brandMemo.Columns[0].Width = 70;
            grid_brandMemo.Columns[0].DataPropertyName = "ProductID";

            grid_brandMemo.Columns[1].Name = "Memo";
            grid_brandMemo.Columns[1].ReadOnly = true;
            grid_brandMemo.Columns[1].Width = 70;
            grid_brandMemo.Columns[1].DataPropertyName = "Memo";

            grid_brandMemo.Columns[2].Name = "Based Date";
            grid_brandMemo.Columns[2].ReadOnly = true;
            grid_brandMemo.Columns[2].Width = 70;
            grid_brandMemo.Columns[2].DataPropertyName = "BasedDate";

            grid_brandMemo.Columns[3].Name = "Start Date";
            grid_brandMemo.Columns[3].ReadOnly = true;
            grid_brandMemo.Columns[3].Width = 70;
            grid_brandMemo.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_brandMemo.Columns[3].DataPropertyName = "StartDate";

            grid_brandMemo.Columns[4].Name = "End Date";
            grid_brandMemo.Columns[4].ReadOnly = true;
            grid_brandMemo.Columns[4].Width = 70;
            grid_brandMemo.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_brandMemo.Columns[4].DataPropertyName = "EndDate";

            //grid font size custom
            grid_brandMemo.RowTemplate.Height = 20;
            grid_brandMemo.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_brandMemo.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_brandMemo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_salesHistoryMonthly_Init()
        {
            grid_salesHistoryMonthly.AutoGenerateColumns = false;

            grid_salesHistoryMonthly.ColumnCount = 3;

            grid_salesHistoryMonthly.Columns[0].Name = "Year";
            grid_salesHistoryMonthly.Columns[0].ReadOnly = true;
            grid_salesHistoryMonthly.Columns[0].Visible = false;
            grid_salesHistoryMonthly.Columns[0].Width = 70;
            grid_salesHistoryMonthly.Columns[0].DataPropertyName = "Year";

            grid_salesHistoryMonthly.Columns[1].Name = "Month";
            grid_salesHistoryMonthly.Columns[1].ReadOnly = true;
            grid_salesHistoryMonthly.Columns[1].Width = 70;
            grid_salesHistoryMonthly.Columns[1].DataPropertyName = "Month";

            grid_salesHistoryMonthly.Columns[2].Name = "Qty";
            grid_salesHistoryMonthly.Columns[2].ReadOnly = true;
            grid_salesHistoryMonthly.Columns[2].Width = 50;
            grid_salesHistoryMonthly.Columns[2].DefaultCellStyle.Format = "N2";
            grid_salesHistoryMonthly.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesHistoryMonthly.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesHistoryMonthly.Columns[2].DataPropertyName = "TotalQty";
            
            //grid font size custom
            grid_salesHistoryMonthly.RowTemplate.Height = 20;
            grid_salesHistoryMonthly.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_salesHistoryMonthly.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_salesHistoryMonthly.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_salesHistoryWeekly_Init()
        {
            grid_salesHistoryWeekly.AutoGenerateColumns = false;

            grid_salesHistoryWeekly.ColumnCount = 4;

            grid_salesHistoryWeekly.Columns[0].Name = "Year";
            grid_salesHistoryWeekly.Columns[0].ReadOnly = true;
            //grid_salesHistoryWeekly.Columns[0].Visible = false;
            grid_salesHistoryWeekly.Columns[0].Width = 50;
            grid_salesHistoryWeekly.Columns[0].DataPropertyName = "Year";

            grid_salesHistoryWeekly.Columns[1].Name = "Month";
            grid_salesHistoryWeekly.Columns[1].ReadOnly = true;
            grid_salesHistoryWeekly.Columns[1].Visible = false;
            grid_salesHistoryWeekly.Columns[1].Width = 40;
            grid_salesHistoryWeekly.Columns[1].DataPropertyName = "Month";

            grid_salesHistoryWeekly.Columns[2].Name = "Week";
            grid_salesHistoryWeekly.Columns[2].ReadOnly = true;
            grid_salesHistoryWeekly.Columns[2].Width = 40;
            grid_salesHistoryWeekly.Columns[2].DataPropertyName = "Week";

            grid_salesHistoryWeekly.Columns[3].Name = "Qty";
            grid_salesHistoryWeekly.Columns[3].ReadOnly = true;
            grid_salesHistoryWeekly.Columns[3].Width = 50;
            grid_salesHistoryWeekly.Columns[3].DefaultCellStyle.Format = "N2";
            grid_salesHistoryWeekly.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesHistoryWeekly.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesHistoryWeekly.Columns[3].DataPropertyName = "TotalQty";

            //grid font size custom
            grid_salesHistoryWeekly.RowTemplate.Height = 20;
            grid_salesHistoryWeekly.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_salesHistoryWeekly.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_salesHistoryWeekly.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_addMemo_Click(object sender, EventArgs e)
        {
            String SupplierID = "";
            String Brand = txt_brand.Text.Trim();
            String ProductID = cbo_product.Text.Trim();
            String Memo = txt_memo.Text.Trim();
            String BasedDate = cbo_basedDate.Text.Trim();
            DateTime StartDate = dateTimePicker_startDate.Value;
            DateTime EndDate = dateTimePicker_endDate.Value;

            connPO.sp_POPREPARE_ADDMEMO(SupplierID, Brand, ProductID, Memo, BasedDate, StartDate, EndDate);

            connSalesOrder.sp_POPREPARE_BRANDMEMO(grid_brandMemo, Brand);
        }
    }
}
