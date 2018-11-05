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

        public static List<Activity> getActivities(Dictionary<string, string> whereFields = null)
        {
            List<Activity> listActivities = new List<Activity>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement(
                dbConnector.CreateSelectCommandWithParams("activities", whereFields));

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

        public static List<Activity> searchForActivities(string searchField)
        {
            List<Activity> listActivities = new List<Activity>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement(
                dbConnector.CreateSelectCommandWithProcedure("activities", searchField));

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

        public static DataTable getAllActivitiesTitle()
        {
            DataTable lisActivities = new DataTable();
            lisActivities.Columns.Add("Id", typeof(int));
            lisActivities.Columns.Add("Name");

            List<Activity> completeListActivity = getActivities();

            foreach (var activity in completeListActivity)
            {
                DataRow listRow = lisActivities.NewRow();
                listRow["Name"] = activity.Title;
                listRow["Id"] = activity.Id;
                lisActivities.Rows.InsertAt(listRow, 0);
            }

            return lisActivities;
        }
        private static List<Dictionary<string, string>> toDict(List<Activity> activityList)
        {
            List<Dictionary<string, string>> activityListDict = new List<Dictionary<string, string>>();
            foreach (var instructor in activityList)
            {
                activityListDict.Add(instructor.GetFieldsToDisplay());
            }

            return activityListDict;
        }

        public static DataTable getAllActivitiesToDisplay()
        {
            return Utils.getDataToDisplay(toDict(getActivities()));
        }

        public static DataTable getAllActivitiesToDisplay(string searchField)
        {
            return Utils.getDataToDisplay(toDict(searchForActivities(searchField)));
        }

        public static bool AddNewActivity(Activity activity)
        {
            Dictionary<string, string> fieldsQuery = activity.GenerateDictFields();
            return dbConnector.DoNonQueryStatement(dbConnector.CreateInsertCommandWithParams("activities", fieldsQuery));
        }

        public static bool UpdateActivity(Activity activity)
        {
            Dictionary<string, string> fieldsQuery = activity.GenerateDictFields();
            return dbConnector.DoNonQueryStatement(dbConnector.CreateUpdateCommandWithParams("activities", fieldsQuery));
        }
    }
}
