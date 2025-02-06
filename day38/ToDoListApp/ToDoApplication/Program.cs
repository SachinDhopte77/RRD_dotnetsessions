using System.Text.Json;
using System.Xml.Serialization;
using ToDoCommonLib.Models;

namespace ToDoApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool closeApp = false;
            ToDoManager toDoManager = new ToDoManager();
            DisplayTodo(toDoManager);
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
                        StoreTodo(toDoManager);
                        DisplayTodoList(toDoManager);
                        
                    }
                    else
                        Console.WriteLine("ToDo List is Empty. Please update Todo List first");

                }
                else if (choice == 3)
                {
                    StoreTodo(toDoManager);
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
            var todoItem=toDoManager.AddtoTodoList(task, description, taskPriority);
            
            Console.WriteLine("Task Added Successfully");
        }

        private static void StoreTodo(ToDoManager toDoManager)
        {
             bool append=true;
             string filePath = "C:\\lIvesessionkoenig\\RRD\\C#.Net\\DataFile\\day38\\Data\\ToDo.json";
            //var todos = new Todo { TaskName = toDoManager.TodoLists[0].TaskName, TaskDescription = toDoManager.TodoLists[0].TaskDescription, TaskPriority = toDoManager.TodoLists[0].TaskPriority, TodoDate = toDoManager.TodoLists[0].TodoDate };
            
            foreach (var todo in toDoManager.TodoLists)
            {
                var jsonString = JsonSerializer.Serialize(todo);
                var sw = new StreamWriter(filePath, append);
                sw.WriteLine(jsonString);
                sw.Close();
               
            }
            Console.WriteLine("written to file");
            

        }
        private static void DisplayTodo(ToDoManager toDoManager)
        {

            
        }


    }
}
