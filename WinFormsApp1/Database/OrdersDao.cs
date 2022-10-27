using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WinFormsApp1.Models;
using WinFormsApp1.Utils;

namespace WinFormsApp1.Database
{
    public class OrdersDao : ModelDao<Order>
    {
        protected override string Table => "orders";

        protected override Dictionary<string, Func<Order, object>> Columns =>
            new Dictionary<string, Func<Order, object>>
            {
                {"timestamp", user => user.Timestamp},
                {"total_price", user => user.TotalPrice},
                {"user_id", user => user.Customer.Id}
            };

        protected override Order GetFromReader(MySqlDataReader reader)
        {
            var usersDao = new UsersDao();
            var userId = reader.GetInt32(3);
            var getUserResult = usersDao.Get(userId);
            if (getUserResult is Failed<User>)
            {
                return null;
            }

            return new Order
            {
                Id = reader.GetInt32(0),
                Timestamp = reader.GetDateTime(1),
                TotalPrice = reader.GetDouble(2),
                Customer = getUserResult.Value
            };
        }
    }
}