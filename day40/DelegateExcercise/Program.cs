using DelegateExcercise.Models;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DelegateExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empl = new List<Employee>();
            empl.Add(new Employee() { ID = 101, Name = "Sachin", salary = 20000, Experiance = 3 });
            empl.Add(new Employee() { ID = 102, Name = "Venkat", salary = 30000, Experiance = 5 });
            empl.Add(new Employee() { ID = 103, Name = "Minu", salary = 50000, Experiance = 8 });
            empl.Add(new Employee() { ID = 104, Name = "Prem", salary = 10000, Experiance = 2 });

            isPromote pro = new isPromote(promote);
            Employee.PromoteEmp(empl, pro);
        }
        public static bool promote(Employee emp)
        {
            if (emp.Experiance >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
/*delegate?
It is a reference type.
It is a function pointer or it holds a reference (pointer) to a function (method).
It is type safe.
Delegates are mainly used for the event handling and the callback methods.
Unicast deligate : This delegate refers to only one method,
Multicast deligate : his delegate can refer to more than one method. This delegate maintains a list of the methods.
An instance of a delegate can refer to static as well as instance methods. 
The signature of function declaration and the delegate declaration should match.*/
