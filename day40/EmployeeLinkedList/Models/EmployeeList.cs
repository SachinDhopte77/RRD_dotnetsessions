using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLinkedList.Models
{
    public class EmployeeList<T>
    {
        int count;
        EmployeeNode<T> head;//it will referencing to begining of linklist

        public EmployeeList()
        {
            head = null;
            count = 0;
        }
          

        //public void AddEmployeetoFront(T node)
        //{ 
        // EmployeeNode<T> employeeNode= new EmployeeNode<T>(node);
        // employeeNode.NextEmployee=head;//new node sit onfront 
        // head = employeeNode; //head reference to new node
        // count++;
        //}

        public void AddEmployeetoNext(T node)
        {
            EmployeeNode<T> employeeNode = new EmployeeNode<T>(node);
            if(head == null)
            {
                head = employeeNode;
                return;
            }
            EmployeeNode<T> employeeLastNode = GetLastNode();
            employeeLastNode.NextEmployee=employeeNode;
        }

        public EmployeeNode<T> GetLastNode()
        {
            EmployeeNode<T> employeeNode= head;
            while(employeeNode.NextEmployee != null)
            {
                employeeNode = employeeNode.NextEmployee;
            }
            return employeeNode;
        }

        public void PrintList()
        { 
         EmployeeNode<T> runner=head;
            while (runner != null)
            { 
             Console.WriteLine(runner.Employee);
             runner = runner.NextEmployee;
            }
        }
    }
}
