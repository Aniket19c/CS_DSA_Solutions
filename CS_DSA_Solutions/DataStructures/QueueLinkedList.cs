using System;

namespace StackQueueLinkedList.DataStructures
{
    public class QueueLinkedList<T>
    {
        private Node<T>? front;
        private Node<T>? rear;

        public QueueLinkedList()
        {
            front = rear = null;
        }

        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            T data = front!.Data;
            front = front.Next;

            if (front == null)
                rear = null;

            return data;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            return front!.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public void Display()
        {
            Node<T>? current = front;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("NULL");
        }
    }
}
