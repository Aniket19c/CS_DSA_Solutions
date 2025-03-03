using System;
using StackQueueLinkedList.DataStructures;

namespace StackQueueLinkedList
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Stack Operations:");
            StackLinkedList<int> stack = new StackLinkedList<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Display();
            Console.WriteLine("Popped: " + stack.Pop());
            stack.Display();

            Console.WriteLine("\nQueue Operations:");
            QueueLinkedList<int> queue = new QueueLinkedList<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Display();
            Console.WriteLine("Dequeued: " + queue.Dequeue());
            queue.Display();
            Console.ReadLine();
        }
    }
}
