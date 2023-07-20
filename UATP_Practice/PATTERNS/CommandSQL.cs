using System;
using System.Data;
using System.Data.SqlClient;

namespace UATP_Practice.PATTERNS
{
    // Command interface
    public interface ISQLDatabaseCommand
    {
        void Execute();
    }

    // Concrete Command class
    public class SqlCommandWrapper : ISQLDatabaseCommand
    {
        private readonly string _query;
        private readonly string _connectionString;
        private readonly SqlParameter[] _parameters;

        public SqlCommandWrapper(string connectionString,string query, SqlParameter[] parameters)
        {
            _query = query;
            _connectionString = connectionString;
            _parameters = parameters;
        }

        public void Execute()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(_query, connection);

                if (_parameters != null)
                {
                    command.Parameters.AddRange(_parameters);
                }

                command.ExecuteNonQuery();
                Console.WriteLine("SQL command executed successfully.");
            }
        }
    }
}
