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
    public partial class Rpt_Chart_Of_Account : Form
    {
        public Rpt_Chart_Of_Account(string CompanyName, string Account, string Description ,DateTime fromdate, DateTime todate)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("CompanyName", CompanyName));
            reportParameters.Add(new ReportParameter("Account_Number", Account));
            reportParameters.Add(new ReportParameter("Account_Description", Description));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_ACCOUNT_CHARTOFACCOUNT_DETAILTableAdapter.Fill(this.ChartOfAccount.sp_ACCOUNT_CHARTOFACCOUNT_DETAIL, CompanyName, Account, fromdate, todate);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_Chart_Of_Account_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ChartOfAccount.sp_ACCOUNT_CHARTOFACCOUNT_DETAIL' table. You can move, or remove it, as needed.
           
        }
    }
}
