using Classes;

DeveloperRepository devRepo = new DeveloperRepository();
DevTeamRepository devTeamRepo = new DevTeamRepository();
int devId = 0;
int teamId = 0;
bool keepRunning = true;

void DisplayMenu()
{
    Console.WriteLine("Option 1) Display Developers");
    Console.WriteLine("Option 2) Display Teams");
    Console.WriteLine("Option 3) Create a new Developer");
    Console.WriteLine("Option 4) Create a new Team");
    Console.WriteLine("Option 5) Delete a Developer");
    Console.WriteLine("Option 6) Delete a Team");
    Console.WriteLine("Option 7) Add Developer to a Team");
    Console.WriteLine("Option 8) Remove a Developer from a Team");
    string option = Console.ReadLine();
    Console.Clear();
    switch (option)
    {   
        case "1":
            ReadDevDirectory(devRepo);
            PressAnyKeyToContinue();
            break;
        case "2":
            ReadTeamDirectory(devTeamRepo);
            PressAnyKeyToContinue();
            break;
        case "3":
            CreateDeveloper();
            break;
        case "4":
            CreateDevTeam();
            break;
        case "5":
            DeleteDeveloper();
            break;
        case "6":
            DeleteDevTeam();
            break;
        case "7":
            AddDevToTeam();
            break;
        case "8":
            RemoveDevFromTeam();
            break;
        default:
            keepRunning = false;
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
}

void CreateDevTeam()
{
    Console.WriteLine("What is the Team's Name?");
    string name = Console.ReadLine();

    teamId += 1;

    DevTeam team = new DevTeam(name, teamId);
    devTeamRepo.AddDevTeamToDirectory(team);
}

void DeleteDeveloper()
{
    ReadDevDirectory(devRepo);

    Console.WriteLine("Please type the Id of the Developer you would like to delete.");
    int targetId = int.Parse(Console.ReadLine());
    devRepo.DeleteDeveloper(targetId);
}

void DeleteDevTeam()
{
    ReadTeamDirectory(devTeamRepo);

    Console.WriteLine("Please type the Id of the DevTeam you would like to delete.");
    int targetId = int.Parse(Console.ReadLine());
    devTeamRepo.DeleteDevTeam(targetId);
}

void AddDevToTeam()
{
    ReadTeamDirectory(devTeamRepo);

    Console.WriteLine("Please type the Id of the DevTeam you would like to add to.");
    int targetTeamId = int.Parse(Console.ReadLine());
    DevTeam targetTeam = devTeamRepo.GetDevTeamById(targetTeamId);

    ReadDevDirectory(devRepo);

    Console.WriteLine("Please type the Id of the Developer you would like to add to the team.");
    int targetDevId = int.Parse(Console.ReadLine());
    Developer targetDev = devRepo.GetDeveloperById(targetDevId);

    targetTeam.AddDeveloperToTeam(targetDev);
}

void RemoveDevFromTeam()
{
    ReadTeamDirectory(devTeamRepo);

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
}

static void ReadTeamDirectory(DevTeamRepository devTeamRepo)
{
    List<DevTeam> devTeamDirectory = devTeamRepo.GetDirectory();
    foreach (DevTeam team in devTeamDirectory)
    {
        Console.WriteLine($"Name: {team.TeamName}  Id: {team.TeamId}");
    }
}

static void ReadDevDirectory(DeveloperRepository devRepo)
{
    List<Developer> devDirectory = devRepo.GetDirectory();
    foreach (Developer dev in devDirectory)
    {
        Console.WriteLine($"Name: {dev.Name}  Id: {dev.Id}");
    }
}

void PressAnyKeyToContinue()
{
    Console.WriteLine("Press any key to continue.");
    Console.ReadKey();
}

while (keepRunning)
{   
    Console.Clear();
    DisplayMenu();
}