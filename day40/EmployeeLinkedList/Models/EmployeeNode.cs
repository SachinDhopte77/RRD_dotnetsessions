using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLinkedList.Models
{
    public class EmployeeNode<T>
    {
        public T Employee;
        public EmployeeNode<T> NextEmployee;

        public EmployeeNode(T employee)
        { 
         Employee = employee;
         NextEmployee = null;
        }

    }
}
