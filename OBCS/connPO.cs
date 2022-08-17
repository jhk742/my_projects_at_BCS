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
    class connPO
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=JINKIM;Initial Catalog=CoreXDB;User ID=JINKIM;Password=JINKIM");
        public static SqlConnection connection2 = new SqlConnection(@"Data Source=JINKIM;Initial Catalog=CoreXDB;User ID=JINKIM;Password=JINKIM");
        public static SqlConnection connection3 = new SqlConnection(@"Data Source=JINKIM;Initial Catalog=CoreXDB;User ID=JINKIM;Password=JINKIM");
        public static SqlConnection connection4 = new SqlConnection(@"Data Source=JINKIM;Initial Catalog=CoreXDB;User ID=JINKIM;Password=JINKIM");
        public static int TimeoutTime = 480;

        static public bool getPOinfo(string PONo, TextBox POMemo)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT POMemo ";
                sql = sql + "FROM PO WHERE PONo = " + PONo + " ";
                sql = sql + "";

                connection.Open();
                //SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT OrdMemo FROM SalesOrderDetail WHERE OrderID = '" + OrderID + "'", connection);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string vPOMemo = reader[0].ToString();
                    POMemo.Text = vPOMemo.Trim();
                    //MessageBox.Show("OK");
                    return true;
                }
                else
                {
                    MessageBox.Show("-------");
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

        static public void SelectedPO(string PONo,
                                      Label POKey,
                                      ComboBox BillAddress,
                                      Label BillAddress2,
                                      Label BillCity,
                                      Label BillState,
                                      Label BillZip,
                                      Label BillTel,
                                      Label BillFax,
                                      ComboBox ShipAddress,
                                      Label ShipAddress2,
                                      Label ShipCity,
                                      Label ShipState,
                                      Label ShipZip,
                                      Label ShipTel,
                                      Label ShipFax,
                                      DateTimePicker OrderDate,
                                      TextBox ExpectedDevDate,
                                      ComboBox Term,
                                      ComboBox ShipVia,
                                      ComboBox ShipMethod,
                                      ComboBox Contact,
                                      ComboBox InventoryIO,
                                      TextBox POMemo,
                                      TextBox RecevingMemo,
                                      TextBox CfmUser,
                                      TextBox CfmVendor,
                                      ComboBox Branch,
                                      ComboBox Location,
                                      TextBox PalletNo,
                                      DateTimePicker RecevingDate,
                                      DateTimePicker OrderSubmitDate,
                                      CheckBox IsConfirmed,
                                      Label POStatus)
        {
            //BcsDBContext db = new BcsDBContext();
            //PO po = db.POs.Find();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_POVendor";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@POKey", SqlDbType.Int);
                cmd.Parameters.Add("@VendorParam", SqlDbType.VarChar);

                cmd.Parameters["@POKey"].Value = PONo;
                cmd.Parameters["@VendorParam"].Value = "";
                
                try
                {
                    //MessageBox.Show("try");
                    connection.Open();
                    SqlDataReader executeSP = cmd.ExecuteReader();

                    if (executeSP.Read())
                    {
                        //----------------------------------------------------------
                        //po.POKey = Convert.ToInt32(executeSP["POKey"]);
                        //MessageBox.Show("POKEY FROM connPO : " + po.POKey.ToString());
                        string vPONo;

                        string vBill;
                        string vShip;

                        string vTraderEntityKey;
                        DateTime vOrderDate;
                        string vExpectedDevDate;
                        string vTerm;
                        string vShipVia;
                        string vShipMethod;
                        string vContact;
                        string vInventoryIO;

                        string vPOMemo;
                        string vRecevingMemo;
                        string vCfmUser;
                        string vCfmVendor;
                        string vBranch;
                        string vLocation;
                        //string vPalletNo;
                        DateTime vRecevingDate;
                        DateTime vOrderSubmitDate;
                        bool vIsConfirmed;
                        string vPOStatus;
                        
                        //------------------------------------------------------
                        vPONo = executeSP["POKey"].ToString().Trim();

                        vBill = executeSP["BillAddrKey"].ToString().Trim();
                        vShip = executeSP["ShipAddrKey"].ToString().Trim();
                        
                        vTraderEntityKey = executeSP["TraderEntityKey"].ToString().Trim();
                        vOrderDate = Convert.ToDateTime(executeSP["OrderDate"].ToString().Trim());
                        vExpectedDevDate = executeSP["ExpectedDevDate"].ToString().Trim();
                        vTerm = executeSP["PaymentTermKey"].ToString().Trim();
                        vContact = executeSP["OrderContactKey"].ToString().Trim();
                        vInventoryIO = executeSP["CdInventoryIOCode"].ToString().Trim();
                        vShipVia = executeSP["CdShipViaCode"].ToString().Trim();
                        vShipMethod = executeSP["CtShipMethod"].ToString().Trim();

                        vPOMemo = executeSP["POMemo"].ToString().Trim();
                        vRecevingMemo = executeSP["RecevingMemo"].ToString().Trim();
                        vCfmUser = executeSP["ConfirmedUser"].ToString().Trim();
                        vCfmVendor = executeSP["ConfirmedVendor"].ToString().Trim();
                        vBranch = executeSP["CdBranchCode"].ToString().Trim();
                        vLocation = executeSP["CdLocation"].ToString().Trim();
                        //vPalletNo = executeSP["PalletGtCode"].ToString().Trim();

                        if (executeSP["RecevingDate"].ToString() == "")
                        {
                            vRecevingDate = Convert.ToDateTime("01-01-1900");
                        }
                        else
                        {
                            vRecevingDate = Convert.ToDateTime(executeSP["RecevingDate"].ToString().Trim());
                        }
                        
                        if (executeSP["OrderSubmitDate"].ToString() == "")
                        {
                            vOrderSubmitDate = Convert.ToDateTime("01-01-1900");
                        }
                        else
                        {
                            vOrderSubmitDate = Convert.ToDateTime(executeSP["OrderSubmitDate"].ToString());
                        }
                        vIsConfirmed = Convert.ToBoolean(executeSP["IsConfirmed"].ToString().Trim());
                        vPOStatus = executeSP["CtPOStatus"].ToString().Trim();
                        //---------------------------------------------------------
                        POKey.Text = vPONo;
                        
                        BillAddress.Text = connPO.getAddress(vBill, "Address");
                        BillAddress2.Text = connPO.getAddress(vBill, "Address2");

                        //BillCity.Text = connPO.getAddress(vBill, "City");
                        //BillState.Text = connPO.getAddress(vBill, "State");
                        //BillZip.Text = connPO.getAddress(vBill, "Zip");
                        string City, State, Zip;
                        City = connPO.getAddress(vBill, "City").Trim();
                        State = connPO.getAddress(vBill, "State").Trim();
                        Zip = connPO.getAddress(vBill, "Zip").Trim();
                        if (!City.Equals(""))
                        {
                            City = City + ", ";
                        }
                        if (!State.Equals(""))
                        {
                            State = State + " ";
                        }
                        BillCity.Text = City + State + Zip;

                        BillTel.Text = "Tel: " + connPO.getContact(vContact, "Tel");
                        BillFax.Text = "Fax: " + connPO.getContact(vContact, "Fax");

                        ShipAddress.Text = connPO.getAddress(vShip, "Address");
                        ShipAddress2.Text = connPO.getAddress(vShip, "Address2");

                        //ShipCity.Text = connPO.getAddress(vShip, "City");
                        //ShipState.Text = connPO.getAddress(vShip, "State");
                        //ShipZip.Text = connPO.getAddress(vShip, "Zip");
                        string shipCity, shipState, shipZip;
                        shipCity = connPO.getAddress(vShip, "City").Trim();
                        shipState = connPO.getAddress(vShip, "State").Trim();
                        shipZip = connPO.getAddress(vShip, "Zip").Trim();
                        if (!shipCity.Equals(""))
                        {
                            shipCity = shipCity + ", ";
                        }
                        if (!State.Equals(""))
                        {
                            shipState = shipState + " ";
                        }
                        ShipCity.Text = shipCity + shipState + shipZip;
                        
                        ShipTel.Text = "Tel: " + "718-392-3355";
                        ShipFax.Text = "Fax: " + "718-392-2072";

                        OrderDate.Value = vOrderDate;
                        ExpectedDevDate.Text = vExpectedDevDate;
                        Term.Text = connPO.getPaymentTerm(vTerm);
                        ShipVia.Text = connPO.getShipVia(vShipVia);
                        ShipMethod.Text = vShipMethod;
                        Contact.Text = connPO.getContact(vContact, "Name");
                        InventoryIO.Text = connPO.getInventoryIO(vInventoryIO);

                        POMemo.Text = vPOMemo;
                        RecevingMemo.Text = vRecevingMemo;

                        CfmUser.Text = vCfmUser;
                        CfmVendor.Text = vCfmVendor;
                        Branch.Text = connPO.getBranchName(vBranch);
                        Location.Text = connPO.getLocation(vLocation);
                        //PalletNo.Text = vPalletNo;
                        RecevingDate.Value = vRecevingDate;
                        OrderSubmitDate.Value = vOrderSubmitDate;
                        //OrderSubmitDate.Value = vOrderSubmitDate;
                        IsConfirmed.Checked = vIsConfirmed;
                        if(vPOStatus == "O")
                        {
                            vPOStatus = "Order";
                        }
                        else if (vPOStatus == "C")
                        {
                            vPOStatus = "Cancel";
                        }
                        else if (vPOStatus == "R")
                        {
                            vPOStatus = "Received";
                        }
                        POStatus.Text = vPOStatus;
                    }
                }
                catch //(SqlException exception)
                {
                    //MessageBox.Show("catch");
                }
                finally
                {
                    //MessageBox.Show("finally");
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

        static public void PODetails(DataGridView _dataGridView, string PONo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_PODetails";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@POKey", SqlDbType.Int);

                cmd.Parameters["@POKey"].Value = PONo;
                
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

        static public void LastPriceOfVendor(DataGridView _dataGridView, string ProductKey)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_ProductPOHistoryOfVendor";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@TraderEntityKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductKey", SqlDbType.VarChar);

                cmd.Parameters["@TraderEntityKey"].Value = "";
                cmd.Parameters["@ProductKey"].Value = ProductKey;

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

        static public string getPaymentTerm(string PaymentTermKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [PaymentTermKey] ";
                sql = sql + "      ,[TermName] ";
                sql = sql + "      ,[RegularTermDay] ";
                sql = sql + "      ,[DiscountTermDay] ";
                sql = sql + "      ,[DiscountRate] ";
                sql = sql + "FROM PaymentTerm ";
                sql = sql + "WHERE PaymentTermKey = '"+ PaymentTermKey + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string TermName = reader[1].ToString();
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

        static public string getPaymentTerm2(string PONumber)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT PTE_0 ";
                sql = sql + "FROM PORDER ";
                sql = sql + "WHERE POHNUM_0 = '" + PONumber + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
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

        static public string getShipVia(string CdShipViaCode)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT ShipViaName ";
                sql = sql + "FROM CdShipVia ";
                sql = sql + "WHERE CdShipViaCode = '" + CdShipViaCode + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string ShipViaName = reader[0].ToString();
                    return ShipViaName;
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

        static public string getProductKey(string ProductID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT ProductKey ";
                sql = sql + "FROM Product ";
                sql = sql + "WHERE ProductID = '" + ProductID + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
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

        static public string getOnhandFromProductID(string ProductID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT QtyOnHand ";
                sql = sql + "FROM Product ";
                sql = sql + "WHERE ProductID = '" + ProductID + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
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

        static public string getPaymentTermKeyFromVendorTraderEntityKey(string TraderEntityKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT[PaymentTermKey ";
                sql = sql + "FROM Vendor ";
                sql = sql + "WHERE TraderEntityKey = '" + TraderEntityKey + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string PaymentTermKey = reader[0].ToString();
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

        static public string getContact(string ContactKey, string set)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [FirstName], [LastName], [Tel1], [Fax] ";
                sql = sql + "FROM TraderEntityContact ";
                sql = sql + "WHERE ContactKey = '" + ContactKey + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    if (set == "Name")
                    {
                        string FirstName = reader[0].ToString();
                        //string LastName = reader[1].ToString();
                        //string FullName = FirstName + " " + LastName;
                        return FirstName;
                    }
                    else if (set == "Tel")
                    {
                        string Tel = reader[2].ToString();
                        return Tel;
                    }
                    else if (set == "Fax")
                    {
                        string Fax = reader[3].ToString();
                        return Fax;
                    }
                    else
                    {
                        return "";
                    }
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
        
        static public string getInventoryIO(string CodeID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [CodeName] ";
                sql = sql + "FROM Code ";
                sql = sql + "WHERE CodeID = '" + CodeID + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CodeName = reader[0].ToString();
                    return CodeName;
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

        static public string getAddress(string AddressKey, string set)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT AddrLine1, AddrLine2, CityName, StateCode, PostalCode, Country ";
                sql = sql + "FROM TraderEntityAddress ";
                sql = sql + "WHERE AddressKey = '" + AddressKey + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string AddrLine1 = reader[0].ToString();
                    string AddrLine2 = reader[1].ToString();
                    string CityName = reader[2].ToString();
                    string StateCode = reader[3].ToString();
                    string PostalCode = reader[4].ToString();

                    if(set == "Address")
                    {
                        return AddrLine1;
                    }
                    else if(set == "Address2")
                    {
                        return AddrLine2;
                    }
                    else if (set == "City")
                    {
                        return CityName;
                    }
                    else if (set == "State")
                    {
                        return StateCode;
                    }
                    else if (set == "Zip")
                    {
                        return PostalCode;
                    }
                    else
                    {
                        return "";
                    }
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

        static public void cbox_billAddress(ComboBox cbox_billAddress, string traderEntityKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [AddrLine1] ";
                sql = sql + "FROM TraderEntityAddress ";
                sql = sql + "WHERE TraderEntityKey = '" + traderEntityKey + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbox_billAddress.Items.Add(reader[0].ToString().Trim());
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

        static public void sp_PORDER_SelectionHeader(TreeView treeView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PORDER_SelectionHeader";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                //cmd.Parameters.Add("@POPrepareNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                

                //cmd.Parameters["@SupplierID"].Value = SupplierID;
                //cmd.Parameters["@Memo"].Value = Memo;
                //cmd.Parameters["@POPrepareNumber"].Value = POPrepareNumber;
                //cmd.Parameters["@CreateUser"].Value = GATE.userID;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    String PORDERNumber = reader[0].ToString().Trim();
                    DateTime PORDERDate = Convert.ToDateTime(reader[1].ToString().Trim());
                    String SupplierID = reader[2].ToString().Trim();
                    String Header = PORDERNumber + " " + PORDERDate.ToShortDateString() + " " + SupplierID;
                    treeView.Nodes.Add(Header);
                    //treeView.Nodes[i].Nodes.Add(" ");

                    //sp_PORDER_SelectionDetail(treeView);

                    i = i + 1;
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

        static public void sp_PORDER_SelectionDetail(TreeView treeView, int NodeIndex, String SelectedPORDERNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PORDER_SelectionDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PORDERNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                //cmd.Parameters.Add("@POPrepareNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@PORDERNumber"].Value = SelectedPORDERNumber;
                //cmd.Parameters["@Memo"].Value = Memo;
                //cmd.Parameters["@POPrepareNumber"].Value = POPrepareNumber;
                //cmd.Parameters["@CreateUser"].Value = GATE.userID;
                
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String PORDERNumber = reader[0].ToString().Trim();
                    String ItemID = reader[1].ToString().Trim();
                    Decimal OrderQty = Convert.ToDecimal(reader[2].ToString().Trim());
                    String Detail = ItemID + " " + OrderQty.ToString("N2");
                    treeView.Nodes[NodeIndex].Nodes.Add(Detail);
                    //treeView.Nodes.Add(Detail, "PO000011 10/28/2018 POPCHIPS");
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

        static public void cbo_contact(ComboBox cbo_contact, string TraderEntityKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT FirstName, LastName ";
                sql = sql + "FROM TraderEntityContact ";
                sql = sql + "WHERE TraderEntityKey = '" + TraderEntityKey + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string firstname = reader[0].ToString().Trim();
                    //string lastname = reader[1].ToString().Trim();
                    //string fullname = firstname + " " + lastname;
                    cbo_contact.Items.Add(firstname);
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

        static public void cbo_location(ComboBox cbo_location)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [CdLocation],[LocationDesc] ";
                sql = sql + "FROM CdLocationCd ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    cbo_location.Items.Add(reader[1].ToString().Trim());
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
                sql = sql + "SELECT [CdBranchCode],[BranchName] ";
                sql = sql + "FROM CdBranch ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_branch.Items.Add(reader[1].ToString().Trim());
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

        static public void getAddressFromTraderEntityKey(string AddrLine1, Label address2, Label city)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT AddrLine2, CityName, StateCode, PostalCode, Country ";
                sql = sql + "FROM TraderEntityAddress ";
                sql = sql + "WHERE AddrLine1 = '" + AddrLine1 + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string AddrLine2 = reader[0].ToString().Trim();
                    string CityName = reader[1].ToString().Trim();
                    string StateCode = reader[2].ToString().Trim();
                    string PostalCode = reader[3].ToString().Trim();

                    if (!CityName.Equals(""))
                    {
                        CityName = CityName + ", ";
                    }
                    if (!StateCode.Equals(""))
                    {
                        StateCode = StateCode + " ";
                    }
                    city.Text = CityName + StateCode + PostalCode;
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

        static public void getShipAddressFromAddrLine1(string AddrLine1, Label address2, Label city)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT AddrLine2, CityName, StateCode, PostalCode, Country ";
                sql = sql + "FROM TraderEntityAddress ";
                sql = sql + "WHERE TraderEntityKey = 90 AND AddrLine1 = '" + AddrLine1 + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    string AddrLine2 = reader[0].ToString().Trim();
                    string CityName = reader[1].ToString().Trim();
                    string StateCode = reader[2].ToString().Trim();
                    string PostalCode = reader[3].ToString().Trim();

                    if (!CityName.Equals(""))
                    {
                        CityName = CityName + ", ";
                    }
                    if (!StateCode.Equals(""))
                    {
                        StateCode = StateCode + " ";
                    }
                    city.Text = CityName + StateCode + PostalCode;
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
        
        static public string getTelFax(string ContactKey, string set)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [FirstName], [LastName], [Tel1], [Fax] ";
                sql = sql + "FROM TraderEntityContact ";
                sql = sql + "WHERE ContactKey = '" + ContactKey + "'";
                sql = sql + "";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string AddrLine1 = reader[0].ToString();
                    string AddrLine2 = reader[1].ToString();
                    string CityName = reader[2].ToString();
                    string StateCode = reader[3].ToString();
                    string PostalCode = reader[4].ToString();

                    if (set == "Address")
                    {
                        return AddrLine1;
                    }
                    else if (set == "Address2")
                    {
                        return AddrLine2;
                    }
                    else if (set == "City")
                    {
                        return CityName;
                    }
                    else if (set == "State")
                    {
                        return StateCode;
                    }
                    else if (set == "Zip")
                    {
                        return PostalCode;
                    }
                    else
                    {
                        return "";
                    }
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

        static public void getTelFaxFromContact(string Contact, Label lbl_billTel, Label lbl_billFax)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [Tel1], [Fax] ";
                sql = sql + "FROM TraderEntityContact ";
                sql = sql + "WHERE (LTRIM(RTRIM(firstname))) = '" + Contact + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Tel = reader[0].ToString();
                    string Fax = reader[1].ToString();
                    lbl_billTel.Text = "Tel : " + Tel;
                    lbl_billFax.Text = "Fax : " + Fax;
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
        
        static public void POPrepare(DataGridView _dataGridView, string Vendor, string Brand, string Branch, DateTime ToDay, string Category)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_POPrepare";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@TraderEntityKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@BrandKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                cmd.Parameters.Add("@ToDay", SqlDbType.VarChar);
                cmd.Parameters.Add("@CategoryKey", SqlDbType.VarChar);

                cmd.Parameters["@TraderEntityKey"].Value = connPO.getVendorTraderEntityKey(Vendor).Trim();
                cmd.Parameters["@BrandKey"].Value = connPO.getBrandKey(Brand);
                cmd.Parameters["@Branch"].Value = connPO.getBranchCode(Vendor);
                cmd.Parameters["@ToDay"].Value = ToDay.ToString("yyyyMMdd");
                if(Category.Equals("ALL"))
                {
                    cmd.Parameters["@CategoryKey"].Value = -1;
                }
                else
                {
                    cmd.Parameters["@CategoryKey"].Value = connPO.getCategoryKey(Category);
                }
                
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

        static public void POPrepare2(DataGridView _dataGridView, string BrandCode, string Supplier, string Category)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_POPrepare2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Supplier", SqlDbType.VarChar);
                cmd.Parameters.Add("@Category", SqlDbType.VarChar);

                cmd.Parameters["@BrandCode"].Value = BrandCode;
                cmd.Parameters["@Supplier"].Value = Supplier;
                cmd.Parameters["@Category"].Value = Category;
                
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

        static public string getVendorTraderEntityKey(string VendorID)
        {
            try
            {
                VendorID = VendorID.Replace("'", "''");
                string sql = "";
                sql = sql + "SELECT [TraderEntityKey] ";
                sql = sql + "FROM [Vendor] ";
                sql = sql + "WHERE VendorID = '" + VendorID + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string VendorTraderEntityKey = reader[0].ToString();
                    return VendorTraderEntityKey;
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

        static public string getVendorTraderEntityKeyFromVendorID(string VendorID)
        {
            try
            {
                VendorID = VendorID.Replace("'", "''");
                string sql = "";
                sql = sql + "SELECT [TraderEntityKey] ";
                sql = sql + "FROM [Vendor] ";
                sql = sql + "WHERE VendorID = '" + VendorID + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string VendorTraderEntityKey = reader[0].ToString();
                    return VendorTraderEntityKey;
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

        static public string getBrandKey(string BrandName)
        {
            try
            {
                //BrandName.Replace("'", "''");
                BrandName = BrandName.Replace("'", "''");

                string sql = "";
                sql = sql + "SELECT [BrandKey] ";
                sql = sql + "FROM [ProductBrand] ";
                sql = sql + "WHERE BrandName = '" + BrandName + "'";
                sql = sql + "";

                connection3.Open();
                SqlCommand cmd = new SqlCommand(sql, connection3);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string BrandKey = reader[0].ToString();
                    return BrandKey;
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

        static public string getBranchCode(string VendorID)
        {
            try
            {
                VendorID = VendorID.Replace("'", "''");
                string sql = "";
                sql = sql + "SELECT [CdBranchCode] ";
                sql = sql + "FROM [Vendor] ";
                sql = sql + "WHERE VendorID = '" + VendorID + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string BranchCode = reader[0].ToString();
                    return BranchCode;
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

        static public string getCategoryKey(string Category)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [CategoryKey] ";
                sql = sql + "FROM [ProductCategory] ";
                sql = sql + "WHERE CategoryName = '" + Category + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CategoryKey = reader[0].ToString();
                    return CategoryKey;
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

        static public void cbox_getBrnad(ComboBox cbo_brand)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [BrandName] ";
                sql = sql + "FROM [ProductBrand] ";
                sql = sql + "where IsInactive = 0 ";
                sql = sql + "Order by BrandName ";
                //sql = sql + "WHERE BrandName = '" + cbo_brand + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_brand.Items.Add(reader[0].ToString().Trim());
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

        

        static public string getBranchName(String BranchCode)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [BranchName] ";
                sql = sql + "FROM [CdBranch] ";
                sql = sql + "WHERE CdBranchCode = '" + BranchCode + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string brandName = reader[0].ToString().Trim();
                    return brandName;
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

        static public void cbox_getVendorID(ComboBox cbo_vendorID)
        {
            try
            {
                string sql = "";
                //sql = sql + "SELECT VendorID ";
                //sql = sql + "FROM Vendor ";
                //sql = sql + "Order by VendorID";
                //sql = sql + "";
                sql = sql + "SELECT BPSNUM_0 ";
                sql = sql + "FROM BPSUPPLIER with(nolock) ";
                sql = sql + "WHERE ENAFLG_0 = 2 ";
                sql = sql + "Order by BPSNUM_0";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_vendorID.Items.Add(reader[0].ToString().Trim());
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

        static public void cbox_getCustomerID(ComboBox cbo_customer)
        {
            try
            {
                //string sql = "";
                //sql = sql + "SELECT CustomerID ";
                //sql = sql + "FROM Customer ";
                //sql = sql + "Order by CustomerID ";
                //sql = sql + "";

                string sql = "";
                sql = sql + "SELECT BPCNUM_0 ";
                sql = sql + "FROM BPCUSTOMER WITH(NOLOCK) ";
                sql = sql + "WHERE DEP_0 != 'INV' ";
                sql = sql + "Order by BPCNUM_0 ";

                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_customer.Items.Add(reader[0].ToString().Trim());
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

        static public void cbo_getCompanyID(ComboBox cbo_company)
        {
            try
            {
                string sql = "";
                sql = sql + "select CompanyCode ";
                sql = sql + "from COMPANY WITH(NOLOCK) ";
                sql = sql + "order by CompanyCode ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_company.Items.Add(reader[0].ToString().Trim());
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

        static public string getCompanyNamebyCompanyID(String CompanyID)
        {
            try
            {
                string sql = "";
                sql = sql + "select CompanyName  ";
                sql = sql + "from COMPANY WITH(NOLOCK) ";
                sql = sql + "where CompanyCode = '" + CompanyID + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
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
                connection2.Close();
            }
        }

        static public string getCustomerNamebyCustomerID(String CustomerID)
        {
            try
            {
                string sql = "";
                sql = sql + "select BPCNAM_0  ";
                sql = sql + "from BPCUSTOMER WITH(NOLOCK) ";
                sql = sql + "where BPCNUM_0 = '" + CustomerID + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CustomerName = reader[0].ToString();
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

        static public void cbox_getDeliveryNumberByCustomerID(ComboBox cbo_customerID, ComboBox cbo_deliveryNumber)
        {
            try
            {
                //string sql = "";
                //sql = sql + "SELECT CustomerID ";
                //sql = sql + "FROM Customer ";
                //sql = sql + "Order by CustomerID ";
                //sql = sql + "";

                string sql = "";
                sql = sql + "SELECT DeliveryNumber ";
                sql = sql + "FROM Delivery WITH(NOLOCK) ";
                sql = sql + "WHERE CustomerID = '" + cbo_customerID.Text.Trim() + "'"; 
                sql = sql + " AND OrderStatus = 'DeliveryInvoice'  "; 
                sql = sql + "Order by id desc ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_deliveryNumber.Items.Add(reader[0].ToString().Trim());
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

        static public void cbox_getAllDeliveryNumberByCustomerID(ComboBox cbo_customerID, ComboBox cbo_deliveryNumber)
        {
            try
            {
                //string sql = "";
                //sql = sql + "SELECT CustomerID ";
                //sql = sql + "FROM Customer ";
                //sql = sql + "Order by CustomerID ";
                //sql = sql + "";

                string sql = "";
                sql = sql + "SELECT DeliveryNumber ";
                sql = sql + "FROM Delivery WITH(NOLOCK) ";
                sql = sql + "WHERE CustomerID = '" + cbo_customerID.Text.Trim() + "' ";
                //sql = sql + " AND OrderStatus = 'DeliveryInvoice'  ";
                sql = sql + "Order by id desc ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_deliveryNumber.Items.Add(reader[0].ToString().Trim());
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

        static public void cbo_CompanyName(ComboBox cbo_CompanyName)
        {
            try
            {
                //string sql = "";
                //sql = sql + "SELECT CustomerID ";
                //sql = sql + "FROM Customer ";
                //sql = sql + "Order by CustomerID ";
                //sql = sql + "";

                string sql = "";
                sql = sql + "SELECT CompanyName ";
                sql = sql + "FROM COMPANY WITH(NOLOCK) ";
                sql = sql + "Where CompanyStatus = 'Active' ";
                sql = sql + "Order by CompanyName ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_CompanyName.Items.Add(reader[0].ToString().Trim());
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

        static public void cbo_term(ComboBox cbo_term)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [PTE_0] ";
                sql = sql + "FROM [TABPAYTERM] ";
                //sql = sql + "WHERE BrandName = '" + cbo_brand + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_term.Items.Add(reader[0].ToString().Trim());
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

        static public void cbo_shipAddress(ComboBox cbo_shipAddress)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [AddrLine1] ";
                sql = sql + "FROM [TraderEntityAddress] ";
                sql = sql + "WHERE TraderEntityKey = 90 ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_shipAddress.Items.Add(reader[0].ToString().Trim());
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

        static public void cbo_shipVia(ComboBox cbo_shipVia)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [CdShipViaCode],[CdGroupCode],[ShipViaName] ";
                sql = sql + "FROM [CdShipVia] ";
                //sql = sql + "WHERE BrandName = '" + cbo_brand + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_shipVia.Items.Add(reader[2].ToString().Trim());
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

        static public string getVendorNameFromVendorID(String vendorID)
        {
            try
            {
                vendorID = vendorID.Replace("'", "''");
                string sql = "";
                sql = sql + "SELECT [VendorName] ";
                sql = sql + "FROM [Vendor] ";
                sql = sql + "WHERE VendorID = '" + vendorID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string VendorName = reader[0].ToString();
                    return VendorName;
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

        static public string getVendorNameFromTraderEntityKey(String TraderEntityKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [VendorName] ";
                sql = sql + "FROM [Vendor] ";
                sql = sql + "WHERE TraderEntityKey = '" + TraderEntityKey + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string VendorName = reader[0].ToString();
                    return VendorName;
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

        static public string getTraderEntityKeyFromPO(String POKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [TraderEntityKey] ";
                sql = sql + "FROM [PO] ";
                sql = sql + "WHERE POKey = '" + POKey + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string TraderEntityKey = reader[0].ToString();
                    return TraderEntityKey;
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

        static public string getBrandMemo(string BrandKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [BrandMemo] ";
                sql = sql + "FROM [ProductBrand] ";
                sql = sql + "WHERE BrandKey = '" + BrandKey + "'";
                sql = sql + "";

                connection3.Open();
                SqlCommand cmd = new SqlCommand(sql, connection3);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string BrandMemo = reader[0].ToString().Trim();
                    return BrandMemo;
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

        static public void UpdateBrandMemo(String BrandKey, String Memo)
        {
            try
            {
                string sql = "";
                sql = sql + "UPDATE [ProductBrand] ";
                sql = sql + "SET BrandMemo = '" + Memo + "' ";
                sql = sql + "WHERE BrandKey = '" + BrandKey + "' ";

                connection2.Open();
                SqlCommand UpdateCommand = new SqlCommand(sql, connection2);
                UpdateCommand.ExecuteNonQuery();
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

        static public void cbox_getCategory(ComboBox cbo_category)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [CategoryKey] ,[CategoryName] ";
                sql = sql + "FROM [ProductCategory] ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_category.Items.Add(reader[1].ToString().Trim());
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

        static public void getBrandVender(ComboBox cbo_vendor, string BrandKey)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Fetch_BrandVendor";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandKey", SqlDbType.VarChar);
                
                cmd.Parameters["@BrandKey"].Value = BrandKey;
                
                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    cbo_vendor.Items.Add(reader[1].ToString().Trim());
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

        static public void sp_GET_Brand(ComboBox cbo_brand)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_Brand";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@BrandKey", SqlDbType.VarChar);

                //cmd.Parameters["@BrandKey"].Value = BrandKey;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_brand.Items.Add(reader[0].ToString().Trim());
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

        static public void sp_GET_SUPPLIER(ComboBox cbo_supplier)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_SUPPLIER";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@BrandKey", SqlDbType.VarChar);

                //cmd.Parameters["@BrandKey"].Value = BrandKey;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_supplier.Items.Add(reader[0].ToString().Trim());
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

        static public void sp_Brands_Supplier(ComboBox cbo_supplier, String BrandName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_Brands_Supplier";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandName", SqlDbType.VarChar);

                cmd.Parameters["@BrandName"].Value = BrandName;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_supplier.Items.Add(reader[0].ToString().Trim());
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

        static public void sp_GET_BrandCode(ComboBox cbo_supplier, String BrandName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_BrandCode";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandName", SqlDbType.VarChar);

                cmd.Parameters["@BrandName"].Value = BrandName;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_supplier.Items.Add(reader[0].ToString().Trim());
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

        static public string getShipViaWithShipViaKey(string VendorTraderEntityKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [CdShipViaCode] ";
                sql = sql + "FROM [Vendor] ";
                sql = sql + "WHERE TraderEntityKey = '" + VendorTraderEntityKey + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                string ShipVia;
                if (reader.Read())
                {
                    string ShipViaKey = reader[0].ToString();
                    //MessageBox.Show(ShipViaKey);
                    if (ShipViaKey.Equals("400"))
                    {
                        ShipVia = "N/A";
                    }
                    else if (ShipViaKey.Equals("401"))
                    {
                        ShipVia = "Our Truck";
                    }
                    else if (ShipViaKey.Equals("402"))
                    {
                        ShipVia = "Customer Truck";
                    }
                    else if (ShipViaKey.Equals("403"))
                    {
                        ShipVia = "Vendor Truck";
                    }
                    else if (ShipViaKey.Equals("404"))
                    {
                        ShipVia = "Third Party Pick Up";
                    }
                    else if (ShipViaKey.Equals("405"))
                    {
                        ShipVia = "UPS";
                    }
                    else if (ShipViaKey.Equals("406"))
                    {
                        ShipVia = "Pick Up";
                    }
                    else if (ShipViaKey.Equals("407"))
                    {
                        ShipVia = "Delivery";
                    }
                    else if (ShipViaKey.Equals("408"))
                    {
                        ShipVia = "C&F NY";
                    }
                    else
                    {
                        ShipVia = "";
                    }
                    return ShipVia;
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

        static public void SavePOPrepare(String ProductID, double QtyReplenish)
        {
            try
            {
                string sql = "";
                sql = sql + "UPDATE [Product] ";
                sql = sql + "SET QtyReplenish = " + QtyReplenish + " ";
                sql = sql + "WHERE ProductID = '"+ ProductID +"' ";
                
                connection2.Open();
                SqlCommand UpdateCommand = new SqlCommand(sql, connection2);
                UpdateCommand.ExecuteNonQuery();

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

        static public void getPOOrderQty(DataGridView _dataGridView, string ProductKey, string FromDate, string ToDate)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_OrderQty";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductKey", SqlDbType.VarChar);
                cmd.Parameters.Add("@From", SqlDbType.VarChar);
                cmd.Parameters.Add("@To", SqlDbType.VarChar);

                cmd.Parameters["@ProductKey"].Value = ProductKey;
                cmd.Parameters["@From"].Value = FromDate;
                cmd.Parameters["@To"].Value = ToDate;

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

        static public void getSaleDailyReportByBranchAndSalesMan(DataGridView _dataGridView, string ProductKey, string FromDate, string ToDate)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_Daily_SalesForPOPrepare";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@FromDate", SqlDbType.VarChar);
                cmd.Parameters.Add("@ToDate", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductKey", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@ProductKey"].Value = ProductKey;

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

        static public void cbox_PO(ComboBox cbo_PO, String TraderEntityKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [POKey] ";
                sql = sql + "FROM [PO] ";
                sql = sql + "WHERE TraderEntityKey = '" + TraderEntityKey + "' ";
                sql = sql + "order by OrderDate desc ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_PO.Items.Add(reader[0].ToString().Trim());
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

        static public void cbox_BPSaleRep(ComboBox cbo_BPSaleRep)
        {
            try
            {
                string sql = "";
                sql = sql + "select REPNUM_0 ";
                sql = sql + "from SALESREP WITH(NOLOCK) ";
                sql = sql + "order by REPNUM_0 ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_BPSaleRep.Items.Add(reader[0].ToString().Trim());
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

        static public void cbox_POVendor(ComboBox cbox_POVendor, string VendorName)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [VendorName] ";
                sql = sql + "FROM [Vendor] ";
                sql = sql + "where VendorName like '" + VendorName + "%'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbox_POVendor.Items.Add(reader[0].ToString().Trim());
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

        static public void grid_salesOrderItems_All(DataGridView _dataGridView, String VendorTraderEntityKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT A.ProductID, B.POItemID AS POCode, 1.00 AS OrderQty, A.ProductDesc, A.StrPackSize AS PackSize, B.PoUnitPr AS ListPrice, 'P' AS DK1, 0 AS DcRate1, 'M' AS DK2, 0 AS DcRate2, CsInner AS InCase  ";
                sql = sql + "FROM [Product] A ";
                sql = sql + "LEFT OUTER JOIN [VendorProduct] B ON A.ProductKey = B.ProductKey AND B.TraderEntityKey = '" + VendorTraderEntityKey + "' ";
                sql = sql + "WHERE IsInActive = 0 AND A.TraderEntityKey = '" + VendorTraderEntityKey + "' ";

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

        static public void grid_salesOrderItems_Replenish(DataGridView _dataGridView, String VendorTraderEntityKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT A.ProductID, B.POItemID AS POCode, A.QtyReplenish AS OrderQty, A.ProductDesc, A.StrPackSize AS PackSize, B.PoUnitPr AS ListPrice, 'P' AS DK1, 0 AS DcRate1, 'M' AS DK2, 0 AS DcRate2, CsInner AS InCase  ";
                sql = sql + "FROM [Product] A ";
                sql = sql + "LEFT OUTER JOIN [VendorProduct] B ON A.ProductKey = B.ProductKey AND B.TraderEntityKey = '" + VendorTraderEntityKey + "' ";
                sql = sql + "WHERE IsInActive = 0 AND A.TraderEntityKey = '" + VendorTraderEntityKey + "' AND QtyReplenish != 0 ";

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

        static public void SavePO
            (String CdBranchCode, int PONo, String CdInventoryIOCode, String CtPOTypeCode, String CdLocation,
             String TraderEntityKey, String CdShipViaCode, String CtShipMethod, String PaymentTermKey, String VendorBrokerKey,
             String OrderContactKey, String CtPOStatus, String OrderDate, String OrderSubmitDate, String ExpectedDevDate,
             String RecevingDate, String IsConfirmed, String ConfirmedUser, String ConfirmedVendor, String POMemo,
             String RecevingMemo, String BillAddrKey, String ShipAddrKey, String AddDate, String AddUser,
             String PalletGtCode)
        {
            try
            {
                string sql = "";
                sql = sql + "insert into [PO] ";
                sql = sql + "( ";
                sql = sql + "[CdBranchCode],[PONo],[CdInventoryIOCode],[CtPOTypeCode],[CdLocation], ";
                sql = sql + "[TraderEntityKey],[CdShipViaCode],[CtShipMethod],[PaymentTermKey],[VendorBrokerKey], ";
                sql = sql + "[OrderContactKey],[CtPOStatus],[OrderDate],[OrderSubmitDate],[ExpectedDevDate], ";
                sql = sql + "[RecevingDate],[IsConfirmed],[ConfirmedUser],[ConfirmedVendor],[POMemo], ";
                sql = sql + "[RecevingMemo],[BillAddrKey],[ShipAddrKey],[AddDate],[AddUser], ";
                sql = sql + "[PalletGtCode] ";
                sql = sql + ") ";
                sql = sql + "Values ";
                sql = sql + "('" + CdBranchCode + "','" + PONo + "','" + CdInventoryIOCode + "','" + CtPOTypeCode + "','" + CdLocation + "', ";
                sql = sql + " '" + TraderEntityKey + "','" + CdShipViaCode + "','" + CtShipMethod + "','" + PaymentTermKey + "','" + VendorBrokerKey + "', ";
                sql = sql + " '" + OrderContactKey + "','" + CtPOStatus + "','" + OrderDate + "','" + OrderSubmitDate + "','" + ExpectedDevDate + "', ";
                sql = sql + " '" + RecevingDate + "','" + IsConfirmed + "','" + ConfirmedUser + "','" + ConfirmedVendor + "','" + POMemo + "', ";
                sql = sql + " '" + RecevingMemo + "','" + BillAddrKey + "','" + ShipAddrKey + "','" + AddDate + "','" + AddUser + "', ";
                sql = sql + " '" + PalletGtCode + "' ";
                sql = sql + ") ";
                sql = sql + "";

                connection2.Open();
                SqlCommand UpdateCommand = new SqlCommand(sql, connection2);
                UpdateCommand.ExecuteNonQuery();
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

        static public void SavePODetail
            (int POKey, String ProductKey, String CsOrdQty, double BxOrdQty,
             String CsRecQty, double BxRecQty, String ListPr, double ListAmt, String DcRate1,
             String DcKind1, String DcRate2, String DcKind2, String NetPr, String Amount,
             String ExpireDate, String InnerQty, String FlgRemark, String CdLocation)
        {
            try
            {
                string sql = "";
                sql = sql + "insert into [PODetail] ";
                sql = sql + "( ";
                sql = sql + "[POKey],[ProductKey],[CsOrdQty],[BxOrdQty], ";
                sql = sql + "[CsRecQty],[BxRecQty],[ListPr],[ListAmt],[DcRate1], ";
                sql = sql + "[DcKind1],[DcRate2],[DcKind2],[NetPr],[Amount], ";
                sql = sql + "[ExpireDate],[InnerQty],[FlgRemark],[CdLocation] ";
                sql = sql + ") ";
                sql = sql + "Values ";
                sql = sql + "('" + POKey + "','" + ProductKey + "','" + CsOrdQty + "','" + BxOrdQty + "', ";
                sql = sql + " '" + CsRecQty + "','" + BxRecQty + "','" + ListPr + "','" + ListAmt + "','" + DcRate1 + "', ";
                sql = sql + " '" + DcKind1 + "','" + DcRate2 + "','" + DcKind2 + "','" + NetPr + "','" + Amount + "', ";
                sql = sql + " '" + ExpireDate + "','" + InnerQty + "','" + FlgRemark + "','" + CdLocation + "' ";
                sql = sql + ") ";
                sql = sql + "";

                connection2.Open();
                SqlCommand UpdateCommand = new SqlCommand(sql, connection2);
                UpdateCommand.ExecuteNonQuery();
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

        static public void UpdatePO
            (String CdBranchCode, int PONo, String CdInventoryIOCode, String CtPOTypeCode, String CdLocation,
             String CdShipViaCode, String CtShipMethod, String PaymentTermKey, String VendorBrokerKey,
             String OrderContactKey, DateTime OrderSubmitDate, String ExpectedDevDate,
             DateTime RecevingDate, String IsConfirmed, String ConfirmedUser, String ConfirmedVendor, String POMemo,
             String RecevingMemo, String BillAddrKey, String ShipAddrKey, String AddDate, String AddUser,
             String PalletGtCode)
        {
            try
            {
                string sql = "";
                sql = sql + "update [PO] set ";
                sql = sql + "	 [CdBranchCode] = '" + CdBranchCode + "' ";
                sql = sql + "	,[CdInventoryIOCode] = '" + CdInventoryIOCode + "'";
                sql = sql + "	,[CtPOTypeCode] =  '" + CtPOTypeCode + "' ";
                sql = sql + "	,[CdLocation] = '" + CdLocation + "' ";
                sql = sql + "	,[CdShipViaCode] = '" + CdShipViaCode + "' ";
                sql = sql + "	,[CtShipMethod] = '" + CtShipMethod + "' ";
                sql = sql + "	,[PaymentTermKey] = '" + PaymentTermKey + "' ";
                sql = sql + "	,[VendorBrokerKey] = '" + VendorBrokerKey + "' ";
                //sql = sql + " 	,[OrderContactKey] = '" + OrderContactKey + "' ";
                sql = sql + "	,[OrderSubmitDate] = '" + OrderSubmitDate + "' ";
                sql = sql + "	,[ExpectedDevDate] = '" + ExpectedDevDate + "' ";
                sql = sql + "	,[RecevingDate] = '" + RecevingDate + "' ";
                sql = sql + " 	,[IsConfirmed] = '" + IsConfirmed + "' ";
                sql = sql + "	,[ConfirmedUser] = '" + ConfirmedUser + "' ";
                sql = sql + "	,[ConfirmedVendor] = '" + ConfirmedVendor + "' ";
                sql = sql + "	,[POMemo] = '" + POMemo + "' ";
                sql = sql + "	,[RecevingMemo] = '" + RecevingMemo + "' ";
                sql = sql + "	,[BillAddrKey] = '" + BillAddrKey + "' ";
                sql = sql + "	,[ShipAddrKey] = '" + ShipAddrKey + "' ";
                sql = sql + "	,[AddDate] = '" + AddDate + "' ";
                sql = sql + "	,[AddUser] = '" + AddUser + "' ";
                sql = sql + "	,[PalletGtCode] = '" + PalletGtCode + "'  ";
                sql = sql + "WHERE [PONo] = '" + PONo + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand UpdateCommand = new SqlCommand(sql, connection2);
                UpdateCommand.ExecuteNonQuery();
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

        static public void UpdatePODetail
            (String ProductKey, String CsOrdQty, double BxOrdQty,
             String CsRecQty, double BxRecQty, String ListPr, double ListAmt, String DcRate1,
             String DcKind1, String DcRate2, String DcKind2, String NetPr, String Amount,
             String ExpireDate, String InnerQty, String FlgRemark, String CdLocation, String PODetailKey)
        {
            try
            {
                string sql = "";
                sql = sql + "update [PODetail] set ";
                sql = sql + "		 [ProductKey] = '" + ProductKey + "' ";
                sql = sql + "		,[CsOrdQty] = '" + CsOrdQty + "' ";
                sql = sql + "		,[BxOrdQty] = '" + BxOrdQty + "' ";
                sql = sql + "		,[CsRecQty] = '" + CsRecQty + "' ";
                sql = sql + "		,[BxRecQty] = '" + BxRecQty + "' ";
                sql = sql + "		,[ListPr] = '" + ListPr + "' ";
                sql = sql + "		,[ListAmt] = '" + ListAmt + "' ";
                sql = sql + "		,[DcRate1] = '" + DcRate1 + "' ";
                sql = sql + "		,[DcKind1] = '" + DcKind1 + "' ";
                sql = sql + "		,[DcRate2] = '" + DcRate2 + "' ";
                sql = sql + "		,[DcKind2] = '" + DcKind2 + "' ";
                sql = sql + "		,[NetPr] = '" + NetPr + "' ";
                sql = sql + "		,[Amount] = '" + Amount + "' ";
                sql = sql + "		,[ExpireDate] = '" + ExpireDate + "' ";
                sql = sql + "		,[InnerQty] = '" + InnerQty + "' ";
                sql = sql + "		,[FlgRemark] = '" + FlgRemark + "' ";
                sql = sql + "		,[CdLocation] = '" + CdLocation + "' ";
                sql = sql + "WHERE [PODetailKey] = '" + PODetailKey + "' ";
                //MessageBox.Show(sql);

                connection2.Open();
                SqlCommand UpdateCommand = new SqlCommand(sql, connection2);
                UpdateCommand.ExecuteNonQuery();
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


        static public string getCdBranchCode(string BranchName)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [CdBranchCode] ";
                sql = sql + "FROM [CdBranch] ";
                sql = sql + "WHERE BranchName = '" + BranchName + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CdBranchCode = reader[0].ToString();
                    return CdBranchCode;
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

        static public string getCdInventoryIOCode(string CodeName)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [CodeID] ";
                sql = sql + "FROM [Code] ";
                sql = sql + "WHERE CodeName = '" + CodeName + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CodeID = reader[0].ToString();
                    return CodeID;
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

        static public string getCdLocationCd(string LocationDesc)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [CdLocation] ";
                sql = sql + "FROM [CdLocationCd] ";
                sql = sql + "WHERE LocationDesc = '" + LocationDesc + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CdLocation = reader[0].ToString();
                    return CdLocation;
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

        static public string getLocation(string LocationCode)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [LocationDesc] ";
                sql = sql + "FROM [CdLocationCd] ";
                sql = sql + "WHERE CdLocation = '" + LocationCode + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string LocationDesc = reader[0].ToString();
                    return LocationDesc;
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

        static public string getCdShipViaCode(string ShipViaName)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [CdShipViaCode] ";
                sql = sql + "FROM [CdShipVia] ";
                sql = sql + "WHERE ShipViaName = '" + ShipViaName + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CdShipViaCode = reader[0].ToString();
                    return CdShipViaCode;
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

        static public string getPaymentTermKey(string TermName)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [PaymentTermKey] ";
                sql = sql + "FROM [PaymentTerm] ";
                sql = sql + "WHERE TermName = '" + TermName + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string PaymentTermKey = reader[0].ToString();
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

        static public string getOrderContactKey(string FristName, string TraderEntityKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [ContactKey] ";
                sql = sql + "FROM [TraderEntityContact] ";
                sql = sql + "WHERE FirstName = '" + FristName + "' AND  TraderEntityKey= '" + TraderEntityKey + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string ContactKey = reader[0].ToString();
                    return ContactKey;
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

        static public string getAddrKey(string AddrLine1)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [AddressKey] ";
                sql = sql + "FROM [TraderEntityAddress] ";
                sql = sql + "WHERE AddrLine1 = '" + AddrLine1.Trim() + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string AddrKey = reader[0].ToString();
                    return AddrKey;
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

        static public string getShipAddrKey(string AddrLine1)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [AddressKey] ";
                sql = sql + "FROM [TraderEntityAddress] ";
                sql = sql + "WHERE AddrLine1 = '" + AddrLine1.Trim() + "' AND TraderEntityKey = 90";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string AddrKey = reader[0].ToString();
                    return AddrKey;
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

        static public string getLastPOKey()
        {
            try
            {
                string sql = "";
                sql = sql + "select top 1 POKey ";
                sql = sql + "from PO order by POKey desc ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string POKey = reader[0].ToString();
                    return POKey;
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

        static public string getCdLocation(string pokey)
        {
            try
            {
                string sql = "";
                sql = sql + "select CdLocation ";
                sql = sql + "FROM [PO] ";
                sql = sql + "where POKey = '"+ pokey + "' ";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CdLocation = reader[0].ToString();
                    return CdLocation;
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

        static public string getCOGS(String ProductID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [COGS] ";
                sql = sql + "FROM [Product] ";
                sql = sql + "WHERE ProductID = '" + ProductID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string COGS = reader[0].ToString();
                    return COGS;
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

        static public string getUnitPrice(String ProductID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [UnitPr] ";
                sql = sql + "FROM [Product] ";
                sql = sql + "WHERE ProductID = '" + ProductID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
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

        static public string getBottomPrice(String ProductID)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [BottomPr] ";
                sql = sql + "FROM [Product] ";
                sql = sql + "WHERE ProductID = '" + ProductID + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
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

        static public void sp_Updated_POForRcv
            (int POKey, String CdBranchCode, int PONo, String CdInventoryIOCode, String CtPOTypeCode,
             String CdLocation, int TraderEntityKey, String CdShipViaCode, String CtShipMethod, String PaymentTermKey,
             int VendorBrokerKey, int OrderContactKey, String CtPOStatus, String OrderDate, String OrderSubmitDate,
             String ExpectedDevDate, String RecevingDate, bool IsConfirmed, String ConfirmedUser, String ConfirmedVendor,
             String POMemo, String RecevingMemo, int BillAddrKey, int ShipAddrKey, String AddDate, String AddUser, String PalletGtCode,
             int OutPut_POKey, int OutPut_RowCount, String OutPut_ErrMsg)
        {
            try
            {
                SqlCommand cmdPo = new SqlCommand();
                cmdPo.Connection = connection2;

                cmdPo.CommandText = "dbo.sp_Update_POForRcv";
                cmdPo.CommandType = CommandType.StoredProcedure;

                cmdPo.Parameters.Add(new SqlParameter("@Tr_POKey", SqlDbType.Int));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_CdBranchCode", SqlDbType.Char, 3));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_PONo", SqlDbType.Int));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_CdInventoryIOCode", SqlDbType.Char, 8));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_CtPOTypeCode", SqlDbType.Char, 8));

                cmdPo.Parameters.Add(new SqlParameter("@Tr_CdLocation", SqlDbType.Char, 3));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_TraderEntityKey", SqlDbType.Int));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_CdShipViaCode", SqlDbType.Char, 3));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_CtShipMethod", SqlDbType.Char, 2));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_PaymentTermKey", SqlDbType.SmallInt));

                cmdPo.Parameters.Add(new SqlParameter("@Tr_VendorBrokerKey", SqlDbType.Int));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_OrderContactKey", SqlDbType.Int));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_CtPOStatus", SqlDbType.Char, 3));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_OrderDate", SqlDbType.SmallDateTime));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_OrderSubmitDate", SqlDbType.SmallDateTime));

                cmdPo.Parameters.Add(new SqlParameter("@Tr_ExpectedDevDate", SqlDbType.VarChar, 10));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_RecevingDate", SqlDbType.SmallDateTime));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_IsConfirmed", SqlDbType.Bit));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_ConfirmedUser", SqlDbType.VarChar, 100));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_ConfirmedVendor", SqlDbType.VarChar, 100));

                cmdPo.Parameters.Add(new SqlParameter("@Tr_POMemo", SqlDbType.VarChar, 250));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_RecevingMemo", SqlDbType.VarChar, 255));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_BillAddrKey", SqlDbType.Int));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_ShipAddrKey", SqlDbType.Int));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_AddDate", SqlDbType.SmallDateTime));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_AddUser", SqlDbType.VarChar, 10));
                cmdPo.Parameters.Add(new SqlParameter("@Tr_PalletGtCode", SqlDbType.VarChar, 8));

                SqlParameter par2 = cmdPo.CreateParameter();
                par2.SourceVersion = DataRowVersion.Proposed;
                par2.ParameterName = "@Tr_OutPut_POKey";
                par2.SqlDbType = SqlDbType.Int;
                par2.Direction = ParameterDirection.Output;
                cmdPo.Parameters.Add(par2);

                SqlParameter par3 = cmdPo.CreateParameter();
                par3.SourceVersion = DataRowVersion.Proposed;

                par3.ParameterName = "@Tr_OutPut_RowCount";

                par3.SqlDbType = SqlDbType.Int;
                par3.Direction = ParameterDirection.Output;
                cmdPo.Parameters.Add(par3);

                SqlParameter par4 = cmdPo.CreateParameter();
                par4.SourceVersion = DataRowVersion.Proposed;
                par4.ParameterName = "@Tr_OutPut_ErrMsg";

                par4.SqlDbType = SqlDbType.VarChar;
                par4.Size = 1000;
                par4.Direction = ParameterDirection.Output;
                cmdPo.Parameters.Add(par4);

                cmdPo.Parameters["@Tr_POKey"].Value = POKey;
                cmdPo.Parameters["@Tr_CdBranchCode"].Value = CdBranchCode;
                cmdPo.Parameters["@Tr_PONo"].Value = PONo;
                CdInventoryIOCode = CdInventoryIOCode ?? "1003121";
                cmdPo.Parameters["@Tr_CdInventoryIOCode"].Value = CdInventoryIOCode;
                cmdPo.Parameters["@Tr_CtPOTypeCode"].Value = CtPOTypeCode;
                CdLocation = CdLocation ?? "NYC";
                cmdPo.Parameters["@Tr_CdLocation"].Value = CdLocation;
                cmdPo.Parameters["@Tr_TraderEntityKey"].Value = TraderEntityKey;
                cmdPo.Parameters["@Tr_CdShipViaCode"].Value = CdShipViaCode;
                cmdPo.Parameters["@Tr_CtShipMethod"].Value = CtShipMethod;
                cmdPo.Parameters["@Tr_PaymentTermKey"].Value = PaymentTermKey;
                cmdPo.Parameters["@Tr_VendorBrokerKey"].Value = VendorBrokerKey;
                cmdPo.Parameters["@Tr_OrderContactKey"].Value = OrderContactKey;
                cmdPo.Parameters["@Tr_CtPOStatus"].Value = "R";
                cmdPo.Parameters["@Tr_OrderDate"].Value = OrderDate;

                cmdPo.Parameters["@Tr_OrderSubmitDate"].Value = OrderSubmitDate;
                ExpectedDevDate = ExpectedDevDate ?? "A.S.A.P";
                cmdPo.Parameters["@Tr_ExpectedDevDate"].Value = ExpectedDevDate;

                cmdPo.Parameters["@Tr_RecevingDate"].Value = RecevingDate;
                cmdPo.Parameters["@Tr_IsConfirmed"].Value = true;
                ConfirmedUser = ConfirmedUser ?? "";
                cmdPo.Parameters["@Tr_ConfirmedUser"].Value = ConfirmedUser;
                ConfirmedVendor = ConfirmedVendor ?? "";
                cmdPo.Parameters["@Tr_ConfirmedVendor"].Value = ConfirmedVendor;
                POMemo = POMemo ?? "";
                cmdPo.Parameters["@Tr_POMemo"].Value = POMemo;
                RecevingMemo = RecevingMemo ?? "";
                cmdPo.Parameters["@Tr_RecevingMemo"].Value = RecevingMemo;
                cmdPo.Parameters["@Tr_BillAddrKey"].Value = BillAddrKey;
                cmdPo.Parameters["@Tr_ShipAddrKey"].Value = ShipAddrKey;
                cmdPo.Parameters["@Tr_AddDate"].Value = AddDate;
                AddUser = AddUser ?? " ";
                cmdPo.Parameters["@Tr_AddUser"].Value = AddUser;
                PalletGtCode = PalletGtCode ?? "";
                cmdPo.Parameters["@Tr_PalletGtCode"].Value = PalletGtCode;

                connection2.Open();

                cmdPo.ExecuteNonQuery();// .ExecuteScalar();

                int poKey;
                poKey = (int)cmdPo.Parameters["@Tr_OutPut_POKey"].Value;

                int a;

                a = (int)cmdPo.Parameters["@Tr_OutPut_RowCount"].Value;

                string outputmsg = (string)cmdPo.Parameters["@Tr_OutPut_ErrMsg"].Value;
                MessageBox.Show(outputmsg);
                SqlDataReader reader = cmdPo.ExecuteReader();
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

        static public string getLeadtime(string BrandCode)
        {
            try
            {
                BrandCode = BrandCode.Replace("'", "''");
                string sql = "";
                sql = sql + "SELECT LeadTime ";
                sql = sql + "FROM Brand WITH(NOLOCK) ";
                sql = sql + "WHERE BrandCode = '" + BrandCode + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string LeadTime = reader[0].ToString();
                    return LeadTime;
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

        static public void UpdateisConfirmTure(String POKey)
        {
            try
            {
                string sql = "";
                sql = sql + "UPDATE [PO] ";
                sql = sql + "SET IsConfirmed = 1 ";
                sql = sql + "WHERE POKey = '" + POKey + "' ";

                connection2.Open();
                SqlCommand UpdateCommand = new SqlCommand(sql, connection2);
                UpdateCommand.ExecuteNonQuery();
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

        static public bool isConfirmed(string POKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [isConfirmed] ";
                sql = sql + "FROM [PO] ";
                sql = sql + "WHERE POKey = '" + POKey + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    bool isConfirmed = Convert.ToBoolean(reader[0]);
                    if(isConfirmed) //true
                    {
                        return true;
                    }
                    else //false
                    {
                        return false;
                    }
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

        static public string getPOStatus(string POKey)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [CtPOStatus] ";
                sql = sql + "FROM [PO] ";
                sql = sql + "WHERE POKey = '" + POKey + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string CtPOStatus = reader[0].ToString();
                    return CtPOStatus;
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

        static public bool sp_Cancel_PO(int POKey)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.Sp_TR_Cancel_PO";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@POKey", SqlDbType.Int);

                SqlParameter par3 = cmd.CreateParameter();
                par3.SourceVersion = DataRowVersion.Proposed;

                par3.ParameterName = "@Tr_OutPut_RowCount";

                par3.SqlDbType = SqlDbType.Int;
                par3.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(par3);

                SqlParameter par4 = cmd.CreateParameter();
                par4.SourceVersion = DataRowVersion.Proposed;
                par4.ParameterName = "@Tr_OutPut_ErrMsg";

                par4.SqlDbType = SqlDbType.VarChar;
                par4.Size = 1000;
                par4.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(par4);

                cmd.Parameters["@POKey"].Value = POKey;

                connection.Open();

                cmd.ExecuteNonQuery();

                int a;

                a = (int)cmd.Parameters["@Tr_OutPut_RowCount"].Value;

                string outputmsg = (string)cmd.Parameters["@Tr_OutPut_ErrMsg"].Value;

                if (a == 0)
                {   //1052
                    //trx.Rollback();
                    return false;
                }
                //SqlDataAdapter da = new SqlDataAdapter();
                //da.SelectCommand = cmd;
                //DataTable dataTable = new DataTable();
                //da.Fill(dataTable);
                //_dataGridView.DataSource = dataTable;
                return true;
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

        static public bool sp_Cancel_Rcv(int POKey)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.Sp_TR_Cancel_Rcv";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Tr_POKey", SqlDbType.Int));

                SqlParameter par3 = cmd.CreateParameter();
                par3.SourceVersion = DataRowVersion.Proposed;

                par3.ParameterName = "@Tr_OutPut_RowCount";

                par3.SqlDbType = SqlDbType.Int;
                par3.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(par3);

                SqlParameter par4 = cmd.CreateParameter();
                par4.SourceVersion = DataRowVersion.Proposed;
                par4.ParameterName = "@Tr_OutPut_ErrMsg";

                par4.SqlDbType = SqlDbType.VarChar;
                par4.Size = 1000;
                par4.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(par4);

                cmd.Parameters["@Tr_POKey"].Value = POKey;

                connection.Open();

                cmd.ExecuteNonQuery();

                int a;

                a = (int)cmd.Parameters["@Tr_OutPut_RowCount"].Value;

                string outputmsg = (string)cmd.Parameters["@Tr_OutPut_ErrMsg"].Value;

                if (a == 0)
                {   //1052
                    //trx.Rollback();
                    return false;
                }
                //SqlDataAdapter da = new SqlDataAdapter();
                //da.SelectCommand = cmd;
                //DataTable dataTable = new DataTable();
                //da.Fill(dataTable);
                //_dataGridView.DataSource = dataTable;
                return true;
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

        static public bool Sp_TR_UPDATE_InventoryIO(String ProductKey, String CdBranchCode, DateTime RecevingDate, String CdInventoryIOCode, String ExpDate,
            double InnerQty, double CsRecQty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.Sp_TR_UPDATE_InventoryIO";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ProductKey", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@CdBranchCode", SqlDbType.VarChar, 3));
                cmd.Parameters.Add(new SqlParameter("@IO_DATE", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@CdInventoryIOCode", SqlDbType.VarChar, 3));
                cmd.Parameters.Add(new SqlParameter("@StrExpDate", SqlDbType.VarChar, 3));
                cmd.Parameters.Add(new SqlParameter("@StrCdLoc", SqlDbType.VarChar, 3));
                cmd.Parameters.Add(new SqlParameter("@Qty", SqlDbType.Decimal));
                cmd.Parameters.Add(new SqlParameter("@StrInOut", SqlDbType.Char, 2));

                SqlParameter par52 = cmd.CreateParameter();
                par52.SourceVersion = DataRowVersion.Proposed;

                par52.ParameterName = "@OutPut_RowCount";

                par52.SqlDbType = SqlDbType.Int;
                par52.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(par52);

                SqlParameter par53 = cmd.CreateParameter();
                par53.SourceVersion = DataRowVersion.Proposed;

                par53.ParameterName = "@OutPut_ErrMsg";

                par53.SqlDbType = SqlDbType.VarChar;
                par53.Size = 1000;
                par53.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(par53);

                cmd.Parameters["@ProductKey"].Value = ProductKey;
                cmd.Parameters["@CdBranchCode"].Value = CdBranchCode;
                //if ( prmPO.RecevingDate == '1990-01-01' ) prmPO.RecevingDate = DateTime.Now;
                cmd.Parameters["@IO_DATE"].Value = RecevingDate;//DateTime.Now;
                cmd.Parameters["@CdInventoryIOCode"].Value = CdInventoryIOCode.Substring(4, 3);
                //1052
                cmd.Parameters["@StrExpDate"].Value = ExpDate; ;
                cmd.Parameters["@StrCdLoc"].Value = "NYC";

                if (InnerQty < 1)
                    InnerQty = 1;

                cmd.Parameters["@Qty"].Value = CsRecQty * InnerQty;
                cmd.Parameters["@StrInOut"].Value = "IN";

                connection.Open();

                cmd.ExecuteNonQuery();

                int a;

                a = (int)cmd.Parameters["@OutPut_RowCount"].Value;

                String outputmsg = (string)cmd.Parameters["@OutPut_ErrMsg"].Value;

                if (a == 0)
                {   //1052
                    //trx.Rollback();
                    return false;
                }
                //SqlDataAdapter da = new SqlDataAdapter();
                //da.SelectCommand = cmd;
                //DataTable dataTable = new DataTable();
                //da.Fill(dataTable);
                //_dataGridView.DataSource = dataTable;
                return true;
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

        static public bool Sp_TR_UPDATE_InventoryExpForInventoryAdj(String ProductKey, String CdBranchCode, String CdInventoryIOCode, String ExpDate,
            String CdLocation, double BxRecQty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.Sp_TR_UPDATE_InventoryExpForInventoryAdj";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ProductKey", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@CdBranchCode", SqlDbType.VarChar, 3));
                cmd.Parameters.Add(new SqlParameter("@IO_DATE", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@CdInventoryIOCode", SqlDbType.VarChar, 3));
                cmd.Parameters.Add(new SqlParameter("@StrExpDate", SqlDbType.VarChar, 8));
                cmd.Parameters.Add(new SqlParameter("@StrCdLoc", SqlDbType.VarChar, 3));
                cmd.Parameters.Add(new SqlParameter("@Qty", SqlDbType.Decimal));
                cmd.Parameters.Add(new SqlParameter("@StrInOut", SqlDbType.Char, 2));

                SqlParameter par72 = cmd.CreateParameter();
                par72.SourceVersion = DataRowVersion.Proposed;

                par72.ParameterName = "@OutPut_RowCount";

                par72.SqlDbType = SqlDbType.Int;
                par72.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(par72);

                SqlParameter par73 = cmd.CreateParameter();
                par73.SourceVersion = DataRowVersion.Proposed;

                par73.ParameterName = "@OutPut_ErrMsg";

                par73.SqlDbType = SqlDbType.VarChar;
                par73.Size = 1000;
                par73.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(par73);

                cmd.Parameters["@ProductKey"].Value = ProductKey;
                cmd.Parameters["@CdBranchCode"].Value = CdBranchCode;
                cmd.Parameters["@IO_DATE"].Value = DateTime.Now;
                cmd.Parameters["@CdInventoryIOCode"].Value = CdInventoryIOCode.Substring(4, 3);

                //1052
                cmd.Parameters["@StrExpDate"].Value = ExpDate; ;
                cmd.Parameters["@StrCdLoc"].Value = CdLocation;

                cmd.Parameters["@Qty"].Value = BxRecQty;

                cmd.Parameters["@StrInOut"].Value = "IN";

                connection.Open();

                cmd.ExecuteNonQuery();

                int a7;

                a7 = (int)cmd.Parameters["@OutPut_RowCount"].Value;

                string outputmsg71 = (string)cmd.Parameters["@OutPut_ErrMsg"].Value;

                if (a7 == 0)
                {   //1052
                    //trx.Rollback();
                    return false;
                }
                //SqlDataAdapter da = new SqlDataAdapter();
                //da.SelectCommand = cmd;
                //DataTable dataTable = new DataTable();
                //da.Fill(dataTable);
                //_dataGridView.DataSource = dataTable;
                return true;
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

        static public void UpdatePOStatus(String POKey, String Status)
        {
            try
            {
                string sql = "";
                sql = sql + "UPDATE [PO] ";
                sql = sql + "SET CtPOStatus = '" + Status + "' ";
                sql = sql + "WHERE POKey = '" + POKey + "' ";

                connection2.Open();
                SqlCommand UpdateCommand = new SqlCommand(sql, connection2);
                UpdateCommand.ExecuteNonQuery();
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

        static public void sp_TemporaryPurchaseOrderList(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_TemporaryPurchaseOrderList";
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

        static public void sp_TemporaryPurchaseOrderList_Product(DataGridView _dataGridView, String BrandKey)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_TemporaryPurchaseOrderList_Product";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandKey", SqlDbType.Int);
                cmd.Parameters["@BrandKey"].Value = BrandKey;

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

        static public void sp_ResetOrder(String BrandKey)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_ResetOrder";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandKey", SqlDbType.Int);
                cmd.Parameters["@BrandKey"].Value = BrandKey;

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

        static public void sp_Fetch_Employee(DataGridView _dataGridView, string IsInActive, string Employee)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Fetch_Employee";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@IsInActive", SqlDbType.VarChar);
                cmd.Parameters.Add("@Employee", SqlDbType.VarChar);

                cmd.Parameters["@IsInActive"].Value = IsInActive;
                cmd.Parameters["@Employee"].Value = Employee;

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

        static public void sp_CREATE_POPrepare(String Vendor, String Brand, String Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CREATE_POPrepare2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Vendor", SqlDbType.VarChar);
                cmd.Parameters.Add("@Brand", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@Vendor"].Value = Vendor;
                cmd.Parameters["@Brand"].Value = Brand;
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

        static public void sp_CREATE_POPrepareDetail(String ItemID, Decimal OrderQty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CREATE_POPrepareDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@ItemID"].Value = ItemID;
                cmd.Parameters["@OrderQty"].Value = OrderQty;
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

        static public void sp_POPrepare_HEADER(DataGridView _dataGridView, string POPNumber, string Supplier, string Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_POPrepare_HEADER2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@POPNumber", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Supplier", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.NVarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@POPNumber"].Value = POPNumber;
                cmd.Parameters["@Supplier"].Value = Supplier;
                cmd.Parameters["@Memo"].Value = Memo;

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

        static public void sp_POPrepare_HEADER3(DataGridView _dataGridView, string POPNumber, string Supplier, string Brand, string Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_POPrepare_HEADER3";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@POPNumber", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Supplier", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Brand", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.NVarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@POPNumber"].Value = POPNumber;
                cmd.Parameters["@Supplier"].Value = Supplier;
                cmd.Parameters["@Brand"].Value = Brand;
                cmd.Parameters["@Memo"].Value = Memo;

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

        static public void sp_POPrepareVoid_HEADER(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_POPrepareVoid_HEADER";
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

        static public void sp_PPAYMENTT_HEADER(DataGridView _dataGridView, String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENTT_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;

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

        static public void sp_PPAYMENT_HEADER(DataGridView _dataGridView, String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;

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

        static public void sp_PPAYMENTT_REVERSE(DataGridView _dataGridView, String TempPaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENTT_REVERSE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@TempPaymentNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReverseUser", SqlDbType.VarChar);

                cmd.Parameters["@TempPaymentNumber"].Value = TempPaymentNumber;
                cmd.Parameters["@ReverseUser"].Value = GATE.userID;

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

        static public void sp_PPAYMENT_DELETECREDITDEBIT(String Number)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_DELETECREDITDEBIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Number", SqlDbType.VarChar);
                cmd.Parameters.Add("@DeleteUser", SqlDbType.VarChar);
                
                cmd.Parameters["@Number"].Value = Number;
                cmd.Parameters["@DeleteUser"].Value = GATE.userID;

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

        static public void sp_PO_DeleteDetail(String PONumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PO_DeleteDetail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);

                cmd.Parameters["@PONumber"].Value = PONumber;

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

        static public void sp_PO_UPDATE(String PONumber, String Memo, String WHMemo, String OrderSite, String Supplier, String ShipVia)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PO_UPDATE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@WHMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@Supplier", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipVia", SqlDbType.VarChar);

                cmd.Parameters["@PONumber"].Value = PONumber;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@WHMemo"].Value = WHMemo;
                cmd.Parameters["@OrderSite"].Value = OrderSite;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@Supplier"].Value = Supplier;
                cmd.Parameters["@ShipVia"].Value = ShipVia;

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

        static public void sp_PPAYMENT_INVOICE(DataGridView _dataGridView, String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_INVOICE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;

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

        static public void sp_PPAYMENT_SELECT_INVOICE(DataGridView _dataGridView, String PaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_SELECT_INVOICE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentNumber", SqlDbType.VarChar);

                cmd.Parameters["@PaymentNumber"].Value = PaymentNumber;
                
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

        static public void sp_PPAYMENTT_SELECT_INVOICE(DataGridView _dataGridView, String PaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENTT_SELECT_INVOICE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentNumber", SqlDbType.VarChar);

                cmd.Parameters["@PaymentNumber"].Value = PaymentNumber;

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

        static public void sp_PRECEIPT_HEADER(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PRECEIPT_HEADER";
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

        static public void sp_PRECEIPT_VALIDATIONHEADER(DataGridView _dataGridView, String RecNumber, String PONumber, String SupplierID, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PRECEIPT_VALIDATIONHEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RecNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                cmd.Parameters["@RecNumber"].Value = RecNumber;
                cmd.Parameters["@PONumber"].Value = PONumber;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
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

        static public void sp_POManagement(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, string Supplier, string Received, string Confirmed, string Type, string Brand)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PO_MANAGEMENT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Supplier", SqlDbType.VarChar);
                cmd.Parameters.Add("@Received", SqlDbType.VarChar);
                cmd.Parameters.Add("@Confirmed", SqlDbType.VarChar);
                cmd.Parameters.Add("@Type", SqlDbType.VarChar);
                cmd.Parameters.Add("@Brand", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@Supplier"].Value = Supplier;
                cmd.Parameters["@Received"].Value = Received;
                cmd.Parameters["@Confirmed"].Value = Confirmed;
                cmd.Parameters["@Type"].Value = Type;
                cmd.Parameters["@Brand"].Value = Brand;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;

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

        static public void sp_POManagement_detail(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, string Supplier, string Brand, string Product, string Received, string Confirmed, string Type)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PO_MANAGEMENT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Supplier", SqlDbType.VarChar);
                cmd.Parameters.Add("@Brand", SqlDbType.VarChar);
                cmd.Parameters.Add("@Product", SqlDbType.VarChar);
                cmd.Parameters.Add("@Received", SqlDbType.VarChar);
                cmd.Parameters.Add("@Confirmed", SqlDbType.VarChar);
                cmd.Parameters.Add("@Type", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@Supplier"].Value = Supplier;
                cmd.Parameters["@Brand"].Value = Brand;
                cmd.Parameters["@Product"].Value = Product;
                cmd.Parameters["@Received"].Value = Received;
                cmd.Parameters["@Confirmed"].Value = Confirmed;
                cmd.Parameters["@Type"].Value = Type;
                //cmd.Parameters["@PaymentType"].Value = PaymentType;

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

        static public string sp_CREATE_PINVOICE_CHARGEBACK(String SupplierID, String SupplierDocNo, String PONumber, Decimal ChargeBackAmount, String Branch, String NewPINNumber, String TypeCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_CREATE_PINVOICE_CHARGEBACK";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierDocNo", SqlDbType.VarChar);
                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ChargeBackAmount", SqlDbType.VarChar);
                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewPINNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@TypeCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReturnMessage", SqlDbType.VarChar, int.MaxValue).Direction = ParameterDirection.Output;

                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@SupplierDocNo"].Value = SupplierDocNo;
                cmd.Parameters["@PONumber"].Value = PONumber;
                cmd.Parameters["@ChargeBackAmount"].Value = ChargeBackAmount;
                cmd.Parameters["@Branch"].Value = Branch;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewPINNumber"].Value = NewPINNumber;
                cmd.Parameters["@TypeCode"].Value = TypeCode;

                connection.Open();
                cmd.ExecuteNonQuery();

                string ReturnMessage = cmd.Parameters["@ReturnMessage"].Value.ToString();
                return ReturnMessage;
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

        static public string sp_CREATE_PINVOICE_FREIGHT(String SupplierID, String SupplierDocNo, String PONumber, Decimal FreightAmount, String Branch, String NewPINNumber, String TypeCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_CREATE_PINVOICE_FREIGHT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierDocNo", SqlDbType.VarChar);
                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@FreightAmount", SqlDbType.VarChar);
                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewPINNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@TypeCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReturnMessage", SqlDbType.VarChar, int.MaxValue).Direction = ParameterDirection.Output;

                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@SupplierDocNo"].Value = SupplierDocNo;
                cmd.Parameters["@PONumber"].Value = PONumber;
                cmd.Parameters["@FreightAmount"].Value = FreightAmount;
                cmd.Parameters["@Branch"].Value = Branch;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewPINNumber"].Value = NewPINNumber;
                cmd.Parameters["@TypeCode"].Value = TypeCode;

                connection.Open();
                cmd.ExecuteNonQuery();

                string ReturnMessage = cmd.Parameters["@ReturnMessage"].Value.ToString();
                return ReturnMessage;
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

        static public void sp_PINVOICE_HEADER(DataGridView _dataGridView, String SupplierID, String SupplierInvoiceNumber, String PONumber, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PINVOICE_HEADER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierInvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@SupplierInvoiceNumber"].Value = SupplierInvoiceNumber;
                cmd.Parameters["@PONumber"].Value = PONumber;
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

        static public void sp_PPAYMENT_CREDIT(DataGridView _dataGridView, String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_CREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;
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

        static public void sp_PPAYMENT_CREDIT_ALL(DataGridView _dataGridView, String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_CREDIT_ALL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;
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

        static public void sp_PPAYMENT_SELECT_CREDIT(DataGridView _dataGridView, String PaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_SELECT_CREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@PaymentNumber"].Value = PaymentNumber;
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

        static public void sp_PPAYMENTT_SELECT_CREDIT(DataGridView _dataGridView, String PaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENTT_SELECT_CREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@PaymentNumber"].Value = PaymentNumber;
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

        static public void sp_PPAYMENT_DEBIT(DataGridView _dataGridView, String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_DEBIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;
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

        static public void sp_PPAYMENT_SELECT_DEBIT(DataGridView _dataGridView, String PaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_SELECT_DEBIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@PaymentNumber"].Value = PaymentNumber;
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

        static public void sp_PPAYMENTT_SELECT_DEBIT(DataGridView _dataGridView, String PaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENTT_SELECT_DEBIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@PaymentNumber"].Value = PaymentNumber;
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

        static public void sp_PPAYMENT_TERMCREDIT(DataGridView _dataGridView, String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_TERMCREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;
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

        static public void sp_PPAYMENT_SELECT_TERMCREDIT(DataGridView _dataGridView, String PaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_SELECT_TERMCREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@PaymentNumber"].Value = PaymentNumber;
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

        static public void sp_PPAYMENTT_SELECT_TERMCREDIT(DataGridView _dataGridView, String PaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENTT_SELECT_TERMCREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@PaymentNumber"].Value = PaymentNumber;
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



        static public void sp_PO_HEADER(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, string PONumber, string RECNumber, string Site, string Supplier, string Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PO_HEADER2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@PONumber", SqlDbType.NVarChar);
                cmd.Parameters.Add("@RECNumber", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Site", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Supplier", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.NVarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@PONumber"].Value = PONumber;
                cmd.Parameters["@RECNumber"].Value = RECNumber;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@Supplier"].Value = Supplier;
                cmd.Parameters["@Memo"].Value = Memo;
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

        static public void sp_PO_DETAIL(DataGridView _dataGridView, String PORDERNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PO_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PORDERNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@PORDERNumber"].Value = PORDERNumber;
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

        static public void sp_POPrepare_DETAIL(DataGridView _dataGridView, String POPNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_POPrepare_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@POPNumber", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                //cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);

                cmd.Parameters["@POPNumber"].Value = POPNumber;
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

        static public void sp_INSERT_PORDERD(PORDER pORDER, String NewPONumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_INSERT_PORDERD";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ReceivingSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductBCS", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductSupplier", SqlDbType.VarChar);
                cmd.Parameters.Add("@OrderQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@STKQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@PackSize", SqlDbType.VarChar);
                cmd.Parameters.Add("@GrossPrice", SqlDbType.VarChar);
                cmd.Parameters.Add("@EDLP", SqlDbType.Decimal);
                cmd.Parameters.Add("@EDLPP", SqlDbType.Decimal);
                cmd.Parameters.Add("@TermPromo", SqlDbType.Decimal);
                cmd.Parameters.Add("@TermPromoP", SqlDbType.Decimal);
                cmd.Parameters.Add("@NetPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@OrderAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@Unit", SqlDbType.VarChar);
                cmd.Parameters.Add("@ExpectedRcptDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@BilledBySupplier", SqlDbType.VarChar);
                cmd.Parameters.Add("@Line", SqlDbType.Decimal);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@Location", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewPONumber", SqlDbType.VarChar);

                cmd.Parameters["@ReceivingSite"].Value = pORDER.ReceivingSite;
                cmd.Parameters["@ProductBCS"].Value = pORDER.ProductBCS;
                cmd.Parameters["@ProductSupplier"].Value = pORDER.ProductSupplier;
                cmd.Parameters["@OrderQty"].Value = pORDER.OrderQty;
                cmd.Parameters["@STKQty"].Value = pORDER.STKQty;
                cmd.Parameters["@Description"].Value = pORDER.Description;
                cmd.Parameters["@PackSize"].Value = pORDER.PackSize;
                cmd.Parameters["@GrossPrice"].Value = pORDER.GrossPrice;
                cmd.Parameters["@EDLP"].Value = pORDER.EDLP;
                cmd.Parameters["@EDLPP"].Value = pORDER.EDLPP;
                cmd.Parameters["@TermPromo"].Value = pORDER.TermPromo;
                cmd.Parameters["@TermPromoP"].Value = pORDER.TermPromoP;
                cmd.Parameters["@NetPrice"].Value = pORDER.NetPrice;
                cmd.Parameters["@OrderAmount"].Value = pORDER.OrderAmount;
                cmd.Parameters["@Unit"].Value = pORDER.Unit;
                cmd.Parameters["@ExpectedRcptDate"].Value = pORDER.ExpectedRcptDate;
                cmd.Parameters["@BilledBySupplier"].Value = pORDER.BilledBySupplier;
                cmd.Parameters["@Line"].Value = pORDER.Line;
                cmd.Parameters["@SupplierID"].Value = pORDER.Supplier;
                cmd.Parameters["@Memo"].Value = pORDER.Memo;
                cmd.Parameters["@Location"].Value = pORDER.Location;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewPONumber"].Value = NewPONumber;
                
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
        static public void sp_INSERT_PRECEIPTDNOT(PORDER pORDER, String NewRECNumber, String Reason)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_INSERT_PRECEIPTDNOT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@PORDERNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductBCS", SqlDbType.VarChar);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@PackSize", SqlDbType.VarChar);
                cmd.Parameters.Add("@Unit", SqlDbType.VarChar);
                cmd.Parameters.Add("@InnerCase", SqlDbType.Decimal);
                cmd.Parameters.Add("@GrossPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@EDLP", SqlDbType.Decimal);
                cmd.Parameters.Add("@EDLPP", SqlDbType.Decimal);
                cmd.Parameters.Add("@TermPromo", SqlDbType.Decimal);
                cmd.Parameters.Add("@TermPromoP", SqlDbType.Decimal);
                cmd.Parameters.Add("@NetPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@POQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@POAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@GRQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@GRAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ReceivingSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@Line", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReceivingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ROWID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewRECNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Location", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@Reason", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = pORDER.Supplier;
                cmd.Parameters["@PORDERNumber"].Value = pORDER.PORDERNumber;
                cmd.Parameters["@ProductBCS"].Value = pORDER.ProductBCS;
                cmd.Parameters["@Description"].Value = pORDER.Description;
                cmd.Parameters["@PackSize"].Value = pORDER.PackSize;
                cmd.Parameters["@Unit"].Value = pORDER.Unit;
                //cmd.Parameters["@ProductSupplier"].Value = pORDER.ProductSupplier;
                cmd.Parameters["@InnerCase"].Value = pORDER.InnerCase;
                cmd.Parameters["@GrossPrice"].Value = pORDER.GrossPrice;
                cmd.Parameters["@EDLP"].Value = pORDER.EDLP;
                cmd.Parameters["@EDLPP"].Value = pORDER.EDLPP;
                cmd.Parameters["@TermPromo"].Value = pORDER.TermPromo;
                cmd.Parameters["@TermPromoP"].Value = pORDER.TermPromoP;
                cmd.Parameters["@NetPrice"].Value = pORDER.NetPrice;
                cmd.Parameters["@POQty"].Value = pORDER.OrderQty;
                cmd.Parameters["@POAmount"].Value = pORDER.OrderAmount;
                cmd.Parameters["@GRQty"].Value = pORDER.Qty;
                cmd.Parameters["@GRAmount"].Value = pORDER.GRAmount;
                cmd.Parameters["@ExpirationDate"].Value = pORDER.ExpirationDate;
                cmd.Parameters["@ReceivingSite"].Value = pORDER.ReceivingSite;
                cmd.Parameters["@Line"].Value = pORDER.Line;
                cmd.Parameters["@ReceivingDate"].Value = pORDER.ReceivingDate;
                cmd.Parameters["@ROWID"].Value = pORDER.ROWID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewRECNumber"].Value = NewRECNumber;
                cmd.Parameters["@Location"].Value = pORDER.Location;
                cmd.Parameters["@ProductStatus"].Value = pORDER.ProductStatus;
                cmd.Parameters["@Reason"].Value = Reason;

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
        static public void sp_INSERT_PRECEIPTD(PORDER pORDER, String NewRECNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_INSERT_PRECEIPTD";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@PORDERNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductBCS", SqlDbType.VarChar);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@PackSize", SqlDbType.VarChar);
                cmd.Parameters.Add("@Unit", SqlDbType.VarChar);
                cmd.Parameters.Add("@InnerCase", SqlDbType.Decimal);
                cmd.Parameters.Add("@GrossPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@EDLP", SqlDbType.Decimal);
                cmd.Parameters.Add("@EDLPP", SqlDbType.Decimal);
                cmd.Parameters.Add("@TermPromo", SqlDbType.Decimal);
                cmd.Parameters.Add("@TermPromoP", SqlDbType.Decimal);
                cmd.Parameters.Add("@NetPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@POQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@POAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@GRQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@GRAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ReceivingSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@Line", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReceivingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ROWID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewRECNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Location", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductStatus", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = pORDER.Supplier;
                cmd.Parameters["@PORDERNumber"].Value = pORDER.PORDERNumber;
                cmd.Parameters["@ProductBCS"].Value = pORDER.ProductBCS;
                cmd.Parameters["@Description"].Value = pORDER.Description;
                cmd.Parameters["@PackSize"].Value = pORDER.PackSize;
                cmd.Parameters["@Unit"].Value = pORDER.Unit;
                //cmd.Parameters["@ProductSupplier"].Value = pORDER.ProductSupplier;
                cmd.Parameters["@InnerCase"].Value = pORDER.InnerCase;
                cmd.Parameters["@GrossPrice"].Value = pORDER.GrossPrice;
                cmd.Parameters["@EDLP"].Value = pORDER.EDLP;
                cmd.Parameters["@EDLPP"].Value = pORDER.EDLPP;
                cmd.Parameters["@TermPromo"].Value = pORDER.TermPromo;
                cmd.Parameters["@TermPromoP"].Value = pORDER.TermPromoP;
                cmd.Parameters["@NetPrice"].Value = pORDER.NetPrice;
                cmd.Parameters["@POQty"].Value = pORDER.OrderQty;
                cmd.Parameters["@POAmount"].Value = pORDER.OrderAmount;
                cmd.Parameters["@GRQty"].Value = pORDER.Qty;
                cmd.Parameters["@GRAmount"].Value = pORDER.GRAmount;
                cmd.Parameters["@ExpirationDate"].Value = pORDER.ExpirationDate;
                cmd.Parameters["@ReceivingSite"].Value = pORDER.ReceivingSite;
                cmd.Parameters["@Line"].Value = pORDER.Line;
                cmd.Parameters["@ReceivingDate"].Value = pORDER.ReceivingDate;
                cmd.Parameters["@ROWID"].Value = pORDER.ROWID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewRECNumber"].Value = NewRECNumber;
                cmd.Parameters["@Location"].Value = pORDER.Location;
                cmd.Parameters["@ProductStatus"].Value = pORDER.ProductStatus;

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

        static public void sp_PPAYMENT_JOU_RECEIVINGD(PORDER pORDER, String NewRECNumber, String NewSTKNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_JOU_RECEIVINGD";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceivingAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReceivingQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewRECNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);

                cmd.Parameters["@Line"].Value = pORDER.Line;
                cmd.Parameters["@Branch"].Value = pORDER.ReceivingSite;
                cmd.Parameters["@ReceivingAmount"].Value = pORDER.GRAmount;
                cmd.Parameters["@ReceivingQty"].Value = pORDER.Qty * pORDER.InnerCase;
                cmd.Parameters["@PONumber"].Value = pORDER.PORDERNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewRECNumber"].Value = NewRECNumber;
                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;

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

        static public void sp_PPAYMENT_JOU_RECEIVINGD_DISCOUNT(PORDER pORDER, String NewRECNumber, String NewSTKNumber, Decimal DiscountAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_JOU_RECEIVINGD_DISCOUNT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                cmd.Parameters.Add("@DiscountAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewRECNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);

                cmd.Parameters["@Line"].Value = pORDER.Line;
                cmd.Parameters["@Branch"].Value = pORDER.ReceivingSite;
                cmd.Parameters["@DiscountAmount"].Value = DiscountAmount;
                cmd.Parameters["@PONumber"].Value = pORDER.PORDERNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewRECNumber"].Value = NewRECNumber;
                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;
                //MessageBox.Show(DiscountAmount.ToString());

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

        static public void sp_PPAYMENT_JOU_VALIDATIOND(PORDER pORDER, String NewPINNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_JOU_VALIDATIOND";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Line", SqlDbType.Int);
                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                cmd.Parameters.Add("@RECNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ValidationAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ValidationQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewPINNumber", SqlDbType.VarChar);

                cmd.Parameters["@Line"].Value = pORDER.Line;
                cmd.Parameters["@Branch"].Value = pORDER.ReceivingSite;
                cmd.Parameters["@RECNumber"].Value = pORDER.RECNumber;
                cmd.Parameters["@ValidationAmount"].Value = pORDER.OrderAmount;
                cmd.Parameters["@ValidationQty"].Value = pORDER.Qty;
                cmd.Parameters["@SupplierID"].Value = pORDER.Supplier;
                cmd.Parameters["@PONumber"].Value = pORDER.PORDERNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewPINNumber"].Value = NewPINNumber;

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

        static public void sp_PPAYMENT_JOU_RECEIVING(String ReceivingSite, String NewRECNumber, String NewSTKNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_JOU_RECEIVING";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewRECNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewSTKNumber", SqlDbType.VarChar);
                
                cmd.Parameters["@Branch"].Value = ReceivingSite;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewRECNumber"].Value = NewRECNumber;
                cmd.Parameters["@NewSTKNumber"].Value = NewSTKNumber;

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

        static public void sp_PPAYMENT_JOU_VALIDATION(String ReceivingSite, String SupplierID, String NewPINNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_JOU_VALIDATION";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewPINNumber", SqlDbType.VarChar);

                cmd.Parameters["@Branch"].Value = ReceivingSite;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewPINNumber"].Value = NewPINNumber;

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

        static public void sp_INSERT_PINVOICED(PORDER pORDER, String NewPINNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_INSERT_PINVOICED";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@RECNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@PORDERNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductBCS", SqlDbType.VarChar);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@PackSize", SqlDbType.VarChar);
                cmd.Parameters.Add("@Unit", SqlDbType.VarChar);
                cmd.Parameters.Add("@Qty", SqlDbType.Decimal);
                cmd.Parameters.Add("@InnerCase", SqlDbType.Decimal);
                cmd.Parameters.Add("@GrossPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@EDLP", SqlDbType.Decimal);
                cmd.Parameters.Add("@EDLPP", SqlDbType.Decimal);
                cmd.Parameters.Add("@TermPromo", SqlDbType.Decimal);
                cmd.Parameters.Add("@TermPromoP", SqlDbType.Decimal);
                cmd.Parameters.Add("@NetPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@OrderAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ReceivingSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@Line", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReceivingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ROWID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewPINNumber", SqlDbType.VarChar);
                
                cmd.Parameters["@RECNumber"].Value = pORDER.RECNumber;
                cmd.Parameters["@SupplierID"].Value = pORDER.Supplier;
                cmd.Parameters["@PORDERNumber"].Value = pORDER.PORDERNumber;
                cmd.Parameters["@ProductBCS"].Value = pORDER.ProductBCS;
                cmd.Parameters["@Description"].Value = pORDER.Description;
                cmd.Parameters["@PackSize"].Value = pORDER.PackSize;
                cmd.Parameters["@Unit"].Value = pORDER.Unit;
                cmd.Parameters["@Qty"].Value = pORDER.Qty;
                //cmd.Parameters["@ProductSupplier"].Value = pORDER.ProductSupplier;
                cmd.Parameters["@InnerCase"].Value = pORDER.InnerCase;
                cmd.Parameters["@GrossPrice"].Value = pORDER.GrossPrice;
                cmd.Parameters["@EDLP"].Value = pORDER.EDLP;
                cmd.Parameters["@EDLPP"].Value = pORDER.EDLPP;
                cmd.Parameters["@TermPromo"].Value = pORDER.TermPromo;
                cmd.Parameters["@TermPromoP"].Value = pORDER.TermPromoP;
                cmd.Parameters["@NetPrice"].Value = pORDER.NetPrice;
                cmd.Parameters["@OrderAmount"].Value = pORDER.OrderAmount;
                cmd.Parameters["@ExpirationDate"].Value = pORDER.ExpirationDate;
                cmd.Parameters["@ReceivingSite"].Value = pORDER.ReceivingSite;
                cmd.Parameters["@Line"].Value = pORDER.Line;
                cmd.Parameters["@ReceivingDate"].Value = pORDER.ReceivingDate;
                cmd.Parameters["@ROWID"].Value = pORDER.ROWID;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewPINNumber"].Value = NewPINNumber;

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

        static public string sp_GET_ShipVia(String SupplierID, String PONumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_ShipVia";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = SupplierID;
                cmd.Parameters["@PONumber"].Value = PONumber;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string ShipVia = reader[2].ToString();
                    return ShipVia;
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

        static public string sp_Brand_Memo(String BrandName, String BrandCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Brand_Memo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandName", SqlDbType.VarChar);
                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);
                
                cmd.Parameters["@BrandName"].Value = BrandName;
                cmd.Parameters["@BrandCode"].Value = BrandCode;

                connection.Open();
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
                connection.Close();
            }
        }

        static public string sp_PPAYMENT_GetSupplierName(String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_GetSupplierName";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string VendorName = reader[0].ToString();
                    return VendorName;
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

        static public string sp_PPAYMENT_GetSupplierAddress1(String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_GetSupplierAddress";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Address1 = reader[1].ToString();
                    return Address1;
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

        static public string sp_PPAYMENT_GetSupplierAddress2(String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_GetSupplierAddress";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Address2 = reader[2].ToString();
                    return Address2;
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

        static public Address sp_GET_SupplierAddress(String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_SupplierAddress";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                Address address = new Address();

                if (reader.Read())
                {
                    address.SupplierID = reader[0].ToString();
                    address.Address1 = reader[1].ToString();
                    address.Address2 = reader[2].ToString();
                    address.City = reader[3].ToString();
                    address.State = reader[4].ToString();
                    address.Zip = reader[5].ToString();
                    address.Tel = reader[6].ToString();
                    address.Fax = reader[7].ToString();

                    return address;
                }
                else
                {
                    return address;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                Address address = new Address();
                return address;
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_CREATE_PORDER(String SupplierID, String Memo, String WHMemo, String POPrepareNumber, String ReceivingSite, String POPNumber, String NewPONumber,
            DateTime ExpectedRcptDate, String ShipVia)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_CREATE_PORDER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceivingSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@POPNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@POPrepareNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewPONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@ExpectedRcptDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@WHMemo", SqlDbType.VarChar);
                cmd.Parameters.Add("@ShipVia", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@ReceivingSite"].Value = ReceivingSite;
                cmd.Parameters["@POPNumber"].Value = POPNumber;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@POPrepareNumber"].Value = POPrepareNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewPONumber"].Value = NewPONumber;
                cmd.Parameters["@ExpectedRcptDate"].Value = ExpectedRcptDate;
                cmd.Parameters["@WHMemo"].Value = WHMemo;
                cmd.Parameters["@ShipVia"].Value = ShipVia;

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

        static public void sp_CREATE_PRECEIPT(String SupplierID, String Memo, String Branch, String PONumber, String NewRECNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_CREATE_PRECEIPT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewRECNumber", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@Branch"].Value = Branch;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@PONumber"].Value = PONumber;
                cmd.Parameters["@NewRECNumber"].Value = NewRECNumber;

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

        static public void sp_CREATE_PINVOICE(String SupplierID, String Memo, String Branch, String RECNumber, String SupplierDocNo, 
                                              Decimal SupplierDocAmount, Decimal ReceiptAmount, Decimal Diff, Decimal Cost, Decimal InvoiceAmount,
                                              String ReceivingSite, String NewPINNumber, DateTime AccountingDate, DateTime InvoiceReceptionDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_CREATE_PINVOICE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceivingSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierDocNo", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierDocAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReceiptAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@Diff", SqlDbType.Decimal);
                cmd.Parameters.Add("@Cost", SqlDbType.Decimal);
                cmd.Parameters.Add("@InvoiceAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                cmd.Parameters.Add("@RECNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewPINNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@InvoiceReceptionDate", SqlDbType.DateTime);

                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@ReceivingSite"].Value = ReceivingSite;
                cmd.Parameters["@SupplierDocNo"].Value = SupplierDocNo;
                cmd.Parameters["@SupplierDocAmount"].Value = SupplierDocAmount;
                cmd.Parameters["@ReceiptAmount"].Value = ReceiptAmount;
                cmd.Parameters["@Diff"].Value = Diff;
                cmd.Parameters["@Cost"].Value = Cost;
                cmd.Parameters["@InvoiceAmount"].Value = InvoiceAmount;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@Branch"].Value = Branch;
                cmd.Parameters["@RECNumber"].Value = RECNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewPINNumber"].Value = NewPINNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@InvoiceReceptionDate"].Value = InvoiceReceptionDate;
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

        static public void sp_CREATE_PINVOICE_SUBCONTRACT(String SupplierID, String Memo, String Branch, String RECNumber, String SupplierDocNo,
                                              Decimal SupplierDocAmount, Decimal ReceiptAmount, Decimal Diff, Decimal Cost, Decimal InvoiceAmount,
                                              String ReceivingSite, String NewPINNumber, DateTime AccountingDate, Decimal Fee)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_CREATE_PINVOICE_SUBCONTRACT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReceivingSite", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierDocNo", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierDocAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReceiptAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@Diff", SqlDbType.Decimal);
                cmd.Parameters.Add("@Cost", SqlDbType.Decimal);
                cmd.Parameters.Add("@InvoiceAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@Branch", SqlDbType.VarChar);
                cmd.Parameters.Add("@RECNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewPINNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.VarChar);
                cmd.Parameters.Add("@Fee", SqlDbType.Decimal);

                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@ReceivingSite"].Value = ReceivingSite;
                cmd.Parameters["@SupplierDocNo"].Value = SupplierDocNo;
                cmd.Parameters["@SupplierDocAmount"].Value = SupplierDocAmount;
                cmd.Parameters["@ReceiptAmount"].Value = ReceiptAmount;
                cmd.Parameters["@Diff"].Value = Diff;
                cmd.Parameters["@Cost"].Value = Cost;
                cmd.Parameters["@InvoiceAmount"].Value = InvoiceAmount;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@Branch"].Value = Branch;
                cmd.Parameters["@RECNumber"].Value = RECNumber;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewPINNumber"].Value = NewPINNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@Fee"].Value = Fee;

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

        static public void sp_PORDER_SaveMemo(String PORDERNumber, String Memo, String WHMemo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PORDER_SaveMemo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PORDERNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@WHMemo", SqlDbType.VarChar);

                cmd.Parameters["@PORDERNumber"].Value = PORDERNumber;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@WHMemo"].Value = WHMemo;

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

        static public void sp_PPAYMENT_ADDCREDIT(String SupplierID, String InvoiceNumber, Decimal Amount
            , String ReasonCode
            , String Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_ADDCREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@ReasonCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@ReasonCode"].Value = ReasonCode;
                cmd.Parameters["@Memo"].Value = Memo;
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

        static public void sp_PPAYMENT_ADDBILLBACKCREDIT(String SupplierID, String InvoiceNumber, Decimal Amount, String Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_ADDBILLBACKCREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@Memo"].Value = Memo;
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

        static public void sp_PPAYMENT_ADDDEBIT(String SupplierID, String InvoiceNumber, Decimal Amount
            , String ReasonCode
            , String Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_ADDDEBIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Amount", SqlDbType.VarChar);
                cmd.Parameters.Add("@ReasonCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@ReasonCode"].Value = ReasonCode;
                cmd.Parameters["@Memo"].Value = Memo;
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

        static public void sp_PPAYMENT_ADDTERMCREDIT(String SupplierID, String InvoiceNumber, Decimal Amount, String Memo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_ADDTERMCREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@Amount", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters["@Memo"].Value = Memo;
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

        static public void sp_POPREPARE_ADDMEMO(String SupplierID, String Brand, String ProductID, String Memo, String BasedDate, DateTime StartDate, DateTime EndDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_POPREPARE_ADDMEMO";
                cmd.CommandType = CommandType.StoredProcedure;

         
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Brand", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Memo", SqlDbType.VarChar);
                cmd.Parameters.Add("@BasedDate", SqlDbType.VarChar);
                cmd.Parameters.Add("@StartDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@EndDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@Brand"].Value = Brand;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Memo"].Value = Memo;
                cmd.Parameters["@BasedDate"].Value = BasedDate;
                cmd.Parameters["@StartDate"].Value = StartDate;
                cmd.Parameters["@EndDate"].Value = EndDate;
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

        static public PORDER sp_GET_PORDERLineByROWID(int ROWID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_GET_PORDERLineByROWID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ROWID", SqlDbType.Int);

                cmd.Parameters["@ROWID"].Value = ROWID;

                connection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                Entities.PORDER pORDER = new Entities.PORDER();

                if (sqlDataReader.Read())
                {
                    pORDER.PORDERNumber = sqlDataReader["POHNUM_0"].ToString().Trim();
                    pORDER.ProductBCS = sqlDataReader["ITMREF_0"].ToString().Trim();
                    pORDER.Description = sqlDataReader["ProductDesc"].ToString().Trim();
                    pORDER.PackSize = sqlDataReader["StrPackSize"].ToString().Trim();
                    pORDER.Unit = sqlDataReader["SUnitM"].ToString().Trim();
                    pORDER.Qty = Convert.ToDecimal(sqlDataReader["OrderQty"].ToString().Trim());
                    pORDER.InnerCase = Convert.ToDecimal(sqlDataReader["CSInner"].ToString().Trim());
                    pORDER.GrossPrice = Convert.ToDecimal(sqlDataReader["UnitPr"].ToString().Trim());
                    pORDER.EDLP = Convert.ToDecimal(sqlDataReader["EDLP"].ToString().Trim());
                    pORDER.EDLPP = Convert.ToDecimal(sqlDataReader["EDLPP"].ToString().Trim());
                    pORDER.TermPromo = Convert.ToDecimal(sqlDataReader["TermPromo"].ToString().Trim());
                    pORDER.TermPromoP = Convert.ToDecimal(sqlDataReader["TermPromoP"].ToString().Trim());
                    pORDER.NetPrice = Convert.ToDecimal(sqlDataReader["NetPrice"].ToString().Trim());
                    pORDER.OrderAmount = Convert.ToDecimal(sqlDataReader["OrderAmount"].ToString().Trim());
                    pORDER.ExpirationDate = Convert.ToDateTime("1900-01-01");
                    pORDER.ReceivingSite = sqlDataReader["ReceivingSite"].ToString().Trim();
                    pORDER.ROWID = Convert.ToInt32(sqlDataReader["ROWID"].ToString().Trim());
                    pORDER.Location = sqlDataReader["Location"].ToString().Trim();

                    //MessageBox.Show(pORDER.ROWID.ToString());
                }
                return pORDER;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                Entities.PORDER pORDER = new Entities.PORDER();
                return pORDER;
            }
            finally
            {
                connection.Close();
            }
        }

        static public void sp_PPAYMENTT_INSERT_INVOICE(String PaymentType, String SupplierID, String InvoiceNumber, Decimal InvoiceAmount, String NewPAYXXNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENTT_INSERT_INVOICE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@InvoiceAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewPAYXXNumber", SqlDbType.VarChar);

                cmd.Parameters["@PaymentType"].Value = PaymentType;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;
                cmd.Parameters["@InvoiceAmount"].Value = InvoiceAmount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewPAYXXNumber"].Value = NewPAYXXNumber;

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

        static public void sp_PPAYMENTT_INSERT_CREDIT(String PaymentType, String SupplierID, String PINNumber, String CreditNumber, Decimal CreditAmount, String NewPAYXXNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENTT_INSERT_CREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@PINNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@CreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewPAYXXNumber", SqlDbType.VarChar);

                cmd.Parameters["@PaymentType"].Value = PaymentType;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@PINNumber"].Value = PINNumber;
                cmd.Parameters["@CreditNumber"].Value = CreditNumber;
                cmd.Parameters["@CreditAmount"].Value = CreditAmount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewPAYXXNumber"].Value = NewPAYXXNumber;

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

        static public void sp_PPAYMENTT_INSERT_DEBIT(String PaymentType, String SupplierID, String PINNumber, String DebitNumber, Decimal DebitAmount, String NewPAYXXNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENTT_INSERT_DEBIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@PINNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DebitNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@DebitAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewPAYXXNumber", SqlDbType.VarChar);

                cmd.Parameters["@PaymentType"].Value = PaymentType;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@PINNumber"].Value = PINNumber;
                cmd.Parameters["@DebitNumber"].Value = DebitNumber;
                cmd.Parameters["@DebitAmount"].Value = DebitAmount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewPAYXXNumber"].Value = NewPAYXXNumber;

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

        static public void sp_PPAYMENTT_INSERT_TERMCREDIT(String PaymentType, String SupplierID, String PINNumber, String TermCreditNumber, Decimal TermCreditAmount, String NewPAYXXNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENTT_INSERT_TERMCREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@PINNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@TermCreditNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@TermCreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewPAYXXNumber", SqlDbType.VarChar);

                cmd.Parameters["@PaymentType"].Value = PaymentType;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@PINNumber"].Value = PINNumber;
                cmd.Parameters["@TermCreditNumber"].Value = TermCreditNumber;
                cmd.Parameters["@TermCreditAmount"].Value = TermCreditAmount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@NewPAYXXNumber"].Value = NewPAYXXNumber;

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

        static public void sp_PPAYMENTT(String PaymentType, String SupplierID, String CheckNumber, DateTime AccountingDate, Decimal PaymentAmount, String Bank, String Site, String NewPAYXXNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENTT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheckNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@PaymentAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@CreateUser", SqlDbType.VarChar);
                cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewPAYXXNumber", SqlDbType.VarChar);
                
                cmd.Parameters["@PaymentType"].Value = PaymentType;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@CheckNumber"].Value = CheckNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@PaymentAmount"].Value = PaymentAmount;
                cmd.Parameters["@CreateUser"].Value = GATE.userID;
                cmd.Parameters["@Bank"].Value = Bank;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@NewPAYXXNumber"].Value = NewPAYXXNumber;
                
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

        static public void sp_PPAYMENT(String NewPAYNumber, 
            String NewBMWNumber, 
            String PaymentType, String SupplierID, String CheckNumber, DateTime AccountingDate, Decimal PaymentAmount, String Site, String Bank)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewPAYNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewBMWNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheckNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@PaymentAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);

                cmd.Parameters["@NewPAYNumber"].Value = NewPAYNumber;
                cmd.Parameters["@NewBMWNumber"].Value = NewBMWNumber;
                cmd.Parameters["@PaymentType"].Value = PaymentType;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@CheckNumber"].Value = CheckNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@PaymentAmount"].Value = PaymentAmount;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@Bank"].Value = Bank;
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

        static public void sp_PPAYMENTD(String NewPAYNumber, String NewBMWNumber, String PINVNumber, String PaymentType, String SupplierID, String CheckNumber, DateTime AccountingDate, Decimal PaymentAmount, String Site, String Bank)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENTD";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewPAYNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewBMWNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@PINVNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@PaymentType", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CheckNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@AccountingDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@PaymentAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@Site", SqlDbType.VarChar);
                cmd.Parameters.Add("@Bank", SqlDbType.VarChar);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);

                cmd.Parameters["@NewPAYNumber"].Value = NewPAYNumber;
                cmd.Parameters["@NewBMWNumber"].Value = NewBMWNumber;
                cmd.Parameters["@PINVNumber"].Value = PINVNumber;
                cmd.Parameters["@PaymentType"].Value = PaymentType;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
                cmd.Parameters["@CheckNumber"].Value = CheckNumber;
                cmd.Parameters["@AccountingDate"].Value = AccountingDate;
                cmd.Parameters["@PaymentAmount"].Value = PaymentAmount;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@Bank"].Value = Bank;
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

        static public void sp_PPAYMENTD_TERMCREDIT(String NewPAYNumber, String NewBMWNumber, String TermCreditPONumber, String TermCreditNumber, Decimal TermCreditAmount, String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENTD_TERMCREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewPAYNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@NewBMWNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@TermCreditPONumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@TermCreditNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@TermCreditAmount", SqlDbType.Decimal);
                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);


                cmd.Parameters["@NewPAYNumber"].Value = NewPAYNumber;
                cmd.Parameters["@NewBMWNumber"].Value = NewBMWNumber;
                cmd.Parameters["@TermCreditPONumber"].Value = TermCreditPONumber;
                cmd.Parameters["@TermCreditNumber"].Value = TermCreditNumber;
                cmd.Parameters["@TermCreditAmount"].Value = TermCreditAmount;
                cmd.Parameters["@SupplierID"].Value = SupplierID;
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

        static public void sp_PORDER_ConfirmCheckUncheck(String Action, String PONumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PORDER_ConfirmCheckUncheck";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Action", SqlDbType.VarChar);
                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);

                cmd.Parameters["@Action"].Value = Action;
                cmd.Parameters["@PONumber"].Value = PONumber;

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

        static public void sp_POPrepare_VOID(String POPNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_POPrepare_VOID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@POPNumber", SqlDbType.VarChar);

                cmd.Parameters["@POPNumber"].Value = POPNumber;

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

        static public void sp_LIST_Product(DataGridView _dataGridView, String ProductID, String Brand, String ProductDesc, String inactive, String Pause)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                //cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_LIST_Product";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@ProductDesc", SqlDbType.VarChar);
                cmd.Parameters.Add("@Brand", SqlDbType.VarChar);
                cmd.Parameters.Add("@Category", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@Pause", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@ProductDesc"].Value = ProductDesc;
                cmd.Parameters["@Brand"].Value = Brand;
                cmd.Parameters["@Category"].Value = "";
                cmd.Parameters["@Status"].Value = inactive;
                cmd.Parameters["@Pause"].Value = Pause;
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

        static public void sp_LIST_SUPPLIER(DataGridView _dataGridView, String SupplierCode, String SupplierName, String Status, String SupplierCategory, String PaymentTerm)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                //cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_LIST_SUPPLIER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierName", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                cmd.Parameters.Add("@SupplierCategory", SqlDbType.VarChar);
                cmd.Parameters.Add("@PaymentTerm", SqlDbType.VarChar);

                cmd.Parameters["@SupplierCode"].Value = SupplierCode;
                cmd.Parameters["@SupplierName"].Value = SupplierName;
                cmd.Parameters["@Status"].Value = Status;
                cmd.Parameters["@SupplierCategory"].Value = "";
                cmd.Parameters["@PaymentTerm"].Value = "";

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

        static public void sp_LIST_CUSTOMER(DataGridView _dataGridView, String CustomerID, String CustomerName, String CustomerStatus, String CustomerBranch, String CustomerPaymentTerm, String ZIPCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                //cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_LIST_CUSTOMER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerName", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerStatus", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerBranch", SqlDbType.VarChar);
                cmd.Parameters.Add("@CustomerPaymentTerm", SqlDbType.VarChar);
                cmd.Parameters.Add("@ZIPCode", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@CustomerName"].Value = CustomerName;
                cmd.Parameters["@CustomerStatus"].Value = CustomerStatus;
                cmd.Parameters["@CustomerBranch"].Value = "";
                cmd.Parameters["@CustomerPaymentTerm"].Value = "";
                cmd.Parameters["@CustomerPaymentTerm"].Value = "";
                cmd.Parameters["@ZIPCode"].Value = ZIPCode;

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

        static public void sp_LIST_COMPANY(DataGridView _dataGridView, String CompanyCode, String CompanyName, String CompanyStatus)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                //cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_LIST_COMPANY";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CompanyCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar);
                cmd.Parameters.Add("@CompanyStatus", SqlDbType.VarChar);

                cmd.Parameters["@CompanyCode"].Value = CompanyCode;
                cmd.Parameters["@CompanyName"].Value = CompanyName;
                cmd.Parameters["@CompanyStatus"].Value = CompanyStatus;
                
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

        static public void sp_LIST_AddressCategory(DataGridView _dataGridView, String ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                //cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection4;
                cmd.CommandText = "dbo.sp_LIST_AddressCategory";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                
                cmd.Parameters["@ID"].Value = ID;
                
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


        static public void sp_UPDATE_BrandMemo(String BrandName, String BrandCode, String BrandMemo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_UPDATE_BrandMemo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandName", SqlDbType.VarChar);
                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@BrandMemo", SqlDbType.VarChar);

                cmd.Parameters["@BrandName"].Value = BrandName;
                cmd.Parameters["@BrandCode"].Value = BrandCode;
                cmd.Parameters["@BrandMemo"].Value = BrandMemo;

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

        static public void sp_LIST_PRODUCT_Supplier(DataGridView _dataGridView, String ProductID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_LIST_PRODUCT_Supplier";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                
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

        static public void sp_LIST_BRAND(DataGridView _dataGridView, String BrandCode, String BrandName, String Status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                //cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_LIST_BRAND";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@BrandName", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);

                cmd.Parameters["@BrandCode"].Value = BrandCode;
                cmd.Parameters["@BrandName"].Value = BrandName;
                cmd.Parameters["@Status"].Value = Status;
                
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

        static public void sp_STOJOU_History(DataGridView _dataGridView, DateTime FromDate, DateTime ToDate, string ProductID, string Site, string Status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_STOJOU_History";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Site", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Status", SqlDbType.NVarChar);

                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@ProductID"].Value = ProductID;
                cmd.Parameters["@Site"].Value = Site;
                cmd.Parameters["@Status"].Value = Status;

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
        static public void txt_INVENTORY(string ProductID, TextBox PHYWH, TextBox PHYNY, TextBox GLOBAL, TextBox DETAIL)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT PHYQTYWH,PHYQTY,GLOALL,DETAILED ";
                sql = sql + "FROM Product WITH(NOLOCK) ";
                sql = sql + "WHERE ProductID ='" + ProductID.Trim() + "' and IsInActive = 0";
                sql = sql + "";

                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PHYWH.Text = (reader[0].ToString().Trim());
                    PHYNY.Text = (reader[1].ToString().Trim());
                    GLOBAL.Text = (reader[2].ToString().Trim());
                    DETAIL.Text = (reader[3].ToString().Trim());
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

        static public String sp_CREATE_NewPONumber()
        {
            String results = "";
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_CREATE_NewPONumber";
                cmd.CommandType = CommandType.StoredProcedure;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    results = reader[0].ToString();
                }
                return results;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return results;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public void cbox_Brand(ComboBox cbo_brand)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [BrandCode] ";
                sql = sql + "FROM [Brand] WITH(NOLOCK) ";
                sql = sql + "where BrandStatus = 'Active' ";
                sql = sql + "Order by BrandCode ";
                //sql = sql + "WHERE BrandName = '" + cbo_brand + "'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_brand.Items.Add(reader[0].ToString().Trim());
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

        static public void sp_PO_SalesDepletion(DataGridView _dataGridView, String Brand, DateTime FromDate, DateTime ToDate, String Text)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PO_SalesReport";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Brand", SqlDbType.VarChar);
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Text", SqlDbType.VarChar);

                cmd.Parameters["@Brand"].Value = Brand;
                cmd.Parameters["@FromDate"].Value = FromDate;
                cmd.Parameters["@ToDate"].Value = ToDate;
                cmd.Parameters["@Text"].Value = Text;

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

            //try
            //{
            //    string sql = ;
            //    sql =

            //        SELECT AA.NUM_0 AS INVOICE_NO, AA.INVDAT_0 AS DATE,AA.REP1_0 AS SALEREP,AA.TSICOD_0 AS BRAND, F.BPRNAM_0 AS CUSTOMER,AA.ITMREF_0 AS ITEM;
            //    sql = sql +  ,AA.ITMDES1_0 AS DESCRIPTION,AA.StrPackSize,AA.QTY_0,AA.AMTNOTLIN_0 AS SALES_AMOUNT,F.BPAADDLIG_0, F.BPYCTY_0, F.BPYSAT_0, F.BPYPOSCOD_0;
            //    sql = sql + FROM(SELECT A.NUM_0, A.INVDAT_0, A.BPCINV_0, B.TSICOD_0, A.ITMREF_0, B.ITMDES1_0, B.ITMDES2_0, A.QTY_0, A.AMTNOTLIN_0, A.REP1_0, StrPackSize;
            //    sql = sql + FROM(SELECT NUM_0, INVDAT_0, BPCINV_0, ITMREF_0, QTY_0, AMTNOTLIN_0, REP1_0, P.StrPackSize FROM SINVOICED A;
            //    sql = sql + LEFT OUTER JOIN Product P ON A.ITMREF_0 = P.ProductID and isinactive = 0;
            //    sql = sql + WHERE INVDAT_0 = ' + FromDate.ToShortDateString() + ' AND INVDAT_0  ' + (ToDate.AddDays(1)).ToShortDateString() + ';
            //    sql = sql + AND A.ITMREF_0 IN(;
            //    for (int i = 0; i  SelectedItem; i++)
            //        {
            //        sql = sql + ' + array[i].ToString() + ';
            //        if (i(SelectedItem - 1)) sql = sql + ,;
            //    }
            //    sql = sql + ) ) A LEFT JOIN ITMMASTER B ON A.ITMREF_0 = B.ITMREF_0;
            //    sql = sql + GROUP BY A.NUM_0, A.INVDAT_0, A.BPCINV_0, A.ITMREF_0, StrPackSize, B.TSICOD_0, B.ITMDES1_0, B.ITMDES2_0, A.QTY_0, A.AMTNOTLIN_0, A.REP1_0;
            //    sql = sql +  ) AA LEFT JOIN SINVOICE F ON F.NUM_0 = AA.NUM_0 AND F.BPR_0 = AA.BPCINV_0;
            //    sql = sql + GROUP BY AA.NUM_0,AA.INVDAT_0,AA.REP1_0,AA.TSICOD_0, F.BPRNAM_0,AA.ITMREF_0,AA.StrPackSize,AA.ITMDES1_0,AA.QTY_0,AA.AMTNOTLIN_0,F.BPAADDLIG_0, F.BPYCTY_0, F.BPYSAT_0, F.BPYPOSCOD_0 ORDER BY DATE;
            //    sql = sql + ;

            //    connection.Open();

            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
            //    DataTable dataTable = new DataTable();
            //    dataAdapter.Fill(dataTable);
            //    _dataGridView.DataSource = dataTable;

            //}
            //catch (SqlException exception)
            //{
            //    MessageBox.Show(exception.ToString());
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }

        static public void sp_GET_BrandName(ComboBox cbo_brand, TextBox txt_BrandName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection4;
                cmd.CommandText = "dbo.sp_GET_BrandName";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);
                cmd.Parameters["@BrandCode"].Value = cbo_brand.Text.Trim();

                connection4.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txt_BrandName.Text = reader[0].ToString();
                }
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

        static public void sp_Get_ItemForBrand(DataGridView _dataGridView, String BrandCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                //cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_Get_ItemForBrand";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BrandCode", SqlDbType.VarChar);
                //cmd.Parameters.Add("@ItemID", SqlDbType.VarChar);

                cmd.Parameters["@BrandCode"].Value = BrandCode;
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

        static public void sp_WMS_GOODSRECEIPT(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_WMS_GOODSRECEIPT";
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

        static public void sp_WMS_GOODSRECEIPTD(DataGridView _dataGridView, string PONumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_WMS_GOODSRECEIPTD";
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

        static public void sp_WMS_GOODSRECEIPT_COMPLETE(string PONumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_WMS_GOODSRECEIPT_COMPLETE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);

                cmd.Parameters["@PONumber"].Value = PONumber;

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

        static public void sp_WMS_SELECT_SHIPMENTRETURN(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_WMS_SELECT_SHIPMENTRETURN";
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

        static public void sp_WMS_SELECT_SHIPMENTRETURND(DataGridView _dataGridView, string DeliveryNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_WMS_SELECT_SHIPMENTRETURND";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@DeliveryNumber", SqlDbType.VarChar);

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

        static public void cbo_CustomerID(ComboBox cbo_CustomerID, String SaleRep)
        {
            try
            {
                cbo_CustomerID.Items.Clear();
                string sql = "";
                if(SaleRep.Equals("Vendor") || SaleRep.Equals("Mail"))
                {
                    sql = sql + "SELECT BPCNUM_0 ";
                    sql = sql + "FROM BPCUSTOMER ";
                    sql = sql + "Order by BPCNUM_0 ";
                    sql = sql + "";
                }
                else
                {
                    sql = sql + "SELECT BPCNUM_0 ";
                    sql = sql + "FROM BPCUSTOMER ";
                    sql = sql + " WHERE REP_0 = '" + SaleRep + "' ";
                    sql = sql + "Order by BPCNUM_0 ";
                    sql = sql + "";
                }
                
                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_CustomerID.Items.Add(reader[0].ToString().Trim());
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

        static public void cbo_getAllDeliveryNumber(ComboBox cbo_deliveryNumber, String SaleRep, String DeliveryNumber)
        {
            try
            {
                cbo_deliveryNumber.Items.Clear();
                cbo_deliveryNumber.Items.Add("");
                string sql = "";
                sql = sql + "select ORIDOCNUM_0 AS DeliveryNumber ";
                sql = sql + " from sinvoice WITH(NOLOCK) ";
                sql = sql + " where ORIDOCNUM_0 LIKE 'DBCS%' AND ORIDOCNUM_0 LIKE '%" + DeliveryNumber + "%' ";
                sql = sql + " and AMTATI_0 - (AMTTAXUSA_0 + BASDEP_0) > 0 ";
                sql = sql + " Order by ORIDOCNUM_0 desc ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_deliveryNumber.Items.Add(reader[0].ToString().Trim());
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

        static public void DTP_getDeliveryDateFromNumber(DateTimePicker dateTimePickerDelivery, String DeliveryNumber)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT CreateTime";
                sql = sql + " FROM Delivery WITH(NOLOCK) ";
                sql = sql + " WHERE DeliveryNumber ='" + DeliveryNumber+"'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dateTimePickerDelivery.Value = Convert.ToDateTime(reader[0]);
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

        static public void sp_CustomerMapListBySalesRep(DataGridView _dataGridView, String Text)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_CUSTMAPTEST";
                //cmd.CommandText = "dbo.sp_CustomerMapListBySalesRep";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Text", SqlDbType.VarChar);

                cmd.Parameters["@Text"].Value = Text;

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

        static public void sp_WMS_SELECT_SHIPMENTRETURNROUTER(DataGridView _dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_WMS_SELECT_SHIPMENTRETURNROUTER";
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

        static public void sp_GET_PONumberBySupplierID(ComboBox cbo_poNumber, String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_PONumberBySupplierID";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_poNumber.Items.Add(reader[0].ToString().Trim());
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

        static public void sp_NS_HISTORY_AP(DataGridView _dataGridView, String SupplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_NS_HISTORY_AP";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar);

                cmd.Parameters["@SupplierID"].Value = SupplierID;

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

        static public void sp_PPAYMENT_DETAIL(DataGridView _dataGridView, String PaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentNumber", SqlDbType.VarChar);

                cmd.Parameters["@PaymentNumber"].Value = PaymentNumber;

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

        static public void cbo_branchCode(ComboBox cbo_branch)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT [CdBranchCode],[BranchName] ";
                sql = sql + "FROM CdBranch ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_branch.Items.Add(reader[0].ToString().Trim());
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

        static public void sp_LIST_SALESREP(DataGridView _dataGridView, String SalesRep, String TeamCode, String RepStatus)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                //cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_LIST_SALESREP";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SalesRep", SqlDbType.VarChar);
                cmd.Parameters.Add("@TeamCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@RepStatus", SqlDbType.VarChar);

                cmd.Parameters["@SalesRep"].Value = SalesRep;
                cmd.Parameters["@TeamCode"].Value = TeamCode;
                cmd.Parameters["@RepStatus"].Value = RepStatus;

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

        static public void sp_PPAYMENT_REVERSE(String PaymentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PPAYMENT_REVERSE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@User", SqlDbType.VarChar);

                cmd.Parameters["@PaymentNumber"].Value = PaymentNumber;
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

        static public void sp_PromotionSchedule_ProductList(DataGridView _dataGridView, string Brand)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PromotionSchedule_ProductList";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Brand", SqlDbType.VarChar);

                cmd.Parameters["@Brand"].Value = Brand;

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

        static public PaymentResolutionObject sp_PaymentResolution_Detail(String InvoiceNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_PaymentResolution_Detail";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar);

                cmd.Parameters["@InvoiceNumber"].Value = InvoiceNumber;

                connection2.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                PaymentResolutionObject paymentResolutionObject = new PaymentResolutionObject();

                if (sqlDataReader.Read())
                {
                    paymentResolutionObject.AD = Convert.ToDecimal(sqlDataReader["AD"].ToString().Trim());
                    paymentResolutionObject.PR = Convert.ToDecimal(sqlDataReader["PR"].ToString().Trim());
                    paymentResolutionObject.EDLP = Convert.ToDecimal(sqlDataReader["EDLP"].ToString().Trim());
                    paymentResolutionObject.BB = Convert.ToDecimal(sqlDataReader["BB"].ToString().Trim());
                    paymentResolutionObject.MD = Convert.ToDecimal(sqlDataReader["MD"].ToString().Trim());
                    paymentResolutionObject.CR = Convert.ToDecimal(sqlDataReader["CR"].ToString().Trim());
                    paymentResolutionObject.D = Convert.ToDecimal(sqlDataReader["D"].ToString().Trim());
                    paymentResolutionObject.DMC = Convert.ToDecimal(sqlDataReader["DMC"].ToString().Trim());
                    paymentResolutionObject.R = Convert.ToDecimal(sqlDataReader["R"].ToString().Trim());
                    paymentResolutionObject.RST = Convert.ToDecimal(sqlDataReader["RST"].ToString().Trim());
                    paymentResolutionObject.ST = Convert.ToDecimal(sqlDataReader["ST"].ToString().Trim());
                    paymentResolutionObject.DA = Convert.ToDecimal(sqlDataReader["DA"].ToString().Trim());
                    paymentResolutionObject.SD = Convert.ToDecimal(sqlDataReader["SD"].ToString().Trim());
                    paymentResolutionObject.SP = Convert.ToDecimal(sqlDataReader["SP"].ToString().Trim());
                    paymentResolutionObject.TC = Convert.ToDecimal(sqlDataReader["TC"].ToString().Trim());
                    paymentResolutionObject.DOH = Convert.ToDecimal(sqlDataReader["DOH"].ToString().Trim());
                    paymentResolutionObject.MISC = Convert.ToDecimal(sqlDataReader["MISC"].ToString().Trim());
                    
                    paymentResolutionObject.AD_m = sqlDataReader["AD_m"].ToString().Trim();
                    paymentResolutionObject.PR_m = sqlDataReader["PR_m"].ToString().Trim();
                    paymentResolutionObject.EDLP_m = sqlDataReader["EDLP_m"].ToString().Trim();
                    paymentResolutionObject.BB_m = sqlDataReader["BB_m"].ToString().Trim();
                    paymentResolutionObject.MD_m = sqlDataReader["MD_m"].ToString().Trim();
                    paymentResolutionObject.CR_m = sqlDataReader["CR_m"].ToString().Trim();
                    paymentResolutionObject.D_m = sqlDataReader["D_m"].ToString().Trim();
                    paymentResolutionObject.DMC_m = sqlDataReader["DMC_m"].ToString().Trim();
                    paymentResolutionObject.R_m = sqlDataReader["R_m"].ToString().Trim();
                    paymentResolutionObject.RST_m = sqlDataReader["RST_m"].ToString().Trim();
                    paymentResolutionObject.ST_m = sqlDataReader["ST_m"].ToString().Trim();
                    paymentResolutionObject.DA_m = sqlDataReader["DA_m"].ToString().Trim();
                    paymentResolutionObject.SD_m = sqlDataReader["SD_m"].ToString().Trim();
                    paymentResolutionObject.SP_m = sqlDataReader["SP_m"].ToString().Trim();
                    paymentResolutionObject.TC_m = sqlDataReader["TC_m"].ToString().Trim();
                    paymentResolutionObject.DOH_m = sqlDataReader["DOH_m"].ToString().Trim();
                    paymentResolutionObject.MISC_m = sqlDataReader["MISC_m"].ToString().Trim();

                }
                return paymentResolutionObject;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                PaymentResolutionObject paymentResolutionObject = new PaymentResolutionObject();
                return paymentResolutionObject;
            }
            finally
            {
                connection2.Close();
            }
        }

        static public string GET_SupplierID_by_PONumber(String PONumber)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT BPSNUM_0 ";
                sql = sql + "FROM PORDER ";
                sql = sql + "WHERE POHNUM_0 = '" + PONumber + "' ";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string SupplierID = reader[0].ToString();
                    return SupplierID;
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

        static public void sp_LIST_PaymentTerm(DataGridView _dataGridView, String PaymentTerm, String Description, String Status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                //cmd.CommandTimeout = TimeoutTime;
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_LIST_PaymentTerm";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PaymentTerm", SqlDbType.VarChar);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar);
                cmd.Parameters.Add("@Status", SqlDbType.VarChar);

                cmd.Parameters["@PaymentTerm"].Value = PaymentTerm;
                cmd.Parameters["@Description"].Value = Description;
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

        static public string sp_POPrepare_GET_LeadTime(String POPNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_POPrepare_GET_LeadTime";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@POPNumber", SqlDbType.VarChar);

                cmd.Parameters["@POPNumber"].Value = POPNumber;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string LeadTime = reader["LeadTime"].ToString();
                    return LeadTime;
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

        static public string sp_POPrepare_GET_LeadTime(String Type, String POPNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_POPrepare_GET_LeadTime";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@POPNumber", SqlDbType.VarChar);

                cmd.Parameters["@POPNumber"].Value = POPNumber;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Value = reader[Type].ToString();
                    return Value;
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

        static public void cbo_DebitNote_Code(String CategoryName, ComboBox cbo_type)
        {
            // MI MISCELLANEOUS ISSUE, MR	MISCELLANEOUS RECEIPT, SC	STOCK STATUS CHANGE
            try
            {
                string sql = "";
                sql = sql + "SELECT TypeCode ";
                sql = sql + "FROM STKReasonCode ";
                sql = sql + "WHERE CategoryCode ='PIN' and CategoryName ='" + CategoryName + "' and Status = 'Active' ";
                sql = sql + "Order by TypeCode";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                cmd.CommandTimeout = TimeoutTime;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_type.Items.Add(reader[0].ToString().Trim());
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
        static public void datepickerPORDER(String PONumber, DateTimePicker OrderDate, DateTimePicker RequireDate)
        {
            try
            {
                string sql = "";
                sql = sql + "SELECT POHNUM_0, ORDDAT_0, EXTRCPDAT1_0 AS RequireDate ";
                sql = sql + "FROM PORDER WITH(NOLOCK) ";
                sql = sql + "Where POHNUM_0 ='"+PONumber+"'";
                sql = sql + "";

                connection2.Open();
                SqlCommand cmd = new SqlCommand(sql, connection2);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    OrderDate.Value = Convert.ToDateTime(reader[1].ToString());
                    RequireDate.Value = Convert.ToDateTime(reader[2].ToString());
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
        static public AddressObject sp_GET_AddressObject2(String CustomerID, String Type)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection2;
                cmd.CommandText = "dbo.sp_GET_AddressObject2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                cmd.Parameters.Add("@Type", SqlDbType.VarChar);

                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@Type"].Value = Type;

                connection2.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                AddressObject address = new AddressObject();
                while (reader.Read())
                {
                    address.ROWID = reader["ROWID"].ToString().Trim();
                    address.AddressCode = reader["AddressCode"].ToString().Trim();
                    address.Address1 = reader["Address1"].ToString().Trim();
                    address.Address2 = reader["Address2"].ToString().Trim();
                    address.AddressCity = reader["AddressCity"].ToString().Trim();
                    address.AddressState = reader["AddressState"].ToString().Trim();
                    address.AddressPostalCode = reader["AddressPostalCode"].ToString().Trim();
                    address.AddressEmail = reader["AddressEmail"].ToString().Trim();
                    address.AddressTel1 = reader["AddressTel1"].ToString().Trim();
                    address.AddressTel2 = reader["AddressTel2"].ToString().Trim();
                    address.AddressFax = reader["AddressFax"].ToString().Trim();
                    address.Latitude = reader["Latitude"].ToString().Trim();
                    address.Longitude = reader["Longitude"].ToString().Trim();
                }
                return address;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                AddressObject address = new AddressObject();
                return address;
            }
            finally
            {
                connection2.Close();
            }
        }

        //this entire method did not use to be here
        static public string sp_getSupplierInfoWithSupplierID(String supplierID) //이거 추가함: PO에서 Supplier ID에 empty string 아니면 존제하지 않는 커스터머 이름을 넣고 create 눌렀을씨 안되게끔 막는 method
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_getSupplierInfoWithSupplierID"; 
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@supplierID", SqlDbType.VarChar);

                cmd.Parameters["@supplierID"].Value = supplierID;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    string Value = reader["supplierID"].ToString();
                    //string Value = reader[0].ToString();
                    //string Value = reader[Type].ToString();
                    return Value;
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

        static public void sp_PO_ETA_DATE_UPDATE(String POHNUMBER, DateTime POExpectedRcptDate, int RcptDateFlag)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PO_ETA_DATE_UPDATE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@POHNUMBER", SqlDbType.VarChar);
                cmd.Parameters.Add("@POExpectedRcptDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@RcptDateFlag", SqlDbType.Int);
                cmd.Parameters["@POHNUMBER"].Value = POHNUMBER;
                cmd.Parameters["@RcptDateFlag"].Value = RcptDateFlag;
                cmd.Parameters["@POExpectedRcptDate"].Value = POExpectedRcptDate;

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

        static public void sp_PO_CONFIRMED_DATE_UPDATE(String POHNUMBER, DateTime POConfirmedRcptDate, int RcptDateFlag)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_PO_CONFIRMED_DATE_UPDATE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@POHNUMBER", SqlDbType.VarChar);
                cmd.Parameters.Add("@POConfirmedRcptDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@RcptDateFlag", SqlDbType.Int);
                cmd.Parameters["@POHNUMBER"].Value = POHNUMBER;
                cmd.Parameters["@RcptDateFlag"].Value = RcptDateFlag;
                cmd.Parameters["@POConfirmedRcptDate"].Value = POConfirmedRcptDate;

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

        static public void sp_POCalendarREAL(DataGridView dgv, DateTime Date)
        { //for first working PO Calendar
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_POCalendarREAL2";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Date", SqlDbType.VarChar);
                cmd.Parameters["@Date"].Value = Date;
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

        static public void sp_PoCalendarREALDetail(DataGridView dgv, String PONumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_POCalendarREALDetail";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
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

        static public void sp_UPDATE_SUPPLIER_LEADTIME(String SupplierCode, int LeadTime)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_UPDATE_SUPPLIER_LEADTIME";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SupplierCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@LeadTime", SqlDbType.Int);

                cmd.Parameters["@SupplierCode"].Value = SupplierCode;
                cmd.Parameters["@LeadTime"].Value = LeadTime;
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

        static public void sp_AffiliatedPO(DataGridView dgv, String productID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_AffiliatedPO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ProductID", SqlDbType.VarChar);
                cmd.Parameters["@ProductID"].Value = productID;
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            } catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            } finally
            {
                connection.Close();
            }
        }

        static public void sp_UPDATE_PRECEIPTD_POCALC(
            Decimal SupplierInvoiceQty, 
            //Decimal BCSGrossPrice, 
            Decimal SupplierGrossPrice, 
            //Decimal BCSEDLP, 
            Decimal SupplierEDLP, 
            //Decimal BCSEDLPP, 
            Decimal SupplierEDLPP, 
            //Decimal BCSTermPromo, 
            Decimal SupplierTermPromo, 
            //Decimal BCSTermPromoP, 
            Decimal SupplierTermPromoP, 
            Decimal poplin_0,
            String PONumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "dbo.sp_UPDATE_PRECEIPTD_POCALC";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SupplierInvoiceQty", SqlDbType.Decimal);
                cmd.Parameters.Add("@SupplierGrossPrice", SqlDbType.Decimal);
                cmd.Parameters.Add("@SupplierEDLP", SqlDbType.Decimal);
                cmd.Parameters.Add("@SupplierEDLPP", SqlDbType.Decimal);
                cmd.Parameters.Add("@SupplierTermPromo", SqlDbType.Decimal);
                cmd.Parameters.Add("@SupplierTermPromoP", SqlDbType.Decimal);
                cmd.Parameters.Add("@poplin_0", SqlDbType.Decimal);
                cmd.Parameters.Add("@PONumber", SqlDbType.VarChar);

                cmd.Parameters["@SupplierInvoiceQty"].Value = SupplierInvoiceQty;
                cmd.Parameters["@SupplierGrossPrice"].Value = SupplierGrossPrice;
                cmd.Parameters["@SupplierEDLP"].Value = SupplierEDLP;
                cmd.Parameters["@SupplierEDLPP"].Value = SupplierEDLPP;
                cmd.Parameters["@SupplierTermPromo"].Value = SupplierTermPromo;
                cmd.Parameters["@SupplierTermPromoP"].Value = SupplierTermPromoP;
                cmd.Parameters["@poplin_0"].Value = poplin_0;
                cmd.Parameters["@PONumber"].Value = PONumber;

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
    }
}
