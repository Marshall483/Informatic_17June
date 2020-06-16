using System;

namespace _336_Task
{
    class Program
    {
        public static int Fact(int n)
        {
            int k, f = 1;
            for (k = 1; k <= n; k++)
            {
                f *= k;
            }
            return f;
        }

        static void Main(string[] args)
        {
            //336-A

            //int n, k;
            //double x;
            //Console.Write("n = ");
            //n = int.Parse(Console.ReadLine());
            //Console.Write("x = ");
            //x = double.Parse(Console.ReadLine());

            //double sum = 0;
            //for (k = 1; k <= n; k++)
            //{
            //    sum += (Fact(2 * k) + Math.Abs(x)) / Fact(k * k);
            //}
            //Console.Write("Result : " + sum);

            //336-Б

            //int n, k;
            //double x;
            //Console.Write("n = ");
            //n = int.Parse(Console.ReadLine());
            //Console.Write("x = ");
            //x = double.Parse(Console.ReadLine());

            //double sum = 0;
            //for (k = 1; k <= n; k++)
            //{
            //    sum += Math.Pow(-1, k) * Math.Pow(x, k) / Fact(Fact(k) + 1);
            //}
            //sum *= 1 / Fact(n);

            //Console.Write("Result : " + sum);

            //336-В

            //int n, k;
            //double x;
            //Console.Write("n = ");
            //n = int.Parse(Console.ReadLine());
            //Console.Write("x = ");
            //x = double.Parse(Console.ReadLine());

            //double sum = 0;
            //for (k = 1; k <= n; k++)
            //{
            //    sum += Math.Pow(k,k)*Math.Pow(x,2*k);
            //}
            //Console.Write("Result : " + sum);

            //336-Г

            int n, k;
            double x;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());

            double sum = 0;
            for (k = 1; k <= n; k++)
            {
                for (int m = k; m < n; m++)
                {
                    sum += (x + k) / m;
                }
            }
            Console.Write("Result : " + sum);
        }
    }
}
