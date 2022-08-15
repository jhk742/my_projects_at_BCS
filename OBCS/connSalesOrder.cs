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
using System.Threading.Tasks;

namespace OBCS
{
    class connSalesOrder
    {
        //****************************************WARNING****************************************************
        //****************CHECK sp_ARValidation sql connection database name : line 24095********************
        //public static SqlConnection connectionasync2 = new SqlConnection(@"Data Source=192.168.1.46;Initial Catalog=CoreTEST;User ID=sa;Password=BcsKing3355!;Asynchronous Processing=True;MultipleActiveResultSets=True");
        public static SqlConnection connection = new SqlConnection(@"Data Source=192.168.1.46;Initial Catalog=CoreXDB;User ID=sa;Password=BcsKing3355!");
        public static SqlConnection connection2 = new SqlConnection(@"Data Source=192.168.1.46;Initial Catalog=CoreXDB;User ID=sa;Password=BcsKing3355!");
        public static SqlConnection connection3 = new SqlConnection(@"Data Source=192.168.1.46;Initial Catalog=CoreXDB;User ID=sa;Password=BcsKing3355!");
        public static SqlConnection connection4 = new SqlConnection(@"Data Source=192.168.1.46;Initial Catalog=CoreXDB;User ID=sa;Password=BcsKing3355!");
        public static SqlConnection connection227 = new SqlConnection(@"Data Source=192.168.1.227;Initial Catalog=CoreLinkDB2013;User ID=sa;Password=bcsroyal##55");
        public static SqlConnection connection2272 = new SqlConnection(@"Data Source=192.168.1.227;Initial Catalog=CoreLinkDB2013;User ID=sa;Password=bcsroyal##55");

        //public static SqlConnection connection = new SqlConnection(@"Data Source=192.168.1.227;Initial Catalog=CoreLinkDB2013;User ID=sa;Password=bcsroyal##55");
        //public static SqlConnection connection2 = new SqlConnection(@"Data Source=192.168.1.227;Initial Catalog=CoreLinkDB2013;User ID=sa;Password=bcsroyal##55");
        //public static SqlConnection connection3 = new SqlConnection(@"Data Source=192.168.1.227;Initial Catalog=CoreLinkDB2013;User ID=sa;Password=bcsroyal##55");

        public static SqlConnection BCSX3connection = new SqlConnection(@"Data Source=VAPP1\X3V9;Integrated Security=False;User ID=sa;Password=Bc$R0y@L;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public static int TimeoutTime = 6000;

        static public void sp_Fetch_iPadSalesOrder(DataGridView _dataGridView, DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Fetch_iPadSalesOrder";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = fromDate;
                cmd.Parameters["@ToDate"].Value = toDate;
                cmd.Parameters["@UserID"].Value = GATE.userID;

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

        static public void sp_Fetch_iPadSalesOrderVendor(DataGridView _dataGridView, DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Fetch_iPadSalesOrderVendor";
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

        static public void sp_Fetch_iPadSalesOrderNYF(DataGridView _dataGridView, DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Fetch_iPadSalesOrderNYF";
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
            finally {connection2.Close();}
        }

        static public void sp_Fetch_iPadSalesOrderDetail(DataGridView _dataGridView, String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Fetch_iPadSalesOrderDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

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

        static public void sp_PAYMENT_CREDIT(DataGridView _dataGridView, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENT_CREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PAYMENT_CREDIT_PENDING(DataGridView _dataGridView, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENT_CREDIT_PENDING";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_NS_HISTORY(DataGridView _dataGridView, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_NS_HISTORY";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_NS_CHECKING(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_NS_CHECKING";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                //cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_List_ProductList_GlobalAllocated(DataGridView _dataGridView, String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_List_ProductList_GlobalAllocated";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PAYMENT_RETURN(DataGridView _dataGridView, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENT_RETURN";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PAYMENT_OVERPAYMENT(DataGridView _dataGridView, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENT_OVERPAYMENT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PAYMENTT_INVOICE(String NewPaymentNumber, String CustomerID, String InvoiceNumber, Decimal PaymentAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENTT_INVOICE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewRECCHNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@PaymentAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewRECCHNumber"].Value = NewPaymentNumber;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@PaymentAmount"].Value = PaymentAmount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PAYMENTT_INVOICE_AR(String NewPaymentNumber, String CustomerID, String InvoiceNumber, Decimal PaymentAmount, String ShortOver, Decimal ShortOverAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENTT_INVOICE_AR";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewRECCHNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@PaymentAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ShortOver", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShortOverAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewRECCHNumber"].Value = NewPaymentNumber;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@PaymentAmount"].Value = PaymentAmount;
                cmd.Parameters["@ShortOver"].Value = ShortOver;
                cmd.Parameters["@ShortOverAmount"].Value = ShortOverAmount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PAYMENTT_INVOICE_SHORTOVER(String CustomerID, String InvoiceNumber, Decimal ShortOverAmount, String NewPaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENTT_INVOICE_SHORTOVER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                //cmd.Parameters.Add("@ARAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShortOverAmount", SqlDbType.Decimal);
                //cmd.Parameters.Add("@PAM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewRECCHNumber", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                //cmd.Parameters["@Amount"].Value = Amount;
                //cmd.Parameters["@ARPaymentAmount"].Value = ARAmount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@ShortOverAmount"].Value = ShortOverAmount;
                //cmd.Parameters["@PAM_0"].Value = PAM_0;
                cmd.Parameters["@NewRECCHNumber"].Value = NewPaymentNumber;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PAYMENT_ADD_CREDIT(String CustomerID, Decimal CreditAmount, String OrderNumber, String CreditMemo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENT_ADD_CREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@OrderNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@CreditMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@CreditAmount"].Value = CreditAmount;
                cmd.Parameters["@OrderNumber"].Value = OrderNumber;
                //cmd.Parameters["@CreditMemo"].Value = CreditMemo;
                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PAYMENT_ADD_3CREDIT(String CompanyID, String CustomerID, String CMReason, String CreditMemo, Decimal CreditAmount, String DeliveryNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENT_ADD_3CREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CompanyID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CMReason", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@DeliveryNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);

                cmd.Parameters["@CompanyID"].Value = CompanyID;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@CMReason"].Value = CMReason;
                cmd.Parameters["@CreditMemo"].Value = CreditMemo;
                cmd.Parameters["@CreditAmount"].Value = CreditAmount;
                cmd.Parameters["@DeliveryNumber"].Value = DeliveryNumber;
                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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


        static public void sp_PAYMENT_ADD_AFTERCREDIT(String CustomerID, String OrderID, String DeliveryNumber, Decimal CreditAmount, String CMReason, String CreditMemo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENT_ADD_AFTERCREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@DeliveryNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CMReason", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@DeliveryNumber"].Value = DeliveryNumber;
                cmd.Parameters["@CreditAmount"].Value = CreditAmount;
                cmd.Parameters["@CMReason"].Value = CMReason;
                cmd.Parameters["@CreditMemo"].Value = CreditMemo;
                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PAYMENT_ADD_PAIDCHECKCASH(String CheckCash, Decimal Amount, DateTime CheckDate, String CheckNumber, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENT_ADD_PAIDCHECKCASH";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CheckCash", SqlDbType.VarChar);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CheckDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@CheckNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CheckCash"].Value = CheckCash;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@CheckDate"].Value = CheckDate;
                cmd.Parameters["@CheckNumber"].Value = CheckNumber;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PAYMENTT_CREDIT(String CustomerID, String CreditNumber, Decimal Amount, String NewPaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENTT_CREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewRECCHNumber", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@CreditNumber"].Value = CreditNumber;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewRECCHNumber"].Value = NewPaymentNumber;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PAYMENTT_RETURN(String CustomerID, String ReturnNumber, Decimal Amount, String NewPaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENTT_RETURN";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReturnNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewRECCHNumber", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@ReturnNumber"].Value = ReturnNumber;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewRECCHNumber"].Value = NewPaymentNumber;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PAYMENTT_TERMCREDIT(String NewPaymentNumber, String InvoiceNumber, Decimal Amount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENTT_TERMCREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewRECCHNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewRECCHNumber"].Value = NewPaymentNumber;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PAYMENTT(String NewPaymentNumber, String CustomerID, String CheckNumber, DateTime Date, Decimal Amount, String PaymentType, String Site, String Bank, String EntryBatch, String id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENTT";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Clear();

                cmd.Parameters.Add("@NewRECCHNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheckNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Date", SqlDbType.DateTime);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                cmd.Parameters.Add("@EntryBatch", SqlDbType.VarChar);
                cmd.Parameters.Add("@id", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewRECCHNumber"].Value = NewPaymentNumber;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@CheckNumber"].Value = CheckNumber;
                cmd.Parameters["@Date"].Value = Date;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@PaymentType"].Value = PaymentType;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@Bank"].Value = Bank;
                cmd.Parameters["@EntryBatch"].Value = EntryBatch;
                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PAYMENT_INVOICE(DataGridView _dataGridView, String CustomerID, String DeliveryNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENT_INVOICE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@DeliveryNumber", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@DeliveryNumber"].Value = DeliveryNumber;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_AROPENCLOSE_OPEN(DataGridView _dataGridView, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_AROPENCLOSE_OPEN";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                
                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }
        static public void sp_AROPENCLOSE_ALL(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_AROPENCLOSE_ALL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_AGING_AR_SUMMARY(DataGridView _dataGridView, DateTime Date, String CustomerID, String Site)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_AGING_AR_SUMMARY";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);

                cmd.Parameters["@ToDate"].Value = Date;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@Site"].Value = Site;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_AGING_AP_SUMMARY(DataGridView _dataGridView, DateTime Date, string SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_AGING_AP_SUMMARY";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                cmd.Parameters["@ToDate"].Value = Date;
                cmd.Parameters["@SupplierID"].Value = SupplierID;

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

        static public void sp_ACCOUNT_AGING(DataGridView _dataGridView, DateTime Date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ACCOUNT_AGING";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Date", SqlDbType.DateTime);

                cmd.Parameters["@Date"].Value = Date;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_SalesReport(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_SalesReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_SalesbyRepReport(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_SalesbyRepReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_OSReport(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_OSReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_ARLIST_SaleRep(DataGridView _dataGridView, string SaleRep)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_AR_LIST_SaleRep";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SaleRep", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@SaleRep"].Value = SaleRep;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_AGING_SUMMARY_AR(DataGridView _dataGridView, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_AGING_SUMMARY_AR";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                
                //cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_LIST_DRIVER(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_LIST_DRIVER";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                //cmd.Parameters["@CustomerID"].Value = CustomerID;


                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_AROPENCLOSE_CLOSED(DataGridView _dataGridView, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_AROPENCLOSE_CLOSED";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_LIST_CUSTOMER(DataGridView _dataGridView, String Branch, String SalesPerson, String CustomerID, String CompanyName, String Active)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_LIST_CUSTOMER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                cmd.Parameters.Add("@SalesPerson", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar);
                cmd.Parameters.Add("@Active", SqlDbType.VarChar);

                cmd.Parameters["@Branch"].Value = Branch;
                cmd.Parameters["@SalesPerson"].Value = SalesPerson;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@CompanyName"].Value = CompanyName;
                cmd.Parameters["@Active"].Value = Active;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_LIST_SUPPLIER(DataGridView _dataGridView, String Branch, String SalesPerson, String CustomerID, String CompanyName, String Active)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_LIST_SUPPLIER";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                //cmd.Parameters.Add("@SalesPerson", SqlDbType.VarChar);
                //cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Active", SqlDbType.VarChar);

                //cmd.Parameters["@Branch"].Value = Branch;
                //cmd.Parameters["@SalesPerson"].Value = SalesPerson;
                //cmd.Parameters["@CustomerID"].Value = CustomerID;
                //cmd.Parameters["@CompanyName"].Value = CompanyName;
                //cmd.Parameters["@Active"].Value = Active;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_LIST_PRODUCT(DataGridView _dataGridView, String Branch, String SalesPerson, String CustomerID, String CompanyName, String Active)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_LIST_PRODUCT";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                //cmd.Parameters.Add("@SalesPerson", SqlDbType.VarChar);
                //cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Active", SqlDbType.VarChar);

                //cmd.Parameters["@Branch"].Value = Branch;
                //cmd.Parameters["@SalesPerson"].Value = SalesPerson;
                //cmd.Parameters["@CustomerID"].Value = CustomerID;
                //cmd.Parameters["@CompanyName"].Value = CompanyName;
                //cmd.Parameters["@Active"].Value = Active;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PAYMENTT_SELECT_PAYMENTNUMBER(DataGridView _dataGridView, String PaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PAYMENTT_SELECT_PAYMENTNUMBER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentNumber", SqlDbType.VarChar);

                cmd.Parameters["@PaymentNumber"].Value = PaymentNumber;

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

        static public void sp_PAYMENTT_REVERSE(String PaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENTT_REVERSE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@PaymentNumber"].Value = PaymentNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PO_DELETE(String PONumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PO_DELETE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@PONumber"].Value = PONumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PAYMENTT_DELETE_CREDIT(String CreditNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENTT_DELETE_CREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreditNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CreditNumber"].Value = CreditNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_NS_REVERSE(String NSNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_NS_REVERSE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NSNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                
                cmd.Parameters["@NSNumber"].Value = NSNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_NS_HISTORY_DETAIL(DataGridView _dataGridView, String NSNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_NS_HISTORY_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NSNumber", SqlDbType.VarChar);

                cmd.Parameters["@NSNumber"].Value = NSNumber;

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

        static public void sp_PAYMENTT_CONFIRM_CREDIT(String CreditNumber)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENTT_CONFIRM_CREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreditNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CreditNumber"].Value = CreditNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PAYMENTT_DELETE_PAID(String id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENTT_DELETE_PAID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_DEALLOCATION_ORDER(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_DEALLOCATION_ORDER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_DEALLOCATION_PICKTICKET(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_DEALLOCATION_PICKTICKET";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_DEALLOCATION_DELIVERYNOTE(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_DEALLOCATION_DELIVERYNOTE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PAYMENTT_HEADER(DataGridView _dataGridView, String CustomerID, String PaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PAYMENTT_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@PaymentNumber", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@PaymentNumber"].Value = PaymentNumber;

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

        static public void sp_DEALLOCATION_SELECT(DataGridView _dataGridView, String Status, String CustomerID, String DeliveryNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_DEALLOCATION_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@DeliveryNumber", SqlDbType.VarChar);
                
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@DeliveryNumber"].Value = DeliveryNumber;

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

        static public void sp_PAYMENTT_GetPayments(DataGridView _dataGridView, String Site, String Bank, String PaymentType)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENTT_GetPayments";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@Bank"].Value = Bank;
                cmd.Parameters["@PaymentType"].Value = PaymentType;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_DEPOSIT_CREATEHEADER(String Site, String Bank, String PAM_0, String NewDEPNumber, String NewBMWNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_DEPOSIT_CREATEHEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                cmd.Parameters.Add("@PAM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewDEPNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewBMWNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@Bank"].Value = Bank;
                cmd.Parameters["@PAM_0"].Value = PAM_0;
                cmd.Parameters["@NewDEPNumber"].Value = NewDEPNumber;
                cmd.Parameters["@NewBMWNumber"].Value = NewBMWNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_DEPOSIT_CREATEDETAIL(String RECCHNumber, String NewDEPNumber, String NewBMWNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_DEPOSIT_CREATEDETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RECCHNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewDEPNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewBMWNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@RECCHNumber"].Value = RECCHNumber;
                cmd.Parameters["@NewDEPNumber"].Value = NewDEPNumber;
                cmd.Parameters["@NewBMWNumber"].Value = NewBMWNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_DEPOSIT_HEADER(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_DEPOSIT_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                //cmd.Parameters["@Site"].Value = Site;
                //cmd.Parameters["@Bank"].Value = Bank;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_DEPOSIT_HEADER_BY_DATE(DataGridView _dataGridView, DateTime Createtime)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_DEPOSIT_HEADER_BY_DATE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreateTime", SqlDbType.DateTime);
                
                cmd.Parameters["@CreateTime"].Value = Createtime;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_DEPOSIT_DETAIL(DataGridView _dataGridView, String DEPNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_DEPOSIT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@DEPNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@DEPNumber"].Value = DEPNumber;
                //cmd.Parameters["@Bank"].Value = Bank;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;
                
                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PAYMENT_PaidCashCheck(DataGridView _dataGridView, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PAYMENT_PaidCashCheck";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_Fetch_OrderDetail2(DataGridView _dataGridView, String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_OrderDetail2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_Fetch_OrderReturnDetail(DataGridView _dataGridView, String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_OrderReturnDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_Fetch_DeliveryDetail(DataGridView _dataGridView, String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_DeliveryDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_Fetch_InvoiceDetail(DataGridView _dataGridView, String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_InvoiceDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_Fetch_PickDetail(DataGridView _dataGridView, String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_PickDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_Fetch_PickingNumber(DataGridView _dataGridView, String PickingNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_PickingNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PickingNumber", SqlDbType.VarChar);

                cmd.Parameters["@PickingNumber"].Value = PickingNumber;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_Fetch_PickingNumber_Deliverable(DataGridView _dataGridView, String PickingNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_PickingNumber_Deliverable";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PickingNumber", SqlDbType.VarChar);

                cmd.Parameters["@PickingNumber"].Value = PickingNumber;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_UPDATE_PickingNumberBox(String PickingNumber, int Box)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_UPDATE_PickingNumberBox";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PickingNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Box", SqlDbType.Int);


                cmd.Parameters["@PickingNumber"].Value = PickingNumber;
                cmd.Parameters["@Box"].Value = Box;


                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_EDIT_PickingNumberBox(String PickingNumber, int Box)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_EDIT_PickingNumberBox";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PickingNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Box", SqlDbType.Int);

                cmd.Parameters["@PickingNumber"].Value = PickingNumber;
                cmd.Parameters["@Box"].Value = Box;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_Fetch_Order2(DataGridView _dataGridView, String CustomerID, String SalesRep, DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_Order2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@SalesRep", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@SalesRep"].Value = SalesRep;
                cmd.Parameters["@FromDate"].Value = fromDate;
                cmd.Parameters["@ToDate"].Value = toDate;
                cmd.Parameters["@UserID"].Value = GATE.userID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_Fetch_Pick(DataGridView _dataGridView, DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_Pick";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = fromDate;
                cmd.Parameters["@ToDate"].Value = toDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_Fetch_Delivery(DataGridView _dataGridView, DateTime fromDate, DateTime toDate, String DeliveryNumber, String CustomerID, String RouteNumber, String DriverName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_Delivery";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@DeliveryNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@RouteNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DriverName", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = fromDate;
                cmd.Parameters["@ToDate"].Value = toDate;
                cmd.Parameters["@DeliveryNumber"].Value = DeliveryNumber;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@RouteNumber"].Value = RouteNumber;
                cmd.Parameters["@DriverName"].Value = DriverName;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_Fetch_Invoice(DataGridView _dataGridView, DateTime fromDate, DateTime toDate, String SalesRep, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_Invoice";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@SalesRep", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Rtest", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = fromDate;
                cmd.Parameters["@ToDate"].Value = toDate;
                cmd.Parameters["@SalesRep"].Value = SalesRep;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                //cmd.Parameters["@Rtest"].Value = "";

                connection.Open();
                
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
                connection.Close();
            }
        }

        static public void cbo_drivers(ComboBox cbo_drivers)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = BCSX3connection;
                cmd.CommandText = "BCSX3.dbo.ZMIC_GET_ALL_DRIVERS";
                cmd.CommandType = CommandType.StoredProcedure;

                BCSX3connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Driver = reader["TEXTE_0"].ToString().Trim();
                    cbo_drivers.Items.Add(Driver);
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                BCSX3connection.Close();
            }
        }

        static public void sp_PORDER_GET_ITEMBYSUPPLIER(ComboBox cbo_product, String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PORDER_GET_ITEMBYSUPPLIER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Product = reader["ProductID"].ToString().Trim();
                    cbo_product.Items.Add(Product);
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

        static public void sp_GET_CommissionCode(ComboBox cbo_commissionCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_CommissionCode";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                //cmd.Parameters["@SupplierID"].Value = SupplierID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string CommissionCode = reader["PLICRI1_0"].ToString().Trim();
                    cbo_commissionCode.Items.Add(CommissionCode);
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
        

        static public void sp_GET_PaymentTerm(ComboBox cbo_paymentTerm)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_PaymentTerm";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                //cmd.Parameters["@SupplierID"].Value = SupplierID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string paymentTerm = reader["PTE_0"].ToString().Trim();
                    cbo_paymentTerm.Items.Add(paymentTerm);
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

        static public void sp_GET_SalesRep(ComboBox cbo_salesRep)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_SalesRep";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                //cmd.Parameters["@SupplierID"].Value = SupplierID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string SalesRep = reader["REPNUM_0"].ToString().Trim();
                    cbo_salesRep.Items.Add(SalesRep);
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

        static public void sp_GET_SupplierCategory(ComboBox cbo_SupplierCategory)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_SupplierCategory";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                //cmd.Parameters["@SupplierID"].Value = SupplierID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string SupplierCategory = reader["BSGCOD_0"].ToString().Trim();
                    cbo_SupplierCategory.Items.Add(SupplierCategory);
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

        static public void sp_GET_ALLBrandCode(ComboBox cbo_brandcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_ALLBrandCode";
                cmd.CommandType = CommandType.StoredProcedure;
                
                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string BrandCode = reader["BrandCode"].ToString().Trim();
                    cbo_brandcode.Items.Add(BrandCode);
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

        static public void sp_GET_SalesUnit(ComboBox cbo_brandcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_SalesUnit";
                cmd.CommandType = CommandType.StoredProcedure;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string SalesUnit = reader["SalesUnit"].ToString().Trim();
                    cbo_brandcode.Items.Add(SalesUnit);
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

        static public void sp_GET_PurchaseUnit(ComboBox cbo_PurchaseUnit)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_PurchaseUnit";
                cmd.CommandType = CommandType.StoredProcedure;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string PurchaseUnit = reader["PurchaseUnit"].ToString().Trim();
                    cbo_PurchaseUnit.Items.Add(PurchaseUnit);
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


        static public void cbo_Driver(ComboBox cbo_drivers)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT driver ";
                sql = sql + "FROM Driver ";
                sql = sql + "WHERE active = 1 ";
                //sql = sql + "ORDER BY id "; 5/7/2020 requested by Ben Jin --order by driver name
                sql = sql + "ORDER BY driver ";
                //sql = sql + "ORDER BY driver ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);

                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Driver = reader["driver"].ToString().Trim();
                    cbo_drivers.Items.Add(Driver);
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

        static public void cbo_Truck(ComboBox cbo_trucks)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT truck ";
                sql = sql + "FROM Truck ";
                sql = sql + "WHERE active = 1 ";
                sql = sql + "Order by truck ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Truck = reader["truck"].ToString().Trim();
                    cbo_trucks.Items.Add(Truck);
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

        static public void cbo_salesRep(ComboBox cbo_salesRep)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT REPNUM_0 ";
                sql = sql + "FROM SALESREP WITH(NOLOCK) ";
                sql = sql + "ORDER BY REPNUM_0 ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string REP = reader["REPNUM_0"].ToString().Trim();
                    cbo_salesRep.Items.Add(REP);
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

        static public void cbo_trucks(ComboBox cbo_trucks)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = BCSX3connection;
                cmd.CommandText = "BCSX3.dbo.ZMIC_GET_ALL_TRUCKS";
                cmd.CommandType = CommandType.StoredProcedure;

                BCSX3connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    string Truck = reader["TEXTE_0"].ToString().Trim();
                    cbo_trucks.Items.Add(Truck);
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                BCSX3connection.Close();
            }
        }

        static public void list_RTTMPH(DataGridView _dataGridView, DateTimePicker dateTimePicker_routingDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = BCSX3connection;
                cmd.CommandText = "BCSX3.dbo.ZRT_GET_RTTMP_HEADERS";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ROUTEDATE", SqlDbType.DateTime);

                cmd.Parameters["@ROUTEDATE"].Value = dateTimePicker_routingDate.Value.Date.ToShortDateString();

                BCSX3connection.Open();

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
                BCSX3connection.Close();
            }
        }

        static public void sp_GET_Route_HEADERS(DataGridView _dataGridView, DateTimePicker dateTimePicker_routingDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_Route_HEADERS";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ROUTEDATE", SqlDbType.DateTime);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);

                cmd.Parameters["@ROUTEDATE"].Value = dateTimePicker_routingDate.Value.Date.ToShortDateString();
                cmd.Parameters["@UserID"].Value = GATE.userID;

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

        static public void sp_GET_Route_HEADERS_VENDOR(DataGridView _dataGridView, DateTimePicker dateTimePicker_routingDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_Route_HEADERS_VENDOR";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ROUTEDATE", SqlDbType.DateTime);
                cmd.Parameters.Add("@UserID", SqlDbType. VarChar);

                cmd.Parameters["@ROUTEDATE"].Value = dateTimePicker_routingDate.Value.Date.ToShortDateString();
                cmd.Parameters["@UserID"].Value = GATE.userID;

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

        static public void grid_DRIVER(DataGridView _dataGridView, MonthCalendar monthCalendar)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_Route_HEADERS";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ROUTEDATE", SqlDbType.DateTime);
                cmd.Parameters.Add("@UserID", SqlDbType.DateTime);

                cmd.Parameters["@ROUTEDATE"].Value = monthCalendar.SelectionRange.Start.ToShortDateString();
                cmd.Parameters["@UserID"].Value = monthCalendar.SelectionRange.Start.ToShortDateString();

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

        static public void sp_PackageNut_Header(DataGridView _dataGridView, DateTime Date, String ViewAllOrder)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PackageNut_Header";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Date", SqlDbType.DateTime);
                cmd.Parameters.Add("@ViewAllOrder", SqlDbType.VarChar);

                cmd.Parameters["@Date"].Value = Date;
                cmd.Parameters["@ViewAllOrder"].Value = ViewAllOrder; // 1.Checked, 2.Unchecked

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

        static public void grid_PickingNumber(DataGridView _dataGridView, String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_PickingListByOrderID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

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

        static public void list_RTTMPD(DataGridView _dataGridView, int TEMPNO, String PRLNUM)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = BCSX3connection;
                cmd.CommandText = "BCSX3.dbo.ZRT_GET_RTTMP_DETAILS3";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@TEMPNO", SqlDbType.Int);
                cmd.Parameters.Add("@PRLNUM", SqlDbType.VarChar);

                cmd.Parameters["@TEMPNO"].Value = TEMPNO;
                cmd.Parameters["@PRLNUM"].Value = PRLNUM;

                BCSX3connection.Open();

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
                BCSX3connection.Close();
            }
        }

        static public void grid_RouteDetail(DataGridView _dataGridView, String RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_Route_DETAILS";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);

                cmd.Parameters["@RouteNumber"].Value = RouteNumber;

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

        static public void grid_DETAILSfromDelivery(DataGridView _dataGridView, String RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_Route_DETAILSfromDelivery";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);

                cmd.Parameters["@RouteNumber"].Value = RouteNumber;

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

        static public void sp_PackageNut_Detail(DataGridView _dataGridView, String iPadOrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PackageNut_Detail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@iPadOrderID", SqlDbType.VarChar);

                cmd.Parameters["@iPadOrderID"].Value = iPadOrderID;

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

        static public void sp_PO_JIT(DataGridView _dataGridView, String BrandName, String ProductID, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PO_JIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandName", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@BrandName"].Value = BrandName;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

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

        static public void grid_RouteDetailfromPick(DataGridView _dataGridView, String RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_Route_DETAILSfromPick";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);

                cmd.Parameters["@RouteNumber"].Value = RouteNumber;

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

        static public DeliveryManifest sp_GET_DeliveryManifest(String RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_DeliveryManifest";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteNumber", SqlDbType.VarChar);

                cmd.Parameters["@RouteNumber"].Value = RouteNumber;

                connection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                DeliveryManifest deliveryManifest = new DeliveryManifest();

                if (sqlDataReader.Read())
                {
                    deliveryManifest.Bill100 = Convert.ToDecimal(sqlDataReader["Bill100"].ToString().Trim());
                    deliveryManifest.Bill50 = Convert.ToDecimal(sqlDataReader["Bill50"].ToString().Trim());
                    deliveryManifest.Bill20 = Convert.ToDecimal(sqlDataReader["Bill20"].ToString().Trim());
                    deliveryManifest.Bill10 = Convert.ToDecimal(sqlDataReader["Bill10"].ToString().Trim());
                    deliveryManifest.Bill5 = Convert.ToDecimal(sqlDataReader["Bill5"].ToString().Trim());
                    deliveryManifest.Bill2 = Convert.ToDecimal(sqlDataReader["Bill2"].ToString().Trim());
                    deliveryManifest.Bill1 = Convert.ToDecimal(sqlDataReader["Bill1"].ToString().Trim());
                    deliveryManifest.Coins = Convert.ToDecimal(sqlDataReader["Coins"].ToString().Trim());
                    deliveryManifest.Park = Convert.ToDecimal(sqlDataReader["Park"].ToString().Trim());
                    deliveryManifest.Gas = Convert.ToDecimal(sqlDataReader["Gas"].ToString().Trim());
                    deliveryManifest.Toll = Convert.ToDecimal(sqlDataReader["Toll"].ToString().Trim());
                    deliveryManifest.Misc = Convert.ToDecimal(sqlDataReader["Misc"].ToString().Trim());
                }
                return deliveryManifest;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                DeliveryManifest deliveryManifest = new DeliveryManifest();
                return deliveryManifest;
            }
            finally
            {
                connection.Close();
            }
        }

        static public ProductObject sp_GET_ProductObject(String ProductKey)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_ProductObject";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductKey", SqlDbType.VarChar);

                cmd.Parameters["@ProductKey"].Value = ProductKey;

                connection2.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                ProductObject productObject = new ProductObject();

                if (sqlDataReader.Read())
                {
                    productObject.CdPackDeptTypeCode = sqlDataReader["CdPackDeptTypeCode"].ToString().Trim();
                    productObject.IsInActive = sqlDataReader["IsInActive"].ToString().Trim();
                    productObject.Brand = sqlDataReader["Brand"].ToString().Trim();
                    productObject.FlgPause = sqlDataReader["FlgPause"].ToString().Trim();
                    productObject.ProductKey = sqlDataReader["ProductKey"].ToString().Trim();
                    productObject.ProductID = sqlDataReader["ProductID"].ToString().Trim();
                    productObject.ProductDesc = sqlDataReader["ProductDesc"].ToString().Trim();
                    productObject.ItemPack = Convert.ToDecimal(sqlDataReader["ItemPack"].ToString().Trim() ?? "0");
                    productObject.ItemSize = Convert.ToDecimal(sqlDataReader["ItemSize"].ToString().Trim() ?? "0");
                    productObject.ItemSizeUnit = sqlDataReader["ItemSizeUnit"].ToString().Trim() ?? "";
                    productObject.StrPackSize = sqlDataReader["StrPackSize"].ToString().Trim();
                    productObject.SalesUnit = sqlDataReader["SalesUnit"].ToString().Trim();
                    productObject.UnitPr = Convert.ToDecimal(sqlDataReader["UnitPr"].ToString().Trim());
                    productObject.BottomPr = Convert.ToDecimal(sqlDataReader["BottomPr"].ToString().Trim());
                    productObject.ShelfLife = sqlDataReader["ShelfLife"].ToString().Trim() ?? "";
                    productObject.GuaranteeDay = Convert.ToDecimal(sqlDataReader["GuaranteeDay"].ToString().Trim());
                    productObject.PurchaseUnit = sqlDataReader["PurchaseUnit"].ToString().Trim();
                    productObject.StockConversionQty = Convert.ToDecimal(sqlDataReader["StockConversionQty"].ToString().Trim());
                    productObject.PalletTier = Convert.ToDecimal(sqlDataReader["PalletTier"].ToString().Trim()?? "0");
                    productObject.PalletHeight = Convert.ToDecimal(sqlDataReader["PalletHeight"].ToString().Trim() ?? "0");
                    productObject.BasePrice = Convert.ToDecimal(sqlDataReader["BasePrice"].ToString().Trim() ?? "0");
                    productObject.PickName = sqlDataReader["PickName"].ToString().Trim() ?? "";
                    productObject.PickBarCode = sqlDataReader["PickBarCode"].ToString().Trim() ?? "";
                    productObject.UPCUnit = sqlDataReader["UPCUnit"].ToString().Trim() ?? "";
                    productObject.UPCBox = sqlDataReader["UPCBox"].ToString().Trim() ?? "";
                    productObject.UPCCase = sqlDataReader["UPCCase"].ToString().Trim() ?? "";
                    productObject.CommissionCode1 = sqlDataReader["CommissionCode1"].ToString().Trim() ?? "";
                    productObject.IncentiveCode1 = sqlDataReader["IncentiveCode1"].ToString().Trim() ?? "";
                    productObject.LOCID = sqlDataReader["LOCID"].ToString().Trim() ?? "";
                    productObject.LOCID2 = sqlDataReader["LOCID2"].ToString().Trim() ?? "";
                    productObject.SubPickZone = sqlDataReader["SubPickZone"].ToString().Trim() ?? "";
                    productObject.KosherLabel1 = sqlDataReader["KosherLabel1"].ToString().Trim() ?? "";
                    productObject.Organic = sqlDataReader["Organic"].ToString().Trim() ?? "";
                    productObject.Vegan = sqlDataReader["Vegan"].ToString().Trim() ?? "";
                    productObject.GlutenFree = sqlDataReader["GlutenFree"].ToString().Trim() ?? "";
                    productObject.NonGMO = sqlDataReader["NonGMO"].ToString().Trim() ?? "";
                    productObject.Kosher = sqlDataReader["Kosher"].ToString().Trim() ?? "";
                    productObject.CheeseNumber = sqlDataReader["CheeseNumber"].ToString().Trim() ?? "";
                    productObject.ReceivingUPC = sqlDataReader["ReceivingUPC"].ToString().Trim() ?? "";
                }
                return productObject;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                ProductObject productObject = new ProductObject();
                return productObject;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public SupplierObject sp_GET_SupplierObject(String SupplierCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_SupplierObject";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierCode", SqlDbType.VarChar);

                cmd.Parameters["@SupplierCode"].Value = SupplierCode;

                connection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                SupplierObject supplierObject = new SupplierObject();

                if (sqlDataReader.Read())
                {
                    supplierObject.SupplierCode = sqlDataReader["SupplierCode"].ToString().Trim();
                    supplierObject.SupplierName = sqlDataReader["SupplierName"].ToString().Trim();
                    supplierObject.SupplierCategory = sqlDataReader["SupplierCategory"].ToString().Trim();
                    supplierObject.SupplierStatus = sqlDataReader["SupplierStatus"].ToString().Trim();
                    supplierObject.PaymentTerm = sqlDataReader["PaymentTerm"].ToString().Trim();
                    supplierObject.ShipVia = sqlDataReader["ShipVia"].ToString().Trim();
                }
                return supplierObject;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                SupplierObject supplierObject = new SupplierObject();
                return supplierObject;
            }
            finally
            {
                connection.Close();
            }
        }

        static public CustomerObject sp_GET_CustomerObject(String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_CustomerObject";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection2.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                CustomerObject customerObject = new CustomerObject();

                if (sqlDataReader.Read())
                {
                    customerObject.CustomerBranch = sqlDataReader["CustomerBranch"].ToString().Trim();
                    customerObject.CustomerStatus = sqlDataReader["CustomerStatus"].ToString().Trim();
                    customerObject.CustomerID = sqlDataReader["CustomerID"].ToString().Trim();
                    customerObject.CustomerName = sqlDataReader["CustomerName"].ToString().Trim();
                    customerObject.CustomerSalesRep = sqlDataReader["CustomerSalesRep"].ToString().Trim();

                    customerObject.CustomerSinceDate = Convert.ToDateTime(sqlDataReader["CustomerSinceDate"].ToString().Trim());
                    customerObject.CustomerTaxID = sqlDataReader["CustomerTaxID"].ToString().Trim();
                    customerObject.CustomerPaymentTerm = sqlDataReader["CustomerPaymentTerm"].ToString().Trim();
                    customerObject.CustomerBillingCompanyName = sqlDataReader["CustomerBillingCompanyName"].ToString().Trim();
                    customerObject.CustomerPickingMemo = sqlDataReader["CustomerPickingMemo"].ToString().Trim();
                    customerObject.CustomerMemo = sqlDataReader["CustomerMemo"].ToString().Trim();

                    customerObject.LabelType = sqlDataReader["LabelType"].ToString().Trim();
                    customerObject.CustomerNutMarkup = Convert.ToDecimal(sqlDataReader["CustomerNutMarkup"].ToString().Trim());
                    customerObject.NutMarkupPrintName = Convert.ToInt32(sqlDataReader["NutMarkupPrintName"].ToString().Trim());
                    customerObject.NutMarkupByMarkup = Convert.ToInt32(sqlDataReader["NutMarkupByMarkup"].ToString().Trim());
                    customerObject.NutMarkupByCustomerPrice = Convert.ToInt32(sqlDataReader["NutMarkupByCustomerPrice"].ToString().Trim());
                    customerObject.NutMarkupShowRetailPrice = Convert.ToInt32(sqlDataReader["NutMarkupShowRetailPrice"].ToString().Trim());
                    customerObject.NutMarkupPrintAddress = Convert.ToInt32(sqlDataReader["NutMarkupPrintAddress"].ToString().Trim());
                    customerObject.NutMarkupCustomLabel = Convert.ToInt32(sqlDataReader["NutMarkupCustomLabel"].ToString().Trim());

                    customerObject.PCKStoreName = sqlDataReader["PCKStoreName"].ToString().Trim();
                    customerObject.PCKAddress1 = sqlDataReader["PCKAddress1"].ToString().Trim();
                    customerObject.PCKAddress2 = sqlDataReader["PCKAddress2"].ToString().Trim();
                    customerObject.PCKCity = sqlDataReader["PCKCity"].ToString().Trim();
                    customerObject.PCKState = sqlDataReader["PCKState"].ToString().Trim();
                    customerObject.PCKZIP = sqlDataReader["PCKZIP"].ToString().Trim();
                    customerObject.AcceptOrder = Convert.ToInt32(sqlDataReader["AcceptOrder"].ToString().Trim());
                }
                return customerObject;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                CustomerObject customerObject = new CustomerObject();
                return customerObject;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public CompanyObject sp_GET_CompanyObject(String CompanyCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_CompanyObject";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);

                cmd.Parameters["@CompanyCode"].Value = CompanyCode;

                connection2.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                CompanyObject companyObject = new CompanyObject();

                if (sqlDataReader.Read())
                {
                    companyObject.CompanyStatus = sqlDataReader["CompanyStatus"].ToString().Trim();
                    companyObject.CompanyCode = sqlDataReader["CompanyCode"].ToString().Trim();
                    companyObject.CompanyName = sqlDataReader["CompanyName"].ToString().Trim();
                    companyObject.CompanyAddress = sqlDataReader["CompanyAddress"].ToString().Trim();
                    companyObject.CompanyCountry = sqlDataReader["CompanyCountry"].ToString().Trim();
                    companyObject.CompanyPhone = sqlDataReader["CompanyPhone"].ToString().Trim();
                    companyObject.CompanyFax = sqlDataReader["CompanyFax"].ToString().Trim();
                    companyObject.CompanyEmail = sqlDataReader["CompanyEmail"].ToString().Trim();
                    companyObject.CompanyWebsite = sqlDataReader["CompanyWebsite"].ToString().Trim();

                    companyObject.LegalName = sqlDataReader["LegalName"].ToString().Trim();
                    companyObject.LegalAddress1 = sqlDataReader["LegalAddress1"].ToString().Trim();
                    companyObject.LegalAddress2 = sqlDataReader["LegalAddress2"].ToString().Trim();
                    companyObject.LegalCity = sqlDataReader["LegalCity"].ToString().Trim();
                    companyObject.LegalState = sqlDataReader["LegalState"].ToString().Trim();
                    companyObject.LegalZIP = sqlDataReader["LegalZIP"].ToString().Trim();
                    companyObject.LegalCountry = sqlDataReader["LegalCountry"].ToString().Trim();

                    companyObject.FiscalYear = sqlDataReader["FiscalYear"].ToString().Trim();
                    companyObject.TaxYear = sqlDataReader["TaxYear"].ToString().Trim();
                    companyObject.IncomeTaxFormUsed = sqlDataReader["IncomeTaxFormUsed"].ToString().Trim();

                    companyObject.FEIN = sqlDataReader["FEIN"].ToString().Trim();
                    companyObject.SSN = sqlDataReader["SSN"].ToString().Trim();

                    companyObject.PayrollContact = sqlDataReader["PayrollContact"].ToString().Trim();
                    companyObject.PayrollTitle = sqlDataReader["PayrollTitle"].ToString().Trim();
                    companyObject.PayrollPhone = sqlDataReader["PayrollPhone"].ToString().Trim();
                }
                return companyObject;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                CompanyObject companyObject = new CompanyObject();
                return companyObject;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public AddressObject sp_GET_AddressObject(String ROWID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_AddressObject";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ROWID", SqlDbType.Int);

                cmd.Parameters["@ROWID"].Value = Convert.ToInt32(ROWID);

                connection2.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                AddressObject addressObject = new AddressObject();

                if (sqlDataReader.Read())
                {
                    addressObject.ROWID = sqlDataReader["ROWID"].ToString().Trim();
                    addressObject.ID = sqlDataReader["ID"].ToString().Trim();
                    addressObject.AddressCode = sqlDataReader["AddressCode"].ToString().Trim();
                    addressObject.Address1 = sqlDataReader["Address1"].ToString().Trim();
                    addressObject.Address2 = sqlDataReader["Address2"].ToString().Trim();
                    addressObject.AddressCity = sqlDataReader["AddressCity"].ToString().Trim();
                    addressObject.AddressState = sqlDataReader["AddressState"].ToString().Trim();
                    addressObject.AddressPostalCode = sqlDataReader["AddressPostalCode"].ToString().Trim();
                    addressObject.AddressEmail = sqlDataReader["AddressEmail"].ToString().Trim();
                    addressObject.AddressTel1 = sqlDataReader["AddressTel1"].ToString().Trim();
                    addressObject.AddressTel2 = sqlDataReader["AddressTel2"].ToString().Trim();
                    addressObject.AddressFax = sqlDataReader["AddressFax"].ToString().Trim();
                }
                return addressObject;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                AddressObject addressObject = new AddressObject();
                return addressObject;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_Update_DeliveryManifest(int RouteNumber, DeliveryManifest deliveryManifest)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Update_DeliveryManifest";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);
                cmd.Parameters.Add("@Bill100", SqlDbType.Decimal);
                cmd.Parameters.Add("@Bill50", SqlDbType.Decimal);
                cmd.Parameters.Add("@Bill20", SqlDbType.Decimal);
                cmd.Parameters.Add("@Bill10", SqlDbType.Decimal);
                cmd.Parameters.Add("@Bill5", SqlDbType.Decimal);
                cmd.Parameters.Add("@Bill2", SqlDbType.Decimal);
                cmd.Parameters.Add("@Bill1", SqlDbType.Decimal);
                cmd.Parameters.Add("@Coins", SqlDbType.Decimal);
                cmd.Parameters.Add("@Park", SqlDbType.Decimal);
                cmd.Parameters.Add("@Gas", SqlDbType.Decimal);
                cmd.Parameters.Add("@Toll", SqlDbType.Decimal);
                cmd.Parameters.Add("@Misc", SqlDbType.Decimal);

                cmd.Parameters["@RouteNumber"].Value = RouteNumber;
                cmd.Parameters["@Bill100"].Value = deliveryManifest.Bill100;
                cmd.Parameters["@Bill50"].Value = deliveryManifest.Bill50;
                cmd.Parameters["@Bill20"].Value = deliveryManifest.Bill20;
                cmd.Parameters["@Bill10"].Value = deliveryManifest.Bill10;
                cmd.Parameters["@Bill5"].Value = deliveryManifest.Bill5;
                cmd.Parameters["@Bill2"].Value = deliveryManifest.Bill2;
                cmd.Parameters["@Bill1"].Value = deliveryManifest.Bill1;
                cmd.Parameters["@Coins"].Value = deliveryManifest.Coins;
                cmd.Parameters["@Park"].Value = deliveryManifest.Park;
                cmd.Parameters["@Gas"].Value = deliveryManifest.Gas;
                cmd.Parameters["@Toll"].Value = deliveryManifest.Toll;
                cmd.Parameters["@Misc"].Value = deliveryManifest.Misc;

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public string sp_UPDATE_ProductInfo(ProductObject productObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_ProductInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@Category", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@Brand", SqlDbType.VarChar);
                cmd.Parameters.Add("@Pause", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductDesc", SqlDbType.VarChar);
                cmd.Parameters.Add("@Pack", SqlDbType.VarChar);
                cmd.Parameters.Add("@Size", SqlDbType.VarChar);
                cmd.Parameters.Add("@Unit", SqlDbType.VarChar);
                cmd.Parameters.Add("@PackSize", SqlDbType.VarChar);
                cmd.Parameters.Add("@SalesUnit", SqlDbType.VarChar);
                cmd.Parameters.Add("@SalesListPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@SalesBottomPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@ShelfLife", SqlDbType.VarChar);
                cmd.Parameters.Add("@GuaranteeDay", SqlDbType.Int);
                cmd.Parameters.Add("@PurchaseUnit", SqlDbType.VarChar);
                cmd.Parameters.Add("@PurchaseStockConversionQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@PalletTier", SqlDbType.Decimal);
                cmd.Parameters.Add("@PalletHeight", SqlDbType.Decimal);
                cmd.Parameters.Add("@BasePrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@PickName", SqlDbType.VarChar);
                cmd.Parameters.Add("@PickUPC", SqlDbType.VarChar);
                cmd.Parameters.Add("@PieceUPC", SqlDbType.VarChar);
                cmd.Parameters.Add("@BoxUPC", SqlDbType.VarChar);
                cmd.Parameters.Add("@MasterUPC", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceivingUPC", SqlDbType.VarChar);
                cmd.Parameters.Add("@CommissionCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@IncentiveCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOCID", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOCID2", SqlDbType.VarChar);
                cmd.Parameters.Add("@SubPickZone", SqlDbType.VarChar);
                cmd.Parameters.Add("@KosherLabel", SqlDbType.VarChar);
                cmd.Parameters.Add("@Organic", SqlDbType.VarChar);
                cmd.Parameters.Add("@Vegan", SqlDbType.VarChar);
                cmd.Parameters.Add("@GlutenFree", SqlDbType.VarChar);
                cmd.Parameters.Add("@NonGMO", SqlDbType.VarChar);
                cmd.Parameters.Add("@Kosher", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheeseNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReturnMessage", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cmd.Parameters["@ProductKey"].Value = productObject.ProductKey;
                cmd.Parameters["@Category"].Value = productObject.CdPackDeptTypeCode;
                cmd.Parameters["@ProductStatus"].Value = productObject.IsInActive;
                cmd.Parameters["@Brand"].Value = productObject.Brand;
                cmd.Parameters["@Pause"].Value = productObject.FlgPause;
                cmd.Parameters["@ProductDesc"].Value = productObject.ProductDesc;
                cmd.Parameters["@Pack"].Value = productObject.ItemPack;
                cmd.Parameters["@Size"].Value = productObject.ItemSize;
                cmd.Parameters["@Unit"].Value = productObject.ItemSizeUnit;
                cmd.Parameters["@PackSize"].Value = productObject.StrPackSize;
                cmd.Parameters["@SalesUnit"].Value = productObject.SalesUnit;
                cmd.Parameters["@SalesListPrice"].Value = productObject.UnitPr;
                cmd.Parameters["@SalesBottomPrice"].Value = productObject.BottomPr;
                cmd.Parameters["@ShelfLife"].Value = productObject.ShelfLife;
                cmd.Parameters["@GuaranteeDay"].Value = productObject.GuaranteeDay;
                cmd.Parameters["@PurchaseUnit"].Value = productObject.PurchaseUnit;
                cmd.Parameters["@PurchaseStockConversionQty"].Value = productObject.StockConversionQty;
                cmd.Parameters["@PalletTier"].Value = productObject.PalletTier;
                cmd.Parameters["@PalletHeight"].Value = productObject.PalletHeight;
                cmd.Parameters["@BasePrice"].Value = productObject.BasePrice;
                cmd.Parameters["@PickName"].Value = productObject.PickName;
                cmd.Parameters["@PickUPC"].Value = productObject.PickBarCode;
                cmd.Parameters["@PieceUPC"].Value = productObject.UPCUnit;
                cmd.Parameters["@BoxUPC"].Value = productObject.UPCBox;
                cmd.Parameters["@MasterUPC"].Value = productObject.UPCCase;
                cmd.Parameters["@ReceivingUPC"].Value = productObject.ReceivingUPC;
                cmd.Parameters["@CommissionCode"].Value = productObject.CommissionCode1;
                cmd.Parameters["@IncentiveCode"].Value = productObject.IncentiveCode1;
                cmd.Parameters["@LOCID"].Value = productObject.LOCID;
                cmd.Parameters["@LOCID2"].Value = productObject.LOCID2;
                cmd.Parameters["@SubPickZone"].Value = productObject.SubPickZone;
                cmd.Parameters["@KosherLabel"].Value = productObject.KosherLabel1;
                cmd.Parameters["@Organic"].Value = productObject.Organic;
                cmd.Parameters["@Vegan"].Value = productObject.Vegan;
                cmd.Parameters["@GlutenFree"].Value = productObject.GlutenFree;
                cmd.Parameters["@NonGMO"].Value = productObject.NonGMO;
                cmd.Parameters["@Kosher"].Value = productObject.Kosher;
                cmd.Parameters["@CheeseNumber"].Value = productObject.CheeseNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();

                string ReturnMessage = cmd.Parameters["@ReturnMessage"].Value.ToString();
                return ReturnMessage;

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_UPDATE_SupplierInfo(SupplierObject supplierObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_SupplierInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierName", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierCategory", SqlDbType.VarChar);
                cmd.Parameters.Add("@PaymentTerm", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipVia", SqlDbType.VarChar);

                cmd.Parameters["@SupplierCode"].Value = supplierObject.SupplierCode;
                cmd.Parameters["@SupplierName"].Value = supplierObject.SupplierName;
                cmd.Parameters["@SupplierStatus"].Value = supplierObject.SupplierStatus;
                cmd.Parameters["@SupplierCategory"].Value = supplierObject.SupplierCategory;
                cmd.Parameters["@PaymentTerm"].Value = supplierObject.PaymentTerm;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@ShipVia"].Value = supplierObject.ShipVia;

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_UPDATE_CustomerInfo(CustomerObject customerObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_CustomerInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerName", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerBranch", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerSalesRep", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerTaxID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerPaymentTerm", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerBillingCompanyName", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerPickingMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerNutMarkup", SqlDbType.Decimal);
                cmd.Parameters.Add("@NutMarkupPrintName", SqlDbType.Int);
                cmd.Parameters.Add("@LabelType", SqlDbType.VarChar);
                cmd.Parameters.Add("@NutMarkupByMarkup", SqlDbType.Int);
                cmd.Parameters.Add("@NutMarkupByCustomerPrice", SqlDbType.Int);
                cmd.Parameters.Add("@NutMarkupShowRetailPrice", SqlDbType.Int);
                cmd.Parameters.Add("@NutMarkupPrintAddress", SqlDbType.Int);
                cmd.Parameters.Add("@NutMarkupCustomLabel", SqlDbType.Int);
                cmd.Parameters.Add("@PCKStoreName", SqlDbType.VarChar);
                cmd.Parameters.Add("@PCKAddress1", SqlDbType.VarChar);
                cmd.Parameters.Add("@PCKAddress2", SqlDbType.VarChar);
                cmd.Parameters.Add("@PCKCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@PCKState", SqlDbType.VarChar);
                cmd.Parameters.Add("@PCKZIP", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = customerObject.CustomerID;
                cmd.Parameters["@CustomerName"].Value = customerObject.CustomerName;
                cmd.Parameters["@CustomerStatus"].Value = customerObject.CustomerStatus;
                cmd.Parameters["@CustomerBranch"].Value = customerObject.CustomerBranch;
                cmd.Parameters["@CustomerSalesRep"].Value = customerObject.CustomerSalesRep;
                cmd.Parameters["@CustomerTaxID"].Value = customerObject.CustomerTaxID;
                cmd.Parameters["@CustomerPaymentTerm"].Value = customerObject.CustomerPaymentTerm;
                cmd.Parameters["@CustomerBillingCompanyName"].Value = customerObject.CustomerBillingCompanyName;
                cmd.Parameters["@CustomerPickingMemo"].Value = customerObject.CustomerPickingMemo;
                cmd.Parameters["@CustomerMemo"].Value = customerObject.CustomerMemo;
                cmd.Parameters["@LabelType"].Value = customerObject.LabelType;
                cmd.Parameters["@CustomerNutMarkup"].Value = customerObject.CustomerNutMarkup;
                cmd.Parameters["@NutMarkupPrintName"].Value = customerObject.NutMarkupPrintName;
                cmd.Parameters["@NutMarkupByMarkup"].Value = customerObject.NutMarkupByMarkup;
                cmd.Parameters["@NutMarkupByCustomerPrice"].Value = customerObject.NutMarkupByCustomerPrice;
                cmd.Parameters["@NutMarkupShowRetailPrice"].Value = customerObject.NutMarkupShowRetailPrice;
                cmd.Parameters["@NutMarkupPrintAddress"].Value = customerObject.NutMarkupPrintAddress;
                cmd.Parameters["@NutMarkupCustomLabel"].Value = customerObject.NutMarkupCustomLabel;
                cmd.Parameters["@PCKStoreName"].Value = customerObject.PCKStoreName;
                cmd.Parameters["@PCKAddress1"].Value = customerObject.PCKAddress1;
                cmd.Parameters["@PCKAddress2"].Value = customerObject.PCKAddress2;
                cmd.Parameters["@PCKCity"].Value = customerObject.PCKCity;
                cmd.Parameters["@PCKState"].Value = customerObject.PCKState;
                cmd.Parameters["@PCKZIP"].Value = customerObject.PCKZIP;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                
                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_UPDATE_CompanyInfo(CompanyObject companyObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_CompanyInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyPhone", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyFax", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyEmail", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyWebsite", SqlDbType.VarChar);
                cmd.Parameters.Add("@PayrollContact", SqlDbType.VarChar);
                cmd.Parameters.Add("@PayrollTitle", SqlDbType.VarChar);
                cmd.Parameters.Add("@PayrollPhone", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CompanyCode"].Value = companyObject.CompanyCode;
                cmd.Parameters["@CompanyStatus"].Value = companyObject.CompanyStatus;
                cmd.Parameters["@CompanyPhone"].Value = companyObject.CompanyPhone;
                cmd.Parameters["@CompanyFax"].Value = companyObject.CompanyFax;
                cmd.Parameters["@CompanyEmail"].Value = companyObject.CompanyEmail;
                cmd.Parameters["@CompanyWebsite"].Value = companyObject.CompanyWebsite;
                cmd.Parameters["@PayrollContact"].Value = companyObject.PayrollContact;
                cmd.Parameters["@PayrollTitle"].Value = companyObject.PayrollTitle;
                cmd.Parameters["@PayrollPhone"].Value = companyObject.PayrollPhone;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_UPDATE_AddressInfo(AddressObject addressObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_AddressInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ROWID", SqlDbType.Int);
                cmd.Parameters.Add("@AddressCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Address1", SqlDbType.VarChar);
                cmd.Parameters.Add("@Address2", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressState", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressPostalCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressEmail", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressTel1", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressTel2", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressFax", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@ROWID"].Value = Convert.ToInt32(addressObject.ROWID);
                cmd.Parameters["@AddressCode"].Value = addressObject.AddressCode;
                cmd.Parameters["@Address1"].Value = addressObject.Address1;
                cmd.Parameters["@Address2"].Value = addressObject.Address2;
                cmd.Parameters["@AddressCity"].Value = addressObject.AddressCity;
                cmd.Parameters["@AddressState"].Value = addressObject.AddressState;
                cmd.Parameters["@AddressPostalCode"].Value = addressObject.AddressPostalCode;
                cmd.Parameters["@AddressEmail"].Value = addressObject.AddressEmail;
                cmd.Parameters["@AddressTel1"].Value = addressObject.AddressTel1;
                cmd.Parameters["@AddressTel2"].Value = addressObject.AddressTel2;
                cmd.Parameters["@AddressFax"].Value = addressObject.AddressFax;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_INSERT_NewProduct(ProductObject productObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INSERT_NewProduct";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@Category", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@Brand", SqlDbType.VarChar);
                cmd.Parameters.Add("@Pause", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductDesc", SqlDbType.VarChar);
                cmd.Parameters.Add("@Pack", SqlDbType.VarChar);
                cmd.Parameters.Add("@Size", SqlDbType.VarChar);
                cmd.Parameters.Add("@Unit", SqlDbType.VarChar);
                cmd.Parameters.Add("@PackSize", SqlDbType.VarChar);
                cmd.Parameters.Add("@SalesUnit", SqlDbType.VarChar);
                cmd.Parameters.Add("@SalesListPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@SalesBottomPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@ShelfLife", SqlDbType.VarChar);
                cmd.Parameters.Add("@GuaranteeDay", SqlDbType.Int);
                cmd.Parameters.Add("@PurchaseUnit", SqlDbType.VarChar);
                cmd.Parameters.Add("@PurchaseStockConversionQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@PalletTier", SqlDbType.Decimal);
                cmd.Parameters.Add("@PalletHeight", SqlDbType.Decimal);
                cmd.Parameters.Add("@BasePrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@PickName", SqlDbType.VarChar);
                cmd.Parameters.Add("@PickUPC", SqlDbType.VarChar);
                cmd.Parameters.Add("@PieceUPC", SqlDbType.VarChar);
                cmd.Parameters.Add("@BoxUPC", SqlDbType.VarChar);
                cmd.Parameters.Add("@MasterUPC", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceivingUPC", SqlDbType.VarChar);
                cmd.Parameters.Add("@CommissionCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@IncentiveCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOCID", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOCID2", SqlDbType.VarChar);
                cmd.Parameters.Add("@SubPickZone", SqlDbType.VarChar);
                cmd.Parameters.Add("@KosherLabel", SqlDbType.VarChar);
                cmd.Parameters.Add("@Organic", SqlDbType.VarChar);
                cmd.Parameters.Add("@Vegan", SqlDbType.VarChar);
                cmd.Parameters.Add("@GlutenFree", SqlDbType.VarChar);
                cmd.Parameters.Add("@NonGMO", SqlDbType.VarChar);
                cmd.Parameters.Add("@Kosher", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheeseNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@PCKName1", SqlDbType.VarChar);
                cmd.Parameters.Add("@PCKName2", SqlDbType.VarChar);
                cmd.Parameters.Add("@PCKUPC", SqlDbType.VarChar);
                cmd.Parameters.Add("@PCKContSize", SqlDbType.VarChar);
                cmd.Parameters.Add("@PCKNetOZ", SqlDbType.VarChar);
                cmd.Parameters.Add("@PCKNetLB", SqlDbType.VarChar);
                cmd.Parameters.Add("@PCKIngredient", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@Category"].Value = productObject.CdPackDeptTypeCode;
                cmd.Parameters["@ProductStatus"].Value = productObject.IsInActive;
                cmd.Parameters["@Brand"].Value = productObject.Brand;
                cmd.Parameters["@Pause"].Value = productObject.FlgPause;
                cmd.Parameters["@ProductID"].Value = productObject.ProductID;
                cmd.Parameters["@ProductDesc"].Value = productObject.ProductDesc;
                cmd.Parameters["@Pack"].Value = productObject.ItemPack;
                cmd.Parameters["@Size"].Value = productObject.ItemSize;
                cmd.Parameters["@Unit"].Value = productObject.ItemSizeUnit;
                cmd.Parameters["@PackSize"].Value = productObject.StrPackSize;
                cmd.Parameters["@SalesUnit"].Value = productObject.SalesUnit;
                cmd.Parameters["@SalesListPrice"].Value = productObject.UnitPr;
                cmd.Parameters["@SalesBottomPrice"].Value = productObject.BottomPr;
                cmd.Parameters["@ShelfLife"].Value = productObject.ShelfLife;
                cmd.Parameters["@GuaranteeDay"].Value = productObject.GuaranteeDay;
                cmd.Parameters["@PurchaseUnit"].Value = productObject.PurchaseUnit;
                cmd.Parameters["@PurchaseStockConversionQty"].Value = productObject.StockConversionQty;
                cmd.Parameters["@PalletTier"].Value = productObject.PalletTier;
                cmd.Parameters["@PalletHeight"].Value = productObject.PalletHeight;
                cmd.Parameters["@BasePrice"].Value = productObject.BasePrice;
                cmd.Parameters["@PickName"].Value = productObject.PickName;
                cmd.Parameters["@PickUPC"].Value = productObject.PickBarCode;
                cmd.Parameters["@PieceUPC"].Value = productObject.UPCUnit;
                cmd.Parameters["@BoxUPC"].Value = productObject.UPCBox;
                cmd.Parameters["@MasterUPC"].Value = productObject.UPCCase;
                cmd.Parameters["@ReceivingUPC"].Value = productObject.ReceivingUPC;
                cmd.Parameters["@CommissionCode"].Value = productObject.CommissionCode1;
                cmd.Parameters["@IncentiveCode"].Value = productObject.IncentiveCode1;
                cmd.Parameters["@LOCID"].Value = productObject.LOCID;
                cmd.Parameters["@LOCID2"].Value = productObject.LOCID2;
                cmd.Parameters["@SubPickZone"].Value = productObject.SubPickZone;
                cmd.Parameters["@KosherLabel"].Value = productObject.KosherLabel1;
                cmd.Parameters["@Organic"].Value = productObject.Organic;
                cmd.Parameters["@Vegan"].Value = productObject.Vegan;
                cmd.Parameters["@GlutenFree"].Value = productObject.GlutenFree;
                cmd.Parameters["@NonGMO"].Value = productObject.NonGMO;
                cmd.Parameters["@Kosher"].Value = productObject.Kosher;
                cmd.Parameters["@CheeseNumber"].Value = productObject.CheeseNumber;
                cmd.Parameters["@PCKName1"].Value = productObject.PCKName1;
                cmd.Parameters["@PCKName2"].Value = productObject.PCKName2;
                cmd.Parameters["@PCKUPC"].Value = productObject.PCKUPC;
                cmd.Parameters["@PCKContSize"].Value = productObject.PCKContSize;
                cmd.Parameters["@PCKNetOZ"].Value = productObject.PCKNetOZ;
                cmd.Parameters["@PCKNetLB"].Value = productObject.PCKNetLB;
                cmd.Parameters["@PCKIngredient"].Value = productObject.PCKIngredient;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_INSERT_NewSupplier(SupplierObject supplierObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INSERT_NewSupplier";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierName", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierCategory", SqlDbType.VarChar);
                cmd.Parameters.Add("@PaymentTerm", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@SupplierCode"].Value = supplierObject.SupplierCode;
                cmd.Parameters["@SupplierName"].Value = supplierObject.SupplierName;
                cmd.Parameters["@SupplierStatus"].Value = supplierObject.SupplierStatus;
                cmd.Parameters["@SupplierCategory"].Value = supplierObject.SupplierCategory;
                cmd.Parameters["@PaymentTerm"].Value = supplierObject.PaymentTerm;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_INSERT_NewCustomer(CustomerObject customerObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INSERT_NewCustomer";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerName", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerBranch", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerSalesRep", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerTaxID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerPaymentTerm", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerBillingCompanyName", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerPickingMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@LabelType", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerNutMarkup", SqlDbType.Decimal);
                cmd.Parameters.Add("@NutMarkupPrintName", SqlDbType.Int);
                cmd.Parameters.Add("@NutMarkupByMarkup", SqlDbType.Int);
                cmd.Parameters.Add("@NutMarkupByCustomerPrice", SqlDbType.Int);
                cmd.Parameters.Add("@NutMarkupShowRetailPrice", SqlDbType.Int);
                cmd.Parameters.Add("@NutMarkupPrintAddress", SqlDbType.Int);
                cmd.Parameters.Add("@NutMarkupCustomLabel", SqlDbType.Int);
                cmd.Parameters.Add("@StoreName", SqlDbType.VarChar);
                cmd.Parameters.Add("@StoreAddress1", SqlDbType.VarChar);
                cmd.Parameters.Add("@StoreAddress2", SqlDbType.VarChar);
                cmd.Parameters.Add("@StoreCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@StoreState", SqlDbType.VarChar);
                cmd.Parameters.Add("@StoreZip", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = customerObject.CustomerID;
                cmd.Parameters["@CustomerName"].Value = customerObject.CustomerName;
                cmd.Parameters["@CustomerStatus"].Value = customerObject.CustomerStatus;
                cmd.Parameters["@CustomerBranch"].Value = customerObject.CustomerBranch;
                cmd.Parameters["@CustomerSalesRep"].Value = customerObject.CustomerSalesRep;
                cmd.Parameters["@CustomerTaxID"].Value = customerObject.CustomerTaxID;
                cmd.Parameters["@CustomerPaymentTerm"].Value = customerObject.CustomerPaymentTerm;
                cmd.Parameters["@CustomerBillingCompanyName"].Value = customerObject.CustomerBillingCompanyName;
                cmd.Parameters["@CustomerPickingMemo"].Value = customerObject.CustomerPickingMemo;
                cmd.Parameters["@CustomerMemo"].Value = customerObject.CustomerMemo;
                cmd.Parameters["@LabelType"].Value = customerObject.LabelType;
                cmd.Parameters["@CustomerNutMarkup"].Value = customerObject.CustomerNutMarkup;
                cmd.Parameters["@NutMarkupPrintName"].Value = customerObject.NutMarkupPrintName;
                cmd.Parameters["@NutMarkupByMarkup"].Value = customerObject.NutMarkupByMarkup;
                cmd.Parameters["@NutMarkupByCustomerPrice"].Value = customerObject.NutMarkupByCustomerPrice;
                cmd.Parameters["@NutMarkupShowRetailPrice"].Value = customerObject.NutMarkupShowRetailPrice;
                cmd.Parameters["@NutMarkupPrintAddress"].Value = customerObject.NutMarkupPrintAddress;
                cmd.Parameters["@NutMarkupCustomLabel"].Value = customerObject.NutMarkupCustomLabel;
                cmd.Parameters["@StoreName"].Value = customerObject.PCKStoreName;
                cmd.Parameters["@StoreAddress1"].Value = customerObject.PCKAddress1;
                cmd.Parameters["@StoreAddress2"].Value = customerObject.PCKAddress2;
                cmd.Parameters["@StoreCity"].Value = customerObject.PCKCity;
                cmd.Parameters["@StoreState"].Value = customerObject.PCKState;
                cmd.Parameters["@StoreZip"].Value = customerObject.PCKZIP;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_INSERT_NewCompany(CompanyObject companyObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INSERT_NewCompany";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CompanyStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyAddress", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyCountry", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyPhone", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyFax", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyEmail", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyWebsite", SqlDbType.VarChar);
                cmd.Parameters.Add("@LegalName", SqlDbType.VarChar);
                cmd.Parameters.Add("@LegalAddress1", SqlDbType.VarChar);
                cmd.Parameters.Add("@LegalAddress2", SqlDbType.VarChar);
                cmd.Parameters.Add("@LegalCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@LegalState", SqlDbType.VarChar);
                cmd.Parameters.Add("@LegalZIP", SqlDbType.VarChar);
                cmd.Parameters.Add("@LegalCountry", SqlDbType.VarChar);
                cmd.Parameters.Add("@FiscalYear", SqlDbType.VarChar);
                cmd.Parameters.Add("@TaxYear", SqlDbType.VarChar);
                cmd.Parameters.Add("@IncomeTaxFormUsed", SqlDbType.VarChar);
                cmd.Parameters.Add("@FEIN", SqlDbType.VarChar);
                cmd.Parameters.Add("@SSN", SqlDbType.VarChar);
                cmd.Parameters.Add("@PayrollContact", SqlDbType.VarChar);
                cmd.Parameters.Add("@PayrollTitle", SqlDbType.VarChar);
                cmd.Parameters.Add("@PayrollPhone", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CompanyStatus"].Value = companyObject.CompanyStatus;
                cmd.Parameters["@CompanyCode"].Value = companyObject.CompanyCode;
                cmd.Parameters["@CompanyName"].Value = companyObject.CompanyName;
                cmd.Parameters["@CompanyAddress"].Value = companyObject.CompanyAddress;
                cmd.Parameters["@CompanyCountry"].Value = companyObject.CompanyCountry;
                cmd.Parameters["@CompanyPhone"].Value = companyObject.CompanyPhone;
                cmd.Parameters["@CompanyFax"].Value = companyObject.CompanyFax;
                cmd.Parameters["@CompanyEmail"].Value = companyObject.CompanyEmail;
                cmd.Parameters["@CompanyWebsite"].Value = companyObject.CompanyWebsite;
                cmd.Parameters["@LegalName"].Value = companyObject.LegalName;
                cmd.Parameters["@LegalAddress1"].Value = companyObject.LegalAddress1;
                cmd.Parameters["@LegalAddress2"].Value = companyObject.LegalAddress2;
                cmd.Parameters["@LegalCity"].Value = companyObject.LegalCity;
                cmd.Parameters["@LegalState"].Value = companyObject.LegalState;
                cmd.Parameters["@LegalZIP"].Value = companyObject.LegalZIP;
                cmd.Parameters["@LegalCountry"].Value = companyObject.LegalCountry;
                cmd.Parameters["@FiscalYear"].Value = companyObject.FiscalYear;
                cmd.Parameters["@TaxYear"].Value = companyObject.TaxYear;
                cmd.Parameters["@IncomeTaxFormUsed"].Value = companyObject.IncomeTaxFormUsed;
                cmd.Parameters["@FEIN"].Value = companyObject.FEIN;
                cmd.Parameters["@SSN"].Value = companyObject.SSN;
                cmd.Parameters["@PayrollContact"].Value = companyObject.PayrollContact;
                cmd.Parameters["@PayrollTitle"].Value = companyObject.PayrollTitle;
                cmd.Parameters["@PayrollPhone"].Value = companyObject.PayrollPhone;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public string sp_INSERT_NewSupplierAddress(AddressObject addressObject, String ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INSERT_NewSupplierAddress";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Address1", SqlDbType.VarChar);
                cmd.Parameters.Add("@Address2", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressState", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressPostalCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressEmail", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressTel1", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressTel2", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressFax", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@Result", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@ID"].Value = ID;
                cmd.Parameters["@AddressCode"].Value = addressObject.AddressCode;
                cmd.Parameters["@Address1"].Value = addressObject.Address1;
                cmd.Parameters["@Address2"].Value = addressObject.Address2;
                cmd.Parameters["@AddressCity"].Value = addressObject.AddressCity;
                cmd.Parameters["@AddressState"].Value = addressObject.AddressState;
                cmd.Parameters["@AddressPostalCode"].Value = addressObject.AddressPostalCode;
                cmd.Parameters["@AddressEmail"].Value = addressObject.AddressEmail;
                cmd.Parameters["@AddressTel1"].Value = addressObject.AddressTel1;
                cmd.Parameters["@AddressTel2"].Value = addressObject.AddressTel2;
                cmd.Parameters["@AddressFax"].Value = addressObject.AddressFax;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();

                string Result = cmd.Parameters["@Result"].Value.ToString();
                return Result;

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_UPDATE_BrandInfo(String BrandCode, String BrandName, int LeadTime, String BrandStatus, String BrandMemo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_BrandInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@BrandName", SqlDbType.VarChar);
                cmd.Parameters.Add("@LeadTime", SqlDbType.Int);
                cmd.Parameters.Add("@BrandStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@BrandMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                
                cmd.Parameters["@BrandCode"].Value = BrandCode;
                cmd.Parameters["@BrandName"].Value = BrandName;
                cmd.Parameters["@LeadTime"].Value = LeadTime;
                cmd.Parameters["@BrandStatus"].Value = BrandStatus;
                cmd.Parameters["@BrandMemo"].Value = BrandMemo;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
            
                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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


        static public void sp_GET_PickingList(DataGridView _dataGridView, String RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_PickingList";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);

                cmd.Parameters["@RouteNumber"].Value = RouteNumber;

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

        static public void sp_SHIPMENTRETURN_SELECT_RETURN(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_SHIPMENTRETURN_SELECT_RETURN";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);

                //cmd.Parameters["@RouteNumber"].Value = RouteNumber;

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

        static public void sp_STOCKCHANGE_STOCK_SELECT(DataGridView _dataGridView, String ItemID, String StorageSite)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_STOCKCHANGE_STOCK_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);
                cmd.Parameters.Add("@StorageSite", SqlDbType.VarChar);

                cmd.Parameters["@ItemID"].Value = ItemID;
                cmd.Parameters["@StorageSite"].Value = StorageSite;

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

        static public void sp_DISASSEMBLY_SELECT(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_DISASSEMBLY_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

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

        static public void sp_MANUFACTURING_SELECT(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_MANUFACTURING_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

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

        static public void sp_ENTRYBATCH_SELECT(DataGridView _dataGridView, String Date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ENTRYBATCH_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Date", SqlDbType.DateTime);
                
                cmd.Parameters["@Date"].Value = Date;
                
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

        static public void sp_ACCOUNT_CHARTOFACCOUNT(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ACCOUNT_CHARTOFACCOUNT";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@Date", SqlDbType.DateTime);

                //cmd.Parameters["@Date"].Value = Date;

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

        static public void sp_ACCOUNT_CHARTOFACCOUNT_DETAIL(DataGridView _dataGridView, String CompanyName, String Account, String FromDate, String ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_ACCOUNT_CHARTOFACCOUNT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar);
                cmd.Parameters.Add("@Account", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@CompanyName"].Value = CompanyName;
                cmd.Parameters["@Account"].Value = Account;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_ACCOUNT_GJE_HEADER(DataGridView _dataGridView, String EntryNumber, String FromDate, String ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_ACCOUNT_GJE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@EntryNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@EntryNumber"].Value = EntryNumber;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_ACCOUNT_GJE_DETAIL(DataGridView _dataGridView, String EntryNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_ACCOUNT_GJE_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@EntryNumber", SqlDbType.VarChar);

                cmd.Parameters["@EntryNumber"].Value = EntryNumber;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_ACCOUNT_CHARTOFACCOUNT_DETAIL2(DataGridView _dataGridView, String Account, String FromDate, String ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_ACCOUNT_CHARTOFACCOUNT_DETAIL2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Account", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@Account"].Value = Account;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_ENTRYBATCH_SELECT_DETAIL(DataGridView _dataGridView, String Date, String EntryBatch)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_ENTRYBATCH_SELECT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@EntryBatch", SqlDbType.VarChar);
                cmd.Parameters.Add("@Date", SqlDbType.DateTime);
                
                cmd.Parameters["@EntryBatch"].Value = EntryBatch;
                cmd.Parameters["@Date"].Value = Date;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_ASSEMBLY_SELECT(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ASSEMBLY_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

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

        static public void sp_SUBCONTRACT_SELECT(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_SUBCONTRACT_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_SUBCONTRACT_SELECT_TEMP(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_SUBCONTRACT_SELECT_TEMP";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@StorageSite", SqlDbType.VarChar);

                //cmd.Parameters["@ItemID"].Value = ItemID;
                //cmd.Parameters["@StorageSite"].Value = StorageSite;

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

        static public void sp_SUBCONTRACT_SELECT_DETAIL(DataGridView _dataGridView, String Number)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_SUBCONTRACT_SELECT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Number", SqlDbType.VarChar);
                //cmd.Parameters.Add("@StorageSite", SqlDbType.VarChar);

                cmd.Parameters["@Number"].Value = Number;
                //cmd.Parameters["@StorageSite"].Value = StorageSite;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_DISASSEMBLY_SELECT_DISASSEMBLED(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_DISASSEMBLY_SELECT_DISASSEMBLED";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

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

        static public void sp_MANUFACTURING_SELECT_DONE(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_MANUFACTURING_SELECT_DONE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

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

        static public void sp_ASSEMBLY_SELECT_ASSEMBLED(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ASSEMBLY_SELECT_ASSEMBLED";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

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

        static public void sp_DISASSEMBLED_SELECT(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_DISASSEMBLED_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@StorageSite", SqlDbType.VarChar);

                //cmd.Parameters["@ItemID"].Value = ItemID;
                //cmd.Parameters["@StorageSite"].Value = StorageSite;

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

        static public void sp_DISASSEMBLY_SELECT_TEMP(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_DISASSEMBLY_SELECT_TEMP";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@StorageSite", SqlDbType.VarChar);

                //cmd.Parameters["@ItemID"].Value = ItemID;
                //cmd.Parameters["@StorageSite"].Value = StorageSite;

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

        static public void sp_MANUFACTURING_SELECT_TEMP(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_MANUFACTURING_SELECT_TEMP";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@StorageSite", SqlDbType.VarChar);

                //cmd.Parameters["@ItemID"].Value = ItemID;
                //cmd.Parameters["@StorageSite"].Value = StorageSite;

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

        static public void sp_ASSEMBLY_SELECT_TEMP(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ASSEMBLY_SELECT_TEMP";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@StorageSite", SqlDbType.VarChar);

                //cmd.Parameters["@ItemID"].Value = ItemID;
                //cmd.Parameters["@StorageSite"].Value = StorageSite;

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

        static public void sp_RECEIPTRETURN_SELECT_LOT(DataGridView _dataGridView, String Company, String StorageSite, String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_RECEIPTRETURN_SELECT_LOT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Company", SqlDbType.VarChar);
                cmd.Parameters.Add("@StorageSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@Company"].Value = Company;
                cmd.Parameters["@StorageSite"].Value = StorageSite;
                cmd.Parameters["@ProductID"].Value = ProductID;

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

        static public void sp_RECEIPTRETURN_HEADER(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_RECEIPTRETURN_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;


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

        static public void sp_INTERSITETRANSFER_SELECT(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INTERSITETRANSFER_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;


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

        static public void sp_STOCKCHANGE_SELECT(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_STOCKCHANGE_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                //cmd.Parameters["@SupplierID"].Value = SupplierID;
                //cmd.Parameters["@ItemID"].Value = ItemID;

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

        static public void sp_POPREPARE_RECEIPTHISTORY(DataGridView _dataGridView, String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_POPREPARE_RECEIPTHISTORY";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;
                //cmd.Parameters["@ItemID"].Value = ItemID;

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

        static public void sp_POPREPARE_SALESHISTORY_WEEKLY(DataGridView _dataGridView, String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_POPREPARE_SALESHISTORY_WEEKLY";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;
                //cmd.Parameters["@ItemID"].Value = ItemID;

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

        static public void sp_POPREPARE_SALESHISTORY_MONTHLY(DataGridView _dataGridView, String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_POPREPARE_SALESHISTORY_MONTHLY";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;
                //cmd.Parameters["@ItemID"].Value = ItemID;

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

        static public void sp_POPREPARE_BRANDMEMO(DataGridView _dataGridView, String Brand)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_POPREPARE_BRANDMEMO";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Brand", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@Brand"].Value = Brand;
                //cmd.Parameters["@ItemID"].Value = ItemID;

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

        static public void sp_INTERSITETRANSFER_SELECT_DETAIL(DataGridView _dataGridView, String WHCHGNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_INTERSITETRANSFER_SELECT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@WHCHGNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@WHCHGNumber"].Value = WHCHGNumber;
                //cmd.Parameters["@ItemID"].Value = ItemID;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_STOCKCHANGE_SELECT_DETAIL(DataGridView _dataGridView, String BCSCHGNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_STOCKCHANGE_SELECT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BCSCHGNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@BCSCHGNumber"].Value = BCSCHGNumber;
                //cmd.Parameters["@ItemID"].Value = ItemID;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_DISASSEMBLY_SELECT_DETAIL(DataGridView _dataGridView, String DISNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_DISASSEMBLY_SELECT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@DISNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@DISNumber"].Value = DISNumber;
                //cmd.Parameters["@ItemID"].Value = ItemID;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_MANUFACTURING_SELECT_DETAIL(DataGridView _dataGridView, String BCSMTKNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_MANUFACTURING_SELECT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BCSMTKNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@BCSMTKNumber"].Value = BCSMTKNumber;
                //cmd.Parameters["@ItemID"].Value = ItemID;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_MANUFACTURING_SELECT_DETAIL_DONE(DataGridView _dataGridView, String BCSMTKNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_MANUFACTURING_SELECT_DETAIL_DONE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BCSMTKNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@BCSMTKNumber"].Value = BCSMTKNumber;
                //cmd.Parameters["@ItemID"].Value = ItemID;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_ASSEMBLY_SELECT_DETAIL(DataGridView _dataGridView, String ASMNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_ASSEMBLY_SELECT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ASMNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@ASMNumber"].Value = ASMNumber;
                //cmd.Parameters["@ItemID"].Value = ItemID;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_ASSEMBLYRECEIPT_SELECT_DETAIL(DataGridView _dataGridView, String ASMNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_ASSEMBLYRECEIPT_SELECT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ASMNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@ASMNumber"].Value = ASMNumber;
                //cmd.Parameters["@ItemID"].Value = ItemID;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_RECEIPTRETURN_DETAIL(DataGridView _dataGridView, String ReceiptReturnNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_RECEIPTRETURN_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ReceiptReturnNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@ReceiptReturnNumber"].Value = ReceiptReturnNumber;
                //cmd.Parameters["@ItemID"].Value = ItemID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public String sp_RECEIPTRETURN_INSERT_STOJOU(String NewBCSPRNNumber, String NewSTKNumber, String CompanyCode, String Site,
            String SupplierID, String LOTNumber, String ProductID, Decimal Qty, Decimal Line, String Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_RECEIPTRETURN_INSERT_STOJOU";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewBCSPRNNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOTNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Line", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);

                cmd.Parameters["@NewBCSPRNNumber"].Value = NewBCSPRNNumber;
                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;
                cmd.Parameters["@CompanyCode"].Value = CompanyCode;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@LOTNumber"].Value = LOTNumber;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@Memo"].Value = Memo;

                connection2.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_RECEIPTRETURN_INSERT_STOJOU \nDetail : " + exception.Message.ToString();
                return ErrorText;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_RECEIPTRETURN_UPDATE_BCSPRNNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_RECEIPTRETURN_UPDATE_BCSPRNNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public string sp_INTERSITETRANSFER_SAVE(String StorageSite, String DestinationSite, String NewWHCHGNumber, String ProductID, String LOTNumber,
           String Status, DateTime Expiration, Decimal Qty, Decimal Amount, int Line)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INTERSITETRANSFER_SAVE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@StorageSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@DestinationSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewWHCHGNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOTNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@Expiration", SqlDbType.DateTime);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@StorageSite"].Value = StorageSite;
                cmd.Parameters["@DestinationSite"].Value = DestinationSite;
                cmd.Parameters["@NewWHCHGNumber"].Value = NewWHCHGNumber;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@LOTNumber"].Value = LOTNumber;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@Expiration"].Value = Expiration;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();
                return "Success";

            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_INTERSITETRANSFER_SAVE \nDetail : " + exception.Message.ToString();
                return ErrorText;
            }
            finally
            {
                connection2.Close();
            }
        }
        static public string sp_INTERSITETRANSFER_SAVE_HEADER(String NewWHCHGNumber, String StorageSite, String DestinationSite, DateTime AccountingDate,
            String Description, String CompanyCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INTERSITETRANSFER_SAVE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewWHCHGNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@StorageSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@DestinationSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);


                cmd.Parameters["@NewWHCHGNumber"].Value = NewWHCHGNumber;
                cmd.Parameters["@StorageSite"].Value = StorageSite;
                cmd.Parameters["@DestinationSite"].Value = DestinationSite;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@Description"].Value = Description;
                cmd.Parameters["@CompanyCode"].Value = CompanyCode;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;



                connection2.Open();
                cmd.ExecuteNonQuery();
                return "Success";


            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_INTERSITETRANSFER_SAVE_HEADER \nDetail : " + exception.Message.ToString();
                return ErrorText;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_WMS_INTERSITETRANSFERS_CONFIRM_DETAIL(String WHCHGNumber,
                                                                    String ProductID,
                                                                    String ProductDesc,
                                                                    String Status,
                                                                    String SalesUnit,
                                                                    String PackSize,
                                                                    Decimal Qty,
                                                                    Decimal BasePrice,
                                                                    String Location,
                                                                    DateTime ExpirationDate,
                                                                    int DetailKey)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WMS_INTERSITETRANSFERS_CONFIRM_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@WHCHGNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductDesc", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@SalesUnit", SqlDbType.VarChar);
                cmd.Parameters.Add("@PackSize", SqlDbType.VarChar);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@BasePrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@Location", SqlDbType.VarChar);
                cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@DetailKey", SqlDbType.Int);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@WHCHGNumber"].Value = WHCHGNumber;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@ProductDesc"].Value = ProductDesc;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@SalesUnit"].Value = SalesUnit;
                cmd.Parameters["@PackSize"].Value = PackSize;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@BasePrice"].Value = BasePrice;
                cmd.Parameters["@Location"].Value = Location;
                cmd.Parameters["@ExpirationDate"].Value = ExpirationDate;
                cmd.Parameters["@DetailKey"].Value = DetailKey;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_WMS_INTERSITETRANSFERS_CONFIRM_HEADER(String WHCHGNumber, String StorageSite, String DestinationSite, DateTime AccountingDate, String Description)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WMS_INTERSITETRANSFERS_CONFIRM_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@WHCHGNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@StorageSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@DestinationSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@WHCHGNumber"].Value = WHCHGNumber;
                cmd.Parameters["@StorageSite"].Value = StorageSite;
                cmd.Parameters["@DestinationSite"].Value = DestinationSite;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@Description"].Value = Description;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_SHIPMENTRETURN_SELECT_RETURNDETAIL(DataGridView _dataGridView, String ReturnID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_SHIPMENTRETURN_SELECT_RETURNDETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ReturnID", SqlDbType.VarChar);

                cmd.Parameters["@ReturnID"].Value = ReturnID;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_SHIPMENTRETURN_SELECT_RETURNDETAIL_TEMP(DataGridView _dataGridView, String ReturnID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_SHIPMENTRETURN_SELECT_RETURNDETAIL_TEMP";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ReturnID", SqlDbType.VarChar);

                cmd.Parameters["@ReturnID"].Value = ReturnID;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public void sp_SHIPMENTRETURN_SELECT_RETURN_TEMP(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_SHIPMENTRETURN_SELECT_RETURN_TEMP";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);

                //cmd.Parameters["@RouteNumber"].Value = RouteNumber;

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
        

        static public void ZRT_RTTMPD_DELETE_TEMPNO(int TEMPNO)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = BCSX3connection;
                cmd.CommandText = "BCSX3.dbo.ZRT_RTTMPD_DELETE_TEMPNO";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@TEMPNO", SqlDbType.Int);

                cmd.Parameters["@TEMPNO"].Value = TEMPNO;

                BCSX3connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                BCSX3connection.Close();
            }
        }

        static public void sp_DELETE_RouteDetail(int RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_DELETE_RouteDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);

                cmd.Parameters["@RouteNumber"].Value = RouteNumber;

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

        static public void sp_RETURN_STOCK(String CustomerID, Decimal Line, Decimal ReturnQty, String AQR, DateTime ExpirationDate, String ProductID, String Memo, String CompanyCode, String Site)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_RETURN_STOCK";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Line", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReturnQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@AQR", SqlDbType.VarChar);
                cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@ReturnQty"].Value = ReturnQty;
                cmd.Parameters["@AQR"].Value = AQR;
                cmd.Parameters["@ExpirationDate"].Value = ExpirationDate;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@CompanyCode"].Value = CompanyCode;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_SHIPMENTRETURN_NOTRETURNED(String ReturnID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_SHIPMENTRETURN_NOTRETURNED";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ReturnID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                
                cmd.Parameters["@ReturnID"].Value = ReturnID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void ZRT_RTTMPD_CRUD(String ACTION, int TEMPNO, String MDL, String SOHNUM, String BPCNUM)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = BCSX3connection;
                cmd.CommandText = "BCSX3.dbo.ZRT_RTTMPD_CRUD";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ACTION", SqlDbType.VarChar);
                cmd.Parameters.Add("@TEMPNO", SqlDbType.Int);
                cmd.Parameters.Add("@MDL", SqlDbType.VarChar);
                cmd.Parameters.Add("@SOHNUM", SqlDbType.VarChar);
                cmd.Parameters.Add("@BPCNUM", SqlDbType.VarChar);

                cmd.Parameters["@ACTION"].Value = ACTION;
                cmd.Parameters["@TEMPNO"].Value = TEMPNO;
                cmd.Parameters["@MDL"].Value = MDL;
                cmd.Parameters["@SOHNUM"].Value = SOHNUM;
                cmd.Parameters["@BPCNUM"].Value = BPCNUM;
                
                BCSX3connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                BCSX3connection.Close();
            }
        }

        static public void sp_CRUD_RouteDetail(String ACTION, int RouteNumber, String RouteStop, String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CRUD_RouteDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ACTION", SqlDbType.VarChar);
                cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);
                cmd.Parameters.Add("@RouteStop", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@ACTION"].Value = ACTION;
                cmd.Parameters["@RouteNumber"].Value = RouteNumber;
                cmd.Parameters["@RouteStop"].Value = RouteStop;
                cmd.Parameters["@OrderID"].Value = OrderID;

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

        static public void sp_RETURN_RECEIVING_DETAIL(String ReturnID, String OrderID, String OrderDetailKey,
            String ProductID, Decimal OrderQty, Decimal Price, Decimal Amount, String AQR, DateTime Expiration, String Memo, String Remark)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_RETURN_RECEIVING_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ReturnID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDetailKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@Expiration", SqlDbType.DateTime);
                cmd.Parameters.Add("@AQR", SqlDbType.VarChar);
                cmd.Parameters.Add("@Remark", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@ReturnID"].Value = ReturnID;
                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@OrderDetailKey"].Value = OrderDetailKey;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@OrderQty"].Value = OrderQty;
                cmd.Parameters["@Price"].Value = Price;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@Expiration"].Value = Expiration;
                cmd.Parameters["@AQR"].Value = AQR;
                cmd.Parameters["@Remark"].Value = Remark;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_RETURN_RECEIVING(String ReturnID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_RETURN_RECEIVING";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ReturnID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@ReturnID"].Value = ReturnID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;


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

        static public void ZRT_RTTMPH_INSERT(String ZDRID, String ZTRID, DateTime ROUTEDATE, String PICKUP)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = BCSX3connection;
                cmd.CommandText = "BCSX3.dbo.ZRT_RTTMPH_INSERT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ZDRID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ZTRID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ROUTEDATE", SqlDbType.DateTime);
                cmd.Parameters.Add("@PICKUP", SqlDbType.VarChar);

                cmd.Parameters["@ZDRID"].Value = ZDRID;
                cmd.Parameters["@ZTRID"].Value = ZTRID;
                cmd.Parameters["@ROUTEDATE"].Value = ROUTEDATE.Date.ToShortDateString();
                cmd.Parameters["@PICKUP"].Value = PICKUP;

                SqlParameter par = cmd.CreateParameter();
                par.SourceVersion = DataRowVersion.Proposed;
                par.ParameterName = "@OUT_TEMPNO";
                par.SqlDbType = SqlDbType.Int;
                par.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(par);

                BCSX3connection.Open();
                cmd.ExecuteNonQuery();

                int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                BCSX3connection.Close();
            }
        }

        static public void sp_RouteHeader_INSERT(String DriverID, String TruckID, DateTime RouteDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_RouteHeader_INSERT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@DriverID", SqlDbType.VarChar);
                cmd.Parameters.Add("@TruckID", SqlDbType.VarChar);
                cmd.Parameters.Add("@RouteDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                
                cmd.Parameters["@DriverID"].Value = DriverID;
                cmd.Parameters["@TruckID"].Value = TruckID;
                cmd.Parameters["@RouteDate"].Value = RouteDate.Date.ToShortDateString();
                cmd.Parameters["@UserID"].Value = GATE.userID;
                
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

        static public string getZDRID(string Driver)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT A.IDENT2_0 ";
                sql = sql + "FROM x3v9.LIVE.ATEXTRA A ";
                sql = sql + "LEFT OUTER JOIN x3v9.LIVE.ATABDIV B  ON A.IDENT1_0= B.NUMTAB_0  AND IDENT2_0 = B.CODE_0 ";
                sql = sql + "LEFT OUTER JOIN ( ";
                sql = sql + "SELECT A.IDENT1_0, A.IDENT2_0, A.TEXTE_0 ";
                sql = sql + "FROM x3v9.LIVE.ATEXTRA A ";
                sql = sql + "WHERE A.LANGUE_0 = 'ENG' AND A.CODFIC_0 = 'ATABDIV' AND A.IDENT1_0 = 5000 AND A.ZONE_0 = 'SHODES' ";
                sql = sql + ") AA ON A.IDENT1_0 = AA.IDENT1_0 AND A.IDENT2_0 = AA.IDENT2_0 ";
                sql = sql + "WHERE A.LANGUE_0 = 'ENG' AND A.CODFIC_0 = 'ATABDIV' AND A.IDENT1_0 = 5000 AND A.ZONE_0 = 'LNGDES' AND AA.TEXTE_0 = 'T' AND A.TEXTE_0 = '"+ Driver + "' ";
                sql = sql + "";

                BCSX3connection.Open();
                SqlCommand cmd = new SqlCommand(sql, BCSX3connection);

                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string ZDRID = reader[0].ToString();
                    return ZDRID;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                BCSX3connection.Close();
            }
        }

        static public string getDriverID(string Driver)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT id ";
                sql = sql + "FROM Driver ";
                sql = sql + "WHERE driver = '" + Driver + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);

                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string DriverID = reader[0].ToString();
                    return DriverID;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getTruckID(string TruckPlateNumber)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT id ";
                sql = sql + "FROM Truck ";
                sql = sql + "WHERE truck = '" + TruckPlateNumber + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);

                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string TruckID = reader[0].ToString();
                    return TruckID;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getZTRID(string Truck)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT A.IDENT2_0 ";
                sql = sql + "FROM x3v9.LIVE.ATEXTRA A ";
                sql = sql + "LEFT OUTER JOIN x3v9.LIVE.ATABDIV B  ON A.IDENT1_0= B.NUMTAB_0  AND IDENT2_0 = B.CODE_0 ";
                sql = sql + "LEFT OUTER JOIN ( ";
                sql = sql + "SELECT A.IDENT1_0, A.IDENT2_0, A.TEXTE_0 ";
                sql = sql + "FROM x3v9.LIVE.ATEXTRA A ";
                sql = sql + "WHERE A.LANGUE_0 = 'ENG' AND A.CODFIC_0 = 'ATABDIV' AND A.IDENT1_0 = 5001 AND A.ZONE_0 = 'SHODES') AA ON A.IDENT1_0 = AA.IDENT1_0 AND A.IDENT2_0 = AA.IDENT2_0 ";
                sql = sql + "WHERE A.LANGUE_0 = 'ENG' AND A.CODFIC_0 = 'ATABDIV' AND A.IDENT1_0 = 5001 AND A.ZONE_0 = 'LNGDES' AND AA.TEXTE_0 = 'T' AND A.TEXTE_0 = '" + Truck + "' ";
                sql = sql + "";

                BCSX3connection.Open();
                SqlCommand cmd = new SqlCommand(sql, BCSX3connection);

                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string ZTRID = reader[0].ToString();
                    return ZTRID;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                BCSX3connection.Close();
            }
        }

        static public void ZRT_GET_ALLORDERS_NOT_PREPLN_V2(DataGridView _dataGridView, String CITYNAME)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = BCSX3connection;
                cmd.CommandText = "BCSX3.dbo.ZRT_GET_ALLORDERS_NOT_PREPLN_V2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CITYNAME", SqlDbType.VarChar);

                cmd.Parameters["@CITYNAME"].Value = CITYNAME;

                BCSX3connection.Open();

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
                BCSX3connection.Close();
            }
        }

        static public void sp_PreparationMap(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PreparationMap";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);

                cmd.Parameters["@UserID"].Value = GATE.userID;

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

        static public void sp_GET_ALLORDERS_NOT_PREPLN_VENDOR(DataGridView _dataGridView, String ShipCity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_ALLORDERS_NOT_PREPLN_VENDOR";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ShipCity", SqlDbType.VarChar);

                cmd.Parameters["@ShipCity"].Value = ShipCity;

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


        static public void sp_ROUTE_City(ComboBox cbo_city)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ROUTE_City";
                cmd.CommandType = CommandType.StoredProcedure;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string City = reader[0].ToString().Trim();
                    cbo_city.Items.Add(City);
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

        static public string getCreditAmount(string iPadOrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT CrAmt ";
                sql = sql + "FROM LEG.[BCS].[dbo].[SalesOrder]  ";
                sql = sql + "WHERE OrderID = '" + iPadOrderID + "' ";
                sql = sql + "";

                connection3.Open();
                SqlCommand cmd = new SqlCommand(sql, connection3);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CreditAmount = reader[0].ToString();
                    return CreditAmount;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection3.Close();
            }
        }

        static public string getCreditAmountFromOrder2(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT CreditAmount ";
                sql = sql + "FROM Order2  ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CreditAmount = reader[0].ToString();
                    return CreditAmount;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public iPadSalesOrder sp_Fetch_iPadSalesOrderInfo(String iPadOrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Fetch_iPadSalesOrderInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@iPadOrderID", SqlDbType.VarChar);

                cmd.Parameters["@iPadOrderID"].Value = iPadOrderID;

                connection2.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                iPadSalesOrder iPadSalesOrder = new iPadSalesOrder();

                if (sqlDataReader.Read())
                {
                    iPadSalesOrder.CdBranchCode = sqlDataReader["CdBranchCode"].ToString().Trim() ?? "";
                    //iPadSalesOrder.OrderID = iPadOrderID ?? "";
                    iPadSalesOrder.CustomerID = sqlDataReader["CustomerID"].ToString().Trim() ?? "";
                    iPadSalesOrder.CompanyName = sqlDataReader["CompanyName"].ToString().Trim() ?? "";
                    //iPadSalesOrder.TraderEntityKey = sqlDataReader["TraderEntityKey"].ToString().Trim() ?? "";
                   // iPadSalesOrder.BillAddressKey = sqlDataReader["BillAddressKey"].ToString().Trim() ?? "";
                    iPadSalesOrder.BillAddress1 = sqlDataReader["BillAddress1"].ToString().Trim() ?? "";
                    iPadSalesOrder.BillAddress2 = sqlDataReader["BillAddress2"].ToString().Trim() ?? "";
                    iPadSalesOrder.BillCityName = sqlDataReader["BillCityName"].ToString().Trim() ?? "";
                    //iPadSalesOrder.BillStateName = sqlDataReader["BillStateName"].ToString().Trim() ?? "";
                    iPadSalesOrder.BillStateCode = sqlDataReader["BillStateCode"].ToString().Trim() ?? "";
                    iPadSalesOrder.BillPostalCode = sqlDataReader["BillPostalCode"].ToString().Trim() ?? "";
                   // iPadSalesOrder.ShipAddressKey = sqlDataReader["ShipAddressKey"].ToString().Trim() ?? "";
                    iPadSalesOrder.ShipAddress1 = sqlDataReader["ShipAddress1"].ToString().Trim() ?? "";
                    iPadSalesOrder.ShipAddress2 = sqlDataReader["ShipAddress2"].ToString().Trim() ?? "";
                    iPadSalesOrder.ShipCityName = sqlDataReader["ShipCityName"].ToString().Trim() ?? "";
                    //iPadSalesOrder.ShipStateName = sqlDataReader["ShipStateName"].ToString().Trim() ?? "";
                    iPadSalesOrder.ShipStateCode = sqlDataReader["ShipStateCode"].ToString().Trim() ?? "";
                    iPadSalesOrder.ShipPostalCode = sqlDataReader["ShipPostalCode"].ToString().Trim() ?? "";
                    iPadSalesOrder.SaleRepID = sqlDataReader["SaleRepID"].ToString().Trim() ?? "";
                    //iPadSalesOrder.OrderDate = sqlDataReader["OrderDate"] == DBNull.Value ? (DateTime?)null : (DateTime?)sqlDataReader["OrderDate"];
                    iPadSalesOrder.OrderDate = Convert.ToDateTime(sqlDataReader["OrderDate"].ToString().Trim());
                    iPadSalesOrder.CrAmt = Convert.ToDecimal(sqlDataReader["CrAmt"].ToString().Trim());
                    //iPadSalesOrder.Amount = Convert.ToDecimal(sqlDataReader["Amount"].ToString().Trim());
                    iPadSalesOrder.OrdMemo = sqlDataReader["OrdMemo"].ToString().Trim() ?? "";
                    iPadSalesOrder.PaymentTermKey = sqlDataReader["PaymentTermKey"].ToString().Trim() ?? "";
                    iPadSalesOrder.TermName = sqlDataReader["TermName"].ToString().Trim() ?? "";
                    iPadSalesOrder.TermName = sqlDataReader["TermName"].ToString().Trim() ?? "";
                }
                return iPadSalesOrder;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                iPadSalesOrder iPadSalesOrder = new iPadSalesOrder();
                return iPadSalesOrder;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public Order2 sp_Fetch_Order2Info(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_Order2Info";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                Order2 order2 = new Order2();

                if (sqlDataReader.Read())
                {
                    order2.id = sqlDataReader["id"].ToString().Trim() ?? "";
                    order2.iPadOrderID = sqlDataReader["iPadOrderID"].ToString().Trim() ?? "";
                    order2.OrderID = sqlDataReader["OrderID"].ToString().Trim() ?? "";
                    order2.CreditAmount = sqlDataReader["CreditAmount"].ToString().Trim() ?? "";
                    order2.OrderDate = Convert.ToDateTime(sqlDataReader["OrderDate"].ToString().Trim());
                    order2.SaleRep = sqlDataReader["SaleRep"].ToString().Trim() ?? "";
                    order2.CustomerID = sqlDataReader["CustomerID"].ToString().Trim() ?? "";
                    order2.CustomerName = sqlDataReader["CustomerName"].ToString().Trim() ?? "";
                    order2.BillAddress1 = sqlDataReader["BillAddress1"].ToString().Trim() ?? "";
                    order2.BillAddress2 = sqlDataReader["BillAddress2"].ToString().Trim() ?? "";
                    order2.BillCity = sqlDataReader["BillCity"].ToString().Trim() ?? "";
                    order2.BillState = sqlDataReader["BillState"].ToString().Trim() ?? "";
                    order2.BillZip = sqlDataReader["BillZip"].ToString().Trim() ?? "";
                    order2.ShipAddress1 = sqlDataReader["ShipAddress1"].ToString().Trim() ?? "";
                    order2.ShipAddress2 = sqlDataReader["ShipAddress2"].ToString().Trim() ?? "";
                    order2.ShipCity = sqlDataReader["ShipCity"].ToString().Trim() ?? "";
                    order2.ShipState = sqlDataReader["ShipState"].ToString().Trim() ?? "";
                    order2.ShipZip = sqlDataReader["ShipZip"].ToString().Trim() ?? "";
                    order2.AuditMemo = sqlDataReader["AuditMemo"].ToString().Trim() ?? "";
                    order2.AuditConfirm = sqlDataReader["AuditConfirm"].ToString().Trim() ?? "";
                    order2.Branch = sqlDataReader["Branch"].ToString().Trim() ?? "";
                    order2.PaymentTermKey = sqlDataReader["PaymentTermKey"].ToString().Trim() ?? "";
                    order2.OrderStatus = sqlDataReader["OrderStatus"].ToString().Trim() ?? "";
                    order2.CreateUserID = sqlDataReader["CreateUserID"].ToString().Trim() ?? "";
                    order2.CreateTime = sqlDataReader["CreateTime"] == DBNull.Value ? (DateTime?)null : (DateTime?)sqlDataReader["CreateTime"];
                    order2.LastModUserID = sqlDataReader["LastModUserID"].ToString().Trim() ?? "";
                    order2.LastModTime = sqlDataReader["LastModTime"] == DBNull.Value ? Convert.ToDateTime("1900-01-01") : (DateTime?)sqlDataReader["LastModTime"];
                    order2.OrderMemo = sqlDataReader["OrderMemo"].ToString().Trim() ?? "";
                    order2.RouteNumber = Convert.ToInt32(sqlDataReader["RouteNumber"].ToString().Trim());
                    order2.RouteStop = sqlDataReader["RouteStop"].ToString().Trim() ?? "";
                    //order2.Amount = sqlDataReader["Amount"] == DBNull.Value ? Convert.ToDecimal("0") : Convert.ToDecimal(sqlDataReader["Amount"].ToString().Trim());
                }
                return order2;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                Order2 order2 = new Order2();
                return order2;
            }
            finally
            {
                connection.Close();
            }
        }

        static public Order2 sp_Fetch_DeliveryInfo(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_DeliveryInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                Order2 order2 = new Order2();

                if (sqlDataReader.Read())
                {
                    order2.id = sqlDataReader["id"].ToString().Trim() ?? "";
                    order2.iPadOrderID = sqlDataReader["iPadOrderID"].ToString().Trim() ?? "";
                    order2.OrderID = sqlDataReader["OrderID"].ToString().Trim() ?? "";
                    order2.DeliveryNumber = sqlDataReader["DeliveryNumber"].ToString().Trim() ?? "";
                    order2.CreditAmount = sqlDataReader["CreditAmount"].ToString().Trim() ?? "";
                    order2.OrderDate = Convert.ToDateTime(sqlDataReader["OrderDate"].ToString().Trim());
                    order2.SaleRep = sqlDataReader["SaleRep"].ToString().Trim() ?? "";
                    order2.CustomerID = sqlDataReader["CustomerID"].ToString().Trim() ?? "";
                    order2.CustomerName = sqlDataReader["CustomerName"].ToString().Trim() ?? "";
                    order2.BillAddress1 = sqlDataReader["BillAddress1"].ToString().Trim() ?? "";
                    order2.BillAddress2 = sqlDataReader["BillAddress2"].ToString().Trim() ?? "";
                    order2.BillCity = sqlDataReader["BillCity"].ToString().Trim() ?? "";
                    order2.BillState = sqlDataReader["BillState"].ToString().Trim() ?? "";
                    order2.BillZip = sqlDataReader["BillZip"].ToString().Trim() ?? "";
                    order2.ShipAddress1 = sqlDataReader["ShipAddress1"].ToString().Trim() ?? "";
                    order2.ShipAddress2 = sqlDataReader["ShipAddress2"].ToString().Trim() ?? "";
                    order2.ShipCity = sqlDataReader["ShipCity"].ToString().Trim() ?? "";
                    order2.ShipState = sqlDataReader["ShipState"].ToString().Trim() ?? "";
                    order2.ShipZip = sqlDataReader["ShipZip"].ToString().Trim() ?? "";
                    order2.Branch = sqlDataReader["Branch"].ToString().Trim() ?? "";
                    order2.PaymentTermKey = sqlDataReader["PaymentTermKey"].ToString().Trim() ?? "";
                    order2.OrderStatus = sqlDataReader["OrderStatus"].ToString().Trim() ?? "";
                    order2.CreateUserID = sqlDataReader["CreateUserID"].ToString().Trim() ?? "";
                    order2.CreateTime = sqlDataReader["CreateTime"] == DBNull.Value ? (DateTime?)null : (DateTime?)sqlDataReader["CreateTime"];
                    order2.LastModUserID = sqlDataReader["LastModUserID"].ToString().Trim() ?? "";
                    order2.LastModTime = sqlDataReader["LastModTime"] == DBNull.Value ? (DateTime?)null : (DateTime?)sqlDataReader["LastModTime"];
                    order2.OrderMemo = sqlDataReader["OrderMemo"].ToString().Trim() ?? "";
                    order2.RouteNumber = Convert.ToInt32(sqlDataReader["RouteNumber"].ToString().Trim());
                    order2.RouteStop = sqlDataReader["RouteStop"].ToString().Trim() ?? "";
                    //order2.Amount = Convert.ToDecimal(sqlDataReader["Amount"].ToString().Trim());
                }
                return order2;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                Order2 order2 = new Order2();
                return order2;
            }
            finally
            {

                connection.Close();
            }
        }

        static public Order2 sp_Fetch_InvoiceInfo(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_InvoiceInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                Order2 order2 = new Order2();

                if (sqlDataReader.Read())
                {
                    order2.id = sqlDataReader["id"].ToString().Trim() ?? "";
                    order2.iPadOrderID = sqlDataReader["iPadOrderID"].ToString().Trim() ?? "";
                    order2.OrderID = sqlDataReader["OrderID"].ToString().Trim() ?? "";
                    order2.CreditAmount = sqlDataReader["CreditAmount"].ToString().Trim() ?? "";
                    order2.OrderDate = Convert.ToDateTime(sqlDataReader["OrderDate"].ToString().Trim());
                    order2.SaleRep = sqlDataReader["SaleRep"].ToString().Trim() ?? "";
                    order2.CustomerID = sqlDataReader["CustomerID"].ToString().Trim() ?? "";
                    order2.CustomerName = sqlDataReader["CustomerName"].ToString().Trim() ?? "";
                    order2.BillAddress1 = sqlDataReader["BillAddress1"].ToString().Trim() ?? "";
                    order2.BillAddress2 = sqlDataReader["BillAddress2"].ToString().Trim() ?? "";
                    order2.BillCity = sqlDataReader["BillCity"].ToString().Trim() ?? "";
                    order2.BillState = sqlDataReader["BillState"].ToString().Trim() ?? "";
                    order2.BillZip = sqlDataReader["BillZip"].ToString().Trim() ?? "";
                    order2.ShipAddress1 = sqlDataReader["ShipAddress1"].ToString().Trim() ?? "";
                    order2.ShipAddress2 = sqlDataReader["ShipAddress2"].ToString().Trim() ?? "";
                    order2.ShipCity = sqlDataReader["ShipCity"].ToString().Trim() ?? "";
                    order2.ShipState = sqlDataReader["ShipState"].ToString().Trim() ?? "";
                    order2.ShipZip = sqlDataReader["ShipZip"].ToString().Trim() ?? "";
                    order2.Branch = sqlDataReader["Branch"].ToString().Trim() ?? "";
                    order2.PaymentTermKey = sqlDataReader["PaymentTermKey"].ToString().Trim() ?? "";
                    order2.OrderStatus = sqlDataReader["OrderStatus"].ToString().Trim() ?? "";
                    order2.CreateUserID = sqlDataReader["CreateUserID"].ToString().Trim() ?? "";
                    order2.CreateTime = sqlDataReader["CreateTime"] == DBNull.Value ? (DateTime?)null : (DateTime?)sqlDataReader["CreateTime"];
                    order2.LastModUserID = sqlDataReader["LastModUserID"].ToString().Trim() ?? "";
                    order2.LastModTime = sqlDataReader["LastModTime"] == DBNull.Value ? (DateTime?)null : (DateTime?)sqlDataReader["LastModTime"];
                    order2.OrderMemo = sqlDataReader["OrderMemo"].ToString().Trim() ?? "";
                    order2.RouteNumber = Convert.ToInt32(sqlDataReader["RouteNumber"].ToString().Trim());
                    order2.RouteStop = sqlDataReader["RouteStop"].ToString().Trim() ?? "";
                    order2.Amount = Convert.ToDecimal(sqlDataReader["Amount"].ToString().Trim());
                }
                return order2;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                Order2 order2 = new Order2();
                return order2;
            }
            finally
            {
                connection.Close();
            }
        }

        static public Order2 sp_Fetch_PickInfo(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_PickInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                Order2 order2 = new Order2();

                if (sqlDataReader.Read())
                {
                    order2.id = sqlDataReader["id"].ToString().Trim() ?? "";
                    order2.iPadOrderID = sqlDataReader["iPadOrderID"].ToString().Trim() ?? "";
                    order2.OrderID = sqlDataReader["OrderID"].ToString().Trim() ?? "";
                    order2.CreditAmount = sqlDataReader["CreditAmount"].ToString().Trim() ?? "";
                    order2.OrderDate = Convert.ToDateTime(sqlDataReader["OrderDate"].ToString().Trim());
                    order2.SaleRep = sqlDataReader["SaleRep"].ToString().Trim() ?? "";
                    order2.CustomerID = sqlDataReader["CustomerID"].ToString().Trim() ?? "";
                    order2.CustomerName = sqlDataReader["CustomerName"].ToString().Trim() ?? "";
                    order2.BillAddress1 = sqlDataReader["BillAddress1"].ToString().Trim() ?? "";
                    order2.BillAddress2 = sqlDataReader["BillAddress2"].ToString().Trim() ?? "";
                    order2.BillCity = sqlDataReader["BillCity"].ToString().Trim() ?? "";
                    order2.BillState = sqlDataReader["BillState"].ToString().Trim() ?? "";
                    order2.BillZip = sqlDataReader["BillZip"].ToString().Trim() ?? "";
                    order2.ShipAddress1 = sqlDataReader["ShipAddress1"].ToString().Trim() ?? "";
                    order2.ShipAddress2 = sqlDataReader["ShipAddress2"].ToString().Trim() ?? "";
                    order2.ShipCity = sqlDataReader["ShipCity"].ToString().Trim() ?? "";
                    order2.ShipState = sqlDataReader["ShipState"].ToString().Trim() ?? "";
                    order2.ShipZip = sqlDataReader["ShipZip"].ToString().Trim() ?? "";
                    order2.Branch = sqlDataReader["Branch"].ToString().Trim() ?? "";
                    order2.PaymentTermKey = sqlDataReader["PaymentTermKey"].ToString().Trim() ?? "";
                    order2.OrderStatus = sqlDataReader["OrderStatus"].ToString().Trim() ?? "";
                    order2.CreateUserID = sqlDataReader["CreateUserID"].ToString().Trim() ?? "";
                    order2.CreateTime = sqlDataReader["CreateTime"] == DBNull.Value ? (DateTime?)null : (DateTime?)sqlDataReader["CreateTime"];
                    order2.LastModUserID = sqlDataReader["LastModUserID"].ToString().Trim() ?? "";
                    order2.LastModTime = sqlDataReader["LastModTime"] == DBNull.Value ? (DateTime?)null : (DateTime?)sqlDataReader["LastModTime"];
                    order2.OrderMemo = sqlDataReader["OrderMemo"].ToString().Trim() ?? "";
                    order2.RouteNumber = Convert.ToInt32(sqlDataReader["RouteNumber"].ToString().Trim());
                    order2.RouteStop = sqlDataReader["RouteStop"].ToString().Trim() ?? "";
                    order2.Amount = Convert.ToDecimal(sqlDataReader["Amount"].ToString().Trim());
                }
                return order2;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                Order2 order2 = new Order2();
                return order2;
            }
            finally
            {
                connection.Close();
            }
        }

        static public Collection sp_Fetch_Order2CollectionInfo(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_DeliveryInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                Collection collection = new Collection();

                if (sqlDataReader.Read())
                {
                    collection.OrderID = sqlDataReader["OrderID"].ToString().Trim() ?? "";
                    collection.Cash = Convert.ToDecimal(sqlDataReader["CollectionCash"].ToString().Trim() ?? "0.00");
                    collection.CheckDate1 = sqlDataReader["CollectionCheckDate1"] == DBNull.Value ? Convert.ToDateTime("1900-01-01") : (DateTime)sqlDataReader["CollectionCheckDate1"];
                    collection.CheckNo1 = sqlDataReader["CollectionCheckNo1"].ToString().Trim() ?? "";
                    collection.CheckAmount1 = Convert.ToDecimal(sqlDataReader["CollectionCheckAmount1"].ToString().Trim());
                    collection.CheckDate2 = sqlDataReader["CollectionCheckDate2"] == DBNull.Value ? Convert.ToDateTime("1900-01-01") : (DateTime)sqlDataReader["CollectionCheckDate2"];
                    collection.CheckNo2 = sqlDataReader["CollectionCheckNo2"].ToString().Trim() ?? "";
                    collection.CheckAmount2 = Convert.ToDecimal(sqlDataReader["CollectionCheckAmount2"].ToString().Trim());
                    collection.CheckDate3 = sqlDataReader["CollectionCheckDate3"] == DBNull.Value ? Convert.ToDateTime("1900-01-01") : (DateTime)sqlDataReader["CollectionCheckDate3"];
                    collection.CheckNo3 = sqlDataReader["CollectionCheckNo3"].ToString().Trim() ?? "";
                    collection.CheckAmount3 = Convert.ToDecimal(sqlDataReader["CollectionCheckAmount3"].ToString().Trim());
                    collection.CheckDate4 = sqlDataReader["CollectionCheckDate4"] == DBNull.Value ? Convert.ToDateTime("1900-01-01") : (DateTime)sqlDataReader["CollectionCheckDate4"];
                    collection.CheckNo4 = sqlDataReader["CollectionCheckNo4"].ToString().Trim() ?? "";
                    collection.CheckAmount4 = Convert.ToDecimal(sqlDataReader["CollectionCheckAmount4"].ToString().Trim());
                    collection.CheckDate5 = sqlDataReader["CollectionCheckDate5"] == DBNull.Value ? Convert.ToDateTime("1900-01-01") : (DateTime)sqlDataReader["CollectionCheckDate5"];
                    collection.CheckNo5 = sqlDataReader["CollectionCheckNo5"].ToString().Trim() ?? "";
                    collection.CheckAmount5 = Convert.ToDecimal(sqlDataReader["CollectionCheckAmount5"].ToString().Trim());
                    
                    //order2.CreateTime = sqlDataReader["CreateTime"] == DBNull.Value ? (DateTime?)null : (DateTime?)sqlDataReader["CreateTime"];
                }
                return collection;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                Collection collection = new Collection();
                return collection;
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_UPDATE_Order2CollectInfo(Collection collection)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_Order2CollectInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Cash", SqlDbType.Decimal);
                cmd.Parameters.Add("@CheckDate1", SqlDbType.DateTime);
                cmd.Parameters.Add("@CheckNo1", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheckAmount1", SqlDbType.Decimal);
                cmd.Parameters.Add("@CheckDate2", SqlDbType.DateTime);
                cmd.Parameters.Add("@CheckNo2", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheckAmount2", SqlDbType.Decimal);
                cmd.Parameters.Add("@CheckDate3", SqlDbType.DateTime);
                cmd.Parameters.Add("@CheckNo3", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheckAmount3", SqlDbType.Decimal);
                cmd.Parameters.Add("@CheckDate4", SqlDbType.DateTime);
                cmd.Parameters.Add("@CheckNo4", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheckAmount4", SqlDbType.Decimal);
                cmd.Parameters.Add("@CheckDate5", SqlDbType.DateTime);
                cmd.Parameters.Add("@CheckNo5", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheckAmount5", SqlDbType.Decimal);

                cmd.Parameters["@OrderID"].Value = collection.OrderID;
                cmd.Parameters["@Cash"].Value = collection.Cash;
                cmd.Parameters["@CheckDate1"].Value = collection.CheckDate1;
                cmd.Parameters["@CheckNo1"].Value = collection.CheckNo1;
                cmd.Parameters["@CheckAmount1"].Value = collection.CheckAmount1;
                cmd.Parameters["@CheckDate2"].Value = collection.CheckDate2;
                cmd.Parameters["@CheckNo2"].Value = collection.CheckNo2;
                cmd.Parameters["@CheckAmount2"].Value = collection.CheckAmount2;
                cmd.Parameters["@CheckDate3"].Value = collection.CheckDate3;
                cmd.Parameters["@CheckNo3"].Value = collection.CheckNo3;
                cmd.Parameters["@CheckAmount3"].Value = collection.CheckAmount3;
                cmd.Parameters["@CheckDate4"].Value = collection.CheckDate4;
                cmd.Parameters["@CheckNo4"].Value = collection.CheckNo4;
                cmd.Parameters["@CheckAmount4"].Value = collection.CheckAmount4;
                cmd.Parameters["@CheckDate5"].Value = collection.CheckDate5;
                cmd.Parameters["@CheckNo5"].Value = collection.CheckNo5;
                cmd.Parameters["@CheckAmount5"].Value = collection.CheckAmount5;
                
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

        static public void sp_INSERT_NewOrderIDFromiPadSalesOrder(iPadSalesOrder iPadSalesOrder)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INSERT_NewOrderIDFromiPadSalesOrder";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@iPadOrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@SaleRep", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerName", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillAddress1", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillAddress2", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillState", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillZip", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipAddress1", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipAddress2", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipState", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShiplZip", SqlDbType.VarChar);
                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                cmd.Parameters.Add("@PaymentTermKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@CreateTime", SqlDbType.DateTime);
                cmd.Parameters.Add("@OrderMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@AuditMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@AuditConfirm", SqlDbType.VarChar);

                cmd.Parameters["@iPadOrderID"].Value = iPadSalesOrder.OrderID;
                cmd.Parameters["@SaleRep"].Value = iPadSalesOrder.SaleRepID;
                cmd.Parameters["@CustomerID"].Value = iPadSalesOrder.CustomerID;
                cmd.Parameters["@CustomerName"].Value = iPadSalesOrder.CompanyName;
                cmd.Parameters["@BillAddress1"].Value = iPadSalesOrder.BillAddress1;
                cmd.Parameters["@BillAddress2"].Value = iPadSalesOrder.BillAddress2;
                cmd.Parameters["@BillCity"].Value = iPadSalesOrder.BillCityName;
                cmd.Parameters["@BillState"].Value = iPadSalesOrder.BillStateCode;
                cmd.Parameters["@BillZip"].Value = iPadSalesOrder.BillPostalCode;
                cmd.Parameters["@ShipAddress1"].Value = iPadSalesOrder.ShipAddress1;
                cmd.Parameters["@ShipAddress2"].Value = iPadSalesOrder.ShipAddress2;
                cmd.Parameters["@ShipCity"].Value = iPadSalesOrder.ShipCityName;
                cmd.Parameters["@ShipState"].Value = iPadSalesOrder.ShipStateCode;
                cmd.Parameters["@ShiplZip"].Value = iPadSalesOrder.ShipPostalCode;
                cmd.Parameters["@Branch"].Value = iPadSalesOrder.CdBranchCode;
                cmd.Parameters["@PaymentTermKey"].Value = iPadSalesOrder.TermName;//iPadSalesOrder.PaymentTermKey;
                cmd.Parameters["@CreateUserID"].Value = GATE.userID;
                //cmd.Parameters["@CreateTime"].Value = DateTime.Now.ToString();
                cmd.Parameters["@OrderMemo"].Value = iPadSalesOrder.OrdMemo;
                cmd.Parameters["@OrderDate"].Value = iPadSalesOrder.OrderDate;
                cmd.Parameters["@CreditAmount"].Value = iPadSalesOrder.CrAmt;
                cmd.Parameters["@AuditMemo"].Value = iPadSalesOrder.AuditMemo;
                cmd.Parameters["@AuditConfirm"].Value = iPadSalesOrder.AuditConfirm;

                //SqlParameter par = cmd.CreateParameter();
                //par.SourceVersion = DataRowVersion.Proposed;
                //par.ParameterName = "@OUT_TEMPNO";
                //par.SqlDbType = SqlDbType.Int;
                //par.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(par);

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_INSERT_SRETURN(iPadSalesOrder iPadSalesOrder)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INSERT_SRETURN";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@iPadOrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@SaleRep", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerName", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillAddress1", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillAddress2", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillState", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillZip", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipAddress1", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipAddress2", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipState", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShiplZip", SqlDbType.VarChar);
                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentTermKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@CreateTime", SqlDbType.DateTime);
                cmd.Parameters.Add("@OrderMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);

                cmd.Parameters["@iPadOrderID"].Value = iPadSalesOrder.OrderID;
                cmd.Parameters["@SaleRep"].Value = iPadSalesOrder.SaleRepID;
                cmd.Parameters["@CustomerID"].Value = iPadSalesOrder.CustomerID;
                cmd.Parameters["@CustomerName"].Value = iPadSalesOrder.CompanyName;
                cmd.Parameters["@BillAddress1"].Value = iPadSalesOrder.BillAddress1;
                cmd.Parameters["@BillAddress2"].Value = iPadSalesOrder.BillAddress2;
                cmd.Parameters["@BillCity"].Value = iPadSalesOrder.BillCityName;
                cmd.Parameters["@BillState"].Value = iPadSalesOrder.BillStateCode;
                cmd.Parameters["@BillZip"].Value = iPadSalesOrder.BillPostalCode;
                cmd.Parameters["@ShipAddress1"].Value = iPadSalesOrder.ShipAddress1;
                cmd.Parameters["@ShipAddress2"].Value = iPadSalesOrder.ShipAddress2;
                cmd.Parameters["@ShipCity"].Value = iPadSalesOrder.ShipCityName;
                cmd.Parameters["@ShipState"].Value = iPadSalesOrder.ShipStateCode;
                cmd.Parameters["@ShiplZip"].Value = iPadSalesOrder.ShipPostalCode;
                cmd.Parameters["@Branch"].Value = iPadSalesOrder.CdBranchCode;
                //cmd.Parameters["@PaymentTermKey"].Value = iPadSalesOrder.PaymentTermKey;
                cmd.Parameters["@CreateUserID"].Value = GATE.userID;
                //cmd.Parameters["@CreateTime"].Value = DateTime.Now.ToString();
                cmd.Parameters["@OrderMemo"].Value = iPadSalesOrder.OrdMemo;
                cmd.Parameters["@OrderDate"].Value = iPadSalesOrder.OrderDate;
                cmd.Parameters["@CreditAmount"].Value = iPadSalesOrder.CrAmt;

                //SqlParameter par = cmd.CreateParameter();
                //par.SourceVersion = DataRowVersion.Proposed;
                //par.ParameterName = "@OUT_TEMPNO";
                //par.SqlDbType = SqlDbType.Int;
                //par.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(par);

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_INSERT_NewBrand(String BrandCode, String BrandName, int LeadTime, String BrandStatus, String BrandMemo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INSERT_NewBrand";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@BrandName", SqlDbType.VarChar);
                cmd.Parameters.Add("@LeadTime", SqlDbType.Int);
                cmd.Parameters.Add("@BrandStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@BrandMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                
                cmd.Parameters["@BrandCode"].Value = BrandCode;
                cmd.Parameters["@BrandName"].Value = BrandName;
                cmd.Parameters["@LeadTime"].Value = LeadTime;
                cmd.Parameters["@BrandStatus"].Value = BrandStatus;
                cmd.Parameters["@BrandMemo"].Value = BrandMemo;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
 
                //SqlParameter par = cmd.CreateParameter();
                //par.SourceVersion = DataRowVersion.Proposed;
                //par.ParameterName = "@OUT_TEMPNO";
                //par.SqlDbType = SqlDbType.Int;
                //par.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(par);

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_INSERT_ITMBPS(String ProductID, String Supplier, String SupplierProductCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INSERT_ITMBPS";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Supplier", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierProductCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Supplier"].Value = Supplier;
                cmd.Parameters["@SupplierProductCode"].Value = SupplierProductCode;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                
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

        static public void sp_DELETE_ITMBPS(String ProductID, String Supplier)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_DELETE_ITMBPS";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Supplier", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Supplier"].Value = Supplier;

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

        static public void sp_DELETE_SupplierAddress(String ROWID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_DELETE_SupplierAddress";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ROWID", SqlDbType.Int);

                cmd.Parameters["@ROWID"].Value =  Convert.ToInt32(ROWID);

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

        static public void sp_GACCENTRY_SalesCreditSCM(iPadSalesOrder iPadSalesOrder)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GACCENTRY_SalesCreditSCM";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@iPadOrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@SaleRep", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerName", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillAddress1", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillAddress2", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillState", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillZip", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipAddress1", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipAddress2", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipState", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShiplZip", SqlDbType.VarChar);
                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentTermKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@CreateTime", SqlDbType.DateTime);
                cmd.Parameters.Add("@OrderMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);

                cmd.Parameters["@iPadOrderID"].Value = iPadSalesOrder.OrderID;
                cmd.Parameters["@SaleRep"].Value = iPadSalesOrder.SaleRepID;
                cmd.Parameters["@CustomerID"].Value = iPadSalesOrder.CustomerID;
                cmd.Parameters["@CustomerName"].Value = iPadSalesOrder.CompanyName;
                cmd.Parameters["@BillAddress1"].Value = iPadSalesOrder.BillAddress1;
                cmd.Parameters["@BillAddress2"].Value = iPadSalesOrder.BillAddress2;
                cmd.Parameters["@BillCity"].Value = iPadSalesOrder.BillCityName;
                cmd.Parameters["@BillState"].Value = iPadSalesOrder.BillStateCode;
                cmd.Parameters["@BillZip"].Value = iPadSalesOrder.BillPostalCode;
                cmd.Parameters["@ShipAddress1"].Value = iPadSalesOrder.ShipAddress1;
                cmd.Parameters["@ShipAddress2"].Value = iPadSalesOrder.ShipAddress2;
                cmd.Parameters["@ShipCity"].Value = iPadSalesOrder.ShipCityName;
                cmd.Parameters["@ShipState"].Value = iPadSalesOrder.ShipStateCode;
                cmd.Parameters["@ShiplZip"].Value = iPadSalesOrder.ShipPostalCode;
                cmd.Parameters["@Branch"].Value = iPadSalesOrder.CdBranchCode;
                //cmd.Parameters["@PaymentTermKey"].Value = iPadSalesOrder.PaymentTermKey;
                cmd.Parameters["@CreateUserID"].Value = GATE.userID;
                //cmd.Parameters["@CreateTime"].Value = DateTime.Now.ToString();
                cmd.Parameters["@OrderMemo"].Value = iPadSalesOrder.OrdMemo;
                cmd.Parameters["@OrderDate"].Value = iPadSalesOrder.OrderDate;
                cmd.Parameters["@CreditAmount"].Value = iPadSalesOrder.CrAmt;

                //SqlParameter par = cmd.CreateParameter();
                //par.SourceVersion = DataRowVersion.Proposed;
                //par.ParameterName = "@OUT_TEMPNO";
                //par.SqlDbType = SqlDbType.Int;
                //par.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(par);

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_VOID_iPadSalesOrder(String iPadOrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_VOID_iPadSalesOrder";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@iPadOrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                
                cmd.Parameters["@iPadOrderID"].Value = iPadOrderID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
 
                //SqlParameter par = cmd.CreateParameter();
                //par.SourceVersion = DataRowVersion.Proposed;
                //par.ParameterName = "@OUT_TEMPNO";
                //par.SqlDbType = SqlDbType.Int;
                //par.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(par);

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_UPDATE_Order2(Order2 order2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_Order2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillAddress1", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillAddress2", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillState", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillZip", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipAddress1", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipAddress2", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipState", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipZip", SqlDbType.VarChar);
                cmd.Parameters.Add("@LastModUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@AuditMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@AuditConfirm", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = order2.OrderID;
                cmd.Parameters["@BillAddress1"].Value = order2.BillAddress1;
                cmd.Parameters["@BillAddress2"].Value = order2.BillAddress2;
                cmd.Parameters["@BillCity"].Value = order2.BillCity;
                cmd.Parameters["@BillState"].Value = order2.BillState;
                cmd.Parameters["@BillZip"].Value = order2.BillZip;
                cmd.Parameters["@ShipAddress1"].Value = order2.ShipAddress1;
                cmd.Parameters["@ShipAddress2"].Value = order2.ShipAddress2;
                cmd.Parameters["@ShipCity"].Value = order2.ShipCity;
                cmd.Parameters["@ShipState"].Value = order2.ShipState;
                cmd.Parameters["@ShipZip"].Value = order2.ShipZip;
                cmd.Parameters["@LastModUserID"].Value = GATE.userID;
                cmd.Parameters["@CreditAmount"].Value = order2.CreditAmount;
                cmd.Parameters["@AuditMemo"].Value = order2.AuditMemo;
                cmd.Parameters["@AuditConfirm"].Value = order2.AuditConfirm ;

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_UPDATE_Pick(Order2 order2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_Pick";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillAddress1", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillAddress2", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillState", SqlDbType.VarChar);
                cmd.Parameters.Add("@BillZip", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipAddress1", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipAddress2", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipState", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipZip", SqlDbType.VarChar);
                cmd.Parameters.Add("@LastModUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);

                cmd.Parameters["@OrderID"].Value = order2.OrderID;
                cmd.Parameters["@BillAddress1"].Value = order2.BillAddress1;
                cmd.Parameters["@BillAddress2"].Value = order2.BillAddress2;
                cmd.Parameters["@BillCity"].Value = order2.BillCity;
                cmd.Parameters["@BillState"].Value = order2.BillState;
                cmd.Parameters["@BillZip"].Value = order2.BillZip;
                cmd.Parameters["@ShipAddress1"].Value = order2.ShipAddress1;
                cmd.Parameters["@ShipAddress2"].Value = order2.ShipAddress2;
                cmd.Parameters["@ShipCity"].Value = order2.ShipCity;
                cmd.Parameters["@ShipState"].Value = order2.ShipState;
                cmd.Parameters["@ShipZip"].Value = order2.ShipZip;
                cmd.Parameters["@LastModUserID"].Value = GATE.userID;
                cmd.Parameters["@CreditAmount"].Value = order2.CreditAmount;

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_INSERT_NewOrderIDFromiPadSalesOrderDetail(iPadSaleOrderDetail iPadSalesOrderDetail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INSERT_NewOrderIDFromiPadSalesOrderDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@iPadOrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDetailKey", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ProductKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReturnFlag", SqlDbType.VarChar);
                cmd.Parameters.Add("@Remark", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);

                cmd.Parameters["@iPadOrderID"].Value = iPadSalesOrderDetail.OrderID;
                cmd.Parameters["@OrderDetailKey"].Value = iPadSalesOrderDetail.OrderDetailKey;
                //cmd.Parameters["@ProductKey"].Value = iPadSalesOrderDetail.ProductKey;
                cmd.Parameters["@ProductID"].Value = iPadSalesOrderDetail.ProductID;
                cmd.Parameters["@OrderQty"].Value = iPadSalesOrderDetail.OrderQty;
                cmd.Parameters["@Price"].Value = iPadSalesOrderDetail.Price;
                cmd.Parameters["@Amount"].Value = iPadSalesOrderDetail.Amount;
                cmd.Parameters["@ReturnFlag"].Value = iPadSalesOrderDetail.ReturnFlag;
                cmd.Parameters["@Remark"].Value = iPadSalesOrderDetail.Remark;
                cmd.Parameters["@CreateUserID"].Value = iPadSalesOrderDetail.CreateUserID;

                //SqlParameter par = cmd.CreateParameter();
                //par.SourceVersion = DataRowVersion.Proposed;
                //par.ParameterName = "@OUT_TEMPNO";
                //par.SqlDbType = SqlDbType.Int;
                //par.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(par);

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_INSERT_OrderDetail2(iPadSaleOrderDetail iPadSalesOrderDetail, int Line)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INSERT_OrderDetail2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@iPadOrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDetailKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReturnFlag", SqlDbType.VarChar);
                cmd.Parameters.Add("@Remark", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Line", SqlDbType.Int);

                cmd.Parameters["@iPadOrderID"].Value = iPadSalesOrderDetail.OrderID;
                cmd.Parameters["@OrderDetailKey"].Value = iPadSalesOrderDetail.OrderDetailKey;
                cmd.Parameters["@ProductID"].Value = iPadSalesOrderDetail.ProductID;
                cmd.Parameters["@OrderQty"].Value = iPadSalesOrderDetail.OrderQty;
                cmd.Parameters["@Price"].Value = iPadSalesOrderDetail.Price;
                cmd.Parameters["@Amount"].Value = iPadSalesOrderDetail.Amount;
                cmd.Parameters["@ReturnFlag"].Value = iPadSalesOrderDetail.ReturnFlag;
                cmd.Parameters["@Remark"].Value = iPadSalesOrderDetail.Remark;
                cmd.Parameters["@CreateUserID"].Value = iPadSalesOrderDetail.CreateUserID;
                cmd.Parameters["@Line"].Value = Line;
                
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

        static public void sp_Allocation_Order(STOALL sTOALL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Allocation_Order";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);
                cmd.Parameters.Add("@STOCOU_0", SqlDbType.Decimal);
                cmd.Parameters.Add("@ALLDAT_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@SEQ_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@ALLTYP_0", SqlDbType.Int);
                cmd.Parameters.Add("@VCRTYP_0", SqlDbType.Int);
                cmd.Parameters.Add("@VCRNUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@VCRLIN_0", SqlDbType.Int);
                cmd.Parameters.Add("@VCRSEQ_0", SqlDbType.Int);
                cmd.Parameters.Add("@QTYSTU_0", SqlDbType.Decimal);
                cmd.Parameters.Add("@QTYSTUACT_0", SqlDbType.Decimal);
                cmd.Parameters.Add("@WRH_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOC_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOT_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SLO_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@STA_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SERNUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SRGLOC_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@DEFWRH_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@DEFLOC_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@DEFLOCTYP_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SRGQTYSTU_0", SqlDbType.Decimal);
                cmd.Parameters.Add("@SRGNUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SRGLIN_0", SqlDbType.Int);
                cmd.Parameters.Add("@PRENUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@BESDAT_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@MVTDES_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@BPRNUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@BPAADD_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SCOFLG_0", SqlDbType.Int);
                cmd.Parameters.Add("@PRECOD_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@EXPNUM_0", SqlDbType.Int);
                cmd.Parameters.Add("@CREDAT_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@CREUSR_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@UPDDAT_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@UPDUSR_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@CREDATTIM_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@UPDDATTIM_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@ECCVALMAJ_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@YQTYPACKED_0", SqlDbType.Decimal);

                cmd.Parameters["@Site"].Value = sTOALL.Site;
                cmd.Parameters["@ItemID"].Value = sTOALL.ItemID;
                cmd.Parameters["@STOCOU_0"].Value = sTOALL.STOCOU_0;
                cmd.Parameters["@ALLDAT_0"].Value = sTOALL.ALLDAT_0;
                cmd.Parameters["@SEQ_0"].Value = sTOALL.SEQ_0;
                cmd.Parameters["@ALLTYP_0"].Value = sTOALL.ALLTYP_0;
                cmd.Parameters["@VCRTYP_0"].Value = sTOALL.VCRTYP_0;
                cmd.Parameters["@VCRNUM_0"].Value = sTOALL.VCRNUM_0;
                cmd.Parameters["@VCRLIN_0"].Value = sTOALL.VCRLIN_0;
                cmd.Parameters["@VCRSEQ_0"].Value = sTOALL.VCRSEQ_0;
                cmd.Parameters["@QTYSTU_0"].Value = sTOALL.QTYSTU_0;
                cmd.Parameters["@QTYSTUACT_0"].Value = sTOALL.QTYSTUACT_0;
                cmd.Parameters["@WRH_0"].Value = sTOALL.WRH_0;
                cmd.Parameters["@LOC_0"].Value = sTOALL.LOC_0;
                cmd.Parameters["@LOT_0"].Value = sTOALL.LOT_0;
                cmd.Parameters["@SLO_0"].Value = sTOALL.SLO_0;
                cmd.Parameters["@STA_0"].Value = sTOALL.STA_0;
                cmd.Parameters["@SERNUM_0"].Value = sTOALL.SERNUM_0;
                cmd.Parameters["@SRGLOC_0"].Value = sTOALL.SRGLOC_0;
                cmd.Parameters["@DEFWRH_0"].Value = sTOALL.DEFWRH_0;
                cmd.Parameters["@DEFLOC_0"].Value = sTOALL.DEFLOC_0;
                cmd.Parameters["@DEFLOCTYP_0"].Value = sTOALL.DEFLOCTYP_0;
                cmd.Parameters["@SRGQTYSTU_0"].Value = sTOALL.SRGQTYSTU_0;
                cmd.Parameters["@SRGNUM_0"].Value = sTOALL.SRGNUM_0;
                cmd.Parameters["@SRGLIN_0"].Value = sTOALL.SRGLIN_0;
                cmd.Parameters["@PRENUM_0"].Value = sTOALL.PRENUM_0;
                cmd.Parameters["@BESDAT_0"].Value = sTOALL.BESDAT_0;
                cmd.Parameters["@MVTDES_0"].Value = sTOALL.MVTDES_0;
                cmd.Parameters["@BPRNUM_0"].Value = sTOALL.BPRNUM_0;
                cmd.Parameters["@BPAADD_0"].Value = sTOALL.BPAADD_0;
                cmd.Parameters["@SCOFLG_0"].Value = sTOALL.SCOFLG_0;
                cmd.Parameters["@PRECOD_0"].Value = sTOALL.PRECOD_0;
                cmd.Parameters["@EXPNUM_0"].Value = sTOALL.EXPNUM_0;
                cmd.Parameters["@CREDAT_0"].Value = sTOALL.CREDAT_0;
                cmd.Parameters["@CREUSR_0"].Value = sTOALL.CREUSR_0;
                cmd.Parameters["@UPDDAT_0"].Value = sTOALL.UPDDAT_0;
                cmd.Parameters["@UPDUSR_0"].Value = sTOALL.UPDUSR_0;
                cmd.Parameters["@CREDATTIM_0"].Value = sTOALL.CREDATTIM_0;
                cmd.Parameters["@UPDDATTIM_0"].Value = sTOALL.UPDDATTIM_0;
                cmd.Parameters["@ECCVALMAJ_0"].Value = sTOALL.ECCVALMAJ_0;
                cmd.Parameters["@YQTYPACKED_0"].Value = sTOALL.YQTYPACKED_0;
                
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

        static public void sp_Allocation_PickingList(STOALL sTOALL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Allocation_PickingList";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);
                cmd.Parameters.Add("@STOCOU_0", SqlDbType.Decimal);
                cmd.Parameters.Add("@ALLDAT_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@SEQ_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@ALLTYP_0", SqlDbType.Int);
                cmd.Parameters.Add("@VCRTYP_0", SqlDbType.Int);
                cmd.Parameters.Add("@VCRNUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@VCRLIN_0", SqlDbType.Int);
                cmd.Parameters.Add("@VCRSEQ_0", SqlDbType.Int);
                cmd.Parameters.Add("@QTYSTU_0", SqlDbType.Decimal);
                cmd.Parameters.Add("@QTYSTUACT_0", SqlDbType.Decimal);
                cmd.Parameters.Add("@WRH_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOC_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOT_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SLO_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@STA_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SERNUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SRGLOC_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@DEFWRH_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@DEFLOC_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@DEFLOCTYP_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SRGQTYSTU_0", SqlDbType.Decimal);
                cmd.Parameters.Add("@SRGNUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SRGLIN_0", SqlDbType.Int);
                cmd.Parameters.Add("@PRENUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@BESDAT_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@MVTDES_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@BPRNUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@BPAADD_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SCOFLG_0", SqlDbType.Int);
                cmd.Parameters.Add("@PRECOD_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@EXPNUM_0", SqlDbType.Int);
                cmd.Parameters.Add("@CREDAT_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@CREUSR_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@UPDDAT_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@UPDUSR_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@CREDATTIM_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@UPDDATTIM_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@ECCVALMAJ_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@YQTYPACKED_0", SqlDbType.Decimal);

                cmd.Parameters["@Site"].Value = sTOALL.Site;
                cmd.Parameters["@ItemID"].Value = sTOALL.ItemID;
                cmd.Parameters["@STOCOU_0"].Value = sTOALL.STOCOU_0;
                cmd.Parameters["@ALLDAT_0"].Value = sTOALL.ALLDAT_0;
                cmd.Parameters["@SEQ_0"].Value = sTOALL.SEQ_0;
                cmd.Parameters["@ALLTYP_0"].Value = sTOALL.ALLTYP_0;
                cmd.Parameters["@VCRTYP_0"].Value = sTOALL.VCRTYP_0;
                cmd.Parameters["@VCRNUM_0"].Value = sTOALL.VCRNUM_0;
                cmd.Parameters["@VCRLIN_0"].Value = sTOALL.VCRLIN_0;
                cmd.Parameters["@VCRSEQ_0"].Value = sTOALL.VCRSEQ_0;
                cmd.Parameters["@QTYSTU_0"].Value = sTOALL.QTYSTU_0;
                cmd.Parameters["@QTYSTUACT_0"].Value = sTOALL.QTYSTUACT_0;
                cmd.Parameters["@WRH_0"].Value = sTOALL.WRH_0;
                cmd.Parameters["@LOC_0"].Value = sTOALL.LOC_0;
                cmd.Parameters["@LOT_0"].Value = sTOALL.LOT_0;
                cmd.Parameters["@SLO_0"].Value = sTOALL.SLO_0;
                cmd.Parameters["@STA_0"].Value = sTOALL.STA_0;
                cmd.Parameters["@SERNUM_0"].Value = sTOALL.SERNUM_0;
                cmd.Parameters["@SRGLOC_0"].Value = sTOALL.SRGLOC_0;
                cmd.Parameters["@DEFWRH_0"].Value = sTOALL.DEFWRH_0;
                cmd.Parameters["@DEFLOC_0"].Value = sTOALL.DEFLOC_0;
                cmd.Parameters["@DEFLOCTYP_0"].Value = sTOALL.DEFLOCTYP_0;
                cmd.Parameters["@SRGQTYSTU_0"].Value = sTOALL.SRGQTYSTU_0;
                cmd.Parameters["@SRGNUM_0"].Value = sTOALL.SRGNUM_0;
                cmd.Parameters["@SRGLIN_0"].Value = sTOALL.SRGLIN_0;
                cmd.Parameters["@PRENUM_0"].Value = sTOALL.PRENUM_0;
                cmd.Parameters["@BESDAT_0"].Value = sTOALL.BESDAT_0;
                cmd.Parameters["@MVTDES_0"].Value = sTOALL.MVTDES_0;
                cmd.Parameters["@BPRNUM_0"].Value = sTOALL.BPRNUM_0;
                cmd.Parameters["@BPAADD_0"].Value = sTOALL.BPAADD_0;
                cmd.Parameters["@SCOFLG_0"].Value = sTOALL.SCOFLG_0;
                cmd.Parameters["@PRECOD_0"].Value = sTOALL.PRECOD_0;
                cmd.Parameters["@EXPNUM_0"].Value = sTOALL.EXPNUM_0;
                cmd.Parameters["@CREDAT_0"].Value = sTOALL.CREDAT_0;
                cmd.Parameters["@CREUSR_0"].Value = sTOALL.CREUSR_0;
                cmd.Parameters["@UPDDAT_0"].Value = sTOALL.UPDDAT_0;
                cmd.Parameters["@UPDUSR_0"].Value = sTOALL.UPDUSR_0;
                cmd.Parameters["@CREDATTIM_0"].Value = sTOALL.CREDATTIM_0;
                cmd.Parameters["@UPDDATTIM_0"].Value = sTOALL.UPDDATTIM_0;
                cmd.Parameters["@ECCVALMAJ_0"].Value = sTOALL.ECCVALMAJ_0;
                cmd.Parameters["@YQTYPACKED_0"].Value = sTOALL.YQTYPACKED_0;

                //MessageBox.Show(sTOALL.Site.ToString());
                //MessageBox.Show(sTOALL.ItemID.ToString());
                //MessageBox.Show(sTOALL.STOCOU_0.ToString());
                //MessageBox.Show(sTOALL.ALLDAT_0.ToString());
                //MessageBox.Show(sTOALL.SEQ_0.ToString());
                //MessageBox.Show(sTOALL.ALLTYP_0.ToString());
                //MessageBox.Show(sTOALL.VCRTYP_0.ToString());
                //MessageBox.Show(sTOALL.VCRNUM_0.ToString());
                //MessageBox.Show(sTOALL.VCRLIN_0.ToString());
                //MessageBox.Show(sTOALL.VCRSEQ_0.ToString());
                //MessageBox.Show(sTOALL.QTYSTU_0.ToString());
                //MessageBox.Show(sTOALL.QTYSTUACT_0.ToString());
                //MessageBox.Show(sTOALL.WRH_0.ToString());
                //MessageBox.Show(sTOALL.LOC_0.ToString());
                //MessageBox.Show(sTOALL.LOT_0.ToString());
                //MessageBox.Show(sTOALL.SLO_0.ToString());
                //MessageBox.Show(sTOALL.STA_0.ToString());
                //MessageBox.Show(sTOALL.SERNUM_0.ToString());
                //MessageBox.Show(sTOALL.SRGLOC_0.ToString());
                //MessageBox.Show(sTOALL.DEFWRH_0.ToString());
                //MessageBox.Show(sTOALL.DEFLOC_0.ToString());
                //MessageBox.Show(sTOALL.DEFLOCTYP_0.ToString());
                //MessageBox.Show(sTOALL.SRGQTYSTU_0.ToString());
                //MessageBox.Show(sTOALL.SRGNUM_0.ToString());
                //MessageBox.Show(sTOALL.SRGLIN_0.ToString());
                //MessageBox.Show(sTOALL.PRENUM_0.ToString());
                //MessageBox.Show(sTOALL.BESDAT_0.ToString());
                //MessageBox.Show(sTOALL.MVTDES_0.ToString());
                //MessageBox.Show(sTOALL.BPRNUM_0.ToString());
                //MessageBox.Show(sTOALL.BPAADD_0.ToString());
                //MessageBox.Show(sTOALL.SCOFLG_0.ToString());
                //MessageBox.Show(sTOALL.PRECOD_0.ToString());
                //MessageBox.Show(sTOALL.EXPNUM_0.ToString());
                //MessageBox.Show(sTOALL.CREDAT_0.ToString());
                //MessageBox.Show(sTOALL.CREUSR_0.ToString());
                //MessageBox.Show(sTOALL.UPDDAT_0.ToString());
                //MessageBox.Show(sTOALL.UPDUSR_0.ToString());
                //MessageBox.Show(sTOALL.CREDATTIM_0.ToString());
                //MessageBox.Show(sTOALL.UPDDATTIM_0.ToString());
                //MessageBox.Show(sTOALL.ECCVALMAJ_0.ToString());
                //MessageBox.Show(sTOALL.YQTYPACKED_0.ToString());
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

        static public void sp_Allocation_DeliveryNote(STOALL sTOALL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Allocation_PickingList";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);
                cmd.Parameters.Add("@STOCOU_0", SqlDbType.Decimal);
                cmd.Parameters.Add("@ALLDAT_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@SEQ_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@ALLTYP_0", SqlDbType.Int);
                cmd.Parameters.Add("@VCRTYP_0", SqlDbType.Int);
                cmd.Parameters.Add("@VCRNUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@VCRLIN_0", SqlDbType.Int);
                cmd.Parameters.Add("@VCRSEQ_0", SqlDbType.Int);
                cmd.Parameters.Add("@QTYSTU_0", SqlDbType.Decimal);
                cmd.Parameters.Add("@QTYSTUACT_0", SqlDbType.Decimal);
                cmd.Parameters.Add("@WRH_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOC_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOT_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SLO_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@STA_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SERNUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SRGLOC_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@DEFWRH_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@DEFLOC_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@DEFLOCTYP_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SRGQTYSTU_0", SqlDbType.Decimal);
                cmd.Parameters.Add("@SRGNUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SRGLIN_0", SqlDbType.Int);
                cmd.Parameters.Add("@PRENUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@BESDAT_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@MVTDES_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@BPRNUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@BPAADD_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SCOFLG_0", SqlDbType.Int);
                cmd.Parameters.Add("@PRECOD_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@EXPNUM_0", SqlDbType.Int);
                cmd.Parameters.Add("@CREDAT_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@CREUSR_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@UPDDAT_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@UPDUSR_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@CREDATTIM_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@UPDDATTIM_0", SqlDbType.DateTime);
                cmd.Parameters.Add("@ECCVALMAJ_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@YQTYPACKED_0", SqlDbType.Decimal);

                cmd.Parameters["@Site"].Value = sTOALL.Site;
                cmd.Parameters["@ItemID"].Value = sTOALL.ItemID;
                cmd.Parameters["@STOCOU_0"].Value = sTOALL.STOCOU_0;
                cmd.Parameters["@ALLDAT_0"].Value = sTOALL.ALLDAT_0;
                cmd.Parameters["@SEQ_0"].Value = sTOALL.SEQ_0;
                cmd.Parameters["@ALLTYP_0"].Value = sTOALL.ALLTYP_0;
                cmd.Parameters["@VCRTYP_0"].Value = sTOALL.VCRTYP_0;
                cmd.Parameters["@VCRNUM_0"].Value = sTOALL.VCRNUM_0;
                cmd.Parameters["@VCRLIN_0"].Value = sTOALL.VCRLIN_0;
                cmd.Parameters["@VCRSEQ_0"].Value = sTOALL.VCRSEQ_0;
                cmd.Parameters["@QTYSTU_0"].Value = sTOALL.QTYSTU_0;
                cmd.Parameters["@QTYSTUACT_0"].Value = sTOALL.QTYSTUACT_0;
                cmd.Parameters["@WRH_0"].Value = sTOALL.WRH_0;
                cmd.Parameters["@LOC_0"].Value = sTOALL.LOC_0;
                cmd.Parameters["@LOT_0"].Value = sTOALL.LOT_0;
                cmd.Parameters["@SLO_0"].Value = sTOALL.SLO_0;
                cmd.Parameters["@STA_0"].Value = sTOALL.STA_0;
                cmd.Parameters["@SERNUM_0"].Value = sTOALL.SERNUM_0;
                cmd.Parameters["@SRGLOC_0"].Value = sTOALL.SRGLOC_0;
                cmd.Parameters["@DEFWRH_0"].Value = sTOALL.DEFWRH_0;
                cmd.Parameters["@DEFLOC_0"].Value = sTOALL.DEFLOC_0;
                cmd.Parameters["@DEFLOCTYP_0"].Value = sTOALL.DEFLOCTYP_0;
                cmd.Parameters["@SRGQTYSTU_0"].Value = sTOALL.SRGQTYSTU_0;
                cmd.Parameters["@SRGNUM_0"].Value = sTOALL.SRGNUM_0;
                cmd.Parameters["@SRGLIN_0"].Value = sTOALL.SRGLIN_0;
                cmd.Parameters["@PRENUM_0"].Value = sTOALL.PRENUM_0;
                cmd.Parameters["@BESDAT_0"].Value = sTOALL.BESDAT_0;
                cmd.Parameters["@MVTDES_0"].Value = sTOALL.MVTDES_0;
                cmd.Parameters["@BPRNUM_0"].Value = sTOALL.BPRNUM_0;
                cmd.Parameters["@BPAADD_0"].Value = sTOALL.BPAADD_0;
                cmd.Parameters["@SCOFLG_0"].Value = sTOALL.SCOFLG_0;
                cmd.Parameters["@PRECOD_0"].Value = sTOALL.PRECOD_0;
                cmd.Parameters["@EXPNUM_0"].Value = sTOALL.EXPNUM_0;
                cmd.Parameters["@CREDAT_0"].Value = sTOALL.CREDAT_0;
                cmd.Parameters["@CREUSR_0"].Value = sTOALL.CREUSR_0;
                cmd.Parameters["@UPDDAT_0"].Value = sTOALL.UPDDAT_0;
                cmd.Parameters["@UPDUSR_0"].Value = sTOALL.UPDUSR_0;
                cmd.Parameters["@CREDATTIM_0"].Value = sTOALL.CREDATTIM_0;
                cmd.Parameters["@UPDDATTIM_0"].Value = sTOALL.UPDDATTIM_0;
                cmd.Parameters["@ECCVALMAJ_0"].Value = sTOALL.ECCVALMAJ_0;
                cmd.Parameters["@YQTYPACKED_0"].Value = sTOALL.YQTYPACKED_0;

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

        static public void sp_UPDATE_OrderDetail2(OrderDetail2 orderDetail2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_OrderDetail2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDetailKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReturnFlag", SqlDbType.VarChar);
                cmd.Parameters.Add("@Remark", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = orderDetail2.OrderID;
                cmd.Parameters["@OrderDetailKey"].Value = orderDetail2.OrderDetailKey;
                cmd.Parameters["@ProductID"].Value = orderDetail2.ProductID;
                cmd.Parameters["@OrderQty"].Value = orderDetail2.OrderQty;
                cmd.Parameters["@Price"].Value = orderDetail2.Price;
                cmd.Parameters["@Amount"].Value = orderDetail2.Amount;
                cmd.Parameters["@ReturnFlag"].Value = orderDetail2.ReturnFlag;
                cmd.Parameters["@Remark"].Value = orderDetail2.Remark;
                cmd.Parameters["@CreateUserID"].Value = orderDetail2.CreateUserID;
                cmd.Parameters["@Status"].Value = orderDetail2.Status;

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

        static public void sp_UPDATE_PickDetail(OrderDetail2 orderDetail2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_PickDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDetailKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReturnFlag", SqlDbType.VarChar);
                cmd.Parameters.Add("@Remark", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = orderDetail2.OrderID;
                cmd.Parameters["@OrderDetailKey"].Value = orderDetail2.OrderDetailKey;
                cmd.Parameters["@ProductID"].Value = orderDetail2.ProductID;
                cmd.Parameters["@OrderQty"].Value = orderDetail2.OrderQty;
                cmd.Parameters["@Price"].Value = orderDetail2.Price;
                cmd.Parameters["@Amount"].Value = orderDetail2.Amount;
                cmd.Parameters["@ReturnFlag"].Value = orderDetail2.ReturnFlag;
                cmd.Parameters["@Remark"].Value = orderDetail2.Remark;
                cmd.Parameters["@CreateUserID"].Value = orderDetail2.CreateUserID;
                cmd.Parameters["@Status"].Value = orderDetail2.Status;

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

        static public void sp_UPDATE_InvoiceDetail(OrderDetail2 orderDetail2, String CustomerID, String NewInvoiceNumber, String REP, String NewSTKNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_InvoiceDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@vOrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@vOrderDetailKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@vProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@vOrderQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@vPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@vAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@vReturnFlag", SqlDbType.VarChar);
                cmd.Parameters.Add("@vRemark", SqlDbType.VarChar);
                cmd.Parameters.Add("@vCreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@vStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@vCustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@vInvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@vREP", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);

                cmd.Parameters["@vOrderID"].Value = orderDetail2.OrderID;
                cmd.Parameters["@vOrderDetailKey"].Value = orderDetail2.OrderDetailKey;
                cmd.Parameters["@vProductID"].Value = orderDetail2.ProductID;
                cmd.Parameters["@vOrderQty"].Value = orderDetail2.OrderQty;
                cmd.Parameters["@vPrice"].Value = orderDetail2.Price;
                cmd.Parameters["@vAmount"].Value = orderDetail2.Amount;
                cmd.Parameters["@vReturnFlag"].Value = orderDetail2.ReturnFlag;
                cmd.Parameters["@vRemark"].Value = orderDetail2.Remark;
                cmd.Parameters["@vCreateUserID"].Value = orderDetail2.CreateUserID;
                cmd.Parameters["@vStatus"].Value = orderDetail2.Status;
                cmd.Parameters["@vCustomerID"].Value = CustomerID;
                cmd.Parameters["@vInvoiceNumber"].Value = NewInvoiceNumber;
                cmd.Parameters["@vREP"].Value = REP;
                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;

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

        static public void sp_VALIDATION_RELEASE_ALLOCATE(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_VALIDATION_RELEASE_ALLOCATE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

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

        static public void sp_UPDATE_DeliveryDetail(String DeliverNumber, String OrderDetailKey, Decimal DeliveredQty, String Reason)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_DeliveryDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@DeliverNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDetailKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@DeliveredQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Reason", SqlDbType.VarChar);

                cmd.Parameters["@DeliverNumber"].Value = DeliverNumber;
                cmd.Parameters["@OrderDetailKey"].Value = OrderDetailKey;
                cmd.Parameters["@DeliveredQty"].Value = DeliveredQty;
                cmd.Parameters["@Reason"].Value = Reason;
                
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

        static public void sp_STOCKCHANGE_SAVE(String ProductID, String LOTNumber, Decimal Qty, String Status, String DestStatus, int Line)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_STOCKCHANGE_SAVE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOTNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@StockChangeQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@DestStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@LOTNumber"].Value = LOTNumber;
                cmd.Parameters["@StockChangeQty"].Value = Qty;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@DestStatus"].Value = DestStatus;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public String sp_DISASSEMBLY_SAVE(String NewDISNumber, String Site, String ProductID, String LOTNumber, String Status, DateTime Expiration, Decimal Qty,
            Decimal Amount, int Line)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_DISASSEMBLY_SAVE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewDISNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOTNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@Expiration", SqlDbType.DateTime);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewDISNumber"].Value = NewDISNumber;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@LOTNumber"].Value = LOTNumber;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@Expiration"].Value = Expiration;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_DISASSEMBLY_SAVE \nDetail : " + exception.Message.ToString();

                return ErrorText;
            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_MANUFACTURING_SAVE(String NewBCSMTKNumber, String Site, String ProductID, String LOTNumber, String Status, DateTime Expiration, Decimal Qty,
            Decimal Amount, int Line)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_MANUFACTURING_SAVE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewBCSMTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOTNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@Expiration", SqlDbType.DateTime);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewBCSMTKNumber"].Value = NewBCSMTKNumber;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@LOTNumber"].Value = LOTNumber;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@Expiration"].Value = Expiration;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;


                connection.Open();
                cmd.ExecuteNonQuery();
                return "Success";

            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_MANUFACTURING_SAVE \nDetail : " + exception.Message.ToString();

                return ErrorText;
            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_ASSEMBLY_SAVE(String NewASMNumber, String Site, String ProductID, String LOTNumber, String Status, DateTime Expiration, Decimal Qty,
            Decimal Amount, int Line)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ASSEMBLY_SAVE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewASMNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOTNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@Expiration", SqlDbType.DateTime);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewASMNumber"].Value = NewASMNumber;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@LOTNumber"].Value = LOTNumber;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@Expiration"].Value = Expiration;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_ASSEMBLY_SAVE \nDetail : " + exception.Message.ToString();

                return ErrorText;
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_SUBCONTRACT_SAVE(String Material, String Type, Decimal Qty, Decimal Lbs, Decimal FeeLbs, Decimal FeeTotal, DateTime Date, String Site, String Location, String Service, int Line, String Description, String ReceivingProductID, Decimal ReceivingQty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_SUBCONTRACT_SAVE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Material", SqlDbType.VarChar);
                cmd.Parameters.Add("@Type", SqlDbType.VarChar);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Lbs", SqlDbType.Decimal);
                cmd.Parameters.Add("@FeeLbs", SqlDbType.Decimal);
                cmd.Parameters.Add("@FeeTotal", SqlDbType.Decimal);
                cmd.Parameters.Add("@Date", SqlDbType.DateTime);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@Location", SqlDbType.VarChar);
                cmd.Parameters.Add("@Service", SqlDbType.VarChar);
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceivingProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceivingQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@Material"].Value = Material;
                cmd.Parameters["@Type"].Value = Type;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@Lbs"].Value = Lbs;
                cmd.Parameters["@FeeLbs"].Value = FeeLbs;
                cmd.Parameters["@FeeTotal"].Value = FeeTotal;
                cmd.Parameters["@Date"].Value = Date;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@Location"].Value = Location;
                cmd.Parameters["@Service"].Value = Service;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@Description"].Value = Description;
                cmd.Parameters["@ReceivingProductID"].Value = ReceivingProductID;
                cmd.Parameters["@ReceivingQty"].Value = ReceivingQty;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void csp_SUBCONTRACTRECEIPT_SAVE(String BCSSCNumber, DateTime Date, DateTime ExpDate, String NewRECNumber, String SupplierID, String Description)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_SUBCONTRACTRECEIPT_SAVE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BCSSCNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Date", SqlDbType.DateTime);
                cmd.Parameters.Add("@ExpirationDate", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewRECNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);

                cmd.Parameters["@BCSSCNumber"].Value = BCSSCNumber;
                cmd.Parameters["@Date"].Value = Date;
                cmd.Parameters["@ExpirationDate"].Value = ExpDate;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewRECNumber"].Value = NewRECNumber;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@Description"].Value = Description;

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

        static public string sp_DISASSEMBLYRECEIPT_SAVE(String NewSTKNumber, String DISNumber, String LOTNumber, DateTime AccountingDate, String Company, String Site,
            String ProductID, String Status, DateTime ExpirationDate, String Memo, Decimal Qty, int Line)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_DISASSEMBLYRECEIPT_SAVE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DISNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOTNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Company", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;
                cmd.Parameters["@DISNumber"].Value = DISNumber;
                cmd.Parameters["@LOTNumber"].Value = LOTNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@Company"].Value = Company;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@ExpirationDate"].Value = ExpirationDate;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_DISASSEMBLYRECEIPT_SAVE \nDetail : " + exception.Message.ToString();
                return ErrorText;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_STOCKCHANGE_SAVE_HEADER(DateTime AccountingDate, String Description, String Site)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_STOCKCHANGE_SAVE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@Description"].Value = Description;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public string sp_MANUFACTURINGRECEIPT_SAVE(String NewSTKNumber, String BCSMTKNumber, String LOTNumber, DateTime AccountingDate, String Company, String Site,
            String ProductID, String Status, DateTime ExpirationDate, String Memo, Decimal Qty, int Line)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_MANUFACTURINGRECEIPT_SAVE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@BCSMTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOTNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Company", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;
                cmd.Parameters["@BCSMTKNumber"].Value = BCSMTKNumber;
                cmd.Parameters["@LOTNumber"].Value = LOTNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@Company"].Value = Company;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@ExpirationDate"].Value = ExpirationDate;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                //return ex.ToString();
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_MANUFACTURINGRECEIPT_SAVE \nDetail : " + exception.Message.ToString();
                return ErrorText;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string sp_ASSEMBLYRECEIPT_SAVE(String NewSTKNumber, String ASMNumber, String LOTNumber, DateTime AccountingDate, String Company, String Site,
            String ProductID, String Status, DateTime ExpirationDate, String Memo, Decimal Qty, int Line)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ASSEMBLYRECEIPT_SAVE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ASMNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOTNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Company", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;
                cmd.Parameters["@ASMNumber"].Value = ASMNumber;
                cmd.Parameters["@LOTNumber"].Value = LOTNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@Company"].Value = Company;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@ExpirationDate"].Value = ExpirationDate;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_ASSEMBLYRECEIPT_SAVE \nDetail : " + exception.Message.ToString();
                return ErrorText;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string sp_ASSEMBLYRECEIPT_SAVE_HEADER(String NewSTKNumber, String ASMNumber, DateTime AccountingDate, String ReceiptMemo, String ReceiptCompany
            , String ReceiptSite)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ASSEMBLYRECEIPT_SAVE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ASMNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ReceiptMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceiptCompany", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceiptSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;
                cmd.Parameters["@ASMNumber"].Value = ASMNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@ReceiptMemo"].Value = ReceiptMemo;
                cmd.Parameters["@ReceiptCompany"].Value = ReceiptCompany;
                cmd.Parameters["@ReceiptSite"].Value = ReceiptSite;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_ASSEMBLYRECEIPT_SAVE_HEADER \nDetail : " + exception.Message.ToString();
                return ErrorText;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_DISASSEMBLY_SAVE_HEADER(String NewDISNumber, DateTime AccountingDate, String Description, String CompanyCode, String Site)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_DISASSEMBLY_SAVE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewDISNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewDISNumber"].Value = NewDISNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@Description"].Value = Description;
                cmd.Parameters["@CompanyCode"].Value = CompanyCode;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_DISASSEMBLY_SAVE_HEADER \nDetail : " + exception.Message.ToString();

                return ErrorText;
            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_MANUFACTURING_SAVE_HEADER(String NewBCSMTKNumber, DateTime AccountingDate, String Description, String CompanyCode, String Site)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_MANUFACTURING_SAVE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewBCSMTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewBCSMTKNumber"].Value = NewBCSMTKNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@Description"].Value = Description;
                cmd.Parameters["@CompanyCode"].Value = CompanyCode;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_MANUFACTURING_SAVE_HEADER \nDetail : " + exception.Message.ToString();

                return ErrorText;
            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_ASSEMBLY_SAVE_HEADER(String NewASMNumber, DateTime AccountingDate, String Description, String CompanyCode, String Site)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ASSEMBLY_SAVE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewASMNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewASMNumber"].Value = NewASMNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@Description"].Value = Description;
                cmd.Parameters["@CompanyCode"].Value = CompanyCode;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_ASSEMBLY_SAVE_HEADER \nDetail : " + exception.Message.ToString();

                return ErrorText;
            }
            finally
            {
                connection.Close();
            }
        }

        static public string sp_DISASSEMBLYRECEIPT_SAVE_HEADER(String NewSTKNumber, String DISNumber, DateTime AccountingDate, String ReceiptMemo, String ReceiptCompany
            , String ReceiptSite)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_DISASSEMBLYRECEIPT_SAVE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DISNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ReceiptMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceiptCompany", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceiptSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;
                cmd.Parameters["@DISNumber"].Value = DISNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@ReceiptMemo"].Value = ReceiptMemo;
                cmd.Parameters["@ReceiptCompany"].Value = ReceiptCompany;
                cmd.Parameters["@ReceiptSite"].Value = ReceiptSite;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_DISASSEMBLYRECEIPT_SAVE_HEADER \nDetail : " + exception.Message.ToString();
                return ErrorText;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string sp_MANUFACTURINGRECEIPT_SAVE_HEADER(String NewSTKNumber, String BCSMTKNumber, DateTime AccountingDate, String ReceiptMemo, String ReceiptCompany
            , String ReceiptSite)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_MANUFACTURINGRECEIPT_SAVE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@BCSMTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ReceiptMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceiptCompany", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceiptSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;
                cmd.Parameters["@BCSMTKNumber"].Value = BCSMTKNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@ReceiptMemo"].Value = ReceiptMemo;
                cmd.Parameters["@ReceiptCompany"].Value = ReceiptCompany;
                cmd.Parameters["@ReceiptSite"].Value = ReceiptSite;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_MANUFACTURINGRECEIPT_SAVE_HEADER \nDetail : " + exception.Message.ToString();
                return ErrorText;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_ASSEMBLYRECEIPT_SAVE_HEADER(String ASMNumber, DateTime AccountingDate, String Description, String Site)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ASSEMBLYRECEIPT_SAVE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ASMNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@ASMNumber"].Value = ASMNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@Description"].Value = Description;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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
       
        static public void sp_UPDATE_PickingNumberStatus(String PickingNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_PickingNumberStatus";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PickingNumber", SqlDbType.VarChar);

                cmd.Parameters["@PickingNumber"].Value = PickingNumber;

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

        static public void sp_UPDATE_DeletePickingDetail(String PickingNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_DeletePickingDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PickingNumber", SqlDbType.VarChar);

                cmd.Parameters["@PickingNumber"].Value = PickingNumber;

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

        static public void sp_UPDATE_PickingNumberDeliverable(String PickingNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_PickingNumberDeliverable";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PickingNumber", SqlDbType.VarChar);

                cmd.Parameters["@PickingNumber"].Value = PickingNumber;

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

        static public void sp_UPDATE_DeleteGLOALL(String ProductID, Decimal Qty, String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_DeleteGLOALL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);


                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@OrderID"].Value = OrderID;


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

        static public void sp_UPDATE_PickingDetail(OrderDetail2 orderDetail2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_PickingDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDetailKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReturnFlag", SqlDbType.VarChar);
                cmd.Parameters.Add("@Remark", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@PickingNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@PickingCategory", SqlDbType.VarChar);
                cmd.Parameters.Add("@PackedQty", SqlDbType.Decimal);
                
                cmd.Parameters["@OrderID"].Value = orderDetail2.OrderID;
                cmd.Parameters["@OrderDetailKey"].Value = orderDetail2.OrderDetailKey;
                cmd.Parameters["@ProductID"].Value = orderDetail2.ProductID;
                cmd.Parameters["@OrderQty"].Value = orderDetail2.OrderQty;
                cmd.Parameters["@Price"].Value = orderDetail2.Price;
                cmd.Parameters["@Amount"].Value = orderDetail2.Amount;
                cmd.Parameters["@ReturnFlag"].Value = orderDetail2.ReturnFlag;
                cmd.Parameters["@Remark"].Value = orderDetail2.Remark;
                cmd.Parameters["@CreateUserID"].Value = orderDetail2.CreateUserID;
                cmd.Parameters["@Status"].Value = orderDetail2.Status;
                cmd.Parameters["@PickingNumber"].Value = orderDetail2.PickingNumber;
                cmd.Parameters["@PickingCategory"].Value = orderDetail2.PickingCategory;
                cmd.Parameters["@PackedQty"].Value = orderDetail2.PackedQty;
                
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

        static public void sp_INSERT_PickingDetail(OrderDetail2 orderDetail2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INSERT_PickingDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDetailKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReturnFlag", SqlDbType.VarChar);
                cmd.Parameters.Add("@Remark", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@PickingNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@PickingCategory", SqlDbType.VarChar);
                cmd.Parameters.Add("@PackedQty", SqlDbType.Decimal);

                cmd.Parameters["@OrderID"].Value = orderDetail2.OrderID;
                cmd.Parameters["@OrderDetailKey"].Value = orderDetail2.OrderDetailKey;
                cmd.Parameters["@ProductID"].Value = orderDetail2.ProductID;
                cmd.Parameters["@OrderQty"].Value = orderDetail2.OrderQty;
                cmd.Parameters["@Price"].Value = orderDetail2.Price;
                cmd.Parameters["@Amount"].Value = orderDetail2.Amount;
                cmd.Parameters["@ReturnFlag"].Value = orderDetail2.ReturnFlag;
                cmd.Parameters["@Remark"].Value = orderDetail2.Remark;
                cmd.Parameters["@CreateUserID"].Value = orderDetail2.CreateUserID;
                cmd.Parameters["@Status"].Value = orderDetail2.Status;
                cmd.Parameters["@PickingNumber"].Value = orderDetail2.PickingNumber;
                cmd.Parameters["@PickingCategory"].Value = orderDetail2.PickingCategory;
                cmd.Parameters["@PackedQty"].Value = orderDetail2.PackedQty;

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
        
        static public void sp_UPDATE_RouteFinishCheckUncheck(String Action, int RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_RouteFinishCheckUncheck";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Action", SqlDbType.VarChar);
                cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);

                cmd.Parameters["@Action"].Value = Action;
                cmd.Parameters["@RouteNumber"].Value = RouteNumber;
                
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

        static public String sp_UPDATE_RouteFinishCheckUncheck_UserCheck()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_RouteFinishCheckUncheck_UserCheck";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string UserCheck = reader[0].ToString();
                    return UserCheck;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_LIST_PRODUCT_UserCheck()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_LIST_PRODUCT_UserCheck";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string UserCheck = reader[0].ToString();
                    return UserCheck;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_CreditRequest_Confirm_UserCheck()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CreditRequest_Confirm_UserCheck";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string UserCheck = reader[0].ToString();
                    return UserCheck;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_WMS_INTERSITETRANSFERS_ORDER_ISSUED_CHECK(String WHCHGNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WMS_INTERSITETRANSFERS_ORDER_ISSUED_CHECK";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@WHCHGNumber", SqlDbType.VarChar);

                cmd.Parameters["@WHCHGNumber"].Value = WHCHGNumber;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string IssuedCheck = reader[0].ToString();
                    return IssuedCheck;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_CreatePickinList_UserCheck()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CreatePickinList_UserCheck";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string UserCheck = reader[0].ToString();
                    return UserCheck;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_UPDATE_RouteReadyCheckUncheck(String Action, int RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_RouteReadyCheckUncheck";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Action", SqlDbType.VarChar);
                cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);

                cmd.Parameters["@Action"].Value = Action;
                cmd.Parameters["@RouteNumber"].Value = RouteNumber;

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

        static public void sp_UPDATE_DeliveryInvoiceReadyCheckUncheck(String Action, int RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_DeliveryInvoiceReadyCheckUncheck";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Action", SqlDbType.VarChar);
                cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);

                cmd.Parameters["@Action"].Value = Action;
                cmd.Parameters["@RouteNumber"].Value = RouteNumber;

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

        static public string getBranchFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT Branch ";
                sql = sql + "FROM Order2 WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Branch = reader[0].ToString();
                    return Branch;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_CustomerPaymentTerm(String CustomerID)
        {
            try
            {
                //string sql = "";
                //sql = sql + "SELECT A.PaymentTermKey ";
                //sql = sql + "FROM Customer A ";
                //sql = sql + "LEFT OUTER JOIN [CoreDBTmp].[dbo].[MigCustomer] B ON A.CustomerID = B.CustomerID and A.TraderEntityKey = B.TraderEntityKey ";
                //sql = sql + "WHERE B.X3CustomerID = '" + CustomerID + "' ";

                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_CustomerPaymentTerm";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    String PaymentTermKey = reader[0].ToString();
                    return PaymentTermKey;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_InvoicePaymentTerm(String InvoiceNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_InvoicePaymentTerm";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);

                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                
                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    String PaymentTermName = reader[0].ToString();
                    return PaymentTermName;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String getPaymentTermName(String PaymentTermKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT TermName ";
                sql = sql + "FROM PaymentTerm ";
                sql = sql + "WHERE PaymentTermKey = '" + PaymentTermKey + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    String TermName = reader[0].ToString();
                    return TermName;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public decimal getDiscountRate(String PaymentTermKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT DiscountRate2 ";
                sql = sql + "FROM PaymentTerm ";
                sql = sql + "WHERE PaymentTermKey = '" + PaymentTermKey + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Decimal DiscountRate2 = Convert.ToDecimal(reader[0].ToString());
                    return DiscountRate2;
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_ABCDEF(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_ABCDEF";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string ABCDEF = reader[0].ToString();
                    return ABCDEF;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_PORDER_GET_SupplierProductID(String SupplierID, String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PORDER_GET_SupplierProductID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@ProductID"].Value = ProductID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string SupplierProductID = reader[0].ToString();
                    return SupplierProductID;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_PORDER_GET_ProductSTKQty(String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PORDER_GET_ProductSTKQty";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CsInner = reader[0].ToString();
                    return CsInner;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public DateTime sp_PORDER_GET_ExpectedRcptDate(String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PORDER_GET_ExpectedRcptDate";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DateTime ExpectedRcptDate = Convert.ToDateTime(reader[0].ToString());
                    return ExpectedRcptDate;
                }
                else
                {
                    return Convert.ToDateTime("2000-01-01");
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Convert.ToDateTime("2000-01-01");
            }
            finally
            {
                connection2.Close();
            }
        }

        static public Decimal sp_PORDER_GET_GROSSPRICE(String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PORDER_GET_GROSSPRICE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Decimal PoUnitPr = Convert.ToDecimal(reader[0].ToString());
                    return PoUnitPr;
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_PAYMENTT_DEPOSITSLIPCHECK(String PaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PAYMENTT_DEPOSITSLIPCHECK";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentNumber", SqlDbType.VarChar);

                cmd.Parameters["@PaymentNumber"].Value = PaymentNumber;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string FRMNUM = reader[0].ToString();
                    return FRMNUM;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_NS_REVERSECHECK(String InvoiceNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_NS_REVERSECHECK";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);

                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string result = reader[0].ToString();
                    return result;
                }
                else
                {
                    return "Fail";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_STOCKCHANGE_GLOBAL(String ItemID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_STOCKCHANGE_GLOBAL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@ItemID"].Value = ItemID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string GLOALL = reader[0].ToString();
                    return GLOALL;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_ONHAND(String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_ONHAND";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Onhand = reader[0].ToString();
                    return Onhand;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_PackageNutCustomerPrice_Desc(String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_PackageNutCustomerPrice_Desc";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string ProductDesc = reader[0].ToString();
                    return ProductDesc;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_PackageNutCustomerPrice_PackSize(String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_PackageNutCustomerPrice_PackSize";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string PackSize = reader[0].ToString();
                    return PackSize;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewInvoiceNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewInvoiceNumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewInvoiceNumber", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection2.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewInvoiceNumber = cmd.Parameters["@NewInvoiceNumber"].Value.ToString();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());
                    return NewInvoiceNumber;
                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());
                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewBMWNumber(String Bank)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewBMWNumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewBMWNumber", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@Bank"].Value = Bank;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewBMWNumber = cmd.Parameters["@NewBMWNumber"].Value.ToString();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());
                    return NewBMWNumber;
                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());
                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewNSNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewNSNumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewNSNumber", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection2.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewNSNumber = cmd.Parameters["@NewNSNumber"].Value.ToString();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());
                    return NewNSNumber;

                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());
                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewORDNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewORDNumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewORDNumber", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection2.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewORDNumber = cmd.Parameters["@NewORDNumber"].Value.ToString();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());
                    return NewORDNumber;

                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());
                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_ManualOrder_CHECK_SEND(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_CHECK_SEND";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompleteFlag", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection2.Open();

                cmd.ExecuteNonQuery();
                
                string CompleteFlag = cmd.Parameters["@CompleteFlag"].Value.ToString();
                
                return CompleteFlag;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewDEPNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewDEPNumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string NewDEPNumber = reader[0].ToString();
                    return NewDEPNumber;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewWHCHGNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewWHCHGNumber";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string NewWHCHGNumber = reader[0].ToString();
                    return NewWHCHGNumber;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewPONumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewPONumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string NewPONumber = reader[0].ToString();
                    return NewPONumber;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewSTKNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewSTKNumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection2.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewSTKNumber = cmd.Parameters["@NewSTKNumber"].Value.ToString();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());
                    
                    return NewSTKNumber;
                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());
                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public int sp_ManualOrder_GET_NewOrderDetailKey(String OrderID, String Return)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_GET_NewOrderDetailKey";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Return", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewOrderDetailKey", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@Return"].Value = Return;

                connection2.Open();

                cmd.ExecuteNonQuery();

                int NewOrderDetailKey = (int)cmd.Parameters["@NewOrderDetailKey"].Value;
                return NewOrderDetailKey;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewRECNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewRECNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string NewRECNumber = reader[0].ToString();
                    return NewRECNumber;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewPAYXXNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewPAYXXNumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string NewPAYXXNumber = reader[0].ToString();
                    return NewPAYXXNumber;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewPINNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewPINNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string NewPINNumber = reader[0].ToString();
                    return NewPINNumber;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewDeliveryNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewDeliveryNumber";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewDeliveryNumber", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;
                
                cmd.Parameters["@CreateUserID"].Value = GATE.userID;
                
                connection2.Open();
                
                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string DeliveryNumber = cmd.Parameters["@NewDeliveryNumber"].Value.ToString();
                
                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());

                    string NewDeliveryNumber = DeliveryNumber;
                    return NewDeliveryNumber;
                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());

                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewBCSPRNNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewBCSPRNNumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string NewBCSPRNNumber = reader[0].ToString();
                    return NewBCSPRNNumber;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_CustomerNameByCustomerID(String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_CustomerNameByCustomerID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CustomerName = reader[1].ToString();
                    return CustomerName;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public CustInfo sp_GET_CustomerInfoByCustomerID(String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_CustomerInfoByCustomerID";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    CustInfo custInfo = new CustInfo();
                    custInfo.CustomerID = reader[0].ToString();
                    custInfo.CustomerName = reader[1].ToString();
                    custInfo.Address1 = reader[2].ToString();
                    custInfo.Address2 = reader[3].ToString();
                    custInfo.Branch = reader[4].ToString();
                    
                    return custInfo;
                }
                else
                {
                    CustInfo custInfo = new CustInfo();
                    return custInfo;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                CustInfo custInfo = new CustInfo();
                return custInfo;
            }
            finally
            {
                connection2.Close();
            }
        }


        static public String sp_GET_NewPaymentNumber(String PAM_0)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewPaymentNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PAM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);


                cmd.Parameters["@PAM_0"].Value = PAM_0;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string NewPaymentNumber = reader[0].ToString();
                    return NewPaymentNumber;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }
        
        static public String sp_GET_PickingNumberCategory(String PickingNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_PickingNumberCategory";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PickingNumber", SqlDbType.VarChar);

                cmd.Parameters["@PickingNumber"].Value = PickingNumber;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Category = reader[0].ToString();
                    return Category;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public Decimal sp_GET_CashTotal(String RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_CashCheckTotal";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteNumber", SqlDbType.VarChar);

                cmd.Parameters["@RouteNumber"].Value = RouteNumber;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Decimal Cash = Convert.ToDecimal(reader[1].ToString());
                    return Cash;
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public Decimal sp_GET_Route_Amount(int RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_Route_Amount";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);

                cmd.Parameters["@RouteNumber"].Value = RouteNumber;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Decimal RouteAmount = Convert.ToDecimal(reader[0].ToString());
                    return RouteAmount;
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string sp_OCCUPIED_CHECK(String RefNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_OCCUPIED_CHECK";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RefNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@RefNumber"].Value = RefNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    String Check = reader[0].ToString();
                    return Check;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_OCCUPIED_RELEASE(String RefNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_OCCUPIED_RELEASE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RefNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                
                cmd.Parameters["@RefNumber"].Value = RefNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteReader();
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

        static public void sp_OCCUPIED_FINISHED(String RefNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_OCCUPIED_FINISHED";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RefNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);


                cmd.Parameters["@RefNumber"].Value = RefNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteReader();
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

        static public void sp_ORDER_COMPLETE(String iPadOrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ORDER_COMPLETE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@iPadOrderID", SqlDbType.VarChar);

                cmd.Parameters["@iPadOrderID"].Value = iPadOrderID;

                connection2.Open();
                cmd.ExecuteReader();
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

        static public Decimal sp_GET_CheckTotal(String RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_CashCheckTotal";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteNumber", SqlDbType.VarChar);

                cmd.Parameters["@RouteNumber"].Value = RouteNumber;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Decimal Check = Convert.ToDecimal(reader[2].ToString());
                    return Check;
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public DateTime getOrderDateFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT OrderDate ";
                sql = sql + "FROM Order2 WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DateTime OrderDate = Convert.ToDateTime(reader[0].ToString());
                    return OrderDate;
                }
                else
                {
                    DateTime DefaultDate = Convert.ToDateTime("1900-01-01");
                    return DefaultDate;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                DateTime DefaultDate = Convert.ToDateTime("1900-01-01");
                return DefaultDate;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public DateTime getDeliveryDateFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "select IIF(cast(Delv.CreateTime as time) > '18:00:00' and cast(Delv.CreateTime as time) <= '23:59:59.999', DATEADD(Day, 1, Delv.CreateTime),Delv.CreateTime) AS ShipDate ";
                sql = sql + "FROM Delivery Delv WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DateTime DeliveryDate = Convert.ToDateTime(reader[0].ToString());
                    return DeliveryDate;
                }
                else
                {
                    DateTime DefaultDate = Convert.ToDateTime("1900-01-01");
                    return DefaultDate;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                DateTime DefaultDate = Convert.ToDateTime("1900-01-01");
                return DefaultDate;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getDriverFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT B.DriverName ";
                sql = sql + "FROM Order2 A WITH(NOLOCK) ";
                sql = sql + "LEFT OUTER JOIN Route B WITH(NOLOCK) ON A.RouteNumber = B.RouteNumber ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string DriverName = reader[0].ToString();
                    return DriverName;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getTruckFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT B.TruckPlateNumber ";
                sql = sql + "FROM Order2 A WITH(NOLOCK) ";
                sql = sql + "LEFT OUTER JOIN Route B WITH(NOLOCK) ON A.RouteNumber = B.RouteNumber ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string TruckPlateNumber = reader[0].ToString();
                    return TruckPlateNumber;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getDriverFromRouteNumber(string RouteNumber)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT DriverName ";
                sql = sql + "FROM Route ";
                sql = sql + "WHERE RouteNumber = '" + RouteNumber + "' ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string DriverName = reader[0].ToString();
                    return DriverName;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }
        
        static public string getPlateNoFromRouteNumber(string RouteNumber)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT TruckPlateNumber ";
                sql = sql + "FROM Route ";
                sql = sql + "WHERE RouteNumber = '" + RouteNumber + "' ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string TruckPlateNumber = reader[0].ToString();
                    return TruckPlateNumber;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }
        
        static public string getCustomerIDFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT CustomerID ";
                sql = sql + "FROM Order2 WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CustomerID = reader[0].ToString();
                    return CustomerID;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getSaleRepFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT SaleRep ";
                sql = sql + "FROM Order2 WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Rep = reader[0].ToString();
                    return Rep;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getMarkUpMemo(string Customer)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT A.CustomerMemo ";
                sql = sql + "FROM Customer A ";
                sql = sql + "WHERE A.CustomerID = '" + Customer + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Memo = reader[0].ToString();
                    return Memo;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getCoreCustomerID(string CustomerID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT A.CustomerID ";
                sql = sql + "FROM [CoreDBTmp].[dbo].[MigCustomer] A ";
                sql = sql + "WHERE A.X3CustomerID = '" + CustomerID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Memo = reader[0].ToString();
                    return Memo;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getShipAddressByCustomerID(string CustomerID)
        {
            try
            {
                string sql = "";
                sql = sql + "select B.BPCNAM_0, A.BPAADDLIG_0, A.CTY_0, A.SAT_0, A.POSCOD_0, A.TEL_0, B.REP_0  ";
                sql = sql + "from BPADDRESS A ";
                sql = sql + "left outer join BPCUSTOMER B ON A.BPANUM_0 = B.BPCNUM_0 ";
                sql = sql + "WHERE A.BPAADD_0 = 'SHIP' AND B.BPCNUM_0 = '" + CustomerID + "' ";
                sql = sql + "";
                
                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CustomerName = reader[0].ToString();
                    string ShipAddress1 = reader[1].ToString();
                    string ShipCity = reader[2].ToString();
                    string ShipState = reader[3].ToString();
                    string ShipZip = reader[4].ToString();
                    string Tel = reader[5].ToString();
                    string SalesRep = reader[6].ToString();
                    
                    string ShipAddress = "[" + SalesRep  + "] " + CustomerName + "\n" + ShipAddress1 + "\n" + ShipCity + ", " + ShipState + " " + ShipZip + "\n" + Tel;
                    return ShipAddress;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getShipToFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT CustomerName,ShipAddress1,ShipAddress2,ShipCity,ShipState,ShipZip,B.TEL_0 ";
                sql = sql + "FROM Order2 A WITH(NOLOCK) ";
                sql = sql + "LEFT OUTER JOIN BPADDRESS B WITH(NOLOCK) ON A.CustomerID = B.BPANUM_0 and B.BPAADD_0 = 'SHIP' ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CustomerName = reader[0].ToString();
                    string ShipAddress1 = reader[1].ToString();
                    string ShipAddress2 = reader[2].ToString();
                    if (reader[2].ToString() != "")
                    {
                        ShipAddress2 = ShipAddress2 + "\n";
                    }
                    string ShipCity = reader[3].ToString();
                    string ShipState = reader[4].ToString();
                    string ShipZip = reader[5].ToString();
                    string Tel = reader[6].ToString();

                    string ShipTo = CustomerName + "\n" + ShipAddress1 + "\n" + ShipCity + ", " + ShipState + " " + ShipZip + "\n" + Tel;
                    return ShipTo;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getBillToFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT CustomerName,BillAddress1,BillAddress2,BillCity,BillState,BillZip ";
                sql = sql + "FROM Order2 WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CustomerName = reader[0].ToString();
                    string BillAddress1 = reader[1].ToString();
                    string BillAddress2 = reader[2].ToString();
                    if (reader[2].ToString() != "")
                    {
                        BillAddress2 = BillAddress2 + "\n";
                    }
                    string BillCity = reader[3].ToString();
                    string BillState = reader[4].ToString();
                    string BillZip = reader[5].ToString();

                    string BillTo = CustomerName + "\n" + BillAddress1 + "\n" + BillCity + ", " + BillState + " " + BillZip;
                    return BillTo;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getOrderStatusFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT OrderStatus ";
                sql = sql + "FROM Order2 WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string OrderStatus = reader[0].ToString();
                    return OrderStatus;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getOrderStatusFromSPick(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT OrderStatus ";
                sql = sql + "FROM SPick WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string OrderStatus = reader[0].ToString();
                    return OrderStatus;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_CREATE_PickingNumber(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CREATE_PickingNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_CREATE_Pick(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CREATE_Pick";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_CREATE_Invoice(String OrderID, String InvoiceNumber, String NewSTKNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CREATE_Invoice";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;

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

        static public void sp_CREATE_Delivery(String OrderID, String NewSTKNumber, String NewDeliveryNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CREATE_Delivery";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewDeliveryNumber", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;
                cmd.Parameters["@NewDeliveryNumber"].Value = NewDeliveryNumber;

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

        static public void sp_CREATE_DIR(String Site, String Company, DateTime AccountingDate, String CustomerID, String Memo, String GL, Decimal Amount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CREATE_DIR";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@Company", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@GL", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@Company"].Value = Company;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@GL"].Value = GL;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_CREATE_PickDetail(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CREATE_PickDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_CREATE_DeliveryDetail(String OrderID, String NewSTKNumber, String NewDeliveryNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CREATE_DeliveryDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewDeliveryNumber", SqlDbType.VarChar);
                
                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;
                cmd.Parameters["@NewDeliveryNumber"].Value = NewDeliveryNumber;

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

        static public void sp_UPDATE_RouteStatus(int RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_RouteStatus";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);
                
                cmd.Parameters["@RouteNumber"].Value = RouteNumber;
                
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

        static public void sp_LIST_DRIVER_DELETE(String id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_LIST_DRIVER_DELETE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_LIST_DRIVER_NEW(String DriverName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_LIST_DRIVER_NEW";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@DriverName", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@DriverName"].Value = DriverName;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_UPDATE_DeliveryStatus(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_DeliveryStatus";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

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

        static public String sp_GET_RouteStatus(int RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_RouteStatus";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);

                cmd.Parameters["@RouteNumber"].Value = RouteNumber;
            
                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string RouteStatus = reader[0].ToString();
                    return RouteStatus;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_PickingListMemo(String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_PickingListMemo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string PickingListMemo = reader[0].ToString();
                    return PickingListMemo;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public Decimal sp_GET_SUGARTAX(String NewDeliveryNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_SUGARTAX";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewDeliveryNumber", SqlDbType.VarChar);

                cmd.Parameters["@NewDeliveryNumber"].Value = NewDeliveryNumber;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Decimal TotalSugarTax = Convert.ToDecimal(reader[0].ToString());
                    return TotalSugarTax;
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_SITE(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_SITE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    String SITE = reader[0].ToString();
                    return SITE;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewOrderDetailKey()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewOrderDetailKey";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);

                //cmd.Parameters["@RouteNumber"].Value = RouteNumber;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string RouteStatus = reader[0].ToString();

                    return RouteStatus;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_Order2OrderStatus(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_Order2OrderStatus";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string RouteStatus = reader[0].ToString();
                    return RouteStatus;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_DeliveryStatus(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_DeliveryStatus";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string RouteStatus = reader[0].ToString();
                    return RouteStatus;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_PreviousBalance(String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_PreviousBalance";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string AR = reader[1].ToString();
                    return AR;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_TotalAmount(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_TotalAmount";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string TotalAmount = reader[1].ToString();
                    return TotalAmount;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_PickStatus(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_PickStatus";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string RouteStatus = reader[0].ToString();
                    return RouteStatus;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_BoxesbyPickingNumber(String PickingNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_BoxesbyPickingNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PickingNumber", SqlDbType.VarChar);

                cmd.Parameters["@PickingNumber"].Value = PickingNumber;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string RouteStatus = reader[0].ToString();
                    return RouteStatus;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_PickingNumber_isDeliverable(String PickingNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PickingNumber_isDeliverable";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PickingNumber", SqlDbType.VarChar);

                cmd.Parameters["@PickingNumber"].Value = PickingNumber;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string RouteStatus = reader[0].ToString();
                    return RouteStatus;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public bool sp_CHECK_BulkNutLabelList(int RouteNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_BulkNutLabelList";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteNumber", SqlDbType.VarChar);

                cmd.Parameters["@RouteNumber"].Value = RouteNumber.ToString();

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
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
                connection2.Close();
            }
        }

        static public bool sp_CHECK_NewBrandCode(String BrandCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_NewBrandCode";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);

                cmd.Parameters["@BrandCode"].Value = BrandCode;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
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
                connection2.Close();
            }
        }

        static public bool sp_CHECK_NewProductID(String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_NewProductID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
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
                connection2.Close();
            }
        }

        static public bool sp_CHECK_NewSupplierCode(String SupplierCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_NewSupplierCode";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierCode", SqlDbType.VarChar);

                cmd.Parameters["@SupplierCode"].Value = SupplierCode;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
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
                connection2.Close();
            }
        }

        static public bool sp_CHECK_NewCustomerID(String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_NewCustomerID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
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
                connection2.Close();
            }
        }

        static public bool sp_CHECK_NewCompanyCode(String CompanyCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_NewCompanyCode";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);

                cmd.Parameters["@CompanyCode"].Value = CompanyCode;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
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
                connection2.Close();
            }
        }

        static public bool sp_CHECK_NewBrandName(String BrandName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_NewBrandName";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandName", SqlDbType.VarChar);

                cmd.Parameters["@BrandName"].Value = BrandName;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
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
                connection2.Close();
            }
        }

        static public String sp_GET_OrderIDfromPickingNumber(String PickingNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_OrderIDfromPickingNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PickingNumber", SqlDbType.VarChar);

                cmd.Parameters["@PickingNumber"].Value = PickingNumber;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string RouteStatus = reader[0].ToString();
                    return RouteStatus;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getRouteNumberFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT RouteNumber ";
                sql = sql + "FROM Order2 WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string RouteNumber = reader[0].ToString();
                    return RouteNumber;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getRouteStopFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT RouteStop ";
                sql = sql + "FROM Order2 WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string RouteStop = reader[0].ToString();
                    return RouteStop;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getTermFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT B.TermName ";
                sql = sql + "FROM Order2 A ";
                sql = sql + "LEFT OUTER JOIN PaymentTerm B ON A.PaymentTermKey = B.PaymentTermKey ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string TermName = reader[0].ToString();
                    return TermName;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getTermFromOrderID2(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT A.PaymentTermKey ";
                sql = sql + "FROM Order2 A WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string TermName = reader[0].ToString();
                    return TermName;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getSalesPersonFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT SaleRep ";
                sql = sql + "FROM Order2 WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string SaleRep = reader[0].ToString();
                    return SaleRep;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getSalesPersonMobileFromOrderID(string OrderID)
        {
            try
            {
                //string sql = "";
                //sql = sql + "SELECT B.PhoneMobile ";
                //sql = sql + "FROM Order2 A WITH(NOLOCK) ";
                //sql = sql + "LEFT OUTER JOIN Employee B WITH(NOLOCK) ON A.SaleRep = B.EmployeeID and B.IsActive = 0 ";
                //sql = sql + "WHERE OrderID = '" + OrderID + "' ";

                string sql = "";
                sql = sql + "SELECT B.TEL_0 ";
                sql = sql + "FROM Order2 A WITH(NOLOCK) ";
                sql = sql + "LEFT OUTER JOIN SALESREP B WITH(NOLOCK) ON A.SaleRep = B.REPNUM_0 ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string PhoneMobile = reader[0].ToString();
                    return PhoneMobile;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getCreditAmountFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT CreditAmount ";
                sql = sql + "FROM Order2 WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID = '" + OrderID + "' ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CreditAmount = reader[0].ToString();
                    return CreditAmount;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getTotalBoxFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT A.OrderID, SUM(B.Box) AS TotalBox ";
                sql = sql + "FROM Order2 A WITH(NOLOCK) ";
                sql = sql + "LEFT OUTER JOIN PickingNumber B WITH(NOLOCK) ON A.OrderID = B.OrderID ";
                sql = sql + "WHERE A.OrderID = '" + OrderID + "' ";
                sql = sql + "GROUP BY A.OrderID ";
                
                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string TotalBox = reader[1].ToString();
                    return TotalBox;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getABoxFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT B.PickingNumber, B.Box, C.PickingCategory ";
                sql = sql + "FROM PickingNumber A WITH(NOLOCK) ";
                sql = sql + "LEFT OUTER JOIN PickingNumber B WITH(NOLOCK) ON A.OrderID = B.OrderID ";
                sql = sql + "LEFT OUTER JOIN OrderDetail2 C WITH(NOLOCK) ON B.PickingNumber = C.PickingNumber ";
                sql = sql + "WHERE A.OrderID = '" + OrderID + "' AND PickingCategory = 'A' ";
                sql = sql + "group by B.PickingNumber, B.Box, C.PickingCategory ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Box = reader[1].ToString();
                    return Box;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getRouteFinish(int RouteNumber)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT A.Complete ";
                sql = sql + "FROM Route A ";
                sql = sql + "WHERE A.RouteNumber = '" + RouteNumber + "' ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Complete = reader[0].ToString();
                    return Complete;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getBBoxFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT B.PickingNumber, B.Box, C.PickingCategory ";
                sql = sql + "FROM PickingNumber A WITH(NOLOCK) ";
                sql = sql + "LEFT OUTER JOIN PickingNumber B WITH(NOLOCK) ON A.OrderID = B.OrderID ";
                sql = sql + "LEFT OUTER JOIN OrderDetail2 C WITH(NOLOCK) ON B.PickingNumber = C.PickingNumber ";
                sql = sql + "WHERE A.OrderID = '" + OrderID + "' AND PickingCategory = 'B' ";
                sql = sql + "group by B.PickingNumber, B.Box, C.PickingCategory ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Box = reader[1].ToString();
                    return Box;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getCBoxFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT B.PickingNumber, B.Box, C.PickingCategory ";
                sql = sql + "FROM PickingNumber A WITH(NOLOCK) ";
                sql = sql + "LEFT OUTER JOIN PickingNumber B WITH(NOLOCK) ON A.OrderID = B.OrderID ";
                sql = sql + "LEFT OUTER JOIN OrderDetail2 C WITH(NOLOCK) ON B.PickingNumber = C.PickingNumber ";
                sql = sql + "WHERE A.OrderID = '" + OrderID + "' AND PickingCategory = 'C' ";
                sql = sql + "group by B.PickingNumber, B.Box, C.PickingCategory ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Box = reader[1].ToString();
                    return Box;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getDBoxFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT B.PickingNumber, B.Box, C.PickingCategory ";
                sql = sql + "FROM PickingNumber A WITH(NOLOCK) ";
                sql = sql + "LEFT OUTER JOIN PickingNumber B WITH(NOLOCK) ON A.OrderID = B.OrderID ";
                sql = sql + "LEFT OUTER JOIN OrderDetail2 C WITH(NOLOCK) ON B.PickingNumber = C.PickingNumber ";
                sql = sql + "WHERE A.OrderID = '" + OrderID + "' AND PickingCategory = 'D' ";
                sql = sql + "group by B.PickingNumber, B.Box, C.PickingCategory ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Box = reader[1].ToString();
                    return Box;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getEBoxFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT B.PickingNumber, B.Box, C.PickingCategory ";
                sql = sql + "FROM PickingNumber A WITH(NOLOCK) ";
                sql = sql + "LEFT OUTER JOIN PickingNumber B WITH(NOLOCK) ON A.OrderID = B.OrderID ";
                sql = sql + "LEFT OUTER JOIN OrderDetail2 C WITH(NOLOCK) ON B.PickingNumber = C.PickingNumber ";
                sql = sql + "WHERE A.OrderID = '" + OrderID + "' AND PickingCategory = 'E' ";
                sql = sql + "group by B.PickingNumber, B.Box, C.PickingCategory ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Box = reader[1].ToString();
                    return Box;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getFBoxFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT B.PickingNumber, B.Box, C.PickingCategory ";
                sql = sql + "FROM PickingNumber A WITH(NOLOCK) ";
                sql = sql + "LEFT OUTER JOIN PickingNumber B WITH(NOLOCK) ON A.OrderID = B.OrderID ";
                sql = sql + "LEFT OUTER JOIN OrderDetail2 C WITH(NOLOCK) ON B.PickingNumber = C.PickingNumber ";
                sql = sql + "WHERE A.OrderID = '" + OrderID + "' AND PickingCategory = 'F' ";
                sql = sql + "group by B.PickingNumber, B.Box, C.PickingCategory ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Box = reader[1].ToString();
                    return Box;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getReturnAmountFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT SUM(Amount) ";
                sql = sql + "  FROM SRETURNDTemp WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID  = '" + OrderID + "' ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string ReturnAmount = reader[0].ToString();
                    return ReturnAmount;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getDeliveryNumberFromOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT DeliveryNumber ";
                sql = sql + "  FROM Delivery WITH(NOLOCK) ";
                sql = sql + "WHERE OrderID  = '" + OrderID + "' ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string DeliveryNumber = reader[0].ToString();
                    return DeliveryNumber;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_UPDATE_RouteInfo(int RouteNumber, String DriverName, String TruckPlate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_RouteInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteNumber", SqlDbType.Int);
                cmd.Parameters.Add("@DriverName", SqlDbType.VarChar);
                cmd.Parameters.Add("@TruckPlate", SqlDbType.VarChar);


                cmd.Parameters["@RouteNumber"].Value = RouteNumber;
                cmd.Parameters["@DriverName"].Value = DriverName;
                cmd.Parameters["@TruckPlate"].Value = TruckPlate;
                
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

        static public void sp_DeliveryMenifest_DeliveryNotePickup(String DeliveryNumber, String CheckUncheck)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_DeliveryMenifest_DeliveryNotePickup";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@DeliveryNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheckUncheck", SqlDbType.VarChar);
                
                cmd.Parameters["@DeliveryNumber"].Value = DeliveryNumber;
                cmd.Parameters["@CheckUncheck"].Value = CheckUncheck;

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

        static public void sp_PackageNutLabel_PrintedCheck(String iPadOrderID, String CheckUncheck)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PackageNutLabel_PrintedCheck";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@iPadOrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheckUncheck", SqlDbType.VarChar);

                cmd.Parameters["@iPadOrderID"].Value = iPadOrderID;
                cmd.Parameters["@CheckUncheck"].Value = CheckUncheck;

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

        static public void cbo_itemID(ComboBox cbo_productID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [ProductID] ";
                sql = sql + "FROM Product with(nolock) ";
                sql = sql + "WHERE IsInActive = 0 and ProductKey > 99 ";
                sql = sql + "Order by ProductID";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_productID.Items.Add(reader[0].ToString().Trim());
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

        static public void cbo_AllProduct(ComboBox cbo_productID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [ProductID] ";
                sql = sql + "FROM Product with(nolock) ";
                sql = sql + "WHERE ProductKey > 99 ";
                sql = sql + "Order by ProductID";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_productID.Items.Add(reader[0].ToString().Trim());
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

        static public void cbo_site(ComboBox cbo_box)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT FCY_0 ";
                sql = sql + "FROM FACILITY ";
                //sql = sql + "WHERE IsInActive = 0 ";
                sql = sql + "ORDER BY FCY_0";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_box.Items.Add(reader[0].ToString().Trim());
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

        static public void cbo_bank(ComboBox cbo_box)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT BAN_0 ";
                sql = sql + "FROM BANK ";
                //sql = sql + "WHERE IsInActive = 0 ";
                sql = sql + "ORDER BY BAN_0";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_box.Items.Add(reader[0].ToString().Trim());
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

        static public void cbo_paymentType(ComboBox cbo_box)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT PAYTYP_0 ";
                sql = sql + "FROM TABPAYTYP ";
                sql = sql + "WHERE ENAFLG_0 = 2 ";
                sql = sql + "ORDER BY PAYTYP_0 DESC ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_box.Items.Add(reader[0].ToString().Trim());
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

        static public string getProductKeyFromItemID(string ItemID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT ProductKey ";
                sql = sql + "FROM Product ";
                sql = sql + "WHERE ProductID = '" + ItemID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string ProductKey = reader[0].ToString();
                    return ProductKey;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getItemDescFromItemID(string ItemID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT ProductDesc ";
                sql = sql + "FROM Product WITH(NOLOCK) ";
                sql = sql + "WHERE ProductID = '" + ItemID + "' AND IsInActive = 0 ";
                sql = sql + "";

                connection3.Open();
                SqlCommand cmd = new SqlCommand(sql, connection3);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string ProductDesc = reader[0].ToString();
                    return ProductDesc;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection3.Close();
            }
        }

        static public string getItemUnitFromItemID(string ItemID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT PurchaseUnit ";
                sql = sql + "FROM Product WITH(NOLOCK) ";
                sql = sql + "WHERE ProductID = '" + ItemID + "' AND IsInActive = 0 ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Unit = reader[0].ToString();
                    return Unit;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getItemPackSizeFromItemID(string ItemID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT StrPackSize ";
                sql = sql + "FROM Product WITH(NOLOCK) ";
                sql = sql + "WHERE ProductID = '" + ItemID + "' AND IsInActive = 0 ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string PackSize = reader[0].ToString();
                    return PackSize;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getItemUnitPriceFromItemID(string ItemID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT UnitPr ";
                sql = sql + "FROM Product WITH(NOLOCK) ";
                sql = sql + "WHERE ProductID = '" + ItemID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string UnitPr = reader[0].ToString();
                    return UnitPr;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getItemBasePriceFromItemID(string ItemID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT BasePrice ";
                sql = sql + "FROM Product A ";
                sql = sql + "WHERE ProductID = '" + ItemID + "' and IsinActive = 0 ";

                sql = sql + "";
                sql = sql + "";
                sql = sql + "";
                sql = sql + "";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string BasePrice = reader[0].ToString();
                    return BasePrice;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getItemBottomPriceFromItemID(string ItemID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT BottomPr ";
                sql = sql + "FROM Product WITH(NOLOCK) ";
                sql = sql + "WHERE ProductID = '" + ItemID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string BottomPr = reader[0].ToString();
                    return BottomPr;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getItemOnhandFromItemID(string ItemID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT PHYQTY - (GLOALL + DETAILED) ";
                sql = sql + "FROM Product WITH(NOLOCK) ";
                sql = sql + "WHERE ProductID = '" + ItemID + "' and IsInActive = 0 ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string QtyOnHand = reader[0].ToString();
                    return QtyOnHand;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getNJItemOnhandFromItemID(string ItemID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT PHYQTYWH ";
                sql = sql + "FROM Product ";
                sql = sql + "WHERE ProductID = '" + ItemID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string QtyOnHand = reader[0].ToString();
                    return QtyOnHand;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string getItemInnerFromItemID(string ItemID)
        {
            try
            {
                string sql = "";
                //sql = sql + "SELECT LastOutCost ";
                sql = sql + "SELECT ItemPack ";
                sql = sql + "FROM Product WITH(NOLOCK) ";
                sql = sql + "WHERE ProductID = '" + ItemID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string LastOutCost = reader[0].ToString();
                    return LastOutCost;
                }
                else
                {
                    return "";
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }


        static public void sp_UPDATE_OrderDetail2OutOfStock(String OrderID, int OrderDetailKey)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_OrderDetail2OutOfStock";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDetailKey", SqlDbType.Int);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@OrderDetailKey"].Value = OrderDetailKey;
                
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

        static public void sp_PORDER_SelectionHeader(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, string SearchPOID, string SearchPOSupplier, string SearchPOSite, string SearchPOMemo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PORDER_SelectionHeader2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@PONumber", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Supplier", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Site", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.NVarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@PONumber"].Value = SearchPOID;
                cmd.Parameters["@Supplier"].Value = SearchPOSupplier;
                cmd.Parameters["@Site"].Value = SearchPOSite;
                cmd.Parameters["@Memo"].Value = SearchPOMemo;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PRECEIPT_HEADER(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, string SearchPPOID, string SearchPRECID, string SearchRECSupplier, string SearchRECSite, string SearchRECMemo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PRECEIPT_HEADER2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@PONumber", SqlDbType.NVarChar);
                cmd.Parameters.Add("@RECNumber", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Supplier", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Site", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.NVarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@PONumber"].Value = SearchPPOID;
                cmd.Parameters["@RECNumber"].Value = SearchPRECID;
                cmd.Parameters["@Supplier"].Value = SearchRECSupplier;
                cmd.Parameters["@Site"].Value = SearchRECSite;
                cmd.Parameters["@Memo"].Value = SearchRECMemo;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PRECEIPT_DETAIL(DataGridView _dataGridView, String RECNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PRECEIPT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RECNumber", SqlDbType.VarChar);

                cmd.Parameters["@RECNumber"].Value = RECNumber;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PRECEIPT_DETAIL_RECEIVING(DataGridView _dataGridView, String RECNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PRECEIPT_DETAIL_RECEIVING";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RECNumber", SqlDbType.VarChar);

                cmd.Parameters["@RECNumber"].Value = RECNumber;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PINVOICE_DETAIL(DataGridView _dataGridView, String PINNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PINVOICE_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PINNumber", SqlDbType.VarChar);

                cmd.Parameters["@PINNumber"].Value = PINNumber;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PORDER_SelectionDetail(DataGridView _dataGridView, String PORDERNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PORDER_SelectionDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PORDERNumber", SqlDbType.VarChar);

                cmd.Parameters["@PORDERNumber"].Value = PORDERNumber;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PORDER_Detail(DataGridView _dataGridView, String PORDERNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PORDER_Detail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PORDERNumber", SqlDbType.VarChar);

                cmd.Parameters["@PORDERNumber"].Value = PORDERNumber;

                connection.Open();

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
                connection.Close();
            }
        }

        static public Decimal sp_GET_SUBCONTRACTFEE(String BCSSCNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_SUBCONTRACTFEE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BCSSCNumber", SqlDbType.VarChar);

                cmd.Parameters["@BCSSCNumber"].Value = BCSSCNumber;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Decimal Fee = Convert.ToDecimal(reader[0].ToString());
                    return Fee;
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public Decimal sp_GET_GlobalQty(String OrderID, String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_GlobalQty";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@ProductID"].Value = ProductID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Decimal GlobalQty = Convert.ToDecimal(reader[0].ToString());
                    return GlobalQty;
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public Decimal sp_GET_GLOALL(int ProductKey)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_GLOALL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductKey", SqlDbType.Int);

                cmd.Parameters["@ProductKey"].Value = ProductKey;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Decimal GLOALL = Convert.ToDecimal(reader[0].ToString());
                    return GLOALL;
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public Decimal sp_GET_DETAILED(int ProductKey)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_DETAILED";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductKey", SqlDbType.Int);

                cmd.Parameters["@ProductKey"].Value = ProductKey;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Decimal DETAILED = Convert.ToDecimal(reader[0].ToString());
                    return DETAILED;
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_Commission(DataGridView _dataGridView, String REP, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Commission";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@REP", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@REP"].Value = REP;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_delivery_Nut(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, String NutNumber, String MixORNot)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_delivery_Nut";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@NutNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@MixORNot", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@NutNumber"].Value = NutNumber;
                cmd.Parameters["@MixORNot"].Value = MixORNot;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_GET_PackageNutProduct(ComboBox comboBox)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_PackageNutProduct";
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Product = reader["ProductID"].ToString().Trim();
                    comboBox.Items.Add(Product);
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

        static public void sp_GET_PackageNutCustomerOption_Customer(ComboBox comboBox)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_PackageNutCustomerOption_Customer";
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Customer = reader["BPCNUM"].ToString().Trim();
                    comboBox.Items.Add(Customer);
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

        static public void sp_GET_PackageNutCustomerOption_Customer(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_PackageNutCustomerOption_Customer";
                cmd.CommandType = CommandType.StoredProcedure;
                
                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_GET_PackageNutCustomerPrice_Customer(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_PackageNutCustomerPrice_Customer";
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PackageNutCustomerOption_Detail(DataGridView _dataGridView, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection4;
                cmd.CommandText = "dbo.sp_PackageNutCustomerOption_Detail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection4.Open();

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
                connection4.Close();
            }
        }

        static public void sp_PackageNutCustomerPrice_Detail(DataGridView _dataGridView, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection4;
                cmd.CommandText = "dbo.sp_PackageNutCustomerPrice_Detail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection4.Open();

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
                connection4.Close();
            }
        }

        static public void sp_PackageNutCustomerOption_Update(String CustomerID, String ProductID, String Name1, String Name2, String UPC, String ContainerSize, Decimal RetailPrice, Decimal NetOZ, Decimal NetLB, String Ingredient)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PackageNutCustomerOption_Update";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Name1", SqlDbType.VarChar);
                cmd.Parameters.Add("@Name2", SqlDbType.VarChar);
                cmd.Parameters.Add("@UPC", SqlDbType.VarChar);
                cmd.Parameters.Add("@ContainerSize", SqlDbType.Decimal);
                cmd.Parameters.Add("@RetailPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@NetOZ", SqlDbType.Decimal);
                cmd.Parameters.Add("@NetLB", SqlDbType.Decimal);
                cmd.Parameters.Add("@Ingredient", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Name1"].Value = Name1;
                cmd.Parameters["@Name2"].Value = Name2;
                cmd.Parameters["@UPC"].Value = UPC;
                cmd.Parameters["@ContainerSize"].Value = ContainerSize;
                cmd.Parameters["@RetailPrice"].Value = RetailPrice;
                cmd.Parameters["@NetOZ"].Value = NetOZ;
                cmd.Parameters["@NetLB"].Value = NetLB;
                cmd.Parameters["@Ingredient"].Value = Ingredient;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PackageNutCustomerPrice_Update(String CustomerID, String ProductID, Decimal RetailPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PackageNutCustomerPrice_Update";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@RetailPrice", SqlDbType.Decimal);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@RetailPrice"].Value = RetailPrice;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PackageNutCustomerOption_Create(String CustomerID, String ProductID, String Name1, String Name2, String UPC, String ContainerSize, Decimal RetailPrice, Decimal NetOZ, Decimal NetLB, String Ingredient)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PackageNutCustomerOption_Create";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Name1", SqlDbType.VarChar);
                cmd.Parameters.Add("@Name2", SqlDbType.VarChar);
                cmd.Parameters.Add("@UPC", SqlDbType.VarChar);
                cmd.Parameters.Add("@ContainerSize", SqlDbType.Decimal);
                cmd.Parameters.Add("@RetailPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@NetOZ", SqlDbType.Decimal);
                cmd.Parameters.Add("@NetLB", SqlDbType.Decimal);
                cmd.Parameters.Add("@Ingredient", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Name1"].Value = Name1;
                cmd.Parameters["@Name2"].Value = Name2;
                cmd.Parameters["@UPC"].Value = UPC;
                cmd.Parameters["@ContainerSize"].Value = ContainerSize;
                cmd.Parameters["@RetailPrice"].Value = RetailPrice;
                cmd.Parameters["@NetOZ"].Value = NetOZ;
                cmd.Parameters["@NetLB"].Value = NetLB;
                cmd.Parameters["@Ingredient"].Value = Ingredient;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PackageNutCustomerPrice_Create(String CustomerID, String ProductID,Decimal RetailPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PackageNutCustomerPrice_Create";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@RetailPrice", SqlDbType.Decimal);
                
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@RetailPrice"].Value = RetailPrice;
                
                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public bool sp_CHECK_PackageNutCustomerOption(String CustomerID, String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_PackageNutCustomerOption";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@ProductID"].Value = ProductID;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
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
                connection2.Close();
            }
        }

        static public bool sp_CHECK_PackageNutCustomerPrice(String CustomerID, String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_PackageNutCustomerPrice";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@ProductID"].Value = ProductID;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
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
                connection2.Close();
            }
        }

        static public String sp_PackageNutLabel_StoreAddress(String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PackageNutLabel_StoreAddress";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;


                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    String StoreAddress = reader[0].ToString();
                    return StoreAddress;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_PackageNutLabel_StoreName(String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PackageNutLabel_StoreName";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    String StoreNam = reader[0].ToString();
                    return StoreNam;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_Top_Product_Summary(DataGridView _dataGridView, String ProductID, String Salerep, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Top_Product_Report_Summary";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Input_ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@SaleRep", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@SaleRep"].Value = Salerep;
                cmd.Parameters["@Input_ProductID"].Value = ProductID;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

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
        static public void sp_Top20_Product_Summary(DataGridView _dataGridView, String ProductID, String SaleRep, DateTime FromDate, DateTime ToDate, int Type)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Top20_Product_Report_Summary";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Input_ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@SaleRep", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Type", SqlDbType.Int);

                cmd.Parameters["@Input_ProductID"].Value = ProductID;
                cmd.Parameters["@SaleRep"].Value = SaleRep;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@Type"].Value = Type;

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
        static public void sp_Top_Product_Detail(DataGridView _dataGridView, String ProductID, String Salerep, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Top_Product_Report_Detail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Input_ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Salerep", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@Input_ProductID"].Value = ProductID;
                cmd.Parameters["@Salerep"].Value = Salerep;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

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

        static public void sp_IPAD_ORDER_DIFF(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_IPAD_ORDER_DIFF";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_IPAD_ORDER_DIFF_TOTAL_AMOUNT(DateTime FromDate, DateTime ToDate, CustomTextBox IPADAmount, CustomTextBox OrderAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_IPAD_ORDER_TOTAL_AMOUNT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;


                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IPADAmount.Text = reader[1].ToString();
                    OrderAmount.Text = reader[2].ToString();
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

        static public String sp_CREATE_NewReturn(String DeliveryNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_CREATE_NewReturn";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@DeliveryNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@RETURN", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                
                cmd.Parameters["@DeliveryNumber"].Value = DeliveryNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();

                String return1 = cmd.Parameters["@RETURN"].Value.ToString();
                return return1;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "error";
            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_DuplicateSalesOrder(String DeliveryNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_DuplicateSalesOrder";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@DeliveryNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@RETURN", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                cmd.Parameters["@DeliveryNumber"].Value = DeliveryNumber;

                connection.Open();
                cmd.ExecuteNonQuery();

                String return1 = cmd.Parameters["@RETURN"].Value.ToString();
                return return1;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "error";
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_LotInformation(DataGridView _dataGridView, String ProductID, String Status, String STOFCY)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_LotInformation";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@STOFCY", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@STOFCY"].Value = STOFCY;

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

        static public String sp_CHECK_ADDORDERTOROUTEPLAN(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_ADDORDERTOROUTEPLAN";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@RouteNumber", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection2.Open();

                cmd.ExecuteNonQuery();
                
                string RouteNumber = cmd.Parameters["@RouteNumber"].Value.ToString().Trim();
                return RouteNumber;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "1";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_SalesOrderExceptionReport(DataGridView _dataGridView, DateTime FromDate, DateTime AsOfDate, String CheckNumber, String CustomerID, String SOOpenStatus, String SOFromX3)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_SalesOrderExceptionReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@AsOfDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@CheckNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@SOOpenStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@SOFromX3", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@AsOfDate"].Value = AsOfDate;
                cmd.Parameters["@CheckNumber"].Value = CheckNumber;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@SOOpenStatus"].Value = SOOpenStatus;
                cmd.Parameters["@SOFromX3"].Value = SOFromX3;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PurchaseOrderExceptionReport(DataGridView _dataGridView, DateTime FromDate, DateTime AsOfDate, String CheckNumber, String SupplierID, String POOpenStatus, String POFromX3)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PurchaseOrderExceptionReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@AsOfDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@CheckNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@POOpenStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@POFromX3", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@AsOfDate"].Value = AsOfDate;
                cmd.Parameters["@CheckNumber"].Value = CheckNumber;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@POOpenStatus"].Value = POOpenStatus;
                cmd.Parameters["@POFromX3"].Value = POFromX3;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_AROPENCLOSE2_Search(DataGridView _dataGridView, DateTime GetDate, String CheckNumber, String CustomerID, String ARStatus)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_AR_OPENCLOSE2_Search";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@GetDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@CheckNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ARStatus", SqlDbType.VarChar);

                cmd.Parameters["@GetDate"].Value = GetDate;
                cmd.Parameters["@CheckNumber"].Value = CheckNumber;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@ARStatus"].Value = ARStatus;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_DeliveryOS_Report(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, String DeliveryNumber, String SalesRep, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_DeliveryOS_Report";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@DeliveryNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@SalesRep", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@DeliveryNumber"].Value = DeliveryNumber;
                cmd.Parameters["@SalesRep"].Value = SalesRep;
                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }
        
        static public void cbo_Subcontract_Supplier(ComboBox cbo_Supplier)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "sp_GET_Subcontract_Supplier";
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Supplier = reader[0].ToString().Trim();
                    cbo_Supplier.Items.Add(Supplier);
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

        static public void sp_SubContractExceptionReport(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, String Supplier, String POStatus, String APStatus)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_SubContractExceptionReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Supplier", SqlDbType.VarChar);
                cmd.Parameters.Add("@POStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@APStatus", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@Supplier"].Value = Supplier;
                cmd.Parameters["@POStatus"].Value = POStatus;
                cmd.Parameters["@APStatus"].Value = APStatus;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_StockValuationReport(DataGridView _dataGridView, DateTime AsOfDate, String Site, String Status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_StockValuationReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@AsOfDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);

                cmd.Parameters["@AsOfDate"].Value = AsOfDate;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@Status"].Value = Status;
               
                connection.Open();

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
                connection.Close();
            }
        }

        static public CustomerInfoObject sp_GET_CustomerInfo(String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_CustomerInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection2.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                CustomerInfoObject customerInfoObject = new CustomerInfoObject();

                if (sqlDataReader.Read())
                {
                    customerInfoObject.CustomerID = sqlDataReader["CustomerID"].ToString().Trim();
                    customerInfoObject.CustomerName = sqlDataReader["CustomerName"].ToString().Trim();
                    customerInfoObject.SalesRep = sqlDataReader["SalesRep"].ToString().Trim();

                    customerInfoObject.BillAddress1 = sqlDataReader["BillAddress1"].ToString().Trim();
                    customerInfoObject.BillAddress2 = sqlDataReader["BillAddress2"].ToString().Trim();
                    customerInfoObject.BillCity = sqlDataReader["BillCity"].ToString().Trim();
                    customerInfoObject.BillState = sqlDataReader["BillState"].ToString().Trim();
                    customerInfoObject.BillPostalCode = sqlDataReader["BillPostalCode"].ToString().Trim();
                    customerInfoObject.BillPhone = sqlDataReader["BillPhone"].ToString().Trim();

                    customerInfoObject.ShipAddress1 = sqlDataReader["ShipAddress1"].ToString().Trim();
                    customerInfoObject.ShipAddress2 = sqlDataReader["ShipAddress2"].ToString().Trim();
                    customerInfoObject.ShipCity = sqlDataReader["ShipCity"].ToString().Trim();
                    customerInfoObject.ShipState = sqlDataReader["ShipState"].ToString().Trim();
                    customerInfoObject.ShipPostalCode = sqlDataReader["ShipPostalCode"].ToString().Trim();
                    customerInfoObject.ShipPhone = sqlDataReader["ShipPhone"].ToString().Trim();
                }
                return customerInfoObject;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                CustomerInfoObject customerInfoObject = new CustomerInfoObject();
                return customerInfoObject;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public ManualOrderProductObject sp_GET_ManualOrderProductInfo(String ProductID, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_ManualOrderProductInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection2.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                ManualOrderProductObject manualOrderProductObject = new ManualOrderProductObject();

                if (sqlDataReader.Read())
                {
                    manualOrderProductObject.ProductKey = sqlDataReader["ProductKey"].ToString().Trim();
                    manualOrderProductObject.ProductID = sqlDataReader["ProductID"].ToString().Trim();
                    manualOrderProductObject.ProductDesc = sqlDataReader["ProductDesc"].ToString().Trim();
                    manualOrderProductObject.PackSize = sqlDataReader["PackSize"].ToString().Trim();
                    manualOrderProductObject.Onhand = Convert.ToDecimal(sqlDataReader["Onhand"].ToString().Trim() ?? "0");
                    manualOrderProductObject.ListPrice = Convert.ToDecimal(sqlDataReader["ListPrice"].ToString().Trim() ?? "0");
                    manualOrderProductObject.LastPrice = Convert.ToDecimal(sqlDataReader["LastPrice"].ToString().Trim() ?? "0");
                    manualOrderProductObject.BasePrice = Convert.ToDecimal(sqlDataReader["BasePrice"].ToString().Trim() ?? "0");
                    manualOrderProductObject.BottomPrice = Convert.ToDecimal(sqlDataReader["BottomPrice"].ToString().Trim() ?? "0");
                    manualOrderProductObject.CustomPrice = Convert.ToDecimal(sqlDataReader["CustomPrice"].ToString().Trim() ?? "0");
                }
                return manualOrderProductObject;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                ManualOrderProductObject manualOrderProductObject = new ManualOrderProductObject();
                return manualOrderProductObject;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_ManualOrderSend_header(String NewORDNumber, String CustomerID, String REP, Decimal CreditAmount, String OrderMemo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ManualOrderSend_header";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewORDNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@REP", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@OrderMemo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewORDNumber"].Value = NewORDNumber;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@REP"].Value = REP;
                cmd.Parameters["@CreditAmount"].Value = CreditAmount;
                cmd.Parameters["@OrderMemo"].Value = OrderMemo;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                
                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_ManualOrderSend_detail(String NewORDNumber, int Line, String ProductID, Decimal Qty, Decimal Price, String Return, String Remark)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ManualOrderSend_detail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewORDNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal);
                cmd.Parameters.Add("@Return", SqlDbType.VarChar);
                cmd.Parameters.Add("@Remark", SqlDbType.VarChar);

                cmd.Parameters["@NewORDNumber"].Value = NewORDNumber;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@Price"].Value = Price;
                cmd.Parameters["@Return"].Value = Return;
                cmd.Parameters["@Remark"].Value = Remark;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_ManualOrder_Search(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_Search";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

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

        static public ManualOrderHeader sp_ManualOrder_SELECT(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection2.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                ManualOrderHeader manualOrderHeader = new ManualOrderHeader();

                if (sqlDataReader.Read())
                {
                    manualOrderHeader.OrderID = sqlDataReader["OrderID"].ToString().Trim();
                    manualOrderHeader.CustomerID = sqlDataReader["CustomerID"].ToString().Trim();
                    manualOrderHeader.OrderMemo = sqlDataReader["OrderMemo"].ToString().Trim();
                    manualOrderHeader.CreditAmount = Convert.ToDecimal(sqlDataReader["CreditAmount"].ToString().Trim() ?? "0");
                }
                return manualOrderHeader;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                ManualOrderHeader manualOrderHeader = new ManualOrderHeader();
                return manualOrderHeader;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_ManualOrder_detail(DataGridView _dataGridView, String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_detail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

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

        static public void sp_ManualOrder_INSERT_DETAIL(String OrderID, int OrderDetailKey, String ProductID, Decimal Qty, Decimal Price, String Return, String Remark)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_INSERT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDetailKey", SqlDbType.Int);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal);
                cmd.Parameters.Add("@Return", SqlDbType.VarChar);
                cmd.Parameters.Add("@Remark", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@OrderDetailKey"].Value = OrderDetailKey;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@Price"].Value = Price;
                cmd.Parameters["@Return"].Value = Return;
                cmd.Parameters["@Remark"].Value = Remark;

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

        static public void sp_ManualOrder_DELETE_DETAIL(String OrderID, int OrderDetailKey)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_DELETE_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDetailKey", SqlDbType.Int);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@OrderDetailKey"].Value = OrderDetailKey;

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

        static public void sp_ManualOrder_UPDATE_DETAIL(String OrderID, int OrderDetailKey, Decimal Qty, Decimal Price, String Remark)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_UPDATE_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDetailKey", SqlDbType.Int);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal);
                cmd.Parameters.Add("@Remark", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@OrderDetailKey"].Value = OrderDetailKey;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@Price"].Value = Price;
                cmd.Parameters["@Remark"].Value = Remark;

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

        static public void sp_ManualOrder_CREATE_HEADER(String NewORDNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_CREATE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewORDNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);

                cmd.Parameters["@NewORDNumber"].Value = NewORDNumber;
                cmd.Parameters["@UserID"].Value = GATE.userID;

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

        static public void sp_ManualOrder_SET_CustomerID(String OrderID, String CustomerID, String REP)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_SET_CustomerID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@REP", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@REP"].Value = REP;

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

        static public void sp_ManualOrder_UPDATE_HEADER(String OrderID, String OrderMemo, Decimal CreditAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_UPDATE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@OrderMemo"].Value = OrderMemo;
                cmd.Parameters["@CreditAmount"].Value = CreditAmount;

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

        static public void sp_ManualOrder_SEND(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_SEND";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                
                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@UserID"].Value = GATE.userID;

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

        static public void sp_ManualOrder_SalesHistory(DataGridView _dataGridView, String CustomerID, String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_SalesHistory";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@ProductID"].Value = ProductID;

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

        static public void sp_PriceListEntry_Header(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PriceListEntry_Header";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@PriceListRecord", SqlDbType.VarChar);
                //cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                //cmd.Parameters["@PriceListRecord"].Value = PriceListRecord;
                //cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PriceListEntry_Detail(DataGridView _dataGridView, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PriceListEntry_Detail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

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

        static public void sp_PriceListEntry_UPDATE_Price(int ROWID, Decimal Price)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PriceListEntry_UPDATE_Price";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ROWID", SqlDbType.Int);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@ROWID"].Value = ROWID;
                cmd.Parameters["@Price"].Value = Price;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public String sp_PriceListEntry_INSERT(String CustomerID, String ProductID, Decimal Price)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PriceListEntry_INSERT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Price", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@INSERT", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Price"].Value = Price;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                

                connection2.Open();
                cmd.ExecuteNonQuery();

                string INSERT = cmd.Parameters["@INSERT"].Value.ToString();
                
                return INSERT;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "NO";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_PriceListEntry_DELETE(int ROWID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PriceListEntry_DELETE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ROWID", SqlDbType.Int);

                cmd.Parameters["@ROWID"].Value = ROWID;

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

        static public void sp_ACCOUNT_GET_SUBACCOUNT(ComboBox cbo_subAccount, string AccountName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ACCOUNT_GET_SUBACCOUNT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@AccountName", SqlDbType.VarChar);

                cmd.Parameters["@AccountName"].Value = AccountName;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_subAccount.Items.Add(reader[0].ToString().Trim());
                    //MessageBox.Show(reader[1].ToString().Trim());
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

        static public String sp_ACCOUNT_INSERT_GACCOUNT(String Type, String Name, String SubAccount, String Description, String AccountNumber, String RoutingNumber, Decimal OpeningBalance, DateTime AsOf)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ACCOUNT_INSERT_GACCOUNT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Type", SqlDbType.VarChar);
                cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@SubAccount", SqlDbType.VarChar);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@RoutingNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@OpeningBalance", SqlDbType.Decimal);
                cmd.Parameters.Add("@AsOf", SqlDbType.DateTime);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@RETURN", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                cmd.Parameters["@Type"].Value = Type;
                cmd.Parameters["@Name"].Value = Name;
                cmd.Parameters["@SubAccount"].Value = SubAccount;
                cmd.Parameters["@Description"].Value = Description;
                cmd.Parameters["@AccountNumber"].Value = AccountNumber;
                cmd.Parameters["@RoutingNumber"].Value = RoutingNumber;
                cmd.Parameters["@OpeningBalance"].Value = OpeningBalance;
                cmd.Parameters["@AsOf"].Value = AsOf;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();

                String return1 = cmd.Parameters["@RETURN"].Value.ToString();
                return return1;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "error";

            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_GET_Accounts(DataGridViewComboBoxColumn ComboBox)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ACCOUNT_CHARTOFACCOUNT";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                //cmd.Parameters["@SupplierID"].Value = SupplierID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Account = reader["DES_0"].ToString().Trim();
                    ComboBox.Items.Add(Account);
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

        static public void sp_ACCOUNT_GENERALJOURNALENTRIES_NAME(DataGridViewComboBoxColumn ComboBox)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ACCOUNT_GENERALJOURNALENTRIES_NAME";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                //cmd.Parameters["@SupplierID"].Value = SupplierID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Name = reader["Name"].ToString().Trim();
                    ComboBox.Items.Add(Name);
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

        static public String sp_GET_NewGJENumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewGJENumber";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewEntryNumber", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@NewGJENumber", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();

                cmd.ExecuteNonQuery();

                string NewEntryNumber = cmd.Parameters["@NewEntryNumber"].Value.ToString();
                string NewGJENumber = cmd.Parameters["@NewGJENumber"].Value.ToString();

                return NewGJENumber;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_GJE_INSERT_HEADER(string NewEntryNumber, string NewGJENumber, DateTime AccountDate, string Company)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GJE_INSERT_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewEntryNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewGJENumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Company", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewEntryNumber"].Value = NewEntryNumber;
                cmd.Parameters["@NewGJENumber"].Value = NewGJENumber;
                cmd.Parameters["@AccountDate"].Value = AccountDate;
                cmd.Parameters["@Company"].Value = Company;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_GJE_UPDATE_HEADER(string GJENumber, DateTime AccountDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GJE_UPDATE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@GJENumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@GJENumber"].Value = GJENumber;
                cmd.Parameters["@AccountDate"].Value = AccountDate;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_GJE_INSERT_DETAIL(string NewEntryNumber, string NewGJENumber, DateTime AccountDate, int Line, string Company, string ACC, string Name, decimal Amount, int SNS, string Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GJE_INSERT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewEntryNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewGJENumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@Company", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Type", SqlDbType.VarChar);
                cmd.Parameters.Add("@ACC", SqlDbType.VarChar);
                cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@SNS", SqlDbType.Int);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewEntryNumber"].Value = NewEntryNumber;
                cmd.Parameters["@NewGJENumber"].Value = NewGJENumber;
                cmd.Parameters["@AccountDate"].Value = AccountDate;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@Company"].Value = Company;
                //cmd.Parameters["@Type"].Value = Type;
                cmd.Parameters["@ACC"].Value = ACC;
                cmd.Parameters["@Name"].Value = Name;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@SNS"].Value = SNS;
                cmd.Parameters["@Memo"].Value = Memo;

                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_NS_SINVOICE(string InvoiceNumber, Decimal CreditTotal)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_NS_SINVOICE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditTotal", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@CreditTotal"].Value = CreditTotal;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_NS_INSERT(string NSNumber, string InvoiceNumber, string CreditType, int NSCreditTypeNumber, string CreditNumber, Decimal CreditAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_NS_INSERT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NSNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditType", SqlDbType.VarChar);
                cmd.Parameters.Add("@NSCreditTypeNumber", SqlDbType.Int);
                cmd.Parameters.Add("@CreditNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NSNumber"].Value = NSNumber;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@CreditType"].Value = CreditType;
                cmd.Parameters["@NSCreditTypeNumber"].Value = NSCreditTypeNumber;
                cmd.Parameters["@CreditNumber"].Value = CreditNumber;
                cmd.Parameters["@CreditAmount"].Value = CreditAmount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_NS_CREDIT(string NSNumber, string InvoiceNumber, string CreditType, string CreditNumber, Decimal CreditAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_NS_CREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NSNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditType", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NSNumber"].Value = NSNumber;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@CreditType"].Value = CreditType;
                cmd.Parameters["@CreditNumber"].Value = CreditNumber;
                cmd.Parameters["@CreditAmount"].Value = CreditAmount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_NS_CREDIT_AP(string NSNumber, string InvoiceNumber, string CreditType, string CreditNumber, Decimal CreditAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_NS_CREDIT_AP";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NSNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditType", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);

                cmd.Parameters["@NSNumber"].Value = NSNumber;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@CreditType"].Value = CreditType;
                cmd.Parameters["@CreditNumber"].Value = CreditNumber;
                cmd.Parameters["@CreditAmount"].Value = CreditAmount;
                cmd.Parameters["@User"].Value = GATE.userID;

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

        static public void sp_NS_DEBIT_AP(string NSNumber, string InvoiceNumber, string DebitType, string DebitNumber, Decimal DebitAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_NS_DEBIT_AP";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NSNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DebitType", SqlDbType.VarChar);
                cmd.Parameters.Add("@DebitNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DebitAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);

                cmd.Parameters["@NSNumber"].Value = NSNumber;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@DebitType"].Value = DebitType;
                cmd.Parameters["@DebitNumber"].Value = DebitNumber;
                cmd.Parameters["@DebitAmount"].Value = DebitAmount;
                cmd.Parameters["@User"].Value = GATE.userID;

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

        static public void sp_NS_AccountingJournal(string CompanyName, string CustomerID, string NSNumber, string InvoiceNumber, string CreditType, string CreditNumber, Decimal CreditAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_NS_AccountingJournal";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@NSNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditType", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CompanyName"].Value = CompanyName;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@NSNumber"].Value = NSNumber;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@CreditType"].Value = CreditType;
                cmd.Parameters["@CreditNumber"].Value = CreditNumber;
                cmd.Parameters["@CreditAmount"].Value = CreditAmount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_NS_AccountingJournal_AP_Credit(string CompanyName, string SupplierID, string NSNumber, string InvoiceNumber, string CreditType, string CreditNumber, Decimal CreditAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_NS_AccountingJournal_AP_Credit";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@NSNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditType", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);

                cmd.Parameters["@CompanyName"].Value = CompanyName;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@NSNumber"].Value = NSNumber;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@CreditType"].Value = CreditType;
                cmd.Parameters["@CreditNumber"].Value = CreditNumber;
                cmd.Parameters["@CreditAmount"].Value = CreditAmount;
                cmd.Parameters["@User"].Value = GATE.userID;

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

        static public void sp_NS_AccountingJournal_AP_Debit(string CompanyName, string SupplierID, string NSNumber, string InvoiceNumber, string DebitType, string DebitNumber, Decimal DebitAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_NS_AccountingJournal_AP_Debit";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@NSNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DebitType", SqlDbType.VarChar);
                cmd.Parameters.Add("@DebitNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DebitAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);

                cmd.Parameters["@CompanyName"].Value = CompanyName;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@NSNumber"].Value = NSNumber;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@DebitType"].Value = DebitType;
                cmd.Parameters["@DebitNumber"].Value = DebitNumber;
                cmd.Parameters["@DebitAmount"].Value = DebitAmount;
                cmd.Parameters["@User"].Value = GATE.userID;

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

        static public ProductObject sp_GET_ProductInfo(String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_GET_ProductInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;

                connection3.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                ProductObject productObject = new ProductObject();

                if (sqlDataReader.Read())
                {
                    productObject.CdPackDeptTypeCode = sqlDataReader["CdPackDeptTypeCode"].ToString().Trim();
                    productObject.IsInActive = sqlDataReader["IsInActive"].ToString().Trim();
                    productObject.Brand = sqlDataReader["Brand"].ToString().Trim();
                    productObject.FlgPause = sqlDataReader["FlgPause"].ToString().Trim();
                    productObject.ProductKey = sqlDataReader["ProductKey"].ToString().Trim();
                    productObject.ProductID = sqlDataReader["ProductID"].ToString().Trim();
                    productObject.ProductDesc = sqlDataReader["ProductDesc"].ToString().Trim();
                    productObject.ItemPack = Convert.ToDecimal(sqlDataReader["ItemPack"].ToString().Trim() ?? "0");
                    productObject.ItemSize = Convert.ToDecimal(sqlDataReader["ItemSize"].ToString().Trim() ?? "0");
                    productObject.ItemSizeUnit = sqlDataReader["ItemSizeUnit"].ToString().Trim() ?? "";
                    productObject.StrPackSize = sqlDataReader["StrPackSize"].ToString().Trim();
                    productObject.SalesUnit = sqlDataReader["SalesUnit"].ToString().Trim();
                    productObject.UnitPr = Convert.ToDecimal(sqlDataReader["UnitPr"].ToString().Trim());
                    productObject.BottomPr = Convert.ToDecimal(sqlDataReader["BottomPr"].ToString().Trim());
                    productObject.ShelfLife = sqlDataReader["ShelfLife"].ToString().Trim() ?? "";
                    productObject.GuaranteeDay = Convert.ToDecimal(sqlDataReader["GuaranteeDay"].ToString().Trim());
                    productObject.PurchaseUnit = sqlDataReader["PurchaseUnit"].ToString().Trim();
                    productObject.StockConversionQty = Convert.ToDecimal(sqlDataReader["StockConversionQty"].ToString().Trim());
                    productObject.PalletTier = Convert.ToDecimal(sqlDataReader["PalletTier"].ToString().Trim() ?? "0");
                    productObject.PalletHeight = Convert.ToDecimal(sqlDataReader["PalletHeight"].ToString().Trim() ?? "0");
                    productObject.BasePrice = Convert.ToDecimal(sqlDataReader["BasePrice"].ToString().Trim() ?? "0");
                    productObject.PickName = sqlDataReader["PickName"].ToString().Trim() ?? "";
                    productObject.PickBarCode = sqlDataReader["PickBarCode"].ToString().Trim() ?? "";
                    productObject.UPCUnit = sqlDataReader["UPCUnit"].ToString().Trim() ?? "";
                    productObject.UPCCase = sqlDataReader["UPCCase"].ToString().Trim() ?? "";
                    productObject.CommissionCode1 = sqlDataReader["CommissionCode1"].ToString().Trim() ?? "";
                    productObject.IncentiveCode1 = sqlDataReader["IncentiveCode1"].ToString().Trim() ?? "";
                    productObject.LOCID = sqlDataReader["LOCID"].ToString().Trim() ?? "";
                    productObject.SubPickZone = sqlDataReader["SubPickZone"].ToString().Trim() ?? "";
                    productObject.KosherLabel1 = sqlDataReader["KosherLabel1"].ToString().Trim() ?? "";
                    productObject.Organic = sqlDataReader["Organic"].ToString().Trim() ?? "";
                    productObject.Vegan = sqlDataReader["Vegan"].ToString().Trim() ?? "";
                    productObject.GlutenFree = sqlDataReader["GlutenFree"].ToString().Trim() ?? "";
                    productObject.NonGMO = sqlDataReader["NonGMO"].ToString().Trim() ?? "";
                    productObject.Kosher = sqlDataReader["Kosher"].ToString().Trim() ?? "";
                    productObject.CheeseNumber = sqlDataReader["CheeseNumber"].ToString().Trim() ?? "";
                    productObject.Onhand = Convert.ToDecimal(sqlDataReader["Onhand"].ToString().Trim() ?? "0");
                    productObject.BCSStockQ = Convert.ToDecimal(sqlDataReader["BCSStockQ"].ToString().Trim() ?? "0");
                    productObject.BCSStockR = Convert.ToDecimal(sqlDataReader["BCSStockR"].ToString().Trim() ?? "0");
                    productObject.WH2StockA = Convert.ToDecimal(sqlDataReader["WH2StockA"].ToString().Trim() ?? "0");
                    productObject.WH2StockQ = Convert.ToDecimal(sqlDataReader["WH2StockQ"].ToString().Trim() ?? "0");
                    productObject.WH2StockR = Convert.ToDecimal(sqlDataReader["WH2StockR"].ToString().Trim() ?? "0");
                    //MessageBox.Show(productObject.UnitPr.ToString());
                }
                return productObject;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                ProductObject productObject = new ProductObject();
                return productObject;
            }
            finally
            {
                connection3.Close();
            }
        }

        static public ProductObject sp_GET_WH2Stock(String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_WH2Stock";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;

                connection2.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                ProductObject productObject = new ProductObject();

                if (sqlDataReader.Read())
                {
                    productObject.WH2A = Convert.ToDecimal(sqlDataReader["A"].ToString().Trim() ?? "0");
                    productObject.WH2Q = Convert.ToDecimal(sqlDataReader["Q"].ToString().Trim() ?? "0");
                    productObject.WH2R = Convert.ToDecimal(sqlDataReader["R"].ToString().Trim() ?? "0");
                    //MessageBox.Show(productObject.UnitPr.ToString());
                }
                return productObject;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                ProductObject productObject = new ProductObject();
                return productObject;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_WMS_INTERSITETRANSFERS_INSERT_DETAIL(String WHCHGNumber, int DetailKey, String ProductID, String ProductDesc, 
            String PackSize, String SalesUnit, String Site, String Status, Decimal Qty,
            Decimal BasePrice, Decimal Amount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WMS_INTERSITETRANSFERS_INSERT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@WHCHGNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DetailKey", SqlDbType.Int);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductDesc", SqlDbType.VarChar);
                cmd.Parameters.Add("@PackSize", SqlDbType.VarChar);
                cmd.Parameters.Add("@SalesUnit", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@BasePrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@Result", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@WHCHGNumber"].Value = WHCHGNumber;
                cmd.Parameters["@DetailKey"].Value = DetailKey;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@ProductDesc"].Value = ProductDesc;
                cmd.Parameters["@PackSize"].Value = PackSize;
                cmd.Parameters["@SalesUnit"].Value = SalesUnit;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@BasePrice"].Value = BasePrice;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                
                connection2.Open();
                cmd.ExecuteNonQuery();

                string Result = cmd.Parameters["@Result"].Value.ToString();

                //MessageBox.Show(Result);
                return Result;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "Fail";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_WMS_INTERSITETRANSFERS_CREATE_HEADER(String NewWHCHGNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WMS_INTERSITETRANSFERS_CREATE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewWHCHGNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);


                cmd.Parameters["@NewWHCHGNumber"].Value = NewWHCHGNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                
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

        static public void sp_WMS_INTERSITETRANSFERS_Search(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WMS_INTERSITETRANSFERS_Search";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

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

        static public void sp_WMS_INTERSITETRANSFERS_UPDATE_HEADER(String WHCHGNumber, String StockSite, String DestSite, String Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WMS_INTERSITETRANSFERS_UPDATE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@WHCHGNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@StockSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@DestSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);


                cmd.Parameters["@WHCHGNumber"].Value = WHCHGNumber;
                cmd.Parameters["@StockSite"].Value = StockSite;
                cmd.Parameters["@DestSite"].Value = DestSite;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_WMS_INTERSITETRANSFERS_ORDER_detail(DataGridView _dataGridView, String WHCHGNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WMS_INTERSITETRANSFERS_ORDER_detail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@WHCHGNumber", SqlDbType.VarChar);

                cmd.Parameters["@WHCHGNumber"].Value = WHCHGNumber;

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

        static public void sp_WMS_INTERSITETRANSFERS_ORDER_DELETE_DETAIL(String WHCHGNumber, int DetailKey)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WMS_INTERSITETRANSFERS_ORDER_DELETE_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@WHCHGNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DetailKey", SqlDbType.Int);

                cmd.Parameters["@WHCHGNumber"].Value = WHCHGNumber;
                cmd.Parameters["@DetailKey"].Value = DetailKey;

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

        static public void sp_WMS_INTERSITETRANSFERS_ORDER_UPDATE_DETAIL(String WHCHGNumber, int DetailKey, Decimal Qty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WMS_INTERSITETRANSFERS_ORDER_UPDATE_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@WHCHGNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DetailKey", SqlDbType.Int);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@WHCHGNumber"].Value = WHCHGNumber;
                cmd.Parameters["@DetailKey"].Value = DetailKey;
                cmd.Parameters["@Qty"].Value = Qty;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public IntersiteTransfersObject sp_WMS_INTERSITETRANSFERS_GET_HEADER(String WHCHGNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_WMS_INTERSITETRANSFERS_GET_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@WHCHGNumber", SqlDbType.VarChar);

                cmd.Parameters["@WHCHGNumber"].Value = WHCHGNumber;

                connection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                IntersiteTransfersObject intersiteTransfersObject = new IntersiteTransfersObject();

                if (sqlDataReader.Read())
                {
                    intersiteTransfersObject.StockSite = sqlDataReader["StockSite"].ToString().Trim();
                    intersiteTransfersObject.DestSite = sqlDataReader["DestSite"].ToString().Trim();
                    intersiteTransfersObject.Memo = sqlDataReader["Memo"].ToString().Trim();
                    intersiteTransfersObject.CreateTime = Convert.ToDateTime(sqlDataReader["CreateDate"].ToString().Trim());
                }
                return intersiteTransfersObject;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                IntersiteTransfersObject intersiteTransfersObject = new IntersiteTransfersObject();
                return intersiteTransfersObject;
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_WMS_RECEIPTRETURN_SELECT(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WMS_RECEIPTRETURN_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                //cmd.Parameters["@SupplierID"].Value = SupplierID;
                //cmd.Parameters["@ItemID"].Value = ItemID;

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

        static public void sp_WMS_INTERSITETRANSFERS_RECEIPT(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WMS_INTERSITETRANSFERS_RECEIPT";
                cmd.CommandType = CommandType.StoredProcedure;
                
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

        static public void sp_WMS_INTERSITETRANSFERS_RECEIPTD(DataGridView _dataGridView, String WHCHGNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WMS_INTERSITETRANSFERS_RECEIPTD";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@WHCHGNumber", SqlDbType.VarChar);

                cmd.Parameters["@WHCHGNumber"].Value = WHCHGNumber;

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

        static public string getRouteNumberByOrderID(string OrderID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT A.RouteNumber ";
                sql = sql + "FROM Order2 A ";
                sql = sql + "WHERE A.OrderID = '" + OrderID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string RouteNumber = reader[0].ToString();
                    return RouteNumber;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public LotProductInfo sp_lotProductInfo(String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_LotProductInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                LotProductInfo product = new LotProductInfo();

                while (reader.Read())
                {
                    product.ProductKey = reader["ProductKey"].ToString().Trim();
                    product.ProductID = reader["ProductID"].ToString().Trim();
                    product.ProductDesc = reader["ProductDesc"].ToString().Trim();
                    product.PackSize = reader["StrPackSize"].ToString().Trim();
                    product.Unit = reader["SUnitM"].ToString().Trim();
                    product.CdPackDepttypeCode = reader["CdPackDepttypeCode"].ToString().Trim();
                    product.UnitPrice = reader["UnitPr"].ToString().Trim();
                    product.BottomPrice = reader["BottomPr"].ToString().Trim();
                    product.IsInActive = reader["IsInActive"].ToString().Trim();
                    product.PickBarCode = reader["PickBarCode"].ToString().Trim();
                    product.UPCUnit = reader["UPCUnit"].ToString().Trim();
                    product.NJWH = reader["PHYQTYWH"].ToString().Trim();
                    product.NYWH = reader["PHYQTY"].ToString().Trim();
                    product.GLOALL = reader["GLOALL"].ToString().Trim();
                    product.DETAIL = reader["DETAILED"].ToString().Trim();
                    product.Onhand = reader["ONHAND"].ToString().Trim();
                    product.LOCID = reader["LOCID"].ToString().Trim();
                    product.BRAND = reader["Brand"].ToString().Trim();
                    product.SalesUnit = reader["SalesUnit"].ToString().Trim();
                }
                return product;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                LotProductInfo product = new LotProductInfo();
                return product;
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_PoprepareDate(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_POPREPARE_DATE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }
        static public void sp_PoprepareSaleRep(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_POPREPARE_SALEREP";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void cbo_CdPackDeptTypeCode(ComboBox cbo_category)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT CdPackDeptTypeCode ";
                sql = sql + "FROM Product ";
                sql = sql + "Group by CdPackDeptTypeCode ";
                sql = sql + "";

                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);

                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Category = reader["CdPackDeptTypeCode"].ToString().Trim();
                    cbo_category.Items.Add(Category);
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

        static public void sp_LotInformation(DataGridView _dataGridView, String ProductID, String Status, String STOFCY, String Category, String Location, String Transaction)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_LotInformation";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@STOFCY", SqlDbType.VarChar);
                cmd.Parameters.Add("@Category", SqlDbType.VarChar);
                cmd.Parameters.Add("@Location", SqlDbType.VarChar);
                cmd.Parameters.Add("@Transaction", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@STOFCY"].Value = STOFCY;
                cmd.Parameters["@Category"].Value = Category;
                cmd.Parameters["@Location"].Value = Location;
                cmd.Parameters["@Transaction"].Value = Transaction;

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

        static public void sp_ARCOLLECTION_DELETE_DETAIL(String ARCNumber, int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ARCOLLECTION_DELETE_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ARCNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@ARCNumber"].Value = ARCNumber;
                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_ARCOLLECTION_DETAIL(DataGridView _dataGridView, String ARCNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ARCOLLECTION_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ARCNumber", SqlDbType.VarChar);

                cmd.Parameters["@ARCNumber"].Value = ARCNumber;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_ARCOLLECTION_CREATE_HEADER(String ARCNumber, String SaleRep, String Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ARCOLLECTION_CREATE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ARCNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@SaleRep", SqlDbType.VarChar);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);

                cmd.Parameters["@ARCNumber"].Value = ARCNumber;
                cmd.Parameters["@SaleRep"].Value = SaleRep;
                cmd.Parameters["@User"].Value = GATE.userID;
                cmd.Parameters["@Memo"].Value = Memo;

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
        static public void sp_ARCOLLECTION_INSERT_DETAIL(String ARCNumber, String DeliveryNumber, DateTime DeliveryDate, String AccountID, String CashCheck, String CheckNumber
            , DateTime CheckDate, Decimal Amount, String Deleted, String Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ARCOLLECTION_INSERT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ARCNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DeliveryNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DeliveryDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@AccountID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CashCheck", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheckNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheckDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);
                cmd.Parameters.Add("@Deleted", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.NVarChar);

                cmd.Parameters["@ARCNumber"].Value = ARCNumber;
                cmd.Parameters["@DeliveryNumber"].Value = DeliveryNumber;
                cmd.Parameters["@DeliveryDate"].Value = DeliveryDate;
                cmd.Parameters["@AccountID"].Value = AccountID;
                cmd.Parameters["@CashCheck"].Value = CashCheck;
                cmd.Parameters["@CheckNumber"].Value = CheckNumber;
                cmd.Parameters["@CheckDate"].Value = CheckDate;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@User"].Value = GATE.userID;
                cmd.Parameters["@Deleted"].Value = Deleted;
                cmd.Parameters["@Memo"].Value = Memo;

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

        static public void sp_ARCOLLECTION_UPDATE_HEADER(String ARCNumber, String SaleRep, String Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ARCOLLECTION_UPDATE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ARCNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@SaleRep", SqlDbType.VarChar);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);

                cmd.Parameters["@ARCNumber"].Value = ARCNumber;
                cmd.Parameters["@SaleRep"].Value = SaleRep;
                cmd.Parameters["@User"].Value = GATE.userID;
                cmd.Parameters["@Memo"].Value = Memo;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_ARCOLLECTION_HEADER(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, String SaleRep)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ARCOLLECTION_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@SaleRep", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@SaleRep"].Value = SaleRep;

                connection.Open();

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

                connection.Close();
            }
        }

        static public String sp_ARCOLLECTION_GET_NewNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ARCOLLECTION_GET_NewNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string NewARCNumber = reader[0].ToString();
                    return NewARCNumber;
                }
                else
                {
                    return "";
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_ARCOLLECTION_DELETE_HEADER(String ARCNumber, int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ARCOLLECTION_DELETE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ARCNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@ARCNumber"].Value = ARCNumber;
                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public Location sp_GET_LATLNG(String Address, String City, String State, String Country, String PostalCode)
        {
            Location location = new Location();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_LATLNG";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Address", SqlDbType.VarChar);
                cmd.Parameters.Add("@City", SqlDbType.VarChar);
                cmd.Parameters.Add("@State", SqlDbType.VarChar);
                cmd.Parameters.Add("@Country", SqlDbType.VarChar);
                cmd.Parameters.Add("@PostalCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Latitude", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Longitude", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@Address"].Value = Address;
                cmd.Parameters["@City"].Value = City;
                cmd.Parameters["@State"].Value = State;
                cmd.Parameters["@Country"].Value = Country;
                cmd.Parameters["@PostalCode"].Value = PostalCode;

                connection.Open();

                cmd.ExecuteNonQuery();

                location.Latitude = cmd.Parameters["@Latitude"].Value.ToString();
                location.Longitude = cmd.Parameters["@Longitude"].Value.ToString();

                return location;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return location;
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_UPDATE_AddressInfoWithLocation(AddressObject addressObject, Location locationObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_UPDATE_AddressInfoWithLocation";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ROWID", SqlDbType.Int);
                cmd.Parameters.Add("@AddressCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Address1", SqlDbType.VarChar);
                cmd.Parameters.Add("@Address2", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressState", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressPostalCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressEmail", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressTel1", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressTel2", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressFax", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@Latitude", SqlDbType.VarChar);
                cmd.Parameters.Add("@Longitude", SqlDbType.VarChar);

                cmd.Parameters["@ROWID"].Value = Convert.ToInt32(addressObject.ROWID);
                cmd.Parameters["@AddressCode"].Value = addressObject.AddressCode;
                cmd.Parameters["@Address1"].Value = addressObject.Address1;
                cmd.Parameters["@Address2"].Value = addressObject.Address2;
                cmd.Parameters["@AddressCity"].Value = addressObject.AddressCity;
                cmd.Parameters["@AddressState"].Value = addressObject.AddressState;
                cmd.Parameters["@AddressPostalCode"].Value = addressObject.AddressPostalCode;
                cmd.Parameters["@AddressEmail"].Value = addressObject.AddressEmail;
                cmd.Parameters["@AddressTel1"].Value = addressObject.AddressTel1;
                cmd.Parameters["@AddressTel2"].Value = addressObject.AddressTel2;
                cmd.Parameters["@AddressFax"].Value = addressObject.AddressFax;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@Latitude"].Value = locationObject.Latitude;
                cmd.Parameters["@Longitude"].Value = locationObject.Longitude;

                connection.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public string sp_INSERT_NewSupplierAddressWithLocation(AddressObject addressObject, Location location, String ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_INSERT_NewSupplierAddressWithLocation";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Address1", SqlDbType.VarChar);
                cmd.Parameters.Add("@Address2", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressState", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressPostalCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressEmail", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressTel1", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressTel2", SqlDbType.VarChar);
                cmd.Parameters.Add("@AddressFax", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@Latitude", SqlDbType.VarChar);
                cmd.Parameters.Add("@Longitude", SqlDbType.VarChar);
                cmd.Parameters.Add("@Result", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@ID"].Value = ID;
                cmd.Parameters["@AddressCode"].Value = addressObject.AddressCode;
                cmd.Parameters["@Address1"].Value = addressObject.Address1;
                cmd.Parameters["@Address2"].Value = addressObject.Address2;
                cmd.Parameters["@AddressCity"].Value = addressObject.AddressCity;
                cmd.Parameters["@AddressState"].Value = addressObject.AddressState;
                cmd.Parameters["@AddressPostalCode"].Value = addressObject.AddressPostalCode;
                cmd.Parameters["@AddressEmail"].Value = addressObject.AddressEmail;
                cmd.Parameters["@AddressTel1"].Value = addressObject.AddressTel1;
                cmd.Parameters["@AddressTel2"].Value = addressObject.AddressTel2;
                cmd.Parameters["@AddressFax"].Value = addressObject.AddressFax;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@Latitude"].Value = location.Latitude;
                cmd.Parameters["@Longitude"].Value = location.Longitude;

                connection.Open();
                cmd.ExecuteNonQuery();
                string Result = cmd.Parameters["@Result"].Value.ToString();
                return Result;

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        static public void SalesRepList(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_SalesRepList";
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();

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
                connection.Close();
            }
        }

        static public String sp_CustomerMapMarkByID(String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_CustomerMapMarkByID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output;

                cmd.Parameters["@CustomerID"].Value = CustomerID;


                connection.Open();
                cmd.ExecuteNonQuery();

                string Address = cmd.Parameters["@Address"].Value.ToString();

                return Address;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "NO";
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_CustomerMapListByCustomerID(DataGridView _dataGridView, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_CustomerMapListByCustomerID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_ARCollectionDailyReport(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ARCollectionDailyReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_ARCollectionMonthlyReport(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ARCollectionMonthlyReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_ARMonthlySalesDebitMemo(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ARMonthlySalesDebitMemo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;

                connection.Open();

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
                connection.Close();
            }
        }
        static public void sp_ARDailySalesDebitMemo(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ARDailySalesDebitMemo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_NSFReport(DataGridView _dataGridView, String CompanyName, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_NSFReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@CompanyName"].Value = CompanyName;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_AROverPayment(DataGridView _dataGridView, String CustomerID, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_OverPayment";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_SalesbyCustomerReport(DataGridView _dataGridView, String CustomerID, String CustomerName, DateTime FromDate, DateTime ToDate, String StateString, String CityString)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_SalesbyCustomerReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerName", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@StateString", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CityString", SqlDbType.NVarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@CustomerName"].Value = CustomerName;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@StateString"].Value = StateString;
                cmd.Parameters["@CityString"].Value = CityString;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_Commission_BETA(DataGridView _dataGridView, String REP, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Commission_BETA";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@REP", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@REP"].Value = REP;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void cbo_getCdPackDeptTypeCode(ComboBox cbo_Cateogry)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT CdPackDeptTypeCode ";
                sql = sql + "FROM Product WITH(NOLOCK) ";
                sql = sql + "WHERE CdPackDeptTypeCode != 'ZN' ";
                sql = sql + "GROUP BY CdPackDeptTypeCode ";
                sql = sql + "ORDER BY CdPackDeptTypeCode ";
                sql = sql + "";

                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_Cateogry.Items.Add(reader[0].ToString().Trim());
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

        static public void sp_CustomerMapListByCategory(DataGridView _dataGridView, String Category, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_CustomerMapListByCategory";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Category", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@Category"].Value = Category;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PromotionSchedule(DataGridView _dataGridView, String PRMNumber)
        //(DataGridView _dataGridView, String BrandCode, String ProductID, String PromotionType, String PromotionBase, String Type, DateTime StartDate, DateTime EndDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PromotionSchedule";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PRMNumber", SqlDbType.VarChar);

                cmd.Parameters["@PRMNumber"].Value = PRMNumber;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PromotionSchedule_EXPIRED(DataGridView _dataGridView, String BrandCode, String ProductID, String PromotionType, String PromotionBase, String Type, DateTime StartDate, DateTime EndDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PromotionSchedule_EXPIRED";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionType", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionBase", SqlDbType.VarChar);
                cmd.Parameters.Add("@Type", SqlDbType.VarChar);
                cmd.Parameters.Add("@StartDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@EndDate", SqlDbType.DateTime);

                cmd.Parameters["@BrandCode"].Value = BrandCode;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@PromotionType"].Value = PromotionType;
                cmd.Parameters["@PromotionBase"].Value = PromotionBase;
                cmd.Parameters["@Type"].Value = Type;
                cmd.Parameters["@StartDate"].Value = StartDate;
                cmd.Parameters["@EndDate"].Value = EndDate;

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

        static public void sp_GET_PromotionTypeCode(ComboBox cbo_promotionType)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_PromotionType";
                cmd.CommandType = CommandType.StoredProcedure;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string PromotionTypeCode = reader["PromotionTypeCode"].ToString().Trim();
                    cbo_promotionType.Items.Add(PromotionTypeCode);
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

        static public string sp_GET_PromotionTypeNamebyCode(String PromotionTypeCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_GET_PromotionTypeNamebyCode";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@PromotionTypeCode", SqlDbType.VarChar);

                cmd.Parameters["@PromotionTypeCode"].Value = PromotionTypeCode;

                connection3.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                
                if (sqlDataReader.Read())
                {
                    String PromotionTypeName = sqlDataReader["PromotionTypeName"].ToString().Trim();
                    return PromotionTypeName;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection3.Close();
            }
        }


        static public void sp_PromotionSchedule_INSERT(PromotionScheduleObject promotionScheduleObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PromotionSchedule_INSERT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionTypeCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionBase", SqlDbType.VarChar);
                cmd.Parameters.Add("@StartDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@EndDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@PromotionMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@BasePrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@Type", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionValue1", SqlDbType.Decimal);
                cmd.Parameters.Add("@PromotionMethod1", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionValue2", SqlDbType.Decimal);
                cmd.Parameters.Add("@PromotionMethod2", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionBuy", SqlDbType.Decimal);
                cmd.Parameters.Add("@PromotionFree", SqlDbType.Decimal);
                cmd.Parameters.Add("@NetPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@Checked", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                
                cmd.Parameters["@BrandCode"].Value = promotionScheduleObject.BrandCode;
                cmd.Parameters["@PromotionTypeCode"].Value = promotionScheduleObject.PromotionTypeCode;
                cmd.Parameters["@PromotionBase"].Value = promotionScheduleObject.PromotionBase;
                cmd.Parameters["@StartDate"].Value = promotionScheduleObject.StartDate;
                cmd.Parameters["@EndDate"].Value = promotionScheduleObject.EndDate;
                cmd.Parameters["@PromotionMemo"].Value = promotionScheduleObject.PromotionMemo;
                cmd.Parameters["@ProductID"].Value = promotionScheduleObject.ProductID;
                cmd.Parameters["@BasePrice"].Value = promotionScheduleObject.BasePrice;
                cmd.Parameters["@Type"].Value = promotionScheduleObject.Type;
                cmd.Parameters["@PromotionValue1"].Value = promotionScheduleObject.PromotionValue1;
                cmd.Parameters["@PromotionMethod1"].Value = promotionScheduleObject.PromotionMethod1;
                cmd.Parameters["@PromotionValue2"].Value = promotionScheduleObject.PromotionValue2;
                cmd.Parameters["@PromotionMethod2"].Value = promotionScheduleObject.PromotionMethod2;
                cmd.Parameters["@PromotionBuy"].Value = promotionScheduleObject.PromotionBuy;
                cmd.Parameters["@PromotionFree"].Value = promotionScheduleObject.PromotionFree;
                cmd.Parameters["@NetPrice"].Value = promotionScheduleObject.NetPrice;
                cmd.Parameters["@Checked"].Value = promotionScheduleObject.Checked;
                cmd.Parameters["@Status"].Value = promotionScheduleObject.Status;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                
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

        static public PromotionScheduleObject sp_PromotionSchedule_SELECT(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PromotionSchedule_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);

                cmd.Parameters["@id"].Value = id;

                connection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                PromotionScheduleObject promotionScheduleObject = new PromotionScheduleObject();

                if (sqlDataReader.Read())
                {
                    promotionScheduleObject.BrandCode = sqlDataReader["BrandCode"].ToString().Trim();
                    promotionScheduleObject.ProductID = sqlDataReader["ProductID"].ToString().Trim();
                    promotionScheduleObject.PromotionTypeCode = sqlDataReader["PromotionTypeCode"].ToString().Trim();
                    promotionScheduleObject.PromotionBase = sqlDataReader["PromotionBase"].ToString().Trim();
                    promotionScheduleObject.StartDate = Convert.ToDateTime(sqlDataReader["StartDate"].ToString().Trim() ?? "1900/01/01");
                    promotionScheduleObject.EndDate = Convert.ToDateTime(sqlDataReader["EndDate"].ToString().Trim() ?? "1900/01/01");
                    //promotionScheduleObject.AlertFromDate = Convert.ToDateTime(sqlDataReader["AlertFromDate"].ToString().Trim() ?? "1900/01/01");
                    //promotionScheduleObject.AlertToDate = Convert.ToDateTime(sqlDataReader["AlertToDate"].ToString().Trim() ?? "1900/01/01");
                    promotionScheduleObject.BasePrice = Convert.ToDecimal(sqlDataReader["BasePrice"].ToString().Trim() ?? "0");
                    promotionScheduleObject.Type = sqlDataReader["Type"].ToString().Trim();
                    promotionScheduleObject.PromotionValue1 = Convert.ToDecimal(sqlDataReader["PromotionValue1"].ToString().Trim() ?? "0");
                    promotionScheduleObject.PromotionMethod1 = sqlDataReader["PromotionMethod1"].ToString().Trim();
                    promotionScheduleObject.PromotionValue2 = Convert.ToDecimal(sqlDataReader["PromotionValue2"].ToString().Trim() ?? "0");
                    promotionScheduleObject.PromotionMethod2 = sqlDataReader["PromotionMethod2"].ToString().Trim();
                    promotionScheduleObject.PromotionBuy = Convert.ToDecimal(sqlDataReader["PromotionBuy"].ToString().Trim() ?? "0");
                    promotionScheduleObject.PromotionFree = Convert.ToDecimal(sqlDataReader["PromotionFree"].ToString().Trim() ?? "0");
                    promotionScheduleObject.NetPrice = Convert.ToDecimal(sqlDataReader["NetPrice"].ToString().Trim());
                    promotionScheduleObject.PromotionMemo = sqlDataReader["PromotionMemo"].ToString().Trim();
                    promotionScheduleObject.Checked = sqlDataReader["Checked"].ToString().Trim();
                    promotionScheduleObject.Status = sqlDataReader["Status"].ToString().Trim();
                    promotionScheduleObject.CreateUser = sqlDataReader["CreateUser"].ToString().Trim() ?? "";
                    promotionScheduleObject.CreateTime = Convert.ToDateTime(sqlDataReader["CreateTime"].ToString().Trim() ?? "1900/01/01");
                    promotionScheduleObject.UpdateUser = sqlDataReader["UpdateUser"].ToString().Trim();
                    promotionScheduleObject.UpdateTime = Convert.ToDateTime(sqlDataReader["UpdateTime"].ToString().Trim() ?? "1900/01/01");
                }
                return promotionScheduleObject;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                PromotionScheduleObject promotionScheduleObject = new PromotionScheduleObject();
                return promotionScheduleObject;
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_PromotionSchedule_UPDATE(int id, PromotionScheduleObject promotionScheduleObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PromotionSchedule_UPDATE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionTypeCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionBase", SqlDbType.VarChar);
                cmd.Parameters.Add("@StartDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@EndDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@PromotionMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@BasePrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@Type", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionValue1", SqlDbType.Decimal);
                cmd.Parameters.Add("@PromotionMethod1", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionValue2", SqlDbType.Decimal);
                cmd.Parameters.Add("@PromotionMethod2", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionBuy", SqlDbType.Decimal);
                cmd.Parameters.Add("@PromotionFree", SqlDbType.Decimal);
                cmd.Parameters.Add("@NetPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@Checked", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                
                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@BrandCode"].Value = promotionScheduleObject.BrandCode;
                cmd.Parameters["@PromotionTypeCode"].Value = promotionScheduleObject.PromotionTypeCode;
                cmd.Parameters["@PromotionBase"].Value = promotionScheduleObject.PromotionBase;
                cmd.Parameters["@StartDate"].Value = promotionScheduleObject.StartDate;
                cmd.Parameters["@EndDate"].Value = promotionScheduleObject.EndDate;
                cmd.Parameters["@PromotionMemo"].Value = promotionScheduleObject.PromotionMemo;
                cmd.Parameters["@ProductID"].Value = promotionScheduleObject.ProductID;
                cmd.Parameters["@BasePrice"].Value = promotionScheduleObject.BasePrice;
                cmd.Parameters["@Type"].Value = promotionScheduleObject.Type;
                cmd.Parameters["@PromotionValue1"].Value = promotionScheduleObject.PromotionValue1;
                cmd.Parameters["@PromotionMethod1"].Value = promotionScheduleObject.PromotionMethod1;
                cmd.Parameters["@PromotionValue2"].Value = promotionScheduleObject.PromotionValue2;
                cmd.Parameters["@PromotionMethod2"].Value = promotionScheduleObject.PromotionMethod2;
                cmd.Parameters["@PromotionBuy"].Value = promotionScheduleObject.PromotionBuy;
                cmd.Parameters["@PromotionFree"].Value = promotionScheduleObject.PromotionFree;
                cmd.Parameters["@NetPrice"].Value = promotionScheduleObject.NetPrice;
                cmd.Parameters["@Checked"].Value = promotionScheduleObject.Checked;
                cmd.Parameters["@Status"].Value = promotionScheduleObject.Status;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                
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

        static public void sp_PromotionSchedule_DELETE(String PRMNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PromotionSchedule_DELETE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PRMNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@PRMNumber"].Value = PRMNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_PromotionType(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PromotionType";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                //cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();

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
                connection.Close();
            }
        }

        static public string sp_PromotionType_INSERT(String PromotionTypeCode, String PromotionTypeName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PromotionType_INSERT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PromotionTypeCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionTypeName", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReturnMessage", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                
                cmd.Parameters["@PromotionTypeCode"].Value = PromotionTypeCode;
                cmd.Parameters["@PromotionTypeName"].Value = PromotionTypeName;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();

                string ReturnMessage = cmd.Parameters["@ReturnMessage"].Value.ToString();
                return ReturnMessage;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "SqlException exception";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_RoutePlanHeader(DataGridView _dataGridView, String RouteCode, String RouteDay, String RouteArea)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_RoutePlanHeader";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@RouteDay", SqlDbType.VarChar);
                cmd.Parameters.Add("@RouteArea", SqlDbType.VarChar);

                cmd.Parameters["@RouteCode"].Value = RouteCode;
                cmd.Parameters["@RouteDay"].Value = RouteDay;
                cmd.Parameters["@RouteArea"].Value = RouteArea;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void cbo_RouteCode(ComboBox cbo_RouteCode)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT RouteCode,RouteArea ";
                sql = sql + "FROM RoutePlan ";
                sql = sql + "GROUP BY RouteCode,RouteArea ";
                sql = sql + "ORDER BY RouteCode,RouteArea ";
                //sql = sql + "ORDER BY driver ";
                sql = sql + "";

                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);

                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                cbo_RouteCode.Items.Add("");
                while (reader.Read())
                {
                    string RouteCode = reader["RouteCode"].ToString().Trim();
                    string RouteArea = reader["RouteArea"].ToString().Trim();
                    cbo_RouteCode.Items.Add(RouteCode + " ( " + RouteArea + " )");
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

        static public void cbo_RouteCity(ComboBox cbo_RouteCity)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT UPPER(CTY_0) AS CTY_0 ";
                sql = sql + "FROM BPADDRESS ";
                sql = sql + "GROUP BY UPPER(CTY_0) ";
                sql = sql + "ORDER BY UPPER(CTY_0) ";
                sql = sql + "";

                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);

                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string RouteCity = reader["CTY_0"].ToString().Trim();
                    cbo_RouteCity.Items.Add(RouteCity);
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

        static public void sp_RoutePlanDetail(DataGridView _dataGridView, String RouteCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_RoutePlanDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RouteCode", SqlDbType.VarChar);

                cmd.Parameters["@RouteCode"].Value = RouteCode;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public String sp_CRUD_RoutePlan(String ACTION, int id, String RouteCode, String RouteDay, String RouteArea, String RouteMemo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_CRUD_RoutePlan";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ACTION", SqlDbType.VarChar);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@RouteCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@RouteDay", SqlDbType.VarChar);
                cmd.Parameters.Add("@RouteArea", SqlDbType.VarChar);
                cmd.Parameters.Add("@RouteMemo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReturnMessage", SqlDbType.VarChar,100).Direction = ParameterDirection.Output;
                
                cmd.Parameters["@ACTION"].Value = ACTION;
                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@RouteCode"].Value = RouteCode;
                cmd.Parameters["@RouteDay"].Value = RouteDay;
                cmd.Parameters["@RouteArea"].Value = RouteArea;
                cmd.Parameters["@RouteMemo"].Value = RouteMemo;
                cmd.Parameters["@User"].Value = GATE.userID;
                
                connection.Open();
                cmd.ExecuteNonQuery();

                string ReturnMessage = cmd.Parameters["@ReturnMessage"].Value.ToString();
                return ReturnMessage;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "SqlException exception";
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_CRUD_RoutePlanDetail(String ACTION, int id, String RouteCode, String RouteStop, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_CRUD_RoutePlanDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ACTION", SqlDbType.VarChar);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@RouteCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@RouteStop", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@ACTION"].Value = ACTION;
                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@RouteCode"].Value = RouteCode;
                cmd.Parameters["@RouteStop"].Value = RouteStop;
                cmd.Parameters["@CustomerID"].Value = CustomerID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public decimal sp_GET_Route_TotalAmountByDate(String Type, DateTime RouteDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "sp_GET_Route_TotalAmountByDate";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Type", SqlDbType.VarChar);
                cmd.Parameters.Add("@RouteDate", SqlDbType.DateTime);

                cmd.Parameters["@Type"].Value = Type;
                cmd.Parameters["@RouteDate"].Value = RouteDate;
                cmd.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Direction = ParameterDirection.Output;
                cmd.Parameters["@TotalAmount"].Scale = 2;

                connection3.Open();
                cmd.ExecuteNonQuery();

                decimal TotalAmount = 0;
                TotalAmount = Convert.ToDecimal(cmd.Parameters["@TotalAmount"].Value.ToString());
                return TotalAmount;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection3.Close();
            }
        }

        static public void sp_PO_COST_CALCULATION(DataGridView _dataGridView, String PONumber)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PO_COST_CALCULATION";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);
                cmd.Parameters["@PONumber"].Value = PONumber;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void cbo_ITEMBYSUPPLIER(ComboBox cbo_product, String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PO_ITEMBYSUPPLIER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters["@SupplierID"].Value = SupplierID;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Product = reader["ProductID"].ToString().Trim();
                    cbo_product.Items.Add(Product);
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

        static public void getItemInfoFromItemID(string ItemID, TextBox txt_ProductDesc, TextBox txt_PackSize, TextBox txt_Unit, TextBox txt_Conversion)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT ProductDesc, strPackSize, PurchaseUnit, StockConversionQty ";
                sql = sql + "FROM Product WITH(NOLOCK) ";
                sql = sql + "WHERE ProductID = '" + ItemID + "' AND IsInActive = 0 ";
                sql = sql + "";

                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txt_ProductDesc.Text = reader[0].ToString();
                    txt_PackSize.Text = reader[1].ToString();
                    txt_Unit.Text = reader[2].ToString();
                    txt_Conversion.Text = reader[3].ToString();
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

        static public void sp_Miscellaneous_Issue_Select(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Miscellaneous_Issue_Select";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void cbo_STKReasonCode(String CategoryCode, ComboBox cbo_ReasonCode)
        {
            // MI MISCELLANEOUS ISSUE, MR	MISCELLANEOUS RECEIPT, SC	STOCK STATUS CHANGE
            try
            {
                string sql = "";
                sql = sql + "SELECT TypeCode ";
                sql = sql + "FROM STKReasonCode ";
                sql = sql + "WHERE CategoryCode ='" + CategoryCode + "' and Status = 'Active' ";
                sql = sql + "Order by TypeCode";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_ReasonCode.Items.Add(reader[0].ToString().Trim());
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

        static public void sp_Miscellaneous_Issue_Select_Detail(DataGridView _dataGridView, String MisNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Miscellaneous_Issue_Select_Detail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MisNumber", SqlDbType.VarChar);

                cmd.Parameters["@MisNumber"].Value = MisNumber;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_Miscellaneous_Stock_Select(DataGridView _dataGridView, String ItemID, String Company, String StorageSite)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Miscellaneous_Stock_Select";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Company", SqlDbType.VarChar);
                cmd.Parameters.Add("@StorageSite", SqlDbType.VarChar);

                cmd.Parameters["@ItemID"].Value = ItemID;
                cmd.Parameters["@Company"].Value = Company;
                cmd.Parameters["@StorageSite"].Value = StorageSite;

                connection.Open();

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
                connection.Close();
            }
        }

        static public String sp_Miscellaneous_Issue_Available_Check(String Site, String ItemID, Decimal IssueQty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Miscellaneous_Issue_Available_Check";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);
                cmd.Parameters.Add("@IssueQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Result", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@ItemID"].Value = ItemID;
                cmd.Parameters["@IssueQty"].Value = IssueQty;

                connection.Open();

                cmd.ExecuteNonQuery();

                string Result = cmd.Parameters["@Result"].Value.ToString();

                return Result;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_GET_NewMISNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_NewMISNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewMISNumber", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewMISNumber = cmd.Parameters["@NewMISNumber"].Value.ToString();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());

                    return NewMISNumber;
                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());

                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_Miscellaneous_Issue_Save_Gaccentry(String Company, String Site, String ProductID, String NewSTKNumber, String NewMISNumber, Decimal IssueQty, String MisMemo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Miscellaneous_Issue_Save_Gaccentry";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Company", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewMISNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@IssueQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@MisMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@Company"].Value = "BIC";
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;
                cmd.Parameters["@NewMISNumber"].Value = NewMISNumber;
                cmd.Parameters["@IssueQty"].Value = IssueQty;
                cmd.Parameters["@MisMemo"].Value = MisMemo;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
                return "Success";

            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_Miscellaneous_Issue_Save_Gaccentry \nDetail : " + exception.Message.ToString();

                return ErrorText;
            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_Miscellaneous_Issue_Save_Stock(String LotNumber, String Company, String Site, String ProductID,
            String NewSTKNumber, String NewMISNumber, Decimal IssueQty, String Status, String MisMemoCode, String MisMemo, int Line)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Miscellaneous_Issue_Save_Stock";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@LotNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Company", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewMISNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@IssueQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@MISMemoCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@MisMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@Line", SqlDbType.Int);

                cmd.Parameters["@LotNumber"].Value = LotNumber;
                cmd.Parameters["@Company"].Value = "BIC";
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;
                cmd.Parameters["@NewMISNumber"].Value = NewMISNumber;
                cmd.Parameters["@IssueQty"].Value = IssueQty;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@MISMemoCode"].Value = MisMemoCode;
                cmd.Parameters["@MisMemo"].Value = MisMemo;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@Line"].Value = Line;

                connection.Open();
                cmd.ExecuteNonQuery();

                return "Success";

            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_Miscellaneous_Issue_Save_Stock \nDetail : " + exception.Message.ToString();

                return ErrorText;
            }
            finally
            {
                connection.Close();
            }
        }

        static public void GETSTKReasonText(String CategoryCode, String TypeCode, TextBox txt_TypeName)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT TypeName ";
                sql = sql + "FROM STKReasonCode ";
                sql = sql + "WHERE TypeCode = '" + TypeCode + "' AND CategoryCode = '" + CategoryCode + "'";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txt_TypeName.Text = (reader[0].ToString());
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

        static public void sp_Miscellaneous_Receipt_Select(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Miscellaneous_Receipt_Select";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_Miscellaneous_Receipt_Select_Detail(DataGridView _dataGridView, String MrcNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Miscellaneous_Receipt_Select_Detail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MrcNumber", SqlDbType.VarChar);

                cmd.Parameters["@MrcNumber"].Value = MrcNumber;

                connection.Open();

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
                connection.Close();
            }
        }

        static public String sp_GET_NewMRCNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_NewMRCNumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewMRCNumber", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewMRCNumber = cmd.Parameters["@NewMRCNumber"].Value.ToString();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());

                    return NewMRCNumber;

                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());

                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_GET_NewLOTNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_NewLOTNumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewLOTNumber", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewLOTNumber = cmd.Parameters["@NewLOTNumber"].Value.ToString();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());

                    return NewLOTNumber;

                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());

                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_Miscellaneous_Receipt_Save(String Company, String Site, String ProductID, String NewLOTNumber,
            String NewMRCNumber, String NewSTKNumber, Decimal ReceiptQty, String Status, String MRCMemoCode, String MRCMemo, DateTime ExpireDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Miscellaneous_Receipt_Save";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Company", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewLOTNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewMRCNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceiptQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@MRCMemoCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@MRCMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@ExpireDate", SqlDbType.DateTime);

                cmd.Parameters["@Company"].Value = "BIC";
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@NewLOTNumber"].Value = NewLOTNumber;
                cmd.Parameters["@NewMRCNumber"].Value = NewMRCNumber;
                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;
                cmd.Parameters["@ReceiptQty"].Value = ReceiptQty;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@MRCMemoCode"].Value = MRCMemoCode;
                cmd.Parameters["@MRCMemo"].Value = MRCMemo;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@ExpireDate"].Value = ExpireDate;

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Something went wrong while processing your request.\nPlease contact your IT Team.\n\nError : sp_Miscellaneous_Receipt_Save\nDetail : " + exception.Message.ToString() + "", "※COTACT IT TEAM※", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_StockDetailByProductID(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, String Site, String Status,
            String Category, String ProductID, String Brand)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_StockDetailByProductID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@Category", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Brand", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@Category"].Value = Category;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Brand"].Value = Brand;
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

        static public String sp_Miscellaneous_UserCheck()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Miscellaneous_UserCheck";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@User", SqlDbType.VarChar);

                cmd.Parameters["@User"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string UserCheck = reader[0].ToString();
                    return UserCheck;
                }
                else
                {
                    return "";
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_NS_PINVOICE(string InvoiceNumber, Decimal CreditTotal, Decimal DebitTotal)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_NS_PINVOICE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditTotal", SqlDbType.Decimal);
                cmd.Parameters.Add("@DebitTotal", SqlDbType.Decimal);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);

                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@CreditTotal"].Value = CreditTotal;
                cmd.Parameters["@DebitTotal"].Value = DebitTotal;
                cmd.Parameters["@User"].Value = GATE.userID;

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

        static public void sp_NS_INSERT_AP_Credit(string NSNumber, string InvoiceNumber, string CreditType, string CreditNumber, Decimal CreditAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_NS_INSERT_AP_Credit";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NSNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditType", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);

                cmd.Parameters["@NSNumber"].Value = NSNumber;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@CreditType"].Value = CreditType;
                cmd.Parameters["@CreditNumber"].Value = CreditNumber;
                cmd.Parameters["@CreditAmount"].Value = CreditAmount;
                cmd.Parameters["@User"].Value = GATE.userID;

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

        static public void sp_NS_INSERT_AP_Debit(string NSNumber, string InvoiceNumber, string DebitType, string DebitNumber, Decimal DebitAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_NS_INSERT_AP_Debit";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NSNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DebitType", SqlDbType.VarChar);
                cmd.Parameters.Add("@DebitNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DebitAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);

                cmd.Parameters["@NSNumber"].Value = NSNumber;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@DebitType"].Value = DebitType;
                cmd.Parameters["@DebitNumber"].Value = DebitNumber;
                cmd.Parameters["@DebitAmount"].Value = DebitAmount;
                cmd.Parameters["@User"].Value = GATE.userID;

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

        static public void sp_LotMemoUpdate(String LOTNumber, String Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_LotMemoUpdate";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@LOTNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);


                cmd.Parameters["@LOTNumber"].Value = LOTNumber;
                cmd.Parameters["@Memo"].Value = Memo;


                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public bool sp_CHECK_ShipmentReturn(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_ShipmentReturn";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
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
                connection2.Close();
            }
        }

        static public void sp_GET_SalesRepTeam(ComboBox cbo_Team)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_SalesRepTeam";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                //cmd.Parameters["@SupplierID"].Value = SupplierID;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Team = reader["TNUM_0"].ToString().Trim();
                    cbo_Team.Items.Add(Team);
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

        static public String sp_UserCheck(String Type)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_UserCheck";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Type", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@Type"].Value = Type;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string UserCheck = reader[0].ToString();
                    return UserCheck;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_UPDATE_SalesRepInfo(String Status, String REPNUM_0, String REPFNAM_0, String REPMNAM_0, String REPLNAM_0, String FCY_0, String REPTEAM_0
       , String REPADDLIG_0, String REPADDLIG_1, int IsInactive, String CTY_0, String SAT_0, String POSCOD_0, String TEL_0, String REPIPAD_0
       , Decimal REPGOAL_D, Decimal REPGOAL_W, Decimal REPGOAL_M, Decimal REPGOAL_Y, DateTime StartDate, DateTime BirthDay, String REPTYP_0, String REPIPADSN_0
           , String REPIPADUD_0, Decimal WeeklySalary, String Password)
        {
            try
            {
                String CommandText = "";

                if (Status.Equals("New"))
                {
                    CommandText = "dbo.sp_INSERT_NEWSalesRep";

                }
                else if (Status.Equals("Update"))
                {
                    CommandText = "dbo.sp_UPDATE_SalesRepInfo";
                }
                else
                {
                    MessageBox.Show("Error");
                    return;
                }

                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = CommandText;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@REPNUM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@REPFNAM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@REPMNAM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@REPLNAM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@FCY_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@REPTEAM_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@REPADDLIG_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@REPADDLIG_1", SqlDbType.VarChar);
                cmd.Parameters.Add("@IsInactive", SqlDbType.Int);
                cmd.Parameters.Add("@CTY_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@SAT_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@POSCOD_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@TEL_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@REPIPAD_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@REPGOAL_D", SqlDbType.Decimal);
                cmd.Parameters.Add("@REPGOAL_W", SqlDbType.Decimal);
                cmd.Parameters.Add("@REPGOAL_M", SqlDbType.Decimal);
                cmd.Parameters.Add("@REPGOAL_Y", SqlDbType.Decimal);
                cmd.Parameters.Add("@UPDUSR_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@StartDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@BirthDay", SqlDbType.DateTime);
                cmd.Parameters.Add("@REPTYP_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@REPIPADSN_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@REPIPADUD_0", SqlDbType.VarChar);
                cmd.Parameters.Add("@WeeklySalary", SqlDbType.Decimal);
                cmd.Parameters.Add("@Password", SqlDbType.VarChar);

                cmd.Parameters["@REPNUM_0"].Value = REPNUM_0;
                cmd.Parameters["@REPFNAM_0"].Value = REPFNAM_0;
                cmd.Parameters["@REPMNAM_0"].Value = REPMNAM_0;
                cmd.Parameters["@REPLNAM_0"].Value = REPLNAM_0;
                cmd.Parameters["@FCY_0"].Value = FCY_0;
                cmd.Parameters["@REPTEAM_0"].Value = REPTEAM_0;
                cmd.Parameters["@REPADDLIG_0"].Value = REPADDLIG_0;
                cmd.Parameters["@REPADDLIG_1"].Value = REPADDLIG_1;
                cmd.Parameters["@IsInactive"].Value = IsInactive;
                cmd.Parameters["@CTY_0"].Value = CTY_0;
                cmd.Parameters["@SAT_0"].Value = SAT_0;
                cmd.Parameters["@POSCOD_0"].Value = POSCOD_0;
                cmd.Parameters["@TEL_0"].Value = TEL_0;
                cmd.Parameters["@REPIPAD_0"].Value = REPIPAD_0;
                cmd.Parameters["@REPGOAL_D"].Value = REPGOAL_D;
                cmd.Parameters["@REPGOAL_W"].Value = REPGOAL_W;
                cmd.Parameters["@REPGOAL_M"].Value = REPGOAL_M;
                cmd.Parameters["@REPGOAL_Y"].Value = REPGOAL_Y;
                cmd.Parameters["@UPDUSR_0"].Value = GATE.userID;
                cmd.Parameters["@StartDate"].Value = StartDate;
                cmd.Parameters["@BirthDay"].Value = BirthDay;
                cmd.Parameters["@REPTYP_0"].Value = REPTYP_0;
                cmd.Parameters["@REPIPADSN_0"].Value = REPIPADSN_0;
                cmd.Parameters["@REPIPADUD_0"].Value = REPIPADUD_0;
                cmd.Parameters["@WeeklySalary"].Value = WeeklySalary;
                cmd.Parameters["@Password"].Value = Password;

                connection.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public bool sp_CHECK_NewRepCode(String RepCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_NewRepCode";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RepCode", SqlDbType.VarChar);

                cmd.Parameters["@RepCode"].Value = RepCode;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
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
                connection2.Close();
            }
        }

        static public void sp_SalesARbyRepReport(DataGridView _dataGridView, String SALESREP)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_SalesARbyRepReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SALESREP", SqlDbType.VarChar);

                cmd.Parameters["@SALESREP"].Value = SALESREP;

                connection.Open();

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
                connection.Close();
            }
        }

        static public String sp_GET_NewPAYNumber(String PaymentType)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewPAYNumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);

                cmd.Parameters["@PaymentType"].Value = PaymentType;
                cmd.Parameters["@User"].Value = GATE.userID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string NewPAYNumber = reader[0].ToString();
                    return NewPAYNumber;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_NewBMWNumber_AP()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewBMWNumber_AP";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@User", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewBMWNumber", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@User"].Value = GATE.userID;

                connection2.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewBMWNumber = cmd.Parameters["@NewBMWNumber"].Value.ToString();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());
                    return NewBMWNumber;

                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());
                    return return1.ToString();
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public Decimal sp_PPAYMENT_CheckNetSettledAmount(String InvoiceNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PPAYMENT_CheckNetSettledAmount";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@NetAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                //cmd.Parameters.Add("@NetSettledAmount", SqlDbType.Decimal, 2).Direction = ParameterDirection.Output;

                SqlParameter netSettledAmount = new SqlParameter("@NetSettledAmount", SqlDbType.Decimal);
                netSettledAmount.Precision = 18;
                netSettledAmount.Scale = 2;
                netSettledAmount.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(netSettledAmount);

                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                //cmd.Parameters["@NetAmount"].Value = NetAmount;

                connection2.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                Decimal NetSettledAmount = Convert.ToDecimal(cmd.Parameters["@NetSettledAmount"].Value.ToString().Trim());

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());
                    return NetSettledAmount;

                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());
                    return 0;//return1.ToString();
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection2.Close();
            }
        }

        public class CheckCreditDebitMemo
        {
            public Decimal NetSettledAmount { get; set; }
            public String Deleted { get; set; }
        }

        static public CheckCreditDebitMemo sp_PPAYMENT_CheckCreditDebitMemo(String RefNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PPAYMENT_CheckCreditDebitMemo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RefNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;

                SqlParameter netSettledAmount = new SqlParameter("@NetSettledAmount", SqlDbType.Decimal);
                netSettledAmount.Precision = 18;
                netSettledAmount.Scale = 2;
                netSettledAmount.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(netSettledAmount);
                cmd.Parameters.Add("@Deleted", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                cmd.Parameters["@RefNumber"].Value = RefNumber;

                connection2.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;

                CheckCreditDebitMemo checkCreditDebitMemo = new CheckCreditDebitMemo();
                checkCreditDebitMemo.NetSettledAmount = Convert.ToDecimal(cmd.Parameters["@NetSettledAmount"].Value.ToString().Trim());
                checkCreditDebitMemo.Deleted = cmd.Parameters["@Deleted"].Value.ToString().Trim();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());
                    return checkCreditDebitMemo;

                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());
                    return checkCreditDebitMemo;//return1.ToString();
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                CheckCreditDebitMemo checkCreditDebitMemo = new CheckCreditDebitMemo();
                return checkCreditDebitMemo;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_WriteOff_TempCheck(String InvoiceNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WriteOff_TempCheck";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);

                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Check = reader[0].ToString();
                    return Check;
                }
                else
                {
                    return "";
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_NS_REVERSE_AP(String NSNumber, String InvoiceNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_NS_REVERSE_AP";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NSNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);

                cmd.Parameters["@NSNumber"].Value = NSNumber;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@User"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public Decimal sp_CHECK_CreditDebitAmount_AP(String Number)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_CreditDebitAmount_AP";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Number", SqlDbType.VarChar);
                
                SqlParameter amount = new SqlParameter("@Amount", SqlDbType.Decimal);
                amount.Precision = 18;
                amount.Scale = 2;
                amount.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(amount);


                cmd.Parameters["@Number"].Value = Number;

                connection2.Open();

                cmd.ExecuteNonQuery();

                //int return1 = (int)cmd.Parameters["@return_value"].Value;
                Decimal Amount = Convert.ToDecimal(cmd.Parameters["@Amount"].Value.ToString());
                return Amount;
                
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_PromotionScheduleH_INSERT(String PRMNumber, String BrandCode, String BrandName, DateTime StartDate, DateTime EndDate, String PromotionMemo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PromotionScheduleH_INSERT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PRMNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@BrandName", SqlDbType.VarChar);
                cmd.Parameters.Add("@StartDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@EndDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@PromotionMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@PRMNumber"].Value = PRMNumber;
                cmd.Parameters["@BrandCode"].Value = BrandCode;
                cmd.Parameters["@BrandName"].Value = BrandName;
                cmd.Parameters["@StartDate"].Value = StartDate;
                cmd.Parameters["@EndDate"].Value = EndDate;
                cmd.Parameters["@PromotionMemo"].Value = PromotionMemo;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public String sp_GET_NewPRMNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_NewPRMNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewPRMNumber", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewPRMNumber = cmd.Parameters["@NewPRMNumber"].Value.ToString();

                if (return1 == 0)
                {
                    return NewPRMNumber;
                }
                else
                {
                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_PromotionSchedule_INSERT(String PRMNumber, PromotionScheduleObject promotionScheduleObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PromotionSchedule_INSERT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PRMNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionTypeCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionBase", SqlDbType.VarChar);
                cmd.Parameters.Add("@StartDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@EndDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@PromotionMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@BasePrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@Type", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionValue1", SqlDbType.Decimal);
                cmd.Parameters.Add("@PromotionMethod1", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionValue2", SqlDbType.Decimal);
                cmd.Parameters.Add("@PromotionMethod2", SqlDbType.VarChar);
                cmd.Parameters.Add("@PromotionBuy", SqlDbType.Decimal);
                cmd.Parameters.Add("@PromotionFree", SqlDbType.Decimal);
                cmd.Parameters.Add("@NetPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@Checked", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@PRMNumber"].Value = PRMNumber;
                cmd.Parameters["@BrandCode"].Value = promotionScheduleObject.BrandCode;
                cmd.Parameters["@PromotionTypeCode"].Value = promotionScheduleObject.PromotionTypeCode;
                cmd.Parameters["@PromotionBase"].Value = promotionScheduleObject.PromotionBase;
                cmd.Parameters["@StartDate"].Value = promotionScheduleObject.StartDate;
                cmd.Parameters["@EndDate"].Value = promotionScheduleObject.EndDate;
                cmd.Parameters["@PromotionMemo"].Value = promotionScheduleObject.PromotionMemo;
                cmd.Parameters["@ProductID"].Value = promotionScheduleObject.ProductID;
                cmd.Parameters["@BasePrice"].Value = promotionScheduleObject.BasePrice;
                cmd.Parameters["@Type"].Value = promotionScheduleObject.Type;
                cmd.Parameters["@PromotionValue1"].Value = promotionScheduleObject.PromotionValue1;
                cmd.Parameters["@PromotionMethod1"].Value = promotionScheduleObject.PromotionMethod1;
                cmd.Parameters["@PromotionValue2"].Value = promotionScheduleObject.PromotionValue2;
                cmd.Parameters["@PromotionMethod2"].Value = promotionScheduleObject.PromotionMethod2;
                cmd.Parameters["@PromotionBuy"].Value = promotionScheduleObject.PromotionBuy;
                cmd.Parameters["@PromotionFree"].Value = promotionScheduleObject.PromotionFree;
                cmd.Parameters["@NetPrice"].Value = promotionScheduleObject.NetPrice;
                cmd.Parameters["@Checked"].Value = promotionScheduleObject.Checked;
                cmd.Parameters["@Status"].Value = promotionScheduleObject.Status;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

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

        static public void sp_PromotionSchedule_Header(DataGridView _dataGridView, String Type, String BrandCode, DateTime StartDate, DateTime EndDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PromotionSchedule_Header";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Type", SqlDbType.VarChar);
                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@StartDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@EndDate", SqlDbType.DateTime);

                cmd.Parameters["@Type"].Value = Type;
                cmd.Parameters["@BrandCode"].Value = BrandCode;
                cmd.Parameters["@StartDate"].Value = StartDate;
                cmd.Parameters["@EndDate"].Value = EndDate;

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

        static public void cbo_Company(ComboBox cbo_Company)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [CompanyCode] ";
                sql = sql + "FROM COMPANY with(nolock) ";
                sql = sql + "WHERE CompanyStatus = 'Active' ";
                sql = sql + "Order by CompanyCode";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_Company.Items.Add(reader[0].ToString().Trim());
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

        static public string getCompanyName(string CompanyCode)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT CompanyName ";
                sql = sql + "FROM COMPANY WITH(NOLOCK) ";
                sql = sql + "WHERE CompanyCode = '" + CompanyCode + "'";
                sql = sql + "";

                connection3.Open();
                SqlCommand cmd = new SqlCommand(sql, connection3);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CompanyName = reader[0].ToString();
                    return CompanyName;
                }
                else
                {
                    return "";
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection3.Close();
            }
        }

        static public decimal getItemBasePriceDividebyConvFromItemID(string ItemID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT ROUND((BasePrice / StockConversionQty), 2) AS BasePrice ";
                sql = sql + "FROM Product WITH(NOLOCK) ";
                sql = sql + "WHERE ProductID = '" + ItemID + "'";
                sql = sql + "";

                connection3.Open();
                SqlCommand cmd = new SqlCommand(sql, connection3);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    decimal BasePrice = Convert.ToDecimal(reader[0].ToString());
                    return BasePrice;
                }
                else
                {
                    return 0;
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection3.Close();
            }
        }

        static public String sp_GET_NewBCSMTKNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_NewBCSMTKNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewBCSMTKNumber", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewDISNumber = cmd.Parameters["@NewBCSMTKNumber"].Value.ToString();

                if (return1 == 0)
                {
                    return NewDISNumber;

                }
                else
                {
                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_Stock_Available_Check(String ProductID, String LOTNumber, Decimal Qty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Stock_Available_Check";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOTNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Result", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@LOTNumber"].Value = LOTNumber;
                cmd.Parameters["@Qty"].Value = Qty;

                connection.Open();

                cmd.ExecuteNonQuery();

                string Result = cmd.Parameters["@Result"].Value.ToString();

                return Result;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        static public void txt_DisReceipt(String TABLENAME, DateTimePicker AccountingDate, TextBox txt_Memo, String Number)
        {
            try
            {
                string sql = "";

                sql = sql + "SELECT IPTDAT_0, VCRDES_0 ";
                sql = sql + "FROM " + TABLENAME + " with(nolock) ";
                sql = sql + "WHERE VCRNUM_0 = '" + Number + "' AND UPDTICK_0 < 1000";

                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AccountingDate.Value = Convert.ToDateTime(reader[0].ToString());
                    txt_Memo.Text = reader[1].ToString();
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

        static public void sp_MANUFACTURINGRECEIPT_SELECT_DETAIL(DataGridView _dataGridView, String BCSMTKNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_MANUFACTURINGRECEIPT_SELECT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BCSMTKNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@BCSMTKNumber"].Value = BCSMTKNumber;
                //cmd.Parameters["@ItemID"].Value = ItemID;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public String sp_GET_NewASMNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_NewASMNumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewASMNumber", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewDISNumber = cmd.Parameters["@NewASMNumber"].Value.ToString();

                if (return1 == 0)
                {
                    return NewDISNumber;
                }
                else
                {
                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_GET_NewDISNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_NewDISNumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewDISNumber", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewDISNumber = cmd.Parameters["@NewDISNumber"].Value.ToString();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());

                    return NewDISNumber;
                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());

                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_DISASSEMBLYRECEIPT_SELECT_DETAIL(DataGridView _dataGridView, String DISNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection3;
                cmd.CommandText = "dbo.sp_DISASSEMBLYRECEIPT_SELECT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@DISNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@DISNumber"].Value = DISNumber;
                //cmd.Parameters["@ItemID"].Value = ItemID;

                connection3.Open();

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
                connection3.Close();
            }
        }

        static public UserObject sp_GET_UserObject(String UserID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_UserObject";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);

                cmd.Parameters["@UserID"].Value = UserID;

                connection2.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                UserObject userObject = new UserObject();

                if (sqlDataReader.Read())
                {

                    userObject.UserStatus = sqlDataReader["UserStatus"].ToString().Trim();
                    userObject.UserID = sqlDataReader["UserID"].ToString().Trim();
                    userObject.FullName = sqlDataReader["FullName"].ToString().Trim();
                    userObject.Email = sqlDataReader["Email"].ToString().Trim();
                    userObject.Department = sqlDataReader["Department"].ToString().Trim();
                    userObject.PhoneNumber = sqlDataReader["PhoneNumber"].ToString().Trim();
                    userObject.StartDate = sqlDataReader["StartDate"] == DBNull.Value ? Convert.ToDateTime("01/01/1900") : (DateTime?)sqlDataReader["StartDate"];
                    userObject.EndDate =  sqlDataReader["EndDate"] == DBNull.Value ? Convert.ToDateTime("01/01/1900") : (DateTime?)sqlDataReader["EndDate"];
                    userObject.EmergencyContactName = sqlDataReader["EmergencyContactName"].ToString().Trim();
                    userObject.EmergencyContactNumber = sqlDataReader["EmergencyContactNumber"].ToString().Trim();

                    //menu
                    userObject.accounting = Convert.ToBoolean(sqlDataReader["accounting"].ToString().Trim());
                    userObject.sales = Convert.ToBoolean(sqlDataReader["sales"].ToString().Trim());
                    userObject.accountsReceivable = Convert.ToBoolean(sqlDataReader["accountsReceivable"].ToString().Trim());
                    userObject.purchaseOrder = Convert.ToBoolean(sqlDataReader["purchaseOrder"].ToString().Trim());
                    userObject.accountsPayable = Convert.ToBoolean(sqlDataReader["accountsPayable"].ToString().Trim());
                    userObject.stock = Convert.ToBoolean(sqlDataReader["stock"].ToString().Trim());
                    userObject.mWMS = Convert.ToBoolean(sqlDataReader["mWMS"].ToString().Trim());
                    userObject.lists = Convert.ToBoolean(sqlDataReader["lists"].ToString().Trim());
                    userObject.map = Convert.ToBoolean(sqlDataReader["map"].ToString().Trim());
                    userObject.systemMenu = Convert.ToBoolean(sqlDataReader["systemMenu"].ToString().Trim());
                    userObject.generalJournalEntries = Convert.ToBoolean(sqlDataReader["generalJournalEntries"].ToString().Trim());
                    userObject.profitAndLossReport = Convert.ToBoolean(sqlDataReader["profitAndLossReport"].ToString().Trim());
                    userObject.salesOrder = Convert.ToBoolean(sqlDataReader["salesOrder"].ToString().Trim());
                    userObject.auditSalesOrder = Convert.ToBoolean(sqlDataReader["auditSalesOrder"].ToString().Trim());
                    userObject.confirmedSalesOrder = Convert.ToBoolean(sqlDataReader["confirmedSalesOrder"].ToString().Trim());
                    userObject.preparationPlan = Convert.ToBoolean(sqlDataReader["preparationPlan"].ToString().Trim());
                    userObject.pickingTicket = Convert.ToBoolean(sqlDataReader["pickingTicket"].ToString().Trim());
                    userObject.deliveryNote = Convert.ToBoolean(sqlDataReader["deliveryNote"].ToString().Trim());
                    userObject.duplicateSalesOrder = Convert.ToBoolean(sqlDataReader["duplicateSalesOrder"].ToString().Trim());
                    userObject.deallocation = Convert.ToBoolean(sqlDataReader["deallocation"].ToString().Trim());
                    userObject.packageNutLabel = Convert.ToBoolean(sqlDataReader["packageNutLabel"].ToString().Trim());
                    userObject.salesReport = Convert.ToBoolean(sqlDataReader["salesReport"].ToString().Trim());
                    userObject.packageNutLabelPrint = Convert.ToBoolean(sqlDataReader["packageNutLabelPrint"].ToString().Trim());
                    userObject.packageNutCustomerOption = Convert.ToBoolean(sqlDataReader["packageNutCustomerOption"].ToString().Trim());
                    userObject.packageNutCustomPrice = Convert.ToBoolean(sqlDataReader["packageNutCustomPrice"].ToString().Trim());
                    userObject.salesOrderExceptionReport = Convert.ToBoolean(sqlDataReader["salesOrderExceptionReport"].ToString().Trim());
                    userObject.salesbyRepReport = Convert.ToBoolean(sqlDataReader["salesbyRepReport"].ToString().Trim());
                    userObject.salesbyCustomerReport = Convert.ToBoolean(sqlDataReader["salesbyCustomerReport"].ToString().Trim());
                    userObject.salesbyProductReport = Convert.ToBoolean(sqlDataReader["salesbyProductReport"].ToString().Trim());
                    userObject.salesPerformanceReport = Convert.ToBoolean(sqlDataReader["salesPerformanceReport"].ToString().Trim());
                    userObject.nutCategorySalesReport = Convert.ToBoolean(sqlDataReader["nutCategorySalesReport"].ToString().Trim());
                    userObject.commissionReport = Convert.ToBoolean(sqlDataReader["commissionReport"].ToString().Trim());
                    userObject.collectionfromDelivery = Convert.ToBoolean(sqlDataReader["collectionfromDelivery"].ToString().Trim());
                    userObject.collectionfromSales = Convert.ToBoolean(sqlDataReader["collectionfromSales"].ToString().Trim());
                    userObject.validation = Convert.ToBoolean(sqlDataReader["validation"].ToString().Trim());
                    userObject.invoice = Convert.ToBoolean(sqlDataReader["invoice"].ToString().Trim());
                    userObject.creditMemoRequest = Convert.ToBoolean(sqlDataReader["creditMemoRequest"].ToString().Trim());
                    userObject.netSettlement = Convert.ToBoolean(sqlDataReader["netSettlement"].ToString().Trim());
                    userObject.arPayment = Convert.ToBoolean(sqlDataReader["arPayment"].ToString().Trim());
                    userObject.entryBatch = Convert.ToBoolean(sqlDataReader["entryBatch"].ToString().Trim());
                    userObject.deposit = Convert.ToBoolean(sqlDataReader["deposit"].ToString().Trim());
                    userObject.writeoff = Convert.ToBoolean(sqlDataReader["writeoff"].ToString().Trim());
                    userObject.arReports = Convert.ToBoolean(sqlDataReader["arReports"].ToString().Trim());
                    userObject.arAging = Convert.ToBoolean(sqlDataReader["arAging"].ToString().Trim());
                    userObject.arbyCustomerReport = Convert.ToBoolean(sqlDataReader["arbyCustomerReport"].ToString().Trim());
                    userObject.arbySalespersonReport = Convert.ToBoolean(sqlDataReader["arbySalespersonReport"].ToString().Trim());
                    userObject.arCollectionsSummary = Convert.ToBoolean(sqlDataReader["arCollectionsSummary"].ToString().Trim());
                    userObject.arSalesDebitMemoSummary = Convert.ToBoolean(sqlDataReader["arSalesDebitMemoSummary"].ToString().Trim());
                    userObject.arOverpayment = Convert.ToBoolean(sqlDataReader["arOverpayment"].ToString().Trim());
                    userObject.nonSufficientFundsReport = Convert.ToBoolean(sqlDataReader["nonSufficientFundsReport"].ToString().Trim());
                    userObject.promotionSchedule = Convert.ToBoolean(sqlDataReader["promotionSchedule"].ToString().Trim());
                    userObject.poPrepare = Convert.ToBoolean(sqlDataReader["poPrepare"].ToString().Trim());
                    userObject.po = Convert.ToBoolean(sqlDataReader["po"].ToString().Trim());
                    userObject.goodsReceipt = Convert.ToBoolean(sqlDataReader["goodsReceipt"].ToString().Trim());
                    userObject.poReports = Convert.ToBoolean(sqlDataReader["poReports"].ToString().Trim());
                    userObject.poExceptionReport = Convert.ToBoolean(sqlDataReader["poExceptionReport"].ToString().Trim());
                    userObject.subcontractOrderExceptionReport = Convert.ToBoolean(sqlDataReader["subcontractOrderExceptionReport"].ToString().Trim());
                    userObject.poManagementReport = Convert.ToBoolean(sqlDataReader["poManagementReport"].ToString().Trim());
                    userObject.poManagementDetailReport = Convert.ToBoolean(sqlDataReader["poManagementDetailReport"].ToString().Trim());
                    userObject.poForecastReport = Convert.ToBoolean(sqlDataReader["poForecastReport"].ToString().Trim());
                    userObject.poDepartmentSalesReport = Convert.ToBoolean(sqlDataReader["poDepartmentSalesReport"].ToString().Trim());
                    userObject.apValidation = Convert.ToBoolean(sqlDataReader["apValidation"].ToString().Trim());
                    userObject.apDebitNote = Convert.ToBoolean(sqlDataReader["apDebitNote"].ToString().Trim());
                    userObject.apCreditMemoRequest = Convert.ToBoolean(sqlDataReader["apCreditMemoRequest"].ToString().Trim());
                    userObject.apDebitMemoRequest = Convert.ToBoolean(sqlDataReader["apDebitMemoRequest"].ToString().Trim());
                    userObject.apNetSettlement = Convert.ToBoolean(sqlDataReader["apNetSettlement"].ToString().Trim());
                    userObject.paymentResolution = Convert.ToBoolean(sqlDataReader["paymentResolution"].ToString().Trim());
                    userObject.apPayment = Convert.ToBoolean(sqlDataReader["apPayment"].ToString().Trim());
                    userObject.apReports = Convert.ToBoolean(sqlDataReader["apReports"].ToString().Trim());
                    userObject.apAging = Convert.ToBoolean(sqlDataReader["apAging"].ToString().Trim());
                    userObject.assembly = Convert.ToBoolean(sqlDataReader["assembly"].ToString().Trim());
                    userObject.assemblyRecipt = Convert.ToBoolean(sqlDataReader["assemblyRecipt"].ToString().Trim());
                    userObject.disassembly = Convert.ToBoolean(sqlDataReader["disassembly"].ToString().Trim());
                    userObject.disassemblyReceipt = Convert.ToBoolean(sqlDataReader["disassemblyReceipt"].ToString().Trim());
                    userObject.manufacturing = Convert.ToBoolean(sqlDataReader["manufacturing"].ToString().Trim());
                    userObject.manufacturingReceipt = Convert.ToBoolean(sqlDataReader["manufacturingReceipt"].ToString().Trim());
                    userObject.miscellaneousIssue = Convert.ToBoolean(sqlDataReader["miscellaneousIssue"].ToString().Trim());
                    userObject.miscellaneousReceipt = Convert.ToBoolean(sqlDataReader["miscellaneousReceipt"].ToString().Trim());
                    userObject.subcontractOrder = Convert.ToBoolean(sqlDataReader["subcontractOrder"].ToString().Trim());
                    userObject.subcontractReceipt = Convert.ToBoolean(sqlDataReader["subcontractReceipt"].ToString().Trim());
                    userObject.intersiteTransfer = Convert.ToBoolean(sqlDataReader["intersiteTransfer"].ToString().Trim());
                    userObject.receiptReturn = Convert.ToBoolean(sqlDataReader["receiptReturn"].ToString().Trim());
                    userObject.shipmentReturn = Convert.ToBoolean(sqlDataReader["shipmentReturn"].ToString().Trim());
                    userObject.stockChange = Convert.ToBoolean(sqlDataReader["stockChange"].ToString().Trim());
                    userObject.stockReports = Convert.ToBoolean(sqlDataReader["stockReports"].ToString().Trim());
                    userObject.ipadShortageReport = Convert.ToBoolean(sqlDataReader["ipadShortageReport"].ToString().Trim());
                    userObject.globalShortageReport = Convert.ToBoolean(sqlDataReader["globalShortageReport"].ToString().Trim());
                    userObject.detailedShortageReport = Convert.ToBoolean(sqlDataReader["detailedShortageReport"].ToString().Trim());
                    userObject.inventoryManagement = Convert.ToBoolean(sqlDataReader["inventoryManagement"].ToString().Trim());
                    userObject.miscellaneousTransactionReport = Convert.ToBoolean(sqlDataReader["miscellaneousTransactionReport"].ToString().Trim());
                    userObject.stockTransactionReport = Convert.ToBoolean(sqlDataReader["stockTransactionReport"].ToString().Trim());
                    userObject.stockMovementReport = Convert.ToBoolean(sqlDataReader["stockMovementReport"].ToString().Trim());
                    userObject.stockValuationReport = Convert.ToBoolean(sqlDataReader["stockValuationReport"].ToString().Trim());
                    userObject.wmsGoodsReceipt = Convert.ToBoolean(sqlDataReader["wmsGoodsReceipt"].ToString().Trim());
                    userObject.wmsStockStatusChange = Convert.ToBoolean(sqlDataReader["wmsStockStatusChange"].ToString().Trim());
                    userObject.wmsShipmentReturn = Convert.ToBoolean(sqlDataReader["wmsShipmentReturn"].ToString().Trim());
                    userObject.IntersiteTransferOrder = Convert.ToBoolean(sqlDataReader["IntersiteTransferOrder"].ToString().Trim());
                    userObject.IntersiteTransferReceipt = Convert.ToBoolean(sqlDataReader["IntersiteTransferReceipt"].ToString().Trim());
                    userObject.wmsCustomerDelivery = Convert.ToBoolean(sqlDataReader["wmsCustomerDelivery"].ToString().Trim());
                    userObject.wmsReceiptReturn = Convert.ToBoolean(sqlDataReader["wmsReceiptReturn"].ToString().Trim());
                    userObject.brandList = Convert.ToBoolean(sqlDataReader["brandList"].ToString().Trim());
                    userObject.chartOfAccount = Convert.ToBoolean(sqlDataReader["chartOfAccount"].ToString().Trim());
                    userObject.companyList = Convert.ToBoolean(sqlDataReader["companyList"].ToString().Trim());
                    userObject.customerList = Convert.ToBoolean(sqlDataReader["customerList"].ToString().Trim());
                    userObject.customerPriceEntry = Convert.ToBoolean(sqlDataReader["customerPriceEntry"].ToString().Trim());
                    userObject.deliveryRoutePlanList = Convert.ToBoolean(sqlDataReader["deliveryRoutePlanList"].ToString().Trim());
                    userObject.driverList = Convert.ToBoolean(sqlDataReader["driverList"].ToString().Trim());
                    userObject.paymentTermList = Convert.ToBoolean(sqlDataReader["paymentTermList"].ToString().Trim());
                    userObject.productList = Convert.ToBoolean(sqlDataReader["productList"].ToString().Trim());
                    userObject.promotionScheduleTypeList = Convert.ToBoolean(sqlDataReader["promotionScheduleTypeList"].ToString().Trim());
                    userObject.salesPersonList = Convert.ToBoolean(sqlDataReader["salesPersonList"].ToString().Trim());
                    userObject.supplierList = Convert.ToBoolean(sqlDataReader["supplierList"].ToString().Trim());
                    userObject.customerMap = Convert.ToBoolean(sqlDataReader["customerMap"].ToString().Trim());
                    userObject.customerMapWeb = Convert.ToBoolean(sqlDataReader["customerMapWeb"].ToString().Trim());
                    userObject.salesByCategoryMap = Convert.ToBoolean(sqlDataReader["salesByCategoryMap"].ToString().Trim());
                    userObject.userMaintenance = Convert.ToBoolean(sqlDataReader["userMaintenance"].ToString().Trim());

                }
                return userObject;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                UserObject userObject = new UserObject();
                return userObject;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_UPDATE_UserInfo(UserObject userObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_UserInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@UserStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@FullName", SqlDbType.VarChar);
                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters.Add("@Department", SqlDbType.VarChar);
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@StartDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@EndDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@EmergencyContactName", SqlDbType.VarChar);
                cmd.Parameters.Add("@EmergencyContactNumber", SqlDbType.VarChar);
                //menu
                cmd.Parameters.Add("@accounting", SqlDbType.Bit);
                cmd.Parameters.Add("@sales", SqlDbType.Bit);
                cmd.Parameters.Add("@accountsReceivable", SqlDbType.Bit);
                cmd.Parameters.Add("@purchaseOrder", SqlDbType.Bit);
                cmd.Parameters.Add("@accountsPayable", SqlDbType.Bit);
                cmd.Parameters.Add("@stock", SqlDbType.Bit);
                cmd.Parameters.Add("@mWMS", SqlDbType.Bit);
                cmd.Parameters.Add("@lists", SqlDbType.Bit);
                cmd.Parameters.Add("@map", SqlDbType.Bit);
                cmd.Parameters.Add("@systemMenu", SqlDbType.Bit);
                cmd.Parameters.Add("@generalJournalEntries", SqlDbType.Bit);
                cmd.Parameters.Add("@profitAndLossReport", SqlDbType.Bit);
                cmd.Parameters.Add("@salesOrder", SqlDbType.Bit);
                cmd.Parameters.Add("@auditSalesOrder", SqlDbType.Bit);
                cmd.Parameters.Add("@confirmedSalesOrder", SqlDbType.Bit);
                cmd.Parameters.Add("@preparationPlan", SqlDbType.Bit);
                cmd.Parameters.Add("@pickingTicket", SqlDbType.Bit);
                cmd.Parameters.Add("@deliveryNote", SqlDbType.Bit);
                cmd.Parameters.Add("@duplicateSalesOrder", SqlDbType.Bit);
                cmd.Parameters.Add("@deallocation", SqlDbType.Bit);
                cmd.Parameters.Add("@packageNutLabel", SqlDbType.Bit);
                cmd.Parameters.Add("@salesReport", SqlDbType.Bit);
                cmd.Parameters.Add("@packageNutLabelPrint", SqlDbType.Bit);
                cmd.Parameters.Add("@packageNutCustomerOption", SqlDbType.Bit);
                cmd.Parameters.Add("@packageNutCustomPrice", SqlDbType.Bit);
                cmd.Parameters.Add("@salesOrderExceptionReport", SqlDbType.Bit);
                cmd.Parameters.Add("@salesbyRepReport", SqlDbType.Bit);
                cmd.Parameters.Add("@salesbyCustomerReport", SqlDbType.Bit);
                cmd.Parameters.Add("@salesbyProductReport", SqlDbType.Bit);
                cmd.Parameters.Add("@salesPerformanceReport", SqlDbType.Bit);
                cmd.Parameters.Add("@nutCategorySalesReport", SqlDbType.Bit);
                cmd.Parameters.Add("@commissionReport", SqlDbType.Bit);
                cmd.Parameters.Add("@collectionfromDelivery", SqlDbType.Bit);
                cmd.Parameters.Add("@collectionfromSales", SqlDbType.Bit);
                cmd.Parameters.Add("@validation", SqlDbType.Bit);
                cmd.Parameters.Add("@invoice", SqlDbType.Bit);
                cmd.Parameters.Add("@creditMemoRequest", SqlDbType.Bit);
                cmd.Parameters.Add("@netSettlement", SqlDbType.Bit);
                cmd.Parameters.Add("@arPayment", SqlDbType.Bit);
                cmd.Parameters.Add("@entryBatch", SqlDbType.Bit);
                cmd.Parameters.Add("@deposit", SqlDbType.Bit);
                cmd.Parameters.Add("@writeoff", SqlDbType.Bit);
                cmd.Parameters.Add("@arReports", SqlDbType.Bit);
                cmd.Parameters.Add("@arAging", SqlDbType.Bit);
                cmd.Parameters.Add("@arbyCustomerReport", SqlDbType.Bit);
                cmd.Parameters.Add("@arbySalespersonReport", SqlDbType.Bit);
                cmd.Parameters.Add("@arCollectionsSummary", SqlDbType.Bit);
                cmd.Parameters.Add("@arSalesDebitMemoSummary", SqlDbType.Bit);
                cmd.Parameters.Add("@arOverpayment", SqlDbType.Bit);
                cmd.Parameters.Add("@nonSufficientFundsReport", SqlDbType.Bit);
                cmd.Parameters.Add("@promotionSchedule", SqlDbType.Bit);
                cmd.Parameters.Add("@poPrepare", SqlDbType.Bit);
                cmd.Parameters.Add("@po", SqlDbType.Bit);
                cmd.Parameters.Add("@goodsReceipt", SqlDbType.Bit);
                cmd.Parameters.Add("@poReports", SqlDbType.Bit);
                cmd.Parameters.Add("@poExceptionReport", SqlDbType.Bit);
                cmd.Parameters.Add("@subcontractOrderExceptionReport", SqlDbType.Bit);
                cmd.Parameters.Add("@poManagementReport", SqlDbType.Bit);
                cmd.Parameters.Add("@poManagementDetailReport", SqlDbType.Bit);
                cmd.Parameters.Add("@poForecastReport", SqlDbType.Bit);
                cmd.Parameters.Add("@poDepartmentSalesReport", SqlDbType.Bit);
                cmd.Parameters.Add("@apValidation", SqlDbType.Bit);
                cmd.Parameters.Add("@apDebitNote", SqlDbType.Bit);
                cmd.Parameters.Add("@apCreditMemoRequest", SqlDbType.Bit);
                cmd.Parameters.Add("@apDebitMemoRequest", SqlDbType.Bit);
                cmd.Parameters.Add("@apNetSettlement", SqlDbType.Bit);
                cmd.Parameters.Add("@paymentResolution", SqlDbType.Bit);
                cmd.Parameters.Add("@apPayment", SqlDbType.Bit);
                cmd.Parameters.Add("@apReports", SqlDbType.Bit);
                cmd.Parameters.Add("@apAging", SqlDbType.Bit);
                cmd.Parameters.Add("@assembly", SqlDbType.Bit);
                cmd.Parameters.Add("@assemblyRecipt", SqlDbType.Bit);
                cmd.Parameters.Add("@disassembly", SqlDbType.Bit);
                cmd.Parameters.Add("@disassemblyReceipt", SqlDbType.Bit);
                cmd.Parameters.Add("@manufacturing", SqlDbType.Bit);
                cmd.Parameters.Add("@manufacturingReceipt", SqlDbType.Bit);
                cmd.Parameters.Add("@miscellaneousIssue", SqlDbType.Bit);
                cmd.Parameters.Add("@miscellaneousReceipt", SqlDbType.Bit);
                cmd.Parameters.Add("@subcontractOrder", SqlDbType.Bit);
                cmd.Parameters.Add("@subcontractReceipt", SqlDbType.Bit);
                cmd.Parameters.Add("@intersiteTransfer", SqlDbType.Bit);
                cmd.Parameters.Add("@receiptReturn", SqlDbType.Bit);
                cmd.Parameters.Add("@shipmentReturn", SqlDbType.Bit);
                cmd.Parameters.Add("@stockChange", SqlDbType.Bit);
                cmd.Parameters.Add("@stockReports", SqlDbType.Bit);
                cmd.Parameters.Add("@ipadShortageReport", SqlDbType.Bit);
                cmd.Parameters.Add("@globalShortageReport", SqlDbType.Bit);
                cmd.Parameters.Add("@detailedShortageReport", SqlDbType.Bit);
                cmd.Parameters.Add("@inventoryManagement", SqlDbType.Bit);
                cmd.Parameters.Add("@miscellaneousTransactionReport", SqlDbType.Bit);
                cmd.Parameters.Add("@stockTransactionReport", SqlDbType.Bit);
                cmd.Parameters.Add("@stockMovementReport", SqlDbType.Bit);
                cmd.Parameters.Add("@stockValuationReport", SqlDbType.Bit);
                cmd.Parameters.Add("@wmsGoodsReceipt", SqlDbType.Bit);
                cmd.Parameters.Add("@wmsStockStatusChange", SqlDbType.Bit);
                cmd.Parameters.Add("@wmsShipmentReturn", SqlDbType.Bit);
                cmd.Parameters.Add("@IntersiteTransferOrder", SqlDbType.Bit);
                cmd.Parameters.Add("@IntersiteTransferReceipt", SqlDbType.Bit);
                cmd.Parameters.Add("@wmsCustomerDelivery", SqlDbType.Bit);
                cmd.Parameters.Add("@wmsReceiptReturn", SqlDbType.Bit);
                cmd.Parameters.Add("@brandList", SqlDbType.Bit);
                cmd.Parameters.Add("@chartOfAccount", SqlDbType.Bit);
                cmd.Parameters.Add("@companyList", SqlDbType.Bit);
                cmd.Parameters.Add("@customerList", SqlDbType.Bit);
                cmd.Parameters.Add("@customerPriceEntry", SqlDbType.Bit);
                cmd.Parameters.Add("@deliveryRoutePlanList", SqlDbType.Bit);
                cmd.Parameters.Add("@driverList", SqlDbType.Bit);
                cmd.Parameters.Add("@paymentTermList", SqlDbType.Bit);
                cmd.Parameters.Add("@productList", SqlDbType.Bit);
                cmd.Parameters.Add("@promotionScheduleTypeList", SqlDbType.Bit);
                cmd.Parameters.Add("@salesPersonList", SqlDbType.Bit);
                cmd.Parameters.Add("@supplierList", SqlDbType.Bit);
                cmd.Parameters.Add("@customerMap", SqlDbType.Bit);
                cmd.Parameters.Add("@customerMapWeb", SqlDbType.Bit);
                cmd.Parameters.Add("@salesByCategoryMap", SqlDbType.Bit);
                cmd.Parameters.Add("@userMaintenance", SqlDbType.Bit);


                cmd.Parameters["@UserStatus"].Value = userObject.UserStatus;
                cmd.Parameters["@UserID"].Value = userObject.UserID;
                cmd.Parameters["@FullName"].Value = userObject.FullName;
                cmd.Parameters["@Email"].Value = userObject.Email;
                cmd.Parameters["@Department"].Value = userObject.Department;
                cmd.Parameters["@PhoneNumber"].Value = userObject.PhoneNumber;
                cmd.Parameters["@StartDate"].Value = userObject.StartDate;
                cmd.Parameters["@EndDate"].Value = userObject.EndDate;
                cmd.Parameters["@EmergencyContactName"].Value = userObject.EmergencyContactName;
                cmd.Parameters["@EmergencyContactNumber"].Value = userObject.EmergencyContactNumber;
                //menu
                cmd.Parameters["@accounting"].Value = userObject.accounting;
                cmd.Parameters["@sales"].Value = userObject.sales;
                cmd.Parameters["@accountsReceivable"].Value = userObject.accountsReceivable;
                cmd.Parameters["@purchaseOrder"].Value = userObject.purchaseOrder;
                cmd.Parameters["@accountsPayable"].Value = userObject.accountsPayable;
                cmd.Parameters["@stock"].Value = userObject.stock;
                cmd.Parameters["@mWMS"].Value = userObject.mWMS;
                cmd.Parameters["@lists"].Value = userObject.lists;
                cmd.Parameters["@map"].Value = userObject.map;
                cmd.Parameters["@systemMenu"].Value = userObject.systemMenu;
                cmd.Parameters["@generalJournalEntries"].Value = userObject.generalJournalEntries;
                cmd.Parameters["@profitAndLossReport"].Value = userObject.profitAndLossReport;
                cmd.Parameters["@salesOrder"].Value = userObject.salesOrder;
                cmd.Parameters["@auditSalesOrder"].Value = userObject.auditSalesOrder;
                cmd.Parameters["@confirmedSalesOrder"].Value = userObject.confirmedSalesOrder;
                cmd.Parameters["@preparationPlan"].Value = userObject.preparationPlan;
                cmd.Parameters["@pickingTicket"].Value = userObject.pickingTicket;
                cmd.Parameters["@deliveryNote"].Value = userObject.deliveryNote;
                cmd.Parameters["@duplicateSalesOrder"].Value = userObject.duplicateSalesOrder;
                cmd.Parameters["@deallocation"].Value = userObject.deallocation;
                cmd.Parameters["@packageNutLabel"].Value = userObject.packageNutLabel;
                cmd.Parameters["@salesReport"].Value = userObject.salesReport;
                cmd.Parameters["@packageNutLabelPrint"].Value = userObject.packageNutLabelPrint;
                cmd.Parameters["@packageNutCustomerOption"].Value = userObject.packageNutCustomerOption;
                cmd.Parameters["@packageNutCustomPrice"].Value = userObject.packageNutCustomPrice;
                cmd.Parameters["@salesOrderExceptionReport"].Value = userObject.salesOrderExceptionReport;
                cmd.Parameters["@salesbyRepReport"].Value = userObject.salesbyRepReport;
                cmd.Parameters["@salesbyCustomerReport"].Value = userObject.salesbyCustomerReport;
                cmd.Parameters["@salesbyProductReport"].Value = userObject.salesbyProductReport;
                cmd.Parameters["@salesPerformanceReport"].Value = userObject.salesPerformanceReport;
                cmd.Parameters["@nutCategorySalesReport"].Value = userObject.nutCategorySalesReport;
                cmd.Parameters["@commissionReport"].Value = userObject.commissionReport;
                cmd.Parameters["@collectionfromDelivery"].Value = userObject.collectionfromDelivery;
                cmd.Parameters["@collectionfromSales"].Value = userObject.collectionfromSales;
                cmd.Parameters["@validation"].Value = userObject.validation;
                cmd.Parameters["@invoice"].Value = userObject.invoice;
                cmd.Parameters["@creditMemoRequest"].Value = userObject.creditMemoRequest;
                cmd.Parameters["@netSettlement"].Value = userObject.netSettlement;
                cmd.Parameters["@arPayment"].Value = userObject.arPayment;
                cmd.Parameters["@entryBatch"].Value = userObject.entryBatch;
                cmd.Parameters["@deposit"].Value = userObject.deposit;
                cmd.Parameters["@writeoff"].Value = userObject.writeoff;
                cmd.Parameters["@arReports"].Value = userObject.arReports;
                cmd.Parameters["@arAging"].Value = userObject.arAging;
                cmd.Parameters["@arbyCustomerReport"].Value = userObject.arbyCustomerReport;
                cmd.Parameters["@arbySalespersonReport"].Value = userObject.arbySalespersonReport;
                cmd.Parameters["@arCollectionsSummary"].Value = userObject.arCollectionsSummary;
                cmd.Parameters["@arSalesDebitMemoSummary"].Value = userObject.arSalesDebitMemoSummary;
                cmd.Parameters["@arOverpayment"].Value = userObject.arOverpayment;
                cmd.Parameters["@nonSufficientFundsReport"].Value = userObject.nonSufficientFundsReport;
                cmd.Parameters["@promotionSchedule"].Value = userObject.promotionSchedule;
                cmd.Parameters["@poPrepare"].Value = userObject.poPrepare;
                cmd.Parameters["@po"].Value = userObject.po;
                cmd.Parameters["@goodsReceipt"].Value = userObject.goodsReceipt;
                cmd.Parameters["@poReports"].Value = userObject.poReports;
                cmd.Parameters["@poExceptionReport"].Value = userObject.poExceptionReport;
                cmd.Parameters["@subcontractOrderExceptionReport"].Value = userObject.subcontractOrderExceptionReport;
                cmd.Parameters["@poManagementReport"].Value = userObject.poManagementReport;
                cmd.Parameters["@poManagementDetailReport"].Value = userObject.poManagementDetailReport;
                cmd.Parameters["@poForecastReport"].Value = userObject.poForecastReport;
                cmd.Parameters["@poDepartmentSalesReport"].Value = userObject.poDepartmentSalesReport;
                cmd.Parameters["@apValidation"].Value = userObject.apValidation;
                cmd.Parameters["@apDebitNote"].Value = userObject.apDebitNote;
                cmd.Parameters["@apCreditMemoRequest"].Value = userObject.apCreditMemoRequest;
                cmd.Parameters["@apDebitMemoRequest"].Value = userObject.apDebitMemoRequest;
                cmd.Parameters["@apNetSettlement"].Value = userObject.apNetSettlement;
                cmd.Parameters["@paymentResolution"].Value = userObject.paymentResolution;
                cmd.Parameters["@apPayment"].Value = userObject.apPayment;
                cmd.Parameters["@apReports"].Value = userObject.apReports;
                cmd.Parameters["@apAging"].Value = userObject.apAging;
                cmd.Parameters["@assembly"].Value = userObject.assembly;
                cmd.Parameters["@assemblyRecipt"].Value = userObject.assemblyRecipt;
                cmd.Parameters["@disassembly"].Value = userObject.disassembly;
                cmd.Parameters["@disassemblyReceipt"].Value = userObject.disassemblyReceipt;
                cmd.Parameters["@manufacturing"].Value = userObject.manufacturing;
                cmd.Parameters["@manufacturingReceipt"].Value = userObject.manufacturingReceipt;
                cmd.Parameters["@miscellaneousIssue"].Value = userObject.miscellaneousIssue;
                cmd.Parameters["@miscellaneousReceipt"].Value = userObject.miscellaneousReceipt;
                cmd.Parameters["@subcontractOrder"].Value = userObject.subcontractOrder;
                cmd.Parameters["@subcontractReceipt"].Value = userObject.subcontractReceipt;
                cmd.Parameters["@intersiteTransfer"].Value = userObject.intersiteTransfer;
                cmd.Parameters["@receiptReturn"].Value = userObject.receiptReturn;
                cmd.Parameters["@shipmentReturn"].Value = userObject.shipmentReturn;
                cmd.Parameters["@stockChange"].Value = userObject.stockChange;
                cmd.Parameters["@stockReports"].Value = userObject.stockReports;
                cmd.Parameters["@ipadShortageReport"].Value = userObject.ipadShortageReport;
                cmd.Parameters["@globalShortageReport"].Value = userObject.globalShortageReport;
                cmd.Parameters["@detailedShortageReport"].Value = userObject.detailedShortageReport;
                cmd.Parameters["@inventoryManagement"].Value = userObject.inventoryManagement;
                cmd.Parameters["@miscellaneousTransactionReport"].Value = userObject.miscellaneousTransactionReport;
                cmd.Parameters["@stockTransactionReport"].Value = userObject.stockTransactionReport;
                cmd.Parameters["@stockMovementReport"].Value = userObject.stockMovementReport;
                cmd.Parameters["@stockValuationReport"].Value = userObject.stockValuationReport;
                cmd.Parameters["@wmsGoodsReceipt"].Value = userObject.wmsGoodsReceipt;
                cmd.Parameters["@wmsStockStatusChange"].Value = userObject.wmsStockStatusChange;
                cmd.Parameters["@wmsShipmentReturn"].Value = userObject.wmsShipmentReturn;
                cmd.Parameters["@IntersiteTransferOrder"].Value = userObject.IntersiteTransferOrder;
                cmd.Parameters["@IntersiteTransferReceipt"].Value = userObject.IntersiteTransferReceipt;
                cmd.Parameters["@wmsCustomerDelivery"].Value = userObject.wmsCustomerDelivery;
                cmd.Parameters["@wmsReceiptReturn"].Value = userObject.wmsReceiptReturn;
                cmd.Parameters["@brandList"].Value = userObject.brandList;
                cmd.Parameters["@chartOfAccount"].Value = userObject.chartOfAccount;
                cmd.Parameters["@companyList"].Value = userObject.companyList;
                cmd.Parameters["@customerList"].Value = userObject.customerList;
                cmd.Parameters["@customerPriceEntry"].Value = userObject.customerPriceEntry;
                cmd.Parameters["@deliveryRoutePlanList"].Value = userObject.deliveryRoutePlanList;
                cmd.Parameters["@driverList"].Value = userObject.driverList;
                cmd.Parameters["@paymentTermList"].Value = userObject.paymentTermList;
                cmd.Parameters["@productList"].Value = userObject.productList;
                cmd.Parameters["@promotionScheduleTypeList"].Value = userObject.promotionScheduleTypeList;
                cmd.Parameters["@salesPersonList"].Value = userObject.salesPersonList;
                cmd.Parameters["@supplierList"].Value = userObject.supplierList;
                cmd.Parameters["@customerMap"].Value = userObject.customerMap;
                cmd.Parameters["@customerMapWeb"].Value = userObject.customerMapWeb;
                cmd.Parameters["@salesByCategoryMap"].Value = userObject.salesByCategoryMap;
                cmd.Parameters["@userMaintenance"].Value = userObject.userMaintenance;

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_UPDATE_UserPass(UserObject userObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_UserPass";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Password", SqlDbType.VarChar);
                

                cmd.Parameters["@UserID"].Value = userObject.UserID;
                cmd.Parameters["@Password"].Value = userObject.Password;

                
                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public string sp_INSERT_NewUser(UserObject userObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INSERT_NewUser";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@UserStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@Password", SqlDbType.VarChar);
                cmd.Parameters.Add("@FullName", SqlDbType.VarChar);
                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters.Add("@Department", SqlDbType.VarChar);
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@StartDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@EndDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@EmergencyContactName", SqlDbType.VarChar);
                cmd.Parameters.Add("@EmergencyContactNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Result", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@UserID"].Value = userObject.UserID;
                cmd.Parameters["@UserStatus"].Value = userObject.UserStatus;
                cmd.Parameters["@Password"].Value = userObject.Password;
                cmd.Parameters["@FullName"].Value = userObject.FullName;
                cmd.Parameters["@Email"].Value = userObject.Email;
                cmd.Parameters["@Department"].Value = userObject.Department;
                cmd.Parameters["@PhoneNumber"].Value = userObject.PhoneNumber;
                cmd.Parameters["@StartDate"].Value = userObject.StartDate;
                cmd.Parameters["@EndDate"].Value = userObject.EndDate;
                cmd.Parameters["@EmergencyContactName"].Value = userObject.EmergencyContactName;
                cmd.Parameters["@EmergencyContactNumber"].Value = userObject.EmergencyContactNumber;

                connection2.Open();
                cmd.ExecuteNonQuery();

                string Result = cmd.Parameters["@Result"].Value.ToString();
                return Result;

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public bool sp_Menu_AccessCheck(String UserID, String Menu)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_UserObject";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);

                cmd.Parameters["@UserID"].Value = UserID;

                connection2.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                bool acceess = false;
                if (sqlDataReader.Read())
                {
                    acceess = Convert.ToBoolean(sqlDataReader[Menu].ToString().Trim());
                }
                return acceess;
            }
            catch (SqlException exception)
            {
                return false;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_InventoryMiscellaneousTransactionReport(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, String Type)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_InventoryMiscellaneousTransactionReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Type", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@Type"].Value = Type;

                connection.Open();

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
                connection.Close();
            }
        }

        static public bool sp_CHECK_NewPaymentTerm(String PaymentTerm)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_NewPaymentTerm";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentTerm", SqlDbType.VarChar);

                cmd.Parameters["@PaymentTerm"].Value = PaymentTerm;

                connection2.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
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
                connection2.Close();
            }
        }

        static public void sp_INSERT_NewPaymentTerm(PaymentTermObject paymentTermObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_INSERT_NewPaymentTerm";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentTerm", SqlDbType.VarChar);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@DCPercentage", SqlDbType.Decimal);
                cmd.Parameters.Add("@DCDays", SqlDbType.Decimal);
                cmd.Parameters.Add("@NetDaysToPay", SqlDbType.Decimal);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);


                cmd.Parameters["@PaymentTerm"].Value = paymentTermObject.PaymentTerm;
                cmd.Parameters["@Description"].Value = paymentTermObject.Description;
                cmd.Parameters["@DCPercentage"].Value = paymentTermObject.DCPercentage;
                cmd.Parameters["@DCDays"].Value = paymentTermObject.DCDays;
                cmd.Parameters["@NetDaysToPay"].Value = paymentTermObject.NetDaysToPay;
                cmd.Parameters["@Status"].Value = paymentTermObject.Status;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public void sp_UPDATE_PaymentTermInfo(PaymentTermObject paymentTermObject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_PaymentTermInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentTerm", SqlDbType.VarChar);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@DCPercentage", SqlDbType.Decimal);
                cmd.Parameters.Add("@DCDays", SqlDbType.Decimal);
                cmd.Parameters.Add("@NetDaysToPay", SqlDbType.Decimal);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@PaymentTerm"].Value = paymentTermObject.PaymentTerm;
                cmd.Parameters["@Description"].Value = paymentTermObject.Description;
                cmd.Parameters["@DCPercentage"].Value = paymentTermObject.DCPercentage;
                cmd.Parameters["@DCDays"].Value = paymentTermObject.DCDays;
                cmd.Parameters["@NetDaysToPay"].Value = paymentTermObject.NetDaysToPay;
                cmd.Parameters["@Status"].Value = paymentTermObject.Status;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();

                //int output_OUT_TEMPNO = (int)cmd.Parameters["@OUT_TEMPNO"].Value;
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

        static public String sp_CHECK_OrderDetail2(String iPadOrderID, int OrderDetailCount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_OrderDetail2";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@iPadOrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderDetailCount", SqlDbType.Int);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@Result", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cmd.Parameters["@iPadOrderID"].Value = iPadOrderID;
                cmd.Parameters["@OrderDetailCount"].Value = OrderDetailCount;
                cmd.Parameters["@UserID"].Value = GATE.userID;

                connection2.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string Result = cmd.Parameters["@Result"].Value.ToString();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());
                    return Result;
                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());
                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_CHECK_AuditOrder(String iPadOrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_AuditOrder";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@iPadOrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@Result", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cmd.Parameters["@iPadOrderID"].Value = iPadOrderID;
                cmd.Parameters["@UserID"].Value = GATE.userID;

                connection2.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string Result = cmd.Parameters["@Result"].Value.ToString();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());
                    return Result;
                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());
                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_SUBCONTRACT_SELECT_RECDETAIL(DataGridView _dataGridView, String Number)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection4;
                cmd.CommandText = "dbo.sp_SUBCONTRACT_SELECT_RECDETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Number", SqlDbType.VarChar);
                //cmd.Parameters.Add("@StorageSite", SqlDbType.VarChar);

                cmd.Parameters["@Number"].Value = Number;
                //cmd.Parameters["@StorageSite"].Value = StorageSite;

                connection4.Open();

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
                connection4.Close();
            }
        }

        static public decimal getStockAvailableFromProductID(string ProductID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT SUM(QTYPCU_0 - CUMALLQTY_0) ";
                sql = sql + "FROM STOCK WITH(NOLOCK) ";
                sql = sql + "WHERE ITMREF_0 = '" + ProductID + "' AND STOFCY_0 = 'BCS' AND QTYPCU_0 - CUMALLQTY_0 >= 0 AND STA_0 = 'A'";
                sql = sql + "";

                connection3.Open();
                SqlCommand cmd = new SqlCommand(sql, connection3);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    decimal Available = Convert.ToDecimal(reader[0]);
                    return Available;
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                connection3.Close();
            }
        }

        static public String sp_Stock_Available_Check_ByProductID(String ProductID, Decimal ProductQty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Stock_Available_Check_ByProductID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Result", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@ProductQty"].Value = ProductQty;

                connection2.Open();

                cmd.ExecuteNonQuery();

                string Result = cmd.Parameters["@Result"].Value.ToString();

                return Result;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_GET_SubcontractOrderNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_SubcontractOrderNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    String Number = reader[0].ToString();
                    return Number;
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";

            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_GET_NewBCSSCNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_NewBCSSCNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewBCSSCNumber", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewBCSSCNumber = cmd.Parameters["@NewBCSSCNumber"].Value.ToString();

                if (return1 == 0)
                {
                    return NewBCSSCNumber;
                }
                else
                {
                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_SUBCONTRACT_SAVE(String NewBCSSCNumber, String CompanyCode, String Site, String ProductID, String LOT, String Status,
            Decimal Quantity, String Supplier, String Service, DateTime ExpirationDate, int Line)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_SUBCONTRACT_SAVE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewBCSSCNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOT", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@Quantity", SqlDbType.Decimal);
                cmd.Parameters.Add("@Supplier", SqlDbType.VarChar);
                cmd.Parameters.Add("@Service", SqlDbType.VarChar);
                cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewBCSSCNumber"].Value = NewBCSSCNumber;
                cmd.Parameters["@CompanyCode"].Value = CompanyCode;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@LOT"].Value = LOT;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@Quantity"].Value = Quantity;
                cmd.Parameters["@Supplier"].Value = Supplier;
                cmd.Parameters["@Service"].Value = Service;
                cmd.Parameters["@ExpirationDate"].Value = ExpirationDate;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_SUBCONTRACT_SAVE \nDetail : " + exception.Message.ToString();
                return ErrorText;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_SUBCONTRACT_SAVE_HEADER(String Number, String NewBCSSCNumber, String CompanyCode, String Site, String ProductID,
            Decimal Quantity, String Supplier, String Service, Decimal Lbs, Decimal FeeLbs, Decimal FeeTotal, String ReceiptProductID, Decimal ReceiptQuantity,
            Decimal TotalAmount, Decimal ReceiptBasePrice, String Memo, int Line)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_SUBCONTRACT_SAVE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Number", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewBCSSCNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Quantity", SqlDbType.Decimal);
                cmd.Parameters.Add("@Supplier", SqlDbType.VarChar);
                cmd.Parameters.Add("@Service", SqlDbType.VarChar);
                cmd.Parameters.Add("@Lbs", SqlDbType.Decimal);
                cmd.Parameters.Add("@FeeLbs", SqlDbType.Decimal);
                cmd.Parameters.Add("@FeeTotal", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReceiptProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceiptQuantity", SqlDbType.Decimal);
                cmd.Parameters.Add("@TotalAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReceiptBasePrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@Number"].Value = Number;
                cmd.Parameters["@NewBCSSCNumber"].Value = NewBCSSCNumber;
                cmd.Parameters["@CompanyCode"].Value = CompanyCode;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Quantity"].Value = Quantity;
                cmd.Parameters["@Supplier"].Value = Supplier;
                cmd.Parameters["@Service"].Value = Service;
                cmd.Parameters["@Lbs"].Value = Lbs;
                cmd.Parameters["@FeeLbs"].Value = FeeLbs;
                cmd.Parameters["@FeeTotal"].Value = FeeTotal;
                cmd.Parameters["@ReceiptProductID"].Value = ReceiptProductID;
                cmd.Parameters["@ReceiptQuantity"].Value = ReceiptQuantity;
                cmd.Parameters["@TotalAmount"].Value = TotalAmount;
                cmd.Parameters["@ReceiptBasePrice"].Value = ReceiptBasePrice;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_SUBCONTRACT_SAVE_HEADER \nDetail : " + exception.Message.ToString();
                return ErrorText;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_SUBCONTRACTRECEIPT_SELECT_TEMP(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_SUBCONTRACTRECEIPT_SELECT_TEMP";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@StorageSite", SqlDbType.VarChar);

                //cmd.Parameters["@ItemID"].Value = ItemID;
                //cmd.Parameters["@StorageSite"].Value = StorageSite;

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

        static public void sp_SUBCONTRACTRECEIPT_SELECT(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_SUBCONTRACTRECEIPT_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public String sp_SUBCONTRACTRECEIPT_SAVE(String CompanyCode, String Site, String BCSSCNumber,
            DateTime ExpirationDate, String NewRECNumber, String SupplierID, String Description)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_SUBCONTRACTRECEIPT_SAVE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@BCSSCNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ExpirationDate", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewRECNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@CompanyCode"].Value = CompanyCode;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@BCSSCNumber"].Value = BCSSCNumber;
                cmd.Parameters["@ExpirationDate"].Value = ExpirationDate;
                cmd.Parameters["@NewRECNumber"].Value = NewRECNumber;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@Description"].Value = Description;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : csp_SUBCONTRACTRECEIPT_SAVE \nDetail : " + exception.Message.ToString();
                return ErrorText;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_STOCKCHANGE_SELECT(DataGridView _dataGridView, DateTime FROMDATE, DateTime TODATE)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_STOCKCHANGE_SELECT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FROMDATE", SqlDbType.DateTime);
                cmd.Parameters.Add("@TODATE", SqlDbType.DateTime);

                cmd.Parameters["@FROMDATE"].Value = FROMDATE;
                cmd.Parameters["@TODATE"].Value = TODATE;

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

        static public String sp_GET_NewBCSCHGNumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_NewBCSCHGNumber";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewBCSCHGNumber", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewBCSCHGNumber = cmd.Parameters["@NewBCSCHGNumber"].Value.ToString();

                if (return1 == 0)
                {
                    return NewBCSCHGNumber;
                }
                else
                {
                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_STOCKCHANGE_SAVE_HEADER(String NewBCSCHGNumber, String CompanyCode, DateTime AccountingDate, String Description, String Site)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_STOCKCHANGE_SAVE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewBCSCHGNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewBCSCHGNumber"].Value = NewBCSCHGNumber;
                cmd.Parameters["@CompanyCode"].Value = CompanyCode;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@Description"].Value = Description;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_STOCKCHANGE_SAVE_HEADER \nDetail : " + exception.Message.ToString();

                return ErrorText;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public String sp_STOCKCHANGE_SAVE(String NewBCSCHGNumber, String ProductID, String LOTNumber, Decimal Qty, String Status, String DestStatus, int Line)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_STOCKCHANGE_SAVE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewBCSCHGNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@LOTNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@StockChangeQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@DestStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@NewBCSCHGNumber"].Value = NewBCSCHGNumber;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@LOTNumber"].Value = LOTNumber;
                cmd.Parameters["@StockChangeQty"].Value = Qty;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@DestStatus"].Value = DestStatus;
                cmd.Parameters["@Line"].Value = Line;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SqlException exception)
            {
                String ErrorText = "Something went wrong while processing your request. \nPlease contact your IT Team.\n\nError : sp_STOCKCHANGE_SAVE \nDetail : " + exception.Message.ToString();

                return ErrorText;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_SHIPMENTRETURN_SELECT_RETURN(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_SHIPMENTRETURN_SELECT_RETURN";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

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

        static public bool sp_CHECK_SRETURNID(String SRETURNID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_CHECK_SRETURNID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SRETURNID", SqlDbType.VarChar);

                cmd.Parameters["@SRETURNID"].Value = SRETURNID;

                connection.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
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

        static public String sp_Check_NewReturn(String DeliveryNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Check_NewReturn";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@DeliveryNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@RETURN", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                cmd.Parameters["@DeliveryNumber"].Value = DeliveryNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();

                String return1 = cmd.Parameters["@RETURN"].Value.ToString();
                return return1;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "error";

            }
            finally
            {
                connection.Close();
            }
        }

        static public String sp_CHECK_AuditOrderAmount(String iPadOrderID, Decimal AuditOrderAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CHECK_AuditOrderAmount";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@iPadOrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@AuditOrderAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@Result", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cmd.Parameters["@iPadOrderID"].Value = iPadOrderID;
                cmd.Parameters["@AuditOrderAmount"].Value = AuditOrderAmount;
                cmd.Parameters["@UserID"].Value = GATE.userID;

                connection2.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string Result = cmd.Parameters["@Result"].Value.ToString();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());
                    return Result;
                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());
                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_Commission_091521(DataGridView _dataGridView, String REP, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Commission_091521";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@REP", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@REP"].Value = REP;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public String sp_GET_NewWONumber()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_NewWONumber";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@CreateUserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@NewWONumber", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@CreateUserID"].Value = GATE.userID;

                connection2.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string NewWONumber = cmd.Parameters["@NewWONumber"].Value.ToString();

                if (return1 == 0)
                {
                    return NewWONumber;
                }
                else
                {
                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_WRITEOFF(string WONumber, string InvoiceNumber, Decimal WOAmount, DateTime AccountingDate, string CompanyName, string Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WRITEOFF";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@WONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@WOAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);

                cmd.Parameters["@WONumber"].Value = WONumber;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@WOAmount"].Value = WOAmount;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@CompanyName"].Value = CompanyName;
                cmd.Parameters["@UserID"].Value = GATE.userID;
                cmd.Parameters["@Memo"].Value = Memo;

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

        static public void sp_WRITEOFF_HISTORY(DataGridView _dataGridView, String CustomerID, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_WRITEOFF_HISTORY";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_ARBalanceAccountReport(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ARBalanceAccountReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_OverpaymentBalanceAccountReport(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_OverpaymentBalanceAccountReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public String sp_Check_DeliveryInvoice(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Check_DeliveryInvoice";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@return_value", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("@ReturnMessage", SqlDbType.VarChar, int.MaxValue).Direction = ParameterDirection.Output;

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection2.Open();

                cmd.ExecuteNonQuery();

                int return1 = (int)cmd.Parameters["@return_value"].Value;
                string ReturnMessage = cmd.Parameters["@ReturnMessage"].Value.ToString();

                if (return1 == 0)
                {
                    //MessageBox.Show("00return1:" + return1.ToString());
                    //MessageBox.Show("00dn:" + DeliveryNumber.ToString());

                    string ReturnMessageString = ReturnMessage;
                    return ReturnMessageString;
                }
                else
                {
                    //MessageBox.Show("return1:" + return1.ToString());
                    //MessageBox.Show("dn:" + DeliveryNumber.ToString());

                    return return1.ToString();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }
        static public void sp_GET_ShipState(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_ShipState";
                cmd.CommandType = CommandType.StoredProcedure;

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
        static public void sp_GET_ShipCity(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_ShipCity";
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();

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
                connection.Close();
            }
        }
        static public void sp_SalesbyCustomerDetailReport(DataGridView _dataGridView, String CustomerID, String CustomerName, DateTime FromDate, DateTime ToDate, String REP, String InvoiceNumber, String StateString, String CityString)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_SalesbyCustomerDetailReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerName", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@REP", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@StateString", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CityString", SqlDbType.NVarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@CustomerName"].Value = CustomerName;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@REP"].Value = REP;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@StateString"].Value = StateString;
                cmd.Parameters["@CityString"].Value = CityString;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_ARShortPaymentReport(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ARShortPaymentReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;

                connection.Open();

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
                connection.Close();
            }
        }

        static public void sp_PRECEIPT_ROWID_ERROR(String PONumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PRECEIPT_ROWID_ERROR";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@PONumber"].Value = PONumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                cmd.ExecuteNonQuery();
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

        static public void sp_UPDATE_CustomeriPadOrder(String Action, String CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_UPDATE_CustomeriPadOrder";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Action", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);

                cmd.Parameters["@Action"].Value = Action;
                cmd.Parameters["@CustomerID"].Value = CustomerID;

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

        static public String sp_ManualOrder_OCCUPIED_CHECK(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_OCCUPIED_CHECK";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderStatus", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@UserID"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();
                
                string OrderStatus = cmd.Parameters["@OrderStatus"].Value.ToString().Trim();
                return OrderStatus;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_ManualOrder_OCCUPIED_RELEASE(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_ManualOrder_OCCUPIED_RELEASE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@UserID"].Value = GATE.userID;

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

        static public void sp_ARValidation(String jsondata)
        {
            SqlConnection connectionasync2 = new SqlConnection(@"Data Source=192.168.1.46;Initial Catalog=CoreXDB;User ID=sa;Password=BcsKing3355!;Asynchronous Processing=True;MultipleActiveResultSets=True");
            try
            {
                Task.Run(() =>
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandTimeout = TimeoutTime;
                    cmd.Connection = connectionasync2;
                    cmd.CommandText = "dbo.sp_ARValidation";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@jsondata", SqlDbType.VarChar);

                    cmd.Parameters["@jsondata"].Value = jsondata;

                    connectionasync2.Open();
                    cmd.ExecuteNonQuery();
                    //cmd.BeginExecuteNonQuery();
                    connectionasync2.Close();
                });
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {

            }

        }

        static public void sp_CREATE_DeliveryNote(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CREATE_DeliveryNote";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;
                cmd.Parameters["@UserID"].Value = GATE.userID;

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

        static public void sp_Transaction_Detail_Report(DataGridView dgv, DateTime FromDate, DateTime ToDate, String CustomerID, String CustomerName, String InvoiceNo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_TRANSACTION_REPORT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerName", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNo", SqlDbType.VarChar);
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@CustomerName"].Value = CustomerName;
                cmd.Parameters["@InvoiceNo"].Value = InvoiceNo;
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable datatable = new DataTable();
                da.Fill(datatable);
                dgv.DataSource = datatable;

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

        static public DeliveryNoteObject sp_GET_DeliveryNote(String OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_DeliveryNote";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@OrderID", SqlDbType.VarChar);

                cmd.Parameters["@OrderID"].Value = OrderID;

                connection2.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                DeliveryNoteObject deliveryNoteObject = new DeliveryNoteObject();

                if (sqlDataReader.Read())
                {
                    deliveryNoteObject.OrderDate = Convert.ToDateTime(sqlDataReader["OrderDate"].ToString().Trim());
                    deliveryNoteObject.DeliveryDate = Convert.ToDateTime(sqlDataReader["DeliveryDate"].ToString().Trim());
                    deliveryNoteObject.CustomerID = sqlDataReader["CustomerID"].ToString().Trim();
                    deliveryNoteObject.ShipTo = sqlDataReader["ShipTo"].ToString().Trim();
                    deliveryNoteObject.BillTo = sqlDataReader["BillTo"].ToString().Trim();
                    deliveryNoteObject.RouteNumber = sqlDataReader["RouteNumber"].ToString().Trim();
                    deliveryNoteObject.RouteStop = sqlDataReader["RouteStop"].ToString().Trim();
                    deliveryNoteObject.Term = sqlDataReader["Term"].ToString().Trim();
                    deliveryNoteObject.SalesPerson = sqlDataReader["SalesPerson"].ToString().Trim();
                    deliveryNoteObject.SalesPersonMobile = sqlDataReader["SalesPersonMobile"].ToString().Trim();
                    deliveryNoteObject.CreditAmount = Convert.ToDecimal(sqlDataReader["CreditAmount"].ToString().Trim() ?? "0");
                    deliveryNoteObject.TotalBox = Convert.ToDecimal(sqlDataReader["TotalBox"].ToString().Trim() ?? "0");
                    deliveryNoteObject.ABox = Convert.ToDecimal(sqlDataReader["ABox"].ToString().Trim() ?? "0");
                    deliveryNoteObject.BBox = Convert.ToDecimal(sqlDataReader["BBox"].ToString().Trim() ?? "0");
                    deliveryNoteObject.CBox = Convert.ToDecimal(sqlDataReader["CBox"].ToString().Trim() ?? "0");
                    deliveryNoteObject.DBox = Convert.ToDecimal(sqlDataReader["DBox"].ToString().Trim() ?? "0");
                    deliveryNoteObject.EBox = Convert.ToDecimal(sqlDataReader["EBox"].ToString().Trim() ?? "0");
                    deliveryNoteObject.FBox = Convert.ToDecimal(sqlDataReader["FBox"].ToString().Trim() ?? "0");
                    deliveryNoteObject.ReturnAmount = Convert.ToDecimal(sqlDataReader["ReturnAmount"].ToString().Trim() ?? "0");
                    deliveryNoteObject.DeliveryNumber = sqlDataReader["DeliveryNumber"].ToString().Trim();
                    deliveryNoteObject.AR = Convert.ToDecimal(sqlDataReader["AR"].ToString().Trim() ?? "0");
                    deliveryNoteObject.TotalAmount = Convert.ToDecimal(sqlDataReader["TotalAmount"].ToString().Trim() ?? "0");

                }
                return deliveryNoteObject;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                DeliveryNoteObject deliveryNoteObject = new DeliveryNoteObject();
                return deliveryNoteObject;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_SalesPromotionReport(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, String REP)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_SalesPromotionReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@REP", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@REP"].Value = REP;

                connection.Open();

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
                connection.Close();
            }
        }

        static public String sp_POCalculator_OCCUPIED_CHECK(String RECNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_POCalculator_OCCUPIED_CHECK";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RECNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OccupiedStatus", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;

                cmd.Parameters["@RECNumber"].Value = RECNumber;
                cmd.Parameters["@UserID"].Value = GATE.userID;

                connection2.Open();
                cmd.ExecuteNonQuery();

                string OccupiedStatus = cmd.Parameters["@OccupiedStatus"].Value.ToString().Trim();
                return OccupiedStatus;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return "";
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void sp_POCalculator_OCCUPIED_RELEASE(String RECNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_POCalculator_OCCUPIED_RELEASE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RECNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar);

                cmd.Parameters["@RECNumber"].Value = RECNumber;
                cmd.Parameters["@UserID"].Value = GATE.userID;

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

        static public void sp_GoodsReceiptValueCalculation(DataGridView _dataGridView, String PONumber, String RECNumber)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GoodsReceiptValueCalculation";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@RECNumber", SqlDbType.VarChar);
                cmd.Parameters["@PONumber"].Value = PONumber;
                cmd.Parameters["@RECNumber"].Value = RECNumber;

                connection.Open();

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
                connection.Close();
            }
        }
    }
}
