using System;
namespace TaskApp
{
    public struct Task
    {
        public string taskName;
        public DateTime timeCreated;
        private DateTime timeDue;

        public Task(string taskName)
        {
            this.taskName = taskName;
            timeCreated = DateTime.Now;
            timeDue = DateTime.Now;
        }
    }
}
