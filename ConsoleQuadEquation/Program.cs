using System;

namespace ConsoleQuadEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
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
                Console.Write("C: ");
                checker = double.TryParse(Console.ReadLine(), out c);
                if (!checker) Console.WriteLine("Значение введено неверно!");
            }
            while (!checker);
            func(a, b, c);
            Console.ReadKey();
        }
        static void func(double a, double b, double c)
        {
            double D = Math.Pow(b,2)-4*a*c;
            Console.WriteLine("Дискриминант: {0}", D);
            if (D < 0) Console.WriteLine("Решений нет!");
            else
            if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Корень уравнения: {0}", x);
            }
            else
            {
                double x1 = (-b + Math.Pow(D,-2)) / (2 * a);
                double x2 = (-b - Math.Pow(D,-2)) / (2 * a);
                Console.WriteLine("Корени уравнения: {0} и {1}", x1, x2);
            }
        }
    }
}
