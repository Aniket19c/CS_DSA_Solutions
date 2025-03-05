using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DSA_Solutions
{
    public class Employee
    {
        public int empid { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }

      public  Employee(int empid,string name,string email,string phonenumber)
        {
            this.empid = empid;
            this.name = name;
            this.email = email;
            this.phonenumber=phonenumber;
        }
       
    }
}
