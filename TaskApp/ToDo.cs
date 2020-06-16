using System;
using System.Collections.Generic;

namespace TaskApp
{
    public class ToDo
    {
        List<Task> tasks;

        public ToDo()
        {
            tasks = new List<Task> { };
        }

        public void AddTask(string taskName)
        {
            Task newTask = new Task(taskName);
            tasks.Add(newTask);
        }

        public bool isEmpty()
        {
            return tasks.Count == 0 ? true : false;
        }

        public void PrintTasks()
        {
            if (!isEmpty())
            {
                int position = 0;
                foreach(Task t in tasks)
                {
                    position++;
                    string formattedString = string.Format("{0,0}. {1,-15} | {2,-10}", position, t.taskName, t.timeCreated.ToLongDateString() );
                    Console.WriteLine(formattedString);
                  
                }
            } else
            {
                Console.WriteLine("You don't have anything on your list!");
            }
        }

        public void RemoveTaskAt(int index)
        {
            try
            {
                tasks.RemoveAt(index);
            } catch (ArgumentOutOfRangeException rangeEx)
            {
                Console.WriteLine(rangeEx.Message);
            }
        }


    }
}
