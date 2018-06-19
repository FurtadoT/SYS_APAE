using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Models
{
    class StudentsView : PeopleView
    {
        string telefone;

        public StudentsView(int id, string nome, string cpf, string phone, string email)
                : base(id, nome, cpf, email)
        {
            Telefone = telefone;
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
