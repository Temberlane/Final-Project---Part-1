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
// You can format numbers within a string using string interpolation which uses $ before the string to signify string interpolation

string firstName = "John";
string lastName = "Doe";
string fullname = $"full name is: {firstName} {lastName}";
Console.WriteLine(fullname);

// This works with strings aswell
double unitPrice = 49.99;
int quantity = 30;
Console.WriteLine($"Subtotal: ${quantity * unitPrice}");

// Formatted with two decimal places and thousands separator
Console.WriteLine($"Subtotal: ${quantity * unitPrice:0,0.00}");

// Formatting percent numbers
double salesTaxRate = 0.065;
Console.WriteLine($"Sales Tax Rate: {salesTaxRate:P2}");

// Multiline format strings
// Using '\n' for line break
string output1 = "hello \n my name is thomas";
Console.WriteLine(output1);

// Using @ quotation marks for multiline strings
string output2 = @"
hello
my
name
is
Thomas";
Console.WriteLine(output2);

// Formatting width and alignment
double subtotal = quantity * unitPrice;
double salesTax = salesTaxRate * subtotal;
double total = subtotal + salesTax;

string output3 = $@"
Sales Tax Rate: {salesTaxRate:P2}
Subtotal:       ${subtotal,9:0,0.00}  // 9 characters wide, right-aligned, with two decimal places
Sales Tax:      ${salesTax,9:0,0.00}  // 9 characters wide, right-aligned, with two decimal places
Total:          ${total,9:0,0.00}      // 9 characters wide, right-aligned, with two decimal places";

Console.WriteLine(output3);