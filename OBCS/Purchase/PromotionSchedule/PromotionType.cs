using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Purchase.PromotionSchedule
{
    public partial class PromotionType : Form
    {
        public PromotionType()
        {
            InitializeComponent();
            grid_promotionType_Init();

            connSalesOrder.sp_PromotionType(grid_promotionType);

            //if(GATE.userID == "ADMIN")
            //{
            //    button1.Visible = true;
            //}
        }

        DataGridViewButtonColumn statusButton = new DataGridViewButtonColumn();

        private void grid_promotionType_Init()
        {
            grid_promotionType.AutoGenerateColumns = false;
            grid_promotionType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_promotionType.ColumnCount = 3;

            grid_promotionType.Columns[0].Name = "Type Code";
            grid_promotionType.Columns[0].ReadOnly = true;
            grid_promotionType.Columns[0].Width = 100;
            grid_promotionType.Columns[0].MinimumWidth = 100;
            grid_promotionType.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_promotionType.Columns[0].DataPropertyName = "PromotionTypeCode";

            grid_promotionType.Columns[1].Name = "Type Name";
            grid_promotionType.Columns[1].ReadOnly = true;
            grid_promotionType.Columns[1].Width = 200;
            grid_promotionType.Columns[1].MinimumWidth = 200;
            grid_promotionType.Columns[1].DataPropertyName = "PromotionTypeName";

            //DataGridViewButtonColumn statusButton = new DataGridViewButtonColumn();
            statusButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            statusButton.Width = 50;
            statusButton.Name = "Status";
            statusButton.Text = "Status";
            statusButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            statusButton.UseColumnTextForButtonValue = true;
            if (grid_promotionType.Columns["Status"] == null)
            {
                grid_promotionType.Columns.Insert(2, statusButton);
            }
            statusButton.Visible = false;
            
            grid_promotionType.Columns[3].Name = "Status";
            grid_promotionType.Columns[3].Visible = false;
            grid_promotionType.Columns[3].Width = 80;
            grid_promotionType.Columns[3].MinimumWidth = 80;
            grid_promotionType.Columns[3].DataPropertyName = "Status";

            //grid font size custom
            grid_promotionType.RowTemplate.Height = 20;
            grid_promotionType.ColumnHeadersHeight = 30;

            foreach (DataGridViewColumn c in grid_promotionType.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            }
            grid_promotionType.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {   
            if(txt_code.Text.Trim() == "" || txt_name.Text.Trim() == "")
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Adding a new Promotion Type?"
                                                        , "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                String PromotionTypeCode = txt_code.Text.Trim();
                String PromotionTypeName = txt_name.Text.Trim();
                string returnMessage = connSalesOrder.sp_PromotionType_INSERT(PromotionTypeCode, PromotionTypeName);

                if (returnMessage != "OK")
                {
                    MessageBox.Show(returnMessage, "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                connSalesOrder.sp_PromotionType(grid_promotionType);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void txt_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_code_TextChanged(object sender, EventArgs e)
        {
            txt_code.Text = Regex.Replace(txt_code.Text, @"\s", "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsyncAccessTest();
            //AccessTest();
        }

        private void AccessTest()
        {
            Message = "";
            test1();
            test2();

            MessageBox.Show(Message);
        }

        private async void AsyncAccessTest()
        {
            Message = "";
            Task.Run(() => test1());
            await Task.Run(() => test2());

            MessageBox.Show(Message);
        }

        String Message = "";

        private void test1()
        {
            for(int i = 0; i<10; i++)
            {
                Thread.Sleep(100);
                //MessageBox.Show("Testing1...(" + i.ToString() + ")");
                Message = Message + "Testing1...(" + i.ToString() + ")\n";
            }
            
        }

        private void test2()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                //MessageBox.Show("Testing2...(" + i.ToString() + ")");
                Message = Message + "Testing2...(" + i.ToString() + ")\n";
            }
        }

    }
}
