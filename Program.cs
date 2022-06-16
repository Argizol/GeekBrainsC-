namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите ваше имя");
            string name = System.Console.ReadLine();
            System.Console.WriteLine($"Привет {name}, сегодня {System.DateTime.Now}");
        }
    }
}
