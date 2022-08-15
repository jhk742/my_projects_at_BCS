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
    public partial class POCaculator : Form
    {
        bool NewFlag = false;
        int StaticRowCount;
        String ReceivingNumber;
        String CalculatorStatus;
        bool bOccupied = false;

        public POCaculator(String PONumber, DateTime ReceivingDate, String RECNumber, String Supplier)
        {
            InitializeComponent();
            grid_POCalculator_Init();
            ReceivingNumber = RECNumber;

            txt_PONumber.Text = PONumber;
            dateTimePickerRec.Value = ReceivingDate;
            txt_RECNumber.Text = RECNumber;
            txt_Supplier.Text = Supplier;

            connSalesOrder.sp_PO_COST_CALCULATION(grid_POCalculator, PONumber);
            
            cbo_ProductID.Items.Clear();
            connSalesOrder.cbo_ITEMBYSUPPLIER(cbo_ProductID, Supplier);
            StaticRowCount = grid_POCalculator.RowCount;

            CalculatorStatus = connSalesOrder.sp_POCalculator_OCCUPIED_CHECK(RECNumber);
            if (CalculatorStatus == "Occupying")
            {
                for (int i = 0; i < 43; i++)
                {
                    grid_POCalculator.Columns[i].ReadOnly = true;
                }
                btn_Add.Enabled = false;
                MessageBox.Show("Someone occupying this Calculator.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                bOccupied = true;
                return;
            }
        }
        private void grid_POCalculator_Init()
        {
            grid_POCalculator.AutoGenerateColumns = false;
            grid_POCalculator.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grid_POCalculator.ColumnCount = 44;

            grid_POCalculator.Columns[0].Name = "PONumber";
            grid_POCalculator.Columns[0].ReadOnly = true;
            grid_POCalculator.Columns[0].Width = 25;
            grid_POCalculator.Columns[0].Visible = false;
            grid_POCalculator.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[0].DataPropertyName = "PONumber";

            grid_POCalculator.Columns[1].Name = "RECNumber";
            grid_POCalculator.Columns[1].ReadOnly = true;
            grid_POCalculator.Columns[1].Width = 25;
            grid_POCalculator.Columns[1].Visible = false;
            grid_POCalculator.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[1].DataPropertyName = "RECNumber";

            grid_POCalculator.Columns[2].Name = "Supplier";
            grid_POCalculator.Columns[2].ReadOnly = true;
            grid_POCalculator.Columns[2].Width = 60;
            grid_POCalculator.Columns[2].Visible = false;
            grid_POCalculator.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[2].DataPropertyName = "Supplier";

            grid_POCalculator.Columns[3].Name = "RECDATE";
            grid_POCalculator.Columns[3].ReadOnly = true;
            grid_POCalculator.Columns[3].Width = 50;
            grid_POCalculator.Columns[3].Visible = false;
            grid_POCalculator.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_POCalculator.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[3].DataPropertyName = "RECDATE";

            grid_POCalculator.Columns[4].Name = "BCS ItemID";
            grid_POCalculator.Columns[4].ReadOnly = true;
            grid_POCalculator.Columns[4].Width = 40;
            grid_POCalculator.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[4].DataPropertyName = "BCSItemID";

            grid_POCalculator.Columns[5].Name = "Supplier ItemID";
            grid_POCalculator.Columns[5].ReadOnly = true;
            grid_POCalculator.Columns[5].Width = 40;
            grid_POCalculator.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[5].DataPropertyName = "SupplierItemID";

            grid_POCalculator.Columns[6].Name = "Description";
            grid_POCalculator.Columns[6].ReadOnly = true;
            grid_POCalculator.Columns[6].Width = 200;
            grid_POCalculator.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[6].DataPropertyName = "Description";

            grid_POCalculator.Columns[7].Name = "PackSize";
            grid_POCalculator.Columns[7].ReadOnly = true;
            grid_POCalculator.Columns[7].Width = 50;
            grid_POCalculator.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[7].DataPropertyName = "PackSize";

            grid_POCalculator.Columns[8].Name = "UOM";
            grid_POCalculator.Columns[8].ReadOnly = true;
            grid_POCalculator.Columns[8].Width = 20;
            grid_POCalculator.Columns[8].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[8].DataPropertyName = "UOM";

            grid_POCalculator.Columns[9].Name = "CONV";
            grid_POCalculator.Columns[9].ReadOnly = true;
            grid_POCalculator.Columns[9].Width = 20;
            grid_POCalculator.Columns[9].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[9].DataPropertyName = "CONV";

            grid_POCalculator.Columns[10].Name = "BCS Price";
            grid_POCalculator.Columns[10].ReadOnly = false;
            grid_POCalculator.Columns[10].Width = 35;
            grid_POCalculator.Columns[10].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[10].DataPropertyName = "Price";

            grid_POCalculator.Columns[11].Name = "BCS Qty";
            grid_POCalculator.Columns[11].ReadOnly = false;
            grid_POCalculator.Columns[11].Width = 35;
            grid_POCalculator.Columns[11].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[11].DataPropertyName = "Qty";

            grid_POCalculator.Columns[12].Name = "BCS Amount";
            grid_POCalculator.Columns[12].ReadOnly = true;
            grid_POCalculator.Columns[12].Width = 45;
            grid_POCalculator.Columns[12].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[12].DataPropertyName = "Amount";

            grid_POCalculator.Columns[13].Name = "Supplier Price";
            grid_POCalculator.Columns[13].ReadOnly = false;
            grid_POCalculator.Columns[13].Width = 35;
            grid_POCalculator.Columns[13].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[13].DataPropertyName = "SupplierPrice";

            grid_POCalculator.Columns[14].Name = "Supplier Qty";
            grid_POCalculator.Columns[14].ReadOnly = false;
            grid_POCalculator.Columns[14].Width = 35;
            grid_POCalculator.Columns[14].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[14].DataPropertyName = "SupplierQty";

            grid_POCalculator.Columns[15].Name = "Supplier Amount";
            grid_POCalculator.Columns[15].ReadOnly = true;
            grid_POCalculator.Columns[15].Width = 45;
            grid_POCalculator.Columns[15].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            grid_POCalculator.Columns[16].Name = "Amount DIFF";
            grid_POCalculator.Columns[16].ReadOnly = true;
            grid_POCalculator.Columns[16].Width = 45;
            grid_POCalculator.Columns[16].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[17].Name = "BCS EDLP";
            grid_POCalculator.Columns[17].ReadOnly = false;
            grid_POCalculator.Columns[17].Width = 50;
            grid_POCalculator.Columns[17].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[17].Visible = false;
            grid_POCalculator.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[17].DataPropertyName = "EDLPCAL";

            grid_POCalculator.Columns[18].Name = "BCS EDLP Amount";
            grid_POCalculator.Columns[18].ReadOnly = true;
            grid_POCalculator.Columns[18].Width = 50;
            grid_POCalculator.Columns[18].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[18].Visible = false;
            grid_POCalculator.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[19].Name = "Supplier EDLP";
            grid_POCalculator.Columns[19].ReadOnly = false;
            grid_POCalculator.Columns[19].Width = 50;
            grid_POCalculator.Columns[19].Visible = false;
            grid_POCalculator.Columns[19].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[19].DataPropertyName = "supplierEDLP";

            grid_POCalculator.Columns[20].Name = "Supplier EDLP Amount";
            grid_POCalculator.Columns[20].ReadOnly = true;
            grid_POCalculator.Columns[20].Width = 50;
            grid_POCalculator.Columns[20].Visible = false;
            grid_POCalculator.Columns[20].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[21].Name = "EDLP DIFF";
            grid_POCalculator.Columns[21].ReadOnly = true;
            grid_POCalculator.Columns[21].Width = 50;
            grid_POCalculator.Columns[21].Visible = false;
            grid_POCalculator.Columns[21].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[22].Name = "BCS EDLP%";
            grid_POCalculator.Columns[22].ReadOnly = false;
            grid_POCalculator.Columns[22].Width = 50;
            grid_POCalculator.Columns[22].Visible = false;
            grid_POCalculator.Columns[22].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[22].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[22].DataPropertyName = "EDLPPCAL";

            grid_POCalculator.Columns[23].Name = "BCS EDLP% Amount";
            grid_POCalculator.Columns[23].ReadOnly = true;
            grid_POCalculator.Columns[23].Width = 50;
            grid_POCalculator.Columns[23].Visible = false;
            grid_POCalculator.Columns[23].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[23].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[24].Name = "Supplier EDLP%";
            grid_POCalculator.Columns[24].ReadOnly = false;
            grid_POCalculator.Columns[24].Width = 50;
            grid_POCalculator.Columns[24].Visible = false;
            grid_POCalculator.Columns[24].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[24].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[24].DataPropertyName = "supplierEDLPP";

            grid_POCalculator.Columns[25].Name = "Supplier EDLP% Amount";
            grid_POCalculator.Columns[25].ReadOnly = true;
            grid_POCalculator.Columns[25].Width = 50;
            grid_POCalculator.Columns[25].Visible = false;
            grid_POCalculator.Columns[25].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[25].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[26].Name = "EDLP% DIFF";
            grid_POCalculator.Columns[26].ReadOnly = true;
            grid_POCalculator.Columns[26].Width = 50;
            grid_POCalculator.Columns[26].Visible = false;
            grid_POCalculator.Columns[26].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[26].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[26].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[27].Name = "BCS Term promo";
            grid_POCalculator.Columns[27].ReadOnly = false;
            grid_POCalculator.Columns[27].Width = 50;
            grid_POCalculator.Columns[27].Visible = false;
            grid_POCalculator.Columns[27].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[27].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[27].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[27].DataPropertyName = "TermPromoCAL";

            grid_POCalculator.Columns[28].Name = "BCS Term promo Amount";
            grid_POCalculator.Columns[28].ReadOnly = true;
            grid_POCalculator.Columns[28].Width = 50;
            grid_POCalculator.Columns[28].Visible = false;
            grid_POCalculator.Columns[28].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[28].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[28].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[29].Name = "Supplier Term promo";
            grid_POCalculator.Columns[29].ReadOnly = false;
            grid_POCalculator.Columns[29].Width = 50;
            grid_POCalculator.Columns[29].Visible = false;
            grid_POCalculator.Columns[29].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[29].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[29].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[29].DataPropertyName = "supplierTermPromo";

            grid_POCalculator.Columns[30].Name = "Supplier Term promo Amount";
            grid_POCalculator.Columns[30].ReadOnly = true;
            grid_POCalculator.Columns[30].Width = 50;
            grid_POCalculator.Columns[30].Visible = false;
            grid_POCalculator.Columns[30].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[30].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[30].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[31].Name = "Term promo DIFF";
            grid_POCalculator.Columns[31].ReadOnly = true;
            grid_POCalculator.Columns[31].Width = 50;
            grid_POCalculator.Columns[31].Visible = false;
            grid_POCalculator.Columns[31].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[31].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[31].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[32].Name = "BCS Term promo%";
            grid_POCalculator.Columns[32].ReadOnly = false;
            grid_POCalculator.Columns[32].Width = 50;
            grid_POCalculator.Columns[32].Visible = false;
            grid_POCalculator.Columns[32].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[32].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[32].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[32].DataPropertyName = "TermPromoPCAL";

            grid_POCalculator.Columns[33].Name = "BCS Term promo% Amount";
            grid_POCalculator.Columns[33].ReadOnly = true;
            grid_POCalculator.Columns[33].Width = 50;
            grid_POCalculator.Columns[33].Visible = false;
            grid_POCalculator.Columns[33].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[33].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[33].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[34].Name = "Supplier Term promo%";
            grid_POCalculator.Columns[34].ReadOnly = false;
            grid_POCalculator.Columns[34].Width = 50;
            grid_POCalculator.Columns[34].Visible = false;
            grid_POCalculator.Columns[34].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[34].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[34].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[34].DataPropertyName = "supplierTermPromoP";

            grid_POCalculator.Columns[35].Name = "Supplier Term promo% Amount";
            grid_POCalculator.Columns[35].ReadOnly = true;
            grid_POCalculator.Columns[35].Width = 50;
            grid_POCalculator.Columns[35].Visible = false;
            grid_POCalculator.Columns[35].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[35].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[35].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[36].Name = "Term promo% DIFF";
            grid_POCalculator.Columns[36].ReadOnly = true;
            grid_POCalculator.Columns[36].Width = 50;
            grid_POCalculator.Columns[36].Visible = false;
            grid_POCalculator.Columns[36].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[36].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[36].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[37].Name = "BCS NET COST";
            grid_POCalculator.Columns[37].ReadOnly = true;
            grid_POCalculator.Columns[37].Width = 50;
            grid_POCalculator.Columns[37].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[37].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[37].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[38].Name = "PO AMOUNT";
            grid_POCalculator.Columns[38].ReadOnly = true;
            grid_POCalculator.Columns[38].Width = 50;
            grid_POCalculator.Columns[38].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[38].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[38].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[39].Name = "INVOICE NET COST";
            grid_POCalculator.Columns[39].ReadOnly = true;
            grid_POCalculator.Columns[39].Width = 50;
            grid_POCalculator.Columns[39].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[39].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[39].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[40].Name = "INVOICE AMOUNT";
            grid_POCalculator.Columns[40].ReadOnly = true;
            grid_POCalculator.Columns[40].Width = 50;
            grid_POCalculator.Columns[40].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[40].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[40].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[41].Name = "TOTAL DIFF";
            grid_POCalculator.Columns[41].ReadOnly = true;
            grid_POCalculator.Columns[41].Width = 50;
            grid_POCalculator.Columns[41].DefaultCellStyle.Format = "N2";
            grid_POCalculator.Columns[41].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_POCalculator.Columns[41].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_POCalculator.Columns[42].Name = "PaymentType";
            grid_POCalculator.Columns[42].ReadOnly = true;
            grid_POCalculator.Columns[42].Width = 100;
            grid_POCalculator.Columns[42].Visible = false;
            grid_POCalculator.Columns[42].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[42].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[42].DataPropertyName = "PaymentType";

            grid_POCalculator.Columns[43].Name = "POPLIN_0";
            grid_POCalculator.Columns[43].ReadOnly = true;
            grid_POCalculator.Columns[43].Width = 100;
            grid_POCalculator.Columns[43].Visible = false;
            grid_POCalculator.Columns[43].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[43].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_POCalculator.Columns[43].DataPropertyName = "POPLIN_0";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 60;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.DataPropertyName = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            //deleteButton.Visible = false;
            if (grid_POCalculator.Columns["Delete"] == null)
            {
                grid_POCalculator.Columns.Insert(43, deleteButton);
            }

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
        private void CalculateRows(int RowIndex)
        {
            try
            {
                Decimal BCSPrice = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["BCS Price"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["BCS Price"].Value);
                Decimal BCSQty = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["BCS Qty"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["BCS Qty"].Value);
                Decimal BCSAmount = BCSPrice * BCSQty;
                Decimal SupplierPrice = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["Supplier Price"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["Supplier Price"].Value);
                Decimal SupplierQty = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["Supplier Qty"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["Supplier Qty"].Value);
                Decimal SupplierAmount = SupplierPrice * SupplierQty;
                Decimal BCSEDLP = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["BCS EDLP"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["BCS EDLP"].Value);
                Decimal SupplierEDLP = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["Supplier EDLP"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["Supplier EDLP"].Value);
                Decimal BCSEDLPP = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["BCS EDLP%"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["BCS EDLP%"].Value);
                Decimal SupplierEDLPP = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["Supplier EDLP%"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["Supplier EDLP%"].Value);
                Decimal BCSTermPromo = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["BCS Term promo"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["BCS Term promo"].Value);
                Decimal SupplierTermPromo = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["Supplier Term promo"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["Supplier Term promo"].Value);
                Decimal BCSTermPromoP = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["BCS Term promo%"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["BCS Term promo%"].Value);
                Decimal SupplierTermPromoP = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["Supplier Term promo%"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["Supplier Term promo%"].Value);
                Decimal BCSNETCOST = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["BCS NET COST"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["BCS NET COST"].Value);
                Decimal POAMOUNT = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["PO AMOUNT"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["PO AMOUNT"].Value);
                Decimal INVOICENETCOST = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["INVOICE NET COST"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["INVOICE NET COST"].Value);
                Decimal INVOICEAMOUNT = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["INVOICE AMOUNT"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["INVOICE AMOUNT"].Value);
                Decimal TOTALDIFF = Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["TOTAL DIFF"].Value == DBNull.Value ? "0" : grid_POCalculator.Rows[RowIndex].Cells["TOTAL DIFF"].Value);
                Decimal BCSEDLPAmount = Convert.ToDecimal((BCSEDLP * BCSQty).ToString("N7"));
                Decimal BCSEDLPPAmount = Convert.ToDecimal((Convert.ToDecimal((BCSPrice * BCSEDLPP / 100).ToString("N7")) * BCSQty).ToString("N7"));
                Decimal SupplierEDLPPAmount = Convert.ToDecimal((Convert.ToDecimal(((BCSPrice * SupplierEDLPP) / 100).ToString("N7")) * BCSQty).ToString("N7"));
                Decimal BCSTermPromoAmount = Convert.ToDecimal((BCSTermPromo * BCSQty).ToString("N7"));
                Decimal BCSTermPromoPAmount = Convert.ToDecimal((Convert.ToDecimal(((BCSPrice * BCSTermPromoP) / 100).ToString("N7")) * BCSQty).ToString("N7"));
                Decimal SUPEDLPAmount = Convert.ToDecimal((SupplierEDLP * SupplierQty).ToString("N7"));
                Decimal SUPEDLPPAmount = Convert.ToDecimal((Convert.ToDecimal(((SupplierPrice * SupplierEDLPP) / 100).ToString("N7")) * SupplierQty).ToString("N7"));
                Decimal SUPTermPromoAmount = Convert.ToDecimal((SupplierTermPromo * SupplierQty).ToString("N7"));
                Decimal SUPTermPromoPAmount = Convert.ToDecimal((Convert.ToDecimal((SupplierPrice * SupplierTermPromoP / 100).ToString("N7")) * SupplierQty).ToString("N7"));

                grid_POCalculator.Rows[RowIndex].Cells["BCS Price"].Value = BCSPrice.ToString();
                grid_POCalculator.Rows[RowIndex].Cells["BCS Qty"].Value = BCSQty.ToString();
                grid_POCalculator.Rows[RowIndex].Cells["Supplier Price"].Value = SupplierPrice.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["Supplier Qty"].Value = SupplierQty.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["BCS EDLP"].Value = BCSEDLP.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["Supplier EDLP"].Value = SupplierEDLP.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["BCS EDLP%"].Value = BCSEDLPP.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["Supplier EDLP%"].Value = SupplierEDLPP.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["BCS Term promo"].Value = BCSTermPromo.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["Supplier Term promo"].Value = SupplierTermPromo.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["BCS Term promo%"].Value = BCSTermPromoP.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["Supplier Term promo%"].Value = SupplierTermPromoP.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["BCS Amount"].Value = BCSAmount.ToString();
                grid_POCalculator.Rows[RowIndex].Cells["Supplier Amount"].Value = SupplierAmount.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["Amount DIFF"].Value = (BCSAmount - SupplierAmount).ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["BCS EDLP Amount"].Value = (BCSEDLPAmount).ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["Supplier EDLP Amount"].Value = (SUPEDLPAmount).ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["EDLP DIFF"].Value = (BCSEDLPAmount - SUPEDLPAmount).ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["BCS EDLP% Amount"].Value = BCSEDLPPAmount.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["Supplier EDLP% Amount"].Value = SupplierEDLPPAmount.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["EDLP% DIFF"].Value = (BCSEDLPPAmount - SupplierEDLPPAmount).ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["BCS Term promo Amount"].Value = BCSTermPromoAmount.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["Supplier Term promo Amount"].Value = SUPTermPromoAmount.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["Term promo DIFF"].Value = (BCSTermPromoAmount - SUPTermPromoAmount).ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["BCS Term promo% Amount"].Value = BCSTermPromoPAmount.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["Supplier Term promo% Amount"].Value = SUPTermPromoPAmount.ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["Term promo% DIFF"].Value = (BCSTermPromoPAmount - SUPTermPromoPAmount).ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["BCS NET COST"].Value = (BCSPrice - BCSEDLP - (BCSPrice * BCSEDLPP / 100) - BCSTermPromo - (BCSPrice * BCSTermPromoP / 100)).ToString("N7"); //N7
                grid_POCalculator.Rows[RowIndex].Cells["PO AMOUNT"].Value = (BCSQty * Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["BCS NET COST"].Value)).ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["INVOICE NET COST"].Value = (SupplierPrice - SupplierEDLP - (SupplierPrice * SupplierEDLPP / 100) - SupplierTermPromo - (SupplierPrice * SupplierTermPromoP / 100)).ToString("N7");
                grid_POCalculator.Rows[RowIndex].Cells["INVOICE AMOUNT"].Value = (SupplierQty * Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["INVOICE NET COST"].Value)).ToString("N2");
                grid_POCalculator.Rows[RowIndex].Cells["TOTAL DIFF"].Value = (Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["PO AMOUNT"].Value) - Convert.ToDecimal(grid_POCalculator.Rows[RowIndex].Cells["INVOICE AMOUNT"].Value)).ToString("N2");
            }
            catch (Exception ex) { MessageBox.Show("CalculateRows\n" + ex.ToString()); }
        }
        private void CalculateTotal()
        {
            try
            {
                decimal TotalBCSQty = 0, TotalBCSAmount = 0, TotalBCSEDLPAmount = 0, TotalBCSEDLPPAmount = 0, TotalBCSTERMAmount = 0, TotalBCSTERMPAmount = 0,
                TotalSUPQty = 0, TotalSUPAmount = 0, TotalSUPEDLPAmount = 0, TotalSUPEDLPPAmount = 0, TotalSUPTERMAmount = 0, TotalSUPTERMPAmount = 0,
                TotalAmountDIFF = 0, TotalEDLPDIFF = 0, TotalEDLPPDIFF = 0, TotalTERMDIFF = 0, TotalTERMPDIFF = 0,
                TotalBCSPOAmount = 0, TotalSUPINVAmount = 0, TotalDIFFS = 0;
                for (int i = 0; i < grid_POCalculator.RowCount - 1; i++)
                {
                    TotalBCSQty += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["BCS Qty"].Value);
                    TotalBCSAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["BCS Amount"].Value);
                    TotalSUPQty += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Supplier Qty"].Value);
                    TotalSUPAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Supplier Amount"].Value);
                    TotalAmountDIFF += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Amount DIFF"].Value);
                    TotalBCSEDLPAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["BCS EDLP Amount"].Value);
                    TotalSUPEDLPAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Supplier EDLP Amount"].Value);
                    TotalEDLPDIFF += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["EDLP DIFF"].Value);
                    TotalBCSEDLPPAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["BCS EDLP% Amount"].Value);
                    TotalSUPEDLPPAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Supplier EDLP% Amount"].Value);
                    TotalEDLPPDIFF += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["EDLP% DIFF"].Value);
                    TotalBCSTERMAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["BCS Term promo Amount"].Value);
                    TotalSUPTERMAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Supplier Term promo Amount"].Value);
                    TotalTERMDIFF += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Term promo DIFF"].Value);
                    TotalBCSTERMPAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["BCS Term promo% Amount"].Value);
                    TotalSUPTERMPAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Supplier Term promo% Amount"].Value);
                    TotalTERMPDIFF += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Term promo% DIFF"].Value);
                    TotalBCSPOAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["PO AMOUNT"].Value);
                    TotalSUPINVAmount += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["INVOICE AMOUNT"].Value);
                    TotalDIFFS += Convert.ToDecimal(grid_POCalculator.Rows[i].Cells["Total DIFF"].Value);
                }
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS Qty"].Value = TotalBCSQty.ToString();
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS Amount"].Value = TotalBCSAmount.ToString();
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier Price"].Value = "";
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier Qty"].Value = TotalSUPQty.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier Amount"].Value = TotalSUPAmount.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Amount DIFF"].Value = TotalAmountDIFF.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS EDLP Amount"].Value = TotalBCSEDLPAmount.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier EDLP"].Value = "";
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier EDLP Amount"].Value = TotalSUPEDLPAmount.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["EDLP DIFF"].Value = TotalEDLPDIFF.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS EDLP% Amount"].Value = TotalBCSEDLPPAmount.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier EDLP%"].Value = "";
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier EDLP% Amount"].Value = TotalSUPEDLPPAmount.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["EDLP% DIFF"].Value = TotalEDLPPDIFF.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS Term promo Amount"].Value = TotalBCSTERMAmount.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier Term promo"].Value = "";
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier Term promo Amount"].Value = TotalSUPTERMAmount.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Term promo DIFF"].Value = TotalTERMDIFF.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS Term promo% Amount"].Value = TotalBCSTERMPAmount.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier Term promo%"].Value = "";
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Supplier Term promo% Amount"].Value = TotalSUPTERMPAmount.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Term promo% DIFF"].Value = TotalTERMPDIFF.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["PO AMOUNT"].Value = TotalBCSPOAmount.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["INVOICE AMOUNT"].Value = TotalSUPINVAmount.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Total DIFF"].Value = TotalDIFFS.ToString("N2");
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["BCS NET COST"].Value = "";
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["INVOICE NET COST"].Value = "";
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["PaymentType"].Value = "";
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells["Delete"].Value = "";

                txt_BCSInvoice.Text = TotalBCSPOAmount.ToString("N2");
                txt_SupplierInvoice.Text = TotalSUPINVAmount.ToString("N2");
                txt_Difference.Text = (TotalBCSPOAmount - TotalSUPINVAmount).ToString("N2");
            }
            catch (Exception ex) { MessageBox.Show("CalculateTotal\n" + ex.Message.ToString()); }
        }

        private void grid_POCalculator_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (NewFlag)
                {
                    SupplierInputInitialize();
                    NewFlag = false;
                    ColorSetting();
                }

                foreach (DataGridViewRow row in this.grid_POCalculator.Rows)
                {
                    if (row.Cells["BCS ItemID"].Value.Equals("TOTAL"))
                    {
                        for (int i = 0; i < grid_POCalculator.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Gray;
                            row.Cells[i].Style.ForeColor = Color.White;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void grid_POCalculator_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 43 && e.RowIndex >= 0 && e.RowIndex < grid_POCalculator.RowCount - 1) // Delete button
                {
                    String ProductID = grid_POCalculator.Rows[e.RowIndex].Cells["BCS ItemID"].Value.ToString();

                    if (e.RowIndex < StaticRowCount)
                    {
                        MessageBox.Show("You cannot delete original PO detail.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    DialogResult dialogResult = MessageBox.Show("Are you sure to delete this product( " + ProductID + " )?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            grid_POCalculator.Rows.Remove(grid_POCalculator.Rows[e.RowIndex]);
                            CalculateTotal();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grid_POCalculator_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CalculateRows(e.RowIndex);
                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "grid_POCalculator_CellEndEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grid_POCalculator.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0.00";
            }
        }
        private void ColorSetting()
        {
            foreach (DataGridViewRow row in this.grid_POCalculator.Rows)
            {
                row.Cells["Supplier Price"].Style.BackColor = Color.OldLace;
                row.Cells["Supplier Qty"].Style.BackColor = Color.OldLace;
                row.Cells["Supplier EDLP"].Style.BackColor = Color.OldLace;
                row.Cells["Supplier EDLP%"].Style.BackColor = Color.OldLace;
                row.Cells["Supplier Term promo"].Style.BackColor = Color.OldLace;
                row.Cells["Supplier Term promo%"].Style.BackColor = Color.OldLace;
                row.Cells["BCS Price"].Style.BackColor = Color.OldLace;
                row.Cells["BCS Qty"].Style.BackColor = Color.OldLace;
                row.Cells["BCS EDLP"].Style.BackColor = Color.OldLace;
                row.Cells["BCS EDLP%"].Style.BackColor = Color.OldLace;
                row.Cells["BCS Term promo"].Style.BackColor = Color.OldLace;
                row.Cells["BCS Term promo%"].Style.BackColor = Color.OldLace;
            }

        }
        private void SupplierInputInitialize()
        {
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 2].Cells["Supplier Price"].Value = "0.00";
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 2].Cells["Supplier Qty"].Value = "0.00";
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 2].Cells["Supplier EDLP"].Value = "0.00";
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 2].Cells["Supplier EDLP%"].Value = "0.00";
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 2].Cells["Supplier Term promo"].Value = "0.00";
            grid_POCalculator.Rows[grid_POCalculator.RowCount - 2].Cells["Supplier Term promo%"].Value = "0.00";
        }

        private void POCaculator_Load(object sender, EventArgs e)
        {
            try
            {
                String PaymentType = grid_POCalculator.Rows[0].Cells["PaymentType"].Value.ToString();
                txt_PaymentType.Text = PaymentType;

                ColorSetting();

                Decimal TotalEDLP = 0, TotalEDLPP = 0, TotalPromo = 0, TotalPromoP = 0;
                foreach (DataGridViewRow row in this.grid_POCalculator.Rows)
                {
                    //row.Cells["Supplier Price"].Value = row.Cells["BCS Price"].Value;
                    //row.Cells["Supplier Qty"].Value = row.Cells["BCS Qty"].Value;
                    
                    //row.Cells["Supplier EDLP"].Value = row.Cells["BCS EDLP"].Value;
                    //row.Cells["Supplier EDLP%"].Value = row.Cells["BCS EDLP%"].Value;
                    //row.Cells["Supplier Term promo"].Value = row.Cells["BCS Term promo"].Value;
                    //row.Cells["Supplier Term promo%"].Value = row.TCells["BCS Term promo%"].Value;
                    
                    row.Cells["BCS NET COST"].Value = "0.00";
                    row.Cells["PO AMOUNT"].Value = "0.00";
                    row.Cells["INVOICE NET COST"].Value = "0.00";
                    row.Cells["INVOICE AMOUNT"].Value = "0.00";
                    row.Cells["TOTAL DIFF"].Value = "0.00";

                    TotalEDLP += Convert.ToDecimal(row.Cells["BCS EDLP"].Value);
                    TotalEDLPP += Convert.ToDecimal(row.Cells["BCS EDLP%"].Value);
                    TotalPromo += Convert.ToDecimal(row.Cells["BCS Term promo"].Value);
                    TotalPromoP += Convert.ToDecimal(row.Cells["BCS Term promo%"].Value);

                    CalculateRows(row.Index);
                }
                if (TotalEDLP != 0) chb_EDLP.Checked = true;
                if (TotalEDLPP != 0) chb_EDLPP.Checked = true;
                if (TotalPromo != 0) chb_TermPromo.Checked = true;
                if (TotalPromoP != 0) chb_TermPromoP.Checked = true;


                for (int i = 0; i < 7; i++)
                {
                    grid_POCalculator.Columns[i].Frozen = true;
                    grid_POCalculator.Columns[6].DividerWidth = 2;
                }

                DataTable dt = grid_POCalculator.DataSource as DataTable;
                DataRow dr = dt.NewRow();

                dr["PONumber"] = "";
                dr["RecNumber"] = "";
                dr["Supplier"] = "";
                dr["RECDATE"] = DBNull.Value;
                dr["BCSItemID"] = "TOTAL";
                dr["SupplierItemID"] = "";
                dr["Description"] = "";
                dr["PackSize"] = "";
                dr["UOM"] = "";
                dr["Qty"] = "0.00";
                dr["Amount"] = "0.00";
                dr["PaymentType"] = "";
                dt.Rows.Add(dr);


                DataGridViewCellStyle dataGridViewCellStyleEmpty = new DataGridViewCellStyle();
                dataGridViewCellStyleEmpty.Padding = new Padding(0, 0, 1000, 0);
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].Cells[43].Style = dataGridViewCellStyleEmpty;
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].DefaultCellStyle.BackColor = Color.Gray;
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].DefaultCellStyle.ForeColor = Color.White;
                grid_POCalculator.Rows[grid_POCalculator.RowCount - 1].ReadOnly = true;

                CalculateTotal();
            }
            catch (Exception ex) { MessageBox.Show("POCaculator_Load\n" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void chb_EDLP_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            int i = 0;
            bool CheckedFlag = false;
            switch (cb.Name)
            {
                case "chb_EDLP":
                    i = 17;
                    break;
                case "chb_EDLPP":
                    i = 22;
                    break;
                case "chb_TermPromo":
                    i = 27;
                    break;
                case "chb_TermPromoP":
                    i = 32;
                    break;
            }
            if (cb.Checked) CheckedFlag = true;

            for (int n = i; n < i + 5; n++)
            {
                grid_POCalculator.Columns[n].Visible = CheckedFlag;
            }
        }

        private void cbo_ProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            connSalesOrder.getItemInfoFromItemID(cbo_ProductID.Text, txt_Description, txt_PackSize, txt_Unit, txt_Conversion);
            txt_SupplierProductID.Text = connSalesOrder.sp_PORDER_GET_SupplierProductID(txt_Supplier.Text.Trim(), cbo_ProductID.Text.Trim());
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                String InputProductID = cbo_ProductID.Text.ToString();
                if (InputProductID.Equals(""))
                {
                    MessageBox.Show("Please input valid value(Product ID).", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                foreach (DataGridViewRow row in this.grid_POCalculator.Rows)
                {
                    if (InputProductID.Equals(row.Cells["BCS ItemID"].Value.ToString()))
                    {
                        MessageBox.Show("Product ID already exist."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                DataTable dt = grid_POCalculator.DataSource as DataTable;
                DataRow dr = dt.NewRow();

                String ProductID = cbo_ProductID.Text;
                String SupplierItemID = txt_SupplierProductID.Text;
                String ProductDesc = txt_Description.Text;
                String UOM = txt_Unit.Text;
                String PackSize = txt_PackSize.Text;
                String CONV = txt_Conversion.Text;


                dr["PONumber"] = txt_PONumber.Text;
                dr["RECNumber"] = txt_RECNumber.Text;
                dr["Supplier"] = txt_Supplier.Text;
                dr["RECDATE"] = dateTimePickerRec.Value.Date;
                dr["BCSItemID"] = ProductID;
                dr["SupplierItemID"] = SupplierItemID;
                dr["Description"] = ProductDesc;
                dr["PackSize"] = PackSize;
                dr["UOM"] = UOM;
                dr["CONV"] = CONV;
                dr["Price"] = "0.00";
                dr["Qty"] = "0.00";
                dr["Amount"] = "0.00";
                dr["EDLPCAL"] = "0.00";
                dr["EDLPPCAL"] = "0.00";
                dr["TermPromoCAL"] = "0.00";
                dr["TermPromoPCAL"] = "0.00";
                dr["PaymentType"] = txt_PaymentType.Text.ToString();

                NewFlag = true;
                //dt.Rows.Add(dr);
                dt.Rows.InsertAt(dr, grid_POCalculator.RowCount - 1);
                CalculateRows(grid_POCalculator.RowCount - 2);

                //RefreshGridviewByCalculator();
                //dt.Rows.InsertAt(dr, grid_RouteDetail.ColumnCount + 1);
                //Audit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Input all item info", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = txt_PONumber.Text.ToString() + " Calculator.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    // changing the name of active sheet
                    hoja_trabajo.Name = txt_PONumber.Text.ToString();
                    // storing header part in Excel
                    for (int i = 1; i < grid_POCalculator.Columns.Count + 1; i++)
                    {
                        hoja_trabajo.Cells[1, i] = grid_POCalculator.Columns[i - 1].HeaderText;
                    }

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 1; i < grid_POCalculator.RowCount + 1; i++)
                    {
                        for (int j = 0; j < grid_POCalculator.Columns.Count; j++)
                        {
                            //if(i == grid_POCalculator.RowCount) { MessageBox.Show(grid_POCalculator.Rows[i - 1].Cells[j].Value == DBNull.Value ? "" : grid_POCalculator.Rows[i - 1].Cells[j].Value.ToString()); }
                            hoja_trabajo.Cells[i + 1, j + 1] = grid_POCalculator.Rows[i - 1].Cells[j].Value == DBNull.Value ? "" : grid_POCalculator.Rows[i - 1].Cells[j].Value.ToString();
                        }
                    }

                    libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void grid_POCalculator_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                //grid_POCalculator.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0.000";
            }
            catch (Exception ex)
            {
                MessageBox.Show("grid_POCalculator_DataError\n" + ex.ToString());
            }
        }

        private void POCaculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (bOccupied == false)
            //{
            //    connSalesOrder.sp_POCalculator_OCCUPIED_RELEASE(ReceivingNumber);


            //}

            try
            {
                foreach (DataGridViewRow row in this.grid_POCalculator.Rows)
                {
                    if (row.Cells["BCS ItemID"].Value.Equals("TOTAL"))
                        return;
                    Decimal bcsPrice = 0;
                    Decimal bcsQty = 0;
                    Decimal supplierPrice = 0;
                    Decimal supplierQty = 0;
                    Decimal bcsEDLP = 0;
                    Decimal supplierEDLP = 0;
                    Decimal bcsEDLPP = 0;
                    Decimal supplierEDLPP = 0;
                    Decimal bcsTermPromo = 0;
                    Decimal supplierTermPromo = 0;
                    Decimal bcsTermPromoP = 0;
                    Decimal supplierTermPromoP = 0;
                    Decimal poplin_0 = Convert.ToDecimal(row.Cells["POPLIN_0"].Value.ToString());

                    //if (chb_EDLP.Checked == false && chb_TermPromo.Checked == false && chb_EDLPP.Checked == false && chb_TermPromoP.Checked == false)
                    //{
                    bcsPrice = Convert.ToDecimal(row.Cells["BCS Price"].Value.ToString());
                    bcsQty = Convert.ToDecimal(row.Cells["BCS Qty"].Value.ToString());
                    supplierPrice = Convert.ToDecimal(row.Cells["Supplier Price"].Value.ToString());
                    supplierQty = Convert.ToDecimal(row.Cells["Supplier Qty"].Value.ToString());
                    //}
                    if (chb_EDLP.Checked == true)
                    {
                        bcsEDLP = Convert.ToDecimal(row.Cells["BCS EDLP"].Value.ToString());
                        supplierEDLP = Convert.ToDecimal(row.Cells["Supplier EDLP"].Value.ToString());
                    }
                    if (chb_TermPromo.Checked == true)
                    {
                        bcsTermPromo = Convert.ToDecimal(row.Cells["BCS Term promo"].Value.ToString());
                        supplierTermPromo = Convert.ToDecimal(row.Cells["Supplier Term promo"].Value.ToString());
                    }
                    if (chb_EDLPP.Checked == true)
                    {
                        bcsEDLPP = Convert.ToDecimal(row.Cells["BCS EDLP%"].Value.ToString());
                        supplierEDLPP = Convert.ToDecimal(row.Cells["Supplier EDLP%"].Value.ToString());
                    }
                    if (chb_TermPromoP.Checked == true)
                    {
                        bcsTermPromoP = Convert.ToDecimal(row.Cells["BCS Term promo%"].Value.ToString());
                        supplierTermPromoP = Convert.ToDecimal(row.Cells["Supplier Term promo%"].Value.ToString());
                    }

                    //connPO.sp_UPDATE_PRECEIPTD_POCALC(bcsPrice, bcsQty, supplierPrice, supplierQty, bcsEDLP, supplierEDLP, bcsEDLPP, supplierEDLPP, bcsTermPromo, supplierTermPromo, bcsTermPromoP, supplierTermPromoP, poplin_0);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
