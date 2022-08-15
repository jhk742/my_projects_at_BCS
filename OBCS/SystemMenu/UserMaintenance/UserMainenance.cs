using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBCS.Entities;
using OBCS.SystemMenu.UserMaintenance;

namespace OBCS
{
    public partial class PASS : Form
    {
        public static string newUserID = "";
        Double nCount = 0;

        public PASS()
        {
            InitializeComponent();
            this.Text = "User Maintenance";

            fill_pass();

            treeView1.ExpandAll();

            cbo_userStatus.Items.Add("Active");
            cbo_userStatus.Items.Add("Inactive");
            cbo_userStatus.SelectedIndex = 0;

            //this.dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            //this.dateTimePickerStartDate.CustomFormat = " ";
            //this.dateTimePickerEndDate.Format = DateTimePickerFormat.Custom;
            //this.dateTimePickerEndDate.CustomFormat = " ";

        }

        private bool NodeExists(TreeNode node, string key)
        {
            foreach (TreeNode subNode in node.Nodes)
            {
                if (subNode.Text == key)
                {
                    return true;
                }
                if (node.Nodes.Count > 0)
                {
                    NodeExists(node, key);
                }
            }
            return false;
        }

        private void HandleOnTreeViewAfterCheck(Object sender,
       TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }

        private void CheckTreeViewNode(TreeNode node, Boolean isChecked)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;

