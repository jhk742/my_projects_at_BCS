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
    public partial class PreparationPlan_original : Form
    {
        public PreparationPlan_original()
        {
            InitializeComponent();

            btn_save.Enabled = false;
            btn_create.Enabled = false;
            btn_cancel.Enabled = false;

            btn_selectOrders.Enabled = true;
            btn_saveRouteOrders.Enabled = false;
            btn_deleteRouteOrders.Enabled = false;
            btn_updateStopNo.Enabled = false;
            btn_createPrepPlan.Enabled = false;


            //driver cbo loading
            connSalesOrder.cbo_drivers(cbo_drivers);

            //truck cbo loadking
            connSalesOrder.cbo_trucks(cbo_trucks);

            grid_RTTMPH_Init();
            grid_RTTMPD_Init();


            grid_RTTMPD.AllowDrop = true;
            grid_RTTMPD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_RTTMPD.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //grid_RTTMPD.AllowUserToAddRows = true;

        }

        private void grid_RTTMPH_Init()
        {
            grid_RTTMPH.AutoGenerateColumns = false;

            grid_RTTMPH.ColumnCount = 7;

            grid_RTTMPH.Columns[0].Name = "RTN";
            grid_RTTMPH.Columns[0].ReadOnly = true;
            grid_RTTMPH.Columns[0].Width = 50;
            grid_RTTMPH.Columns[0].DataPropertyName = "TEMPNO";

            grid_RTTMPH.Columns[1].Name = "Driver";
            grid_RTTMPH.Columns[1].ReadOnly = true;
            grid_RTTMPH.Columns[1].Width = 150;
            grid_RTTMPH.Columns[1].DataPropertyName = "DRIVER";

            grid_RTTMPH.Columns[2].Name = "Truck";
            grid_RTTMPH.Columns[2].ReadOnly = true;
            grid_RTTMPH.Columns[2].Width = 120;
            grid_RTTMPH.Columns[2].DataPropertyName = "PLATENO";

            grid_RTTMPH.Columns[3].Name = "Plan No.";
            grid_RTTMPH.Columns[3].ReadOnly = true;
            grid_RTTMPH.Columns[3].Width = 80;
            grid_RTTMPH.Columns[3].DataPropertyName = "PRLNUM";

            grid_RTTMPH.Columns[4].Name = "CRS";
            grid_RTTMPH.Columns[4].ReadOnly = true;
            grid_RTTMPH.Columns[4].Width = 35;
            grid_RTTMPH.Columns[4].DataPropertyName = "TOTCRS";
            
            DataGridViewCheckBoxColumn pickingCheck = new DataGridViewCheckBoxColumn();
            pickingCheck.HeaderText = "F";
            pickingCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            pickingCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            pickingCheck.FalseValue = false;
            pickingCheck.TrueValue = true;
            pickingCheck.Name = "CheckBox";
            pickingCheck.ReadOnly = true;
            pickingCheck.Width = 30;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_RTTMPH.Columns.Insert(5, pickingCheck);
            grid_RTTMPH.CellContentClick += new DataGridViewCellEventHandler(gridcellclick);

            grid_RTTMPH.Columns[6].Name = "P";
            grid_RTTMPH.Columns[6].Width = 30;
            grid_RTTMPH.Columns[6].DataPropertyName = "PICKUP";

            grid_RTTMPH.Columns[7].Name = "Finish";
            grid_RTTMPH.Columns[7].Visible = false;
            grid_RTTMPH.Columns[7].DataPropertyName = "FLGDLVPRN";


            //grid font size custom
            grid_RTTMPH.RowTemplate.Height = 20;
            grid_RTTMPH.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_RTTMPH.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            
            grid_RTTMPH.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_RTTMPD_Init()
        {
            grid_RTTMPD.AutoGenerateColumns = false;

            grid_RTTMPD.ColumnCount = 14;

            grid_RTTMPD.Columns[0].Name = "No.";
            grid_RTTMPD.Columns[0].ReadOnly = true;
            grid_RTTMPD.Columns[0].Width = 30;
            grid_RTTMPD.Columns[0].DataPropertyName = "";

            grid_RTTMPD.Columns[1].Name = "Stop";
            grid_RTTMPD.Columns[1].ReadOnly = true;
            grid_RTTMPD.Columns[1].Width = 35;
            grid_RTTMPD.Columns[1].DataPropertyName = "MDL_0";
            
            grid_RTTMPD.Columns[2].Name = "Address";
            grid_RTTMPD.Columns[2].ReadOnly = true;
            grid_RTTMPD.Columns[2].Width = 350;
            grid_RTTMPD.Columns[2].DataPropertyName = "BPDADDLIG_0";

            grid_RTTMPD.Columns[3].Name = "ZIP";
            grid_RTTMPD.Columns[3].ReadOnly = true;
            grid_RTTMPD.Columns[3].Width = 50;
            grid_RTTMPD.Columns[3].DataPropertyName = "BPDPOSCOD_0";

            grid_RTTMPD.Columns[4].Name = "Ord. Amount";
            grid_RTTMPD.Columns[4].ReadOnly = true;
            grid_RTTMPD.Columns[4].Width = 70;
            grid_RTTMPD.Columns[4].DefaultCellStyle.Format = "N2";
            grid_RTTMPD.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_RTTMPD.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_RTTMPD.Columns[4].DataPropertyName = "ORDNOT_0";
            
            grid_RTTMPD.Columns[5].Name = "Order No.";
            grid_RTTMPD.Columns[5].Width = 100;
            grid_RTTMPD.Columns[5].DataPropertyName = "SOHNUM_0";

            grid_RTTMPD.Columns[6].Name = "Delv. No";
            grid_RTTMPD.Columns[6].Width = 100;
            grid_RTTMPD.Columns[6].DataPropertyName = "LASDLVNUM_0";

            grid_RTTMPD.Columns[7].Name = "Order Date";
            grid_RTTMPD.Columns[7].Width = 80;
            grid_RTTMPD.Columns[7].DataPropertyName = "ORDDAT_0";

            grid_RTTMPD.Columns[8].Name = "Customer";
            grid_RTTMPD.Columns[8].Width = 100;
            grid_RTTMPD.Columns[8].DataPropertyName = "BPCORD_0";

            grid_RTTMPD.Columns[9].Name = "Rep.";
            grid_RTTMPD.Columns[9].Width = 50;
            grid_RTTMPD.Columns[9].DataPropertyName = "REP_0";

            grid_RTTMPD.Columns[10].Name = "Pick Ticket";
            grid_RTTMPD.Columns[10].Width = 50;
            grid_RTTMPD.Columns[10].DataPropertyName = "";

            grid_RTTMPD.Columns[11].Name = "Dept.";
            grid_RTTMPD.Columns[11].Width = 100;
            grid_RTTMPD.Columns[11].DataPropertyName = "FLGDLVPRN";

            grid_RTTMPD.Columns[12].Name = "Memo";
            grid_RTTMPD.Columns[12].Visible = false;
            grid_RTTMPD.Columns[12].Width = 100;
            grid_RTTMPD.Columns[12].DataPropertyName = "YORDREF_0";

            grid_RTTMPD.Columns[13].Name = "Memo2";
            grid_RTTMPD.Columns[13].Visible = false;
            grid_RTTMPD.Columns[13].Width = 100;
            grid_RTTMPD.Columns[13].DataPropertyName = "BPDADDLIG_1";

            //grid font size custom
            grid_RTTMPD.RowTemplate.Height = 20;
            grid_RTTMPD.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_RTTMPD.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_RTTMPD.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void gridcellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(grid_RTTMPH.Rows[e.RowIndex].Cells["CheckBox"].EditedFormattedValue) == true)
                {
                    grid_RTTMPH.Rows[e.RowIndex].Cells["CheckBox"].Value = false;

                }
                else
                {
                    grid_RTTMPH.Rows[e.RowIndex].Cells["CheckBox"].Value = true;
                }

            }
        }


        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh_header();
        }

        private void refresh_header()
        {
            connSalesOrder.list_RTTMPH(grid_RTTMPH, dateTimePicker_routingDate);

            foreach (DataGridViewRow item in grid_RTTMPH.Rows)
            {
                if (item.Cells["Finish"].Value.ToString().Trim() == "Y")
                {
                    item.Cells["CheckBox"].Value = true;
                }
            }
            grid_RTTMPD.DataSource = null;
            grid_RTTMPH.ClearSelection();
        }
        int tempNo;
        private void grid_RTTMPH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tempNo = Convert.ToInt32(grid_RTTMPH.Rows[e.RowIndex].Cells["RTN"].Value);
            string prlNum = grid_RTTMPH.Rows[e.RowIndex].Cells["Plan No."].Value.ToString();

            i = 0;

            connSalesOrder.list_RTTMPD(grid_RTTMPD, tempNo, prlNum);
            //DataTable dt = connSalesOrder.list_RTTMPD2(tempNo, prlNum);

            
            //Total Amount
            Decimal Amount = 0;
            for (int i = 0; i < grid_RTTMPD.Rows.Count; i++)
            {
                Amount += Convert.ToDecimal(grid_RTTMPD.Rows[i].Cells["Ord. Amount"].Value);
                //MessageBox.Show(grid_RTTMPD.Rows[i].Cells["Memo"].Value.ToString());

                if (grid_RTTMPD.Rows[i].Cells["Memo"].Value != null && grid_RTTMPD.Rows[i].Cells["Memo"].Value.ToString().Trim() !="")
                {
                    string memo = grid_RTTMPD.Rows[i].Cells["Memo"].Value.ToString().Trim();
                    string memo2 = grid_RTTMPD.Rows[i].Cells["Memo2"].Value.ToString().Trim();
                    memo.Replace(Environment.NewLine, " ");
                    if (memo2 != "")
                    {
                        grid_RTTMPD.Rows[i].Cells["Address"].Value = grid_RTTMPD.Rows[i].Cells["Address"].Value.ToString() + Environment.NewLine + "****** : " + memo + "~[" + memo2 + "]";
                    }
                    else
                    {
                        grid_RTTMPD.Rows[i].Cells["Address"].Value = grid_RTTMPD.Rows[i].Cells["Address"].Value.ToString() + Environment.NewLine + "****** : " + memo;
                    }
                }
            }
            txt_amount.Text = Amount.ToString("C");

        }

        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        private void grid_RTTMPD_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = grid_RTTMPD.DoDragDrop(
                    grid_RTTMPD.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void grid_RTTMPD_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = grid_RTTMPD.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;


            //DataGridView.HitTestInfo info = this.grid_RTTMPD.HitTest(e.X, e.Y);
            //if (info.RowIndex != -1 && info.ColumnIndex != -1)
            //{
            //    Object value = this.grid_RTTMPD.Rows[info.RowIndex].Cells[info.ColumnIndex].Value;
            //    if (value != null)
            //    {
            //        this.grid_RTTMPD.Rows[info.RowIndex].Cells[info.ColumnIndex].Value = this.grid_RTTMPD.Rows[info.RowIndex].Cells[info.ColumnIndex].Value;
            //        this.DoDragDrop(value, DragDropEffects.Move);
            //    }
            //}
        }

        private void grid_RTTMPD_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        int i = 0;
        private void grid_RTTMPD_DragDrop(object sender, DragEventArgs e)
        {
            
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = grid_RTTMPD.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                grid_RTTMPD.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(
                    typeof(DataGridViewRow)) as DataGridViewRow;
                //grid_RTTMPD.Rows.RemoveAt(rowIndexFromMouseDown);
                //grid_RTTMPD.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
                DataTable dt = this.grid_RTTMPD.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr.ItemArray = dt.Rows[rowIndexFromMouseDown].ItemArray.Clone() as object[];
                //MessageBox.Show(rowToMove.Cells[2].Value.ToString());
                dt.Rows.RemoveAt(rowIndexFromMouseDown);
                dt.Rows.InsertAt(dr, rowIndexOfItemUnderMouseToDrop);
            }

            i++;

            for (int i = 0; i < grid_RTTMPD.RowCount; i++)
            {
                int j = i + 1;
                grid_RTTMPD.Rows[i].Cells["STOP"].Value = "S" + j.ToString("D2");
            }

            
            //Point p = this.grid_RTTMPD.PointToClient(new Point(e.X, e.Y));
            //DataGridView.HitTestInfo info = this.grid_RTTMPD.HitTest(p.X, p.Y);
            //if (info.RowIndex != -1 && info.ColumnIndex != -1)
            //{
            //    Object value = (Object)e.Data.GetData(typeof(string));
            //    this.grid_RTTMPD.Rows[info.RowIndex].Cells[info.ColumnIndex].Value = value;
            //}
        }
        

        private void grid_RTTMPD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grid_RTTMPD_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
            //번호매기기
            this.grid_RTTMPD.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString("D2");

            //if (i > 0)
            //{
            //    this.grid_RTTMPD.Rows[e.RowIndex].Cells[1].Value = "S" + (e.RowIndex + 1).ToString("D2");
            //}
            
            
        }

        private void btn_saveRouteOrders_Click(object sender, EventArgs e)
        {
            //delete
            connSalesOrder.ZRT_RTTMPD_DELETE_TEMPNO(tempNo);

            //cuid insert
            for (int i = 0; i < grid_RTTMPD.RowCount; i++)
            {
                int ACTION = tempNo;
                String MDL = grid_RTTMPD.Rows[i].Cells["Stop"].Value.ToString().Trim();
                String SOHNUM = grid_RTTMPD.Rows[i].Cells["Order No."].Value.ToString().Trim();
                String BPCNUM = grid_RTTMPD.Rows[i].Cells["Customer"].Value.ToString().Trim();

                connSalesOrder.ZRT_RTTMPD_CRUD("INSERT", ACTION, MDL, SOHNUM, BPCNUM);
            }

            //Save finished
            MessageBox.Show("The Route " + tempNo + " has been Saved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            btn_new.Enabled = false;
            btn_save.Enabled = false;
            btn_create.Enabled = true;
            btn_cancel.Enabled = true;

            btn_selectOrders.Enabled = false;
            btn_saveRouteOrders.Enabled = false;
            btn_deleteRouteOrders.Enabled = false; //-----> DELETE ROUTE ORDERS 
            btn_createPrepPlan.Enabled = false; //-----> CREATE PREP PLAN
            btn_updateStopNo.Enabled = false; //-----> UPDATE STOP NO (MDL)
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (cbo_drivers.Text == "" || cbo_trucks.Text == "")
            {
                MessageBox.Show("Select Driver and Truck.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            String ZDRID = connSalesOrder.getZDRID(cbo_drivers.Text);
            String ZTRID = connSalesOrder.getZTRID(cbo_trucks.Text);
            String PICKUP;
            DateTime ROUTEDATE = dateTimePicker_routingDate.Value;
            
            if (cbox_vendor.Checked)
            {
                PICKUP = "Y";
            }
            else
            {
                PICKUP = "N";
            }
            
            //ZRT_RTTMPH_INSERT
            connSalesOrder.ZRT_RTTMPH_INSERT(ZDRID, ZTRID, ROUTEDATE, PICKUP);

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_new.Enabled = true;
            btn_create.Enabled = false;
            btn_cancel.Enabled = false;
        }

        private void btn_selectOrders_Click(object sender, EventArgs e)
        {
            PreparationOrders_original preparationOrders = new PreparationOrders_original();
            preparationOrders.MdiParent = this.MdiParent;
            preparationOrders.ShowDialog();

            try
            {
                int Rows = PreparationOrders_original.OrdersArray.GetLength(0);
                int Columns = PreparationOrders_original.OrdersArray.GetLength(1);

                for (int i = 0; i < Rows; i++)
                {

                    String Stop = PreparationOrders_original.OrdersArray[i, 0];
                    String Address = PreparationOrders_original.OrdersArray[i, 1];
                    String City = PreparationOrders_original.OrdersArray[i, 2];
                    String State = PreparationOrders_original.OrdersArray[i, 3];
                    String Zip = PreparationOrders_original.OrdersArray[i, 4];
                    String OrdAmount = PreparationOrders_original.OrdersArray[i, 5];
                    String OrderNo = PreparationOrders_original.OrdersArray[i, 6];
                    String OrderDate = PreparationOrders_original.OrdersArray[i, 7];
                    String Customer = PreparationOrders_original.OrdersArray[i, 8];
                    String Rep = PreparationOrders_original.OrdersArray[i, 9];
                    String Memo = PreparationOrders_original.OrdersArray[i, 10];
                    String Memo2 = PreparationOrders_original.OrdersArray[i, 11];

                    String Address1 = Address + ", " + City + " " + State;



                    //grid_RTTMPD.Rows.Add("", Stop, Address1, Zip, OrdAmount, OrderNo, "", OrderDate, Customer, Rep, "N/A", "", Memo, Memo2);

                    //DataTable dt = grid_RTTMPD.DataSource as DataTable;
                    //Create the new row
                    //DataRow row = dt.Rows.Add("", Stop, Address1, Zip, OrdAmount, OrderNo, "", OrderDate, Customer, Rep, "N/A", "", Memo, Memo2);
                    //Populate the row with data

                    //Add the row to data table
                    //dt.Rows.Add(row);

                    //grid_RTTMPD.Rows.RemoveAt(rowIndexFromMouseDown);
                    //grid_RTTMPD.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
                    
                    DataTable dt = this.grid_RTTMPD.DataSource as DataTable;
                    DataRow dr = dt.NewRow();

                    dr["No."] = "";
                    dr["Stop"] = Stop;
                    dr["Address"] = Address1;
                    dr["Zip"] = Zip;
                    dr["Ord. Amount"] = OrdAmount;
                    dr["Order No."] = OrderNo;
                    dr["Delv. No."] = "";
                    dr["Order Date"] = OrderDate;
                    dr["Customer"] = Customer;
                    dr["Rep."] = Rep;
                    dr["Pick Ticket"] = "";
                    dr["Dept."] = "";
                    dr["Memo"] = Memo;
                    dr["Memo2"] = Memo2;
                    //MessageBox.Show(dr[2].ToString());

                    //dr.ItemArray = dt.Rows[grid_RTTMPD.ColumnCount+1].ItemArray.Clone() as object[];
                    //MessageBox.Show(rowToMove.Cells[2].Value.ToString());
                    //dt.Rows.Add("", Stop, Address1, Zip, OrdAmount, OrderNo, "", OrderDate, Customer, Rep, "N/A", "", Memo, Memo2);
                    //dt.Rows.InsertAt(dr, 0);
                    dt.Rows.Add(dr);

                    //grid_RTTMPD.DataSource = dt;

                }
            }
            catch
            {

            }

        }
    }
}
