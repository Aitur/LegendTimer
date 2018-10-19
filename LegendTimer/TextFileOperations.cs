using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace LegendTimer
{
    class TextFileOperations
    {
        static string file_path = "legendTime.txt";

        /// <summary>
        /// Load the complete saved File
        /// </summary>
        /// <returns></returns>
        public void LoadFile(out TimeSpan[] spentDuration, out DateTime[] dayOfSpentDuration)
        {
            string readString;
            string[] readDays;
            string[] cleanedData;
            using (StreamReader sr = new StreamReader(file_path))
            {
                readString = sr.ReadToEnd();
                readDays = readString.Split('|');
            }
            cleanedData = new string[readDays.Length - 1];
            for (int i = 0; i < cleanedData.Length; i++)
            {
                cleanedData[i] = readDays[i];
            }
            this.convertToObjects(cleanedData, out spentDuration, out dayOfSpentDuration);
        }
        /// <summary>
        /// Convert the Textdata to Objekts
        /// </summary>
        /// <param name="dataofDays"></param>
        /// <param name="spentDuration"></param>
        /// <param name="dayOfSpentDuration"></param>
        private void convertToObjects(string[] dataofDays, out TimeSpan[] spentDuration, out DateTime[] dayOfSpentDuration)
        {
            spentDuration = new TimeSpan[dataofDays.Length];
            dayOfSpentDuration = new DateTime[dataofDays.Length];
            for (var i = 0; i < dataofDays.Length; i++)
            {
                string[] dataFragments = dataofDays[i].Split(';');
                int.TryParse(dataFragments[3], out int dayOfData);
                int.TryParse(dataFragments[4], out int monthOfData);
                int.TryParse(dataFragments[5], out int yearOfData);
                int.TryParse(dataFragments[0], out int dataSeconds);
                int.TryParse(dataFragments[1], out int dataMinutes);
                int.TryParse(dataFragments[2], out int dataHours);

                spentDuration[i] = new TimeSpan(dataHours,dataMinutes,dataSeconds);
                dayOfSpentDuration[i] = new DateTime(yearOfData,monthOfData,dayOfData);
            }
        }

        /// <summary>
        /// The given durations are saved. If there is already an entry for the given day, then the duration to save ist added
        /// to the values in the entry.
        /// </summary>
        public void SaveFile(TimeSpan spentTime, DateTime dayOfSpentTime)
        {
            //If the File doesn't exist, then it is created and the time is saved.
            if (!File.Exists(file_path))
            {
                File.WriteAllText(file_path,
                    spentTime.Seconds + ";" + spentTime.Minutes + ";" + spentTime.Hours + ";" + dayOfSpentTime.Day + ";" + dayOfSpentTime.Month + ";" + dayOfSpentTime.Year + "|");
            }
            //Otherwise there is already a file. It is checked, wether there is already an entry for the given day.
            else
            {
                bool entryChanged = this.changeEntry(spentTime, dayOfSpentTime);
                //Otherwise a new Line is written.
                if (entryChanged == false)
                {
                    using (StreamWriter sw = new StreamWriter(file_path))
                    {
                        sw.WriteLine(spentTime.Seconds + ";" + spentTime.Minutes + ";" + spentTime.Hours + ";" + dayOfSpentTime.Day + ";" + dayOfSpentTime.Month + ";" + dayOfSpentTime.Year +
                                     "|");
                    }
                }
            }
        }
        /// <summary>
        /// Changes the entry for the given day oder returns false otherwise
        /// </summary>
        /// <param name="spentDuration"></param>
        /// <param name="dayOfSpentTime"></param>
        /// <returns></returns>
        private bool changeEntry(TimeSpan spentDuration, DateTime dayOfSpentTime)
        {
            this.LoadFile(out TimeSpan[] savedDurations, out DateTime[] daysOfSavedDurations);
            bool entryFound = false;
            for (int i = 0; i < savedDurations.Length; i++)
            {
                if (dayOfSpentTime.Equals(daysOfSavedDurations[i]))
                {
                    entryFound = true;
                    //If an entry with similar day is found, the spend time is added.
                    savedDurations[i] += spentDuration;
                    break;
                }
            }

            //If there was a entry with similar day, the file is overwritten with the changed value.
            if (entryFound == true)
            {
                this.fileOverride(savedDurations,daysOfSavedDurations);
            }

            return entryFound;
        }

        private void fileOverride(TimeSpan[] spentDuration, DateTime[] dayOfSpentTime)
        {
            using (StreamWriter sw = new StreamWriter(file_path))
            {
                string tempRead = "";
                for (var i = 0; i < spentDuration.Length; i++)
                {
                    tempRead += spentDuration[i].Seconds + ";" + spentDuration[i].Minutes + ";" +
                                spentDuration[i].Hours + ";" + dayOfSpentTime[i].Day + ";" + dayOfSpentTime[i].Month +
                                ";" + dayOfSpentTime[i].Year +
                                "|";
                }
                sw.Write(tempRead);
            }
        }
    }
}
