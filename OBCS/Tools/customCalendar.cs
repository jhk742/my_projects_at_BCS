using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace OBCS.Tools
{
    public partial class customCalendar : UserControl
    {
        int day, month, year;
        public static int static_day, static_month, static_year; //create static variables so that they can be used interchangeably across multiple forms. We need to share these static variables such that they can be used within the UserControlIncluded.cs page. With regards to the "month" and "year" variables,
        //there is no need to include them within the two for loops located within every method on this page. Days is another question. Since every month has a different number of days, they need to be included in the for loop so that the Load function within userControlIncluded.cs constructs a string in the form
        //of a DATETIME. This same string is converted into a DateTime datatype and used within our Database to query for PO#s and their corresponding Supplier names. Each panel within the calendar represents a day, and each day is assigned a customGrid. Since we need to load approximately 30 grids for each month,
        //it is crucial that we get the DAY variable correct. Notice how when going into the prev or next function, the static_day variable is automatically assigned the value of 1 to reflect...well...the start of the month. Very important shiet.
        public customCalendar()
        {
            InitializeComponent();
            this.datePICK.CustomFormat = "MM/yyyy";
        }


        private void customCalendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            //day = now.Day;
            month = now.Month;
            year = now.Year;
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label_displayDate.Text = monthName + " " + year;
            static_day = day;
            static_month = month; //O_o
            static_year = year; //O_o
            datePICK.Value = Convert.ToDateTime("" + static_month + "/" + static_year + "");
            //
            //get first day of the month
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            //get day count
            int days = DateTime.DaysInMonth(year, month);

            //convert startOfTheMonth to integer
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            //create blank userControl (for days that are not in the current month)
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank daysNotIncluded = new UserControlBlank();
                daysContainer.Controls.Add(daysNotIncluded);
            }
            //create userControl for days included in the month
            for (int i = 1; i <= days; i++)
            {
                static_day = i;
                UserControlIncluded daysIncluded = new UserControlIncluded();
                daysIncluded.days(i);
                daysContainer.Controls.Add(daysIncluded);
            }
        }

        private void button1_Click(object sender, EventArgs e) //refresh
        {
            daysContainer.Controls.Clear();
            DateTime startOfTheMonth = new DateTime(static_year, static_month, 1);
            int days = DateTime.DaysInMonth(static_year, static_month);
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            datePICK.Value = Convert.ToDateTime("" + static_month + "/" + static_year + "");
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank daysNotIncluded = new UserControlBlank();
                daysContainer.Controls.Add(daysNotIncluded);
            }
            //create userControl for days included in the month
            for (int i = 1; i <= days; i++)
            {
                static_day = i;
                UserControlIncluded daysIncluded = new UserControlIncluded();
                daysIncluded.days(i);
                daysContainer.Controls.Add(daysIncluded);
            }
            //static_month = ;
            //displayDays();
        }

        private void button2_Click(object sender, EventArgs e) //load
        {
            int month, year;
            DateTime date = datePICK.Value.Date;
            month = date.Month;
            year = date.Year;
            static_day = 1;
            static_month = month;
            static_year = year;
            datePICK.Value = Convert.ToDateTime("" + static_month + "/" + static_year + "");
            label_displayDate.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            daysContainer.Controls.Clear();
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank daysNotIncluded = new UserControlBlank();
                daysContainer.Controls.Add(daysNotIncluded);
            }
            //create userControl for days included in the month
            for (int i = 1; i <= days; i++)
            {
                static_day = i;
                UserControlIncluded daysIncluded = new UserControlIncluded();
                daysIncluded.days(i);
                daysContainer.Controls.Add(daysIncluded);
            }
        }

        private void button3_Click(object sender, EventArgs e) //now
        {
            daysContainer.Controls.Clear();
            displayDays();
        }

        private void btn_Prev_Click_1(object sender, EventArgs e)
        {
            //clear panels, decrement month, assign 1 to static_day (first day of the month)
            static_day = 1;
            daysContainer.Controls.Clear();
            month--;
            if (month == 0)
            {
                year--;
                month = 12;
            }
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label_displayDate.Text = monthName + " " + year;
            static_month = month; //needed for the construction of the datetime string (in UserControlIncluded.cs), which in turn is converted into a datetime datatype to be sent in as a variable for the stored_procedure on our database
            static_year = year; //"
            datePICK.Value = Convert.ToDateTime("" + static_month + "/" + static_year + "");
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month); //get the number of days in the current month so we can create a for loop and send the same numbers over onto UserControlIncluded.cs
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank daysNotIncluded = new UserControlBlank(); //identifies valid dates within a given week - decides which panels are to be transparent = represents day in another month OR opaque = day withini week/mnth
                daysContainer.Controls.Add(daysNotIncluded);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlIncluded daysIncluded = new UserControlIncluded();//create an instance of UserControlIncluded, increment static_days, send in days to via the "days" function : to display the day in top-left corner of each panel (label_Days.text)
                static_day++;
                daysIncluded.days(i);
                daysContainer.Controls.Add(daysIncluded);
            }
        }
        
        private void btn_PrevYear_Click(object sender, EventArgs e)
        {
            static_day = 1;
            daysContainer.Controls.Clear();
            year--;
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label_displayDate.Text = monthName + " " + year;
            static_month = month;
            static_year = year;
            datePICK.Value = Convert.ToDateTime("" + static_month + "/" + static_year + "");
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank dni = new UserControlBlank();
                daysContainer.Controls.Add(dni);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlIncluded uci = new UserControlIncluded();
                static_day++;
                uci.days(i);
                daysContainer.Controls.Add(uci);
            }
        }

        private void btn_Next_Click_1(object sender, EventArgs e)
        {
            //clear panels and increment month - almost identical to btn_Prev_Click_1
            static_day = 1;
            daysContainer.Controls.Clear();
            month++;
            if (month == 13)
            {
                year++;
                month = 1;
            }
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label_displayDate.Text = monthName + " " + year;
            static_month = month; //O_o
            static_year = year; //O_o
            datePICK.Value = Convert.ToDateTime("" + static_month + "/" + static_year + "");
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank daysNotIncluded = new UserControlBlank();
                daysContainer.Controls.Add(daysNotIncluded);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlIncluded daysIncluded = new UserControlIncluded();
                static_day++;
                daysIncluded.days(i);
                daysContainer.Controls.Add(daysIncluded);
            }
        }
        private void btn_NextYear_Click(object sender, EventArgs e)
        {
            static_day = 1;
            daysContainer.Controls.Clear();
            year++;
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label_displayDate.Text = monthName + " " + year;
            static_month = month;
            static_year = year;
            datePICK.Value = Convert.ToDateTime("" + static_month + "/" + static_year + "");
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank dni = new UserControlBlank();
                daysContainer.Controls.Add(dni);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlIncluded uci = new UserControlIncluded();
                static_day++;
                uci.days(i);
                daysContainer.Controls.Add(uci);
            }
        }
    }
}
