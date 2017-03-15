using ExamenMVC.Models;
using System;
using System.Collections.Generic;

namespace ExamenMVC.Repositories
{
    public interface ITaskRepository
    {
        void addTasks(List<Task> tasks);
        void deleteTask(decimal employeeId);
    }
}