                if (item.Nodes.Count > 0)
                {
                    this.CheckTreeViewNode(item, isChecked);
                }
            }
        }

        public void fill_pass()
        {
            grid_user.AllowDrop = true;
            grid_user.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_user.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            grid_user.AutoGenerateColumns = false;
            grid_user.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_user.ColumnCount = 9;
            grid_user.ReadOnly = true;

            grid_user.Columns[0].Name = "User ID";
            grid_user.Columns[0].Width = 80;
            grid_user.Columns[0].MinimumWidth = 80;
            grid_user.Columns[0].DataPropertyName = "P_ID";

            grid_user.Columns[1].Name = "Name";
            grid_user.Columns[1].Width = 120;
            grid_user.Columns[1].MinimumWidth = 120;
            grid_user.Columns[1].DataPropertyName = "P_NAME";

            grid_user.Columns[2].Name = "Department";
            grid_user.Columns[2].Width = 80;
            grid_user.Columns[2].MinimumWidth = 80;
            grid_user.Columns[2].DataPropertyName = "P_DEPARTMENT";

            grid_user.Columns[3].Name = "Phone Number";
            grid_user.Columns[3].Width = 80;
            grid_user.Columns[3].MinimumWidth = 80;
            grid_user.Columns[3].DataPropertyName = "P_PHONE";

            grid_user.Columns[4].Name = "Start Date";
            grid_user.Columns[4].Width = 80;
            grid_user.Columns[4].MinimumWidth = 80;
            grid_user.Columns[4].DataPropertyName = "P_STARTDATE";

            grid_user.Columns[5].Name = "End Date";
            grid_user.Columns[5].Width = 80;
            grid_user.Columns[5].MinimumWidth = 80;
            grid_user.Columns[5].DataPropertyName = "P_ENDDATE";

            grid_user.Columns[6].Name = "Emergency Contact Name";
            grid_user.Columns[6].Visible = false;
            grid_user.Columns[6].Width = 100;
            grid_user.Columns[6].MinimumWidth = 100;
            grid_user.Columns[6].DataPropertyName = "P_EMERGENCYCONTACTNAME";

            grid_user.Columns[7].Name = "Emergency Contact Number";
            grid_user.Columns[7].Visible = false;
            grid_user.Columns[7].Width = 100;
            grid_user.Columns[7].MinimumWidth = 100;
            grid_user.Columns[7].DataPropertyName = "P_EMERGENCYCONTACTNUMBER";

            grid_user.Columns[8].Name = "Status";
            grid_user.Columns[8].Width = 60;
            grid_user.Columns[8].MinimumWidth = 60;
            grid_user.Columns[8].DataPropertyName = "P_STATUS";

            for (int i = 0; i < grid_user.RowCount; i++)
            {
                nCount += 1;
                for (int j = 0; j < grid_user.ColumnCount; j++)
                {
                    //grid_user.Rows[i].Cells[j].Value = grid_user.Rows[i].Cells[j].Value.ToString().Trim();
                    //MessageBox.Show(grid_user.Rows[i].Cells[j].Value.ToString());
                }
            }
            txt_count.Text = nCount.ToString();
            txt_count.TextAlign = HorizontalAlignment.Right;
            newUserID = "";
        }
        private void PASS_Load(object sender, EventArgs e)
        {
            
            conn.User_Active(grid_user);

            Color_SetUp();
        }

        private void Color_SetUp()
        {
            try
            {
                foreach (DataGridViewRow row in this.grid_user.Rows)
                {
                    if (row.Cells["Status"].Value.Equals("Inactive"))
                    {
                        for (int i = 0; i < grid_user.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Gray;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < grid_user.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.White;
                        }
                    }
                }
            }
            catch { }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //if(GATE.userID == "ADMIN")
            //{
            //    PASS_ADD pASS_ADD = new PASS_ADD();
            //    //pASS_ADD.Dock = DockStyle.Fill;
            //    //pASS_ADD.MdiParent = this.MdiParent;
            //    //pASS_ADD.TopLevel = false;
            //    pASS_ADD.ShowDialog();

            //    if(PASS_ADD.newUserID != "")
            //    {
            //        newUserID = PASS_ADD.newUserID.ToString();
            //        PASS_MOD pASS_MOD = new PASS_MOD();
            //        pASS_MOD.ShowDialog();

            //        conn.User(this.grid_user);
            //        this.grid_user.ClearSelection();
            //    }
            //}
            //else { MessageBox.Show("Only OBCS use."); }

            panel_pw.Visible = true;
            panel_info.Location = new Point(3, 187);

            grid_user.ClearSelection();
            btn_add.Enabled = false;
            cbo_userStatus.Text = "Active";
            txt_userid.Text = "";
            txt_userid.Enabled = true;
            btn_changePassword.Visible = false;
            txt_name.Text = "";
            txt_email.Text = "";
            txt_department.Text = "";
            txt_phoneNumber.Text = "";
            dateTimePickerStartDate.Value = Convert.ToDateTime("01/01/1900");
            dateTimePickerEndDate.Value = Convert.ToDateTime("01/01/1900");
            txt_emergencyContactName.Text = "";
            txt_emergencyContactNumber.Text = "";

            panel1.Visible = false;

        }

        
        private void grid_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (grid_user.CurrentCell == null ||
            //    grid_user.CurrentCell.Value == null ||
            //    e.RowIndex == -1) return;
            //if (e.ColumnIndex == 0)
            //{
            //    newUserID = grid_user.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    PASS_MOD pASS_MOD = new PASS_MOD();
            //    pASS_MOD.ShowDialog();

            //    conn.User(this.grid_user);
            //    this.grid_user.ClearSelection();
            //}
            //String UserID = grid_user.Rows[e.RowIndex].Cells["User ID"].Value.ToString().Trim();
            //String Name = grid_user.Rows[e.RowIndex].Cells["Name"].Value.ToString().Trim();
            //String Department = grid_user.Rows[e.RowIndex].Cells["Department"].Value.ToString().Trim();
            //String PhoneNumber = grid_user.Rows[e.RowIndex].Cells["Phone Number"].Value.ToString().Trim();
            ////DateTime StartDate = Convert.ToDateTime(grid_user.Rows[e.RowIndex].Cells["Start Date"].Value.ToString().Trim());
            ////DateTime EndDate = Convert.ToDateTime(grid_user.Rows[e.RowIndex].Cells["End Date"].Value.ToString().Trim());
            //String EmergencyContactName = grid_user.Rows[e.RowIndex].Cells["Emergency Contact Name"].Value.ToString().Trim();
            //String EmergencyContactNumber = grid_user.Rows[e.RowIndex].Cells["Emergency Contact Number"].Value.ToString().Trim();

            //txt_userid.Text = UserID;
            //txt_name.Text = Name;
            //txt_department.Text = Department;
            //txt_phoneNumber.Text = PhoneNumber;
            //txt_emergencyContactName.Text = EmergencyContactName;
            //txt_emergencyContactNumber.Text = EmergencyContactNumber;
        }

        private void PASS_Activated(object sender, EventArgs e)
        {
            this.grid_user.ClearSelection();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        List<String> CheckedNodes = new List<String>();
        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_userid.Text.Trim() == "")
            {
                MessageBox.Show("Input User ID.");
                return;
            }
            //MessageBox.Show(string.Join(",", CheckedNodes));

            String UserStatus = cbo_userStatus.Text;
            String UserID = txt_userid.Text;
            String Password = txt_password.Text;
            String ConfirmPassword = txt_comfirmPassword.Text;
            String FullName = txt_name.Text;
            String Email = txt_email.Text;
            String Department = txt_department.Text;
            String PhoneNumber = txt_phoneNumber.Text;
            DateTime StartDate = dateTimePickerStartDate.Value;
            DateTime EndDate = dateTimePickerEndDate.Value;
            String EmergencyContactName = txt_emergencyContactName.Text;
            String EmergencyContactNumber = txt_emergencyContactNumber.Text;

            UserObject userObject = new UserObject();
            userObject.UserStatus = UserStatus;
            userObject.UserID = UserID;
            userObject.Password = MD5(txt_password.Text);
            userObject.ConfirmPassword = MD5(txt_comfirmPassword.Text);
            userObject.FullName = FullName;
            userObject.Email = Email;
            userObject.Department = Department;
            userObject.PhoneNumber = PhoneNumber;
            userObject.StartDate = StartDate;
            userObject.EndDate = EndDate;
            userObject.EmergencyContactName = EmergencyContactName;
            userObject.EmergencyContactNumber = EmergencyContactNumber;

            //menu
            if (accounting.Checked) { userObject.accounting = true; } else { userObject.accounting = false; }
            if (sales.Checked) { userObject.sales = true; } else { userObject.sales = false; }
            if (accountsReceivable.Checked) { userObject.accountsReceivable = true; } else { userObject.accountsReceivable = false; }
            if (purchaseOrder.Checked) { userObject.purchaseOrder = true; } else { userObject.purchaseOrder = false; }
            if (accountsPayable.Checked) { userObject.accountsPayable = true; } else { userObject.accountsPayable = false; }
            if (stock.Checked) { userObject.stock = true; } else { userObject.stock = false; }
            if (mWMS.Checked) { userObject.mWMS = true; } else { userObject.mWMS = false; }
            if (lists.Checked) { userObject.lists = true; } else { userObject.lists = false; }
            if (map.Checked) { userObject.map = true; } else { userObject.map = false; }
            if (systemMenu.Checked) { userObject.systemMenu = true; } else { userObject.systemMenu = false; }
            if (generalJournalEntries.Checked) { userObject.generalJournalEntries = true; } else { userObject.generalJournalEntries = false; }
            if (profitAndLossReport.Checked) { userObject.profitAndLossReport = true; } else { userObject.profitAndLossReport = false; }
            if (salesOrder.Checked) { userObject.salesOrder = true; } else { userObject.salesOrder = false; }
            if (auditSalesOrder.Checked) { userObject.auditSalesOrder = true; } else { userObject.auditSalesOrder = false; }
            if (confirmedSalesOrder.Checked) { userObject.confirmedSalesOrder = true; } else { userObject.confirmedSalesOrder = false; }
            if (preparationPlan.Checked) { userObject.preparationPlan = true; } else { userObject.preparationPlan = false; }
            if (pickingTicket.Checked) { userObject.pickingTicket = true; } else { userObject.pickingTicket = false; }
            if (deliveryNote.Checked) { userObject.deliveryNote = true; } else { userObject.deliveryNote = false; }
            if (duplicateSalesOrder.Checked) { userObject.duplicateSalesOrder = true; } else { userObject.duplicateSalesOrder = false; }
            if (deallocation.Checked) { userObject.deallocation = true; } else { userObject.deallocation = false; }
            if (packageNutLabel.Checked) { userObject.packageNutLabel = true; } else { userObject.packageNutLabel = false; }
            if (salesReport.Checked) { userObject.salesReport = true; } else { userObject.salesReport = false; }
            if (packageNutLabelPrint.Checked) { userObject.packageNutLabelPrint = true; } else { userObject.packageNutLabelPrint = false; }
            if (packageNutCustomerOption.Checked) { userObject.packageNutCustomerOption = true; } else { userObject.packageNutCustomerOption = false; }
            if (packageNutCustomPrice.Checked) { userObject.packageNutCustomPrice = true; } else { userObject.packageNutCustomPrice = false; }
            if (salesOrderExceptionReport.Checked) { userObject.salesOrderExceptionReport = true; } else { userObject.salesOrderExceptionReport = false; }
            if (salesbyRepReport.Checked) { userObject.salesbyRepReport = true; } else { userObject.salesbyRepReport = false; }
            if (salesbyCustomerReport.Checked) { userObject.salesbyCustomerReport = true; } else { userObject.salesbyCustomerReport = false; }
            if (salesbyProductReport.Checked) { userObject.salesbyProductReport = true; } else { userObject.salesbyProductReport = false; }
            if (salesPerformanceReport.Checked) { userObject.salesPerformanceReport = true; } else { userObject.salesPerformanceReport = false; }
            if (nutCategorySalesReport.Checked) { userObject.nutCategorySalesReport = true; } else { userObject.nutCategorySalesReport = false; }
            if (commissionReport.Checked) { userObject.commissionReport = true; } else { userObject.commissionReport = false; }
            if (collectionfromDelivery.Checked) { userObject.collectionfromDelivery = true; } else { userObject.collectionfromDelivery = false; }
            if (collectionfromSales.Checked) { userObject.collectionfromSales = true; } else { userObject.collectionfromSales = false; }
            if (validation.Checked) { userObject.validation = true; } else { userObject.validation = false; }
            if (invoice.Checked) { userObject.invoice = true; } else { userObject.invoice = false; }
            if (creditMemoRequest.Checked) { userObject.creditMemoRequest = true; } else { userObject.creditMemoRequest = false; }
            if (netSettlement.Checked) { userObject.netSettlement = true; } else { userObject.netSettlement = false; }
            if (arPayment.Checked) { userObject.arPayment = true; } else { userObject.arPayment = false; }
            if (entryBatch.Checked) { userObject.entryBatch = true; } else { userObject.entryBatch = false; }
            if (deposit.Checked) { userObject.deposit = true; } else { userObject.deposit = false; }
            if (writeoff.Checked) { userObject.writeoff = true; } else { userObject.writeoff = false; }
            if (arReports.Checked) { userObject.arReports = true; } else { userObject.arReports = false; }
            if (arAging.Checked) { userObject.arAging = true; } else { userObject.arAging = false; }
            if (arbyCustomerReport.Checked) { userObject.arbyCustomerReport = true; } else { userObject.arbyCustomerReport = false; }
            if (arbySalespersonReport.Checked) { userObject.arbySalespersonReport = true; } else { userObject.arbySalespersonReport = false; }
            if (arCollectionsSummary.Checked) { userObject.arCollectionsSummary = true; } else { userObject.arCollectionsSummary = false; }
            if (arSalesDebitMemoSummary.Checked) { userObject.arSalesDebitMemoSummary = true; } else { userObject.arSalesDebitMemoSummary = false; }
            if (arOverpayment.Checked) { userObject.arOverpayment = true; } else { userObject.arOverpayment = false; }
            if (nonSufficientFundsReport.Checked) { userObject.nonSufficientFundsReport = true; } else { userObject.nonSufficientFundsReport = false; }
            if (promotionSchedule.Checked) { userObject.promotionSchedule = true; } else { userObject.promotionSchedule = false; }
            if (poPrepare.Checked) { userObject.poPrepare = true; } else { userObject.poPrepare = false; }
            if (po.Checked) { userObject.po = true; } else { userObject.po = false; }
            if (goodsReceipt.Checked) { userObject.goodsReceipt = true; } else { userObject.goodsReceipt = false; }
            if (poReports.Checked) { userObject.poReports = true; } else { userObject.poReports = false; }
            if (poExceptionReport.Checked) { userObject.poExceptionReport = true; } else { userObject.poExceptionReport = false; }
            if (subcontractOrderExceptionReport.Checked) { userObject.subcontractOrderExceptionReport = true; } else { userObject.subcontractOrderExceptionReport = false; }
            if (poManagementReport.Checked) { userObject.poManagementReport = true; } else { userObject.poManagementReport = false; }
            if (poManagementDetailReport.Checked) { userObject.poManagementDetailReport = true; } else { userObject.poManagementDetailReport = false; }
            if (poForecastReport.Checked) { userObject.poForecastReport = true; } else { userObject.poForecastReport = false; }
            if (poDepartmentSalesReport.Checked) { userObject.poDepartmentSalesReport = true; } else { userObject.poDepartmentSalesReport = false; }
            if (apValidation.Checked) { userObject.apValidation = true; } else { userObject.apValidation = false; }
            if (apDebitNote.Checked) { userObject.apDebitNote = true; } else { userObject.apDebitNote = false; }
            if (apCreditMemoRequest.Checked) { userObject.apCreditMemoRequest = true; } else { userObject.apCreditMemoRequest = false; }
            if (apDebitMemoRequest.Checked) { userObject.apDebitMemoRequest = true; } else { userObject.apDebitMemoRequest = false; }
            if (apNetSettlement.Checked) { userObject.apNetSettlement = true; } else { userObject.apNetSettlement = false; }
            if (paymentResolution.Checked) { userObject.paymentResolution = true; } else { userObject.paymentResolution = false; }
            if (apPayment.Checked) { userObject.apPayment = true; } else { userObject.apPayment = false; }
            if (apReports.Checked) { userObject.apReports = true; } else { userObject.apReports = false; }
            if (apAging.Checked) { userObject.apAging = true; } else { userObject.apAging = false; }
            if (assembly.Checked) { userObject.assembly = true; } else { userObject.assembly = false; }
            if (assemblyRecipt.Checked) { userObject.assemblyRecipt = true; } else { userObject.assemblyRecipt = false; }
            if (disassembly.Checked) { userObject.disassembly = true; } else { userObject.disassembly = false; }
            if (disassemblyReceipt.Checked) { userObject.disassemblyReceipt = true; } else { userObject.disassemblyReceipt = false; }
            if (manufacturing.Checked) { userObject.manufacturing = true; } else { userObject.manufacturing = false; }
            if (manufacturingReceipt.Checked) { userObject.manufacturingReceipt = true; } else { userObject.manufacturingReceipt = false; }
            if (miscellaneousIssue.Checked) { userObject.miscellaneousIssue = true; } else { userObject.miscellaneousIssue = false; }
            if (miscellaneousReceipt.Checked) { userObject.miscellaneousReceipt = true; } else { userObject.miscellaneousReceipt = false; }
            if (subcontractOrder.Checked) { userObject.subcontractOrder = true; } else { userObject.subcontractOrder = false; }
            if (subcontractReceipt.Checked) { userObject.subcontractReceipt = true; } else { userObject.subcontractReceipt = false; }
            if (intersiteTransfer.Checked) { userObject.intersiteTransfer = true; } else { userObject.intersiteTransfer = false; }
            if (receiptReturn.Checked) { userObject.receiptReturn = true; } else { userObject.receiptReturn = false; }
            if (shipmentReturn.Checked) { userObject.shipmentReturn = true; } else { userObject.shipmentReturn = false; }
            if (stockChange.Checked) { userObject.stockChange = true; } else { userObject.stockChange = false; }
            if (stockReports.Checked) { userObject.stockReports = true; } else { userObject.stockReports = false; }
            if (ipadShortageReport.Checked) { userObject.ipadShortageReport = true; } else { userObject.ipadShortageReport = false; }
            if (globalShortageReport.Checked) { userObject.globalShortageReport = true; } else { userObject.globalShortageReport = false; }
            if (detailedShortageReport.Checked) { userObject.detailedShortageReport = true; } else { userObject.detailedShortageReport = false; }
            if (inventoryManagement.Checked) { userObject.inventoryManagement = true; } else { userObject.inventoryManagement = false; }
            if (miscellaneousTransactionReport.Checked) { userObject.miscellaneousTransactionReport = true; } else { userObject.miscellaneousTransactionReport = false; }
            if (stockTransactionReport.Checked) { userObject.stockTransactionReport = true; } else { userObject.stockTransactionReport = false; }
            if (stockMovementReport.Checked) { userObject.stockMovementReport = true; } else { userObject.stockMovementReport = false; }
            if (stockValuationReport.Checked) { userObject.stockValuationReport = true; } else { userObject.stockValuationReport = false; }
            if (wmsGoodsReceipt.Checked) { userObject.wmsGoodsReceipt = true; } else { userObject.wmsGoodsReceipt = false; }
            if (wmsStockStatusChange.Checked) { userObject.wmsStockStatusChange = true; } else { userObject.wmsStockStatusChange = false; }
            if (wmsShipmentReturn.Checked) { userObject.wmsShipmentReturn = true; } else { userObject.wmsShipmentReturn = false; }
            if (IntersiteTransferOrder.Checked) { userObject.IntersiteTransferOrder = true; } else { userObject.IntersiteTransferOrder = false; }
            if (IntersiteTransferReceipt.Checked) { userObject.IntersiteTransferReceipt = true; } else { userObject.IntersiteTransferReceipt = false; }
            if (wmsCustomerDelivery.Checked) { userObject.wmsCustomerDelivery = true; } else { userObject.wmsCustomerDelivery = false; }
            if (wmsReceiptReturn.Checked) { userObject.wmsReceiptReturn = true; } else { userObject.wmsReceiptReturn = false; }
            if (brandList.Checked) { userObject.brandList = true; } else { userObject.brandList = false; }
            if (chartOfAccount.Checked) { userObject.chartOfAccount = true; } else { userObject.chartOfAccount = false; }
            if (companyList.Checked) { userObject.companyList = true; } else { userObject.companyList = false; }
            if (customerList.Checked) { userObject.customerList = true; } else { userObject.customerList = false; }
            if (customerPriceEntry.Checked) { userObject.customerPriceEntry = true; } else { userObject.customerPriceEntry = false; }
            if (deliveryRoutePlanList.Checked) { userObject.deliveryRoutePlanList = true; } else { userObject.deliveryRoutePlanList = false; }
            if (driverList.Checked) { userObject.driverList = true; } else { userObject.driverList = false; }
            if (paymentTermList.Checked) { userObject.paymentTermList = true; } else { userObject.paymentTermList = false; }
            if (productList.Checked) { userObject.productList = true; } else { userObject.productList = false; }
            if (promotionScheduleTypeList.Checked) { userObject.promotionScheduleTypeList = true; } else { userObject.promotionScheduleTypeList = false; }
            if (salesPersonList.Checked) { userObject.salesPersonList = true; } else { userObject.salesPersonList = false; }
            if (supplierList.Checked) { userObject.supplierList = true; } else { userObject.supplierList = false; }
            if (customerMap.Checked) { userObject.customerMap = true; } else { userObject.customerMap = false; }
            if (customerMapWeb.Checked) { userObject.customerMapWeb = true; } else { userObject.customerMapWeb = false; }
            if (salesByCategoryMap.Checked) { userObject.salesByCategoryMap = true; } else { userObject.salesByCategoryMap = false; }
            if (userMaintenance.Checked) { userObject.userMaintenance = true; } else { userObject.userMaintenance = false; }
            

            if (txt_userid.Enabled == true) // add a new user
            {
                if(userObject.Password == userObject.ConfirmPassword)
                {
                    //insert into pass a new user
                    String Result = connSalesOrder.sp_INSERT_NewUser(userObject);
                    if(Result != "OK")
                    {
                        MessageBox.Show(Result);
                        return;
                    }
                    else if(Result == "OK")
                    {
                        if (cbx_inactive.Checked)
                        {
                            conn.User(grid_user);
                        }
                        else
                        {
                            conn.User_Active(grid_user);
                        }
                        Color_SetUp();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Not matching password and confirm password.");
                    return;
                }
            }
            else
            {
                connSalesOrder.sp_UPDATE_UserInfo(userObject);

                //grid update
                for (int i = 0; i < grid_user.RowCount; i++)
                {
                    if (grid_user.Rows[i].Cells["User ID"].Value.Equals(UserID))
                    {
                        grid_user.Rows[i].Cells["Name"].Value = FullName;
                        grid_user.Rows[i].Cells["Department"].Value = Department;
                        grid_user.Rows[i].Cells["Phone Number"].Value = PhoneNumber;

                        grid_user.Rows[i].Cells["Start Date"].Value = StartDate.ToShortDateString();
                        grid_user.Rows[i].Cells["End Date"].Value = EndDate.ToShortDateString();
                        //MessageBox.Show(Convert.ToDateTime(grid_user.Rows[i].Cells["Start Date"].Value).ToShortDateString());
                        //MessageBox.Show(Convert.ToDateTime("1/1/1900").ToShortDateString());

                        if (Convert.ToDateTime(grid_user.Rows[i].Cells["Start Date"].Value).ToShortDateString() == Convert.ToDateTime("1/1/1900").ToShortDateString())
                        {
                            grid_user.Rows[i].Cells["Start Date"].Value = "";
                        }
                        if (Convert.ToDateTime(grid_user.Rows[i].Cells["End Date"].Value).ToShortDateString() == Convert.ToDateTime("1/1/1900").ToShortDateString())
                        {
                            grid_user.Rows[i].Cells["End Date"].Value = "";
                        }

                        grid_user.Rows[i].Cells["Status"].Value = UserStatus;
                    }
                }
            }

            //try
            //{
            //    foreach (DataGridViewRow row in this.grid_user.Rows)
            //    {
            //        if (row.Cells["User ID"].Value.Equals(UserID))
            //        {
            //            row.Cells["Name"].Value = FullName;
            //            row.Cells["Deparment"].Value = Department;
            //            row.Cells["Phone Number"].Value = PhoneNumber;
            //            row.Cells["Status"].Value = UserStatus;
            //        }
            //    }
            //}
            //catch {
            //    MessageBox.Show("catch");
            //}
            Color_SetUp();

            
            

        }

        public string MD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("X2"));
            }
            return str.ToString();
        }
        
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);

            if (e.Node.Checked)
            {
                CheckedNodes.Add(e.Node.Name.ToString());
            }
            else
            {
                CheckedNodes.Remove(e.Node.Name.ToString());
            }

            // Determine by checking the Text property.  
            //MessageBox.Show(e.Node.Name);

        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            //panel1 original location: 3, 101
            //panel moving
            //if (panel_pw.Visible == false)
            //{
            //    panel_pw.Visible = true;
            //    btn_changePassword.Text = "Cancel";
            //    panel_info.Location = new Point(3, 187);
            //}
            //else if (panel_pw.Visible == true)
            //{
            //    panel_pw.Visible = false;
            //    btn_changePassword.Text = "Change Password";
            //    txt_password.Text = "";
            //    txt_comfirmPassword.Text = "";
            //    panel_info.Location = new Point(3, 101);
            //}

            String UserID = txt_userid.Text;
            ChangePassword changePassword = new ChangePassword(UserID);
            changePassword.ShowDialog();


        }

        private void grid_user_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            panel_pw.Visible = false;
            txt_password.Text = "";
            txt_comfirmPassword.Text = "";
            panel_info.Location = new Point(3, 101);

            String UserID = grid_user.Rows[e.RowIndex].Cells["User ID"].Value.ToString().Trim();
            UserObject userObject = new UserObject();
            userObject = connSalesOrder.sp_GET_UserObject(UserID);

            cbo_userStatus.Text = userObject.UserStatus;
            txt_userid.Text = userObject.UserID;
            //txt_password.Text = userObject.
            //txt_comfirmPassword.Text = userObject
            txt_name.Text = userObject.FullName;
            txt_email.Text = userObject.Email;
            txt_department.Text = userObject.Department;
            txt_phoneNumber.Text = userObject.PhoneNumber;
            dateTimePickerStartDate.Value = Convert.ToDateTime(userObject.StartDate);
            dateTimePickerEndDate.Value = Convert.ToDateTime(userObject.EndDate);
            txt_emergencyContactName.Text = userObject.EmergencyContactName;
            txt_emergencyContactNumber.Text = userObject.EmergencyContactNumber;

            btn_add.Enabled = true;
            txt_userid.Enabled = false;
            btn_changePassword.Visible = true;


            if (userObject.accounting) { accounting.Checked = true; } else { accounting.Checked = false; }
            if (userObject.sales) { sales.Checked = true; } else { sales.Checked = false; }
            if (userObject.accountsReceivable) { accountsReceivable.Checked = true; } else { accountsReceivable.Checked = false; }
            if (userObject.purchaseOrder) { purchaseOrder.Checked = true; } else { purchaseOrder.Checked = false; }
            if (userObject.accountsPayable) { accountsPayable.Checked = true; } else { accountsPayable.Checked = false; }
            if (userObject.stock) { stock.Checked = true; } else { stock.Checked = false; }
            if (userObject.mWMS) { mWMS.Checked = true; } else { mWMS.Checked = false; }
            if (userObject.lists) { lists.Checked = true; } else { lists.Checked = false; }
            if (userObject.map) { map.Checked = true; } else { map.Checked = false; }
            if (userObject.systemMenu) { systemMenu.Checked = true; } else { systemMenu.Checked = false; }
            if (userObject.generalJournalEntries) { generalJournalEntries.Checked = true; } else { generalJournalEntries.Checked = false; }
            if (userObject.profitAndLossReport) { profitAndLossReport.Checked = true; } else { profitAndLossReport.Checked = false; }
            if (userObject.salesOrder) { salesOrder.Checked = true; } else { salesOrder.Checked = false; }
            if (userObject.auditSalesOrder) { auditSalesOrder.Checked = true; } else { auditSalesOrder.Checked = false; }
            if (userObject.confirmedSalesOrder) { confirmedSalesOrder.Checked = true; } else { confirmedSalesOrder.Checked = false; }
            if (userObject.preparationPlan) { preparationPlan.Checked = true; } else { preparationPlan.Checked = false; }
            if (userObject.pickingTicket) { pickingTicket.Checked = true; } else { pickingTicket.Checked = false; }
            if (userObject.deliveryNote) { deliveryNote.Checked = true; } else { deliveryNote.Checked = false; }
            if (userObject.duplicateSalesOrder) { duplicateSalesOrder.Checked = true; } else { duplicateSalesOrder.Checked = false; }
            if (userObject.deallocation) { deallocation.Checked = true; } else { deallocation.Checked = false; }
            if (userObject.packageNutLabel) { packageNutLabel.Checked = true; } else { packageNutLabel.Checked = false; }
            if (userObject.salesReport) { salesReport.Checked = true; } else { salesReport.Checked = false; }
            if (userObject.packageNutLabelPrint) { packageNutLabelPrint.Checked = true; } else { packageNutLabelPrint.Checked = false; }
            if (userObject.packageNutCustomerOption) { packageNutCustomerOption.Checked = true; } else { packageNutCustomerOption.Checked = false; }
            if (userObject.packageNutCustomPrice) { packageNutCustomPrice.Checked = true; } else { packageNutCustomPrice.Checked = false; }
            if (userObject.salesOrderExceptionReport) { salesOrderExceptionReport.Checked = true; } else { salesOrderExceptionReport.Checked = false; }
            if (userObject.salesbyRepReport) { salesbyRepReport.Checked = true; } else { salesbyRepReport.Checked = false; }
            if (userObject.salesbyCustomerReport) { salesbyCustomerReport.Checked = true; } else { salesbyCustomerReport.Checked = false; }
            if (userObject.salesbyProductReport) { salesbyProductReport.Checked = true; } else { salesbyProductReport.Checked = false; }
            if (userObject.salesPerformanceReport) { salesPerformanceReport.Checked = true; } else { salesPerformanceReport.Checked = false; }
            if (userObject.nutCategorySalesReport) { nutCategorySalesReport.Checked = true; } else { nutCategorySalesReport.Checked = false; }
            if (userObject.commissionReport) { commissionReport.Checked = true; } else { commissionReport.Checked = false; }
            if (userObject.collectionfromDelivery) { collectionfromDelivery.Checked = true; } else { collectionfromDelivery.Checked = false; }
            if (userObject.collectionfromSales) { collectionfromSales.Checked = true; } else { collectionfromSales.Checked = false; }
            if (userObject.validation) { validation.Checked = true; } else { validation.Checked = false; }
            if (userObject.invoice) { invoice.Checked = true; } else { invoice.Checked = false; }
            if (userObject.creditMemoRequest) { creditMemoRequest.Checked = true; } else { creditMemoRequest.Checked = false; }
            if (userObject.netSettlement) { netSettlement.Checked = true; } else { netSettlement.Checked = false; }
            if (userObject.arPayment) { arPayment.Checked = true; } else { arPayment.Checked = false; }
            if (userObject.entryBatch) { entryBatch.Checked = true; } else { entryBatch.Checked = false; }
            if (userObject.deposit) { deposit.Checked = true; } else { deposit.Checked = false; }
            if (userObject.writeoff) { writeoff.Checked = true; } else { writeoff.Checked = false; }
            if (userObject.arReports) { arReports.Checked = true; } else { arReports.Checked = false; }
            if (userObject.arAging) { arAging.Checked = true; } else { arAging.Checked = false; }
            if (userObject.arbyCustomerReport) { arbyCustomerReport.Checked = true; } else { arbyCustomerReport.Checked = false; }
            if (userObject.arbySalespersonReport) { arbySalespersonReport.Checked = true; } else { arbySalespersonReport.Checked = false; }
            if (userObject.arCollectionsSummary) { arCollectionsSummary.Checked = true; } else { arCollectionsSummary.Checked = false; }
            if (userObject.arSalesDebitMemoSummary) { arSalesDebitMemoSummary.Checked = true; } else { arSalesDebitMemoSummary.Checked = false; }
            if (userObject.arOverpayment) { arOverpayment.Checked = true; } else { arOverpayment.Checked = false; }
            if (userObject.nonSufficientFundsReport) { nonSufficientFundsReport.Checked = true; } else { nonSufficientFundsReport.Checked = false; }
            if (userObject.promotionSchedule) { promotionSchedule.Checked = true; } else { promotionSchedule.Checked = false; }
            if (userObject.poPrepare) { poPrepare.Checked = true; } else { poPrepare.Checked = false; }
            if (userObject.po) { po.Checked = true; } else { po.Checked = false; }
            if (userObject.goodsReceipt) { goodsReceipt.Checked = true; } else { goodsReceipt.Checked = false; }
            if (userObject.poReports) { poReports.Checked = true; } else { poReports.Checked = false; }
            if (userObject.poExceptionReport) { poExceptionReport.Checked = true; } else { poExceptionReport.Checked = false; }
            if (userObject.subcontractOrderExceptionReport) { subcontractOrderExceptionReport.Checked = true; } else { subcontractOrderExceptionReport.Checked = false; }
            if (userObject.poManagementReport) { poManagementReport.Checked = true; } else { poManagementReport.Checked = false; }
            if (userObject.poManagementDetailReport) { poManagementDetailReport.Checked = true; } else { poManagementDetailReport.Checked = false; }
            if (userObject.poForecastReport) { poForecastReport.Checked = true; } else { poForecastReport.Checked = false; }
            if (userObject.poDepartmentSalesReport) { poDepartmentSalesReport.Checked = true; } else { poDepartmentSalesReport.Checked = false; }
            if (userObject.apValidation) { apValidation.Checked = true; } else { apValidation.Checked = false; }
            if (userObject.apDebitNote) { apDebitNote.Checked = true; } else { apDebitNote.Checked = false; }
            if (userObject.apCreditMemoRequest) { apCreditMemoRequest.Checked = true; } else { apCreditMemoRequest.Checked = false; }
            if (userObject.apDebitMemoRequest) { apDebitMemoRequest.Checked = true; } else { apDebitMemoRequest.Checked = false; }
            if (userObject.apNetSettlement) { apNetSettlement.Checked = true; } else { apNetSettlement.Checked = false; }
            if (userObject.paymentResolution) { paymentResolution.Checked = true; } else { paymentResolution.Checked = false; }
            if (userObject.apPayment) { apPayment.Checked = true; } else { apPayment.Checked = false; }
            if (userObject.apReports) { apReports.Checked = true; } else { apReports.Checked = false; }
            if (userObject.apAging) { apAging.Checked = true; } else { apAging.Checked = false; }
            if (userObject.assembly) { assembly.Checked = true; } else { assembly.Checked = false; }
            if (userObject.assemblyRecipt) { assemblyRecipt.Checked = true; } else { assemblyRecipt.Checked = false; }
            if (userObject.disassembly) { disassembly.Checked = true; } else { disassembly.Checked = false; }
            if (userObject.disassemblyReceipt) { disassemblyReceipt.Checked = true; } else { disassemblyReceipt.Checked = false; }
            if (userObject.manufacturing) { manufacturing.Checked = true; } else { manufacturing.Checked = false; }
            if (userObject.manufacturingReceipt) { manufacturingReceipt.Checked = true; } else { manufacturingReceipt.Checked = false; }
            if (userObject.miscellaneousIssue) { miscellaneousIssue.Checked = true; } else { miscellaneousIssue.Checked = false; }
            if (userObject.miscellaneousReceipt) { miscellaneousReceipt.Checked = true; } else { miscellaneousReceipt.Checked = false; }
            if (userObject.subcontractOrder) { subcontractOrder.Checked = true; } else { subcontractOrder.Checked = false; }
            if (userObject.subcontractReceipt) { subcontractReceipt.Checked = true; } else { subcontractReceipt.Checked = false; }
            if (userObject.intersiteTransfer) { intersiteTransfer.Checked = true; } else { intersiteTransfer.Checked = false; }
            if (userObject.receiptReturn) { receiptReturn.Checked = true; } else { receiptReturn.Checked = false; }
            if (userObject.shipmentReturn) { shipmentReturn.Checked = true; } else { shipmentReturn.Checked = false; }
            if (userObject.stockChange) { stockChange.Checked = true; } else { stockChange.Checked = false; }
            if (userObject.stockReports) { stockReports.Checked = true; } else { stockReports.Checked = false; }
            if (userObject.ipadShortageReport) { ipadShortageReport.Checked = true; } else { ipadShortageReport.Checked = false; }
            if (userObject.globalShortageReport) { globalShortageReport.Checked = true; } else { globalShortageReport.Checked = false; }
            if (userObject.detailedShortageReport) { detailedShortageReport.Checked = true; } else { detailedShortageReport.Checked = false; }
            if (userObject.inventoryManagement) { inventoryManagement.Checked = true; } else { inventoryManagement.Checked = false; }
            if (userObject.miscellaneousTransactionReport) { miscellaneousTransactionReport.Checked = true; } else { miscellaneousTransactionReport.Checked = false; }
            if (userObject.stockTransactionReport) { stockTransactionReport.Checked = true; } else { stockTransactionReport.Checked = false; }
            if (userObject.stockMovementReport) { stockMovementReport.Checked = true; } else { stockMovementReport.Checked = false; }
            if (userObject.stockValuationReport) { stockValuationReport.Checked = true; } else { stockValuationReport.Checked = false; }
            if (userObject.wmsGoodsReceipt) { wmsGoodsReceipt.Checked = true; } else { wmsGoodsReceipt.Checked = false; }
            if (userObject.wmsStockStatusChange) { wmsStockStatusChange.Checked = true; } else { wmsStockStatusChange.Checked = false; }
            if (userObject.wmsShipmentReturn) { wmsShipmentReturn.Checked = true; } else { wmsShipmentReturn.Checked = false; }
            if (userObject.IntersiteTransferOrder) { IntersiteTransferOrder.Checked = true; } else { IntersiteTransferOrder.Checked = false; }
            if (userObject.IntersiteTransferReceipt) { IntersiteTransferReceipt.Checked = true; } else { IntersiteTransferReceipt.Checked = false; }
            if (userObject.wmsCustomerDelivery) { wmsCustomerDelivery.Checked = true; } else { wmsCustomerDelivery.Checked = false; }
            if (userObject.wmsReceiptReturn) { wmsReceiptReturn.Checked = true; } else { wmsReceiptReturn.Checked = false; }
            if (userObject.brandList) { brandList.Checked = true; } else { brandList.Checked = false; }
            if (userObject.chartOfAccount) { chartOfAccount.Checked = true; } else { chartOfAccount.Checked = false; }
            if (userObject.companyList) { companyList.Checked = true; } else { companyList.Checked = false; }
            if (userObject.customerList) { customerList.Checked = true; } else { customerList.Checked = false; }
            if (userObject.customerPriceEntry) { customerPriceEntry.Checked = true; } else { customerPriceEntry.Checked = false; }
            if (userObject.deliveryRoutePlanList) { deliveryRoutePlanList.Checked = true; } else { deliveryRoutePlanList.Checked = false; }
            if (userObject.driverList) { driverList.Checked = true; } else { driverList.Checked = false; }
            if (userObject.paymentTermList) { paymentTermList.Checked = true; } else { paymentTermList.Checked = false; }
            if (userObject.productList) { productList.Checked = true; } else { productList.Checked = false; }
            if (userObject.promotionScheduleTypeList) { promotionScheduleTypeList.Checked = true; } else { promotionScheduleTypeList.Checked = false; }
            if (userObject.salesPersonList) { salesPersonList.Checked = true; } else { salesPersonList.Checked = false; }
            if (userObject.supplierList) { supplierList.Checked = true; } else { supplierList.Checked = false; }
            if (userObject.customerMap) { customerMap.Checked = true; } else { customerMap.Checked = false; }
            if (userObject.customerMapWeb) { customerMapWeb.Checked = true; } else { customerMapWeb.Checked = false; }
            if (userObject.salesByCategoryMap) { salesByCategoryMap.Checked = true; } else { salesByCategoryMap.Checked = false; }
            if (userObject.userMaintenance) { userMaintenance.Checked = true; } else { userMaintenance.Checked = false; }



        }

        private void cbx_inactive_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_inactive.Checked)
            {
                conn.User(grid_user);
            }
            else
            {
                conn.User_Active(grid_user);
            }
            Color_SetUp();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            //MenuObject menuObject = new MenuObject();
            //menuObject.menu = "testMenu";
            //menuObject.active = true;

            //MenuObject[] menuArray = new MenuObject[112];
            //menuArray[0] = menuObject;
            //MessageBox.Show(menuArray[0].ToString());

            //MenuObject[] marray = new MenuObject[]
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //    marray[0] = menuObject.menu
            //    }
            //};


            //string[,] array = new string[,]
            //{
            //    {"accounting", "1"}, {"generalJournalEntries", "1" }, {"profitAndLoss", "1"}
            //};

            // 답변 부탁드리겠습니다. 
            //MessageBox.Show(array.Length.ToString());
            //MessageBox.Show(array.Depth.Tostring());
            /*
            MessageBox.Show(array[0, 0]); //accounting 
            MessageBox.Show(array[0, 1]); //1
            MessageBox.Show(array[1, 0]); //generalJournalEntries
            MessageBox.Show(array[1, 1]); //1
            MessageBox.Show(array[2, 0]); //profitAndLoss
            MessageBox.Show(array[2, 1]); //1
            */
            // MessageBox.Show(array[3, 0]); //? arrange error

            TreeNodeCollection nodes = treeView1.Nodes;
            foreach (TreeNode node in nodes)
            {
                PrintRecursive(node);
            }

        }

        private void PrintRecursive(TreeNode treeNode)
        {

            // Print the node.
            //System.Diagnostics.Debug.WriteLine(treeNode.Text);
            //checking all menu name Array 
            //List<String> menu = new List<String>()



            //for(int i = 0; i < 113; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        arr1[i,j] = { }

            //        { 1, 1}, { 2,1}, { 3,0}
            //    }
            //}

            //if (treeNode.Name == "salesOrder")
            //{
            //    treeNode.Checked = true;
            //}

            //if (treeNode.Name == "salesReport")
            //{
            //    treeNode.Checked = true;
            //}

            //if (treeNode.Name == "salesbyRepReport")
            //{
            //    treeNode.Checked = false;
            //}

            ////MessageBox.Show(treeNode.Name);
            //// Print each node recursively.  
            ///
            string[,] array = new string[,]
            {
                {"accounting", "1"}, {"generalJournalEntries", "0" }, {"profitAndLoss", "0"}
            };

            for (int i = 0; i < 3; i++)
            {
                //MessageBox.Show(array[i, 0]);

                if (treeNode.Name == array[i, 0])
                {
                    treeNode.Checked = true;

                    //if (array[i, 1] == "1")
                    //    treeNode.Checked = true;
                    //else
                    //    treeNode.Checked = false;
                }
            }

            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(tn);
            }
        }

        private void btn_selectAll_Click(object sender, EventArgs e)
        {
            accounting.Checked = true;
            sales.Checked = true;
            accountsReceivable.Checked = true;
            purchaseOrder.Checked = true;
            accountsPayable.Checked = true;
            stock.Checked = true;
            mWMS.Checked = true;
            lists.Checked = true;
            map.Checked = true;
            systemMenu.Checked = true;
            generalJournalEntries.Checked = true;
            profitAndLossReport.Checked = true;
            salesOrder.Checked = true;
            auditSalesOrder.Checked = true;
            confirmedSalesOrder.Checked = true;
            preparationPlan.Checked = true;
            pickingTicket.Checked = true;
            deliveryNote.Checked = true;
            duplicateSalesOrder.Checked = true;
            deallocation.Checked = true;
            packageNutLabel.Checked = true;
            salesReport.Checked = true;
            packageNutLabelPrint.Checked = true;
            packageNutCustomerOption.Checked = true;
            packageNutCustomPrice.Checked = true;
            salesOrderExceptionReport.Checked = true;
            salesbyRepReport.Checked = true;
            salesbyCustomerReport.Checked = true;
            salesbyProductReport.Checked = true;
            salesPerformanceReport.Checked = true;
            nutCategorySalesReport.Checked = true;
            commissionReport.Checked = true;
            collectionfromDelivery.Checked = true;
            collectionfromSales.Checked = true;
            validation.Checked = true;
            invoice.Checked = true;
            creditMemoRequest.Checked = true;
            netSettlement.Checked = true;
            arPayment.Checked = true;
            entryBatch.Checked = true;
            deposit.Checked = true;
            writeoff.Checked = true;
            arReports.Checked = true;
            arAging.Checked = true;
            arbyCustomerReport.Checked = true;
            arbySalespersonReport.Checked = true;
            arCollectionsSummary.Checked = true;
            arSalesDebitMemoSummary.Checked = true;
            arOverpayment.Checked = true;
            nonSufficientFundsReport.Checked = true;
            promotionSchedule.Checked = true;
            poPrepare.Checked = true;
            po.Checked = true;
            goodsReceipt.Checked = true;
            poReports.Checked = true;
            poExceptionReport.Checked = true;
            subcontractOrderExceptionReport.Checked = true;
            poManagementReport.Checked = true;
            poManagementDetailReport.Checked = true;
            poForecastReport.Checked = true;
            poDepartmentSalesReport.Checked = true;
            apValidation.Checked = true;
            apDebitNote.Checked = true;
            apCreditMemoRequest.Checked = true;
            apDebitMemoRequest.Checked = true;
            apNetSettlement.Checked = true;
            paymentResolution.Checked = true;
            apPayment.Checked = true;
            apReports.Checked = true;
            apAging.Checked = true;
            assembly.Checked = true;
            assemblyRecipt.Checked = true;
            disassembly.Checked = true;
            disassemblyReceipt.Checked = true;
            manufacturing.Checked = true;
            manufacturingReceipt.Checked = true;
            miscellaneousIssue.Checked = true;
            miscellaneousReceipt.Checked = true;
            subcontractOrder.Checked = true;
            subcontractReceipt.Checked = true;
            intersiteTransfer.Checked = true;
            receiptReturn.Checked = true;
            shipmentReturn.Checked = true;
            stockChange.Checked = true;
            stockReports.Checked = true;
            ipadShortageReport.Checked = true;
            globalShortageReport.Checked = true;
            detailedShortageReport.Checked = true;
            inventoryManagement.Checked = true;
            miscellaneousTransactionReport.Checked = true;
            stockTransactionReport.Checked = true;
            stockMovementReport.Checked = true;
            stockValuationReport.Checked = true;
            wmsGoodsReceipt.Checked = true;
            wmsStockStatusChange.Checked = true;
            wmsShipmentReturn.Checked = true;
            IntersiteTransferOrder.Checked = true;
            IntersiteTransferReceipt.Checked = true;
            wmsCustomerDelivery.Checked = true;
            wmsReceiptReturn.Checked = true;
            brandList.Checked = true;
            chartOfAccount.Checked = true;
            companyList.Checked = true;
            customerList.Checked = true;
            customerPriceEntry.Checked = true;
            deliveryRoutePlanList.Checked = true;
            driverList.Checked = true;
            productList.Checked = true;
            promotionScheduleTypeList.Checked = true;
            salesPersonList.Checked = true;
            supplierList.Checked = true;
            customerMap.Checked = true;
            customerMapWeb.Checked = true;
            salesByCategoryMap.Checked = true;
            userMaintenance.Checked = true;

        }

    }
}
