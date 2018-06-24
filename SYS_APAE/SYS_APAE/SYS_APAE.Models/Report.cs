using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Models
{
    class Report
    {
        private int id, dif_dig, dif_lei, dif_rec, dif_atv, dif_int;
        private Student student;
        private Instructor instructor;
        private Activity activity;
        private DateTime dt_created;
        private string obs_atv, obs_int;

        public Report(int id, int dif_dig, int dif_lei, int dif_rec, int dif_atv, int dif_int, Student student, Instructor instructor, Activity activity, DateTime dt_created, string obs_atv, string obs_int)
        {
            Id = id;
            Dif_dig = dif_dig;
            Dif_lei = dif_lei;
            Dif_rec = dif_rec;
            Dif_atv = dif_atv;
            Dif_int = dif_int;
            this.Student = student;
            this.Instructor = instructor;
            this.Activity = activity;
            Dt_created = dt_created;
            Obs_atv = obs_atv;
            Obs_int = obs_int;
        }

        public virtual Dictionary<string, string> GenerateDictFields()
        {
            Dictionary<string, string> fieldsQuery = new Dictionary<string, string>
            {
                { "id", Id.ToString() },
                { "id_student", Student.Id.ToString() },
                { "id_instructor", Instructor.Id.ToString() },
                { "id_activity", Activity.Id.ToString() },
                { "dt_created", Dt_created.ToString("yyyy-MM-dd") },
                { "dif_dig", Dif_dig.ToString() },
                { "dif_lei", Dif_lei.ToString() },
                { "dif_rec", Dif_rec.ToString() },
                { "dif_atv", Dif_atv.ToString() },
                { "obs_atv", Obs_atv },
                { "dif_int", Dif_int.ToString() },
                { "obs_int", Obs_int }
            };

            return fieldsQuery;
        }

        public Dictionary<string, string> GetFieldsToDisplay()
        {
            Dictionary<string, string> displayFields = new Dictionary<string, string>
            {
                { "Id", Id.ToString() },
                { "Nome do aluno", Student.Name },
                { "Nome do monitor", Instructor.Name },
                { "Título da atividade", Activity.Title },
                { "Data", Dt_created.ToString("dd/MM/yyyy") }
            };

            return displayFields;
        }


        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Dif_dig
        {
            get
            {
                return dif_dig;
            }

            set
            {
                dif_dig = value;
            }
        }

        public int Dif_lei
        {
            get
            {
                return dif_lei;
            }

            set
            {
                dif_lei = value;
            }
        }

        public int Dif_rec
        {
            get
            {
                return dif_rec;
            }

            set
            {
                dif_rec = value;
            }
        }

        public int Dif_atv
        {
            get
            {
                return dif_atv;
            }

            set
            {
                dif_atv = value;
            }
        }

        public int Dif_int
        {
            get
            {
                return dif_int;
            }

            set
            {
                dif_int = value;
            }
        }

        internal Activity Activity
        {
            get
            {
                return activity;
            }

            set
            {
                activity = value;
            }
        }

        internal Student Student
        {
            get
            {
                return student;
            }

            set
            {
                student = value;
            }
        }

        internal Instructor Instructor
        {
            get
            {
                return instructor;
            }

            set
            {
                instructor = value;
            }
        }

        public DateTime Dt_created
        {
            get
            {
                return dt_created;
            }

            set
            {
                dt_created = value;
            }
        }

        public string Obs_atv
        {
            get
            {
                return obs_atv;
            }

            set
            {
                obs_atv = value;
            }
        }

        public string Obs_int
        {
            get
            {
                return obs_int;
            }

            set
            {
                obs_int = value;
            }
        }
    }
}
