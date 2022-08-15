using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBCS.Entities;
using OBCS.Reports;
using ZXing;

namespace OBCS.Sales
{
    public partial class PackageNutLabelPrint : Form
    {
        String iPadOrderID;
        int i = 0; // i 초기화
        
        public PackageNutLabelPrint()
        {
            InitializeComponent();

            grid_Header_Init();
            grid_DETAIL_Init();

            refresh_header();

            //detail grid multi line allow
            grid_DETAIL.AllowDrop = true;
            grid_DETAIL.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_DETAIL.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void grid_Header_Init()
        {
            grid_Header.AutoGenerateColumns = false;
            grid_Header.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Header.ColumnCount = 8;

            grid_Header.Columns[0].Name = "iPad Order ID";
            grid_Header.Columns[0].ReadOnly = true;
            grid_Header.Columns[0].Visible = true;
            grid_Header.Columns[0].Width = 100;
            grid_Header.Columns[0].MinimumWidth = 100;
            grid_Header.Columns[0].DataPropertyName = "iPadOrderID";

            grid_Header.Columns[1].Name = "Order No.";
            grid_Header.Columns[1].ReadOnly = true;
            grid_Header.Columns[1].Width = 90;
            grid_Header.Columns[1].MinimumWidth = 90;
            grid_Header.Columns[1].DataPropertyName = "OrderID";

            grid_Header.Columns[2].Name = "Customer ID";
            grid_Header.Columns[2].ReadOnly = true;
            grid_Header.Columns[2].Width = 100;
            grid_Header.Columns[2].MinimumWidth = 100;
            grid_Header.Columns[2].DataPropertyName = "CustomerID";

            grid_Header.Columns[3].Name = "Customer Name";
            grid_Header.Columns[3].ReadOnly = true;
            grid_Header.Columns[3].Width = 250;
            grid_Header.Columns[3].MinimumWidth = 250;
            grid_Header.Columns[3].DataPropertyName = "CustomerName";

            grid_Header.Columns[4].Name = "Route Number";
            grid_Header.Columns[4].ReadOnly = true;
            grid_Header.Columns[4].Width = 55;
            grid_Header.Columns[4].MinimumWidth = 55;
            grid_Header.Columns[4].DataPropertyName = "RouteNumber";

            grid_Header.Columns[5].Name = "Route Stop";
            grid_Header.Columns[5].ReadOnly = true;
            grid_Header.Columns[5].Width = 45;
            grid_Header.Columns[5].MinimumWidth = 45;
            grid_Header.Columns[5].DataPropertyName = "RouteStop";

            grid_Header.Columns[6].Name = "Sales Rep.";
            grid_Header.Columns[6].ReadOnly = true;
            grid_Header.Columns[6].MinimumWidth = 40;
            grid_Header.Columns[6].MinimumWidth = 40;
            grid_Header.Columns[6].DataPropertyName = "REP";

            DataGridViewCheckBoxColumn PackageNutLabelCheck = new DataGridViewCheckBoxColumn();
            PackageNutLabelCheck.HeaderText = "X";
            PackageNutLabelCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PackageNutLabelCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PackageNutLabelCheck.FalseValue = false;
            PackageNutLabelCheck.TrueValue = true;
            PackageNutLabelCheck.Name = "PackageNutLabelSelect";
            PackageNutLabelCheck.ReadOnly = true;
            PackageNutLabelCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PackageNutLabelCheck.Width = 25;
            PackageNutLabelCheck.MinimumWidth = 25;
            //pickingCheck.DataPropertyName = "FLGDLVPRN";
            grid_Header.Columns.Insert(7, PackageNutLabelCheck);
            grid_Header.CellContentClick += new DataGridViewCellEventHandler(PackageNutLabelSelect);

            grid_Header.Columns[8].Name = "Printed";
            grid_Header.Columns[8].Visible = false;
            grid_Header.Columns[8].MinimumWidth = 40;
            grid_Header.Columns[8].MinimumWidth = 40;
            grid_Header.Columns[8].DataPropertyName = "Printed";

            //grid font size custom
            grid_Header.RowTemplate.Height = 20;
            grid_Header.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_Header.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_Header.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_DETAIL_Init()
        {
            grid_DETAIL.AutoGenerateColumns = false;
            grid_DETAIL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_DETAIL.ColumnCount = 15;
            
            grid_DETAIL.Columns[0].Name = "No.";
            grid_DETAIL.Columns[0].ReadOnly = true;
            grid_DETAIL.Columns[0].Visible = false;
            grid_DETAIL.Columns[0].Width = 35;
            grid_DETAIL.Columns[0].DataPropertyName = "";

            grid_DETAIL.Columns[1].Name = "Qty";
            grid_DETAIL.Columns[1].ReadOnly = true;
            grid_DETAIL.Columns[1].Width = 60;
            grid_DETAIL.Columns[1].MinimumWidth = 60;
            grid_DETAIL.Columns[1].DefaultCellStyle.Format = "N2";
            grid_DETAIL.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_DETAIL.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_DETAIL.Columns[1].DataPropertyName = "Quantity";
            
            grid_DETAIL.Columns[2].Name = "Product ID";
            grid_DETAIL.Columns[2].ReadOnly = true;
            grid_DETAIL.Columns[2].Width = 80;
            grid_DETAIL.Columns[2].MinimumWidth = 80;
            grid_DETAIL.Columns[2].DataPropertyName = "ProductID";

            grid_DETAIL.Columns[3].Name = "Name 1";
            grid_DETAIL.Columns[3].ReadOnly = true;
            grid_DETAIL.Columns[3].Width = 150;
            grid_DETAIL.Columns[3].MinimumWidth = 150;
            grid_DETAIL.Columns[3].DataPropertyName = "ProductDesc1";

            grid_DETAIL.Columns[4].Name = "Name 2";
            grid_DETAIL.Columns[4].ReadOnly = true;
            grid_DETAIL.Columns[4].Width = 200;
            grid_DETAIL.Columns[4].MinimumWidth = 200;
            grid_DETAIL.Columns[4].DataPropertyName = "ProductDesc2";

            grid_DETAIL.Columns[5].Name = "Net OZ.";
            grid_DETAIL.Columns[5].ReadOnly = true;
            grid_DETAIL.Columns[5].Width = 80;
            grid_DETAIL.Columns[5].MinimumWidth = 80;
            grid_DETAIL.Columns[5].DataPropertyName = "PackSize";

            grid_DETAIL.Columns[6].Name = "Order Price";
            grid_DETAIL.Columns[6].ReadOnly = true;
            grid_DETAIL.Columns[6].Width = 50;
            grid_DETAIL.Columns[6].MinimumWidth = 50;
            grid_DETAIL.Columns[6].DefaultCellStyle.Format = "N2";
            grid_DETAIL.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DETAIL.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DETAIL.Columns[6].DataPropertyName = "OrderPrice";

            grid_DETAIL.Columns[7].Name = "Retail Price";
            grid_DETAIL.Columns[7].ReadOnly = true;
            grid_DETAIL.Columns[7].Width = 50;
            grid_DETAIL.Columns[7].MinimumWidth = 50;
            grid_DETAIL.Columns[7].DefaultCellStyle.Format = "N2";
            grid_DETAIL.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DETAIL.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DETAIL.Columns[7].DataPropertyName = "RetailPrice";
           
            grid_DETAIL.Columns[8].Name = "Price/lb";
            grid_DETAIL.Columns[8].ReadOnly = true;
            grid_DETAIL.Columns[8].Width = 50;
            grid_DETAIL.Columns[8].MinimumWidth = 50;
            grid_DETAIL.Columns[8].DefaultCellStyle.Format = "N2";
            grid_DETAIL.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DETAIL.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_DETAIL.Columns[8].DataPropertyName = "PriceLB";

            grid_DETAIL.Columns[9].Name = "K";
            grid_DETAIL.Columns[9].ReadOnly = true;
            grid_DETAIL.Columns[9].Width = 30;
            grid_DETAIL.Columns[9].MinimumWidth = 30;
            grid_DETAIL.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_DETAIL.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_DETAIL.Columns[9].DataPropertyName = "KosherLabel";

            grid_DETAIL.Columns[10].Name = "UPC";
            grid_DETAIL.Columns[10].Visible = false;
            grid_DETAIL.Columns[10].Width = 30;
            grid_DETAIL.Columns[10].DataPropertyName = "UPC";
        
            grid_DETAIL.Columns[11].Name = "NetOZ";
            grid_DETAIL.Columns[11].Visible = false;
            grid_DETAIL.Columns[11].Width = 30;
            grid_DETAIL.Columns[11].DataPropertyName = "NetOZ";

            grid_DETAIL.Columns[12].Name = "NetKG";
            grid_DETAIL.Columns[12].Visible = false;
            grid_DETAIL.Columns[12].Width = 30;
            grid_DETAIL.Columns[12].DataPropertyName = "NetKG";

            grid_DETAIL.Columns[13].Name = "ExpireDate";
            grid_DETAIL.Columns[13].Visible = false;
            grid_DETAIL.Columns[13].Width = 30;
            grid_DETAIL.Columns[13].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_DETAIL.Columns[13].DataPropertyName = "ExpireDate";

            grid_DETAIL.Columns[14].Name = "CONTSIZE";
            grid_DETAIL.Columns[14].Visible = false;
            grid_DETAIL.Columns[14].Width = 30;
            grid_DETAIL.Columns[14].DataPropertyName = "CONTSIZE";

            //grid font size custom
            grid_DETAIL.RowTemplate.Height = 35;
            grid_DETAIL.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_DETAIL.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_DETAIL.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void PackageNutLabelSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7) //Ready check box click
            {
                String iPadOrderID = grid_Header.Rows[e.RowIndex].Cells["iPad Order ID"].Value.ToString().Trim();

                if (Convert.ToBoolean(grid_Header.Rows[e.RowIndex].Cells["PackageNutLabelSelect"].EditedFormattedValue) == false) // 체크안되있는 상태에서 체크 했을 때 
                {
                    
                    //DialogResult dialogResult = MessageBox.Show("finished package nut label printing this sales order, " + iPadOrderID + "?"
                    //                                   , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //if (dialogResult == DialogResult.Yes)
                    //{
                        connSalesOrder.sp_PackageNutLabel_PrintedCheck(iPadOrderID, "Check");
                        grid_Header.Rows[e.RowIndex].Cells["PackageNutLabelSelect"].Value = true;
                        grid_Header.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkGray;

                    //}
                }
                else // uncheck 했을 때
                {
                    //MessageBox.Show("Please contact the system administrator."
                    //                                   , "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    connSalesOrder.sp_PackageNutLabel_PrintedCheck(iPadOrderID, "Uncheck");
                    grid_Header.Rows[e.RowIndex].Cells["PackageNutLabelSelect"].Value = false;

                    CustomGrid customGrid = new CustomGrid();
                    grid_Header.Rows[e.RowIndex].DefaultCellStyle.BackColor = customGrid.BackgroundColor;

                }
            }
        }

        private void refresh_header() // header grid refresh
        {
            grid_Header.DataSource = null;
            DateTime date = dateTimePicker_date.Value.Date;

            String ViewAllOrder = "";
            if (cbx_all.Checked) ViewAllOrder = "Checked";
            else ViewAllOrder = "Unchecked";


            connSalesOrder.sp_PackageNut_Header(grid_Header, date, ViewAllOrder);

            foreach (DataGridViewRow item in grid_Header.Rows)
            {
                if (item.Cells["Printed"].Value.ToString().Trim() == "1")
                {
                    item.Cells["PackageNutLabelSelect"].Value = true;
                    item.DefaultCellStyle.BackColor = Color.DarkGray;
                }
            }

            grid_Header.ClearSelection();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show(monthCalendar1.SelectionRange.Start.ToShortDateString());
            refresh_header();
        }

        private void grid_DRIVER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    RouteNumber = Convert.ToInt32(grid_Header.Rows[e.RowIndex].Cells["RTN"].Value); //초기화 한 RouteNumber 정의
            //    string RouteNumberString = grid_Header.Rows[e.RowIndex].Cells["RTN"].Value.ToString(); //RouteNumber String 형

            //    i = 0;

            //    SelectedOrderID = ""; //RouteNumber에서 order를 지우기위한 OrderID 초기화

            //    connSalesOrder.grid_DETAILSfromDelivery(grid_DETAIL, RouteNumberString); // Fill detail gird
            //    grid_DETAIL.ClearSelection(); // detail gird clear selection

            //    Entities.DeliveryManifest deliveryManifest = new Entities.DeliveryManifest();
            //    deliveryManifest = connSalesOrder.sp_GET_DeliveryManifest(RouteNumberString);

            //    txt_100.Text = Convert.ToDecimal(deliveryManifest.Bill100).ToString("C2");
            //    txt_50.Text = Convert.ToDecimal(deliveryManifest.Bill50).ToString("C2");
            //    txt_20.Text = Convert.ToDecimal(deliveryManifest.Bill20).ToString("C2");
            //    txt_10.Text = Convert.ToDecimal(deliveryManifest.Bill10).ToString("C2");
            //    txt_5.Text = Convert.ToDecimal(deliveryManifest.Bill5).ToString("C2");
            //    txt_2.Text = Convert.ToDecimal(deliveryManifest.Bill2).ToString("C2");
            //    txt_1.Text = Convert.ToDecimal(deliveryManifest.Bill1).ToString("C2");
            //    txt_coins.Text = Convert.ToDecimal(deliveryManifest.Coins).ToString("C2");
            //    txt_park.Text = Convert.ToDecimal(deliveryManifest.Park).ToString("C2");
            //    txt_gas.Text = Convert.ToDecimal(deliveryManifest.Gas).ToString("C2");
            //    txt_toll.Text = Convert.ToDecimal(deliveryManifest.Toll).ToString("C2");
            //    txt_misc.Text = Convert.ToDecimal(deliveryManifest.Misc).ToString("C2");

            //    decimal b100 = Convert.ToDecimal(txt_100.Text.ToString().Substring(1));
            //    decimal b50 = Convert.ToDecimal(txt_50.Text.ToString().Substring(1));
            //    decimal b20 = Convert.ToDecimal(txt_20.Text.ToString().Substring(1));
            //    decimal b10 = Convert.ToDecimal(txt_10.Text.ToString().Substring(1));
            //    decimal b5 = Convert.ToDecimal(txt_5.Text.ToString().Substring(1));
            //    decimal b2 = Convert.ToDecimal(txt_2.Text.ToString().Substring(1));
            //    decimal b1 = Convert.ToDecimal(txt_1.Text.ToString().Substring(1));
            //    decimal coins = Convert.ToDecimal(txt_coins.Text.ToString().Substring(1));

            //    txt_cashTotal.Text = (b100 + b50 + b20 + b10 + b5 + b2 + b1 + coins).ToString("C2");

            //    decimal park = Convert.ToDecimal(txt_park.Text.ToString().Substring(1));
            //    decimal gas = Convert.ToDecimal(txt_gas.Text.ToString().Substring(1));
            //    decimal toll = Convert.ToDecimal(txt_toll.Text.ToString().Substring(1));
            //    decimal misc = Convert.ToDecimal(txt_misc.Text.ToString().Substring(1));

            //    txt_expenseTotal.Text = (park + gas + toll + misc).ToString("C2");

                

            //    for (int i = 0; i < grid_DETAIL.RowCount; i++)
            //    {
            //        if (grid_DETAIL.Rows[i].Cells["DeliveryNotePickup"].Value.ToString().Trim() == "Y")
            //        {
            //            grid_DETAIL.Rows[i].Cells["DeliveryNoteSelect"].Value = true;
            //        }
                    
            //        String OrderID = grid_DETAIL.Rows[i].Cells["Order ID"].Value.ToString();
            //        Collection collection = new Collection();
            //        collection = connSalesOrder.sp_Fetch_Order2CollectionInfo(OrderID);
            //        //MessageBox.Show("1" + collection.CheckNo3.ToString() + "1");
            //        String cashString;
            //        if (collection.Cash.ToString() == "0.00")
            //        {
            //            cashString = "";
            //        }
            //        else
            //        {
            //            cashString = "Cash: $ " + collection.Cash.ToString() + "\n";
            //        }

            //        String check1String;
            //        if (collection.CheckNo1.ToString().Equals(""))
            //        {
            //            check1String = "";
            //        }
            //        else
            //        {
            //            check1String = "CHK 01: (" + collection.CheckDate1.ToString("MM/dd/yyyy") + ") " + collection.CheckNo1 + " $" + collection.CheckAmount1 + "\n";
            //        }

            //        String check2String;
            //        if (collection.CheckNo2.ToString().Equals(""))
            //        {
            //            check2String = "";
            //        }
            //        else
            //        {
            //            check2String = "CHK 02: (" + collection.CheckDate2.ToString("MM/dd/yyyy") + ") " + collection.CheckNo2 + " $" + collection.CheckAmount2 + "\n";
            //        }

            //        String check3String;
            //        if (collection.CheckNo3.ToString().Equals(""))
            //        {
            //            check3String = "";
            //        }
            //        else
            //        {
            //            check3String = "CHK 03: (" + collection.CheckDate3.ToString("MM/dd/yyyy") + ") " + collection.CheckNo3 + " $" + collection.CheckAmount3 + "\n";
            //        }

            //        String check4String;
            //        if (collection.CheckNo4.ToString().Equals(""))
            //        {
            //            check4String = "";
            //        }
            //        else
            //        {
            //            check4String = "CHK 04: (" + collection.CheckDate4.ToString("MM/dd/yyyy") + ") " + collection.CheckNo4 + " $" + collection.CheckAmount4 + "\n";
            //        }

            //        String check5String;
            //        if (collection.CheckNo5.ToString().Equals(""))
            //        {
            //            check5String = "";
            //        }
            //        else
            //        {
            //            check5String = "CHK 05: (" + collection.CheckDate5.ToString("MM/dd/yyyy") + ") " + collection.CheckNo5 + " $" + collection.CheckAmount5 + "\n";
            //        }

            //        string Paid = "\n" + cashString + check1String + check2String + check3String + check4String + check5String;
            //        if (Paid == "\n")
            //        {
            //            Paid = "Not Paid";
            //        }
            //        grid_DETAIL.Rows[i].Cells["Paid"].Value = Paid;
            //    }

            //    Decimal cashTotal = connSalesOrder.sp_GET_CashTotal(RouteNumberString);
            //    Decimal checkTotal = connSalesOrder.sp_GET_CheckTotal(RouteNumberString);

            //    txt_cashTotal2.Text = cashTotal.ToString();
            //    txt_checkTotal.Text = checkTotal.ToString();
            //    txt_subTotal.Text = (cashTotal + checkTotal).ToString();
            //}
            //catch
            //{

            //}
        }
        string imageUrl = null;

