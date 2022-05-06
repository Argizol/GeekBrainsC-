using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{

    //Считаем и получаем среднюю температуру
    internal class MothTemp 
    {

        public static int MiddleTemp()
        {
            Console.WriteLine("Введите минимальную температуры за день: ");
            int minTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуры за день: ");
            int maxTemp = Convert.ToInt32(Console.ReadLine());
            return (minTemp + maxTemp) / 2;
        }

        //Проверяем что месяц зимний и средняя температура больше 0, затем печатаем результат
        public static void PrintWintMonth(){
            Console.WriteLine("Введите порядковый номер текущего месяца: ");
            int MonthNum = Convert.ToInt32(Console.ReadLine());
            if ((MonthNum == 11 || MonthNum == 12 || MonthNum == 1) && MiddleTemp() > 0)
            {
                Console.WriteLine("Дождливая зима");
            } else
            {
                Console.WriteLine("Не зима и, вероятно, не дождливая");
            }
        } 
    }
}
