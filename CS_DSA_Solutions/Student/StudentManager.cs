namespace CS_DSA_Solutions.Student
{
    public class StudentManager
    {
        private StudentLinkedList studentList = new StudentLinkedList();

        public void AddStudent(Student student)
        {
            studentList.add(student);
            Console.WriteLine("Student added successfully.");
        }

        public void RemoveStudent(int id)
        {
            if (studentList.remove(id))
                Console.WriteLine("Student removed successfully.");
            else
                Console.WriteLine("Student not found.");
        }

        public void DisplayStudents()
        {
            Console.WriteLine("Student List:");
            studentList.display();
        }
    }
}
