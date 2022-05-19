using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Human
    {
        private string firstName;
        private string lastName;
        private string patronymic;
        public Human()
        {
            Console.WriteLine("Введите имя");
            this.firstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            this.lastName = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            this.patronymic = Console.ReadLine();
        }
        private string GetFullName()
        {
            return this.firstName + " " + this.lastName + " " + this.patronymic;
        }

        public static void printPeopleV1()
        {
            Console.WriteLine("Введите количество человек ");
            int a = Convert.ToInt32(Console.ReadLine());
            Human[] people = new Human[a];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Human();
            }
            foreach (Human person in people)
            {
                Console.WriteLine(person.GetFullName());
            }
        }
    }
}
