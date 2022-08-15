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
    public partial class Rpt_PAYMENTT_GetPayments : Form
    {
        public Rpt_PAYMENTT_GetPayments(string Site, string Bank, string PaymentType)
        {
            InitializeComponent();
            DateTime todate = DateTime.Today;
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("TODATE", todate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("Site", Site));
            reportParameters.Add(new ReportParameter("Bank", Bank));
            reportParameters.Add(new ReportParameter("PaymentType", PaymentType));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_PAYMENTT_GetPaymentsTableAdapter.Fill(this.PAYMENTT_GetPayments.sp_PAYMENTT_GetPayments,Site, Bank, PaymentType);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_PAYMENTT_GetPayments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PAYMENTT_GetPayments.sp_PAYMENTT_GetPayments' table. You can move, or remove it, as needed.
            
        }
    }
}
