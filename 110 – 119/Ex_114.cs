using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Ex114
{
    class Ex_114
    {
       
        static double ex_A(double n, double b)
        {
            if (n == b)
                return 1 / (n * n);

            var res = 1 / (n * n);
            n++;
            return res + ex_A(n, b);
        }

        static double ex_B(double n, double b)
        {
            if (n == b)
                return 1 / (n * n * n);

            var res = 1 / (n * n * n);
            n++;
            return res + ex_B(n, b);
        }

        static double ex_C(int n, int b)
        {
            if (n == b)
                return 1.0 / factorial(n);

            var res = 1.0 / factorial(n);
            n++;
            return res + ex_C(n, b);
        }

        static int factorial(int i)
        {
            int result;

            if (i == 1)
                return 1;
            result = factorial(i - 1) * i;
            return result;
        }

        static double ex_D(double n, double b)
        {
            if (n == b)
                return 1 / (2 * n * 2 * n);

            var res = 1 / (2 * n * 2 * n);
            n++;
            return res + ex_D(n, b);
        }

        static double ex_E(double n, double b)
        {
            if (n == b)
                return (n * n) / (n * n + 2 * n + 3);

            var res = (n * n) / (n * n + 2 * n + 3);
            n++;
            return res * ex_E(n, b);
        }

        static double ex_F(int n, int b)
        {
            if (n == b)
                return (2.0 + 1.0 / factorial(n));

            var res = (2.0 + 1.0 / factorial(n));
            n++;
            return res * ex_F(n, b);
        }
        
        static double ex_G(int n, int b)
        {
            if (n == b)
                return ((n+1.0) / (n+2.0));

            var res = ((n + 1.0) / (n + 2.0));
            n++;
            return res * ex_G(n, b);
        }

        static double ex_H(int n, int b)
        {
            if (n == b)
                return ((1.0 - 1.0 / factorial(n))* (1.0 - 1.0 / factorial(n)));

            var res = ((1.0 - 1.0 / factorial(n)) * (1.0 - 1.0 / factorial(n)));
            n++;
            return res * ex_H(n, b);
        }

        static void Main(string[] args)
        {

            //A
            Console.WriteLine(ex_A(1, 100));
            

            //Б
            Console.WriteLine(ex_B(1, 50));
           

            //В
            Console.WriteLine(ex_C(1, 10));
            

            //Г
            Console.WriteLine(ex_D(1, 128));
            

            //Д
            Console.WriteLine(ex_E(1, 52));
            

            //Е
            Console.WriteLine(ex_F(1, 10));


            //Ж
            Console.WriteLine(ex_G(2, 100));


            //З
            Console.WriteLine(ex_H(2, 10));
           
            
            Console.ReadKey();
        }
    }
}
