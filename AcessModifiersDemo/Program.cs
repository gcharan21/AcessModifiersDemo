using MyBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { Id = 101, Name= "Guru charan" };
            Console.WriteLine(employee);

        }
    }
}
