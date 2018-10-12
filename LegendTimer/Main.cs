using System;
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
        bool _timerTicking;
        DateTime _timepointWhenCurrentSessionStarted;
        TimeSpan _summedTimeFromAllPreviousSessions = new TimeSpan(0);
        TimeSpan _durationOfCurrentSession;

        private void StartOrStopSession(object sender, EventArgs e)
        {
            //If the timer ist currently not ticking, an new Session ist started.
            if (_timerTicking == false)
            {
                buttonStart.Text = "Break";
                timer1.Start();
                _timepointWhenCurrentSessionStarted = DateTime.Now;
                _timerTicking = true;
            }
            //Otherwise the Session is ended and the resulting time is saved.
            else
            {
                buttonStart.Text = "Weiter";
                timer1.Stop();
                _summedTimeFromAllPreviousSessions += DateTime.Now - _timepointWhenCurrentSessionStarted;
                _timerTicking = false;
            }
        }

        private void UpdateDisplaiedTime(object sender, EventArgs e)
        {
            _durationOfCurrentSession = _summedTimeFromAllPreviousSessions + (DateTime.Now - _timepointWhenCurrentSessionStarted);
            labelZeitAnzeige.Text = _durationOfCurrentSession.Hours + ":" + _durationOfCurrentSession.Minutes + ":" 
                + _durationOfCurrentSession.Seconds;
        }

        private void SaveBeforeClosing(object sender, FormClosingEventArgs e)
        {
            //Otherwise the timer was never started, so there would be nothing to save.
            if (!labelZeitAnzeige.Equals("00:00:00"))
            {
                TextFileOperations.SaveFile(_durationOfCurrentSession.Seconds, _durationOfCurrentSession.Minutes,
                    _durationOfCurrentSession.Hours, _timepointWhenCurrentSessionStarted.Day,
                    _timepointWhenCurrentSessionStarted.Month, _timepointWhenCurrentSessionStarted.Year);
            }
        }
        private void FillInTime(object sender, EventArgs e)
        {
            ZeitNachtragen formFillIn = new ZeitNachtragen();
            formFillIn.Show();
        }

        private void ShowWeeklyEvaluation(object sender, EventArgs e)
        {
            Wochenansicht wochenansicht = new Wochenansicht();
            wochenansicht.Show();
        }
    }
}
