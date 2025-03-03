using System;
using CS_DSA_Solutions.Student;

namespace CS_DSA_Solutions
{
    class Program
    {
        static void Main()
        {
            DoublyLinkedList dll = new DoublyLinkedList();
            CircularLinkedList cll = new CircularLinkedList();
            SinglyLinkedList sll= new SinglyLinkedList();

            StudentManager studentManager = new StudentManager();


            while (true)
            {
                
                Console.WriteLine("1. Doubly Linked List");
                Console.WriteLine("2. Circular Linked List");
                Console.WriteLine("3. Singly Linked List");
                Console.WriteLine("4. Student Management");
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
                    case 3:
                        SinglyLinkedListMenu(sll);
                        break;
                    case 4:
                        StudentMenu(studentManager);
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
                Console.WriteLine("4. Add at particular index");
                Console.WriteLine("5. Remove from index");
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
                    case 4:
                        Console.WriteLine("Enter the index where you want to add");
                        int ind;
                        if (int.TryParse(Console.ReadLine(), out ind)) 
                        Console.WriteLine("Enter the data you want to add");
                        int data;
                        if(int.TryParse(Console.ReadLine(), out data));
                        dll.InsertAt(ind, data);
                        break;
                    case 5:
                        Console.WriteLine("Enter the index you want to delete");
                        int rInd;
                        if (int.TryParse(Console.ReadLine(), out rInd))
                            dll.RemoveAt(rInd);
                        else
                            Console.WriteLine("Invalid Input");
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void SinglyLinkedListMenu(SinglyLinkedList sll)
        {
            while (true)
            {

                Console.WriteLine("1. Insert at End");
                Console.WriteLine("2. Delete a Value");
                Console.WriteLine("3. Display List");
                Console.WriteLine("4. Add at particular index");
                Console.WriteLine("5. Remove from index");
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
                            sll.InsertEnd(insertVal);
                        else
                            Console.WriteLine("Invalid input.");
                        break;
                    case 2:
                        Console.Write("Enter value to delete: ");
                        int deleteVal;
                        if (int.TryParse(Console.ReadLine(), out deleteVal))
                            sll.Delete(deleteVal);
                        else
                            Console.WriteLine("Invalid input.");
                        break;
                    case 3:
                        sll.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the index where you want to add");
                        int ind;
                        if (int.TryParse(Console.ReadLine(), out ind))
                            Console.WriteLine("Enter the data you want to add");
                        int data;
                        if (int.TryParse(Console.ReadLine(), out data)) ;
                        sll.InsertAt(ind, data);
                        break;
                    case 5:
                        Console.WriteLine("Enter the index you want to delete");
                        int rInd;
                        if (int.TryParse(Console.ReadLine(), out rInd))
                            sll.RemoveAt(rInd);
                        else
                            Console.WriteLine("Invalid Input");
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
        static void StudentMenu(StudentManager studentManager)
        {
            while (true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. Display Students");
                Console.WriteLine("0. Back");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter student ID: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            //studentManager.AddStudent(new Student(id, name));
                            studentManager.AddStudent(new CS_DSA_Solutions.Student.Student(id, name));

                        }
                        else
                        {
                            Console.WriteLine("Invalid ID format.");
                        }
                        break;
                    case 2:
                        Console.Write("Enter student ID to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int removeId))
                        {
                            studentManager.RemoveStudent(removeId);
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID format.");
                        }
                        break;
                    case 3:
                        studentManager.DisplayStudents();
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
