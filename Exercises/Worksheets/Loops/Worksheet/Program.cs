// Exercise 1
// Create a program that will count from 0 to 100 and prints everything on a new line

int i = 0;
while (i < 101)
{
    Console.WriteLine(i);
    i++;
}

// Exercise 2
// Write a program that utilizes a do/while loop to print numbers from 0 to 100. Ensure that the loop executes at least once.

int j = 0;
do
{
    Console.WriteLine(j);
    j++;
} while (j < 11);

// Exercise 3
// Develop a program that uses a for loop to print the numbers from 0 to 101. Include conditions within the loop to skip printing odd numbers

for (int number = 0; number <= 101; number++)
{
    // Skip odd numbers
    if (number % 2 != 0)
    {
        continue;
    }

    Console.WriteLine(number);
}
