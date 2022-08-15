using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace OBCS
{
    public partial class PASS_MOD : Form
    {
        public PASS_MOD()
        {
            InitializeComponent();
            txt_userid.Text = PASS.newUserID;

            fill_pass_mod();

            treeView1.ExpandAll();
        }

        public void fill_pass_mod()
        {
            grid_user.AutoGenerateColumns = false;

            grid_user.ColumnCount = 3;

            grid_user.Columns[0].Name = "Form ID";
            grid_user.Columns[0].Width = 80;
            grid_user.Columns[0].DataPropertyName = "P_FORM";

            grid_user.Columns[1].Name = "Description";
            grid_user.Columns[1].Width = 300;
            grid_user.Columns[1].DataPropertyName = "P_DESC";

            grid_user.Columns[2].Name = "Access";
            grid_user.Columns[2].Width = 50;
            grid_user.Columns[2].DataPropertyName = "P_ACCESS";

            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            check.HeaderText = "Check";
            check.FalseValue = false;
            check.TrueValue = true;
            check.Name = "CheckBox";
            check.ReadOnly = false;
            check.Width = 50;
            grid_user.Columns.Insert(1, check);
            grid_user.CellContentClick += new DataGridViewCellEventHandler(gridcellclick);


            conn.FillGrid_PASSD(this.grid_user, PASS.newUserID);

            for (int i = 0; i < grid_user.RowCount; i++)
            {
                for (int j = 0; j < grid_user.ColumnCount; j++)
                {
                    //grid_user.Rows[i].Cells[j].Value = grid_user.Rows[i].Cells[j].Value.ToString().Trim();
                    //MessageBox.Show(grid_user.Rows[i].Cells[j].Value.ToString());
                }
            }

        }

        private void gridcellclick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex>= 0 && e.ColumnIndex ==0)
            //{
            //    bool ischecked = true;
            //    foreach (DataGridViewRow item in grid_picking.Rows)
            //    {
            //        if(Convert.ToBoolean(item.Cells["CheckBox"].EditedFormattedValue)==true)
            //        {
            //            MessageBox.Show("true");
            //        } else
            //        {
            //            MessageBox.Show("false");
            //        }


            //    }

            //}

        }

        private void PASS_MOD_Load(object sender, EventArgs e)
        {
                txt_userid.Text = PASS.newUserID;
                conn.FillOutUserInfo(txt_userid.Text, txt_name, txt_category, txt_email);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            conn.ModiUserId(txt_userid.Text, MD5(txt_password.Text), txt_name.Text, txt_email.Text, txt_category.Text);
            this.Close();
        }

        public string MD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("X2"));
            }
            return str.ToString();
        }

        List<String> CheckedNodes = new List<String>();

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);

            if (e.Node.Checked)
            {
                CheckedNodes.Add(e.Node.Name.ToString());
            }
            else
            {
                CheckedNodes.Remove(e.Node.Name.ToString());
            }
            
        }
        

        private void CheckTreeViewNode(TreeNode node, Boolean isChecked)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;

                if (item.Nodes.Count > 0)
                {
                    this.CheckTreeViewNode(item, isChecked);
                }

            }
        }
        
        
        private void btn_delet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join(",", CheckedNodes));

            //treeView1.Nodes.Find("menu1", true);

        }

        private void treeView1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            //MessageBox.Show(e.Node.Name);
            //CheckTreeViewNode2(e.Node, e.Node.Checked);
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {

        }
    }

}
