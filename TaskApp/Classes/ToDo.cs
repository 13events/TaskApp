using System;
using System.Collections.Generic;

namespace TaskApp
{
   //TODO: Refactor method(s) to account for Task.DueBy date. Order taskList DueBy in ascending order.
    public class ToDo
    {
        List<Task> tasks;

        public ToDo()
        {
            tasks = new List<Task> { };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskName"></param>
        /// <returns>True when task is added successfully</returns>
        /// <exception cref="System.Exception">Thrown when adding a task that already exists in the list.</exception>
        public bool AddTask(string taskName)
        {
            Task newTask = new Task(taskName);

            if (!tasks.Contains(newTask))
            {
                tasks.Add(newTask);
                return true;
            }
            throw new Exception("Duplicate tasks are not allowed.");
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

                Console.WriteLine("=========================== Your ToDo List ===========================");

                foreach (Task t in tasks)
                {
                    position++;
                    string formattedString = string.Format("| {0,0}. {1,-15} | {2,-10} |", position, t.taskName, t.timeCreated.ToLongDateString() );
                    Console.WriteLine(formattedString);
                  
                }
            } else
            {
                Console.WriteLine("========== You don't have anything on your list! ==========");
            }

            Console.WriteLine("\n\n");
        }

        public bool RemoveTaskAt(int index)
        {
            try
            {
                tasks.RemoveAt(index);
                return true;
            } catch (ArgumentOutOfRangeException rangeEx)
            {

                Console.WriteLine(rangeEx.Message);
                return false;
            }
        }


    }
}
