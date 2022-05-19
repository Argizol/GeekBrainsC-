using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Task1
    {
        //получаем Имя из консоли
        public static string getFirstName()
        {
            Console.WriteLine("Введите имя");

            return Console.ReadLine();
        }
        //получаем Фамилию из консоли
        public static string getLastName()
        {
            Console.WriteLine("Введите фамилию");
            return Console.ReadLine();
        }
        //получаем Отчество из консоли
        public static string patronymic()
        {
            Console.WriteLine("Введите отчество");
            return Console.ReadLine();
        }
        //склеиваем конкатенацией ФИО
        public static string GetFullName(string firstName, string lastName, string patronymic)
        {
            Console.WriteLine("***********************************************************");
            return firstName + " " + lastName + " " + patronymic;
        }
        //Получаем список людей, кладем в массив и печатаем
        public static void printPeople()
        {
            Console.WriteLine("Введите количество человек ");
            int a = Convert.ToInt32(Console.ReadLine());
            string[] people = new string[a];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = GetFullName(getFirstName(), getLastName(), patronymic());
            }
            foreach (string person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
