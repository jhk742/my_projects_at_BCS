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
    public partial class Rpt_Statement : Form
    {
        public Rpt_Statement(String CustomerID, String CustomerName, String CustomerAddress, String Branch)
        {
            InitializeComponent();
            
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("CustomerID", CustomerID));
            reportParameters.Add(new ReportParameter("CustomerName", CustomerName));
            reportParameters.Add(new ReportParameter("CustomerAddress", CustomerAddress));
            //reportParameters.Add(new ReportParameter("TotalBalance", "$" + Convert.ToDecimal(TotalBalance).ToString("N2")));
            reportParameters.Add(new ReportParameter("Branch", Branch));
            

            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_Rpt_StatementTableAdapter.Fill(this.StatementReport.sp_Rpt_Statement, CustomerID);
            

            this.reportViewer1.RefreshReport();


            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_Statement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StatementReport.sp_Rpt_Statement' table. You can move, or remove it, as needed.
            //this.sp_Rpt_StatementTableAdapter.Fill(this.StatementReport.sp_Rpt_Statement);

            this.reportViewer1.RefreshReport();
        }
    }
}
