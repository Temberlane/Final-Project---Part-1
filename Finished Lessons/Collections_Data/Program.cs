// Collections
// Starting with arrays
// Used to store multiple values in a single variable
// Use square brackets
// string[] dogs;
// Dogs is now an array of strings
using System.Numerics;
using System.Runtime.CompilerServices;

string[] dogs = {"Golden", "Husky", "Woof"};
// Nums are different
int[] nums = {10, 20, 5};

// TO access the elements of an array, you must specify the array then the array index, it starts at 0
Console.WriteLine(dogs[0]); // Would print golden

// Now to change an index number value
dogs[0] = "Hot Dog";
Console.WriteLine(dogs[0]); // Would print hot dog

// You can also create empty arrays and then add elements later such as

string[] emptyarr = new string[4]; // Array of 4 elements thats empty

string[] emptyarr2 = new string[4] {"elements 1", "element 2", "elements 3", "element 4"}; // This creates the empty array then immediately adds the elements

//Or you could even make an unspecfied length array then add the elements

string[] emptyarr3 = new string[] {"elements 1", "element 2", "elements 3", "element 4"};
//often ommiting the new keyword is quicker and better
string[] emptyarr4 = {"elements 1", "element 2", "elements 3", "element 4"};

// Looping through an array

string[] emptyarr5 = {"elements 1", "element 2", "elements 3", "element 4"};
for (int i = 0; i < emptyarr5.Length; i++)
{
    Console.WriteLine(emptyarr5[i]);
}

// There is a less verbose way to write looping through an array using foreach
// foreach (type variablename in arrayname) {code}
// Example
foreach (string i in emptyarr5)
{
    Console.WriteLine(i);
}

// Sometimes it is useful to have the index avaliable but often its better to use for each

// There are also nested arrays
int[,] numbers = { {1, 2}, {3, 4}, {5, 6}}; // The comma inside the [] specifies the depth of the array, 1 comma = 2D, 2 commas = 3D ect.
//Now to access elemeents you must use [index1, index2] to access stuff
Console.WriteLine(numbers[0,0]); // prints 1

// You can still loop through 2D arrays just use for each
foreach (int i in numbers)
{
    Console.WriteLine(i);
}

// Or you could use the regular for loop but need a nested loop
for (int j = 0; j < numbers.GetLength(0); j++)
{
    for (int k = 0; k < numbers.GetLength(1); k++)
    {
        Console.WriteLine(numbers[j,k]);
    }
}
// Using GetLength access the length of an array. The parameter is an integer that will return the dimension that is specified GetLength(0) Would return 3 and the GetLegnth(1) returns 2
Console.WriteLine(numbers.GetLength(0).ToString() + numbers.GetLength(1).ToString());

// There are also dictionaries that are key value pairs
Dictionary<string, int> newDict = new Dictionary<string, int>(); // This creates a new dictionary with strings as keys and ints as values
// Adding is simpler such as
newDict.Add("One", 1);
// Getting value uses get
int value = newDict["One"];


// There are also many methods assosiated with arrays such as
// IndexOf(array, item)
// Returns index of item
// Also Resize along with the ref keyword
// ref will pass by reference (the memory of the data not just the data)
// Resize(array, new array length)
