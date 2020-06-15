using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;

namespace Temp
{
    class Program
    {

        static long IncorrectFac(int n) //113
        {
            int start = 1;
            long result = 1;
            if ((n % 2).Equals(1))
                start = 1;
            else start = 2;

            while (start <= n)
            {
                result = result * start;
                start += 2;
            }
            return result;
        }
        static void Main() 
        {

            IncorrectFac(7);//113


            Console.ReadKey();
        }


    }
}
