using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DSA_Solutions.Student
{
    public class StudentLinkedList
    {
        private StudentNode head;
        public void add(Student student) 
        {
            StudentNode newNode = new StudentNode(student);
            if (head == null)
            {
                head = newNode;

            }
            else
            {
                StudentNode temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        public bool remove(int id)
        {
            if (head == null) return false;
            if (head.Data.Id == id)
            {
                head = head.Next;
                return true;
            }

            StudentNode temp = head;
            while (temp.Next != null && temp.Next.Data.Id != id)
            {
                temp = temp.Next;
            }

            if (temp.Next == null) return false;
            temp.Next = temp.Next.Next;
            return true;
        }
        public void display()
        {
            StudentNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($" id :{temp.Data.Id} , name : {temp.Data.Name}");
                temp = temp.Next;
            }
        }

    }
}
