using Classes;

public class DevTeamRepository
{
    private readonly List<DevTeam> _devTeamDirectory = new List<DevTeam>();

    public bool AddDevTeamToDirectory(DevTeam team)
    {
        int startingCount = _devTeamDirectory.Count();

        if (team != null)
        {
            _devTeamDirectory.Add(team);
        }

        bool countIncreased = _devTeamDirectory.Count() > startingCount;
        return countIncreased;
    }
    public List<DevTeam> GetDirectory()
    {
        return new List<DevTeam>(_devTeamDirectory);
    }
    public DevTeam? GetDevTeamById(int id)
    {
        foreach (DevTeam team in _devTeamDirectory)
        {
            if (team.TeamId == id)
            {
                return team;
            }
        }
        return null;
    }
    public bool UpdateDevTeam(int id, DevTeam newTeam)
    {
        DevTeam? oldTeam = GetDevTeamById(id);
        if (oldTeam == null)
        {
            return false;
        }

        int index = _devTeamDirectory.IndexOf(oldTeam);
        _devTeamDirectory[index] = newTeam;
        return true;
    }
    public bool DeleteDevTeam(int id)
    {
        DevTeam? targetTeam = GetDevTeamById(id);
        if (targetTeam == null)
        {
            return false;
        }

        bool deleteResult = _devTeamDirectory.Remove(targetTeam);
        return deleteResult;
    }
}