using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS_APAE
{
    class DBConnect
    {
        private readonly String connectionString = "Server=localhost; database=SYS_APAE; UID=root; password=root";
        private MySqlConnection connection;

        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<Dictionary<string, string>> ExecuteSelect(string sqlStatement)
        {
            List<Dictionary<string, string>> returnValue = new List<Dictionary<string, string>>();

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(sqlStatement, connection);
                MySqlDataReader dataReader = command.ExecuteReader();

                List<string> readerColumns = new List<string>();
                for (int index = 0; index < dataReader.FieldCount; index++)
                    readerColumns.Add(dataReader.GetName(index));

                while (dataReader.Read())
                {
                    Dictionary<string, string> newRow = new Dictionary<string, string>();
                    for (int counter = 0; counter < dataReader.FieldCount; counter++)
                    {
                        newRow.Add(readerColumns[counter].ToString(), dataReader[counter].ToString());
                    }

                    returnValue.Add(newRow);
                }

                this.CloseConnection();
            }

            return returnValue;
        }
    }
}
