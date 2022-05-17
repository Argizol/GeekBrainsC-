using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //printReverse();
            //printArrayDiag();
            //printArrayDiag2();
            //printArrayDiag3();
            //phoneNumber();
            seaFight();
            Console.ReadKey();
        }
        // ТЗ к первому заданию максимально невнятное

        static void printArrayDiag3()
        {
            int[,] numbers = new int[,]
            {
                {1, 0, 0},
                {0, 1, 0},
                {0, 0, 1}
            };

            int height = numbers.GetLength(0);
            int width = numbers.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                /* for (int j = 0; j < width; j++)
                 {
                     if (i == (width - j - 1))
                     {
                         Console.Write(numbers[i,j]);
                     }
                 }*/
                Console.WriteLine(numbers[i, 3 -i -1]);
            }
            
        }    

        /// <summary>
        /// Выводим цифры справа налево которые будут в массиве стоять по дуагонали сверху вниз слева направо
        /// </summary>
        static void printArrayDiag2()
        {
            int[,] numbers = new int[,]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 0}
            };

            int height = numbers.GetLength(0);
            int width = numbers.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width - 1; j++)
                {
                    if (i == 0)
                    {
                        Console.Write(numbers[0, j]);
                    }
                    else
                    {
                        Console.Write(numbers[1, j + 1]);
                    }
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Выводим все содержимое двумерного массиво по диагонали
        /// </summary>
        static void printArrayDiag()
        {
            int[,] numbers = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 0 } };
            foreach (int num in numbers)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (j < num | num == 0)
                        Console.Write(" ");
                }
                Console.Write($"{num} \n");
            }
        }
        static void printReverse()
        {
            string word = Console.ReadLine();
            Console.Write(word.Reverse().ToArray());
        }
        static void phoneNumber()
        {
            string[,] contacts = new string[5, 2]
            {
                {"Fedor", "+7 934 123 12 34"},
                {"Stepan", "stepan123@gmail.com"},
                {"Ulia", "+5 324 112 33 54"},
                {"Marina", "marina27@mail.bk"},
                {"Alex", "+1 234 456 76 23"},
            };

            for (var i = 0; i < contacts.GetLength(0); i++)
            {
                for (var j = 0; j < contacts.GetLength(1); j++)
                {
                    Console.Write(contacts[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        static void seaFight()
        {
            string[,] field = {
                {"X", "O", "X", "X", "O", "X", "X", "O", "O", "X"},
                {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
                {"O", "O", "O", "O", "O", "O", "X", "O", "O", "O"},
                {"O", "O", "X", "O", "O", "O", "X", "O", "O", "O"},
                {"O", "O", "X", "O", "O", "O", "O", "O", "O", "O"},
                {"O", "O", "X", "O", "O", "O", "X", "X", "X", "O"},
                {"O", "O", "X", "O", "O", "O", "O", "O", "O", "O"},
                {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
                {"O", "O", "X", "X", "X", "O", "O", "O", "O", "O"},
                {"X", "O", "O", "O", "O", "O", "O", "O", "O", "X"}
            };

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i,j]);
                }
                Console.WriteLine();
            }
        }



    }
}

