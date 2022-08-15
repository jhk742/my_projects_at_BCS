using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Account
{
    public partial class GeneralJournalEntriesList : Form
    {
        public GeneralJournalEntriesList()
        {
            InitializeComponent();
            grid_header_Init();

            
        }

        private void grid_header_Init()
        {
            grid_header.AutoGenerateColumns = false;
            grid_header.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_header.ColumnCount = 4;

            grid_header.Columns[0].Name = "Date";
            grid_header.Columns[0].ReadOnly = true;
            grid_header.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_header.Columns[0].Width = 80;
            grid_header.Columns[0].DefaultCellStyle.Format = "MM'/'dd'/'yyyy";
            grid_header.Columns[0].DataPropertyName = "ACCDAT_0";

            grid_header.Columns[1].Name = "Entry Number";
            grid_header.Columns[1].ReadOnly = true;
            grid_header.Columns[1].Width = 100;
            grid_header.Columns[1].DataPropertyName = "NUM_0";

            grid_header.Columns[2].Name = "Company";
            grid_header.Columns[2].ReadOnly = true;
            grid_header.Columns[2].Width = 80;
            grid_header.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_header.Columns[2].DataPropertyName = "CPY_0";

            grid_header.Columns[3].Name = "Site";
            grid_header.Columns[3].ReadOnly = true;
            grid_header.Columns[3].Width = 80;
            grid_header.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_header.Columns[3].DataPropertyName = "FCY_0";

            //grid font size custom
            grid_header.RowTemplate.Height = 20;
            grid_header.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_header.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_header.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(GeneralJournalEntries))
                {
                    form.Activate();
                    return;
                }
            }
            GeneralJournalEntries generalJournalEntries = new GeneralJournalEntries("", DateTime.Today,"","");
            generalJournalEntries.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            String EntryNumber = txt_entryNumber.Text.Trim();

            DateTime FromDate = dateTimePickerFrom.Value;
            DateTime ToDate = dateTimePickerTo.Value;

            String FromDateString = FromDate.ToShortDateString();
            String ToDateString = ToDate.ToShortDateString();

            connSalesOrder.sp_ACCOUNT_GJE_HEADER(grid_header, EntryNumber, FromDateString, ToDateString);
        }

        private void grid_header_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // order id 잡고 있기

            String GJENumber = grid_header.Rows[e.RowIndex].Cells["Entry Number"].Value.ToString().Trim();
            DateTime AccountDate = Convert.ToDateTime(grid_header.Rows[e.RowIndex].Cells["Date"].Value.ToString().Trim());
            String Company = grid_header.Rows[e.RowIndex].Cells["Company"].Value.ToString().Trim();
            String Site = grid_header.Rows[e.RowIndex].Cells["Entry Number"].Value.ToString().Trim();

            GeneralJournalEntries generalJournalEntries = new GeneralJournalEntries(GJENumber, AccountDate, Company, Site);
            generalJournalEntries.ShowDialog();

        }

        private void txt_entryNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    refresh();
                }
                catch
                {

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
