using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEmployeeSalaryExcercise.Models
{
    internal abstract class Employee
    {
        private readonly int _empID;
        protected readonly string _empName;
        protected readonly double _empBasicpay;

        public Employee(int empID, string empName, double empSalary)
        {
            _empID = empID;
            _empName = empName;
            _empBasicpay = empSalary;
        }

        public int EmployeeID { get { return _empID; } }

        public string EmployeeName { get { return _empName; } }

        public double EmployeeBasicPay { get { return _empBasicpay; } }

        public abstract IEnumerable<KeyValuePair<string, string>> EmployeeSalary();

    }
}
