using System;
using System.Data;
using System.Data.SqlClient;

namespace UATP_Practice.PATTERNS
{
    // Command interface
    public interface ISQLStoredProcDatabaseCommand
    {
        void Execute();
    }

    // Concrete Command class
    public class StoredProcedureCommand : ISQLStoredProcDatabaseCommand
    {
        private readonly string _storedProcedureName;
        private readonly string _connectionString;
        private readonly SqlParameter[] _parameters;

        public StoredProcedureCommand(string connectionString, string storedProcedureName, SqlParameter[] parameters)
        {
            _storedProcedureName = storedProcedureName;
            _connectionString = connectionString;
            _parameters = parameters;
        }

        public void Execute()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(_storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                if (_parameters != null)
                {
                    command.Parameters.AddRange(_parameters);
                }

                command.ExecuteNonQuery();
                Console.WriteLine("Stored procedure command executed successfully.");
            }
        }
    }
}
