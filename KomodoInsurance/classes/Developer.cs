namespace Classes;

public class Developer
{
    public Developer(string name, int id, bool pluralsightAccess)
    {
        Name = name;
        Id = id;
        PluralsightAccess = pluralsightAccess;
    }
    public string Name { get; set; }
    public int Id { get; set; }
    public bool PluralsightAccess { get; set; }
}