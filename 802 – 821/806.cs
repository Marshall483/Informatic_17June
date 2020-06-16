using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _806
{
    class Program
    {
        static void Main(string[] args)
        {
            //a
            string bad = ",./';[]{}`~!@#$%$^&*() +|";
            Console.WriteLine("Введите s");
            string s = Console.ReadLine();
            if (s.Any(x=>bad.IndexOf(x) >=0 )) Console.WriteLine("Не идентификатор");
            else Console.WriteLine("идентификатор");
            //
            //b
            Console.WriteLine("Введите s");
            string s1 = Console.ReadLine();
            Regex regex = new Regex(@"[^0-9]+");
            if (regex.IsMatch(s1)) Console.WriteLine("Не число");
            else Console.WriteLine("Число");
            //

        }
    }
}
