// using System.IO;
using Classes;

StreamReader sr = new StreamReader("./DrofsnarGame/game-sequence.txt");

var line = sr.ReadLine();
string[] words = line.Split(",");

Drofsnar player = new Drofsnar(5000, 3);

foreach (string word in words)
{
    player.EncounterObject(word);
    if (player.Lives == 0)
    {
        break;
    }
}

Console.WriteLine($"Total Points: {player.Points}");
Console.WriteLine($"Remaining Lives: {player.Lives}");