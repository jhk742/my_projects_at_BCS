using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OBCS
{
    class CustomGrid : DataGridView
    {
        public CustomGrid()
        {
            DoubleBuffered = true;
            //init
            RowTemplate.Height = 30;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;
            BackgroundColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            GridColor = Color.LightGray;
            MultiSelect = false;
            ReadOnly = true;
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            RowHeadersVisible = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StandardTab = true;

            foreach (DataGridViewColumn c in Columns)
            {
                //c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);
            }
            DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);
            DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 13F, FontStyle.Bold);
            ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
            EnableHeadersVisualStyles = false;
        }

        protected override void InitLayout()
        {
            AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            RowTemplate.Height = 19;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;
            BackgroundColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GridColor = Color.LightGray;
            MultiSelect = false;
            ReadOnly = false;
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            RowHeadersVisible = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StandardTab = true;
            DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            //DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            
            //int r, g, b, sr, sg,sb;
            //r = DefaultCellStyle.SelectionBackColor.R;
            //g = DefaultCellStyle.SelectionBackColor.G;
            //b = DefaultCellStyle.SelectionBackColor.B;

            //sr = r-50;
            //if (sr < 0)
            //    r = 0;
            //sg = g-50;
            //if (sg < 0)
            //    g = 0;
            //sb = b-50;
            //if (sb < 0)
            //    b = 0;
            DefaultCellStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            //DefaultCellStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(sr)))), ((int)(((byte)(sg)))), ((int)(((byte)(sb)))));
            
            DefaultCellStyle.SelectionForeColor = Color.Black;
            ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            //ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
            //ColumnHeadersDefaultCellStyle.BackColor = Color.Moccasin;
            ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            EnableHeadersVisualStyles = false;
            //AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            base.InitLayout();
        }
    }

}
