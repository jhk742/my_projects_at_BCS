using Microsoft.Reporting.WinForms;
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
using ZXing;

namespace OBCS.Reports
{
    public partial class Rpt_PackageNutLabel_DrSnack : Form
    {
        string _imageUrl, _StoreName, _StoreAddress, _ProductName1, _ProductName2, _RetailPrice, _NetOZ, _NetKG, _PriceLB, _ExpirationDate, _Kosher, _UPCNumber, _ContSize, _ContSizeCT;
        int _Copies;

        public Rpt_PackageNutLabel_DrSnack(
             String imageUrl
            ,String StoreName
            ,String StoreAddress
            ,String ProductName1
            ,String ProductName2
            ,String RetailPrice
            ,String NetOZ
            ,String NetKG
            ,String PriceLB
            ,String ExpirationDate
            ,String Kosher
            ,String UPCNumber
            ,String ContSize
            ,String ContSizeCT
            ,int Copies
            )
        {
            InitializeComponent();
            _imageUrl = imageUrl;
            _StoreName = StoreName;
            _StoreAddress = StoreAddress;
            _ProductName1 = ProductName1;
            _ProductName2 = ProductName2;
            _RetailPrice = RetailPrice;
            _NetOZ = NetOZ;
            _NetKG = NetKG;
            _PriceLB = PriceLB;
            _ExpirationDate = ExpirationDate;
            _Kosher = Kosher;
            _UPCNumber = UPCNumber;
            _Copies = Copies;
            _ContSize = ContSize;
            _ContSizeCT = ContSizeCT;

            //reportViewer1.LocalReport.DataSources.Clear();

            //this.reportViewer1.RefreshReport();
        }

        private void Rpt_PackageNutLabel_DrSnack_Load(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("StoreName", _StoreName));
            reportParameters.Add(new ReportParameter("StoreAddress", _StoreAddress));
            reportParameters.Add(new ReportParameter("ProductName1", _ProductName1));
            reportParameters.Add(new ReportParameter("ProductName2", _ProductName2));
            reportParameters.Add(new ReportParameter("RetailPrice", _RetailPrice));
            reportParameters.Add(new ReportParameter("NetOZ", _NetOZ));
            reportParameters.Add(new ReportParameter("NetKG", _NetKG));
            reportParameters.Add(new ReportParameter("PriceLB", _PriceLB));
            FileInfo fi = new FileInfo(_imageUrl);
            reportParameters.Add(new ReportParameter("UPC", new Uri(_imageUrl).AbsoluteUri));
            reportParameters.Add(new ReportParameter("ExpirationDate", _ExpirationDate));
            reportParameters.Add(new ReportParameter("Kosher", _Kosher));
            reportParameters.Add(new ReportParameter("UPCNumber", _UPCNumber));
            reportParameters.Add(new ReportParameter("ContSize", _ContSize));
            reportParameters.Add(new ReportParameter("ContSizeCT", _ContSizeCT));
            this.reportViewer1.PrinterSettings.Copies = (short)_Copies;
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                reportViewer1.PrintDialog();
                this.Close();
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(Sales.PackageNutLabelPrint))
                    {
                        form.Activate();
                        form.Focus();
                    }
                }
                
            }
            catch
            {

            }
        }

    }
}
