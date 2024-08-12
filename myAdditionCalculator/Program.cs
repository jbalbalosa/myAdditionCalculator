// See https://aka.ms/new-console-template for more information
//Prints out whatever is inside the ()
//Console.WriteLine("Hello, World!");
//Console.Write("Input a string:");

////takes the user input and stores it
//string userInput = Console.ReadLine();
//Console.WriteLine("You entered: " + userInput);

//string petsName;

//petsName = "Boomer";
//Console.WriteLine($"Pet's Name: {petsName}");
//Console.ReadKey();

using System.Globalization;

double myNumber1 = 0;
double myNumber2 = 0;
Console.Write("Enter a number1: ");

string userInput= Console.ReadLine();
myNumber1 = double.Parse(userInput, CultureInfo.InvariantCulture);

Console.Write("Enter a number2: ");
userInput = Console.ReadLine();
myNumber2 = double.Parse(userInput, CultureInfo.InvariantCulture);

double Sum = Math.Round( myNumber1 + myNumber2, 2);

// string concatination
Console.WriteLine("The Sum is " + Sum );

//string interpolation
Console.WriteLine($"The Sum {myNumber1} and {myNumber2} is sum {Sum}");
Console.ReadKey();