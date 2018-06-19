using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Models
{
    class InstructorsView : PeopleView
    {
        private string prontuario, tipo_monitor;

        public InstructorsView(int id, string name, string cpf, string email, string prontuario, string tipo_monitor)
                : base(id, name, cpf, email)
        {
            Prontuario = prontuario;
            Tipo_monitor = tipo_monitor;
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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
