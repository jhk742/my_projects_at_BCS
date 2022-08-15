using OBCS.Entities;
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
    public partial class EmployeeDetail : Form
    {

        public EmployeeDetail(String TraderEntityKey)
        {
            InitializeComponent();

            


            Employee employee = new Employee();
            employee = connEmployee.sp_Fetch_EmployeeDetail(TraderEntityKey);

            cbo_department.Items.Clear();
            cbo_title.Items.Clear();
            cbo_branch.Items.Clear();
            connEmployee.cbo_department(cbo_department);
            connEmployee.cbo_title(cbo_title);
            connEmployee.cbo_branch(cbo_branch);

            txt_employeeID.Text = employee.EmployeeID;
            txt_firstName.Text = employee.FirstName;
            txt_lastName.Text = employee.LastName;
            txt_aidName.Text = employee.AidName;
            cbo_department.Text = employee.DepartmentName;
            cbo_title.Text = employee.TitleName;
            txt_htel.Text = employee.PhoneHome;
            txt_hireDate.Text = employee.HireDate.ToString();
            txt_dob.Text = employee.DOB.ToString();
            txt_memo.Text = employee.Memo;
            txt_mobile.Text = employee.PhoneMobile;
            cbo_branch.Text = employee.BranchName;
            txt_driverID.Text = employee.DriverID;
            txt_lastDate.Text = employee.LastDate.ToString();
            txt_ssno.Text = employee.SSNo;
            if(employee.IsActive ==true)
            {
                cbox_inactive.Checked = true;
            }
            else
            {
                cbox_inactive.Checked = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
