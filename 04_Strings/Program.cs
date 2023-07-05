// See https://aka.ms/new-console-template for more information

string firstName = "Sam";
string lastName = "Ruiz";

// Concatenation
string concatenatedString = firstName + " " + lastName;

// Composite formatting
string compositeString = string.Format("My name is {0} {1}.", firstName, lastName);

// String Interpolation
string interpolatedString = $"My name is still {firstName} {lastName}";


string cardName = "Black Lotus";
string storeName = "Game Time";

string interpolatedSentence = $"{firstName} {lastName} works at {storeName} and sells cards like {cardName}.";
Console.WriteLine(interpolatedSentence);

string compositeSentence = string.Format("{0} {1} works at {2} and sells cards like {3}.", firstName, lastName, storeName, cardName);
Console.WriteLine(compositeSentence);


