using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Models
{
    class Instructor : People
    {
        private string prontuario;

        public Instructor(int id, string name, string cpf, string rg,
                string org_exp, DateTime dt_exp, DateTime dt_nasc,
                string nationality, string father_name, string mother_name,
                string address, string city, string state, string district,
                string cep, string phone, string celphone, string email, string prontuario)
            : base(id, name, cpf, rg, org_exp, dt_exp, dt_nasc, nationality,
                father_name, mother_name, address, city, state, district,
                cep, phone, celphone, email)
        {
            Prontuario = prontuario;
        }

        public override Dictionary<string, string> GenerateDictFields()
        {
            Dictionary<string, string> fieldsQuery = base.GenerateDictFields();

            fieldsQuery.Add("prontuario", Prontuario);

            return fieldsQuery;
        }

        public string Prontuario
        {
            get
            {
                return prontuario;
            }

            set
            {
                prontuario = value;
            }
        }

        public override String ToString()
        {
            return base.ToString();
        }
    }
}
