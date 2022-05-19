using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Task3
    {
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        public static string whatSeason(int a)
        {
           if (a == 1 || a == 2 || a == 12)
            {
                Season season = Season.Winter;
                return Convert.ToString(season);
            }
            if(a == 3 || a == 4 || a == 5) {
                Season season2 = Season.Spring;
                return Convert.ToString(season2);
            }
            if (a == 6 || a == 7 || a == 8)
            {
                Season season3 = Season.Summer;
                return Convert.ToString(season3);
            }
            if (a == 9 || a == 10 || a == 11)
            {
                Season season4 = Season.Autumn;
                return Convert.ToString(season4);
            }
            else
            {
               return "Введите число от 1 о 12";
            }
        }
    }
}