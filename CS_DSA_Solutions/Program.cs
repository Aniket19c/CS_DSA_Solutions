using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CS_DSA_Solutions
{
    public class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Reverse a String");
                Console.WriteLine("2. Palindrome Check");
                Console.WriteLine("3. Anagram Check");
              
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice (0-7): ");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > 7)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 7.");
                    continue;
                }

                if (choice == 0)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                Console.Write("Enter the input string: ");
                string input = Console.ReadLine();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Reversed String: " + ReverseString.Reverse(input));
                        break;
                    case 2:
                        Console.WriteLine("Is Palindrome? " + PalindromeCheck.IsPalindrome(input));
                        break;
                    case 3:
                        Console.Write("Enter second string: ");
                        string input2 = Console.ReadLine();
                        Console.WriteLine("Are Anagrams? " + AnagramCheck.AreAnagrams(input, input2));
                        break;
                    
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}


