// C# is a language designed to be like Java and is an object orientated language
// It has many capabilities such as writing web apps, backend, frontend, mobile apps ect.


// First C# Program
Console.WriteLine("Hello, World!");
// This writes a line to the console


// To make a file, you must use the command "dotnet new console -o (name of project)"

// A more proper program would be using System;
// using System; // Use classes from the system namespace

// namespace HelloWorld // Use namespaces to organize your code, it is like a countainer for classes
// { // These curly braces mark the beginning and ending of code
//   class Program // A class is a container for data and methods, basically functions
//   {
//     static void Main(string[] args) // Any code in the Main method will be executed
//     {
//       Console.WriteLine("Hello World!");   //Note the "punctuation" with the ;
//     }
//   }
// }

/* To make a multiline comment
Use these symbols /* and */


// Syntax in C#:
// This language uses curly braces to denote blocks of code, unlike python that uses indentation. C# doesn't care about white space. But it is nice to have it since it makes it more readable.
// Key points :
// ; to end a line
// {} to show a code block

// Variables in C#endregion
// A variable is a holder of information
// Many different types :
// int - integer
// double - floating point such as 9.99
// char - single charecters
// string - text
// bool - True or False

//Example denoting a variable
// (type) (variableName) = (value);
int num = 5; // This would set num to the integer 5
// To print it 
Console.WriteLine(num);
// You can also declare an empty variable
int num;
num = 20;
Console.WriteLine(num);
//There are rules for variables names:
// Variable names can only contain letters, digits, and the underscore _
// Variable names must start with a letter. 
// Variable names are case-sensitive.
// Variable names cannot contain reserved keywords.

// There are also constants that make it so that you cannot change variables

const int num = 5;
num = 10 // would return an error