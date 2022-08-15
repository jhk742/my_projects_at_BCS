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

namespace OBCS.Lists
{
    public partial class SupplierList : Form
    {
        public SupplierList()
        {
           // MessageBox.Show("ProductList");
            InitializeComponent();
            
        }
        private void grid_supplier_Init()
        {
            grid_supplier.AutoGenerateColumns = false;
            grid_supplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_supplier.ColumnCount = 5;

            grid_supplier.Columns[0].Name = "";
            grid_supplier.Columns[0].Visible = false;
            grid_supplier.Columns[0].Width = 80;
            grid_supplier.Columns[0].MinimumWidth = 80;
            grid_supplier.Columns[0].DataPropertyName = "";

            grid_supplier.Columns[1].Name = "Supplier Code";
            grid_supplier.Columns[1].ReadOnly = true;
            grid_supplier.Columns[1].Width = 200;
            grid_supplier.Columns[1].MinimumWidth = 200;
            grid_supplier.Columns[1].DataPropertyName = "SupplierCode";

            grid_supplier.Columns[2].Name = "Supplier Name";
            grid_supplier.Columns[2].ReadOnly = true;
            grid_supplier.Columns[2].Width = 300;
            grid_supplier.Columns[2].MinimumWidth = 300;
            grid_supplier.Columns[2].DataPropertyName = "SupplierName";

            grid_supplier.Columns[3].Name = "Status";
            grid_supplier.Columns[3].ReadOnly = true;
            grid_supplier.Columns[3].Width = 60;
            grid_supplier.Columns[3].MinimumWidth = 60;
            grid_supplier.Columns[3].DataPropertyName = "SupplierStatus";

            grid_supplier.Columns[4].Name = "Lead Time";
            grid_supplier.Columns[4].ReadOnly = true;
            grid_supplier.Columns[4].Width = 60;
            grid_supplier.Columns[4].MinimumWidth = 60;
            grid_supplier.Columns[4].DataPropertyName = "LeadTime";

            //grid font size custom
            grid_supplier.RowTemplate.Height = 20;
            grid_supplier.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_supplier.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_supplier.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_address_Init()
        {
            grid_address.AutoGenerateColumns = false;
            grid_address.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_address.ColumnCount = 2;

            grid_address.Columns[0].Name = "ROWID";
            grid_address.Columns[0].Visible = false;
            grid_address.Columns[0].Width = 80;
            grid_address.Columns[0].MinimumWidth = 80;
            grid_address.Columns[0].DataPropertyName = "ROWID";

            grid_address.Columns[1].Name = "Address Code";
            grid_address.Columns[1].ReadOnly = true;
            grid_address.Columns[1].Width = 60;
            grid_address.Columns[1].MinimumWidth = 60;
            grid_address.Columns[1].DataPropertyName = "AddressCategory";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 60;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_address.Columns["Delete"] == null)
            {
                grid_address.Columns.Insert(2, deleteButton);
            }

            //grid font size custom
            grid_address.RowTemplate.Height = 20;
            grid_address.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_address.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_address.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_contact_Init()
        {
            grid_contact.AutoGenerateColumns = false;
            grid_contact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_contact.ColumnCount = 2;

            grid_contact.Columns[0].Name = "";
            grid_contact.Columns[0].Visible = false;
            grid_contact.Columns[0].Width = 80;
            grid_contact.Columns[0].MinimumWidth = 80;
            grid_contact.Columns[0].DataPropertyName = "";

            grid_contact.Columns[1].Name = "Contact Code";
            grid_contact.Columns[1].ReadOnly = true;
            grid_contact.Columns[1].Width = 60;
            grid_contact.Columns[1].MinimumWidth = 60;
            grid_contact.Columns[1].DataPropertyName = "";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 60;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_contact.Columns["Delete"] == null)
            {
                grid_contact.Columns.Insert(2, deleteButton);
            }
            //grid font size custom
            grid_contact.RowTemplate.Height = 20;
            grid_contact.ColumnHeadersHeight = 30;
            foreach (DataGridViewColumn c in grid_contact.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_contact.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_supplier_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            SupplierObject supplierObject = new SupplierObject();
            String SupplierCode = grid_supplier.Rows[e.RowIndex].Cells["Supplier Code"].Value.ToString().Trim();
            supplierObject = connSalesOrder.sp_GET_SupplierObject(SupplierCode);
            cbo_SupplierCategory.Text = supplierObject.SupplierCategory;
            if (supplierObject.SupplierStatus == "2")
            {
                cbo_SupplierStatus.Text = "Active";
            }
            else
            {
                cbo_SupplierStatus.Text = "Inactive";
            }
            txt_supplierCode.Text = supplierObject.SupplierCode;
            txt_supplierName.Text = supplierObject.SupplierName;
            cbo_paymentTerm.Text = supplierObject.PaymentTerm;
            cbo_ShipVia.Text = supplierObject.ShipVia;
            txt_leadTime.Text = grid_supplier.Rows[e.RowIndex].Cells["Lead Time"].Value.ToString() ;
            txt_addressCode.Text = "";
            txt_address1.Text = "";
            txt_address2.Text = "";
            txt_city.Text = "";
            txt_stateCode.Text = "";
            txt_postalCode.Text = "";
            txt_addressEmail.Text = "";
            txt_addressTel1.Text = "";
            txt_addressTel2.Text = "";
            txt_addressFax.Text = "";

            btn_save.Enabled = true;
            btn_newSave.Visible = false;
            btn_new.Enabled = true;
            txt_supplierCode.Enabled = false;
            txt_addressCode.Text = "";
            pan_address.Visible = true;
            label1.Visible = true;
            connPO.sp_LIST_AddressCategory(grid_address, txt_supplierCode.Text.Trim());
        }

        private void grid_supplier_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirming update supplier, "+ txt_supplierCode.Text.Trim() + " information.", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    SupplierObject supplierObject = new SupplierObject();
                    supplierObject.SupplierCategory = cbo_SupplierCategory.Text.Trim();
                    if (cbo_SupplierStatus.Text.Trim() == "Active")
                    {
                        supplierObject.SupplierStatus = "2";
                    }
                    else
                    {
                        supplierObject.SupplierStatus = "1";
                    }
                    supplierObject.SupplierCode = txt_supplierCode.Text.Trim();
                    supplierObject.SupplierName = txt_supplierName.Text.Trim();
                    supplierObject.PaymentTerm = cbo_paymentTerm.Text.Trim();
                    supplierObject.ShipVia = cbo_ShipVia.Text.Trim();

                    connSalesOrder.sp_UPDATE_SupplierInfo(supplierObject);

                    MessageBox.Show("Supplier, " + supplierObject.SupplierCode + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                }
            }
        }

