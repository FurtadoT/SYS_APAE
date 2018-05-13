using SYS_APAE.SYS_APAE.Models;
using System;
using System.Collections.Generic;
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
                        instructor["rg"].ToString(),
                        instructor["org_exp"].ToString(),
                        DateTime.Parse(instructor["dt_exp"]),
                        DateTime.Parse(instructor["dt_nasc"]),
                        instructor["nationality"].ToString(),
                        instructor["father_name"].ToString(),
                        instructor["mother_name"].ToString(),
                        instructor["address"].ToString(),
                        instructor["city"].ToString(),
                        instructor["state"].ToString(),
                        instructor["district"].ToString(),
                        instructor["cep"].ToString(),
                        instructor["phone"].ToString(),
                        instructor["celphone"].ToString(),
                        instructor["email"].ToString(),
                        instructor["prontuario"].ToString()
                        ));
            }

            return listInstructors;
        }


        public static List<InstructorsView> getAllInstructorsUsingView()
        {
            List<InstructorsView> listInstructors = new List<InstructorsView>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement("SELECT * FROM instructors_view");

            foreach (var instructor in dbResult)
            {
                listInstructors.Add(new InstructorsView(
                        Convert.ToInt32(instructor["Id"]),
                        instructor["Nome"].ToString(),
                        instructor["CPF"].ToString(),
                        instructor["Telefone"].ToString(),
                        instructor["E-mail"].ToString(),
                        instructor["Prontuario"].ToString()
                        ));
            }

            return listInstructors;
        }

        public static Instructor getInstructorById(string id)
        {
            Dictionary<string, string> instructor = dbConnector.DoQueryStatementOnlyFirstRow("SELECT * FROM instructors where id=" + id);

            return new Instructor(
                        Convert.ToInt32(instructor["id"]),
                        instructor["name"].ToString(),
                        instructor["cpf"].ToString(),
                        instructor["rg"].ToString(),
                        instructor["org_exp"].ToString(),
                        DateTime.Parse(instructor["dt_exp"]),
                        DateTime.Parse(instructor["dt_nasc"]),
                        instructor["nationality"].ToString(),
                        instructor["father_name"].ToString(),
                        instructor["mother_name"].ToString(),
                        instructor["address"].ToString(),
                        instructor["city"].ToString(),
                        instructor["state"].ToString(),
                        instructor["district"].ToString(),
                        instructor["cep"].ToString(),
                        instructor["phone"].ToString(),
                        instructor["celphone"].ToString(),
                        instructor["email"].ToString(),
                        instructor["prontuario"].ToString()
                        );
        }

        public static bool addNewInstructor(Instructor instructor)
        {
            string[] partialQuery = instructor.GeneratePartialInsertQuery();
            return dbConnector.DoNonQueryStatement("INSERT INTO instructors (" + partialQuery[0] + ") VALUES(" + partialQuery[1] + ")");
        }
    }
}
