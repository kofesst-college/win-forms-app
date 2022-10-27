using System;
using MultiSoftApp.Services.Utils;
using MySql.Data.MySqlClient;

namespace MultiSoftApp.Database.Services
{
    public static class MySqlService
    {
        private static string ConnectionString =>
            "server=localhost;port=3306;uid=root;database=clients_base";

        public static OperationResult<int> ExecNonQuery(string statement)
        {
            try
            {
                var result = ExecuteMySql(connection =>
                {
                    var command = new MySqlCommand(statement, connection);
                    command.ExecuteNonQuery();
                    return (int) command.LastInsertedId;
                });
                return new Success<int>(result);
            }
            catch (Exception exception)
            {
                return new Failed<int>(exception);
            }
        }

        public static OperationResult<T> ExecQuery<T>(string statement, Func<MySqlDataReader, T> callback)
        {
            try
            {
                var result = ExecuteMySql(connection =>
                {
                    var command = new MySqlCommand(statement, connection);
                    using (var reader = command.ExecuteReader())
                    {
                        return callback(reader);
                    }
                });
                if (result == null)
                    throw new NullReferenceException("Object not found");
                return new Success<T>(result);
            }
            catch (Exception exception)
            {
                return new Failed<T>(exception);
            }
        }

        private static T ExecuteMySql<T>(Func<MySqlConnection, T> block)
        {
            using (var connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                return block(connection);
            }
        }
    }
}