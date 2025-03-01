using System;

namespace CS_DSA_Solutions
{
    public class DoublyLinkedList
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
            newNode.Prev = temp;
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
                if (head != null)
                    head.Prev = newNode;
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
            if (temp.Next != null)
                temp.Next.Prev = newNode;

            temp.Next = newNode;
            newNode.Prev = temp;
        }

        public void Delete(int data)
        {
            if (head == null) return;

            Node temp = head;
            while (temp != null && temp.Data != data)
                temp = temp.Next;

            if (temp == null) return;

            if (temp.Prev != null)
                temp.Prev.Next = temp.Next;
            if (temp.Next != null)
                temp.Next.Prev = temp.Prev;
            if (temp == head)
                head = temp.Next;
        }

        public void RemoveAt(int index)
        {
            if (head == null || index < 0)
            {
                Console.WriteLine("Invalid index or empty list.");
                return;
            }

            Node temp = head;
            int count = 0;

            while (temp != null && count < index)
            {
                temp = temp.Next;
                count++;
            }

            if (temp == null) 
            {
                Console.WriteLine("Index out of range.");
                return;
            }

            if (temp == head)
            {
                head = temp.Next;
            }

            if (temp.Prev != null)
                temp.Prev.Next = temp.Next;
            if (temp.Next != null)
                temp.Next.Prev = temp.Prev;
        }


        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " <-> ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }
    }

    
}
