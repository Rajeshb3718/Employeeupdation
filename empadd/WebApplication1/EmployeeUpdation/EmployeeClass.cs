using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.PL
{
    public class EmployeeClass
    {
        public int Salary { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
       public DeptClass dept = new DeptClass();
        public List<AddressClass> Addresses = new List<AddressClass>();


        public DateTime HireDate { get; set; }

        public int Comm { get; set; }

        public int DeptNo { get; set; }

        public int Empno { get; set; }
    }
}