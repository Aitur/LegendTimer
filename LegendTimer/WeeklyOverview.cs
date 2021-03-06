﻿using System;
using System.Windows.Forms;
using LegendTimer;

namespace TimeTracker
{
    public partial class WeeklyOverview: Form
    {
        public WeeklyOverview()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        public void ResetTimes()
        {
            lblMontag.Text = "0:0:0";
            lblDienstag.Text = "0:0:0";
            lblMittwoch.Text = "0:0:0";
            lblDonnerstag.Text = "0:0:0";
            lblFreitag.Text = "0:0:0";
            lblSamstag.Text = "0:0:0";
            lblSonntag.Text = "0:0:0";

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowData(object sender, EventArgs e)
        {
            String[] data = TextFileOperations.LoadFile();
            DateTime[] daysOfTheWeek = CalculateDaysOfWeek();
            foreach (string readDay in data)
            {
                string[] readDayData = readDay.Split(';');
                int.TryParse(readDayData[3], out int tempDay);
                int.TryParse(readDayData[4], out int tempMonth);
                int.TryParse(readDayData[5], out int tempYear);
                for (int i = 0; i < 7; i++)
                {
                    if (tempDay == daysOfTheWeek[i].Day && tempMonth == daysOfTheWeek[i].Month && tempYear == daysOfTheWeek[i].Year)
                    {
                        int.TryParse(readDayData[0], out tempSeconds);
                        int.TryParse(readDayData[1], out tempMinutes);
                        int.TryParse(readDayData[2], out tempHours);
                        FillDayLabel(daysOfTheWeek[i].DayOfWeek, tempHours, tempMinutes, tempSeconds);
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dayOfWeek"></param>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        private void FillDayLabel(DayOfWeek dayOfWeek, int hours, int minutes, int seconds)
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DateTime[] CalculateDaysOfWeek()
        {
            DateTime mondayOfWeek = CalculateStartOfWeek();
            DateTime[] daysOfWeek = new DateTime[7];
            for (int i = 0; i < 7; i++)
            {
                daysOfWeek[i] = mondayOfWeek + new TimeSpan(i, 0, 0, 0);
            }

            return daysOfWeek;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DateTime CalculateStartOfWeek()
        {
            DateTime now = DateTime.Now;
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return now;
                case DayOfWeek.Tuesday:
                    return now - new TimeSpan(1, 0, 0, 0);
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
