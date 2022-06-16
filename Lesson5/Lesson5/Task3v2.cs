using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Task3v2
    {
        public static void SaveToBinv2(List<byte> arr)
        {
            byte[] arr1 = new byte[arr.Count];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = (byte)arr[i];
            }
            Directory.CreateDirectory(@"C:\Под урок 5");
            File.WriteAllBytes(@"C:\Под урок 5\byteFile.bin", arr1);
            byte[] arr2 = File.ReadAllBytes(@"C:\Под урок 5\byteFile.bin");
            foreach (byte b in arr2)
            {
                Console.Write($"{b} ");
            }
        }

        public static List<byte> GetByteArr()
        {
            List<byte> arr = new List<byte>();
            do
            {
                Console.WriteLine("Для добавления числа нажмите 1, для завершения ввода 0");
                int counter = int.Parse(Console.ReadLine());
                if (counter == 1)
                {
                    Console.WriteLine("Введите число от 0 до 255");
                    arr.Add(Convert.ToByte(Console.ReadLine()));
                }
                else
                {
                    return arr;
                }
            } while (true);
        }
    }
}
