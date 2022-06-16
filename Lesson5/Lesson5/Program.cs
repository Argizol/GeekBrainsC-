using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1 и Task2 запускать вместе
            //Task1.SaveTextToFile();
            //Task2.TimeAddToFile();
            //Task3v1.SaveToBin();
            //Task3v2.SaveToBinv2(Task3v2.GetByteArr())
            //Task4.CatalogSaverRec();
            //Task5.GetTaskText();
            //Console.WriteLine("Для завершения программы нажмите любую кнопку");
            Task4v2.CatalogSaverRec();
            Console.ReadKey(true);
        }                      
    }
}