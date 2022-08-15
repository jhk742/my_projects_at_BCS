using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Lists
{
    public partial class NutCategorySalesReport : Form
    {
        public NutCategorySalesReport()
        {
            InitializeComponent();
            grid_NutDelivery_Init();
            cbx_NutNumber.Items.Add("8");
            cbx_NutNumber.Items.Add("12");
            cbx_NutNumber.Items.Add("16");
            cbx_NutNumber.Items.Add("24");
            cbx_NutNumber.Items.Add("32");
            cbx_NutNumber.Items.Add("5");
            cbx_NutNumber.Items.Add("10");
            //dateTimePickerFrom.Value = DateTime.Today.AddDays(-1);
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = FromDate.AddDays(+1); 
            string NutNumber = cbx_NutNumber.Text.Trim();
            string MixORNot = "Not";
            //connSalesOrder.sp_delivery_Nut(grid_NutDelivery, FromDate, ToDate, NutNumber,MixORNot);
        }
        private void grid_NutDelivery_Init()
        {
            grid_NutDelivery.AutoGenerateColumns = false;
            grid_NutDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_NutDelivery.ColumnCount = 5;

            grid_NutDelivery.Columns[0].Name = "Product ID";
            grid_NutDelivery.Columns[0].Visible = true;
            grid_NutDelivery.Columns[0].Width = 60;
            grid_NutDelivery.Columns[0].MinimumWidth = 60;
            grid_NutDelivery.Columns[0].DataPropertyName = "ProductID";

            grid_NutDelivery.Columns[1].Name = "Description";
            grid_NutDelivery.Columns[1].ReadOnly = true;
            grid_NutDelivery.Columns[1].Width = 140;
            grid_NutDelivery.Columns[1].MinimumWidth = 140;
            grid_NutDelivery.Columns[1].DataPropertyName = "ProductDesc";

            grid_NutDelivery.Columns[2].Name = "Pack Size";
            grid_NutDelivery.Columns[2].ReadOnly = true;
            grid_NutDelivery.Columns[2].Width = 50;
            grid_NutDelivery.Columns[2].MinimumWidth = 50;
            grid_NutDelivery.Columns[2].DataPropertyName = "StrPackSize";

            grid_NutDelivery.Columns[3].Name = "Qty";
            grid_NutDelivery.Columns[3].ReadOnly = true;
            grid_NutDelivery.Columns[3].Width = 50;
            grid_NutDelivery.Columns[3].MinimumWidth = 50;
            grid_NutDelivery.Columns[3].DefaultCellStyle.Format = "N2";
            grid_NutDelivery.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_NutDelivery.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_NutDelivery.Columns[3].DataPropertyName = "Qty";

            grid_NutDelivery.Columns[4].Name = "Create Time";
            grid_NutDelivery.Columns[4].ReadOnly = true;
            grid_NutDelivery.Columns[4].Width = 80;
            grid_NutDelivery.Columns[4].MinimumWidth = 80;
            grid_NutDelivery.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_NutDelivery.Columns[4].DataPropertyName = "CreateTime";
           

            //grid font size custom
            grid_NutDelivery.RowTemplate.Height = 20;
            grid_NutDelivery.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_NutDelivery.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_NutDelivery.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_PMsearch_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = FromDate.AddDays(1);
            string NutNumber = cbx_NutNumber.Text.Trim();
            String MixORNot = "";
            if (chb_Mix.Checked) MixORNot = "Mix";
            else MixORNot = "Not";

            connSalesOrder.sp_delivery_Nut(grid_NutDelivery, FromDate, ToDate, NutNumber, MixORNot);
        }

        private void chb_Mix_CheckedChanged(object sender, EventArgs e)
        {
            cbx_NutNumber.Items.Clear();
            cbx_NutNumber.Text = "";
            if (chb_Mix.Checked)
            {
                cbx_NutNumber.Items.Add("5");
                cbx_NutNumber.Items.Add("10");
                cbx_NutNumber.Items.Add("25");
            }
            else
            {
                cbx_NutNumber.Items.Add("8");
                cbx_NutNumber.Items.Add("12");
                cbx_NutNumber.Items.Add("16");
                cbx_NutNumber.Items.Add("24");
                cbx_NutNumber.Items.Add("32");
                cbx_NutNumber.Items.Add("5");
                cbx_NutNumber.Items.Add("10");
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = FromDate.AddDays(1);
            string NutNumber = cbx_NutNumber.Text.Trim();
            String MixORNot = "";
            if (chb_Mix.Checked) MixORNot = "Mix";
            else MixORNot = "Not";
            Reports.Rpt_NutDeliveryList rpt_NutDeliveryList = new Reports.Rpt_NutDeliveryList(FromDate, ToDate, NutNumber, MixORNot);
            rpt_NutDeliveryList.Show();
        }
    }
}
