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

        public static List<Instructor> getAllInstructors()
        {
            List<Instructor> listInstructors = new List<Instructor>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement("SELECT * FROM instructors");

            foreach (var instructor in dbResult)
            {
                listInstructors.Add(new Instructor(
                        Convert.ToInt32(instructor["id"]),
                        instructor["name"].ToString(),
                        instructor["cpf"].ToString(),
                        "",
                        instructor["tipo_monitor"].ToString(),
                        instructor["prontuario"].ToString(),
                        instructor["email"].ToString(),
                        Convert.ToInt32(instructor["carga_horaria"])
                        ));
            }

            return listInstructors;
        }

        public static DataTable getAllInstructorsName()
        {
            DataTable listInstructors = new DataTable();
            listInstructors.Columns.Add("Id", typeof(int));
            listInstructors.Columns.Add("Name");

            List<Instructor> completeListStudent = getAllInstructors();

            foreach (var instructor in completeListStudent)
            {
                DataRow listRow = listInstructors.NewRow();
                listRow["Name"] = instructor.Name;
                listRow["Id"] = instructor.Id;
                listInstructors.Rows.InsertAt(listRow, 0);
            }

            return listInstructors;
        }

        public static DataTable getAllInstructorsToDisplay()
        {
            return Utils.getDataToDisplay(getAllInstructors());
        }

        public static Instructor getInstructorById(string id)
        {
            Dictionary<string, string> instructor = dbConnector.DoQueryStatement("SELECT * FROM instructors where id=" + id)[0];

            return new Instructor(
                        Convert.ToInt32(instructor["id"]),
                        instructor["name"].ToString(),
                        instructor["cpf"].ToString(),
                        "",
                        instructor["email"].ToString(),
                        instructor["prontuario"].ToString(),
                        instructor["tipo_monitor"].ToString(),
                        Convert.ToInt32(instructor["carga_horaria"])
                        );
        }

        public static string getProntuario(int id)
        {
            return dbConnector.DoQueryStatement("SELECT prontuario FROM instructors where id="+id)[0]["prontuario"];
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
