//***************************************************************
//* Практическая работа № 7                                     *
//* Выполнил: Пирогов Д., группа 2ИСП                           *
//* Задание: составить программу циклической структуры          *
//***************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №7");
            Console.WriteLine("Здравствуйте!");
            Console.WriteLine("Введите количество чисел: "); // вводим значение N

            try
            {
                try
                {
                    int N = Convert.ToInt32(Console.ReadLine());

                    if (N <= 0)
                    {
                        Console.ReadLine();
                        Console.WriteLine("Пожалуйста, введите положительное целое число.");
                    }
                    else
                    {
                        int a = 0; // переменная для хранения суммы квадратов чисел
                        for (int i = 0; i < N; i++)
                        {
                            Console.Write($"Введите число {i + 1}: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            a += num * num;
                        }

                        if (N > 0) // Проверка на N > 0, чтобы избежать деления на 0
                        {
                            double b = Math.Sqrt(a / N); // вычисляем среднее квадратическое
                            Console.WriteLine($"Среднее квадратическое N чисел: {b}");
                        }
                    }
                }
                catch (FormatException fe)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка ввода \n" + fe.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка ввода \n" + e.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("До свидания!");
            Console.ReadKey();
        }
    }
}
