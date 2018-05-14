using SYS_APAE.SYS_APAE.Models;
using System;
using System.Collections.Generic;
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
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement("SELECT * FROM records");

            foreach (var report in dbResult)
            {
                listReports.Add(new Report(
                        Convert.ToInt32(report["id"]),
                        Convert.ToInt32(report["dif_dig"]),
                        Convert.ToInt32(report["dif_lei"]),
                        Convert.ToInt32(report["dif_rec"]),
                        Convert.ToInt32(report["dif_atv"]),
                        Convert.ToInt32(report["dif_int"]),
                        StudentsDTO.getStudentById(report["id_student"].ToString()),
                        InstructorDTO.getInstructorById(report["id_instructor"].ToString()),
                        DateTime.Parse(report["dt_created"]),
                        report["title"].ToString(),
                        report["obs_atv"].ToString(),
                        report["obs_int"].ToString()
                        ));
            }

            return listReports;
        }

        public static bool addNewReport(Report report)
        {
            string[] partialQuery = report.GeneratePartialInsertQuery();
            return dbConnector.DoNonQueryStatement("INSERT INTO records (" + partialQuery[0] + ") VALUES(" + partialQuery[1] + ")");
        }
    }
}
