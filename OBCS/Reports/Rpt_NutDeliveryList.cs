using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Reports
{
    public partial class Rpt_NutDeliveryList : Form
    {
        public Rpt_NutDeliveryList(DateTime FromDate, DateTime ToDate, String NUTNumber, String MixORNot)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", FromDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", ToDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("MixORNot", MixORNot));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_delivery_NutTableAdapter.Fill(this.NutDeliveryList.sp_delivery_Nut,FromDate,ToDate,NUTNumber,MixORNot);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_NutDeliveryList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NutDeliveryList.sp_delivery_Nut' table. You can move, or remove it, as needed.
           
        }
    }
}
