using EmployeeLinkedList.Models;

namespace EmployeeLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmployeeList<string> employeeList = new EmployeeList<string>();
            employeeList.AddEmployeetoNext("Sachin");
            employeeList.AddEmployeetoNext("Venkat");
            employeeList.AddEmployeetoNext("Akhilesh");
            employeeList.AddEmployeetoNext("Minu");

            employeeList.PrintList();

        }
       
    }
}
