using System;

namespace CS_Basic_Problems
{
    public class MajorityElement
    {
        public static void FindMajorityElementInArray()
        {
            Console.WriteLine("Enter the array elements (comma-separated): ");
            string input = Console.ReadLine();
            int[] arr = input.Split(',').Select(int.Parse).ToArray();

            int candidate = arr[0], count = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == candidate)
                    count++;
                else
                    count--;

                if (count == 0)
                {
                    candidate = arr[i];
                    count = 1;
                }
            }

            Console.WriteLine("Majority Element: " + candidate);
        }
    }
}
