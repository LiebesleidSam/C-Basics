// Bronze
for (int i = 500; i <= 525; i++)
{
    Console.WriteLine(i);
}

// Silver
for (int i = 0; i <= 100; i += 5)
{
    Console.WriteLine(i);
}

// Gold
for (int i = 1; i <=100; i++)
{
    if (i % 4 == 0)
    {
        continue;
    }
    else if (i % 15 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 7 == 0)
    {
        continue;
    }
    else
    {
        Console.WriteLine(i);
    }
}