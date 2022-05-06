using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Chek
    {
    public static void PrintChek()
        {
            string adress = "Тут должен быть юр адрес организации";
            string chekNum = "Номер чека 234567";
            string prihod = "Приход";
            DateTime dateByPurchase = new DateTime(2022, 05, 06); 
            string clientMail = "123@123.ru";
            string companyMail = "321@321.ru";
            string kktNum = "KKT021808";
            double price = 200.55;
            Console.Write($"{adress}, \n {chekNum}, {prihod}, \n {dateByPurchase.ToString("d")}, \n {clientMail}, \n {companyMail}, " +
                $"\n Номер ККТ {kktNum}, \n Сумма покупки {price} рублей");            
        }
    }
}
