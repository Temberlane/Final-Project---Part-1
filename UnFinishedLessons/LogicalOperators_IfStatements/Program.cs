// Statements
// a statement is an instruction that can be executed. We have seen assignment statements so far. 
// we will be focusing on if-statements

// Expression
// an expression is something that needs to be evaluated

// Comparison Operators
// ==	Equal to	x == y	
// !=	Not equal	x != y	
// >	Greater than	x > y	
// <	Less than	x < y	
// >=	Greater than or equal to	x >= y	
// <=	Less than or equal to	x <= y

// If-Statements
// The word 'if' is used to make decisions

int var1 = 20;
int var2 = 18;
if (var1 > var2) {
  Console.WriteLine("x is greater than y");
} else {
    Console.WriteLine("x is not greater than y");
}
// To do more than one thing when a condition is true, you need to include it within the curly braces {}, this is a code block

// Else
// If a particular condition is true, execute a specific block of code. Otherwise (else), execute an alternative block of code.
// The 'else' keyword covers scenarios not addressed by preceding conditions.
// Code indented under 'else' is activated only when the initial condition is false.
// You can use 'else' without 'else if' (which will be discussed later).

// Else if
// The 'else if' keyword is a way of saying 'if the previous conditions were not true, then check this condition.'
// An if statement can contain any number of 'else if' conditions and doesn't necessarily need an 'else' at the end.

if (condition1)
{
  // block of code to be executed if condition1 is True
} 
else if (condition2) 
{
  // block of code to be executed if the condition1 is false and condition2 is True
} 
else
{
  // block of code to be executed if the condition1 is false and condition2 is False
}


// Example 1
int a1 = 33;
int b1 = 33;

if (b1 > a1)
{
    Console.WriteLine("b is greater than a");
}
else if (a1 == b1)
{
    Console.WriteLine("a and b are equal");
}

// Example 2
int a2 = 200;
int b2 = 33;

if (b2 > a2)
{
    Console.WriteLine("b is greater than a");
}
else if (a2 == b2)
{
    Console.WriteLine("a and b are equal");
}
else
{
    Console.WriteLine("a is greater than b");
}

// # Logical Operators
// # logical operators are used to combine conditional statements

// && 	Logical and	Returns True if both statements are true	
// || 	Logical or	Returns True if one of the statements is true	
// !	Logical not	Reverse the result, returns False if the result is true	
// Example with 'and' logical operator
int a = 200;
int b = 33;
int c = 500;
if (a > b && c > a)
{
    Console.WriteLine("Both conditions are true");
}

// Example with 'or' logical operator
int a2 = 200;
int b2 = 33;
int c2 = 500;
if (a2 > b2 || c2 > a2)
{
    Console.WriteLine("At least one of the conditions is true");
}

// Example with 'not' logical operator
int a3 = 200;
int b3 = 33;
int c3 = 500;
if (!(a3 > b3 && c3 > a3))
{
    Console.WriteLine("Both conditions are false");
}
else if (!(a3 > b3 || c3 > a3))
{
    Console.WriteLine("One of the conditions is false");
}

// Example with Nested Ifs
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