        private void searchSupplier()
        {
            String SearchSupplierCode = txt_searchSupplierCode.Text.Trim();
            String SearchSupplierName = txt_searchSupplierName.Text.Trim();
            String SearchSupplierCategory = cbo_searchSupplierCategory.Text.Trim();
            String SearchSupplierPaymentTerm = cbo_searchPaymentTerm.Text.Trim();
            String SearchSupplierStatus = "";
            if (cbx_inactive.Checked)
            {
                SearchSupplierStatus = "ALL";
            }
            else
            {
                SearchSupplierStatus = "Active";
            }
            connPO.sp_LIST_SUPPLIER(grid_supplier, SearchSupplierCode, SearchSupplierName, SearchSupplierStatus, SearchSupplierCategory, SearchSupplierPaymentTerm);
        }

        private void cbx_inactive_CheckedChanged(object sender, EventArgs e)
        {
            searchSupplier();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_supplierCode.Text = "";
            txt_supplierName.Text = "";
            cbo_SupplierCategory.Text = "";
            cbo_SupplierStatus.Text = "Active";
            cbo_paymentTerm.Text = "";
            cbo_ShipVia.Text = "";
            txt_supplierCode.Enabled = true;
            grid_address.DataSource = null;
            grid_contact.DataSource = null;
            btn_save.Enabled = false;
            btn_newSave.Visible = true;
            btn_new.Enabled = false;
            pan_address.Visible = false;
            label1.Visible = false;
        }

