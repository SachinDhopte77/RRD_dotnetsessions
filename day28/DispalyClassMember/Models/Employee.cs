using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispalyClassMember.Models
{
    internal class Employee
    {
        private readonly string _empName;
        private readonly string _empID;
        private static int _employeeCounter;

        static Employee()
        { _employeeCounter = 1000; }

        public Employee(string empName)
        {
            _employeeCounter++;
            _empName = empName;
            _empID = "E" + _employeeCounter.ToString();

        }

        public string EmployeeName { get { return _empName; } }

        public string EmployeeID { get { return _empID; } }

        public static int EmployeeCounter { get { return _employeeCounter; } }


    }
}
