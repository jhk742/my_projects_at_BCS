using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OBCS
{
    class conn

    {
        public static class ControlID
        {
            public static string TextData { get; set; }
        }

        public static SqlConnection connection = new SqlConnection(@"Data Source=JINKIM;Initial Catalog=JINKIM;User ID=JINKIM;Password=JINKIM!"); 
        //public static SqlConnection connection = new SqlConnection(@"Data Source=JINKIM;Initial Catalog=CoreLinkDB2013;User ID=JINKIM;Password=JINKIM");

        static public bool LogIn(string txt_id, string txt_password)
        {
            try
            {
                connection.Open();
                //SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT OrdMemo FROM SalesOrderDetail WHERE OrderID = '" + OrderID + "'", connection);
                SqlCommand cmd = new SqlCommand("SELECT * FROM PASS WITH(NOLOCK) WHERE p_id = '" + txt_id + "' and p_pass = '" + txt_password + "'", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    //MessageBox.Show("OK");
                    return true;
                }
                else
                {
                    MessageBox.Show("Your ID or Password is incorrect.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        static public bool UserIdCheckup(string id)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT p_id FROM PASS WITH(NOLOCK) WHERE p_id = '" + id + "' ";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return true;
            }
            finally
            {
                connection.Close();
            }
        }

        static public void AddNewUser(string id)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO PASS(p_id, p_pass, p_name, p_email, p_cat, p_idate) values('" + id + "', '', '','','', getdate())", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void ModiUserId(string id, string password, string name, string email, string category)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE PASS SET p_pass = '" + password + "', p_name = '" + name + "', p_email = '" + email + "', p_cat = '" + category + "' WHERE p_id = '" + id + "'", connection);
                SqlDataReader reader = cmd.ExecuteReader();

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }


        static public void User(DataGridView _dataGridView)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT * FROM PASS WITH(NOLOCK) ";
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void User_Active(DataGridView _dataGridView)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT * FROM PASS WITH(NOLOCK) WHERE p_status = 'Active' ";
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void FillOutUserInfo(String userid, TextBox txt_name, TextBox txt_category, TextBox txt_email)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT p_id, p_name, p_cat, p_email FROM PASS WITH(NOLOCK) WHERE p_id = '" + userid + "'", connection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string id = dr[0].ToString();
                    string name = dr[1].ToString();
                    string category = dr[2].ToString();
                    string email = dr[3].ToString();

                    txt_name.Text = name.Trim();
                    txt_category.Text = category.Trim();
                    txt_email.Text = email.Trim();
                }
                else
                {

                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }


        static public void InvFillGrid(DataGridView _dataGridView)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT * ";
                sql = sql + "FROM INV WITH(NOLOCK) ";
                sql = sql + "WHERE I_RP = 'I' ";
                sql = sql + "      AND I_GROUP = '80SO' ";
                //sql = sql + "      AND  I_INVDATE >= '<<dFROMDATE>>' ";
                sql = sql + "ORDER BY I_ID ";
                sql = sql + " ";
                sql = sql + " ";

                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void FillGrid_PASSD(DataGridView _dataGridView, String userid)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT * ";
                sql = sql + "FROM PASSD WITH(NOLOCK) ";
                sql = sql + "WHERE P_ID='" + userid + "' ";

                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void InvoiceDetailGrid(DataGridView _dataGridView, String id)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT *  ";
                sql = sql + "FROM INVDET WITH(NOLOCK) ";
                sql = sql + "WHERE ID_ID = '" + id + "' ";


                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void FillGrid_orddet(DataGridView _dataGridView, String id)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT *  ";
                sql = sql + "FROM ORDDET ";
                sql = sql + "WHERE ORDD_ORDERID = '" + id + "' ";


                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }


        static public void FillGrid_Order(DataGridView _dataGridView)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT *  ";
                sql = sql + "FROM ORD WITH(NOLOCK) ";
                
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }


        static public void FillGrid_Item(DataGridView _dataGridView)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT * ";
                sql = sql + "FROM ITEM WITH(NOLOCK) ";
                sql = sql + "ORDER BY item_id ";

                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void item_mod(String itemID, TextBox txt_id, TextBox txt_desc, TextBox txt_packSize, TextBox txt_minPrice, TextBox txt_onhand, TextBox txt_cat1, TextBox txt_barcode, TextBox txt_brand, TextBox txt_priceGroup, TextBox txt_pickZone, TextBox txt_active)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT item_id, item_desc, item_packSize, item_minPrice, item_onhand, item_cat1, item_barcode, item_brand, item_priceGroup, item_pickZone, item_active ";
                sql = sql + "FROM ITEM WITH(NOLOCK) ";
                sql = sql + "WHERE item_id = '" + itemID + "' ";

                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string id = dr[0].ToString();
                    string desc = dr[1].ToString();
                    string packSize = dr[2].ToString();
                    string minPrice = dr[3].ToString();
                    string onhand = dr[4].ToString();
                    string cat1 = dr[5].ToString();
                    string barcode = dr[6].ToString();
                    string brand = dr[7].ToString();
                    string priceGroup = dr[8].ToString();
                    string pickZone = dr[9].ToString();
                    string active = dr[10].ToString();

                    txt_id.Text = id.Trim();
                    txt_desc.Text = desc.Trim();
                    txt_packSize.Text = packSize.Trim();
                    txt_minPrice.Text = minPrice.Trim();
                    txt_onhand.Text = onhand.Trim();
                    txt_cat1.Text = cat1.Trim();
                    txt_barcode.Text = barcode.Trim();
                    txt_brand.Text = brand.Trim();
                    txt_priceGroup.Text = priceGroup.Trim();
                    txt_pickZone.Text = pickZone.Trim();
                    txt_active.Text = active.Trim();
                }
                else
                {

                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }


        static public void PickingCheck(String orddetid)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ORDDET SET ordd_pickingFlag = 'Y' WHERE ordd_id = '"+ orddetid + "' ", connection);
                SqlDataReader dr = cmd.ExecuteReader();
                
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }


    }
}
