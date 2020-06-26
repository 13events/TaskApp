using System;
namespace TaskApp
{
    //TODO: Add field for DueBy Date.

    public struct Task : IEquatable<Task>
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

        public bool Equals(Task other)
        {
            if(other.taskName == this.taskName)
            {
                return true;
            }

            return false;
        }
    }
}
