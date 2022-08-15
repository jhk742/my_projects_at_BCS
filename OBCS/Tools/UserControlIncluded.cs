using OBCS.Purchase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OBCS.Tools
{
    public partial class UserControlIncluded : UserControl
    {
        public UserControlIncluded()
        {
            InitializeComponent();
            UserControlIncluded_Load();
        }
        public void days(int numday)
        {
            label_Days.Text = numday + "";
        }
        private void grid_includedPO_Init()
        {
            grid_includedPO.AutoGenerateColumns = false;
            grid_includedPO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_includedPO.ColumnCount = 5;

            grid_includedPO.Columns[0].Name = "PO #";
            grid_includedPO.Columns[0].ReadOnly = true;
            grid_includedPO.Columns[0].Width = 45;
            grid_includedPO.Columns[0].MinimumWidth = 45;
            grid_includedPO.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_includedPO.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_includedPO.Columns[0].DataPropertyName = "POHNUM_0";

            grid_includedPO.Columns[1].Name = "Brand Name";
            grid_includedPO.Columns[1].ReadOnly = true;
            grid_includedPO.Columns[1].Width = 70;
            grid_includedPO.Columns[1].MinimumWidth = 70;
            grid_includedPO.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_includedPO.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_includedPO.Columns[1].DataPropertyName = "BrandName";
            
            grid_includedPO.Columns[2].Name = "Site";
            grid_includedPO.Columns[2].ReadOnly = true;
            grid_includedPO.Columns[2].Width = 25;
            grid_includedPO.Columns[2].MinimumWidth = 25;
            grid_includedPO.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_includedPO.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_includedPO.Columns[2].DataPropertyName = "PRHFCY_0";
            
            grid_includedPO.Columns[3].Name = "Flag";
            grid_includedPO.Columns[3].Visible = false;
            grid_includedPO.Columns[3].DataPropertyName = "Flag";

            grid_includedPO.Columns[4].Name = "Supplier Name";
            grid_includedPO.Columns[4].Visible = false;
            grid_includedPO.Columns[4].DataPropertyName = "BPSNUM_0";

            foreach (DataGridViewColumn c in grid_includedPO.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_includedPO.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        } 
        private void UserControlIncluded_Load()
        {
            grid_includedPO_Init();
            String theday = customCalendar.static_year + "-" + customCalendar.static_month + "-" + customCalendar.static_day;
            DateTime THEDAY = DateTime.Parse(theday);
            connPO.sp_POCalendarREAL(grid_includedPO, THEDAY);
        }
        private void grid_includedPO_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                /* Used to be that upon double-clicking a cell, a separate winform holding the details of said-report would pop up.
                 * This functionality has been discarded and a double-click will now open the PORDER winform rpt with the corresponding PORDER loaded up (code found below commented section) 
                 
                int sday = Convert.ToInt32(label_Days.Text);
                String PONumber = grid_includedPO.Rows[e.RowIndex].Cells["PO #"].Value.ToString().Trim();
                POCalendarDetail jtd = new POCalendarDetail(PONumber, sday);
                jtd.Show();
                */
                //int sday = Convert.ToInt32(label_Days.Text);
                String PONumber = grid_includedPO.Rows[e.RowIndex].Cells["PO #"].Value.ToString().Trim();
                //POCalendarDetail jtd = new POCalendarDetail(PONumber, sday);
                //jtd.Show();

                bool active = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(PORDER))
                    {
                        active = true;
                        form.Activate();
                        //return;
                        break;
                    }
                }
                if (active == false)
                {
                    PORDER porder = new PORDER();
                    porder.Show();
                }
                
                String SupplierID = grid_includedPO.Rows[e.RowIndex].Cells["Brand Name"].Value.ToString().Trim();
                //String PONumber = grid_includedPO.Rows[e.RowIndex].Cells["PO #"].Value.ToString().Trim();
                var mainForm = Application.OpenForms.OfType<PORDER>().FirstOrDefault();
                mainForm.Activate();
                mainForm.txt_PSOrderID.Text = PONumber;
                mainForm.btn_refresh2.PerformClick();
                mainForm.cbo_supplierID.Text = SupplierID;
                mainForm.txt_poNumber.Text = PONumber;
            } catch
            {
               
            }
        }

        private void Distinguish()
        {/*
            for (int i = 0; i < grid_includedPO.RowCount; i++)
            {
                String flag = grid_includedPO.Rows[i].Cells["Flag"].Value.ToString();
                if (flag == "E")
                {
                    grid_includedPO.ClearSelection();
                    grid_includedPO.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightPink;
                    grid_includedPO.Rows[i].DefaultCellStyle.BackColor = Color.HotPink;
                } else if (flag == "C")
                {
                    grid_includedPO.ClearSelection();
                    grid_includedPO.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
                    grid_includedPO.Rows[i].DefaultCellStyle.BackColor = Color.SpringGreen;
                }
            }*/
            for (int i = 0; i < grid_includedPO.RowCount; i++)
            {
                String flag = grid_includedPO.Rows[i].Cells["Flag"].Value.ToString();
                if (flag == "E")
                {
                    grid_includedPO.ClearSelection();
                    //grid_includedPO.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightPink;
                    grid_includedPO.Rows[i].DefaultCellStyle.SelectionBackColor = Color.SlateGray;
                    grid_includedPO.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(41, 53, 65);
                }
                else if (flag == "C")
                {
                    grid_includedPO.ClearSelection();
                    //grid_includedPO.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
                    grid_includedPO.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Khaki;
                    grid_includedPO.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(245, 156, 26);
                }
            }
        }

        private void grid_includedPO_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Distinguish();
        }
    }
}
