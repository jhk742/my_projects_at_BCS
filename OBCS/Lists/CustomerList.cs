using OBCS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Data.SqlClient;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using Location = OBCS.Entities.Location;

namespace OBCS.Lists
{
    public partial class CustomerList : Form
    {

        GMarkerGoogle marker;
        GMarkerGoogle BCSmarker;
        GMapOverlay markerOverlay;

        double BCSlatitude = 40.742164;
        double BCSlongitude = -73.931789;

        String StaticZip = "";
        String StaticCity = "";
        String StaticState = "";
        String StaticAddress = "";
        String StaticAddressMemo = "";

        String StaticZipbill = "";
        String StaticCitybill = "";
        String StaticStatebill = "";
        String StaticAddressbill = "";
        String StaticAddressMemobill = "";


        static HttpClient client = new HttpClient();
        public CustomerList()
        {
            InitializeComponent();
            BCS_Setting();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            
            try
            {
                grid_customer_Init();

                txt_ZIP.Enabled = false;
                cbo_City.Enabled = false;
                cbo_State.Enabled = false;
                txt_Address.Enabled = false;
                txt_AddressMemo.Enabled = false;
                btn_ZIP.Enabled = false;
                btn_Address.Enabled = false;

                txt_ZIPbill.Enabled = false;
                cbo_Citybill.Enabled = false;
                cbo_Statebill.Enabled = false;
                txt_Addressbill.Enabled = false;
                txt_AddressMemobill.Enabled = false;
                btn_ZIPbill.Enabled = false;
                btn_Addressbill.Enabled = false;

                if (connSalesOrder.sp_UserCheck("CUSTOMERLIST_ADDRESS").Equals("1"))
                {
                    //MessageBox.Show("Sorry, You require permission from Administrators to perform this action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                    //btn_Edit.Visible = true;

                    txt_ZIP.Enabled = true;
                    cbo_City.Enabled = true;
                    cbo_State.Enabled = true;
                    txt_Address.Enabled = true;
                    txt_AddressMemo.Enabled = true;
                    btn_ZIP.Enabled = true;
                    btn_Address.Enabled = true;

                    txt_ZIPbill.Enabled = true;
                    cbo_Citybill.Enabled = true;
                    cbo_Statebill.Enabled = true;
                    txt_Addressbill.Enabled = true;
                    txt_AddressMemobill.Enabled = true;
                    btn_ZIPbill.Enabled = true;
                    btn_Addressbill.Enabled = true;
                }

                String SearchCustomerID = txt_searchCustomerID.Text.Trim();
                String SearchCustomerName = txt_searchCustomerName.Text.Trim();
                String SearchCustomerBranch = "";
                String SearchCustomerPaymentTerm = "";
                String SearchCustomerStatus = "";
                String SearchZIPCode = txt_zipCode.Text.Trim();

                if (cbx_inactive.Checked)
                {
                    SearchCustomerStatus = "ALL";
                }
                else
                {
                    SearchCustomerStatus = "Active";
                }
                connPO.sp_LIST_CUSTOMER(grid_customer, SearchCustomerID, SearchCustomerName, SearchCustomerStatus, SearchCustomerBranch, SearchCustomerPaymentTerm, SearchZIPCode);

                cbo_CustomerStatus.Items.Clear();
                cbo_CustomerStatus.Items.Add("Active");
                cbo_CustomerStatus.Items.Add("Inactive");

                cbo_CustomerBranch.Items.Clear();
                cbo_CustomerBranch.Items.Add("");
                cbo_CustomerBranch.Items.Add("BCS");
                cbo_CustomerBranch.Items.Add("NYC");
                cbo_CustomerBranch.Items.Add("HYD");
                cbo_CustomerBranch.Items.Add("CFI");
                cbo_CustomerBranch.Items.Add("NTM");
                cbo_CustomerBranch.Items.Add("NYF");

                cbo_labelType.Items.Clear();
                cbo_labelType.Items.Add("Dr.SNACK");
                cbo_labelType.Items.Add("Dr.SNACK2");
                cbo_labelType.Items.Add("AGATA & VALENTINA");
                cbo_labelType.Items.Add("HUACHAO FOOD");
                cbo_labelType.Items.Add("NUT MAN");
                cbo_labelType.Items.Add("Goodies");

                cbo_paymentTerm.Items.Clear();
                connSalesOrder.sp_GET_PaymentTerm(cbo_paymentTerm);

                cbo_salesRep.Items.Clear();
                cbo_salesRep.Items.Add("");
                connSalesOrder.sp_GET_SalesRep(cbo_salesRep);

                cbo_AddressCode.Items.Add("BILL");
                cbo_AddressCode.Items.Add("SHIP");
                cbo_AddressCode.Text = "SHIP";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void grid_customer_Init()
        {
            grid_customer.AutoGenerateColumns = false;
            grid_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_customer.ColumnCount = 10; 

            grid_customer.Columns[0].Name = "";
            grid_customer.Columns[0].Visible = false;
            grid_customer.Columns[0].Width = 80;
            grid_customer.Columns[0].MinimumWidth = 80;
            grid_customer.Columns[0].DataPropertyName = "";

            grid_customer.Columns[1].Name = "Branch";
            grid_customer.Columns[1].ReadOnly = true;
            grid_customer.Columns[1].Width = 70;
            grid_customer.Columns[1].MinimumWidth = 70;
            grid_customer.Columns[1].DataPropertyName = "CustomerBranch";

            grid_customer.Columns[2].Name = "Customer ID";
            grid_customer.Columns[2].ReadOnly = true;
            grid_customer.Columns[2].Width = 110;
            grid_customer.Columns[2].MinimumWidth = 110;
            grid_customer.Columns[2].DataPropertyName = "CustomerID";

            grid_customer.Columns[3].Name = "Customer Name";
            grid_customer.Columns[3].ReadOnly = true;
            grid_customer.Columns[3].Width = 300;
            grid_customer.Columns[3].MinimumWidth = 300;
            grid_customer.Columns[3].DataPropertyName = "CustomerName";

            grid_customer.Columns[4].Name = "Sales Rep.";
            grid_customer.Columns[4].ReadOnly = true;
            grid_customer.Columns[4].Width = 60;
            grid_customer.Columns[4].MinimumWidth = 60;
            grid_customer.Columns[4].DataPropertyName = "CustomerSalesRep";

            grid_customer.Columns[5].Name = "Payment Term";
            grid_customer.Columns[5].ReadOnly = true;
            grid_customer.Columns[5].Width = 80;
            grid_customer.Columns[5].MinimumWidth = 80;
            grid_customer.Columns[5].DataPropertyName = "CustomerPaymentTerm";
        
            grid_customer.Columns[6].Name = "Customer Since";
            grid_customer.Columns[6].ReadOnly = true;
            grid_customer.Columns[6].Width = 75;
            grid_customer.Columns[6].MinimumWidth = 75;
            grid_customer.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_customer.Columns[6].DataPropertyName = "CustomerSinceDate";

            grid_customer.Columns[7].Name = "Last Invoice Date";
            grid_customer.Columns[7].ReadOnly = true;
            grid_customer.Columns[7].Width = 75;
            grid_customer.Columns[7].MinimumWidth = 75;
            grid_customer.Columns[7].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_customer.Columns[7].DataPropertyName = "LastInvoiceDate";

            grid_customer.Columns[8].Name = "Ship ZIP Code";
            grid_customer.Columns[8].ReadOnly = true;
            grid_customer.Columns[8].Width = 60;
            grid_customer.Columns[8].MinimumWidth = 60;
            grid_customer.Columns[8].DataPropertyName = "ZIPCode";

            grid_customer.Columns[9].Name = "Status";
            grid_customer.Columns[9].ReadOnly = true;
            grid_customer.Columns[9].Width = 60;
            grid_customer.Columns[9].MinimumWidth = 60;
            grid_customer.Columns[9].DataPropertyName = "CustomerStatus";

            //grid font size custom
            grid_customer.RowTemplate.Height = 20;
            grid_customer.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_customer.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_customer.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

      
        private void grid_customer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbo_salesRep.Text = "";
            cbx_printName.Checked = false;
            cbx_byMarkup.Checked = false;
            cbx_byCustomerPrice.Checked = false;
            cbx_showRetailPrice.Checked = false;
            cbx_printAddress.Checked = false;
            cbx_customLabel.Checked = false;
            cbx_iPadOrder.Checked = false;

            CustomerObject customerObject = new CustomerObject();
            String CustomerID = grid_customer.Rows[e.RowIndex].Cells["Customer ID"].Value.ToString().Trim();
            customerObject = connSalesOrder.sp_GET_CustomerObject(CustomerID);

            if (customerObject.CustomerStatus == "2") // 1: inactive, 2: active
            {
                cbo_CustomerStatus.Text = "Active";
            }
            else
            {
                cbo_CustomerStatus.Text = "Inactive";
            }
            cbo_CustomerBranch.Text = customerObject.CustomerBranch;
            txt_customerID.Text = customerObject.CustomerID;
            txt_customerName.Text = customerObject.CustomerName;
            cbo_paymentTerm.Text = customerObject.CustomerPaymentTerm;
            cbo_salesRep.Text = customerObject.CustomerSalesRep;

            dateTimePicker_CustomerSince.Value = customerObject.CustomerSinceDate;
            txt_customerTaxID.Text = customerObject.CustomerTaxID;
            txt_CustomerBillingCompanyName.Text = customerObject.CustomerBillingCompanyName;
            txt_pickingMemo.Text = customerObject.CustomerPickingMemo;
            txt_customerMemo.Text = customerObject.CustomerMemo;

            cbo_labelType.Text = customerObject.LabelType.ToString();
            txt_nutMarkup.Text = customerObject.CustomerNutMarkup.ToString("N2");

            txt_PCKStoreName.Text = customerObject.PCKStoreName;
            txt_PCKAddress1.Text = customerObject.PCKAddress1;
            txt_PCKAddress2.Text = customerObject.PCKAddress2;
            txt_PCKCity.Text = customerObject.PCKCity;
            txt_PCKState.Text = customerObject.PCKState;
            txt_PCKZIP.Text = customerObject.PCKZIP;

            if (customerObject.NutMarkupPrintName == 1) cbx_printName.Checked = true;
            if (customerObject.NutMarkupByMarkup == 1)  cbx_byMarkup.Checked = true;
            if (customerObject.NutMarkupByCustomerPrice == 1)   cbx_byCustomerPrice.Checked = true;
            if (customerObject.NutMarkupShowRetailPrice == 1)   cbx_showRetailPrice.Checked = true;
            if (customerObject.NutMarkupPrintAddress == 1)  cbx_printAddress.Checked = true;
            if (customerObject.NutMarkupCustomLabel == 1)   cbx_customLabel.Checked = true;

            if (customerObject.AcceptOrder == 1) cbx_iPadOrder.Checked = true;

            btn_save.Enabled = true;
            btn_newSave.Visible = false;
            btn_new.Enabled = true;
            txt_customerID.Enabled = false;

            cbo_AddressCode.Text = "SHIP";
            GetAddress();
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cbo_salesRep.Text.Trim() == "")
            {
                MessageBox.Show("Please select Sales Rep. of the customer."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (cbo_CustomerBranch.Text.Trim() == "")
            {
                MessageBox.Show("Please select a Branch of the customer."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            DialogResult dialogResult = MessageBox.Show("Confirming update customer, "+ txt_customerID.Text.Trim() + " information."
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    CustomerObject customerObject = new CustomerObject();

                    customerObject.CustomerBranch = cbo_CustomerBranch.Text.Trim();

                    customerObject.CustomerStatus = "1";
                    customerObject.NutMarkupPrintName = 0;
                    customerObject.NutMarkupByMarkup = 0;
                    customerObject.NutMarkupByCustomerPrice = 0;
                    customerObject.NutMarkupShowRetailPrice = 0;
                    customerObject.NutMarkupPrintAddress = 0;
                    customerObject.NutMarkupCustomLabel = 0;

                    if (cbo_CustomerStatus.Text.Trim() == "Active") customerObject.CustomerStatus = "2";

                    customerObject.CustomerBranch = cbo_CustomerBranch.Text.Trim();
                    customerObject.CustomerID = txt_customerID.Text.Trim();
                    customerObject.CustomerName = txt_customerName.Text.Trim();
                    customerObject.CustomerPaymentTerm = cbo_paymentTerm.Text.Trim();
                    customerObject.CustomerSalesRep = cbo_salesRep.Text.Trim();

                    customerObject.CustomerSinceDate = dateTimePicker_CustomerSince.Value;
                    customerObject.CustomerTaxID = txt_customerTaxID.Text.Trim();
                    customerObject.CustomerBillingCompanyName = txt_CustomerBillingCompanyName.Text.Trim();
                    customerObject.CustomerPickingMemo = txt_pickingMemo.Text.Trim();
                    customerObject.CustomerMemo = txt_customerMemo.Text.Trim();

                    customerObject.LabelType = cbo_labelType.Text.Trim();
                    customerObject.CustomerNutMarkup = Convert.ToDecimal(txt_nutMarkup.Text.Trim());

                    if (cbx_printName.Checked)   customerObject.NutMarkupPrintName = 1;
                    if (cbx_byMarkup.Checked)    customerObject.NutMarkupByMarkup = 1;
                    if (cbx_byCustomerPrice.Checked)    customerObject.NutMarkupByCustomerPrice = 1;
                    if (cbx_showRetailPrice.Checked)    customerObject.NutMarkupShowRetailPrice = 1;
                    if (cbx_printAddress.Checked)   customerObject.NutMarkupPrintAddress = 1;
                    if (cbx_customLabel.Checked)    customerObject.NutMarkupCustomLabel = 1;

                    customerObject.PCKStoreName = txt_PCKStoreName.Text.Trim();
                    customerObject.PCKAddress1 = txt_PCKAddress1.Text.Trim();
                    customerObject.PCKAddress2 = txt_PCKAddress2.Text.Trim();
                    customerObject.PCKCity = txt_PCKCity.Text.Trim();
                    customerObject.PCKState = txt_PCKState.Text.Trim();
                    customerObject.PCKZIP = txt_PCKZIP.Text.Trim();

                    connSalesOrder.sp_UPDATE_CustomerInfo(customerObject);

                    MessageBox.Show("Customer, " + customerObject.CustomerID + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchCustomer();
                }
                catch
                {
                }
            }
        }
        private void searchCustomer()
        {
            String SearchCustomerID = txt_searchCustomerID.Text.Trim();
            String SearchCustomerName = txt_searchCustomerName.Text.Trim();
            String SearchCustomerBranch = "";// cbo_searchSupplierCategory.Text.Trim();
            String SearchCustomerPaymentTerm = "";//cbo_searchPaymentTerm.Text.Trim();
            String SearchCustomerStatus = "";
            String SearchZIPCode = txt_zipCode.Text.Trim();

            if (cbx_inactive.Checked)
            {
                SearchCustomerStatus = "ALL";
            }
            else
            {
                SearchCustomerStatus = "Active";
            }
            connPO.sp_LIST_CUSTOMER(grid_customer, SearchCustomerID, SearchCustomerName, SearchCustomerStatus, SearchCustomerBranch, SearchCustomerPaymentTerm, SearchZIPCode);
        }

        private void cbx_inactive_CheckedChanged(object sender, EventArgs e)
        {
            searchCustomer();
        }
        private void ClearCustomer()
        {
            txt_customerID.Text = "";
            txt_customerName.Text = "";
            cbo_CustomerBranch.Text = "";
            cbo_CustomerStatus.Text = "Active";
            cbo_paymentTerm.Text = "";
            dateTimePicker_CustomerSince.Value = DateTime.Now.Date;
            txt_customerTaxID.Text = "";
            txt_CustomerBillingCompanyName.Text = "";
            txt_pickingMemo.Text = "";
            txt_customerMemo.Text = "";

            txt_nutMarkup.Text = "0";
            cbx_printName.Checked = false;
            cbx_byMarkup.Checked = false;
            cbx_byCustomerPrice.Checked = false;
            cbx_showRetailPrice.Checked = false;
            cbx_printAddress.Checked = false;
            cbx_customLabel.Checked = false;

            txt_PCKStoreName.Text = "";
            txt_PCKAddress1.Text = "";
            txt_PCKAddress2.Text = "";
            txt_PCKCity.Text = "";
            txt_PCKState.Text = "";
            txt_PCKZIP.Text = "";

        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            BCS_Setting();
            ClearCustomer();
            txt_customerID.Enabled = true;
            btn_save.Enabled = false;
            btn_newSave.Visible = true;
            btn_new.Enabled = false;

            ClearAddress();
            lbl_Addresses.Visible = false;
            panel_Address.Visible = false;
            btn_SaveAddressInfo.Enabled = false;
            cbo_AddressCode.Enabled = false;

        }
        
        private void btn_newSave_Click(object sender, EventArgs e)
        {
            if (txt_customerID.Text.Trim() == "")
            {
                MessageBox.Show("Please insert Customer ID"
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (connSalesOrder.sp_CHECK_NewCustomerID(txt_customerID.Text.Trim()) == true)
            {
                MessageBox.Show("Customer ID already exist."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (cbo_salesRep.Text.Trim() == "")
            {
                MessageBox.Show("Please select Sales Rep of the customer."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (cbo_CustomerBranch.Text.Trim() == "")
            {
                MessageBox.Show("Please select a Branch of the customer."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Save a new customer?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    CustomerObject customerObject = new CustomerObject();

                    customerObject.CustomerBranch = cbo_CustomerBranch.Text.Trim();
                    customerObject.CustomerStatus = "1";
                    customerObject.NutMarkupPrintName = 0;
                    customerObject.NutMarkupByMarkup = 0;
                    customerObject.NutMarkupByCustomerPrice = 0;
                    customerObject.NutMarkupShowRetailPrice = 0;
                    customerObject.NutMarkupPrintAddress = 0;
                    customerObject.NutMarkupCustomLabel = 0;

                    if (cbo_CustomerStatus.Text.Trim() == "Active") customerObject.CustomerStatus = "2";

                    customerObject.CustomerID = txt_customerID.Text.Trim();
                    customerObject.CustomerName = txt_customerName.Text.Trim();
                    customerObject.CustomerPaymentTerm = cbo_paymentTerm.Text.Trim();
                    customerObject.CustomerSalesRep = cbo_salesRep.Text.Trim();

                    customerObject.CustomerSinceDate = dateTimePicker_CustomerSince.Value;
                    customerObject.CustomerTaxID = txt_customerTaxID.Text.Trim();
                    customerObject.CustomerBillingCompanyName = txt_CustomerBillingCompanyName.Text.Trim();
                    customerObject.CustomerPickingMemo = txt_pickingMemo.Text.Trim();
                    customerObject.CustomerMemo = txt_customerMemo.Text.Trim();

                    customerObject.LabelType = cbo_labelType.Text.Trim();
                    customerObject.CustomerNutMarkup = Convert.ToDecimal(txt_nutMarkup.Text.Trim());

                    if (cbx_printName.Checked)  customerObject.NutMarkupPrintName = 1;
                    if (cbx_byMarkup.Checked)   customerObject.NutMarkupByMarkup = 1;
                    if (cbx_byCustomerPrice.Checked)    customerObject.NutMarkupByCustomerPrice = 1;
                    if (cbx_showRetailPrice.Checked)    customerObject.NutMarkupShowRetailPrice = 1;
                    if (cbx_printAddress.Checked)   customerObject.NutMarkupPrintAddress = 1;
                    if (cbx_customLabel.Checked)    customerObject.NutMarkupCustomLabel = 1;

                    customerObject.PCKStoreName = txt_PCKStoreName.Text.Trim();
                    customerObject.PCKAddress1 = txt_PCKAddress1.Text.Trim();
                    customerObject.PCKAddress2 = txt_PCKAddress2.Text.Trim();
                    customerObject.PCKCity = txt_PCKCity.Text.Trim();
                    customerObject.PCKState = txt_PCKState.Text.Trim();
                    customerObject.PCKZIP = txt_PCKZIP.Text.Trim();


                    connSalesOrder.sp_INSERT_NewCustomer(customerObject);

                    MessageBox.Show("Customer, " + customerObject.CustomerID + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchCustomer();
                }
                catch
                {
                    MessageBox.Show("Input all customer information."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            
        }

        bool started = false;
        private void ProductList_Activated(object sender, EventArgs e)
        {
            started = true;
        }
        private void ProductList_Deactivate(object sender, EventArgs e)
        {
            started = false;
        }
        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchCustomer();
            }
        }

        private void txt_customerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_customerID_TextChanged(object sender, EventArgs e)
        {
            txt_customerID.Text = Regex.Replace(txt_customerID.Text, @"\s", "");
        }








        private void BCS_Setting()
        {
            try
            {
                gMapControl1.Overlays.Clear();
                gMapControl1.Refresh();

                gMapControl1.DragButton = MouseButtons.Left;
                gMapControl1.CanDragMap = true;
                gMapControl1.MapProvider = GMapProviders.GoogleMap;
                gMapControl1.Position = new PointLatLng(BCSlatitude, BCSlongitude);

                gMapControl1.MinZoom = 0;
                gMapControl1.MaxZoom = 24;
                gMapControl1.Zoom = 15;
                gMapControl1.AutoScroll = true;

                markerOverlay = new GMapOverlay("Marker");
                marker = new GMarkerGoogle(new PointLatLng(BCSlatitude, BCSlongitude), GMarkerGoogleType.red_dot);
                gMapControl1.Overlays.Add(markerOverlay);
                markerOverlay.Markers.Add(marker);

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error(BCS_Setting)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void MarkTheMap(String Latitude, String Longitude)
        {
            try
            {
                gMapControl1.Overlays.Clear();
                markerOverlay.Clear();
                gMapControl1.Refresh();

                gMapControl1.DragButton = MouseButtons.Left;
                gMapControl1.CanDragMap = true;
                gMapControl1.MapProvider = GMapProviders.GoogleMap;

                gMapControl1.MinZoom = 0;
                gMapControl1.MaxZoom = 24;
                gMapControl1.AutoScroll = true;

                markerOverlay = new GMapOverlay("Marker");
                gMapControl1.Overlays.Add(markerOverlay);

                //BCSmarker = new GMarkerGoogle(new PointLatLng(BCSlatitude, BCSlongitude), GMarkerGoogleType.red_dot);
                //markerOverlay.Markers.Add(BCSmarker);
                //gMapControl1.Position = new PointLatLng(BCSlatitude, BCSlongitude);

                if (txt_LAT.Text.Length != 0 && txt_LONG.Text.Length != 0)
                {
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)), GMarkerGoogleType.green_dot);
                    markerOverlay.Markers.Add(marker);
                    gMapControl1.Position = new PointLatLng(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude));

                }
                gMapControl1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error(MarkTheMap)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MarkTheMap(String shipLatitude, String shipLongitude, String billLatitude, String billLongitude)
        {
            try
            {
                gMapControl1.Overlays.Clear();
                markerOverlay.Clear();
                gMapControl1.Refresh();

                gMapControl1.DragButton = MouseButtons.Left;
                gMapControl1.CanDragMap = true;
                gMapControl1.MapProvider = GMapProviders.GoogleMap;

                gMapControl1.MinZoom = 0;
                gMapControl1.MaxZoom = 24;
                gMapControl1.AutoScroll = true;

                markerOverlay = new GMapOverlay("Marker");
                gMapControl1.Overlays.Add(markerOverlay);

                //BCSmarker = new GMarkerGoogle(new PointLatLng(BCSlatitude, BCSlongitude), GMarkerGoogleType.red_dot);
                //markerOverlay.Markers.Add(BCSmarker);
                //gMapControl1.Position = new PointLatLng(BCSlatitude, BCSlongitude);

                if (txt_LAT.Text.Length != 0 && txt_LONG.Text.Length != 0)
                {
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(billLatitude), Convert.ToDouble(billLongitude)), GMarkerGoogleType.blue_dot);
                    markerOverlay.Markers.Add(marker);
                    gMapControl1.Position = new PointLatLng(Convert.ToDouble(billLatitude), Convert.ToDouble(billLongitude));

                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(shipLatitude), Convert.ToDouble(shipLongitude)), GMarkerGoogleType.green_dot);
                    markerOverlay.Markers.Add(marker);
                    gMapControl1.Position = new PointLatLng(Convert.ToDouble(shipLatitude), Convert.ToDouble(shipLongitude));

                }
                gMapControl1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error(MarkTheMap)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txt_ZIP.Enabled = true;
            cbo_City.Enabled = true;
            cbo_State.Enabled = true;
            txt_Address.Enabled = true;
            txt_AddressMemo.Enabled = true;
            btn_ZIP.Enabled = true;
            btn_Address.Enabled = true;
        }
        private void ClearAddress()
        {
            cbo_City.Items.Clear();
            cbo_State.Items.Clear();
            txt_ZIP.Text = "";
            txt_Address.Text = "";
            txt_AddressMemo.Text = "";
            txt_addressEmail.Text = "";
            txt_addressTel1.Text = "";
            txt_addressTel2.Text = "";
            txt_addressFax.Text = "";
            txt_LAT.Text = "";
            txt_LONG.Text = "";
            label_Location.Text = "";

            cbo_Citybill.Items.Clear();
            cbo_Statebill.Items.Clear();
            txt_ZIPbill.Text = "";
            txt_Addressbill.Text = "";
            txt_AddressMemobill.Text = "";
            txt_addressEmailbill.Text = "";
            txt_addressTel1bill.Text = "";
            txt_addressTel2bill.Text = "";
            txt_addressFaxbill.Text = "";
            txt_LATbill.Text = "";
            txt_LONGbill.Text = "";
            label_Locationbill.Text = "";
            //txt_ZIP.Enabled = false;
            //cbo_City.Enabled = false;
            //cbo_State.Enabled = false;
            //txt_Address.Enabled = false;
            //txt_AddressMemo.Enabled = false;
            //btn_ZIP.Enabled = false;
            //btn_Address.Enabled = false;
            //btn_Edit.Enabled = false;
            //txt_addressEmail.Enabled = false;
            //txt_addressTel1.Enabled = false;
            //txt_addressTel2.Enabled = false;
            //txt_addressFax.Enabled = false;
        }
        private void cbo_AddressCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAddress();
        }
        private void GetAddress()
        {
            ClearAddress();
            lbl_Addresses.Visible = true;
            panel_Address.Visible = true;
            cbo_AddressCode.Enabled = true;
            btn_save.Enabled = true;
            btn_Edit.Enabled = true;
            btn_SaveAddressInfo.Enabled = true;
            txt_addressEmail.Enabled = true;
            txt_addressTel1.Enabled = true;
            txt_addressTel2.Enabled = true;
            txt_addressFax.Enabled = true;

            AddressObject SHIPaddress = new AddressObject();
            //SHIPaddress = connPO.sp_GET_AddressObject2(txt_customerID.Text.Trim(), cbo_AddressCode.Text);
            SHIPaddress = connPO.sp_GET_AddressObject2(txt_customerID.Text.Trim(), "SHIP");

            txt_ROWID.Text = SHIPaddress.ROWID;
            txt_ZIP.Text = SHIPaddress.AddressPostalCode;
            txt_Address.Text = SHIPaddress.Address1;
            txt_AddressMemo.Text = SHIPaddress.Address2;
            txt_addressEmail.Text = SHIPaddress.AddressEmail;
            txt_addressTel1.Text = SHIPaddress.AddressTel1;
            txt_addressTel2.Text = SHIPaddress.AddressTel2;
            txt_addressFax.Text = SHIPaddress.AddressFax;
            txt_LAT.Text = SHIPaddress.Latitude;
            txt_LONG.Text = SHIPaddress.Longitude;
            label_Location.Text = SHIPaddress.Latitude + "," + SHIPaddress.Longitude;

            StaticZip = SHIPaddress.AddressPostalCode == null ? "" : SHIPaddress.AddressPostalCode;
            StaticCity = SHIPaddress.AddressCity == null ? "" : SHIPaddress.AddressCity;
            StaticState = SHIPaddress.AddressState == null ? "" : SHIPaddress.AddressState;
            StaticAddress = SHIPaddress.Address1 == null ? "" : SHIPaddress.Address1;
            StaticAddressMemo = SHIPaddress.Address2 == null ? "" : SHIPaddress.Address2;

            if (!(SHIPaddress.AddressPostalCode is null))
            {
                cbo_City.Items.Add(StaticCity);
                cbo_City.Text = StaticCity;
                cbo_State.Items.Add(StaticState);
                cbo_State.Text = StaticState;
            }
            //if (address.ROWID is null)
            //{
            //    btn_Edit.Enabled = false;
            //    txt_ZIP.Enabled = true;
            //    cbo_City.Enabled = true;
            //    cbo_State.Enabled = true;
            //    txt_Address.Enabled = true;
            //    txt_AddressMemo.Enabled = true;
            //    btn_ZIP.Enabled = true;
            //    btn_Address.Enabled = true;
            //}

            AddressObject BILLaddress = new AddressObject();
            BILLaddress = connPO.sp_GET_AddressObject2(txt_customerID.Text.Trim(), "BILL");

            txt_ROWIDbill.Text = BILLaddress.ROWID;
            txt_ZIPbill.Text = BILLaddress.AddressPostalCode;
            txt_Addressbill.Text = BILLaddress.Address1;
            txt_AddressMemobill.Text = BILLaddress.Address2;
            txt_addressEmailbill.Text = BILLaddress.AddressEmail;
            txt_addressTel1bill.Text = BILLaddress.AddressTel1;
            txt_addressTel2bill.Text = BILLaddress.AddressTel2;
            txt_addressFaxbill.Text = BILLaddress.AddressFax;
            txt_LATbill.Text = BILLaddress.Latitude;
            txt_LONGbill.Text = BILLaddress.Longitude;
            label_Locationbill.Text = BILLaddress.Latitude + "," + BILLaddress.Longitude;

            StaticZipbill = BILLaddress.AddressPostalCode == null ? "" : BILLaddress.AddressPostalCode;
            StaticCitybill = BILLaddress.AddressCity == null ? "" : BILLaddress.AddressCity;
            StaticStatebill = BILLaddress.AddressState == null ? "" : BILLaddress.AddressState;
            StaticAddressbill = BILLaddress.Address1 == null ? "" : BILLaddress.Address1;
            StaticAddressMemobill = BILLaddress.Address2 == null ? "" : BILLaddress.Address2;

            if(BILLaddress.Latitude == SHIPaddress.Latitude && BILLaddress.Longitude == SHIPaddress.Longitude)
            {
                gMapControl1.Zoom = 15;
                MarkTheMap(BILLaddress.Latitude, BILLaddress.Longitude);

            }
            else
            {
                gMapControl1.Zoom = 12;
                MarkTheMap(SHIPaddress.Latitude, SHIPaddress.Longitude, BILLaddress.Latitude, BILLaddress.Longitude);
            }
            
            if (!(BILLaddress.AddressPostalCode is null))
            {
                cbo_Citybill.Items.Add(StaticCitybill);
                cbo_Citybill.Text = StaticCitybill;
                cbo_Statebill.Items.Add(StaticStatebill);
                cbo_Statebill.Text = StaticStatebill;
            }
        }
        protected string fileGetContents(string fileName)
        {
            string sContents = string.Empty;
            string me = string.Empty;
            try
            {
                if (fileName.ToLower().IndexOf("https:") > -1)
                {
                    System.Net.WebClient wc = new System.Net.WebClient();
                    byte[] response = wc.DownloadData(fileName);
                    sContents = System.Text.Encoding.ASCII.GetString(response);
                }
                else
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
                    sContents = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch(Exception ex) { sContents = ex.ToString()+"\nunable to connect to server "; }
            return sContents;
        }

        private void AddressSearch(TextBox tZIP, ComboBox cCity, ComboBox cState)
        {
            if (tZIP.Text.Length == 0 || cCity.Text.Length == 0 || cState.Text.Length == 0)
            {
                MessageBox.Show("Please enter all informations(Zip, City, State).",
                               "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_Address.Text.Length != 0)
            {
                String InputAddress = txt_Address.Text.Length == 0 ? "" : txt_Address.Text.ToString();
                String InputZip = tZIP.Text.Length == 0 ? "" : tZIP.Text.ToString();
                String InputCity = cCity.Text.Length == 0 ? "" : cCity.Text.ToString();
                String InputState = cState.Text.Length == 0 ? "" : cState.Text.ToString();

                String FullAddress = InputAddress.Trim() + ", " + InputCity + ", " + InputState + " " + InputZip + ", USA";

                string url = "https://maps.google.com/maps/api/geocode/json?key=AIzaSyBLxyBEB2O504HHMFcT_oWI5jWD_0x5A5Y&sensor=true&address=" + FullAddress;
                string content = fileGetContents(url);

                List<string> add = new List<string>();
                if (content.Trim().Equals("unable to connect to server"))
                {
                    MessageBox.Show(content, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    try
                    {
                        JObject o = JObject.Parse(content);
                        JObject jObj = (JObject)JsonConvert.DeserializeObject(content);

                        if (o.SelectToken("status").ToString().Trim().Equals("ZERO_RESULTS")) // no result
                        {
                            MessageBox.Show("Address : " + FullAddress + " could not be found on OBCS Maps. \nPlease make sure your search term is spelled correctly.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            int count = jObj.Count;
                            var root = JsonConvert.DeserializeObject<CustomerLocation.RootObject>(content); //get json data by (CustomerLocation.RootObject) format


                            var FormattedAddress = root.results[0].formatted_address == null ? "" : root.results[0].formatted_address.ToString();
                            var ZipCode = "";

                            foreach (var addressComponent in root.results[0].address_components)
                            {
                                if (addressComponent.types[0].Equals("postal_code"))
                                {
                                    ZipCode = addressComponent.long_name.ToString();
                                }
                            }

                            if (FormattedAddress.Equals("") || ZipCode.Equals(""))
                            {
                                MessageBox.Show("Address : " + FullAddress + " could not be found on OBCS Maps. \nPlease make sure your search term is spelled correctly.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                String Message = "";
                                if (FullAddress.ToUpper().Equals(FormattedAddress.ToUpper().ToString()))
                                {
                                    Message = "Address : "+FormattedAddress.ToString()+"\nIs the following address correct?";
                                }
                                else
                                {
                                    Message = "Search Address : '" + FullAddress + "'\n           🠗\nFormatted Address : '" + FormattedAddress.ToString() +
                                       "'\n\nIs the following address correct? ";
                                }
                                DialogResult dialogResult = MessageBox.Show(Message, "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (dialogResult == DialogResult.Yes)
                                {
                                    int CommaCount = FormattedAddress.Split(',').Length - 1; //47-15 33rd ave, Long island City, NY 11101, USA
                                    String[] Format = FormattedAddress.Split(',');
                                    String StreetNumber = "";
                                    String City = "";
                                    ZipCodeSearch(ZipCode, true, cState, cCity);

                                    if (CommaCount == 3) // Normal Formatted Address 
                                    {
                                        StreetNumber = Format[0];
                                        City = Format[1];
                                    }
                                    else if (CommaCount >= 4) // (street number,route,apartment etc...)
                                    {
                                        for (int i = 0; i < CommaCount - 2; i++) //City 앞 쪽 Data
                                        {
                                            StreetNumber += Format[i];
                                            if (i != CommaCount - 3) StreetNumber += ",";
                                        }
                                        City = Format[CommaCount - 2];
                                    }else if (CommaCount == 2)
                                    {
                                        City = Format[0];
                                    }

                                    bool FormattedAutoCheck = false;

                                    foreach (String CityName in cCity.Items)
                                    {
                                        if (City.Trim().ToUpper().Equals(CityName.Trim()))
                                        {
                                            FormattedAutoCheck = true; //ZipSearch로 이미 cCity에 저장되어 있는 City라면 자동 선택 및 FormattedAutocheck = true
                                        }
                                    }

                                    if (!FormattedAutoCheck) // if there is no match in cCity
                                    {
                                        cCity.Items.Add(City.Trim().ToUpper());
                                        //foreach (var addressComponent in root.results[0].address_components)
                                        //{
                                        //    foreach (String CityName in cCity.Items)
                                        //    {
                                        //        if (addressComponent.long_name.ToUpper().Equals(CityName))
                                        //        {
                                        //            City = CityName;
                                        //        }
                                        //    }
                                        //}
                                    }

                                    String Latitude = root.results[0].geometry.location.lat.ToString();
                                    String Longitude = root.results[0].geometry.location.lng.ToString();

                                    label_Location.Text = Latitude + "," + Longitude;
                                    txt_LAT.Text = Latitude;
                                    txt_LONG.Text = Longitude;

                                    MarkTheMap(Latitude, Longitude);

                                    tZIP.Text = ZipCode;
                                    txt_Address.Text = StreetNumber;
                                    cCity.Text = City.Trim().ToUpper().ToString();

                                    StaticZip = tZIP.Text.ToString();
                                    StaticCity = cCity.Text.ToString();
                                    StaticState = cState.Text.ToString();
                                    StaticAddress = txt_Address.Text.ToString();
                                    StaticAddressMemo = txt_AddressMemo.Text.ToString();

                                }
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void AddressSearchBill(TextBox tZIP, ComboBox cCity, ComboBox cState)
        {
            if (tZIP.Text.Length == 0 || cCity.Text.Length == 0 || cState.Text.Length == 0)
            {
                MessageBox.Show("Please enter all informations(Zip, City, State).",
                               "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_Address.Text.Length != 0)
            {
                String InputAddress = txt_Addressbill.Text.Length == 0 ? "" : txt_Addressbill.Text.ToString();
                String InputZip = tZIP.Text.Length == 0 ? "" : tZIP.Text.ToString();
                String InputCity = cCity.Text.Length == 0 ? "" : cCity.Text.ToString();
                String InputState = cState.Text.Length == 0 ? "" : cState.Text.ToString();

                String FullAddress = InputAddress.Trim() + ", " + InputCity + ", " + InputState + " " + InputZip + ", USA";

                string url = "https://maps.google.com/maps/api/geocode/json?key=AIzaSyBLxyBEB2O504HHMFcT_oWI5jWD_0x5A5Y&sensor=true&address=" + FullAddress;
                string content = fileGetContents(url);

                List<string> add = new List<string>();
                if (content.Trim().Equals("unable to connect to server"))
                {
                    MessageBox.Show(content, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    try
                    {
                        JObject o = JObject.Parse(content);
                        JObject jObj = (JObject)JsonConvert.DeserializeObject(content);

                        if (o.SelectToken("status").ToString().Trim().Equals("ZERO_RESULTS")) // no result
                        {
                            MessageBox.Show("Address : " + FullAddress + " could not be found on OBCS Maps. \nPlease make sure your search term is spelled correctly.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            int count = jObj.Count;
                            var root = JsonConvert.DeserializeObject<CustomerLocation.RootObject>(content); //get json data by (CustomerLocation.RootObject) format


                            var FormattedAddress = root.results[0].formatted_address == null ? "" : root.results[0].formatted_address.ToString();
                            var ZipCode = "";

                            foreach (var addressComponent in root.results[0].address_components)
                            {
                                if (addressComponent.types[0].Equals("postal_code"))
                                {
                                    ZipCode = addressComponent.long_name.ToString();
                                }
                            }

                            if (FormattedAddress.Equals("") || ZipCode.Equals(""))
                            {
                                MessageBox.Show("Address : " + FullAddress + " could not be found on OBCS Maps. \nPlease make sure your search term is spelled correctly.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                String Message = "";
                                if (FullAddress.ToUpper().Equals(FormattedAddress.ToUpper().ToString()))
                                {
                                    Message = "Address : " + FormattedAddress.ToString() + "\nIs the following address correct?";
                                }
                                else
                                {
                                    Message = "Search Address : '" + FullAddress + "'\n           🠗\nFormatted Address : '" + FormattedAddress.ToString() +
                                       "'\n\nIs the following address correct? ";
                                }
                                DialogResult dialogResult = MessageBox.Show(Message, "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (dialogResult == DialogResult.Yes)
                                {
                                    int CommaCount = FormattedAddress.Split(',').Length - 1; //47-15 33rd ave, Long island City, NY 11101, USA
                                    String[] Format = FormattedAddress.Split(',');
                                    String StreetNumber = "";
                                    String City = "";
                                    ZipCodeSearch(ZipCode, true, cState, cCity);

                                    if (CommaCount == 3) // Normal Formatted Address 
                                    {
                                        StreetNumber = Format[0];
                                        City = Format[1];
                                    }
                                    else if (CommaCount >= 4) // (street number,route,apartment etc...)
                                    {
                                        for (int i = 0; i < CommaCount - 2; i++) //City 앞 쪽 Data
                                        {
                                            StreetNumber += Format[i];
                                            if (i != CommaCount - 3) StreetNumber += ",";
                                        }
                                        City = Format[CommaCount - 2];
                                    }
                                    else if (CommaCount == 2)
                                    {
                                        City = Format[0];
                                    }

                                    bool FormattedAutoCheck = false;

                                    foreach (String CityName in cCity.Items)
                                    {
                                        if (City.Trim().ToUpper().Equals(CityName.Trim()))
                                        {
                                            FormattedAutoCheck = true; //ZipSearch로 이미 cCity에 저장되어 있는 City라면 자동 선택 및 FormattedAutocheck = true
                                        }
                                    }

                                    if (!FormattedAutoCheck) // if there is no match in cCity
                                    {
                                        cCity.Items.Add(City.Trim().ToUpper());
                                        //foreach (var addressComponent in root.results[0].address_components)
                                        //{
                                        //    foreach (String CityName in cCity.Items)
                                        //    {
                                        //        if (addressComponent.long_name.ToUpper().Equals(CityName))
                                        //        {
                                        //            City = CityName;
                                        //        }
                                        //    }
                                        //}
                                    }

                                    String Latitude = root.results[0].geometry.location.lat.ToString();
                                    String Longitude = root.results[0].geometry.location.lng.ToString();

                                    label_Locationbill.Text = Latitude + "," + Longitude;
                                    txt_LATbill.Text = Latitude;
                                    txt_LONGbill.Text = Longitude;

                                    MarkTheMap(Latitude, Longitude);

                                    tZIP.Text = ZipCode;
                                    txt_Addressbill.Text = StreetNumber;
                                    cCity.Text = City.Trim().ToUpper().ToString();

                                    StaticZipbill = tZIP.Text.ToString();
                                    StaticCitybill = cCity.Text.ToString();
                                    StaticStatebill = cState.Text.ToString();
                                    StaticAddressbill = txt_Addressbill.Text.ToString();
                                    StaticAddressMemobill = txt_AddressMemobill.Text.ToString();

                                }
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void ZipCodeSearch(String InputZip, bool AddressConfirm, ComboBox cState, ComboBox cCity)
        {
            cCity.Items.Clear();
            cState.Items.Clear();

            string url = "https://maps.google.com/maps/api/geocode/json?key=AIzaSyBLxyBEB2O504HHMFcT_oWI5jWD_0x5A5Y&sensor=true&address=" + InputZip;
            string content = fileGetContents(url);


            List<string> add = new List<string>();
            if (content.Trim().Equals("unable to connect to server"))
            {
                MessageBox.Show(content, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    JObject o = JObject.Parse(content);
                    JObject jObj = (JObject)JsonConvert.DeserializeObject(content);
                    if (o.SelectToken("status").ToString().Trim().Equals("ZERO_RESULTS"))
                    {
                        MessageBox.Show("ZIP : '" + InputZip + "' could not be found on OBCS Maps. \nPlease make sure your search term is spelled correctly.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        int count = jObj.Count;
                        var root = JsonConvert.DeserializeObject<CustomerLocation.RootObject>(content);
                        //MessageBox.Show(content);

                        foreach (var singleResult in root.results)
                        {
                            bool USCheck = false;

                            for (int i = 0; i < singleResult.address_components.Count; i++)
                            {
                                if (singleResult.address_components[i].types[0].Equals("country"))
                                {
                                    if (singleResult.address_components[i].short_name.ToUpper().Equals("US")) // ONLY US ADDRESS
                                    {
                                        USCheck = true;
                                    }
                                }
                            }

                            if (USCheck) //ONLY US!!!!!!!!!!!!!!!!!!!!!!!!
                            {
                                //////////////////////////////////////////////////////////////////////////////////CITY////////////////////////////////////////////////////////////////////////////////////////////
                                if (singleResult.postcode_localities != null) // Google Api에서 Zip에 따라 postcode_localities에 City를 자동으로 List up 해줌
                                {
                                    for (int i = 0; i < singleResult.postcode_localities.Length; i++)
                                    {
                                        var postcode_localities = singleResult.postcode_localities[i].ToString();
                                        cCity.Items.Add(postcode_localities.ToUpper().ToString());
                                    }
                                    cCity.SelectedIndex = 0;
                                }


                                for (int i = 0; i < singleResult.address_components.Count; i++)
                                {
                                    if (singleResult.address_components[i].types.Count > 1 && !((singleResult.address_components[i].types[0].Substring(0, 5).Equals("admin")) || singleResult.address_components[i].types[0].Equals("country")))
                                    {
                                        if (singleResult.address_components[i].types[0].Equals("political") || singleResult.address_components[i].types[1].Equals("political"))
                                        {   //City가 될만한 것들을 다 넣는다.
                                            if (!cCity.Items.Contains(singleResult.address_components[i].long_name.ToUpper().ToString())) //이미 있는 것들 빼고 다 넣는다
                                            {
                                                cCity.Items.Add(singleResult.address_components[i].long_name.ToUpper().ToString());
                                            }
                                            cCity.Text = singleResult.address_components[i].long_name.ToUpper().ToString();
                                        }
                                    }
                                }
                                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                                ///////////////////////////////////////////////////////////////////////////////////STATE//////////////////////////////////////////////////////////////////////////////////////////
                                for (int i = 0; i < singleResult.address_components.Count; i++)
                                {
                                    if (singleResult.address_components[i].types[0].Equals("administrative_area_level_1")) //administrative_area_level_1 = State
                                    {
                                        cState.Items.Add(singleResult.address_components[i].short_name.ToUpper().ToString());
                                        cState.Text = singleResult.address_components[i].short_name.ToUpper().ToString();
                                    }
                                    if (singleResult.address_components[i].types[0].Equals("postal_code")) // Type postal_code가 없다는 것은 이상한 주소라는 뜻
                                    {
                                        String JsonZipCode = singleResult.address_components[i].long_name.ToString();
                                        if ((!txt_ZIP.Text.Trim().Equals(JsonZipCode)) && !AddressConfirm) //AddressConfirm true = Zip button Confirm이 아닌 Address Button Confirm Click시
                                        {
                                            DialogResult dialogResult = MessageBox.Show("ZIP : '" + InputZip + "' could not be found on OBCS Maps.\n\n" +
                                                "Search ZIP : '" + txt_ZIP.Text.ToString() + "'\n           🠗\nFormatted ZIP : '" + JsonZipCode + "'\n\nIs the following ZIP correct?"
                                                   , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            if (dialogResult == DialogResult.Yes)
                                            {
                                                txt_ZIP.Text = JsonZipCode;
                                            }
                                            cCity.Items.Clear();
                                            cState.Items.Clear();
                                            return;
                                        }
                                    }
                                }
                                if (cState.Text.Length == 0) //그래도 비어있으면 나라라도 넣어준다
                                {
                                    for (int i = 0; i < singleResult.address_components.Count; i++)
                                    {
                                        if (singleResult.address_components[i].types[0].Equals("country"))
                                        {
                                            cState.Items.Add(singleResult.address_components[i].short_name.ToUpper().ToString());
                                            cState.Text = singleResult.address_components[i].short_name.ToUpper().ToString();
                                        }
                                    }
                                }
                                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            }
                        }
                        if(cCity.Text.Equals("") || cState.Text.Equals(""))
                        {
                            MessageBox.Show("ZIP : '" + InputZip + "' could not be found on OBCS Maps." +
                     "\nPlease make sure your search term(Only US Address) is spelled correctly.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    StaticZip = txt_ZIP.Text.ToString();
                    StaticCity = cCity.Text.ToString();
                    StaticState = cState.Text.ToString();
                    StaticAddress = txt_Address.Text.ToString();
                    StaticAddressMemo = txt_AddressMemo.Text.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ZIP : '" + InputZip + "' could not be found on OBCS Maps. " +
                     "\nPlease make sure your search term is spelled correctly.\n\n Error message : " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ZipCodeSearchBill(String InputZip, bool AddressConfirm, ComboBox cState, ComboBox cCity)
        {
            cCity.Items.Clear();
            cState.Items.Clear();

            string url = "https://maps.google.com/maps/api/geocode/json?key=AIzaSyBLxyBEB2O504HHMFcT_oWI5jWD_0x5A5Y&sensor=true&address=" + InputZip;
            string content = fileGetContents(url);


            List<string> add = new List<string>();
            if (content.Trim().Equals("unable to connect to server"))
            {
                MessageBox.Show(content, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    JObject o = JObject.Parse(content);
                    JObject jObj = (JObject)JsonConvert.DeserializeObject(content);
                    if (o.SelectToken("status").ToString().Trim().Equals("ZERO_RESULTS"))
                    {
                        MessageBox.Show("ZIP : '" + InputZip + "' could not be found on OBCS Maps. \nPlease make sure your search term is spelled correctly.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        int count = jObj.Count;
                        var root = JsonConvert.DeserializeObject<CustomerLocation.RootObject>(content);
                        //MessageBox.Show(content);

                        foreach (var singleResult in root.results)
                        {
                            bool USCheck = false;

                            for (int i = 0; i < singleResult.address_components.Count; i++)
                            {
                                if (singleResult.address_components[i].types[0].Equals("country"))
                                {
                                    if (singleResult.address_components[i].short_name.ToUpper().Equals("US")) // ONLY US ADDRESS
                                    {
                                        USCheck = true;
                                    }
                                }
                            }

                            if (USCheck) //ONLY US!!!!!!!!!!!!!!!!!!!!!!!!
                            {
                                //////////////////////////////////////////////////////////////////////////////////CITY////////////////////////////////////////////////////////////////////////////////////////////
                                if (singleResult.postcode_localities != null) // Google Api에서 Zip에 따라 postcode_localities에 City를 자동으로 List up 해줌
                                {
                                    for (int i = 0; i < singleResult.postcode_localities.Length; i++)
                                    {
                                        var postcode_localities = singleResult.postcode_localities[i].ToString();
                                        cCity.Items.Add(postcode_localities.ToUpper().ToString());
                                    }
                                    cCity.SelectedIndex = 0;
                                }


                                for (int i = 0; i < singleResult.address_components.Count; i++)
                                {
                                    if (singleResult.address_components[i].types.Count > 1 && !((singleResult.address_components[i].types[0].Substring(0, 5).Equals("admin")) || singleResult.address_components[i].types[0].Equals("country")))
                                    {
                                        if (singleResult.address_components[i].types[0].Equals("political") || singleResult.address_components[i].types[1].Equals("political"))
                                        {   //City가 될만한 것들을 다 넣는다.
                                            if (!cCity.Items.Contains(singleResult.address_components[i].long_name.ToUpper().ToString())) //이미 있는 것들 빼고 다 넣는다
                                            {
                                                cCity.Items.Add(singleResult.address_components[i].long_name.ToUpper().ToString());
                                            }
                                            cCity.Text = singleResult.address_components[i].long_name.ToUpper().ToString();
                                        }
                                    }
                                }
                                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                                ///////////////////////////////////////////////////////////////////////////////////STATE//////////////////////////////////////////////////////////////////////////////////////////
                                for (int i = 0; i < singleResult.address_components.Count; i++)
                                {
                                    if (singleResult.address_components[i].types[0].Equals("administrative_area_level_1")) //administrative_area_level_1 = State
                                    {
                                        cState.Items.Add(singleResult.address_components[i].short_name.ToUpper().ToString());
                                        cState.Text = singleResult.address_components[i].short_name.ToUpper().ToString();
                                    }
                                    if (singleResult.address_components[i].types[0].Equals("postal_code")) // Type postal_code가 없다는 것은 이상한 주소라는 뜻
                                    {
                                        String JsonZipCode = singleResult.address_components[i].long_name.ToString();
                                        if ((!txt_ZIPbill.Text.Trim().Equals(JsonZipCode)) && !AddressConfirm) //AddressConfirm true = Zip button Confirm이 아닌 Address Button Confirm Click시
                                        {
                                            DialogResult dialogResult = MessageBox.Show("ZIP : '" + InputZip + "' could not be found on OBCS Maps.\n\n" +
                                                "Search ZIP : '" + txt_ZIPbill.Text.ToString() + "'\n           🠗\nFormatted ZIP : '" + JsonZipCode + "'\n\nIs the following ZIP correct?"
                                                   , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            if (dialogResult == DialogResult.Yes)
                                            {
                                                txt_ZIPbill.Text = JsonZipCode;
                                            }
                                            cCity.Items.Clear();
                                            cState.Items.Clear();
                                            return;
                                        }
                                    }
                                }
                                if (cState.Text.Length == 0) //그래도 비어있으면 나라라도 넣어준다
                                {
                                    for (int i = 0; i < singleResult.address_components.Count; i++)
                                    {
                                        if (singleResult.address_components[i].types[0].Equals("country"))
                                        {
                                            cState.Items.Add(singleResult.address_components[i].short_name.ToUpper().ToString());
                                            cState.Text = singleResult.address_components[i].short_name.ToUpper().ToString();
                                        }
                                    }
                                }
                                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            }
                        }
                        if (cCity.Text.Equals("") || cState.Text.Equals(""))
                        {
                            MessageBox.Show("ZIP : '" + InputZip + "' could not be found on OBCS Maps." +
                     "\nPlease make sure your search term(Only US Address) is spelled correctly.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    StaticZipbill = txt_ZIPbill.Text.ToString();
                    StaticCitybill = cCity.Text.ToString();
                    StaticStatebill = cState.Text.ToString();
                    StaticAddressbill = txt_Addressbill.Text.ToString();
                    StaticAddressMemobill = txt_AddressMemobill.Text.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ZIP : '" + InputZip + "' could not be found on OBCS Maps. " +
                     "\nPlease make sure your search term is spelled correctly.\n\n Error message : " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Address_Click(object sender, EventArgs e)
        {
            AddressSearch(txt_ZIP, cbo_City, cbo_State);
        }
        private void txt_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddressSearch(txt_ZIP, cbo_City, cbo_State);
            }
        }
        private void txt_ZIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String InputZip = txt_ZIP.Text.Length == 0 ? "" : txt_ZIP.Text.ToString();

                if (txt_Address.Text.Trim().Length != 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Your address will be deleted. Are you sure to continue?", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        txt_Address.Text = "";
                        ZipCodeSearch(InputZip,false, cbo_State, cbo_City);
                    }
                }
                else
                {
                    ZipCodeSearch(InputZip,false, cbo_State, cbo_City);
                }
            }
        }
        private void btn_ZIP_Click(object sender, EventArgs e)
        {
            String InputZip = txt_ZIP.Text.Length == 0 ? "" : txt_ZIP.Text.ToString();

            if (txt_Address.Text.Trim().Length != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Your address will be deleted. Are you sure to continue?", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    txt_Address.Text = "";
                    ZipCodeSearch(InputZip,false, cbo_State, cbo_City);
                }
            }
            else
            {
                ZipCodeSearch(InputZip,false, cbo_State, cbo_City);
            }
        }

        private void btn_ZIPbill_Click(object sender, EventArgs e)
        {
            String InputZip = txt_ZIPbill.Text.Length == 0 ? "" : txt_ZIPbill.Text.ToString();

            if (txt_Addressbill.Text.Trim().Length != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Your address will be deleted. Are you sure to continue?", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    txt_Addressbill.Text = "";
                    ZipCodeSearchBill(InputZip, false, cbo_Statebill, cbo_Citybill);
                }
            }
            else
            {
                ZipCodeSearchBill(InputZip, false, cbo_Statebill, cbo_Citybill);
            }
        }

        private void btn_SaveAddressInfo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            AddressObject addressObject = new AddressObject();
            Location location = new Location();

            addressObject.ROWID = txt_ROWID.Text.Trim();
            addressObject.AddressCode = "SHIP";//cbo_AddressCode.Text.Trim();
            addressObject.Address1 = txt_Address.Text.Trim();
            addressObject.Address2 = txt_AddressMemo.Text.Trim();
            addressObject.AddressCity = cbo_City.Text.Trim();
            addressObject.AddressState = cbo_State.Text.Trim();
            addressObject.AddressPostalCode = txt_ZIP.Text.Trim();
            addressObject.AddressEmail = txt_addressEmail.Text.Trim();
            addressObject.AddressTel1 = txt_addressTel1.Text.Trim();
            addressObject.AddressTel2 = txt_addressTel2.Text.Trim();
            addressObject.AddressFax = txt_addressFax.Text.Trim();
            location.Latitude = txt_LAT.Text.Trim();
            location.Longitude = txt_LONG.Text.Trim();

            AddressObject billaddressObject = new AddressObject();
            Location billlocation = new Location();

            billaddressObject.ROWID = txt_ROWIDbill.Text.Trim(); 
            billaddressObject.AddressCode = "BILL"; //cbo_AddressCode.Text.Trim();
            billaddressObject.Address1 = txt_Addressbill.Text.Trim();
            billaddressObject.Address2 = txt_AddressMemobill.Text.Trim();
            billaddressObject.AddressCity = cbo_Citybill.Text.Trim();
            billaddressObject.AddressState = cbo_Statebill.Text.Trim();
            billaddressObject.AddressPostalCode = txt_ZIPbill.Text.Trim();
            billaddressObject.AddressEmail = txt_addressEmailbill.Text.Trim();
            billaddressObject.AddressTel1 = txt_addressTel1bill.Text.Trim();
            billaddressObject.AddressTel2 = txt_addressTel2bill.Text.Trim();
            billaddressObject.AddressFax = txt_addressFaxbill.Text.Trim();
            billlocation.Latitude = txt_LATbill.Text.Trim();
            billlocation.Longitude = txt_LONGbill.Text.Trim();

            //MessageBox.Show("Static ZIP : " + StaticZip + "\nStatic Address : " + StaticAddress + "\nStaticAddressMemo : " + StaticAddressMemo
            //    + "\nStaticCity : " + StaticCity + "\nStaticState : " + StaticState + "\ntxt_Zip.text : " + txt_ZIP.Text.ToString());
            //String Permission = connSalesOrder.sp_UserCheck("CUSTOMERLIST_ADDRESS");

            if (txt_Address.Enabled && txt_ROWID.Text.Length == 0) //Permission update OR new Address!
            {
                //if (txt_LAT.Text.Length == 0 || txt_LONG.Text.Length == 0) // if it doesn't have location information
                //{
                //    MessageBox.Show("Please make sure your search location is spelled correctly. Enter the correct zip code, address and click the search/confirm button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                //if (txt_ZIP.TextLength == 0 || cbo_City.Text.Length == 0 || cbo_State.Text.Length == 0) // if no input
                //{
                //    MessageBox.Show("Please enter all informations(Zip, City, State).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                //if ((!txt_ZIP.Text.Equals(StaticZip)) || (!txt_Address.Text.Equals(StaticAddress))) // if the value has changed
                //{
                //    MessageBox.Show("Input address has changed. Please confirm(button) again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                dialogResult = MessageBox.Show("Saving address information...", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        //if (Permission.Equals("1")) // permission ok
                        //{
                            String Result = connSalesOrder.sp_INSERT_NewSupplierAddressWithLocation(addressObject, location, txt_customerID.Text.ToString());
                            String Resultbill = connSalesOrder.sp_INSERT_NewSupplierAddressWithLocation(billaddressObject, billlocation, txt_customerID.Text.ToString());
                            if (Result.Equals("OK"))
                            {
                                //MessageBox.Show("Customer address, " + addressObject.AddressCode + " information has been added successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show("Customer address information has been added successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(Result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                MessageBox.Show(Resultbill, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            searchCustomer();

                        //}
                        //else if (Permission.Equals("0")) // no permission
                        //{
                        //    MessageBox.Show("Sorry, You require permission from Administrators to perform this action.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //    return;
                        //}
                        //else // error
                        //{
                        //    MessageBox.Show("Sorry, Something went wrong, please try again.\n"+Permission, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return;
                        //}

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("btn_SaveAddressInfo_Click(Add New Address)\n" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else //no Permission / address part 못 건드리기 때문에 addressObject Column 전부 UPDATE함
            {
                if(txt_ROWID.Text.Length == 0) // No address information in BPADRESS
                {
                    MessageBox.Show("You need to save the address first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((!txt_ZIP.Text.Equals(StaticZip)) || (!txt_Address.Text.Equals(StaticAddress))) // if the value has changed
                {
                    MessageBox.Show("Input address has changed. Please confirm(button) again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dialogResult = MessageBox.Show("Confirming update address information", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        connSalesOrder.sp_UPDATE_AddressInfoWithLocation(addressObject, location);
                        connSalesOrder.sp_UPDATE_AddressInfoWithLocation(billaddressObject, billlocation);
                        //MessageBox.Show("Customer address, " + addressObject.AddressCode + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Customer address information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        searchCustomer();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("btn_SaveAddressInfo_Click(Update Address)\n" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        private void btn_Google_Click(object sender, EventArgs e)
        {
            String InputAddress = txt_Address.Text.Length == 0 ? "" : txt_Address.Text.Trim().ToString();
            String InputZip = txt_ZIP.Text.Length == 0 ? "" : txt_ZIP.Text.Trim().ToString();
            String InputCity = cbo_City.Text.Length == 0 ? "" : cbo_City.Text.Trim().ToString();
            String InputState = cbo_State.Text.Length == 0 ? "" : cbo_State.Text.Trim().ToString();

            String Address = InputAddress.Replace(' ', '+');
            String Zip = InputZip.Replace(' ', '+');
            String City = InputCity.Replace(' ', '+');
            String State = InputState.Replace(' ', '+');

            String FullAddress = Address + ",+" + City + ",+" + State + "+" + Zip + ",+USA";
            System.Diagnostics.Process.Start("chrome", "google.com/maps/place/" + FullAddress + " --new-window");
            //bool active = false;
            //String Address = txt_Address.Text.ToString().Replace(" ", "+");
            //String City = cbo_City.Text.ToString();
            //String State = cbo_State.Text.ToString();
            //String Zipcode = txt_ZIP.Text.ToString();
            //String Latitude = txt_LAT.Text.ToString();
            //String Longitude = txt_LONG.Text.ToString();

            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.GetType() == typeof(Reports.CustomerWeb))
            //    {
            //        active = true;
            //        form.Close();
            //        Reports.CustomerWeb customerWeb = new Reports.CustomerWeb(false, Address, City, State, Zipcode, Latitude, Longitude);
            //        customerWeb.Show();
            //        break;
            //    }
            //}
            //if (active == false)
            //{
            //    Reports.CustomerWeb customerWeb = new Reports.CustomerWeb(false, Address, City, State, Zipcode, Latitude, Longitude);
            //    customerWeb.Show();
            //}
        }
        private void btn_Map_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }
        private void btn_Satellite_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
        }
        private void btn_hybrid_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleHybridMap;
        }
        private void btn_BcsLogo_Click(object sender, EventArgs e)
        {
            gMapControl1.Position = new PointLatLng(BCSlatitude, BCSlongitude);
        }
        private void label_Location_Click(object sender, EventArgs e)
        {
            if(label_Location.Text.Length != 1)
            {
                String[] LocationString = label_Location.Text.Split(',');
                gMapControl1.Position = new PointLatLng(Convert.ToDouble(LocationString[0]), Convert.ToDouble(LocationString[1]));
            }
        }

        private void btn_Addressbill_Click(object sender, EventArgs e)
        {
            AddressSearchBill(txt_ZIPbill, cbo_Citybill, cbo_Statebill);
        }

        private void cbx_acceptOrder_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbx_acceptOrder_Click(object sender, EventArgs e)
        {
            if (cbx_iPadOrder.Checked == true) // 체크안되있는 상태에서 체크 했을 때 
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?"
                                                    , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    connSalesOrder.sp_UPDATE_CustomeriPadOrder("CHECK", txt_customerID.Text.Trim());
                    //cbx_acceptOrder.Checked = true;
                    //connSalesOrder.sp_UPDATE_RouteFinishCheckUncheck("CHECK", RouteNumber);
                    //finished
                    //MessageBox.Show("The Route " + RouteNumber + " has been Finished.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
                {
                    cbx_iPadOrder.Checked = false;
                    connSalesOrder.sp_UPDATE_CustomeriPadOrder("UNCHECK", txt_customerID.Text.Trim());
                }

            }
            else // uncheck 했을 때
            {
                //if (connSalesOrder.sp_UPDATE_RouteFinishCheckUncheck_UserCheck() == "1")
                //{
                //    grid_RouteHeader.Rows[e.RowIndex].Cells["CheckBox"].Value = false;
                //    connSalesOrder.sp_UPDATE_RouteFinishCheckUncheck("UNCHECK", RouteNumber);
                //}
                //else
                //{
                //    MessageBox.Show("Cannot uncheck finish check box."
                //                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //    return;
                //}
                //cbx_acceptOrder.Checked = false;
                connSalesOrder.sp_UPDATE_CustomeriPadOrder("UNCHECK", txt_customerID.Text.Trim());
            }
        }
    }
}
