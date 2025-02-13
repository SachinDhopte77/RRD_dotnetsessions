using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ToDOListCommonLib.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ToDOListCommonLib.Repository
{
    internal class MySqlRepository : IToDoRepository
    {
        public void AddtoTodoList(string taskvalue, string descriptionvalue, string taskPriorityvalue, string ConnectionString)
        {
            var date = DateTime.Now;
            string MysqlQuery = "INSERT INTO todolist_db (task, taskdescription,taskPriority,TodoDate) VALUES (@value1, @value2,@value3,@value4)";
            using var con = new MySqlConnection(ConnectionString) ;
            con.Open();
            using var cmd = new MySqlCommand(MysqlQuery, con);
            cmd.Parameters.AddWithValue("@value1", taskvalue);
            cmd.Parameters.AddWithValue("@value2", descriptionvalue);
            cmd.Parameters.AddWithValue("@value3", taskPriorityvalue);
            cmd.Parameters.AddWithValue("@Value4", date.ToShortDateString());
            cmd.ExecuteNonQuery();
            
        }

        public List<Todo> DisplayTodoList(string ConnectionString)
        {
            using var con = new MySqlConnection(ConnectionString);            
            string sql = "SELECT * FROM todolist_db";
            con.Open();
            using var cmd = new MySqlCommand(sql, con);
            using MySqlDataReader reader = cmd.ExecuteReader();
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
            using var con = new MySqlConnection(ConnectionString);
            string sql = "SELECT COUNT(*) FROM todolist_db";
            con.Open();
            using var cmd = new MySqlCommand(sql, con);
            count = int.Parse(cmd.ExecuteScalar().ToString());           
            con.Close();           
            return count;
        }
    }
}
