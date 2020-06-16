using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;

namespace Temp
{
    class Program
    {

        static double LongArifm() // 110
        {
            double result = 0;
            int i = 103;

            while (i > 0)
            {
                result = 1 / (result + i);
                i -= 2;
            }

            return result;
        }

        static void Main() 
        {

            LongArifm();//110


            Console.ReadKey();
        }


    }
}
