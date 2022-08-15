using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Purchase
{
    public partial class testing : Form
    {
        public testing()
        {
            InitializeComponent();
        }



        private Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {

                for (int i = 0; i < totalProcess; i++)

                {

                    progressReport.PercentComplete = index++ * 100 / totalProcess;

                    progress.Report(progressReport);

                    Thread.Sleep(20); //used to simulate length of operation

                }

            });

        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            /*
            String POFromX3 = "Unchecked";
            DateTime FromDate = dateTimePickerFromDate.Value.Date;
            DateTime AsOfDate = dateTimePickerAsOf.Value.Date;
            String SupplierID = cbo_SupplierID.Text.Trim();
            String CheckNumber = txt_checkNo.Text.Trim();
            String POOpenStatus = cbo_poOpenStatus.Text.Trim();
            connSalesOrder.sp_PurchaseOrderExceptionReport(grid_AR, FromDate, AsOfDate, CheckNumber, SupplierID, POOpenStatus, POFromX3);
            */
            

            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i.ToString());
            }
            lblStatus.Text = "Working...";
            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {

                lblStatus.Text = string.Format("Procesing...{0}%", report.PercentComplete);
                progressBar.Value = report.PercentComplete;
                progressBar.Update();
                
            };
            await ProcessData(list, progress);
            lblStatus.Text = "Done !";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 50;

            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            // INSERT TIME CONSUMING OPERATIONS HERE
            // THAT DON'T REPORT PROGRESS
            //Thread.Sleep(3000);
            String POFromX3 = "Unchecked";
            DateTime FromDate = dateTimePickerFromDate.Value.Date;
            DateTime AsOfDate = dateTimePickerAsOf.Value.Date;
            String SupplierID = cbo_SupplierID.Text.Trim();
            String CheckNumber = txt_checkNo.Text.Trim();
            String POOpenStatus = cbo_poOpenStatus.Text.Trim();
            connSalesOrder.sp_PurchaseOrderExceptionReport(grid_AR, FromDate, AsOfDate, CheckNumber, SupplierID, POOpenStatus, POFromX3);

        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = progressBar.Minimum;

            MessageBox.Show("Done!");
        }


        public class ProgressReport
        {
            public int PercentComplete { get; set; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(this.BackColor);
            Rectangle rect = new Rectangle(10, 30, 100, 100);
            g.DrawRectangle(Pens.Black, rect);
            g.Dispose();
        }
    }
}
