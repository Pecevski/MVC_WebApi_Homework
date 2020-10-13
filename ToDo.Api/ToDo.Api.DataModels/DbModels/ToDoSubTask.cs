using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Api.DataModels.DbModels
{
    public class ToDoSubTask
    {
        public int Id { get; set; }
        public string SubTaskName { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }

        public int ToDoTaskId { get; set; }
        public ToDoTask ToDoTask { get; set; }
    }
}
