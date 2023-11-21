// Exercise 1
// Write a program that prompts user to enter an item to check if its in an array

string[] itemsArray = { "apple", "banana", "orange", "grape", "kiwi" };

Console.Write("Enter an item to check: ");
string userItem = Console.ReadLine().ToLower(); // Convert to lowercase for case-insensitive comparison

// Exercise 2
// Check if the user's item exists in the array
if (Array.Exists(itemsArray, item => item.ToLower() == userItem))
{
    Console.WriteLine($"Yes, {userItem} is in the array.");
}
else
{
    Console.WriteLine($"No, {userItem} is not in the array.");
}

// Exercise 3
// Write a program that can append items to an array and delete with user inputs
string[] itemsArray = { "apple", "banana", "orange", "grape", "kiwi" };

while (true)
{
    Console.WriteLine("Current items in the array:");
    PrintArray(itemsArray);

    Console.WriteLine("\nChoose an operation:");
    Console.WriteLine("1. Append item");
    Console.WriteLine("2. Delete item");
    Console.WriteLine("3. Exit");

    Console.Write("Enter your choice (1-3): ");
    int choice;
    if (int.TryParse(Console.ReadLine(), out choice))
    {
        if (choice == 1)
        {
            Console.Write("Enter the item to append: ");
            string newItem = Console.ReadLine();
            itemsArray = AppendItem(itemsArray, newItem);
        }
        else if (choice == 2)
        {
            Console.Write("Enter the item to delete: ");
            string itemToDelete = Console.ReadLine();
            itemsArray = DeleteItem(itemsArray, itemToDelete);
        }
        else if (choice == 3)
        {
            Console.WriteLine("Exiting the program. Goodbye!");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}


static string[] AppendItem(string[] array, string newItem)
{
    Array.Resize(ref array, array.Length + 1);
    array[array.Length - 1] = newItem;
    Console.WriteLine($"{newItem} has been appended to the array.");
    return array;
}

static string[] DeleteItem(string[] array, string itemToDelete)
{
    int index = Array.IndexOf(array, itemToDelete);
    if (index != -1)
    {
        array = array.Where((source, i) => i != index).ToArray();
        Console.WriteLine($"{itemToDelete} has been deleted from the array.");
    }
    else
    {
        Console.WriteLine($"{itemToDelete} not found in the array.");
    }
    return array;
}

static void PrintArray(string[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

