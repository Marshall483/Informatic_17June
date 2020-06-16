using System;

namespace Ex93
{
    class Ex_93
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа в порядке q,r,b,x(0),x(1) для формулы x(n)=q*x(n-1)+rx(n-2)+b");
            double q = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число n");
            int n = int.Parse(Console.ReadLine());

            double x=0;
            double x_0 = c;
            double x_1 = d;
            
            for (int i=2; i<=n; i++)
            {
                x = q * x_1 + r * x_0 + b;
                x_0 = x_1;
                x_1 = x;
            }

            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
