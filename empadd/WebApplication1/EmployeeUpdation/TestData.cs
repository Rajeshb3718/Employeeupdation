using Employee.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeUpdation
{
    public class TestData
    {
        public static EmployeeClass getEmployee()
        {
            EmployeeClass emp = new EmployeeClass();
            emp.Name = "Mary";
            emp.Salary = 4500;
            emp.DeptNo = 30;
            emp.Comm = 250;
            emp.HireDate = Convert.ToDateTime("11-11-2016");
            emp.Empno = 4321;
            emp.dept.Deptname = "Accounting";
            emp.dept.Deptlocation = "New york";
            AddressClass add1 = new AddressClass();
            add1.City = "Manassas";
            add1.Street = "7354 Wichita Ct";
            add1.Zipcode = 22012;
            add1.AddressNo = 1;
            add1.state1.Id= 1;
            add1.state1.Code = "VA";
            add1.state1.Name = "Virginia";
            AddressClass add2 = new AddressClass();
            add2.City = "Chantilly";
            add2.Street = "4222 MSudley Rd";
            add2.Zipcode = 20152;
            add2.AddressNo = 2;
            add2.state1.Id = 2;
            add2.state1.Code = "MD";
            add2.state1.Name = "Maryland";
            emp.Addresses.Add(add1);
            emp.Addresses.Add(add2);
            return emp;
        }
    }
}