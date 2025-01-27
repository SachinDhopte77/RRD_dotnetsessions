using AbstractClassEmployeeSalaryExcercise.Models;
using System.ComponentModel.DataAnnotations;

namespace AbstractClassEmployeeSalaryExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee developer1 = new Developer(1001, "Sachin", 60000);

            PrintSalarySlip(developer1.EmployeeSalary());

            Employee manager1 = new Manager(1002, "Akhilesh", 100000);

            PrintSalarySlip(manager1.EmployeeSalary());

        }

        private static void PrintSalarySlip(IEnumerable<KeyValuePair<string, string>> employee)
        {
            Console.WriteLine("Salary Slip Detail :");
            foreach (KeyValuePair<string, string> keyvaluepair in employee)
            {
                Console.WriteLine($"{keyvaluepair.Key} {keyvaluepair.Value}");
            }
        }
    }
}
