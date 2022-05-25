using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Task3v1
    {
        public static async void SaveToBin()
        {
            Console.WriteLine("Введите числа от 0 до 255");
            string nums = Console.ReadLine();
            Directory.CreateDirectory(@"C:\Под урок 5");
            //определяем путь к файлу, режим работы с файлом: Открыть если есть, создать если нет
            using (FileStream fstream = new FileStream(@"C:\Под урок 5\byteFile.bin", FileMode.OpenOrCreate))
            {
                //преобразуем строку цифр в массив байтов
                byte[] byteFile = Encoding.Default.GetBytes(nums);
                //записываем массив байтов в файл
                await fstream.WriteAsync(byteFile, 0, byteFile.Length);
            }

            using (FileStream fstream = File.OpenRead(@"C:\Под урок 5\byteFile.bin"))
            {
                // выделяем массив для считывания данных из файла
                byte[] byteFile = new byte[fstream.Length];
                // считываем данные
                await fstream.ReadAsync(byteFile, 0, byteFile.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.Default.GetString(byteFile);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }
        }
    }
}
