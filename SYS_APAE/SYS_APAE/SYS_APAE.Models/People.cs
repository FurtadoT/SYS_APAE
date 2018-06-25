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
        private DateTime dt_created;

        public People(int id, string name, string cpf, string email, DateTime dt_created)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Email = email;
            Dt_created = dt_created;
        }

        public virtual Dictionary<string, string> GenerateDictFields()
        {
            Dictionary<string, string> fieldsQuery = new Dictionary<string, string>
            {
                { "id", Id.ToString() },
                { "name", Name },
                { "cpf", Cpf },
                { "email", Email },
                { "dt_created", Dt_created.ToString("yyyy-MM-dd") }
            };

            return fieldsQuery;
        }

        public string GetMaskedCPF()
        {
            return this.Cpf.Substring(0, 3) + "." + this.Cpf.Substring(3, 3) + "." +
                this.Cpf.Substring(6, 3) + "-" + this.Cpf.Substring(9, 2);
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
    }
}
