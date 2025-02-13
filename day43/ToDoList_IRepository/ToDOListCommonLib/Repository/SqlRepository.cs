using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDOListCommonLib.Models;

namespace ToDOListCommonLib.Repository
{
    internal class SqlRepository : IToDoRepository
    {
        
        public void AddtoTodoList(string task, string description, string taskPriority, string ConnectionString)
        {
            var date = DateTime.Now;
            var con = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand("insert into " + "ToDoList" + "(task, taskdescription, taskPriority,TodoDate)values(" + "'" + task + "'" + "," + "'" + description + "'" + "," + "'" + taskPriority + "'" + "," + "'" + date.ToShortDateString() + "'" + ")", con);
            con.Open();
            var reader = cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Todo> DisplayTodoList(string ConnectionString)
        {
            var myTodoList = new List<string>();
            var con = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand("select * from" + " ToDoList", con);
            con.Open();           
            var reader = cmd.ExecuteReader();
            List<Todo> todoList = new List<Todo>();
            while (reader.Read())
            {
                todoList.Add(new Todo()
                {
                    TaskName = (string)reader["task"],
                    TaskDescription = (string)reader["taskdescription"],
                    TaskPriority = (string)reader["taskPriority"],
                    TodoDate = (string)reader["TodoDate"]
                }
                ); 
            }
            con.Close();
            return todoList;
        }

        public int TaskCount(string ConnectionString)
        {
            int count = 0;
            var con = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand("SELECT COUNT(*) FROM" + " ToDoList", con);            
            con.Open();
            count = (int)cmd.ExecuteScalar();
            return count;
        }
    }
}
