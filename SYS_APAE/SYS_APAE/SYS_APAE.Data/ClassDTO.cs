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
                        StudentsDTO.getStudentById(new Dictionary<string, string> { { "id", _class["id_student"].ToString() } }),
                        InstructorDTO.getInstructorById(new Dictionary<string, string> { { "id", _class["id_instructor"].ToString() } }),
                        ActivityDTO.getActivityById(new Dictionary<string, string> { { "id", _class["id_activity"].ToString() } }),
                        DateTime.Parse(_class["dt_created"]),
                        _class["obs_atv"].ToString(),
                        _class["obs_int"].ToString()
                        ));
            }

            return listClass;
        }

        public static List<Class> getFilteredClass(Dictionary<string, string> whereFields)
        {
            List<Class> listClass = new List<Class>();
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement(
                dbConnector.CreateSelectCommandWithParams("classes", whereFields));

            foreach (var _class in dbResult)
            {
                listClass.Add(new Class(
                        Convert.ToInt32(_class["id"]),
                        Convert.ToInt32(_class["dif_dig"]),
                        Convert.ToInt32(_class["dif_lei"]),
                        Convert.ToInt32(_class["dif_rec"]),
                        Convert.ToInt32(_class["dif_atv"]),
                        Convert.ToInt32(_class["dif_int"]),
                        StudentsDTO.getStudentById(new Dictionary<string, string> { { "id", _class["id_student"].ToString() } }),
                        InstructorDTO.getInstructorById(new Dictionary<string, string> { { "id", _class["id_instructor"].ToString() } }),
                        ActivityDTO.getActivityById(new Dictionary<string, string> { { "id", _class["id_activity"].ToString() } }),
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
                    StudentsDTO.getStudentById(new Dictionary<string, string> { { "id", _class["id_student"].ToString() } }),
                    InstructorDTO.getInstructorById(new Dictionary<string, string> { { "id", _class["id_instructor"].ToString() } }),
                    ActivityDTO.getActivityById(new Dictionary<string, string> { { "id", _class["id_activity"].ToString() } }),
                    DateTime.Parse(_class["dt_created"]),
                    _class["obs_atv"].ToString(),
                    _class["obs_int"].ToString()
                    );
        }

        public static DataTable getAllClassToDisplay()
        {
            return Utils.getDataToDisplay(getAllClass());
        }

        public static DataTable getFilteredClassToDisplay(string searchField)
        {
            return Utils.getDataToDisplay(getFilteredClass(new Dictionary<string, string> { { "title", searchField } }));
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
    }
}
