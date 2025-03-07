using System;

class Program
{
    static void Main()
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Choose Sorting Algorithm:");
        Console.WriteLine("1. Bubble Sort");
        Console.WriteLine("2. Insertion Sort");
        Console.WriteLine("3. Selection Sort");
        Console.WriteLine("4. Merge Sort");
        Console.Write("Enter your choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nOriginal Array:");
        PrintArray(array);

        switch (choice)
        {
            case 1:
                BubbleSort.Sort(array);
                Console.WriteLine("\nSorted using Bubble Sort:");
                break;
            case 2:
                InsertionSort.Sort(array);
                Console.WriteLine("\nSorted using Insertion Sort:");
                break;
            case 3:
                SelectionSort.Sort(array);
                Console.WriteLine("\nSorted using Selection Sort:");
                break;
            case 4:
                MergeSort.Sort(array, 0, array.Length - 1);
                Console.WriteLine("\nSorted using Merge Sort:");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                return;
        }

        PrintArray(array);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}
