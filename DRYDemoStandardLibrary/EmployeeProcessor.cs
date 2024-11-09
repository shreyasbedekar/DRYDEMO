using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRYDemoStandardLibrary
{
    public class EmployeeProcessor
    {
        public string GenerateEmployeeId(string firstname, string lastname)
        {
            Random random = new Random();
            string employeeId = $"{GetPartofName(firstname, 4)}{GetPartofName(lastname, 4)}{random.Next(100, 999)}";
            return employeeId;
        }
        private string GetPartofName(string name, int numberOfCharcaters)
        {
            string output = name;
            if (name.Length > numberOfCharcaters)
            {
                output = name.Substring(0, numberOfCharcaters);
            }
            else
            {
                do
                {
                    output += "X";
                } while (output.Length < 4);
            }
            return output;
        }
    }
}
