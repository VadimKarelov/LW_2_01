using System;

namespace LW_2_01_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            do
            {
                Console.WriteLine("Введите x");
            } while (!double.TryParse(Console.ReadLine(), out x));
            do
            {
                Console.WriteLine("Введите y");
            } while (!double.TryParse(Console.ReadLine(), out y));

            bool res = (y <= 0) && (x * x + y * y <= 1);
            Console.WriteLine($"Точка принадлежит закрашенной области: {res}");
        }
    }
}
