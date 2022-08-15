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
    public partial class ProductFindDialog : Form
    {
        public ProductFindDialog()
        {
            InitializeComponent();
        }

        public ProductFindDialog(string VendorTraderEntityKey, CheckBox checkBox)
        {
            InitializeComponent();

            try
            {
                grid_salegrid_salesOrderItems_Init(VendorTraderEntityKey, checkBox);
            }
            catch
            {

            }
        }

        public void grid_salegrid_salesOrderItems_Init(string VendorTraderEntityKey, CheckBox checkbox)
        {
            grid_salesOrderItems.AutoGenerateColumns = false;

            grid_salesOrderItems.ColumnCount = 11;

            grid_salesOrderItems.Columns[0].Name = "ProductID";
            grid_salesOrderItems.Columns[0].Width = 70;
            grid_salesOrderItems.Columns[0].DataPropertyName = "ProductID";

            grid_salesOrderItems.Columns[1].Name = "PoCode";
            grid_salesOrderItems.Columns[1].Width = 70;
            grid_salesOrderItems.Columns[1].DataPropertyName = "PoCode";

            grid_salesOrderItems.Columns[2].Name = "Order Qty";
            grid_salesOrderItems.Columns[2].Width = 50;
            grid_salesOrderItems.Columns[2].DefaultCellStyle.Format = "N2";
            grid_salesOrderItems.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesOrderItems.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesOrderItems.Columns[2].DataPropertyName = "OrderQty";

            grid_salesOrderItems.Columns[3].Name = "ProductDesc";
            grid_salesOrderItems.Columns[3].Width = 200;
            grid_salesOrderItems.Columns[3].DataPropertyName = "ProductDesc";

            grid_salesOrderItems.Columns[4].Name = "Pack Size";
            grid_salesOrderItems.Columns[4].Width = 80;
            grid_salesOrderItems.Columns[4].DataPropertyName = "PackSize";

            grid_salesOrderItems.Columns[5].Name = "List Price";
            grid_salesOrderItems.Columns[5].Width = 50;
            grid_salesOrderItems.Columns[5].DefaultCellStyle.Format = "N2";
            grid_salesOrderItems.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesOrderItems.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesOrderItems.Columns[5].DataPropertyName = "ListPrice";

            grid_salesOrderItems.Columns[6].Name = "DK1";
            grid_salesOrderItems.Columns[6].DataPropertyName = "DK1";
            grid_salesOrderItems.Columns[6].Width = 30;

            grid_salesOrderItems.Columns[7].Name = "DcRate1";
            grid_salesOrderItems.Columns[7].DataPropertyName = "DcRate1";
            grid_salesOrderItems.Columns[7].DefaultCellStyle.Format = "N2";
            grid_salesOrderItems.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesOrderItems.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesOrderItems.Columns[7].Width = 50;

            grid_salesOrderItems.Columns[8].Name = "DK2";
            grid_salesOrderItems.Columns[8].DataPropertyName = "DK2";
            grid_salesOrderItems.Columns[8].Width = 30;

            grid_salesOrderItems.Columns[9].Name = "DcRate2";
            grid_salesOrderItems.Columns[9].DefaultCellStyle.Format = "N2";
            grid_salesOrderItems.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesOrderItems.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesOrderItems.Columns[9].DataPropertyName = "DcRate2";
            grid_salesOrderItems.Columns[9].Width = 50;

            grid_salesOrderItems.Columns[10].Name = "InCase";
            grid_salesOrderItems.Columns[10].DataPropertyName = "InCase";
            grid_salesOrderItems.Columns[10].Visible = false;

            DataGridViewCheckBoxColumn pickingCheck = new DataGridViewCheckBoxColumn();
            pickingCheck.HeaderText = "Check";
            pickingCheck.FalseValue = false;
            pickingCheck.TrueValue = true;
            pickingCheck.Name = "CheckBox";
            pickingCheck.ReadOnly = true;
            pickingCheck.Width = 50;
            grid_salesOrderItems.Columns.Insert(0, pickingCheck);
            grid_salesOrderItems.CellContentClick += new DataGridViewCellEventHandler(gridcellclick);

            if (checkbox.Checked) //cbox_replenishOnly checked
            {
                connPO.grid_salesOrderItems_Replenish(grid_salesOrderItems, VendorTraderEntityKey);
            }
            else //cbox_replenishOnly unchecked
            {
                connPO.grid_salesOrderItems_All(grid_salesOrderItems, VendorTraderEntityKey);
            }


            for (int i = 0; i < grid_salesOrderItems.RowCount; i++)
            {
                for (int j = 0; j < grid_salesOrderItems.ColumnCount; j++)
                {
                    if (grid_salesOrderItems.Rows[i].Cells[j].Value != null)
                    {
                        grid_salesOrderItems.Rows[i].Cells[j].Value = grid_salesOrderItems.Rows[i].Cells[j].Value.ToString().Trim();
                    }

                    //MessageBox.Show(grid_user.Rows[i].Cells[j].Value.ToString());
                }
            }

        }

        private void gridcellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(grid_salesOrderItems.Rows[e.RowIndex].Cells["CheckBox"].EditedFormattedValue) == true)
                {
                    grid_salesOrderItems.Rows[e.RowIndex].Cells["CheckBox"].Value = false;
                }
                else
                {
                    grid_salesOrderItems.Rows[e.RowIndex].Cells["CheckBox"].Value = true;
                }

            }
        }

        public static string[,] POArray;
        private void btn_apply_Click(object sender, EventArgs e)
        {
            int checkCount = 0;
            int count = 0;

            //declare Array
            foreach (DataGridViewRow item in grid_salesOrderItems.Rows)
            {

                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    checkCount++;
                }
            }
            //string[,] POArray = new string[checkCount, 6];
            POArray = new string[checkCount, 11];
            //MessageBox.Show(checkCount.ToString());

            //Add array
            for (int i = 0; i < grid_salesOrderItems.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_salesOrderItems.Rows[i].Cells[0].Value))
                {
                    //MessageBox.Show(count.ToString());

                    POArray[count, 0] = grid_salesOrderItems.Rows[i].Cells[1].Value.ToString().Trim(); //ProductID
                    POArray[count, 1] = grid_salesOrderItems.Rows[i].Cells[2].Value.ToString().Trim(); //POCode
                    POArray[count, 2] = grid_salesOrderItems.Rows[i].Cells[3].Value.ToString().Trim(); //OrderQty
                    POArray[count, 3] = grid_salesOrderItems.Rows[i].Cells[4].Value.ToString().Trim(); //ProductDesc
                    POArray[count, 4] = grid_salesOrderItems.Rows[i].Cells[5].Value.ToString().Trim(); //PackSize
                    POArray[count, 5] = grid_salesOrderItems.Rows[i].Cells[6].Value.ToString().Trim(); //ListPrice
                    POArray[count, 6] = grid_salesOrderItems.Rows[i].Cells[7].Value.ToString().Trim(); //DK1
                    POArray[count, 7] = grid_salesOrderItems.Rows[i].Cells[8].Value.ToString().Trim(); //DcRate1
                    POArray[count, 8] = grid_salesOrderItems.Rows[i].Cells[9].Value.ToString().Trim(); //DK2
                    POArray[count, 9] = grid_salesOrderItems.Rows[i].Cells[10].Value.ToString().Trim(); //DcRate2
                    POArray[count, 10] = grid_salesOrderItems.Rows[i].Cells[11].Value.ToString().Trim(); //InCase
                    
                    count = count + 1;
                }
            }

            //// For more extensibility.. 
            //string output = string.Empty;
            //foreach (var item in POArray)
            //{
            //    output += item + "\n";
            //}

            //MessageBox.Show(output);
            Close();
        }

        private void cbox_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_salesOrderItems.RowCount; i++)
            {
                if (cbox_SelectAll.Checked)
                {
                    grid_salesOrderItems.Rows[i].Cells["CheckBox"].Value = true;
                }
                else
                {
                    grid_salesOrderItems.Rows[i].Cells["CheckBox"].Value = false;
                }
            }
        }
        
    }
}
