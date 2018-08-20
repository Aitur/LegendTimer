using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendTimer
{
    class TextFileOperations
    {
        static string path = "legendTime.txt";
        /// <summary>
        /// The given durations are saved. If there is already an entry for the given day, then the duration to save ist added
        /// to the values in the entry.
        /// </summary>
        /// <param name="seconds">Seconds that where spend Legendary.</param>
        /// <param name="minutes">Minutes that where spend Legendary.</param>
        /// <param name="hours">Hours that where spend Legendary.</param>
        /// <param name="day">Day of the Legendary spend time.</param>
        /// <param name="month">Month of the Legendary spend time.</param>
        /// <param name="year">Year of the Legendary spend time.</param>
        public static void saveFile(int seconds, int minutes, int hours, int day, int month, int year)
        {
            //If the File doesn't exist, then it is created and the time is saved.
            if (!File.Exists(path))
            {
                File.WriteAllText(path,
                    seconds + ";" + minutes + ";" + hours + ";" + day + ";" + month + ";" + year + "|");
            }
            //Otherwise there ist already a file. It is checked, wether there is already an entry for the given day.
            else
            {
                string tempRead;
                string[] tempSplitted;
                string[] tempSplittedLine;
                int tempSeconds;
                int tempMinutes;
                int tempHours;
                int tempDay;
                int tempMonth;
                int tempYear;
                bool alreadySavedToday = false;
                tempSplitted = TextFileOperations.loadFile();
                for (int i = 0; i < tempSplitted.Length; i++)
                {
                    if (tempSplitted[0].Equals(path))
                    {
                        continue;
                    }

                    tempSplittedLine = tempSplitted[i].Split(';');
                    int.TryParse(tempSplittedLine[3], out tempDay);
                    int.TryParse(tempSplittedLine[4], out tempMonth);
                    int.TryParse(tempSplittedLine[5], out tempYear);
                    if (day == tempDay || month == tempMonth || year == tempYear)
                    {
                        alreadySavedToday = true;
                        int.TryParse(tempSplittedLine[0], out tempSeconds);
                        int.TryParse(tempSplittedLine[1], out tempMinutes);
                        int.TryParse(tempSplittedLine[2], out tempHours);
                        //If an entry with similar day is found, the spend time is added.
                        tempSplittedLine[0] = (tempSeconds + seconds).ToString();
                        tempSplittedLine[1] = (tempMinutes + minutes).ToString();
                        tempSplittedLine[2] = (tempHours + hours).ToString();
                        tempSplitted[i] = tempSplittedLine[0] + ";" + tempSplittedLine[1] + ";" + tempSplittedLine[2] +
                                          ";" + tempSplittedLine[3] + ";" + tempSplittedLine[4] + ";" +
                                          tempSplittedLine[5];
                        break;
                    }
                }

                //If there was a entry with similar day, the file is overwritten with the changed value.
                if (alreadySavedToday == true)
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        tempRead = "";
                        foreach (String s in tempSplitted)
                        {
                            tempRead += s + "|";
                        }

                        sw.Write(tempRead);
                    }
                }

                //Otherwise a new Line is written.
                if (alreadySavedToday == false)
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(seconds + ";" + minutes + ";" + hours + ";" + day + ";" + month + ";" + year +
                                     "|");
                    }
                }
            }
        }

        public static String[] loadFile()
        {
            string tempRead;
            string[] tempSplitted;
            string[] cleanedData;
            using (StreamReader sr = new StreamReader(path))
            {
                tempRead = sr.ReadToEnd();
                tempSplitted = tempRead.Split('|');
            }
            cleanedData = new string[tempSplitted.Length - 1];
            for(int i = 0; i < cleanedData.Length; i++)
            {
                cleanedData[i] = tempSplitted[i];
            }
            return tempSplitted;
        }

    }
}
