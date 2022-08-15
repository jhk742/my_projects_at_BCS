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
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace OBCS.Purchase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txt_path.Text = openFileDialog.FileName;
                this.txt_sheet.Text = "Sheet1";
            }
            
        }

        private DataTable GetSheet(string excelPath)
        {
            string connstring = string.Empty;
            if (excelPath.IndexOf(".xlsx") > -1)
            {
                connstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelPath + ";Extended Properties=\"Excel 8.0;IMEX=1\"";
            }
            else
            {
                connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelPath + ";Extended Properties=\"Excel 8.0;IMEX=1\"";
            }

            OleDbConnection connect = new OleDbConnection(connstring);

            connect.Open();
            DataTable dt = connect.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            connect.Close();

            string sheetName = dt.Rows[0]["TABLE_NAME"].ToString();
            string sQuery = string.Format(" SELECT * FROM [{0}]", sheetName);

            dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(sQuery, connect);

            da.Fill(dt);

            grid_category.DataSource = dt;

            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //GetSheet(txt_path.Text);

            string PathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + txt_path.Text + "; Extended Properties=\"Excel 8.0;HDR=YES;\"; ";
            OleDbConnection conn = new OleDbConnection(PathConn);
            //conn.Open();
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + txt_sheet.Text + "$]", conn);
            DataTable dt = new DataTable();
            try
            {
                myDataAdapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Input the right Sheet name.");
            }

            grid_category.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
            String Category1, Category2, Category3, Category4, Category5;
            String Keyword1, Keyword2, Keyword3, Keyword4, Keyword5;
            int KLength1, KLength2, KLength3, KLength4, KLength5;

            String NotKeyword1, NotKeyword2, NotKeyword3, NotKeyword4, NotKeyword5;
            int NotKLength1, NotKLength2, NotKLength3, NotKLength4, NotKLength5;

            int i1, i2, i3, i4, i5;
            for (int i = 0; i < grid_category.RowCount; i++)
            {
                
                if (grid_category.Rows[i].Cells["Description"].Value == null || grid_category.Rows[i].Cells["Description"].Value == null)
                {
                    grid_category.Rows[i].Cells["Category"].Value = "";
                }
                else
                {
                    if (txt_cat1.Text != "")
                    {

                        KLength1 = txt_keywords1.Lines.Length;
                        KLength2 = txt_keywords2.Lines.Length;
                        KLength3 = txt_keywords3.Lines.Length;
                        KLength4 = txt_keywords4.Lines.Length;
                        KLength5 = txt_keywords5.Lines.Length;

                        NotKLength1 = txt_no1.Lines.Length;
                        NotKLength2 = txt_no2.Lines.Length;
                        NotKLength3 = txt_no3.Lines.Length;
                        NotKLength4 = txt_no4.Lines.Length;
                        NotKLength5 = txt_no5.Lines.Length;


                        for (i1 = 0; i1 < KLength1; i1++)
                        {
                            Category1 = txt_cat1.Text.ToString().ToUpper();
                            Keyword1 = txt_keywords1.Lines[i1].ToString().ToUpper();

                            if (grid_category.Rows[i].Cells["Category"].Value.ToString() == "" || grid_category.Rows[i].Cells["Category"].Value == null)
                            {
                                if (grid_category.Rows[i].Cells["Description"].Value.ToString().ToUpper().Contains(Keyword1.Trim()))
                                {
                                    if (Keyword1.Trim() != "")
                                    {
                                        grid_category.Rows[i].Cells["Category"].Value = Category1;
                                    }
                                }
                            }
                        }
                    

                        for (i2 = 0; i2 < KLength2; i2++)
                        {
                            Category2 = txt_cat2.Text.ToString().ToUpper();
                            Keyword2 = txt_keywords2.Lines[i2].ToString().ToUpper();

                            if (grid_category.Rows[i].Cells["Category"].Value.ToString() == "" || grid_category.Rows[i].Cells["Category"].Value == null)
                            {
                                if (grid_category.Rows[i].Cells["Description"].Value.ToString().ToUpper().Contains(Keyword2.Trim()))
                                {
                                    if (Keyword2.Trim() != "")
                                    {
                                        grid_category.Rows[i].Cells["Category"].Value = Category2;
                                    }
                                }
                            }
                        }

                        for (i3 = 0; i3 < KLength3; i3++)
                        {
                            Category3 = txt_cat3.Text.ToString().ToUpper();
                            Keyword3 = txt_keywords3.Lines[i3].ToString().ToUpper();

                            if (grid_category.Rows[i].Cells["Category"].Value.ToString() == "" || grid_category.Rows[i].Cells["Category"].Value == null)
                            {
                                if (grid_category.Rows[i].Cells["Description"].Value.ToString().ToUpper().Contains(Keyword3.Trim()))
                                {
                                    if (Keyword3.Trim() != "")
                                    {
                                        grid_category.Rows[i].Cells["Category"].Value = Category3;
                                    }
                                }
                            }
                        }

                        for (i4 = 0; i4 < KLength4; i4++)
                        {
                            Category4 = txt_cat4.Text.ToString().ToUpper();
                            Keyword4 = txt_keywords4.Lines[i4].ToString().ToUpper();

                            if (grid_category.Rows[i].Cells["Category"].Value.ToString() == "" || grid_category.Rows[i].Cells["Category"].Value == null)
                            {
                                if (grid_category.Rows[i].Cells["Description"].Value.ToString().ToUpper().Contains(Keyword4.Trim()))
                                {
                                    if (Keyword4.Trim() != "")
                                    {
                                        grid_category.Rows[i].Cells["Category"].Value = Category4;
                                    }
                                }
                            }
                        }

                        for (i5 = 0; i5 < KLength5; i5++)
                        {
                            Category5 = txt_cat5.Text.ToString().ToUpper();
                            Keyword5 = txt_keywords5.Lines[i5].ToString().ToUpper();

                            if (grid_category.Rows[i].Cells["Category"].Value.ToString() == "" || grid_category.Rows[i].Cells["Category"].Value == null)
                            {
                                if (grid_category.Rows[i].Cells["Description"].Value.ToString().ToUpper().Contains(Keyword5.Trim()))
                                {
                                    if (Keyword5.Trim() != "")
                                    {
                                        grid_category.Rows[i].Cells["Category"].Value = Category5;
                                    }
                                }
                            }
                        }

                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            fichero.FileName = "export.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                // changing the name of active sheet
                hoja_trabajo.Name = "Sheet1";
                // storing header part in Excel
                for (int i = 1; i < grid_category.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i] = grid_category.Columns[i - 1].HeaderText;
                }

                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 1; i < grid_category.Rows.Count + 1; i++)
                {
                    for (int j = 0; j < grid_category.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grid_category.Rows[i - 1].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

    }
}
