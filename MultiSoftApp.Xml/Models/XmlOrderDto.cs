using System;

namespace MultiSoftApp.Xml.Models
{
    public class XmlOrderDto
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public double TotalPrice { get; set; }
        public XmlUserDto Customer { get; set; }
    }
}