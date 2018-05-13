using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Models
{
    class StudentsView : PeopleView
    {
        public StudentsView(int id, string name, string cpf, string phone, string email)
                : base(id, name, cpf, phone, email)
        {}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
