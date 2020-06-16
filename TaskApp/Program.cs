using System;
using System.IO;

namespace TaskApp
{
    class MainClass
    {
        
   

        public static void Main(string[] args)
        {
            Task taskList = new Task();

            string userName = Environment.UserName;
            string userSelection = string.Empty;

            PrintWelcome();

            while (!userSelection.Equals('q'))
            {
                PrintMenu();

                Console.Write("===> ");
                userSelection = Console.ReadLine();

                switch (userSelection.ToLower())
                {
                    case "1":
                        Console.WriteLine("Show task list. \n");
                        break;
                    case "2":
                        Console.WriteLine("Add a new task. \n");
                        break;
                    case "3":
                        Console.WriteLine("Mark a task as completed. \n");
                        break;
                    case "q":
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
            Console.WriteLine("Make your selection using the menu below.\n");
        }

        static public void PrintMenu()
        {
            Console.WriteLine("1) Show Task List");
            Console.WriteLine("2) Add a new Task");
            Console.WriteLine("3) Mark a task as completed");
        }

        private void AddTask(string taskName)
        {
        }
    }
}
