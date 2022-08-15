using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Sales
{
    public partial class uploadFile : Form
    {
        public uploadFile()
        {
            InitializeComponent();

            grid_Customer_Init();
            grid_Customer2_Init();

            refresh();
            refreshNewProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WebClient client = new WebClient();
            //string myFile = @"C:\BCS\test1.txt";
            //client.Credentials = CredentialCache.DefaultCredentials;
            //client.UploadFile(@"http://192.168.1.28:8003/webApplication3/catalog/test1.txt", "POST", myFile);
            //client.Dispose();

            //FtpWebRequest ftpReq = (FtpWebRequest)WebRequest.Create("http://69.38.128.78:21/catalog/test1.txt");

            //ftpReq.UseBinary = true;
            //ftpReq.Method = WebRequestMethods.Ftp.UploadFile;
            //ftpReq.Credentials = new NetworkCredential("ftp_user", "Royal##55");

            //byte[] b = File.ReadAllBytes(@"C:\BCS\test1.txt");
            //ftpReq.ContentLength = b.Length;
            //using (Stream s = ftpReq.GetRequestStream())
            //{
            //    s.Write(b, 0, b.Length);
            //}

            //FtpWebResponse ftpResp = (FtpWebResponse)ftpReq.GetResponse();

            //if (ftpResp != null)
            //{
            //    if (ftpResp.StatusDescription.StartsWith("226"))
            //    {
            //        //Console.WriteLine("File Uploaded.");
            //        MessageBox.Show("File Uploaded.");
            //    }
            //}


            ////Use WebClient
            //WebClient client = new WebClient();
            //client.Credentials = new NetworkCredential("ftp_user", "Royal##55");
            //client.UploadFile(
            //    "ftp://69.38.128.78:21/test11.txt", @"C:\BCS\test1.txt");

            //FtpUploadAsync("ftp://69.38.128.78:21/test12.txt", "ftp_user", "Royal##55", @"C:\BCS\test1.txt");
            FtpUpload();
        }

        public static async Task<FtpStatusCode> FtpUploadAsync(string folder, string fileName, string filePath, TextBox textBox, Action action)
        {
            string ftp = "ftp://69.38.128.78:21/";
            string username = "ftp_user";
            string password = "Royal##55";
            

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftp + folder+ "/" + fileName);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(username, password);
            // request.UsePassive is true by default.

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (Stream requestStream = request.GetRequestStream())
            {
                await fileStream.CopyToAsync(requestStream);
            }

            using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
            {
                //MessageBox.Show(response.StatusCode.ToString());
                MessageBox.Show(response.StatusDescription.ToString());
                textBox.Text = "";
                action();
                return response.StatusCode;
            }
            
        }



        public void FtpUpload()
        {

            // 코드 단순화를 위해 하드코드함
            string ftpPath = "ftp://69.38.128.78:21/catalog/01nut.pdf";
            string user = "ftp_user";
            string pwd = "Royal##55";
            string inputFile = @"C:\BCS\CatalogTest.pdf";

            // WebRequest.Create로 Http,Ftp,File Request 객체를 모두 생성할 수 있다.
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(ftpPath);
            // FTP 업로드한다는 것을 표시
            req.Method = WebRequestMethods.Ftp.UploadFile;
            // 쓰기 권한이 있는 FTP 사용자 로그인 지정
            req.Credentials = new NetworkCredential(user, pwd);

            // 입력파일을 바이트 배열로 읽음
            byte[] data;

            try
            {
                using (StreamReader reader = new StreamReader(inputFile))
                {
                    data = Encoding.UTF8.GetBytes(reader.ReadToEnd());
                }
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            // RequestStream에 데이타를 쓴다
            req.ContentLength = data.Length;
            try
            {
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                }
            }
            catch(WebException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            

            try
            {
                // FTP Upload 실행
                using (FtpWebResponse resp = (FtpWebResponse)req.GetResponse())
                {
                    // FTP 결과 상태 출력
                    //Console.WriteLine("Upload: {0}", resp.StatusDescription);
                    //MessageBox.Show("Upload: {0}", resp.StatusDescription);
                    MessageBox.Show(resp.StatusDescription.ToString());
                    //226 transfer complete.
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(((FtpWebResponse)ex.Response).StatusDescription);
            }
        }

        private void grid_Customer_Init()
        {
            customGrid1.AutoGenerateColumns = false;
            customGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customGrid1.ColumnCount = 3;

            customGrid1.Columns[0].Name = "File Name";
            customGrid1.Columns[0].ReadOnly = true;
            customGrid1.Columns[0].Visible = true;
            customGrid1.Columns[0].Width = 150;
            customGrid1.Columns[0].MinimumWidth = 150;
            customGrid1.Columns[0].DataPropertyName = "";

            customGrid1.Columns[1].Name = "File Size";
            customGrid1.Columns[1].ReadOnly = true;
            customGrid1.Columns[1].Visible = true;
            customGrid1.Columns[1].Width = 100;
            customGrid1.Columns[1].MinimumWidth = 100;
            customGrid1.Columns[1].DataPropertyName = "";

            customGrid1.Columns[2].Name = "Last Modified";
            customGrid1.Columns[2].ReadOnly = true;
            customGrid1.Columns[2].Visible = true;
            customGrid1.Columns[2].Width = 220;
            customGrid1.Columns[2].MinimumWidth = 220;
            //customGrid1.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss tt";
            customGrid1.Columns[2].DataPropertyName = "";

            //grid font size custom
            customGrid1.RowTemplate.Height = 20;
            customGrid1.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in customGrid1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            customGrid1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void grid_Customer2_Init()
        {
            customGrid2.AutoGenerateColumns = false;
            customGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customGrid2.ColumnCount = 3;

            customGrid2.Columns[0].Name = "File Name";
            customGrid2.Columns[0].ReadOnly = true;
            customGrid2.Columns[0].Visible = true;
            customGrid2.Columns[0].Width = 150;
            customGrid2.Columns[0].MinimumWidth = 150;
            customGrid2.Columns[0].DataPropertyName = "";

            customGrid2.Columns[1].Name = "File Size";
            customGrid2.Columns[1].ReadOnly = true;
            customGrid2.Columns[1].Visible = true;
            customGrid2.Columns[1].Width = 100;
            customGrid2.Columns[1].MinimumWidth = 100;
            customGrid2.Columns[1].DataPropertyName = "";

            customGrid2.Columns[2].Name = "Last Modified";
            customGrid2.Columns[2].ReadOnly = true;
            customGrid2.Columns[2].Visible = true;
            customGrid2.Columns[2].Width = 220;
            customGrid2.Columns[2].MinimumWidth = 220;
            //customGrid2.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss tt";
            customGrid2.Columns[2].DataPropertyName = "";

            //grid font size custom
            customGrid2.RowTemplate.Height = 20;
            customGrid2.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in customGrid2.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            customGrid2.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void refresh()
        {
            customGrid1.DataSource = null;
            customGrid1.Rows.Clear();
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(@"ftp://69.38.128.78:21/catalog/");
            request.Credentials = new NetworkCredential("ftp_user", "Royal##55");
            //request.Method = WebRequestMethods.Ftp.ListDirectory;//ListDirectoryDetails;
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            try
            {
                StreamReader streamReader = new StreamReader(request.GetResponse().GetResponseStream());
                string fileName = streamReader.ReadLine();


                while (fileName != null)
                {
                    string[] row1 = new string[] { fileName };
                    customGrid1.Rows.Add(row1);
                    Console.WriteLine(fileName);
                    fileName = streamReader.ReadLine();
                }

                request = null;
                streamReader = null;
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
                return;//macbook pro late 2020 13
            }

            for (int i = 0; i < customGrid1.Rows.Count; i++)
            {
                string file = customGrid1.Rows[i].Cells["File Name"].Value.ToString();
                request = (FtpWebRequest)WebRequest.Create(@"ftp://69.38.128.78:21/catalog/" + file);
                request.Credentials = new NetworkCredential("ftp_user", "Royal##55");
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                response = (FtpWebResponse)request.GetResponse();
                //MessageBox.Show(response.ContentLength.ToString());
                decimal size = response.ContentLength / 1024;
                customGrid1.Rows[i].Cells["File Size"].Value = size.ToString("N0") + " KB";
                response.Close();

                FtpWebRequest request2 = (FtpWebRequest)WebRequest.Create(@"ftp://69.38.128.78:21/catalog/" + file);
                request2.Credentials = new NetworkCredential("ftp_user", "Royal##55");
                request2.Method = WebRequestMethods.Ftp.GetDateTimestamp;
                FtpWebResponse response2 = (FtpWebResponse)request2.GetResponse();
                customGrid1.Rows[i].Cells["Last Modified"].Value = response2.LastModified.ToString("MM/dd/yyyy HH:mm:ss tt");

            }

            response.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void deleteFile()
        {
            string fileName = "CatalogTest.pdf";

            FtpWebRequest requestFileDelete = (FtpWebRequest)WebRequest.Create(@"ftp://69.38.128.78:21/" + fileName);
            requestFileDelete.Credentials = new NetworkCredential("ftp_user", "Royal##55");
            requestFileDelete.Method = WebRequestMethods.Ftp.DeleteFile;

            try
            {
                //FtpWebResponse responseFileDelete = (FtpWebResponse)requestFileDelete.GetResponse();
                using (FtpWebResponse responseFileDelete = (FtpWebResponse)requestFileDelete.GetResponse())
                {
                    // FTP 결과 상태 출력
                    //Console.WriteLine("Upload: {0}", resp.StatusDescription);
                    //MessageBox.Show("Upload: {0}", resp.StatusDescription);
                    MessageBox.Show(responseFileDelete.StatusDescription.ToString());
                    //250 DELE command successful.
                }
            }
            catch(WebException ex)
            {
                MessageBox.Show(((FtpWebResponse)ex.Response).StatusDescription);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteFile();
        }

        
        private void btn_fileNut_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_nut.Text = openFileDialog1.FileName;
        }

        private void btn_fileConfectionary_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_confectionery.Text = openFileDialog1.FileName;
        }
        private string user = "ftp_user";
        private string pw = "Royal##55";
        private string ftp = "ftp://69.38.128.78:21/catalog/";

        private void btn_uploadNut_Click(object sender, EventArgs e)
        {
            //FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://69.38.128.78:21/catalog/01nut.pdf");
            //request.Method = WebRequestMethods.Ftp.UploadFile;
            //request.Credentials = new NetworkCredential("ftp_user", "Royal##55");
            //// request.UsePassive is true by default.

            //using (FileStream fileStream = new FileStream(txt_nut.Text.Trim(), FileMode.Open, FileAccess.Read))
            //using (Stream requestStream = request.GetRequestStream())
            //{
            //    fileStream.CopyToAsync(requestStream);
            //}

            //using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            //{
            //    // FTP 결과 상태 출력
            //    //Console.WriteLine("Upload: {0}", resp.StatusDescription);
            //    //MessageBox.Show("Upload: {0}", resp.StatusDescription);
            //    MessageBox.Show(response.StatusDescription.ToString());
            //    //250 DELE command successful.
            //}

            FtpUploadAsync("catalog", "01nut.pdf", txt_nut.Text.Trim(), txt_nut, refresh);


            //using (OpenFileDialog ofd=new OpenFileDialog() { Multiselect=false,ValidateNames=true,Filter="pdf files|*.pdf"})
            //{
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        FileInfo fi = new FileInfo(ofd.FileName);
            //        _inputParameter.UserName = "ftp_user";
            //        _inputParameter.Password = "Royal##55";
            //        _inputParameter.Server = "ftp://69.38.128.78:21/catalog";
            //        _inputParameter.FileName = txt_nut.Text.Trim();
            //        backgroundWorker1.RunWorkerAsync(_inputParameter);
            /*
            CHECK THIS OUT 나는 정 상 수
            백발백중 하는 명 사 수
            부산진구 유명가수
            일취월장 하며 성장 중
            내가 대표해 이 거리를
            누구도 막지 못해 내 지껄임을
            사양할게 너의 벌쓰 피처링은
            이건 나의 TRACK MY SWAG
            노린 RAP ATTACK
            난 계속해서 매섭게 쏘겠어
            죄 속에서 날 대속해 주신 주
            운명의 추 악전고투
            성난 황소같은 삶과 벌이는 투우
            세상의 바다를 부유
            주님따라 RUN TO YOU
            */
            //
            //    }
            //}

        }
        FtpSetting _inputParameter;
        struct FtpSetting
        {
            public string Server { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string FileName { get; set; }
            public string FullName { get; set; }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string fileName = ((FtpSetting)e.Argument).FileName;
            string fullName = ((FtpSetting)e.Argument).FullName;
            string userName = ((FtpSetting)e.Argument).UserName;
            string password = ((FtpSetting)e.Argument).Password;
            string server = ((FtpSetting)e.Argument).Server;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(fileName);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("ftp_user", "Royal##55");
            Stream ftpStream = request.GetRequestStream();
            FileStream fs = File.OpenRead(txt_nut.Text.Trim());

            byte[] buffer;
            int bufferint = 0;

            try
            {
                using (StreamReader reader = new StreamReader(txt_nut.Text.Trim()))
                {
                    buffer = Encoding.UTF8.GetBytes(reader.ReadToEnd());
                    bufferint = Convert.ToInt32(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            double total = (double)fs.Length;
            int byteRead = 0;
            double read = 0;
            do
            {
                if (!backgroundWorker1.CancellationPending)
                {
                    byteRead = fs.Read(buffer, 0, bufferint);
                    ftpStream.Write(buffer, 0, byteRead);
                    read += (double)byteRead;
                    double percentage = read / total * 100;
                    backgroundWorker1.ReportProgress((int)percentage);
                }
                
            }
            while (byteRead != 0);
            fs.Close();
            ftpStream.Close();

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbl_status.Text = $"Uploaded {e.ProgressPercentage} %";
            progressBar1.Value = e.ProgressPercentage;
            progressBar1.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbl_status.Text = "Upload complete!";
        }

        private void btn_uploadConfectionery_Click(object sender, EventArgs e)
        {
            FtpUploadAsync("catalog", "02confectionery.pdf", txt_confectionery.Text.Trim(), txt_confectionery, refresh);
        }

        private void btn_fileSnack_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_snack.Text = openFileDialog1.FileName;
        }

        private void btn_fileBeverage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_beverage.Text = openFileDialog1.FileName;
        }

        private void btn_fileTea_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_tea.Text = openFileDialog1.FileName;
        }

        private void btn_fileEuropean_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_european.Text = openFileDialog1.FileName;
        }

        private void btn_fileGourmet_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_gourmet.Text = openFileDialog1.FileName;
        }

        private void btn_fileAsian_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_asian.Text = openFileDialog1.FileName;
        }

        private void btn_fileDairy_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_dairy.Text = openFileDialog1.FileName;
        }

        private void btn_fileProduce_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_produce.Text = openFileDialog1.FileName;
        }

        private void btn_fileMeat_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_meat.Text = openFileDialog1.FileName;
        }

        private void btn_fileFrozen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_frozen.Text = openFileDialog1.FileName;
        }

        private void btn_fileNonfood_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_nonfood.Text = openFileDialog1.FileName;
        }

        private void btn_uploadSnack_Click(object sender, EventArgs e)
        {
            FtpUploadAsync("catalog", "03snack.pdf", txt_snack.Text.Trim(), txt_snack, refresh);
        }

        private void btn_uploadBeverage_Click(object sender, EventArgs e)
        {
            FtpUploadAsync("catalog", "04beverage.pdf", txt_beverage.Text.Trim(), txt_beverage, refresh);
        }

        private void btn_uploadTea_Click(object sender, EventArgs e)
        {
            FtpUploadAsync("catalog", "05tea.pdf", txt_tea.Text.Trim(), txt_tea, refresh);
        }

        private void btn_uploadEuropean_Click(object sender, EventArgs e)
        {
            FtpUploadAsync("catalog", "06european.pdf", txt_european.Text.Trim(), txt_european, refresh);
        }

        private void btn_uploadGourmet_Click(object sender, EventArgs e)
        {
            FtpUploadAsync("catalog", "07gourmet.pdf", txt_gourmet.Text.Trim(), txt_gourmet, refresh);
        }

        private void btn_uploadAsian_Click(object sender, EventArgs e)
        {
            FtpUploadAsync("catalog", "08asian.pdf", txt_asian.Text.Trim(), txt_asian, refresh);
        }

        private void btn_uploadDairy_Click(object sender, EventArgs e)
        {
            FtpUploadAsync("catalog", "09dairy.pdf", txt_dairy.Text.Trim(), txt_dairy, refresh);
        }

        private void btn_uploadProduce_Click(object sender, EventArgs e)
        {
            FtpUploadAsync("catalog", "10produce.pdf", txt_produce.Text.Trim(), txt_produce, refresh);
        }

        private void btn_uploadMeat_Click(object sender, EventArgs e)
        {
            FtpUploadAsync("catalog", "11meat.pdf", txt_meat.Text.Trim(), txt_meat, refresh);
        }

        private void btn_uploadFrozen_Click(object sender, EventArgs e)
        {
            FtpUploadAsync("catalog", "12frozen.pdf", txt_frozen.Text.Trim(), txt_frozen, refresh);
        }

        private void btn_uploadNonfood_Click(object sender, EventArgs e)
        {
            FtpUploadAsync("catalog", "13non-food.pdf", txt_nonfood.Text.Trim(), txt_nonfood, refresh);
        }

        private void btn_fileMainpage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_mainpage.Text = openFileDialog1.FileName;
        }

        private void btn_uploadMainpage_Click(object sender, EventArgs e)
        {
            FtpUploadAsync("catalog", "00main.pdf", txt_mainpage.Text.Trim(), txt_mainpage, refresh);
        }

        private void btn_fileNewProduct_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files|*.pdf";
            openFileDialog1.Title = "open pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            txt_newProduct.Text = openFileDialog1.FileName;
        }

        private void btn_uploadNewProduct_Click(object sender, EventArgs e)
        {
            FtpUploadAsync("newproduct","00newproduct.pdf", txt_newProduct.Text.Trim(), txt_newProduct, refreshNewProduct);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            refreshNewProduct();
        }

        private void refreshNewProduct()
        {
            customGrid2.DataSource = null;
            customGrid2.Rows.Clear();
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(@"ftp://69.38.128.78:21/newproduct/");
            request.Credentials = new NetworkCredential("ftp_user", "Royal##55");
            //request.Method = WebRequestMethods.Ftp.ListDirectory;//ListDirectoryDetails;
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            try
            {
                StreamReader streamReader = new StreamReader(request.GetResponse().GetResponseStream());
                string fileName = streamReader.ReadLine();


                while (fileName != null)
                {
                    string[] row1 = new string[] { fileName };
                    customGrid2.Rows.Add(row1);
                    Console.WriteLine(fileName);
                    fileName = streamReader.ReadLine();
                }

                request = null;
                streamReader = null;
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
                return;//macbook pro late 2020 13
            }

            for (int i = 0; i < customGrid2.Rows.Count; i++)
            {
                string file = customGrid2.Rows[i].Cells["File Name"].Value.ToString();
                request = (FtpWebRequest)WebRequest.Create(@"ftp://69.38.128.78:21/newproduct/" + file);
                request.Credentials = new NetworkCredential("ftp_user", "Royal##55");
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                response = (FtpWebResponse)request.GetResponse();
                decimal size = response.ContentLength / 1024;
                customGrid2.Rows[i].Cells["File Size"].Value = size.ToString("N0") + " KB";
                response.Close();

                FtpWebRequest request2 = (FtpWebRequest)WebRequest.Create(@"ftp://69.38.128.78:21/newproduct/" + file);
                request2.Credentials = new NetworkCredential("ftp_user", "Royal##55");
                request2.Method = WebRequestMethods.Ftp.GetDateTimestamp;
                FtpWebResponse response2 = (FtpWebResponse)request2.GetResponse();
                customGrid2.Rows[i].Cells["Last Modified"].Value = response2.LastModified.ToString("MM/dd/yyyy HH:mm:ss tt");
            }

            response.Close();
        }
    }
}
