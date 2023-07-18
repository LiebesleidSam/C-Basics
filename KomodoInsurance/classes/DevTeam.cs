namespace Classes;

public class DevTeam
{
    public DevTeam(string teamName, int teamId)
    {
        TeamMembers = new List<Developer>();
        TeamName = teamName;
        TeamId = teamId;
    }
    public List<Developer> TeamMembers { get; private set; }
    public string TeamName { get; set; }
    public int TeamId { get; set; }
    public void AddDeveloperToTeam(Developer dev)
    {
        TeamMembers.Add(dev);
    }
    public void RemoveDeveloperFromTeam(Developer dev)
    {
        TeamMembers.Remove(dev);
    }
}