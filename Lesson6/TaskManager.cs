using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson6
{
    internal class TaskManager
    {
        public static void ConsoleTaskManager()
        {            
            while (true)
            {
                Console.WriteLine($"Для просмотра процессов нажмите 1");
                Console.WriteLine($"Для перехода к меню прекращения процессов нажмите 2");
                Console.WriteLine($"Для завершения программы введите 0");
                int menuNumber = int.Parse(Console.ReadLine());
                Console.Clear();
                if (menuNumber == 1)
                {
                    Process[] processList = Process.GetProcesses();
                    Console.WriteLine($"Запущенные процессы: ");
                    foreach (Process process in processList)
                    {
                        Console.WriteLine($"{process.Id} {process.ProcessName}");
                    }                                        
                }
                if (menuNumber == 0)
                {
                    Console.WriteLine("Завершение программы. Нажмите любую клавишу...");
                    Console.ReadKey(true);
                    return;
                }
                if (menuNumber == 2)
                {
                    Console.WriteLine("Для прекращения процесса введите его ID или имя");
                    var processKill = Console.ReadLine();
                    if (int.TryParse(processKill, out int number))
                    {
                        int processKillID = int.Parse(processKill);
                        string machineName = Process.GetCurrentProcess().MachineName;
                        Process processById = Process.GetProcessById(processKillID, machineName);
                        processById.Kill();
                        Console.WriteLine($"Процесс {processById.ProcessName} остановлен.");                                             
                    }
                    else
                    {
                        Process[] processListByName = Process.GetProcessesByName(processKill);
                        foreach (Process process in processListByName)
                        {
                            process.Kill();
                            Console.WriteLine($"Процесс {process.ProcessName} остановлен.");                                                        
                        }
                    }
                }
                Console.WriteLine($"Для продолжения нажмите любую кнопку");
                Console.ReadKey(true);
                Console.Clear();
            }            
        }
    }
}