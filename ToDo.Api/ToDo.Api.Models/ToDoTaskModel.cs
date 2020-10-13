using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Api.Models
{
    public class ToDoTaskModel
    {
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskSchedule { get; set; } = DateTime.Now;
        public bool IsComplete { get; set; }

        public int UserId { get; set; }
    }
}
