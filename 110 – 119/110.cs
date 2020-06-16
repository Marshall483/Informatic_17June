using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
     class Seq
    {
        public static double Sum()
        {
            double a = 1 / 103;
            double n = 101;
            while(n >=1)
            {
                a = 1 / (n + a);
                n = n - 2;
            }
            return a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Exercise 110

            Console.WriteLine(Seq.Sum());
        }
    }
}
