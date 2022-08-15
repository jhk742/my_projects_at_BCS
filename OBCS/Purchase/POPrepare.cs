using OBCS.Reports;
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
using Excel = Microsoft.Office.Interop.Excel;



namespace OBCS.Purchase
{
    public partial class POPrepare : Form
    {
        //TextBox textBoxDgv1 = new TextBox();
        //TextBox textBoxDgv2 = new TextBox();
        //TextBox textBoxDgv3 = new TextBox();
        //TextBox textBoxDgv4 = new TextBox();
        //TextBox textBoxDgv5 = new TextBox();
        //Label labelDgv1 = new Label();


        public POPrepare()
        {
            InitializeComponent();
            //if (GATE.userID == "BCS")
            //{
            //    groupBox1.Visible = true;
            //}
            //grid_POPrepares.Height = 744;
            grid_POPrepares_Init();
            grid_AffiliatedPO_Init();
 
            grid_POPrepares.Columns["inner"].Visible = false;
            grid_POPrepares.Columns["T"].Visible = false;
            grid_POPrepares.Columns["H"].Visible = false;
            grid_POPrepares.Columns["ShelfLife"].Visible = false;
            grid_POPrepares.Columns["Guaranteed Day"].Visible = false;

            var chart = chart_poPrepare.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chart.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chart.AxisX.Interval = 1;
            chart.AxisX.LabelStyle.Format = "yyyy.MM.dd";

            gridMonthSet();

            grid_LastPriceOfVendor.Visible = false;
            chart_poPrepare.Visible = false;
            grid_contentControl.Visible = false;
            cbo_brand_Init();

            grid_LastPriceOfVendor_Init();

            cbo_category_Init();

            //labelDgv1.Text = "Total";
            //labelDgv1.Height = 22;
            //labelDgv1.AutoSize = false;
            //labelDgv1.BorderStyle = BorderStyle.Fixed3D;
            //labelDgv1.TextAlign = ContentAlignment.MiddleCenter;
            //int Xdgv1 = this.grid_POPrepares.GetCellDisplayRectangle(2, -1, true).Location.X;
            //labelDgv1.Width = this.grid_POPrepares.Columns[2].Width + Xdgv1;
            //labelDgv1.Location = new Point(0, this.grid_POPrepares.Height - textBoxDgv1.Height);
            //this.grid_POPrepares.Controls.Add(labelDgv1);

            for(int i = 0; i < grid_POPrepares.ColumnCount; i++)
            {
                grid_POPrepares.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            



        }

        private void gridMonthSet()
        {
            //DateTime Today = DateTime.Now;

            //int j = 0;
            //for (int i = 0; i < 24; i++)
            //{
            //    j = i;
            //    if (i >= 12)
            //        j = i + 1;

            //    this.grid_POPrepares.Columns[21 + j].HeaderText = Today.AddMonths(-i).ToString("yyyy.MM");
            //}
        }
        private void grid_AffiliatedPO_Init()
        {
            grid_AffiliatedPO.AutoGenerateColumns = false;
            grid_AffiliatedPO.ColumnCount = 5;

            grid_AffiliatedPO.Columns[0].Name = "PO #";
            grid_AffiliatedPO.Columns[0].ReadOnly = true;
            grid_AffiliatedPO.Columns[0].Width = 70;
            grid_AffiliatedPO.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AffiliatedPO.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AffiliatedPO.Columns[0].DataPropertyName = "PONUMBER";

            grid_AffiliatedPO.Columns[1].Name = "PO Date";
            grid_AffiliatedPO.Columns[1].ReadOnly = true;
            grid_AffiliatedPO.Columns[1].Width = 70;
            grid_AffiliatedPO.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AffiliatedPO.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AffiliatedPO.Columns[1].DataPropertyName = "PODATE";

            grid_AffiliatedPO.Columns[2].Name = "Reception Status";
            grid_AffiliatedPO.Columns[2].ReadOnly = true;
            grid_AffiliatedPO.Columns[2].Width = 70;
            grid_AffiliatedPO.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AffiliatedPO.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AffiliatedPO.Columns[2].DataPropertyName = "POSTATUS";

            grid_AffiliatedPO.Columns[3].Name = "Reception Date";
            grid_AffiliatedPO.Columns[3].ReadOnly = true;
            grid_AffiliatedPO.Columns[3].Width = 70;
            grid_AffiliatedPO.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AffiliatedPO.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AffiliatedPO.Columns[3].DataPropertyName = "PORCPTDATE";

            grid_AffiliatedPO.Columns[4].Name = "Location";
            grid_AffiliatedPO.Columns[4].ReadOnly = true;
            grid_AffiliatedPO.Columns[4].Width = 40;
            grid_AffiliatedPO.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AffiliatedPO.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_AffiliatedPO.Columns[4].DataPropertyName = "POLOCATION";


            grid_AffiliatedPO.RowTemplate.Height = 23;
            
            foreach (DataGridViewColumn c in grid_AffiliatedPO.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Regular);
            }

            grid_AffiliatedPO.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
           
        }
        private void grid_POPrepares_Init()
        {
            grid_POPrepares.AutoGenerateColumns = false;
            //grid_POPrepares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_POPrepares.ColumnCount = 45;
            
            //[0] Product ID
            grid_POPrepares.Columns[0].Name = "Product ID";
            grid_POPrepares.Columns[0].ReadOnly = true;
            grid_POPrepares.Columns[0].Width = 75;
            grid_POPrepares.Columns[0].DataPropertyName = "ProductID";

            //[1] DESC
            grid_POPrepares.Columns[1].Name = "DESC";
            grid_POPrepares.Columns[1].ReadOnly = true;
            grid_POPrepares.Columns[1].Width = 300;
            grid_POPrepares.Columns[1].DataPropertyName = "ProductDesc";

            grid_POPrepares.Columns[2].Name = "PackSize";
            grid_POPrepares.Columns[2].ReadOnly = true;
            grid_POPrepares.Columns[2].Width = 80;
            grid_POPrepares.Columns[2].DataPropertyName = "StrPackSize";
            
            //[2] LastRecDate
            grid_POPrepares.Columns[3].Name = "Last RecDate";
            grid_POPrepares.Columns[3].ReadOnly = true;
            grid_POPrepares.Columns[3].Width = 70;
            grid_POPrepares.Columns[3].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_POPrepares.Columns[3].DataPropertyName = "LastRecDate";

            //[3] LastRecQty
            grid_POPrepares.Columns[4].Name = "Last RecQty";
            grid_POPrepares.Columns[4].ReadOnly = true;
            grid_POPrepares.Columns[4].Width = 70;
            grid_POPrepares.Columns[4].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[4].DataPropertyName = "LastRecQty";

            

            //[5] OnNY if (ViewLocQty.checked)
            grid_POPrepares.Columns[5].Name = "OnNY";
            grid_POPrepares.Columns[5].ReadOnly = true;
            grid_POPrepares.Columns[5].Width = 70;
            grid_POPrepares.Columns[5].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[5].DataPropertyName = "OnhandNY";

            //[6] OnNJ if (ViewLocQty.checked)
            grid_POPrepares.Columns[6].Name = "OnNJ";
            grid_POPrepares.Columns[6].ReadOnly = true;
            grid_POPrepares.Columns[6].Width = 70;
            grid_POPrepares.Columns[6].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[6].DataPropertyName = "OnhandNJ";

            //[4] OnHand
            grid_POPrepares.Columns[7].Name = "OnHand";
            grid_POPrepares.Columns[7].ReadOnly = true;
            grid_POPrepares.Columns[7].Width = 70;
            grid_POPrepares.Columns[7].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[7].DataPropertyName = "Onhand";

            //[7] OnOrder
            grid_POPrepares.Columns[8].Name = "OnOrder";
            grid_POPrepares.Columns[8].ReadOnly = true;
            grid_POPrepares.Columns[8].Width = 70;
            grid_POPrepares.Columns[8].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[8].DataPropertyName = "OnOrder";

            //[8] OrderDate
            grid_POPrepares.Columns[9].Name = "Last Order Date";
            grid_POPrepares.Columns[9].ReadOnly = true;
            grid_POPrepares.Columns[9].Width = 70;
            grid_POPrepares.Columns[9].DataPropertyName = "LastOrderDate";
        
            //[9] ExpDate
            grid_POPrepares.Columns[10].Name = "ExpDate";
            grid_POPrepares.Columns[10].ReadOnly = true;
            grid_POPrepares.Columns[10].Width = 70;
            grid_POPrepares.Columns[10].DataPropertyName = "ExpDate";

            //[10] Replenish
            grid_POPrepares.Columns[11].Name = "Order Qty.";
            grid_POPrepares.Columns[11].Width = 70;
            grid_POPrepares.Columns[11].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[11].DataPropertyName = "OrderQty";
            
            //[11] Inner
            grid_POPrepares.Columns[12].Name = "Inner";
            grid_POPrepares.Columns[12].ReadOnly = true;
            grid_POPrepares.Columns[12].Width = 50;
            grid_POPrepares.Columns[12].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[12].DataPropertyName = "CsInner";

            //[12] T
            grid_POPrepares.Columns[13].Name = "T";
            grid_POPrepares.Columns[13].Width = 50;
            grid_POPrepares.Columns[13].ReadOnly = true;
            grid_POPrepares.Columns[13].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[13].DataPropertyName = "T";
            
            //[13] H
            grid_POPrepares.Columns[14].Name = "H";
            grid_POPrepares.Columns[14].Width = 50;
            grid_POPrepares.Columns[14].ReadOnly = true;
            grid_POPrepares.Columns[14].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[14].DataPropertyName = "H";

            //[14] ShelfLife
            grid_POPrepares.Columns[15].Name = "ShelfLife";
            grid_POPrepares.Columns[15].ReadOnly = true;
            grid_POPrepares.Columns[15].Width = 70;
            grid_POPrepares.Columns[15].DataPropertyName = "ShelfLife";
        
            //[15] ShelfLife
            grid_POPrepares.Columns[16].Name = "Guaranteed Day";
            grid_POPrepares.Columns[16].ReadOnly = true;
            grid_POPrepares.Columns[16].Width = 70;
            grid_POPrepares.Columns[16].DataPropertyName = "GuaranteeDay";

            //[16] Expect
            grid_POPrepares.Columns[17].Name = "Expect";
            grid_POPrepares.Columns[17].ReadOnly = true;
            grid_POPrepares.Columns[17].Width = 70;
            grid_POPrepares.Columns[17].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[17].DataPropertyName = "Expect";

            //[17] ~ SPEED
            grid_POPrepares.Columns[18].Name = DateTime.Now.ToString("yyyy.MM").Trim();//"M01";
            grid_POPrepares.Columns[18].ReadOnly = true;
            grid_POPrepares.Columns[18].Width = 70;
            grid_POPrepares.Columns[18].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[18].DataPropertyName = "M01";

            grid_POPrepares.Columns[19].Name = DateTime.Now.AddMonths(-1).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[19].ReadOnly = true;
            grid_POPrepares.Columns[19].Width = 70;
            grid_POPrepares.Columns[19].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[19].DataPropertyName = "M02";

            grid_POPrepares.Columns[20].Name = DateTime.Now.AddMonths(-2).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[20].ReadOnly = true;
            grid_POPrepares.Columns[20].Width = 70;
            grid_POPrepares.Columns[20].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[20].DataPropertyName = "M03";

            grid_POPrepares.Columns[21].Name = DateTime.Now.AddMonths(-3).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[21].ReadOnly = true;
            grid_POPrepares.Columns[21].Width = 70;
            grid_POPrepares.Columns[21].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[21].DataPropertyName = "M04";

            grid_POPrepares.Columns[22].Name = DateTime.Now.AddMonths(-4).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[22].ReadOnly = true;
            grid_POPrepares.Columns[22].Width = 70;
            grid_POPrepares.Columns[22].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[22].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[22].DataPropertyName = "M05";

            grid_POPrepares.Columns[23].Name = DateTime.Now.AddMonths(-5).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[23].ReadOnly = true;
            grid_POPrepares.Columns[23].Width = 70;
            grid_POPrepares.Columns[23].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[23].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[23].DataPropertyName = "M06";

            grid_POPrepares.Columns[24].Name = DateTime.Now.AddMonths(-6).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[24].ReadOnly = true;
            grid_POPrepares.Columns[24].Width = 70;
            grid_POPrepares.Columns[24].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[24].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[24].DataPropertyName = "M07";

            grid_POPrepares.Columns[25].Name = DateTime.Now.AddMonths(-7).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[25].ReadOnly = true;
            grid_POPrepares.Columns[25].Width = 70;
            grid_POPrepares.Columns[25].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[25].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[25].DataPropertyName = "M08";

            grid_POPrepares.Columns[26].Name = DateTime.Now.AddMonths(-8).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[26].ReadOnly = true;
            grid_POPrepares.Columns[26].Width = 70;
            grid_POPrepares.Columns[26].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[26].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[26].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[26].DataPropertyName = "M09";

            grid_POPrepares.Columns[27].Name = DateTime.Now.AddMonths(-9).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[27].ReadOnly = true;
            grid_POPrepares.Columns[27].Width = 70;
            grid_POPrepares.Columns[27].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[27].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[27].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[27].DataPropertyName = "M10";

            grid_POPrepares.Columns[28].Name = DateTime.Now.AddMonths(-10).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[28].ReadOnly = true;
            grid_POPrepares.Columns[28].Width = 70;
            grid_POPrepares.Columns[28].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[28].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[28].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[28].DataPropertyName = "M11";

            grid_POPrepares.Columns[29].Name = DateTime.Now.AddMonths(-11).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[29].ReadOnly = true;
            grid_POPrepares.Columns[29].Width = 70;
            grid_POPrepares.Columns[29].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[29].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[29].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[29].DataPropertyName = "M12";

            grid_POPrepares.Columns[30].Name = "Total1";
            grid_POPrepares.Columns[30].ReadOnly = true;
            grid_POPrepares.Columns[30].Width = 70;
            grid_POPrepares.Columns[30].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[30].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[30].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[30].DataPropertyName = "SpeedTotal1";

            grid_POPrepares.Columns[31].Name = "30";
            grid_POPrepares.Columns[31].Visible = false;
            grid_POPrepares.Columns[31].Width = 70;
            grid_POPrepares.Columns[31].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[31].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[31].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[31].DataPropertyName = "";

            grid_POPrepares.Columns[32].Name = DateTime.Now.AddMonths(-12).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[32].ReadOnly = true;
            grid_POPrepares.Columns[32].Width = 70;
            grid_POPrepares.Columns[32].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[32].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[32].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[32].DataPropertyName = "M13";

            grid_POPrepares.Columns[33].Name = DateTime.Now.AddMonths(-13).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[33].ReadOnly = true;
            grid_POPrepares.Columns[33].Width = 70;
            grid_POPrepares.Columns[33].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[33].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[33].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[33].DataPropertyName = "M14";

            grid_POPrepares.Columns[34].Name = DateTime.Now.AddMonths(-14).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[34].ReadOnly = true;
            grid_POPrepares.Columns[34].Width = 70;
            grid_POPrepares.Columns[34].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[34].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[34].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[34].DataPropertyName = "M15";

            grid_POPrepares.Columns[35].Name = DateTime.Now.AddMonths(-15).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[35].ReadOnly = true;
            grid_POPrepares.Columns[35].Width = 70;
            grid_POPrepares.Columns[35].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[35].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[35].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[35].DataPropertyName = "M16";

            grid_POPrepares.Columns[36].Name = DateTime.Now.AddMonths(-16).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[36].ReadOnly = true;
            grid_POPrepares.Columns[36].Width = 70;
            grid_POPrepares.Columns[36].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[36].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[36].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[36].DataPropertyName = "M17";

            grid_POPrepares.Columns[37].Name = DateTime.Now.AddMonths(-17).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[37].ReadOnly = true;
            grid_POPrepares.Columns[37].Width = 70;
            grid_POPrepares.Columns[37].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[37].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[37].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[37].DataPropertyName = "M18";

            grid_POPrepares.Columns[38].Name = DateTime.Now.AddMonths(-18).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[38].ReadOnly = true;
            grid_POPrepares.Columns[38].Width = 70;
            grid_POPrepares.Columns[38].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[38].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[38].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[38].DataPropertyName = "M19";

            grid_POPrepares.Columns[39].Name = DateTime.Now.AddMonths(-19).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[39].ReadOnly = true;
            grid_POPrepares.Columns[39].Width = 70;
            grid_POPrepares.Columns[39].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[39].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[39].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[39].DataPropertyName = "M20";

            grid_POPrepares.Columns[40].Name = DateTime.Now.AddMonths(-20).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[40].ReadOnly = true;
            grid_POPrepares.Columns[40].Width = 70;
            grid_POPrepares.Columns[40].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[40].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[40].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[40].DataPropertyName = "M21";

            grid_POPrepares.Columns[41].Name = DateTime.Now.AddMonths(-21).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[41].ReadOnly = true;
            grid_POPrepares.Columns[41].Width = 70;
            grid_POPrepares.Columns[41].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[41].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[41].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[41].DataPropertyName = "M22";

            grid_POPrepares.Columns[42].Name = DateTime.Now.AddMonths(-22).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[42].ReadOnly = true;
            grid_POPrepares.Columns[42].Width = 70;
            grid_POPrepares.Columns[42].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[42].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[42].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[42].DataPropertyName = "M23";
       
            grid_POPrepares.Columns[43].Name = DateTime.Now.AddMonths(-23).ToString("yyyy.MM").Trim();//"M02";
            grid_POPrepares.Columns[43].ReadOnly = true;
            grid_POPrepares.Columns[43].Width = 70;
            grid_POPrepares.Columns[43].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[43].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[43].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[43].DataPropertyName = "M24";

            grid_POPrepares.Columns[44].Name = "Total2";
            grid_POPrepares.Columns[44].ReadOnly = true;
            grid_POPrepares.Columns[44].Width = 70;
            grid_POPrepares.Columns[44].DefaultCellStyle.Format = "N2";
            grid_POPrepares.Columns[44].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[44].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POPrepares.Columns[44].DataPropertyName = "SpeedTotal2";



            //grid font size custom
            grid_POPrepares.RowTemplate.Height = 23;

            foreach (DataGridViewColumn c in grid_POPrepares.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Regular);
            }

