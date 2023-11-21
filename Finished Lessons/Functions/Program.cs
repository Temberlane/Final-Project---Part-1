// Functions
// They are a way to put your code into blocks
// Tends to be reusable such as a function to find primes or a function to parse some data ect.
// You can pass data called parameters into a function
// They are also called methods

// Example
// using System;

// static void MyMethod() // Static means the method belongs to the program class andi s not an object
// // void means it doesn't return a value
// {
//     Console.WriteLine("Hello, this is my method");
// }

// MyMethod();

// In order to take in parameters, you must specify inside the parentheses.

// static void PrintMethod(string name)
// {
//     Console.WriteLine("My name is" + name);
// }

// PrintMethod("Thomas");

// You could even give multiple parameters seperated by a comma, you must specify the type

// static void PrintMethodAge(string name, int age)
// {
//     Console.WriteLine("My name is" + name + "My age is" + age);
// }

// PrintMethodAge("John", 20);

// There are default parameter values with setting the parameter equal to something so that if a value isn't provided, it still gets a value
// static void PrintMethodAge(string name == "No Name", int age = 0)

// Now to return values, we must get rid of the void keyword, and use a different data type
// Example 

// static int addition(int x)
// {
//     return x + x;
// }

// There is also a tecnique called method overloading which is coding a method to handle multiple datatypes. the above method wouldn't work for doubles so we could change it but use the same method with different data keywords to handle doubles


// Now we will run into some errors so we must use some formatting

using System;

namespace MyApplication
{
  class Program
  {
    static int addition(int x, int y)
    {
        return x + y;
    }

    static double addition(double x, double y)
    {
        return x + y;
    }

    static void Main(string[] args) // This is the main function to run 
    {
      int myNum1 = addition(8, 5);
      double myNum2 = addition(1.2, 3.26);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
    }  
  }
}