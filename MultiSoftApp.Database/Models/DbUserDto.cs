namespace MultiSoftApp.Database.Models
{
    public class DbUserDto
    {
        public readonly int Id;
        public readonly string FirstName;
        public readonly string LastName;
        public readonly string MiddleName;
        public readonly string PassportSeries;
        public readonly string PassportNumber;

        public DbUserDto(int id, string firstName, string lastName, string middleName, string passportSeries,
            string passportNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
        }
    }
}