using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegendTimer
{
    public partial class ZeitNachtragen : Form
    {
        public ZeitNachtragen()
        {
            InitializeComponent();
        }

        private void zeitNachtragen(object sender, EventArgs e)
        {
            int tempSecond;
            int tempMinutes;
            int tempHours;
            int.TryParse(textBoxSeconds.Text, out tempSecond);
            int.TryParse(textBoxMinutes.Text, out tempMinutes);
            int.TryParse(textBoxHours.Text, out tempHours);
            TextFileOperations.saveFile(tempSecond, tempMinutes, tempHours, dateTimePicker.Value.Day, dateTimePicker.Value.Month, dateTimePicker.Value.Year);
        }
    }
}
