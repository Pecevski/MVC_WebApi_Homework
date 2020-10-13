using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Api.Models;

namespace ToDo.Api.Services.Interfaces
{
    public interface IToDoSubTaskService
    {
        IEnumerable<SubTaskModel> GetTodoSubTasks(int toDoId);
        SubTaskModel GetSubTask(int id, int toDoId);
        void AddSubTask(SubTaskModel request);
        void DeleteSubTask(int id, int toDoId);
    }
}
