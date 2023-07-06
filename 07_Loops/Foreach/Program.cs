// Foreach Syntax
// foreach (type variableName in array) { body of code }

string instructor = "Marty";
string[] sd171 = new string[] {"David", "Nathan", "Willie", "Sam", instructor};

foreach (string name in sd171)
{
    if (name == "Marty")
    {
        Console.WriteLine(name + " is the instructor.");
    }
    else
    {
        Console.WriteLine(name + " is a student.");
    }    
}

int[] posNegNumbers = new int[] {-5, -3, -1, 0, 1, 3, 5};

foreach (int number in posNegNumbers)
{
    if (number < 0)
    {
        Console.WriteLine(number + " is negative.");
    }
    else if (number > 0)
    {
        Console.WriteLine(number + " is positive.");
    }
    else
    {
        Console.WriteLine(number + " is zero.");
    }
}