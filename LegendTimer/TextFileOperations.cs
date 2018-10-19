using System;
using System.IO;

namespace LegendTimer
{
    class TextFileOperations
    {
        static string filepath = "legendTime.txt";
        /// <summary>
        /// The given durations are saved. If there is already an entry for the given day, then the duration to save ist added
        /// to the values in the entry.
        /// </summary>
        /// <param name="seconds">Seconds that were tracked</param>
        /// <param name="minutes">Minutes that were tracked.</param>
        /// <param name="hours">Hours that were tracked</param>
        /// <param name="day">Day of the tracked time</param>
        /// <param name="month">Month of the tracked time</param>
        /// <param name="year">Year of the tracked time</param>
        /// 
        /****************************************************
         * One method to save the file and one to create the stuff that will be saved!! Artur get to work
         ***************************************************/
        public void SaveFile(int seconds, int minutes, int hours, int day, int month, int year)
        {
            //create file if it doesnt exist
            if (!File.Exists(filepath))
            {
                File.WriteAllText(filepath,
                    seconds + ";" + minutes + ";" + hours + ";" + day + ";" + month + ";" + year + "|");
            }
            //check if there is an entry for the current day
            else
            {
                bool alreadySavedToday = false;
                string[] loadedDays = LoadFile();
                for (int i = 0; i < loadedDays.Length; i++)
                {
                    if (loadedDays[0].Equals(filepath))
                    { continue; }
                    string[] dayDataSplit = loadedDays[i].Split(';');
                    int.TryParse(dayDataSplit[3], out var dayOfData);
                    int.TryParse(dayDataSplit[4], out var monthOfData);
                    int.TryParse(dayDataSplit[5], out var yearOfData);
                    if (day == dayOfData || month == monthOfData || year == yearOfData)
                    {
                        alreadySavedToday = true;
                        int.TryParse(dayDataSplit[0], out var dataSeconds);
                        int.TryParse(dayDataSplit[1], out var dataMinutes);
                        int.TryParse(dayDataSplit[2], out var dataHours);
                        //If an entry with similar day is found, the spend time is added.
                        dayDataSplit[0] = (dataSeconds + seconds).ToString();
                        dayDataSplit[1] = (dataMinutes + minutes).ToString();
                        dayDataSplit[2] = (dataHours + hours).ToString();
                        loadedDays[i] = dayDataSplit[0] + ";" + dayDataSplit[1] + ";" + dayDataSplit[2] +
                                          ";" + dayDataSplit[3] + ";" + dayDataSplit[4] + ";" +
                                          dayDataSplit[5];
                        break;
                    }
                }

                //If there was a entry with similar day, the file is overwritten with the changed value.
                if (alreadySavedToday)
                {
                    using (StreamWriter sw = new StreamWriter(filepath))
                    {
                        string tempRead = "";
                        foreach (String s in loadedDays)
                        {
                            tempRead += s + "|";
                        }

                        sw.Write(tempRead);
                    }
                }

                //Otherwise a new Line is written.
                if (alreadySavedToday == false)
                {
                    using (StreamWriter sw = new StreamWriter(filepath))
                    {
                        sw.WriteLine(seconds + ";" + minutes + ";" + hours + ";" + day + ";" + month + ";" + year +
                                     "|");
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public String[] LoadFile()
        {
            string readString;
            string[] readDays;
            string[] cleanedData;
            using (StreamReader sr = new StreamReader(filepath))
            {
                readString = sr.ReadToEnd();
                readDays = readString.Split('|');
            }
            cleanedData = new string[readDays.Length - 1];
            for(int i = 0; i < cleanedData.Length; i++)
            {
                cleanedData[i] = readDays[i];
            }
            return readDays;
        }

    }
}
