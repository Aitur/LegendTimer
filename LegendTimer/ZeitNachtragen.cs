using System;
using System.Windows.Forms;

namespace LegendTimer
{
    public partial class ZeitNachtragen : Form
    {
        public ZeitNachtragen()
        {
            InitializeComponent();
        }

        private void TimeNachtragen(object sender, EventArgs e)
        {
            int tempSecond;
            int tempMinutes;
            int tempHours;
            int.TryParse(textBoxSeconds.Text, out tempSecond);
            int.TryParse(textBoxMinutes.Text, out tempMinutes);
            int.TryParse(textBoxHours.Text, out tempHours);
            TextFileOperations.SaveFile(tempSecond, tempMinutes, tempHours, dateTimePicker.Value.Day,
                dateTimePicker.Value.Month, dateTimePicker.Value.Year);
        }
    }
}
