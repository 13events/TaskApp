using System;
using System.IO;

namespace TaskApp
{
    class MainClass
    {
         static private ToDo taskList = new ToDo();

        public static void Main(string[] args)
        {
            string userName = Environment.UserName;
            string userSelection = string.Empty;

            SetConsoleColors();

          

            PrintWelcome();

            while (!userSelection.Equals('q'))
            {
                PrintMenu();

                Console.Write("===> ");
                userSelection = Console.ReadLine();

                switch (userSelection.ToLower())
                {
                    case "1":
                        Console.Clear();
                        taskList.PrintTasks();
                        break;
                    case "2":
                        Console.Clear();
                        PromptUserToAddTask();
                        break;
                    case "3":
                        Console.Clear();
                        PromptUserToRemoveTask();
                        break;
                    case "q":
                        Console.Clear();
                        Console.WriteLine("Quitting application... \n");
                        break;
                    default:
                        return;
                }
            }  
        }

        static public void PrintWelcome()
        {
            Console.WriteLine("********** Welcome to the TaskApp **********");
            
        }

        static public void PrintMenu()
        {
            Console.WriteLine("Make your selection using the menu below.\n");
            Console.WriteLine("1) Show Task List");
            Console.WriteLine("2) Add a new Task");
            Console.WriteLine("3) Mark a task as completed");
        }

        static public void SetConsoleColors()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
        }

        static private bool PromptUserToAddTask()
        {
            string taskName = string.Empty;

            Console.Write("Enter task: ");
            taskName = Console.ReadLine();

            try
            {
                return taskList.AddTask(taskName);

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        static private bool PromptUserToRemoveTask()
        {
            string indexOfTaskToRemove;

            Console.Write("Enter task number to mark as completed: ");
            indexOfTaskToRemove = Console.ReadLine();

            return taskList.RemoveTaskAt(int.Parse(indexOfTaskToRemove));

        }
        
        
    }
}
