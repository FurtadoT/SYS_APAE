﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

        private MySqlDataReader ExecuteStatement(string sqlStatement)
        {
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            return command.ExecuteReader();
        }

        private void ExecuteNonQueryStatement(string sqlStatement)
        {
            MySqlCommand command = new MySqlCommand(sqlStatement, connection);
            command.ExecuteNonQuery();
        }

        private Dictionary<string, string> resolveData(MySqlDataReader dataReader)
        {
            Dictionary<string, string> newRow = new Dictionary<string, string>();

            for (int counter = 0; counter < dataReader.FieldCount; counter++)
                newRow.Add(dataReader.GetName(counter).ToString(), dataReader[counter].ToString());

            return newRow;
        }

        public List<Dictionary<string, string>> DoQueryStatement(string sqlStatement)
        {
            List<Dictionary<string, string>> returnData = new List<Dictionary<string, string>>();

            if (this.OpenConnection())
            {
                MySqlDataReader dataReader = ExecuteStatement(sqlStatement);

                while (dataReader.Read())
                    returnData.Add(resolveData(dataReader));

                this.CloseConnection();
            }

            return returnData;
        }

        public bool DoNonQueryStatement(string sqlStatement)
        {
            if (this.OpenConnection())
            {
                ExecuteNonQueryStatement(sqlStatement);

                this.CloseConnection();
            }

            return true;
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
