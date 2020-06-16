using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise102
{
    class Program
    {
        static void Main(string[] args)
        {
            double numb = 1;
            double nextnumb = (2 - Math.Pow(numb, 3)) / 5;
            int ind = 0;
            while (Math.Abs(numb - nextnumb) > Math.Pow(10,-5))
            {
                ind++;
                numb = nextnumb;
                nextnumb = (2 - Math.Pow(numb, 3)) / 5;
            }
            Console.WriteLine(@"x{0}  =  {1}", ind, numb);
        }
    }
}
