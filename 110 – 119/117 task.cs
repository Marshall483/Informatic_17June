using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecxercise117
{
    class Program
    {
        static double APoint(int n)
        {
            double num = 1;
            int number = 1;
            for (int i =0; i < n; i++)
            {
                num *= (double)number / (number + 1);
                number += 2;
            }
            Console.WriteLine(num);
            return num;
        }
        static double BPoint(int n)
        {
            double num = 1;
            if (n == 1)
            {
                return num;
            }
            else
            for (int i = 2; i <= n; i++)
            {
                    num *= (double)(2*i-1)/i;
            }
            return (num);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(APoint(n));
            //Console.WriteLine(BPoint(n));
        }
    }
}
