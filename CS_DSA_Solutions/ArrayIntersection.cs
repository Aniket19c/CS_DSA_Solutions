using System;
using System.Collections.Generic;

namespace CS_Basic_Problems
{
    public class ArrayIntersection
    {
        public static void GetIntersection()
        {
            Console.WriteLine("Enter first array (comma-separated): ");
            string input1 = Console.ReadLine();
            int[] arr1 = input1.Split(',').Select(int.Parse).ToArray();

            Console.WriteLine("Enter second array (comma-separated): ");
            string input2 = Console.ReadLine();
            int[] arr2 = input2.Split(',').Select(int.Parse).ToArray();

            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            List<int> resultIntersection = new List<int>();

            foreach (int num in arr1)
            {
                if (!frequencyMap.ContainsKey(num))
                    frequencyMap[num] = 0;
                frequencyMap[num]++;
            }

            foreach (int num in arr2)
            {
                if (frequencyMap.ContainsKey(num) && frequencyMap[num] > 0)
                {
                    resultIntersection.Add(num);
                    frequencyMap[num]--;
                }
            }

            Console.WriteLine("Intersection: " + string.Join(", ", resultIntersection));
        }
    }
}
