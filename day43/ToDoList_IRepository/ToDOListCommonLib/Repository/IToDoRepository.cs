using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDOListCommonLib.Models;

namespace ToDOListCommonLib.Repository
{
    public interface IToDoRepository
    {
        void AddtoTodoList(string task, string description, string taskPriority, string ConnectionString);
        List<Todo> DisplayTodoList(string ConnectionString);

        int TaskCount(string ConnectionString);
    }
}
