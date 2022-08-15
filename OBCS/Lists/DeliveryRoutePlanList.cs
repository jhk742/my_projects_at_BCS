using OBCS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Lists
{
    public partial class DeliveryRoutePlanList : Form
    {
        public DeliveryRoutePlanList()
        {
            InitializeComponent();
            grid_RoutePlan_Init();
            grid_RoutePlanDetail_Init();
            grid_address_Init();

            String RouteCode = cbo_SearchCode.Text.ToString();
            String RouteDay = cbo_SearchDay.Text.ToString();
            String RouteArea = cbo_SearchCity.Text.ToString();

            connSalesOrder.sp_RoutePlanHeader(grid_RoutePlan, RouteCode, RouteDay, RouteArea);
            connPO.cbox_getCustomerID(cbo_CustomerID);

            connSalesOrder.cbo_RouteCode(cbo_SearchCode);
            cbo_SearchCity.Items.Clear();
            //cbo_SearchCity.Items.Add("");
            connSalesOrder.cbo_RouteCity(cbo_SearchCity);
            cbo_HeaderCity.Items.Clear();
            connSalesOrder.cbo_RouteCity(cbo_HeaderCity);
            DaySetting();
        }

        private void grid_RoutePlan_Init()
        {
            grid_RoutePlan.AutoGenerateColumns = false;
            grid_RoutePlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_RoutePlan.ColumnCount = 11;

            grid_RoutePlan.Columns[0].Name = "id";
            grid_RoutePlan.Columns[0].Visible = false;
            grid_RoutePlan.Columns[0].Width = 80;
            grid_RoutePlan.Columns[0].MinimumWidth = 80;
            grid_RoutePlan.Columns[0].DataPropertyName = "id";

            grid_RoutePlan.Columns[1].Name = "Code";
            grid_RoutePlan.Columns[1].ReadOnly = true;
            grid_RoutePlan.Columns[1].Width = 25;
            grid_RoutePlan.Columns[1].MinimumWidth = 25;
            grid_RoutePlan.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlan.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlan.Columns[1].DataPropertyName = "RouteCode";

            grid_RoutePlan.Columns[2].Name = "Area";
            grid_RoutePlan.Columns[2].ReadOnly = true;
            grid_RoutePlan.Columns[2].Width = 60;
            grid_RoutePlan.Columns[2].MinimumWidth = 60;
            grid_RoutePlan.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlan.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlan.Columns[2].DataPropertyName = "RouteArea";

            grid_RoutePlan.Columns[3].Name = "Route Day";
            grid_RoutePlan.Columns[3].ReadOnly = true;
            grid_RoutePlan.Columns[3].Width = 40;
            grid_RoutePlan.Columns[3].MinimumWidth = 40;
            grid_RoutePlan.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlan.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlan.Columns[3].DataPropertyName = "RouteDay";

            grid_RoutePlan.Columns[4].Name = "RouteMemoCode";
            grid_RoutePlan.Columns[4].ReadOnly = true;
            grid_RoutePlan.Columns[4].Width = 60;
            grid_RoutePlan.Columns[4].MinimumWidth = 60;
            grid_RoutePlan.Columns[4].Visible = false;
            grid_RoutePlan.Columns[4].DataPropertyName = "RouteMemoCode";

            grid_RoutePlan.Columns[5].Name = "Memo";
            grid_RoutePlan.Columns[5].ReadOnly = true;
            grid_RoutePlan.Columns[5].Width = 100;
            grid_RoutePlan.Columns[5].MinimumWidth = 100;
            grid_RoutePlan.Columns[5].DataPropertyName = "RouteMemo";

            grid_RoutePlan.Columns[6].Name = "RouteMemo2";
            grid_RoutePlan.Columns[6].ReadOnly = true;
            grid_RoutePlan.Columns[6].Width = 75;
            grid_RoutePlan.Columns[6].MinimumWidth = 75;
            grid_RoutePlan.Columns[6].Visible = false;
            grid_RoutePlan.Columns[6].DataPropertyName = "RouteMemo2";

            grid_RoutePlan.Columns[7].Name = "Create User";
            grid_RoutePlan.Columns[7].ReadOnly = true;
            grid_RoutePlan.Columns[7].Width = 40;
            grid_RoutePlan.Columns[7].MinimumWidth = 40;
            grid_RoutePlan.Columns[7].Visible = false;
            grid_RoutePlan.Columns[7].DataPropertyName = "CreateUser";

            grid_RoutePlan.Columns[8].Name = "Create Date";
            grid_RoutePlan.Columns[8].ReadOnly = true;
            grid_RoutePlan.Columns[8].Width = 40;
            grid_RoutePlan.Columns[8].MinimumWidth = 40;
            grid_RoutePlan.Columns[8].Visible = false;
            grid_RoutePlan.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_RoutePlan.Columns[8].DataPropertyName = "CreateDate";

            grid_RoutePlan.Columns[9].Name = "Update User";
            grid_RoutePlan.Columns[9].ReadOnly = true;
            grid_RoutePlan.Columns[9].Width = 30;
            grid_RoutePlan.Columns[9].MinimumWidth = 30;
            grid_RoutePlan.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlan.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlan.Columns[9].DataPropertyName = "UpdateUser";

            grid_RoutePlan.Columns[10].Name = "Update Date";
            grid_RoutePlan.Columns[10].ReadOnly = true;
            grid_RoutePlan.Columns[10].Width = 70;
            grid_RoutePlan.Columns[10].MinimumWidth = 70;
            grid_RoutePlan.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlan.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlan.Columns[10].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_RoutePlan.Columns[10].DataPropertyName = "UpdateDate";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 60;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            //deleteButton.Visible = false;
            if (grid_RoutePlan.Columns["Delete"] == null)
            {
                grid_RoutePlan.Columns.Insert(11, deleteButton);
            }

            //grid font size custom
            grid_RoutePlan.RowTemplate.Height = 20;
            grid_RoutePlan.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_RoutePlan.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
                //c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            grid_RoutePlan.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void grid_RoutePlanDetail_Init()
        {
            //detail grid multi line allow
            grid_RoutePlanDetail.AllowDrop = true;
            //grid_RoutePlanDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //grid_RoutePlanDetail.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grid_RoutePlanDetail.AutoGenerateColumns = false;
            grid_RoutePlanDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_RoutePlanDetail.ColumnCount = 19;

            grid_RoutePlanDetail.Columns[0].Name = "id";
            grid_RoutePlanDetail.Columns[0].Visible = false;
            grid_RoutePlanDetail.Columns[0].Width = 80;
            grid_RoutePlanDetail.Columns[0].MinimumWidth = 80;
            grid_RoutePlanDetail.Columns[0].DataPropertyName = "id";

            grid_RoutePlanDetail.Columns[1].Name = "No.";
            grid_RoutePlanDetail.Columns[1].ReadOnly = true;
            grid_RoutePlanDetail.Columns[1].Width = 15;
            grid_RoutePlanDetail.Columns[1].MinimumWidth = 15;
            grid_RoutePlanDetail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlanDetail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlanDetail.Columns[1].DataPropertyName = "RouteStop";

            grid_RoutePlanDetail.Columns[2].Name = "Customer ID";
            grid_RoutePlanDetail.Columns[2].ReadOnly = true;
            grid_RoutePlanDetail.Columns[2].Width = 35;
            grid_RoutePlanDetail.Columns[2].MinimumWidth = 35;
            grid_RoutePlanDetail.Columns[2].DataPropertyName = "CustomerID";

            grid_RoutePlanDetail.Columns[3].Name = "CustomerName";
            grid_RoutePlanDetail.Columns[3].ReadOnly = true;
            grid_RoutePlanDetail.Columns[3].Visible = false;
            grid_RoutePlanDetail.Columns[3].Width = 300;
            grid_RoutePlanDetail.Columns[3].MinimumWidth = 300;
            grid_RoutePlanDetail.Columns[3].DataPropertyName = "CustomerName";

            grid_RoutePlanDetail.Columns[4].Name = "REP_0";
            grid_RoutePlanDetail.Columns[4].ReadOnly = true;
            grid_RoutePlanDetail.Columns[4].Width = 60;
            grid_RoutePlanDetail.Columns[4].Visible = false;
            grid_RoutePlanDetail.Columns[4].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[4].DataPropertyName = "REP_0";

            grid_RoutePlanDetail.Columns[5].Name = "ShipType";
            grid_RoutePlanDetail.Columns[5].ReadOnly = true;
            grid_RoutePlanDetail.Columns[5].Width = 80;
            grid_RoutePlanDetail.Columns[5].Visible = false;
            grid_RoutePlanDetail.Columns[5].MinimumWidth = 80;
            grid_RoutePlanDetail.Columns[5].DataPropertyName = "ShipType";

            grid_RoutePlanDetail.Columns[6].Name = "Address1";
            grid_RoutePlanDetail.Columns[6].ReadOnly = true;
            grid_RoutePlanDetail.Columns[6].Width = 90;
            grid_RoutePlanDetail.Columns[6].MinimumWidth = 90;
            grid_RoutePlanDetail.Columns[6].DataPropertyName = "Address1";

            grid_RoutePlanDetail.Columns[7].Name = "Address2";
            grid_RoutePlanDetail.Columns[7].ReadOnly = true;
            grid_RoutePlanDetail.Columns[7].Width = 75;
            grid_RoutePlanDetail.Columns[7].Visible = false;
            grid_RoutePlanDetail.Columns[7].MinimumWidth = 75;
            grid_RoutePlanDetail.Columns[7].DataPropertyName = "Address2";

            grid_RoutePlanDetail.Columns[8].Name = "PostalCode";
            grid_RoutePlanDetail.Columns[8].ReadOnly = true;
            grid_RoutePlanDetail.Columns[8].Width = 60;
            grid_RoutePlanDetail.Columns[8].Visible = false;
            grid_RoutePlanDetail.Columns[8].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[8].DataPropertyName = "PostalCode";

            grid_RoutePlanDetail.Columns[9].Name = "City";
            grid_RoutePlanDetail.Columns[9].ReadOnly = true;
            grid_RoutePlanDetail.Columns[9].Width = 60;
            grid_RoutePlanDetail.Columns[9].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[9].DataPropertyName = "City";

            grid_RoutePlanDetail.Columns[10].Name = "State";
            grid_RoutePlanDetail.Columns[10].ReadOnly = true;
            grid_RoutePlanDetail.Columns[10].Width = 25;
            grid_RoutePlanDetail.Columns[10].MinimumWidth = 25;
            grid_RoutePlanDetail.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlanDetail.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_RoutePlanDetail.Columns[10].DataPropertyName = "State";

            grid_RoutePlanDetail.Columns[11].Name = "Country";
            grid_RoutePlanDetail.Columns[11].ReadOnly = true;
            grid_RoutePlanDetail.Columns[11].Width = 60;
            grid_RoutePlanDetail.Columns[11].Visible = false;
            grid_RoutePlanDetail.Columns[11].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[11].DataPropertyName = "Country";

            grid_RoutePlanDetail.Columns[12].Name = "TEL_0";
            grid_RoutePlanDetail.Columns[12].ReadOnly = true;
            grid_RoutePlanDetail.Columns[12].Width = 60;
            grid_RoutePlanDetail.Columns[12].Visible = false;
            grid_RoutePlanDetail.Columns[12].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[12].DataPropertyName = "TEL_0";

            grid_RoutePlanDetail.Columns[13].Name = "TEL_1";
            grid_RoutePlanDetail.Columns[13].ReadOnly = true;
            grid_RoutePlanDetail.Columns[13].Width = 60;
            grid_RoutePlanDetail.Columns[13].Visible = false;
            grid_RoutePlanDetail.Columns[13].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[13].DataPropertyName = "TEL_1";

            grid_RoutePlanDetail.Columns[14].Name = "FAX_0";
            grid_RoutePlanDetail.Columns[14].ReadOnly = true;
            grid_RoutePlanDetail.Columns[14].Width = 60;
            grid_RoutePlanDetail.Columns[14].Visible = false;
            grid_RoutePlanDetail.Columns[14].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[14].DataPropertyName = "FAX_0";

            grid_RoutePlanDetail.Columns[15].Name = "MOB_0";
            grid_RoutePlanDetail.Columns[15].ReadOnly = true;
            grid_RoutePlanDetail.Columns[15].Width = 60;
            grid_RoutePlanDetail.Columns[15].Visible = false;
            grid_RoutePlanDetail.Columns[15].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[15].DataPropertyName = "MOB_0";

            grid_RoutePlanDetail.Columns[16].Name = "WEB_0";
            grid_RoutePlanDetail.Columns[16].ReadOnly = true;
            grid_RoutePlanDetail.Columns[16].Width = 60;
            grid_RoutePlanDetail.Columns[16].Visible = false;
            grid_RoutePlanDetail.Columns[16].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[16].DataPropertyName = "WEB_0";

            grid_RoutePlanDetail.Columns[17].Name = "Latitude";
            grid_RoutePlanDetail.Columns[17].ReadOnly = true;
            grid_RoutePlanDetail.Columns[17].Width = 60;
            grid_RoutePlanDetail.Columns[17].Visible = false;
            grid_RoutePlanDetail.Columns[17].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[17].DataPropertyName = "Latitude";

            grid_RoutePlanDetail.Columns[18].Name = "Longitude";
            grid_RoutePlanDetail.Columns[18].ReadOnly = true;
            grid_RoutePlanDetail.Columns[18].Width = 60;
            grid_RoutePlanDetail.Columns[18].Visible = false;
            grid_RoutePlanDetail.Columns[18].MinimumWidth = 60;
            grid_RoutePlanDetail.Columns[18].DataPropertyName = "Longitude";
            //grid_RoutePlanDetail.Columns[7].DefaultCellStyle.Format = "MM/dd/yyyy";
            //grid font size custom

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 60;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            //deleteButton.Visible = false;
            if (grid_RoutePlanDetail.Columns["Delete"] == null)
            {
                grid_RoutePlanDetail.Columns.Insert(19, deleteButton);
            }

            grid_RoutePlanDetail.RowTemplate.Height = 20;
            grid_RoutePlanDetail.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_RoutePlanDetail.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
                //c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            grid_RoutePlanDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void grid_address_Init()
        {
            grid_address.AutoGenerateColumns = false;
            grid_address.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_address.ColumnCount = 2;

            grid_address.Columns[0].Name = "ROWID";
            grid_address.Columns[0].Visible = false;
            grid_address.Columns[0].Width = 80;
            grid_address.Columns[0].MinimumWidth = 80;
            grid_address.Columns[0].DataPropertyName = "ROWID";

            grid_address.Columns[1].Name = "Address Code";
            grid_address.Columns[1].ReadOnly = true;
            grid_address.Columns[1].Width = 60;
            grid_address.Columns[1].MinimumWidth = 60;
            grid_address.Columns[1].DataPropertyName = "AddressCategory";

            //grid font size custom
            grid_address.RowTemplate.Height = 20;
            grid_address.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_address.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            grid_address.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void cbo_CustomerID_SelectedValueChanged(object sender, EventArgs e)
        {
            CustomerObject customerObject = new CustomerObject();

            String CustomerID = cbo_CustomerID.Text.ToString();
            customerObject = connSalesOrder.sp_GET_CustomerObject(CustomerID);

            txt_CustomerName.Text = customerObject.CustomerName;
            txt_CustomerMemo.Text = customerObject.CustomerMemo;
            txt_address1.Text = "";
            txt_address2.Text = "";
            txt_city.Text = "";
            txt_stateCode.Text = "";
            txt_postalCode.Text = "";
            txt_addressEmail.Text = "";
            txt_addressTel1.Text = "";
            txt_addressTel2.Text = "";
            txt_addressFax.Text = "";

            connPO.sp_LIST_AddressCategory(grid_address, cbo_CustomerID.Text.ToString());
        }

        private void grid_RoutePlan_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String id = grid_RoutePlan.Rows[e.RowIndex].Cells["id"].Value.ToString();
            String RouteCode = grid_RoutePlan.Rows[e.RowIndex].Cells["Code"].Value.ToString();
            String RouteDay = grid_RoutePlan.Rows[e.RowIndex].Cells["Route Day"].Value.ToString();
            String RouteArea = grid_RoutePlan.Rows[e.RowIndex].Cells["Area"].Value.ToString();
            String RouteMemo = grid_RoutePlan.Rows[e.RowIndex].Cells["Memo"].Value.ToString();

            txt_Headerid.Text = id;
            txt_HeaderCode.Text = RouteCode;
            cbo_HeaderDay.Text = RouteDay;
            cbo_HeaderCity.Text = RouteArea;
            txt_HeaderMemo.Text = RouteMemo;

            connSalesOrder.sp_RoutePlanDetail(grid_RoutePlanDetail, RouteCode);
            txt_RouteCode.Text = RouteCode;
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            String RouteCode = cbo_SearchCode.Text.ToString();
            String RouteDay = cbo_SearchDay.Text.ToString();
            String RouteArea = cbo_SearchCity.Text.ToString();

            connSalesOrder.sp_RoutePlanHeader(grid_RoutePlan, RouteCode, RouteDay, RouteArea);
        }

        private void grid_address_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_address1.Text = "";
            txt_address2.Text = "";
            txt_city.Text = "";
            txt_stateCode.Text = "";
            txt_postalCode.Text = "";
            //get addresses
            String ROWID = grid_address.Rows[e.RowIndex].Cells["ROWID"].Value.ToString().Trim();
            AddressObject addressObject = new AddressObject();
            addressObject = connSalesOrder.sp_GET_AddressObject(ROWID);

            txt_address1.Text = addressObject.Address1;
            txt_address2.Text = addressObject.Address2;
            txt_city.Text = addressObject.AddressCity;
            txt_stateCode.Text = addressObject.AddressState;
            txt_postalCode.Text = addressObject.AddressPostalCode;
            txt_addressEmail.Text = addressObject.AddressEmail;
            txt_addressTel1.Text = addressObject.AddressTel1;
            txt_addressTel2.Text = addressObject.AddressTel2;
            txt_addressFax.Text = addressObject.AddressFax;
        }
        private void grid_RoutePlanDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String CustomerID = grid_RoutePlanDetail.Rows[e.RowIndex].Cells["Customer ID"].Value.ToString();
            cbo_CustomerID.Text = CustomerID;
        }

        private void btn_DetailAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String RouteCode = txt_RouteCode.Text.ToString();
                String CustomerID = cbo_CustomerID.Text.ToString();

                for (int i = 0; i < grid_RoutePlanDetail.RowCount; i++)
                {
                    if (CustomerID.Equals(grid_RoutePlanDetail.Rows[i].Cells["Customer ID"].Value.ToString()))
                    {
                        MessageBox.Show("Customer ID already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                connSalesOrder.sp_CRUD_RoutePlanDetail("INSERT", 0, RouteCode, "", CustomerID);
                connSalesOrder.sp_RoutePlanDetail(grid_RoutePlanDetail, RouteCode);
            }
            catch { }
        }
        private void DaySetting()
        {
            cbo_SearchDay.Items.Add("");
            cbo_SearchDay.Items.Add("Monday");
            cbo_SearchDay.Items.Add("Tuesday");
            cbo_SearchDay.Items.Add("Wednesday");
            cbo_SearchDay.Items.Add("Thursday");
            cbo_SearchDay.Items.Add("Friday");
            cbo_SearchDay.Items.Add("Saturday");
            cbo_SearchDay.Items.Add("Sunday");

            cbo_HeaderDay.Items.Add("Monday");
            cbo_HeaderDay.Items.Add("Tuesday");
            cbo_HeaderDay.Items.Add("Wednesday");
            cbo_HeaderDay.Items.Add("Thursday");
            cbo_HeaderDay.Items.Add("Friday");
            cbo_HeaderDay.Items.Add("Saturday");
            cbo_HeaderDay.Items.Add("Sunday");
        }

        private void grid_RoutePlanDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 19 && e.RowIndex >= 0) // Delete button
            {
                //MessageBox.Show(e.RowIndex.ToString().Trim());
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer from route plan list?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(grid_RoutePlanDetail.Rows[e.RowIndex].Cells["id"].Value);
                        String RouteCode = txt_RouteCode.Text.ToString();
                        String RouteStop = grid_RoutePlanDetail.Rows[e.RowIndex].Cells["No."].Value.ToString();
                        String CustomerID = grid_RoutePlanDetail.Rows[e.RowIndex].Cells["Customer ID"].Value.ToString();
                        connSalesOrder.sp_CRUD_RoutePlanDetail("DELETE", id, RouteCode, RouteStop, CustomerID);

                        DataTable dt = this.grid_RoutePlanDetail.DataSource as DataTable;
                        dt.Rows.RemoveAt(e.RowIndex);

                        for (int i = 0; i < grid_RoutePlanDetail.RowCount; i++)
                        {
                            int j = i + 1;
                            grid_RoutePlanDetail.Rows[i].Cells["No."].Value = "S" + j.ToString("D2");
                        }
                        for (int i = 0; i < grid_RoutePlanDetail.RowCount; i++)
                        {
                            int Updateid = Convert.ToInt32(grid_RoutePlanDetail.Rows[i].Cells["id"].Value);
                            String UpdateRouteStop = grid_RoutePlanDetail.Rows[i].Cells["No."].Value.ToString();
                            String UpdateCustomerID = grid_RoutePlanDetail.Rows[i].Cells["Customer ID"].Value.ToString();
                            //MessageBox.Show(id.ToString()+"\n"+RouteStop);
                            connSalesOrder.sp_CRUD_RoutePlanDetail("UPDATE", Updateid, RouteCode, UpdateRouteStop, UpdateCustomerID);
                        }
                        connSalesOrder.sp_RoutePlanDetail(grid_RoutePlanDetail, RouteCode);
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

        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        private void grid_RoutePlanDetail_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = grid_RoutePlanDetail.DoDragDrop(
                    grid_RoutePlanDetail.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void grid_RoutePlanDetail_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = grid_RoutePlanDetail.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void grid_RoutePlanDetail_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void grid_RoutePlanDetail_DragDrop(object sender, DragEventArgs e)
        {

            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = grid_RoutePlanDetail.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                grid_RoutePlanDetail.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                DataTable dt = this.grid_RoutePlanDetail.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr.ItemArray = dt.Rows[rowIndexFromMouseDown].ItemArray.Clone() as object[];
                dt.Rows.RemoveAt(rowIndexFromMouseDown);
                dt.Rows.InsertAt(dr, rowIndexOfItemUnderMouseToDrop);
            }

            for (int i = 0; i < grid_RoutePlanDetail.RowCount; i++)
            {
                int j = i + 1;
                grid_RoutePlanDetail.Rows[i].Cells["No."].Value = "S" + j.ToString("D2");
            }
            
            try
            {
                for (int i = 0; i < grid_RoutePlanDetail.RowCount; i++)
                {
                    int id = Convert.ToInt32(grid_RoutePlanDetail.Rows[i].Cells["id"].Value);
                    String RouteCode = txt_RouteCode.Text.ToString();
                    String RouteStop = grid_RoutePlanDetail.Rows[i].Cells["No."].Value.ToString();
                    String CustomerID = grid_RoutePlanDetail.Rows[i].Cells["Customer ID"].Value.ToString();
                    //MessageBox.Show(id.ToString()+"\n"+RouteStop);
                    connSalesOrder.sp_CRUD_RoutePlanDetail("UPDATE", id, RouteCode, RouteStop, CustomerID);
                }
                //connSalesOrder.sp_RoutePlanDetail(grid_RoutePlanDetail, RouteCode);
            }
            catch //(Exception ex)
            {
                MessageBox.Show("try again please.");
            }
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            try
            {
                int RowIndex = grid_RoutePlanDetail.SelectedCells[0].OwningRow.Index;
                DataTable dt = this.grid_RoutePlanDetail.DataSource as DataTable;
                DataRow row = dt.NewRow();

                int id = Convert.ToInt32(grid_RoutePlanDetail.Rows[RowIndex].Cells["id"].Value);
                String CustomerID = grid_RoutePlanDetail.Rows[RowIndex].Cells["Customer ID"].Value.ToString();
                String Address1 = grid_RoutePlanDetail.Rows[RowIndex].Cells["Address1"].Value.ToString();
                String City = grid_RoutePlanDetail.Rows[RowIndex].Cells["City"].Value.ToString();
                String State = grid_RoutePlanDetail.Rows[RowIndex].Cells["State"].Value.ToString();

                row["id"] = id.ToString();
                row["RouteStop"] = "";
                row["CustomerID"] = CustomerID;
                row["Address1"] = Address1;
                row["City"] = City;
                row["State"] = State;


                if (RowIndex > 0)
                {
                    dt.Rows.RemoveAt(RowIndex);
                    dt.Rows.InsertAt(row, RowIndex - 1);
                    //dt.Rows.Add(row);
                    grid_RoutePlanDetail.ClearSelection();
                    grid_RoutePlanDetail.Rows[RowIndex - 1].Selected = true;
                }

                for (int i = 0; i < grid_RoutePlanDetail.RowCount; i++)
                {
                    int j = i + 1;
                    grid_RoutePlanDetail.Rows[i].Cells["No."].Value = "S" + j.ToString("D2");
                }
            }
            catch
            {
                return;
            }

            try
            {
                for (int i = 0; i < grid_RoutePlanDetail.RowCount; i++)
                {
                    int id = Convert.ToInt32(grid_RoutePlanDetail.Rows[i].Cells["id"].Value);
                    String RouteCode = txt_RouteCode.Text.ToString();
                    String RouteStop = grid_RoutePlanDetail.Rows[i].Cells["No."].Value.ToString();
                    String CustomerID = grid_RoutePlanDetail.Rows[i].Cells["Customer ID"].Value.ToString();
                    //MessageBox.Show(id.ToString()+"\n"+RouteStop);
                    connSalesOrder.sp_CRUD_RoutePlanDetail("UPDATE", id, RouteCode, RouteStop, CustomerID);
                }
                //connSalesOrder.sp_RoutePlanDetail(grid_RoutePlanDetail, RouteCode);
            }
            catch //(Exception ex)
            {
                MessageBox.Show("try again please.");
            }
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            try
            {
                int RowIndex = grid_RoutePlanDetail.SelectedCells[0].OwningRow.Index;
                DataTable dt = this.grid_RoutePlanDetail.DataSource as DataTable;
                DataRow row = dt.NewRow();

                int id = Convert.ToInt32(grid_RoutePlanDetail.Rows[RowIndex].Cells["id"].Value);
                String CustomerID = grid_RoutePlanDetail.Rows[RowIndex].Cells["Customer ID"].Value.ToString();
                String Address1 = grid_RoutePlanDetail.Rows[RowIndex].Cells["Address1"].Value.ToString();
                String City = grid_RoutePlanDetail.Rows[RowIndex].Cells["City"].Value.ToString();
                String State = grid_RoutePlanDetail.Rows[RowIndex].Cells["State"].Value.ToString();

                row["id"] = id.ToString();
                row["RouteStop"] = "";
                row["CustomerID"] = CustomerID;
                row["Address1"] = Address1;
                row["City"] = City;
                row["State"] = State;

                if (RowIndex < grid_RoutePlanDetail.Rows.Count - 1)
                {
                    dt.Rows.RemoveAt(RowIndex);
                    dt.Rows.InsertAt(row, RowIndex + 1);
                    //dt.Rows.Add(row);
                    grid_RoutePlanDetail.ClearSelection();
                    grid_RoutePlanDetail.Rows[RowIndex + 1].Selected = true;
                }

                for (int i = 0; i < grid_RoutePlanDetail.RowCount; i++)
                {
                    int j = i + 1;
                    grid_RoutePlanDetail.Rows[i].Cells["No."].Value = "S" + j.ToString("D2");
                }
            }
            catch//(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return;
            }

            try
            {
                for (int i = 0; i < grid_RoutePlanDetail.RowCount; i++)
                {
                    int id = Convert.ToInt32(grid_RoutePlanDetail.Rows[i].Cells["id"].Value);
                    String RouteCode = txt_RouteCode.Text.ToString();
                    String RouteStop = grid_RoutePlanDetail.Rows[i].Cells["No."].Value.ToString();
                    String CustomerID = grid_RoutePlanDetail.Rows[i].Cells["Customer ID"].Value.ToString();
                    //MessageBox.Show(id.ToString()+"\n"+RouteStop);
                    connSalesOrder.sp_CRUD_RoutePlanDetail("UPDATE", id, RouteCode, RouteStop, CustomerID);
                }
                //connSalesOrder.sp_RoutePlanDetail(grid_RoutePlanDetail, RouteCode);
            }
            catch //(Exception ex)
            {
                MessageBox.Show("try again please.");
            }
        }

        private void btn_DetailSave_Click(object sender, EventArgs e)
        {
            String RouteCode = txt_RouteCode.Text.ToString();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save the list?"
                                                             , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < grid_RoutePlanDetail.RowCount; i++)
                    {
                        int id = Convert.ToInt32(grid_RoutePlanDetail.Rows[i].Cells["id"].Value);
                        String RouteStop = grid_RoutePlanDetail.Rows[i].Cells["No."].Value.ToString();
                        String CustomerID = grid_RoutePlanDetail.Rows[i].Cells["Customer ID"].Value.ToString();
                        //MessageBox.Show(id.ToString()+"\n"+RouteStop);
                        connSalesOrder.sp_CRUD_RoutePlanDetail("UPDATE", id, RouteCode, RouteStop, CustomerID);
                    }
                    //connSalesOrder.sp_RoutePlanDetail(grid_RoutePlanDetail, RouteCode);
                }
                catch //(Exception ex)
                {
                    //MessageBox.Show("Contact to IT \n" + ex.ToString());
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btn_HeaderAdd_Click(object sender, EventArgs e)
        {
            String HeaderRouteCode = txt_HeaderCode.Text.ToString();
            if (HeaderRouteCode.Equals(""))
            {
                MessageBox.Show("Input route code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //for (int i = 0; i < grid_RoutePlan.RowCount; i++)
            //{
            //    if (HeaderRouteCode.Equals(grid_RoutePlan.Rows[i].Cells["Code"].Value.ToString()))
            //    {
            //        MessageBox.Show("Same route code exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add new route plan?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    String RouteCode = txt_HeaderCode.Text.ToString();
                    String RouteDay = cbo_HeaderDay.Text.ToString();
                    String RouteArea = cbo_HeaderCity.Text.ToString();
                    String RouteMemo = txt_HeaderMemo.Text.ToString();

                    String ReturnMessage = connSalesOrder.sp_CRUD_RoutePlan("INSERT", 0, RouteCode, RouteDay, RouteArea, RouteMemo);
                    if (ReturnMessage != "OK")
                    {
                        MessageBox.Show(ReturnMessage, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        connSalesOrder.sp_RoutePlanHeader(grid_RoutePlan, cbo_SearchCode.Text.ToString(), cbo_SearchDay.Text.ToString(), cbo_SearchCity.Text.ToString());
                        return;
                    }
                    connSalesOrder.sp_RoutePlanHeader(grid_RoutePlan, cbo_SearchCode.Text.ToString(), cbo_SearchDay.Text.ToString(), cbo_SearchCity.Text.ToString());
                }
                catch //(Exception ex)
                {
                    //MessageBox.Show("Contact to IT \n" + ex.ToString());
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void grid_RoutePlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11 && e.RowIndex >= 0) // Delete button
            {
                //MessageBox.Show(e.RowIndex.ToString().Trim());
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently remove this route plan list?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(grid_RoutePlan.Rows[e.RowIndex].Cells["id"].Value);
                        String RouteCode = grid_RoutePlan.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        String RouteDay = grid_RoutePlan.Rows[e.RowIndex].Cells["Route Day"].Value.ToString();
                        String RouteArea = grid_RoutePlan.Rows[e.RowIndex].Cells["Area"].Value.ToString();
                        connSalesOrder.sp_CRUD_RoutePlan("DELETE", id, RouteCode, RouteDay, RouteArea, "");

                        connSalesOrder.sp_RoutePlanHeader(grid_RoutePlan, cbo_SearchCode.Text.ToString(), cbo_SearchDay.Text.ToString(), cbo_SearchCity.Text.ToString());
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

        private void btn_HeaderSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_Headerid.Text.ToString());
            String HeaderRouteCode = txt_HeaderCode.Text.ToString();
            if (id.ToString().Equals(""))
            {
                MessageBox.Show("Select header first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //for (int i = 0; i < grid_RoutePlan.RowCount; i++)
            //{
            //    if (HeaderRouteCode.Equals(grid_RoutePlan.Rows[i].Cells["Code"].Value.ToString()))
            //    {
            //        if (grid_RoutePlan.Rows[grid_RoutePlan.CurrentRow.Index].Cells["Code"].Value.ToString().Equals(HeaderRouteCode))
            //        {
            //        }
            //        else
            //        {
            //            MessageBox.Show("Same route code exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //    }
            //}
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save this route plan?"
                                                            , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    String RouteCode = txt_HeaderCode.Text.ToString();
                    String RouteDay = cbo_HeaderDay.Text.ToString();
                    String RouteArea = cbo_HeaderCity.Text.ToString();
                    String RouteMemo = txt_HeaderMemo.Text.ToString();

                    String ReturnMessage = connSalesOrder.sp_CRUD_RoutePlan("UPDATE", id, RouteCode, RouteDay, RouteArea, RouteMemo);

                    if(ReturnMessage != "OK")
                    {
                        MessageBox.Show(ReturnMessage, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        connSalesOrder.sp_RoutePlanHeader(grid_RoutePlan, cbo_SearchCode.Text.ToString(), cbo_SearchDay.Text.ToString(), cbo_SearchCity.Text.ToString());
                        return;
                    }
                    connSalesOrder.sp_RoutePlanHeader(grid_RoutePlan, cbo_SearchCode.Text.ToString(), cbo_SearchDay.Text.ToString(), cbo_SearchCity.Text.ToString());
                }
                catch //(Exception ex)
                {
                    //MessageBox.Show("Contact to IT \n" + ex.ToString());
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        
    }
}
