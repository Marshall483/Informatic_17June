using System;

namespace _93
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = double.Parse(Console.ReadLine());
            var r = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var d = double.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            GetResult(q, r, b, c, d, n);

        }

        private static void GetResult(double q, double r, double b, double c, double d, int n)
        {
            double x0 = c;
            double x1 = d;
            double x = 0;
            for (var a = 2; a <= n; a++)
            {
                x = q * x1 + r * x0 + b;
                x0 = x1;
                x1 = x;
            }
            Console.WriteLine(x);

        }
    }
}
