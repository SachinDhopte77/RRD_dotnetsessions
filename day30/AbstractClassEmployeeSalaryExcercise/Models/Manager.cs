using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEmployeeSalaryExcercise.Models
{
    internal class Manager : Employee
    {
        private double _employeeHouserentallownce;
        private double _employeeTravellingallownce;
        private double _employeeSalary;
        private const double EmployeeHouserentAllowncePercentage = .50;
        private const double EmployeeTravellingAllowncePercentage = .10;
        private const int NoOfmonth = 12;

        public Manager(int empID, string empName, double empSalary) : base(empID, empName, empSalary)
        {

        }


        public override IEnumerable<KeyValuePair<string, string>> EmployeeSalary()
        {
            _employeeHouserentallownce = _empBasicpay * EmployeeHouserentAllowncePercentage;
            _employeeTravellingallownce = _empBasicpay * EmployeeTravellingAllowncePercentage;
            _employeeSalary = (_employeeHouserentallownce + _employeeTravellingallownce + _empBasicpay) * NoOfmonth;
            var employeeDetail = new KeyValuePair<string, string>("Employee Type : Manager || ", $"Employee Name: {_empName}");
            var employeeHouserentallownce = new KeyValuePair<string, string>("House Rent Allownce  : ", _employeeHouserentallownce.ToString());
            var employeeTravellingallownce = new KeyValuePair<string, string>("Travelling Allownce : ", _employeeTravellingallownce.ToString());
            var employeeSalary = new KeyValuePair<string, string>("Employee Payable Annual Salary : ", _employeeSalary.ToString());

            var managerSalarystructure = new List<KeyValuePair<string, string>> { employeeDetail, employeeHouserentallownce, employeeTravellingallownce, employeeSalary };
            return managerSalarystructure;

        }

    }
}
