using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Task4
    {
        public static void CatalogSaverRec()
        {
            Console.Write("Укажите путь каталога в формате С:\\ \n");
            string startDir = Console.ReadLine();
            string result = "";
            CatalogSaverRec2(startDir, ref result, 0);
            File.WriteAllText(@"C:\Под урок 5\Catalogs.txt", result);            
        }
        static void CatalogSaverRec2(string startDir, ref string result, int c)
        {
            string[] directorys = Directory.GetDirectories(startDir);
            string[] files = Directory.GetFiles(startDir);
            foreach (string directory in directorys)
            {
                for (int i = 0; i < c; i++)
                {
                    result += "\t";
                }
                result += directory + "\n";
                CatalogSaverRec2(directory, ref result, c + 1);

            }
            foreach (string file in files)
            {
                for (int i = 0; i < c; i++)
                {
                    result += "\t";
                }
                result += file + "\n";
            }
        }
    }
}
