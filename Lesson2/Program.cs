using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Homework2
    {
         static void Main(string[] args)
        {


            // MiddleTemp();
            //TodayMonth();
            //IsNumEven();
            //MothTemp.PrintWintMonth();
            //Chek.PrintChek();
            //Task2();
            string str = "Genius is simplicity.";
            //char[] reverse = str.Reverse().ToArray();
            Console.WriteLine(str.Reverse());
            Console.ReadLine();
        }
 
        //Считаем среднюю температуру
        public static void MiddleTemp()
        {
            Console.WriteLine("Введите минимальную температуры за день: ");
            int minTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуры за день: ");
            int maxTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Среднесуточная температура: {(minTemp + maxTemp) / 2}");
        }

        //Определяем месяц по введенному номеру
        public static void TodayMonth()
        {
            Console.WriteLine("Введите порядковый номер текущего месяца: ");
             int todayMonth = Convert.ToInt32(Console.ReadLine());
             switch (todayMonth)
             {
                 case 1: Console.WriteLine("Январь");
                     break;
                 case 2: Console.WriteLine("Февраль");
                     break;
                 case 3: Console.WriteLine("Март");
                     break;
                 case 4:
                     Console.WriteLine("Апрель");
                     break;
                 case 5:
                     Console.WriteLine("Май");
                     break;
                 case 6:
                     Console.WriteLine("Июнь");
                     break;
                 case 7:
                     Console.WriteLine("Июль");
                     break;
                 case 8:
                     Console.WriteLine("Август");
                     break;
                 case 9:
                     Console.WriteLine("Сентябрь");
                     break;
                 case 10:
                     Console.WriteLine("Октябрь");
                     break;
                 case 11:
                     Console.WriteLine("Ноябрь");
                     break;
                 case 12:
                     Console.WriteLine("Декабрь");
                     break;
                 default: Console.WriteLine("Введите число от 1 до 12");
                     break;
             }
        }

        static int Task2()
        {
            Console.Write("Укажите порядковый номер месяца: ");
            int monthNo = int.Parse(Console.ReadLine());
            if (monthNo < 1 || monthNo > 12)
            {
                Console.WriteLine("Вы указали некорректный номер месяца.");
            }
            Console.WriteLine($"Вы указали месяц: {new DateTime(1, monthNo, 1).ToString("MMMM")}");
            Console.ReadKey();

            return monthNo;
        }

        //Определяем четность числа
        public static void IsNumEven()
        {
            Console.WriteLine("Введите число: ");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(" Число четное ");
                return;
            }
            Console.WriteLine("Число нечетное");
        }
    }
}
