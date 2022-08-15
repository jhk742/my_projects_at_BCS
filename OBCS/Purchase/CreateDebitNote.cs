using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBCS.Entities;

namespace OBCS.Purchase
{
    public partial class CreateDebitNote : Form
    {
        public bool save;

        public CreateDebitNote()
        {
            InitializeComponent();

            connPO.cbox_getVendorID(cbo_supplierID);

            cbo_glAccountName.Items.Add("");
            cbo_glAccountName.Items.Add("Chargebacks");
            cbo_glAccountName.Items.Add("Duty,Freight & Brokerage");
            cbo_glAccountName.SelectedIndex = 0;
            txt_glAccountNumber.Text = "";

            cbo_site.Items.Add("BCS");
            cbo_site.Items.Add("WH2");
            cbo_site.SelectedIndex = 0;

            txt_invoicingCompany.Text = "BIC";
            txt_supplierName.Text = "";
            txt_poNumber.Text = "";

            save = false;
        }
        
        private void btn_create_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbl_PO.Text + txt_poNumber.Text.Trim());
            if (cbo_supplierID.Text == "" || cbo_glAccountName.Text == "" || txt_amount.Text.Trim() == "" ||  cbo_site.Text == "") //txt_docNo.Text.Trim() == "" ||
            {
                MessageBox.Show("Please input all informations." , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                if(Convert.ToDecimal(txt_amount.Text) <= 0)
                {
                    MessageBox.Show("Please input valid value.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please input valid value.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            DialogResult dialogResult = MessageBox.Show("Create Debit Memo."
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //Get a new PIN Number from Server 12/24/2018
                String NewPINNumber = connSalesOrder.sp_GET_NewPINNumber();
                String TypeCode = cbo_type.Text.Trim();
                String SupplierID = cbo_supplierID.Text.Trim();
                Decimal Amount = Convert.ToDecimal(txt_amount.Text.Trim());
                String DocNumber = txt_docNo.Text.Trim();
                String InvoicingSite = cbo_site.Text.Trim();
                String PONumber = lbl_PO.Text + txt_poNumber.Text.Trim();
                String GLAccountName = cbo_glAccountName.Text.Trim();
                String GLAccountNumber = txt_glAccountNumber.Text.Trim();

                String ReturnMessage;
                if (GLAccountName == "Chargebacks")
                {
                    ReturnMessage = connPO.sp_CREATE_PINVOICE_CHARGEBACK(SupplierID, DocNumber, PONumber, Amount, InvoicingSite, NewPINNumber, TypeCode); // 20100(-1), 62225(1)
                }
                else // (Type == "Freight")
                {
                    ReturnMessage = connPO.sp_CREATE_PINVOICE_FREIGHT(SupplierID, DocNumber, PONumber, Amount, InvoicingSite, NewPINNumber, TypeCode); // 20100(-1). 51200(1)
                }
                
                if(ReturnMessage != "OK")
                {
                    //MessageBox.Show(ReturnMessage);
                    return;
                }

                cbo_supplierID.Text = "";
                txt_amount.Text = "";
                txt_docNo.Text = "";
                save = true;
                //todo: grid update

                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save = true;
            Close();
        }

        private void cbo_supplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            SupplierObject supplierObject = new SupplierObject();

            String SupplierID = cbo_supplierID.Text.Trim();
            supplierObject = connSalesOrder.sp_GET_SupplierObject(SupplierID);
            txt_supplierName.Text = supplierObject.SupplierName.ToString();


            cbo_poNumber.Items.Clear();
            cbo_poNumber.Items.Add("");
            connPO.sp_GET_PONumberBySupplierID(cbo_poNumber, cbo_supplierID.Text.Trim());
            */
        }

        private void cbo_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_glAccountName.Text == "Chargebacks")
            {
                txt_glAccountNumber.Text = "62225";

                cbo_type.Items.Clear();
                connPO.cbo_DebitNote_Code(cbo_glAccountName.Text, cbo_type);
                cbo_type.SelectedIndex = 0;
            }
            else if(cbo_glAccountName.Text == "Duty,Freight & Brokerage")
            {
                txt_glAccountNumber.Text = "51200";

                cbo_type.Items.Clear();
                connPO.cbo_DebitNote_Code(cbo_glAccountName.Text, cbo_type);
                cbo_type.SelectedIndex = 0;
            }
        }

        private void cbo_type_SelectedValueChanged(object sender, EventArgs e)
        {
            connSalesOrder.GETSTKReasonText("PIN", cbo_type.Text.ToString(), txt_typeName);
        }
    }
}
