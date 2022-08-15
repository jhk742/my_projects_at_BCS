using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Sales
{
    public partial class MiscellaneousTransactionReport : Form
    {
        public MiscellaneousTransactionReport()
        {
            InitializeComponent();
            grid_report_Init();

            for (int i = 0; i < grid_report.ColumnCount; i++)
            {
                grid_report.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void grid_report_Init()
        {
            grid_report.AutoGenerateColumns = false;
            grid_report.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_report.ColumnCount = 72;

            grid_report.Columns[0].Name = "Month";
            grid_report.Columns[0].ReadOnly = true;
            grid_report.Columns[0].Width = 80;
            grid_report.Columns[0].MinimumWidth = 80;
            grid_report.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_report.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_report.Columns[0].DataPropertyName = "Month";

            grid_report.Columns[1].Name = "Year";
            grid_report.Columns[1].ReadOnly = true;
            grid_report.Columns[1].Width = 40;
            grid_report.Columns[1].MinimumWidth = 40;
            grid_report.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_report.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_report.Columns[1].DataPropertyName = "Year";

            grid_report.Columns[2].Name = "Damaged Stock PO";
            grid_report.Columns[2].ReadOnly = true;
            grid_report.Columns[2].Visible = false;
            grid_report.Columns[2].Width = 80;
            grid_report.Columns[2].MinimumWidth = 80;
            grid_report.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[2].DataPropertyName = "DamagedStockPO";

            grid_report.Columns[3].Name = "Damaged Stock PO Amount";
            grid_report.Columns[3].ReadOnly = true;
            grid_report.Columns[3].Width = 80;
            grid_report.Columns[3].MinimumWidth = 80;
            grid_report.Columns[3].DefaultCellStyle.Format = "N2";
            grid_report.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[3].DataPropertyName = "DamagedStockPOAmount";

            grid_report.Columns[4].Name = "Expired Stock PO";
            grid_report.Columns[4].ReadOnly = true;
            grid_report.Columns[4].Visible = false;
            grid_report.Columns[4].Width = 80;
            grid_report.Columns[4].MinimumWidth = 80;
            grid_report.Columns[4].DefaultCellStyle.Format = "N2";
            grid_report.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[4].DataPropertyName = "ExpiredStockPO";

            grid_report.Columns[5].Name = "Expired Stock PO Amount";
            grid_report.Columns[5].ReadOnly = true;
            grid_report.Columns[5].Width = 80;
            grid_report.Columns[5].MinimumWidth = 80;
            grid_report.Columns[5].DefaultCellStyle.Format = "N2";
            grid_report.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[5].DataPropertyName = "ExpiredStockPOAmount";

            grid_report.Columns[6].Name = "PO Credit";
            grid_report.Columns[6].ReadOnly = true;
            grid_report.Columns[6].Visible = false;
            grid_report.Columns[6].Width = 80;
            grid_report.Columns[6].MinimumWidth = 80;
            grid_report.Columns[6].DefaultCellStyle.Format = "N2";
            grid_report.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[6].DataPropertyName = "POCredit";

            grid_report.Columns[7].Name = "PO Credit Amount";
            grid_report.Columns[7].ReadOnly = true;
            grid_report.Columns[7].Width = 80;
            grid_report.Columns[7].MinimumWidth = 80;
            grid_report.Columns[7].DefaultCellStyle.Format = "N2";
            grid_report.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[7].DataPropertyName = "POCreditAmount";

            grid_report.Columns[8].Name = "Subcontract Differnce";
            grid_report.Columns[8].ReadOnly = true;
            grid_report.Columns[8].Visible = false;
            grid_report.Columns[8].Width = 80;
            grid_report.Columns[8].MinimumWidth = 80;
            grid_report.Columns[8].DefaultCellStyle.Format = "N2";
            grid_report.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[8].DataPropertyName = "SubcontractDiffernce";

            grid_report.Columns[9].Name = "Subcontract Differnce Amount";
            grid_report.Columns[9].ReadOnly = true;
            grid_report.Columns[9].Width = 80;
            grid_report.Columns[9].MinimumWidth = 80;
            grid_report.Columns[9].DefaultCellStyle.Format = "N2";
            grid_report.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[9].DataPropertyName = "SubcontractDiffernceAmount";

            grid_report.Columns[10].Name = "Data Entry Mistakes";
            grid_report.Columns[10].ReadOnly = true;
            grid_report.Columns[10].Visible = false;
            grid_report.Columns[10].Width = 80;
            grid_report.Columns[10].MinimumWidth = 80;
            grid_report.Columns[10].DefaultCellStyle.Format = "N2";
            grid_report.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[10].DataPropertyName = "DataEntryMistakes";

            grid_report.Columns[11].Name = "Data Entry Mistakes Amount";
            grid_report.Columns[11].ReadOnly = true;
            grid_report.Columns[11].Width = 80;
            grid_report.Columns[11].MinimumWidth = 80;
            grid_report.Columns[11].DefaultCellStyle.Format = "N2";
            grid_report.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[11].DataPropertyName = "DataEntryMistakesAmount";

            grid_report.Columns[12].Name = "Wrong Receiving";
            grid_report.Columns[12].ReadOnly = true;
            grid_report.Columns[12].Visible = false;
            grid_report.Columns[12].Width = 80;
            grid_report.Columns[12].MinimumWidth = 80;
            grid_report.Columns[12].DefaultCellStyle.Format = "N2";
            grid_report.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[12].DataPropertyName = "WrongReceiving";

            grid_report.Columns[13].Name = "Wrong Receiving Amount";
            grid_report.Columns[13].ReadOnly = true;
            grid_report.Columns[13].Width = 80;
            grid_report.Columns[13].MinimumWidth = 80;
            grid_report.Columns[13].DefaultCellStyle.Format = "N2";
            grid_report.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[13].DataPropertyName = "WrongReceivingAmount";

            grid_report.Columns[14].Name = "Free Goods";
            grid_report.Columns[14].ReadOnly = true;
            grid_report.Columns[14].Visible = false;
            grid_report.Columns[14].Width = 80;
            grid_report.Columns[14].MinimumWidth = 80;
            grid_report.Columns[14].DefaultCellStyle.Format = "N2";
            grid_report.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[14].DataPropertyName = "FreeGoods";

            grid_report.Columns[15].Name = "Free Goods Amount";
            grid_report.Columns[15].ReadOnly = true;
            grid_report.Columns[15].Width = 80;
            grid_report.Columns[15].MinimumWidth = 80;
            grid_report.Columns[15].DefaultCellStyle.Format = "N2";
            grid_report.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[15].DataPropertyName = "FreeGoodsAmount";

            grid_report.Columns[16].Name = "PO Subtotal Qty";
            grid_report.Columns[16].ReadOnly = true;
            grid_report.Columns[16].Visible = false;
            grid_report.Columns[16].Width = 80;
            grid_report.Columns[16].MinimumWidth = 80;
            grid_report.Columns[16].DefaultCellStyle.Format = "N2";
            grid_report.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[16].DataPropertyName = "POSubtotalQty";

            grid_report.Columns[17].Name = "PO Subtotal Amount";
            grid_report.Columns[17].ReadOnly = true;
            grid_report.Columns[17].Visible = false;
            grid_report.Columns[17].Width = 80;
            grid_report.Columns[17].MinimumWidth = 80;
            grid_report.Columns[17].DefaultCellStyle.Format = "N2";
            grid_report.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[17].DataPropertyName = "POSubtotalAmount";

            grid_report.Columns[18].Name = "Damaged Stock WH";
            grid_report.Columns[18].ReadOnly = true;
            grid_report.Columns[18].Visible = false;
            grid_report.Columns[18].Width = 80;
            grid_report.Columns[18].MinimumWidth = 80;
            grid_report.Columns[18].DefaultCellStyle.Format = "N2";
            grid_report.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[18].DataPropertyName = "DamagedStockWH";

            grid_report.Columns[19].Name = "Damaged Stock WH Amount";
            grid_report.Columns[19].ReadOnly = true;
            grid_report.Columns[19].Width = 80;
            grid_report.Columns[19].MinimumWidth = 80;
            grid_report.Columns[19].DefaultCellStyle.Format = "N2";
            grid_report.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[19].DataPropertyName = "DamagedStockWHAmount";

            grid_report.Columns[20].Name = "Expired Stock WH";
            grid_report.Columns[20].ReadOnly = true;
            grid_report.Columns[20].Visible = false;
            grid_report.Columns[20].Width = 80;
            grid_report.Columns[20].MinimumWidth = 80;
            grid_report.Columns[20].DefaultCellStyle.Format = "N2";
            grid_report.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[20].DataPropertyName = "ExpiredStockWH";

            grid_report.Columns[21].Name = "Expired Stock WH Amount";
            grid_report.Columns[21].ReadOnly = true;
            grid_report.Columns[21].Width = 80;
            grid_report.Columns[21].MinimumWidth = 80;
            grid_report.Columns[21].DefaultCellStyle.Format = "N2";
            grid_report.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[21].DataPropertyName = "ExpiredStockWHAmount";

            grid_report.Columns[22].Name = "Missing Stock WH";
            grid_report.Columns[22].ReadOnly = true;
            grid_report.Columns[22].Visible = false;
            grid_report.Columns[22].Width = 80;
            grid_report.Columns[22].MinimumWidth = 80;
            grid_report.Columns[22].DefaultCellStyle.Format = "N2";
            grid_report.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[22].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[22].DataPropertyName = "MissingStockWH";

            grid_report.Columns[23].Name = "Missing Stock WH Amount";
            grid_report.Columns[23].ReadOnly = true;
            grid_report.Columns[23].Width = 80;
            grid_report.Columns[23].MinimumWidth = 80;
            grid_report.Columns[23].DefaultCellStyle.Format = "N2";
            grid_report.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[23].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[23].DataPropertyName = "MissingStockWHAmount";

            grid_report.Columns[24].Name = "Global Shortage OS";
            grid_report.Columns[24].ReadOnly = true;
            grid_report.Columns[24].Visible = false;
            grid_report.Columns[24].Width = 80;
            grid_report.Columns[24].MinimumWidth = 80;
            grid_report.Columns[24].DefaultCellStyle.Format = "N2";
            grid_report.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[24].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[24].DataPropertyName = "GlobalShortageOS";

            grid_report.Columns[25].Name = "Global Shortage OS Amount";
            grid_report.Columns[25].ReadOnly = true;
            grid_report.Columns[25].Width = 80;
            grid_report.Columns[25].MinimumWidth = 80;
            grid_report.Columns[25].DefaultCellStyle.Format = "N2";
            grid_report.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[25].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[25].DataPropertyName = "GlobalShortageOSAmount";

            grid_report.Columns[26].Name = "Inventory Adjustment";
            grid_report.Columns[26].ReadOnly = true;
            grid_report.Columns[26].Visible = false;
            grid_report.Columns[26].Width = 80;
            grid_report.Columns[26].MinimumWidth = 80;
            grid_report.Columns[26].DefaultCellStyle.Format = "N2";
            grid_report.Columns[26].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[26].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[26].DataPropertyName = "InventoryAdjustment";

            grid_report.Columns[27].Name = "Inventory Adjustment Amount";
            grid_report.Columns[27].ReadOnly = true;
            grid_report.Columns[27].Width = 80;
            grid_report.Columns[27].MinimumWidth = 80;
            grid_report.Columns[27].DefaultCellStyle.Format = "N2";
            grid_report.Columns[27].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[27].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[27].DataPropertyName = "InventoryAdjustmentAmount";

            grid_report.Columns[28].Name = "Physical Inv Count NJ";
            grid_report.Columns[28].ReadOnly = true;
            grid_report.Columns[28].Visible = false;
            grid_report.Columns[28].Width = 80;
            grid_report.Columns[28].MinimumWidth = 80;
            grid_report.Columns[28].DefaultCellStyle.Format = "N2";
            grid_report.Columns[28].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[28].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[28].DataPropertyName = "PhysicalInvCountNJ";

            grid_report.Columns[29].Name = "Physical Inv Count NJ Amount";
            grid_report.Columns[29].ReadOnly = true;
            grid_report.Columns[29].Width = 80;
            grid_report.Columns[29].MinimumWidth = 80;
            grid_report.Columns[29].DefaultCellStyle.Format = "N2";
            grid_report.Columns[29].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[29].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[29].DataPropertyName = "PhysicalInvCountNJAmount";

            grid_report.Columns[30].Name = "Physical Inv Count NY";
            grid_report.Columns[30].ReadOnly = true;
            grid_report.Columns[30].Visible = false;
            grid_report.Columns[30].Width = 80;
            grid_report.Columns[30].MinimumWidth = 80;
            grid_report.Columns[30].DefaultCellStyle.Format = "N2";
            grid_report.Columns[30].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[30].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[30].DataPropertyName = "PhysicalInvCountNY";

            grid_report.Columns[31].Name = "Physical Inv Count NY Amount";
            grid_report.Columns[31].ReadOnly = true;
            grid_report.Columns[31].Width = 80;
            grid_report.Columns[31].MinimumWidth = 80;
            grid_report.Columns[31].DefaultCellStyle.Format = "N2";
            grid_report.Columns[31].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[31].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[31].DataPropertyName = "PhysicalInvCountNYAmount";

            grid_report.Columns[32].Name = "Rodent Damage";
            grid_report.Columns[32].ReadOnly = true;
            grid_report.Columns[32].Visible = false;
            grid_report.Columns[32].Width = 80;
            grid_report.Columns[32].MinimumWidth = 80;
            grid_report.Columns[32].DefaultCellStyle.Format = "N2";
            grid_report.Columns[32].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[32].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[32].DataPropertyName = "RodentDamage";

            grid_report.Columns[33].Name = "Rodent Damage Amount";
            grid_report.Columns[33].ReadOnly = true;
            grid_report.Columns[33].Width = 80;
            grid_report.Columns[33].MinimumWidth = 80;
            grid_report.Columns[33].DefaultCellStyle.Format = "N2";
            grid_report.Columns[33].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[33].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[33].DataPropertyName = "RodentDamageAmount";

            grid_report.Columns[34].Name = "Repack";
            grid_report.Columns[34].ReadOnly = true;
            grid_report.Columns[34].Visible = false;
            grid_report.Columns[34].Width = 80;
            grid_report.Columns[34].MinimumWidth = 80;
            grid_report.Columns[34].DefaultCellStyle.Format = "N2";
            grid_report.Columns[34].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[34].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[34].DataPropertyName = "Repack";

            grid_report.Columns[35].Name = "Repack Amount";
            grid_report.Columns[35].ReadOnly = true;
            grid_report.Columns[35].Width = 80;
            grid_report.Columns[35].MinimumWidth = 80;
            grid_report.Columns[35].DefaultCellStyle.Format = "N2";
            grid_report.Columns[35].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[35].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[35].DataPropertyName = "RepackAmount";

            grid_report.Columns[36].Name = "Warehouse Subtotal Qty";
            grid_report.Columns[36].ReadOnly = true;
            grid_report.Columns[36].Visible = false;
            grid_report.Columns[36].Width = 80;
            grid_report.Columns[36].MinimumWidth = 80;
            grid_report.Columns[36].DefaultCellStyle.Format = "N2";
            grid_report.Columns[36].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[36].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[36].DataPropertyName = "WarehouseSubtotalQty";

            grid_report.Columns[37].Name = "Warehouse Subtotal Amount";
            grid_report.Columns[37].ReadOnly = true;
            grid_report.Columns[37].Visible = false;
            grid_report.Columns[37].Width = 80;
            grid_report.Columns[37].MinimumWidth = 80;
            grid_report.Columns[37].DefaultCellStyle.Format = "N2";
            grid_report.Columns[37].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[37].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[37].DataPropertyName = "WarehouseSubtotalAmount";

            grid_report.Columns[38].Name = "Damaged Stock SA";
            grid_report.Columns[38].ReadOnly = true;
            grid_report.Columns[38].Visible = false;
            grid_report.Columns[38].Width = 80;
            grid_report.Columns[38].MinimumWidth = 80;
            grid_report.Columns[38].DefaultCellStyle.Format = "N2";
            grid_report.Columns[38].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[38].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[38].DataPropertyName = "DamagedStockSA";

            grid_report.Columns[39].Name = "Damaged Stock SA Amount";
            grid_report.Columns[39].ReadOnly = true;
            grid_report.Columns[39].Width = 80;
            grid_report.Columns[39].MinimumWidth = 80;
            grid_report.Columns[39].DefaultCellStyle.Format = "N2";
            grid_report.Columns[39].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[39].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[39].DataPropertyName = "DamagedStockSAAmount";

            grid_report.Columns[40].Name = "Expired Stock SA";
            grid_report.Columns[40].ReadOnly = true;
            grid_report.Columns[40].Visible = false;
            grid_report.Columns[40].Width = 80;
            grid_report.Columns[40].MinimumWidth = 80;
            grid_report.Columns[40].DefaultCellStyle.Format = "N2";
            grid_report.Columns[40].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[40].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[40].DataPropertyName = "ExpiredStockSA";

            grid_report.Columns[41].Name = "Expired Stock SA Amount";
            grid_report.Columns[41].ReadOnly = true;
            grid_report.Columns[41].Width = 80;
            grid_report.Columns[41].MinimumWidth = 80;
            grid_report.Columns[41].DefaultCellStyle.Format = "N2";
            grid_report.Columns[41].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[41].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[41].DataPropertyName = "ExpiredStockSAAmount";

            grid_report.Columns[42].Name = "Missing Stock SA";
            grid_report.Columns[42].ReadOnly = true;
            grid_report.Columns[42].Visible = false;
            grid_report.Columns[42].Width = 80;
            grid_report.Columns[42].MinimumWidth = 80;
            grid_report.Columns[42].DefaultCellStyle.Format = "N2";
            grid_report.Columns[42].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[42].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[42].DataPropertyName = "MissingStockSA";

            grid_report.Columns[43].Name = "Missing Stock SA Amount";
            grid_report.Columns[43].ReadOnly = true;
            grid_report.Columns[43].Visible = false;
            grid_report.Columns[43].Width = 80;
            grid_report.Columns[43].MinimumWidth = 80;
            grid_report.Columns[43].DefaultCellStyle.Format = "N2";
            grid_report.Columns[43].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[43].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[43].DataPropertyName = "MissingStockSAAmount";

            grid_report.Columns[44].Name = "Sample";
            grid_report.Columns[44].ReadOnly = true;
            grid_report.Columns[44].Visible = false;
            grid_report.Columns[44].Width = 80;
            grid_report.Columns[44].MinimumWidth = 80;
            grid_report.Columns[44].DefaultCellStyle.Format = "N2";
            grid_report.Columns[44].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[44].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[44].DataPropertyName = "Sample";

            grid_report.Columns[45].Name = "Sample Amount";
            grid_report.Columns[45].ReadOnly = true;
            grid_report.Columns[45].Width = 80;
            grid_report.Columns[45].MinimumWidth = 80;
            grid_report.Columns[45].DefaultCellStyle.Format = "N2";
            grid_report.Columns[45].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[45].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[45].DataPropertyName = "SampleAmount";

            grid_report.Columns[46].Name = "Sales Subtotal Qty";
            grid_report.Columns[46].ReadOnly = true;
            grid_report.Columns[46].Visible = false;
            grid_report.Columns[46].Width = 80;
            grid_report.Columns[46].MinimumWidth = 80;
            grid_report.Columns[46].DefaultCellStyle.Format = "N2";
            grid_report.Columns[46].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[46].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[46].DataPropertyName = "SalesSubtotalQty";

            grid_report.Columns[47].Name = "Sales Subtotal Amount";
            grid_report.Columns[47].ReadOnly = true;
            grid_report.Columns[47].Visible = false;
            grid_report.Columns[47].Width = 80;
            grid_report.Columns[47].MinimumWidth = 80;
            grid_report.Columns[47].DefaultCellStyle.Format = "N2";
            grid_report.Columns[47].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[47].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[47].DataPropertyName = "SalesSubtotalAmount";

            grid_report.Columns[48].Name = "Damaged Stock DR";
            grid_report.Columns[48].ReadOnly = true;
            grid_report.Columns[48].Visible = false;
            grid_report.Columns[48].Width = 80;
            grid_report.Columns[48].MinimumWidth = 80;
            grid_report.Columns[48].DefaultCellStyle.Format = "N2";
            grid_report.Columns[48].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[48].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[48].DataPropertyName = "DamagedStockDR";

            grid_report.Columns[49].Name = "Damaged Stock DR Amount";
            grid_report.Columns[49].ReadOnly = true;
            grid_report.Columns[49].Width = 80;
            grid_report.Columns[49].MinimumWidth = 80;
            grid_report.Columns[49].DefaultCellStyle.Format = "N2";
            grid_report.Columns[49].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[49].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[49].DataPropertyName = "DamagedStockDRAmount";

            grid_report.Columns[50].Name = "Expired Stock DR";
            grid_report.Columns[50].ReadOnly = true;
            grid_report.Columns[50].Visible = false;
            grid_report.Columns[50].Width = 80;
            grid_report.Columns[50].MinimumWidth = 80;
            grid_report.Columns[50].DefaultCellStyle.Format = "N2";
            grid_report.Columns[50].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[50].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[50].DataPropertyName = "ExpiredStockDR";

            grid_report.Columns[51].Name = "Expired Stock DR Amount";
            grid_report.Columns[51].ReadOnly = true;
            grid_report.Columns[51].Width = 80;
            grid_report.Columns[51].MinimumWidth = 80;
            grid_report.Columns[51].DefaultCellStyle.Format = "N2";
            grid_report.Columns[51].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[51].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[51].DataPropertyName = "ExpiredStockDRAmount";

            grid_report.Columns[52].Name = "Missing Stock DR";
            grid_report.Columns[52].ReadOnly = true;
            grid_report.Columns[52].Visible = false;
            grid_report.Columns[52].Width = 80;
            grid_report.Columns[52].MinimumWidth = 80;
            grid_report.Columns[52].DefaultCellStyle.Format = "N2";
            grid_report.Columns[52].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[52].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[52].DataPropertyName = "MissingStockDR";

            grid_report.Columns[53].Name = "Missing Stock DR Amount";
            grid_report.Columns[53].ReadOnly = true;
            grid_report.Columns[53].Width = 80;
            grid_report.Columns[53].MinimumWidth = 80;
            grid_report.Columns[53].DefaultCellStyle.Format = "N2";
            grid_report.Columns[53].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[53].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[53].DataPropertyName = "MissingStockDRAmount";

            grid_report.Columns[54].Name = "Driver Subtotal Qty";
            grid_report.Columns[54].ReadOnly = true;
            grid_report.Columns[54].Visible = false;
            grid_report.Columns[54].Visible = false;
            grid_report.Columns[54].Width = 80;
            grid_report.Columns[54].MinimumWidth = 80;
            grid_report.Columns[54].DefaultCellStyle.Format = "N2";
            grid_report.Columns[54].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[54].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[54].DataPropertyName = "DriverSubtotalQty";

            grid_report.Columns[55].Name = "Driver Subtotal Amount";
            grid_report.Columns[55].ReadOnly = true;
            grid_report.Columns[55].Visible = false;
            grid_report.Columns[55].Width = 80;
            grid_report.Columns[55].MinimumWidth = 80;
            grid_report.Columns[55].DefaultCellStyle.Format = "N2";
            grid_report.Columns[55].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[55].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[55].DataPropertyName = "DriverSubtotalAmount";

            grid_report.Columns[56].Name = "Meal For Employees";
            grid_report.Columns[56].ReadOnly = true;
            grid_report.Columns[56].Visible = false;
            grid_report.Columns[56].Width = 80;
            grid_report.Columns[56].MinimumWidth = 80;
            grid_report.Columns[56].DefaultCellStyle.Format = "N2";
            grid_report.Columns[56].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[56].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[56].DataPropertyName = "MealForEmployees";

            grid_report.Columns[57].Name = "Meal For Employees Amount";
            grid_report.Columns[57].ReadOnly = true;
            grid_report.Columns[57].Width = 80;
            grid_report.Columns[57].MinimumWidth = 80;
            grid_report.Columns[57].DefaultCellStyle.Format = "N2";
            grid_report.Columns[57].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[57].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[57].DataPropertyName = "MealForEmployeesAmount";

            grid_report.Columns[58].Name = "Damaged Stock For Sale";
            grid_report.Columns[58].ReadOnly = true;
            grid_report.Columns[58].Visible = false;
            grid_report.Columns[58].Width = 80;
            grid_report.Columns[58].MinimumWidth = 80;
            grid_report.Columns[58].DefaultCellStyle.Format = "N2";
            grid_report.Columns[58].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[58].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[58].DataPropertyName = "DamagedStockForSale";

            grid_report.Columns[59].Name = "Damaged Stock For Sale Amount";
            grid_report.Columns[59].ReadOnly = true;
            grid_report.Columns[59].Width = 80;
            grid_report.Columns[59].MinimumWidth = 80;
            grid_report.Columns[59].DefaultCellStyle.Format = "N2";
            grid_report.Columns[59].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[59].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[59].DataPropertyName = "DamagedStockForSaleAmount";

            grid_report.Columns[60].Name = "Expired Stock For Sale";
            grid_report.Columns[60].ReadOnly = true;
            grid_report.Columns[60].Visible = false;
            grid_report.Columns[60].Width = 80;
            grid_report.Columns[60].MinimumWidth = 80;
            grid_report.Columns[60].DefaultCellStyle.Format = "N2";
            grid_report.Columns[60].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[60].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[60].DataPropertyName = "ExpiredStockForSale";

            grid_report.Columns[61].Name = "Expired Stock For Sale Amount";
            grid_report.Columns[61].ReadOnly = true;
            grid_report.Columns[61].Width = 80;
            grid_report.Columns[61].MinimumWidth = 80;
            grid_report.Columns[61].DefaultCellStyle.Format = "N2";
            grid_report.Columns[61].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[61].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[61].DataPropertyName = "ExpiredStockForSaleAmount";

            grid_report.Columns[62].Name = "Donation";
            grid_report.Columns[62].ReadOnly = true;
            grid_report.Columns[62].Visible = false;
            grid_report.Columns[62].Width = 80;
            grid_report.Columns[62].MinimumWidth = 80;
            grid_report.Columns[62].DefaultCellStyle.Format = "N2";
            grid_report.Columns[62].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[62].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[62].DataPropertyName = "Donation";

            grid_report.Columns[63].Name = "Donation Amount";
            grid_report.Columns[63].ReadOnly = true;
            grid_report.Columns[63].Width = 80;
            grid_report.Columns[63].MinimumWidth = 80;
            grid_report.Columns[63].DefaultCellStyle.Format = "N2";
            grid_report.Columns[63].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[63].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[63].DataPropertyName = "DonationAmount";

            grid_report.Columns[64].Name = "Miscellaneous";
            grid_report.Columns[64].ReadOnly = true;
            grid_report.Columns[64].Visible = false;
            grid_report.Columns[64].Width = 80;
            grid_report.Columns[64].MinimumWidth = 80;
            grid_report.Columns[64].DefaultCellStyle.Format = "N2";
            grid_report.Columns[64].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[64].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[64].DataPropertyName = "Miscellaneous";

            grid_report.Columns[65].Name = "Miscellaneous Amount";
            grid_report.Columns[65].ReadOnly = true;
            grid_report.Columns[65].Width = 80;
            grid_report.Columns[65].MinimumWidth = 80;
            grid_report.Columns[65].DefaultCellStyle.Format = "N2";
            grid_report.Columns[65].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[65].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[65].DataPropertyName = "MiscellaneousAmount";

            grid_report.Columns[66].Name = "Management Subtotal Qty";
            grid_report.Columns[66].ReadOnly = true;
            grid_report.Columns[66].Visible = false;
            grid_report.Columns[66].Width = 80;
            grid_report.Columns[66].MinimumWidth = 80;
            grid_report.Columns[66].DefaultCellStyle.Format = "N2";
            grid_report.Columns[66].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[66].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[66].DataPropertyName = "ManagementSubtotalQty";

            grid_report.Columns[67].Name = "Management Subtotal Amount";
            grid_report.Columns[67].ReadOnly = true;
            grid_report.Columns[67].Visible = false;
            grid_report.Columns[67].Width = 80;
            grid_report.Columns[67].MinimumWidth = 80;
            grid_report.Columns[67].DefaultCellStyle.Format = "N2";
            grid_report.Columns[67].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[67].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[67].DataPropertyName = "ManagementSubtotalAmount";

            grid_report.Columns[68].Name = "Non Category Qty";
            grid_report.Columns[68].ReadOnly = true;
            grid_report.Columns[68].Visible = false;
            grid_report.Columns[68].Width = 80;
            grid_report.Columns[68].MinimumWidth = 80;
            grid_report.Columns[68].DefaultCellStyle.Format = "N2";
            grid_report.Columns[68].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[68].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[68].DataPropertyName = "NonCategoryQty";

            grid_report.Columns[69].Name = "Non Category Amount";
            grid_report.Columns[69].ReadOnly = true;
            grid_report.Columns[69].Visible = false;
            grid_report.Columns[69].Width = 80;
            grid_report.Columns[69].MinimumWidth = 80;
            grid_report.Columns[69].DefaultCellStyle.Format = "N2";
            grid_report.Columns[69].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[69].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[69].DataPropertyName = "NonCategoryAmount";

            grid_report.Columns[70].Name = "Total Qty";
            grid_report.Columns[70].ReadOnly = true;
            grid_report.Columns[70].Visible = false;
            grid_report.Columns[70].Width = 80;
            grid_report.Columns[70].MinimumWidth = 80;
            grid_report.Columns[70].DefaultCellStyle.Format = "N2";
            grid_report.Columns[70].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[70].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[70].DataPropertyName = "TotalQty";

            grid_report.Columns[71].Name = "Total Amount";
            grid_report.Columns[71].ReadOnly = true;
            grid_report.Columns[71].Visible = false;
            grid_report.Columns[71].Width = 80;
            grid_report.Columns[71].MinimumWidth = 80;
            grid_report.Columns[71].DefaultCellStyle.Format = "N2";
            grid_report.Columns[71].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[71].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_report.Columns[71].DataPropertyName = "TotalAmount";

            //grid font size custom
            grid_report.RowTemplate.Height = 20;
            grid_report.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_report.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_report.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String type = "";
            if (rbtn_issue.Checked)
            {
                type = "Issue";
            }
            else if (rbtn_receipt.Checked)
            {
                type = "Receipt";
            }
            else if (rbtn_issueAndReceipt.Checked)
            {
                type = "All";
            }

            connSalesOrder.sp_InventoryMiscellaneousTransactionReport(grid_report, FromDate, ToDate, type);

            try
            {
                DataTable dataTable = (DataTable)grid_report.DataSource;

                decimal totalDamagedStockPO = 0;
                decimal totalDamagedStockPOAmount = 0;
                decimal totalExpiredStockPO = 0;
                decimal totalExpiredStockPOAmount = 0;
                decimal totalPOCredit = 0;
                decimal totalPOCreditAmount = 0;
                decimal totalSubcontractDiffernce = 0;
                decimal totalSubcontractDiffernceAmount = 0;
                decimal totalDataEntryMistakes = 0;
                decimal totalDataEntryMistakesAmount = 0;
                decimal totalWrongReceiving = 0;
                decimal totalWrongReceivingAmount = 0;
                decimal totalFreeGoods = 0;
                decimal totalFreeGoodsAmount = 0;
                decimal totalPOSubtotalQty = 0;
                decimal totalPOSubtotalAmount = 0;

                decimal totalDamagedStockWH = 0;
                decimal totalDamagedStockWHAmount = 0;
                decimal totalExpiredStockWH = 0;
                decimal totalExpiredStockWHAmount = 0;
                decimal totalMissingStockWH = 0;
                decimal totalMissingStockWHAmount = 0;
                decimal totalGlobalShortageOS = 0;
                decimal totalGlobalShortageOSAmount = 0;
                decimal totalInventoryAdjustment = 0;
                decimal totalInventoryAdjustmentAmount = 0;
                decimal totalPhysicalInvCountNJ = 0;
                decimal totalPhysicalInvCountNJAmount = 0;
                decimal totalPhysicalInvCountNY = 0;
                decimal totalPhysicalInvCountNYAmount = 0;
                decimal totalRodentDamage = 0;
                decimal totalRodentDamageAmount = 0;
                decimal totalRepack = 0;
                decimal totalRepackAmount = 0;
                decimal totalWarehouseSubtotalQty = 0;
                decimal totalWarehouseSubtotalAmount = 0;

                decimal totalDamagedStockSA = 0;
                decimal totalDamagedStockSAAmount = 0;
                decimal totalExpiredStockSA = 0;
                decimal totalExpiredStockSAAmount = 0;
                decimal totalMissingStockSA = 0;
                decimal totalMissingStockSAAmount = 0;
                decimal totalSample = 0;
                decimal totalSampleAmount = 0;
                decimal totalSalesSubtotalQty = 0;
                decimal totalSalesSubtotalAmount = 0;

                decimal totalDamagedStockDR = 0;
                decimal totalDamagedStockDRAmount = 0;
                decimal totalExpiredStockDR = 0;
                decimal totalExpiredStockDRAmount = 0;
                decimal totalMissingStockDR = 0;
                decimal totalMissingStockDRAmount = 0;
                decimal totalDriverSubtotalQty = 0;
                decimal totalDriverSubtotalAmount = 0;

                decimal totalMealForEmployees = 0;
                decimal totalMealForEmployeesAmount = 0;
                decimal totalDamagedStockForSale = 0;
                decimal totalDamagedStockForSaleAmount = 0;
                decimal totalExpiredStockForSale = 0;
                decimal totalExpiredStockForSaleAmount = 0;
                decimal totalDonation = 0;
                decimal totalDonationAmount = 0;
                decimal totalMiscellaneous = 0;
                decimal totalMiscellaneousAmount = 0;
                decimal totalManagementSubtotalQty = 0;
                decimal totalManagementSubtotalAmount = 0;

                decimal totalNonCategoryQty = 0;
                decimal totalNonCategoryAmount = 0;

                decimal totalTotalQty = 0;
                decimal totalTotalAmount = 0;


                for (int i = 0; i < grid_report.RowCount; i++)
                {
                    totalDamagedStockPO += Convert.ToDecimal(grid_report.Rows[i].Cells["Damaged Stock PO"].Value);
                    totalDamagedStockPOAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Damaged Stock PO Amount"].Value);
                    totalExpiredStockPO += Convert.ToDecimal(grid_report.Rows[i].Cells["Expired Stock PO"].Value);
                    totalExpiredStockPOAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Expired Stock PO Amount"].Value);
                    totalPOCredit += Convert.ToDecimal(grid_report.Rows[i].Cells["PO Credit"].Value);
                    totalPOCreditAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["PO Credit Amount"].Value);
                    totalSubcontractDiffernce += Convert.ToDecimal(grid_report.Rows[i].Cells["Subcontract Differnce"].Value);
                    totalSubcontractDiffernceAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Subcontract Differnce Amount"].Value);
                    totalDataEntryMistakes += Convert.ToDecimal(grid_report.Rows[i].Cells["Data Entry Mistakes"].Value);
                    totalDataEntryMistakesAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Data Entry Mistakes Amount"].Value);
                    totalWrongReceiving += Convert.ToDecimal(grid_report.Rows[i].Cells["Wrong Receiving"].Value);
                    totalWrongReceivingAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Wrong Receiving Amount"].Value);
                    totalFreeGoods += Convert.ToDecimal(grid_report.Rows[i].Cells["Free Goods"].Value);
                    totalFreeGoodsAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Free Goods Amount"].Value);
                    totalPOSubtotalQty += Convert.ToDecimal(grid_report.Rows[i].Cells["PO Subtotal Qty"].Value);
                    totalPOSubtotalAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["PO Subtotal Amount"].Value);

                    totalDamagedStockWH += Convert.ToDecimal(grid_report.Rows[i].Cells["Damaged Stock WH"].Value);
                    totalDamagedStockWHAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Damaged Stock WH Amount"].Value);
                    totalExpiredStockWH += Convert.ToDecimal(grid_report.Rows[i].Cells["Expired Stock WH"].Value);
                    totalExpiredStockWHAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Expired Stock WH Amount"].Value);
                    totalMissingStockWH += Convert.ToDecimal(grid_report.Rows[i].Cells["Missing Stock WH"].Value);
                    totalMissingStockWHAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Missing Stock WH Amount"].Value);
                    totalGlobalShortageOS += Convert.ToDecimal(grid_report.Rows[i].Cells["Global Shortage OS"].Value);
                    totalGlobalShortageOSAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Global Shortage OS Amount"].Value);
                    totalInventoryAdjustment += Convert.ToDecimal(grid_report.Rows[i].Cells["Inventory Adjustment"].Value);
                    totalInventoryAdjustmentAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Inventory Adjustment Amount"].Value);
                    totalPhysicalInvCountNJ += Convert.ToDecimal(grid_report.Rows[i].Cells["Physical Inv Count NJ"].Value);
                    totalPhysicalInvCountNJAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Physical Inv Count NJ Amount"].Value);
                    totalPhysicalInvCountNY += Convert.ToDecimal(grid_report.Rows[i].Cells["Physical Inv Count NY"].Value);
                    totalPhysicalInvCountNYAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Physical Inv Count NY Amount"].Value);
                    totalRodentDamage += Convert.ToDecimal(grid_report.Rows[i].Cells["Rodent Damage"].Value);
                    totalRodentDamageAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Rodent Damage Amount"].Value);
                    totalRepack += Convert.ToDecimal(grid_report.Rows[i].Cells["Repack"].Value);
                    totalRepackAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Repack Amount"].Value);
                    totalWarehouseSubtotalQty += Convert.ToDecimal(grid_report.Rows[i].Cells["Warehouse Subtotal Qty"].Value);
                    totalWarehouseSubtotalAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Warehouse Subtotal Amount"].Value);

                    totalDamagedStockSA += Convert.ToDecimal(grid_report.Rows[i].Cells["Damaged Stock SA"].Value);
                    totalDamagedStockSAAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Damaged Stock SA Amount"].Value);
                    totalExpiredStockSA += Convert.ToDecimal(grid_report.Rows[i].Cells["Expired Stock SA"].Value);
                    totalExpiredStockSAAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Expired Stock SA Amount"].Value);
                    totalMissingStockSA += Convert.ToDecimal(grid_report.Rows[i].Cells["Missing Stock SA"].Value);
                    totalMissingStockSAAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Missing Stock SA Amount"].Value);
                    totalSample += Convert.ToDecimal(grid_report.Rows[i].Cells["Sample"].Value);
                    totalSampleAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Sample Amount"].Value);
                    totalSalesSubtotalQty += Convert.ToDecimal(grid_report.Rows[i].Cells["Sales Subtotal Qty"].Value);
                    totalSalesSubtotalAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Sales Subtotal Amount"].Value);

                    totalDamagedStockDR += Convert.ToDecimal(grid_report.Rows[i].Cells["Damaged Stock DR"].Value);
                    totalDamagedStockDRAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Damaged Stock DR Amount"].Value);
                    totalExpiredStockDR += Convert.ToDecimal(grid_report.Rows[i].Cells["Expired Stock DR"].Value);
                    totalExpiredStockDRAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Expired Stock DR Amount"].Value);
                    totalMissingStockDR += Convert.ToDecimal(grid_report.Rows[i].Cells["Missing Stock DR"].Value);
                    totalMissingStockDRAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Missing Stock DR Amount"].Value);
                    totalDriverSubtotalQty += Convert.ToDecimal(grid_report.Rows[i].Cells["Driver Subtotal Qty"].Value);
                    totalDriverSubtotalAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Driver Subtotal Amount"].Value);

                    totalMealForEmployees += Convert.ToDecimal(grid_report.Rows[i].Cells["Meal For Employees"].Value);
                    totalMealForEmployeesAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Meal For Employees Amount"].Value);
                    totalDamagedStockForSale += Convert.ToDecimal(grid_report.Rows[i].Cells["Damaged Stock For Sale"].Value);
                    totalDamagedStockForSaleAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Damaged Stock For Sale Amount"].Value);
                    totalExpiredStockForSale += Convert.ToDecimal(grid_report.Rows[i].Cells["Expired Stock For Sale"].Value);
                    totalExpiredStockForSaleAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Expired Stock For Sale Amount"].Value);
                    totalDonation += Convert.ToDecimal(grid_report.Rows[i].Cells["Donation"].Value);
                    totalDonationAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Donation Amount"].Value);
                    totalMiscellaneous += Convert.ToDecimal(grid_report.Rows[i].Cells["Miscellaneous"].Value);
                    totalMiscellaneousAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Miscellaneous Amount"].Value);
                    totalManagementSubtotalQty += Convert.ToDecimal(grid_report.Rows[i].Cells["Management Subtotal Qty"].Value);
                    totalManagementSubtotalAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Management Subtotal Amount"].Value);

                    totalNonCategoryQty += Convert.ToDecimal(grid_report.Rows[i].Cells["Non Category Qty"].Value);
                    totalNonCategoryAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Non Category Amount"].Value);

                    totalTotalQty += Convert.ToDecimal(grid_report.Rows[i].Cells["Total Qty"].Value);
                    totalTotalAmount += Convert.ToDecimal(grid_report.Rows[i].Cells["Total Amount"].Value);
                }

                DataRow drToAdd = dataTable.NewRow();
                drToAdd["Month"] = "Total";
                drToAdd["Year"] = "";
                drToAdd["DamagedStockPO"] = totalDamagedStockPO.ToString();
                drToAdd["DamagedStockPOAmount"] = totalDamagedStockPOAmount.ToString();
                drToAdd["ExpiredStockPO"] = totalExpiredStockPO.ToString();
                drToAdd["ExpiredStockPOAmount"] = totalExpiredStockPOAmount.ToString();
                drToAdd["POCredit"] = totalPOCredit.ToString();
                drToAdd["POCreditAmount"] = totalPOCreditAmount.ToString();
                drToAdd["SubcontractDiffernce"] = totalSubcontractDiffernce.ToString();
                drToAdd["SubcontractDiffernceAmount"] = totalSubcontractDiffernceAmount.ToString();
                drToAdd["DataEntryMistakes"] = totalDataEntryMistakes.ToString();
                drToAdd["DataEntryMistakesAmount"] = totalDataEntryMistakesAmount.ToString();
                drToAdd["WrongReceiving"] = totalWrongReceiving.ToString();
                drToAdd["WrongReceivingAmount"] = totalWrongReceivingAmount.ToString();
                drToAdd["FreeGoods"] = totalFreeGoods.ToString();
                drToAdd["FreeGoodsAmount"] = totalFreeGoodsAmount.ToString();
                drToAdd["POSubtotalQty"] = totalPOSubtotalQty.ToString();
                drToAdd["POSubtotalAmount"] = totalPOSubtotalAmount.ToString();

                drToAdd["DamagedStockWH"] = totalDamagedStockWH.ToString();
                drToAdd["DamagedStockWHAmount"] = totalDamagedStockWHAmount.ToString();
                drToAdd["ExpiredStockWH"] = totalExpiredStockWH.ToString();
                drToAdd["ExpiredStockWHAmount"] = totalExpiredStockWHAmount.ToString();
                drToAdd["MissingStockWH"] = totalMissingStockWH.ToString();
                drToAdd["MissingStockWHAmount"] = totalMissingStockWHAmount.ToString();
                drToAdd["GlobalShortageOS"] = totalGlobalShortageOS.ToString();
                drToAdd["GlobalShortageOSAmount"] = totalGlobalShortageOSAmount.ToString();
                drToAdd["InventoryAdjustment"] = totalInventoryAdjustment.ToString();
                drToAdd["InventoryAdjustmentAmount"] = totalInventoryAdjustmentAmount.ToString();
                drToAdd["PhysicalInvCountNJ"] = totalPhysicalInvCountNJ.ToString();
                drToAdd["PhysicalInvCountNJAmount"] = totalPhysicalInvCountNJAmount.ToString();
                drToAdd["PhysicalInvCountNY"] = totalPhysicalInvCountNY.ToString();
                drToAdd["PhysicalInvCountNYAmount"] = totalPhysicalInvCountNYAmount.ToString();
                drToAdd["RodentDamage"] = totalRodentDamage.ToString();
                drToAdd["RodentDamageAmount"] = totalRodentDamageAmount.ToString();
                drToAdd["Repack"] = totalRepack.ToString();
                drToAdd["RepackAmount"] = totalRepackAmount.ToString();
                drToAdd["WarehouseSubtotalQty"] = totalWarehouseSubtotalQty.ToString();
                drToAdd["WarehouseSubtotalAmount"] = totalWarehouseSubtotalAmount.ToString();

                drToAdd["DamagedStockSA"] = totalDamagedStockSA.ToString();
                drToAdd["DamagedStockSAAmount"] = totalDamagedStockSAAmount.ToString();
                drToAdd["ExpiredStockSA"] = totalExpiredStockSA.ToString();
                drToAdd["ExpiredStockSAAmount"] = totalExpiredStockSAAmount.ToString();
                drToAdd["MissingStockSA"] = totalMissingStockSA.ToString();
                drToAdd["MissingStockSAAmount"] = totalMissingStockSAAmount.ToString();
                drToAdd["Sample"] = totalSample.ToString();
                drToAdd["SampleAmount"] = totalSampleAmount.ToString();
                drToAdd["SalesSubtotalQty"] = totalSalesSubtotalQty.ToString();
                drToAdd["SalesSubtotalAmount"] = totalSalesSubtotalAmount.ToString();

                drToAdd["DamagedStockDR"] = totalDamagedStockDR.ToString();
                drToAdd["DamagedStockDRAmount"] = totalDamagedStockDRAmount.ToString();
                drToAdd["ExpiredStockDR"] = totalExpiredStockDR.ToString();
                drToAdd["ExpiredStockDRAmount"] = totalExpiredStockDRAmount.ToString();
                drToAdd["MissingStockDR"] = totalMissingStockDR.ToString();
                drToAdd["MissingStockDRAmount"] = totalMissingStockDRAmount.ToString();
                drToAdd["DriverSubtotalQty"] = totalDriverSubtotalQty.ToString();
                drToAdd["DriverSubtotalAmount"] = totalDriverSubtotalAmount.ToString();

                drToAdd["MealForEmployees"] = totalMealForEmployees.ToString();
                drToAdd["MealForEmployeesAmount"] = totalMealForEmployeesAmount.ToString();
                drToAdd["DamagedStockForSale"] = totalDamagedStockForSale.ToString();
                drToAdd["DamagedStockForSaleAmount"] = totalDamagedStockForSaleAmount.ToString();
                drToAdd["ExpiredStockForSale"] = totalExpiredStockForSale.ToString();
                drToAdd["ExpiredStockForSaleAmount"] = totalExpiredStockForSaleAmount.ToString();
                drToAdd["Donation"] = totalDonation.ToString();
                drToAdd["DonationAmount"] = totalDonationAmount.ToString();
                drToAdd["Miscellaneous"] = totalMiscellaneous.ToString();
                drToAdd["MiscellaneousAmount"] = totalMiscellaneousAmount.ToString();
                drToAdd["ManagementSubtotalQty"] = totalManagementSubtotalQty.ToString();
                drToAdd["ManagementSubtotalAmount"] = totalManagementSubtotalAmount.ToString();

                drToAdd["NonCategoryQty"] = totalNonCategoryQty.ToString();
                drToAdd["NonCategoryAmount"] = totalNonCategoryAmount.ToString();

                drToAdd["TotalQty"] = totalTotalQty.ToString();
                drToAdd["TotalAmount"] = totalTotalAmount.ToString();

                dataTable.Rows.Add(drToAdd);

                dataTable.AcceptChanges();

                this.grid_report.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void grid_report_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.grid_report.Rows)
            {
                if (row.Cells["Month"].Value.Equals("Total"))
                {
                    for (int i = 0; i < grid_report.ColumnCount; i++)
                    {
                        row.Cells[i].Style.BackColor = Color.Gray;
                        row.Cells[i].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            String type = "";
            if (rbtn_issue.Checked)
            {
                type = "Issue";
            }
            else if (rbtn_receipt.Checked)
            {
                type = "Receipt";
            }
            else if (rbtn_issueAndReceipt.Checked)
            {
                type = "All";
            }
            Reports.Rpt_InventoryMiscellaneousTransactionReport commission = new Reports.Rpt_InventoryMiscellaneousTransactionReport(FromDate, ToDate, type);
            commission.Show();
        }
    }
}
