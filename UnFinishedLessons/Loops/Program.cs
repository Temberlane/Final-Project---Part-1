// Loops are a big part of writing programs because sometimes you need to count or perform a task multiple times
// Those programs require a loop
// Theres two types
// while loops and for loops

// While loops will execute as long as a condition is true
// while (condition) 
// {
//   // code to be executed
// }

// here is an example of counting from 0 to 10
int i = 0;
while (i < 11) 
{
  Console.WriteLine(i);
  i++;
}

// There is also a do/while loops which will execute code once then check the condition and only execute as long as the condition is true

// do 
// {
//   // code to be executed once then contiously
// }
// while (condition);

// Here is an updated example with the do/while example
int j = 0;
do
{
  Console.WriteLine(j);
  j++;
} while (j < 11);

// For loops are for when you know how many times you want to execute through a code block

// for (condition 1; condition 2; condition 3) 
// {
//   // code
// }
// condition 1 is executed once before the code block.

// condition 2 is the condition for executing the code block.

// condition 3 is executed everytime after the code block has been executed.

// The example below will print the numbers 0 to 10

for (int k = 0; k < 11; k++)
{
    Console.WriteLine("Trial One " + k);
}

// It gets more complicated if you want to interate over a string
// You must use a foreach loop which will loop through elements in an array
// foreach (type variableName in arrayName) 
// {
//   // code 
// }

// Lets say we want to iterate through all the elements in an array
string[] dogs = {"Husky", "Golden", "cool dog"}; //initializes an array of strings
foreach (string m in dogs)
{
    Console.WriteLine(m);
}

// There are break and continue statements which are used to either break out of a loop or skip over an interation of a loop


// Break example
// The following will loop from 0 to 10 but jump out of the loop when it hits 8
for (int h = 0; h < 11; h++)
{
    if (h == 8)
    {
        break;
    }
    Console.WriteLine(h);
}

// Lets see what happens if you switch it to a continue statement, it will skip over the value 8 instead
for (int h = 0; h < 11; h++)
{
    if (h == 8)
    {
        continue;
    }
    Console.WriteLine(h);
}
// They can be used in while loops and foreach loops
