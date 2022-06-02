using System;

namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Console.WriteLine("Введите возраст пользователя:");
                Properties.Settings.Default.UserAge = Console.ReadLine();
                Console.WriteLine("Введите профессию пользователя:");
                Properties.Settings.Default.UserProffecy = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string HelloByStart = Properties.Settings.Default.HelloByStart;
            string UserName = Properties.Settings.Default.UserName;            
            string UserAge = Properties.Settings.Default.UserAge;
            string UserProffecy = Properties.Settings.Default.UserProffecy;
            Console.WriteLine($"{HelloByStart}, {UserName}! \n Возраст: {UserAge} \n Род деятельности: {UserProffecy}");
            Console.ReadKey(true);
        }
        
    }
}

