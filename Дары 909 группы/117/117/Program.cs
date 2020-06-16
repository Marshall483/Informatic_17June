using System;

namespace _117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task117B(4));
            Console.WriteLine(Task117A(4));



        }
        public static double Task117A(int n)
        {
            var p = 1.0;
            for (int i = 1; i < n; i++)
            {
                p *= ((double)(i*2-1) / (i *2));
            }
            return p;
        }

        public static double Task117B(int n)
        {
            var p = 1.0;
            for (int i = 1; i < n; i++)
            {
                p *= ((double)(i * 2 + 1) / (i + 1));
            }
            return p;
        }

    }
}
