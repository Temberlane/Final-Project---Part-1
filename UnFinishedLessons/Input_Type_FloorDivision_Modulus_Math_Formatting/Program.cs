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
Console.WriteLine("Enter your age:");
int age = Console.ReadLine();
Console.WriteLine("Age is " + age);
// This would return an error saying that cannot implicitly convert 'string' to 'int'

// You must explicitly convert string to int.
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Age is " + age);

// Floor Division (Integer Division)

