using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Api.DataAccess;
using ToDo.Api.DataAccess.EntityFramework;
using ToDo.Api.DataModels.DbModels;

namespace ToDo.Api.Services
{
    public class DiModule
    {
        public static IServiceCollection RegisterModule(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ToDosDbContext>(x =>
            x.UseSqlServer(connectionString));

            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<ToDoTask>, ToDoTaskRepository>();
            services.AddTransient<IRepository<ToDoSubTask>, ToDoSubTaskRepository>();

            return services;
        }
    }
}
