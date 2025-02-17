using IteratorDesignPattern.Models;

namespace IteratorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeCollection collection = new EmployeeCollection();
            collection.AddEmployee(new Employee("Sachin", 100));
            collection.AddEmployee(new Employee("Venkat", 101));
            collection.AddEmployee(new Employee("Akhilesh", 102));
            collection.AddEmployee(new Employee("Minu", 103));
            collection.AddEmployee(new Employee("Markanda", 104));
           

            // Create iterator
            Iterator iterator = collection.CreateIterator();
            //looping iterator      
            Console.WriteLine("Iterating over collection:");

            for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
            }
          
        }
    }
}
/*The Iterator Design Pattern is a Behavioral Design Pattern that allows sequential access to the elements 
 * of an aggregate object (i.e., collection) without exposing its underlying representation. 
 * That means using the Iterator Design Pattern, we can access the elements of a collection sequentially 
 * without knowing its internal representations. This pattern provides a uniform interface for traversing 
 * different data structures.
*/