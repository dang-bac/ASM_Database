using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAsmt2
{
    internal class DatabaseConnection
    {
        private static string _connectionString = "Data Source=ADMIN\\SQLEXPRESS01;Initial Catalog=DIAMOND;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(_connectionString);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Eror while connecting to the database",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            return connection;

        }
    }
}
