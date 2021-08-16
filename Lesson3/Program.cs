using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // • Задание 2
            Console.WriteLine("введите сумму");
            double sum = Convert.ToDouble(Console.ReadLine());
            if (sum <= 1000 && sum > 500)
            {
                double s = sum / 100 * 3;
                Console.WriteLine($"{sum - s} сом");
            }
            else if (sum > 1000)
            {
                double s = sum / 100 * 5;
                Console.WriteLine($"{sum - s} сом");
            }
            else Console.WriteLine($"{sum} сом");

            // • Задание 3
            Console.WriteLine("Введите значение переменных a,b,c,d");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c && c == d) Console.WriteLine(a * b * c * d);
            else if (!(a < b && b < c && c < d))
            {
                var h = Math.Min(Math.Min(a, b), Math.Min(c, d));
                Console.WriteLine($"минимальное число в переменных: {h}");
            }
            else Console.WriteLine("Числа расположены по возрастанию");


            // • Задание 4
            Console.WriteLine("Введите значение переменных a,b,c");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());

            if (A < C) (A, C) = (C, A);
            if (A < B) (A, B) = (B, C);
            if (B < C) (B, C) = (C, B);


            Console.WriteLine($"A = {A}, B = {B}, C = {C}");

        }
    }
}
