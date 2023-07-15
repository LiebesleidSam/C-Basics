using Classes;

DeveloperRepository devRepo = new DeveloperRepository();
DevTeamRepository devTeamRepo = new DevTeamRepository();
int devId = 0;
int teamId = 0;

void DisplayMenu()
{
    Console.WriteLine("Option 1) Create a new Developer");
    Console.WriteLine("Option 2) Create a new Team");
    Console.WriteLine("Option 3) Delete a Developer");
    Console.WriteLine("Option 4) Delete a Team");
    Console.WriteLine("Option 5) Add Developer to a Team");
    Console.WriteLine("Option 6) Remove a Developer from a Team");
    string option = Console.ReadLine();
    Console.Clear();
    switch (option)
    {
        case "1":
            CreateDeveloper();
            break;
        case "2":
            CreateDevTeam();
            break;
        case "3":
            DeleteDeveloper();
            break;
        case "4":
            DeleteDevTeam();
            break;
        case "5":
            AddDevToTeam();
            break;
        case "6":
            RemoveDevFromTeam();
            break;
        default:
            break;
    }
}

void CreateDeveloper()
{
    Console.WriteLine("What is the Developer's Name?");
    string name = Console.ReadLine();

    Console.WriteLine("The Developer has access to Pluralsight?");
    bool access = bool.Parse(Console.ReadLine());

    devId += 1;

    Developer dev = new Developer(name, devId, access);
    devRepo.AddDeveloperToDirectory(dev);

    Console.Clear();
    DisplayMenu();
}

void CreateDevTeam()
{
    Console.WriteLine("What is the Team's Name?");
    string name = Console.ReadLine();

    teamId += 1;

    DevTeam team = new DevTeam(name, teamId);
    devTeamRepo.AddDevTeamToDirectory(team);

    Console.Clear();
    DisplayMenu();
}

void DeleteDeveloper()
{
    List<Developer> devDirectory = devRepo.GetDirectory();
    foreach (Developer dev in devDirectory)
    {
        Console.WriteLine($"Name: {dev.Name}  Id: {dev.Id}");
    }

    Console.WriteLine("Please type the Id of the Developer you would like to delete.");
    int targetId = int.Parse(Console.ReadLine());
    devRepo.DeleteDeveloper(targetId);
    
    Console.Clear();
    DisplayMenu();
}

void DeleteDevTeam()
{
    List<DevTeam> devTeamDirectory = devTeamRepo.GetDirectory();
    foreach (DevTeam team in devTeamDirectory)
    {
        Console.WriteLine($"Name: {team.TeamName}  Id: {team.TeamId}");
    }

    Console.WriteLine("Please type the Id of the DevTeam you would like to delete.");
    int targetId = int.Parse(Console.ReadLine());
    devTeamRepo.DeleteDevTeam(targetId);

    Console.Clear();
    DisplayMenu();
}

void AddDevToTeam()
{
    List<DevTeam> devTeamDirectory = devTeamRepo.GetDirectory();
    foreach (DevTeam team in devTeamDirectory)
    {
        Console.WriteLine($"Name: {team.TeamName}  Id: {team.TeamId}");
    }

    Console.WriteLine("Please type the Id of the DevTeam you would like to add to.");
    int targetTeamId = int.Parse(Console.ReadLine());
    DevTeam targetTeam = devTeamRepo.GetDevTeamById(targetTeamId);

    List<Developer> devDirectory = devRepo.GetDirectory();
    foreach (Developer dev in devDirectory)
    {
        Console.WriteLine($"Name: {dev.Name}  Id: {dev.Id}");
    }

    Console.WriteLine("Please type the Id of the Developer you would like to add to the team.");
    int targetDevId = int.Parse(Console.ReadLine());
    Developer targetDev = devRepo.GetDeveloperById(targetDevId);

    targetTeam.AddDeveloperToTeam(targetDev);

    Console.Clear();
    DisplayMenu();
}

void RemoveDevFromTeam()
{
    List<DevTeam> devTeamDirectory = devTeamRepo.GetDirectory();
    foreach (DevTeam team in devTeamDirectory)
    {
        Console.WriteLine($"Name: {team.TeamName}  Id: {team.TeamId}");
    }

    Console.WriteLine("Please type the Id of the DevTeam you would like to remove from.");
    int targetTeamId = int.Parse(Console.ReadLine());
    DevTeam targetTeam = devTeamRepo.GetDevTeamById(targetTeamId);

    List<Developer> devDirectory = targetTeam.TeamMembers;
    foreach (Developer dev in devDirectory)
    {
        Console.WriteLine($"Name: {dev.Name}  Id: {dev.Id}");
    }

    Console.WriteLine("Please type the Id of the Developer you would like to remove from the team.");
    int targetDevId = int.Parse(Console.ReadLine());
    Developer targetDev = devRepo.GetDeveloperById(targetDevId);

    targetTeam.RemoveDeveloperFromTeam(targetDev);

    Console.Clear();
    DisplayMenu();
}

DisplayMenu();