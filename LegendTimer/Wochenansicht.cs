using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LegendTimer;

namespace TimeTracker
{
    public partial class Wochenansicht : Form
    {
        public Wochenansicht()
        {
            InitializeComponent();
        }

        public void Zeiten_setzen()
        {
            lblMontag.Text = "0:0:0";
            lblDienstag.Text = "0:0:0";
            lblMittwoch.Text = "0:0:0";
            lblDonnerstag.Text = "0:0:0";
            lblFreitag.Text = "0:0:0";
            lblSamstag.Text = "0:0:0";
            lblSonntag.Text = "0:0:0";

        }

        private void showData(object sender, EventArgs e)
        {
            String[] data = TextFileOperations.loadFile();
            DateTime[] daysOfTheWeek = calculateDaysOfWeek();
            string[] readDayData;
            int tempSeconds;
            int tempMinutes;
            int tempHours;
            int tempDay;
            int tempMonth;
            int tempYear;
            foreach (string readDay in data)
            {
                readDayData = readDay.Split(';');
                int.TryParse(readDayData[3],out tempDay);
                int.TryParse(readDayData[4], out tempMonth);
                int.TryParse(readDayData[5], out tempYear);
                for(int i = 0; i < 7; i++)
                {
                    if (tempDay == daysOfTheWeek[i].Day && tempMonth == daysOfTheWeek[i].Month && tempYear == daysOfTheWeek[i].Year)
                    {
                        int.TryParse(readDayData[0], out tempSeconds);
                        int.TryParse(readDayData[1], out tempMinutes);
                        int.TryParse(readDayData[2], out tempHours);
                        fillDayLabel(daysOfTheWeek[i].DayOfWeek,tempHours,tempMinutes,tempSeconds);
                    }
                }
            }
        }

        private void fillDayLabel(DayOfWeek dayOfWeek, int hours, int minutes, int seconds)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    lblMontag.Text = hours + ":" + minutes + ":" + seconds;
                    break;
                case DayOfWeek.Tuesday:
                    lblDienstag.Text = hours + ":" + minutes + ":" + seconds;
                    break;
                case DayOfWeek.Wednesday:
                    lblMittwoch.Text = hours + ":" + minutes + ":" + seconds;
                    break; ;
                case DayOfWeek.Thursday:
                    lblDonnerstag.Text = hours + ":" + minutes + ":" + seconds;
                    break;
                case DayOfWeek.Friday:
                    lblFreitag.Text = hours + ":" + minutes + ":" + seconds;
                    break;
                case DayOfWeek.Saturday:
                    lblSamstag.Text = hours + ":" + minutes + ":" + seconds;
                    break;
                case DayOfWeek.Sunday:
                    lblSonntag.Text = hours + ":" + minutes + ":" + seconds;
                    break;
            }
        }

        private DateTime[] calculateDaysOfWeek()
        {
            DateTime mondayOfWeek = calculateStartOfWeek();
            DateTime[] daysOfWeek = new DateTime[7];
            for (int i = 0; i < 7; i++)
            {
                daysOfWeek[i] = mondayOfWeek + new TimeSpan(i, 0, 0, 0);
            }

            return daysOfWeek;
        }

        private DateTime calculateStartOfWeek()
        {
            DateTime now = DateTime.Now;
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return now;
                case DayOfWeek.Tuesday:
                    return now - new TimeSpan(1,0,0,0);
                case DayOfWeek.Wednesday:
                    return now - new TimeSpan(2, 0, 0, 0);
                case DayOfWeek.Thursday:
                    return now - new TimeSpan(3, 0, 0, 0);
                case DayOfWeek.Friday:
                    return now - new TimeSpan(4, 0, 0, 0);
                case DayOfWeek.Saturday:
                    return now - new TimeSpan(5, 0, 0, 0);
                case DayOfWeek.Sunday:
                    return now - new TimeSpan(1, 0, 0, 0);
                default:
                    return now;
            }
        }
    }
}
