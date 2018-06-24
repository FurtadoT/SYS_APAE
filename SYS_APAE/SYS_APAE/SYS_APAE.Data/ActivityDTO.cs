using SYS_APAE.SYS_APAE.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Data
{
    class ActivityDTO
    {
        private static DBConnect dbConnector = new DBConnect();

        public static List<Activity> getAllActivities()
        {
            List<Activity> listActivities = new List<Activity>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement("SELECT * FROM activities");

            foreach (var activity in dbResult)
            {
                listActivities.Add(new Activity(
                    Convert.ToInt32(activity["id"]),
                    activity["title"].ToString(),
                    activity["description"].ToString(),
                    DateTime.Parse(activity["dt_created"])
                        ));
            }

            return listActivities;
        }

        public static Activity getActivityById(string id)
        {
            Dictionary<string, string> activity = dbConnector.DoQueryStatement("SELECT * FROM activities where id=" + id)[0];

            return new Activity(
                    Convert.ToInt32(activity["id"]),
                    activity["title"].ToString(),
                    activity["description"].ToString(),
                    DateTime.Parse(activity["dt_created"])
                        );
        }

        public static DataTable getAllActivitiesToDisplay()
        {
            return Utils.getDataToDisplay(getAllActivities());
        }

        public static bool AddNewActivity(Activity activity)
        {
            Dictionary<string, string> fieldsQuery = activity.GenerateDictFields();
            return dbConnector.DoNonQueryStatement(dbConnector.CreateInsertCommandWithParams("activities", fieldsQuery));
        }
    }
}
