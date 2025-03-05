using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DSA_Solutions
{
    public class Department
    {
       public int DeptId { get; set; }
        public string DeptName { get; set; }
        public List<Employee> Employees { get; set; }

      public  Department(int deptId, string deptName)
        {
            DeptId=deptId;
            DeptName = deptName;
            Employees=new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}
