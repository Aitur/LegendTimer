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
                btnStart.Text = "Break";
                timer1.Start();
                timepointWhenCurrentSessionStarted = DateTime.Now;
                timerTicking = true;
            }
            //Otherwise the session is ended and the final time is saved.
            else
            {
                btnStart.Text = "Weiter";
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
            labelTime.Text = durationOfCurrentSession.Hours + ":" + durationOfCurrentSession.Minutes + ":" 
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
            if (!labelTime.Equals("00:00:00"))
            {
                TextFileOperations.SaveFile(durationOfCurrentSession.Seconds, durationOfCurrentSession.Minutes,
                    durationOfCurrentSession.Hours, timepointWhenCurrentSessionStarted.Day,
                    timepointWhenCurrentSessionStarted.Month, timepointWhenCurrentSessionStarted.Year);
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

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
