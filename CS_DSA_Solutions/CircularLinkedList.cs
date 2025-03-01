using System;

namespace CS_DSA_Solutions
{
    public class CircularLinkedList
    {
        private Node head;

        public void InsertEnd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                head.Next = head;
                return;
            }

            Node temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Next = head;
        }

        public void Delete(int data)
        {
            if (head == null) return;

            Node temp = head, prev = null;

            if (head.Data == data)
            {
                if (head.Next == head)
                {
                    head = null;
                    return;
                }

                Node last = head;
                while (last.Next != head)
                    last = last.Next;

                last.Next = head.Next;
                head = head.Next;
                return;
            }

            do
            {
                prev = temp;
                temp = temp.Next;
            } while (temp != head && temp.Data != data);

            if (temp == head) return;

            prev.Next = temp.Next;
        }

        public void Display()
        {
            if (head == null) return;

            Node temp = head;
            do
            {
                Console.Write(temp.Data + "->");
                temp = temp.Next;
            } while (temp != head);
            Console.WriteLine($"{head.Data}");
        }
    }

}
