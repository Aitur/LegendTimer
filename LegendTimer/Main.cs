using System;
using System.Windows.Forms;
using TimeTracker;

namespace LegendTimer
{
    public partial class Main : Form
    {
        bool timerTicking;
        DateTime timepointWhenCurrentSessionStarted;
        TimeSpan summedTimeFromAllPreviousSessions = new TimeSpan(0);
        TimeSpan durationOfCurrentSession;

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartOrStopSession(object sender, EventArgs e)
        {
            //If the timer ist currently not ticking, a new session ist started.
            if (timerTicking == false)
            {
                buttonStart.Text = "Break";
                timer1.Start();
                timepointWhenCurrentSessionStarted = DateTime.Now;
                timerTicking = true;
            }
            //Otherwise the session is ended and the final time is saved.
            else
            {
                buttonStart.Text = "Weiter";
                timer1.Stop();
                summedTimeFromAllPreviousSessions += DateTime.Now - timepointWhenCurrentSessionStarted;
                timerTicking = false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateDisplayedTime(object sender, EventArgs e)
        {
            durationOfCurrentSession = summedTimeFromAllPreviousSessions + (DateTime.Now - timepointWhenCurrentSessionStarted);
            labelZeitAnzeige.Text = durationOfCurrentSession.Hours + ":" + durationOfCurrentSession.Minutes + ":" 
                + durationOfCurrentSession.Seconds;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBeforeClosing(object sender, FormClosingEventArgs e)
        {
            //Otherwise the timer was never started, so there would be nothing to save.
            if (!labelZeitAnzeige.Equals("00:00:00"))
            {
                TextFileOperations textOps = new TextFileOperations();
                textOps.SaveFile(new TimeSpan(durationOfCurrentSession.Hours, durationOfCurrentSession.Minutes, durationOfCurrentSession.Seconds),
                    new DateTime(timepointWhenCurrentSessionStarted.Year, timepointWhenCurrentSessionStarted.Month, timepointWhenCurrentSessionStarted.Day));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FillInTime(object sender, EventArgs e)
        {
            AddTimeManually formFillIn = new AddTimeManually();
            formFillIn.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowWeeklyEvaluation(object sender, EventArgs e)
        {
            WeeklyOverview weeklyoverview = new WeeklyOverview();
            weeklyoverview.Show();
        }
    }
}
