using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Certification;
using System.Net.NetworkInformation;
using System.Text;
using System.Net;
using System.IO;

namespace OBCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            ClientCertificate clientCertificate = new ClientCertificate();
            if (clientCertificate.Certified())
            {
                string proc = Process.GetCurrentProcess().ProcessName;
                Process[] processes = Process.GetProcessesByName(proc);
                if (processes.Length > 1)
                {
                    MessageBox.Show("Application is already running.\n\nOnly one instance open at a time.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Main());
                }
            }
            else
            {
                MessageBox.Show(clientCertificate.Exception(), "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                foreach (var process in Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName))
                {
                    process.Kill();
                }
            }
        }
    }
}
