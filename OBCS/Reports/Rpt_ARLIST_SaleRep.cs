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
    public partial class Rpt_ARLIST_SaleRep : Form
    {
        public Rpt_ARLIST_SaleRep(string SaleRep)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("SaleRep", SaleRep));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.sp_AR_LIST_SaleRepTableAdapter.Fill(this.ARLIST_SaleRep.sp_AR_LIST_SaleRep, SaleRep);

            this.reportViewer1.RefreshReport();


            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Rpt_ARLIST_SaleRep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ARLIST_SaleRep.sp_AR_LIST_SaleRep' table. You can move, or remove it, as needed.
            
        }
    }
}
