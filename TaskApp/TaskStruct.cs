using System;
namespace TaskApp
{
    public struct Task
    {
        string taskName;
        private DateTime timeCreated;
        private DateTime timeDue;

        public Task(string taskName)
        {
            this.taskName = taskName;
            timeCreated = DateTime.Now;
            timeDue = DateTime.Now;
        }
    }
}
