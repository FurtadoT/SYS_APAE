using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Models
{
    abstract class People
    {
        private int id;
        private string name, cpf, email;

        public People(int id, string name, string cpf, string email)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Email = email;
        }

        public virtual Dictionary<string, string> GenerateDictFields()
        {
            Dictionary<string, string> fieldsQuery = new Dictionary<string, string>();

            fieldsQuery.Add("id", Id.ToString());
            fieldsQuery.Add("name", Name);
            fieldsQuery.Add("cpf", Cpf);
            fieldsQuery.Add("email", Email);

            return fieldsQuery;
        }

        public override string ToString()
        {
            // TODO: Complete string information
            return String.Format("Aluno {0}", Name);
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}
