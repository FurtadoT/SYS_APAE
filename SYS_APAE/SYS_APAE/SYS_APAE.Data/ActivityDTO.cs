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

        public static List<Activity> getFilteredActivities(string searchField)
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

        public static DataTable getAllActivitiesToDisplay()
        {
            return Utils.getDataToDisplay(getActivities());
        }

        public static DataTable getFilteredActivitiesToDisplay(string searchField)
        {
            return Utils.getDataToDisplay(getFilteredActivities(searchField));
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
