using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Models
{
    class ReportsView
    {
        private int id;
        private string nomeAluno, nomeMonitor, titulo;
        private DateTime data;

        public ReportsView(int id, string nomeAluno, string nomeMonitor, string titulo, DateTime data)
        {
            Id = id;
            NomeAluno = nomeAluno;
            NomeMonitor = nomeMonitor;
            Titulo = titulo;
            Data = data;
        }

        public int Id { get => id; set => id = value; }
        public string NomeAluno { get => nomeAluno; set => nomeAluno = value; }
        public string NomeMonitor { get => nomeMonitor; set => nomeMonitor = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}
