using System;

namespace CS_DSA_Solutions
{
    class Program
    {
        static void Main()
        {
            DoublyLinkedList dll = new DoublyLinkedList();
            CircularLinkedList cll = new CircularLinkedList();

            while (true)
            {
                
                Console.WriteLine("1. Doubly Linked List");
                Console.WriteLine("2. Circular Linked List");
                Console.WriteLine("0. Exit");
               

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        DoublyLinkedListMenu(dll);
                        break;
                    case 2:
                        CircularLinkedListMenu(cll);
                        break;
                    case 0:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void DoublyLinkedListMenu(DoublyLinkedList dll)
        {
            while (true)
            {
            
                Console.WriteLine("1. Insert at End");
                Console.WriteLine("2. Delete a Value");
                Console.WriteLine("3. Display List");
                Console.WriteLine("0. Back ");
                

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter value to insert: ");
                        int insertVal;
                        if (int.TryParse(Console.ReadLine(), out insertVal))
                            dll.InsertEnd(insertVal);
                        else
                            Console.WriteLine("Invalid input.");
                        break;
                    case 2:
                        Console.Write("Enter value to delete: ");
                        int deleteVal;
                        if (int.TryParse(Console.ReadLine(), out deleteVal))
                            dll.Delete(deleteVal);
                        else
                            Console.WriteLine("Invalid input.");
                        break;
                    case 3:
                        dll.Display();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void CircularLinkedListMenu(CircularLinkedList cll)
        {
            while (true)
            {
              
                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Delete a Value");
                Console.WriteLine("3. Display List");
                Console.WriteLine("0. Back");
              

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter value to insert: ");
                        int insertVal;
                        if (int.TryParse(Console.ReadLine(), out insertVal))
                            cll.InsertEnd(insertVal);
                        else
                            Console.WriteLine("Invalid input.");
                        break;
                    case 2:
                        Console.Write("Enter value to delete: ");
                        int deleteVal;
                        if (int.TryParse(Console.ReadLine(), out deleteVal))
                            cll.Delete(deleteVal);
                        else
                            Console.WriteLine("Invalid input.");
                        break;
                    case 3:
                        cll.Display();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
