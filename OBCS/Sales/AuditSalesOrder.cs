using OBCS.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OBCS.conn;

namespace OBCS.Sales

{
    public partial class AuditSalesOrder : Form
    {
        public AuditSalesOrder()
        {
            InitializeComponent();

            //detail grid multi line allow
            grid_salesOrder.AllowDrop = true;
            grid_salesOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_salesOrder.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            grid_salesOrder_Init();

            dateTimePickerFrom.Value = DateTime.Today.AddDays(-7);
            salesOrder_refresh();
        }

        private void grid_salesOrder_Init()
        {
            grid_salesOrder.AutoGenerateColumns = false;
            grid_salesOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //DoubleBuffered = true;

            //grid_salesOrder.RowHeadersWidth = 40;

            grid_salesOrder.ColumnCount = 11;

            grid_salesOrder.Columns[0].Name = "No.";
            grid_salesOrder.Columns[0].ReadOnly = true;
            grid_salesOrder.Columns[0].Width = 40;
            grid_salesOrder.Columns[0].DataPropertyName = "";

            grid_salesOrder.Columns[1].Name = "iPad Order ID";
            if (GATE.userID == "ADMIN")
                grid_salesOrder.Columns[1].ReadOnly = false;
            else
                grid_salesOrder.Columns[1].ReadOnly = true;
            grid_salesOrder.Columns[1].Width = 270;
            grid_salesOrder.Columns[1].DataPropertyName = "OrderID";

            grid_salesOrder.Columns[2].Name = "Branch";
            grid_salesOrder.Columns[2].ReadOnly = true;
            grid_salesOrder.Columns[2].Width = 50;
            grid_salesOrder.Columns[2].DataPropertyName = "Branch";

            grid_salesOrder.Columns[3].Name = "Customer ID";
            grid_salesOrder.Columns[3].ReadOnly = true;
            grid_salesOrder.Columns[3].Width = 100;
            grid_salesOrder.Columns[3].DataPropertyName = "CustomerID";

            grid_salesOrder.Columns[4].Name = "Sales Rep.";
            grid_salesOrder.Columns[4].ReadOnly = true;
            grid_salesOrder.Columns[4].Width = 70;
            grid_salesOrder.Columns[4].DataPropertyName = "SaleRepID";

            grid_salesOrder.Columns[5].Name = "Order Date";
            grid_salesOrder.Columns[5].ReadOnly = true;
            grid_salesOrder.Columns[5].Width = 130;
            grid_salesOrder.Columns[5].DefaultCellStyle.Format = "MM'/'dd'/'yyyy hh:mm:ss tt";
            grid_salesOrder.Columns[5].DataPropertyName = "OrderDate";

            grid_salesOrder.Columns[6].Name = "Status";
            grid_salesOrder.Columns[6].Visible = false;
            grid_salesOrder.Columns[6].Width = 50;
            grid_salesOrder.Columns[6].DataPropertyName = "";

            grid_salesOrder.Columns[7].Name = "Printed";
            grid_salesOrder.Columns[7].Visible = false;
            grid_salesOrder.Columns[7].Width = 50;
            grid_salesOrder.Columns[7].DataPropertyName = "";

            grid_salesOrder.Columns[8].Name = "Amount";
            grid_salesOrder.Columns[8].ReadOnly = true;
            grid_salesOrder.Columns[8].Width = 70;
            grid_salesOrder.Columns[8].DefaultCellStyle.Format = "C2"; //"$#,##0.00";
            grid_salesOrder.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesOrder.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesOrder.Columns[8].DataPropertyName = "Amount";

            grid_salesOrder.Columns[9].Name = "Credit";
            grid_salesOrder.Columns[9].ReadOnly = true;
            grid_salesOrder.Columns[9].Width = 60;
            grid_salesOrder.Columns[9].DefaultCellStyle.Format = "C2";
            grid_salesOrder.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesOrder.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_salesOrder.Columns[9].DataPropertyName = "CrAmt";

            grid_salesOrder.Columns[10].Name = "Memo";
            grid_salesOrder.Columns[10].ReadOnly = true;
            grid_salesOrder.Columns[10].Width = 300;
            grid_salesOrder.Columns[10].DataPropertyName = "OrdMemo";

            //grid font size custom
            grid_salesOrder.RowTemplate.Height = 20;
            grid_salesOrder.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_salesOrder.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_salesOrder.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_salesOrder_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //번호매기기
            this.grid_salesOrder.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            salesOrder_refresh();
        }

        private void salesOrder_refresh()
        {
            DateTime FromDate = dateTimePickerFrom.Value.Date;
            DateTime ToDate = dateTimePickerTo.Value.Date;
            connSalesOrder.sp_Fetch_iPadSalesOrder(grid_salesOrder, FromDate, ToDate);

            grid_salesOrder.ClearSelection();
        }

        private void grid_salesOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // order id 잡고 있기
            String iPadOrderID = grid_salesOrder.Rows[e.RowIndex].Cells["iPad Order ID"].Value.ToString().Trim();

            using (AuditSalesOrderDetail auditSalesOrderDetail = new AuditSalesOrderDetail(iPadOrderID))
            {
                auditSalesOrderDetail.ShowDialog();
                if (auditSalesOrderDetail.finished == true)
                {
                    grid_salesOrder.Rows.RemoveAt(e.RowIndex);
                }
            }
            //salesOrder_refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        String SelectediPadOrderID = "";
        private void grid_salesOrder_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectediPadOrderID = grid_salesOrder.Rows[e.RowIndex].Cells["iPad Order ID"].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void grid_salesOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // prevent selecting next row when hitting enter key in datagridview
                try
                {
                    using (AuditSalesOrderDetail auditSalesOrderDetail = new AuditSalesOrderDetail(SelectediPadOrderID))
                    {
                        auditSalesOrderDetail.ShowDialog();
                        if (auditSalesOrderDetail.finished == true)
                        {
                            for (int i = 0; i < grid_salesOrder.Rows.Count; i++)
                            {
                                if (grid_salesOrder.Rows[i].Cells["iPad Order ID"].Value.ToString().Trim() == SelectediPadOrderID)
                                {
                                    grid_salesOrder.Rows.RemoveAt(i);
                                    return;
                                }
                            }
                        }
                    }
                }
                catch { }
            }
        }
    }
}
