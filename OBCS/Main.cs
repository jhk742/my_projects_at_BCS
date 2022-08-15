using OBCS.Lists;
using OBCS.Purchase;
using OBCS.Sales;
using OBCS.Stock;
using OBCS.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Extensions.Winforms;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using OBCS.Entities;

namespace OBCS
{
    public partial class Main : CustomForm
    {
        //private static System.Timers.Timer AutoCloseTimer = new System.Timers.Timer();
        //private static System.Timers.Timer AutoClosingTimer = new System.Timers.Timer();



        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //private static extern IntPtr CreateRoundRectRgn(int nLeftRect,
        //  int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    //customMenuButton1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, customMenuButton1.Width, customMenuButton1.Height, 15, 15));
        //    //lblCAM.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, lblCAM.Width, lblCAM.Height, 15, 15));
        //    //lblPOWER.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, lblPOWER.Width, lblPOWER.Height, 15, 15));
        //}


        public Main()
        {
            InitializeComponent();

            IsMdiContainer = true;
            menu.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
            //Find the MdiClient and hold it by a variable
            client = Controls.OfType<MdiClient>().First();
            //This will check whenever client gets focused and there aren't any
            //child forms opened, Send the client to back so that the other controls can be shown back.
            client.GotFocus += (s, e) => {
                if (!MdiChildren.Any(x => x.Visible)) client.SendToBack();
            };
            //salesTabPB.Image = Properties.Resources.SalesTitle

            //this.SetStyle(ControlStyles.DoubleBuffer, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //this.SetStyle(ControlStyles.UserPaint, true);

            //typeof(Panel).InvokeMember("DoubleBuffered",
            //BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            //null, salesTabPB, new object[] { true });

            //typeof(Panel).InvokeMember("DoubleBuffered",
            //BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            //null, label1, new object[] { true });

            //typeof(Panel).InvokeMember("DoubleBuffered",
            //BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            //null, pictureBox18, new object[] { true });

            //typeof(Panel).InvokeMember("DoubleBuffered",
            //BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            //null, label11, new object[] { true });
        }
        


        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
        //        return cp;
        //    }
        //}

        private void AutoCloseTimerEvent(object sender, EventArgs e)
        {
            /*
            AutoCloseTimer.Stop();
            
            AutoClosingTimer.Stop();
            AutoClosingTimer.Elapsed += new ElapsedEventHandler(AutoClosingTimerEvent);
            AutoClosingTimer.Interval = 3000;
            AutoClosingTimer.Enabled = true;
            */

            /*
            AutoCloseTimer.Stop();

            CustomMessageBox customMessageBox = new CustomMessageBox();
            customMessageBox.ShowDialog();
            
            AutoCloseTimer.Start();
            AutoCloseTimer.Elapsed += new ElapsedEventHandler(AutoCloseTimerEvent);
            AutoCloseTimer.Interval = 5000;
            AutoCloseTimer.Enabled = true;
            */
            
            /*
            DialogResult dialogResult = MessageBox.Show("Are you still using the program?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                AutoCloseTimer.Stop();
                //AutoCloseTimer.Elapsed += new ElapsedEventHandler(AutoCloseTimerEvent);
                AutoCloseTimer.Start();
                AutoCloseTimer.Interval = 5000;
                AutoCloseTimer.Enabled = true;

                AutoClosingTimer.Stop();
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
            */
            
        }

        private void AutoClosingTimerEvent(object sender, EventArgs e)
        {Application.Exit();}

        public MdiClient client;

