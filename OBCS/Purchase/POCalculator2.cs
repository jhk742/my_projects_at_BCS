using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Purchase
{
    public partial class POCalculator2 : Form
    {
        String ReceivingNumber;
        String PurchaseOrderNumber;
        String CalculatorStatus;
        bool bOccupied = false;

        public POCalculator2(String PONumber, DateTime ReceivingDate, String RECNumber, String Supplier)
        {
            InitializeComponent();
            grid_POCalculator_Init();
            colors();

            txt_PONumber.Text = PONumber;
            dateTimePickerRec.Value = ReceivingDate;
            txt_RECNumber.Text = RECNumber;
            ReceivingNumber = RECNumber;
            PurchaseOrderNumber = PONumber;
            txt_Supplier.Text = Supplier;

            connSalesOrder.sp_GoodsReceiptValueCalculation(grid_POCalculator, PONumber, RECNumber);
          
            total();

            //MessageBox.Show(grid_POCalculator.RowCount.ToString()); //7

            Decimal BCSEDLP = Convert.ToDecimal(grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS EDLP Amount"].Value);
            Decimal SupplierEDLP = Convert.ToDecimal(grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier EDLP Amount"].Value);
            if (BCSEDLP == 0 && SupplierEDLP == 0)
            {
                //hide edlp
                cbo_EDLP.Checked = false;
                grid_POCalculator.Columns[15].Visible = false;
                grid_POCalculator.Columns[16].Visible = false;
                grid_POCalculator.Columns[17].Visible = false;
                grid_POCalculator.Columns[18].Visible = false;
                grid_POCalculator.Columns[19].Visible = false;
                grid_POCalculator.Columns[20].Visible = false;
            }

            Decimal BCSEDLPP = Convert.ToDecimal(grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS EDLPP Amount"].Value);
            Decimal SupplierEDLPP = Convert.ToDecimal(grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier EDLPP Amount"].Value);
            if (BCSEDLPP == 0 && SupplierEDLPP == 0)
            {
                //hide 
                cbo_EDLPP.Checked = false;
                grid_POCalculator.Columns[21].Visible = false;
                grid_POCalculator.Columns[22].Visible = false;
                grid_POCalculator.Columns[23].Visible = false;
                grid_POCalculator.Columns[24].Visible = false;
                grid_POCalculator.Columns[25].Visible = false;
                grid_POCalculator.Columns[26].Visible = false;
            }

            Decimal BCSTermPromo = Convert.ToDecimal(grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS TermPromo Amount"].Value);
            Decimal SupplierTermPromo = Convert.ToDecimal(grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier TermPromo Amount"].Value);
            if (BCSTermPromo == 0 && SupplierTermPromo == 0)
            {
                //hide 
                cbo_TermPromo.Checked = false;
                grid_POCalculator.Columns[27].Visible = false;
                grid_POCalculator.Columns[28].Visible = false;
                grid_POCalculator.Columns[29].Visible = false;
                grid_POCalculator.Columns[30].Visible = false;
                grid_POCalculator.Columns[31].Visible = false;
                grid_POCalculator.Columns[32].Visible = false;
            }

            Decimal BCSTermPromoP = Convert.ToDecimal(grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS TermPromoP Amount"].Value);
            Decimal SupplierTermPromoP = Convert.ToDecimal(grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier TermPromoP Amount"].Value);
            if (BCSTermPromoP == 0 && SupplierTermPromoP == 0)
            {
                //hide 
                cbo_TermPromoP.Checked = false;
                grid_POCalculator.Columns[33].Visible = false;
                grid_POCalculator.Columns[34].Visible = false;
                grid_POCalculator.Columns[35].Visible = false;
                grid_POCalculator.Columns[36].Visible = false;
                grid_POCalculator.Columns[37].Visible = false;
                grid_POCalculator.Columns[38].Visible = false;
            }

            //lock
            CalculatorStatus = connSalesOrder.sp_POCalculator_OCCUPIED_CHECK(RECNumber);
            if (CalculatorStatus == "Occupying")
            {
                for (int i = 0; i < 43; i++)
                {
                    grid_POCalculator.Columns[i].ReadOnly = true;
                }
                MessageBox.Show("Someone is occupying this Calculator. You won't be able to input any values into the columns.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                bOccupied = true;
                return;
            }

        }

        private void grid_POCalculator_Init()
        {
            grid_POCalculator.AutoGenerateColumns = false;
            grid_POCalculator.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grid_POCalculator.ColumnCount = 45;

            grid_POCalculator.Columns[0].Name = "Product ID";
            grid_POCalculator.Columns[0].ReadOnly = true;
            grid_POCalculator.Columns[0].Width = 70;
            grid_POCalculator.Columns[0].MinimumWidth = 70;
            grid_POCalculator.Columns[0].DataPropertyName = "ProductID";

            grid_POCalculator.Columns[1].Name = "Supplier Product ID";
            grid_POCalculator.Columns[1].ReadOnly = true;
            grid_POCalculator.Columns[1].Width = 70;
            grid_POCalculator.Columns[1].Width = 70;
            grid_POCalculator.Columns[1].DataPropertyName = "SupplierProductID";

            grid_POCalculator.Columns[2].Name = "Product Desc";
            grid_POCalculator.Columns[2].ReadOnly = true;
            grid_POCalculator.Columns[2].Width = 300;
            grid_POCalculator.Columns[2].MinimumWidth = 300;
            grid_POCalculator.Columns[2].DataPropertyName = "ProductDesc";

            grid_POCalculator.Columns[3].Name = "Pack Size";
            grid_POCalculator.Columns[3].ReadOnly = true;
            grid_POCalculator.Columns[3].Width = 50;
            grid_POCalculator.Columns[3].MinimumWidth = 50;
            grid_POCalculator.Columns[3].DataPropertyName = "PackSize";

            grid_POCalculator.Columns[4].Name = "Stock Conversion Qty";
            grid_POCalculator.Columns[4].ReadOnly = true;
            grid_POCalculator.Columns[4].Width = 50;
            grid_POCalculator.Columns[4].Width = 50;
            grid_POCalculator.Columns[4].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[4].DataPropertyName = "StockConversionQty";

            grid_POCalculator.Columns[5].Name = "PO Qty";
            grid_POCalculator.Columns[5].ReadOnly = true;
            grid_POCalculator.Columns[5].Width = 60;
            grid_POCalculator.Columns[5].MinimumWidth = 60;
            grid_POCalculator.Columns[5].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[5].DataPropertyName = "OrderQty";

            grid_POCalculator.Columns[6].Name = "REC Qty";
            grid_POCalculator.Columns[6].ReadOnly = true;
            grid_POCalculator.Columns[6].Width = 60;
            grid_POCalculator.Columns[6].MinimumWidth = 60;
            grid_POCalculator.Columns[6].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[6].DataPropertyName = "ReceiptQty";

            grid_POCalculator.Columns[6+1].Name = "Supplier Invoice Qty";
            grid_POCalculator.Columns[6+1].ReadOnly = false;
            grid_POCalculator.Columns[6+1].Width = 60;
            grid_POCalculator.Columns[6+1].MinimumWidth = 60;
            grid_POCalculator.Columns[6+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[6+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[6+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[6+1].DataPropertyName = "SupplierInvoiceQty";

            grid_POCalculator.Columns[7+1].Name = "";
            grid_POCalculator.Columns[7+1].ReadOnly = true;
            grid_POCalculator.Columns[7+1].Width = 10;
            grid_POCalculator.Columns[7+1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_POCalculator.Columns[7+1].DataPropertyName = "blank";
            grid_POCalculator.Columns[8].HeaderCell.Style.BackColor = Color.Black;

            grid_POCalculator.Columns[8+1].Name = "BCS Gross Price";
            grid_POCalculator.Columns[8+1].ReadOnly = true;
            grid_POCalculator.Columns[8+1].Width = 60;
            grid_POCalculator.Columns[8+1].MinimumWidth = 60;
            grid_POCalculator.Columns[8+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[8+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[8+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[8+1].DataPropertyName = "BCSGrossPrice";

            grid_POCalculator.Columns[9+1].Name = "BCS Gross Amount";
            grid_POCalculator.Columns[9+1].ReadOnly = true;
            grid_POCalculator.Columns[9+1].Width = 60;
            grid_POCalculator.Columns[9+1].MinimumWidth = 60;
            grid_POCalculator.Columns[9+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[9+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[9+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[9+1].DataPropertyName = "BCSGrossAmount";

            grid_POCalculator.Columns[10+1].Name = "Supplier Gross Price";
            grid_POCalculator.Columns[10+1].ReadOnly = false;
            grid_POCalculator.Columns[10+1].Width = 60;
            grid_POCalculator.Columns[10+1].MinimumWidth = 60;
            grid_POCalculator.Columns[10+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[10+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[10+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[10+1].DataPropertyName = "SupplierGrossPrice";

            grid_POCalculator.Columns[11+1].Name = "Supplier Gross Amount";
            grid_POCalculator.Columns[11+1].ReadOnly = true;
            grid_POCalculator.Columns[11+1].Width = 60;
            grid_POCalculator.Columns[11+1].MinimumWidth = 60;
            grid_POCalculator.Columns[11+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[11+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[11+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[11+1].DataPropertyName = "SupplierGrossAmount";

            grid_POCalculator.Columns[12+1].Name = "Gross Diff";
            grid_POCalculator.Columns[12+1].ReadOnly = true;
            grid_POCalculator.Columns[12+1].Width = 60;
            grid_POCalculator.Columns[12+1].MinimumWidth = 60;
            grid_POCalculator.Columns[12+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[12+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[12+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[12+1].DataPropertyName = "GrossDiff";

            grid_POCalculator.Columns[13+1].Name = " ";
            grid_POCalculator.Columns[13+1].ReadOnly = true;
            grid_POCalculator.Columns[13+1].Width = 10;
            grid_POCalculator.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_POCalculator.Columns[13+1].DataPropertyName = "blank";
            grid_POCalculator.Columns[14].HeaderCell.Style.BackColor = Color.Black;

            grid_POCalculator.Columns[14+1].Name = "BCS EDLP";
            grid_POCalculator.Columns[14+1].ReadOnly = true;
            grid_POCalculator.Columns[14+1].Width = 60;
            grid_POCalculator.Columns[14+1].MinimumWidth = 60;
            grid_POCalculator.Columns[14+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[14+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[14+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[14+1].DataPropertyName = "BCSEDLP";

            grid_POCalculator.Columns[15+1].Name = "BCS EDLP Amount";
            grid_POCalculator.Columns[15+1].ReadOnly = true;
            grid_POCalculator.Columns[15+1].Width = 60;
            grid_POCalculator.Columns[15+1].MinimumWidth = 60;
            grid_POCalculator.Columns[15+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[15+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[15+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[15+1].DataPropertyName = "BCSEDLPAmount";

            grid_POCalculator.Columns[16+1].Name = "Supplier EDLP";
            grid_POCalculator.Columns[16+1].ReadOnly = false;
            grid_POCalculator.Columns[16+1].Width = 60;
            grid_POCalculator.Columns[16+1].MinimumWidth = 60;
            grid_POCalculator.Columns[16+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[16+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[16+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[16+1].DataPropertyName = "SupplierEDLP";

            grid_POCalculator.Columns[17+1].Name = "Supplier EDLP Amount";
            grid_POCalculator.Columns[17+1].ReadOnly = true;
            grid_POCalculator.Columns[17+1].Width = 60;
            grid_POCalculator.Columns[17+1].MinimumWidth = 60;
            grid_POCalculator.Columns[17+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[17+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[17+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[17+1].DataPropertyName = "SupplierEDLPAmount";

            grid_POCalculator.Columns[18+1].Name = "EDLP Diff";
            grid_POCalculator.Columns[18+1].ReadOnly = true;
            grid_POCalculator.Columns[18+1].Width = 60;
            grid_POCalculator.Columns[18+1].MinimumWidth = 60;
            grid_POCalculator.Columns[18+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[18+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[18+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[18+1].DataPropertyName = "EDLPDiff";

            grid_POCalculator.Columns[19+1].Name = "  ";
            grid_POCalculator.Columns[19+1].ReadOnly = false;
            grid_POCalculator.Columns[19+1].Width = 10;
            grid_POCalculator.Columns[20].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_POCalculator.Columns[19+1].DataPropertyName = "blank";
            grid_POCalculator.Columns[20].HeaderCell.Style.BackColor = Color.Black;

            grid_POCalculator.Columns[20+1].Name = "BCS EDLPP";
            grid_POCalculator.Columns[20+1].ReadOnly = true;
            grid_POCalculator.Columns[20+1].Width = 60;
            grid_POCalculator.Columns[20+1].MinimumWidth = 60;
            grid_POCalculator.Columns[20+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[20+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[20+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[20+1].DataPropertyName = "BCSEDLPP";

            grid_POCalculator.Columns[21+1].Name = "BCS EDLPP Amount";
            grid_POCalculator.Columns[21+1].ReadOnly = true;
            grid_POCalculator.Columns[21+1].Width = 60;
            grid_POCalculator.Columns[21+1].MinimumWidth = 60;
            grid_POCalculator.Columns[21+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[21+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[21+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[21+1].DataPropertyName = "BCSEDLPPAmount";

            grid_POCalculator.Columns[22+1].Name = "Supplier EDLPP";
            grid_POCalculator.Columns[22+1].ReadOnly = false;
            grid_POCalculator.Columns[22+1].Width = 60;
            grid_POCalculator.Columns[22+1].MinimumWidth = 60;
            grid_POCalculator.Columns[22+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[22+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[22+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[22+1].DataPropertyName = "SupplierEDLPP";

            grid_POCalculator.Columns[23+1].Name = "Supplier EDLPP Amount";
            grid_POCalculator.Columns[23+1].ReadOnly = true;
            grid_POCalculator.Columns[23+1].Width = 60;
            grid_POCalculator.Columns[23+1].MinimumWidth = 60;
            grid_POCalculator.Columns[23+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[23+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[23+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[23+1].DataPropertyName = "SupplierEDLPPAmount";

            grid_POCalculator.Columns[24+1].Name = "EDLPP Diff";
            grid_POCalculator.Columns[24+1].ReadOnly = true;
            grid_POCalculator.Columns[24+1].Width = 60;
            grid_POCalculator.Columns[24+1].MinimumWidth = 60;
            grid_POCalculator.Columns[24+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[24+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[24+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[24+1].DataPropertyName = "EDLPPDiff";

            grid_POCalculator.Columns[25+1].Name = "   ";
            grid_POCalculator.Columns[25+1].ReadOnly = true;
            grid_POCalculator.Columns[25+1].Width = 10;
            grid_POCalculator.Columns[26].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_POCalculator.Columns[25+1].DataPropertyName = "blank";
            grid_POCalculator.Columns[26].HeaderCell.Style.BackColor = Color.Black;

            grid_POCalculator.Columns[26+1].Name = "BCS TermPromo";
            grid_POCalculator.Columns[26+1].ReadOnly = true;
            grid_POCalculator.Columns[26+1].Width = 60;
            grid_POCalculator.Columns[26+1].MinimumWidth = 60;
            grid_POCalculator.Columns[26+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[26+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[26+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[26+1].DataPropertyName = "BCSTermPromo";

            grid_POCalculator.Columns[27+1].Name = "BCS TermPromo Amount";
            grid_POCalculator.Columns[27+1].ReadOnly = true;
            grid_POCalculator.Columns[27+1].Width = 60;
            grid_POCalculator.Columns[27+1].MinimumWidth = 60;
            grid_POCalculator.Columns[27+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[27+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[27+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[27+1].DataPropertyName = "BCSTermPromoAmount";

            grid_POCalculator.Columns[28+1].Name = "Supplier TermPromo";
            grid_POCalculator.Columns[28+1].ReadOnly = false;
            grid_POCalculator.Columns[28+1].Width = 60;
            grid_POCalculator.Columns[28+1].MinimumWidth = 60;
            grid_POCalculator.Columns[28+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[28+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[28+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[28+1].DataPropertyName = "SupplierTermPromo";

            grid_POCalculator.Columns[29+1].Name = "Supplier TermPromo Amount";
            grid_POCalculator.Columns[29+1].ReadOnly = true;
            grid_POCalculator.Columns[29+1].Width = 60;
            grid_POCalculator.Columns[29+1].MinimumWidth = 60;
            grid_POCalculator.Columns[29+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[29+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[29+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[29+1].DataPropertyName = "SupplierTermPromoAmount";

            grid_POCalculator.Columns[30+1].Name = "TermPromo Diff";
            grid_POCalculator.Columns[30+1].ReadOnly = true;
            grid_POCalculator.Columns[30+1].Width = 60;
            grid_POCalculator.Columns[30+1].MinimumWidth = 60;
            grid_POCalculator.Columns[30+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[30+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[30+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[30+1].DataPropertyName = "TermPromoDiff";

            grid_POCalculator.Columns[31+1].Name = "    ";
            grid_POCalculator.Columns[31+1].ReadOnly = true;
            grid_POCalculator.Columns[31+1].Width = 10;
            grid_POCalculator.Columns[32].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_POCalculator.Columns[31+1].DataPropertyName = "blank";
            grid_POCalculator.Columns[32].HeaderCell.Style.BackColor = Color.Black;

            grid_POCalculator.Columns[32+1].Name = "BCS TermPromoP";
            grid_POCalculator.Columns[32+1].ReadOnly = true;
            grid_POCalculator.Columns[32+1].Width = 60;
            grid_POCalculator.Columns[32+1].MinimumWidth = 60;
            grid_POCalculator.Columns[32+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[32+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[32+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[32+1].DataPropertyName = "BCSTermPromoP";

            grid_POCalculator.Columns[33+1].Name = "BCS TermPromoP Amount";
            grid_POCalculator.Columns[33+1].ReadOnly = true;
            grid_POCalculator.Columns[33+1].Width = 60;
            grid_POCalculator.Columns[33+1].MinimumWidth = 60;
            grid_POCalculator.Columns[33+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[33+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[33+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[33+1].DataPropertyName = "BCSTermPromoPAmount";

            grid_POCalculator.Columns[34+1].Name = "Supplier TermPromoP";
            grid_POCalculator.Columns[34+1].ReadOnly = false;
            grid_POCalculator.Columns[34+1].Width = 60;
            grid_POCalculator.Columns[34+1].MinimumWidth = 60;
            grid_POCalculator.Columns[34+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[34+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[34+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[34+1].DataPropertyName = "SupplierTermPromoP";

            grid_POCalculator.Columns[35+1].Name = "Supplier TermPromoP Amount";
            grid_POCalculator.Columns[35+1].ReadOnly = true;
            grid_POCalculator.Columns[35+1].Width = 60;
            grid_POCalculator.Columns[35+1].MinimumWidth = 60;
            grid_POCalculator.Columns[35+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[35+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[35+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[35+1].DataPropertyName = "SupplierTermPromoPAmount";

            grid_POCalculator.Columns[36+1].Name = "TermPromoP Diff";
            grid_POCalculator.Columns[36+1].ReadOnly = true;
            grid_POCalculator.Columns[36+1].Width = 60;
            grid_POCalculator.Columns[36+1].MinimumWidth = 60;
            grid_POCalculator.Columns[36+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[36+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[36+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[36+1].DataPropertyName = "TermPromoPDiff";

            grid_POCalculator.Columns[37+1].Name = "     ";
            grid_POCalculator.Columns[37+1].ReadOnly = true;
            grid_POCalculator.Columns[37+1].Width = 10;
            grid_POCalculator.Columns[38].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_POCalculator.Columns[37+1].DataPropertyName = "blank";
            grid_POCalculator.Columns[38].HeaderCell.Style.BackColor = Color.Black;

            grid_POCalculator.Columns[38+1].Name = "BCS Net Price";
            grid_POCalculator.Columns[38+1].ReadOnly = true;
            grid_POCalculator.Columns[38+1].Width = 60;
            grid_POCalculator.Columns[38+1].MinimumWidth = 60;
            grid_POCalculator.Columns[38+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[38+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[38+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[38+1].DataPropertyName = "BCSNetPrice";

            grid_POCalculator.Columns[39+1].Name = "BCS Net Amount";
            grid_POCalculator.Columns[39+1].ReadOnly = true;
            grid_POCalculator.Columns[39+1].Width = 60;
            grid_POCalculator.Columns[39+1].MinimumWidth = 60;
            grid_POCalculator.Columns[39+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[39+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[39+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[39+1].DataPropertyName = "BCSNetAmount";

            grid_POCalculator.Columns[40+1].Name = "Supplier Net Price";
            grid_POCalculator.Columns[40+1].ReadOnly = true;
            grid_POCalculator.Columns[40+1].Width = 60;
            grid_POCalculator.Columns[40+1].MinimumWidth = 60;
            grid_POCalculator.Columns[40+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[40+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[40+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[40+1].DataPropertyName = "SupplierNetPrice";

            grid_POCalculator.Columns[41+1].Name = "Supplier Net Amount";
            grid_POCalculator.Columns[41+1].ReadOnly = true;
            grid_POCalculator.Columns[41+1].Width = 60;
            grid_POCalculator.Columns[41+1].MinimumWidth = 60;
            grid_POCalculator.Columns[41+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[41+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[41+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[41+1].DataPropertyName = "SupplierNetAmount";

            grid_POCalculator.Columns[42+1].Name = "Net Diff";
            grid_POCalculator.Columns[42+1].ReadOnly = true;
            grid_POCalculator.Columns[42+1].Width = 60;
            grid_POCalculator.Columns[42+1].MinimumWidth = 60;
            grid_POCalculator.Columns[42+1].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[42+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[42+1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[42+1].DataPropertyName = "NetDiff";

            grid_POCalculator.Columns[44].Name = "POPLIN_0";
            grid_POCalculator.Columns[44].Visible = false;
            grid_POCalculator.Columns[44].DataPropertyName = "POPLIN_0";

            //grid font size custom
            grid_POCalculator.RowTemplate.Height = 20;
            grid_POCalculator.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_POCalculator.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            grid_POCalculator.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_POCalculator_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == grid_POCalculator.RowCount-1)
            {
                return;
            }
            Decimal POQty = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["PO Qty"].Value);
            Decimal RECQty = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["REC Qty"].Value);
            Decimal SupplierInvoiceQty = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Supplier Invoice Qty"].Value);

            Decimal BCSGrossPrice = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["BCS Gross Price"].Value);
            Decimal BCSGrossAmount = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["BCS Gross Amount"].Value);
            Decimal SupplierGrossPrice = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Supplier Gross Price"].Value);
            Decimal SupplierGrossAmount = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Supplier Gross Amount"].Value);
            Decimal GrossDiff = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Gross Diff"].Value);

            Decimal BCSEDLP = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["BCS EDLP"].Value);
            Decimal BCSEDLPAmount = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["BCS EDLP Amount"].Value);
            Decimal SupplierEDLP = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Supplier EDLP"].Value);
            Decimal SupplierEDLPAmount = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Supplier EDLP Amount"].Value);
            Decimal EDLPDiff = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["EDLP Diff"].Value);

            Decimal BCSEDLPP = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["BCS EDLPP"].Value);
            Decimal BCSEDLPPAmount = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["BCS EDLPP Amount"].Value);
            Decimal SupplierEDLPP = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Supplier EDLPP"].Value);
            Decimal SupplierEDLPPAmount = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Supplier EDLPP Amount"].Value);
            Decimal EDLPPDiff = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["EDLPP Diff"].Value);

            Decimal BCSTermPromo = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["BCS TermPromo"].Value);
            Decimal BCSTermPromoAmount = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["BCS TermPromo Amount"].Value);
            Decimal SupplierTermPromo = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Supplier TermPromo"].Value);
            Decimal SupplierTermPromoAmount = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Supplier TermPromo Amount"].Value);
            Decimal TermPromoDiff = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["TermPromo Diff"].Value);

            Decimal BCSTermPromoP = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["BCS TermPromoP"].Value);
            Decimal BCSTermPromoPAmount = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["BCS TermPromoP Amount"].Value);
            Decimal SupplierTermPromoP = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Supplier TermPromoP"].Value);
            Decimal SupplierTermPromoPAmount = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Supplier TermPromoP Amount"].Value);
            Decimal TermPromoPDiff = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["TermPromoP Diff"].Value);

            Decimal BCSNetPrice = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["BCS Net Price"].Value);
            Decimal BCSNetAmount = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["BCS Net Amount"].Value);
            Decimal SupplierNetPrice = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Supplier Net Price"].Value);
            Decimal SupplierNetAmount = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Supplier Net Amount"].Value);
            Decimal NetDiff = Convert.ToDecimal(grid_POCalculator.Rows[e.RowIndex].Cells["Net Diff"].Value);

            grid_POCalculator.Rows[e.RowIndex].Cells["BCS Gross Amount"].Value = BCSGrossPrice * RECQty;
            grid_POCalculator.Rows[e.RowIndex].Cells["Supplier Gross Amount"].Value = SupplierGrossPrice * SupplierInvoiceQty;
            grid_POCalculator.Rows[e.RowIndex].Cells["Gross Diff"].Value = (BCSGrossPrice * RECQty) - (SupplierGrossPrice * SupplierInvoiceQty);

            grid_POCalculator.Rows[e.RowIndex].Cells["BCS EDLP Amount"].Value = BCSEDLP * RECQty;
            grid_POCalculator.Rows[e.RowIndex].Cells["Supplier EDLP Amount"].Value = SupplierEDLP * SupplierInvoiceQty;
            grid_POCalculator.Rows[e.RowIndex].Cells["EDLP Diff"].Value = (BCSEDLP * RECQty) - (SupplierEDLP * SupplierInvoiceQty);

            grid_POCalculator.Rows[e.RowIndex].Cells["BCS EDLPP Amount"].Value = Math.Round((BCSGrossPrice * BCSEDLPP / 100), 2) * RECQty;
            grid_POCalculator.Rows[e.RowIndex].Cells["Supplier EDLPP Amount"].Value = Math.Round((SupplierGrossPrice * SupplierEDLPP / 100), 2) * SupplierInvoiceQty;
            grid_POCalculator.Rows[e.RowIndex].Cells["EDLPP Diff"].Value = (Math.Round((BCSGrossPrice * BCSEDLPP / 100), 2) * RECQty) - (Math.Round((SupplierGrossPrice * SupplierEDLPP / 100), 2) * SupplierInvoiceQty);

            grid_POCalculator.Rows[e.RowIndex].Cells["BCS TermPromo Amount"].Value = BCSTermPromo * RECQty;
            grid_POCalculator.Rows[e.RowIndex].Cells["Supplier TermPromo Amount"].Value = SupplierTermPromo * SupplierInvoiceQty;
            grid_POCalculator.Rows[e.RowIndex].Cells["TermPromo Diff"].Value = (BCSTermPromo * RECQty) - (SupplierTermPromo * SupplierInvoiceQty);

            grid_POCalculator.Rows[e.RowIndex].Cells["BCS TermPromoP Amount"].Value = Math.Round((BCSGrossPrice * BCSTermPromoP / 100), 2) * RECQty;
            grid_POCalculator.Rows[e.RowIndex].Cells["Supplier TermPromoP Amount"].Value = Math.Round((SupplierGrossPrice * SupplierTermPromoP / 100), 2) * SupplierInvoiceQty;
            grid_POCalculator.Rows[e.RowIndex].Cells["TermPromoP Diff"].Value = (Math.Round((BCSGrossPrice * BCSTermPromoP / 100), 2) * RECQty) - (Math.Round((SupplierGrossPrice * SupplierTermPromoP / 100), 2) * SupplierInvoiceQty);

            grid_POCalculator.Rows[e.RowIndex].Cells["BCS Net Price"].Value = BCSGrossPrice - BCSEDLP - Math.Round((BCSGrossPrice * BCSEDLPP / 100), 2) - BCSTermPromo - Math.Round((BCSGrossPrice * BCSTermPromoP / 100), 2);
            grid_POCalculator.Rows[e.RowIndex].Cells["BCS Net Amount"].Value = (BCSGrossPrice - BCSEDLP - Math.Round((BCSGrossPrice * BCSEDLPP / 100), 2) - BCSTermPromo - Math.Round((BCSGrossPrice * BCSTermPromoP / 100), 2)) * RECQty;
            grid_POCalculator.Rows[e.RowIndex].Cells["Supplier Net Price"].Value = SupplierGrossPrice - SupplierEDLP - Math.Round((SupplierGrossPrice * SupplierEDLPP / 100), 2) - SupplierTermPromo - Math.Round((SupplierGrossPrice * SupplierTermPromoP / 100), 2);
            grid_POCalculator.Rows[e.RowIndex].Cells["Supplier Net Amount"].Value = (SupplierGrossPrice - SupplierEDLP - Math.Round((SupplierGrossPrice * SupplierEDLPP / 100), 2) - SupplierTermPromo - Math.Round((SupplierGrossPrice * SupplierTermPromoP / 100), 2)) * SupplierInvoiceQty;
            grid_POCalculator.Rows[e.RowIndex].Cells["Net Diff"].Value = ((BCSGrossPrice - BCSEDLP - Math.Round((BCSGrossPrice * BCSEDLPP / 100), 2) - BCSTermPromo - Math.Round((BCSGrossPrice * BCSTermPromoP / 100), 2)) * RECQty) - ((SupplierGrossPrice - SupplierEDLP - Math.Round((SupplierGrossPrice * SupplierEDLPP / 100), 2) - SupplierTermPromo - Math.Round((SupplierGrossPrice * SupplierTermPromoP / 100), 2)) * SupplierInvoiceQty);

            //update total
            Decimal TotalRECQty = 0, TotalSupplierInvoiceQty = 0;
            Decimal TotalBCSGrossAmount = 0, TotalSupplierGrossAmount = 0, TotalGrossDiff = 0;
            Decimal TotalBCSEDLPAmount = 0, TotalSupplierEDLPAmount = 0, TotalEDLPDiff = 0;
            Decimal TotalBCSEDLPPAmount = 0, TotalSupplierEDLPPAmount = 0, TotalEDLPPDiff = 0;
            Decimal TotalBCSTermPromoAmount = 0, TotalSupplierTermPromoAmount = 0, TotalTermPromoDiff = 0;
            Decimal TotalBCSTermPromoPAmount = 0, TotalSupplierTermPromoPAmount = 0, TotalTermPromoPDiff = 0;
            Decimal TotalBCSNetAmount = 0, TotalSupplierNetAmount = 0, TotalNetDiff = 0;

            for (int i = 0; i < grid_POCalculator.RowCount-1; i++)
            {
                TotalRECQty += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["REC Qty"].Value);
                TotalSupplierInvoiceQty += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Supplier Invoice Qty"].Value);

                TotalBCSGrossAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["BCS Gross Amount"].Value);
                TotalSupplierGrossAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Supplier Gross Amount"].Value);
                TotalGrossDiff += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Gross Diff"].Value);

                TotalBCSEDLPAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["BCS EDLP Amount"].Value);
                TotalSupplierEDLPAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Supplier EDLP Amount"].Value);
                TotalEDLPDiff += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["EDLP Diff"].Value);

                TotalBCSEDLPPAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["BCS EDLPP Amount"].Value);
                TotalSupplierEDLPPAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Supplier EDLPP Amount"].Value);
                TotalEDLPPDiff += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["EDLPP Diff"].Value);

                TotalBCSTermPromoAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["BCS TermPromo Amount"].Value);
                TotalSupplierTermPromoAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Supplier TermPromo Amount"].Value);
                TotalTermPromoDiff += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["TermPromo Diff"].Value);

                TotalBCSTermPromoPAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["BCS TermPromoP Amount"].Value);
                TotalSupplierTermPromoPAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Supplier TermPromoP Amount"].Value);
                TotalTermPromoPDiff += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["TermPromoP Diff"].Value);

                TotalBCSNetAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["BCS Net Amount"].Value);
                TotalSupplierNetAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Supplier Net Amount"].Value);
                TotalNetDiff += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Net Diff"].Value);
            }
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["REC Qty"].Value = TotalRECQty;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier Invoice Qty"].Value = TotalSupplierInvoiceQty;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS Gross Amount"].Value = TotalBCSGrossAmount;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier Gross Amount"].Value = TotalSupplierGrossAmount;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Gross Diff"].Value = TotalGrossDiff;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS EDLP Amount"].Value = TotalBCSEDLPAmount;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier EDLP Amount"].Value = TotalSupplierEDLPAmount;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["EDLP Diff"].Value = TotalEDLPDiff;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS EDLPP Amount"].Value = TotalBCSEDLPPAmount;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier EDLPP Amount"].Value = TotalSupplierEDLPPAmount;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["EDLPP Diff"].Value = TotalEDLPPDiff;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS TermPromo Amount"].Value = TotalBCSTermPromoAmount;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier TermPromo Amount"].Value = TotalSupplierTermPromoAmount;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["TermPromo Diff"].Value = TotalTermPromoDiff;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS TermPromoP Amount"].Value = TotalBCSTermPromoPAmount;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier TermPromoP Amount"].Value = TotalSupplierTermPromoPAmount;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["TermPromoP Diff"].Value = TotalTermPromoPDiff;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS Net Amount"].Value = TotalBCSNetAmount;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier Net Amount"].Value = TotalSupplierNetAmount;
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Net Diff"].Value = TotalNetDiff;
        }

        private void cbo_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            int i = 0;
            bool CheckedFlag = false;
            switch (cb.Name)
            {
                case "cbo_EDLP":
                    i = 15;
                    break;
                case "cbo_EDLPP":
                    i = 21;
                    break;
                case "cbo_TermPromo":
                    i = 27;
                    break;
                case "cbo_TermPromoP":
                    i = 33;
                    break;
            }
            if (cb.Checked) CheckedFlag = true;

            for (int n = i; n < i + 6; n++)
            {
                grid_POCalculator.Columns[n].Visible = CheckedFlag;
            }
        }
        private void total()
        {
            Decimal TotalRECQty = 0, TotalSupplierInvoiceQty = 0;
            Decimal TotalBCSGrossAmount = 0, TotalSupplierGrossAmount = 0, TotalGrossDiff = 0;
            Decimal TotalBCSEDLPAmount = 0, TotalSupplierEDLPAmount = 0, TotalEDLPDiff = 0;
            Decimal TotalBCSEDLPPAmount = 0, TotalSupplierEDLPPAmount = 0, TotalEDLPPDiff = 0;
            Decimal TotalBCSTermPromoAmount = 0, TotalSupplierTermPromoAmount = 0, TotalTermPromoDiff = 0;
            Decimal TotalBCSTermPromoPAmount = 0, TotalSupplierTermPromoPAmount = 0, TotalTermPromoPDiff = 0;
            Decimal TotalBCSNetAmount = 0, TotalSupplierNetAmount = 0, TotalNetDiff = 0;

            foreach (DataGridViewRow row in this.grid_POCalculator.Rows)
            {
                TotalRECQty += Convert.ToDecimal(row.Cells["REC Qty"].Value);
                TotalSupplierInvoiceQty += Convert.ToDecimal(row.Cells["Supplier Invoice Qty"].Value);

                TotalBCSGrossAmount += Convert.ToDecimal(row.Cells["BCS Gross Amount"].Value);
                TotalSupplierGrossAmount += Convert.ToDecimal(row.Cells["Supplier Gross Amount"].Value);
                TotalGrossDiff += Convert.ToDecimal(row.Cells["Gross Diff"].Value);

                TotalBCSEDLPAmount += Convert.ToDecimal(row.Cells["BCS EDLP Amount"].Value);
                TotalSupplierEDLPAmount += Convert.ToDecimal(row.Cells["Supplier EDLP Amount"].Value);
                TotalEDLPDiff += Convert.ToDecimal(row.Cells["EDLP Diff"].Value);

                TotalBCSEDLPPAmount += Convert.ToDecimal(row.Cells["BCS EDLPP Amount"].Value);
                TotalSupplierEDLPPAmount += Convert.ToDecimal(row.Cells["Supplier EDLPP Amount"].Value);
                TotalEDLPPDiff += Convert.ToDecimal(row.Cells["EDLPP Diff"].Value);

                TotalBCSTermPromoAmount += Convert.ToDecimal(row.Cells["BCS TermPromo Amount"].Value);
                TotalSupplierTermPromoAmount += Convert.ToDecimal(row.Cells["Supplier TermPromo Amount"].Value);
                TotalTermPromoDiff += Convert.ToDecimal(row.Cells["TermPromo Diff"].Value);

                TotalBCSTermPromoPAmount += Convert.ToDecimal(row.Cells["BCS TermPromoP Amount"].Value);
                TotalSupplierTermPromoPAmount += Convert.ToDecimal(row.Cells["Supplier TermPromoP Amount"].Value);
                TotalTermPromoPDiff += Convert.ToDecimal(row.Cells["TermPromoP Diff"].Value);

                TotalBCSNetAmount += Convert.ToDecimal(row.Cells["BCS Net Amount"].Value);
                TotalSupplierNetAmount += Convert.ToDecimal(row.Cells["Supplier Net Amount"].Value);
                TotalNetDiff += Convert.ToDecimal(row.Cells["Net Diff"].Value);
            }
            DataTable dt = this.grid_POCalculator.DataSource as DataTable;
            DataRow dr = dt.NewRow();

            dr["ProductID"] = "Total";

            dr["ReceiptQty"] = TotalRECQty;
            dr["SupplierInvoiceQty"] = TotalSupplierInvoiceQty;

            dr["BCSGrossAmount"] = TotalBCSGrossAmount;
            dr["SupplierGrossAmount"] = TotalSupplierGrossAmount;
            dr["GrossDiff"] = TotalGrossDiff;

            dr["BCSEDLPAmount"] = TotalBCSEDLPAmount;
            dr["SupplierEDLPAmount"] = TotalSupplierEDLPAmount;
            dr["EDLPDiff"] = TotalEDLPDiff;

            dr["BCSEDLPPAmount"] = TotalBCSEDLPPAmount;
            dr["SupplierEDLPPAmount"] = TotalSupplierEDLPPAmount;
            dr["EDLPPDiff"] = TotalEDLPPDiff;

            dr["BCSTermPromoAmount"] = TotalBCSTermPromoAmount;
            dr["SupplierTermPromoAmount"] = TotalSupplierTermPromoAmount;
            dr["TermPromoDiff"] = TotalTermPromoDiff;

            dr["BCSTermPromoPAmount"] = TotalBCSTermPromoPAmount;
            dr["SupplierTermPromoPAmount"] = TotalSupplierTermPromoPAmount;
            dr["TermPromoPDiff"] = TotalTermPromoPDiff;

            dr["BCSNetAmount"] = TotalBCSNetAmount;
            dr["SupplierNetAmount"] = TotalSupplierNetAmount;
            dr["NetDiff"] = TotalNetDiff;

            dt.Rows.Add(dr);
        }

        private void POCalculator2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (bOccupied == false)
            {
                connSalesOrder.sp_POCalculator_OCCUPIED_RELEASE(ReceivingNumber);

                try
                {
                    foreach (DataGridViewRow row in this.grid_POCalculator.Rows)
                    {
                        if (row.Cells["Product ID"].Value.Equals("Total") || row.Cells["poplin_0"].Value == null)
                            return;

                        Decimal poplin_0 = Convert.ToDecimal(row.Cells["POPLIN_0"].Value.ToString());
                        Decimal SupplierInvoiceQty = Convert.ToDecimal(row.Cells["Supplier Invoice Qty"].Value);

                        //Decimal BCSGrossPrice = Convert.ToDecimal(row.Cells["BCS Gross Price"].Value);
                        Decimal SupplierGrossPrice = Convert.ToDecimal(row.Cells["Supplier Gross Price"].Value);

                        //Decimal BCSEDLP = Convert.ToDecimal(row.Cells["BCS EDLP"].Value);
                        Decimal SupplierEDLP = Convert.ToDecimal(row.Cells["Supplier EDLP"].Value);

                        //Decimal BCSEDLPP = Convert.ToDecimal(row.Cells["BCS EDLPP"].Value);
                        Decimal SupplierEDLPP = Convert.ToDecimal(row.Cells["Supplier EDLPP"].Value);

                        //Decimal BCSTermPromo = Convert.ToDecimal(row.Cells["BCS TermPromo"].Value);
                        Decimal SupplierTermPromo = Convert.ToDecimal(row.Cells["Supplier TermPromo"].Value);

                        //Decimal BCSTermPromoP = Convert.ToDecimal(row.Cells["BCS TermPromoP"].Value);
                        Decimal SupplierTermPromoP = Convert.ToDecimal(row.Cells["Supplier TermPromoP"].Value);

                        connPO.sp_UPDATE_PRECEIPTD_POCALC(SupplierInvoiceQty, SupplierGrossPrice, SupplierEDLP, SupplierEDLPP, SupplierTermPromo, SupplierTermPromoP, poplin_0, txt_PONumber.Text.Trim());
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void colors()
        {
            foreach (DataGridViewRow row in this.grid_POCalculator.Rows)
            {
                row.Cells["Supplier Invoice Qty"].Style.BackColor = Color.OldLace;
                row.Cells["BCS Gross Price"].Style.BackColor = Color.OldLace;
                row.Cells["Supplier Gross Price"].Style.BackColor = Color.OldLace;
                row.Cells["BCS EDLP"].Style.BackColor = Color.OldLace;
                row.Cells["Supplier EDLP"].Style.BackColor = Color.OldLace;
                row.Cells["BCS EDLPP"].Style.BackColor = Color.OldLace;
                row.Cells["Supplier EDLPP"].Style.BackColor = Color.OldLace;
                row.Cells["BCS TermPromo"].Style.BackColor = Color.OldLace;
                row.Cells["Supplier TermPromo"].Style.BackColor = Color.OldLace;
                row.Cells["BCS TermPromoP"].Style.BackColor = Color.OldLace;
                row.Cells["Supplier TermPromoP"].Style.BackColor = Color.OldLace;

                row.Cells[""].Style.BackColor = Color.Black;
                row.Cells[""].Style.SelectionBackColor = Color.Black;
                row.Cells[" "].Style.BackColor = Color.Black;
                row.Cells[" "].Style.SelectionBackColor = Color.Black;
                row.Cells["  "].Style.BackColor = Color.Black;
                row.Cells["  "].Style.SelectionBackColor = Color.Black;
                row.Cells["   "].Style.BackColor = Color.Black;
                row.Cells["   "].Style.SelectionBackColor = Color.Black;
                row.Cells["    "].Style.BackColor = Color.Black;
                row.Cells["    "].Style.SelectionBackColor = Color.Black;
                row.Cells["     "].Style.BackColor = Color.Black;
                row.Cells["     "].Style.SelectionBackColor = Color.Black;
            }
        }

        private void grid_POCalculator_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            colors();

            foreach (DataGridViewRow row in this.grid_POCalculator.Rows)
            {
                if (row.Cells["Product ID"].Value.Equals("Total"))
                {
                    for (int i = 0; i < grid_POCalculator.ColumnCount; i++)
                    {
                        row.Cells[i].Style.BackColor = Color.Gray;
                        row.Cells[i].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void btn_calculator_Click(object sender, EventArgs e)
        {
            Reports.Rpt_POCalculator2 poCalculator2 = new Reports.Rpt_POCalculator2(PurchaseOrderNumber, ReceivingNumber);
            poCalculator2.Show();
        }
    }


}
