using System;
using System.Collections.Generic;
using MultiSoftApp.Database.Models;
using MultiSoftApp.Services.Utils;
using MySql.Data.MySqlClient;

namespace MultiSoftApp.Database.Dao
{
    public class OrdersDao : ModelDao<DbOrderDto>
    {
        protected override string Table => "orders";

        protected override Dictionary<string, Func<DbOrderDto, object>> Columns =>
            new Dictionary<string, Func<DbOrderDto, object>>
            {
                {"timestamp", user => user.Timestamp},
                {"total_price", user => user.TotalPrice},
                {"user_id", user => user.Customer.Id}
            };

        protected override DbOrderDto GetFromReader(MySqlDataReader reader)
        {
            var usersDao = new UsersDao();
            var userId = reader.GetInt32(3);
            var getUserResult = usersDao.Get(userId);
            if (getUserResult is Failed<DbUserDto>)
            {
                return null;
            }

            return new DbOrderDto(
                reader.GetInt32(0),
                reader.GetDateTime(1),
                reader.GetDouble(2),
                getUserResult.Value
            );
        }
    }
}