using System;

namespace LW_2_01_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // input data
            int a = 1000;
            float b = 0.0001f;

            // computing
            D(a, b);
            F(a, b);
        }

        static void D(int a, double b)
        {
            double d = a - b;
            double e = Math.Pow(d, 3);
            double f = a * a * a;
            double g = 3 * a * b * b;
            double h = f + g;
            double i = e - h;
            double j = -3 * a * a * b;
            double k = Math.Pow(b, 3);
            double l = j - k;
            double m = i / l;

            Console.WriteLine($"Тип double, результат = {m}");
        }

        static void F(int a, float b)
        {
            float d = a - b;
            float e = d * d * d;
            float f = a * a * a;
            float g = 3 * a * b * b;
            float h = f + g;
            float i = e - h;
            float j = -3 * a * a * b;
            float k = b * b * b;
            float l = j - k;
            float m = i / l;

            Console.WriteLine($"Тип float, результат = {m}");
        }
    }
}