        private void btn_newSave_Click(object sender, EventArgs e)
        {
            if (txt_supplierCode.Text.Trim() == "")
            {
                MessageBox.Show("Please insert Supplier code", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (connSalesOrder.sp_CHECK_NewSupplierCode(txt_supplierCode.Text.Trim()) == true)
            {
                MessageBox.Show("Supplier code already exist.", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Save a new supplier?", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    SupplierObject supplierObject = new SupplierObject();

                    supplierObject.SupplierCategory = cbo_SupplierCategory.Text.Trim();
                    if (cbo_SupplierStatus.Text.Trim() == "Active")
                    {
                        supplierObject.SupplierStatus = "2";
                    }
                    else
                    {
                        supplierObject.SupplierStatus = "1";
                    }
                    supplierObject.SupplierCode = txt_supplierCode.Text.Trim();
                    supplierObject.SupplierName = txt_supplierName.Text.Trim();
                    supplierObject.PaymentTerm = cbo_paymentTerm.Text.Trim();
                    supplierObject.ShipVia = cbo_ShipVia.Text.Trim();
                    connSalesOrder.sp_INSERT_NewSupplier(supplierObject);
                    MessageBox.Show("Supplier, " + supplierObject.SupplierCode + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Input all product information.", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }

        private void SupplierList_Load(object sender, EventArgs e)
        {
            grid_supplier_Init();
            grid_address_Init();
            String SearchSupplierCode = txt_searchSupplierCode.Text.Trim();
            String SearchSupplierName = txt_searchSupplierName.Text.Trim();
            String SearchSupplierCategory = cbo_searchSupplierCategory.Text.Trim();
            String SearchSupplierPaymentTerm = cbo_searchPaymentTerm.Text.Trim();
            String SearchSupplierStatus = "";
            if (cbx_inactive.Checked)
            {
                SearchSupplierStatus = "ALL";
            }
            else
            {
                SearchSupplierStatus = "Active";
            }
            connPO.sp_LIST_SUPPLIER(grid_supplier, SearchSupplierCode, SearchSupplierName, SearchSupplierStatus, SearchSupplierCategory, SearchSupplierPaymentTerm);
            

            cbo_SupplierStatus.Items.Clear();
            cbo_SupplierStatus.Items.Add("Active");
            cbo_SupplierStatus.Items.Add("Inactive");
            cbo_SupplierCategory.Items.Clear();
            connSalesOrder.sp_GET_SupplierCategory(cbo_SupplierCategory);
            cbo_paymentTerm.Items.Clear();
            connSalesOrder.sp_GET_PaymentTerm(cbo_paymentTerm);
            cbo_ShipVia.Items.Clear();
            cbo_ShipVia.Items.Add("");
            cbo_ShipVia.Items.Add("DELIVERY");
            cbo_ShipVia.Items.Add("OURTRUCK");
            cbo_ShipVia.Items.Add("THRPT");
            cbo_ShipVia.Items.Add("N/A");
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
        private void grid_address_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0) // Delete button
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure deleting this supplier address from this address list?", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        String ROWID = grid_address.Rows[e.RowIndex].Cells["ROWID"].Value.ToString().Trim();
                        connSalesOrder.sp_DELETE_SupplierAddress(ROWID);
                        grid_address.Rows.RemoveAt(e.RowIndex);
                        txt_addressCode.Text = "";
                        txt_address1.Text = "";
                        txt_address2.Text = "";
                        txt_city.Text = "";
                        txt_stateCode.Text = "";
                        txt_postalCode.Text = "";
                        txt_addressEmail.Text = "";
                        txt_addressTel1.Text = "";
                        txt_addressTel2.Text = "";
                        txt_addressFax.Text = "";
                    }
                    catch
                    {
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
        }

        private void grid_address_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btn_saveNewAddress.Visible = false;
            txt_addressCode.Text = "";
            txt_address1.Text = "";
            txt_address2.Text = "";
            txt_city.Text = "";
            txt_stateCode.Text = "";
            txt_postalCode.Text = "";
            //get addresses
            String ROWID = grid_address.Rows[e.RowIndex].Cells["ROWID"].Value.ToString().Trim();
            AddressObject addressObject = new AddressObject();
            addressObject = connSalesOrder.sp_GET_AddressObject(ROWID);
            //MessageBox.Show(addressObject.AddressCode);
            txt_ROWID.Text = addressObject.ROWID;
            txt_addressCode.Text = addressObject.AddressCode;
            txt_address1.Text = addressObject.Address1;
            txt_address2.Text = addressObject.Address2;
            txt_city.Text = addressObject.AddressCity;
            txt_stateCode.Text = addressObject.AddressState;
            txt_postalCode.Text = addressObject.AddressPostalCode;
            txt_addressEmail.Text = addressObject.AddressEmail;
            txt_addressTel1.Text = addressObject.AddressTel1;
            txt_addressTel2.Text = addressObject.AddressTel2;
            txt_addressFax.Text = addressObject.AddressFax;
        }

        private void btn_newAddress_Click(object sender, EventArgs e)
        {
            txt_addressCode.Text = "";
            txt_address1.Text = "";
            txt_address2.Text = "";
            txt_city.Text = "";
            txt_stateCode.Text = "";
            txt_postalCode.Text = "";
            txt_addressEmail.Text = "";
            txt_addressTel1.Text = "";
            txt_addressTel2.Text = "";
            txt_addressFax.Text = "";
            btn_saveNewAddress.Visible = true;
        }

        private void btn_saveAddress_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirming update supplier, " + txt_supplierCode.Text.Trim() + " information.", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    //get addresses
                    String ROWID = txt_ROWID.Text.Trim();
                    AddressObject addressObject = new AddressObject();
                    Location location = new Location();
                    addressObject.ROWID = txt_ROWID.Text.Trim();
                    addressObject.AddressCode = txt_addressCode.Text.Trim();
                    addressObject.Address1 = txt_address1.Text.Trim();
                    addressObject.Address2 = txt_address2.Text.Trim();
                    addressObject.AddressCity = txt_city.Text.Trim();
                    addressObject.AddressState = txt_stateCode.Text.Trim();
                    addressObject.AddressPostalCode = txt_postalCode.Text.Trim();
                    addressObject.AddressEmail = txt_addressEmail.Text.Trim();
                    addressObject.AddressTel1 = txt_addressTel1.Text.Trim();
                    addressObject.AddressTel2 = txt_addressTel2.Text.Trim();
                    addressObject.AddressFax = txt_addressFax.Text.Trim();
                    connSalesOrder.sp_UPDATE_AddressInfo(addressObject);
                    MessageBox.Show("Supplier address, " + addressObject.AddressCode + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                }
            }
        }

        private void btn_saveNewAddress_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirming add a new address, " + txt_addressCode.Text.Trim() + ".", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    AddressObject addressObject = new AddressObject();
                    addressObject.AddressCode = txt_addressCode.Text.Trim();
                    addressObject.Address1 = txt_address1.Text.Trim();
                    addressObject.Address2 = txt_address2.Text.Trim();
                    addressObject.AddressCity = txt_city.Text.Trim();
                    addressObject.AddressState = txt_stateCode.Text.Trim();
                    addressObject.AddressPostalCode = txt_postalCode.Text.Trim();
                    addressObject.AddressEmail = txt_addressEmail.Text.Trim();
                    addressObject.AddressTel1 = txt_addressTel1.Text.Trim();
                    addressObject.AddressTel2 = txt_addressTel2.Text.Trim();
                    addressObject.AddressFax = txt_addressFax.Text.Trim();
                    String SupplierID = txt_supplierCode.Text.Trim();
                    String Result = connSalesOrder.sp_INSERT_NewSupplierAddress(addressObject, SupplierID);
                    if (Result != "OK")
                    {
                        MessageBox.Show(Result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Supplier address, " + addressObject.AddressCode + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connPO.sp_LIST_AddressCategory(grid_address, txt_supplierCode.Text.Trim());
                }
                catch
                {
                }
            }
        }
        
        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchSupplier();
            }
        }

        private void txt_supplierCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_supplierCode_TextChanged(object sender, EventArgs e)
        {
            txt_supplierCode.Text = Regex.Replace(txt_supplierCode.Text, @"\s", "");
        }

        private void btn_updateLeadTime_Click_1(object sender, EventArgs e)
        {
            String Supplier = txt_supplierCode.Text.Trim();
            int LeadTime = Convert.ToInt32(txt_leadTime.Text.Trim());
            connPO.sp_UPDATE_SUPPLIER_LEADTIME(Supplier, LeadTime);
            MessageBox.Show("Lead Time of (" + LeadTime + ")days updated for Supplier: " + Supplier);
            searchSupplier();
        }
    }
}
