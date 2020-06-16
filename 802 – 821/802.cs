using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 802

            string s = Console.ReadLine();
            int count = 0;
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]) == true)
                {
                    count++;
                }
                if (count > max)
                {
                    max = count;
                }
                if (Char.IsDigit(s[i]) == false)
                {
                    count = 0;
                }
            }
            Console.WriteLine(max);
        }
    }
}
