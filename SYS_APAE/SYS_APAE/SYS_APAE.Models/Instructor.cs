using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Models
{
    class Instructor : People
    {
        private string prontuario, tipo_monitor, password;
        private int carga_horaria;

        public Instructor(int id, string name, string cpf, string password, string email, string prontuario, string tipo_monitor, int carga_horaria)
            : base(id, name, cpf, email)
        {
            Password = password;
            Prontuario = prontuario;
            Tipo_monitor = tipo_monitor;
            Carga_horaria = carga_horaria;
        }

        public override Dictionary<string, string> GenerateDictFields()
        {
            Dictionary<string, string> fieldsQuery = base.GenerateDictFields();

            fieldsQuery.Add("password", Password);
            fieldsQuery.Add("prontuario", Prontuario);
            fieldsQuery.Add("tipo_monitor", Tipo_monitor);
            fieldsQuery.Add("carga_horaria", Carga_horaria.ToString());

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

        public string Tipo_monitor
        {
            get
            {
                return tipo_monitor;
            }

            set
            {
                tipo_monitor = value;
            }
        }

        public int Carga_horaria
        {
            get
            {
                return carga_horaria;
            }

            set
            {
                carga_horaria = value;
            }
        }

        public string Password { get => password; set => password = value; }

        public override String ToString()
        {
            return base.ToString();
        }
    }
}
