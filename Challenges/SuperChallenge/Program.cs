string longWord = "Supercalifragilisticexpialidocious";

foreach (char letter in longWord)
{
    if (letter == 'i')
    {
        Console.WriteLine(letter);
    }
    else
    {
        Console.WriteLine("Not an i");
    }
}

Console.WriteLine(longWord.Length);