using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Api.DataModels.DbModels;

namespace ToDo.Api.DataAccess.EntityFramework
{
    public class ToDoSubTaskRepository : IRepository<ToDoSubTask>
    {
        private readonly ToDosDbContext _context;

        public ToDoSubTaskRepository(ToDosDbContext context)
        {
            _context = context;
        }
        public IEnumerable<ToDoSubTask> GetAll()
        {
            return _context.ToDoSubTasks;
        }
        public void Create(ToDoSubTask entity)
        {
            _context.ToDoSubTasks.Add(entity);
            _context.SaveChanges();
        }

        public void Update(ToDoSubTask entity)
        {
            _context.ToDoSubTasks.Update(entity);
            _context.SaveChanges();
        }
        public void Remove(ToDoSubTask entity)
        {
            _context.ToDoSubTasks.Remove(entity);
            _context.SaveChanges();
        }

    }
}
