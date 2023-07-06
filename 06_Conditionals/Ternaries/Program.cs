// Ternaries syntax
// boolean expression ? expression if true : expression if false;

Console.WriteLine("Enter your age: ");
string? response = Console.ReadLine();
int age = int.Parse(response);

string output = age >= 18 ? "You can vote!" : "You're too young to vote.";
