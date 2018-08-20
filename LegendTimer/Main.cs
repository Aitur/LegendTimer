using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker;

namespace LegendTimer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        bool timerTicking = false;
        DateTime timepointWhenCurrentSessionStarted;
        TimeSpan summedTimeFromAllPreviousSessions = new TimeSpan(0);
        TimeSpan durationOfCurrentSession;

        private void startOrStopSession(object sender, EventArgs e)
        {
            //If the timer ist currently not ticking, an new Session ist started.
            if (timerTicking == false)
            {
                buttonStart.Text = "Break";
                timer1.Start();
                timepointWhenCurrentSessionStarted = DateTime.Now;
                timerTicking = true;
            }
            //Otherwise the Session is ended and the resulting time is saved.
            else
            {
                buttonStart.Text = "Weiter";
                timer1.Stop();
                summedTimeFromAllPreviousSessions += DateTime.Now - timepointWhenCurrentSessionStarted;
                timerTicking = false;
            }
        }

        private void updateDisplaiedTime(object sender, EventArgs e)
        {
            durationOfCurrentSession = summedTimeFromAllPreviousSessions + (DateTime.Now - timepointWhenCurrentSessionStarted);
            labelZeitAnzeige.Text = durationOfCurrentSession.Hours + ":" + durationOfCurrentSession.Minutes + ":" 
                + durationOfCurrentSession.Seconds;
        }

        private void saveBeforeClosing(object sender, FormClosingEventArgs e)
        {
            //Otherwise the timer was never started, so there would be nothing to save.
            if (!labelZeitAnzeige.Equals("00:00:00"))
            {
                TextFileOperations.saveFile(durationOfCurrentSession.Seconds, durationOfCurrentSession.Minutes, durationOfCurrentSession.Hours, timepointWhenCurrentSessionStarted.Day, timepointWhenCurrentSessionStarted.Month, timepointWhenCurrentSessionStarted.Year);
            }
        }
        private void fillInTime(object sender, EventArgs e)
        {
            ZeitNachtragen formFillIn = new ZeitNachtragen();
            formFillIn.Show();
        }

        private void showWeeklyEvaluation(object sender, EventArgs e)
        {
            Wochenansicht wochenansicht = new Wochenansicht();
            wochenansicht.Show();
        }
    }
}
