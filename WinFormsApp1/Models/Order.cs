using System;

namespace WinFormsApp1.Models
{
    public class Order
    {
        public DateTime Timestamp { get; set; }
        public User Customer { get; set; }
        public double TotalPrice { get; set; }
        
        public override string ToString()
        {
            return $"Timestamp: {Timestamp}\n" +
                   $"Customer: {Customer}\n" +
                   $"Total price: {TotalPrice}$";
        }
    }
}