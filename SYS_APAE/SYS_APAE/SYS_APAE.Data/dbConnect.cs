using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;

namespace SYS_APAE
{
    class DBConnect : IDisposable
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

        private Dictionary<string, string> resolveData(MySqlDataReader dataReader)
        {
            Dictionary<string, string> newRow = new Dictionary<string, string>();

            for (int counter = 0; counter < dataReader.FieldCount; counter++)
                newRow.Add(dataReader.GetName(counter).ToString(), dataReader[counter].ToString());

            return newRow;
        }

        public List<Dictionary<string, string>> DoQueryStatement(MySqlCommand sqlCommand)
        {
            List<Dictionary<string, string>> returnData = new List<Dictionary<string, string>>();

            if (this.OpenConnection())
            {
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                    returnData.Add(resolveData(dataReader));

                this.CloseConnection();
            }

            return returnData;
        }

        public bool DoNonQueryStatement(MySqlCommand sqlCommand)
        {
            if (this.OpenConnection())
            {
                sqlCommand.ExecuteNonQuery();

                this.CloseConnection();
            }

            return true;
        }

        private List<string> CreateSelectFieldsArray(string[] fields)
        {
            List<string> stringReturn = new List<string>();

            foreach (string field in fields)
                stringReturn.Add(field + " LIKE @" + field);

            return stringReturn;
        }

        public MySqlCommand CreateSelectCommandWithParams(string TableName, Dictionary<string, string> whereFields)
        {
            string whereStatement = String.Empty;
            if (whereFields != null)
            {
                List<string> fields = CreateSelectFieldsArray(whereFields.Keys.ToArray());
                if (fields.Count > 0)
                    whereStatement = "WHERE " + string.Join(" AND ", fields);
            }

            MySqlCommand commandSql = new MySqlCommand(
                string.Format("select * from {0} {1}",
                TableName,
                whereStatement
            ), connection);

            if (whereFields != null)
                foreach (KeyValuePair<string, string> field in whereFields)
                {
                    commandSql.Parameters.Add(new MySqlParameter("@" + field.Key, field.Value));
                }

            return commandSql;
        }

        public MySqlCommand CreateInsertCommandWithParams(string TableName, Dictionary<string, string> fieldsQuery)
        {
            string[] fields = fieldsQuery.Keys.ToArray();

            MySqlCommand commandSql = new MySqlCommand(
                string.Format("INSERT INTO {0} ({1}) VALUES({2})",
                TableName,
                string.Join(",", fields),
                "@" + string.Join(",@", fields)
            ), connection);
            foreach (KeyValuePair<string, string> field in fieldsQuery)
            {
                commandSql.Parameters.Add(new MySqlParameter("@" + field.Key, field.Value));
            }

            return commandSql;
        }

        private List<string> CreateUpdateFieldsArray(string[] fields)
        {
            List<string> stringReturn = new List<string>();

            foreach (string field in fields)
                stringReturn.Add(field + " = @" + field);

            return stringReturn;
        }

        public MySqlCommand CreateUpdateCommandWithParams(string TableName, Dictionary<string, string> fieldsQuery)
        {
            string idToUpdate = fieldsQuery["id"];
            fieldsQuery.Remove("id");
            List<string> fields = CreateUpdateFieldsArray(fieldsQuery.Keys.ToArray());

            MySqlCommand commandSql = new MySqlCommand(
                string.Format("UPDATE {0} SET {1} WHERE id={2}",
                TableName,
                string.Join(",", fields),
                idToUpdate
            ), connection);
            foreach (KeyValuePair<string, string> field in fieldsQuery)
            {
                commandSql.Parameters.Add(new MySqlParameter("@" + field.Key, field.Value));
            }

            return commandSql;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(Boolean isSafeToFreeManagedObjects)
        {
            if (isSafeToFreeManagedObjects)
                if (this.connection != null)
                {
                    this.connection.Dispose();
                    this.connection = null;
                }
        }
    }
}
