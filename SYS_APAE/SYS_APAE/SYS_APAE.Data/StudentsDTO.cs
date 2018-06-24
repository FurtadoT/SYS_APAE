using SYS_APAE.SYS_APAE.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Data
{
    static class StudentsDTO
    {
        private static DBConnect dbConnector = new DBConnect();

        public static List<Student> getAllStudents()
        {
            List<Student> listStudents = new List<Student>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement(
                dbConnector.CreateSelectCommandWithParams("students", null));

            foreach (var student in dbResult)
            {
                listStudents.Add(new Student(
                        Convert.ToInt32(student["id"]),
                        student["name"].ToString(),
                        student["cpf"].ToString(),
                        student["rg"].ToString(),
                        student["org_exp"].ToString(),
                        DateTime.Parse(student["dt_exp"]),
                        DateTime.Parse(student["dt_nasc"]),
                        student["nationality"].ToString(),
                        student["father_name"].ToString(),
                        student["mother_name"].ToString(),
                        student["address"].ToString(),
                        student["city"].ToString(),
                        student["state"].ToString(),
                        student["district"].ToString(),
                        student["cep"].ToString(),
                        student["phone"].ToString(),
                        student["celphone"].ToString(),
                        student["email"].ToString(),
                        DateTime.Parse(student["dt_created"])
                        ));
            }

            return listStudents;
        }

        public static List<Student> getFilteredStudents(Dictionary<string, string> whereFields)
        {
            List<Student> listStudents = new List<Student>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement(
                dbConnector.CreateSelectCommandWithParams("students", whereFields));

            foreach (var student in dbResult)
            {
                listStudents.Add(new Student(
                        Convert.ToInt32(student["id"]),
                        student["name"].ToString(),
                        student["cpf"].ToString(),
                        student["rg"].ToString(),
                        student["org_exp"].ToString(),
                        DateTime.Parse(student["dt_exp"]),
                        DateTime.Parse(student["dt_nasc"]),
                        student["nationality"].ToString(),
                        student["father_name"].ToString(),
                        student["mother_name"].ToString(),
                        student["address"].ToString(),
                        student["city"].ToString(),
                        student["state"].ToString(),
                        student["district"].ToString(),
                        student["cep"].ToString(),
                        student["phone"].ToString(),
                        student["celphone"].ToString(),
                        student["email"].ToString(),
                        DateTime.Parse(student["dt_created"])
                        ));
            }

            return listStudents;
        }

        public static DataTable getAllStudentsName()
        {
            DataTable listStudents = new DataTable();
            listStudents.Columns.Add("Id", typeof(int));
            listStudents.Columns.Add("Name");

            List<Student> completeListStudent = getAllStudents();

            foreach (var student in completeListStudent)
            {
                DataRow listRow = listStudents.NewRow();
                listRow["Name"] = student.Name;
                listRow["Id"] = student.Id;
                listStudents.Rows.InsertAt(listRow, 0);
            }

            return listStudents;
        }

        public static DataTable getAllStudentsToDisplay()
        {
            return Utils.getDataToDisplay(getAllStudents());
        }

        public static DataTable getFilteredStudentsToDisplay(string searchField)
        {
            return Utils.getDataToDisplay(getFilteredStudents(new Dictionary<string, string> { { "name", "%" + searchField + "%" } }));
        }

        public static Student getStudentById(Dictionary<string, string> whereFields)
        {
            Dictionary<string, string> student = dbConnector.DoQueryStatement(
                dbConnector.CreateSelectCommandWithParams("students", whereFields))[0];

            return new Student(
                        Convert.ToInt32(student["id"]),
                        student["name"].ToString(),
                        student["cpf"].ToString(),
                        student["rg"].ToString(),
                        student["org_exp"].ToString(),
                        DateTime.Parse(student["dt_exp"]),
                        DateTime.Parse(student["dt_nasc"]),
                        student["nationality"].ToString(),
                        student["father_name"].ToString(),
                        student["mother_name"].ToString(),
                        student["address"].ToString(),
                        student["city"].ToString(),
                        student["state"].ToString(),
                        student["district"].ToString(),
                        student["cep"].ToString(),
                        student["phone"].ToString(),
                        student["celphone"].ToString(),
                        student["email"].ToString(),
                        DateTime.Parse(student["dt_created"])
                        );
        }

        public static bool AddNewStudent(Student student)
        {
           Dictionary<string, string> fieldsQuery = student.GenerateDictFields();
           return dbConnector.DoNonQueryStatement(dbConnector.CreateInsertCommandWithParams("students", fieldsQuery));
        }

        public static bool UpdateInstructor(Student student)
        {
            Dictionary<string, string> fieldsQuery = student.GenerateDictFields();
            return dbConnector.DoNonQueryStatement(dbConnector.CreateUpdateCommandWithParams("students", fieldsQuery));
        }
    }
}
