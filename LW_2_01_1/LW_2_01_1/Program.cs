/*
m-++n
m++>--n
m--<++n
25x^5-sqrt(x*x+x)
*/
using System;

namespace LW_2_01_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            do
            {
                Console.WriteLine("Введите n");
            } while (!int.TryParse(Console.ReadLine(), out n));
            do
            {
                Console.WriteLine("Введите m");
            } while (!int.TryParse(Console.ReadLine(), out m));

            int res1 = m - ++n;
            Console.WriteLine($"m={m} n = {n} m-++n={res1}");

            bool res2 = m++ > --n;
            Console.WriteLine($"m={m} n = {n} m++>--n={res2}");

            bool res3 = m-- < ++n;
            Console.WriteLine($"m={m} n = {n} m--<++n={res3}");

            double x;
            do
            {
                Console.WriteLine("Введите x (x <= -1 или x >=0)");
            } while (!double.TryParse(Console.ReadLine(), out x) || (x > -1 && x < 0));

            double res4 = 25 * Math.Pow(x, 5.0) - Math.Sqrt(x * x + x);
            Console.WriteLine($"x={x} f(x)={res4}");
        }
    }
}
