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
 
        public static DataTable getDataToDisplay(List<Instructor> allInstructors)
        {
            DataTable listData = new DataTable();

            if (allInstructors.Count() == 0)
                return listData;

            getColumnsTable(listData, allInstructors[0].GetFieldsToDisplay().Keys.ToArray());

            foreach (var instructor in allInstructors)
            {
                DataRow listDataRow = listData.NewRow();

                getRowValues(listDataRow, instructor.GetFieldsToDisplay());

                listData.Rows.InsertAt(listDataRow, 0);
            }

            return listData;
        }

        public static DataTable getDataToDisplay(List<Student> allStudents)
        {
            DataTable listData = new DataTable();

            if (allStudents.Count() == 0)
                return listData;

            getColumnsTable(listData, allStudents[0].GetFieldsToDisplay().Keys.ToArray());

            foreach (var student in allStudents)
            {
                DataRow listDataRow = listData.NewRow();

                getRowValues(listDataRow, student.GetFieldsToDisplay());

                listData.Rows.InsertAt(listDataRow, 0);
            }

            return listData;
        }

        public static DataTable getDataToDisplay(List<Class> allReports)
        {
            DataTable listData = new DataTable();

            if (allReports.Count() == 0)
                return listData;

            getColumnsTable(listData, allReports[0].GetFieldsToDisplay().Keys.ToArray());

            foreach (var report in allReports)
            {
                DataRow listDataRow = listData.NewRow();

                getRowValues(listDataRow, report.GetFieldsToDisplay());

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
