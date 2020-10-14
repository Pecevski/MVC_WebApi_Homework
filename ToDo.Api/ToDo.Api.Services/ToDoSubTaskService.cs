using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDo.Api.DataAccess;
using ToDo.Api.DataModels.DbModels;
using ToDo.Api.Models;
using ToDo.Api.Services.Exceptions;
using ToDo.Api.Services.Interfaces;

namespace ToDo.Api.Services
{
    public class ToDoSubTaskService : IToDoSubTaskService
    {
        private readonly IRepository<ToDoTask> _toDoRepository;
        private readonly IRepository<ToDoSubTask> _subTaskRepository;

        public ToDoSubTaskService(IRepository<ToDoTask> toDoRepository, IRepository<ToDoSubTask> subTaskRepository)
        {
            _toDoRepository = toDoRepository;
            _subTaskRepository = subTaskRepository;
        }
        public SubTaskModel GetSubTask(int id, int toDoId)
        {
            var subTask = _subTaskRepository.GetAll()
                                            .FirstOrDefault(x => x.Id == id && x.ToDoTaskId == toDoId);

            if (subTask == null)
            {
                throw new ToDoSubTaskExceptions("No such subtask.");
            }

            return new SubTaskModel
            {
                SubTaskName = subTask.SubTaskName,
                Description = subTask.Description,
                IsComplete = subTask.IsComplete
            };
        }

        public IEnumerable<SubTaskModel> GetTodoSubTasks(int toDoId)
        {
            return _subTaskRepository.GetAll().Where(x => x.ToDoTaskId == toDoId).Select(x => new SubTaskModel{SubTaskName = x.SubTaskName, Description = x.Description, IsComplete = x.IsComplete});
        }

        public void AddSubTask(SubTaskModel request)
        {
            var toDoTask = _toDoRepository.GetAll()
                 .FirstOrDefault(x => x.Id == request.ToDoTaskId);

            if (toDoTask == null)
            {
                throw new ToDoSubTaskExceptions("No such task.");
            }
            if (string.IsNullOrWhiteSpace(request.SubTaskName))
            {
                throw new ToDoSubTaskExceptions("SubTask name is required.");
            }
            if (string.IsNullOrWhiteSpace(request.Description))
            {
                throw new ToDoSubTaskExceptions("Description is required.");
            }

            var subTask = new ToDoSubTask
            {
                SubTaskName = request.SubTaskName,
                Description = request.Description

            };

            _subTaskRepository.Create(subTask);

        }

        public void DeleteSubTask(int id, int toDoId)
        {
            var subTask = _subTaskRepository.GetAll()
                                            .FirstOrDefault(x => x.Id == id && x.ToDoTaskId == toDoId);
            if(subTask == null)
            {
                throw new ToDoSubTaskExceptions("No subtask with that Id.");
            }

            _subTaskRepository.Remove(subTask);
        }

    }
}
