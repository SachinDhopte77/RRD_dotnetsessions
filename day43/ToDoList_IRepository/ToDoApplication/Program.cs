using ToDOListCommonLib.Models;
using ToDOListCommonLib.Repository;

namespace ToDoApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool closeApp = false;
            int choice1 = 1, choice2 = 2, choice3 = 3;
            //var ConnectionString = @"server=DESKTOP-7MAM3KF;userid=sachin;password=Pa$$w0rd;database=rrd_db";
             var ConnectionString = "server=DESKTOP-7MAM3KF\\SQLEXPRESS;database=TodoList_db;Integrated security=true;TrustServerCertificate=true";
            ToDoManager toDoManager = new ToDoManager();
            IToDoRepository toDoRepository = toDoManager.TodoRepository(RepositoryType.SqlRepository);
            Console.WriteLine("To Do Application");
            while (!closeApp)
            {               
                Console.WriteLine("Please Enter a Choice");
                Console.WriteLine("1. Add todo Task.");
                Console.WriteLine("2. Display todo Task.");
                Console.WriteLine("3. Exit Application");
               
                int choice = int.Parse(Console.ReadLine());

                if (choice == choice1)
                {
                    AddTodoTask(toDoRepository,ConnectionString);
                }
                else if (choice == choice2)
                {
                    int rowCount = toDoRepository.TaskCount(ConnectionString);
                    if (rowCount > 0)
                    {
                        DisplayTodoList(toDoRepository, ConnectionString);
                    }
                    else Console.WriteLine("ToDo List is empty");
                    

                }
                else if (choice == choice3)
                {
                    Console.WriteLine("Complete Your task on Time. Have a nice Day");
                    closeApp = true;
                }
               
                else { Console.WriteLine("Please enter a Correct choice"); }
            }

        }

        private static void DisplayTodoList(IToDoRepository toDoRepository, string connectionString)
        {
            var todoLists =toDoRepository.DisplayTodoList(connectionString);
            Console.WriteLine("Task Name | Task Description| Task Priority | Date");
            foreach (var todo in todoLists)
            {
                Console.WriteLine($"{todo.TaskName} | {todo.TaskDescription} | {todo.TaskPriority} | {todo.TodoDate}");
            }

        }

        private static void AddTodoTask(IToDoRepository toDoRepository,string ConnectionString)
        {
            Console.WriteLine("Enter Task: ");
            string task = Console.ReadLine();
            Console.WriteLine("Enter Task Description: ");
            string description = Console.ReadLine();
            Console.WriteLine("Enter Priority : 1. High 2. Medium 3. Low");
            string taskPriority = Console.ReadLine();
            toDoRepository.AddtoTodoList(task, description, taskPriority,ConnectionString);
            Console.WriteLine("Task Added Successfully");
        }
    }
 }

