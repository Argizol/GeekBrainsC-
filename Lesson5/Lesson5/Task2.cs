using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Task2
    {
        public static void TimeAddToFile()
        {
            Console.WriteLine("Сейчас в файд textFile.txt будет добавлено текущее время");
            string Str2 = DateTime.Now.ToString("HH:mm:ss");
            File.AppendAllText(@"C:\Под урок 5\textFile.txt", Str2);
        }
    }
}
