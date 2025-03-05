using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DSA_Solutions
{
    public class College
    {
       private List<Department> departments;
        public College()
        {
            departments = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }
        public void AddEmployee(string deptName, Employee employee)
        {
            var dept = departments.First(d => d.DeptName == deptName);
            if ((dept != null))
            {
                dept.AddEmployee(employee);

            }
            else
            {
                Console.WriteLine("Department not found");
            }


        }
        public void Display()
        {
            foreach (var dept in departments)
            {
                Console.WriteLine($"Department   {dept.DeptName}");
                foreach (var emp in dept.Employees)
                {
                    Console.WriteLine($"name {emp.name} ,email {emp.email} , PhoneNumber {emp.phonenumber}");

                }
            }

        }

        public void Display(string deptName)
        {
            var dept=departments.First();
            if (dept != null)
            {
                Console.WriteLine($"In department {deptName}");
                foreach(var emp in dept.Employees)
                {
                    Console.WriteLine($"{emp.name},{emp.email},{emp.phonenumber}");
                }
            }
        }

       public void Update(string deptName,string empName)
        {
            var dept=departments.First(d=>d.DeptName==deptName);
            if (dept != null)
            {
                var employee = dept.Employees.First(e => e.name.Equals(empName));
                if (employee != null) {
                    dept.Employees.Remove(employee);
                }

            }
        }
        public void Add (string deptName,Employee employee)
        {
            AddEmployee(deptName, employee);
        }
       
    }
}

