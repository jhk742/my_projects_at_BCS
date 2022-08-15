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
    public partial class CompanyList : Form
    {
        public CompanyList()
        {
            InitializeComponent();

            grid_company_Init();
            //grid_contact_Init();
            
            String SearchCompanyCode = txt_searchCompanyCode.Text.Trim();
            String SearchCompanyName = txt_searchCompanyName.Text.Trim();

            String SearchCustomerStatus = "";
            if (cbx_inactive.Checked)
            {
                SearchCustomerStatus = "ALL";
            }
            else
            {
                SearchCustomerStatus = "Active";
            }
            connPO.sp_LIST_COMPANY(grid_company, SearchCompanyCode, SearchCompanyName, SearchCustomerStatus);
            
            cbo_companyStatus.Items.Clear();
            cbo_companyStatus.Items.Add("Active");
            cbo_companyStatus.Items.Add("Inactive");

            cbo_companyCountry.Items.Clear();
            cbo_companyCountry.Items.Add("US");
            cbo_companyCountry.Items.Add("Canada");
            cbo_companyCountry.Items.Add("Other");

            cbo_legalCountry.Items.Clear();
            cbo_legalCountry.Items.Add("US");
            cbo_legalCountry.Items.Add("Canada");
            cbo_legalCountry.Items.Add("Other");

            cbo_fiscalYear.Items.Clear();
            cbo_fiscalYear.Items.Add("January");
            cbo_fiscalYear.Items.Add("February");
            cbo_fiscalYear.Items.Add("March");
            cbo_fiscalYear.Items.Add("April");
            cbo_fiscalYear.Items.Add("May");
            cbo_fiscalYear.Items.Add("June");
            cbo_fiscalYear.Items.Add("July");
            cbo_fiscalYear.Items.Add("August");
            cbo_fiscalYear.Items.Add("September");
            cbo_fiscalYear.Items.Add("October");
            cbo_fiscalYear.Items.Add("November");
            cbo_fiscalYear.Items.Add("December");

            cbo_taxYear.Items.Clear();
            cbo_taxYear.Items.Add("January");
            cbo_taxYear.Items.Add("February");
            cbo_taxYear.Items.Add("March");
            cbo_taxYear.Items.Add("April");
            cbo_taxYear.Items.Add("May");
            cbo_taxYear.Items.Add("June");
            cbo_taxYear.Items.Add("July");
            cbo_taxYear.Items.Add("August");
            cbo_taxYear.Items.Add("September");
            cbo_taxYear.Items.Add("October");
            cbo_taxYear.Items.Add("November");
            cbo_taxYear.Items.Add("December");

            cbo_incomeTaxFormUsed.Items.Clear();
            cbo_incomeTaxFormUsed.Items.Add("Form 1120 (Corporation)");
            cbo_incomeTaxFormUsed.Items.Add("Form 1120S (S Corporation)");
            cbo_incomeTaxFormUsed.Items.Add("Form 1065 (Partnership)");
            cbo_incomeTaxFormUsed.Items.Add("Form 990 (Exempt Organization)");
            cbo_incomeTaxFormUsed.Items.Add("Form 990-PF (Ret of Priv Foundn)");
            cbo_incomeTaxFormUsed.Items.Add("Form 990-T (Bus Tx Ret)");
            cbo_incomeTaxFormUsed.Items.Add("Form 1040 (Sole Proprietor)");
            cbo_incomeTaxFormUsed.Items.Add("<Other/None>");
        }

        private void CompanyList_Load(object sender, EventArgs e)
        {
            
           
        }

        private void grid_company_Init()
        {
            grid_company.AutoGenerateColumns = false;
            grid_company.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_company.ColumnCount = 5;

            grid_company.Columns[0].Name = "";
            grid_company.Columns[0].Visible = false;
            grid_company.Columns[0].Width = 80;
            grid_company.Columns[0].MinimumWidth = 80;
            grid_company.Columns[0].DataPropertyName = "";

            grid_company.Columns[1].Name = "";
            grid_company.Columns[1].Visible = false;
            grid_company.Columns[1].Width = 70;
            grid_company.Columns[1].MinimumWidth = 70;
            grid_company.Columns[1].DataPropertyName = "";

            grid_company.Columns[2].Name = "Code";
            grid_company.Columns[2].ReadOnly = true;
            grid_company.Columns[2].Width = 110;
            grid_company.Columns[2].MinimumWidth = 110;
            grid_company.Columns[2].DataPropertyName = "CompanyCode";

            grid_company.Columns[3].Name = "Name";
            grid_company.Columns[3].ReadOnly = true;
            grid_company.Columns[3].Width = 300;
            grid_company.Columns[3].MinimumWidth = 300;
            grid_company.Columns[3].DataPropertyName = "CompanyName";

            grid_company.Columns[4].Name = "Status";
            grid_company.Columns[4].ReadOnly = true;
            grid_company.Columns[4].Width = 60;
            grid_company.Columns[4].MinimumWidth = 60;
            grid_company.Columns[4].DataPropertyName = "CompanyStatus";
            

            //grid font size custom
            grid_company.RowTemplate.Height = 20;
            grid_company.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_company.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_company.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_company_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CompanyObject companyObject = new CompanyObject();

            String CustomerCode = grid_company.Rows[e.RowIndex].Cells["Code"].Value.ToString().Trim();
            companyObject = connSalesOrder.sp_GET_CompanyObject(CustomerCode);

            txt_companyCode.Text = companyObject.CompanyCode;
            txt_companyName.Text = companyObject.CompanyName;
            cbo_companyStatus.Text = companyObject.CompanyStatus;
            txt_companyAddress.Text = companyObject.CompanyAddress;
            cbo_companyCountry.Text = companyObject.CompanyCountry;
            txt_companyPhone.Text = companyObject.CompanyPhone;
            txt_companyFax.Text = companyObject.CompanyFax;
            txt_companyEmail.Text = companyObject.CompanyEmail;
            txt_companyWebsite.Text = companyObject.CompanyWebsite;

            txt_legalName.Text = companyObject.LegalName;
            txt_legalAddress1.Text = companyObject.LegalAddress1;
            txt_legalAddress2.Text = companyObject.LegalAddress2;
            txt_legalCity.Text = companyObject.LegalCity;
            txt_legalState.Text = companyObject.LegalState;
            txt_legalZIP.Text = companyObject.LegalZIP;
            cbo_legalCountry.Text = companyObject.LegalCountry;

            cbo_fiscalYear.Text = companyObject.FiscalYear;
            cbo_taxYear.Text = companyObject.TaxYear;
            cbo_incomeTaxFormUsed.Text = companyObject.IncomeTaxFormUsed;

            txt_FEIN.Text = companyObject.FEIN;
            txt_SSN.Text = companyObject.SSN;

            txt_payrollContact.Text = companyObject.PayrollContact;
            txt_payrollTitle.Text = companyObject.PayrollTitle;
            txt_payrollPhone.Text = companyObject.PayrollPhone;
            
            btn_save.Enabled = true;
            btn_newSave.Visible = false;
            btn_new.Enabled = true;
            
            txt_companyCode.Enabled = false;
            txt_companyName.Enabled = false;
            txt_companyAddress.Enabled = false;
            cbo_companyCountry.Enabled = false;
            //txt_companyPhone.Enabled = false;
            //txt_companyFax.Enabled = false;
            //txt_companyEmail.Enabled = false;
            //txt_companyWebsite.Enabled = false;

            txt_legalName.Enabled = false;
            txt_legalAddress1.Enabled = false;
            txt_legalAddress2.Enabled = false;
            txt_legalCity.Enabled = false;
            txt_legalState.Enabled = false;
            txt_legalZIP.Enabled = false;
            cbo_legalCountry.Enabled = false;

            cbo_fiscalYear.Enabled = false;
            cbo_taxYear.Enabled = false;
            cbo_incomeTaxFormUsed.Enabled = false;

            txt_FEIN.Enabled = false;
            txt_SSN.Enabled = false;

            //txt_payrollContact.Enabled = false;
            //txt_payrollTitle.Enabled = false;
            //txt_payrollPhone.Enabled = false;
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirming update customer, " + txt_companyCode.Text.Trim() + " information."
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    CompanyObject companyObject = new CompanyObject();

                    companyObject.CompanyCode = txt_companyCode.Text;
                    companyObject.CompanyStatus = cbo_companyStatus.Text;

                    companyObject.CompanyPhone = txt_companyPhone.Text;
                    companyObject.CompanyFax = txt_companyFax.Text;
                    companyObject.CompanyEmail = txt_companyEmail.Text;
                    companyObject.CompanyWebsite = txt_companyWebsite.Text;
                    
                    companyObject.PayrollContact = txt_payrollContact.Text;
                    companyObject.PayrollTitle = txt_payrollTitle.Text;
                    companyObject.PayrollPhone = txt_payrollPhone.Text;

                     connSalesOrder.sp_UPDATE_CompanyInfo(companyObject);

                    MessageBox.Show("Company, " + companyObject.CompanyCode + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {

                }

            }
        }

        private void searchCompany()
        {
            String SearchCompanyCode = txt_searchCompanyCode.Text.Trim();
            String SearchCompanyName = txt_searchCompanyName.Text.Trim();

            String SearchCompanyStatus = "";
            if (cbx_inactive.Checked)
            {
                SearchCompanyStatus = "ALL";
            }
            else
            {
                SearchCompanyStatus = "Active";
            }
            connPO.sp_LIST_COMPANY(grid_company, SearchCompanyCode, SearchCompanyName, SearchCompanyStatus);
        }

        private void cbx_inactive_CheckedChanged(object sender, EventArgs e)
        {
            searchCompany();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_companyCode.Text = "";
            txt_companyName.Text = "";
            cbo_companyStatus.Text = "Active";
            txt_companyAddress.Text = "";
            cbo_companyCountry.Text = "US";
            txt_companyPhone.Text = "";
            txt_companyFax.Text = "";
            txt_companyEmail.Text = "";
            txt_companyWebsite.Text = "";

            txt_legalName.Text = "";
            txt_legalAddress1.Text = "";
            txt_legalAddress2.Text = "";
            txt_legalCity.Text = "";
            txt_legalState.Text = "";
            txt_legalZIP.Text = "";
            cbo_legalCountry.Text = "US";

            cbo_fiscalYear.Text = "January";
            cbo_taxYear.Text = "January";
            cbo_incomeTaxFormUsed.Text = "Form 1120 (Corporation)";

            txt_FEIN.Text = "";
            txt_SSN.Text = "";

            txt_payrollContact.Text = "";
            txt_payrollTitle.Text = "";
            txt_payrollPhone.Text = "";

            txt_companyCode.Enabled = true;
            txt_companyName.Enabled = true;
            txt_companyAddress.Enabled = true;
            cbo_companyCountry.Enabled = true;

            txt_legalName.Enabled = true;
            txt_legalAddress1.Enabled = true;
            txt_legalAddress2.Enabled = true;
            txt_legalCity.Enabled = true;
            txt_legalState.Enabled = true;
            txt_legalZIP.Enabled = true;
            cbo_legalCountry.Enabled = true;

            cbo_fiscalYear.Enabled = true;
            cbo_taxYear.Enabled = true;
            cbo_incomeTaxFormUsed.Enabled = true;

            txt_FEIN.Enabled = true;
            txt_SSN.Enabled = true;


            btn_save.Enabled = false;
            btn_newSave.Visible = true;

            btn_new.Enabled = false;

        }

        private void btn_newSave_Click(object sender, EventArgs e)
        {
            if (txt_companyCode.Text.Trim() == "")
            {
                MessageBox.Show("Please insert Company Code"
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (connSalesOrder.sp_CHECK_NewCompanyCode(txt_companyCode.Text.Trim()) == true)
            {
                MessageBox.Show("Company Code already exist."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Save a new company?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    CompanyObject companyObject = new CompanyObject();
                    

                    companyObject.CompanyCode = txt_companyCode.Text;
                    companyObject.CompanyName = txt_companyName.Text;
                    companyObject.CompanyStatus = cbo_companyStatus.Text;
                    companyObject.CompanyAddress = txt_companyAddress.Text;
                    companyObject.CompanyCountry = cbo_companyCountry.Text;
                    companyObject.CompanyPhone = txt_companyPhone.Text;
                    companyObject.CompanyFax = txt_companyFax.Text;
                    companyObject.CompanyEmail = txt_companyEmail.Text;
                    companyObject.CompanyWebsite = txt_companyWebsite.Text;

                    companyObject.LegalName = txt_legalName.Text;
                    companyObject.LegalAddress1 = txt_legalAddress1.Text;
                    companyObject.LegalAddress2 = txt_legalAddress2.Text;
                    companyObject.LegalCity = txt_legalCity.Text;
                    companyObject.LegalState = txt_legalState.Text;
                    companyObject.LegalZIP = txt_legalZIP.Text;
                    companyObject.LegalCountry = cbo_legalCountry.Text;

                    companyObject.FiscalYear = cbo_fiscalYear.Text;
                    companyObject.TaxYear = cbo_taxYear.Text;
                    companyObject.IncomeTaxFormUsed = cbo_incomeTaxFormUsed.Text;

                    companyObject.FEIN = txt_FEIN.Text;
                    companyObject.SSN = txt_SSN.Text;

                    companyObject.PayrollContact = txt_payrollContact.Text;
                    companyObject.PayrollTitle = txt_payrollTitle.Text;
                    companyObject.PayrollPhone = txt_payrollPhone.Text;
                    
                    connSalesOrder.sp_INSERT_NewCompany(companyObject);

                    MessageBox.Show("Company, " + companyObject.CompanyCode + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    String SearchCompanyCode = txt_searchCompanyCode.Text.Trim();
                    String SearchCompanyName = txt_searchCompanyName.Text.Trim();

                    String SearchCompanyStatus = "";
                    if (cbx_inactive.Checked)
                    {
                        SearchCompanyStatus = "ALL";
                    }
                    else
                    {
                        SearchCompanyStatus = "Active";
                    }

                    connPO.sp_LIST_COMPANY(grid_company, SearchCompanyCode, SearchCompanyName, SearchCompanyStatus);

                }
                catch
                {
                    MessageBox.Show("Input all Company information."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchCompany();
            }
        }

    }
}
