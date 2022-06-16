using System;
using System.IO;
using System.Text;

namespace Lesson9
{
    internal class DoConsoleCommand
    {
        /// <summary>
        /// Вспомогательный метод, получить текущую позицию курсора
        /// </summary>
        /// <returns></returns>
        static (int left, int top) GetCursorPosition()
        {
            return (Console.CursorLeft, Console.CursorTop);
        }

        /// <summary>
        /// Обработка процесса ввода данных с консоли
        /// </summary>
        /// <param name="width">Длина строки ввода</param>
        public static void ProcessEnterCommand(int width)
        {
            (int left, int top) = GetCursorPosition();
            StringBuilder command = new StringBuilder();
            ConsoleKeyInfo keyInfo;
            char key;

            do
            {
                keyInfo = Console.ReadKey();
                key = keyInfo.KeyChar;

                if (keyInfo.Key != ConsoleKey.Enter && keyInfo.Key != ConsoleKey.Backspace &&
                    keyInfo.Key != ConsoleKey.UpArrow)
                    command.Append(key);

                (int currentLeft, int currentTop) = GetCursorPosition();

                if (currentLeft == width - 2)
                {
                    Console.SetCursorPosition(currentLeft - 1, top);
                    Console.Write(" ");
                    Console.SetCursorPosition(currentLeft - 1, top);
                }

                if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (command.Length > 0)
                        command.Remove(command.Length - 1, 1);
                    if (currentLeft >= left)
                    {
                        Console.SetCursorPosition(currentLeft, top);
                        Console.Write(" ");
                        Console.SetCursorPosition(currentLeft, top);
                    }
                    else
                    {
                        command.Clear();
                        Console.SetCursorPosition(left, top);
                    }
                }

            }
            while (keyInfo.Key != ConsoleKey.Enter);
            ParseCommandString(command.ToString());
        }

        static void ParseCommandString(string command)
        {
            string[] commandParams = command.ToLower().Split(' ');
            if (commandParams.Length > 0)
            {
                switch (commandParams[0])
                {
                    case "cd":
                        if (commandParams.Length > 1)
                            if (Directory.Exists(commandParams[1]))
                            {
                                
                                Program.currentDir = commandParams[1];
                               
                            }
                        break;
                    case "ls":
                        if (commandParams.Length > 1 && Directory.Exists(commandParams[1]))
                            if (commandParams.Length > 3 && commandParams[2] == "-p" && int.TryParse(commandParams[3], out int numberOfPage))
                            {
                                CatalogWiew.pageNumber = int.Parse(commandParams[3]);
                                string[] arr = CatalogWiew.GetCatalog(commandParams[1]);
                                DrawWindow.DrawConsoleWindow(0, 0, Program.WINDOW_WIDTH, 18);
                                CatalogWiew.CatalogPrint(arr);

                            }
                            else if (commandParams.Length > 3 && commandParams[2] == "-p")
                            {
                                CatalogWiew.pageNumber = 1;
                                string[] arr = CatalogWiew.GetCatalog(commandParams[1]);
                                DrawWindow.DrawConsoleWindow(0, 0, Program.WINDOW_WIDTH, 18);
                                CatalogWiew.CatalogPrint(arr);
                            }
                        break;
                    case "exit":
                        if (commandParams.Length > 0 && commandParams[0] == "exit")
                            return;
                        break;

                    //Копирование каталога
                    //cp C:\Source D:\Target
                    //Копирование файла
                    //cp C:\source.txt D:\target.txt
                    case "cp":
                        if (commandParams.Length > 1 && File.Exists(commandParams[1]) && Directory.Exists(commandParams[2]))
                        {
                            FileInfo file = new FileInfo(commandParams[1]);
                            file.CopyTo(commandParams[2]);
                        }
                        else if(commandParams.Length > 1 && Directory.Exists(commandParams[1]) && Directory.Exists(commandParams[2]))
                        {                            
                            CopyDir(command[1].ToString(), command[2].ToString());                            
                        }
                        break;
                    //Удаление каталога рекурсивно
                    //rm C:\Source
                    //Удаление файла
                    //rm C:\source.txt
                    case "rm":
                        if (commandParams.Length > 1)
                        {
                            if (File.Exists(commandParams[1]))
                            {
                                File.Delete(commandParams[1]);
                            }
                            else
                            {
                                string folder = commandParams[1];
                                try
                                {
                                    Directory.Delete(folder, true);
                                }
                                catch (DirectoryNotFoundException ex)
                                {
                                    Console.WriteLine("Директория не найдена. Ошибка: " + ex.Message);
                                }
                                catch (UnauthorizedAccessException ex)
                                {
                                    Console.WriteLine("Отсутствует доступ. Ошибка: " + ex.Message);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                                }
                            }
                        }
                        break;
                    //Вывод информации
                    //file C:\source.txt
                    case "file":
                        if (commandParams.Length > 1 && File.Exists(commandParams[1]))
                        {
                            FileInfo file = new FileInfo(commandParams[1]);
                            string fileParams = "имя файла " + file.Name.ToString() + " расширение" + file.Extension.ToString() + " размер файла" + file.Length.ToString();
                            Console.SetCursorPosition(1, 19);
                            Console.WriteLine(fileParams);
                        }
                        else
                        {
                            DirectoryInfo directory = new DirectoryInfo(commandParams[1]);
                            string directoryParams = "имя папки " + directory.Name.ToString() + " время создания " + directory.CreationTime.ToString();
                            Console.SetCursorPosition(1, 19);
                            Console.WriteLine(directoryParams);
                        }
                        break;
                        //    if (enteredKey == ConsoleKey.UpArrow)
                        //    {
                        //         //TODO предыдущая введеная строка в консоль
                        //    }
                        //    if (enteredKey == ConsoleKey.DownArrow)
                        //    {
                        //    //TODO следующая введеная строка в консоль
                        //    }
                }
            }
            Program.UpdateConsole();
        }

        /// <summary>
        /// Метод для копирования каталога рекурсивно
        /// </summary>
        /// <param name="FromDir">Откуда копируем</param>
        /// <param name="ToDir">Куда копируем</param>
        static void CopyDir(string FromDir, string ToDir)
        {
            Directory.CreateDirectory(ToDir);
            foreach (string s1 in Directory.GetFiles(FromDir))
            {
                string s2 = ToDir + "\\" + Path.GetFileName(s1);
                File.Copy(s1, s2);
            }
            foreach (string s in Directory.GetDirectories(FromDir))
            {
                CopyDir(s, ToDir + "\\" + Path.GetFileName(s));
            }
        }
    }
}

