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
    public partial class Rpt_PORDER : Form
    {
        public Rpt_PORDER
            (String PONO, String OrderDate, String RequireDate, String Term, String Via, String Contact,
             String SupplierID, String SupplierName, String SupplierAddress1, String SupplierAddress2,
             String SupplierTel, String SupplierFax,
             String SupplierCityStateZip,
             String ShipName, String ShipAddress1, String ShipAddress2,
             String ShipTel, String ShipFax,
             String ShipCityStateZip, String ExpectDate, String TotalCase, String TotalAmount)
        {
            InitializeComponent();

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("PONO", PONO));
            reportParameters.Add(new ReportParameter("OrderDate", OrderDate));
            reportParameters.Add(new ReportParameter("RequireDate", RequireDate));
            reportParameters.Add(new ReportParameter("Term", Term));
            reportParameters.Add(new ReportParameter("ShipVia", Via));
            reportParameters.Add(new ReportParameter("Contact", Contact));
            reportParameters.Add(new ReportParameter("SupplierID", SupplierID));
            reportParameters.Add(new ReportParameter("SupplierName", SupplierName));
            reportParameters.Add(new ReportParameter("SupplierAddress1", SupplierAddress1));
            reportParameters.Add(new ReportParameter("SupplierAddress2", SupplierAddress2));
            reportParameters.Add(new ReportParameter("SupplierTel", SupplierTel));
            reportParameters.Add(new ReportParameter("SupplierFax", SupplierFax));
            reportParameters.Add(new ReportParameter("SupplierCityStateZip", SupplierCityStateZip));
            reportParameters.Add(new ReportParameter("ShipName", ShipName));
            reportParameters.Add(new ReportParameter("ShipAddress1", ShipAddress1));
            reportParameters.Add(new ReportParameter("ShipAddress2", ShipAddress2));
            reportParameters.Add(new ReportParameter("ShipTel", ShipTel));
            reportParameters.Add(new ReportParameter("ShipFax", ShipFax));
            reportParameters.Add(new ReportParameter("ShipCityStateZip", ShipCityStateZip));
            reportParameters.Add(new ReportParameter("ExpectDate", ExpectDate));
            reportParameters.Add(new ReportParameter("TotalCase", TotalCase));
            reportParameters.Add(new ReportParameter("TotalAmount", TotalAmount));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.sp_Rpt_PORDERDETAILTableAdapter.Fill(this.PORDER.sp_Rpt_PORDERDETAIL, PONO);

            //this.reportViewer1.RefreshReport();
            var rds = new ReportDataSource("PORDER", this.PORDER.sp_Rpt_PORDERDETAIL as DataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            txt_attachedFile.Text = PONO;

        }

        private void Rpt_PORDER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PORDER.sp_Rpt_PORDERDETAIL' table. You can move, or remove it, as needed.
            //this.sp_Rpt_PORDERDETAILTableAdapter.Fill(this.PORDER.sp_Rpt_PORDERDETAIL, "PO002222");

            //this.reportViewer1.RefreshReport();
        }

        MemoryStream memoryStream = new MemoryStream();

        public static void sendMail(ReportViewer reportViewer, TextBox txt_attachedFile, TextBox txt_to, TextBox txt_subject, TextBox txt_body)
        {
            //SmtpClient client = new SmtpClient("email-out-priv.myregisteredsite.com", 25);
            SmtpClient client = new SmtpClient("mail.bcsroyal.com", 25);
            client.UseDefaultCredentials = false; // 시스템에 설정된 인증 정보를 사용하지 않는다.
            client.EnableSsl = false;  // SSL을 사용한다.
            client.DeliveryMethod = SmtpDeliveryMethod.Network; //  mail에 인증 받기.
            client.Credentials = new System.Net.NetworkCredential("eddie.lee@bcsroyal.com", "Milroi%^&78edle");

            MailAddress from = new MailAddress("eddie.lee@bcsroyal.com", "Eddie Lee", System.Text.Encoding.UTF8);
            MailAddress to = new MailAddress(txt_to.Text.Trim());

            MailMessage message = new MailMessage(from, to);

            message.Body = txt_body.Text.Trim();
            ///string someArrows = new string(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
            //message.Body += Environment.NewLine + someArrows;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.Subject = txt_subject.Text.Trim();
            message.SubjectEncoding = System.Text.Encoding.UTF8;

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            byte[] bytes = reportViewer.LocalReport.Render
        ("PDF", null, out mimeType, out encoding, out extension, out
        streamids, out warnings);

            MemoryStream memoryStream = new MemoryStream(bytes);
            memoryStream.Seek(0, SeekOrigin.Begin);

            string fileName = txt_attachedFile.Text + ".pdf";

            Attachment attachment = new Attachment(memoryStream, fileName);//

            message.Attachments.Add(attachment);

            try
            {
                // 동기로 메일을 보낸다.
                client.Send(message);

                // Clean up.
                message.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //MessageBox.Show("Done");



        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //txt_attachedFile.Text = PONO;

            if (groupBox1.Visible == false)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            sendMail(reportViewer1, txt_attachedFile, txt_to, txt_subject, txt_body);
            MessageBox.Show("Done", "Send Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void txt_from_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
