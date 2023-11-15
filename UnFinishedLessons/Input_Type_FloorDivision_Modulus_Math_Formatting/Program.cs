// Input
// Input function is to interact with code
// You have learnt that Console.WriteLine() is used to output, 
// Now Console.ReadLine() gets user input.

// Here is a sample name getter
Console.WriteLine("Enter Name:");
string name = Console.ReadLine();
Console.WriteLine("Name is " + name);
// This works for strings but doesn't work for numbers

// Example : 
// Console.WriteLine("Enter your age:");
// int age = Console.ReadLine();
// Console.WriteLine("Age is " + age);
// This would return an error saying that cannot implicitly convert 'string' to 'int'

// You must explicitly convert string to int.
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Age is " + age);

// Floor Division (Integer Division)
// Use Math.Floor()
Console.WriteLine(Math.Floor(100.0/6.0)); // Both numbers need to be a float or "double"

// Modulos
Console.WriteLine(6 % 4); // Returns the remainder of 2

// Math Functions
// Math.Max(x,y) Find highest value
// Math.Min(x,y) Find lowest value
// Math.Sqrt(x) Returns the Sqrt of x
// Math.Abs(x) Returns the positive value
// Math.Round(x) Rounds the number to the nearest whole number

// Formatting Numbers
