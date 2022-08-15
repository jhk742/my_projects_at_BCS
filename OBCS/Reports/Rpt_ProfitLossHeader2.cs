using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Reports
{
    public partial class Rpt_ProfitLossHeader2 : Form
    {
        public Rpt_ProfitLossHeader2()
        {
            InitializeComponent();
            connPO.cbo_CompanyName(cbo_company);
        }
        
        private void btn_fresh_Click(object sender, EventArgs e)
        {
            string CompanyName = cbo_company.Text.Trim().ToString();
            DateTime FromDate = dateTimePicker1.Value.Date;
            DateTime ToDate = dateTimePicker2.Value.Date;
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", FromDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", ToDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("COMPANYNAME", CompanyName));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_ProfitAndLossReport_HeaderTableAdapter.Fill(this.ProfitAndLossHeader.sp_ProfitAndLossReport_Header,CompanyName,FromDate,ToDate);

            this.reportViewer1.RefreshReport();

            //reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.SetDisplayMode(DisplayMode.Normal);
            //reportViewer1.ZoomMode = ZoomMode.Percent;
            //reportViewer1.ZoomPercent = 100;
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

        }

        private void Rpt_ProfitLossHeader2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ProfitAndLossHeader.sp_ProfitAndLossReport_Header' table. You can move, or remove it, as needed.
            //this.sp_ProfitAndLossReport_HeaderTableAdapter.Fill(this.ProfitAndLossHeader.sp_ProfitAndLossReport_Header);
           
            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            //try
            //{
            //    MessageBox.Show("CLICKED");
            //    Microsoft.Reporting.WinForms.ReportDataSource dataSrc = new Microsoft.Reporting.WinForms.ReportDataSource();
            //    dataSrc.Name = "TESTREPORT";
            //    dataSrc.Value = this.DataBindings;

            //    System.Data.DataSet TestDataSet = new System.Data.DataSet();
                
            //    //TestDataSet.

            //    LocalReport localReport = (LocalReport)e.Report;
            //    localReport.DataSources.Add(dataSrc);
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime minimumDate = Convert.ToDateTime("01/01/2019");
            if(dateTimePicker1.Value.Date < minimumDate)    dateTimePicker1.Value = minimumDate;
        }
    }
}
