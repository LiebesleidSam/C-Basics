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