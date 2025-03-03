using System;

namespace StackQueueLinkedList.DataStructures
{
    public class StackLinkedList<T>
    {
        private Node<T>? top;

        public StackLinkedList()
        {
            top = null;
        }

        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = top;
            top = newNode;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            T data = top!.Data;
            top = top.Next;
            return data;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            return top!.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Display()
        {
            Node<T>? current = top;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("NULL");
        }
    }
}
