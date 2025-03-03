using System;

namespace CS_DSA_Solutions
{
    public class SinglyLinkedList
    {
        private Node head;

        public void InsertEnd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
        }

        public void InsertAt(int index, int data)
        {
            if (index < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            Node newNode = new Node(data);

            if (index == 0)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            Node temp = head;
            for (int i = 0; temp != null && i < index - 1; i++)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine("Index out of bounds");
                return;
            }

            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        public void Delete(int data)
        {
            if (head == null) return;

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node temp = head;
            while (temp.Next != null && temp.Next.Data != data)
                temp = temp.Next;

            if (temp.Next == null) return;

            temp.Next = temp.Next.Next;
        }

        public void RemoveAt(int index)
        {
            if (head == null || index < 0)
            {
                Console.WriteLine("Invalid index or empty list.");
                return;
            }

            if (index == 0)
            {
                head = head.Next;
                return;
            }

            Node temp = head;
            int count = 0;

            while (temp.Next != null && count < index - 1)
            {
                temp = temp.Next;
                count++;
            }

            if (temp.Next == null)
            {
                Console.WriteLine("Index out of range.");
                return;
            }

            temp.Next = temp.Next.Next;
        }

        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }
    }

    
}
