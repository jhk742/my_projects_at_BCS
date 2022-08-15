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
    public partial class Rpt_POManagement : Form
    {
        public Rpt_POManagement(DateTime fromdate, DateTime todate, string Supplier, string Received, string Confirmed, string Type, string Brand)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", fromdate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", todate.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_PO_MANAGEMENTTableAdapter.Fill(this.PO_Management.sp_PO_MANAGEMENT, fromdate, todate, Supplier, Received, Confirmed, Type, Brand);
            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_POManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PO_Management.sp_PO_MANAGEMENT' table. You can move, or remove it, as needed.
            
        }
    }
}
