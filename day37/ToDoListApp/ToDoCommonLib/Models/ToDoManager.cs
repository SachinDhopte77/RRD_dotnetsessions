using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoCommonLib.Models
{
    public class ToDoManager
    {
        private List<Todo> _todoLists = new List<Todo>();

        public List<Todo> TodoLists { get { return _todoLists; } }

        public List<Todo> AddtoTodoList(string task, string description, string taskPriority)
        {
            _todoLists.Add(new Todo { TaskName = task, TaskDescription = description, TaskPriority = taskPriority, TodoDate = DateTime.Now });
            return _todoLists;

        }

        public void DisplayTodoList(ToDoManager toDoManager)
        {

            for (int i = 0; i < TodoLists.Count; i++)
            {
                Console.WriteLine($"SR.No.{(i + 1).ToString()} || Task Name: {TodoLists[i].TaskName} || Task Discription: {TodoLists[i].TaskDescription}  || Task Priority: {TodoLists[i].TaskPriority} || Date : {TodoLists[i].TodoDate}");
            }
        }


    }
}
