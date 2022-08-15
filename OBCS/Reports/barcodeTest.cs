using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace OBCS.Reports
{
    public partial class barcodeTest : Form
    {
        public barcodeTest()
        {
            InitializeComponent();

            //Zen.Barcode.Code11BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.UPC;
            //pictureBox1.Image = barcode.Draw("80555492135", 50);

            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.UPC_A;
            //writer.Options.PureBarcode = true;
            writer.Options.Width = 100;
            writer.Options.Height = 40;
            //writer.Options.GS1Format = true;
            writer.Options.Margin = 0;

            pictureBox1.Image = writer.Write("642525124566");

            //BarcodeWriter writer2 = new BarcodeWriter();
            //writer2.Format = BarcodeFormat.Co;
            ////writer.Options.PureBarcode = true;
            //writer2.Options.Width = 100;
            //writer2.Options.Height = 40;
            ////writer.Options.GS1Format = true;
            //writer2.Options.Margin = 0;

            //pictureBox2.Image = writer2.Write("PIC123456P");

            //MessageBox.Show(strArray[1].ToString());
            //string BID = strArray[1];
            //Bitmap mmm = writer.Write(BID.ToString());


            //FlowDocument flowDoc = new FlowDocument();
            //Section sec = new Section();

            //flowDoc.ColumnWidth = 2000;
            //int x = Properties.Settings.Default.X;
            //int y = Properties.Settings.Default.Y;
            //int fontSize = Properties.Settings.Default.fontSize;

            //sec.Padding = sec.Margin = new Thickness(x, y, 0, 0);
            //sec.TextAlignment = TextAlignment.Center;
            //sec.FontSize = fontSize;

            //double lineH = Properties.Settings.Default.LineHighet;

            //barcodeimg.Source = Bitmap2BitmapImage(mmm);
            //InlineUIContainer container = new InlineUIContainer(barcodeimg);
            //container.FontStretch = FontStretches.ExtraCondensed;
            //Paragraph paragraph = new Paragraph(container);
            //sec.Blocks.Add(paragraph);
            //flowDoc.Blocks.Add(sec);

            //PrintDialog dialog = new PrintDialog();
            //IDocumentPaginatorSource idpSource = flowDoc;
            //dialog.PrintDocument(idpSource.DocumentPaginator, "job1");

        }
    }
}
