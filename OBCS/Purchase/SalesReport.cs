using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Purchase
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
            grid_Item_Init();
            grid_detail_Init();
            connPO.cbox_Brand(cbo_Brand);
            //connPO.sp_GET_Brand(cbo_Brand);
        }
        private void grid_Item_Init()
        {
            grid_Item.AutoGenerateColumns = false;
            grid_Item.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Item.ColumnCount = 2;
            
            DataGridViewCheckBoxColumn confirmCheck = new DataGridViewCheckBoxColumn();
            confirmCheck.HeaderText = "V";
            confirmCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            confirmCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            confirmCheck.FalseValue = false;
            confirmCheck.TrueValue = true;
            confirmCheck.Name = "CheckBox";
            confirmCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            confirmCheck.ReadOnly = true;
            confirmCheck.Width = 20;
            //confirmCheck.HeaderCell.
            confirmCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            grid_Item.Columns.Insert(0, confirmCheck);
            grid_Item.CellContentClick += new DataGridViewCellEventHandler(confirmcellclick);

            grid_Item.Columns[1].Name = "Item Code";
            grid_Item.Columns[1].ReadOnly = true;
            grid_Item.Columns[1].Width = 10;
            grid_Item.Columns[1].MinimumWidth = 10;
            grid_Item.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Item.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Item.Columns[1].DataPropertyName = "ProductID";

            grid_Item.Columns[2].Name = "Description";
            grid_Item.Columns[2].ReadOnly = true;
            grid_Item.Columns[2].Width = 300;
            grid_Item.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Item.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Item.Columns[2].MinimumWidth = 300;
            grid_Item.Columns[2].DataPropertyName = "ProductDesc";

            //grid font size custom
            grid_Item.RowTemplate.Height = 20;
            //grid_po.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_Item.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            for (int i = 0; i < grid_Item.ColumnCount; i++)
            {
                grid_Item.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            grid_Item.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void grid_detail_Init()
        {
            grid_SalesDepletion.AutoGenerateColumns = false;
            grid_SalesDepletion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_SalesDepletion.ColumnCount = 15;

            grid_SalesDepletion.Columns[0].Name = "Inv NO";
            grid_SalesDepletion.Columns[0].ReadOnly = true;
            grid_SalesDepletion.Columns[0].Width = 40;
            grid_SalesDepletion.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[0].DataPropertyName = "INVOICE_NO";

            grid_SalesDepletion.Columns[1].Name = "Date";
            grid_SalesDepletion.Columns[1].ReadOnly = true;
            grid_SalesDepletion.Columns[1].Width = 40;
            grid_SalesDepletion.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_SalesDepletion.Columns[1].DataPropertyName = "DATE";

            grid_SalesDepletion.Columns[2].Name = "Rep";
            grid_SalesDepletion.Columns[2].ReadOnly = true;
            grid_SalesDepletion.Columns[2].Width = 20;
            grid_SalesDepletion.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[2].DataPropertyName = "SALEREP";

            grid_SalesDepletion.Columns[3].Name = "Brand";
            grid_SalesDepletion.Columns[3].ReadOnly = true;
            grid_SalesDepletion.Columns[3].Width = 30;
            grid_SalesDepletion.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[3].DataPropertyName = "BRAND";

            grid_SalesDepletion.Columns[4].Name = "Customer ID";
            grid_SalesDepletion.Columns[4].ReadOnly = true;
            grid_SalesDepletion.Columns[4].Width = 70;
            grid_SalesDepletion.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[4].DataPropertyName = "CustomerID";

            grid_SalesDepletion.Columns[5].Name = "Customer Name";
            grid_SalesDepletion.Columns[5].ReadOnly = true;
            grid_SalesDepletion.Columns[5].Width = 100;
            grid_SalesDepletion.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[5].DataPropertyName = "CUSTOMER";

            grid_SalesDepletion.Columns[6].Name = "Item";
            grid_SalesDepletion.Columns[6].ReadOnly = true;
            grid_SalesDepletion.Columns[6].Width = 30;
            grid_SalesDepletion.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[6].DataPropertyName = "ITEM";

            grid_SalesDepletion.Columns[7].Name = "Description";
            grid_SalesDepletion.Columns[7].ReadOnly = true;
            grid_SalesDepletion.Columns[7].Width = 100;
            grid_SalesDepletion.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[7].DataPropertyName = "DESCRIPTION";

            grid_SalesDepletion.Columns[8].Name = "PackSize";
            grid_SalesDepletion.Columns[8].ReadOnly = true;
            grid_SalesDepletion.Columns[8].Width = 40;
            grid_SalesDepletion.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[8].DataPropertyName = "StrPackSize";

            grid_SalesDepletion.Columns[9].Name = "Qty";
            grid_SalesDepletion.Columns[9].ReadOnly = true;
            grid_SalesDepletion.Columns[9].Width = 30;
            grid_SalesDepletion.Columns[9].DefaultCellStyle.Format = "N2";
            grid_SalesDepletion.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_SalesDepletion.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_SalesDepletion.Columns[9].DataPropertyName = "QTY_0";
        
            grid_SalesDepletion.Columns[10].Name = "Sales Amount";
            grid_SalesDepletion.Columns[10].ReadOnly = true;
            grid_SalesDepletion.Columns[10].Width = 50;
            grid_SalesDepletion.Columns[10].DefaultCellStyle.Format = "N2";
            grid_SalesDepletion.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_SalesDepletion.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_SalesDepletion.Columns[10].DataPropertyName = "SALES_AMOUNT";

            grid_SalesDepletion.Columns[11].Name = "Address";
            grid_SalesDepletion.Columns[11].ReadOnly = true;
            grid_SalesDepletion.Columns[11].Width = 80;
            grid_SalesDepletion.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[11].DataPropertyName = "BPAADDLIG_0";

            grid_SalesDepletion.Columns[12].Name = "City";
            grid_SalesDepletion.Columns[12].ReadOnly = true;
            grid_SalesDepletion.Columns[12].Width = 50;
            grid_SalesDepletion.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[12].DataPropertyName = "BPYCTY_0";

            grid_SalesDepletion.Columns[13].Name = "State";
            grid_SalesDepletion.Columns[13].ReadOnly = true;
            grid_SalesDepletion.Columns[13].Width = 30;
            grid_SalesDepletion.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[13].DataPropertyName = "BPYSAT_0";

            grid_SalesDepletion.Columns[14].Name = "Post";
            grid_SalesDepletion.Columns[14].ReadOnly = true;
            grid_SalesDepletion.Columns[14].Width = 50;
            grid_SalesDepletion.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesDepletion.Columns[14].DataPropertyName = "BPYPOSCOD_0";
            
            //grid font size custom
            grid_SalesDepletion.RowTemplate.Height = 20;
            grid_SalesDepletion.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_SalesDepletion.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_SalesDepletion.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void confirmcellclick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0) //confirm check box click
                {
                    if (Convert.ToBoolean(grid_Item.Rows[e.RowIndex].Cells[0].EditedFormattedValue) == false)
                        grid_Item.Rows[e.RowIndex].Cells[0].Value = true;
                    else // uncheck 했을 때
                        grid_Item.Rows[e.RowIndex].Cells[0].Value = false;
                }

            }
            catch { }
        }

        private void cbo_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_BrandName.Text = "";
            String Brand = cbo_Brand.Text;
            connPO.sp_Get_ItemForBrand(grid_Item, Brand);
            for (int i = 0; i < grid_Item.RowCount; i++)
            {
                grid_Item.Rows[i].Cells[0].Value = true;
            }
            connPO.sp_GET_BrandName(cbo_Brand, txt_BrandName);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String Brand = cbo_Brand.Text;
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String Text = "";
            int selectedItem = 0;
            //if (!cbo_Brand.Text.Equals(""))
            if (grid_Item.DataSource != null)
            {
                List<string> list = new List<string>();
                for (int i = 0; i < grid_Item.RowCount; i++)
                {
                    if (grid_Item.Rows[i].Cells[0].Value.Equals(true))
                    {
                        selectedItem += 1;
                        list.Add(grid_Item.Rows[i].Cells[1].Value.ToString());
                    }
                }
                string[] array = list.ToArray();
                if (selectedItem == 0)
                {
                    MessageBox.Show("Select Item.");
                }
                else
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Text += array[i].ToString();
                        if (i < (array.Length - 1)) Text += ",";
                    }
                    connPO.sp_PO_SalesDepletion(grid_SalesDepletion, Brand, FromDate, ToDate, Text);
                }
            }
            else
            {
                MessageBox.Show("Select Brand First");
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            String Brand = cbo_Brand.Text;
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String Text = "";
            int selectedItem = 0;
            List<string> list = new List<string>();
            for (int i = 0; i < grid_Item.RowCount; i++)
            {
                if (grid_Item.Rows[i].Cells[0].Value.Equals(true))
                {
                    selectedItem += 1;
                    list.Add(grid_Item.Rows[i].Cells[1].Value.ToString());
                }
            }
            string[] array = list.ToArray();

            if (selectedItem == 0)
            {
                MessageBox.Show("Select Item.");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Text += array[i].ToString();
                    if (i < (array.Length - 1)) Text += ",";
                }
                
                //MessageBox.Show("TEXT : "+Text);
                //connPO.sp_PO_SalesDepletionTEST(Brand, FromDate, ToDate, Text);
                btn_Search_Click(sender, e);
                Reports.Rpt_PO_SalesReport rpt_PO_SalesReport = new Reports.Rpt_PO_SalesReport(Brand, FromDate, ToDate, Text);
                rpt_PO_SalesReport.Show();
            }
        }
        private void grid_Item_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grid_Item.RowCount > 0)
            { 
                if (e.ColumnIndex == 0)
                {
                    if (Convert.ToBoolean(grid_Item.Rows[1].Cells[0].EditedFormattedValue) == false)
                        for (int i = 0; i < grid_Item.RowCount; i++)
                            grid_Item.Rows[i].Cells[0].Value = true;

                    else // uncheck 했을 때
                        for (int i = 0; i < grid_Item.RowCount; i++)
                            grid_Item.Rows[i].Cells[0].Value = false;
                }
            }
        }

        private void grid_SalesDepletion_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Decimal TotalQty = 0;
            Decimal TotalAmount = 0;

            for (int i = 0; i < grid_SalesDepletion.RowCount; i++)
            {
                Decimal Qty = Convert.ToDecimal(grid_SalesDepletion.Rows[i].Cells["Qty"].Value.ToString().Trim());
                TotalQty = TotalQty + Qty;

                Decimal Amount = Convert.ToDecimal(grid_SalesDepletion.Rows[i].Cells["Sales Amount"].Value.ToString().Trim());
                TotalAmount = TotalAmount + Amount;

            }
            txt_TQty.Text = TotalQty.ToString("N2");
            txt_TAmount.Text = TotalAmount.ToString("N2");
        }
    }
}
