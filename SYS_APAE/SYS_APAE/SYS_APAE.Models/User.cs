using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Models
{
    class User
    {
        private bool isLogged;
        private int accessLevel;
        private string name;

        public User(int accessLevel, string name, bool isLogged = false)
        {
            IsLogged = isLogged;
            AccessLevel = accessLevel;
            Name = name;
        }

        public int AccessLevel
        {
            get
            {
                return accessLevel;
            }

            set
            {
                accessLevel = value;
            }
        }

        public bool IsLogged
        {
            get
            {
                return isLogged;
            }

            set
            {
                isLogged = value;
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
    }
}
