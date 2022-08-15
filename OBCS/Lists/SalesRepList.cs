using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Lists
{
    public partial class SalesRepList : Form
    {
        String SearchRepStatus = "";
        //String HBDREPString = "";
        public SalesRepList()
        {
            InitializeComponent();
            grid_SalesRep_Init();

            cbo_Branch.Items.Clear();
            connPO.cbo_branchCode(cbo_Branch);

            cbo_RepStatus.Items.Clear();
            cbo_RepStatus.Items.Add("Active");
            cbo_RepStatus.Items.Add("InActive");

            SearchRepStatus = "Active";

            cbo_SearchTeam.Items.Clear();
            cbo_SearchTeam.Items.Add("");
            connSalesOrder.sp_GET_SalesRepTeam(cbo_SearchTeam);

            connPO.sp_LIST_SALESREP(grid_SalesRep, txt_searchRepCode.Text.ToString(), cbo_SearchTeam.Text.ToString(), SearchRepStatus);

            cbo_Team.Items.Clear();
            cbo_Team.Items.Add("");
            connSalesOrder.sp_GET_SalesRepTeam(cbo_Team);

            cbo_RepType.Items.Clear();
            cbo_RepType.Items.Add("");
            cbo_RepType.Items.Add("Commission");
            cbo_RepType.Items.Add("Salary");

            //for (int i = 0; i < grid_SalesRep.RowCount; i++)
            //{
            //    DateTime BirthDay = Convert.ToDateTime(grid_SalesRep.Rows[i].Cells["BirthDay"].Value);
            //    String REP = grid_SalesRep.Rows[i].Cells["REP"].Value.ToString().Trim();
            //    String FirstName = grid_SalesRep.Rows[i].Cells["First Name"].Value.ToString().Trim();
            //    String MiddleName = grid_SalesRep.Rows[i].Cells["Middle Name"].Value.ToString().Trim();
            //    String LastName = grid_SalesRep.Rows[i].Cells["Last Name"].Value.ToString().Trim();
            //    if (DateTime.Now.Month.Equals(BirthDay.Month))
            //    {
            //        HBDREPString += REP + " ["+FirstName+" "+MiddleName+" "+LastName+"] : "+BirthDay.ToShortDateString()+"\n";
            //    }
            //}
            //if(HBDREPString.Length != 0)
            //{
            //    MessageBox.Show("ヾ(⌐■_■)ノ♪              \n\n" + HBDREPString, "┌iii┐ HBD List in " + DateTime.Now.ToString("MMMM")+ " ┌iii┐", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            if (connSalesOrder.sp_UserCheck("SALESREPLIST") == "0")
            {
                btn_new.Visible = false;
                panel_Goal.Visible = false;
                cbo_RepStatus.Enabled = false;
                lb_Goal.Visible = false;
                chb_Password.Visible = false;
                txt_Password.Visible = false;
            }

        }
        
        private void grid_SalesRep_Init()
        {
            grid_SalesRep.AutoGenerateColumns = false;
            grid_SalesRep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_SalesRep.ColumnCount = 35;

            grid_SalesRep.Columns[0].Name = "FCY";
            grid_SalesRep.Columns[0].ReadOnly = true;
            grid_SalesRep.Columns[0].Width = 40;
            grid_SalesRep.Columns[0].MinimumWidth = 40;
            grid_SalesRep.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[0].DataPropertyName = "FCY_0";

            grid_SalesRep.Columns[1].Name = "REPKEY_0";
            grid_SalesRep.Columns[1].Visible = false;
            grid_SalesRep.Columns[1].ReadOnly = true;
            grid_SalesRep.Columns[1].Width = 40;
            grid_SalesRep.Columns[1].MinimumWidth = 40;
            grid_SalesRep.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[1].DataPropertyName = "REPKEY_0";

            grid_SalesRep.Columns[2].Name = "REP";
            grid_SalesRep.Columns[2].ReadOnly = true;
            grid_SalesRep.Columns[2].Width = 40;
            grid_SalesRep.Columns[2].MinimumWidth = 40;
            grid_SalesRep.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[2].DataPropertyName = "REPNUM_0";

            grid_SalesRep.Columns[3].Name = "REPNAM_0";
            grid_SalesRep.Columns[3].ReadOnly = true;
            grid_SalesRep.Columns[3].Visible = false;
            grid_SalesRep.Columns[3].Width = 80;
            grid_SalesRep.Columns[3].MinimumWidth = 80;
            grid_SalesRep.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[3].DataPropertyName = "REPNAM_0";

            grid_SalesRep.Columns[4].Name = "First Name";
            grid_SalesRep.Columns[4].ReadOnly = true;
            grid_SalesRep.Columns[4].Width = 80;
            grid_SalesRep.Columns[4].MinimumWidth = 80;
            grid_SalesRep.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[4].DataPropertyName = "REPFNAM_0";

            grid_SalesRep.Columns[5].Name = "Middle Name";
            grid_SalesRep.Columns[5].ReadOnly = true;
            grid_SalesRep.Columns[5].Width = 80;
            grid_SalesRep.Columns[5].MinimumWidth = 80;
            grid_SalesRep.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[5].DataPropertyName = "REPMNAM_0";

            grid_SalesRep.Columns[6].Name = "Last Name";
            grid_SalesRep.Columns[6].ReadOnly = true;
            grid_SalesRep.Columns[6].Width = 80;
            grid_SalesRep.Columns[6].MinimumWidth = 80;
            grid_SalesRep.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[6].DataPropertyName = "REPLNAM_0";

            grid_SalesRep.Columns[7].Name = "TEAM";
            grid_SalesRep.Columns[7].ReadOnly = true;
            grid_SalesRep.Columns[7].Width = 60;
            grid_SalesRep.Columns[7].MinimumWidth = 60;
            grid_SalesRep.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[7].DataPropertyName = "REPTEAM_0";

            grid_SalesRep.Columns[8].Name = "Address";
            grid_SalesRep.Columns[8].ReadOnly = true;
            grid_SalesRep.Columns[8].Width = 150;
            grid_SalesRep.Columns[8].MinimumWidth = 150;
            grid_SalesRep.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[8].DataPropertyName = "REPADDLIG_0";

            grid_SalesRep.Columns[9].Name = "REPADDLIG_1";
            grid_SalesRep.Columns[9].Visible = false;
            grid_SalesRep.Columns[9].ReadOnly = true;
            grid_SalesRep.Columns[9].Width = 150;
            grid_SalesRep.Columns[9].MinimumWidth = 150;
            grid_SalesRep.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[9].DataPropertyName = "REPADDLIG_1";

            grid_SalesRep.Columns[10].Name = "TEL";
            grid_SalesRep.Columns[10].Visible = false;
            grid_SalesRep.Columns[10].ReadOnly = true;
            grid_SalesRep.Columns[10].Width = 100;
            grid_SalesRep.Columns[10].MinimumWidth = 100;
            grid_SalesRep.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[10].DataPropertyName = "TEL_0";

            grid_SalesRep.Columns[11].Name = "REPIPAD_0";
            grid_SalesRep.Columns[11].Visible = false;
            grid_SalesRep.Columns[11].ReadOnly = true;
            grid_SalesRep.Columns[11].Width = 100;
            grid_SalesRep.Columns[11].MinimumWidth = 100;
            grid_SalesRep.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[11].DataPropertyName = "REPIPAD_0";

            grid_SalesRep.Columns[12].Name = "REPGOAL_D";
            grid_SalesRep.Columns[12].Visible = false;
            grid_SalesRep.Columns[12].ReadOnly = true;
            grid_SalesRep.Columns[12].Width = 40;
            grid_SalesRep.Columns[12].MinimumWidth = 40;
            grid_SalesRep.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_SalesRep.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[12].DefaultCellStyle.Format = "N2";
            grid_SalesRep.Columns[12].DataPropertyName = "REPGOAL_D";

            grid_SalesRep.Columns[13].Name = "REPGOAL_M";
            grid_SalesRep.Columns[13].Visible = false;
            grid_SalesRep.Columns[13].ReadOnly = true;
            grid_SalesRep.Columns[13].Width = 40;
            grid_SalesRep.Columns[13].MinimumWidth = 40;
            grid_SalesRep.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_SalesRep.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[13].DefaultCellStyle.Format = "N2";
            grid_SalesRep.Columns[13].DataPropertyName = "REPGOAL_M";

            grid_SalesRep.Columns[14].Name = "REPGOAL_W";
            grid_SalesRep.Columns[14].Visible = false;
            grid_SalesRep.Columns[14].ReadOnly = true;
            grid_SalesRep.Columns[14].Width = 40;
            grid_SalesRep.Columns[14].MinimumWidth = 40;
            grid_SalesRep.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_SalesRep.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[14].DefaultCellStyle.Format = "N2";
            grid_SalesRep.Columns[14].DataPropertyName = "REPGOAL_W";

            grid_SalesRep.Columns[15].Name = "REPGOAL_Y";
            grid_SalesRep.Columns[15].Visible = false;
            grid_SalesRep.Columns[15].ReadOnly = true;
            grid_SalesRep.Columns[15].Width = 40;
            grid_SalesRep.Columns[15].MinimumWidth = 40;
            grid_SalesRep.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_SalesRep.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[15].DefaultCellStyle.Format = "N2";
            grid_SalesRep.Columns[15].DataPropertyName = "REPGOAL_Y";

            grid_SalesRep.Columns[16].Name = "CREUSR_0";
            grid_SalesRep.Columns[16].Visible = false;
            grid_SalesRep.Columns[16].ReadOnly = true;
            grid_SalesRep.Columns[16].Width = 40;
            grid_SalesRep.Columns[16].MinimumWidth = 40;
            grid_SalesRep.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[16].DataPropertyName = "CREUSR_0";

            grid_SalesRep.Columns[17].Name = "CREDATTIM_0";
            grid_SalesRep.Columns[17].Visible = false;
            grid_SalesRep.Columns[17].ReadOnly = true;
            grid_SalesRep.Columns[17].Width = 40;
            grid_SalesRep.Columns[17].MinimumWidth = 40;
            grid_SalesRep.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[17].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_SalesRep.Columns[17].DataPropertyName = "CREDATTIM_0";

            grid_SalesRep.Columns[18].Name = "UPDUSR";
            grid_SalesRep.Columns[18].ReadOnly = true;
            grid_SalesRep.Columns[18].Width = 80;
            grid_SalesRep.Columns[18].MinimumWidth = 80;
            grid_SalesRep.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[18].DataPropertyName = "UPDUSR_0";

            grid_SalesRep.Columns[19].Name = "UPDDATE";
            grid_SalesRep.Columns[19].ReadOnly = true;
            grid_SalesRep.Columns[19].Width = 100;
            grid_SalesRep.Columns[19].MinimumWidth = 100;
            grid_SalesRep.Columns[19].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_SalesRep.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[19].DataPropertyName = "UPDDATTIM_0";

            grid_SalesRep.Columns[20].Name = "IsInactive";
            grid_SalesRep.Columns[20].Visible = false;
            grid_SalesRep.Columns[20].ReadOnly = true;
            grid_SalesRep.Columns[20].Width = 40;
            grid_SalesRep.Columns[20].MinimumWidth = 40;
            grid_SalesRep.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[20].DataPropertyName = "IsInactive";

            grid_SalesRep.Columns[21].Name = "TGOAL_D";
            grid_SalesRep.Columns[21].Visible = false;
            grid_SalesRep.Columns[21].ReadOnly = true;
            grid_SalesRep.Columns[21].Width = 40;
            grid_SalesRep.Columns[21].MinimumWidth = 40;
            grid_SalesRep.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_SalesRep.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[21].DefaultCellStyle.Format = "N2";
            grid_SalesRep.Columns[21].DataPropertyName = "TGOAL_D";

            grid_SalesRep.Columns[22].Name = "TGOAL_M";
            grid_SalesRep.Columns[22].Visible = false;
            grid_SalesRep.Columns[22].ReadOnly = true;
            grid_SalesRep.Columns[22].Width = 40;
            grid_SalesRep.Columns[22].MinimumWidth = 40;
            grid_SalesRep.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_SalesRep.Columns[22].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[22].DefaultCellStyle.Format = "N2";
            grid_SalesRep.Columns[22].DataPropertyName = "TGOAL_M";

            grid_SalesRep.Columns[23].Name = "TGOAL_W";
            grid_SalesRep.Columns[23].Visible = false;
            grid_SalesRep.Columns[23].ReadOnly = true;
            grid_SalesRep.Columns[23].Width = 40;
            grid_SalesRep.Columns[23].MinimumWidth = 40;
            grid_SalesRep.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_SalesRep.Columns[23].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[23].DefaultCellStyle.Format = "N2";
            grid_SalesRep.Columns[23].DataPropertyName = "TGOAL_W";

            grid_SalesRep.Columns[24].Name = "TGOAL_Y";
            grid_SalesRep.Columns[24].Visible = false;
            grid_SalesRep.Columns[24].ReadOnly = true;
            grid_SalesRep.Columns[24].Width = 40;
            grid_SalesRep.Columns[24].MinimumWidth = 40;
            grid_SalesRep.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_SalesRep.Columns[24].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[24].DefaultCellStyle.Format = "N2";
            grid_SalesRep.Columns[24].DataPropertyName = "TGOAL_Y";

            grid_SalesRep.Columns[25].Name = "StartDate";
            grid_SalesRep.Columns[25].Visible = false;
            grid_SalesRep.Columns[25].ReadOnly = true;
            grid_SalesRep.Columns[25].Width = 100;
            grid_SalesRep.Columns[25].MinimumWidth = 100;
            grid_SalesRep.Columns[25].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_SalesRep.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[25].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[25].DataPropertyName = "StartDate";

            grid_SalesRep.Columns[26].Name = "BirthDay";
            grid_SalesRep.Columns[26].Visible = false;
            grid_SalesRep.Columns[26].ReadOnly = true;
            grid_SalesRep.Columns[26].Width = 100;
            grid_SalesRep.Columns[26].MinimumWidth = 100;
            grid_SalesRep.Columns[26].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid_SalesRep.Columns[26].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[26].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[26].DataPropertyName = "BirthDay";

            grid_SalesRep.Columns[27].Name = "REPTYP_0";
            grid_SalesRep.Columns[27].Visible = false;
            grid_SalesRep.Columns[27].ReadOnly = true;
            grid_SalesRep.Columns[27].Width = 15;
            grid_SalesRep.Columns[27].MinimumWidth = 15;
            grid_SalesRep.Columns[27].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[27].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[27].DataPropertyName = "REPTYP_0";

            grid_SalesRep.Columns[28].Name = "REPIPADSN_0";
            grid_SalesRep.Columns[28].Visible = false;
            grid_SalesRep.Columns[28].ReadOnly = true;
            grid_SalesRep.Columns[28].Width = 40;
            grid_SalesRep.Columns[28].MinimumWidth = 40;
            grid_SalesRep.Columns[28].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[28].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[28].DataPropertyName = "REPIPADSN_0";

            grid_SalesRep.Columns[29].Name = "REPIPADUD_0";
            grid_SalesRep.Columns[29].Visible = false;
            grid_SalesRep.Columns[29].ReadOnly = true;
            grid_SalesRep.Columns[29].Width = 40;
            grid_SalesRep.Columns[29].MinimumWidth = 40;
            grid_SalesRep.Columns[29].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[29].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[29].DataPropertyName = "REPIPADUD_0";

            grid_SalesRep.Columns[30].Name = "WeeklySalary";
            grid_SalesRep.Columns[30].Visible = false;
            grid_SalesRep.Columns[30].ReadOnly = true;
            grid_SalesRep.Columns[30].Width = 40;
            grid_SalesRep.Columns[30].MinimumWidth = 40;
            grid_SalesRep.Columns[30].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid_SalesRep.Columns[30].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SalesRep.Columns[30].DefaultCellStyle.Format = "N2";
            grid_SalesRep.Columns[30].DataPropertyName = "WeeklySalary";

            grid_SalesRep.Columns[31].Name = "CTY_0";
            grid_SalesRep.Columns[31].Visible = false;
            grid_SalesRep.Columns[31].ReadOnly = true;
            grid_SalesRep.Columns[31].Width = 40;
            grid_SalesRep.Columns[31].MinimumWidth = 40;
            grid_SalesRep.Columns[31].DataPropertyName = "CTY_0";

            grid_SalesRep.Columns[32].Name = "SAT_0";
            grid_SalesRep.Columns[32].Visible = false;
            grid_SalesRep.Columns[32].ReadOnly = true;
            grid_SalesRep.Columns[32].Width = 40;
            grid_SalesRep.Columns[32].MinimumWidth = 40;
            grid_SalesRep.Columns[32].DataPropertyName = "SAT_0";

            grid_SalesRep.Columns[33].Name = "POSCOD_0";
            grid_SalesRep.Columns[33].Visible = false;
            grid_SalesRep.Columns[33].ReadOnly = true;
            grid_SalesRep.Columns[33].Width = 40;
            grid_SalesRep.Columns[33].MinimumWidth = 40;
            grid_SalesRep.Columns[33].DataPropertyName = "POSCOD_0";

            grid_SalesRep.Columns[34].Name = "Password";
            grid_SalesRep.Columns[34].Visible = false;
            grid_SalesRep.Columns[34].ReadOnly = true;
            grid_SalesRep.Columns[34].Width = 40;
            grid_SalesRep.Columns[34].MinimumWidth = 40;
            grid_SalesRep.Columns[34].DataPropertyName = "Password";
            //grid font size custom
            grid_SalesRep.RowTemplate.Height = 20;
            grid_SalesRep.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_SalesRep.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }

            grid_SalesRep.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }

        private void cbo_SearchTeam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchSalesRep();
            }
        }
        private void searchSalesRep()
        {
            String SearchSalesRep = txt_searchRepCode.Text.Trim();
            String SearchTeam = cbo_SearchTeam.Text.Trim();
            
            if (cbx_inactive.Checked)
            {
                SearchRepStatus = "ALL";
            }
            else
            {
                SearchRepStatus = "Active";
            }
            connPO.sp_LIST_SALESREP(grid_SalesRep, SearchSalesRep, SearchTeam, SearchRepStatus);
            
        }

        private void Color_SetUp()
        {
            try
            {
                foreach (DataGridViewRow row in this.grid_SalesRep.Rows)
                {
                    if (Convert.ToInt32(row.Cells["IsInactive"].Value) == 1)
                    {
                        for (int i = 0; i < grid_SalesRep.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Gray;
                        }
                    }
                }
            }
            catch { }
        }

        private void txt_searchRepCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchSalesRep();
            }
        }
        private void cbx_inactive_CheckedChanged(object sender, EventArgs e)
        {
            searchSalesRep();
        }

        private void grid_SalesRep_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_RepCode.Text = grid_SalesRep.Rows[e.RowIndex].Cells["REP"].Value.ToString().Trim();
            txt_RepFName.Text = grid_SalesRep.Rows[e.RowIndex].Cells["First Name"].Value.ToString().Trim();
            txt_RepMName.Text = grid_SalesRep.Rows[e.RowIndex].Cells["Middle Name"].Value.ToString().Trim();
            txt_RepLName.Text = grid_SalesRep.Rows[e.RowIndex].Cells["Last Name"].Value.ToString().Trim();
            cbo_Branch.Text = grid_SalesRep.Rows[e.RowIndex].Cells["FCY"].Value.ToString().Trim();
            cbo_Team.Text = grid_SalesRep.Rows[e.RowIndex].Cells["TEAM"].Value.ToString().Trim();
            txt_city.Text = grid_SalesRep.Rows[e.RowIndex].Cells["CTY_0"].Value.ToString().Trim();
            txt_stateCode.Text = grid_SalesRep.Rows[e.RowIndex].Cells["SAT_0"].Value.ToString().Trim();
            txt_postalCode.Text = grid_SalesRep.Rows[e.RowIndex].Cells["POSCOD_0"].Value.ToString().Trim();
            cbo_RepStatus.Text = (Convert.ToInt32(grid_SalesRep.Rows[e.RowIndex].Cells["IsInactive"].Value) == 0 ? "Active" : "InActive");
            txt_Address1.Text = grid_SalesRep.Rows[e.RowIndex].Cells["Address"].Value.ToString().Trim();
            txt_Address2.Text = grid_SalesRep.Rows[e.RowIndex].Cells["REPADDLIG_1"].Value.ToString().Trim();
            txt_Tel.Text = grid_SalesRep.Rows[e.RowIndex].Cells["TEL"].Value.ToString().Trim();
            txt_IpadUDID.Text = grid_SalesRep.Rows[e.RowIndex].Cells["REPIPADUD_0"].Value.ToString().Trim();
            txt_IpadSerialNo.Text = grid_SalesRep.Rows[e.RowIndex].Cells["REPIPADSN_0"].Value.ToString().Trim();
            txt_IpadDesc.Text = grid_SalesRep.Rows[e.RowIndex].Cells["REPIPAD_0"].Value.ToString().Trim();
            txt_RepGoalD.Text = grid_SalesRep.Rows[e.RowIndex].Cells["REPGOAL_D"].Value.ToString().Trim();
            txt_RepGoalM.Text = grid_SalesRep.Rows[e.RowIndex].Cells["REPGOAL_M"].Value.ToString().Trim();
            txt_RepGoalW.Text = grid_SalesRep.Rows[e.RowIndex].Cells["REPGOAL_W"].Value.ToString().Trim();
            txt_RepGoalY.Text = grid_SalesRep.Rows[e.RowIndex].Cells["REPGOAL_Y"].Value.ToString().Trim();
            txt_TeamGoalD.Text = grid_SalesRep.Rows[e.RowIndex].Cells["TGOAL_D"].Value.ToString().Trim();
            txt_TeamGoalM.Text = grid_SalesRep.Rows[e.RowIndex].Cells["TGOAL_M"].Value.ToString().Trim();
            txt_TeamGoalW.Text = grid_SalesRep.Rows[e.RowIndex].Cells["TGOAL_W"].Value.ToString().Trim();
            txt_TeamGoalY.Text = grid_SalesRep.Rows[e.RowIndex].Cells["TGOAL_Y"].Value.ToString().Trim();
            cbo_RepType.Text = grid_SalesRep.Rows[e.RowIndex].Cells["REPTYP_0"].Value.ToString().Trim();
            dateTimePicker_Birthday.Value = Convert.ToDateTime(grid_SalesRep.Rows[e.RowIndex].Cells["BirthDay"].Value);
            dateTimePicker_RepSince.Value = Convert.ToDateTime(grid_SalesRep.Rows[e.RowIndex].Cells["StartDate"].Value);
            txt_WeeklySalary.Text = grid_SalesRep.Rows[e.RowIndex].Cells["WeeklySalary"].Value.ToString().Trim();
            txt_Password.Text = grid_SalesRep.Rows[e.RowIndex].Cells["Password"].Value.ToString().Trim();

            btn_save.Enabled = true;
            btn_newSave.Visible = false;
            btn_new.Enabled = true;
            txt_RepCode.Enabled = false;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_RepCode.Text = "";
            txt_RepFName.Text = "";
            txt_RepMName.Text = "";
            txt_RepLName.Text = "";
            cbo_Branch.Text = "";
            cbo_Team.Text = "";
            cbo_RepStatus.Text = "";
            txt_Address1.Text = "";
            txt_Address2.Text = "";
            txt_city.Text = "";
            txt_stateCode.Text = "";
            txt_postalCode.Text = "";
            txt_Tel.Text = "";
            txt_IpadUDID.Text = "";
            txt_IpadDesc.Text = "";
            txt_IpadSerialNo.Text = "";
            txt_RepGoalD.Text = "0.0";
            txt_RepGoalM.Text = "0.0";
            txt_RepGoalW.Text = "0.0";
            txt_RepGoalY.Text = "0.0";
            txt_TeamGoalD.Text = "0.0";
            txt_TeamGoalM.Text = "0.0";
            txt_TeamGoalW.Text = "0.0";
            txt_TeamGoalY.Text = "0.0";
            txt_WeeklySalary.Text = "0.0";
            cbo_RepType.Text = "";
            chb_Password.Checked = true;
            txt_Password.Text = "";
            
            dateTimePicker_Birthday.Value = DateTime.Now.Date;
            dateTimePicker_RepSince.Value = DateTime.Now.Date;

            txt_RepCode.Enabled = true;
            btn_save.Enabled = false;
            btn_newSave.Visible = true;
            //btn_new.Enabled = false;

        }
        private void txt_GOAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirming update Rep, " + txt_RepCode.Text.Trim() + " information."
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    String REPNUM_0 = txt_RepCode.Text.ToString();
                    String REPFNAM_0 = txt_RepFName.Text.ToString();
                    String REPMNAM_0 = txt_RepMName.Text.ToString();
                    String REPLNAM_0 = txt_RepLName.Text.ToString();
                    String FCY_0 = cbo_Branch.Text.ToString();
                    String REPTEAM_0 = cbo_Team.Text.ToString();
                    String REPADDLIG_0 = txt_Address1.Text.ToString();
                    String REPADDLIG_1 = txt_Address2.Text.ToString();
                    int IsInactive = (cbo_RepStatus.Text.Trim().Equals("Active") ? 0 : 1);
                    String CTY_0 = txt_city.Text.ToString();
                    String SAT_0 = txt_stateCode.Text.ToString();
                    String POSCOD_0 = txt_postalCode.Text.ToString();
                    String TEL_0 = txt_Tel.Text.ToString();
                    String REPIPAD_0 = txt_IpadDesc.Text.ToString();
                    Decimal REPGOAL_D = Convert.ToDecimal(txt_RepGoalD.Text.Length == 0 ? "0.0" : txt_RepGoalD.Text.ToString());
                    Decimal REPGOAL_W = Convert.ToDecimal(txt_RepGoalW.Text.Length == 0 ? "0.0" : txt_RepGoalW.Text.ToString());
                    Decimal REPGOAL_M = Convert.ToDecimal(txt_RepGoalM.Text.Length == 0 ? "0.0" : txt_RepGoalM.Text.ToString());
                    Decimal REPGOAL_Y = Convert.ToDecimal(txt_RepGoalY.Text.Length == 0 ? "0.0" : txt_RepGoalY.Text.ToString());
                    DateTime StartDate = dateTimePicker_RepSince.Value.Date;
                    DateTime BirthDay = dateTimePicker_Birthday.Value.Date;
                    String REPTYP_0 = cbo_RepType.Text.ToString();
                    String REPIPADSN_0 = txt_IpadSerialNo.Text.ToString();
                    String REPIPADUD_0 = txt_IpadUDID.Text.ToString();
                    Decimal WeeklySalary = Convert.ToDecimal(txt_WeeklySalary.Text.Length == 0 ? "0.0" : txt_WeeklySalary.Text.ToString());
                    String Password = txt_Password.Text.ToString();

                    connSalesOrder.sp_UPDATE_SalesRepInfo("Update",REPNUM_0,REPFNAM_0,REPMNAM_0,REPLNAM_0,FCY_0,REPTEAM_0,REPADDLIG_0,REPADDLIG_1,IsInactive
                        ,CTY_0,SAT_0,POSCOD_0,TEL_0,REPIPAD_0,REPGOAL_D,REPGOAL_W,REPGOAL_M,REPGOAL_Y,StartDate,BirthDay,REPTYP_0,REPIPADSN_0,REPIPADUD_0,WeeklySalary,Password);

                    txt_RepCode.Enabled = false;
                    chb_Password.Checked = false;
                    MessageBox.Show("Rep, " + txt_RepCode.Text.ToString() + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchSalesRep();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
        private void btn_newSave_Click(object sender, EventArgs e)
        {
            if (txt_RepCode.Text.Trim() == "")
            {
                MessageBox.Show("Please insert Rep Code."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (connSalesOrder.sp_CHECK_NewRepCode(txt_RepCode.Text.Trim()) == true)
            {
                MessageBox.Show("Rep Code already exist."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Save a new Rep?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    String REPNUM_0 = txt_RepCode.Text.ToString();
                    String REPFNAM_0 = txt_RepFName.Text.ToString();
                    String REPMNAM_0 = txt_RepMName.Text.ToString();
                    String REPLNAM_0 = txt_RepLName.Text.ToString();
                    String FCY_0 = cbo_Branch.Text.ToString();
                    String REPTEAM_0 = cbo_Team.Text.ToString();
                    String REPADDLIG_0 = txt_Address1.Text.ToString();
                    String REPADDLIG_1 = txt_Address2.Text.ToString();
                    int IsInactive = (cbo_RepStatus.Text.Trim().Equals("Active") ? 0 : 1);
                    String CTY_0 = txt_city.Text.ToString();
                    String SAT_0 = txt_stateCode.Text.ToString();
                    String POSCOD_0 = txt_postalCode.Text.ToString();
                    String TEL_0 = txt_Tel.Text.ToString();
                    String REPIPAD_0 = txt_IpadDesc.Text.ToString();
                    Decimal REPGOAL_D = Convert.ToDecimal(txt_RepGoalD.Text.Length == 0 ? "0.0" : txt_RepGoalD.Text.ToString());
                    Decimal REPGOAL_W = Convert.ToDecimal(txt_RepGoalW.Text.Length == 0 ? "0.0" : txt_RepGoalW.Text.ToString());
                    Decimal REPGOAL_M = Convert.ToDecimal(txt_RepGoalM.Text.Length == 0 ? "0.0" : txt_RepGoalM.Text.ToString());
                    Decimal REPGOAL_Y = Convert.ToDecimal(txt_RepGoalY.Text.Length == 0 ? "0.0" : txt_RepGoalY.Text.ToString());
                    DateTime StartDate = dateTimePicker_RepSince.Value.Date;
                    DateTime BirthDay = dateTimePicker_Birthday.Value.Date;
                    String REPTYP_0 = cbo_RepType.Text.ToString();
                    String REPIPADSN_0 = txt_IpadSerialNo.Text.ToString();
                    String REPIPADUD_0 = txt_IpadUDID.Text.ToString();
                    Decimal WeeklySalary = Convert.ToDecimal(txt_WeeklySalary.Text.Length == 0 ? "0.0" : txt_WeeklySalary.Text.ToString());
                    String Password = txt_Password.Text.ToString();

                    connSalesOrder.sp_UPDATE_SalesRepInfo("New",REPNUM_0, REPFNAM_0, REPMNAM_0, REPLNAM_0, FCY_0, REPTEAM_0, REPADDLIG_0, REPADDLIG_1, IsInactive
                        , CTY_0, SAT_0, POSCOD_0, TEL_0, REPIPAD_0, REPGOAL_D, REPGOAL_W, REPGOAL_M, REPGOAL_Y, StartDate,BirthDay,REPTYP_0, REPIPADSN_0,REPIPADUD_0,WeeklySalary,Password);

                    txt_RepCode.Enabled = false;
                    chb_Password.Checked = false;
                    MessageBox.Show("Rep, " + txt_RepCode.Text.ToString() + " information has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchSalesRep();
                }
                catch
                {
                    MessageBox.Show("Input all customer information."
                                                        , "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }
        private void grid_SalesRep_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Color_SetUp();
        }

        private void txt_RepGoal_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_SalesRep.RowCount; i++)
            {
                String SalesRep = txt_RepCode.Text.ToString();
                if (grid_SalesRep.Rows[i].Cells["REP"].Value.ToString().Equals(SalesRep))
                {
                    decimal TGOAL_D = Convert.ToDecimal(grid_SalesRep.Rows[i].Cells["TGOAL_D"].Value == DBNull.Value ? "0.0" : grid_SalesRep.Rows[i].Cells["TGOAL_D"].Value);
                    decimal TGOAL_W = Convert.ToDecimal(grid_SalesRep.Rows[i].Cells["TGOAL_W"].Value == DBNull.Value ? "0.0" : grid_SalesRep.Rows[i].Cells["TGOAL_W"].Value);
                    decimal TGOAL_M = Convert.ToDecimal(grid_SalesRep.Rows[i].Cells["TGOAL_M"].Value == DBNull.Value ? "0.0" : grid_SalesRep.Rows[i].Cells["TGOAL_M"].Value);
                    decimal TGOAL_Y = Convert.ToDecimal(grid_SalesRep.Rows[i].Cells["TGOAL_Y"].Value == DBNull.Value ? "0.0" : grid_SalesRep.Rows[i].Cells["TGOAL_Y"].Value);
                    decimal REPGOAL_D = Convert.ToDecimal(grid_SalesRep.Rows[i].Cells["REPGOAL_D"].Value == DBNull.Value ? "0.0" : grid_SalesRep.Rows[i].Cells["REPGOAL_D"].Value);
                    decimal REPGOAL_W = Convert.ToDecimal(grid_SalesRep.Rows[i].Cells["REPGOAL_W"].Value == DBNull.Value ? "0.0" : grid_SalesRep.Rows[i].Cells["REPGOAL_W"].Value);
                    decimal REPGOAL_M = Convert.ToDecimal(grid_SalesRep.Rows[i].Cells["REPGOAL_M"].Value == DBNull.Value ? "0.0" : grid_SalesRep.Rows[i].Cells["REPGOAL_M"].Value);
                    decimal REPGOAL_Y = Convert.ToDecimal(grid_SalesRep.Rows[i].Cells["REPGOAL_Y"].Value == DBNull.Value ? "0.0" : grid_SalesRep.Rows[i].Cells["REPGOAL_Y"].Value);
                    txt_TeamGoalD.Text = (TGOAL_D - REPGOAL_D + Convert.ToDecimal(txt_RepGoalD.Text.Length == 0 ? "0.0" : txt_RepGoalD.Text.ToString())).ToString();
                    txt_TeamGoalW.Text = (TGOAL_W - REPGOAL_W + Convert.ToDecimal(txt_RepGoalW.Text.Length == 0 ? "0.0" : txt_RepGoalW.Text.ToString())).ToString();
                    txt_TeamGoalM.Text = (TGOAL_M - REPGOAL_M + Convert.ToDecimal(txt_RepGoalM.Text.Length == 0 ? "0.0" : txt_RepGoalM.Text.ToString())).ToString();
                    txt_TeamGoalY.Text = (TGOAL_Y - REPGOAL_Y + Convert.ToDecimal(txt_RepGoalY.Text.Length == 0 ? "0.0" : txt_RepGoalY.Text.ToString())).ToString();

                    //txt_TeamGoalW.Text = (TGOAL_W - REPGOAL_W + Convert.ToDecimal(txt_RepGoalW.Text.ToString())).ToString();
                    //txt_TeamGoalM.Text = (TGOAL_M - REPGOAL_M + Convert.ToDecimal(txt_RepGoalM.Text.ToString())).ToString();
                    //txt_TeamGoalY.Text = (TGOAL_Y - REPGOAL_Y + Convert.ToDecimal(txt_RepGoalY.Text.ToString())).ToString();

                    return;
                }

            }
        }

        private void cbo_RepType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txt_RepGoalD.Enabled = false;
            //txt_RepGoalW.Enabled = false;
            //txt_RepGoalM.Enabled = false;
            //txt_RepGoalY.Enabled = false;
            //txt_TeamGoalD.Enabled = false;
            //txt_TeamGoalW.Enabled = false;
            //txt_TeamGoalM.Enabled = false;
            //txt_TeamGoalY.Enabled = false;
            //txt_WeeklySalary.Enabled = false;

            //if (cbo_RepType.Text.Equals("Salary"))
            //{
            //    txt_WeeklySalary.Enabled = true;
            //}
            //else if (cbo_RepType.Text.Equals("Commission"))
            //{
            //    txt_RepGoalD.Enabled = true;
            //    txt_RepGoalW.Enabled = true;
            //    txt_RepGoalM.Enabled = true;
            //    txt_RepGoalY.Enabled = true;
            //}
           
        }

        private void chb_Password_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = chb_Password.Checked ? '\0' : '*';
        }
    }
}
