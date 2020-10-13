using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ToDo.Api.DataModels.DbModels
{
    public class ToDosDbContext : DbContext
    {
        public ToDosDbContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<ToDoTask> ToDoTasks { get; set; }
        public DbSet<ToDoSubTask> ToDoSubTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // USER
            modelBuilder
                .Entity<User>()
                .ToTable(nameof(User))
                .HasKey(p => p.Id);

            modelBuilder
                .Entity<User>()
                .Property(p => p.UserName)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder
                .Entity<User>()
                .Property(p => p.Password)
                .HasMaxLength(100)
                .IsRequired();

            // ToDoTask

            modelBuilder
                .Entity<ToDoTask>()
                .ToTable(nameof(ToDoTask))
                .HasKey(t => t.Id);

            modelBuilder
                .Entity<ToDoTask>()
                .Property(t => t.TaskName)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder
                .Entity<ToDoTask>()
                .Property(t => t.TaskDescription)
                .HasMaxLength(200)
                .IsRequired();

            modelBuilder
                .Entity<ToDoTask>()
                .Property(t => t.TaskSchedule)
                .HasDefaultValue();

            modelBuilder
                .Entity<ToDoTask>()
                .HasOne(t => t.User)
                .WithMany(t => t.ToDoTasks)
                .HasForeignKey(t => t.UserId);

            // ToDo SubTask

            modelBuilder
                .Entity<ToDoSubTask>()
                .ToTable(nameof(ToDoSubTask))
                .HasKey(s => s.Id);

            modelBuilder
                .Entity<ToDoSubTask>()
                .Property(s => s.SubTaskName)
                .HasMaxLength(100);

            modelBuilder
                .Entity<ToDoSubTask>()
                .Property(s => s.Description)
                .HasMaxLength(200);

            modelBuilder
                .Entity<ToDoSubTask>()
                .HasOne(s => s.ToDoTask)
                .WithMany(s => s.ToDoSubTasks)
                .HasForeignKey(s => s.ToDoTaskId);

            base.OnModelCreating(modelBuilder);
            Seed(modelBuilder);
        }

        public void Seed(ModelBuilder modelBuilder)
        {
            var md5 = new MD5CryptoServiceProvider();
            var md5data = md5.ComputeHash(Encoding.ASCII.GetBytes("136905pass"));
            var hashedPassword = Encoding.ASCII.GetString(md5data);

            modelBuilder.Entity<User>()
               .HasData(
               new User()
               {
                   Id = 1,
                   FullName = "Ilija Pecevski",
                   UserName = "pecevski",
                   Password = hashedPassword
               }
               );
            modelBuilder.Entity<ToDoTask>()
                .HasData(
                new ToDoTask()
                {
                    Id = 1,
                    TaskName = "Homework",
                    TaskDescription = "To build a service for TODO List",
                    TaskSchedule = new DateTime(2020, 10, 05),
                    UserId = 1
                },
                new ToDoTask()
                {
                    Id = 2,
                    TaskName = "Relaxing time",
                    TaskDescription = "Watch the soccer game between Macedonia and Kosovo",
                    TaskSchedule = new DateTime(2020, 10, 08),
                    UserId = 1
                },
                new ToDoTask()
                {
                    Id = 3,
                    TaskName = "Studing",
                    TaskDescription = "Study Entity Framework, ADO.Net and Dapper",
                    TaskSchedule = new DateTime(2020, 10, 09),
                    UserId = 1
                }
                );
            modelBuilder.Entity<ToDoSubTask>()
                .HasData(
                new ToDoSubTask()
                {
                    Id = 1,
                    SubTaskName = "Entity Framework",
                    Description = "Study Entity Framework",
                    ToDoTaskId = 3
                },
                new ToDoSubTask()
                {
                    Id = 2,
                    SubTaskName = "ADO.Net",
                    Description = "Study ADO.Net",
                    ToDoTaskId = 3
                },
                new ToDoSubTask()
                {
                    Id = 3,
                    SubTaskName = "Dapper",
                    Description = "Study Dapper",
                    ToDoTaskId = 3
                }
                );
        }

    }
}
