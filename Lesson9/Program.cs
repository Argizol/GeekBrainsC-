using System;
using System.IO;

namespace Lesson9
{
    internal class Program
    {

        public const int WINDOW_HEIGHT = 30;
        public const int WINDOW_WIDTH = 120;
        public static string currentDir = Directory.GetCurrentDirectory(); 
        
        static void Main(string[] args)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.currentDir))
                currentDir = Properties.Settings.Default.currentDir;

            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Title = "FileManager";

            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);
            Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGHT);

            DrawWindow.DrawConsoleWindow(0, 0, WINDOW_WIDTH, 18);
            DrawWindow.DrawConsoleWindow(0, 18, WINDOW_WIDTH, 8);
            UpdateConsole();
            Properties.Settings.Default.currentDir = currentDir;
            Properties.Settings.Default.Save();
            Console.ReadLine();
        }

        /// <summary>
        /// Обновление ввода с консоли
        /// </summary>
        public static void UpdateConsole()
        {
            DrawConsole.DrawMyConsole(currentDir, 0, 26, WINDOW_WIDTH, 3);
            DoConsoleCommand.ProcessEnterCommand(WINDOW_WIDTH);
            
        }
    }
}
