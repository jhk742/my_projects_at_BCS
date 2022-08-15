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
    public partial class Rpt_InventoryFlowByLastRecDateByBrand : Form
    {
        public Rpt_InventoryFlowByLastRecDateByBrand(String BrandName)
        {
            InitializeComponent();

            String BrandKey = connPO.getBrandKey(BrandName);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("BrandName", BrandName));
            
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.Rpt_InventoryFlowListByLastRecDateTableAdapter.Fill(this.InventoryFlowByLastRecDateByBrand.Rpt_InventoryFlowListByLastRecDate, BrandKey);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

        }

        private void Form_InventoryFlowByLastRecDateByBrand_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'InventoryFlowByLastRecDateByBrand.Rpt_InventoryFlowListByLastRecDate' table. You can move, or remove it, as needed.
            
        }
    }
}
