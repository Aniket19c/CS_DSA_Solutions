using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DSA_Solutions.Student
{
    public class StudentNode
    {
        public Student Data { get; set; }
        public StudentNode Next { get; set; }
        public StudentNode(Student data) {
            Data = data;
            Next = null;
        }

    }
}
