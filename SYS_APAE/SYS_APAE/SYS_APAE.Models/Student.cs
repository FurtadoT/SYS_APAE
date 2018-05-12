using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE
{
    class Student
    {
        int id;
        string name, cpf, rg, org_exp, nationality,
            father_name, mother_name, address, city,
            state, district, cep, phone, celphone, email;
        DateTime dt_exp, dt_nasc;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Org_exp { get => org_exp; set => org_exp = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string Father_name { get => father_name; set => father_name = value; }
        public string Mother_name { get => mother_name; set => mother_name = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string District { get => district; set => district = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Celphone { get => celphone; set => celphone = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Dt_exp { get => dt_exp; set => dt_exp = value; }
        public DateTime Dt_nasc { get => dt_nasc; set => dt_nasc = value; }
    }
}
