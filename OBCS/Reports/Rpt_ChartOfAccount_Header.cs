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
    public partial class Rpt_ChartOfAccount_Header : Form
    {

        public Rpt_ChartOfAccount_Header(String CompanyName, DateTime fromdate, DateTime todate)
        {

            InitializeComponent();

            
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("CompanyName", CompanyName));
            reportParameters.Add(new ReportParameter("FROMDATE", fromdate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", todate.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            
            this.sp_GL_Transaction_Account_RecTableAdapter.Fill(this.ChartOfAccount_Header.sp_GL_Transaction_Account_Rec,CompanyName,fromdate,todate);


            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

       
        

        private void Rpt_ChartOfAccount_Header_Load(object sender, EventArgs e)
        {
            this.sp_GL_Transaction_Account_RecTableAdapter.Adapter.SelectCommand.CommandTimeout = 120;
            // TODO: This line of code loads data into the 'ChartOfAccount_Header.sp_GL_Transaction_Account_Rec' table. You can move, or remove it, as needed.
        }

        


    }
}
