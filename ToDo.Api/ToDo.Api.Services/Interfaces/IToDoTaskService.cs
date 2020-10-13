using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Api.Models;

namespace ToDo.Api.Services.Interfaces
{
    public interface IToDoTaskService
    {
        IEnumerable<ToDoTaskModel> GetUserTodos(int userId);
        ToDoTaskModel GetTask(int id, int userId);
        void AddTask(ToDoTaskModel request);
        void DeleteTask(int id, int userId);
    }
}
