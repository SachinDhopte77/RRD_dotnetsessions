using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoCommonLib.Models
{
    public class Todo
    {
        public DateTime TodoDate { get; set; }
        public string TaskPriority { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
    }
}
