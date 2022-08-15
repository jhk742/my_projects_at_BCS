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
    public partial class AGING : Form
    {
        public AGING()
        {
            InitializeComponent();
            grid_aging_Init();

            cbo_site.Items.Add("");
            cbo_site.Items.Add("BCS");
            cbo_site.Items.Add("NYC");
            cbo_site.Items.Add("HYD");
            cbo_site.Items.Add("CFI");
            cbo_site.Items.Add("NTM");

        }

        private void grid_aging_Init()
        {
            grid_aging.AutoGenerateColumns = false;
            grid_aging.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_aging.ColumnCount = 8;

            grid_aging.Columns[0].Name = "Customer ID";
            grid_aging.Columns[0].ReadOnly = true;
            grid_aging.Columns[0].Width = 120;
            grid_aging.Columns[0].MinimumWidth = 120;
            grid_aging.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid_aging.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid_aging.Columns[0].DataPropertyName = "CustomerID";

            grid_aging.Columns[1].Name = "Company";
            grid_aging.Columns[1].ReadOnly = true;
            grid_aging.Columns[1].Width = 300;
            grid_aging.Columns[1].MinimumWidth = 300;
            grid_aging.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid_aging.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid_aging.Columns[1].DataPropertyName = "CustomerName";

            grid_aging.Columns[2].Name = "Current Due";
            grid_aging.Columns[2].ReadOnly = true;
            grid_aging.Columns[2].Width = 120;
            grid_aging.Columns[2].MinimumWidth = 120;
            //grid_aging.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_aging.Columns[2].DefaultCellStyle.Format = "N2";
            grid_aging.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_aging.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_aging.Columns[2].DataPropertyName = "NotDue";

            grid_aging.Columns[3].Name = "1 - 30 Days";
            grid_aging.Columns[3].ReadOnly = true;
            grid_aging.Columns[3].Width = 120;
            grid_aging.Columns[3].MinimumWidth = 120;
            //grid_aging.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_aging.Columns[3].DefaultCellStyle.Format = "N2";
            grid_aging.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_aging.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_aging.Columns[3].DataPropertyName = "Days030";

            grid_aging.Columns[4].Name = "31 - 60 Days";
            grid_aging.Columns[4].ReadOnly = true;
            grid_aging.Columns[4].Width = 120;
            grid_aging.Columns[4].MinimumWidth = 120;
            //grid_aging.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_aging.Columns[4].DefaultCellStyle.Format = "N2";
            grid_aging.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_aging.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_aging.Columns[4].DataPropertyName = "Days3160";

            grid_aging.Columns[5].Name = "61 - 90 Days";
            grid_aging.Columns[5].ReadOnly = true;
            grid_aging.Columns[5].Width = 120;
            grid_aging.Columns[5].MinimumWidth = 120;
            //grid_aging.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_aging.Columns[5].DefaultCellStyle.Format = "N2";
            grid_aging.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_aging.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_aging.Columns[5].DataPropertyName = "Days6190";

            grid_aging.Columns[6].Name = "+ 91 Days";
            grid_aging.Columns[6].ReadOnly = true;
            grid_aging.Columns[6].Width = 120;
            grid_aging.Columns[6].MinimumWidth = 120;
            //grid_aging.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_aging.Columns[6].DefaultCellStyle.Format = "N2";
            grid_aging.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_aging.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_aging.Columns[6].DataPropertyName = "Days90Over";

            grid_aging.Columns[7].Name = "Total";
            grid_aging.Columns[7].ReadOnly = true;
            grid_aging.Columns[7].Width = 140;
            grid_aging.Columns[7].MinimumWidth = 140;
            //grid_aging.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_aging.Columns[7].DefaultCellStyle.Format = "N2";
            grid_aging.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_aging.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_aging.Columns[7].DataPropertyName = "Total";
            
            //grid font size custom
            grid_aging.RowTemplate.Height = 20;
            grid_aging.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_aging.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_aging.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;
            String Site = cbo_site.Text.Trim();
            string CustomerID = txt_CustomerID.Text.Trim();
            //string Customer_ID = txt_CustomerID.Text.Trim();
            //MessageBox.Show(date.ToString());
            connSalesOrder.sp_AGING_AR_SUMMARY(grid_aging, date, CustomerID, Site);
        }

        private void grid_aging_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            txt_totalAR.Text = "";
            txt_notDue.Text = "";
            txt_030.Text = "";
            txt_3160.Text = "";
            txt_6190.Text = "";
            txt_91.Text = "";
            txt_count.Text = "";
            try
            {
                Decimal TotalOpenAR = 0;
                Decimal TotalnotDue = 0;
                Decimal Total030 = 0;
                Decimal Total3160 = 0;
                Decimal Total6190 = 0;
                Decimal Total91 = 0;
                Decimal TotalOpenARCount = 0;
                for (int i = 0; i < grid_aging.Rows.Count; i++)
                {
                    Decimal OpenAR = Convert.ToDecimal(grid_aging.Rows[i].Cells[7].Value);
                    TotalOpenAR = TotalOpenAR + OpenAR;

                    Decimal notDue = Convert.ToDecimal(grid_aging.Rows[i].Cells[2].Value);
                    TotalnotDue = TotalnotDue + notDue;

                    Decimal d030 = Convert.ToDecimal(grid_aging.Rows[i].Cells[3].Value);
                    Total030 = Total030 + d030;

                    Decimal d3160 = Convert.ToDecimal(grid_aging.Rows[i].Cells[4].Value);
                    Total3160 = Total3160 + d3160;

                    Decimal d6190 = Convert.ToDecimal(grid_aging.Rows[i].Cells[5].Value);
                    Total6190 = Total6190 + d6190;

                    Decimal d91 = Convert.ToDecimal(grid_aging.Rows[i].Cells[6].Value);
                    Total91 = Total91 + d91;

                    TotalOpenARCount = TotalOpenARCount + 1;
                }

                txt_totalAR.Text = TotalOpenAR.ToString("N2");
                txt_notDue.Text = TotalnotDue.ToString("N2");
                txt_030.Text = Total030.ToString("N2");
                txt_3160.Text = Total3160.ToString("N2");
                txt_6190.Text = Total6190.ToString("N2");
                txt_91.Text = Total91.ToString("N2");
                txt_count.Text = TotalOpenARCount.ToString();
            }
            catch
            {

            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime Todate = dateTimePicker1.Value.Date;
            String Site = cbo_site.Text.Trim();
            String CustomerID = txt_CustomerID.Text.Trim();
            Reports.Rpt_AGING_AR_SUMMARY AR_SUMMARY = new Reports.Rpt_AGING_AR_SUMMARY(Todate, CustomerID, Site);
            AR_SUMMARY.Show();
            Reports.Rpt_AGING_AR_DETAIL AR_DETAIL = new Reports.Rpt_AGING_AR_DETAIL(Todate, CustomerID, Site);
            AR_DETAIL.Show();
        }


    }
}
