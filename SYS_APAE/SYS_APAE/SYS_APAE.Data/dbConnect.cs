using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS_APAE
{
    static class dbConnect
    {
        private static String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\SYS_APAE.Data\\DbSysAPAE.mdf;Integrated Security=True";

        private static SqlDataAdapter ExecuteQuery(String selectCommand)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            return dataAdapter;
        }

        public static DataTable GetDataTable(String selectCommand)
        {
            try
            {
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                ExecuteQuery(selectCommand).Fill(table);
                return table;
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed while trying to connect with database");
            }

            return null;
        }
    }
}
