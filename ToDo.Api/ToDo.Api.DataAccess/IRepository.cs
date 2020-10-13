using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Api.DataAccess
{
    public interface IRepository<T>
    {

        IEnumerable<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
