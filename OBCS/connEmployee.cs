using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.Entity;
using OBCS.Entities;

namespace OBCS
{
    class connEmployee
    {

        public static SqlConnection connection = new SqlConnection(@"Data Source=192.168.1.46;Initial Catalog=CoreXDB;User ID=sa;Password=BcsKing3355!");
        public static SqlConnection connection2 = new SqlConnection(@"Data Source=192.168.1.46;Initial Catalog=CoreXDB;User ID=sa;Password=BcsKing3355!");
        public static SqlConnection connection3 = new SqlConnection(@"Data Source=192.168.1.46;Initial Catalog=CoreXDB;User ID=sa;Password=BcsKing3355!");

        //public static SqlConnection connection = new SqlConnection(@"Data Source=192.168.1.227;Initial Catalog=CoreLinkDB2013;User ID=sa;Password=bcsroyal##55");
        //public static SqlConnection connection2 = new SqlConnection(@"Data Source=192.168.1.227;Initial Catalog=CoreLinkDB2013;User ID=sa;Password=bcsroyal##55");
        //public static SqlConnection connection3 = new SqlConnection(@"Data Source=192.168.1.227;Initial Catalog=CoreLinkDB2013;User ID=sa;Password=bcsroyal##55");

        //Employee employee = new Employee();

        static public Employee sp_Fetch_EmployeeDetail(String TraderEntityKey)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_EmployeeDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@TraderEntityKey", SqlDbType.VarChar);

                cmd.Parameters["@TraderEntityKey"].Value = TraderEntityKey;

                connection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                Employee employee = new Employee();

                if (sqlDataReader.Read())
                {
                    employee.TraderEntityKey = Convert.ToInt32(TraderEntityKey);
                    employee.EmployeeID = sqlDataReader["EmployeeID"].ToString().Trim();
                    employee.CdBranchCode = sqlDataReader["CdBranchCode"].ToString().Trim();
                    employee.DepartmentKey = Convert.ToInt32(sqlDataReader["DepartmentKey"].ToString().Trim());
                    employee.TitleKey = Convert.ToInt32(sqlDataReader["TitleKey"].ToString().Trim());
                    employee.IsActive = Convert.ToBoolean(sqlDataReader["IsActive"].ToString().Trim());
                    employee.FirstName = sqlDataReader["FirstName"].ToString().Trim() ?? "";
                    employee.LastName = sqlDataReader["LastName"].ToString().Trim() ?? "";
                    employee.AidName = sqlDataReader["AidName"].ToString().Trim() ?? "";
                    employee.DriverID = sqlDataReader["DriverID"].ToString().Trim() ?? "";
                    employee.SSNo = sqlDataReader["SSNo"].ToString().Trim() ?? "";
                    //employee.DOB = Convert.ToDateTime(sqlDataReader["DOB"].ToString().Trim()) == null ? (DateTime?)null : Convert.ToDateTime(sqlDataReader["DOB"].ToString().Trim());
                    employee.DOB = sqlDataReader["DOB"] == DBNull.Value ? (DateTime?)null : (DateTime?)sqlDataReader["DOB"];
                    //employee.HireDate = Convert.ToDateTime(sqlDataReader["HireDate"].ToString().Trim()) == null ? (DateTime?)null : Convert.ToDateTime(sqlDataReader["HireDate"].ToString().Trim());
                    employee.HireDate = sqlDataReader["HireDate"] == DBNull.Value ? (DateTime?)null : (DateTime?)sqlDataReader["HireDate"];
                    //employee.LastDate = Convert.ToDateTime(sqlDataReader["LastDate"].ToString().Trim()) == null ? (DateTime?)null : Convert.ToDateTime(sqlDataReader["LastDate"].ToString().Trim());
                    employee.LastDate = sqlDataReader["LastDate"] == DBNull.Value ? (DateTime?)null : (DateTime?)sqlDataReader["LastDate"];
                    employee.Email = sqlDataReader["Email"].ToString().Trim() ?? "";
                    employee.PhoneHome = sqlDataReader["PhoneHome"].ToString().Trim() ?? "";
                    employee.PhoneMobile = sqlDataReader["PhoneMobile"].ToString().Trim() ?? "";
                    employee.PhoneAlt = sqlDataReader["PhoneAlt"].ToString().Trim() ?? "";
                    employee.PhotoPath = sqlDataReader["PhotoPath"].ToString().Trim() ?? "";
                    employee.OldKey = Convert.ToInt32(sqlDataReader["OldKey"].ToString().Trim());
                    //employee.ModDate = Convert.ToDateTime(sqlDataReader["ModDate"].ToString().Trim()) == null ? (DateTime?)null : Convert.ToDateTime(sqlDataReader["ModDate"].ToString().Trim());
                    employee.ModDate = Convert.ToDateTime(sqlDataReader["ModDate"].ToString().Trim());
                    employee.DepartmentName = sqlDataReader["DepartmentName"].ToString().Trim() ?? "";
                    employee.TitleName = sqlDataReader["TitleName"].ToString().Trim() ?? "";
                    employee.BranchName = sqlDataReader["BranchName"].ToString().Trim() ?? "";
                }
                
                return employee;
                
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                Employee employee = new Employee();
                return employee;
            }
            finally
            {

                connection.Close();
            }
        }

        static public void cbo_department(ComboBox cbo_department)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT DepartmentName ";
                sql = sql + "FROM Department WITH(NOLOCK) ";
                //sql = sql + "WHERE DepartmentKey = '" + DepartmentKey + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    string firstname = reader[0].ToString().Trim();
                    //string lastname = reader[1].ToString().Trim();
                    //string fullname = firstname + " " + lastname;
                    cbo_department.Items.Add(firstname);
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void cbo_title(ComboBox cbo_title)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT TitleName ";
                sql = sql + "FROM Title ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    string firstname = reader[0].ToString().Trim();
                    //string lastname = reader[1].ToString().Trim();
                    //string fullname = firstname + " " + lastname;
                    cbo_title.Items.Add(firstname);
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void cbo_branch(ComboBox cbo_branch)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT BranchName ";
                sql = sql + "FROM CdBranch WITH(NOLOCK) ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    string firstname = reader[0].ToString().Trim();
                    //string lastname = reader[1].ToString().Trim();
                    //string fullname = firstname + " " + lastname;
                    cbo_branch.Items.Add(firstname);
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection2.Close();
            }
        }

    }
}
