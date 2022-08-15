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
using System.IO;

using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace OBCS.Reports
{
    public partial class Rpt_BulkNutLabelList : Form
    {
        

        public Rpt_BulkNutLabelList(int RouteNumber)
        {
            InitializeComponent();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("RouteNumber", RouteNumber.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_REPORT_BulkNutLabelListTableAdapter.Fill(this.BulkNutLabelList.sp_REPORT_BulkNutLabelList, RouteNumber.ToString());

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

        }

        public event RenderingCompleteEventHandler RenderingComplete;
        private void Rpt_BulkNutLabelList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BulkNutLabelList.sp_REPORT_BulkNutLabelList' table. You can move, or remove it, as needed.
        }

        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                //reportViewer1.PrintDialog();
                //Close();
            }
            catch
            {

            }
            
        }

        
    }
}