        public class MyColorTable : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
                }
            }

            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
                }
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                {
                    return Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
                }
            }

            public override Color MenuItemSelected //선택
            {
                get
                {
                    return Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(29))))); 
                }
            }

            public override Color MenuStripGradientBegin
            {
                get
                {
                    return Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
                }
            }

            public override Color MenuStripGradientEnd
            {
                get
                {
                    return Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
                }
            }

            public override Color MenuItemSelectedGradientBegin //선택
            {
                get
                {
                    return Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(29)))));
                }
            }

            public override Color MenuItemSelectedGradientEnd //선택
            {
                get
                {
                    return Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(29)))));
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
                }
            }
        }

        private void ShowForm(Form childForm)
        {
            client.BringToFront();//This will make your child form shown on top.
            childForm.Show();
        }
        private void DisableTabControl(TabPage page, bool result) {
            Control.ControlCollection ctls = page.Controls;
            foreach (Control ctl in ctls) {
                ctl.Enabled = result;
            }
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;

            //GATE gate = new GATE { MdiParent = this };
            //gate.StartPosition = FormStartPosition.Manual;
            //gate.Location = new Point(this.ClientSize.Width / 2 - gate.Width / 2, this.ClientSize.Height / 2 - gate.Height / 2);
            //ShowForm(gate);

            System.Extensions.Winforms.GATE gate = new System.Extensions.Winforms.GATE();
            //gate.MdiParent = this;
            gate.StartPosition = FormStartPosition.Manual;
            gate.Location = new Point(this.ClientSize.Width / 2 - gate.Width / 2, this.ClientSize.Height / 2 - gate.Height / 2);
            gate.ShowDialog();

            //customMenuButton1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, customMenuButton1.Width, customMenuButton1.Height, 5, 5));

            //if success login
            menu.Visible = true;
            WorkFlowTabs.Location = new Point(-30, 27);
            WorkFlowTabs.Size = new Size(1250, 661);
            panel1.Visible = true;
            //tabControl1.Visible = true;
            GATE.userID = gate.userID;

            UserObject userObject = new UserObject();
            userObject = connSalesOrder.sp_GET_UserObject(GATE.userID);

            if (userObject.salesOrder) { btn_salesOrder.Enabled = true; } else { btn_salesOrder.Enabled = false; }
            if (userObject.auditSalesOrder) { btn_auditSalesOrder.Enabled = true; } else { btn_auditSalesOrder.Enabled = false; }
            if (userObject.confirmedSalesOrder) { btn_confirmedSalesOrder.Enabled = true; } else { btn_confirmedSalesOrder.Enabled = false; }
            if (userObject.preparationPlan) { btn_preparationPlan.Enabled = true; } else { btn_preparationPlan.Enabled = false; }
            if (userObject.pickingTicket) { btn_pickingTicket.Enabled = true; } else { btn_pickingTicket.Enabled = false; }
            if (userObject.deliveryNote) { btn_deliveryNote.Enabled = true; } else { btn_deliveryNote.Enabled = false; }
            if (userObject.salesOrderExceptionReport) { btn_salesOrderExceptionReport.Enabled = true; } else { btn_salesOrderExceptionReport.Enabled = false; }
            if (userObject.salesbyRepReport) { btn_salesbyRepReport.Enabled = true; } else { btn_salesbyRepReport.Enabled = false; }
            if (userObject.salesbyCustomerReport) { btn_salesbyCustomerReport.Enabled = true; } else { btn_salesbyCustomerReport.Enabled = false; }
            if (userObject.salesbyProductReport) { btn_salesbyProductReport.Enabled = true; } else { btn_salesbyProductReport.Enabled = false; }
            if (userObject.salesPerformanceReport) { btn_salesPerformanceReport.Enabled = true; } else { btn_salesPerformanceReport.Enabled = false; }
            if (userObject.nutCategorySalesReport) { btn_nutCategorySalesReport.Enabled = true; } else { btn_nutCategorySalesReport.Enabled = false; }
            if (userObject.commissionReport) { btn_commissionReport.Enabled = true; } else { btn_commissionReport.Enabled = false; }
            if (userObject.validation) { btn_validation.Enabled = true; } else { btn_validation.Enabled = false; }
            if (userObject.invoice) { btn_invoice.Enabled = true; } else { btn_invoice.Enabled = false; }
            if (userObject.creditMemoRequest) { btn_creditMemoRequest.Enabled = true; } else { btn_creditMemoRequest.Enabled = false; }
            if (userObject.netSettlement) { btn_netSettlement.Enabled = true; } else { btn_netSettlement.Enabled = false; }
            if (userObject.arPayment) { btn_arPayment.Enabled = true; } else { btn_arPayment.Enabled = false; }
            if (userObject.deposit) { btn_deposit.Enabled = true; } else { btn_deposit.Enabled = false; }
            if (userObject.arAging) { btn_arAging.Enabled = true; } else { btn_arAging.Enabled = false; }
            if (userObject.arbyCustomerReport) { btn_arbyCustomerReport.Enabled = true; } else { btn_arbyCustomerReport.Enabled = false; }
            if (userObject.arbySalespersonReport) { btn_arbySalespersonReport.Enabled = true; } else { btn_arbySalespersonReport.Enabled = false; }
            if (userObject.arCollectionsSummary) { btn_arCollectionsSummary.Enabled = true; } else { btn_arCollectionsSummary.Enabled = false; }
            if (userObject.arSalesDebitMemoSummary) { btn_arSalesDebitMemoSummary.Enabled = true; } else { btn_arSalesDebitMemoSummary.Enabled = false; }
            if (userObject.arOverpayment) { btn_arOverpayment.Enabled = true; } else { btn_arOverpayment.Enabled = false; }
            if (userObject.nonSufficientFundsReport) { btn_nonSufficientFundsReport.Enabled = true; } else { btn_nonSufficientFundsReport.Enabled = false; }
            if (userObject.promotionSchedule) { btn_promotionSchedule.Enabled = true; } else { btn_promotionSchedule.Enabled = false; }
            if (userObject.poPrepare) { btn_poPrepare.Enabled = true; } else { btn_poPrepare.Enabled = false; }
            if (userObject.po) { btn_po.Enabled = true; } else { btn_po.Enabled = false; }
            if (userObject.goodsReceipt) { btn_goodsReceipt.Enabled = true; lbl_goodsReceipt.Enabled = true; } else { btn_goodsReceipt.Enabled = false; lbl_goodsReceipt.Enabled = false; }
            if (userObject.poExceptionReport) { btn_poExceptionReport.Enabled = true; } else { btn_poExceptionReport.Enabled = false; }
            if (userObject.subcontractOrderExceptionReport) { btn_subcontractOrderExceptionReport.Enabled = true; } else { btn_subcontractOrderExceptionReport.Enabled = false; }
            if (userObject.poManagementReport) { btn_poManagementReport.Enabled = true; } else { btn_poManagementReport.Enabled = false; }
            if (userObject.poManagementDetailReport) { btn_poManagementDetailReport.Enabled = true; } else { btn_poManagementDetailReport.Enabled = false; }
            if (userObject.poForecastReport) { btn_poForecastReport.Enabled = true; } else { btn_poForecastReport.Enabled = false; }
            if (userObject.poDepartmentSalesReport) { btn_poDepartmentSalesReport.Enabled = true; } else { btn_poDepartmentSalesReport.Enabled = false; }
            if (userObject.apValidation) { btn_apValidation.Enabled = true; } else { btn_apValidation.Enabled = false; }
            if (userObject.apDebitNote) { btn_apDebitNote.Enabled = true; } else { btn_apDebitNote.Enabled = false; }
            if (userObject.apCreditMemoRequest) { btn_apCreditMemoRequest.Enabled = true; } else { btn_apCreditMemoRequest.Enabled = false; }
            if (userObject.apDebitMemoRequest) { btn_apDebitMemoRequest.Enabled = true; } else { btn_apDebitMemoRequest.Enabled = false; }
            if (userObject.apNetSettlement) { btn_apNetSettlement.Enabled = true; } else { btn_apNetSettlement.Enabled = false; }
            if (userObject.paymentResolution) { btn_paymentResolution.Enabled = true; } else { btn_paymentResolution.Enabled = false; }
            if (userObject.apPayment) { btn_apPayment.Enabled = true; } else { btn_apPayment.Enabled = false; }
            if (userObject.apAging) { btn_apAging.Enabled = true; } else { btn_apAging.Enabled = false; }
            if (userObject.assembly) { btn_assembly.Enabled = true; } else { btn_assembly.Enabled = false; }
            if (userObject.assemblyRecipt) { btn_assemblyRecipt.Enabled = true; } else { btn_assemblyRecipt.Enabled = false; }
            if (userObject.disassembly) { btn_disassembly.Enabled = true; } else { btn_disassembly.Enabled = false; }
            if (userObject.disassemblyReceipt) { btn_disassemblyReceipt.Enabled = true; } else { btn_disassemblyReceipt.Enabled = false; }
            if (userObject.manufacturing) { btn_manufacturing.Enabled = true; } else { btn_manufacturing.Enabled = false; }
            if (userObject.manufacturingReceipt) { btn_manufacturingReceipt.Enabled = true; } else { btn_manufacturingReceipt.Enabled = false; }
            if (userObject.miscellaneousIssue) { btn_miscellaneousIssue.Enabled = true; } else { btn_miscellaneousIssue.Enabled = false; }
            if (userObject.miscellaneousReceipt) { btn_miscellaneousReceipt.Enabled = true; } else { btn_miscellaneousReceipt.Enabled = false; }
            if (userObject.subcontractOrder) { btn_subcontractOrder.Enabled = true; } else { btn_subcontractOrder.Enabled = false; }
            if (userObject.subcontractReceipt) { btn_subcontractReceipt.Enabled = true; } else { btn_subcontractReceipt.Enabled = false; }
            if (userObject.intersiteTransfer) { btn_intersiteTransfer.Enabled = true; } else { btn_intersiteTransfer.Enabled = false; }
            if (userObject.receiptReturn) { btn_receiptReturn.Enabled = true; } else { btn_receiptReturn.Enabled = false; }
            if (userObject.shipmentReturn) { btn_shipmentReturn.Enabled = true; } else { btn_shipmentReturn.Enabled = false; }
            if (userObject.stockChange) { btn_stockChange.Enabled = true; } else { btn_stockChange.Enabled = false; }
            if (userObject.ipadShortageReport) { btn_ipadShortageReport.Enabled = true; } else { btn_ipadShortageReport.Enabled = false; }
            if (userObject.globalShortageReport) { btn_globalShortageReport.Enabled = true; } else { btn_globalShortageReport.Enabled = false; }
            if (userObject.detailedShortageReport) { btn_detailedShortageReport.Enabled = true; } else { btn_detailedShortageReport.Enabled = false; }
            if (userObject.inventoryManagement) { btn_inventoryManagement.Enabled = true; } else { btn_inventoryManagement.Enabled = false; }
            if (userObject.stockTransactionReport) { btn_stockTransactionReport.Enabled = true; } else { btn_stockTransactionReport.Enabled = false; }
            if (userObject.stockMovementReport) { btn_stockMovementReport.Enabled = true; } else { btn_stockMovementReport.Enabled = false; }
            if (userObject.stockValuationReport) { btn_stockValuationReport.Enabled = true; } else { btn_stockValuationReport.Enabled = false; }
            if (userObject.deliveryNote) { btn_DeliveryNote2.Enabled = true; } else { btn_DeliveryNote2.Enabled = false; }

            if (userObject.accounting) { menu_accounting.Enabled = true; } else { menu_accounting.Enabled = false; }
            if (userObject.sales) { menu_sales.Enabled = true; } else { menu_sales.Enabled = false; DisableTabControl(WorkFlowTabs.TabPages[WorkFlowTabs.SelectedIndex = 1], false); }
            if (userObject.accountsReceivable) { menu_accountsReceivable.Enabled = true; } else { menu_accountsReceivable.Enabled = false; DisableTabControl(WorkFlowTabs.TabPages[WorkFlowTabs.SelectedIndex = 2], false); }
            if (userObject.purchaseOrder) { menu_purchaseOrder.Enabled = true; } else { menu_purchaseOrder.Enabled = false; DisableTabControl(WorkFlowTabs.TabPages[WorkFlowTabs.SelectedIndex = 3], false); }
            if (userObject.accountsPayable) { menu_accountsPayable.Enabled = true; } else { menu_accountsPayable.Enabled = false; DisableTabControl(WorkFlowTabs.TabPages[WorkFlowTabs.SelectedIndex = 4], false); }
            if (userObject.stock) { menu_stock.Enabled = true; } else { menu_stock.Enabled = false; }
            if (userObject.mWMS) { menu_mWMS.Enabled = true; } else { menu_mWMS.Enabled = false; }
            if (userObject.lists) { menu_lists.Enabled = true; } else { menu_lists.Enabled = false; }
            if (userObject.map) { menu_map.Enabled = true; } else { menu_map.Enabled = false; }
            if (userObject.systemMenu) { menu_systemMenu.Enabled = true; } else { menu_systemMenu.Enabled = false; }
            if (userObject.generalJournalEntries) { menu_generalJournalEntries.Enabled = true; } else { menu_generalJournalEntries.Enabled = false; }
            if (userObject.profitAndLossReport) { menu_profitAndLossReport.Enabled = true; } else { menu_profitAndLossReport.Enabled = false; }
            if (userObject.salesOrder) { menu_salesOrder.Enabled = true; } else { menu_salesOrder.Enabled = false; }
            if (userObject.auditSalesOrder) { menu_auditSalesOrder.Enabled = true; } else { menu_auditSalesOrder.Enabled = false; }
            if (userObject.confirmedSalesOrder) { menu_confirmedSalesOrder.Enabled = true; } else { menu_confirmedSalesOrder.Enabled = false; }
            if (userObject.preparationPlan) { menu_preparationPlan.Enabled = true; } else { menu_preparationPlan.Enabled = false; }
            if (userObject.pickingTicket) { menu_pickingTicket.Enabled = true; } else { menu_pickingTicket.Enabled = false; }
            if (userObject.deliveryNote) { menu_deliveryNote.Enabled = true; } else { menu_deliveryNote.Enabled = false; }
            if (userObject.duplicateSalesOrder) { menu_duplicateSalesOrder.Enabled = true; } else { menu_duplicateSalesOrder.Enabled = false; }
            if (userObject.deallocation) { menu_deallocation.Enabled = true; } else { menu_deallocation.Enabled = false; }
            if (userObject.packageNutLabel) { menu_packageNutLabel.Enabled = true; } else { menu_packageNutLabel.Enabled = false; }
            if (userObject.salesReport) { menu_salesReport.Enabled = true; } else { menu_salesReport.Enabled = false; }
            if (userObject.packageNutLabelPrint) { menu_packageNutLabelPrint.Enabled = true; } else { menu_packageNutLabelPrint.Enabled = false; }
            if (userObject.packageNutCustomerOption) { menu_packageNutCustomerOption.Enabled = true; } else { menu_packageNutCustomerOption.Enabled = false; }
            if (userObject.packageNutCustomPrice) { menu_packageNutCustomPrice.Enabled = true; } else { menu_packageNutCustomPrice.Enabled = false; }
            if (userObject.salesOrderExceptionReport) { menu_salesOrderExceptionReport.Enabled = true; } else { menu_salesOrderExceptionReport.Enabled = false; }
            if (userObject.salesbyRepReport) { menu_salesbyRepReport.Enabled = true; } else { menu_salesbyRepReport.Enabled = false; }
            if (userObject.salesbyCustomerReport) { menu_salesbyCustomerReport.Enabled = true; } else { menu_salesbyCustomerReport.Enabled = false; }
            if (userObject.salesbyProductReport) { menu_salesbyProductReport.Enabled = true; } else { menu_salesbyProductReport.Enabled = false; }
            if (userObject.salesPerformanceReport) { menu_salesPerformanceReport.Enabled = true; } else { menu_salesPerformanceReport.Enabled = false; }
            if (userObject.nutCategorySalesReport) { menu_nutCategorySalesReport.Enabled = true; } else { menu_nutCategorySalesReport.Enabled = false; }
            if (userObject.commissionReport) { menu_commissionReport.Enabled = true; } else { menu_commissionReport.Enabled = false; }
            if (userObject.collectionfromDelivery) { menu_collectionfromDelivery.Enabled = true; } else { menu_collectionfromDelivery.Enabled = false; }
            if (userObject.collectionfromSales) { menu_collectionfromSales.Enabled = true; } else { menu_collectionfromSales.Enabled = false; }
            if (userObject.validation) { menu_validation.Enabled = true; } else { menu_validation.Enabled = false; }
            if (userObject.invoice) { menu_invoice.Enabled = true; } else { menu_invoice.Enabled = false; }
            if (userObject.creditMemoRequest) { menu_creditMemoRequest.Enabled = true; } else { menu_creditMemoRequest.Enabled = false; }
            if (userObject.netSettlement) { menu_netSettlement.Enabled = true; } else { menu_netSettlement.Enabled = false; }
            if (userObject.arPayment) { menu_arPayment.Enabled = true; } else { menu_arPayment.Enabled = false; }
            if (userObject.entryBatch) { menu_entryBatch.Enabled = true; } else { menu_entryBatch.Enabled = false; }
            if (userObject.deposit) { menu_deposit.Enabled = true; } else { menu_deposit.Enabled = false; }
            if (userObject.writeoff) { menu_writeoff.Enabled = true; } else { menu_writeoff.Enabled = false; }
            if (userObject.arReports) { menu_arReports.Enabled = true; } else { menu_arReports.Enabled = false; }
            if (userObject.arAging) { menu_arAging.Enabled = true; } else { menu_arAging.Enabled = false; }
            if (userObject.arbyCustomerReport) { menu_arbyCustomerReport.Enabled = true; } else { menu_arbyCustomerReport.Enabled = false; }
            if (userObject.arbySalespersonReport) { menu_arbySalespersonReport.Enabled = true; } else { menu_arbySalespersonReport.Enabled = false; }
            if (userObject.arCollectionsSummary) { menu_arCollectionsSummary.Enabled = true; } else { menu_arCollectionsSummary.Enabled = false; }
            if (userObject.arSalesDebitMemoSummary) { menu_arSalesDebitMemoSummary.Enabled = true; } else { menu_arSalesDebitMemoSummary.Enabled = false; }
            if (userObject.arOverpayment) { menu_arOverpayment.Enabled = true; } else { menu_arOverpayment.Enabled = false; }
            if (userObject.nonSufficientFundsReport) { menu_nonSufficientFundsReport.Enabled = true; } else { menu_nonSufficientFundsReport.Enabled = false; }
            if (userObject.promotionSchedule) { menu_promotionSchedule.Enabled = true; } else { menu_promotionSchedule.Enabled = false; }
            if (userObject.poPrepare) { menu_poPrepare.Enabled = true; } else { menu_poPrepare.Enabled = false; }
            if (userObject.po) { menu_po.Enabled = true; } else { menu_po.Enabled = false; }
            if (userObject.goodsReceipt) { menu_goodsReceipt.Enabled = true; } else { menu_goodsReceipt.Enabled = false; }
            if (userObject.poReports) { menu_poReports.Enabled = true; } else { menu_poReports.Enabled = false; }
            if (userObject.poExceptionReport) { menu_poExceptionReport.Enabled = true; } else { menu_poExceptionReport.Enabled = false; }
            if (userObject.subcontractOrderExceptionReport) { menu_subcontractOrderExceptionReport.Enabled = true; } else { menu_subcontractOrderExceptionReport.Enabled = false; }
            if (userObject.poManagementReport) { menu_poManagementReport.Enabled = true; } else { menu_poManagementReport.Enabled = false; }
            if (userObject.poManagementDetailReport) { menu_poManagementDetailReport.Enabled = true; } else { menu_poManagementDetailReport.Enabled = false; }
            if (userObject.poForecastReport) { menu_poForecastReport.Enabled = true; } else { menu_poForecastReport.Enabled = false; }
            if (userObject.poDepartmentSalesReport) { menu_poDepartmentSalesReport.Enabled = true; } else { menu_poDepartmentSalesReport.Enabled = false; }
            if (userObject.apValidation) { menu_apValidation.Enabled = true; } else { menu_apValidation.Enabled = false; }
            if (userObject.apDebitNote) { menu_apDebitNote.Enabled = true; } else { menu_apDebitNote.Enabled = false; }
            if (userObject.apCreditMemoRequest) { menu_apCreditMemoRequest.Enabled = true; } else { menu_apCreditMemoRequest.Enabled = false; }
            if (userObject.apDebitMemoRequest) { menu_apDebitMemoRequest.Enabled = true; } else { menu_apDebitMemoRequest.Enabled = false; }
            if (userObject.apNetSettlement) { menu_apNetSettlement.Enabled = true; } else { menu_apNetSettlement.Enabled = false; }
            if (userObject.paymentResolution) { menu_paymentResolution.Enabled = true; } else { menu_paymentResolution.Enabled = false; }
            if (userObject.apPayment) { menu_apPayment.Enabled = true; } else { menu_apPayment.Enabled = false; }
            if (userObject.apReports) { menu_apReports.Enabled = true; } else { menu_apReports.Enabled = false; }
            if (userObject.apAging) { menu_apAging.Enabled = true; } else { menu_apAging.Enabled = false; }
            if (userObject.assembly) { menu_assembly.Enabled = true; } else { menu_assembly.Enabled = false; }
            if (userObject.assemblyRecipt) { menu_assemblyRecipt.Enabled = true; } else { menu_assemblyRecipt.Enabled = false; }
            if (userObject.disassembly) { menu_disassembly.Enabled = true; } else { menu_disassembly.Enabled = false; }
            if (userObject.disassemblyReceipt) { menu_disassemblyReceipt.Enabled = true; } else { menu_disassemblyReceipt.Enabled = false; }
            if (userObject.manufacturing) { menu_manufacturing.Enabled = true; } else { menu_manufacturing.Enabled = false; }
            if (userObject.manufacturingReceipt) { menu_manufacturingReceipt.Enabled = true; } else { menu_manufacturingReceipt.Enabled = false; }
            if (userObject.miscellaneousIssue) { menu_miscellaneousIssue.Enabled = true; } else { menu_miscellaneousIssue.Enabled = false; }
            if (userObject.miscellaneousReceipt) { menu_miscellaneousReceipt.Enabled = true; } else { menu_miscellaneousReceipt.Enabled = false; }
            if (userObject.subcontractOrder) { menu_subcontractOrder.Enabled = true; } else { menu_subcontractOrder.Enabled = false; }
            if (userObject.subcontractReceipt) { menu_subcontractReceipt.Enabled = true; } else { menu_subcontractReceipt.Enabled = false; }
            if (userObject.intersiteTransfer) { menu_intersiteTransfer.Enabled = true; } else { menu_intersiteTransfer.Enabled = false; }
            if (userObject.receiptReturn) { menu_receiptReturn.Enabled = true; } else { menu_receiptReturn.Enabled = false; }
            if (userObject.shipmentReturn) { menu_shipmentReturn.Enabled = true; } else { menu_shipmentReturn.Enabled = false; }
            if (userObject.stockChange) { menu_stockChange.Enabled = true; } else { menu_stockChange.Enabled = false; }
            if (userObject.stockReports) { menu_stockReports.Enabled = true; } else { menu_stockReports.Enabled = false; }
            if (userObject.ipadShortageReport) { menu_ipadShortageReport.Enabled = true; } else { menu_ipadShortageReport.Enabled = false; }
            if (userObject.globalShortageReport) { menu_globalShortageReport.Enabled = true; } else { menu_globalShortageReport.Enabled = false; }
            if (userObject.detailedShortageReport) { menu_detailedShortageReport.Enabled = true; } else { menu_detailedShortageReport.Enabled = false; }
            if (userObject.inventoryManagement) { menu_inventoryManagement.Enabled = true; } else { menu_inventoryManagement.Enabled = false; }
            if (userObject.stockTransactionReport) { menu_stockTransactionReport.Enabled = true; } else { menu_stockTransactionReport.Enabled = false; }
            if (userObject.stockMovementReport) { menu_stockMovementReport.Enabled = true; } else { menu_stockMovementReport.Enabled = false; }
            if (userObject.stockValuationReport) { menu_stockValuationReport.Enabled = true; } else { menu_stockValuationReport.Enabled = false; }
            if (userObject.wmsGoodsReceipt) { menu_wmsGoodsReceipt.Enabled = true; } else { menu_wmsGoodsReceipt.Enabled = false; }
            if (userObject.wmsStockStatusChange) { menu_wmsStockStatusChange.Enabled = true; } else { menu_wmsStockStatusChange.Enabled = false; }
            if (userObject.wmsShipmentReturn) { menu_wmsShipmentReturn.Enabled = true; } else { menu_wmsShipmentReturn.Enabled = false; }
            if (userObject.IntersiteTransferOrder) { menu_IntersiteTransferOrder.Enabled = true; } else { menu_IntersiteTransferOrder.Enabled = false; }
            if (userObject.IntersiteTransferReceipt) { menu_IntersiteTransferReceipt.Enabled = true; } else { menu_IntersiteTransferReceipt.Enabled = false; }
            if (userObject.wmsCustomerDelivery) { menu_wmsCustomerDelivery.Enabled = true; } else { menu_wmsCustomerDelivery.Enabled = false; }
            if (userObject.wmsReceiptReturn) { menu_wmsReceiptReturn.Enabled = true; } else { menu_wmsReceiptReturn.Enabled = false; }
            if (userObject.brandList) { menu_brandList.Enabled = true; } else { menu_brandList.Enabled = false; }
            if (userObject.chartOfAccount) { menu_chartOfAccount.Enabled = true; } else { menu_chartOfAccount.Enabled = false; }
            if (userObject.companyList) { menu_companyList.Enabled = true; } else { menu_companyList.Enabled = false; }
            if (userObject.customerList) { menu_customerList.Enabled = true; } else { menu_customerList.Enabled = false; }
            if (userObject.customerPriceEntry) { menu_customerPriceEntry.Enabled = true; } else { menu_customerPriceEntry.Enabled = false; }
            if (userObject.deliveryRoutePlanList) { menu_deliveryRoutePlanList.Enabled = true; } else { menu_deliveryRoutePlanList.Enabled = false; }
            if (userObject.driverList) { menu_driverList.Enabled = true; } else { menu_driverList.Enabled = false; }
            if (userObject.paymentTermList) { menu_paymentTermList.Enabled = true; } else { menu_paymentTermList.Enabled = false; }
            if (userObject.productList) { menu_productList.Enabled = true; } else { menu_productList.Enabled = false; }
            if (userObject.promotionScheduleTypeList) { menu_promotionScheduleTypeList.Enabled = true; } else { menu_promotionScheduleTypeList.Enabled = false; }
            if (userObject.salesPersonList) { menu_salesPersonList.Enabled = true; } else { menu_salesPersonList.Enabled = false; }
            if (userObject.supplierList) { menu_supplierList.Enabled = true; } else { menu_supplierList.Enabled = false; }
            if (userObject.customerMap) { menu_customerMap.Enabled = true; } else { menu_customerMap.Enabled = false; }
            if (userObject.customerMapWeb) { menu_customerMapWeb.Enabled = true; } else { menu_customerMapWeb.Enabled = false; }
            if (userObject.salesByCategoryMap) { menu_salesByCategoryMap.Enabled = true; } else { menu_salesByCategoryMap.Enabled = false; }
            if (userObject.userMaintenance) { menu_userMaintenance.Enabled = true; } else { menu_userMaintenance.Enabled = false; }

            if (GATE.userID == "ADMIN")
            {
                menu_systemMenu.Visible = true;
               
                DateTime creation = File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location);
                this.Text = "Main - " + creation.ToShortDateString();
            }
            else
            {
                menu_systemMenu.Visible = false;
                
            }

            
            if (GATE.userID == "")
            {
                Application.Exit();
            }

            if ((GATE.userID == "DR1" || GATE.userID == "DR2" || GATE.userID == "DR3" || GATE.userID == "TEAM"))
            {
                WorkFlowTabs.Visible = false;
                pnl_main.Visible = false;
                tab_main.Visible = false;
                tab_sales.Visible = false;
                tab_ar.Visible = false;
                tab_po.Visible = false;
                tab_ap.Visible = false;
                tab_inventory.Visible = false;
                panel1.Visible = false;
            }
            else
            {
                WorkFlowTabs.SelectedTab = tabPage1;
                WorkFlowTabs.Show();
            }
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_userMaintenance_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PASS))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            PASS f = new PASS { MdiParent = this };
            ShowForm(f);

            //PASS pASS = new PASS();
            //pASS.MdiParent = this;
            //pASS.Show();
        }

        private void menu_vendorAPCenter_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.VendorAPCenter))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            //Purchase.VendorAPCenter vendorAPCenter = new Purchase.VendorAPCenter();
            //vendorAPCenter.MdiParent = this;
            //vendorAPCenter.Show();

            Purchase.VendorAPCenter f = new Purchase.VendorAPCenter { MdiParent = this };
            ShowForm(f);
        }

        private void menu_poPrepare_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.POPrepare))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //Purchase.POPrepare poPrepare = new Purchase.POPrepare();
            //poPrepare.MdiParent = this;
            //poPrepare.Show();

            Purchase.POPrepare f = new Purchase.POPrepare { MdiParent = this };
            ShowForm(f);

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.POPrepData))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Purchase.POPrepData poPrepData = new Purchase.POPrepData();
            try
            {
                poPrepData.StartPosition = FormStartPosition.Manual;
                poPrepData.Bounds = Screen.AllScreens[1].Bounds;
                poPrepData.Show();
            }
            catch
            {
                poPrepData.Show();
            }
            

           
        }

        private void menu_po_Click(object sender, EventArgs e)
        {
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.GetType() == typeof(Purchase.PO))
            //    {
            //        form.Activate();
            //        return;
            //    }
            //}

            //Purchase.PO po = new Purchase.PO();
            //po.MdiParent = this;
            //po.Show();
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.PORDER))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            //Purchase.PORDER po = new Purchase.PORDER();
            //po.MdiParent = this;
            //po.Show();

            Purchase.PORDER f = new Purchase.PORDER { MdiParent = this };
            ShowForm(f);
        }

        private void menu_goodsReceipt_Click(object sender, EventArgs e)
        {
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.GetType() == typeof(Purchase.Receiving))
            //    {
            //        form.Activate();
            //        return;
            //    }
            //}

            //Purchase.Receiving receiving = new Purchase.Receiving();
            //receiving.MdiParent = this;
            //receiving.Show();
            
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.RECEIPTS))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            Purchase.RECEIPTS f = new Purchase.RECEIPTS();
            f.Show();
        }

        private void menu_TemporaryPurchaseOrderList_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(TemporaryPurchaseOrderList))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            //TemporaryPurchaseOrderList temporaryPurchaseOrderList = new TemporaryPurchaseOrderList();
            //temporaryPurchaseOrderList.MdiParent = this;
            //temporaryPurchaseOrderList.Show();

            TemporaryPurchaseOrderList f = new TemporaryPurchaseOrderList { MdiParent = this };
            ShowForm(f);
        }

        private void menu_employeeList_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(EmployeeList))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            //EmployeeList employeeList = new EmployeeList();
            //employeeList.MdiParent = this;
            //employeeList.Show();

            EmployeeList f = new EmployeeList { MdiParent = this };
            ShowForm(f);
        }

        private void menu_preparationPlan_Click(object sender, EventArgs e)
        {
            if(GATE.userID == "WH01" || GATE.userID == "BEN")
            {
                PreparationPlan preparationPlan = new PreparationPlan();
                //preparationPlan.MdiParent = this;
                preparationPlan.Show();
            }
            else
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(PreparationPlan))
                    {
                        form.Activate();
                        form.WindowState = FormWindowState.Maximized;
                        form.BringToFront();
                        return;
                    }
                }
                PreparationPlan f = new PreparationPlan { MdiParent = this };
                ShowForm(f);
            }
            

        }

        private void menu_deliveryNote_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(DeliveryNote))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            //DeliveryInvoice deliveryInvoice = new DeliveryInvoice();
            //deliveryInvoice.MdiParent = this;
            //deliveryInvoice.Show();

            DeliveryNote f = new DeliveryNote { MdiParent = this };
            ShowForm(f);
        }

        private void menu_collectionfromDelivery_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CollectionfromDelivery))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //DeliveryManifest deliveryManifest = new DeliveryManifest();
            //deliveryManifest.MdiParent = this;
            //deliveryManifest.Show();

            CollectionfromDelivery f = new CollectionfromDelivery { MdiParent = this };
            ShowForm(f);
        }

        private void menu_pick_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Pick))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //Pick pick = new Pick();
            //pick.MdiParent = this;
            //pick.Show();

            Pick f = new Pick { MdiParent = this };
            ShowForm(f);
        }

        private void menu_pickingTicket_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PickingTickets))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //PickTicket pickTicket = new PickTicket();
            //pickTicket.MdiParent = this;
            //pickTicket.Show();

            PickingTickets f = new PickingTickets { MdiParent = this };
            ShowForm(f);

        }

        private void menu_validation_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Delivery))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Delivery delivery = new Delivery();
            //delivery.MdiParent = this;
            delivery.Show();

           // Delivery f = new Delivery { MdiParent = this };
            //ShowForm(f);
        }

        private void menu_invoice_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Invoice))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Invoice invoice = new Invoice();
            //invoice.MdiParent = this;
            invoice.Show();

            //Invoice f = new Invoice { MdiParent = this };
            //ShowForm(f);
        }

        private void menu_arPayment_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ARPAYMENT))
                {
                    form.Activate();
                    //form.WindowState = FormWindowState.Normal;
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    return;
                }
            }
            ARPAYMENT aRPAYMENT = new ARPAYMENT();
            //aRPAYMENT.MdiParent = this;
            aRPAYMENT.Show();

            //ARPAYMENT f = new ARPAYMENT { MdiParent = this };
            //ShowForm(f);
        }

        private void menu_deposit_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Deposit))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Deposit deposit = new Deposit();
            //dEPOSITSLIP.MdiParent = this;
            deposit.Show();

            //DEPOSITSLIP f = new DEPOSITSLIP { MdiParent = this };
            //ShowForm(f);
        }

        private void menu_apValidation_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PVALIDATION))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //PVALIDATION pVALIDATION = new PVALIDATION();
            //pVALIDATION.MdiParent = this;
            //pVALIDATION.Show();

            PVALIDATION f = new PVALIDATION { MdiParent = this };
            ShowForm(f);
        }

        private void menu_apPayment_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PPAYMENT))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //PPAYMENT pPAYMENT = new PPAYMENT();
            //pPAYMENT.MdiParent = this;
            //pPAYMENT.Show();

            PPAYMENT f = new PPAYMENT { MdiParent = this };
            ShowForm(f);
        }


        private void menu_shipmentReturn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SHIPMENTRETURN))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //SHIPMENTRETURN shipmentReturn = new SHIPMENTRETURN();
            //shipmentReturn.MdiParent = this;
            //shipmentReturn.Show();

            //SHIPMENTRETURN f = new SHIPMENTRETURN { MdiParent = this };
            //ShowForm(f);

            SHIPMENTRETURN f = new SHIPMENTRETURN();
            //delivery.MdiParent = this;
            f.Show();
        }

        private void menu_deallocation_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(DEALLOCATION))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //DEALLOCATION deallocation = new DEALLOCATION();
            //deallocation.MdiParent = this;
            //deallocation.Show();

            //DEALLOCATION f = new DEALLOCATION { MdiParent = this };
            //ShowForm(f);

            DEALLOCATION dEALLOCATION = new DEALLOCATION();
            //delivery.MdiParent = this;
            dEALLOCATION.Show();
            
        }

        private void menu_receiptReturn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(RECEIPTRETURN))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //RECEIPTRETURN receiptReturn = new RECEIPTRETURN();
            //receiptReturn.MdiParent = this;
            //receiptReturn.Show();

            //RECEIPTRETURN f = new RECEIPTRETURN { MdiParent = this };
            //ShowForm(f);

            RECEIPTRETURN f = new RECEIPTRETURN();
            f.Show();

        }

        private void menu_intersiteTransfer_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(IntersiteTransfer))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            IntersiteTransfer f = new IntersiteTransfer();
            f.Show();
        }

        private void menu_stockChange_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(StockChange))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //IntersiteTransfer intersiteTransfer = new IntersiteTransfer();
            //intersiteTransfer.MdiParent = this;
            //intersiteTransfer.Show();

            StockChange f = new StockChange();
            ShowForm(f);
        }

        private void menu_disassembly_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Disassembly))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }


            Disassembly f = new Disassembly();
            f.Show();
        }

        private void menu_disassemblyReceipt_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(DisassemblyReceipt))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }


            DisassemblyReceipt f = new DisassemblyReceipt();
            f.Show();
        }

        private void menu_assembly_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Stock.Assembly))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            Assembly f = new Assembly();
            f.Show();
        }

        private void menu_assemblyRecipt_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(AssemblyReceipt))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }


            AssemblyReceipt f = new AssemblyReceipt();
            f.Show();
        }

        private void menu_subcontractOrder_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SubcontractOrder))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            //SubcontractOrder f = new SubcontractOrder { MdiParent = this };
            //ShowForm(f);

            SubcontractOrder f = new SubcontractOrder();
            f.Show();
        }

        private void menu_subcontractReceipt_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SubcontractReceipt))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            //SubcontractReceipt f = new SubcontractReceipt { MdiParent = this };
            //ShowForm(f);

            SubcontractReceipt f = new SubcontractReceipt();
            f.Show();
        }

        private void menu_arbyCustomerReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ARbyCustomerReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    return;
                }
            }
            ARbyCustomerReport aROPENCLOSED = new ARbyCustomerReport();
            aROPENCLOSED.Show();

            //AROPENCLOSED f = new AROPENCLOSED { MdiParent = this };
            //ShowForm(f);
        }

        private void menu_driverList_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(DriverList))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            DriverList f = new DriverList { MdiParent = this };
            ShowForm(f);
        }

        private void menu_aging_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(AGING))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            AGING f = new AGING { MdiParent = this };
            ShowForm(f);
        }

        private void menu_manufacturing_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Manufacturing))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            //Manufacturing f = new Manufacturing { MdiParent = this };
            //ShowForm(f);

            Manufacturing mnufacturing = new Manufacturing();
            mnufacturing.Show();
        }

        private void menu_manufacturingReceipt_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ManufacturingReceipt))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //ManufacturingReceipt f = new ManufacturingReceipt { MdiParent = this };
            //ShowForm(f);

            ManufacturingReceipt mnufacturingReceipt = new ManufacturingReceipt();
            mnufacturingReceipt.Show();
        }

        private void menu_entryBatch_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(EntryBatch))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //EntryBatch f = new EntryBatch { MdiParent = this };
            //ShowForm(f);

            EntryBatch entryBatch = new EntryBatch();
            entryBatch.Show();
        }

        private void menu_chartOfAccount_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ChartOfAccount))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            ChartOfAccount f = new ChartOfAccount();
            f.Show();
        }

        private void menu_customerList_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CustomerList))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //CustomerList f = new CustomerList { MdiParent = this };
            //ShowForm(f);

            CustomerList customerList = new CustomerList();
            //delivery.MdiParent = this;
            customerList.Show();
        }


        private void menu_productList_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ProductList))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            ProductList productList = new ProductList();
            //delivery.MdiParent = this;
            productList.Show();

            //ProductList f = new ProductList { MdiParent = this };
            //ShowForm(f);
        }

        private void menu_supplierList_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SupplierList))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            SupplierList f = new SupplierList { MdiParent = this };
            ShowForm(f);
        }

        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ChartOfAccount2))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            ChartOfAccount2 f = new ChartOfAccount2 { MdiParent = this };
            ShowForm(f);
        }

        private void menu_globalShortageReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Stock.OSReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Stock.OSReport f = new Stock.OSReport { MdiParent = this };
            ShowForm(f);
        }

        private void menu_poManagementReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.POManagement))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //Purchase.POManagement f = new Purchase.POManagement { MdiParent = this };
            //ShowForm(f);

            Purchase.POManagement f = new POManagement();
            //aRPAYMENT.MdiParent = this;
            f.Show();
        }

        private void menu_poManagementDetailReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.POManagement_Detail))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //Purchase.POManagement_Detail f = new Purchase.POManagement_Detail { MdiParent = this };
            //ShowForm(f);

            Purchase.POManagement_Detail f = new POManagement_Detail();
            //aRPAYMENT.MdiParent = this;
            f.Show();
        }

        private void menu_apAging_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.AP_AGING))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Purchase.AP_AGING f = new Purchase.AP_AGING { MdiParent = this };
            ShowForm(f);
        }

        private void menu_arbySalespersonReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Sales.ARbySalespersonReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Sales.ARbySalespersonReport f = new Sales.ARbySalespersonReport { MdiParent = this };
            ShowForm(f);
        }

        private void menu_arOpenClosedAll_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Sales.AROPENCLOSED_ALL))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Sales.AROPENCLOSED_ALL f = new Sales.AROPENCLOSED_ALL { MdiParent = this };
            ShowForm(f);
        }

        private void menu_stockTransactionReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Stock.STOJOU_History))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //Stock.STOJOU_History f = new Stock.STOJOU_History { MdiParent = this };
            //ShowForm(f);

            Stock.STOJOU_History sTOJOU_History = new Stock.STOJOU_History();
            //dEPOSITSLIP.MdiParent = this;
            sTOJOU_History.Show();
        }

        private void menu_brandList_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Lists.BrandList))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Lists.BrandList f = new Lists.BrandList { MdiParent = this };
            ShowForm(f);
        }

        private void menu_commissionReportOld_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Sales.CommissionReportOld))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Sales.CommissionReportOld commission = new Sales.CommissionReportOld();
            //dEPOSITSLIP.MdiParent = this;
            commission.Show();
        }

        private void menu_packageNutLabelPrint_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Sales.PackageNutLabelPrint))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Sales.PackageNutLabelPrint packageNutLabelPrint = new Sales.PackageNutLabelPrint();
            //packageNutLabelPrint.MdiParent = this;
            packageNutLabelPrint.Show();
        }

        private void menu_nutCategorySalesReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(NutCategorySalesReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            NutCategorySalesReport nutCategorySalesReport = new NutCategorySalesReport();
            nutCategorySalesReport.Show();
        }

        private void menu_packageNutCustomerOption_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PackageNutCustomerOption))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            PackageNutCustomerOption packageNutCustomerOption = new PackageNutCustomerOption();
            packageNutCustomerOption.Show();
        }

        private void menu_packageNutCustomPrice_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PackageNutCustomerPrice))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            PackageNutCustomerPrice packageNutCustomerPrice = new PackageNutCustomerPrice();
            packageNutCustomerPrice.Show();
        }

        private void menu_salesbyRepReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SalesbyRepReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            SalesbyRepReport salesbyRepReport = new SalesbyRepReport();
            salesbyRepReport.Show();
        }

        private void menu_poForecastReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(JITPO))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            JITPO jitPO = new JITPO();
            jitPO.Show();
        }

        private void menu_salesbyProductReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Reports.Top_Product_Report))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Reports.Top_Product_Report top_Product_Report = new Reports.Top_Product_Report();
            top_Product_Report.Show();
        }

        private void menu_ipadShortageReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(IPADORDER_SHORTAGE_Form))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            IPADORDER_SHORTAGE_Form iPAD_ORDER_DIFF = new IPADORDER_SHORTAGE_Form();
            iPAD_ORDER_DIFF.Show();
        }

        private void menu_inventoryManagement_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(LotInformation))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            LotInformation lotInformation = new LotInformation();
            lotInformation.Show();
        }

        private void menu_salesOrderExceptionReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SalesOrderExceptionReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            SalesOrderExceptionReport salesOrderExceptionReport = new SalesOrderExceptionReport();
            salesOrderExceptionReport.Show();
        }

        private void menu_poDepartmentSalesReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.SalesReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Purchase.SalesReport salesReport = new Purchase.SalesReport();
            salesReport.Show();
        }

        private void menu_poExceptionReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PurchaseOrderExceptionReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            PurchaseOrderExceptionReport purchaseOrderExceptionReport = new PurchaseOrderExceptionReport();
            purchaseOrderExceptionReport.Show();
        }

 
        private void menu_detailedShortageReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(DeliveryOSReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            DeliveryOSReport deliveryOSReport = new DeliveryOSReport();
            deliveryOSReport.Show();
        }

        private void menu_subcontractOrderExceptionReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SubcontractExceptionReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            SubcontractExceptionReport subcontractExceptionReport = new SubcontractExceptionReport();
            subcontractExceptionReport.Show();
        }

        private void menu_stockValuationReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(StockValuationReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            StockValuationReport stockValuationReport = new StockValuationReport();
            stockValuationReport.Show();
        }

        private void menu_customerPriceEntry_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PriceListEntry))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            PriceListEntry priceListEntry = new PriceListEntry();
            priceListEntry.Show();
        }

        

        private void menu_companyList_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CompanyList))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            CompanyList companyList = new CompanyList();
            companyList.Show();
        }

        private void menu_duplicateSalesOrder_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(DuplicateSalesOrder))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            DuplicateSalesOrder f = new DuplicateSalesOrder { MdiParent = this };
            ShowForm(f);
            //DuplicateSalesOrder duplicateSalesOrder = new DuplicateSalesOrder();
            //duplicateSalesOrder.Show();
        }

        private void menu_netSettlement_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(NetSettlement))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            NetSettlement netSettlement = new NetSettlement();
            netSettlement.Show();
        }

        private void menu_wmsStockStatusChange_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(StockChange))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //IntersiteTransfer intersiteTransfer = new IntersiteTransfer();
            //intersiteTransfer.MdiParent = this;
            //intersiteTransfer.Show();

            StockChange f = new StockChange { MdiParent = this };
            ShowForm(f);
        }

        private void menu_wmsCustomerDelivery_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PickingTickets))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            //PickTicket pickTicket = new PickTicket();
            //pickTicket.MdiParent = this;
            //pickTicket.Show();

            PickingTickets f = new PickingTickets { MdiParent = this };
            ShowForm(f);
        }

        private void menu_wmsGoodsReceipt_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(mWMS.wms_goodsReceipt))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            mWMS.wms_goodsReceipt f = new mWMS.wms_goodsReceipt { MdiParent = this };
            ShowForm(f);
        }

        private void menu_wmsShipmentReturn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(mWMS.wms_shipmentReturn))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            //mWMS.wms_shipmentReturn f = new mWMS.wms_shipmentReturn { MdiParent = this };
            //ShowForm(f);

            mWMS.wms_shipmentReturn f = new mWMS.wms_shipmentReturn();
            f.Show();


        }


        private void menu_wmsReceiptReturn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(mWMS.wms_receiptReturn))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            mWMS.wms_receiptReturn f = new mWMS.wms_receiptReturn { MdiParent = this };
            ShowForm(f);
        }

        private void menu_IntersiteTransferOrder_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(mWMS.wms_intersiteTransfersOrder))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            mWMS.wms_intersiteTransfersOrder f = new mWMS.wms_intersiteTransfersOrder { MdiParent = this };
            ShowForm(f);
        }

        private void menu_IntersiteTransferReceipt_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(mWMS.wms_intersiteTransfersReceipt))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            mWMS.wms_intersiteTransfersReceipt f = new mWMS.wms_intersiteTransfersReceipt { MdiParent = this };
            ShowForm(f);
        }

        private void menu_creditMemoRequest_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Sales.CreditMemoRequest))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Sales.CreditMemoRequest creditMemoRequest = new Sales.CreditMemoRequest();
            creditMemoRequest.Show();
        }

        private void menu_arCollection_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CollectionfromSales))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            CollectionfromSales aRCOLLECTIONH = new CollectionfromSales();
            aRCOLLECTIONH.Show();
        }


        private void menu_customerMap_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Reports.CustomerMap))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Reports.CustomerMap customerMap = new Reports.CustomerMap();
            customerMap.Show();
        }

        private void menu_customerMapWeb_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Reports.CustomerWeb))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Reports.CustomerWeb customerWeb = new Reports.CustomerWeb(true, "", "", "", "", "", "");
            customerWeb.Show();
        }

        private void menu_ARSalesDebitMemoSummary_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ARSalesDebitMemoSummaryReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            ARSalesDebitMemoSummaryReport salesDebitMemoSummary = new ARSalesDebitMemoSummaryReport();
            salesDebitMemoSummary.Show();
        }

        private void menu_ARCollectionsSummary_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ARCollectionsSummaryReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            ARCollectionsSummaryReport aRCollectionDailyMonthly = new ARCollectionsSummaryReport();
            aRCollectionDailyMonthly.Show();
        }

        private void menu_nonSufficientFundsReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(NSFReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            NSFReport nSFReport = new NSFReport();
            nSFReport.Show();
        }

        private void menu_AROverpayment_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(AROverpayment))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            AROverpayment aROverPayment = new AROverpayment();
            aROverPayment.Show();
        }

        private void menu_salesbyCustomerReport_Click(object sender, EventArgs e)
        {
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.GetType() == typeof(SalesbyCustomerReport))
            //    {
            //        form.Activate();
            //        form.WindowState = FormWindowState.Normal;
            //        form.BringToFront();
            //        return;
            //    }
            //}
            //SalesbyCustomerReport salesbyCustomer = new SalesbyCustomerReport();
            //salesbyCustomer.Show();
        }

        private void menu_commissionReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CommissionReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            CommissionReport commissionReport_Beta = new CommissionReport();
            commissionReport_Beta.Show();
        }

        private void menu_salesByCategoryMap_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Reports.SalesbyCategoryMap))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Reports.SalesbyCategoryMap salesbyCategoryMap = new Reports.SalesbyCategoryMap();
            salesbyCategoryMap.Show();
        }

        private void menu_promotionSchedule_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.PromotionSchedule.PromotionSchedule))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Purchase.PromotionSchedule.PromotionSchedule promotionSchedule = new Purchase.PromotionSchedule.PromotionSchedule();
            promotionSchedule.Show();
        }

        private void menu_promotionScheduleTypeList_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.PromotionSchedule.PromotionType))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Purchase.PromotionSchedule.PromotionType promotionType = new Purchase.PromotionSchedule.PromotionType();
            promotionType.Show();
        }

        private void menu_deliveryRoutePlanList_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Lists.DeliveryRoutePlanList))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Lists.DeliveryRoutePlanList deliveryRoutePlanList = new Lists.DeliveryRoutePlanList();
            deliveryRoutePlanList.Show();
        }

        private void menu_miscellaneousReceipt_Click(object sender, EventArgs e)
        {
            if (connSalesOrder.sp_Miscellaneous_UserCheck() == "1")
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(Stock.MiscellaneousReceipt))
                    {
                        form.Activate();
                        form.WindowState = FormWindowState.Normal;
                        form.BringToFront();
                        return;
                    }
                }
                Stock.MiscellaneousReceipt miscellaneousReceipt = new Stock.MiscellaneousReceipt();
                miscellaneousReceipt.Show();
            }
            else
            {
                MessageBox.Show("You do not have permissions to access.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_miscellaneousIssue_Click(object sender, EventArgs e)
        {
            if (connSalesOrder.sp_Miscellaneous_UserCheck() == "1")
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(Stock.MiscellaneousIssue))
                    {
                        form.Activate();
                        form.WindowState = FormWindowState.Normal;
                        form.BringToFront();
                        return;
                    }
                }
                Stock.MiscellaneousIssue miscellaneousIssue = new Stock.MiscellaneousIssue();
                miscellaneousIssue.Show();
            }
            else
            {
                MessageBox.Show("You do not have permissions to access.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_poCreditMemoRequest_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.CreditMemoRequest))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Purchase.CreditMemoRequest creditMemoRequest = new Purchase.CreditMemoRequest();
            creditMemoRequest.Show();
        }

        private void menu_poDebitMemoRequest_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.DebitMemoRequest))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Purchase.DebitMemoRequest debitMemoRequest = new Purchase.DebitMemoRequest();
            debitMemoRequest.Show();
        }

        private void menu_poDebitNote_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.DebitNote))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Purchase.DebitNote debitNote = new Purchase.DebitNote();
            debitNote.Show();
        }

        private void menu_apNetSettlement_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Purchase.APNetSettlement))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Purchase.APNetSettlement apNetSettlement = new Purchase.APNetSettlement();
            apNetSettlement.Show();
        }

        

        private void menu_stockMovementReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Stock.StockDetailByProduct))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Stock.StockDetailByProduct stockDetailByProduct = new Stock.StockDetailByProduct();
            stockDetailByProduct.Show();
        }

        private void buttonEnabledChanged(object sender, EventArgs e)
        {
            //((Button)sender).BackColor = Color.DarkSlateGray;
            //((Button)sender).BackColor = Color.FromArgb(1, 63, 45);
            //((Button)sender).BackColor = Color.FromArgb(23, 58, 29);
            
        }
        private void PicBox_Main_Click(object sender, EventArgs e)
        {
            

            Button button = sender as Button;
            switch (button.Text) {
                case "Main":
                    WorkFlowTabs.SelectedIndex = 0;
                    pnl_main.Visible = true;
                    pnl_sales.Visible = false;
                    pnl_ar.Visible = false;
                    pnl_po.Visible = false;
                    pnl_ap.Visible = false;
                    pnl_inventory.Visible = false;
                    break;
                case "Sales":
                    WorkFlowTabs.SelectedIndex = 1;
                    pnl_main.Visible = false;
                    pnl_sales.Visible = true;
                    pnl_ar.Visible = false;
                    pnl_po.Visible = false;
                    pnl_ap.Visible = false;
                    pnl_inventory.Visible = false;
                    break;
                case "AR":
                    WorkFlowTabs.SelectedIndex = 2;
                    pnl_main.Visible = false;
                    pnl_sales.Visible = false;
                    pnl_ar.Visible = true;
                    pnl_po.Visible = false;
                    pnl_ap.Visible = false;
                    pnl_inventory.Visible = false;
                    break;
                case "PO":
                    WorkFlowTabs.SelectedIndex = 3;
                    pnl_main.Visible = false;
                    pnl_sales.Visible = false;
                    pnl_ar.Visible = false;
                    pnl_po.Visible = true;
                    pnl_ap.Visible = false;
                    pnl_inventory.Visible = false;
                    break;
                case "AP":
                    WorkFlowTabs.SelectedIndex = 4;
                    pnl_main.Visible = false;
                    pnl_sales.Visible = false;
                    pnl_ar.Visible = false;
                    pnl_po.Visible = false;
                    pnl_ap.Visible = true;
                    pnl_inventory.Visible = false;
                    break;
                case "Inventory":
                    WorkFlowTabs.SelectedIndex = 5;
                    pnl_main.Visible = false;
                    pnl_sales.Visible = false;
                    pnl_ar.Visible = false;
                    pnl_po.Visible = false;
                    pnl_ap.Visible = false;
                    pnl_inventory.Visible = true;
                    break;
            }
        }

        private void menu_salesPersonList_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Lists.SalesRepList))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Lists.SalesRepList salesRepList = new Lists.SalesRepList();
            salesRepList.Show();
        }

        private void menu_salesPerformanceReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SalesARbyRepReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            SalesARbyRepReport salesARbyRepReport = new SalesARbyRepReport();
            salesARbyRepReport.Show();
        }

        private void menu_paymentResolution_Click(object sender, EventArgs e)
        {
            //string menu = (sender as ToolStripMenuItem).Name;
            //if (!AccessCheck(GATE.userID, menu)) { return; }

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Reports.PaymentResolution2))
                {
                    form.Activate() ;
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            Reports.PaymentResolution2 paymentResolution = new Reports.PaymentResolution2();
            paymentResolution.Show();
            //Your item has been shipped.The tracking number is 9534615619521090379249
        }

        private void progress_paint(object sender, PaintEventArgs e)
        {
            //Graphics g = panel3.CreateGraphics();
            ////g.Clear(this.BackColor);
            //Rectangle rect = new Rectangle(0, 0, 249, 44);
            //Pen pen = new Pen(Color.FromArgb(176, 214, 115));
            //g.DrawRectangle(pen, rect);
            ////g.Dispose();
        }

        private void progressBar_pain(object sender, PaintEventArgs e)
        {
            //Graphics g = panel4.CreateGraphics();
            ////g.Clear(this.BackColor);
            //Rectangle rect = new Rectangle(0, 0, 39, 9);
            //SolidBrush brush = new SolidBrush(Color.FromArgb(176, 214, 115));
            //g.FillRectangle(brush, rect);
            ////g.Dispose();
        }

        private bool AccessCheck(string UserID, string Menu)
        {
            Menu = Menu.Replace("menu_", "");
            bool Access = connSalesOrder.sp_Menu_AccessCheck(UserID, Menu);
            if (!Access)
            {
                MessageBox.Show("You do not have permissions to access.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return Access;
            //MessageBox.Show(Access.ToString());
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //MessageBox.Show(button.Name);
            string buttonName = button.Name;

            Type type;
            
            switch (buttonName)
            {
                case "btn_salesOrder":
                    type = typeof(SalesOrder);
                    break;
                case "btn_auditSalesOrder":
                    type = typeof(AuditSalesOrder);
                    break;
                case "btn_confirmedSalesOrder":
                    type = typeof(ConfirmedSalesOrder);
                    break;
                case "btn_preparationPlan":
                    type = typeof(PreparationPlan);
                    break;
                case "btn_pickingTicket":
                    type = typeof(PickingTickets);
                    break;
                case "btn_deliveryNote":
                    type = typeof(DeliveryNote);
                    break;

                default:
                    type = typeof(SalesOrder);
                    break;
            }
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == type)
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            var selectedForm = (Form)Activator.CreateInstance(type);
            //var selectedForm = form1;
            //selectedForm.MdiParent = this;
            //MdiParent = this;
            selectedForm.Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            string menu = (sender as ToolStripMenuItem).Name;
            if (!AccessCheck(GATE.userID, menu)) { return; }

            Type type;
            Form form1 = new SalesARbyRepReport();

            switch (menu)
            {
                case "btn_salesOrder":
                    type = typeof(SalesOrder);
                    break;
                //accounting
                //case "menu_accounting":
                //    type = typeof(GeneralJournalEntriesList);
                //    //form1 = new SalesARbyRepReport();
                //    break;
                case "menu_generalJournalEntries":
                    type = typeof(GeneralJournalEntriesList);
                    break;
                case "menu_profitAndLossReport":
                    type = typeof(Reports.Rpt_ProfitLossHeader2);
                    break;
                case "menu_sales":
                    type = typeof(GeneralJournalEntriesList);
                    break;
                case "menu_salesOrder":
                    type = typeof(SalesOrder);
                    break;
                case "menu_auditSalesOrder":
                    type = typeof(AuditSalesOrder);
                    break;
                case "menu_confirmedSalesOrder":
                    type = typeof(ConfirmedSalesOrder);
                    break;
                case "menu_preparationPlan":
                    type = typeof(PreparationPlan);
                    break;
                case "menu_pickingTicket":
                    type = typeof(PickingTickets);
                    break;
                case "menu_deliveryNote":
                    type = typeof(DeliveryNote);
                    break;
                case "menu_duplicateSalesOrder":
                    type = typeof(DuplicateSalesOrder);
                    break;
                case "menu_deallocation":
                    type = typeof(DEALLOCATION);
                    break;
                //case "menu_packageNutLabel":
                //    //type = typeof();
                //    break;
                case "menu_packageNutLabelPrint":
                    type = typeof(PackageNutLabelPrint);
                    break;
                case "menu_packageNutCustomerOption":
                    type = typeof(PackageNutCustomerOption);
                    break;
                case "menu_packageNutCustomerPrice":
                    type = typeof(PackageNutCustomerPrice);
                    break;
                //case "menu_salesReport":
                //    //type = typeof();
                //    break;
                case "menu_salesOrderExceptionReport":
                    type = typeof(SalesOrderExceptionReport);
                    break;
                case "menu_salesbyRepReport":
                    type = typeof(SalesbyRepReport);
                    break;
                case "menu_salesbyCustomerReport":
                    type = typeof(SalesbyCustomerReport);
                    break;
                case "menu_salesbyProductReport":
                    type = typeof(Reports.Top_Product_Report);
                    break;
                case "menu_salesPerformanceReport":
                    type = typeof(SalesARbyRepReport);
                    break;
                case "menu_nutCategorySalesReport":
                    type = typeof(NutCategorySalesReport);
                    break;
                case "menu_commissionReport":
                    type = typeof(CommissionReport);
                    break;
                case "menu_miscellaneousTransactionReport":
                    type = typeof(MiscellaneousTransactionReport);
                    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;
                //case "":
                //    type = typeof();
                //    break;

                default:
                    type = typeof(SalesOrder);
                    break;
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == type)
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            
            var selectedForm = (Form)Activator.CreateInstance(type);
            //var selectedForm = form1;
            //selectedForm.MdiParent = this;
            //MdiParent = this;
            selectedForm.Show();
        }

        private void menu_paymentTermList_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PaymentTermList))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            PaymentTermList f = new PaymentTermList();
            //delivery.MdiParent = this;
            f.Show();
        }

        private void menu_writeoff_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(WriteOff))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            WriteOff f = new WriteOff();
            //delivery.MdiParent = this;
            f.Show();
        }

        private void menu_ARBalanceAccountReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ARBalanceAccountReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            ARBalanceAccountReport f = new ARBalanceAccountReport();
            //delivery.MdiParent = this;
            f.Show();
        }

        private void menu_overpaymentBalanceAccountReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(OverpaymentBalanceAccountReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            OverpaymentBalanceAccountReport f = new OverpaymentBalanceAccountReport();
            //delivery.MdiParent = this;
            f.Show();
        }

        private void menu_headerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SalesbyCustomerReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            SalesbyCustomerReport salesbyCustomer = new SalesbyCustomerReport();
            salesbyCustomer.Show();
        }

        private void menu_detailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SalesbyCustomerDetailReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            SalesbyCustomerDetailReport salesbyCustomer = new SalesbyCustomerDetailReport();
            salesbyCustomer.Show();
        }

        private void menu_arShortPaymentReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SalesbyCustomerDetailReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            ARShortPaymentReport arShortPaymentReport = new ARShortPaymentReport();
            arShortPaymentReport.Show();
        }

        private void purchaseOrderReceptionCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(POCalendar))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            POCalendar POCalendar = new POCalendar();
            POCalendar.Show();
        }

        private void label_TRD_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(TransactionReportDetail))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
                TransactionReportDetail trd = new TransactionReportDetail();
                trd.Show();
            }
        }

        private void transactionReportDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(TransactionReportDetail))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            TransactionReportDetail trd = new TransactionReportDetail();
            trd.Show();
        }

        private void menu_catalogUpload_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(uploadFile))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            uploadFile uploadFile = new uploadFile();
            uploadFile.Show();
        }

        private void menu_salesPromotionReport_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SalesPromotionReport))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            SalesPromotionReport salesPromotionReport = new SalesPromotionReport();
            salesPromotionReport.Show();
        }
    }
}
