using System;

namespace CS_Basic_Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the Problem");
            Console.WriteLine("1. Find All Pairs with a Given Sum");
            Console.WriteLine("2. Find the Missing Number in an Array");
            Console.WriteLine("3. Find the Intersection of Two Arrays");
            Console.WriteLine("4. Maximum Subarray");
            Console.WriteLine("5. Find the Majority Element");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Pair.FindPairsWithSum();
                    break;
                case 2:
                    MissingNumber.FindMissingNumber();
                    break;
                case 3:
                    ArrayIntersection.GetIntersection();

                    break;
                case 4:
                    MaximumSubarray.CalculateMaximumSubarraySum();
                    break;
                case 5:
                    MajorityElement.FindMajorityElementInArray();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
