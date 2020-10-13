using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ToDo.Api.DataAccess;
using ToDo.Api.DataModels.DbModels;
using ToDo.Api.Models;
using ToDo.Api.Services.Exceptions;
using ToDo.Api.Services.Interfaces;

namespace ToDo.Api.Services
{
    public class ToDoTaskService : IToDoTaskService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<ToDoTask> _todoRepository;

        public ToDoTaskService(IRepository<User> userRepository, IRepository<ToDoTask> todoRepository)
        {
            _userRepository = userRepository;
            _todoRepository = todoRepository;

        }
        public ToDoTaskModel GetTask(int id, int userId)
        {
            var toDoTask = _todoRepository.GetAll()
                 .FirstOrDefault(x => x.Id == id && x.UserId == userId);

            if(toDoTask == null)
            {
                throw new ToDoTaskException("No such task.");
            }

            return new ToDoTaskModel
            {
                TaskName = toDoTask.TaskName,
                TaskDescription = toDoTask.TaskDescription,
                TaskSchedule = toDoTask.TaskSchedule,
                IsComplete = toDoTask.IsComplete
            };
        }

        public IEnumerable<ToDoTaskModel> GetUserTodos(int userId)
        {
            return _todoRepository.GetAll()
                                  .Where(x => x.UserId == userId)
                                  .Select(x => new ToDoTaskModel
                                  {
                                      TaskName = x.TaskName,
                                      TaskDescription = x.TaskDescription,
                                      TaskSchedule = x.TaskSchedule,
                                      IsComplete = x.IsComplete
                                     
                                  });
        }

        public void AddTask(ToDoTaskModel request)
        {
            var user = _userRepository.GetAll()
               .FirstOrDefault(x => x.Id == request.UserId);

            if (user == null)
            {
                throw new ToDoTaskException("User does not exists.");
            }
            if(string.IsNullOrWhiteSpace(request.TaskName))
            {
                throw new ToDoTaskException("TaskName is required.");
            }
            if (string.IsNullOrWhiteSpace(request.TaskDescription))
            {
                throw new ToDoTaskException("Description is required.");
            }
            if (request.TaskSchedule == null)
            {
                throw new ToDoTaskException("Time Schedule is required");
            }

            var toDoTask = new ToDoTask
            {
                TaskName = request.TaskName,
                TaskDescription = request.TaskDescription,
                TaskSchedule = request.TaskSchedule
            };

            _todoRepository.Create(toDoTask);
        }

        public void DeleteTask(int id, int userId)
        {
            var toDoTask = _todoRepository.GetAll()
                 .FirstOrDefault(x => x.Id == id && x.UserId == userId);

            if (toDoTask == null)
            {
                throw new ToDoTaskException("No task with that Id.");
            }

            _todoRepository.Remove(toDoTask);
        }

    }
}
