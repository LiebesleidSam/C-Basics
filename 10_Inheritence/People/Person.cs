namespace People;

public class Person
{
    private string _firstName;
    private string _lastName;

    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public string Name
    {
        get
        {
            string fullName = $"{_firstName} {_lastName}";
            return (!string.IsNullOrWhiteSpace(fullName) ? fullName : "Unnamed");
        }
    }

    public void SetFirstName(string name)
    {
        _firstName = name;
    }
    public void SetLastName(string name)
    {
        _lastName = name;
    }
}