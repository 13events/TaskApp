﻿using System;
using System.Runtime.InteropServices;
namespace TaskApp {
    public class WindowManager
    {
        bool UNIX;  //flag for using UNIX specific commands
        int windowHeight { get; set; }
        int windowWidth {get; set;}

        public WindowManager()
        {
            //set UNIX flag
            UNIX = Environment.OSVersion.Platform.ToString() == "Unix" ? true : false;

        }

        /// <summary>
        /// Create a new WindowManager object and set windowsize.
        /// </summary>
        /// <param name="height">height of window, in characters</param>
        /// <param name="width">width of window, in characters</param>
        public WindowManager(int height, int width)
        {
            windowHeight = height;
            windowWidth = width;
            SetWindowSize(windowHeight, windowWidth);
        }

        /// <summary>
        /// Sets the terminal window size 
        /// </summary>
        /// <param name="height">number of characters to display vertically</param>
        /// <param name="width">number of characters to display horizontally</param>
        public void SetWindowSize(int height, int width)
        {
            windowHeight = height;
            windowWidth = width;

            if (UNIX)
            {
                system($"printf '\\e[8;%i;%it' {windowHeight} {windowWidth}");
                system($"printf '\\e[3;0;0t'");
            } else
            {
                //resize window and move to position
                Console.WindowHeight = height;
                Console.WindowWidth = width;
                Console.SetWindowPosition(0, 0);
            }
        }


        // Load this when running on a UNIX based OS
        [DllImport("libc")]
        private static extern int system(string message);


    }
}
