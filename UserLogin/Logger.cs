using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UserLogin
{
    public static class Logger
    {
        private static List<string> currentSessionActivities = new List<string>();


        public static void LogActivity(string activity)
        {
            StringBuilder activityLine = new StringBuilder();
            activityLine.Append(DateTime.Now + "; ");
            activityLine.Append(LoginValidation.CurrentUserUsername + "; ");
            activityLine.Append(LoginValidation.CurrentUserRole + "; ");
            activityLine.Append(activity);
            currentSessionActivities.Add(activityLine.ToString());

            if (File.Exists("log.txt") == true)
            {
                File.AppendAllText("log.txt", activityLine.ToString());
            }
            else
                File.WriteAllText("log.txt", activityLine.ToString());
        }

        public static string GetCurrentSessionActivities(string filter)
        {
            var filteredActivities = from activity in currentSessionActivities
                                              where activity.Contains(filter)
                                              select activity;

            StringBuilder sb = new StringBuilder();
            foreach(var activity in filteredActivities)
            {
                sb.Append(activity + "\n");
            }
            return sb.ToString();
        }
    }
}
