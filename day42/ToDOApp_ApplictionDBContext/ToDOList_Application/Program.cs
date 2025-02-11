using System;
using ToDoCommonLib.Models;

namespace ToDOList_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool closeApp = false;
            int choice1=1, choice2=2, choice3=3,choice4=4;
            ToDoManager toDoManager = new ToDoManager();
            Console.WriteLine("To Do Application");
            while (!closeApp)
            {

                Console.WriteLine("Please Enter a Choice");
                Console.WriteLine("1. Add todo Task.");
                Console.WriteLine("2. Display todo Task.");
                Console.WriteLine("3. Exit Application");
                Console.WriteLine("4. Update todo Task");

                int choice = int.Parse(Console.ReadLine());

                if (choice == choice1)
                {
                    AddTodoTask(toDoManager);
                }
                else if (choice == choice2)
                {
                    
                        DisplayTodoList(toDoManager);
                   
                       // Console.WriteLine("ToDo List is Empty. Please update Todo List first");

                }
                else if (choice == choice3)
                {
                    Console.WriteLine("Complete Your task on Time. Have a nice Day");
                    closeApp = true;
                }
                else if(choice==choice4)
                {
                    Console.WriteLine("Enter Id to update task: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Task: ");
                    string task = Console.ReadLine();
                    Console.WriteLine("Enter Task Description: ");
                    string description = Console.ReadLine();
                    Console.WriteLine("Enter Priority : 1. High 2. Medium 3. Low");
                    string taskPriority = Console.ReadLine();
                    toDoManager.UpdateTodoList(id, task, description, taskPriority);

                }
                else { Console.WriteLine("Please enter a Correct choice"); }
            }

        }

        private static void DisplayTodoList(ToDoManager toDoManager)
        {
            Console.WriteLine("Todays Todo Lists:");
            toDoManager.DisplayTodoList();
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
