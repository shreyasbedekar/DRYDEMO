using DRYDemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Name: ");
            string firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastname = Console.ReadLine();

            EmployeeProcessor employeeProcessor = new EmployeeProcessor();
            string employeeID = employeeProcessor.GenerateEmployeeId(firstname, lastname);

            Console.WriteLine($"Employee ID: {employeeID}");
            Console.ReadLine();
        }
    }
}
