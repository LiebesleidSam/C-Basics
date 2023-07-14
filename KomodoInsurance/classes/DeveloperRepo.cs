using Classes;

public class DeveloperRepository
{
    private readonly List<Developer> _developerDirectory = new List<Developer>();

    public bool AddDeveloperToDirectory(Developer developer)
    {
        int startingCount = _developerDirectory.Count();

        if (developer != null)
        {
            _developerDirectory.Add(developer);
        }

        bool countIncreased = _developerDirectory.Count() > startingCount;
        return countIncreased;
    }
    public List<Developer> GetDirectory()
    {
        return new List<Developer>(_developerDirectory);
    }
    public Developer? GetDeveloperById(int id)
    {
        foreach (Developer developer in _developerDirectory)
        {
            if (developer.Id == id)
            {
                return developer;
            }
        }
        return null;
    }
    public bool UpdateDeveloper(int id, Developer newDeveloper)
    {
        Developer? oldDeveloper = GetDeveloperById(id);
        if (oldDeveloper == null)
        {
            return false;
        }

        int index = _developerDirectory.IndexOf(oldDeveloper);
        _developerDirectory[index] = newDeveloper;
        return true;
    }
    public bool DeleteDeveloper(int id)
    {
        Developer? targetDeveloper = GetDeveloperById(id);
        if (targetDeveloper == null)
        {
            return false;
        }

        bool deleteResult = _developerDirectory.Remove(targetDeveloper);
        return deleteResult;
    }
}