using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Task1
    {
        public static void SaveTextToFile()
        {
            Console.WriteLine("Введите текст в строку");
            string textFile = Console.ReadLine();
            Directory.CreateDirectory(@"C:\Под урок 5");
            File.WriteAllText(@"C:\Под урок 5\textFile.txt", $"{textFile} ");
        }
        
    }
}
