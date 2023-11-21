// Exercise 1
// Create a C# program that prompts the user to enter their name, reads the input, and then prints a greeting using string interpolation.

Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");

// Exercise 2
// Develop a program that asks the user to enter their age, reads the input, converts it to an integer, and then prints the age.

Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Age is {age}");

// Exercise 3
//Write a program that formats and prints a full name using string interpolation. Use the provided firstName and lastName variables.
string firstName = "John";
string lastName = "Doe";
string fullName = $"Full name is: {firstName} {lastName}";
Console.WriteLine(fullName);