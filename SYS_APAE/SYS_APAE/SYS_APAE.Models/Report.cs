﻿using System;
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
        private DateTime dt_created;
        private string title, obs_atv, obs_int;

        public Report(int id, int dif_dig, int dif_lei, int dif_rec, int dif_atv, int dif_int, Student student, Instructor instructor, DateTime dt_created, string title, string obs_atv, string obs_int)
        {
            Id = id;
            Dif_dig = dif_dig;
            Dif_lei = dif_lei;
            Dif_rec = dif_rec;
            Dif_atv = dif_atv;
            Dif_int = dif_int;
            this.Student = student;
            this.Instructor = instructor;
            Dt_created = dt_created;
            Title = title;
            Obs_atv = obs_atv;
            Obs_int = obs_int;
        }

        public virtual string[] GeneratePartialInsertQuery()
        {
            string[] partQuery = new string[2];
            //Headers
            partQuery[0] = "id, id_student, id_instructor, dt_created, title, dif_dig, dif_lei" +
                ", dif_rec, dif_atv, obs_atv, dif_int, obs_int";

            /* TODO: Protect from SQL Injection
                 (maybe start using ORM) */
            //Values
            partQuery[1] = "" + Id + ", " + Student.Id + ", " + Instructor.Id + ", '" + Dt_created.ToString("yyyy-MM-dd") + "', '" +
                Title + "', " + Dif_dig + ", " + Dif_lei + ", " + Dif_rec + ", " + Dif_atv + ", '" +
                Obs_atv + "', " + Dif_int + ", '" + Obs_int + "'";

            return partQuery;
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

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
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
