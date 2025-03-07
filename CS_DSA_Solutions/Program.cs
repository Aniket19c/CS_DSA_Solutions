using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a data structure:");
        Console.WriteLine("1. Dictionary");
        Console.WriteLine("2. HashTable");
        Console.Write("Enter your choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            HandleDictionary(myDictionary);
        }
        else if (choice == 2)
        {
            HashTable<int, string> myHashTable = new HashTable<int, string>();
            HandleHashTable(myHashTable);
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }

    static void HandleDictionary(Dictionary<int, string> dict)
    {
        while (true)
        {
            Console.WriteLine("\nDictionary Operations:");
            Console.WriteLine("1. Add Key-Value Pair");
            Console.WriteLine("2. Get Value by Key");
            Console.WriteLine("3. Remove Key");
            Console.WriteLine("4. Display All");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter Key (int): ");
                    int key = int.Parse(Console.ReadLine());
                    Console.Write("Enter Value (string): ");
                    string value = Console.ReadLine();
                    dict[key] = value;
                    break;
                case 2:
                    Console.Write("Enter Key to Get Value: ");
                    key = int.Parse(Console.ReadLine());
                    Console.WriteLine(dict.ContainsKey(key) ? $"Value: {dict[key]}" : "Key not found.");
                    break;
                case 3:
                    Console.Write("Enter Key to Remove: ");
                    key = int.Parse(Console.ReadLine());
                    if (dict.Remove(key)) Console.WriteLine("Key removed.");
                    else Console.WriteLine("Key not found.");
                    break;
                case 4:
                    Console.WriteLine("Dictionary Contents:");
                    foreach (var pair in dict)
                        Console.WriteLine($"{pair.Key} : {pair.Value}");
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void HandleHashTable(HashTable<int, string> hashTable)
    {
        while (true)
        {
            Console.WriteLine("\nHashTable Operations:");
            Console.WriteLine("1. Add Key-Value Pair");
            Console.WriteLine("2. Get Value by Key");
            Console.WriteLine("3. Remove Key");
            Console.WriteLine("4. Display All");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter Key (int): ");
                    int key = int.Parse(Console.ReadLine());
                    Console.Write("Enter Value (string): ");
                    string value = Console.ReadLine();
                    hashTable.Add(key, value);
                    break;
                case 2:
                    Console.Write("Enter Key to Get Value: ");
                    key = int.Parse(Console.ReadLine());
                    Console.WriteLine(hashTable.ContainsKey(key) ? $"Value: {hashTable.Get(key)}" : "Key not found.");
                    break;
                case 3:
                    Console.Write("Enter Key to Remove: ");
                    key = int.Parse(Console.ReadLine());
                    if (hashTable.Remove(key)) Console.WriteLine("Key removed.");
                    else Console.WriteLine("Key not found.");
                    break;
                case 4:
                    Console.WriteLine("HashTable Contents:");
                    hashTable.Display();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
