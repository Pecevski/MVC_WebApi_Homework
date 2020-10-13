using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Api.DataModels.DbModels;

namespace ToDo.Api.DataAccess.EntityFramework
{
    public class ToDoTaskRepository : IRepository<ToDoTask>
    {
        private readonly ToDosDbContext _context;

        public ToDoTaskRepository(ToDosDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ToDoTask> GetAll()
        {
            return _context.ToDoTasks;
        }

        public void Create(ToDoTask entity)
        {
            _context.ToDoTasks.Add(entity);
            _context.SaveChanges();
        }

        public void Update(ToDoTask entity)
        {
            _context.ToDoTasks.Update(entity);
            _context.SaveChanges();
        }
        public void Remove(ToDoTask entity)
        {
            _context.ToDoTasks.Remove(entity);
            _context.SaveChanges();
        }
    }
}
