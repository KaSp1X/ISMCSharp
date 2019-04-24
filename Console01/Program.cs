using System;

namespace Console01
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;
            bool checker;
            Console.WriteLine("Введите значения:");
            do
            {
                Console.Write("A: ");
                checker = double.TryParse(Console.ReadLine(), out a);
                if (!checker) Console.WriteLine("Значение введено неверно!");
            }
            while (!checker);
            do
            {
                Console.Write("B: ");
                checker = double.TryParse(Console.ReadLine(), out b);
                if (!checker) Console.WriteLine("Значение введено неверно!");
            }
            while (!checker);
            do
            {
                Console.Write("X: ");
                checker = double.TryParse(Console.ReadLine(), out x);
                if (!checker) Console.WriteLine("Значение введено неверно!");
            }
            while (!checker);
            func(a, b, x);
            Console.ReadKey();
        }
        static void func(double a, double b, double x)
        {
            double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
            Console.WriteLine("Решение: {0}", y);
        }
    }
}
