using SYS_APAE.SYS_APAE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_APAE.SYS_APAE.Data
{
    static class LoginDTO
    {
        private static DBConnect dbConnector = new DBConnect();
        private static User User;

        private static bool verifyAdmin(string user, string password)
        {
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement("SELECT * FROM admin where login='" + user + "' and password='" + password + "'");
            if (dbResult.Count == 0)
            {
                return false;
            }

            User = new User(6, dbResult[0]["name"], true);
            return true;
        }
        private static bool verifyStudent(string user, string password)
        {
            List<Dictionary<string, string>> dbResult = dbConnector.DoQueryStatement("SELECT * FROM students where cpf='" + user + "' and password='" + password + "'");
            if (dbResult.Count == 0)
            {
                return false;
            }

            User = new User(1, dbResult[0]["name"], true);
            return true;
        }

        public static bool verifyLogin(string user, string password)
        {
            if (!verifyStudent(user, password) && !verifyAdmin(user, password)) {
                User = null;
                return false;
            }

            return true;
        }

        public static User getUser()
        {
            return User;
        }
    }
}
