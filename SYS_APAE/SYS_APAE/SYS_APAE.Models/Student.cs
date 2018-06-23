using SYS_APAE.SYS_APAE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE
{
    class Student : People
    {
        private string rg, org_exp, nationality,
            father_name, mother_name, address, city,
            state, district, cep, phone, celphone;
        private DateTime dt_exp, dt_nasc;

        public Student(int id, string name, string cpf, string rg,
                string org_exp, DateTime dt_exp, DateTime dt_nasc,
                string nationality, string father_name, string mother_name,
                string address, string city, string state, string district,
                string cep, string phone, string celphone, string email)
            : base(id, name, cpf, email)
        {
            Rg = rg;
            Org_exp = org_exp;
            Nationality = nationality;
            Father_name = father_name;
            Mother_name = mother_name;
            Address = address;
            City = city;
            State = state;
            District = district;
            Cep = cep;
            Phone = phone;
            Celphone = celphone;
            Dt_exp = dt_exp;
            Dt_nasc = dt_nasc;
        }

        public override Dictionary<string, string> GenerateDictFields()
        {
            Dictionary<string, string> fieldsQuery = base.GenerateDictFields();

            fieldsQuery.Add("rg", Rg);
            fieldsQuery.Add("org_exp", Org_exp);
            fieldsQuery.Add("nationality", Nationality);
            fieldsQuery.Add("father_name", Father_name);
            fieldsQuery.Add("mother_name", Mother_name);
            fieldsQuery.Add("address", Address);
            fieldsQuery.Add("city", City);
            fieldsQuery.Add("state", State);
            fieldsQuery.Add("district", District);
            fieldsQuery.Add("cep", Cep);
            fieldsQuery.Add("phone", Phone);
            fieldsQuery.Add("celphone", Celphone);
            fieldsQuery.Add("dt_exp", Dt_exp.ToString("yyyy-MM-dd"));
            fieldsQuery.Add("dt_nasc", Dt_nasc.ToString("yyyy-MM-dd"));

            return fieldsQuery;
        }

        public Dictionary<string, string> GetFieldsToDisplay()
        {
            Dictionary<string, string> displayFields = new Dictionary<string, string>
            {
                { "Id", Id.ToString() },
                { "Nome", Name },
                { "CPF", Cpf },
                { "E-mail", Email },
                { "Data de nascimento", Dt_nasc.ToString("yyyy-MM-dd") }
            };

            return displayFields;
        }

        public override String ToString()
        {
            return base.ToString();
        }

        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public string Org_exp
        {
            get
            {
                return org_exp;
            }

            set
            {
                org_exp = value;
            }
        }

        public string Nationality
        {
            get
            {
                return nationality;
            }

            set
            {
                nationality = value;
            }
        }

        public string Father_name
        {
            get
            {
                return father_name;
            }

            set
            {
                father_name = value;
            }
        }

        public string Mother_name
        {
            get
            {
                return mother_name;
            }

            set
            {
                mother_name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public string District
        {
            get
            {
                return district;
            }

            set
            {
                district = value;
            }
        }

        public string Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Celphone
        {
            get
            {
                return celphone;
            }

            set
            {
                celphone = value;
            }
        }

        public DateTime Dt_exp
        {
            get
            {
                return dt_exp;
            }

            set
            {
                dt_exp = value;
            }
        }

        public DateTime Dt_nasc
        {
            get
            {
                return dt_nasc;
            }

            set
            {
                dt_nasc = value;
            }
        }
    }
}