        private void grid_DETAIL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("*" + grid_DETAIL.Rows[e.RowIndex].Cells["UPC"].Value.ToString().Trim() + "*");
            BarcodeWriter UPC = new BarcodeWriter();
            // Create QRcode....    
            UPC.Format = BarcodeFormat.UPC_A;
            UPC.Options.PureBarcode = true;
            UPC.Options.Width = 100;
            UPC.Options.Height = 20;
            UPC.Options.Margin = 0;
            String UPCNumber = grid_DETAIL.Rows[e.RowIndex].Cells["UPC"].Value.ToString().Trim();
            Bitmap bmp;
            try
            {
                bmp = UPC.Write(UPCNumber);
            }
            catch
            {
                MessageBox.Show("Requested contents should be 12 (without checksum digit) or 13 digits long.\n\n" +
                    "Check the barcode of the product on Package Nut Customer Option.\n\n" +
                    "How to add or update UPC of the product?:\n" +
                    "Sales Menu-> Package Nut Customer Option -> Select Customer -> Search Product ID and Add or Update UPC.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            //bmp.Save("C:\\Test\\img.png", ImageFormat.Png);
            bmp.Save(Path.GetTempPath() + "\\img.png", ImageFormat.Png);
            //imageUrl = "C:\\Test\\img.png";
            imageUrl = Path.GetTempPath() + "\\img.png";

            String StoreName;
            if (cbx_printName.Checked)
                StoreName = txt_storeName.Text.Trim();
            else
                StoreName = "";

            String StoreAddress;
            if (cbx_printAddress.Checked)
                StoreAddress = txt_storeAddress.Text.Trim();
            else
                StoreAddress = "";
            
            String ProductName1 = grid_DETAIL.Rows[e.RowIndex].Cells["Name 1"].Value.ToString().Trim();
            String ProductName2 = grid_DETAIL.Rows[e.RowIndex].Cells["Name 2"].Value.ToString().Trim();

            String RetailPrice;
            try
            {
                if (cbx_showRetailPrice.Checked)
                    RetailPrice = Convert.ToDecimal(grid_DETAIL.Rows[e.RowIndex].Cells["Retail Price"].Value.ToString().Trim()).ToString("0.##");
                else
                    RetailPrice = "";
            }
            catch
            {
                if(cbx_customLabel.Checked)
                {
                    MessageBox.Show("No Custom Label info on the system.\n\n" +
                    "How to input custom label info? :\n" +
                    "Sales Menu-> PackageNut Customer Option\n" +
                    " -> Add new custom label info", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(cbx_byCustomerPrice.Checked)
                {
                    MessageBox.Show("No Custom Price info on the system.\n\n" +
                    "How to input custom price info? :\n" +
                    "Sales Menu-> PackageNut Customer Price\n" +
                    " -> Add new custom price info", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                RetailPrice = "";
                return;
            }
            
            
            String NetOZ = grid_DETAIL.Rows[e.RowIndex].Cells["NetOZ"].Value.ToString().Trim();
            String NetKG = grid_DETAIL.Rows[e.RowIndex].Cells["NetKG"].Value.ToString().Trim();
            String PriceLB = grid_DETAIL.Rows[e.RowIndex].Cells["Price/lb"].Value.ToString().Trim();
            String ExpirationDate = Convert.ToDateTime(grid_DETAIL.Rows[e.RowIndex].Cells["ExpireDate"].Value.ToString().Trim()).ToString("MM/dd/yyyy");
            String Kosher = grid_DETAIL.Rows[e.RowIndex].Cells["K"].Value.ToString().Trim();
            String ContSize = Convert.ToDecimal(grid_DETAIL.Rows[e.RowIndex].Cells["ContSize"].Value.ToString().Trim()).ToString("0.##") + " Oz";
            String ContSizeCT = Convert.ToDecimal(grid_DETAIL.Rows[e.RowIndex].Cells["ContSize"].Value.ToString().Trim()).ToString("0.##") + "CT";
            Decimal OrderQty = Convert.ToDecimal(grid_DETAIL.Rows[e.RowIndex].Cells["Qty"].Value.ToString().Trim());
            Decimal CopiesTemp = Math.Ceiling(OrderQty / 6);
            int Copies = Convert.ToInt32(CopiesTemp);

            


            if (!string.IsNullOrEmpty(imageUrl))
            {
                if (txt_labelType.Text.Trim() == "Dr.SNACK" || txt_labelType.Text.Trim() == "")
                {
                    Rpt_PackageNutLabel rpt_PackageNutLabel = new Rpt_PackageNutLabel(imageUrl
                                                                             , StoreName
                                                                             , StoreAddress
                                                                             , ProductName1
                                                                             , ProductName2
                                                                             , RetailPrice
                                                                             , NetOZ
                                                                             , NetKG
                                                                             , PriceLB
                                                                             , ExpirationDate
                                                                             , Kosher
                                                                             , UPCNumber
                                                                             , ContSize
                                                                             , Copies
                                                                              );
                    rpt_PackageNutLabel.ShowDialog();
                }
                else if (txt_labelType.Text.Trim() == "Dr.SNACK2" || txt_labelType.Text.Trim() == "")
                {
                    Rpt_PackageNutLabel_DrSnack rpt_PackageNutLabel = new Rpt_PackageNutLabel_DrSnack(imageUrl
                                                                                 , StoreName
                                                                                 , StoreAddress
                                                                                 , ProductName1
                                                                                 , ProductName2
                                                                                 , RetailPrice
                                                                                 , NetOZ
                                                                                 , NetKG
                                                                                 , PriceLB
                                                                                 , ExpirationDate
                                                                                 , Kosher
                                                                                 , UPCNumber
                                                                                 , ContSize
                                                                                 , ContSizeCT
                                                                                 , Copies
                                                                                  );
                    rpt_PackageNutLabel.ShowDialog();
                }
                else if (txt_labelType.Text.Trim() == "AGATA & VALENTINA")
                {

                    Rpt_PackageNutLabel_AgataValentina rpt_PackageNutLabel = new Rpt_PackageNutLabel_AgataValentina(imageUrl
                                                                                     , StoreName
                                                                                     , StoreAddress
                                                                                     , ProductName1
                                                                                     , ProductName2
                                                                                     , RetailPrice
                                                                                     , NetOZ
                                                                                     , NetKG
                                                                                     , PriceLB
                                                                                     , ExpirationDate
                                                                                     , Kosher
                                                                                     , UPCNumber
                                                                                     , ContSize
                                                                                     , Copies
                                                                                      );
                    rpt_PackageNutLabel.ShowDialog();
                }
                else if (txt_labelType.Text.Trim() == "Goodies")
                {

                    Rpt_PackageNutLabel_Goodies rpt_PackageNutLabel = new Rpt_PackageNutLabel_Goodies(imageUrl
                                                                                     , StoreName
                                                                                     , StoreAddress
                                                                                     , ProductName1
                                                                                     , ProductName2
                                                                                     , RetailPrice
                                                                                     , NetOZ
                                                                                     , NetKG
                                                                                     , PriceLB
                                                                                     , ExpirationDate
                                                                                     , Kosher
                                                                                     , UPCNumber
                                                                                     , ContSize
                                                                                     , Copies
                                                                                      );
                    rpt_PackageNutLabel.ShowDialog();
                }


                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(Sales.PackageNutLabelPrint))
                    {
                        form.Activate();
                        form.Focus();
                    }
                }
                
            }
            //String OrderID = grid_RouteDetail.Rows[e.RowIndex].Cells["Order No."].Value.ToString().Trim();
            
            //try
            //{
            //    String OrderID = grid_DETAIL.Rows[e.RowIndex].Cells["Order ID"].Value.ToString();
            //    CashCheckCollection cashCheckCollection = new CashCheckCollection(OrderID);
            //    cashCheckCollection.ShowDialog();

            //    connSalesOrder.grid_DETAILSfromDelivery(grid_DETAIL, RouteNumber.ToString()); // Fill detail gird
            //    grid_DETAIL.ClearSelection(); // detail gird clear selection

            //    for (int i = 0; i < grid_DETAIL.RowCount; i++)
            //    {
            //        String OrderID2 = grid_DETAIL.Rows[i].Cells["Order ID"].Value.ToString();
            //        Collection collection = new Collection();
            //        collection = connSalesOrder.sp_Fetch_Order2CollectionInfo(OrderID2);
            //        //MessageBox.Show("1" + collection.CheckNo3.ToString() + "1");
            //        String cashString;
            //        if (collection.Cash.ToString() == "0.00")
            //        {
            //            cashString = "";
            //        }
            //        else
            //        {
            //            cashString = "Cash: $ " + collection.Cash.ToString() + "\n";
            //        }

            //        String check1String;
            //        if (collection.CheckNo1.ToString().Equals(""))
            //        {
            //            check1String = "";
            //        }
            //        else
            //        {
            //            check1String = "CHK 01: (" + collection.CheckDate1.ToString("MM/dd/yyyy") + ") " + collection.CheckNo1 + " $" + collection.CheckAmount1 + "\n";
            //        }

            //        String check2String;
            //        if (collection.CheckNo2.ToString().Equals(""))
            //        {
            //            check2String = "";
            //        }
            //        else
            //        {
            //            check2String = "CHK 02: (" + collection.CheckDate2.ToString("MM/dd/yyyy") + ") " + collection.CheckNo2 + " $" + collection.CheckAmount2 + "\n";
            //        }

            //        String check3String;
            //        if (collection.CheckNo3.ToString().Equals(""))
            //        {
            //            check3String = "";
            //        }
            //        else
            //        {
            //            check3String = "CHK 03: (" + collection.CheckDate3.ToString("MM/dd/yyyy") + ") " + collection.CheckNo3 + " $" + collection.CheckAmount3 + "\n";
            //        }

            //        String check4String;
            //        if (collection.CheckNo4.ToString().Equals(""))
            //        {
            //            check4String = "";
            //        }
            //        else
            //        {
            //            check4String = "CHK 04: (" + collection.CheckDate4.ToString("MM/dd/yyyy") + ") " + collection.CheckNo4 + " $" + collection.CheckAmount4 + "\n";
            //        }

            //        String check5String;
            //        if (collection.CheckNo5.ToString().Equals(""))
            //        {
            //            check5String = "";
            //        }
            //        else
            //        {
            //            check5String = "CHK 05: (" + collection.CheckDate5.ToString("MM/dd/yyyy") + ") " + collection.CheckNo5 + " $" + collection.CheckAmount5 + "\n";
            //        }

            //        string Paid = "\n" + cashString + check1String + check2String + check3String + check4String + check5String;
            //        if (Paid == "\n")
            //        {
            //            Paid = "Not Paid";
            //        }
            //        grid_DETAIL.Rows[i].Cells["Paid"].Value = Paid;
            //    }

            //    Decimal cashTotal = connSalesOrder.sp_GET_CashTotal(RouteNumber.ToString());
            //    Decimal checkTotal = connSalesOrder.sp_GET_CheckTotal(RouteNumber.ToString());

            //    txt_cashTotal2.Text = cashTotal.ToString();
            //    txt_checkTotal.Text = checkTotal.ToString();
            //    txt_subTotal.Text = (cashTotal + checkTotal).ToString();
            //}
            //catch
            //{

            //}

        }

        private void dateTimePicker_date_ValueChanged(object sender, EventArgs e)
        {
            refresh_header();
        }

        private void grid_Header_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                iPadOrderID = grid_Header.Rows[e.RowIndex].Cells["iPad Order ID"].Value.ToString().Trim(); 
                connSalesOrder.sp_PackageNut_Detail(grid_DETAIL, iPadOrderID); // Fill detail gird
                grid_DETAIL.ClearSelection(); // detail gird clear selection

                //Get option info by customer
                
                CustomerObject customerObject = new CustomerObject();
                String CustomerID = grid_Header.Rows[e.RowIndex].Cells["Customer ID"].Value.ToString().Trim();
                String StoreName = connSalesOrder.sp_PackageNutLabel_StoreName(CustomerID);
                String StoreAddress = connSalesOrder.sp_PackageNutLabel_StoreAddress(CustomerID);

                txt_storeName.Text = StoreName;
                txt_storeAddress.Text = StoreAddress;

                customerObject = connSalesOrder.sp_GET_CustomerObject(CustomerID);
                
                txt_labelType.Text = customerObject.LabelType.ToString();
                txt_nutMarkup.Text = customerObject.CustomerNutMarkup.ToString("N2");

                if (customerObject.NutMarkupPrintName == 1)
                    cbx_printName.Checked = true;
                else
                    cbx_printName.Checked = false;

                if (customerObject.NutMarkupByMarkup == 1)
                    cbx_byMarkup.Checked = true;
                else
                    cbx_byMarkup.Checked = false;

                if (customerObject.NutMarkupByCustomerPrice == 1)
                    cbx_byCustomerPrice.Checked = true;
                else
                    cbx_byCustomerPrice.Checked = false;

                if (customerObject.NutMarkupShowRetailPrice == 1)
                    cbx_showRetailPrice.Checked = true;
                else
                    cbx_showRetailPrice.Checked = false;

                if (customerObject.NutMarkupPrintAddress == 1)
                    cbx_printAddress.Checked = true;
                else
                    cbx_printAddress.Checked = false;

                if (customerObject.NutMarkupCustomLabel == 1)
                    cbx_customLabel.Checked = true;
                else
                    cbx_customLabel.Checked = false;

                                
            }
            catch
            {

            }
        }

        private void grid_DETAIL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    BarcodeWriter UPC = new BarcodeWriter();
                    // Create QRcode....    
                    UPC.Format = BarcodeFormat.UPC_A;
                    UPC.Options.PureBarcode = true;
                    UPC.Options.Width = 100;
                    UPC.Options.Height = 20;
                    UPC.Options.Margin = 0;
                    String UPCNumber = selectedUPCNumber;
                    Bitmap bmp = UPC.Write(UPCNumber);
                    //bmp.Save("C:\\Test\\img.png", ImageFormat.Png);
                    bmp.Save(Path.GetTempPath() + "\\img.png", ImageFormat.Png);
                    //imageUrl = "C:\\Test\\img.png";
                    imageUrl = Path.GetTempPath() + "\\img.png";

                    String StoreName;
                    if (cbx_printName.Checked)
                        StoreName = txt_storeName.Text.Trim();
                    else
                        StoreName = "";

                    String StoreAddress;
                    if (cbx_printAddress.Checked)
                        StoreAddress = txt_storeAddress.Text.Trim();
                    else
                        StoreAddress = "";

                    String ProductName1 = selectedProductName1;
                    String ProductName2 = selectedProductName2;

                    String RetailPrice;
                    if (cbx_showRetailPrice.Checked)
                        RetailPrice = selectedRetailPrice;
                    else
                        RetailPrice = "";

                    String NetOZ = selectedNetOZ;
                    String NetKG = selectedNetKG;
                    String PriceLB = selectedPriceLB;
                    String ExpirationDate = selectedExpirationDate;
                    String Kosher = selectedKosher;
                    String ContSize = selectedContSize;
                    String ContSizeCT = selectedContSizeCT;
                    Decimal OrderQty = selectedOrderQty;
                    Decimal CopiesTemp = Math.Ceiling(OrderQty / 6);
                    int Copies = Convert.ToInt32(CopiesTemp);




                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        if (txt_labelType.Text.Trim() == "Dr.SNACK" || txt_labelType.Text.Trim() == "")
                        {
                            Rpt_PackageNutLabel rpt_PackageNutLabel = new Rpt_PackageNutLabel(imageUrl
                                                                                     , StoreName
                                                                                     , StoreAddress
                                                                                     , ProductName1
                                                                                     , ProductName2
                                                                                     , RetailPrice
                                                                                     , NetOZ
                                                                                     , NetKG
                                                                                     , PriceLB
                                                                                     , ExpirationDate
                                                                                     , Kosher
                                                                                     , UPCNumber
                                                                                     , ContSize
                                                                                     , Copies
                                                                                      );
                            rpt_PackageNutLabel.ShowDialog();
                        }
                        else if (txt_labelType.Text.Trim() == "Dr.SNACK2" || txt_labelType.Text.Trim() == "")
                        {
                            Rpt_PackageNutLabel_DrSnack rpt_PackageNutLabel = new Rpt_PackageNutLabel_DrSnack(imageUrl
                                                                                         , StoreName
                                                                                         , StoreAddress
                                                                                         , ProductName1
                                                                                         , ProductName2
                                                                                         , RetailPrice
                                                                                         , NetOZ
                                                                                         , NetKG
                                                                                         , PriceLB
                                                                                         , ExpirationDate
                                                                                         , Kosher
                                                                                         , UPCNumber
                                                                                         , ContSize
                                                                                         , ContSizeCT
                                                                                         , Copies
                                                                                          );
                            rpt_PackageNutLabel.ShowDialog();
                        }
                        else if (txt_labelType.Text.Trim() == "AGATA & VALENTINA")
                        {

                            Rpt_PackageNutLabel_AgataValentina rpt_PackageNutLabel = new Rpt_PackageNutLabel_AgataValentina(imageUrl
                                                                                             , StoreName
                                                                                             , StoreAddress
                                                                                             , ProductName1
                                                                                             , ProductName2
                                                                                             , RetailPrice
                                                                                             , NetOZ
                                                                                             , NetKG
                                                                                             , PriceLB
                                                                                             , ExpirationDate
                                                                                             , Kosher
                                                                                             , UPCNumber
                                                                                             , ContSize
                                                                                             , Copies
                                                                                              );
                            rpt_PackageNutLabel.ShowDialog();
                        }
                        else if (txt_labelType.Text.Trim() == "Goodies")
                        {

                            Rpt_PackageNutLabel_Goodies rpt_PackageNutLabel = new Rpt_PackageNutLabel_Goodies(imageUrl
                                                                                             , StoreName
                                                                                             , StoreAddress
                                                                                             , ProductName1
                                                                                             , ProductName2
                                                                                             , RetailPrice
                                                                                             , NetOZ
                                                                                             , NetKG
                                                                                             , PriceLB
                                                                                             , ExpirationDate
                                                                                             , Kosher
                                                                                             , UPCNumber
                                                                                             , ContSize
                                                                                             , Copies
                                                                                              );
                            rpt_PackageNutLabel.ShowDialog();
                        }


                        foreach (Form form in Application.OpenForms)
                        {
                            if (form.GetType() == typeof(Sales.PackageNutLabelPrint))
                            {
                                form.Activate();
                                form.Focus();
                            }
                        }
                    }
                }
                catch
                {

                }
            }
        }

        string selectedUPCNumber, selectedProductName1, selectedProductName2, selectedRetailPrice, selectedNetOZ, selectedNetKG, selectedPriceLB, selectedExpirationDate, selectedKosher, selectedContSize, selectedContSizeCT;

        private void cbx_all_CheckedChanged(object sender, EventArgs e)
        {
            refresh_header();
        }

        Decimal selectedOrderQty;
        private void grid_DETAIL_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedUPCNumber = grid_DETAIL.Rows[e.RowIndex].Cells["UPC"].Value.ToString().Trim();
                selectedProductName1 = grid_DETAIL.Rows[e.RowIndex].Cells["Name 1"].Value.ToString().Trim();
                selectedProductName2 = grid_DETAIL.Rows[e.RowIndex].Cells["Name 2"].Value.ToString().Trim();
                selectedRetailPrice = Convert.ToDecimal(grid_DETAIL.Rows[e.RowIndex].Cells["Retail Price"].Value.ToString().Trim()).ToString("0.##");
                selectedNetOZ = grid_DETAIL.Rows[e.RowIndex].Cells["NetOZ"].Value.ToString().Trim();
                selectedNetKG = grid_DETAIL.Rows[e.RowIndex].Cells["NetKG"].Value.ToString().Trim();
                selectedPriceLB = grid_DETAIL.Rows[e.RowIndex].Cells["Price/lb"].Value.ToString().Trim();
                selectedExpirationDate = Convert.ToDateTime(grid_DETAIL.Rows[e.RowIndex].Cells["ExpireDate"].Value.ToString().Trim()).ToString("MM/dd/yyyy");
                selectedKosher = grid_DETAIL.Rows[e.RowIndex].Cells["K"].Value.ToString().Trim();
                selectedContSize = Convert.ToDecimal(grid_DETAIL.Rows[e.RowIndex].Cells["ContSize"].Value.ToString().Trim()).ToString("0.##") + " Oz";
                selectedContSizeCT = Convert.ToDecimal(grid_DETAIL.Rows[e.RowIndex].Cells["ContSize"].Value.ToString().Trim()).ToString("0.##") + "CT";
                selectedOrderQty = Convert.ToDecimal(grid_DETAIL.Rows[e.RowIndex].Cells["Qty"].Value.ToString().Trim());
            }
            catch
            {
                return;
            }
        }
    }
}
