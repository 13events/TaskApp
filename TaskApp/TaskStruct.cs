using System;
namespace TaskApp
{
    public struct Task
    {
        private string[] tasks;
        private string task;
        private string timeCreated;
        private string timeDue;

        public Task(string taskName)
        {
            tasks = new string[] { };
            task = taskName;
            timeCreated = DateTime.Now.Date.ToShortDateString();
            timeDue = DateTime.Now.Date.ToShortDateString();
        }

        public Task (string taskName, DateTime dueDate)
        {
            tasks = new string[] { };
            task = taskName;
            timeCreated = DateTime.Now.Date.ToShortDateString();
            timeDue = dueDate.ToShortDateString();
        }

        public void PrintTask()
        {

        }

    }
}
