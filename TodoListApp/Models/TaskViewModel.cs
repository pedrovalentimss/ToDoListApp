using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.Models
{
    public class TaskViewModel
    {
        public IEnumerable<TaskModel> Tasks { get; set; }
    }
}
