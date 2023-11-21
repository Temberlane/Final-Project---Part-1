// Exercise 1
// Create a C# program that defines a function named Greet which takes a string parameter name and prints a greeting message. Call the function with the argument "Alice".
static void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}


Greet("Alice");

// Exercise 2
// Write a program that defines a function named CalculateArea which calculates and returns the area of a rectangle. The function should take two parameters, length and width. Call the function with the arguments length = 5 and width = 10, then print the result.

static double CalculateArea(double length, double width)
{
    return length * width;
}


double area = CalculateArea(5, 10);
Console.WriteLine($"The area of the rectangle is: {area}");

// Exercise 3
// Create a program that defines a function named GreetUser which takes a string parameter name with a default value of "Guest". The function should print a greeting message using the provided name. Call the function with and without an argument to see the default behavior.

static void GreetUser(string name = "Guest")
{
    Console.WriteLine($"Hello, {name}!");
}



    GreetUser();             // Outputs: Hello, Guest!
    GreetUser("Alice");      // Outputs: Hello, Alice!