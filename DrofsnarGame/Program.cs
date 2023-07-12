using System.IO;
using Classes;

StreamReader sr = new StreamReader("./DrofsnarGame/game-sequence.txt");

var line = sr.ReadLine();
string[] words = line.Split(",");

Drofsnar player = new Drofsnar(5000, 3);