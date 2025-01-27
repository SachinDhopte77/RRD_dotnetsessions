using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEmployeeSalaryExcercise.Models
{
    internal class Developer : Employee
    {

        private double _employeePerformancebonus;
        private double _employeeSalary;
        private const double PerformanceBonusPercentage = .40;
        private const int NoOfmonth = 12;
        public Developer(int empID, string empName, double empSalary) : base(empID, empName, empSalary)
        {


        }

        public override IEnumerable<KeyValuePair<string, string>> EmployeeSalary()
        {
            _employeePerformancebonus = _empBasicpay * PerformanceBonusPercentage;
            _employeeSalary = (_empBasicpay + _employeePerformancebonus) * NoOfmonth;
            var employeeDetail = new KeyValuePair<string, string>("Employee Type : Developer || ", $"Employee Name: {_empName}");
            var performanceBonus = new KeyValuePair<string, string>("Performance Bonus : ", _employeePerformancebonus.ToString());
            var employeeSalary = new KeyValuePair<string, string>("Employee Payable Annual Salary : ", _employeeSalary.ToString());

            var devloperSalarystructure = new List<KeyValuePair<string, string>> { employeeDetail, performanceBonus, employeeSalary };
            return devloperSalarystructure;

        }
    }
}
