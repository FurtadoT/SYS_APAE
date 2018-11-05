using SYS_APAE.SYS_APAE.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Data
{
    class InstructorDTO
    {
        private static DBConnect dbConnector = new DBConnect();

        public static List<Instructor> getInstructors(Dictionary<string, string> whereFields = null)
        {
            List<Instructor> listInstructors = new List<Instructor>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement(
                dbConnector.CreateSelectCommandWithParams("instructors", whereFields));

            foreach (var instructor in dbResult)
            {
                listInstructors.Add(new Instructor(
                        Convert.ToInt32(instructor["id"]),
                        instructor["name"].ToString(),
                        instructor["cpf"].ToString(),
                        "",
                        instructor["email"].ToString(),
                        instructor["prontuario"].ToString(),
                        instructor["tipo_monitor"].ToString(),
                        Convert.ToInt32(instructor["carga_horaria"]),
                        DateTime.Parse(instructor["dt_created"])
                        ));
            }

            return listInstructors;
        }

        public static List<Instructor> searchForInstructors(string searchField)
        {
            List<Instructor> listInstructors = new List<Instructor>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement(
                dbConnector.CreateSelectCommandWithProcedure("instructors", searchField));

            foreach (var instructor in dbResult)
            {
                listInstructors.Add(new Instructor(
                        Convert.ToInt32(instructor["id"]),
                        instructor["name"].ToString(),
                        instructor["cpf"].ToString(),
                        "",
                        instructor["email"].ToString(),
                        instructor["prontuario"].ToString(),
                        instructor["tipo_monitor"].ToString(),
                        Convert.ToInt32(instructor["carga_horaria"]),
                        DateTime.Parse(instructor["dt_created"])
                        ));
            }

            return listInstructors;
        }

        public static DataTable getAllInstructorsName()
        {
            DataTable listInstructors = new DataTable();
            listInstructors.Columns.Add("Id", typeof(int));
            listInstructors.Columns.Add("Name");

            List<Instructor> completeListStudent = getInstructors();

            foreach (var instructor in completeListStudent)
            {
                DataRow listRow = listInstructors.NewRow();
                listRow["Name"] = instructor.Name;
                listRow["Id"] = instructor.Id;
                listInstructors.Rows.InsertAt(listRow, 0);
            }

            return listInstructors;
        }

        private static List<Dictionary<string, string>> toDict(List<Instructor> instructorList)
        {
            List<Dictionary<string, string>> instructorListDict = new List<Dictionary<string, string>>();
            foreach (var instructor in instructorList)
            {
                instructorListDict.Add(instructor.GetFieldsToDisplay());
            }

            return instructorListDict;
        }

        public static DataTable getAllInstructorsToDisplay()
        {
            return Utils.getDataToDisplay(toDict(getInstructors()));
        }

        public static DataTable getAllInstructorsToDisplay(string searchField)
        {
            return Utils.getDataToDisplay(toDict(searchForInstructors(searchField)));
        }

        public static string getProntuario(int id)
        {
            return getInstructors(new Dictionary<string, string> { { "id", id.ToString() } })[0].Prontuario;
        }

        public static bool AddNewInstructor(Instructor instructor)
        {
            Dictionary<string, string> fieldsQuery = instructor.GenerateDictFields();
            return dbConnector.DoNonQueryStatement(dbConnector.CreateInsertCommandWithParams("instructors", fieldsQuery));
        }

        public static bool UpdateInstructor(Instructor instructor)
        {
            Dictionary<string, string> fieldsQuery = instructor.GenerateDictFields();
            return dbConnector.DoNonQueryStatement(dbConnector.CreateUpdateCommandWithParams("instructors", fieldsQuery));
        }
    }
}
