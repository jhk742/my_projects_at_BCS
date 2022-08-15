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
    public partial class UserInfoList : Form
    {
        public UserInfoList()
        {
            InitializeComponent();
            grid_userInfoList_Init();
        }

        private void grid_userInfoList_Init()
        {
            grid_userInfoList.AutoGenerateColumns = false;

            grid_userInfoList.ColumnCount = 4;

            grid_userInfoList.Columns[0].Name = "Branch";
            grid_userInfoList.Columns[0].ReadOnly = true;
            grid_userInfoList.Columns[0].Width = 80;
            grid_userInfoList.Columns[0].DataPropertyName = "BrandKey";

            grid_userInfoList.Columns[1].Name = "First Name";
            grid_userInfoList.Columns[1].ReadOnly = true;
            grid_userInfoList.Columns[1].Width = 140;
            grid_userInfoList.Columns[1].DataPropertyName = "BrandName";

            grid_userInfoList.Columns[2].Name = "Last Name";
            grid_userInfoList.Columns[2].ReadOnly = true;
            grid_userInfoList.Columns[2].Width = 140;
            grid_userInfoList.Columns[2].DataPropertyName = "VendorID";

            grid_userInfoList.Columns[3].Name = "User ID";
            grid_userInfoList.Columns[3].ReadOnly = true;
            grid_userInfoList.Columns[3].Width = 210;
            grid_userInfoList.Columns[3].DataPropertyName = "VendorName";

            grid_userInfoList.Columns[3].Name = "Level";
            grid_userInfoList.Columns[3].ReadOnly = true;
            grid_userInfoList.Columns[3].Width = 210;
            grid_userInfoList.Columns[3].DataPropertyName = "VendorName";

            grid_userInfoList.Columns[3].Name = "Group";
            grid_userInfoList.Columns[3].ReadOnly = true;
            grid_userInfoList.Columns[3].Width = 210;
            grid_userInfoList.Columns[3].DataPropertyName = "VendorName";

            grid_userInfoList.Columns[3].Name = "Title";
            grid_userInfoList.Columns[3].ReadOnly = true;
            grid_userInfoList.Columns[3].Width = 210;
            grid_userInfoList.Columns[3].DataPropertyName = "VendorName";

            grid_userInfoList.Columns[3].Name = "Job";
            grid_userInfoList.Columns[3].ReadOnly = true;
            grid_userInfoList.Columns[3].Width = 210;
            grid_userInfoList.Columns[3].DataPropertyName = "VendorName";

            grid_userInfoList.Columns[3].Name = "Department";
            grid_userInfoList.Columns[3].ReadOnly = true;
            grid_userInfoList.Columns[3].Width = 210;
            grid_userInfoList.Columns[3].DataPropertyName = "VendorName";

            connPO.sp_TemporaryPurchaseOrderList(grid_userInfoList);
            //grid font size custom
            grid_userInfoList.RowTemplate.Height = 20;

            foreach (DataGridViewColumn c in grid_userInfoList.Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Regular);
            }
            grid_userInfoList.ColumnHeadersHeight = 30;
            grid_userInfoList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Regular);

        }
    }

    
}
