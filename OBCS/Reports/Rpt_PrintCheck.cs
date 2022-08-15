using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace OBCS.Reports
{
    public partial class Rpt_PrintCheck : Form
    {
        public Rpt_PrintCheck(String PaymentNumber, String CheckNumber, String CheckDate, String SupplierID, String SupplierName, String CheckAmount, String CheckAmountWord, String SupplierAddress1, String SupplierAddress2)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("CheckNumber", CheckNumber));
            reportParameters.Add(new ReportParameter("CheckDate", CheckDate));
            reportParameters.Add(new ReportParameter("SupplierID", SupplierID));
            reportParameters.Add(new ReportParameter("SupplierName", SupplierName));
            reportParameters.Add(new ReportParameter("CheckAmount", CheckAmount));
            reportParameters.Add(new ReportParameter("CheckAmountWord", CheckAmountWord));
            reportParameters.Add(new ReportParameter("SupplierAddress1", SupplierAddress1));
            reportParameters.Add(new ReportParameter("SupplierAddress2", SupplierAddress2));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_Rpt_PrintCheckTableAdapter.Fill(this.PrintCheck.sp_Rpt_PrintCheck, PaymentNumber);

            //this.reportViewer1.RefreshReport();
            var rds = new ReportDataSource("PrintCheck", this.PrintCheck.sp_Rpt_PrintCheck as DataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_PrintCheck_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PrintCheck.sp_Rpt_PrintCheck' table. You can move, or remove it, as needed.
            //this.sp_Rpt_PrintCheckTableAdapter.Fill(this.PrintCheck.sp_Rpt_PrintCheck, PaymentNumber);

            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

    }
}
