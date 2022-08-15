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
using System.Net.Mail;
using System.IO;
using System.Configuration;
using System.Net;

namespace OBCS.Reports
{
    public partial class Rpt_PORDERWAREHOUSE : Form
    {
        public Rpt_PORDERWAREHOUSE
            (String PONumber, String SupplierID, String SupplierName, String SupplierAddress1, String SupplierAddress2, String ShipVia, String WHMemo,
            String CreateUser, String UpdateUser)
        {
            InitializeComponent();

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("PONumber", PONumber));
            reportParameters.Add(new ReportParameter("SupplierID", SupplierID));
            reportParameters.Add(new ReportParameter("SupplierName", SupplierName));
            reportParameters.Add(new ReportParameter("SupplierAddress1", SupplierAddress1));
            reportParameters.Add(new ReportParameter("SupplierAddress2", SupplierAddress2));
            reportParameters.Add(new ReportParameter("ShipVia", ShipVia));
            reportParameters.Add(new ReportParameter("WHMemo", WHMemo));
            reportParameters.Add(new ReportParameter("CreateUser", CreateUser));
            reportParameters.Add(new ReportParameter("UpdateUser", UpdateUser));


            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_Rpt_PORDERDETAIL_WAREHOUSETableAdapter.Fill(this.PORDERWAREHOUSE.sp_Rpt_PORDERDETAIL_WAREHOUSE, PONumber);

            var rds = new ReportDataSource("PORDERWAREHOUSE", this.PORDERWAREHOUSE.sp_Rpt_PORDERDETAIL_WAREHOUSE as DataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;


        }

        private void Rpt_PORDERWAREHOUSE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PORDERWAREHOUSE.sp_Rpt_PORDERDETAIL_WAREHOUSE' table. You can move, or remove it, as needed.
            //this.sp_Rpt_PORDERDETAIL_WAREHOUSETableAdapter.Fill(this.PORDERWAREHOUSE.sp_Rpt_PORDERDETAIL_WAREHOUSE);

            //this.reportViewer1.RefreshReport();
        }
    }
}
