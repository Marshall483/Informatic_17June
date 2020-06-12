
using System;
using System.Text;

namespace Informatic
{
    class Program
    {
        static double FuncA(int k)
        {
            if (k.Equals(1)) return 1;
            return 1.0/2 * (Math.Sqrt(FuncB(k - 1)) + 1.0/2 * Math.Sqrt(FuncA(k - 1)));
        }

        static double FuncB(int k)
        {
            if (k.Equals(1)) return 1;
            return 2 * Math.Pow(FuncA(k - 1), 2) + FuncB(k - 1);
        }
        static void Main() 
        {

            int n = int.Parse(Console.ReadLine());

            if (n < 2) return;

            double result = 0;
            for (int i = 2; i < n; i++)
                result += FuncA(i) * FuncB(i);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
