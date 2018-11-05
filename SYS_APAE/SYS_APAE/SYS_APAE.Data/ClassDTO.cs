using SYS_APAE.SYS_APAE.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Data
{
    static class ClassDTO
    {
        private static DBConnect dbConnector = new DBConnect();

        public static List<Class> getAllClass()
        {
            List<Class> listClass = new List<Class>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement(
                dbConnector.CreateSelectCommandWithParams("classes", null));

            foreach (var _class in dbResult)
            {
                listClass.Add(new Class(
                        Convert.ToInt32(_class["id"]),
                        Convert.ToInt32(_class["dif_dig"]),
                        Convert.ToInt32(_class["dif_lei"]),
                        Convert.ToInt32(_class["dif_rec"]),
                        Convert.ToInt32(_class["dif_atv"]),
                        Convert.ToInt32(_class["dif_int"]),
                        StudentsDTO.getStudents(new Dictionary<string, string> { { "id", _class["id_student"].ToString() } })[0],
                        InstructorDTO.getInstructors(new Dictionary<string, string> { { "id", _class["id_instructor"].ToString() } })[0],
                        ActivityDTO.getActivities(new Dictionary<string, string> { { "id", _class["id_activity"].ToString() } })[0],
                        DateTime.Parse(_class["dt_created"]),
                        _class["obs_atv"].ToString(),
                        _class["obs_int"].ToString()
                        ));
            }

            return listClass;
        }

        public static List<Class> getFilteredClass(string searchField)
        {
            List<Class> listClass = new List<Class>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement(
                dbConnector.CreateSelectCommandWithProcedure("classes", searchField));

            foreach (var _class in dbResult)
            {
                listClass.Add(new Class(
                        Convert.ToInt32(_class["id"]),
                        Convert.ToInt32(_class["dif_dig"]),
                        Convert.ToInt32(_class["dif_lei"]),
                        Convert.ToInt32(_class["dif_rec"]),
                        Convert.ToInt32(_class["dif_atv"]),
                        Convert.ToInt32(_class["dif_int"]),
                        StudentsDTO.getStudents(new Dictionary<string, string> { { "id", _class["id_student"].ToString() } })[0],
                        InstructorDTO.getInstructors(new Dictionary<string, string> { { "id", _class["id_instructor"].ToString() } })[0],
                        ActivityDTO.getActivities(new Dictionary<string, string> { { "id", _class["id_activity"].ToString() } })[0],
                        DateTime.Parse(_class["dt_created"]),
                        _class["obs_atv"].ToString(),
                        _class["obs_int"].ToString()
                        ));
            }

            return listClass;
        }

        public static Class getClassById(Dictionary<string, string> whereFields)
        {
            Dictionary<string, string> _class = dbConnector.DoQueryStatement(
                dbConnector.CreateSelectCommandWithParams("classes", whereFields))[0];

            return new Class(
                    Convert.ToInt32(_class["id"]),
                    Convert.ToInt32(_class["dif_dig"]),
                    Convert.ToInt32(_class["dif_lei"]),
                    Convert.ToInt32(_class["dif_rec"]),
                    Convert.ToInt32(_class["dif_atv"]),
                    Convert.ToInt32(_class["dif_int"]),
                    StudentsDTO.getStudents(new Dictionary<string, string> { { "id", _class["id_student"].ToString() } })[0],
                    InstructorDTO.getInstructors(new Dictionary<string, string> { { "id", _class["id_instructor"].ToString() } })[0],
                    ActivityDTO.getActivities(new Dictionary<string, string> { { "id", _class["id_activity"].ToString() } })[0],
                    DateTime.Parse(_class["dt_created"]),
                    _class["obs_atv"].ToString(),
                    _class["obs_int"].ToString()
                    );
        }
        private static List<Dictionary<string, string>> toDict(List<Class> classList)
        {
            List<Dictionary<string, string>> classListDict = new List<Dictionary<string, string>>();
            foreach (var instructor in classList)
            {
                classListDict.Add(instructor.GetFieldsToDisplay());
            }

            return classListDict;
        }

        public static DataTable getAllClassToDisplay()
        {
            return Utils.getDataToDisplay(toDict(getAllClass()));
        }

        public static DataTable getAllClassToDisplay(string searchField)
        {
            return Utils.getDataToDisplay(toDict(getFilteredClass(searchField)));
        }

        public static bool AddNewClass(Class _class)
        {
            Dictionary<string, string> fieldsQuery = _class.GenerateDictFields();
            return dbConnector.DoNonQueryStatement(dbConnector.CreateInsertCommandWithParams("classes", fieldsQuery));
        }

        public static bool UpdateClass(Class _class)
        {
            Dictionary<string, string> fieldsQuery = _class.GenerateDictFields();
            return dbConnector.DoNonQueryStatement(dbConnector.CreateUpdateCommandWithParams("classes", fieldsQuery));
        }
        
        public static string GetSearchQuery(string id)
        {
            return "SELECT c.* FROM classes c" +
                " inner join instructors i on c.id_instructor = i.id" +
                " inner join students s on c.id_student = s.id" +
                " inner join activities a on c.id_activity = a.id" +
                " WHERE (a.title=@SEARCH or s.name=@SEARCH or i.name=@SEARCH)";
        }
    }
}
