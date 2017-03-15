using System;
using System.Collections.Generic;
using ExamenMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ExamenMVC.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private _Context context;
        public DbSet<Task> taskEntity;

        public TaskRepository(_Context context)
        {
            this.context = context;
            taskEntity = context.Set<Task>();
        }

        public void addTasks(List<Task> tasks)
        {
            foreach (var item in tasks)
            {
                var exits = taskEntity.Where(c => c.TaskName == item.TaskName).FirstOrDefault();

                if (exits == null)
                {
                    context.Entry(item).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
        }

        public void deleteTask(decimal employeeId)
        {
            var delete = taskEntity.Where(c => c.EmployeeId == employeeId).FirstOrDefault();

            if (delete != null)
            {
                taskEntity.Remove(delete);
                context.SaveChanges();
            }
        }
    }
}
