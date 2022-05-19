using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Task3
    {
        public enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn,
            Error
        }
        
        public static Season whatSeason(int a)
        {
            if (a == 1 || a == 2 || a == 12)
            {
                return Season.Winter;
            }
            if (a == 3 || a == 4 || a == 5)
            { 
                return Season.Spring;
            }
            if (a == 6 || a == 7 || a == 8)
            {
                return Season.Summer;
            }
            if (a == 9 || a == 10 || a == 11)
            {
                return Season.Autumn;
            }
            return Season.Error;
        }

        public static void printSeason(Season a)
        {
            switch (a)
            {
                case Season.Winter:
                    Console.WriteLine("Зима");
                    break;
                case Season.Spring:
                    Console.WriteLine("Весна");
                    break;
                case Season.Summer:
                    Console.WriteLine("Лето");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Осень");
                    break;
                default: 
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                    break;
            }
        }
    }
}