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
    public partial class PreparationOrders_original : Form
    {
        public PreparationOrders_original()
        {
            InitializeComponent();



            grid_ORDERS_Init();

            grid_ORDERS.AllowDrop = true;
            grid_ORDERS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_ORDERS.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            connSalesOrder.ZRT_GET_ALLORDERS_NOT_PREPLN_V2(grid_ORDERS, "");


            //Total Amount
            Decimal Amount = 0;
            Decimal Weight = 0;
            for (int i = 0; i < grid_ORDERS.Rows.Count; i++)
            {
                Amount += Convert.ToDecimal(grid_ORDERS.Rows[i].Cells["Amount"].Value);
                Weight += Convert.ToDecimal(grid_ORDERS.Rows[i].Cells["Weight"].Value);


                if (grid_ORDERS.Rows[i].Cells["Memo"].Value != null && grid_ORDERS.Rows[i].Cells["Memo"].Value.ToString().Trim() != "")
                {
                    string memo = grid_ORDERS.Rows[i].Cells["Memo"].Value.ToString().Trim();
                    string memo2 = grid_ORDERS.Rows[i].Cells["Memo2"].Value.ToString().Trim();
                    memo.Replace(Environment.NewLine, " ");
                    if (memo2 != "")
                    {
                        grid_ORDERS.Rows[i].Cells["Address"].Value = grid_ORDERS.Rows[i].Cells["Address"].Value.ToString() + Environment.NewLine + "****** : " + memo + "~[" + memo2 + "]";
                    }
                    else
                    {
                        grid_ORDERS.Rows[i].Cells["Address"].Value = grid_ORDERS.Rows[i].Cells["Address"].Value.ToString() + Environment.NewLine + "****** : " + memo;
                    }
                }
            }
            txt_amount.Text = Amount.ToString("C");
            txt_weight.Text = Weight.ToString("N2");
        }

        private void grid_ORDERS_Init()
        {
            grid_ORDERS.AutoGenerateColumns = false;

            grid_ORDERS.ColumnCount = 15;

            grid_ORDERS.Columns[0].Name = "No.";
            grid_ORDERS.Columns[0].ReadOnly = true;
            grid_ORDERS.Columns[0].Width = 30;
            grid_ORDERS.Columns[0].DataPropertyName = "";

            grid_ORDERS.Columns[1].Name = "ZIP";
            grid_ORDERS.Columns[1].ReadOnly = true;
            grid_ORDERS.Columns[1].Width = 50;
            grid_ORDERS.Columns[1].DataPropertyName = "BPDPOSCOD_0";

            grid_ORDERS.Columns[2].Name = "Customer";
            grid_ORDERS.Columns[2].ReadOnly = true;
            grid_ORDERS.Columns[2].Width = 120;
            grid_ORDERS.Columns[2].DataPropertyName = "BPCORD_0";


            DataGridViewCheckBoxColumn pickingCheck = new DataGridViewCheckBoxColumn();
            pickingCheck.HeaderText = "X";
            pickingCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            pickingCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            pickingCheck.FalseValue = false;
            pickingCheck.TrueValue = true;
            pickingCheck.Name = "CheckBox";
            pickingCheck.ReadOnly = true;
            pickingCheck.Width = 30;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_ORDERS.Columns.Insert(3, pickingCheck);
            grid_ORDERS.CellContentClick += new DataGridViewCellEventHandler(gridcellclick);

            //grid_ORDERS.Columns[3].Name = "X";
 

            grid_ORDERS.Columns[4].Name = "Address";
            grid_ORDERS.Columns[4].ReadOnly = true;
            grid_ORDERS.Columns[4].Width = 400;
            grid_ORDERS.Columns[4].DataPropertyName = "BPDADDLIG_0";

            grid_ORDERS.Columns[5].Name = "City";
            grid_ORDERS.Columns[5].Width = 100;
            grid_ORDERS.Columns[5].DataPropertyName = "BPDCTY_0";

            grid_ORDERS.Columns[6].Name = "State";
            grid_ORDERS.Columns[6].Width = 50;
            grid_ORDERS.Columns[6].DataPropertyName = "BPDSAT_0";

            grid_ORDERS.Columns[7].Name = "REP";
            grid_ORDERS.Columns[7].Width = 50;
            grid_ORDERS.Columns[7].DataPropertyName = "REP_0";

            grid_ORDERS.Columns[8].Name = "Order Date";
            grid_ORDERS.Columns[8].Width = 80;
            grid_ORDERS.Columns[8].DataPropertyName = "ORDDAT_0";

            grid_ORDERS.Columns[9].Name = "Order No.";
            grid_ORDERS.Columns[9].Width = 100;
            grid_ORDERS.Columns[9].DataPropertyName = "SOHNUM_0";

            grid_ORDERS.Columns[10].Name = "Weight";
            grid_ORDERS.Columns[10].Width = 60;
            grid_ORDERS.Columns[10].DefaultCellStyle.Format = "N2";
            grid_ORDERS.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDERS.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDERS.Columns[10].DataPropertyName = "TOTAL_LINWEI";

            grid_ORDERS.Columns[11].Name = "Amount";
            grid_ORDERS.Columns[11].Width = 80;
            grid_ORDERS.Columns[11].DefaultCellStyle.Format = "N2";
            grid_ORDERS.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDERS.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_ORDERS.Columns[11].DataPropertyName = "ORDNOT_0";

            grid_ORDERS.Columns[12].Name = "Stop";
            grid_ORDERS.Columns[12].Width = 60;
            grid_ORDERS.Columns[12].DataPropertyName = "MDL_0";

            grid_ORDERS.Columns[13].Name = "Route";
            grid_ORDERS.Columns[13].Width = 100;
            grid_ORDERS.Columns[13].DataPropertyName = "LANMES_0";

            grid_ORDERS.Columns[14].Name = "Memo";
            grid_ORDERS.Columns[14].Visible = false;
            grid_ORDERS.Columns[14].Width = 100;
            grid_ORDERS.Columns[14].DataPropertyName = "YORDREF_0";

            grid_ORDERS.Columns[15].Name = "Memo2";
            grid_ORDERS.Columns[15].Visible = false;
            grid_ORDERS.Columns[15].Width = 100;
            grid_ORDERS.Columns[15].DataPropertyName = "BPDADDLIG_1";

            //grid font size custom
            grid_ORDERS.RowTemplate.Height = 20;
            grid_ORDERS.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_ORDERS.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_ORDERS.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void gridcellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (Convert.ToBoolean(grid_ORDERS.Rows[e.RowIndex].Cells["CheckBox"].EditedFormattedValue) == true)
                {
                    grid_ORDERS.Rows[e.RowIndex].Cells["CheckBox"].Value = false;

                }
                else
                {
                    grid_ORDERS.Rows[e.RowIndex].Cells["CheckBox"].Value = true;
                }

            }
        }

        private void grid_ORDERS_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //번호매기기
            this.grid_ORDERS.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString("D2");
        }

        public static string[,] OrdersArray;
        private void btn_addToRoutePlan_Click(object sender, EventArgs e)
        {
            int checkCount = 0;
            int count = 0;

            //declare Array
            foreach (DataGridViewRow item in grid_ORDERS.Rows)
            {

                if (Convert.ToBoolean(item.Cells[3].Value))
                {
                    checkCount++;
                }
            }
            //string[,] POArray = new string[checkCount, 6];
            OrdersArray = new string[checkCount, 13];
            //MessageBox.Show(checkCount.ToString());

            //Add array
            for (int i = 0; i < grid_ORDERS.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_ORDERS.Rows[i].Cells[3].Value))
                {
                    //MessageBox.Show(count.ToString());

                    OrdersArray[count, 0] = grid_ORDERS.Rows[i].Cells[12].Value.ToString().Trim(); //STOP
                    OrdersArray[count, 1] = grid_ORDERS.Rows[i].Cells[4].Value.ToString().Trim(); //ADDRESS
                    OrdersArray[count, 2] = grid_ORDERS.Rows[i].Cells[5].Value.ToString().Trim(); //CITY
                    OrdersArray[count, 3] = grid_ORDERS.Rows[i].Cells[6].Value.ToString().Trim(); //STATE
                    OrdersArray[count, 4] = grid_ORDERS.Rows[i].Cells[1].Value.ToString().Trim(); //ZIP
                    OrdersArray[count, 5] = grid_ORDERS.Rows[i].Cells[11].Value.ToString().Trim(); //Order Amount
                    OrdersArray[count, 6] = grid_ORDERS.Rows[i].Cells[9].Value.ToString().Trim(); //OrderNo
                    OrdersArray[count, 7] = grid_ORDERS.Rows[i].Cells[8].Value.ToString().Trim(); //OrderDate
                    OrdersArray[count, 8] = grid_ORDERS.Rows[i].Cells[2].Value.ToString().Trim(); //Customer
                    OrdersArray[count, 9] = grid_ORDERS.Rows[i].Cells[7].Value.ToString().Trim(); //Rep
                    OrdersArray[count, 10] = grid_ORDERS.Rows[i].Cells[14].Value.ToString().Trim(); //Memo
                    OrdersArray[count, 11] = grid_ORDERS.Rows[i].Cells[15].Value.ToString().Trim(); //Memo2
                    
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
