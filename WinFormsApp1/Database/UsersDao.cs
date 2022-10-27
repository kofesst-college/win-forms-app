using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WinFormsApp1.Models;

namespace WinFormsApp1.Database
{
    public sealed class UsersDao : ModelDao<User>
    {
        protected override string Table => "users";

        protected override Dictionary<string, Func<User, object>> Columns =>
            new Dictionary<string, Func<User, object>>
            {
                {"first_name", user => user.FirstName},
                {"last_name", user => user.LastName},
                {"middle_name", user => user.MiddleName},
                {"passport_number", user => user.Passport.Number.ToString()},
                {"passport_series", user => user.Passport.Series.ToString()}
            };

        protected override User GetFromReader(MySqlDataReader reader) => new User
        {
            Id = reader.GetInt32(0),
            FirstName = reader.GetString(1),
            LastName = reader.GetString(2),
            MiddleName = reader.GetString(3),
            Passport = new Passport
            {
                Number = int.Parse(reader.GetString(4)),
                Series = int.Parse(reader.GetString(5))
            }
        };
    }
}