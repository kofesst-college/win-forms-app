using System;
using MultiSoftApp.Database.Models;
using MultiSoftApp.Xml.Models;

namespace MultiSoftApp.Models
{
    public class Order
    {
        public readonly int Id;
        public readonly DateTime Timestamp;
        public readonly double TotalPrice;
        public readonly User Customer;

        public Order(int id, DateTime timestamp, double totalPrice, User customer)
        {
            Id = id;
            Timestamp = timestamp;
            TotalPrice = totalPrice;
            Customer = customer;
        }

        public DbOrderDto ToDb() => new DbOrderDto(
            Id,
            Timestamp,
            TotalPrice,
            Customer.ToDb()
        );

        public XmlOrderDto ToXml() => new XmlOrderDto {
            Id = Id,
            Timestamp = Timestamp,
            TotalPrice = TotalPrice,
            Customer = Customer.ToXml()
        };

        public static Order FromDb(DbOrderDto dbOrder) => new Order(
            dbOrder.Id,
            dbOrder.Timestamp,
            dbOrder.TotalPrice,
            User.FromDb(dbOrder.Customer)
        );

        public static Order FromXml(XmlOrderDto xmlOrder) => new Order(
            xmlOrder.Id,
            xmlOrder.Timestamp,
            xmlOrder.TotalPrice,
            User.FromXml(xmlOrder.Customer)
        );
    }
}