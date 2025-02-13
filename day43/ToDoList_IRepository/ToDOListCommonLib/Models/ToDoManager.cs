using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDOListCommonLib.Repository;

namespace ToDOListCommonLib.Models
{
    public class ToDoManager
    {
        private List<Todo> _todoLists = new List<Todo>();
             
        public List<Todo> TodoLists { get { return _todoLists; } }
       

        public IToDoRepository TodoRepository(RepositoryType repositoryType)
        {
           
            if (repositoryType == RepositoryType.SqlRepository)
            {
                return new SqlRepository();
            }

            
                return new MySqlRepository();    
           
       
        }
       
    }
}
