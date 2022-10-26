namespace WinFormsApp1.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Passport Passport { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {MiddleName}";
        }
    }
}