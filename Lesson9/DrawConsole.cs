using System;

namespace Lesson9
{

    internal class DrawConsole
    {

        /// <summary>
        /// Отрисовка консоли
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static void DrawMyConsole(string dir, int x, int y, int width, int height)
        {
            DrawWindow.DrawConsoleWindow(x, y, width, height);
            Console.SetCursorPosition(x + 1, y + height / 2);
            Console.Write($"{dir}>");
        }
    }
}
