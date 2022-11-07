using MultiSoftApp.Database.Models;
using MultiSoftApp.Xml.Models;

namespace MultiSoftApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public readonly string FirstName;
        public readonly string LastName;
        public readonly string MiddleName;
        public readonly string PassportSeries;
        public readonly string PassportNumber;

        public User(int id, string firstName, string lastName, string middleName, string passportSeries,
            string passportNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
        }

        public DbUserDto ToDb() => new DbUserDto(
            Id,
            FirstName,
            LastName,
            MiddleName,
            PassportSeries,
            PassportNumber
        );

        public XmlUserDto ToXml() => new XmlUserDto {
            Id = Id,
            FirstName = FirstName,
            LastName = LastName,
            MiddleName = MiddleName,
            PassportSeries = PassportSeries,
            PassportNumber = PassportNumber
        };

        public static User FromDb(DbUserDto dbUser) => new User(
            dbUser.Id,
            dbUser.FirstName,
            dbUser.LastName,
            dbUser.MiddleName,
            dbUser.PassportSeries,
            dbUser.PassportNumber
        );

        public static User FromXml(XmlUserDto xmlUser) => new User(
            xmlUser.Id,
            xmlUser.FirstName,
            xmlUser.LastName,
            xmlUser.MiddleName,
            xmlUser.PassportSeries,
            xmlUser.PassportNumber
        );
    }
}