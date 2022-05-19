using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Task2
    {
        
        public static string getString()
        {
            Console.WriteLine("Введите цифры разделенные пробелом ");
            return Console.ReadLine(); ;
        }
        public static void stringToInt(string stroka)
        {            
            string[] words = stroka.Split();
            int sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                sum += int.Parse(words[i]);
            }
            Console.WriteLine($"Сумма :{sum}");
        }



    }


    }

