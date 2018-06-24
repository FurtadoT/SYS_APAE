using SYS_APAE.SYS_APAE.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Data
{
    static class ReportsDTO
    {
        private static DBConnect dbConnector = new DBConnect();

        public static List<Report> getAllReports()
        {
            List<Report> listReports = new List<Report>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement(
                dbConnector.CreateSelectCommandWithParams("records", null));

            foreach (var report in dbResult)
            {
                listReports.Add(new Report(
                        Convert.ToInt32(report["id"]),
                        Convert.ToInt32(report["dif_dig"]),
                        Convert.ToInt32(report["dif_lei"]),
                        Convert.ToInt32(report["dif_rec"]),
                        Convert.ToInt32(report["dif_atv"]),
                        Convert.ToInt32(report["dif_int"]),
                        StudentsDTO.getStudentById(new Dictionary<string, string> { { "id", report["id_student"].ToString() } }),
                        InstructorDTO.getInstructorById(new Dictionary<string, string> { { "id", report["id_instructor"].ToString() } }),
                        ActivityDTO.getActivityById(new Dictionary<string, string> { { "id", report["id_activity"].ToString() } }),
                        DateTime.Parse(report["dt_created"]),
                        report["obs_atv"].ToString(),
                        report["obs_int"].ToString()
                        ));
            }

            return listReports;
        }

        public static List<Report> getFilteredReports(Dictionary<string, string> whereFields)
        {
            List<Report> listReports = new List<Report>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement(
                dbConnector.CreateSelectCommandWithParams("records", whereFields));

            foreach (var report in dbResult)
            {
                listReports.Add(new Report(
                        Convert.ToInt32(report["id"]),
                        Convert.ToInt32(report["dif_dig"]),
                        Convert.ToInt32(report["dif_lei"]),
                        Convert.ToInt32(report["dif_rec"]),
                        Convert.ToInt32(report["dif_atv"]),
                        Convert.ToInt32(report["dif_int"]),
                        StudentsDTO.getStudentById(new Dictionary<string, string> { { "id", report["id_student"].ToString() } }),
                        InstructorDTO.getInstructorById(new Dictionary<string, string> { { "id", report["id_instructor"].ToString() } }),
                        ActivityDTO.getActivityById(new Dictionary<string, string> { { "id", report["id_activity"].ToString() } }),
                        DateTime.Parse(report["dt_created"]),
                        report["obs_atv"].ToString(),
                        report["obs_int"].ToString()
                        ));
            }

            return listReports;
        }

        public static DataTable getAllReportsToDisplay()
        {
            return Utils.getDataToDisplay(getAllReports());
        }

        public static DataTable getFilteredReportsToDisplay(string searchField)
        {
            return Utils.getDataToDisplay(getFilteredReports(new Dictionary<string, string> { { "title", searchField } }));
        }

        public static bool AddNewReport(Report report)
        {
            Dictionary<string, string> fieldsQuery = report.GenerateDictFields();
            return dbConnector.DoNonQueryStatement(dbConnector.CreateInsertCommandWithParams("records", fieldsQuery));
        }
    }
}
