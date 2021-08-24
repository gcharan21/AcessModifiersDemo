using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBusinessLogic
{

    internal class Address
    {
       
        public string street { get; set; }
        public string City { get; set; }
        public int  Pincode { get; set; }
    }
    public class Employee

    { 
            public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
           return $"{Id }{Name }";
        }

    }
    
}
