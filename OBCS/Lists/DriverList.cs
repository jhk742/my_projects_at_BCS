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
    public partial class DriverList : Form
    {
        public DriverList()
        {
            InitializeComponent();
            grid_driver_Init();

            connSalesOrder.sp_LIST_DRIVER(grid_driver);

        }


        private void grid_driver_Init()
        {
            grid_driver.AutoGenerateColumns = false;
            grid_driver.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_driver.ColumnCount = 3;

            grid_driver.Columns[0].Name = "Driver ID";
            grid_driver.Columns[0].ReadOnly = true;
            grid_driver.Columns[0].Width = 70;
            grid_driver.Columns[0].MinimumWidth = 70;
            grid_driver.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_driver.Columns[0].DataPropertyName = "id";

            grid_driver.Columns[1].Name = "Driver Name";
            grid_driver.Columns[1].ReadOnly = true;
            grid_driver.Columns[1].Width = 250;
            grid_driver.Columns[1].MinimumWidth = 250;
            grid_driver.Columns[1].DataPropertyName = "driver";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 50;
            
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_driver.Columns["Delete"] == null)
            {
                grid_driver.Columns.Insert(2, deleteButton);
            }
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            grid_driver.Columns[3].Name = "Active";
            grid_driver.Columns[3].Visible = false;
            grid_driver.Columns[3].Width = 80;
            grid_driver.Columns[3].MinimumWidth = 80;
            grid_driver.Columns[3].DataPropertyName = "active";
            
            //grid font size custom
            grid_driver.RowTemplate.Height = 20;
            grid_driver.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_driver.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_driver.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_driver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0) // Delete button
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure deleting driver from driver list?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    String id = grid_driver.Rows[e.RowIndex].Cells["Driver ID"].Value.ToString().Trim();
                    connSalesOrder.sp_LIST_DRIVER_DELETE(id);

                    //DataTable dt = this.grid_driver.DataSource as DataTable;
                    //DataRow dr = dt.NewRow();
                    //dt.Rows.RemoveAt(e.RowIndex);
                    connSalesOrder.sp_LIST_DRIVER(grid_driver);
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_driver.Text.Trim() == "")
            {
                MessageBox.Show("Please insert driver name."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure adding driver?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                String DriverName = txt_driver.Text.Trim();
                connSalesOrder.sp_LIST_DRIVER_NEW(DriverName);
                
                connSalesOrder.sp_LIST_DRIVER(grid_driver);
            }
            else if (dialogResult == DialogResult.No)
            {

            }

            
        }
        
    }
}
