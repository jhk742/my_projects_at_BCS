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
    public partial class GeneralJournalEntries : Form
    {
        public GeneralJournalEntries(String GJENumber, DateTime AccountDate, String Company, String Site)
        {
            InitializeComponent();

            txt_EntryNumber.Text = GJENumber;
            

            grid_journal_Init();

            //TODO: Add Company function
            //cbo_company.Items.Add("BCS");
            //cbo_company.Items.Add("IFONS");

            connPO.cbo_CompanyName(cbo_company);
            dateTimePicker_accountDate.Value = AccountDate;

            cbo_company.Text = Company;

            if (GJENumber != "")
            {
                cbo_company.Enabled = false;

                connSalesOrder.sp_ACCOUNT_GJE_DETAIL(grid_journal, GJENumber);

                for (int i = 0; i < 50; i++)
                {
                    DataTable dt = this.grid_journal.DataSource as DataTable;
                    DataRow dr = dt.NewRow();

                    dr["Account"] = "";
                    dr["Debit"] = "";
                    dr["Credit"] = "";
                    dr["Memo"] = "";
                    dr["Name"] = "";

                    dt.Rows.Add(dr);
                }
                    
            }
            else
            {
                cbo_company.Enabled = true;
                for (int i = 0; i < 50; i++)
                {
                    grid_journal.Rows.Add(new object[] { "", "", "", "", "" });
                }
            }

            calculate();



        }

        private void grid_journal_Init()
        {
            grid_journal.AutoGenerateColumns = false;
            grid_journal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_journal.ColumnCount = 3;

            DataGridViewComboBoxColumn AccountComboBox = new DataGridViewComboBoxColumn();
            AccountComboBox.Width = 300;
            AccountComboBox.MinimumWidth = 300;
            AccountComboBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            AccountComboBox.Name = "Account";
            AccountComboBox.Items.Add("");
            connSalesOrder.sp_GET_Accounts(AccountComboBox);
            AccountComboBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (grid_journal.Columns["Account"] == null)
            {
                grid_journal.Columns.Insert(0, AccountComboBox);
            }
            AccountComboBox.DataPropertyName = "Account";

            //grid_journal.Columns[0].Name = "Account";
            //grid_journal.Columns[0].ReadOnly = false;
            //grid_journal.Columns[0].Width = 100;
            //grid_journal.Columns[0].MinimumWidth = 100;
            //grid_journal.Columns[0].DataPropertyName = "Account";

            grid_journal.Columns[1].Name = "Debit";
            grid_journal.Columns[1].ReadOnly = false;
            grid_journal.Columns[1].Width = 150;
            grid_journal.Columns[1].MinimumWidth = 150;
            grid_journal.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_journal.Columns[1].DefaultCellStyle.Format = "N2";
            grid_journal.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_journal.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_journal.Columns[1].DataPropertyName = "Debit";

            grid_journal.Columns[2].Name = "Credit";
            grid_journal.Columns[2].ReadOnly = false;
            grid_journal.Columns[2].Width = 150;
            grid_journal.Columns[2].MinimumWidth = 150;
            grid_journal.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_journal.Columns[2].DefaultCellStyle.Format = "N2";
            grid_journal.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_journal.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_journal.Columns[2].DataPropertyName = "Credit";

            grid_journal.Columns[3].Name = "Memo";
            grid_journal.Columns[3].ReadOnly = false;
            grid_journal.Columns[3].Width = 250;
            grid_journal.Columns[3].MinimumWidth = 250;
            grid_journal.Columns[3].DataPropertyName = "Memo";

            DataGridViewComboBoxColumn NameComboBox = new DataGridViewComboBoxColumn();
            NameComboBox.Width = 200;
            NameComboBox.MinimumWidth = 200;
            NameComboBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NameComboBox.Name = "Name";
            NameComboBox.Items.Add("");
            connSalesOrder.sp_ACCOUNT_GENERALJOURNALENTRIES_NAME(NameComboBox);
            AccountComboBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (grid_journal.Columns["Name"] == null)
            {
                grid_journal.Columns.Insert(4, NameComboBox);
            }
            NameComboBox.DataPropertyName = "Name";


            //grid font size custom
            grid_journal.RowTemplate.Height = 20;
            grid_journal.ColumnHeadersHeight = 100;

            foreach (DataGridViewColumn c in grid_journal.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
            }

            grid_journal.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
        }

        

        private void grid_journal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if(e.ColumnIndex == 1)
            {
                try
                {
                    decimal Debit = Convert.ToDecimal(grid_journal.Rows[e.RowIndex].Cells["Debit"].Value.ToString().Trim());

                    grid_journal.Rows[e.RowIndex].Cells["Debit"].Value = Debit.ToString("N2");

                    grid_journal.Rows[e.RowIndex].Cells["Credit"].Value = "";
                }
                catch
                {

                }
            } else if(e.ColumnIndex == 2)
            {
                try
                {
                    decimal Credit = Convert.ToDecimal(grid_journal.Rows[e.RowIndex].Cells["Credit"].Value.ToString().Trim());

                    grid_journal.Rows[e.RowIndex].Cells["Credit"].Value = Credit.ToString("N2");

                    grid_journal.Rows[e.RowIndex].Cells["Debit"].Value = "";
                }
                catch
                {

                }
            }
            calculate();
        }

        private void calculate()
        {
            Decimal TotalDebit = 0;
            Decimal TotalCredit = 0;

            for (int i = 0; i < grid_journal.RowCount; i++)
            {
                //MessageBox.Show(grid_journal.Rows[i].Cells["Debit"].Value.ToString().Trim());
                if (grid_journal.Rows[i].Cells["Debit"].Value.ToString().Trim() != "")
                {
                    TotalDebit = TotalDebit + Convert.ToDecimal(grid_journal.Rows[i].Cells["Debit"].Value.ToString().Trim());
                }

                if (grid_journal.Rows[i].Cells["Credit"].Value.ToString().Trim() != "")
                {
                    TotalCredit = TotalCredit + Convert.ToDecimal(grid_journal.Rows[i].Cells["Credit"].Value.ToString().Trim());
                }

            }

            txt_totalDebit.Text = TotalDebit.ToString("N2");
            txt_totalCredit.Text = TotalCredit.ToString("N2");

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_totalDebit.Text != txt_totalCredit.Text)
            {
                MessageBox.Show("The transaction is not in balance. Please make sure the total amount in the debit column equals the total amount in the credit column."
                                                        , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbo_company.Text.Trim() == "")
            {
                MessageBox.Show("Select company."
                                                        , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < grid_journal.RowCount; i++)
            {
                if (grid_journal.Rows[i].Cells["Account"].Value.ToString().Trim() != "" && 
                    (grid_journal.Rows[i].Cells["Debit"].Value.ToString().Trim() == "" && grid_journal.Rows[i].Cells["Credit"].Value.ToString().Trim() == "") )
                {
                    MessageBox.Show("Account , Debit, Credit");
                    return;
                }

            }

            DialogResult dialogResult = MessageBox.Show("Do you want to record your changes?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                String NewGJENumber;
                if (txt_EntryNumber.Text.Trim() == "")
                {
                    NewGJENumber = connSalesOrder.sp_GET_NewGJENumber();
                }
                else
                {
                    NewGJENumber = txt_EntryNumber.Text.Trim();
                }

                DateTime AccountDate = dateTimePicker_accountDate.Value.Date;
                String Company = cbo_company.Text.Trim();
                
                if (txt_EntryNumber.Text.Trim() == "")
                {
                    connSalesOrder.sp_GJE_INSERT_HEADER(NewGJENumber, NewGJENumber, AccountDate, Company);
                }
                else
                {
                    connSalesOrder.sp_GJE_UPDATE_HEADER(NewGJENumber, AccountDate);
                }

                int line = 1;
                for (int i = 0; i < grid_journal.RowCount; i++)
                {
                    if (grid_journal.Rows[i].Cells["Account"].Value.ToString().Trim() != "")
                    {
                        string ACC = grid_journal.Rows[i].Cells["Account"].Value.ToString().Trim();
                        decimal Amount;
                        string Memo = grid_journal.Rows[i].Cells["Memo"].Value.ToString().Trim();
                        string Name = grid_journal.Rows[i].Cells["Name"].Value.ToString().Trim();
                        if (grid_journal.Rows[i].Cells["Debit"].Value.ToString().Trim() == "") //Credit
                        {
                            Amount = Convert.ToDecimal(grid_journal.Rows[i].Cells["Credit"].Value.ToString().Trim());
                            connSalesOrder.sp_GJE_INSERT_DETAIL(NewGJENumber, NewGJENumber, AccountDate, line, Company, ACC, Name, Amount, -1, Memo);
                        }
                        else if (grid_journal.Rows[i].Cells["Credit"].Value.ToString().Trim() == "") //Debit
                        {
                            Amount = Convert.ToDecimal(grid_journal.Rows[i].Cells["Debit"].Value.ToString().Trim());
                            connSalesOrder.sp_GJE_INSERT_DETAIL(NewGJENumber, NewGJENumber, AccountDate, line, Company, ACC, Name, Amount, 1, Memo);
                        }
                        line++;
                    }
                }

                
                if (txt_EntryNumber.Text.Trim() == "")
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Saved."
                                                        , "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }

            
        }

        private void btn_newLine_Click(object sender, EventArgs e)
        {
            if(txt_EntryNumber.Text.Trim() == "")
            {
                grid_journal.Rows.Add(new object[] { "", "", "", "", "" });
            }
            else
            {
                DataTable dt = this.grid_journal.DataSource as DataTable;
                DataRow dr = dt.NewRow();

                dr["Account"] = "";
                dr["Debit"] = "";
                dr["Credit"] = "";
                dr["Memo"] = "";
                dr["Name"] = "";

                dt.Rows.Add(dr);
            }
            
        }

    }
}
