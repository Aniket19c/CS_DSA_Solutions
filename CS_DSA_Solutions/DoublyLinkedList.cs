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

        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + "<->");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }
    }
}
