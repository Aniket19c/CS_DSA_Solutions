using System;

namespace CS_Basic_Problems
{
    public class MaximumSubarray
    {
        public static void CalculateMaximumSubarraySum()
        {
            Console.WriteLine("Enter the array elements (comma-separated): ");
            string input = Console.ReadLine();
            int[] nums = input.Split(',').Select(int.Parse).ToArray();

            int maxSum = nums[0], currentSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }

            Console.WriteLine("Maximum Subarray Sum: " + maxSum);
        }
    }
}
