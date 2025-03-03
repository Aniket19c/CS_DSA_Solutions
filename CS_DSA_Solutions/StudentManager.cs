using System;
using System.Collections.Generic;

namespace CS_DSA_Solutions
{
    public class StudentManager
    {
        private LinkedList<Student> studentList = new LinkedList<Student>();

     
        public void AddStudent(Student student)
        {
            studentList.AddLast(student);
            Console.WriteLine($"Student added: {student}");
        }

     
        public bool RemoveStudent(int id)
        {
            var node = studentList.First;
            while (node != null)
            {
                if (node.Value.Id == id)
                {
                    studentList.Remove(node);
                    Console.WriteLine($"Student with ID {id} removed.");
                    return true;
                }
                node = node.Next;
            }
            Console.WriteLine($"Student with ID {id} not found.");
            return false;
        }

      
        public void DisplayStudents()
        {
            if (studentList.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("Student List:");
            foreach (var student in studentList)
            {
                Console.WriteLine(student);
            }
        }
    }
}
