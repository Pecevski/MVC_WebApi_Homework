using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Api.Models
{
    public class SubTaskModel
    {
        public string SubTaskName { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }

        public int ToDoTaskId { get; set; }
    }
}
