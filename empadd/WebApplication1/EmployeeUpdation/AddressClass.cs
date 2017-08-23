using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeUpdation;

namespace Employee.PL
{
   
    public class AddressClass
    {
        public int Add_no = 7346;
        public string Street { get; set; }
        public string City { get; set; }
       // public string State { get; set; }
        public int Zipcode { get; set; }
        public StateTable state1 = new StateTable();


        public int AddressNo { get; set; }
    }
}
