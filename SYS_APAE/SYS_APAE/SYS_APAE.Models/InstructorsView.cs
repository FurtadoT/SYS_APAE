using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Models
{
    class InstructorsView : PeopleView
    {
        private string prontuario;

        public InstructorsView(int id, string name, string cpf, string phone, string email, string prontuario)
                : base(id, name, cpf, phone, email)
        {
            Prontuario = prontuario;
        }

        public string Prontuario { get => prontuario; set => prontuario = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
