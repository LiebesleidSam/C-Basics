// NOT Operator
// AND Operator
// OR Operator
// XOR Operator

// Use the bool keyword
bool csharpIsCool = false;
csharpIsCool = true;

// Boolean Logical Operators
// NOT Operator
bool isTrue = !false;
bool isFalse = !true;

// AND Operator
bool trueAndExample = true && true;
bool falseAndExample = true && false;

// OR Operator
bool trueOrExample = true || false;
bool falseOrExample = false || false;

// XOR Operator
bool trueExclusiveOr = true ^ false;
bool falseExclusiveOr = true ^ true;

bool isRaining = true;
bool isGoingOutside = true;

if (isRaining && isGoingOutside) {
    Console.WriteLine("Bring an Umbrella!");
}