using System;

namespace CS_DSA_Solutions
{
    class Program
    {
        static void Main()
        {
            StudentManager studentManager = new StudentManager();

            while (true)
            {
                Console.WriteLine("Student Management System");
                Console.WriteLine("1️. Add Student");
                Console.WriteLine("2️. Remove Student");
                Console.WriteLine("3️. Display Students");
                Console.WriteLine("0️. Exit");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Student ID :");
                        if (!int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.WriteLine("Invalid ID. Must be a number.");
                            break;
                        }

                        Console.Write("Enter Student Name: ");
                        string name = Console.ReadLine();

                        studentManager.AddStudent(new Student(id, name));
                        break;

                    case 2:
                        Console.Write("Enter Student ID to remove: ");
                        if (!int.TryParse(Console.ReadLine(), out int removeId))
                        {
                            Console.WriteLine("Invalid ID. Must be a number.");
                            break;
                        }

                        studentManager.RemoveStudent(removeId);
                        break;

                    case 3:
                        studentManager.DisplayStudents();
                        break;

                    case 0:
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
