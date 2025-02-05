using ToDoCommonLib.Models;

namespace ToDoApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool closeApp = false;
            ToDoManager toDoManager = new ToDoManager();
            Console.WriteLine("To Do Application");
            while (!closeApp)
            {

                Console.WriteLine("Please Enter a Choice");
                Console.WriteLine("1. Add todo Task.");
                Console.WriteLine("2. Display todo Task.");
                Console.WriteLine("3. Exit Application");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    AddTodoTask(toDoManager);
                }
                else if (choice == 2)
                {
                    if (toDoManager.TodoLists.Count > 0)
                    {
                        DisplayTodoList(toDoManager);
                    }
                    else
                        Console.WriteLine("ToDo List is Empty. Please update Todo List first");

                }
                else if (choice == 3)
                {
                    Console.WriteLine("Complete Your task on Time. Have a nice Day");
                    closeApp = true;
                }
                else { Console.WriteLine("Please enter a Correct choice"); }
            }

        }

        private static void DisplayTodoList(ToDoManager toDoManager)
        {
            Console.WriteLine("Todays Todo Lists:");
            toDoManager.DisplayTodoList(toDoManager);
        }

        private static void AddTodoTask(ToDoManager toDoManager)
        {
            Console.WriteLine("Enter Task: ");
            string task = Console.ReadLine();
            Console.WriteLine("Enter Task Description: ");
            string description = Console.ReadLine();
            Console.WriteLine("Enter Priority : 1. High 2. Medium 3. Low");
            string taskPriority = Console.ReadLine();
            toDoManager.AddtoTodoList(task, description, taskPriority);
            Console.WriteLine("Task Added Successfully");
        }


    }
}
