using System;

class Program
{
    static void Main()
    {
        int[] array = { 12, 34, 45, 7, 9, 23, 56, 78 };
        Console.WriteLine("Choose Search Method:");
        Console.WriteLine("1. Linear Search");
        Console.WriteLine("2. Binary Search");
        Console.Write("Enter your choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number to search: ");
        int target = Convert.ToInt32(Console.ReadLine());

        int result = -1;

        switch (choice)
        {
            case 1:
                result = LinearSearch.Search(array, target);
                break;
            case 2:
                Array.Sort(array); 
                result = BinarySearch.Search(array, target);
                break;
            default:
                Console.WriteLine("Invalid choice!");
                return;
        }

        if (result != -1)
            Console.WriteLine($"Element found at index: {result}");
        else
            Console.WriteLine("Element not found in the array.");
    }
}
