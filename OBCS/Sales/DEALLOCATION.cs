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
    public partial class DEALLOCATION : Form
    {
        public DEALLOCATION()
        {
            InitializeComponent();
            grid_deallocation_Init();
        }

        private void grid_deallocation_Init()
        {
            grid_deallocation.AutoGenerateColumns = false;
            grid_deallocation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_deallocation.ColumnCount = 6;

            grid_deallocation.Columns[0].Name = "Date";
            grid_deallocation.Columns[0].ReadOnly = true;
            grid_deallocation.Columns[0].Width = 80;
            grid_deallocation.Columns[0].MinimumWidth = 80;
            grid_deallocation.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_deallocation.Columns[0].DataPropertyName = "CreateTime";
            grid_deallocation.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_deallocation.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_deallocation.Columns[1].Name = "Customer";
            grid_deallocation.Columns[1].ReadOnly = true;
            grid_deallocation.Columns[1].Width = 120;
            grid_deallocation.Columns[1].MinimumWidth = 120;
            grid_deallocation.Columns[1].DataPropertyName = "CustomerID";


            grid_deallocation.Columns[2].Name = "Order No.";
            grid_deallocation.Columns[2].ReadOnly = true;
            grid_deallocation.Columns[2].Width = 100;
            grid_deallocation.Columns[2].MinimumWidth = 100;
            grid_deallocation.Columns[2].DataPropertyName = "OrderID";

            
            grid_deallocation.Columns[3].Name = "Picking No.";
            grid_deallocation.Columns[3].ReadOnly = true;
            grid_deallocation.Columns[3].Width = 450;
            grid_deallocation.Columns[3].MinimumWidth = 450;
            grid_deallocation.Columns[3].DataPropertyName = "PickingNumber";
            grid_deallocation.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_deallocation.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_deallocation.Columns[4].Name = "Delivery No.";
            grid_deallocation.Columns[4].ReadOnly = true;
            grid_deallocation.Columns[4].Width = 120;
            grid_deallocation.Columns[4].MinimumWidth = 120;
            grid_deallocation.Columns[4].DataPropertyName = "DeliveryNumber";
            
            grid_deallocation.Columns[5].Name = "Invoice No.";
            grid_deallocation.Columns[5].ReadOnly = true;
            grid_deallocation.Columns[5].Width = 100;
            grid_deallocation.Columns[5].MinimumWidth = 100;
            grid_deallocation.Columns[5].DataPropertyName = "InvoiceNumber";

            
            DataGridViewButtonColumn deallocationButton = new DataGridViewButtonColumn();
            deallocationButton.Width = 50;
            deallocationButton.MinimumWidth = 50;
            deallocationButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deallocationButton.Name = "Delete";
            deallocationButton.Text = "Delete";
            deallocationButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deallocationButton.UseColumnTextForButtonValue = true;
            if (grid_deallocation.Columns["Delete"] == null)

            {
                grid_deallocation.Columns.Insert(6, deallocationButton);
            }

            //grid font size custom
            grid_deallocation.RowTemplate.Height = 20;
            grid_deallocation.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_deallocation.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_deallocation.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void rbtn_all_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void rbtn_invoice_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void rbtn_noInvoice_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            string CustomerID = txt_CustomerID.Text.Trim();
            string DeliveryNo = txt_DeliveryNumber.Text.Trim();
            if (rbtn_all.Checked)
            {
                connSalesOrder.sp_DEALLOCATION_SELECT(grid_deallocation, "", CustomerID, DeliveryNo);
            }
            else if (rbtn_invoice.Checked)
            {
                connSalesOrder.sp_DEALLOCATION_SELECT(grid_deallocation, "Invoice", CustomerID, DeliveryNo);
            }
            else if (rbtn_noInvoice.Checked)
            {
                connSalesOrder.sp_DEALLOCATION_SELECT(grid_deallocation, "No Invoice", CustomerID, DeliveryNo);
            }
        }

        private void grid_deallocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6) // Delete button
                {
                    if (grid_deallocation.Rows[e.RowIndex].Cells["Order No."].Value.ToString() == "")
                    {
                        MessageBox.Show("Cannot process.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    if (grid_deallocation.Rows[e.RowIndex].Cells["Invoice No."].Value.ToString() != "")
                    {
                        MessageBox.Show("This order number has already finished the invoice process and can not be deallocated.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    DialogResult dialogResult = MessageBox.Show("Are you sure delete all of these reference numbers and deallocate?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        String OrderID = grid_deallocation.Rows[e.RowIndex].Cells["Order No."].Value.ToString();

                        if (grid_deallocation.Rows[e.RowIndex].Cells["Delivery No."].Value.ToString() == "")
                        {
                            if (grid_deallocation.Rows[e.RowIndex].Cells["Picking No."].Value.ToString() == "")
                            {
                                connSalesOrder.sp_DEALLOCATION_ORDER(OrderID);
                            }
                            else
                            {
                                connSalesOrder.sp_DEALLOCATION_PICKTICKET(OrderID);
                            }
                        }
                        else
                        {
                            connSalesOrder.sp_DEALLOCATION_DELIVERYNOTE(OrderID);
                        }

                        //if (rbtn_all.Checked)
                        //{
                        //    connSalesOrder.sp_DEALLOCATION_SELECT(grid_deallocation, "");
                        //}
                        //else if (rbtn_invoice.Checked)
                        //{
                        //    connSalesOrder.sp_DEALLOCATION_SELECT(grid_deallocation, "Invoice");
                        //}
                        //else if (rbtn_noInvoice.Checked)
                        //{
                        //    connSalesOrder.sp_DEALLOCATION_SELECT(grid_deallocation, "No Invoice");
                        //}
                        grid_deallocation.Rows.RemoveAt(e.RowIndex);

                    }
                }
            }
            catch
            {

            }
            
            
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                refresh();
            }
        }
    }
}
