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
        public Student(int id, string name, string cpf, string rg,
                string org_exp, DateTime dt_exp, DateTime dt_nasc,
                string nationality, string father_name, string mother_name,
                string address, string city, string state, string district,
                string cep, string phone, string celphone, string email)
            : base(id, name, cpf, rg, org_exp, dt_exp, dt_nasc, nationality,
                father_name, mother_name, address, city, state, district,
                cep, phone, celphone, email)
        {}

        public override String ToString()
        {
            return base.ToString();
        }
    }
}
