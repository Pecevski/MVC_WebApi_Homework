using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Api.DataModels.DbModels
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskSchedule { get; set; } = DateTime.Now;
        public bool IsComplete { get; set; }
        public List<ToDoSubTask> ToDoSubTasks { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
