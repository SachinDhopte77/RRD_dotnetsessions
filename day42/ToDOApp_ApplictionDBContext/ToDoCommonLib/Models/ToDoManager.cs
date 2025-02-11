using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

namespace ToDoCommonLib.Models
{
    public class ToDoManager
    {
        private List<Todo> _todoLists = new List<Todo>();
        public List<Todo> TodoLists { get { return _todoLists; } }

        // private readonly string _dbcontext;
        //public ToDoManager()
        //{
        //    _dbcontext = "Data Source=DESKTOP-7MAM3KF\\SQLEXPRESS;Initial Catalog=TodoList_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //}


        public void AddtoTodoList(string task, string description, string taskPriority)
        {
            var date= DateTime.Now;
            var connectionString = "Data Source=DESKTOP-7MAM3KF\\SQLEXPRESS;Initial Catalog=TodoList_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("insert into " + "ToDoList" + "(task, taskdescription, taskPriority,TodoDate)values("+ "'"+task+ "'" + ","+ "'"+description+ "'" + ","+ "'"+ taskPriority+ "'" + ","+ "'" + date.ToShortDateString()+ "'"+")", con);
            con.Open();
            var reader = cmd.ExecuteNonQuery();
            Console.WriteLine("Database updated with insertion");
            con.Close();
            // _todoLists.Add(new Todo { TaskName = task, TaskDescription = description, TaskPriority = taskPriority, TodoDate = DateTime.Now });
            // return _todoLists;

        }

        public void DisplayTodoList()
        {
            
            var connectionString = "Data Source=DESKTOP-7MAM3KF\\SQLEXPRESS;Initial Catalog=TodoList_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("select * from" + " ToDoList", con);
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["task"] + "|" + reader["taskdescription"]+"|"+ reader["taskPriority"]+"|"+ reader["TodoDate"]);
                            }
            con.Close();
        }

        public void DeleteTodoList(int id)
        {
            var connectionString = "Data Source=DESKTOP-7MAM3KF\\SQLEXPRESS;Initial Catalog=TodoList_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("delete ToDoList where id="+id, con);
            con.Open();
            var reader = cmd.ExecuteNonQuery();
            Console.WriteLine("Records Deleted");
            con.Close();

        }

        public void UpdateTodoList(int id, string task, string description, string taskPriority)
        {
            var date = DateTime.Now;
            var connectionString = "Data Source=DESKTOP-7MAM3KF\\SQLEXPRESS;Initial Catalog=TodoList_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("update ToDoList set" + "task="+"'"+task+"'"+","+ "taskdescription="+"'"+description+"'"+","+ "taskPriority="+"'"+taskPriority+"'"+","+ "TodoDate="+"'"+date+"'" + "where id=" + id, con);
            con.Open();
            var reader = cmd.ExecuteNonQuery();
            Console.WriteLine("Records Deleted");
            con.Close();

        }
    }
}
