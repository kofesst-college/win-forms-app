using System;

namespace MultiSoftApp.Database.Models
{
    public class DbOrderDto
    {
        public readonly int Id;
        public readonly DateTime Timestamp;
        public readonly double TotalPrice;
        public readonly DbUserDto Customer;

        public DbOrderDto(int id, DateTime timestamp, double totalPrice, DbUserDto customer)
        {
            Id = id;
            Timestamp = timestamp;
            TotalPrice = totalPrice;
            Customer = customer;
        }
    }
}