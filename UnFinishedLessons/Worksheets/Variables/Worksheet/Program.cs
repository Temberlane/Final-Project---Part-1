// Exercise 1
// Create a C# program that declares a variable named greeting and initializes it with the string "Hello, World!". Print the value of the greeting variable to the console.

string greeting = "Hello, World!";
Console.WriteLine(greeting);

//Exercise 2
// Develop a C# program that declares and initializes variables of different types (int, double, char, string, bool). Print each variable's value on a separate line.
int num = 5;
double floatingNum = 9.99;
char singleChar = 'A';
string text = "Programming is cool";
bool isTrue = true;

Console.WriteLine($"Integer: {num}");
Console.WriteLine($"Double: {floatingNum}");
Console.WriteLine($"Character: {singleChar}");
Console.WriteLine($"String: {text}");
Console.WriteLine($"Boolean: {isTrue}");

// Exercise 3
// Write a C# program that demonstrates the use of constants. Declare a constant named fixedNum with a value of 10. Attempt to reassign a new value to fixedNum and observe the resulting error.

const int fixedNum = 10;
// Uncommenting the line below would result in a compilation error because you cannot change constants, they are constant.
// fixedNum = 20;
Console.WriteLine($"Constant value: {fixedNum}");
