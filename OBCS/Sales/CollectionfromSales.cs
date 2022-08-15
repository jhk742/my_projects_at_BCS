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
    public partial class CollectionfromSales : Form
    {
        public CollectionfromSales()
        {
            InitializeComponent();
            grid_ARCollectionHeader_Init();

            cbo_Salesrep.Items.Clear();
            cbo_Salesrep.Items.Add("");
            cbo_Salesrep.Items.Add("Mail");
            cbo_Salesrep.Items.Add("Vendor");
            connSalesOrder.sp_GET_SalesRep(cbo_Salesrep);

            dateTimePickerFrom.Value = DateTime.Today.AddDays(-1);
            dateTimePickerTo.Value = DateTime.Today;

            connSalesOrder.sp_ARCOLLECTION_HEADER(grid_ARCollectionHeader, dateTimePickerFrom.Value, dateTimePickerTo.Value,"");
        }
        private void grid_ARCollectionHeader_Init()
        {
            grid_ARCollectionHeader.AutoGenerateColumns = false;
            grid_ARCollectionHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_ARCollectionHeader.ColumnCount = 9;

            grid_ARCollectionHeader.Columns[0].Name = "ARCNumber";
            grid_ARCollectionHeader.Columns[0].ReadOnly = true;
            grid_ARCollectionHeader.Columns[0].Width = 50;
            grid_ARCollectionHeader.Columns[0].MinimumWidth = 50;
            grid_ARCollectionHeader.Columns[0].DataPropertyName = "ARCNumber";

            grid_ARCollectionHeader.Columns[1].Name = "SaleRep";
            grid_ARCollectionHeader.Columns[1].ReadOnly = true;
            grid_ARCollectionHeader.Columns[1].Width = 20;
            grid_ARCollectionHeader.Columns[1].MinimumWidth = 20;
            grid_ARCollectionHeader.Columns[1].DataPropertyName = "SaleRep";

            grid_ARCollectionHeader.Columns[2].Name = "CreateUser";
            grid_ARCollectionHeader.Columns[2].ReadOnly = true;
            grid_ARCollectionHeader.Columns[2].Width = 30;
            grid_ARCollectionHeader.Columns[2].MinimumWidth = 30;
            grid_ARCollectionHeader.Columns[2].DataPropertyName = "CreateUser";
            
            grid_ARCollectionHeader.Columns[3].Name = "CreateTime";
            grid_ARCollectionHeader.Columns[3].ReadOnly = true;
            grid_ARCollectionHeader.Columns[3].Width = 50;
            grid_ARCollectionHeader.Columns[3].MinimumWidth = 50;
            grid_ARCollectionHeader.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_ARCollectionHeader.Columns[3].DataPropertyName = "CreateTime";

            grid_ARCollectionHeader.Columns[4].Name = "EditUser";
            grid_ARCollectionHeader.Columns[4].ReadOnly = true;
            grid_ARCollectionHeader.Columns[4].Width = 30;
            grid_ARCollectionHeader.Columns[4].MinimumWidth = 30;
            grid_ARCollectionHeader.Columns[4].DataPropertyName = "EditUser";

            grid_ARCollectionHeader.Columns[5].Name = "LastEditTime";
            grid_ARCollectionHeader.Columns[5].ReadOnly = true;
            grid_ARCollectionHeader.Columns[5].Width = 50;
            grid_ARCollectionHeader.Columns[5].MinimumWidth = 50;
            grid_ARCollectionHeader.Columns[5].DataPropertyName = "LastEditTime";

            grid_ARCollectionHeader.Columns[6].Name = "CollectionStatus";
            grid_ARCollectionHeader.Columns[6].ReadOnly = true;
            grid_ARCollectionHeader.Columns[6].Width = 50;
            grid_ARCollectionHeader.Columns[6].MinimumWidth = 50;
            grid_ARCollectionHeader.Columns[6].DataPropertyName = "CollectionStatus";

            grid_ARCollectionHeader.Columns[7].Name = "Memo";
            grid_ARCollectionHeader.Columns[7].ReadOnly = true;
            grid_ARCollectionHeader.Columns[7].Width = 250;
            grid_ARCollectionHeader.Columns[7].MinimumWidth = 250;
            grid_ARCollectionHeader.Columns[7].DataPropertyName = "Memo";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 50;
            deleteButton.MinimumWidth = 50;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            //deleteButton.Visible = false;
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_ARCollectionHeader.Columns["Delete"] == null)
            {
                grid_ARCollectionHeader.Columns.Insert(8, deleteButton);
            }

            grid_ARCollectionHeader.Columns[9].Name = "id";
            grid_ARCollectionHeader.Columns[9].ReadOnly = true;
            grid_ARCollectionHeader.Columns[9].Visible = false;
            grid_ARCollectionHeader.Columns[9].Width = 10;
            grid_ARCollectionHeader.Columns[9].MinimumWidth = 10;
            grid_ARCollectionHeader.Columns[9].DataPropertyName = "id";

            //grid font size custom
            grid_ARCollectionHeader.RowTemplate.Height = 20;
            grid_ARCollectionHeader.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_ARCollectionHeader.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_ARCollectionHeader.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFrom.Value;
            DateTime ToDate = dateTimePickerTo.Value;
            String SaleRep = cbo_Salesrep.Text.ToString();
            connSalesOrder.sp_ARCOLLECTION_HEADER(grid_ARCollectionHeader,FromDate,ToDate,SaleRep);
        }

        private void btn_NewCollection_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CollectionfromSalesDetail))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            String ARCNumber = connSalesOrder.sp_ARCOLLECTION_GET_NewNumber();
            CollectionfromSalesDetail collectionfromSalesDetail = new CollectionfromSalesDetail("N", ARCNumber, "", DateTime.Today, "");
            collectionfromSalesDetail.Show();
        }
        private void grid_ARCollectionHeader_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                String ARCNumber = grid_ARCollectionHeader.Rows[e.RowIndex].Cells["ARCNumber"].Value.ToString();
                String SaleRep = grid_ARCollectionHeader.Rows[e.RowIndex].Cells["SaleRep"].Value.ToString();
                DateTime CreateTime = Convert.ToDateTime(grid_ARCollectionHeader.Rows[e.RowIndex].Cells["CreateTime"].Value);
                String Memo = grid_ARCollectionHeader.Rows[e.RowIndex].Cells["Memo"].Value.ToString();
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(CollectionfromSalesDetail))
                    {
                        form.Activate();
                        form.WindowState = FormWindowState.Normal;
                        form.BringToFront();
                        return;
                    }
                }
                CollectionfromSalesDetail collectionfromSalesDetail = new CollectionfromSalesDetail("O", ARCNumber,SaleRep, CreateTime, Memo);
                collectionfromSalesDetail.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void grid_ARCollectionHeader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 8 && e.RowIndex >= 0) // Delete button
                {
                    if(GATE.userID == "ADMIN")
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure delete item from this list?"
                                                            , "Confirming", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(grid_ARCollectionHeader.Rows[e.RowIndex].Cells["id"].Value.ToString().Trim());
                            String ARCNumber = grid_ARCollectionHeader.Rows[e.RowIndex].Cells["ARCNumber"].Value.ToString().Trim();
                            connSalesOrder.sp_ARCOLLECTION_DELETE_HEADER(ARCNumber, id);
                            connSalesOrder.sp_ARCOLLECTION_HEADER(grid_ARCollectionHeader, dateTimePickerFrom.Value, dateTimePickerTo.Value, cbo_Salesrep.Text);
                        }
                        else if (dialogResult == DialogResult.No) { }
                    }
                    else
                    {
                        MessageBox.Show("Contact IT Department to delete the AR Collection."
                                                            , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
