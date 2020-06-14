using System;
using System.Collections.Generic;

namespace _103
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = Convert.ToDouble(Console.ReadLine());
            float y;
            y = 0;
            while(true)
            {
                if ((((y+1)/(y+2))-y)<e)
                {
                    Console.WriteLine((y+1)/(y+2));
                    break;
                }
                y = (y + 1) / (y + 2);
            }
            
           
        }
    }
}
