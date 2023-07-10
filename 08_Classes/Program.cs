using Classes;

User sam = new User("Sam", "Ruiz", 1, "08/23/1999");

Console.WriteLine(sam.GetAge());
Console.WriteLine(sam.GetFullName());

namespace Classes
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName {get; set; }
        public int ID {get; }
        public string BirthDate {get; set; }

        public User(string firstName, string lastName, int ID, string brithDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ID = ID;
            this.BirthDate = brithDate;
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public int GetAge()
        {
            string[] date = BirthDate.Split("/");
            int birthYear = int.Parse(date[date.Length - 1]);
            return 2023 - birthYear;
        }
    }

}