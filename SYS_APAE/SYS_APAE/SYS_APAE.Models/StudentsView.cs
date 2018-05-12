﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Models
{
    class StudentsView
    {
        private int id;
        private string name, cpf, phone, email;

        public StudentsView()
        {

        }

        public StudentsView(int id, string name, string cpf, string phone, string email)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Phone = phone;
            Email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
    }
}