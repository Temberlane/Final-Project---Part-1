// Exercise 1
// Develop a program that declares three variables x, y, and z, and assigns the value 50 to each variable in a single line. Print the values of x, y, and z.

int x, y, z;
x = y = z = 50;
Console.WriteLine($"x: {x}, y: {y}, z: {z}");

// Exercise 2
// Create a program that demonstrates the use of assignment operators. Declare a variable x with an initial value of 5. Use assignment operators to update x by adding 3, subtracting 2, multiplying by 4, dividing by 2, and finding the remainder when divided by 3. Print the result after each operation.

int x = 5;
Console.WriteLine($"Initial x: {x}");
x += 3;
Console.WriteLine($"After adding 3: {x}");
x -= 2;
Console.WriteLine($"After subtracting 2: {x}");
x *= 4;
Console.WriteLine($"After multiplying by 4: {x}");
x /= 2;
Console.WriteLine($"After dividing by 2: {x}");
x %= 3;
Console.WriteLine($"After finding remainder when divided by 3: {x}");

// Exercise 3
// Develop a program that uses the addition and subtraction operators. Declare two variables, a and b, assign them values, and print the result of adding a and b, then subtracting b from a.

int a = 10;
int b = 5;
Console.WriteLine($"a + b = {a + b}");
Console.WriteLine($"a - b = {a - b}");