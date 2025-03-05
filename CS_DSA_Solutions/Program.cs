using System;
using CS_DSA_Solutions;

class Program
{
    static void Main()
    { 
        Department csDept = new Department(1, "Computer Science");
        Department mechDept = new Department(2, "Mechanical Engineering");

       
        Employee emp1 = new Employee(100, "Aniket", "aniket@gmail.com", "23434234233");
        Employee emp2 = new Employee(101, "Aditya", "aditya@gmail.com", "43242342343");
        Employee emp3 = new Employee(102, "Rahul", "rahul@gmail.com", "9876543210");

     
        College college = new College();

      
        college.AddDepartment(csDept);
        college.AddDepartment(mechDept);

      
        college.AddEmployee("Computer Science", emp1);
        college.AddEmployee("Computer Science", emp2);
        college.AddEmployee("Mechanical Engineering", emp3);

   
        Console.WriteLine("\n--- College Data ---");
        college.Display();

       
        Console.WriteLine("\n--- Employees in Computer Science Department ---");
        college.Display("Computer Science");

 
        Console.WriteLine("\n--- Removing Employee Aniket from Computer Science ---");
        college.Update("Computer Science", "Aniket");
        college.Display("Computer Science");
        Console.ReadLine();
    }
}