            grid_POPrepares.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);

        }

        
        private void Total_in_Grid()
        {
            DataTable dataTable = (DataTable)grid_POPrepares.DataSource;
            DataRow drTodelete = dataTable.Rows[grid_POPrepares.RowCount - 1];
            
            decimal total_OnNY = 0, total_OnNJ = 0, total_OnHand = 0, total_OnOrderQty = 0, total_Expect = 0,
               total_LastRecQty = 0, total_Onorder = 0, total_Speed_Total = 0, total_Speed_Total2 = 0;
            decimal[] a = new decimal[24];
            for (int i = 0; i < grid_POPrepares.RowCount-1; i++)
            {
                total_OnNY += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["OnNY"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["OnNY"].Value);
                total_OnNJ += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["OnNJ"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["OnNJ"].Value);
                total_OnOrderQty += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["Order Qty."].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["Order Qty."].Value);
                total_Expect += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["Expect"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["Expect"].Value);
                total_OnHand += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["OnHand"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["OnHand"].Value);
                total_LastRecQty += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["Last RecQty"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["Last RecQty"].Value);
                total_Onorder += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["OnOrder"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["OnOrder"].Value);
                total_Speed_Total += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["Total1"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["Total1"].Value);
                total_Speed_Total2 += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["Total2"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["Total2"].Value);
                a[0] += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells[DateTime.Now.ToString("yyyy.MM").Trim()].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells[DateTime.Now.ToString("yyyy.MM").Trim()].Value);
                for (int j = 1; j < a.Length; j++)
                {
                    a[j] += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells[DateTime.Now.AddMonths(-j).ToString("yyyy.MM")].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells[DateTime.Now.AddMonths(-j).ToString("yyyy.MM")].Value);
                }
            }

            drTodelete["ProductID"] = "TOTAL";
            drTodelete["OnhandNY"] = total_OnNY.ToString();
            drTodelete["Onhand"] = total_OnHand.ToString();
            drTodelete["OnhandNJ"] = total_OnNJ.ToString();
            drTodelete["OrderQty"] = total_OnOrderQty.ToString();
            drTodelete["Expect"] = total_Expect.ToString();
            drTodelete["OnOrder"] = total_Onorder.ToString();
            drTodelete["LastRecQty"] = total_LastRecQty.ToString();
            drTodelete["SpeedTotal1"] = total_Speed_Total.ToString();
            drTodelete["SpeedTotal2"] = total_Speed_Total2.ToString();

            for (int i = 0; i < a.Length; i++)
            {
                if (i < 9) drTodelete["M0" + (i + 1).ToString().Trim()] = a[i].ToString();
                else drTodelete["M" + (i + 1).ToString().Trim()] = a[i].ToString();
            }
            

            //dataTable.AcceptChanges();
            //MessageBox.Show(total_OnNY + "\n" + total_OnNJ + "\n" + total_OnNY + "\n" + total_OnOrderQty + "\n" + total_Expect + "\n" + total_OnHand + "\n" + total_LastRecQty + "\n" + total_Onorder + "\n" + total_Speed_Total + "\n" + total_Speed_Total2 + "\n");


            //this.grid_POPrepares.ClearSelection();

           
        }

        private void grid_POPrepares_Load()
        {
            //Clear the binding.
            grid_POPrepares.DataSource = null;

            decimal total_OnNY = 0, total_OnNJ = 0, total_OnHand = 0, total_OnOrderQty = 0, total_Expect = 0, 
                total_LastRecQty = 0, total_Onorder = 0, total_Speed_Total = 0, total_Speed_Total2 = 0;
            decimal[] a = new decimal[24];
            
            //connPO.POPrepare(grid_POPrepares, cbo_vendor.Text, cbo_brand.Text, "", dateTimePicker_ToDay.Value, cbo_category.Text);
            connPO.POPrepare2(grid_POPrepares, cbo_brandCode.Text.Trim(), cbo_vendor.Text.Trim(), cbo_category.Text.Trim());

            for (int i = 0; i < grid_POPrepares.RowCount; i++)
            {
                total_OnNY += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["OnNY"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["OnNY"].Value);
                total_OnNJ += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["OnNJ"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["OnNJ"].Value);
                total_OnOrderQty += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["Order Qty."].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["Order Qty."].Value);
                total_Expect += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["Expect"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["Expect"].Value);
                total_OnHand += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["OnHand"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["OnHand"].Value);         
                total_LastRecQty += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["Last RecQty"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["Last RecQty"].Value);
                total_Onorder += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["OnOrder"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["OnOrder"].Value);
                total_Speed_Total += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["Total1"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["Total1"].Value);
                total_Speed_Total2 += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["Total2"].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells["Total2"].Value);
                a[0] += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells[DateTime.Now.ToString("yyyy.MM").Trim()].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells[DateTime.Now.ToString("yyyy.MM").Trim()].Value);
                for (int j = 1; j< a.Length; j++)
                {
                   a[j] += Convert.ToDecimal(grid_POPrepares.Rows[i].Cells[DateTime.Now.AddMonths(-j).ToString("yyyy.MM")].Value == DBNull.Value ? "0" : grid_POPrepares.Rows[i].Cells[DateTime.Now.AddMonths(-j).ToString("yyyy.MM")].Value);
                }

                if (grid_POPrepares.Rows[i].Cells["Product ID"].Value == null || grid_POPrepares.Rows[i].Cells["DESC"].Value == null)
                {
                    grid_POPrepares.Rows[i].Cells["Product ID"].Value = "";
                    grid_POPrepares.Rows[i].Cells["DESC"].Value = "";
                }
                else
                {
                    grid_POPrepares.Rows[i].Cells["Product ID"].Value = grid_POPrepares.Rows[i].Cells["Product ID"].Value.ToString().Trim();
                    grid_POPrepares.Rows[i].Cells["DESC"].Value = grid_POPrepares.Rows[i].Cells["DESC"].Value.ToString().Trim();
                }

                //for (int j = 0; j < grid_POPrepares.ColumnCount; j++)
                //{
                //    //MessageBox.Show(grid_POPrepares.Rows[i].Cells[j].Value.GetType().ToString() + ":" + grid_POPrepares.Rows[i].Cells[j].Value.ToString());
                //    //if (grid_POPrepares.Rows[i].Cells[j].Value.GetType().ToString() == "System.String" || grid_POPrepares.Rows[i].Cells[j].Value.GetType().ToString() == null)
                //    if (grid_POPrepares.Rows[i].Cells[j].Value == null)
                //    {
                //        grid_POPrepares.Rows[i].Cells[j].Value = "";
                //    }
                //    else
                //    {
                //        grid_POPrepares.Rows[i].Cells[j].Value = grid_POPrepares.Rows[i].Cells[j].Value.ToString().Trim();
                //    }
                //}
            }
            DataTable dataTable = (DataTable)grid_POPrepares.DataSource;
            DataRow drToAdd = dataTable.NewRow();
            drToAdd["ProductID"] = "TOTAL";
            drToAdd["OnhandNY"] = total_OnNY.ToString();
            drToAdd["Onhand"] = total_OnHand.ToString();
            drToAdd["OnhandNJ"] = total_OnNJ.ToString();
            drToAdd["OrderQty"] = total_OnOrderQty.ToString();
            drToAdd["Expect"] = total_Expect.ToString();
            drToAdd["OnOrder"] = total_Onorder.ToString();
            drToAdd["LastRecQty"] = total_LastRecQty.ToString();
            drToAdd["SpeedTotal1"] = total_Speed_Total.ToString();
            drToAdd["SpeedTotal2"] = total_Speed_Total2.ToString();
            
            for (int i = 0; i < a.Length; i++)
            {
                if(i < 9) drToAdd["M0"+(i+1).ToString().Trim()] = a[i].ToString();
                else drToAdd["M" + (i+1).ToString().Trim()] = a[i].ToString();
            }
            
                //grid_POPrepares.Rows[grid_POPrepares.RowCount].DefaultCellStyle.BackColor = Color.OldLace;

            dataTable.Rows.Add(drToAdd);
            
            dataTable.AcceptChanges();

            this.grid_POPrepares.ClearSelection();

            grid_POPrepares.Columns["Product ID"].Frozen = true;
            grid_POPrepares.Columns["Product ID"].DividerWidth = 2;
            


        }
       
        private void grid_LastPriceOfVendor_Init()
        {
            grid_LastPriceOfVendor.AutoGenerateColumns = false;
            grid_LastPriceOfVendor.ReadOnly = true;

            grid_LastPriceOfVendor.ColumnCount = 14;

            grid_LastPriceOfVendor.Columns[0].Name = "POKey";
            grid_LastPriceOfVendor.Columns[0].Width = 50;
            grid_LastPriceOfVendor.Columns[0].DataPropertyName = "POKey";

            grid_LastPriceOfVendor.Columns[1].Name = "Vendor";
            grid_LastPriceOfVendor.Columns[1].Width = 60;
            grid_LastPriceOfVendor.Columns[1].DataPropertyName = "VendorID";

            grid_LastPriceOfVendor.Columns[2].Name = "OrdDate";
            grid_LastPriceOfVendor.Columns[2].Width = 70;
            grid_LastPriceOfVendor.Columns[2].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_LastPriceOfVendor.Columns[2].DataPropertyName = "OrderDate";

            grid_LastPriceOfVendor.Columns[3].Name = "RecDate";
            grid_LastPriceOfVendor.Columns[3].Width = 70;
            grid_LastPriceOfVendor.Columns[3].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_LastPriceOfVendor.Columns[3].DataPropertyName = "RecevingDate";

            grid_LastPriceOfVendor.Columns[4].Name = "OrdQty";
            grid_LastPriceOfVendor.Columns[4].Width = 60;
            grid_LastPriceOfVendor.Columns[4].DefaultCellStyle.Format = "N2";
            grid_LastPriceOfVendor.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LastPriceOfVendor.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LastPriceOfVendor.Columns[4].DataPropertyName = "CsOrdQty";

            grid_LastPriceOfVendor.Columns[5].Name = "RecQty";
            grid_LastPriceOfVendor.Columns[5].Width = 60;
            grid_LastPriceOfVendor.Columns[5].DefaultCellStyle.Format = "N2";
            grid_LastPriceOfVendor.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LastPriceOfVendor.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LastPriceOfVendor.Columns[5].DataPropertyName = "CsRecQty";

            grid_LastPriceOfVendor.Columns[6].Name = "ListPr";
            grid_LastPriceOfVendor.Columns[6].Width = 60;
            grid_LastPriceOfVendor.Columns[6].DefaultCellStyle.Format = "N2";
            grid_LastPriceOfVendor.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LastPriceOfVendor.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LastPriceOfVendor.Columns[6].DataPropertyName = "ListPr";

            grid_LastPriceOfVendor.Columns[7].Name = "DK1";
            grid_LastPriceOfVendor.Columns[7].Width = 30;
            grid_LastPriceOfVendor.Columns[7].DataPropertyName = "DcKind1";

            grid_LastPriceOfVendor.Columns[8].Name = "Dc1";
            grid_LastPriceOfVendor.Columns[8].Width = 50;
            grid_LastPriceOfVendor.Columns[8].DefaultCellStyle.Format = "N2";
            grid_LastPriceOfVendor.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LastPriceOfVendor.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LastPriceOfVendor.Columns[8].DataPropertyName = "DcRate1";

            grid_LastPriceOfVendor.Columns[9].Name = "DK2";
            grid_LastPriceOfVendor.Columns[9].Width = 30;
            grid_LastPriceOfVendor.Columns[9].DataPropertyName = "DcKind2";

            grid_LastPriceOfVendor.Columns[10].Name = "Dc2";
            grid_LastPriceOfVendor.Columns[10].Width = 50;
            grid_LastPriceOfVendor.Columns[10].DefaultCellStyle.Format = "N2";
            grid_LastPriceOfVendor.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LastPriceOfVendor.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LastPriceOfVendor.Columns[10].DataPropertyName = "DcRate2";

            grid_LastPriceOfVendor.Columns[11].Name = "NetPr";
            grid_LastPriceOfVendor.Columns[11].Width = 70;
            grid_LastPriceOfVendor.Columns[11].DefaultCellStyle.Format = "N2";
            grid_LastPriceOfVendor.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LastPriceOfVendor.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LastPriceOfVendor.Columns[11].DataPropertyName = "NetPr";

            grid_LastPriceOfVendor.Columns[12].Name = "Amount";
            grid_LastPriceOfVendor.Columns[12].Width = 70;
            grid_LastPriceOfVendor.Columns[12].DefaultCellStyle.Format = "N2";
            grid_LastPriceOfVendor.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LastPriceOfVendor.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_LastPriceOfVendor.Columns[12].DataPropertyName = "Amount";

            grid_LastPriceOfVendor.Columns[13].Name = "ExpDate";
            grid_LastPriceOfVendor.Columns[13].Width = 60;
            grid_LastPriceOfVendor.Columns[13].DataPropertyName = "ExpireDate";

            //grid font size custom
            grid_LastPriceOfVendor.RowTemplate.Height = 20;

            foreach (DataGridViewColumn c in grid_LastPriceOfVendor.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Regular);
            }
            grid_LastPriceOfVendor.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
        }

        private void grid_LastPriceOfVendor_Load(string ProductKey)
        {
            //Clear the binding.
            //grid_LastPriceOfVendor.DataSource = null;

            connPO.LastPriceOfVendor(grid_LastPriceOfVendor, ProductKey);

            for (int i = 0; i < grid_LastPriceOfVendor.RowCount; i++)
            {
                for (int j = 0; j < grid_LastPriceOfVendor.ColumnCount; j++)
                {
                    if (grid_LastPriceOfVendor.Rows[i].Cells[j].Value == null)
                    {
                        grid_LastPriceOfVendor.Rows[i].Cells[j].Value = "";
                    }
                    else
                    {
                        grid_LastPriceOfVendor.Rows[i].Cells[j].Value = grid_LastPriceOfVendor.Rows[i].Cells[j].Value.ToString().Trim();
                    }
                }
            }
            this.grid_LastPriceOfVendor.Sort(this.grid_LastPriceOfVendor.Columns["OrdDate"], ListSortDirection.Descending);

            this.grid_LastPriceOfVendor.ClearSelection();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            grid_POPrepares_Load();
            //select first row when clicked find button
            //grid_POPrepares_CellClick(sender, new DataGridViewCellEventArgs(0, 3));
        }

        private void rbtn_view_Click(object sender, EventArgs e)
        {
            grid_POPrepares.Columns["ExpDate"].Visible = false;
            grid_POPrepares.Columns["Order Qty."].Visible = false;
            grid_POPrepares.Columns["inner"].Visible = false;
            grid_POPrepares.Columns["T"].Visible = false;
            grid_POPrepares.Columns["*"].Visible = false;
            grid_POPrepares.Columns["H"].Visible = false;
            grid_POPrepares.Columns["Expect"].Visible = false;
        }

        private void rbtn_edit_Click(object sender, EventArgs e)
        {
            grid_POPrepares.Columns["ExpDate"].Visible = false;
            grid_POPrepares.Columns["Order Qty."].Visible = true;
            grid_POPrepares.Columns["inner"].Visible = true;
            grid_POPrepares.Columns["T"].Visible = true;
            grid_POPrepares.Columns["*"].Visible = false;
            grid_POPrepares.Columns["H"].Visible = true;

            grid_POPrepares.Columns["ShelfLife"].Visible = true;
            grid_POPrepares.Columns["Expect"].Visible = true;
        }

        private void cbox_viewDetail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_viewDetail.Checked == true)
            {
                grid_POPrepares.Height = 539;
                grid_LastPriceOfVendor.Visible = true;
                chart_poPrepare.Visible = true;
                grid_contentControl.Visible = true;
            }
            else
            {
                grid_POPrepares.Height = 744;
                grid_LastPriceOfVendor.Visible = false;
                chart_poPrepare.Visible = false;
                grid_contentControl.Visible = false;
            }
        }

        private void grid_POPrepares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String productID = grid_POPrepares.CurrentRow.Cells["Product ID"].Value.ToString().Trim();
            connPO.sp_AffiliatedPO(grid_AffiliatedPO, productID);
            /*
            String productID = grid_POPrepares.Rows[e.RowIndex].Cells["Product ID"].Value.ToString();
            var mainForm = Application.OpenForms.OfType<POPrepData>().FirstOrDefault();
            mainForm.txt_product.Text = productID;
            /*
             
            /*
            //grid_POPrepares.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = Color.Aqua;
            try
            {
                string CurrentReplenishString = grid_POPrepares.CurrentRow.Cells["Order Qty."].Value.ToString();
                double CurrentReplenish = Convert.ToDouble(CurrentReplenishString);

                string innerString = grid_POPrepares.CurrentRow.Cells["Inner"].Value.ToString();
                double inner = Convert.ToDouble(innerString);

                string CurrentExpectString = grid_POPrepares.CurrentRow.Cells["Expect"].Value.ToString();
                OriginalExpect = Convert.ToDouble(CurrentExpectString) - CurrentReplenish * inner;

                string productKey = grid_POPrepares.Rows[e.RowIndex].Cells["ProductKey"].Value.ToString();
                grid_LastPriceOfVendor_Load(productKey);

                string productID = grid_POPrepares.Rows[e.RowIndex].Cells["Product ID"].Value.ToString();
                txt_product.Text = productID;

                int i = 1;
                int M = 24;
                string MXX;
                int MMonth = 23;

                double highestM = 0;

                //graph

                //chart_poPrepare.Series["ThisYear"].Points.Clear();

                chart_poPrepare.Series.Clear();

                chart_poPrepare.Series.Add("ThisYear");
                chart_poPrepare.Series.Add("LastYear");

                this.chart_poPrepare.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
                this.chart_poPrepare.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;

                chart_poPrepare.Series["ThisYear"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_poPrepare.Series["LastYear"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


                for (i = 1; i <= M; i++)
                {
                    if (i < 10)
                    {
                        MXX = "M0" + i.ToString();
                    }
                    else
                    {
                        MXX = "M" + i.ToString(); ;
                    }

                    String MString = grid_POPrepares.Rows[e.RowIndex].Cells[MXX].Value.ToString();
                    double Mdouble = Convert.ToDouble(MString);

                    if (Mdouble > highestM)
                    {
                        highestM = Mdouble;
                    }

                    DateTime Today = DateTime.Now;


                    String MMonthString = Today.AddMonths(-MMonth).ToString("yyyy.MM");
                    //chart_poPrepare.Series["ThisYear"].Points.AddXY(MMonthString, Mdouble);
                    //MessageBox.Show(MMonth.ToString());
                    if (MMonth >= 12)
                    {
                        chart_poPrepare.Series["ThisYear"].Points.AddXY(MMonthString, Mdouble);
                    }
                    else
                    {
                        chart_poPrepare.Series["LastYear"].Points.AddY(Mdouble);
                    }


                    MMonth = MMonth - 1;

                }
                //chart_poPrepare.ChartAreas[0].AxisY.ScaleView.Zoom(-10, highestM);
                // chart_poPrepare.Series["ThisYear"].IsValueShownAsLabel = true;
                chart_poPrepare.Series["ThisYear"].IsVisibleInLegend = true;
                chart_poPrepare.Series["ThisYear"].LegendText = "Last Year";
                chart_poPrepare.Series["ThisYear"].BorderWidth = 3;
                chart_poPrepare.Series["ThisYear"].Color = Color.Salmon;
                chart_poPrepare.Series["ThisYear"].MarkerStyle = MarkerStyle.Circle;
                chart_poPrepare.Series["ThisYear"].MarkerSize = 7;
                chart_poPrepare.Series["ThisYear"].MarkerColor = Color.Red;

                //chart_poPrepare.Series["LastYear"].IsValueShownAsLabel = true;
                chart_poPrepare.Series["LastYear"].IsVisibleInLegend = true;
                chart_poPrepare.Series["LastYear"].LegendText = "This Year";
                chart_poPrepare.Series["LastYear"].BorderWidth = 3;
                chart_poPrepare.Series["LastYear"].Color = Color.CornflowerBlue;
                chart_poPrepare.Series["LastYear"].MarkerStyle = MarkerStyle.Circle;
                chart_poPrepare.Series["LastYear"].MarkerSize = 7;
                chart_poPrepare.Series["LastYear"].MarkerColor = Color.Blue;
            }
            catch
            {

            }
            */
        }

        private void cbo_brand_Click(object sender, EventArgs e)
        {
            cbo_brand_DroppedDown();
        }

        private void cbo_brand_DroppedDown()
        {
            cbo_brand.DroppedDown = true;
        }

        private void cbo_brand_Init()
        {
            cbo_brand.Items.Clear();
            connPO.sp_GET_Brand(cbo_brand);
        }

        private void cbo_brand_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbo_brand.DroppedDown = true;

            //if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //{
            //    getMemo(cbo_brand.Text.Trim());
            //    grid_POPrepares_Load();
            //}
        }



        private void getMemo(String BrandName, String BrandCode)
        {
            txt_memo.Text = "";
            //string brandKey = connPO.getBrandKey(cbo_brand.Text);
            txt_memo.Text = connPO.sp_Brand_Memo(BrandName, BrandCode);
        }

        private void setVendor(string SelectedBrandName)
        {
            this.grid_POPrepares.DataSource = null;
            this.grid_POPrepares.Rows.Clear();
            this.grid_LastPriceOfVendor.DataSource = null;
            this.grid_LastPriceOfVendor.Rows.Clear();
            this.chart_poPrepare.Series.Clear();
            cbo_vendor.Text = "";
            try
            {
                
                cbo_vendor.Items.Clear();
                connPO.sp_Brands_Supplier(cbo_vendor, cbo_brand.Text.Trim());
                cbo_brandCode.Items.Clear();
                connPO.sp_GET_BrandCode(cbo_brandCode, cbo_brand.Text.Trim());

                cbo_vendor.Text = cbo_vendor.Items[0].ToString();
                string VendorTraderEntityKey = connPO.getVendorTraderEntityKey(cbo_vendor.Text).Trim();
                string ShipVia = connPO.sp_GET_ShipVia(cbo_vendor.Text.Trim(), "");//connPO.getShipViaWithShipViaKey(VendorTraderEntityKey);
                txt_shipVia.Text = ShipVia;
                cbo_brandCode.Text = cbo_brandCode.Items[0].ToString();
            }
            catch
            {

            }
        }

        private void cbo_category_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbo_category.DroppedDown = true;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

            }
        }

        private void cbo_category_Click(object sender, EventArgs e)
        {
            cbo_category.DroppedDown = true;
        }

        private void cbo_category_Init()
        {
            cbo_category.Items.Clear();
            connPO.cbox_getCategory(cbo_category);
            cbo_category.Text = cbo_category.Items[0].ToString();
        }

        private void cbox_viewLocQty_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_viewLocQty.Checked == true)
            {
                grid_POPrepares.Columns["OnNY"].Visible = true;
                grid_POPrepares.Columns["OnNJ"].Visible = true;

            }
            else
            {
                grid_POPrepares.Columns["OnNY"].Visible = false;
                grid_POPrepares.Columns["OnNJ"].Visible = false;
            }
        }

        private void cbox_expDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_expDate.Checked == true)
            {
                grid_POPrepares.Columns["ExpDate"].Visible = true;

            }
            else
            {
                grid_POPrepares.Columns["ExpDate"].Visible = false;
            }
        }

        private void cbox_shelfLife_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_shelfLife.Checked == true)
            {
                grid_POPrepares.Columns["ShelfLife"].Visible = true;

            }
            else
            {
                grid_POPrepares.Columns["ShelfLife"].Visible = false;
            }
        }

        private void cbox_weekly_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            int M = 24;
            string MXX;

            if (cbox_weekly.Checked == true)
            {
                for (i = 0; i <= M; i++)
                {
                    if (i < 10)
                    {
                        MXX = "M0" + i.ToString();
                    }
                    else
                    {
                        MXX = "M" + i.ToString(); ;
                    }
                    grid_POPrepares.Columns[MXX].Visible = false;
                }
                grid_POPrepares.Columns["MXX"].Visible = false;
                grid_POPrepares.Columns["First Year"].Visible = false;
                grid_POPrepares.Columns["Second Year"].Visible = false;


            }
            else
            {
                for (i = 0; i <= M; i++)
                {
                    if (i < 10)
                    {
                        MXX = "M0" + i.ToString(); ;
                    }
                    else
                    {
                        MXX = "M" + i.ToString(); ;
                    }
                    grid_POPrepares.Columns[MXX].Visible = true;
                }
                grid_POPrepares.Columns["MXX"].Visible = true;
                grid_POPrepares.Columns["First Year"].Visible = true;
                grid_POPrepares.Columns["Second Year"].Visible = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Proceed with this P/O prepare process?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < grid_POPrepares.RowCount - 1; i++)
                {

                    String productID = grid_POPrepares.Rows[i].Cells["Product ID"].Value.ToString().Trim();
                    String QtyReplenishString = grid_POPrepares.Rows[i].Cells["Order Qty."].Value.ToString().Trim();
                    Decimal QtyReplenish = Convert.ToDecimal(QtyReplenishString);
                    if (QtyReplenish > 0)
                    {
                        connPO.sp_CREATE_POPrepareDetail(productID, QtyReplenish);
                    }

                    //connPO.SavePOPrepare(productID, QtyReplenish);
                }

                String Vendor = cbo_vendor.Text.Trim();
                String Brand = cbo_brandCode.Text.Trim();
                String Memo = txt_poPrepareMemo.Text.Trim();
                connPO.sp_CREATE_POPrepare(Vendor, Brand, Memo);

                MessageBox.Show("P/O prepare successfully saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                grid_POPrepares_Load();
                txt_poPrepareMemo.Text = "";

            }
            else if (dialogResult == DialogResult.No)
            {

            }

            
        }

        double OriginalExpect;
        private void grid_POPrepares_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string CurrentReplenishString = grid_POPrepares.CurrentRow.Cells["Order Qty."].Value.ToString();
                double CurrentReplenish = Convert.ToDouble(CurrentReplenishString);

                string innerString = grid_POPrepares.CurrentRow.Cells["Inner"].Value.ToString();
                double inner = Convert.ToDouble(innerString);

                string CurrentExpectString = grid_POPrepares.CurrentRow.Cells["Expect"].Value.ToString();
                OriginalExpect = Convert.ToDouble(CurrentExpectString) - CurrentReplenish * inner;

                string productKey = grid_POPrepares.CurrentRow.Cells["ProductKey"].Value.ToString();
                grid_LastPriceOfVendor_Load(productKey);

                string productID = grid_POPrepares.CurrentRow.Cells["Product ID"].Value.ToString();
                txt_product.Text = productID;

                int i = 1;
                int M = 24;
                string MXX;
                int MMonth = 23;

                double highestM = 0;

                //graph

                //chart_poPrepare.Series["ThisYear"].Points.Clear();

                chart_poPrepare.Series.Clear();

                chart_poPrepare.Series.Add("ThisYear");
                chart_poPrepare.Series.Add("LastYear");

                this.chart_poPrepare.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
                this.chart_poPrepare.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;

                chart_poPrepare.Series["ThisYear"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_poPrepare.Series["LastYear"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


                for (i = 1; i <= M; i++)
                {
                    if (i < 10)
                    {
                        MXX = "M0" + i.ToString();
                    }
                    else
                    {
                        MXX = "M" + i.ToString(); ;
                    }

                    String MString = grid_POPrepares.CurrentRow.Cells[MXX].Value.ToString();
                    double Mdouble = Convert.ToDouble(MString);

                    if (Mdouble > highestM)
                    {
                        highestM = Mdouble;
                    }

                    DateTime Today = DateTime.Now;


                    String MMonthString = Today.AddMonths(-MMonth).ToString("yyyy.MM");
                    //chart_poPrepare.Series["ThisYear"].Points.AddXY(MMonthString, Mdouble);
                    //MessageBox.Show(MMonth.ToString());
                    if (MMonth >= 12)
                    {
                        chart_poPrepare.Series["ThisYear"].Points.AddXY(MMonthString, Mdouble);
                    }
                    else
                    {
                        chart_poPrepare.Series["LastYear"].Points.AddY(Mdouble);
                    }

                    MMonth = MMonth - 1;

                }
                //chart_poPrepare.ChartAreas[0].AxisY.ScaleView.Zoom(-10, highestM);
                // chart_poPrepare.Series["ThisYear"].IsValueShownAsLabel = true;
                chart_poPrepare.Series["ThisYear"].IsVisibleInLegend = true;
                chart_poPrepare.Series["ThisYear"].LegendText = "Last Year";
                chart_poPrepare.Series["ThisYear"].BorderWidth = 3;
                chart_poPrepare.Series["ThisYear"].Color = Color.Salmon;
                chart_poPrepare.Series["ThisYear"].MarkerStyle = MarkerStyle.Circle;
                chart_poPrepare.Series["ThisYear"].MarkerSize = 7;
                chart_poPrepare.Series["ThisYear"].MarkerColor = Color.Red;

                //chart_poPrepare.Series["LastYear"].IsValueShownAsLabel = true;
                chart_poPrepare.Series["LastYear"].IsVisibleInLegend = true;
                chart_poPrepare.Series["LastYear"].LegendText = "This Year";
                chart_poPrepare.Series["LastYear"].BorderWidth = 3;
                chart_poPrepare.Series["LastYear"].Color = Color.CornflowerBlue;
                chart_poPrepare.Series["LastYear"].MarkerStyle = MarkerStyle.Circle;
                chart_poPrepare.Series["LastYear"].MarkerSize = 7;
                chart_poPrepare.Series["LastYear"].MarkerColor = Color.Blue;
            }
            catch
            {

            }
        }
        
        private void grid_POPrepares_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (grid_POPrepares.CurrentRow.Cells["Order Qty."].Value.ToString().Trim() == "")
                {
                    grid_POPrepares.CurrentRow.Cells["Order Qty."].Value = "0";
                }
                string ReplenishString = grid_POPrepares.CurrentRow.Cells["Order Qty."].Value.ToString();
                double Replenish = Convert.ToDouble(ReplenishString);

                string innerString = grid_POPrepares.CurrentRow.Cells["Inner"].Value.ToString();
                double inner = Convert.ToDouble(innerString);

                double ExpectResult = OriginalExpect + Replenish * inner;
                grid_POPrepares.CurrentRow.Cells["Expect"].Value = ExpectResult;
                
                totalCalculate();
                Total_in_Grid();
            }
            catch
            {
                
            }
        }

        private void grid_POPrepares_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String Date = grid_POPrepares.Columns[e.ColumnIndex].HeaderText.ToString();
                String productID = grid_POPrepares.CurrentRow.Cells["Product ID"].Value.ToString().Trim();

                if ((Date.Substring(0, 1).Equals("2")))
                {
                    if (productID.Equals("TOTAL"))
                    {

                    }
                    else
                    {
                        DateTime FromDate = Convert.ToDateTime(Date).Date;
                        DateTime ToDate = Convert.ToDateTime(Date).AddMonths(1).Date;
                        //MessageBox.Show(FromDate.ToString() + "\n" + ToDate.ToString() + "\n" + productID);
                        Purchase.POPrepare_Detail pOPrepare_Detail = new Purchase.POPrepare_Detail(FromDate, ToDate, productID);
                        pOPrepare_Detail.Show();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_makeExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            fichero.FileName = "export.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                // changing the name of active sheet
                hoja_trabajo.Name = "Sheet1";
                // storing header part in Excel
                for (int i = 1; i < grid_POPrepares.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i] = grid_POPrepares.Columns[i - 1].HeaderText;
                }

                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 1; i < grid_POPrepares.Rows.Count + 1; i++)
                {
                    for (int j = 0; j < grid_POPrepares.Columns.Count; j++)
                    {
                        MessageBox.Show(grid_POPrepares.Rows[i - 1].ToString());

                        hoja_trabajo.Cells[i + 1, j + 1] = grid_POPrepares.Rows[i - 1].Cells[j].Value.ToString();

                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }

            //Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            //WorkBook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            //copyAlltoClipboard();
            //Microsoft.Office.Interop.Excel.Application xlexcel;
            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            //Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;
            //xlexcel = new Excel.Application();
            //xlexcel.Visible = true;
            //xlWorkBook = xlexcel.Workbooks.Add(misValue);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            //CR.Select();
            //xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void btn_memo_Click(object sender, EventArgs e)
        {
            if(cbo_brand.Text.Equals(""))
            {
                MessageBox.Show("Select Brand", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                //string brandKey = connPO.getBrandKey(cbo_brand.Text);
                String BrandName = cbo_brand.Text.Trim();
                String BrandMemo = txt_memo.Text;
                String BrandCode = cbo_brandCode.Text.Trim();
                connPO.sp_UPDATE_BrandMemo(BrandName, BrandCode, BrandMemo);

                MessageBox.Show("The memo has been updated successfully.\n\n"+ cbo_brand.Text + ":\n" + BrandMemo, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_printForPO_Click(object sender, EventArgs e)
        {
            if(cbo_brand.Text != "")
            {
                String brandName = cbo_brand.Text;
                Rpt_InventoryFlowByLastRecDateByBrand rpt_InventoryFlowByLastRecDateByBrand = new Rpt_InventoryFlowByLastRecDateByBrand(brandName);
                rpt_InventoryFlowByLastRecDateByBrand.MdiParent = this.MdiParent;
                rpt_InventoryFlowByLastRecDateByBrand.Show();
            }
            else
            {
                MessageBox.Show("Please select Brand.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

        }

        private void cbo_vendor_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_shipVia.Text = connPO.sp_GET_ShipVia(cbo_vendor.Text.Trim(), "");
            //txt_leadtime.Text = connPO.getLeadtime(cbo_brandCode.Text.Trim());
            //grid_POPrepares_Load();
        }

        private void POPrepare_Load(object sender, EventArgs e)
        {

        }

        public string FileSelected { get; set; }
        private void cbo_brand_Leave(object sender, EventArgs e)
        {
            //getMemo(cbo_brand.Text.Trim());
            setVendor(cbo_brand.Text);
            //grid_POPrepares_Load();
            
        }

        private void cbo_brand_SelectedValueChanged(object sender, EventArgs e)
        {
            //getMemo(cbo_brand.Text.Trim());
            setVendor(cbo_brand.Text);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void POPrepare_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var mainForm = Application.OpenForms.OfType<POPrepData>().FirstOrDefault();
                mainForm.Close();
            }
            
            catch
            {
                
            }
        }

        private void grid_POPrepares_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String productID = grid_POPrepares.Rows[e.RowIndex].Cells["Product ID"].Value.ToString();
                var mainForm = Application.OpenForms.OfType<POPrepData>().FirstOrDefault();
                mainForm.txt_product.Text = productID;
                
            }
            catch
            {

            }
            
        }

        private void cbox_more_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_more.Checked == true)
            {
                grid_POPrepares.Columns["inner"].Visible = true;
                grid_POPrepares.Columns["T"].Visible = true;
                grid_POPrepares.Columns["H"].Visible = true;
                grid_POPrepares.Columns["ShelfLife"].Visible = true;
                grid_POPrepares.Columns["Guaranteed Day"].Visible = true;
            }
            else
            {
                grid_POPrepares.Columns["inner"].Visible = false;
                grid_POPrepares.Columns["T"].Visible = false;
                grid_POPrepares.Columns["H"].Visible = false;
                grid_POPrepares.Columns["ShelfLife"].Visible = false;
                grid_POPrepares.Columns["Guaranteed Day"].Visible = false;
            }
            
        }

        private void POPrepare_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void grid_POPrepares_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            totalCalculate();
            foreach (DataGridViewRow row in this.grid_POPrepares.Rows)
            {
                row.Cells["OnHand"].Style.BackColor = Color.OldLace;
                row.Cells["Order Qty."].Style.BackColor = Color.OldLace;
                row.Cells["Total1"].Style.BackColor = Color.OldLace;
                row.Cells["Total2"].Style.BackColor = Color.OldLace;
                row.Cells["Expect"].Style.BackColor = Color.Yellow;
                if (row.Cells["Product ID"].Value.Equals("TOTAL"))
                {
                    row.Cells["OnHand"].Style.BackColor = Color.Gray;
                    row.Cells["Order Qty."].Style.BackColor = Color.Gray;
                    row.Cells["Total1"].Style.BackColor = Color.Gray;
                    row.Cells["Total2"].Style.BackColor = Color.Gray;
                    row.Cells["Expect"].Style.BackColor = Color.Gray;
                    row.DefaultCellStyle.BackColor = Color.Gray;
                    row.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }

        private void totalCalculate()
        {
            Decimal TotalOnNY = 0;
            Decimal TotalOnNJ = 0;
            Decimal TotalOnHand = 0;
            Decimal TotalOnOrder = 0;
            Decimal TotalOrderQty = 0;
            Decimal TotalExpect = 0;

            for (int i = 0; i < grid_POPrepares.RowCount-1; i++)
            {
                Decimal OnNY = Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["OnNY"].Value.ToString().Trim());
                TotalOnNY = TotalOnNY + OnNY;

                Decimal OnNJ = Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["OnNJ"].Value.ToString().Trim());
                TotalOnNJ = TotalOnNJ + OnNJ;

                Decimal OnHand = Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["OnHand"].Value.ToString().Trim());
                TotalOnHand = TotalOnHand + OnHand;

                Decimal OnOrder = Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["OnOrder"].Value.ToString().Trim());
                TotalOnOrder = TotalOnOrder + OnOrder;

                Decimal OrderQty = Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["Order Qty."].Value.ToString().Trim());
                TotalOrderQty = TotalOrderQty + OrderQty;

                Decimal Expect = Convert.ToDecimal(grid_POPrepares.Rows[i].Cells["Expect"].Value.ToString().Trim());
                TotalExpect = TotalExpect + Expect;
            }
            txt_onNYTotal.Text = TotalOnNY.ToString("N2");
            txt_onNJTotal.Text = TotalOnNJ.ToString("N2");
            txt_onhandTotal.Text = TotalOnHand.ToString("N2");
            txt_onOrder.Text = TotalOnOrder.ToString("N2");
            txt_orderQty.Text = TotalOrderQty.ToString("N2");
            txt_expectTotal.Text = TotalExpect.ToString("N2");
        }

        private void grid_POPrepares_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //int sum = 0;
            //for (int i = 0; i < this.grid_POPrepares.Rows.Count; i++)
            //{
            //    if (grid_POPrepares.Rows[i].Cells["Expect"].Value != string.Empty)
            //    {
            //        sum += Convert.ToInt32(this.grid_POPrepares["Expect", i].Value);
            //    }

            //}
            //textBoxDgv1.Text = sum.ToString();
            //MessageBox.Show("grid_POPrepares_CellPainting");
            //textBoxDgv1.Text = cbo_brand.Text.Trim();
            //textBoxDgv2.Text = cbo_brand.Text.Trim();
            //textBoxDgv3.Text = cbo_brand.Text.Trim();
            //textBoxDgv4.Text = cbo_brand.Text.Trim();
            //textBoxDgv5.Text = cbo_brand.Text.Trim();

            //int Xdgvx = this.grid_POPrepares.GetCellDisplayRectangle(2, -1, true).Location.X;
            //labelDgv1.Width = this.grid_POPrepares.Columns[3].Width + Xdgvx;
            //labelDgv1.Location = new Point(0, this.grid_POPrepares.Height - textBoxDgv1.Height);
            //textBoxDgv1.Width = this.grid_POPrepares.Columns[3].Width;
            //Xdgvx = this.grid_POPrepares.GetCellDisplayRectangle(3, -1, true).Location.X;
            //textBoxDgv1.Location = new Point(Xdgvx, this.grid_POPrepares.Height - textBoxDgv1.Height);
            //textBoxDgv2.Location = new Point(Xdgvx + textBoxDgv1.Width, this.grid_POPrepares.Height - textBoxDgv1.Height);
            //textBoxDgv3.Location = new Point(Xdgvx + textBoxDgv1.Width + textBoxDgv2.Width, this.grid_POPrepares.Height - textBoxDgv1.Height);
            //textBoxDgv4.Location = new Point(Xdgvx + textBoxDgv1.Width + textBoxDgv2.Width + textBoxDgv3.Width, this.grid_POPrepares.Height - textBoxDgv1.Height);
            //textBoxDgv5.Location = new Point(Xdgvx + textBoxDgv1.Width + textBoxDgv2.Width + textBoxDgv3.Width + textBoxDgv4.Width, this.grid_POPrepares.Height - textBoxDgv1.Height);
            ////textBoxDgv1.Location = new Point(0, 0);
            //this.grid_POPrepares.Controls.Add(textBoxDgv1);
            //this.grid_POPrepares.Controls.Add(textBoxDgv2);
            //this.grid_POPrepares.Controls.Add(textBoxDgv3);
            //this.grid_POPrepares.Controls.Add(textBoxDgv4);
            //this.grid_POPrepares.Controls.Add(textBoxDgv5);
        }

        private void grid_POPrepares_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            grid_POPrepares_Load();
        }

        private void cbo_brandCode_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_leadtime.Text = "";
            String BrandName = cbo_brand.Text.Trim();
            String BrandCode = cbo_brandCode.Text.Trim();
            txt_leadtime.Text = connPO.getLeadtime(BrandCode);
            getMemo(BrandName, BrandCode);
            grid_POPrepares_Load();

            grid_POPrepares.Rows[0].Selected = true;
            connPO.sp_AffiliatedPO(grid_AffiliatedPO, grid_POPrepares.Rows[0].Cells["Product ID"].Value.ToString().Trim());
            try
            {
                var mainForm = Application.OpenForms.OfType<POPrepData>().FirstOrDefault();
                mainForm.txt_brand.Text = cbo_brand.Text;
            }
            catch
            {
            }
        }
    }
}
