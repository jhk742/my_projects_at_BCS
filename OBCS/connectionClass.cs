using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS
{
    class connectionClass
    {
        public static SqlConnection connection2 = new SqlConnection(@"Data Source=JINKIM;Initial Catalog=CoreXDB;User ID=JINKIM;Password=JINKIM");

        static public void sp_Fetch_iPadSalesOrder(DataGridView _dataGridView, DateTime fromDate, DateTime toDate)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Fetch_iPadSalesOrder";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = fromDate;
                cmd.Parameters["@ToDate"].Value = toDate;

                connection2.Open();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                _dataGridView.DataSource = dataTable;


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

        static public void sp_Fetch_iPadSalesOrder2(DateTime fromDate, DateTime toDate)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Fetch_iPadSalesOrder";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = fromDate;
                cmd.Parameters["@ToDate"].Value = toDate;

                connection2.Open();
                cmd.ExecuteNonQuery();

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
