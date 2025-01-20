using EmployeeAppUsingStatic.Models;

namespace EmployeeAppUsingStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Sachin");

            Employee employee2 = new Employee("Venkat");

            Employee employee3 = new Employee("Akhilesh");


            Console.WriteLine($"Name {employee1.EmployeeName} employee Id : {employee1.EmployeeID} ");
            Console.WriteLine($"Name {employee2.EmployeeName} employee Id : {employee2.EmployeeID} ");
            Console.WriteLine($"Name {employee1.EmployeeName} employee Id : {employee1.EmployeeID} ");
            Console.WriteLine($"Name {employee3.EmployeeName} employee Id : {employee3.EmployeeID} ");
            Console.WriteLine($"Name {employee1.EmployeeName} employee Id : {employee1.EmployeeID} ");

        }
    }
}
