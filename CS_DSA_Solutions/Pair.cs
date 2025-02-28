using System;
using System.Collections.Generic;

namespace CS_Basic_Problems
{
    public class Pair
    {
        public static void FindPairsWithSum()
        {
            Console.WriteLine("Enter the elements of the array separated by spaces:");
            string[] input = Console.ReadLine().Split();
            int[] arr = Array.ConvertAll(input, int.Parse);

            Console.WriteLine("Enter the target sum:");
            int target = int.Parse(Console.ReadLine());

            HashSet<int> set = new HashSet<int>();
            List<(int, int)> result = new List<(int, int)>();

            foreach (int num in arr)
            {
                int complement = target - num;
                if (set.Contains(complement))
                    result.Add((complement, num));

                set.Add(num);
            }

            if (result.Count > 0)
            {
                Console.WriteLine("Pairs with sum " + target + ": " + string.Join(", ", result));
            }
            else
            {
                Console.WriteLine("No pairs found with the given sum.");
            }
        }
    }
}
