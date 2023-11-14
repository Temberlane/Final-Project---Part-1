// C# Data types
// Variables in C#
// A variable is a holder of information
// Many different types :
// int - integer from -2,147,483,648 to 2,147,483,647
// long - integer from from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
// double - floating point such as 9.99
// char - single charecters
// string - text
// bool - True or False

//You can assign multiple varibles in one line such as
int x, y, z;
x = y = z = 50;
// With all x, y, z, being int and 50

// C# Text
string text = "Hello, my name is Thomas";
Console.WriteLine(text);

// C# integers
// They are any number with no decimal point such as 1, 4, 5, -6 ect.
int myint = 5;
Console.WriteLine(myint);

// C# Floats (doubles)
// They are any number with a decimal such as 1.3, 5.6, -4.5
double myfloat = 23.4;
Console.WriteLine(myfloat);

// C# Bools
// They are true and false values
bool running, walking;
running = true;
walking = false;
Console.WriteLine(running, walking)

// Type casting
// When you assign a value of one data type to another type
// Two types :
// Implicit (Automatically change type to a larger type size)
// char -> int -> long -> float -> double
int oldInt = 20;
double newDouble = oldInt;       // Automatic casting: int to double
Console.WriteLine(oldInt);   
Console.WriteLine(newDouble); 

// Explicit (Manually change type to a smaller type size)
// double -> float -> long -> int -> char
double doubleVar = 1114.53;
int myInt = (int) doubleVar;    // Manual casting: double to int
Console.WriteLine(myDouble);   // Outputs 1114.53
Console.WriteLine(myInt);      // Outputs 1114

// C# Operators
// +	Addition	Adds together two values	x + y	
// -	Subtraction	Subtracts one value from another	x - y	
// *	Multiplication	Multiplies two values	x * y	
// /	Division	Divides one value by another	x / y	
// %	Modulus	Returns the division remainder	x % y	
// ++	Increment	Increases the value of a variable by 1	x++	
// --	Decrement	Decreases the value of a variable by 1	x--

// C# Assignment Operators
// =	x = 5	x = 5	
// +=	x += 3	x = x + 3	
// -=	x -= 3	x = x - 3	
// *=	x *= 3	x = x * 3	
// /=	x /= 3	x = x / 3	
// %=	x %= 3	x = x % 3	
// &=	x &= 3	x = x & 3	
// |=	x |= 3	x = x | 3	
// ^=	x ^= 3	x = x ^ 3	
// >>=	x >>= 3	x = x >> 3	
// <<=	x <<= 3	x = x << 3

// C# Comparitors
// ==	Equal to	x == y	
// ===	Strictly equal to	x === y	
// !=	Not equal	x != y	
// >	Greater than	x > y	
// <	Less than	x < y	
// >=	Greater than or equal to	x >= y	
// <=	Less than or equal to	x <= y
