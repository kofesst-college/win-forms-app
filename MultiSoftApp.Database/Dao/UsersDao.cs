using System;
using System.Collections.Generic;
using MultiSoftApp.Database.Models;
using MySql.Data.MySqlClient;

namespace MultiSoftApp.Database.Dao
{
    public sealed class UsersDao : ModelDao<DbUserDto>
    {
        protected override string Table => "users";

        protected override Dictionary<string, Func<DbUserDto, object>> Columns =>
            new Dictionary<string, Func<DbUserDto, object>>
            {
                {"first_name", user => user.FirstName},
                {"last_name", user => user.LastName},
                {"middle_name", user => user.MiddleName},
                {"passport_number", user => user.PassportNumber.ToString()},
                {"passport_series", user => user.PassportSeries.ToString()}
            };

        protected override DbUserDto GetFromReader(MySqlDataReader reader) => new DbUserDto(
            reader.GetInt32(0),
            reader.GetString(1),
            reader.GetString(2),
            reader.GetString(3),
            reader.GetString(4),
            reader.GetString(5)
        );
    }
}