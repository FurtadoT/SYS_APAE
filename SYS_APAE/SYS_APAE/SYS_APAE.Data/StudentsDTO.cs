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
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement("SELECT * FROM students");

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
                        student["email"].ToString()
                        ));
            }

            return listStudents;
        }

        public static DataTable getAllStudentsName()
        {
            DataTable listStudents = new DataTable();
            listStudents.Columns.Add("Id", typeof(int));
            listStudents.Columns.Add("Name");

            List<StudentsView> completeListStudent = getAllStudentsUsingView();

            foreach (var student in completeListStudent)
            {
                DataRow listRow = listStudents.NewRow();
                listRow["Name"] = student.Nome;
                listRow["Id"] = student.Id;
                listStudents.Rows.InsertAt(listRow, 0);
            }

            return listStudents;
        }


        public static List<StudentsView> getAllStudentsUsingView()
        {
            List<StudentsView> listStudents = new List<StudentsView>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement("SELECT * FROM students_view");

            foreach (var student in dbResult)
            {
                listStudents.Add(new StudentsView(
                        Convert.ToInt32(student["Id"]),
                        student["Nome"].ToString(),
                        student["CPF"].ToString(),
                        student["Telefone"].ToString(),
                        student["E-mail"].ToString()
                        ));
            }

            return listStudents;
        }

        public static Student getStudentById(string id)
        {
            Dictionary<string, string> student = dbConnector.DoQueryStatement("SELECT * FROM students where id=" + id)[0];

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
                        student["email"].ToString()
                        );
        }

        public static bool addNewStudent(Student student)
        {
           Dictionary<string, string> fieldsQuery = student.GenerateDictFields();
           return dbConnector.DoNonQueryStatement(dbConnector.CreateInsertCommandWithParams("students", fieldsQuery));
        }
    }
}
