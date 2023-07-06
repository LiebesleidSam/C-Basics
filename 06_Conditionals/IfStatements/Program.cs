bool isRaining = true;
bool isGoingOutside = true;

/*
If Statement Syntax
if (true/false value or expressions)
{
    Curly braces on a line

    Body of code to be run if condition is true
}
*/

if (isRaining)
{
    Console.WriteLine("It is raining.");
}

if (isRaining && isGoingOutside) 
{
    Console.WriteLine("Bring an umbrella!");
}

Console.WriteLine("How are you doing today on a scale from 1-5?");
string? dailyMood = Console.ReadLine();

if (dailyMood == "5")
{
    Console.WriteLine("Sounds like you're doing awesome!");
}
else if (dailyMood == "4")
{
    Console.WriteLine("That's pretty good!");
}
else if (dailyMood == "3")
{
    Console.WriteLine("Could be better, could be worse.");
}
else if (dailyMood == "2")
{
    Console.WriteLine("I'm sorry to hear that.");
}
else if (dailyMood == "1")
{
    Console.WriteLine("Oh dear, I hope tomorrow is better.");
}
else
{
    Console.WriteLine("I'm not sure what you meant by that.");
}