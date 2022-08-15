using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.mWMS
{
    //GIT TEST 04211045
    public partial class wms_shipmentReturn : Form
    {
        public wms_shipmentReturn()
        {
            InitializeComponent();

            grid_Router_Init();
            grid_header_Init();
            grid_detail_Init();

            connPO.sp_WMS_SELECT_SHIPMENTRETURN(grid_header);
            connPO.sp_WMS_SELECT_SHIPMENTRETURNROUTER(grid_Router);

            connSalesOrder.cbo_itemID(cbo_itemID);
            cbo_RM.Items.Add("RR");
            cbo_RM.Items.Add("PF");


        }
        private void grid_Router_Init()
        {
            grid_Router.AutoGenerateColumns = false;
            grid_Router.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Router.ColumnCount = 2;

            grid_Router.Columns[0].Name = "No.";
            grid_Router.Columns[0].ReadOnly = true;
            grid_Router.Columns[0].Width = 5;
            grid_Router.Columns[0].DataPropertyName = "RouteNumber";

            grid_Router.Columns[1].Name = "Stop";
            grid_Router.Columns[1].ReadOnly = true;
            grid_Router.Columns[1].Width = 50;
            grid_Router.Columns[1].DataPropertyName = "RouteStop";

            grid_Router.RowTemplate.Height = 20;
            grid_Router.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_Router.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_Router.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        private void grid_header_Init()
        {
            grid_header.AutoGenerateColumns = false;
            grid_header.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_header.ColumnCount = 9;

            grid_header.Columns[0].Name = "Return No.";
            grid_header.Columns[0].ReadOnly = true;
            grid_header.Columns[0].Width = 90;
            grid_header.Columns[0].DataPropertyName = "ReturnID";

            grid_header.Columns[1].Name = "Order No.";
            grid_header.Columns[1].ReadOnly = true;
            grid_header.Columns[1].Width = 90;
            grid_header.Columns[1].DataPropertyName = "OrderID";

            grid_header.Columns[2].Name = "Delivery No.";
            grid_header.Columns[2].ReadOnly = true;
            grid_header.Columns[2].Width = 90;
            grid_header.Columns[2].DataPropertyName = "DeliveryNumber";

            grid_header.Columns[3].Name = "Customer ID";
            grid_header.Columns[3].ReadOnly = true;
            grid_header.Columns[3].Width = 90;
            grid_header.Columns[3].DataPropertyName = "CustomerID";

            grid_header.Columns[4].Name = "Customer Name";
            grid_header.Columns[4].ReadOnly = true;
            grid_header.Columns[4].Width = 200;
            grid_header.Columns[4].DataPropertyName = "CustomerName";

            grid_header.Columns[5].Name = "Sale Rep";
            grid_header.Columns[5].ReadOnly = true;
            grid_header.Columns[5].Width = 40;
            grid_header.Columns[5].DataPropertyName = "SaleRep";

            grid_header.Columns[6].Name = "Create Date";
            grid_header.Columns[6].ReadOnly = true;
            grid_header.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy\n";
            grid_header.Columns[6].Width = 75;
            grid_header.Columns[6].DataPropertyName = "CreateTime";
            
            grid_header.Columns[7].Name = "Branch";
            grid_header.Columns[7].ReadOnly = true;
            grid_header.Columns[7].Width = 40;
            grid_header.Columns[7].DataPropertyName = "Branch";

            grid_header.Columns[8].Name = "Amount";
            grid_header.Columns[8].Visible = false;
            grid_header.Columns[8].Width = 60;
            grid_header.Columns[8].DefaultCellStyle.Format = "N2";
            grid_header.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_header.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_header.Columns[8].DataPropertyName = "Amount";

            //grid font size custom
            grid_header.RowTemplate.Height = 20;
            grid_header.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_header.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_header.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_detail_Init()
        {
            grid_detail.AutoGenerateColumns = false;
            grid_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_detail.ColumnCount = 9;

            grid_detail.Columns[0].Name = "No.";
            grid_detail.Columns[0].ReadOnly = true;
            grid_detail.Columns[0].Width = 50;
            grid_detail.Columns[0].DataPropertyName = "OrderDetailKey";

            grid_detail.Columns[1].Name = "Product ID";
            grid_detail.Columns[1].ReadOnly = true;
            grid_detail.Columns[1].Width = 90;
            grid_detail.Columns[1].DataPropertyName = "ProductID";

            grid_detail.Columns[2].Name = "Product Description";
            grid_detail.Columns[2].ReadOnly = true;
            grid_detail.Columns[2].Width = 300;
            grid_detail.Columns[2].DataPropertyName = "ProductDesc";

            grid_detail.Columns[3].Name = "Remark";
            grid_detail.Columns[3].ReadOnly = true;
            grid_detail.Columns[3].Width = 30;
            grid_detail.Columns[3].DataPropertyName = "Remark";

            grid_detail.Columns[4].Name = "Price";
            grid_detail.Columns[4].ReadOnly = true;
            grid_detail.Columns[4].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[4].Width = 60;
            grid_detail.Columns[4].DataPropertyName = "Price";

            grid_detail.Columns[5].Name = "Return Qty.";
            grid_detail.Columns[5].ReadOnly = false;
            grid_detail.Columns[5].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[5].Width = 60;
            grid_detail.Columns[5].DataPropertyName = "Qty";

            grid_detail.Columns[6].Name = "Amount";
            grid_detail.Columns[6].ReadOnly = true;
            grid_detail.Columns[6].DefaultCellStyle.Format = "N2";
            grid_detail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_detail.Columns[6].Width = 60;
            grid_detail.Columns[6].DataPropertyName = "Amount";

            DataGridViewComboBoxColumn AQRComboBox = new DataGridViewComboBoxColumn();
            AQRComboBox.Width = 50;
            AQRComboBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            AQRComboBox.Name = "AQR";
            AQRComboBox.Items.Add("A");
            AQRComboBox.Items.Add("Q");
            AQRComboBox.Items.Add("R");
            AQRComboBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AQRComboBox.DataPropertyName = "TempAQR";
            grid_detail.Columns.Insert(7, AQRComboBox);
            
            //grid_detail.Columns[6].Name = "AQR";
            //grid_detail.Columns[6].ReadOnly = false;
            //grid_detail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_detail.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid_detail.Columns[6].Width = 60;
            //grid_detail.Columns[6].DataPropertyName = "TempAQR";

            grid_detail.Columns[8].Name = "Expiration Date";
            grid_detail.Columns[8].ReadOnly = false;
            grid_detail.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_detail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_detail.Columns[8].Width = 90;
            grid_detail.Columns[8].DataPropertyName = "ExpirationDate";

            grid_detail.Columns[9].Name = "Memo";
            grid_detail.Columns[9].ReadOnly = false;
            grid_detail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid_detail.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid_detail.Columns[9].Width = 90;
            grid_detail.Columns[9].DataPropertyName = "Memo";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 50;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButton.UseColumnTextForButtonValue = true;
            if (grid_detail.Columns["Delete"] == null)

            {
                grid_detail.Columns.Insert(10, deleteButton);
            }

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

        private void grid_header_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String DeliveryNumber = grid_header.Rows[e.RowIndex].Cells["Delivery No."].Value.ToString();
                txt_deliveryNumber.Text = DeliveryNumber;

                SelectedReturnID = grid_header.Rows[e.RowIndex].Cells["Return No."].Value.ToString().Trim();
                SelectedOrderID = grid_header.Rows[e.RowIndex].Cells["Order No."].Value.ToString().Trim();
                SelectedCustomerID = grid_header.Rows[e.RowIndex].Cells["Customer ID"].Value.ToString().Trim();

                connPO.sp_WMS_SELECT_SHIPMENTRETURND(grid_detail, DeliveryNumber);
            }
            catch
            {
                //MessageBox.Show("ERROR");
            }
            
        }

        private string format;
        private void grid_detail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CultureInfo provider = CultureInfo.InvariantCulture;
                string dateString = grid_detail.CurrentRow.Cells["Expiration Date"].Value.ToString().Trim();

                if (dateString.Length == 6)
                {
                    format = "MMddyy";
                }
                else if (dateString.Length == 8)
                {
                    format = "MMddyyyy";
                }
                else if (dateString.Length == 10)
                {
                    format = "MM/dd/yyyy";
                }
                DateTime result = DateTime.ParseExact(dateString, format, provider);
                grid_detail.CurrentRow.Cells["Expiration Date"].Value = result.ToString("MM/dd/yyyy");
                //MessageBox.Show(grid_detail.CurrentRow.Cells["Expiration Date"].Value.ToString().Trim());

            }
            catch
            {
                grid_detail.CurrentRow.Cells["Expiration Date"].Value = "";
            }

            try
            {
                if (grid_detail.Rows[e.RowIndex].Cells["Remark"].Value.ToString().Trim() == "RR")
                {
                    Decimal ReturnPrice = Convert.ToDecimal(grid_detail.Rows[e.RowIndex].Cells["Price"].Value.ToString().Trim());
                    Decimal ReturQty = Convert.ToDecimal(grid_detail.Rows[e.RowIndex].Cells["Order Qty."].Value.ToString().Trim());
                    grid_detail.CurrentRow.Cells["Amount"].Value = ReturnPrice * ReturQty;
                }
                else
                {
                    grid_detail.CurrentRow.Cells["Amount"].Value = 0;
                }

            }
            catch
            {

            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (connSalesOrder.sp_CHECK_ShipmentReturn(SelectedOrderID) == true)
            {
                MessageBox.Show("Already has been processed the shipment return. Refreshing...", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                connPO.sp_WMS_SELECT_SHIPMENTRETURN(grid_header);
                connPO.sp_WMS_SELECT_SHIPMENTRETURNROUTER(grid_Router);
                return;
            }

            if (grid_detail.RowCount == 0)
            {
                MessageBox.Show("Please click the not received all item button.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            for (int i = 0; i < grid_detail.Rows.Count; i++)
            {
                Decimal RetunrQty = Convert.ToDecimal(grid_detail.Rows[i].Cells["Return Qty."].Value.ToString().Trim());

                if (RetunrQty <= 0)
                {
                    MessageBox.Show("Please delete this item when this item has not been received.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            for (int i = 0; i < grid_detail.Rows.Count; i++)
            {
                String ReturnAQR = grid_detail.Rows[i].Cells["AQR"].Value.ToString().Trim();

                if (ReturnAQR == "")
                {
                    MessageBox.Show("Please select product status.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            for (int i = 0; i < grid_detail.Rows.Count; i++)
            {
                String ReturnExpirationDate = grid_detail.Rows[i].Cells["Expiration Date"].Value.ToString().Trim();

                if (ReturnExpirationDate == "")
                {
                    MessageBox.Show("Please input the expiration date.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure shipment return receiving process?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                String ReturnID = "";
                String OrderDetailKey = "";
                String AQR = "";
                String Remark = "";
                Decimal ReturnQty = 0;
                String ProductID = "";
                DateTime ExpirationDate;
                String Memo = "";
                if (Memo.Length > 20)
                {
                    MessageBox.Show("Memo (20) letter"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return;
                }
                for (int i = 0; i < grid_detail.Rows.Count; i++)
                {
                    OrderDetailKey = grid_detail.Rows[i].Cells["No."].Value.ToString().Trim();
                    AQR = grid_detail.Rows[i].Cells["AQR"].Value.ToString().Trim();
                    Remark = grid_detail.Rows[i].Cells["Remark"].Value.ToString().Trim();
                    ReturnQty = Convert.ToDecimal(grid_detail.Rows[i].Cells["Return Qty."].Value.ToString().Trim());
                    Decimal ReturnPrice = Convert.ToDecimal(grid_detail.Rows[i].Cells["Price"].Value.ToString().Trim());
                    Decimal ReturnAmount = Convert.ToDecimal(grid_detail.Rows[i].Cells["Amount"].Value.ToString().Trim());
                    ProductID = grid_detail.Rows[i].Cells["Product ID"].Value.ToString().Trim();
                    ExpirationDate = Convert.ToDateTime(grid_detail.Rows[i].Cells["Expiration Date"].Value.ToString().Trim());
                    if (grid_detail.Rows[i].Cells["Memo"].Value == null)
                    {
                        Memo = "";
                    }
                    else
                    {
                        Memo = grid_detail.Rows[i].Cells["Memo"].Value.ToString().Trim();
                    }

                    connSalesOrder.sp_RETURN_RECEIVING_DETAIL(SelectedReturnID, SelectedOrderID, OrderDetailKey, ProductID, ReturnQty, ReturnPrice, ReturnAmount, AQR, ExpirationDate, Memo, Remark);
                    connSalesOrder.sp_RETURN_STOCK(SelectedCustomerID, i + 1, ReturnQty, AQR, ExpirationDate, ProductID, Memo, "BIC", "BCS");
                }
                connSalesOrder.sp_RETURN_RECEIVING(SelectedReturnID);

                grid_detail.DataSource = null;
                refresh();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private string SelectedReturnID;
        private string SelectedOrderID;
        private string SelectedCustomerID;

        private void refresh()
        {
            connPO.sp_WMS_SELECT_SHIPMENTRETURN(grid_header);
            connPO.sp_WMS_SELECT_SHIPMENTRETURNROUTER(grid_Router);

        }

        private void cbo_itemID_SelectedValueChanged(object sender, EventArgs e)
        {
            fillAddItemInfo();
            calculateAddItemPrice();
        }

        private void fillAddItemInfo()
        {
            try
            {
                String ItemDesc = connSalesOrder.getItemDescFromItemID(cbo_itemID.Text);
                txt_itemDesc.Text = ItemDesc;

                Decimal UnitPrice = Convert.ToDecimal(connSalesOrder.getItemUnitPriceFromItemID(cbo_itemID.Text));
                txt_price.Text = UnitPrice.ToString("N2");

                cbo_RM.Text = "RR";
            }
            catch
            {
                //MessageBox.Show("Input all item try to add info", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void calculateAddItemPrice()
        {
            try
            {
                Decimal Qty = Convert.ToDecimal(txt_qty.Text);
                Decimal Price = Convert.ToDecimal(txt_price.Text);
                Decimal Amount = Qty * Price;
                String Remark = cbo_RM.Text;
                if (Remark == "PF")
                {
                    txt_addAmount.Text = "0.00";
                }
                else
                {
                    txt_addAmount.Text = Amount.ToString("N2");
                }
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void cbo_RM_Leave(object sender, EventArgs e)
        {
            calculateAddItemPrice();
        }

        private void txt_price_Leave(object sender, EventArgs e)
        {
            calculateAddItemPrice();
        }

        private void txt_qty_Leave(object sender, EventArgs e)
        {
            calculateAddItemPrice();
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            if (cbo_itemID.Text.Trim() == "")
            {
                MessageBox.Show("Input all item info", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            
            try
            {
                DataTable dt = this.grid_detail.DataSource as DataTable;
                DataRow dr = dt.NewRow();

                //get new orderDetailKey
                String NewOrderDetailKey = connSalesOrder.sp_GET_NewOrderDetailKey();

                int OrderDetailKey = Convert.ToInt32(Convert.ToDecimal(NewOrderDetailKey));
                String ProductID = cbo_itemID.Text;
                Decimal Quantity = Convert.ToDecimal(txt_qty.Text);
                String ProductDesc = txt_itemDesc.Text;
                Decimal Price = Convert.ToDecimal(txt_price.Text);
                Decimal Amount = Convert.ToDecimal(txt_addAmount.Text);
                String Remark = cbo_RM.Text;
                
                dr["OrderDetailKey"] = OrderDetailKey;
                dr["ProductID"] = ProductID;
                dr["ProductDesc"] = ProductDesc;
                dr["Remark"] = Remark;
                dr["Price"] = Price;
                dr["Qty"] = Quantity;
                dr["Amount"] = Amount;
                dr["TempAQR"] = "A";
                dr["ExpirationDate"] = "";

                dt.Rows.Add(dr);
                //dt.Rows.InsertAt(dr, grid_RouteDetail.ColumnCount + 1);
                //Audit();
                cbo_itemID.Text = "";
                txt_itemDesc.Text = "";
                cbo_RM.Text = "RR";
                txt_qty.Text = "";
                txt_addAmount.Text = "";

            }
            catch
            {
                MessageBox.Show("Input all item info", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int port = 2195;
            //String hostname = "gateway.sandbox.push.apple.com";

            ////load certificate
            //string certificatePath = @"C:\BCS\OBCS\LIVE\OBCS\Tools\Certificates0721.p12";
            //string certificatePassword = "bcsroyal0111";
            //X509Certificate2 clientCertificate = new X509Certificate2(certificatePath, certificatePassword);
            //X509Certificate2Collection certificatesCollection = new X509Certificate2Collection(clientCertificate);

            //TcpClient client = new TcpClient(hostname, port);
            //SslStream sslStream = new SslStream(
            //        client.GetStream(),
            //        false,
            //        new RemoteCertificateValidationCallback(ValidateServerCertificate),
            //        null
            //);

            //try
            //{
            //    MessageBox.Show("try start");
            //    sslStream.AuthenticateAsClient(hostname, certificatesCollection, SslProtocols.Tls, true);
            //    MessageBox.Show("try end");
            //    MessageBox.Show(sslStream.ToString());
            //}
            //catch (AuthenticationException ex)
            //{
            //    MessageBox.Show("catch");
            //    client.Close();
            //    return;
            //}

            //// Encode a test message into a byte array.
            //MemoryStream memoryStream = new MemoryStream();
            //BinaryWriter writer = new BinaryWriter(memoryStream);

            //writer.Write((byte)0);  //The command
            //writer.Write((byte)0);  //The first byte of the deviceId length (big-endian first byte)
            //writer.Write((byte)32); //The deviceId length (big-endian second byte)

            //String deviceId = "5FD084B233681DF41A168A2CBF635570F18CC63BDE6D711A818252146F12EE09";// "DEVICEIDGOESHERE";
            //writer.Write(ToByteArray(deviceId.ToUpper()));

            //String payload = "{\"aps\":{\"alert\":\"I like spoons also\",\"badge\":14}}";

            //writer.Write((byte)0); //First byte of payload length; (big-endian first byte)
            //writer.Write((byte)payload.Length); //payload length (big-endian second byte)

            //byte[] b1 = System.Text.Encoding.UTF8.GetBytes(payload);
            //writer.Write(b1);
            //writer.Flush();

            //byte[] array = memoryStream.ToArray();
            //sslStream.Write(array);
            //sslStream.Flush();

            //// Close the client connection.
            //client.Close();
        }

        public static byte[] ToByteArray(string str)
        {
            return System.Text.Encoding.ASCII.GetBytes(str);
        }

        // The following method is invoked by the RemoteCertificateValidationDelegate.
        public static bool ValidateServerCertificate(
              object sender,
              X509Certificate certificate,
              X509Chain chain,
              SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;

            Console.WriteLine("Certificate error: {0}", sslPolicyErrors);

            // Do not allow this client to communicate with unauthenticated servers.
            return false;
        }
    }
}
