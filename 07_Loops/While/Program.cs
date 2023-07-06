// While (condition is true) { ... code ... }

int loopCount = 0;
bool isRunning = true;

while(loopCount < 100)
{
    Console.WriteLine(loopCount);
    loopCount += 3;
}

while(isRunning)
{
    Console.WriteLine(loopCount);
    loopCount += 5;
    if (loopCount > 120)
    {
        isRunning = false;
    }
}