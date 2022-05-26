using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Task4v2
    {

        public static void CatalogSaverRec()
        {
            Console.WriteLine("Укажите путь каталога в формате С:\\");
            string startDirectory = Console.ReadLine();
            Console.Clear();
            string indent = "";
            string result = GetTreeRecursive(new DirectoryInfo(startDirectory), indent, true, string.Empty);
            File.WriteAllText(@"C:\Под урок 5\Catalogs.txt", result);
        }

        public static string GetTreeRecursive(DirectoryInfo currentDirectory, string indent, bool lastDirectory, string result)
        {            
            string parentLine = indent + (lastDirectory ? "└─" : "├─") + "📂" + currentDirectory.Name + "\n";
            result += parentLine;
            indent += lastDirectory ? "  " : "│ ";
            Console.Write(parentLine);
            DirectoryInfo[] subDir = currentDirectory.GetDirectories();
            FileInfo[] files = currentDirectory.GetFiles();
            for (int i = 0; i < subDir.Length; i++)
            {
                result = GetTreeRecursive(subDir[i], indent, i == subDir.Length - 1 && files.Length == 0, result);
            }
                        
            for (int i = 0; i < files.Length; i++)
            {
                bool lastFile = i == files.Length - 1;                
                result += indent + (lastFile ? "└─" : "├─") + "📄" + files[i].Name + "\n";
            }
            return result;
        }
    }
}
