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
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
            grid_employeeList_Init();
        }

        private void grid_employeeList_Init()
        {
            grid_employeeList.AutoGenerateColumns = false;

            grid_employeeList.ColumnCount = 10;

            grid_employeeList.Columns[0].Name = "Branch";
            grid_employeeList.Columns[0].ReadOnly = true;
            grid_employeeList.Columns[0].Width = 50;
            grid_employeeList.Columns[0].DataPropertyName = "CdBranchCode";

            grid_employeeList.Columns[1].Name = "Emp ID";
            grid_employeeList.Columns[1].ReadOnly = true;
            grid_employeeList.Columns[1].Width = 80;
            grid_employeeList.Columns[1].DataPropertyName = "EmployeeID";

            grid_employeeList.Columns[2].Name = "First Name";
            grid_employeeList.Columns[2].ReadOnly = true;
            grid_employeeList.Columns[2].Width = 160;
            grid_employeeList.Columns[2].DataPropertyName = "FirstName";

            grid_employeeList.Columns[3].Name = "Last Name";
            grid_employeeList.Columns[3].ReadOnly = true;
            grid_employeeList.Columns[3].Width = 160;
            grid_employeeList.Columns[3].DataPropertyName = "LastName";

            grid_employeeList.Columns[4].Name = "Aid Name";
            grid_employeeList.Columns[4].ReadOnly = true;
            grid_employeeList.Columns[4].Width = 170;
            grid_employeeList.Columns[4].DataPropertyName = "AidName";

            grid_employeeList.Columns[5].Name = "Phone Mobile";
            grid_employeeList.Columns[5].ReadOnly = true;
            grid_employeeList.Columns[5].Width = 170;
            grid_employeeList.Columns[5].DataPropertyName = "PhoneMobile";

            grid_employeeList.Columns[6].Name = "Department";
            grid_employeeList.Columns[6].ReadOnly = true;
            grid_employeeList.Columns[6].Width = 180;
            grid_employeeList.Columns[6].DataPropertyName = "DepartmentName";

            grid_employeeList.Columns[7].Name = "Title";
            grid_employeeList.Columns[7].ReadOnly = true;
            grid_employeeList.Columns[7].Width = 180;
            grid_employeeList.Columns[7].DataPropertyName = "TitleName";

            grid_employeeList.Columns[8].Name = "IsActive";
            grid_employeeList.Columns[8].Visible = false;
            grid_employeeList.Columns[8].DataPropertyName = "IsActive";

            grid_employeeList.Columns[9].Name = "TraderEntityKey";
            grid_employeeList.Columns[9].Visible = false;
            grid_employeeList.Columns[9].DataPropertyName = "TraderEntityKey";


            //grid font size custom
            grid_employeeList.RowTemplate.Height = 20;

            foreach (DataGridViewColumn c in grid_employeeList.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Regular);
            }
            grid_employeeList.ColumnHeadersHeight = 30;
            grid_employeeList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Regular);

        }

        private void txt_employee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string isinactive;
                if(cbox_isInactive.Checked)
                {
                    isinactive = "1";
                }
                else
                {
                    isinactive = "0";
                }

                connPO.sp_Fetch_Employee(grid_employeeList, isinactive, txt_employee.Text.ToString().Trim());
                


                for (int i = 0; i < grid_employeeList.RowCount; i++)
                {

                    String IsActive = grid_employeeList.Rows[i].Cells["IsActive"].Value.ToString().Trim();
                    //MessageBox.Show(IsActive);
                    if (IsActive == "True")
                    {
                        grid_employeeList.Rows[i].DefaultCellStyle.BackColor = Color.DarkGray;
                    }

                }

            }
        }

        private void grid_employeeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String TraderEntityKey = grid_employeeList.Rows[e.RowIndex].Cells["TraderEntityKey"].Value.ToString().Trim();

            EmployeeDetail employeeDetail = new EmployeeDetail(TraderEntityKey);
            employeeDetail.MdiParent = this.MdiParent;
            employeeDetail.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isinactive;
            if (cbox_isInactive.Checked)
            {
                isinactive = "1";
            }
            else
            {
                isinactive = "0";
            }

            connPO.sp_Fetch_Employee(grid_employeeList, isinactive, txt_employee.Text.ToString().Trim());



            for (int i = 0; i < grid_employeeList.RowCount; i++)
            {
                String IsActive = grid_employeeList.Rows[i].Cells["IsActive"].Value.ToString().Trim();
                //MessageBox.Show(IsActive);
                if (IsActive == "True")
                {
                    grid_employeeList.Rows[i].DefaultCellStyle.BackColor = Color.DarkGray;
                }
            }
        }
    }
}
