using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите целое число n (от 1 до 10): ");
            double x = ReadDoubleFromConsole();
            Console.WriteLine("Введите степень (от 1 до 10):");
            int n = ReadPositiveIntFromConsole(1, 10);
            double result = RootExtraction(n, x);
            Console.WriteLine($"Корень степени {n} из числа {x} равен: {result}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Спасибо за использование моей программы!");
            Console.ReadKey();
        }
        static double RootExtraction(int n, double x)
        {
            return Math.Pow(x, 1.0 / n);
        }
        static double ReadDoubleFromConsole()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result) || result < 1 || result > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод. Введите вещественное число от 1 до 100:");
            }
            return result;
        }

        static int ReadPositiveIntFromConsole(int minValue, int maxValue)
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result) || result < minValue || result > maxValue)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Некорректный ввод. Введите целое число от {minValue} до {maxValue}:");
            }
            return result;
        }
    }
}