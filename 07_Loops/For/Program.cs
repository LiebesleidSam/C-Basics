// For Loop Syntax
// for (initializer; condition; iterator) {body of the loop}

int numberOfTimes = 20;

for (int i = 0; i < numberOfTimes; i++)
{
    //Console.WriteLine(i);
    if (i % 15 == 0)
    {
        continue;
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}