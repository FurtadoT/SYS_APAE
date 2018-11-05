using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Models
{
    class Utils
    {
        private static void getColumnsTable(DataTable listData, IEnumerable<string> columns)
        {
            foreach (var key in columns)
                listData.Columns.Add(key);
        }

        private static void getRowValues(DataRow newListRow, Dictionary<string, string> values)
        {
            foreach (KeyValuePair<string, string> field in values)
                newListRow[field.Key] = field.Value;
        }

        public static DataTable getDataToDisplay(List<Dictionary<string, string>> fields)
        {
            DataTable listData = new DataTable();

            if (fields.Count() == 0)
                return listData;

            getColumnsTable(listData, fields[0].Keys.ToArray());

            foreach (var field in fields)
            {
                DataRow listDataRow = listData.NewRow();

                getRowValues(listDataRow, field);

                listData.Rows.InsertAt(listDataRow, 0);
            }

            return listData;
        }

        public static DataTable getDataToDisplay(List<Activity> allActivities)
        {
            DataTable listData = new DataTable();

            if (allActivities.Count() == 0)
                return listData;

            getColumnsTable(listData, allActivities[0].GetFieldsToDisplay().Keys.ToArray());

            foreach (var activity in allActivities)
            {
                DataRow listDataRow = listData.NewRow();

                getRowValues(listDataRow, activity.GetFieldsToDisplay());

                listData.Rows.InsertAt(listDataRow, 0);
            }

            return listData;
        }
    }
}
