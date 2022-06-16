using System;
using System.IO;

namespace Lesson9
{
    internal class CatalogWiew
    {
        public static int pageNumber = 1;
        public static int elementsOnPageNumber = 16;

        /// <summary>
        /// Получение стартовой директории и запуск рекурсии на сбор директорий и фалов в ней
        /// </summary>
        /// <returns>полное дерево каталогов и файлов</returns>
        public static string[] GetCatalog(string startDirectory)
        {
            Console.SetCursorPosition(1, 1);
            string indent = "";
            string[] result = GetTreeRecursive(new DirectoryInfo(startDirectory), indent, true);
            return result;
        }

        /// <summary>
        /// Получение массива всех директорий и файлов в них
        /// </summary>
        /// <param name="currentDirectory">текущая директория</param>
        /// <param name="indent">отступ для вывода на печать</param>
        /// <param name="lastDirectory">определение последний ли элемент в дереве</param>
        /// <returns></returns>
        public static string[] GetTreeRecursive(DirectoryInfo currentDirectory, string indent, bool lastDirectory)
        {
            string parentLine = indent + (lastDirectory ? "└─" : "├─") + currentDirectory.Name;
            int arrSize = 1;
            string[] result = new string[arrSize];
            result[0] = parentLine;
            indent += lastDirectory ? "  " : "│ ";
            DirectoryInfo[] subDir = currentDirectory.GetDirectories();
            FileInfo[] files = currentDirectory.GetFiles();
            for (int i = 0; i < subDir.Length; i++)
            {
                try //для избежания эксепшена "отказано в доступе" и пропуске таких элементов
                {
                    var subResult = GetTreeRecursive(subDir[i], indent, i == subDir.Length - 1 && files.Length == 0);
                    var oldArrSize = result.Length;
                    arrSize = result.Length + subResult.Length;
                    Array.Resize(ref result, arrSize);
                    for (int j = 0; j < subResult.Length; j++)
                    {
                        result[j + oldArrSize] = subResult[j];
                    }
                }
                catch
                {
                    //пусто потому, что не требуется обработки эксепшена, только пропуск элемента приведшего к ошибке 
                }
            }
            var oldFileArrSize = result.Length;
            arrSize = result.Length + files.Length;
            Array.Resize(ref result, arrSize);
            for (int j = 0; j < files.Length; j++)
            {
                bool lastFile = j == files.Length - 1;
                result[j + oldFileArrSize] = indent + (lastFile ? "└─" : "├─") + files[j].Name;
            }
            return result;
        }

        /// <summary>
        /// Вывод в консоль дерева каталогов
        /// </summary>
        /// <param name="result"></param>

        public static void CatalogPrint(string[] result)
        {
            int startElementIndex = (pageNumber - 1) * elementsOnPageNumber;
            int lastElementIndex = startElementIndex + elementsOnPageNumber - 1;
            int y = 0;
            int pageTotal = (result.Length + elementsOnPageNumber - 1) / elementsOnPageNumber;
            if (startElementIndex > pageTotal)
                startElementIndex = pageTotal;
            for (int i = startElementIndex; i <= lastElementIndex && i < result.Length; i++)
            {
                
                ++y;
                Console.SetCursorPosition(1, y);
                Console.Write(result[i]);
            }
            string pagesOf = $"╡ {startElementIndex + 1} of {pageTotal} ╞";
            Console.SetCursorPosition(Program.WINDOW_WIDTH / 2 - pagesOf.Length / 2, 17);
            Console.WriteLine(pagesOf);
        }
    }
}
