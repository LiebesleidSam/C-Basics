Console.Write("Enter a name: ");
string? name = Console.ReadLine();
switch(name)
{
    case "Marty":
        Console.WriteLine("He's the instructor!");
        break;
    case "David":
        Console.WriteLine("He's had some programming experience.");
        break;
    case "Sam":
    case "Willie":
    case "Nathan":
        Console.WriteLine("Other students in the class");
        break;
    default:
        Console.WriteLine("What are you doing here?");
        break;
}

Console.WriteLine("How are you doing today on a scale from 1-5?");
string? dailyMood = Console.ReadLine();
int dailyNum = int.Parse(dailyMood);

string response = dailyNum switch
{
    1 => "Oh dear, I hope tomorrow is better.",
    2 => "I'm sorry to hear that.",
    3 => "Could be better, could be worse.",
    4 => "That's pretty good!",
    5 => "Sound's like you're doing awesome!",
    _ => "I'm not sure what you meant by that."
};
Console.WriteLine(response);