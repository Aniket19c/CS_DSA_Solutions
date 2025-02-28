using System;
using System.Linq;

namespace CS_Basic_Problems
{
    public class MissingNumber
    {
        public static void FindMissingNumber()
        {
            Console.WriteLine("Enter the numbers (comma-separated): ");
            string input = Console.ReadLine();
            int[] arr = input.Split(',').Select(int.Parse).ToArray();

            int n = arr.Length + 1;
            int totalSum = n * (n + 1) / 2;
            int arraySum = arr.Sum();

            Console.WriteLine("Missing number: " + (totalSum - arraySum));
        }
    }
}
