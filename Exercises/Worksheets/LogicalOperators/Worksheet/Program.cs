// Exercise 1
// Write a C# program that uses nested if statements to check two conditions. If the first condition is true, check a second condition. Print "Above 10" if the first condition is true and "Above 20" if the second condition is true. If the first condition is false, print "Not above 10."

int x = 41;

if (x > 10)
{
    Console.WriteLine("Above 10");

    if (x > 20)
    {
        Console.WriteLine("Above 20");
    }
    else
    {
        Console.WriteLine("But not above 20");
    }
}
else
{
    Console.WriteLine("Not above 10");
}

// Exercise 2
// Develop a program that uses logical operators to check at least one of two conditions. If at least one condition is true, print "At least one of the conditions is true." Use the || operator.

int a2 = 200;
int b2 = 33;
int c2 = 500;

if (a2 > b2 || c2 > a2)
{
    Console.WriteLine("At least one of the conditions is true");
}

// Exercise 3
// Create a C# program that uses logical operators to check two conditions. If both conditions are true, print "Both conditions are true." Use the && operator.

int a = 200;
int b = 33;
int c = 500;

if (a > b && c > a)
{
    Console.WriteLine("Both conditions are true");
}