using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem2.Helpers
{
   

    public class SqlHelper
    {
        private readonly string _connectionString= "Server=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DB.mdf;Integrated Security=True";

        public SqlHelper(string connectionString)
        {
            if(connectionString!="")
                _connectionString = connectionString;
        }

        public int ExecuteNonQuery(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;
                    command.Parameters.AddRange(parameters);

                    connection.Open();

                    return command.ExecuteNonQuery();
                }
            }
        }

        public object ExecuteScalar(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;
                    command.Parameters.AddRange(parameters);

                    connection.Open();

                    return command.ExecuteScalar();
                }
            }
        }

        public SqlDataReader ExecuteReader(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.CommandType = commandType;
                command.Parameters.AddRange(parameters);

                connection.Open();

                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        public DataTable ExecuteDataTable(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;
                    command.Parameters.AddRange(parameters);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }
    }
}
