﻿using Microsoft.Reporting.WinForms;
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
    public partial class Rpt_Commission_Summary_Beta : Form
    {
        public Rpt_Commission_Summary_Beta(DateTime FromDate, DateTime ToDate)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("FROMDATE", FromDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("TODATE", ToDate.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_Commission_Summary_BETATableAdapter.Fill(this.CommissionSummary_Beta.sp_Commission_Summary_BETA, FromDate, ToDate);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_Commission_Summary_Beta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CommissionSummary_Beta.sp_Commission_Summary_BETA' table. You can move, or remove it, as needed.
            
        }
    }
}
