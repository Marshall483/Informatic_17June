using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111
{
    class Program
    {   
        public static double recures(ref int j, double x)
        {
            j = j + 2;
            if (j ==  256)
            {
            
                return (x * x) + (double)j / (x * x);
            }
            else
            {
                
                return ((x * x) + (j / recures(ref j, x)));
            }
            
        }
        static void Main(string[] args) 
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            int j = 0;
            Console.WriteLine(x/recures(ref j, x));

        }
    }
}
