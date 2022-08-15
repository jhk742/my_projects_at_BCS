using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.mWMS
{
    public partial class wms_receiptReturn : Form
    {
        public wms_receiptReturn()
        {
            InitializeComponent();

            grid_detail_Init();

            connPO.cbox_getVendorID(cbo_supplierID);
            connSalesOrder.sp_WMS_RECEIPTRETURN_SELECT(grid_detail);
        }

        private void grid_detail_Init()
        {
            grid_detail.AutoGenerateColumns = false;
            grid_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_detail.ColumnCount = 6;

            grid_detail.Columns[0].Name = "LOT No.";
            grid_detail.Columns[0].ReadOnly = true;
            grid_detail.Columns[0].MinimumWidth = 100;
            grid_detail.Columns[0].Width = 100;
            grid_detail.Columns[0].DataPropertyName = "LOTNumber";

            grid_detail.Columns[1].Name = "Product ID";
            grid_detail.Columns[1].ReadOnly = true;
            grid_detail.Columns[1].MinimumWidth = 80;
            grid_detail.Columns[1].Width = 80;
            grid_detail.Columns[1].DataPropertyName = "ProductID";

            grid_detail.Columns[2].Name = "Available Qty.";
            grid_detail.Columns[2].ReadOnly = true;
            grid_detail.Columns[2].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[2].MinimumWidth = 50;
            grid_detail.Columns[2].Width = 50;
            grid_detail.Columns[2].DataPropertyName = "AvailableQty";

            grid_detail.Columns[3].Name = "Return Qty.";
            grid_detail.Columns[3].ReadOnly = true;
            grid_detail.Columns[3].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[3].MinimumWidth = 50;
            grid_detail.Columns[3].Width = 50;
            grid_detail.Columns[3].DataPropertyName = "ReturnQty";
            
            grid_detail.Columns[4].Name = "Price";
            grid_detail.Columns[4].ReadOnly = true;
            grid_detail.Columns[4].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[4].MinimumWidth = 50;
            grid_detail.Columns[4].Width = 50;
            grid_detail.Columns[4].DataPropertyName = "Price";

            grid_detail.Columns[5].Name = "Amount";
            grid_detail.Columns[5].ReadOnly = true;
            grid_detail.Columns[5].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].MinimumWidth = 50;
            grid_detail.Columns[5].Width = 50;
            grid_detail.Columns[5].DataPropertyName = "Amount";

            //grid font size custom
            grid_detail.RowTemplate.Height = 20;
            grid_detail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_detail.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_detail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_detail_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String LOTNumber = grid_detail.Rows[e.RowIndex].Cells["LOT No."].Value.ToString().Trim();
            String ProductID = grid_detail.Rows[e.RowIndex].Cells["Product ID"].Value.ToString().Trim();
            Decimal AvailableQty = Convert.ToDecimal(grid_detail.Rows[e.RowIndex].Cells["Available Qty."].Value.ToString().Trim());
            Decimal ReturnQty = Convert.ToDecimal(grid_detail.Rows[e.RowIndex].Cells["Return Qty."].Value.ToString().Trim());
            Decimal Price = Convert.ToDecimal(grid_detail.Rows[e.RowIndex].Cells["Price"].Value.ToString().Trim());
            Decimal Amount = Convert.ToDecimal(grid_detail.Rows[e.RowIndex].Cells["Amount"].Value.ToString().Trim());

            txt_productID.Text = ProductID;
            txt_LOTNumber.Text = LOTNumber;
            String ProductDesc = connSalesOrder.getItemDescFromItemID(ProductID);
            txt_productDesc.Text = ProductDesc;
            txt_availableQty.Text = AvailableQty.ToString("N2");
            txt_returnQty.Text = ReturnQty.ToString("N2");
            txt_price.Text = Price.ToString("N2");
            txt_amount.Text = Amount.ToString("N2");
        }


        private void changeReturnQty()
        {
            Decimal Amount = 0;
            try
            {
                Decimal AvailableQty = Convert.ToDecimal(txt_availableQty.Text.Trim());
                Decimal ReturnQty = Convert.ToDecimal(txt_returnQty.Text.Trim());
                if(ReturnQty > AvailableQty)
                {
                    txt_returnQty.Text = AvailableQty.ToString("N2");
                    ReturnQty = Convert.ToDecimal(txt_returnQty.Text.Trim());
                }
                Decimal Price = Convert.ToDecimal(txt_price.Text.Trim());

                Amount = ReturnQty * Price;
                txt_amount.Text = Amount.ToString("N2");
            }
            catch
            {
                MessageBox.Show("Please enter valid value."
                                                        , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_returnQty.Text = txt_availableQty.Text.ToString();

                Decimal ReturnQty = Convert.ToDecimal(txt_returnQty.Text.Trim());
                Decimal Price = Convert.ToDecimal(txt_price.Text.Trim());

                Amount = ReturnQty * Price;
                txt_amount.Text = Amount.ToString("N2");
            }
        }

        private void txt_returnQty_Leave(object sender, EventArgs e)
        {
            changeReturnQty();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (cbo_supplierID.Text.Trim() == "")
            {
                MessageBox.Show("Please select supplier ID."
                                                , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure confirm the receipt return process?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                String NewBCSPRNNumber = connSalesOrder.sp_GET_NewBCSPRNNumber();
                String NewSTKNumber = connSalesOrder.sp_GET_NewSTKNumber();
                if (!NewSTKNumber.Contains("STK"))
                {
                    MessageBox.Show("Please try again.(STK) (Error code: " + NewSTKNumber + ")"
                                                    , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                String SupplierID = cbo_supplierID.Text.Trim();

                String LOTNumber = txt_LOTNumber.Text.Trim();
                String ProductID = txt_productID.Text.Trim();

                Decimal Qty = Convert.ToDecimal(txt_returnQty.Text.Trim());
                Decimal Price = Convert.ToDecimal(txt_price.Text.Trim());
                Decimal Amount = Convert.ToDecimal(txt_amount.Text.Trim());

                //sp_RECEIPTRETURN_INSERT_STOJOU
                connSalesOrder.sp_RECEIPTRETURN_INSERT_STOJOU(NewBCSPRNNumber,NewSTKNumber, "BIC", "BCS" ,SupplierID, LOTNumber, ProductID, Qty, 1,"");

                connSalesOrder.sp_WMS_RECEIPTRETURN_SELECT(grid_detail);

                MessageBox.Show("Successfully saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
