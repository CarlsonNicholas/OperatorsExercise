// Operators Exercise by Nick Carlson
// Exercise 1 Part 1: 
// Simple Program to Write Results

using Operators_Exercise;

Console.WriteLine("Simple Math Operations: ");
Console.WriteLine();

int add = MathOps.Add(7, 7);
int sub = MathOps.Subtract(7, 7);
int mul = MathOps.Multiply(7, 7);
int div = MathOps.Divide(7, 7);
int mod = MathOps.Modulus(7, 7);

Console.WriteLine($"7 + 7 when added gives you the sum of {add}; when subtracted {sub}; when multiplyed {mul}; when divided {div}; and finally with a modulus {mod}!");
Console.WriteLine();

//Exercise 1 Part 2:
// Declaring Integers
Console.WriteLine("Declairng Integers Exercise 1");
Console.WriteLine("");

int a = 17;
int b = 4;

int quotient = a / b;
int remainder = a % b;

if (a == 17 && b == 4)
    Console.WriteLine($"{a} divided by {b} is {quotient} with a remainder of {remainder}!");
    Console.WriteLine();

//Exercise 2

Console.WriteLine("Please enter a Radius for a Cirlce ");

var radius = double.Parse(Console.ReadLine());

var answer = Circle.AreaOfCircle(radius);
Console.WriteLine(answer);

